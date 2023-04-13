using System.IO;

namespace PublishContainerImages.Model
{
    public class TestConfigurationDefinition
    {
        public string Name;

        public string Template;

        public string PoolTemplate;

        public string DockerImage;

        public string ExpectedOutput;

        public string Parameters;

        public string GetParametersFileName()
        {
            //not a property so it doesn't get serialized
            return $"{Name}.parameters.json";
        }
    }
}
