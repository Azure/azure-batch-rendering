using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using PublishContainerImages.Model;

namespace PublishContainerImages
{
    class ContainerImagePayload
    {
        public ContainerImageDefinition ContainerImageDefinition;

        public TestConfigurationDefinition TestConfigurationDefinition;

        public dynamic TestParametersDefinition;
    }
}
