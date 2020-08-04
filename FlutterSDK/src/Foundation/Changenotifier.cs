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
namespace FlutterSDK.Foundation.Changenotifier
{
    internal static class ChangenotifierDefaultClass
    {
    }

    /// <Summary>
    /// An object that maintains a list of listeners.
    ///
    /// The listeners are typically used to notify clients that the object has been
    /// updated.
    ///
    /// There are two variants of this interface:
    ///
    ///  * [ValueListenable], an interface that augments the [Listenable] interface
    ///    with the concept of a _current value_.
    ///
    ///  * [Animation], an interface that augments the [ValueListenable] interface
    ///    to add the concept of direction (forward or reverse).
    ///
    /// Many classes in the Flutter API use or implement these interfaces. The
    /// following subclasses are especially relevant:
    ///
    ///  * [ChangeNotifier], which can be subclassed or mixed in to create objects
    ///    that implement the [Listenable] interface.
    ///
    ///  * [ValueNotifier], which implements the [ValueListenable] interface with
    ///    a mutable value that triggers the notifications when modified.
    ///
    /// The terms "notify clients", "send notifications", "trigger notifications",
    /// and "fire notifications" are used interchangeably.
    ///
    /// See also:
    ///
    ///  * [AnimatedBuilder], a widget that uses a builder callback to rebuild
    ///    whenever a given [Listenable] triggers its notifications. This widget is
    ///    commonly used with [Animation] subclasses, hence its name, but is by no
    ///    means limited to animations, as it can be used with any [Listenable]. It
    ///    is a subclass of [AnimatedWidget], which can be used to create widgets
    ///    that are driven from a [Listenable].
    ///  * [ValueListenableBuilder], a widget that uses a builder callback to
    ///    rebuild whenever a [ValueListenable] object triggers its notifications,
    ///    providing the builder with the value of the object.
    ///  * [InheritedNotifier], an abstract superclass for widgets that use a
    ///    [Listenable]'s notifications to trigger rebuilds in descendant widgets
    ///    that declare a dependency on them, using the [InheritedWidget] mechanism.
    ///  * [new Listenable.merge], which creates a [Listenable] that triggers
    ///    notifications whenever any of a list of other [Listenable]s trigger their
    ///    notifications.
    /// </Summary>
    public interface IListenable
    {
        void AddListener(VoidCallback listener);
        void RemoveListener(VoidCallback listener);
    }


    /// <Summary>
    /// An interface for subclasses of [Listenable] that expose a [value].
    ///
    /// This interface is implemented by [ValueNotifier<T>] and [Animation<T>], and
    /// allows other APIs to accept either of those implementations interchangeably.
    /// </Summary>
    public interface IValueListenable<T>
    {
        T Value { get; }
    }


    public interface IChangeNotifier { }

    public class ChangeNotifier : IListenable
    {
        internal virtual FlutterSDK.Foundation.Observerlist.ObserverList<object> _Listeners { get; set; }
        public virtual bool HasListeners { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private bool _DebugAssertNotDisposed()
        {

            return true;
        }




        /// <Summary>
        /// Register a closure to be called when the object changes.
        ///
        /// This method must not be called after [dispose] has been called.
        /// </Summary>
        public new void AddListener(VoidCallback listener)
        {

            _Listeners.Add(listener);
        }




        /// <Summary>
        /// Remove a previously registered closure from the list of closures that are
        /// notified when the object changes.
        ///
        /// If the given listener is not registered, the call is ignored.
        ///
        /// This method must not be called after [dispose] has been called.
        ///
        /// If a listener had been added twice, and is removed once during an
        /// iteration (i.e. in response to a notification), it will still be called
        /// again. If, on the other hand, it is removed as many times as it was
        /// registered, then it will no longer be called. This odd behavior is the
        /// result of the [ChangeNotifier] not being able to determine which listener
        /// is being removed, since they are identical, and therefore conservatively
        /// still calling all the listeners when it knows that any are still
        /// registered.
        ///
        /// This surprising behavior can be unexpectedly observed when registering a
        /// listener on two separate objects which are both forwarding all
        /// registrations to a common upstream object.
        /// </Summary>
        public new void RemoveListener(VoidCallback listener)
        {

            _Listeners.Remove(listener);
        }




        /// <Summary>
        /// Discards any resources used by the object. After this is called, the
        /// object is not in a usable state and should be discarded (calls to
        /// [addListener] and [removeListener] will throw after the object is
        /// disposed).
        ///
        /// This method should only be called by the object's owner.
        /// </Summary>
        public virtual void Dispose()
        {

            _Listeners = null;
        }




        /// <Summary>
        /// Call all the registered listeners.
        ///
        /// Call this method whenever the object changes, to notify any clients the
        /// object may have. Listeners that are added during this iteration will not
        /// be visited. Listeners that are removed during this iteration will not be
        /// visited after they are removed.
        ///
        /// Exceptions thrown by listeners will be caught and reported using
        /// [FlutterError.reportError].
        ///
        /// This method must not be called after [dispose] has been called.
        ///
        /// Surprising behavior can result when reentrantly removing a listener (i.e.
        /// in response to a notification) that has been registered multiple times.
        /// See the discussion at [removeListener].
        /// </Summary>
        public virtual void NotifyListeners()
        {

            if (_Listeners != null)
            {
                List<VoidCallback> localListeners = List<VoidCallback>.From(_Listeners);
                foreach (VoidCallback listener in localListeners)
                {
                    try
                    {
                        if (_Listeners.Contains(listener)) listener();
                    }
                    catch (exception,stack){
                        AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, stack: stack, library: "foundation library", context: new ErrorDescription($"'while dispatching notifications for {GetType()}'"), informationCollector: () =>
                        {
                            yield return new DiagnosticsProperty<ChangeNotifier>($"'The {GetType()} sending notification was'", this, style: DiagnosticsTreeStyle.ErrorProperty);
                        }
                        ));
                    }

                    }

                }

            }



        }
        public static class ChangeNotifierMixin
        {
            static System.Runtime.CompilerServices.ConditionalWeakTable<IChangeNotifier, ChangeNotifier> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IChangeNotifier, ChangeNotifier>();
            static ChangeNotifier GetOrCreate(IChangeNotifier instance)
            {
                if (!_table.TryGetValue(instance, out var value))
                {
                    value = new ChangeNotifier();
                    _table.Add(instance, value);
                }
                return (ChangeNotifier)value;
            }
            public static bool HasListenersProperty(this IChangeNotifier instance) => GetOrCreate(instance).HasListeners;
            public static void AddListener(this IChangeNotifier instance, VoidCallback listener) => GetOrCreate(instance).AddListener(listener);
            public static void RemoveListener(this IChangeNotifier instance, VoidCallback listener) => GetOrCreate(instance).RemoveListener(listener);
            public static void Dispose(this IChangeNotifier instance) => GetOrCreate(instance).Dispose();
            public static void NotifyListeners(this IChangeNotifier instance) => GetOrCreate(instance).NotifyListeners();
        }


        /// <Summary>
        /// An object that maintains a list of listeners.
        ///
        /// The listeners are typically used to notify clients that the object has been
        /// updated.
        ///
        /// There are two variants of this interface:
        ///
        ///  * [ValueListenable], an interface that augments the [Listenable] interface
        ///    with the concept of a _current value_.
        ///
        ///  * [Animation], an interface that augments the [ValueListenable] interface
        ///    to add the concept of direction (forward or reverse).
        ///
        /// Many classes in the Flutter API use or implement these interfaces. The
        /// following subclasses are especially relevant:
        ///
        ///  * [ChangeNotifier], which can be subclassed or mixed in to create objects
        ///    that implement the [Listenable] interface.
        ///
        ///  * [ValueNotifier], which implements the [ValueListenable] interface with
        ///    a mutable value that triggers the notifications when modified.
        ///
        /// The terms "notify clients", "send notifications", "trigger notifications",
        /// and "fire notifications" are used interchangeably.
        ///
        /// See also:
        ///
        ///  * [AnimatedBuilder], a widget that uses a builder callback to rebuild
        ///    whenever a given [Listenable] triggers its notifications. This widget is
        ///    commonly used with [Animation] subclasses, hence its name, but is by no
        ///    means limited to animations, as it can be used with any [Listenable]. It
        ///    is a subclass of [AnimatedWidget], which can be used to create widgets
        ///    that are driven from a [Listenable].
        ///  * [ValueListenableBuilder], a widget that uses a builder callback to
        ///    rebuild whenever a [ValueListenable] object triggers its notifications,
        ///    providing the builder with the value of the object.
        ///  * [InheritedNotifier], an abstract superclass for widgets that use a
        ///    [Listenable]'s notifications to trigger rebuilds in descendant widgets
        ///    that declare a dependency on them, using the [InheritedWidget] mechanism.
        ///  * [new Listenable.merge], which creates a [Listenable] that triggers
        ///    notifications whenever any of a list of other [Listenable]s trigger their
        ///    notifications.
        /// </Summary>
        public class Listenable
        {
            /// <Summary>
            /// Abstract const constructor. This constructor enables subclasses to provide
            /// const constructors so that they can be used in const expressions.
            /// </Summary>
            public Listenable()
            {

            }
            /// <Summary>
            /// Return a [Listenable] that triggers when any of the given [Listenable]s
            /// themselves trigger.
            ///
            /// The list must not be changed after this method has been called. Doing so
            /// will lead to memory leaks or exceptions.
            ///
            /// The list may contain nulls; they are ignored.
            /// </Summary>
            public static Listenable Merge(List<FlutterSDK.Foundation.Changenotifier.Listenable> listenables)
            {

            }

            /// <Summary>
            /// Register a closure to be called when the object notifies its listeners.
            /// </Summary>
            public virtual void AddListener(VoidCallback listener)
            {
            }


            /// <Summary>
            /// Remove a previously registered closure from the list of closures that the
            /// object notifies.
            /// </Summary>
            public virtual void RemoveListener(VoidCallback listener)
            {
            }

        }


        /// <Summary>
        /// An interface for subclasses of [Listenable] that expose a [value].
        ///
        /// This interface is implemented by [ValueNotifier<T>] and [Animation<T>], and
        /// allows other APIs to accept either of those implementations interchangeably.
        /// </Summary>
        public class ValueListenable<T> : FlutterSDK.Foundation.Changenotifier.Listenable
        {
            /// <Summary>
            /// Abstract const constructor. This constructor enables subclasses to provide
            /// const constructors so that they can be used in const expressions.
            /// </Summary>
            public ValueListenable()
            {

            }
            public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        }


        public class _MergingListenable : FlutterSDK.Foundation.Changenotifier.Listenable
        {
            public _MergingListenable(List<FlutterSDK.Foundation.Changenotifier.Listenable> _children)
            {
                this._Children = _children;
            }
            internal virtual List<FlutterSDK.Foundation.Changenotifier.Listenable> _Children { get; set; }

            public new void AddListener(VoidCallback listener)
            {
                foreach (Listenable child in _Children)
                {
                    child?.AddListener(listener);
                }

            }




            public new void RemoveListener(VoidCallback listener)
            {
                foreach (Listenable child in _Children)
                {
                    child?.RemoveListener(listener);
                }

            }




        }


        /// <Summary>
        /// A [ChangeNotifier] that holds a single value.
        ///
        /// When [value] is replaced with something that is not equal to the old
        /// value as evaluated by the equality operator ==, this class notifies its
        /// listeners.
        /// </Summary>
        public class ValueNotifier<T> : FlutterSDK.Foundation.Changenotifier.ChangeNotifier, IValueListenable<T>
        {
            /// <Summary>
            /// Creates a [ChangeNotifier] that wraps this value.
            /// </Summary>
            public ValueNotifier(T _value)
            {
                this._Value = _value;
            }
            internal virtual T _Value { get; set; }
            public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        }

    }
