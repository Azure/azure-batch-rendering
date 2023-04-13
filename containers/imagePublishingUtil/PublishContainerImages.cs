using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using CommandLine;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using PublishContainerImages.Model;


namespace PublishContainerImages
{
    class PublishContainerImages
    {
        public static Action<string> WriteLog;
        public static Action<string> WriteError;

        public static string ContainerImagesDefinitionFilename = "containerImage.json";
        public static string BuiltImageMetadataFilename = "rendering-container-images.json";

        public static string TestConfigurationFilename = "testConfiguration.json";
        public static string TestParametersFilename = "testParameters.json";
        public static string ProdImagesFilename = "prodAcrImages.txt";
        public static string TestImagesFilename = "testImages.txt";

        private const string LogFilename = "publishContainerImages.log";

        public static string DockerInstallScriptsRootDir { get; private set; }

        public static string BatchExtensionTemplatesRootDir { get; private set; }

        public static string StorageAccountName { get; private set; }

        public static string StorageContainerName { get; private set; }

        public static string RelativePathFromRunnerDir { get; private set; }

        private static string[] ParseTargetRelativeDirs(string targetRelativeDirs)
        {
            var targetRelativeDir = targetRelativeDirs == "/" ? string.Empty : targetRelativeDirs;
            var targetRelativeDirsSplit = targetRelativeDir.Replace(" ", "").Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
            return targetRelativeDirsSplit;
        }


        private static StreamWriter _log;

        static int Main(string[] args)
        {
            using (var log = File.AppendText(LogFilename))
            {
                    _log = log;
                    _log.AutoFlush = true;
                    WriteLog = _writeLog;
                    WriteError = _writeError;

                    return Parser.Default.ParseArguments<PublishOptions, TestOnlyOptions, MergeJsonOptions>(args)
                        .MapResult(
                            (PublishOptions opts) => RunPublish(opts),
                            (TestOnlyOptions opts) => RunTestOnly(opts),
                            (MergeJsonOptions opts) => RunMergeJson(opts),
                            errs => 1);
            }
        }

        public static List<string> PrettyStringObjectProperties<T>(T options)
        {
            var optionValues = new List<string>();
            foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
            {
                if (propertyInfo.CanRead)
                {
                    optionValues.Add($"{propertyInfo.Name}: {propertyInfo.GetValue(options, null)}");
                }
            }

            return optionValues;
        }

        public static int RunPublish(PublishOptions options)
        {
            try
            {
                var optionValues = PrettyStringObjectProperties(options);
                var targetRelativeDirs = ParseTargetRelativeDirs(options.TargetRelativeDirs);

                _writeLog($"Beginning Publishing Run with environment:\n{string.Join("\n", optionValues)}");

                DockerInstallScriptsRootDir = options.DockerInstallScriptsRootDir;

                BatchExtensionTemplatesRootDir = options.BatchExtensionTemplatesRootDir;

                StorageAccountName = options.StorageAccountName;

                StorageContainerName = options.StorageContainerName;

                var testRepoRegistry = options.TestRepoBase.Split('/')[0];

                var blobContainer =
                    _buildBlobClient(StorageAccountName, options.StorageKey,
                        StorageContainerName); //NOTE blobContainer will be null if !buildImages

                var containerImagePayload = DirectoryTraversal.BuildFullPayloadFromDirectoryTree(
                    options.AcrRepoBase,
                    options.TestRepoBase,
                    options.ProdRepoBase,
                    DockerInstallScriptsRootDir,
                    targetRelativeDirs,
                    options.IncludeAntecendentsBool,
                    options.IncludeDescendentsBool,
                    options.BuildVersion,
                    true);

                _writePrePublishLog(containerImagePayload);
                var imageNumber = 1;
                var prodImages = new List<string>();
                var testImages = new List<string>();
                var builtContainerImages = new List<OutputContainerImage>();

                foreach (var payload in containerImagePayload)
                {
                    var imageDef = payload.ContainerImageDefinition;
                    dynamic blobProperties = _getBlobUriWithSasTokenAndMD5(imageDef.InstallerFileBlob, blobContainer);

                    string devTag = ImageTagging.BuildDevImageTag(options.ReleaseName, blobProperties.blobMD5, options.GitCommitSha, imageDef.VersionTag);

                    _writeLog($"Building #{imageNumber++} of {containerImagePayload.Count} \n" +
                              $" - Prod-ImageName: {imageDef.ProdRepoName}:{imageDef.VersionTag}\n" +
                              $" - PreProd-ImageName: {imageDef.AcrRepoName}:{imageDef.VersionTag}\n" +
                              $" - Test-RepoName: {imageDef.TestRepoName}:{devTag}\n");

                    var localImageId = _buildImage(options.AcrRepoBase, DockerInstallScriptsRootDir, imageDef,
                        blobProperties.blobSasToken);

                    var testImage = $"{imageDef.TestRepoName}:{devTag}";
                    DockerCommands._runDockerTag(localImageId, testImage);
                    testImages.Add(testImage);
                    _writeLog($"Successfully built and tagged {testImage}");

                    var prodImage = $"{imageDef.AcrRepoName}:{imageDef.VersionTag}";
                    DockerCommands._runDockerTag(localImageId, prodImage);
                    prodImages.Add(prodImage);
                    _writeLog($"Successfully built and tagged {prodImage}");

                    var outputImage = new OutputContainerImage
                    {
                        AcrRepoName = imageDef.AcrRepoName,
                        TestRepoName = imageDef.TestRepoName,
                        ProdRepoName = imageDef.ProdRepoName,
                        Metadata = imageDef.Metadata,
                        DevTag = devTag,
                        VersionTag = imageDef.VersionTag,
                        PathToDockerfile = imageDef.PathToDockerFile,
                        Payload = payload,
                        TestContainerImage = $"{imageDef.TestRepoName}:{devTag}"
                    };
                    builtContainerImages.Add(outputImage);

                    if (options.PushTestImagesBool)
                    {
                        DockerCommands._runDockerPush(outputImage.TestContainerImage);
                        _writeLog($"Successfully pushed {testImage}\n");
                    }
                }

                OutputFileWriter._outputTestFiles(options.TestRepoUsername, options.TestRepoPassword, testRepoRegistry,
                    BatchExtensionTemplatesRootDir, builtContainerImages, testImages);
                OutputFileWriter._outputTestImagesFile(testImages);
                OutputFileWriter._outputProdImagesFile(prodImages);
                OutputFileWriter._outputContainerImageMetadataFile(builtContainerImages,
                    options.OutputFullMetadataFileBool);
                OutputFileWriter.UpdateVersionFiles(DockerInstallScriptsRootDir, builtContainerImages);

                _writeLog($"Completed Publishing Successfully!\n\n");
                return 0;
            }
            catch (Exception ex)
            {
                _writeError("Fatal Exception: " + ex);
                return 1;
            }
        }

        public static int RunTestOnly(TestOnlyOptions options)
        {
            try
            {
                var optionValues = PrettyStringObjectProperties(options);
                var targetRelativeDirs = ParseTargetRelativeDirs(options.TargetRelativeDirs);

                _writeLog($"Beginning Test Run with environment:\n{string.Join("\n", optionValues)}");

                DockerInstallScriptsRootDir = options.DockerInstallScriptsRootDir;

                BatchExtensionTemplatesRootDir = options.BatchExtensionTemplatesRootDir;

                var testRepoRegistry = options.TestRepoBase.Split('/')[0];

                var containerImagePayload = DirectoryTraversal.BuildFullPayloadFromDirectoryTree(
                    "",
                    options.TestRepoBase,
                    "",
                    DockerInstallScriptsRootDir,
                    targetRelativeDirs,
                    options.IncludeAntecendentsBool,
                    options.IncludeDescendentsBool,
                    "unused",
                    false);

                _writePrePublishLog(containerImagePayload);
                var imageNumber = 1;
                var prodImages = new List<string>();

                //not building images, just output the test files
                prodImages = containerImagePayload
                    .Select(x => x.ContainerImageDefinition.ProdContainerImageWithVersionTag).ToList();

                var outputContainerImages = new List<OutputContainerImage>();
                foreach (var payload in containerImagePayload)
                {
                    outputContainerImages.Add(new OutputContainerImage
                    {
                        TestRepoName =
                            payload.ContainerImageDefinition
                                .AcrRepoName, //here we are just testing the current prod images
                        Metadata = payload.ContainerImageDefinition.Metadata,
                        VersionTag = payload.ContainerImageDefinition.VersionTag,
                        PathToDockerfile = payload.ContainerImageDefinition.PathToDockerFile,
                        Payload = payload,
                        TestContainerImage =payload.ContainerImageDefinition.TestContainerImageWithVersionTag
                    });
                }

                OutputFileWriter._outputTestFiles(options.TestRepoUsername, options.TestRepoPassword, testRepoRegistry,
                    BatchExtensionTemplatesRootDir, outputContainerImages, prodImages);
                _writeLog($"Completed Generating Test Files!\n\n");
                return 0;
            }
            catch (Exception ex)
            {
                _writeError("Fatal Exception: " + ex);
                return 1;
            }
        }

        public static int RunMergeJson(MergeJsonOptions options)
        {
            try
            {
                var optionValues = PrettyStringObjectProperties(options);

                _writeLog($"Beginning MergeJson Run with environment:\n{string.Join("\n", optionValues)}");

                MergeRenderingContainerImagesJson.MergeJson(options.MasterFile, options.NewImagesFile, options.OutputFile, options.ExclusivelyForApp);

                return 0;
            }
            catch (Exception ex)
            {
                _writeError("Fatal Exception: " + ex);
                return 1;
            }
        }

        private static void _writePrePublishLog(List<ContainerImagePayload> containerImages)
        {
            var imageListLog = ($"Loaded {containerImages.Count} containerImages:\n");
            containerImages.ForEach(image => imageListLog += image.ContainerImageDefinition.ContainerImage + "\n");
            _writeLog(imageListLog);
        }
   
        private static void _writeLog(string log)
        {
            var logLine = string.Format(@"{0}: {1}", DateTime.UtcNow.ToShortDateString() + " " + DateTime.UtcNow.ToLongTimeString(), log);
            _log.WriteLine(logLine);
            Console.WriteLine(log);
        }

        private static void _writeError(string error)
        {
            var logLine = string.Format(@"{0}: ERROR: {1}", DateTime.UtcNow.ToShortDateString() + " " + DateTime.UtcNow.ToLongTimeString(), error);
            _log.WriteLine(logLine);
            Console.WriteLine($"ERROR: {error}");
        }

        private static string _buildImage(string acrServerRepo, string dockerInstallScriptsRootDir, ContainerImageDefinition imageDefinition, string blobSasToken)
        {
            var dockerBuildOutput = DockerCommands._runDockerBuild(acrServerRepo, dockerInstallScriptsRootDir, blobSasToken, imageDefinition);

            var localImageId = _imageIdFromDockerBuildOutput(dockerBuildOutput);

            return localImageId;
        }

        private static string _imageIdFromDockerBuildOutput(string[] output)
        {
            var keyLine = output.First(line => line.StartsWith("Successfully built "));

            var imageId = keyLine.Substring("Successfully built ".Length);

            return imageId;
        }

        private static CloudBlobContainer _buildBlobClient(string storageAccountName, string storageKey, string containerName)
        {
            var storageUri = new Uri($"https://{storageAccountName}.blob.core.windows.net/");

            var storageClient = new CloudBlobClient(storageUri, new StorageCredentials(storageAccountName, storageKey));

            return storageClient.GetContainerReference(containerName);
        }

        private static dynamic _getBlobUriWithSasTokenAndMD5(string blobPath, CloudBlobContainer blobContainer)
        {
            if (string.IsNullOrEmpty(blobPath))
            {
                return new { blobSasToken = string.Empty, blobMD5 = string.Empty };
            }

            var blob = blobContainer.GetBlockBlobReference(blobPath);

            var sasConstraints =
                new SharedAccessBlobPolicy
                {
                    SharedAccessStartTime = DateTimeOffset.UtcNow.AddMinutes(-5),
                    SharedAccessExpiryTime = DateTimeOffset.UtcNow.AddHours(24),
                    Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.Write
                };

            var sasBlobToken = blob.GetSharedAccessSignature(sasConstraints);

            blob.FetchAttributesAsync().GetAwaiter().GetResult();

            return new { blobSasToken = blob.Uri + sasBlobToken, blobMD5 = blob.Properties.ContentMD5 };
        }
    }
}
