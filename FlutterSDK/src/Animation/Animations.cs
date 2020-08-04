using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Widgets.Framework;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Animation.Animations
{
    internal static class AnimationsDefaultClass
    {
        public static FlutterSDK.Animation.Animation.Animation<double> KAlwaysCompleteAnimation = default(FlutterSDK.Animation.Animation.Animation<double>);
        public static FlutterSDK.Animation.Animation.Animation<double> KAlwaysDismissedAnimation = default(FlutterSDK.Animation.Animation.Animation<double>);
    }

    /// <Summary>
    /// An interface for combining multiple Animations. Subclasses need only
    /// implement the `value` getter to control how the child animations are
    /// combined. Can be chained to combine more than 2 animations.
    ///
    /// For example, to create an animation that is the sum of two others, subclass
    /// this class and define `T get value = first.value + second.value;`
    ///
    /// By default, the [status] of a [CompoundAnimation] is the status of the
    /// [next] animation if [next] is moving, and the status of the [first]
    /// animation otherwise.
    /// </Summary>
    public interface ICompoundAnimation<T>
    {
        void DidStartListening();
        void DidStopListening();
        string ToString();
        FlutterSDK.Animation.Animation.Animation<T> First { get; }
        FlutterSDK.Animation.Animation.Animation<T> Next { get; }
        FlutterSDK.Animation.Animation.AnimationStatus Status { get; }
    }


    public interface IAnimationWithParentMixin<T> { }

    public class AnimationWithParentMixin<T>
    {
        public virtual FlutterSDK.Animation.Animation.Animation<T> Parent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.AnimationStatus Status { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Calls the listener every time the value of the animation changes.
        ///
        /// Listeners can be removed with [removeListener].
        /// </Summary>
        public virtual void AddListener(VoidCallback listener) => Parent.AddListener(listener);



        /// <Summary>
        /// Stop calling the listener every time the value of the animation changes.
        ///
        /// Listeners can be added with [addListener].
        /// </Summary>
        public virtual void RemoveListener(VoidCallback listener) => Parent.RemoveListener(listener);



        /// <Summary>
        /// Calls listener every time the status of the animation changes.
        ///
        /// Listeners can be removed with [removeStatusListener].
        /// </Summary>
        public virtual void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener) => Parent.AddStatusListener(listener);



        /// <Summary>
        /// Stops calling the listener every time the status of the animation changes.
        ///
        /// Listeners can be added with [addStatusListener].
        /// </Summary>
        public virtual void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener) => Parent.RemoveStatusListener(listener);


    }
    public static class AnimationWithParentMixinMixin
    {
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
        public static void AddListener<T>(this IAnimationWithParentMixin<T> instance, VoidCallback listener) => GetOrCreate(instance).AddListener(listener);
        public static void RemoveListener<T>(this IAnimationWithParentMixin<T> instance, VoidCallback listener) => GetOrCreate(instance).RemoveListener(listener);
        public static void AddStatusListener<T>(this IAnimationWithParentMixin<T> instance, FlutterSDK.Animation.Animation.AnimationStatusListener listener) => GetOrCreate(instance).AddStatusListener(listener);
        public static void RemoveStatusListener<T>(this IAnimationWithParentMixin<T> instance, FlutterSDK.Animation.Animation.AnimationStatusListener listener) => GetOrCreate(instance).RemoveStatusListener(listener);
    }


    public class _AlwaysCompleteAnimation : FlutterSDK.Animation.Animation.Animation<double>
    {
        public _AlwaysCompleteAnimation()
        {

        }
        public virtual FlutterSDK.Animation.Animation.AnimationStatus Status { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void AddListener(VoidCallback listener)
        {
        }




        public new void RemoveListener(VoidCallback listener)
        {
        }




        public new void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener)
        {
        }




        public new void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener)
        {
        }




    }


    public class _AlwaysDismissedAnimation : FlutterSDK.Animation.Animation.Animation<double>
    {
        public _AlwaysDismissedAnimation()
        {

        }
        public virtual FlutterSDK.Animation.Animation.AnimationStatus Status { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void AddListener(VoidCallback listener)
        {
        }




        public new void RemoveListener(VoidCallback listener)
        {
        }




        public new void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener)
        {
        }




        public new void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener)
        {
        }




    }


    /// <Summary>
    /// An animation that is always stopped at a given value.
    ///
    /// The [status] is always [AnimationStatus.forward].
    /// </Summary>
    public class AlwaysStoppedAnimation<T> : FlutterSDK.Animation.Animation.Animation<T>
    {
        /// <Summary>
        /// Creates an [AlwaysStoppedAnimation] with the given value.
        ///
        /// Since the [value] and [status] of an [AlwaysStoppedAnimation] can never
        /// change, the listeners can never be called. It is therefore safe to reuse
        /// an [AlwaysStoppedAnimation] instance in multiple places. If the [value] to
        /// be used is known at compile time, the constructor should be called as a
        /// `const` constructor.
        /// </Summary>
        public AlwaysStoppedAnimation(T value)
        {
            this.Value = value;
        }
        public new T Value { get; set; }
        public virtual FlutterSDK.Animation.Animation.AnimationStatus Status { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void AddListener(VoidCallback listener)
        {
        }




        public new void RemoveListener(VoidCallback listener)
        {
        }




        public new void AddStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener)
        {
        }




        public new void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener)
        {
        }




        public new string ToStringDetails()
        {
            return $"'{base.ToStringDetails()} {Value}; paused'";
        }



    }


    /// <Summary>
    /// An animation that is a proxy for another animation.
    ///
    /// A proxy animation is useful because the parent animation can be mutated. For
    /// example, one object can create a proxy animation, hand the proxy to another
    /// object, and then later change the animation from which the proxy receives
    /// its value.
    /// </Summary>
    public class ProxyAnimation : FlutterSDK.Animation.Animation.Animation<double>, IAnimationLazyListenerMixin, IAnimationLocalListenersMixin, IAnimationLocalStatusListenersMixin
    {
        /// <Summary>
        /// Creates a proxy animation.
        ///
        /// If the animation argument is omitted, the proxy animation will have the
        /// status [AnimationStatus.dismissed] and a value of 0.0.
        /// </Summary>
        public ProxyAnimation(FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>))
        {

            _Parent = animation;
            if (_Parent == null)
            {
                _Status = AnimationStatus.Dismissed;
                _Value = 0.0;
            }

        }


        internal virtual FlutterSDK.Animation.Animation.AnimationStatus _Status { get; set; }
        internal virtual double _Value { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Parent { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Parent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.AnimationStatus Status { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void DidStartListening()
        {
            if (_Parent != null)
            {
                _Parent.AddListener(NotifyListeners);
                _Parent.AddStatusListener(NotifyStatusListeners);
            }

        }




        public new void DidStopListening()
        {
            if (_Parent != null)
            {
                _Parent.RemoveListener(NotifyListeners);
                _Parent.RemoveStatusListener(NotifyStatusListeners);
            }

        }




    }


    /// <Summary>
    /// An animation that is the reverse of another animation.
    ///
    /// If the parent animation is running forward from 0.0 to 1.0, this animation
    /// is running in reverse from 1.0 to 0.0.
    ///
    /// Using a [ReverseAnimation] is different from simply using a [Tween] with a
    /// begin of 1.0 and an end of 0.0 because the tween does not change the status
    /// or direction of the animation.
    ///
    /// See also:
    ///
    ///  * [Curve.flipped] and [FlippedCurve], which provide a similar effect but on
    ///    [Curve]s.
    ///  * [CurvedAnimation], which can take separate curves for when the animation
    ///    is going forward than for when it is going in reverse.
    /// </Summary>
    public class ReverseAnimation : FlutterSDK.Animation.Animation.Animation<double>, IAnimationLazyListenerMixin, IAnimationLocalStatusListenersMixin
    {
        /// <Summary>
        /// Creates a reverse animation.
        ///
        /// The parent argument must not be null.
        /// </Summary>
        public ReverseAnimation(FlutterSDK.Animation.Animation.Animation<double> parent)
        : base()
        {
            this.Parent = parent;
        }
        /// <Summary>
        /// The animation whose value and direction this animation is reversing.
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<double> Parent { get; set; }
        public virtual FlutterSDK.Animation.Animation.AnimationStatus Status { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void AddListener(VoidCallback listener)
        {
            DidRegisterListener();
            Parent.AddListener(listener);
        }




        public new void RemoveListener(VoidCallback listener)
        {
            Parent.RemoveListener(listener);
            DidUnregisterListener();
        }




        public new void DidStartListening()
        {
            Parent.AddStatusListener(_StatusChangeHandler);
        }




        public new void DidStopListening()
        {
            Parent.RemoveStatusListener(_StatusChangeHandler);
        }




        private void _StatusChangeHandler(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            NotifyStatusListeners(_ReverseStatus(status));
        }




        private FlutterSDK.Animation.Animation.AnimationStatus _ReverseStatus(FlutterSDK.Animation.Animation.AnimationStatus status)
        {

            switch (status) { case AnimationStatus.Forward: return AnimationStatus.Reverse; case AnimationStatus.Reverse: return AnimationStatus.Forward; case AnimationStatus.Completed: return AnimationStatus.Dismissed; case AnimationStatus.Dismissed: return AnimationStatus.Completed; }
            return null;
        }




    }


    /// <Summary>
    /// An animation that applies a curve to another animation.
    ///
    /// [CurvedAnimation] is useful when you want to apply a non-linear [Curve] to
    /// an animation object, especially if you want different curves when the
    /// animation is going forward vs when it is going backward.
    ///
    /// Depending on the given curve, the output of the [CurvedAnimation] could have
    /// a wider range than its input. For example, elastic curves such as
    /// [Curves.elasticIn] will significantly overshoot or undershoot the default
    /// range of 0.0 to 1.0.
    ///
    /// If you want to apply a [Curve] to a [Tween], consider using [CurveTween].
    ///
    /// {@tool snippet}
    ///
    /// The following code snippet shows how you can apply a curve to a linear
    /// animation produced by an [AnimationController] `controller`.
    ///
    /// ```dart
    /// final Animation<double> animation = CurvedAnimation(
    ///   parent: controller,
    ///   curve: Curves.ease,
    /// );
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// This second code snippet shows how to apply a different curve in the forward
    /// direction than in the reverse direction. This can't be done using a
    /// [CurveTween] (since [Tween]s are not aware of the animation direction when
    /// they are applied).
    ///
    /// ```dart
    /// final Animation<double> animation = CurvedAnimation(
    ///   parent: controller,
    ///   curve: Curves.easeIn,
    ///   reverseCurve: Curves.easeOut,
    /// );
    /// ```
    /// {@end-tool}
    ///
    /// By default, the [reverseCurve] matches the forward [curve].
    ///
    /// See also:
    ///
    ///  * [CurveTween], for an alternative way of expressing the first sample
    ///    above.
    ///  * [AnimationController], for examples of creating and disposing of an
    ///    [AnimationController].
    ///  * [Curve.flipped] and [FlippedCurve], which provide the reverse of a
    ///    [Curve].
    /// </Summary>
    public class CurvedAnimation : FlutterSDK.Animation.Animation.Animation<double>, IAnimationWithParentMixin<double>
    {
        /// <Summary>
        /// Creates a curved animation.
        ///
        /// The parent and curve arguments must not be null.
        /// </Summary>
        public CurvedAnimation(FlutterSDK.Animation.Animation.Animation<double> parent = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Animation.Curves.Curve reverseCurve = default(FlutterSDK.Animation.Curves.Curve))
        : base()
        {
            this.Parent = parent;
            this.Curve = curve;
            this.ReverseCurve = reverseCurve;
            _UpdateCurveDirection(Parent.Status);
            Parent.AddStatusListener(_UpdateCurveDirection);
        }


        /// <Summary>
        /// The animation to which this animation applies a curve.
        /// </Summary>
        public new FlutterSDK.Animation.Animation.Animation<double> Parent { get; set; }
        /// <Summary>
        /// The curve to use in the forward direction.
        /// </Summary>
        public virtual FlutterSDK.Animation.Curves.Curve Curve { get; set; }
        /// <Summary>
        /// The curve to use in the reverse direction.
        ///
        /// If the parent animation changes direction without first reaching the
        /// [AnimationStatus.completed] or [AnimationStatus.dismissed] status, the
        /// [CurvedAnimation] stays on the same curve (albeit in the opposite
        /// direction) to avoid visual discontinuities.
        ///
        /// If you use a non-null [reverseCurve], you might want to hold this object
        /// in a [State] object rather than recreating it each time your widget builds
        /// in order to take advantage of the state in this object that avoids visual
        /// discontinuities.
        ///
        /// If this field is null, uses [curve] in both directions.
        /// </Summary>
        public virtual FlutterSDK.Animation.Curves.Curve ReverseCurve { get; set; }
        /// <Summary>
        /// The direction used to select the current curve.
        ///
        /// The curve direction is only reset when we hit the beginning or the end of
        /// the timeline to avoid discontinuities in the value of any variables this
        /// animation is used to animate.
        /// </Summary>
        internal virtual FlutterSDK.Animation.Animation.AnimationStatus _CurveDirection { get; set; }
        internal virtual bool _UseForwardCurve { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _UpdateCurveDirection(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            switch (status) { case AnimationStatus.Dismissed: case AnimationStatus.Completed: _CurveDirection = null; break; case AnimationStatus.Forward: _CurveDirection = (_CurveDirection == null ? AnimationStatus.Forward : _CurveDirection); break; case AnimationStatus.Reverse: _CurveDirection = (_CurveDirection == null ? AnimationStatus.Reverse : _CurveDirection); break; }
        }




    }


    /// <Summary>
    /// This animation starts by proxying one animation, but when the value of that
    /// animation crosses the value of the second (either because the second is
    /// going in the opposite direction, or because the one overtakes the other),
    /// the animation hops over to proxying the second animation.
    ///
    /// When the [TrainHoppingAnimation] starts proxying the second animation
    /// instead of the first, the [onSwitchedTrain] callback is called.
    ///
    /// If the two animations start at the same value, then the
    /// [TrainHoppingAnimation] immediately hops to the second animation, and the
    /// [onSwitchedTrain] callback is not called. If only one animation is provided
    /// (i.e. if the second is null), then the [TrainHoppingAnimation] just proxies
    /// the first animation.
    ///
    /// Since this object must track the two animations even when it has no
    /// listeners of its own, instead of shutting down when all its listeners are
    /// removed, it exposes a [dispose()] method. Call this method to shut this
    /// object down.
    /// </Summary>
    public class TrainHoppingAnimation : FlutterSDK.Animation.Animation.Animation<double>, IAnimationEagerListenerMixin, IAnimationLocalListenersMixin, IAnimationLocalStatusListenersMixin
    {
        /// <Summary>
        /// Creates a train-hopping animation.
        ///
        /// The current train argument must not be null but the next train argument
        /// can be null. If the next train is null, then this object will just proxy
        /// the first animation and never hop.
        /// </Summary>
        public TrainHoppingAnimation(FlutterSDK.Animation.Animation.Animation<double> _currentTrain, FlutterSDK.Animation.Animation.Animation<double> _nextTrain, VoidCallback onSwitchedTrain = default(VoidCallback))
        : base()
        {
            this._CurrentTrain = _currentTrain;
            this._NextTrain = _nextTrain;
            this.OnSwitchedTrain = onSwitchedTrain;
            if (_NextTrain != null)
            {
                if (_CurrentTrain.Value == _NextTrain.Value)
                {
                    _CurrentTrain = _NextTrain;
                    _NextTrain = null;
                }
                else if (_CurrentTrain.Value > _NextTrain.Value)
                {
                    _Mode = _TrainHoppingMode.Maximize;
                }
                else
                {

                    _Mode = _TrainHoppingMode.Minimize;
                }

            }

            _CurrentTrain.AddStatusListener(_StatusChangeHandler);
            _CurrentTrain.AddListener(_ValueChangeHandler);
            _NextTrain?.AddListener(_ValueChangeHandler);

        }


        internal virtual FlutterSDK.Animation.Animation.Animation<double> _CurrentTrain { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _NextTrain { get; set; }
        internal virtual FlutterSDK.Animation.Animations._TrainHoppingMode _Mode { get; set; }
        /// <Summary>
        /// Called when this animation switches to be driven by the second animation.
        ///
        /// This is not called if the two animations provided to the constructor have
        /// the same value at the time of the call to the constructor. In that case,
        /// the second animation is used from the start, and the first is ignored.
        /// </Summary>
        public virtual VoidCallback OnSwitchedTrain { get; set; }
        internal virtual FlutterSDK.Animation.Animation.AnimationStatus _LastStatus { get; set; }
        internal virtual double _LastValue { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> CurrentTrain { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Animation.Animation.AnimationStatus Status { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _StatusChangeHandler(FlutterSDK.Animation.Animation.AnimationStatus status)
        {

            if (status != _LastStatus)
            {
                NotifyListeners();
                _LastStatus = status;
            }


        }




        private void _ValueChangeHandler()
        {

            bool hop = false;
            if (_NextTrain != null)
            {

                switch (_Mode) { case _TrainHoppingMode.Minimize: hop = _NextTrain.Value <= _CurrentTrain.Value; break; case _TrainHoppingMode.Maximize: hop = _NextTrain.Value >= _CurrentTrain.Value; break; }
                if (hop)
                {
                    ;
                    _CurrentTrain.RemoveStatusListener(_StatusChangeHandler);
                    _CurrentTrain.RemoveListener(_ValueChangeHandler);
                    _CurrentTrain = _NextTrain;
                    _NextTrain = null;
                    _CurrentTrain.AddStatusListener(_StatusChangeHandler);
                    _StatusChangeHandler(_CurrentTrain.Status);
                }

            }

            double newValue = Value;
            if (newValue != _LastValue)
            {
                NotifyListeners();
                _LastValue = newValue;
            }


            if (hop && OnSwitchedTrain != null) OnSwitchedTrain();
        }




        /// <Summary>
        /// Frees all the resources used by this performance.
        /// After this is called, this object is no longer usable.
        /// </Summary>
        public new void Dispose()
        {

            _CurrentTrain.RemoveStatusListener(_StatusChangeHandler);
            _CurrentTrain.RemoveListener(_ValueChangeHandler);
            _CurrentTrain = null;
            _NextTrain?.RemoveListener(_ValueChangeHandler);
            _NextTrain = null;
            base.Dispose();
        }




    }


    /// <Summary>
    /// An interface for combining multiple Animations. Subclasses need only
    /// implement the `value` getter to control how the child animations are
    /// combined. Can be chained to combine more than 2 animations.
    ///
    /// For example, to create an animation that is the sum of two others, subclass
    /// this class and define `T get value = first.value + second.value;`
    ///
    /// By default, the [status] of a [CompoundAnimation] is the status of the
    /// [next] animation if [next] is moving, and the status of the [first]
    /// animation otherwise.
    /// </Summary>
    public class CompoundAnimation<T> : FlutterSDK.Animation.Animation.Animation<T>, IAnimationLazyListenerMixin, IAnimationLocalListenersMixin, IAnimationLocalStatusListenersMixin
    {
        /// <Summary>
        /// Creates a CompoundAnimation. Both arguments must be non-null. Either can
        /// be a CompoundAnimation itself to combine multiple animations.
        /// </Summary>
        public CompoundAnimation(FlutterSDK.Animation.Animation.Animation<T> first = default(FlutterSDK.Animation.Animation.Animation<T>), FlutterSDK.Animation.Animation.Animation<T> next = default(FlutterSDK.Animation.Animation.Animation<T>))
        : base()
        {
            this.First = first;
            this.Next = next;
        }
        /// <Summary>
        /// The first sub-animation. Its status takes precedence if neither are
        /// animating.
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<T> First { get; set; }
        /// <Summary>
        /// The second sub-animation.
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<T> Next { get; set; }
        internal virtual FlutterSDK.Animation.Animation.AnimationStatus _LastStatus { get; set; }
        internal virtual T _LastValue { get; set; }
        public virtual FlutterSDK.Animation.Animation.AnimationStatus Status { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void DidStartListening()
        {
            First.AddListener(_MaybeNotifyListeners);
            First.AddStatusListener(_MaybeNotifyStatusListeners);
            Next.AddListener(_MaybeNotifyListeners);
            Next.AddStatusListener(_MaybeNotifyStatusListeners);
        }




        public new void DidStopListening()
        {
            First.RemoveListener(_MaybeNotifyListeners);
            First.RemoveStatusListener(_MaybeNotifyStatusListeners);
            Next.RemoveListener(_MaybeNotifyListeners);
            Next.RemoveStatusListener(_MaybeNotifyStatusListeners);
        }





        private void _MaybeNotifyStatusListeners(FlutterSDK.Animation.Animation.AnimationStatus _)
        {
            if (Status != _LastStatus)
            {
                _LastStatus = Status;
                NotifyStatusListeners(Status);
            }

        }




        private void _MaybeNotifyListeners()
        {
            if (Value != _LastValue)
            {
                _LastValue = Value;
                NotifyListeners();
            }

        }



    }


    /// <Summary>
    /// An animation of [double]s that tracks the mean of two other animations.
    ///
    /// The [status] of this animation is the status of the `right` animation if it is
    /// moving, and the `left` animation otherwise.
    ///
    /// The [value] of this animation is the [double] that represents the mean value
    /// of the values of the `left` and `right` animations.
    /// </Summary>
    public class AnimationMean : FlutterSDK.Animation.Animations.CompoundAnimation<double>
    {
        /// <Summary>
        /// Creates an animation that tracks the mean of two other animations.
        /// </Summary>
        public AnimationMean(FlutterSDK.Animation.Animation.Animation<double> left = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> right = default(FlutterSDK.Animation.Animation.Animation<double>))
        : base(first: left, next: right)
        {

        }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    /// <Summary>
    /// An animation that tracks the maximum of two other animations.
    ///
    /// The [value] of this animation is the maximum of the values of
    /// [first] and [next].
    /// </Summary>
    public class AnimationMax<T> : FlutterSDK.Animation.Animations.CompoundAnimation<T>
    {
        /// <Summary>
        /// Creates an [AnimationMax].
        ///
        /// Both arguments must be non-null. Either can be an [AnimationMax] itself
        /// to combine multiple animations.
        /// </Summary>
        public AnimationMax(FlutterSDK.Animation.Animation.Animation<T> first, FlutterSDK.Animation.Animation.Animation<T> next)
        : base(first: first, next: next)
        {

        }
        public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    /// <Summary>
    /// An animation that tracks the minimum of two other animations.
    ///
    /// The [value] of this animation is the maximum of the values of
    /// [first] and [next].
    /// </Summary>
    public class AnimationMin<T> : FlutterSDK.Animation.Animations.CompoundAnimation<T>
    {
        /// <Summary>
        /// Creates an [AnimationMin].
        ///
        /// Both arguments must be non-null. Either can be an [AnimationMin] itself
        /// to combine multiple animations.
        /// </Summary>
        public AnimationMin(FlutterSDK.Animation.Animation.Animation<T> first, FlutterSDK.Animation.Animation.Animation<T> next)
        : base(first: first, next: next)
        {

        }
        public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    public enum _TrainHoppingMode
    {

        Minimize,
        Maximize,
    }

}
