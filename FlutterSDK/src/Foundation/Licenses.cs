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
namespace FlutterSDK.Foundation.Licenses
{
    /// <Summary>
    /// Signature for callbacks passed to [LicenseRegistry.addLicense].
    /// </Summary>
    public delegate Stream<FlutterSDK.Foundation.Licenses.LicenseEntry> LicenseEntryCollector();
    internal static class LicensesDefaultClass
    {
    }

    /// <Summary>
    /// A license that covers part of the application's software or assets, to show
    /// in an interface such as the [LicensePage].
    ///
    /// For optimal performance, [LicenseEntry] objects should only be created on
    /// demand in [LicenseEntryCollector] callbacks passed to
    /// [LicenseRegistry.addLicense].
    /// </Summary>
    public interface ILicenseEntry
    {
        Iterable<string> Packages { get; }
        Iterable<FlutterSDK.Foundation.Licenses.LicenseParagraph> Paragraphs { get; }
    }


    /// <Summary>
    /// A string that represents one paragraph in a [LicenseEntry].
    ///
    /// See [LicenseEntry.paragraphs].
    /// </Summary>
    public class LicenseParagraph
    {
        /// <Summary>
        /// Creates a string for a license entry paragraph.
        /// </Summary>
        public LicenseParagraph(string text, int indent)
        {
            this.Text = text;
            this.Indent = indent;
        }
        /// <Summary>
        /// The text of the paragraph. Should not have any leading or trailing whitespace.
        /// </Summary>
        public virtual string Text { get; set; }
        /// <Summary>
        /// How many steps of indentation the paragraph has.
        ///
        /// * 0 means the paragraph is not indented.
        /// * 1 means the paragraph is indented one unit of indentation.
        /// * 2 means the paragraph is indented two units of indentation.
        ///
        /// ...and so forth.
        ///
        /// In addition, the special value [centeredIndent] can be used to indicate
        /// that rather than being indented, the paragraph is centered.
        /// </Summary>
        public virtual int Indent { get; set; }
        /// <Summary>
        /// A constant that represents "centered" alignment for [indent].
        /// </Summary>
        public virtual int CenteredIndent { get; set; }
    }


    /// <Summary>
    /// A license that covers part of the application's software or assets, to show
    /// in an interface such as the [LicensePage].
    ///
    /// For optimal performance, [LicenseEntry] objects should only be created on
    /// demand in [LicenseEntryCollector] callbacks passed to
    /// [LicenseRegistry.addLicense].
    /// </Summary>
    public class LicenseEntry
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public LicenseEntry()
        {

        }
        public virtual Iterable<string> Packages { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Foundation.Licenses.LicenseParagraph> Paragraphs { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    /// <Summary>
    /// Variant of [LicenseEntry] for licenses that separate paragraphs with blank
    /// lines and that hard-wrap text within paragraphs. Lines that begin with one
    /// or more space characters are also assumed to introduce new paragraphs,
    /// unless they start with the same number of spaces as the previous line, in
    /// which case it's assumed they are a continuation of an indented paragraph.
    ///
    /// {@tool snippet}
    ///
    /// For example, the BSD license in this format could be encoded as follows:
    ///
    /// ```dart
    /// void initMyLibrary() {
    ///   LicenseRegistry.addLicense(() async* {
    ///     yield LicenseEntryWithLineBreaks(<String>['my_library'], '''
    /// Copyright 2016 The Sample Authors. All rights reserved.
    ///
    /// Redistribution and use in source and binary forms, with or without
    /// modification, are permitted provided that the following conditions are
    /// met:
    ///
    ///    * Redistributions of source code must retain the above copyright
    /// notice, this list of conditions and the following disclaimer.
    ///    * Redistributions in binary form must reproduce the above
    /// copyright notice, this list of conditions and the following disclaimer
    /// in the documentation and/or other materials provided with the
    /// distribution.
    ///    * Neither the name of Example Inc. nor the names of its
    /// contributors may be used to endorse or promote products derived from
    /// this software without specific prior written permission.
    ///
    /// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
    /// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
    /// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
    /// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
    /// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
    /// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
    /// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
    /// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
    /// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
    /// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
    /// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.''');
    ///   });
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// This would result in a license with six [paragraphs], the third, fourth, and
    /// fifth being indented one level.
    ///
    /// ## Performance considerations
    ///
    /// Computing the paragraphs is relatively expensive. Doing the work for one
    /// license per frame is reasonable; doing more at the same time is ill-advised.
    /// Consider doing all the work at once using [compute] to move the work to
    /// another thread, or spreading the work across multiple frames using
    /// [SchedulerBinding.scheduleTask].
    /// </Summary>
    public class LicenseEntryWithLineBreaks : FlutterSDK.Foundation.Licenses.LicenseEntry
    {
        /// <Summary>
        /// Create a license entry for a license whose text is hard-wrapped within
        /// paragraphs and has paragraph breaks denoted by blank lines or with
        /// indented text.
        /// </Summary>
        public LicenseEntryWithLineBreaks(List<string> packages, string text)
        {
            this.Packages = packages;
            this.Text = text;
        }
        public new List<string> Packages { get; set; }
        /// <Summary>
        /// The text of the license.
        ///
        /// The text will be split into paragraphs according to the following
        /// conventions:
        ///
        /// * Lines starting with a different number of space characters than the
        ///   previous line start a new paragraph, with those spaces removed.
        /// * Blank lines start a new paragraph.
        /// * Other line breaks are replaced by a single space character.
        /// * Leading spaces on a line are removed.
        ///
        /// For each paragraph, the algorithm attempts (using some rough heuristics)
        /// to identify how indented the paragraph is, or whether it is centered.
        /// </Summary>
        public virtual string Text { get; set; }
        public virtual Iterable<FlutterSDK.Foundation.Licenses.LicenseParagraph> Paragraphs { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    /// <Summary>
    /// A registry for packages to add licenses to, so that they can be displayed
    /// together in an interface such as the [LicensePage].
    ///
    /// Packages can register their licenses using [addLicense]. User interfaces
    /// that wish to show all the licenses can obtain them by calling [licenses].
    ///
    /// The flutter tool will automatically collect the contents of all the LICENSE
    /// files found at the root of each package into a single LICENSE file in the
    /// default asset bundle. Each license in that file is separated from the next
    /// by a line of eighty hyphens (`-`), and begins with a list of package names
    /// that the license applies to, one to a line, separated from the next by a
    /// blank line. The `services` package registers a license collector that splits
    /// that file and adds each entry to the registry.
    ///
    /// The LICENSE files in each package can either consist of a single license, or
    /// can be in the format described above. In the latter case, each component
    /// license and list of package names is merged independently.
    ///
    /// See also:
    ///
    ///  * [showAboutDialog], which shows a Material-style dialog with information
    ///    about the application, including a button that shows a [LicensePage] that
    ///    uses this API to select licenses to show.
    ///  * [AboutListTile], which is a widget that can be added to a [Drawer]. When
    ///    tapped it calls [showAboutDialog].
    /// </Summary>
    public class LicenseRegistry
    {
        internal LicenseRegistry()
        {

        }
        internal virtual List<object> _Collectors { get; set; }
        public virtual Stream<FlutterSDK.Foundation.Licenses.LicenseEntry> Licenses { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Adds licenses to the registry.
        ///
        /// To avoid actually manipulating the licenses unless strictly necessary,
        /// licenses are added by adding a closure that returns a list of
        /// [LicenseEntry] objects. The closure is only called if [licenses] is itself
        /// called; in normal operation, if the user does not request to see the
        /// licenses, the closure will not be called.
        /// </Summary>
        public virtual void AddLicense(FlutterSDK.Foundation.Licenses.LicenseEntryCollector collector)
        {
            _Collectors = (_Collectors == null ? new List<LicenseEntryCollector>() { } : _Collectors);
            _Collectors.Add(collector);
        }




        /// <Summary>
        /// Resets the internal state of [LicenseRegistry]. Intended for use in
        /// testing.
        /// </Summary>
        public virtual void Reset()
        {
            _Collectors = null;
        }



    }


    public enum _LicenseEntryWithLineBreaksParserState
    {

        BeforeParagraph,
        InParagraph,
    }

}
