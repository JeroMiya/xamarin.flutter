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
namespace FlutterSDK.Animation.Animationcontroller{
public delegate void _DirectionSetter(FlutterSDK.Animation.Animationcontroller._AnimationDirection direction);
internal static class AnimationcontrollerDefaultClass{
public static FlutterSDK.Physics.Springsimulation.SpringDescription _KFlingSpringDescription = default(FlutterSDK.Physics.Springsimulation.SpringDescription);
public static FlutterSDK.Physics.Tolerance.Tolerance _KFlingTolerance = default(FlutterSDK.Physics.Tolerance.Tolerance);
}

public class AnimationController : FlutterSDK.Animation.Animation.Animation<double>,IAnimationEagerListenerMixin,IAnimationLocalListenersMixin,IAnimationLocalStatusListenersMixin
{
#region constructors
public AnimationController(double value = default(double),TimeSpan duration = default(TimeSpan),TimeSpan reverseDuration = default(TimeSpan),string debugLabel = default(string),double lowerBound = 0.0,double upperBound = 1.0,FlutterSDK.Animation.Animationcontroller.AnimationBehavior animationBehavior = default(FlutterSDK.Animation.Animationcontroller.AnimationBehavior),FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider))
: base()
{
this.Duration = duration;
this.ReverseDuration = reverseDuration;
this.DebugLabel = debugLabel;
this.LowerBound = lowerBound;
this.UpperBound = upperBound;
this.AnimationBehavior = animationBehavior;throw new NotImplementedException(); }
public static AnimationController Unbounded(double value = 0.0,TimeSpan duration = default(TimeSpan),TimeSpan reverseDuration = default(TimeSpan),string debugLabel = default(string),FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider),FlutterSDK.Animation.Animationcontroller.AnimationBehavior animationBehavior = default(FlutterSDK.Animation.Animationcontroller.AnimationBehavior))
{
var instance =new AnimationController();instance.Duration = duration;
instance.ReverseDuration = reverseDuration;
instance.DebugLabel = debugLabel;
instance.AnimationBehavior = animationBehavior;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double LowerBound{get;set;}
public virtual double UpperBound{get;set;}
public virtual string DebugLabel{get;set;}
public virtual FlutterSDK.Animation.Animationcontroller.AnimationBehavior AnimationBehavior{get;set;}
public virtual TimeSpan Duration{get;set;}
public virtual TimeSpan ReverseDuration{get;set;}
internal virtual FlutterSDK.Scheduler.Ticker.Ticker _Ticker{get;set;}
internal virtual FlutterSDK.Physics.Simulation.Simulation _Simulation{get;set;}
internal virtual double _Value{get;set;}
internal virtual TimeSpan _LastElapsedDuration{get;set;}
internal virtual FlutterSDK.Animation.Animationcontroller._AnimationDirection _Direction{get;set;}
internal virtual FlutterSDK.Animation.Animation.AnimationStatus _Status{get;set;}
internal virtual FlutterSDK.Animation.Animation.AnimationStatus _LastReportedStatus{get;set;}
public virtual FlutterSDK.Animation.Animation.Animation<double> View{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double Value{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual double Velocity{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual TimeSpan LastElapsedDuration{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsAnimating{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Animation.Animation.AnimationStatus Status{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual void Resync(FlutterSDK.Scheduler.Ticker.TickerProvider vsync){ throw new NotImplementedException(); }


public virtual void Reset(){ throw new NotImplementedException(); }


private void _InternalSetValue(double newValue){ throw new NotImplementedException(); }


public virtual FlutterSDK.Scheduler.Ticker.TickerFuture Forward(double from = default(double)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Scheduler.Ticker.TickerFuture Reverse(double from = default(double)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Scheduler.Ticker.TickerFuture AnimateTo(double target,TimeSpan duration = default(TimeSpan),FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Scheduler.Ticker.TickerFuture AnimateBack(double target,TimeSpan duration = default(TimeSpan),FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)){ throw new NotImplementedException(); }


private FlutterSDK.Scheduler.Ticker.TickerFuture _AnimateToInternal(double target,TimeSpan duration = default(TimeSpan),FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Scheduler.Ticker.TickerFuture Repeat(double min = default(double),double max = default(double),bool reverse = false,TimeSpan period = default(TimeSpan)){ throw new NotImplementedException(); }


private void _DirectionSetter(FlutterSDK.Animation.Animationcontroller._AnimationDirection direction){ throw new NotImplementedException(); }


public virtual FlutterSDK.Scheduler.Ticker.TickerFuture Fling(double velocity = 1.0,FlutterSDK.Animation.Animationcontroller.AnimationBehavior animationBehavior = default(FlutterSDK.Animation.Animationcontroller.AnimationBehavior)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Scheduler.Ticker.TickerFuture AnimateWith(FlutterSDK.Physics.Simulation.Simulation simulation){ throw new NotImplementedException(); }


private FlutterSDK.Scheduler.Ticker.TickerFuture _StartSimulation(FlutterSDK.Physics.Simulation.Simulation simulation){ throw new NotImplementedException(); }


public virtual void Stop(bool canceled = true){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }


private void _CheckStatusChanged(){ throw new NotImplementedException(); }


private void _Tick(TimeSpan elapsed){ throw new NotImplementedException(); }


public new string ToStringDetails(){ throw new NotImplementedException(); }

#endregion
}


public class _InterpolationSimulation : FlutterSDK.Physics.Simulation.Simulation
{
#region constructors
public _InterpolationSimulation(double _begin,double _end,TimeSpan duration,FlutterSDK.Animation.Curves.Curve _curve,double scale)
: base()
{
this._Begin = _begin;
this._End = _end;
this._Curve = _curve;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual double _DurationInSeconds{get;set;}
internal virtual double _Begin{get;set;}
internal virtual double _End{get;set;}
internal virtual FlutterSDK.Animation.Curves.Curve _Curve{get;set;}
#endregion

#region methods

public new double x(double timeInSeconds){ throw new NotImplementedException(); }


public new double Dx(double timeInSeconds){ throw new NotImplementedException(); }


public new bool IsDone(double timeInSeconds){ throw new NotImplementedException(); }

#endregion
}


public class _RepeatingSimulation : FlutterSDK.Physics.Simulation.Simulation
{
#region constructors
public _RepeatingSimulation(double initialValue,double min,double max,bool reverse,TimeSpan period,FlutterSDK.Animation.Animationcontroller._DirectionSetter directionSetter)
: base()
{
this.Min = min;
this.Max = max;
this.Reverse = reverse;
this.DirectionSetter = directionSetter;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double Min{get;set;}
public virtual double Max{get;set;}
public virtual bool Reverse{get;set;}
public virtual FlutterSDK.Animation.Animationcontroller._DirectionSetter DirectionSetter{get;set;}
internal virtual double _PeriodInSeconds{get;set;}
internal virtual double _InitialT{get;set;}
#endregion

#region methods

public new double x(double timeInSeconds){ throw new NotImplementedException(); }


public new double Dx(double timeInSeconds){ throw new NotImplementedException(); }


public new bool IsDone(double timeInSeconds){ throw new NotImplementedException(); }

#endregion
}


public enum _AnimationDirection{

Forward,
Reverse,
}


public enum AnimationBehavior{

Normal,
Preserve,
}

}
