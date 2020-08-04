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
namespace FlutterSDK.Gestures.Multidrag
{
    /// <Summary>
    /// Signature for when [MultiDragGestureRecognizer] recognizes the start of a drag gesture.
    /// </Summary>
    public delegate FlutterSDK.Gestures.Drag.Drag GestureMultiDragStartCallback(FlutterBinding.UI.Offset position);
    internal static class MultidragDefaultClass
    {
    }

    /// <Summary>
    /// Per-pointer state for a [MultiDragGestureRecognizer].
    ///
    /// A [MultiDragGestureRecognizer] tracks each pointer separately. The state for
    /// each pointer is a subclass of [MultiDragPointerState].
    /// </Summary>
    public interface IMultiDragPointerState
    {
        void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition);
        void CheckForResolutionAfterMove();
        void Accepted(FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback starter);
        void Rejected();
        void Dispose();
        FlutterBinding.UI.Offset InitialPosition { get; }
        FlutterBinding.UI.Offset PendingDelta { get; }
    }


    /// <Summary>
    /// Recognizes movement on a per-pointer basis.
    ///
    /// In contrast to [DragGestureRecognizer], [MultiDragGestureRecognizer] watches
    /// each pointer separately, which means multiple drags can be recognized
    /// concurrently if multiple pointers are in contact with the screen.
    ///
    /// [MultiDragGestureRecognizer] is not intended to be used directly. Instead,
    /// consider using one of its subclasses to recognize specific types for drag
    /// gestures.
    ///
    /// See also:
    ///
    ///  * [ImmediateMultiDragGestureRecognizer], the most straight-forward variant
    ///    of multi-pointer drag gesture recognizer.
    ///  * [HorizontalMultiDragGestureRecognizer], which only recognizes drags that
    ///    start horizontally.
    ///  * [VerticalMultiDragGestureRecognizer], which only recognizes drags that
    ///    start vertically.
    ///  * [DelayedMultiDragGestureRecognizer], which only recognizes drags that
    ///    start after a long-press gesture.
    /// </Summary>
    public interface IMultiDragGestureRecognizer<T>
    {
        void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
        T CreateNewPointerState(FlutterSDK.Gestures.Events.PointerDownEvent @event);
        void AcceptGesture(int pointer);
        void RejectGesture(int pointer);
        void Dispose();
        FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback OnStart { get; set; }
    }


    /// <Summary>
    /// Per-pointer state for a [MultiDragGestureRecognizer].
    ///
    /// A [MultiDragGestureRecognizer] tracks each pointer separately. The state for
    /// each pointer is a subclass of [MultiDragPointerState].
    /// </Summary>
    public class MultiDragPointerState
    {
        /// <Summary>
        /// Creates per-pointer state for a [MultiDragGestureRecognizer].
        ///
        /// The [initialPosition] argument must not be null.
        /// </Summary>
        public MultiDragPointerState(FlutterBinding.UI.Offset initialPosition)
        : base()
        {
            this.InitialPosition = initialPosition;
        }
        /// <Summary>
        /// The global coordinates of the pointer when the pointer contacted the screen.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset InitialPosition { get; set; }
        internal virtual FlutterSDK.Gestures.Velocitytracker.VelocityTracker _VelocityTracker { get; set; }
        internal virtual FlutterSDK.Gestures.Drag.Drag _Client { get; set; }
        internal virtual FlutterBinding.UI.Offset _PendingDelta { get; set; }
        internal virtual TimeSpan _LastPendingEventTimestamp { get; set; }
        internal virtual FlutterSDK.Gestures.Arena.GestureArenaEntry _ArenaEntry { get; set; }
        public virtual FlutterBinding.UI.Offset PendingDelta { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _SetArenaEntry(FlutterSDK.Gestures.Arena.GestureArenaEntry entry)
        {



            _ArenaEntry = entry;
        }




        /// <Summary>
        /// Resolve this pointer's entry in the [GestureArenaManager] with the given disposition.
        /// </Summary>
        public virtual void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition)
        {
            _ArenaEntry.Resolve(disposition);
        }




        private void _Move(FlutterSDK.Gestures.Events.PointerMoveEvent @event)
        {

            if (!@event.Synthesized) _VelocityTracker.AddPosition(@event.TimeStamp, @event.Position);
            if (_Client != null)
            {

                _Client.Update(new DragUpdateDetails(sourceTimeStamp: @event.TimeStamp, delta: @event.Delta, globalPosition: @event.Position));
            }
            else
            {

                _PendingDelta += @event.Delta;
                _LastPendingEventTimestamp = @event.TimeStamp;
                CheckForResolutionAfterMove();
            }

        }




        /// <Summary>
        /// Override this to call resolve() if the drag should be accepted or rejected.
        /// This is called when a pointer movement is received, but only if the gesture
        /// has not yet been resolved.
        /// </Summary>
        public virtual void CheckForResolutionAfterMove()
        {
        }




        /// <Summary>
        /// Called when the gesture was accepted.
        ///
        /// Either immediately or at some future point before the gesture is disposed,
        /// call starter(), passing it initialPosition, to start the drag.
        /// </Summary>
        public virtual void Accepted(FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback starter)
        {
        }


        /// <Summary>
        /// Called when the gesture was rejected.
        ///
        /// The [dispose] method will be called immediately following this.
        /// </Summary>
        public virtual void Rejected()
        {



            _PendingDelta = null;
            _LastPendingEventTimestamp = null;
            _ArenaEntry = null;
        }




        private void _StartDrag(FlutterSDK.Gestures.Drag.Drag client)
        {




            _Client = client;
            DragUpdateDetails details = new DragUpdateDetails(sourceTimeStamp: _LastPendingEventTimestamp, delta: PendingDelta, globalPosition: InitialPosition);
            _PendingDelta = null;
            _LastPendingEventTimestamp = null;
            _Client.Update(details);
        }




        private void _Up()
        {

            if (_Client != null)
            {

                DragEndDetails details = new DragEndDetails(velocity: _VelocityTracker.GetVelocity());
                Drag client = _Client;
                _Client = null;
                client.End(details);
            }
            else
            {

                _PendingDelta = null;
                _LastPendingEventTimestamp = null;
            }

        }




        private void _Cancel()
        {

            if (_Client != null)
            {

                Drag client = _Client;
                _Client = null;
                client.Cancel();
            }
            else
            {

                _PendingDelta = null;
                _LastPendingEventTimestamp = null;
            }

        }




        /// <Summary>
        /// Releases any resources used by the object.
        /// </Summary>
        public virtual void Dispose()
        {
            _ArenaEntry?.Resolve(GestureDisposition.Rejected);
            _ArenaEntry = null;

        }



    }


    /// <Summary>
    /// Recognizes movement on a per-pointer basis.
    ///
    /// In contrast to [DragGestureRecognizer], [MultiDragGestureRecognizer] watches
    /// each pointer separately, which means multiple drags can be recognized
    /// concurrently if multiple pointers are in contact with the screen.
    ///
    /// [MultiDragGestureRecognizer] is not intended to be used directly. Instead,
    /// consider using one of its subclasses to recognize specific types for drag
    /// gestures.
    ///
    /// See also:
    ///
    ///  * [ImmediateMultiDragGestureRecognizer], the most straight-forward variant
    ///    of multi-pointer drag gesture recognizer.
    ///  * [HorizontalMultiDragGestureRecognizer], which only recognizes drags that
    ///    start horizontally.
    ///  * [VerticalMultiDragGestureRecognizer], which only recognizes drags that
    ///    start vertically.
    ///  * [DelayedMultiDragGestureRecognizer], which only recognizes drags that
    ///    start after a long-press gesture.
    /// </Summary>
    public class MultiDragGestureRecognizer<T> : FlutterSDK.Gestures.Recognizer.GestureRecognizer
    {
        /// <Summary>
        /// Initialize the object.
        /// </Summary>
        public MultiDragGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {

        }
        /// <Summary>
        /// Called when this class recognizes the start of a drag gesture.
        ///
        /// The remaining notifications for this drag gesture are delivered to the
        /// [Drag] object returned by this callback.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback OnStart { get; set; }
        internal virtual Dictionary<int, T> _Pointers { get; set; }

        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {




            T state = CreateNewPointerState(@event);
            _Pointers[@event.Pointer] = state;
            BindingDefaultClass.GestureBinding.Instance.PointerRouter.AddRoute(@event.Pointer, _HandleEvent);
            state._SetArenaEntry(BindingDefaultClass.GestureBinding.Instance.GestureArena.Add(@event.Pointer, this));
        }




        /// <Summary>
        /// Subclasses should override this method to create per-pointer state
        /// objects to track the pointer associated with the given event.
        /// </Summary>
        public virtual T CreateNewPointerState(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            return default(T);
        }


        private void _HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {





            T state = _Pointers[@event.Pointer];
            if (@event is PointerMoveEvent)
            {
                state._Move(((PointerMoveEvent)@event));
            }
            else if (@event is PointerUpEvent)
            {

                state._Up();
                _RemoveState(((PointerUpEvent)@event).Pointer);
            }
            else if (@event is PointerCancelEvent)
            {

                state._Cancel();
                _RemoveState(((PointerCancelEvent)@event).Pointer);
            }
            else if (!(@event is PointerDownEvent))
            {

            }

        }




        public new void AcceptGesture(int pointer)
        {

            T state = _Pointers[pointer];
            if (state == null) return;
            state.Accepted((Offset initialPosition) => =>_StartDrag(initialPosition, pointer));
        }




        private FlutterSDK.Gestures.Drag.Drag _StartDrag(FlutterBinding.UI.Offset initialPosition, int pointer)
        {

            T state = _Pointers[pointer];


            Drag drag = default(Drag);
            if (OnStart != null) drag = InvokeCallback("onStart", () => =>OnStart(initialPosition));
            if (drag != null)
            {
                state._StartDrag(drag);
            }
            else
            {
                _RemoveState(pointer);
            }

            return drag;
        }




        public new void RejectGesture(int pointer)
        {

            if (_Pointers.ContainsKey(pointer))
            {
                T state = _Pointers[pointer];

                state.Rejected();
                _RemoveState(pointer);
            }

        }




        private void _RemoveState(int pointer)
        {
            if (_Pointers == null)
            {
                return;
            }


            BindingDefaultClass.GestureBinding.Instance.PointerRouter.RemoveRoute(pointer, _HandleEvent);
            _Pointers.Remove(pointer).Dispose();
        }




        public new void Dispose()
        {
            _Pointers.Keys.ToList().ForEach(_RemoveState);

            _Pointers = null;
            base.Dispose();
        }



    }


    public class _ImmediatePointerState : FlutterSDK.Gestures.Multidrag.MultiDragPointerState
    {
        public _ImmediatePointerState(FlutterBinding.UI.Offset initialPosition)
        : base(initialPosition)
        {

        }

        public new void CheckForResolutionAfterMove()
        {

            if (PendingDelta.Distance > ConstantsDefaultClass.KTouchSlop) Resolve(GestureDisposition.Accepted);
        }




        public new void Accepted(FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback starter)
        {
            starter(InitialPosition);
        }



    }


    /// <Summary>
    /// Recognizes movement both horizontally and vertically on a per-pointer basis.
    ///
    /// In contrast to [PanGestureRecognizer], [ImmediateMultiDragGestureRecognizer]
    /// watches each pointer separately, which means multiple drags can be
    /// recognized concurrently if multiple pointers are in contact with the screen.
    ///
    /// See also:
    ///
    ///  * [PanGestureRecognizer], which recognizes only one drag gesture at a time,
    ///    regardless of how many fingers are involved.
    ///  * [HorizontalMultiDragGestureRecognizer], which only recognizes drags that
    ///    start horizontally.
    ///  * [VerticalMultiDragGestureRecognizer], which only recognizes drags that
    ///    start vertically.
    ///  * [DelayedMultiDragGestureRecognizer], which only recognizes drags that
    ///    start after a long-press gesture.
    /// </Summary>
    public class ImmediateMultiDragGestureRecognizer : FlutterSDK.Gestures.Multidrag.MultiDragGestureRecognizer<FlutterSDK.Gestures.Multidrag._ImmediatePointerState>
    {
        /// <Summary>
        /// Create a gesture recognizer for tracking multiple pointers at once.
        /// </Summary>
        public ImmediateMultiDragGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {

        }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Gestures.Multidrag._ImmediatePointerState CreateNewPointerState(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            return new _ImmediatePointerState(@event.Position);
        }



    }


    public class _HorizontalPointerState : FlutterSDK.Gestures.Multidrag.MultiDragPointerState
    {
        public _HorizontalPointerState(FlutterBinding.UI.Offset initialPosition)
        : base(initialPosition)
        {

        }

        public new void CheckForResolutionAfterMove()
        {

            if (PendingDelta.Dx.Abs() > ConstantsDefaultClass.KTouchSlop) Resolve(GestureDisposition.Accepted);
        }




        public new void Accepted(FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback starter)
        {
            starter(InitialPosition);
        }



    }


    /// <Summary>
    /// Recognizes movement in the horizontal direction on a per-pointer basis.
    ///
    /// In contrast to [HorizontalDragGestureRecognizer],
    /// [HorizontalMultiDragGestureRecognizer] watches each pointer separately,
    /// which means multiple drags can be recognized concurrently if multiple
    /// pointers are in contact with the screen.
    ///
    /// See also:
    ///
    ///  * [HorizontalDragGestureRecognizer], a gesture recognizer that just
    ///    looks at horizontal movement.
    ///  * [ImmediateMultiDragGestureRecognizer], a similar recognizer, but without
    ///    the limitation that the drag must start horizontally.
    ///  * [VerticalMultiDragGestureRecognizer], which only recognizes drags that
    ///    start vertically.
    /// </Summary>
    public class HorizontalMultiDragGestureRecognizer : FlutterSDK.Gestures.Multidrag.MultiDragGestureRecognizer<FlutterSDK.Gestures.Multidrag._HorizontalPointerState>
    {
        /// <Summary>
        /// Create a gesture recognizer for tracking multiple pointers at once
        /// but only if they first move horizontally.
        /// </Summary>
        public HorizontalMultiDragGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {

        }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Gestures.Multidrag._HorizontalPointerState CreateNewPointerState(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            return new _HorizontalPointerState(@event.Position);
        }



    }


    public class _VerticalPointerState : FlutterSDK.Gestures.Multidrag.MultiDragPointerState
    {
        public _VerticalPointerState(FlutterBinding.UI.Offset initialPosition)
        : base(initialPosition)
        {

        }

        public new void CheckForResolutionAfterMove()
        {

            if (PendingDelta.Dy.Abs() > ConstantsDefaultClass.KTouchSlop) Resolve(GestureDisposition.Accepted);
        }




        public new void Accepted(FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback starter)
        {
            starter(InitialPosition);
        }



    }


    /// <Summary>
    /// Recognizes movement in the vertical direction on a per-pointer basis.
    ///
    /// In contrast to [VerticalDragGestureRecognizer],
    /// [VerticalMultiDragGestureRecognizer] watches each pointer separately,
    /// which means multiple drags can be recognized concurrently if multiple
    /// pointers are in contact with the screen.
    ///
    /// See also:
    ///
    ///  * [VerticalDragGestureRecognizer], a gesture recognizer that just
    ///    looks at vertical movement.
    ///  * [ImmediateMultiDragGestureRecognizer], a similar recognizer, but without
    ///    the limitation that the drag must start vertically.
    ///  * [HorizontalMultiDragGestureRecognizer], which only recognizes drags that
    ///    start horizontally.
    /// </Summary>
    public class VerticalMultiDragGestureRecognizer : FlutterSDK.Gestures.Multidrag.MultiDragGestureRecognizer<FlutterSDK.Gestures.Multidrag._VerticalPointerState>
    {
        /// <Summary>
        /// Create a gesture recognizer for tracking multiple pointers at once
        /// but only if they first move vertically.
        /// </Summary>
        public VerticalMultiDragGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {

        }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Gestures.Multidrag._VerticalPointerState CreateNewPointerState(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            return new _VerticalPointerState(@event.Position);
        }



    }


    public class _DelayedPointerState : FlutterSDK.Gestures.Multidrag.MultiDragPointerState
    {
        public _DelayedPointerState(FlutterBinding.UI.Offset initialPosition, TimeSpan delay)
        : base(initialPosition)
        {

            _Timer = Timer.CreateNew(delay, _DelayPassed);
        }


        internal virtual Timer _Timer { get; set; }
        internal virtual FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback _Starter { get; set; }

        private void _DelayPassed()
        {



            _Timer = null;
            if (_Starter != null)
            {
                _Starter(InitialPosition);
                _Starter = null;
            }
            else
            {
                Resolve(GestureDisposition.Accepted);
            }


        }




        private void _EnsureTimerStopped()
        {
            _Timer?.Cancel();
            _Timer = null;
        }




        public new void Accepted(FlutterSDK.Gestures.Multidrag.GestureMultiDragStartCallback starter)
        {

            if (_Timer == null) starter(InitialPosition); else _Starter = starter;
        }




        public new void CheckForResolutionAfterMove()
        {
            if (_Timer == null)
            {

                return;
            }


            if (PendingDelta.Distance > ConstantsDefaultClass.KTouchSlop)
            {
                Resolve(GestureDisposition.Rejected);
                _EnsureTimerStopped();
            }

        }




        public new void Dispose()
        {
            _EnsureTimerStopped();
            base.Dispose();
        }



    }


    /// <Summary>
    /// Recognizes movement both horizontally and vertically on a per-pointer basis
    /// after a delay.
    ///
    /// In contrast to [ImmediateMultiDragGestureRecognizer],
    /// [DelayedMultiDragGestureRecognizer] waits for a [delay] before recognizing
    /// the drag. If the pointer moves more than [kTouchSlop] before the delay
    /// expires, the gesture is not recognized.
    ///
    /// In contrast to [PanGestureRecognizer], [DelayedMultiDragGestureRecognizer]
    /// watches each pointer separately, which means multiple drags can be
    /// recognized concurrently if multiple pointers are in contact with the screen.
    ///
    /// See also:
    ///
    ///  * [ImmediateMultiDragGestureRecognizer], a similar recognizer but without
    ///    the delay.
    ///  * [PanGestureRecognizer], which recognizes only one drag gesture at a time,
    ///    regardless of how many fingers are involved.
    /// </Summary>
    public class DelayedMultiDragGestureRecognizer : FlutterSDK.Gestures.Multidrag.MultiDragGestureRecognizer<FlutterSDK.Gestures.Multidrag._DelayedPointerState>
    {
        /// <Summary>
        /// Creates a drag recognizer that works on a per-pointer basis after a delay.
        ///
        /// In order for a drag to be recognized by this recognizer, the pointer must
        /// remain in the same place for [delay] (up to [kTouchSlop]). The [delay]
        /// defaults to [kLongPressTimeout] to match [LongPressGestureRecognizer] but
        /// can be changed for specific behaviors.
        /// </Summary>
        public DelayedMultiDragGestureRecognizer(TimeSpan delay = default(TimeSpan), @Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {
            this.Delay = delay;
        }
        /// <Summary>
        /// The amount of time the pointer must remain in the same place for the drag
        /// to be recognized.
        /// </Summary>
        public virtual TimeSpan Delay { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Gestures.Multidrag._DelayedPointerState CreateNewPointerState(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            return new _DelayedPointerState(@event.Position, Delay);
        }



    }

}
