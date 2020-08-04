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
namespace FlutterSDK.Gestures.Monodrag
{
    /// <Summary>
    /// Signature for when a pointer that was previously in contact with the screen
    /// and moving is no longer in contact with the screen.
    ///
    /// The velocity at which the pointer was moving when it stopped contacting
    /// the screen is available in the `details`.
    ///
    /// See [DragGestureRecognizer.onEnd].
    /// </Summary>
    public delegate void GestureDragEndCallback(FlutterSDK.Gestures.Dragdetails.DragEndDetails details);
    /// <Summary>
    /// Signature for when the pointer that previously triggered a
    /// [GestureDragDownCallback] did not complete.
    ///
    /// See [DragGestureRecognizer.onCancel].
    /// </Summary>
    public delegate void GestureDragCancelCallback();
    internal static class MonodragDefaultClass
    {
    }

    /// <Summary>
    /// Recognizes movement.
    ///
    /// In contrast to [MultiDragGestureRecognizer], [DragGestureRecognizer]
    /// recognizes a single gesture sequence for all the pointers it watches, which
    /// means that the recognizer has at most one drag sequence active at any given
    /// time regardless of how many pointers are in contact with the screen.
    ///
    /// [DragGestureRecognizer] is not intended to be used directly. Instead,
    /// consider using one of its subclasses to recognize specific types for drag
    /// gestures.
    ///
    /// [DragGestureRecognizer] competes on pointer events of [kPrimaryButton]
    /// only when it has at least one non-null callback. If it has no callbacks, it
    /// is a no-op.
    ///
    /// See also:
    ///
    ///  * [HorizontalDragGestureRecognizer], for left and right drags.
    ///  * [VerticalDragGestureRecognizer], for up and down drags.
    ///  * [PanGestureRecognizer], for drags that are not locked to a single axis.
    /// </Summary>
    public interface IDragGestureRecognizer
    {
        bool IsFlingGesture(FlutterSDK.Gestures.Velocitytracker.VelocityEstimate estimate);
        bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerEvent @event);
        void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerEvent @event);
        void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event);
        void AcceptGesture(int pointer);
        void RejectGesture(int pointer);
        void DidStopTrackingLastPointer(int pointer);
        void Dispose();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback OnDown { get; set; }
        FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback OnStart { get; set; }
        FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnUpdate { get; set; }
        FlutterSDK.Gestures.Monodrag.GestureDragEndCallback OnEnd { get; set; }
        FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback OnCancel { get; set; }
        double MinFlingDistance { get; set; }
        double MinFlingVelocity { get; set; }
        double MaxFlingVelocity { get; set; }
    }


    /// <Summary>
    /// Recognizes movement.
    ///
    /// In contrast to [MultiDragGestureRecognizer], [DragGestureRecognizer]
    /// recognizes a single gesture sequence for all the pointers it watches, which
    /// means that the recognizer has at most one drag sequence active at any given
    /// time regardless of how many pointers are in contact with the screen.
    ///
    /// [DragGestureRecognizer] is not intended to be used directly. Instead,
    /// consider using one of its subclasses to recognize specific types for drag
    /// gestures.
    ///
    /// [DragGestureRecognizer] competes on pointer events of [kPrimaryButton]
    /// only when it has at least one non-null callback. If it has no callbacks, it
    /// is a no-op.
    ///
    /// See also:
    ///
    ///  * [HorizontalDragGestureRecognizer], for left and right drags.
    ///  * [VerticalDragGestureRecognizer], for up and down drags.
    ///  * [PanGestureRecognizer], for drags that are not locked to a single axis.
    /// </Summary>
    public class DragGestureRecognizer : FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer
    {
        /// <Summary>
        /// Initialize the object.
        ///
        /// [dragStartBehavior] must not be null.
        ///
        /// {@macro flutter.gestures.gestureRecognizer.kind}
        /// </Summary>
        public DragGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(debugOwner: debugOwner, kind: kind)
        {
            this.DragStartBehavior = dragStartBehavior;
        }
        /// <Summary>
        /// Configure the behavior of offsets sent to [onStart].
        ///
        /// If set to [DragStartBehavior.start], the [onStart] callback will be called
        /// at the time and position when this gesture recognizer wins the arena. If
        /// [DragStartBehavior.down], [onStart] will be called at the time and
        /// position when a down event was first detected.
        ///
        /// For more information about the gesture arena:
        /// https://flutter.dev/docs/development/ui/advanced/gestures#gesture-disambiguation
        ///
        /// By default, the drag start behavior is [DragStartBehavior.start].
        ///
        /// ## Example:
        ///
        /// A finger presses down on the screen with offset (500.0, 500.0), and then
        /// moves to position (510.0, 500.0) before winning the arena. With
        /// [dragStartBehavior] set to [DragStartBehavior.down], the [onStart]
        /// callback will be called at the time corresponding to the touch's position
        /// at (500.0, 500.0). If it is instead set to [DragStartBehavior.start],
        /// [onStart] will be called at the time corresponding to the touch's position
        /// at (510.0, 500.0).
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        /// <Summary>
        /// A pointer has contacted the screen with a primary button and might begin
        /// to move.
        ///
        /// The position of the pointer is provided in the callback's `details`
        /// argument, which is a [DragDownDetails] object.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [DragDownDetails], which is passed as an argument to this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback OnDown { get; set; }
        /// <Summary>
        /// A pointer has contacted the screen with a primary button and has begun to
        /// move.
        ///
        /// The position of the pointer is provided in the callback's `details`
        /// argument, which is a [DragStartDetails] object.
        ///
        /// Depending on the value of [dragStartBehavior], this function will be
        /// called on the initial touch down, if set to [DragStartBehavior.down] or
        /// when the drag gesture is first detected, if set to
        /// [DragStartBehavior.start].
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [DragStartDetails], which is passed as an argument to this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback OnStart { get; set; }
        /// <Summary>
        /// A pointer that is in contact with the screen with a primary button and
        /// moving has moved again.
        ///
        /// The distance traveled by the pointer since the last update is provided in
        /// the callback's `details` argument, which is a [DragUpdateDetails] object.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [DragUpdateDetails], which is passed as an argument to this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnUpdate { get; set; }
        /// <Summary>
        /// A pointer that was previously in contact with the screen with a primary
        /// button and moving is no longer in contact with the screen and was moving
        /// at a specific velocity when it stopped contacting the screen.
        ///
        /// The velocity is provided in the callback's `details` argument, which is a
        /// [DragEndDetails] object.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [DragEndDetails], which is passed as an argument to this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragEndCallback OnEnd { get; set; }
        /// <Summary>
        /// The pointer that previously triggered [onDown] did not complete.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback OnCancel { get; set; }
        /// <Summary>
        /// The minimum distance an input pointer drag must have moved to
        /// to be considered a fling gesture.
        ///
        /// This value is typically compared with the distance traveled along the
        /// scrolling axis. If null then [kTouchSlop] is used.
        /// </Summary>
        public virtual double MinFlingDistance { get; set; }
        /// <Summary>
        /// The minimum velocity for an input pointer drag to be considered fling.
        ///
        /// This value is typically compared with the magnitude of fling gesture's
        /// velocity along the scrolling axis. If null then [kMinFlingVelocity]
        /// is used.
        /// </Summary>
        public virtual double MinFlingVelocity { get; set; }
        /// <Summary>
        /// Fling velocity magnitudes will be clamped to this value.
        ///
        /// If null then [kMaxFlingVelocity] is used.
        /// </Summary>
        public virtual double MaxFlingVelocity { get; set; }
        internal virtual FlutterSDK.Gestures.Monodrag._DragState _State { get; set; }
        internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _InitialPosition { get; set; }
        internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _PendingDragOffset { get; set; }
        internal virtual TimeSpan _LastPendingEventTimestamp { get; set; }
        internal virtual int _InitialButtons { get; set; }
        internal virtual Matrix4 _LastTransform { get; set; }
        /// <Summary>
        /// Distance moved in the global coordinate space of the screen in drag direction.
        ///
        /// If drag is only allowed along a defined axis, this value may be negative to
        /// differentiate the direction of the drag.
        /// </Summary>
        internal virtual double _GlobalDistanceMoved { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Gestures.Velocitytracker.VelocityTracker> _VelocityTrackers { get; set; }
        internal virtual bool _HasSufficientGlobalDistanceToAccept { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Determines if a gesture is a fling or not based on velocity.
        ///
        /// A fling calls its gesture end callback with a velocity, allowing the
        /// provider of the callback to respond by carrying the gesture forward with
        /// inertia, for example.
        /// </Summary>
        public virtual bool IsFlingGesture(FlutterSDK.Gestures.Velocitytracker.VelocityEstimate estimate)
        {
            return default(bool);
        }


        private Offset _GetDeltaForDetails(FlutterBinding.UI.Offset delta)
        {
            return default(Offset);
        }


        private double _GetPrimaryValueFromOffset(FlutterBinding.UI.Offset value)
        {
            return default(double);
        }


        public new bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            if (_InitialButtons == null)
            {
                switch (@event.Buttons) { case EventsDefaultClass.KPrimaryButton: if (OnDown == null && OnStart == null && OnUpdate == null && OnEnd == null && OnCancel == null) return false; break; default: return false; }
            }
            else
            {
                if (@event.Buttons != _InitialButtons)
                {
                    return false;
                }

            }

            return base.IsPointerAllowed(@event as PointerDownEvent);
        }




        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            StartTrackingPointer(@event.Pointer, @event.Transform);
            _VelocityTrackers[@event.Pointer] = new VelocityTracker();
            if (_State == _DragState.Ready)
            {
                _State = _DragState.Possible;
                _InitialPosition = new OffsetPair(global: @event.Position, local: @event.LocalPosition);
                _InitialButtons = @event.Buttons;
                _PendingDragOffset = RecognizerDefaultClass.OffsetPair.Zero;
                _GlobalDistanceMoved = 0.0;
                _LastPendingEventTimestamp = @event.TimeStamp;
                _LastTransform = @event.Transform;
                _CheckDown();
            }
            else if (_State == _DragState.Accepted)
            {
                Resolve(GestureDisposition.Accepted);
            }

        }




        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {

            if (!@event.Synthesized && (@event is PointerDownEvent || @event is PointerMoveEvent))
            {
                VelocityTracker tracker = _VelocityTrackers[((PointerDownEvent)@event).Pointer];

                tracker.AddPosition(((PointerDownEvent)@event).TimeStamp, ((PointerDownEvent)@event).LocalPosition);
            }

            if (@event is PointerMoveEvent)
            {
                if (((PointerMoveEvent)@event).Buttons != _InitialButtons)
                {
                    _GiveUpPointer(((PointerMoveEvent)@event).Pointer);
                    return;
                }

                if (_State == _DragState.Accepted)
                {
                    _CheckUpdate(sourceTimeStamp: @event.TimeStamp, delta: _GetDeltaForDetails(@event.LocalDelta), primaryDelta: _GetPrimaryValueFromOffset(@event.LocalDelta), globalPosition: @event.Position, localPosition: @event.LocalPosition);
                }
                else
                {
                    _PendingDragOffset += new OffsetPair(local: @event.LocalDelta, global: @event.Delta);
                    _LastPendingEventTimestamp = @event.TimeStamp;
                    _LastTransform = @event.Transform;
                    Offset movedLocally = _GetDeltaForDetails(@event.LocalDelta);
                    Matrix4 localToGlobalTransform = @event.Transform == null ? null : Matrix4.TryInvert(@event.Transform);
                    _GlobalDistanceMoved += EventsDefaultClass.PointerEvent.TransformDeltaViaPositions(transform: localToGlobalTransform, untransformedDelta: movedLocally, untransformedEndPosition: @event.LocalPosition).Distance * (_GetPrimaryValueFromOffset(movedLocally) ?? 1).Sign;
                    if (_HasSufficientGlobalDistanceToAccept) Resolve(GestureDisposition.Accepted);
                }

            }

            if (@event is PointerUpEvent || @event is PointerCancelEvent)
            {
                _GiveUpPointer(((PointerUpEvent)@event).Pointer, reject: ((PointerUpEvent)@event) is PointerCancelEvent || _State == _DragState.Possible);
            }

        }




        public new void AcceptGesture(int pointer)
        {
            if (_State != _DragState.Accepted)
            {
                _State = _DragState.Accepted;
                OffsetPair delta = _PendingDragOffset;
                TimeSpan timestamp = _LastPendingEventTimestamp;
                Matrix4 transform = _LastTransform;
                Offset localUpdateDelta = default(Offset);
                switch (DragStartBehavior) { case DragStartBehavior.Start: _InitialPosition = _InitialPosition + delta; localUpdateDelta = Dart.UiDefaultClass.Offset.Zero; break; case DragStartBehavior.Down: localUpdateDelta = _GetDeltaForDetails(delta.Local); break; }
                _PendingDragOffset = RecognizerDefaultClass.OffsetPair.Zero;
                _LastPendingEventTimestamp = null;
                _LastTransform = null;
                _CheckStart(timestamp);
                if (localUpdateDelta != Dart.UiDefaultClass.Offset.Zero && OnUpdate != null)
                {
                    Matrix4 localToGlobal = transform != null ? Matrix4.TryInvert(transform) : null;
                    Offset correctedLocalPosition = _InitialPosition.Local + localUpdateDelta;
                    Offset globalUpdateDelta = EventsDefaultClass.PointerEvent.TransformDeltaViaPositions(untransformedEndPosition: correctedLocalPosition, untransformedDelta: localUpdateDelta, transform: localToGlobal);
                    OffsetPair updateDelta = new OffsetPair(local: localUpdateDelta, global: globalUpdateDelta);
                    OffsetPair correctedPosition = _InitialPosition + updateDelta;
                    _CheckUpdate(sourceTimeStamp: timestamp, delta: localUpdateDelta, primaryDelta: _GetPrimaryValueFromOffset(localUpdateDelta), globalPosition: correctedPosition.Global, localPosition: correctedPosition.Local);
                }

            }

        }




        public new void RejectGesture(int pointer)
        {
            _GiveUpPointer(pointer);
        }




        public new void DidStopTrackingLastPointer(int pointer)
        {

            switch (_State) { case _DragState.Ready: break; case _DragState.Possible: Resolve(GestureDisposition.Rejected); _CheckCancel(); break; case _DragState.Accepted: _CheckEnd(pointer); break; }
            _VelocityTrackers.Clear();
            _InitialButtons = null;
            _State = _DragState.Ready;
        }




        private void _GiveUpPointer(int pointer, bool reject = true)
        {
            StopTrackingPointer(pointer);
            if (reject)
            {
                if (_VelocityTrackers.ContainsKey(pointer))
                {
                    _VelocityTrackers.Remove(pointer);
                    ResolvePointer(pointer, GestureDisposition.Rejected);
                }

            }

        }




        private void _CheckDown()
        {

            DragDownDetails details = new DragDownDetails(globalPosition: _InitialPosition.Global, localPosition: _InitialPosition.Local);
            if (OnDown != null) InvokeCallback("onDown", () => =>OnDown(details));
        }




        private void _CheckStart(TimeSpan timestamp)
        {

            DragStartDetails details = new DragStartDetails(sourceTimeStamp: timestamp, globalPosition: _InitialPosition.Global, localPosition: _InitialPosition.Local);
            if (OnStart != null) InvokeCallback("onStart", () => =>OnStart(details));
        }




        private void _CheckUpdate(TimeSpan sourceTimeStamp = default(TimeSpan), FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset), double primaryDelta = default(double), FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset))
        {

            DragUpdateDetails details = new DragUpdateDetails(sourceTimeStamp: sourceTimeStamp, delta: delta, primaryDelta: primaryDelta, globalPosition: globalPosition, localPosition: localPosition);
            if (OnUpdate != null) InvokeCallback("onUpdate", () => =>OnUpdate(details));
        }




        private void _CheckEnd(int pointer)
        {

            if (OnEnd == null) return;
            VelocityTracker tracker = _VelocityTrackers[pointer];

            DragEndDetails details = default(DragEndDetails);
            Func<String> debugReport = default();
            VelocityEstimate estimate = tracker.GetVelocityEstimate();
            if (estimate != null && IsFlingGesture(estimate))
            {
                Velocity velocity = new Velocity(pixelsPerSecond: estimate.PixelsPerSecond).ClampMagnitude(minFlingVelocity == default(double) ? kMinFlingVelocity : minFlingVelocity, maxFlingVelocity == default(double) ? kMaxFlingVelocity : maxFlingVelocity);
                details = new DragEndDetails(velocity: velocity, primaryVelocity: _GetPrimaryValueFromOffset(velocity.PixelsPerSecond));
                debugReport = () =>
                {
                    return $"'{estimate}; fling at {velocity}.'";
                }
                ;
            }
            else
            {
                details = new DragEndDetails(velocity: VelocitytrackerDefaultClass.Velocity.Zero, primaryVelocity: 0.0);
                debugReport = () =>
                {
                    if (estimate == null) return "Could not estimate velocity.";
                    return $"'{estimate}; judged to not be a fling.'";
                }
                ;
            }

            InvokeCallback("onEnd", () => =>OnEnd(details), debugReport: debugReport);
        }




        private void _CheckCancel()
        {

            if (OnCancel != null) InvokeCallback("onCancel", OnCancel);
        }




        public new void Dispose()
        {
            _VelocityTrackers.Clear();
            base.Dispose();
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<DragStartBehavior>("start behavior", DragStartBehavior));
        }



    }


    /// <Summary>
    /// Recognizes movement in the vertical direction.
    ///
    /// Used for vertical scrolling.
    ///
    /// See also:
    ///
    ///  * [HorizontalDragGestureRecognizer], for a similar recognizer but for
    ///    horizontal movement.
    ///  * [MultiDragGestureRecognizer], for a family of gesture recognizers that
    ///    track each touch point independently.
    /// </Summary>
    public class VerticalDragGestureRecognizer : FlutterSDK.Gestures.Monodrag.DragGestureRecognizer
    {
        /// <Summary>
        /// Create a gesture recognizer for interactions in the vertical axis.
        ///
        /// {@macro flutter.gestures.gestureRecognizer.kind}
        /// </Summary>
        public VerticalDragGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {

        }
        internal virtual bool _HasSufficientGlobalDistanceToAccept { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool IsFlingGesture(FlutterSDK.Gestures.Velocitytracker.VelocityEstimate estimate)
        {
            double minVelocity = minFlingVelocity == default(double) ? kMinFlingVelocity : minFlingVelocity;
            double minDistance = minFlingDistance == default(double) ? kTouchSlop : minFlingDistance;
            return estimate.PixelsPerSecond.Dy.Abs() > minVelocity && estimate.Offset.Dy.Abs() > minDistance;
        }




        protected new Offset _GetDeltaForDetails(FlutterBinding.UI.Offset delta) => new Offset(0.0, delta.Dy);



        protected new double _GetPrimaryValueFromOffset(FlutterBinding.UI.Offset value) => value.Dy;


    }


    /// <Summary>
    /// Recognizes movement in the horizontal direction.
    ///
    /// Used for horizontal scrolling.
    ///
    /// See also:
    ///
    ///  * [VerticalDragGestureRecognizer], for a similar recognizer but for
    ///    vertical movement.
    ///  * [MultiDragGestureRecognizer], for a family of gesture recognizers that
    ///    track each touch point independently.
    /// </Summary>
    public class HorizontalDragGestureRecognizer : FlutterSDK.Gestures.Monodrag.DragGestureRecognizer
    {
        /// <Summary>
        /// Create a gesture recognizer for interactions in the horizontal axis.
        ///
        /// {@macro flutter.gestures.gestureRecognizer.kind}
        /// </Summary>
        public HorizontalDragGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {

        }
        internal virtual bool _HasSufficientGlobalDistanceToAccept { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool IsFlingGesture(FlutterSDK.Gestures.Velocitytracker.VelocityEstimate estimate)
        {
            double minVelocity = minFlingVelocity == default(double) ? kMinFlingVelocity : minFlingVelocity;
            double minDistance = minFlingDistance == default(double) ? kTouchSlop : minFlingDistance;
            return estimate.PixelsPerSecond.Dx.Abs() > minVelocity && estimate.Offset.Dx.Abs() > minDistance;
        }




        protected new Offset _GetDeltaForDetails(FlutterBinding.UI.Offset delta) => new Offset(delta.Dx, 0.0);



        protected new double _GetPrimaryValueFromOffset(FlutterBinding.UI.Offset value) => value.Dx;


    }


    /// <Summary>
    /// Recognizes movement both horizontally and vertically.
    ///
    /// See also:
    ///
    ///  * [ImmediateMultiDragGestureRecognizer], for a similar recognizer that
    ///    tracks each touch point independently.
    ///  * [DelayedMultiDragGestureRecognizer], for a similar recognizer that
    ///    tracks each touch point independently, but that doesn't start until
    ///    some time has passed.
    /// </Summary>
    public class PanGestureRecognizer : FlutterSDK.Gestures.Monodrag.DragGestureRecognizer
    {
        /// <Summary>
        /// Create a gesture recognizer for tracking movement on a plane.
        /// </Summary>
        public PanGestureRecognizer(@Object debugOwner = default(@Object))
        : base(debugOwner: debugOwner)
        {

        }
        internal virtual bool _HasSufficientGlobalDistanceToAccept { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool IsFlingGesture(FlutterSDK.Gestures.Velocitytracker.VelocityEstimate estimate)
        {
            double minVelocity = minFlingVelocity == default(double) ? kMinFlingVelocity : minFlingVelocity;
            double minDistance = minFlingDistance == default(double) ? kTouchSlop : minFlingDistance;
            return estimate.PixelsPerSecond.DistanceSquared > minVelocity * minVelocity && estimate.Offset.DistanceSquared > minDistance * minDistance;
        }




        protected new Offset _GetDeltaForDetails(FlutterBinding.UI.Offset delta) => delta;



        protected new double _GetPrimaryValueFromOffset(FlutterBinding.UI.Offset value) => null;


    }


    public enum _DragState
    {

        Ready,
        Possible,
        Accepted,
    }

}
