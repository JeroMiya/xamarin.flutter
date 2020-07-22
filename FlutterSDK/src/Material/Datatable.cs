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
namespace FlutterSDK.Material.Datatable
{
    public delegate void DataColumnSortCallback(int columnIndex, bool ascending);
    internal static class DatatableDefaultClass
    {
    }

    /// <Summary>
    /// Column configuration for a [DataTable].
    ///
    /// One column configuration must be provided for each column to
    /// display in the table. The list of [DataColumn] objects is passed
    /// as the `columns` argument to the [new DataTable] constructor.
    /// </Summary>
    public class DataColumn
    {
        public DataColumn(FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), string tooltip = default(string), bool numeric = false, FlutterSDK.Material.Datatable.DataColumnSortCallback onSort = default(FlutterSDK.Material.Datatable.DataColumnSortCallback))
        : base()
        {
            this.Label = label;
            this.Tooltip = tooltip;
            this.Numeric = numeric;
            this.OnSort = onSort;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public virtual string Tooltip { get; set; }
        public virtual bool Numeric { get; set; }
        public virtual FlutterSDK.Material.Datatable.DataColumnSortCallback OnSort { get; set; }
        internal virtual bool _DebugInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    /// <Summary>
    /// Row configuration and cell data for a [DataTable].
    ///
    /// One row configuration must be provided for each row to
    /// display in the table. The list of [DataRow] objects is passed
    /// as the `rows` argument to the [new DataTable] constructor.
    ///
    /// The data for this row of the table is provided in the [cells]
    /// property of the [DataRow] object.
    /// </Summary>
    public class DataRow
    {
        public DataRow(FlutterSDK.Foundation.Key.LocalKey key = default(FlutterSDK.Foundation.Key.LocalKey), bool selected = false, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelectChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), List<FlutterSDK.Material.Datatable.DataCell> cells = default(List<FlutterSDK.Material.Datatable.DataCell>))
        : base()
        {
            this.Key = key;
            this.Selected = selected;
            this.OnSelectChanged = onSelectChanged;
            this.Cells = cells;
        }
        public static DataRow ByIndex(int index = default(int), bool selected = false, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelectChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), List<FlutterSDK.Material.Datatable.DataCell> cells = default(List<FlutterSDK.Material.Datatable.DataCell>))
        {
            var instance = new DataRow(); instance.Selected = selected;
            instance.OnSelectChanged = onSelectChanged;
            instance.Cells = cells;
        }
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnSelectChanged { get; set; }
        public virtual bool Selected { get; set; }
        public virtual List<FlutterSDK.Material.Datatable.DataCell> Cells { get; set; }
        internal virtual bool _DebugInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    /// <Summary>
    /// The data for a cell of a [DataTable].
    ///
    /// One list of [DataCell] objects must be provided for each [DataRow]
    /// in the [DataTable], in the [new DataRow] constructor's `cells`
    /// argument.
    /// </Summary>
    public class DataCell
    {
        public DataCell(FlutterSDK.Widgets.Framework.Widget child, bool placeholder = false, bool showEditIcon = false, VoidCallback onTap = default(VoidCallback))
        : base()
        {
            this.Child = child;
            this.Placeholder = placeholder;
            this.ShowEditIcon = showEditIcon;
            this.OnTap = onTap;
        }
        public virtual FlutterSDK.Material.Datatable.DataCell Empty { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual bool Placeholder { get; set; }
        public virtual bool ShowEditIcon { get; set; }
        public virtual VoidCallback OnTap { get; set; }
        internal virtual bool _DebugInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    /// <Summary>
    /// A material design data table.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=ktTajqbhIcY}
    ///
    /// Displaying data in a table is expensive, because to lay out the
    /// table all the data must be measured twice, once to negotiate the
    /// dimensions to use for each column, and once to actually lay out
    /// the table given the results of the negotiation.
    ///
    /// For this reason, if you have a lot of data (say, more than a dozen
    /// rows with a dozen columns, though the precise limits depend on the
    /// target device), it is suggested that you use a
    /// [PaginatedDataTable] which automatically splits the data into
    /// multiple pages.
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This sample shows how to display a [DataTable] with three columns: name, age, and
    /// role. The columns are defined by three [DataColumn] objects. The table
    /// contains three rows of data for three example users, the data for which
    /// is defined by three [DataRow] objects.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/data_table.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return DataTable(
    ///     columns: const <DataColumn>[
    ///       DataColumn(
    ///         label: Text(
    ///           'Name',
    ///           style: TextStyle(fontStyle: FontStyle.italic),
    ///         ),
    ///       ),
    ///       DataColumn(
    ///         label: Text(
    ///           'Age',
    ///           style: TextStyle(fontStyle: FontStyle.italic),
    ///         ),
    ///       ),
    ///       DataColumn(
    ///         label: Text(
    ///           'Role',
    ///           style: TextStyle(fontStyle: FontStyle.italic),
    ///         ),
    ///       ),
    ///     ],
    ///     rows: const <DataRow>[
    ///       DataRow(
    ///         cells: <DataCell>[
    ///           DataCell(Text('Sarah')),
    ///           DataCell(Text('19')),
    ///           DataCell(Text('Student')),
    ///         ],
    ///       ),
    ///       DataRow(
    ///         cells: <DataCell>[
    ///           DataCell(Text('Janine')),
    ///           DataCell(Text('43')),
    ///           DataCell(Text('Professor')),
    ///         ],
    ///       ),
    ///       DataRow(
    ///         cells: <DataCell>[
    ///           DataCell(Text('William')),
    ///           DataCell(Text('27')),
    ///           DataCell(Text('Associate Professor')),
    ///         ],
    ///       ),
    ///     ],
    ///   );
    /// }
    /// ```
    ///
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [DataColumn], which describes a column in the data table.
    ///  * [DataRow], which contains the data for a row in the data table.
    ///  * [DataCell], which contains the data for a single cell in the data table.
    ///  * [PaginatedDataTable], which shows part of the data in a data table and
    ///    provides controls for paging through the remainder of the data.
    ///  * <https://material.io/design/components/data-tables.html>
    /// </Summary>
    public class DataTable : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public DataTable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Material.Datatable.DataColumn> columns = default(List<FlutterSDK.Material.Datatable.DataColumn>), int sortColumnIndex = default(int), bool sortAscending = true, FlutterSDK.Foundation.Basictypes.ValueSetter<bool> onSelectAll = default(FlutterSDK.Foundation.Basictypes.ValueSetter<bool>), double dataRowHeight = default(double), double headingRowHeight = 56.0, double horizontalMargin = 24.0, double columnSpacing = 56.0, bool showCheckboxColumn = true, double dividerThickness = 1.0, List<FlutterSDK.Material.Datatable.DataRow> rows = default(List<FlutterSDK.Material.Datatable.DataRow>))
        : base(key: key)
        {
            this.Columns = columns;
            this.SortColumnIndex = sortColumnIndex;
            this.SortAscending = sortAscending;
            this.OnSelectAll = onSelectAll;
            this.DataRowHeight = dataRowHeight;
            this.HeadingRowHeight = headingRowHeight;
            this.HorizontalMargin = horizontalMargin;
            this.ColumnSpacing = columnSpacing;
            this.ShowCheckboxColumn = showCheckboxColumn;
            this.DividerThickness = dividerThickness;
            this.Rows = rows;
        }
        public virtual List<FlutterSDK.Material.Datatable.DataColumn> Columns { get; set; }
        public virtual int SortColumnIndex { get; set; }
        public virtual bool SortAscending { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueSetter<bool> OnSelectAll { get; set; }
        public virtual double DataRowHeight { get; set; }
        public virtual double HeadingRowHeight { get; set; }
        public virtual double HorizontalMargin { get; set; }
        public virtual double ColumnSpacing { get; set; }
        public virtual bool ShowCheckboxColumn { get; set; }
        public virtual List<FlutterSDK.Material.Datatable.DataRow> Rows { get; set; }
        internal virtual int _OnlyTextColumn { get; set; }
        internal virtual FlutterSDK.Foundation.Key.LocalKey _HeadingRowKey { get; set; }
        internal virtual double _SortArrowPadding { get; set; }
        internal virtual double _HeadingFontSize { get; set; }
        internal virtual TimeSpan _SortArrowAnimationDuration { get; set; }
        internal virtual FlutterBinding.UI.Color _Grey100Opacity { get; set; }
        internal virtual FlutterBinding.UI.Color _Grey300Opacity { get; set; }
        public virtual double DividerThickness { get; set; }
        internal virtual bool _DebugInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private int _InitOnlyTextColumn(List<FlutterSDK.Material.Datatable.DataColumn> columns)
        {
            int result = default(int);
            for (int index = 0; index < columns.Count; index += 1)
            {
                DataColumn column = columns[index];
                if (!column.Numeric)
                {
                    if (result != null) return null;
                    result = index;
                }

            }

            return result;
        }




        private void _HandleSelectAll(bool @checked)
        {
            if (OnSelectAll != null)
            {
                OnSelectAll(checked);
            }
            else
            {
                foreach (DataRow row in Rows)
                {
                    if ((row.OnSelectChanged != null) && (row.Selected != checked))row.OnSelectChanged(checked);
                }

            }

        }




        private FlutterSDK.Widgets.Framework.Widget _BuildCheckbox(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), bool @checked = default(bool), VoidCallback onRowTap = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onCheckboxChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>))
        {
            Widget contents = new Semantics(container: true, child: new Padding(padding: EdgeInsetsDirectional.Only(start: HorizontalMargin, end: HorizontalMargin / 2.0), child: new Center(child: new Checkbox(activeColor: color, value: @checked, onChanged: onCheckboxChanged))));
            if (onRowTap != null)
            {
                contents = new TableRowInkWell(onTap: onRowTap, child: contents);
            }

            return new TableCell(verticalAlignment: TableCellVerticalAlignment.Fill, child: contents);
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildHeadingCell(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), string tooltip = default(string), bool numeric = default(bool), VoidCallback onSort = default(VoidCallback), bool sorted = default(bool), bool ascending = default(bool))
        {
            List<Widget> ArrowWithPadding()
            {
                return onSort == null ? new List<Widget>() { } : new List<Widget>() { new _SortArrow(visible: sorted, down: sorted ? ascending : null, duration: _SortArrowAnimationDuration), new SizedBox(width: _SortArrowPadding) };
            }

            label = new Row(textDirection: numeric ? TextDirection.Rtl : null, children: new List<Widget>() { label,  /* ...ArrowWithPadding() */});
            label = new Container(padding: padding, height: HeadingRowHeight, alignment: numeric ? AlignmentDefaultClass.Alignment.CenterRight : AlignmentDefaultClass.AlignmentDirectional.CenterStart, child: new AnimatedDefaultTextStyle(style: new TextStyle(fontWeight: Dart:uiDefaultClass.FontWeight.W500, fontSize: _HeadingFontSize, height: Math.Dart:mathDefaultClass.Min(1.0, HeadingRowHeight / _HeadingFontSize), color: (ThemeDefaultClass.Theme.Of(context).Brightness == Brightness.Light) ? ((onSort != null && sorted) ? ColorsDefaultClass.Colors.Black87 : ColorsDefaultClass.Colors.Black54) : ((onSort != null && sorted) ? ColorsDefaultClass.Colors.White : ColorsDefaultClass.Colors.White70)), softWrap: false, duration: _SortArrowAnimationDuration, child: label));
            if (tooltip != null)
            {
                label = new Tooltip(message: tooltip, child: label);
            }

            label = new InkWell(onTap: onSort, child: label);
            return label;
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildDataCell(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), bool numeric = default(bool), bool placeholder = default(bool), bool showEditIcon = default(bool), VoidCallback onTap = default(VoidCallback), VoidCallback onSelectChanged = default(VoidCallback))
        {
            bool isLightTheme = ThemeDefaultClass.Theme.Of(context).Brightness == Brightness.Light;
            if (showEditIcon)
            {
                Widget icon = new Icon(IconsDefaultClass.Icons.Edit, size: 18.0);
                label = new Expanded(child: label);
                label = new Row(textDirection: numeric ? TextDirection.Rtl : null, children: new List<Widget>() { label, icon });
            }

            label = new Container(padding: padding, height: DataRowHeight, alignment: numeric ? AlignmentDefaultClass.Alignment.CenterRight : AlignmentDefaultClass.AlignmentDirectional.CenterStart, child: new DefaultTextStyle(style: new TextStyle(fontSize: 13.0, color: isLightTheme ? (placeholder ? ColorsDefaultClass.Colors.Black38 : ColorsDefaultClass.Colors.Black87) : (placeholder ? ColorsDefaultClass.Colors.White38 : ColorsDefaultClass.Colors.White70)), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(color: isLightTheme ? ColorsDefaultClass.Colors.Black54 : ColorsDefaultClass.Colors.White70), child: new DropdownButtonHideUnderline(child: label))));
            if (onTap != null)
            {
                label = new InkWell(onTap: onTap, child: label);
            }
            else if (onSelectChanged != null)
            {
                label = new TableRowInkWell(onTap: onSelectChanged, child: label);
            }

            return label;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            BoxDecoration _kSelectedDecoration = new BoxDecoration(border: new Border(bottom: DividerDefaultClass.Divider.CreateBorderSide(context, width: DividerThickness)), color: (ThemeDefaultClass.Theme.Of(context).Brightness == Brightness.Light) ? _Grey100Opacity : _Grey300Opacity);
            BoxDecoration _kUnselectedDecoration = new BoxDecoration(border: new Border(bottom: DividerDefaultClass.Divider.CreateBorderSide(context, width: DividerThickness)));
            bool displayCheckboxColumn = ShowCheckboxColumn && Rows.Any((DataRow row) => =>row.OnSelectChanged != null);
            bool allChecked = displayCheckboxColumn && !Rows.Any((DataRow row) => =>row.OnSelectChanged != null && !row.Selected);
            List<TableColumnWidth> tableColumns = new List<TableColumnWidth>(Columns.Count + (displayCheckboxColumn ? 1 : 0));
            List<TableRow> tableRows = List<TableRow>.Generate(Rows.Count + 1, (int index) =>
            {
                return new TableRow(key: index == 0 ? _HeadingRowKey : Rows[index - 1].Key, decoration: index > 0 && Rows[index - 1].Selected ? _kSelectedDecoration : _kUnselectedDecoration, children: new List<Widget>(tableColumns.Count));
            }
            );
            int rowIndex = default(int);
            int displayColumnIndex = 0;
            if (displayCheckboxColumn)
            {
                tableColumns[0] = new FixedColumnWidth(HorizontalMargin + CheckboxDefaultClass.Checkbox.Width + HorizontalMargin / 2.0);
                tableRows[0].Children[0] = _BuildCheckbox(color: theme.AccentColor, @checked: allChecked, onCheckboxChanged: _HandleSelectAll);
                rowIndex = 1;
                foreach (DataRow row in Rows)
                {
                    tableRows[rowIndex].Children[0] = _BuildCheckbox(color: theme.AccentColor, @checked: row.Selected, onRowTap: () => =>row.OnSelectChanged != null ? row.OnSelectChanged(!row.Selected) : null, onCheckboxChanged: row.OnSelectChanged);
                    rowIndex += 1;
                }

                displayColumnIndex += 1;
            }

            for (int dataColumnIndex = 0; dataColumnIndex < Columns.Count; dataColumnIndex += 1)
            {
                DataColumn column = Columns[dataColumnIndex];
                double paddingStart = default(double);
                if (dataColumnIndex == 0 && displayCheckboxColumn)
                {
                    paddingStart = HorizontalMargin / 2.0;
                }
                else if (dataColumnIndex == 0 && !displayCheckboxColumn)
                {
                    paddingStart = HorizontalMargin;
                }
                else
                {
                    paddingStart = ColumnSpacing / 2.0;
                }

                double paddingEnd = default(double);
                if (dataColumnIndex == Columns.Count - 1)
                {
                    paddingEnd = HorizontalMargin;
                }
                else
                {
                    paddingEnd = ColumnSpacing / 2.0;
                }

                EdgeInsetsDirectional padding = EdgeInsetsDirectional.Only(start: paddingStart, end: paddingEnd);
                if (dataColumnIndex == _OnlyTextColumn)
                {
                    tableColumns[displayColumnIndex] = new IntrinsicColumnWidth(flex: 1.0);
                }
                else
                {
                    tableColumns[displayColumnIndex] = new IntrinsicColumnWidth();
                }

                tableRows[0].Children[displayColumnIndex] = _BuildHeadingCell(context: context, padding: padding, label: column.Label, tooltip: column.Tooltip, numeric: column.Numeric, onSort: column.OnSort != null ? () => =>column.OnSort(dataColumnIndex, SortColumnIndex != dataColumnIndex || !SortAscending):null, sorted: dataColumnIndex == SortColumnIndex, ascending: SortAscending);
                rowIndex = 1;
                foreach (DataRow row in Rows)
                {
                    DataCell cell = row.Cells[dataColumnIndex];
                    tableRows[rowIndex].Children[displayColumnIndex] = _BuildDataCell(context: context, padding: padding, label: cell.Child, numeric: column.Numeric, placeholder: cell.Placeholder, showEditIcon: cell.ShowEditIcon, onTap: cell.OnTap, onSelectChanged: () => =>row.OnSelectChanged != null ? row.OnSelectChanged(!row.Selected) : null);
                    rowIndex += 1;
                }

                displayColumnIndex += 1;
            }

            return new Table(columnWidths: tableColumns.AsMap(), children: tableRows);
        }



    }


    /// <Summary>
    /// A rectangular area of a Material that responds to touch but clips
    /// its ink splashes to the current table row of the nearest table.
    ///
    /// Must have an ancestor [Material] widget in which to cause ink
    /// reactions and an ancestor [Table] widget to establish a row.
    ///
    /// The [TableRowInkWell] must be in the same coordinate space (modulo
    /// translations) as the [Table]. If it's rotated or scaled or
    /// otherwise transformed, it will not be able to describe the
    /// rectangle of the row in its own coordinate system as a [Rect], and
    /// thus the splash will not occur. (In general, this is easy to
    /// achieve: just put the [TableRowInkWell] as the direct child of the
    /// [Table], and put the other contents of the cell inside it.)
    /// </Summary>
    public class TableRowInkWell : FlutterSDK.Material.Inkwell.InkResponse
    {
        public TableRowInkWell(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Tap.GestureTapCallback onDoubleTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>))
        : base(key: key, child: child, onTap: onTap, onDoubleTap: onDoubleTap, onLongPress: onLongPress, onHighlightChanged: onHighlightChanged, containedInkWell: true, highlightShape: BoxShape.Rectangle)
        {

        }

        public new FlutterSDK.Material.Material.RectCallback GetRectCallback(FlutterSDK.Rendering.Box.RenderBox referenceBox)
        {
            return () =>
            {
                RenderObject cell = referenceBox;
                AbstractNode table = cell.Parent;
                Matrix4 transform = Matrix4.Identity();
                while (table is RenderObject && !(table is RenderTable))
                {
                    RenderObject parentBox = table as RenderObject;
                    parentBox.ApplyPaintTransform(cell, transform);

                    cell = parentBox;
                    table = table.Parent;
                }

                if (table is RenderTable)
                {
                    TableCellParentData cellParentData = cell.ParentData as TableCellParentData;

                    Rect rect = ((RenderObject)table).GetRowBox(cellParentData.y);
                    ((RenderObject)table).ApplyPaintTransform(cell, transform);
                    Offset offset = MatrixutilsDefaultClass.MatrixUtils.GetAsTranslation(transform);
                    if (offset != null) return rect.Shift(-offset);
                }

                return Dart:uiDefaultClass.Rect.Zero;
            }
            ;
        }




        public new bool DebugCheckContext(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            return base.DebugCheckContext(context);
        }



    }


    public class _SortArrow : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _SortArrow(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool visible = default(bool), bool down = default(bool), TimeSpan duration = default(TimeSpan))
        : base(key: key)
        {
            this.Visible = visible;
            this.Down = down;
            this.Duration = duration;
        }
        public virtual bool Visible { get; set; }
        public virtual bool Down { get; set; }
        public virtual TimeSpan Duration { get; set; }

        public new FlutterSDK.Material.Datatable._SortArrowState CreateState() => new _SortArrowState();


    }


    public class _SortArrowState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Datatable._SortArrow>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _SortArrowState()
        { }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _OpacityController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _OpacityAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _OrientationController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _OrientationAnimation { get; set; }
        internal virtual double _OrientationOffset { get; set; }
        internal virtual bool _Down { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _TurnTween { get; set; }
        internal virtual double _ArrowIconBaselineOffset { get; set; }
        internal virtual double _ArrowIconSize { get; set; }

        public new void InitState()
        {
            base.InitState();
            _OpacityAnimation = new CurvedAnimation(parent: _OpacityController = new AnimationController(duration: Widget.Duration, vsync: this), curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            new CurvedAnimation(parent: _OpacityController = new AnimationController(duration: Widget.Duration, vsync: this), curve: CurvesDefaultClass.Curves.FastOutSlowIn).AddListener(_Rebuild);
            _OpacityController.Value = Widget.Visible ? 1.0 : 0.0;
            _OrientationController = new AnimationController(duration: Widget.Duration, vsync: this);
            _OrientationAnimation = _OrientationController.Drive(_TurnTween);
            _OrientationController.Drive(_TurnTween).AddListener(_Rebuild);
            _OrientationController.Drive(_TurnTween).AddStatusListener(_ResetOrientationAnimation);
            if (Widget.Visible) _OrientationOffset = Widget.Down ? 0.0 : Math.Dart:mathDefaultClass.Pi;
        }




        private void _Rebuild()
        {
            SetState(() =>
            {
            }
            );
        }




        private void _ResetOrientationAnimation(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status == AnimationStatus.Completed)
            {

                _OrientationOffset += Math.Dart:mathDefaultClass.Pi;
                _OrientationController.Value = 0.0;
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Material.Datatable._SortArrow oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            bool skipArrow = false;
            bool newDown = Widget.Down ?? _Down;
            if (oldWidget.Visible != Widget.Visible)
            {
                if (Widget.Visible && (_OpacityController.Status == AnimationStatus.Dismissed))
                {
                    _OrientationController.Stop();
                    _OrientationController.Value = 0.0;
                    _OrientationOffset = newDown ? 0.0 : Math.Dart:mathDefaultClass.Pi;
                    skipArrow = true;
                }

                if (Widget.Visible)
                {
                    _OpacityController.Forward();
                }
                else
                {
                    _OpacityController.Reverse();
                }

            }

            if ((_Down != newDown) && !skipArrow)
            {
                if (_OrientationController.Status == AnimationStatus.Dismissed)
                {
                    _OrientationController.Forward();
                }
                else
                {
                    _OrientationController.Reverse();
                }

            }

            _Down = newDown;
        }




        public new void Dispose()
        {
            _OpacityController.Dispose();
            _OrientationController.Dispose();
            base.Dispose();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Opacity(opacity: _OpacityAnimation.Value, child: new Transform(transform: Matrix4.RotationZ(_OrientationOffset + _OrientationAnimation.Value);
            Matrix4.RotationZ(_OrientationOffset + _OrientationAnimation.Value).SetTranslationRaw(0.0, _ArrowIconBaselineOffset, 0.0), alignment: AlignmentDefaultClass.Alignment.Center, child: new Icon(IconsDefaultClass.Icons.Arrow_downward, size: _ArrowIconSize, color: (ThemeDefaultClass.Theme.Of(context).Brightness == Brightness.Light) ? ColorsDefaultClass.Colors.Black87 : ColorsDefaultClass.Colors.White70)));
        }



    }

}
