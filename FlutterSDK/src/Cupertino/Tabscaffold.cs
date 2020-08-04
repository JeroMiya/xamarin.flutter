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
namespace FlutterSDK.Cupertino.Tabscaffold
{
    internal static class TabscaffoldDefaultClass
    {
    }

    /// <Summary>
    /// Coordinates tab selection between a [CupertinoTabBar] and a [CupertinoTabScaffold].
    ///
    /// The [index] property is the index of the selected tab. Changing its value
    /// updates the actively displayed tab of the [CupertinoTabScaffold] the
    /// [CupertinoTabController] controls, as well as the currently selected tab item of
    /// its [CupertinoTabBar].
    ///
    /// {@tool snippet}
    ///
    /// [CupertinoTabController] can be used to switch tabs:
    ///
    /// ```dart
    /// class MyCupertinoTabScaffoldPage extends StatefulWidget {
    ///   @override
    ///   _CupertinoTabScaffoldPageState createState() => _CupertinoTabScaffoldPageState();
    /// }
    ///
    /// class _CupertinoTabScaffoldPageState extends State<MyCupertinoTabScaffoldPage> {
    ///   final CupertinoTabController _controller = CupertinoTabController();
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return CupertinoTabScaffold(
    ///       tabBar: CupertinoTabBar(
    ///         items: <BottomNavigationBarItem> [
    ///           // ...
    ///         ],
    ///       ),
    ///       controller: _controller,
    ///       tabBuilder: (BuildContext context, int index) {
    ///         return Center(
    ///           child: CupertinoButton(
    ///             child: const Text('Go to first tab'),
    ///             onPressed: () => _controller.index = 0,
    ///           )
    ///         );
    ///       }
    ///     );
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     _controller.dispose();
    ///     super.dispose();
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [CupertinoTabScaffold], a tabbed application root layout that can be
    ///    controlled by a [CupertinoTabController].
    /// </Summary>
    public class CupertinoTabController : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
    {
        /// <Summary>
        /// Creates a [CupertinoTabController] to control the tab index of [CupertinoTabScaffold]
        /// and [CupertinoTabBar].
        ///
        /// The [initialIndex] must not be null and defaults to 0. The value must be
        /// greater than or equal to 0, and less than the total number of tabs.
        /// </Summary>
        public CupertinoTabController(int initialIndex = 0)
        : base()
        {

        }
        internal virtual bool _IsDisposed { get; set; }
        internal virtual int _Index { get; set; }
        public virtual int Index { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Dispose()
        {
            base.Dispose();
            _IsDisposed = true;
        }



    }


    /// <Summary>
    /// Implements a tabbed iOS application's root layout and behavior structure.
    ///
    /// The scaffold lays out the tab bar at the bottom and the content between or
    /// behind the tab bar.
    ///
    /// A [tabBar] and a [tabBuilder] are required. The [CupertinoTabScaffold]
    /// will automatically listen to the provided [CupertinoTabBar]'s tap callbacks
    /// to change the active tab.
    ///
    /// A [controller] can be used to provide an initially selected tab index and manage
    /// subsequent tab changes. If a controller is not specified, the scaffold will
    /// create its own [CupertinoTabController] and manage it internally. Otherwise
    /// it's up to the owner of [controller] to call `dispose` on it after finish
    /// using it.
    ///
    /// Tabs' contents are built with the provided [tabBuilder] at the active
    /// tab index. The [tabBuilder] must be able to build the same number of
    /// pages as there are [tabBar] items. Inactive tabs will be moved [Offstage]
    /// and their animations disabled.
    ///
    /// Adding/removing tabs, or changing the order of tabs is supported but not
    /// recommended. Doing so is against the iOS human interface guidelines, and
    /// [CupertinoTabScaffold] may lose some tabs' state in the process.
    ///
    /// Use [CupertinoTabView] as the root widget of each tab to support tabs with
    /// parallel navigation state and history. Since each [CupertinoTabView] contains
    /// a [Navigator], rebuilding the [CupertinoTabView] with a different
    /// [WidgetBuilder] instance in [CupertinoTabView.builder] will not recreate
    /// the [CupertinoTabView]'s navigation stack or update its UI. To update the
    /// contents of the [CupertinoTabView] after it's built, trigger a rebuild
    /// (via [State.setState], for instance) from its descendant rather than from
    /// its ancestor.
    ///
    /// {@tool snippet}
    ///
    /// A sample code implementing a typical iOS information architecture with tabs.
    ///
    /// ```dart
    /// CupertinoTabScaffold(
    ///   tabBar: CupertinoTabBar(
    ///     items: <BottomNavigationBarItem> [
    ///       // ...
    ///     ],
    ///   ),
    ///   tabBuilder: (BuildContext context, int index) {
    ///     return CupertinoTabView(
    ///       builder: (BuildContext context) {
    ///         return CupertinoPageScaffold(
    ///           navigationBar: CupertinoNavigationBar(
    ///             middle: Text('Page 1 of tab $index'),
    ///           ),
    ///           child: Center(
    ///             child: CupertinoButton(
    ///               child: const Text('Next page'),
    ///               onPressed: () {
    ///                 Navigator.of(context).push(
    ///                   CupertinoPageRoute<void>(
    ///                     builder: (BuildContext context) {
    ///                       return CupertinoPageScaffold(
    ///                         navigationBar: CupertinoNavigationBar(
    ///                           middle: Text('Page 2 of tab $index'),
    ///                         ),
    ///                         child: Center(
    ///                           child: CupertinoButton(
    ///                             child: const Text('Back'),
    ///                             onPressed: () { Navigator.of(context).pop(); },
    ///                           ),
    ///                         ),
    ///                       );
    ///                     },
    ///                   ),
    ///                 );
    ///               },
    ///             ),
    ///           ),
    ///         );
    ///       },
    ///     );
    ///   },
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// To push a route above all tabs instead of inside the currently selected one
    /// (such as when showing a dialog on top of this scaffold), use
    /// `Navigator.of(rootNavigator: true)` from inside the [BuildContext] of a
    /// [CupertinoTabView].
    ///
    /// See also:
    ///
    ///  * [CupertinoTabBar], the bottom tab bar inserted in the scaffold.
    ///  * [CupertinoTabController], the selection state of this widget
    ///  * [CupertinoTabView], the typical root content of each tab that holds its own
    ///    [Navigator] stack.
    ///  * [CupertinoPageRoute], a route hosting modal pages with iOS style transitions.
    ///  * [CupertinoPageScaffold], typical contents of an iOS modal page implementing
    ///    layout with a navigation bar on top.
    ///  * [iOS human interface guidelines](https://developer.apple.com/design/human-interface-guidelines/ios/bars/tab-bars/).
    /// </Summary>
    public class CupertinoTabScaffold : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a layout for applications with a tab bar at the bottom.
        ///
        /// The [tabBar] and [tabBuilder] arguments must not be null.
        /// </Summary>
        public CupertinoTabScaffold(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Cupertino.Bottomtabbar.CupertinoTabBar tabBar = default(FlutterSDK.Cupertino.Bottomtabbar.CupertinoTabBar), FlutterSDK.Widgets.Framework.IndexedWidgetBuilder tabBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder), FlutterSDK.Cupertino.Tabscaffold.CupertinoTabController controller = default(FlutterSDK.Cupertino.Tabscaffold.CupertinoTabController), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), bool resizeToAvoidBottomInset = true)
        : base(key: key)
        {
            this.TabBar = tabBar;
            this.TabBuilder = tabBuilder;
            this.Controller = controller;
            this.BackgroundColor = backgroundColor;
            this.ResizeToAvoidBottomInset = resizeToAvoidBottomInset;
        }
        /// <Summary>
        /// The [tabBar] is a [CupertinoTabBar] drawn at the bottom of the screen
        /// that lets the user switch between different tabs in the main content area
        /// when present.
        ///
        /// The [CupertinoTabBar.currentIndex] is only used to initialize a
        /// [CupertinoTabController] when no [controller] is provided. Subsequently
        /// providing a different [CupertinoTabBar.currentIndex] does not affect the
        /// scaffold or the tab bar's active tab index. To programmatically change
        /// the active tab index, use a [CupertinoTabController].
        ///
        /// If [CupertinoTabBar.onTap] is provided, it will still be called.
        /// [CupertinoTabScaffold] automatically also listen to the
        /// [CupertinoTabBar]'s `onTap` to change the [controller]'s `index`
        /// and change the actively displayed tab in [CupertinoTabScaffold]'s own
        /// main content area.
        ///
        /// If translucent, the main content may slide behind it.
        /// Otherwise, the main content's bottom margin will be offset by its height.
        ///
        /// By default `tabBar` has its text scale factor set to 1.0 and does not
        /// respond to text scale factor changes from the operating system, to match
        /// the native iOS behavior. To override this behavior, wrap each of the `tabBar`'s
        /// items inside a [MediaQuery] with the desired [MediaQueryData.textScaleFactor]
        /// value. The text scale factor value from the operating system can be retrieved
        /// int many ways, such as querying [MediaQuery.textScaleFactorOf] against
        /// [CupertinoApp]'s [BuildContext].
        ///
        /// Must not be null.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Bottomtabbar.CupertinoTabBar TabBar { get; set; }
        /// <Summary>
        /// Controls the currently selected tab index of the [tabBar], as well as the
        /// active tab index of the [tabBuilder]. Providing a different [controller]
        /// will also update the scaffold's current active index to the new controller's
        /// index value.
        ///
        /// Defaults to null.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Tabscaffold.CupertinoTabController Controller { get; set; }
        /// <Summary>
        /// An [IndexedWidgetBuilder] that's called when tabs become active.
        ///
        /// The widgets built by [IndexedWidgetBuilder] are typically a
        /// [CupertinoTabView] in order to achieve the parallel hierarchical
        /// information architecture seen on iOS apps with tab bars.
        ///
        /// When the tab becomes inactive, its content is cached in the widget tree
        /// [Offstage] and its animations disabled.
        ///
        /// Content can slide under the [tabBar] when they're translucent.
        /// In that case, the child's [BuildContext]'s [MediaQuery] will have a
        /// bottom padding indicating the area of obstructing overlap from the
        /// [tabBar].
        ///
        /// Must not be null.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.IndexedWidgetBuilder TabBuilder { get; set; }
        /// <Summary>
        /// The color of the widget that underlies the entire scaffold.
        ///
        /// By default uses [CupertinoTheme]'s `scaffoldBackgroundColor` when null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// Whether the body should size itself to avoid the window's bottom inset.
        ///
        /// For example, if there is an onscreen keyboard displayed above the
        /// scaffold, the body can be resized to avoid overlapping the keyboard, which
        /// prevents widgets inside the body from being obscured by the keyboard.
        ///
        /// Defaults to true and cannot be null.
        /// </Summary>
        public virtual bool ResizeToAvoidBottomInset { get; set; }

        public new FlutterSDK.Cupertino.Tabscaffold._CupertinoTabScaffoldState CreateState() => new _CupertinoTabScaffoldState();


    }


    public class _CupertinoTabScaffoldState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Tabscaffold.CupertinoTabScaffold>
    {
        public _CupertinoTabScaffoldState()
        { }
        internal virtual FlutterSDK.Cupertino.Tabscaffold.CupertinoTabController _Controller { get; set; }

        public new void InitState()
        {
            base.InitState();
            _UpdateTabController();
        }




        private void _UpdateTabController(bool shouldDisposeOldController = false)
        {
            CupertinoTabController newController = Widget.Controller ?? new CupertinoTabController(initialIndex: Widget.TabBar.CurrentIndex);
            if (newController == _Controller)
            {
                return;
            }

            if (shouldDisposeOldController)
            {
                _Controller?.Dispose();
            }
            else if (_Controller?._IsDisposed == false)
            {
                _Controller.RemoveListener(_OnCurrentIndexChange);
            }

            newController.AddListener(_OnCurrentIndexChange);
            _Controller = newController;
        }




        private void _OnCurrentIndexChange()
        {

            SetState(() =>
            {
            }
            );
        }




        public new void DidUpdateWidget(FlutterSDK.Cupertino.Tabscaffold.CupertinoTabScaffold oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Controller != oldWidget.Controller)
            {
                _UpdateTabController(shouldDisposeOldController: oldWidget.Controller == null);
            }
            else if (_Controller.Index >= Widget.TabBar.Items.Count)
            {
                _Controller.Index = Widget.TabBar.Items.Count - 1;
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            MediaQueryData existingMediaQuery = MediaqueryDefaultClass.MediaQuery.Of(context);
            MediaQueryData newMediaQuery = MediaqueryDefaultClass.MediaQuery.Of(context);
            Widget content = new _TabSwitchingView(currentTabIndex: _Controller.Index, tabCount: Widget.TabBar.Items.Count, tabBuilder: Widget.TabBuilder);
            EdgeInsets contentPadding = EdgeinsetsDefaultClass.EdgeInsets.Zero;
            if (Widget.ResizeToAvoidBottomInset)
            {
                newMediaQuery = newMediaQuery.RemoveViewInsets(removeBottom: true);
                contentPadding = EdgeInsets.Only(bottom: existingMediaQuery.ViewInsets.Bottom);
            }

            if (Widget.TabBar != null && (!Widget.ResizeToAvoidBottomInset || Widget.TabBar.PreferredSize.Height > existingMediaQuery.ViewInsets.Bottom))
            {
                double bottomPadding = Widget.TabBar.PreferredSize.Height + existingMediaQuery.Padding.Bottom;
                if (Widget.TabBar.Opaque(context))
                {
                    contentPadding = EdgeInsets.Only(bottom: bottomPadding);
                    newMediaQuery = newMediaQuery.RemovePadding(removeBottom: true);
                }
                else
                {
                    newMediaQuery = newMediaQuery.CopyWith(padding: newMediaQuery.Padding.CopyWith(bottom: bottomPadding));
                }

            }

            content = new MediaQuery(data: newMediaQuery, child: new Padding(padding: contentPadding, child: content));
            return new DecoratedBox(decoration: new BoxDecoration(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.BackgroundColor, context) ?? ThemeDefaultClass.CupertinoTheme.Of(context).ScaffoldBackgroundColor), child: new Stack(children: new List<Widget>(){content, new MediaQuery(data:existingMediaQuery.CopyWith(textScaleFactor:1), child:new Align(alignment:AlignmentDefaultClass.Alignment.BottomCenter, child:Widget.TabBar.CopyWith(currentIndex:_Controller.Index, onTap:(int newIndex) => {
_Controller.Index=newIndex;
if (Widget.TabBar.OnTap!=null )Widget.TabBar.OnTap(newIndex);
}
)))}));
        }




        public new void Dispose()
        {
            if (Widget.Controller == null)
            {
                _Controller?.Dispose();
            }
            else if (_Controller?._IsDisposed == false)
            {
                _Controller.RemoveListener(_OnCurrentIndexChange);
            }

            base.Dispose();
        }



    }


    /// <Summary>
    /// A widget laying out multiple tabs with only one active tab being built
    /// at a time and on stage. Off stage tabs' animations are stopped.
    /// </Summary>
    public class _TabSwitchingView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _TabSwitchingView(int currentTabIndex = default(int), int tabCount = default(int), FlutterSDK.Widgets.Framework.IndexedWidgetBuilder tabBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder))
        : base()
        {
            this.CurrentTabIndex = currentTabIndex;
            this.TabCount = tabCount;
            this.TabBuilder = tabBuilder;
        }
        public virtual int CurrentTabIndex { get; set; }
        public virtual int TabCount { get; set; }
        public virtual FlutterSDK.Widgets.Framework.IndexedWidgetBuilder TabBuilder { get; set; }

        public new FlutterSDK.Cupertino.Tabscaffold._TabSwitchingViewState CreateState() => new _TabSwitchingViewState();


    }


    public class _TabSwitchingViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Tabscaffold._TabSwitchingView>
    {
        public _TabSwitchingViewState()
        { }
        public virtual List<bool> ShouldBuildTab { get; set; }
        public virtual List<FlutterSDK.Widgets.Focusmanager.FocusScopeNode> TabFocusNodes { get; set; }
        public virtual List<FlutterSDK.Widgets.Focusmanager.FocusScopeNode> DiscardedNodes { get; set; }

        public new void InitState()
        {
            base.InitState();
            ShouldBuildTab.AddAll(List<bool>.Filled(Widget.TabCount, false));
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            _FocusActiveTab();
        }




        public new void DidUpdateWidget(FlutterSDK.Cupertino.Tabscaffold._TabSwitchingView oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            int lengthDiff = Widget.TabCount - ShouldBuildTab.Count;
            if (lengthDiff > 0)
            {
                ShouldBuildTab.AddAll(List<bool>.Filled(lengthDiff, false));
            }
            else if (lengthDiff < 0)
            {
                ShouldBuildTab.RemoveRange(Widget.TabCount, ShouldBuildTab.Count);
            }

            _FocusActiveTab();
        }




        private void _FocusActiveTab()
        {
            if (TabFocusNodes.Count != Widget.TabCount)
            {
                if (TabFocusNodes.Count > Widget.TabCount)
                {
                    DiscardedNodes.AddAll(TabFocusNodes.Sublist(Widget.TabCount));
                    TabFocusNodes.RemoveRange(Widget.TabCount, TabFocusNodes.Count);
                }
                else
                {
                    TabFocusNodes.AddAll(List<FocusScopeNode>.Generate(Widget.TabCount - TabFocusNodes.Count, (int index) => =>new FocusScopeNode(debugLabel: $"'{TabscaffoldDefaultClass.CupertinoTabScaffold} Tab {index + TabFocusNodes.Count}'")));
                }

            }

            FocusscopeDefaultClass.FocusScope.Of(Context).SetFirstFocus(TabFocusNodes[Widget.CurrentTabIndex]);
        }




        public new void Dispose()
        {
            foreach (FocusScopeNode focusScopeNode in TabFocusNodes)
            {
                focusScopeNode.Dispose();
            }

            foreach (FocusScopeNode focusScopeNode in DiscardedNodes)
            {
                focusScopeNode.Dispose();
            }

            base.Dispose();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Stack(fit: StackFit.Expand, children: List<Widget>.Generate(Widget.TabCount, (int index) =>
            {
                bool active = index == Widget.CurrentTabIndex;
                ShouldBuildTab[index] = active || ShouldBuildTab[index];
                return new Offstage(offstage: !active, child: new TickerMode(enabled: active, child: new FocusScope(node: TabFocusNodes[index], child: new Builder(builder: (BuildContext context) =>
                {
                    return ShouldBuildTab[index] ? Widget.TabBuilder(context, index) : new Container();
                }
                ))));
            }
            ));
        }



    }

}
