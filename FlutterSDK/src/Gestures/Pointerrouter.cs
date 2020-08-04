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
namespace FlutterSDK.Gestures.Pointerrouter
{
    /// <Summary>
    /// A callback that receives a [PointerEvent]
    /// </Summary>
    public delegate void PointerRoute(FlutterSDK.Gestures.Events.PointerEvent @event);
    internal static class PointerrouterDefaultClass
    {
    }

    public interface IPointerRouter { }

    public class PointerRouter
    {
        internal virtual Dictionary<int, Dictionary<object, object>> _RouteMap { get; set; }
        internal virtual Dictionary<object, object> _GlobalRoutes { get; set; }

        /// <Summary>
        /// Adds a route to the routing table.
        ///
        /// Whenever this object routes a [PointerEvent] corresponding to
        /// pointer, call route.
        ///
        /// Routes added reentrantly within [PointerRouter.route] will take effect when
        /// routing the next event.
        /// </Summary>
        public virtual void AddRoute(int pointer, FlutterSDK.Gestures.Pointerrouter.PointerRoute route, Matrix4 transform = default(Matrix4))
        {
            Dictionary<PointerRoute, Matrix4> routes = _RouteMap.PutIfAbsent(pointer, () => =>new Dictionary<PointerRoute, Matrix4> { });

            routes[route] = transform;
        }




        /// <Summary>
        /// Removes a route from the routing table.
        ///
        /// No longer call route when routing a [PointerEvent] corresponding to
        /// pointer. Requires that this route was previously added to the router.
        ///
        /// Routes removed reentrantly within [PointerRouter.route] will take effect
        /// immediately.
        /// </Summary>
        public virtual void RemoveRoute(int pointer, FlutterSDK.Gestures.Pointerrouter.PointerRoute route)
        {

            Dictionary<PointerRoute, Matrix4> routes = _RouteMap[pointer];

            routes.Remove(route);
            if (routes.IsEmpty()) _RouteMap.Remove(pointer);
        }




        /// <Summary>
        /// Adds a route to the global entry in the routing table.
        ///
        /// Whenever this object routes a [PointerEvent], call route.
        ///
        /// Routes added reentrantly within [PointerRouter.route] will take effect when
        /// routing the next event.
        /// </Summary>
        public virtual void AddGlobalRoute(FlutterSDK.Gestures.Pointerrouter.PointerRoute route, Matrix4 transform = default(Matrix4))
        {

            _GlobalRoutes[route] = transform;
        }




        /// <Summary>
        /// Removes a route from the global entry in the routing table.
        ///
        /// No longer call route when routing a [PointerEvent]. Requires that this
        /// route was previously added via [addGlobalRoute].
        ///
        /// Routes removed reentrantly within [PointerRouter.route] will take effect
        /// immediately.
        /// </Summary>
        public virtual void RemoveGlobalRoute(FlutterSDK.Gestures.Pointerrouter.PointerRoute route)
        {

            _GlobalRoutes.Remove(route);
        }




        private void _Dispatch(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Pointerrouter.PointerRoute route, Matrix4 transform)
        {
            try
            {
                @event = @event.Transformed(transform);
                route(@event);
            }
            catch (exception,stack){
                InformationCollector collector = default(InformationCollector);

                AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetailsForPointerRouter(exception: exception, stack: stack, library: "gesture library", context: new ErrorDescription("while routing a pointer event"), router: this, route: route, @event: @event, informationCollector: collector));
            }

            }




/// <Summary>
/// Calls the routes registered for this pointer event.
///
/// Routes are called in the order in which they were added to the
/// PointerRouter object.
/// </Summary>
        public virtual void Route(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            Dictionary<PointerRoute, Matrix4> routes = _RouteMap[@event.Pointer];
            Dictionary<PointerRoute, Matrix4> copiedGlobalRoutes = Dictionary<PointerRoute, Matrix4>.From(_GlobalRoutes);
            if (routes != null)
            {
                _DispatchEventToRoutes(@event, routes, Dictionary<PointerRoute, Matrix4>.From(routes));
            }

            _DispatchEventToRoutes(@event, _GlobalRoutes, copiedGlobalRoutes);
        }




        private void _DispatchEventToRoutes(FlutterSDK.Gestures.Events.PointerEvent @event, Dictionary<object, object> referenceRoutes, Dictionary<object, object> copiedRoutes)
        {
            copiedRoutes.ForEach((PointerRoute route, Matrix4 transform) =>
            {
                if (referenceRoutes.ContainsKey(route))
                {
                    _Dispatch(@event, route, transform);
                }

            }
            );
        }



    }
    public static class PointerRouterMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IPointerRouter, PointerRouter> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IPointerRouter, PointerRouter>();
        static PointerRouter GetOrCreate(IPointerRouter instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new PointerRouter();
                _table.Add(instance, value);
            }
            return (PointerRouter)value;
        }
        public static void AddRoute(this IPointerRouter instance, int pointer, FlutterSDK.Gestures.Pointerrouter.PointerRoute route, Matrix4 transform = default(Matrix4)) => GetOrCreate(instance).AddRoute(pointer, route, transform);
        public static void RemoveRoute(this IPointerRouter instance, int pointer, FlutterSDK.Gestures.Pointerrouter.PointerRoute route) => GetOrCreate(instance).RemoveRoute(pointer, route);
        public static void AddGlobalRoute(this IPointerRouter instance, FlutterSDK.Gestures.Pointerrouter.PointerRoute route, Matrix4 transform = default(Matrix4)) => GetOrCreate(instance).AddGlobalRoute(route, transform);
        public static void RemoveGlobalRoute(this IPointerRouter instance, FlutterSDK.Gestures.Pointerrouter.PointerRoute route) => GetOrCreate(instance).RemoveGlobalRoute(route);
        public static void Route(this IPointerRouter instance, FlutterSDK.Gestures.Events.PointerEvent @event) => GetOrCreate(instance).Route(@event);
    }


    /// <Summary>
    /// Variant of [FlutterErrorDetails] with extra fields for the gestures
    /// library's pointer router ([PointerRouter]).
    ///
    /// See also:
    ///
    ///  * [FlutterErrorDetailsForPointerEventDispatcher], which is also used
    ///    by the gestures library.
    /// </Summary>
    public class FlutterErrorDetailsForPointerRouter : FlutterSDK.Foundation.Assertions.FlutterErrorDetails
    {
        /// <Summary>
        /// Creates a [FlutterErrorDetailsForPointerRouter] object with the given
        /// arguments setting the object's properties.
        ///
        /// The gestures library calls this constructor when catching an exception
        /// that will subsequently be reported using [FlutterError.onError].
        /// </Summary>
        public FlutterErrorDetailsForPointerRouter(object exception = default(object), StackTrace stack = default(StackTrace), string library = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), FlutterSDK.Gestures.Pointerrouter.PointerRouter router = default(FlutterSDK.Gestures.Pointerrouter.PointerRouter), FlutterSDK.Gestures.Pointerrouter.PointerRoute route = default(FlutterSDK.Gestures.Pointerrouter.PointerRoute), FlutterSDK.Gestures.Events.PointerEvent @event = default(FlutterSDK.Gestures.Events.PointerEvent), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false)
        : base(exception: exception, stack: stack, library: library, context: context, informationCollector: informationCollector, silent: silent)
        {
            this.Router = router;
            this.Route = route;
            this.@event = @event;
        }
        /// <Summary>
        /// The pointer router that caught the exception.
        ///
        /// In a typical application, this is the value of [GestureBinding.pointerRouter] on
        /// the binding ([GestureBinding.instance]).
        /// </Summary>
        public virtual FlutterSDK.Gestures.Pointerrouter.PointerRouter Router { get; set; }
        /// <Summary>
        /// The callback that threw the exception.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Pointerrouter.PointerRoute Route { get; set; }
        /// <Summary>
        /// The pointer event that was being routed when the exception was raised.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Events.PointerEvent @event { get; set; }
    }

}
