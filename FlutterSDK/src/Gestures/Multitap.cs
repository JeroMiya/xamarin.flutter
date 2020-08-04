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
namespace FlutterSDK.Gestures.Multitap
{
    /// <Summary>
    /// Signature for callback when the user has tapped the screen at the same
    /// location twice in quick succession.
    ///
    /// See also:
    ///
    ///  * [GestureDetector.onDoubleTap], which matches this signature.
    /// </Summary>
    public delegate void GestureDoubleTapCallback();
    /// <Summary>
    /// Signature used by [MultiTapGestureRecognizer] for when a pointer that might
    /// cause a tap has contacted the screen at a particular location.
    /// </Summary>
    public delegate void GestureMultiTapDownCallback(int pointer, FlutterSDK.Gestures.Tap.TapDownDetails details);
    /// <Summary>
    /// Signature used by [MultiTapGestureRecognizer] for when a pointer that will
    /// trigger a tap has stopped contacting the screen at a particular location.
    /// </Summary>
    public delegate void GestureMultiTapUpCallback(int pointer, FlutterSDK.Gestures.Tap.TapUpDetails details);
    /// <Summary>
    /// Signature used by [MultiTapGestureRecognizer] for when a tap has occurred.
    /// </Summary>
    public delegate void GestureMultiTapCallback(int pointer);
    /// <Summary>
    /// Signature for when the pointer that previously triggered a
    /// [GestureMultiTapDownCallback] will not end up causing a tap.
    /// </Summary>
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
        public _CountdownZoned(TimeSpan duration = default(TimeSpan))
        : base()
        {

            new Timer(duration, _OnTimeout);
        }


        internal virtual bool _Timeout { get; set; }
        public virtual bool Timeout { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _OnTimeout()
        {
            _Timeout = true;
        }



    }


    /// <Summary>
    /// TapTracker helps track individual tap sequences as part of a
    /// larger gesture.
    /// </Summary>
    public class _TapTracker
    {
        public _TapTracker(FlutterSDK.Gestures.Events.PointerDownEvent @event = default(FlutterSDK.Gestures.Events.PointerDownEvent), FlutterSDK.Gestures.Arena.GestureArenaEntry entry = default(FlutterSDK.Gestures.Arena.GestureArenaEntry), TimeSpan doubleTapMinTime = default(TimeSpan))
        : base()
        {
            this.Entry = entry;
        }
        public virtual int Pointer { get; set; }
        public virtual FlutterSDK.Gestures.Arena.GestureArenaEntry Entry { get; set; }
        internal virtual FlutterBinding.UI.Offset _InitialGlobalPosition { get; set; }
        public virtual int InitialButtons { get; set; }
        internal virtual FlutterSDK.Gestures.Multitap._CountdownZoned _DoubleTapMinTimeCountdown { get; set; }
        internal virtual bool _IsTrackingPointer { get; set; }

        public virtual void StartTrackingPointer(FlutterSDK.Gestures.Pointerrouter.PointerRoute route, Matrix4 transform)
        {
            if (!_IsTrackingPointer)
            {
                _IsTrackingPointer = true;
                BindingDefaultClass.GestureBinding.Instance.PointerRouter.AddRoute(Pointer, route, transform);
            }

        }




        public virtual void StopTrackingPointer(FlutterSDK.Gestures.Pointerrouter.PointerRoute route)
        {
            if (_IsTrackingPointer)
            {
                _IsTrackingPointer = false;
                BindingDefaultClass.GestureBinding.Instance.PointerRouter.RemoveRoute(Pointer, route);
            }

        }




        public virtual bool IsWithinGlobalTolerance(FlutterSDK.Gestures.Events.PointerEvent @event, double tolerance)
        {
            Offset offset = @event.Position - _InitialGlobalPosition;
            return offset.Distance <= tolerance;
        }




        public virtual bool HasElapsedMinTime()
        {
            return _DoubleTapMinTimeCountdown.Timeout;
        }




        public virtual bool HasSameButton(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            return @event.Buttons == InitialButtons;
        }



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
        /// <Summary>
        /// Create a gesture recognizer for double taps.
        ///
        /// {@macro flutter.gestures.gestureRecognizer.kind}
        /// </Summary>
        public DoubleTapGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {

        }
        /// <Summary>
        /// Called when the user has tapped the screen with a primary button at the
        /// same location twice in quick succession.
        ///
        /// This triggers when the pointer stops contacting the device after the
        /// second tap.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Multitap.GestureDoubleTapCallback OnDoubleTap { get; set; }
        internal virtual Timer _DoubleTapTimer { get; set; }
        internal virtual FlutterSDK.Gestures.Multitap._TapTracker _FirstTap { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Gestures.Multitap._TapTracker> _Trackers { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            if (_FirstTap == null)
            {
                switch (@event.Buttons) { case EventsDefaultClass.KPrimaryButton: if (OnDoubleTap == null) return false; break; default: return false; }
            }

            return base.IsPointerAllowed(@event as PointerDownEvent);
        }




        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            if (_FirstTap != null)
            {
                if (!_FirstTap.IsWithinGlobalTolerance(@event, ConstantsDefaultClass.KDoubleTapSlop))
                {
                    return;
                }
                else if (!_FirstTap.HasElapsedMinTime() || !_FirstTap.HasSameButton(@event as PointerDownEvent))
                {
                    _Reset();
                    return _TrackFirstTap(@event);
                }

            }

            _TrackFirstTap(@event);
        }




        private void _TrackFirstTap(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            _StopDoubleTapTimer();
            _TapTracker tracker = new _TapTracker(@event: @event as PointerDownEvent, entry: BindingDefaultClass.GestureBinding.Instance.GestureArena.Add(@event.Pointer, this), doubleTapMinTime: ConstantsDefaultClass.KDoubleTapMinTime);
            _Trackers[@event.Pointer] = tracker;
            tracker.StartTrackingPointer(_HandleEvent, @event.Transform);
        }




        private void _HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            _TapTracker tracker = _Trackers[@event.Pointer];

            if (@event is PointerUpEvent)
            {
                if (_FirstTap == null) _RegisterFirstTap(tracker); else _RegisterSecondTap(tracker);
            }
            else if (@event is PointerMoveEvent)
            {
                if (!tracker.IsWithinGlobalTolerance(((PointerMoveEvent)@event), ConstantsDefaultClass.KDoubleTapTouchSlop)) _Reject(tracker);
            }
            else if (@event is PointerCancelEvent)
            {
                _Reject(tracker);
            }

        }




        public new void AcceptGesture(int pointer)
        {
        }




        public new void RejectGesture(int pointer)
        {
            _TapTracker tracker = _Trackers[pointer];
            if (tracker == null && _FirstTap != null && _FirstTap.Pointer == pointer) tracker = _FirstTap;
            if (tracker != null) _Reject(tracker);
        }




        private void _Reject(FlutterSDK.Gestures.Multitap._TapTracker tracker)
        {
            _Trackers.Remove(tracker.Pointer);
            tracker.Entry.Resolve(GestureDisposition.Rejected);
            _FreezeTracker(tracker);
            if (_FirstTap != null && (_Trackers.IsEmpty() || tracker == _FirstTap)) _Reset();
        }




        public new void Dispose()
        {
            _Reset();
            base.Dispose();
        }




        private void _Reset()
        {
            _StopDoubleTapTimer();
            if (_FirstTap != null)
            {
                _TapTracker tracker = _FirstTap;
                _FirstTap = null;
                _Reject(tracker);
                BindingDefaultClass.GestureBinding.Instance.GestureArena.Release(tracker.Pointer);
            }

            _ClearTrackers();
        }




        private void _RegisterFirstTap(FlutterSDK.Gestures.Multitap._TapTracker tracker)
        {
            _StartDoubleTapTimer();
            BindingDefaultClass.GestureBinding.Instance.GestureArena.Hold(tracker.Pointer);
            _FreezeTracker(tracker);
            _Trackers.Remove(tracker.Pointer);
            _ClearTrackers();
            _FirstTap = tracker;
        }




        private void _RegisterSecondTap(FlutterSDK.Gestures.Multitap._TapTracker tracker)
        {
            _FirstTap.Entry.Resolve(GestureDisposition.Accepted);
            tracker.Entry.Resolve(GestureDisposition.Accepted);
            _FreezeTracker(tracker);
            _Trackers.Remove(tracker.Pointer);
            _CheckUp(tracker.InitialButtons);
            _Reset();
        }




        private void _ClearTrackers()
        {
            _Trackers.Values.ToList().ForEach(_Reject);

        }




        private void _FreezeTracker(FlutterSDK.Gestures.Multitap._TapTracker tracker)
        {
            tracker.StopTrackingPointer(_HandleEvent);
        }




        private void _StartDoubleTapTimer()
        {
            _DoubleTapTimer = (_DoubleTapTimer == null ? new Timer(ConstantsDefaultClass.KDoubleTapTimeout, _Reset) : _DoubleTapTimer);
        }




        private void _StopDoubleTapTimer()
        {
            if (_DoubleTapTimer != null)
            {
                _DoubleTapTimer.Cancel();
                _DoubleTapTimer = null;
            }

        }




        private void _CheckUp(int buttons)
        {

            if (OnDoubleTap != null) InvokeCallback("onDoubleTap", OnDoubleTap);
        }



    }


    /// <Summary>
    /// TapGesture represents a full gesture resulting from a single tap sequence,
    /// as part of a [MultiTapGestureRecognizer]. Tap gestures are passive, meaning
    /// that they will not preempt any other arena member in play.
    /// </Summary>
    public class _TapGesture : FlutterSDK.Gestures.Multitap._TapTracker
    {
        public _TapGesture(FlutterSDK.Gestures.Multitap.MultiTapGestureRecognizer gestureRecognizer = default(FlutterSDK.Gestures.Multitap.MultiTapGestureRecognizer), FlutterSDK.Gestures.Events.PointerEvent @event = default(FlutterSDK.Gestures.Events.PointerEvent), TimeSpan longTapDelay = default(TimeSpan))
        : base(@event: @event as PointerDownEvent, entry: BindingDefaultClass.GestureBinding.Instance.GestureArena.Add(@event.Pointer, gestureRecognizer), doubleTapMinTime: ConstantsDefaultClass.KDoubleTapMinTime)
        {
            this.GestureRecognizer = gestureRecognizer;
            StartTrackingPointer(HandleEvent, @event.Transform);
            if (longTapDelay > Dart.CoreDefaultClass.Duration.Zero)
            {
                _Timer = new Timer(longTapDelay, () =>
                {
                    _Timer = null;
                    GestureRecognizer._DispatchLongTap(@event.Pointer, _LastPosition);
                }
                );
            }

        }


        public virtual FlutterSDK.Gestures.Multitap.MultiTapGestureRecognizer GestureRecognizer { get; set; }
        internal virtual bool _WonArena { get; set; }
        internal virtual Timer _Timer { get; set; }
        internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _LastPosition { get; set; }
        internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _FinalPosition { get; set; }

        public virtual void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {

            if (@event is PointerMoveEvent)
            {
                if (!IsWithinGlobalTolerance(((PointerMoveEvent)@event), ConstantsDefaultClass.KTouchSlop)) Cancel(); else _LastPosition = OffsetPair.FromEventPosition(((PointerMoveEvent)@event));
            }
            else if (@event is PointerCancelEvent)
            {
                Cancel();
            }
            else if (@event is PointerUpEvent)
            {
                StopTrackingPointer(HandleEvent);
                _FinalPosition = OffsetPair.FromEventPosition(((PointerUpEvent)@event));
                _Check();
            }

        }




        public new void StopTrackingPointer(FlutterSDK.Gestures.Pointerrouter.PointerRoute route)
        {
            _Timer?.Cancel();
            _Timer = null;
            base.StopTrackingPointer(route);
        }




        public virtual void Accept()
        {
            _WonArena = true;
            _Check();
        }




        public virtual void Reject()
        {
            StopTrackingPointer(HandleEvent);
            GestureRecognizer._DispatchCancel(Pointer);
        }




        public virtual void Cancel()
        {
            if (_WonArena) Reject(); else Entry.Resolve(GestureDisposition.Rejected);
        }




        private void _Check()
        {
            if (_WonArena && _FinalPosition != null) GestureRecognizer._DispatchTap(Pointer, _FinalPosition);
        }



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
        /// <Summary>
        /// Creates a multi-tap gesture recognizer.
        ///
        /// The [longTapDelay] defaults to [Duration.zero], which means
        /// [onLongTapDown] is called immediately after [onTapDown].
        /// </Summary>
        public MultiTapGestureRecognizer(TimeSpan longTapDelay = default(TimeSpan), @Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {
            this.LongTapDelay = longTapDelay;
        }
        /// <Summary>
        /// A pointer that might cause a tap has contacted the screen at a particular
        /// location.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Multitap.GestureMultiTapDownCallback OnTapDown { get; set; }
        /// <Summary>
        /// A pointer that will trigger a tap has stopped contacting the screen at a
        /// particular location.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Multitap.GestureMultiTapUpCallback OnTapUp { get; set; }
        /// <Summary>
        /// A tap has occurred.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Multitap.GestureMultiTapCallback OnTap { get; set; }
        /// <Summary>
        /// The pointer that previously triggered [onTapDown] will not end up causing
        /// a tap.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Multitap.GestureMultiTapCancelCallback OnTapCancel { get; set; }
        /// <Summary>
        /// The amount of time between [onTapDown] and [onLongTapDown].
        /// </Summary>
        public virtual TimeSpan LongTapDelay { get; set; }
        /// <Summary>
        /// A pointer that might cause a tap is still in contact with the screen at a
        /// particular location after [longTapDelay].
        /// </Summary>
        public virtual FlutterSDK.Gestures.Multitap.GestureMultiTapDownCallback OnLongTapDown { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Gestures.Multitap._TapGesture> _GestureMap { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerEvent @event)
        {

            _GestureMap[@event.Pointer] = new _TapGesture(gestureRecognizer: this, @event: @event, longTapDelay: LongTapDelay);
            if (OnTapDown != null) InvokeCallback("onTapDown", () =>
            {
                OnTapDown(@event.Pointer, new TapDownDetails(globalPosition: @event.Position, localPosition: @event.LocalPosition, kind: @event.Kind));
            }
              );
        }




        public new void AcceptGesture(int pointer)
        {

            _GestureMap[pointer].Accept();
        }




        public new void RejectGesture(int pointer)
        {

            _GestureMap[pointer].Reject();

        }




        private void _DispatchCancel(int pointer)
        {

            _GestureMap.Remove(pointer);
            if (OnTapCancel != null) InvokeCallback("onTapCancel", () => =>OnTapCancel(pointer));
        }




        private void _DispatchTap(int pointer, FlutterSDK.Gestures.Recognizer.OffsetPair position)
        {

            _GestureMap.Remove(pointer);
            if (OnTapUp != null) InvokeCallback("onTapUp", () =>
            {
                OnTapUp(pointer, new TapUpDetails(localPosition: position.Local, globalPosition: position.Global));
            }
              );
            if (OnTap != null) InvokeCallback("onTap", () => =>OnTap(pointer));
        }




        private void _DispatchLongTap(int pointer, FlutterSDK.Gestures.Recognizer.OffsetPair lastPosition)
        {

            if (OnLongTapDown != null) InvokeCallback("onLongTapDown", () =>
            {
                OnLongTapDown(pointer, new TapDownDetails(globalPosition: lastPosition.Global, localPosition: lastPosition.Local, kind: GetKindForPointer(pointer)));
            }
              );
        }




        public new void Dispose()
        {
            List<_TapGesture> localGestures = List<_TapGesture>.From(_GestureMap.Values);
            foreach (_TapGesture gesture in localGestures) gesture.Cancel();

            base.Dispose();
        }



    }

}
