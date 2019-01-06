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
        /// The [Window] singleton. This object exposes
        ///  - the size of the display,
        ///  - the core scheduler API,
        ///  - the input event callback,
        ///  - the graphics drawing API,
        ///  - and other such core services.
        private static Window _instance;

        public static Window Instance => _instance ?? (_instance = new Window());

        public IWindowClient WindowClient { get; internal set; }

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
        public double DevicePixelRatio { get; private set; } = 1.0;

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
        public Size PhysicalSize { get; set; } = Size.zero;

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
        public WindowPadding ViewInsets { get; private set; } = WindowPadding.Zero;

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
        public WindowPadding Padding { get; private set; } = WindowPadding.Zero;

        public ViewportMetrics ViewportMetrics { get; private set; }

        /// <summary>
        /// Raised whenever the [devicePixelRatio], [physicalSize], [padding], or [viewInsets] values change
        /// for example: when the device is rotated or when the application is resized (e.g. when
        /// showing applications side-by-side on Android).
        /// </summary>
        public event EventHandler<ViewportMetrics> MetricsChanged;
        protected virtual void RaiseMetricsChanged(ViewportMetrics metrics)
        {
            MetricsChanged?.Invoke(this, metrics);
        }

        public void UpdateWindowMetrics(ViewportMetrics metrics)
        {
            ViewportMetrics = metrics;

            // This bypasses Hooks.cs
            DevicePixelRatio = metrics.DevicePixelRatio;
            PhysicalSize     = new Size(metrics.PhysicalWidth, metrics.PhysicalHeight);
            Padding = new WindowPadding(
                left: metrics.PhysicalPaddingLeft,
                top: metrics.PhysicalPaddingTop,
                right: metrics.PhysicalPaddingRight,
                bottom: metrics.PhysicalPaddingBottom
            );
            ViewInsets = new WindowPadding(
                left: metrics.PhysicalViewInsetLeft,
                top: metrics.PhysicalViewInsetTop,
                right: metrics.PhysicalViewInsetRight,
                bottom: metrics.PhysicalViewInsetBottom);

            RaiseMetricsChanged(metrics);
        }

        private double _textScaleFactor = 1.0;

        /// <summary>
        /// The system-reported text scale.
        ///
        /// This establishes the text scaling factor to use when rendering text,
        /// according to the user's platform preferences.
        ///
        /// The [TextScaleFactorChanged] event is raised whenever this value changes.
        /// </summary>
        public double TextScaleFactor
        {
            get => _textScaleFactor;
            set
            {
                if (Math.Abs(value - _textScaleFactor) > double.Epsilon)
                {
                    _textScaleFactor = value;
                    RaiseTextScaleFactorChanged(value);
                }
            }
        }

        /// <summary>
        /// A callback that is invoked whenever [textScaleFactor] changes value.
        /// </summary>
        public event EventHandler<double> TextScaleFactorChanged;
        protected virtual void RaiseTextScaleFactorChanged(double e)
        {
            TextScaleFactorChanged?.Invoke(this, e);
        }


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
        public event EventHandler<TimeDelta> BeginFrameDelta;
        public virtual void RaiseBeginFrameDelta(TimeDelta delta)
        {
            BeginFrameDelta?.Invoke(this, delta);
        }


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
        public event EventHandler DrawFrame;
        public virtual void RaiseDrawFrame()
        {
            DrawFrame?.Invoke(this, EventArgs.Empty);
        }

        /// A callback that is invoked when pointer data is available.
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        ///
        /// See also:
        ///
        ///  * [GestureBinding], the Flutter framework class which manages pointer events.
        public event EventHandler<PointerDataPacket> PointerDataPacket;
        public virtual void RaisePointerDataPacket(PointerDataPacket packet)
        {
            PointerDataPacket?.Invoke(this, packet);
        }

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
        public string DefaultRouteName => WindowClient.DefaultRouteName();


        /// Requests that, at the next appropriate opportunity, the [onBeginFrame]
        /// and [onDrawFrame] callbacks be invoked.
        ///
        /// See also:
        ///
        ///  * [SchedulerBinding], the Flutter framework class which manages the
        ///    scheduling of frames.
        public void ScheduleFrame() => WindowClient.ScheduleFrame();


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
            Engine.Engine.Instance.Render(scene.LayerTree);
        }


        private bool _semanticsEnabled = false;

        /// Whether the user has requested that [updateSemantics] be called when
        /// the semantic contents of window changes.
        ///
        /// The [onSemanticsEnabledChanged] callback is called whenever this value
        /// changes.
        public bool SemanticsEnabled
        {
            get => _semanticsEnabled;
            set
            {
                _semanticsEnabled = value;
                RaiseSemanticsEnabledChanged(value);
            }
        }

        public event EventHandler<bool> SemanticsEnabledChanged;
        public virtual void RaiseSemanticsEnabledChanged(bool enabled)
        {
            SemanticsEnabledChanged?.Invoke(this, enabled);
        }


        /// A callback that is invoked whenever the user requests an action to be
        /// performed.
        ///
        /// This callback is used when the user expresses the action they wish to
        /// perform based on the semantics supplied by [updateSemantics].
        ///
        /// The framework invokes this callback in the same zone in which the
        /// callback was set.
        public event EventHandler<SemanticsActionArgs> SemanticsAction;
        protected virtual void RaiseSemanticsAction(SemanticsActionArgs args)
        {
            SemanticsAction?.Invoke(this, args);
        }

        public class SemanticsActionArgs
        {
            public SemanticsActionArgs(int id, SemanticsAction semanticsAction, object args)
            {
                Id = id;
                SemanticsAction = semanticsAction;
                Args = args;
            }

            public int Id { get; }
            public SemanticsAction SemanticsAction { get; }
            public object Args { get; }
        }


        private AccessibilityFeatures _accessibilityFeatures;

        /// Additional accessibility features that may be enabled by the platform.
        public AccessibilityFeatures AccessibilityFeatures
        {
            get => _accessibilityFeatures;
            set
            {
                if (_accessibilityFeatures != value)
                {
                    _accessibilityFeatures = value;
                    RaiseAccessibilityFeaturesChanged(value);
                }
            }
        }

        public event EventHandler<AccessibilityFeatures> AccessibilityFeaturesChanged;
        protected virtual void RaiseAccessibilityFeaturesChanged(AccessibilityFeatures e)
        {
            AccessibilityFeaturesChanged?.Invoke(this, e);
        }


        /// Change the retained semantics data about this window.
        ///
        /// If [semanticsEnabled] is true, the user has requested that this function
        /// be called whenever the semantic content of this window changes.
        ///
        /// In either case, this function disposes the given update, which means the
        /// semantics update cannot be used further.
        public void UpdateSemantics(SemanticsUpdate update) => WindowClient.UpdateSemantics(update);


        /// Set the debug name associated with this window's root isolate.
        ///
        /// Normally debug names are automatically generated from the Dart port, entry
        /// point, and source file. For example: `main.dart$main-1234`.
        ///
        /// This can be combined with flutter tools `--isolate-filter` flag to debug
        /// specific root isolates. For example: `flutter attach --isolate-filter=[name]`.
        /// Note that this does not rename any child isolates of the root.
        public void SetIsolateDebugName(string name) => WindowClient.SetIsolateDebugName(name);


        /// Sends a message to a platform-specific plugin.
        ///
        /// The `name` parameter determines which plugin receives the message. The
        /// `data` parameter contains the message payload and is typically UTF-8
        /// encoded JSON but can be arbitrary data. If the plugin replies to the
        /// message, `callback` will be called with the response.
        ///
        /// The framework invokes [callback] in the same zone in which this method
        /// was called.
        public void SendPlatformMessage(
            string name,
            object data = null,
            PlatformMessageResponseCallback responseCallback = null)
        {
            var responseMessage = new PlatformMessageResponse(responseCallback, null);
            var message = new PlatformMessage(name, data, responseMessage);
            DispatchPlatformMessage(message);
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

        // Called by [_dispatchPlatformMessage].
        //internal void RespondToPlatformMessage(int responseId, object data)
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

        public event EventHandler<PlatformMessage> PlatformMessage;
        protected virtual void RaisePlatformMessage(PlatformMessage message)
        {
            PlatformMessage?.Invoke(this, message);
        }

        public void DispatchPlatformMessage(PlatformMessage message)
        {
            RaisePlatformMessage(message);
            WindowClient.HandlePlatformMessage(message);
        }

        public void DispatchSemanticsAction(int id, SemanticsAction action, object args)
        {
            RaiseSemanticsAction(new SemanticsActionArgs(id, action, args));
        }

        public void BeginFrame(TimePoint frameTime)
        {
            var now = TimePoint.Now();
            var diff = now.TotalMicroseconds - frameTime.TotalMicroseconds;

            RaiseBeginFrameDelta(TimeDelta.FromMicroseconds(diff));
        }

        //public void CompletePlatformMessageResponse(int response_id, std::vector<uint8_t> data);
        //public void CompletePlatformMessageEmptyResponse(int response_id);
        //public static void RegisterNatives(tonic::DartLibraryNatives* natives);

        // We use id 0 to mean that no response is expected.
        //private int _nextResponseId = 1;
        //private Dictionary<int, PlatformMessageResponse> _pendingResponses_ = new Dictionary<int,PlatformMessageResponse>();
    }
}
