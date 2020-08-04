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
        /// <Summary>
        /// A router that routes all pointer events received from the engine.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Pointerrouter.PointerRouter PointerRouter { get; set; }
        /// <Summary>
        /// The gesture arenas used for disambiguating the meaning of sequences of
        /// pointer events.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Arena.GestureArenaManager GestureArena { get; set; }
        /// <Summary>
        /// The resolver used for determining which widget handles a pointer
        /// signal event.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Pointersignalresolver.PointerSignalResolver PointerSignalResolver { get; set; }
        /// <Summary>
        /// State for all pointers which are currently down.
        ///
        /// The state of hovering pointers is not tracked because that would require
        /// hit-testing on every frame.
        /// </Summary>
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
            if (_PendingPointerEvents.IsEmpty() && !Locked) Dart.AsyncDefaultClass.ScheduleMicrotask(_FlushPointerEventQueue);
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
                    AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetailsForPointerEventDispatcher(exception: exception, stack: stack, library: "gesture library", context: new ErrorDescription("while dispatching a non-hit-tested pointer event"), @event: @event, hitTestEntry: null, informationCollector: () =>
                    {
                        yield return new DiagnosticsProperty<PointerEvent>("Event", @event, style: DiagnosticsTreeStyle.ErrorProperty);
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
                        AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetailsForPointerEventDispatcher(exception: exception, stack: stack, library: "gesture library", context: new ErrorDescription("while dispatching a pointer event"), @event: @event, hitTestEntry: entry, informationCollector: () =>
                        {
                            yield return new DiagnosticsProperty<PointerEvent>("Event", @event, style: DiagnosticsTreeStyle.ErrorProperty);
                            yield return new DiagnosticsProperty<HitTestTarget>("Target", entry.Target, style: DiagnosticsTreeStyle.ErrorProperty);
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
        /// <Summary>
        /// Creates a [FlutterErrorDetailsForPointerEventDispatcher] object with the given
        /// arguments setting the object's properties.
        ///
        /// The gesture library calls this constructor when catching an exception
        /// that will subsequently be reported using [FlutterError.onError].
        /// </Summary>
        public FlutterErrorDetailsForPointerEventDispatcher(object exception = default(object), StackTrace stack = default(StackTrace), string library = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), FlutterSDK.Gestures.Events.PointerEvent @event = default(FlutterSDK.Gestures.Events.PointerEvent), FlutterSDK.Gestures.Hittest.HitTestEntry hitTestEntry = default(FlutterSDK.Gestures.Hittest.HitTestEntry), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false)
        : base(exception: exception, stack: stack, library: library, context: context, informationCollector: informationCollector, silent: silent)
        {
            this.@event = @event;
            this.HitTestEntry = hitTestEntry;
        }
        /// <Summary>
        /// The pointer event that was being routed when the exception was raised.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Events.PointerEvent @event { get; set; }
        /// <Summary>
        /// The hit test result entry for the object whose handleEvent method threw
        /// the exception. May be null if no hit test entry is associated with the
        /// event (e.g. hover and pointer add/remove events).
        ///
        /// The target object itself is given by the [HitTestEntry.target] property of
        /// the hitTestEntry object.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Hittest.HitTestEntry HitTestEntry { get; set; }
    }

}
