
namespace BatchLabs.Plugin.Common.Contract
{
    public interface IMaxLogger
    {
        void Debug(string message, string title = "", bool dialog = false);

        void Info(string message, string title = "", bool dialog = false);

        void Warn(string message, string title = "", bool dialog = false);

        void Error(string message, string title = "", bool dialog = false);
    }
}
