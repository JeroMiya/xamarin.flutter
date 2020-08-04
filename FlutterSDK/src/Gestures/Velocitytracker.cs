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
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
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
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Gestures.Velocitytracker
{
    internal static class VelocitytrackerDefaultClass
    {
    }

    public interface IVelocityTracker { }

    public class VelocityTracker
    {
        internal virtual int _AssumePointerMoveStoppedMilliseconds { get; set; }
        internal virtual int _HistorySize { get; set; }
        internal virtual int _HorizonMilliseconds { get; set; }
        internal virtual int _MinSampleSize { get; set; }
        internal virtual List<FlutterSDK.Gestures.Velocitytracker._PointAtTime> _Samples { get; set; }
        internal virtual int _Index { get; set; }

        /// <Summary>
        /// Adds a position as the given time to the tracker.
        /// </Summary>
        public virtual void AddPosition(TimeSpan time, FlutterBinding.UI.Offset position)
        {
            _Index += 1;
            if (_Index == _HistorySize) _Index = 0;
            _Samples[_Index] = new _PointAtTime(position, time);
        }




        /// <Summary>
        /// Returns an estimate of the velocity of the object being tracked by the
        /// tracker given the current information available to the tracker.
        ///
        /// Information is added using [addPosition].
        ///
        /// Returns null if there is no data on which to base an estimate.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Velocitytracker.VelocityEstimate GetVelocityEstimate()
        {
            List<double> x = new List<double>() { };
            List<double> y = new List<double>() { };
            List<double> w = new List<double>() { };
            List<double> time = new List<double>() { };
            int sampleCount = 0;
            int index = _Index;
            _PointAtTime newestSample = _Samples[index];
            if (newestSample == null) return null;
            _PointAtTime previousSample = newestSample;
            _PointAtTime oldestSample = newestSample;
            do
            {
                _PointAtTime sample = _Samples[index];
                if (sample == null) break;
                double age = (newestSample.Time - sample.Time).InMilliseconds.ToDouble();
                double delta = (sample.Time - previousSample.Time).InMilliseconds.Abs().ToDouble();
                previousSample = sample;
                if (age > _HorizonMilliseconds || delta > _AssumePointerMoveStoppedMilliseconds) break;
                oldestSample = sample;
                Offset position = sample.Point;
                x.Add(position.Dx);
                y.Add(position.Dy);
                w.Add(1.0);
                time.Add(-age);
                index = (index == 0 ? _HistorySize : index) - 1;
                sampleCount += 1;
            }
            while (sampleCount < _HistorySize);
            if (sampleCount >= _MinSampleSize)
            {
                LeastSquaresSolver xSolver = new LeastSquaresSolver(time, x, w);
                PolynomialFit xFit = xSolver.Solve(2);
                if (xFit != null)
                {
                    LeastSquaresSolver ySolver = new LeastSquaresSolver(time, y, w);
                    PolynomialFit yFit = ySolver.Solve(2);
                    if (yFit != null)
                    {
                        return new VelocityEstimate(pixelsPerSecond: new Offset(xFit.Coefficients[1] * 1000, yFit.Coefficients[1] * 1000), confidence: xFit.Confidence * yFit.Confidence, duration: newestSample.Time - oldestSample.Time, offset: newestSample.Point - oldestSample.Point);
                    }

                }

            }

            return new VelocityEstimate(pixelsPerSecond: Dart.UiDefaultClass.Offset.Zero, confidence: 1.0, duration: newestSample.Time - oldestSample.Time, offset: newestSample.Point - oldestSample.Point);
        }




        /// <Summary>
        /// Computes the velocity of the pointer at the time of the last
        /// provided data point.
        ///
        /// This can be expensive. Only call this when you need the velocity.
        ///
        /// Returns [Velocity.zero] if there is no data from which to compute an
        /// estimate or if the estimated velocity is zero.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Velocitytracker.Velocity GetVelocity()
        {
            VelocityEstimate estimate = GetVelocityEstimate();
            if (estimate == null || estimate.PixelsPerSecond == Dart.UiDefaultClass.Offset.Zero) return VelocitytrackerDefaultClass.Velocity.Zero;
            return new Velocity(pixelsPerSecond: estimate.PixelsPerSecond);
        }



    }
    public static class VelocityTrackerMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IVelocityTracker, VelocityTracker> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IVelocityTracker, VelocityTracker>();
        static VelocityTracker GetOrCreate(IVelocityTracker instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new VelocityTracker();
                _table.Add(instance, value);
            }
            return (VelocityTracker)value;
        }
        public static void AddPosition(this IVelocityTracker instance, TimeSpan time, FlutterBinding.UI.Offset position) => GetOrCreate(instance).AddPosition(time, position);
        public static FlutterSDK.Gestures.Velocitytracker.VelocityEstimate GetVelocityEstimate(this IVelocityTracker instance) => GetOrCreate(instance).GetVelocityEstimate();
        public static FlutterSDK.Gestures.Velocitytracker.Velocity GetVelocity(this IVelocityTracker instance) => GetOrCreate(instance).GetVelocity();
    }


    /// <Summary>
    /// A velocity in two dimensions.
    /// </Summary>
    public class Velocity
    {
        /// <Summary>
        /// Creates a velocity.
        ///
        /// The [pixelsPerSecond] argument must not be null.
        /// </Summary>
        public Velocity(FlutterBinding.UI.Offset pixelsPerSecond = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.PixelsPerSecond = pixelsPerSecond;
        }
        /// <Summary>
        /// A velocity that isn't moving at all.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Velocitytracker.Velocity Zero { get; set; }
        /// <Summary>
        /// The number of pixels per second of velocity in the x and y directions.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset PixelsPerSecond { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Return the negation of a velocity.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Velocitytracker.Velocity Unary() => new Velocity(pixelsPerSecond: -PixelsPerSecond);



        /// <Summary>
        /// Return the difference of two velocities.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Velocitytracker.Velocity SubtractOperator(FlutterSDK.Gestures.Velocitytracker.Velocity other)
        {
            return new Velocity(pixelsPerSecond: PixelsPerSecond - other.PixelsPerSecond);
        }




        /// <Summary>
        /// Return the sum of two velocities.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Velocitytracker.Velocity AddOperator(FlutterSDK.Gestures.Velocitytracker.Velocity other)
        {
            return new Velocity(pixelsPerSecond: PixelsPerSecond + other.PixelsPerSecond);
        }




        /// <Summary>
        /// Return a velocity whose magnitude has been clamped to [minValue]
        /// and [maxValue].
        ///
        /// If the magnitude of this Velocity is less than minValue then return a new
        /// Velocity with the same direction and with magnitude [minValue]. Similarly,
        /// if the magnitude of this Velocity is greater than maxValue then return a
        /// new Velocity with the same direction and magnitude [maxValue].
        ///
        /// If the magnitude of this Velocity is within the specified bounds then
        /// just return this.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Velocitytracker.Velocity ClampMagnitude(double minValue, double maxValue)
        {


            double valueSquared = PixelsPerSecond.DistanceSquared;
            if (valueSquared > maxValue * maxValue) return new Velocity(pixelsPerSecond: (PixelsPerSecond / PixelsPerSecond.Distance) * maxValue);
            if (valueSquared < minValue * minValue) return new Velocity(pixelsPerSecond: (PixelsPerSecond / PixelsPerSecond.Distance) * minValue);
            return this;
        }




        public new bool Equals(@Object other)
        {
            return other is Velocity && other.PixelsPerSecond == PixelsPerSecond;
        }




    }


    /// <Summary>
    /// A two dimensional velocity estimate.
    ///
    /// VelocityEstimates are computed by [VelocityTracker.getVelocityEstimate]. An
    /// estimate's [confidence] measures how well the velocity tracker's position
    /// data fit a straight line, [duration] is the time that elapsed between the
    /// first and last position sample used to compute the velocity, and [offset]
    /// is similarly the difference between the first and last positions.
    ///
    /// See also:
    ///
    ///  * [VelocityTracker], which computes [VelocityEstimate]s.
    ///  * [Velocity], which encapsulates (just) a velocity vector and provides some
    ///    useful velocity operations.
    /// </Summary>
    public class VelocityEstimate
    {
        /// <Summary>
        /// Creates a dimensional velocity estimate.
        ///
        /// [pixelsPerSecond], [confidence], [duration], and [offset] must not be null.
        /// </Summary>
        public VelocityEstimate(FlutterBinding.UI.Offset pixelsPerSecond = default(FlutterBinding.UI.Offset), double confidence = default(double), TimeSpan duration = default(TimeSpan), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.PixelsPerSecond = pixelsPerSecond;
            this.Confidence = confidence;
            this.Duration = duration;
            this.Offset = offset;
        }
        /// <Summary>
        /// The number of pixels per second of velocity in the x and y directions.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset PixelsPerSecond { get; set; }
        /// <Summary>
        /// A value between 0.0 and 1.0 that indicates how well [VelocityTracker]
        /// was able to fit a straight line to its position data.
        ///
        /// The value of this property is 1.0 for a perfect fit, 0.0 for a poor fit.
        /// </Summary>
        public virtual double Confidence { get; set; }
        /// <Summary>
        /// The time that elapsed between the first and last position sample used
        /// to compute [pixelsPerSecond].
        /// </Summary>
        public virtual TimeSpan Duration { get; set; }
        /// <Summary>
        /// The difference between the first and last position sample used
        /// to compute [pixelsPerSecond].
        /// </Summary>
        public virtual FlutterBinding.UI.Offset Offset { get; set; }

    }


    public class _PointAtTime
    {
        public _PointAtTime(FlutterBinding.UI.Offset point, TimeSpan time)
        : base()
        {
            this.Point = point;
            this.Time = time;
        }
        public virtual TimeSpan Time { get; set; }
        public virtual FlutterBinding.UI.Offset Point { get; set; }

    }

}
