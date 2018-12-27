using System;

namespace FlutterBinding.Shell
{
    internal class FlutterException : Exception
    {
        public string Code { get; }
        public object Details { get; }

        /// <inheritdoc />
        public FlutterException() { }

        /// <inheritdoc />
        public FlutterException(string message) : base(message) { }

        /// <inheritdoc />
        public FlutterException(string message, Exception innerException) : base(message, innerException) { }

        /// <inheritdoc />
        public FlutterException(string code, string message, object details = null) : base(message)
        {
            Code    = code;
            Details = details;
        }

        /// <inheritdoc />
        public FlutterException(string code, string message, object details, Exception innerException) : base(message, innerException)
        {
            Code    = code;
            Details = details;
        }
    }
}
