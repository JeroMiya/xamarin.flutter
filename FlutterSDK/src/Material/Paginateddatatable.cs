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
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
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
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Typography;
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
namespace FlutterSDK.Material.Paginateddatatable
{
    internal static class PaginateddatatableDefaultClass
    {
    }

    /// <Summary>
    /// A material design data table that shows data using multiple pages.
    ///
    /// A paginated data table shows [rowsPerPage] rows of data per page and
    /// provides controls for showing other pages.
    ///
    /// Data is read lazily from from a [DataTableSource]. The widget is presented
    /// as a [Card].
    ///
    /// See also:
    ///
    ///  * [DataTable], which is not paginated.
    ///  * <https://material.io/go/design-data-tables#data-tables-tables-within-cards>
    /// </Summary>
    public class PaginatedDataTable : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget describing a paginated [DataTable] on a [Card].
        ///
        /// The [header] should give the card's header, typically a [Text] widget. It
        /// must not be null.
        ///
        /// The [columns] argument must be a list of as many [DataColumn] objects as
        /// the table is to have columns, ignoring the leading checkbox column if any.
        /// The [columns] argument must have a length greater than zero and cannot be
        /// null.
        ///
        /// If the table is sorted, the column that provides the current primary key
        /// should be specified by index in [sortColumnIndex], 0 meaning the first
        /// column in [columns], 1 being the next one, and so forth.
        ///
        /// The actual sort order can be specified using [sortAscending]; if the sort
        /// order is ascending, this should be true (the default), otherwise it should
        /// be false.
        ///
        /// The [source] must not be null. The [source] should be a long-lived
        /// [DataTableSource]. The same source should be provided each time a
        /// particular [PaginatedDataTable] widget is created; avoid creating a new
        /// [DataTableSource] with each new instance of the [PaginatedDataTable]
        /// widget unless the data table really is to now show entirely different
        /// data from a new source.
        ///
        /// The [rowsPerPage] and [availableRowsPerPage] must not be null (they
        /// both have defaults, though, so don't have to be specified).
        /// </Summary>
        public PaginatedDataTable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget header = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), List<FlutterSDK.Material.Datatable.DataColumn> columns = default(List<FlutterSDK.Material.Datatable.DataColumn>), int sortColumnIndex = default(int), bool sortAscending = true, FlutterSDK.Foundation.Basictypes.ValueSetter<bool> onSelectAll = default(FlutterSDK.Foundation.Basictypes.ValueSetter<bool>), double dataRowHeight = default(double), double headingRowHeight = 56.0, double horizontalMargin = 24.0, double columnSpacing = 56.0, bool showCheckboxColumn = true, int initialFirstRowIndex = 0, FlutterSDK.Foundation.Basictypes.ValueChanged<int> onPageChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), int rowsPerPage = default(int), List<int> availableRowsPerPage = default(List<int>), FlutterSDK.Foundation.Basictypes.ValueChanged<int> onRowsPerPageChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), FlutterSDK.Material.Datatablesource.DataTableSource source = default(FlutterSDK.Material.Datatablesource.DataTableSource))
        : base(key: key)
        {
            this.Header = header;
            this.Actions = actions;
            this.Columns = columns;
            this.SortColumnIndex = sortColumnIndex;
            this.SortAscending = sortAscending;
            this.OnSelectAll = onSelectAll;
            this.DataRowHeight = dataRowHeight;
            this.HeadingRowHeight = headingRowHeight;
            this.HorizontalMargin = horizontalMargin;
            this.ColumnSpacing = columnSpacing;
            this.ShowCheckboxColumn = showCheckboxColumn;
            this.InitialFirstRowIndex = initialFirstRowIndex;
            this.OnPageChanged = onPageChanged;
            this.RowsPerPage = rowsPerPage;
            this.AvailableRowsPerPage = availableRowsPerPage;
            this.OnRowsPerPageChanged = onRowsPerPageChanged;
            this.DragStartBehavior = dragStartBehavior;
            this.Source = source;
        }
        /// <Summary>
        /// The table card's header.
        ///
        /// This is typically a [Text] widget, but can also be a [ButtonBar] with
        /// [FlatButton]s. Suitable defaults are automatically provided for the font,
        /// button color, button padding, and so forth.
        ///
        /// If items in the table are selectable, then, when the selection is not
        /// empty, the header is replaced by a count of the selected items.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Header { get; set; }
        /// <Summary>
        /// Icon buttons to show at the top right of the table.
        ///
        /// Typically, the exact actions included in this list will vary based on
        /// whether any rows are selected or not.
        ///
        /// These should be size 24.0 with default padding (8.0).
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
        /// <Summary>
        /// The configuration and labels for the columns in the table.
        /// </Summary>
        public virtual List<FlutterSDK.Material.Datatable.DataColumn> Columns { get; set; }
        /// <Summary>
        /// The current primary sort key's column.
        ///
        /// See [DataTable.sortColumnIndex].
        /// </Summary>
        public virtual int SortColumnIndex { get; set; }
        /// <Summary>
        /// Whether the column mentioned in [sortColumnIndex], if any, is sorted
        /// in ascending order.
        ///
        /// See [DataTable.sortAscending].
        /// </Summary>
        public virtual bool SortAscending { get; set; }
        /// <Summary>
        /// Invoked when the user selects or unselects every row, using the
        /// checkbox in the heading row.
        ///
        /// See [DataTable.onSelectAll].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueSetter<bool> OnSelectAll { get; set; }
        /// <Summary>
        /// The height of each row (excluding the row that contains column headings).
        ///
        /// This value is optional and defaults to kMinInteractiveDimension if not
        /// specified.
        /// </Summary>
        public virtual double DataRowHeight { get; set; }
        /// <Summary>
        /// The height of the heading row.
        ///
        /// This value is optional and defaults to 56.0 if not specified.
        /// </Summary>
        public virtual double HeadingRowHeight { get; set; }
        /// <Summary>
        /// The horizontal margin between the edges of the table and the content
        /// in the first and last cells of each row.
        ///
        /// When a checkbox is displayed, it is also the margin between the checkbox
        /// the content in the first data column.
        ///
        /// This value defaults to 24.0 to adhere to the Material Design specifications.
        /// </Summary>
        public virtual double HorizontalMargin { get; set; }
        /// <Summary>
        /// The horizontal margin between the contents of each data column.
        ///
        /// This value defaults to 56.0 to adhere to the Material Design specifications.
        /// </Summary>
        public virtual double ColumnSpacing { get; set; }
        /// <Summary>
        /// {@macro flutter.material.dataTable.showCheckboxColumn}
        /// </Summary>
        public virtual bool ShowCheckboxColumn { get; set; }
        /// <Summary>
        /// The index of the first row to display when the widget is first created.
        /// </Summary>
        public virtual int InitialFirstRowIndex { get; set; }
        /// <Summary>
        /// Invoked when the user switches to another page.
        ///
        /// The value is the index of the first row on the currently displayed page.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnPageChanged { get; set; }
        /// <Summary>
        /// The number of rows to show on each page.
        ///
        /// See also:
        ///
        ///  * [onRowsPerPageChanged]
        ///  * [defaultRowsPerPage]
        /// </Summary>
        public virtual int RowsPerPage { get; set; }
        /// <Summary>
        /// The default value for [rowsPerPage].
        ///
        /// Useful when initializing the field that will hold the current
        /// [rowsPerPage], when implemented [onRowsPerPageChanged].
        /// </Summary>
        public virtual int DefaultRowsPerPage { get; set; }
        /// <Summary>
        /// The options to offer for the rowsPerPage.
        ///
        /// The current [rowsPerPage] must be a value in this list.
        ///
        /// The values in this list should be sorted in ascending order.
        /// </Summary>
        public virtual List<int> AvailableRowsPerPage { get; set; }
        /// <Summary>
        /// Invoked when the user selects a different number of rows per page.
        ///
        /// If this is null, then the value given by [rowsPerPage] will be used
        /// and no affordance will be provided to change the value.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnRowsPerPageChanged { get; set; }
        /// <Summary>
        /// The data source which provides data to show in each row. Must be non-null.
        ///
        /// This object should generally have a lifetime longer than the
        /// [PaginatedDataTable] widget itself; it should be reused each time the
        /// [PaginatedDataTable] constructor is called.
        /// </Summary>
        public virtual FlutterSDK.Material.Datatablesource.DataTableSource Source { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.scrollable.dragStartBehavior}
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }

        public new FlutterSDK.Material.Paginateddatatable.PaginatedDataTableState CreateState() => new PaginatedDataTableState();


    }


    /// <Summary>
    /// Holds the state of a [PaginatedDataTable].
    ///
    /// The table can be programmatically paged using the [pageTo] method.
    /// </Summary>
    public class PaginatedDataTableState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Paginateddatatable.PaginatedDataTable>
    {
        public PaginatedDataTableState()
        { }
        internal virtual int _FirstRowIndex { get; set; }
        internal virtual int _RowCount { get; set; }
        internal virtual bool _RowCountApproximate { get; set; }
        internal virtual int _SelectedRowCount { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Material.Datatable.DataRow> _Rows { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _TableKey { get; set; }

        public new void InitState()
        {
            base.InitState();
            _FirstRowIndex = PagestorageDefaultClass.PageStorage.Of(Context)?.ReadState(Context) as int ?? Widget.InitialFirstRowIndex ?? 0;
            Widget.Source.AddListener(_HandleDataSourceChanged);
            _HandleDataSourceChanged();
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Paginateddatatable.PaginatedDataTable oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (oldWidget.Source != Widget.Source)
            {
                oldWidget.Source.RemoveListener(_HandleDataSourceChanged);
                Widget.Source.AddListener(_HandleDataSourceChanged);
                _HandleDataSourceChanged();
            }

        }




        public new void Dispose()
        {
            Widget.Source.RemoveListener(_HandleDataSourceChanged);
            base.Dispose();
        }




        private void _HandleDataSourceChanged()
        {
            SetState(() =>
            {
                _RowCount = Widget.Source.RowCount;
                _RowCountApproximate = Widget.Source.IsRowCountApproximate;
                _SelectedRowCount = Widget.Source.SelectedRowCount;
                _Rows.Clear();
            }
            );
        }




        /// <Summary>
        /// Ensures that the given row is visible.
        /// </Summary>
        public virtual void PageTo(int rowIndex)
        {
            int oldFirstRowIndex = _FirstRowIndex;
            SetState(() =>
            {
                int rowsPerPage = Widget.RowsPerPage;
                _FirstRowIndex = (rowIndex~/ rowsPerPage) * rowsPerPage;
        }
);
if ((Widget.OnPageChanged!=null )&&(oldFirstRowIndex!=_FirstRowIndex))Widget.OnPageChanged(_FirstRowIndex);
}




    private FlutterSDK.Material.Datatable.DataRow _GetBlankRowFor(int index)
    {
        return DataRow.ByIndex(index: index, cells: Widget.Columns.Map((DataColumn column) => =>DatatableDefaultClass.DataCell.Empty).ToList());
    }




    private FlutterSDK.Material.Datatable.DataRow _GetProgressIndicatorRowFor(int index)
    {
        bool haveProgressIndicator = false;
        List<DataCell> cells = Widget.Columns.Map((DataColumn column) =>
        {
            if (!column.Numeric)
            {
                haveProgressIndicator = true;
                return new DataCell(new CircularProgressIndicator());
            }

            return DatatableDefaultClass.DataCell.Empty;
        }
        ).ToList();
        if (!haveProgressIndicator)
        {
            haveProgressIndicator = true;
            cells[0] = new DataCell(new CircularProgressIndicator());
        }

        return DataRow.ByIndex(index: index, cells: cells);
    }




    private List<FlutterSDK.Material.Datatable.DataRow> _GetRows(int firstRowIndex, int rowsPerPage)
    {
        List<DataRow> result = new List<DataRow>() { };
        int nextPageFirstRowIndex = firstRowIndex + rowsPerPage;
        bool haveProgressIndicator = false;
        for (int index = firstRowIndex; index < nextPageFirstRowIndex; index += 1)
        {
            DataRow row = default(DataRow);
            if (index < _RowCount || _RowCountApproximate)
            {
                row = _Rows.PutIfAbsent(index, () => =>Widget.Source.GetRow(index));
                if (row == null && !haveProgressIndicator)
                {
                    row = (row == null ? _GetProgressIndicatorRowFor(index) : row);
                    haveProgressIndicator = true;
                }

            }

            row = (row == null ? _GetBlankRowFor(index) : row);
            result.Add(row);
        }

        return result;
    }




    private void _HandlePrevious()
    {
        PageTo(Dart.Math.MathDefaultClass.Max(_FirstRowIndex - Widget.RowsPerPage, 0));
    }




    private void _HandleNext()
    {
        PageTo(_FirstRowIndex + Widget.RowsPerPage);
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {

        ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
        MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
        List<Widget> headerWidgets = new List<Widget>() { };
        double startPadding = 24.0;
        if (_SelectedRowCount == 0)
        {
            headerWidgets.Add(new Expanded(child: Widget.Header));
            if (((ButtonBar)Widget.Header) is ButtonBar)
            {
                startPadding = 12.0;
            }

        }
        else
        {
            headerWidgets.Add(new Expanded(child: new Text(localizations.SelectedRowCountTitle(_SelectedRowCount))));
        }

        if (Widget.Actions != null)
        {
            headerWidgets.AddAll(Widget.Actions.Map((Widget action) =>
            {
                return new Padding(padding: EdgeInsetsDirectional.Only(start: 24.0 - 8.0 * 2.0), child: action);
            }
            ).ToList());
        }

        TextStyle footerTextStyle = themeData.TextTheme.Caption;
        List<Widget> footerWidgets = new List<Widget>() { };
        if (Widget.OnRowsPerPageChanged != null)
        {
            List<Widget> availableRowsPerPage = Widget.AvailableRowsPerPage.Where((int value) => =>value <= _RowCount || value == Widget.RowsPerPage).Map((int value) =>
            {
                return new DropdownMenuItem<int>(value: value, child: new Text($"'{value}'"));
            }
            ).ToList();
            footerWidgets.AddAll(new List<Widget>() { new Container(width: 14.0), new Text(localizations.RowsPerPageTitle), new ConstrainedBox(constraints: new BoxConstraints(minWidth: 64.0), child: new Align(alignment: AlignmentDefaultClass.AlignmentDirectional.CenterEnd, child: new DropdownButtonHideUnderline(child: new DropdownButton<int>(items: availableRowsPerPage.Cast(), value: Widget.RowsPerPage, onChanged: Widget.OnRowsPerPageChanged, style: footerTextStyle, iconSize: 24.0)))) });
        }

        footerWidgets.AddAll(new List<Widget>() { new Container(width: 32.0), new Text(localizations.PageRowsInfoTitle(_FirstRowIndex + 1, _FirstRowIndex + Widget.RowsPerPage, _RowCount, _RowCountApproximate)), new Container(width: 32.0), new IconButton(icon: new Icon(IconsDefaultClass.Icons.Chevron_left), padding: EdgeinsetsDefaultClass.EdgeInsets.Zero, tooltip: localizations.PreviousPageTooltip, onPressed: _FirstRowIndex <= 0 ? null : _HandlePrevious), new Container(width: 24.0), new IconButton(icon: new Icon(IconsDefaultClass.Icons.Chevron_right), padding: EdgeinsetsDefaultClass.EdgeInsets.Zero, tooltip: localizations.NextPageTooltip, onPressed: (!_RowCountApproximate && (_FirstRowIndex + Widget.RowsPerPage >= _RowCount)) ? null : _HandleNext), new Container(width: 14.0) });
        return new LayoutBuilder(builder: (BuildContext context, BoxConstraints constraints) =>
        {
            return new Card(semanticContainer: false, child: new Column(crossAxisAlignment: CrossAxisAlignment.Stretch, children: new List<Widget>() { new Semantics(container: true, child: new DefaultTextStyle(style: _SelectedRowCount > 0 ? themeData.TextTheme.Subtitle1.CopyWith(color: themeData.AccentColor) : themeData.TextTheme.Headline6.CopyWith(fontWeight: Dart.UI.UiDefaultClass.FontWeight.W400), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(opacity: 0.54), child: new Ink(height: 64.0, color: _SelectedRowCount > 0 ? themeData.SecondaryHeaderColor : null, child: new Padding(padding: EdgeInsetsDirectional.Only(start: startPadding, end: 14.0), child: new Row(mainAxisAlignment: MainAxisAlignment.End, children: headerWidgets)))))), new SingleChildScrollView(scrollDirection: Axis.Horizontal, dragStartBehavior: Widget.DragStartBehavior, child: new ConstrainedBox(constraints: new BoxConstraints(minWidth: constraints.MinWidth), child: new DataTable(key: _TableKey, columns: Widget.Columns, sortColumnIndex: Widget.SortColumnIndex, sortAscending: Widget.SortAscending, onSelectAll: Widget.OnSelectAll, dataRowHeight: Widget.DataRowHeight, headingRowHeight: Widget.HeadingRowHeight, horizontalMargin: Widget.HorizontalMargin, columnSpacing: Widget.ColumnSpacing, rows: _GetRows(_FirstRowIndex, Widget.RowsPerPage)))), new DefaultTextStyle(style: footerTextStyle, child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(opacity: 0.54), child: new Container(height: 56.0, child: new SingleChildScrollView(dragStartBehavior: Widget.DragStartBehavior, scrollDirection: Axis.Horizontal, reverse: true, child: new Row(children: footerWidgets))))) }));
        }
        );
    }



}

}
