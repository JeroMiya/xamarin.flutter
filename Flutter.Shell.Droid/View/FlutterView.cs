using Android.App;
using Android.Content;
using Android.Content.Res;
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
using Java.Util;
using Java.Util.Concurrent.Atomic;
using System;
using Android.Database;
using Android.InputMethodServices;
using Android.Locations;
using Android.Support.V4.View.Accessibility;
using FlutterBinding.Shell;
using FlutterSDK;
using Java.Nio;
using Format = Android.Graphics.Format;
using KeyboardType = Android.Views.KeyboardType;
using Keycode = Android.Views.Keycode;
using Surface = Android.Views.Surface;

namespace Flutter.Shell.Droid.View
{
    public interface IProvider
    {
        /**
         * Returns a reference to the Flutter view maintained by this object. This may
         * be {@code null}.
         */
        FlutterView GetFlutterView();
    }

    public class OnFrameAvailableListenerImpl : Java.Lang.Object, SurfaceTexture.IOnFrameAvailableListener
    {
        public Action<SurfaceTexture> FrameAvailable;

        /// <inheritdoc />
        public void OnFrameAvailable(SurfaceTexture surfaceTexture)
        {
            FrameAvailable?.Invoke(surfaceTexture);
        }
    }

    public class FlutterView :
        SurfaceView,
        ISurfaceHolderCallback,
        IBinaryMessenger,
        ITextureRegistry,
        AccessibilityManager.IAccessibilityStateChangeListener
    {
        private static readonly string TAG = "FlutterView";

        public class ViewportMetrics
        {
            public float devicePixelRatio = 1.0f;
            public int physicalWidth = 0;
            public int physicalHeight = 0;
            public int physicalPaddingTop = 0;
            public int physicalPaddingRight = 0;
            public int physicalPaddingBottom = 0;
            public int physicalPaddingLeft = 0;
            public int physicalViewInsetTop = 0;
            public int physicalViewInsetRight = 0;
            public int physicalViewInsetBottom = 0;
            public int physicalViewInsetLeft = 0;
        }

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
            _isSoftwareRenderingEnabled = nativeGetIsSoftwareRenderingEnabled();
            _animationScaleObserver = new AnimationScaleObserver(this, new Handler());
            _metrics = new ViewportMetrics
            {
                devicePixelRatio = context.Resources.DisplayMetrics.Density
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
            _flutterLocalizationChannel = new MethodChannel(this, "flutter/localization", StandardMethodCodec.Instance);    // JSON
            _flutterNavigationChannel = new MethodChannel(this, "flutter/navigation", StandardMethodCodec.Instance);    // JSON
            _flutterKeyEventChannel = new BasicMessageChannel<object>(this, "flutter/keyevent", StandardMessageCodec.Instance);   // JSON
            _flutterLifecycleChannel = new BasicMessageChannel<string>(this, "flutter/lifecycle", StringCodec.Instance);  // string
            _flutterSystemChannel = new BasicMessageChannel<object>(this, "flutter/system", StandardMessageCodec.Instance);   // JSON
            _flutterSettingsChannel = new BasicMessageChannel<object>(this, "flutter/settings", StandardMessageCodec.Instance);   //JSON

            //PlatformPlugin platformPlugin = new PlatformPlugin(activity);
            //MethodChannel flutterPlatformChannel = new MethodChannel(this, "flutter/platform", JSONMethodCodec.INSTANCE);
            //flutterPlatformChannel.setMethodCallHandler(platformPlugin);
            //addActivityLifecycleListener(platformPlugin);
            _imm = (InputMethodManager)Context.GetSystemService(Context.InputMethodService);
            _textInputPlugin = new TextInputPlugin(this);

            SetLocales(Resources.Configuration);
            SetUserSettings();
        }

        /// <inheritdoc />
        void ISurfaceHolderCallback.SurfaceChanged(ISurfaceHolder holder, Format format, int width, int height)
        {
            AssertAttached();
            nativeSurfaceChanged(_nativeView.Get(), width, height);
        }

        /// <inheritdoc />
        void ISurfaceHolderCallback.SurfaceCreated(ISurfaceHolder holder)
        {
            AssertAttached();
            nativeSurfaceCreated(_nativeView.Get(), holder.Surface);
        }

        /// <inheritdoc />
        void ISurfaceHolderCallback.SurfaceDestroyed(ISurfaceHolder holder)
        {
            AssertAttached();
            nativeSurfaceDestroyed(_nativeView.Get());
        }

        private void EncodeKeyEvent(KeyEvent @event, System.Collections.Generic.Dictionary<string, object> message)
        {
            message["flags"] = @event.Flags;
            message["codePoint"] = @event.UnicodeChar;
            message["keyCode"] = @event.KeyCode;
            message["scanCode"] = @event.ScanCode;
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
                ["type"] = "keyup",
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
                ["type"] = "keydown",
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
            return FlutterMain.GetLookupKeyForAsset(asset);
        }

        public string GetLookupKeyForAsset(string asset, string packageName)
        {
            return FlutterMain.GetLookupKeyForAsset(asset, packageName);
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
            System.Collections.Generic.Dictionary<string, object> message = new System.Collections.Generic.Dictionary<string, object>(1) { ["type"] = "memoryPressure" };
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

        private void SetUserSettings()
        {
            var message = new System.Collections.Generic.Dictionary<string, object>
            {
                ["textScaleFactor"] = Resources.Configuration.FontScale,
                ["alwaysUse24HourFormat"] = Android.Text.Format.DateFormat.Is24HourFormat(Context)
            };
            _flutterSettingsChannel.Send(message);
        }

        private void SetLocales(Android.Content.Res.Configuration config)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.N)    // 24
            {
                //try
                //{
                //    // Passes the full list of locales for android API >= 24 with reflection.
                //    object localeList = config.getClass().getDeclaredMethod("getLocales").invoke(config);
                //    Method localeListGet = localeList.getClass().getDeclaredMethod("get", int.class);
                //    Method localeListSize = localeList.getClass().getDeclaredMethod("size");
                //    int localeCount = (int)localeListSize.invoke(localeList);
                //    List<string> data = new ArrayList<string>();
                //    for (int index = 0; index<localeCount; ++index) 
                //    {
                //        Locale locale = (Locale)localeListGet.invoke(localeList, index);
                //        data.add(locale.getLanguage());
                //        data.add(locale.getCountry());
                //        data.add(locale.getScript());
                //        data.add(locale.getVariant());
                //    }
                //    mFlutterLocalizationChannel.invokeMethod("setLocale", data);
                //    return;
                //} 
                //catch (Exception exception) 
                //{
                //    // Any exception is a failure. Resort to fallback of sending only one locale.
                //}
            }

            // Fallback single locale passing for android API < 24. Should work always.
            Locale locale = config.Locale;
            // getScript() is gated because it is added in API 21.
            _flutterLocalizationChannel.InvokeMethod(
                "setLocale",
                new object[]
                {
                locale.Language, locale.Country, Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop ? locale.Script : "", locale.Variant
                });
        }

        //@Override
        /// <inheritdoc />
        protected override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            SetLocales(newConfig);
            SetUserSettings();
        }

        private float GetDevicePixelRatio()
        {
            return _metrics.devicePixelRatio;
        }

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
        public IInputConnection OnCreateInputConnection(EditorInfo outAttrs)
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

        private int GetPointerChangeForAction(MotionEventActions maskedAction)
        {
            // Primary pointer:
            if (maskedAction == MotionEventActions.Down)
                return kPointerChangeDown;

            if (maskedAction == MotionEventActions.Up)
                return kPointerChangeUp;

            // Secondary pointer:
            if (maskedAction == MotionEventActions.PointerDown)
                return kPointerChangeDown;

            if (maskedAction == MotionEventActions.PointerUp)
                return kPointerChangeUp;

            // All pointers:
            if (maskedAction == MotionEventActions.Move)
                return kPointerChangeMove;

            if (maskedAction == MotionEventActions.Cancel)
                return kPointerChangeCancel;

            return -1;
        }

        private int GetPointerDeviceTypeForToolType(MotionEventToolType toolType)
        {
            switch (toolType)
            {
                case MotionEventToolType.Finger:
                    return kPointerDeviceKindTouch;
                case MotionEventToolType.Stylus:
                    return kPointerDeviceKindStylus;
                case MotionEventToolType.Mouse:
                    return kPointerDeviceKindMouse;
                case MotionEventToolType.Eraser:
                    return kPointerDeviceKindInvertedStylus;
                default:
                    // MotionEvent.TOOL_TYPE_UNKNOWN will reach here.
                    return kPointerDeviceKindUnknown;
            }
        }

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

        // TODO: ByteBuffer->object
        private PointerParameter AddPointerForIndex(MotionEvent @event, int pointerIndex, int pointerChange, int pointerData)
        {
            if (pointerChange == -1)
                return null;

            int pointerKind = GetPointerDeviceTypeForToolType(@event.GetToolType(pointerIndex));
            long buttonState = 0;
            double tilt = 0.0d;

            if (pointerKind == kPointerDeviceKindMouse)
                buttonState = (int)@event.ButtonState & 0x1F; // mouse buttons
            else if (pointerKind == kPointerDeviceKindStylus)
            {
                buttonState = ((int)@event.ButtonState >> 4) & 0xF; // stylus buttons
                tilt = @event.GetAxisValue(Axis.Tilt, pointerIndex);
            }

            double pressure = @event.GetPressure(pointerIndex);
            var distance = @event.GetAxisValue(Axis.Distance, pointerIndex);
            var size = @event.GetSize(pointerIndex);
            var radiusMajor = @event.GetToolMajor(pointerIndex);
            var radiusMinor = @event.GetToolMinor(pointerIndex);
            var orientation = @event.GetAxisValue(Axis.Orientation, pointerIndex);

            return new PointerParameter
            {
                Timestamp = @event.EventTime * 1000, // Convert from milliseconds to microseconds.
                PointerIndex = pointerIndex,
                PointerChange = pointerChange,
                PointerKind = pointerKind,
                MotionEvent = @event,
                PointerId = @event.GetPointerId(pointerIndex),
                X = @event.GetX(pointerIndex),
                Y = @event.GetY(pointerIndex),
                ButtonState = buttonState,
                Pressure = pressure,
                PressureMin = 0.0d,
                PressureMax = 1.0d,
                Distance = distance,
                DistanceMax = 0.0d,
                Size = size,
                RadiusMinor = radiusMinor,
                RadiusMajor = radiusMajor,
                RadiusMin = 0.0d,
                RadiusMax = 0.0d,
                Orientation = orientation,
                Tilt = tilt,
                PointerData = pointerData
            };
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

            var packet = new List<PointerParameter>();

            MotionEventActions maskedAction = @event.ActionMasked;
            int pointerChange = GetPointerChangeForAction(@event.ActionMasked);
            if (maskedAction == MotionEventActions.Down || maskedAction == MotionEventActions.PointerDown)
            {
                // ACTION_DOWN and ACTION_POINTER_DOWN always apply to a single pointer only.
                packet.Add(
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
                            packet.Add(
                                AddPointerForIndex(@event, p, kPointerChangeMove, kPointerDataFlagBatched));
                        }
                    }
                }

                // It's important that we're sending the UP event last. This allows PlatformView
                // to correctly batch everything back into the original Android event if needed.
                packet.Add(
                    AddPointerForIndex(@event, @event.ActionIndex, pointerChange, 0));
            }
            else
            {
                // ACTION_MOVE may not actually mean all pointers have moved
                // but it's the responsibility of a later part of the system to
                // ignore 0-deltas if desired.
                for (int p = 0; p < pointerCount; p++)
                {
                    packet.Add(
                        AddPointerForIndex(@event, p, pointerChange, 0));
                }
            }

            //assert packet.position() % (kPointerDataFieldCount* kBytePerField) == 0;
            nativeDispatchPointerDataPacket(_nativeView.Get(), packet);
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
            _metrics.physicalWidth = width;
            _metrics.physicalHeight = height;
            UpdateViewportMetrics();
            base.OnSizeChanged(width, height, oldWidth, oldHeight);
        }

        // TODO(garyq): Add support for notch cutout API
        // Decide if we want to zero the padding of the sides. When in Landscape orientation,
        // android may decide to place the software navigation bars on the side. When the nav
        // bar is hidden, the reported insets should be removed to prevent extra useless space
        // on the sides.
        public enum ZeroSides { None, Left, Right, Both }
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
            _metrics.physicalPaddingTop = statusBarHidden ? 0 : insets.SystemWindowInsetTop;
            _metrics.physicalPaddingRight =
                zeroSides == ZeroSides.Right || zeroSides == ZeroSides.Both ? 0 : insets.SystemWindowInsetRight;
            _metrics.physicalPaddingBottom = 0;
            _metrics.physicalPaddingLeft =
                zeroSides == ZeroSides.Left || zeroSides == ZeroSides.Both ? 0 : insets.SystemWindowInsetLeft;

            // Bottom system inset (keyboard) should adjust scrollable bottom edge (inset).
            _metrics.physicalViewInsetTop = 0;
            _metrics.physicalViewInsetRight = 0;
            // We perform hidden navbar and keyboard handling if the navbar is set to hidden. Otherwise,
            // the navbar padding should always be provided.
            _metrics.physicalViewInsetBottom =
                navigationBarHidden ? CalculateBottomKeyboardInset(insets) : insets.SystemWindowInsetBottom;
            _metrics.physicalViewInsetLeft = 0;
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
                _metrics.physicalPaddingTop = insets.Top;
                _metrics.physicalPaddingRight = insets.Right;
                _metrics.physicalPaddingBottom = 0;
                _metrics.physicalPaddingLeft = insets.Left;

                // Bottom system inset (keyboard) should adjust scrollable bottom edge (inset).
                _metrics.physicalViewInsetTop = 0;
                _metrics.physicalViewInsetRight = 0;
                _metrics.physicalViewInsetBottom = insets.Bottom;
                _metrics.physicalViewInsetLeft = 0;
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

        private void PostRun()
        {
        }

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
         * Parameter `reuseRuntimeController` has no effect.
         */
        //@Deprecated
        [Obsolete("deprected")]
        public void RunFromBundle(string bundlePath, string defaultPath, string entrypoint = "main", bool reuseRuntimeController = false)
        {
            FlutterRunArguments args = new FlutterRunArguments
            {
                BundlePath = bundlePath,
                Entrypoint = entrypoint,
                DefaultPath = defaultPath
            };
            RunFromBundle(args);
        }

        /**
         * Return the most recent frame as a bitmap.
         *
         * @return A bitmap.
         */
        public Bitmap GetBitmap()
        {
            AssertAttached();
            return nativeGetBitmap(_nativeView.Get());
        }

        private static void nativeSurfaceCreated(long nativePlatformViewAndroid, Surface surface);      // native

        private static void nativeSurfaceChanged(long nativePlatformViewAndroid, int width, int height); // native

        private static void nativeSurfaceDestroyed(long nativePlatformViewAndroid);                     // native

        private static void nativeSetViewportMetrics(long nativePlatformViewAndroid, float devicePixelRatio,
                int physicalWidth, int physicalHeight, int physicalPaddingTop, int physicalPaddingRight,
                int physicalPaddingBottom, int physicalPaddingLeft, int physicalViewInsetTop, int physicalViewInsetRight,
                int physicalViewInsetBottom, int physicalViewInsetLeft);                                // native engine->SetViewportMetrics(metrics);

        private static Bitmap nativeGetBitmap(long nativePlatformViewAndroid);                          // native

        // TODO: ByteBuffer->object
        private static void nativeDispatchPointerDataPacket(long nativePlatformViewAndroid, object buffer);
        // native

        // TODO: ByteBuffer->object
        // native shell::DispatchSemanticsAction
        private static void nativeDispatchSemanticsAction(long nativePlatformViewAndroid, int id, int action, object args);
        

        private static void nativeSetSemanticsEnabled(long nativePlatformViewAndroid, bool enabled);    // native

        private static void NativeSetAccessibilityFeatures(long nativePlatformViewAndroid, AccessibilityFeatures flags);  // native

        private static bool nativeGetIsSoftwareRenderingEnabled();                                      // native

        private static void nativeRegisterTexture(long nativePlatformViewAndroid, long textureId, SurfaceTexture surfaceTexture); 
                                                                                                        // native

        private static void nativeMarkTextureFrameAvailable(long nativePlatformViewAndroid, long textureId); 
                                                                                                        // native

        private static void nativeUnregisterTexture(long nativePlatformViewAndroid, long textureId);    // native

        private void UpdateViewportMetrics()
        {
            if (!IsAttached())
                return;
            nativeSetViewportMetrics(_nativeView.Get(), _metrics.devicePixelRatio, _metrics.physicalWidth,
                    _metrics.physicalHeight, _metrics.physicalPaddingTop, _metrics.physicalPaddingRight,
                    _metrics.physicalPaddingBottom, _metrics.physicalPaddingLeft, _metrics.physicalViewInsetTop,
                    _metrics.physicalViewInsetRight, _metrics.physicalViewInsetBottom, _metrics.physicalViewInsetLeft);

            IWindowManager wm = (IWindowManager)Context.GetSystemService(Context.WindowService);
            float fps = wm.DefaultDisplay.RefreshRate;
            VsyncWaiter.RefreshPeriodNanos = (long)(1000000000.0 / fps);
            VsyncWaiter.RefreshRateFps = fps;
        }

        // Called by native to update the semantics/accessibility tree.
        // TODO: ByteBuffer->object
        public void UpdateSemantics(object buffer, string[] strings)
        {
            try
            {
                if (_accessibilityNodeProvider != null)
                {
                    //buffer.order(ByteOrder.LITTLE_ENDIAN);
                    _accessibilityNodeProvider.UpdateSemantics(buffer, strings);
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

        public void DispatchSemanticsAction(int id, AccessibilityBridge.AccessibilityBridgeAction accessibilityBridgeAction)
        {
            DispatchSemanticsAction(id, accessibilityBridgeAction, null);
        }

        public void DispatchSemanticsAction(int id, AccessibilityBridge.AccessibilityBridgeAction accessibilityBridgeAction, object args)
        {
            if (!IsAttached())
                return;
            object encodedArgs = null;
            if (args != null)
            {
                encodedArgs = StandardMessageCodec.Instance.EncodeMessage(args);
            }
            nativeDispatchSemanticsAction(_nativeView.Get(), id, (int)accessibilityBridgeAction, encodedArgs);
        }

        //@Override
        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            _accessibilityEnabled = _accessibilityManager.IsEnabled;
            _touchExplorationEnabled = _accessibilityManager.IsTouchExplorationEnabled;
            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr1)
            {
                var transitionUri = Android.Provider.Settings.Global.GetUriFor(Android.Provider.Settings.Global.TransitionAnimationScale);
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
                nativeSetSemanticsEnabled(_nativeView.Get(), false);
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
                string value = Android.Provider.Settings.Global.GetString(_flutterView.Context.ContentResolver,
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
            nativeSetSemanticsEnabled(_nativeView.Get(), true);
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
            var entry = new SurfaceTextureRegistryEntry(_nextTextureId.GetAndIncrement(), surfaceTexture, _nativeView);
            nativeRegisterTexture(_nativeView.Get(), entry.Id, surfaceTexture);
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
                _id = id;
                _surfaceTexture = surfaceTexture;
                _flutterNativeView = flutterNativeView;

                var onFrameListener = new OnFrameAvailableListenerImpl { FrameAvailable = OnFrameAvailable };
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
                nativeMarkTextureFrameAvailable(_flutterNativeView.Get(), _id);
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
                nativeUnregisterTexture(_flutterNativeView.Get(), _id);
                // Otherwise onFrameAvailableListener might be called after mNativeView==null
                // (https://github.com/flutter/flutter/issues/20951). See also the check in onFrameAvailable.
                _surfaceTexture.SetOnFrameAvailableListener(null);
                _surfaceTexture.Release();
            }
        }
    }
}