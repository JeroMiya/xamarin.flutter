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
namespace FlutterSDK.Painting.Textpainter
{
    internal static class TextpainterDefaultClass
    {
    }

    /// <Summary>
    /// Holds the [Size] and baseline required to represent the dimensions of
    /// a placeholder in text.
    ///
    /// Placeholders specify an empty space in the text layout, which is used
    /// to later render arbitrary inline widgets into defined by a [WidgetSpan].
    ///
    /// The [size] and [alignment] properties are required and cannot be null.
    ///
    /// See also:
    ///
    ///  * [WidgetSpan], a subclass of [InlineSpan] and [PlaceholderSpan] that
    ///    represents an inline widget embedded within text. The space this
    ///    widget takes is indicated by a placeholder.
    ///  * [RichText], a text widget that supports text inline widgets.
    /// </Summary>
    public class PlaceholderDimensions
    {
        /// <Summary>
        /// Constructs a [PlaceholderDimensions] with the specified parameters.
        ///
        /// The `size` and `alignment` are required as a placeholder's dimensions
        /// require at least `size` and `alignment` to be fully defined.
        /// </Summary>
        public PlaceholderDimensions(Size size = default(Size), PlaceholderAlignment alignment = default(PlaceholderAlignment), TextBaseline baseline = default(TextBaseline), double baselineOffset = default(double))
        : base()
        {
            this.Size = size;
            this.Alignment = alignment;
            this.Baseline = baseline;
            this.BaselineOffset = baselineOffset;
        }
        /// <Summary>
        /// Width and height dimensions of the placeholder.
        /// </Summary>
        public virtual Size Size { get; set; }
        /// <Summary>
        /// How to align the placeholder with the text.
        ///
        /// See also:
        ///
        ///  * [baseline], the baseline to align to when using
        ///    [ui.PlaceholderAlignment.baseline],
        ///    [ui.PlaceholderAlignment.aboveBaseline],
        ///    or [ui.PlaceholderAlignment.underBaseline].
        ///  * [baselineOffset], the distance of the alphabetic baseline from the upper
        ///    edge of the placeholder.
        /// </Summary>
        public virtual PlaceholderAlignment Alignment { get; set; }
        /// <Summary>
        /// Distance of the [baseline] from the upper edge of the placeholder.
        ///
        /// Only used when [alignment] is [ui.PlaceholderAlignment.baseline].
        /// </Summary>
        public virtual double BaselineOffset { get; set; }
        /// <Summary>
        /// The [TextBaseline] to align to. Used with:
        ///
        ///  * [ui.PlaceholderAlignment.baseline]
        ///  * [ui.PlaceholderAlignment.aboveBaseline]
        ///  * [ui.PlaceholderAlignment.underBaseline]
        ///  * [ui.PlaceholderAlignment.middle]
        /// </Summary>
        public virtual TextBaseline Baseline { get; set; }

    }


    /// <Summary>
    /// This is used to cache and pass the computed metrics regarding the
    /// caret's size and position. This is preferred due to the expensive
    /// nature of the calculation.
    /// </Summary>
    public class _CaretMetrics
    {
        public _CaretMetrics(FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), double fullHeight = default(double))
        {
            this.Offset = offset;
            this.FullHeight = fullHeight;
        }
        /// <Summary>
        /// The offset of the top left corner of the caret from the top left
        /// corner of the paragraph.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset Offset { get; set; }
        /// <Summary>
        /// The full height of the glyph at the caret position.
        /// </Summary>
        public virtual double FullHeight { get; set; }
    }


    /// <Summary>
    /// An object that paints a [TextSpan] tree into a [Canvas].
    ///
    /// To use a [TextPainter], follow these steps:
    ///
    /// 1. Create a [TextSpan] tree and pass it to the [TextPainter]
    ///    constructor.
    ///
    /// 2. Call [layout] to prepare the paragraph.
    ///
    /// 3. Call [paint] as often as desired to paint the paragraph.
    ///
    /// If the width of the area into which the text is being painted
    /// changes, return to step 2. If the text to be painted changes,
    /// return to step 1.
    ///
    /// The default text style is white. To change the color of the text,
    /// pass a [TextStyle] object to the [TextSpan] in `text`.
    /// </Summary>
    public class TextPainter
    {
        /// <Summary>
        /// Creates a text painter that paints the given text.
        ///
        /// The `text` and `textDirection` arguments are optional but [text] and
        /// [textDirection] must be non-null before calling [layout].
        ///
        /// The [textAlign] property must not be null.
        ///
        /// The [maxLines] property, if non-null, must be greater than zero.
        /// </Summary>
        public TextPainter(FlutterSDK.Painting.Inlinespan.InlineSpan text = default(FlutterSDK.Painting.Inlinespan.InlineSpan), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), double textScaleFactor = 1.0, int maxLines = default(int), string ellipsis = default(string), Locale locale = default(Locale), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), TextHeightBehavior textHeightBehavior = default(TextHeightBehavior))
        : base()
        {

        }
        internal virtual FlutterBinding.UI.Paragraph _Paragraph { get; set; }
        internal virtual bool _NeedsLayout { get; set; }
        internal virtual FlutterSDK.Painting.Inlinespan.InlineSpan _Text { get; set; }
        internal virtual TextAlign _TextAlign { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual double _TextScaleFactor { get; set; }
        internal virtual string _Ellipsis { get; set; }
        internal virtual Locale _Locale { get; set; }
        internal virtual int _MaxLines { get; set; }
        internal virtual FlutterSDK.Painting.Strutstyle.StrutStyle _StrutStyle { get; set; }
        internal virtual FlutterSDK.Painting.Textpainter.TextWidthBasis _TextWidthBasis { get; set; }
        internal virtual TextHeightBehavior _TextHeightBehavior { get; set; }
        internal virtual FlutterBinding.UI.Paragraph _LayoutTemplate { get; set; }
        internal virtual List<TextBox> _InlinePlaceholderBoxes { get; set; }
        internal virtual List<double> _InlinePlaceholderScales { get; set; }
        internal virtual List<FlutterSDK.Painting.Textpainter.PlaceholderDimensions> _PlaceholderDimensions { get; set; }
        internal virtual double _LastMinWidth { get; set; }
        internal virtual double _LastMaxWidth { get; set; }
        internal virtual int _ZwjUtf16 { get; set; }
        internal virtual FlutterSDK.Painting.Textpainter._CaretMetrics _CaretMetrics { get; set; }
        internal virtual TextPosition _PreviousCaretPosition { get; set; }
        internal virtual FlutterBinding.UI.Rect _PreviousCaretPrototype { get; set; }
        public virtual FlutterSDK.Painting.Inlinespan.InlineSpan Text { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextAlign TextAlign { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double TextScaleFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string Ellipsis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Locale Locale { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int MaxLines { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextHeightBehavior TextHeightBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual List<TextBox> InlinePlaceholderBoxes { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual List<double> InlinePlaceholderScales { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double PreferredLineHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MinIntrinsicWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MaxIntrinsicWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Width { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Height { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Size Size { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DidExceedMaxLines { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterBinding.UI.Offset _EmptyOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Marks this text painter's layout information as dirty and removes cached
        /// information.
        ///
        /// Uses this method to notify text painter to relayout in the case of
        /// layout changes in engine. In most cases, updating text painter properties
        /// in framework will automatically invoke this method.
        /// </Summary>
        public virtual void MarkNeedsLayout()
        {
            _Paragraph = null;
            _NeedsLayout = true;
            _PreviousCaretPosition = null;
            _PreviousCaretPrototype = null;
        }




        /// <Summary>
        /// Sets the dimensions of each placeholder in [text].
        ///
        /// The number of [PlaceholderDimensions] provided should be the same as the
        /// number of [PlaceholderSpan]s in text. Passing in an empty or null `value`
        /// will do nothing.
        ///
        /// If [layout] is attempted without setting the placeholder dimensions, the
        /// placeholders will be ignored in the text layout and no valid
        /// [inlinePlaceholderBoxes] will be returned.
        /// </Summary>
        public virtual void SetPlaceholderDimensions(List<FlutterSDK.Painting.Textpainter.PlaceholderDimensions> value)
        {
            if (value == null || value.IsEmpty() || CollectionsDefaultClass.ListEquals(value, _PlaceholderDimensions))
            {
                return;
            }


            _PlaceholderDimensions = value;
            MarkNeedsLayout();
        }




        private ParagraphStyle _CreateParagraphStyle(TextDirection defaultTextDirection = default(TextDirection))
        {


            return _Text.Style?.GetParagraphStyle(textAlign: TextAlign, textDirection: TextDirection ?? defaultTextDirection, textScaleFactor: TextScaleFactor, maxLines: _MaxLines, textHeightBehavior: _TextHeightBehavior, ellipsis: _Ellipsis, locale: _Locale, strutStyle: _StrutStyle) ?? new Ui.ParagraphStyle(textAlign: TextAlign, textDirection: TextDirection ?? defaultTextDirection, maxLines: MaxLines, textHeightBehavior: _TextHeightBehavior, ellipsis: Ellipsis, locale: Locale);
        }




        private double _ApplyFloatingPointHack(double layoutValue)
        {
            return layoutValue.CeilToDouble();
        }




        /// <Summary>
        /// Returns the distance from the top of the text to the first baseline of the
        /// given type.
        ///
        /// Valid only after [layout] has been called.
        /// </Summary>
        public virtual double ComputeDistanceToActualBaseline(TextBaseline baseline)
        {


            switch (baseline) { case TextBaseline.Alphabetic: return _Paragraph.AlphabeticBaseline; case TextBaseline.Ideographic: return _Paragraph.IdeographicBaseline; }
            return null;
        }




        /// <Summary>
        /// Computes the visual position of the glyphs for painting the text.
        ///
        /// The text will layout with a width that's as close to its max intrinsic
        /// width as possible while still being greater than or equal to `minWidth` and
        /// less than or equal to `maxWidth`.
        ///
        /// The [text] and [textDirection] properties must be non-null before this is
        /// called.
        /// </Summary>
        public virtual void Layout(double minWidth = 0.0, double maxWidth = default(double))
        {


            if (!_NeedsLayout && minWidth == _LastMinWidth && maxWidth == _LastMaxWidth) return;
            _NeedsLayout = false;
            if (_Paragraph == null)
            {
                Dart.UI.ParagraphBuilder builder = new Ui.ParagraphBuilder(_CreateParagraphStyle());
                _Text.Build(builder, textScaleFactor: TextScaleFactor, dimensions: _PlaceholderDimensions);
                _InlinePlaceholderScales = builder.PlaceholderScales;
                _Paragraph = builder.Build();
            }

            _LastMinWidth = minWidth;
            _LastMaxWidth = maxWidth;
            _Paragraph.Layout(new Ui.ParagraphConstraints(width: maxWidth));
            if (minWidth != maxWidth)
            {
                double newWidth = MaxIntrinsicWidth.Clamp(minWidth, maxWidth) as double;
                if (newWidth != Width)
                {
                    _Paragraph.Layout(new Ui.ParagraphConstraints(width: newWidth));
                }

            }

            _InlinePlaceholderBoxes = _Paragraph.GetBoxesForPlaceholders();
        }




        /// <Summary>
        /// Paints the text onto the given canvas at the given offset.
        ///
        /// Valid only after [layout] has been called.
        ///
        /// If you cannot see the text being painted, check that your text color does
        /// not conflict with the background on which you are drawing. The default
        /// text color is white (to contrast with the default black background color),
        /// so if you are writing an application with a white background, the text
        /// will not be visible by default.
        ///
        /// To set the text style, specify a [TextStyle] when creating the [TextSpan]
        /// that you pass to the [TextPainter] constructor or to the [text] property.
        /// </Summary>
        public virtual void Paint(Canvas canvas, FlutterBinding.UI.Offset offset)
        {

            canvas.DrawParagraph(_Paragraph, offset);
        }




        private bool _IsUtf16Surrogate(int value)
        {
            return value & 0xF800 == 0xD800;
        }




        private bool _IsUnicodeDirectionality(int value)
        {
            return value == 0x200F || value == 0x200E;
        }




        /// <Summary>
        /// Returns the closest offset after `offset` at which the input cursor can be
        /// positioned.
        /// </Summary>
        public virtual int GetOffsetAfter(int offset)
        {
            int nextCodeUnit = _Text.CodeUnitAt(offset);
            if (nextCodeUnit == null) return null;
            return _IsUtf16Surrogate(nextCodeUnit) ? offset + 2 : offset + 1;
        }




        /// <Summary>
        /// Returns the closest offset before `offset` at which the input cursor can
        /// be positioned.
        /// </Summary>
        public virtual int GetOffsetBefore(int offset)
        {
            int prevCodeUnit = _Text.CodeUnitAt(offset - 1);
            if (prevCodeUnit == null) return null;
            return _IsUtf16Surrogate(prevCodeUnit) ? offset - 2 : offset - 1;
        }




        private Rect _GetRectFromUpstream(int offset, FlutterBinding.UI.Rect caretPrototype)
        {
            string flattenedText = _Text.ToPlainText(includePlaceholders: false);
            int prevCodeUnit = _Text.CodeUnitAt(Dart.Math.MathDefaultClass.Max(0, offset - 1));
            if (prevCodeUnit == null) return null;
            bool needsSearch = _IsUtf16Surrogate(prevCodeUnit) || _Text.CodeUnitAt(offset) == _ZwjUtf16 || _IsUnicodeDirectionality(prevCodeUnit);
            int graphemeClusterLength = needsSearch ? 2 : 1;
            List<TextBox> boxes = new List<TextBox>() { };
            while (boxes.IsEmpty() && flattenedText != null)
            {
                int prevRuneOffset = offset - graphemeClusterLength;
                boxes = _Paragraph.GetBoxesForRange(prevRuneOffset, offset, boxHeightStyle: Ui.BoxHeightStyle.Strut);
                if (boxes.IsEmpty())
                {
                    if (!needsSearch)
                    {
                        break;
                    }

                    if (prevRuneOffset < -flattenedText.Length)
                    {
                        break;
                    }

                    graphemeClusterLength *= 2;
                    continue;
                }

                TextBox box = boxes.First;
                int NEWLINE_CODE_UNIT = 10;
                if (prevCodeUnit == NEWLINE_CODE_UNIT)
                {
                    return Rect.FromLTRB(_EmptyOffset.Dx, box.Bottom, _EmptyOffset.Dx, box.Bottom + box.Bottom - box.Top);
                }

                double caretEnd = box.End;
                double dx = box.Direction == TextDirection.Rtl ? caretEnd - caretPrototype.Width : caretEnd;
                return Rect.FromLTRB(Dart.Math.MathDefaultClass.Min(dx, _Paragraph.Width), box.Top, Dart.Math.MathDefaultClass.Min(dx, _Paragraph.Width), box.Bottom);
            }

            return null;
        }




        private Rect _GetRectFromDownstream(int offset, FlutterBinding.UI.Rect caretPrototype)
        {
            string flattenedText = _Text.ToPlainText(includePlaceholders: false);
            int nextCodeUnit = _Text.CodeUnitAt(Dart.Math.MathDefaultClass.Min(offset, flattenedText == null ? 0 : flattenedText.Length - 1));
            if (nextCodeUnit == null) return null;
            bool needsSearch = _IsUtf16Surrogate(nextCodeUnit) || nextCodeUnit == _ZwjUtf16 || _IsUnicodeDirectionality(nextCodeUnit);
            int graphemeClusterLength = needsSearch ? 2 : 1;
            List<TextBox> boxes = new List<TextBox>() { };
            while (boxes.IsEmpty() && flattenedText != null)
            {
                int nextRuneOffset = offset + graphemeClusterLength;
                boxes = _Paragraph.GetBoxesForRange(offset, nextRuneOffset, boxHeightStyle: Ui.BoxHeightStyle.Strut);
                if (boxes.IsEmpty())
                {
                    if (!needsSearch)
                    {
                        break;
                    }

                    if (nextRuneOffset >= flattenedText.Length << 1)
                    {
                        break;
                    }

                    graphemeClusterLength *= 2;
                    continue;
                }

                TextBox box = boxes.Last();
                double caretStart = box.Start;
                double dx = box.Direction == TextDirection.Rtl ? caretStart - caretPrototype.Width : caretStart;
                return Rect.FromLTRB(Dart.Math.MathDefaultClass.Min(dx, _Paragraph.Width), box.Top, Dart.Math.MathDefaultClass.Min(dx, _Paragraph.Width), box.Bottom);
            }

            return null;
        }




        /// <Summary>
        /// Returns the offset at which to paint the caret.
        ///
        /// Valid only after [layout] has been called.
        /// </Summary>
        public virtual Offset GetOffsetForCaret(TextPosition position, FlutterBinding.UI.Rect caretPrototype)
        {
            _ComputeCaretMetrics(position, caretPrototype);
            return _CaretMetrics.Offset;
        }




        /// <Summary>
        /// Returns the tight bounded height of the glyph at the given [position].
        ///
        /// Valid only after [layout] has been called.
        /// </Summary>
        public virtual double GetFullHeightForCaret(TextPosition position, FlutterBinding.UI.Rect caretPrototype)
        {
            _ComputeCaretMetrics(position, caretPrototype);
            return _CaretMetrics.FullHeight;
        }




        private void _ComputeCaretMetrics(TextPosition position, FlutterBinding.UI.Rect caretPrototype)
        {

            if (position == _PreviousCaretPosition && caretPrototype == _PreviousCaretPrototype) return;
            int offset = position.Offset;

            Rect rect = default(Rect);
            switch (position.Affinity)
            {
                case TextAffinity.Upstream:
                    {
                        rect = _GetRectFromUpstream(offset, caretPrototype) ?? _GetRectFromDownstream(offset, caretPrototype);
                        break;
                    }
                case TextAffinity.Downstream:
                    {
                        rect = _GetRectFromDownstream(offset, caretPrototype) ?? _GetRectFromUpstream(offset, caretPrototype);
                        break;
                    }
            }
            _CaretMetrics = new _CaretMetrics(offset: rect != null ? new Offset(rect.Left, rect.Top) : _EmptyOffset, fullHeight: rect != null ? rect.Bottom - rect.Top : null);
            _PreviousCaretPosition = position;
            _PreviousCaretPrototype = caretPrototype;
        }




        /// <Summary>
        /// Returns a list of rects that bound the given selection.
        ///
        /// The [boxHeightStyle] and [boxWidthStyle] arguments may be used to select
        /// the shape of the [TextBox]s. These properties default to
        /// [ui.BoxHeightStyle.tight] and [ui.BoxWidthStyle.tight] respectively and
        /// must not be null.
        ///
        /// A given selection might have more than one rect if this text painter
        /// contains bidirectional text because logically contiguous text might not be
        /// visually contiguous.
        /// </Summary>
        public virtual List<TextBox> GetBoxesForSelection(FlutterSDK.Services.Textediting.TextSelection selection, BoxHeightStyle boxHeightStyle = default(BoxHeightStyle), BoxWidthStyle boxWidthStyle = default(BoxWidthStyle))
        {



            return _Paragraph.GetBoxesForRange(selection.Start, selection.End, boxHeightStyle: boxHeightStyle, boxWidthStyle: boxWidthStyle);
        }




        /// <Summary>
        /// Returns the position within the text for the given pixel offset.
        /// </Summary>
        public virtual TextPosition GetPositionForOffset(FlutterBinding.UI.Offset offset)
        {

            return _Paragraph.GetPositionForOffset(offset);
        }




        /// <Summary>
        /// Returns the text range of the word at the given offset. Characters not
        /// part of a word, such as spaces, symbols, and punctuation, have word breaks
        /// on both sides. In such cases, this method will return a text range that
        /// contains the given text position.
        ///
        /// Word boundaries are defined more precisely in Unicode Standard Annex #29
        /// <http://www.unicode.org/reports/tr29/#Word_Boundaries>.
        /// </Summary>
        public virtual TextRange GetWordBoundary(TextPosition position)
        {

            return _Paragraph.GetWordBoundary(position);
        }




        /// <Summary>
        /// Returns the text range of the line at the given offset.
        ///
        /// The newline, if any, is included in the range.
        /// </Summary>
        public virtual TextRange GetLineBoundary(TextPosition position)
        {

            return _Paragraph.GetLineBoundary(position);
        }




        /// <Summary>
        /// Returns the full list of [LineMetrics] that describe in detail the various
        /// metrics of each laid out line.
        ///
        /// The [LineMetrics] list is presented in the order of the lines they represent.
        /// For example, the first line is in the zeroth index.
        ///
        /// [LineMetrics] contains measurements such as ascent, descent, baseline, and
        /// width for the line as a whole, and may be useful for aligning additional
        /// widgets to a particular line.
        ///
        /// Valid only after [layout] has been called.
        ///
        /// This can potentially return a large amount of data, so it is not recommended
        /// to repeatedly call this. Instead, cache the results. The cached results
        /// should be invalidated upon the next successful [layout].
        /// </Summary>
        public virtual List<LineMetrics> ComputeLineMetrics()
        {

            return _Paragraph.ComputeLineMetrics();
        }



    }


    /// <Summary>
    /// The different ways of measuring the width of one or more lines of text.
    ///
    /// See [Text.textWidthBasis], for example.
    /// </Summary>
    public enum TextWidthBasis
    {

        /// <Summary>
        /// multiline text will take up the full width given by the parent. For single
        /// line text, only the minimum amount of width needed to contain the text
        /// will be used. A common use case for this is a standard series of
        /// paragraphs.
        /// </Summary>
        Parent,
        /// <Summary>
        /// The width will be exactly enough to contain the longest line and no
        /// longer. A common use case for this is chat bubbles.
        /// </Summary>
        LongestLine,
    }

}
