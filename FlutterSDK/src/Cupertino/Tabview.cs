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
namespace FlutterSDK.Cupertino.Tabview
{
    internal static class TabviewDefaultClass
    {
    }

    /// <Summary>
    /// A single tab view with its own [Navigator] state and history.
    ///
    /// A typical tab view used as the content of each tab in a [CupertinoTabScaffold]
    /// where multiple tabs with parallel navigation states and history can
    /// co-exist.
    ///
    /// [CupertinoTabView] configures the top-level [Navigator] to search for routes
    /// in the following order:
    ///
    ///  1. For the `/` route, the [builder] property, if non-null, is used.
    ///
    ///  2. Otherwise, the [routes] table is used, if it has an entry for the route,
    ///     including `/` if [builder] is not specified.
    ///
    ///  3. Otherwise, [onGenerateRoute] is called, if provided. It should return a
    ///     non-null value for any _valid_ route not handled by [builder] and [routes].
    ///
    ///  4. Finally if all else fails [onUnknownRoute] is called.
    ///
    /// These navigation properties are not shared with any sibling [CupertinoTabView]
    /// nor any ancestor or descendant [Navigator] instances.
    ///
    /// To push a route above this [CupertinoTabView] instead of inside it (such
    /// as when showing a dialog on top of all tabs), use
    /// `Navigator.of(rootNavigator: true)`.
    ///
    /// See also:
    ///
    ///  * [CupertinoTabScaffold], a typical host that supports switching between tabs.
    ///  * [CupertinoPageRoute], a typical modal page route pushed onto the
    ///    [CupertinoTabView]'s [Navigator].
    /// </Summary>
    public class CupertinoTabView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates the content area for a tab in a [CupertinoTabScaffold].
        /// </Summary>
        public CupertinoTabView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder), FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> navigatorKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState>), string defaultTitle = default(string), Dictionary<string, object> routes = default(Dictionary<string, object>), FlutterSDK.Widgets.Navigator.RouteFactory onGenerateRoute = default(FlutterSDK.Widgets.Navigator.RouteFactory), FlutterSDK.Widgets.Navigator.RouteFactory onUnknownRoute = default(FlutterSDK.Widgets.Navigator.RouteFactory), List<FlutterSDK.Widgets.Navigator.NavigatorObserver> navigatorObservers = default(List<FlutterSDK.Widgets.Navigator.NavigatorObserver>))
        : base(key: key)
        {
            this.Builder = builder;
            this.NavigatorKey = navigatorKey;
            this.DefaultTitle = defaultTitle;
            this.Routes = routes;
            this.OnGenerateRoute = onGenerateRoute;
            this.OnUnknownRoute = onUnknownRoute;
            this.NavigatorObservers = navigatorObservers;
        }
        /// <Summary>
        /// The widget builder for the default route of the tab view
        /// ([Navigator.defaultRouteName], which is `/`).
        ///
        /// If a [builder] is specified, then [routes] must not include an entry for `/`,
        /// as [builder] takes its place.
        ///
        /// Rebuilding a [CupertinoTabView] with a different [builder] will not clear
        /// its current navigation stack or update its descendant. Instead, trigger a
        /// rebuild from a descendant in its subtree. This can be done via methods such
        /// as:
        ///
        ///  * Calling [State.setState] on a descendant [StatefulWidget]'s [State]
        ///  * Modifying an [InheritedWidget] that a descendant registered itself
        ///    as a dependent to.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.WidgetBuilder Builder { get; set; }
        /// <Summary>
        /// A key to use when building this widget's [Navigator].
        ///
        /// If a [navigatorKey] is specified, the [Navigator] can be directly
        /// manipulated without first obtaining it from a [BuildContext] via
        /// [Navigator.of]: from the [navigatorKey], use the [GlobalKey.currentState]
        /// getter.
        ///
        /// If this is changed, a new [Navigator] will be created, losing all the
        /// tab's state in the process; in that case, the [navigatorObservers]
        /// must also be changed, since the previous observers will be attached to the
        /// previous navigator.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> NavigatorKey { get; set; }
        /// <Summary>
        /// The title of the default route.
        /// </Summary>
        public virtual string DefaultTitle { get; set; }
        /// <Summary>
        /// This tab view's routing table.
        ///
        /// When a named route is pushed with [Navigator.pushNamed] inside this tab view,
        /// the route name is looked up in this map. If the name is present,
        /// the associated [WidgetBuilder] is used to construct a [CupertinoPageRoute]
        /// that performs an appropriate transition to the new route.
        ///
        /// If the tab view only has one page, then you can specify it using [builder] instead.
        ///
        /// If [builder] is specified, then it implies an entry in this table for the
        /// [Navigator.defaultRouteName] route (`/`), and it is an error to
        /// redundantly provide such a route in the [routes] table.
        ///
        /// If a route is requested that is not specified in this table (or by
        /// [builder]), then the [onGenerateRoute] callback is called to build the page
        /// instead.
        ///
        /// This routing table is not shared with any routing tables of ancestor or
        /// descendant [Navigator]s.
        /// </Summary>
        public virtual Dictionary<string, object> Routes { get; set; }
        /// <Summary>
        /// The route generator callback used when the tab view is navigated to a named route.
        ///
        /// This is used if [routes] does not contain the requested route.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnGenerateRoute { get; set; }
        /// <Summary>
        /// Called when [onGenerateRoute] also fails to generate a route.
        ///
        /// This callback is typically used for error handling. For example, this
        /// callback might always generate a "not found" page that describes the route
        /// that wasn't found.
        ///
        /// The default implementation pushes a route that displays an ugly error
        /// message.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnUnknownRoute { get; set; }
        /// <Summary>
        /// The list of observers for the [Navigator] created in this tab view.
        ///
        /// This list of observers is not shared with ancestor or descendant [Navigator]s.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> NavigatorObservers { get; set; }

        public new FlutterSDK.Cupertino.Tabview._CupertinoTabViewState CreateState()
        {
            return new _CupertinoTabViewState();
        }



    }


    public class _CupertinoTabViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Tabview.CupertinoTabView>
    {
        public _CupertinoTabViewState()
        { }
        internal virtual FlutterSDK.Widgets.Heroes.HeroController _HeroController { get; set; }
        internal virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> _NavigatorObservers { get; set; }

        public new void InitState()
        {
            base.InitState();
            _HeroController = AppDefaultClass.CupertinoApp.CreateCupertinoHeroController();
            _UpdateObservers();
        }




        public new void DidUpdateWidget(FlutterSDK.Cupertino.Tabview.CupertinoTabView oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.NavigatorKey != oldWidget.NavigatorKey || Widget.NavigatorObservers != oldWidget.NavigatorObservers)
            {
                _UpdateObservers();
            }

        }




        private void _UpdateObservers()
        {
            _NavigatorObservers = List<NavigatorObserver>.From(Widget.NavigatorObservers);
            List<NavigatorObserver>.From(Widget.NavigatorObservers).Add(_HeroController);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Navigator(key: Widget.NavigatorKey, onGenerateRoute: _OnGenerateRoute, onUnknownRoute: _OnUnknownRoute, observers: _NavigatorObservers);
        }




        private FlutterSDK.Widgets.Navigator.Route<object> _OnGenerateRoute(FlutterSDK.Widgets.Navigator.RouteSettings settings)
        {
            string name = settings.Name;
            WidgetBuilder routeBuilder = default(WidgetBuilder);
            string title = default(string);
            if (name == NavigatorDefaultClass.Navigator.DefaultRouteName && Widget.Builder != null)
            {
                routeBuilder = Widget.Builder;
                title = Widget.DefaultTitle;
            }
            else if (Widget.Routes != null)
            {
                routeBuilder = Widget.Routes[name];
            }

            if (routeBuilder != null)
            {
                return new CupertinoPageRoute<object>(builder: routeBuilder, title: title, settings: settings);
            }

            if (Widget.OnGenerateRoute != null) return Widget.OnGenerateRoute(settings);
            return null;
        }




        private FlutterSDK.Widgets.Navigator.Route<object> _OnUnknownRoute(FlutterSDK.Widgets.Navigator.RouteSettings settings)
        {

            Route<object> result = Widget.OnUnknownRoute(settings);

            return result;
        }



    }

}
