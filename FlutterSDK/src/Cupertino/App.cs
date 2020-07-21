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
namespace FlutterSDK.Cupertino.App
{
    internal static class AppDefaultClass
    {
    }

    /// <Summary>
    /// An application that uses Cupertino design.
    ///
    /// A convenience widget that wraps a number of widgets that are commonly
    /// required for an iOS-design targeting application. It builds upon a
    /// [WidgetsApp] by iOS specific defaulting such as fonts and scrolling
    /// physics.
    ///
    /// The [CupertinoApp] configures the top-level [Navigator] to search for routes
    /// in the following order:
    ///
    ///  1. For the `/` route, the [home] property, if non-null, is used.
    ///
    ///  2. Otherwise, the [routes] table is used, if it has an entry for the route.
    ///
    ///  3. Otherwise, [onGenerateRoute] is called, if provided. It should return a
    ///     non-null value for any _valid_ route not handled by [home] and [routes].
    ///
    ///  4. Finally if all else fails [onUnknownRoute] is called.
    ///
    /// If [home], [routes], [onGenerateRoute], and [onUnknownRoute] are all null,
    /// and [builder] is not null, then no [Navigator] is created.
    ///
    /// This widget also configures the observer of the top-level [Navigator] (if
    /// any) to perform [Hero] animations.
    ///
    /// Use this widget with caution on Android since it may produce behaviors
    /// Android users are not expecting such as:
    ///
    ///  * Pages will be dismissible via a back swipe.
    ///  * Scrolling past extremities will trigger iOS-style spring overscrolls.
    ///  * The San Francisco font family is unavailable on Android and can result
    ///    in undefined font behavior.
    ///
    /// See also:
    ///
    ///  * [CupertinoPageScaffold], which provides a standard page layout default
    ///    with nav bars.
    ///  * [Navigator], which is used to manage the app's stack of pages.
    ///  * [CupertinoPageRoute], which defines an app page that transitions in an
    ///    iOS-specific way.
    ///  * [WidgetsApp], which defines the basic app elements but does not depend
    ///    on the Cupertino library.
    /// </Summary>
    public class CupertinoApp : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public CupertinoApp(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> navigatorKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState>), FlutterSDK.Widgets.Framework.Widget home = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Cupertino.Theme.CupertinoThemeData theme = default(FlutterSDK.Cupertino.Theme.CupertinoThemeData), Dictionary<string, object> routes = default(Dictionary<string, object>), string initialRoute = default(string), FlutterSDK.Widgets.Navigator.RouteFactory onGenerateRoute = default(FlutterSDK.Widgets.Navigator.RouteFactory), FlutterSDK.Widgets.App.InitialRouteListFactory onGenerateInitialRoutes = default(FlutterSDK.Widgets.App.InitialRouteListFactory), FlutterSDK.Widgets.Navigator.RouteFactory onUnknownRoute = default(FlutterSDK.Widgets.Navigator.RouteFactory), List<FlutterSDK.Widgets.Navigator.NavigatorObserver> navigatorObservers = default(List<FlutterSDK.Widgets.Navigator.NavigatorObserver>), FlutterSDK.Widgets.Framework.TransitionBuilder builder = default(FlutterSDK.Widgets.Framework.TransitionBuilder), string title = default(string), FlutterSDK.Widgets.App.GenerateAppTitle onGenerateTitle = default(FlutterSDK.Widgets.App.GenerateAppTitle), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), Locale locale = default(Locale), Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> localizationsDelegates = default(Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>>), FlutterSDK.Widgets.App.LocaleListResolutionCallback localeListResolutionCallback = default(FlutterSDK.Widgets.App.LocaleListResolutionCallback), FlutterSDK.Widgets.App.LocaleResolutionCallback localeResolutionCallback = default(FlutterSDK.Widgets.App.LocaleResolutionCallback), Iterable<Locale> supportedLocales = default(Iterable<Locale>), bool showPerformanceOverlay = false, bool checkerboardRasterCacheImages = false, bool checkerboardOffscreenLayers = false, bool showSemanticsDebugger = false, bool debugShowCheckedModeBanner = true, Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> shortcuts = default(Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent>), Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> actions = default(Dictionary<FlutterSDK.Foundation.Key.LocalKey, object>))
        : base(key: key)
        {
            this.NavigatorKey = navigatorKey;
            this.Home = home;
            this.Theme = theme;
            this.Routes = routes;
            this.InitialRoute = initialRoute;
            this.OnGenerateRoute = onGenerateRoute;
            this.OnGenerateInitialRoutes = onGenerateInitialRoutes;
            this.OnUnknownRoute = onUnknownRoute;
            this.NavigatorObservers = navigatorObservers;
            this.Builder = builder;
            this.Title = title;
            this.OnGenerateTitle = onGenerateTitle;
            this.Color = color;
            this.Locale = locale;
            this.LocalizationsDelegates = localizationsDelegates;
            this.LocaleListResolutionCallback = localeListResolutionCallback;
            this.LocaleResolutionCallback = localeResolutionCallback;
            this.SupportedLocales = supportedLocales;
            this.ShowPerformanceOverlay = showPerformanceOverlay;
            this.CheckerboardRasterCacheImages = checkerboardRasterCacheImages;
            this.CheckerboardOffscreenLayers = checkerboardOffscreenLayers;
            this.ShowSemanticsDebugger = showSemanticsDebugger;
            this.DebugShowCheckedModeBanner = debugShowCheckedModeBanner;
            this.Shortcuts = shortcuts;
            this.Actions = actions;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> NavigatorKey { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Home { get; set; }
        public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData Theme { get; set; }
        public virtual Dictionary<string, object> Routes { get; set; }
        public virtual string InitialRoute { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnGenerateRoute { get; set; }
        public virtual FlutterSDK.Widgets.App.InitialRouteListFactory OnGenerateInitialRoutes { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnUnknownRoute { get; set; }
        public virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> NavigatorObservers { get; set; }
        public virtual FlutterSDK.Widgets.Framework.TransitionBuilder Builder { get; set; }
        public virtual string Title { get; set; }
        public virtual FlutterSDK.Widgets.App.GenerateAppTitle OnGenerateTitle { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual Locale Locale { get; set; }
        public virtual Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> LocalizationsDelegates { get; set; }
        public virtual FlutterSDK.Widgets.App.LocaleListResolutionCallback LocaleListResolutionCallback { get; set; }
        public virtual FlutterSDK.Widgets.App.LocaleResolutionCallback LocaleResolutionCallback { get; set; }
        public virtual Iterable<Locale> SupportedLocales { get; set; }
        public virtual bool ShowPerformanceOverlay { get; set; }
        public virtual bool CheckerboardRasterCacheImages { get; set; }
        public virtual bool CheckerboardOffscreenLayers { get; set; }
        public virtual bool ShowSemanticsDebugger { get; set; }
        public virtual bool DebugShowCheckedModeBanner { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> Shortcuts { get; set; }
        public virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> Actions { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Cupertino.App._CupertinoAppState CreateState() => new _CupertinoAppState();



        /// <Summary>
        /// The [HeroController] used for Cupertino page transitions.
        ///
        /// Used by [CupertinoTabView] and [CupertinoApp].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Heroes.HeroController CreateCupertinoHeroController() => new HeroController();


        #endregion
    }


    public class _AlwaysCupertinoScrollBehavior : FlutterSDK.Widgets.Scrollconfiguration.ScrollBehavior
    {
        #region constructors
        public _AlwaysCupertinoScrollBehavior()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget BuildViewportChrome(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection)
        {
            return child;
        }




        public new FlutterSDK.Widgets.Scrollphysics.ScrollPhysics GetScrollPhysics(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new BouncingScrollPhysics();
        }



        #endregion
    }


    public class _CupertinoAppState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.App.CupertinoApp>
    {
        #region constructors
        public _CupertinoAppState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Heroes.HeroController _HeroController { get; set; }
        internal virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> _NavigatorObservers { get; set; }
        internal virtual Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> _LocalizationsDelegates { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState()
        {
            base.InitState();
            _HeroController = AppDefaultClass.CupertinoApp.CreateCupertinoHeroController();
            _UpdateNavigator();
        }




        public new void DidUpdateWidget(FlutterSDK.Cupertino.App.CupertinoApp oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.NavigatorKey != oldWidget.NavigatorKey)
            {
                _HeroController = AppDefaultClass.CupertinoApp.CreateCupertinoHeroController();
            }

            _UpdateNavigator();
        }




        private void _UpdateNavigator()
        {
            if (Widget.Home != null || Widget.Routes.IsNotEmpty || Widget.OnGenerateRoute != null || Widget.OnUnknownRoute != null)
            {
                _NavigatorObservers = List<NavigatorObserver>.From(Widget.NavigatorObservers);
                List<NavigatorObserver>.From(Widget.NavigatorObservers).Add(_HeroController);
            }
            else
            {
                _NavigatorObservers = new List<NavigatorObserver>() { };
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            CupertinoThemeData effectiveThemeData = Widget.Theme ?? new CupertinoThemeData();
            return new ScrollConfiguration(behavior: new _AlwaysCupertinoScrollBehavior(), child: new CupertinoUserInterfaceLevel(data: CupertinoUserInterfaceLevelData.Base, child: new CupertinoTheme(data: effectiveThemeData, child: new Builder(builder: (BuildContext context) =>
            {
                return new WidgetsApp(key: new GlobalObjectKey(this), navigatorKey: Widget.NavigatorKey, navigatorObservers: _NavigatorObservers, pageRouteBuilder: (RouteSettings settings, WidgetBuilder builder) => =>new CupertinoPageRoute<T>(settings: settings, builder: builder), home: Widget.Home, routes: Widget.Routes, initialRoute: Widget.InitialRoute, onGenerateRoute: Widget.OnGenerateRoute, onGenerateInitialRoutes: Widget.OnGenerateInitialRoutes, onUnknownRoute: Widget.OnUnknownRoute, builder: Widget.Builder, title: Widget.Title, onGenerateTitle: Widget.OnGenerateTitle, textStyle: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.TextStyle, color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.Color ?? effectiveThemeData.PrimaryColor, context), locale: Widget.Locale, localizationsDelegates: _LocalizationsDelegates, localeResolutionCallback: Widget.LocaleResolutionCallback, localeListResolutionCallback: Widget.LocaleListResolutionCallback, supportedLocales: Widget.SupportedLocales, showPerformanceOverlay: Widget.ShowPerformanceOverlay, checkerboardRasterCacheImages: Widget.CheckerboardRasterCacheImages, checkerboardOffscreenLayers: Widget.CheckerboardOffscreenLayers, showSemanticsDebugger: Widget.ShowSemanticsDebugger, debugShowCheckedModeBanner: Widget.DebugShowCheckedModeBanner, inspectorSelectButtonBuilder: (BuildContext context, VoidCallback onPressed) =>
                {
                    return CupertinoButton.Filled(child: new Icon(IconsDefaultClass.CupertinoIcons.Search, size: 28.0, color: ColorsDefaultClass.CupertinoColors.White), padding: EdgeinsetsDefaultClass.EdgeInsets.Zero, onPressed: onPressed);
                }
                , shortcuts: Widget.Shortcuts, actions: Widget.Actions);
            }
            ))));
        }



        #endregion
    }

}
