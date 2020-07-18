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
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Routenotificationmessages;
namespace FlutterSDK.Widgets.Nestedscrollview
{
    public delegate List<FlutterSDK.Widgets.Framework.Widget> NestedScrollViewHeaderSliversBuilder(FlutterSDK.Widgets.Framework.BuildContext context, bool innerBoxIsScrolled);
    public delegate FlutterSDK.Widgets.Scrollactivity.ScrollActivity _NestedScrollActivityGetter(FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition position);
    internal static class NestedscrollviewDefaultClass
    {
    }

    /// <Summary>
    /// A scrolling view inside of which can be nested other scrolling views, with
    /// their scroll positions being intrinsically linked.
    ///
    /// The most common use case for this widget is a scrollable view with a
    /// flexible [SliverAppBar] containing a [TabBar] in the header (built by
    /// [headerSliverBuilder], and with a [TabBarView] in the [body], such that the
    /// scrollable view's contents vary based on which tab is visible.
    ///
    /// ## Motivation
    ///
    /// In a normal [ScrollView], there is one set of slivers (the components of the
    /// scrolling view). If one of those slivers hosted a [TabBarView] which scrolls
    /// in the opposite direction (e.g. allowing the user to swipe horizontally
    /// between the pages represented by the tabs, while the list scrolls
    /// vertically), then any list inside that [TabBarView] would not interact with
    /// the outer [ScrollView]. For example, flinging the inner list to scroll to
    /// the top would not cause a collapsed [SliverAppBar] in the outer [ScrollView]
    /// to expand.
    ///
    /// [NestedScrollView] solves this problem by providing custom
    /// [ScrollController]s for the outer [ScrollView] and the inner [ScrollView]s
    /// (those inside the [TabBarView], hooking them together so that they appear,
    /// to the user, as one coherent scroll view.
    ///
    /// {@tool snippet}
    ///
    /// This example shows a [NestedScrollView] whose header is the combination of a
    /// [TabBar] in a [SliverAppBar] and whose body is a [TabBarView]. It uses a
    /// [SliverOverlapAbsorber]/[SliverOverlapInjector] pair to make the inner lists
    /// align correctly, and it uses [SafeArea] to avoid any horizontal disturbances
    /// (e.g. the "notch" on iOS when the phone is horizontal). In addition,
    /// [PageStorageKey]s are used to remember the scroll position of each tab's
    /// list.
    ///
    /// In the example below, `_tabs` is a list of strings, one for each tab, giving
    /// the tab labels. In a real application, it would be replaced by the actual
    /// data model being represented.
    ///
    /// ```dart
    /// DefaultTabController(
    ///   length: _tabs.length, // This is the number of tabs.
    ///   child: NestedScrollView(
    ///     headerSliverBuilder: (BuildContext context, bool innerBoxIsScrolled) {
    ///       // These are the slivers that show up in the "outer" scroll view.
    ///       return <Widget>[
    ///         SliverOverlapAbsorber(
    ///           // This widget takes the overlapping behavior of the SliverAppBar,
    ///           // and redirects it to the SliverOverlapInjector below. If it is
    ///           // missing, then it is possible for the nested "inner" scroll view
    ///           // below to end up under the SliverAppBar even when the inner
    ///           // scroll view thinks it has not been scrolled.
    ///           // This is not necessary if the "headerSliverBuilder" only builds
    ///           // widgets that do not overlap the next sliver.
    ///           handle: NestedScrollView.sliverOverlapAbsorberHandleFor(context),
    ///           sliver: SliverAppBar(
    ///             title: const Text('Books'), // This is the title in the app bar.
    ///             pinned: true,
    ///             expandedHeight: 150.0,
    ///             // The "forceElevated" property causes the SliverAppBar to show
    ///             // a shadow. The "innerBoxIsScrolled" parameter is true when the
    ///             // inner scroll view is scrolled beyond its "zero" point, i.e.
    ///             // when it appears to be scrolled below the SliverAppBar.
    ///             // Without this, there are cases where the shadow would appear
    ///             // or not appear inappropriately, because the SliverAppBar is
    ///             // not actually aware of the precise position of the inner
    ///             // scroll views.
    ///             forceElevated: innerBoxIsScrolled,
    ///             bottom: TabBar(
    ///               // These are the widgets to put in each tab in the tab bar.
    ///               tabs: _tabs.map((String name) => Tab(text: name)).toList(),
    ///             ),
    ///           ),
    ///         ),
    ///       ];
    ///     },
    ///     body: TabBarView(
    ///       // These are the contents of the tab views, below the tabs.
    ///       children: _tabs.map((String name) {
    ///         return SafeArea(
    ///           top: false,
    ///           bottom: false,
    ///           child: Builder(
    ///             // This Builder is needed to provide a BuildContext that is
    ///             // "inside" the NestedScrollView, so that
    ///             // sliverOverlapAbsorberHandleFor() can find the
    ///             // NestedScrollView.
    ///             builder: (BuildContext context) {
    ///               return CustomScrollView(
    ///                 // The "controller" and "primary" members should be left
    ///                 // unset, so that the NestedScrollView can control this
    ///                 // inner scroll view.
    ///                 // If the "controller" property is set, then this scroll
    ///                 // view will not be associated with the NestedScrollView.
    ///                 // The PageStorageKey should be unique to this ScrollView;
    ///                 // it allows the list to remember its scroll position when
    ///                 // the tab view is not on the screen.
    ///                 key: PageStorageKey<String>(name),
    ///                 slivers: <Widget>[
    ///                   SliverOverlapInjector(
    ///                     // This is the flip side of the SliverOverlapAbsorber
    ///                     // above.
    ///                     handle: NestedScrollView.sliverOverlapAbsorberHandleFor(context),
    ///                   ),
    ///                   SliverPadding(
    ///                     padding: const EdgeInsets.all(8.0),
    ///                     // In this example, the inner scroll view has
    ///                     // fixed-height list items, hence the use of
    ///                     // SliverFixedExtentList. However, one could use any
    ///                     // sliver widget here, e.g. SliverList or SliverGrid.
    ///                     sliver: SliverFixedExtentList(
    ///                       // The items in this example are fixed to 48 pixels
    ///                       // high. This matches the Material Design spec for
    ///                       // ListTile widgets.
    ///                       itemExtent: 48.0,
    ///                       delegate: SliverChildBuilderDelegate(
    ///                         (BuildContext context, int index) {
    ///                           // This builder is called for each child.
    ///                           // In this example, we just number each list item.
    ///                           return ListTile(
    ///                             title: Text('Item $index'),
    ///                           );
    ///                         },
    ///                         // The childCount of the SliverChildBuilderDelegate
    ///                         // specifies how many children this inner list
    ///                         // has. In this example, each tab has a list of
    ///                         // exactly 30 items, but this is arbitrary.
    ///                         childCount: 30,
    ///                       ),
    ///                     ),
    ///                   ),
    ///                 ],
    ///               );
    ///             },
    ///           ),
    ///         );
    ///       }).toList(),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class NestedScrollView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public NestedScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewHeaderSliversBuilder headerSliverBuilder = default(FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewHeaderSliversBuilder), FlutterSDK.Widgets.Framework.Widget body = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.Controller = controller;
            this.ScrollDirection = scrollDirection;
            this.Reverse = reverse;
            this.Physics = physics;
            this.HeaderSliverBuilder = headerSliverBuilder;
            this.Body = body;
            this.DragStartBehavior = dragStartBehavior;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis ScrollDirection { get; set; }
        public virtual bool Reverse { get; set; }
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
        public virtual FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewHeaderSliversBuilder HeaderSliverBuilder { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Body { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Returns the [SliverOverlapAbsorberHandle] of the nearest ancestor
        /// [NestedScrollView].
        ///
        /// This is necessary to configure the [SliverOverlapAbsorber] and
        /// [SliverOverlapInjector] widgets.
        ///
        /// For sample code showing how to use this method, see the [NestedScrollView]
        /// documentation.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle SliverOverlapAbsorberHandleFor(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _InheritedNestedScrollView target = context.DependOnInheritedWidgetOfExactType();

            return target.State._AbsorberHandle;
        }




        private List<FlutterSDK.Widgets.Framework.Widget> _BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Scrollcontroller.ScrollController innerController, bool bodyIsScrolled)
        {
            return new List<Widget>() {, HeaderSliverBuilder(context, bodyIsScrolled), new SliverFillRemaining(child: new PrimaryScrollController(controller: innerController, child: Body)) };
        }




        public new FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState CreateState() => new NestedScrollViewState();


        #endregion
    }


    /// <Summary>
    /// The [State] for a [NestedScrollView].
    ///
    /// The [ScrollController]s, [innerController] and [outerController], of the
    /// [NestedScrollView]'s children may be accessed through its state. This is
    /// useful for obtaining respective scroll positions in the [NestedScrollView].
    ///
    /// If you want to access the inner or outer scroll controller of a
    /// [NestedScrollView], you can get its [NestedScrollViewState] by supplying a
    /// `GlobalKey<NestedScrollViewState>` to the [NestedScrollView.key] parameter).
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// [NestedScrollViewState] can be obtained using a [GlobalKey].
    /// Using the following setup, you can access the inner scroll controller
    /// using `globalKey.currentState.innerController`.
    ///
    /// ```dart preamble
    /// final GlobalKey<NestedScrollViewState> globalKey = GlobalKey();
    /// ```
    /// ```dart
    /// @override
    /// Widget build(BuildContext context) {
    ///   return NestedScrollView(
    ///     key: globalKey,
    ///     headerSliverBuilder: (BuildContext context, bool innerBoxIsScrolled) {
    ///       return <Widget>[
    ///         SliverAppBar(
    ///           title: Text('NestedScrollViewState Demo!'),
    ///         ),
    ///       ];
    ///     },
    ///     body: CustomScrollView(
    ///       // Body slivers go here!
    ///     ),
    ///   );
    /// }
    ///
    /// ScrollController get innerController {
    ///   return globalKey.currentState.innerController;
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class NestedScrollViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Nestedscrollview.NestedScrollView>
    {
        #region constructors
        public NestedScrollViewState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle _AbsorberHandle { get; set; }
        internal virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator _Coordinator { get; set; }
        internal virtual bool _LastHasScrolledBody { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController InnerController { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController OuterController { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState()
        {
            base.InitState();
            _Coordinator = new _NestedScrollCoordinator(this, Widget.Controller, _HandleHasScrolledBodyChanged);
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            _Coordinator.SetParent(Widget.Controller);
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Nestedscrollview.NestedScrollView oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (oldWidget.Controller != Widget.Controller) _Coordinator.SetParent(Widget.Controller);
        }




        public new void Dispose()
        {
            _Coordinator.Dispose();
            _Coordinator = null;
            base.Dispose();
        }




        private void _HandleHasScrolledBodyChanged()
        {
            if (!Mounted) return;
            bool newHasScrolledBody = _Coordinator.HasScrolledBody;
            if (_LastHasScrolledBody != newHasScrolledBody)
            {
                SetState(() =>
                {
                }
                );
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _InheritedNestedScrollView(state: this, child: new Builder(builder: (BuildContext context) =>
            {
                _LastHasScrolledBody = _Coordinator.HasScrolledBody;
                return new _NestedScrollViewCustomScrollView(dragStartBehavior: Widget.DragStartBehavior, scrollDirection: Widget.ScrollDirection, reverse: Widget.Reverse, physics: Widget.Physics != null ? Widget.Physics.ApplyTo(new ClampingScrollPhysics()) : new ClampingScrollPhysics(), controller: _Coordinator._OuterController, slivers: Widget._BuildSlivers(context, _Coordinator._InnerController, _LastHasScrolledBody), handle: _AbsorberHandle);
            }
            ));
        }



        #endregion
    }


    public class _NestedScrollViewCustomScrollView : FlutterSDK.Widgets.Scrollview.CustomScrollView
    {
        #region constructors
        public _NestedScrollViewCustomScrollView(FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), List<FlutterSDK.Widgets.Framework.Widget> slivers = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle handle = default(FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(scrollDirection: scrollDirection, reverse: reverse, physics: physics, controller: controller, slivers: slivers, dragStartBehavior: dragStartBehavior)
        {
            this.Handle = handle;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget BuildViewport(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection, List<FlutterSDK.Widgets.Framework.Widget> slivers)
        {

            return new NestedScrollViewViewport(axisDirection: axisDirection, offset: offset, slivers: slivers, handle: Handle);
        }



        #endregion
    }


    public class _InheritedNestedScrollView : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public _InheritedNestedScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState state = default(FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.State = state;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState State { get; set; }
        #endregion

        #region methods

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Nestedscrollview._InheritedNestedScrollView old) => State != old.State;

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => State != old.State;


        #endregion
    }


    public class _NestedScrollMetrics : FlutterSDK.Widgets.Scrollmetrics.FixedScrollMetrics
    {
        #region constructors
        public _NestedScrollMetrics(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double minRange = default(double), double maxRange = default(double), double correctionOffset = default(double))
        : base(minScrollExtent: minScrollExtent, maxScrollExtent: maxScrollExtent, pixels: pixels, viewportDimension: viewportDimension, axisDirection: axisDirection)
        {
            this.MinRange = minRange;
            this.MaxRange = maxRange;
            this.CorrectionOffset = correctionOffset;
        }
        #endregion

        #region fields
        public virtual double MinRange { get; set; }
        public virtual double MaxRange { get; set; }
        public virtual double CorrectionOffset { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics CopyWith(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double minRange = default(double), double maxRange = default(double), double correctionOffset = default(double))
        {
            return new _NestedScrollMetrics(minScrollExtent: minScrollExtent == default(double) ? this.minScrollExtent : minScrollExtent, maxScrollExtent: maxScrollExtent == default(double) ? this.maxScrollExtent : maxScrollExtent, pixels: pixels == default(double) ? this.pixels : pixels, viewportDimension: viewportDimension == default(double) ? this.viewportDimension : viewportDimension, axisDirection: axisDirection ?? this.AxisDirection, minRange: minRange == default(double) ? this.minRange : minRange, maxRange: maxRange == default(double) ? this.maxRange : maxRange, correctionOffset: correctionOffset == default(double) ? this.correctionOffset : correctionOffset);
        }



        #endregion
    }


    public class _NestedScrollCoordinator : IScrollActivityDelegate, IScrollHoldController
    {
        #region constructors
        public _NestedScrollCoordinator(FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState _state, FlutterSDK.Widgets.Scrollcontroller.ScrollController _parent, VoidCallback _onHasScrolledBodyChanged)
        {
            this._State = _state;
            this._Parent = _parent;
            this._OnHasScrolledBodyChanged = _onHasScrolledBodyChanged;
            double initialScrollOffset = _Parent?.InitialScrollOffset ?? 0.0;
            _OuterController = new _NestedScrollController(this, initialScrollOffset: initialScrollOffset, debugLabel: "outer");
            _InnerController = new _NestedScrollController(this, initialScrollOffset: 0.0, debugLabel: "inner");
        }


        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState _State { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _Parent { get; set; }
        internal virtual VoidCallback _OnHasScrolledBodyChanged { get; set; }
        internal virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollController _OuterController { get; set; }
        internal virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollController _InnerController { get; set; }
        internal virtual FlutterSDK.Rendering.Viewportoffset.ScrollDirection _UserScrollDirection { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollactivity.ScrollDragController _CurrentDrag { get; set; }
        internal virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition _OuterPosition { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Iterable<FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition> _InnerPositions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CanScrollBody { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasScrolledBody { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Viewportoffset.ScrollDirection UserScrollDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void UpdateShadow()
        {
            if (_OnHasScrolledBodyChanged != null) _OnHasScrolledBodyChanged();
        }




        public virtual void UpdateUserScrollDirection(FlutterSDK.Rendering.Viewportoffset.ScrollDirection value)
        {

            if (UserScrollDirection == value) return;
            _UserScrollDirection = value;
            _OuterPosition.DidUpdateScrollDirection(value);
            foreach (_NestedScrollPosition position in _InnerPositions) position.DidUpdateScrollDirection(value);
        }




        public virtual void BeginActivity(FlutterSDK.Widgets.Scrollactivity.ScrollActivity newOuterActivity, FlutterSDK.Widgets.Nestedscrollview._NestedScrollActivityGetter innerActivityGetter)
        {
            _OuterPosition.BeginActivity(newOuterActivity);
            bool scrolling = newOuterActivity.IsScrolling;
            foreach (_NestedScrollPosition position in _InnerPositions)
            {
                ScrollActivity newInnerActivity = innerActivityGetter(position);
                position.BeginActivity(newInnerActivity);
                scrolling = scrolling && newInnerActivity.IsScrolling;
            }

            _CurrentDrag?.Dispose();
            _CurrentDrag = null;
            if (!scrolling) UpdateUserScrollDirection(ScrollDirection.Idle);
        }




        private FlutterSDK.Widgets.Scrollactivity.IdleScrollActivity _CreateIdleScrollActivity(FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition position)
        {
            return new IdleScrollActivity(position);
        }




        public new void GoIdle()
        {
            BeginActivity(_CreateIdleScrollActivity(_OuterPosition), _CreateIdleScrollActivity);
        }




        public new void GoBallistic(double velocity)
        {
            BeginActivity(CreateOuterBallisticScrollActivity(velocity), (_NestedScrollPosition position) =>
            {
                return CreateInnerBallisticScrollActivity(position, velocity);
            }
            );
        }




        public virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivity CreateOuterBallisticScrollActivity(double velocity)
        {
            _NestedScrollPosition innerPosition = default(_NestedScrollPosition);
            if (velocity != 0.0)
            {
                foreach (_NestedScrollPosition position in _InnerPositions)
                {
                    if (innerPosition != null)
                    {
                        if (velocity > 0.0)
                        {
                            if (innerPosition.Pixels < position.Pixels) continue;
                        }
                        else
                        {

                            if (innerPosition.Pixels > position.Pixels) continue;
                        }

                    }

                    innerPosition = position;
                }

            }

            if (innerPosition == null)
            {
                return _OuterPosition.CreateBallisticScrollActivity(_OuterPosition.Physics.CreateBallisticSimulation(_OuterPosition, velocity), mode: _NestedBallisticScrollActivityMode.Independent);
            }

            _NestedScrollMetrics metrics = _GetMetrics(innerPosition, velocity);
            return _OuterPosition.CreateBallisticScrollActivity(_OuterPosition.Physics.CreateBallisticSimulation(metrics, velocity), mode: _NestedBallisticScrollActivityMode.Outer, metrics: metrics);
        }




        public virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivity CreateInnerBallisticScrollActivity(FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition position, double velocity)
        {
            return position.CreateBallisticScrollActivity(position.Physics.CreateBallisticSimulation(velocity == 0 ? position as ScrollMetrics : _GetMetrics(position, velocity), velocity), mode: _NestedBallisticScrollActivityMode.Inner);
        }




        private FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics _GetMetrics(FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition innerPosition, double velocity)
        {

            double pixels minRange maxRange correctionOffset extra = default(double);
            if (innerPosition.Pixels == innerPosition.MinScrollExtent)
            {
                pixels = _OuterPosition.Pixels.Clamp(_OuterPosition.MinScrollExtent, _OuterPosition.MaxScrollExtent) as double;
                minRange = _OuterPosition.MinScrollExtent;
                maxRange = _OuterPosition.MaxScrollExtent;

                correctionOffset = 0.0;
                extra = 0.0;
            }
            else
            {

                if (innerPosition.Pixels < innerPosition.MinScrollExtent)
                {
                    pixels = innerPosition.Pixels - innerPosition.MinScrollExtent + _OuterPosition.MinScrollExtent;
                }
                else
                {

                    pixels = innerPosition.Pixels - innerPosition.MinScrollExtent + _OuterPosition.MaxScrollExtent;
                }

                if ((velocity > 0.0) && (innerPosition.Pixels > innerPosition.MinScrollExtent))
                {
                    extra = _OuterPosition.MaxScrollExtent - _OuterPosition.Pixels;

                    minRange = pixels;
                    maxRange = pixels + extra;

                    correctionOffset = _OuterPosition.Pixels - pixels;
                }
                else if ((velocity < 0.0) && (innerPosition.Pixels < innerPosition.MinScrollExtent))
                {
                    extra = _OuterPosition.Pixels - _OuterPosition.MinScrollExtent;

                    minRange = pixels - extra;
                    maxRange = pixels;

                    correctionOffset = _OuterPosition.Pixels - pixels;
                }
                else
                {
                    if (velocity > 0.0)
                    {
                        extra = _OuterPosition.MinScrollExtent - _OuterPosition.Pixels;
                    }
                    else
                    {

                        extra = _OuterPosition.Pixels - (_OuterPosition.MaxScrollExtent - _OuterPosition.MinScrollExtent);
                    }


                    minRange = _OuterPosition.MinScrollExtent;
                    maxRange = _OuterPosition.MaxScrollExtent + extra;

                    correctionOffset = 0.0;
                }

            }

            return new _NestedScrollMetrics(minScrollExtent: _OuterPosition.MinScrollExtent, maxScrollExtent: _OuterPosition.MaxScrollExtent + innerPosition.MaxScrollExtent - innerPosition.MinScrollExtent + extra, pixels: pixels, viewportDimension: _OuterPosition.ViewportDimension, axisDirection: _OuterPosition.AxisDirection, minRange: minRange, maxRange: maxRange, correctionOffset: correctionOffset);
        }




        public virtual double UnnestOffset(double value, FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition source)
        {
            if (source == _OuterPosition) return value.Clamp(_OuterPosition.MinScrollExtent, _OuterPosition.MaxScrollExtent) as double;
            if (value < source.MinScrollExtent) return value - source.MinScrollExtent + _OuterPosition.MinScrollExtent;
            return value - source.MinScrollExtent + _OuterPosition.MaxScrollExtent;
        }




        public virtual double NestOffset(double value, FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition target)
        {
            if (target == _OuterPosition) return value.Clamp(_OuterPosition.MinScrollExtent, _OuterPosition.MaxScrollExtent) as double;
            if (value < _OuterPosition.MinScrollExtent) return value - _OuterPosition.MinScrollExtent + target.MinScrollExtent;
            if (value > _OuterPosition.MaxScrollExtent) return value - _OuterPosition.MaxScrollExtent + target.MinScrollExtent;
            return target.MinScrollExtent;
        }




        public virtual void UpdateCanDrag()
        {
            if (!_OuterPosition.HaveDimensions) return;
            double maxInnerExtent = 0.0;
            foreach (_NestedScrollPosition position in _InnerPositions)
            {
                if (!position.HaveDimensions) return;
                maxInnerExtent = Math.Dart:mathDefaultClass.Max(maxInnerExtent, position.MaxScrollExtent - position.MinScrollExtent);
            }

            _OuterPosition.UpdateCanDrag(maxInnerExtent);
        }




        public virtual Future<object> AnimateTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
    async
{
DrivenScrollActivity outerActivity = _OuterPosition.CreateDrivenScrollActivity(NestOffset(to, _OuterPosition), duration, curve);
        List<Future<void>> resultFutures = new List<Future<void>>() { outerActivity.Done };
        BeginActivity(outerActivity, (_NestedScrollPosition position) => {
            DrivenScrollActivity innerActivity = position.CreateDrivenScrollActivity(NestOffset(to, position), duration, curve);
            resultFutures.Add(innerActivity.Done);
            return innerActivity;
        }
);
await Dart:asyncDefaultClass.Future.Wait(resultFutures);
}




    public virtual void JumpTo(double to)
    {
        GoIdle();
        _OuterPosition.LocalJumpTo(NestOffset(to, _OuterPosition));
        foreach (_NestedScrollPosition position in _InnerPositions) position.LocalJumpTo(NestOffset(to, position));
        GoBallistic(0.0);
    }




    public new double SetPixels(double newPixels)
    {

        return 0.0;
    }




    public virtual FlutterSDK.Widgets.Scrollactivity.ScrollHoldController Hold(VoidCallback holdCancelCallback)
    {
        BeginActivity(new HoldScrollActivity(@delegate: _OuterPosition, onHoldCanceled: holdCancelCallback), (_NestedScrollPosition position) => =>new HoldScrollActivity(@delegate: position));
        return this;
    }




    public new void Cancel()
    {
        GoBallistic(0.0);
    }




    public virtual FlutterSDK.Gestures.Drag.Drag Drag(FlutterSDK.Gestures.Dragdetails.DragStartDetails details, VoidCallback dragCancelCallback)
    {
        ScrollDragController drag = new ScrollDragController(@delegate: this, details: details, onDragCanceled: dragCancelCallback);
        BeginActivity(new DragScrollActivity(_OuterPosition, drag), (_NestedScrollPosition position) => =>new DragScrollActivity(position, drag));

        _CurrentDrag = drag;
        return drag;
    }




    public new void ApplyUserOffset(double delta)
    {
        UpdateUserScrollDirection(delta > 0.0 ? ScrollDirection.Forward : ScrollDirection.Reverse);

        if (_InnerPositions.IsEmpty())
        {
            _OuterPosition.ApplyFullDragUpdate(delta);
        }
        else if (delta < 0.0)
        {
            double innerDelta = _OuterPosition.ApplyClampedDragUpdate(delta);
            if (innerDelta != 0.0)
            {
                foreach (_NestedScrollPosition position in _InnerPositions) position.ApplyFullDragUpdate(innerDelta);
            }

        }
        else
        {
            double outerDelta = 0.0;
            List<double> overscrolls = new List<double>() { };
            List<_NestedScrollPosition> innerPositions = _InnerPositions.ToList();
            foreach (_NestedScrollPosition position in innerPositions)
            {
                double overscroll = position.ApplyClampedDragUpdate(delta);
                outerDelta = Math.Dart:mathDefaultClass.Max(outerDelta, overscroll);
                overscrolls.Add(overscroll);
            }

            if (outerDelta != 0.0) outerDelta -= _OuterPosition.ApplyClampedDragUpdate(outerDelta);
            for (int i = 0; i < innerPositions.Count; ++i)
            {
                double remainingDelta = overscrolls[i] - outerDelta;
                if (remainingDelta > 0.0) innerPositions[i].ApplyFullDragUpdate(remainingDelta);
            }

        }

    }




    public virtual void SetParent(FlutterSDK.Widgets.Scrollcontroller.ScrollController value)
    {
        _Parent = value;
        UpdateParent();
    }




    public virtual void UpdateParent()
    {
        _OuterPosition?.SetParent(_Parent ?? PrimaryscrollcontrollerDefaultClass.PrimaryScrollController.Of(_State.Context));
    }




    public virtual void Dispose()
    {
        _CurrentDrag?.Dispose();
        _CurrentDrag = null;
        _OuterController.Dispose();
        _InnerController.Dispose();
    }




    #endregion
}


public class _NestedScrollController : FlutterSDK.Widgets.Scrollcontroller.ScrollController
{
    #region constructors
    public _NestedScrollController(FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator coordinator, double initialScrollOffset = 0.0, string debugLabel = default(string))
    : base(initialScrollOffset: initialScrollOffset, debugLabel: debugLabel)
    {
        this.Coordinator = coordinator;
    }
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator Coordinator { get; set; }
    public virtual Iterable<FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition> NestedPositions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new FlutterSDK.Widgets.Scrollposition.ScrollPosition CreateScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics, FlutterSDK.Widgets.Scrollcontext.ScrollContext context, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition)
    {
        return new _NestedScrollPosition(coordinator: Coordinator, physics: physics, context: context, initialPixels: InitialScrollOffset, oldPosition: oldPosition, debugLabel: DebugLabel);
    }




    public new void Attach(FlutterSDK.Widgets.Scrollposition.ScrollPosition position)
    {

        base.Attach(position);
        Coordinator.UpdateParent();
        Coordinator.UpdateCanDrag();
        position.AddListener(_ScheduleUpdateShadow);
        _ScheduleUpdateShadow();
    }




    public new void Detach(FlutterSDK.Widgets.Scrollposition.ScrollPosition position)
    {

        position.RemoveListener(_ScheduleUpdateShadow);
        base.Detach(position);
        _ScheduleUpdateShadow();
    }




    private void _ScheduleUpdateShadow()
    {
        BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan timeStamp) =>
        {
            Coordinator.UpdateShadow();
        }
        );
    }



    #endregion
}


public class _NestedScrollPosition : FlutterSDK.Widgets.Scrollposition.ScrollPosition, IScrollActivityDelegate
{
    #region constructors
    public _NestedScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontext.ScrollContext context = default(FlutterSDK.Widgets.Scrollcontext.ScrollContext), double initialPixels = 0.0, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition), string debugLabel = default(string), FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator coordinator = default(FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator))
    : base(physics: physics, context: context, oldPosition: oldPosition, debugLabel: debugLabel)
    {
        this.Coordinator = coordinator;
        if (Pixels == null && initialPixels != null) CorrectPixels(initialPixels);
        if (Activity == null) GoIdle();

        SaveScrollOffset();
    }


    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator Coordinator { get; set; }
    internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _Parent { get; set; }
    public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Rendering.Viewportoffset.ScrollDirection UserScrollDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public virtual void SetParent(FlutterSDK.Widgets.Scrollcontroller.ScrollController value)
    {
        _Parent?.Detach(this);
        _Parent = value;
        _Parent?.Attach(this);
    }




    public new void Absorb(FlutterSDK.Widgets.Scrollposition.ScrollPosition other)
    {
        base.Absorb(other);
        Activity.UpdateDelegate(this);
    }




    public new void RestoreScrollOffset()
    {
        if (Coordinator.CanScrollBody) base.RestoreScrollOffset();
    }




    public virtual double ApplyClampedDragUpdate(double delta)
    {

        double min = delta < 0.0 ? -Dart : coreDefaultClass.Double.Infinity:Math.Dart:mathDefaultClass.Min(MinScrollExtent, Pixels);
        double max = delta > 0.0 ? Dart : coreDefaultClass.Double.Infinity:Math.Dart:mathDefaultClass.Max(MaxScrollExtent, Pixels);
        double oldPixels = Pixels;
        double newPixels = (Pixels - delta).Clamp(min, max) as double;
        double clampedDelta = newPixels - Pixels;
        if (clampedDelta == 0.0) return delta;
        double overscroll = Physics.ApplyBoundaryConditions(this, newPixels);
        double actualNewPixels = newPixels - overscroll;
        double offset = actualNewPixels - oldPixels;
        if (offset != 0.0)
        {
            ForcePixels(actualNewPixels);
            DidUpdateScrollPositionBy(offset);
        }

        return delta + offset;
    }




    public virtual double ApplyFullDragUpdate(double delta)
    {

        double oldPixels = Pixels;
        double newPixels = Pixels - Physics.ApplyPhysicsToUserOffset(this, delta);
        if (oldPixels == newPixels) return 0.0;
        double overscroll = Physics.ApplyBoundaryConditions(this, newPixels);
        double actualNewPixels = newPixels - overscroll;
        if (actualNewPixels != oldPixels)
        {
            ForcePixels(actualNewPixels);
            DidUpdateScrollPositionBy(actualNewPixels - oldPixels);
        }

        if (overscroll != 0.0)
        {
            DidOverscrollBy(overscroll);
            return overscroll;
        }

        return 0.0;
    }




    public virtual FlutterSDK.Widgets.Scrollactivity.DrivenScrollActivity CreateDrivenScrollActivity(double to, TimeSpan duration, FlutterSDK.Animation.Curves.Curve curve)
    {
        return new DrivenScrollActivity(this, from: Pixels, to: to, duration: duration, curve: curve, vsync: Vsync);
    }




    public new double ApplyUserOffset(double delta)
    {

        return 0.0;
    }




    public new void GoIdle()
    {
        BeginActivity(new IdleScrollActivity(this));
    }




    public new void GoBallistic(double velocity)
    {
        Simulation simulation = default(Simulation);
        if (velocity != 0.0 || OutOfRange) simulation = Physics.CreateBallisticSimulation(this, velocity);
        BeginActivity(CreateBallisticScrollActivity(simulation, mode: _NestedBallisticScrollActivityMode.Independent));
    }




    public virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivity CreateBallisticScrollActivity(FlutterSDK.Physics.Simulation.Simulation simulation, FlutterSDK.Widgets.Nestedscrollview._NestedBallisticScrollActivityMode mode = default(FlutterSDK.Widgets.Nestedscrollview._NestedBallisticScrollActivityMode), FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics metrics = default(FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics))
    {
        if (simulation == null) return new IdleScrollActivity(this);

        switch (mode) { case _NestedBallisticScrollActivityMode.Outer: if (metrics.MinRange == metrics.MaxRange) return new IdleScrollActivity(this); return new _NestedOuterBallisticScrollActivity(Coordinator, this, metrics, simulation, Context.Vsync); case _NestedBallisticScrollActivityMode.Inner: return new _NestedInnerBallisticScrollActivity(Coordinator, this, simulation, Context.Vsync); case _NestedBallisticScrollActivityMode.Independent: return new BallisticScrollActivity(this, simulation, Context.Vsync); }
        return null;
    }




    public new Future<object> AnimateTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
    {
        return Coordinator.AnimateTo(Coordinator.UnnestOffset(to, this), duration: duration, curve: curve);
    }




    public new void JumpTo(double value)
    {
        return Coordinator.JumpTo(Coordinator.UnnestOffset(value, this));
    }




    public new void JumpToWithoutSettling(double value)
    {

    }




    public virtual void LocalJumpTo(double value)
    {
        if (Pixels != value)
        {
            double oldPixels = Pixels;
            ForcePixels(value);
            DidStartScroll();
            DidUpdateScrollPositionBy(Pixels - oldPixels);
            DidEndScroll();
        }

    }




    public new void ApplyNewDimensions()
    {
        base.ApplyNewDimensions();
        Coordinator.UpdateCanDrag();
    }




    public virtual void UpdateCanDrag(double totalExtent)
    {
        Context.SetCanDrag(totalExtent > (ViewportDimension - MaxScrollExtent) || MinScrollExtent != MaxScrollExtent);
    }




    public new FlutterSDK.Widgets.Scrollactivity.ScrollHoldController Hold(VoidCallback holdCancelCallback)
    {
        return Coordinator.Hold(holdCancelCallback);
    }




    public new FlutterSDK.Gestures.Drag.Drag Drag(FlutterSDK.Gestures.Dragdetails.DragStartDetails details, VoidCallback dragCancelCallback)
    {
        return Coordinator.Drag(details, dragCancelCallback);
    }




    public new void Dispose()
    {
        _Parent?.Detach(this);
        base.Dispose();
    }



    #endregion
}


public class _NestedInnerBallisticScrollActivity : FlutterSDK.Widgets.Scrollactivity.BallisticScrollActivity
{
    #region constructors
    public _NestedInnerBallisticScrollActivity(FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator coordinator, FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition position, FlutterSDK.Physics.Simulation.Simulation simulation, FlutterSDK.Scheduler.Ticker.TickerProvider vsync)
    : base(position, simulation, vsync)
    {
        this.Coordinator = coordinator;
    }
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator Coordinator { get; set; }
    public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition @delegate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void ResetActivity()
    {
        Delegate.BeginActivity(Coordinator.CreateInnerBallisticScrollActivity(Delegate, Velocity));
    }




    public new void ApplyNewDimensions()
    {
        Delegate.BeginActivity(Coordinator.CreateInnerBallisticScrollActivity(Delegate, Velocity));
    }




    public new bool ApplyMoveTo(double value)
    {
        return base.ApplyMoveTo(Coordinator.NestOffset(value, Delegate));
    }



    #endregion
}


public class _NestedOuterBallisticScrollActivity : FlutterSDK.Widgets.Scrollactivity.BallisticScrollActivity
{
    #region constructors
    public _NestedOuterBallisticScrollActivity(FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator coordinator, FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition position, FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics metrics, FlutterSDK.Physics.Simulation.Simulation simulation, FlutterSDK.Scheduler.Ticker.TickerProvider vsync)
    : base(position, simulation, vsync)
    {
        this.Coordinator = coordinator;
        this.Metrics = metrics;
    }
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator Coordinator { get; set; }
    public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics Metrics { get; set; }
    public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition @delegate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void ResetActivity()
    {
        Delegate.BeginActivity(Coordinator.CreateOuterBallisticScrollActivity(Velocity));
    }




    public new void ApplyNewDimensions()
    {
        Delegate.BeginActivity(Coordinator.CreateOuterBallisticScrollActivity(Velocity));
    }




    public new bool ApplyMoveTo(double value)
    {
        bool done = false;
        if (Velocity > 0.0)
        {
            if (value < Metrics.MinRange) return true;
            if (value > Metrics.MaxRange)
            {
                value = Metrics.MaxRange;
                done = true;
            }

        }
        else if (Velocity < 0.0)
        {
            if (value > Metrics.MaxRange) return true;
            if (value < Metrics.MinRange)
            {
                value = Metrics.MinRange;
                done = true;
            }

        }
        else
        {
            value = value.Clamp(Metrics.MinRange, Metrics.MaxRange) as double;
            done = true;
        }

        bool result = base.ApplyMoveTo(value + Metrics.CorrectionOffset);

        return !done;
    }




    #endregion
}


/// <Summary>
/// Handle to provide to a [SliverOverlapAbsorber], a [SliverOverlapInjector],
/// and an [NestedScrollViewViewport], to shift overlap in a [NestedScrollView].
///
/// A particular [SliverOverlapAbsorberHandle] can only be assigned to a single
/// [SliverOverlapAbsorber] at a time. It can also be (and normally is) assigned
/// to one or more [SliverOverlapInjector]s, which must be later descendants of
/// the same [NestedScrollViewViewport] as the [SliverOverlapAbsorber]. The
/// [SliverOverlapAbsorber] must be a direct descendant of the
/// [NestedScrollViewViewport], taking part in the same sliver layout. (The
/// [SliverOverlapInjector] can be a descendant that takes part in a nested
/// scroll view's sliver layout.)
///
/// Whenever the [NestedScrollViewViewport] is marked dirty for layout, it will
/// cause its assigned [SliverOverlapAbsorberHandle] to fire notifications. It
/// is the responsibility of the [SliverOverlapInjector]s (and any other
/// clients) to mark themselves dirty when this happens, in case the geometry
/// subsequently changes during layout.
///
/// See also:
///
///  * [NestedScrollView], which uses a [NestedScrollViewViewport] and a
///    [SliverOverlapAbsorber] to align its children, and which shows sample
///    usage for this class.
/// </Summary>
public class SliverOverlapAbsorberHandle : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
{
    #region constructors
    public SliverOverlapAbsorberHandle()
    { }
    #endregion

    #region fields
    internal virtual int _Writers { get; set; }
    internal virtual double _LayoutExtent { get; set; }
    internal virtual double _ScrollExtent { get; set; }
    public virtual double LayoutExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double ScrollExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    private void _SetExtents(double layoutValue, double scrollValue)
    {

        _LayoutExtent = layoutValue;
        _ScrollExtent = scrollValue;
    }




    private void _MarkNeedsLayout() => NotifyListeners();



    #endregion
}


/// <Summary>
/// A sliver that wraps another, forcing its layout extent to be treated as
/// overlap.
///
/// The difference between the overlap requested by the child [sliver] and the
/// overlap reported by this widget, called the _absorbed overlap_, is reported
/// to the [SliverOverlapAbsorberHandle], which is typically passed to a
/// [SliverOverlapInjector].
///
/// See also:
///
///  * [NestedScrollView], whose documentation has sample code showing how to
///    use this widget.
/// </Summary>
public class SliverOverlapAbsorber : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
    #region constructors
    public SliverOverlapAbsorber(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle handle = default(FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key, child: sliver ?? child)
    {
        this.Handle = handle;
    }
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Widgets.Nestedscrollview.RenderSliverOverlapAbsorber CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new RenderSliverOverlapAbsorber(handle: Handle);
    }




    public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Nestedscrollview.RenderSliverOverlapAbsorber renderObject)
    {
        renderObject.Handle = Handle;
    }


    public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
    {
        renderObject.Handle = Handle;
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<SliverOverlapAbsorberHandle>("handle", Handle));
    }



    #endregion
}


/// <Summary>
/// A sliver that wraps another, forcing its layout extent to be treated as
/// overlap.
///
/// The difference between the overlap requested by the child [sliver] and the
/// overlap reported by this widget, called the _absorbed overlap_, is reported
/// to the [SliverOverlapAbsorberHandle], which is typically passed to a
/// [RenderSliverOverlapInjector].
/// </Summary>
public class RenderSliverOverlapAbsorber : FlutterSDK.Rendering.Sliver.RenderSliver, IRenderObjectWithChildMixin<FlutterSDK.Rendering.Sliver.RenderSliver>
{
    #region constructors
    public RenderSliverOverlapAbsorber(FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle handle = default(FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle), FlutterSDK.Rendering.Sliver.RenderSliver child = default(FlutterSDK.Rendering.Sliver.RenderSliver), FlutterSDK.Rendering.Sliver.RenderSliver sliver = default(FlutterSDK.Rendering.Sliver.RenderSliver))
    : base()
    {

        this.Child = sliver ?? child;
    }


    #endregion

    #region fields
    internal virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle _Handle { get; set; }
    public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
    {
        base.Attach(owner);
        Handle._Writers += 1;
    }


    public new void Attach(@Object owner)
    {
        base.Attach(owner);
        Handle._Writers += 1;
    }




    public new void Detach()
    {
        Handle._Writers -= 1;
        base.Detach();
    }




    public new void PerformLayout()
    {

        if (Child == null)
        {
            Geometry = new SliverGeometry();
            return;
        }

        Child.Layout(Constraints, parentUsesSize: true);
        SliverGeometry childLayoutGeometry = Child.Geometry;
        Geometry = new SliverGeometry(scrollExtent: childLayoutGeometry.ScrollExtent - childLayoutGeometry.MaxScrollObstructionExtent, paintExtent: childLayoutGeometry.PaintExtent, paintOrigin: childLayoutGeometry.PaintOrigin, layoutExtent: Math.Dart:mathDefaultClass.Max(0, childLayoutGeometry.PaintExtent - childLayoutGeometry.MaxScrollObstructionExtent), maxPaintExtent: childLayoutGeometry.MaxPaintExtent, maxScrollObstructionExtent: childLayoutGeometry.MaxScrollObstructionExtent, hitTestExtent: childLayoutGeometry.HitTestExtent, visible: childLayoutGeometry.Visible, hasVisualOverflow: childLayoutGeometry.HasVisualOverflow, scrollOffsetCorrection: childLayoutGeometry.ScrollOffsetCorrection);
        Handle._SetExtents(childLayoutGeometry.MaxScrollObstructionExtent, childLayoutGeometry.MaxScrollObstructionExtent);
    }




    public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
    {
    }




    public new bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double))
    {
        if (Child != null) return Child.HitTest(result, mainAxisPosition: mainAxisPosition, crossAxisPosition: crossAxisPosition);
        return false;
    }




    public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {
        if (Child != null) context.PaintChild(Child, offset);
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<SliverOverlapAbsorberHandle>("handle", Handle));
    }



    #endregion
}


/// <Summary>
/// A sliver that has a sliver geometry based on the values stored in a
/// [SliverOverlapAbsorberHandle].
///
/// The [SliverOverlapAbsorber] must be an earlier descendant of a common
/// ancestor [Viewport], so that it will always be laid out before the
/// [SliverOverlapInjector] during a particular frame.
///
/// See also:
///
///  * [NestedScrollView], which uses a [SliverOverlapAbsorber] to align its
///    children, and which shows sample usage for this class.
/// </Summary>
public class SliverOverlapInjector : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
    #region constructors
    public SliverOverlapInjector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle handle = default(FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key, child: sliver ?? child)
    {
        this.Handle = handle;
    }
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Widgets.Nestedscrollview.RenderSliverOverlapInjector CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new RenderSliverOverlapInjector(handle: Handle);
    }




    public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Nestedscrollview.RenderSliverOverlapInjector renderObject)
    {
        renderObject.Handle = Handle;
    }


    public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
    {
        renderObject.Handle = Handle;
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<SliverOverlapAbsorberHandle>("handle", Handle));
    }



    #endregion
}


/// <Summary>
/// A sliver that has a sliver geometry based on the values stored in a
/// [SliverOverlapAbsorberHandle].
///
/// The [RenderSliverOverlapAbsorber] must be an earlier descendant of a common
/// ancestor [RenderViewport] (probably a [RenderNestedScrollViewViewport]), so
/// that it will always be laid out before the [RenderSliverOverlapInjector]
/// during a particular frame.
/// </Summary>
public class RenderSliverOverlapInjector : FlutterSDK.Rendering.Sliver.RenderSliver
{
    #region constructors
    public RenderSliverOverlapInjector(FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle handle = default(FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle))
    : base()
    {

    }
    #endregion

    #region fields
    internal virtual double _CurrentLayoutExtent { get; set; }
    internal virtual double _CurrentMaxExtent { get; set; }
    internal virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle _Handle { get; set; }
    public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
    {
        base.Attach(owner);
        Handle.AddListener(MarkNeedsLayout);
        if (Handle.LayoutExtent != _CurrentLayoutExtent || Handle.ScrollExtent != _CurrentMaxExtent) MarkNeedsLayout();
    }


    public new void Attach(@Object owner)
    {
        base.Attach(owner);
        Handle.AddListener(MarkNeedsLayout);
        if (Handle.LayoutExtent != _CurrentLayoutExtent || Handle.ScrollExtent != _CurrentMaxExtent) MarkNeedsLayout();
    }




    public new void Detach()
    {
        Handle.RemoveListener(MarkNeedsLayout);
        base.Detach();
    }




    public new void PerformLayout()
    {
        _CurrentLayoutExtent = Handle.LayoutExtent;
        _CurrentMaxExtent = Handle.LayoutExtent;
        double clampedLayoutExtent = Math.Dart:mathDefaultClass.Min(_CurrentLayoutExtent - Constraints.ScrollOffset, Constraints.RemainingPaintExtent);
        Geometry = new SliverGeometry(scrollExtent: _CurrentLayoutExtent, paintExtent: Math.Dart:mathDefaultClass.Max(0.0, clampedLayoutExtent), maxPaintExtent: _CurrentMaxExtent);
    }




    public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {

    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<SliverOverlapAbsorberHandle>("handle", Handle));
    }



    #endregion
}


/// <Summary>
/// The [Viewport] variant used by [NestedScrollView].
///
/// This viewport takes a [SliverOverlapAbsorberHandle] and notifies it any time
/// the viewport needs to recompute its layout (e.g. when it is scrolled).
/// </Summary>
public class NestedScrollViewViewport : FlutterSDK.Widgets.Viewport.Viewport
{
    #region constructors
    public NestedScrollViewViewport(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double anchor = 0.0, FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), FlutterSDK.Foundation.Key.Key center = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> slivers = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle handle = default(FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle))
    : base(key: key, axisDirection: axisDirection, crossAxisDirection: crossAxisDirection, anchor: anchor, offset: offset, center: center, slivers: slivers)
    {
        this.Handle = handle;
    }
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Widgets.Nestedscrollview.RenderNestedScrollViewViewport CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new RenderNestedScrollViewViewport(axisDirection: AxisDirection, crossAxisDirection: CrossAxisDirection ?? ViewportDefaultClass.Viewport.GetDefaultCrossAxisDirection(context, AxisDirection), anchor: Anchor, offset: Offset, handle: Handle);
    }




    public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Nestedscrollview.RenderNestedScrollViewViewport renderObject)
    {
        ..AxisDirection = AxisDirection..CrossAxisDirection = CrossAxisDirection ?? ViewportDefaultClass.Viewport.GetDefaultCrossAxisDirection(context, AxisDirection)..Anchor = Anchor..Offset = Offset..Handle = Handle;
    }


    public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
    {
        ..AxisDirection = AxisDirection..CrossAxisDirection = CrossAxisDirection ?? ViewportDefaultClass.Viewport.GetDefaultCrossAxisDirection(context, AxisDirection)..Anchor = Anchor..Offset = Offset..Handle = Handle;
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<SliverOverlapAbsorberHandle>("handle", Handle));
    }



    #endregion
}


/// <Summary>
/// The [RenderViewport] variant used by [NestedScrollView].
///
/// This viewport takes a [SliverOverlapAbsorberHandle] and notifies it any time
/// the viewport needs to recompute its layout (e.g. when it is scrolled).
/// </Summary>
public class RenderNestedScrollViewViewport : FlutterSDK.Rendering.Viewport.RenderViewport
{
    #region constructors
    public RenderNestedScrollViewViewport(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), double anchor = 0.0, List<FlutterSDK.Rendering.Sliver.RenderSliver> children = default(List<FlutterSDK.Rendering.Sliver.RenderSliver>), FlutterSDK.Rendering.Sliver.RenderSliver center = default(FlutterSDK.Rendering.Sliver.RenderSliver), FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle handle = default(FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle))
    : base(axisDirection: axisDirection, crossAxisDirection: crossAxisDirection, offset: offset, anchor: anchor, children: children, center: center)
    {

    }
    #endregion

    #region fields
    internal virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle _Handle { get; set; }
    public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void MarkNeedsLayout()
    {
        Handle._MarkNeedsLayout();
        base.MarkNeedsLayout();
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<SliverOverlapAbsorberHandle>("handle", Handle));
    }



    #endregion
}


public enum _NestedBallisticScrollActivityMode
{

    Outer,
    Inner,
    Independent,
}

}
