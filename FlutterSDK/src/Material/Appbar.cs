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
namespace FlutterSDK.Material.Appbar
{
    internal static class AppbarDefaultClass
    {
        public static double _KLeadingWidth = default(double);
    }

    public class _ToolbarContainerLayout : FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate
    {
        public _ToolbarContainerLayout()
        {

        }

        public new FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            return constraints.Tighten(height: ConstantsDefaultClass.KToolbarHeight);
        }




        public new Size GetSize(FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            return new Size(constraints.MaxWidth, ConstantsDefaultClass.KToolbarHeight);
        }




        public new Offset GetPositionForChild(Size size, Size childSize)
        {
            return new Offset(0.0, size.Height - childSize.Height);
        }




        public new bool ShouldRelayout(FlutterSDK.Material.Appbar._ToolbarContainerLayout oldDelegate) => false;

        public new bool ShouldRelayout(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate oldDelegate) => false;


    }


    /// <Summary>
    /// A material design app bar.
    ///
    /// An app bar consists of a toolbar and potentially other widgets, such as a
    /// [TabBar] and a [FlexibleSpaceBar]. App bars typically expose one or more
    /// common [actions] with [IconButton]s which are optionally followed by a
    /// [PopupMenuButton] for less common operations (sometimes called the "overflow
    /// menu").
    ///
    /// App bars are typically used in the [Scaffold.appBar] property, which places
    /// the app bar as a fixed-height widget at the top of the screen. For a scrollable
    /// app bar, see [SliverAppBar], which embeds an [AppBar] in a sliver for use in
    /// a [CustomScrollView].
    ///
    /// When not used as [Scaffold.appBar], or when wrapped in a [Hero], place the app
    /// bar in a [MediaQuery] to take care of the padding around the content of the
    /// app bar if needed, as the padding will not be handled by [Scaffold].
    ///
    /// The AppBar displays the toolbar widgets, [leading], [title], and [actions],
    /// above the [bottom] (if any). The [bottom] is usually used for a [TabBar]. If
    /// a [flexibleSpace] widget is specified then it is stacked behind the toolbar
    /// and the bottom widget. The following diagram shows where each of these slots
    /// appears in the toolbar when the writing language is left-to-right (e.g.
    /// English):
    ///
    /// ![The leading widget is in the top left, the actions are in the top right,
    /// the title is between them. The bottom is, naturally, at the bottom, and the
    /// flexibleSpace is behind all of them.](https://flutter.github.io/assets-for-api-docs/assets/material/app_bar.png)
    ///
    /// If the [leading] widget is omitted, but the [AppBar] is in a [Scaffold] with
    /// a [Drawer], then a button will be inserted to open the drawer. Otherwise, if
    /// the nearest [Navigator] has any previous routes, a [BackButton] is inserted
    /// instead. This behavior can be turned off by setting the [automaticallyImplyLeading]
    /// to false. In that case a null leading widget will result in the middle/title widget
    /// stretching to start.
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    ///
    /// This sample shows an [AppBar] with two simple actions. The first action
    /// opens a [SnackBar], while the second action navigates to a new page.
    ///
    /// ```dart preamble
    /// final GlobalKey<ScaffoldState> scaffoldKey = GlobalKey<ScaffoldState>();
    /// final SnackBar snackBar = const SnackBar(content: Text('Showing Snackbar'));
    ///
    /// void openPage(BuildContext context) {
    ///   Navigator.push(context, MaterialPageRoute(
    ///     builder: (BuildContext context) {
    ///       return Scaffold(
    ///         appBar: AppBar(
    ///           title: const Text('Next page'),
    ///         ),
    ///         body: const Center(
    ///           child: Text(
    ///             'This is the next page',
    ///             style: TextStyle(fontSize: 24),
    ///           ),
    ///         ),
    ///       );
    ///     },
    ///   ));
    /// }
    /// ```
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     key: scaffoldKey,
    ///     appBar: AppBar(
    ///       title: const Text('AppBar Demo'),
    ///       actions: <Widget>[
    ///         IconButton(
    ///           icon: const Icon(Icons.add_alert),
    ///           tooltip: 'Show Snackbar',
    ///           onPressed: () {
    ///             scaffoldKey.currentState.showSnackBar(snackBar);
    ///           },
    ///         ),
    ///         IconButton(
    ///           icon: const Icon(Icons.navigate_next),
    ///           tooltip: 'Next page',
    ///           onPressed: () {
    ///             openPage(context);
    ///           },
    ///         ),
    ///       ],
    ///     ),
    ///     body: const Center(
    ///       child: Text(
    ///         'This is the home page',
    ///         style: TextStyle(fontSize: 24),
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Scaffold], which displays the [AppBar] in its [Scaffold.appBar] slot.
    ///  * [SliverAppBar], which uses [AppBar] to provide a flexible app bar that
    ///    can be used in a [CustomScrollView].
    ///  * [TabBar], which is typically placed in the [bottom] slot of the [AppBar]
    ///    if the screen has multiple pages arranged in tabs.
    ///  * [IconButton], which is used with [actions] to show buttons on the app bar.
    ///  * [PopupMenuButton], to show a popup menu on the app bar, via [actions].
    ///  * [FlexibleSpaceBar], which is used with [flexibleSpace] when the app bar
    ///    can expand and collapse.
    ///  * <https://material.io/design/components/app-bars-top.html>
    /// </Summary>
    public class AppBar : FlutterSDK.Widgets.Framework.StatefulWidget, IPreferredSizeWidget
    {
        /// <Summary>
        /// Creates a material design app bar.
        ///
        /// The arguments [primary], [toolbarOpacity], [bottomOpacity]
        /// and [automaticallyImplyLeading] must not be null. Additionally, if
        /// [elevation] is specified, it must be non-negative.
        ///
        /// If [backgroundColor], [elevation], [brightness], [iconTheme],
        /// [actionsIconTheme], or [textTheme] are null, then their [AppBarTheme]
        /// values will be used. If the corresponding [AppBarTheme] property is null,
        /// then the default specified in the property's documentation will be used.
        ///
        /// Typically used in the [Scaffold.appBar] property.
        /// </Summary>
        public AppBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), bool automaticallyImplyLeading = true, FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget flexibleSpace = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget bottom = default(FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget), double elevation = default(double), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData actionsIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), bool primary = true, bool centerTitle = default(bool), bool excludeHeaderSemantics = false, double titleSpacing = default(double), double toolbarOpacity = 1.0, double bottomOpacity = 1.0)
        : base(key: key)
        {
            this.Leading = leading;
            this.AutomaticallyImplyLeading = automaticallyImplyLeading;
            this.Title = title;
            this.Actions = actions;
            this.FlexibleSpace = flexibleSpace;
            this.Bottom = bottom;
            this.Elevation = elevation;
            this.Shape = shape;
            this.BackgroundColor = backgroundColor;
            this.Brightness = brightness;
            this.IconTheme = iconTheme;
            this.ActionsIconTheme = actionsIconTheme;
            this.TextTheme = textTheme;
            this.Primary = primary;
            this.CenterTitle = centerTitle;
            this.ExcludeHeaderSemantics = excludeHeaderSemantics;
            this.TitleSpacing = titleSpacing;
            this.ToolbarOpacity = toolbarOpacity;
            this.BottomOpacity = bottomOpacity;
        }
        /// <Summary>
        /// A widget to display before the [title].
        ///
        /// Typically the [leading] widget is an [Icon] or an [IconButton].
        ///
        /// Becomes the leading component of the [NavigationToolBar] built
        /// by this widget. The [leading] widget's width and height are constrained to
        /// be no bigger than toolbar's height, which is [kToolbarHeight].
        ///
        /// If this is null and [automaticallyImplyLeading] is set to true, the
        /// [AppBar] will imply an appropriate widget. For example, if the [AppBar] is
        /// in a [Scaffold] that also has a [Drawer], the [Scaffold] will fill this
        /// widget with an [IconButton] that opens the drawer (using [Icons.menu]). If
        /// there's no [Drawer] and the parent [Navigator] can go back, the [AppBar]
        /// will use a [BackButton] that calls [Navigator.maybePop].
        ///
        /// {@tool snippet}
        ///
        /// The following code shows how the drawer button could be manually specified
        /// instead of relying on [automaticallyImplyLeading]:
        ///
        /// ```dart
        /// AppBar(
        ///   leading: Builder(
        ///     builder: (BuildContext context) {
        ///       return IconButton(
        ///         icon: const Icon(Icons.menu),
        ///         onPressed: () { Scaffold.of(context).openDrawer(); },
        ///         tooltip: MaterialLocalizations.of(context).openAppDrawerTooltip,
        ///       );
        ///     },
        ///   ),
        /// )
        /// ```
        /// {@end-tool}
        ///
        /// The [Builder] is used in this example to ensure that the `context` refers
        /// to that part of the subtree. That way this code snippet can be used even
        /// inside the very code that is creating the [Scaffold] (in which case,
        /// without the [Builder], the `context` wouldn't be able to see the
        /// [Scaffold], since it would refer to an ancestor of that widget).
        ///
        /// See also:
        ///
        ///  * [Scaffold.appBar], in which an [AppBar] is usually placed.
        ///  * [Scaffold.drawer], in which the [Drawer] is usually placed.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Leading { get; set; }
        /// <Summary>
        /// Controls whether we should try to imply the leading widget if null.
        ///
        /// If true and [leading] is null, automatically try to deduce what the leading
        /// widget should be. If false and [leading] is null, leading space is given to [title].
        /// If leading widget is not null, this parameter has no effect.
        /// </Summary>
        public virtual bool AutomaticallyImplyLeading { get; set; }
        /// <Summary>
        /// The primary widget displayed in the app bar.
        ///
        /// Typically a [Text] widget that contains a description of the current
        /// contents of the app.
        ///
        /// Becomes the middle component of the [NavigationToolBar] built by this widget.
        /// The [title]'s width is constrained to fit within the remaining space
        /// between the toolbar's [leading] and [actions] widgets. Its height is
        /// _not_ constrained. The [title] is vertically centered and clipped to fit
        /// within the toolbar, whose height is [kToolbarHeight]. Typically this
        /// isn't noticeable because a simple [Text] [title] will fit within the
        /// toolbar by default. On the other hand, it is noticeable when a
        /// widget with an intrinsic height that is greater than [kToolbarHeight]
        /// is used as the [title]. For example, when the height of an Image used
        /// as the [title] exceeds [kToolbarHeight], it will be centered and
        /// clipped (top and bottom), which may be undesirable. In cases like this
        /// the height of the [title] widget can be constrained. For example:
        ///
        /// ```dart
        /// MaterialApp(
        ///   home: Scaffold(
        ///     appBar: AppBar(
        ///        title: SizedBox(
        ///        height: kToolbarHeight,
        ///          child: child: Image.asset(logoAsset),
        ///      ),
        ///   ),
        /// )
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        /// <Summary>
        /// Widgets to display in a row after the [title] widget.
        ///
        /// Typically these widgets are [IconButton]s representing common operations.
        /// For less common operations, consider using a [PopupMenuButton] as the
        /// last action.
        ///
        /// The [actions] become the trailing component of the [NavigationToolBar] built
        /// by this widget. The height of each action is constrained to be no bigger
        /// than the toolbar's height, which is [kToolbarHeight].
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        /// <Summary>
        /// This widget is stacked behind the toolbar and the tab bar. It's height will
        /// be the same as the app bar's overall height.
        ///
        /// A flexible space isn't actually flexible unless the [AppBar]'s container
        /// changes the [AppBar]'s size. A [SliverAppBar] in a [CustomScrollView]
        /// changes the [AppBar]'s height when scrolled.
        ///
        /// Typically a [FlexibleSpaceBar]. See [FlexibleSpaceBar] for details.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget FlexibleSpace { get; set; }
        /// <Summary>
        /// This widget appears across the bottom of the app bar.
        ///
        /// Typically a [TabBar]. Only widgets that implement [PreferredSizeWidget] can
        /// be used at the bottom of an app bar.
        ///
        /// See also:
        ///
        ///  * [PreferredSize], which can be used to give an arbitrary widget a preferred size.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget Bottom { get; set; }
        /// <Summary>
        /// The z-coordinate at which to place this app bar relative to its parent.
        ///
        /// This controls the size of the shadow below the app bar.
        ///
        /// The value is non-negative.
        ///
        /// If this property is null, then [ThemeData.appBarTheme.elevation] is used,
        /// if that is also null, the default value is 4, the appropriate elevation
        /// for app bars.
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// The material's shape as well its shadow.
        ///
        /// A shadow is only displayed if the [elevation] is greater than
        /// zero.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        /// <Summary>
        /// The color to use for the app bar's material. Typically this should be set
        /// along with [brightness], [iconTheme], [textTheme].
        ///
        /// If this property is null, then [ThemeData.appBarTheme.color] is used,
        /// if that is also null, then [ThemeData.primaryColor] is used.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// The brightness of the app bar's material. Typically this is set along
        /// with [backgroundColor], [iconTheme], [textTheme].
        ///
        /// If this property is null, then [ThemeData.appBarTheme.brightness] is used,
        /// if that is also null, then [ThemeData.primaryColorBrightness] is used.
        /// </Summary>
        public virtual Brightness Brightness { get; set; }
        /// <Summary>
        /// The color, opacity, and size to use for app bar icons. Typically this
        /// is set along with [backgroundColor], [brightness], [textTheme].
        ///
        /// If this property is null, then [ThemeData.appBarTheme.iconTheme] is used,
        /// if that is also null, then [ThemeData.primaryIconTheme] is used.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData IconTheme { get; set; }
        /// <Summary>
        /// The color, opacity, and size to use for the icons that appear in the app
        /// bar's [actions]. This should only be used when the [actions] should be
        /// themed differently than the icon that appears in the app bar's [leading]
        /// widget.
        ///
        /// If this property is null, then [ThemeData.appBarTheme.actionsIconTheme] is
        /// used, if that is also null, then this falls back to [iconTheme].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData ActionsIconTheme { get; set; }
        /// <Summary>
        /// The typographic styles to use for text in the app bar. Typically this is
        /// set along with [brightness] [backgroundColor], [iconTheme].
        ///
        /// If this property is null, then [ThemeData.appBarTheme.textTheme] is used,
        /// if that is also null, then [ThemeData.primaryTextTheme] is used.
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme TextTheme { get; set; }
        /// <Summary>
        /// Whether this app bar is being displayed at the top of the screen.
        ///
        /// If true, the app bar's toolbar elements and [bottom] widget will be
        /// padded on top by the height of the system status bar. The layout
        /// of the [flexibleSpace] is not affected by the [primary] property.
        /// </Summary>
        public virtual bool Primary { get; set; }
        /// <Summary>
        /// Whether the title should be centered.
        ///
        /// Defaults to being adapted to the current [TargetPlatform].
        /// </Summary>
        public virtual bool CenterTitle { get; set; }
        /// <Summary>
        /// Whether the title should be wrapped with header [Semantics].
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool ExcludeHeaderSemantics { get; set; }
        /// <Summary>
        /// The spacing around [title] content on the horizontal axis. This spacing is
        /// applied even if there is no [leading] content or [actions]. If you want
        /// [title] to take all the space available, set this value to 0.0.
        ///
        /// Defaults to [NavigationToolbar.kMiddleSpacing].
        /// </Summary>
        public virtual double TitleSpacing { get; set; }
        /// <Summary>
        /// How opaque the toolbar part of the app bar is.
        ///
        /// A value of 1.0 is fully opaque, and a value of 0.0 is fully transparent.
        ///
        /// Typically, this value is not changed from its default value (1.0). It is
        /// used by [SliverAppBar] to animate the opacity of the toolbar when the app
        /// bar is scrolled.
        /// </Summary>
        public virtual double ToolbarOpacity { get; set; }
        /// <Summary>
        /// How opaque the bottom part of the app bar is.
        ///
        /// A value of 1.0 is fully opaque, and a value of 0.0 is fully transparent.
        ///
        /// Typically, this value is not changed from its default value (1.0). It is
        /// used by [SliverAppBar] to animate the opacity of the toolbar when the app
        /// bar is scrolled.
        /// </Summary>
        public virtual double BottomOpacity { get; set; }
        /// <Summary>
        /// A size whose height is the sum of [kToolbarHeight] and the [bottom] widget's
        /// preferred height.
        ///
        /// [Scaffold] uses this size to set its app bar's height.
        /// </Summary>
        public new Size PreferredSize { get; set; }

        private bool _GetEffectiveCenterTitle(FlutterSDK.Material.Themedata.ThemeData theme)
        {
            if (CenterTitle != null) return CenterTitle;

            switch (theme.Platform) { case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: return false; case TargetPlatform.IOS: case TargetPlatform.MacOS: return Actions == null || Actions.Count < 2; }
            return null;
        }




        public new FlutterSDK.Material.Appbar._AppBarState CreateState() => new _AppBarState();


    }


    public class _AppBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Appbar.AppBar>
    {
        public _AppBarState()
        { }
        internal virtual double _DefaultElevation { get; set; }

        private void _HandleDrawerButton()
        {
            ScaffoldDefaultClass.Scaffold.Of(Context).OpenDrawer();
        }




        private void _HandleDrawerButtonEnd()
        {
            ScaffoldDefaultClass.Scaffold.Of(Context).OpenEndDrawer();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {


            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            AppBarTheme appBarTheme = AppbarthemeDefaultClass.AppBarTheme.Of(context);
            ScaffoldState scaffold = ScaffoldDefaultClass.Scaffold.Of(context, nullOk: true);
            ModalRoute<object> parentRoute = RoutesDefaultClass.ModalRoute.Of(context);
            bool hasDrawer = scaffold?.HasDrawer ?? false;
            bool hasEndDrawer = scaffold?.HasEndDrawer ?? false;
            bool canPop = parentRoute?.CanPop ?? false;
            bool useCloseButton = parentRoute is PageRoute<object> && parentRoute.FullscreenDialog;
            IconThemeData overallIconTheme = Widget.IconTheme ?? appBarTheme.IconTheme ?? theme.PrimaryIconTheme;
            IconThemeData actionsIconTheme = Widget.ActionsIconTheme ?? appBarTheme.ActionsIconTheme ?? overallIconTheme;
            TextStyle centerStyle = Widget.TextTheme?.Headline6 ?? appBarTheme.TextTheme?.Headline6 ?? theme.PrimaryTextTheme.Headline6;
            TextStyle sideStyle = Widget.TextTheme?.BodyText2 ?? appBarTheme.TextTheme?.BodyText2 ?? theme.PrimaryTextTheme.BodyText2;
            if (Widget.ToolbarOpacity != 1.0)
            {
                double opacity = new Interval(0.25, 1.0, curve: CurvesDefaultClass.Curves.FastOutSlowIn).Transform(Widget.ToolbarOpacity);
                if (centerStyle?.Color != null) centerStyle = centerStyle.CopyWith(color: centerStyle.Color.WithOpacity(opacity));
                if (sideStyle?.Color != null) sideStyle = sideStyle.CopyWith(color: sideStyle.Color.WithOpacity(opacity));
                overallIconTheme = overallIconTheme.CopyWith(opacity: opacity * (overallIconTheme.Opacity ?? 1.0));
                actionsIconTheme = actionsIconTheme.CopyWith(opacity: opacity * (actionsIconTheme.Opacity ?? 1.0));
            }

            Widget leading = Widget.Leading;
            if (leading == null && Widget.AutomaticallyImplyLeading)
            {
                if (hasDrawer)
                {
                    leading = new IconButton(icon: new Icon(IconsDefaultClass.Icons.Menu), onPressed: _HandleDrawerButton, tooltip: MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).OpenAppDrawerTooltip);
                }
                else
                {
                    if (canPop) leading = useCloseButton ? new CloseButton() : new BackButton();
                }

            }

            if (leading != null)
            {
                leading = new ConstrainedBox(constraints: BoxConstraints.TightFor(width: AppbarDefaultClass._KLeadingWidth), child: leading);
            }

            Widget title = Widget.Title;
            if (title != null)
            {
                bool namesRoute = default(bool);
                switch (theme.Platform) { case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: namesRoute = true; break; case TargetPlatform.IOS: case TargetPlatform.MacOS: break; }
                title = new _AppBarTitleBox(child: title);
                if (!Widget.ExcludeHeaderSemantics)
                {
                    title = new Semantics(namesRoute: namesRoute, child: title, header: true);
                }

                title = new DefaultTextStyle(style: centerStyle, softWrap: false, overflow: TextOverflow.Ellipsis, child: title);
            }

            Widget actions = default(Widget);
            if (Widget.Actions != null && Widget.Actions.IsNotEmpty)
            {
                actions = new Row(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: Widget.Actions);
            }
            else if (hasEndDrawer)
            {
                actions = new IconButton(icon: new Icon(IconsDefaultClass.Icons.Menu), onPressed: _HandleDrawerButtonEnd, tooltip: MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).OpenAppDrawerTooltip);
            }

            if (actions != null)
            {
                actions = IconthemeDefaultClass.IconTheme.Merge(data: actionsIconTheme, child: actions);
            }

            Widget toolbar = new NavigationToolbar(leading: leading, middle: title, trailing: actions, centerMiddle: Widget._GetEffectiveCenterTitle(theme), middleSpacing: Widget.TitleSpacing);
            Widget appBar = new ClipRect(child: new CustomSingleChildLayout(@delegate: new _ToolbarContainerLayout(), child: IconthemeDefaultClass.IconTheme.Merge(data: overallIconTheme, child: new DefaultTextStyle(style: sideStyle, child: toolbar))));
            if (Widget.Bottom != null)
            {
                appBar = new Column(mainAxisAlignment: MainAxisAlignment.SpaceBetween, children: new List<Widget>() { new Flexible(child: new ConstrainedBox(constraints: new BoxConstraints(maxHeight: ConstantsDefaultClass.KToolbarHeight), child: appBar)) });
            }

            if (Widget.Primary)
            {
                appBar = new SafeArea(bottom: false, top: true, child: appBar);
            }

            appBar = new Align(alignment: AlignmentDefaultClass.Alignment.TopCenter, child: appBar);
            if (Widget.FlexibleSpace != null)
            {
                appBar = new Stack(fit: StackFit.Passthrough, children: new List<Widget>() { Widget.FlexibleSpace, appBar });
            }

            Brightness brightness = Widget.Brightness ?? appBarTheme.Brightness ?? theme.PrimaryColorBrightness;
            SystemUiOverlayStyle overlayStyle = brightness == Brightness.Dark ? SystemchromeDefaultClass.SystemUiOverlayStyle.Light : SystemchromeDefaultClass.SystemUiOverlayStyle.Dark;
            return new Semantics(container: true, child: new AnnotatedRegion<SystemUiOverlayStyle>(value: overlayStyle, child: new Material(color: Widget.BackgroundColor ?? appBarTheme.Color ?? theme.PrimaryColor, elevation: Widget.Elevation ?? appBarTheme.Elevation ?? _DefaultElevation, shape: Widget.Shape, child: new Semantics(explicitChildNodes: true, child: appBar))));
        }



    }


    public class _FloatingAppBar : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _FloatingAppBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Material.Appbar._FloatingAppBarState CreateState() => new _FloatingAppBarState();


    }


    public class _FloatingAppBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Appbar._FloatingAppBar>
    {
        public _FloatingAppBarState()
        { }
        internal virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition _Position { get; set; }

        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            if (_Position != null) _Position.IsScrollingNotifier.RemoveListener(_IsScrollingListener);
            _Position = ScrollableDefaultClass.Scrollable.Of(Context)?.Position;
            if (_Position != null) _Position.IsScrollingNotifier.AddListener(_IsScrollingListener);
        }




        public new void Dispose()
        {
            if (_Position != null) _Position.IsScrollingNotifier.RemoveListener(_IsScrollingListener);
            base.Dispose();
        }




        private FlutterSDK.Rendering.Sliverpersistentheader.RenderSliverFloatingPersistentHeader _HeaderRenderer()
        {
            return Context.FindAncestorRenderObjectOfType();
        }




        private void _IsScrollingListener()
        {
            if (_Position == null) return;
            RenderSliverFloatingPersistentHeader header = _HeaderRenderer();
            if (_Position.IsScrollingNotifier.Value) header?.MaybeStopSnapAnimation(_Position.UserScrollDirection); else header?.MaybeStartSnapAnimation(_Position.UserScrollDirection);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) => Widget.Child;


    }


    public class _SliverAppBarDelegate : FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate
    {
        public _SliverAppBarDelegate(FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), bool automaticallyImplyLeading = default(bool), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget flexibleSpace = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget bottom = default(FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget), double elevation = default(double), bool forceElevated = default(bool), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData actionsIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), bool primary = default(bool), bool centerTitle = default(bool), bool excludeHeaderSemantics = default(bool), double titleSpacing = default(double), double expandedHeight = default(double), double collapsedHeight = default(double), double topPadding = default(double), bool floating = default(bool), bool pinned = default(bool), FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration snapConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base()
        {
            this.Leading = leading;
            this.AutomaticallyImplyLeading = automaticallyImplyLeading;
            this.Title = title;
            this.Actions = actions;
            this.FlexibleSpace = flexibleSpace;
            this.Bottom = bottom;
            this.Elevation = elevation;
            this.ForceElevated = forceElevated;
            this.BackgroundColor = backgroundColor;
            this.Brightness = brightness;
            this.IconTheme = iconTheme;
            this.ActionsIconTheme = actionsIconTheme;
            this.TextTheme = textTheme;
            this.Primary = primary;
            this.CenterTitle = centerTitle;
            this.ExcludeHeaderSemantics = excludeHeaderSemantics;
            this.TitleSpacing = titleSpacing;
            this.ExpandedHeight = expandedHeight;
            this.CollapsedHeight = collapsedHeight;
            this.TopPadding = topPadding;
            this.Floating = floating;
            this.Pinned = pinned;
            this.SnapConfiguration = snapConfiguration;
            this.StretchConfiguration = stretchConfiguration;
            this.Shape = shape;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Leading { get; set; }
        public virtual bool AutomaticallyImplyLeading { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget FlexibleSpace { get; set; }
        public virtual FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget Bottom { get; set; }
        public virtual double Elevation { get; set; }
        public virtual bool ForceElevated { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual Brightness Brightness { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData IconTheme { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData ActionsIconTheme { get; set; }
        public virtual FlutterSDK.Material.Texttheme.TextTheme TextTheme { get; set; }
        public virtual bool Primary { get; set; }
        public virtual bool CenterTitle { get; set; }
        public virtual bool ExcludeHeaderSemantics { get; set; }
        public virtual double TitleSpacing { get; set; }
        public virtual double ExpandedHeight { get; set; }
        public virtual double CollapsedHeight { get; set; }
        public virtual double TopPadding { get; set; }
        public virtual bool Floating { get; set; }
        public virtual bool Pinned { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        internal virtual double _BottomHeight { get; set; }
        public new FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration SnapConfiguration { get; set; }
        public new FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration StretchConfiguration { get; set; }
        public virtual double MinExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MaxExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, double shrinkOffset, bool overlapsContent)
        {
            double visibleMainHeight = MaxExtent - shrinkOffset - TopPadding;
            double toolbarOpacity = !Pinned || (Floating && Bottom != null) ? ((visibleMainHeight - _BottomHeight) / ConstantsDefaultClass.KToolbarHeight).Clamp(0.0, 1.0) as double : 1.0;
            Widget appBar = FlexiblespacebarDefaultClass.FlexibleSpaceBar.CreateSettings(minExtent: MinExtent, maxExtent: MaxExtent, currentExtent: Dart.Math.MathDefaultClass.Max(MinExtent, MaxExtent - shrinkOffset), toolbarOpacity: toolbarOpacity, child: new AppBar(leading: Leading, automaticallyImplyLeading: AutomaticallyImplyLeading, title: Title, actions: Actions, flexibleSpace: (Title == null && FlexibleSpace != null && !ExcludeHeaderSemantics) ? new Semantics(child: FlexibleSpace, header: true) : FlexibleSpace, bottom: Bottom, elevation: ForceElevated || overlapsContent || (Pinned && shrinkOffset > MaxExtent - MinExtent) ? elevation == default(double) ? 4.0 : elevation : 0.0, backgroundColor: BackgroundColor, brightness: Brightness, iconTheme: IconTheme, actionsIconTheme: ActionsIconTheme, textTheme: TextTheme, primary: Primary, centerTitle: CenterTitle, excludeHeaderSemantics: ExcludeHeaderSemantics, titleSpacing: TitleSpacing, shape: Shape, toolbarOpacity: toolbarOpacity, bottomOpacity: Pinned ? 1.0 : ((visibleMainHeight / _BottomHeight).Clamp(0.0, 1.0) as double)));
            return Floating ? new _FloatingAppBar(child: appBar) : appBar;
        }




        public new bool ShouldRebuild(FlutterSDK.Material.Appbar._SliverAppBarDelegate oldDelegate)
        {
            return Leading != oldDelegate.Leading || AutomaticallyImplyLeading != oldDelegate.AutomaticallyImplyLeading || Title != oldDelegate.Title || Actions != oldDelegate.Actions || FlexibleSpace != oldDelegate.FlexibleSpace || Bottom != oldDelegate.Bottom || _BottomHeight != oldDelegate._BottomHeight || Elevation != oldDelegate.Elevation || BackgroundColor != oldDelegate.BackgroundColor || Brightness != oldDelegate.Brightness || IconTheme != oldDelegate.IconTheme || ActionsIconTheme != oldDelegate.ActionsIconTheme || TextTheme != oldDelegate.TextTheme || Primary != oldDelegate.Primary || CenterTitle != oldDelegate.CenterTitle || TitleSpacing != oldDelegate.TitleSpacing || ExpandedHeight != oldDelegate.ExpandedHeight || TopPadding != oldDelegate.TopPadding || Pinned != oldDelegate.Pinned || Floating != oldDelegate.Floating || SnapConfiguration != oldDelegate.SnapConfiguration || StretchConfiguration != oldDelegate.StretchConfiguration;
        }


        public new bool ShouldRebuild(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate oldDelegate)
        {
            return Leading != oldDelegate.Leading || AutomaticallyImplyLeading != oldDelegate.AutomaticallyImplyLeading || Title != oldDelegate.Title || Actions != oldDelegate.Actions || FlexibleSpace != oldDelegate.FlexibleSpace || Bottom != oldDelegate.Bottom || _BottomHeight != oldDelegate._BottomHeight || Elevation != oldDelegate.Elevation || BackgroundColor != oldDelegate.BackgroundColor || Brightness != oldDelegate.Brightness || IconTheme != oldDelegate.IconTheme || ActionsIconTheme != oldDelegate.ActionsIconTheme || TextTheme != oldDelegate.TextTheme || Primary != oldDelegate.Primary || CenterTitle != oldDelegate.CenterTitle || TitleSpacing != oldDelegate.TitleSpacing || ExpandedHeight != oldDelegate.ExpandedHeight || TopPadding != oldDelegate.TopPadding || Pinned != oldDelegate.Pinned || Floating != oldDelegate.Floating || SnapConfiguration != oldDelegate.SnapConfiguration || StretchConfiguration != oldDelegate.StretchConfiguration;
        }




    }


    /// <Summary>
    /// A material design app bar that integrates with a [CustomScrollView].
    ///
    /// An app bar consists of a toolbar and potentially other widgets, such as a
    /// [TabBar] and a [FlexibleSpaceBar]. App bars typically expose one or more
    /// common actions with [IconButton]s which are optionally followed by a
    /// [PopupMenuButton] for less common operations.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=R9C5KMJKluE}
    ///
    /// Sliver app bars are typically used as the first child of a
    /// [CustomScrollView], which lets the app bar integrate with the scroll view so
    /// that it can vary in height according to the scroll offset or float above the
    /// other content in the scroll view. For a fixed-height app bar at the top of
    /// the screen see [AppBar], which is used in the [Scaffold.appBar] slot.
    ///
    /// The AppBar displays the toolbar widgets, [leading], [title], and
    /// [actions], above the [bottom] (if any). If a [flexibleSpace] widget is
    /// specified then it is stacked behind the toolbar and the bottom widget.
    ///
    /// {@tool snippet}
    ///
    /// This is an example that could be included in a [CustomScrollView]'s
    /// [CustomScrollView.slivers] list:
    ///
    /// ```dart
    /// SliverAppBar(
    ///   expandedHeight: 150.0,
    ///   flexibleSpace: const FlexibleSpaceBar(
    ///     title: Text('Available seats'),
    ///   ),
    ///   actions: <Widget>[
    ///     IconButton(
    ///       icon: const Icon(Icons.add_circle),
    ///       tooltip: 'Add new entry',
    ///       onPressed: () { /* ... */ },
    ///     ),
    ///   ]
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ## Animated Examples
    ///
    /// The following animations show how app bars with different configurations
    /// behave when a user scrolls up and then down again.
    ///
    /// * App bar with [floating]: false, [pinned]: false, [snap]: false:
    ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar.mp4}
    ///
    /// * App bar with [floating]: true, [pinned]: false, [snap]: false:
    ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar_floating.mp4}
    ///
    /// * App bar with [floating]: true, [pinned]: false, [snap]: true:
    ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar_floating_snap.mp4}
    ///
    /// * App bar with [floating]: true, [pinned]: true, [snap]: false:
    ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar_pinned_floating.mp4}
    ///
    /// * App bar with [floating]: true, [pinned]: true, [snap]: true:
    ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar_pinned_floating_snap.mp4}
    ///
    /// * App bar with [floating]: false, [pinned]: true, [snap]: false:
    ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar_pinned.mp4}
    ///
    /// The property [snap] can only be set to true if [floating] is also true.
    ///
    /// See also:
    ///
    ///  * [CustomScrollView], which integrates the [SliverAppBar] into its
    ///    scrolling.
    ///  * [AppBar], which is a fixed-height app bar for use in [Scaffold.appBar].
    ///  * [TabBar], which is typically placed in the [bottom] slot of the [AppBar]
    ///    if the screen has multiple pages arranged in tabs.
    ///  * [IconButton], which is used with [actions] to show buttons on the app bar.
    ///  * [PopupMenuButton], to show a popup menu on the app bar, via [actions].
    ///  * [FlexibleSpaceBar], which is used with [flexibleSpace] when the app bar
    ///    can expand and collapse.
    ///  * <https://material.io/design/components/app-bars-top.html>
    /// </Summary>
    public class SliverAppBar : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a material design app bar that can be placed in a [CustomScrollView].
        ///
        /// The arguments [forceElevated], [primary], [floating], [pinned], [snap]
        /// and [automaticallyImplyLeading] must not be null.
        /// </Summary>
        public SliverAppBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), bool automaticallyImplyLeading = true, FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget flexibleSpace = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget bottom = default(FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget), double elevation = default(double), bool forceElevated = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData actionsIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), bool primary = true, bool centerTitle = default(bool), bool excludeHeaderSemantics = false, double titleSpacing = default(double), double expandedHeight = default(double), bool floating = false, bool pinned = false, bool snap = false, bool stretch = false, double stretchTriggerOffset = 100.0, FlutterSDK.Foundation.Basictypes.AsyncCallback onStretchTrigger = default(FlutterSDK.Foundation.Basictypes.AsyncCallback), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base(key: key)
        {
            this.Leading = leading;
            this.AutomaticallyImplyLeading = automaticallyImplyLeading;
            this.Title = title;
            this.Actions = actions;
            this.FlexibleSpace = flexibleSpace;
            this.Bottom = bottom;
            this.Elevation = elevation;
            this.ForceElevated = forceElevated;
            this.BackgroundColor = backgroundColor;
            this.Brightness = brightness;
            this.IconTheme = iconTheme;
            this.ActionsIconTheme = actionsIconTheme;
            this.TextTheme = textTheme;
            this.Primary = primary;
            this.CenterTitle = centerTitle;
            this.ExcludeHeaderSemantics = excludeHeaderSemantics;
            this.TitleSpacing = titleSpacing;
            this.ExpandedHeight = expandedHeight;
            this.Floating = floating;
            this.Pinned = pinned;
            this.Snap = snap;
            this.Stretch = stretch;
            this.StretchTriggerOffset = stretchTriggerOffset;
            this.OnStretchTrigger = onStretchTrigger;
            this.Shape = shape;
        }
        /// <Summary>
        /// A widget to display before the [title].
        ///
        /// If this is null and [automaticallyImplyLeading] is set to true, the [AppBar] will
        /// imply an appropriate widget. For example, if the [AppBar] is in a [Scaffold]
        /// that also has a [Drawer], the [Scaffold] will fill this widget with an
        /// [IconButton] that opens the drawer. If there's no [Drawer] and the parent
        /// [Navigator] can go back, the [AppBar] will use a [BackButton] that calls
        /// [Navigator.maybePop].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Leading { get; set; }
        /// <Summary>
        /// Controls whether we should try to imply the leading widget if null.
        ///
        /// If true and [leading] is null, automatically try to deduce what the leading
        /// widget should be. If false and [leading] is null, leading space is given to [title].
        /// If leading widget is not null, this parameter has no effect.
        /// </Summary>
        public virtual bool AutomaticallyImplyLeading { get; set; }
        /// <Summary>
        /// The primary widget displayed in the app bar.
        ///
        /// Typically a [Text] widget containing a description of the current contents
        /// of the app.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        /// <Summary>
        /// Widgets to display after the [title] widget.
        ///
        /// Typically these widgets are [IconButton]s representing common operations.
        /// For less common operations, consider using a [PopupMenuButton] as the
        /// last action.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Scaffold(
        ///   body: CustomScrollView(
        ///     primary: true,
        ///     slivers: <Widget>[
        ///       SliverAppBar(
        ///         title: Text('Hello World'),
        ///         actions: <Widget>[
        ///           IconButton(
        ///             icon: Icon(Icons.shopping_cart),
        ///             tooltip: 'Open shopping cart',
        ///             onPressed: () {
        ///               // handle the press
        ///             },
        ///           ),
        ///         ],
        ///       ),
        ///       // ...rest of body...
        ///     ],
        ///   ),
        /// )
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        /// <Summary>
        /// This widget is stacked behind the toolbar and the tab bar. It's height will
        /// be the same as the app bar's overall height.
        ///
        /// Typically a [FlexibleSpaceBar]. See [FlexibleSpaceBar] for details.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget FlexibleSpace { get; set; }
        /// <Summary>
        /// This widget appears across the bottom of the app bar.
        ///
        /// Typically a [TabBar]. Only widgets that implement [PreferredSizeWidget] can
        /// be used at the bottom of an app bar.
        ///
        /// See also:
        ///
        ///  * [PreferredSize], which can be used to give an arbitrary widget a preferred size.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget Bottom { get; set; }
        /// <Summary>
        /// The z-coordinate at which to place this app bar when it is above other
        /// content. This controls the size of the shadow below the app bar.
        ///
        /// If this property is null, then [ThemeData.appBarTheme.elevation] is used,
        /// if that is also null, the default value is 4, the appropriate elevation
        /// for app bars.
        ///
        /// If [forceElevated] is false, the elevation is ignored when the app bar has
        /// no content underneath it. For example, if the app bar is [pinned] but no
        /// content is scrolled under it, or if it scrolls with the content, then no
        /// shadow is drawn, regardless of the value of [elevation].
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// Whether to show the shadow appropriate for the [elevation] even if the
        /// content is not scrolled under the [AppBar].
        ///
        /// Defaults to false, meaning that the [elevation] is only applied when the
        /// [AppBar] is being displayed over content that is scrolled under it.
        ///
        /// When set to true, the [elevation] is applied regardless.
        ///
        /// Ignored when [elevation] is zero.
        /// </Summary>
        public virtual bool ForceElevated { get; set; }
        /// <Summary>
        /// The color to use for the app bar's material. Typically this should be set
        /// along with [brightness], [iconTheme], [textTheme].
        ///
        /// If this property is null, then [ThemeData.appBarTheme.color] is used,
        /// if that is also null, then [ThemeData.primaryColor] is used.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// The brightness of the app bar's material. Typically this is set along
        /// with [backgroundColor], [iconTheme], [textTheme].
        ///
        /// If this property is null, then [ThemeData.appBarTheme.brightness] is used,
        /// if that is also null, then [ThemeData.primaryColorBrightness] is used.
        /// </Summary>
        public virtual Brightness Brightness { get; set; }
        /// <Summary>
        /// The color, opacity, and size to use for app bar icons. Typically this
        /// is set along with [backgroundColor], [brightness], [textTheme].
        ///
        /// If this property is null, then [ThemeData.appBarTheme.iconTheme] is used,
        /// if that is also null, then [ThemeData.primaryIconTheme] is used.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData IconTheme { get; set; }
        /// <Summary>
        /// The color, opacity, and size to use for trailing app bar icons. This
        /// should only be used when the trailing icons should be themed differently
        /// than the leading icons.
        ///
        /// If this property is null, then [ThemeData.appBarTheme.actionsIconTheme] is
        /// used, if that is also null, then this falls back to [iconTheme].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData ActionsIconTheme { get; set; }
        /// <Summary>
        /// The typographic styles to use for text in the app bar. Typically this is
        /// set along with [brightness] [backgroundColor], [iconTheme].
        ///
        /// If this property is null, then [ThemeData.appBarTheme.textTheme] is used,
        /// if that is also null, then [ThemeData.primaryTextTheme] is used.
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme TextTheme { get; set; }
        /// <Summary>
        /// Whether this app bar is being displayed at the top of the screen.
        ///
        /// If this is true, the top padding specified by the [MediaQuery] will be
        /// added to the top of the toolbar.
        /// </Summary>
        public virtual bool Primary { get; set; }
        /// <Summary>
        /// Whether the title should be centered.
        ///
        /// Defaults to being adapted to the current [TargetPlatform].
        /// </Summary>
        public virtual bool CenterTitle { get; set; }
        /// <Summary>
        /// Whether the title should be wrapped with header [Semantics].
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool ExcludeHeaderSemantics { get; set; }
        /// <Summary>
        /// The spacing around [title] content on the horizontal axis. This spacing is
        /// applied even if there is no [leading] content or [actions]. If you want
        /// [title] to take all the space available, set this value to 0.0.
        ///
        /// Defaults to [NavigationToolbar.kMiddleSpacing].
        /// </Summary>
        public virtual double TitleSpacing { get; set; }
        /// <Summary>
        /// The size of the app bar when it is fully expanded.
        ///
        /// By default, the total height of the toolbar and the bottom widget (if
        /// any). If a [flexibleSpace] widget is specified this height should be big
        /// enough to accommodate whatever that widget contains.
        ///
        /// This does not include the status bar height (which will be automatically
        /// included if [primary] is true).
        /// </Summary>
        public virtual double ExpandedHeight { get; set; }
        /// <Summary>
        /// Whether the app bar should become visible as soon as the user scrolls
        /// towards the app bar.
        ///
        /// Otherwise, the user will need to scroll near the top of the scroll view to
        /// reveal the app bar.
        ///
        /// If [snap] is true then a scroll that exposes the app bar will trigger an
        /// animation that slides the entire app bar into view. Similarly if a scroll
        /// dismisses the app bar, the animation will slide it completely out of view.
        ///
        /// ## Animated Examples
        ///
        /// The following animations show how the app bar changes its scrolling
        /// behavior based on the value of this property.
        ///
        /// * App bar with [floating] set to false:
        ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar.mp4}
        /// * App bar with [floating] set to true:
        ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar_floating.mp4}
        ///
        /// See also:
        ///
        ///  * [SliverAppBar] for more animated examples of how this property changes the
        ///    behavior of the app bar in combination with [pinned] and [snap].
        /// </Summary>
        public virtual bool Floating { get; set; }
        /// <Summary>
        /// Whether the app bar should remain visible at the start of the scroll view.
        ///
        /// The app bar can still expand and contract as the user scrolls, but it will
        /// remain visible rather than being scrolled out of view.
        ///
        /// ## Animated Examples
        ///
        /// The following animations show how the app bar changes its scrolling
        /// behavior based on the value of this property.
        ///
        /// * App bar with [pinned] set to false:
        ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar.mp4}
        /// * App bar with [pinned] set to true:
        ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar_pinned.mp4}
        ///
        /// See also:
        ///
        ///  * [SliverAppBar] for more animated examples of how this property changes the
        ///    behavior of the app bar in combination with [floating].
        /// </Summary>
        public virtual bool Pinned { get; set; }
        /// <Summary>
        /// The material's shape as well as its shadow.
        ///
        /// A shadow is only displayed if the [elevation] is greater than zero.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        /// <Summary>
        /// If [snap] and [floating] are true then the floating app bar will "snap"
        /// into view.
        ///
        /// If [snap] is true then a scroll that exposes the floating app bar will
        /// trigger an animation that slides the entire app bar into view. Similarly if
        /// a scroll dismisses the app bar, the animation will slide the app bar
        /// completely out of view.
        ///
        /// Snapping only applies when the app bar is floating, not when the app bar
        /// appears at the top of its scroll view.
        ///
        /// ## Animated Examples
        ///
        /// The following animations show how the app bar changes its scrolling
        /// behavior based on the value of this property.
        ///
        /// * App bar with [snap] set to false:
        ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar_floating.mp4}
        /// * App bar with [snap] set to true:
        ///   {@animation 476 400 https://flutter.github.io/assets-for-api-docs/assets/material/app_bar_floating_snap.mp4}
        ///
        /// See also:
        ///
        ///  * [SliverAppBar] for more animated examples of how this property changes the
        ///    behavior of the app bar in combination with [pinned] and [floating].
        /// </Summary>
        public virtual bool Snap { get; set; }
        /// <Summary>
        /// Whether the app bar should stretch to fill the over-scroll area.
        ///
        /// The app bar can still expand and contract as the user scrolls, but it will
        /// also stretch when the user over-scrolls.
        /// </Summary>
        public virtual bool Stretch { get; set; }
        /// <Summary>
        /// The offset of overscroll required to activate [onStretchTrigger].
        ///
        /// This defaults to 100.0.
        /// </Summary>
        public virtual double StretchTriggerOffset { get; set; }
        /// <Summary>
        /// The callback function to be executed when a user over-scrolls to the
        /// offset specified by [stretchTriggerOffset].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.AsyncCallback OnStretchTrigger { get; set; }

        public new FlutterSDK.Material.Appbar._SliverAppBarState CreateState() => new _SliverAppBarState();


    }


    public class _SliverAppBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Appbar.SliverAppBar>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _SliverAppBarState()
        { }
        internal virtual FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration _SnapConfiguration { get; set; }
        internal virtual FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration _StretchConfiguration { get; set; }

        private void _UpdateSnapConfiguration()
        {
            if (Widget.Snap && Widget.Floating)
            {
                _SnapConfiguration = new FloatingHeaderSnapConfiguration(vsync: this, curve: CurvesDefaultClass.Curves.EaseOut, duration: new TimeSpan(milliseconds: 200));
            }
            else
            {
                _SnapConfiguration = null;
            }

        }




        private void _UpdateStretchConfiguration()
        {
            if (Widget.Stretch)
            {
                _StretchConfiguration = new OverScrollHeaderStretchConfiguration(stretchTriggerOffset: Widget.StretchTriggerOffset, onStretchTrigger: Widget.OnStretchTrigger);
            }
            else
            {
                _StretchConfiguration = null;
            }

        }




        public new void InitState()
        {
            base.InitState();
            _UpdateSnapConfiguration();
            _UpdateStretchConfiguration();
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Appbar.SliverAppBar oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Snap != oldWidget.Snap || Widget.Floating != oldWidget.Floating) _UpdateSnapConfiguration();
            if (Widget.Stretch != oldWidget.Stretch) _UpdateStretchConfiguration();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            double topPadding = Widget.Primary ? MediaqueryDefaultClass.MediaQuery.Of(context).Padding.Top : 0.0;
            double collapsedHeight = (Widget.Pinned && Widget.Floating && Widget.Bottom != null) ? Widget.Bottom.PreferredSize.Height + topPadding : null;
            return MediaQuery.RemovePadding(context: context, removeBottom: true, child: new SliverPersistentHeader(floating: Widget.Floating, pinned: Widget.Pinned, @delegate: new _SliverAppBarDelegate(leading: Widget.Leading, automaticallyImplyLeading: Widget.AutomaticallyImplyLeading, title: Widget.Title, actions: Widget.Actions, flexibleSpace: Widget.FlexibleSpace, bottom: Widget.Bottom, elevation: Widget.Elevation, forceElevated: Widget.ForceElevated, backgroundColor: Widget.BackgroundColor, brightness: Widget.Brightness, iconTheme: Widget.IconTheme, actionsIconTheme: Widget.ActionsIconTheme, textTheme: Widget.TextTheme, primary: Widget.Primary, centerTitle: Widget.CenterTitle, excludeHeaderSemantics: Widget.ExcludeHeaderSemantics, titleSpacing: Widget.TitleSpacing, expandedHeight: Widget.ExpandedHeight, collapsedHeight: collapsedHeight, topPadding: topPadding, floating: Widget.Floating, pinned: Widget.Pinned, shape: Widget.Shape, snapConfiguration: _SnapConfiguration, stretchConfiguration: _StretchConfiguration)));
        }



    }


    public class _AppBarTitleBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _AppBarTitleBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {

        }

        public new FlutterSDK.Material.Appbar._RenderAppBarTitleBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderAppBarTitleBox(textDirection: BasicDefaultClass.Directionality.Of(context));
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Appbar._RenderAppBarTitleBox renderObject)
        {
            renderObject.TextDirection = BasicDefaultClass.Directionality.Of(context);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.TextDirection = BasicDefaultClass.Directionality.Of(context);
        }



    }


    public class _RenderAppBarTitleBox : FlutterSDK.Rendering.Shiftedbox.RenderAligningShiftedBox
    {
        public _RenderAppBarTitleBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), TextDirection textDirection = default(TextDirection))
        : base(child: child, alignment: AlignmentDefaultClass.Alignment.Center, textDirection: textDirection)
        {

        }

        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            BoxConstraints innerConstraints = constraints.CopyWith(maxHeight: Dart.CoreDefaultClass.Double.Infinity);
            Child.Layout(innerConstraints, parentUsesSize: true);
            Size = constraints.Constrain(Child.Size);
            AlignChild();
        }



    }

}
