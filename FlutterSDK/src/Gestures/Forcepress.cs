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
namespace FlutterSDK.Gestures.Forcepress
{
    public delegate void GestureForcePressStartCallback(FlutterSDK.Gestures.Forcepress.ForcePressDetails details);
    public delegate void GestureForcePressPeakCallback(FlutterSDK.Gestures.Forcepress.ForcePressDetails details);
    public delegate void GestureForcePressUpdateCallback(FlutterSDK.Gestures.Forcepress.ForcePressDetails details);
    public delegate void GestureForcePressEndCallback(FlutterSDK.Gestures.Forcepress.ForcePressDetails details);
    public delegate double GestureForceInterpolation(double pressureMin, double pressureMax, double pressure);
    internal static class ForcepressDefaultClass
    {
    }

    /// <Summary>
    /// Details object for callbacks that use [GestureForcePressStartCallback],
    /// [GestureForcePressPeakCallback], [GestureForcePressEndCallback] or
    /// [GestureForcePressUpdateCallback].
    ///
    /// See also:
    ///
    ///  * [ForcePressGestureRecognizer.onStart], [ForcePressGestureRecognizer.onPeak],
    ///    [ForcePressGestureRecognizer.onEnd], and [ForcePressGestureRecognizer.onUpdate]
    ///    which use [ForcePressDetails].
    /// </Summary>
    public class ForcePressDetails
    {
        #region constructors
        public ForcePressDetails(FlutterBinding.UI.Offset globalPosition = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset), double pressure = default(double))
        : base()
    
}
    #endregion

    #region fields
    public virtual FlutterBinding.UI.Offset GlobalPosition { get; set; }
    public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
    public virtual double Pressure { get; set; }
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Recognizes a force press on devices that have force sensors.
///
/// Only the force from a single pointer is used to invoke events. A tap
/// recognizer will win against this recognizer on pointer up as long as the
/// pointer has not pressed with a force greater than
/// [ForcePressGestureRecognizer.startPressure]. A long press recognizer will
/// win when the press down time exceeds the threshold time as long as the
/// pointer's pressure was never greater than
/// [ForcePressGestureRecognizer.startPressure] in that duration.
///
/// As of November, 2018 iPhone devices of generation 6S and higher have
/// force touch functionality, with the exception of the iPhone XR. In addition,
/// a small handful of Android devices have this functionality as well.
///
/// Devices with faux screen pressure sensors like the Pixel 2 and 3 will not
/// send any force press related callbacks.
///
/// Reported pressure will always be in the range 0.0 to 1.0, where 1.0 is
/// maximum pressure and 0.0 is minimum pressure. If using a custom
/// [interpolation] callback, the pressure reported will correspond to that
/// custom curve.
/// </Summary>
public class ForcePressGestureRecognizer : FlutterSDK.Gestures.Recognizer.OneSequenceGestureRecognizer
{
    #region constructors
    public ForcePressGestureRecognizer(double startPressure = 0.4, double peakPressure = 0.85, FlutterSDK.Gestures.Forcepress.GestureForceInterpolation interpolation = default(FlutterSDK.Gestures.Forcepress.GestureForceInterpolation), @Object debugOwner = default(@Object), PointerDeviceKind kind = default(PointerDeviceKind))
    : base(debugOwner: debugOwner, kind: kind)

}
#endregion

#region fields
public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback OnStart { get; set; }
public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressUpdateCallback OnUpdate { get; set; }
public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressPeakCallback OnPeak { get; set; }
public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback OnEnd { get; set; }
public virtual double StartPressure { get; set; }
public virtual double PeakPressure { get; set; }
public virtual FlutterSDK.Gestures.Forcepress.GestureForceInterpolation Interpolation { get; set; }
internal virtual FlutterSDK.Gestures.Recognizer.OffsetPair _LastPosition { get; set; }
internal virtual double _LastPressure { get; set; }
internal virtual FlutterSDK.Gestures.Forcepress._ForceState _State { get; set; }
public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void AddAllowedPointer(FlutterSDK.Gestures.Events.PointerEvent @event)
{
    if (!(@event is PointerUpEvent) && @event.PressureMax <= 1.0)
    {
        Resolve(GestureDisposition.Rejected);
    }
    else
    {
        StartTrackingPointer(@event.Pointer, @event.Transform);
        if (_State == _ForceState.Ready)
        {
            _State = _ForceState.Possible;
            _LastPosition = OffsetPair.FromEventPosition(@event);
        }

    }

}




public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
{

    if (@event is PointerMoveEvent || @event is PointerDownEvent)
    {
        if (((PointerMoveEvent)@event).Pressure > ((PointerMoveEvent)@event).PressureMax || ((PointerMoveEvent)@event).Pressure < ((PointerMoveEvent)@event).PressureMin)
        {
            PrintDefaultClass.DebugPrint("The reported device pressure " + ((PointerMoveEvent)@event).Pressure.ToString() + " is outside of the device pressure range where: " + ((PointerMoveEvent)@event).PressureMin.ToString() + " <= pressure <= " + ((PointerMoveEvent)@event).PressureMax.ToString());
        }

        double pressure = Interpolation(@event.PressureMin, @event.PressureMax, @event.Pressure);

        _LastPosition = OffsetPair.FromEventPosition(@event);
        _LastPressure = pressure;
        if (_State == _ForceState.Possible)
        {
            if (pressure > StartPressure)
            {
                _State = _ForceState.Started;
                Resolve(GestureDisposition.Accepted);
            }
            else if (@event.Delta.DistanceSquared > ConstantsDefaultClass.KTouchSlop)
            {
                Resolve(GestureDisposition.Rejected);
            }

        }

        if (pressure > StartPressure && _State == _ForceState.Accepted)
        {
            _State = _ForceState.Started;
            if (OnStart != null)
            {
                InvokeCallback("onStart", () => =>OnStart(new ForcePressDetails(pressure: pressure, globalPosition: _LastPosition.Global, localPosition: _LastPosition.Local)));
            }

        }

        if (OnPeak != null && pressure > PeakPressure && (_State == _ForceState.Started))
        {
            _State = _ForceState.Peaked;
            if (OnPeak != null)
            {
                InvokeCallback("onPeak", () => =>OnPeak(new ForcePressDetails(pressure: pressure, globalPosition: @event.Position, localPosition: @event.LocalPosition)));
            }

        }

        if (OnUpdate != null && !pressure.IsNaN && (_State == _ForceState.Started || _State == _ForceState.Peaked))
        {
            if (OnUpdate != null)
            {
                InvokeCallback("onUpdate", () => =>OnUpdate(new ForcePressDetails(pressure: pressure, globalPosition: @event.Position, localPosition: @event.LocalPosition)));
            }

        }

    }

    StopTrackingIfPointerNoLongerDown(@event);
}




public new void AcceptGesture(int pointer)
{
    if (_State == _ForceState.Possible) _State = _ForceState.Accepted;
    if (OnStart != null && _State == _ForceState.Started)
    {
        InvokeCallback("onStart", () => =>OnStart(new ForcePressDetails(pressure: _LastPressure, globalPosition: _LastPosition.Global, localPosition: _LastPosition.Local)));
    }

}




public new void DidStopTrackingLastPointer(int pointer)
{
    bool wasAccepted = _State == _ForceState.Started || _State == _ForceState.Peaked;
    if (_State == _ForceState.Possible)
    {
        Resolve(GestureDisposition.Rejected);
        return;
    }

    if (wasAccepted && OnEnd != null)
    {
        if (OnEnd != null)
        {
            InvokeCallback("onEnd", () => =>OnEnd(new ForcePressDetails(pressure: 0.0, globalPosition: _LastPosition.Global, localPosition: _LastPosition.Local)));
        }

    }

    _State = _ForceState.Ready;
}




public new void RejectGesture(int pointer)
{
    StopTrackingPointer(pointer);
    DidStopTrackingLastPointer(pointer);
}




private double _InverseLerp(double min, double max, double t)
{

    double value = (t - min) / (max - min);
    if (!value.IsNaN) value = value.Clamp(0.0, 1.0) as double;
    return value;
}



#endregion
}


public enum _ForceState
{

    Ready,
    Possible,
    Accepted,
    Started,
    Peaked,
}

}
