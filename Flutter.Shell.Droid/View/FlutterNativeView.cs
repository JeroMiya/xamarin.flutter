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
    public class FlutterNativeView : IBinaryMessenger
    {
        private static readonly string TAG = "FlutterNativeView";

        private Dictionary<string, IBinaryMessageHandler> _messageHandlers;
        private int _nextReplyId = 1;
        private Dictionary<int, IBinaryReply> _pendingReplies = new Dictionary<int, IBinaryReply>();

        private FlutterPluginRegistry _pluginRegistry;
        private long _nativePlatformView;
        private FlutterView _flutterView;
        private Context _context;
        private bool _applicationIsRunning;

        public FlutterNativeView(Context context) : this(context, false) { }

        public FlutterNativeView(Context context, bool isBackgroundView)
        {
            _context        = context;
            _pluginRegistry = new FlutterPluginRegistry(this, context);
            Attach(this, isBackgroundView);
            AssertAttached();
            _messageHandlers = new Dictionary<string, IBinaryMessageHandler>();
        }

        public void Detach()
        {
            _pluginRegistry.Detach();
            _flutterView = null;
            nativeDetach(_nativePlatformView);
        }

        public void Destroy()
        {
            _pluginRegistry.Destroy();
            _flutterView = null;
            nativeDestroy(_nativePlatformView);
            _nativePlatformView   = 0;
            _applicationIsRunning = false;
        }

        public FlutterPluginRegistry GetPluginRegistry()
        {
            return _pluginRegistry;
        }

        public void AttachViewAndActivity(FlutterView flutterView, Activity activity)
        {
            _flutterView = flutterView;
            _pluginRegistry.Attach(flutterView, activity);
        }

        public bool IsAttached()
        {
            return _nativePlatformView != 0;
        }

        public long Get()
        {
            return _nativePlatformView;
        }

        public void AssertAttached()
        {
            if (!IsAttached()) throw new AssertionError("Platform view is not attached");
        }

        public void RunFromBundle(FlutterRunArguments args)
        {
            bool hasBundlePaths = args.BundlePaths != null && args.BundlePaths.Length != 0;
            if (args.BundlePath == null && !hasBundlePaths)
            {
                throw new AssertionError("Either bundlePath or bundlePaths must be specified");
            }

            if ((args.BundlePath != null || args.DefaultPath != null) && hasBundlePaths)
            {
                throw new AssertionError("Can't specify both bundlePath and bundlePaths");
            }

            if (args.Entrypoint == null)
            {
                throw new AssertionError("An entrypoint must be specified");
            }

            if (hasBundlePaths)
            {
                RunFromBundleInternal(args.BundlePaths, args.Entrypoint, args.LibraryPath);
            }
            else
            {
                RunFromBundleInternal(new[] {args.BundlePath, args.DefaultPath}, args.Entrypoint, args.LibraryPath);
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
            RunFromBundleInternal(new[] {bundlePath, defaultPath}, entrypoint, null);
        }

        private void RunFromBundleInternal(string[] bundlePaths, string entrypoint, string libraryPath)
        {
            AssertAttached();
            if (_applicationIsRunning)
                throw new AssertionError("This Flutter engine instance is already running an application");

            nativeRunBundleAndSnapshotFromLibrary(
                _nativePlatformView,
                bundlePaths,
                entrypoint,
                libraryPath,
                _context.Resources.Assets);

            _applicationIsRunning = true;
        }

        public bool IsApplicationRunning()
        {
            return _applicationIsRunning;
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
        public void Send(string channel, object message, IBinaryReply callback)
        {
            if (!IsAttached())
            {
                Log.Debug(TAG, "FlutterView.send called on a detached view, channel=" + channel);
                return;
            }

            int replyId = 0;
            if (callback != null)
            {
                replyId                  = _nextReplyId++;
                _pendingReplies[replyId] = callback;
            }

            if (message == null)
                nativeDispatchEmptyPlatformMessage(_nativePlatformView, channel, replyId);
            else
                nativeDispatchPlatformMessage(_nativePlatformView, channel, message, replyId);
        }

        //@Override
        public void SetMessageHandler(string channel, IBinaryMessageHandler handler)
        {
            if (handler == null)
                _messageHandlers.Remove(channel);
            else
                _messageHandlers[channel] = handler;
        }

        private void Attach(FlutterNativeView view, bool isBackgroundView)
        {
            _nativePlatformView = nativeAttach(view, isBackgroundView);
        }

        // Called by native to send us a platform message.
        // TODO: byte[]->object
        public void HandlePlatformMessage(string channel, object message, int replyId)
        {
            AssertAttached();
            IBinaryMessageHandler handler = _messageHandlers[channel];
            if (handler != null)
            {
                try
                {
                    //ByteBuffer buffer = (message == null ? null : ByteBuffer.wrap(message));
                    handler.OnMessage(
                        message,
                        new BinaryReplyImpl
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
                                    nativeInvokePlatformMessageEmptyResponseCallback(_nativePlatformView, replyId);
                                else
                                    nativeInvokePlatformMessageResponseCallback(_nativePlatformView, replyId, reply);
                            }
                        });
                }
                catch (Exception ex)
                {
                    Log.Error(TAG, "Uncaught exception in binary message listener", ex);
                    nativeInvokePlatformMessageEmptyResponseCallback(_nativePlatformView, replyId);
                }

                return;
            }

            nativeInvokePlatformMessageEmptyResponseCallback(_nativePlatformView, replyId);
        }

        // Called by native to respond to a platform message that we sent.
        // TODO: byte[]->object
        public void HandlePlatformMessageResponse(int replyId, object reply)
        {
            IBinaryReply callback = _pendingReplies[replyId];
            _pendingReplies.Remove(replyId);
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
        public void UpdateSemantics(ByteBuffer buffer, string[] strings)
        {
            _flutterView?.UpdateSemantics(buffer, strings);
        }

        // Called by native to update the custom accessibility actions.
        public void UpdateCustomAccessibilityActions(ByteBuffer buffer, string[] strings)
        {
            _flutterView?.UpdateCustomAccessibilityActions(buffer, strings);
        }

        // Called by native to notify first Flutter frame rendered.
        public void RaiseFirstFrame()
        {
            _flutterView?.RaiseFirstFrame();
        }

        // Called by native to notify when the engine is restarted (hot restart).
        //@SuppressWarnings("unused")
        public void OnPreEngineRestart()
        {
            _flutterView?.ResetAccessibilityTree();
            _pluginRegistry?.OnPreEngineRestart();
        }

        private static long nativeAttach(FlutterNativeView view, bool isBackgroundView); // native shell::Attach
        private static void nativeDestroy(long nativePlatformViewAndroid);               // native shell::Destroy
        private static void nativeDetach(long nativePlatformViewAndroid);                // native shell::Detach

        private static void nativeRunBundleAndSnapshotFromLibrary(
            long nativePlatformViewAndroid, string[] bundlePaths,
            string entrypoint, string libraryUrl, AssetManager manager); // native shell::RunBundleAndSnapshotFromLibrary

        private static string nativeGetObservatoryUri(); // native shell::GetObservatoryUri

        // Send an empty platform message to Dart.
        private static void nativeDispatchEmptyPlatformMessage(
            long nativePlatformViewAndroid, string channel, int responseId); // native shell::DispatchEmptyPlatformMessage

        // Send a data-carrying platform message to Dart.
        private static void nativeDispatchPlatformMessage(
            long nativePlatformViewAndroid,
            string channel, object message, int responseId); // native shell::DispatchPlatformMessage

        // Send an empty response to a platform message received from Dart.
        private static void nativeInvokePlatformMessageEmptyResponseCallback(
            long nativePlatformViewAndroid, int responseId); // native 

        // Send a data-carrying response to a platform message received from Dart.
        private static void nativeInvokePlatformMessageResponseCallback(
            long nativePlatformViewAndroid, int responseId,
            object message); // c++  native shell::InvokePlatformMessageEmptyResponseCallback

        // c++  FlutterViewHandlePlatformMessageResponse
        // java FlutternativeView -> handlePlatformMessageResponse
    }
}
