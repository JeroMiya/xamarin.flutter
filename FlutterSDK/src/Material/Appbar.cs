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
namespace FlutterSDK.Material.Appbar
{
    internal static class AppbarDefaultClass
    {
        public static double _KLeadingWidth = default(double);
    }

    public class _ToolbarContainerLayout : FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate
    {
        #region constructors
        public _ToolbarContainerLayout()
    
}
    #endregion

    #region fields
    #endregion

    #region methods

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


    #endregion
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
    #region constructors
    public AppBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), bool automaticallyImplyLeading = true, FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget flexibleSpace = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget bottom = default(FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget), double elevation = default(double), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData actionsIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), bool primary = true, bool centerTitle = default(bool), bool excludeHeaderSemantics = false, double titleSpacing = default(double), double toolbarOpacity = 1.0, double bottomOpacity = 1.0)
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Leading { get; set; }
public virtual bool AutomaticallyImplyLeading { get; set; }
public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
public virtual FlutterSDK.Widgets.Framework.Widget FlexibleSpace { get; set; }
public virtual FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget Bottom { get; set; }
public virtual double Elevation { get; set; }
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
public virtual Brightness Brightness { get; set; }
public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData IconTheme { get; set; }
public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData ActionsIconTheme { get; set; }
public virtual FlutterSDK.Material.Texttheme.TextTheme TextTheme { get; set; }
public virtual bool Primary { get; set; }
public virtual bool CenterTitle { get; set; }
public virtual bool ExcludeHeaderSemantics { get; set; }
public virtual double TitleSpacing { get; set; }
public virtual double ToolbarOpacity { get; set; }
public virtual double BottomOpacity { get; set; }
public new Size PreferredSize { get; set; }
#endregion

#region methods

private bool _GetEffectiveCenterTitle(FlutterSDK.Material.Themedata.ThemeData theme)
{
    if (CenterTitle != null) return CenterTitle;

    switch (theme.Platform) { case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: return false; case TargetPlatform.IOS: case TargetPlatform.MacOS: return Actions == null || Actions.Count < 2; }
    return null;
}




public new FlutterSDK.Material.Appbar._AppBarState CreateState() => new _AppBarState();


#endregion
}


public class _AppBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Appbar.AppBar>
{
    #region constructors
    public _AppBarState()
    { }
    #endregion

    #region fields
    internal virtual double _DefaultElevation { get; set; }
    #endregion

    #region methods

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
            appBar = new Column(mainAxisAlignment: MainAxisAlignment.SpaceBetween, children: new List<Widget>() { new Flexible(child: new ConstrainedBox(constraints: new BoxConstraints(maxHeight: ConstantsDefaultClass.KToolbarHeight), child: appBar)), });
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



    #endregion
}


public class _FloatingAppBar : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public _FloatingAppBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Appbar._FloatingAppBarState CreateState() => new _FloatingAppBarState();


#endregion
}


public class _FloatingAppBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Appbar._FloatingAppBar>
{
    #region constructors
    public _FloatingAppBarState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition _Position { get; set; }
    #endregion

    #region methods

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


    #endregion
}


public class _SliverAppBarDelegate : FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate
{
    #region constructors
    public _SliverAppBarDelegate(FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), bool automaticallyImplyLeading = default(bool), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget flexibleSpace = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget bottom = default(FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget), double elevation = default(double), bool forceElevated = default(bool), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData actionsIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), bool primary = default(bool), bool centerTitle = default(bool), bool excludeHeaderSemantics = default(bool), double titleSpacing = default(double), double expandedHeight = default(double), double collapsedHeight = default(double), double topPadding = default(double), bool floating = default(bool), bool pinned = default(bool), FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration snapConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder))
    : base()

}
#endregion

#region fields
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
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, double shrinkOffset, bool overlapsContent)
{
    double visibleMainHeight = MaxExtent - shrinkOffset - TopPadding;
    double toolbarOpacity = !Pinned || (Floating && Bottom != null) ? ((visibleMainHeight - _BottomHeight) / ConstantsDefaultClass.KToolbarHeight).Clamp(0.0, 1.0) as double : 1.0;
    Widget appBar = FlexiblespacebarDefaultClass.FlexibleSpaceBar.CreateSettings(minExtent: MinExtent, maxExtent: MaxExtent, currentExtent: Math.Dart:mathDefaultClass.Max(MinExtent, MaxExtent - shrinkOffset), toolbarOpacity: toolbarOpacity, child: new AppBar(leading: Leading, automaticallyImplyLeading: AutomaticallyImplyLeading, title: Title, actions: Actions, flexibleSpace: (Title == null && FlexibleSpace != null && !ExcludeHeaderSemantics) ? new Semantics(child: FlexibleSpace, header: true) : FlexibleSpace, bottom: Bottom, elevation: ForceElevated || overlapsContent || (Pinned && shrinkOffset > MaxExtent - MinExtent) ? elevation == default(double) ? 4.0 : elevation : 0.0, backgroundColor: BackgroundColor, brightness: Brightness, iconTheme: IconTheme, actionsIconTheme: ActionsIconTheme, textTheme: TextTheme, primary: Primary, centerTitle: CenterTitle, excludeHeaderSemantics: ExcludeHeaderSemantics, titleSpacing: TitleSpacing, shape: Shape, toolbarOpacity: toolbarOpacity, bottomOpacity: Pinned ? 1.0 : ((visibleMainHeight / _BottomHeight).Clamp(0.0, 1.0) as double)));
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




#endregion
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
    #region constructors
    public SliverAppBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), bool automaticallyImplyLeading = true, FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Framework.Widget flexibleSpace = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget bottom = default(FlutterSDK.Widgets.Preferredsize.PreferredSizeWidget), double elevation = default(double), bool forceElevated = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData actionsIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Material.Texttheme.TextTheme textTheme = default(FlutterSDK.Material.Texttheme.TextTheme), bool primary = true, bool centerTitle = default(bool), bool excludeHeaderSemantics = false, double titleSpacing = default(double), double expandedHeight = default(double), bool floating = false, bool pinned = false, bool snap = false, bool stretch = false, double stretchTriggerOffset = 100.0, FlutterSDK.Foundation.Basictypes.AsyncCallback onStretchTrigger = default(FlutterSDK.Foundation.Basictypes.AsyncCallback), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder))
    : base(key: key)

}
#endregion

#region fields
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
public virtual bool Floating { get; set; }
public virtual bool Pinned { get; set; }
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
public virtual bool Snap { get; set; }
public virtual bool Stretch { get; set; }
public virtual double StretchTriggerOffset { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.AsyncCallback OnStretchTrigger { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Appbar._SliverAppBarState CreateState() => new _SliverAppBarState();


#endregion
}


public class _SliverAppBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Appbar.SliverAppBar>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
    #region constructors
    public _SliverAppBarState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration _SnapConfiguration { get; set; }
    internal virtual FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration _StretchConfiguration { get; set; }
    #endregion

    #region methods

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



    #endregion
}


public class _AppBarTitleBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
    #region constructors
    public _AppBarTitleBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key, child: child)

}
#endregion

#region fields
#endregion

#region methods

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



#endregion
}


public class _RenderAppBarTitleBox : FlutterSDK.Rendering.Shiftedbox.RenderAligningShiftedBox
{
    #region constructors
    public _RenderAppBarTitleBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), TextDirection textDirection = default(TextDirection))
    : base(child: child, alignment: AlignmentDefaultClass.Alignment.Center, textDirection: textDirection)

}
#endregion

#region fields
#endregion

#region methods

public new void PerformLayout()
{
    BoxConstraints constraints = this.Constraints;
    BoxConstraints innerConstraints = constraints.CopyWith(maxHeight: Dart:coreDefaultClass.Double.Infinity);
    Child.Layout(innerConstraints, parentUsesSize: true);
    Size = constraints.Constrain(Child.Size);
    AlignChild();
}



#endregion
}

}
