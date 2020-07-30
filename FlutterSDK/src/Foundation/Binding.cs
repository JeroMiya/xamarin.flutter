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
namespace FlutterSDK.Foundation.Binding
{
    public delegate Future<Dictionary<string, object>> ServiceExtensionCallback(Dictionary<string, string> parameters);
    internal static class BindingDefaultClass
    {
        internal static async Future<object> _ExitApplication()
        {
            Dart.IoDefaultClass.Exit(0);
        }



    }

    /// <Summary>
    /// Base class for mixins that provide singleton services (also known as
    /// "bindings").
    ///
    /// To use this class in an `on` clause of a mixin, inherit from it and implement
    /// [initInstances()]. The mixin is guaranteed to only be constructed once in
    /// the lifetime of the app (more precisely, it will assert if constructed twice
    /// in checked mode).
    ///
    /// The top-most layer used to write the application will have a concrete class
    /// that inherits from [BindingBase] and uses all the various [BindingBase]
    /// mixins (such as [ServicesBinding]). For example, the Widgets library in
    /// Flutter introduces a binding called [WidgetsFlutterBinding]. The relevant
    /// library defines how to create the binding. It could be implied (for example,
    /// [WidgetsFlutterBinding] is automatically started from [runApp]), or the
    /// application might be required to explicitly call the constructor.
    /// </Summary>
    public interface IBindingBase
    {
        void InitInstances();
        void InitServiceExtensions();
        Future<object> LockEvents(Func<Future> callback);
        void Unlocked();
        Future<object> ReassembleApplication();
        Future<object> PerformReassemble();
        void RegisterSignalServiceExtension(string name = default(string), FlutterSDK.Foundation.Basictypes.AsyncCallback callback = default(FlutterSDK.Foundation.Basictypes.AsyncCallback));
        void RegisterBoolServiceExtension(string name = default(string), FlutterSDK.Foundation.Basictypes.AsyncValueGetter<bool> getter = default(FlutterSDK.Foundation.Basictypes.AsyncValueGetter<bool>), FlutterSDK.Foundation.Basictypes.AsyncValueSetter<bool> setter = default(FlutterSDK.Foundation.Basictypes.AsyncValueSetter<bool>));
        void RegisterNumericServiceExtension(string name = default(string), FlutterSDK.Foundation.Basictypes.AsyncValueGetter<double> getter = default(FlutterSDK.Foundation.Basictypes.AsyncValueGetter<double>), FlutterSDK.Foundation.Basictypes.AsyncValueSetter<double> setter = default(FlutterSDK.Foundation.Basictypes.AsyncValueSetter<double>));
        void PostEvent(string eventKind, Dictionary<string, object> eventData);
        void RegisterStringServiceExtension(string name = default(string), FlutterSDK.Foundation.Basictypes.AsyncValueGetter<string> getter = default(FlutterSDK.Foundation.Basictypes.AsyncValueGetter<string>), FlutterSDK.Foundation.Basictypes.AsyncValueSetter<string> setter = default(FlutterSDK.Foundation.Basictypes.AsyncValueSetter<string>));
        void RegisterServiceExtension(string name = default(string), FlutterSDK.Foundation.Binding.ServiceExtensionCallback callback = default(FlutterSDK.Foundation.Binding.ServiceExtensionCallback));
        string ToString();
        Window Window { get; }
        bool Locked { get; }
    }


    /// <Summary>
    /// Base class for mixins that provide singleton services (also known as
    /// "bindings").
    ///
    /// To use this class in an `on` clause of a mixin, inherit from it and implement
    /// [initInstances()]. The mixin is guaranteed to only be constructed once in
    /// the lifetime of the app (more precisely, it will assert if constructed twice
    /// in checked mode).
    ///
    /// The top-most layer used to write the application will have a concrete class
    /// that inherits from [BindingBase] and uses all the various [BindingBase]
    /// mixins (such as [ServicesBinding]). For example, the Widgets library in
    /// Flutter introduces a binding called [WidgetsFlutterBinding]. The relevant
    /// library defines how to create the binding. It could be implied (for example,
    /// [WidgetsFlutterBinding] is automatically started from [runApp]), or the
    /// application might be required to explicitly call the constructor.
    /// </Summary>
    public class BindingBase
    {
        public BindingBase()
        {

            Developer.Dart.DeveloperDefaultClass.Timeline.StartSync("Framework initialization");

            InitInstances();


            InitServiceExtensions();

            Developer.Dart.DeveloperDefaultClass.PostEvent("Flutter.FrameworkInitialization", new Dictionary<string, string> { });
            Developer.Dart.DeveloperDefaultClass.Timeline.FinishSync();
        }


        internal virtual bool _DebugInitialized { get; set; }
        internal virtual bool _DebugServiceExtensionsRegistered { get; set; }
        internal virtual int _LockCount { get; set; }
        public virtual Window Window { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Locked { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// The initialization method. Subclasses override this method to hook into
        /// the platform and otherwise configure their services. Subclasses must call
        /// "super.initInstances()".
        ///
        /// By convention, if the service is to be provided as a singleton, it should
        /// be exposed as `MixinClassName.instance`, a static getter that returns
        /// `MixinClassName._instance`, a static field that is set by
        /// `initInstances()`.
        /// </Summary>
        public virtual void InitInstances()
        {


        }




        /// <Summary>
        /// Called when the binding is initialized, to register service
        /// extensions.
        ///
        /// Bindings that want to expose service extensions should overload
        /// this method to register them using calls to
        /// [registerSignalServiceExtension],
        /// [registerBoolServiceExtension],
        /// [registerNumericServiceExtension], and
        /// [registerServiceExtension] (in increasing order of complexity).
        ///
        /// Implementations of this method must call their superclass
        /// implementation.
        ///
        /// {@macro flutter.foundation.bindingBase.registerServiceExtension}
        ///
        /// See also:
        ///
        ///  * <https://github.com/dart-lang/sdk/blob/master/runtime/vm/service/service.md#rpcs-requests-and-responses>
        /// </Summary>
        public virtual void InitServiceExtensions()
        {


            if (!ConstantsDefaultClass.KReleaseMode && !ConstantsDefaultClass.KIsWeb)
            {
                RegisterSignalServiceExtension(name: "exit", callback: BindingDefaultClass._ExitApplication);
                RegisterServiceExtension(name: "saveCompilationTrace", callback: async (Dictionary<string, string> parameters) =>
                {
                    return new Dictionary<string, object> { { "value", Dart.UI.UiDefaultClass.SaveCompilationTrace() } };
                }
                );
            }



        }




        /// <Summary>
        /// Locks the dispatching of asynchronous events and callbacks until the
        /// callback's future completes.
        ///
        /// This causes input lag and should therefore be avoided when possible. It is
        /// primarily intended for use during non-user-interactive time such as to
        /// allow [reassembleApplication] to block input while it walks the tree
        /// (which it partially does asynchronously).
        ///
        /// The [Future] returned by the `callback` argument is returned by [lockEvents].
        /// </Summary>
        public virtual Future<object> LockEvents(Func<Future> callback)
        {
            Developer.Dart.DeveloperDefaultClass.Timeline.StartSync("Lock events");

            _LockCount += 1;
            Future<void> future = callback();

            future.WhenComplete(() =>
            {
                _LockCount -= 1;
                if (!Locked)
                {
                    Developer.Dart.DeveloperDefaultClass.Timeline.FinishSync();
                    Unlocked();
                }

            }
            );
            return future;
        }




        /// <Summary>
        /// Called by [lockEvents] when events get unlocked.
        ///
        /// This should flush any events that were queued while [locked] was true.
        /// </Summary>
        public virtual void Unlocked()
        {

        }




        /// <Summary>
        /// Cause the entire application to redraw, e.g. after a hot reload.
        ///
        /// This is used by development tools when the application code has changed,
        /// to cause the application to pick up any changed code. It can be triggered
        /// manually by sending the `ext.flutter.reassemble` service extension signal.
        ///
        /// This method is very computationally expensive and should not be used in
        /// production code. There is never a valid reason to cause the entire
        /// application to repaint in production. All aspects of the Flutter framework
        /// know how to redraw when necessary. It is only necessary in development
        /// when the code is literally changed on the fly (e.g. in hot reload) or when
        /// debug flags are being toggled.
        ///
        /// While this method runs, events are locked (e.g. pointer events are not
        /// dispatched).
        ///
        /// Subclasses (binding classes) should override [performReassemble] to react
        /// to this method being called. This method itself should not be overridden.
        /// </Summary>
        public virtual Future<object> ReassembleApplication()
        {
            return LockEvents(PerformReassemble);
        }




        /// <Summary>
        /// This method is called by [reassembleApplication] to actually cause the
        /// application to reassemble, e.g. after a hot reload.
        ///
        /// Bindings are expected to use this method to re-register anything that uses
        /// closures, so that they do not keep pointing to old code, and to flush any
        /// caches of previously computed values, in case the new code would compute
        /// them differently. For example, the rendering layer triggers the entire
        /// application to repaint when this is called.
        ///
        /// Do not call this method directly. Instead, use [reassembleApplication].
        /// </Summary>
        public virtual Future<object> PerformReassemble()
        {
            AssertionsDefaultClass.FlutterError.ResetErrorCount();
            return Future<void>.Value();
        }




        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.name"), which takes no arguments and returns
        /// no value.
        ///
        /// Calls the `callback` callback when the service extension is called.
        ///
        /// {@macro flutter.foundation.bindingBase.registerServiceExtension}
        /// </Summary>
        public virtual void RegisterSignalServiceExtension(string name = default(string), FlutterSDK.Foundation.Basictypes.AsyncCallback callback = default(FlutterSDK.Foundation.Basictypes.AsyncCallback))
        {


            RegisterServiceExtension(name: name, callback: async (Dictionary<string, string> parameters) =>
            {
                await callback();
                return new Dictionary<string, object> { };
            }
            );
        }




        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.name"), which takes a single argument
        /// "enabled" which can have the value "true" or the value "false"
        /// or can be omitted to read the current value. (Any value other
        /// than "true" is considered equivalent to "false". Other arguments
        /// are ignored.)
        ///
        /// Calls the `getter` callback to obtain the value when
        /// responding to the service extension method being called.
        ///
        /// Calls the `setter` callback with the new value when the
        /// service extension method is called with a new value.
        ///
        /// {@macro flutter.foundation.bindingBase.registerServiceExtension}
        /// </Summary>
        public virtual void RegisterBoolServiceExtension(string name = default(string), FlutterSDK.Foundation.Basictypes.AsyncValueGetter<bool> getter = default(FlutterSDK.Foundation.Basictypes.AsyncValueGetter<bool>), FlutterSDK.Foundation.Basictypes.AsyncValueSetter<bool> setter = default(FlutterSDK.Foundation.Basictypes.AsyncValueSetter<bool>))
        {



            RegisterServiceExtension(name: name, callback: async (Dictionary<string, string> parameters) =>
            {
                if (parameters.ContainsKey("enabled"))
                {
                    await setter(parameters["enabled"] == "true");
                    _PostExtensionStateChangedEvent(name, await getter() ? "true" : "false");
                }

                return new Dictionary<string, object> { { "enabled", await getter() ? "true" : "false" } };
            }
            );
        }




        /// <Summary>
        /// Registers a service extension method with the given name (full
        /// name "ext.flutter.name"), which takes a single argument with the
        /// same name as the method which, if present, must have a value
        /// that can be parsed by [double.parse], and can be omitted to read
        /// the current value. (Other arguments are ignored.)
        ///
        /// Calls the `getter` callback to obtain the value when
        /// responding to the service extension method being called.
        ///
        /// Calls the `setter` callback with the new value when the
        /// service extension method is called with a new value.
        ///
        /// {@macro flutter.foundation.bindingBase.registerServiceExtension}
        /// </Summary>
        public virtual void RegisterNumericServiceExtension(string name = default(string), FlutterSDK.Foundation.Basictypes.AsyncValueGetter<double> getter = default(FlutterSDK.Foundation.Basictypes.AsyncValueGetter<double>), FlutterSDK.Foundation.Basictypes.AsyncValueSetter<double> setter = default(FlutterSDK.Foundation.Basictypes.AsyncValueSetter<double>))
        {



            RegisterServiceExtension(name: name, callback: async (Dictionary<string, string> parameters) =>
            {
                if (parameters.ContainsKey(name))
                {
                    await setter(Dart.CoreDefaultClass.Double.Parse(parameters[name]));
                    _PostExtensionStateChangedEvent(name, (await getter()).ToString());
                }

                return new Dictionary<string, object> { { name, (await getter()).ToString() } };
            }
            );
        }




        /// <Summary>
        /// Sends an event when a service extension's state is changed.
        ///
        /// Clients should listen for this event to stay aware of the current service
        /// extension state. Any service extension that manages a state should call
        /// this method on state change.
        ///
        /// `value` reflects the newly updated service extension value.
        ///
        /// This will be called automatically for service extensions registered via
        /// [registerBoolServiceExtension], [registerNumericServiceExtension], or
        /// [registerStringServiceExtension].
        /// </Summary>
        private void _PostExtensionStateChangedEvent(string name, object value)
        {
            PostEvent("Flutter.ServiceExtensionStateChanged", new Dictionary<string, object> { { "extension", $"'ext.flutter.{name}'" }{ "value", value } });
        }




        /// <Summary>
        /// All events dispatched by a [BindingBase] use this method instead of
        /// calling [developer.postEvent] directly so that tests for [BindingBase]
        /// can track which events were dispatched by overriding this method.
        /// </Summary>
        public virtual void PostEvent(string eventKind, Dictionary<string, object> eventData)
        {
            Developer.Dart.DeveloperDefaultClass.PostEvent(eventKind, eventData);
        }




        /// <Summary>
        /// Registers a service extension method with the given name (full name
        /// "ext.flutter.name"), which optionally takes a single argument with the
        /// name "value". If the argument is omitted, the value is to be read,
        /// otherwise it is to be set. Returns the current value.
        ///
        /// Calls the `getter` callback to obtain the value when
        /// responding to the service extension method being called.
        ///
        /// Calls the `setter` callback with the new value when the
        /// service extension method is called with a new value.
        ///
        /// {@macro flutter.foundation.bindingBase.registerServiceExtension}
        /// </Summary>
        public virtual void RegisterStringServiceExtension(string name = default(string), FlutterSDK.Foundation.Basictypes.AsyncValueGetter<string> getter = default(FlutterSDK.Foundation.Basictypes.AsyncValueGetter<string>), FlutterSDK.Foundation.Basictypes.AsyncValueSetter<string> setter = default(FlutterSDK.Foundation.Basictypes.AsyncValueSetter<string>))
        {



            RegisterServiceExtension(name: name, callback: async (Dictionary<string, string> parameters) =>
            {
                if (parameters.ContainsKey("value"))
                {
                    await setter(parameters["value"]);
                    _PostExtensionStateChangedEvent(name, await getter());
                }

                return new Dictionary<string, object> { { "value", await getter() } };
            }
            );
        }




        /// <Summary>
        /// Registers a service extension method with the given name (full name
        /// "ext.flutter.name").
        ///
        /// The given callback is called when the extension method is called. The
        /// callback must return a [Future] that either eventually completes to a
        /// return value in the form of a name/value map where the values can all be
        /// converted to JSON using `json.encode()` (see [JsonEncoder]), or fails. In
        /// case of failure, the failure is reported to the remote caller and is
        /// dumped to the logs.
        ///
        /// The returned map will be mutated.
        ///
        /// {@template flutter.foundation.bindingBase.registerServiceExtension}
        /// A registered service extension can only be activated if the vm-service
        /// is included in the build, which only happens in debug and profile mode.
        /// Although a service extension cannot be used in release mode its code may
        /// still be included in the Dart snapshot and blow up binary size if it is
        /// not wrapped in a guard that allows the tree shaker to remove it (see
        /// sample code below).
        ///
        /// {@tool snippet}
        /// The following code registers a service extension that is only included in
        /// debug builds.
        ///
        /// ```dart
        /// void myRegistrationFunction() {
        ///   assert(() {
        ///     // Register your service extension here.
        ///     return true;
        ///   }());
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// {@tool snippet}
        /// A service extension registered with the following code snippet is
        /// available in debug and profile mode.
        ///
        /// ```dart
        /// void myRegistrationFunction() {
        ///   // kReleaseMode is defined in the 'flutter/foundation.dart' package.
        ///   if (!kReleaseMode) {
        ///     // Register your service extension here.
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// Both guards ensure that Dart's tree shaker can remove the code for the
        /// service extension in release builds.
        /// {@endtemplate}
        /// </Summary>
        public virtual void RegisterServiceExtension(string name = default(string), FlutterSDK.Foundation.Binding.ServiceExtensionCallback callback = default(FlutterSDK.Foundation.Binding.ServiceExtensionCallback))
        {


            string methodName = $"'ext.flutter.{name}'";
            Developer.Dart.DeveloperDefaultClass.RegisterExtension(methodName, async (string method, Dictionary<string, string> parameters) =>
            {


            await DebugDefaultClass.DebugInstrumentAction("Wait for outer event loop", () =>
            {
                return Future<void>.Delayed(Dart.CoreDefaultClass.Duration.Zero);
            }
            );
            object caughtException = default(object);
            StackTrace caughtStack = default(StackTrace);
            Dictionary<string, object> result = default(Dictionary<string, object>);
            try
            {
                result = await callback(parameters);
            }
            catch (exception,stack){
                caughtException = exception;
                caughtStack = stack;
            }

            if (caughtException == null)
            {
                result["type"] = "_extensionType";
                result["method"] = method;
                return Developer.Dart.DeveloperDefaultClass.ServiceExtensionResponse.Result(Dart.ConvertDefaultClass.Json.Encode(result));
            }
            else
            {
                AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: caughtException, stack: caughtStack, context: new ErrorDescription($"'during a service extension callback for "{ method }"'")));
                return Developer.Dart.DeveloperDefaultClass.ServiceExtensionResponse.Error(Developer.Dart.DeveloperDefaultClass.ServiceExtensionResponse.ExtensionError, Dart.ConvertDefaultClass.Json.Encode(new Dictionary<string, string> { { "exception", caughtException.ToString() }{ "stack", caughtStack.ToString() }{ "method", method } }));
            }

        }
);
}




}

}
