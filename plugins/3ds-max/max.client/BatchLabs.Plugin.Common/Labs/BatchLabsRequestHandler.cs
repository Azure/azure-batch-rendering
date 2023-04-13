
using System;
using System.Collections.Generic;
using System.Diagnostics;

using BatchLabs.Plugin.Common.Code;
using BatchLabs.Plugin.Common.Contract;
using BatchLabs.Plugin.Common.Resources;

namespace BatchLabs.Plugin.Common.Labs
{
    public class BatchLabsRequestHandler : ILabsRequestHandler
    {
        private static Guid _sessionId = Guid.NewGuid();
        private readonly IMaxLogger _logger;

        public BatchLabsRequestHandler(IMaxLogger logger)
        {
            _logger = logger;
        }

        public void CallBatchLabs(string action, Dictionary<string, string> arguments = null)
        {
            var baseUrl = $"{Constants.BatchLabsBaseUrl}/{action}?session={SessionId}";
            if (arguments != null)
            {
                foreach (var keyValue in arguments)
                {
                    baseUrl = $"{baseUrl}&{keyValue.Key}={Uri.EscapeUriString(keyValue.Value)}";
                }
            }

            try
            {
                _logger.Debug($"Calling BatchLabs with URL: {baseUrl}");
                Process.Start(baseUrl);
            }
            catch (Exception ex)
            {
                _logger.Error($"{ex.Message}\n{ex}", Strings.BatchLabs_RequestError, true);
                // MessageBox.Show($"{Strings.BatchLabs_RequestError}.\n{ex.Message}\n{ex}");
            }
        }

        private static string SessionId => _sessionId.ToString();
    }
}
