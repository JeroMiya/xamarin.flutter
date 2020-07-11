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
namespace FlutterSDK.Gestures.Multitap
{
    public delegate void GestureDoubleTapCallback();
    public delegate void GestureMultiTapDownCallback(int pointer, FlutterSDK.Gestures.Tap.TapDownDetails details);
    public delegate void GestureMultiTapUpCallback(int pointer, FlutterSDK.Gestures.Tap.TapUpDetails details);
    public delegate void GestureMultiTapCallback(int pointer);
    public delegate void GestureMultiTapCancelCallback(int pointer);
    internal static class MultitapDefaultClass
    {
    }

    /// <Summary>
    /// CountdownZoned tracks whether the specified duration has elapsed since
    /// creation, honoring [Zone].
    /// </Summary>
    public class _CountdownZoned
    {
        #region constructors
        public _CountdownZoned(TimeSpan duration = default(TimeSpan))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual bool _Timeout { get; set; }
        public virtual bool Timeout { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _OnTimeout() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// TapTracker helps track individual tap sequences as part of a
    /// larger gesture.
    /// </Summary>
    public class _TapTracker
    {
        #region constructors
        public _TapTracker(FlutterSDK.Gestures.Events.PointerDownEvent @event = default(FlutterSDK.Gestures.Events.PointerDownEvent), FlutterSDK.Gestures.Arena.GestureArenaEntry entry = default(FlutterSDK.Gestures.Arena.GestureArenaEntry), TimeSpan doubleTapMinTime = default(TimeSpan))
        : base()
        {
            this.Entry = entry; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int Pointer { get; set; }
        public virtual FlutterSDK.Gestures.Arena.GestureArenaEntry Entry { get; set; }
        internal virtual FlutterBinding.UI.Offset _InitialGlobalPosition { get; set; }
        public virtual int InitialButtons { get; set; }
        internal virtual FlutterSDK.Gestures.Multitap._CountdownZoned _DoubleTapMinTimeCountdown { get; set; }
        internal virtual bool _IsTrackingPointer { get; set; }
        #endregion

        #region methods

        public virtual void StartTrackingPointer(FlutterSDK.Gestures.Pointerrouter.PointerRoute route, Matrix4 transform) { throw new NotImplementedException(); }


        public virtual void StopTrackingPointer(FlutterSDK.Gestures.Pointerrouter.PointerRoute route) { throw new NotImplementedException(); }


        public virtual bool IsWithinGlobalTolerance(FlutterSDK.Gestures.Events.PointerEvent @event, double tolerance) { throw new NotImplementedException(); }


        public virtual bool HasElapsedMinTime() { throw new NotImplementedException(); }


        public virtual bool HasSameButton(FlutterSDK.Gestures.Events.PointerDownEvent @event) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Recognizes when the user has tapped the screen at the same location twice in
    /// quick succession.
    ///
    /// [DoubleTapGestureRecognizer] competes on pointer events of [kPrimaryButton]
    /// only when it has a non-null callback. If it has no callbacks, it is a no-op.
    ///
    /// </Summary>
    public class DoubleTapGestureRecognizer : FlutterSDK.Gestures.Recognizer.GestureRecognizer
    {
        #region constructors
        public DoubleTapGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Gestures.Multitap.GestureDoubleTapCallback OnDoubleTap { get; set; }
        internal virtual Timer _DoubleTapTimer { get; set; }
        internal virtual FlutterSDK.Gestures.Multitap._TapTracker _FirstTap { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Gestures.Multitap._TapTracker> _Trackers { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        private void _TrackFirstTap(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        private void _HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public new void AcceptGesture(int pointer) { throw new NotImplementedException(); }


        public new void RejectGesture(int pointer) { throw new NotImplementedException(); }


        private void _Reject(FlutterSDK.Gestures.Multitap._TapTracker tracker) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _Reset() { throw new NotImplementedException(); }


        private void _RegisterFirstTap(FlutterSDK.Gestures.Multitap._TapTracker tracker) { throw new NotImplementedException(); }


        private void _RegisterSecondTap(FlutterSDK.Gestures.Multitap._TapTracker tracker) { throw new NotImplementedException(); }


        private void _ClearTrackers() { throw new NotImplementedException(); }


        private void _FreezeTracker(FlutterSDK.Gestures.Multitap._TapTracker tracker) { throw new NotImplementedException(); }


        private void _StartDoubleTapTimer() { throw new NotImplementedException(); }


        private void _StopDoubleTapTimer() { throw new NotImplementedException(); }


        private void _CheckUp(int buttons) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// TapGesture represents a full gesture resulting from a single tap sequence,
    /// as part of a [MultiTapGestureRecognizer]. Tap gestures are passive, meaning
    /// that they will not preempt any other arena member in play.
    /// </Summary>
    public class _TapGesture : FlutterSDK.Gestures.Multitap._TapTracker
    {
        #region constructors
        public _TapGesture(FlutterSDK.Gestures.Multitap.MultiTapGestureRecognizer gestureRecognizer = default(FlutterSDK.Gestures.Multitap.MultiTapGestureRecognizer), FlutterSDK.Gestures.Events.PointerEvent @event = default(FlutterSDK.Gestures.Events.PointerEvent), TimeSpan longTapDelay = default(TimeSpan))
        : base(@event: @event as PointerDownEvent, entry: BindingDefaultClass.GestureBinding.Instance.GestureArena.Add(@event.Pointer, gestureRecognizer), doubleTapMinTime: ConstantsDefaultClass.KDoubleTapMinTime)
        {
            this.GestureRecognizer = gestureRecognizer; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Gestures.Multitap.MultiTapGestureRecognizer GestureRecognizer { get; set; }
        internal virtual bool _WonArena { get; set; }
        internal virtual Timer _Timer { get; set; }
        internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _LastPosition { get; set; }
        internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _FinalPosition { get; set; }
        #endregion

        #region methods

        public virtual void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public new void StopTrackingPointer(FlutterSDK.Gestures.Pointerrouter.PointerRoute route) { throw new NotImplementedException(); }


        public virtual void Accept() { throw new NotImplementedException(); }


        public virtual void Reject() { throw new NotImplementedException(); }


        public virtual void Cancel() { throw new NotImplementedException(); }


        private void _Check() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Recognizes taps on a per-pointer basis.
    ///
    /// [MultiTapGestureRecognizer] considers each sequence of pointer events that
    /// could constitute a tap independently of other pointers: For example, down-1,
    /// down-2, up-1, up-2 produces two taps, on up-1 and up-2.
    ///
    /// See also:
    ///
    ///  * [TapGestureRecognizer]
    /// </Summary>
    public class MultiTapGestureRecognizer : FlutterSDK.Gestures.Recognizer.GestureRecognizer
    {
        #region constructors
        public MultiTapGestureRecognizer(TimeSpan longTapDelay = default(TimeSpan), @Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {
            this.LongTapDelay = longTapDelay; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Gestures.Multitap.GestureMultiTapDownCallback OnTapDown { get; set; }
        public virtual FlutterSDK.Gestures.Multitap.GestureMultiTapUpCallback OnTapUp { get; set; }
        public virtual FlutterSDK.Gestures.Multitap.GestureMultiTapCallback OnTap { get; set; }
        public virtual FlutterSDK.Gestures.Multitap.GestureMultiTapCancelCallback OnTapCancel { get; set; }
        public virtual TimeSpan LongTapDelay { get; set; }
        public virtual FlutterSDK.Gestures.Multitap.GestureMultiTapDownCallback OnLongTapDown { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Gestures.Multitap._TapGesture> _GestureMap { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerEvent @event) { throw new NotImplementedException(); }


        public new void AcceptGesture(int pointer) { throw new NotImplementedException(); }


        public new void RejectGesture(int pointer) { throw new NotImplementedException(); }


        private void _DispatchCancel(int pointer) { throw new NotImplementedException(); }


        private void _DispatchTap(int pointer, FlutterSDK.Gestures.Recognizer.OffsetPair position) { throw new NotImplementedException(); }


        private void _DispatchLongTap(int pointer, FlutterSDK.Gestures.Recognizer.OffsetPair lastPosition) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }

        #endregion
    }

}
