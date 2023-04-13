
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BatchLabs.Plugin.Common.Code
{
    public static class DirectoryInfoExtensions
    {
        public static IEnumerable<FileInfo> GetAllDirectoryFiles(this DirectoryInfo dirInfo, SearchOption searchOption)
        {
            var result = dirInfo.EnumerateFiles("*", searchOption);
            return result.Where(file => (file.Attributes & FileAttributes.Hidden) == 0);
        }
    }
}
