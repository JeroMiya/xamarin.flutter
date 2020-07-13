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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/scheduler.dart;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Inkdecoration;
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
        #region constructors
        public PaginatedDataTable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget header = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>), List<FlutterSDK.Material.Datatable.DataColumn> columns = default(List<FlutterSDK.Material.Datatable.DataColumn>), int sortColumnIndex = default(int), bool sortAscending = true, FlutterSDK.Foundation.Basictypes.ValueSetter<bool> onSelectAll = default(FlutterSDK.Foundation.Basictypes.ValueSetter<bool>), double dataRowHeight = default(double), double headingRowHeight = 56.0, double horizontalMargin = 24.0, double columnSpacing = 56.0, bool showCheckboxColumn = true, int initialFirstRowIndex = 0, FlutterSDK.Foundation.Basictypes.ValueChanged<int> onPageChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), int rowsPerPage = default(int), List<int> availableRowsPerPage = default(List<int>), FlutterSDK.Foundation.Basictypes.ValueChanged<int> onRowsPerPageChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), FlutterSDK.Material.Datatablesource.DataTableSource source = default(FlutterSDK.Material.Datatablesource.DataTableSource))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Framework.Widget Header { get; set; }
    public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions { get; set; }
    public virtual List<FlutterSDK.Material.Datatable.DataColumn> Columns { get; set; }
    public virtual int SortColumnIndex { get; set; }
    public virtual bool SortAscending { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueSetter<bool> OnSelectAll { get; set; }
    public virtual double DataRowHeight { get; set; }
    public virtual double HeadingRowHeight { get; set; }
    public virtual double HorizontalMargin { get; set; }
    public virtual double ColumnSpacing { get; set; }
    public virtual bool ShowCheckboxColumn { get; set; }
    public virtual int InitialFirstRowIndex { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnPageChanged { get; set; }
    public virtual int RowsPerPage { get; set; }
    public virtual int DefaultRowsPerPage { get; set; }
    public virtual List<int> AvailableRowsPerPage { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnRowsPerPageChanged { get; set; }
    public virtual FlutterSDK.Material.Datatablesource.DataTableSource Source { get; set; }
    public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Material.Paginateddatatable.PaginatedDataTableState CreateState() => new PaginatedDataTableState();


    #endregion
}


/// <Summary>
/// Holds the state of a [PaginatedDataTable].
///
/// The table can be programmatically paged using the [pageTo] method.
/// </Summary>
public class PaginatedDataTableState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Paginateddatatable.PaginatedDataTable>
{
    #region constructors
    public PaginatedDataTableState()
    { }
    #endregion

    #region fields
    internal virtual int _FirstRowIndex { get; set; }
    internal virtual int _RowCount { get; set; }
    internal virtual bool _RowCountApproximate { get; set; }
    internal virtual int _SelectedRowCount { get; set; }
    internal virtual Dictionary<int, FlutterSDK.Material.Datatable.DataRow> _Rows { get; set; }
    internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _TableKey { get; set; }
    #endregion

    #region methods

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
    PageTo(Math.Dart:mathDefaultClass.Max(_FirstRowIndex - Widget.RowsPerPage, 0));
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
        return new Card(semanticContainer: false, child: new Column(crossAxisAlignment: CrossAxisAlignment.Stretch, children: new List<Widget>() { new Semantics(container: true, child: new DefaultTextStyle(style: _SelectedRowCount > 0 ? themeData.TextTheme.Subtitle1.CopyWith(color: themeData.AccentColor) : themeData.TextTheme.Headline6.CopyWith(fontWeight: Dart:uiDefaultClass.FontWeight.W400), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(opacity: 0.54), child: new Ink(height: 64.0, color: _SelectedRowCount > 0 ? themeData.SecondaryHeaderColor : null, child: new Padding(padding: EdgeInsetsDirectional.Only(start: startPadding, end: 14.0), child: new Row(mainAxisAlignment: MainAxisAlignment.End, children: headerWidgets)))))), new SingleChildScrollView(scrollDirection: Axis.Horizontal, dragStartBehavior: Widget.DragStartBehavior, child: new ConstrainedBox(constraints: new BoxConstraints(minWidth: constraints.MinWidth), child: new DataTable(key: _TableKey, columns: Widget.Columns, sortColumnIndex: Widget.SortColumnIndex, sortAscending: Widget.SortAscending, onSelectAll: Widget.OnSelectAll, dataRowHeight: Widget.DataRowHeight, headingRowHeight: Widget.HeadingRowHeight, horizontalMargin: Widget.HorizontalMargin, columnSpacing: Widget.ColumnSpacing, rows: _GetRows(_FirstRowIndex, Widget.RowsPerPage)))), new DefaultTextStyle(style: footerTextStyle, child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(opacity: 0.54), child: new Container(height: 56.0, child: new SingleChildScrollView(dragStartBehavior: Widget.DragStartBehavior, scrollDirection: Axis.Horizontal, reverse: true, child: new Row(children: footerWidgets))))) }));
    }
    );
}



#endregion
}

}
