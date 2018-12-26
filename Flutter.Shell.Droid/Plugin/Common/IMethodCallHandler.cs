namespace Flutter.Shell.Droid.Plugin.Common
{
    /**
     * A handler of incoming method calls.
     */
    public interface IMethodCallHandler
    {
        /**
         * Handles the specified method call received from Flutter.
         *
         * <p>Handler implementations must submit a result for all incoming calls, by making a single call
         * on the given {@link Result} callback. Failure to do so will result in lingering Flutter result
         * handlers. The result may be submitted asynchronously. Calls to unknown or unimplemented methods
         * should be handled using {@link Result#notImplemented()}.</p>
         *
         * <p>Any uncaught exception thrown by this method will be caught by the channel implementation and
         * logged, and an error result will be sent back to Flutter.</p>
         *
         * <p>The handler is called on the platform thread (Android main thread). For more details see
         * <a href="https://github.com/flutter/engine/wiki/Threading-in-the-Flutter-Engine">Threading in the Flutter
         * Engine</a>.</p>
         *
         * @param call A {@link MethodCall}.
         * @param result A {@link Result} used for submitting the result of the call.
         */
        void OnMethodCall(MethodCall call, IResult result);
    }
}
