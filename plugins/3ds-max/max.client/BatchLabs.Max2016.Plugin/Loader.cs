
using BatchLabs.Max2016.Plugin.Common;

namespace BatchLabs.Max2016.Plugin
{
    /// <summary>
    /// Public managed c# class to load assembly 
    /// </summary>
    public static class Loader
    {
        public const string ActionCategory = "BatchLabs - Max2016 Rendering";

        /// <summary>
        /// Init point for assembly loader
        /// </summary>
        public static void AssemblyMain()
        {
            Log.Instance.Info("loading BatchLabs.Max2016.Plugin");
            MenuUtilities.SetupMenuHandlers();
        }
    }
}
