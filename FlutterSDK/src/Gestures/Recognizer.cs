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
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
namespace FlutterSDK.Gestures.Recognizer
{
    /// <Summary>
    /// Generic signature for callbacks passed to
    /// [GestureRecognizer.invokeCallback]. This allows the
    /// [GestureRecognizer.invokeCallback] mechanism to be generically used with
    /// anonymous functions that return objects of particular types.
    /// </Summary>
    public delegate T RecognizerCallback<T>();
    internal static class RecognizerDefaultClass
    {
    }

    /// <Summary>
    /// The base class that all gesture recognizers inherit from.
    ///
    /// Provides a basic API that can be used by classes that work with
    /// gesture recognizers but don't care about the specific details of
    /// the gestures recognizers themselves.
    ///
    /// See also:
    ///
    ///  * [GestureDetector], the widget that is used to detect gestures.
    ///  * [debugPrintRecognizerCallbacksTrace], a flag that can be set to help
    ///    debug issues with gesture recognizers.
    /// </Summary>
    public interface IGestureRecognizer
    {
        void AddPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
        void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
        void HandleNonAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
        bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerDownEvent @event);
        PointerDeviceKind GetKindForPointer(int pointer);
        void Dispose();
        T InvokeCallback<T>(string name, FlutterSDK.Gestures.Recognizer.RecognizerCallback<T> callback, Func<String> debugReport = default(Func<String>));
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        @Object DebugOwner { get; }
        string DebugDescription { get; }
    }


    /// <Summary>
    /// Base class for gesture recognizers that can only recognize one
    /// gesture at a time. For example, a single [TapGestureRecognizer]
    /// can never recognize two taps happening simultaneously, even if
    /// multiple pointers are placed on the same widget.
    ///
    /// This is in contrast to, for instance, [MultiTapGestureRecognizer],
    /// which manages each pointer independently and can consider multiple
    /// simultaneous touches to each result in a separate tap.
    /// </Summary>
    public interface IOneSequenceGestureRecognizer
    {
        void HandleNonAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
        void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event);
        void AcceptGesture(int pointer);
        void RejectGesture(int pointer);
        void DidStopTrackingLastPointer(int pointer);
        void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition);
        void ResolvePointer(int pointer, FlutterSDK.Gestures.Arena.GestureDisposition disposition);
        void Dispose();
        void StartTrackingPointer(int pointer, Matrix4 transform = default(Matrix4));
        void StopTrackingPointer(int pointer);
        void StopTrackingIfPointerNoLongerDown(FlutterSDK.Gestures.Events.PointerEvent @event);
        FlutterSDK.Gestures.Team.GestureArenaTeam Team { get; set; }
    }


    /// <Summary>
    /// A base class for gesture recognizers that track a single primary pointer.
    ///
    /// Gestures based on this class will stop tracking the gesture if the primary
    /// pointer travels beyond [preAcceptSlopTolerance] or [postAcceptSlopTolerance]
    /// pixels from the original contact point of the gesture.
    ///
    /// If the [preAcceptSlopTolerance] was breached before the gesture was accepted
    /// in the gesture arena, the gesture will be rejected.
    /// </Summary>
    public interface IPrimaryPointerGestureRecognizer
    {
        void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
        void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event);
        void HandlePrimaryPointer(FlutterSDK.Gestures.Events.PointerEvent @event);
        void DidExceedDeadline();
        void DidExceedDeadlineWithEvent(FlutterSDK.Gestures.Events.PointerDownEvent @event);
        void AcceptGesture(int pointer);
        void RejectGesture(int pointer);
        void DidStopTrackingLastPointer(int pointer);
        void Dispose();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        TimeSpan Deadline { get; }
        double PreAcceptSlopTolerance { get; }
        double PostAcceptSlopTolerance { get; }
        FlutterSDK.Gestures.Recognizer.GestureRecognizerState State { get; set; }
        int PrimaryPointer { get; set; }
        FlutterSDK.Gestures.Recognizer.OffsetPair InitialPosition { get; set; }
    }


    /// <Summary>
    /// The base class that all gesture recognizers inherit from.
    ///
    /// Provides a basic API that can be used by classes that work with
    /// gesture recognizers but don't care about the specific details of
    /// the gestures recognizers themselves.
    ///
    /// See also:
    ///
    ///  * [GestureDetector], the widget that is used to detect gestures.
    ///  * [debugPrintRecognizerCallbacksTrace], a flag that can be set to help
    ///    debug issues with gesture recognizers.
    /// </Summary>
    public class GestureRecognizer : FlutterSDK.Gestures.Arena.GestureArenaMember, IDiagnosticableTreeMixin
    {
        /// <Summary>
        /// Initializes the gesture recognizer.
        ///
        /// The argument is optional and is only used for debug purposes (e.g. in the
        /// [toString] serialization).
        ///
        /// {@template flutter.gestures.gestureRecognizer.kind}
        /// It's possible to limit this recognizer to a specific [PointerDeviceKind]
        /// by providing the optional [kind] argument. If [kind] is null,
        /// the recognizer will accept pointer events from all device kinds.
        /// {@endtemplate}
        /// </Summary>
        public GestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base()
        {
            this.DebugOwner = debugOwner;
        }
        /// <Summary>
        /// The recognizer's owner.
        ///
        /// This is used in the [toString] serialization to report the object for which
        /// this gesture recognizer was created, to aid in debugging.
        /// </Summary>
        public virtual @Object DebugOwner { get; set; }
        /// <Summary>
        /// The kind of device that's allowed to be recognized. If null, events from
        /// all device kinds will be tracked and recognized.
        /// </Summary>
        internal virtual PointerDeviceKind _KindFilter { get; set; }
        /// <Summary>
        /// Holds a mapping between pointer IDs and the kind of devices they are
        /// coming from.
        /// </Summary>
        internal virtual Dictionary<int, PointerDeviceKind> _PointerToKind { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Registers a new pointer that might be relevant to this gesture
        /// detector.
        ///
        /// The owner of this gesture recognizer calls addPointer() with the
        /// PointerDownEvent of each pointer that should be considered for
        /// this gesture.
        ///
        /// It's the GestureRecognizer's responsibility to then add itself
        /// to the global pointer router (see [PointerRouter]) to receive
        /// subsequent events for this pointer, and to add the pointer to
        /// the global gesture arena manager (see [GestureArenaManager]) to track
        /// that pointer.
        ///
        /// This method is called for each and all pointers being added. In
        /// most cases, you want to override [addAllowedPointer] instead.
        /// </Summary>
        public virtual void AddPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            _PointerToKind[@event.Pointer] = @event.Kind;
            if (IsPointerAllowed(@event))
            {
                AddAllowedPointer(@event);
            }
            else
            {
                HandleNonAllowedPointer(@event);
            }

        }




        /// <Summary>
        /// Registers a new pointer that's been checked to be allowed by this gesture
        /// recognizer.
        ///
        /// Subclasses of [GestureRecognizer] are supposed to override this method
        /// instead of [addPointer] because [addPointer] will be called for each
        /// pointer being added while [addAllowedPointer] is only called for pointers
        /// that are allowed by this recognizer.
        /// </Summary>
        public virtual void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
        }




        /// <Summary>
        /// Handles a pointer being added that's not allowed by this recognizer.
        ///
        /// Subclasses can override this method and reject the gesture.
        ///
        /// See:
        /// - [OneSequenceGestureRecognizer.handleNonAllowedPointer].
        /// </Summary>
        public virtual void HandleNonAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
        }




        /// <Summary>
        /// Checks whether or not a pointer is allowed to be tracked by this recognizer.
        /// </Summary>
        public virtual bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            return _KindFilter == null || _KindFilter == @event.Kind;
        }




        /// <Summary>
        /// For a given pointer ID, returns the device kind associated with it.
        ///
        /// The pointer ID is expected to be a valid one i.e. an event was received
        /// with that pointer ID.
        /// </Summary>
        public virtual PointerDeviceKind GetKindForPointer(int pointer)
        {

            return _PointerToKind[pointer];
        }




        /// <Summary>
        /// Releases any resources used by the object.
        ///
        /// This method is called by the owner of this gesture recognizer
        /// when the object is no longer needed (e.g. when a gesture
        /// recognizer is being unregistered from a [GestureDetector], the
        /// GestureDetector widget calls this method).
        /// </Summary>
        public virtual void Dispose()
        {
        }




        /// <Summary>
        /// Invoke a callback provided by the application, catching and logging any
        /// exceptions.
        ///
        /// The `name` argument is ignored except when reporting exceptions.
        ///
        /// The `debugReport` argument is optional and is used when
        /// [debugPrintRecognizerCallbacksTrace] is true. If specified, it must be a
        /// callback that returns a string describing useful debugging information,
        /// e.g. the arguments passed to the callback.
        /// </Summary>
        public virtual T InvokeCallback<T>(string name, FlutterSDK.Gestures.Recognizer.RecognizerCallback<T> callback, Func<String> debugReport = default(Func<String>))
        {

            T result = default(T);
            try
            {

                result = callback();
            }
            catch (exception,stack){
                InformationCollector collector = default(InformationCollector);

                AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, stack: stack, library: "gesture", context: new ErrorDescription("while handling a gesture"), informationCollector: collector));
            }

            return result;
            }




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<object>("debugOwner", DebugOwner, defaultValue: null));
        }



    }


    /// <Summary>
    /// Base class for gesture recognizers that can only recognize one
    /// gesture at a time. For example, a single [TapGestureRecognizer]
    /// can never recognize two taps happening simultaneously, even if
    /// multiple pointers are placed on the same widget.
    ///
    /// This is in contrast to, for instance, [MultiTapGestureRecognizer],
    /// which manages each pointer independently and can consider multiple
    /// simultaneous touches to each result in a separate tap.
    /// </Summary>
    public class OneSequenceGestureRecognizer : FlutterSDK.Gestures.Recognizer.GestureRecognizer
    {
        /// <Summary>
        /// Initialize the object.
        ///
        /// {@macro flutter.gestures.gestureRecognizer.kind}
        /// </Summary>
        public OneSequenceGestureRecognizer(@Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {

        }
        internal virtual Dictionary<int, FlutterSDK.Gestures.Arena.GestureArenaEntry> _Entries { get; set; }
        internal virtual HashSet<int> _TrackedPointers { get; set; }
        internal virtual FlutterSDK.Gestures.Team.GestureArenaTeam _Team { get; set; }
        public virtual FlutterSDK.Gestures.Team.GestureArenaTeam Team { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void HandleNonAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            Resolve(GestureDisposition.Rejected);
        }




        /// <Summary>
        /// Called when a pointer event is routed to this recognizer.
        /// </Summary>
        public virtual void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
        }


        public new void AcceptGesture(int pointer)
        {
        }




        public new void RejectGesture(int pointer)
        {
        }




        /// <Summary>
        /// Called when the number of pointers this recognizer is tracking changes from one to zero.
        ///
        /// The given pointer ID is the ID of the last pointer this recognizer was
        /// tracking.
        /// </Summary>
        public virtual void DidStopTrackingLastPointer(int pointer)
        {
        }


        /// <Summary>
        /// Resolves this recognizer's participation in each gesture arena with the
        /// given disposition.
        /// </Summary>
        public virtual void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition)
        {
            List<GestureArenaEntry> localEntries = List<GestureArenaEntry>.From(_Entries.Values);
            _Entries.Clear();
            foreach (GestureArenaEntry entry in localEntries) entry.Resolve(disposition);
        }




        /// <Summary>
        /// Resolves this recognizer's participation in the given gesture arena with
        /// the given disposition.
        /// </Summary>
        public virtual void ResolvePointer(int pointer, FlutterSDK.Gestures.Arena.GestureDisposition disposition)
        {
            GestureArenaEntry entry = _Entries[pointer];
            if (entry != null)
            {
                entry.Resolve(disposition);
                _Entries.Remove(pointer);
            }

        }




        public new void Dispose()
        {
            Resolve(GestureDisposition.Rejected);
            foreach (int pointer in _TrackedPointers) BindingDefaultClass.GestureBinding.Instance.PointerRouter.RemoveRoute(pointer, HandleEvent);
            _TrackedPointers.Clear();

            base.Dispose();
        }




        private FlutterSDK.Gestures.Arena.GestureArenaEntry _AddPointerToArena(int pointer)
        {
            if (_Team != null) return _Team.Add(pointer, this);
            return BindingDefaultClass.GestureBinding.Instance.GestureArena.Add(pointer, this);
        }




        /// <Summary>
        /// Causes events related to the given pointer ID to be routed to this recognizer.
        ///
        /// The pointer events are transformed according to `transform` and then delivered
        /// to [handleEvent]. The value for the `transform` argument is usually obtained
        /// from [PointerDownEvent.transform] to transform the events from the global
        /// coordinate space into the coordinate space of the event receiver. It may be
        /// null if no transformation is necessary.
        ///
        /// Use [stopTrackingPointer] to remove the route added by this function.
        /// </Summary>
        public virtual void StartTrackingPointer(int pointer, Matrix4 transform = default(Matrix4))
        {
            BindingDefaultClass.GestureBinding.Instance.PointerRouter.AddRoute(pointer, HandleEvent, transform);
            _TrackedPointers.Add(pointer);

            _Entries[pointer] = _AddPointerToArena(pointer);
        }




        /// <Summary>
        /// Stops events related to the given pointer ID from being routed to this recognizer.
        ///
        /// If this function reduces the number of tracked pointers to zero, it will
        /// call [didStopTrackingLastPointer] synchronously.
        ///
        /// Use [startTrackingPointer] to add the routes in the first place.
        /// </Summary>
        public virtual void StopTrackingPointer(int pointer)
        {
            if (_TrackedPointers.Contains(pointer))
            {
                BindingDefaultClass.GestureBinding.Instance.PointerRouter.RemoveRoute(pointer, HandleEvent);
                _TrackedPointers.Remove(pointer);
                if (_TrackedPointers.IsEmpty()) DidStopTrackingLastPointer(pointer);
            }

        }




        /// <Summary>
        /// Stops tracking the pointer associated with the given event if the event is
        /// a [PointerUpEvent] or a [PointerCancelEvent] event.
        /// </Summary>
        public virtual void StopTrackingIfPointerNoLongerDown(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            if (@event is PointerUpEvent || @event is PointerCancelEvent) StopTrackingPointer(@event.Pointer);
        }



    }


    /// <Summary>
    /// A base class for gesture recognizers that track a single primary pointer.
    ///
    /// Gestures based on this class will stop tracking the gesture if the primary
    /// pointer travels beyond [preAcceptSlopTolerance] or [postAcceptSlopTolerance]
    /// pixels from the original contact point of the gesture.
    ///
    /// If the [preAcceptSlopTolerance] was breached before the gesture was accepted
    /// in the gesture arena, the gesture will be rejected.
    /// </Summary>
    public class PrimaryPointerGestureRecognizer : FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer
    {
        /// <Summary>
        /// Initializes the [deadline] field during construction of subclasses.
        ///
        /// {@macro flutter.gestures.gestureRecognizer.kind}
        /// </Summary>
        public PrimaryPointerGestureRecognizer(TimeSpan deadline = default(TimeSpan), double preAcceptSlopTolerance = default(double), double postAcceptSlopTolerance = default(double), @Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
        : base(debugOwner: debugOwner, kind: kind)
        {
            this.Deadline = deadline;
            this.PreAcceptSlopTolerance = preAcceptSlopTolerance;
            this.PostAcceptSlopTolerance = postAcceptSlopTolerance;
        }
        /// <Summary>
        /// If non-null, the recognizer will call [didExceedDeadline] after this
        /// amount of time has elapsed since starting to track the primary pointer.
        ///
        /// The [didExceedDeadline] will not be called if the primary pointer is
        /// accepted, rejected, or all pointers are up or canceled before [deadline].
        /// </Summary>
        public virtual TimeSpan Deadline { get; set; }
        /// <Summary>
        /// The maximum distance in logical pixels the gesture is allowed to drift
        /// from the initial touch down position before the gesture is accepted.
        ///
        /// Drifting past the allowed slop amount causes the gesture to be rejected.
        ///
        /// Can be null to indicate that the gesture can drift for any distance.
        /// Defaults to 18 logical pixels.
        /// </Summary>
        public virtual double PreAcceptSlopTolerance { get; set; }
        /// <Summary>
        /// The maximum distance in logical pixels the gesture is allowed to drift
        /// after the gesture has been accepted.
        ///
        /// Drifting past the allowed slop amount causes the gesture to stop tracking
        /// and signaling subsequent callbacks.
        ///
        /// Can be null to indicate that the gesture can drift for any distance.
        /// Defaults to 18 logical pixels.
        /// </Summary>
        public virtual double PostAcceptSlopTolerance { get; set; }
        /// <Summary>
        /// The current state of the recognizer.
        ///
        /// See [GestureRecognizerState] for a description of the states.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.GestureRecognizerState State { get; set; }
        /// <Summary>
        /// The ID of the primary pointer this recognizer is tracking.
        /// </Summary>
        public virtual int PrimaryPointer { get; set; }
        /// <Summary>
        /// The location at which the primary pointer contacted the screen.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.OffsetPair InitialPosition { get; set; }
        internal virtual bool _GestureAccepted { get; set; }
        internal virtual Timer _Timer { get; set; }

        public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            StartTrackingPointer(@event.Pointer, @event.Transform);
            if (State == GestureRecognizerState.Ready)
            {
                State = GestureRecognizerState.Possible;
                PrimaryPointer = ((PointerUpEvent)@event).Pointer;
                InitialPosition = new OffsetPair(local: ((PointerUpEvent)@event).LocalPosition, global: ((PointerUpEvent)@event).Position);
                if (Deadline != null) _Timer = new Timer(Deadline, () => =>DidExceedDeadlineWithEvent(((PointerUpEvent)@event)));
            }

        }




        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {

            if (State == GestureRecognizerState.Possible && @event.Pointer == PrimaryPointer)
            {
                bool isPreAcceptSlopPastTolerance = !_GestureAccepted && PreAcceptSlopTolerance != null && _GetGlobalDistance(@event) > PreAcceptSlopTolerance;
                bool isPostAcceptSlopPastTolerance = _GestureAccepted && PostAcceptSlopTolerance != null && _GetGlobalDistance(@event) > PostAcceptSlopTolerance;
                if (((PointerMoveEvent)@event) is PointerMoveEvent && (isPreAcceptSlopPastTolerance || isPostAcceptSlopPastTolerance))
                {
                    Resolve(GestureDisposition.Rejected);
                    StopTrackingPointer(PrimaryPointer);
                }
                else
                {
                    HandlePrimaryPointer(@event);
                }

            }

            StopTrackingIfPointerNoLongerDown(@event);
        }




        /// <Summary>
        /// Override to provide behavior for the primary pointer when the gesture is still possible.
        /// </Summary>
        public virtual void HandlePrimaryPointer(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
        }


        /// <Summary>
        /// Override to be notified when [deadline] is exceeded.
        ///
        /// You must override this method or [didExceedDeadlineWithEvent] if you
        /// supply a [deadline].
        /// </Summary>
        public virtual void DidExceedDeadline()
        {

        }




        /// <Summary>
        /// Same as [didExceedDeadline] but receives the [event] that initiated the
        /// gesture.
        ///
        /// You must override this method or [didExceedDeadline] if you supply a
        /// [deadline].
        /// </Summary>
        public virtual void DidExceedDeadlineWithEvent(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            DidExceedDeadline();
        }




        public new void AcceptGesture(int pointer)
        {
            if (pointer == PrimaryPointer)
            {
                _StopTimer();
                _GestureAccepted = true;
            }

        }




        public new void RejectGesture(int pointer)
        {
            if (pointer == PrimaryPointer && State == GestureRecognizerState.Possible)
            {
                _StopTimer();
                State = GestureRecognizerState.Defunct;
            }

        }




        public new void DidStopTrackingLastPointer(int pointer)
        {

            _StopTimer();
            State = GestureRecognizerState.Ready;
        }




        public new void Dispose()
        {
            _StopTimer();
            base.Dispose();
        }




        private void _StopTimer()
        {
            if (_Timer != null)
            {
                _Timer.Cancel();
                _Timer = null;
            }

        }




        private double _GetGlobalDistance(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            Offset offset = @event.Position - InitialPosition.Global;
            return offset.Distance;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<GestureRecognizerState>("state", State));
        }



    }


    /// <Summary>
    /// A container for a [local] and [global] [Offset] pair.
    ///
    /// Usually, the [global] [Offset] is in the coordinate space of the screen
    /// after conversion to logical pixels and the [local] offset is the same
    /// [Offset], but transformed to a local coordinate space.
    /// </Summary>
    public class OffsetPair
    {
        /// <Summary>
        /// Creates a [OffsetPair] combining a [local] and [global] [Offset].
        /// </Summary>
        public OffsetPair(FlutterBinding.UI.Offset local = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset global = default(FlutterBinding.UI.Offset))
        {
            this.Local = local;
            this.Global = global;
        }
        /// <Summary>
        /// Creates a [OffsetPair] from [PointerEvent.localPosition] and
        /// [PointerEvent.position].
        /// </Summary>
        public static OffsetPair FromEventPosition(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            var instance = new OffsetPair();
            return new OffsetPair(local: @event.LocalPosition, global: @event.Position);
        }


        /// <Summary>
        /// Creates a [OffsetPair] from [PointerEvent.localDelta] and
        /// [PointerEvent.delta].
        /// </Summary>
        public static OffsetPair FromEventDelta(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            var instance = new OffsetPair();
            return new OffsetPair(local: @event.LocalDelta, global: @event.Delta);
        }


        /// <Summary>
        /// A [OffsetPair] where both [Offset]s are [Offset.zero].
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.OffsetPair Zero { get; set; }
        /// <Summary>
        /// The [Offset] in the local coordinate space.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset Local { get; set; }
        /// <Summary>
        /// The [Offset] in the global coordinate space after conversion to logical
        /// pixels.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset Global { get; set; }

        /// <Summary>
        /// Adds the `other.global` to [global] and `other.local` to [local].
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.OffsetPair AddOperator(FlutterSDK.Gestures.Recognizer.OffsetPair other)
        {
            return new OffsetPair(local: Local + other.Local, global: Global + other.Global);
        }




        /// <Summary>
        /// Subtracts the `other.global` from [global] and `other.local` from [local].
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.OffsetPair SubtractOperator(FlutterSDK.Gestures.Recognizer.OffsetPair other)
        {
            return new OffsetPair(local: Local - other.Local, global: Global - other.Global);
        }




    }


    /// <Summary>
    /// Configuration of offset passed to [DragStartDetails].
    ///
    /// The settings determines when a drag formally starts when the user
    /// initiates a drag.
    ///
    /// See also:
    ///
    ///  * [DragGestureRecognizer.dragStartBehavior], which gives an example for the different behaviors.
    /// </Summary>
    public enum DragStartBehavior
    {

        /// <Summary>
        /// Set the initial offset, at the position where the first down event was
        /// detected.
        /// </Summary>
        Down,
        /// <Summary>
        /// Set the initial position at the position where the drag start event was
        /// detected.
        /// </Summary>
        Start,
    }


    /// <Summary>
    /// The possible states of a [PrimaryPointerGestureRecognizer].
    ///
    /// The recognizer advances from [ready] to [possible] when it starts tracking a
    /// primary pointer. When the primary pointer is resolved in the gesture
    /// arena (either accepted or rejected), the recognizers advances to [defunct].
    /// Once the recognizer has stopped tracking any remaining pointers, the
    /// recognizer returns to [ready].
    /// </Summary>
    public enum GestureRecognizerState
    {

        /// <Summary>
        /// The recognizer is ready to start recognizing a gesture.
        /// </Summary>
        Ready,
        /// <Summary>
        /// The sequence of pointer events seen thus far is consistent with the
        /// gesture the recognizer is attempting to recognize but the gesture has not
        /// been accepted definitively.
        /// </Summary>
        Possible,
        /// <Summary>
        /// Further pointer events cannot cause this recognizer to recognize the
        /// gesture until the recognizer returns to the [ready] state (typically when
        /// all the pointers the recognizer is tracking are removed from the screen).
        /// </Summary>
        Defunct,
    }

}
