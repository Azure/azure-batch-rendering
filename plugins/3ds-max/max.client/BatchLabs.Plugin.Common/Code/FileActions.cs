
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BatchLabs.Plugin.Common.Code
{
    public class FileActions
    {
        public static Dictionary<string, List<string>> GetFileDictionaryWithLocationsFromFolder(string folder)
        {
            if (string.IsNullOrEmpty(folder))
            {
                return null;
            }

            var dictionary = new Dictionary<string, List<string>>();
            var files = GetFilesInDirectory(folder, SearchOption.AllDirectories);

            foreach (var fileInfo in files)
            {
                if (!dictionary.ContainsKey(fileInfo.Name))
                {
                    dictionary.Add(fileInfo.Name, new List<string> { fileInfo.FullName });
                }
                else
                {
                    dictionary[fileInfo.Name].Add(fileInfo.FullName);
                }
            }

            return dictionary;
        }

        public static IEnumerable<FileInfo> GetFilesInDirectory(string folder, SearchOption searchOption)
        {
            var dirInfo = new DirectoryInfo(folder);
            return dirInfo.GetAllDirectoryFiles(searchOption);
        }

        public static IEnumerable<FileInfo> GetFileInfos(IEnumerable<string> filePaths)
        {
            return filePaths
                .Select(GetFileInfo)
                .ToList();
        }

        public static FileInfo GetFileInfo(string filePath)
        {
            return new FileInfo(filePath);
        }
    }
}

