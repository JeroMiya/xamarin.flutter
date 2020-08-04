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
namespace FlutterSDK.Foundation.Stackframe
{
    internal static class StackframeDefaultClass
    {
    }

    /// <Summary>
    /// A object representation of a frame from a stack trace.
    ///
    /// {@tool snippet}
    ///
    /// This example creates a traversable list of parsed [StackFrame] objects from
    /// the current [StackTrace].
    ///
    /// ```dart
    /// final List<StackFrame> currentFrames = StackFrame.fromStackTrace(StackTrace.current);
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class StackFrame
    {
        /// <Summary>
        /// Creates a new StackFrame instance.
        ///
        /// All parameters must not be null. The [className] may be the empty string
        /// if there is no class (e.g. for a top level library method).
        /// </Summary>
        public StackFrame(int number = default(int), int column = default(int), int line = default(int), string packageScheme = default(string), string package = default(string), string packagePath = default(string), string className = default(string), string method = default(string), bool isConstructor = false, string source = default(string))
        : base()
        {
            this.Number = number;
            this.Column = column;
            this.Line = line;
            this.PackageScheme = packageScheme;
            this.Package = package;
            this.PackagePath = packagePath;
            this.ClassName = className;
            this.Method = method;
            this.IsConstructor = isConstructor;
            this.Source = source;
        }
        /// <Summary>
        /// A stack frame representing an asynchronous suspension.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Stackframe.StackFrame AsynchronousSuspension { get; set; }
        /// <Summary>
        /// A stack frame representing a Dart elided stack overflow frame.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Stackframe.StackFrame StackOverFlowElision { get; set; }
        internal virtual RegExp _WebNonDebugFramePattern { get; set; }
        /// <Summary>
        /// The original source of this stack frame.
        /// </Summary>
        public virtual string Source { get; set; }
        /// <Summary>
        /// The zero-indexed frame number.
        ///
        /// This value may be -1 to indicate an unknown frame number.
        /// </Summary>
        public virtual int Number { get; set; }
        /// <Summary>
        /// The scheme of the package for this frame, e.g. "dart" for
        /// dart:core/errors_patch.dart or "package" for
        /// package:flutter/src/widgets/text.dart.
        ///
        /// The path property refers to the source file.
        /// </Summary>
        public virtual string PackageScheme { get; set; }
        /// <Summary>
        /// The package for this frame, e.g. "core" for
        /// dart:core/errors_patch.dart or "flutter" for
        /// package:flutter/src/widgets/text.dart.
        /// </Summary>
        public virtual string Package { get; set; }
        /// <Summary>
        /// The path of the file for this frame, e.g. "errors_patch.dart" for
        /// dart:core/errors_patch.dart or "src/widgets/text.dart" for
        /// package:flutter/src/widgets/text.dart.
        /// </Summary>
        public virtual string PackagePath { get; set; }
        /// <Summary>
        /// The source line number.
        /// </Summary>
        public virtual int Line { get; set; }
        /// <Summary>
        /// The source column number.
        /// </Summary>
        public virtual int Column { get; set; }
        /// <Summary>
        /// The class name, if any, for this frame.
        ///
        /// This may be null for top level methods in a library or anonymous closure
        /// methods.
        /// </Summary>
        public virtual string ClassName { get; set; }
        /// <Summary>
        /// The method name for this frame.
        ///
        /// This will be an empty string if the stack frame is from the default
        /// constructor.
        /// </Summary>
        public virtual string Method { get; set; }
        /// <Summary>
        /// Whether or not this was thrown from a constructor.
        /// </Summary>
        public virtual bool IsConstructor { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Parses a list of [StackFrame]s from a [StackTrace] object.
        ///
        /// This is normally useful with [StackTrace.current].
        /// </Summary>
        public virtual List<FlutterSDK.Foundation.Stackframe.StackFrame> FromStackTrace(StackTrace stack)
        {

            return FromStackString(stack.ToString());
        }




        /// <Summary>
        /// Parses a list of [StackFrame]s from the [StackTrace.toString] method.
        /// </Summary>
        public virtual List<FlutterSDK.Foundation.Stackframe.StackFrame> FromStackString(string stack)
        {

            return stack.Trim().Split('\n').ToList().Map(FromStackTraceLine).SkipWhile((StackFrame frame) => =>frame == null).ToList();
        }




        private FlutterSDK.Foundation.Stackframe.StackFrame _ParseWebFrame(string line)
        {
            if (ConstantsDefaultClass.KDebugMode)
            {
                return _ParseWebDebugFrame(line);
            }
            else
            {
                return _ParseWebNonDebugFrame(line);
            }

        }




        private FlutterSDK.Foundation.Stackframe.StackFrame _ParseWebDebugFrame(string line)
        {
            bool hasPackage = line.StartsWith("package");
            RegExp parser = hasPackage ? new RegExp("'^(package.+) (\d+):(\d+)\s+(.+)$") : new RegExp("'^(.+) (\d+):(\d+)\s+(.+)$");
            Match match = parser.FirstMatch(line);

            string package = "<unknown>";
            string packageScheme = "<unknown>";
            string packagePath = "<unknown>";
            if (hasPackage)
            {
                packageScheme = "package";
                Uri packageUri = Dart.CoreDefaultClass.Uri.Parse(match.Group(1));
                package = packageUri.PathSegments[0];
                packagePath = packageUri.Path.ReplaceFirst(packageUri.PathSegments[0] + '/', "");
            }

            return new StackFrame(number: -1, packageScheme: packageScheme, package: package, packagePath: packagePath, line: Dart.CoreDefaultClass.Int.Parse(match.Group(2)), column: Dart.CoreDefaultClass.Int.Parse(match.Group(3)), className: "<unknown>", method: match.Group(4), source: line);
        }




        private FlutterSDK.Foundation.Stackframe.StackFrame _ParseWebNonDebugFrame(string line)
        {
            Match match = _WebNonDebugFramePattern.FirstMatch(line);
            if (match == null)
            {
                return null;
            }

            List<string> classAndMethod = match.Group(1).Split('.').ToList();
            string className = classAndMethod.Count > 1 ? classAndMethod.First : "<unknown>";
            string method = classAndMethod.Count > 1 ? classAndMethod.Skip(1).Join('.') : classAndMethod.Single();
            return new StackFrame(number: -1, packageScheme: "<unknown>", package: "<unknown>", packagePath: "<unknown>", line: -1, column: -1, className: className, method: method, source: line);
        }




        /// <Summary>
        /// Parses a single [StackFrame] from a single line of a [StackTrace].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Stackframe.StackFrame FromStackTraceLine(string line)
        {

            if (line == "<asynchronous suspension>")
            {
                return AsynchronousSuspension;
            }
            else if (line == "...")
            {
                return StackOverFlowElision;
            }

            if (!line.StartsWith('#'))
            {
                return _ParseWebFrame(line);
            }

            RegExp parser = new RegExp("'^#(\d+) +(.+) \((.+?):?(\d+){0,1}:?(\d+){0,1}\)$");
            Match match = parser.FirstMatch(line);

            bool isConstructor = false;
            string className = "";
            string method = match.Group(2).ReplaceAll(".<anonymous closure>", "");
            if (method.StartsWith("new"))
            {
                className = method.Split(' ').ToList()[1];
                method = "";
                if (className.Contains('.'))
                {
                    List<string> parts = className.Split('.').ToList();
                    className = parts[0];
                    method = parts[1];
                }

                isConstructor = true;
            }
            else if (method.Contains('.'))
            {
                List<string> parts = method.Split('.').ToList();
                className = parts[0];
                method = parts[1];
            }

            Uri packageUri = Dart.CoreDefaultClass.Uri.Parse(match.Group(3));
            string package = "<unknown>";
            string packagePath = packageUri.Path;
            if (packageUri.Scheme == "dart" || packageUri.Scheme == "package")
            {
                package = packageUri.PathSegments[0];
                packagePath = packageUri.Path.ReplaceFirst(packageUri.PathSegments[0] + '/', "");
            }

            return new StackFrame(number: Dart.CoreDefaultClass.Int.Parse(match.Group(1)), className: className, method: method, packageScheme: packageUri.Scheme, package: package, packagePath: packagePath, line: match.Group(4) == null ? -1 : Dart.CoreDefaultClass.Int.Parse(match.Group(4)), column: match.Group(5) == null ? -1 : Dart.CoreDefaultClass.Int.Parse(match.Group(5)), isConstructor: isConstructor, source: line);
        }




        public new bool Equals(@Object other)
        {
            if (other.GetType() != GetType()) return false;
            return other is StackFrame && other.Number == Number && other.Package == Package && other.Line == Line && other.Column == Column && other.ClassName == ClassName && other.Method == Method && other.Source == Source;
        }




    }

}
