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
namespace FlutterSDK.Gestures.Longpress
{
    /// <Summary>
    /// Callback signature for [LongPressGestureRecognizer.onLongPress].
    ///
    /// Called when a pointer has remained in contact with the screen at the
    /// same location for a long period of time.
    /// </Summary>
    public delegate void GestureLongPressCallback();
    /// <Summary>
    /// Callback signature for [LongPressGestureRecognizer.onLongPressUp].
    ///
    /// Called when a pointer stops contacting the screen after a long press
    /// gesture was detected.
    /// </Summary>
    public delegate void GestureLongPressUpCallback();
    /// <Summary>
    /// Callback signature for [LongPressGestureRecognizer.onLongPressStart].
    ///
    /// Called when a pointer has remained in contact with the screen at the
    /// same location for a long period of time. Also reports the long press down
    /// position.
    /// </Summary>
    public delegate void GestureLongPressStartCallback(FlutterSDK.Gestures.Longpress.LongPressStartDetails details);
    /// <Summary>
    /// Callback signature for [LongPressGestureRecognizer.onLongPressMoveUpdate].
    ///
    /// Called when a pointer is moving after being held in contact at the same
    /// location for a long period of time. Reports the new position and its offset
    /// from the original down position.
    /// </Summary>
    public delegate void GestureLongPressMoveUpdateCallback(FlutterSDK.Gestures.Longpress.LongPressMoveUpdateDetails details);
    /// <Summary>
    /// Callback signature for [LongPressGestureRecognizer.onLongPressEnd].
    ///
    /// Called when a pointer stops contacting the screen after a long press
    /// gesture was detected. Also reports the position where the pointer stopped
    /// contacting the screen.
    /// </Summary>
    public delegate void GestureLongPressEndCallback(FlutterSDK.Gestures.Longpress.LongPressEndDetails details);
    internal static class LongpressDefaultClass
    {
    }

    /// <Summary>
    /// Details for callbacks that use [GestureLongPressStartCallback].
    ///
    /// See also:
    ///
    ///  * [LongPressGestureRecognizer.onLongPressStart], which uses [GestureLongPressStartCallback].
    ///  * [LongPressMoveUpdateDetails], the details for [GestureLongPressMoveUpdateCallback]
    ///  * [LongPressEndDetails], the details for [GestureLongPressEndCallback].
    /// </Summary>
    public class LongPressStartDetails
    {
        /// <Summary>
        /// Creates the details for a [GestureLongPressStartCallback].
        ///
        /// The [globalPosition] argument must not be null.
        /// </Summary>
        public LongPressStartDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.GlobalPosition = globalPosition;
        }
        /// <Summary>
        /// The global position at which the pointer contacted the screen.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
        /// <Summary>
        /// The local position at which the pointer contacted the screen.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
    }


    /// <Summary>
    /// Details for callbacks that use [GestureLongPressMoveUpdateCallback].
    ///
    /// See also:
    ///
    ///  * [LongPressGestureRecognizer.onLongPressMoveUpdate], which uses [GestureLongPressMoveUpdateCallback].
    ///  * [LongPressEndDetails], the details for [GestureLongPressEndCallback]
    ///  * [LongPressStartDetails], the details for [GestureLongPressStartCallback].
    /// </Summary>
    public class LongPressMoveUpdateDetails
    {
        /// <Summary>
        /// Creates the details for a [GestureLongPressMoveUpdateCallback].
        ///
        /// The [globalPosition] and [offsetFromOrigin] arguments must not be null.
        /// </Summary>
        public LongPressMoveUpdateDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset offsetFromOrigin = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localOffsetFromOrigin = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.GlobalPosition = globalPosition;
            this.OffsetFromOrigin = offsetFromOrigin;
        }
        /// <Summary>
        /// The global position of the pointer when it triggered this update.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
        /// <Summary>
        /// The local position of the pointer when it triggered this update.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
        /// <Summary>
        /// A delta offset from the point where the long press drag initially contacted
        /// the screen to the point where the pointer is currently located (the
        /// present [globalPosition]) when this callback is triggered.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset OffsetFromOrigin { get; set; }
        /// <Summary>
        /// A local delta offset from the point where the long press drag initially contacted
        /// the screen to the point where the pointer is currently located (the
        /// present [localPosition]) when this callback is triggered.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalOffsetFromOrigin { get; set; }
    }


    /// <Summary>
    /// Details for callbacks that use [GestureLongPressEndCallback].
    ///
    /// See also:
    ///
    ///  * [LongPressGestureRecognizer.onLongPressEnd], which uses [GestureLongPressEndCallback].
    ///  * [LongPressMoveUpdateDetails], the details for [GestureLongPressMoveUpdateCallback]
    ///  * [LongPressStartDetails], the details for [GestureLongPressStartCallback].
    /// </Summary>
    public class LongPressEndDetails
    {
        /// <Summary>
        /// Creates the details for a [GestureLongPressEndCallback].
        ///
        /// The [globalPosition] argument must not be null.
        /// </Summary>
        public LongPressEndDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), FlutterSDK.Gestures.Velocitytracker.Velocity velocity = default(FlutterSDK.Gestures.Velocitytracker.Velocity))
        : base()
        {
            this.GlobalPosition = globalPosition;
            this.Velocity = velocity;
        }
        /// <Summary>
        /// The global position at which the pointer lifted from the screen.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
        /// <Summary>
        /// The local position at which the pointer contacted the screen.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
        /// <Summary>
        /// The pointer's velocity when it stopped contacting the screen.
        ///
        /// Defaults to zero if not specified in the constructor.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Velocitytracker.Velocity Velocity { get; set; }
    }


    /// <Summary>
    /// Recognizes when the user has pressed down at the same location for a long
    /// period of time.
    ///
    /// The gesture must not deviate in position from its touch down point for 500ms
    /// until it's recognized. Once the gesture is accepted, the finger can be
    /// moved, triggering [onLongPressMoveUpdate] callbacks, unless the
    /// [postAcceptSlopTolerance] constructor argument is specified.
    ///
    /// [LongPressGestureRecognizer] competes on pointer events of [kPrimaryButton]
    /// only when it has at least one non-null callback. If it has no callbacks, it
    /// is a no-op.
    /// </Summary>
    public class LongPressGestureRecognizer : FlutterSDK.Gestures.Recognizer.PrimaryPointerGestureRecognizer
    {
        /// <Summary>
        /// Creates a long-press gesture recognizer.
        ///
        /// Consider assigning the [onLongPressStart] callback after creating this
        /// object.
        ///
        /// The [postAcceptSlopTolerance] argument can be used to specify a maximum
        /// allowed distance for the gesture to deviate from the starting point once
        /// the long press has triggered. If the gesture deviates past that point,
        /// subsequent callbacks ([onLongPressMoveUpdate], [onLongPressUp],
        /// [onLongPressEnd]) will stop. Defaults to null, which means the gesture
        /// can be moved without limit once the long press is accepted.
        ///
        /// The [duration] argument can be used to overwrite the default duration
        /// after which the long press will be recognized.
        /// </Summary>
        public LongPressGestureRecognizer(TimeSpan duration = default(TimeSpan), double postAcceptSlopTolerance = default(double), PointerDeviceKind kind = default(PointerDeviceKind), @Object debugOwner = default(@Object))
        : base(deadline: duration ?? ConstantsDefaultClass.KLongPressTimeout, postAcceptSlopTolerance: postAcceptSlopTolerance, kind: kind, debugOwner: debugOwner)
        {

        }
        internal virtual bool _LongPressAccepted { get; set; }
        internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _LongPressOrigin { get; set; }
        internal virtual int _InitialButtons { get; set; }
        /// <Summary>
        /// Called when a long press gesture by a primary button has been recognized.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onLongPressStart], which has the same timing but has data for the
        ///    press location.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback OnLongPress { get; set; }
        /// <Summary>
        /// Called when a long press gesture by a primary button has been recognized.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onLongPress], which has the same timing but without details.
        ///  * [LongPressStartDetails], which is passed as an argument to this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback OnLongPressStart { get; set; }
        /// <Summary>
        /// Called when moving after the long press by a primary button is recognized.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [LongPressMoveUpdateDetails], which is passed as an argument to this
        ///    callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback OnLongPressMoveUpdate { get; set; }
        /// <Summary>
        /// Called when the pointer stops contacting the screen after a long-press
        /// by a primary button.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onLongPressEnd], which has the same timing but has data for the up
        ///    gesture location.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressUpCallback OnLongPressUp { get; set; }
        /// <Summary>
        /// Called when the pointer stops contacting the screen after a long-press
        /// by a primary button.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onLongPressUp], which has the same timing, but without details.
        ///  * [LongPressEndDetails], which is passed as an argument to this
        ///    callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback OnLongPressEnd { get; set; }
        internal virtual FlutterSDK.Gestures.Velocitytracker.VelocityTracker _VelocityTracker { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            switch (@event.Buttons) { case EventsDefaultClass.KPrimaryButton: if (OnLongPressStart == null && OnLongPress == null && OnLongPressMoveUpdate == null && OnLongPressEnd == null && OnLongPressUp == null) return false; break; default: return false; }
            return base.IsPointerAllowed(@event);
        }




        public new void DidExceedDeadline()
        {
            Resolve(GestureDisposition.Accepted);
            _LongPressAccepted = true;
            base.AcceptGesture(PrimaryPointer);
            _CheckLongPressStart();
        }




        public new void HandlePrimaryPointer(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            if (!@event.Synthesized)
            {
                if (((PointerDownEvent)@event) is PointerDownEvent)
                {
                    _VelocityTracker = new VelocityTracker();
                    _VelocityTracker.AddPosition(((PointerDownEvent)@event).TimeStamp, ((PointerDownEvent)@event).LocalPosition);
                }

                if (@event is PointerMoveEvent)
                {

                    _VelocityTracker.AddPosition(((PointerMoveEvent)@event).TimeStamp, ((PointerMoveEvent)@event).LocalPosition);
                }

            }

            if (@event is PointerUpEvent)
            {
                if (_LongPressAccepted == true)
                {
                    _CheckLongPressEnd(((PointerUpEvent)@event));
                }
                else
                {
                    Resolve(GestureDisposition.Rejected);
                }

                _Reset();
            }
            else if (@event is PointerCancelEvent)
            {
                _Reset();
            }
            else if (@event is PointerDownEvent)
            {
                _LongPressOrigin = OffsetPair.FromEventPosition(((PointerDownEvent)@event));
                _InitialButtons = ((PointerDownEvent)@event).Buttons;
            }
            else if (@event is PointerMoveEvent)
            {
                if (((PointerMoveEvent)@event).Buttons != _InitialButtons)
                {
                    Resolve(GestureDisposition.Rejected);
                    StopTrackingPointer(PrimaryPointer);
                }
                else if (_LongPressAccepted)
                {
                    _CheckLongPressMoveUpdate(@event);
                }

            }

        }




        private void _CheckLongPressStart()
        {

            if (OnLongPressStart != null)
            {
                LongPressStartDetails details = new LongPressStartDetails(globalPosition: _LongPressOrigin.Global, localPosition: _LongPressOrigin.Local);
                InvokeCallback("onLongPressStart", () => =>OnLongPressStart(details));
            }

            if (OnLongPress != null) InvokeCallback("onLongPress", OnLongPress);
        }




        private void _CheckLongPressMoveUpdate(FlutterSDK.Gestures.Events.PointerEvent @event)
        {

            LongPressMoveUpdateDetails details = new LongPressMoveUpdateDetails(globalPosition: @event.Position, localPosition: @event.LocalPosition, offsetFromOrigin: @event.Position - _LongPressOrigin.Global, localOffsetFromOrigin: @event.LocalPosition - _LongPressOrigin.Local);
            if (OnLongPressMoveUpdate != null) InvokeCallback("onLongPressMoveUpdate", () => =>OnLongPressMoveUpdate(details));
        }




        private void _CheckLongPressEnd(FlutterSDK.Gestures.Events.PointerEvent @event)
        {

            VelocityEstimate estimate = _VelocityTracker.GetVelocityEstimate();
            Velocity velocity = estimate == null ? VelocitytrackerDefaultClass.Velocity.Zero : new Velocity(pixelsPerSecond: estimate.PixelsPerSecond);
            LongPressEndDetails details = new LongPressEndDetails(globalPosition: @event.Position, localPosition: @event.LocalPosition, velocity: velocity);
            _VelocityTracker = null;
            if (OnLongPressEnd != null) InvokeCallback("onLongPressEnd", () => =>OnLongPressEnd(details));
            if (OnLongPressUp != null) InvokeCallback("onLongPressUp", OnLongPressUp);
        }




        private void _Reset()
        {
            _LongPressAccepted = false;
            _LongPressOrigin = null;
            _InitialButtons = null;
            _VelocityTracker = null;
        }




        public new void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition)
        {
            if (_LongPressAccepted && disposition == GestureDisposition.Rejected)
            {
                _Reset();
            }

            base.Resolve(disposition);
        }




        public new void AcceptGesture(int pointer)
        {
        }



    }

}
