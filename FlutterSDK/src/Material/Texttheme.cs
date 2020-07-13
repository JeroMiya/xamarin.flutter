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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Material.Texttheme
{
    internal static class TextthemeDefaultClass
    {
    }

    /// <Summary>
    /// Material design text theme.
    ///
    /// Definitions for the various typographical styles found in Material Design
    /// (e.g., button, caption). Rather than creating a [TextTheme] directly,
    /// you can obtain an instance as [Typography.black] or [Typography.white].
    ///
    /// To obtain the current text theme, call [Theme.of] with the current
    /// [BuildContext] and read the [ThemeData.textTheme] property.
    ///
    /// The names of the TextTheme properties match this table from the
    /// [Material Design spec](https://material.io/design/typography/the-type-system.html#type-scale)
    /// with two exceptions: the styles called H1-H6 in the spec are
    /// headline1-headline6 in the API, and body1,body2 are called
    /// bodyText1 and bodyText2.
    ///
    /// ![](https://storage.googleapis.com/spec-host-backup/mio-design%2Fassets%2F1W8kyGVruuG_O8psvyiOaCf1lLFIMzB-N%2Ftypesystem-typescale.png)
    ///
    /// ## Migrating from the 2014 names
    ///
    /// The Material Design typography scheme was significantly changed in the
    /// current (2018) version of the specification
    /// (https://material.io/design/typography).
    ///
    /// The 2018 spec has thirteen text styles:
    /// ```
    /// NAME         SIZE  WEIGHT  SPACING
    /// headline1    96.0  light   -1.5
    /// headline2    60.0  light   -0.5
    /// headline3    48.0  regular  0.0
    /// headline4    34.0  regular  0.25
    /// headline5    24.0  regular  0.0
    /// headline6    20.0  medium   0.15
    /// subtitle1    16.0  regular  0.15
    /// subtitle2    14.0  medium   0.1
    /// body1        16.0  regular  0.5   (bodyText1)
    /// body2        14.0  regular  0.25  (bodyText2)
    /// button       14.0  medium   1.25
    /// caption      12.0  regular  0.4
    /// overline     10.0  regular  1.5
    /// ```
    ///
    /// ...where "light" is `FontWeight.w300`, "regular" is `FontWeight.w400` and
    /// "medium" is `FontWeight.w500`.
    ///
    /// The [TextTheme] API was originally based on the original material (2014)
    /// design spec, which used different text style names. For backwards
    /// compatibility's sake, this API continues to expose the old names. The table
    /// below should help with understanding the mapping of the API's old names and
    /// the new names (those in terms of the 2018 material specification).
    ///
    /// Each of the [TextTheme] text styles corresponds to one of the
    /// styles from 2018 spec. By default, the font sizes, font weights
    /// and letter spacings have not changed from their original,
    /// 2014, values.
    ///
    /// ```
    /// NAME       SIZE   WEIGHT   SPACING  2018 NAME
    /// display4   112.0  thin     0.0      headline1
    /// display3   56.0   normal   0.0      headline2
    /// display2   45.0   normal   0.0      headline3
    /// display1   34.0   normal   0.0      headline4
    /// headline   24.0   normal   0.0      headline5
    /// title      20.0   medium   0.0      headline6
    /// subhead    16.0   normal   0.0      subtitle1
    /// body2      14.0   medium   0.0      body1 (bodyText1)
    /// body1      14.0   normal   0.0      body2 (bodyText2)
    /// caption    12.0   normal   0.0      caption
    /// button     14.0   medium   0.0      button
    /// subtitle   14.0   medium   0.0      subtitle2
    /// overline   10.0   normal   0.0      overline
    /// ```
    ///
    /// Where "thin" is `FontWeight.w100`, "normal" is `FontWeight.w400` and
    /// "medium" is `FontWeight.w500`. Letter spacing for all of the original
    /// text styles was 0.0.
    ///
    /// The old names are deprecated in this API.
    ///
    /// Since the names `body1` and `body2` are used in both specifications but with
    /// different meanings, the API uses the terms `bodyText1` and `bodyText2` for
    /// the new API.
    ///
    /// To configure a [Theme] for the new sizes, weights, and letter spacings,
    /// initialize its [ThemeData.typography] value using [Typography.material2018].
    ///
    /// See also:
    ///
    ///  * [Typography], the class that generates [TextTheme]s appropriate for a platform.
    ///  * [Theme], for other aspects of a material design application that can be
    ///    globally adjusted, such as the color scheme.
    ///  * <https://material.io/design/typography/>
    /// </Summary>
    public class TextTheme : IDiagnosticable
    {
        #region constructors
        public TextTheme(FlutterSDK.Painting.Textstyle.TextStyle headline1 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline2 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline3 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline4 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline5 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline6 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle subtitle1 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle subtitle2 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle bodyText1 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle bodyText2 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle caption = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle button = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle overline = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle display4 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle display3 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle display2 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle display1 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle title = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle subhead = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle subtitle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle body2 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle body1 = default(FlutterSDK.Painting.Textstyle.TextStyle))
        : base()
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Headline1 { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Headline2 { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Headline3 { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Headline4 { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Headline5 { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Headline6 { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Subtitle1 { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Subtitle2 { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle BodyText1 { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle BodyText2 { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Caption { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Button { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Overline { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Display4 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Display3 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Display2 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Display1 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Headline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Title { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Subhead { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Subtitle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Body2 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle Body1 { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Creates a copy of this text theme but with the given fields replaced with
    /// the new values.
    ///
    /// Consider using [Typography.black] or [Typography.white], which implement
    /// the typography styles in the material design specification, as a starting
    /// point.
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// /// A Widget that sets the ambient theme's title text color for its
    /// /// descendants, while leaving other ambient theme attributes alone.
    /// class TitleColorThemeCopy extends StatelessWidget {
    ///   TitleColorThemeCopy({Key key, this.child, this.titleColor}) : super(key: key);
    ///
    ///   final Color titleColor;
    ///   final Widget child;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     final ThemeData theme = Theme.of(context);
    ///     return Theme(
    ///       data: theme.copyWith(
    ///         textTheme: theme.textTheme.copyWith(
    ///           headline6: theme.textTheme.headline6.copyWith(
    ///             color: titleColor,
    ///           ),
    ///         ),
    ///       ),
    ///       child: child,
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [merge] is used instead of [copyWith] when you want to merge all
    ///    of the fields of a TextTheme instead of individual fields.
    /// </Summary>
    public virtual FlutterSDK.Material.Texttheme.TextTheme CopyWith(FlutterSDK.Painting.Textstyle.TextStyle headline1 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline2 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline3 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline4 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline5 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline6 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle subtitle1 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle subtitle2 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle bodyText1 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle bodyText2 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle caption = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle button = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle overline = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle display4 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle display3 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle display2 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle display1 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle headline = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle title = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle subhead = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle subtitle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle body2 = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle body1 = default(FlutterSDK.Painting.Textstyle.TextStyle))
    {

        return new TextTheme(headline1: headline1 ?? display4 ?? this.Headline1, headline2: headline2 ?? display3 ?? this.Headline2, headline3: headline3 ?? display2 ?? this.Headline3, headline4: headline4 ?? display1 ?? this.Headline4, headline5: headline5 ?? headline ?? this.Headline5, headline6: headline6 ?? title ?? this.Headline6, subtitle1: subtitle1 ?? subhead ?? this.Subtitle1, subtitle2: subtitle2 ?? subtitle ?? this.Subtitle2, bodyText1: bodyText1 ?? body2 ?? this.BodyText1, bodyText2: bodyText2 ?? body1 ?? this.BodyText2, caption: caption ?? this.Caption, button: button ?? this.Button, overline: overline ?? this.Overline);
    }




    /// <Summary>
    /// Creates a new [TextTheme] where each text style from this object has been
    /// merged with the matching text style from the `other` object.
    ///
    /// The merging is done by calling [TextStyle.merge] on each respective pair
    /// of text styles from this and the [other] text themes and is subject to
    /// the value of [TextStyle.inherit] flag. For more details, see the
    /// documentation on [TextStyle.merge] and [TextStyle.inherit].
    ///
    /// If this theme, or the `other` theme has members that are null, then the
    /// non-null one (if any) is used. If the `other` theme is itself null, then
    /// this [TextTheme] is returned unchanged. If values in both are set, then
    /// the values are merged using [TextStyle.merge].
    ///
    /// This is particularly useful if one [TextTheme] defines one set of
    /// properties and another defines a different set, e.g. having colors
    /// defined in one text theme and font sizes in another, or when one
    /// [TextTheme] has only some fields defined, and you want to define the rest
    /// by merging it with a default theme.
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// /// A Widget that sets the ambient theme's title text color for its
    /// /// descendants, while leaving other ambient theme attributes alone.
    /// class TitleColorTheme extends StatelessWidget {
    ///   TitleColorTheme({Key key, this.child, this.titleColor}) : super(key: key);
    ///
    ///   final Color titleColor;
    ///   final Widget child;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     ThemeData theme = Theme.of(context);
    ///     // This partialTheme is incomplete: it only has the title style
    ///     // defined. Just replacing theme.textTheme with partialTheme would
    ///     // set the title, but everything else would be null. This isn't very
    ///     // useful, so merge it with the existing theme to keep all of the
    ///     // preexisting definitions for the other styles.
    ///     TextTheme partialTheme = TextTheme(headline6: TextStyle(color: titleColor));
    ///     theme = theme.copyWith(textTheme: theme.textTheme.merge(partialTheme));
    ///     return Theme(data: theme, child: child);
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [copyWith] is used instead of [merge] when you wish to override
    ///    individual fields in the [TextTheme] instead of merging all of the
    ///    fields of two [TextTheme]s.
    /// </Summary>
    public virtual FlutterSDK.Material.Texttheme.TextTheme Merge(FlutterSDK.Material.Texttheme.TextTheme other)
    {
        if (other == null) return this;
        return CopyWith(headline1: Headline1?.Merge(other.Headline1) ?? other.Headline1, headline2: Headline2?.Merge(other.Headline2) ?? other.Headline2, headline3: Headline3?.Merge(other.Headline3) ?? other.Headline3, headline4: Headline4?.Merge(other.Headline4) ?? other.Headline4, headline5: Headline5?.Merge(other.Headline5) ?? other.Headline5, headline6: Headline6?.Merge(other.Headline6) ?? other.Headline6, subtitle1: Subtitle1?.Merge(other.Subtitle1) ?? other.Subtitle1, subtitle2: Subtitle2?.Merge(other.Subtitle2) ?? other.Subtitle2, bodyText1: BodyText1?.Merge(other.BodyText1) ?? other.BodyText1, bodyText2: BodyText2?.Merge(other.BodyText2) ?? other.BodyText2, caption: Caption?.Merge(other.Caption) ?? other.Caption, button: Button?.Merge(other.Button) ?? other.Button, overline: Overline?.Merge(other.Overline) ?? other.Overline);
    }




    /// <Summary>
    /// Creates a copy of this text theme but with the given field replaced in
    /// each of the individual text styles.
    ///
    /// The `displayColor` is applied to [headline4], [headline3], [headline2],
    /// [headline1], and [caption]. The `bodyColor` is applied to the remaining
    /// text styles.
    ///
    /// Consider using [Typography.black] or [Typography.white], which implement
    /// the typography styles in the material design specification, as a starting
    /// point.
    /// </Summary>
    public virtual FlutterSDK.Material.Texttheme.TextTheme Apply(string fontFamily = default(string), double fontSizeFactor = 1.0, double fontSizeDelta = 0.0, FlutterBinding.UI.Color displayColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color bodyColor = default(FlutterBinding.UI.Color), TextDecoration decoration = default(TextDecoration), FlutterBinding.UI.Color decorationColor = default(FlutterBinding.UI.Color), TextDecorationStyle decorationStyle = default(TextDecorationStyle))
    {
        return new TextTheme(headline1: Headline1?.Apply(color: displayColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), headline2: Headline2?.Apply(color: displayColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), headline3: Headline3?.Apply(color: displayColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), headline4: Headline4?.Apply(color: displayColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), headline5: Headline5?.Apply(color: bodyColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), headline6: Headline6?.Apply(color: bodyColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), subtitle1: Subtitle1?.Apply(color: bodyColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), subtitle2: Subtitle2?.Apply(color: bodyColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), bodyText1: BodyText1?.Apply(color: bodyColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), bodyText2: BodyText2?.Apply(color: bodyColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), caption: Caption?.Apply(color: displayColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), button: Button?.Apply(color: bodyColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta), overline: Overline?.Apply(color: bodyColor, decoration: decoration, decorationColor: decorationColor, decorationStyle: decorationStyle, fontFamily: fontFamily, fontSizeFactor: fontSizeFactor, fontSizeDelta: fontSizeDelta));
    }




    /// <Summary>
    /// Linearly interpolate between two text themes.
    ///
    /// {@macro flutter.material.themeData.lerp}
    /// </Summary>
    public virtual FlutterSDK.Material.Texttheme.TextTheme Lerp(FlutterSDK.Material.Texttheme.TextTheme a, FlutterSDK.Material.Texttheme.TextTheme b, double t)
    {

        return new TextTheme(headline1: TextstyleDefaultClass.TextStyle.Lerp(a?.Headline1, b?.Headline1, t), headline2: TextstyleDefaultClass.TextStyle.Lerp(a?.Headline2, b?.Headline2, t), headline3: TextstyleDefaultClass.TextStyle.Lerp(a?.Headline3, b?.Headline3, t), headline4: TextstyleDefaultClass.TextStyle.Lerp(a?.Headline4, b?.Headline4, t), headline5: TextstyleDefaultClass.TextStyle.Lerp(a?.Headline5, b?.Headline5, t), headline6: TextstyleDefaultClass.TextStyle.Lerp(a?.Headline6, b?.Headline6, t), subtitle1: TextstyleDefaultClass.TextStyle.Lerp(a?.Subtitle1, b?.Subtitle1, t), subtitle2: TextstyleDefaultClass.TextStyle.Lerp(a?.Subtitle2, b?.Subtitle2, t), bodyText1: TextstyleDefaultClass.TextStyle.Lerp(a?.BodyText1, b?.BodyText1, t), bodyText2: TextstyleDefaultClass.TextStyle.Lerp(a?.BodyText2, b?.BodyText2, t), caption: TextstyleDefaultClass.TextStyle.Lerp(a?.Caption, b?.Caption, t), button: TextstyleDefaultClass.TextStyle.Lerp(a?.Button, b?.Button, t), overline: TextstyleDefaultClass.TextStyle.Lerp(a?.Overline, b?.Overline, t));
    }




    public new bool Equals(@Object other)
    {
        if (Dart:coreDefaultClass.Identical(this, other))return true;
        if (other.GetType() != GetType()) return false;
        return other is TextTheme && Headline1 == other.Headline1 && Headline2 == other.Headline2 && Headline3 == other.Headline3 && Headline4 == other.Headline4 && Headline5 == other.Headline5 && Headline6 == other.Headline6 && Subtitle1 == other.Subtitle1 && Subtitle2 == other.Subtitle2 && BodyText1 == other.BodyText1 && BodyText2 == other.BodyText2 && Caption == other.Caption && Button == other.Button && Overline == other.Overline;
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        TextTheme defaultTheme = Typography.Material2018(platform: PlatformDefaultClass.DefaultTargetPlatform).Black;
        properties.Add(new DiagnosticsProperty<TextStyle>("headline1", Headline1, defaultValue: defaultTheme.Headline1));
        properties.Add(new DiagnosticsProperty<TextStyle>("headline2", Headline2, defaultValue: defaultTheme.Headline2));
        properties.Add(new DiagnosticsProperty<TextStyle>("headline3", Headline3, defaultValue: defaultTheme.Headline3));
        properties.Add(new DiagnosticsProperty<TextStyle>("headline4", Headline4, defaultValue: defaultTheme.Headline4));
        properties.Add(new DiagnosticsProperty<TextStyle>("headline5", Headline5, defaultValue: defaultTheme.Headline5));
        properties.Add(new DiagnosticsProperty<TextStyle>("headline6", Headline6, defaultValue: defaultTheme.Headline6));
        properties.Add(new DiagnosticsProperty<TextStyle>("subtitle1", Subtitle1, defaultValue: defaultTheme.Subtitle1));
        properties.Add(new DiagnosticsProperty<TextStyle>("subtitle2", Subtitle2, defaultValue: defaultTheme.Subtitle2));
        properties.Add(new DiagnosticsProperty<TextStyle>("bodyText1", BodyText1, defaultValue: defaultTheme.BodyText1));
        properties.Add(new DiagnosticsProperty<TextStyle>("bodyText2", BodyText2, defaultValue: defaultTheme.BodyText2));
        properties.Add(new DiagnosticsProperty<TextStyle>("caption", Caption, defaultValue: defaultTheme.Caption));
        properties.Add(new DiagnosticsProperty<TextStyle>("button", Button, defaultValue: defaultTheme.Button));
        properties.Add(new DiagnosticsProperty<TextStyle>("overline", Overline, defaultValue: defaultTheme.Overline));
    }



    #endregion
}

}
