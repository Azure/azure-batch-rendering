using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using PublishContainerImages.Model;

namespace PublishContainerImages
{
    class MergeRenderingContainerImagesJson
    {
        public static void MergeJson(string masterFile, string newImagesFile, string outputFile, string exclusivelyForApp)
        {
            var masterContainerImages = ReadRenderingContainerImagesJsonFile(masterFile);
            var newContainerImages = ReadRenderingContainerImagesJsonFile(newImagesFile);

            var outputContainerImages = masterContainerImages.ContainerImages.ToList();
            foreach(var newImage in newContainerImages.ContainerImages)
            {
                var preExistingContainerImage = outputContainerImages.Find(masterImage => ImageMetadataMatches(masterImage, newImage));
                if (preExistingContainerImage == null)
                {
                    outputContainerImages.Add(newImage);
                }
                else
                {
                    preExistingContainerImage.ContainerImage = newImage.ContainerImage;
                }
            }

            if(!string.IsNullOrEmpty(exclusivelyForApp))
            {
                outputContainerImages.RemoveAll(image => !image.App.Equals(exclusivelyForApp, StringComparison.OrdinalIgnoreCase));
            }

            var output = new RenderingContainerImages()
            {
                ContainerImages = outputContainerImages.ToArray(),
                ImageReferences = masterContainerImages.ImageReferences
            };

            string outputJson = Json.JsonSerializeObject(output);
            File.WriteAllText(outputFile, outputJson);
            PublishContainerImages.WriteLog($"\nWrote metadata file at: {outputFile}, file contents:");
            PublishContainerImages.WriteLog(outputJson);

            dynamic metaDataOutput = new ExpandoObject();
            //metaDataOutput.containerImages = new dynamic[imagesWithMetadata.Count];

            //int index = 0;
            //foreach (var image in imagesWithMetadata)
            //{
            //    dynamic imageEntry = new ExpandoObject();
            //    imageEntry.containerImage = $"{image.ProdRepoName}:{image.VersionTag}";
            //    imageEntry.os = image.Metadata.Os;
            //    imageEntry.app = image.Metadata.App;
            //    imageEntry.appVersion = image.Metadata.AppVersion;
            //    imageEntry.renderer = image.Metadata.Renderer;
            //    imageEntry.rendererVersion = image.Metadata.RendererVersion;
            //    imageEntry.imageReferenceId = image.Metadata.ImageReferenceId;


            //    metaDataOutput.containerImages[index++] = imageEntry;
            //}
        }

        private static RenderingContainerImages ReadRenderingContainerImagesJsonFile(string masterFilePath)
        {
            RenderingContainerImages renderingContainerImages;
            dynamic json = Json.ReadJsonFileToDynamic(masterFilePath);
            try
            {
                renderingContainerImages = json.ToObject<RenderingContainerImages>();
            }
            catch (JsonSerializationException ex)
            {
                PublishContainerImages.WriteError(
                    $"Invalid Json read in file {masterFilePath}, Json was: {json}. Exception: {ex}");
                throw;
            }
            return renderingContainerImages;
        }

        private static bool ImageMetadataMatches(RenderingContainerImage image1, RenderingContainerImage image2)
        {
            return 
                image1.App.Equals(image2.App, StringComparison.OrdinalIgnoreCase) &&
                image1.AppVersion.Equals(image2.AppVersion, StringComparison.OrdinalIgnoreCase) &&
                image1.ImageReferenceId.Equals(image2.ImageReferenceId, StringComparison.OrdinalIgnoreCase) &&
                image1.Os.Equals(image2.Os, StringComparison.OrdinalIgnoreCase) &&
                image1.Renderer.Equals(image2.Renderer, StringComparison.OrdinalIgnoreCase) &&
                image1.RendererVersion.Equals(image2.RendererVersion, StringComparison.OrdinalIgnoreCase);
        }
    }
}
