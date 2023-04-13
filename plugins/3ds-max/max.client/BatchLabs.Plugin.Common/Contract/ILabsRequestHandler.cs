
using System.Collections.Generic;

namespace BatchLabs.Plugin.Common.Contract
{
    public interface ILabsRequestHandler
    {
        void CallBatchLabs(string action, Dictionary<string, string> arguments = null);
    }
}
