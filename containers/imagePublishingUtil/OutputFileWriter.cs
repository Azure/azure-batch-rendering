using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json.Linq;
using PublishContainerImages.Model;

namespace PublishContainerImages
{
    class OutputFileWriter
    {
        private const string RelativePathToTestsDir = "OutputTests";
        private const string TemplatesDirectory = "Templates";
        private const string RelativePathToImageTxtDir = "OutputImages";

        public static void _outputProdImagesFile(List<string> latestImages)
        {
            PublishContainerImages.WriteLog($"\nWriting the following entries to {PublishContainerImages.ProdImagesFilename}:"); 
            latestImages.ForEach(PublishContainerImages.WriteLog);
            var builtImagesFilePath = Path.Combine(OutputImagesTxtFilePath(), PublishContainerImages.ProdImagesFilename);
            Directory.CreateDirectory(new FileInfo(builtImagesFilePath).DirectoryName);
            File.WriteAllLines(builtImagesFilePath, latestImages);
        }

        public static void _outputTestImagesFile(List<string> testImages)
        {
            PublishContainerImages.WriteLog($"\nWriting the following entries to {PublishContainerImages.TestImagesFilename}:");
            testImages.ForEach(PublishContainerImages.WriteLog);
            var builtImagesFilePath = Path.Combine(OutputImagesTxtFilePath(), PublishContainerImages.TestImagesFilename);
            Directory.CreateDirectory(new FileInfo(builtImagesFilePath).DirectoryName);
            File.WriteAllLines(builtImagesFilePath, testImages);
        }

        public static void _outputContainerImageMetadataFile(List<OutputContainerImage> builtImages, bool outputFullMetadataFile)
        {
            PublishContainerImages.WriteLog($"\nWriting the following entries to {PublishContainerImages.BuiltImageMetadataFilename}:");
            builtImages.Select(x => 
                $"{x.ProdRepoName}:{x.VersionTag}")
                .ToList().ForEach(PublishContainerImages.WriteLog);

            var builtImagesFilePath = Path.Combine(OutputImagesTxtFilePath(), PublishContainerImages.BuiltImageMetadataFilename);
            Directory.CreateDirectory(new FileInfo(builtImagesFilePath).DirectoryName);

            var imagesWithMetadata = builtImages.Where(im => im.Metadata != null).ToList();

            dynamic metaDataOutput = new ExpandoObject();
            if (outputFullMetadataFile)
            {
                metaDataOutput.imageReferences = ImageReference.GetAllImageReferences();
            }

            metaDataOutput.containerImages = new dynamic[imagesWithMetadata.Count];

            int index = 0;
            foreach (var image in imagesWithMetadata)
            {
                dynamic imageEntry = new ExpandoObject();
                imageEntry.containerImage = $"{image.ProdRepoName}:{image.VersionTag}";
                imageEntry.os = image.Metadata.Os;
                imageEntry.app = image.Metadata.App;
                imageEntry.appVersion = image.Metadata.AppVersion;
                imageEntry.renderer = image.Metadata.Renderer;
                imageEntry.rendererVersion = image.Metadata.RendererVersion;
                imageEntry.imageReferenceId = image.Metadata.ImageReferenceId;

                metaDataOutput.containerImages[index++] = imageEntry;
            }

            string metadataJson = Json.JsonSerializeObject(metaDataOutput);
            File.WriteAllText(builtImagesFilePath, metadataJson);
            PublishContainerImages.WriteLog($"\nWrote metadata file at: {builtImagesFilePath}, file contents:");
            PublishContainerImages.WriteLog(metadataJson);
        }

        public static void _outputTestFiles(string testRepoUsername, string testRepoPassword, string testRepoRegistry, string batchExtensionTemplatesRootDir, List<OutputContainerImage> imageDefinitions, List<string> imagesWithTagsToTest)
        {
            PublishContainerImages.WriteLog($"\nWriting test files for the following images:\n { string.Join("\n", imageDefinitions.Select(image => image.TestContainerImage))}");

            var imagesWithTests = _removeInvalidPayloads(imageDefinitions);
            var updatedImageDefinitions = _updateTestConfigAndParametersWithTaggedImage(imagesWithTests);

            updatedImageDefinitions.ForEach(payload =>
            {
                var parametersPath = Path.Combine(OutputTestPath(), payload.Payload.TestConfigurationDefinition.GetParametersFileName());
                var parametersJson = Json.JsonSerializeObject(payload.Payload.TestParametersDefinition);

                FileInfo paramsFile = new FileInfo(parametersPath);
                Directory.CreateDirectory(paramsFile.DirectoryName);
                File.WriteAllText(parametersPath, parametersJson);
                PublishContainerImages.WriteLog($"\nWrote parameters file at: {paramsFile.FullName}, file contents:");
                PublishContainerImages.WriteLog(parametersJson);
            });

            updatedImageDefinitions.ForEach(payload =>
            {
                var runnerDirectory = Path.Combine(ExecutableDirectory(), batchExtensionTemplatesRootDir, "runner");
                var poolTemplateOriginalFullPath = Path.Combine(runnerDirectory, payload.Payload.TestConfigurationDefinition.PoolTemplate);
                var poolTemplateDynamic = Json.ReadJsonFileToDynamic(poolTemplateOriginalFullPath);

                if (!string.IsNullOrEmpty(testRepoUsername))
                {
                    var containerRegistries = JArray.FromObject(new[]
                    {
                        new
                        {
                            username = testRepoUsername, password = testRepoPassword, registryServer = testRepoRegistry
                        }
                    });

                    poolTemplateDynamic.variables.osType.containerConfiguration.containerRegistries = containerRegistries;
                }

                var poolTemplateJson = Json.JsonSerializeObject(poolTemplateDynamic);

                var relativeFinalPathForPoolTemplate = payload.Payload.TestConfigurationDefinition.PoolTemplate.Replace("../", "");
                var poolTemplateFinalPath = Path.Combine(OutputTestPath(), relativeFinalPathForPoolTemplate);
                
                payload.Payload.TestConfigurationDefinition.PoolTemplate = poolTemplateFinalPath.Replace("\\", "/");

                FileInfo poolTemplateFinal = new FileInfo(poolTemplateFinalPath);
                Directory.CreateDirectory(poolTemplateFinal.DirectoryName);
                File.WriteAllText(poolTemplateFinalPath, poolTemplateJson);
                PublishContainerImages.WriteLog($"\nWrote pool template file at: {poolTemplateFinalPath}, file contents:");
                PublishContainerImages.WriteLog(poolTemplateJson);
            });

            var testsConfiguration = new TestsDefinition
            {
                Tests = updatedImageDefinitions.Select(payload =>
                {
                    var config = payload.Payload.TestConfigurationDefinition;
                    config.Parameters = Path.Combine(OutputTestPath(), config.GetParametersFileName()).Replace("\\", "/");
                    return config;
                }).ToArray(),
                Images = new[]
                {
                    new TestMarketplaceImageDefinition
                    {
                        Offer = "microsoft-azure-batch",
                        OsType = "linux",
                        Publisher = "centos-container",
                        Sku = "7-5",
                        Version =  "latest",
                    },
                    new TestMarketplaceImageDefinition
                    {
                        Offer = "microsoft-azure-batch",
                        OsType = "linux",
                        Publisher = "ubuntu-server-container",
                        Sku = "16-04-lts",
                        Version =  "latest",
                    }
                }
            };

            var testsConfigurationFilepath = Path.Combine(OutputTestPath(), PublishContainerImages.TestConfigurationFilename);
            var testsConfigurationJson = Json.JsonSerializeObject(testsConfiguration);

            FileInfo configFile = new FileInfo(testsConfigurationFilepath);
            Directory.CreateDirectory(configFile.DirectoryName);
            File.WriteAllText(testsConfigurationFilepath, testsConfigurationJson);
            PublishContainerImages.WriteLog($"\nWrote configuration file at: {configFile.FullName}, file contents:");
            PublishContainerImages.WriteLog(testsConfigurationJson);
        }

        public static void UpdateVersionFiles(string rootDir, List<OutputContainerImage> asBuilt)
        {
            foreach (var image in asBuilt)
            {
                File.WriteAllText(Path.Combine(rootDir, image.PathToDockerfile, "version"), image.VersionTag);
            }
        }

        private static List<OutputContainerImage> _removeInvalidPayloads(List<OutputContainerImage> images)
        {
            return images.Where(image =>
                image.Payload.TestConfigurationDefinition != null && image.Payload.TestParametersDefinition != null).ToList();
        }

        private static List<OutputContainerImage> _updateTestConfigAndParametersWithTaggedImage(List<OutputContainerImage> images)
        {
            foreach (var image in images)
            {
                image.Payload.TestParametersDefinition.containerImage = new ExpandoObject();
                image.Payload.TestParametersDefinition.containerImage.value = image.TestContainerImage;
                image.Payload.TestConfigurationDefinition.DockerImage = image.TestContainerImage;
            }

            return images;
        }

        private static string OutputTestPath()
        {
            return Path.GetFullPath(Path.Combine(ExecutableDirectory(), RelativePathToTestsDir));
        }

        private static string ExecutableDirectory()
        {
            var locationUri = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            var executableDirectory = new FileInfo(locationUri.AbsolutePath).Directory;

            return executableDirectory?.FullName;
        }

            private static string OutputImagesTxtFilePath()
        {
            var locationUri = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            var executableDirectory = new FileInfo(locationUri.AbsolutePath).Directory;

            return Path.GetFullPath(Path.Combine(executableDirectory.FullName, RelativePathToImageTxtDir));
        }
    }
}
