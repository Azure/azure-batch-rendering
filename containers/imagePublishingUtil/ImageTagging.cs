using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PublishContainerImages
{
    static class ImageTagging
    {
        public static string BuildDevImageTag(string release, string blobMd5, string gitSha, string versionTag)
        {
            if (gitSha.Length > 7)
            {
                gitSha = gitSha.Substring(0, 7);
            }

            var sanitizedblobMd5 = _sanitizeBase64StringForDockerTag(blobMd5);

            var devTag = $"dev-{release}-git.{gitSha}-{versionTag}";

            if (!string.IsNullOrEmpty(blobMd5))
            {
                devTag += $"-blob.{sanitizedblobMd5}";
            }

            return devTag.ToLower();
        }

        public static string BuildVersionTag(string containerImage, string parentVersionTag, string currentVersion)
        {
            var imageAndTag = containerImage
                    .Replace($"$VER", currentVersion)
                    .Replace($"$PARENT_TAG", parentVersionTag)
                    .Split(':');
            PublishContainerImages.WriteLog($"Split image and Tag into: {string.Join(", ", imageAndTag)}");
            return imageAndTag.Last();
        }

        private static string _sanitizeBase64StringForDockerTag(string base64)
        {
            if (string.IsNullOrEmpty(base64))
            {
                return "none";  //default if no installer blob is used
            }

            return base64.Replace('/', '_').Replace('+', '.').TrimEnd('=').Substring(0, 7).ToLower();
        }
    }
}
