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
namespace FlutterSDK.Material.Reorderablelist
{
    /// <Summary>
    /// The callback used by [ReorderableListView] to move an item to a new
    /// position in a list.
    ///
    /// Implementations should remove the corresponding list item at [oldIndex]
    /// and reinsert it at [newIndex].
    ///
    /// If [oldIndex] is before [newIndex], removing the item at [oldIndex] from the
    /// list will reduce the list's length by one. Implementations used by
    /// [ReorderableListView] will need to account for this when inserting before
    /// [newIndex].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=3fB1mxOsqJE}
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// final List<MyDataObject> backingList = <MyDataObject>[/* ... */];
    ///
    /// void handleReorder(int oldIndex, int newIndex) {
    ///   if (oldIndex < newIndex) {
    ///     // removing the item at oldIndex will shorten the list by 1.
    ///     newIndex -= 1;
    ///   }
    ///   final MyDataObject element = backingList.removeAt(oldIndex);
    ///   backingList.insert(newIndex, element);
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public delegate void ReorderCallback(int oldIndex, int newIndex);
    internal static class ReorderablelistDefaultClass
    {
    }

    /// <Summary>
    /// A list whose items the user can interactively reorder by dragging.
    ///
    /// This class is appropriate for views with a small number of
    /// children because constructing the [List] requires doing work for every
    /// child that could possibly be displayed in the list view instead of just
    /// those children that are actually visible.
    ///
    /// All [children] must have a key.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=3fB1mxOsqJE}
    /// </Summary>
    public class ReorderableListView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a reorderable list.
        /// </Summary>
        public ReorderableListView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget header = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Material.Reorderablelist.ReorderCallback onReorder = default(FlutterSDK.Material.Reorderablelist.ReorderCallback), FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), bool reverse = false)
        : base(key: key)
        {
            this.Header = header;
            this.Children = children;
            this.OnReorder = onReorder;
            this.ScrollController = scrollController;
            this.ScrollDirection = scrollDirection;
            this.Padding = padding;
            this.Reverse = reverse;
        }
        /// <Summary>
        /// A non-reorderable header widget to show before the list.
        ///
        /// If null, no header will appear before the list.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Header { get; set; }
        /// <Summary>
        /// The widgets to display.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        /// <Summary>
        /// The [Axis] along which the list scrolls.
        ///
        /// List [children] can only drag along this [Axis].
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.Axis ScrollDirection { get; set; }
        /// <Summary>
        /// Creates a [ScrollPosition] to manage and determine which portion
        /// of the content is visible in the scroll view.
        ///
        /// This can be used in many ways, such as setting an initial scroll offset,
        /// (via [ScrollController.initialScrollOffset]), reading the current scroll position
        /// (via [ScrollController.offset]), or changing it (via [ScrollController.jumpTo] or
        /// [ScrollController.animateTo]).
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        /// <Summary>
        /// The amount of space by which to inset the [children].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Padding { get; set; }
        /// <Summary>
        /// Whether the scroll view scrolls in the reading direction.
        ///
        /// For example, if the reading direction is left-to-right and
        /// [scrollDirection] is [Axis.horizontal], then the scroll view scrolls from
        /// left to right when [reverse] is false and from right to left when
        /// [reverse] is true.
        ///
        /// Similarly, if [scrollDirection] is [Axis.vertical], then the scroll view
        /// scrolls from top to bottom when [reverse] is false and from bottom to top
        /// when [reverse] is true.
        ///
        /// Defaults to false.
        /// </Summary>
        public virtual bool Reverse { get; set; }
        /// <Summary>
        /// Called when a list child is dropped into a new position to shuffle the
        /// underlying list.
        ///
        /// This [ReorderableListView] calls [onReorder] after a list child is dropped
        /// into a new position.
        /// </Summary>
        public virtual FlutterSDK.Material.Reorderablelist.ReorderCallback OnReorder { get; set; }

        public new FlutterSDK.Material.Reorderablelist._ReorderableListViewState CreateState() => new _ReorderableListViewState();


    }


    public class _ReorderableListViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Reorderablelist.ReorderableListView>
    {
        public _ReorderableListViewState()
        { }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _OverlayKey { get; set; }
        internal virtual FlutterSDK.Widgets.Overlay.OverlayEntry _ListOverlayEntry { get; set; }

        public new void InitState()
        {
            base.InitState();
            _ListOverlayEntry = new OverlayEntry(opaque: true, builder: (BuildContext context) =>
            {
                return new _ReorderableListContent(header: Widget.Header, children: Widget.Children, scrollController: Widget.ScrollController, scrollDirection: Widget.ScrollDirection, onReorder: Widget.OnReorder, padding: Widget.Padding, reverse: Widget.Reverse);
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Overlay(key: _OverlayKey, initialEntries: new List<OverlayEntry>() { _ListOverlayEntry });
        }



    }


    public class _ReorderableListContent : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _ReorderableListContent(FlutterSDK.Widgets.Framework.Widget header = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Material.Reorderablelist.ReorderCallback onReorder = default(FlutterSDK.Material.Reorderablelist.ReorderCallback), bool reverse = default(bool))
        {
            this.Header = header;
            this.Children = children;
            this.ScrollController = scrollController;
            this.ScrollDirection = scrollDirection;
            this.Padding = padding;
            this.OnReorder = onReorder;
            this.Reverse = reverse;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Header { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis ScrollDirection { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Padding { get; set; }
        public virtual FlutterSDK.Material.Reorderablelist.ReorderCallback OnReorder { get; set; }
        public virtual bool Reverse { get; set; }

        public new FlutterSDK.Material.Reorderablelist._ReorderableListContentState CreateState() => new _ReorderableListContentState();


    }


    public class _ReorderableListContentState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Reorderablelist._ReorderableListContent>, ITickerProviderStateMixin<FlutterSDK.Material.Reorderablelist._ReorderableListContent>
    {
        public _ReorderableListContentState()
        { }
        internal virtual double _DefaultDropAreaExtent { get; set; }
        internal virtual double _DropAreaMargin { get; set; }
        internal virtual TimeSpan _ReorderAnimationDuration { get; set; }
        internal virtual TimeSpan _ScrollAnimationDuration { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _ScrollController { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _EntranceController { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _GhostController { get; set; }
        internal virtual FlutterSDK.Foundation.Key.Key _Dragging { get; set; }
        internal virtual Size _DraggingFeedbackSize { get; set; }
        internal virtual int _DragStartIndex { get; set; }
        internal virtual int _GhostIndex { get; set; }
        internal virtual int _CurrentIndex { get; set; }
        internal virtual int _NextIndex { get; set; }
        internal virtual bool _Scrolling { get; set; }
        internal virtual double _DropAreaExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _EntranceController = new AnimationController(vsync: this, duration: _ReorderAnimationDuration);
            _GhostController = new AnimationController(vsync: this, duration: _ReorderAnimationDuration);
            _EntranceController.AddStatusListener(_OnEntranceStatusChanged);
        }




        public new void DidChangeDependencies()
        {
            _ScrollController = Widget.ScrollController ?? PrimaryscrollcontrollerDefaultClass.PrimaryScrollController.Of(Context) ?? new ScrollController();
            base.DidChangeDependencies();
        }




        public new void Dispose()
        {
            _EntranceController.Dispose();
            _GhostController.Dispose();
            base.Dispose();
        }




        private void _RequestAnimationToNextIndex()
        {
            if (_EntranceController.IsCompleted)
            {
                _GhostIndex = _CurrentIndex;
                if (_NextIndex == _CurrentIndex)
                {
                    return;
                }

                _CurrentIndex = _NextIndex;
                _GhostController.Reverse(from: 1.0);
                _EntranceController.Forward(from: 0.0);
            }

        }




        private void _OnEntranceStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status == AnimationStatus.Completed)
            {
                SetState(() =>
                {
                    _RequestAnimationToNextIndex();
                }
                );
            }

        }




        private void _ScrollTo(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (_Scrolling) return;
            RenderObject contextObject = context.FindRenderObject();
            RenderAbstractViewport viewport = ViewportDefaultClass.RenderAbstractViewport.Of(contextObject);

            double margin = _DropAreaExtent;
            double scrollOffset = _ScrollController.Offset;
            double topOffset = Dart.Math.MathDefaultClass.Max(_ScrollController.Position.MinScrollExtent, viewport.GetOffsetToReveal(contextObject, 0.0).Offset - margin);
            double bottomOffset = Dart.Math.MathDefaultClass.Min(_ScrollController.Position.MaxScrollExtent, viewport.GetOffsetToReveal(contextObject, 1.0).Offset + margin);
            bool onScreen = scrollOffset <= topOffset && scrollOffset >= bottomOffset;
            if (!onScreen)
            {
                _Scrolling = true;
                _ScrollController.Position.AnimateTo(scrollOffset < bottomOffset ? bottomOffset : topOffset, duration: _ScrollAnimationDuration, curve: CurvesDefaultClass.Curves.EaseInOut).Then((void value) =>
                {
                    SetState(() =>
                    {
                        _Scrolling = false;
                    }
                    );
                }
                );
            }

        }




        private FlutterSDK.Widgets.Framework.Widget _BuildContainerForScrollDirection(List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        {
            switch (Widget.ScrollDirection) { case Axis.Horizontal: return new Row(children: children); case Axis.Vertical: default: return new Column(children: children); }
        }




        private FlutterSDK.Widgets.Framework.Widget _Wrap(FlutterSDK.Widgets.Framework.Widget toWrap, int index, FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {

            GlobalObjectKey keyIndexGlobalKey = new GlobalObjectKey(toWrap.Key);
            void OnDragStarted()
            {
                SetState(() =>
                {
                    _Dragging = toWrap.Key;
                    _DragStartIndex = index;
                    _GhostIndex = index;
                    _CurrentIndex = index;
                    _EntranceController.Value = 1.0;
                    _DraggingFeedbackSize = keyIndexGlobalKey.CurrentContext.Size;
                }
                );
            }

            void Reorder(int startIndex, int endIndex)
            {
                SetState(() =>
                {
                    if (startIndex != endIndex) Widget.OnReorder(startIndex, endIndex);
                    _GhostController.Reverse(from: 0.1);
                    _EntranceController.Reverse(from: 0.1);
                    _Dragging = null;
                }
                );
            }

            void OnDragEnded()
            {
                Reorder(_DragStartIndex, _CurrentIndex);
            }

            Widget WrapWithSemantics()
            {
                Dictionary<CustomSemanticsAction, VoidCallback> semanticsActions = new Dictionary<CustomSemanticsAction, VoidCallback> { };
                void MoveToStart() => Reorder(index, 0);
                void MoveToEnd() => Reorder(index, Widget.Children.Count);
                void MoveBefore() => Reorder(index, index - 1);
                void MoveAfter() => Reorder(index, index + 2);
                MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
                if (index > 0)
                {
                    semanticsActions[new CustomSemanticsAction(label: localizations.ReorderItemToStart)] = MoveToStart;
                    string reorderItemBefore = localizations.ReorderItemUp;
                    if (Widget.ScrollDirection == Axis.Horizontal)
                    {
                        reorderItemBefore = BasicDefaultClass.Directionality.Of(Context) == TextDirection.Ltr ? localizations.ReorderItemLeft : localizations.ReorderItemRight;
                    }

                    semanticsActions[new CustomSemanticsAction(label: reorderItemBefore)] = MoveBefore;
                }

                if (index < Widget.Children.Count - 1)
                {
                    string reorderItemAfter = localizations.ReorderItemDown;
                    if (Widget.ScrollDirection == Axis.Horizontal)
                    {
                        reorderItemAfter = BasicDefaultClass.Directionality.Of(Context) == TextDirection.Ltr ? localizations.ReorderItemRight : localizations.ReorderItemLeft;
                    }

                    semanticsActions[new CustomSemanticsAction(label: reorderItemAfter)] = MoveAfter;
                    semanticsActions[new CustomSemanticsAction(label: localizations.ReorderItemToEnd)] = MoveToEnd;
                }

                return new KeyedSubtree(key: keyIndexGlobalKey, child: new MergeSemantics(child: new Semantics(customSemanticsActions: semanticsActions, child: toWrap)));
            }

            Widget BuildDragTarget(BuildContext context, List<Key> acceptedCandidates, List<object> rejectedCandidates)
            {
                Widget toWrapWithSemantics = WrapWithSemantics();
                Widget child = new LongPressDraggable<Key>(maxSimultaneousDrags: 1, axis: Widget.ScrollDirection, data: toWrap.Key, ignoringFeedbackSemantics: false, feedback: new Container(alignment: AlignmentDefaultClass.Alignment.TopLeft, constraints: constraints, child: new Material(elevation: 6.0, child: toWrapWithSemantics)), child: _Dragging == toWrap.Key ? new SizedBox() : toWrapWithSemantics, childWhenDragging: new SizedBox(), dragAnchor: DragAnchor.Child, onDragStarted: OnDragStarted, onDragCompleted: OnDragEnded, onDraggableCanceled: (Velocity velocity, Offset offset) =>
                {
                    OnDragEnded();
                }
                );
                if (index >= Widget.Children.Count)
                {
                    child = toWrap;
                }

                Widget spacing = default(Widget);
                switch (Widget.ScrollDirection) { case Axis.Horizontal: spacing = new SizedBox(width: _DropAreaExtent); break; case Axis.Vertical: default: spacing = new SizedBox(height: _DropAreaExtent); break; }
                if (_CurrentIndex == index)
                {
                    return _BuildContainerForScrollDirection(children: new List<Widget>() { new SizeTransition(sizeFactor: _EntranceController, axis: Widget.ScrollDirection, child: spacing), child });
                }

                if (_GhostIndex == index)
                {
                    return _BuildContainerForScrollDirection(children: new List<Widget>() { new SizeTransition(sizeFactor: _GhostController, axis: Widget.ScrollDirection, child: spacing), child });
                }

                return child;
            }

            return new Builder(builder: (BuildContext context) =>
            {
                return new DragTarget<Key>(builder: BuildDragTarget, onWillAccept: (Key toAccept) =>
                {
                    SetState(() =>
                    {
                        _NextIndex = index;
                        _RequestAnimationToNextIndex();
                    }
                    );
                    _ScrollTo(context);
                    return _Dragging == toAccept && toAccept != toWrap.Key;
                }
                , onAccept: (Key accepted) =>
                {
                }
                , onLeave: (object leaving) =>
                {
                }
                );
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            return new LayoutBuilder(builder: (BuildContext context, BoxConstraints constraints) =>
            {
                Key endWidgetKey = new Key("DraggableList - End Widget");
                Widget finalDropArea = default(Widget);
                switch (Widget.ScrollDirection) { case Axis.Horizontal: finalDropArea = new SizedBox(key: endWidgetKey, width: _DefaultDropAreaExtent, height: constraints.MaxHeight); break; case Axis.Vertical: default: finalDropArea = new SizedBox(key: endWidgetKey, height: _DefaultDropAreaExtent, width: constraints.MaxWidth); break; }
                return new SingleChildScrollView(scrollDirection: Widget.ScrollDirection, padding: Widget.Padding, controller: _ScrollController, reverse: Widget.Reverse, child: _BuildContainerForScrollDirection(children: new List<Widget>() { }));
            }
            );
        }



    }

}
