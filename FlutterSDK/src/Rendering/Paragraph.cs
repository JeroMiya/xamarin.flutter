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
namespace FlutterSDK.Rendering.Paragraph
{
    internal static class ParagraphDefaultClass
    {
        public static string _KEllipsis = default(string);
    }

    /// <Summary>
    /// Parent data for use with [RenderParagraph].
    /// </Summary>
    public class TextParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
    {
        public TextParentData()
        { }
        /// <Summary>
        /// The scaling of the text.
        /// </Summary>
        public virtual double Scale { get; set; }

    }


    /// <Summary>
    /// A render object that displays a paragraph of text.
    /// </Summary>
    public class RenderParagraph : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Paragraph.TextParentData>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Paragraph.TextParentData>, IRelayoutWhenSystemFontsChangeMixin
    {
        /// <Summary>
        /// Creates a paragraph render object.
        ///
        /// The [text], [textAlign], [textDirection], [overflow], [softWrap], and
        /// [textScaleFactor] arguments must not be null.
        ///
        /// The [maxLines] property may be null (and indeed defaults to null), but if
        /// it is not null, it must be greater than zero.
        /// </Summary>
        public RenderParagraph(FlutterSDK.Painting.Inlinespan.InlineSpan text, TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), bool softWrap = true, FlutterSDK.Rendering.Paragraph.TextOverflow overflow = default(FlutterSDK.Rendering.Paragraph.TextOverflow), double textScaleFactor = 1.0, int maxLines = default(int), Locale locale = default(Locale), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), TextHeightBehavior textHeightBehavior = default(TextHeightBehavior), List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>))
        : base()
        {

            AddAll(children);
            _ExtractPlaceholderSpans(text);
        }


        internal virtual FlutterSDK.Painting.Textpainter.TextPainter _TextPainter { get; set; }
        internal virtual List<FlutterSDK.Painting.Placeholderspan.PlaceholderSpan> _PlaceholderSpans { get; set; }
        internal virtual bool _SoftWrap { get; set; }
        internal virtual FlutterSDK.Rendering.Paragraph.TextOverflow _Overflow { get; set; }
        internal virtual bool _NeedsClipping { get; set; }
        internal virtual SKShader _OverflowShader { get; set; }
        internal virtual List<FlutterSDK.Painting.Textpainter.PlaceholderDimensions> _PlaceholderDimensions { get; set; }
        /// <Summary>
        /// Collected during [describeSemanticsConfiguration], used by
        /// [assembleSemanticsNode] and [_combineSemanticsInfo].
        /// </Summary>
        internal virtual List<FlutterSDK.Painting.Inlinespan.InlineSpanSemanticsInformation> _SemanticsInfo { get; set; }
        internal virtual Queue<FlutterSDK.Semantics.Semantics.SemanticsNode> _CachedChildNodes { get; set; }
        public virtual FlutterSDK.Painting.Inlinespan.InlineSpan Text { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextAlign TextAlign { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SoftWrap { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Paragraph.TextOverflow Overflow { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double TextScaleFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int MaxLines { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Locale Locale { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextHeightBehavior TextHeightBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugHasOverflowShader { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Size TextSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
        {
            if (!(child.ParentData is TextParentData)) child.ParentData = new TextParentData();
        }


        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is TextParentData)) child.ParentData = new TextParentData();
        }




        private void _ExtractPlaceholderSpans(FlutterSDK.Painting.Inlinespan.InlineSpan span)
        {
            _PlaceholderSpans = new List<PlaceholderSpan>() { };
            span.VisitChildren((InlineSpan span) =>
            {
                if (span is PlaceholderSpan)
                {
                    PlaceholderSpan placeholderSpan = ((PlaceholderSpan)span);
                    _PlaceholderSpans.Add(placeholderSpan);
                }

                return true;
            }
            );
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            if (!_CanComputeIntrinsics())
            {
                return 0.0;
            }

            _ComputeChildrenWidthWithMinIntrinsics(height);
            _LayoutText();
            return _TextPainter.MinIntrinsicWidth;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            if (!_CanComputeIntrinsics())
            {
                return 0.0;
            }

            _ComputeChildrenWidthWithMaxIntrinsics(height);
            _LayoutText();
            return _TextPainter.MaxIntrinsicWidth;
        }




        private double _ComputeIntrinsicHeight(double width)
        {
            if (!_CanComputeIntrinsics())
            {
                return 0.0;
            }

            _ComputeChildrenHeightWithMinIntrinsics(width);
            _LayoutText(minWidth: width, maxWidth: width);
            return _TextPainter.Height;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            return _ComputeIntrinsicHeight(width);
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            return _ComputeIntrinsicHeight(width);
        }




        public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
        {



            _LayoutTextWithConstraints(Constraints);
            return _TextPainter.ComputeDistanceToActualBaseline(TextBaseline.Alphabetic);
        }




        private bool _CanComputeIntrinsics()
        {
            foreach (PlaceholderSpan span in _PlaceholderSpans)
            {
                switch (span.Alignment)
                {
                    case Ui.PlaceholderAlignment.Baseline:
                    case Ui.PlaceholderAlignment.AboveBaseline:
                    case Ui.PlaceholderAlignment.BelowBaseline:
                        {

                            return false;
                        }
                    case Ui.PlaceholderAlignment.Top:
                    case Ui.PlaceholderAlignment.Middle:
                    case Ui.PlaceholderAlignment.Bottom:
                        {
                            continue;
                        }
                }
            }

            return true;
        }




        private void _ComputeChildrenWidthWithMaxIntrinsics(double height)
        {
            RenderBox child = FirstChild;
            List<PlaceholderDimensions> placeholderDimensions = List.CreateNew<PlaceholderDimensions>(ChildCount);
            int childIndex = 0;
            while (child != null)
            {
                placeholderDimensions[childIndex] = new PlaceholderDimensions(size: new Size(child.GetMaxIntrinsicWidth(height), height), alignment: _PlaceholderSpans[childIndex].Alignment, baseline: _PlaceholderSpans[childIndex].Baseline);
                child = ChildAfter(child);
                childIndex += 1;
            }

            _TextPainter.SetPlaceholderDimensions(placeholderDimensions);
        }




        private void _ComputeChildrenWidthWithMinIntrinsics(double height)
        {
            RenderBox child = FirstChild;
            List<PlaceholderDimensions> placeholderDimensions = List.CreateNew<PlaceholderDimensions>(ChildCount);
            int childIndex = 0;
            while (child != null)
            {
                double intrinsicWidth = child.GetMinIntrinsicWidth(height);
                double intrinsicHeight = child.GetMinIntrinsicHeight(intrinsicWidth);
                placeholderDimensions[childIndex] = new PlaceholderDimensions(size: new Size(intrinsicWidth, intrinsicHeight), alignment: _PlaceholderSpans[childIndex].Alignment, baseline: _PlaceholderSpans[childIndex].Baseline);
                child = ChildAfter(child);
                childIndex += 1;
            }

            _TextPainter.SetPlaceholderDimensions(placeholderDimensions);
        }




        private void _ComputeChildrenHeightWithMinIntrinsics(double width)
        {
            RenderBox child = FirstChild;
            List<PlaceholderDimensions> placeholderDimensions = List.CreateNew<PlaceholderDimensions>(ChildCount);
            int childIndex = 0;
            while (child != null)
            {
                double intrinsicHeight = child.GetMinIntrinsicHeight(width);
                double intrinsicWidth = child.GetMinIntrinsicWidth(intrinsicHeight);
                placeholderDimensions[childIndex] = new PlaceholderDimensions(size: new Size(intrinsicWidth, intrinsicHeight), alignment: _PlaceholderSpans[childIndex].Alignment, baseline: _PlaceholderSpans[childIndex].Baseline);
                child = ChildAfter(child);
                childIndex += 1;
            }

            _TextPainter.SetPlaceholderDimensions(placeholderDimensions);
        }




        public new bool HitTestSelf(FlutterBinding.UI.Offset position) => true;



        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            RenderBox child = FirstChild;
            while (child != null)
            {
                TextParentData textParentData = child.ParentData as TextParentData;
                Matrix4 transform = Matrix4.TranslationValues(textParentData.Offset.Dx, textParentData.Offset.Dy, 0.0);
                Matrix4.TranslationValues(textParentData.Offset.Dx, textParentData.Offset.Dy, 0.0).Scale(textParentData.Scale, textParentData.Scale, textParentData.Scale);
                bool isHit = result.AddWithPaintTransform(transform: transform, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
                {

                    return child.HitTest(result, position: transformed);
                }
                );
                if (isHit)
                {
                    return true;
                }

                child = ChildAfter(child);
            }

            return false;
        }




        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry)
        {

            if (!(@event is PointerDownEvent)) return;
            _LayoutTextWithConstraints(Constraints);
            Offset offset = entry.LocalPosition;
            TextPosition position = _TextPainter.GetPositionForOffset(offset);
            InlineSpan span = _TextPainter.Text.GetSpanForPosition(position);
            if (span == null)
            {
                return;
            }

            if (span is TextSpan)
            {
                TextSpan textSpan = ((TextSpan)span);
                textSpan.Recognizer?.AddPointer(@event as PointerDownEvent);
            }

        }




        private void _LayoutText(double minWidth = 0.0, double maxWidth = default(double))
        {
            bool widthMatters = SoftWrap || Overflow == TextOverflow.Ellipsis;
            _TextPainter.Layout(minWidth: minWidth, maxWidth: widthMatters ? maxWidth : Dart.CoreDefaultClass.Double.Infinity);
        }




        public new void SystemFontsDidChange()
        {
            base.SystemFontsDidChange();
            _TextPainter.MarkNeedsLayout();
        }




        private void _LayoutTextWithConstraints(FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            _TextPainter.SetPlaceholderDimensions(_PlaceholderDimensions);
            _LayoutText(minWidth: constraints.MinWidth, maxWidth: constraints.MaxWidth);
        }




        private void _LayoutChildren(FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            if (ChildCount == 0)
            {
                return;
            }

            RenderBox child = FirstChild;
            _PlaceholderDimensions = List.CreateNew<PlaceholderDimensions>(ChildCount);
            int childIndex = 0;
            while (child != null)
            {
                child.Layout(new BoxConstraints(maxWidth: constraints.MaxWidth), parentUsesSize: true);
                double baselineOffset = default(double);
                switch (_PlaceholderSpans[childIndex].Alignment)
                {
                    case Ui.PlaceholderAlignment.Baseline:
                        {
                            baselineOffset = child.GetDistanceToBaseline(_PlaceholderSpans[childIndex].Baseline);
                            break;
                        }
                    default:
                        {
                            baselineOffset = null;
                            break;
                        }
                }
                _PlaceholderDimensions[childIndex] = new PlaceholderDimensions(size: child.Size, alignment: _PlaceholderSpans[childIndex].Alignment, baseline: _PlaceholderSpans[childIndex].Baseline, baselineOffset: baselineOffset);
                child = ChildAfter(child);
                childIndex += 1;
            }

        }




        private void _SetParentData()
        {
            RenderBox child = FirstChild;
            int childIndex = 0;
            while (child != null && childIndex < _TextPainter.InlinePlaceholderBoxes.Count)
            {
                TextParentData textParentData = child.ParentData as TextParentData;
                textParentData.Offset = new Offset(_TextPainter.InlinePlaceholderBoxes[childIndex].Left, _TextPainter.InlinePlaceholderBoxes[childIndex].Top);
                textParentData.Scale = _TextPainter.InlinePlaceholderScales[childIndex];
                child = ChildAfter(child);
                childIndex += 1;
            }

        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            _LayoutChildren(constraints);
            _LayoutTextWithConstraints(constraints);
            _SetParentData();
            Size textSize = _TextPainter.Size;
            bool textDidExceedMaxLines = _TextPainter.DidExceedMaxLines;
            Size = constraints.Constrain(textSize);
            bool didOverflowHeight = Size.Height < textSize.Height || textDidExceedMaxLines;
            bool didOverflowWidth = Size.Width < textSize.Width;
            bool hasVisualOverflow = didOverflowWidth || didOverflowHeight;
            if (hasVisualOverflow)
            {
                switch (_Overflow)
                {
                    case TextOverflow.Visible: _NeedsClipping = false; _OverflowShader = null; break;
                    case TextOverflow.Clip: case TextOverflow.Ellipsis: _NeedsClipping = true; _OverflowShader = null; break;
                    case TextOverflow.Fade:
                        _NeedsClipping = true; TextPainter fadeSizePainter = new TextPainter(text: new TextSpan(style: _TextPainter.Text.Style, text: "\u2026"), textDirection: TextDirection, textScaleFactor: TextScaleFactor, locale: Locale);
                        new TextPainter(text: new TextSpan(style: _TextPainter.Text.Style, text: "\u2026"), textDirection: TextDirection, textScaleFactor: TextScaleFactor, locale: Locale).Layout(); if (didOverflowWidth)
                        {
                            double fadeEnd fadeStart = default(double);
                            switch (TextDirection) { case TextDirection.Rtl: fadeEnd = 0.0; fadeStart = fadeSizePainter.Width; break; case TextDirection.Ltr: fadeEnd = Size.Width; fadeStart = fadeEnd - fadeSizePainter.Width; break; }
                            _OverflowShader = Dart.UI.Gradient.Linear(new Offset(fadeStart, 0.0), new Offset(fadeEnd, 0.0), new List<Color>() { new Color(0xFFFFFFFF), new Color(0x00FFFFFF) });
                        }
                        else
                        {
                            double fadeEnd = Size.Height;
                            double fadeStart = fadeEnd - fadeSizePainter.Height / 2.0;
                            _OverflowShader = Dart.UI.Gradient.Linear(new Offset(0.0, fadeStart), new Offset(0.0, fadeEnd), new List<Color>() { new Color(0xFFFFFFFF), new Color(0x00FFFFFF) });
                        }
                        break;
                }
            }
            else
            {
                _NeedsClipping = false;
                _OverflowShader = null;
            }

        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            _LayoutTextWithConstraints(Constraints);

            if (_NeedsClipping)
            {
                Rect bounds = offset & Size;
                if (_OverflowShader != null)
                {
                    context.Canvas.SaveLayer(bounds, new Paint());
                }
                else
                {
                    context.Canvas.Save();
                }

                context.Canvas.ClipRect(bounds);
            }

            _TextPainter.Paint(context.Canvas, offset);
            RenderBox child = FirstChild;
            int childIndex = 0;
            while (child != null && childIndex < _TextPainter.InlinePlaceholderBoxes.Count)
            {
                TextParentData textParentData = child.ParentData as TextParentData;
                double scale = textParentData.Scale;
                context.PushTransform(NeedsCompositing, offset + textParentData.Offset, Matrix4.Diagonal3Values(scale, scale, scale), (PaintingContext context, Offset offset) =>
                {
                    context.PaintChild(child, offset);
                }
                );
                child = ChildAfter(child);
                childIndex += 1;
            }

            if (_NeedsClipping)
            {
                if (_OverflowShader != null)
                {
                    context.Canvas.Translate(offset.Dx, offset.Dy);
                    Paint paint = new Paint()..BlendMode = BlendMode.Modulate..Shader = _OverflowShader;
                    context.Canvas.DrawRect(Dart.UI.UiDefaultClass.Offset.Zero & Size, paint);
                }

                context.Canvas.Restore();
            }

        }




        /// <Summary>
        /// Returns the offset at which to paint the caret.
        ///
        /// Valid only after [layout].
        /// </Summary>
        public virtual Offset GetOffsetForCaret(TextPosition position, FlutterBinding.UI.Rect caretPrototype)
        {

            _LayoutTextWithConstraints(Constraints);
            return _TextPainter.GetOffsetForCaret(position, caretPrototype);
        }




        /// <Summary>
        /// Returns a list of rects that bound the given selection.
        ///
        /// A given selection might have more than one rect if this text painter
        /// contains bidirectional text because logically contiguous text might not be
        /// visually contiguous.
        ///
        /// Valid only after [layout].
        /// </Summary>
        public virtual List<TextBox> GetBoxesForSelection(FlutterSDK.Services.Textediting.TextSelection selection)
        {

            _LayoutTextWithConstraints(Constraints);
            return _TextPainter.GetBoxesForSelection(selection);
        }




        /// <Summary>
        /// Returns the position within the text for the given pixel offset.
        ///
        /// Valid only after [layout].
        /// </Summary>
        public virtual TextPosition GetPositionForOffset(FlutterBinding.UI.Offset offset)
        {

            _LayoutTextWithConstraints(Constraints);
            return _TextPainter.GetPositionForOffset(offset);
        }




        /// <Summary>
        /// Returns the text range of the word at the given offset. Characters not
        /// part of a word, such as spaces, symbols, and punctuation, have word breaks
        /// on both sides. In such cases, this method will return a text range that
        /// contains the given text position.
        ///
        /// Word boundaries are defined more precisely in Unicode Standard Annex #29
        /// <http://www.unicode.org/reports/tr29/#Word_Boundaries>.
        ///
        /// Valid only after [layout].
        /// </Summary>
        public virtual TextRange GetWordBoundary(TextPosition position)
        {

            _LayoutTextWithConstraints(Constraints);
            return _TextPainter.GetWordBoundary(position);
        }




        /// <Summary>
        /// Combines _semanticsInfo entries where permissible, determined by
        /// [InlineSpanSemanticsInformation.requiresOwnNode].
        /// </Summary>
        private List<FlutterSDK.Painting.Inlinespan.InlineSpanSemanticsInformation> _CombineSemanticsInfo()
        {

            List<InlineSpanSemanticsInformation> combined = new List<InlineSpanSemanticsInformation>() { };
            string workingText = "";
            string workingLabel = default(string);
            foreach (InlineSpanSemanticsInformation info in _SemanticsInfo)
            {
                if (info.RequiresOwnNode)
                {
                    if (workingText != null)
                    {
                        combined.Add(new InlineSpanSemanticsInformation(workingText, semanticsLabel: workingLabel ?? workingText));
                        workingText = "";
                        workingLabel = null;
                    }

                    combined.Add(info);
                }
                else
                {
                    workingText += info.Text;
                    workingLabel = (workingLabel == null ? "" : workingLabel);
                    if (info.SemanticsLabel != null)
                    {
                        workingLabel += info.SemanticsLabel;
                    }
                    else
                    {
                        workingLabel += info.Text;
                    }

                }

            }

            if (workingText != null)
            {
                combined.Add(new InlineSpanSemanticsInformation(workingText, semanticsLabel: workingLabel));
            }
            else
            {

            }

            return combined;
        }




        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            _SemanticsInfo = Text.GetSemanticsInformation();
            if (_SemanticsInfo.Any((InlineSpanSemanticsInformation info) => =>info.Recognizer != null))
            {
                config.ExplicitChildNodes = true;
                config.IsSemanticBoundary = true;
            }
            else
            {
                StringBuffer buffer = new StringBuffer();
                foreach (InlineSpanSemanticsInformation info in _SemanticsInfo)
                {
                    buffer.Write(info.SemanticsLabel ?? info.Text);
                }

                config.Label = buffer.ToString();
                config.TextDirection = TextDirection;
            }

        }




        public new void AssembleSemanticsNode(FlutterSDK.Semantics.Semantics.SemanticsNode node, FlutterSDK.Semantics.Semantics.SemanticsConfiguration config, Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> children)
        {

            List<SemanticsNode> newChildren = new List<SemanticsNode>() { };
            TextDirection currentDirection = TextDirection;
            Rect currentRect = default(Rect);
            double ordinal = 0.0;
            int start = 0;
            int placeholderIndex = 0;
            RenderBox child = FirstChild;
            Queue<SemanticsNode> newChildCache = Queue.CreateNew<SemanticsNode>();
            foreach (InlineSpanSemanticsInformation info in _CombineSemanticsInfo())
            {
                TextDirection initialDirection = currentDirection;
                TextSelection selection = new TextSelection(baseOffset: start, extentOffset: start + info.Text.Length);
                List<Dart.UI.TextBox> rects = GetBoxesForSelection(selection);
                if (rects.IsEmpty())
                {
                    continue;
                }

                Rect rect = rects.First.ToRect();
                currentDirection = rects.First.Direction;
                foreach (Dart.UI.TextBox textBox in rects.Skip(1))
                {
                    rect = rect.ExpandToInclude(textBox.ToRect());
                    currentDirection = textBox.Direction;
                }

                rect = Rect.FromLTWH(Dart.Math.MathDefaultClass.Max(0.0, rect.Left), Dart.Math.MathDefaultClass.Max(0.0, rect.Top), Dart.Math.MathDefaultClass.Min(rect.Width, Constraints.MaxWidth), Dart.Math.MathDefaultClass.Min(rect.Height, Constraints.MaxHeight));
                currentRect = Rect.FromLTRB(rect.Left.FloorToDouble() - 4.0, rect.Top.FloorToDouble() - 4.0, rect.Right.CeilToDouble() + 4.0, rect.Bottom.CeilToDouble() + 4.0);
                if (info.IsPlaceholder)
                {
                    SemanticsNode childNode = children.ElementAt(placeholderIndex++);
                    TextParentData parentData = child.ParentData as TextParentData;
                    childNode.Rect = Rect.FromLTWH(childNode.Rect.Left, childNode.Rect.Top, childNode.Rect.Width * parentData.Scale, childNode.Rect.Height * parentData.Scale);
                    newChildren.Add(childNode);
                    child = ChildAfter(child);
                }
                else
                {
                    SemanticsConfiguration configuration = new SemanticsConfiguration()..SortKey = new OrdinalSortKey(ordinal++)..TextDirection = initialDirection..Label = info.SemanticsLabel ?? info.Text;
                    GestureRecognizer recognizer = info.Recognizer;
                    if (recognizer != null)
                    {
                        if (((TapGestureRecognizer)recognizer) is TapGestureRecognizer)
                        {
                            configuration.OnTap = ((TapGestureRecognizer)recognizer).OnTap;
                            configuration.IsLink = true;
                        }
                        else if (recognizer is LongPressGestureRecognizer)
                        {
                            configuration.OnLongPress = ((LongPressGestureRecognizer)recognizer).OnLongPress;
                        }
                        else
                        {

                        }

                    }

                    SemanticsNode newChild = (_CachedChildNodes?.IsNotEmpty == true) ? _CachedChildNodes.RemoveFirst() : new SemanticsNode();
                    ;
                    newChild.UpdateWith(config: configuration)..Rect = currentRect;
                    newChildCache.AddLast(newChild);
                    newChildren.Add(newChild);
                }

                start += info.Text.Length;
            }

            _CachedChildNodes = newChildCache;
            node.UpdateWith(config: config, childrenInInversePaintOrder: newChildren);
        }




        public new void ClearSemantics()
        {
            base.ClearSemantics();
            _CachedChildNodes = null;
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            return new List<DiagnosticsNode>() { Text.ToDiagnosticsNode(name: "text", style: DiagnosticsTreeStyle.Transition) };
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<TextAlign>("textAlign", TextAlign));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection));
            properties.Add(new FlagProperty("softWrap", value: SoftWrap, ifTrue: "wrapping at box width", ifFalse: "no wrapping except at line break characters", showName: true));
            properties.Add(new EnumProperty<TextOverflow>("overflow", Overflow));
            properties.Add(new DoubleProperty("textScaleFactor", TextScaleFactor, defaultValue: 1.0));
            properties.Add(new DiagnosticsProperty<Locale>("locale", Locale, defaultValue: null));
            properties.Add(new IntProperty("maxLines", MaxLines, ifNull: "unlimited"));
        }



    }


    /// <Summary>
    /// How overflowing text should be handled.
    ///
    /// A [TextOverflow] can be passed to [Text] and [RichText] via their
    /// [Text.overflow] and [RichText.overflow] properties respectively.
    /// </Summary>
    public enum TextOverflow
    {

        /// <Summary>
        /// Clip the overflowing text to fix its container.
        /// </Summary>
        Clip,
        /// <Summary>
        /// Fade the overflowing text to transparent.
        /// </Summary>
        Fade,
        /// <Summary>
        /// Use an ellipsis to indicate that the text has overflowed.
        /// </Summary>
        Ellipsis,
        /// <Summary>
        /// Render overflowing text outside of its container.
        /// </Summary>
        Visible,
    }

}
