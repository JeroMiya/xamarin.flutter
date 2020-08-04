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
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
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
using FlutterSDK.Scheduler;
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
namespace FlutterSDK.Widgets.App
{
    /// <Summary>
    /// The signature of [WidgetsApp.localeListResolutionCallback].
    ///
    /// A [LocaleListResolutionCallback] is responsible for computing the locale of the app's
    /// [Localizations] object when the app starts and when user changes the list of
    /// locales for the device.
    ///
    /// The [locales] list is the device's preferred locales when the app started, or the
    /// device's preferred locales the user selected after the app was started. This list
    /// is in order of preference. If this list is null or empty, then Flutter has not yet
    /// received the locale information from the platform. The [supportedLocales] parameter
    /// is just the value of [WidgetsApp.supportedLocales].
    ///
    /// See also:
    ///
    ///  * [LocaleResolutionCallback], which takes only one default locale (instead of a list)
    ///    and is attempted only after this callback fails or is null. [LocaleListResolutionCallback]
    ///    is recommended over [LocaleResolutionCallback].
    /// </Summary>
    public delegate Locale LocaleListResolutionCallback(List<Locale> locales, Iterable<Locale> supportedLocales);
    /// <Summary>
    /// {@template flutter.widgets.widgetsApp.localeResolutionCallback}
    /// The signature of [WidgetsApp.localeResolutionCallback].
    ///
    /// It is recommended to provide a [LocaleListResolutionCallback] instead of a
    /// [LocaleResolutionCallback] when possible, as [LocaleResolutionCallback] only
    /// receives a subset of the information provided in [LocaleListResolutionCallback].
    ///
    /// A [LocaleResolutionCallback] is responsible for computing the locale of the app's
    /// [Localizations] object when the app starts and when user changes the default
    /// locale for the device after [LocaleListResolutionCallback] fails or is not provided.
    ///
    /// This callback is also used if the app is created with a specific locale using
    /// the [new WidgetsApp] `locale` parameter.
    ///
    /// The [locale] is either the value of [WidgetsApp.locale], or the device's default
    /// locale when the app started, or the device locale the user selected after the app
    /// was started. The default locale is the first locale in the list of preferred
    /// locales. If [locale] is null, then Flutter has not yet received the locale
    /// information from the platform. The [supportedLocales] parameter is just the value of
    /// [WidgetsApp.supportedLocales].
    ///
    /// See also:
    ///
    ///  * [LocaleListResolutionCallback], which takes a list of preferred locales (instead of one locale).
    ///    Resolutions by [LocaleListResolutionCallback] take precedence over [LocaleResolutionCallback].
    /// {@endtemplate}
    /// </Summary>
    public delegate Locale LocaleResolutionCallback(Locale locale, Iterable<Locale> supportedLocales);
    /// <Summary>
    /// The signature of [WidgetsApp.onGenerateTitle].
    ///
    /// Used to generate a value for the app's [Title.title], which the device uses
    /// to identify the app for the user. The `context` includes the [WidgetsApp]'s
    /// [Localizations] widget so that this method can be used to produce a
    /// localized title.
    ///
    /// This function must not return null.
    /// </Summary>
    public delegate string GenerateAppTitle(FlutterSDK.Widgets.Framework.BuildContext context);
    /// <Summary>
    /// The signature of [WidgetsApp.pageRouteBuilder].
    ///
    /// Creates a [PageRoute] using the given [RouteSettings] and [WidgetBuilder].
    /// </Summary>
    public delegate FlutterSDK.Widgets.Pages.PageRoute<T> PageRouteFactory<T>(FlutterSDK.Widgets.Navigator.RouteSettings settings, FlutterSDK.Widgets.Framework.WidgetBuilder builder);
    /// <Summary>
    /// The signature of [WidgetsApp.onGenerateInitialRoutes].
    ///
    /// Creates a series of one or more initial routes.
    /// </Summary>
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
        /// <Summary>
        /// Creates a widget that wraps a number of widgets that are commonly
        /// required for an application.
        ///
        /// The boolean arguments, [color], and [navigatorObservers] must not be null.
        ///
        /// Most callers will want to use the [home] or [routes] parameters, or both.
        /// The [home] parameter is a convenience for the following [routes] map:
        ///
        /// ```dart
        /// <String, WidgetBuilder>{ '/': (BuildContext context) => myWidget }
        /// ```
        ///
        /// It is possible to specify both [home] and [routes], but only if [routes] does
        ///  _not_ contain an entry for `'/'`.  Conversely, if [home] is omitted, [routes]
        /// _must_ contain an entry for `'/'`.
        ///
        /// If [home] or [routes] are not null, the routing implementation needs to know how
        /// appropriately build [PageRoutes]. This can be achieved by supplying the
        /// [pageRouteBuilder] parameter.  The [pageRouteBuilder] is used by [MaterialApp]
        /// and [CupertinoApp] to create [MaterialPageRoute]s and [CupertinoPageRoute],
        /// respectively.
        ///
        /// The [builder] parameter is designed to provide the ability to wrap the visible
        /// content of the app in some other widget. It is recommended that you use [home]
        /// rather than [builder] if you intend to only display a single route in your app.
        ///
        /// [WidgetsApp] is also possible to provide a custom implementation of routing via the
        /// [onGeneratedRoute] and [onUnknownRoute] parameters. These parameters correspond
        /// to [Navigator.onGenerateRoute] and [Navigator.onUnknownRoute]. If [home], [routes],
        /// and [builder] are null, or if they fail to create a requested route,
        /// [onGeneratedRoute] will be invoked.  If that fails, [onUnknownRoute] will be invoked.
        ///
        /// The [pageRouteBuilder] will create a [PageRoute] that wraps newly built routes.
        /// If the [builder] is non-null and the [onGenerateRoute] argument is null, then the
        /// [builder] will not be provided only with the context and the child widget, whereas
        /// the [pageRouteBuilder] will be provided with [RouteSettings]. If [onGenerateRoute]
        /// is not provided, [navigatorKey], [onUnknownRoute], [navigatorObservers], and
        /// [initialRoute] must have their default values, as they will have no effect.
        ///
        /// The `supportedLocales` argument must be a list of one or more elements.
        /// By default supportedLocales is `[const Locale('en', 'US')]`.
        /// </Summary>
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
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.navigatorKey}
        /// A key to use when building the [Navigator].
        ///
        /// If a [navigatorKey] is specified, the [Navigator] can be directly
        /// manipulated without first obtaining it from a [BuildContext] via
        /// [Navigator.of]: from the [navigatorKey], use the [GlobalKey.currentState]
        /// getter.
        ///
        /// If this is changed, a new [Navigator] will be created, losing all the
        /// application state in the process; in that case, the [navigatorObservers]
        /// must also be changed, since the previous observers will be attached to the
        /// previous navigator.
        ///
        /// The [Navigator] is only built if [onGenerateRoute] is not null; if it is
        /// null, [navigatorKey] must also be null.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> NavigatorKey { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.onGenerateRoute}
        /// The route generator callback used when the app is navigated to a
        /// named route.
        ///
        /// If this returns null when building the routes to handle the specified
        /// [initialRoute], then all the routes are discarded and
        /// [Navigator.defaultRouteName] is used instead (`/`). See [initialRoute].
        ///
        /// During normal app operation, the [onGenerateRoute] callback will only be
        /// applied to route names pushed by the application, and so should never
        /// return null.
        ///
        /// This is used if [routes] does not contain the requested route.
        ///
        /// The [Navigator] is only built if routes are provided (either via [home],
        /// [routes], [onGenerateRoute], or [onUnknownRoute]); if they are not,
        /// [builder] must not be null.
        /// {@endtemplate}
        ///
        /// If this property is not set, either the [routes] or [home] properties must
        /// be set, and the [pageRouteBuilder] must also be set so that the
        /// default handler will know what routes and [PageRoute]s to build.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnGenerateRoute { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.onGenerateInitialRoutes}
        /// The routes generator callback used for generating initial routes if
        /// [initialRoute] is provided.
        ///
        /// If this property is not set, the underlying
        /// [Navigator.onGenerateInitialRoutes] will default to
        /// [Navigator.defaultGenerateInitialRoutes].
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Widgets.App.InitialRouteListFactory OnGenerateInitialRoutes { get; set; }
        /// <Summary>
        /// The [PageRoute] generator callback used when the app is navigated to a
        /// named route.
        ///
        /// This callback can be used, for example, to specify that a [MaterialPageRoute]
        /// or a [CupertinoPageRoute] should be used for building page transitions.
        /// </Summary>
        public virtual FlutterSDK.Widgets.App.PageRouteFactory PageRouteBuilder { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.home}
        /// The widget for the default route of the app ([Navigator.defaultRouteName],
        /// which is `/`).
        ///
        /// This is the route that is displayed first when the application is started
        /// normally, unless [initialRoute] is specified. It's also the route that's
        /// displayed if the [initialRoute] can't be displayed.
        ///
        /// To be able to directly call [Theme.of], [MediaQuery.of], etc, in the code
        /// that sets the [home] argument in the constructor, you can use a [Builder]
        /// widget to get a [BuildContext].
        ///
        /// If [home] is specified, then [routes] must not include an entry for `/`,
        /// as [home] takes its place.
        ///
        /// The [Navigator] is only built if routes are provided (either via [home],
        /// [routes], [onGenerateRoute], or [onUnknownRoute]); if they are not,
        /// [builder] must not be null.
        ///
        /// The difference between using [home] and using [builder] is that the [home]
        /// subtree is inserted into the application below a [Navigator] (and thus
        /// below an [Overlay], which [Navigator] uses). With [home], therefore,
        /// dialog boxes will work automatically, the [routes] table will be used, and
        /// APIs such as [Navigator.push] and [Navigator.pop] will work as expected.
        /// In contrast, the widget returned from [builder] is inserted _above_ the
        /// app's [Navigator] (if any).
        /// {@endtemplate}
        ///
        /// If this property is set, the [pageRouteBuilder] property must also be set
        /// so that the default route handler will know what kind of [PageRoute]s to
        /// build.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Home { get; set; }
        /// <Summary>
        /// The application's top-level routing table.
        ///
        /// When a named route is pushed with [Navigator.pushNamed], the route name is
        /// looked up in this map. If the name is present, the associated
        /// [WidgetBuilder] is used to construct a [PageRoute] specified by
        /// [pageRouteBuilder] to perform an appropriate transition, including [Hero]
        /// animations, to the new route.
        ///
        /// {@template flutter.widgets.widgetsApp.routes}
        /// If the app only has one page, then you can specify it using [home] instead.
        ///
        /// If [home] is specified, then it implies an entry in this table for the
        /// [Navigator.defaultRouteName] route (`/`), and it is an error to
        /// redundantly provide such a route in the [routes] table.
        ///
        /// If a route is requested that is not specified in this table (or by
        /// [home]), then the [onGenerateRoute] callback is called to build the page
        /// instead.
        ///
        /// The [Navigator] is only built if routes are provided (either via [home],
        /// [routes], [onGenerateRoute], or [onUnknownRoute]); if they are not,
        /// [builder] must not be null.
        /// {@endtemplate}
        ///
        /// If the routes map is not empty, the [pageRouteBuilder] property must be set
        /// so that the default route handler will know what kind of [PageRoute]s to
        /// build.
        /// </Summary>
        public virtual Dictionary<string, object> Routes { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.onUnknownRoute}
        /// Called when [onGenerateRoute] fails to generate a route, except for the
        /// [initialRoute].
        ///
        /// This callback is typically used for error handling. For example, this
        /// callback might always generate a "not found" page that describes the route
        /// that wasn't found.
        ///
        /// Unknown routes can arise either from errors in the app or from external
        /// requests to push routes, such as from Android intents.
        ///
        /// The [Navigator] is only built if routes are provided (either via [home],
        /// [routes], [onGenerateRoute], or [onUnknownRoute]); if they are not,
        /// [builder] must not be null.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Navigator.RouteFactory OnUnknownRoute { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.initialRoute}
        /// The name of the first route to show, if a [Navigator] is built.
        ///
        /// Defaults to [Window.defaultRouteName], which may be overridden by the code
        /// that launched the application.
        ///
        /// If the route contains slashes, then it is treated as a "deep link", and
        /// before this route is pushed, the routes leading to this one are pushed
        /// also. For example, if the route was `/a/b/c`, then the app would start
        /// with the three routes `/a`, `/a/b`, and `/a/b/c` loaded, in that order.
        ///
        /// Intermediate routes aren't required to exist. In the example above, `/a`
        /// and `/a/b` could be skipped if they have no matching route. But `/a/b/c` is
        /// required to have a route, else [initialRoute] is ignored and
        /// [Navigator.defaultRouteName] is used instead (`/`). This can happen if the
        /// app is started with an intent that specifies a non-existent route.
        ///
        /// The [Navigator] is only built if routes are provided (either via [home],
        /// [routes], [onGenerateRoute], or [onUnknownRoute]); if they are not,
        /// [initialRoute] must be null and [builder] must not be null.
        ///
        /// See also:
        ///
        ///  * [Navigator.initialRoute], which is used to implement this property.
        ///  * [Navigator.push], for pushing additional routes.
        ///  * [Navigator.pop], for removing a route from the stack.
        ///
        /// {@endtemplate}
        /// </Summary>
        public virtual string InitialRoute { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.navigatorObservers}
        /// The list of observers for the [Navigator] created for this app.
        ///
        /// This list must be replaced by a list of newly-created observers if the
        /// [navigatorKey] is changed.
        ///
        /// The [Navigator] is only built if routes are provided (either via [home],
        /// [routes], [onGenerateRoute], or [onUnknownRoute]); if they are not,
        /// [navigatorObservers] must be the empty list and [builder] must not be null.
        /// {@endtemplate}
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Navigator.NavigatorObserver> NavigatorObservers { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.builder}
        /// A builder for inserting widgets above the [Navigator] but below the other
        /// widgets created by the [WidgetsApp] widget, or for replacing the
        /// [Navigator] entirely.
        ///
        /// For example, from the [BuildContext] passed to this method, the
        /// [Directionality], [Localizations], [DefaultTextStyle], [MediaQuery], etc,
        /// are all available. They can also be overridden in a way that impacts all
        /// the routes in the [Navigator].
        ///
        /// This is rarely useful, but can be used in applications that wish to
        /// override those defaults, e.g. to force the application into right-to-left
        /// mode despite being in English, or to override the [MediaQuery] metrics
        /// (e.g. to leave a gap for advertisements shown by a plugin from OEM code).
        ///
        /// For specifically overriding the [title] with a value based on the
        /// [Localizations], consider [onGenerateTitle] instead.
        ///
        /// The [builder] callback is passed two arguments, the [BuildContext] (as
        /// `context`) and a [Navigator] widget (as `child`).
        ///
        /// If no routes are provided using [home], [routes], [onGenerateRoute], or
        /// [onUnknownRoute], the `child` will be null, and it is the responsibility
        /// of the [builder] to provide the application's routing machinery.
        ///
        /// If routes _are_ provided using one or more of those properties, then
        /// `child` is not null, and the returned value should include the `child` in
        /// the widget subtree; if it does not, then the application will have no
        /// navigator and the [navigatorKey], [home], [routes], [onGenerateRoute],
        /// [onUnknownRoute], [initialRoute], and [navigatorObservers] properties will
        /// have no effect.
        ///
        /// If [builder] is null, it is as if a builder was specified that returned
        /// the `child` directly. If it is null, routes must be provided using one of
        /// the other properties listed above.
        ///
        /// Unless a [Navigator] is provided, either implicitly from [builder] being
        /// null, or by a [builder] including its `child` argument, or by a [builder]
        /// explicitly providing a [Navigator] of its own, widgets and APIs such as
        /// [Hero], [Navigator.push] and [Navigator.pop], will not function.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.TransitionBuilder Builder { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.title}
        /// A one-line description used by the device to identify the app for the user.
        ///
        /// On Android the titles appear above the task manager's app snapshots which are
        /// displayed when the user presses the "recent apps" button. On iOS this
        /// value cannot be used. `CFBundleDisplayName` from the app's `Info.plist` is
        /// referred to instead whenever present, `CFBundleName` otherwise.
        ///
        /// To provide a localized title instead, use [onGenerateTitle].
        /// {@endtemplate}
        /// </Summary>
        public virtual string Title { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.onGenerateTitle}
        /// If non-null this callback function is called to produce the app's
        /// title string, otherwise [title] is used.
        ///
        /// The [onGenerateTitle] `context` parameter includes the [WidgetsApp]'s
        /// [Localizations] widget so that this callback can be used to produce a
        /// localized title.
        ///
        /// This callback function must not return null.
        ///
        /// The [onGenerateTitle] callback is called each time the [WidgetsApp]
        /// rebuilds.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Widgets.App.GenerateAppTitle OnGenerateTitle { get; set; }
        /// <Summary>
        /// The default text style for [Text] in the application.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.color}
        /// The primary color to use for the application in the operating system
        /// interface.
        ///
        /// For example, on Android this is the color used for the application in the
        /// application switcher.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.locale}
        /// The initial locale for this app's [Localizations] widget is based
        /// on this value.
        ///
        /// If the 'locale' is null then the system's locale value is used.
        ///
        /// The value of [Localizations.locale] will equal this locale if
        /// it matches one of the [supportedLocales]. Otherwise it will be
        /// the first element of [supportedLocales].
        /// {@endtemplate}
        ///
        /// See also:
        ///
        ///  * [localeResolutionCallback], which can override the default
        ///    [supportedLocales] matching algorithm.
        ///  * [localizationsDelegates], which collectively define all of the localized
        ///    resources used by this app.
        /// </Summary>
        public virtual Locale Locale { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.localizationsDelegates}
        /// The delegates for this app's [Localizations] widget.
        ///
        /// The delegates collectively define all of the localized resources
        /// for this application's [Localizations] widget.
        /// {@endtemplate}
        /// </Summary>
        public virtual Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> LocalizationsDelegates { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.localeListResolutionCallback}
        /// This callback is responsible for choosing the app's locale
        /// when the app is started, and when the user changes the
        /// device's locale.
        ///
        /// When a [localeListResolutionCallback] is provided, Flutter will first
        /// attempt to resolve the locale with the provided
        /// [localeListResolutionCallback]. If the callback or result is null, it will
        /// fallback to trying the [localeResolutionCallback]. If both
        /// [localeResolutionCallback] and [localeListResolutionCallback] are left
        /// null or fail to resolve (return null), the a basic fallback algorithm will
        /// be used.
        ///
        /// The priority of each available fallback is:
        ///
        ///  1. [localeListResolutionCallback] is attempted first.
        ///  1. [localeResolutionCallback] is attempted second.
        ///  1. Flutter's basic resolution algorithm, as described in
        ///     [supportedLocales], is attempted last.
        ///
        /// Properly localized projects should provide a more advanced algorithm than
        /// the basic method from [supportedLocales], as it does not implement a
        /// complete algorithm (such as the one defined in
        /// [Unicode TR35](https://unicode.org/reports/tr35/#LanguageMatching))
        /// and is optimized for speed at the detriment of some uncommon edge-cases.
        /// {@endtemplate}
        ///
        /// This callback considers the entire list of preferred locales.
        ///
        /// This algorithm should be able to handle a null or empty list of preferred locales,
        /// which indicates Flutter has not yet received locale information from the platform.
        ///
        /// See also:
        ///
        ///  * [MaterialApp.localeListResolutionCallback], which sets the callback of the
        ///    [WidgetsApp] it creates.
        /// </Summary>
        public virtual FlutterSDK.Widgets.App.LocaleListResolutionCallback LocaleListResolutionCallback { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.widgetsApp.localeListResolutionCallback}
        ///
        /// This callback considers only the default locale, which is the first locale
        /// in the preferred locales list. It is preferred to set [localeListResolutionCallback]
        /// over [localeResolutionCallback] as it provides the full preferred locales list.
        ///
        /// This algorithm should be able to handle a null locale, which indicates
        /// Flutter has not yet received locale information from the platform.
        ///
        /// See also:
        ///
        ///  * [MaterialApp.localeResolutionCallback], which sets the callback of the
        ///    [WidgetsApp] it creates.
        /// </Summary>
        public virtual FlutterSDK.Widgets.App.LocaleResolutionCallback LocaleResolutionCallback { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.supportedLocales}
        /// The list of locales that this app has been localized for.
        ///
        /// By default only the American English locale is supported. Apps should
        /// configure this list to match the locales they support.
        ///
        /// This list must not null. Its default value is just
        /// `[const Locale('en', 'US')]`.
        ///
        /// The order of the list matters. The default locale resolution algorithm,
        /// `basicLocaleListResolution`, attempts to match by the following priority:
        ///
        ///  1. [Locale.languageCode], [Locale.scriptCode], and [Locale.countryCode]
        ///  2. [Locale.languageCode] and [Locale.scriptCode] only
        ///  3. [Locale.languageCode] and [Locale.countryCode] only
        ///  4. [Locale.languageCode] only
        ///  5. [Locale.countryCode] only when all preferred locales fail to match
        ///  6. Returns the first element of [supportedLocales] as a fallback
        ///
        /// When more than one supported locale matches one of these criteria, only
        /// the first matching locale is returned.
        ///
        /// The default locale resolution algorithm can be overridden by providing a
        /// value for [localeListResolutionCallback]. The provided
        /// `basicLocaleListResolution` is optimized for speed and does not implement
        /// a full algorithm (such as the one defined in
        /// [Unicode TR35](https://unicode.org/reports/tr35/#LanguageMatching)) that
        /// takes distances between languages into account.
        ///
        /// When supporting languages with more than one script, it is recommended
        /// to specify the [Locale.scriptCode] explicitly. Locales may also be defined without
        /// [Locale.countryCode] to specify a generic fallback for a particular script.
        ///
        /// A fully supported language with multiple scripts should define a generic language-only
        /// locale (e.g. 'zh'), language+script only locales (e.g. 'zh_Hans' and 'zh_Hant'),
        /// and any language+script+country locales (e.g. 'zh_Hans_CN'). Fully defining all of
        /// these locales as supported is not strictly required but allows for proper locale resolution in
        /// the most number of cases. These locales can be specified with the [Locale.fromSubtags]
        /// constructor:
        ///
        /// ```dart
        /// // Full Chinese support for CN, TW, and HK
        /// supportedLocales: [
        ///   const Locale.fromSubtags(languageCode: 'zh'), // generic Chinese 'zh'
        ///   const Locale.fromSubtags(languageCode: 'zh', scriptCode: 'Hans'), // generic simplified Chinese 'zh_Hans'
        ///   const Locale.fromSubtags(languageCode: 'zh', scriptCode: 'Hant'), // generic traditional Chinese 'zh_Hant'
        ///   const Locale.fromSubtags(languageCode: 'zh', scriptCode: 'Hans', countryCode: 'CN'), // 'zh_Hans_CN'
        ///   const Locale.fromSubtags(languageCode: 'zh', scriptCode: 'Hant', countryCode: 'TW'), // 'zh_Hant_TW'
        ///   const Locale.fromSubtags(languageCode: 'zh', scriptCode: 'Hant', countryCode: 'HK'), // 'zh_Hant_HK'
        /// ],
        /// ```
        ///
        /// Omitting some these fallbacks may result in improperly resolved
        /// edge-cases, for example, a simplified Chinese user in Taiwan ('zh_Hans_TW')
        /// may resolve to traditional Chinese if 'zh_Hans' and 'zh_Hans_CN' are
        /// omitted.
        /// {@endtemplate}
        ///
        /// See also:
        ///
        ///  * [MaterialApp.supportedLocales], which sets the `supportedLocales`
        ///    of the [WidgetsApp] it creates.
        ///  * [localeResolutionCallback], an app callback that resolves the app's locale
        ///    when the device's locale changes.
        ///  * [localizationsDelegates], which collectively define all of the localized
        ///    resources used by this app.
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
        /// Checkerboards raster cache images.
        ///
        /// See [PerformanceOverlay.checkerboardRasterCacheImages].
        /// </Summary>
        public virtual bool CheckerboardRasterCacheImages { get; set; }
        /// <Summary>
        /// Checkerboards layers rendered to offscreen bitmaps.
        ///
        /// See [PerformanceOverlay.checkerboardOffscreenLayers].
        /// </Summary>
        public virtual bool CheckerboardOffscreenLayers { get; set; }
        /// <Summary>
        /// Turns on an overlay that shows the accessibility information
        /// reported by the framework.
        /// </Summary>
        public virtual bool ShowSemanticsDebugger { get; set; }
        /// <Summary>
        /// Turns on an overlay that enables inspecting the widget tree.
        ///
        /// The inspector is only available in checked mode as it depends on
        /// [RenderObject.debugDescribeChildren] which should not be called outside of
        /// checked mode.
        /// </Summary>
        public virtual bool DebugShowWidgetInspector { get; set; }
        /// <Summary>
        /// Builds the widget the [WidgetInspector] uses to switch between view and
        /// inspect modes.
        ///
        /// This lets [MaterialApp] to use a material button to toggle the inspector
        /// select mode without requiring [WidgetInspector] to depend on the
        /// material package.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Widgetinspector.InspectorSelectButtonBuilder InspectorSelectButtonBuilder { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.debugShowCheckedModeBanner}
        /// Turns on a little "DEBUG" banner in checked mode to indicate
        /// that the app is in checked mode. This is on by default (in
        /// checked mode), to turn it off, set the constructor argument to
        /// false. In release mode this has no effect.
        ///
        /// To get this banner in your application if you're not using
        /// WidgetsApp, include a [CheckedModeBanner] widget in your app.
        ///
        /// This banner is intended to deter people from complaining that your
        /// app is slow when it's in checked mode. In checked mode, Flutter
        /// enables a large number of expensive diagnostics to aid in
        /// development, and so performance in checked mode is not
        /// representative of what will happen in release mode.
        /// {@endtemplate}
        /// </Summary>
        public virtual bool DebugShowCheckedModeBanner { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.shortcuts}
        /// The default map of keyboard shortcuts to intents for the application.
        ///
        /// By default, this is set to [WidgetsApp.defaultShortcuts].
        /// {@endtemplate}
        ///
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
        ///
        /// {@template flutter.widgets.widgetsApp.shortcuts.seeAlso}
        /// See also:
        ///
        ///  * [LogicalKeySet], a set of [LogicalKeyboardKey]s that make up the keys
        ///    for this map.
        ///  * The [Shortcuts] widget, which defines a keyboard mapping.
        ///  * The [Actions] widget, which defines the mapping from intent to action.
        ///  * The [Intent] and [Action] classes, which allow definition of new
        ///    actions.
        /// {@endtemplate}
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> Shortcuts { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.widgetsApp.actions}
        /// The default map of intent keys to actions for the application.
        ///
        /// By default, this is the output of [WidgetsApp.defaultActions], called with
        /// [defaultTargetPlatform]. Specifying [actions] for an app overrides the
        /// default, so if you wish to modify the default [actions], you can call
        /// [WidgetsApp.defaultActions] and modify the resulting map, passing it as
        /// the [actions] for this app. You may also add to the bindings, or override
        /// specific bindings for a widget subtree, by adding your own [Actions]
        /// widget.
        /// {@endtemplate}
        ///
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
        ///
        /// {@template flutter.widgets.widgetsApp.actions.seeAlso}
        /// See also:
        ///
        ///  * The [shortcuts] parameter, which defines the default set of shortcuts
        ///    for the application.
        ///  * The [Shortcuts] widget, which defines a keyboard mapping.
        ///  * The [Actions] widget, which defines the mapping from intent to action.
        ///  * The [Intent] and [Action] classes, which allow definition of new
        ///    actions.
        /// {@endtemplate}
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> Actions { get; set; }
        /// <Summary>
        /// If true, forces the performance overlay to be visible in all instances.
        ///
        /// Used by the `showPerformanceOverlay` observatory extension.
        /// </Summary>
        public virtual bool ShowPerformanceOverlayOverride { get; set; }
        /// <Summary>
        /// If true, forces the widget inspector to be visible.
        ///
        /// Used by the `debugShowWidgetInspector` debugging extension.
        ///
        /// The inspector allows you to select a location on your device or emulator
        /// and view what widgets and render objects associated with it. An outline of
        /// the selected widget and some summary information is shown on device and
        /// more detailed information is shown in the IDE or Observatory.
        /// </Summary>
        public virtual bool DebugShowWidgetInspectorOverride { get; set; }
        /// <Summary>
        /// If false, prevents the debug banner from being visible.
        ///
        /// Used by the `debugAllowBanner` observatory extension.
        ///
        /// This is how `flutter run` turns off the banner when you take a screen shot
        /// with "s".
        /// </Summary>
        public virtual bool DebugAllowBannerOverride { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> _DefaultShortcuts { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> _DefaultWebShortcuts { get; set; }
        internal virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> _DefaultMacOsShortcuts { get; set; }
        /// <Summary>
        /// The default value of [WidgetsApp.actions].
        /// </Summary>
        public virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> DefaultActions { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> DefaultShortcuts { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.App._WidgetsAppState CreateState() => new _WidgetsAppState();


    }


    public class _WidgetsAppState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.App.WidgetsApp>, IWidgetsBindingObserver
    {
        public _WidgetsAppState()
        { }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Navigator.NavigatorState> _Navigator { get; set; }
        /// <Summary>
        /// This is the resolved locale, and is one of the supportedLocales.
        /// </Summary>
        internal virtual Locale _Locale { get; set; }
        internal virtual Iterable<FlutterSDK.Widgets.Localizations.LocalizationsDelegate<object>> _LocalizationsDelegates { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

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



    }


    /// <Summary>
    /// Builds [MediaQuery] from `window` by listening to [WidgetsBinding].
    ///
    /// It is performed in a standalone widget to rebuild **only** [MediaQuery] and
    /// its dependents when `window` changes, instead of rebuilding the entire widget tree.
    /// </Summary>
    public class _MediaQueryFromWindow : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _MediaQueryFromWindow(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.App._MediaQueryFromWindowsState CreateState() => new _MediaQueryFromWindowsState();


    }


    public class _MediaQueryFromWindowsState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.App._MediaQueryFromWindow>, IWidgetsBindingObserver
    {
        public _MediaQueryFromWindowsState()
        { }

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



    }

}
