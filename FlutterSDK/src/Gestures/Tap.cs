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
namespace FlutterSDK.Gestures.Tap
{
    /// <Summary>
    /// Signature for when a pointer that might cause a tap has contacted the
    /// screen.
    ///
    /// The position at which the pointer contacted the screen is available in the
    /// `details`.
    ///
    /// See also:
    ///
    ///  * [GestureDetector.onTapDown], which matches this signature.
    ///  * [TapGestureRecognizer], which uses this signature in one of its callbacks.
    /// </Summary>
    public delegate void GestureTapDownCallback(FlutterSDK.Gestures.Tap.TapDownDetails details);
    /// <Summary>
    /// Signature for when a pointer that will trigger a tap has stopped contacting
    /// the screen.
    ///
    /// The position at which the pointer stopped contacting the screen is available
    /// in the `details`.
    ///
    /// See also:
    ///
    ///  * [GestureDetector.onTapUp], which matches this signature.
    ///  * [TapGestureRecognizer], which uses this signature in one of its callbacks.
    /// </Summary>
    public delegate void GestureTapUpCallback(FlutterSDK.Gestures.Tap.TapUpDetails details);
    /// <Summary>
    /// Signature for when a tap has occurred.
    ///
    /// See also:
    ///
    ///  * [GestureDetector.onTap], which matches this signature.
    ///  * [TapGestureRecognizer], which uses this signature in one of its callbacks.
    /// </Summary>
    public delegate void GestureTapCallback();
    /// <Summary>
    /// Signature for when the pointer that previously triggered a
    /// [GestureTapDownCallback] will not end up causing a tap.
    ///
    /// See also:
    ///
    ///  * [GestureDetector.onTapCancel], which matches this signature.
    ///  * [TapGestureRecognizer], which uses this signature in one of its callbacks.
    /// </Summary>
    public delegate void GestureTapCancelCallback();
    internal static class TapDefaultClass
    {
    }

    /// <Summary>
    /// A base class for gesture recognizers that recognize taps.
    ///
    /// Gesture recognizers take part in gesture arenas to enable potential gestures
    /// to be disambiguated from each other. This process is managed by a
    /// [GestureArenaManager].
    ///
    /// A tap is defined as a sequence of events that starts with a down, followed
    /// by optional moves, then ends with an up. All move events must contain the
    /// same `buttons` as the down event, and must not be too far from the initial
    /// position. The gesture is rejected on any violation, a cancel event, or
    /// if any other recognizers wins the arena. It is accepted only when it is the
    /// last member of the arena.
    ///
    /// The [BaseTapGestureRecognizer] considers all the pointers involved in the
    /// pointer event sequence as contributing to one gesture. For this reason,
    /// extra pointer interactions during a tap sequence are not recognized as
    /// additional taps. For example, down-1, down-2, up-1, up-2 produces only one
    /// tap on up-1.
    ///
    /// The [BaseTapGestureRecognizer] can not be directly used, since it does not
    /// define which buttons to accept, or what to do when a tap happens. If you
    /// want to build a custom tap recognizer, extend this class by overriding
    /// [isPointerAllowed] and the handler methods.
    ///
    /// See also:
    ///
    ///  * [TapGestureRecognizer], a ready-to-use tap recognizer that recognizes
    ///    taps of the primary button and taps of the secondary button.
    ///  * [ModalBarrier], a widget that uses a custom tap recognizer that accepts
    ///    any buttons.
    /// </Summary>
    public interface IBaseTapGestureRecognizer
    {
        void HandleTapDown(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent));
        void HandleTapUp(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent), FlutterSDK.Gestures.Events.PointerUpEvent up = default(FlutterSDK.Gestures.Events.PointerUpEvent));
        void HandleTapCancel(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent), FlutterSDK.Gestures.Events.PointerCancelEvent cancel = default(FlutterSDK.Gestures.Events.PointerCancelEvent), string reason = default(string));
        void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
        void StartTrackingPointer(int pointer, Matrix4 transform = default(Matrix4));
        void HandlePrimaryPointer(FlutterSDK.Gestures.Events.PointerEvent @event);
        void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition);
        void DidExceedDeadline();
        void AcceptGesture(int pointer);
        void RejectGesture(int pointer);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        string DebugDescription { get; }
    }


    /// <Summary>
    /// Details for [GestureTapDownCallback], such as position
    ///
    /// See also:
    ///
    ///  * [GestureDetector.onTapDown], which receives this information.
    ///  * [TapGestureRecognizer], which passes this information to one of its callbacks.
    /// </Summary>
    public class TapDownDetails
    {
        /// <Summary>
        /// Creates details for a [GestureTapDownCallback].
        ///
        /// The [globalPosition] argument must not be null.
        /// </Summary>
        public TapDownDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), PointerDeviceKind kind = default(PointerDeviceKind))
        : base()
        {
            this.GlobalPosition = globalPosition;
            this.Kind = kind;
        }
        /// <Summary>
        /// The global position at which the pointer contacted the screen.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
        /// <Summary>
        /// The kind of the device that initiated the event.
        /// </Summary>
        public virtual PointerDeviceKind Kind { get; set; }
        /// <Summary>
        /// The local position at which the pointer contacted the screen.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
    }


    /// <Summary>
    /// Details for [GestureTapUpCallback], such as position.
    ///
    /// See also:
    ///
    ///  * [GestureDetector.onTapUp], which receives this information.
    ///  * [TapGestureRecognizer], which passes this information to one of its callbacks.
    /// </Summary>
    public class TapUpDetails
    {
        /// <Summary>
        /// The [globalPosition] argument must not be null.
        /// </Summary>
        public TapUpDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset))
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
    /// A base class for gesture recognizers that recognize taps.
    ///
    /// Gesture recognizers take part in gesture arenas to enable potential gestures
    /// to be disambiguated from each other. This process is managed by a
    /// [GestureArenaManager].
    ///
    /// A tap is defined as a sequence of events that starts with a down, followed
    /// by optional moves, then ends with an up. All move events must contain the
    /// same `buttons` as the down event, and must not be too far from the initial
    /// position. The gesture is rejected on any violation, a cancel event, or
    /// if any other recognizers wins the arena. It is accepted only when it is the
    /// last member of the arena.
    ///
    /// The [BaseTapGestureRecognizer] considers all the pointers involved in the
    /// pointer event sequence as contributing to one gesture. For this reason,
    /// extra pointer interactions during a tap sequence are not recognized as
    /// additional taps. For example, down-1, down-2, up-1, up-2 produces only one
    /// tap on up-1.
    ///
    /// The [BaseTapGestureRecognizer] can not be directly used, since it does not
    /// define which buttons to accept, or what to do when a tap happens. If you
    /// want to build a custom tap recognizer, extend this class by overriding
    /// [isPointerAllowed] and the handler methods.
    ///
    /// See also:
    ///
    ///  * [TapGestureRecognizer], a ready-to-use tap recognizer that recognizes
    ///    taps of the primary button and taps of the secondary button.
    ///  * [ModalBarrier], a widget that uses a custom tap recognizer that accepts
    ///    any buttons.
    /// </Summary>
    public class BaseTapGestureRecognizer : FlutterSDK.Gestures.Recognizer.PrimaryPointerGestureRecognizer
    {
        /// <Summary>
        /// Creates a tap gesture recognizer.
        /// </Summary>
        public BaseTapGestureRecognizer(@Object debugOwner = default(@Object))
        : base(deadline: ConstantsDefaultClass.KPressTimeout, debugOwner: debugOwner)
        {

        }
        internal virtual bool _SentTapDown { get; set; }
        internal virtual bool _WonArenaForPrimaryPointer { get; set; }
        internal virtual FlutterSDK.Gestures.Events.PointerDownEvent _Down { get; set; }
        internal virtual FlutterSDK.Gestures.Events.PointerUpEvent _Up { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// A pointer has contacted the screen, which might be the start of a tap.
        ///
        /// This triggers after the down event, once a short timeout ([deadline]) has
        /// elapsed, or once the gesture has won the arena, whichever comes first.
        ///
        /// The parameter `down` is the down event of the primary pointer that started
        /// the tap sequence.
        ///
        /// If this recognizer doesn't win the arena, [handleTapCancel] is called next.
        /// Otherwise, [handleTapUp] is called next.
        /// </Summary>
        public virtual void HandleTapDown(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent))
        {
        }


        /// <Summary>
        /// A pointer has stopped contacting the screen, which is recognized as a tap.
        ///
        /// This triggers on the up event, if the recognizer wins the arena with it
        /// or has previously won.
        ///
        /// The parameter `down` is the down event of the primary pointer that started
        /// the tap sequence, and `up` is the up event that ended the tap sequence.
        ///
        /// If this recognizer doesn't win the arena, [handleTapCancel] is called
        /// instead.
        /// </Summary>
        public virtual void HandleTapUp(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent), FlutterSDK.Gestures.Events.PointerUpEvent up = default(FlutterSDK.Gestures.Events.PointerUpEvent))
        {
        }


        /// <Summary>
        /// A pointer that previously triggered [handleTapDown] will not end up
        /// causing a tap.
        ///
        /// This triggers once the gesture loses the arena, if [handleTapDown] has
        /// been previously triggered.
        ///
        /// The parameter `down` is the down event of the primary pointer that started
        /// the tap sequence; `cancel` is the cancel event, which might be null;
        /// `reason` is a short description of the cause if `cancel` is null, which
        /// can be "forced" if other gestures won the arena, or "spontaneous"
        /// otherwise.
        ///
        /// If this recognizer wins the arena, [handleTapUp] is called instead.
        /// </Summary>
        public virtual void HandleTapCancel(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent), FlutterSDK.Gestures.Events.PointerCancelEvent cancel = default(FlutterSDK.Gestures.Events.PointerCancelEvent), string reason = default(string))
        {
        }


        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {

            if (State == GestureRecognizerState.Ready)
            {
                _Down = @event;
            }

            if (_Down != null)
            {
                base.AddAllowedPointer(@event);
            }

        }




        public new void StartTrackingPointer(int pointer, Matrix4 transform = default(Matrix4))
        {

            base.StartTrackingPointer(pointer, transform);
        }




        public new void HandlePrimaryPointer(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            if (@event is PointerUpEvent)
            {
                _Up = ((PointerUpEvent)@event);
                _CheckUp();
            }
            else if (@event is PointerCancelEvent)
            {
                Resolve(GestureDisposition.Rejected);
                if (_SentTapDown)
                {
                    _CheckCancel(((PointerCancelEvent)@event), "");
                }

                _Reset();
            }
            else if (@event.Buttons != _Down.Buttons)
            {
                Resolve(GestureDisposition.Rejected);
                StopTrackingPointer(PrimaryPointer);
            }

        }




        public new void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition)
        {
            if (_WonArenaForPrimaryPointer && disposition == GestureDisposition.Rejected)
            {

                _CheckCancel(null, "spontaneous");
                _Reset();
            }

            base.Resolve(disposition);
        }




        public new void DidExceedDeadline()
        {
            _CheckDown();
        }




        public new void AcceptGesture(int pointer)
        {
            base.AcceptGesture(pointer);
            if (pointer == PrimaryPointer)
            {
                _CheckDown();
                _WonArenaForPrimaryPointer = true;
                _CheckUp();
            }

        }




        public new void RejectGesture(int pointer)
        {
            base.RejectGesture(pointer);
            if (pointer == PrimaryPointer)
            {

                if (_SentTapDown) _CheckCancel(null, "forced");
                _Reset();
            }

        }




        private void _CheckDown()
        {
            if (_SentTapDown)
            {
                return;
            }

            HandleTapDown(down: _Down);
            _SentTapDown = true;
        }




        private void _CheckUp()
        {
            if (!_WonArenaForPrimaryPointer || _Up == null)
            {
                return;
            }

            HandleTapUp(down: _Down, up: _Up);
            _Reset();
        }




        private void _CheckCancel(FlutterSDK.Gestures.Events.PointerCancelEvent @event, string note)
        {
            HandleTapCancel(down: _Down, cancel: @event, reason: note);
        }




        private void _Reset()
        {
            _SentTapDown = false;
            _WonArenaForPrimaryPointer = false;
            _Up = null;
            _Down = null;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new FlagProperty("wonArenaForPrimaryPointer", value: _WonArenaForPrimaryPointer, ifTrue: "won arena"));
            properties.Add(new DiagnosticsProperty<Offset>("finalPosition", _Up?.Position, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Offset>("finalLocalPosition", _Up?.LocalPosition, defaultValue: _Up?.Position));
            properties.Add(new DiagnosticsProperty<int>("button", _Down?.Buttons, defaultValue: null));
            properties.Add(new FlagProperty("sentTapDown", value: _SentTapDown, ifTrue: "sent tap down"));
        }



    }


    /// <Summary>
    /// Recognizes taps.
    ///
    /// Gesture recognizers take part in gesture arenas to enable potential gestures
    /// to be disambiguated from each other. This process is managed by a
    /// [GestureArenaManager].
    ///
    /// [TapGestureRecognizer] considers all the pointers involved in the pointer
    /// event sequence as contributing to one gesture. For this reason, extra
    /// pointer interactions during a tap sequence are not recognized as additional
    /// taps. For example, down-1, down-2, up-1, up-2 produces only one tap on up-1.
    ///
    /// [TapGestureRecognizer] competes on pointer events of [kPrimaryButton] only
    /// when it has at least one non-null `onTap*` callback, and events of
    /// [kSecondaryButton] only when it has at least one non-null `onSecondaryTap*`
    /// callback. If it has no callbacks, it is a no-op.
    ///
    /// See also:
    ///
    ///  * [GestureDetector.onTap], which uses this recognizer.
    ///  * [MultiTapGestureRecognizer]
    /// </Summary>
    public class TapGestureRecognizer : FlutterSDK.Gestures.Tap.BaseTapGestureRecognizer
    {
        /// <Summary>
        /// Creates a tap gesture recognizer.
        /// </Summary>
        public TapGestureRecognizer(@Object debugOwner = default(@Object))
        : base(debugOwner: debugOwner)
        {

        }
        /// <Summary>
        /// A pointer has contacted the screen at a particular location with a primary
        /// button, which might be the start of a tap.
        ///
        /// This triggers after the down event, once a short timeout ([deadline]) has
        /// elapsed, or once the gestures has won the arena, whichever comes first.
        ///
        /// If this recognizer doesn't win the arena, [onTapCancel] is called next.
        /// Otherwise, [onTapUp] is called next.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onSecondaryTapDown], a similar callback but for a secondary button.
        ///  * [TapDownDetails], which is passed as an argument to this callback.
        ///  * [GestureDetector.onTapDown], which exposes this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapDownCallback OnTapDown { get; set; }
        /// <Summary>
        /// A pointer has stopped contacting the screen at a particular location,
        /// which is recognized as a tap of a primary button.
        ///
        /// This triggers on the up event, if the recognizer wins the arena with it
        /// or has previously won, immediately followed by [onTap].
        ///
        /// If this recognizer doesn't win the arena, [onTapCancel] is called instead.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onSecondaryTapUp], a similar callback but for a secondary button.
        ///  * [TapUpDetails], which is passed as an argument to this callback.
        ///  * [GestureDetector.onTapUp], which exposes this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapUpCallback OnTapUp { get; set; }
        /// <Summary>
        /// A pointer has stopped contacting the screen, which is recognized as a tap
        /// of a primary button.
        ///
        /// This triggers on the up event, if the recognizer wins the arena with it
        /// or has previously won, immediately following [onTap].
        ///
        /// If this recognizer doesn't win the arena, [onTapCancel] is called instead.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onTapUp], which has the same timing but with details.
        ///  * [GestureDetector.onTap], which exposes this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap { get; set; }
        /// <Summary>
        /// A pointer that previously triggered [onTapDown] will not end up causing
        /// a tap.
        ///
        /// This triggers once the gesture loses the arena, if [onTapDown] has
        /// previously been triggered.
        ///
        /// If this recognizer wins the arena, [onTapUp] and [onTap] are called
        /// instead.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onSecondaryTapCancel], a similar callback but for a secondary button.
        ///  * [GestureDetector.onTapCancel], which exposes this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapCancelCallback OnTapCancel { get; set; }
        /// <Summary>
        /// A pointer has contacted the screen at a particular location with a
        /// secondary button, which might be the start of a secondary tap.
        ///
        /// This triggers after the down event, once a short timeout ([deadline]) has
        /// elapsed, or once the gestures has won the arena, whichever comes first.
        ///
        /// If this recognizer doesn't win the arena, [onSecondaryTapCancel] is called
        /// next. Otherwise, [onSecondaryTapUp] is called next.
        ///
        /// See also:
        ///
        ///  * [kSecondaryButton], the button this callback responds to.
        ///  * [onTapDown], a similar callback but for a primary button.
        ///  * [TapDownDetails], which is passed as an argument to this callback.
        ///  * [GestureDetector.onSecondaryTapDown], which exposes this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapDownCallback OnSecondaryTapDown { get; set; }
        /// <Summary>
        /// A pointer has stopped contacting the screen at a particular location,
        /// which is recognized as a tap of a secondary button.
        ///
        /// This triggers on the up event, if the recognizer wins the arena with it
        /// or has previously won.
        ///
        /// If this recognizer doesn't win the arena, [onSecondaryTapCancel] is called
        /// instead.
        ///
        /// See also:
        ///
        ///  * [kSecondaryButton], the button this callback responds to.
        ///  * [onTapUp], a similar callback but for a primary button.
        ///  * [TapUpDetails], which is passed as an argument to this callback.
        ///  * [GestureDetector.onSecondaryTapUp], which exposes this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapUpCallback OnSecondaryTapUp { get; set; }
        /// <Summary>
        /// A pointer that previously triggered [onSecondaryTapDown] will not end up
        /// causing a tap.
        ///
        /// This triggers once the gesture loses the arena, if [onSecondaryTapDown]
        /// has previously been triggered.
        ///
        /// If this recognizer wins the arena, [onSecondaryTapUp] is called instead.
        ///
        /// See also:
        ///
        ///  * [kSecondaryButton], the button this callback responds to.
        ///  * [onTapCancel], a similar callback but for a primary button.
        ///  * [GestureDetector.onTapCancel], which exposes this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapCancelCallback OnSecondaryTapCancel { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            switch (@event.Buttons) { case EventsDefaultClass.KPrimaryButton: if (OnTapDown == null && OnTap == null && OnTapUp == null && OnTapCancel == null) return false; break; case EventsDefaultClass.KSecondaryButton: if (OnSecondaryTapDown == null && OnSecondaryTapUp == null && OnSecondaryTapCancel == null) return false; break; default: return false; }
            return base.IsPointerAllowed(@event);
        }




        public new void HandleTapDown(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent))
        {
            TapDownDetails details = new TapDownDetails(globalPosition: down.Position, localPosition: down.LocalPosition, kind: GetKindForPointer(down.Pointer));
            switch (down.Buttons) { case EventsDefaultClass.KPrimaryButton: if (OnTapDown != null) InvokeCallback("onTapDown", () => =>OnTapDown(details)); break; case EventsDefaultClass.KSecondaryButton: if (OnSecondaryTapDown != null) InvokeCallback("onSecondaryTapDown", () => =>OnSecondaryTapDown(details)); break; default: }
        }




        public new void HandleTapUp(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent), FlutterSDK.Gestures.Events.PointerUpEvent up = default(FlutterSDK.Gestures.Events.PointerUpEvent))
        {
            TapUpDetails details = new TapUpDetails(globalPosition: up.Position, localPosition: up.LocalPosition);
            switch (down.Buttons) { case EventsDefaultClass.KPrimaryButton: if (OnTapUp != null) InvokeCallback("onTapUp", () => =>OnTapUp(details)); if (OnTap != null) InvokeCallback("onTap", OnTap); break; case EventsDefaultClass.KSecondaryButton: if (OnSecondaryTapUp != null) InvokeCallback("onSecondaryTapUp", () => =>OnSecondaryTapUp(details)); break; default: }
        }




        public new void HandleTapCancel(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent), FlutterSDK.Gestures.Events.PointerCancelEvent cancel = default(FlutterSDK.Gestures.Events.PointerCancelEvent), string reason = default(string))
        {
            string note = reason == "" ? reason : $"'{reason} '";
            switch (down.Buttons) { case EventsDefaultClass.KPrimaryButton: if (OnTapCancel != null) InvokeCallback($"'{note}onTapCancel'", OnTapCancel); break; case EventsDefaultClass.KSecondaryButton: if (OnSecondaryTapCancel != null) InvokeCallback($"'{note}onSecondaryTapCancel'", OnSecondaryTapCancel); break; default: }
        }



    }

}
