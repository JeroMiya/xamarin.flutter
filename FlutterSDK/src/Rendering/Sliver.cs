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
namespace FlutterSDK.Rendering.Sliver{
public delegate bool SliverHitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result,double mainAxisPosition = default(double),double crossAxisPosition = default(double));
internal static class SliverDefaultClass{
internal static FlutterSDK.Painting.Basictypes.AxisDirection ApplyGrowthDirectionToAxisDirection(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection,FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection){
throw new NotImplementedException();
}

internal static FlutterSDK.Rendering.Viewportoffset.ScrollDirection ApplyGrowthDirectionToScrollDirection(FlutterSDK.Rendering.Viewportoffset.ScrollDirection scrollDirection,FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection){
throw new NotImplementedException();
}

internal static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _DebugCompareFloats(string labelA,double valueA,string labelB,double valueB){
throw new NotImplementedException();
}

}

public interface IRenderSliver{
void DebugResetSize();
void DebugAssertDoesMeetConstraints();
void PerformResize();
bool HitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result,double mainAxisPosition = default(double),double crossAxisPosition = default(double));
bool HitTestSelf(double mainAxisPosition = default(double),double crossAxisPosition = default(double));
bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result,double mainAxisPosition = default(double),double crossAxisPosition = default(double));
double CalculatePaintOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints,double from = default(double),double to = default(double));
double CalculateCacheOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints,double from = default(double),double to = default(double));
double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child);
double ChildCrossAxisPosition(FlutterSDK.Rendering.@object.RenderObject child);
double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child);
void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform);
Size GetAbsoluteSizeRelativeToOrigin();
Size GetAbsoluteSize();
void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset);
void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event,FlutterSDK.Rendering.Sliver.SliverHitTestEntry entry);
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
FlutterSDK.Rendering.Sliver.SliverConstraints Constraints{get;}
FlutterSDK.Rendering.Sliver.SliverGeometry Geometry{get;set;}
FlutterBinding.UI.Rect SemanticBounds{get;}
FlutterBinding.UI.Rect PaintBounds{get;}
double CenterOffsetAdjustment{get;}
}


public interface IRenderSliverSingleBoxAdapter{
void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child);
void SetChildParentData(FlutterSDK.Rendering.@object.RenderObject child,FlutterSDK.Rendering.Sliver.SliverConstraints constraints,FlutterSDK.Rendering.Sliver.SliverGeometry geometry);
bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result,double mainAxisPosition = default(double),double crossAxisPosition = default(double));
double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child);
void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform);
void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset);
}


public interface IRenderSliverHelpers{}

public class RenderSliverHelpers:IRenderSliver{

private bool _GetRightWayUp(FlutterSDK.Rendering.Sliver.SliverConstraints constraints){ throw new NotImplementedException(); }


public virtual bool HitTestBoxChild(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterSDK.Rendering.Box.RenderBox child,double mainAxisPosition = default(double),double crossAxisPosition = default(double)){ throw new NotImplementedException(); }


public virtual void ApplyPaintTransformForBoxChild(FlutterSDK.Rendering.Box.RenderBox child,Matrix4 transform){ throw new NotImplementedException(); }

internal virtual FlutterSDK.Rendering.Sliver.SliverGeometry _Geometry{get;set;}
public virtual FlutterSDK.Rendering.Sliver.SliverConstraints Constraints{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Rendering.Sliver.SliverGeometry Geometry{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Rect SemanticBounds{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterBinding.UI.Rect PaintBounds{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double CenterOffsetAdjustment{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}

public new void DebugResetSize(){ throw new NotImplementedException(); }


public new void DebugAssertDoesMeetConstraints(){ throw new NotImplementedException(); }


public new void PerformResize(){ throw new NotImplementedException(); }


public virtual bool HitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result,double mainAxisPosition = default(double),double crossAxisPosition = default(double)){ throw new NotImplementedException(); }


public virtual bool HitTestSelf(double mainAxisPosition = default(double),double crossAxisPosition = default(double)){ throw new NotImplementedException(); }


public virtual bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result,double mainAxisPosition = default(double),double crossAxisPosition = default(double)){ throw new NotImplementedException(); }


public virtual double CalculatePaintOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints,double from = default(double),double to = default(double)){ throw new NotImplementedException(); }


public virtual double CalculateCacheOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints,double from = default(double),double to = default(double)){ throw new NotImplementedException(); }


public virtual double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public virtual double ChildCrossAxisPosition(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public virtual double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform){ throw new NotImplementedException(); }


public virtual Size GetAbsoluteSizeRelativeToOrigin(){ throw new NotImplementedException(); }


public virtual Size GetAbsoluteSize(){ throw new NotImplementedException(); }


private void _DebugDrawArrow(Canvas canvas,SKPaint paint,FlutterBinding.UI.Offset p0,FlutterBinding.UI.Offset p1,FlutterSDK.Rendering.Sliver.GrowthDirection direction){ throw new NotImplementedException(); }


public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event,FlutterSDK.Rendering.Sliver.SliverHitTestEntry entry){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

}
public static class RenderSliverHelpersMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<IRenderSliverHelpers, RenderSliverHelpers> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IRenderSliverHelpers, RenderSliverHelpers>();
static RenderSliverHelpers GetOrCreate(IRenderSliverHelpers instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new RenderSliverHelpers();
_table.Add(instance, value);
}
return (RenderSliverHelpers)value;
}
public static bool HitTestBoxChild(this IRenderSliverHelpers instance,FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterSDK.Rendering.Box.RenderBox child,double mainAxisPosition = default(double),double crossAxisPosition = default(double)) => GetOrCreate(instance).HitTestBoxChild(result, child, mainAxisPosition, crossAxisPosition);
public static void ApplyPaintTransformForBoxChild(this IRenderSliverHelpers instance,FlutterSDK.Rendering.Box.RenderBox child,Matrix4 transform) => GetOrCreate(instance).ApplyPaintTransformForBoxChild(child, transform);
}


public class SliverConstraints : FlutterSDK.Rendering.@object.Constraints
{
#region constructors
public SliverConstraints(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection),FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection = default(FlutterSDK.Rendering.Sliver.GrowthDirection),FlutterSDK.Rendering.Viewportoffset.ScrollDirection userScrollDirection = default(FlutterSDK.Rendering.Viewportoffset.ScrollDirection),double scrollOffset = default(double),double precedingScrollExtent = default(double),double overlap = default(double),double remainingPaintExtent = default(double),double crossAxisExtent = default(double),FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection),double viewportMainAxisExtent = default(double),double remainingCacheExtent = default(double),double cacheOrigin = default(double))
: base()
{
this.AxisDirection = axisDirection;
this.GrowthDirection = growthDirection;
this.UserScrollDirection = userScrollDirection;
this.ScrollOffset = scrollOffset;
this.PrecedingScrollExtent = precedingScrollExtent;
this.Overlap = overlap;
this.RemainingPaintExtent = remainingPaintExtent;
this.CrossAxisExtent = crossAxisExtent;
this.CrossAxisDirection = crossAxisDirection;
this.ViewportMainAxisExtent = viewportMainAxisExtent;
this.RemainingCacheExtent = remainingCacheExtent;
this.CacheOrigin = cacheOrigin;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection{get;set;}
public virtual FlutterSDK.Rendering.Sliver.GrowthDirection GrowthDirection{get;set;}
public virtual FlutterSDK.Rendering.Viewportoffset.ScrollDirection UserScrollDirection{get;set;}
public virtual double ScrollOffset{get;set;}
public virtual double PrecedingScrollExtent{get;set;}
public virtual double Overlap{get;set;}
public virtual double RemainingPaintExtent{get;set;}
public virtual double CrossAxisExtent{get;set;}
public virtual FlutterSDK.Painting.Basictypes.AxisDirection CrossAxisDirection{get;set;}
public virtual double ViewportMainAxisExtent{get;set;}
public virtual double CacheOrigin{get;set;}
public virtual double RemainingCacheExtent{get;set;}
public virtual FlutterSDK.Painting.Basictypes.Axis Axis{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Rendering.Sliver.GrowthDirection NormalizedGrowthDirection{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsTight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsNormalized{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual FlutterSDK.Rendering.Sliver.SliverConstraints CopyWith(FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection),FlutterSDK.Rendering.Sliver.GrowthDirection growthDirection = default(FlutterSDK.Rendering.Sliver.GrowthDirection),FlutterSDK.Rendering.Viewportoffset.ScrollDirection userScrollDirection = default(FlutterSDK.Rendering.Viewportoffset.ScrollDirection),double scrollOffset = default(double),double precedingScrollExtent = default(double),double overlap = default(double),double remainingPaintExtent = default(double),double crossAxisExtent = default(double),FlutterSDK.Painting.Basictypes.AxisDirection crossAxisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection),double viewportMainAxisExtent = default(double),double remainingCacheExtent = default(double),double cacheOrigin = default(double)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints AsBoxConstraints(double minExtent = 0.0,double maxExtent = default(double),double crossAxisExtent = default(double)){ throw new NotImplementedException(); }


public new bool DebugAssertIsValid(bool isAppliedConstraint = false,FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector)){ throw new NotImplementedException(); }


public new bool Equals(@Object other){ throw new NotImplementedException(); }


#endregion
}


public class SliverGeometry : IDiagnosticable
{
#region constructors
public SliverGeometry(double scrollExtent = 0.0,double paintExtent = 0.0,double paintOrigin = 0.0,double layoutExtent = default(double),double maxPaintExtent = 0.0,double maxScrollObstructionExtent = 0.0,double hitTestExtent = default(double),bool visible = default(bool),bool hasVisualOverflow = false,double scrollOffsetCorrection = default(double),double cacheExtent = default(double))
: base()
{
this.ScrollExtent = scrollExtent;
this.PaintExtent = paintExtent;
this.PaintOrigin = paintOrigin;
this.MaxPaintExtent = maxPaintExtent;
this.MaxScrollObstructionExtent = maxScrollObstructionExtent;
this.HasVisualOverflow = hasVisualOverflow;
this.ScrollOffsetCorrection = scrollOffsetCorrection;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Rendering.Sliver.SliverGeometry Zero{get;set;}
public virtual double ScrollExtent{get;set;}
public virtual double PaintOrigin{get;set;}
public virtual double PaintExtent{get;set;}
public virtual double LayoutExtent{get;set;}
public virtual double MaxPaintExtent{get;set;}
public virtual double MaxScrollObstructionExtent{get;set;}
public virtual double HitTestExtent{get;set;}
public virtual bool Visible{get;set;}
public virtual bool HasVisualOverflow{get;set;}
public virtual double ScrollOffsetCorrection{get;set;}
public virtual double CacheExtent{get;set;}
#endregion

#region methods

public virtual bool DebugAssertIsValid(FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector)){ throw new NotImplementedException(); }


public new string ToStringShort(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class SliverHitTestResult : FlutterSDK.Gestures.Hittest.HitTestResult
{
#region constructors
public SliverHitTestResult()
: base()
{
throw new NotImplementedException(); }
public static SliverHitTestResult Wrap(FlutterSDK.Gestures.Hittest.HitTestResult result)
{
var instance =new SliverHitTestResult(result);throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public virtual bool AddWithAxisOffset(FlutterBinding.UI.Offset paintOffset = default(FlutterBinding.UI.Offset),double mainAxisOffset = default(double),double crossAxisOffset = default(double),double mainAxisPosition = default(double),double crossAxisPosition = default(double),FlutterSDK.Rendering.Sliver.SliverHitTest hitTest = default(FlutterSDK.Rendering.Sliver.SliverHitTest)){ throw new NotImplementedException(); }

#endregion
}


public class SliverHitTestEntry : FlutterSDK.Gestures.Hittest.HitTestEntry
{
#region constructors
public SliverHitTestEntry(FlutterSDK.Rendering.Sliver.RenderSliver target,double mainAxisPosition = default(double),double crossAxisPosition = default(double))
: base(target)
{
this.MainAxisPosition = mainAxisPosition;
this.CrossAxisPosition = crossAxisPosition;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double MainAxisPosition{get;set;}
public virtual double CrossAxisPosition{get;set;}
public virtual FlutterSDK.Rendering.Sliver.RenderSliver Target{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

#endregion
}


public class SliverLogicalParentData : FlutterSDK.Rendering.@object.ParentData
{
#region constructors
public SliverLogicalParentData()
{ }
#endregion

#region fields
public virtual double LayoutOffset{get;set;}
#endregion

#region methods

#endregion
}


public class SliverLogicalContainerParentData : FlutterSDK.Rendering.Sliver.SliverLogicalParentData,IContainerParentDataMixin<FlutterSDK.Rendering.Sliver.RenderSliver>
{
#region constructors
public SliverLogicalContainerParentData()
{ }
#endregion

#region fields
#endregion

#region methods
#endregion
}


public class SliverPhysicalParentData : FlutterSDK.Rendering.@object.ParentData
{
#region constructors
public SliverPhysicalParentData()
{ }
#endregion

#region fields
public virtual FlutterBinding.UI.Offset PaintOffset{get;set;}
#endregion

#region methods

public virtual void ApplyPaintTransform(Matrix4 transform){ throw new NotImplementedException(); }


#endregion
}


public class SliverPhysicalContainerParentData : FlutterSDK.Rendering.Sliver.SliverPhysicalParentData,IContainerParentDataMixin<FlutterSDK.Rendering.Sliver.RenderSliver>
{
#region constructors
public SliverPhysicalContainerParentData()
{ }
#endregion

#region fields
#endregion

#region methods
#endregion
}


public class RenderSliver : FlutterSDK.Rendering.@object.RenderObject
{
#region constructors
public RenderSliver()
{ }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Sliver.SliverGeometry _Geometry{get;set;}
public virtual FlutterSDK.Rendering.Sliver.SliverConstraints Constraints{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Rendering.Sliver.SliverGeometry Geometry{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Rect SemanticBounds{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterBinding.UI.Rect PaintBounds{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double CenterOffsetAdjustment{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void DebugResetSize(){ throw new NotImplementedException(); }


public new void DebugAssertDoesMeetConstraints(){ throw new NotImplementedException(); }


public new void PerformResize(){ throw new NotImplementedException(); }


public virtual bool HitTest(FlutterSDK.Rendering.Sliver.SliverHitTestResult result,double mainAxisPosition = default(double),double crossAxisPosition = default(double)){ throw new NotImplementedException(); }


public virtual bool HitTestSelf(double mainAxisPosition = default(double),double crossAxisPosition = default(double)){ throw new NotImplementedException(); }


public virtual bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result,double mainAxisPosition = default(double),double crossAxisPosition = default(double)){ throw new NotImplementedException(); }


public virtual double CalculatePaintOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints,double from = default(double),double to = default(double)){ throw new NotImplementedException(); }


public virtual double CalculateCacheOffset(FlutterSDK.Rendering.Sliver.SliverConstraints constraints,double from = default(double),double to = default(double)){ throw new NotImplementedException(); }


public virtual double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public virtual double ChildCrossAxisPosition(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public virtual double ChildScrollOffset(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform){ throw new NotImplementedException(); }


public virtual Size GetAbsoluteSizeRelativeToOrigin(){ throw new NotImplementedException(); }


public virtual Size GetAbsoluteSize(){ throw new NotImplementedException(); }


private void _DebugDrawArrow(Canvas canvas,SKPaint paint,FlutterBinding.UI.Offset p0,FlutterBinding.UI.Offset p1,FlutterSDK.Rendering.Sliver.GrowthDirection direction){ throw new NotImplementedException(); }


public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event,FlutterSDK.Rendering.Sliver.SliverHitTestEntry entry){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RenderSliverSingleBoxAdapter : FlutterSDK.Rendering.Sliver.RenderSliver,IRenderObjectWithChildMixin<FlutterSDK.Rendering.Box.RenderBox>,IRenderSliverHelpers
{
#region constructors
public RenderSliverSingleBoxAdapter(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public virtual void SetChildParentData(FlutterSDK.Rendering.@object.RenderObject child,FlutterSDK.Rendering.Sliver.SliverConstraints constraints,FlutterSDK.Rendering.Sliver.SliverGeometry geometry){ throw new NotImplementedException(); }


public new bool HitTestChildren(FlutterSDK.Rendering.Sliver.SliverHitTestResult result,double mainAxisPosition = default(double),double crossAxisPosition = default(double)){ throw new NotImplementedException(); }


public new double ChildMainAxisPosition(FlutterSDK.Rendering.Box.RenderBox child){ throw new NotImplementedException(); }
public new double ChildMainAxisPosition(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

#endregion
}


public class RenderSliverToBoxAdapter : FlutterSDK.Rendering.Sliver.RenderSliverSingleBoxAdapter
{
#region constructors
public RenderSliverToBoxAdapter(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child:child)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new void PerformLayout(){ throw new NotImplementedException(); }

#endregion
}


public enum GrowthDirection{

Forward,
Reverse,
}

}
