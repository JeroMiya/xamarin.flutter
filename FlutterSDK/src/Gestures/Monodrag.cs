using System;
using FlutterSDK;
using FlutterSDK.Widgets.Framework;
using System.Net.Http;
using FlutterBinding.UI;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using SkiaSharp;
using FlutterBinding.Engine.Painting;
using static FlutterSDK.Global;
using FlutterBinding.Mapping;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Willpopscope;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Scrollview;
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
namespace FlutterSDK.Gestures.Monodrag
{
    public delegate void GestureDragEndCallback(FlutterSDK.Gestures.Dragdetails.DragEndDetails details);
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
        #region constructors
        public DragGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(debugOwner: debugOwner, kind: kind)
        {
            this.DragStartBehavior = dragStartBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback OnDown { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback OnStart { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnUpdate { get; set; }
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragEndCallback OnEnd { get; set; }
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback OnCancel { get; set; }
        public virtual double MinFlingDistance { get; set; }
        public virtual double MinFlingVelocity { get; set; }
        public virtual double MaxFlingVelocity { get; set; }
        internal virtual FlutterSDK.Gestures.Monodrag._DragState _State { get; set; }
        internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _InitialPosition { get; set; }
        internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _PendingDragOffset { get; set; }
        internal virtual TimeSpan _LastPendingEventTimestamp { get; set; }
        internal virtual int _InitialButtons { get; set; }
        internal virtual Matrix4 _LastTransform { get; set; }
        internal virtual double _GlobalDistanceMoved { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Gestures.Velocitytracker.VelocityTracker> _VelocityTrackers { get; set; }
        internal virtual bool _HasSufficientGlobalDistanceToAccept { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Determines if a gesture is a fling or not based on velocity.
        ///
        /// A fling calls its gesture end callback with a velocity, allowing the
        /// provider of the callback to respond by carrying the gesture forward with
        /// inertia, for example.
        /// </Summary>
        public virtual bool IsFlingGesture(FlutterSDK.Gestures.Velocitytracker.VelocityEstimate estimate) { throw new NotImplementedException(); }


        private Offset _GetDeltaForDetails(FlutterBinding.UI.Offset delta) { throw new NotImplementedException(); }


        private double _GetPrimaryValueFromOffset(FlutterBinding.UI.Offset value) { throw new NotImplementedException(); }


        public new bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public new void AcceptGesture(int pointer) { throw new NotImplementedException(); }


        public new void RejectGesture(int pointer) { throw new NotImplementedException(); }


        public new void DidStopTrackingLastPointer(int pointer) { throw new NotImplementedException(); }


        private void _GiveUpPointer(int pointer, bool reject = true) { throw new NotImplementedException(); }


        private void _CheckDown() { throw new NotImplementedException(); }


        private void _CheckStart(TimeSpan timestamp) { throw new NotImplementedException(); }


        private void _CheckUpdate(TimeSpan sourceTimeStamp = default(TimeSpan), FlutterBinding.UI.Offset delta = default(FlutterBinding.UI.Offset), double primaryDelta = default(double), FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        private void _CheckEnd(int pointer) { throw new NotImplementedException(); }


        private void _CheckCancel() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public VerticalDragGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual bool _HasSufficientGlobalDistanceToAccept { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool IsFlingGesture(FlutterSDK.Gestures.Velocitytracker.VelocityEstimate estimate) { throw new NotImplementedException(); }


        protected new Offset _GetDeltaForDetails(FlutterBinding.UI.Offset delta) { throw new NotImplementedException(); }


        protected new double _GetPrimaryValueFromOffset(FlutterBinding.UI.Offset value) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public HorizontalDragGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual bool _HasSufficientGlobalDistanceToAccept { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool IsFlingGesture(FlutterSDK.Gestures.Velocitytracker.VelocityEstimate estimate) { throw new NotImplementedException(); }


        protected new Offset _GetDeltaForDetails(FlutterBinding.UI.Offset delta) { throw new NotImplementedException(); }


        protected new double _GetPrimaryValueFromOffset(FlutterBinding.UI.Offset value) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public PanGestureRecognizer(@Object debugOwner = default(@Object))
        : base(debugOwner: debugOwner)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual bool _HasSufficientGlobalDistanceToAccept { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool IsFlingGesture(FlutterSDK.Gestures.Velocitytracker.VelocityEstimate estimate) { throw new NotImplementedException(); }


        protected new Offset _GetDeltaForDetails(FlutterBinding.UI.Offset delta) { throw new NotImplementedException(); }


        protected new double _GetPrimaryValueFromOffset(FlutterBinding.UI.Offset value) { throw new NotImplementedException(); }

        #endregion
    }


    public enum _DragState
    {

        Ready,
        Possible,
        Accepted,
    }

}
