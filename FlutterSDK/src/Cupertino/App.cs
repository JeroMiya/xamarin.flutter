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
        /// <Summary>
        /// Creates a CupertinoApp.
        ///
        /// At least one of [home], [routes], [onGenerateRoute], or [builder] must be
        /// non-null. If only [routes] is given, it must include an entry for the
        /// [Navigator.defaultRouteName] (`/`), since that is the route used when the
        /// application is launched with an intent that specifies an otherwise
        /// unsupported route.
        ///
        /// This class creates an instance of [WidgetsApp].
        ///
        /// The boolean arguments, [routes], and [navigatorObservers], must not be null.
        /// </Summary>
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
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.navigatorKey}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> NavigatorKey { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.home}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Home { get; set; }
        /// <Summary>
        /// The top-level [CupertinoTheme] styling.
        ///
        /// A null [theme] or unspecified [theme] attributes will default to iOS
        /// system values.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData Theme { get; set; }
        /// <Summary>
        /// The application's top-level routing table.
        ///
        /// When a named route is pushed with [Navigator.pushNamed], the route name is
        /// looked up in this map. If the name is present, the associated
        /// [WidgetBuilder] is used to construct a [CupertinoPageRoute] that performs
        /// an appropriate transition, including [Hero] animations, to the new route.
        ///
        /// {@macro flutter.widgets.widgetsApp.routes}
        /// </Summary>
        public virtual Dictionary<string, object> Routes { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.initialRoute}
        /// </Summary>
        public virtual string InitialRoute { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.onGenerateRoute}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnGenerateRoute { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.onGenerateInitialRoutes}
        /// </Summary>
        public virtual FlutterSDK.Widgets.App.InitialRouteListFactory OnGenerateInitialRoutes { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.onUnknownRoute}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnUnknownRoute { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.navigatorObservers}
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> NavigatorObservers { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.builder}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.TransitionBuilder Builder { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.title}
        ///
        /// This value is passed unmodified to [WidgetsApp.title].
        /// </Summary>
        public virtual string Title { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.onGenerateTitle}
        ///
        /// This value is passed unmodified to [WidgetsApp.onGenerateTitle].
        /// </Summary>
        public virtual FlutterSDK.Widgets.App.GenerateAppTitle OnGenerateTitle { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.color}
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.locale}
        /// </Summary>
        public virtual Locale Locale { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.localizationsDelegates}
        /// </Summary>
        public virtual Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> LocalizationsDelegates { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.localeListResolutionCallback}
        ///
        /// This callback is passed along to the [WidgetsApp] built by this widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.App.LocaleListResolutionCallback LocaleListResolutionCallback { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.localeResolutionCallback}
        ///
        /// This callback is passed along to the [WidgetsApp] built by this widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.App.LocaleResolutionCallback LocaleResolutionCallback { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.supportedLocales}
        ///
        /// It is passed along unmodified to the [WidgetsApp] built by this widget.
        /// </Summary>
        public virtual Iterable<Locale> SupportedLocales { get; set; }
        /// <Summary>
        /// Turns on a performance overlay.
        ///
        /// See also:
        ///
        ///  * <https://flutter.dev/debugging/#performanceoverlay>
        /// </Summary>
        public virtual bool ShowPerformanceOverlay { get; set; }
        /// <Summary>
        /// Turns on checkerboarding of raster cache images.
        /// </Summary>
        public virtual bool CheckerboardRasterCacheImages { get; set; }
        /// <Summary>
        /// Turns on checkerboarding of layers rendered to offscreen bitmaps.
        /// </Summary>
        public virtual bool CheckerboardOffscreenLayers { get; set; }
        /// <Summary>
        /// Turns on an overlay that shows the accessibility information
        /// reported by the framework.
        /// </Summary>
        public virtual bool ShowSemanticsDebugger { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.debugShowCheckedModeBanner}
        /// </Summary>
        public virtual bool DebugShowCheckedModeBanner { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.shortcuts}
        /// {@tool snippet}
        /// This example shows how to add a single shortcut for
        /// [LogicalKeyboardKey.select] to the default shortcuts without needing to
        /// add your own [Shortcuts] widget.
        ///
        /// Alternatively, you could insert a [Shortcuts] widget with just the mapping
        /// you want to add between the [WidgetsApp] and its child and get the same
        /// effect.
        ///
        /// ```dart
        /// Widget build(BuildContext context) {
        ///   return WidgetsApp(
        ///     shortcuts: <LogicalKeySet, Intent>{
        ///       ... WidgetsApp.defaultShortcuts,
        ///       LogicalKeySet(LogicalKeyboardKey.select): const Intent(ActivateAction.key),
        ///     },
        ///     color: const Color(0xFFFF0000),
        ///     builder: (BuildContext context, Widget child) {
        ///       return const Placeholder();
        ///     },
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// {@macro flutter.widgets.widgetsApp.shortcuts.seeAlso}
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> Shortcuts { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.actions}
        /// {@tool snippet}
        /// This example shows how to add a single action handling an
        /// [ActivateAction] to the default actions without needing to
        /// add your own [Actions] widget.
        ///
        /// Alternatively, you could insert a [Actions] widget with just the mapping
        /// you want to add between the [WidgetsApp] and its child and get the same
        /// effect.
        ///
        /// ```dart
        /// Widget build(BuildContext context) {
        ///   return WidgetsApp(
        ///     actions: <LocalKey, ActionFactory>{
        ///       ... WidgetsApp.defaultActions,
        ///       ActivateAction.key: () => CallbackAction(
        ///         ActivateAction.key,
        ///         onInvoke: (FocusNode focusNode, Intent intent) {
        ///           // Do something here...
        ///         },
        ///       ),
        ///     },
        ///     color: const Color(0xFFFF0000),
        ///     builder: (BuildContext context, Widget child) {
        ///       return const Placeholder();
        ///     },
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// {@macro flutter.widgets.widgetsApp.actions.seeAlso}
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> Actions { get; set; }

        public new FlutterSDK.Cupertino.App._CupertinoAppState CreateState() => new _CupertinoAppState();



        /// <Summary>
        /// The [HeroController] used for Cupertino page transitions.
        ///
        /// Used by [CupertinoTabView] and [CupertinoApp].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Heroes.HeroController CreateCupertinoHeroController() => new HeroController();


    }


    public class _AlwaysCupertinoScrollBehavior : FlutterSDK.Widgets.Scrollconfiguration.ScrollBehavior
    {
        public _AlwaysCupertinoScrollBehavior()
        { }

        public new FlutterSDK.Widgets.Framework.Widget BuildViewportChrome(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection)
        {
            return child;
        }




        public new FlutterSDK.Widgets.Scrollphysics.ScrollPhysics GetScrollPhysics(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new BouncingScrollPhysics();
        }



    }


    public class _CupertinoAppState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.App.CupertinoApp>
    {
        public _CupertinoAppState()
        { }
        internal virtual FlutterSDK.Widgets.Heroes.HeroController _HeroController { get; set; }
        internal virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> _NavigatorObservers { get; set; }
        internal virtual Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> _LocalizationsDelegates { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

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



    }

}
