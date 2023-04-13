
using BatchLabs.Max2019.Plugin.Common;

namespace BatchLabs.Max2019.Plugin
{
    /// <summary>
    /// Public managed c# class to load assembly 
    /// </summary>
    public static class Loader
    {
        public const string ActionCategory = "BatchLabs - Max2019 Rendering";

        /// <summary>
        /// Init point for assembly loader
        /// </summary>
        public static void AssemblyMain()
        {
            Log.Instance.Info("loading BatchLabs.Max2019.Plugin");
            MenuUtilities.SetupMenuHandlers();
        }
    }
}
