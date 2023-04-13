
using Autodesk.Max;

using BatchLabs.Max2019.Plugin.Max;
using BatchLabs.Plugin.Common.Contract;

namespace BatchLabs.Max2019.Plugin.Common
{
    /// <summary>
    /// Common logger form passing logs to Max.
    /// </summary>
    public class Log : IMaxLogger
    {
        private const uint SyslogError = 0x00000001;
        private const uint SyslogWarn = 0x00000002;
        private const uint SyslogInfo = 0x00000004;
        private const uint SyslogDebug = 0x00000008;

        private static Log _instance;
        private static ILogSys _logger;

        private Log(ILogSys maxLogger)
        {
            _logger = maxLogger;
        }

        public static IMaxLogger Instance =>
            _instance ?? (_instance = GetLogger);

        private static Log GetLogger => new Log(MaxGlobalInterface.Instance.COREInterface16.Log);

        public void Debug(string message, string title = "", bool dialog = false)
        {
            _logger.LogEntry(SyslogDebug, dialog, title, FormatLog(message));
        }

        public void Info(string message, string title = "", bool dialog = false)
        {
            _logger.LogEntry(SyslogInfo, dialog, title, FormatLog(message));
        }

        public void Warn(string message, string title = "", bool dialog = false)
        {
            _logger.LogEntry(SyslogWarn, dialog, title, FormatLog(message));
        }

        public void Error(string message, string title = "", bool dialog = false)
        {
            _logger.LogEntry(SyslogError, dialog, title, FormatLog(message));
        }

        private string FormatLog(string message)
        {
            return $"[BatchLabs] - {message}";
        }
    }
}
