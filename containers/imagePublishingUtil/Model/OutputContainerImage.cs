using System;
using System.Collections.Generic;
using System.Text;

namespace PublishContainerImages.Model
{
    class OutputContainerImage
    {
        public string AcrRepoName;

        public string TestRepoName;

        public string ProdRepoName;

        public string DevTag;

        public string VersionTag;

        public string PathToDockerfile;

        public ContainerImagePayload Payload;

        public ContainerImageMetadata Metadata;

        public string TestContainerImage;
    }
}
