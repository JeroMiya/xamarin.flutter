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
namespace FlutterSDK.Widgets.Table
{
    internal static class TableDefaultClass
    {
    }

    /// <Summary>
    /// A horizontal group of cells in a [Table].
    ///
    /// Every row in a table must have the same number of children.
    ///
    /// The alignment of individual cells in a row can be controlled using a
    /// [TableCell].
    /// </Summary>
    public class TableRow
    {
        /// <Summary>
        /// Creates a row in a [Table].
        /// </Summary>
        public TableRow(FlutterSDK.Foundation.Key.LocalKey key = default(FlutterSDK.Foundation.Key.LocalKey), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        {
            this.Key = key;
            this.Decoration = decoration;
            this.Children = children;
        }
        /// <Summary>
        /// An identifier for the row.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }
        /// <Summary>
        /// A decoration to paint behind this row.
        ///
        /// Row decorations fill the horizontal and vertical extent of each row in
        /// the table, unlike decorations for individual cells, which might not fill
        /// either.
        /// </Summary>
        public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
        /// <Summary>
        /// The widgets that comprise the cells in this row.
        ///
        /// Children may be wrapped in [TableCell] widgets to provide per-cell
        /// configuration to the [Table], but children are not required to be wrapped
        /// in [TableCell] widgets.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }

    }


    public class _TableElementRow
    {
        public _TableElementRow(FlutterSDK.Foundation.Key.LocalKey key = default(FlutterSDK.Foundation.Key.LocalKey), List<FlutterSDK.Widgets.Framework.Element> children = default(List<FlutterSDK.Widgets.Framework.Element>))
        {
            this.Key = key;
            this.Children = children;
        }
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Element> Children { get; set; }
    }


    /// <Summary>
    /// A widget that uses the table layout algorithm for its children.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=_lbE0wsVZSw}
    ///
    /// If you only have one row, the [Row] widget is more appropriate. If you only
    /// have one column, the [SliverList] or [Column] widgets will be more
    /// appropriate.
    ///
    /// Rows size vertically based on their contents. To control the column widths,
    /// use the [columnWidths] property.
    ///
    /// For more details about the table layout algorithm, see [RenderTable].
    /// To control the alignment of children, see [TableCell].
    ///
    /// See also:
    ///
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Table : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        /// <Summary>
        /// Creates a table.
        ///
        /// The [children], [defaultColumnWidth], and [defaultVerticalAlignment]
        /// arguments must not be null.
        /// </Summary>
        public Table(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Table.TableRow> children = default(List<FlutterSDK.Widgets.Table.TableRow>), Dictionary<int, FlutterSDK.Rendering.Table.TableColumnWidth> columnWidths = default(Dictionary<int, FlutterSDK.Rendering.Table.TableColumnWidth>), FlutterSDK.Rendering.Table.TableColumnWidth defaultColumnWidth = default(FlutterSDK.Rendering.Table.TableColumnWidth), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Tableborder.TableBorder border = default(FlutterSDK.Rendering.Tableborder.TableBorder), FlutterSDK.Rendering.Table.TableCellVerticalAlignment defaultVerticalAlignment = default(FlutterSDK.Rendering.Table.TableCellVerticalAlignment), TextBaseline textBaseline = default(TextBaseline))
        : base(key: key)
        {
            this.Children = children;
            this.ColumnWidths = columnWidths;
            this.DefaultColumnWidth = defaultColumnWidth;
            this.TextDirection = textDirection;
            this.Border = border;
            this.DefaultVerticalAlignment = defaultVerticalAlignment;
            this.TextBaseline = textBaseline;

        }


        /// <Summary>
        /// The rows of the table.
        ///
        /// Every row in a table must have the same number of children, and all the
        /// children must be non-null.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Table.TableRow> Children { get; set; }
        /// <Summary>
        /// How the horizontal extents of the columns of this table should be determined.
        ///
        /// If the [Map] has a null entry for a given column, the table uses the
        /// [defaultColumnWidth] instead. By default, that uses flex sizing to
        /// distribute free space equally among the columns.
        ///
        /// The [FixedColumnWidth] class can be used to specify a specific width in
        /// pixels. That is the cheapest way to size a table's columns.
        ///
        /// The layout performance of the table depends critically on which column
        /// sizing algorithms are used here. In particular, [IntrinsicColumnWidth] is
        /// quite expensive because it needs to measure each cell in the column to
        /// determine the intrinsic size of the column.
        /// </Summary>
        public virtual Dictionary<int, FlutterSDK.Rendering.Table.TableColumnWidth> ColumnWidths { get; set; }
        /// <Summary>
        /// How to determine with widths of columns that don't have an explicit sizing algorithm.
        ///
        /// Specifically, the [defaultColumnWidth] is used for column `i` if
        /// `columnWidths[i]` is null.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Table.TableColumnWidth DefaultColumnWidth { get; set; }
        /// <Summary>
        /// The direction in which the columns are ordered.
        ///
        /// Defaults to the ambient [Directionality].
        /// </Summary>
        public virtual TextDirection TextDirection { get; set; }
        /// <Summary>
        /// The style to use when painting the boundary and interior divisions of the table.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Tableborder.TableBorder Border { get; set; }
        /// <Summary>
        /// How cells that do not explicitly specify a vertical alignment are aligned vertically.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Table.TableCellVerticalAlignment DefaultVerticalAlignment { get; set; }
        /// <Summary>
        /// The text baseline to use when aligning rows using [TableCellVerticalAlignment.baseline].
        /// </Summary>
        public virtual TextBaseline TextBaseline { get; set; }
        internal virtual List<FlutterSDK.Painting.Decoration.Decoration> _RowDecorations { get; set; }

        public new FlutterSDK.Widgets.Table._TableElement CreateElement() => new _TableElement(this);



        public new FlutterSDK.Rendering.Table.RenderTable CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            return new RenderTable(columns: Children.IsNotEmpty ? Children[0].Children.Count : 0, rows: Children.Count, columnWidths: ColumnWidths, defaultColumnWidth: DefaultColumnWidth, textDirection: TextDirection ?? BasicDefaultClass.Directionality.Of(context), border: Border, rowDecorations: _RowDecorations, configuration: ImageDefaultClass.CreateLocalImageConfiguration(context), defaultVerticalAlignment: DefaultVerticalAlignment, textBaseline: TextBaseline);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Table.RenderTable renderObject)
        {



            ..ColumnWidths = ColumnWidths..DefaultColumnWidth = DefaultColumnWidth..TextDirection = TextDirection ?? BasicDefaultClass.Directionality.Of(context)..Border = Border..RowDecorations = _RowDecorations..Configuration = ImageDefaultClass.CreateLocalImageConfiguration(context)..DefaultVerticalAlignment = DefaultVerticalAlignment..TextBaseline = TextBaseline;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {



            ..ColumnWidths = ColumnWidths..DefaultColumnWidth = DefaultColumnWidth..TextDirection = TextDirection ?? BasicDefaultClass.Directionality.Of(context)..Border = Border..RowDecorations = _RowDecorations..Configuration = ImageDefaultClass.CreateLocalImageConfiguration(context)..DefaultVerticalAlignment = DefaultVerticalAlignment..TextBaseline = TextBaseline;
        }



    }


    public class _TableElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        public _TableElement(FlutterSDK.Widgets.Table.Table widget)
        : base(widget)
        {

        }
        internal virtual List<FlutterSDK.Widgets.Table._TableElementRow> _Children { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Framework.Element> _ForgottenChildren { get; set; }
        public virtual FlutterSDK.Widgets.Table.Table Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Table.RenderTable RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {
            base.Mount(parent, newSlot);
            _Children = Widget.Children.Map((TableRow row) =>
            {
                return new _TableElementRow(key: row.Key, children: row.Children.Map((Widget child) =>
                {

                    return InflateWidget(child, null);
                }
                ).ToList(growable: false));
            }
            ).ToList(growable: false);
            _UpdateRenderObjectChildren();
        }




        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Widgets.Framework.IndexedSlot<FlutterSDK.Widgets.Framework.Element> slot)
        {
            RenderObject.SetupParentData(child);
        }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
            RenderObject.SetupParentData(child);
        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
        }




        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {
            TableCellParentData childParentData = child.ParentData as TableCellParentData;
            RenderObject.SetChild(childParentData.x, childParentData.y, null);
        }




        public new void Update(FlutterSDK.Widgets.Table.Table newWidget)
        {
            Dictionary<LocalKey, List<Element>> oldKeyedRows = new Dictionary<LocalKey, List<Element>> { };
            foreach (_TableElementRow row in _Children)
            {
                if (row.Key != null)
                {
                    oldKeyedRows[row.Key] = row.Children;
                }

            }

            Iterator<_TableElementRow> oldUnkeyedRows = _Children.Where((_TableElementRow row) => =>row.Key == null).Iterator;
            List<_TableElementRow> newChildren = new List<_TableElementRow>() { };
            HashSet<List<Element>> taken = new Dictionary<List<Element>> { };
            foreach (TableRow row in newWidget.Children)
            {
                List<Element> oldChildren = default(List<Element>);
                if (row.Key != null && oldKeyedRows.ContainsKey(row.Key))
                {
                    oldChildren = oldKeyedRows[row.Key];
                    taken.Add(oldChildren);
                }
                else if (row.Key == null && oldUnkeyedRows.MoveNext())
                {
                    oldChildren = oldUnkeyedRows.Current.Children;
                }
                else
                {
                    oldChildren = new List<Element>() { };
                }

                newChildren.Add(new _TableElementRow(key: row.Key, children: UpdateChildren(oldChildren, row.Children, forgottenChildren: _ForgottenChildren)));
            }

            while (oldUnkeyedRows.MoveNext()) UpdateChildren(oldUnkeyedRows.Current.Children, new List<Widget>() { }, forgottenChildren: _ForgottenChildren);
            foreach (List<Element> oldChildren in oldKeyedRows.Values.Where((List<Element> list) => =>!taken.Contains(list))) UpdateChildren(oldChildren, new List<Widget>() { }, forgottenChildren: _ForgottenChildren);
            _Children = newChildren;
            _UpdateRenderObjectChildren();
            _ForgottenChildren.Clear();
            base.Update(newWidget);

        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            Dictionary<LocalKey, List<Element>> oldKeyedRows = new Dictionary<LocalKey, List<Element>> { };
            foreach (_TableElementRow row in _Children)
            {
                if (row.Key != null)
                {
                    oldKeyedRows[row.Key] = row.Children;
                }

            }

            Iterator<_TableElementRow> oldUnkeyedRows = _Children.Where((_TableElementRow row) => =>row.Key == null).Iterator;
            List<_TableElementRow> newChildren = new List<_TableElementRow>() { };
            HashSet<List<Element>> taken = new Dictionary<List<Element>> { };
            foreach (TableRow row in newWidget.Children)
            {
                List<Element> oldChildren = default(List<Element>);
                if (row.Key != null && oldKeyedRows.ContainsKey(row.Key))
                {
                    oldChildren = oldKeyedRows[row.Key];
                    taken.Add(oldChildren);
                }
                else if (row.Key == null && oldUnkeyedRows.MoveNext())
                {
                    oldChildren = oldUnkeyedRows.Current.Children;
                }
                else
                {
                    oldChildren = new List<Element>() { };
                }

                newChildren.Add(new _TableElementRow(key: row.Key, children: UpdateChildren(oldChildren, row.Children, forgottenChildren: _ForgottenChildren)));
            }

            while (oldUnkeyedRows.MoveNext()) UpdateChildren(oldUnkeyedRows.Current.Children, new List<Widget>() { }, forgottenChildren: _ForgottenChildren);
            foreach (List<Element> oldChildren in oldKeyedRows.Values.Where((List<Element> list) => =>!taken.Contains(list))) UpdateChildren(oldChildren, new List<Widget>() { }, forgottenChildren: _ForgottenChildren);
            _Children = newChildren;
            _UpdateRenderObjectChildren();
            _ForgottenChildren.Clear();
            base.Update(newWidget);

        }




        private void _UpdateRenderObjectChildren()
        {

            RenderObject.SetFlatChildren(_Children.IsNotEmpty ? _Children[0].Children.Count : 0, _Children.Expand((_TableElementRow row) =>
            {
                return row.Children.Map((Element child) =>
                {
                    RenderBox box = child.RenderObject as RenderBox;
                    return box;
                }
                );
            }
            ).ToList());
        }




        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            foreach (Element child in _Children.Expand((_TableElementRow row) => =>row.Children))
            {
                if (!_ForgottenChildren.Contains(child)) visitor(child);
            }

        }




        public new bool ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {
            _ForgottenChildren.Add(child);
            base.ForgetChild(child);
            return true;
        }



    }


    /// <Summary>
    /// A widget that controls how a child of a [Table] is aligned.
    ///
    /// A [TableCell] widget must be a descendant of a [Table], and the path from
    /// the [TableCell] widget to its enclosing [Table] must contain only
    /// [TableRow]s, [StatelessWidget]s, or [StatefulWidget]s (not
    /// other kinds of widgets, like [RenderObjectWidget]s).
    /// </Summary>
    public class TableCell : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.Table.TableCellParentData>
    {
        /// <Summary>
        /// Creates a widget that controls how a child of a [Table] is aligned.
        /// </Summary>
        public TableCell(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Table.TableCellVerticalAlignment verticalAlignment = default(FlutterSDK.Rendering.Table.TableCellVerticalAlignment), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.VerticalAlignment = verticalAlignment;
        }
        /// <Summary>
        /// How this cell is aligned vertically.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Table.TableCellVerticalAlignment VerticalAlignment { get; set; }
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            TableCellParentData parentData = renderObject.ParentData as TableCellParentData;
            if (parentData.VerticalAlignment != VerticalAlignment)
            {
                parentData.VerticalAlignment = VerticalAlignment;
                AbstractNode targetParent = renderObject.Parent;
                if (((RenderObject)targetParent) is RenderObject) ((RenderObject)targetParent).MarkNeedsLayout();
            }

        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<TableCellVerticalAlignment>("verticalAlignment", VerticalAlignment));
        }



    }

}
