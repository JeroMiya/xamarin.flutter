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
namespace FlutterSDK.Animation.Animationcontroller
{
    public delegate void _DirectionSetter(FlutterSDK.Animation.Animationcontroller._AnimationDirection direction);
    internal static class AnimationcontrollerDefaultClass
    {
        public static FlutterSDK.Physics.Springsimulation.SpringDescription _KFlingSpringDescription = default(FlutterSDK.Physics.Springsimulation.SpringDescription);
        public static FlutterSDK.Physics.Tolerance.Tolerance _KFlingTolerance = default(FlutterSDK.Physics.Tolerance.Tolerance);
    }

    /// <Summary>
    /// A controller for an animation.
    ///
    /// This class lets you perform tasks such as:
    ///
    /// * Play an animation [forward] or in [reverse], or [stop] an animation.
    /// * Set the animation to a specific [value].
    /// * Define the [upperBound] and [lowerBound] values of an animation.
    /// * Create a [fling] animation effect using a physics simulation.
    ///
    /// By default, an [AnimationController] linearly produces values that range
    /// from 0.0 to 1.0, during a given duration. The animation controller generates
    /// a new value whenever the device running your app is ready to display a new
    /// frame (typically, this rate is around 60 values per second).
    ///
    /// ## Ticker providers
    ///
    /// An [AnimationController] needs a [TickerProvider], which is configured using
    /// the `vsync` argument on the constructor.
    ///
    /// The [TickerProvider] interface describes a factory for [Ticker] objects. A
    /// [Ticker] is an object that knows how to register itself with the
    /// [SchedulerBinding] and fires a callback every frame. The
    /// [AnimationController] class uses a [Ticker] to step through the animation
    /// that it controls.
    ///
    /// If an [AnimationController] is being created from a [State], then the State
    /// can use the [TickerProviderStateMixin] and [SingleTickerProviderStateMixin]
    /// classes to implement the [TickerProvider] interface. The
    /// [TickerProviderStateMixin] class always works for this purpose; the
    /// [SingleTickerProviderStateMixin] is slightly more efficient in the case of
    /// the class only ever needing one [Ticker] (e.g. if the class creates only a
    /// single [AnimationController] during its entire lifetime).
    ///
    /// The widget test framework [WidgetTester] object can be used as a ticker
    /// provider in the context of tests. In other contexts, you will have to either
    /// pass a [TickerProvider] from a higher level (e.g. indirectly from a [State]
    /// that mixes in [TickerProviderStateMixin]), or create a custom
    /// [TickerProvider] subclass.
    ///
    /// ## Life cycle
    ///
    /// An [AnimationController] should be [dispose]d when it is no longer needed.
    /// This reduces the likelihood of leaks. When used with a [StatefulWidget], it
    /// is common for an [AnimationController] to be created in the
    /// [State.initState] method and then disposed in the [State.dispose] method.
    ///
    /// ## Using [Future]s with [AnimationController]
    ///
    /// The methods that start animations return a [TickerFuture] object which
    /// completes when the animation completes successfully, and never throws an
    /// error; if the animation is canceled, the future never completes. This object
    /// also has a [TickerFuture.orCancel] property which returns a future that
    /// completes when the animation completes successfully, and completes with an
    /// error when the animation is aborted.
    ///
    /// This can be used to write code such as the `fadeOutAndUpdateState` method
    /// below.
    ///
    /// {@tool snippet}
    ///
    /// Here is a stateful `Foo` widget. Its [State] uses the
    /// [SingleTickerProviderStateMixin] to implement the necessary
    /// [TickerProvider], creating its controller in the [State.initState] method
    /// and disposing of it in the [State.dispose] method. The duration of the
    /// controller is configured from a property in the `Foo` widget; as that
    /// changes, the [State.didUpdateWidget] method is used to update the
    /// controller.
    ///
    /// ```dart
    /// class Foo extends StatefulWidget {
    ///   Foo({ Key key, this.duration }) : super(key: key);
    ///
    ///   final Duration duration;
    ///
    ///   @override
    ///   _FooState createState() => _FooState();
    /// }
    ///
    /// class _FooState extends State<Foo> with SingleTickerProviderStateMixin {
    ///   AnimationController _controller;
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     _controller = AnimationController(
    ///       vsync: this, // the SingleTickerProviderStateMixin
    ///       duration: widget.duration,
    ///     );
    ///   }
    ///
    ///   @override
    ///   void didUpdateWidget(Foo oldWidget) {
    ///     super.didUpdateWidget(oldWidget);
    ///     _controller.duration = widget.duration;
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     _controller.dispose();
    ///     super.dispose();
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Container(); // ...
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// The following method (for a [State] subclass) drives two animation
    /// controllers using Dart's asynchronous syntax for awaiting [Future] objects:
    ///
    /// ```dart
    /// Future<void> fadeOutAndUpdateState() async {
    ///   try {
    ///     await fadeAnimationController.forward().orCancel;
    ///     await sizeAnimationController.forward().orCancel;
    ///     setState(() {
    ///       dismissed = true;
    ///     });
    ///   } on TickerCanceled {
    ///     // the animation got canceled, probably because we were disposed
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// The assumption in the code above is that the animation controllers are being
    /// disposed in the [State] subclass' override of the [State.dispose] method.
    /// Since disposing the controller cancels the animation (raising a
    /// [TickerCanceled] exception), the code here can skip verifying whether
    /// [State.mounted] is still true at each step. (Again, this assumes that the
    /// controllers are created in [State.initState] and disposed in
    /// [State.dispose], as described in the previous section.)
    ///
    /// See also:
    ///
    ///  * [Tween], the base class for converting an [AnimationController] to a
    ///    range of values of other types.
    /// </Summary>
    public class AnimationController : FlutterSDK.Animation.Animation.Animation<double>, IAnimationEagerListenerMixin, IAnimationLocalListenersMixin, IAnimationLocalStatusListenersMixin
    {
        public AnimationController(double value = default(double), TimeSpan duration = default(TimeSpan), TimeSpan reverseDuration = default(TimeSpan), string debugLabel = default(string), double lowerBound = 0.0, double upperBound = 1.0, FlutterSDK.Animation.Animationcontroller.AnimationBehavior animationBehavior = default(FlutterSDK.Animation.Animationcontroller.AnimationBehavior), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider))
        : base()
        {
            this.Duration = duration;
            this.ReverseDuration = reverseDuration;
            this.DebugLabel = debugLabel;
            this.LowerBound = lowerBound;
            this.UpperBound = upperBound;
            this.AnimationBehavior = animationBehavior;
            _Ticker = vsync.CreateTicker(_Tick);
            _InternalSetValue(value == default(double) ? lowerBound : value);
        }


        public static AnimationController Unbounded(double value = 0.0, TimeSpan duration = default(TimeSpan), TimeSpan reverseDuration = default(TimeSpan), string debugLabel = default(string), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), FlutterSDK.Animation.Animationcontroller.AnimationBehavior animationBehavior = default(FlutterSDK.Animation.Animationcontroller.AnimationBehavior))
        {
            var instance = new AnimationController(); instance.Duration = duration;
            instance.ReverseDuration = reverseDuration;
            instance.DebugLabel = debugLabel;
            instance.AnimationBehavior = animationBehavior;
            _Ticker = vsync.CreateTicker(_Tick);
            _InternalSetValue(value);
        }


        public virtual double LowerBound { get; set; }
        public virtual double UpperBound { get; set; }
        public virtual string DebugLabel { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationBehavior AnimationBehavior { get; set; }
        public virtual TimeSpan Duration { get; set; }
        public virtual TimeSpan ReverseDuration { get; set; }
        internal virtual FlutterSDK.Scheduler.Ticker.Ticker _Ticker { get; set; }
        internal virtual FlutterSDK.Physics.Simulation.Simulation _Simulation { get; set; }
        internal virtual double _Value { get; set; }
        internal virtual TimeSpan _LastElapsedDuration { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller._AnimationDirection _Direction { get; set; }
        internal virtual FlutterSDK.Animation.Animation.AnimationStatus _Status { get; set; }
        internal virtual FlutterSDK.Animation.Animation.AnimationStatus _LastReportedStatus { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> View { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Velocity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan LastElapsedDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsAnimating { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.AnimationStatus Status { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Recreates the [Ticker] with the new [TickerProvider].
        /// </Summary>
        public virtual void Resync(FlutterSDK.Scheduler.Ticker.TickerProvider vsync)
        {
            Ticker oldTicker = _Ticker;
            _Ticker = vsync.CreateTicker(_Tick);
            _Ticker.AbsorbTicker(oldTicker);
        }




        /// <Summary>
        /// Sets the controller's value to [lowerBound], stopping the animation (if
        /// in progress), and resetting to its beginning point, or dismissed state.
        ///
        /// The most recently returned [TickerFuture], if any, is marked as having been
        /// canceled, meaning the future never completes and its [TickerFuture.orCancel]
        /// derivative future completes with a [TickerCanceled] error.
        ///
        /// See also:
        ///
        ///  * [value], which can be explicitly set to a specific value as desired.
        ///  * [forward], which starts the animation in the forward direction.
        ///  * [stop], which aborts the animation without changing its value or status
        ///    and without dispatching any notifications other than completing or
        ///    canceling the [TickerFuture].
        /// </Summary>
        public virtual void Reset()
        {
            Value = LowerBound;
        }




        private void _InternalSetValue(double newValue)
        {
            _Value = newValue.Clamp(LowerBound, UpperBound) as double;
            if (_Value == LowerBound)
            {
                _Status = AnimationStatus.Dismissed;
            }
            else if (_Value == UpperBound)
            {
                _Status = AnimationStatus.Completed;
            }
            else
            {
                _Status = (_Direction == _AnimationDirection.Forward) ? AnimationStatus.Forward : AnimationStatus.Reverse;
            }

        }




        /// <Summary>
        /// Starts running this animation forwards (towards the end).
        ///
        /// Returns a [TickerFuture] that completes when the animation is complete.
        ///
        /// The most recently returned [TickerFuture], if any, is marked as having been
        /// canceled, meaning the future never completes and its [TickerFuture.orCancel]
        /// derivative future completes with a [TickerCanceled] error.
        ///
        /// During the animation, [status] is reported as [AnimationStatus.forward],
        /// which switches to [AnimationStatus.completed] when [upperBound] is
        /// reached at the end of the animation.
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.TickerFuture Forward(double from = default(double))
        {


            _Direction = _AnimationDirection.Forward;
            if (from != null) Value = from;
            return _AnimateToInternal(UpperBound);
        }




        /// <Summary>
        /// Starts running this animation in reverse (towards the beginning).
        ///
        /// Returns a [TickerFuture] that completes when the animation is dismissed.
        ///
        /// The most recently returned [TickerFuture], if any, is marked as having been
        /// canceled, meaning the future never completes and its [TickerFuture.orCancel]
        /// derivative future completes with a [TickerCanceled] error.
        ///
        /// During the animation, [status] is reported as [AnimationStatus.reverse],
        /// which switches to [AnimationStatus.dismissed] when [lowerBound] is
        /// reached at the end of the animation.
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.TickerFuture Reverse(double from = default(double))
        {


            _Direction = _AnimationDirection.Reverse;
            if (from != null) Value = from;
            return _AnimateToInternal(LowerBound);
        }




        /// <Summary>
        /// Drives the animation from its current value to target.
        ///
        /// Returns a [TickerFuture] that completes when the animation is complete.
        ///
        /// The most recently returned [TickerFuture], if any, is marked as having been
        /// canceled, meaning the future never completes and its [TickerFuture.orCancel]
        /// derivative future completes with a [TickerCanceled] error.
        ///
        /// During the animation, [status] is reported as [AnimationStatus.forward]
        /// regardless of whether `target` > [value] or not. At the end of the
        /// animation, when `target` is reached, [status] is reported as
        /// [AnimationStatus.completed].
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.TickerFuture AnimateTo(double target, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {

            _Direction = _AnimationDirection.Forward;
            return _AnimateToInternal(target, duration: duration, curve: curve);
        }




        /// <Summary>
        /// Drives the animation from its current value to target.
        ///
        /// Returns a [TickerFuture] that completes when the animation is complete.
        ///
        /// The most recently returned [TickerFuture], if any, is marked as having been
        /// canceled, meaning the future never completes and its [TickerFuture.orCancel]
        /// derivative future completes with a [TickerCanceled] error.
        ///
        /// During the animation, [status] is reported as [AnimationStatus.reverse]
        /// regardless of whether `target` < [value] or not. At the end of the
        /// animation, when `target` is reached, [status] is reported as
        /// [AnimationStatus.dismissed].
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.TickerFuture AnimateBack(double target, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {

            _Direction = _AnimationDirection.Reverse;
            return _AnimateToInternal(target, duration: duration, curve: curve);
        }




        private FlutterSDK.Scheduler.Ticker.TickerFuture _AnimateToInternal(double target, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {
            double scale = 1.0;
            if (BindingDefaultClass.SemanticsBinding.Instance.DisableAnimations)
            {
                switch (AnimationBehavior) { case AnimationBehavior.Normal: scale = 0.05; break; case AnimationBehavior.Preserve: break; }
            }

            TimeSpan simulationDuration = duration;
            if (simulationDuration == null)
            {

                double range = UpperBound - LowerBound;
                double remainingFraction = range.IsFinite() ? (target - _Value).Abs() / range : 1.0;
                TimeSpan directionDuration = (_Direction == _AnimationDirection.Reverse && ReverseDuration != null) ? ReverseDuration : this.Duration;
                simulationDuration = directionDuration * remainingFraction;
            }
            else if (target == Value)
            {
                simulationDuration = Dart.CoreDefaultClass.Duration.Zero;
            }

            Stop();
            if (simulationDuration == Dart.CoreDefaultClass.Duration.Zero)
            {
                if (Value != target)
                {
                    _Value = target.Clamp(LowerBound, UpperBound) as double;
                    NotifyListeners();
                }

                _Status = (_Direction == _AnimationDirection.Forward) ? AnimationStatus.Completed : AnimationStatus.Dismissed;
                _CheckStatusChanged();
                return TickerFuture.Complete();
            }



            return _StartSimulation(new _InterpolationSimulation(_Value, target, simulationDuration, curve, scale));
        }




        /// <Summary>
        /// Starts running this animation in the forward direction, and
        /// restarts the animation when it completes.
        ///
        /// Defaults to repeating between the [lowerBound] and [upperBound] of the
        /// [AnimationController] when no explicit value is set for [min] and [max].
        ///
        /// With [reverse] set to true, instead of always starting over at [min]
        /// the starting value will alternate between [min] and [max] values on each
        /// repeat. The [status] will be reported as [AnimationStatus.reverse] when
        /// the animation runs from [max] to [min].
        ///
        /// Returns a [TickerFuture] that never completes. The [TickerFuture.orCancel] future
        /// completes with an error when the animation is stopped (e.g. with [stop]).
        ///
        /// The most recently returned [TickerFuture], if any, is marked as having been
        /// canceled, meaning the future never completes and its [TickerFuture.orCancel]
        /// derivative future completes with a [TickerCanceled] error.
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.TickerFuture Repeat(double min = default(double), double max = default(double), bool reverse = false, TimeSpan period = default(TimeSpan))
        {
            min = (min == null ? LowerBound : min);
            max = (max == null ? UpperBound : max);
            period = (period == null ? Duration : period);




            Stop();
            return _StartSimulation(new _RepeatingSimulation(_Value, min, max, reverse, period, _DirectionSetter));
        }




        private void _DirectionSetter(FlutterSDK.Animation.Animationcontroller._AnimationDirection direction)
        {
            _Direction = direction;
            _Status = (_Direction == _AnimationDirection.Forward) ? AnimationStatus.Forward : AnimationStatus.Reverse;
            _CheckStatusChanged();
        }




        /// <Summary>
        /// Drives the animation with a critically damped spring (within [lowerBound]
        /// and [upperBound]) and initial velocity.
        ///
        /// If velocity is positive, the animation will complete, otherwise it will
        /// dismiss.
        ///
        /// Returns a [TickerFuture] that completes when the animation is complete.
        ///
        /// The most recently returned [TickerFuture], if any, is marked as having been
        /// canceled, meaning the future never completes and its [TickerFuture.orCancel]
        /// derivative future completes with a [TickerCanceled] error.
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.TickerFuture Fling(double velocity = 1.0, FlutterSDK.Animation.Animationcontroller.AnimationBehavior animationBehavior = default(FlutterSDK.Animation.Animationcontroller.AnimationBehavior))
        {
            _Direction = velocity < 0.0 ? _AnimationDirection.Reverse : _AnimationDirection.Forward;
            double target = velocity < 0.0 ? LowerBound - AnimationcontrollerDefaultClass._KFlingTolerance.Distance : UpperBound + AnimationcontrollerDefaultClass._KFlingTolerance.Distance;
            double scale = 1.0;
            AnimationBehavior behavior = animationBehavior ?? this.AnimationBehavior;
            if (BindingDefaultClass.SemanticsBinding.Instance.DisableAnimations)
            {
                switch (behavior) { case AnimationBehavior.Normal: scale = 200.0; break; case AnimationBehavior.Preserve: break; }
            }

            Simulation simulation = new SpringSimulation(AnimationcontrollerDefaultClass._KFlingSpringDescription, Value, target, velocity * scale)..Tolerance = AnimationcontrollerDefaultClass._KFlingTolerance;
            Stop();
            return _StartSimulation(simulation);
        }




        /// <Summary>
        /// Drives the animation according to the given simulation.
        ///
        /// The values from the simulation are clamped to the [lowerBound] and
        /// [upperBound]. To avoid this, consider creating the [AnimationController]
        /// using the [new AnimationController.unbounded] constructor.
        ///
        /// Returns a [TickerFuture] that completes when the animation is complete.
        ///
        /// The most recently returned [TickerFuture], if any, is marked as having been
        /// canceled, meaning the future never completes and its [TickerFuture.orCancel]
        /// derivative future completes with a [TickerCanceled] error.
        ///
        /// The [status] is always [AnimationStatus.forward] for the entire duration
        /// of the simulation.
        /// </Summary>
        public virtual FlutterSDK.Scheduler.Ticker.TickerFuture AnimateWith(FlutterSDK.Physics.Simulation.Simulation simulation)
        {

            Stop();
            _Direction = _AnimationDirection.Forward;
            return _StartSimulation(simulation);
        }




        private FlutterSDK.Scheduler.Ticker.TickerFuture _StartSimulation(FlutterSDK.Physics.Simulation.Simulation simulation)
        {


            _Simulation = simulation;
            _LastElapsedDuration = Dart.CoreDefaultClass.Duration.Zero;
            _Value = simulation.x(0.0).Clamp(LowerBound, UpperBound) as double;
            TickerFuture result = _Ticker.Start();
            _Status = (_Direction == _AnimationDirection.Forward) ? AnimationStatus.Forward : AnimationStatus.Reverse;
            _CheckStatusChanged();
            return result;
        }




        /// <Summary>
        /// Stops running this animation.
        ///
        /// This does not trigger any notifications. The animation stops in its
        /// current state.
        ///
        /// By default, the most recently returned [TickerFuture] is marked as having
        /// been canceled, meaning the future never completes and its
        /// [TickerFuture.orCancel] derivative future completes with a [TickerCanceled]
        /// error. By passing the `canceled` argument with the value false, this is
        /// reversed, and the futures complete successfully.
        ///
        /// See also:
        ///
        ///  * [reset], which stops the animation and resets it to the [lowerBound],
        ///    and which does send notifications.
        ///  * [forward], [reverse], [animateTo], [animateWith], [fling], and [repeat],
        ///    which restart the animation controller.
        /// </Summary>
        public virtual void Stop(bool canceled = true)
        {

            _Simulation = null;
            _LastElapsedDuration = null;
            _Ticker.Stop(canceled: canceled);
        }




        /// <Summary>
        /// Release the resources used by this object. The object is no longer usable
        /// after this method is called.
        ///
        /// The most recently returned [TickerFuture], if any, is marked as having been
        /// canceled, meaning the future never completes and its [TickerFuture.orCancel]
        /// derivative future completes with a [TickerCanceled] error.
        /// </Summary>
        public new void Dispose()
        {

            _Ticker.Dispose();
            _Ticker = null;
            base.Dispose();
        }




        private void _CheckStatusChanged()
        {
            AnimationStatus newStatus = Status;
            if (_LastReportedStatus != newStatus)
            {
                _LastReportedStatus = newStatus;
                NotifyStatusListeners(newStatus);
            }

        }




        private void _Tick(TimeSpan elapsed)
        {
            _LastElapsedDuration = elapsed;
            double elapsedInSeconds = elapsed.InMicroseconds().ToDouble() / Dart.CoreDefaultClass.Duration.MicrosecondsPerSecond;

            _Value = _Simulation.x(elapsedInSeconds).Clamp(LowerBound, UpperBound) as double;
            if (_Simulation.IsDone(elapsedInSeconds))
            {
                _Status = (_Direction == _AnimationDirection.Forward) ? AnimationStatus.Completed : AnimationStatus.Dismissed;
                Stop(canceled: false);
            }

            NotifyListeners();
            _CheckStatusChanged();
        }




        public new string ToStringDetails()
        {
            string paused = IsAnimating ? "" : "; paused";
            string ticker = _Ticker == null ? "; DISPOSED" : (_Ticker.Muted ? "; silenced" : "");
            string label = DebugLabel == null ? "" : $"'; for {DebugLabel}'";
            string more = $"'{base.ToStringDetails()} {Value.ToStringAsFixed(3)}'";
            return $"'{more}{paused}{ticker}{label}'";
        }



    }


    public class _InterpolationSimulation : FlutterSDK.Physics.Simulation.Simulation
    {
        public _InterpolationSimulation(double _begin, double _end, TimeSpan duration, FlutterSDK.Animation.Curves.Curve _curve, double scale)
        : base()
        {
            this._Begin = _begin;
            this._End = _end;
            this._Curve = _curve;
        }
        internal virtual double _DurationInSeconds { get; set; }
        internal virtual double _Begin { get; set; }
        internal virtual double _End { get; set; }
        internal virtual FlutterSDK.Animation.Curves.Curve _Curve { get; set; }

        public new double x(double timeInSeconds)
        {
            double t = (timeInSeconds / _DurationInSeconds).Clamp(0.0, 1.0) as double;
            if (t == 0.0) return _Begin; else if (t == 1.0) return _End; else return _Begin + (_End - _Begin) * _Curve.Transform(t);
        }




        public new double Dx(double timeInSeconds)
        {
            double epsilon = Tolerance.Time;
            return (x(timeInSeconds + epsilon) - x(timeInSeconds - epsilon)) / (2 * epsilon);
        }




        public new bool IsDone(double timeInSeconds) => timeInSeconds > _DurationInSeconds;


    }


    public class _RepeatingSimulation : FlutterSDK.Physics.Simulation.Simulation
    {
        public _RepeatingSimulation(double initialValue, double min, double max, bool reverse, TimeSpan period, FlutterSDK.Animation.Animationcontroller._DirectionSetter directionSetter)
        : base()
        {
            this.Min = min;
            this.Max = max;
            this.Reverse = reverse;
            this.DirectionSetter = directionSetter;


        }


        public virtual double Min { get; set; }
        public virtual double Max { get; set; }
        public virtual bool Reverse { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller._DirectionSetter DirectionSetter { get; set; }
        internal virtual double _PeriodInSeconds { get; set; }
        internal virtual double _InitialT { get; set; }

        public new double x(double timeInSeconds)
        {

            double totalTimeInSeconds = timeInSeconds + _InitialT;
            double t = (totalTimeInSeconds / _PeriodInSeconds) % 1.0;
            bool _isPlayingReverse = (totalTimeInSeconds~/ _PeriodInSeconds)% 2 == 1;
            if (Reverse && _isPlayingReverse)
            {
                DirectionSetter(_AnimationDirection.Reverse);
                return Dart.UI.UiDefaultClass.LerpDouble(Max, Min, t);
            }
            else
            {
                DirectionSetter(_AnimationDirection.Forward);
                return Dart.UI.UiDefaultClass.LerpDouble(Min, Max, t);
            }

        }




        public new double Dx(double timeInSeconds) => (Max - Min) / _PeriodInSeconds;



        public new bool IsDone(double timeInSeconds) => false;


    }


    /// <Summary>
    /// The direction in which an animation is running.
    /// </Summary>
    public enum _AnimationDirection
    {

        /// <Summary>
        /// The animation is running from beginning to end.
        /// </Summary>
        Forward,
        /// <Summary>
        /// The animation is running backwards, from end to beginning.
        /// </Summary>
        Reverse,
    }


    /// <Summary>
    /// Configures how an [AnimationController] behaves when animations are
    /// disabled.
    ///
    /// When [AccessibilityFeatures.disableAnimations] is true, the device is asking
    /// Flutter to reduce or disable animations as much as possible. To honor this,
    /// we reduce the duration and the corresponding number of frames for
    /// animations. This enum is used to allow certain [AnimationController]s to opt
    /// out of this behavior.
    ///
    /// For example, the [AnimationController] which controls the physics simulation
    /// for a scrollable list will have [AnimationBehavior.preserve], so that when
    /// a user attempts to scroll it does not jump to the end/beginning too quickly.
    /// </Summary>
    public enum AnimationBehavior
    {

        /// <Summary>
        /// The [AnimationController] will reduce its duration when
        /// [AccessibilityFeatures.disableAnimations] is true.
        /// </Summary>
        Normal,
        /// <Summary>
        /// The [AnimationController] will preserve its behavior.
        ///
        /// This is the default for repeating animations in order to prevent them from
        /// flashing rapidly on the screen if the widget does not take the
        /// [AccessibilityFeatures.disableAnimations] flag into account.
        /// </Summary>
        Preserve,
    }

}
