
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization.Json;
using BatchLabs.Plugin.Common.Contract;
using BatchLabs.Plugin.Common.Models;

namespace BatchLabs.Plugin.Common.Code
{
    public class TemplateHelper
    {
        public const string TemplateStandard = "standard";
        public const string TemplateDistributed = "vray-dr";
        public const string RendererArnold = "arnold";
        public const string RendererVRay = "vray";
        public const string RendererVRayAdv = "VRayAdv";
        public const string RendererVRayRt = "VRayRT";

        private const string AppIndexJsonUrl =
            "https://raw.githubusercontent.com/Azure/BatchLabs-data/master/ncj/3dsmax/index.json";

        /// <summary>
        /// Read the collection of 3ds Max application templates from our GitHub repo. They 
        /// are all listed in a file called index.json.
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> GetApplicationTemplates(IMaxLogger logger)
        {

            var templates = new List<KeyValuePair<string, string>>();
            try
            {
                var request = WebRequest.Create(AppIndexJsonUrl);
                using (var response = (HttpWebResponse) request.GetResponse())
                {
                    using (var responseSteam = response.GetResponseStream())
                    {
                        // in the unlkely event, just return an empty collection
                        if (responseSteam == null)
                        {
                            return templates;
                        }

                        // deserialize the json response into a collection of application templates
                        var jsonSerializer = new DataContractJsonSerializer(new List<ApplicationTemplate>().GetType());
                        var templateList = jsonSerializer.ReadObject(responseSteam) as List<ApplicationTemplate>;
                        if (templateList != null)
                        {
                            foreach (var template in templateList)
                            {
                                logger.Debug($"Got template: {template.Id}, with name: {template.Name} ");
                                templates.Add(new KeyValuePair<string, string>(template.Id, template.Name));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"{ex.Message}\n{ex}", "Failed to get 3ds Max templates", true);
            }

            return templates;
        }

        /// <summary>
        /// List the renderer options for the 3ds Max templates
        /// </summary>
        /// <returns></returns>
        public static List<KeyValuePair<string, string>> GetRenderers(string template)
        {
            // special case for DR rendering
            return template == TemplateDistributed
                ? new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>(RendererVRayAdv, RendererVRayAdv),
                    new KeyValuePair<string, string>(RendererVRayRt, RendererVRayRt)
                }
                : new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>(RendererArnold, "Arnold"),
                    new KeyValuePair<string, string>(RendererVRay, "V-Ray")
                };
        }
    }
}
