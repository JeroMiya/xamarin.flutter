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
            this.DragStartBehavior = dragStartBehavior; throw new NotImplementedException();
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
        public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle SliverOverlapAbsorberHandleFor(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        private List<FlutterSDK.Widgets.Framework.Widget> _BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Scrollcontroller.ScrollController innerController, bool bodyIsScrolled) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState CreateState() { throw new NotImplementedException(); }

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

        public new void InitState() { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Widgets.Nestedscrollview.NestedScrollView oldWidget) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _HandleHasScrolledBodyChanged() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _NestedScrollViewCustomScrollView : FlutterSDK.Widgets.Scrollview.CustomScrollView
    {
        #region constructors
        public _NestedScrollViewCustomScrollView(FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), List<FlutterSDK.Widgets.Framework.Widget> slivers = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle handle = default(FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(scrollDirection: scrollDirection, reverse: reverse, physics: physics, controller: controller, slivers: slivers, dragStartBehavior: dragStartBehavior)
        {
            this.Handle = handle; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget BuildViewport(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection, List<FlutterSDK.Widgets.Framework.Widget> slivers) { throw new NotImplementedException(); }

        #endregion
    }


    public class _InheritedNestedScrollView : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public _InheritedNestedScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState state = default(FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.State = state; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState State { get; set; }
        #endregion

        #region methods

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Nestedscrollview._InheritedNestedScrollView old) { throw new NotImplementedException(); }
        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }

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
            this.CorrectionOffset = correctionOffset; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double MinRange { get; set; }
        public virtual double MaxRange { get; set; }
        public virtual double CorrectionOffset { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics CopyWith(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double minRange = default(double), double maxRange = default(double), double correctionOffset = default(double)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _NestedScrollCoordinator : IScrollActivityDelegate, IScrollHoldController
    {
        #region constructors
        public _NestedScrollCoordinator(FlutterSDK.Widgets.Nestedscrollview.NestedScrollViewState _state, FlutterSDK.Widgets.Scrollcontroller.ScrollController _parent, VoidCallback _onHasScrolledBodyChanged)
        {
            this._State = _state;
            this._Parent = _parent;
            this._OnHasScrolledBodyChanged = _onHasScrolledBodyChanged; throw new NotImplementedException();
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

        public virtual void UpdateShadow() { throw new NotImplementedException(); }


        public virtual void UpdateUserScrollDirection(FlutterSDK.Rendering.Viewportoffset.ScrollDirection value) { throw new NotImplementedException(); }


        public virtual void BeginActivity(FlutterSDK.Widgets.Scrollactivity.ScrollActivity newOuterActivity, FlutterSDK.Widgets.Nestedscrollview._NestedScrollActivityGetter innerActivityGetter) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Scrollactivity.IdleScrollActivity _CreateIdleScrollActivity(FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition position) { throw new NotImplementedException(); }


        public new void GoIdle() { throw new NotImplementedException(); }


        public new void GoBallistic(double velocity) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivity CreateOuterBallisticScrollActivity(double velocity) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivity CreateInnerBallisticScrollActivity(FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition position, double velocity) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics _GetMetrics(FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition innerPosition, double velocity) { throw new NotImplementedException(); }


        public virtual double UnnestOffset(double value, FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition source) { throw new NotImplementedException(); }


        public virtual double NestOffset(double value, FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition target) { throw new NotImplementedException(); }


        public virtual void UpdateCanDrag() { throw new NotImplementedException(); }


        public virtual Future<object> AnimateTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)) { throw new NotImplementedException(); }


        public virtual void JumpTo(double to) { throw new NotImplementedException(); }


        public new double SetPixels(double newPixels) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Scrollactivity.ScrollHoldController Hold(VoidCallback holdCancelCallback) { throw new NotImplementedException(); }


        public new void Cancel() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Gestures.Drag.Drag Drag(FlutterSDK.Gestures.Dragdetails.DragStartDetails details, VoidCallback dragCancelCallback) { throw new NotImplementedException(); }


        public new void ApplyUserOffset(double delta) { throw new NotImplementedException(); }


        public virtual void SetParent(FlutterSDK.Widgets.Scrollcontroller.ScrollController value) { throw new NotImplementedException(); }


        public virtual void UpdateParent() { throw new NotImplementedException(); }


        public virtual void Dispose() { throw new NotImplementedException(); }


        #endregion
    }


    public class _NestedScrollController : FlutterSDK.Widgets.Scrollcontroller.ScrollController
    {
        #region constructors
        public _NestedScrollController(FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator coordinator, double initialScrollOffset = 0.0, string debugLabel = default(string))
        : base(initialScrollOffset: initialScrollOffset, debugLabel: debugLabel)
        {
            this.Coordinator = coordinator; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator Coordinator { get; set; }
        public virtual Iterable<FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition> NestedPositions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Scrollposition.ScrollPosition CreateScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics, FlutterSDK.Widgets.Scrollcontext.ScrollContext context, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Widgets.Scrollposition.ScrollPosition position) { throw new NotImplementedException(); }


        public new void Detach(FlutterSDK.Widgets.Scrollposition.ScrollPosition position) { throw new NotImplementedException(); }


        private void _ScheduleUpdateShadow() { throw new NotImplementedException(); }

        #endregion
    }


    public class _NestedScrollPosition : FlutterSDK.Widgets.Scrollposition.ScrollPosition, IScrollActivityDelegate
    {
        #region constructors
        public _NestedScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontext.ScrollContext context = default(FlutterSDK.Widgets.Scrollcontext.ScrollContext), double initialPixels = 0.0, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition), string debugLabel = default(string), FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator coordinator = default(FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator))
        : base(physics: physics, context: context, oldPosition: oldPosition, debugLabel: debugLabel)
        {
            this.Coordinator = coordinator; throw new NotImplementedException();
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

        public virtual void SetParent(FlutterSDK.Widgets.Scrollcontroller.ScrollController value) { throw new NotImplementedException(); }


        public new void Absorb(FlutterSDK.Widgets.Scrollposition.ScrollPosition other) { throw new NotImplementedException(); }


        public new void RestoreScrollOffset() { throw new NotImplementedException(); }


        public virtual double ApplyClampedDragUpdate(double delta) { throw new NotImplementedException(); }


        public virtual double ApplyFullDragUpdate(double delta) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Scrollactivity.DrivenScrollActivity CreateDrivenScrollActivity(double to, TimeSpan duration, FlutterSDK.Animation.Curves.Curve curve) { throw new NotImplementedException(); }


        public new double ApplyUserOffset(double delta) { throw new NotImplementedException(); }


        public new void GoIdle() { throw new NotImplementedException(); }


        public new void GoBallistic(double velocity) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivity CreateBallisticScrollActivity(FlutterSDK.Physics.Simulation.Simulation simulation, FlutterSDK.Widgets.Nestedscrollview._NestedBallisticScrollActivityMode mode = default(FlutterSDK.Widgets.Nestedscrollview._NestedBallisticScrollActivityMode), FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics metrics = default(FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics)) { throw new NotImplementedException(); }


        public new Future<object> AnimateTo(double to, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)) { throw new NotImplementedException(); }


        public new void JumpTo(double value) { throw new NotImplementedException(); }


        public new void JumpToWithoutSettling(double value) { throw new NotImplementedException(); }


        public virtual void LocalJumpTo(double value) { throw new NotImplementedException(); }


        public new void ApplyNewDimensions() { throw new NotImplementedException(); }


        public virtual void UpdateCanDrag(double totalExtent) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Scrollactivity.ScrollHoldController Hold(VoidCallback holdCancelCallback) { throw new NotImplementedException(); }


        public new FlutterSDK.Gestures.Drag.Drag Drag(FlutterSDK.Gestures.Dragdetails.DragStartDetails details, VoidCallback dragCancelCallback) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }

        #endregion
    }


    public class _NestedInnerBallisticScrollActivity : FlutterSDK.Widgets.Scrollactivity.BallisticScrollActivity
    {
        #region constructors
        public _NestedInnerBallisticScrollActivity(FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator coordinator, FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition position, FlutterSDK.Physics.Simulation.Simulation simulation, FlutterSDK.Scheduler.Ticker.TickerProvider vsync)
        : base(position, simulation, vsync)
        {
            this.Coordinator = coordinator; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator Coordinator { get; set; }
        public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition @delegate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ResetActivity() { throw new NotImplementedException(); }


        public new void ApplyNewDimensions() { throw new NotImplementedException(); }


        public new bool ApplyMoveTo(double value) { throw new NotImplementedException(); }

        #endregion
    }


    public class _NestedOuterBallisticScrollActivity : FlutterSDK.Widgets.Scrollactivity.BallisticScrollActivity
    {
        #region constructors
        public _NestedOuterBallisticScrollActivity(FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator coordinator, FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition position, FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics metrics, FlutterSDK.Physics.Simulation.Simulation simulation, FlutterSDK.Scheduler.Ticker.TickerProvider vsync)
        : base(position, simulation, vsync)
        {
            this.Coordinator = coordinator;
            this.Metrics = metrics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollCoordinator Coordinator { get; set; }
        public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollMetrics Metrics { get; set; }
        public virtual FlutterSDK.Widgets.Nestedscrollview._NestedScrollPosition @delegate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ResetActivity() { throw new NotImplementedException(); }


        public new void ApplyNewDimensions() { throw new NotImplementedException(); }


        public new bool ApplyMoveTo(double value) { throw new NotImplementedException(); }


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

        private void _SetExtents(double layoutValue, double scrollValue) { throw new NotImplementedException(); }


        private void _MarkNeedsLayout() { throw new NotImplementedException(); }


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
            this.Handle = handle; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Nestedscrollview.RenderSliverOverlapAbsorber CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Nestedscrollview.RenderSliverOverlapAbsorber renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

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
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle _Handle { get; set; }
        public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform) { throw new NotImplementedException(); }


        public new bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result, double mainAxisPosition = default(double), double crossAxisPosition = default(double)) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

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
            this.Handle = handle; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Nestedscrollview.RenderSliverOverlapInjector CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Nestedscrollview.RenderSliverOverlapInjector renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

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
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual double _CurrentLayoutExtent { get; set; }
        internal virtual double _CurrentMaxExtent { get; set; }
        internal virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle _Handle { get; set; }
        public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

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
            this.Handle = handle; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Nestedscrollview.RenderNestedScrollViewViewport CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Nestedscrollview.RenderNestedScrollViewViewport renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

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
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle _Handle { get; set; }
        public virtual FlutterSDK.Widgets.Nestedscrollview.SliverOverlapAbsorberHandle Handle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void MarkNeedsLayout() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public enum _NestedBallisticScrollActivityMode
    {

        Outer,
        Inner,
        Independent,
    }

}
