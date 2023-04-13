using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;
using CommandLine.Text;

namespace PublishContainerImages
{
    public abstract class OptionsBase {

        protected bool TryParseAsBool(string toParse)
        {
            return bool.Parse(toParse.First().ToString().ToUpper() + toParse.Substring(1));
        }
    }

    [Verb("publish", HelpText = "Build, Test and Publish the images.")]
    class PublishOptions : OptionsBase
    {
        [Option(Required = true)] public string TargetRelativeDirs { get; set; }

        [Option(Required = true)] public string BuildVersion { get; set; }

        [Option(Required = false, Default= "renderingapplications")]
        public string StorageAccountName { get; set; }

        [Option(Required = false, Default = "batch-rendering-apps")]
        public string StorageContainerName { get; set; }

        [Option(Required = true)] public string StorageKey { get; set; }

        [Option(Required = true)] public string ProdRepoBase { get; set; }

        [Option(Required = true)] public string AcrRepoBase { get; set; }

        [Option(Required = true)] public string TestRepoBase { get; set; }

        [Option(Required = true)] public string TestRepoUsername { get; set; }

        [Option(Required = true)] public string TestRepoPassword { get; set; }

        [Option(Required = true)] public string BatchExtensionTemplatesRootDir { get; set; }

        [Option(Required = true)] public string DockerInstallScriptsRootDir { get; set; }

        [Option(Required = true)] public string IncludeAntecendents { get; set; }
        public bool IncludeAntecendentsBool => TryParseAsBool(IncludeAntecendents);

        [Option(Required = true)] public string IncludeDescendents { get; set; }
        public bool IncludeDescendentsBool => TryParseAsBool(IncludeDescendents);

        [Option(Required = true)] public string GitCommitSha { get; set; }

        [Option(Required = true)] public string ReleaseName { get; set; }

        [Option(Required = true)] public string PushTestImages { get; set; }
        public bool PushTestImagesBool => TryParseAsBool(PushTestImages);

        [Option(Required = true)] public string OutputFullMetadataFile { get; set; }
        public bool OutputFullMetadataFileBool => TryParseAsBool(OutputFullMetadataFile);
    }

    [Verb("test", HelpText = "Run Tests only against current Prod image versions.")]
    class TestOnlyOptions : OptionsBase
    {
        [Option(Required = true)] public string TargetRelativeDirs { get; set; }

        [Option(Required = true)] public string TestRepoBase { get; set; }

        [Option] public string TestRepoUsername { get; set; }

        [Option] public string TestRepoPassword { get; set; }

        [Option(Required = true)] public string BatchExtensionTemplatesRootDir { get; set; }

        [Option(Required = true)] public string DockerInstallScriptsRootDir { get; set; }

        [Option(Required = true)] public string IncludeAntecendents { get; set; }
        public bool IncludeAntecendentsBool => TryParseAsBool(IncludeAntecendents);

        [Option(Required = true)] public string IncludeDescendents { get; set; }
        public bool IncludeDescendentsBool => TryParseAsBool(IncludeDescendents);
    }

    [Verb("mergejson", HelpText = "Merge rendering-container-images.json.")]
    class MergeJsonOptions : OptionsBase
    {
        [Option(Required = true)] public string MasterFile { get; set; }

        [Option(Required = true)] public string NewImagesFile { get; set; }

        [Option(Required = true)] public string OutputFile { get; set; }

        [Option(Required = false)] public string ExclusivelyForApp { get; set; }
    }
}