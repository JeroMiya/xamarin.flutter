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
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Rendering.Wrap
{
    internal static class WrapDefaultClass
    {
    }

    public class _RunMetrics
    {
        #region constructors
        public _RunMetrics(double mainAxisExtent, double crossAxisExtent, int childCount)
    
}
    #endregion

    #region fields
    public virtual double MainAxisExtent { get; set; }
    public virtual double CrossAxisExtent { get; set; }
    public virtual int ChildCount { get; set; }
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Parent data for use with [RenderWrap].
/// </Summary>
public class WrapParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
{
    #region constructors
    public WrapParentData()
    { }
    #endregion

    #region fields
    internal virtual int _RunIndex { get; set; }
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Displays its children in multiple horizontal or vertical runs.
///
/// A [RenderWrap] lays out each child and attempts to place the child adjacent
/// to the previous child in the main axis, given by [direction], leaving
/// [spacing] space in between. If there is not enough space to fit the child,
/// [RenderWrap] creates a new _run_ adjacent to the existing children in the
/// cross axis.
///
/// After all the children have been allocated to runs, the children within the
/// runs are positioned according to the [alignment] in the main axis and
/// according to the [crossAxisAlignment] in the cross axis.
///
/// The runs themselves are then positioned in the cross axis according to the
/// [runSpacing] and [runAlignment].
/// </Summary>
public class RenderWrap : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Wrap.WrapParentData>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Wrap.WrapParentData>
{
    #region constructors
    public RenderWrap(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), FlutterSDK.Painting.Basictypes.Axis direction = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Wrap.WrapAlignment alignment = default(FlutterSDK.Rendering.Wrap.WrapAlignment), double spacing = 0.0, FlutterSDK.Rendering.Wrap.WrapAlignment runAlignment = default(FlutterSDK.Rendering.Wrap.WrapAlignment), double runSpacing = 0.0, FlutterSDK.Rendering.Wrap.WrapCrossAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Wrap.WrapCrossAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection))
    : base()

AddAll(children);
}


#endregion

#region fields
internal virtual FlutterSDK.Painting.Basictypes.Axis _Direction { get; set; }
internal virtual FlutterSDK.Rendering.Wrap.WrapAlignment _Alignment { get; set; }
internal virtual double _Spacing { get; set; }
internal virtual FlutterSDK.Rendering.Wrap.WrapAlignment _RunAlignment { get; set; }
internal virtual double _RunSpacing { get; set; }
internal virtual FlutterSDK.Rendering.Wrap.WrapCrossAlignment _CrossAxisAlignment { get; set; }
internal virtual TextDirection _TextDirection { get; set; }
internal virtual FlutterSDK.Painting.Basictypes.VerticalDirection _VerticalDirection { get; set; }
internal virtual bool _HasVisualOverflow { get; set; }
public virtual FlutterSDK.Painting.Basictypes.Axis Direction { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Wrap.WrapAlignment Alignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double Spacing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Wrap.WrapAlignment RunAlignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double RunSpacing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Wrap.WrapCrossAlignment CrossAxisAlignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Basictypes.VerticalDirection VerticalDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual bool _DebugHasNecessaryDirections { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
{
    if (!(child.ParentData is WrapParentData)) child.ParentData = new WrapParentData();
}


public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
{
    if (!(child.ParentData is WrapParentData)) child.ParentData = new WrapParentData();
}




private double _ComputeIntrinsicHeightForWidth(double width)
{

    int runCount = 0;
    double height = 0.0;
    double runWidth = 0.0;
    double runHeight = 0.0;
    int childCount = 0;
    RenderBox child = FirstChild;
    while (child != null)
    {
        double childWidth = child.GetMaxIntrinsicWidth(Dart: coreDefaultClass.Double.Infinity);
        double childHeight = child.GetMaxIntrinsicHeight(childWidth);
        if (runWidth + childWidth > width)
        {
            height += runHeight;
            if (runCount > 0) height += RunSpacing;
            runCount += 1;
            runWidth = 0.0;
            runHeight = 0.0;
            childCount = 0;
        }

        runWidth += childWidth;
        runHeight = Math.Dart:mathDefaultClass.Max(runHeight, childHeight);
if (childCount > 0) runWidth += Spacing;
childCount += 1;
child = ChildAfter(child);
}

if (childCount > 0) height += runHeight + RunSpacing;
return height;
}




private double _ComputeIntrinsicWidthForHeight(double height)
{

    int runCount = 0;
    double width = 0.0;
    double runHeight = 0.0;
    double runWidth = 0.0;
    int childCount = 0;
    RenderBox child = FirstChild;
    while (child != null)
    {
        double childHeight = child.GetMaxIntrinsicHeight(Dart: coreDefaultClass.Double.Infinity);
        double childWidth = child.GetMaxIntrinsicWidth(childHeight);
        if (runHeight + childHeight > height)
        {
            width += runWidth;
            if (runCount > 0) width += RunSpacing;
            runCount += 1;
            runHeight = 0.0;
            runWidth = 0.0;
            childCount = 0;
        }

        runHeight += childHeight;
        runWidth = Math.Dart:mathDefaultClass.Max(runWidth, childWidth);
if (childCount > 0) runHeight += Spacing;
childCount += 1;
child = ChildAfter(child);
}

if (childCount > 0) width += runWidth + RunSpacing;
return width;
}




public new double ComputeMinIntrinsicWidth(double height)
{
    switch (Direction)
    {
        case Axis.Horizontal:
            double width = 0.0; RenderBox child = FirstChild; while (child != null)
            {
                width = Math.Dart:mathDefaultClass.Max(width, child.GetMinIntrinsicWidth(Dart: coreDefaultClass.Double.Infinity));
                child = ChildAfter(child);
            }
            return width;
        case Axis.Vertical: return _ComputeIntrinsicWidthForHeight(height);
    }
    return null;
}




public new double ComputeMaxIntrinsicWidth(double height)
{
    switch (Direction)
    {
        case Axis.Horizontal:
            double width = 0.0; RenderBox child = FirstChild; while (child != null)
            {
                width += child.GetMaxIntrinsicWidth(Dart: coreDefaultClass.Double.Infinity);
                child = ChildAfter(child);
            }
            return width;
        case Axis.Vertical: return _ComputeIntrinsicWidthForHeight(height);
    }
    return null;
}




public new double ComputeMinIntrinsicHeight(double width)
{
    switch (Direction)
    {
        case Axis.Horizontal: return _ComputeIntrinsicHeightForWidth(width);
        case Axis.Vertical:
            double height = 0.0; RenderBox child = FirstChild; while (child != null)
            {
                height = Math.Dart:mathDefaultClass.Max(height, child.GetMinIntrinsicHeight(Dart: coreDefaultClass.Double.Infinity));
                child = ChildAfter(child);
            }
            return height;
    }
    return null;
}




public new double ComputeMaxIntrinsicHeight(double width)
{
    switch (Direction)
    {
        case Axis.Horizontal: return _ComputeIntrinsicHeightForWidth(width);
        case Axis.Vertical:
            double height = 0.0; RenderBox child = FirstChild; while (child != null)
            {
                height += child.GetMaxIntrinsicHeight(Dart: coreDefaultClass.Double.Infinity);
                child = ChildAfter(child);
            }
            return height;
    }
    return null;
}




public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
{
    return DefaultComputeDistanceToHighestActualBaseline(baseline);
}




private double _GetMainAxisExtent(FlutterSDK.Rendering.Box.RenderBox child)
{
    switch (Direction) { case Axis.Horizontal: return child.Size.Width; case Axis.Vertical: return child.Size.Height; }
    return 0.0;
}




private double _GetCrossAxisExtent(FlutterSDK.Rendering.Box.RenderBox child)
{
    switch (Direction) { case Axis.Horizontal: return child.Size.Height; case Axis.Vertical: return child.Size.Width; }
    return 0.0;
}




private Offset _GetOffset(double mainAxisOffset, double crossAxisOffset)
{
    switch (Direction) { case Axis.Horizontal: return new Offset(mainAxisOffset, crossAxisOffset); case Axis.Vertical: return new Offset(crossAxisOffset, mainAxisOffset); }
    return Dart:uiDefaultClass.Offset.Zero;
}




private double _GetChildCrossAxisOffset(bool flipCrossAxis, double runCrossAxisExtent, double childCrossAxisExtent)
{
    double freeSpace = runCrossAxisExtent - childCrossAxisExtent;
    switch (CrossAxisAlignment) { case WrapCrossAlignment.Start: return flipCrossAxis ? freeSpace : 0.0; case WrapCrossAlignment.End: return flipCrossAxis ? 0.0 : freeSpace; case WrapCrossAlignment.Center: return freeSpace / 2.0; }
    return 0.0;
}




public new void PerformLayout()
{
    BoxConstraints constraints = this.Constraints;

    _HasVisualOverflow = false;
    RenderBox child = FirstChild;
    if (child == null)
    {
        Size = constraints.Smallest;
        return;
    }

    BoxConstraints childConstraints = default(BoxConstraints);
    double mainAxisLimit = 0.0;
    bool flipMainAxis = false;
    bool flipCrossAxis = false;
    switch (Direction) { case Axis.Horizontal: childConstraints = new BoxConstraints(maxWidth: constraints.MaxWidth); mainAxisLimit = constraints.MaxWidth; if (TextDirection == TextDirection.Rtl) flipMainAxis = true; if (VerticalDirection == VerticalDirection.Up) flipCrossAxis = true; break; case Axis.Vertical: childConstraints = new BoxConstraints(maxHeight: constraints.MaxHeight); mainAxisLimit = constraints.MaxHeight; if (VerticalDirection == VerticalDirection.Up) flipMainAxis = true; if (TextDirection == TextDirection.Rtl) flipCrossAxis = true; break; }


    double spacing = this.Spacing;
    double runSpacing = this.RunSpacing;
    List<_RunMetrics> runMetrics = new List<_RunMetrics>() { };
    double mainAxisExtent = 0.0;
    double crossAxisExtent = 0.0;
    double runMainAxisExtent = 0.0;
    double runCrossAxisExtent = 0.0;
    int childCount = 0;
    while (child != null)
    {
        child.Layout(childConstraints, parentUsesSize: true);
        double childMainAxisExtent = _GetMainAxisExtent(child);
        double childCrossAxisExtent = _GetCrossAxisExtent(child);
        if (childCount > 0 && runMainAxisExtent + spacing + childMainAxisExtent > mainAxisLimit)
        {
            mainAxisExtent = Math.Dart:mathDefaultClass.Max(mainAxisExtent, runMainAxisExtent);
            crossAxisExtent += runCrossAxisExtent;
            if (runMetrics.IsNotEmpty) crossAxisExtent += runSpacing;
            runMetrics.Add(new _RunMetrics(runMainAxisExtent, runCrossAxisExtent, childCount));
            runMainAxisExtent = 0.0;
            runCrossAxisExtent = 0.0;
            childCount = 0;
        }

        runMainAxisExtent += childMainAxisExtent;
        if (childCount > 0) runMainAxisExtent += spacing;
        runCrossAxisExtent = Math.Dart:mathDefaultClass.Max(runCrossAxisExtent, childCrossAxisExtent);
        childCount += 1;
        WrapParentData childParentData = child.ParentData as WrapParentData;
        childParentData._RunIndex = runMetrics.Count;
        child = childParentData.NextSibling;
    }

    if (childCount > 0)
    {
        mainAxisExtent = Math.Dart:mathDefaultClass.Max(mainAxisExtent, runMainAxisExtent);
        crossAxisExtent += runCrossAxisExtent;
        if (runMetrics.IsNotEmpty) crossAxisExtent += runSpacing;
        runMetrics.Add(new _RunMetrics(runMainAxisExtent, runCrossAxisExtent, childCount));
    }

    int runCount = runMetrics.Count;

    double containerMainAxisExtent = 0.0;
    double containerCrossAxisExtent = 0.0;
    switch (Direction) { case Axis.Horizontal: Size = constraints.Constrain(new Size(mainAxisExtent, crossAxisExtent)); containerMainAxisExtent = Size.Width; containerCrossAxisExtent = Size.Height; break; case Axis.Vertical: Size = constraints.Constrain(new Size(crossAxisExtent, mainAxisExtent)); containerMainAxisExtent = Size.Height; containerCrossAxisExtent = Size.Width; break; }
    _HasVisualOverflow = containerMainAxisExtent < mainAxisExtent || containerCrossAxisExtent < crossAxisExtent;
    double crossAxisFreeSpace = Math.Dart:mathDefaultClass.Max(0.0, containerCrossAxisExtent - crossAxisExtent);
    double runLeadingSpace = 0.0;
    double runBetweenSpace = 0.0;
    switch (RunAlignment) { case WrapAlignment.Start: break; case WrapAlignment.End: runLeadingSpace = crossAxisFreeSpace; break; case WrapAlignment.Center: runLeadingSpace = crossAxisFreeSpace / 2.0; break; case WrapAlignment.SpaceBetween: runBetweenSpace = runCount > 1 ? crossAxisFreeSpace / (runCount - 1) : 0.0; break; case WrapAlignment.SpaceAround: runBetweenSpace = crossAxisFreeSpace / runCount; runLeadingSpace = runBetweenSpace / 2.0; break; case WrapAlignment.SpaceEvenly: runBetweenSpace = crossAxisFreeSpace / (runCount + 1); runLeadingSpace = runBetweenSpace; break; }
    runBetweenSpace += runSpacing;
    double crossAxisOffset = flipCrossAxis ? containerCrossAxisExtent - runLeadingSpace : runLeadingSpace;
    child = FirstChild;
    for (int i = 0; i < runCount; ++i)
    {
        _RunMetrics metrics = runMetrics[i];
        double runMainAxisExtent = metrics.MainAxisExtent;
        double runCrossAxisExtent = metrics.CrossAxisExtent;
        int childCount = metrics.ChildCount;
        double mainAxisFreeSpace = Math.Dart:mathDefaultClass.Max(0.0, containerMainAxisExtent - runMainAxisExtent);
        double childLeadingSpace = 0.0;
        double childBetweenSpace = 0.0;
        switch (Alignment) { case WrapAlignment.Start: break; case WrapAlignment.End: childLeadingSpace = mainAxisFreeSpace; break; case WrapAlignment.Center: childLeadingSpace = mainAxisFreeSpace / 2.0; break; case WrapAlignment.SpaceBetween: childBetweenSpace = childCount > 1 ? mainAxisFreeSpace / (childCount - 1) : 0.0; break; case WrapAlignment.SpaceAround: childBetweenSpace = mainAxisFreeSpace / childCount; childLeadingSpace = childBetweenSpace / 2.0; break; case WrapAlignment.SpaceEvenly: childBetweenSpace = mainAxisFreeSpace / (childCount + 1); childLeadingSpace = childBetweenSpace; break; }
        childBetweenSpace += spacing;
        double childMainPosition = flipMainAxis ? containerMainAxisExtent - childLeadingSpace : childLeadingSpace;
        if (flipCrossAxis) crossAxisOffset -= runCrossAxisExtent;
        while (child != null)
        {
            WrapParentData childParentData = child.ParentData as WrapParentData;
            if (childParentData._RunIndex != i) break;
            double childMainAxisExtent = _GetMainAxisExtent(child);
            double childCrossAxisExtent = _GetCrossAxisExtent(child);
            double childCrossAxisOffset = _GetChildCrossAxisOffset(flipCrossAxis, runCrossAxisExtent, childCrossAxisExtent);
            if (flipMainAxis) childMainPosition -= childMainAxisExtent;
            childParentData.Offset = _GetOffset(childMainPosition, crossAxisOffset + childCrossAxisOffset);
            if (flipMainAxis) childMainPosition -= childBetweenSpace; else childMainPosition += childMainAxisExtent + childBetweenSpace;
            child = childParentData.NextSibling;
        }

        if (flipCrossAxis) crossAxisOffset -= runBetweenSpace; else crossAxisOffset += runCrossAxisExtent + runBetweenSpace;
    }

}




public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    return DefaultHitTestChildren(result, position: position);
}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (_HasVisualOverflow) context.PushClipRect(NeedsCompositing, offset, Dart: uiDefaultClass.Offset.Zero & Size, DefaultPaint); else DefaultPaint(context, offset);
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new EnumProperty<Axis>("direction", Direction));
    properties.Add(new EnumProperty<WrapAlignment>("alignment", Alignment));
    properties.Add(new DoubleProperty("spacing", Spacing));
    properties.Add(new EnumProperty<WrapAlignment>("runAlignment", RunAlignment));
    properties.Add(new DoubleProperty("runSpacing", RunSpacing));
    properties.Add(new DoubleProperty("crossAxisAlignment", RunSpacing));
    properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
    properties.Add(new EnumProperty<VerticalDirection>("verticalDirection", VerticalDirection, defaultValue: VerticalDirection.Down));
}



#endregion
}


/// <Summary>
/// How [Wrap] should align objects.
///
/// Used both to align children within a run in the main axis as well as to
/// align the runs themselves in the cross axis.
/// </Summary>
public enum WrapAlignment
{

    /// <Summary>
    /// Place the objects as close to the start of the axis as possible.
    ///
    /// If this value is used in a horizontal direction, a [TextDirection] must be
    /// available to determine if the start is the left or the right.
    ///
    /// If this value is used in a vertical direction, a [VerticalDirection] must be
    /// available to determine if the start is the top or the bottom.
    /// </Summary>
    Start,
    /// <Summary>
    /// Place the objects as close to the end of the axis as possible.
    ///
    /// If this value is used in a horizontal direction, a [TextDirection] must be
    /// available to determine if the end is the left or the right.
    ///
    /// If this value is used in a vertical direction, a [VerticalDirection] must be
    /// available to determine if the end is the top or the bottom.
    /// </Summary>
    End,
    /// <Summary>
    /// Place the objects as close to the middle of the axis as possible.
    /// </Summary>
    Center,
    /// <Summary>
    /// Place the free space evenly between the objects.
    /// </Summary>
    SpaceBetween,
    /// <Summary>
    /// Place the free space evenly between the objects as well as half of that
    /// space before and after the first and last objects.
    /// </Summary>
    SpaceAround,
    /// <Summary>
    /// Place the free space evenly between the objects as well as before and
    /// after the first and last objects.
    /// </Summary>
    SpaceEvenly,
}


/// <Summary>
/// Who [Wrap] should align children within a run in the cross axis.
/// </Summary>
public enum WrapCrossAlignment
{

    /// <Summary>
    /// Place the children as close to the start of the run in the cross axis as
    /// possible.
    ///
    /// If this value is used in a horizontal direction, a [TextDirection] must be
    /// available to determine if the start is the left or the right.
    ///
    /// If this value is used in a vertical direction, a [VerticalDirection] must be
    /// available to determine if the start is the top or the bottom.
    /// </Summary>
    Start,
    /// <Summary>
    /// Place the children as close to the end of the run in the cross axis as
    /// possible.
    ///
    /// If this value is used in a horizontal direction, a [TextDirection] must be
    /// available to determine if the end is the left or the right.
    ///
    /// If this value is used in a vertical direction, a [VerticalDirection] must be
    /// available to determine if the end is the top or the bottom.
    /// </Summary>
    End,
    /// <Summary>
    /// Place the children as close to the middle of the run in the cross axis as
    /// possible.
    /// </Summary>
    Center,
}

}
