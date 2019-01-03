using System;
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

        public static void Log(FLogSeverity severity, string tag, string message, Exception ex = null)
        {
            if (severity < Severity)
                return;

            if (string.IsNullOrWhiteSpace(tag))
                Console.WriteLine(ex != null ? $"{tag}: {message}: {ex}" : $"{tag}: {message}");
            else
                Console.WriteLine(ex != null ? $"{message}: {ex}" : message);
        }

        public static void Info(string tag, string message, Exception ex = null) => Log(FLogSeverity.Info, tag, message, ex);
        public static void Info(string message, Exception ex = null) => Log(FLogSeverity.Info, null, message, ex);

        public static void Warning(string tag, string message, Exception ex) => Log(FLogSeverity.Warning, tag, message, ex);
        public static void Warning(string message, Exception ex) => Log(FLogSeverity.Warning, null, message, ex);

        public static void Error(string tag, string message, Exception ex = null) => Log(FLogSeverity.Error, tag, message, ex);
        public static void Error(string message, Exception ex = null) => Log(FLogSeverity.Error, null, message, ex);

        public static void Fatal(string tag, string message, Exception ex = null) => Log(FLogSeverity.Fatal, tag, message, ex);
        public static void Fatal(string message, Exception ex) => Log(FLogSeverity.Fatal, null, message, ex);
    }

    public enum FLogSeverity
    {
        Info = 0,
        Warning = 1,
        Error = 2,
        Fatal = 3
    }
}
