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
namespace FlutterSDK.Foundation.Assertions
{
    public delegate void FlutterExceptionHandler(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details);
    public delegate Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DiagnosticPropertiesTransformer(Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> properties);
    public delegate Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> InformationCollector();
    internal static class AssertionsDefaultClass
    {
        internal static void DebugPrintStack(StackTrace stackTrace = default(StackTrace), string label = default(string), int maxFrames = default(int))
        {
            if (label != null) PrintDefaultClass.DebugPrint(label);
            stackTrace = (stackTrace == null ? Dart.CoreDefaultClass.StackTrace.Current : stackTrace);
            Iterable<string> lines = stackTrace.ToString().TrimEnd().Split('\n').ToList();
            if (ConstantsDefaultClass.KIsWeb && lines.IsNotEmpty)
            {
                lines = lines.SkipWhile((string line) =>
                {
                    return line.Contains("StackTrace.current") || line.Contains("dart:sdk_internal");
                }
                );
            }

            if (maxFrames != null) lines = lines.Take(maxFrames);
            PrintDefaultClass.DebugPrint(AssertionsDefaultClass.FlutterError.DefaultStackFilter(lines).Join('\n'));
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
        public PartialStackFrame(Pattern package = default(Pattern), string className = default(string), string method = default(string))
        : base()
        {
            this.Package = package;
            this.ClassName = className;
            this.Method = method;
        }
        public virtual FlutterSDK.Foundation.Assertions.PartialStackFrame AsynchronousSuspension { get; set; }
        public virtual Pattern Package { get; set; }
        public virtual string ClassName { get; set; }
        public virtual string Method { get; set; }

        /// <Summary>
        /// Tests whether the [StackFrame] matches the information in this
        /// [PartialStackFrame].
        /// </Summary>
        public virtual bool Matches(FlutterSDK.Foundation.Stackframe.StackFrame stackFrame)
        {
            string stackFramePackage = $"'{stackFrame.PackageScheme}:{stackFrame.Package}/{stackFrame.PackagePath}'";
            if (ConstantsDefaultClass.KIsWeb)
            {
                return Package.AllMatches(stackFramePackage).IsNotEmpty && stackFrame.Method == (Method.StartsWith('_') ? $"'[{Method}]'" : Method);
            }

            return Package.AllMatches(stackFramePackage).IsNotEmpty && stackFrame.Method == Method && stackFrame.ClassName == ClassName;
        }



    }


    /// <Summary>
    /// A class that filters stack frames for additional filtering on
    /// [FlutterError.defaultStackFilter].
    /// </Summary>
    public class StackFilter
    {
        public StackFilter()
        {

        }

        /// <Summary>
        /// Filters the list of [StackFrame]s by updating corrresponding indices in
        /// `reasons`.
        ///
        /// To elide a frame or number of frames, set the string
        /// </Summary>
        public virtual void Filter(List<FlutterSDK.Foundation.Stackframe.StackFrame> stackFrames, List<string> reasons)
        {
        }

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
        public RepetitiveStackFrameFilter(List<FlutterSDK.Foundation.Assertions.PartialStackFrame> frames = default(List<FlutterSDK.Foundation.Assertions.PartialStackFrame>), string replacement = default(string))
        : base()
        {
            this.Frames = frames;
            this.Replacement = replacement;
        }
        public virtual List<FlutterSDK.Foundation.Assertions.PartialStackFrame> Frames { get; set; }
        public virtual string Replacement { get; set; }
        public virtual int NumFrames { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual List<string> _Replacements { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Filter(List<FlutterSDK.Foundation.Stackframe.StackFrame> stackFrames, List<string> reasons)
        {
            for (int index = 0; index < stackFrames.Count - NumFrames; index += 1)
            {
                if (_MatchesFrames(stackFrames.Skip(index).Take(NumFrames).ToList()))
                {
                    reasons.SetRange(index, index + NumFrames, _Replacements);
                    index += NumFrames - 1;
                }

            }

        }




        private bool _MatchesFrames(List<FlutterSDK.Foundation.Stackframe.StackFrame> stackFrames)
        {
            if (stackFrames.Count < NumFrames)
            {
                return false;
            }

            for (int index = 0; index < stackFrames.Count; index++)
            {
                if (!Frames[index].Matches(stackFrames[index]))
                {
                    return false;
                }

            }

            return true;
        }



    }


    public class _ErrorDiagnostic : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<List<@Object>>
    {
        public _ErrorDiagnostic(string message, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(null, new List<object>() { message }, showName: false, showSeparator: false, defaultValue: null, style: style, level: level)
        {

        }
        internal static _ErrorDiagnostic _FromParts(List<@Object> messageParts, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        {
            var instance = new _ErrorDiagnostic(null, messageParts, showName: false, showSeparator: false, defaultValue: null, style: style, level: level);
        }

        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
        {
            return Value.Join("");
        }



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
        public ErrorDescription(string message)
        : base(message, level: DiagnosticLevel.Info)
        {

        }
        internal static ErrorDescription _FromParts(List<@Object> messageParts)
        {
            var instance = new ErrorDescription(messageParts, level: DiagnosticLevel.Info);
        }
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
        public ErrorSummary(string message)
        : base(message, level: DiagnosticLevel.Summary)
        {

        }
        internal static ErrorSummary _FromParts(List<@Object> messageParts)
        {
            var instance = new ErrorSummary(messageParts, level: DiagnosticLevel.Summary);
        }
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
        public ErrorHint(string message)
        : base(message, level: DiagnosticLevel.Hint)
        {

        }
        internal static ErrorHint _FromParts(List<@Object> messageParts)
        {
            var instance = new ErrorHint(messageParts, level: DiagnosticLevel.Hint);
        }
    }


    /// <Summary>
    /// An [ErrorSpacer] creates an empty [DiagnosticsNode], that can be used to
    /// tune the spacing between other [DiagnosticsNode] objects.
    /// </Summary>
    public class ErrorSpacer : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<object>
    {
        public ErrorSpacer()
        : base("", null, description: "", showName: false)
        {

        }
    }


    /// <Summary>
    /// Class for information provided to [FlutterExceptionHandler] callbacks.
    ///
    /// See [FlutterError.onError].
    /// </Summary>
    public class FlutterErrorDetails : IDiagnosticable
    {
        public FlutterErrorDetails(object exception = default(object), StackTrace stack = default(StackTrace), string library = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsNode context = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode), FlutterSDK.Foundation.Basictypes.IterableFilter<string> stackFilter = default(FlutterSDK.Foundation.Basictypes.IterableFilter<string>), FlutterSDK.Foundation.Assertions.InformationCollector informationCollector = default(FlutterSDK.Foundation.Assertions.InformationCollector), bool silent = false)
        {
            this.Exception = exception;
            this.Stack = stack;
            this.Library = library;
            this.Context = context;
            this.StackFilter = stackFilter;
            this.InformationCollector = informationCollector;
            this.Silent = silent;
        }
        public virtual List<object> PropertiesTransformers { get; set; }
        public virtual object Exception { get; set; }
        public virtual StackTrace Stack { get; set; }
        public virtual string Library { get; set; }
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode Context { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.IterableFilter<string> StackFilter { get; set; }
        public virtual FlutterSDK.Foundation.Assertions.InformationCollector InformationCollector { get; set; }
        public virtual bool Silent { get; set; }
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode Summary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Converts the [exception] to a string.
        ///
        /// This applies some additional logic to make [AssertionError] exceptions
        /// prettier, to handle exceptions that stringify to empty strings, to handle
        /// objects that don't inherit from [Exception] or [Error], and so forth.
        /// </Summary>
        public virtual string ExceptionAsString()
        {
            string longMessage = default(string);
            if (Exception is AssertionError)
            {
                object message = ((AssertionError)Exception).Message;
                string fullMessage = ((AssertionError)Exception).ToString();
                if (((String)message) is string && ((String)message) != fullMessage)
                {
                    if (fullMessage.Length > ((String)message).Length)
                    {
                        int position = fullMessage.LastIndexOf(((String)message));
                        if (position == fullMessage.Length - ((String)message).Length && position > 2 && fullMessage.Substring(position - 2, position) == ": ")
                        {
                            string body = fullMessage.Substring(0, position - 2);
                            int splitPoint = body.IndexOf(" Failed assertion:");
                            if (splitPoint >= 0)
                            {
                                body = $"'{body.Substring(0, splitPoint)}\n{body.Substring(splitPoint + 1)}'";
                            }

                            longMessage = $"'{message.TrimEnd()}\n{body}'";
                        }

                    }

                }

                longMessage = (longMessage == null ? fullMessage : longMessage);
            }
            else if (Exception is string)
            {
                longMessage = ((String)Exception) as string;
            }
            else if (Exception is Error || Exception is Exception)
            {
                longMessage = ((Error)Exception).ToString();
            }
            else
            {
                longMessage = $"'  {Exception.ToString()}'";
            }

            longMessage = longMessage.TrimEnd();
            if (longMessage.IsEmpty()) longMessage = "  <no message available>";
            return longMessage;
        }




        private FlutterSDK.Foundation.Diagnostics.Diagnosticable _ExceptionToDiagnosticable()
        {
            if (Exception is FlutterError)
            {
                return ((FlutterError)Exception) as FlutterError;
            }

            if (Exception is AssertionError && Exception.Message is FlutterError)
            {
                return ((FlutterError)Exception.Message) as FlutterError;
            }

            return null;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            DiagnosticsNode verb = new ErrorDescription($"'thrown{Context != null ? new ErrorDescription($"" {Context}""):""}'");
            Diagnosticable diagnosticable = _ExceptionToDiagnosticable();
            if (Exception is NullThrownError)
            {
                properties.Add(new ErrorDescription($"'The null value was {verb}.'"));
            }
            else if (Exception is Num)
            {
                properties.Add(new ErrorDescription($"'The number {((Num)Exception)} was {verb}.'"));
            }
            else
            {
                DiagnosticsNode errorName = default(DiagnosticsNode);
                if (((AssertionError)Exception) is AssertionError)
                {
                    errorName = new ErrorDescription("assertion");
                }
                else if (Exception is string)
                {
                    errorName = new ErrorDescription("message");
                }
                else if (Exception is Error || Exception is Exception)
                {
                    errorName = new ErrorDescription($"'{((Error)Exception).GetType()}'");
                }
                else
                {
                    errorName = new ErrorDescription($"'{Exception.GetType()} object'");
                }

                properties.Add(new ErrorDescription($"'The following {errorName} was {verb}:'"));
                if (diagnosticable != null)
                {
                    diagnosticable.DebugFillProperties(properties);
                }
                else
                {
                    string prefix = $"'{Exception.GetType()}: '";
                    string message = ExceptionAsString();
                    if (message.StartsWith(prefix)) message = message.Substring(prefix.Length);
                    properties.Add(new ErrorSummary(message));
                }

            }

            if (Stack != null)
            {
                if (((AssertionError)Exception) is AssertionError && diagnosticable == null)
                {
                    List<StackFrame> stackFrames = StackframeDefaultClass.StackFrame.FromStackTrace(Stack).SkipWhile((StackFrame frame) => =>frame.PackageScheme == "dart").ToList();
                    bool ourFault = stackFrames.Count >= 2 && stackFrames[0].Package == "flutter" && stackFrames[1].Package == "flutter";
                    if (ourFault)
                    {
                        properties.Add(new ErrorSpacer());
                        properties.Add(new ErrorHint("Either the assertion indicates an error in the framework itself, or we should " + "provide substantially more information in this error message to help you determine " + "and fix the underlying cause.\n" + "In either case, please report this assertion by filing a bug on GitHub:\n" + "  https://github.com/flutter/flutter/issues/new?template=BUG.md"));
                    }

                }

                properties.Add(new ErrorSpacer());
                properties.Add(new DiagnosticsStackTrace("When the exception was thrown, this was the stack", Stack, stackFilter: StackFilter));
            }

            if (InformationCollector != null)
            {
                properties.Add(new ErrorSpacer());
                InformationCollector().ForEach(properties.Add);
            }

        }




        public new string ToStringShort()
        {
            return Library != null ? $"'Exception caught by {Library}'" : "Exception caught";
        }





        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            return new _FlutterErrorDetailsNode(name: name, value: this, style: style);
        }



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
        public FlutterError(string message)
        {

            List<string> lines = message.Split('\n').ToList();
            return FlutterError.FromParts(new List<DiagnosticsNode>() { new ErrorSummary(lines.First),  /* ...lines.Skip(1).Map((string line) => =>new ErrorDescription(line)) */});
        }


        public static FlutterError FromParts(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> diagnostics)
        {
            var instance = new FlutterError(); instance.Diagnostics = diagnostics;


        }


        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> Diagnostics { get; set; }
        public virtual FlutterSDK.Foundation.Assertions.FlutterExceptionHandler OnError { get; set; }
        internal virtual int _ErrorCount { get; set; }
        public virtual int WrapWidth { get; set; }
        internal virtual List<FlutterSDK.Foundation.Assertions.StackFilter> _StackFilters { get; set; }
        public virtual string Message { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Resets the count of errors used by [dumpErrorToConsole] to decide whether
        /// to show a complete error message or an abbreviated one.
        ///
        /// After this is called, the next error message will be shown in full.
        /// </Summary>
        public virtual void ResetErrorCount()
        {
            _ErrorCount = 0;
        }




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
        public virtual void DumpErrorToConsole(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details, bool forceReport = false)
        {


            bool reportError = details.Silent != true;

            if (!reportError && !forceReport) return;
            if (_ErrorCount == 0 || forceReport)
            {
                PrintDefaultClass.DebugPrint(new TextTreeRenderer(wrapWidth: WrapWidth, wrapWidthProperties: WrapWidth, maxDescendentsTruncatableNode: 5).Render(details.ToDiagnosticsNode(style: DiagnosticsTreeStyle.Error)).TrimEnd());
            }
            else
            {
                PrintDefaultClass.DebugPrint($"'Another exception was thrown: {details.Summary}'");
            }

            _ErrorCount += 1;
        }




        /// <Summary>
        /// Adds a stack filtering function to [defaultStackFilter].
        ///
        /// For example, the framework adds common patterns of element building to
        /// elide tree-walking patterns in the stacktrace.
        ///
        /// Added filters are checked in order of addition. The first matching filter
        /// wins, and subsequent filters will not be checked.
        /// </Summary>
        public virtual void AddDefaultStackFilter(FlutterSDK.Foundation.Assertions.StackFilter filter)
        {
            _StackFilters.Add(filter);
        }




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
        public virtual Iterable<string> DefaultStackFilter(Iterable<string> frames)
        {
            Dictionary<string, int> removedPackagesAndClasses = new Dictionary<string, int> { { "dart:async-patch", 0 }{ "dart:async", 0 }{ "package:stack_trace", 0 }{ "class _AssertionError", 0 }{ "class _FakeAsync", 0 }{ "class _FrameCallbackEntry", 0 }{ "class _Timer", 0 }{ "class _RawReceivePortImpl", 0 } };
            int skipped = 0;
            List<StackFrame> parsedFrames = StackframeDefaultClass.StackFrame.FromStackString(frames.Join('\n'));
            for (int index = 0; index < parsedFrames.Count; index += 1)
            {
                StackFrame frame = parsedFrames[index];
                string className = $"'class {frame.ClassName}'";
                string package = $"'{frame.PackageScheme}:{frame.Package}'";
                if (removedPackagesAndClasses.ContainsKey(className))
                {
                    skipped += 1;
                    removedPackagesAndClasses[className] += 1;
                    parsedFrames.RemoveAt(index);
                    index -= 1;
                }
                else if (removedPackagesAndClasses.ContainsKey(package))
                {
                    skipped += 1;
                    removedPackagesAndClasses[package] += 1;
                    parsedFrames.RemoveAt(index);
                    index -= 1;
                }

            }

            List<string> reasons = new List<string>(parsedFrames.Count);
            foreach (StackFilter filter in _StackFilters)
            {
                filter.Filter(parsedFrames, reasons);
            }

            List<string> result = new List<string>() { };
            for (int index = 0; index < parsedFrames.Count; index += 1)
            {
                int start = index;
                while (index < reasons.Count - 1 && reasons[index] != null && reasons[index + 1] == reasons[index])
                {
                    index++;
                }

                string suffix = "";
                if (reasons[index] != null)
                {
                    if (index != start)
                    {
                        suffix = $"' ({index - start + 2} frames)'";
                    }
                    else
                    {
                        suffix = " (1 frame)";
                    }

                }

                string resultLine = $"'{reasons[index] ?? parsedFrames[index].Source}{suffix}'";
                result.Add(resultLine);
            }

            List<string> where = new List<string>() { };
            new List<string>() { }.Sort();
            if (skipped == 1)
            {
                result.Add($"'(elided one frame from {where.Single()})'");
            }
            else if (skipped > 1)
            {
                if (where.Count > 1) where[where.Count - 1] = $"'and {where.Last()}'";
                if (where.Count > 2)
                {
                    result.Add($"'(elided {skipped} frames from {where.Join(", ")})'");
                }
                else
                {
                    result.Add($"'(elided {skipped} frames from {where.Join(' ')})'");
                }

            }

            return result;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            Diagnostics?.ForEach(properties.Add);
        }




        public new string ToStringShort() => "FlutterError";




        /// <Summary>
        /// Calls [onError] with the given details, unless it is null.
        /// </Summary>
        public virtual void ReportError(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details)
        {


            if (OnError != null) OnError(details);
        }



    }


    /// <Summary>
    /// Diagnostic with a [StackTrace] [value] suitable for displaying stack traces
    /// as part of a [FlutterError] object.
    /// </Summary>
    public class DiagnosticsStackTrace : FlutterSDK.Foundation.Diagnostics.DiagnosticsBlock
    {
        public DiagnosticsStackTrace(string name, StackTrace stack, FlutterSDK.Foundation.Basictypes.IterableFilter<string> stackFilter = default(FlutterSDK.Foundation.Basictypes.IterableFilter<string>), bool showSeparator = true)
        : base(name: name, value: stack, properties: stack == null ? new List<DiagnosticsNode>() { } : (stackFilter ?? AssertionsDefaultClass.FlutterError.DefaultStackFilter)(stack.ToString().TrimEnd().Split('\n').ToList()).Map(_CreateStackFrame).ToList(), style: DiagnosticsTreeStyle.Flat, showSeparator: showSeparator, allowTruncate: true)
        {

        }
        public static DiagnosticsStackTrace SingleFrame(string name, string frame = default(string), bool showSeparator = true)
        {
            var instance = new DiagnosticsStackTrace(name: name, properties: new List<DiagnosticsNode>() { _CreateStackFrame(frame) }, style: DiagnosticsTreeStyle.Whitespace, showSeparator: showSeparator);
        }

        private FlutterSDK.Foundation.Diagnostics.DiagnosticsNode _CreateStackFrame(string frame)
        {
            return DiagnosticsNode.Message(frame, allowWrap: false);
        }



    }


    public class _FlutterErrorDetailsNode : FlutterSDK.Foundation.Diagnostics.DiagnosticableNode<FlutterSDK.Foundation.Assertions.FlutterErrorDetails>
    {
        public _FlutterErrorDetailsNode(string name = default(string), FlutterSDK.Foundation.Assertions.FlutterErrorDetails value = default(FlutterSDK.Foundation.Assertions.FlutterErrorDetails), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        : base(name: name, value: value, style: style)
        {

        }
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder Builder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }

}
