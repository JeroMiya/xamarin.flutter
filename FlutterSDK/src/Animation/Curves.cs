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
namespace FlutterSDK.Animation.Curves{
internal static class CurvesDefaultClass{
internal static double _Bounce(double t){
throw new NotImplementedException();
}

}

public interface IParametricCurve<T>{
T Transform(double t);
T TransformInternal(double t);
string ToString();
}


public interface ICurve{
double Transform(double t);
FlutterSDK.Animation.Curves.Curve Flipped{get;}
}


public interface ICurve2D{
Iterable<FlutterSDK.Animation.Curves.Curve2DSample> GenerateSamples(double start = 0.0,double end = 1.0,double tolerance = 1e-10);
double FindInverse(double x);
int SamplingSeed{get;}
}


public class ParametricCurve<T>
{
#region constructors
public ParametricCurve()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public virtual T Transform(double t){ throw new NotImplementedException(); }


public virtual T TransformInternal(double t){ throw new NotImplementedException(); }


#endregion
}


public class Curve : FlutterSDK.Animation.Curves.ParametricCurve<double>
{
#region constructors
public Curve()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Curves.Curve Flipped{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new double Transform(double t){ throw new NotImplementedException(); }

#endregion
}


public class _Linear : FlutterSDK.Animation.Curves.Curve
{
#region constructors
internal _Linear()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }

#endregion
}


public class SawTooth : FlutterSDK.Animation.Curves.Curve
{
#region constructors
public SawTooth(int count)
: base()
{
this.Count = count;throw new NotImplementedException(); }
#endregion

#region fields
public virtual int Count{get;set;}
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }


#endregion
}


public class Interval : FlutterSDK.Animation.Curves.Curve
{
#region constructors
public Interval(double begin,double end,FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
: base()
{
this.Begin = begin;
this.End = end;
this.Curve = curve;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double Begin{get;set;}
public virtual double End{get;set;}
public virtual FlutterSDK.Animation.Curves.Curve Curve{get;set;}
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }


#endregion
}


public class Threshold : FlutterSDK.Animation.Curves.Curve
{
#region constructors
public Threshold(double threshold)
: base()
{
this.ThresholdValue = threshold;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double ThresholdValue{get;set;}
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }

#endregion
}


public class Cubic : FlutterSDK.Animation.Curves.Curve
{
#region constructors
public Cubic(double a,double b,double c,double d)
: base()
{
this.a = a;
this.b = b;
this.c = c;
this.d = d;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double a{get;set;}
public virtual double b{get;set;}
public virtual double c{get;set;}
public virtual double d{get;set;}
internal virtual double _CubicErrorBound{get;set;}
#endregion

#region methods

private double _EvaluateCubic(double a,double b,double m){ throw new NotImplementedException(); }


public new double TransformInternal(double t){ throw new NotImplementedException(); }


#endregion
}


public class Curve2D : FlutterSDK.Animation.Curves.ParametricCurve<Offset>
{
#region constructors
public Curve2D()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual int SamplingSeed{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual Iterable<FlutterSDK.Animation.Curves.Curve2DSample> GenerateSamples(double start = 0.0,double end = 1.0,double tolerance = 1e-10){ throw new NotImplementedException(); }


public virtual double FindInverse(double x){ throw new NotImplementedException(); }

#endregion
}


public class Curve2DSample
{
#region constructors
public Curve2DSample(double t,FlutterBinding.UI.Offset value)
: base()
{
this.t = t;
this.Value = value;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double t{get;set;}
public virtual FlutterBinding.UI.Offset Value{get;set;}
#endregion

#region methods

#endregion
}


public class CatmullRomSpline : FlutterSDK.Animation.Curves.Curve2D
{
#region constructors
public CatmullRomSpline(List<FlutterBinding.UI.Offset> controlPoints,double tension = 0.0,FlutterBinding.UI.Offset startHandle = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset endHandle = default(FlutterBinding.UI.Offset))
: base()
{
throw new NotImplementedException(); }
public static CatmullRomSpline Precompute(List<FlutterBinding.UI.Offset> controlPoints,double tension = 0.0,FlutterBinding.UI.Offset startHandle = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset endHandle = default(FlutterBinding.UI.Offset))
{
var instance =new CatmullRomSpline();throw new NotImplementedException(); }
#endregion

#region fields
internal virtual List<List<Offset>> _CubicSegments{get;set;}
internal virtual List<Offset> _ControlPoints{get;set;}
internal virtual FlutterBinding.UI.Offset _StartHandle{get;set;}
internal virtual FlutterBinding.UI.Offset _EndHandle{get;set;}
internal virtual double _Tension{get;set;}
public virtual int SamplingSeed{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private List<List<Offset>> _ComputeSegments(List<FlutterBinding.UI.Offset> controlPoints,double tension,FlutterBinding.UI.Offset startHandle = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset endHandle = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


private void _InitializeIfNeeded(){ throw new NotImplementedException(); }


public new Offset TransformInternal(double t){ throw new NotImplementedException(); }

#endregion
}


public class CatmullRomCurve : FlutterSDK.Animation.Curves.Curve
{
#region constructors
public CatmullRomCurve(List<FlutterBinding.UI.Offset> controlPoints,double tension = 0.0)
: base()
{
this.ControlPoints = controlPoints;
this.Tension = tension;throw new NotImplementedException(); }
public static CatmullRomCurve Precompute(List<FlutterBinding.UI.Offset> controlPoints,double tension = 0.0)
{
var instance =new CatmullRomCurve();instance.ControlPoints = controlPoints;
instance.Tension = tension;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual List<string> _DebugAssertReasons{get;set;}
internal virtual List<FlutterSDK.Animation.Curves.Curve2DSample> _PrecomputedSamples{get;set;}
public virtual List<Offset> ControlPoints{get;set;}
public virtual double Tension{get;set;}
#endregion

#region methods

private List<FlutterSDK.Animation.Curves.Curve2DSample> _ComputeSamples(List<FlutterBinding.UI.Offset> controlPoints,double tension){ throw new NotImplementedException(); }


public virtual bool ValidateControlPoints(List<FlutterBinding.UI.Offset> controlPoints,double tension = 0.0,List<string> reasons = default(List<string>)){ throw new NotImplementedException(); }


public new double TransformInternal(double t){ throw new NotImplementedException(); }

#endregion
}


public class FlippedCurve : FlutterSDK.Animation.Curves.Curve
{
#region constructors
public FlippedCurve(FlutterSDK.Animation.Curves.Curve curve)
: base()
{
this.Curve = curve;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Curves.Curve Curve{get;set;}
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }


#endregion
}


public class _DecelerateCurve : FlutterSDK.Animation.Curves.Curve
{
#region constructors
internal _DecelerateCurve()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }

#endregion
}


public class _BounceInCurve : FlutterSDK.Animation.Curves.Curve
{
#region constructors
internal _BounceInCurve()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }

#endregion
}


public class _BounceOutCurve : FlutterSDK.Animation.Curves.Curve
{
#region constructors
internal _BounceOutCurve()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }

#endregion
}


public class _BounceInOutCurve : FlutterSDK.Animation.Curves.Curve
{
#region constructors
internal _BounceInOutCurve()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }

#endregion
}


public class ElasticInCurve : FlutterSDK.Animation.Curves.Curve
{
#region constructors
public ElasticInCurve(double period = 0.4)
{
this.Period = period;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double Period{get;set;}
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }


#endregion
}


public class ElasticOutCurve : FlutterSDK.Animation.Curves.Curve
{
#region constructors
public ElasticOutCurve(double period = 0.4)
{
this.Period = period;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double Period{get;set;}
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }


#endregion
}


public class ElasticInOutCurve : FlutterSDK.Animation.Curves.Curve
{
#region constructors
public ElasticInOutCurve(double period = 0.4)
{
this.Period = period;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double Period{get;set;}
#endregion

#region methods

public new double TransformInternal(double t){ throw new NotImplementedException(); }


#endregion
}


public class Curves
{
#region constructors
internal Curves()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Curves.Curve Linear{get;set;}
public virtual FlutterSDK.Animation.Curves.Curve Decelerate{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic FastLinearToSlowEaseIn{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic Ease{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseIn{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInToLinear{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInSine{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInQuad{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInCubic{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInQuart{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInQuint{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInExpo{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInCirc{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInBack{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseOut{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic LinearToEaseOut{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseOutSine{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseOutQuad{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseOutCubic{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseOutQuart{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseOutQuint{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseOutExpo{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseOutCirc{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseOutBack{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInOut{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutSine{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutQuad{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutCubic{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutQuart{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutQuint{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutExpo{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutCirc{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutBack{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic FastOutSlowIn{get;set;}
public virtual FlutterSDK.Animation.Curves.Cubic SlowMiddle{get;set;}
public virtual FlutterSDK.Animation.Curves.Curve BounceIn{get;set;}
public virtual FlutterSDK.Animation.Curves.Curve BounceOut{get;set;}
public virtual FlutterSDK.Animation.Curves.Curve BounceInOut{get;set;}
public virtual FlutterSDK.Animation.Curves.ElasticInCurve ElasticIn{get;set;}
public virtual FlutterSDK.Animation.Curves.ElasticOutCurve ElasticOut{get;set;}
public virtual FlutterSDK.Animation.Curves.ElasticInOutCurve ElasticInOut{get;set;}
#endregion

#region methods
#endregion
}

}
