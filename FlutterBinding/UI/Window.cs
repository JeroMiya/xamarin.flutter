using System;
using System.Collections.Generic;
using System.Linq;
using FlutterBinding.Engine;
using FlutterBinding.Mapping;
using FlutterBinding.Shell;
using Newtonsoft.Json;

namespace FlutterBinding.UI
{
    /// Signature of callbacks that have no arguments and return no data.
    public delegate void VoidCallback();

    /// Signature for [Window.onBeginFrame].
    public delegate void FrameCallback(TimeDelta duration);

    /// Signature for [Window.onPointerDataPacket].
    public delegate void PointerDataPacketCallback(PointerDataPacket packet);

    /// Signature for [Window.onSemanticsAction].
    public delegate void SemanticsActionCallback(int id, SemanticsAction action, object args);

    /// Signature for responses to platform messages.
    ///
    /// Used as a parameter to [Window.sendPlatformMessage] and
    /// [Window.onPlatformMessage].
    public delegate void PlatformMessageResponseCallback(PlatformMessageResponse response);

    /// Signature for [Window.onPlatformMessage].
    public delegate void PlatformMessageCallback(PlatformMessage platformMessage);


    /// The most basic interface to the host operating system's user interface.
    ///
    /// There is a single Window instance in the system, which you can
    /// obtain from the [window] property.
    public class Window
    {
        /// The [Window] singleton. This object exposes the size of the display, the
        /// core scheduler API, the input event callback, the graphics drawing API, and
        /// other such core services.
        private static Window _instance;

        public static Window Instance => _instance ?? (_instance = new Window());

        private Window() { }

        /// The number of device pixels for each logical pixel. This number might not
        /// be a power of two. Indeed, it might not even be an integer. For example,
        /// the Nexus 6 has a device pixel ratio of 3.5.
        ///
        /// Device pixels are also referred to as physical pixels. Logical pixels are
        /// also referred to as device-independent or resolution-independent pixels.
        ///
        /// By definition, there are roughly 38 logical pixels per centimeter, or
        /// about 96 logical pixels per inch, of the physical display. The value
        /// returned by [devicePixelRatio] is ultimately obtained either from the
        /// hardware itself, the device drivers, or a hard-coded value stored in the
        /// operating system or firmware, and may be inaccurate, sometimes by a
        /// significant margin.
        ///
        /// The Flutter framework operates in logical pixels, so it is rarely
        /// necessary to directly deal with this property.
        ///
        /// When this changes, [onMetricsChanged] is called.
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver], for a mechanism at the widgets layer to
        ///    observe when this value changes.
        public double devicePixelRatio { get; set; } = 1.0;

        /// The dimensions of the rectangle into which the application will be drawn,
        /// in physical pixels.
        ///
        /// When this changes, [onMetricsChanged] is called.
        ///
        /// At startup, the size of the application window may not be known before Dart
        /// code runs. If this value is observed early in the application lifecycle,
        /// it may report [Size.zero].
        ///
        /// This value does not take into account any on-screen keyboards or other
        /// system UI. The [padding] and [viewInsets] properties provide a view into
        /// how much of each side of the application may be obscured by system UI.
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver], for a mechanism at the widgets layer to
        ///    observe when this value changes.
        public Size physicalSize { get; set; } = Size.zero;

        /// The number of physical pixels on each side of the display rectangle into
        /// which the application can render, but over which the operating system
        /// will likely place system UI, such as the keyboard, that fully obscures
        /// any content.
        ///
        /// When this changes, [onMetricsChanged] is called.
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver], for a mechanism at the widgets layer to
        ///    observe when this value changes.
        ///  * [MediaQuery.of], a simpler mechanism for the same.
        ///  * [Scaffold], which automatically applies the view insets in material
        ///    design applications.
        public WindowPadding viewInsets { get; set; } = WindowPadding.zero;

        /// The number of physical pixels on each side of the display rectangle into
        /// which the application can render, but which may be partially obscured by
        /// system UI (such as the system notification area), or or physical
        /// intrusions in the display (e.g. overscan regions on television screens or
        /// phone sensor housings).
        ///
        /// When this changes, [onMetricsChanged] is called.
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver], for a mechanism at the widgets layer to
        ///    observe when this value changes.
        ///  * [MediaQuery.of], a simpler mechanism for the same.
        ///  * [Scaffold], which automatically applies the padding in material design
        ///    applications.
        public WindowPadding padding { get; set; } = WindowPadding.zero;

        /// A callback that is invoked whenever the [devicePixelRatio],
        /// [physicalSize], [padding], or [viewInsets] values change, for example
        /// when the device is rotated or when the application is resized (e.g. when
        /// showing applications side-by-side on Android).
        ///
        /// The engine invokes this callback in the same zone in which the callback
        /// was set.
        ///
        /// The framework registers with this callback and updates the layout
        /// appropriately.
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver], for a mechanism at the widgets layer to
        ///    register for notifications when this is called.
        ///  * [MediaQuery.of], a simpler mechanism for the same.
        public VoidCallback onMetricsChanged
        {
            get => _onMetricsChanged;
            set
            {
                _onMetricsChanged    = value;
                OnMetricsChangedZone = Types.Zone.current;
            }
        }

        private VoidCallback _onMetricsChanged;
        internal Types.Zone OnMetricsChangedZone;


        /// The system-reported default locale of the device.
        ///
        /// This establishes the language and formatting conventions that application
        /// should, if possible, use to render their user interface.
        ///
        /// This is the first locale selected by the user and is the user's
        /// primary locale (the locale the device UI is displayed in)
        ///
        /// This is equivalent to `locales.first` and will provide an empty non-null locale
        /// if the [locales] list has not been set or is empty.
        public Locale locale
        {
            get
            {
                if (locales != null && locales.Count > 0)
                {
                    return locales.First();
                }

                return Locale.none;
            }
        }

        /// The full system-reported supported locales of the device.
        ///
        /// This establishes the language and formatting conventions that application
        /// should, if possible, use to render their user interface.
        ///
        /// The list is ordered in order of priority, with lower-indexed locales being
        /// preferred over higher-indexed ones. The first element is the primary [locale].
        ///
        /// The [onLocaleChanged] callback is called whenever this value changes.
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver], for a mechanism at the widgets layer to
        ///    observe when this value changes.
        public List<Locale> locales { get; set; }

        /// A callback that is invoked whenever [locale] changes value.
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver], for a mechanism at the widgets layer to
        ///    observe when this callback is invoked.
        public VoidCallback onLocaleChanged
        {
            get => _onLocaleChanged;
            set
            {
                _onLocaleChanged    = value;
                OnLocaleChangedZone = Types.Zone.current;
            }
        }

        private VoidCallback _onLocaleChanged;
        internal Types.Zone OnLocaleChangedZone;

        /// The system-reported text scale.
        ///
        /// This establishes the text scaling factor to use when rendering text,
        /// according to the user's platform preferences.
        ///
        /// The [onTextScaleFactorChanged] callback is called whenever this value
        /// changes.
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver], for a mechanism at the widgets layer to
        ///    observe when this value changes.
        public double textScaleFactor { get; set; } = 1.0;

        /// The setting indicating whether time should always be shown in the 24-hour
        /// format.
        ///
        /// This option is used by [showTimePicker].
        public bool alwaysUse24HourFormat { get; set; } = false;

        /// A callback that is invoked whenever [textScaleFactor] changes value.
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        ///
        /// See also:
        ///
        ///  * [WidgetsBindingObserver], for a mechanism at the widgets layer to
        ///    observe when this callback is invoked.
        public VoidCallback OnTextScaleFactorChanged
        {
            get => _onTextScaleFactorChanged;
            set
            {
                _onTextScaleFactorChanged    = value;
                OnTextScaleFactorChangedZone = Types.Zone.current;
            }
        }

        private VoidCallback _onTextScaleFactorChanged;
        internal Types.Zone OnTextScaleFactorChangedZone;

        /// A callback that is invoked to notify the application that it is an
        /// appropriate time to provide a scene using the [SceneBuilder] API and the
        /// [render] method. When possible, this is driven by the hardware VSync
        /// signal. This is only called if [scheduleFrame] has been called since the
        /// last time this callback was invoked.
        ///
        /// The [onDrawFrame] callback is invoked immediately after [onBeginFrame],
        /// after draining any microtasks (e.g. completions of any [Future]s) queued
        /// by the [onBeginFrame] handler.
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        ///
        /// See also:
        ///
        ///  * [SchedulerBinding], the Flutter framework class which manages the
        ///    scheduling of frames.
        ///  * [RendererBinding], the Flutter framework class which manages layout and
        ///    painting.
        public FrameCallback onBeginFrame
        {
            get => _onBeginFrame;
            set
            {
                _onBeginFrame    = value;
                OnBeginFrameZone = Types.Zone.current;
            }
        }

        private FrameCallback _onBeginFrame;
        internal Types.Zone OnBeginFrameZone;

        /// A callback that is invoked for each frame after [onBeginFrame] has
        /// completed and after the microtask queue has been drained. This can be
        /// used to implement a second phase of frame rendering that happens
        /// after any deferred work queued by the [onBeginFrame] phase.
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        ///
        /// See also:
        ///
        ///  * [SchedulerBinding], the Flutter framework class which manages the
        ///    scheduling of frames.
        ///  * [RendererBinding], the Flutter framework class which manages layout and
        ///    painting.
        public VoidCallback onDrawFrame
        {
            get => _onDrawFrame;
            set
            {
                _onDrawFrame    = value;
                OnDrawFrameZone = Types.Zone.current;
            }
        }

        private VoidCallback _onDrawFrame;
        internal Types.Zone OnDrawFrameZone;

        /// A callback that is invoked when pointer data is available.
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        ///
        /// See also:
        ///
        ///  * [GestureBinding], the Flutter framework class which manages pointer
        ///    events.
        public PointerDataPacketCallback onPointerDataPacket
        {
            get => _onPointerDataPacket;
            set
            {
                _onPointerDataPacket    = value;
                OnPointerDataPacketZone = Types.Zone.current;
            }
        }

        private PointerDataPacketCallback _onPointerDataPacket;
        internal Types.Zone OnPointerDataPacketZone;

        /// The route or path that the embedder requested when the application was
        /// launched.
        ///
        /// This will be the string "`/`" if no particular route was requested.
        ///
        /// ## Android
        ///
        /// On Android, calling
        /// [`FlutterView.setInitialRoute`](/javadoc/io/flutter/view/FlutterView.html#setInitialRoute-java.lang.String-)
        /// will set this value. The value must be set sufficiently early, i.e. before
        /// the [runApp] call is executed in Dart, for this to have any effect on the
        /// framework. The `createFlutterView` method in your `FlutterActivity`
        /// subclass is a suitable time to set the value. The application's
        /// `AndroidManifest.xml` file must also be updated to have a suitable
        /// [`<intent-filter>`](https://developer.android.com/guide/topics/manifest/intent-filter-element.html).
        ///
        /// ## iOS
        ///
        /// On iOS, calling
        /// [`FlutterViewController.setInitialRoute`](/objcdoc/Classes/FlutterViewController.html#/c:objc%28cs%29FlutterViewController%28im%29setInitialRoute:)
        /// will set this value. The value must be set sufficiently early, i.e. before
        /// the [runApp] call is executed in Dart, for this to have any effect on the
        /// framework. The `application:didFinishLaunchingWithOptions:` method is a
        /// suitable time to set this value.
        ///
        /// See also:
        ///
        ///  * [Navigator], a widget that handles routing.
        ///  * [SystemChannels.navigation], which handles subsequent navigation
        ///    requests from the embedder.
        public string defaultRouteName => _client.DefaultRouteName();


        /// Requests that, at the next appropriate opportunity, the [onBeginFrame]
        /// and [onDrawFrame] callbacks be invoked.
        ///
        /// See also:
        ///
        ///  * [SchedulerBinding], the Flutter framework class which manages the
        ///    scheduling of frames.
        public void scheduleFrame() => _client.ScheduleFrame();


        /// Updates the application's rendering on the GPU with the newly provided
        /// [Scene]. This function must be called within the scope of the
        /// [onBeginFrame] or [onDrawFrame] callbacks being invoked. If this function
        /// is called a second time during a single [onBeginFrame]/[onDrawFrame]
        /// callback sequence or called outside the scope of those callbacks, the call
        /// will be ignored.
        ///
        /// To record graphical operations, first create a [PictureRecorder], then
        /// construct a [Canvas], passing that [PictureRecorder] to its constructor.
        /// After issuing all the graphical operations, call the
        /// [PictureRecorder.endRecording] function on the [PictureRecorder] to obtain
        /// the final [Picture] that represents the issued graphical operations.
        ///
        /// Next, create a [SceneBuilder], and add the [Picture] to it using
        /// [SceneBuilder.addPicture]. With the [SceneBuilder.build] method you can
        /// then obtain a [Scene] object, which you can display to the user via this
        /// [render] function.
        ///
        /// See also:
        ///
        ///  * [SchedulerBinding], the Flutter framework class which manages the
        ///    scheduling of frames.
        ///  * [RendererBinding], the Flutter framework class which manages layout and
        ///    painting.
        public void Render(Scene scene)
        {
            Engine.Engine.Instance.Render(scene.TakeLayerTree());
        }


        /// Whether the user has requested that [updateSemantics] be called when
        /// the semantic contents of window changes.
        ///
        /// The [onSemanticsEnabledChanged] callback is called whenever this value
        /// changes.
        public bool semanticsEnabled { get; set; } = false;

        /// A callback that is invoked when the value of [semanticsEnabled] changes.
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        public VoidCallback onSemanticsEnabledChanged
        {
            get => _onSemanticsEnabledChanged;
            set
            {
                _onSemanticsEnabledChanged    = value;
                OnSemanticsEnabledChangedZone = Types.Zone.current;
            }
        }

        private VoidCallback _onSemanticsEnabledChanged;
        internal Types.Zone OnSemanticsEnabledChangedZone;

        /// A callback that is invoked whenever the user requests an action to be
        /// performed.
        ///
        /// This callback is used when the user expresses the action they wish to
        /// perform based on the semantics supplied by [updateSemantics].
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        public SemanticsActionCallback onSemanticsAction
        {
            get => _onSemanticsAction;
            set
            {
                _onSemanticsAction    = value;
                OnSemanticsActionZone = Types.Zone.current;
            }
        }

        private SemanticsActionCallback _onSemanticsAction;
        internal Types.Zone OnSemanticsActionZone;

        /// Additional accessibility features that may be enabled by the platform.
        public AccessibilityFeatures accessibilityFeatures { get; set; }

        /// A callback that is invoked when the value of [accessibilityFlags] changes.
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        public VoidCallback onAccessibilityFeaturesChanged
        {
            get => _onAccessibilityFeaturesChanged;
            set
            {
                _onAccessibilityFeaturesChanged = value;
                OnAccessibilityFlagsChangedZone = Types.Zone.current;
            }
        }

        private VoidCallback _onAccessibilityFeaturesChanged;
        internal Types.Zone OnAccessibilityFlagsChangedZone;

        /// Change the retained semantics data about this window.
        ///
        /// If [semanticsEnabled] is true, the user has requested that this funciton
        /// be called whenever the semantic content of this window changes.
        ///
        /// In either case, this function disposes the given update, which means the
        /// semantics update cannot be used further.
        public void updateSemantics(SemanticsUpdate update) => _client.UpdateSemantics(update);


        /// Set the debug name associated with this window's root isolate.
        ///
        /// Normally debug names are automatically generated from the Dart port, entry
        /// point, and source file. For example: `main.dart$main-1234`.
        ///
        /// This can be combined with flutter tools `--isolate-filter` flag to debug
        /// specific root isolates. For example: `flutter attach --isolate-filter=[name]`.
        /// Note that this does not rename any child isolates of the root.
        public void setIsolateDebugName(string name) => _client.SetIsolateDebugName(name);


        /// Sends a message to a platform-specific plugin.
        ///
        /// The `name` parameter determines which plugin receives the message. The
        /// `data` parameter contains the message payload and is typically UTF-8
        /// encoded JSON but can be arbitrary data. If the plugin replies to the
        /// message, `callback` will be called with the response.
        ///
        /// The framework invokes [callback] in the same zone in which this method
        /// was called.
        public void sendPlatformMessage(
            string name,
            object data,
            PlatformMessageResponseCallback response)
        {
            SendPlatformMessage(
                name,
                data,
                response);
        }


        /// Called whenever this window receives a message from a platform-specific
        /// plugin.
        ///
        /// The `name` parameter determines which plugin sent the message. The `data`
        /// parameter is the payload and is typically UTF-8 encoded JSON but can be
        /// arbitrary data.
        ///
        /// Message handlers must call the function given in the `callback` parameter.
        /// If the handler does not need to respond, the handler should pass null to
        /// the callback.
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        public PlatformMessageCallback OnPlatformMessage
        {
            get => _onPlatformMessage;
            set
            {
                _onPlatformMessage = value;
                OnPlatformMessageZone = Types.Zone.current;
            }
        }

        private PlatformMessageCallback _onPlatformMessage;
        internal Types.Zone OnPlatformMessageZone;

        /// Called by [_dispatchPlatformMessage].
        //internal void RespondToPlatformMessage(int responseId, ByteData data)
        //{
        //    // native 'Window_respondToPlatformMessage';
        //}

        // TODO: Improve/remove callback mechanism for talking to platform
        /// Wraps the given [callback] in another callback that ensures that the
        /// original callback is called in the zone it was registered in.
        //private static PlatformMessageResponseCallback _zonedPlatformMessageResponseCallback(PlatformMessageResponseCallback callback)
        //{
        //    if (callback == null)
        //        return null;

        //    // Store the zone in which the callback is being registered.
        //    Zone registrationZone = Zone.current;

        //    return (data) => registrationZone.runUnaryGuarded(callback, data);
        //}

        // NOTE: What is following in this file is mostly from the C++ Engine side of Window

        protected IWindowClient _client { get; set; }

        //private DartPersistentValue library_;
        private ViewportMetrics _viewport_metrics;

        public ViewportMetrics viewport_metrics()
        {
            return _viewport_metrics;
        }

        // TODO: Not required
        void DidCreateIsolate() { }

        public void UpdateWindowMetrics(ViewportMetrics metrics)
        {
            _viewport_metrics = metrics;

            // This bypasses Hooks.cs
            devicePixelRatio = metrics.DevicePixelRatio;
            physicalSize = new Size(metrics.PhysicalWidth, metrics.PhysicalHeight);
            padding = new WindowPadding(
                left: metrics.PhysicalPaddingLeft,
                top: metrics.PhysicalPaddingTop,
                right: metrics.PhysicalPaddingRight,
                bottom: metrics.PhysicalPaddingBottom
            );
            viewInsets = new WindowPadding(
                left: metrics.PhysicalViewInsetLeft,
                top: metrics.PhysicalViewInsetTop,
                right: metrics.PhysicalViewInsetRight,
                bottom: metrics.PhysicalViewInsetBottom);

            _invoke(onMetricsChanged, OnMetricsChangedZone);
        }

        public void UpdateLocales(List<Locale> locales)
        {
            this.locales = locales;
            _invoke(onLocaleChanged, OnLocaleChangedZone);
        }

        public void UpdateUserSettingsData(string jsonData)
        {
            var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonData);

            textScaleFactor = Convert.ToDouble(data["textScaleFactor"]);
            alwaysUse24HourFormat = Convert.ToBoolean(data["alwaysUse24HourFormat"]);

            _invoke(OnTextScaleFactorChanged, OnTextScaleFactorChangedZone);
        }

        public void UpdateSemanticsEnabled(bool enabled)
        {
            semanticsEnabled = enabled;
            _invoke(onSemanticsEnabledChanged, OnSemanticsEnabledChangedZone);
        }

        public void UpdateAccessibilityFeatures(AccessibilityFeatures newFeatures)
        {
            if (newFeatures == accessibilityFeatures)
                return;
            accessibilityFeatures = newFeatures;
            _invoke(onAccessibilityFeaturesChanged, OnAccessibilityFlagsChangedZone);
        }

        public void DispatchPlatformMessage(PlatformMessage message)
        {
            if (OnPlatformMessage == null)
                return;
            _invoke(() => OnPlatformMessage(message), OnPlatformMessageZone);
        }

        public void DispatchPointerDataPacket(PointerDataPacket packet)
        {
            if (onPointerDataPacket == null)
                return;
            _invoke(
                () => onPointerDataPacket(packet),
                OnPointerDataPacketZone);
        }

        public void DispatchSemanticsAction(int id, SemanticsAction action, object args)
        {
            if (onSemanticsAction == null)
                return;

            _invoke(
                () => { onSemanticsAction(id, action, args); },
                OnSemanticsActionZone);
        }

        public void BeginFrame(TimePoint frameTime)
        {
            var now = TimePoint.Now();
            var diff = now.TotalMicroseconds - frameTime.TotalMicroseconds;

            _invoke(
                () => onBeginFrame(TimeDelta.FromMicroseconds(diff)),
                OnBeginFrameZone);
        }

        //public void CompletePlatformMessageResponse(int response_id, std::vector<uint8_t> data);
        //public void CompletePlatformMessageEmptyResponse(int response_id);

        // 
        //public static void RegisterNatives(tonic::DartLibraryNatives* natives);

        protected void SendPlatformMessage(string name,
                                           object data = null,
                                           PlatformMessageResponseCallback onResponse = null)
        {
            var responseMessage = new PlatformMessageResponse(onResponse, null);
            var message = new PlatformMessage(name, data, responseMessage);
            _client.HandlePlatformMessage(message);
        }


        /// Invokes [callback] inside the given [zone].
        static void _invoke(VoidCallback callback, Types.Zone zone)
        {
            if (callback == null)
                return;
            if (Types.Zone.current == zone)
                callback();
            else
                zone.runGuarded(callback);
        }


        // We use id 0 to mean that no response is expected.
        //private int _nextResponseId = 1;
        //private Dictionary<int, PlatformMessageResponse> _pendingResponses_ = new Dictionary<int,PlatformMessageResponse>();
    }
}
