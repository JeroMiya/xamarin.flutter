using System.Diagnostics;

namespace FlutterBinding.Engine
{
    /// <summary>
    /// Flutter Logging
    /// </summary>
    public static class FLog
    {
        public static FLogSeverity Severity { get; set; }
#if DEBUG
            = FLogSeverity.Warning;
#else
            = FLogSeverity.Error;
        #endif

        public static void Log(FLogSeverity severity, string message)
        {
            if (severity >= Severity) Trace.Write(message);
        }

        public static void Info(string message) => Log(FLogSeverity.Info, message);
        public static void Warning(string message) => Log(FLogSeverity.Warning, message);
        public static void Error(string message) => Log(FLogSeverity.Error, message);
        public static void Fatal(string message) => Log(FLogSeverity.Fatal, message);
    }

    public enum FLogSeverity
    {
        Info = 0,
        Warning = 1,
        Error = 2,
        Fatal = 3
    }
}
