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
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
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
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
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
using FlutterSDK.Scheduler;
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
using FlutterSDK.Widgets.Constants;
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
using FlutterSDK.Widgets.Routenotificationmessages;
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
namespace FlutterSDK.Widgets.Overscrollindicator
{
    internal static class OverscrollindicatorDefaultClass
    {
    }

    /// <Summary>
    /// A visual indication that a scroll view has overscrolled.
    ///
    /// A [GlowingOverscrollIndicator] listens for [ScrollNotification]s in order
    /// to control the overscroll indication. These notifications are typically
    /// generated by a [ScrollView], such as a [ListView] or a [GridView].
    ///
    /// [GlowingOverscrollIndicator] generates [OverscrollIndicatorNotification]
    /// before showing an overscroll indication. To prevent the indicator from
    /// showing the indication, call [OverscrollIndicatorNotification.disallowGlow]
    /// on the notification.
    ///
    /// Created automatically by [ScrollBehavior.buildViewportChrome] on platforms
    /// (e.g., Android) that commonly use this type of overscroll indication.
    ///
    /// In a [MaterialApp], the edge glow color is the [ThemeData.accentColor].
    ///
    /// When building a [CustomScrollView] with a [GlowingOverscrollIndicator], the
    /// indicator will apply to the entire scrollable area, regardless of what
    /// slivers the CustomScrollView contains.
    ///
    /// For example, if your CustomScrollView contains a SliverAppBar in the first
    /// position, the GlowingOverscrollIndicator will overlay the SliverAppBar. To
    /// manipulate the position of the GlowingOverscrollIndicator in this case, use
    /// a [NestedScrollView].
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This example demonstrates how to use a [NestedScrollView] to manipulate the
    /// placement of a [GlowingOverscrollIndicator] when building a
    /// [CustomScrollView]. Drag the scrollable to see the bounds of the overscroll
    /// indicator.
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return NestedScrollView(
    ///     headerSliverBuilder: (BuildContext context, bool innerBoxIsScrolled) {
    ///       return <Widget>[
    ///         SliverAppBar(title: Text('Custom NestedScrollViews')),
    ///       ];
    ///     },
    ///     body: CustomScrollView(
    ///       slivers: <Widget>[
    ///         SliverToBoxAdapter(
    ///           child: Container(
    ///             color: Colors.amberAccent,
    ///             height: 100,
    ///             child: Center(child: Text('Glow all day!')),
    ///           ),
    ///         ),
    ///         SliverFillRemaining(child: FlutterLogo()),
    ///       ],
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class GlowingOverscrollIndicator : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a visual indication that a scroll view has overscrolled.
        ///
        /// In order for this widget to display an overscroll indication, the [child]
        /// widget must contain a widget that generates a [ScrollNotification], such
        /// as a [ListView] or a [GridView].
        ///
        /// The [showLeading], [showTrailing], [axisDirection], [color], and
        /// [notificationPredicate] arguments must not be null.
        /// </Summary>
        public GlowingOverscrollIndicator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool showLeading = true, bool showTrailing = true, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Scrollnotification.ScrollNotificationPredicate notificationPredicate = default(FlutterSDK.Widgets.Scrollnotification.ScrollNotificationPredicate), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.ShowLeading = showLeading;
            this.ShowTrailing = showTrailing;
            this.AxisDirection = axisDirection;
            this.Color = color;
            this.NotificationPredicate = notificationPredicate;
            this.Child = child;
        }
        /// <Summary>
        /// Whether to show the overscroll glow on the side with negative scroll
        /// offsets.
        ///
        /// For a vertical downwards viewport, this is the top side.
        ///
        /// Defaults to true.
        ///
        /// See [showTrailing] for the corresponding control on the other side of the
        /// viewport.
        /// </Summary>
        public virtual bool ShowLeading { get; set; }
        /// <Summary>
        /// Whether to show the overscroll glow on the side with positive scroll
        /// offsets.
        ///
        /// For a vertical downwards viewport, this is the bottom side.
        ///
        /// Defaults to true.
        ///
        /// See [showLeading] for the corresponding control on the other side of the
        /// viewport.
        /// </Summary>
        public virtual bool ShowTrailing { get; set; }
        /// <Summary>
        /// The direction of positive scroll offsets in the [Scrollable] whose
        /// overscrolls are to be visualized.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get; set; }
        /// <Summary>
        /// The color of the glow. The alpha channel is ignored.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// A check that specifies whether a [ScrollNotification] should be
        /// handled by this widget.
        ///
        /// By default, checks whether `notification.depth == 0`. Set it to something
        /// else for more complicated layouts.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollnotification.ScrollNotificationPredicate NotificationPredicate { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// The overscroll indicator will paint on top of this child. This child (and its
        /// subtree) should include a source of [ScrollNotification] notifications.
        ///
        /// Typically a [GlowingOverscrollIndicator] is created by a
        /// [ScrollBehavior.buildViewportChrome] method, in which case
        /// the child is usually the one provided as an argument to that method.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Overscrollindicator._GlowingOverscrollIndicatorState CreateState() => new _GlowingOverscrollIndicatorState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<AxisDirection>("axisDirection", AxisDirection));
            string showDescription = default(string);
            if (ShowLeading && ShowTrailing)
            {
                showDescription = "both sides";
            }
            else if (ShowLeading)
            {
                showDescription = "leading side only";
            }
            else if (ShowTrailing)
            {
                showDescription = "trailing side only";
            }
            else
            {
                showDescription = "neither side (!)";
            }

            properties.Add(new MessageProperty("show", showDescription));
            properties.Add(new ColorProperty("color", Color, showName: false));
        }



    }


    public class _GlowingOverscrollIndicatorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Overscrollindicator.GlowingOverscrollIndicator>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _GlowingOverscrollIndicatorState()
        { }
        internal virtual FlutterSDK.Widgets.Overscrollindicator._GlowController _LeadingController { get; set; }
        internal virtual FlutterSDK.Widgets.Overscrollindicator._GlowController _TrailingController { get; set; }
        internal virtual FlutterSDK.Foundation.Changenotifier.Listenable _LeadingAndTrailingListener { get; set; }
        internal virtual Type _LastNotificationType { get; set; }
        internal virtual Dictionary<bool, bool> _Accepted { get; set; }

        public new void InitState()
        {
            base.InitState();
            _LeadingController = new _GlowController(vsync: this, color: Widget.Color, axis: Widget.Axis);
            _TrailingController = new _GlowController(vsync: this, color: Widget.Color, axis: Widget.Axis);
            _LeadingAndTrailingListener = Listenable.Merge(new List<Listenable>() { _LeadingController, _TrailingController });
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Overscrollindicator.GlowingOverscrollIndicator oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (oldWidget.Color != Widget.Color || oldWidget.Axis != Widget.Axis)
            {
                _LeadingController.Color = Widget.Color;
                _LeadingController.Axis = Widget.Axis;
                _TrailingController.Color = Widget.Color;
                _TrailingController.Axis = Widget.Axis;
            }

        }




        private bool _HandleScrollNotification(FlutterSDK.Widgets.Scrollnotification.ScrollNotification notification)
        {
            if (!Widget.NotificationPredicate(notification)) return false;
            if (notification is OverscrollNotification)
            {
                _GlowController controller = default(_GlowController);
                if (((OverscrollNotification)notification).Overscroll < 0.0)
                {
                    controller = _LeadingController;
                }
                else if (notification.Overscroll > 0.0)
                {
                    controller = _TrailingController;
                }
                else
                {

                }

                bool isLeading = controller == _LeadingController;
                if (_LastNotificationType != ScrollnotificationDefaultClass.OverscrollNotification)
                {
                    OverscrollIndicatorNotification confirmationNotification = new OverscrollIndicatorNotification(leading: isLeading);
                    confirmationNotification.Dispatch(Context);
                    _Accepted[isLeading] = confirmationNotification._Accepted;
                }



                if (_Accepted[isLeading])
                {
                    if (notification.Velocity != 0.0)
                    {

                        controller.AbsorbImpact(notification.Velocity.Abs());
                    }
                    else
                    {

                        if (notification.DragDetails != null)
                        {

                            RenderBox renderer = notification.Context.FindRenderObject() as RenderBox;


                            Size size = renderer.Size;
                            Offset position = renderer.GlobalToLocal(notification.DragDetails.GlobalPosition);
                            switch (notification.Metrics.Axis) { case Axis.Horizontal: controller.Pull(notification.Overscroll.Abs(), size.Width, position.Dy.Clamp(0.0, size.Height) as double, size.Height); break; case Axis.Vertical: controller.Pull(notification.Overscroll.Abs(), size.Height, position.Dx.Clamp(0.0, size.Width) as double, size.Width); break; }
                        }

                    }

                }

            }
            else if (notification is ScrollEndNotification || notification is ScrollUpdateNotification)
            {
                if ((((ScrollEndNotification)notification) as object).DragDetails != null)
                {
                    _LeadingController.ScrollEnd();
                    _TrailingController.ScrollEnd();
                }

            }

            _LastNotificationType = notification.GetType();
            return false;
        }




        public new void Dispose()
        {
            _LeadingController.Dispose();
            _TrailingController.Dispose();
            base.Dispose();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new NotificationListener<ScrollNotification>(onNotification: _HandleScrollNotification, child: new RepaintBoundary(child: new CustomPaint(foregroundPainter: new _GlowingOverscrollIndicatorPainter(leadingController: Widget.ShowLeading ? _LeadingController : null, trailingController: Widget.ShowTrailing ? _TrailingController : null, axisDirection: Widget.AxisDirection, repaint: _LeadingAndTrailingListener), child: new RepaintBoundary(child: Widget.Child))));
        }



    }


    public class _GlowController : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
    {
        public _GlowController(FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Basictypes.Axis axis = default(FlutterSDK.Painting.Basictypes.Axis))
        : base()
        {

            _GlowController = new AnimationController(vsync: vsync);
            new AnimationController(vsync: vsync).AddStatusListener(_ChangePhase);
            Animation<double> decelerator = new CurvedAnimation(parent: _GlowController, curve: CurvesDefaultClass.Curves.Decelerate);
            new CurvedAnimation(parent: _GlowController, curve: CurvesDefaultClass.Curves.Decelerate).AddListener(NotifyListeners);
            _GlowOpacity = decelerator.Drive(_GlowOpacityTween);
            _GlowSize = decelerator.Drive(_GlowSizeTween);
            _DisplacementTicker = vsync.CreateTicker(_TickDisplacement);
        }


        internal virtual FlutterSDK.Widgets.Overscrollindicator._GlowState _State { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _GlowControllerValue { get; set; }
        internal virtual Timer _PullRecedeTimer { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _GlowOpacityTween { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _GlowOpacity { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _GlowSizeTween { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _GlowSize { get; set; }
        internal virtual FlutterSDK.Scheduler.Ticker.Ticker _DisplacementTicker { get; set; }
        internal virtual TimeSpan _DisplacementTickerLastElapsed { get; set; }
        internal virtual double _DisplacementTarget { get; set; }
        internal virtual double _Displacement { get; set; }
        internal virtual double _PullDistance { get; set; }
        internal virtual FlutterBinding.UI.Color _Color { get; set; }
        internal virtual FlutterSDK.Painting.Basictypes.Axis _Axis { get; set; }
        internal virtual TimeSpan _RecedeTime { get; set; }
        internal virtual TimeSpan _PullTime { get; set; }
        internal virtual TimeSpan _PullHoldTime { get; set; }
        internal virtual TimeSpan _PullDecayTime { get; set; }
        internal virtual TimeSpan _CrossAxisHalfTime { get; set; }
        internal virtual double _MaxOpacity { get; set; }
        internal virtual double _PullOpacityGlowFactor { get; set; }
        internal virtual double _VelocityGlowFactor { get; set; }
        internal virtual double _Sqrt3 { get; set; }
        internal virtual double _WidthToHeightFactor { get; set; }
        internal virtual double _MinVelocity { get; set; }
        internal virtual double _MaxVelocity { get; set; }
        public virtual FlutterBinding.UI.Color Color { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Basictypes.Axis Axis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Dispose()
        {
            _GlowController.Dispose();
            _DisplacementTicker.Dispose();
            _PullRecedeTimer?.Cancel();
            base.Dispose();
        }




        /// <Summary>
        /// Handle a scroll slamming into the edge at a particular velocity.
        ///
        /// The velocity must be positive.
        /// </Summary>
        public virtual void AbsorbImpact(double velocity)
        {

            _PullRecedeTimer?.Cancel();
            _PullRecedeTimer = null;
            velocity = velocity.Clamp(_MinVelocity, _MaxVelocity) as double;
            _GlowOpacityTween.Begin = _State == _GlowState.Idle ? 0.3 : _GlowOpacity.Value;
            _GlowOpacityTween.End = (velocity * _VelocityGlowFactor).Clamp(_GlowOpacityTween.Begin, _MaxOpacity) as double;
            _GlowSizeTween.Begin = _GlowSize.Value;
            _GlowSizeTween.End = Dart.Math.MathDefaultClass.Min(0.025 + 7.5e-7 * velocity * velocity, 1.0);
            _GlowController.Duration = new TimeSpan(milliseconds: (0.15 + velocity * 0.02).Round());
            _GlowController.Forward(from: 0.0);
            _Displacement = 0.5;
            _State = _GlowState.Absorb;
        }




        /// <Summary>
        /// Handle a user-driven overscroll.
        ///
        /// The `overscroll` argument should be the scroll distance in logical pixels,
        /// the `extent` argument should be the total dimension of the viewport in the
        /// main axis in logical pixels, the `crossAxisOffset` argument should be the
        /// distance from the leading (left or top) edge of the cross axis of the
        /// viewport, and the `crossExtent` should be the size of the cross axis. For
        /// example, a pull of 50 pixels up the middle of a 200 pixel high and 100
        /// pixel wide vertical viewport should result in a call of `pull(50.0, 200.0,
        /// 50.0, 100.0)`. The `overscroll` value should be positive regardless of the
        /// direction.
        /// </Summary>
        public virtual void Pull(double overscroll, double extent, double crossAxisOffset, double crossExtent)
        {
            _PullRecedeTimer?.Cancel();
            _PullDistance += overscroll / 200.0;
            _GlowOpacityTween.Begin = _GlowOpacity.Value;
            _GlowOpacityTween.End = Dart.Math.MathDefaultClass.Min(_GlowOpacity.Value + overscroll / extent * _PullOpacityGlowFactor, _MaxOpacity);
            double height = Dart.Math.MathDefaultClass.Min(extent, crossExtent * _WidthToHeightFactor);
            _GlowSizeTween.Begin = _GlowSize.Value;
            _GlowSizeTween.End = Dart.Math.MathDefaultClass.Max(1.0 - 1.0 / (0.7 * Dart.Math.MathDefaultClass.Sqrt(_PullDistance * height)), _GlowSize.Value);
            _DisplacementTarget = crossAxisOffset / crossExtent;
            if (_DisplacementTarget != _Displacement)
            {
                if (!_DisplacementTicker.IsTicking)
                {

                    _DisplacementTicker.Start();
                }

            }
            else
            {
                _DisplacementTicker.Stop();
                _DisplacementTickerLastElapsed = null;
            }

            _GlowController.Duration = _PullTime;
            if (_State != _GlowState.Pull)
            {
                _GlowController.Forward(from: 0.0);
                _State = _GlowState.Pull;
            }
            else
            {
                if (!_GlowController.IsAnimating)
                {

                    NotifyListeners();
                }

            }

            _PullRecedeTimer = new Timer(_PullHoldTime, () => =>_Recede(_PullDecayTime));
        }




        public virtual void ScrollEnd()
        {
            if (_State == _GlowState.Pull) _Recede(_RecedeTime);
        }




        private void _ChangePhase(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status != AnimationStatus.Completed) return;
            switch (_State) { case _GlowState.Absorb: _Recede(_RecedeTime); break; case _GlowState.Recede: _State = _GlowState.Idle; _PullDistance = 0.0; break; case _GlowState.Pull: case _GlowState.Idle: break; }
        }




        private void _Recede(TimeSpan duration)
        {
            if (_State == _GlowState.Recede || _State == _GlowState.Idle) return;
            _PullRecedeTimer?.Cancel();
            _PullRecedeTimer = null;
            _GlowOpacityTween.Begin = _GlowOpacity.Value;
            _GlowOpacityTween.End = 0.0;
            _GlowSizeTween.Begin = _GlowSize.Value;
            _GlowSizeTween.End = 0.0;
            _GlowController.Duration = duration;
            _GlowController.Forward(from: 0.0);
            _State = _GlowState.Recede;
        }




        private void _TickDisplacement(TimeSpan elapsed)
        {
            if (_DisplacementTickerLastElapsed != null)
            {
                double t = (elapsed.InMicroseconds() - _DisplacementTickerLastElapsed.InMicroseconds()).ToDouble();
                _Displacement = _DisplacementTarget - (_DisplacementTarget - _Displacement) * Dart.Math.MathDefaultClass.Pow(2.0, -t / _CrossAxisHalfTime.InMicroseconds());
                NotifyListeners();
            }

            if (UtilsDefaultClass.NearEqual(_DisplacementTarget, _Displacement, ToleranceDefaultClass.Tolerance.DefaultTolerance.Distance))
            {
                _DisplacementTicker.Stop();
                _DisplacementTickerLastElapsed = null;
            }
            else
            {
                _DisplacementTickerLastElapsed = elapsed;
            }

        }




        public virtual void Paint(Canvas canvas, Size size)
        {
            if (_GlowOpacity.Value == 0.0) return;
            double baseGlowScale = size.Width > size.Height ? size.Height / size.Width : 1.0;
            double radius = size.Width * 3.0 / 2.0;
            double height = Dart.Math.MathDefaultClass.Min(size.Height, size.Width * _WidthToHeightFactor);
            double scaleY = _GlowSize.Value * baseGlowScale;
            Rect rect = Rect.FromLTWH(0.0, 0.0, size.Width, height);
            Offset center = new Offset((size.Width / 2.0) * (0.5 + _Displacement), height - radius);
            Paint paint = new Paint()..Color = Color.WithOpacity(_GlowOpacity.Value);
            canvas.Save();
            canvas.Scale(1.0, scaleY);
            canvas.ClipRect(rect);
            canvas.DrawCircle(center, radius, paint);
            canvas.Restore();
        }



    }


    public class _GlowingOverscrollIndicatorPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        public _GlowingOverscrollIndicatorPainter(FlutterSDK.Widgets.Overscrollindicator._GlowController leadingController = default(FlutterSDK.Widgets.Overscrollindicator._GlowController), FlutterSDK.Widgets.Overscrollindicator._GlowController trailingController = default(FlutterSDK.Widgets.Overscrollindicator._GlowController), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Foundation.Changenotifier.Listenable repaint = default(FlutterSDK.Foundation.Changenotifier.Listenable))
        : base(repaint: repaint)
        {
            this.LeadingController = leadingController;
            this.TrailingController = trailingController;
            this.AxisDirection = axisDirection;
        }
        /// <Summary>
        /// The controller for the overscroll glow on the side with negative scroll offsets.
        ///
        /// For a vertical downwards viewport, this is the top side.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Overscrollindicator._GlowController LeadingController { get; set; }
        /// <Summary>
        /// The controller for the overscroll glow on the side with positive scroll offsets.
        ///
        /// For a vertical downwards viewport, this is the bottom side.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Overscrollindicator._GlowController TrailingController { get; set; }
        /// <Summary>
        /// The direction of the viewport.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get; set; }
        public virtual double PiOver2 { get; set; }

        private void _PaintSide(Canvas canvas, Size size, FlutterSDK.Widgets.Overscrollindicator._GlowController controller, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection, FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection)
        {
            if (controller == null) return;
            switch (SliverDefaultClass.ApplyGrowthDirectionToAxisDirection(axisDirection, growthDirection)) { case AxisDirection.Up: controller.Paint(canvas, size); break; case AxisDirection.Down: canvas.Save(); canvas.Translate(0.0, size.Height); canvas.Scale(1.0, -1.0); controller.Paint(canvas, size); canvas.Restore(); break; case AxisDirection.Left: canvas.Save(); canvas.Rotate(PiOver2); canvas.Scale(1.0, -1.0); controller.Paint(canvas, new Size(size.Height, size.Width)); canvas.Restore(); break; case AxisDirection.Right: canvas.Save(); canvas.Translate(size.Width, 0.0); canvas.Rotate(PiOver2); controller.Paint(canvas, new Size(size.Height, size.Width)); canvas.Restore(); break; }
        }




        public new void Paint(Canvas canvas, Size size)
        {
            _PaintSide(canvas, size, LeadingController, AxisDirection, GrowthDirection.Reverse);
            _PaintSide(canvas, size, TrailingController, AxisDirection, GrowthDirection.Forward);
        }




        public new bool ShouldRepaint(FlutterSDK.Widgets.Overscrollindicator._GlowingOverscrollIndicatorPainter oldDelegate)
        {
            return oldDelegate.LeadingController != LeadingController || oldDelegate.TrailingController != TrailingController;
        }


        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            return oldDelegate.LeadingController != LeadingController || oldDelegate.TrailingController != TrailingController;
        }



    }


    /// <Summary>
    /// A notification that an [GlowingOverscrollIndicator] will start showing an
    /// overscroll indication.
    ///
    /// To prevent the indicator from showing the indication, call [disallowGlow] on
    /// the notification.
    ///
    /// See also:
    ///
    ///  * [GlowingOverscrollIndicator], which generates this type of notification.
    /// </Summary>
    public class OverscrollIndicatorNotification : FlutterSDK.Widgets.Notificationlistener.Notification, IViewportNotificationMixin
    {
        /// <Summary>
        /// Creates a notification that an [GlowingOverscrollIndicator] will start
        /// showing an overscroll indication.
        ///
        /// The [leading] argument must not be null.
        /// </Summary>
        public OverscrollIndicatorNotification(bool leading = default(bool))
        {
            this.Leading = leading;
        }
        /// <Summary>
        /// Whether the indication will be shown on the leading edge of the scroll
        /// view.
        /// </Summary>
        public virtual bool Leading { get; set; }
        internal virtual bool _Accepted { get; set; }

        /// <Summary>
        /// Call this method if the glow should be prevented.
        /// </Summary>
        public virtual void DisallowGlow()
        {
            _Accepted = false;
        }




        public new void DebugFillDescription(List<string> description)
        {
            base.DebugFillDescription(description);
            description.Add($"'side: {Leading ? "leading edge":"trailing edge"}'");
        }



    }


    public enum _GlowState
    {

        Idle,
        Absorb,
        Pull,
        Recede,
    }

}
