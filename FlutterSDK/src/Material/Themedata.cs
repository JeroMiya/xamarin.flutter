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
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Material.Themedata
{
    internal static class ThemedataDefaultClass
    {
        public static Color _KLightThemeHighlightColor = default(Color);
        public static Color _KLightThemeSplashColor = default(Color);
        public static Color _KDarkThemeHighlightColor = default(Color);
        public static Color _KDarkThemeSplashColor = default(Color);
    }

    /// <Summary>
    /// Holds the color and typography values for a material design theme.
    ///
    /// Use this class to configure a [Theme] or [MaterialApp] widget.
    ///
    /// To obtain the current theme, use [Theme.of].
    ///
    /// {@tool snippet}
    ///
    /// This sample creates a [Theme] widget that stores the `ThemeData`. The
    /// `ThemeData` can be accessed by descendant Widgets that use the correct
    /// `context`. This example uses the [Builder] widget to gain access to a
    /// descendant `context` that contains the `ThemeData`.
    ///
    /// The [Container] widget uses [Theme.of] to retrieve the [primaryColor] from
    /// the `ThemeData` to draw an amber square.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/theme_data.png)
    ///
    /// ```dart
    /// Theme(
    ///   data: ThemeData(primaryColor: Colors.amber),
    ///   child: Builder(
    ///     builder: (BuildContext context) {
    ///       return Container(
    ///         width: 100,
    ///         height: 100,
    ///         color: Theme.of(context).primaryColor,
    ///       );
    ///     },
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// In addition to using the [Theme] widget, you can provide `ThemeData` to a
    /// [MaterialApp]. The `ThemeData` will be used throughout the app to style
    /// material design widgets.
    ///
    /// {@tool snippet}
    ///
    /// This sample creates a [MaterialApp] widget that stores `ThemeData` and
    /// passes the `ThemeData` to descendant widgets. The [AppBar] widget uses the
    /// [primaryColor] to create a blue background. The [Text] widget uses the
    /// [TextTheme.bodyText2] to create purple text. The [FloatingActionButton] widget
    /// uses the [accentColor] to create a green background.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/material_app_theme_data.png)
    ///
    /// ```dart
    /// MaterialApp(
    ///   theme: ThemeData(
    ///     primaryColor: Colors.blue,
    ///     accentColor: Colors.green,
    ///     textTheme: TextTheme(bodyText2: TextStyle(color: Colors.purple)),
    ///   ),
    ///   home: Scaffold(
    ///     appBar: AppBar(
    ///       title: const Text('ThemeData Demo'),
    ///     ),
    ///     floatingActionButton: FloatingActionButton(
    ///       child: const Icon(Icons.add),
    ///       onPressed: () {},
    ///     ),
    ///     body: Center(
    ///       child: Text(
    ///         'Button pressed 0 times',
    ///       ),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class ThemeData : IDiagnosticable
    {
        #region constructors
        public ThemeData(Brightness brightness = default(Brightness), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Colors.MaterialColor primarySwatch = default(FlutterSDK.Material.Colors.MaterialColor), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), Brightness primaryColorBrightness = default(Brightness), FlutterBinding.UI.Color primaryColorLight = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColorDark = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color accentColor = default(FlutterBinding.UI.Color), Brightness accentColorBrightness = default(Brightness), FlutterBinding.UI.Color canvasColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color bottomAppBarColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cardColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory splashFactory = default(FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory), FlutterBinding.UI.Color selectedRowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color unselectedWidgetColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color buttonColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Buttontheme.ButtonThemeData buttonTheme = default(FlutterSDK.Material.Buttontheme.ButtonThemeData), FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme = default(FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData), FlutterBinding.UI.Color secondaryHeaderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionHandleColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dialogBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color indicatorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hintColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color errorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color toggleableActiveColor = default(FlutterBinding.UI.Color), string fontFamily = default(string), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme primaryTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme accentTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Inputdecorator.InputDecorationTheme inputDecorationTheme = default(FlutterSDK.Material.Inputdecorator.InputDecorationTheme), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData primaryIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData accentIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Tabbartheme.TabBarTheme tabBarTheme = default(FlutterSDK.Material.Tabbartheme.TabBarTheme), FlutterSDK.Material.Tooltiptheme.TooltipThemeData tooltipTheme = default(FlutterSDK.Material.Tooltiptheme.TooltipThemeData), FlutterSDK.Material.Cardtheme.CardTheme cardTheme = default(FlutterSDK.Material.Cardtheme.CardTheme), FlutterSDK.Material.Chiptheme.ChipThemeData chipTheme = default(FlutterSDK.Material.Chiptheme.ChipThemeData), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), bool applyElevationOverlayColor = default(bool), FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme pageTransitionsTheme = default(FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme), FlutterSDK.Material.Appbartheme.AppBarTheme appBarTheme = default(FlutterSDK.Material.Appbartheme.AppBarTheme), FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme bottomAppBarTheme = default(FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme), FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Dialogtheme.DialogTheme dialogTheme = default(FlutterSDK.Material.Dialogtheme.DialogTheme), FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData floatingActionButtonTheme = default(FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData), FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData navigationRailTheme = default(FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData), FlutterSDK.Material.Typography.Typography typography = default(FlutterSDK.Material.Typography.Typography), FlutterSDK.Cupertino.Theme.CupertinoThemeData cupertinoOverrideTheme = default(FlutterSDK.Cupertino.Theme.CupertinoThemeData), FlutterSDK.Material.Snackbartheme.SnackBarThemeData snackBarTheme = default(FlutterSDK.Material.Snackbartheme.SnackBarThemeData), FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData bottomSheetTheme = default(FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData), FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData popupMenuTheme = default(FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData), FlutterSDK.Material.Bannertheme.MaterialBannerThemeData bannerTheme = default(FlutterSDK.Material.Bannertheme.MaterialBannerThemeData), FlutterSDK.Material.Dividertheme.DividerThemeData dividerTheme = default(FlutterSDK.Material.Dividertheme.DividerThemeData), FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData buttonBarTheme = default(FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData))
    
brightness = (brightness == null ? Brightness.Light : brightness );
bool isDark = brightness == Brightness.Dark;
        visualDensity = (visualDensity == null ? new VisualDensity() : visualDensity );
primarySwatch = (primarySwatch == null ? ColorsDefaultClass.Colors.Blue : primarySwatch );
primaryColor = (primaryColor == null ? isDark? ColorsDefaultClass.Colors.Grey[900]:primarySwatch : primaryColor );
        primaryColorBrightness = (primaryColorBrightness == null ? EstimateBrightnessForColor(primaryColor) : primaryColorBrightness );
primaryColorLight = (primaryColorLight == null ? isDark? ColorsDefaultClass.Colors.Grey[500]:primarySwatch[100] : primaryColorLight );
        primaryColorDark = (primaryColorDark == null ? isDark? ColorsDefaultClass.Colors.Black:primarySwatch[700] : primaryColorDark );
        bool primaryIsDark = primaryColorBrightness == Brightness.Dark;
        toggleableActiveColor = (toggleableActiveColor == null ? isDark? ColorsDefaultClass.Colors.TealAccent[200]:(accentColor??primarySwatch[600]) : toggleableActiveColor );
accentColor = (accentColor == null ? isDark? ColorsDefaultClass.Colors.TealAccent[200]:primarySwatch[500] : accentColor );
        accentColorBrightness = (accentColorBrightness == null ? EstimateBrightnessForColor(accentColor) : accentColorBrightness );
bool accentIsDark = accentColorBrightness == Brightness.Dark;
        canvasColor = (canvasColor == null ? isDark? ColorsDefaultClass.Colors.Grey[850]:ColorsDefaultClass.Colors.Grey[50] : canvasColor );
        scaffoldBackgroundColor = (scaffoldBackgroundColor == null ? canvasColor : scaffoldBackgroundColor );
bottomAppBarColor = (bottomAppBarColor == null ? isDark? ColorsDefaultClass.Colors.Grey[800]:ColorsDefaultClass.Colors.White : bottomAppBarColor );
        cardColor = (cardColor == null ? isDark? ColorsDefaultClass.Colors.Grey[800]:ColorsDefaultClass.Colors.White : cardColor );
        dividerColor = (dividerColor == null ? isDark? new Color(0x1FFFFFFF) :new Color(0x1F000000) : dividerColor );
colorScheme = (colorScheme == null ? ColorScheme.FromSwatch(primarySwatch:primarySwatch, primaryColorDark:primaryColorDark, accentColor:accentColor, cardColor:cardColor, backgroundColor:backgroundColor, errorColor:errorColor, brightness:brightness) : colorScheme );
splashFactory = (splashFactory == null ? InksplashDefaultClass.InkSplash.SplashFactory : splashFactory );
selectedRowColor = (selectedRowColor == null ? ColorsDefaultClass.Colors.Grey[100] : selectedRowColor );
unselectedWidgetColor = (unselectedWidgetColor == null ? isDark? ColorsDefaultClass.Colors.White70:ColorsDefaultClass.Colors.Black54 : unselectedWidgetColor );
        secondaryHeaderColor = (secondaryHeaderColor == null ? isDark? ColorsDefaultClass.Colors.Grey[700]:primarySwatch[50] : secondaryHeaderColor );
        textSelectionColor = (textSelectionColor == null ? isDark? accentColor:primarySwatch[200] : textSelectionColor );
cursorColor=cursorColor??Color.FromRGBO(66, 133, 244, 1.0);
textSelectionHandleColor = (textSelectionHandleColor == null ? isDark? ColorsDefaultClass.Colors.TealAccent[400]:primarySwatch[300] : textSelectionHandleColor );
        backgroundColor = (backgroundColor == null ? isDark? ColorsDefaultClass.Colors.Grey[700]:primarySwatch[200] : backgroundColor );
        dialogBackgroundColor = (dialogBackgroundColor == null ? isDark? ColorsDefaultClass.Colors.Grey[800]:ColorsDefaultClass.Colors.White : dialogBackgroundColor );
        indicatorColor = (indicatorColor == null ? accentColor==primaryColor? ColorsDefaultClass.Colors.White:accentColor : indicatorColor );
        hintColor = (hintColor == null ? isDark? new Color(0x80FFFFFF) :new Color(0x8A000000) : hintColor );
errorColor = (errorColor == null ? ColorsDefaultClass.Colors.Red[700] : errorColor );
inputDecorationTheme = (inputDecorationTheme == null ? new InputDecorationTheme() : inputDecorationTheme );
pageTransitionsTheme = (pageTransitionsTheme == null ? new PageTransitionsTheme() : pageTransitionsTheme );
primaryIconTheme = (primaryIconTheme == null ? primaryIsDark? new IconThemeData(color:ColorsDefaultClass.Colors.White) :new IconThemeData(color:ColorsDefaultClass.Colors.Black) : primaryIconTheme );
accentIconTheme = (accentIconTheme == null ? accentIsDark? new IconThemeData(color:ColorsDefaultClass.Colors.White) :new IconThemeData(color:ColorsDefaultClass.Colors.Black) : accentIconTheme );
iconTheme = (iconTheme == null ? isDark? new IconThemeData(color:ColorsDefaultClass.Colors.White) :new IconThemeData(color:ColorsDefaultClass.Colors.Black87) : iconTheme );
platform = (platform == null ? PlatformDefaultClass.DefaultTargetPlatform : platform );
typography = (typography == null ? Typography.Material2014(platform:platform) : typography );
TextTheme defaultTextTheme = isDark ? typography.White : typography.Black;
        TextTheme defaultPrimaryTextTheme = primaryIsDark ? typography.White : typography.Black;
        TextTheme defaultAccentTextTheme = accentIsDark ? typography.White : typography.Black;
if (fontFamily!=null ){
defaultTextTheme=defaultTextTheme.Apply(fontFamily:fontFamily);
defaultPrimaryTextTheme=defaultPrimaryTextTheme.Apply(fontFamily:fontFamily);
defaultAccentTextTheme=defaultAccentTextTheme.Apply(fontFamily:fontFamily);
}

    textTheme=defaultTextTheme.Merge(textTheme);
primaryTextTheme=defaultPrimaryTextTheme.Merge(primaryTextTheme);
accentTextTheme=defaultAccentTextTheme.Merge(accentTextTheme);
materialTapTargetSize = (materialTapTargetSize == null ? MaterialTapTargetSize.Padded : materialTapTargetSize );
    applyElevationOverlayColor = (applyElevationOverlayColor == null ? false  : applyElevationOverlayColor );
buttonColor = (buttonColor == null ? isDark? primarySwatch[600]:ColorsDefaultClass.Colors.Grey[300] : buttonColor );
focusColor = (focusColor == null ? isDark? ColorsDefaultClass.Colors.White.WithOpacity(0.12):ColorsDefaultClass.Colors.Black.WithOpacity(0.12) : focusColor );
hoverColor = (hoverColor == null ? isDark? ColorsDefaultClass.Colors.White.WithOpacity(0.04):ColorsDefaultClass.Colors.Black.WithOpacity(0.04) : hoverColor );
buttonTheme = (buttonTheme == null ? new ButtonThemeData(colorScheme:colorScheme, buttonColor:buttonColor, disabledColor:disabledColor, focusColor:focusColor, hoverColor:hoverColor, highlightColor:highlightColor, splashColor:splashColor, materialTapTargetSize:materialTapTargetSize) : buttonTheme );
toggleButtonsTheme = (toggleButtonsTheme == null ? new ToggleButtonsThemeData() : toggleButtonsTheme );
disabledColor = (disabledColor == null ? isDark? ColorsDefaultClass.Colors.White38:ColorsDefaultClass.Colors.Black38 : disabledColor );
    highlightColor = (highlightColor == null ? isDark? ThemedataDefaultClass._KDarkThemeHighlightColor:ThemedataDefaultClass._KLightThemeHighlightColor : highlightColor );
    splashColor = (splashColor == null ? isDark? ThemedataDefaultClass._KDarkThemeSplashColor:ThemedataDefaultClass._KLightThemeSplashColor : splashColor );
    sliderTheme = (sliderTheme == null ? new SliderThemeData() : sliderTheme );
tabBarTheme = (tabBarTheme == null ? new TabBarTheme() : tabBarTheme );
tooltipTheme = (tooltipTheme == null ? new TooltipThemeData() : tooltipTheme );
appBarTheme = (appBarTheme == null ? new AppBarTheme() : appBarTheme );
bottomAppBarTheme = (bottomAppBarTheme == null ? new BottomAppBarTheme() : bottomAppBarTheme );
cardTheme = (cardTheme == null ? new CardTheme() : cardTheme );
chipTheme = (chipTheme == null ? ChipThemeData.FromDefaults(secondaryColor:primaryColor, brightness:brightness, labelStyle:textTheme.BodyText1) : chipTheme );
dialogTheme = (dialogTheme == null ? new DialogTheme() : dialogTheme );
floatingActionButtonTheme = (floatingActionButtonTheme == null ? new FloatingActionButtonThemeData() : floatingActionButtonTheme );
navigationRailTheme = (navigationRailTheme == null ? new NavigationRailThemeData() : navigationRailTheme );
cupertinoOverrideTheme=cupertinoOverrideTheme?.NoDefault();
    snackBarTheme = (snackBarTheme == null ? new SnackBarThemeData() : snackBarTheme );
bottomSheetTheme = (bottomSheetTheme == null ? new BottomSheetThemeData() : bottomSheetTheme );
popupMenuTheme = (popupMenuTheme == null ? new PopupMenuThemeData() : popupMenuTheme );
bannerTheme = (bannerTheme == null ? new MaterialBannerThemeData() : bannerTheme );
dividerTheme = (dividerTheme == null ? new DividerThemeData() : dividerTheme );
buttonBarTheme = (buttonBarTheme == null ? new ButtonBarThemeData() : buttonBarTheme );
return ThemeData.Raw(brightness:brightness, visualDensity:visualDensity, primaryColor:primaryColor, primaryColorBrightness:primaryColorBrightness, primaryColorLight:primaryColorLight, primaryColorDark:primaryColorDark, accentColor:accentColor, accentColorBrightness:accentColorBrightness, canvasColor:canvasColor, scaffoldBackgroundColor:scaffoldBackgroundColor, bottomAppBarColor:bottomAppBarColor, cardColor:cardColor, dividerColor:dividerColor, focusColor:focusColor, hoverColor:hoverColor, highlightColor:highlightColor, splashColor:splashColor, splashFactory:splashFactory, selectedRowColor:selectedRowColor, unselectedWidgetColor:unselectedWidgetColor, disabledColor:disabledColor, buttonTheme:buttonTheme, buttonColor:buttonColor, toggleButtonsTheme:toggleButtonsTheme, toggleableActiveColor:toggleableActiveColor, secondaryHeaderColor:secondaryHeaderColor, textSelectionColor:textSelectionColor, cursorColor:cursorColor, textSelectionHandleColor:textSelectionHandleColor, backgroundColor:backgroundColor, dialogBackgroundColor:dialogBackgroundColor, indicatorColor:indicatorColor, hintColor:hintColor, errorColor:errorColor, textTheme:textTheme, primaryTextTheme:primaryTextTheme, accentTextTheme:accentTextTheme, inputDecorationTheme:inputDecorationTheme, iconTheme:iconTheme, primaryIconTheme:primaryIconTheme, accentIconTheme:accentIconTheme, sliderTheme:sliderTheme, tabBarTheme:tabBarTheme, tooltipTheme:tooltipTheme, cardTheme:cardTheme, chipTheme:chipTheme, platform:platform, materialTapTargetSize:materialTapTargetSize, applyElevationOverlayColor:applyElevationOverlayColor, pageTransitionsTheme:pageTransitionsTheme, appBarTheme:appBarTheme, bottomAppBarTheme:bottomAppBarTheme, colorScheme:colorScheme, dialogTheme:dialogTheme, floatingActionButtonTheme:floatingActionButtonTheme, navigationRailTheme:navigationRailTheme, typography:typography, cupertinoOverrideTheme:cupertinoOverrideTheme, snackBarTheme:snackBarTheme, bottomSheetTheme:bottomSheetTheme, popupMenuTheme:popupMenuTheme, bannerTheme:bannerTheme, dividerTheme:dividerTheme, buttonBarTheme:buttonBarTheme);
}


public static ThemeData Raw(Brightness brightness = default(Brightness), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), Brightness primaryColorBrightness = default(Brightness), FlutterBinding.UI.Color primaryColorLight = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColorDark = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color canvasColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color accentColor = default(FlutterBinding.UI.Color), Brightness accentColorBrightness = default(Brightness), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color bottomAppBarColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cardColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory splashFactory = default(FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory), FlutterBinding.UI.Color selectedRowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color unselectedWidgetColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Buttontheme.ButtonThemeData buttonTheme = default(FlutterSDK.Material.Buttontheme.ButtonThemeData), FlutterBinding.UI.Color buttonColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme = default(FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData), FlutterBinding.UI.Color secondaryHeaderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionHandleColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dialogBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color indicatorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hintColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color errorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color toggleableActiveColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme primaryTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme accentTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Inputdecorator.InputDecorationTheme inputDecorationTheme = default(FlutterSDK.Material.Inputdecorator.InputDecorationTheme), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData primaryIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData accentIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Tabbartheme.TabBarTheme tabBarTheme = default(FlutterSDK.Material.Tabbartheme.TabBarTheme), FlutterSDK.Material.Tooltiptheme.TooltipThemeData tooltipTheme = default(FlutterSDK.Material.Tooltiptheme.TooltipThemeData), FlutterSDK.Material.Cardtheme.CardTheme cardTheme = default(FlutterSDK.Material.Cardtheme.CardTheme), FlutterSDK.Material.Chiptheme.ChipThemeData chipTheme = default(FlutterSDK.Material.Chiptheme.ChipThemeData), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), bool applyElevationOverlayColor = default(bool), FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme pageTransitionsTheme = default(FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme), FlutterSDK.Material.Appbartheme.AppBarTheme appBarTheme = default(FlutterSDK.Material.Appbartheme.AppBarTheme), FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme bottomAppBarTheme = default(FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme), FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Dialogtheme.DialogTheme dialogTheme = default(FlutterSDK.Material.Dialogtheme.DialogTheme), FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData floatingActionButtonTheme = default(FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData), FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData navigationRailTheme = default(FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData), FlutterSDK.Material.Typography.Typography typography = default(FlutterSDK.Material.Typography.Typography), FlutterSDK.Cupertino.Theme.CupertinoThemeData cupertinoOverrideTheme = default(FlutterSDK.Cupertino.Theme.CupertinoThemeData), FlutterSDK.Material.Snackbartheme.SnackBarThemeData snackBarTheme = default(FlutterSDK.Material.Snackbartheme.SnackBarThemeData), FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData bottomSheetTheme = default(FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData), FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData popupMenuTheme = default(FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData), FlutterSDK.Material.Bannertheme.MaterialBannerThemeData bannerTheme = default(FlutterSDK.Material.Bannertheme.MaterialBannerThemeData), FlutterSDK.Material.Dividertheme.DividerThemeData dividerTheme = default(FlutterSDK.Material.Dividertheme.DividerThemeData), FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData buttonBarTheme = default(FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData))

}
public static ThemeData From(FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme))


bool isDark = colorScheme.Brightness == Brightness.Dark;
Color primarySurfaceColor = isDark ? colorScheme.Surface : colorScheme.Primary;
Color onPrimarySurfaceColor = isDark ? colorScheme.OnSurface : colorScheme.OnPrimary;
return new ThemeData(brightness: colorScheme.Brightness, primaryColor: primarySurfaceColor, primaryColorBrightness: ThemedataDefaultClass.ThemeData.EstimateBrightnessForColor(primarySurfaceColor), canvasColor: colorScheme.Background, accentColor: colorScheme.Secondary, accentColorBrightness: ThemedataDefaultClass.ThemeData.EstimateBrightnessForColor(colorScheme.Secondary), scaffoldBackgroundColor: colorScheme.Background, bottomAppBarColor: colorScheme.Surface, cardColor: colorScheme.Surface, dividerColor: colorScheme.OnSurface.WithOpacity(0.12), backgroundColor: colorScheme.Background, dialogBackgroundColor: colorScheme.Background, errorColor: colorScheme.Error, textTheme: textTheme, indicatorColor: onPrimarySurfaceColor, applyElevationOverlayColor: isDark, colorScheme: colorScheme);
}


public static ThemeData Light()
new ThemeData(brightness: Brightness.Light);

public static ThemeData Dark()
new ThemeData(brightness: Brightness.Dark);

public static ThemeData Fallback()
ThemeData.Light();

#endregion

#region fields
public virtual Brightness Brightness { get; set; }
public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
public virtual FlutterBinding.UI.Color PrimaryColor { get; set; }
public virtual Brightness PrimaryColorBrightness { get; set; }
public virtual FlutterBinding.UI.Color PrimaryColorLight { get; set; }
public virtual FlutterBinding.UI.Color PrimaryColorDark { get; set; }
public virtual FlutterBinding.UI.Color CanvasColor { get; set; }
public virtual FlutterBinding.UI.Color AccentColor { get; set; }
public virtual Brightness AccentColorBrightness { get; set; }
public virtual FlutterBinding.UI.Color ScaffoldBackgroundColor { get; set; }
public virtual FlutterBinding.UI.Color BottomAppBarColor { get; set; }
public virtual FlutterBinding.UI.Color CardColor { get; set; }
public virtual FlutterBinding.UI.Color DividerColor { get; set; }
public virtual FlutterBinding.UI.Color FocusColor { get; set; }
public virtual FlutterBinding.UI.Color HoverColor { get; set; }
public virtual FlutterBinding.UI.Color HighlightColor { get; set; }
public virtual FlutterBinding.UI.Color SplashColor { get; set; }
public virtual FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory SplashFactory { get; set; }
public virtual FlutterBinding.UI.Color SelectedRowColor { get; set; }
public virtual FlutterBinding.UI.Color UnselectedWidgetColor { get; set; }
public virtual FlutterBinding.UI.Color DisabledColor { get; set; }
public virtual FlutterSDK.Material.Buttontheme.ButtonThemeData ButtonTheme { get; set; }
public virtual FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData ToggleButtonsTheme { get; set; }
public virtual FlutterBinding.UI.Color ButtonColor { get; set; }
public virtual FlutterBinding.UI.Color SecondaryHeaderColor { get; set; }
public virtual FlutterBinding.UI.Color TextSelectionColor { get; set; }
public virtual FlutterBinding.UI.Color CursorColor { get; set; }
public virtual FlutterBinding.UI.Color TextSelectionHandleColor { get; set; }
public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
public virtual FlutterBinding.UI.Color DialogBackgroundColor { get; set; }
public virtual FlutterBinding.UI.Color IndicatorColor { get; set; }
public virtual FlutterBinding.UI.Color HintColor { get; set; }
public virtual FlutterBinding.UI.Color ErrorColor { get; set; }
public virtual FlutterBinding.UI.Color ToggleableActiveColor { get; set; }
public virtual FlutterSDK.Material.Texttheme.TextTheme TextTheme { get; set; }
public virtual FlutterSDK.Material.Texttheme.TextTheme PrimaryTextTheme { get; set; }
public virtual FlutterSDK.Material.Texttheme.TextTheme AccentTextTheme { get; set; }
public virtual FlutterSDK.Material.Inputdecorator.InputDecorationTheme InputDecorationTheme { get; set; }
public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData IconTheme { get; set; }
public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData PrimaryIconTheme { get; set; }
public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData AccentIconTheme { get; set; }
public virtual FlutterSDK.Material.Slidertheme.SliderThemeData SliderTheme { get; set; }
public virtual FlutterSDK.Material.Tabbartheme.TabBarTheme TabBarTheme { get; set; }
public virtual FlutterSDK.Material.Tooltiptheme.TooltipThemeData TooltipTheme { get; set; }
public virtual FlutterSDK.Material.Cardtheme.CardTheme CardTheme { get; set; }
public virtual FlutterSDK.Material.Chiptheme.ChipThemeData ChipTheme { get; set; }
public virtual FlutterSDK.Foundation.Platform.TargetPlatform Platform { get; set; }
public virtual FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
public virtual bool ApplyElevationOverlayColor { get; set; }
public virtual FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme PageTransitionsTheme { get; set; }
public virtual FlutterSDK.Material.Appbartheme.AppBarTheme AppBarTheme { get; set; }
public virtual FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme BottomAppBarTheme { get; set; }
public virtual FlutterSDK.Material.Colorscheme.ColorScheme ColorScheme { get; set; }
public virtual FlutterSDK.Material.Snackbartheme.SnackBarThemeData SnackBarTheme { get; set; }
public virtual FlutterSDK.Material.Dialogtheme.DialogTheme DialogTheme { get; set; }
public virtual FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData FloatingActionButtonTheme { get; set; }
public virtual FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData NavigationRailTheme { get; set; }
public virtual FlutterSDK.Material.Typography.Typography Typography { get; set; }
public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData CupertinoOverrideTheme { get; set; }
public virtual FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData BottomSheetTheme { get; set; }
public virtual FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData PopupMenuTheme { get; set; }
public virtual FlutterSDK.Material.Bannertheme.MaterialBannerThemeData BannerTheme { get; set; }
public virtual FlutterSDK.Material.Dividertheme.DividerThemeData DividerTheme { get; set; }
public virtual FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData ButtonBarTheme { get; set; }
internal virtual int _LocalizedThemeDataCacheSize { get; set; }
internal virtual FlutterSDK.Material.Themedata._FifoCache<FlutterSDK.Material.Themedata._IdentityThemeDataCacheKey, FlutterSDK.Material.Themedata.ThemeData> _LocalizedThemeDataCache { get; set; }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Creates a copy of this theme but with the given fields replaced with the new values.
/// </Summary>
public virtual FlutterSDK.Material.Themedata.ThemeData CopyWith(Brightness brightness = default(Brightness), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), Brightness primaryColorBrightness = default(Brightness), FlutterBinding.UI.Color primaryColorLight = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColorDark = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color accentColor = default(FlutterBinding.UI.Color), Brightness accentColorBrightness = default(Brightness), FlutterBinding.UI.Color canvasColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color bottomAppBarColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cardColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory splashFactory = default(FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory), FlutterBinding.UI.Color selectedRowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color unselectedWidgetColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Buttontheme.ButtonThemeData buttonTheme = default(FlutterSDK.Material.Buttontheme.ButtonThemeData), FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme = default(FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData), FlutterBinding.UI.Color buttonColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondaryHeaderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionHandleColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dialogBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color indicatorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hintColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color errorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color toggleableActiveColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme primaryTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme accentTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Inputdecorator.InputDecorationTheme inputDecorationTheme = default(FlutterSDK.Material.Inputdecorator.InputDecorationTheme), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData primaryIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData accentIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Tabbartheme.TabBarTheme tabBarTheme = default(FlutterSDK.Material.Tabbartheme.TabBarTheme), FlutterSDK.Material.Tooltiptheme.TooltipThemeData tooltipTheme = default(FlutterSDK.Material.Tooltiptheme.TooltipThemeData), FlutterSDK.Material.Cardtheme.CardTheme cardTheme = default(FlutterSDK.Material.Cardtheme.CardTheme), FlutterSDK.Material.Chiptheme.ChipThemeData chipTheme = default(FlutterSDK.Material.Chiptheme.ChipThemeData), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), bool applyElevationOverlayColor = default(bool), FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme pageTransitionsTheme = default(FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme), FlutterSDK.Material.Appbartheme.AppBarTheme appBarTheme = default(FlutterSDK.Material.Appbartheme.AppBarTheme), FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme bottomAppBarTheme = default(FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme), FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Dialogtheme.DialogTheme dialogTheme = default(FlutterSDK.Material.Dialogtheme.DialogTheme), FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData floatingActionButtonTheme = default(FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData), FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData navigationRailTheme = default(FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData), FlutterSDK.Material.Typography.Typography typography = default(FlutterSDK.Material.Typography.Typography), FlutterSDK.Cupertino.Theme.CupertinoThemeData cupertinoOverrideTheme = default(FlutterSDK.Cupertino.Theme.CupertinoThemeData), FlutterSDK.Material.Snackbartheme.SnackBarThemeData snackBarTheme = default(FlutterSDK.Material.Snackbartheme.SnackBarThemeData), FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData bottomSheetTheme = default(FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData), FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData popupMenuTheme = default(FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData), FlutterSDK.Material.Bannertheme.MaterialBannerThemeData bannerTheme = default(FlutterSDK.Material.Bannertheme.MaterialBannerThemeData), FlutterSDK.Material.Dividertheme.DividerThemeData dividerTheme = default(FlutterSDK.Material.Dividertheme.DividerThemeData), FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData buttonBarTheme = default(FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData))
{
    cupertinoOverrideTheme = cupertinoOverrideTheme?.NoDefault();
    return ThemeData.Raw(brightness: brightness ?? this.Brightness, visualDensity: visualDensity ?? this.VisualDensity, primaryColor: primaryColor ?? this.PrimaryColor, primaryColorBrightness: primaryColorBrightness ?? this.PrimaryColorBrightness, primaryColorLight: primaryColorLight ?? this.PrimaryColorLight, primaryColorDark: primaryColorDark ?? this.PrimaryColorDark, accentColor: accentColor ?? this.AccentColor, accentColorBrightness: accentColorBrightness ?? this.AccentColorBrightness, canvasColor: canvasColor ?? this.CanvasColor, scaffoldBackgroundColor: scaffoldBackgroundColor ?? this.ScaffoldBackgroundColor, bottomAppBarColor: bottomAppBarColor ?? this.BottomAppBarColor, cardColor: cardColor ?? this.CardColor, dividerColor: dividerColor ?? this.DividerColor, focusColor: focusColor ?? this.FocusColor, hoverColor: hoverColor ?? this.HoverColor, highlightColor: highlightColor ?? this.HighlightColor, splashColor: splashColor ?? this.SplashColor, splashFactory: splashFactory ?? this.SplashFactory, selectedRowColor: selectedRowColor ?? this.SelectedRowColor, unselectedWidgetColor: unselectedWidgetColor ?? this.UnselectedWidgetColor, disabledColor: disabledColor ?? this.DisabledColor, buttonColor: buttonColor ?? this.ButtonColor, buttonTheme: buttonTheme ?? this.ButtonTheme, toggleButtonsTheme: toggleButtonsTheme ?? this.ToggleButtonsTheme, secondaryHeaderColor: secondaryHeaderColor ?? this.SecondaryHeaderColor, textSelectionColor: textSelectionColor ?? this.TextSelectionColor, cursorColor: cursorColor ?? this.CursorColor, textSelectionHandleColor: textSelectionHandleColor ?? this.TextSelectionHandleColor, backgroundColor: backgroundColor ?? this.BackgroundColor, dialogBackgroundColor: dialogBackgroundColor ?? this.DialogBackgroundColor, indicatorColor: indicatorColor ?? this.IndicatorColor, hintColor: hintColor ?? this.HintColor, errorColor: errorColor ?? this.ErrorColor, toggleableActiveColor: toggleableActiveColor ?? this.ToggleableActiveColor, textTheme: textTheme ?? this.TextTheme, primaryTextTheme: primaryTextTheme ?? this.PrimaryTextTheme, accentTextTheme: accentTextTheme ?? this.AccentTextTheme, inputDecorationTheme: inputDecorationTheme ?? this.InputDecorationTheme, iconTheme: iconTheme ?? this.IconTheme, primaryIconTheme: primaryIconTheme ?? this.PrimaryIconTheme, accentIconTheme: accentIconTheme ?? this.AccentIconTheme, sliderTheme: sliderTheme ?? this.SliderTheme, tabBarTheme: tabBarTheme ?? this.TabBarTheme, tooltipTheme: tooltipTheme ?? this.TooltipTheme, cardTheme: cardTheme ?? this.CardTheme, chipTheme: chipTheme ?? this.ChipTheme, platform: platform ?? this.Platform, materialTapTargetSize: materialTapTargetSize ?? this.MaterialTapTargetSize, applyElevationOverlayColor: applyElevationOverlayColor ?? this.ApplyElevationOverlayColor, pageTransitionsTheme: pageTransitionsTheme ?? this.PageTransitionsTheme, appBarTheme: appBarTheme ?? this.AppBarTheme, bottomAppBarTheme: bottomAppBarTheme ?? this.BottomAppBarTheme, colorScheme: colorScheme ?? this.ColorScheme, dialogTheme: dialogTheme ?? this.DialogTheme, floatingActionButtonTheme: floatingActionButtonTheme ?? this.FloatingActionButtonTheme, navigationRailTheme: navigationRailTheme ?? this.NavigationRailTheme, typography: typography ?? this.Typography, cupertinoOverrideTheme: cupertinoOverrideTheme ?? this.CupertinoOverrideTheme, snackBarTheme: snackBarTheme ?? this.SnackBarTheme, bottomSheetTheme: bottomSheetTheme ?? this.BottomSheetTheme, popupMenuTheme: popupMenuTheme ?? this.PopupMenuTheme, bannerTheme: bannerTheme ?? this.BannerTheme, dividerTheme: dividerTheme ?? this.DividerTheme, buttonBarTheme: buttonBarTheme ?? this.ButtonBarTheme);
}




/// <Summary>
/// Returns a new theme built by merging the text geometry provided by the
/// [localTextGeometry] theme with the [baseTheme].
///
/// For those text styles in the [baseTheme] whose [TextStyle.inherit] is set
/// to true, the returned theme's text styles inherit the geometric properties
/// of [localTextGeometry]. The resulting text styles' [TextStyle.inherit] is
/// set to those provided by [localTextGeometry].
/// </Summary>
public virtual FlutterSDK.Material.Themedata.ThemeData Localize(FlutterSDK.Material.Themedata.ThemeData baseTheme, FlutterSDK.Material.Texttheme.TextTheme localTextGeometry)
{


    return _LocalizedThemeDataCache.PutIfAbsent(new _IdentityThemeDataCacheKey(baseTheme, localTextGeometry), () =>
    {
        return baseTheme.CopyWith(primaryTextTheme: localTextGeometry.Merge(baseTheme.PrimaryTextTheme), accentTextTheme: localTextGeometry.Merge(baseTheme.AccentTextTheme), textTheme: localTextGeometry.Merge(baseTheme.TextTheme));
    }
    );
}




/// <Summary>
/// Determines whether the given [Color] is [Brightness.light] or
/// [Brightness.dark].
///
/// This compares the luminosity of the given color to a threshold value that
/// matches the material design specification.
/// </Summary>
public virtual Brightness EstimateBrightnessForColor(FlutterBinding.UI.Color color)
{
    double relativeLuminance = color.ComputeLuminance();
    double kThreshold = 0.15;
    if ((relativeLuminance + 0.05) * (relativeLuminance + 0.05) > kThreshold) return Brightness.Light;
    return Brightness.Dark;
}




/// <Summary>
/// Linearly interpolate between two themes.
///
/// The arguments must not be null.
///
/// {@macro dart.ui.shadow.lerp}
/// </Summary>
public virtual FlutterSDK.Material.Themedata.ThemeData Lerp(FlutterSDK.Material.Themedata.ThemeData a, FlutterSDK.Material.Themedata.ThemeData b, double t)
{



    return ThemeData.Raw(brightness: t < 0.5 ? a.Brightness : b.Brightness, visualDensity: ThemedataDefaultClass.VisualDensity.Lerp(a.VisualDensity, b.VisualDensity, t), primaryColor: Dart:uiDefaultClass.Color.Lerp(a.PrimaryColor, b.PrimaryColor, t), primaryColorBrightness: t < 0.5 ? a.PrimaryColorBrightness : b.PrimaryColorBrightness, primaryColorLight: Dart:uiDefaultClass.Color.Lerp(a.PrimaryColorLight, b.PrimaryColorLight, t), primaryColorDark: Dart:uiDefaultClass.Color.Lerp(a.PrimaryColorDark, b.PrimaryColorDark, t), canvasColor: Dart:uiDefaultClass.Color.Lerp(a.CanvasColor, b.CanvasColor, t), accentColor: Dart:uiDefaultClass.Color.Lerp(a.AccentColor, b.AccentColor, t), accentColorBrightness: t < 0.5 ? a.AccentColorBrightness : b.AccentColorBrightness, scaffoldBackgroundColor: Dart:uiDefaultClass.Color.Lerp(a.ScaffoldBackgroundColor, b.ScaffoldBackgroundColor, t), bottomAppBarColor: Dart:uiDefaultClass.Color.Lerp(a.BottomAppBarColor, b.BottomAppBarColor, t), cardColor: Dart:uiDefaultClass.Color.Lerp(a.CardColor, b.CardColor, t), dividerColor: Dart:uiDefaultClass.Color.Lerp(a.DividerColor, b.DividerColor, t), focusColor: Dart:uiDefaultClass.Color.Lerp(a.FocusColor, b.FocusColor, t), hoverColor: Dart:uiDefaultClass.Color.Lerp(a.HoverColor, b.HoverColor, t), highlightColor: Dart:uiDefaultClass.Color.Lerp(a.HighlightColor, b.HighlightColor, t), splashColor: Dart:uiDefaultClass.Color.Lerp(a.SplashColor, b.SplashColor, t), splashFactory: t < 0.5 ? a.SplashFactory : b.SplashFactory, selectedRowColor: Dart:uiDefaultClass.Color.Lerp(a.SelectedRowColor, b.SelectedRowColor, t), unselectedWidgetColor: Dart:uiDefaultClass.Color.Lerp(a.UnselectedWidgetColor, b.UnselectedWidgetColor, t), disabledColor: Dart:uiDefaultClass.Color.Lerp(a.DisabledColor, b.DisabledColor, t), buttonTheme: t < 0.5 ? a.ButtonTheme : b.ButtonTheme, toggleButtonsTheme: TogglebuttonsthemeDefaultClass.ToggleButtonsThemeData.Lerp(a.ToggleButtonsTheme, b.ToggleButtonsTheme, t), buttonColor: Dart:uiDefaultClass.Color.Lerp(a.ButtonColor, b.ButtonColor, t), secondaryHeaderColor: Dart:uiDefaultClass.Color.Lerp(a.SecondaryHeaderColor, b.SecondaryHeaderColor, t), textSelectionColor: Dart:uiDefaultClass.Color.Lerp(a.TextSelectionColor, b.TextSelectionColor, t), cursorColor: Dart:uiDefaultClass.Color.Lerp(a.CursorColor, b.CursorColor, t), textSelectionHandleColor: Dart:uiDefaultClass.Color.Lerp(a.TextSelectionHandleColor, b.TextSelectionHandleColor, t), backgroundColor: Dart:uiDefaultClass.Color.Lerp(a.BackgroundColor, b.BackgroundColor, t), dialogBackgroundColor: Dart:uiDefaultClass.Color.Lerp(a.DialogBackgroundColor, b.DialogBackgroundColor, t), indicatorColor: Dart:uiDefaultClass.Color.Lerp(a.IndicatorColor, b.IndicatorColor, t), hintColor: Dart:uiDefaultClass.Color.Lerp(a.HintColor, b.HintColor, t), errorColor: Dart:uiDefaultClass.Color.Lerp(a.ErrorColor, b.ErrorColor, t), toggleableActiveColor: Dart:uiDefaultClass.Color.Lerp(a.ToggleableActiveColor, b.ToggleableActiveColor, t), textTheme: TextthemeDefaultClass.TextTheme.Lerp(a.TextTheme, b.TextTheme, t), primaryTextTheme: TextthemeDefaultClass.TextTheme.Lerp(a.PrimaryTextTheme, b.PrimaryTextTheme, t), accentTextTheme: TextthemeDefaultClass.TextTheme.Lerp(a.AccentTextTheme, b.AccentTextTheme, t), inputDecorationTheme: t < 0.5 ? a.InputDecorationTheme : b.InputDecorationTheme, iconTheme: IconthemedataDefaultClass.IconThemeData.Lerp(a.IconTheme, b.IconTheme, t), primaryIconTheme: IconthemedataDefaultClass.IconThemeData.Lerp(a.PrimaryIconTheme, b.PrimaryIconTheme, t), accentIconTheme: IconthemedataDefaultClass.IconThemeData.Lerp(a.AccentIconTheme, b.AccentIconTheme, t), sliderTheme: SliderthemeDefaultClass.SliderThemeData.Lerp(a.SliderTheme, b.SliderTheme, t), tabBarTheme: TabbarthemeDefaultClass.TabBarTheme.Lerp(a.TabBarTheme, b.TabBarTheme, t), tooltipTheme: TooltipthemeDefaultClass.TooltipThemeData.Lerp(a.TooltipTheme, b.TooltipTheme, t), cardTheme: CardthemeDefaultClass.CardTheme.Lerp(a.CardTheme, b.CardTheme, t), chipTheme: ChipthemeDefaultClass.ChipThemeData.Lerp(a.ChipTheme, b.ChipTheme, t), platform: t < 0.5 ? a.Platform : b.Platform, materialTapTargetSize: t < 0.5 ? a.MaterialTapTargetSize : b.MaterialTapTargetSize, applyElevationOverlayColor: t < 0.5 ? a.ApplyElevationOverlayColor : b.ApplyElevationOverlayColor, pageTransitionsTheme: t < 0.5 ? a.PageTransitionsTheme : b.PageTransitionsTheme, appBarTheme: AppbarthemeDefaultClass.AppBarTheme.Lerp(a.AppBarTheme, b.AppBarTheme, t), bottomAppBarTheme: BottomappbarthemeDefaultClass.BottomAppBarTheme.Lerp(a.BottomAppBarTheme, b.BottomAppBarTheme, t), colorScheme: ColorschemeDefaultClass.ColorScheme.Lerp(a.ColorScheme, b.ColorScheme, t), dialogTheme: DialogthemeDefaultClass.DialogTheme.Lerp(a.DialogTheme, b.DialogTheme, t), floatingActionButtonTheme: FloatingactionbuttonthemeDefaultClass.FloatingActionButtonThemeData.Lerp(a.FloatingActionButtonTheme, b.FloatingActionButtonTheme, t), navigationRailTheme: NavigationrailthemeDefaultClass.NavigationRailThemeData.Lerp(a.NavigationRailTheme, b.NavigationRailTheme, t), typography: TypographyDefaultClass.Typography.Lerp(a.Typography, b.Typography, t), cupertinoOverrideTheme: t < 0.5 ? a.CupertinoOverrideTheme : b.CupertinoOverrideTheme, snackBarTheme: SnackbarthemeDefaultClass.SnackBarThemeData.Lerp(a.SnackBarTheme, b.SnackBarTheme, t), bottomSheetTheme: BottomsheetthemeDefaultClass.BottomSheetThemeData.Lerp(a.BottomSheetTheme, b.BottomSheetTheme, t), popupMenuTheme: PopupmenuthemeDefaultClass.PopupMenuThemeData.Lerp(a.PopupMenuTheme, b.PopupMenuTheme, t), bannerTheme: BannerthemeDefaultClass.MaterialBannerThemeData.Lerp(a.BannerTheme, b.BannerTheme, t), dividerTheme: DividerthemeDefaultClass.DividerThemeData.Lerp(a.DividerTheme, b.DividerTheme, t), buttonBarTheme: ButtonbarthemeDefaultClass.ButtonBarThemeData.Lerp(a.ButtonBarTheme, b.ButtonBarTheme, t));
}




public new bool Equals(@Object other)
{
    if (other.GetType() != GetType()) return false;
    return other is ThemeData && other.Brightness == Brightness && other.VisualDensity == VisualDensity && other.PrimaryColor == PrimaryColor && other.PrimaryColorBrightness == PrimaryColorBrightness && other.PrimaryColorLight == PrimaryColorLight && other.PrimaryColorDark == PrimaryColorDark && other.AccentColor == AccentColor && other.AccentColorBrightness == AccentColorBrightness && other.CanvasColor == CanvasColor && other.ScaffoldBackgroundColor == ScaffoldBackgroundColor && other.BottomAppBarColor == BottomAppBarColor && other.CardColor == CardColor && other.DividerColor == DividerColor && other.HighlightColor == HighlightColor && other.SplashColor == SplashColor && other.SplashFactory == SplashFactory && other.SelectedRowColor == SelectedRowColor && other.UnselectedWidgetColor == UnselectedWidgetColor && other.DisabledColor == DisabledColor && other.ButtonTheme == ButtonTheme && other.ButtonColor == ButtonColor && other.ToggleButtonsTheme == ToggleButtonsTheme && other.SecondaryHeaderColor == SecondaryHeaderColor && other.TextSelectionColor == TextSelectionColor && other.CursorColor == CursorColor && other.TextSelectionHandleColor == TextSelectionHandleColor && other.BackgroundColor == BackgroundColor && other.DialogBackgroundColor == DialogBackgroundColor && other.IndicatorColor == IndicatorColor && other.HintColor == HintColor && other.ErrorColor == ErrorColor && other.ToggleableActiveColor == ToggleableActiveColor && other.TextTheme == TextTheme && other.PrimaryTextTheme == PrimaryTextTheme && other.AccentTextTheme == AccentTextTheme && other.InputDecorationTheme == InputDecorationTheme && other.IconTheme == IconTheme && other.PrimaryIconTheme == PrimaryIconTheme && other.AccentIconTheme == AccentIconTheme && other.SliderTheme == SliderTheme && other.TabBarTheme == TabBarTheme && other.TooltipTheme == TooltipTheme && other.CardTheme == CardTheme && other.ChipTheme == ChipTheme && other.Platform == Platform && other.MaterialTapTargetSize == MaterialTapTargetSize && other.ApplyElevationOverlayColor == ApplyElevationOverlayColor && other.PageTransitionsTheme == PageTransitionsTheme && other.AppBarTheme == AppBarTheme && other.BottomAppBarTheme == BottomAppBarTheme && other.ColorScheme == ColorScheme && other.DialogTheme == DialogTheme && other.FloatingActionButtonTheme == FloatingActionButtonTheme && other.NavigationRailTheme == NavigationRailTheme && other.Typography == Typography && other.CupertinoOverrideTheme == CupertinoOverrideTheme && other.SnackBarTheme == SnackBarTheme && other.BottomSheetTheme == BottomSheetTheme && other.PopupMenuTheme == PopupMenuTheme && other.BannerTheme == BannerTheme && other.DividerTheme == DividerTheme && other.ButtonBarTheme == ButtonBarTheme;
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    ThemeData defaultData = ThemeData.Fallback();
    properties.Add(new EnumProperty<TargetPlatform>("platform", Platform, defaultValue: PlatformDefaultClass.DefaultTargetPlatform, level: DiagnosticLevel.Debug));
    properties.Add(new EnumProperty<Brightness>("brightness", Brightness, defaultValue: defaultData.Brightness, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("primaryColor", PrimaryColor, defaultValue: defaultData.PrimaryColor, level: DiagnosticLevel.Debug));
    properties.Add(new EnumProperty<Brightness>("primaryColorBrightness", PrimaryColorBrightness, defaultValue: defaultData.PrimaryColorBrightness, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("accentColor", AccentColor, defaultValue: defaultData.AccentColor, level: DiagnosticLevel.Debug));
    properties.Add(new EnumProperty<Brightness>("accentColorBrightness", AccentColorBrightness, defaultValue: defaultData.AccentColorBrightness, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("canvasColor", CanvasColor, defaultValue: defaultData.CanvasColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("scaffoldBackgroundColor", ScaffoldBackgroundColor, defaultValue: defaultData.ScaffoldBackgroundColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("bottomAppBarColor", BottomAppBarColor, defaultValue: defaultData.BottomAppBarColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("cardColor", CardColor, defaultValue: defaultData.CardColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("dividerColor", DividerColor, defaultValue: defaultData.DividerColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("focusColor", FocusColor, defaultValue: defaultData.FocusColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("hoverColor", HoverColor, defaultValue: defaultData.HoverColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("highlightColor", HighlightColor, defaultValue: defaultData.HighlightColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("splashColor", SplashColor, defaultValue: defaultData.SplashColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("selectedRowColor", SelectedRowColor, defaultValue: defaultData.SelectedRowColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("unselectedWidgetColor", UnselectedWidgetColor, defaultValue: defaultData.UnselectedWidgetColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("disabledColor", DisabledColor, defaultValue: defaultData.DisabledColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("buttonColor", ButtonColor, defaultValue: defaultData.ButtonColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("secondaryHeaderColor", SecondaryHeaderColor, defaultValue: defaultData.SecondaryHeaderColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("textSelectionColor", TextSelectionColor, defaultValue: defaultData.TextSelectionColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("cursorColor", CursorColor, defaultValue: defaultData.CursorColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("textSelectionHandleColor", TextSelectionHandleColor, defaultValue: defaultData.TextSelectionHandleColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("backgroundColor", BackgroundColor, defaultValue: defaultData.BackgroundColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("dialogBackgroundColor", DialogBackgroundColor, defaultValue: defaultData.DialogBackgroundColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("indicatorColor", IndicatorColor, defaultValue: defaultData.IndicatorColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("hintColor", HintColor, defaultValue: defaultData.HintColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("errorColor", ErrorColor, defaultValue: defaultData.ErrorColor, level: DiagnosticLevel.Debug));
    properties.Add(new ColorProperty("toggleableActiveColor", ToggleableActiveColor, defaultValue: defaultData.ToggleableActiveColor, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<ButtonThemeData>("buttonTheme", ButtonTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<ToggleButtonsThemeData>("toggleButtonsTheme", ToggleButtonsTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<TextTheme>("textTheme", TextTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<TextTheme>("primaryTextTheme", PrimaryTextTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<TextTheme>("accentTextTheme", AccentTextTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<InputDecorationTheme>("inputDecorationTheme", InputDecorationTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<IconThemeData>("iconTheme", IconTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<IconThemeData>("primaryIconTheme", PrimaryIconTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<IconThemeData>("accentIconTheme", AccentIconTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<SliderThemeData>("sliderTheme", SliderTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<TabBarTheme>("tabBarTheme", TabBarTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<TooltipThemeData>("tooltipTheme", TooltipTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<CardTheme>("cardTheme", CardTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<ChipThemeData>("chipTheme", ChipTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<MaterialTapTargetSize>("materialTapTargetSize", MaterialTapTargetSize, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<bool>("applyElevationOverlayColor", ApplyElevationOverlayColor, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<PageTransitionsTheme>("pageTransitionsTheme", PageTransitionsTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<AppBarTheme>("appBarTheme", AppBarTheme, defaultValue: defaultData.AppBarTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<BottomAppBarTheme>("bottomAppBarTheme", BottomAppBarTheme, defaultValue: defaultData.BottomAppBarTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<ColorScheme>("colorScheme", ColorScheme, defaultValue: defaultData.ColorScheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<DialogTheme>("dialogTheme", DialogTheme, defaultValue: defaultData.DialogTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<FloatingActionButtonThemeData>("floatingActionButtonThemeData", FloatingActionButtonTheme, defaultValue: defaultData.FloatingActionButtonTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<NavigationRailThemeData>("navigationRailThemeData", NavigationRailTheme, defaultValue: defaultData.NavigationRailTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<Typography>("typography", Typography, defaultValue: defaultData.Typography, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<CupertinoThemeData>("cupertinoOverrideTheme", CupertinoOverrideTheme, defaultValue: defaultData.CupertinoOverrideTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<SnackBarThemeData>("snackBarTheme", SnackBarTheme, defaultValue: defaultData.SnackBarTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<BottomSheetThemeData>("bottomSheetTheme", BottomSheetTheme, defaultValue: defaultData.BottomSheetTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<PopupMenuThemeData>("popupMenuTheme", PopupMenuTheme, defaultValue: defaultData.PopupMenuTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<MaterialBannerThemeData>("bannerTheme", BannerTheme, defaultValue: defaultData.BannerTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<DividerThemeData>("dividerTheme", DividerTheme, defaultValue: defaultData.DividerTheme, level: DiagnosticLevel.Debug));
    properties.Add(new DiagnosticsProperty<ButtonBarThemeData>("buttonBarTheme", ButtonBarTheme, defaultValue: defaultData.ButtonBarTheme, level: DiagnosticLevel.Debug));
}



#endregion
}


/// <Summary>
/// A [CupertinoThemeData] that defers unspecified theme attributes to an
/// upstream Material [ThemeData].
///
/// This type of [CupertinoThemeData] is used by the Material [Theme] to
/// harmonize the [CupertinoTheme] with the material theme's colors and text
/// styles.
///
/// In the most basic case, [ThemeData]'s `cupertinoOverrideTheme` is null and
/// and descendant Cupertino widgets' styling is derived from the Material theme.
///
/// To override individual parts of the Material-derived Cupertino styling,
/// `cupertinoOverrideTheme`'s construction parameters can be used.
///
/// To completely decouple the Cupertino styling from Material theme derivation,
/// another [CupertinoTheme] widget can be inserted as a descendant of the
/// Material [Theme]. On a [MaterialApp], this can be done using the `builder`
/// parameter on the constructor.
///
/// See also:
///
///  * [CupertinoThemeData], whose null constructor parameters default to
///    reasonable iOS styling defaults rather than harmonizing with a Material
///    theme.
///  * [Theme], widget which inserts a [CupertinoTheme] with this
///    [MaterialBasedCupertinoThemeData].
/// </Summary>
public class MaterialBasedCupertinoThemeData : FlutterSDK.Cupertino.Theme.CupertinoThemeData
{
    #region constructors
    public MaterialBasedCupertinoThemeData(FlutterSDK.Material.Themedata.ThemeData materialTheme = default(FlutterSDK.Material.Themedata.ThemeData))
    : base()

}
internal MaterialBasedCupertinoThemeData(FlutterSDK.Material.Themedata.ThemeData _materialTheme, FlutterSDK.Cupertino.Theme.CupertinoThemeData _cupertinoOverrideTheme)
: base(_cupertinoOverrideTheme.Brightness, _cupertinoOverrideTheme.PrimaryColor, _cupertinoOverrideTheme.PrimaryContrastingColor, _cupertinoOverrideTheme.TextTheme, _cupertinoOverrideTheme.BarBackgroundColor, _cupertinoOverrideTheme.ScaffoldBackgroundColor)

}
#endregion

#region fields
internal virtual FlutterSDK.Material.Themedata.ThemeData _MaterialTheme { get; set; }
internal virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData _CupertinoOverrideTheme { get; set; }
public virtual Brightness Brightness { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color PrimaryColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color PrimaryContrastingColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color ScaffoldBackgroundColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Copies the [ThemeData]'s `cupertinoOverrideTheme`.
///
/// Only the specified override attributes of the [ThemeData]'s
/// `cupertinoOverrideTheme` and the newly specified parameters are in the
/// returned [CupertinoThemeData]. No derived attributes from iOS defaults or
/// from cascaded Material theme attributes are copied.
///
/// [MaterialBasedCupertinoThemeData.copyWith] cannot change the base
/// Material [ThemeData]. To change the base Material [ThemeData], create a
/// new Material [Theme] and use `copyWith` on the Material [ThemeData]
/// instead.
/// </Summary>
public new FlutterSDK.Material.Themedata.MaterialBasedCupertinoThemeData CopyWith(Brightness brightness = default(Brightness), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryContrastingColor = default(FlutterBinding.UI.Color), FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme = default(FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData), FlutterBinding.UI.Color barBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color))
{
    return MaterialBasedCupertinoThemeData._(_MaterialTheme, _CupertinoOverrideTheme.CopyWith(brightness: brightness, primaryColor: primaryColor, primaryContrastingColor: primaryContrastingColor, textTheme: textTheme, barBackgroundColor: barBackgroundColor, scaffoldBackgroundColor: scaffoldBackgroundColor));
}




public new FlutterSDK.Cupertino.Theme.CupertinoThemeData ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
{
    return MaterialBasedCupertinoThemeData._(_MaterialTheme, _CupertinoOverrideTheme.ResolveFrom(context, nullOk: nullOk));
}



#endregion
}


public class _IdentityThemeDataCacheKey
{
    #region constructors
    public _IdentityThemeDataCacheKey(FlutterSDK.Material.Themedata.ThemeData baseTheme, FlutterSDK.Material.Texttheme.TextTheme localTextGeometry)

}
#endregion

#region fields
public virtual FlutterSDK.Material.Themedata.ThemeData BaseTheme { get; set; }
public virtual FlutterSDK.Material.Texttheme.TextTheme LocalTextGeometry { get; set; }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool Equals(@Object other)
{
    return other is _IdentityThemeDataCacheKey && Dart:coreDefaultClass.Identical(other.BaseTheme, BaseTheme) && Dart:coreDefaultClass.Identical(other.LocalTextGeometry, LocalTextGeometry);
}



#endregion
}


/// <Summary>
/// Cache of objects of limited size that uses the first in first out eviction
/// strategy (a.k.a least recently inserted).
///
/// The key that was inserted before all other keys is evicted first, i.e. the
/// one inserted least recently.
/// </Summary>
public class _FifoCache<K, V>
{
    #region constructors
    public _FifoCache(int _maximumSize)
    : base()

}
#endregion

#region fields
internal virtual Dictionary<K, V> _Cache { get; set; }
internal virtual int _MaximumSize { get; set; }
#endregion

#region methods

/// <Summary>
/// Returns the previously cached value for the given key, if available;
/// if not, calls the given callback to obtain it first.
///
/// The arguments must not be null.
/// </Summary>
public virtual V PutIfAbsent(K key, Func<V> loader)
{


    V result = _Cache[key];
    if (result != null) return result;
    if (_Cache.Length == _MaximumSize) _Cache.Remove(_Cache.Keys.First);
    return _Cache[key] = loader();
}



#endregion
}


/// <Summary>
/// Defines the visual density of user interface components.
///
/// Density, in the context of a UI, is the vertical and horizontal
/// "compactness" of the components in the UI. It is unitless, since it means
/// different things to different UI components.
///
/// The default for visual densities is zero for both vertical and horizontal
/// densities, which corresponds to the default visual density of components in
/// the Material Design specification. It does not affect text sizes, icon
/// sizes, or padding values.
///
/// For example, for buttons, it affects the spacing around the child of the
/// button. For lists, it affects the distance between baselines of entries in
/// the list. For chips, it only affects the vertical size, not the horizontal
/// size.
///
/// See also:
///
///  * [ThemeData.visualDensity], where this property is used to specify the base
///    horizontal density of Material components.
///  * [Material design guidance on density](https://material.io/design/layout/applying-density.html).
/// </Summary>
public class VisualDensity : IDiagnosticable
{
    #region constructors
    public VisualDensity(double horizontal = 0.0, double vertical = 0.0)
    : base()

}
#endregion

#region fields
public virtual double MinimumDensity { get; set; }
public virtual double MaximumDensity { get; set; }
public virtual FlutterSDK.Material.Themedata.VisualDensity Standard { get; set; }
public virtual FlutterSDK.Material.Themedata.VisualDensity Comfortable { get; set; }
public virtual FlutterSDK.Material.Themedata.VisualDensity Compact { get; set; }
public virtual double Horizontal { get; set; }
public virtual double Vertical { get; set; }
public virtual FlutterSDK.Material.Themedata.VisualDensity AdaptivePlatformDensity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Offset BaseSizeAdjustment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Copy the current [VisualDensity] with the given values replacing the
/// current values.
/// </Summary>
public virtual FlutterSDK.Material.Themedata.VisualDensity CopyWith(double horizontal = default(double), double vertical = default(double))
{
    return new VisualDensity(horizontal: horizontal == default(double) ? this.horizontal : horizontal, vertical: vertical == default(double) ? this.vertical : vertical);
}




/// <Summary>
/// Linearly interpolate between two densities.
/// </Summary>
public virtual FlutterSDK.Material.Themedata.VisualDensity Lerp(FlutterSDK.Material.Themedata.VisualDensity a, FlutterSDK.Material.Themedata.VisualDensity b, double t)
{
    return new VisualDensity(horizontal: Dart:uiDefaultClass.LerpDouble(a.Horizontal, b.Horizontal, t), vertical: Dart:uiDefaultClass.LerpDouble(a.Horizontal, b.Horizontal, t));
}




/// <Summary>
/// Return a copy of [constraints] whose minimum width and height have been
/// updated with the [baseSizeAdjustment].
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints EffectiveConstraints(FlutterSDK.Rendering.Box.BoxConstraints constraints)
{

    return constraints.CopyWith(minWidth: (constraints.MinWidth + BaseSizeAdjustment.Dx).Clamp(0.0, Dart: coreDefaultClass.Double.Infinity).ToDouble(), minHeight: (constraints.MinHeight + BaseSizeAdjustment.Dy).Clamp(0.0, Dart: coreDefaultClass.Double.Infinity).ToDouble());
}




public new bool Equals(@Object other)
{
    if (other.GetType() != GetType())
    {
        return false;
    }

    return other is VisualDensity && other.Horizontal == Horizontal && other.Vertical == Vertical;
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DoubleProperty("horizontal", Horizontal, defaultValue: 0.0));
    properties.Add(new DoubleProperty("vertical", Vertical, defaultValue: 0.0));
}




public new string ToStringShort()
{
    return $"'{base.ToStringShort()}(h: {DebugDefaultClass.DebugFormatDouble(Horizontal)}, v: {DebugDefaultClass.DebugFormatDouble(Vertical)})'";
}



#endregion
}


/// <Summary>
/// Configures the tap target and layout size of certain Material widgets.
///
/// Changing the value in [ThemeData.materialTapTargetSize] will affect the
/// accessibility experience.
///
/// Some of the impacted widgets include:
///
///   * [FloatingActionButton], only the mini tap target size is increased.
///   * [MaterialButton]
///   * [OutlineButton]
///   * [FlatButton]
///   * [RaisedButton]
///   * [TimePicker]
///   * [SnackBar]
///   * [Chip]
///   * [RawChip]
///   * [InputChip]
///   * [ChoiceChip]
///   * [FilterChip]
///   * [ActionChip]
///   * [Radio]
///   * [Switch]
///   * [Checkbox]
/// </Summary>
public enum MaterialTapTargetSize
{

    /// <Summary>
    /// Expands the minimum tap target size to 48px by 48px.
    ///
    /// This is the default value of [ThemeData.materialHitTestSize] and the
    /// recommended size to conform to Android accessibility scanner
    /// recommendations.
    /// </Summary>
    Padded,
    /// <Summary>
    /// Shrinks the tap target size to the minimum provided by the Material
    /// specification.
    /// </Summary>
    ShrinkWrap,
}

}
