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
namespace FlutterSDK.Animation.Tweensequence
{
    internal static class TweensequenceDefaultClass
    {
    }

    /// <Summary>
    /// Enables creating an [Animation] whose value is defined by a sequence of
    /// [Tween]s.
    ///
    /// Each [TweenSequenceItem] has a weight that defines its percentage of the
    /// animation's duration. Each tween defines the animation's value during the
    /// interval indicated by its weight.
    ///
    /// {@tool snippet}
    /// This example defines an animation that uses an easing curve to interpolate
    /// between 5.0 and 10.0 during the first 40% of the animation, remains at 10.0
    /// for the next 20%, and then returns to 5.0 for the final 40%.
    ///
    /// ```dart
    /// final Animation<double> animation = TweenSequence(
    ///   <TweenSequenceItem<double>>[
    ///     TweenSequenceItem<double>(
    ///       tween: Tween<double>(begin: 5.0, end: 10.0)
    ///         .chain(CurveTween(curve: Curves.ease)),
    ///       weight: 40.0,
    ///     ),
    ///     TweenSequenceItem<double>(
    ///       tween: ConstantTween<double>(10.0),
    ///       weight: 20.0,
    ///     ),
    ///     TweenSequenceItem<double>(
    ///       tween: Tween<double>(begin: 10.0, end: 5.0)
    ///         .chain(CurveTween(curve: Curves.ease)),
    ///       weight: 40.0,
    ///     ),
    ///   ],
    /// ).animate(myAnimationController);
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class TweenSequence<T> : FlutterSDK.Animation.Tween.Animatable<T>
    {
        #region constructors
        public TweenSequence(List<FlutterSDK.Animation.Tweensequence.TweenSequenceItem<T>> items)
        : base()
        {

            _Items.AddAll(items);
            double totalWeight = 0.0;
            foreach (TweenSequenceItem<T> item in _Items) totalWeight += item.Weight;

            double start = 0.0;
            for (int i = 0; i < _Items.Count; i += 1)
            {
                double end = i == _Items.Count - 1 ? 1.0 : start + _Items[i].Weight / totalWeight;
                _Intervals.Add(new _Interval(start, end));
                start = end;
            }

        }


        #endregion

        #region fields
        internal virtual List<FlutterSDK.Animation.Tweensequence.TweenSequenceItem<T>> _Items { get; set; }
        internal virtual List<FlutterSDK.Animation.Tweensequence._Interval> _Intervals { get; set; }
        #endregion

        #region methods

        private T _EvaluateAt(double t, int index)
        {
            TweenSequenceItem<T> element = _Items[index];
            double tInterval = _Intervals[index].Value(t);
            return element.Tween.Transform(tInterval);
        }




        public new T Transform(double t)
        {

            if (t == 1.0) return _EvaluateAt(t, _Items.Count - 1);
            for (int index = 0; index < _Items.Count; index++)
            {
                if (_Intervals[index].Contains(t)) return _EvaluateAt(t, index);
            }


            return null;
        }




        #endregion
    }


    /// <Summary>
    /// Enables creating a flipped [Animation] whose value is defined by a sequence
    /// of [Tween]s.
    ///
    /// This creates a [TweenSequence] that evaluates to a result that flips the
    /// tween both horizontally and vertically.
    ///
    /// This tween sequence assumes that the evaluated result has to be a double
    /// between 0.0 and 1.0.
    /// </Summary>
    public class FlippedTweenSequence : FlutterSDK.Animation.Tweensequence.TweenSequence<double>
    {
        #region constructors
        public FlippedTweenSequence(List<FlutterSDK.Animation.Tweensequence.TweenSequenceItem<double>> items)
        : base(items)
        {

        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new double Transform(double t) => 1 - base.Transform(1 - t);


        #endregion
    }


    /// <Summary>
    /// A simple holder for one element of a [TweenSequence].
    /// </Summary>
    public class TweenSequenceItem<T>
    {
        #region constructors
        public TweenSequenceItem(FlutterSDK.Animation.Tween.Animatable<T> tween = default(FlutterSDK.Animation.Tween.Animatable<T>), double weight = default(double))
        : base()
        {
            this.Tween = tween;
            this.Weight = weight;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Animation.Tween.Animatable<T> Tween { get; set; }
        public virtual double Weight { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class _Interval
    {
        #region constructors
        public _Interval(double start, double end)
        : base()
        {
            this.Start = start;
            this.End = end;
        }
        #endregion

        #region fields
        public virtual double Start { get; set; }
        public virtual double End { get; set; }
        #endregion

        #region methods

        public virtual bool Contains(double t) => t >= Start && t < End;



        public virtual double Value(double t) => (t - Start) / (End - Start);



        #endregion
    }

}
