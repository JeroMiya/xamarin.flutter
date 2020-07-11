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
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
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

    public class DataColumn
    {
        #region constructors
        public DataColumn(FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), string tooltip = default(string), bool numeric = false, FlutterSDK.Material.Datatable.DataColumnSortCallback onSort = default(FlutterSDK.Material.Datatable.DataColumnSortCallback))
        : base()
        {
            this.Label = label;
            this.Tooltip = tooltip;
            this.Numeric = numeric;
            this.OnSort = onSort; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public virtual string Tooltip { get; set; }
        public virtual bool Numeric { get; set; }
        public virtual FlutterSDK.Material.Datatable.DataColumnSortCallback OnSort { get; set; }
        internal virtual bool _DebugInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods
        #endregion
    }


    public class DataRow
    {
        #region constructors
        public DataRow(FlutterSDK.Foundation.Key.LocalKey key = default(FlutterSDK.Foundation.Key.LocalKey), bool selected = false, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelectChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), List<FlutterSDK.Material.Datatable.DataCell> cells = default(List<FlutterSDK.Material.Datatable.DataCell>))
        : base()
        {
            this.Key = key;
            this.Selected = selected;
            this.OnSelectChanged = onSelectChanged;
            this.Cells = cells; throw new NotImplementedException();
        }
        public static DataRow ByIndex(int index = default(int), bool selected = false, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelectChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), List<FlutterSDK.Material.Datatable.DataCell> cells = default(List<FlutterSDK.Material.Datatable.DataCell>))
        {
            var instance = new DataRow(); instance.Selected = selected;
            instance.OnSelectChanged = onSelectChanged;
            instance.Cells = cells; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnSelectChanged { get; set; }
        public virtual bool Selected { get; set; }
        public virtual List<FlutterSDK.Material.Datatable.DataCell> Cells { get; set; }
        internal virtual bool _DebugInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods
        #endregion
    }


    public class DataCell
    {
        #region constructors
        public DataCell(FlutterSDK.Widgets.Framework.Widget child, bool placeholder = false, bool showEditIcon = false, VoidCallback onTap = default(VoidCallback))
        : base()
        {
            this.Child = child;
            this.Placeholder = placeholder;
            this.ShowEditIcon = showEditIcon;
            this.OnTap = onTap; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Datatable.DataCell Empty { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual bool Placeholder { get; set; }
        public virtual bool ShowEditIcon { get; set; }
        public virtual VoidCallback OnTap { get; set; }
        internal virtual bool _DebugInteractive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods
        #endregion
    }


    public class DataTable : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
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
            this.Rows = rows; throw new NotImplementedException();
        }
        #endregion

        #region fields
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
        #endregion

        #region methods

        private int _InitOnlyTextColumn(List<FlutterSDK.Material.Datatable.DataColumn> columns) { throw new NotImplementedException(); }


        private void _HandleSelectAll(bool @checked) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildCheckbox(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), bool @checked = default(bool), VoidCallback onRowTap = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onCheckboxChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>)) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildHeadingCell(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), string tooltip = default(string), bool numeric = default(bool), VoidCallback onSort = default(VoidCallback), bool sorted = default(bool), bool ascending = default(bool)) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildDataCell(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), bool numeric = default(bool), bool placeholder = default(bool), bool showEditIcon = default(bool), VoidCallback onTap = default(VoidCallback), VoidCallback onSelectChanged = default(VoidCallback)) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class TableRowInkWell : FlutterSDK.Material.Inkwell.InkResponse
    {
        #region constructors
        public TableRowInkWell(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Tap.GestureTapCallback onDoubleTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>))
        : base(key: key, child: child, onTap: onTap, onDoubleTap: onDoubleTap, onLongPress: onLongPress, onHighlightChanged: onHighlightChanged, containedInkWell: true, highlightShape: BoxShape.Rectangle)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Material.Material.RectCallback GetRectCallback(FlutterSDK.Rendering.Box.RenderBox referenceBox) { throw new NotImplementedException(); }


        public new bool DebugCheckContext(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SortArrow : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _SortArrow(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool visible = default(bool), bool down = default(bool), TimeSpan duration = default(TimeSpan))
        : base(key: key)
        {
            this.Visible = visible;
            this.Down = down;
            this.Duration = duration; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Visible { get; set; }
        public virtual bool Down { get; set; }
        public virtual TimeSpan Duration { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Datatable._SortArrowState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _SortArrowState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Datatable._SortArrow>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _SortArrowState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _OpacityController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _OpacityAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _OrientationController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _OrientationAnimation { get; set; }
        internal virtual double _OrientationOffset { get; set; }
        internal virtual bool _Down { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _TurnTween { get; set; }
        internal virtual double _ArrowIconBaselineOffset { get; set; }
        internal virtual double _ArrowIconSize { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        private void _Rebuild() { throw new NotImplementedException(); }


        private void _ResetOrientationAnimation(FlutterSDK.Animation.Animation.AnimationStatus status) { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Datatable._SortArrow oldWidget) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }

}
