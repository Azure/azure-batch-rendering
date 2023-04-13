
using System.IO;
using System.Text.RegularExpressions;

namespace BatchLabs.Plugin.Common.Code
{
    public class Utils
    {
        private const int MaxFileGroupLength = 55;
        private const string Prefix = "3dsmax-";

        private static readonly Regex UnderscoresAndMultipleDashes = new Regex("[_-]+");
        private static readonly char[] ForbiddenLeadingTrailingContainerNameChars = { '-' };
        private static readonly int MaxUsableLength = MaxFileGroupLength - Prefix.Length;

        /// <summary>
        /// Sanitize the 3ds max file name into a valid storage container name so we can
        /// use it for a file group name should we choose to.
        /// </summary>
        /// <param name="maxFile"></param>
        /// <returns></returns>
        public static string ContainerizeMaxFile(string maxFile)
        {
            if (string.IsNullOrEmpty(maxFile))
            {
                return string.Empty;
            }

            // get the filename only and lower case it
            var sansExtension = Path.GetFileNameWithoutExtension(maxFile).ToLower();

            // replace any spaces with '_'
            sansExtension = sansExtension.Replace(" ", "_");

            // replace underscores and multiple dashes
            sansExtension = UnderscoresAndMultipleDashes.Replace(sansExtension, "-");

            // check that the filename is not too long, if it is then trim it
            if (sansExtension.Length > MaxUsableLength)
            {
                sansExtension = sansExtension.Substring(0, MaxUsableLength);
            }

            // return after replacing any start and end hyphens
            return sansExtension.Trim(ForbiddenLeadingTrailingContainerNameChars);
        }
    }
}
