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

    public class TweenSequence<T> : FlutterSDK.Animation.Tween.Animatable<T>
    {
        #region constructors
        public TweenSequence(List<FlutterSDK.Animation.Tweensequence.TweenSequenceItem<T>> items)
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual List<FlutterSDK.Animation.Tweensequence.TweenSequenceItem<T>> _Items { get; set; }
        internal virtual List<FlutterSDK.Animation.Tweensequence._Interval> _Intervals { get; set; }
        #endregion

        #region methods

        private T _EvaluateAt(double t, int index) { throw new NotImplementedException(); }


        public new T Transform(double t) { throw new NotImplementedException(); }


        #endregion
    }


    public class FlippedTweenSequence : FlutterSDK.Animation.Tweensequence.TweenSequence<double>
    {
        #region constructors
        public FlippedTweenSequence(List<FlutterSDK.Animation.Tweensequence.TweenSequenceItem<double>> items)
        : base(items)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new double Transform(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class TweenSequenceItem<T>
    {
        #region constructors
        public TweenSequenceItem(FlutterSDK.Animation.Tween.Animatable<T> tween = default(FlutterSDK.Animation.Tween.Animatable<T>), double weight = default(double))
        : base()
        {
            this.Tween = tween;
            this.Weight = weight; throw new NotImplementedException();
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
            this.End = end; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Start { get; set; }
        public virtual double End { get; set; }
        #endregion

        #region methods

        public virtual bool Contains(double t) { throw new NotImplementedException(); }


        public virtual double Value(double t) { throw new NotImplementedException(); }


        #endregion
    }

}
