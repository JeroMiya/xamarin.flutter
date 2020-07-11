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
namespace FlutterSDK.Animation.Animations{
internal static class AnimationsDefaultClass{
public static FlutterSDK.Animation.Animation.Animation<double> KAlwaysCompleteAnimation = default(FlutterSDK.Animation.Animation.Animation<double>);
public static FlutterSDK.Animation.Animation.Animation<double> KAlwaysDismissedAnimation = default(FlutterSDK.Animation.Animation.Animation<double>);
}

public interface ICompoundAnimation<T>{
void DidStartListening();
void DidStopListening();
string ToString();
FlutterSDK.Animation.Animation.Animation<T> First{get;}
FlutterSDK.Animation.Animation.Animation<T> Next{get;}
FlutterSDK.Animation.Animation.AnimationStatus Status{get;}
}


public interface IAnimationWithParentMixin<T>{}

public class AnimationWithParentMixin<T>{
public virtual FlutterSDK.Animation.Animation.Animation<T> Parent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Animation.Animation.AnimationStatus Status{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}

public virtual void AddListener(VoidCallback listener){ throw new NotImplementedException(); }


public virtual void RemoveListener(VoidCallback listener){ throw new NotImplementedException(); }


public virtual void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


public virtual void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }

}
public static class AnimationWithParentMixinMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
static AnimationWithParentMixin<T> GetOrCreate<T>(IAnimationWithParentMixin<T> instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new AnimationWithParentMixin<T>();
_table.Add(instance, value);
}
return (AnimationWithParentMixin<T>)value;
}
public static FlutterSDK.Animation.Animation.Animation<T> ParentProperty<T>(this IAnimationWithParentMixin<T> instance) => GetOrCreate(instance).Parent;
public static FlutterSDK.Animation.Animation.AnimationStatus StatusProperty<T>(this IAnimationWithParentMixin<T> instance) => GetOrCreate(instance).Status;
public static void AddListener<T>(this IAnimationWithParentMixin<T> instance,VoidCallback listener) => GetOrCreate(instance).AddListener(listener);
public static void RemoveListener<T>(this IAnimationWithParentMixin<T> instance,VoidCallback listener) => GetOrCreate(instance).RemoveListener(listener);
public static void AddStatusListener<T>(this IAnimationWithParentMixin<T> instance,FlutterSDK.Animation.Animation.AnimationStatusListener listener) => GetOrCreate(instance).AddStatusListener(listener);
public static void RemoveStatusListener<T>(this IAnimationWithParentMixin<T> instance,FlutterSDK.Animation.Animation.AnimationStatusListener listener) => GetOrCreate(instance).RemoveStatusListener(listener);
}


public class _AlwaysCompleteAnimation : FlutterSDK.Animation.Animation.Animation<double>
{
#region constructors
public _AlwaysCompleteAnimation()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Animation.AnimationStatus Status{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void AddListener(VoidCallback listener){ throw new NotImplementedException(); }


public new void RemoveListener(VoidCallback listener){ throw new NotImplementedException(); }


public new void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


public new void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


#endregion
}


public class _AlwaysDismissedAnimation : FlutterSDK.Animation.Animation.Animation<double>
{
#region constructors
public _AlwaysDismissedAnimation()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Animation.AnimationStatus Status{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void AddListener(VoidCallback listener){ throw new NotImplementedException(); }


public new void RemoveListener(VoidCallback listener){ throw new NotImplementedException(); }


public new void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


public new void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


#endregion
}


public class AlwaysStoppedAnimation<T> : FlutterSDK.Animation.Animation.Animation<T>
{
#region constructors
public AlwaysStoppedAnimation(T value)
{
this.Value = value;throw new NotImplementedException(); }
#endregion

#region fields
public new T Value{get;set;}
public virtual FlutterSDK.Animation.Animation.AnimationStatus Status{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void AddListener(VoidCallback listener){ throw new NotImplementedException(); }


public new void RemoveListener(VoidCallback listener){ throw new NotImplementedException(); }


public new void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


public new void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener){ throw new NotImplementedException(); }


public new string ToStringDetails(){ throw new NotImplementedException(); }

#endregion
}


public class ProxyAnimation : FlutterSDK.Animation.Animation.Animation<double>,IAnimationLazyListenerMixin,IAnimationLocalListenersMixin,IAnimationLocalStatusListenersMixin
{
#region constructors
public ProxyAnimation(FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>))
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Animation.Animation.AnimationStatus _Status{get;set;}
internal virtual double _Value{get;set;}
internal virtual FlutterSDK.Animation.Animation.Animation<double> _Parent{get;set;}
public virtual FlutterSDK.Animation.Animation.Animation<double> Parent{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Animation.Animation.AnimationStatus Status{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void DidStartListening(){ throw new NotImplementedException(); }


public new void DidStopListening(){ throw new NotImplementedException(); }


#endregion
}


public class ReverseAnimation : FlutterSDK.Animation.Animation.Animation<double>,IAnimationLazyListenerMixin,IAnimationLocalStatusListenersMixin
{
#region constructors
public ReverseAnimation(FlutterSDK.Animation.Animation.Animation<double> parent)
: base()
{
this.Parent = parent;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Animation.Animation<double> Parent{get;set;}
public virtual FlutterSDK.Animation.Animation.AnimationStatus Status{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void AddListener(VoidCallback listener){ throw new NotImplementedException(); }


public new void RemoveListener(VoidCallback listener){ throw new NotImplementedException(); }


public new void DidStartListening(){ throw new NotImplementedException(); }


public new void DidStopListening(){ throw new NotImplementedException(); }


private void _StatusChangeHandler(FlutterSDK.Animation.Animation.AnimationStatus status){ throw new NotImplementedException(); }


private FlutterSDK.Animation.Animation.AnimationStatus _ReverseStatus(FlutterSDK.Animation.Animation.AnimationStatus status){ throw new NotImplementedException(); }


#endregion
}


public class CurvedAnimation : FlutterSDK.Animation.Animation.Animation<double>,IAnimationWithParentMixin<double>
{
#region constructors
public CurvedAnimation(FlutterSDK.Animation.Animation.Animation<double> parent = default(FlutterSDK.Animation.Animation.Animation<double>),FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve),FlutterSDK.Animation.Curves.Curve reverseCurve = default(FlutterSDK.Animation.Curves.Curve))
: base()
{
this.Parent = parent;
this.Curve = curve;
this.ReverseCurve = reverseCurve;throw new NotImplementedException(); }
#endregion

#region fields
public new FlutterSDK.Animation.Animation.Animation<double> Parent{get;set;}
public virtual FlutterSDK.Animation.Curves.Curve Curve{get;set;}
public virtual FlutterSDK.Animation.Curves.Curve ReverseCurve{get;set;}
internal virtual FlutterSDK.Animation.Animation.AnimationStatus _CurveDirection{get;set;}
internal virtual bool _UseForwardCurve{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private void _UpdateCurveDirection(FlutterSDK.Animation.Animation.AnimationStatus status){ throw new NotImplementedException(); }


#endregion
}


public class TrainHoppingAnimation : FlutterSDK.Animation.Animation.Animation<double>,IAnimationEagerListenerMixin,IAnimationLocalListenersMixin,IAnimationLocalStatusListenersMixin
{
#region constructors
public TrainHoppingAnimation(FlutterSDK.Animation.Animation.Animation<double> _currentTrain,FlutterSDK.Animation.Animation.Animation<double> _nextTrain,VoidCallback onSwitchedTrain = default(VoidCallback))
: base()
{
this._CurrentTrain = _currentTrain;
this._NextTrain = _nextTrain;
this.OnSwitchedTrain = onSwitchedTrain;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Animation.Animation.Animation<double> _CurrentTrain{get;set;}
internal virtual FlutterSDK.Animation.Animation.Animation<double> _NextTrain{get;set;}
internal virtual FlutterSDK.Animation.Animations._TrainHoppingMode _Mode{get;set;}
public virtual VoidCallback OnSwitchedTrain{get;set;}
internal virtual FlutterSDK.Animation.Animation.AnimationStatus _LastStatus{get;set;}
internal virtual double _LastValue{get;set;}
public virtual FlutterSDK.Animation.Animation.Animation<double> CurrentTrain{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Animation.Animation.AnimationStatus Status{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private void _StatusChangeHandler(FlutterSDK.Animation.Animation.AnimationStatus status){ throw new NotImplementedException(); }


private void _ValueChangeHandler(){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }


#endregion
}


public class CompoundAnimation<T> : FlutterSDK.Animation.Animation.Animation<T>,IAnimationLazyListenerMixin,IAnimationLocalListenersMixin,IAnimationLocalStatusListenersMixin
{
#region constructors
public CompoundAnimation(FlutterSDK.Animation.Animation.Animation<T> first = default(FlutterSDK.Animation.Animation.Animation<T>),FlutterSDK.Animation.Animation.Animation<T> next = default(FlutterSDK.Animation.Animation.Animation<T>))
: base()
{
this.First = first;
this.Next = next;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Animation.Animation<T> First{get;set;}
public virtual FlutterSDK.Animation.Animation.Animation<T> Next{get;set;}
internal virtual FlutterSDK.Animation.Animation.AnimationStatus _LastStatus{get;set;}
internal virtual T _LastValue{get;set;}
public virtual FlutterSDK.Animation.Animation.AnimationStatus Status{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void DidStartListening(){ throw new NotImplementedException(); }


public new void DidStopListening(){ throw new NotImplementedException(); }



private void _MaybeNotifyStatusListeners(FlutterSDK.Animation.Animation.AnimationStatus _){ throw new NotImplementedException(); }


private void _MaybeNotifyListeners(){ throw new NotImplementedException(); }

#endregion
}


public class AnimationMean : FlutterSDK.Animation.Animations.CompoundAnimation<double>
{
#region constructors
public AnimationMean(FlutterSDK.Animation.Animation.Animation<double> left = default(FlutterSDK.Animation.Animation.Animation<double>),FlutterSDK.Animation.Animation.Animation<double> right = default(FlutterSDK.Animation.Animation.Animation<double>))
: base(first:left,next:right)
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual double Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods
#endregion
}


public class AnimationMax<T> : FlutterSDK.Animation.Animations.CompoundAnimation<T>
{
#region constructors
public AnimationMax(FlutterSDK.Animation.Animation.Animation<T> first,FlutterSDK.Animation.Animation.Animation<T> next)
: base(first:first,next:next)
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual T Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods
#endregion
}


public class AnimationMin<T> : FlutterSDK.Animation.Animations.CompoundAnimation<T>
{
#region constructors
public AnimationMin(FlutterSDK.Animation.Animation.Animation<T> first,FlutterSDK.Animation.Animation.Animation<T> next)
: base(first:first,next:next)
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual T Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods
#endregion
}


public enum _TrainHoppingMode{

Minimize,
Maximize,
}

}
