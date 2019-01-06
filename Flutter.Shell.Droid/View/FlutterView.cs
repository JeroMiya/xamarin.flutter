using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Database;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Views.Accessibility;
using Android.Views.InputMethods;
using Flutter.Shell.Droid.App;
using Flutter.Shell.Droid.Plugin.Common;
using Flutter.Shell.Droid.Plugin.Editing;
using FlutterSDK;
using Java.Util.Concurrent.Atomic;
using System;
using FlutterBinding.Plugin.Common;
using FlutterBinding.Shell;
using FlutterBinding.UI;
using SkiaSharp;
using Format = Android.Graphics.Format;
using KeyboardType = Android.Views.KeyboardType;
using Keycode = Android.Views.Keycode;
using Rasterizer = FlutterBinding.Shell.Rasterizer;
using Rect = Android.Graphics.Rect;
using Surface = Android.Views.Surface;

namespace Flutter.Shell.Droid.View
{
    public class FlutterView :
        SurfaceView,
        ISurfaceHolderCallback,
        IBinaryMessenger,
        ITextureRegistry,
        AccessibilityManager.IAccessibilityStateChangeListener
    {
        private static readonly string TAG = "FlutterView";

        private InputMethodManager _imm;
        private TextInputPlugin _textInputPlugin;
        private readonly ISurfaceHolderCallback _surfaceCallback;
        private ViewportMetrics _metrics;
        private readonly AccessibilityManager _accessibilityManager;
        private MethodChannel _flutterLocalizationChannel;
        private MethodChannel _flutterNavigationChannel;
        private BasicMessageChannel<object> _flutterKeyEventChannel;
        private BasicMessageChannel<string> _flutterLifecycleChannel;
        private BasicMessageChannel<object> _flutterSystemChannel;
        private BasicMessageChannel<object> _flutterSettingsChannel;

        private System.Collections.Generic.List<IActivityLifecycleListener> _activityLifecycleListeners;

        //private System.Collections.Generic.List<FirstFrameListener> _firstFrameListeners;
        private readonly AtomicLong _nextTextureId = new AtomicLong(0L);
        private FlutterNativeView _nativeView;
        private readonly AnimationScaleObserver _animationScaleObserver;
        private readonly bool _isSoftwareRenderingEnabled = false; // using the software renderer or not
        private IInputConnection _lastInputConnection;

        public EventHandler FirstFrame;

        /// <inheritdoc />
        protected FlutterView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        /// <inheritdoc />
        public FlutterView(Context context) : this(context, null) { }

        /// <inheritdoc />
        public FlutterView(Context context, IAttributeSet attrs) : this(context, attrs, null) { }

        public FlutterView(Context context, IAttributeSet attrs, FlutterNativeView nativeView) : base(context, attrs)
        {
            _isSoftwareRenderingEnabled = NativeGetIsSoftwareRenderingEnabled();
            _animationScaleObserver     = new AnimationScaleObserver(this, new Handler());
            _metrics = new ViewportMetrics
            {
                DevicePixelRatio = context.Resources.DisplayMetrics.Density
            };
            SetFocusable(ViewFocusability.Focusable);
            // SetFocusableInTouchMode(true);   // Not required with Compat

            Activity activity = (Activity)Context;
            _nativeView = nativeView ?? new FlutterNativeView(activity.ApplicationContext);
            _nativeView.AttachViewAndActivity(this, activity);

            _surfaceCallback = (ISurfaceHolderCallback)this;
            Holder.AddCallback(_surfaceCallback);

            _accessibilityManager = (AccessibilityManager)Context.GetSystemService(Context.AccessibilityService);

            _activityLifecycleListeners = new System.Collections.Generic.List<IActivityLifecycleListener>();

            // Configure the platform plugins and flutter channels.
            _flutterLocalizationChannel = new MethodChannel(this, "flutter/localization", StandardMethodCodec.Instance);            // JSON
            _flutterNavigationChannel   = new MethodChannel(this, "flutter/navigation", StandardMethodCodec.Instance);              // JSON
            _flutterKeyEventChannel     = new BasicMessageChannel<object>(this, "flutter/keyevent", StandardMessageCodec.Instance); // JSON
            _flutterLifecycleChannel    = new BasicMessageChannel<string>(this, "flutter/lifecycle", StringCodec.Instance);         // string
            _flutterSystemChannel       = new BasicMessageChannel<object>(this, "flutter/system", StandardMessageCodec.Instance);   // JSON
            _flutterSettingsChannel     = new BasicMessageChannel<object>(this, "flutter/settings", StandardMessageCodec.Instance); //JSON

            //PlatformPlugin platformPlugin = new PlatformPlugin(activity);
            //MethodChannel flutterPlatformChannel = new MethodChannel(this, "flutter/platform", JSONMethodCodec.INSTANCE);
            //flutterPlatformChannel.setMethodCallHandler(platformPlugin);
            //addActivityLifecycleListener(platformPlugin);
            _imm             = (InputMethodManager)Context.GetSystemService(Context.InputMethodService);
            _textInputPlugin = new TextInputPlugin(this);
        }

        /// <inheritdoc />
        void ISurfaceHolderCallback.SurfaceChanged(ISurfaceHolder holder, Format format, int width, int height)
        {
            AssertAttached();
            NativeSurfaceChanged(_nativeView.Get(), width, height);
        }

        /// <inheritdoc />
        void ISurfaceHolderCallback.SurfaceCreated(ISurfaceHolder holder)
        {
            AssertAttached();
            NativeSurfaceCreated(_nativeView.Get(), holder.Surface);
        }

        /// <inheritdoc />
        void ISurfaceHolderCallback.SurfaceDestroyed(ISurfaceHolder holder)
        {
            AssertAttached();
            NativeSurfaceDestroyed(_nativeView.Get());
        }

        private void EncodeKeyEvent(KeyEvent @event, System.Collections.Generic.Dictionary<string, object> message)
        {
            message["flags"]     = @event.Flags;
            message["codePoint"] = @event.UnicodeChar;
            message["keyCode"]   = @event.KeyCode;
            message["scanCode"]  = @event.ScanCode;
            message["metaState"] = @event.MetaState;
        }

        //@Override
        public override bool OnKeyUp(Keycode keyCode, KeyEvent @event)
        {
            if (!IsAttached())
            {
                return base.OnKeyUp(keyCode, @event);
            }

            System.Collections.Generic.Dictionary<string, object> message = new System.Collections.Generic.Dictionary<string, object>
            {
                ["type"]   = "keyup",
                ["keymap"] = "android"
            };
            EncodeKeyEvent(@event, message);
            _flutterKeyEventChannel.Send(message);
            return base.OnKeyUp(keyCode, @event);
        }

        //@Override
        public override bool OnKeyDown(Keycode keyCode, KeyEvent @event)
        {
            if (!IsAttached())
            {
                return base.OnKeyDown(keyCode, @event);
            }

            if (@event.DeviceId != (int)KeyboardType.VirtualKeyboard)
            {
                if (_lastInputConnection != null && _imm.IsAcceptingText)
                {
                    _lastInputConnection.SendKeyEvent(@event);
                }
            }

            System.Collections.Generic.Dictionary<string, object> message = new System.Collections.Generic.Dictionary<string, object>
            {
                ["type"]   = "keydown",
                ["keymap"] = "android"
            };
            EncodeKeyEvent(@event, message);
            _flutterKeyEventChannel.Send(message);
            return base.OnKeyDown(keyCode, @event);
        }

        public FlutterNativeView GetFlutterNativeView()
        {
            return _nativeView;
        }

        public FlutterPluginRegistry GetPluginRegistry()
        {
            return _nativeView.GetPluginRegistry();
        }

        public string GetLookupKeyForAsset(string asset)
        {
            return FlutterMainAndroid.GetLookupKeyForAsset(asset);
        }

        public string GetLookupKeyForAsset(string asset, string packageName)
        {
            return FlutterMainAndroid.GetLookupKeyForAsset(asset, packageName);
        }

        public void AddActivityLifecycleListener(IActivityLifecycleListener listener)
        {
            _activityLifecycleListeners.Add(listener);
        }

        public void OnStart()
        {
            _flutterLifecycleChannel.Send("AppLifecycleState.inactive");
        }

        public void OnPause()
        {
            _flutterLifecycleChannel.Send("AppLifecycleState.inactive");
        }

        public void OnPostResume()
        {
            UpdateAccessibilityFeatures();
            foreach (IActivityLifecycleListener listener in _activityLifecycleListeners)
            {
                listener.OnPostResume();
            }

            _flutterLifecycleChannel.Send("AppLifecycleState.resumed");
        }

        public void OnStop()
        {
            _flutterLifecycleChannel.Send("AppLifecycleState.paused");
        }

        public void OnMemoryPressure()
        {
            System.Collections.Generic.Dictionary<string, object> message = new System.Collections.Generic.Dictionary<string, object>(1) {["type"] = "memoryPressure"};
            _flutterSystemChannel.Send(message);
        }

        /**
         * Provide a listener that will be called once when the FlutterView renders its
         * first frame to the underlaying SurfaceView.
         */
        public void AddFirstFrameListener(System.Action listener)
        {
            FirstFrame += (s, e) => listener();
        }

        /**
         * Updates this to support rendering as a transparent {@link SurfaceView}.
         *
         * Sets it on top of its window. The background color still needs to be
         * controlled from within the Flutter UI itself.
         */
        public void EnableTransparentBackground()
        {
            SetZOrderOnTop(true);
            Holder.SetFormat(Format.Transparent);
        }

        /**
         * Reverts this back to the {@link SurfaceView} defaults, at the back of its
         * window and opaque.
         */
        public void DisableTransparentBackground()
        {
            SetZOrderOnTop(false);
            Holder.SetFormat(Format.Opaque);
        }

        public void SetInitialRoute(string route)
        {
            _flutterNavigationChannel.InvokeMethod("setInitialRoute", route);
        }

        public void PushRoute(string route)
        {
            _flutterNavigationChannel.InvokeMethod("pushRoute", route);
        }

        public void PopRoute()
        {
            _flutterNavigationChannel.InvokeMethod("popRoute", null);
        }

        public float GetDevicePixelRatio() => _metrics.DevicePixelRatio;

        public FlutterNativeView Detach()
        {
            if (!IsAttached())
                return null;
            Holder.RemoveCallback(_surfaceCallback);
            _nativeView.Detach();

            FlutterNativeView view = _nativeView;
            _nativeView = null;
            return view;
        }

        public void Destroy()
        {
            if (!IsAttached())
                return;

            Holder.RemoveCallback(_surfaceCallback);

            _nativeView.Destroy();
            _nativeView = null;
        }

        //@Override
        public override IInputConnection OnCreateInputConnection(EditorInfo outAttrs)
        {
            try
            {
                _lastInputConnection = _textInputPlugin.CreateInputConnection(this, outAttrs);
                return _lastInputConnection;
            }
            catch (Exception e)
            {
                Log.Error(TAG, "Failed to create input connection", e);
                return null;
            }
        }

        // Must match the PointerChange enum in pointer.dart.
        private static readonly int kPointerChangeCancel = 0;
        private static readonly int kPointerChangeAdd = 1;
        private static readonly int kPointerChangeRemove = 2;
        private static readonly int kPointerChangeHover = 3;
        private static readonly int kPointerChangeDown = 4;
        private static readonly int kPointerChangeMove = 5;
        private static readonly int kPointerChangeUp = 6;

        // Must match the PointerDeviceKind enum in pointer.dart.
        private static readonly int kPointerDeviceKindTouch = 0;
        private static readonly int kPointerDeviceKindMouse = 1;
        private static readonly int kPointerDeviceKindStylus = 2;
        private static readonly int kPointerDeviceKindInvertedStylus = 3;
        private static readonly int kPointerDeviceKindUnknown = 4;

        public PointerChange GetPointerChangeForAction(MotionEventActions maskedAction)
        {
            // Primary pointer:
            if (maskedAction == MotionEventActions.Down)
                return PointerChange.down;

            if (maskedAction == MotionEventActions.Up)
                return PointerChange.up;

            // Secondary pointer:
            if (maskedAction == MotionEventActions.PointerDown)
                return PointerChange.down;

            if (maskedAction == MotionEventActions.PointerUp)
                return PointerChange.up;

            // All pointers:
            if (maskedAction == MotionEventActions.Move)
                return PointerChange.move;

            if (maskedAction == MotionEventActions.Cancel)
                return PointerChange.cancel;

            return PointerChange.unknown;
        }

        public PointerDeviceKind GetPointerDeviceTypeForToolType(MotionEventToolType toolType)
        {
            switch (toolType)
            {
            case MotionEventToolType.Finger:
                return PointerDeviceKind.touch;
            case MotionEventToolType.Stylus:
                return PointerDeviceKind.stylus;
            case MotionEventToolType.Mouse:
                return PointerDeviceKind.mouse;
            case MotionEventToolType.Eraser:
                return PointerDeviceKind.invertedStylus;
            default:
                // MotionEvent.TOOL_TYPE_UNKNOWN will reach here.
                return PointerDeviceKind.unknown;
            }
        }

        /*
        public class PointerParameter
        {
            public long Timestamp;
            public int PointerIndex;
            public int PointerChange;
            public int PointerKind;
            public MotionEvent MotionEvent;
            public int PointerId;
            public float X;
            public float Y;
            public long ButtonState;
            public double Pressure;
            public double PressureMin;
            public double PressureMax;
            public double Distance;
            public double DistanceMax;
            public double Size;
            public double RadiusMinor;
            public double RadiusMajor;
            public double RadiusMin;
            public double RadiusMax;
            public double Orientation;
            public double Tilt;
            public long PointerData;
        }
        */

        // TODO: ByteBuffer->object
        public PointerData AddPointerForIndex(MotionEvent @event, int pointerIndex, PointerChange pointerChange, int pointerData)
        {
            if (pointerChange == PointerChange.unknown)
                return null;

            PointerDeviceKind pointerKind = GetPointerDeviceTypeForToolType(@event.GetToolType(pointerIndex));
            int buttonState = 0;
            double tilt = 0.0d;

            if (pointerKind == PointerDeviceKind.mouse)
                buttonState = (int)@event.ButtonState & 0x1F; // mouse buttons
            else if (pointerKind == PointerDeviceKind.stylus)
            {
                buttonState = ((int)@event.ButtonState >> 4) & 0xF; // stylus buttons
                tilt        = @event.GetAxisValue(Axis.Tilt, pointerIndex);
            }

            double pressure = @event.GetPressure(pointerIndex);
            float distance = @event.GetAxisValue(Axis.Distance, pointerIndex);
            float size = @event.GetSize(pointerIndex);
            float radiusMajor = @event.GetToolMajor(pointerIndex);
            float radiusMinor = @event.GetToolMinor(pointerIndex);
            float orientation = @event.GetAxisValue(Axis.Orientation, pointerIndex);

            var device = @event.GetPointerId(pointerIndex);
            return new PointerData
            (
                timeStamp: TimeSpan.FromMilliseconds(@event.EventTime), // Convert from milliseconds to microseconds.
                change: pointerChange,
                kind: pointerKind,
                device: device,
                physicalX: @event.GetX(pointerIndex),
                physicalY: @event.GetY(pointerIndex),
                buttons: buttonState,
                obscured: false,
                pressure: pressure,
                pressureMin: 0.0,
                pressureMax: 1.0,
                distance: distance,
                distanceMax: 0.0,
                radiusMajor: radiusMajor,
                radiusMinor: radiusMinor,
                radiusMin: 0.0,
                radiusMax: 0.0,
                orientation: orientation,
                tilt: tilt,
                size: size
                //PointerData   = pointerData
                //MotionEvent = @event
            );
        }

        //@Override
        public override bool OnTouchEvent(MotionEvent @event)
        {
            if (!IsAttached())
            {
                return false;
            }

            // TODO(abarth): This version check might not be effective in some
            // versions of Android that statically compile code and will be upset
            // at the lack of |requestUnbufferedDispatch|. Instead, we should factor
            // version-dependent code into separate classes for each supported
            // version and dispatch dynamically.
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                RequestUnbufferedDispatch(@event);
            }

            // These values must match the unpacking code in hooks.dart.
            int kPointerDataFieldCount = 21;
            int kBytePerField = 8;

            // This value must match the value in framework's platform_view.dart.
            // This flag indicates whether the original Android pointer events were batched together.
            int kPointerDataFlagBatched = 1;

            int pointerCount = @event.PointerCount;

            //ByteBuffer packet = ByteBuffer.allocateDirect(pointerCount * kPointerDataFieldCount * kBytePerField);
            //packet.order(ByteOrder.LITTLE_ENDIAN);

            PointerDataPacket packet = new PointerDataPacket();
            //List<PointerParameter> packet = new List<PointerParameter>();

            MotionEventActions maskedAction = @event.ActionMasked;
            PointerChange pointerChange = GetPointerChangeForAction(@event.ActionMasked);
            if (maskedAction == MotionEventActions.Down || maskedAction == MotionEventActions.PointerDown)
            {
                // ACTION_DOWN and ACTION_POINTER_DOWN always apply to a single pointer only.
                packet.data.Add(
                    AddPointerForIndex(@event, @event.ActionIndex, pointerChange, 0));
            }
            else if (maskedAction == MotionEventActions.Up || maskedAction == MotionEventActions.PointerUp)
            {
                // ACTION_UP and ACTION_POINTER_UP may contain position updates for other pointers.
                // We are converting these updates to move events here in order to preserve this data.
                // We also mark these events with a flag in order to help the framework reassemble
                // the original Android event later, should it need to forward it to a PlatformView.
                for (int p = 0; p < pointerCount; p++)
                {
                    if (p != @event.ActionIndex)
                    {
                        if (@event.GetToolType(p) == MotionEventToolType.Finger)
                        {
                            packet.data.Add(
                                AddPointerForIndex(@event, p, PointerChange.move, kPointerDataFlagBatched));
                        }
                    }
                }

                // It's important that we're sending the UP event last. This allows PlatformView
                // to correctly batch everything back into the original Android event if needed.
                packet.data.Add(
                    AddPointerForIndex(@event, @event.ActionIndex, pointerChange, 0));
            }
            else
            {
                // ACTION_MOVE may not actually mean all pointers have moved
                // but it's the responsibility of a later part of the system to
                // ignore 0-deltas if desired.
                for (int p = 0; p < pointerCount; p++)
                {
                    packet.data.Add(
                        AddPointerForIndex(@event, p, pointerChange, 0));
                }
            }

            //assert packet.position() % (kPointerDataFieldCount* kBytePerField) == 0;
            NativeDispatchPointerDataPacket(_nativeView.Get(), packet);
            return true;
        }

        //@Override
        public override bool OnHoverEvent(MotionEvent @event)
        {
            if (!IsAttached())
            {
                return false;
            }

            bool handled = HandleAccessibilityHoverEvent(@event);
            if (!handled)
            {
                // TODO(ianh): Expose hover events to the platform,
                // implementing ADD, REMOVE, etc.
            }

            return handled;
        }

        //@Override
        protected override void OnSizeChanged(int width, int height, int oldWidth, int oldHeight)
        {
            _metrics.PhysicalWidth  = width;
            _metrics.PhysicalHeight = height;
            UpdateViewportMetrics();
            base.OnSizeChanged(width, height, oldWidth, oldHeight);
        }

        // TODO(garyq): Add support for notch cutout API
        // Decide if we want to zero the padding of the sides. When in Landscape orientation,
        // android may decide to place the software navigation bars on the side. When the nav
        // bar is hidden, the reported insets should be removed to prevent extra useless space
        // on the sides.
        public enum ZeroSides
        {
            None,
            Left,
            Right,
            Both
        }

        public ZeroSides CalculateShouldZeroSides()
        {
            // We get both orientation and rotation because rotation is all 4
            // rotations relative to default rotation while orientation is portrait
            // or landscape. By combining both, we can obtain a more precise measure
            // of the rotation.
            Activity activity = (Activity)Context;
            Orientation orientation = activity.Resources.Configuration.Orientation;
            SurfaceOrientation rotation = activity.WindowManager.DefaultDisplay.Rotation;

            if (orientation == Orientation.Landscape)
            {
                if (rotation == SurfaceOrientation.Rotation90)
                    return ZeroSides.Right;

                if (rotation == SurfaceOrientation.Rotation270)
                    // In android API >= 23, the nav bar always appears on the "bottom" (USB) side.
                    return Build.VERSION.SdkInt >= BuildVersionCodes.M ? ZeroSides.Left : ZeroSides.Right;

                // Ambiguous orientation due to landscape left/right default. Zero both sides.
                if (rotation == SurfaceOrientation.Rotation0 || rotation == SurfaceOrientation.Rotation180)
                    return ZeroSides.Both;
            }

            // Square orientation deprecated in API 16, we will not check for it and return false
            // to be safe and not remove any unique padding for the devices that do use it.
            return ZeroSides.None;
        }

        // TODO(garyq): Use clean ways to detect keyboard instead of heuristics if possible
        // TODO(garyq): The keyboard detection may interact strangely with
        //   https://github.com/flutter/flutter/issues/22061

        // Uses inset heights and screen heights as a heuristic to determine if the insets should
        // be padded. When the on-screen keyboard is detected, we want to include the full inset
        // but when the inset is just the hidden nav bar, we want to provide a zero inset so the space
        // can be used.
        private int CalculateBottomKeyboardInset(WindowInsets insets)
        {
            int screenHeight = RootView.Height;
            // Magic number due to this being a heuristic. This should be replaced, but we have not
            // found a clean way to do it yet (Sept. 2018)
            double keyboardHeightRatioHeuristic = 0.18;
            if (insets.SystemWindowInsetBottom < screenHeight * keyboardHeightRatioHeuristic)
            {
                // Is not a keyboard, so return zero as inset.
                return 0;
            }
            else
            {
                // Is a keyboard, so return the full inset.
                return insets.SystemWindowInsetBottom;
            }
        }

        // This callback is not present in API < 20, which means lower API devices will see
        // the wider than expected padding when the status and navigation bars are hidden.
        //@Override
        public override WindowInsets OnApplyWindowInsets(WindowInsets insets)
        {
            bool statusBarHidden = WindowSystemUiVisibility.HasFlag(SystemUiFlags.Fullscreen);
            bool navigationBarHidden = WindowSystemUiVisibility.HasFlag(SystemUiFlags.HideNavigation);

            // We zero the left and/or right sides to prevent the padding the
            // navigation bar would have caused.
            ZeroSides zeroSides = ZeroSides.None;
            if (navigationBarHidden)
            {
                zeroSides = CalculateShouldZeroSides();
            }

            // The padding on top should be removed when the statusbar is hidden.
            _metrics.PhysicalPaddingTop = statusBarHidden ? 0 : insets.SystemWindowInsetTop;
            _metrics.PhysicalPaddingRight =
                zeroSides == ZeroSides.Right || zeroSides == ZeroSides.Both ? 0 : insets.SystemWindowInsetRight;
            _metrics.PhysicalPaddingBottom = 0;
            _metrics.PhysicalPaddingLeft =
                zeroSides == ZeroSides.Left || zeroSides == ZeroSides.Both ? 0 : insets.SystemWindowInsetLeft;

            // Bottom system inset (keyboard) should adjust scrollable bottom edge (inset).
            _metrics.PhysicalViewInsetTop   = 0;
            _metrics.PhysicalViewInsetRight = 0;
            // We perform hidden navbar and keyboard handling if the navbar is set to hidden. Otherwise,
            // the navbar padding should always be provided.
            _metrics.PhysicalViewInsetBottom =
                navigationBarHidden ? CalculateBottomKeyboardInset(insets) : insets.SystemWindowInsetBottom;
            _metrics.PhysicalViewInsetLeft = 0;
            UpdateViewportMetrics();
            return base.OnApplyWindowInsets(insets);
        }

        //@Override
        //@SuppressWarnings("deprecation")
        [Obsolete("deprecated")]
        protected override bool FitSystemWindows(Rect insets)
        {
            if (Build.VERSION.SdkInt <= BuildVersionCodes.Kitkat)
            {
                // Status bar, left/right system insets partially obscure content (padding).
                _metrics.PhysicalPaddingTop    = insets.Top;
                _metrics.PhysicalPaddingRight  = insets.Right;
                _metrics.PhysicalPaddingBottom = 0;
                _metrics.PhysicalPaddingLeft   = insets.Left;

                // Bottom system inset (keyboard) should adjust scrollable bottom edge (inset).
                _metrics.PhysicalViewInsetTop    = 0;
                _metrics.PhysicalViewInsetRight  = 0;
                _metrics.PhysicalViewInsetBottom = insets.Bottom;
                _metrics.PhysicalViewInsetLeft   = 0;
                UpdateViewportMetrics();
                return true;
            }

            return base.FitSystemWindows(insets);
        }

        private bool IsAttached()
        {
            return _nativeView != null && _nativeView.IsAttached();
        }

        private void AssertAttached()
        {
            if (!IsAttached())
                throw new AssertionError("Platform view is not attached");
        }

        private void PreRun()
        {
            ResetAccessibilityTree();
        }

        private void PostRun() { }

        public void RunFromBundle(FlutterRunArguments args)
        {
            AssertAttached();
            PreRun();
            _nativeView.RunFromBundle(args);
            PostRun();
        }

        /**
         * @deprecated
         * Please use runFromBundle with `FlutterRunArguments`.
         */
        //@Deprecated
        [Obsolete("deprected")]
        public void RunFromBundle(string bundlePath, string defaultPath, string entrypoint = "main")
        {
            FlutterRunArguments args = new FlutterRunArguments
            {
                BundlePath  = bundlePath,
                Entrypoint  = entrypoint,
                DefaultPath = defaultPath
            };
            RunFromBundle(args);
        }

        /**
         * Return the most recent frame as a bitmap.
         *
         * @return A bitmap.
         */
        public SKImage GetBitmap()
        {
            AssertAttached();
            return NativeGetBitmap(_nativeView.Get());
        }

        private static void NativeSurfaceCreated(AndroidShellHolder shellHolder, Surface surface) // native
        {
            shellHolder.PlatformView.NotifyCreated();
            // TODO: ???

            // Note: This frame ensures that any local references used by
            // ANativeWindow_fromSurface are released immediately. This is needed as a
            // workaround for https://code.google.com/p/android/issues/detail?id=68174
            //fml::jni::ScopedJavaLocalFrame scoped_local_reference_frame(env);
            //auto window = fml::MakeRefCounted<AndroidNativeWindow>(
            //    ANativeWindow_fromSurface(env, jsurface));
            //ANDROID_SHELL_HOLDER->GetPlatformView()->NotifyCreated(std::move(window));
        }

        private static void NativeSurfaceChanged(AndroidShellHolder shellHolder, int width, int height) // native
        {
            shellHolder.PlatformView.NotifyChanged(new SKSizeI(width, height));

        }

        private static void NativeSurfaceDestroyed(AndroidShellHolder shellHolder) // native
        {
            shellHolder.PlatformView.NotifyDestroyed();
        }

        private static void NativeSetViewportMetrics(
            AndroidShellHolder shellHolder, float devicePixelRatio,
            int physicalWidth, int physicalHeight, int physicalPaddingTop, int physicalPaddingRight,
            int physicalPaddingBottom, int physicalPaddingLeft, int physicalViewInsetTop, int physicalViewInsetRight,
            int physicalViewInsetBottom, int physicalViewInsetLeft) // native engine->SetViewportMetrics(metrics);
        {
            shellHolder.SetViewportMetrics(
                new ViewportMetrics
                {
                    DevicePixelRatio = devicePixelRatio,
                    PhysicalWidth = physicalWidth,
                    PhysicalHeight = physicalHeight,
                    PhysicalPaddingTop = physicalPaddingTop,
                    PhysicalPaddingRight = physicalPaddingRight,
                    PhysicalPaddingBottom = physicalPaddingBottom,
                    PhysicalPaddingLeft = physicalPaddingLeft,
                    PhysicalViewInsetTop = physicalViewInsetTop,
                    PhysicalViewInsetRight = physicalViewInsetRight,
                    PhysicalViewInsetBottom = physicalViewInsetBottom,
                    PhysicalViewInsetLeft = physicalViewInsetLeft
                });
        }

        private static SKImage NativeGetBitmap(AndroidShellHolder shellHolder) // native
        {
            var screenshot = shellHolder.Screenshot(Rasterizer.ScreenshotType.UncompressedImage, false);

            return screenshot?.Image;
            //SKSizeI frame_size = screenshot.FrameSize;
            //long pixels_size = frame_size.Width * frame_size.Height;
            //var pixels_array = new byte[pixels_size];
            //if (pixels_array == null)
            //    return null;

            //jint* pixels = env->GetIntArrayElements(pixels_array, nullptr);
            //if (pixels == nullptr)
            //{
            //    return nullptr;
            //}

            //auto* pixels_src = static_cast <const int32_t*> (screenshot.data->data());

            //// Our configuration of Skia does not support rendering to the
            //// BitmapConfig.ARGB_8888 format expected by android.graphics.Bitmap.
            //// Convert from kRGBA_8888 to kBGRA_8888 (equivalent to ARGB_8888).
            //for (int i = 0; i < pixels_size; i++)
            //{
            //    int32_t src_pixel = pixels_src[i];
            //    uint8_t* src_bytes = reinterpret_cast<uint8_t*>(&src_pixel);
            //    std::swap(src_bytes[0], src_bytes[2]);
            //    pixels[i] = src_pixel;
            //}

            //env->ReleaseIntArrayElements(pixels_array, pixels, 0);

            //jclass bitmap_class = env->FindClass("android/graphics/Bitmap");
            //if (bitmap_class == nullptr)
            //{
            //    return nullptr;
            //}

            //jmethodID create_bitmap = env->GetStaticMethodID(
            //    bitmap_class, "createBitmap",
            //    "([IIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
            //if (create_bitmap == nullptr)
            //{
            //    return nullptr;
            //}

            //jclass bitmap_config_class = env->FindClass("android/graphics/Bitmap$Config");
            //if (bitmap_config_class == nullptr)
            //{
            //    return nullptr;
            //}

            //jmethodID bitmap_config_value_of = env->GetStaticMethodID(
            //    bitmap_config_class, "valueOf",
            //    "(Ljava/lang/String;)Landroid/graphics/Bitmap$Config;");
            //if (bitmap_config_value_of == nullptr)
            //{
            //    return nullptr;
            //}

            //jstring argb = env->NewStringUTF("ARGB_8888");
            //if (argb == nullptr)
            //{
            //    return nullptr;
            //}

            //jobject bitmap_config = env->CallStaticObjectMethod(
            //    bitmap_config_class, bitmap_config_value_of, argb);
            //if (bitmap_config == nullptr)
            //{
            //    return nullptr;
            //}

            //return env->CallStaticObjectMethod(bitmap_class, create_bitmap, pixels_array,
            //                                   frame_size.width(), frame_size.height(),
            //                                   bitmap_config);
        }

        // TODO: ByteBuffer->object
        private static void NativeDispatchPointerDataPacket(AndroidShellHolder shellHolder, PointerDataPacket packet)
        {
            shellHolder.PlatformView.DispatchPointerDataPacket(packet);
        }
        // native

        // TODO: ByteBuffer->object
        // native shell::DispatchSemanticsAction
        private static void NativeDispatchSemanticsAction(AndroidShellHolder shellHolder, int id, SemanticsAction action, object args)
        {
            shellHolder.PlatformView.DispatchSemanticsAction(id, action, args);
        }


        private static void NativeSetSemanticsEnabled(AndroidShellHolder shellHolder, bool enabled) // native
        {
            shellHolder.PlatformView.SetSemanticsEnabled(enabled);
        }

        private static void NativeSetAccessibilityFeatures(AndroidShellHolder shellHolder, AccessibilityFeatures flags) // native
        {
            shellHolder.PlatformView.SetAccessibilityFeatures(flags);
        }

        private static bool NativeGetIsSoftwareRenderingEnabled() // native
        {
            return false;
        }

        private static void NativeRegisterTexture(AndroidShellHolder shellHolder, long textureId, SurfaceTexture surfaceTexture) // native
        {
            var platformViewAndroid = (PlatformViewAndroid)shellHolder.PlatformView;
            platformViewAndroid.RegisterExternalTexture(textureId, surfaceTexture);
        }

        private static void NativeMarkTextureFrameAvailable(AndroidShellHolder shellHolder, long textureId) // native
        {
            shellHolder.PlatformView.MarkTextureFrameAvailable(textureId);
        }


        private static void NativeUnregisterTexture(AndroidShellHolder shellHolder, long textureId) // native
        {
            shellHolder.PlatformView.UnregisterTexture(textureId);
        }

        private void UpdateViewportMetrics()
        {
            if (!IsAttached())
                return;
            NativeSetViewportMetrics(
                _nativeView.Get(),
                _metrics.DevicePixelRatio,
                _metrics.PhysicalWidth,
                _metrics.PhysicalHeight,
                _metrics.PhysicalPaddingTop,
                _metrics.PhysicalPaddingRight,
                _metrics.PhysicalPaddingBottom,
                _metrics.PhysicalPaddingLeft,
                _metrics.PhysicalViewInsetTop,
                _metrics.PhysicalViewInsetRight,
                _metrics.PhysicalViewInsetBottom,
                _metrics.PhysicalViewInsetLeft);

            IWindowManager wm = (IWindowManager)Context.GetSystemService(Context.WindowService);
            float fps = wm.DefaultDisplay.RefreshRate;
            VsyncWaiter.RefreshPeriodNanos = (long)(1000000000.0 / fps);
            VsyncWaiter.RefreshRateFps     = fps;
        }

        // Called by native to update the semantics/accessibility tree.
        // TODO: ByteBuffer->object
        public void UpdateSemantics(SemanticsNodeUpdates update, CustomAccessibilityActionUpdates actions)
        {
            try
            {
                if (_accessibilityNodeProvider != null)
                {
                    //buffer.order(ByteOrder.LITTLE_ENDIAN);
                    _accessibilityNodeProvider.UpdateSemantics(update, actions);
                }
            }
            catch (Exception ex)
            {
                Log.Error(TAG, "Uncaught exception while updating semantics", ex);
            }
        }

        // TODO: ByteBuffer->object
        public void UpdateCustomAccessibilityActions(object buffer, string[] strings)
        {
            try
            {
                //buffer.order(ByteOrder.LITTLE_ENDIAN);
                _accessibilityNodeProvider?.UpdateCustomAccessibilityActions(buffer, strings);
            }
            catch (Exception ex)
            {
                Log.Error(TAG, "Uncaught exception while updating local context actions", ex);
            }
        }

        // Called by native to notify first Flutter frame rendered.
        public void RaiseFirstFrame()
        {
            FirstFrame?.Invoke(this, new EventArgs());
        }

        // ACCESSIBILITY

        private bool _accessibilityEnabled = false;
        private bool _touchExplorationEnabled = false;
        private AccessibilityFeatures _accessibilityFeatureFlags;
        private TouchExplorationListener _touchExplorationListener;

        public void DispatchSemanticsAction(int id, SemanticsAction accessibilityBridgeAction)
        {
            DispatchSemanticsAction(id, accessibilityBridgeAction, null);
        }

        public void DispatchSemanticsAction(int id, SemanticsAction accessibilityBridgeAction, object args)
        {
            if (!IsAttached())
                return;
            object encodedArgs = null;
            if (args != null)
            {
                encodedArgs = StandardMessageCodec.Instance.EncodeMessage(args);
            }

            NativeDispatchSemanticsAction(_nativeView.Get(), id, accessibilityBridgeAction, encodedArgs);
        }

        //@Override
        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            _accessibilityEnabled    = _accessibilityManager.IsEnabled;
            _touchExplorationEnabled = _accessibilityManager.IsTouchExplorationEnabled;
            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr1)
            {
                Android.Net.Uri transitionUri = Android.Provider.Settings.Global.GetUriFor(Android.Provider.Settings.Global.TransitionAnimationScale);
                Context.ContentResolver.RegisterContentObserver(transitionUri, false, _animationScaleObserver);
            }

            if (_accessibilityEnabled || _touchExplorationEnabled)
            {
                EnsureAccessibilityEnabled();
            }

            if (_touchExplorationEnabled)
                _accessibilityFeatureFlags |= AccessibilityFeatures.AccessibleNavigation;
            else
                _accessibilityFeatureFlags &= ~AccessibilityFeatures.AccessibleNavigation;

            // Apply additional accessibility settings
            UpdateAccessibilityFeatures();
            ResetWillNotDraw();
            _accessibilityManager.AddAccessibilityStateChangeListener(this);
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat)
            {
                if (_touchExplorationListener == null)
                {
                    _touchExplorationListener = new TouchExplorationListener(this);
                }

                _accessibilityManager.AddTouchExplorationStateChangeListener(_touchExplorationListener);
            }
        }

        private void UpdateAccessibilityFeatures()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr1)
            {
                string transitionAnimationScale = Android.Provider.Settings.Global.GetString(
                    Context.ContentResolver,
                    Android.Provider.Settings.Global.TransitionAnimationScale);
                if (transitionAnimationScale != null && transitionAnimationScale.Equals("0"))
                    _accessibilityFeatureFlags |= AccessibilityFeatures.DisableAnimations;
                else
                    _accessibilityFeatureFlags &= ~AccessibilityFeatures.DisableAnimations;
            }

            NativeSetAccessibilityFeatures(_nativeView.Get(), _accessibilityFeatureFlags);
        }

        //@Override
        protected override void OnDetachedFromWindow()
        {
            base.OnDetachedFromWindow();
            Context.ContentResolver.UnregisterContentObserver(_animationScaleObserver);
            _accessibilityManager.RemoveAccessibilityStateChangeListener(this);
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat)
            {
                _accessibilityManager.RemoveTouchExplorationStateChangeListener(_touchExplorationListener);
            }
        }

        public void ResetWillNotDraw()
        {
            if (!_isSoftwareRenderingEnabled)
                SetWillNotDraw(!(_accessibilityEnabled || _touchExplorationEnabled));
            else
                SetWillNotDraw(false);
        }

        //@Override
        public void OnAccessibilityStateChanged(bool enabled)
        {
            if (enabled)
            {
                EnsureAccessibilityEnabled();
            }
            else
            {
                _accessibilityEnabled = false;
                _accessibilityNodeProvider?.SetAccessibilityEnabled(false);
                NativeSetSemanticsEnabled(_nativeView.Get(), false);
            }

            ResetWillNotDraw();
        }


        // Listens to the global TRANSITION_ANIMATION_SCALE property and notifies us so
        // that we can disable animations in Flutter.
        private class AnimationScaleObserver : ContentObserver
        {
            private readonly FlutterView _flutterView;

            public AnimationScaleObserver(FlutterView flutterView, Handler handler) : base(handler)
            {
                _flutterView = flutterView;
            }

            //@Override
            public override void OnChange(bool selfChange)
            {
                OnChange(selfChange, null);
            }

            //@Override
            private void OnChange(bool selfChange, Uri uri)
            {
                string value = Android.Provider.Settings.Global.GetString(
                    _flutterView.Context.ContentResolver,
                    Android.Provider.Settings.Global.TransitionAnimationScale);
                if (value != null && value.Equals("0"))
                    _flutterView._accessibilityFeatureFlags |= AccessibilityFeatures.DisableAnimations;
                else
                    _flutterView._accessibilityFeatureFlags &= ~AccessibilityFeatures.DisableAnimations;
                NativeSetAccessibilityFeatures(_flutterView._nativeView.Get(), _flutterView._accessibilityFeatureFlags);
            }
        }

        private class TouchExplorationListener : Java.Lang.Object, AccessibilityManager.ITouchExplorationStateChangeListener
        {
            private readonly FlutterView _flutterView;

            public TouchExplorationListener(FlutterView flutterView)
            {
                _flutterView = flutterView;
            }

            //@Override
            public void OnTouchExplorationStateChanged(bool enabled)
            {
                if (enabled)
                {
                    _flutterView._touchExplorationEnabled = true;
                    _flutterView.EnsureAccessibilityEnabled();
                    _flutterView._accessibilityFeatureFlags |= AccessibilityFeatures.AccessibleNavigation;
                    NativeSetAccessibilityFeatures(_flutterView._nativeView.Get(), _flutterView._accessibilityFeatureFlags);
                }
                else
                {
                    _flutterView._touchExplorationEnabled = false;
                    if (_flutterView._accessibilityNodeProvider != null)
                    {
                        _flutterView._accessibilityNodeProvider.HandleTouchExplorationExit();
                    }

                    _flutterView._accessibilityFeatureFlags &= ~AccessibilityFeatures.AccessibleNavigation;
                    NativeSetAccessibilityFeatures(_flutterView._nativeView.Get(), _flutterView._accessibilityFeatureFlags);
                }

                _flutterView.ResetWillNotDraw();
            }
        }

        //@Override
        public AccessibilityNodeProvider GetAccessibilityNodeProvider()
        {
            if (_accessibilityEnabled)
                return _accessibilityNodeProvider;
            // TODO(goderbauer): when a11y is off this should return a one-off snapshot of
            // the a11y
            // tree.
            return null;
        }

        private AccessibilityBridge _accessibilityNodeProvider;

        public void EnsureAccessibilityEnabled()
        {
            if (!IsAttached())
                return;
            _accessibilityEnabled = true;
            if (_accessibilityNodeProvider == null)
            {
                _accessibilityNodeProvider = new AccessibilityBridge(this);
            }

            NativeSetSemanticsEnabled(_nativeView.Get(), true);
            _accessibilityNodeProvider.SetAccessibilityEnabled(true);
        }

        public void ResetAccessibilityTree()
        {
            _accessibilityNodeProvider?.Reset();
        }

        public bool HandleAccessibilityHoverEvent(MotionEvent @event)
        {
            if (!_touchExplorationEnabled)
            {
                return false;
            }

            if (@event.Action == MotionEventActions.HoverEnter || @event.Action == MotionEventActions.HoverMove)
            {
                _accessibilityNodeProvider.HandleTouchExploration(@event.GetX(), @event.GetY());
            }
            else if (@event.Action == MotionEventActions.HoverExit)
            {
                _accessibilityNodeProvider.HandleTouchExplorationExit();
            }
            else
            {
                Log.Debug("flutter", "unexpected accessibility hover event: " + @event);
                return false;
            }

            return true;
        }

        //@Override
        // TODO: ByteBuffer->object
        public void Send(string channel, object message)
        {
            Send(channel, message, null);
        }

        //@Override
        // TODO: ByteBuffer->object
        public void Send(string channel, object message, IBinaryReply callback)
        {
            if (!IsAttached())
            {
                Log.Debug(TAG, "FlutterView.send called on a detached view, channel=" + channel);
                return;
            }

            _nativeView.Send(channel, message, callback);
        }

        //@Override
        public void SetMessageHandler(string channel, IBinaryMessageHandler handler)
        {
            _nativeView.SetMessageHandler(channel, handler);
        }

        //@Override
        public ITextureRegistrySurfaceTextureEntry CreateSurfaceTexture()
        {
            SurfaceTexture surfaceTexture = new SurfaceTexture(0);
            surfaceTexture.DetachFromGLContext();
            SurfaceTextureRegistryEntry entry = new SurfaceTextureRegistryEntry(_nextTextureId.GetAndIncrement(), surfaceTexture, _nativeView);
            NativeRegisterTexture(_nativeView.Get(), entry.Id, surfaceTexture);
            return entry;
        }

        internal class SurfaceTextureRegistryEntry : ITextureRegistrySurfaceTextureEntry
        {
            private readonly long _id;
            private readonly SurfaceTexture _surfaceTexture;
            private readonly FlutterNativeView _flutterNativeView;
            private bool _released = false;

            public SurfaceTextureRegistryEntry(long id, SurfaceTexture surfaceTexture, FlutterNativeView flutterNativeView)
            {
                _id                = id;
                _surfaceTexture    = surfaceTexture;
                _flutterNativeView = flutterNativeView;

                OnFrameAvailableListenerImpl onFrameListener = new OnFrameAvailableListenerImpl {FrameAvailable = OnFrameAvailable};
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                {
                    // The callback relies on being executed on the UI thread (unsynchronised read of mNativeView
                    // and also the engine code check for platform thread in Shell::OnPlatformViewMarkTextureFrameAvailable),
                    // so we explicitly pass a Handler for the current thread.
                    _surfaceTexture.SetOnFrameAvailableListener(onFrameListener, new Handler());
                }
                else
                {
                    // Android documentation states that the listener can be called on an arbitrary thread.
                    // But in practice, versions of Android that predate the newer API will call the listener
                    // on the thread where the SurfaceTexture was constructed.
                    _surfaceTexture.SetOnFrameAvailableListener(onFrameListener);
                }
            }

            private void OnFrameAvailable(SurfaceTexture texture)
            {
                if (_released)
                {
                    // Even though we make sure to unregister the callback before releasing, as of Android O
                    // SurfaceTexture has a data race when accessing the callback, so the callback may
                    // still be called by a stale reference after released==true and mNativeView==null.
                    return;
                }

                NativeMarkTextureFrameAvailable(_flutterNativeView.Get(), _id);
            }

            //@Override
            public SurfaceTexture SurfaceTexture => _surfaceTexture;

            //@Override
            public long Id => _id;

            //@Override
            public void Release()
            {
                if (_released)
                    return;

                _released = true;
                NativeUnregisterTexture(_flutterNativeView.Get(), _id);
                // Otherwise onFrameAvailableListener might be called after mNativeView==null
                // (https://github.com/flutter/flutter/issues/20951). See also the check in onFrameAvailable.
                _surfaceTexture.SetOnFrameAvailableListener(null);
                _surfaceTexture.Release();
            }
        }
    }
}
