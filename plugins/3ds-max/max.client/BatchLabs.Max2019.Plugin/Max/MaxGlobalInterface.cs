
using Autodesk.Max;

#if DEBUG
using BatchLabs.Max2019.Plugin.Contract;
#endif

namespace BatchLabs.Max2019.Plugin.Max
{
    /// <summary>
    /// Want to change this to be dependancy injected
    /// </summary>
    public class MaxGlobalInterface
    {
        private static IGlobal _instance;

        public static IGlobal Instance =>
            _instance ?? (_instance = GetGlobalInterface);

        private static IGlobal GetGlobalInterface
        {
            get
            {
#if DEBUG
                return GlobalInterface.Instance != null
                    ? GlobalInterface.Instance
                    : new FakeGlobalInterface();
#else
                return GlobalInterface.Instance;
#endif
            }
        }
    }
}
