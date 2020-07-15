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
namespace FlutterSDK.Widgets.Draggablescrollablesheet
{
    public delegate FlutterSDK.Widgets.Framework.Widget ScrollableWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController);
    internal static class DraggablescrollablesheetDefaultClass
    {
    }

    /// <Summary>
    /// A container for a [Scrollable] that responds to drag gestures by resizing
    /// the scrollable until a limit is reached, and then scrolling.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=Hgw819mL_78}
    ///
    /// This widget can be dragged along the vertical axis between its
    /// [minChildSize], which defaults to `0.25` and [maxChildSize], which defaults
    /// to `1.0`. These sizes are percentages of the height of the parent container.
    ///
    /// The widget coordinates resizing and scrolling of the widget returned by
    /// builder as the user drags along the horizontal axis.
    ///
    /// The widget will initially be displayed at its initialChildSize which
    /// defaults to `0.5`, meaning half the height of its parent. Dragging will work
    /// between the range of minChildSize and maxChildSize (as percentages of the
    /// parent container's height) as long as the builder creates a widget which
    /// uses the provided [ScrollController]. If the widget created by the
    /// [ScrollableWidgetBuilder] does not use the provided [ScrollController], the
    /// sheet will remain at the initialChildSize.
    ///
    /// By default, the widget will expand its non-occupied area to fill available
    /// space in the parent. If this is not desired, e.g. because the parent wants
    /// to position sheet based on the space it is taking, the [expand] property
    /// may be set to false.
    ///
    /// {@tool snippet}
    ///
    /// This is a sample widget which shows a [ListView] that has 25 [ListTile]s.
    /// It starts out as taking up half the body of the [Scaffold], and can be
    /// dragged up to the full height of the scaffold or down to 25% of the height
    /// of the scaffold. Upon reaching full height, the list contents will be
    /// scrolled up or down, until they reach the top of the list again and the user
    /// drags the sheet back down.
    ///
    /// ```dart
    /// class HomePage extends StatelessWidget {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Scaffold(
    ///       appBar: AppBar(
    ///         title: const Text('DraggableScrollableSheet'),
    ///       ),
    ///       body: SizedBox.expand(
    ///         child: DraggableScrollableSheet(
    ///           builder: (BuildContext context, ScrollController scrollController) {
    ///             return Container(
    ///               color: Colors.blue[100],
    ///               child: ListView.builder(
    ///                 controller: scrollController,
    ///                 itemCount: 25,
    ///                 itemBuilder: (BuildContext context, int index) {
    ///                   return ListTile(title: Text('Item $index'));
    ///                 },
    ///               ),
    ///             );
    ///           },
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class DraggableScrollableSheet : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public DraggableScrollableSheet(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double initialChildSize = 0.5, double minChildSize = 0.25, double maxChildSize = 1.0, bool expand = true, FlutterSDK.Widgets.Draggablescrollablesheet.ScrollableWidgetBuilder builder = default(FlutterSDK.Widgets.Draggablescrollablesheet.ScrollableWidgetBuilder))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual double InitialChildSize { get; set; }
    public virtual double MinChildSize { get; set; }
    public virtual double MaxChildSize { get; set; }
    public virtual bool Expand { get; set; }
    public virtual FlutterSDK.Widgets.Draggablescrollablesheet.ScrollableWidgetBuilder Builder { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Widgets.Draggablescrollablesheet._DraggableScrollableSheetState CreateState() => new _DraggableScrollableSheetState();


    #endregion
}


/// <Summary>
/// A [Notification] related to the extent, which is the size, and scroll
/// offset, which is the position of the child list, of the
/// [DraggableScrollableSheet].
///
/// [DraggableScrollableSheet] widgets notify their ancestors when the size of
/// the sheet changes. When the extent of the sheet changes via a drag,
/// this notification bubbles up through the tree, which means a given
/// [NotificationListener] will receive notifications for all descendant
/// [DraggableScrollableSheet] widgets. To focus on notifications from the
/// nearest [DraggableScorllableSheet] descendant, check that the [depth]
/// property of the notification is zero.
///
/// When an extent notification is received by a [NotificationListener], the
/// listener will already have completed build and layout, and it is therefore
/// too late for that widget to call [State.setState]. Any attempt to adjust the
/// build or layout based on an extent notification would result in a layout
/// that lagged one frame behind, which is a poor user experience. Extent
/// notifications are used primarily to drive animations. The [Scaffold] widget
/// listens for extent notifications and responds by driving animations for the
/// [FloatingActionButton] as the bottom sheet scrolls up.
/// </Summary>
public class DraggableScrollableNotification : FlutterSDK.Widgets.Notificationlistener.Notification, IViewportNotificationMixin
{
    #region constructors
    public DraggableScrollableNotification(double extent = default(double), double minExtent = default(double), double maxExtent = default(double), double initialExtent = default(double), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext))
    : base()

}
#endregion

#region fields
public virtual double Extent { get; set; }
public virtual double MinExtent { get; set; }
public virtual double MaxExtent { get; set; }
public virtual double InitialExtent { get; set; }
public virtual FlutterSDK.Widgets.Framework.BuildContext Context { get; set; }
#endregion

#region methods

public new void DebugFillDescription(List<string> description)
{
    base.DebugFillDescription(description);
    description.Add($"'minExtent: {MinExtent}, extent: {Extent}, maxExtent: {MaxExtent}, initialExtent: {InitialExtent}'");
}



#endregion
}


/// <Summary>
/// Manages state between [_DraggableScrollableSheetState],
/// [_DraggableScrollableSheetScrollController], and
/// [_DraggableScrollableSheetScrollPosition].
///
/// The State knows the pixels available along the axis the widget wants to
/// scroll, but expects to get a fraction of those pixels to render the sheet.
///
/// The ScrollPosition knows the number of pixels a user wants to move the sheet.
///
/// The [currentExtent] will never be null.
/// The [availablePixels] will never be null, but may be `double.infinity`.
/// </Summary>
public class _DraggableSheetExtent
{
    #region constructors
    public _DraggableSheetExtent(double minExtent = default(double), double maxExtent = default(double), double initialExtent = default(double), VoidCallback listener = default(VoidCallback))
    : base()

}
#endregion

#region fields
public virtual double MinExtent { get; set; }
public virtual double MaxExtent { get; set; }
public virtual double InitialExtent { get; set; }
internal virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<double> _CurrentExtent { get; set; }
public virtual double AvailablePixels { get; set; }
public virtual bool IsAtMin { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool IsAtMax { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double CurrentExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double AdditionalMinExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double AdditionalMaxExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// The scroll position gets inputs in terms of pixels, but the extent is
/// expected to be expressed as a number between 0..1.
/// </Summary>
public virtual void AddPixelDelta(double delta, FlutterSDK.Widgets.Framework.BuildContext context)
{
    if (AvailablePixels == 0)
    {
        return;
    }

    CurrentExtent += delta / AvailablePixels * MaxExtent;
    new DraggableScrollableNotification(minExtent: MinExtent, maxExtent: MaxExtent, extent: CurrentExtent, initialExtent: InitialExtent, context: context).Dispatch(context);
}



#endregion
}


public class _DraggableScrollableSheetState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Draggablescrollablesheet.DraggableScrollableSheet>
{
    #region constructors
    public _DraggableScrollableSheetState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Widgets.Draggablescrollablesheet._DraggableScrollableSheetScrollController _ScrollController { get; set; }
    internal virtual FlutterSDK.Widgets.Draggablescrollablesheet._DraggableSheetExtent _Extent { get; set; }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        _Extent = new _DraggableSheetExtent(minExtent: Widget.MinChildSize, maxExtent: Widget.MaxChildSize, initialExtent: Widget.InitialChildSize, listener: _SetExtent);
        _ScrollController = new _DraggableScrollableSheetScrollController(extent: _Extent);
    }




    public new void DidChangeDependencies()
    {
        base.DidChangeDependencies();
        if (DraggablescrollablesheetDefaultClass._InheritedResetNotifier.ShouldReset(Context))
        {
            if (_ScrollController.Offset != 0.0)
            {
                _ScrollController.AnimateTo(0.0, duration: new TimeSpan(milliseconds: 1), curve: CurvesDefaultClass.Curves.Linear);
            }

            _Extent._CurrentExtent.Value = _Extent.InitialExtent;
        }

    }




    private void _SetExtent()
    {
        SetState(() =>
        {
        }
        );
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return new LayoutBuilder(builder: (BuildContext context, BoxConstraints constraints) =>
        {
            _Extent.AvailablePixels = Widget.MaxChildSize * constraints.Biggest.Height;
            Widget sheet = new FractionallySizedBox(heightFactor: _Extent.CurrentExtent, child: Widget.Builder(context, _ScrollController), alignment: AlignmentDefaultClass.Alignment.BottomCenter);
            return Widget.Expand ? SizedBox.Expand(child: sheet) : sheet;
        }
        );
    }




    public new void Dispose()
    {
        _ScrollController.Dispose();
        base.Dispose();
    }



    #endregion
}


/// <Summary>
/// A [ScrollController] suitable for use in a [ScrollableWidgetBuilder] created
/// by a [DraggableScrollableSheet].
///
/// If a [DraggableScrollableSheet] contains content that is exceeds the height
/// of its container, this controller will allow the sheet to both be dragged to
/// fill the container and then scroll the child content.
///
/// See also:
///
///  * [_DraggableScrollableSheetScrollPosition], which manages the positioning logic for
///    this controller.
///  * [PrimaryScrollController], which can be used to establish a
///    [_DraggableScrollableSheetScrollController] as the primary controller for
///    descendants.
/// </Summary>
public class _DraggableScrollableSheetScrollController : FlutterSDK.Widgets.Scrollcontroller.ScrollController
{
    #region constructors
    public _DraggableScrollableSheetScrollController(double initialScrollOffset = 0.0, string debugLabel = default(string), FlutterSDK.Widgets.Draggablescrollablesheet._DraggableSheetExtent extent = default(FlutterSDK.Widgets.Draggablescrollablesheet._DraggableSheetExtent))
    : base(debugLabel: debugLabel, initialScrollOffset: initialScrollOffset)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Draggablescrollablesheet._DraggableSheetExtent Extent { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Draggablescrollablesheet._DraggableScrollableSheetScrollPosition CreateScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics, FlutterSDK.Widgets.Scrollcontext.ScrollContext context, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition)
{
    return new _DraggableScrollableSheetScrollPosition(physics: physics, context: context, oldPosition: oldPosition, extent: Extent);
}




public new void DebugFillDescription(List<string> description)
{
    base.DebugFillDescription(description);
    description.Add($"'extent: {Extent}'");
}



#endregion
}


/// <Summary>
/// A scroll position that manages scroll activities for
/// [_DraggableScrollableSheetScrollController].
///
/// This class is a concrete subclass of [ScrollPosition] logic that handles a
/// single [ScrollContext], such as a [Scrollable]. An instance of this class
/// manages [ScrollActivity] instances, which changes the
/// [_DraggableSheetExtent.currentExtent] or visible content offset in the
/// [Scrollable]'s [Viewport]
///
/// See also:
///
///  * [_DraggableScrollableSheetScrollController], which uses this as its [ScrollPosition].
/// </Summary>
public class _DraggableScrollableSheetScrollPosition : FlutterSDK.Widgets.Scrollpositionwithsinglecontext.ScrollPositionWithSingleContext
{
    #region constructors
    public _DraggableScrollableSheetScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontext.ScrollContext context = default(FlutterSDK.Widgets.Scrollcontext.ScrollContext), double initialPixels = 0.0, bool keepScrollOffset = true, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition), string debugLabel = default(string), FlutterSDK.Widgets.Draggablescrollablesheet._DraggableSheetExtent extent = default(FlutterSDK.Widgets.Draggablescrollablesheet._DraggableSheetExtent))
    : base(physics: physics, context: context, initialPixels: initialPixels, keepScrollOffset: keepScrollOffset, oldPosition: oldPosition, debugLabel: debugLabel)

}
#endregion

#region fields
internal virtual VoidCallback _DragCancelCallback { get; set; }
public virtual FlutterSDK.Widgets.Draggablescrollablesheet._DraggableSheetExtent Extent { get; set; }
public virtual bool ListShouldScroll { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool ApplyContentDimensions(double minScrollExtent, double maxScrollExtent)
{
    return base.ApplyContentDimensions(minScrollExtent - Extent.AdditionalMinExtent, maxScrollExtent + Extent.AdditionalMaxExtent);
}




public new void ApplyUserOffset(double delta)
{
    if (!ListShouldScroll && (!(Extent.IsAtMin || Extent.IsAtMax) || (Extent.IsAtMin && delta < 0) || (Extent.IsAtMax && delta > 0)))
    {
        Extent.AddPixelDelta(-delta, Context.NotificationContext);
    }
    else
    {
        base.ApplyUserOffset(delta);
    }

}




public new void GoBallistic(double velocity)
{
    if (velocity == 0.0 || (velocity < 0.0 && ListShouldScroll) || (velocity > 0.0 && Extent.IsAtMax))
    {
        base.GoBallistic(velocity);
        return;
    }

    _DragCancelCallback?._DragCancelCallback();
    _DragCancelCallback = null;
    Simulation simulation = new ClampingScrollSimulation(position: Extent.CurrentExtent, velocity: velocity, tolerance: Physics.Tolerance);
    AnimationController ballisticController = AnimationController.Unbounded(debugLabel: ObjectDefaultClass.ObjectRuntimeType(this, "_DraggableScrollableSheetPosition"), vsync: Context.Vsync);
    double lastDelta = 0;
    void _Tick() => {
        double delta = ballisticController.Value - lastDelta;
        lastDelta = ballisticController.Value;
        Extent.AddPixelDelta(delta, Context.NotificationContext);
        if ((velocity > 0 && Extent.IsAtMax) || (velocity < 0 && Extent.IsAtMin))
        {
            velocity = ballisticController.Velocity + (Physics.Tolerance.Velocity * ballisticController.Velocity.Sign);
            base.GoBallistic(velocity);
            ballisticController.Stop();
        }
        else if (ballisticController.IsCompleted)
        {
            base.GoBallistic(0);
        }

    }

;
    ballisticController.AddListener(_Tick);
    ballisticController.AnimateWith(simulation).WhenCompleteOrCancel(ballisticController.Dispose);
}




public new FlutterSDK.Gestures.Drag.Drag Drag(FlutterSDK.Gestures.Dragdetails.DragStartDetails details, VoidCallback dragCancelCallback)
{
    _DragCancelCallback = dragCancelCallback;
    return base.Drag(details, dragCancelCallback);
}



#endregion
}


/// <Summary>
/// A widget that can notify a descendent [DraggableScrollableSheet] that it
/// should reset its position to the initial state.
///
/// The [Scaffold] uses this widget to notify a persistent bottom sheet that
/// the user has tapped back if the sheet has started to cover more of the body
/// than when at its initial position. This is important for users of assistive
/// technology, where dragging may be difficult to communicate.
/// </Summary>
public class DraggableScrollableActuator : FlutterSDK.Widgets.Framework.StatelessWidget
{
    #region constructors
    public DraggableScrollableActuator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
internal virtual FlutterSDK.Widgets.Draggablescrollablesheet._ResetNotifier _Notifier { get; set; }
#endregion

#region methods

/// <Summary>
/// Notifies any descendant [DraggableScrollableSheet] that it should reset
/// to its initial position.
///
/// Returns `true` if a [DraggableScrollableActuator] is available and
/// some [DraggableScrollableSheet] is listening for updates, `false`
/// otherwise.
/// </Summary>
public virtual bool Reset(FlutterSDK.Widgets.Framework.BuildContext context)
{
    _InheritedResetNotifier notifier = context.DependOnInheritedWidgetOfExactType();
    if (notifier == null)
    {
        return false;
    }

    return notifier._SendReset();
}




public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new _InheritedResetNotifier(child: Child, notifier: _Notifier);
}



#endregion
}


/// <Summary>
/// A [ChangeNotifier] to use with [InheritedResetNotifer] to notify
/// descendants that they should reset to initial state.
/// </Summary>
public class _ResetNotifier : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
{
    #region constructors
    public _ResetNotifier()
    { }
    #endregion

    #region fields
    internal virtual bool _WasCalled { get; set; }
    #endregion

    #region methods

    /// <Summary>
    /// Fires a reset notification to descendants.
    ///
    /// Returns false if there are no listeners.
    /// </Summary>
    public virtual bool SendReset()
    {
        if (!HasListeners)
        {
            return false;
        }

        _WasCalled = true;
        NotifyListeners();
        return true;
    }



    #endregion
}


public class _InheritedResetNotifier : FlutterSDK.Widgets.Inheritednotifier.InheritedNotifier<FlutterSDK.Widgets.Draggablescrollablesheet._ResetNotifier>
{
    #region constructors
    public _InheritedResetNotifier(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Draggablescrollablesheet._ResetNotifier notifier = default(FlutterSDK.Widgets.Draggablescrollablesheet._ResetNotifier))
    : base(key: key, child: child, notifier: notifier)

}
#endregion

#region fields
#endregion

#region methods

private bool _SendReset() => Notifier.SendReset();



/// <Summary>
/// Specifies whether the [DraggableScrollableSheet] should reset to its
/// initial position.
///
/// Returns true if the notifier requested a reset, false otherwise.
/// </Summary>
public virtual bool ShouldReset(FlutterSDK.Widgets.Framework.BuildContext context)
{
    InheritedWidget widget = context.DependOnInheritedWidgetOfExactType();
    if (widget == null)
    {
        return false;
    }


    _InheritedResetNotifier inheritedNotifier = widget as _InheritedResetNotifier;
    bool wasCalled = inheritedNotifier.Notifier._WasCalled;
    inheritedNotifier.Notifier._WasCalled = false;
    return wasCalled;
}



#endregion
}

}
