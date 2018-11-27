using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FlutterBinding.Engine
{
    /// <summary>
    /// An error happened in the Flutter engine.
    /// Usually a replacement for the c++ engine passing a string back to Dart, then Dart throwing a generic exception
    /// </summary>
    public class FlutterException : Exception
    {
        public FlutterException() { }

        public FlutterException(string message) : base(message) { }

        public FlutterException(string message, Exception innerException) : base(message, innerException) { }
    }
}
