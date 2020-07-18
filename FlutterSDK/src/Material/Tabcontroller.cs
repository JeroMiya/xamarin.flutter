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
namespace FlutterSDK.Material.Tabcontroller
{
    internal static class TabcontrollerDefaultClass
    {
    }

    /// <Summary>
    /// Coordinates tab selection between a [TabBar] and a [TabBarView].
    ///
    /// The [index] property is the index of the selected tab and the [animation]
    /// represents the current scroll positions of the tab bar and the tab bar view.
    /// The selected tab's index can be changed with [animateTo].
    ///
    /// A stateful widget that builds a [TabBar] or a [TabBarView] can create
    /// a [TabController] and share it directly.
    ///
    /// When the [TabBar] and [TabBarView] don't have a convenient stateful
    /// ancestor, a [TabController] can be shared by providing a
    /// [DefaultTabController] inherited widget.
    ///
    /// {@animation 700 540 https://flutter.github.io/assets-for-api-docs/assets/material/tabs.mp4}
    ///
    /// {@tool snippet}
    ///
    /// This widget introduces a [Scaffold] with an [AppBar] and a [TabBar].
    ///
    /// ```dart
    /// class MyTabbedPage extends StatefulWidget {
    ///   const MyTabbedPage({ Key key }) : super(key: key);
    ///   @override
    ///   _MyTabbedPageState createState() => _MyTabbedPageState();
    /// }
    ///
    /// class _MyTabbedPageState extends State<MyTabbedPage> with SingleTickerProviderStateMixin {
    ///   final List<Tab> myTabs = <Tab>[
    ///     Tab(text: 'LEFT'),
    ///     Tab(text: 'RIGHT'),
    ///   ];
    ///
    ///   TabController _tabController;
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     _tabController = TabController(vsync: this, length: myTabs.length);
    ///   }
    ///
    ///  @override
    ///  void dispose() {
    ///    _tabController.dispose();
    ///    super.dispose();
    ///  }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Scaffold(
    ///       appBar: AppBar(
    ///         bottom: TabBar(
    ///           controller: _tabController,
    ///           tabs: myTabs,
    ///         ),
    ///       ),
    ///       body: TabBarView(
    ///         controller: _tabController,
    ///         children: myTabs.map((Tab tab) {
    ///           final String label = tab.text.toLowerCase();
    ///           return Center(
    ///             child: Text(
    ///               'This is the $label tab',
    ///               style: const TextStyle(fontSize: 36),
    ///             ),
    ///           );
    ///         }).toList(),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class TabController : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
    {
        #region constructors
        public TabController(int initialIndex = 0, int length = default(int), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider))
        : base()
        {
            this.Length = length;
        }
        internal TabController(int index = default(int), int previousIndex = default(int), FlutterSDK.Animation.Animationcontroller.AnimationController animationController = default(FlutterSDK.Animation.Animationcontroller.AnimationController), int length = default(int))
        : base()
        {
            this.Length = length;
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _AnimationController { get; set; }
        public virtual int Length { get; set; }
        internal virtual int _Index { get; set; }
        internal virtual int _PreviousIndex { get; set; }
        internal virtual int _IndexIsChangingCount { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int Index { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int PreviousIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IndexIsChanging { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Creates a new [TabController] with `index`, `previousIndex`, and `length`
        /// if they are non-null.
        ///
        /// This method is used by [DefaultTabController].
        ///
        /// When [DefaultTabController.length] is updated, this method is called to
        /// create a new [TabController] without creating a new [AnimationController].
        /// </Summary>
        private FlutterSDK.Material.Tabcontroller.TabController _CopyWith(int index = default(int), int length = default(int), int previousIndex = default(int))
        {
            return TabController._(index: index ?? _Index, length: length ?? this.Length, animationController: _AnimationController, previousIndex: previousIndex ?? _PreviousIndex);
        }




        private void _ChangeIndex(int value, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {




            if (value == _Index || Length < 2) return;
            _PreviousIndex = Index;
            _Index = value;
            if (duration != null)
            {
                _IndexIsChangingCount += 1;
                NotifyListeners();
                _AnimationController.AnimateTo(_Index.ToDouble(), duration: duration, curve: curve).WhenCompleteOrCancel(() =>
                {
                    _IndexIsChangingCount -= 1;
                    NotifyListeners();
                }
                );
            }
            else
            {
                _IndexIsChangingCount += 1;
                _AnimationController.Value = _Index.ToDouble();
                _IndexIsChangingCount -= 1;
                NotifyListeners();
            }

        }




        /// <Summary>
        /// Immediately sets [index] and [previousIndex] and then plays the
        /// [animation] from its current value to [index].
        ///
        /// While the animation is running [indexIsChanging] is true. When the
        /// animation completes [offset] will be 0.0.
        /// </Summary>
        public virtual void AnimateTo(int value, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {
            _ChangeIndex(value, duration: duration, curve: curve);
        }




        public new void Dispose()
        {
            _AnimationController?.Dispose();
            _AnimationController = null;
            base.Dispose();
        }



        #endregion
    }


    public class _TabControllerScope : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public _TabControllerScope(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Tabcontroller.TabController controller = default(FlutterSDK.Material.Tabcontroller.TabController), bool enabled = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Controller = controller;
            this.Enabled = enabled;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        public virtual bool Enabled { get; set; }
        #endregion

        #region methods

        public new bool UpdateShouldNotify(FlutterSDK.Material.Tabcontroller._TabControllerScope old)
        {
            return Enabled != old.Enabled || Controller != old.Controller;
        }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget)
        {
            return Enabled != old.Enabled || Controller != old.Controller;
        }



        #endregion
    }


    /// <Summary>
    /// The [TabController] for descendant widgets that don't specify one
    /// explicitly.
    ///
    /// [DefaultTabController] is an inherited widget that is used to share a
    /// [TabController] with a [TabBar] or a [TabBarView]. It's used when sharing an
    /// explicitly created [TabController] isn't convenient because the tab bar
    /// widgets are created by a stateless parent widget or by different parent
    /// widgets.
    ///
    /// {@animation 700 540 https://flutter.github.io/assets-for-api-docs/assets/material/tabs.mp4}
    ///
    /// ```dart
    /// class MyDemo extends StatelessWidget {
    ///   final List<Tab> myTabs = <Tab>[
    ///     Tab(text: 'LEFT'),
    ///     Tab(text: 'RIGHT'),
    ///   ];
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return DefaultTabController(
    ///       length: myTabs.length,
    ///       child: Scaffold(
    ///         appBar: AppBar(
    ///           bottom: TabBar(
    ///             tabs: myTabs,
    ///           ),
    ///         ),
    ///         body: TabBarView(
    ///           children: myTabs.map((Tab tab) {
    ///             final String label = tab.text.toLowerCase();
    ///             return Center(
    ///               child: Text(
    ///                 'This is the $label tab',
    ///                 style: const TextStyle(fontSize: 36),
    ///               ),
    ///             );
    ///           }).toList(),
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    /// </Summary>
    public class DefaultTabController : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public DefaultTabController(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int length = default(int), int initialIndex = 0, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Length = length;
            this.InitialIndex = initialIndex;
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual int Length { get; set; }
        public virtual int InitialIndex { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// The closest instance of this class that encloses the given context.
        ///
        /// {@tool snippet}
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// TabController controller = DefaultTabController.of(context);
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Material.Tabcontroller.TabController Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _TabControllerScope scope = context.DependOnInheritedWidgetOfExactType();
            return scope?.Controller;
        }




        public new FlutterSDK.Material.Tabcontroller._DefaultTabControllerState CreateState() => new _DefaultTabControllerState();


        #endregion
    }


    public class _DefaultTabControllerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Tabcontroller.DefaultTabController>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _DefaultTabControllerState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Material.Tabcontroller.TabController _Controller { get; set; }
        #endregion

        #region methods

        public new void InitState()
        {
            base.InitState();
            _Controller = new TabController(vsync: this, length: Widget.Length, initialIndex: Widget.InitialIndex);
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _TabControllerScope(controller: _Controller, enabled: TickerproviderDefaultClass.TickerMode.Of(context), child: Widget.Child);
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Tabcontroller.DefaultTabController oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (oldWidget.Length != Widget.Length)
            {
                int newIndex = default(int);
                int previousIndex = _Controller.PreviousIndex;
                if (_Controller.Index >= Widget.Length)
                {
                    newIndex = Math.Dart:mathDefaultClass.Max(0, Widget.Length - 1);
                    previousIndex = _Controller.Index;
                }

                _Controller = _Controller._CopyWith(length: Widget.Length, index: newIndex, previousIndex: previousIndex);
            }

        }



        #endregion
    }

}
