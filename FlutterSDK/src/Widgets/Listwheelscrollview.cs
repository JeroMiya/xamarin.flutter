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
using FlutterSDK.Widgets.Constants;
namespace FlutterSDK.Widgets.Listwheelscrollview{
internal static class ListwheelscrollviewDefaultClass{
internal static int _GetItemFromOffset(double offset = default(double),double itemExtent = default(double),double minScrollExtent = default(double),double maxScrollExtent = default(double)){
throw new NotImplementedException();
}

internal static double _ClipOffsetToScrollableRange(double offset,double minScrollExtent,double maxScrollExtent){
throw new NotImplementedException();
}

}

public interface IFixedExtentMetrics{
FlutterSDK.Widgets.Listwheelscrollview.FixedExtentMetrics CopyWith(double minScrollExtent = default(double),double maxScrollExtent = default(double),double pixels = default(double),double viewportDimension = default(double),FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection),int itemIndex = default(int));
int ItemIndex{get;}
}


public interface IListWheelChildDelegate{}

public class ListWheelChildDelegate{
public virtual int EstimatedChildCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}

public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context,int index){ throw new NotImplementedException(); }


public virtual int TrueIndexOf(int index){ throw new NotImplementedException(); }


public virtual bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate oldDelegate){ throw new NotImplementedException(); }

}
public static class ListWheelChildDelegateMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<IListWheelChildDelegate, ListWheelChildDelegate> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IListWheelChildDelegate, ListWheelChildDelegate>();
static ListWheelChildDelegate GetOrCreate(IListWheelChildDelegate instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new ListWheelChildDelegate();
_table.Add(instance, value);
}
return (ListWheelChildDelegate)value;
}
public static int EstimatedChildCountProperty(this IListWheelChildDelegate instance) => GetOrCreate(instance).EstimatedChildCount;
public static FlutterSDK.Widgets.Framework.Widget Build(this IListWheelChildDelegate instance,FlutterSDK.Widgets.Framework.BuildContext context,int index) => GetOrCreate(instance).Build(context, index);
public static int TrueIndexOf(this IListWheelChildDelegate instance,int index) => GetOrCreate(instance).TrueIndexOf(index);
public static bool ShouldRebuild(this IListWheelChildDelegate instance,FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate oldDelegate) => GetOrCreate(instance).ShouldRebuild(oldDelegate);
}


public class ListWheelChildListDelegate : FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate
{
#region constructors
public ListWheelChildListDelegate(List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
: base()
{
this.Children = children;throw new NotImplementedException(); }
#endregion

#region fields
public virtual List<FlutterSDK.Widgets.Framework.Widget> Children{get;set;}
public virtual int EstimatedChildCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context,int index){ throw new NotImplementedException(); }


public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildListDelegate oldDelegate){ throw new NotImplementedException(); }
public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate oldDelegate){ throw new NotImplementedException(); }

#endregion
}


public class ListWheelChildLoopingListDelegate : FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate
{
#region constructors
public ListWheelChildLoopingListDelegate(List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
: base()
{
this.Children = children;throw new NotImplementedException(); }
#endregion

#region fields
public virtual List<FlutterSDK.Widgets.Framework.Widget> Children{get;set;}
public virtual int EstimatedChildCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new int TrueIndexOf(int index){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context,int index){ throw new NotImplementedException(); }


public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildLoopingListDelegate oldDelegate){ throw new NotImplementedException(); }
public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate oldDelegate){ throw new NotImplementedException(); }

#endregion
}


public class ListWheelChildBuilderDelegate : FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate
{
#region constructors
public ListWheelChildBuilderDelegate(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder builder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder),int childCount = default(int))
: base()
{
this.Builder = builder;
this.ChildCount = childCount;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.IndexedWidgetBuilder Builder{get;set;}
public virtual int ChildCount{get;set;}
public virtual int EstimatedChildCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context,int index){ throw new NotImplementedException(); }


public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildBuilderDelegate oldDelegate){ throw new NotImplementedException(); }
public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate oldDelegate){ throw new NotImplementedException(); }

#endregion
}


public class FixedExtentScrollController : FlutterSDK.Widgets.Scrollcontroller.ScrollController
{
#region constructors
public FixedExtentScrollController(int initialItem = 0)
: base()
{
this.InitialItem = initialItem;throw new NotImplementedException(); }
#endregion

#region fields
public virtual int InitialItem{get;set;}
public virtual int SelectedItem{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual Future<object> AnimateToItem(int itemIndex,TimeSpan duration = default(TimeSpan),FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)){ throw new NotImplementedException(); }


public virtual void JumpToItem(int itemIndex){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Scrollposition.ScrollPosition CreateScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics,FlutterSDK.Widgets.Scrollcontext.ScrollContext context,FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition){ throw new NotImplementedException(); }

#endregion
}


public class FixedExtentMetrics : FlutterSDK.Widgets.Scrollmetrics.FixedScrollMetrics
{
#region constructors
public FixedExtentMetrics(double minScrollExtent = default(double),double maxScrollExtent = default(double),double pixels = default(double),double viewportDimension = default(double),FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection),int itemIndex = default(int))
: base(minScrollExtent:minScrollExtent,maxScrollExtent:maxScrollExtent,pixels:pixels,viewportDimension:viewportDimension,axisDirection:axisDirection)
{
this.ItemIndex = itemIndex;throw new NotImplementedException(); }
#endregion

#region fields
public virtual int ItemIndex{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Listwheelscrollview.FixedExtentMetrics CopyWith(double minScrollExtent = default(double),double maxScrollExtent = default(double),double pixels = default(double),double viewportDimension = default(double),FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection),int itemIndex = default(int)){ throw new NotImplementedException(); }

#endregion
}


public class _FixedExtentScrollPosition : FlutterSDK.Widgets.Scrollpositionwithsinglecontext.ScrollPositionWithSingleContext,IFixedExtentMetrics
{
#region constructors
public _FixedExtentScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),FlutterSDK.Widgets.Scrollcontext.ScrollContext context = default(FlutterSDK.Widgets.Scrollcontext.ScrollContext),int initialItem = default(int),bool keepScrollOffset = true,FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition),string debugLabel = default(string))
: base(physics:physics,context:context,initialPixels:_GetItemExtentFromScrollContext(context)*initialItem,keepScrollOffset:keepScrollOffset,oldPosition:oldPosition,debugLabel:debugLabel)
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual double ItemExtent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int ItemIndex{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private double _GetItemExtentFromScrollContext(FlutterSDK.Widgets.Scrollcontext.ScrollContext context){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Listwheelscrollview.FixedExtentMetrics CopyWith(double minScrollExtent = default(double),double maxScrollExtent = default(double),double pixels = default(double),double viewportDimension = default(double),FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection),int itemIndex = default(int)){ throw new NotImplementedException(); }

#endregion
}


public class _FixedExtentScrollable : FlutterSDK.Widgets.Scrollable.Scrollable
{
#region constructors
public _FixedExtentScrollable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection),FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),double itemExtent = default(double),FlutterSDK.Widgets.Scrollable.ViewportBuilder viewportBuilder = default(FlutterSDK.Widgets.Scrollable.ViewportBuilder))
: base(key:key,axisDirection:axisDirection,controller:controller,physics:physics,viewportBuilder:viewportBuilder)
{
this.ItemExtent = itemExtent;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double ItemExtent{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Listwheelscrollview._FixedExtentScrollableState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _FixedExtentScrollableState : FlutterSDK.Widgets.Scrollable.ScrollableState
{
#region constructors
public _FixedExtentScrollableState()
{ }
#endregion

#region fields
public virtual double ItemExtent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods
#endregion
}


public class FixedExtentScrollPhysics : FlutterSDK.Widgets.Scrollphysics.ScrollPhysics
{
#region constructors
public FixedExtentScrollPhysics(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics parent = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
: base(parent:parent)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollPhysics ApplyTo(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ancestor){ throw new NotImplementedException(); }


public new FlutterSDK.Physics.Simulation.Simulation CreateBallisticSimulation(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position,double velocity){ throw new NotImplementedException(); }

#endregion
}


public class ListWheelScrollView : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public ListWheelScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),double diameterRatio = default(double),double perspective = default(double),double offAxisFraction = 0.0,bool useMagnifier = false,double magnification = 1.0,double overAndUnderCenterOpacity = 1.0,double itemExtent = default(double),double squeeze = 1.0,FlutterSDK.Foundation.Basictypes.ValueChanged<int> onSelectedItemChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>),bool clipToSize = true,bool renderChildrenOutsideViewport = false,List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
: base(key:key)
{
this.Controller = controller;
this.Physics = physics;
this.DiameterRatio = diameterRatio;
this.Perspective = perspective;
this.OffAxisFraction = offAxisFraction;
this.UseMagnifier = useMagnifier;
this.Magnification = magnification;
this.OverAndUnderCenterOpacity = overAndUnderCenterOpacity;
this.ItemExtent = itemExtent;
this.Squeeze = squeeze;
this.OnSelectedItemChanged = onSelectedItemChanged;
this.ClipToSize = clipToSize;
this.RenderChildrenOutsideViewport = renderChildrenOutsideViewport;throw new NotImplementedException(); }
public static ListWheelScrollView UseDelegate(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),double diameterRatio = default(double),double perspective = default(double),double offAxisFraction = 0.0,bool useMagnifier = false,double magnification = 1.0,double overAndUnderCenterOpacity = 1.0,double itemExtent = default(double),double squeeze = 1.0,FlutterSDK.Foundation.Basictypes.ValueChanged<int> onSelectedItemChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>),bool clipToSize = true,bool renderChildrenOutsideViewport = false,FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate childDelegate = default(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate))
{
var instance =new ListWheelScrollView(key:key);instance.Controller = controller;
instance.Physics = physics;
instance.DiameterRatio = diameterRatio;
instance.Perspective = perspective;
instance.OffAxisFraction = offAxisFraction;
instance.UseMagnifier = useMagnifier;
instance.Magnification = magnification;
instance.OverAndUnderCenterOpacity = overAndUnderCenterOpacity;
instance.ItemExtent = itemExtent;
instance.Squeeze = squeeze;
instance.OnSelectedItemChanged = onSelectedItemChanged;
instance.ClipToSize = clipToSize;
instance.RenderChildrenOutsideViewport = renderChildrenOutsideViewport;
instance.ChildDelegate = childDelegate;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller{get;set;}
public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics{get;set;}
public virtual double DiameterRatio{get;set;}
public virtual double Perspective{get;set;}
public virtual double OffAxisFraction{get;set;}
public virtual bool UseMagnifier{get;set;}
public virtual double Magnification{get;set;}
public virtual double OverAndUnderCenterOpacity{get;set;}
public virtual double ItemExtent{get;set;}
public virtual double Squeeze{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnSelectedItemChanged{get;set;}
public virtual bool ClipToSize{get;set;}
public virtual bool RenderChildrenOutsideViewport{get;set;}
public virtual FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate ChildDelegate{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Listwheelscrollview._ListWheelScrollViewState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _ListWheelScrollViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Listwheelscrollview.ListWheelScrollView>
{
#region constructors
public _ListWheelScrollViewState()
{ }
#endregion

#region fields
internal virtual int _LastReportedItemIndex{get;set;}
public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController{get;set;}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


public new void DidUpdateWidget(FlutterSDK.Widgets.Listwheelscrollview.ListWheelScrollView oldWidget){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class ListWheelElement : FlutterSDK.Widgets.Framework.RenderObjectElement,IListWheelChildManager
{
#region constructors
public ListWheelElement(FlutterSDK.Widgets.Listwheelscrollview.ListWheelViewport widget)
: base(widget)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual Dictionary<int,FlutterSDK.Widgets.Framework.Widget> _ChildWidgets{get;set;}
internal virtual SplayTreeMap<int,FlutterSDK.Widgets.Framework.Element> _ChildElements{get;set;}
public virtual FlutterSDK.Widgets.Listwheelscrollview.ListWheelViewport Widget{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Rendering.Listwheelviewport.RenderListWheelViewport RenderObject{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int ChildCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void Update(FlutterSDK.Widgets.Listwheelscrollview.ListWheelViewport newWidget){ throw new NotImplementedException(); }
public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget){ throw new NotImplementedException(); }


public new void PerformRebuild(){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Framework.Widget RetrieveWidget(int index){ throw new NotImplementedException(); }


public new bool ChildExistsAt(int index){ throw new NotImplementedException(); }


public new void CreateChild(int index,FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox)){ throw new NotImplementedException(); }


public new void RemoveChild(FlutterSDK.Rendering.Box.RenderBox child){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Element UpdateChild(FlutterSDK.Widgets.Framework.Element child,FlutterSDK.Widgets.Framework.Widget newWidget,object newSlot){ throw new NotImplementedException(); }


public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child,int slot){ throw new NotImplementedException(); }
public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child,object slot){ throw new NotImplementedException(); }


public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child,object slot){ throw new NotImplementedException(); }


public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor){ throw new NotImplementedException(); }


public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child){ throw new NotImplementedException(); }

#endregion
}


public class ListWheelViewport : FlutterSDK.Widgets.Framework.RenderObjectWidget
{
#region constructors
public ListWheelViewport(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),double diameterRatio = default(double),double perspective = default(double),double offAxisFraction = 0.0,bool useMagnifier = false,double magnification = 1.0,double overAndUnderCenterOpacity = 1.0,double itemExtent = default(double),double squeeze = 1.0,bool clipToSize = true,bool renderChildrenOutsideViewport = false,FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset),FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate childDelegate = default(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate))
: base(key:key)
{
this.DiameterRatio = diameterRatio;
this.Perspective = perspective;
this.OffAxisFraction = offAxisFraction;
this.UseMagnifier = useMagnifier;
this.Magnification = magnification;
this.OverAndUnderCenterOpacity = overAndUnderCenterOpacity;
this.ItemExtent = itemExtent;
this.Squeeze = squeeze;
this.ClipToSize = clipToSize;
this.RenderChildrenOutsideViewport = renderChildrenOutsideViewport;
this.Offset = offset;
this.ChildDelegate = childDelegate;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double DiameterRatio{get;set;}
public virtual double Perspective{get;set;}
public virtual double OffAxisFraction{get;set;}
public virtual bool UseMagnifier{get;set;}
public virtual double Magnification{get;set;}
public virtual double OverAndUnderCenterOpacity{get;set;}
public virtual double ItemExtent{get;set;}
public virtual double Squeeze{get;set;}
public virtual bool ClipToSize{get;set;}
public virtual bool RenderChildrenOutsideViewport{get;set;}
public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset{get;set;}
public virtual FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate ChildDelegate{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Listwheelscrollview.ListWheelElement CreateElement(){ throw new NotImplementedException(); }


public new FlutterSDK.Rendering.Listwheelviewport.RenderListWheelViewport CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Rendering.Listwheelviewport.RenderListWheelViewport renderObject){ throw new NotImplementedException(); }
public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Rendering.@object.RenderObject renderObject){ throw new NotImplementedException(); }

#endregion
}

}
