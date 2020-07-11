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
namespace FlutterSDK.Rendering.Box{
public delegate bool BoxHitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position);
internal static class BoxDefaultClass{
}

public interface IContainerBoxParentData<ChildType>{
}


public interface IRenderBox{
void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child);
double GetMinIntrinsicWidth(double height);
double ComputeMinIntrinsicWidth(double height);
double GetMaxIntrinsicWidth(double height);
double ComputeMaxIntrinsicWidth(double height);
double GetMinIntrinsicHeight(double width);
double ComputeMinIntrinsicHeight(double width);
double GetMaxIntrinsicHeight(double width);
double ComputeMaxIntrinsicHeight(double width);
Size DebugAdoptSize(Size value);
void DebugResetSize();
double GetDistanceToBaseline(TextBaseline baseline,bool onlyReal = false);
double GetDistanceToActualBaseline(TextBaseline baseline);
double ComputeDistanceToActualBaseline(TextBaseline baseline);
void DebugAssertDoesMeetConstraints();
void MarkNeedsLayout();
void PerformResize();
void PerformLayout();
bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset));
bool HitTestSelf(FlutterBinding.UI.Offset position);
bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset));
void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform);
Offset GlobalToLocal(FlutterBinding.UI.Offset point,FlutterSDK.Rendering.@object.RenderObject ancestor = default(FlutterSDK.Rendering.@object.RenderObject));
Offset LocalToGlobal(FlutterBinding.UI.Offset point,FlutterSDK.Rendering.@object.RenderObject ancestor = default(FlutterSDK.Rendering.@object.RenderObject));
void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event,FlutterSDK.Rendering.Box.BoxHitTestEntry entry);
bool DebugHandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event,FlutterSDK.Gestures.Hittest.HitTestEntry entry);
void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset);
void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset);
void DebugPaintBaselines(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset);
void DebugPaintPointers(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset);
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
bool HasSize{get;}
Size Size{get;set;}
FlutterBinding.UI.Rect SemanticBounds{get;}
FlutterSDK.Rendering.Box.BoxConstraints Constraints{get;}
FlutterBinding.UI.Rect PaintBounds{get;}
}


public interface IRenderBoxContainerDefaultsMixin<ChildType,ParentDataType>{}

public class RenderBoxContainerDefaultsMixin<ChildType,ParentDataType>:IContainerRenderObjectMixin<ChildType,ParentDataType>{

public virtual double DefaultComputeDistanceToFirstActualBaseline(TextBaseline baseline){ throw new NotImplementedException(); }


public virtual double DefaultComputeDistanceToHighestActualBaseline(TextBaseline baseline){ throw new NotImplementedException(); }


public virtual bool DefaultHitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public virtual void DefaultPaint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public virtual List<ChildType> GetChildrenAsList(){ throw new NotImplementedException(); }

internal virtual int _ChildCount{get;set;}
internal virtual ChildType _FirstChild{get;set;}
internal virtual ChildType _LastChild{get;set;}
public virtual int ChildCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual ChildType FirstChild{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual ChildType LastChild{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}

private bool _DebugUltimatePreviousSiblingOf(ChildType child,ChildType equals = default(ChildType)){ throw new NotImplementedException(); }


private bool _DebugUltimateNextSiblingOf(ChildType child,ChildType equals = default(ChildType)){ throw new NotImplementedException(); }


public virtual bool DebugValidateChild(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


private void _InsertIntoChildList(ChildType child,ChildType after = default(ChildType)){ throw new NotImplementedException(); }


public virtual void Insert(ChildType child,ChildType after = default(ChildType)){ throw new NotImplementedException(); }


public virtual void Add(ChildType child){ throw new NotImplementedException(); }


public virtual void AddAll(List<ChildType> children){ throw new NotImplementedException(); }


private void _RemoveFromChildList(ChildType child){ throw new NotImplementedException(); }


public virtual void Remove(ChildType child){ throw new NotImplementedException(); }


public virtual void RemoveAll(){ throw new NotImplementedException(); }


public virtual void Move(ChildType child,ChildType after = default(ChildType)){ throw new NotImplementedException(); }


public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner){ throw new NotImplementedException(); }
public new void Attach(@Object owner){ throw new NotImplementedException(); }


public new void Detach(){ throw new NotImplementedException(); }


public new void RedepthChildren(){ throw new NotImplementedException(); }


public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor){ throw new NotImplementedException(); }


public virtual ChildType ChildBefore(ChildType child){ throw new NotImplementedException(); }


public virtual ChildType ChildAfter(ChildType child){ throw new NotImplementedException(); }


public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren(){ throw new NotImplementedException(); }

}
public static class RenderBoxContainerDefaultsMixinMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
static RenderBoxContainerDefaultsMixin<ChildType,ParentDataType> GetOrCreate<ChildType,ParentDataType>(IRenderBoxContainerDefaultsMixin<ChildType,ParentDataType> instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new RenderBoxContainerDefaultsMixin<ChildType,ParentDataType>();
_table.Add(instance, value);
}
return (RenderBoxContainerDefaultsMixin<ChildType,ParentDataType>)value;
}
public static double DefaultComputeDistanceToFirstActualBaseline<ChildType,ParentDataType>(this IRenderBoxContainerDefaultsMixin<ChildType,ParentDataType> instance,TextBaseline baseline) => GetOrCreate(instance).DefaultComputeDistanceToFirstActualBaseline(baseline);
public static double DefaultComputeDistanceToHighestActualBaseline<ChildType,ParentDataType>(this IRenderBoxContainerDefaultsMixin<ChildType,ParentDataType> instance,TextBaseline baseline) => GetOrCreate(instance).DefaultComputeDistanceToHighestActualBaseline(baseline);
public static bool DefaultHitTestChildren<ChildType,ParentDataType>(this IRenderBoxContainerDefaultsMixin<ChildType,ParentDataType> instance,FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) => GetOrCreate(instance).DefaultHitTestChildren(result, position);
public static void DefaultPaint<ChildType,ParentDataType>(this IRenderBoxContainerDefaultsMixin<ChildType,ParentDataType> instance,FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset) => GetOrCreate(instance).DefaultPaint(context, offset);
public static List<ChildType> GetChildrenAsList<ChildType,ParentDataType>(this IRenderBoxContainerDefaultsMixin<ChildType,ParentDataType> instance) => GetOrCreate(instance).GetChildrenAsList();
}


public class _DebugSize : Size
{
#region constructors
public _DebugSize(Size source,FlutterSDK.Rendering.Box.RenderBox _owner,bool _canBeUsedByParent)
: base(source)
{
this._Owner = _owner;
this._CanBeUsedByParent = _canBeUsedByParent;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Box.RenderBox _Owner{get;set;}
internal virtual bool _CanBeUsedByParent{get;set;}
#endregion

#region methods
#endregion
}


public class BoxConstraints : FlutterSDK.Rendering.@object.Constraints
{
#region constructors
public BoxConstraints(double minWidth = 0.0,double maxWidth = default(double),double minHeight = 0.0,double maxHeight = default(double))
: base()
{
this.MinWidth = minWidth;
this.MaxWidth = maxWidth;
this.MinHeight = minHeight;
this.MaxHeight = maxHeight;throw new NotImplementedException(); }
public static BoxConstraints Tight(Size size)
{
var instance =new BoxConstraints();throw new NotImplementedException(); }
public static BoxConstraints TightFor(double width = default(double),double height = default(double))
{
var instance =new BoxConstraints();throw new NotImplementedException(); }
public static BoxConstraints TightForFinite(double width = default(double),double height = default(double))
{
var instance =new BoxConstraints();throw new NotImplementedException(); }
public static BoxConstraints Loose(Size size)
{
var instance =new BoxConstraints();throw new NotImplementedException(); }
public static BoxConstraints Expand(double width = default(double),double height = default(double))
{
var instance =new BoxConstraints();throw new NotImplementedException(); }
#endregion

#region fields
public virtual double MinWidth{get;set;}
public virtual double MaxWidth{get;set;}
public virtual double MinHeight{get;set;}
public virtual double MaxHeight{get;set;}
public virtual FlutterSDK.Rendering.Box.BoxConstraints Flipped{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual Size Biggest{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual Size Smallest{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool HasTightWidth{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool HasTightHeight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsTight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool HasBoundedWidth{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool HasBoundedHeight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool HasInfiniteWidth{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool HasInfiniteHeight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsNormalized{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual FlutterSDK.Rendering.Box.BoxConstraints CopyWith(double minWidth = default(double),double maxWidth = default(double),double minHeight = default(double),double maxHeight = default(double)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints Deflate(FlutterSDK.Painting.Edgeinsets.EdgeInsets edges){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints Loosen(){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints Enforce(FlutterSDK.Rendering.Box.BoxConstraints constraints){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints Tighten(double width = default(double),double height = default(double)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints WidthConstraints(){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints HeightConstraints(){ throw new NotImplementedException(); }


public virtual double ConstrainWidth(double width = default(double)){ throw new NotImplementedException(); }


public virtual double ConstrainHeight(double height = default(double)){ throw new NotImplementedException(); }


private Size _DebugPropagateDebugSize(Size size,Size result){ throw new NotImplementedException(); }


public virtual Size Constrain(Size size){ throw new NotImplementedException(); }


public virtual Size ConstrainDimensions(double width,double height){ throw new NotImplementedException(); }


public virtual Size ConstrainSizeAndAttemptToPreserveAspectRatio(Size size){ throw new NotImplementedException(); }


public virtual bool IsSatisfiedBy(Size size){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints MultiplyOperator(double factor){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints DivideOperator(double factor){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints DivideIntegerResultOperator(double factor){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints ModuloOperator(double value){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints Lerp(FlutterSDK.Rendering.Box.BoxConstraints a,FlutterSDK.Rendering.Box.BoxConstraints b,double t){ throw new NotImplementedException(); }


public new bool DebugAssertIsValid(bool isAppliedConstraint = false,FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Rendering.Box.BoxConstraints Normalize(){ throw new NotImplementedException(); }


public new bool Equals(@Object other){ throw new NotImplementedException(); }


#endregion
}


public class BoxHitTestResult : FlutterSDK.Gestures.Hittest.HitTestResult
{
#region constructors
public BoxHitTestResult()
: base()
{
throw new NotImplementedException(); }
public static BoxHitTestResult Wrap(FlutterSDK.Gestures.Hittest.HitTestResult result)
{
var instance =new BoxHitTestResult(result);throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public virtual bool AddWithPaintTransform(Matrix4 transform = default(Matrix4),FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterSDK.Rendering.Box.BoxHitTest hitTest = default(FlutterSDK.Rendering.Box.BoxHitTest)){ throw new NotImplementedException(); }


public virtual bool AddWithPaintOffset(FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterSDK.Rendering.Box.BoxHitTest hitTest = default(FlutterSDK.Rendering.Box.BoxHitTest)){ throw new NotImplementedException(); }


public virtual bool AddWithRawTransform(Matrix4 transform = default(Matrix4),FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterSDK.Rendering.Box.BoxHitTest hitTest = default(FlutterSDK.Rendering.Box.BoxHitTest)){ throw new NotImplementedException(); }

#endregion
}


public class BoxHitTestEntry : FlutterSDK.Gestures.Hittest.HitTestEntry
{
#region constructors
public BoxHitTestEntry(FlutterSDK.Rendering.Box.RenderBox target,FlutterBinding.UI.Offset localPosition)
: base(target)
{
this.LocalPosition = localPosition;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterBinding.UI.Offset LocalPosition{get;set;}
public virtual FlutterSDK.Rendering.Box.RenderBox Target{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

#endregion
}


public class BoxParentData : FlutterSDK.Rendering.@object.ParentData
{
#region constructors
public BoxParentData()
{ }
#endregion

#region fields
public virtual FlutterBinding.UI.Offset Offset{get;set;}
#endregion

#region methods

#endregion
}


public class ContainerBoxParentData<ChildType> : FlutterSDK.Rendering.Box.BoxParentData,IContainerParentDataMixin<ChildType>
{
#region constructors
public ContainerBoxParentData()
{ }
#endregion

#region fields
#endregion

#region methods
#endregion
}


public class _IntrinsicDimensionsCacheEntry
{
#region constructors
public _IntrinsicDimensionsCacheEntry(FlutterSDK.Rendering.Box._IntrinsicDimension dimension,double argument)
{
this.Dimension = dimension;
this.Argument = argument;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Rendering.Box._IntrinsicDimension Dimension{get;set;}
public virtual double Argument{get;set;}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool Equals(@Object other){ throw new NotImplementedException(); }

#endregion
}


public class RenderBox : FlutterSDK.Rendering.@object.RenderObject
{
#region constructors
public RenderBox()
{ }
#endregion

#region fields
internal virtual Dictionary<FlutterSDK.Rendering.Box._IntrinsicDimensionsCacheEntry,double> _CachedIntrinsicDimensions{get;set;}
internal virtual Size _Size{get;set;}
internal virtual Dictionary<TextBaseline,double> _CachedBaselines{get;set;}
internal virtual bool _DebugDoingBaseline{get;set;}
internal virtual int _DebugActivePointers{get;set;}
public virtual bool HasSize{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual Size Size{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Rect SemanticBounds{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterBinding.UI.Rect PaintBounds{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


private double _ComputeIntrinsicDimension(FlutterSDK.Rendering.Box._IntrinsicDimension dimension,double argument,Func<double,double> computer){ throw new NotImplementedException(); }


public virtual double GetMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public virtual double ComputeMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public virtual double GetMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public virtual double ComputeMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public virtual double GetMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


public virtual double ComputeMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


public virtual double GetMaxIntrinsicHeight(double width){ throw new NotImplementedException(); }


public virtual double ComputeMaxIntrinsicHeight(double width){ throw new NotImplementedException(); }


public virtual Size DebugAdoptSize(Size value){ throw new NotImplementedException(); }


public new void DebugResetSize(){ throw new NotImplementedException(); }


private bool _DebugSetDoingBaseline(bool value){ throw new NotImplementedException(); }


public virtual double GetDistanceToBaseline(TextBaseline baseline,bool onlyReal = false){ throw new NotImplementedException(); }


public virtual double GetDistanceToActualBaseline(TextBaseline baseline){ throw new NotImplementedException(); }


public virtual double ComputeDistanceToActualBaseline(TextBaseline baseline){ throw new NotImplementedException(); }


public new void DebugAssertDoesMeetConstraints(){ throw new NotImplementedException(); }


public new void MarkNeedsLayout(){ throw new NotImplementedException(); }


public new void PerformResize(){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


public virtual bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public virtual bool HitTestSelf(FlutterBinding.UI.Offset position){ throw new NotImplementedException(); }


public virtual bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child,Matrix4 transform){ throw new NotImplementedException(); }


public virtual Offset GlobalToLocal(FlutterBinding.UI.Offset point,FlutterSDK.Rendering.@object.RenderObject ancestor = default(FlutterSDK.Rendering.@object.RenderObject)){ throw new NotImplementedException(); }


public virtual Offset LocalToGlobal(FlutterBinding.UI.Offset point,FlutterSDK.Rendering.@object.RenderObject ancestor = default(FlutterSDK.Rendering.@object.RenderObject)){ throw new NotImplementedException(); }


public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event,FlutterSDK.Rendering.Box.BoxHitTestEntry entry){ throw new NotImplementedException(); }


public virtual bool DebugHandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event,FlutterSDK.Gestures.Hittest.HitTestEntry entry){ throw new NotImplementedException(); }


public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public virtual void DebugPaintSize(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public virtual void DebugPaintBaselines(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public virtual void DebugPaintPointers(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public enum _IntrinsicDimension{

MinWidth,
MaxWidth,
MinHeight,
MaxHeight,
}

}
