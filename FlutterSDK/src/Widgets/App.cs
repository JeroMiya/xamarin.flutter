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
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Typography;
using FlutterSDK.Scheduler;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
namespace FlutterSDK.Widgets.App
{
    public delegate Locale LocaleListResolutionCallback(List<Locale> locales, Iterable<Locale> supportedLocales);
    public delegate Locale LocaleResolutionCallback(Locale locale, Iterable<Locale> supportedLocales);
    public delegate string GenerateAppTitle(FlutterSDK.Widgets.Framework.BuildContext context);
    public delegate FlutterSDK.Widgets.Pages.PageRoute<T> PageRouteFactory(FlutterSDK.Widgets.Navigator.RouteSettings settings, FlutterSDK.Widgets.Framework.WidgetBuilder builder);
    public delegate List<FlutterSDK.Widgets.Navigator.Route<object>> InitialRouteListFactory(string initialRoute);
    internal static class AppDefaultClass
    {
    }

    /// <Summary>
    /// A convenience widget that wraps a number of widgets that are commonly
    /// required for an application.
    ///
    /// One of the primary roles that [WidgetsApp] provides is binding the system
    /// back button to popping the [Navigator] or quitting the application.
    ///
    /// It is used by both [MaterialApp] and [CupertinoApp] to implement base
    /// functionality for an app.
    ///
    /// Find references to many of the widgets that [WidgetsApp] wraps in the "See
    /// also" section.
    ///
    /// See also:
    ///
    ///  * [CheckedModeBanner], which displays a [Banner] saying "DEBUG" when
    ///    running in checked mode.
    ///  * [DefaultTextStyle], the text style to apply to descendant [Text] widgets
    ///    without an explicit style.
    ///  * [MediaQuery], which establishes a subtree in which media queries resolve
    ///    to a [MediaQueryData].
    ///  * [Localizations], which defines the [Locale] for its `child`.
    ///  * [Title], a widget that describes this app in the operating system.
    ///  * [Navigator], a widget that manages a set of child widgets with a stack
    ///    discipline.
    ///  * [Overlay], a widget that manages a [Stack] of entries that can be managed
    ///    independently.
    ///  * [SemanticsDebugger], a widget that visualizes the semantics for the child.
    /// </Summary>
    public class WidgetsApp : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public WidgetsApp(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> navigatorKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState>), FlutterSDK.Widgets.Navigator.RouteFactory onGenerateRoute = default(FlutterSDK.Widgets.Navigator.RouteFactory), FlutterSDK.Widgets.App.InitialRouteListFactory onGenerateInitialRoutes = default(FlutterSDK.Widgets.App.InitialRouteListFactory), FlutterSDK.Widgets.Navigator.RouteFactory onUnknownRoute = default(FlutterSDK.Widgets.Navigator.RouteFactory), List<FlutterSDK.Widgets.Navigator.NavigatorObserver> navigatorObservers = default(List<FlutterSDK.Widgets.Navigator.NavigatorObserver>), string initialRoute = default(string), FlutterSDK.Widgets.App.PageRouteFactory pageRouteBuilder = default(FlutterSDK.Widgets.App.PageRouteFactory), FlutterSDK.Widgets.Framework.Widget home = default(FlutterSDK.Widgets.Framework.Widget), Dictionary<string, object> routes = default(Dictionary<string, object>), FlutterSDK.Widgets.Framework.TransitionBuilder builder = default(FlutterSDK.Widgets.Framework.TransitionBuilder), string title = default(string), FlutterSDK.Widgets.App.GenerateAppTitle onGenerateTitle = default(FlutterSDK.Widgets.App.GenerateAppTitle), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), Locale locale = default(Locale), Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> localizationsDelegates = default(Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>>), FlutterSDK.Widgets.App.LocaleListResolutionCallback localeListResolutionCallback = default(FlutterSDK.Widgets.App.LocaleListResolutionCallback), FlutterSDK.Widgets.App.LocaleResolutionCallback localeResolutionCallback = default(FlutterSDK.Widgets.App.LocaleResolutionCallback), Iterable<Locale> supportedLocales = default(Iterable<Locale>), bool showPerformanceOverlay = false, bool checkerboardRasterCacheImages = false, bool checkerboardOffscreenLayers = false, bool showSemanticsDebugger = false, bool debugShowWidgetInspector = false, bool debugShowCheckedModeBanner = true, FlutterSDK.Widgets.Widgetinspector.InspectorSelectButtonBuilder inspectorSelectButtonBuilder = default(FlutterSDK.Widgets.Widgetinspector.InspectorSelectButtonBuilder), Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> shortcuts = default(Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent>), Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> actions = default(Dictionary<FlutterSDK.Foundation.Key.LocalKey, object>))
        : base(key: key)
        {
            this.NavigatorKey = navigatorKey;
            this.OnGenerateRoute = onGenerateRoute;
            this.OnGenerateInitialRoutes = onGenerateInitialRoutes;
            this.OnUnknownRoute = onUnknownRoute;
            this.NavigatorObservers = navigatorObservers;
            this.InitialRoute = initialRoute;
            this.PageRouteBuilder = pageRouteBuilder;
            this.Home = home;
            this.Routes = routes;
            this.Builder = builder;
            this.Title = title;
            this.OnGenerateTitle = onGenerateTitle;
            this.TextStyle = textStyle;
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
            this.DebugShowWidgetInspector = debugShowWidgetInspector;
            this.DebugShowCheckedModeBanner = debugShowCheckedModeBanner;
            this.InspectorSelectButtonBuilder = inspectorSelectButtonBuilder;
            this.Shortcuts = shortcuts;
            this.Actions = actions;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> NavigatorKey { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnGenerateRoute { get; set; }
        public virtual FlutterSDK.Widgets.App.InitialRouteListFactory OnGenerateInitialRoutes { get; set; }
        public virtual FlutterSDK.Widgets.App.PageRouteFactory PageRouteBuilder { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Home { get; set; }
        public virtual Dictionary<string, object> Routes { get; set; }
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnUnknownRoute { get; set; }
        public virtual string InitialRoute { get; set; }
        public virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> NavigatorObservers { get; set; }
        public virtual FlutterSDK.Widgets.Framework.TransitionBuilder Builder { get; set; }
        public virtual string Title { get; set; }
        public virtual FlutterSDK.Widgets.App.GenerateAppTitle OnGenerateTitle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
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
        public virtual bool DebugShowWidgetInspector { get; set; }
        public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelectButtonBuilder InspectorSelectButtonBuilder { get; set; }
        public virtual bool DebugShowCheckedModeBanner { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> Shortcuts { get; set; }
        public virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> Actions { get; set; }
        public virtual bool ShowPerformanceOverlayOverride { get; set; }
        public virtual bool DebugShowWidgetInspectorOverride { get; set; }
        public virtual bool DebugAllowBannerOverride { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> _DefaultShortcuts { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> _DefaultWebShortcuts { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> _DefaultMacOsShortcuts { get; set; }
        public virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> DefaultActions { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> DefaultShortcuts { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.App._WidgetsAppState CreateState() => new _WidgetsAppState();


        #endregion
    }


    public class _WidgetsAppState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.App.WidgetsApp>, IWidgetsBindingObserver
    {
        #region constructors
        public _WidgetsAppState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> _Navigator { get; set; }
        internal virtual Locale _Locale { get; set; }
        internal virtual Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> _LocalizationsDelegates { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState()
        {
            base.InitState();
            _UpdateNavigator();
            _Locale = _ResolveLocales(BindingDefaultClass.WidgetsBinding.Instance.Window.Locales, Widget.SupportedLocales);
            BindingDefaultClass.WidgetsBinding.Instance.AddObserver(this);
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.App.WidgetsApp oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.NavigatorKey != oldWidget.NavigatorKey) _UpdateNavigator();
        }




        public new void Dispose()
        {
            BindingDefaultClass.WidgetsBinding.Instance.RemoveObserver(this);
            base.Dispose();
        }




        private void _UpdateNavigator()
        {
            _Navigator = Widget.NavigatorKey ?? new GlobalObjectKey<NavigatorState>(this);
        }




        private FlutterSDK.Widgets.Navigator.Route<object> _OnGenerateRoute(FlutterSDK.Widgets.Navigator.RouteSettings settings)
        {
            string name = settings.Name;
            WidgetBuilder pageContentBuilder = name == NavigatorDefaultClass.Navigator.DefaultRouteName && Widget.Home != null ? (BuildContext context) => =>Widget.Home:Widget.Routes[name];
            if (pageContentBuilder != null)
            {

                Route<object> route = Widget.PageRouteBuilder(settings, pageContentBuilder);

                return route;
            }

            if (Widget.OnGenerateRoute != null) return Widget.OnGenerateRoute(settings);
            return null;
        }




        private FlutterSDK.Widgets.Navigator.Route<object> _OnUnknownRoute(FlutterSDK.Widgets.Navigator.RouteSettings settings)
        {

            Route<object> result = Widget.OnUnknownRoute(settings);

            return result;
        }




        public new async Future<bool> DidPopRoute()
        {

            NavigatorState navigator = _Navigator?.CurrentState;
            if (navigator == null) return false;
            return await navigator.MaybePop();
        }




        public new async Future<bool> DidPushRoute(string route)
        {

            NavigatorState navigator = _Navigator?.CurrentState;
            if (navigator == null) return false;
            navigator.PushNamed(route);
            return true;
        }




        private Locale _ResolveLocales(List<Locale> preferredLocales, Iterable<Locale> supportedLocales)
        {
            if (Widget.LocaleListResolutionCallback != null)
            {
                Locale locale = Widget.LocaleListResolutionCallback(preferredLocales, Widget.SupportedLocales);
                if (locale != null) return locale;
            }

            if (Widget.LocaleResolutionCallback != null)
            {
                Locale locale = Widget.LocaleResolutionCallback(preferredLocales != null && preferredLocales.IsNotEmpty ? preferredLocales.First : null, Widget.SupportedLocales);
                if (locale != null) return locale;
            }

            return BasicLocaleListResolution(preferredLocales, supportedLocales);
        }




        /// <Summary>
        /// The default locale resolution algorithm.
        ///
        /// Custom resolution algorithms can be provided through
        /// [WidgetsApp.localeListResolutionCallback] or
        /// [WidgetsApp.localeResolutionCallback].
        ///
        /// When no custom locale resolution algorithms are provided or if both fail
        /// to resolve, Flutter will default to calling this algorithm.
        ///
        /// This algorithm prioritizes speed at the cost of slightly less appropriate
        /// resolutions for edge cases.
        ///
        /// This algorithm will resolve to the earliest preferred locale that
        /// matches the most fields, prioritizing in the order of perfect match,
        /// languageCode+countryCode, languageCode+scriptCode, languageCode-only.
        ///
        /// In the case where a locale is matched by languageCode-only and is not the
        /// default (first) locale, the next preferred locale with a
        /// perfect match can supersede the languageCode-only match if it exists.
        ///
        /// When a preferredLocale matches more than one supported locale, it will
        /// resolve to the first matching locale listed in the supportedLocales.
        ///
        /// When all preferred locales have been exhausted without a match, the first
        /// countryCode only match will be returned.
        ///
        /// When no match at all is found, the first (default) locale in
        /// [supportedLocales] will be returned.
        ///
        /// To summarize, the main matching priority is:
        ///
        ///  1. [Locale.languageCode], [Locale.scriptCode], and [Locale.countryCode]
        ///  1. [Locale.languageCode] and [Locale.scriptCode] only
        ///  1. [Locale.languageCode] and [Locale.countryCode] only
        ///  1. [Locale.languageCode] only (with caveats, see above)
        ///  1. [Locale.countryCode] only when all [preferredLocales] fail to match
        ///  1. Returns the first element of [supportedLocales] as a fallback
        ///
        /// This algorithm does not take language distance (how similar languages are to each other)
        /// into account, and will not handle edge cases such as resolving `de` to `fr` rather than `zh`
        /// when `de` is not supported and `zh` is listed before `fr` (German is closer to French
        /// than Chinese).
        /// </Summary>
        public virtual Locale BasicLocaleListResolution(List<Locale> preferredLocales, Iterable<Locale> supportedLocales)
        {
            if (preferredLocales == null || preferredLocales.IsEmpty())
            {
                return supportedLocales.First;
            }

            Dictionary<string, Locale> allSupportedLocales = new HashMap<string, Locale>();
            Dictionary<string, Locale> languageAndCountryLocales = new HashMap<string, Locale>();
            Dictionary<string, Locale> languageAndScriptLocales = new HashMap<string, Locale>();
            Dictionary<string, Locale> languageLocales = new HashMap<string, Locale>();
            Dictionary<string, Locale> countryLocales = new HashMap<string, Locale>();
            foreach (Locale locale in supportedLocales)
            {
                allSupportedLocales[$"'{locale.LanguageCode}_{locale.ScriptCode}_{locale.CountryCode}'"] = (allSupportedLocales[$"'{locale.LanguageCode}_{locale.ScriptCode}_{locale.CountryCode}'"] == null ? locale : allSupportedLocales[$"'{locale.LanguageCode}_{locale.ScriptCode}_{locale.CountryCode}'"]);
                languageAndScriptLocales[$"'{locale.LanguageCode}_{locale.ScriptCode}'"] = (languageAndScriptLocales[$"'{locale.LanguageCode}_{locale.ScriptCode}'"] == null ? locale : languageAndScriptLocales[$"'{locale.LanguageCode}_{locale.ScriptCode}'"]);
                languageAndCountryLocales[$"'{locale.LanguageCode}_{locale.CountryCode}'"] = (languageAndCountryLocales[$"'{locale.LanguageCode}_{locale.CountryCode}'"] == null ? locale : languageAndCountryLocales[$"'{locale.LanguageCode}_{locale.CountryCode}'"]);
                languageLocales[locale.LanguageCode] = (languageLocales[locale.LanguageCode] == null ? locale : languageLocales[locale.LanguageCode]);
                countryLocales[locale.CountryCode] = (countryLocales[locale.CountryCode] == null ? locale : countryLocales[locale.CountryCode]);
            }

            Locale matchesLanguageCode = default(Locale);
            Locale matchesCountryCode = default(Locale);
            for (int localeIndex = 0; localeIndex < preferredLocales.Count; localeIndex += 1)
            {
                Locale userLocale = preferredLocales[localeIndex];
                if (allSupportedLocales.ContainsKey($"'{userLocale.LanguageCode}_{userLocale.ScriptCode}_{userLocale.CountryCode}'"))
                {
                    return userLocale;
                }

                if (userLocale.ScriptCode != null)
                {
                    Locale match = languageAndScriptLocales[$"'{userLocale.LanguageCode}_{userLocale.ScriptCode}'"];
                    if (match != null)
                    {
                        return match;
                    }

                }

                if (userLocale.CountryCode != null)
                {
                    Locale match = languageAndCountryLocales[$"'{userLocale.LanguageCode}_{userLocale.CountryCode}'"];
                    if (match != null)
                    {
                        return match;
                    }

                }

                if (matchesLanguageCode != null)
                {
                    return matchesLanguageCode;
                }

                Locale match = languageLocales[userLocale.LanguageCode];
                if (match != null)
                {
                    matchesLanguageCode = match;
                    if (localeIndex == 0 && !(localeIndex + 1 < preferredLocales.Count && preferredLocales[localeIndex + 1].LanguageCode == userLocale.LanguageCode))
                    {
                        return matchesLanguageCode;
                    }

                }

                if (matchesCountryCode == null && userLocale.CountryCode != null)
                {
                    match = countryLocales[userLocale.CountryCode];
                    if (match != null)
                    {
                        matchesCountryCode = match;
                    }

                }

            }

            Locale resolvedLocale = matchesLanguageCode ?? matchesCountryCode ?? supportedLocales.First;
            return resolvedLocale;
        }




        public new void DidChangeLocales(List<Locale> locales)
        {
            Locale newLocale = _ResolveLocales(locales, Widget.SupportedLocales);
            if (newLocale != _Locale)
            {
                SetState(() =>
                {
                    _Locale = newLocale;
                }
                );
            }

        }




        private bool _DebugCheckLocalizations(Locale appLocale)
        {

            return true;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Widget navigator = default(Widget);
            if (_Navigator != null)
            {
                navigator = new Navigator(key: _Navigator, initialRoute: BindingDefaultClass.WidgetsBinding.Instance.Window.DefaultRouteName != NavigatorDefaultClass.Navigator.DefaultRouteName ? BindingDefaultClass.WidgetsBinding.Instance.Window.DefaultRouteName : Widget.InitialRoute ?? BindingDefaultClass.WidgetsBinding.Instance.Window.DefaultRouteName, onGenerateRoute: _OnGenerateRoute, onGenerateInitialRoutes: Widget.OnGenerateInitialRoutes == null ? NavigatorDefaultClass.Navigator.DefaultGenerateInitialRoutes : (NavigatorState navigator, string initialRouteName) =>
                {
                    return Widget.OnGenerateInitialRoutes(initialRouteName);
                }
                , onUnknownRoute: _OnUnknownRoute, observers: Widget.NavigatorObservers);
            }

            Widget result = default(Widget);
            if (Widget.Builder != null)
            {
                result = new Builder(builder: (BuildContext context) =>
                {
                    return Widget.Builder(context, navigator);
                }
                );
            }
            else
            {

                result = navigator;
            }

            if (Widget.TextStyle != null)
            {
                result = new DefaultTextStyle(style: Widget.TextStyle, child: result);
            }

            PerformanceOverlay performanceOverlay = default(PerformanceOverlay);
            if (Widget.ShowPerformanceOverlay || AppDefaultClass.WidgetsApp.ShowPerformanceOverlayOverride)
            {
                performanceOverlay = PerformanceOverlay.AllEnabled(checkerboardRasterCacheImages: Widget.CheckerboardRasterCacheImages, checkerboardOffscreenLayers: Widget.CheckerboardOffscreenLayers);
            }
            else if (Widget.CheckerboardRasterCacheImages || Widget.CheckerboardOffscreenLayers)
            {
                performanceOverlay = new PerformanceOverlay(checkerboardRasterCacheImages: Widget.CheckerboardRasterCacheImages, checkerboardOffscreenLayers: Widget.CheckerboardOffscreenLayers);
            }

            if (performanceOverlay != null)
            {
                result = new Stack(children: new List<Widget>() { result, new Positioned(top: 0.0, left: 0.0, right: 0.0, child: performanceOverlay) });
            }

            if (Widget.ShowSemanticsDebugger)
            {
                result = new SemanticsDebugger(child: result);
            }


            Widget title = default(Widget);
            if (Widget.OnGenerateTitle != null)
            {
                title = new Builder(builder: (BuildContext context) =>
                {
                    string title = Widget.OnGenerateTitle(context);

                    return new Title(title: title, color: Widget.Color, child: result);
                }
                );
            }
            else
            {
                title = new Title(title: Widget.Title, color: Widget.Color, child: result);
            }

            Locale appLocale = Widget.Locale != null ? _ResolveLocales(new List<Locale>() { Widget.Locale }, Widget.SupportedLocales) : _Locale;

            return new Shortcuts(shortcuts: Widget.Shortcuts ?? AppDefaultClass.WidgetsApp.DefaultShortcuts, debugLabel: "<Default WidgetsApp Shortcuts>", child: new Actions(actions: Widget.Actions ?? AppDefaultClass.WidgetsApp.DefaultActions, child: new FocusTraversalGroup(policy: new ReadingOrderTraversalPolicy(), child: new _MediaQueryFromWindow(child: new Localizations(locale: appLocale, delegates: _LocalizationsDelegates.ToList(), child: title)))));
        }



        #endregion
    }


    /// <Summary>
    /// Builds [MediaQuery] from `window` by listening to [WidgetsBinding].
    ///
    /// It is performed in a standalone widget to rebuild **only** [MediaQuery] and
    /// its dependents when `window` changes, instead of rebuilding the entire widget tree.
    /// </Summary>
    public class _MediaQueryFromWindow : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _MediaQueryFromWindow(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.App._MediaQueryFromWindowsState CreateState() => new _MediaQueryFromWindowsState();


        #endregion
    }


    public class _MediaQueryFromWindowsState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.App._MediaQueryFromWindow>, IWidgetsBindingObserver
    {
        #region constructors
        public _MediaQueryFromWindowsState()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public new void InitState()
        {
            base.InitState();
            BindingDefaultClass.WidgetsBinding.Instance.AddObserver(this);
        }




        public new void DidChangeAccessibilityFeatures()
        {
            SetState(() =>
            {
            }
            );
        }




        public new void DidChangeMetrics()
        {
            SetState(() =>
            {
            }
            );
        }




        public new void DidChangeTextScaleFactor()
        {
            SetState(() =>
            {
            }
            );
        }




        public new void DidChangePlatformBrightness()
        {
            SetState(() =>
            {
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new MediaQuery(data: MediaQueryData.FromWindow(BindingDefaultClass.WidgetsBinding.Instance.Window), child: Widget.Child);
        }




        public new void Dispose()
        {
            BindingDefaultClass.WidgetsBinding.Instance.RemoveObserver(this);
            base.Dispose();
        }



        #endregion
    }

}
