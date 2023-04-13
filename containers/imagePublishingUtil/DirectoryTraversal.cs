using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.WindowsAzure.Storage;
using Newtonsoft.Json;
using PublishContainerImages.Model;

namespace PublishContainerImages
{
    static class DirectoryTraversal
    {
        public static List<ContainerImagePayload> BuildFullPayloadFromDirectoryTree(string acrRepoBase, string testRepoBase, string prodRepoBase, string dockerInstallScriptsRootDir, string[] targetRelativeDirs, bool includeAntecendents, bool includeDescendents, string buildVersion, bool buildImages)
        {
            var payloads = new List<ContainerImagePayload>();
            foreach (var targetRelativeDir in targetRelativeDirs)
            {
                var targetDirectory = new DirectoryInfo(Path.Combine(dockerInstallScriptsRootDir, targetRelativeDir));
                List<DirectoryInfo> directoryInfosToBuild = new List<DirectoryInfo>();
                if (includeAntecendents)
                {
                    directoryInfosToBuild.AddRange(DirectoryInfosForAntecendents(targetDirectory));
                }

                if (includeDescendents)
                {
                    AddDirectoryInfosForTargetAndDescendents(targetDirectory, directoryInfosToBuild);
                }
                else
                {
                    directoryInfosToBuild.Add(targetDirectory);
                }

                payloads.AddRange(DirectoryInfosToPayloads(acrRepoBase, testRepoBase, prodRepoBase,
                    dockerInstallScriptsRootDir, directoryInfosToBuild, buildVersion, buildImages));
            }

            return payloads.Where(payload => payload.ContainerImageDefinition != null).ToList();
        }

        private static List<ContainerImagePayload> DirectoryInfosToPayloads(string acrRepoBase, string testRepoBase, string prodRepoBase, string dockerInstallScriptsRootDir, List<DirectoryInfo> directoryInfos, string newBuildVersion, bool buildImages)
        {
            if (buildImages)
            {
                return ImagePayloadWhenBuildingImages(acrRepoBase, testRepoBase, prodRepoBase,dockerInstallScriptsRootDir, directoryInfos, newBuildVersion);
            }

            return ImagePayloadWhenNotBuildingImages(acrRepoBase, testRepoBase, prodRepoBase, directoryInfos);
            
        }

        private static List<ContainerImagePayload> ImagePayloadWhenBuildingImages(string acrRepoBase, string testRepoBase, string prodRepoBase, string dockerInstallScriptsRootDir, List<DirectoryInfo> directoryInfos, string newBuildVersion)
        {
            List<ContainerImagePayload> payloads = new List<ContainerImagePayload>();

            foreach (var di in directoryInfos)
            {
                if (directoryInfos.Find(otherDir => otherDir.FullName == di.Parent?.FullName) != null)
                {
                    //we are building both the parent and the child image in this release
                    var rootDirInfo = new DirectoryInfo(dockerInstallScriptsRootDir);
                    var pathToDockerFileOfParent =
                        di.Parent?.FullName.Replace(rootDirInfo.FullName, "").TrimStart('\\');

                    var parentPayload = payloads.Find(p =>
                        p.ContainerImageDefinition.PathToDockerFile == pathToDockerFileOfParent);

                    var payload = PayloadForDirectory(acrRepoBase, testRepoBase, prodRepoBase, di, newBuildVersion,
                        parentPayload.ContainerImageDefinition.VersionTag);

                    payloads.Add(payload);
                }
                else
                {
                    if (di.Parent != null)
                    {
                        //we aren't building the parent, so use the parent tag from the version file in the directory above
                        var parentVersion = TryReadVersionFileForDirectory(di.Parent);

                        var payload = PayloadForDirectory(acrRepoBase, testRepoBase, prodRepoBase, di, newBuildVersion, parentVersion);

                        payloads.Add(payload);
                    }
                    else
                    {
                        //we are building a top level image so there is no parent
                        var payload = PayloadForDirectory(acrRepoBase, testRepoBase, prodRepoBase, di, newBuildVersion);
                        payloads.Add(payload);
                    }
                }
            }

            return payloads;
        }

        private static List<ContainerImagePayload> ImagePayloadWhenNotBuildingImages(string acrRepoBase, string testRepoBase, string prodRepoBase, List<DirectoryInfo> directoryInfos)
        {
            List<ContainerImagePayload> payloads = new List<ContainerImagePayload>();

            foreach (var di in directoryInfos)
            {
                //we aren't building the images, so read the version file for both parent and child
                var childVersionTag = TryReadVersionFileForDirectory(di);
                if (childVersionTag == null)
                {
                    PublishContainerImages.WriteError($"No version found in target directory {di.FullName}");
                    throw new FileNotFoundException($"No version file found in target directory {di.FullName}");
                }
                if (di.Parent != null)
                {
                    var parentVersion = TryReadVersionFileForDirectory(di.Parent);
                    //we aren't building the parent, so use the parent tag from the version file in the directory above
                    var payload = PayloadForDirectory(acrRepoBase, testRepoBase, prodRepoBase, di, ExtractBuildVersionFromFullTag(childVersionTag), parentVersion);

                    payloads.Add(payload);
                }
            }

            return payloads;
        }

        private static string ExtractBuildVersionFromFullTag(string versionTag)
        {
            //the below requires build version to be in format e.g. 1.0.0.parentImage-12.34.56.thisFinalImage
            var startIndex = versionTag.LastIndexOf('-') + 1;
            var indexOfFinalDotInString = versionTag.LastIndexOf('.');
            var versionStringLength = indexOfFinalDotInString - startIndex;
            var version = versionTag.Substring(startIndex, versionStringLength);
            return version;
        }

        private static string TryReadVersionFileForDirectory(DirectoryInfo di)
        {
            var versionFile = di.EnumerateFiles().FirstOrDefault(file => file.Name == "version");
            if (versionFile == null)
            {
                return null;
            }
            var versionFileLines = File.ReadAllLines(versionFile.FullName);
            return versionFileLines.First();
        }


        private static List<DirectoryInfo> DirectoryInfosForAntecendents(DirectoryInfo root)
        {
            var topDirectory = _findTopDirectoryContainingContainerImageJson(root);
            var bottomDirectory = root;

            if (bottomDirectory.FullName == topDirectory.FullName)
            {
                return new List<DirectoryInfo>();
            }

            var directoryInfo = new List<DirectoryInfo>();
            do
            {
                bottomDirectory = bottomDirectory.Parent;
                directoryInfo.Add(bottomDirectory);
            } while (bottomDirectory != null && bottomDirectory.FullName != topDirectory.FullName);
            
            directoryInfo.Reverse(); //we need build order to have top level directories first

            return directoryInfo.ToList();
        }

        private static List<DirectoryInfo> AddDirectoryInfosForTargetAndDescendents(DirectoryInfo root, List<DirectoryInfo> toBuild)
        {
            toBuild.Add(root);

            var subDirs = root.GetDirectories();

            foreach (var dirInfo in subDirs)
            {
                AddDirectoryInfosForTargetAndDescendents(dirInfo, toBuild);
            }

            return toBuild;
        }

        private static ContainerImagePayload PayloadForDirectory(string acrRepoBase, string testRepoBase, string prodRepoBase, DirectoryInfo directory, string buildVersion)
        {
            return PayloadForDirectory(acrRepoBase, testRepoBase, prodRepoBase, directory, buildVersion, null);
        }

        private static ContainerImagePayload PayloadForDirectory(string acrRepoBase, string testRepoBase, string prodRepoBase, DirectoryInfo directory, string buildVersion, string parentVersionTag)
        {
            var containerImageDefinition = ReadContainerImageDefinition(directory);
            containerImageDefinition.BuildVersion = buildVersion;
            containerImageDefinition.ParentVersionTag = parentVersionTag;
            containerImageDefinition.VersionTag = ImageTagging.BuildVersionTag(containerImageDefinition.ContainerImage, containerImageDefinition.ParentVersionTag, containerImageDefinition.BuildVersion);
            var testConfigAndParams = TryReadTestConfigAndParams(directory);

            containerImageDefinition.SubstituteValuesIntoRepoString(acrRepoBase, testRepoBase, prodRepoBase);

            return new ContainerImagePayload
            {
                ContainerImageDefinition = containerImageDefinition,
                TestConfigurationDefinition = testConfigAndParams.Item1,
                TestParametersDefinition = testConfigAndParams.Item2,
            };
        }
         
        private static DirectoryInfo _findTopDirectoryContainingContainerImageJson(DirectoryInfo root)
        {
            DirectoryInfo lastDir = root;
            while (_fileInfoForContainerImageDefinition(root) != null)
            {
                lastDir = root;
                root = root.Parent;
            }

            return lastDir;
        }

        private static FileInfo _fileInfoForContainerImageDefinition(DirectoryInfo root)
        {
            FileInfo fileInfo = null;

            try
            {
                fileInfo = root.GetFiles(PublishContainerImages.ContainerImagesDefinitionFilename).Single();
            }
            catch (UnauthorizedAccessException e)
            {
                PublishContainerImages.WriteError(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                PublishContainerImages.WriteError(e.Message);
            }
            catch (ArgumentNullException e)
            {
                PublishContainerImages.WriteError(e.Message);
            }
            catch (InvalidOperationException e)
            {
                PublishContainerImages.WriteError(e.Message);
            }

            return fileInfo;
        }

        

        private static ContainerImageDefinition ReadContainerImageDefinition(DirectoryInfo directory)
        {
            var containerDefinitionFileInfo = _fileInfoForContainerImageDefinition(directory);

            if (containerDefinitionFileInfo != null)
            {
                ContainerImageDefinition containerImageDefinition;
                dynamic json = Json.ReadJsonFileToDynamic(containerDefinitionFileInfo.FullName);
                try
                {
                    containerImageDefinition = json.ToObject<ContainerImageDefinition>();
                    containerImageDefinition.PathToDockerFile = System.IO.Path.GetRelativePath(
                        PublishContainerImages.DockerInstallScriptsRootDir, directory.FullName);
                }
                catch (JsonSerializationException ex)
                {
                    PublishContainerImages.WriteError(
                        $"Invalid Json read in file {containerDefinitionFileInfo}, Json was: {json}. Exception: {ex}");
                    throw;
                }
                return containerImageDefinition;
            }

            return null;
        }

        private static Tuple<TestConfigurationDefinition, ExpandoObject> TryReadTestConfigAndParams(DirectoryInfo directory)
        {
            var testConfigFiles = directory.GetFiles(PublishContainerImages.TestConfigurationFilename);
            var testParamsFiles = directory.GetFiles(PublishContainerImages.TestParametersFilename);

            if (!testConfigFiles.Any())
            {
                PublishContainerImages.WriteLog($"TestConfiguration.json not found in directory {directory}, no test will be run for this path.");
                return new Tuple<TestConfigurationDefinition, ExpandoObject>(null, null);
            }

            if (!testParamsFiles.Any())
            {
                PublishContainerImages.WriteLog($"TestParameters.json not found in directory {directory}, no test will be run for this path.");
                return new Tuple<TestConfigurationDefinition, ExpandoObject>(null, null);
            }

            if (testConfigFiles.Length > 1)
            {
                PublishContainerImages.WriteLog($"More than one TestConfiguration.json file found in {directory}, no test will be run for this path.");
                return new Tuple<TestConfigurationDefinition, ExpandoObject>(null, null);
            }

            if (testParamsFiles.Length > 1)
            {
                PublishContainerImages.WriteLog($"More than one TestParameters.json file found in {directory}, no test will be run for this path.");
                return new Tuple<TestConfigurationDefinition, ExpandoObject>(null, null);
            }

            var testConfigJson = Json.ReadJsonFileToDynamic(testConfigFiles.Single().FullName);
            TestConfigurationDefinition testConfig;
            ExpandoObject testParams;

            try
            {
                testConfig = testConfigJson.ToObject<TestConfigurationDefinition>();
            }
            catch (JsonSerializationException ex)
            {
                PublishContainerImages.WriteError($"Invalid Json read in file {testConfigFiles.Single().FullName}, no test will be run for this path. Json was: {testConfigJson}. Exception: {ex}");
                return new Tuple<TestConfigurationDefinition, ExpandoObject>(null, null);
            }

            var testParamsJson = Json.ReadJsonFileToDynamic(testParamsFiles.Single().FullName);

            try
            {
                testParams = testParamsJson.ToObject<ExpandoObject>();
            }
            catch (JsonSerializationException ex)
            {
                PublishContainerImages.WriteError($"Invalid Json read in file {testParamsJson.Single().FullName}, no test will be run for this path. Json was: {testParamsJson}. Exception: {ex}");
                return new Tuple<TestConfigurationDefinition, ExpandoObject>(null, null);
            }

            return new Tuple<TestConfigurationDefinition, ExpandoObject>(testConfig, testParams);
        }
    }
}

