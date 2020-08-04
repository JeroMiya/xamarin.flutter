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
namespace FlutterSDK.Widgets.Viewport
{
    internal static class ViewportDefaultClass
    {
    }

    /// <Summary>
    /// A widget that is bigger on the inside.
    ///
    /// [Viewport] is the visual workhorse of the scrolling machinery. It displays a
    /// subset of its children according to its own dimensions and the given
    /// [offset]. As the offset varies, different children are visible through
    /// the viewport.
    ///
    /// [Viewport] hosts a bidirectional list of slivers, anchored on a [center]
    /// sliver, which is placed at the zero scroll offset. The center widget is
    /// displayed in the viewport according to the [anchor] property.
    ///
    /// Slivers that are earlier in the child list than [center] are displayed in
    /// reverse order in the reverse [axisDirection] starting from the [center]. For
    /// example, if the [axisDirection] is [AxisDirection.down], the first sliver
    /// before [center] is placed above the [center]. The slivers that are later in
    /// the child list than [center] are placed in order in the [axisDirection]. For
    /// example, in the preceding scenario, the first sliver after [center] is
    /// placed below the [center].
    ///
    /// [Viewport] cannot contain box children directly. Instead, use a
    /// [SliverList], [SliverFixedExtentList], [SliverGrid], or a
    /// [SliverToBoxAdapter], for example.
    ///
    /// See also:
    ///
    ///  * [ListView], [PageView], [GridView], and [CustomScrollView], which combine
    ///    [Scrollable] and [Viewport] into widgets that are easier to use.
    ///  * [SliverToBoxAdapter], which allows a box widget to be placed inside a
    ///    sliver context (the opposite of this widget).
    ///  * [ShrinkWrappingViewport], a variant of [Viewport] that shrink-wraps its
    ///    contents along the main axis.
    /// </Summary>
    public class Viewport : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        /// <Summary>
        /// Creates a widget that is bigger on the inside.
        ///
        /// The viewport listens to the [offset], which means you do not need to
        /// rebuild this widget when the [offset] changes.
        ///
        /// The [offset] argument must not be null.
        /// </Summary>
        public Viewport(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), double anchor = 0.0, FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), FlutterSDK.Foundation.Key.Key center = default(FlutterSDK.Foundation.Key.Key), double cacheExtent = default(double), FlutterSDK.Rendering.Viewport.CacheExtentStyle cacheExtentStyle = default(FlutterSDK.Rendering.Viewport.CacheExtentStyle), List<FlutterSDK.Widgets.Framework.Widget> slivers = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: slivers)
        {
            this.AxisDirection = axisDirection;
            this.CrossAxisDirection = crossAxisDirection;
            this.Anchor = anchor;
            this.Offset = offset;
            this.Center = center;
            this.CacheExtent = cacheExtent;
            this.CacheExtentStyle = cacheExtentStyle;
        }
        /// <Summary>
        /// The direction in which the [offset]'s [ViewportOffset.pixels] increases.
        ///
        /// For example, if the [axisDirection] is [AxisDirection.down], a scroll
        /// offset of zero is at the top of the viewport and increases towards the
        /// bottom of the viewport.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get; set; }
        /// <Summary>
        /// The direction in which child should be laid out in the cross axis.
        ///
        /// If the [axisDirection] is [AxisDirection.down] or [AxisDirection.up], this
        /// property defaults to [AxisDirection.left] if the ambient [Directionality]
        /// is [TextDirection.rtl] and [AxisDirection.right] if the ambient
        /// [Directionality] is [TextDirection.ltr].
        ///
        /// If the [axisDirection] is [AxisDirection.left] or [AxisDirection.right],
        /// this property defaults to [AxisDirection.down].
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection CrossAxisDirection { get; set; }
        /// <Summary>
        /// The relative position of the zero scroll offset.
        ///
        /// For example, if [anchor] is 0.5 and the [axisDirection] is
        /// [AxisDirection.down] or [AxisDirection.up], then the zero scroll offset is
        /// vertically centered within the viewport. If the [anchor] is 1.0, and the
        /// [axisDirection] is [AxisDirection.right], then the zero scroll offset is
        /// on the left edge of the viewport.
        /// </Summary>
        public virtual double Anchor { get; set; }
        /// <Summary>
        /// Which part of the content inside the viewport should be visible.
        ///
        /// The [ViewportOffset.pixels] value determines the scroll offset that the
        /// viewport uses to select which part of its content to display. As the user
        /// scrolls the viewport, this value changes, which changes the content that
        /// is displayed.
        ///
        /// Typically a [ScrollPosition].
        /// </Summary>
        public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get; set; }
        /// <Summary>
        /// The first child in the [GrowthDirection.forward] growth direction.
        ///
        /// Children after [center] will be placed in the [axisDirection] relative to
        /// the [center]. Children before [center] will be placed in the opposite of
        /// the [axisDirection] relative to the [center].
        ///
        /// The [center] must be the key of a child of the viewport.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.Key Center { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.viewport.cacheExtent}
        /// </Summary>
        public virtual double CacheExtent { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.viewport.cacheExtentStyle}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Viewport.CacheExtentStyle CacheExtentStyle { get; set; }

        /// <Summary>
        /// Given a [BuildContext] and an [AxisDirection], determine the correct cross
        /// axis direction.
        ///
        /// This depends on the [Directionality] if the `axisDirection` is vertical;
        /// otherwise, the default cross axis direction is downwards.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection GetDefaultCrossAxisDirection(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection)
        {

            switch (axisDirection) { case AxisDirection.Up: return BasictypesDefaultClass.TextDirectionToAxisDirection(BasicDefaultClass.Directionality.Of(context)); case AxisDirection.Right: return AxisDirection.Down; case AxisDirection.Down: return BasictypesDefaultClass.TextDirectionToAxisDirection(BasicDefaultClass.Directionality.Of(context)); case AxisDirection.Left: return AxisDirection.Down; }
            return null;
        }




        public new FlutterSDK.Rendering.Viewport.RenderViewport CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new RenderViewport(axisDirection: AxisDirection, crossAxisDirection: CrossAxisDirection ?? ViewportDefaultClass.Viewport.GetDefaultCrossAxisDirection(context, AxisDirection), anchor: Anchor, offset: Offset, cacheExtent: CacheExtent, cacheExtentStyle: CacheExtentStyle);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Viewport.RenderViewport renderObject)
        {
            ..AxisDirection = AxisDirection..CrossAxisDirection = CrossAxisDirection ?? ViewportDefaultClass.Viewport.GetDefaultCrossAxisDirection(context, AxisDirection)..Anchor = Anchor..Offset = Offset..CacheExtent = CacheExtent..CacheExtentStyle = CacheExtentStyle;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..AxisDirection = AxisDirection..CrossAxisDirection = CrossAxisDirection ?? ViewportDefaultClass.Viewport.GetDefaultCrossAxisDirection(context, AxisDirection)..Anchor = Anchor..Offset = Offset..CacheExtent = CacheExtent..CacheExtentStyle = CacheExtentStyle;
        }




        public new FlutterSDK.Widgets.Viewport._ViewportElement CreateElement() => new _ViewportElement(this);



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<AxisDirection>("axisDirection", AxisDirection));
            properties.Add(new EnumProperty<AxisDirection>("crossAxisDirection", CrossAxisDirection, defaultValue: null));
            properties.Add(new DoubleProperty("anchor", Anchor));
            properties.Add(new DiagnosticsProperty<ViewportOffset>("offset", Offset));
            if (Center != null)
            {
                properties.Add(new DiagnosticsProperty<Key>("center", Center));
            }
            else if (Children.IsNotEmpty && Children.First.Key != null)
            {
                properties.Add(new DiagnosticsProperty<Key>("center", Children.First.Key, tooltip: "implicit"));
            }

            properties.Add(new DiagnosticsProperty<double>("cacheExtent", CacheExtent));
            properties.Add(new DiagnosticsProperty<CacheExtentStyle>("cacheExtentStyle", CacheExtentStyle));
        }



    }


    public class _ViewportElement : FlutterSDK.Widgets.Framework.MultiChildRenderObjectElement
    {
        /// <Summary>
        /// Creates an element that uses the given widget as its configuration.
        /// </Summary>
        public _ViewportElement(FlutterSDK.Widgets.Viewport.Viewport widget)
        : base(widget)
        {

        }
        public virtual FlutterSDK.Widgets.Viewport.Viewport Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Viewport.RenderViewport RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {
            base.Mount(parent, newSlot);
            _UpdateCenter();
        }




        public new void Update(FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget newWidget)
        {
            base.Update(newWidget);
            _UpdateCenter();
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);
            _UpdateCenter();
        }




        private void _UpdateCenter()
        {
            if (Widget.Center != null)
            {
                RenderObject.Center = Children.SingleWhere((Element element) => =>element.Widget.Key == Widget.Center).RenderObject as RenderSliver;
            }
            else if (Children.IsNotEmpty)
            {
                RenderObject.Center = Children.First.RenderObject as RenderSliver;
            }
            else
            {
                RenderObject.Center = null;
            }

        }




        public new void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            Children.Where((Element e) =>
            {
                RenderSliver renderSliver = e.RenderObject as RenderSliver;
                return renderSliver.Geometry.Visible;
            }
            ).ForEach(visitor);
        }



    }


    /// <Summary>
    /// A widget that is bigger on the inside and shrink wraps its children in the
    /// main axis.
    ///
    /// [ShrinkWrappingViewport] displays a subset of its children according to its
    /// own dimensions and the given [offset]. As the offset varies, different
    /// children are visible through the viewport.
    ///
    /// [ShrinkWrappingViewport] differs from [Viewport] in that [Viewport] expands
    /// to fill the main axis whereas [ShrinkWrappingViewport] sizes itself to match
    /// its children in the main axis. This shrink wrapping behavior is expensive
    /// because the children, and hence the viewport, could potentially change size
    /// whenever the [offset] changes (e.g., because of a collapsing header).
    ///
    /// [ShrinkWrappingViewport] cannot contain box children directly. Instead, use
    /// a [SliverList], [SliverFixedExtentList], [SliverGrid], or a
    /// [SliverToBoxAdapter], for example.
    ///
    /// See also:
    ///
    ///  * [ListView], [PageView], [GridView], and [CustomScrollView], which combine
    ///    [Scrollable] and [ShrinkWrappingViewport] into widgets that are easier to
    ///    use.
    ///  * [SliverToBoxAdapter], which allows a box widget to be placed inside a
    ///    sliver context (the opposite of this widget).
    ///  * [Viewport], a viewport that does not shrink-wrap its contents.
    /// </Summary>
    public class ShrinkWrappingViewport : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        /// <Summary>
        /// Creates a widget that is bigger on the inside and shrink wraps its
        /// children in the main axis.
        ///
        /// The viewport listens to the [offset], which means you do not need to
        /// rebuild this widget when the [offset] changes.
        ///
        /// The [offset] argument must not be null.
        /// </Summary>
        public ShrinkWrappingViewport(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), List<FlutterSDK.Widgets.Framework.Widget> slivers = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: slivers)
        {
            this.AxisDirection = axisDirection;
            this.CrossAxisDirection = crossAxisDirection;
            this.Offset = offset;
        }
        /// <Summary>
        /// The direction in which the [offset]'s [ViewportOffset.pixels] increases.
        ///
        /// For example, if the [axisDirection] is [AxisDirection.down], a scroll
        /// offset of zero is at the top of the viewport and increases towards the
        /// bottom of the viewport.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get; set; }
        /// <Summary>
        /// The direction in which child should be laid out in the cross axis.
        ///
        /// If the [axisDirection] is [AxisDirection.down] or [AxisDirection.up], this
        /// property defaults to [AxisDirection.left] if the ambient [Directionality]
        /// is [TextDirection.rtl] and [AxisDirection.right] if the ambient
        /// [Directionality] is [TextDirection.ltr].
        ///
        /// If the [axisDirection] is [AxisDirection.left] or [AxisDirection.right],
        /// this property defaults to [AxisDirection.down].
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection CrossAxisDirection { get; set; }
        /// <Summary>
        /// Which part of the content inside the viewport should be visible.
        ///
        /// The [ViewportOffset.pixels] value determines the scroll offset that the
        /// viewport uses to select which part of its content to display. As the user
        /// scrolls the viewport, this value changes, which changes the content that
        /// is displayed.
        ///
        /// Typically a [ScrollPosition].
        /// </Summary>
        public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get; set; }

        public new FlutterSDK.Rendering.Viewport.RenderShrinkWrappingViewport CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new RenderShrinkWrappingViewport(axisDirection: AxisDirection, crossAxisDirection: CrossAxisDirection ?? ViewportDefaultClass.Viewport.GetDefaultCrossAxisDirection(context, AxisDirection), offset: Offset);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Viewport.RenderShrinkWrappingViewport renderObject)
        {
            ..AxisDirection = AxisDirection..CrossAxisDirection = CrossAxisDirection ?? ViewportDefaultClass.Viewport.GetDefaultCrossAxisDirection(context, AxisDirection)..Offset = Offset;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..AxisDirection = AxisDirection..CrossAxisDirection = CrossAxisDirection ?? ViewportDefaultClass.Viewport.GetDefaultCrossAxisDirection(context, AxisDirection)..Offset = Offset;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<AxisDirection>("axisDirection", AxisDirection));
            properties.Add(new EnumProperty<AxisDirection>("crossAxisDirection", CrossAxisDirection, defaultValue: null));
            properties.Add(new DiagnosticsProperty<ViewportOffset>("offset", Offset));
        }



    }

}
