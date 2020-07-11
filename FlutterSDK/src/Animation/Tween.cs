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
namespace FlutterSDK.Animation.Tween{
internal static class TweenDefaultClass{
}

public interface IAnimatable<T>{
T Transform(double t);
T Evaluate(FlutterSDK.Animation.Animation.Animation<double> animation);
Animation<T> Animate(FlutterSDK.Animation.Animation.Animation<double> parent);
Animatable<T> Chain(FlutterSDK.Animation.Tween.Animatable<double> parent);
}


public class Animatable<T>
{
#region constructors
public Animatable()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public virtual T Transform(double t){ throw new NotImplementedException(); }


public virtual T Evaluate(FlutterSDK.Animation.Animation.Animation<double> animation){ throw new NotImplementedException(); }


public virtual Animation<T> Animate(FlutterSDK.Animation.Animation.Animation<double> parent){ throw new NotImplementedException(); }


public virtual Animatable<T> Chain(FlutterSDK.Animation.Tween.Animatable<double> parent){ throw new NotImplementedException(); }

#endregion
}


public class _AnimatedEvaluation<T> : FlutterSDK.Animation.Animation.Animation<T>,IAnimationWithParentMixin<double>
{
#region constructors
public _AnimatedEvaluation(FlutterSDK.Animation.Animation.Animation<double> parent,FlutterSDK.Animation.Tween.Animatable<T> _evaluatable)
{
this.Parent = parent;
this._Evaluatable = _evaluatable;throw new NotImplementedException(); }
#endregion

#region fields
public new FlutterSDK.Animation.Animation.Animation<double> Parent{get;set;}
internal virtual FlutterSDK.Animation.Tween.Animatable<T> _Evaluatable{get;set;}
public virtual T Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods


public new string ToStringDetails(){ throw new NotImplementedException(); }

#endregion
}


public class _ChainedEvaluation<T> : FlutterSDK.Animation.Tween.Animatable<T>
{
#region constructors
public _ChainedEvaluation(FlutterSDK.Animation.Tween.Animatable<double> _parent,FlutterSDK.Animation.Tween.Animatable<T> _evaluatable)
{
this._Parent = _parent;
this._Evaluatable = _evaluatable;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Animation.Tween.Animatable<double> _Parent{get;set;}
internal virtual FlutterSDK.Animation.Tween.Animatable<T> _Evaluatable{get;set;}
#endregion

#region methods

public new T Transform(double t){ throw new NotImplementedException(); }


#endregion
}


public class Tween<T> : FlutterSDK.Animation.Tween.Animatable<T>
{
#region constructors
public Tween(T begin = default(T),T end = default(T))
{
this.Begin = begin;
this.End = end;throw new NotImplementedException(); }
#endregion

#region fields
public virtual T Begin{get;set;}
public virtual T End{get;set;}
#endregion

#region methods

public virtual T Lerp(double t){ throw new NotImplementedException(); }


public new T Transform(double t){ throw new NotImplementedException(); }


#endregion
}


public class ReverseTween<T> : FlutterSDK.Animation.Tween.Tween<T>
{
#region constructors
public ReverseTween(FlutterSDK.Animation.Tween.Tween<T> parent)
: base(begin:parent.End,end:parent.Begin)
{
this.Parent = parent;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Tween.Tween<T> Parent{get;set;}
#endregion

#region methods

public new T Lerp(double t){ throw new NotImplementedException(); }

#endregion
}


public class ColorTween : FlutterSDK.Animation.Tween.Tween<Color>
{
#region constructors
public ColorTween(FlutterBinding.UI.Color begin = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color end = default(FlutterBinding.UI.Color))
: base(begin:begin,end:end)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new Color Lerp(double t){ throw new NotImplementedException(); }

#endregion
}


public class SizeTween : FlutterSDK.Animation.Tween.Tween<Size>
{
#region constructors
public SizeTween(Size begin = default(Size),Size end = default(Size))
: base(begin:begin,end:end)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new Size Lerp(double t){ throw new NotImplementedException(); }

#endregion
}


public class RectTween : FlutterSDK.Animation.Tween.Tween<Rect>
{
#region constructors
public RectTween(FlutterBinding.UI.Rect begin = default(FlutterBinding.UI.Rect),FlutterBinding.UI.Rect end = default(FlutterBinding.UI.Rect))
: base(begin:begin,end:end)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new Rect Lerp(double t){ throw new NotImplementedException(); }

#endregion
}


public class IntTween : FlutterSDK.Animation.Tween.Tween<int>
{
#region constructors
public IntTween(int begin = default(int),int end = default(int))
: base(begin:begin,end:end)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new int Lerp(double t){ throw new NotImplementedException(); }

#endregion
}


public class StepTween : FlutterSDK.Animation.Tween.Tween<int>
{
#region constructors
public StepTween(int begin = default(int),int end = default(int))
: base(begin:begin,end:end)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new int Lerp(double t){ throw new NotImplementedException(); }

#endregion
}


public class ConstantTween<T> : FlutterSDK.Animation.Tween.Tween<T>
{
#region constructors
public ConstantTween(T value)
: base(begin:value,end:value)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new T Lerp(double t){ throw new NotImplementedException(); }


#endregion
}


public class CurveTween : FlutterSDK.Animation.Tween.Animatable<double>
{
#region constructors
public CurveTween(FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
: base()
{
this.Curve = curve;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Curves.Curve Curve{get;set;}
#endregion

#region methods

public new double Transform(double t){ throw new NotImplementedException(); }


#endregion
}

}
