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
namespace FlutterSDK.Material.Drawer
{
    /// <Summary>
    /// Signature for the callback that's called when a [DrawerController] is
    /// opened or closed.
    /// </Summary>
    public delegate void DrawerCallback(bool isOpened);
    internal static class DrawerDefaultClass
    {
        public static double _KWidth = default(double);
        public static double _KEdgeDragWidth = default(double);
        public static double _KMinFlingVelocity = default(double);
        public static TimeSpan _KBaseSettleDuration = default(TimeSpan);
    }

    /// <Summary>
    /// A material design panel that slides in horizontally from the edge of a
    /// [Scaffold] to show navigation links in an application.
    ///
    /// Drawers are typically used with the [Scaffold.drawer] property. The child of
    /// the drawer is usually a [ListView] whose first child is a [DrawerHeader]
    /// that displays status information about the current user. The remaining
    /// drawer children are often constructed with [ListTile]s, often concluding
    /// with an [AboutListTile].
    ///
    /// The [AppBar] automatically displays an appropriate [IconButton] to show the
    /// [Drawer] when a [Drawer] is available in the [Scaffold]. The [Scaffold]
    /// automatically handles the edge-swipe gesture to show the drawer.
    ///
    /// {@animation 350 622 https://flutter.github.io/assets-for-api-docs/assets/material/drawer.mp4}
    ///
    /// {@tool snippet}
    /// This example shows how to create a [Scaffold] that contains an [AppBar] and
    /// a [Drawer]. A user taps the "menu" icon in the [AppBar] to open the
    /// [Drawer]. The [Drawer] displays four items: A header and three menu items.
    /// The [Drawer] displays the four items using a [ListView], which allows the
    /// user to scroll through the items if need be.
    ///
    /// ```dart
    /// Scaffold(
    ///   appBar: AppBar(
    ///     title: const Text('Drawer Demo'),
    ///   ),
    ///   drawer: Drawer(
    ///     child: ListView(
    ///       padding: EdgeInsets.zero,
    ///       children: const <Widget>[
    ///         DrawerHeader(
    ///           decoration: BoxDecoration(
    ///             color: Colors.blue,
    ///           ),
    ///           child: Text(
    ///             'Drawer Header',
    ///             style: TextStyle(
    ///               color: Colors.white,
    ///               fontSize: 24,
    ///             ),
    ///           ),
    ///         ),
    ///         ListTile(
    ///           leading: Icon(Icons.message),
    ///           title: Text('Messages'),
    ///         ),
    ///         ListTile(
    ///           leading: Icon(Icons.account_circle),
    ///           title: Text('Profile'),
    ///         ),
    ///         ListTile(
    ///           leading: Icon(Icons.settings),
    ///           title: Text('Settings'),
    ///         ),
    ///       ],
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// An open drawer can be closed by calling [Navigator.pop]. For example
    /// a drawer item might close the drawer when tapped:
    ///
    /// ```dart
    /// ListTile(
    ///   leading: Icon(Icons.change_history),
    ///   title: Text('Change history'),
    ///   onTap: () {
    ///     // change app state...
    ///     Navigator.pop(context); // close the drawer
    ///   },
    /// );
    /// ```
    ///
    /// See also:
    ///
    ///  * [Scaffold.drawer], where one specifies a [Drawer] so that it can be
    ///    shown.
    ///  * [Scaffold.of], to obtain the current [ScaffoldState], which manages the
    ///    display and animation of the drawer.
    ///  * [ScaffoldState.openDrawer], which displays its [Drawer], if any.
    ///  * <https://material.io/design/components/navigation-drawer.html>
    /// </Summary>
    public class Drawer : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a material design drawer.
        ///
        /// Typically used in the [Scaffold.drawer] property.
        ///
        /// The [elevation] must be non-negative.
        /// </Summary>
        public Drawer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double elevation = 16.0, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), string semanticLabel = default(string))
        : base(key: key)
        {
            this.Elevation = elevation;
            this.Child = child;
            this.SemanticLabel = semanticLabel;
        }
        /// <Summary>
        /// The z-coordinate at which to place this drawer relative to its parent.
        ///
        /// This controls the size of the shadow below the drawer.
        ///
        /// Defaults to 16, the appropriate elevation for drawers. The value is
        /// always non-negative.
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// Typically a [SliverList].
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The semantic label of the dialog used by accessibility frameworks to
        /// announce screen transitions when the drawer is opened and closed.
        ///
        /// If this label is not provided, it will default to
        /// [MaterialLocalizations.drawerLabel].
        ///
        /// See also:
        ///
        ///  * [SemanticsConfiguration.namesRoute], for a description of how this
        ///    value is used.
        /// </Summary>
        public virtual string SemanticLabel { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            string label = SemanticLabel;
            switch (ThemeDefaultClass.Theme.Of(context).Platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: label = SemanticLabel; break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: label = SemanticLabel ?? MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context)?.DrawerLabel; }
            return new Semantics(scopesRoute: true, namesRoute: true, explicitChildNodes: true, label: label, child: new ConstrainedBox(constraints: BoxConstraints.Expand(width: DrawerDefaultClass._KWidth), child: new Material(elevation: Elevation, child: Child)));
        }



    }


    /// <Summary>
    /// Provides interactive behavior for [Drawer] widgets.
    ///
    /// Rarely used directly. Drawer controllers are typically created automatically
    /// by [Scaffold] widgets.
    ///
    /// The draw controller provides the ability to open and close a drawer, either
    /// via an animation or via user interaction. When closed, the drawer collapses
    /// to a translucent gesture detector that can be used to listen for edge
    /// swipes.
    ///
    /// See also:
    ///
    ///  * [Drawer], a container with the default width of a drawer.
    ///  * [Scaffold.drawer], the [Scaffold] slot for showing a drawer.
    /// </Summary>
    public class DrawerController : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a controller for a [Drawer].
        ///
        /// Rarely used directly.
        ///
        /// The [child] argument must not be null and is typically a [Drawer].
        /// </Summary>
        public DrawerController(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> key = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Material.Drawer.DrawerAlignment alignment = default(FlutterSDK.Material.Drawer.DrawerAlignment), FlutterSDK.Material.Drawer.DrawerCallback drawerCallback = default(FlutterSDK.Material.Drawer.DrawerCallback), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), FlutterBinding.UI.Color scrimColor = default(FlutterBinding.UI.Color), double edgeDragWidth = default(double), bool enableOpenDragGesture = true)
        : base(key: key)
        {
            this.Child = child;
            this.Alignment = alignment;
            this.DrawerCallback = drawerCallback;
            this.DragStartBehavior = dragStartBehavior;
            this.ScrimColor = scrimColor;
            this.EdgeDragWidth = edgeDragWidth;
            this.EnableOpenDragGesture = enableOpenDragGesture;
        }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// Typically a [Drawer].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The alignment of the [Drawer].
        ///
        /// This controls the direction in which the user should swipe to open and
        /// close the drawer.
        /// </Summary>
        public virtual FlutterSDK.Material.Drawer.DrawerAlignment Alignment { get; set; }
        /// <Summary>
        /// Optional callback that is called when a [Drawer] is opened or closed.
        /// </Summary>
        public virtual FlutterSDK.Material.Drawer.DrawerCallback DrawerCallback { get; set; }
        /// <Summary>
        /// {@template flutter.material.drawer.dragStartBehavior}
        /// Determines the way that drag start behavior is handled.
        ///
        /// If set to [DragStartBehavior.start], the drag behavior used for opening
        /// and closing a drawer will begin upon the detection of a drag gesture. If
        /// set to [DragStartBehavior.down] it will begin when a down event is first
        /// detected.
        ///
        /// In general, setting this to [DragStartBehavior.start] will make drag
        /// animation smoother and setting it to [DragStartBehavior.down] will make
        /// drag behavior feel slightly more reactive.
        ///
        /// By default, the drag start behavior is [DragStartBehavior.start].
        ///
        /// See also:
        ///
        ///  * [DragGestureRecognizer.dragStartBehavior], which gives an example for
        ///    the different behaviors.
        ///
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        /// <Summary>
        /// The color to use for the scrim that obscures primary content while a drawer is open.
        ///
        /// By default, the color used is [Colors.black54]
        /// </Summary>
        public virtual FlutterBinding.UI.Color ScrimColor { get; set; }
        /// <Summary>
        /// Determines if the [Drawer] can be opened with a drag gesture.
        ///
        /// By default, the drag gesture is enabled.
        /// </Summary>
        public virtual bool EnableOpenDragGesture { get; set; }
        /// <Summary>
        /// The width of the area within which a horizontal swipe will open the
        /// drawer.
        ///
        /// By default, the value used is 20.0 added to the padding edge of
        /// `MediaQuery.of(context).padding` that corresponds to [alignment].
        /// This ensures that the drag area for notched devices is not obscured. For
        /// example, if [alignment] is set to [DrawerAlignment.start] and
        /// `TextDirection.of(context)` is set to [TextDirection.ltr],
        /// 20.0 will be added to `MediaQuery.of(context).padding.left`.
        /// </Summary>
        public virtual double EdgeDragWidth { get; set; }

        public new FlutterSDK.Material.Drawer.DrawerControllerState CreateState() => new DrawerControllerState();


    }


    /// <Summary>
    /// State for a [DrawerController].
    ///
    /// Typically used by a [Scaffold] to [open] and [close] the drawer.
    /// </Summary>
    public class DrawerControllerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Drawer.DrawerController>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public DrawerControllerState()
        { }
        internal virtual FlutterSDK.Widgets.Routes.LocalHistoryEntry _HistoryEntry { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusScopeNode _FocusScopeNode { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _DrawerKey { get; set; }
        internal virtual bool _PreviouslyOpened { get; set; }
        internal virtual FlutterSDK.Animation.Tween.ColorTween _ScrimColorTween { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _GestureDetectorKey { get; set; }
        internal virtual double _Width { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Painting.Alignment.AlignmentDirectional _DrawerOuterAlignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Painting.Alignment.AlignmentDirectional _DrawerInnerAlignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _ScrimColorTween = _BuildScrimColorTween();
            _Controller = new AnimationController(duration: DrawerDefaultClass._KBaseSettleDuration, vsync: this);
            new AnimationController(duration: DrawerDefaultClass._KBaseSettleDuration, vsync: this).AddListener(_AnimationChanged);
            new AnimationController(duration: DrawerDefaultClass._KBaseSettleDuration, vsync: this).AddStatusListener(_AnimationStatusChanged);
        }




        public new void Dispose()
        {
            _HistoryEntry?.Remove();
            _Controller.Dispose();
            base.Dispose();
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Drawer.DrawerController oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.ScrimColor != oldWidget.ScrimColor) _ScrimColorTween = _BuildScrimColorTween();
        }




        private void _AnimationChanged()
        {
            SetState(() =>
            {
            }
            );
        }




        private void _EnsureHistoryEntry()
        {
            if (_HistoryEntry == null)
            {
                ModalRoute<object> route = RoutesDefaultClass.ModalRoute.Of(Context);
                if (route != null)
                {
                    _HistoryEntry = new LocalHistoryEntry(onRemove: _HandleHistoryEntryRemoved);
                    route.AddLocalHistoryEntry(_HistoryEntry);
                    FocusscopeDefaultClass.FocusScope.Of(Context).SetFirstFocus(_FocusScopeNode);
                }

            }

        }




        private void _AnimationStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            switch (status) { case AnimationStatus.Forward: _EnsureHistoryEntry(); break; case AnimationStatus.Reverse: _HistoryEntry?.Remove(); _HistoryEntry = null; break; case AnimationStatus.Dismissed: break; case AnimationStatus.Completed: break; }
        }




        private void _HandleHistoryEntryRemoved()
        {
            _HistoryEntry = null;
            Close();
        }




        private void _HandleDragDown(FlutterSDK.Gestures.Dragdetails.DragDownDetails details)
        {
            _Controller.Stop();
            _EnsureHistoryEntry();
        }




        private void _HandleDragCancel()
        {
            if (_Controller.IsDismissed || _Controller.IsAnimating) return;
            if (_Controller.Value < 0.5)
            {
                Close();
            }
            else
            {
                Open();
            }

        }




        private void _Move(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {
            double delta = details.PrimaryDelta / _Width;
            switch (Widget.Alignment) { case DrawerAlignment.Start: break; case DrawerAlignment.End: delta = -delta; break; }
            switch (BasicDefaultClass.Directionality.Of(Context)) { case TextDirection.Rtl: _Controller.Value -= delta; break; case TextDirection.Ltr: _Controller.Value += delta; break; }
            bool opened = _Controller.Value > 0.5;
            if (opened != _PreviouslyOpened && Widget.DrawerCallback != null) Widget.DrawerCallback(opened);
            _PreviouslyOpened = opened;
        }




        private void _Settle(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {
            if (_Controller.IsDismissed) return;
            if (details.Velocity.PixelsPerSecond.Dx.Abs() >= DrawerDefaultClass._KMinFlingVelocity)
            {
                double visualVelocity = details.Velocity.PixelsPerSecond.Dx / _Width;
                switch (Widget.Alignment) { case DrawerAlignment.Start: break; case DrawerAlignment.End: visualVelocity = -visualVelocity; break; }
                switch (BasicDefaultClass.Directionality.Of(Context)) { case TextDirection.Rtl: _Controller.Fling(velocity: -visualVelocity); if (Widget.DrawerCallback != null) Widget.DrawerCallback(visualVelocity < 0.0); break; case TextDirection.Ltr: _Controller.Fling(velocity: visualVelocity); if (Widget.DrawerCallback != null) Widget.DrawerCallback(visualVelocity > 0.0); break; }
            }
            else if (_Controller.Value < 0.5)
            {
                Close();
            }
            else
            {
                Open();
            }

        }




        /// <Summary>
        /// Starts an animation to open the drawer.
        ///
        /// Typically called by [ScaffoldState.openDrawer].
        /// </Summary>
        public virtual void Open()
        {
            _Controller.Fling(velocity: 1.0);
            if (Widget.DrawerCallback != null) Widget.DrawerCallback(true);
        }




        /// <Summary>
        /// Starts an animation to close the drawer.
        /// </Summary>
        public virtual void Close()
        {
            _Controller.Fling(velocity: -1.0);
            if (Widget.DrawerCallback != null) Widget.DrawerCallback(false);
        }




        private FlutterSDK.Animation.Tween.ColorTween _BuildScrimColorTween()
        {
            return new ColorTween(begin: ColorsDefaultClass.Colors.Transparent, end: Widget.ScrimColor ?? ColorsDefaultClass.Colors.Black54);
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildDrawer(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            bool drawerIsStart = Widget.Alignment == DrawerAlignment.Start;
            EdgeInsets padding = MediaqueryDefaultClass.MediaQuery.Of(context).Padding;
            TextDirection textDirection = BasicDefaultClass.Directionality.Of(context);
            double dragAreaWidth = Widget.EdgeDragWidth;
            if (Widget.EdgeDragWidth == null)
            {
                switch (textDirection) { case TextDirection.Ltr: dragAreaWidth = DrawerDefaultClass._KEdgeDragWidth + (drawerIsStart ? padding.Left : padding.Right); break; case TextDirection.Rtl: dragAreaWidth = DrawerDefaultClass._KEdgeDragWidth + (drawerIsStart ? padding.Right : padding.Left); break; }
            }

            if (_Controller.Status == AnimationStatus.Dismissed)
            {
                if (Widget.EnableOpenDragGesture)
                {
                    return new Align(alignment: _DrawerOuterAlignment, child: new GestureDetector(key: _GestureDetectorKey, onHorizontalDragUpdate: _Move, onHorizontalDragEnd: _Settle, behavior: HitTestBehavior.Translucent, excludeFromSemantics: true, dragStartBehavior: Widget.DragStartBehavior, child: new Container(width: dragAreaWidth)));
                }
                else
                {
                    return SizedBox.Shrink();
                }

            }
            else
            {
                bool platformHasBackButton = default(bool);
                switch (ThemeDefaultClass.Theme.Of(context).Platform) { case TargetPlatform.Android: platformHasBackButton = true; break; case TargetPlatform.IOS: case TargetPlatform.MacOS: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: platformHasBackButton = false; break; }

                return new GestureDetector(key: _GestureDetectorKey, onHorizontalDragDown: _HandleDragDown, onHorizontalDragUpdate: _Move, onHorizontalDragEnd: _Settle, onHorizontalDragCancel: _HandleDragCancel, excludeFromSemantics: true, dragStartBehavior: Widget.DragStartBehavior, child: new RepaintBoundary(child: new Stack(children: new List<Widget>() { new BlockSemantics(child: new ExcludeSemantics(excluding: platformHasBackButton, child: new GestureDetector(onTap: Close, child: new Semantics(label: MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context)?.ModalBarrierDismissLabel, child: new MouseRegion(opaque: true, child: new Container(color: _ScrimColorTween.Evaluate(_Controller))))))), new Align(alignment: _DrawerOuterAlignment, child: new Align(alignment: _DrawerInnerAlignment, widthFactor: _Controller.Value, child: new RepaintBoundary(child: new FocusScope(key: _DrawerKey, node: _FocusScopeNode, child: Widget.Child)))) })));
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            return new ListTileTheme(style: ListTileStyle.Drawer, child: _BuildDrawer(context));
        }



    }


    /// <Summary>
    /// The possible alignments of a [Drawer].
    /// </Summary>
    public enum DrawerAlignment
    {

        /// <Summary>
        /// Denotes that the [Drawer] is at the start side of the [Scaffold].
        ///
        /// This corresponds to the left side when the text direction is left-to-right
        /// and the right side when the text direction is right-to-left.
        /// </Summary>
        Start,
        /// <Summary>
        /// Denotes that the [Drawer] is at the end side of the [Scaffold].
        ///
        /// This corresponds to the right side when the text direction is left-to-right
        /// and the left side when the text direction is right-to-left.
        /// </Summary>
        End,
    }

}
