namespace PublishContainerImages.Model
{
    class ContainerImageDefinition
    {
        public string ContainerImage { get; set; }

        public void SubstituteValuesIntoRepoString(string acrRepoBase, string testRepoBase, string prodRepoBase)
        {
            AcrRepoName = RepoString.Replace("$REPO_BASE", acrRepoBase);
            TestRepoName = RepoString.Replace("$REPO_BASE", testRepoBase);
            ProdRepoName = RepoString.Replace("$REPO_BASE", prodRepoBase);
        }

        public ContainerImageMetadata Metadata { get; set; }

        public string BuildVersion { get; set; }    //the version of the current build

        public string VersionTag { get; set; }    //the version of the current build

        public string ParentVersionTag { get; set; }   //the full version tag of the parent image

        public string InstallerFileBlob { get; set; }  //optional

        public string PathToDockerFile { get; set; } //property calculated during execution, should not be defined in .json

        public string AcrRepoName { get; private set; } //property calculated during execution, should not be defined in .json

        public string TestRepoName { get; private set; } //property calculated during execution, should not be defined in .json

        public string ProdRepoName { get; private set; } //property calculated during execution, should not be defined in .json

        public string RepoString => ContainerImage.Split(':')[0];

        public string ProdContainerImageWithVersionTag => $"{ProdRepoName}:{VersionTag}";

        public string TestContainerImageWithVersionTag => $"{TestRepoName}:{VersionTag}";
    }
}

