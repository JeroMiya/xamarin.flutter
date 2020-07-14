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
namespace FlutterSDK.Gestures.Longpress
{
    public delegate void GestureLongPressCallback();
    public delegate void GestureLongPressUpCallback();
    public delegate void GestureLongPressStartCallback(FlutterSDK.Gestures.Longpress.LongPressStartDetails details);
    public delegate void GestureLongPressMoveUpdateCallback(FlutterSDK.Gestures.Longpress.LongPressMoveUpdateDetails details);
    public delegate void GestureLongPressEndCallback(FlutterSDK.Gestures.Longpress.LongPressEndDetails details);
    internal static class LongpressDefaultClass
    {
    }

    /// <Summary>
    /// Details for callbacks that use [GestureLongPressStartCallback].
    ///
    /// See also:
    ///
    ///  * [LongPressGestureRecognizer.onLongPressStart], which uses [GestureLongPressStartCallback].
    ///  * [LongPressMoveUpdateDetails], the details for [GestureLongPressMoveUpdateCallback]
    ///  * [LongPressEndDetails], the details for [GestureLongPressEndCallback].
    /// </Summary>
    public class LongPressStartDetails
    {
        #region constructors
        public LongPressStartDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset))
        : base()
    
}
    #endregion

    #region fields
    public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
    public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Details for callbacks that use [GestureLongPressMoveUpdateCallback].
///
/// See also:
///
///  * [LongPressGestureRecognizer.onLongPressMoveUpdate], which uses [GestureLongPressMoveUpdateCallback].
///  * [LongPressEndDetails], the details for [GestureLongPressEndCallback]
///  * [LongPressStartDetails], the details for [GestureLongPressStartCallback].
/// </Summary>
public class LongPressMoveUpdateDetails
{
    #region constructors
    public LongPressMoveUpdateDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset offsetFromOrigin = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localOffsetFromOrigin = default(FlutterBinding.UI.Offset))
    : base()

}
#endregion

#region fields
public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
public virtual FlutterBinding.UI.Offset OffsetFromOrigin { get; set; }
public virtual FlutterBinding.UI.Offset LocalOffsetFromOrigin { get; set; }
#endregion

#region methods
#endregion
}


/// <Summary>
/// Details for callbacks that use [GestureLongPressEndCallback].
///
/// See also:
///
///  * [LongPressGestureRecognizer.onLongPressEnd], which uses [GestureLongPressEndCallback].
///  * [LongPressMoveUpdateDetails], the details for [GestureLongPressMoveUpdateCallback]
///  * [LongPressStartDetails], the details for [GestureLongPressStartCallback].
/// </Summary>
public class LongPressEndDetails
{
    #region constructors
    public LongPressEndDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), FlutterSDK.Gestures.Velocitytracker.Velocity velocity = default(FlutterSDK.Gestures.Velocitytracker.Velocity))
    : base()

}
#endregion

#region fields
public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
public virtual FlutterSDK.Gestures.Velocitytracker.Velocity Velocity { get; set; }
#endregion

#region methods
#endregion
}


/// <Summary>
/// Recognizes when the user has pressed down at the same location for a long
/// period of time.
///
/// The gesture must not deviate in position from its touch down point for 500ms
/// until it's recognized. Once the gesture is accepted, the finger can be
/// moved, triggering [onLongPressMoveUpdate] callbacks, unless the
/// [postAcceptSlopTolerance] constructor argument is specified.
///
/// [LongPressGestureRecognizer] competes on pointer events of [kPrimaryButton]
/// only when it has at least one non-null callback. If it has no callbacks, it
/// is a no-op.
/// </Summary>
public class LongPressGestureRecognizer : FlutterSDK.Gestures.Recognizer.PrimaryPointerGestureRecognizer
{
    #region constructors
    public LongPressGestureRecognizer(TimeSpan duration = default(TimeSpan), double postAcceptSlopTolerance = default(double), PointerDeviceKind kind = default(PointerDeviceKind), @Object debugOwner = default(@Object))
    : base(deadline: duration ?? ConstantsDefaultClass.KLongPressTimeout, postAcceptSlopTolerance: postAcceptSlopTolerance, kind: kind, debugOwner: debugOwner)

}
#endregion

#region fields
internal virtual bool _LongPressAccepted { get; set; }
internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _LongPressOrigin { get; set; }
internal virtual int _InitialButtons { get; set; }
public virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback OnLongPress { get; set; }
public virtual FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback OnLongPressStart { get; set; }
public virtual FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback OnLongPressMoveUpdate { get; set; }
public virtual FlutterSDK.Gestures.Longpress.GestureLongPressUpCallback OnLongPressUp { get; set; }
public virtual FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback OnLongPressEnd { get; set; }
internal virtual FlutterSDK.Gestures.Velocitytracker.VelocityTracker _VelocityTracker { get; set; }
public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerDownEvent @event)
{
    switch (@event.Buttons) { case EventsDefaultClass.KPrimaryButton: if (OnLongPressStart == null && OnLongPress == null && OnLongPressMoveUpdate == null && OnLongPressEnd == null && OnLongPressUp == null) return false; break; default: return false; }
    return base.IsPointerAllowed(@event);
}




public new void DidExceedDeadline()
{
    Resolve(GestureDisposition.Accepted);
    _LongPressAccepted = true;
    base.AcceptGesture(PrimaryPointer);
    _CheckLongPressStart();
}




public new void HandlePrimaryPointer(FlutterSDK.Gestures.Events.PointerEvent @event)
{
    if (!@event.Synthesized)
    {
        if (((PointerDownEvent)@event) is PointerDownEvent)
        {
            _VelocityTracker = new VelocityTracker();
            _VelocityTracker.AddPosition(((PointerDownEvent)@event).TimeStamp, ((PointerDownEvent)@event).LocalPosition);
        }

        if (@event is PointerMoveEvent)
        {

            _VelocityTracker.AddPosition(((PointerMoveEvent)@event).TimeStamp, ((PointerMoveEvent)@event).LocalPosition);
        }

    }

    if (@event is PointerUpEvent)
    {
        if (_LongPressAccepted == true)
        {
            _CheckLongPressEnd(((PointerUpEvent)@event));
        }
        else
        {
            Resolve(GestureDisposition.Rejected);
        }

        _Reset();
    }
    else if (@event is PointerCancelEvent)
    {
        _Reset();
    }
    else if (@event is PointerDownEvent)
    {
        _LongPressOrigin = OffsetPair.FromEventPosition(((PointerDownEvent)@event));
        _InitialButtons = ((PointerDownEvent)@event).Buttons;
    }
    else if (@event is PointerMoveEvent)
    {
        if (((PointerMoveEvent)@event).Buttons != _InitialButtons)
        {
            Resolve(GestureDisposition.Rejected);
            StopTrackingPointer(PrimaryPointer);
        }
        else if (_LongPressAccepted)
        {
            _CheckLongPressMoveUpdate(@event);
        }

    }

}




private void _CheckLongPressStart()
{

    if (OnLongPressStart != null)
    {
        LongPressStartDetails details = new LongPressStartDetails(globalPosition: _LongPressOrigin.Global, localPosition: _LongPressOrigin.Local);
        InvokeCallback("onLongPressStart", () => =>OnLongPressStart(details));
    }

    if (OnLongPress != null) InvokeCallback("onLongPress", OnLongPress);
}




private void _CheckLongPressMoveUpdate(FlutterSDK.Gestures.Events.PointerEvent @event)
{

    LongPressMoveUpdateDetails details = new LongPressMoveUpdateDetails(globalPosition: @event.Position, localPosition: @event.LocalPosition, offsetFromOrigin: @event.Position - _LongPressOrigin.Global, localOffsetFromOrigin: @event.LocalPosition - _LongPressOrigin.Local);
    if (OnLongPressMoveUpdate != null) InvokeCallback("onLongPressMoveUpdate", () => =>OnLongPressMoveUpdate(details));
}




private void _CheckLongPressEnd(FlutterSDK.Gestures.Events.PointerEvent @event)
{

    VelocityEstimate estimate = _VelocityTracker.GetVelocityEstimate();
    Velocity velocity = estimate == null ? VelocitytrackerDefaultClass.Velocity.Zero : new Velocity(pixelsPerSecond: estimate.PixelsPerSecond);
    LongPressEndDetails details = new LongPressEndDetails(globalPosition: @event.Position, localPosition: @event.LocalPosition, velocity: velocity);
    _VelocityTracker = null;
    if (OnLongPressEnd != null) InvokeCallback("onLongPressEnd", () => =>OnLongPressEnd(details));
    if (OnLongPressUp != null) InvokeCallback("onLongPressUp", OnLongPressUp);
}




private void _Reset()
{
    _LongPressAccepted = false;
    _LongPressOrigin = null;
    _InitialButtons = null;
    _VelocityTracker = null;
}




public new void Resolve(FlutterSDK.Gestures.Arena.GestureDisposition disposition)
{
    if (_LongPressAccepted && disposition == GestureDisposition.Rejected)
    {
        _Reset();
    }

    base.Resolve(disposition);
}




public new void AcceptGesture(int pointer)
{
}



#endregion
}

}
