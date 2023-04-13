using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PublishContainerImages.Model;

namespace PublishContainerImages
{
    public static class Json
    {
        public static dynamic ReadJsonFileToDynamic(string filePath)
        {
            string jsonStr;
            using (var streamReader = new StreamReader(filePath))
            {
                jsonStr = streamReader.ReadToEnd();
            }

            dynamic json = JsonConvert.DeserializeObject(jsonStr);

            return json;
        }

        public static string JsonSerializeObject(dynamic toSerialize)
        {
            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                Formatting = Formatting.Indented
            };

            return JsonConvert.SerializeObject(toSerialize, jsonSerializerSettings);
        }
    }
}
