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

    public class ThemeData : IDiagnosticable
    {
        #region constructors
        public ThemeData(Brightness brightness = default(Brightness), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Colors.MaterialColor primarySwatch = default(FlutterSDK.Material.Colors.MaterialColor), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), Brightness primaryColorBrightness = default(Brightness), FlutterBinding.UI.Color primaryColorLight = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColorDark = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color accentColor = default(FlutterBinding.UI.Color), Brightness accentColorBrightness = default(Brightness), FlutterBinding.UI.Color canvasColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color bottomAppBarColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cardColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory splashFactory = default(FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory), FlutterBinding.UI.Color selectedRowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color unselectedWidgetColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color buttonColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Buttontheme.ButtonThemeData buttonTheme = default(FlutterSDK.Material.Buttontheme.ButtonThemeData), FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme = default(FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData), FlutterBinding.UI.Color secondaryHeaderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionHandleColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dialogBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color indicatorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hintColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color errorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color toggleableActiveColor = default(FlutterBinding.UI.Color), string fontFamily = default(string), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme primaryTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme accentTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Inputdecorator.InputDecorationTheme inputDecorationTheme = default(FlutterSDK.Material.Inputdecorator.InputDecorationTheme), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData primaryIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData accentIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Tabbartheme.TabBarTheme tabBarTheme = default(FlutterSDK.Material.Tabbartheme.TabBarTheme), FlutterSDK.Material.Tooltiptheme.TooltipThemeData tooltipTheme = default(FlutterSDK.Material.Tooltiptheme.TooltipThemeData), FlutterSDK.Material.Cardtheme.CardTheme cardTheme = default(FlutterSDK.Material.Cardtheme.CardTheme), FlutterSDK.Material.Chiptheme.ChipThemeData chipTheme = default(FlutterSDK.Material.Chiptheme.ChipThemeData), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), bool applyElevationOverlayColor = default(bool), FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme pageTransitionsTheme = default(FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme), FlutterSDK.Material.Appbartheme.AppBarTheme appBarTheme = default(FlutterSDK.Material.Appbartheme.AppBarTheme), FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme bottomAppBarTheme = default(FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme), FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Dialogtheme.DialogTheme dialogTheme = default(FlutterSDK.Material.Dialogtheme.DialogTheme), FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData floatingActionButtonTheme = default(FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData), FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData navigationRailTheme = default(FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData), FlutterSDK.Material.Typography.Typography typography = default(FlutterSDK.Material.Typography.Typography), FlutterSDK.Cupertino.Theme.CupertinoThemeData cupertinoOverrideTheme = default(FlutterSDK.Cupertino.Theme.CupertinoThemeData), FlutterSDK.Material.Snackbartheme.SnackBarThemeData snackBarTheme = default(FlutterSDK.Material.Snackbartheme.SnackBarThemeData), FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData bottomSheetTheme = default(FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData), FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData popupMenuTheme = default(FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData), FlutterSDK.Material.Bannertheme.MaterialBannerThemeData bannerTheme = default(FlutterSDK.Material.Bannertheme.MaterialBannerThemeData), FlutterSDK.Material.Dividertheme.DividerThemeData dividerTheme = default(FlutterSDK.Material.Dividertheme.DividerThemeData), FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData buttonBarTheme = default(FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData))
        {
            throw new NotImplementedException();
        }
        public static ThemeData Raw(Brightness brightness = default(Brightness), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), Brightness primaryColorBrightness = default(Brightness), FlutterBinding.UI.Color primaryColorLight = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColorDark = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color canvasColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color accentColor = default(FlutterBinding.UI.Color), Brightness accentColorBrightness = default(Brightness), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color bottomAppBarColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cardColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory splashFactory = default(FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory), FlutterBinding.UI.Color selectedRowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color unselectedWidgetColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Buttontheme.ButtonThemeData buttonTheme = default(FlutterSDK.Material.Buttontheme.ButtonThemeData), FlutterBinding.UI.Color buttonColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme = default(FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData), FlutterBinding.UI.Color secondaryHeaderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionHandleColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dialogBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color indicatorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hintColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color errorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color toggleableActiveColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme primaryTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme accentTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Inputdecorator.InputDecorationTheme inputDecorationTheme = default(FlutterSDK.Material.Inputdecorator.InputDecorationTheme), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData primaryIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData accentIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Tabbartheme.TabBarTheme tabBarTheme = default(FlutterSDK.Material.Tabbartheme.TabBarTheme), FlutterSDK.Material.Tooltiptheme.TooltipThemeData tooltipTheme = default(FlutterSDK.Material.Tooltiptheme.TooltipThemeData), FlutterSDK.Material.Cardtheme.CardTheme cardTheme = default(FlutterSDK.Material.Cardtheme.CardTheme), FlutterSDK.Material.Chiptheme.ChipThemeData chipTheme = default(FlutterSDK.Material.Chiptheme.ChipThemeData), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), bool applyElevationOverlayColor = default(bool), FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme pageTransitionsTheme = default(FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme), FlutterSDK.Material.Appbartheme.AppBarTheme appBarTheme = default(FlutterSDK.Material.Appbartheme.AppBarTheme), FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme bottomAppBarTheme = default(FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme), FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Dialogtheme.DialogTheme dialogTheme = default(FlutterSDK.Material.Dialogtheme.DialogTheme), FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData floatingActionButtonTheme = default(FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData), FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData navigationRailTheme = default(FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData), FlutterSDK.Material.Typography.Typography typography = default(FlutterSDK.Material.Typography.Typography), FlutterSDK.Cupertino.Theme.CupertinoThemeData cupertinoOverrideTheme = default(FlutterSDK.Cupertino.Theme.CupertinoThemeData), FlutterSDK.Material.Snackbartheme.SnackBarThemeData snackBarTheme = default(FlutterSDK.Material.Snackbartheme.SnackBarThemeData), FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData bottomSheetTheme = default(FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData), FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData popupMenuTheme = default(FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData), FlutterSDK.Material.Bannertheme.MaterialBannerThemeData bannerTheme = default(FlutterSDK.Material.Bannertheme.MaterialBannerThemeData), FlutterSDK.Material.Dividertheme.DividerThemeData dividerTheme = default(FlutterSDK.Material.Dividertheme.DividerThemeData), FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData buttonBarTheme = default(FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData))
        {
            var instance = new ThemeData(); instance.Brightness = brightness;
            instance.VisualDensity = visualDensity;
            instance.PrimaryColor = primaryColor;
            instance.PrimaryColorBrightness = primaryColorBrightness;
            instance.PrimaryColorLight = primaryColorLight;
            instance.PrimaryColorDark = primaryColorDark;
            instance.CanvasColor = canvasColor;
            instance.AccentColor = accentColor;
            instance.AccentColorBrightness = accentColorBrightness;
            instance.ScaffoldBackgroundColor = scaffoldBackgroundColor;
            instance.BottomAppBarColor = bottomAppBarColor;
            instance.CardColor = cardColor;
            instance.DividerColor = dividerColor;
            instance.FocusColor = focusColor;
            instance.HoverColor = hoverColor;
            instance.HighlightColor = highlightColor;
            instance.SplashColor = splashColor;
            instance.SplashFactory = splashFactory;
            instance.SelectedRowColor = selectedRowColor;
            instance.UnselectedWidgetColor = unselectedWidgetColor;
            instance.DisabledColor = disabledColor;
            instance.ButtonTheme = buttonTheme;
            instance.ButtonColor = buttonColor;
            instance.ToggleButtonsTheme = toggleButtonsTheme;
            instance.SecondaryHeaderColor = secondaryHeaderColor;
            instance.TextSelectionColor = textSelectionColor;
            instance.CursorColor = cursorColor;
            instance.TextSelectionHandleColor = textSelectionHandleColor;
            instance.BackgroundColor = backgroundColor;
            instance.DialogBackgroundColor = dialogBackgroundColor;
            instance.IndicatorColor = indicatorColor;
            instance.HintColor = hintColor;
            instance.ErrorColor = errorColor;
            instance.ToggleableActiveColor = toggleableActiveColor;
            instance.TextTheme = textTheme;
            instance.PrimaryTextTheme = primaryTextTheme;
            instance.AccentTextTheme = accentTextTheme;
            instance.InputDecorationTheme = inputDecorationTheme;
            instance.IconTheme = iconTheme;
            instance.PrimaryIconTheme = primaryIconTheme;
            instance.AccentIconTheme = accentIconTheme;
            instance.SliderTheme = sliderTheme;
            instance.TabBarTheme = tabBarTheme;
            instance.TooltipTheme = tooltipTheme;
            instance.CardTheme = cardTheme;
            instance.ChipTheme = chipTheme;
            instance.Platform = platform;
            instance.MaterialTapTargetSize = materialTapTargetSize;
            instance.ApplyElevationOverlayColor = applyElevationOverlayColor;
            instance.PageTransitionsTheme = pageTransitionsTheme;
            instance.AppBarTheme = appBarTheme;
            instance.BottomAppBarTheme = bottomAppBarTheme;
            instance.ColorScheme = colorScheme;
            instance.DialogTheme = dialogTheme;
            instance.FloatingActionButtonTheme = floatingActionButtonTheme;
            instance.NavigationRailTheme = navigationRailTheme;
            instance.Typography = typography;
            instance.CupertinoOverrideTheme = cupertinoOverrideTheme;
            instance.SnackBarTheme = snackBarTheme;
            instance.BottomSheetTheme = bottomSheetTheme;
            instance.PopupMenuTheme = popupMenuTheme;
            instance.BannerTheme = bannerTheme;
            instance.DividerTheme = dividerTheme;
            instance.ButtonBarTheme = buttonBarTheme; throw new NotImplementedException();
        }
        public static ThemeData From(FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme))
        {
            var instance = new ThemeData(); throw new NotImplementedException();
        }
        public static ThemeData Light()
        {
            var instance = new ThemeData(); throw new NotImplementedException();
        }
        public static ThemeData Dark()
        {
            var instance = new ThemeData(); throw new NotImplementedException();
        }
        public static ThemeData Fallback()
        {
            var instance = new ThemeData(); throw new NotImplementedException();
        }
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

        public virtual FlutterSDK.Material.Themedata.ThemeData CopyWith(Brightness brightness = default(Brightness), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), Brightness primaryColorBrightness = default(Brightness), FlutterBinding.UI.Color primaryColorLight = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColorDark = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color accentColor = default(FlutterBinding.UI.Color), Brightness accentColorBrightness = default(Brightness), FlutterBinding.UI.Color canvasColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color bottomAppBarColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cardColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory splashFactory = default(FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory), FlutterBinding.UI.Color selectedRowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color unselectedWidgetColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Buttontheme.ButtonThemeData buttonTheme = default(FlutterSDK.Material.Buttontheme.ButtonThemeData), FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData toggleButtonsTheme = default(FlutterSDK.Material.Togglebuttonstheme.ToggleButtonsThemeData), FlutterBinding.UI.Color buttonColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondaryHeaderColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textSelectionHandleColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color dialogBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color indicatorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hintColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color errorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color toggleableActiveColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme primaryTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme accentTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Inputdecorator.InputDecorationTheme inputDecorationTheme = default(FlutterSDK.Material.Inputdecorator.InputDecorationTheme), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData primaryIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData accentIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData), FlutterSDK.Material.Tabbartheme.TabBarTheme tabBarTheme = default(FlutterSDK.Material.Tabbartheme.TabBarTheme), FlutterSDK.Material.Tooltiptheme.TooltipThemeData tooltipTheme = default(FlutterSDK.Material.Tooltiptheme.TooltipThemeData), FlutterSDK.Material.Cardtheme.CardTheme cardTheme = default(FlutterSDK.Material.Cardtheme.CardTheme), FlutterSDK.Material.Chiptheme.ChipThemeData chipTheme = default(FlutterSDK.Material.Chiptheme.ChipThemeData), FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), bool applyElevationOverlayColor = default(bool), FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme pageTransitionsTheme = default(FlutterSDK.Material.Pagetransitionstheme.PageTransitionsTheme), FlutterSDK.Material.Appbartheme.AppBarTheme appBarTheme = default(FlutterSDK.Material.Appbartheme.AppBarTheme), FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme bottomAppBarTheme = default(FlutterSDK.Material.Bottomappbartheme.BottomAppBarTheme), FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Dialogtheme.DialogTheme dialogTheme = default(FlutterSDK.Material.Dialogtheme.DialogTheme), FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData floatingActionButtonTheme = default(FlutterSDK.Material.Floatingactionbuttontheme.FloatingActionButtonThemeData), FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData navigationRailTheme = default(FlutterSDK.Material.Navigationrailtheme.NavigationRailThemeData), FlutterSDK.Material.Typography.Typography typography = default(FlutterSDK.Material.Typography.Typography), FlutterSDK.Cupertino.Theme.CupertinoThemeData cupertinoOverrideTheme = default(FlutterSDK.Cupertino.Theme.CupertinoThemeData), FlutterSDK.Material.Snackbartheme.SnackBarThemeData snackBarTheme = default(FlutterSDK.Material.Snackbartheme.SnackBarThemeData), FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData bottomSheetTheme = default(FlutterSDK.Material.Bottomsheettheme.BottomSheetThemeData), FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData popupMenuTheme = default(FlutterSDK.Material.Popupmenutheme.PopupMenuThemeData), FlutterSDK.Material.Bannertheme.MaterialBannerThemeData bannerTheme = default(FlutterSDK.Material.Bannertheme.MaterialBannerThemeData), FlutterSDK.Material.Dividertheme.DividerThemeData dividerTheme = default(FlutterSDK.Material.Dividertheme.DividerThemeData), FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData buttonBarTheme = default(FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Material.Themedata.ThemeData Localize(FlutterSDK.Material.Themedata.ThemeData baseTheme, FlutterSDK.Material.Texttheme.TextTheme localTextGeometry) { throw new NotImplementedException(); }


        public virtual Brightness EstimateBrightnessForColor(FlutterBinding.UI.Color color) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Material.Themedata.ThemeData Lerp(FlutterSDK.Material.Themedata.ThemeData a, FlutterSDK.Material.Themedata.ThemeData b, double t) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class MaterialBasedCupertinoThemeData : FlutterSDK.Cupertino.Theme.CupertinoThemeData
    {
        #region constructors
        public MaterialBasedCupertinoThemeData(FlutterSDK.Material.Themedata.ThemeData materialTheme = default(FlutterSDK.Material.Themedata.ThemeData))
        : base()
        {
            throw new NotImplementedException();
        }
        internal MaterialBasedCupertinoThemeData(FlutterSDK.Material.Themedata.ThemeData _materialTheme, FlutterSDK.Cupertino.Theme.CupertinoThemeData _cupertinoOverrideTheme)
        : base(_cupertinoOverrideTheme.Brightness, _cupertinoOverrideTheme.PrimaryColor, _cupertinoOverrideTheme.PrimaryContrastingColor, _cupertinoOverrideTheme.TextTheme, _cupertinoOverrideTheme.BarBackgroundColor, _cupertinoOverrideTheme.ScaffoldBackgroundColor)
        {
            this._MaterialTheme = _materialTheme;
            this._CupertinoOverrideTheme = _cupertinoOverrideTheme; throw new NotImplementedException();
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

        public new FlutterSDK.Material.Themedata.MaterialBasedCupertinoThemeData CopyWith(Brightness brightness = default(Brightness), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryContrastingColor = default(FlutterBinding.UI.Color), FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme = default(FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData), FlutterBinding.UI.Color barBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color)) { throw new NotImplementedException(); }


        public new FlutterSDK.Cupertino.Theme.CupertinoThemeData ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false) { throw new NotImplementedException(); }

        #endregion
    }


    public class _IdentityThemeDataCacheKey
    {
        #region constructors
        public _IdentityThemeDataCacheKey(FlutterSDK.Material.Themedata.ThemeData baseTheme, FlutterSDK.Material.Texttheme.TextTheme localTextGeometry)
        {
            this.BaseTheme = baseTheme;
            this.LocalTextGeometry = localTextGeometry; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Themedata.ThemeData BaseTheme { get; set; }
        public virtual FlutterSDK.Material.Texttheme.TextTheme LocalTextGeometry { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }

        #endregion
    }


    public class _FifoCache<K, V>
    {
        #region constructors
        public _FifoCache(int _maximumSize)
        : base()
        {
            this._MaximumSize = _maximumSize; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual Dictionary<K, V> _Cache { get; set; }
        internal virtual int _MaximumSize { get; set; }
        #endregion

        #region methods

        public virtual V PutIfAbsent(K key, Func<V> loader) { throw new NotImplementedException(); }

        #endregion
    }


    public class VisualDensity : IDiagnosticable
    {
        #region constructors
        public VisualDensity(double horizontal = 0.0, double vertical = 0.0)
        : base()
        {
            this.Horizontal = horizontal;
            this.Vertical = vertical; throw new NotImplementedException();
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

        public virtual FlutterSDK.Material.Themedata.VisualDensity CopyWith(double horizontal = default(double), double vertical = default(double)) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Material.Themedata.VisualDensity Lerp(FlutterSDK.Material.Themedata.VisualDensity a, FlutterSDK.Material.Themedata.VisualDensity b, double t) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.Box.BoxConstraints EffectiveConstraints(FlutterSDK.Rendering.Box.BoxConstraints constraints) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }

        #endregion
    }


    public enum MaterialTapTargetSize
    {

        Padded,
        ShrinkWrap,
    }

}
