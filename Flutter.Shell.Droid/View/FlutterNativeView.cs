using Android.App;
using Android.Content;
using Android.Util;
using Flutter.Shell.Droid.App;
using Flutter.Shell.Droid.Plugin.Common;
using Java.Lang;
using Java.Nio;
using System.Collections.Generic;
using Android.Content.Res;

namespace Flutter.Shell.Droid.View
{
    public class FlutterNativeView : BinaryMessenger
    {
        private static readonly string TAG = "FlutterNativeView";

        private Dictionary<string, BinaryMessageHandler> mMessageHandlers;
        private int mNextReplyId = 1;
        private Dictionary<int, BinaryReply> mPendingReplies = new Dictionary<int, BinaryReply>();

        private FlutterPluginRegistry mPluginRegistry;
        private long mNativePlatformView;
        private FlutterView mFlutterView;
        private Context mContext;
        private bool applicationIsRunning;

        public FlutterNativeView(Context context) : this(context, false)
        {

        }

        public FlutterNativeView(Context context, bool isBackgroundView)
        {
            mContext = context;
            mPluginRegistry = new FlutterPluginRegistry(this, context);
            Attach(this, isBackgroundView);
            AssertAttached();
            mMessageHandlers = new Dictionary<string, BinaryMessageHandler>();
        }

        public void Detach()
        {
            mPluginRegistry.Detach();
            mFlutterView = null;
            nativeDetach(mNativePlatformView);
        }

        public void Destroy()
        {
            mPluginRegistry.Destroy();
            mFlutterView = null;
            nativeDestroy(mNativePlatformView);
            mNativePlatformView = 0;
            applicationIsRunning = false;
        }

        public FlutterPluginRegistry GetPluginRegistry()
        {
            return mPluginRegistry;
        }

        public void AttachViewAndActivity(FlutterView flutterView, Activity activity)
        {
            mFlutterView = flutterView;
            mPluginRegistry.Attach(flutterView, activity);
        }

        public bool IsAttached()
        {
            return mNativePlatformView != 0;
        }

        public long Get()
        {
            return mNativePlatformView;
        }

        public void AssertAttached()
        {
            if (!IsAttached()) throw new AssertionError("Platform view is not attached");
        }

        public void RunFromBundle(FlutterRunArguments args)
        {
            bool hasBundlePaths = args.bundlePaths != null && args.bundlePaths.Length != 0;
            if (args.bundlePath == null && !hasBundlePaths)
            {
                throw new AssertionError("Either bundlePath or bundlePaths must be specified");
            }

            if ((args.bundlePath != null || args.defaultPath != null) && hasBundlePaths)
            {
                throw new AssertionError("Can't specify both bundlePath and bundlePaths");
            }

            if (args.entrypoint == null)
            {
                throw new AssertionError("An entrypoint must be specified");
            }

            if (hasBundlePaths)
            {
                RunFromBundleInternal(args.bundlePaths, args.entrypoint, args.libraryPath);
            }
            else
            {
                RunFromBundleInternal(new[] { args.bundlePath, args.defaultPath }, args.entrypoint, args.libraryPath);
            }
        }

        /**
         * @deprecated
         * Please use runFromBundle with `FlutterRunArguments`.
         * Parameter `reuseRuntimeController` has no effect.
         */
        //@Deprecated
        public void RunFromBundle(string bundlePath, string defaultPath, string entrypoint, bool reuseRuntimeController)
        {
            RunFromBundleInternal(new [] { bundlePath, defaultPath }, entrypoint, null);
        }

        private void RunFromBundleInternal(string[] bundlePaths, string entrypoint, string libraryPath)
        {
            AssertAttached();
            if (applicationIsRunning)
                throw new AssertionError("This Flutter engine instance is already running an application");

            nativeRunBundleAndSnapshotFromLibrary(mNativePlatformView, bundlePaths,
                entrypoint, libraryPath, mContext.Resources.Assets);

            applicationIsRunning = true;
        }

        public bool IsApplicationRunning()
        {
            return applicationIsRunning;
        }

        public static string GetObservatoryUri()
        {
            return nativeGetObservatoryUri();
        }

        //@Override
        public void Send(string channel, object message)
        {
            Send(channel, message, null);
        }

        //@Override
        public void Send(string channel, object message, BinaryReply callback)
        {
            if (!IsAttached())
            {
                Log.Debug(TAG, "FlutterView.send called on a detached view, channel=" + channel);
                return;
            }

            int replyId = 0;
            if (callback != null)
            {
                replyId = mNextReplyId++;
                mPendingReplies[replyId] = callback;
            }
            if (message == null)
            {
                nativeDispatchEmptyPlatformMessage(mNativePlatformView, channel, replyId);
            }
            else
            {
                nativeDispatchPlatformMessage(
                        mNativePlatformView, channel, message, message.position(), replyId);
            }
        }

        //@Override
        public void SetMessageHandler(string channel, BinaryMessageHandler handler)
        {
            if (handler == null)
                mMessageHandlers.Remove(channel);
            else
                mMessageHandlers[channel] = handler;
        }

        private void Attach(FlutterNativeView view, bool isBackgroundView)
        {
            mNativePlatformView = nativeAttach(view, isBackgroundView);
        }

        // Called by native to send us a platform message.
        // TODO: byte[]->object
        public void HandlePlatformMessage(string channel, object message, int replyId)
        {
            AssertAttached();
            BinaryMessageHandler handler = mMessageHandlers[channel];
            if (handler != null)
            {
                try
                {
                    //ByteBuffer buffer = (message == null ? null : ByteBuffer.wrap(message));
                    handler.OnMessage(message, new BinaryReplyImpl
                    {
                        // private readonly final AtomicBoolean done = private new AtomicBoolean(false);
                        OnReply = (reply) =>
                        {
                            if (!IsAttached())
                            {
                                Log.Debug(TAG, "handlePlatformMessage replying to a detached view, channel=" + channel);
                                return;
                            }
                            //if (done.getAndSet(true))
                            //    throw new IllegalStateException("Reply already submitted");
                            if (reply == null)
                                nativeInvokePlatformMessageEmptyResponseCallback(mNativePlatformView, replyId);
                            else
                                nativeInvokePlatformMessageResponseCallback(mNativePlatformView, replyId, reply, reply.position());
                        }
                    });
                }
                catch (Exception ex)
                {
                    Log.Error(TAG, "Uncaught exception in binary message listener", ex);
                    nativeInvokePlatformMessageEmptyResponseCallback(mNativePlatformView, replyId);
                }
                return;
            }

            nativeInvokePlatformMessageEmptyResponseCallback(mNativePlatformView, replyId);
        }

        // Called by native to respond to a platform message that we sent.
        // TODO: byte[]->object
        private void HandlePlatformMessageResponse(int replyId, object reply)
        {
            BinaryReply callback = mPendingReplies[replyId];
            mPendingReplies.Remove(replyId);
            if (callback != null)
            {
                try
                {
                    callback.Reply(reply);
                }
                catch (Exception ex)
                {
                    Log.Error(TAG, "Uncaught exception in binary message reply handler", ex);
                }
            }
        }

        // Called by native to update the semantics/accessibility tree.
        private void UpdateSemantics(ByteBuffer buffer, String[] strings)
        {
            if (mFlutterView == null)
                return;
            mFlutterView.UpdateSemantics(buffer, strings);
        }

        // Called by native to update the custom accessibility actions.
        private void UpdateCustomAccessibilityActions(ByteBuffer buffer, String[] strings)
        {
            if (mFlutterView == null)
                return;
            mFlutterView.updateCustomAccessibilityActions(buffer, strings);
        }

        // Called by native to notify first Flutter frame rendered.
        private void OnFirstFrame()
        {
            if (mFlutterView == null)
                return;
            mFlutterView.onFirstFrame();
        }

        // Called by native to notify when the engine is restarted (hot restart).
        //@SuppressWarnings("unused")
        private void OnPreEngineRestart()
        {
            if (mFlutterView != null)
                mFlutterView.resetAccessibilityTree();

            mPluginRegistry?.OnPreEngineRestart();
        }

        private static long nativeAttach(FlutterNativeView view, bool isBackgroundView);    // native shell::Attach
        private static void nativeDestroy(long nativePlatformViewAndroid);                  // native shell::Destroy
        private static void nativeDetach(long nativePlatformViewAndroid);                   // native shell::Detach

        private static void nativeRunBundleAndSnapshotFromLibrary(
                long nativePlatformViewAndroid, string[] bundlePaths,
                string entrypoint, string libraryUrl, AssetManager manager);                // native shell::RunBundleAndSnapshotFromLibrary

        private static string nativeGetObservatoryUri();                                    // native shell::GetObservatoryUri

        // Send an empty platform message to Dart.
        private static void nativeDispatchEmptyPlatformMessage(
                long nativePlatformViewAndroid, string channel, int responseId);            // native shell::DispatchEmptyPlatformMessage

        // Send a data-carrying platform message to Dart.
        private static void nativeDispatchPlatformMessage(long nativePlatformViewAndroid,
                string channel, object message, int position, int responseId);              // native shell::DispatchPlatformMessage

        // Send an empty response to a platform message received from Dart.
        private static void nativeInvokePlatformMessageEmptyResponseCallback(
                long nativePlatformViewAndroid, int responseId);                            // native shell::InvokePlatformMessageResponseCallback

        // Send a data-carrying response to a platform message received from Dart.
        private static void nativeInvokePlatformMessageResponseCallback(
                long nativePlatformViewAndroid, int responseId, 
                object message, int position);                                              // native shell::InvokePlatformMessageEmptyResponseCallback
    }
}