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
namespace FlutterSDK.Rendering.Table
{
    internal static class TableDefaultClass
    {
    }

    /// <Summary>
    /// Base class to describe how wide a column in a [RenderTable] should be.
    ///
    /// To size a column to a specific number of pixels, use a [FixedColumnWidth].
    /// This is the cheapest way to size a column.
    ///
    /// Other algorithms that are relatively cheap include [FlexColumnWidth], which
    /// distributes the space equally among the flexible columns,
    /// [FractionColumnWidth], which sizes a column based on the size of the
    /// table's container.
    /// </Summary>
    public interface ITableColumnWidth
    {
        double MinIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth);
        double MaxIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth);
        double Flex(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells);
        string ToString();
    }


    /// <Summary>
    /// Parent data used by [RenderTable] for its children.
    /// </Summary>
    public class TableCellParentData : FlutterSDK.Rendering.Box.BoxParentData
    {
        #region constructors
        public TableCellParentData()
        { }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Table.TableCellVerticalAlignment VerticalAlignment { get; set; }
        public virtual int x { get; set; }
        public virtual int y { get; set; }
        #endregion

        #region methods

        #endregion
    }


    /// <Summary>
    /// Base class to describe how wide a column in a [RenderTable] should be.
    ///
    /// To size a column to a specific number of pixels, use a [FixedColumnWidth].
    /// This is the cheapest way to size a column.
    ///
    /// Other algorithms that are relatively cheap include [FlexColumnWidth], which
    /// distributes the space equally among the flexible columns,
    /// [FractionColumnWidth], which sizes a column based on the size of the
    /// table's container.
    /// </Summary>
    public class TableColumnWidth
    {
        #region constructors
        public TableColumnWidth()
    
}
    #endregion

    #region fields
    #endregion

    #region methods

    /// <Summary>
    /// The smallest width that the column can have.
    ///
    /// The `cells` argument is an iterable that provides all the cells
    /// in the table for this column. Walking the cells is by definition
    /// O(N), so algorithms that do that should be considered expensive.
    ///
    /// The `containerWidth` argument is the `maxWidth` of the incoming
    /// constraints for the table, and might be infinite.
    /// </Summary>
    public virtual double MinIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
    {
        return default(double);
    }


    /// <Summary>
    /// The ideal width that the column should have. This must be equal
    /// to or greater than the [minIntrinsicWidth]. The column might be
    /// bigger than this width, e.g. if the column is flexible or if the
    /// table's width ends up being forced to be bigger than the sum of
    /// all the maxIntrinsicWidth values.
    ///
    /// The `cells` argument is an iterable that provides all the cells
    /// in the table for this column. Walking the cells is by definition
    /// O(N), so algorithms that do that should be considered expensive.
    ///
    /// The `containerWidth` argument is the `maxWidth` of the incoming
    /// constraints for the table, and might be infinite.
    /// </Summary>
    public virtual double MaxIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
    {
        return default(double);
    }


    /// <Summary>
    /// The flex factor to apply to the cell if there is any room left
    /// over when laying out the table. The remaining space is
    /// distributed to any columns with flex in proportion to their flex
    /// value (higher values get more space).
    ///
    /// The `cells` argument is an iterable that provides all the cells
    /// in the table for this column. Walking the cells is by definition
    /// O(N), so algorithms that do that should be considered expensive.
    /// </Summary>
    public virtual double Flex(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells) => null;



    #endregion
}


/// <Summary>
/// Sizes the column according to the intrinsic dimensions of all the
/// cells in that column.
///
/// This is a very expensive way to size a column.
///
/// A flex value can be provided. If specified (and non-null), the
/// column will participate in the distribution of remaining space
/// once all the non-flexible columns have been sized.
/// </Summary>
public class IntrinsicColumnWidth : FlutterSDK.Rendering.Table.TableColumnWidth
{
    #region constructors
    public IntrinsicColumnWidth(double flex = default(double))
    : base()

}
#endregion

#region fields
internal virtual double _Flex { get; set; }
#endregion

#region methods

public new double MinIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    double result = 0.0;
    foreach (RenderBox cell in cells) result = Math.Dart:mathDefaultClass.Max(result, cell.GetMinIntrinsicWidth(Dart: coreDefaultClass.Double.Infinity));
    return result;
}




public new double MaxIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    double result = 0.0;
    foreach (RenderBox cell in cells) result = Math.Dart:mathDefaultClass.Max(result, cell.GetMaxIntrinsicWidth(Dart: coreDefaultClass.Double.Infinity));
    return result;
}




public new double Flex(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells) => _Flex;



#endregion
}


/// <Summary>
/// Sizes the column to a specific number of pixels.
///
/// This is the cheapest way to size a column.
/// </Summary>
public class FixedColumnWidth : FlutterSDK.Rendering.Table.TableColumnWidth
{
    #region constructors
    public FixedColumnWidth(double value)
    : base()

}
#endregion

#region fields
public virtual double Value { get; set; }
#endregion

#region methods

public new double MinIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    return Value;
}




public new double MaxIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    return Value;
}




#endregion
}


/// <Summary>
/// Sizes the column to a fraction of the table's constraints' maxWidth.
///
/// This is a cheap way to size a column.
/// </Summary>
public class FractionColumnWidth : FlutterSDK.Rendering.Table.TableColumnWidth
{
    #region constructors
    public FractionColumnWidth(double value)
    : base()

}
#endregion

#region fields
public virtual double Value { get; set; }
#endregion

#region methods

public new double MinIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    if (!containerWidth.IsFinite()) return 0.0;
    return Value * containerWidth;
}




public new double MaxIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    if (!containerWidth.IsFinite()) return 0.0;
    return Value * containerWidth;
}




#endregion
}


/// <Summary>
/// Sizes the column by taking a part of the remaining space once all
/// the other columns have been laid out.
///
/// For example, if two columns have a [FlexColumnWidth], then half the
/// space will go to one and half the space will go to the other.
///
/// This is a cheap way to size a column.
/// </Summary>
public class FlexColumnWidth : FlutterSDK.Rendering.Table.TableColumnWidth
{
    #region constructors
    public FlexColumnWidth(double value = 1.0)
    : base()

}
#endregion

#region fields
public virtual double Value { get; set; }
#endregion

#region methods

public new double MinIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    return 0.0;
}




public new double MaxIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    return 0.0;
}




public new double Flex(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells)
{
    return Value;
}




#endregion
}


/// <Summary>
/// Sizes the column such that it is the size that is the maximum of
/// two column width specifications.
///
/// For example, to have a column be 10% of the container width or
/// 100px, whichever is bigger, you could use:
///
///     const MaxColumnWidth(const FixedColumnWidth(100.0), FractionColumnWidth(0.1))
///
/// Both specifications are evaluated, so if either specification is
/// expensive, so is this.
/// </Summary>
public class MaxColumnWidth : FlutterSDK.Rendering.Table.TableColumnWidth
{
    #region constructors
    public MaxColumnWidth(FlutterSDK.Rendering.Table.TableColumnWidth a, FlutterSDK.Rendering.Table.TableColumnWidth b)

}
#endregion

#region fields
public virtual FlutterSDK.Rendering.Table.TableColumnWidth a { get; set; }
public virtual FlutterSDK.Rendering.Table.TableColumnWidth b { get; set; }
#endregion

#region methods

public new double MinIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    return Math.Dart:mathDefaultClass.Max(a.MinIntrinsicWidth(cells, containerWidth), b.MinIntrinsicWidth(cells, containerWidth));
}




public new double MaxIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    return Math.Dart:mathDefaultClass.Max(a.MaxIntrinsicWidth(cells, containerWidth), b.MaxIntrinsicWidth(cells, containerWidth));
}




public new double Flex(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells)
{
    double aFlex = a.Flex(cells);
    if (aFlex == null) return b.Flex(cells);
    double bFlex = b.Flex(cells);
    if (bFlex == null) return null;
    return Math.Dart:mathDefaultClass.Max(aFlex, bFlex);
}




#endregion
}


/// <Summary>
/// Sizes the column such that it is the size that is the minimum of
/// two column width specifications.
///
/// For example, to have a column be 10% of the container width but
/// never bigger than 100px, you could use:
///
///     const MinColumnWidth(const FixedColumnWidth(100.0), FractionColumnWidth(0.1))
///
/// Both specifications are evaluated, so if either specification is
/// expensive, so is this.
/// </Summary>
public class MinColumnWidth : FlutterSDK.Rendering.Table.TableColumnWidth
{
    #region constructors
    public MinColumnWidth(FlutterSDK.Rendering.Table.TableColumnWidth a, FlutterSDK.Rendering.Table.TableColumnWidth b)

}
#endregion

#region fields
public virtual FlutterSDK.Rendering.Table.TableColumnWidth a { get; set; }
public virtual FlutterSDK.Rendering.Table.TableColumnWidth b { get; set; }
#endregion

#region methods

public new double MinIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    return Math.Dart:mathDefaultClass.Min(a.MinIntrinsicWidth(cells, containerWidth), b.MinIntrinsicWidth(cells, containerWidth));
}




public new double MaxIntrinsicWidth(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells, double containerWidth)
{
    return Math.Dart:mathDefaultClass.Min(a.MaxIntrinsicWidth(cells, containerWidth), b.MaxIntrinsicWidth(cells, containerWidth));
}




public new double Flex(Iterable<FlutterSDK.Rendering.Box.RenderBox> cells)
{
    double aFlex = a.Flex(cells);
    if (aFlex == null) return b.Flex(cells);
    double bFlex = b.Flex(cells);
    if (bFlex == null) return null;
    return Math.Dart:mathDefaultClass.Min(aFlex, bFlex);
}




#endregion
}


/// <Summary>
/// A table where the columns and rows are sized to fit the contents of the cells.
/// </Summary>
public class RenderTable : FlutterSDK.Rendering.Box.RenderBox
{
    #region constructors
    public RenderTable(int columns = default(int), int rows = default(int), Dictionary<int, FlutterSDK.Rendering.Table.TableColumnWidth> columnWidths = default(Dictionary<int, FlutterSDK.Rendering.Table.TableColumnWidth>), FlutterSDK.Rendering.Table.TableColumnWidth defaultColumnWidth = default(FlutterSDK.Rendering.Table.TableColumnWidth), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Tableborder.TableBorder border = default(FlutterSDK.Rendering.Tableborder.TableBorder), List<FlutterSDK.Painting.Decoration.Decoration> rowDecorations = default(List<FlutterSDK.Painting.Decoration.Decoration>), FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration), FlutterSDK.Rendering.Table.TableCellVerticalAlignment defaultVerticalAlignment = default(FlutterSDK.Rendering.Table.TableCellVerticalAlignment), TextBaseline textBaseline = default(TextBaseline), List<List<FlutterSDK.Rendering.Box.RenderBox>> children = default(List<List<FlutterSDK.Rendering.Box.RenderBox>>))
    : base()

_Columns=columns??(children!=null &&children.IsNotEmpty? children.First.Count:0);
    _Rows=rows??0;
_Children=new List<RenderBox>(){}
..Count = _Columns * _Rows;
_ColumnWidths = columnWidths ?? new HashMap<int, TableColumnWidth>();
_DefaultColumnWidth = defaultColumnWidth;
_Border = border;
this.RowDecorations = rowDecorations;
_Configuration = configuration;
_DefaultVerticalAlignment = defaultVerticalAlignment;
_TextBaseline = textBaseline;
children?.ForEach(AddRow);
}


#endregion

#region fields
internal virtual List<FlutterSDK.Rendering.Box.RenderBox> _Children { get; set; }
internal virtual int _Columns { get; set; }
internal virtual int _Rows { get; set; }
internal virtual Dictionary<int, FlutterSDK.Rendering.Table.TableColumnWidth> _ColumnWidths { get; set; }
internal virtual FlutterSDK.Rendering.Table.TableColumnWidth _DefaultColumnWidth { get; set; }
internal virtual TextDirection _TextDirection { get; set; }
internal virtual FlutterSDK.Rendering.Tableborder.TableBorder _Border { get; set; }
internal virtual List<FlutterSDK.Painting.Decoration.Decoration> _RowDecorations { get; set; }
internal virtual List<FlutterSDK.Painting.Decoration.BoxPainter> _RowDecorationPainters { get; set; }
internal virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration _Configuration { get; set; }
internal virtual FlutterSDK.Rendering.Table.TableCellVerticalAlignment _DefaultVerticalAlignment { get; set; }
internal virtual TextBaseline _TextBaseline { get; set; }
internal virtual double _BaselineDistance { get; set; }
internal virtual List<double> _RowTops { get; set; }
internal virtual Iterable<double> _ColumnLefts { get; set; }
public virtual int Columns { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int Rows { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual Dictionary<int, FlutterSDK.Rendering.Table.TableColumnWidth> ColumnWidths { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Table.TableColumnWidth DefaultColumnWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Tableborder.TableBorder Border { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual List<FlutterSDK.Painting.Decoration.Decoration> RowDecorations { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration Configuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Table.TableCellVerticalAlignment DefaultVerticalAlignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual TextBaseline TextBaseline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Determines how the width of column with the given index is determined.
/// </Summary>
public virtual void SetColumnWidth(int column, FlutterSDK.Rendering.Table.TableColumnWidth value)
{
    if (_ColumnWidths[column] == value) return;
    _ColumnWidths[column] = value;
    MarkNeedsLayout();
}




public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
{
    if (!(child.ParentData is TableCellParentData)) child.ParentData = new TableCellParentData();
}




/// <Summary>
/// Replaces the children of this table with the given cells.
///
/// The cells are divided into the specified number of columns before
/// replacing the existing children.
///
/// If the new cells contain any existing children of the table, those
/// children are simply moved to their new location in the table rather than
/// removed from the table and re-added.
/// </Summary>
public virtual void SetFlatChildren(int columns, List<FlutterSDK.Rendering.Box.RenderBox> cells)
{
    if (cells == _Children && columns == _Columns) return;

    if (columns == 0 || cells.IsEmpty())
    {

        _Columns = columns;
        if (_Children.IsEmpty())
        {

            return;
        }

        foreach (RenderBox oldChild in _Children)
        {
            if (oldChild != null) DropChild(oldChild);
        }

        _Rows = 0;
        _Children.Clear();
        MarkNeedsLayout();
        return;
    }



    HashSet<RenderBox> lostChildren = new HashSet<RenderBox>();
    for (int y = 0; y < _Rows; y += 1)
    {
        for (int x = 0; x < _Columns; x += 1)
        {
            int xyOld = x + y * _Columns;
            int xyNew = x + y * columns;
            if (_Children[xyOld] != null && (x >= columns || xyNew >= cells.Count || _Children[xyOld] != cells[xyNew])) lostChildren.Add(_Children[xyOld]);
        }

    }

    int y = 0;
    while (y * columns < cells.Count)
    {
        for (int x = 0; x < columns; x += 1)
        {
            int xyNew = x + y * columns;
            int xyOld = x + y * _Columns;
            if (cells[xyNew] != null && (x >= _Columns || y >= _Rows || _Children[xyOld] != cells[xyNew]))
            {
                if (!lostChildren.Remove(cells[xyNew])) AdoptChild(cells[xyNew]);
            }

        }

        y += 1;
    }

    lostChildren.ForEach(DropChild);
    _Columns = columns;
    _Rows = cells.Count~/ columns;
    _Children = cells.ToList();

    MarkNeedsLayout();
}




/// <Summary>
/// Replaces the children of this table with the given cells.
/// </Summary>
public virtual void SetChildren(List<List<FlutterSDK.Rendering.Box.RenderBox>> cells)
{
    if (cells == null)
    {
        SetFlatChildren(0, null);
        return;
    }

    foreach (RenderBox oldChild in _Children)
    {
        if (oldChild != null) DropChild(oldChild);
    }

    _Children.Clear();
    _Columns = cells.IsNotEmpty ? cells.First.Count : 0;
    _Rows = 0;
    cells.ForEach(AddRow);

}




/// <Summary>
/// Adds a row to the end of the table.
///
/// The newly added children must not already have parents.
/// </Summary>
public virtual void AddRow(List<FlutterSDK.Rendering.Box.RenderBox> cells)
{


    _Rows += 1;
    _Children.AddAll(cells);
    foreach (RenderBox cell in cells)
    {
        if (cell != null) AdoptChild(cell);
    }

    MarkNeedsLayout();
}




/// <Summary>
/// Replaces the child at the given position with the given child.
///
/// If the given child is already located at the given position, this function
/// does not modify the table. Otherwise, the given child must not already
/// have a parent.
/// </Summary>
public virtual void SetChild(int x, int y, FlutterSDK.Rendering.Box.RenderBox value)
{




    int xy = x + y * Columns;
    RenderBox oldChild = _Children[xy];
    if (oldChild == value) return;
    if (oldChild != null) DropChild(oldChild);
    _Children[xy] = value;
    if (value != null) AdoptChild(value);
}




public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
{
    base.Attach(owner);
    foreach (RenderBox child in _Children) child?.Attach(owner);
}


public new void Attach(@Object owner)
{
    base.Attach(owner);
    foreach (RenderBox child in _Children) child?.Attach(owner);
}




public new void Detach()
{
    base.Detach();
    if (_RowDecorationPainters != null)
    {
        foreach (BoxPainter painter in _RowDecorationPainters) painter?.Dispose();
        _RowDecorationPainters = new List<BoxPainter>(_RowDecorations.Count);
    }

    foreach (RenderBox child in _Children) child?.Detach();
}




public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
{

    foreach (RenderBox child in _Children)
    {
        if (child != null) visitor(child);
    }

}




public new double ComputeMinIntrinsicWidth(double height)
{

    double totalMinWidth = 0.0;
    for (int x = 0; x < Columns; x += 1)
    {
        TableColumnWidth columnWidth = _ColumnWidths[x] ?? DefaultColumnWidth;
        Iterable<RenderBox> columnCells = Column(x);
        totalMinWidth += columnWidth.MinIntrinsicWidth(columnCells, Dart: coreDefaultClass.Double.Infinity);
    }

    return totalMinWidth;
}




public new double ComputeMaxIntrinsicWidth(double height)
{

    double totalMaxWidth = 0.0;
    for (int x = 0; x < Columns; x += 1)
    {
        TableColumnWidth columnWidth = _ColumnWidths[x] ?? DefaultColumnWidth;
        Iterable<RenderBox> columnCells = Column(x);
        totalMaxWidth += columnWidth.MaxIntrinsicWidth(columnCells, Dart: coreDefaultClass.Double.Infinity);
    }

    return totalMaxWidth;
}




public new double ComputeMinIntrinsicHeight(double width)
{

    List<double> widths = _ComputeColumnWidths(BoxConstraints.TightForFinite(width: width));
    double rowTop = 0.0;
    for (int y = 0; y < Rows; y += 1)
    {
        double rowHeight = 0.0;
        for (int x = 0; x < Columns; x += 1)
        {
            int xy = x + y * Columns;
            RenderBox child = _Children[xy];
            if (child != null) rowHeight = Math.Dart:mathDefaultClass.Max(rowHeight, child.GetMaxIntrinsicHeight(widths[x]));
        }

        rowTop += rowHeight;
    }

    return rowTop;
}




public new double ComputeMaxIntrinsicHeight(double width)
{
    return ComputeMinIntrinsicHeight(width);
}




public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
{

    return _BaselineDistance;
}




/// <Summary>
/// Returns the list of [RenderBox] objects that are in the given
/// column, in row order, starting from the first row.
///
/// This is a lazily-evaluated iterable.
/// </Summary>
public virtual Iterable<FlutterSDK.Rendering.Box.RenderBox> Column(int x)
sync
*
{
    for (int y = 0; y < Rows; y += 1)
    {
        int xy = x + y * Columns;
        RenderBox child = _Children[xy];
        if (child != null) yield child;
    }

}




/// <Summary>
/// Returns the list of [RenderBox] objects that are on the given
/// row, in column order, starting with the first column.
///
/// This is a lazily-evaluated iterable.
/// </Summary>
public virtual Iterable<FlutterSDK.Rendering.Box.RenderBox> Row(int y)
sync
*
{
    int start = y * Columns;
    int end = (y + 1) * Columns;
    for (int xy = start; xy < end; xy += 1)
    {
        RenderBox child = _Children[xy];
        if (child != null) yield child;
    }

}




private List<double> _ComputeColumnWidths(FlutterSDK.Rendering.Box.BoxConstraints constraints)
{


    List<double> widths = new List<double>(Columns);
    List<double> minWidths = new List<double>(Columns);
    List<double> flexes = new List<double>(Columns);
    double tableWidth = 0.0;
    double unflexedTableWidth = 0.0;
    double totalFlex = 0.0;
    for (int x = 0; x < Columns; x += 1)
    {
        TableColumnWidth columnWidth = _ColumnWidths[x] ?? DefaultColumnWidth;
        Iterable<RenderBox> columnCells = Column(x);
        double maxIntrinsicWidth = columnWidth.MaxIntrinsicWidth(columnCells, constraints.MaxWidth);


        widths[x] = maxIntrinsicWidth;
        tableWidth += maxIntrinsicWidth;
        double minIntrinsicWidth = columnWidth.MinIntrinsicWidth(columnCells, constraints.MaxWidth);


        minWidths[x] = minIntrinsicWidth;

        double flex = columnWidth.Flex(columnCells);
        if (flex != null)
        {


            flexes[x] = flex;
            totalFlex += flex;
        }
        else
        {
            unflexedTableWidth += maxIntrinsicWidth;
        }

    }


    double maxWidthConstraint = constraints.MaxWidth;
    double minWidthConstraint = constraints.MinWidth;
    if (totalFlex > 0.0)
    {
        double targetWidth = default(double);
        if (maxWidthConstraint.IsFinite())
        {
            targetWidth = maxWidthConstraint;
        }
        else
        {
            targetWidth = minWidthConstraint;
        }

        if (tableWidth < targetWidth)
        {
            double remainingWidth = targetWidth - unflexedTableWidth;


            for (int x = 0; x < Columns; x += 1)
            {
                if (flexes[x] != null)
                {
                    double flexedWidth = remainingWidth * flexes[x] / totalFlex;


                    if (widths[x] < flexedWidth)
                    {
                        double delta = flexedWidth - widths[x];
                        tableWidth += delta;
                        widths[x] = flexedWidth;
                    }

                }

            }


        }

    }
    else if (tableWidth < minWidthConstraint)
    {
        double delta = (minWidthConstraint - tableWidth) / Columns;
        for (int x = 0; x < Columns; x += 1) widths[x] += delta;
        tableWidth = minWidthConstraint;
    }


    if (tableWidth > maxWidthConstraint)
    {
        double deficit = tableWidth - maxWidthConstraint;
        int availableColumns = Columns;
        while (deficit > ConstantsDefaultClass.PrecisionErrorTolerance && totalFlex > ConstantsDefaultClass.PrecisionErrorTolerance)
        {
            double newTotalFlex = 0.0;
            for (int x = 0; x < Columns; x += 1)
            {
                if (flexes[x] != null)
                {
                    double newWidth = widths[x] - deficit * flexes[x] / totalFlex;

                    if (newWidth <= minWidths[x])
                    {
                        deficit -= widths[x] - minWidths[x];
                        widths[x] = minWidths[x];
                        flexes[x] = null;
                        availableColumns -= 1;
                    }
                    else
                    {
                        deficit -= widths[x] - newWidth;
                        widths[x] = newWidth;
                        newTotalFlex += flexes[x];
                    }


                }

            }

            totalFlex = newTotalFlex;
        }

        while (deficit > ConstantsDefaultClass.PrecisionErrorTolerance && availableColumns > 0)
        {
            double delta = deficit / availableColumns;

            int newAvailableColumns = 0;
            for (int x = 0; x < Columns; x += 1)
            {
                double availableDelta = widths[x] - minWidths[x];
                if (availableDelta > 0.0)
                {
                    if (availableDelta <= delta)
                    {
                        deficit -= widths[x] - minWidths[x];
                        widths[x] = minWidths[x];
                    }
                    else
                    {
                        deficit -= delta;
                        widths[x] -= delta;
                        newAvailableColumns += 1;
                    }

                }

            }

            availableColumns = newAvailableColumns;
        }

    }

    return widths;
}




/// <Summary>
/// Returns the position and dimensions of the box that the given
/// row covers, in this render object's coordinate space (so the
/// left coordinate is always 0.0).
///
/// The row being queried must exist.
///
/// This is only valid after layout.
/// </Summary>
public virtual Rect GetRowBox(int row)
{



    return Rect.FromLTRB(0.0, _RowTops[row], Size.Width, _RowTops[row + 1]);
}




public new void PerformLayout()
{
    BoxConstraints constraints = this.Constraints;
    int rows = this.Rows;
    int columns = this.Columns;

    if (rows * columns == 0)
    {
        Size = constraints.Constrain(new Size(0.0, 0.0));
        return;
    }

    List<double> widths = _ComputeColumnWidths(constraints);
    List<double> positions = new List<double>(columns);
    double tableWidth = default(double);
    switch (TextDirection) { case TextDirection.Rtl: positions[columns - 1] = 0.0; for (int x = columns - 2; x >= 0; x -= 1) positions[x] = positions[x + 1] + widths[x + 1]; _ColumnLefts = positions.Reversed; tableWidth = positions.First + widths.First; break; case TextDirection.Ltr: positions[0] = 0.0; for (int x = 1; x < columns; x += 1) positions[x] = positions[x - 1] + widths[x - 1]; _ColumnLefts = positions; tableWidth = positions.Last() + widths.Last(); break; }

    _RowTops.Clear();
    _BaselineDistance = null;
    double rowTop = 0.0;
    for (int y = 0; y < rows; y += 1)
    {
        _RowTops.Add(rowTop);
        double rowHeight = 0.0;
        bool haveBaseline = false;
        double beforeBaselineDistance = 0.0;
        double afterBaselineDistance = 0.0;
        List<double> baselines = new List<double>(columns);
        for (int x = 0; x < columns; x += 1)
        {
            int xy = x + y * columns;
            RenderBox child = _Children[xy];
            if (child != null)
            {
                TableCellParentData childParentData = child.ParentData as TableCellParentData;

                childParentData.x = x;
                childParentData.y = y;
                switch (childParentData.VerticalAlignment ?? DefaultVerticalAlignment)
                {
                    case TableCellVerticalAlignment.Baseline:
                        child.Layout(BoxConstraints.TightFor(width: widths[x]), parentUsesSize: true); double childBaseline = child.GetDistanceToBaseline(TextBaseline, onlyReal: true); if (childBaseline != null)
                        {
                            beforeBaselineDistance = Math.Dart:mathDefaultClass.Max(beforeBaselineDistance, childBaseline);
                            afterBaselineDistance = Math.Dart:mathDefaultClass.Max(afterBaselineDistance, child.Size.Height - childBaseline);
                            baselines[x] = childBaseline;
                            haveBaseline = true;
                        }
                        else
                        {
                            rowHeight = Math.Dart:mathDefaultClass.Max(rowHeight, child.Size.Height);
                            childParentData.Offset = new Offset(positions[x], rowTop);
                        }
                        break;
                    case TableCellVerticalAlignment.Top: case TableCellVerticalAlignment.Middle: case TableCellVerticalAlignment.Bottom: child.Layout(BoxConstraints.TightFor(width: widths[x]), parentUsesSize: true); rowHeight = Math.Dart:mathDefaultClass.Max(rowHeight, child.Size.Height); break;
                    case TableCellVerticalAlignment.Fill: break;
                }
            }

        }

        if (haveBaseline)
        {
            if (y == 0) _BaselineDistance = beforeBaselineDistance;
            rowHeight = Math.Dart:mathDefaultClass.Max(rowHeight, beforeBaselineDistance + afterBaselineDistance);
        }

        for (int x = 0; x < columns; x += 1)
        {
            int xy = x + y * columns;
            RenderBox child = _Children[xy];
            if (child != null)
            {
                TableCellParentData childParentData = child.ParentData as TableCellParentData;
                switch (childParentData.VerticalAlignment ?? DefaultVerticalAlignment) { case TableCellVerticalAlignment.Baseline: if (baselines[x] != null) childParentData.Offset = new Offset(positions[x], rowTop + beforeBaselineDistance - baselines[x]); break; case TableCellVerticalAlignment.Top: childParentData.Offset = new Offset(positions[x], rowTop); break; case TableCellVerticalAlignment.Middle: childParentData.Offset = new Offset(positions[x], rowTop + (rowHeight - child.Size.Height) / 2.0); break; case TableCellVerticalAlignment.Bottom: childParentData.Offset = new Offset(positions[x], rowTop + rowHeight - child.Size.Height); break; case TableCellVerticalAlignment.Fill: child.Layout(BoxConstraints.TightFor(width: widths[x], height: rowHeight)); childParentData.Offset = new Offset(positions[x], rowTop); break; }
            }

        }

        rowTop += rowHeight;
    }

    _RowTops.Add(rowTop);
    Size = constraints.Constrain(new Size(tableWidth, rowTop));

}




public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{

    for (int index = _Children.Count - 1; index >= 0; index -= 1)
    {
        RenderBox child = _Children[index];
        if (child != null)
        {
            BoxParentData childParentData = child.ParentData as BoxParentData;
            bool isHit = result.AddWithPaintOffset(offset: childParentData.Offset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
            {

                return child.HitTest(result, position: transformed);
            }
            );
            if (isHit) return true;
        }

    }

    return false;
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

    if (Rows * Columns == 0)
    {
        if (Border != null)
        {
            Rect borderRect = Rect.FromLTWH(offset.Dx, offset.Dy, Size.Width, 0.0);
            Border.Paint(context.Canvas, borderRect, rows: new List, < double > (}, columns: new List, < double > (});
}

return;
}


if (_RowDecorations != null)
{

    Canvas canvas = context.Canvas;
    for (int y = 0; y < Rows; y += 1)
    {
        if (_RowDecorations.Count <= y) break;
        if (_RowDecorations[y] != null)
        {
            _RowDecorationPainters[y] = (_RowDecorationPainters[y] == null ? _RowDecorations[y].CreateBoxPainter(MarkNeedsPaint) : _RowDecorationPainters[y]);
            _RowDecorationPainters[y].Paint(canvas, new Offset(offset.Dx, offset.Dy + _RowTops[y]), Configuration.CopyWith(size: new Size(Size.Width, _RowTops[y + 1] - _RowTops[y])));
        }

    }

}

for (int index = 0; index < _Children.Count; index += 1)
{
    RenderBox child = _Children[index];
    if (child != null)
    {
        BoxParentData childParentData = child.ParentData as BoxParentData;
        context.PaintChild(child, childParentData.Offset + offset);
    }

}



if (Border != null)
{
    Rect borderRect = Rect.FromLTWH(offset.Dx, offset.Dy, Size.Width, _RowTops.Last());
    Iterable<double> rows = _RowTops.GetRange(1, _RowTops.Count - 1);
    Iterable<double> columns = _ColumnLefts.Skip(1);
    Border.Paint(context.Canvas, borderRect, rows: rows, columns: columns);
}

}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new DiagnosticsProperty<TableBorder>("border", Border, defaultValue: null));
    properties.Add(new DiagnosticsProperty<Dictionary<int, TableColumnWidth>>("specified column widths", _ColumnWidths, level: _ColumnWidths.IsEmpty() ? DiagnosticLevel.Hidden : DiagnosticLevel.Info));
    properties.Add(new DiagnosticsProperty<TableColumnWidth>("default column width", DefaultColumnWidth));
    properties.Add(new MessageProperty("table size", $"'{Columns}\u00D7{Rows}'"));
    properties.Add(new IterableProperty<string>("column offsets", _ColumnLefts?.Map(DebugDefaultClass.DebugFormatDouble), ifNull: "unknown"));
    properties.Add(new IterableProperty<string>("row offsets", _RowTops?.Map(DebugDefaultClass.DebugFormatDouble), ifNull: "unknown"));
}




public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
{
    if (_Children.IsEmpty())
    {
        return new List<DiagnosticsNode>() { DiagnosticsNode.Message("table is empty") };
    }

    List<DiagnosticsNode> children = new List<DiagnosticsNode>() { };
    for (int y = 0; y < Rows; y += 1)
    {
        for (int x = 0; x < Columns; x += 1)
        {
            int xy = x + y * Columns;
            RenderBox child = _Children[xy];
            string name = $"'child ({x}, {y})'";
            if (child != null) children.Add(child.ToDiagnosticsNode(name: name)); else children.Add(new DiagnosticsProperty<object>(name, null, ifNull: "is null", showSeparator: false));
        }

    }

    return children;
}



#endregion
}


/// <Summary>
/// Vertical alignment options for cells in [RenderTable] objects.
///
/// This is specified using [TableCellParentData] objects on the
/// [RenderObject.parentData] of the children of the [RenderTable].
/// </Summary>
public enum TableCellVerticalAlignment
{

    /// <Summary>
    /// Cells with this alignment are placed with their top at the top of the row.
    /// </Summary>
    Top,
    /// <Summary>
    /// Cells with this alignment are vertically centered in the row.
    /// </Summary>
    Middle,
    /// <Summary>
    /// Cells with this alignment are placed with their bottom at the bottom of the row.
    /// </Summary>
    Bottom,
    /// <Summary>
    /// Cells with this alignment are aligned such that they all share the same
    /// baseline. Cells with no baseline are top-aligned instead. The baseline
    /// used is specified by [RenderTable.textBaseline]. It is not valid to use
    /// the baseline value if [RenderTable.textBaseline] is not specified.
    ///
    /// This vertical alignment is relatively expensive because it causes the table
    /// to compute the baseline for each cell in the row.
    /// </Summary>
    Baseline,
    /// <Summary>
    /// Cells with this alignment are sized to be as tall as the row, then made to fit the row.
    /// If all the cells have this alignment, then the row will have zero height.
    /// </Summary>
    Fill,
}

}
