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
namespace FlutterSDK.Rendering.Proxybox{
public delegate SKShader ShaderCallback(FlutterBinding.UI.Rect bounds);
public delegate void PointerDownEventListener(FlutterSDK.Gestures.Events.PointerDownEvent @event);
public delegate void PointerMoveEventListener(FlutterSDK.Gestures.Events.PointerMoveEvent @event);
public delegate void PointerUpEventListener(FlutterSDK.Gestures.Events.PointerUpEvent @event);
public delegate void PointerCancelEventListener(FlutterSDK.Gestures.Events.PointerCancelEvent @event);
public delegate void PointerSignalEventListener(FlutterSDK.Gestures.Events.PointerSignalEvent @event);
internal static class ProxyboxDefaultClass{
}

public interface IRenderProxyBoxWithHitTestBehavior{
bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset));
bool HitTestSelf(FlutterBinding.UI.Offset position);
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior{get;set;}
}


public interface ICustomClipper<T>{
T GetClip(Size size);
Rect GetApproximateClipRect(Size size);
bool ShouldReclip(FlutterSDK.Rendering.Proxybox.CustomClipper<T> oldClipper);
string ToString();
}


internal interface I_RenderCustomClip<T>{
void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner);
void Detach();
void PerformLayout();
Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child);
void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset);
FlutterSDK.Rendering.Proxybox.CustomClipper<T> Clipper{get;set;}
FlutterBinding.UI.Clip ClipBehavior{get;set;}
}


internal interface I_RenderPhysicalModelBase<T>{
void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config);
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description);
double Elevation{get;set;}
FlutterBinding.UI.Color ShadowColor{get;set;}
FlutterBinding.UI.Color Color{get;set;}
bool AlwaysNeedsCompositing{get;}
}


public interface IRenderProxyBoxMixin<T>{}

public class RenderProxyBoxMixin<T>{

public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new double ComputeDistanceToActualBaseline(TextBaseline baseline){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

}
public static class RenderProxyBoxMixinMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
static RenderProxyBoxMixin<T> GetOrCreate<T>(IRenderProxyBoxMixin<T> instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new RenderProxyBoxMixin<T>();
_table.Add(instance, value);
}
return (RenderProxyBoxMixin<T>)value;
}
public static void SetupParentData<T>(this IRenderProxyBoxMixin<T> instance,FlutterSDK.Rendering.@object.RenderObject child) => GetOrCreate(instance).SetupParentData(child);
public static double ComputeMinIntrinsicWidth<T>(this IRenderProxyBoxMixin<T> instance,double height) => GetOrCreate(instance).ComputeMinIntrinsicWidth(height);
public static double ComputeMaxIntrinsicWidth<T>(this IRenderProxyBoxMixin<T> instance,double height) => GetOrCreate(instance).ComputeMaxIntrinsicWidth(height);
public static double ComputeMinIntrinsicHeight<T>(this IRenderProxyBoxMixin<T> instance,double width) => GetOrCreate(instance).ComputeMinIntrinsicHeight(width);
public static double ComputeMaxIntrinsicHeight<T>(this IRenderProxyBoxMixin<T> instance,double width) => GetOrCreate(instance).ComputeMaxIntrinsicHeight(width);
public static double ComputeDistanceToActualBaseline<T>(this IRenderProxyBoxMixin<T> instance,TextBaseline baseline) => GetOrCreate(instance).ComputeDistanceToActualBaseline(baseline);
public static void PerformLayout<T>(this IRenderProxyBoxMixin<T> instance) => GetOrCreate(instance).PerformLayout();
public static bool HitTestChildren<T>(this IRenderProxyBoxMixin<T> instance,FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) => GetOrCreate(instance).HitTestChildren(result, position);
public static void ApplyPaintTransform<T>(this IRenderProxyBoxMixin<T> instance,FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform) => GetOrCreate(instance).ApplyPaintTransform(child, transform);
public static void Paint<T>(this IRenderProxyBoxMixin<T> instance,FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset) => GetOrCreate(instance).Paint(context, offset);
}


public interface IRenderAnimatedOpacityMixin<T>{}

public class RenderAnimatedOpacityMixin<T>{
internal virtual int _Alpha{get;set;}
internal virtual bool _CurrentlyNeedsCompositing{get;set;}
internal virtual FlutterSDK.Animation.Animation.Animation<double> _Opacity{get;set;}
internal virtual bool _AlwaysIncludeSemantics{get;set;}
public virtual bool AlwaysNeedsCompositing{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Animation.Animation.Animation<double> Opacity{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool AlwaysIncludeSemantics{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}

public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner){ throw new NotImplementedException(); }
public new void Attach(@Object owner){ throw new NotImplementedException(); }


public new void Detach(){ throw new NotImplementedException(); }


private void _UpdateOpacity(){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

}
public static class RenderAnimatedOpacityMixinMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
static RenderAnimatedOpacityMixin<T> GetOrCreate<T>(IRenderAnimatedOpacityMixin<T> instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new RenderAnimatedOpacityMixin<T>();
_table.Add(instance, value);
}
return (RenderAnimatedOpacityMixin<T>)value;
}
public static bool AlwaysNeedsCompositingProperty<T>(this IRenderAnimatedOpacityMixin<T> instance) => GetOrCreate(instance).AlwaysNeedsCompositing;
public static FlutterSDK.Animation.Animation.Animation<double> OpacityProperty<T>(this IRenderAnimatedOpacityMixin<T> instance) => GetOrCreate(instance).Opacity;
public static bool AlwaysIncludeSemanticsProperty<T>(this IRenderAnimatedOpacityMixin<T> instance) => GetOrCreate(instance).AlwaysIncludeSemantics;
public static void Attach<T>(this IRenderAnimatedOpacityMixin<T> instance,FlutterSDK.Rendering.@object.PipelineOwner owner) => GetOrCreate(instance).Attach(owner);
public static void Detach<T>(this IRenderAnimatedOpacityMixin<T> instance) => GetOrCreate(instance).Detach();
public static void Paint<T>(this IRenderAnimatedOpacityMixin<T> instance,FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset) => GetOrCreate(instance).Paint(context, offset);
public static void VisitChildrenForSemantics<T>(this IRenderAnimatedOpacityMixin<T> instance,FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) => GetOrCreate(instance).VisitChildrenForSemantics(visitor);
public static void DebugFillProperties<T>(this IRenderAnimatedOpacityMixin<T> instance,FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) => GetOrCreate(instance).DebugFillProperties(properties);
}


public class RenderProxyBox : FlutterSDK.Rendering.Box.RenderBox,IRenderObjectWithChildMixin<FlutterSDK.Rendering.Box.RenderBox>,IRenderProxyBoxMixin<FlutterSDK.Rendering.Box.RenderBox>
{
#region constructors
public RenderProxyBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods
#endregion
}


public class RenderProxyBoxWithHitTestBehavior : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderProxyBoxWithHitTestBehavior(FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior),FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
this.Behavior = behavior;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior{get;set;}
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new bool HitTestSelf(FlutterBinding.UI.Offset position){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderConstrainedBox : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderConstrainedBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Box.BoxConstraints _AdditionalConstraints{get;set;}
public virtual FlutterSDK.Rendering.Box.BoxConstraints AdditionalConstraints{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new double ComputeMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderLimitedBox : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderLimitedBox(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),double maxWidth = default(double),double maxHeight = default(double))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual double _MaxWidth{get;set;}
internal virtual double _MaxHeight{get;set;}
public virtual double MaxWidth{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual double MaxHeight{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

private FlutterSDK.Rendering.Box.BoxConstraints _LimitConstraints(FlutterSDK.Rendering.Box.BoxConstraints constraints){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderAspectRatio : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderAspectRatio(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),double aspectRatio = default(double))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual double _AspectRatio{get;set;}
public virtual double AspectRatio{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new double ComputeMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicHeight(double width){ throw new NotImplementedException(); }


private Size _ApplyAspectRatio(FlutterSDK.Rendering.Box.BoxConstraints constraints){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderIntrinsicWidth : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderIntrinsicWidth(double stepWidth = default(double),double stepHeight = default(double),FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual double _StepWidth{get;set;}
internal virtual double _StepHeight{get;set;}
public virtual double StepWidth{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual double StepHeight{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

private double _ApplyStep(double input,double step){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderIntrinsicHeight : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderIntrinsicHeight(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new double ComputeMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }

#endregion
}


public class RenderOpacity : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderOpacity(double opacity = 1.0,bool alwaysIncludeSemantics = false,FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual int _Alpha{get;set;}
internal virtual double _Opacity{get;set;}
internal virtual bool _AlwaysIncludeSemantics{get;set;}
public virtual bool AlwaysNeedsCompositing{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double Opacity{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool AlwaysIncludeSemantics{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderAnimatedOpacity : FlutterSDK.Rendering.Proxybox.RenderProxyBox,IRenderProxyBoxMixin<FlutterSDK.Rendering.Box.RenderBox>,IRenderAnimatedOpacityMixin<FlutterSDK.Rendering.Box.RenderBox>
{
#region constructors
public RenderAnimatedOpacity(FlutterSDK.Animation.Animation.Animation<double> opacity = default(FlutterSDK.Animation.Animation.Animation<double>),bool alwaysIncludeSemantics = false,FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods
#endregion
}


public class RenderShaderMask : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderShaderMask(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Rendering.Proxybox.ShaderCallback shaderCallback = default(FlutterSDK.Rendering.Proxybox.ShaderCallback),FlutterBinding.UI.BlendMode blendMode = default(FlutterBinding.UI.BlendMode))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Proxybox.ShaderCallback _ShaderCallback{get;set;}
internal virtual FlutterBinding.UI.BlendMode _BlendMode{get;set;}
public virtual FlutterSDK.Rendering.Layer.ShaderMaskLayer Layer{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Rendering.Proxybox.ShaderCallback ShaderCallback{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.BlendMode BlendMode{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool AlwaysNeedsCompositing{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

#endregion
}


public class RenderBackdropFilter : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderBackdropFilter(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),ImageFilter filter = default(ImageFilter))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual ImageFilter _Filter{get;set;}
public virtual FlutterSDK.Rendering.Layer.BackdropFilterLayer Layer{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual ImageFilter Filter{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool AlwaysNeedsCompositing{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

#endregion
}


public class CustomClipper<T>
{
#region constructors
public CustomClipper(FlutterSDK.Foundation.Changenotifier.Listenable reclip = default(FlutterSDK.Foundation.Changenotifier.Listenable))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Foundation.Changenotifier.Listenable _Reclip{get;set;}
#endregion

#region methods

public virtual T GetClip(Size size){ throw new NotImplementedException(); }


public virtual Rect GetApproximateClipRect(Size size){ throw new NotImplementedException(); }


public virtual bool ShouldReclip(FlutterSDK.Rendering.Proxybox.CustomClipper<T> oldClipper){ throw new NotImplementedException(); }


#endregion
}


public class ShapeBorderClipper : FlutterSDK.Rendering.Proxybox.CustomClipper<Path>
{
#region constructors
public ShapeBorderClipper(FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder),TextDirection textDirection = default(TextDirection))
: base()
{
this.Shape = shape;
this.TextDirection = textDirection;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape{get;set;}
public virtual TextDirection TextDirection{get;set;}
#endregion

#region methods

public new Path GetClip(Size size){ throw new NotImplementedException(); }


public new bool ShouldReclip(FlutterSDK.Rendering.Proxybox.CustomClipper<Path> oldClipper){ throw new NotImplementedException(); }

#endregion
}


public class _RenderCustomClip<T> : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public _RenderCustomClip(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Rendering.Proxybox.CustomClipper<T> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<T>),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Proxybox.CustomClipper<T> _Clipper{get;set;}
internal virtual T _Clip{get;set;}
internal virtual FlutterBinding.UI.Clip _ClipBehavior{get;set;}
internal virtual SKPaint _DebugPaint{get;set;}
internal virtual FlutterSDK.Painting.Textpainter.TextPainter _DebugText{get;set;}
public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<T> Clipper{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
internal virtual T _DefaultClip{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterBinding.UI.Clip ClipBehavior{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner){ throw new NotImplementedException(); }
public new void Attach(@Object owner){ throw new NotImplementedException(); }


public new void Detach(){ throw new NotImplementedException(); }


private void _MarkNeedsClip(){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


private void _UpdateClip(){ throw new NotImplementedException(); }


public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

#endregion
}


public class RenderClipRect : FlutterSDK.Rendering.Proxybox._RenderCustomClip<Rect>
{
#region constructors
public RenderClipRect(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Rect>),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
: base(child:child,clipper:clipper,clipBehavior:clipBehavior)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterBinding.UI.Rect _DefaultClip{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

#endregion
}


public class RenderClipRRect : FlutterSDK.Rendering.Proxybox._RenderCustomClip<RRect>
{
#region constructors
public RenderClipRRect(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius),FlutterSDK.Rendering.Proxybox.CustomClipper<RRect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<RRect>),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
: base(child:child,clipper:clipper,clipBehavior:clipBehavior)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Painting.Borderradius.BorderRadius _BorderRadius{get;set;}
public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
internal virtual FlutterBinding.UI.RRect _DefaultClip{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

#endregion
}


public class RenderClipOval : FlutterSDK.Rendering.Proxybox._RenderCustomClip<Rect>
{
#region constructors
public RenderClipOval(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Rect>),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
: base(child:child,clipper:clipper,clipBehavior:clipBehavior)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterBinding.UI.Rect _CachedRect{get;set;}
internal virtual Path _CachedPath{get;set;}
internal virtual FlutterBinding.UI.Rect _DefaultClip{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private Path _GetClipPath(FlutterBinding.UI.Rect rect){ throw new NotImplementedException(); }


public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

#endregion
}


public class RenderClipPath : FlutterSDK.Rendering.Proxybox._RenderCustomClip<Path>
{
#region constructors
public RenderClipPath(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Rendering.Proxybox.CustomClipper<Path> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Path>),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
: base(child:child,clipper:clipper,clipBehavior:clipBehavior)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual Path _DefaultClip{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

#endregion
}


public class _RenderPhysicalModelBase<T> : FlutterSDK.Rendering.Proxybox._RenderCustomClip<T>
{
#region constructors
public _RenderPhysicalModelBase(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),double elevation = default(double),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),FlutterSDK.Rendering.Proxybox.CustomClipper<T> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<T>))
: base(child:child,clipBehavior:clipBehavior,clipper:clipper)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual double _Elevation{get;set;}
internal virtual FlutterBinding.UI.Color _ShadowColor{get;set;}
internal virtual FlutterBinding.UI.Color _Color{get;set;}
public virtual double Elevation{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Color ShadowColor{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Color Color{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool AlwaysNeedsCompositing{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description){ throw new NotImplementedException(); }

#endregion
}


public class RenderPhysicalModel : FlutterSDK.Rendering.Proxybox._RenderPhysicalModelBase<RRect>
{
#region constructors
public RenderPhysicalModel(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius),double elevation = 0.0,FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
: base(clipBehavior:clipBehavior,child:child,elevation:elevation,color:color,shadowColor:shadowColor)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Painting.Boxborder.BoxShape _Shape{get;set;}
internal virtual FlutterSDK.Painting.Borderradius.BorderRadius _BorderRadius{get;set;}
public virtual FlutterSDK.Rendering.Layer.PhysicalModelLayer Layer{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Painting.Boxborder.BoxShape Shape{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
internal virtual FlutterBinding.UI.RRect _DefaultClip{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description){ throw new NotImplementedException(); }

#endregion
}


public class RenderPhysicalShape : FlutterSDK.Rendering.Proxybox._RenderPhysicalModelBase<Path>
{
#region constructors
public RenderPhysicalShape(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Rendering.Proxybox.CustomClipper<Path> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Path>),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),double elevation = 0.0,FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
: base(child:child,elevation:elevation,color:color,shadowColor:shadowColor,clipper:clipper,clipBehavior:clipBehavior)
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Rendering.Layer.PhysicalModelLayer Layer{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Path _DefaultClip{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description){ throw new NotImplementedException(); }

#endregion
}


public class RenderDecoratedBox : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderDecoratedBox(FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration),FlutterSDK.Rendering.Proxybox.DecorationPosition position = default(FlutterSDK.Rendering.Proxybox.DecorationPosition),FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration),FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Painting.Decoration.BoxPainter _Painter{get;set;}
internal virtual FlutterSDK.Painting.Decoration.Decoration _Decoration{get;set;}
internal virtual FlutterSDK.Rendering.Proxybox.DecorationPosition _Position{get;set;}
internal virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration _Configuration{get;set;}
public virtual FlutterSDK.Painting.Decoration.Decoration Decoration{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Rendering.Proxybox.DecorationPosition Position{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration Configuration{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void Detach(){ throw new NotImplementedException(); }


public new bool HitTestSelf(FlutterBinding.UI.Offset position){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderTransform : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderTransform(Matrix4 transform = default(Matrix4),FlutterBinding.UI.Offset origin = default(FlutterBinding.UI.Offset),FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry),TextDirection textDirection = default(TextDirection),bool transformHitTests = true,FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
this.TransformHitTests = transformHitTests;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterBinding.UI.Offset _Origin{get;set;}
internal virtual FlutterSDK.Painting.Alignment.AlignmentGeometry _Alignment{get;set;}
internal virtual TextDirection _TextDirection{get;set;}
public virtual bool TransformHitTests{get;set;}
internal virtual Matrix4 _Transform{get;set;}
public virtual FlutterBinding.UI.Offset Origin{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual TextDirection TextDirection{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual object Transform{set {throw new NotImplementedException();}}
internal virtual object _EffectiveTransform{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual void SetIdentity(){ throw new NotImplementedException(); }


public virtual void RotateX(double radians){ throw new NotImplementedException(); }


public virtual void RotateY(double radians){ throw new NotImplementedException(); }


public virtual void RotateZ(double radians){ throw new NotImplementedException(); }


public virtual void Translate(double x,double y = 0.0,double z = 0.0){ throw new NotImplementedException(); }


public virtual void Scale(double x,double y = default(double),double z = default(double)){ throw new NotImplementedException(); }


public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child,Matrix4 transform){ throw new NotImplementedException(); }
public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderFittedBox : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderFittedBox(FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit),FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry),TextDirection textDirection = default(TextDirection),FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Painting.Alignment.Alignment _ResolvedAlignment{get;set;}
internal virtual FlutterSDK.Painting.Boxfit.BoxFit _Fit{get;set;}
internal virtual FlutterSDK.Painting.Alignment.AlignmentGeometry _Alignment{get;set;}
internal virtual TextDirection _TextDirection{get;set;}
internal virtual bool _HasVisualOverflow{get;set;}
internal virtual Matrix4 _Transform{get;set;}
public virtual FlutterSDK.Painting.Boxfit.BoxFit Fit{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual TextDirection TextDirection{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

private void _Resolve(){ throw new NotImplementedException(); }


private void _MarkNeedResolution(){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


private void _ClearPaintData(){ throw new NotImplementedException(); }


private void _UpdatePaintData(){ throw new NotImplementedException(); }


private FlutterSDK.Rendering.Layer.TransformLayer _PaintChildWithTransform(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child,Matrix4 transform){ throw new NotImplementedException(); }
public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderFractionalTranslation : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderFractionalTranslation(FlutterBinding.UI.Offset translation = default(FlutterBinding.UI.Offset),bool transformHitTests = true,FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
this.TransformHitTests = transformHitTests;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterBinding.UI.Offset _Translation{get;set;}
public virtual bool TransformHitTests{get;set;}
public virtual FlutterBinding.UI.Offset Translation{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child,Matrix4 transform){ throw new NotImplementedException(); }
public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderPointerListener : FlutterSDK.Rendering.Proxybox.RenderProxyBoxWithHitTestBehavior
{
#region constructors
public RenderPointerListener(FlutterSDK.Rendering.Proxybox.PointerDownEventListener onPointerDown = default(FlutterSDK.Rendering.Proxybox.PointerDownEventListener),FlutterSDK.Rendering.Proxybox.PointerMoveEventListener onPointerMove = default(FlutterSDK.Rendering.Proxybox.PointerMoveEventListener),FlutterSDK.Rendering.Proxybox.PointerUpEventListener onPointerUp = default(FlutterSDK.Rendering.Proxybox.PointerUpEventListener),FlutterSDK.Rendering.Proxybox.PointerCancelEventListener onPointerCancel = default(FlutterSDK.Rendering.Proxybox.PointerCancelEventListener),FlutterSDK.Rendering.Proxybox.PointerSignalEventListener onPointerSignal = default(FlutterSDK.Rendering.Proxybox.PointerSignalEventListener),FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior),FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(behavior:behavior,child:child)
{
this.OnPointerDown = onPointerDown;
this.OnPointerMove = onPointerMove;
this.OnPointerUp = onPointerUp;
this.OnPointerCancel = onPointerCancel;
this.OnPointerSignal = onPointerSignal;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Rendering.Proxybox.PointerDownEventListener OnPointerDown{get;set;}
public virtual FlutterSDK.Rendering.Proxybox.PointerMoveEventListener OnPointerMove{get;set;}
public virtual FlutterSDK.Rendering.Proxybox.PointerUpEventListener OnPointerUp{get;set;}
public virtual FlutterSDK.Rendering.Proxybox.PointerCancelEventListener OnPointerCancel{get;set;}
public virtual FlutterSDK.Rendering.Proxybox.PointerSignalEventListener OnPointerSignal{get;set;}
#endregion

#region methods

public new void PerformResize(){ throw new NotImplementedException(); }


public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event,FlutterSDK.Gestures.Hittest.HitTestEntry entry){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderMouseRegion : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderMouseRegion(FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener onEnter = default(FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener),FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener onHover = default(FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener),FlutterSDK.Rendering.Mousetracking.PointerExitEventListener onExit = default(FlutterSDK.Rendering.Mousetracking.PointerExitEventListener),bool opaque = true,FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual bool _Opaque{get;set;}
internal virtual FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener _OnEnter{get;set;}
internal virtual FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener _OnHover{get;set;}
internal virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener _OnExit{get;set;}
internal virtual FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation _HoverAnnotation{get;set;}
internal virtual bool _AnnotationIsActive{get;set;}
public virtual bool Opaque{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener OnEnter{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener OnHover{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener OnExit{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation HoverAnnotation{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool NeedsCompositing{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private void _HandleEnter(FlutterSDK.Gestures.Events.PointerEnterEvent @event){ throw new NotImplementedException(); }


private void _HandleHover(FlutterSDK.Gestures.Events.PointerHoverEvent @event){ throw new NotImplementedException(); }


private void _HandleExit(FlutterSDK.Gestures.Events.PointerExitEvent @event){ throw new NotImplementedException(); }


private void _MarkPropertyUpdated(bool mustRepaint = default(bool)){ throw new NotImplementedException(); }


private void _SetAnnotationIsActive(bool value){ throw new NotImplementedException(); }


private void _HandleUpdatedMouseIsConnected(){ throw new NotImplementedException(); }


public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner){ throw new NotImplementedException(); }
public new void Attach(@Object owner){ throw new NotImplementedException(); }


public new void Detach(){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void PerformResize(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderRepaintBoundary : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderRepaintBoundary(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual int _DebugSymmetricPaintCount{get;set;}
internal virtual int _DebugAsymmetricPaintCount{get;set;}
public virtual bool IsRepaintBoundary{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int DebugSymmetricPaintCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int DebugAsymmetricPaintCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual Future<SKImage> ToImage(double pixelRatio = 1.0){ throw new NotImplementedException(); }


public virtual void DebugResetMetrics(){ throw new NotImplementedException(); }


public new void DebugRegisterRepaintBoundaryPaint(bool includedParent = true,bool includedChild = false){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderIgnorePointer : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderIgnorePointer(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),bool ignoring = true,bool ignoringSemantics = default(bool))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual bool _Ignoring{get;set;}
internal virtual bool _IgnoringSemantics{get;set;}
public virtual bool Ignoring{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IgnoringSemantics{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
internal virtual bool _EffectiveIgnoringSemantics{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderOffstage : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderOffstage(bool offstage = true,FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual bool _Offstage{get;set;}
public virtual bool Offstage{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool SizedByParent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new double ComputeMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new double ComputeDistanceToActualBaseline(TextBaseline baseline){ throw new NotImplementedException(); }


public new void PerformResize(){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }


public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren(){ throw new NotImplementedException(); }

#endregion
}


public class RenderAbsorbPointer : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderAbsorbPointer(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),bool absorbing = true,bool ignoringSemantics = default(bool))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual bool _Absorbing{get;set;}
internal virtual bool _IgnoringSemantics{get;set;}
public virtual bool Absorbing{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IgnoringSemantics{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
internal virtual bool _EffectiveIgnoringSemantics{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderMetaData : FlutterSDK.Rendering.Proxybox.RenderProxyBoxWithHitTestBehavior
{
#region constructors
public RenderMetaData(object metaData = default(object),FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior),FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(behavior:behavior,child:child)
{
this.MetaData = metaData;throw new NotImplementedException(); }
#endregion

#region fields
public virtual object MetaData{get;set;}
#endregion

#region methods

public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderSemanticsGestureHandler : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderSemanticsGestureHandler(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback),FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback),FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback onHorizontalDragUpdate = default(FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback),FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback onVerticalDragUpdate = default(FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback),double scrollFactor = 0.8)
: base(child)
{
this.ScrollFactor = scrollFactor;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual HashSet<SemanticsAction> _ValidActions{get;set;}
internal virtual FlutterSDK.Gestures.Tap.GestureTapCallback _OnTap{get;set;}
internal virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback _OnLongPress{get;set;}
internal virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback _OnHorizontalDragUpdate{get;set;}
internal virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback _OnVerticalDragUpdate{get;set;}
public virtual double ScrollFactor{get;set;}
public virtual HashSet<SemanticsAction> ValidActions{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback OnLongPress{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnHorizontalDragUpdate{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnVerticalDragUpdate{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config){ throw new NotImplementedException(); }


private bool _IsValidAction(SemanticsAction action){ throw new NotImplementedException(); }


private void _PerformSemanticScrollLeft(){ throw new NotImplementedException(); }


private void _PerformSemanticScrollRight(){ throw new NotImplementedException(); }


private void _PerformSemanticScrollUp(){ throw new NotImplementedException(); }


private void _PerformSemanticScrollDown(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderSemanticsAnnotations : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderSemanticsAnnotations(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),bool container = false,bool explicitChildNodes = default(bool),bool excludeSemantics = false,bool enabled = default(bool),bool @checked = default(bool),bool toggled = default(bool),bool selected = default(bool),bool button = default(bool),bool link = default(bool),bool header = default(bool),bool textField = default(bool),bool readOnly = default(bool),bool focusable = default(bool),bool focused = default(bool),bool inMutuallyExclusiveGroup = default(bool),bool obscured = default(bool),bool multiline = default(bool),bool scopesRoute = default(bool),bool namesRoute = default(bool),bool hidden = default(bool),bool image = default(bool),bool liveRegion = default(bool),int maxValueLength = default(int),int currentValueLength = default(int),string label = default(string),string value = default(string),string increasedValue = default(string),string decreasedValue = default(string),string hint = default(string),FlutterSDK.Semantics.Semantics.SemanticsHintOverrides hintOverrides = default(FlutterSDK.Semantics.Semantics.SemanticsHintOverrides),TextDirection textDirection = default(TextDirection),FlutterSDK.Semantics.Semantics.SemanticsSortKey sortKey = default(FlutterSDK.Semantics.Semantics.SemanticsSortKey),VoidCallback onTap = default(VoidCallback),VoidCallback onDismiss = default(VoidCallback),VoidCallback onLongPress = default(VoidCallback),VoidCallback onScrollLeft = default(VoidCallback),VoidCallback onScrollRight = default(VoidCallback),VoidCallback onScrollUp = default(VoidCallback),VoidCallback onScrollDown = default(VoidCallback),VoidCallback onIncrease = default(VoidCallback),VoidCallback onDecrease = default(VoidCallback),VoidCallback onCopy = default(VoidCallback),VoidCallback onCut = default(VoidCallback),VoidCallback onPaste = default(VoidCallback),FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorForwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler),FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorBackwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler),FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorForwardByWord = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler),FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorBackwardByWord = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler),FlutterSDK.Semantics.Semantics.SetSelectionHandler onSetSelection = default(FlutterSDK.Semantics.Semantics.SetSelectionHandler),VoidCallback onDidGainAccessibilityFocus = default(VoidCallback),VoidCallback onDidLoseAccessibilityFocus = default(VoidCallback),Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object> customSemanticsActions = default(Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object>))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual bool _Container{get;set;}
internal virtual bool _ExplicitChildNodes{get;set;}
internal virtual bool _ExcludeSemantics{get;set;}
internal virtual bool _Checked{get;set;}
internal virtual bool _Enabled{get;set;}
internal virtual bool _Selected{get;set;}
internal virtual bool _Button{get;set;}
internal virtual bool _Link{get;set;}
internal virtual bool _Header{get;set;}
internal virtual bool _TextField{get;set;}
internal virtual bool _ReadOnly{get;set;}
internal virtual bool _Focusable{get;set;}
internal virtual bool _Focused{get;set;}
internal virtual bool _InMutuallyExclusiveGroup{get;set;}
internal virtual bool _Obscured{get;set;}
internal virtual bool _Multiline{get;set;}
internal virtual bool _ScopesRoute{get;set;}
internal virtual bool _NamesRoute{get;set;}
internal virtual bool _Hidden{get;set;}
internal virtual bool _Image{get;set;}
internal virtual bool _LiveRegion{get;set;}
internal virtual int _MaxValueLength{get;set;}
internal virtual int _CurrentValueLength{get;set;}
internal virtual bool _Toggled{get;set;}
internal virtual string _Label{get;set;}
internal virtual string _Value{get;set;}
internal virtual string _IncreasedValue{get;set;}
internal virtual string _DecreasedValue{get;set;}
internal virtual string _Hint{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides _HintOverrides{get;set;}
internal virtual TextDirection _TextDirection{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey _SortKey{get;set;}
internal virtual VoidCallback _OnTap{get;set;}
internal virtual VoidCallback _OnDismiss{get;set;}
internal virtual VoidCallback _OnLongPress{get;set;}
internal virtual VoidCallback _OnScrollLeft{get;set;}
internal virtual VoidCallback _OnScrollRight{get;set;}
internal virtual VoidCallback _OnScrollUp{get;set;}
internal virtual VoidCallback _OnScrollDown{get;set;}
internal virtual VoidCallback _OnIncrease{get;set;}
internal virtual VoidCallback _OnDecrease{get;set;}
internal virtual VoidCallback _OnCopy{get;set;}
internal virtual VoidCallback _OnCut{get;set;}
internal virtual VoidCallback _OnPaste{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorForwardByCharacter{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorBackwardByCharacter{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorForwardByWord{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorBackwardByWord{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.SetSelectionHandler _OnSetSelection{get;set;}
internal virtual VoidCallback _OnDidGainAccessibilityFocus{get;set;}
internal virtual VoidCallback _OnDidLoseAccessibilityFocus{get;set;}
internal virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object> _CustomSemanticsActions{get;set;}
public virtual bool Container{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool ExplicitChildNodes{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool ExcludeSemantics{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool @checked{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Enabled{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Selected{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Button{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Link{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Header{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool TextField{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool ReadOnly{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Focusable{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Focused{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool InMutuallyExclusiveGroup{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Obscured{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Multiline{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool ScopesRoute{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool NamesRoute{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Hidden{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Image{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool LiveRegion{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual int MaxValueLength{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual int CurrentValueLength{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Toggled{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual string Label{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual string Value{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual string IncreasedValue{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual string DecreasedValue{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual string Hint{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides HintOverrides{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual TextDirection TextDirection{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKey{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnTap{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnDismiss{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnLongPress{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnScrollLeft{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnScrollRight{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnScrollUp{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnScrollDown{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnIncrease{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnDecrease{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnCopy{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnCut{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnPaste{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByCharacter{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByCharacter{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByWord{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByWord{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.SetSelectionHandler OnSetSelection{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnDidGainAccessibilityFocus{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnDidLoseAccessibilityFocus{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object> CustomSemanticsActions{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor){ throw new NotImplementedException(); }


public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config){ throw new NotImplementedException(); }


private void _PerformTap(){ throw new NotImplementedException(); }


private void _PerformLongPress(){ throw new NotImplementedException(); }


private void _PerformDismiss(){ throw new NotImplementedException(); }


private void _PerformScrollLeft(){ throw new NotImplementedException(); }


private void _PerformScrollRight(){ throw new NotImplementedException(); }


private void _PerformScrollUp(){ throw new NotImplementedException(); }


private void _PerformScrollDown(){ throw new NotImplementedException(); }


private void _PerformIncrease(){ throw new NotImplementedException(); }


private void _PerformDecrease(){ throw new NotImplementedException(); }


private void _PerformCopy(){ throw new NotImplementedException(); }


private void _PerformCut(){ throw new NotImplementedException(); }


private void _PerformPaste(){ throw new NotImplementedException(); }


private void _PerformMoveCursorForwardByCharacter(bool extendSelection){ throw new NotImplementedException(); }


private void _PerformMoveCursorBackwardByCharacter(bool extendSelection){ throw new NotImplementedException(); }


private void _PerformMoveCursorForwardByWord(bool extendSelection){ throw new NotImplementedException(); }


private void _PerformMoveCursorBackwardByWord(bool extendSelection){ throw new NotImplementedException(); }


private void _PerformSetSelection(FlutterSDK.Services.Textediting.TextSelection selection){ throw new NotImplementedException(); }


private void _PerformDidGainAccessibilityFocus(){ throw new NotImplementedException(); }


private void _PerformDidLoseAccessibilityFocus(){ throw new NotImplementedException(); }

#endregion
}


public class RenderBlockSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderBlockSemantics(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),bool blocking = true)
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual bool _Blocking{get;set;}
public virtual bool Blocking{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderMergeSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderMergeSemantics(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config){ throw new NotImplementedException(); }

#endregion
}


public class RenderExcludeSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderExcludeSemantics(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),bool excluding = true)
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual bool _Excluding{get;set;}
public virtual bool Excluding{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderIndexedSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderIndexedSemantics(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),int index = default(int))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual int _Index{get;set;}
public virtual int Index{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderLeaderLayer : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderLeaderLayer(FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink),FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Layer.LayerLink _Link{get;set;}
public virtual FlutterSDK.Rendering.Layer.LayerLink Link{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool AlwaysNeedsCompositing{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderFollowerLayer : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderFollowerLayer(FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink),bool showWhenUnlinked = true,FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset),FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Layer.LayerLink _Link{get;set;}
internal virtual bool _ShowWhenUnlinked{get;set;}
internal virtual FlutterBinding.UI.Offset _Offset{get;set;}
public virtual FlutterSDK.Rendering.Layer.LayerLink Link{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool ShowWhenUnlinked{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Offset Offset{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool AlwaysNeedsCompositing{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Rendering.Layer.FollowerLayer Layer{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void Detach(){ throw new NotImplementedException(); }


public virtual Matrix4 GetCurrentTransform(){ throw new NotImplementedException(); }


public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child,Matrix4 transform){ throw new NotImplementedException(); }
public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderAnnotatedRegion<T> : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public RenderAnnotatedRegion(T value = default(T),bool sized = default(bool),FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual T _Value{get;set;}
internal virtual bool _Sized{get;set;}
public new bool AlwaysNeedsCompositing{get;set;}
public virtual T Value{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool Sized{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

#endregion
}


public enum HitTestBehavior{

DeferToChild,
Opaque,
Translucent,
}


public enum DecorationPosition{

Background,
Foreground,
}

}
