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
namespace FlutterSDK.Gestures.Binding
{
    internal static class BindingDefaultClass
    {
    }

    public interface IGestureBinding { }

    public class GestureBinding : IHitTestable, IHitTestDispatcher, IHitTestTarget
    {
        internal virtual FlutterSDK.Gestures.Binding.GestureBinding _Instance { get; set; }
        internal virtual Queue<FlutterSDK.Gestures.Events.PointerEvent> _PendingPointerEvents { get; set; }
        public virtual FlutterSDK.Gestures.Pointerrouter.PointerRouter PointerRouter { get; set; }
        public virtual FlutterSDK.Gestures.Arena.GestureArenaManager GestureArena { get; set; }
        public virtual FlutterSDK.Gestures.Pointersignalresolver.PointerSignalResolver PointerSignalResolver { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Gestures.Hittest.HitTestResult> _HitTests { get; set; }
        public virtual FlutterSDK.Gestures.Binding.GestureBinding Instance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitInstances()
        {
            base.InitInstances();
            _Instance = this;
            Window.OnPointerDataPacket = _HandlePointerDataPacket;
        }




        public new void Unlocked()
        {
            base.Unlocked();
            _FlushPointerEventQueue();
        }




        private void _HandlePointerDataPacket(PointerDataPacket packet)
        {
            _PendingPointerEvents.AddAll(ConverterDefaultClass.PointerEventConverter.Expand(packet.Data, Window.DevicePixelRatio));
            if (!Locked) _FlushPointerEventQueue();
        }




        /// <Summary>
        /// Dispatch a [PointerCancelEvent] for the given pointer soon.
        ///
        /// The pointer event will be dispatched before the next pointer event and
        /// before the end of the microtask but not within this function call.
        /// </Summary>
        public virtual void CancelPointer(int pointer)
        {
            if (_PendingPointerEvents.IsEmpty() && !Locked) Dart: asyncDefaultClass.ScheduleMicrotask(_FlushPointerEventQueue);
            _PendingPointerEvents.AddFirst(new PointerCancelEvent(pointer: pointer));
        }




        private void _FlushPointerEventQueue()
        {

            while (_PendingPointerEvents.IsNotEmpty) _HandlePointerEvent(_PendingPointerEvents.RemoveFirst());
        }




        private void _HandlePointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {

            HitTestResult hitTestResult = default(HitTestResult);
            if (@event is PointerDownEvent || @event is PointerSignalEvent)
            {

                hitTestResult = new HitTestResult();
                HitTest(hitTestResult, ((PointerDownEvent)@event).Position);
                if (((PointerDownEvent)@event) is PointerDownEvent)
                {
                    _HitTests[((PointerDownEvent)@event).Pointer] = hitTestResult;
                }


            }
            else if (@event is PointerUpEvent || @event is PointerCancelEvent)
            {
                hitTestResult = _HitTests.Remove(((PointerUpEvent)@event).Pointer);
            }
            else if (@event.Down)
            {
                hitTestResult = _HitTests[@event.Pointer];
            }


            if (hitTestResult != null || @event is PointerHoverEvent || @event is PointerAddedEvent || @event is PointerRemovedEvent)
            {
                DispatchEvent(((PointerHoverEvent)@event), hitTestResult);
            }

        }




        /// <Summary>
        /// Determine which [HitTestTarget] objects are located at a given position.
        /// </Summary>
        public new void HitTest(FlutterSDK.Gestures.Hittest.HitTestResult result, FlutterBinding.UI.Offset position)
        {
            result.Add(new HitTestEntry(this));
        }




        /// <Summary>
        /// Dispatch an event to a hit test result's path.
        ///
        /// This sends the given event to every [HitTestTarget] in the entries of the
        /// given [HitTestResult], and catches exceptions that any of the handlers
        /// might throw. The [hitTestResult] argument may only be null for
        /// [PointerHoverEvent], [PointerAddedEvent], or [PointerRemovedEvent] events.
        /// </Summary>
        public new void DispatchEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestResult hitTestResult)
        {

            if (hitTestResult == null)
            {

                try
                {
                    PointerRouter.Route(@event);
                }
                catch (exception,stack){
                    AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetailsForPointerEventDispatcher(exception: exception, stack: stack, library: "gesture library", context: new ErrorDescription("while dispatching a non-hit-tested pointer event"), @event: @event, hitTestEntry: null, informationCollector: () => sync *{
yield new DiagnosticsProperty<PointerEvent>("Event", @event, style:DiagnosticsTreeStyle.ErrorProperty);
                }
));
                }

                return;
            }

            foreach (HitTestEntry entry in hitTestResult.Path)
            {
                try
                {
                    entry.Target.HandleEvent(@event.Transformed(entry.Transform), entry);
                }
                catch (exception,stack){
                    AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetailsForPointerEventDispatcher(exception: exception, stack: stack, library: "gesture library", context: new ErrorDescription("while dispatching a pointer event"), @event: @event, hitTestEntry: entry, informationCollector: () => sync *{
yield new DiagnosticsProperty<PointerEvent>("Event", @event, style:DiagnosticsTreeStyle.ErrorProperty);
                    yield new DiagnosticsProperty<HitTestTarget>("Target", entry.Target, style: DiagnosticsTreeStyle.ErrorProperty);
                }
));
                }

            }

        }




        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry)
        {
            PointerRouter.Route(@event);
            if (@event is PointerDownEvent)
            {
                GestureArena.Close(((PointerDownEvent)@event).Pointer);
            }
            else if (@event is PointerUpEvent)
            {
                GestureArena.Sweep(((PointerUpEvent)@event).Pointer);
            }
            else if (@event is PointerSignalEvent)
            {
                PointerSignalResolver.Resolve(((PointerSignalEvent)@event));
            }

        }



    }
    public static class GestureBindingMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IGestureBinding, GestureBinding> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IGestureBinding, GestureBinding>();
        static GestureBinding GetOrCreate(IGestureBinding instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new GestureBinding();
                _table.Add(instance, value);
            }
            return (GestureBinding)value;
        }
        public static FlutterSDK.Gestures.Pointerrouter.PointerRouter PointerRouterProperty(this IGestureBinding instance) => GetOrCreate(instance).PointerRouter;
        public static FlutterSDK.Gestures.Arena.GestureArenaManager GestureArenaProperty(this IGestureBinding instance) => GetOrCreate(instance).GestureArena;
        public static FlutterSDK.Gestures.Pointersignalresolver.PointerSignalResolver PointerSignalResolverProperty(this IGestureBinding instance) => GetOrCreate(instance).PointerSignalResolver;
        public static FlutterSDK.Gestures.Binding.GestureBinding InstanceProperty(this IGestureBinding instance) => GetOrCreate(instance).Instance;
        public static void InitInstances(this IGestureBinding instance) => GetOrCreate(instance).InitInstances();
        public static void Unlocked(this IGestureBinding instance) => GetOrCreate(instance).Unlocked();
        public static void CancelPointer(this IGestureBinding instance, int pointer) => GetOrCreate(instance).CancelPointer(pointer);
        public static void HitTest(this IGestureBinding instance, FlutterSDK.Gestures.Hittest.HitTestResult result, FlutterBinding.UI.Offset position) => GetOrCreate(instance).HitTest(result, position);
        public static void DispatchEvent(this IGestureBinding instance, FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestResult hitTestResult) => GetOrCreate(instance).DispatchEvent(@event, hitTestResult);
        public static void HandleEvent(this IGestureBinding instance, FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry) => GetOrCreate(instance).HandleEvent(@event, entry);
    }


    /// <Summary>
    /// Variant of [FlutterErrorDetails] with extra fields for the gesture
    /// library's binding's pointer event dispatcher ([GestureBinding.dispatchEvent]).
    ///
    /// See also:
    ///
    ///  * [FlutterErrorDetailsForPointerRouter], which is also used by the
    ///    gesture library.
    /// </Summary>
    public class FlutterErrorDetailsForPointerEventDispatcher : FlutterSDK.Foundation.Assertions.FlutterErrorDetails
    {
        #region constructors
        public FlutterErrorDetailsForPointerEventDispatcher(object exception = default(object), StackTrace stack = default(StackTrace), string library = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), FlutterSDK.Gestures.Events.PointerEvent @event = default(FlutterSDK.Gestures.Events.PointerEvent), FlutterSDK.Gestures.Hittest.HitTestEntry hitTestEntry = default(FlutterSDK.Gestures.Hittest.HitTestEntry), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false)
        : base(exception: exception, stack: stack, library: library, context: context, informationCollector: informationCollector, silent: silent)
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Gestures.Events.PointerEvent @event { get; set; }
    public virtual FlutterSDK.Gestures.Hittest.HitTestEntry HitTestEntry { get; set; }
    #endregion

    #region methods
    #endregion
}

}
