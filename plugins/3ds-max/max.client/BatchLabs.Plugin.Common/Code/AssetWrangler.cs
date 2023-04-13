
using System;
using System.Collections.Generic;
using System.Linq;

namespace BatchLabs.Plugin.Common.Code
{
    public class AssetWrangler
    {
        /// <summary>
        /// Get a list of all files that exist in the current project directory.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, List<string>> GetProjectFiles(string projectFolder)
        {
            return FileActions.GetFileDictionaryWithLocationsFromFolder(projectFolder);
        }

        /// <summary>
        /// Wander backwards up the directory tree looking for matches. This is for files that are in the project directory
        /// already, but 3ds Max is using them from another location, i.e. a pre-installed texture pack on the local machine.
        /// I.E. This file is marked as an asset by the max scene:
        ///     C:\program files (x86)\itoo software\forest pack pro\maps\presets\fp_grass_leaf_5.jpg
        /// 
        /// If we find this is the case then we ignore the file in the program files folder as we don't need to upload 
        /// it again. 3ds Max will find it in the project directory, or in its propper location after the texture pack is 
        /// installed on the node.
        /// </summary>
        /// <param name="sceneFilePath"></param>
        /// <param name="diskLocations"></param>
        /// <returns></returns>
        public static int FindMatchingDirectories(string sceneFilePath, List<string> diskLocations)
        {
            var locationMatch = new Dictionary<string, int>();
            diskLocations.ForEach(location =>
            {
                locationMatch[location] = 0;
                var sceneFileDirectory = FileActions.GetFileInfo(sceneFilePath).Directory;
                var diskLocationDirectory = FileActions.GetFileInfo(location).Directory;
                while (sceneFileDirectory != null && diskLocationDirectory != null)
                {
                    if (sceneFileDirectory.Name.Equals(diskLocationDirectory.Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        locationMatch[location]++;
                    }
                    else
                    {
                        // the moment we don't match, break out of loop.
                        break;
                    }

                    // move to the parent directory.
                    sceneFileDirectory = sceneFileDirectory.Parent;
                    diskLocationDirectory = diskLocationDirectory.Parent;
                }
            });

            return locationMatch.Values.Max();
        }
    }
}
