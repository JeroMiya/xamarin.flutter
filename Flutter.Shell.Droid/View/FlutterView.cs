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
using FlutterSDK;
using KeyboardType = Android.Views.KeyboardType;

namespace Flutter.Shell.Droid.View
{
    public interface Provider
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
        BinaryMessenger,
        TextureRegistry,
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

        private InputMethodManager mImm;
        private TextInputPlugin mTextInputPlugin;
        private readonly ISurfaceHolderCallback mSurfaceCallback;
        private ViewportMetrics mMetrics;
        private readonly AccessibilityManager mAccessibilityManager;
        private MethodChannel mFlutterLocalizationChannel;
        private MethodChannel mFlutterNavigationChannel;
        private BasicMessageChannel<object> mFlutterKeyEventChannel;
        private BasicMessageChannel<string> mFlutterLifecycleChannel;
        private BasicMessageChannel<object> mFlutterSystemChannel;
        private BasicMessageChannel<object> mFlutterSettingsChannel;
        private System.Collections.Generic.List<ActivityLifecycleListener> mActivityLifecycleListeners;
        private System.Collections.Generic.List<FirstFrameListener> mFirstFrameListeners;
        private readonly AtomicLong nextTextureId = new AtomicLong(0L);
        private FlutterNativeView mNativeView;
        private readonly AnimationScaleObserver mAnimationScaleObserver;
        private readonly bool mIsSoftwareRenderingEnabled = false; // using the software renderer or not
        private IInputConnection mLastInputConnection;


        /// <inheritdoc />
        protected FlutterView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        /// <inheritdoc />
        public FlutterView(Context context) : this(context, null) { }

        /// <inheritdoc />
        public FlutterView(Context context, IAttributeSet attrs) : this(context, attrs, null) { }

        public FlutterView(Context context, IAttributeSet attrs, FlutterNativeView nativeView) : base(context, attrs)
        {
            mIsSoftwareRenderingEnabled = nativeGetIsSoftwareRenderingEnabled();
            mAnimationScaleObserver = new AnimationScaleObserver(new Handler());
            mMetrics = new ViewportMetrics
            {
                devicePixelRatio = context.Resources.DisplayMetrics.Density
            };
            SetFocusable(ViewFocusability.Focusable);
            SetFocusableInTouchMode(true);

            Activity activity = (Activity)Context;
            mNativeView = nativeView ?? new FlutterNativeView(activity.ApplicationContext);
            mNativeView.AttachViewAndActivity(this, activity);

            mSurfaceCallback = (ISurfaceHolderCallback)this;
            Holder.AddCallback(mSurfaceCallback);

            mAccessibilityManager = (AccessibilityManager)Context.GetSystemService(Context.AccessibilityService);

            mActivityLifecycleListeners = new System.Collections.Generic.List<ActivityLifecycleListener>();
            mFirstFrameListeners = new System.Collections.Generic.List<FirstFrameListener>();

            // Configure the platform plugins and flutter channels.
            mFlutterLocalizationChannel = new MethodChannel(this, "flutter/localization", StandardMethodCodec.INSTANCE);    // JSON
            mFlutterNavigationChannel = new MethodChannel(this, "flutter/navigation", StandardMethodCodec.INSTANCE);    // JSON
            mFlutterKeyEventChannel = new BasicMessageChannel<object>(this, "flutter/keyevent", StandardMessageCodec.INSTANCE);   // JSON
            mFlutterLifecycleChannel = new BasicMessageChannel<string>(this, "flutter/lifecycle", StringCodec.INSTANCE);  // string
            mFlutterSystemChannel = new BasicMessageChannel<object>(this, "flutter/system", StandardMessageCodec.INSTANCE);   // JSON
            mFlutterSettingsChannel = new BasicMessageChannel<object>(this, "flutter/settings", StandardMessageCodec.INSTANCE);   //JSON

            //PlatformPlugin platformPlugin = new PlatformPlugin(activity);
            //MethodChannel flutterPlatformChannel = new MethodChannel(this, "flutter/platform", JSONMethodCodec.INSTANCE);
            //flutterPlatformChannel.setMethodCallHandler(platformPlugin);
            //addActivityLifecycleListener(platformPlugin);
            mImm = (InputMethodManager)Context.GetSystemService(Context.InputMethodService);
            mTextInputPlugin = new TextInputPlugin(this);

            SetLocales(Resources.Configuration);
            SetUserSettings();
        }

        /// <inheritdoc />
        void ISurfaceHolderCallback.SurfaceChanged(ISurfaceHolder holder, Format format, int width, int height)
        {
            assertAttached();
            nativeSurfaceChanged(mNativeView.Get(), width, height);
        }

        /// <inheritdoc />
        void ISurfaceHolderCallback.SurfaceCreated(ISurfaceHolder holder)
        {
            assertAttached();
            nativeSurfaceCreated(mNativeView.Get(), holder.Surface);
        }

        /// <inheritdoc />
        void ISurfaceHolderCallback.SurfaceDestroyed(ISurfaceHolder holder)
        {
            assertAttached();
            nativeSurfaceDestroyed(mNativeView.Get());
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
            mFlutterKeyEventChannel.Send(message);
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
                if (mLastInputConnection != null && mImm.IsAcceptingText)
                {
                    mLastInputConnection.SendKeyEvent(@event);
                }
            }

            System.Collections.Generic.Dictionary<string, object> message = new System.Collections.Generic.Dictionary<string, object>
            {
                ["type"] = "keydown",
                ["keymap"] = "android"
            };
            EncodeKeyEvent(@event, message);
            mFlutterKeyEventChannel.Send(message);
            return base.OnKeyDown(keyCode, @event);
        }

        public FlutterNativeView getFlutterNativeView()
        {
            return mNativeView;
        }

        public FlutterPluginRegistry getPluginRegistry()
        {
            return mNativeView.GetPluginRegistry();
        }

        public string getLookupKeyForAsset(string asset)
        {
            return FlutterMain.GetLookupKeyForAsset(asset);
        }

        public string getLookupKeyForAsset(string asset, string packageName)
        {
            return FlutterMain.GetLookupKeyForAsset(asset, packageName);
        }

        public void addActivityLifecycleListener(ActivityLifecycleListener listener)
        {
            mActivityLifecycleListeners.Add(listener);
        }

        public void onStart()
        {
            mFlutterLifecycleChannel.Send("AppLifecycleState.inactive");
        }

        public void onPause()
        {
            mFlutterLifecycleChannel.Send("AppLifecycleState.inactive");
        }

        public void onPostResume()
        {
            UpdateAccessibilityFeatures();
            foreach (ActivityLifecycleListener listener in mActivityLifecycleListeners)
            {
                listener.OnPostResume();
            }
            mFlutterLifecycleChannel.Send("AppLifecycleState.resumed");
        }

        public void OnStop()
        {
            mFlutterLifecycleChannel.Send("AppLifecycleState.paused");
        }

        public void OnMemoryPressure()
        {
            System.Collections.Generic.Dictionary<string, object> message = new System.Collections.Generic.Dictionary<string, object>(1) { ["type"] = "memoryPressure" };
            mFlutterSystemChannel.Send(message);
        }

        /**
         * Provide a listener that will be called once when the FlutterView renders its
         * first frame to the underlaying SurfaceView.
         */
        public void AddFirstFrameListener(FirstFrameListener listener)
        {
            mFirstFrameListeners.Add(listener);
        }

        /**
         * Remove an existing first frame listener.
         */
        public void RemoveFirstFrameListener(FirstFrameListener listener)
        {
            mFirstFrameListeners.Remove(listener);
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
            mFlutterNavigationChannel.InvokeMethod("setInitialRoute", route);
        }

        public void PushRoute(string route)
        {
            mFlutterNavigationChannel.InvokeMethod("pushRoute", route);
        }

        public void PopRoute()
        {
            mFlutterNavigationChannel.InvokeMethod("popRoute", null);
        }

        private void SetUserSettings()
        {
            System.Collections.Generic.Dictionary<string, object> message = new System.Collections.Generic.Dictionary<string, object>();
            message["textScaleFactor"] = Resources.Configuration.FontScale;
            message["alwaysUse24HourFormat"] = Java.Text.DateFormat.Is24HourFormat(Context);
            mFlutterSettingsChannel.Send(message);
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
            mFlutterLocalizationChannel.InvokeMethod(
                "setLocale",
                new object[]
                {
                locale.Language, locale.Country, Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop ? locale.Script : "", locale.Variant
                });
        }

        //@Override
        protected void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            SetLocales(newConfig);
            SetUserSettings();
        }

        private float GetDevicePixelRatio()
        {
            return mMetrics.devicePixelRatio;
        }

        public FlutterNativeView Detach()
        {
            if (!IsAttached())
                return null;
            Holder.RemoveCallback(mSurfaceCallback);
            mNativeView.Detach();

            FlutterNativeView view = mNativeView;
            mNativeView = null;
            return view;
        }

        public void Destroy()
        {
            if (!IsAttached())
                return;

            Holder.RemoveCallback(mSurfaceCallback);

            mNativeView.Destroy();
            mNativeView = null;
        }

        //@Override
        public IInputConnection OnCreateInputConnection(EditorInfo outAttrs)
        {
            try
            {
                mLastInputConnection = mTextInputPlugin.CreateInputConnection(this, outAttrs);
                return mLastInputConnection;
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

        private int getPointerChangeForAction(MotionEventActions maskedAction)
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

        private int getPointerDeviceTypeForToolType(MotionEventToolType toolType)
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

        // TODO: ByteBuffer->object
        private void AddPointerForIndex(MotionEvent @event, int pointerIndex, int pointerChange, int pointerData, object packet)
        {
            if (pointerChange == -1)
            {
                return;
            }

            int pointerKind = getPointerDeviceTypeForToolType(@event.GetToolType(pointerIndex));

            long timeStamp = @event.EventTime * 1000; // Convert from milliseconds to microseconds.

            packet.putLong(timeStamp); // time_stamp
            packet.putLong(pointerChange); // change
            packet.putLong(pointerKind); // kind
            packet.putLong(@event.getPointerId(pointerIndex)); // device
            packet.putDouble(@event.getX(pointerIndex)); // physical_x
            packet.putDouble(@event.getY(pointerIndex)); // physical_y

            if (pointerKind == kPointerDeviceKindMouse)
            {
                packet.putLong(@event.getButtonState() & 0x1F); // buttons
            }
            else if (pointerKind == kPointerDeviceKindStylus)
            {
                packet.putLong((@event.getButtonState() >> 4) & 0xF); // buttons
            }
            else
            {
                packet.putLong(0); // buttons
            }

            packet.putLong(0); // obscured

            // TODO(eseidel): Could get the calibrated range if necessary:
            // event.getDevice().getMotionRange(MotionEvent.AXIS_PRESSURE)
            packet.putDouble(@event.getPressure(pointerIndex)); // pressure
            packet.putDouble(0.0); // pressure_min
            packet.putDouble(1.0); // pressure_max

            if (pointerKind == kPointerDeviceKindStylus)
            {
                packet.putDouble(@event.getAxisValue(MotionEvent.AXIS_DISTANCE, pointerIndex)); // distance
                packet.putDouble(0.0); // distance_max
            }
            else
            {
                packet.putDouble(0.0); // distance
                packet.putDouble(0.0); // distance_max
            }

            packet.putDouble(@event.getSize(pointerIndex)); // size

            packet.putDouble(@event.getToolMajor(pointerIndex)); // radius_major
            packet.putDouble(@event.getToolMinor(pointerIndex)); // radius_minor

            packet.putDouble(0.0); // radius_min
            packet.putDouble(0.0); // radius_max

            packet.putDouble(@event.getAxisValue(MotionEvent.AXIS_ORIENTATION, pointerIndex)); // orientation

            if (pointerKind == kPointerDeviceKindStylus)
            {
                packet.putDouble(@event.getAxisValue(MotionEvent.AXIS_TILT, pointerIndex)); // tilt
            }
            else
            {
                packet.putDouble(0.0); // tilt
            }

            packet.putLong(pointerData); // platformData
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

            MotionEventActions maskedAction = @event.ActionMasked;
            int pointerChange = getPointerChangeForAction(@event.ActionMasked);
            if (maskedAction == MotionEventActions.Down || maskedAction == MotionEventActions.PointerDown)
            {
                // ACTION_DOWN and ACTION_POINTER_DOWN always apply to a single pointer only.
                AddPointerForIndex(@event, @event.ActionIndex, pointerChange, 0, packet);
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
                            AddPointerForIndex(@event, p, kPointerChangeMove, kPointerDataFlagBatched, packet);
                        }
                    }
                }

                // It's important that we're sending the UP event last. This allows PlatformView
                // to correctly batch everything back into the original Android event if needed.
                AddPointerForIndex(@event, @event.ActionIndex, pointerChange, 0, packet);
            }
            else
            {
                // ACTION_MOVE may not actually mean all pointers have moved
                // but it's the responsibility of a later part of the system to
                // ignore 0-deltas if desired.
                for (int p = 0; p < pointerCount; p++)
                {
                    AddPointerForIndex(@event, p, pointerChange, 0, packet);
                }
            }

            //assert packet.position() % (kPointerDataFieldCount* kBytePerField) == 0;
            nativeDispatchPointerDataPacket(mNativeView.Get(), packet, packet.position());
            return true;
        }

        //@Override
        public override bool OnHoverEvent(MotionEvent @event)
        {
            if (!IsAttached())
            {
                return false;
            }

            bool handled = handleAccessibilityHoverEvent(@event);
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
            mMetrics.physicalWidth = width;
            mMetrics.physicalHeight = height;
            updateViewportMetrics();
            base.OnSizeChanged(width, height, oldWidth, oldHeight);
        }

        // TODO(garyq): Add support for notch cutout API
        // Decide if we want to zero the padding of the sides. When in Landscape orientation,
        // android may decide to place the software navigation bars on the side. When the nav
        // bar is hidden, the reported insets should be removed to prevent extra useless space
        // on the sides.
        public enum ZeroSides { NONE, LEFT, RIGHT, BOTH }
        public ZeroSides calculateShouldZeroSides()
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
                    return ZeroSides.RIGHT;

                if (rotation == SurfaceOrientation.Rotation270)
                    // In android API >= 23, the nav bar always appears on the "bottom" (USB) side.
                    return Build.VERSION.SdkInt >= BuildVersionCodes.M ? ZeroSides.LEFT : ZeroSides.RIGHT;

                // Ambiguous orientation due to landscape left/right default. Zero both sides.
                if (rotation == SurfaceOrientation.Rotation0 || rotation == SurfaceOrientation.Rotation180)
                    return ZeroSides.BOTH;
            }
            // Square orientation deprecated in API 16, we will not check for it and return false
            // to be safe and not remove any unique padding for the devices that do use it.
            return ZeroSides.NONE;
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
            ZeroSides zeroSides = ZeroSides.NONE;
            if (navigationBarHidden)
            {
                zeroSides = calculateShouldZeroSides();
            }

            // The padding on top should be removed when the statusbar is hidden.
            mMetrics.physicalPaddingTop = statusBarHidden ? 0 : insets.SystemWindowInsetTop;
            mMetrics.physicalPaddingRight =
                zeroSides == ZeroSides.RIGHT || zeroSides == ZeroSides.BOTH ? 0 : insets.SystemWindowInsetRight;
            mMetrics.physicalPaddingBottom = 0;
            mMetrics.physicalPaddingLeft =
                zeroSides == ZeroSides.LEFT || zeroSides == ZeroSides.BOTH ? 0 : insets.SystemWindowInsetLeft;

            // Bottom system inset (keyboard) should adjust scrollable bottom edge (inset).
            mMetrics.physicalViewInsetTop = 0;
            mMetrics.physicalViewInsetRight = 0;
            // We perform hidden navbar and keyboard handling if the navbar is set to hidden. Otherwise,
            // the navbar padding should always be provided.
            mMetrics.physicalViewInsetBottom =
                navigationBarHidden ? CalculateBottomKeyboardInset(insets) : insets.SystemWindowInsetBottom;
            mMetrics.physicalViewInsetLeft = 0;
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
                mMetrics.physicalPaddingTop = insets.Top;
                mMetrics.physicalPaddingRight = insets.Right;
                mMetrics.physicalPaddingBottom = 0;
                mMetrics.physicalPaddingLeft = insets.Left;

                // Bottom system inset (keyboard) should adjust scrollable bottom edge (inset).
                mMetrics.physicalViewInsetTop = 0;
                mMetrics.physicalViewInsetRight = 0;
                mMetrics.physicalViewInsetBottom = insets.Bottom;
                mMetrics.physicalViewInsetLeft = 0;
                UpdateViewportMetrics();
                return true;
            }
            return base.FitSystemWindows(insets);
        }

        private bool IsAttached()
        {
            return mNativeView != null && mNativeView.IsAttached();
        }

        private void AssertAttached()
        {
            if (!IsAttached())
                throw new AssertionError("Platform view is not attached");
        }

        private void PreRun()
        {
            resetAccessibilityTree();
        }

        private void PostRun()
        {
        }

        public void runFromBundle(FlutterRunArguments args)
        {
            AssertAttached();
            PreRun();
            mNativeView.RunFromBundle(args);
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
                bundlePath = bundlePath,
                entrypoint = entrypoint,
                defaultPath = defaultPath
            };
            runFromBundle(args);
        }

        /**
         * Return the most recent frame as a bitmap.
         *
         * @return A bitmap.
         */
        public Bitmap GetBitmap()
        {
            AssertAttached();
            return nativeGetBitmap(mNativeView.Get());
        }

        private static void nativeSurfaceCreated(long nativePlatformViewAndroid, Surface surface);      // native

        private static void nativeSurfaceChanged(long nativePlatformViewAndroid, int width, int height); // native

        private static void nativeSurfaceDestroyed(long nativePlatformViewAndroid);                     // native

        private static void nativeSetViewportMetrics(long nativePlatformViewAndroid, float devicePixelRatio,
                int physicalWidth, int physicalHeight, int physicalPaddingTop, int physicalPaddingRight,
                int physicalPaddingBottom, int physicalPaddingLeft, int physicalViewInsetTop, int physicalViewInsetRight,
                int physicalViewInsetBottom, int physicalViewInsetLeft);                                // native

        private static Bitmap nativeGetBitmap(long nativePlatformViewAndroid);                          // native

        // TODO: ByteBuffer->object
        private static void nativeDispatchPointerDataPacket(long nativePlatformViewAndroid, object buffer, int position); 
                                                                                                        // native

        // TODO: ByteBuffer->object
        private static void nativeDispatchSemanticsAction(long nativePlatformViewAndroid, int id, int action, object args, int argsPosition); 
                                                                                                        // native

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
            nativeSetViewportMetrics(mNativeView.Get(), mMetrics.devicePixelRatio, mMetrics.physicalWidth,
                    mMetrics.physicalHeight, mMetrics.physicalPaddingTop, mMetrics.physicalPaddingRight,
                    mMetrics.physicalPaddingBottom, mMetrics.physicalPaddingLeft, mMetrics.physicalViewInsetTop,
                    mMetrics.physicalViewInsetRight, mMetrics.physicalViewInsetBottom, mMetrics.physicalViewInsetLeft);

            IWindowManager wm = (IWindowManager)Context.GetSystemService(Context.WindowService);
            float fps = wm.DefaultDisplay.RefreshRate;
            VsyncWaiter.refreshPeriodNanos = (long)(1000000000.0 / fps);
            VsyncWaiter.refreshRateFPS = fps;
        }

        // Called by native to update the semantics/accessibility tree.
        // TODO: ByteBuffer->object
        public void UpdateSemantics(object buffer, string[] strings)
        {
            try
            {
                if (mAccessibilityNodeProvider != null)
                {
                    buffer.order(ByteOrder.LITTLE_ENDIAN);
                    mAccessibilityNodeProvider.updateSemantics(buffer, strings);
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
                if (mAccessibilityNodeProvider != null)
                {
                    buffer.order(ByteOrder.LITTLE_ENDIAN);
                    mAccessibilityNodeProvider.updateCustomAccessibilityActions(buffer, strings);
                }
            }
            catch (Exception ex)
            {
                Log.Error(TAG, "Uncaught exception while updating local context actions", ex);
            }
        }

        // Called by native to notify first Flutter frame rendered.
        public void OnFirstFrame()
        {
            // Allow listeners to remove themselves when they are called.
            foreach (var listener in mFirstFrameListeners)
                listener.onFirstFrame();
        }

        // ACCESSIBILITY

        private bool mAccessibilityEnabled = false;
        private bool mTouchExplorationEnabled = false;
        private AccessibilityFeatures mAccessibilityFeatureFlags;
        private TouchExplorationListener mTouchExplorationListener;

        public void DispatchSemanticsAction(int id, AccessibilityBridge.Action action)
        {
            DispatchSemanticsAction(id, action, null);
        }

        public void DispatchSemanticsAction(int id, AccessibilityBridge.Action action, object args)
        {
            if (!IsAttached())
                return;
            object encodedArgs = null;
            int position = 0;
            if (args != null)
            {
                encodedArgs = StandardMessageCodec.INSTANCE.EncodeMessage(args);
                position = encodedArgs.position();
            }
            nativeDispatchSemanticsAction(mNativeView.Get(), id, action.value, encodedArgs, position);
        }

        //@Override
        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            mAccessibilityEnabled = mAccessibilityManager.IsEnabled;
            mTouchExplorationEnabled = mAccessibilityManager.IsTouchExplorationEnabled;
            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr1)
            {
                Uri transitionUri = Settings.Global.getUriFor(Settings.Global.TRANSITION_ANIMATION_SCALE);
                Context.ContentResolver.RegisterContentObserver(transitionUri, false, mAnimationScaleObserver);
            }

            if (mAccessibilityEnabled || mTouchExplorationEnabled)
            {
                ensureAccessibilityEnabled();
            }
            if (mTouchExplorationEnabled)
                mAccessibilityFeatureFlags |= AccessibilityFeatures.AccessibleNavigation;
            else
                mAccessibilityFeatureFlags &= ~AccessibilityFeatures.AccessibleNavigation;

            // Apply additional accessibility settings
            UpdateAccessibilityFeatures();
            ResetWillNotDraw();
            mAccessibilityManager.AddAccessibilityStateChangeListener(this);
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat)
            {
                if (mTouchExplorationListener == null)
                {
                    mTouchExplorationListener = new TouchExplorationListener();
                }
                mAccessibilityManager.AddTouchExplorationStateChangeListener(mTouchExplorationListener);
            }
        }

        private void UpdateAccessibilityFeatures()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr1)
            {
                string transitionAnimationScale = Settings.Global.getString(Context.ContentResolver,
                    Settings.Global.TRANSITION_ANIMATION_SCALE);
                if (transitionAnimationScale != null && transitionAnimationScale.Equals("0"))
                    mAccessibilityFeatureFlags |= AccessibilityFeatures.DisableAnimations;
                else
                    mAccessibilityFeatureFlags &= ~AccessibilityFeatures.DisableAnimations;
            }
            NativeSetAccessibilityFeatures(mNativeView.Get(), mAccessibilityFeatureFlags);
        }

        //@Override
        protected override void OnDetachedFromWindow()
        {
            base.OnDetachedFromWindow();
            Context.ContentResolver.UnregisterContentObserver(mAnimationScaleObserver);
            mAccessibilityManager.RemoveAccessibilityStateChangeListener(this);
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat)
            {
                mAccessibilityManager.RemoveTouchExplorationStateChangeListener(mTouchExplorationListener);
            }
        }

        private void ResetWillNotDraw()
        {
            if (!mIsSoftwareRenderingEnabled)
                SetWillNotDraw(!(mAccessibilityEnabled || mTouchExplorationEnabled));
            else
                SetWillNotDraw(false);
        }

        //@Override
        public void OnAccessibilityStateChanged(bool enabled)
        {
            if (enabled)
            {
                ensureAccessibilityEnabled();
            }
            else
            {
                mAccessibilityEnabled = false;
                if (mAccessibilityNodeProvider != null)
                {
                    mAccessibilityNodeProvider.setAccessibilityEnabled(false);
                }
                nativeSetSemanticsEnabled(mNativeView.Get(), false);
            }
            ResetWillNotDraw();
        }


        // Listens to the global TRANSITION_ANIMATION_SCALE property and notifies us so
        // that we can disable animations in Flutter.
        private class AnimationScaleObserver : ContentObserver
        {
            public AnimationScaleObserver(Handler handler) : base(handler)
            {
            }

            //@Override
            public override void OnChange(bool selfChange)
            {
                OnChange(selfChange, null);
            }

            //@Override
            public void OnChange(bool selfChange, Uri uri)
            {
                string value = Settings.Global.getString(getContext().getContentResolver(),
                        Settings.Global.TRANSITION_ANIMATION_SCALE);
                if (value != null && value.Equals("0"))
                    mAccessibilityFeatureFlags |= AccessibilityFeatures.DisableAnimations;
                else
                    mAccessibilityFeatureFlags &= ~AccessibilityFeature.DISABLE_ANIMATIONS.value;
                NativeSetAccessibilityFeatures(mNativeView.get(), mAccessibilityFeatureFlags);
            }
        }

        internal class TouchExplorationListener : Java.Lang.Object, AccessibilityManager.ITouchExplorationStateChangeListener
        {
            //@Override
            public void OnTouchExplorationStateChanged(bool enabled)
            {
                if (enabled)
                {
                    mTouchExplorationEnabled = true;
                    ensureAccessibilityEnabled();
                    mAccessibilityFeatureFlags |= AccessibilityFeatures.AccessibleNavigation;
                    NativeSetAccessibilityFeatures(mNativeView.Get(), mAccessibilityFeatureFlags);
                }
                else
                {
                    mTouchExplorationEnabled = false;
                    if (mAccessibilityNodeProvider != null)
                    {
                        mAccessibilityNodeProvider.handleTouchExplorationExit();
                    }
                    mAccessibilityFeatureFlags &= ~AccessibilityFeatures.AccessibleNavigation;
                    NativeSetAccessibilityFeatures(mNativeView.Get(), mAccessibilityFeatureFlags);
                }
                ResetWillNotDraw();
            }
        }

        //@Override
        public AccessibilityNodeProvider GetAccessibilityNodeProvider()
        {
            if (mAccessibilityEnabled)
                return mAccessibilityNodeProvider;
            // TODO(goderbauer): when a11y is off this should return a one-off snapshot of
            // the a11y
            // tree.
            return null;
        }

        private AccessibilityBridge mAccessibilityNodeProvider;

        private void EnsureAccessibilityEnabled()
        {
            if (!IsAttached())
                return;
            mAccessibilityEnabled = true;
            if (mAccessibilityNodeProvider == null)
            {
                mAccessibilityNodeProvider = new AccessibilityBridge(this);
            }
            nativeSetSemanticsEnabled(mNativeView.Get(), true);
            mAccessibilityNodeProvider.setAccessibilityEnabled(true);
        }

        private void ResetAccessibilityTree()
        {
            if (mAccessibilityNodeProvider != null)
            {
                mAccessibilityNodeProvider.reset();
            }
        }

        private bool HandleAccessibilityHoverEvent(MotionEvent @event)
        {
            if (!mTouchExplorationEnabled)
            {
                return false;
            }
            if (@event.Action == MotionEventActions.HoverEnter || @event.Action == MotionEventActions.HoverMove)
            {
                mAccessibilityNodeProvider.handleTouchExploration(@event.GetX(), @event.GetY());
            } 
            else if (@event.Action == MotionEventActions.HoverExit) 
            {
                mAccessibilityNodeProvider.handleTouchExplorationExit();
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
        public void Send(string channel, object message, BinaryReply callback)
        {
            if (!IsAttached())
            {
                Log.Debug(TAG, "FlutterView.send called on a detached view, channel=" + channel);
                return;
            }
            mNativeView.Send(channel, message, callback);
        }

        //@Override
        public void SetMessageHandler(string channel, BinaryMessageHandler handler)
        {
            mNativeView.SetMessageHandler(channel, handler);
        }

        /**
         * Listener will be called on the Android UI thread once when Flutter renders
         * the first frame.
         */
        public interface FirstFrameListener
        {
            void onFirstFrame();
        }

        //@Override
        public TextureRegistry_SurfaceTextureEntry CreateSurfaceTexture()
        {
            SurfaceTexture surfaceTexture = new SurfaceTexture(0);
            surfaceTexture.DetachFromGLContext();
            var entry = new SurfaceTextureRegistryEntry(nextTextureId.GetAndIncrement(), surfaceTexture);
            nativeRegisterTexture(mNativeView.Get(), entry.Id(), surfaceTexture);
            return entry;
        }

        internal class SurfaceTextureRegistryEntry : TextureRegistry_SurfaceTextureEntry
        {
            private readonly long id;
            private readonly SurfaceTexture surfaceTexture;
            private readonly bool released;

            public SurfaceTextureRegistryEntry(long id, SurfaceTexture surfaceTexture)
            {
                this.id = id;
                this.surfaceTexture = surfaceTexture;

                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                {
                    // The callback relies on being executed on the UI thread (unsynchronised read of mNativeView
                    // and also the engine code check for platform thread in Shell::OnPlatformViewMarkTextureFrameAvailable),
                    // so we explicitly pass a Handler for the current thread.
                    this.surfaceTexture.SetOnFrameAvailableListener(OnFrameListener, new Handler());
                }
                else
                {
                    // Android documentation states that the listener can be called on an arbitrary thread.
                    // But in practice, versions of Android that predate the newer API will call the listener
                    // on the thread where the SurfaceTexture was constructed.
                    this.surfaceTexture.SetOnFrameAvailableListener(OnFrameListener);
                }
            }

            private readonly SurfaceTexture.IOnFrameAvailableListener OnFrameListener = new OnFrameAvailableListenerImpl
            {
                FrameAvailable = (texture) =>
                {
                    if (released)
                    {
                        // Even though we make sure to unregister the callback before releasing, as of Android O
                        // SurfaceTexture has a data race when accessing the callback, so the callback may
                        // still be called by a stale reference after released==true and mNativeView==null.
                        return;
                    }
                    nativeMarkTextureFrameAvailable(mNativeView.Get(), SurfaceTextureRegistryEntry.Id);
                }
            };

            //@Override
            public SurfaceTexture SurfaceTexture()
            {
                return surfaceTexture;
            }

            //@Override
            public long Id()
            {
                return id;
            }

            //@Override
            public void Release()
            {
                if (released)
                {
                    return;
                }
                released = true;
                nativeUnregisterTexture(mNativeView.Get(), id);
                // Otherwise onFrameAvailableListener might be called after mNativeView==null
                // (https://github.com/flutter/flutter/issues/20951). See also the check in onFrameAvailable.
                surfaceTexture.SetOnFrameAvailableListener(null);
                surfaceTexture.Release();
            }
        }
    }
}