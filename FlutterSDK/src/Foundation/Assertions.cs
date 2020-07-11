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
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
namespace FlutterSDK.Foundation.Assertions
{
    public delegate void FlutterExceptionHandler(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details);
    public delegate Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DiagnosticPropertiesTransformer(Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> properties);
    public delegate Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> InformationCollector();
    internal static class AssertionsDefaultClass
    {
        internal static void DebugPrintStack(StackTrace stackTrace = default(StackTrace), string label = default(string), int maxFrames = default(int))
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// A class that filters stack frames for additional filtering on
    /// [FlutterError.defaultStackFilter].
    /// </Summary>
    public interface IStackFilter
    {
        void Filter(List<FlutterSDK.Foundation.Stackframe.StackFrame> stackFrames, List<string> reasons);
    }


    internal interface I_ErrorDiagnostic
    {
        string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration));
    }


    /// <Summary>
    /// Partial information from a stack frame for stack filtering purposes.
    ///
    /// See also:
    ///
    ///  * [RepetitiveStackFrameFilter], which uses this class to compare against [StackFrame]s.
    /// </Summary>
    public class PartialStackFrame
    {
        #region constructors
        public PartialStackFrame(Pattern package = default(Pattern), string className = default(string), string method = default(string))
        : base()
        {
            this.Package = package;
            this.ClassName = className;
            this.Method = method; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Assertions.PartialStackFrame AsynchronousSuspension { get; set; }
        public virtual Pattern Package { get; set; }
        public virtual string ClassName { get; set; }
        public virtual string Method { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Tests whether the [StackFrame] matches the information in this
        /// [PartialStackFrame].
        /// </Summary>
        public virtual bool Matches(FlutterSDK.Foundation.Stackframe.StackFrame stackFrame) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A class that filters stack frames for additional filtering on
    /// [FlutterError.defaultStackFilter].
    /// </Summary>
    public class StackFilter
    {
        #region constructors
        public StackFilter()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        /// <Summary>
        /// Filters the list of [StackFrame]s by updating corrresponding indices in
        /// `reasons`.
        ///
        /// To elide a frame or number of frames, set the string
        /// </Summary>
        public virtual void Filter(List<FlutterSDK.Foundation.Stackframe.StackFrame> stackFrames, List<string> reasons) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A [StackFilter] that filters based on repeating lists of
    /// [PartialStackFrame]s.
    ///
    /// See also:
    ///
    ///   * [FlutterError.addDefaultStackFilter], a method to register additional
    ///     stack filters for [FlutterError.defaultStackFilter].
    ///   * [StackFrame], a class that can help with parsing stack frames.
    ///   * [PartialStackFrame], a class that helps match partial method information
    ///     to a stack frame.
    /// </Summary>
    public class RepetitiveStackFrameFilter : FlutterSDK.Foundation.Assertions.StackFilter
    {
        #region constructors
        public RepetitiveStackFrameFilter(List<FlutterSDK.Foundation.Assertions.PartialStackFrame> frames = default(List<FlutterSDK.Foundation.Assertions.PartialStackFrame>), string replacement = default(string))
        : base()
        {
            this.Frames = frames;
            this.Replacement = replacement; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Foundation.Assertions.PartialStackFrame> Frames { get; set; }
        public virtual string Replacement { get; set; }
        public virtual int NumFrames { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual List<string> _Replacements { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Filter(List<FlutterSDK.Foundation.Stackframe.StackFrame> stackFrames, List<string> reasons) { throw new NotImplementedException(); }


        private bool _MatchesFrames(List<FlutterSDK.Foundation.Stackframe.StackFrame> stackFrames) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ErrorDiagnostic : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<List<@Object>>
    {
        #region constructors
        public _ErrorDiagnostic(string message, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(null, new List<object>() { message }, showName: false, showSeparator: false, defaultValue: null, style: style, level: level)
        {
            throw new NotImplementedException();
        }
        internal static _ErrorDiagnostic _FromParts(List<@Object> messageParts, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        {
            var instance = new _ErrorDiagnostic(null, messageParts, showName: false, showSeparator: false, defaultValue: null, style: style, level: level); throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An explanation of the problem and its cause, any information that may help
    /// track down the problem, background information, etc.
    ///
    /// Use [ErrorDescription] for any part of an error message where neither
    /// [ErrorSummary] or [ErrorHint] is appropriate.
    ///
    /// See also:
    ///
    ///  * [ErrorSummary], which provides a short (one line) description of the
    ///    problem that was detected.
    ///  * [ErrorHint], which provides specific, non-obvious advice that may be
    ///    applicable.
    ///  * [FlutterError], which is the most common place to use an
    ///    [ErrorDescription].
    /// </Summary>
    public class ErrorDescription : FlutterSDK.Foundation.Assertions._ErrorDiagnostic
    {
        #region constructors
        public ErrorDescription(string message)
        : base(message, level: DiagnosticLevel.Info)
        {
            throw new NotImplementedException();
        }
        internal static ErrorDescription _FromParts(List<@Object> messageParts)
        {
            var instance = new ErrorDescription(messageParts, level: DiagnosticLevel.Info); throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A short (one line) description of the problem that was detected.
    ///
    /// Error summaries from the same source location should have little variance,
    /// so that they can be recognized as related. For example, they shouldn't
    /// include hash codes.
    ///
    /// A [FlutterError] must start with an [ErrorSummary] and may not contain
    /// multiple summaries.
    ///
    /// See also:
    ///
    ///  * [ErrorDescription], which provides an explanation of the problem and its
    ///    cause, any information that may help track down the problem, background
    ///    information, etc.
    ///  * [ErrorHint], which provides specific, non-obvious advice that may be
    ///    applicable.
    ///  * [FlutterError], which is the most common place to use an [ErrorSummary].
    /// </Summary>
    public class ErrorSummary : FlutterSDK.Foundation.Assertions._ErrorDiagnostic
    {
        #region constructors
        public ErrorSummary(string message)
        : base(message, level: DiagnosticLevel.Summary)
        {
            throw new NotImplementedException();
        }
        internal static ErrorSummary _FromParts(List<@Object> messageParts)
        {
            var instance = new ErrorSummary(messageParts, level: DiagnosticLevel.Summary); throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// An [ErrorHint] provides specific, non-obvious advice that may be applicable.
    ///
    /// If your message provides obvious advice that is always applicable it is an
    /// [ErrorDescription] not a hint.
    ///
    /// See also:
    ///
    ///  * [ErrorSummary], which provides a short (one line) description of the
    ///    problem that was detected.
    ///  * [ErrorDescription], which provides an explanation of the problem and its
    ///    cause, any information that may help track down the problem, background
    ///    information, etc.
    ///  * [FlutterError], which is the most common place to use an [ErrorHint].
    /// </Summary>
    public class ErrorHint : FlutterSDK.Foundation.Assertions._ErrorDiagnostic
    {
        #region constructors
        public ErrorHint(string message)
        : base(message, level: DiagnosticLevel.Hint)
        {
            throw new NotImplementedException();
        }
        internal static ErrorHint _FromParts(List<@Object> messageParts)
        {
            var instance = new ErrorHint(messageParts, level: DiagnosticLevel.Hint); throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// An [ErrorSpacer] creates an empty [DiagnosticsNode], that can be used to
    /// tune the spacing between other [DiagnosticsNode] objects.
    /// </Summary>
    public class ErrorSpacer : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<object>
    {
        #region constructors
        public ErrorSpacer()
        : base("", null, description: "", showName: false)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// Class for information provided to [FlutterExceptionHandler] callbacks.
    ///
    /// See [FlutterError.onError].
    /// </Summary>
    public class FlutterErrorDetails : IDiagnosticable
    {
        #region constructors
        public FlutterErrorDetails(object exception = default(object), StackTrace stack = default(StackTrace), string library = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), FlutterSDK.Foundation.Basictypes.IterableFilter<string> stackFilter = default(FlutterSDK.Foundation.Basictypes.IterableFilter<string>), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false)
        {
            this.Exception = exception;
            this.Stack = stack;
            this.Library = library;
            this.Context = context;
            this.StackFilter = stackFilter;
            this.InformationCollector = informationCollector;
            this.Silent = silent; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<object> PropertiesTransformers { get; set; }
        public virtual object Exception { get; set; }
        public virtual StackTrace Stack { get; set; }
        public virtual string Library { get; set; }
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode Context { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.IterableFilter<string> StackFilter { get; set; }
        public virtual FlutterSDK.Foundation.Assertions.InformationCollector InformationCollector { get; set; }
        public virtual bool Silent { get; set; }
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode Summary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Converts the [exception] to a string.
        ///
        /// This applies some additional logic to make [AssertionError] exceptions
        /// prettier, to handle exceptions that stringify to empty strings, to handle
        /// objects that don't inherit from [Exception] or [Error], and so forth.
        /// </Summary>
        public virtual string ExceptionAsString() { throw new NotImplementedException(); }


        private FlutterSDK.Foundation.Diagnostics.Diagnosticable _ExceptionToDiagnosticable() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }



        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Error class used to report Flutter-specific assertion failures and
    /// contract violations.
    ///
    /// See also:
    ///
    ///  * <https://flutter.dev/docs/testing/errors>, more information about error
    ///    handling in Flutter.
    /// </Summary>
    public class FlutterError : Error, IAssertionError, IDiagnosticableTreeMixin
    {
        #region constructors
        public FlutterError(string message)
        {
            throw new NotImplementedException();
        }
        public static FlutterError FromParts(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> diagnostics)
        {
            var instance = new FlutterError(); instance.Diagnostics = diagnostics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> Diagnostics { get; set; }
        public virtual FlutterSDK.Foundation.Assertions.FlutterExceptionHandler OnError { get; set; }
        internal virtual int _ErrorCount { get; set; }
        public virtual int WrapWidth { get; set; }
        internal virtual List<FlutterSDK.Foundation.Assertions.StackFilter> _StackFilters { get; set; }
        public virtual string Message { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Resets the count of errors used by [dumpErrorToConsole] to decide whether
        /// to show a complete error message or an abbreviated one.
        ///
        /// After this is called, the next error message will be shown in full.
        /// </Summary>
        public virtual void ResetErrorCount() { throw new NotImplementedException(); }


        /// <Summary>
        /// Prints the given exception details to the console.
        ///
        /// The first time this is called, it dumps a very verbose message to the
        /// console using [debugPrint].
        ///
        /// Subsequent calls only dump the first line of the exception, unless
        /// `forceReport` is set to true (in which case it dumps the verbose message).
        ///
        /// Call [resetErrorCount] to cause this method to go back to acting as if it
        /// had not been called before (so the next message is verbose again).
        ///
        /// The default behavior for the [onError] handler is to call this function.
        /// </Summary>
        public virtual void DumpErrorToConsole(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details, bool forceReport = false) { throw new NotImplementedException(); }


        /// <Summary>
        /// Adds a stack filtering function to [defaultStackFilter].
        ///
        /// For example, the framework adds common patterns of element building to
        /// elide tree-walking patterns in the stacktrace.
        ///
        /// Added filters are checked in order of addition. The first matching filter
        /// wins, and subsequent filters will not be checked.
        /// </Summary>
        public virtual void AddDefaultStackFilter(FlutterSDK.Foundation.Assertions.StackFilter filter) { throw new NotImplementedException(); }


        /// <Summary>
        /// Converts a stack to a string that is more readable by omitting stack
        /// frames that correspond to Dart internals.
        ///
        /// This is the default filter used by [dumpErrorToConsole] if the
        /// [FlutterErrorDetails] object has no [FlutterErrorDetails.stackFilter]
        /// callback.
        ///
        /// This function expects its input to be in the format used by
        /// [StackTrace.toString()]. The output of this function is similar to that
        /// format but the frame numbers will not be consecutive (frames are elided)
        /// and the final line may be prose rather than a stack frame.
        /// </Summary>
        public virtual Iterable<string> DefaultStackFilter(Iterable<string> frames) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }



        /// <Summary>
        /// Calls [onError] with the given details, unless it is null.
        /// </Summary>
        public virtual void ReportError(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Diagnostic with a [StackTrace] [value] suitable for displaying stack traces
    /// as part of a [FlutterError] object.
    /// </Summary>
    public class DiagnosticsStackTrace : FlutterSDK.Foundation.Diagnostics.DiagnosticsBlock
    {
        #region constructors
        public DiagnosticsStackTrace(string name, StackTrace stack, FlutterSDK.Foundation.Basictypes.IterableFilter<string> stackFilter = default(FlutterSDK.Foundation.Basictypes.IterableFilter<string>), bool showSeparator = true)
        : base(name: name, value: stack, properties: stack == null ? new List<DiagnosticsNode>() { } : (stackFilter ?? AssertionsDefaultClass.FlutterError.DefaultStackFilter)(stack.ToString().TrimEnd().Split('\n').ToList()).Map(_CreateStackFrame).ToList(), style: DiagnosticsTreeStyle.Flat, showSeparator: showSeparator, allowTruncate: true)
        {
            throw new NotImplementedException();
        }
        public static DiagnosticsStackTrace SingleFrame(string name, string frame = default(string), bool showSeparator = true)
        {
            var instance = new DiagnosticsStackTrace(name: name, properties: new List<DiagnosticsNode>() { _CreateStackFrame(frame) }, style: DiagnosticsTreeStyle.Whitespace, showSeparator: showSeparator); throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        private FlutterSDK.Foundation.Diagnostics.DiagnosticsNode _CreateStackFrame(string frame) { throw new NotImplementedException(); }

        #endregion
    }


    public class _FlutterErrorDetailsNode : FlutterSDK.Foundation.Diagnostics.DiagnosticableNode<FlutterSDK.Foundation.Assertions.FlutterErrorDetails>
    {
        #region constructors
        public _FlutterErrorDetailsNode(string name = default(string), FlutterSDK.Foundation.Assertions.FlutterErrorDetails value = default(FlutterSDK.Foundation.Assertions.FlutterErrorDetails), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        : base(name: name, value: value, style: style)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder Builder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods
        #endregion
    }

}
