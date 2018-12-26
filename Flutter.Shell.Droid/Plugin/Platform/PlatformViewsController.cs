using Android.Content;
using Android.OS;
using Android.Util;
using Android.Views;
using Flutter.Shell.Droid.Plugin.Common;
using Flutter.Shell.Droid.View;
using Java.Lang;
using System.Collections.Generic;
using LayoutDirection = Android.Views.LayoutDirection;
using Math = System.Math;

namespace Flutter.Shell.Droid.Plugin.Platform
{
    /**
     * Manages platform views.
     * <p>
     * Each {@link io.flutter.app.FlutterPluginRegistry} has a single platform views controller.
     * A platform views controller can be attached to at most one Flutter view.
     */
    public class PlatformViewsController : IMethodCallHandler
    {
        private static readonly string TAG = "PlatformViewsController";

        private static readonly string CHANNEL_NAME = "flutter/platform_views";

        // API level 20 is required for VirtualDisplay#setSurface which we use when resizing a platform view.
        private static readonly BuildVersionCodes MINIMAL_SDK = BuildVersionCodes.KitkatWatch;

        private PlatformViewRegistryImpl _registry;

        // The context of the Activity or Fragment hosting the render target for the Flutter engine.
        private Context _context;

        // The texture registry maintaining the textures into which the embedded views will be rendered.
        private ITextureRegistry _textureRegistry;

        // The messenger used to communicate with the framework over the platform views channel.
        private IBinaryMessenger _messenger;

        private Dictionary<int, VirtualDisplayController> _vdControllers;

        public PlatformViewsController()
        {
            _registry      = new PlatformViewRegistryImpl();
            _vdControllers = new Dictionary<int, VirtualDisplayController>();
        }

        /**
         * Attaches this platform views controller to its input and output channels.
         *
         * @param context The base context that will be passed to embedded views created by this controller.
         *                This should be the context of the Activity hosting the Flutter application.
         * @param textureRegistry The texture registry which provides the output textures into which the embedded views
         *                        will be rendered.
         * @param messenger The Flutter application on the other side of this messenger drives this platform views controller.
         */
        public void Attach(Context context, ITextureRegistry textureRegistry, IBinaryMessenger messenger)
        {
            if (_context != null)
            {
                throw new AssertionError(
                    "A PlatformViewsController can only be attached to a single output target.\n" +
                    "attach was called while the PlatformViewsController was already attached."
                );
            }

            _context         = context;
            _textureRegistry = textureRegistry;
            _messenger       = messenger;
            MethodChannel channel = new MethodChannel(messenger, CHANNEL_NAME, StandardMethodCodec.Instance);
            channel.SetMethodCallHandler(this);
        }

        /**
         * Detaches this platform views controller.
         *
         * This is typically called when a Flutter applications moves to run in the background, or is destroyed.
         * After calling this the platform views controller will no longer listen to it's previous messenger, and will
         * not maintain references to the texture registry, context, and messenger passed to the previous attach call.
         */
        public void Detach()
        {
            _messenger.SetMessageHandler(CHANNEL_NAME, null);
            _messenger       = null;
            _context         = null;
            _textureRegistry = null;
        }

        public IPlatformViewRegistry GetRegistry()
        {
            return _registry;
        }

        public void OnFlutterViewDestroyed()
        {
            FlushAllViews();
        }

        public void OnPreEngineRestart()
        {
            FlushAllViews();
        }

        //@Override
        public void OnMethodCall(MethodCall call, IResult result)
        {
            if (Build.VERSION.SdkInt < MINIMAL_SDK)
            {
                Log.Error(
                    TAG,
                    "Trying to use platform views with API " + Build.VERSION.SdkInt
                    + ", required API level is: " + MINIMAL_SDK);
                return;
            }

            switch (call.Method)
            {
            case "create":
                CreatePlatformView(call, result);
                return;
            case "dispose":
                DisposePlatformView(call, result);
                return;
            case "resize":
                ResizePlatformView(call, result);
                return;
            case "touch":
                OnTouch(call, result);
                return;
            case "setDirection":
                SetDirection(call, result);
                return;
            }

            result.NotImplemented();
        }

        //@TargetApi(Build.VERSION_CODES.JELLY_BEAN_MR1)
        private void CreatePlatformView(MethodCall call, IResult result)
        {
            Dictionary<string, object> args = (Dictionary<string, object>)call.Arguments;
            int id = (int)args["id"];
            string viewType = (string)args["viewType"];
            double logicalWidth = (double)args["width"];
            double logicalHeight = (double)args["height"];
            LayoutDirection direction = (LayoutDirection)args["direction"];

            if (!ValidateDirection(direction))
            {
                result.Error(
                    "error",
                    "Trying to create a view with unknown direction value: " + direction + "(view id: " + id + ")",
                    null
                );
                return;
            }

            if (_vdControllers.ContainsKey(id))
            {
                result.Error(
                    "error",
                    "Trying to create an already created platform view, view id: " + id,
                    null
                );
                return;
            }

            PlatformViewFactory viewFactory = _registry.GetFactory(viewType);
            if (viewFactory == null)
            {
                result.Error(
                    "error",
                    "Trying to create a platform view of unregistered type: " + viewType,
                    null
                );
                return;
            }

            object createParams = null;
            if (args.ContainsKey("params"))
            {
                createParams = viewFactory.GetCreateArgsCodec().DecodeMessage(
                    args["params"]
                    //ByteBuffer.wrap((byte[])args.get("params"))
                );
            }

            var textureEntry = _textureRegistry.CreateSurfaceTexture();
            VirtualDisplayController vdController = VirtualDisplayController.Create(
                _context,
                viewFactory,
                textureEntry,
                ToPhysicalPixels(logicalWidth),
                ToPhysicalPixels(logicalHeight),
                id,
                createParams
            );

            if (vdController == null)
            {
                result.Error(
                    "error",
                    "Failed creating virtual display for a " + viewType + " with id: " + id,
                    null
                );
                return;
            }

            _vdControllers[id]                     = vdController;
            vdController.GetView().LayoutDirection = direction;

            // TODO(amirh): copy accessibility nodes to the FlutterView's accessibility tree.

            result.Success(textureEntry.Id);
        }

        private void DisposePlatformView(MethodCall call, IResult result)
        {
            int id = (int)call.Arguments;

            VirtualDisplayController vdController = _vdControllers[id];
            if (vdController == null)
            {
                result.Error(
                    "error",
                    "Trying to dispose a platform view with unknown id: " + id,
                    null
                );
                return;
            }

            vdController.Dispose();
            _vdControllers.Remove(id);
            result.Success(null);
        }

        private void ResizePlatformView(MethodCall call, IResult result)
        {
            Dictionary<string, object> args = (Dictionary<string, object>)call.Arguments;
            int id = (int)args["id"];
            double width = (double)args["width"];
            double height = (double)args["height"];

            VirtualDisplayController vdController = _vdControllers[id];
            if (vdController == null)
            {
                result.Error(
                    "error",
                    "Trying to resize a platform view with unknown id: " + id,
                    null
                );
                return;
            }

            vdController.Resize(
                ToPhysicalPixels(width),
                ToPhysicalPixels(height),
                () => result.Success(null)); // Runnable
        }

        public void OnTouch(MethodCall call, IResult result)
        {
            List<object> args = (List<object>)call.Arguments;

            float density = _context.Resources.DisplayMetrics.Density;

            int id = (int)args[0];
            Number downTime = (Number)args[1];
            Number eventTime = (Number)args[2];
            MotionEventActions action = (MotionEventActions)args[3];
            int pointerCount = (int)args[4];
            var pointerProperties = ParsePointerPropertiesList(args[5]);
            var pointerCoords = ParsePointerCoordsList(args[6], density);

            MetaKeyStates metaState = (MetaKeyStates)args[7];
            MotionEventButtonState buttonState = (MotionEventButtonState)args[8];
            float xPrecision = (float)(double)args[9];
            float yPrecision = (float)(double)args[10];
            int deviceId = (int)args[11];
            Edge edgeFlags = (Edge)args[12];
            InputSourceType source = (InputSourceType)args[13];
            MotionEventFlags flags = (MotionEventFlags)args[14];

            Android.Views.View view = _vdControllers[id].GetView();
            if (view == null)
            {
                result.Error(
                    "error",
                    "Sending touch to an unknown view with id: " + id,
                    null
                );
                return;
            }

            var @event = MotionEvent.Obtain(
                downTime.LongValue(),
                eventTime.LongValue(),
                action,
                pointerCount,
                pointerProperties.ToArray(),
                pointerCoords.ToArray(),
                metaState,
                buttonState,
                xPrecision,
                yPrecision,
                deviceId,
                edgeFlags,
                source,
                flags
            );

            view.DispatchTouchEvent(@event);
            result.Success(null);
        }

        //@TargetApi(Build.VERSION_CODES.JELLY_BEAN_MR1)
        private void SetDirection(MethodCall call, IResult result)
        {
            var args = (Dictionary<string, object>)call.Arguments;
            int id = (int)args["id"];
            var direction = (LayoutDirection)args["direction"];

            if (!ValidateDirection(direction))
            {
                result.Error(
                    "error",
                    "Trying to set unknown direction value: " + direction + "(view id: " + id + ")",
                    null
                );
                return;
            }

            var view = _vdControllers[id].GetView();
            if (view == null)
            {
                result.Error(
                    "error",
                    "Sending touch to an unknown view with id: " + id,
                    null
                );
                return;
            }

            view.LayoutDirection = direction;
            result.Success(null);
        }

        private static bool ValidateDirection(LayoutDirection direction)
        {
            return direction == LayoutDirection.Ltr || direction == LayoutDirection.Rtl;
        }

        //@SuppressWarnings("unchecked")
        private static List<MotionEvent.PointerProperties> ParsePointerPropertiesList(object rawPropertiesList)
        {
            List<object> rawProperties = (List<object>)rawPropertiesList;
            List<MotionEvent.PointerProperties> pointerProperties = new List<MotionEvent.PointerProperties>();
            foreach (object o in rawProperties)
            {
                pointerProperties.Add(ParsePointerProperties(o));
            }

            return pointerProperties;
        }

        //@SuppressWarnings("unchecked")
        private static MotionEvent.PointerProperties ParsePointerProperties(object rawProperties)
        {
            List<object> propertiesList = (List<object>)rawProperties;
            MotionEvent.PointerProperties properties = new MotionEvent.PointerProperties
            {
                Id       = (int)propertiesList[0],
                ToolType = (MotionEventToolType)propertiesList[1]
            };
            return properties;
        }

        //@SuppressWarnings("unchecked")
        private static List<MotionEvent.PointerCoords> ParsePointerCoordsList(object rawCoordsList, float density)
        {
            var rawCoords = (List<object>)rawCoordsList;
            var pointerCoords = new List<MotionEvent.PointerCoords>();
            foreach (object o in rawCoords)
            {
                pointerCoords.Add(ParsePointerCoords(o, density));
            }

            return pointerCoords;
        }

        //@SuppressWarnings("unchecked")
        private static MotionEvent.PointerCoords ParsePointerCoords(object rawCoords, float density)
        {
            List<object> coordsList = (List<object>)rawCoords;
            MotionEvent.PointerCoords coords = new MotionEvent.PointerCoords
            {
                Orientation = (float)(double)coordsList[0],
                Pressure    = (float)(double)coordsList[1],
                Size        = (float)(double)coordsList[2],
                ToolMajor   = (float)(double)coordsList[3] * density,
                ToolMinor   = (float)(double)coordsList[4] * density,
                TouchMajor  = (float)(double)coordsList[5] * density,
                TouchMinor  = (float)(double)coordsList[6] * density,
                X           = (float)(double)coordsList[7] * density,
                Y           = (float)(double)coordsList[8] * density
            };
            return coords;
        }

        private int ToPhysicalPixels(double logicalPixels)
        {
            float density = _context.Resources.DisplayMetrics.Density;
            return (int)Math.Round(logicalPixels * density);
        }

        private void FlushAllViews()
        {
            foreach (VirtualDisplayController controller in _vdControllers.Values)
                controller.Dispose();
            _vdControllers.Clear();
        }
    }
}
