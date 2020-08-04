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
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
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
using FlutterSDK.Scheduler;
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
namespace FlutterSDK.Painting.Inlinespan
{
    /// <Summary>
    /// Called on each span as [InlineSpan.visitChildren] walks the [InlineSpan] tree.
    ///
    /// Returns true when the walk should continue, and false to stop visiting further
    /// [InlineSpan]s.
    /// </Summary>
    public delegate bool InlineSpanVisitor(FlutterSDK.Painting.Inlinespan.InlineSpan span);
    internal static class InlinespanDefaultClass
    {
    }

    /// <Summary>
    /// An immutable span of inline content which forms part of a paragraph.
    ///
    ///  * The subclass [TextSpan] specifies text and may contain child [InlineSpan]s.
    ///  * The subclass [PlaceholderSpan] represents a placeholder that may be
    ///    filled with non-text content. [PlaceholderSpan] itself defines a
    ///    [ui.PlaceholderAlignemnt] and a [TextBaseline]. To be useful,
    ///    [PlaceholderSpan] must be extended to define content. An instance of
    ///    this is the [WidgetSpan] class in the widgets library.
    ///  * The subclass [WidgetSpan] specifies embedded inline widgets.
    ///
    /// {@tool snippet}
    ///
    /// This example shows a tree of [InlineSpan]s that make a query asking for a
    /// name with a [TextField] embedded inline.
    ///
    /// ```dart
    /// Text.rich(
    ///   TextSpan(
    ///     text: 'My name is ',
    ///     style: TextStyle(color: Colors.black),
    ///     children: <InlineSpan>[
    ///       WidgetSpan(
    ///         alignment: PlaceholderAlignment.baseline,
    ///         baseline: TextBaseline.alphabetic,
    ///         child: ConstrainedBox(
    ///           constraints: BoxConstraints(maxWidth: 100),
    ///           child: TextField(),
    ///         )
    ///       ),
    ///       TextSpan(
    ///         text: '.',
    ///       ),
    ///     ],
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Text], a widget for showing uniformly-styled text.
    ///  * [RichText], a widget for finer control of text rendering.
    ///  * [TextPainter], a class for painting [InlineSpan] objects on a [Canvas].
    /// </Summary>
    public interface IInlineSpan
    {
        void Build(ParagraphBuilder builder, double textScaleFactor = 1.0, List<FlutterSDK.Painting.Textpainter.PlaceholderDimensions> dimensions = default(List<FlutterSDK.Painting.Textpainter.PlaceholderDimensions>));
        bool VisitTextSpan(Func<bool, TextSpan> visitor);
        bool VisitChildren(FlutterSDK.Painting.Inlinespan.InlineSpanVisitor visitor);
        FlutterSDK.Painting.Inlinespan.InlineSpan GetSpanForPosition(TextPosition position);
        FlutterSDK.Painting.Inlinespan.InlineSpan GetSpanForPositionVisitor(TextPosition position, FlutterSDK.Painting.Inlinespan.Accumulator offset);
        string ToPlainText(bool includeSemanticsLabels = true, bool includePlaceholders = true);
        List<FlutterSDK.Painting.Inlinespan.InlineSpanSemanticsInformation> GetSemanticsInformation();
        void ComputeSemanticsInformation(List<FlutterSDK.Painting.Inlinespan.InlineSpanSemanticsInformation> collector);
        void ComputeToPlainText(StringBuffer buffer, bool includeSemanticsLabels = true, bool includePlaceholders = true);
        int CodeUnitAt(int index);
        int CodeUnitAtVisitor(int index, FlutterSDK.Painting.Inlinespan.Accumulator offset);
        void DescribeSemantics(FlutterSDK.Painting.Inlinespan.Accumulator offset, List<int> semanticsOffsets, List<object> semanticsElements);
        bool DebugAssertIsValid();
        FlutterSDK.Painting.Basictypes.RenderComparison CompareTo(FlutterSDK.Painting.Inlinespan.InlineSpan other);
        bool Equals(@Object other);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        FlutterSDK.Painting.Textstyle.TextStyle Style { get; }
        string Text { get; }
        List<FlutterSDK.Painting.Inlinespan.InlineSpan> Children { get; }
        FlutterSDK.Gestures.Recognizer.GestureRecognizer Recognizer { get; }
        int HashCode { get; }
    }


    /// <Summary>
    /// Mutable wrapper of an integer that can be passed by reference to track a
    /// value across a recursive stack.
    /// </Summary>
    public class Accumulator
    {
        /// <Summary>
        /// [Accumulator] may be initialized with a specified value, otherwise, it will
        /// initialize to zero.
        /// </Summary>
        public Accumulator(int _value = 0)
        {
            this._Value = _value;
        }
        internal virtual int _Value { get; set; }
        public virtual int Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Increases the [value] by the `addend`.
        /// </Summary>
        public virtual void Increment(int addend)
        {

            _Value += addend;
        }



    }


    /// <Summary>
    /// The textual and semantic label information for an [InlineSpan].
    ///
    /// For [PlaceholderSpan]s, [InlineSpanSemanticsInformation.placeholder] is used by default.
    ///
    /// See also:
    ///
    ///  * [InlineSpan.getSemanticsInformation]
    /// </Summary>
    public class InlineSpanSemanticsInformation
    {
        /// <Summary>
        /// Constructs an object that holds the text and semantics label values of an
        /// [InlineSpan].
        ///
        /// The text parameter must not be null.
        ///
        /// Use [InlineSpanSemanticsInformation.placeholder] instead of directly setting
        /// [isPlaceholder].
        /// </Summary>
        public InlineSpanSemanticsInformation(string text, bool isPlaceholder = false, string semanticsLabel = default(string), FlutterSDK.Gestures.Recognizer.GestureRecognizer recognizer = default(FlutterSDK.Gestures.Recognizer.GestureRecognizer))
        : base()
        {
            this.Text = text;
            this.IsPlaceholder = isPlaceholder;
            this.SemanticsLabel = semanticsLabel;
            this.Recognizer = recognizer;
        }
        /// <Summary>
        /// The text info for a [PlaceholderSpan].
        /// </Summary>
        public virtual FlutterSDK.Painting.Inlinespan.InlineSpanSemanticsInformation Placeholder { get; set; }
        /// <Summary>
        /// The text value, if any.  For [PlaceholderSpan]s, this will be the unicode
        /// placeholder value.
        /// </Summary>
        public virtual string Text { get; set; }
        /// <Summary>
        /// The semanticsLabel, if any.
        /// </Summary>
        public virtual string SemanticsLabel { get; set; }
        /// <Summary>
        /// The gesture recognizer, if any, for this span.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.GestureRecognizer Recognizer { get; set; }
        /// <Summary>
        /// Whether this is for a placeholder span.
        /// </Summary>
        public virtual bool IsPlaceholder { get; set; }
        /// <Summary>
        /// True if this configuration should get its own semantics node.
        ///
        /// This will be the case of the [recognizer] is not null, of if
        /// [isPlaceholder] is true.
        /// </Summary>
        public virtual bool RequiresOwnNode { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            return other is InlineSpanSemanticsInformation && other.Text == Text && other.SemanticsLabel == SemanticsLabel && other.Recognizer == Recognizer && other.IsPlaceholder == IsPlaceholder;
        }




    }


    /// <Summary>
    /// An immutable span of inline content which forms part of a paragraph.
    ///
    ///  * The subclass [TextSpan] specifies text and may contain child [InlineSpan]s.
    ///  * The subclass [PlaceholderSpan] represents a placeholder that may be
    ///    filled with non-text content. [PlaceholderSpan] itself defines a
    ///    [ui.PlaceholderAlignemnt] and a [TextBaseline]. To be useful,
    ///    [PlaceholderSpan] must be extended to define content. An instance of
    ///    this is the [WidgetSpan] class in the widgets library.
    ///  * The subclass [WidgetSpan] specifies embedded inline widgets.
    ///
    /// {@tool snippet}
    ///
    /// This example shows a tree of [InlineSpan]s that make a query asking for a
    /// name with a [TextField] embedded inline.
    ///
    /// ```dart
    /// Text.rich(
    ///   TextSpan(
    ///     text: 'My name is ',
    ///     style: TextStyle(color: Colors.black),
    ///     children: <InlineSpan>[
    ///       WidgetSpan(
    ///         alignment: PlaceholderAlignment.baseline,
    ///         baseline: TextBaseline.alphabetic,
    ///         child: ConstrainedBox(
    ///           constraints: BoxConstraints(maxWidth: 100),
    ///           child: TextField(),
    ///         )
    ///       ),
    ///       TextSpan(
    ///         text: '.',
    ///       ),
    ///     ],
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Text], a widget for showing uniformly-styled text.
    ///  * [RichText], a widget for finer control of text rendering.
    ///  * [TextPainter], a class for painting [InlineSpan] objects on a [Canvas].
    /// </Summary>
    public class InlineSpan : FlutterSDK.Foundation.Diagnostics.DiagnosticableTree
    {
        /// <Summary>
        /// Creates an [InlineSpan] with the given values.
        /// </Summary>
        public InlineSpan(FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle))
        {
            this.Style = style;
        }
        /// <Summary>
        /// The [TextStyle] to apply to this span.
        ///
        /// The [style] is also applied to any child spans when this is an instance
        /// of [TextSpan].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual string Text { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual List<FlutterSDK.Painting.Inlinespan.InlineSpan> Children { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Gestures.Recognizer.GestureRecognizer Recognizer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Apply the properties of this object to the given [ParagraphBuilder], from
        /// which a [Paragraph] can be obtained.
        ///
        /// The `textScaleFactor` parameter specifies a scale that the text and
        /// placeholders will be scaled by. The scaling is performed before layout,
        /// so the text will be laid out with the scaled glyphs and placeholders.
        ///
        /// The `dimensions` parameter specifies the sizes of the placeholders.
        /// Each [PlaceholderSpan] must be paired with a [PlaceholderDimensions]
        /// in the same order as defined in the [InlineSpan] tree.
        ///
        /// [Paragraph] objects can be drawn on [Canvas] objects.
        /// </Summary>
        public virtual void Build(ParagraphBuilder builder, double textScaleFactor = 1.0, List<FlutterSDK.Painting.Textpainter.PlaceholderDimensions> dimensions = default(List<FlutterSDK.Painting.Textpainter.PlaceholderDimensions>))
        {
        }


        /// <Summary>
        /// Walks this [TextSpan] and any descendants in pre-order and calls `visitor`
        /// for each span that has content.
        ///
        /// When `visitor` returns true, the walk will continue. When `visitor` returns
        /// false, then the walk will end.
        /// </Summary>
        public virtual bool VisitTextSpan(Func<bool, TextSpan> visitor)
        {
            return default(bool);
        }


        /// <Summary>
        /// Walks this [InlineSpan] and any descendants in pre-order and calls `visitor`
        /// for each span that has content.
        ///
        /// When `visitor` returns true, the walk will continue. When `visitor` returns
        /// false, then the walk will end.
        /// </Summary>
        public virtual bool VisitChildren(FlutterSDK.Painting.Inlinespan.InlineSpanVisitor visitor)
        {
            return default(bool);
        }


        /// <Summary>
        /// Returns the [InlineSpan] that contains the given position in the text.
        /// </Summary>
        public virtual FlutterSDK.Painting.Inlinespan.InlineSpan GetSpanForPosition(TextPosition position)
        {

            Accumulator offset = new Accumulator();
            InlineSpan result = default(InlineSpan);
            VisitChildren((InlineSpan span) =>
            {
                result = span.GetSpanForPositionVisitor(position, offset);
                return result == null;
            }
            );
            return result;
        }




        /// <Summary>
        /// Performs the check at each [InlineSpan] for if the `position` falls within the range
        /// of the span and returns the span if it does.
        ///
        /// The `offset` parameter tracks the current index offset in the text buffer formed
        /// if the contents of the [InlineSpan] tree were concatenated together starting
        /// from the root [InlineSpan].
        ///
        /// This method should not be directly called. Use [getSpanForPosition] instead.
        /// </Summary>
        public virtual FlutterSDK.Painting.Inlinespan.InlineSpan GetSpanForPositionVisitor(TextPosition position, FlutterSDK.Painting.Inlinespan.Accumulator offset)
        {
            return default(InlineSpan);
        }


        /// <Summary>
        /// Flattens the [InlineSpan] tree into a single string.
        ///
        /// Styles are not honored in this process. If `includeSemanticsLabels` is
        /// true, then the text returned will include the [TextSpan.semanticsLabel]s
        /// instead of the text contents for [TextSpan]s.
        ///
        /// When `includePlaceholders` is true, [PlaceholderSpan]s in the tree will be
        /// represented as a 0xFFFC 'object replacement character'.
        /// </Summary>
        public virtual string ToPlainText(bool includeSemanticsLabels = true, bool includePlaceholders = true)
        {
            StringBuffer buffer = new StringBuffer();
            ComputeToPlainText(buffer, includeSemanticsLabels: includeSemanticsLabels, includePlaceholders: includePlaceholders);
            return buffer.ToString();
        }




        /// <Summary>
        /// Flattens the [InlineSpan] tree to a list of
        /// [InlineSpanSemanticsInformation] objects.
        ///
        /// [PlaceholderSpan]s in the tree will be represented with a
        /// [InlineSpanSemanticsInformation.placeholder] value.
        /// </Summary>
        public virtual List<FlutterSDK.Painting.Inlinespan.InlineSpanSemanticsInformation> GetSemanticsInformation()
        {
            List<InlineSpanSemanticsInformation> collector = new List<InlineSpanSemanticsInformation>() { };
            ComputeSemanticsInformation(collector);
            return collector;
        }




        /// <Summary>
        /// Walks the [InlineSpan] tree and accumulates a list of
        /// [InlineSpanSemanticsInformation] objects.
        ///
        /// This method should not be directly called.  Use
        /// [getSemanticsInformation] instead.
        ///
        /// [PlaceholderSpan]s in the tree will be represented with a
        /// [InlineSpanSemanticsInformation.placeholder] value.
        /// </Summary>
        public virtual void ComputeSemanticsInformation(List<FlutterSDK.Painting.Inlinespan.InlineSpanSemanticsInformation> collector)
        {
        }


        /// <Summary>
        /// Walks the [InlineSpan] tree and writes the plain text representation to `buffer`.
        ///
        /// This method should not be directly called. Use [toPlainText] instead.
        ///
        /// Styles are not honored in this process. If `includeSemanticsLabels` is
        /// true, then the text returned will include the [TextSpan.semanticsLabel]s
        /// instead of the text contents for [TextSpan]s.
        ///
        /// When `includePlaceholders` is true, [PlaceholderSpan]s in the tree will be
        /// represented as a 0xFFFC 'object replacement character'.
        ///
        /// The plain-text representation of this [InlineSpan] is written into the `buffer`.
        /// This method will then recursively call [computeToPlainText] on its children
        /// [InlineSpan]s if available.
        /// </Summary>
        public virtual void ComputeToPlainText(StringBuffer buffer, bool includeSemanticsLabels = true, bool includePlaceholders = true)
        {
        }


        /// <Summary>
        /// Returns the UTF-16 code unit at the given `index` in the flattened string.
        ///
        /// This only accounts for the [TextSpan.text] values and ignores [PlaceholderSpans].
        ///
        /// Returns null if the `index` is out of bounds.
        /// </Summary>
        public virtual int CodeUnitAt(int index)
        {
            if (index < 0) return null;
            Accumulator offset = new Accumulator();
            int result = default(int);
            VisitChildren((InlineSpan span) =>
            {
                result = span.CodeUnitAtVisitor(index, offset);
                return result == null;
            }
            );
            return result;
        }




        /// <Summary>
        /// Performs the check at each [InlineSpan] for if the `index` falls within the range
        /// of the span and returns the corresponding code unit. Returns null otherwise.
        ///
        /// The `offset` parameter tracks the current index offset in the text buffer formed
        /// if the contents of the [InlineSpan] tree were concatenated together starting
        /// from the root [InlineSpan].
        ///
        /// This method should not be directly called. Use [codeUnitAt] instead.
        /// </Summary>
        public virtual int CodeUnitAtVisitor(int index, FlutterSDK.Painting.Inlinespan.Accumulator offset)
        {
            return default(int);
        }


        /// <Summary>
        /// Populates the `semanticsOffsets` and `semanticsElements` with the appropriate data
        /// to be able to construct a [SemanticsNode].
        ///
        /// If applicable, the beginning and end text offset are added to [semanticsOffsets].
        /// [PlaceholderSpan]s have a text length of 1, which corresponds to the object
        /// replacement character (0xFFFC) that is inserted to represent it.
        ///
        /// Any [GestureRecognizer]s are added to `semanticsElements`. Null is added to
        /// `semanticsElements` for [PlaceholderSpan]s.
        /// </Summary>
        public virtual void DescribeSemantics(FlutterSDK.Painting.Inlinespan.Accumulator offset, List<int> semanticsOffsets, List<object> semanticsElements)
        {
        }


        /// <Summary>
        /// In checked mode, throws an exception if the object is not in a
        /// valid configuration. Otherwise, returns true.
        ///
        /// This is intended to be used as follows:
        ///
        /// ```dart
        /// assert(myInlineSpan.debugAssertIsValid());
        /// ```
        /// </Summary>
        public virtual bool DebugAssertIsValid() => true;



        /// <Summary>
        /// Describe the difference between this span and another, in terms of
        /// how much damage it will make to the rendering. The comparison is deep.
        ///
        /// Comparing [InlineSpan] objects of different types, for example, comparing
        /// a [TextSpan] to a [WidgetSpan], always results in [RenderComparison.layout].
        ///
        /// See also:
        ///
        ///  * [TextStyle.compareTo], which does the same thing for [TextStyle]s.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.RenderComparison CompareTo(FlutterSDK.Painting.Inlinespan.InlineSpan other)
        {
            return default(RenderComparison);
        }


        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is InlineSpan && other.Style == Style;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.DefaultDiagnosticsTreeStyle = DiagnosticsTreeStyle.Whitespace;
            if (Style != null)
            {
                Style.DebugFillProperties(properties);
            }

        }



    }

}
