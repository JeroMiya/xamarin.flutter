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
namespace FlutterSDK.Cupertino.Actionsheet{
internal static class ActionsheetDefaultClass{
public static FlutterSDK.Painting.Textstyle.TextStyle _KActionSheetActionStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
public static FlutterSDK.Painting.Textstyle.TextStyle _KActionSheetContentStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
public static Color _KBackgroundColor = default(Color);
public static Color _KPressedColor = default(Color);
public static Color _KCancelPressedColor = default(Color);
public static Color _KContentTextColor = default(Color);
public static Color _KButtonDividerColor = default(Color);
public static double _KBlurAmount = default(double);
public static double _KEdgeHorizontalPadding = default(double);
public static double _KCancelButtonPadding = default(double);
public static double _KEdgeVerticalPadding = default(double);
public static double _KContentHorizontalPadding = default(double);
public static double _KContentVerticalPadding = default(double);
public static double _KButtonHeight = default(double);
public static double _KCornerRadius = default(double);
public static double _KDividerThickness = default(double);
}

public class CupertinoActionSheet : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public CupertinoActionSheet(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Framework.Widget message = default(FlutterSDK.Widgets.Framework.Widget),List<FlutterSDK.Widgets.Framework.Widget> actions = default(List<FlutterSDK.Widgets.Framework.Widget>),FlutterSDK.Widgets.Scrollcontroller.ScrollController messageScrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),FlutterSDK.Widgets.Scrollcontroller.ScrollController actionScrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),FlutterSDK.Widgets.Framework.Widget cancelButton = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key)
{
this.Title = title;
this.Message = message;
this.Actions = actions;
this.MessageScrollController = messageScrollController;
this.ActionScrollController = actionScrollController;
this.CancelButton = cancelButton;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Title{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Message{get;set;}
public virtual List<FlutterSDK.Widgets.Framework.Widget> Actions{get;set;}
public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController MessageScrollController{get;set;}
public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ActionScrollController{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget CancelButton{get;set;}
#endregion

#region methods

private FlutterSDK.Widgets.Framework.Widget _BuildContent(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


private FlutterSDK.Widgets.Framework.Widget _BuildActions(){ throw new NotImplementedException(); }


private FlutterSDK.Widgets.Framework.Widget _BuildCancelButton(){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class CupertinoActionSheetAction : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public CupertinoActionSheetAction(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),VoidCallback onPressed = default(VoidCallback),bool isDefaultAction = false,bool isDestructiveAction = false,FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key)
{
this.OnPressed = onPressed;
this.IsDefaultAction = isDefaultAction;
this.IsDestructiveAction = isDestructiveAction;
this.Child = child;throw new NotImplementedException(); }
#endregion

#region fields
public virtual VoidCallback OnPressed{get;set;}
public virtual bool IsDefaultAction{get;set;}
public virtual bool IsDestructiveAction{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Child{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoActionSheetCancelButton : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public _CupertinoActionSheetCancelButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key)
{
this.Child = child;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child{get;set;}
#endregion

#region methods

public new FlutterSDK.Cupertino.Actionsheet._CupertinoActionSheetCancelButtonState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoActionSheetCancelButtonState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Actionsheet._CupertinoActionSheetCancelButton>
{
#region constructors
public _CupertinoActionSheetCancelButtonState()
{ }
#endregion

#region fields
public virtual bool IsBeingPressed{get;set;}
#endregion

#region methods

private void _OnTapDown(FlutterSDK.Gestures.Tap.TapDownDetails @event){ throw new NotImplementedException(); }


private void _OnTapUp(FlutterSDK.Gestures.Tap.TapUpDetails @event){ throw new NotImplementedException(); }


private void _OnTapCancel(){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoAlertRenderWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
{
#region constructors
public _CupertinoAlertRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Framework.Widget contentSection = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Framework.Widget actionsSection = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key)
{
this.ContentSection = contentSection;
this.ActionsSection = actionsSection;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget ContentSection{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget ActionsSection{get;set;}
#endregion

#region methods

public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Cupertino.Actionsheet._RenderCupertinoAlert renderObject){ throw new NotImplementedException(); }
public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Rendering.@object.RenderObject renderObject){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.RenderObjectElement CreateElement(){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoAlertRenderElement : FlutterSDK.Widgets.Framework.RenderObjectElement
{
#region constructors
public _CupertinoAlertRenderElement(FlutterSDK.Cupertino.Actionsheet._CupertinoAlertRenderWidget widget)
: base(widget)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Widgets.Framework.Element _ContentElement{get;set;}
internal virtual FlutterSDK.Widgets.Framework.Element _ActionsElement{get;set;}
public virtual FlutterSDK.Cupertino.Actionsheet._CupertinoAlertRenderWidget Widget{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Cupertino.Actionsheet._RenderCupertinoAlert RenderObject{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor){ throw new NotImplementedException(); }


public new void Mount(FlutterSDK.Widgets.Framework.Element parent,object newSlot){ throw new NotImplementedException(); }


public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child,FlutterSDK.Cupertino.Actionsheet._AlertSections slot){ throw new NotImplementedException(); }
public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child,object slot){ throw new NotImplementedException(); }


public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child,FlutterSDK.Cupertino.Actionsheet._AlertSections slot){ throw new NotImplementedException(); }
public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child,object slot){ throw new NotImplementedException(); }


public new void Update(FlutterSDK.Widgets.Framework.RenderObjectWidget newWidget){ throw new NotImplementedException(); }
public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget){ throw new NotImplementedException(); }


public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child){ throw new NotImplementedException(); }


public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


private void _PlaceChildInSlot(FlutterSDK.Rendering.@object.RenderObject child,FlutterSDK.Cupertino.Actionsheet._AlertSections slot){ throw new NotImplementedException(); }

#endregion
}


public class _RenderCupertinoAlert : FlutterSDK.Rendering.Box.RenderBox
{
#region constructors
public _RenderCupertinoAlert(FlutterSDK.Rendering.Box.RenderBox contentSection = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Rendering.Box.RenderBox actionsSection = default(FlutterSDK.Rendering.Box.RenderBox),double dividerThickness = 0.0,FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Box.RenderBox _ContentSection{get;set;}
internal virtual FlutterSDK.Rendering.Box.RenderBox _ActionsSection{get;set;}
internal virtual double _DividerThickness{get;set;}
internal virtual SKPaint _DividerPaint{get;set;}
public virtual FlutterSDK.Rendering.Box.RenderBox ContentSection{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Rendering.Box.RenderBox ActionsSection{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Color DividerColor{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner){ throw new NotImplementedException(); }
public new void Attach(@Object owner){ throw new NotImplementedException(); }


public new void Detach(){ throw new NotImplementedException(); }


public new void RedepthChildren(){ throw new NotImplementedException(); }


public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child){ throw new NotImplementedException(); }
public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor){ throw new NotImplementedException(); }


public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren(){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


private void _PaintDividerBetweenContentAndActions(Canvas canvas,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoAlertContentSection : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _CupertinoAlertContentSection(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Framework.Widget message = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController))
: base(key:key)
{
this.Title = title;
this.Message = message;
this.ScrollController = scrollController;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Title{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Message{get;set;}
public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoAlertActionSection : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public _CupertinoAlertActionSection(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>),FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool hasCancelButton = default(bool))
: base(key:key)
{
this.Children = children;
this.ScrollController = scrollController;
this.HasCancelButton = hasCancelButton;throw new NotImplementedException(); }
#endregion

#region fields
public virtual List<FlutterSDK.Widgets.Framework.Widget> Children{get;set;}
public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController{get;set;}
public virtual bool HasCancelButton{get;set;}
#endregion

#region methods

public new FlutterSDK.Cupertino.Actionsheet._CupertinoAlertActionSectionState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoAlertActionSectionState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Actionsheet._CupertinoAlertActionSection>
{
#region constructors
public _CupertinoAlertActionSectionState()
{ }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _PressableActionButton : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public _PressableActionButton(FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
{
this.Child = child;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child{get;set;}
#endregion

#region methods

public new FlutterSDK.Cupertino.Actionsheet._PressableActionButtonState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _PressableActionButtonState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Actionsheet._PressableActionButton>
{
#region constructors
public _PressableActionButtonState()
{ }
#endregion

#region fields
internal virtual bool _IsPressed{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _ActionButtonParentDataWidget : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Cupertino.Actionsheet._ActionButtonParentData>
{
#region constructors
public _ActionButtonParentDataWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),bool isPressed = default(bool),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key,child:child)
{
this.IsPressed = isPressed;throw new NotImplementedException(); }
#endregion

#region fields
public virtual bool IsPressed{get;set;}
public virtual Type DebugTypicalAncestorWidgetClass{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject){ throw new NotImplementedException(); }

#endregion
}


public class _ActionButtonParentData : FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData
{
#region constructors
public _ActionButtonParentData(bool isPressed = false)
{
this.IsPressed = isPressed;throw new NotImplementedException(); }
#endregion

#region fields
public virtual bool IsPressed{get;set;}
#endregion

#region methods
#endregion
}


public class _CupertinoAlertActionsRenderWidget : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
{
#region constructors
public _CupertinoAlertActionsRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),List<FlutterSDK.Widgets.Framework.Widget> actionButtons = default(List<FlutterSDK.Widgets.Framework.Widget>),double dividerThickness = 0.0,bool hasCancelButton = false)
: base(key:key,children:actionButtons)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual double _DividerThickness{get;set;}
internal virtual bool _HasCancelButton{get;set;}
#endregion

#region methods

public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Cupertino.Actionsheet._RenderCupertinoAlertActions renderObject){ throw new NotImplementedException(); }
public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Rendering.@object.RenderObject renderObject){ throw new NotImplementedException(); }

#endregion
}


public class _RenderCupertinoAlertActions : FlutterSDK.Rendering.Box.RenderBox,IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox,FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData>,IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox,FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData>
{
#region constructors
public _RenderCupertinoAlertActions(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>),double dividerThickness = 0.0,FlutterBinding.UI.Color dividerColor = default(FlutterBinding.UI.Color),bool hasCancelButton = false,FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color pressedColor = default(FlutterBinding.UI.Color))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual double _DividerThickness{get;set;}
internal virtual bool _HasCancelButton{get;set;}
internal virtual SKPaint _ButtonBackgroundPaint{get;set;}
internal virtual SKPaint _PressedButtonBackgroundPaint{get;set;}
internal virtual SKPaint _DividerPaint{get;set;}
public virtual double DividerThickness{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Color BackgroundColor{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Color PressedColor{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Color DividerColor{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool HasCancelButton{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child){ throw new NotImplementedException(); }
public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


private double _ComputeMinIntrinsicHeightWithCancel(double width){ throw new NotImplementedException(); }


private double _ComputeMinIntrinsicHeightWithoutCancel(double width){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicHeight(double width){ throw new NotImplementedException(); }


private double _ComputeMaxIntrinsicHeightStacked(double width){ throw new NotImplementedException(); }


public new void PerformLayout(){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


private void _DrawButtonBackgroundsAndDividersStacked(Canvas canvas,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


private void _DrawButtons(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result,FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }

#endregion
}


public enum _AlertSections{

ContentSection,
ActionsSection,
}

}
