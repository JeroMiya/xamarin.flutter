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
namespace FlutterSDK.Foundation.Assertions
{
    /// <Summary>
    /// Signature for [FlutterError.onError] handler.
    /// </Summary>
    public delegate void FlutterExceptionHandler(FlutterSDK.Foundation.Assertions.FlutterErrorDetails details);
    /// <Summary>
    /// Signature for [DiagnosticPropertiesBuilder] transformer.
    /// </Summary>
    public delegate Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DiagnosticPropertiesTransformer(Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> properties);
    /// <Summary>
    /// Signature for [FlutterErrorDetails.informationCollector] callback
    /// and other callbacks that collect information describing an error.
    /// </Summary>
    public delegate Iterable<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> InformationCollector();
    internal static class AssertionsDefaultClass
    {
        /// <Summary>
        /// Dump the stack to the console using [debugPrint] and
        /// [FlutterError.defaultStackFilter].
        ///
        /// If the `stackTrace` parameter is null, the [StackTrace.current] is used to
        /// obtain the stack.
        ///
        /// The `maxFrames` argument can be given to limit the stack to the given number
        /// of lines before filtering is applied. By default, all stack lines are
        /// included.
        ///
        /// The `label` argument, if present, will be printed before the stack.
        /// </Summary>
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
        /// <Summary>
        /// Creates a new [PartialStackFrame] instance. All arguments are required and
        /// must not be null.
        /// </Summary>
        public PartialStackFrame(Pattern package = default(Pattern), string className = default(string), string method = default(string))
        : base()
        {
            this.Package = package;
            this.ClassName = className;
            this.Method = method;
        }
        /// <Summary>
        /// An `<asynchronous suspension>` line in a stack trace.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Assertions.PartialStackFrame AsynchronousSuspension { get; set; }
        /// <Summary>
        /// The package to match, e.g. `package:flutter/src/foundation/assertions.dart`,
        /// or `dart:ui/window.dart`.
        /// </Summary>
        public virtual Pattern Package { get; set; }
        /// <Summary>
        /// The class name for the method.
        ///
        /// On web, this is ignored, since class names are not available.
        ///
        /// On all platforms, top level methods should use the empty string.
        /// </Summary>
        public virtual string ClassName { get; set; }
        /// <Summary>
        /// The method name for this frame line.
        ///
        /// On web, private methods are wrapped with `[]`.
        /// </Summary>
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
        /// <Summary>
        /// A const constructor to allow subclasses to be const.
        /// </Summary>
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
        /// <Summary>
        /// Creates a new RepetitiveStackFrameFilter. All parameters are required and must not be
        /// null.
        /// </Summary>
        public RepetitiveStackFrameFilter(List<FlutterSDK.Foundation.Assertions.PartialStackFrame> frames = default(List<FlutterSDK.Foundation.Assertions.PartialStackFrame>), string replacement = default(string))
        : base()
        {
            this.Frames = frames;
            this.Replacement = replacement;
        }
        /// <Summary>
        /// The shape of this repetative stack pattern.
        /// </Summary>
        public virtual List<FlutterSDK.Foundation.Assertions.PartialStackFrame> Frames { get; set; }
        /// <Summary>
        /// The string to replace the frames with.
        ///
        /// If the same replacement string is used multiple times in a row, the
        /// [FlutterError.defaultStackFilter] will simply update a counter after this
        /// line rather than repeating it.
        /// </Summary>
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
        /// <Summary>
        /// This constructor provides a reliable hook for a kernel transformer to find
        /// error messages that need to be rewritten to include object references for
        /// interactive display of errors.
        /// </Summary>
        public _ErrorDiagnostic(string message, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(null, new List<object>() { message }, showName: false, showSeparator: false, defaultValue: null, style: style, level: level)
        {

        }
        /// <Summary>
        /// In debug builds, a kernel transformer rewrites calls to the default
        /// constructors for [ErrorSummary], [ErrorDetails], and [ErrorHint] to use
        /// this constructor.
        /// </Summary>
        internal static _ErrorDiagnostic _FromParts(List<@Object> messageParts, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        => new _ErrorDiagnostic(messageParts, style, level);

        private _ErrorDiagnostic(List<@Object> messageParts, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level)
        : base(null, messageParts, showName: false, showSeparator: false, defaultValue: null, style: style, level: level)
        {

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
        /// <Summary>
        /// A lint enforces that this constructor can only be called with a string
        /// literal to match the limitations of the Dart Kernel transformer that
        /// optionally extracts out objects referenced using string interpolation in
        /// the message passed in.
        ///
        /// The message will display with the same text regardless of whether the
        /// kernel transformer is used. The kernel transformer is required so that
        /// debugging tools can provide interactive displays of objects described by
        /// the error.
        /// </Summary>
        public ErrorDescription(string message)
        : base(message, level: DiagnosticLevel.Info)
        {

        }
        /// <Summary>
        /// Calls to the default constructor may be rewritten to use this constructor
        /// in debug mode using a kernel transformer.
        /// </Summary>
        internal static ErrorDescription _FromParts(List<@Object> messageParts)
        => new ErrorDescription(messageParts);

        private ErrorDescription(List<@Object> messageParts)
        : base(messageParts, level: DiagnosticLevel.Info)
        {

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
        /// <Summary>
        /// A lint enforces that this constructor can only be called with a string
        /// literal to match the limitations of the Dart Kernel transformer that
        /// optionally extracts out objects referenced using string interpolation in
        /// the message passed in.
        ///
        /// The message will display with the same text regardless of whether the
        /// kernel transformer is used. The kernel transformer is required so that
        /// debugging tools can provide interactive displays of objects described by
        /// the error.
        /// </Summary>
        public ErrorSummary(string message)
        : base(message, level: DiagnosticLevel.Summary)
        {

        }
        /// <Summary>
        /// Calls to the default constructor may be rewritten to use this constructor
        /// in debug mode using a kernel transformer.
        /// </Summary>
        internal static ErrorSummary _FromParts(List<@Object> messageParts)
        => new ErrorSummary(messageParts);

        private ErrorSummary(List<@Object> messageParts)
        : base(messageParts, level: DiagnosticLevel.Summary)
        {

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
        /// <Summary>
        /// A lint enforces that this constructor can only be called with a string
        /// literal to match the limitations of the Dart Kernel transformer that
        /// optionally extracts out objects referenced using string interpolation in
        /// the message passed in.
        ///
        /// The message will display with the same text regardless of whether the
        /// kernel transformer is used. The kernel transformer is required so that
        /// debugging tools can provide interactive displays of objects described by
        /// the error.
        /// </Summary>
        public ErrorHint(string message)
        : base(message, level: DiagnosticLevel.Hint)
        {

        }
        /// <Summary>
        /// Calls to the default constructor may be rewritten to use this constructor
        /// in debug mode using a kernel transformer.
        /// </Summary>
        internal static ErrorHint _FromParts(List<@Object> messageParts)
        => new ErrorHint(messageParts);

        private ErrorHint(List<@Object> messageParts)
        : base(messageParts, level: DiagnosticLevel.Hint)
        {

        }
    }


    /// <Summary>
    /// An [ErrorSpacer] creates an empty [DiagnosticsNode], that can be used to
    /// tune the spacing between other [DiagnosticsNode] objects.
    /// </Summary>
    public class ErrorSpacer : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<object>
    {
        /// <Summary>
        /// Creates an empty space to insert into a list of [DiagnosticsNode] objects
        /// typically within a [FlutterError] object.
        /// </Summary>
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
        /// <Summary>
        /// Creates a [FlutterErrorDetails] object with the given arguments setting
        /// the object's properties.
        ///
        /// The framework calls this constructor when catching an exception that will
        /// subsequently be reported using [FlutterError.onError].
        ///
        /// The [exception] must not be null; other arguments can be left to
        /// their default values. (`throw null` results in a
        /// [NullThrownError] exception.)
        /// </Summary>
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
        /// <Summary>
        /// Transformers to transform [DiagnosticsNode] in [DiagnosticPropertiesBuilder]
        /// into a more descriptive form.
        ///
        /// There are layers that attach certain [DiagnosticsNode] into
        /// [FlutterErrorDetails] that require knowledge from other layers to parse.
        /// To correctly interpret those [DiagnosticsNode], register transformers in
        /// the layers that possess the knowledge.
        ///
        /// See also:
        ///
        ///  * [WidgetsBinding.initInstances], which registers its transformer.
        /// </Summary>
        public virtual List<object> PropertiesTransformers { get; set; }
        /// <Summary>
        /// The exception. Often this will be an [AssertionError], maybe specifically
        /// a [FlutterError]. However, this could be any value at all.
        /// </Summary>
        public virtual object Exception { get; set; }
        /// <Summary>
        /// The stack trace from where the [exception] was thrown (as opposed to where
        /// it was caught).
        ///
        /// StackTrace objects are opaque except for their [toString] function.
        ///
        /// If this field is not null, then the [stackFilter] callback, if any, will
        /// be called with the result of calling [toString] on this object and
        /// splitting that result on line breaks. If there's no [stackFilter]
        /// callback, then [FlutterError.defaultStackFilter] is used instead. That
        /// function expects the stack to be in the format used by
        /// [StackTrace.toString].
        /// </Summary>
        public virtual StackTrace Stack { get; set; }
        /// <Summary>
        /// A human-readable brief name describing the library that caught the error
        /// message. This is used by the default error handler in the header dumped to
        /// the console.
        /// </Summary>
        public virtual string Library { get; set; }
        /// <Summary>
        /// A human-readable description of where the error was caught (as opposed to
        /// where it was thrown).
        ///
        /// The string should be in a form that will make sense in English when
        /// following the word "thrown", as in "thrown while obtaining the image from
        /// the network" (for the context "while obtaining the image from the
        /// network").
        /// </Summary>
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode Context { get; set; }
        /// <Summary>
        /// A callback which filters the [stack] trace. Receives an iterable of
        /// strings representing the frames encoded in the way that
        /// [StackTrace.toString()] provides. Should return an iterable of lines to
        /// output for the stack.
        ///
        /// If this is not provided, then [FlutterError.dumpErrorToConsole] will use
        /// [FlutterError.defaultStackFilter] instead.
        ///
        /// If the [FlutterError.defaultStackFilter] behavior is desired, then the
        /// callback should manually call that function. That function expects the
        /// incoming list to be in the [StackTrace.toString()] format. The output of
        /// that function, however, does not always follow this format.
        ///
        /// This won't be called if [stack] is null.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.IterableFilter<string> StackFilter { get; set; }
        /// <Summary>
        /// A callback which, when called with a [StringBuffer] will write to that buffer
        /// information that could help with debugging the problem.
        ///
        /// Information collector callbacks can be expensive, so the generated information
        /// should be cached, rather than the callback being called multiple times.
        ///
        /// The text written to the information argument may contain newlines but should
        /// not end with a newline.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Assertions.InformationCollector InformationCollector { get; set; }
        /// <Summary>
        /// Whether this error should be ignored by the default error reporting
        /// behavior in release mode.
        ///
        /// If this is false, the default, then the default error handler will always
        /// dump this error to the console.
        ///
        /// If this is true, then the default error handler would only dump this error
        /// to the console in checked mode. In release mode, the error is ignored.
        ///
        /// This is used by certain exception handlers that catch errors that could be
        /// triggered by environmental conditions (as opposed to logic errors). For
        /// example, the HTTP library sets this flag so as to not report every 404
        /// error to the console on end-user devices, while still allowing a custom
        /// error handler to see the errors even in release builds.
        /// </Summary>
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
        /// <Summary>
        /// Create an error message from a string.
        ///
        /// The message may have newlines in it. The first line should be a terse
        /// description of the error, e.g. "Incorrect GlobalKey usage" or "setState()
        /// or markNeedsBuild() called during build". Subsequent lines should contain
        /// substantial additional information, ideally sufficient to develop a
        /// correct solution to the problem.
        ///
        /// In some cases, when a FlutterError is reported to the user, only the first
        /// line is included. For example, Flutter will typically only fully report
        /// the first exception at runtime, displaying only the first line of
        /// subsequent errors.
        ///
        /// All sentences in the error should be correctly punctuated (i.e.,
        /// do end the error message with a period).
        ///
        /// This constructor defers to the [new FlutterError.fromParts] constructor.
        /// The first line is wrapped in an implied [ErrorSummary], and subsequent
        /// lines are wrapped in implied [ErrorDescription]s. Consider using the
        /// [new FlutterError.fromParts] constructor to provide more detail, e.g.
        /// using [ErrorHint]s or other [DiagnosticsNode]s.
        /// </Summary>
        public static FlutterError CreateNew(string message)
        {

            List<string> lines = message.Split('\n').ToList();
            return FlutterError.FromParts(new List<DiagnosticsNode>() { new ErrorSummary(lines.First),  /* ...lines.Skip(1).Map((string line) => =>new ErrorDescription(line)) */});
        }


        /// <Summary>
        /// Create an error message from a list of [DiagnosticsNode]s.
        ///
        /// By convention, there should be exactly one [ErrorSummary] in the list,
        /// and it should be the first entry.
        ///
        /// Other entries are typically [ErrorDescription]s (for material that is
        /// always applicable for this error) and [ErrorHint]s (for material that may
        /// be sometimes useful, but may not always apply). Other [DiagnosticsNode]
        /// subclasses, such as [DiagnosticsStackTrace], may
        /// also be used.
        /// </Summary>
        public static FlutterError FromParts(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> diagnostics)
        => new FlutterError(diagnostics);

        private FlutterError(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> diagnostics)
        : base()
        {
            this.Diagnostics = diagnostics;


        }


        /// <Summary>
        /// The information associated with this error, in structured form.
        ///
        /// The first node is typically an [ErrorSummary] giving a short description
        /// of the problem, suitable for an index of errors, a log, etc.
        ///
        /// Subsequent nodes should give information specific to this error. Typically
        /// these will be [ErrorDescription]s or [ErrorHint]s, but they could be other
        /// objects also. For instance, an error relating to a timer could include a
        /// stack trace of when the timer was scheduled using the
        /// [DiagnosticsStackTrace] class.
        /// </Summary>
        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> Diagnostics { get; set; }
        /// <Summary>
        /// Called whenever the Flutter framework catches an error.
        ///
        /// The default behavior is to call [dumpErrorToConsole].
        ///
        /// You can set this to your own function to override this default behavior.
        /// For example, you could report all errors to your server.
        ///
        /// If the error handler throws an exception, it will not be caught by the
        /// Flutter framework.
        ///
        /// Set this to null to silently catch and ignore errors. This is not
        /// recommended.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Assertions.FlutterExceptionHandler OnError { get; set; }
        internal virtual int _ErrorCount { get; set; }
        /// <Summary>
        /// The width to which [dumpErrorToConsole] will wrap lines.
        ///
        /// This can be used to ensure strings will not exceed the length at which
        /// they will wrap, e.g. when placing ASCII art diagrams in messages.
        /// </Summary>
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

            List<string> reasons = List.CreateNew<string>(parsedFrames.Count);
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
        /// <Summary>
        /// Creates a diagnostic for a stack trace.
        ///
        /// [name] describes a name the stacktrace is given, e.g.
        /// `When the exception was thrown, this was the stack`.
        /// [stackFilter] provides an optional filter to use to filter which frames
        /// are included. If no filter is specified, [FlutterError.defaultStackFilter]
        /// is used.
        /// [showSeparator] indicates whether to include a ':' after the [name].
        /// </Summary>
        public DiagnosticsStackTrace(string name, StackTrace stack, FlutterSDK.Foundation.Basictypes.IterableFilter<string> stackFilter = default(FlutterSDK.Foundation.Basictypes.IterableFilter<string>), bool showSeparator = true)
        : base(name: name, value: stack, properties: stack == null ? new List<DiagnosticsNode>() { } : (stackFilter ?? AssertionsDefaultClass.FlutterError.DefaultStackFilter)(stack.ToString().TrimEnd().Split('\n').ToList()).Map(_CreateStackFrame).ToList(), style: DiagnosticsTreeStyle.Flat, showSeparator: showSeparator, allowTruncate: true)
        {

        }
        /// <Summary>
        /// Creates a diagnostic describing a single frame from a StackTrace.
        /// </Summary>
        public static DiagnosticsStackTrace SingleFrame(string name, string frame = default(string), bool showSeparator = true)
        => new DiagnosticsStackTrace(name, frame, showSeparator);

        private DiagnosticsStackTrace(string name, string frame, bool showSeparator)
        : base(name: name, properties: new List<DiagnosticsNode>() { _CreateStackFrame(frame) }, style: DiagnosticsTreeStyle.Whitespace, showSeparator: showSeparator)
        {

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
