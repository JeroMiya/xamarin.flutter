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
namespace FlutterSDK.Animation.Curves
{
    internal static class CurvesDefaultClass
    {
        internal static double _Bounce(double t)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// An abstract class providing an interface for evaluating a parametric curve.
    ///
    /// A parametric curve transforms a parameter (hence the name) `t` along a curve
    /// to the value of the curve at that value of `t`. The curve can be of
    /// arbitrary dimension, but is typically a 1D, 2D, or 3D curve.
    ///
    /// See also:
    ///
    ///  * [Curve], a 1D animation easing curve that starts at 0.0 and ends at 1.0.
    ///  * [Curve2D], a parametric curve that transforms the parameter to a 2D point.
    /// </Summary>
    public interface IParametricCurve<T>
    {
        T Transform(double t);
        T TransformInternal(double t);
        string ToString();
    }


    /// <Summary>
    /// An parametric animation easing curve, i.e. a mapping of the unit interval to
    /// the unit interval.
    ///
    /// Easing curves are used to adjust the rate of change of an animation over
    /// time, allowing them to speed up and slow down, rather than moving at a
    /// constant rate.
    ///
    /// A [Curve] must map t=0.0 to 0.0 and t=1.0 to 1.0.
    ///
    /// See also:
    ///
    ///  * [Curves], a collection of common animation easing curves.
    ///  * [CurveTween], which can be used to apply a [Curve] to an [Animation].
    ///  * [Canvas.drawArc], which draws an arc, and has nothing to do with easing
    ///    curves.
    ///  * [Animatable], for a more flexible interface that maps fractions to
    ///    arbitrary values.
    /// </Summary>
    public interface ICurve
    {
        double Transform(double t);
        FlutterSDK.Animation.Curves.Curve Flipped { get; }
    }


    /// <Summary>
    /// Abstract class that defines an API for evaluating 2D parametric curves.
    ///
    /// [Curve2D] differs from [Curve] in that the values interpolated are [Offset]
    /// values instead of [double] values, hence the "2D" in the name. They both
    /// take a single double `t` that has a range of 0.0 to 1.0, inclusive, as input
    /// to the [transform] function . Unlike [Curve], [Curve2D] is not required to
    /// map `t=0.0` and `t=1.0` to specific output values.
    ///
    /// The interpolated `t` value given to [transform] represents the progression
    /// along the curve, but it doesn't necessarily progress at a constant velocity, so
    /// incrementing `t` by, say, 0.1 might move along the curve by quite a lot at one
    /// part of the curve, or hardly at all in another part of the curve, depending
    /// on the definition of the curve.
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// This example shows how to use a [Curve2D] to modify the position of a widget
    /// so that it can follow an arbitrary path.
    ///
    /// ```dart preamble
    /// // This is the path that the child will follow. It's a CatmullRomSpline so
    /// // that the coordinates can be specified that it must pass through. If the
    /// // tension is set to 1.0, it will linearly interpolate between those points,
    /// // instead of interpolating smoothly.
    /// final CatmullRomSpline path = CatmullRomSpline(
    ///   const <Offset>[
    ///     Offset(0.05, 0.75),
    ///     Offset(0.18, 0.23),
    ///     Offset(0.32, 0.04),
    ///     Offset(0.73, 0.5),
    ///     Offset(0.42, 0.74),
    ///     Offset(0.73, 0.01),
    ///     Offset(0.93, 0.93),
    ///     Offset(0.05, 0.75),
    ///   ],
    ///   startHandle: Offset(0.93, 0.93),
    ///   endHandle: Offset(0.18, 0.23),
    ///   tension: 0.0,
    /// );
    ///
    /// class FollowCurve2D extends StatefulWidget {
    ///   const FollowCurve2D({
    ///     Key key,
    ///     @required this.path,
    ///     this.curve = Curves.easeInOut,
    ///     @required this.child,
    ///     this.duration = const Duration(seconds: 1),
    ///   })  : assert(path != null),
    ///         assert(curve != null),
    ///         assert(child != null),
    ///         assert(duration != null),
    ///         super(key: key);
    ///
    ///   final Curve2D path;
    ///   final Curve curve;
    ///   final Duration duration;
    ///   final Widget child;
    ///
    ///   @override
    ///   _FollowCurve2DState createState() => _FollowCurve2DState();
    /// }
    ///
    /// class _FollowCurve2DState extends State<FollowCurve2D> with TickerProviderStateMixin {
    ///   // The animation controller for this animation.
    ///   AnimationController controller;
    ///   // The animation that will be used to apply the widget's animation curve.
    ///   Animation<double> animation;
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     controller = AnimationController(duration: widget.duration, vsync: this);
    ///     animation = CurvedAnimation(parent: controller, curve: widget.curve);
    ///     // Have the controller repeat indefinitely.  If you want it to "bounce" back
    ///     // and forth, set the reverse parameter to true.
    ///     controller.repeat(reverse: false);
    ///     controller.addListener(() => setState(() {}));
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     super.dispose();
    ///     // Always have to dispose of animation controllers when done.
    ///     controller.dispose();
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     // Scale the path values to match the -1.0 to 1.0 domain of the Alignment widget.
    ///     final Offset position = widget.path.transform(animation.value) * 2.0 - Offset(1.0, 1.0);
    ///     return Align(
    ///       alignment: Alignment(position.dx, position.dy),
    ///       child: widget.child,
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    ///   Widget build(BuildContext context) {
    ///     return Container(
    ///       color: Colors.white,
    ///       alignment: Alignment.center,
    ///       child: FollowCurve2D(
    ///         path: path,
    ///         curve: Curves.easeInOut,
    ///         duration: const Duration(seconds: 3),
    ///         child: CircleAvatar(
    ///           backgroundColor: Colors.yellow,
    ///           child: DefaultTextStyle(
    ///             style: Theme.of(context).textTheme.headline6,
    ///             child: Text("B"), // Buzz, buzz!
    ///           ),
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// ```
    /// {@end-tool}
    ///
    /// </Summary>
    public interface ICurve2D
    {
        Iterable<FlutterSDK.Animation.Curves.Curve2DSample> GenerateSamples(double start = 0.0, double end = 1.0, double tolerance = 1e-10);
        double FindInverse(double x);
        int SamplingSeed { get; }
    }


    /// <Summary>
    /// An abstract class providing an interface for evaluating a parametric curve.
    ///
    /// A parametric curve transforms a parameter (hence the name) `t` along a curve
    /// to the value of the curve at that value of `t`. The curve can be of
    /// arbitrary dimension, but is typically a 1D, 2D, or 3D curve.
    ///
    /// See also:
    ///
    ///  * [Curve], a 1D animation easing curve that starts at 0.0 and ends at 1.0.
    ///  * [Curve2D], a parametric curve that transforms the parameter to a 2D point.
    /// </Summary>
    public class ParametricCurve<T>
    {
        #region constructors
        public ParametricCurve()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        /// <Summary>
        /// Returns the value of the curve at point `t`.
        ///
        /// This method asserts that t is between 0 and 1 before delegating to
        /// [transformInternal].
        ///
        /// It is recommended that subclasses override [transformInternal] instead of
        /// this function, as the above case is already handled in the default
        /// implementation of [transform], which delegates the remaining logic to
        /// [transformInternal].
        /// </Summary>
        public virtual T Transform(double t) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the value of the curve at point `t`.
        ///
        /// The given parametric value `t` will be between 0.0 and 1.0, inclusive.
        /// </Summary>
        public virtual T TransformInternal(double t) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// An parametric animation easing curve, i.e. a mapping of the unit interval to
    /// the unit interval.
    ///
    /// Easing curves are used to adjust the rate of change of an animation over
    /// time, allowing them to speed up and slow down, rather than moving at a
    /// constant rate.
    ///
    /// A [Curve] must map t=0.0 to 0.0 and t=1.0 to 1.0.
    ///
    /// See also:
    ///
    ///  * [Curves], a collection of common animation easing curves.
    ///  * [CurveTween], which can be used to apply a [Curve] to an [Animation].
    ///  * [Canvas.drawArc], which draws an arc, and has nothing to do with easing
    ///    curves.
    ///  * [Animatable], for a more flexible interface that maps fractions to
    ///    arbitrary values.
    /// </Summary>
    public class Curve : FlutterSDK.Animation.Curves.ParametricCurve<double>
    {
        #region constructors
        public Curve()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Animation.Curves.Curve Flipped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Returns the value of the curve at point `t`.
        ///
        /// This function must ensure the following:
        /// - The value of `t` must be between 0.0 and 1.0
        /// - Values of `t`=0.0 and `t`=1.0 must be mapped to 0.0 and 1.0,
        /// respectively.
        ///
        /// It is recommended that subclasses override [transformInternal] instead of
        /// this function, as the above cases are already handled in the default
        /// implementation of [transform], which delegates the remaining logic to
        /// [transformInternal].
        /// </Summary>
        public new double Transform(double t) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// The identity map over the unit interval.
    ///
    /// See [Curves.linear] for an instance of this class.
    /// </Summary>
    public class _Linear : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        internal _Linear()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A sawtooth curve that repeats a given number of times over the unit interval.
    ///
    /// The curve rises linearly from 0.0 to 1.0 and then falls discontinuously back
    /// to 0.0 each iteration.
    ///
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_sawtooth.mp4}
    /// </Summary>
    public class SawTooth : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        public SawTooth(int count)
        : base()
        {
            this.Count = count; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int Count { get; set; }
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// A curve that is 0.0 until [begin], then curved (according to [curve]) from
    /// 0.0 at [begin] to 1.0 at [end], then remains 1.0 past [end].
    ///
    /// An [Interval] can be used to delay an animation. For example, a six second
    /// animation that uses an [Interval] with its [begin] set to 0.5 and its [end]
    /// set to 1.0 will essentially become a three-second animation that starts
    /// three seconds later.
    ///
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_interval.mp4}
    /// </Summary>
    public class Interval : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        public Interval(double begin, double end, FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        : base()
        {
            this.Begin = begin;
            this.End = end;
            this.Curve = curve; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Begin { get; set; }
        public virtual double End { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve Curve { get; set; }
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// A curve that is 0.0 until it hits the threshold, then it jumps to 1.0.
    ///
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_threshold.mp4}
    /// </Summary>
    public class Threshold : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        public Threshold(double threshold)
        : base()
        {
            this.ThresholdValue = threshold; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double ThresholdValue { get; set; }
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A cubic polynomial mapping of the unit interval.
    ///
    /// The [Curves] class contains some commonly used cubic curves:
    ///
    ///  * [Curves.ease]
    ///  * [Curves.easeIn]
    ///  * [Curves.easeOut]
    ///  * [Curves.easeInOut]
    ///
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_out.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_out.mp4}
    ///
    /// The [Cubic] class implements third-order Bézier curves.
    ///
    /// See also:
    ///
    ///  * [Curves], where many more predefined curves are available.
    ///  * [CatmullRomCurve], a curve which passes through specific values.
    /// </Summary>
    public class Cubic : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        public Cubic(double a, double b, double c, double d)
        : base()
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double a { get; set; }
        public virtual double b { get; set; }
        public virtual double c { get; set; }
        public virtual double d { get; set; }
        internal virtual double _CubicErrorBound { get; set; }
        #endregion

        #region methods

        private double _EvaluateCubic(double a, double b, double m) { throw new NotImplementedException(); }


        public new double TransformInternal(double t) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// Abstract class that defines an API for evaluating 2D parametric curves.
    ///
    /// [Curve2D] differs from [Curve] in that the values interpolated are [Offset]
    /// values instead of [double] values, hence the "2D" in the name. They both
    /// take a single double `t` that has a range of 0.0 to 1.0, inclusive, as input
    /// to the [transform] function . Unlike [Curve], [Curve2D] is not required to
    /// map `t=0.0` and `t=1.0` to specific output values.
    ///
    /// The interpolated `t` value given to [transform] represents the progression
    /// along the curve, but it doesn't necessarily progress at a constant velocity, so
    /// incrementing `t` by, say, 0.1 might move along the curve by quite a lot at one
    /// part of the curve, or hardly at all in another part of the curve, depending
    /// on the definition of the curve.
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// This example shows how to use a [Curve2D] to modify the position of a widget
    /// so that it can follow an arbitrary path.
    ///
    /// ```dart preamble
    /// // This is the path that the child will follow. It's a CatmullRomSpline so
    /// // that the coordinates can be specified that it must pass through. If the
    /// // tension is set to 1.0, it will linearly interpolate between those points,
    /// // instead of interpolating smoothly.
    /// final CatmullRomSpline path = CatmullRomSpline(
    ///   const <Offset>[
    ///     Offset(0.05, 0.75),
    ///     Offset(0.18, 0.23),
    ///     Offset(0.32, 0.04),
    ///     Offset(0.73, 0.5),
    ///     Offset(0.42, 0.74),
    ///     Offset(0.73, 0.01),
    ///     Offset(0.93, 0.93),
    ///     Offset(0.05, 0.75),
    ///   ],
    ///   startHandle: Offset(0.93, 0.93),
    ///   endHandle: Offset(0.18, 0.23),
    ///   tension: 0.0,
    /// );
    ///
    /// class FollowCurve2D extends StatefulWidget {
    ///   const FollowCurve2D({
    ///     Key key,
    ///     @required this.path,
    ///     this.curve = Curves.easeInOut,
    ///     @required this.child,
    ///     this.duration = const Duration(seconds: 1),
    ///   })  : assert(path != null),
    ///         assert(curve != null),
    ///         assert(child != null),
    ///         assert(duration != null),
    ///         super(key: key);
    ///
    ///   final Curve2D path;
    ///   final Curve curve;
    ///   final Duration duration;
    ///   final Widget child;
    ///
    ///   @override
    ///   _FollowCurve2DState createState() => _FollowCurve2DState();
    /// }
    ///
    /// class _FollowCurve2DState extends State<FollowCurve2D> with TickerProviderStateMixin {
    ///   // The animation controller for this animation.
    ///   AnimationController controller;
    ///   // The animation that will be used to apply the widget's animation curve.
    ///   Animation<double> animation;
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     controller = AnimationController(duration: widget.duration, vsync: this);
    ///     animation = CurvedAnimation(parent: controller, curve: widget.curve);
    ///     // Have the controller repeat indefinitely.  If you want it to "bounce" back
    ///     // and forth, set the reverse parameter to true.
    ///     controller.repeat(reverse: false);
    ///     controller.addListener(() => setState(() {}));
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     super.dispose();
    ///     // Always have to dispose of animation controllers when done.
    ///     controller.dispose();
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     // Scale the path values to match the -1.0 to 1.0 domain of the Alignment widget.
    ///     final Offset position = widget.path.transform(animation.value) * 2.0 - Offset(1.0, 1.0);
    ///     return Align(
    ///       alignment: Alignment(position.dx, position.dy),
    ///       child: widget.child,
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    ///   Widget build(BuildContext context) {
    ///     return Container(
    ///       color: Colors.white,
    ///       alignment: Alignment.center,
    ///       child: FollowCurve2D(
    ///         path: path,
    ///         curve: Curves.easeInOut,
    ///         duration: const Duration(seconds: 3),
    ///         child: CircleAvatar(
    ///           backgroundColor: Colors.yellow,
    ///           child: DefaultTextStyle(
    ///             style: Theme.of(context).textTheme.headline6,
    ///             child: Text("B"), // Buzz, buzz!
    ///           ),
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// ```
    /// {@end-tool}
    ///
    /// </Summary>
    public class Curve2D : FlutterSDK.Animation.Curves.ParametricCurve<Offset>
    {
        #region constructors
        public Curve2D()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int SamplingSeed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Generates a list of samples with a recursive subdivision until a tolerance
        /// of `tolerance` is reached.
        ///
        /// Samples are generated in order.
        ///
        /// Samples can be used to render a curve efficiently, since the samples
        /// constitute line segments which vary in size with the curvature of the
        /// curve. They can also be used to quickly approximate the value of the curve
        /// by searching for the desired range in X and linearly interpolating between
        /// samples to obtain an approximation of Y at the desired X value. The
        /// implementation of [CatmullRomCurve] uses samples for this purpose
        /// internally.
        ///
        /// The tolerance is computed as the area of a triangle formed by a new point
        /// and the preceding and following point.
        ///
        /// See also:
        ///
        ///  * Luiz Henrique de Figueire's Graphics Gem on [the algorithm](http://ariel.chronotext.org/dd/defigueiredo93adaptive.pdf).
        /// </Summary>
        public virtual Iterable<FlutterSDK.Animation.Curves.Curve2DSample> GenerateSamples(double start = 0.0, double end = 1.0, double tolerance = 1e-10) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the parameter `t` that corresponds to the given x value of the spline.
        ///
        /// This will only work properly for curves which are single-valued in x
        /// (where every value of `x` maps to only one value in 'y', i.e. the curve
        /// does not loop or curve back over itself). For curves that are not
        /// single-valued, it will return the parameter for only one of the values at
        /// the given `x` location.
        /// </Summary>
        public virtual double FindInverse(double x) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A class that holds a sample of a 2D parametric curve, containing the [value]
    /// (the X, Y coordinates) of the curve at the parametric value [t].
    ///
    /// See also:
    ///
    ///  * [Curve2D.generateSamples], which generates samples of this type.
    ///  * [Curve2D], a parametric curve that maps a double parameter to a 2D location.
    /// </Summary>
    public class Curve2DSample
    {
        #region constructors
        public Curve2DSample(double t, FlutterBinding.UI.Offset value)
        : base()
        {
            this.t = t;
            this.Value = value; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double t { get; set; }
        public virtual FlutterBinding.UI.Offset Value { get; set; }
        #endregion

        #region methods

        #endregion
    }


    /// <Summary>
    /// A 2D spline that passes smoothly through the given control points using a
    /// centripetal Catmull-Rom spline.
    ///
    /// When the curve is evaluated with [transform], the output values will move
    /// smoothly from one control point to the next, passing through the control
    /// points.
    ///
    /// {@template flutter.animation.curves.catmull_rom_description}
    /// Unlike most cubic splines, Catmull-Rom splines have the advantage that their
    /// curves pass through the control points given to them. They are cubic
    /// polynomial representations, and, in fact, Catmull-Rom splines can be
    /// converted mathematically into cubic splines. This class implements a
    /// "centripetal" Catmull-Rom spline. The term centripetal implies that it won't
    /// form loops or self-intersections within a single segment.
    /// {@endtemplate}
    ///
    /// See also:
    ///  * [Centripetal Catmull–Rom splines](https://en.wikipedia.org/wiki/Centripetal_Catmull%E2%80%93Rom_spline)
    ///    on Wikipedia.
    ///  * [Parameterization and Applications of Catmull-Rom Curves](http://faculty.cs.tamu.edu/schaefer/research/cr_cad.pdf),
    ///    a paper on using Catmull-Rom splines.
    ///  * [CatmullRomCurve], an animation curve that uses a [CatmullRomSpline] as its
    ///    internal representation.
    /// </Summary>
    public class CatmullRomSpline : FlutterSDK.Animation.Curves.Curve2D
    {
        #region constructors
        public CatmullRomSpline(List<FlutterBinding.UI.Offset> controlPoints, double tension = 0.0, FlutterBinding.UI.Offset startHandle = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endHandle = default(FlutterBinding.UI.Offset))
        : base()
        {
            throw new NotImplementedException();
        }
        public static CatmullRomSpline Precompute(List<FlutterBinding.UI.Offset> controlPoints, double tension = 0.0, FlutterBinding.UI.Offset startHandle = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endHandle = default(FlutterBinding.UI.Offset))
        {
            var instance = new CatmullRomSpline(); throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual List<List<Offset>> _CubicSegments { get; set; }
        internal virtual List<Offset> _ControlPoints { get; set; }
        internal virtual FlutterBinding.UI.Offset _StartHandle { get; set; }
        internal virtual FlutterBinding.UI.Offset _EndHandle { get; set; }
        internal virtual double _Tension { get; set; }
        public virtual int SamplingSeed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private List<List<Offset>> _ComputeSegments(List<FlutterBinding.UI.Offset> controlPoints, double tension, FlutterBinding.UI.Offset startHandle = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset endHandle = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        private void _InitializeIfNeeded() { throw new NotImplementedException(); }


        public new Offset TransformInternal(double t) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An animation easing curve that passes smoothly through the given control
    /// points using a centripetal Catmull-Rom spline.
    ///
    /// When this curve is evaluated with [transform], the values will interpolate
    /// smoothly from one control point to the next, passing through (0.0, 0.0), the
    /// given points, and then (1.0, 1.0).
    ///
    /// {@macro flutter.animation.curves.catmull_rom_description}
    ///
    /// This class uses a centripetal Catmull-Rom curve (a [CatmullRomSpline]) as
    /// its internal representation. The term centripetal implies that it won't form
    /// loops or self-intersections within a single segment, and corresponds to a
    /// Catmull-Rom α (alpha) value of 0.5.
    ///
    /// See also:
    ///
    ///  * [CatmullRomSpline], the 2D spline that this curve uses to generate its values.
    ///  * A Wikipedia article on [centripetal Catmull-Rom splines](https://en.wikipedia.org/wiki/Centripetal_Catmull%E2%80%93Rom_spline).
    ///  * [new CatmullRomCurve] for a description of the constraints put on the
    ///    input control points.
    ///  * This [paper on using Catmull-Rom splines](http://faculty.cs.tamu.edu/schaefer/research/cr_cad.pdf).
    /// </Summary>
    public class CatmullRomCurve : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        public CatmullRomCurve(List<FlutterBinding.UI.Offset> controlPoints, double tension = 0.0)
        : base()
        {
            this.ControlPoints = controlPoints;
            this.Tension = tension; throw new NotImplementedException();
        }
        public static CatmullRomCurve Precompute(List<FlutterBinding.UI.Offset> controlPoints, double tension = 0.0)
        {
            var instance = new CatmullRomCurve(); instance.ControlPoints = controlPoints;
            instance.Tension = tension; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual List<string> _DebugAssertReasons { get; set; }
        internal virtual List<FlutterSDK.Animation.Curves.Curve2DSample> _PrecomputedSamples { get; set; }
        public virtual List<Offset> ControlPoints { get; set; }
        public virtual double Tension { get; set; }
        #endregion

        #region methods

        private List<FlutterSDK.Animation.Curves.Curve2DSample> _ComputeSamples(List<FlutterBinding.UI.Offset> controlPoints, double tension) { throw new NotImplementedException(); }


        /// <Summary>
        /// Validates that a given set of control points for a [CatmullRomCurve] is
        /// well-formed and will not produce a spline that self-intersects.
        ///
        /// This method is also used in debug mode to validate a curve to make sure
        /// that it won't violate the contract for the [new CatmullRomCurve]
        /// constructor.
        ///
        /// If in debug mode, and `reasons` is non-null, this function will fill in
        /// `reasons` with descriptions of the problems encountered. The `reasons`
        /// argument is ignored in release mode.
        ///
        /// In release mode, this function can be used to decide if a proposed
        /// modification to the curve will result in a valid curve.
        /// </Summary>
        public virtual bool ValidateControlPoints(List<FlutterBinding.UI.Offset> controlPoints, double tension = 0.0, List<string> reasons = default(List<string>)) { throw new NotImplementedException(); }


        public new double TransformInternal(double t) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A curve that is the reversed inversion of its given curve.
    ///
    /// This curve evaluates the given curve in reverse (i.e., from 1.0 to 0.0 as t
    /// increases from 0.0 to 1.0) and returns the inverse of the given curve's
    /// value (i.e., 1.0 minus the given curve's value).
    ///
    /// This is the class used to implement the [flipped] getter on curves.
    ///
    /// This is often useful with [CurvedAnimation.reverseCurve].
    ///
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_bounce_in.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_flipped.mp4}
    ///
    /// See also:
    ///
    ///  * [Curve.flipped], which provides the [FlippedCurve] of a [Curve].
    ///  * [ReverseAnimation], which reverses an [Animation] rather than a [Curve].
    ///  * [CurvedAnimation], which can take a separate curve and reverse curve.
    /// </Summary>
    public class FlippedCurve : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        public FlippedCurve(FlutterSDK.Animation.Curves.Curve curve)
        : base()
        {
            this.Curve = curve; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Animation.Curves.Curve Curve { get; set; }
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// A curve where the rate of change starts out quickly and then decelerates; an
    /// upside-down `f(t) = t²` parabola.
    ///
    /// This is equivalent to the Android `DecelerateInterpolator` class with a unit
    /// factor (the default factor).
    ///
    /// See [Curves.decelerate] for an instance of this class.
    /// </Summary>
    public class _DecelerateCurve : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        internal _DecelerateCurve()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An oscillating curve that grows in magnitude.
    ///
    /// See [Curves.bounceIn] for an instance of this class.
    /// </Summary>
    public class _BounceInCurve : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        internal _BounceInCurve()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An oscillating curve that shrink in magnitude.
    ///
    /// See [Curves.bounceOut] for an instance of this class.
    /// </Summary>
    public class _BounceOutCurve : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        internal _BounceOutCurve()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An oscillating curve that first grows and then shrink in magnitude.
    ///
    /// See [Curves.bounceInOut] for an instance of this class.
    /// </Summary>
    public class _BounceInOutCurve : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        internal _BounceInOutCurve()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An oscillating curve that grows in magnitude while overshooting its bounds.
    ///
    /// An instance of this class using the default period of 0.4 is available as
    /// [Curves.elasticIn].
    ///
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_elastic_in.mp4}
    /// </Summary>
    public class ElasticInCurve : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        public ElasticInCurve(double period = 0.4)
        {
            this.Period = period; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Period { get; set; }
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// An oscillating curve that shrinks in magnitude while overshooting its bounds.
    ///
    /// An instance of this class using the default period of 0.4 is available as
    /// [Curves.elasticOut].
    ///
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_elastic_out.mp4}
    /// </Summary>
    public class ElasticOutCurve : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        public ElasticOutCurve(double period = 0.4)
        {
            this.Period = period; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Period { get; set; }
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// An oscillating curve that grows and then shrinks in magnitude while
    /// overshooting its bounds.
    ///
    /// An instance of this class using the default period of 0.4 is available as
    /// [Curves.elasticInOut].
    ///
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_elastic_in_out.mp4}
    /// </Summary>
    public class ElasticInOutCurve : FlutterSDK.Animation.Curves.Curve
    {
        #region constructors
        public ElasticInOutCurve(double period = 0.4)
        {
            this.Period = period; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Period { get; set; }
        #endregion

        #region methods

        public new double TransformInternal(double t) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// A collection of common animation curves.
    ///
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_bounce_in.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_bounce_in_out.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_bounce_out.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_decelerate.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_sine.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_quad.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_cubic.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_quart.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_quint.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_expo.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_circ.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_back.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_out.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_out_sine.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_out_quad.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_out_cubic.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_out_quart.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_out_quint.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_out_expo.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_out_circ.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_in_out_back.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_out.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_out_sine.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_out_quad.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_out_cubic.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_out_quart.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_out_quint.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_out_expo.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_out_circ.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_ease_out_back.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_elastic_in.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_elastic_in_out.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_elastic_out.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_fast_out_slow_in.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_slow_middle.mp4}
    /// {@animation 464 192 https://flutter.github.io/assets-for-api-docs/assets/animation/curve_linear.mp4}
    ///
    /// See also:
    ///
    ///  * [Curve], the interface implemented by the constants available from the
    ///    [Curves] class.
    /// </Summary>
    public class Curves
    {
        #region constructors
        internal Curves()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Animation.Curves.Curve Linear { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve Decelerate { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic FastLinearToSlowEaseIn { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic Ease { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseIn { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInToLinear { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInSine { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInQuad { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInCubic { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInQuart { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInQuint { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInExpo { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInCirc { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInBack { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseOut { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic LinearToEaseOut { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseOutSine { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseOutQuad { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseOutCubic { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseOutQuart { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseOutQuint { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseOutExpo { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseOutCirc { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseOutBack { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInOut { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutSine { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutQuad { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutCubic { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutQuart { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutQuint { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutExpo { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutCirc { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic EaseInOutBack { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic FastOutSlowIn { get; set; }
        public virtual FlutterSDK.Animation.Curves.Cubic SlowMiddle { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve BounceIn { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve BounceOut { get; set; }
        public virtual FlutterSDK.Animation.Curves.Curve BounceInOut { get; set; }
        public virtual FlutterSDK.Animation.Curves.ElasticInCurve ElasticIn { get; set; }
        public virtual FlutterSDK.Animation.Curves.ElasticOutCurve ElasticOut { get; set; }
        public virtual FlutterSDK.Animation.Curves.ElasticInOutCurve ElasticInOut { get; set; }
        #endregion

        #region methods
        #endregion
    }

}
