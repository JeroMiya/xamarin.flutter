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
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Routenotificationmessages;
namespace FlutterSDK.Widgets.Pageview
{
    internal static class PageviewDefaultClass
    {
        public static FlutterSDK.Widgets.Pageview.PageController _DefaultPageController = default(FlutterSDK.Widgets.Pageview.PageController);
        public static FlutterSDK.Widgets.Pageview.PageScrollPhysics _KPagePhysics = default(FlutterSDK.Widgets.Pageview.PageScrollPhysics);
    }

    /// <Summary>
    /// Metrics for a [PageView].
    ///
    /// The metrics are available on [ScrollNotification]s generated from
    /// [PageView]s.
    /// </Summary>
    public interface IPageMetrics
    {
        FlutterSDK.Widgets.Pageview.PageMetrics CopyWith(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double viewportFraction = default(double));
        double ViewportFraction { get; }
        double Page { get; }
    }


    /// <Summary>
    /// A controller for [PageView].
    ///
    /// A page controller lets you manipulate which page is visible in a [PageView].
    /// In addition to being able to control the pixel offset of the content inside
    /// the [PageView], a [PageController] also lets you control the offset in terms
    /// of pages, which are increments of the viewport size.
    ///
    /// See also:
    ///
    ///  * [PageView], which is the widget this object controls.
    ///
    /// {@tool snippet}
    ///
    /// This widget introduces a [MaterialApp], [Scaffold] and [PageView] with two pages
    /// using the default constructor. Both pages contain a [RaisedButton] allowing you
    /// to animate the [PageView] using a [PageController].
    ///
    /// ```dart
    /// class MyPageView extends StatefulWidget {
    ///   MyPageView({Key key}) : super(key: key);
    ///
    ///   _MyPageViewState createState() => _MyPageViewState();
    /// }
    ///
    /// class _MyPageViewState extends State<MyPageView> {
    ///   PageController _pageController;
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     _pageController = PageController();
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     _pageController.dispose();
    ///     super.dispose();
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return MaterialApp(
    ///       home: Scaffold(
    ///         body: PageView(
    ///           controller: _pageController,
    ///           children: [
    ///             Container(
    ///               color: Colors.red,
    ///               child: Center(
    ///                 child: RaisedButton(
    ///                   color: Colors.white,
    ///                   onPressed: () {
    ///                     if (_pageController.hasClients) {
    ///                       _pageController.animateToPage(
    ///                         1,
    ///                         duration: const Duration(milliseconds: 400),
    ///                         curve: Curves.easeInOut,
    ///                       );
    ///                     }
    ///                   },
    ///                   child: Text('Next'),
    ///                 ),
    ///               ),
    ///             ),
    ///             Container(
    ///               color: Colors.blue,
    ///               child: Center(
    ///                 child: RaisedButton(
    ///                   color: Colors.white,
    ///                   onPressed: () {
    ///                     if (_pageController.hasClients) {
    ///                       _pageController.animateToPage(
    ///                         0,
    ///                         duration: const Duration(milliseconds: 400),
    ///                         curve: Curves.easeInOut,
    ///                       );
    ///                     }
    ///                   },
    ///                   child: Text('Previous'),
    ///                 ),
    ///               ),
    ///             ),
    ///           ],
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class PageController : FlutterSDK.Widgets.Scrollcontroller.ScrollController
    {
        #region constructors
        public PageController(int initialPage = 0, bool keepPage = true, double viewportFraction = 1.0)
        : base()
        {
            this.InitialPage = initialPage;
            this.KeepPage = keepPage;
            this.ViewportFraction = viewportFraction; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int InitialPage { get; set; }
        public virtual bool KeepPage { get; set; }
        public virtual double ViewportFraction { get; set; }
        public virtual double Page { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Animates the controlled [PageView] from the current page to the given page.
        ///
        /// The animation lasts for the given duration and follows the given curve.
        /// The returned [Future] resolves when the animation completes.
        ///
        /// The `duration` and `curve` arguments must not be null.
        /// </Summary>
        public virtual Future<object> AnimateToPage(int page, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Changes which page is displayed in the controlled [PageView].
        ///
        /// Jumps the page position from its current value to the given value,
        /// without animation, and without checking if the new value is in range.
        /// </Summary>
        public virtual void JumpToPage(int page) { throw new NotImplementedException(); }


        /// <Summary>
        /// Animates the controlled [PageView] to the next page.
        ///
        /// The animation lasts for the given duration and follows the given curve.
        /// The returned [Future] resolves when the animation completes.
        ///
        /// The `duration` and `curve` arguments must not be null.
        /// </Summary>
        public virtual Future<object> NextPage(TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Animates the controlled [PageView] to the previous page.
        ///
        /// The animation lasts for the given duration and follows the given curve.
        /// The returned [Future] resolves when the animation completes.
        ///
        /// The `duration` and `curve` arguments must not be null.
        /// </Summary>
        public virtual Future<object> PreviousPage(TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Scrollposition.ScrollPosition CreateScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics, FlutterSDK.Widgets.Scrollcontext.ScrollContext context, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Widgets.Scrollposition.ScrollPosition position) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Metrics for a [PageView].
    ///
    /// The metrics are available on [ScrollNotification]s generated from
    /// [PageView]s.
    /// </Summary>
    public class PageMetrics : FlutterSDK.Widgets.Scrollmetrics.FixedScrollMetrics
    {
        #region constructors
        public PageMetrics(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double viewportFraction = default(double))
        : base(minScrollExtent: minScrollExtent, maxScrollExtent: maxScrollExtent, pixels: pixels, viewportDimension: viewportDimension, axisDirection: axisDirection)
        {
            this.ViewportFraction = viewportFraction; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double ViewportFraction { get; set; }
        public virtual double Page { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Pageview.PageMetrics CopyWith(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double viewportFraction = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _PagePosition : FlutterSDK.Widgets.Scrollpositionwithsinglecontext.ScrollPositionWithSingleContext, IPageMetrics
    {
        #region constructors
        public _PagePosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontext.ScrollContext context = default(FlutterSDK.Widgets.Scrollcontext.ScrollContext), int initialPage = 0, bool keepPage = true, double viewportFraction = 1.0, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition))
        : base(physics: physics, context: context, initialPixels: null, keepScrollOffset: keepPage, oldPosition: oldPosition)
        {
            this.InitialPage = initialPage; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int InitialPage { get; set; }
        internal virtual double _PageToUseOnStartup { get; set; }
        internal virtual double _ViewportFraction { get; set; }
        public virtual double ViewportFraction { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _InitialPageOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Page { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual double GetPageFromPixels(double pixels, double viewportDimension) { throw new NotImplementedException(); }


        public virtual double GetPixelsFromPage(double page) { throw new NotImplementedException(); }


        public new void SaveScrollOffset() { throw new NotImplementedException(); }


        public new void RestoreScrollOffset() { throw new NotImplementedException(); }


        public new bool ApplyViewportDimension(double viewportDimension) { throw new NotImplementedException(); }


        public new bool ApplyContentDimensions(double minScrollExtent, double maxScrollExtent) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Pageview.PageMetrics CopyWith(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double viewportFraction = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ForceImplicitScrollPhysics : FlutterSDK.Widgets.Scrollphysics.ScrollPhysics
    {
        #region constructors
        public _ForceImplicitScrollPhysics(bool allowImplicitScrolling = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics parent = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
        : base(parent: parent)
        {
            this.AllowImplicitScrolling = allowImplicitScrolling; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public new bool AllowImplicitScrolling { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Pageview._ForceImplicitScrollPhysics ApplyTo(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ancestor) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Scroll physics used by a [PageView].
    ///
    /// These physics cause the page view to snap to page boundaries.
    ///
    /// See also:
    ///
    ///  * [ScrollPhysics], the base class which defines the API for scrolling
    ///    physics.
    ///  * [PageView.physics], which can override the physics used by a page view.
    /// </Summary>
    public class PageScrollPhysics : FlutterSDK.Widgets.Scrollphysics.ScrollPhysics
    {
        #region constructors
        public PageScrollPhysics(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics parent = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
        : base(parent: parent)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool AllowImplicitScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Pageview.PageScrollPhysics ApplyTo(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ancestor) { throw new NotImplementedException(); }


        private double _GetPage(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position) { throw new NotImplementedException(); }


        private double _GetPixels(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double page) { throw new NotImplementedException(); }


        private double _GetTargetPixels(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, FlutterSDK.Physics.Tolerance.Tolerance tolerance, double velocity) { throw new NotImplementedException(); }


        public new FlutterSDK.Physics.Simulation.Simulation CreateBallisticSimulation(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double velocity) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A scrollable list that works page by page.
    ///
    /// Each child of a page view is forced to be the same size as the viewport.
    ///
    /// You can use a [PageController] to control which page is visible in the view.
    /// In addition to being able to control the pixel offset of the content inside
    /// the [PageView], a [PageController] also lets you control the offset in terms
    /// of pages, which are increments of the viewport size.
    ///
    /// The [PageController] can also be used to control the
    /// [PageController.initialPage], which determines which page is shown when the
    /// [PageView] is first constructed, and the [PageController.viewportFraction],
    /// which determines the size of the pages as a fraction of the viewport size.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=J1gE9xvph-A}
    ///
    /// See also:
    ///
    ///  * [PageController], which controls which page is visible in the view.
    ///  * [SingleChildScrollView], when you need to make a single child scrollable.
    ///  * [ListView], for a scrollable list of boxes.
    ///  * [GridView], for a scrollable grid of boxes.
    ///  * [ScrollNotification] and [NotificationListener], which can be used to watch
    ///    the scroll position without using a [ScrollController].
    /// </Summary>
    public class PageView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public PageView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Pageview.PageController controller = default(FlutterSDK.Widgets.Pageview.PageController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool pageSnapping = true, FlutterSDK.Foundation.Basictypes.ValueChanged<int> onPageChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool allowImplicitScrolling = false)
        : base(key: key)
        {
            this.ScrollDirection = scrollDirection;
            this.Reverse = reverse;
            this.Physics = physics;
            this.PageSnapping = pageSnapping;
            this.OnPageChanged = onPageChanged;
            this.DragStartBehavior = dragStartBehavior;
            this.AllowImplicitScrolling = allowImplicitScrolling; throw new NotImplementedException();
        }
        public static PageView Builder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Pageview.PageController controller = default(FlutterSDK.Widgets.Pageview.PageController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool pageSnapping = true, FlutterSDK.Foundation.Basictypes.ValueChanged<int> onPageChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), FlutterSDK.Widgets.Framework.IndexedWidgetBuilder itemBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder), int itemCount = default(int), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool allowImplicitScrolling = false)
        {
            var instance = new PageView(key: key); instance.ScrollDirection = scrollDirection;
            instance.Reverse = reverse;
            instance.Physics = physics;
            instance.PageSnapping = pageSnapping;
            instance.OnPageChanged = onPageChanged;
            instance.DragStartBehavior = dragStartBehavior;
            instance.AllowImplicitScrolling = allowImplicitScrolling; throw new NotImplementedException();
        }
        public static PageView Custom(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Pageview.PageController controller = default(FlutterSDK.Widgets.Pageview.PageController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool pageSnapping = true, FlutterSDK.Foundation.Basictypes.ValueChanged<int> onPageChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), FlutterSDK.Widgets.Sliver.SliverChildDelegate childrenDelegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool allowImplicitScrolling = false)
        {
            var instance = new PageView(key: key); instance.ScrollDirection = scrollDirection;
            instance.Reverse = reverse;
            instance.Physics = physics;
            instance.PageSnapping = pageSnapping;
            instance.OnPageChanged = onPageChanged;
            instance.ChildrenDelegate = childrenDelegate;
            instance.DragStartBehavior = dragStartBehavior;
            instance.AllowImplicitScrolling = allowImplicitScrolling; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool AllowImplicitScrolling { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis ScrollDirection { get; set; }
        public virtual bool Reverse { get; set; }
        public virtual FlutterSDK.Widgets.Pageview.PageController Controller { get; set; }
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
        public virtual bool PageSnapping { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnPageChanged { get; set; }
        public virtual FlutterSDK.Widgets.Sliver.SliverChildDelegate ChildrenDelegate { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Pageview._PageViewState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _PageViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Pageview.PageView>
    {
        #region constructors
        public _PageViewState()
        { }
        #endregion

        #region fields
        internal virtual int _LastReportedPage { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Basictypes.AxisDirection _GetDirection(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description) { throw new NotImplementedException(); }

        #endregion
    }

}
