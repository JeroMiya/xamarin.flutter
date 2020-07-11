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
namespace FlutterSDK.Gestures.Recognizer{
public delegate T RecognizerCallback<T>();
internal static class RecognizerDefaultClass{
}

public interface IGestureRecognizer{
void AddPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
void HandleNonAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerDownEvent @event);
PointerDeviceKind GetKindForPointer(int pointer);
void Dispose();
T InvokeCallback<T>(string name,FlutterSDK.Gestures.Recognizer.RecognizerCallback<T> callback,Func<String> debugReport = default(Func<String>));
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
@Object DebugOwner{get;}
string DebugDescription{get;}
}


public interface IOneSequenceGestureRecognizer{
void HandleNonAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event);
void AcceptGesture(int pointer);
void RejectGesture(int pointer);
void DidStopTrackingLastPointer(int pointer);
void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition);
void ResolvePointer(int pointer,FlutterSDK.Gestures.Arena.GestureDisposition disposition);
void Dispose();
void StartTrackingPointer(int pointer,Matrix4 transform = default(Matrix4));
void StopTrackingPointer(int pointer);
void StopTrackingIfPointerNoLongerDown(FlutterSDK.Gestures.Events.PointerEvent @event);
FlutterSDK.Gestures.Team.GestureArenaTeam Team{get;set;}
}


public interface IPrimaryPointerGestureRecognizer{
void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event);
void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event);
void HandlePrimaryPointer(FlutterSDK.Gestures.Events.PointerEvent @event);
void DidExceedDeadline();
void DidExceedDeadlineWithEvent(FlutterSDK.Gestures.Events.PointerDownEvent @event);
void AcceptGesture(int pointer);
void RejectGesture(int pointer);
void DidStopTrackingLastPointer(int pointer);
void Dispose();
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
TimeSpan Deadline{get;}
double PreAcceptSlopTolerance{get;}
double PostAcceptSlopTolerance{get;}
FlutterSDK.Gestures.Recognizer.GestureRecognizerState State{get;set;}
int PrimaryPointer{get;set;}
FlutterSDK.Gestures.Recognizer.OffsetPair InitialPosition{get;set;}
}


public class GestureRecognizer : FlutterSDK.Gestures.Arena.GestureArenaMember,IDiagnosticableTreeMixin
{
#region constructors
public GestureRecognizer(@Object debugOwner = default(@Object),PointerDeviceKind kind = default(PointerDeviceKind))
: base()
{
this.DebugOwner = debugOwner;throw new NotImplementedException(); }
#endregion

#region fields
public virtual @Object DebugOwner{get;set;}
internal virtual PointerDeviceKind _KindFilter{get;set;}
internal virtual Dictionary<int,PointerDeviceKind> _PointerToKind{get;set;}
public virtual string DebugDescription{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual void AddPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event){ throw new NotImplementedException(); }


public virtual void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event){ throw new NotImplementedException(); }


public virtual void HandleNonAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event){ throw new NotImplementedException(); }


public virtual bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerDownEvent @event){ throw new NotImplementedException(); }


public virtual PointerDeviceKind GetKindForPointer(int pointer){ throw new NotImplementedException(); }


public virtual void Dispose(){ throw new NotImplementedException(); }


public virtual T InvokeCallback<T>(string name,FlutterSDK.Gestures.Recognizer.RecognizerCallback<T> callback,Func<String> debugReport = default(Func<String>)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class OneSequenceGestureRecognizer : FlutterSDK.Gestures.Recognizer.GestureRecognizer
{
#region constructors
public OneSequenceGestureRecognizer(@Object debugOwner = default(@Object),PointerDeviceKind kind = default(PointerDeviceKind))
: base(debugOwner:debugOwner,kind:kind)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual Dictionary<int,FlutterSDK.Gestures.Arena.GestureArenaEntry> _Entries{get;set;}
internal virtual HashSet<int> _TrackedPointers{get;set;}
internal virtual FlutterSDK.Gestures.Team.GestureArenaTeam _Team{get;set;}
public virtual FlutterSDK.Gestures.Team.GestureArenaTeam Team{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void HandleNonAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event){ throw new NotImplementedException(); }


public virtual void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event){ throw new NotImplementedException(); }


public new void AcceptGesture(int pointer){ throw new NotImplementedException(); }


public new void RejectGesture(int pointer){ throw new NotImplementedException(); }


public virtual void DidStopTrackingLastPointer(int pointer){ throw new NotImplementedException(); }


public virtual void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition){ throw new NotImplementedException(); }


public virtual void ResolvePointer(int pointer,FlutterSDK.Gestures.Arena.GestureDisposition disposition){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }


private FlutterSDK.Gestures.Arena.GestureArenaEntry _AddPointerToArena(int pointer){ throw new NotImplementedException(); }


public virtual void StartTrackingPointer(int pointer,Matrix4 transform = default(Matrix4)){ throw new NotImplementedException(); }


public virtual void StopTrackingPointer(int pointer){ throw new NotImplementedException(); }


public virtual void StopTrackingIfPointerNoLongerDown(FlutterSDK.Gestures.Events.PointerEvent @event){ throw new NotImplementedException(); }

#endregion
}


public class PrimaryPointerGestureRecognizer : FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer
{
#region constructors
public PrimaryPointerGestureRecognizer(TimeSpan deadline = default(TimeSpan),double preAcceptSlopTolerance = default(double),double postAcceptSlopTolerance = default(double),@Object debugOwner = default(@Object),PointerDeviceKind kind = default(PointerDeviceKind))
: base(debugOwner:debugOwner,kind:kind)
{
this.Deadline = deadline;
this.PreAcceptSlopTolerance = preAcceptSlopTolerance;
this.PostAcceptSlopTolerance = postAcceptSlopTolerance;throw new NotImplementedException(); }
#endregion

#region fields
public virtual TimeSpan Deadline{get;set;}
public virtual double PreAcceptSlopTolerance{get;set;}
public virtual double PostAcceptSlopTolerance{get;set;}
public virtual FlutterSDK.Gestures.Recognizer.GestureRecognizerState State{get;set;}
public virtual int PrimaryPointer{get;set;}
public virtual FlutterSDK.Gestures.Recognizer.OffsetPair InitialPosition{get;set;}
internal virtual bool _GestureAccepted{get;set;}
internal virtual Timer _Timer{get;set;}
#endregion

#region methods

public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerDownEvent @event){ throw new NotImplementedException(); }


public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event){ throw new NotImplementedException(); }


public virtual void HandlePrimaryPointer(FlutterSDK.Gestures.Events.PointerEvent @event){ throw new NotImplementedException(); }


public virtual void DidExceedDeadline(){ throw new NotImplementedException(); }


public virtual void DidExceedDeadlineWithEvent(FlutterSDK.Gestures.Events.PointerDownEvent @event){ throw new NotImplementedException(); }


public new void AcceptGesture(int pointer){ throw new NotImplementedException(); }


public new void RejectGesture(int pointer){ throw new NotImplementedException(); }


public new void DidStopTrackingLastPointer(int pointer){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }


private void _StopTimer(){ throw new NotImplementedException(); }


private double _GetGlobalDistance(FlutterSDK.Gestures.Events.PointerEvent @event){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class OffsetPair
{
#region constructors
public OffsetPair(FlutterBinding.UI.Offset local = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset global = default(FlutterBinding.UI.Offset))
{
this.Local = local;
this.Global = global;throw new NotImplementedException(); }
public static OffsetPair FromEventPosition(FlutterSDK.Gestures.Events.PointerEvent @event)
{
var instance =new OffsetPair();throw new NotImplementedException(); }
public static OffsetPair FromEventDelta(FlutterSDK.Gestures.Events.PointerEvent @event)
{
var instance =new OffsetPair();throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Gestures.Recognizer.OffsetPair Zero{get;set;}
public virtual FlutterBinding.UI.Offset Local{get;set;}
public virtual FlutterBinding.UI.Offset Global{get;set;}
#endregion

#region methods

public virtual FlutterSDK.Gestures.Recognizer.OffsetPair AddOperator(FlutterSDK.Gestures.Recognizer.OffsetPair other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Gestures.Recognizer.OffsetPair SubtractOperator(FlutterSDK.Gestures.Recognizer.OffsetPair other){ throw new NotImplementedException(); }


#endregion
}


public enum DragStartBehavior{

Down,
Start,
}


public enum GestureRecognizerState{

Ready,
Possible,
Defunct,
}

}
