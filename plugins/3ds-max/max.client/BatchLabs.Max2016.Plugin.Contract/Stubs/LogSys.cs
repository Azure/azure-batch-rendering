
using System;
using System.Diagnostics;

using Autodesk.Max;

namespace BatchLabs.Max2016.Plugin.Contract.Stubs
{
    /// <summary>
    /// Override the 3ds Max logger for when we are running locally in debug mode
    /// </summary>
    public class LogSys : ILogSys
    {
        public bool Equals(ILogSys other)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IntPtr NativePointer { get; }

        public void SaveState()
        {
            throw new NotImplementedException();
        }

        public void LoadState()
        {
            throw new NotImplementedException();
        }

        public void LogEntry(uint type, bool dialogue, string title, string format, params object[] param4)
        {
            Debug.WriteLine(format);
        }

        public int Longevity { get; set; }

        public uint LogDays { get; set; }

        public uint LogSize { get; set; }

        public uint LogTypes { get; set; }

        public bool QuietMode { get; set; }

        public string SessionLogName { get; set; }
    }
}
