using System;

namespace FlutterBinding.Plugin.Common
{
    /**
     * Method call result callback. Supports dual use: Implementations of methods
     * to be invoked by Flutter act as clients of this interface for sending results
     * back to Flutter. Invokers of Flutter methods provide implementations of this
     * interface for handling results received from Flutter.
     *
     * <p>All methods of this class must be called on the platform thread (Android main thread). For more details see
     * <a href="https://github.com/flutter/engine/wiki/Threading-in-the-Flutter-Engine">Threading in the Flutter
     * Engine</a>.</p>
     */
    public interface IResult
    {
        /**
         * Handles a successful result.
         *
         * @param result The result, possibly null.
         */
        void Success( /* @Nullable */ object result);

        /**
         * Handles an error result.
         *
         * @param errorCode An error code String.
         * @param errorMessage A human-readable error message String, possibly null.
         * @param errorDetails Error details, possibly null
         */
        void Error(string errorCode, /* @Nullable */ string errorMessage, /* @Nullable */ object errorDetails);

        /**
         * Handles a call to an unimplemented method.
         */
        void NotImplemented();
    }

    public class ResultImpl : IResult
    {
        public Action<object> OnSuccess;
        public Action<string, string, object> OnError;
        public Action OnNotImplemented;

        /// <inheritdoc />
        public void Success(object result)
        {
            OnSuccess?.Invoke(result);
        }

        /// <inheritdoc />
        public void Error(string errorCode, string errorMessage, object errorDetails)
        {
            OnError?.Invoke(errorCode, errorMessage, errorDetails);
        }

        /// <inheritdoc />
        public void NotImplemented()
        {
            OnNotImplemented?.Invoke();
        }
    }
}
