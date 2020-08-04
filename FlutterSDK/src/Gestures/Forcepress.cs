using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Gestures.Forcepress
{
    /// <Summary>
    /// Signature used by a [ForcePressGestureRecognizer] for when a pointer has
    /// pressed with at least [ForcePressGestureRecognizer.startPressure].
    /// </Summary>
    public delegate void GestureForcePressStartCallback(FlutterSDK.Gestures.Forcepress.ForcePressDetails details);
    /// <Summary>
    /// Signature used by [ForcePressGestureRecognizer] for when a pointer that has
    /// pressed with at least [ForcePressGestureRecognizer.peakPressure].
    /// </Summary>
    public delegate void GestureForcePressPeakCallback(FlutterSDK.Gestures.Forcepress.ForcePressDetails details);
    /// <Summary>
    /// Signature used by [ForcePressGestureRecognizer] during the frames
    /// after the triggering of a [ForcePressGestureRecognizer.onStart] callback.
    /// </Summary>
    public delegate void GestureForcePressUpdateCallback(FlutterSDK.Gestures.Forcepress.ForcePressDetails details);
    /// <Summary>
    /// Signature for when the pointer that previously triggered a
    /// [ForcePressGestureRecognizer.onStart] callback is no longer in contact
    /// with the screen.
    /// </Summary>
    public delegate void GestureForcePressEndCallback(FlutterSDK.Gestures.Forcepress.ForcePressDetails details);
    /// <Summary>
    /// Signature used by [ForcePressGestureRecognizer] for interpolating the raw
    /// device pressure to a value in the range [0, 1] given the device's pressure
    /// min and pressure max.
    /// </Summary>
    public delegate double GestureForceInterpolation(double pressureMin, double pressureMax, double pressure);
    internal static class ForcepressDefaultClass
    {
    }

    /// <Summary>
    /// Details object for callbacks that use [GestureForcePressStartCallback],
    /// [GestureForcePressPeakCallback], [GestureForcePressEndCallback] or
    /// [GestureForcePressUpdateCallback].
    ///
    /// See also:
    ///
    ///  * [ForcePressGestureRecognizer.onStart], [ForcePressGestureRecognizer.onPeak],
    ///    [ForcePressGestureRecognizer.onEnd], and [ForcePressGestureRecognizer.onUpdate]
    ///    which use [ForcePressDetails].
    /// </Summary>
    public class ForcePressDetails
    {
        /// <Summary>
        /// Creates details for a [GestureForcePressStartCallback],
        /// [GestureForcePressPeakCallback] or [GestureForcePressEndCallback].
        ///
        /// The [globalPosition] argument must not be null.
        /// </Summary>
        public ForcePressDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), double pressure = default(double))
        : base()
        {
            this.GlobalPosition = globalPosition;
            this.Pressure = pressure;
        }
        /// <Summary>
        /// The global position at which the function was called.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
        /// <Summary>
        /// The local position at which the function was called.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
        /// <Summary>
        /// The pressure of the pointer on the screen.
        /// </Summary>
        public virtual double Pressure { get; set; }
    }


    /// <Summary>
    /// Recognizes a force press on devices that have force sensors.
    ///
    /// Only the force from a single pointer is used to invoke events. A tap
    /// recognizer will win against this recognizer on pointer up as long as the
    /// pointer has not pressed with a force greater than
    /// [ForcePressGestureRecognizer.startPressure]. A long press recognizer will
    /// win when the press down time exceeds the threshold time as long as the
    /// pointer's pressure was never greater than
    /// [ForcePressGestureRecognizer.startPressure] in that duration.
    ///
    /// As of November, 2018 iPhone devices of generation 6S and higher have
    /// force touch functionality, with the exception of the iPhone XR. In addition,
    /// a small handful of Android devices have this functionality as well.
    ///
    /// Devices with faux screen pressure sensors like the Pixel 2 and 3 will not
    /// send any force press related callbacks.
    ///
    /// Reported pressure will always be in the range 0.0 to 1.0, where 1.0 is
    /// maximum pressure and 0.0 is minimum pressure. If using a custom
    /// [interpolation] callback, the pressure reported will correspond to that
    /// custom curve.
    /// </Summary>
    public class ForcePressGestureRecognizer : FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer
    {
        /// <Summary>
        /// Creates a force press gesture recognizer.
        ///
        /// The [startPressure] defaults to 0.4, and [peakPressure] defaults to 0.85
        /// where a value of 0.0 is no pressure and a value of 1.0 is maximum pressure.
        ///
        /// The [startPressure], [peakPressure] and [interpolation] arguments must not
        /// be null. The [peakPressure] argument must be greater than [startPressure].
        /// The [interpolation] callback must always return a value in the range 0.0
        /// to 1.0 for values of `pressure` that are between `pressureMin` and
        /// `pressureMax`.
        ///
        /// {@macro flutter.gestures.gestureRecognizer.kind}
        /// </Summary>
        public ForcePressGestureRecognizer(double startPressure = 0.4, double peakPressure = 0.85, FlutterSDK.Gestures.Forcepress.GestureForceInterpolation interpolation = default(FlutterSDK.Gestures.Forcepress.GestureForceInterpolation), @Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {
            this.StartPressure = startPressure;
            this.PeakPressure = peakPressure;
            this.Interpolation = interpolation;
        }
        /// <Summary>
        /// A pointer is in contact with the screen and has just pressed with a force
        /// exceeding the [startPressure]. Consequently, if there were other gesture
        /// detectors, only the force press gesture will be detected and all others
        /// will be rejected.
        ///
        /// The position of the pointer is provided in the callback's `details`
        /// argument, which is a [ForcePressDetails] object.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback OnStart { get; set; }
        /// <Summary>
        /// A pointer is in contact with the screen and is either moving on the plane
        /// of the screen, pressing the screen with varying forces or both
        /// simultaneously.
        ///
        /// This callback will be invoked for every pointer event after the invocation
        /// of [onStart] and/or [onPeak] and before the invocation of [onEnd], no
        /// matter what the pressure is during this time period. The position and
        /// pressure of the pointer is provided in the callback's `details` argument,
        /// which is a [ForcePressDetails] object.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressUpdateCallback OnUpdate { get; set; }
        /// <Summary>
        /// A pointer is in contact with the screen and has just pressed with a force
        /// exceeding the [peakPressure]. This is an arbitrary second level action
        /// threshold and isn't necessarily the maximum possible device pressure
        /// (which is 1.0).
        ///
        /// The position of the pointer is provided in the callback's `details`
        /// argument, which is a [ForcePressDetails] object.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressPeakCallback OnPeak { get; set; }
        /// <Summary>
        /// A pointer is no longer in contact with the screen.
        ///
        /// The position of the pointer is provided in the callback's `details`
        /// argument, which is a [ForcePressDetails] object.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback OnEnd { get; set; }
        /// <Summary>
        /// The pressure of the press required to initiate a force press.
        ///
        /// A value of 0.0 is no pressure, and 1.0 is maximum pressure.
        /// </Summary>
        public virtual double StartPressure { get; set; }
        /// <Summary>
        /// The pressure of the press required to peak a force press.
        ///
        /// A value of 0.0 is no pressure, and 1.0 is maximum pressure. This value
        /// must be greater than [startPressure].
        /// </Summary>
        public virtual double PeakPressure { get; set; }
        /// <Summary>
        /// The function used to convert the raw device pressure values into a value
        /// in the range 0.0 to 1.0.
        ///
        /// The function takes in the device's minimum, maximum and raw touch pressure
        /// and returns a value in the range 0.0 to 1.0 denoting the interpolated
        /// touch pressure.
        ///
        /// This function must always return values in the range 0.0 to 1.0 given a
        /// pressure that is between the minimum and maximum pressures. It may return
        /// `double.NaN` for values that it does not want to support.
        ///
        /// By default, the function is a linear interpolation; however, changing the
        /// function could be useful to accommodate variations in the way different
        /// devices respond to pressure, or to change how animations from pressure
        /// feedback are rendered.
        ///
        /// For example, an ease-in curve can be used to determine the interpolated
        /// value:
        ///
        /// ```dart
        /// static double interpolateWithEasing(double min, double max, double t) {
        ///    final double lerp = (t - min) / (max - min);
        ///    return Curves.easeIn.transform(lerp);
        /// }
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Gestures.Forcepress.GestureForceInterpolation Interpolation { get; set; }
        internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _LastPosition { get; set; }
        internal virtual double _LastPressure { get; set; }
        internal virtual FlutterSDK.Gestures.Forcepress._ForceState _State { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            if (!(@event is PointerUpEvent) && @event.PressureMax <= 1.0)
            {
                Resolve(GestureDisposition.Rejected);
            }
            else
            {
                StartTrackingPointer(@event.Pointer, @event.Transform);
                if (_State == _ForceState.Ready)
                {
                    _State = _ForceState.Possible;
                    _LastPosition = OffsetPair.FromEventPosition(@event);
                }

            }

        }




        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {

            if (@event is PointerMoveEvent || @event is PointerDownEvent)
            {
                if (((PointerMoveEvent)@event).Pressure > ((PointerMoveEvent)@event).PressureMax || ((PointerMoveEvent)@event).Pressure < ((PointerMoveEvent)@event).PressureMin)
                {
                    PrintDefaultClass.DebugPrint("The reported device pressure " + ((PointerMoveEvent)@event).Pressure.ToString() + " is outside of the device pressure range where: " + ((PointerMoveEvent)@event).PressureMin.ToString() + " <= pressure <= " + ((PointerMoveEvent)@event).PressureMax.ToString());
                }

                double pressure = Interpolation(@event.PressureMin, @event.PressureMax, @event.Pressure);

                _LastPosition = OffsetPair.FromEventPosition(@event);
                _LastPressure = pressure;
                if (_State == _ForceState.Possible)
                {
                    if (pressure > StartPressure)
                    {
                        _State = _ForceState.Started;
                        Resolve(GestureDisposition.Accepted);
                    }
                    else if (@event.Delta.DistanceSquared > ConstantsDefaultClass.KTouchSlop)
                    {
                        Resolve(GestureDisposition.Rejected);
                    }

                }

                if (pressure > StartPressure && _State == _ForceState.Accepted)
                {
                    _State = _ForceState.Started;
                    if (OnStart != null)
                    {
                        InvokeCallback("onStart", () => =>OnStart(new ForcePressDetails(pressure: pressure, globalPosition: _LastPosition.Global, localPosition: _LastPosition.Local)));
                    }

                }

                if (OnPeak != null && pressure > PeakPressure && (_State == _ForceState.Started))
                {
                    _State = _ForceState.Peaked;
                    if (OnPeak != null)
                    {
                        InvokeCallback("onPeak", () => =>OnPeak(new ForcePressDetails(pressure: pressure, globalPosition: @event.Position, localPosition: @event.LocalPosition)));
                    }

                }

                if (OnUpdate != null && !pressure.IsNaN && (_State == _ForceState.Started || _State == _ForceState.Peaked))
                {
                    if (OnUpdate != null)
                    {
                        InvokeCallback("onUpdate", () => =>OnUpdate(new ForcePressDetails(pressure: pressure, globalPosition: @event.Position, localPosition: @event.LocalPosition)));
                    }

                }

            }

            StopTrackingIfPointerNoLongerDown(@event);
        }




        public new void AcceptGesture(int pointer)
        {
            if (_State == _ForceState.Possible) _State = _ForceState.Accepted;
            if (OnStart != null && _State == _ForceState.Started)
            {
                InvokeCallback("onStart", () => =>OnStart(new ForcePressDetails(pressure: _LastPressure, globalPosition: _LastPosition.Global, localPosition: _LastPosition.Local)));
            }

        }




        public new void DidStopTrackingLastPointer(int pointer)
        {
            bool wasAccepted = _State == _ForceState.Started || _State == _ForceState.Peaked;
            if (_State == _ForceState.Possible)
            {
                Resolve(GestureDisposition.Rejected);
                return;
            }

            if (wasAccepted && OnEnd != null)
            {
                if (OnEnd != null)
                {
                    InvokeCallback("onEnd", () => =>OnEnd(new ForcePressDetails(pressure: 0.0, globalPosition: _LastPosition.Global, localPosition: _LastPosition.Local)));
                }

            }

            _State = _ForceState.Ready;
        }




        public new void RejectGesture(int pointer)
        {
            StopTrackingPointer(pointer);
            DidStopTrackingLastPointer(pointer);
        }




        private double _InverseLerp(double min, double max, double t)
        {

            double value = (t - min) / (max - min);
            if (!value.IsNaN) value = value.Clamp(0.0, 1.0) as double;
            return value;
        }



    }


    public enum _ForceState
    {

        Ready,
        Possible,
        Accepted,
        Started,
        Peaked,
    }

}
