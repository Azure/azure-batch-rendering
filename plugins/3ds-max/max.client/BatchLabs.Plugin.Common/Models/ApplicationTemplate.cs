
using System.Runtime.Serialization;

namespace BatchLabs.Plugin.Common.Models
{
    [DataContract]
    public class ApplicationTemplate
    {
        [DataMember(Name="id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
