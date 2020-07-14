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
namespace FlutterSDK.Animation.Tween
{
    internal static class TweenDefaultClass
    {
    }

    /// <Summary>
    /// An object that can produce a value of type `T` given an [Animation<double>]
    /// as input.
    ///
    /// Typically, the values of the input animation are nominally in the range 0.0
    /// to 1.0. In principle, however, any value could be provided.
    ///
    /// The main subclass of [Animatable] is [Tween].
    /// </Summary>
    public interface IAnimatable<T>
    {
        T Transform(double t);
        T Evaluate(FlutterSDK.Animation.Animation.Animation<double> animation);
        Animation<T> Animate(FlutterSDK.Animation.Animation.Animation<double> parent);
        Animatable<T> Chain(FlutterSDK.Animation.Tween.Animatable<double> parent);
    }


    /// <Summary>
    /// An object that can produce a value of type `T` given an [Animation<double>]
    /// as input.
    ///
    /// Typically, the values of the input animation are nominally in the range 0.0
    /// to 1.0. In principle, however, any value could be provided.
    ///
    /// The main subclass of [Animatable] is [Tween].
    /// </Summary>
    public class Animatable<T>
    {
        #region constructors
        public Animatable()
    
}
    #endregion

    #region fields
    #endregion

    #region methods

    /// <Summary>
    /// Returns the value of the object at point `t`.
    ///
    /// The value of `t` is nominally a fraction in the range 0.0 to 1.0, though
    /// in practice it may extend outside this range.
    ///
    /// See also:
    ///
    ///  * [evaluate], which is a shorthand for applying [transform] to the value
    ///    of an [Animation].
    ///  * [Curve.transform], a similar method for easing curves.
    /// </Summary>
    public virtual T Transform(double t)
    {
        return default(T);
    }


    /// <Summary>
    /// The current value of this object for the given [Animation].
    ///
    /// This function is implemented by deferring to [transform]. Subclasses that
    /// want to provide custom behavior should override [transform], not
    /// [evaluate].
    ///
    /// See also:
    ///
    ///  * [transform], which is similar but takes a `t` value directly instead of
    ///    an [Animation].
    ///  * [animate], which creates an [Animation] out of this object, continually
    ///    applying [evaluate].
    /// </Summary>
    public virtual T Evaluate(FlutterSDK.Animation.Animation.Animation<double> animation) => Transform(animation.Value);



    /// <Summary>
    /// Returns a new [Animation] that is driven by the given animation but that
    /// takes on values determined by this object.
    ///
    /// Essentially this returns an [Animation] that automatically applies the
    /// [evaluate] method to the parent's value.
    ///
    /// See also:
    ///
    ///  * [AnimationController.drive], which does the same thing from the
    ///    opposite starting point.
    /// </Summary>
    public virtual Animation<T> Animate(FlutterSDK.Animation.Animation.Animation<double> parent)
    {
        return new _AnimatedEvaluation<T>(parent, this);
    }




    /// <Summary>
    /// Returns a new [Animatable] whose value is determined by first evaluating
    /// the given parent and then evaluating this object.
    ///
    /// This allows [Tween]s to be chained before obtaining an [Animation].
    /// </Summary>
    public virtual Animatable<T> Chain(FlutterSDK.Animation.Tween.Animatable<double> parent)
    {
        return new _ChainedEvaluation<T>(parent, this);
    }



    #endregion
}


public class _AnimatedEvaluation<T> : FlutterSDK.Animation.Animation.Animation<T>, IAnimationWithParentMixin<double>
{
    #region constructors
    public _AnimatedEvaluation(FlutterSDK.Animation.Animation.Animation<double> parent, FlutterSDK.Animation.Tween.Animatable<T> _evaluatable)

}
#endregion

#region fields
public new FlutterSDK.Animation.Animation.Animation<double> Parent { get; set; }
internal virtual FlutterSDK.Animation.Tween.Animatable<T> _Evaluatable { get; set; }
public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods


public new string ToStringDetails()
{
    return $"'{base.ToStringDetails()} {_Evaluatable}'";
}



#endregion
}


public class _ChainedEvaluation<T> : FlutterSDK.Animation.Tween.Animatable<T>
{
    #region constructors
    public _ChainedEvaluation(FlutterSDK.Animation.Tween.Animatable<double> _parent, FlutterSDK.Animation.Tween.Animatable<T> _evaluatable)

}
#endregion

#region fields
internal virtual FlutterSDK.Animation.Tween.Animatable<double> _Parent { get; set; }
internal virtual FlutterSDK.Animation.Tween.Animatable<T> _Evaluatable { get; set; }
#endregion

#region methods

public new T Transform(double t)
{
    return _Evaluatable.Transform(_Parent.Transform(t));
}




#endregion
}


/// <Summary>
/// A linear interpolation between a beginning and ending value.
///
/// [Tween] is useful if you want to interpolate across a range.
///
/// To use a [Tween] object with an animation, call the [Tween] object's
/// [animate] method and pass it the [Animation] object that you want to
/// modify.
///
/// You can chain [Tween] objects together using the [chain] method, so that a
/// single [Animation] object is configured by multiple [Tween] objects called
/// in succession. This is different than calling the [animate] method twice,
/// which results in two separate [Animation] objects, each configured with a
/// single [Tween].
///
/// {@tool snippet}
///
/// Suppose `_controller` is an [AnimationController], and we want to create an
/// [Animation<Offset>] that is controlled by that controller, and save it in
/// `_animation`. Here are two possible ways of expressing this:
///
/// ```dart
/// _animation = _controller.drive(
///   Tween<Offset>(
///     begin: const Offset(100.0, 50.0),
///     end: const Offset(200.0, 300.0),
///   ),
/// );
/// ```
/// {@end-tool}
/// {@tool snippet}
///
/// ```dart
/// _animation = Tween<Offset>(
///   begin: const Offset(100.0, 50.0),
///   end: const Offset(200.0, 300.0),
/// ).animate(_controller);
/// ```
/// {@end-tool}
///
/// In both cases, the `_animation` variable holds an object that, over the
/// lifetime of the `_controller`'s animation, returns a value
/// (`_animation.value`) that depicts a point along the line between the two
/// offsets above. If we used a [MaterialPointArcTween] instead of a
/// [Tween<Offset>] in the code above, the points would follow a pleasing curve
/// instead of a straight line, with no other changes necessary.
///
/// ## Performance optimizations
///
/// Tweens are mutable; specifically, their [begin] and [end] values can be
/// changed at runtime. An object created with [Animation.drive] using a [Tween]
/// will immediately honor changes to that underlying [Tween] (though the
/// listeners will only be triggered if the [Animation] is actively animating).
/// This can be used to change an animation on the fly without having to
/// recreate all the objects in the chain from the [AnimationController] to the
/// final [Tween].
///
/// If a [Tween]'s values are never changed, however, a further optimization can
/// be applied: the object can be stored in a `static final` variable, so that
/// the exact same instance is used whenever the [Tween] is needed. This is
/// preferable to creating an identical [Tween] afresh each time a [State.build]
/// method is called, for example.
///
/// ## Types with special considerations
///
/// Classes with [lerp] static methods typically have corresponding dedicated
/// [Tween] subclasses that call that method. For example, [ColorTween] uses
/// [Color.lerp] to implement the [ColorTween.lerp] method.
///
/// Types that define `+` and `-` operators to combine values (`T + T → T` and
/// `T - T → T`) and an `*` operator to scale by multiplying with a double (`T *
/// double → T`) can be directly used with `Tween<T>`.
///
/// This does not extend to any type with `+`, `-`, and `*` operators. In
/// particular, [int] does not satisfy this precise contract (`int * double`
/// actually returns [num], not [int]). There are therefore two specific classes
/// that can be used to interpolate integers:
///
///  * [IntTween], which is an approximation of a linear interpolation (using
///    [double.round]).
///  * [StepTween], which uses [double.floor] to ensure that the result is
///    never greater than it would be using if a `Tween<double>`.
///
/// The relevant operators on [Size] also don't fulfill this contract, so
/// [SizeTween] uses [Size.lerp].
///
/// In addition, some of the types that _do_ have suitable `+`, `-`, and `*`
/// operators still have dedicated [Tween] subclasses that perform the
/// interpolation in a more specialized manner. One such class is
/// [MaterialPointArcTween], which is mentioned above. The [AlignmentTween], and
/// [AlignmentGeometryTween], and [FractionalOffsetTween] are another group of
/// [Tween]s that use dedicated `lerp` methods instead of merely relying on the
/// operators (in particular, this allows them to handle null values in a more
/// useful manner).
/// </Summary>
public class Tween<T> : FlutterSDK.Animation.Tween.Animatable<T>
{
    #region constructors
    public Tween(T begin = default(T), T end = default(T))

}
#endregion

#region fields
public virtual T Begin { get; set; }
public virtual T End { get; set; }
#endregion

#region methods

/// <Summary>
/// Returns the value this variable has at the given animation clock value.
///
/// The default implementation of this method uses the [+], [-], and [*]
/// operators on `T`. The [begin] and [end] properties must therefore be
/// non-null by the time this method is called.
/// </Summary>
public virtual T Lerp(double t)
{


    return Begin + (End - Begin) * t as T;
}




/// <Summary>
/// Returns the interpolated value for the current value of the given animation.
///
/// This method returns `begin` and `end` when the animation values are 0.0 or
/// 1.0, respectively.
///
/// This function is implemented by deferring to [lerp]. Subclasses that want
/// to provide custom behavior should override [lerp], not [transform] (nor
/// [evaluate]).
///
/// See the constructor for details about whether the [begin] and [end]
/// properties may be null when this is called. It varies from subclass to
/// subclass.
/// </Summary>
public new T Transform(double t)
{
    if (t == 0.0) return Begin;
    if (t == 1.0) return End;
    return Lerp(t);
}




#endregion
}


/// <Summary>
/// A [Tween] that evaluates its [parent] in reverse.
/// </Summary>
public class ReverseTween<T> : FlutterSDK.Animation.Tween.Tween<T>
{
    #region constructors
    public ReverseTween(FlutterSDK.Animation.Tween.Tween<T> parent)
    : base(begin: parent.End, end: parent.Begin)

}
#endregion

#region fields
public virtual FlutterSDK.Animation.Tween.Tween<T> Parent { get; set; }
#endregion

#region methods

public new T Lerp(double t) => Parent.Lerp(1.0 - t);


#endregion
}


/// <Summary>
/// An interpolation between two colors.
///
/// This class specializes the interpolation of [Tween<Color>] to use
/// [Color.lerp].
///
/// See [Tween] for a discussion on how to use interpolation objects.
/// </Summary>
public class ColorTween : FlutterSDK.Animation.Tween.Tween<Color>
{
    #region constructors
    public ColorTween(FlutterBinding.UI.Color begin = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color end = default(FlutterBinding.UI.Color))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Returns the value this variable has at the given animation clock value.
/// </Summary>
public new Color Lerp(double t) => Dart:uiDefaultClass.Color.Lerp(Begin, End, t);


#endregion
}


/// <Summary>
/// An interpolation between two sizes.
///
/// This class specializes the interpolation of [Tween<Size>] to use
/// [Size.lerp].
///
/// See [Tween] for a discussion on how to use interpolation objects.
/// </Summary>
public class SizeTween : FlutterSDK.Animation.Tween.Tween<Size>
{
    #region constructors
    public SizeTween(Size begin = default(Size), Size end = default(Size))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Returns the value this variable has at the given animation clock value.
/// </Summary>
public new Size Lerp(double t) => Dart:uiDefaultClass.Size.Lerp(Begin, End, t);


#endregion
}


/// <Summary>
/// An interpolation between two rectangles.
///
/// This class specializes the interpolation of [Tween<Rect>] to use
/// [Rect.lerp].
///
/// See [Tween] for a discussion on how to use interpolation objects.
/// </Summary>
public class RectTween : FlutterSDK.Animation.Tween.Tween<Rect>
{
    #region constructors
    public RectTween(FlutterBinding.UI.Rect begin = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Rect end = default(FlutterBinding.UI.Rect))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Returns the value this variable has at the given animation clock value.
/// </Summary>
public new Rect Lerp(double t) => Dart:uiDefaultClass.Rect.Lerp(Begin, End, t);


#endregion
}


/// <Summary>
/// An interpolation between two integers that rounds.
///
/// This class specializes the interpolation of [Tween<int>] to be
/// appropriate for integers by interpolating between the given begin
/// and end values and then rounding the result to the nearest
/// integer.
///
/// This is the closest approximation to a linear tween that is possible with an
/// integer. Compare to [StepTween] and [Tween<double>].
///
/// See [Tween] for a discussion on how to use interpolation objects.
/// </Summary>
public class IntTween : FlutterSDK.Animation.Tween.Tween<int>
{
    #region constructors
    public IntTween(int begin = default(int), int end = default(int))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

public new int Lerp(double t) => (Begin + (End - Begin) * t).Round();


#endregion
}


/// <Summary>
/// An interpolation between two integers that floors.
///
/// This class specializes the interpolation of [Tween<int>] to be
/// appropriate for integers by interpolating between the given begin
/// and end values and then using [double.floor] to return the current
/// integer component, dropping the fractional component.
///
/// This results in a value that is never greater than the equivalent
/// value from a linear double interpolation. Compare to [IntTween].
///
/// See [Tween] for a discussion on how to use interpolation objects.
/// </Summary>
public class StepTween : FlutterSDK.Animation.Tween.Tween<int>
{
    #region constructors
    public StepTween(int begin = default(int), int end = default(int))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

public new int Lerp(double t) => (Begin + (End - Begin) * t).Floor();


#endregion
}


/// <Summary>
/// A tween with a constant value.
/// </Summary>
public class ConstantTween<T> : FlutterSDK.Animation.Tween.Tween<T>
{
    #region constructors
    public ConstantTween(T value)
    : base(begin: value, end: value)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// This tween doesn't interpolate, it always returns the same value.
/// </Summary>
public new T Lerp(double t) => Begin;



#endregion
}


/// <Summary>
/// Transforms the value of the given animation by the given curve.
///
/// This class differs from [CurvedAnimation] in that [CurvedAnimation] applies
/// a curve to an existing [Animation] object whereas [CurveTween] can be
/// chained with another [Tween] prior to receiving the underlying [Animation].
/// ([CurvedAnimation] also has the additional ability of having different
/// curves when the animation is going forward vs when it is going backward,
/// which can be useful in some scenarios.)
///
/// {@tool snippet}
///
/// The following code snippet shows how you can apply a curve to a linear
/// animation produced by an [AnimationController] `controller`:
///
/// ```dart
/// final Animation<double> animation = _controller.drive(
///   CurveTween(curve: Curves.ease),
/// );
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [CurvedAnimation], for an alternative way of expressing the sample above.
///  * [AnimationController], for examples of creating and disposing of an
///    [AnimationController].
/// </Summary>
public class CurveTween : FlutterSDK.Animation.Tween.Animatable<double>
{
    #region constructors
    public CurveTween(FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Animation.Curves.Curve Curve { get; set; }
#endregion

#region methods

public new double Transform(double t)
{
    if (t == 0.0 || t == 1.0)
    {

        return t;
    }

    return Curve.Transform(t);
}




#endregion
}

}
