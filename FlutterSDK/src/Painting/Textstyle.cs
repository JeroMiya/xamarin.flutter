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
namespace FlutterSDK.Painting.Textstyle
{
    internal static class TextstyleDefaultClass
    {
        public static string _KDefaultDebugLabel = default(string);
        public static string _KColorForegroundWarning = default(string);
        public static string _KColorBackgroundWarning = default(string);
    }

    /// <Summary>
    /// An immutable style in which paint text.
    ///
    /// ### Bold
    ///
    /// {@tool snippet}
    /// Here, a single line of text in a [Text] widget is given a specific style
    /// override. The style is mixed with the ambient [DefaultTextStyle] by the
    /// [Text] widget.
    ///
    /// ![Applying the style in this way creates bold text.](https://flutter.github.io/assets-for-api-docs/assets/painting/text_style_bold.png)
    ///
    /// ```dart
    /// Text(
    ///   'No, we need bold strokes. We need this plan.',
    ///   style: TextStyle(fontWeight: FontWeight.bold),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ### Italics
    ///
    /// {@tool snippet}
    /// As in the previous example, the [Text] widget is given a specific style
    /// override which is implicitly mixed with the ambient [DefaultTextStyle].
    ///
    /// ![This results in italicized text.](https://flutter.github.io/assets-for-api-docs/assets/painting/text_style_italics.png)
    ///
    /// ```dart
    /// Text(
    ///   "Welcome to the present, we're running a real nation.",
    ///   style: TextStyle(fontStyle: FontStyle.italic),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ### Opacity and Color
    ///
    /// Each line here is progressively more opaque. The base color is
    /// [material.Colors.black], and [Color.withOpacity] is used to create a
    /// derivative color with the desired opacity. The root [TextSpan] for this
    /// [RichText] widget is explicitly given the ambient [DefaultTextStyle], since
    /// [RichText] does not do that automatically. The inner [TextStyle] objects are
    /// implicitly mixed with the parent [TextSpan]'s [TextSpan.style].
    ///
    /// If [color] is specified, [foreground] must be null and vice versa. [color] is
    /// treated as a shorthand for `Paint()..color = color`.
    ///
    /// If [backgroundColor] is specified, [background] must be null and vice versa.
    /// The [backgroundColor] is treated as a shorthand for
    /// `background: Paint()..color = backgroundColor`.
    ///
    /// ![This results in three lines of text that go from lighter to darker in color.](https://flutter.github.io/assets-for-api-docs/assets/painting/text_style_opacity_and_color.png)
    ///
    /// ```dart
    /// RichText(
    ///   text: TextSpan(
    ///     style: DefaultTextStyle.of(context).style,
    ///     children: <TextSpan>[
    ///       TextSpan(
    ///         text: "You don't have the votes.\n",
    ///         style: TextStyle(color: Colors.black.withOpacity(0.6)),
    ///       ),
    ///       TextSpan(
    ///         text: "You don't have the votes!\n",
    ///         style: TextStyle(color: Colors.black.withOpacity(0.8)),
    ///       ),
    ///       TextSpan(
    ///         text: "You're gonna need congressional approval and you don't have the votes!\n",
    ///         style: TextStyle(color: Colors.black.withOpacity(1.0)),
    ///       ),
    ///     ],
    ///   ),
    /// )
    /// ```
    ///
    /// ### Size
    ///
    /// {@tool snippet}
    /// In this example, the ambient [DefaultTextStyle] is explicitly manipulated to
    /// obtain a [TextStyle] that doubles the default font size.
    ///
    /// ![This results in text that is twice as large as normal.](https://flutter.github.io/assets-for-api-docs/assets/painting/text_style_size.png)
    ///
    /// ```dart
    /// Text(
    ///   "These are wise words, enterprising men quote 'em.",
    ///   style: DefaultTextStyle.of(context).style.apply(fontSizeFactor: 2.0),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ### Line height
    ///
    /// By default, text will layout with line height as defined by the font.
    /// Font-metrics defined line height may be taller or shorter than the font size.
    /// The [height] property allows manual adjustment of the height of the line as
    /// a multiple of [fontSize]. For most fonts, setting [height] to 1.0 is not
    /// the same as omitting or setting height to null. The following diagram
    /// illustrates the difference between the font-metrics defined line height and
    /// the line height produced with `height: 1.0` (also known as the EM-square):
    ///
    /// ![Text height diagram](https://flutter.github.io/assets-for-api-docs/assets/painting/text_height_diagram.png)
    ///
    /// {@tool snippet}
    /// The [height] property can be used to change the line height. Here, the line
    /// height is set to 5 times the font size, so that the text is very spaced out.
    /// Since the `fontSize` is set to 10, the final height of the line is
    /// 50 pixels.
    ///
    /// ```dart
    /// Text(
    ///   'Ladies and gentlemen, you coulda been anywhere in the world tonight, but you’re here with us in New York City.',
    ///   style: TextStyle(height: 5, fontSize: 10),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// Examples of the resulting heights from different values of `TextStyle.height`:
    ///
    /// ![Text height comparison diagram](https://flutter.github.io/assets-for-api-docs/assets/painting/text_height_comparison_diagram.png)
    ///
    /// See [StrutStyle] for further control of line height at the paragraph level.
    ///
    /// ### Wavy red underline with black text
    ///
    /// {@tool snippet}
    /// Styles can be combined. In this example, the misspelled word is drawn in
    /// black text and underlined with a wavy red line to indicate a spelling error.
    /// (The remainder is styled according to the Flutter default text styles, not
    /// the ambient [DefaultTextStyle], since no explicit style is given and
    /// [RichText] does not automatically use the ambient [DefaultTextStyle].)
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/painting/text_style_wavy_red_underline.png)
    ///
    /// ```dart
    /// RichText(
    ///   text: TextSpan(
    ///     text: "Don't tax the South ",
    ///     children: <TextSpan>[
    ///       TextSpan(
    ///         text: 'cuz',
    ///         style: TextStyle(
    ///           color: Colors.black,
    ///           decoration: TextDecoration.underline,
    ///           decorationColor: Colors.red,
    ///           decorationStyle: TextDecorationStyle.wavy,
    ///         ),
    ///       ),
    ///       TextSpan(
    ///         text: ' we got it made in the shade',
    ///       ),
    ///     ],
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ### Borders and stroke (Foreground)
    ///
    /// {@tool snippet}
    /// To create bordered text, a [Paint] with [Paint.style] set to [PaintingStyle.stroke]
    /// should be provided as a [foreground] paint. The following example uses a [Stack]
    /// to produce a stroke and fill effect.
    ///
    /// ![Text border](https://flutter.github.io/assets-for-api-docs/assets/widgets/text_border.png)
    ///
    /// ```dart
    /// Stack(
    ///   children: <Widget>[
    ///     // Stroked text as border.
    ///     Text(
    ///       'Greetings, planet!',
    ///       style: TextStyle(
    ///         fontSize: 40,
    ///         foreground: Paint()
    ///           ..style = PaintingStyle.stroke
    ///           ..strokeWidth = 6
    ///           ..color = Colors.blue[700],
    ///       ),
    ///     ),
    ///     // Solid text as fill.
    ///     Text(
    ///       'Greetings, planet!',
    ///       style: TextStyle(
    ///         fontSize: 40,
    ///         color: Colors.grey[300],
    ///       ),
    ///     ),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ### Gradients (Foreground)
    ///
    /// {@tool snippet}
    /// The [foreground] property also allows effects such as gradients to be
    /// applied to the text. Here we provide a [Paint] with a [ui.Gradient]
    /// shader.
    ///
    /// ![Text gradient](https://flutter.github.io/assets-for-api-docs/assets/widgets/text_gradient.png)
    ///
    /// ```dart
    /// Text(
    ///   'Greetings, planet!',
    ///   style: TextStyle(
    ///     fontSize: 40,
    ///     foreground: Paint()
    ///       ..shader = ui.Gradient.linear(
    ///         const Offset(0, 20),
    ///         const Offset(150, 20),
    ///         <Color>[
    ///           Colors.red,
    ///           Colors.yellow,
    ///         ],
    ///       )
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ### Custom Fonts
    ///
    /// Custom fonts can be declared in the `pubspec.yaml` file as shown below:
    ///
    /// ```yaml
    /// flutter:
    ///   fonts:
    ///     - family: Raleway
    ///       fonts:
    ///         - asset: fonts/Raleway-Regular.ttf
    ///         - asset: fonts/Raleway-Medium.ttf
    ///           weight: 500
    ///         - asset: assets/fonts/Raleway-SemiBold.ttf
    ///           weight: 600
    ///      - family: Schyler
    ///        fonts:
    ///          - asset: fonts/Schyler-Regular.ttf
    ///          - asset: fonts/Schyler-Italic.ttf
    ///            style: italic
    /// ```
    ///
    /// The `family` property determines the name of the font, which you can use in
    /// the [fontFamily] argument. The `asset` property is a path to the font file,
    /// relative to the `pubspec.yaml` file. The `weight` property specifies the
    /// weight of the glyph outlines in the file as an integer multiple of 100
    /// between 100 and 900. This corresponds to the [FontWeight] class and can be
    /// used in the [fontWeight] argument. The `style` property specifies whether the
    /// outlines in the file are `italic` or `normal`. These values correspond to
    /// the [FontStyle] class and can be used in the [fontStyle] argument.
    ///
    /// To select a custom font, create [TextStyle] using the [fontFamily]
    /// argument as shown in the example below:
    ///
    /// {@tool snippet}
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/painting/text_style_custom_fonts.png)
    ///
    /// ```dart
    /// const TextStyle(fontFamily: 'Raleway')
    /// ```
    /// {@end-tool}
    ///
    /// To use a font family defined in a package, the [package] argument must be
    /// provided. For instance, suppose the font declaration above is in the
    /// `pubspec.yaml` of a package named `my_package` which the app depends on.
    /// Then creating the TextStyle is done as follows:
    ///
    /// ```dart
    /// const TextStyle(fontFamily: 'Raleway', package: 'my_package')
    /// ```
    ///
    /// If the package internally uses the font it defines, it should still specify
    /// the `package` argument when creating the text style as in the example above.
    ///
    /// A package can also provide font files without declaring a font in its
    /// `pubspec.yaml`. These files should then be in the `lib/` folder of the
    /// package. The font files will not automatically be bundled in the app, instead
    /// the app can use these selectively when declaring a font. Suppose a package
    /// named `my_package` has:
    ///
    /// ```
    /// lib/fonts/Raleway-Medium.ttf
    /// ```
    ///
    /// Then the app can declare a font like in the example below:
    ///
    /// ```yaml
    /// flutter:
    ///   fonts:
    ///     - family: Raleway
    ///       fonts:
    ///         - asset: assets/fonts/Raleway-Regular.ttf
    ///         - asset: packages/my_package/fonts/Raleway-Medium.ttf
    ///           weight: 500
    /// ```
    ///
    /// The `lib/` is implied, so it should not be included in the asset path.
    ///
    /// In this case, since the app locally defines the font, the TextStyle is
    /// created without the `package` argument:
    ///
    /// {@tool snippet}
    /// ```dart
    /// const TextStyle(fontFamily: 'Raleway')
    /// ```
    /// {@end-tool}
    ///
    /// ### Custom Font Fallback
    ///
    /// A custom [fontFamilyFallback] list can be provided. The list should be an
    /// ordered list of strings of font family names in the order they will be attempted.
    ///
    /// The fonts in [fontFamilyFallback] will be used only if the requested glyph is
    /// not present in the [fontFamily].
    ///
    /// The fallback order is:
    ///
    ///  * [fontFamily]
    ///  * [fontFamilyFallback] in order of first to last.
    ///  * System fallback fonts which will vary depending on platform.
    ///
    /// The glyph used will always be the first matching version in fallback order.
    ///
    /// The [fontFamilyFallback] property is commonly used to specify different font
    /// families for multilingual text spans as well as separate fonts for glyphs such
    /// as emojis.
    ///
    /// {@tool snippet}
    /// In the following example, any glyphs not present in the font `Raleway` will be attempted
    /// to be resolved with `Noto Sans CJK SC`, and then with `Noto Color Emoji`:
    ///
    /// ```dart
    /// const TextStyle(
    ///   fontFamily: 'Raleway',
    ///   fontFamilyFallback: <String>[
    ///     'Noto Sans CJK SC',
    ///     'Noto Color Emoji',
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// If all custom fallback font families are exhausted and no match was found
    /// or no custom fallback was provided, the platform font fallback will be used.
    ///
    /// ### Inconsistent platform fonts
    ///
    /// Since Flutter's font discovery for default fonts depends on the fonts present
    /// on the device, it is not safe to assume all default fonts will be available or
    /// consistent across devices.
    ///
    /// A known example of this is that Samsung devices ship with a CJK font that has
    /// smaller line spacing than the Android default. This results in Samsung devices
    /// displaying more tightly spaced text than on other Android devices when no
    /// custom font is specified.
    ///
    /// To avoid this, a custom font should be specified if absolute font consistency
    /// is required for your application.
    ///
    /// See also:
    ///
    ///  * [Text], the widget for showing text in a single style.
    ///  * [DefaultTextStyle], the widget that specifies the default text styles for
    ///    [Text] widgets, configured using a [TextStyle].
    ///  * [RichText], the widget for showing a paragraph of mix-style text.
    ///  * [TextSpan], the class that wraps a [TextStyle] for the purposes of
    ///    passing it to a [RichText].
    ///  * [TextStyle](https://api.flutter.dev/flutter/dart-ui/TextStyle-class.html), the class in the [dart:ui] library.
    ///
    /// </Summary>
    public class TextStyle : IDiagnosticable
    {
        public TextStyle(bool inherit = true, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double fontSize = default(double), FontWeight fontWeight = default(FontWeight), FontStyle fontStyle = default(FontStyle), double letterSpacing = default(double), double wordSpacing = default(double), TextBaseline textBaseline = default(TextBaseline), double height = default(double), Locale locale = default(Locale), SKPaint foreground = default(SKPaint), SKPaint background = default(SKPaint), List<Shadow> shadows = default(List<Shadow>), List<FontFeature> fontFeatures = default(List<FontFeature>), TextDecoration decoration = default(TextDecoration), FlutterBinding.UI.Color decorationColor = default(FlutterBinding.UI.Color), TextDecorationStyle decorationStyle = default(TextDecorationStyle), double decorationThickness = default(double), string debugLabel = default(string), string fontFamily = default(string), List<string> fontFamilyFallback = default(List<string>), string package = default(string))
        : base()
        {
            this.Inherit = inherit;
            this.Color = color;
            this.BackgroundColor = backgroundColor;
            this.FontSize = fontSize;
            this.FontWeight = fontWeight;
            this.FontStyle = fontStyle;
            this.LetterSpacing = letterSpacing;
            this.WordSpacing = wordSpacing;
            this.TextBaseline = textBaseline;
            this.Height = height;
            this.Locale = locale;
            this.Foreground = foreground;
            this.Background = background;
            this.Shadows = shadows;
            this.FontFeatures = fontFeatures;
            this.Decoration = decoration;
            this.DecorationColor = decorationColor;
            this.DecorationStyle = decorationStyle;
            this.DecorationThickness = decorationThickness;
            this.DebugLabel = debugLabel;
        }
        public virtual bool Inherit { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual string FontFamily { get; set; }
        internal virtual List<string> _FontFamilyFallback { get; set; }
        internal virtual string _Package { get; set; }
        public virtual double FontSize { get; set; }
        internal virtual double _DefaultFontSize { get; set; }
        public virtual FontWeight FontWeight { get; set; }
        public virtual FontStyle FontStyle { get; set; }
        public virtual double LetterSpacing { get; set; }
        public virtual double WordSpacing { get; set; }
        public virtual TextBaseline TextBaseline { get; set; }
        public virtual double Height { get; set; }
        public virtual Locale Locale { get; set; }
        public virtual SKPaint Foreground { get; set; }
        public virtual SKPaint Background { get; set; }
        public virtual TextDecoration Decoration { get; set; }
        public virtual FlutterBinding.UI.Color DecorationColor { get; set; }
        public virtual TextDecorationStyle DecorationStyle { get; set; }
        public virtual double DecorationThickness { get; set; }
        public virtual string DebugLabel { get; set; }
        public virtual List<Shadow> Shadows { get; set; }
        public virtual List<FontFeature> FontFeatures { get; set; }
        public virtual List<string> FontFamilyFallback { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a copy of this text style but with the given fields replaced with
        /// the new values.
        ///
        /// One of [color] or [foreground] must be null, and if this has [foreground]
        /// specified it will be given preference over any color parameter.
        ///
        /// One of [backgroundColor] or [background] must be null, and if this has
        /// [background] specified it will be given preference over any
        /// backgroundColor parameter.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle CopyWith(bool inherit = default(bool), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), string fontFamily = default(string), List<string> fontFamilyFallback = default(List<string>), double fontSize = default(double), FontWeight fontWeight = default(FontWeight), FontStyle fontStyle = default(FontStyle), double letterSpacing = default(double), double wordSpacing = default(double), TextBaseline textBaseline = default(TextBaseline), double height = default(double), Locale locale = default(Locale), SKPaint foreground = default(SKPaint), SKPaint background = default(SKPaint), List<Shadow> shadows = default(List<Shadow>), List<FontFeature> fontFeatures = default(List<FontFeature>), TextDecoration decoration = default(TextDecoration), FlutterBinding.UI.Color decorationColor = default(FlutterBinding.UI.Color), TextDecorationStyle decorationStyle = default(TextDecorationStyle), double decorationThickness = default(double), string debugLabel = default(string))
        {


            string newDebugLabel = default(string);

            return new TextStyle(inherit: inherit ?? this.Inherit, color: this.Foreground == null && foreground == null ? color ?? this.Color : null, backgroundColor: this.Background == null && background == null ? backgroundColor ?? this.BackgroundColor : null, fontFamily: fontFamily ?? this.FontFamily, fontFamilyFallback: fontFamilyFallback ?? this.FontFamilyFallback, fontSize: fontSize == default(double) ? this.fontSize : fontSize, fontWeight: fontWeight ?? this.FontWeight, fontStyle: fontStyle ?? this.FontStyle, letterSpacing: letterSpacing == default(double) ? this.letterSpacing : letterSpacing, wordSpacing: wordSpacing == default(double) ? this.wordSpacing : wordSpacing, textBaseline: textBaseline ?? this.TextBaseline, height: height == default(double) ? this.height : height, locale: locale ?? this.Locale, foreground: foreground ?? this.Foreground, background: background ?? this.Background, shadows: shadows ?? this.Shadows, fontFeatures: fontFeatures ?? this.FontFeatures, decoration: decoration ?? this.Decoration, decorationColor: decorationColor ?? this.DecorationColor, decorationStyle: decorationStyle ?? this.DecorationStyle, decorationThickness: decorationThickness == default(double) ? this.decorationThickness : decorationThickness, debugLabel: newDebugLabel);
        }




        /// <Summary>
        /// Creates a copy of this text style replacing or altering the specified
        /// properties.
        ///
        /// The non-numeric properties [color], [fontFamily], [decoration],
        /// [decorationColor] and [decorationStyle] are replaced with the new values.
        ///
        /// [foreground] will be given preference over [color] if it is not null and
        /// [background] will be given preference over [backgroundColor] if it is not
        /// null.
        ///
        /// The numeric properties are multiplied by the given factors and then
        /// incremented by the given deltas.
        ///
        /// For example, `style.apply(fontSizeFactor: 2.0, fontSizeDelta: 1.0)` would
        /// return a [TextStyle] whose [fontSize] is `style.fontSize * 2.0 + 1.0`.
        ///
        /// For the [fontWeight], the delta is applied to the [FontWeight] enum index
        /// values, so that for instance `style.apply(fontWeightDelta: -2)` when
        /// applied to a `style` whose [fontWeight] is [FontWeight.w500] will return a
        /// [TextStyle] with a [FontWeight.w300].
        ///
        /// The numeric arguments must not be null.
        ///
        /// If the underlying values are null, then the corresponding factors and/or
        /// deltas must not be specified.
        ///
        /// If [foreground] is specified on this object, then applying [color] here
        /// will have no effect and if [background] is specified on this object, then
        /// applying [backgroundColor] here will have no effect either.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Apply(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), TextDecoration decoration = default(TextDecoration), FlutterBinding.UI.Color decorationColor = default(FlutterBinding.UI.Color), TextDecorationStyle decorationStyle = default(TextDecorationStyle), double decorationThicknessFactor = 1.0, double decorationThicknessDelta = 0.0, string fontFamily = default(string), List<string> fontFamilyFallback = default(List<string>), double fontSizeFactor = 1.0, double fontSizeDelta = 0.0, int fontWeightDelta = 0, double letterSpacingFactor = 1.0, double letterSpacingDelta = 0.0, double wordSpacingFactor = 1.0, double wordSpacingDelta = 0.0, double heightFactor = 1.0, double heightDelta = 0.0)
        {

















            string modifiedDebugLabel = default(string);

            return new TextStyle(inherit: Inherit, color: Foreground == null ? color ?? this.Color : null, backgroundColor: Background == null ? backgroundColor ?? this.BackgroundColor : null, fontFamily: fontFamily ?? this.FontFamily, fontFamilyFallback: fontFamilyFallback ?? this.FontFamilyFallback, fontSize: FontSize == null ? null : FontSize * fontSizeFactor + fontSizeDelta, fontWeight: FontWeight == null ? null : Dart.UiDefaultClass.FontWeight.Values[(FontWeight.Index + fontWeightDelta).Clamp(0, Dart.UI.UiDefaultClass.FontWeight.Values.Count - 1) as int], fontStyle: FontStyle, letterSpacing: LetterSpacing == null ? null : LetterSpacing * letterSpacingFactor + letterSpacingDelta, wordSpacing: WordSpacing == null ? null : WordSpacing * wordSpacingFactor + wordSpacingDelta, textBaseline: TextBaseline, height: Height == null ? null : Height * heightFactor + heightDelta, locale: Locale, foreground: Foreground, background: Background, shadows: Shadows, fontFeatures: FontFeatures, decoration: decoration ?? this.Decoration, decorationColor: decorationColor ?? this.DecorationColor, decorationStyle: decorationStyle ?? this.DecorationStyle, decorationThickness: DecorationThickness == null ? null : DecorationThickness * decorationThicknessFactor + decorationThicknessDelta, debugLabel: modifiedDebugLabel);
        }




        /// <Summary>
        /// Returns a new text style that is a combination of this style and the given
        /// [other] style.
        ///
        /// If the given [other] text style has its [TextStyle.inherit] set to true,
        /// its null properties are replaced with the non-null properties of this text
        /// style. The [other] style _inherits_ the properties of this style. Another
        /// way to think of it is that the "missing" properties of the [other] style
        /// are _filled_ by the properties of this style.
        ///
        /// If the given [other] text style has its [TextStyle.inherit] set to false,
        /// returns the given [other] style unchanged. The [other] style does not
        /// inherit properties of this style.
        ///
        /// If the given text style is null, returns this text style.
        ///
        /// One of [color] or [foreground] must be null, and if this or `other` has
        /// [foreground] specified it will be given preference over any color parameter.
        ///
        /// Similarly, One of [backgroundColor] or [background] must be null, and if
        /// this or `other` has [background] specified it will be given preference
        /// over any backgroundColor parameter.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Merge(FlutterSDK.Painting.Textstyle.TextStyle other)
        {
            if (other == null) return this;
            if (!other.Inherit) return other;
            string mergedDebugLabel = default(string);

            return CopyWith(color: other.Color, backgroundColor: other.BackgroundColor, fontFamily: other.FontFamily, fontFamilyFallback: other.FontFamilyFallback, fontSize: other.FontSize, fontWeight: other.FontWeight, fontStyle: other.FontStyle, letterSpacing: other.LetterSpacing, wordSpacing: other.WordSpacing, textBaseline: other.TextBaseline, height: other.Height, locale: other.Locale, foreground: other.Foreground, background: other.Background, shadows: other.Shadows, fontFeatures: other.FontFeatures, decoration: other.Decoration, decorationColor: other.DecorationColor, decorationStyle: other.DecorationStyle, decorationThickness: other.DecorationThickness, debugLabel: mergedDebugLabel);
        }




        /// <Summary>
        /// Interpolate between two text styles.
        ///
        /// This will not work well if the styles don't set the same fields.
        ///
        /// {@macro dart.ui.shadow.lerp}
        ///
        /// If [foreground] is specified on either of `a` or `b`, both will be treated
        /// as if they have a [foreground] paint (creating a new [Paint] if necessary
        /// based on the [color] property).
        ///
        /// If [background] is specified on either of `a` or `b`, both will be treated
        /// as if they have a [background] paint (creating a new [Paint] if necessary
        /// based on the [backgroundColor] property).
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Lerp(FlutterSDK.Painting.Textstyle.TextStyle a, FlutterSDK.Painting.Textstyle.TextStyle b, double t)
        {


            if (a == null && b == null)
            {
                return null;
            }

            string lerpDebugLabel = default(string);

            if (a == null)
            {
                return new TextStyle(inherit: b.Inherit, color: Dart.UI.UiDefaultClass.Color.Lerp(null, b.Color, t), backgroundColor: Dart.UI.UiDefaultClass.Color.Lerp(null, b.BackgroundColor, t), fontFamily: t < 0.5 ? null : b.FontFamily, fontFamilyFallback: t < 0.5 ? null : b.FontFamilyFallback, fontSize: t < 0.5 ? null : b.FontSize, fontWeight: Dart.UI.UiDefaultClass.FontWeight.Lerp(null, b.FontWeight, t), fontStyle: t < 0.5 ? null : b.FontStyle, letterSpacing: t < 0.5 ? null : b.LetterSpacing, wordSpacing: t < 0.5 ? null : b.WordSpacing, textBaseline: t < 0.5 ? null : b.TextBaseline, height: t < 0.5 ? null : b.Height, locale: t < 0.5 ? null : b.Locale, foreground: t < 0.5 ? null : b.Foreground, background: t < 0.5 ? null : b.Background, decoration: t < 0.5 ? null : b.Decoration, shadows: t < 0.5 ? null : b.Shadows, fontFeatures: t < 0.5 ? null : b.FontFeatures, decorationColor: Dart.UI.UiDefaultClass.Color.Lerp(null, b.DecorationColor, t), decorationStyle: t < 0.5 ? null : b.DecorationStyle, decorationThickness: t < 0.5 ? null : b.DecorationThickness, debugLabel: lerpDebugLabel);
            }

            if (b == null)
            {
                return new TextStyle(inherit: a.Inherit, color: Dart.UI.UiDefaultClass.Color.Lerp(a.Color, null, t), backgroundColor: Dart.UI.UiDefaultClass.Color.Lerp(null, a.BackgroundColor, t), fontFamily: t < 0.5 ? a.FontFamily : null, fontFamilyFallback: t < 0.5 ? a.FontFamilyFallback : null, fontSize: t < 0.5 ? a.FontSize : null, fontWeight: Dart.UI.UiDefaultClass.FontWeight.Lerp(a.FontWeight, null, t), fontStyle: t < 0.5 ? a.FontStyle : null, letterSpacing: t < 0.5 ? a.LetterSpacing : null, wordSpacing: t < 0.5 ? a.WordSpacing : null, textBaseline: t < 0.5 ? a.TextBaseline : null, height: t < 0.5 ? a.Height : null, locale: t < 0.5 ? a.Locale : null, foreground: t < 0.5 ? a.Foreground : null, background: t < 0.5 ? a.Background : null, shadows: t < 0.5 ? a.Shadows : null, fontFeatures: t < 0.5 ? a.FontFeatures : null, decoration: t < 0.5 ? a.Decoration : null, decorationColor: Dart.UI.UiDefaultClass.Color.Lerp(a.DecorationColor, null, t), decorationStyle: t < 0.5 ? a.DecorationStyle : null, decorationThickness: t < 0.5 ? a.DecorationThickness : null, debugLabel: lerpDebugLabel);
            }

            return new TextStyle(inherit: b.Inherit, color: a.Foreground == null && b.Foreground == null ? Dart.UI.UiDefaultClass.Color.Lerp(a.Color, b.Color, t) : null, backgroundColor: a.Background == null && b.Background == null ? Dart.UI.UiDefaultClass.Color.Lerp(a.BackgroundColor, b.BackgroundColor, t) : null, fontFamily: t < 0.5 ? a.FontFamily : b.FontFamily, fontFamilyFallback: t < 0.5 ? a.FontFamilyFallback : b.FontFamilyFallback, fontSize: Dart.UI.UiDefaultClass.LerpDouble(a.FontSize ?? b.FontSize, b.FontSize ?? a.FontSize, t), fontWeight: Dart.UI.UiDefaultClass.FontWeight.Lerp(a.FontWeight, b.FontWeight, t), fontStyle: t < 0.5 ? a.FontStyle : b.FontStyle, letterSpacing: Dart.UI.UiDefaultClass.LerpDouble(a.LetterSpacing ?? b.LetterSpacing, b.LetterSpacing ?? a.LetterSpacing, t), wordSpacing: Dart.UI.UiDefaultClass.LerpDouble(a.WordSpacing ?? b.WordSpacing, b.WordSpacing ?? a.WordSpacing, t), textBaseline: t < 0.5 ? a.TextBaseline : b.TextBaseline, height: Dart.UI.UiDefaultClass.LerpDouble(a.Height ?? b.Height, b.Height ?? a.Height, t), locale: t < 0.5 ? a.Locale : b.Locale, foreground: (a.Foreground != null || b.Foreground != null) ? t < 0.5 ? a.Foreground ?? (new Paint()..Color = a.Color) : b.Foreground ?? (new Paint()..Color = b.Color) : null, background: (a.Background != null || b.Background != null) ? t < 0.5 ? a.Background ?? (new Paint()..Color = a.BackgroundColor) : b.Background ?? (new Paint()..Color = b.BackgroundColor) : null, shadows: t < 0.5 ? a.Shadows : b.Shadows, fontFeatures: t < 0.5 ? a.FontFeatures : b.FontFeatures, decoration: t < 0.5 ? a.Decoration : b.Decoration, decorationColor: Dart.UI.UiDefaultClass.Color.Lerp(a.DecorationColor, b.DecorationColor, t), decorationStyle: t < 0.5 ? a.DecorationStyle : b.DecorationStyle, decorationThickness: Dart.UI.UiDefaultClass.LerpDouble(a.DecorationThickness ?? b.DecorationThickness, b.DecorationThickness ?? a.DecorationThickness, t), debugLabel: lerpDebugLabel);
        }




        /// <Summary>
        /// The style information for text runs, encoded for use by `dart:ui`.
        /// </Summary>
        public virtual TextStyle GetTextStyle(double textScaleFactor = 1.0)
        {
            return new Ui.TextStyle(color: Color, decoration: Decoration, decorationColor: DecorationColor, decorationStyle: DecorationStyle, decorationThickness: DecorationThickness, fontWeight: FontWeight, fontStyle: FontStyle, textBaseline: TextBaseline, fontFamily: FontFamily, fontFamilyFallback: FontFamilyFallback, fontSize: FontSize == null ? null : FontSize * textScaleFactor, letterSpacing: LetterSpacing, wordSpacing: WordSpacing, height: Height, locale: Locale, foreground: Foreground, background: Background ?? (BackgroundColor != null ? (new Paint()..Color = BackgroundColor) : null), shadows: Shadows, fontFeatures: FontFeatures);
        }




        /// <Summary>
        /// The style information for paragraphs, encoded for use by `dart:ui`.
        ///
        /// The `textScaleFactor` argument must not be null. If omitted, it defaults
        /// to 1.0. The other arguments may be null. The `maxLines` argument, if
        /// specified and non-null, must be greater than zero.
        ///
        /// If the font size on this style isn't set, it will default to 14 logical
        /// pixels.
        /// </Summary>
        public virtual ParagraphStyle GetParagraphStyle(TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), double textScaleFactor = 1.0, string ellipsis = default(string), int maxLines = default(int), TextHeightBehavior textHeightBehavior = default(TextHeightBehavior), Locale locale = default(Locale), string fontFamily = default(string), double fontSize = default(double), FontWeight fontWeight = default(FontWeight), FontStyle fontStyle = default(FontStyle), double height = default(double), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle))
        {


            return new Ui.ParagraphStyle(textAlign: textAlign, textDirection: textDirection, fontWeight: fontWeight ?? this.FontWeight, fontStyle: fontStyle ?? this.FontStyle, fontFamily: fontFamily ?? this.FontFamily, fontSize: (fontSize == default(double) ? this.fontSize : fontSize ?? _DefaultFontSize) * textScaleFactor, height: height == default(double) ? this.height : height, textHeightBehavior: textHeightBehavior, strutStyle: strutStyle == null ? null : new Ui.StrutStyle(fontFamily: strutStyle.FontFamily, fontFamilyFallback: strutStyle.FontFamilyFallback, fontSize: strutStyle.FontSize == null ? null : strutStyle.FontSize * textScaleFactor, height: strutStyle.Height, leading: strutStyle.Leading, fontWeight: strutStyle.FontWeight, fontStyle: strutStyle.FontStyle, forceStrutHeight: strutStyle.ForceStrutHeight), maxLines: maxLines, ellipsis: ellipsis, locale: locale);
        }




        /// <Summary>
        /// Describe the difference between this style and another, in terms of how
        /// much damage it will make to the rendering.
        ///
        /// See also:
        ///
        ///  * [TextSpan.compareTo], which does the same thing for entire [TextSpan]s.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.RenderComparison CompareTo(FlutterSDK.Painting.Textstyle.TextStyle other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return RenderComparison.Identical;
            if (Inherit != other.Inherit || FontFamily != other.FontFamily || FontSize != other.FontSize || FontWeight != other.FontWeight || FontStyle != other.FontStyle || LetterSpacing != other.LetterSpacing || WordSpacing != other.WordSpacing || TextBaseline != other.TextBaseline || Height != other.Height || Locale != other.Locale || Foreground != other.Foreground || Background != other.Background || !CollectionsDefaultClass.ListEquals(Shadows, other.Shadows) || !CollectionsDefaultClass.ListEquals(FontFeatures, other.FontFeatures) || !CollectionsDefaultClass.ListEquals(FontFamilyFallback, other.FontFamilyFallback)) return RenderComparison.Layout;
            if (Color != other.Color || BackgroundColor != other.BackgroundColor || Decoration != other.Decoration || DecorationColor != other.DecorationColor || DecorationStyle != other.DecorationStyle || DecorationThickness != other.DecorationThickness) return RenderComparison.Paint;
            return RenderComparison.Identical;
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is TextStyle && other.Inherit == Inherit && other.Color == Color && other.BackgroundColor == BackgroundColor && other.FontFamily == FontFamily && other.FontSize == FontSize && other.FontWeight == FontWeight && other.FontStyle == FontStyle && other.LetterSpacing == LetterSpacing && other.WordSpacing == WordSpacing && other.TextBaseline == TextBaseline && other.Height == Height && other.Locale == Locale && other.Foreground == Foreground && other.Background == Background && other.Decoration == Decoration && other.DecorationColor == DecorationColor && other.DecorationStyle == DecorationStyle && other.DecorationThickness == DecorationThickness && CollectionsDefaultClass.ListEquals(other.Shadows, Shadows) && CollectionsDefaultClass.ListEquals(other.FontFeatures, FontFeatures) && CollectionsDefaultClass.ListEquals(other.FontFamilyFallback, FontFamilyFallback);
        }




        public new string ToStringShort() => ObjectDefaultClass.ObjectRuntimeType(this, "TextStyle");



        /// <Summary>
        /// Adds all properties prefixing property names with the optional `prefix`.
        /// </Summary>
        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties, string prefix = default(string))
        {
            base.DebugFillProperties(properties);
            if (DebugLabel != null) properties.Add(new MessageProperty($"'{prefix}debugLabel'", DebugLabel));
            List<DiagnosticsNode> styles = new List<DiagnosticsNode>() { new ColorProperty($"'{prefix}color'", Color, defaultValue: null), new ColorProperty($"'{prefix}backgroundColor'", BackgroundColor, defaultValue: null), new StringProperty($"'{prefix}family'", FontFamily, defaultValue: null, quoted: false), new IterableProperty<string>($"'{prefix}familyFallback'", FontFamilyFallback, defaultValue: null), new DoubleProperty($"'{prefix}size'", FontSize, defaultValue: null) };
            string weightDescription = default(string);
            if (FontWeight != null)
            {
                weightDescription = $"'{FontWeight.Index + 1}00'";
            }

            styles.Add(new DiagnosticsProperty<FontWeight>($"'{prefix}weight'", FontWeight, description: weightDescription, defaultValue: null));
            styles.Add(new EnumProperty<FontStyle>($"'{prefix}style'", FontStyle, defaultValue: null));
            styles.Add(new DoubleProperty($"'{prefix}letterSpacing'", LetterSpacing, defaultValue: null));
            styles.Add(new DoubleProperty($"'{prefix}wordSpacing'", WordSpacing, defaultValue: null));
            styles.Add(new EnumProperty<TextBaseline>($"'{prefix}baseline'", TextBaseline, defaultValue: null));
            styles.Add(new DoubleProperty($"'{prefix}height'", Height, unit: 'x', defaultValue: null));
            styles.Add(new DiagnosticsProperty<Locale>($"'{prefix}locale'", Locale, defaultValue: null));
            styles.Add(new DiagnosticsProperty<Paint>($"'{prefix}foreground'", Foreground, defaultValue: null));
            styles.Add(new DiagnosticsProperty<Paint>($"'{prefix}background'", Background, defaultValue: null));
            if (Decoration != null || DecorationColor != null || DecorationStyle != null || DecorationThickness != null)
            {
                List<string> decorationDescription = new List<string>() { };
                if (DecorationStyle != null) decorationDescription.Add(DiagnosticsDefaultClass.DescribeEnum(DecorationStyle));
                styles.Add(new ColorProperty($"'{prefix}decorationColor'", DecorationColor, defaultValue: null, level: DiagnosticLevel.Fine));
                if (DecorationColor != null) decorationDescription.Add($"'{DecorationColor}'");
                styles.Add(new DiagnosticsProperty<TextDecoration>($"'{prefix}decoration'", Decoration, defaultValue: null, level: DiagnosticLevel.Hidden));
                if (Decoration != null) decorationDescription.Add($"'{Decoration}'");

                styles.Add(new MessageProperty($"'{prefix}decoration'", decorationDescription.Join(' ')));
                styles.Add(new DoubleProperty($"'{prefix}decorationThickness'", DecorationThickness, unit: 'x', defaultValue: null));
            }

            bool styleSpecified = styles.Any((DiagnosticsNode n) => =>!n.IsFiltered(DiagnosticLevel.Info));
            properties.Add(new DiagnosticsProperty<bool>($"'{prefix}inherit'", Inherit, level: (!styleSpecified && Inherit) ? DiagnosticLevel.Fine : DiagnosticLevel.Info));
            styles.ForEach(properties.Add);
            if (!styleSpecified) properties.Add(new FlagProperty("inherit", value: Inherit, ifTrue: $"'{prefix}<all styles inherited>'", ifFalse: $"'{prefix}<no style specified>'"));
        }



    }

}
