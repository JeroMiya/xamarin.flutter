using Android.App;
using Android.Content;
using Android.Util;
using Flutter.Shell.Droid.App;
using Flutter.Shell.Droid.Plugin.Common;
using Java.Lang;
using Java.Nio;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlutterBinding.App;
using FlutterBinding.Engine.Assets;
using FlutterBinding.Plugin.Common;
using FlutterBinding.Shell;
using FlutterBinding.UI;
using AssetManager = Android.Content.Res.AssetManager;

namespace Flutter.Shell.Droid.View
{
    public class FlutterNativeView : IBinaryMessenger
    {
        private static readonly string TAG = "FlutterNativeView";

        private Dictionary<string, IBinaryMessageHandler> _messageHandlers;
        private int _nextReplyId = 1;
        private Dictionary<int, IBinaryReply> _pendingReplies = new Dictionary<int, IBinaryReply>();

        private FlutterPluginRegistry _pluginRegistry;
        private AndroidShellHolder _shellHolder;
        private FlutterView _flutterView;
        private Context _context;
        private bool _applicationIsRunning;

        public FlutterNativeView(Context context)
        {
            _context        = context;
            _pluginRegistry = new FlutterPluginRegistry(this, context);
            Attach(this);
            AssertAttached();
            _messageHandlers = new Dictionary<string, IBinaryMessageHandler>();
        }

        public void Detach()
        {
            _pluginRegistry.Detach();
            _flutterView = null;
        }

        public void Destroy()
        {
            _pluginRegistry.Destroy();
            _flutterView = null;
            _shellHolder = null;
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
            return _shellHolder != null;
        }

        public AndroidShellHolder Get()
        {
            return _shellHolder;
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
         */
        //@Deprecated
        public void RunFromBundle(string bundlePath, string defaultPath, string entrypoint)
        {
            RunFromBundleInternal(new[] {bundlePath, defaultPath}, entrypoint, null);
        }

        private void RunFromBundleInternal(string[] bundlePaths, string entrypoint, string libraryPath)
        {
            AssertAttached();
            if (_applicationIsRunning)
                throw new AssertionError("This Flutter engine instance is already running an application");

            NativeRunBundleAndSnapshotFromLibrary(
                _shellHolder,
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
            return NativeGetObservatoryUri();
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
                NativeDispatchEmptyPlatformMessage(_shellHolder, channel, replyId);
            else
                nativeDispatchPlatformMessage(_shellHolder, channel, message, replyId);
        }

        //@Override
        public void SetMessageHandler(string channel, IBinaryMessageHandler handler)
        {
            if (handler == null)
                _messageHandlers.Remove(channel);
            else
                _messageHandlers[channel] = handler;
        }

        private async void Attach(FlutterNativeView view)
        {
            _shellHolder = await NativeAttach(view);
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
                                    nativeInvokePlatformMessageEmptyResponseCallback(_shellHolder, replyId);
                                else
                                    nativeInvokePlatformMessageResponseCallback(_shellHolder, replyId, reply);
                            }
                        });
                }
                catch (Exception ex)
                {
                    Log.Error(TAG, "Uncaught exception in binary message listener", ex);
                    nativeInvokePlatformMessageEmptyResponseCallback(_shellHolder, replyId);
                }

                return;
            }

            nativeInvokePlatformMessageEmptyResponseCallback(_shellHolder, replyId);
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
        public void UpdateSemantics(SemanticsNodeUpdates update, CustomAccessibilityActionUpdates actions)
        {
            _flutterView?.UpdateSemantics(update, actions);
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

        public static async Task<AndroidShellHolder> NativeAttach(FlutterNativeView view)
        {
            return await AndroidShellHolder.Create(
                FlutterMain.Settings,
                view);
        }

        private static void NativeRunBundleAndSnapshotFromLibrary(
            AndroidShellHolder shellHolder,
            string[] bundlePaths,
            string entrypoint,
            string libraryUrl,
            AssetManager nativeAssetManager) // native shell::RunBundleAndSnapshotFromLibrary
        {
            FlutterBinding.Engine.Assets.AssetManager assetManager = new FlutterBinding.Engine.Assets.AssetManager();

            foreach (var bundlePath in bundlePaths)
            {
                if (string.IsNullOrWhiteSpace(bundlePath))
                    continue;

                // If we got a bundle path, attempt to use that as a directory asset
                // bundle or a zip asset bundle.
                var fileExtIndex = bundlePath.LastIndexOf('.');
                if (bundlePath.Substring(fileExtIndex) == ".zip")
                {
                    //TODO: ZipAssetStore
                    //assetManager.PushBack(new ZipAssetStore(bundlePath));
                }
                else
                {
                    assetManager.PushBack(new DirectoryAssetBundle(bundlePath));

                    // Use the last path component of the bundle path to determine the
                    // directory in the APK assets.
                    var lastSlashIndex = bundlePath.LastIndexOf('/');
                    if (lastSlashIndex > 1)
                    {
                        var apkAssetDir = bundlePath.Substring(lastSlashIndex + 1);

                        //TODO: APKAssetProvider
                        //assetManager.PushBack(new APKAssetProvider(apkAssetDir));
                    }
                }
            }

            var config = new RunConfiguration(assetManager);

            if (!string.IsNullOrWhiteSpace(entrypoint) && !string.IsNullOrWhiteSpace(libraryUrl))
                config.SetEntrypointAndLibrary(entrypoint, libraryUrl);
            else
                config.SetEntrypoint(entrypoint);
            
            shellHolder.Launch(config);
        }

        private static string NativeGetObservatoryUri() // native shell::GetObservatoryUri
        {
            return null;    // TODO: ??
        }

        // Send an empty platform message to Dart.
        private static void NativeDispatchEmptyPlatformMessage(
            AndroidShellHolder shellHolder,
            string channel,
            int responseId) // native shell::DispatchEmptyPlatformMessage
        {
            ((PlatformViewAndroid)shellHolder.PlatformView).DispatchPlatformMessage(channel, null, responseId);
        }

        // Send a data-carrying platform message to Dart.
        private static void nativeDispatchPlatformMessage(
            AndroidShellHolder shellHolder,
            string channel, object message, int responseId) // native shell::DispatchPlatformMessage
        {
            ((PlatformViewAndroid)shellHolder.PlatformView).DispatchPlatformMessage(channel, message, responseId);
        }

        // Send an empty response to a platform message received from Dart.
        private static void nativeInvokePlatformMessageEmptyResponseCallback(
            AndroidShellHolder shellHolder, int responseId) // c++  native shell::InvokePlatformMessageEmptyResponseCallback
        {
            ((PlatformViewAndroid)shellHolder.PlatformView).InvokePlatformMessageEmptyResponseCallback(responseId);
        }

        // Send a data-carrying response to a platform message received from Dart.
        private static void nativeInvokePlatformMessageResponseCallback(
            AndroidShellHolder shellHolder, int responseId,
            object message) // c++  native shell::InvokePlatformMessageResponseCallback
        {
            ((PlatformViewAndroid)shellHolder.PlatformView).InvokePlatformMessageResponseCallback(responseId, message);
        }

        // c++  FlutterViewHandlePlatformMessageResponse
        // java FlutternativeView -> handlePlatformMessageResponse
    }
}
