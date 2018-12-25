using System;

namespace Flutter.Framework.Engine
{
    /// <summary>
    /// An error happened in the Flutter engine.
    /// Usually a replacement for the c++ engine passing a string back to Dart, then Dart throwing a generic exception
    /// </summary>
    public class FlutterException : Exception
    {
        public string code;
        public object details;

        public FlutterException() { }

        public FlutterException(string message) : base(message) { }

        public FlutterException(string message, Exception innerException) : base(message, innerException) { }
    }
}
