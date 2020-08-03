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
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Willpopscope;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
namespace FlutterSDK.Gestures.Hittest
{
    internal static class HittestDefaultClass
    {
    }

    public interface IHitTestable { }

    public class HitTestable
    {

        /// <Summary>
        /// Check whether the given position hits this object.
        ///
        /// If this given position hits this object, consider adding a [HitTestEntry]
        /// to the given hit test result.
        /// </Summary>
        public virtual void HitTest(FlutterSDK.Gestures.Hittest.HitTestResult result, FlutterBinding.UI.Offset position)
        {
        }

    }
    public static class HitTestableMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IHitTestable, HitTestable> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IHitTestable, HitTestable>();
        static HitTestable GetOrCreate(IHitTestable instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new HitTestable();
                _table.Add(instance, value);
            }
            return (HitTestable)value;
        }
        public static void HitTest(this IHitTestable instance, FlutterSDK.Gestures.Hittest.HitTestResult result, FlutterBinding.UI.Offset position) => GetOrCreate(instance).HitTest(result, position);
    }


    public interface IHitTestDispatcher { }

    public class HitTestDispatcher
    {

        /// <Summary>
        /// Override this method to dispatch events.
        /// </Summary>
        public virtual void DispatchEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestResult result)
        {
        }

    }
    public static class HitTestDispatcherMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IHitTestDispatcher, HitTestDispatcher> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IHitTestDispatcher, HitTestDispatcher>();
        static HitTestDispatcher GetOrCreate(IHitTestDispatcher instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new HitTestDispatcher();
                _table.Add(instance, value);
            }
            return (HitTestDispatcher)value;
        }
        public static void DispatchEvent(this IHitTestDispatcher instance, FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestResult result) => GetOrCreate(instance).DispatchEvent(@event, result);
    }


    public interface IHitTestTarget { }

    public class HitTestTarget
    {

        /// <Summary>
        /// Override this method to receive events.
        /// </Summary>
        public virtual void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry)
        {
        }

    }
    public static class HitTestTargetMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IHitTestTarget, HitTestTarget> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IHitTestTarget, HitTestTarget>();
        static HitTestTarget GetOrCreate(IHitTestTarget instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new HitTestTarget();
                _table.Add(instance, value);
            }
            return (HitTestTarget)value;
        }
        public static void HandleEvent(this IHitTestTarget instance, FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Gestures.Hittest.HitTestEntry entry) => GetOrCreate(instance).HandleEvent(@event, entry);
    }


    /// <Summary>
    /// Data collected during a hit test about a specific [HitTestTarget].
    ///
    /// Subclass this object to pass additional information from the hit test phase
    /// to the event propagation phase.
    /// </Summary>
    public class HitTestEntry
    {
        /// <Summary>
        /// Creates a hit test entry.
        /// </Summary>
        public HitTestEntry(FlutterSDK.Gestures.Hittest.HitTestTarget target)
        {
            this.Target = target;
        }
        /// <Summary>
        /// The [HitTestTarget] encountered during the hit test.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Hittest.HitTestTarget Target { get; set; }
        internal virtual Matrix4 _Transform { get; set; }
        public virtual object Transform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    }


    /// <Summary>
    /// The result of performing a hit test.
    /// </Summary>
    public class HitTestResult
    {
        /// <Summary>
        /// Creates an empty hit test result.
        /// </Summary>
        public HitTestResult()
        : base()
        {

        }
        /// <Summary>
        /// Wraps `result` (usually a subtype of [HitTestResult]) to create a
        /// generic [HitTestResult].
        ///
        /// The [HitTestEntry]s added to the returned [HitTestResult] are also
        /// added to the wrapped `result` (both share the same underlying data
        /// structure to store [HitTestEntry]s).
        /// </Summary>
        public static HitTestResult Wrap(FlutterSDK.Gestures.Hittest.HitTestResult result)
        {
            var instance = new HitTestResult();
        }
        internal virtual List<FlutterSDK.Gestures.Hittest.HitTestEntry> _Path { get; set; }
        internal virtual Queue<object> _Transforms { get; set; }
        public virtual Iterable<FlutterSDK.Gestures.Hittest.HitTestEntry> Path { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Add a [HitTestEntry] to the path.
        ///
        /// The new entry is added at the end of the path, which means entries should
        /// be added in order from most specific to least specific, typically during an
        /// upward walk of the tree being hit tested.
        /// </Summary>
        public virtual void Add(FlutterSDK.Gestures.Hittest.HitTestEntry entry)
        {

            entry._Transform = _Transforms.IsEmpty() ? null : _Transforms.Last();
            _Path.Add(entry);
        }




        /// <Summary>
        /// Pushes a new transform matrix that is to be applied to all future
        /// [HitTestEntry]s added via [add] until it is removed via [popTransform].
        ///
        /// This method is only to be used by subclasses, which must provide
        /// coordinate space specific public wrappers around this function for their
        /// users (see [BoxHitTestResult.addWithPaintTransform] for such an example).
        ///
        /// The provided `transform` matrix should describe how to transform
        /// [PointerEvent]s from the coordinate space of the method caller to the
        /// coordinate space of its children. In most cases `transform` is derived
        /// from running the inverted result of [RenderObject.applyPaintTransform]
        /// through [PointerEvent.removePerspectiveTransform] to remove
        /// the perspective component.
        ///
        /// [HitTestable]s need to call this method indirectly through a convenience
        /// method defined on a subclass before hit testing a child that does not
        /// have the same origin as the parent. After hit testing the child,
        /// [popTransform] has to be called to remove the child-specific `transform`.
        ///
        /// See also:
        ///
        ///  * [BoxHitTestResult.addWithPaintTransform], which is a public wrapper
        ///    around this function for hit testing on [RenderBox]s.
        ///  * [SliverHitTestResult.addWithAxisOffset], which is a public wrapper
        ///    around this function for hit testing on [RenderSliver]s.
        /// </Summary>
        public virtual void PushTransform(Matrix4 transform)
        {


            _Transforms.Add(_Transforms.IsEmpty() ? transform : (transform * _Transforms.Last() as Matrix4));
        }




        /// <Summary>
        /// Removes the last transform added via [pushTransform].
        ///
        /// This method is only to be used by subclasses, which must provide
        /// coordinate space specific public wrappers around this function for their
        /// users (see [BoxHitTestResult.addWithPaintTransform] for such an example).
        ///
        /// This method must be called after hit testing is done on a child that
        /// required a call to [pushTransform].
        ///
        /// See also:
        ///
        ///  * [pushTransform], which describes the use case of this function pair in
        ///    more details.
        /// </Summary>
        public virtual void PopTransform()
        {

            _Transforms.RemoveLast();
        }




        private bool _DebugVectorMoreOrLessEquals(Vector4 a, Vector4 b, double epsilon = default(double))
        {
            bool result = true;

            return result;
        }




    }

}
