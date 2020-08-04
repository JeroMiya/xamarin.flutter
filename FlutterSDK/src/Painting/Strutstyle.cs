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
namespace FlutterSDK.Painting.Strutstyle
{
    internal static class StrutstyleDefaultClass
    {
    }

    /// <Summary>
    /// Defines the strut, which sets the minimum height a line can be
    /// relative to the baseline.
    ///
    /// Strut applies to all lines in the paragraph. Strut is a feature that
    /// allows minimum line heights to be set. The effect is as if a zero
    /// width space was included at the beginning of each line in the
    /// paragraph. This imaginary space is 'shaped' according the properties
    /// defined in this class. Flutter's strut is based on
    /// [typesetting strut](https://en.wikipedia.org/wiki/Strut_(typesetting))
    /// and CSS's [line-height](https://www.w3.org/TR/CSS2/visudet.html#line-height).
    ///
    /// No lines may be shorter than the strut. The ascent and descent of the
    /// strut are calculated, and any laid out text that has a shorter ascent or
    /// descent than the strut's ascent or descent will take the ascent and
    /// descent of the strut. Text with ascents or descents larger than the
    /// strut's ascent or descent will layout as normal and extend past the strut.
    ///
    /// Strut is defined independently from any text content or [TextStyle]s.
    ///
    /// The vertical components of strut are as follows:
    ///
    ///  * Half the font-defined leading
    ///  * `ascent * height`
    ///  * `descent * height`
    ///  * Half the font-defined leading
    ///
    /// The sum of these four values is the total height of the line.
    ///
    /// Ascent is the font's spacing above the baseline without leading and
    /// descent is the spacing below the baseline without leading. Leading is
    /// split evenly between the top and bottom. The values for `ascent` and
    /// `descent` are provided by the font named by [fontFamily]. If no
    /// [fontFamily] or [fontFamilyFallback] is provided, then the platform's
    /// default family will be used. Many fonts will have leading values of
    /// zero, so in practice, the leading component is often irrelevant.
    ///
    /// When [height] is omitted or null, then the font defined ascent and descent
    /// will be used. The font's combined ascent and descent may be taller or
    /// shorter than the [fontSize]. When [height] is provided, the line's EM-square
    /// ascent and descent (which sums to [fontSize]) will be scaled by [height] to
    /// achieve a final line height of `fontSize * height + fontSize * leading`
    /// logical pixels. The proportion of ascent:descent with [height] specified
    /// is the same as the font metrics defined ascent:descent ratio.
    ///
    /// ![Text height diagram](https://flutter.github.io/assets-for-api-docs/assets/painting/text_height_diagram.png)
    ///
    /// Each line's spacing above the baseline will be at least as tall as the
    /// half leading plus ascent. Each line's spacing below the baseline will
    /// be at least as tall as the half leading plus descent.
    ///
    /// See also:
    ///
    ///  * [StrutStyle](dart-ui/StrutStyle-class.html), the class in the [dart:ui] library.
    ///
    /// ### Fields and their default values.
    ///
    /// Omitted or null properties will take the default values specified below:
    ///
    ///  * [fontFamily]: the name of the font to use when calculating the strut
    ///    (e.g., Roboto). No glyphs from the font will be drawn and the font will
    ///    be used purely for metrics.
    ///
    ///  * [fontFamilyFallback]: an ordered list of font family names that will
    ///    be searched for when the font in [fontFamily] cannot be found. When
    ///    all specified font families have been exhausted an no match was found,
    ///    the default platform font will be used.
    ///
    ///  * [fontSize]: the size of the ascent plus descent in logical pixels. This
    ///    is also used as the basis of the custom leading calculation. This value
    ///    cannot be negative.
    ///    Default is 14 logical pixels.
    ///
    ///  * [height]: the multiple of [fontSize] the line's height should be.
    ///    The line's height will take the font's ascent and descent values if
    ///    [height] is omitted or null. If provided, the EM-square ascent and
    ///    descent (which sum to [fontSize]) is scaled by [height].
    ///    The [height] will impact the spacing above and below the baseline
    ///    differently depending on the ratios between the font's ascent and
    ///    descent. This property is separate from the leading multiplier, which
    ///    is controlled through [leading].
    ///    Default is null.
    ///
    ///  * [leading]: the custom leading to apply to the strut as a multiple of
    ///    [fontSize]. Leading is additional spacing between lines. Half of the
    ///    leading is added to the top and the other half to the bottom of the
    ///    line height. This differs from [height] since the spacing is equally
    ///    distributed above and below the baseline.
    ///    Default is null, which will use the font-specified leading.
    ///
    ///  * [fontWeight]: the typeface thickness to use when calculating the strut
    ///    (e.g., bold).
    ///    Default is [FontWeight.w400].
    ///
    ///  * [fontStyle]: the typeface variant to use when calculating the strut
    ///    (e.g., italic).
    ///    Default is [FontStyle.normal].
    ///
    ///  * [forceStrutHeight]: when true, all lines will be laid out with the
    ///    height of the strut. All line and run-specific metrics will be
    ///    ignored/overridden and only strut metrics will be used instead.
    ///    This property guarantees uniform line spacing, however text in
    ///    adjacent lines may overlap. This property should be enabled with
    ///    caution as it bypasses a large portion of the vertical layout system.
    ///    The default value is false.
    ///
    /// ### Examples
    ///
    /// {@tool snippet}
    /// In this simple case, the text will be rendered at font size 10, however,
    /// the vertical height of each line will be the strut height (Roboto in
    /// font size 30 * 1.5) as the text itself is shorter than the strut.
    ///
    /// ```dart
    /// const Text(
    ///   'Hello, world!\nSecond line!',
    ///   style: TextStyle(
    ///     fontSize: 10,
    ///     fontFamily: 'Raleway',
    ///   ),
    ///   strutStyle: StrutStyle(
    ///     fontFamily: 'Roboto',
    ///     fontSize: 30,
    ///     height: 1.5,
    ///   ),
    /// ),
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    /// Here, strut is used to absorb the additional line height in the second line.
    /// The strut [height] was defined as 1.5 (the default font size is 14), which
    /// caused all lines to be laid out taller than without strut. This extra space
    /// was able to accommodate the larger font size of `Second line!` without
    /// causing the line height to change for the second line only. All lines in
    /// this example are thus the same height (`14 * 1.5`).
    ///
    /// ```dart
    /// const Text.rich(
    ///   TextSpan(
    ///     text: 'First line!\n',
    ///     style: TextStyle(
    ///       fontSize: 14,
    ///       fontFamily: 'Roboto'
    ///     ),
    ///     children: <TextSpan>[
    ///       TextSpan(
    ///         text: 'Second line!\n',
    ///         style: TextStyle(
    ///           fontSize: 16,
    ///           fontFamily: 'Roboto',
    ///         ),
    ///       ),
    ///       TextSpan(
    ///         text: 'Third line!\n',
    ///         style: TextStyle(
    ///           fontSize: 14,
    ///           fontFamily: 'Roboto',
    ///         ),
    ///       ),
    ///     ],
    ///   ),
    ///   strutStyle: StrutStyle(
    ///     fontFamily: 'Roboto',
    ///     height: 1.5,
    ///   ),
    /// ),
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    /// Here, strut is used to enable strange and overlapping text to achieve unique
    /// effects. The `M`s in lines 2 and 3 are able to extend above their lines and
    /// fill empty space in lines above. The [forceStrutHeight] is enabled and functions
    /// as a 'grid' for the glyphs to draw on.
    ///
    /// ![The result of the example below.](https://flutter.github.io/assets-for-api-docs/assets/painting/strut_force_example.png)
    ///
    /// ```dart
    /// const Text.rich(
    ///   TextSpan(
    ///     text: '---------         ---------\n',
    ///     style: TextStyle(
    ///       fontSize: 14,
    ///       fontFamily: 'Roboto',
    ///     ),
    ///     children: <TextSpan>[
    ///       TextSpan(
    ///         text: '^^^M^^^\n',
    ///         style: TextStyle(
    ///           fontSize: 30,
    ///           fontFamily: 'Roboto',
    ///         ),
    ///       ),
    ///       TextSpan(
    ///         text: 'M------M\n',
    ///         style: TextStyle(
    ///           fontSize: 30,
    ///           fontFamily: 'Roboto',
    ///         ),
    ///       ),
    ///     ],
    ///   ),
    ///   strutStyle: StrutStyle(
    ///     fontFamily: 'Roboto',
    ///     fontSize: 14,
    ///     height: 1,
    ///     forceStrutHeight: true,
    ///   ),
    /// ),
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    /// This example uses forceStrutHeight to create a 'drop cap' for the 'T' in 'The'.
    /// By locking the line heights to the metrics of the 14pt serif font, we are able
    /// to lay out a large 37pt 'T' on the second line to take up space on both the first
    /// and second lines.
    ///
    /// ![The result of the example below.](https://flutter.github.io/assets-for-api-docs/assets/painting/strut_force_example_2.png)
    ///
    /// ```dart
    /// Text.rich(
    ///   TextSpan(
    ///     text: '       he candle flickered\n',
    ///     style: TextStyle(
    ///       fontSize: 14,
    ///       fontFamily: 'Serif'
    ///     ),
    ///     children: <TextSpan>[
    ///       TextSpan(
    ///         text: 'T',
    ///         style: TextStyle(
    ///           fontSize: 37,
    ///           fontFamily: 'Serif'
    ///         ),
    ///       ),
    ///       TextSpan(
    ///         text: 'in the moonlight as\n',
    ///         style: TextStyle(
    ///           fontSize: 14,
    ///           fontFamily: 'Serif'
    ///         ),
    ///       ),
    ///       TextSpan(
    ///         text: 'Dash the bird fluttered\n',
    ///         style: TextStyle(
    ///           fontSize: 14,
    ///           fontFamily: 'Serif'
    ///         ),
    ///       ),
    ///       TextSpan(
    ///         text: 'off into the distance.',
    ///         style: TextStyle(
    ///           fontSize: 14,
    ///           fontFamily: 'Serif'
    ///         ),
    ///       ),
    ///     ],
    ///   ),
    ///   strutStyle: StrutStyle(
    ///     fontFamily: 'Serif',
    ///     fontSize: 14,
    ///     forceStrutHeight: true,
    ///   ),
    /// ),
    /// ```
    /// {@end-tool}
    ///
    /// </Summary>
    public class StrutStyle : IDiagnosticable
    {
        /// <Summary>
        /// Creates a strut style.
        ///
        /// The `package` argument must be non-null if the font family is defined in a
        /// package. It is combined with the `fontFamily` argument to set the
        /// [fontFamily] property.
        ///
        /// If provided, fontSize must be positive and non-zero, leading must be
        /// zero or positive.
        /// </Summary>
        public StrutStyle(string fontFamily = default(string), List<string> fontFamilyFallback = default(List<string>), double fontSize = default(double), double height = default(double), double leading = default(double), FontWeight fontWeight = default(FontWeight), FontStyle fontStyle = default(FontStyle), bool forceStrutHeight = default(bool), string debugLabel = default(string), string package = default(string))
        : base()
        {
            this.FontSize = fontSize;
            this.Height = height;
            this.Leading = leading;
            this.FontWeight = fontWeight;
            this.FontStyle = fontStyle;
            this.ForceStrutHeight = forceStrutHeight;
            this.DebugLabel = debugLabel;
        }
        /// <Summary>
        /// Builds a StrutStyle that contains values of the equivalent properties in
        /// the provided [textStyle].
        ///
        /// The [textStyle] parameter must not be null.
        ///
        /// The named parameters override the [textStyle]'s argument's properties.
        /// Since TextStyle does not contain [leading] or [forceStrutHeight], these
        /// values will take on default values (null and false) unless otherwise
        /// specified.
        ///
        /// If provided, fontSize must be positive and non-zero, leading must be
        /// zero or positive.
        ///
        /// When [textStyle] has a package and a new [package] is also specified,
        /// the entire font family fallback list should be redefined since the
        /// [textStyle]'s package data is inherited by being prepended onto the
        /// font family names. If [fontFamilyFallback] is meant to be empty, pass
        /// an empty list instead of null. This prevents the previous package name
        /// from being prepended twice.
        /// </Summary>
        public static StrutStyle FromTextStyle(FlutterSDK.Painting.Textstyle.TextStyle textStyle, string fontFamily = default(string), List<string> fontFamilyFallback = default(List<string>), double fontSize = default(double), double height = default(double), double leading = default(double), FontWeight fontWeight = default(FontWeight), FontStyle fontStyle = default(FontStyle), bool forceStrutHeight = default(bool), string debugLabel = default(string), string package = default(string))
        => new StrutStyle(textStyle, fontFamily, fontFamilyFallback, fontSize, height, leading, fontWeight, fontStyle, forceStrutHeight, debugLabel, package);

        private StrutStyle(FlutterSDK.Painting.Textstyle.TextStyle textStyle, string fontFamily, List<string> fontFamilyFallback, double fontSize, double height, double leading, FontWeight fontWeight, FontStyle fontStyle, bool forceStrutHeight, string debugLabel, string package)
        : base()
        {
            this.Leading = leading;
            this.ForceStrutHeight = forceStrutHeight;
        }
        /// <Summary>
        /// A [StrutStyle] that will have no impact on the text layout.
        ///
        /// Equivalent to having no strut at all. All lines will be laid out according to
        /// the properties defined in [TextStyle].
        /// </Summary>
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle Disabled { get; set; }
        /// <Summary>
        /// The name of the font to use when calculating the strut (e.g., Roboto). If
        /// the font is defined in a package, this will be prefixed with
        /// 'packages/package_name/' (e.g. 'packages/cool_fonts/Roboto'). The
        /// prefixing is done by the constructor when the `package` argument is
        /// provided.
        ///
        /// The value provided in [fontFamily] will act as the preferred/first font
        /// family that will be searched for, followed in order by the font families
        /// in [fontFamilyFallback]. If all font families are exhausted and no match
        /// was found, the default platform font family will be used instead. Unlike
        /// [TextStyle.fontFamilyFallback], the font does not need to contain the
        /// desired glyphs to match.
        /// </Summary>
        public virtual string FontFamily { get; set; }
        internal virtual List<string> _FontFamilyFallback { get; set; }
        internal virtual string _Package { get; set; }
        /// <Summary>
        /// The size of text (in logical pixels) to use when obtaining metrics from the font.
        ///
        /// The [fontSize] is used to get the base set of metrics that are then used to calculated
        /// the metrics of strut. The height and leading are expressed as a multiple of
        /// [fontSize].
        ///
        /// The default fontSize is 14 logical pixels.
        /// </Summary>
        public virtual double FontSize { get; set; }
        /// <Summary>
        /// The multiple of [fontSize] to multiply the ascent and descent by where
        /// `ascent + descent = fontSize`.
        ///
        /// Ascent is the spacing above the baseline and descent is the spacing below
        /// the baseline.
        ///
        /// When [height] is omitted or null, then the font defined ascent and descent
        /// will be used. The font's combined ascent and descent may be taller or
        /// shorter than the [fontSize]. When [height] is provided, the line's EM-square
        /// ascent and descent (which sums to [fontSize]) will be scaled by [height] to
        /// achieve a final line height of `fontSize * height + fontSize * leading`
        /// logical pixels. The following diagram illustrates the differences between
        /// the font metrics defined height and the EM-square height:
        ///
        /// ![Text height diagram](https://flutter.github.io/assets-for-api-docs/assets/painting/text_height_diagram.png)
        ///
        /// The [height] will impact the spacing above and below the baseline differently
        /// depending on the ratios between the font's ascent and descent. This property is
        /// separate from the leading multiplier, which is controlled through [leading].
        ///
        /// The ratio of ascent:descent with [height] specified is the same as the
        /// font metrics defined ascent:descent ratio when [height] is null or omitted.
        ///
        /// See [TextStyle.height], which works in a similar manner.
        ///
        /// The default height is null.
        /// </Summary>
        public virtual double Height { get; set; }
        /// <Summary>
        /// The typeface thickness to use when calculating the strut (e.g., bold).
        ///
        /// The default fontWeight is [FontWeight.w400].
        /// </Summary>
        public virtual FontWeight FontWeight { get; set; }
        /// <Summary>
        /// The typeface variant to use when calculating the strut (e.g., italics).
        ///
        /// The default fontStyle is [FontStyle.normal].
        /// </Summary>
        public virtual FontStyle FontStyle { get; set; }
        /// <Summary>
        /// The custom leading to apply to the strut as a multiple of [fontSize].
        ///
        /// Leading is additional spacing between lines. Half of the leading is added
        /// to the top and the other half to the bottom of the line. This differs
        /// from [height] since the spacing is equally distributed above and below the
        /// baseline.
        ///
        /// The default leading is null, which will use the font-specified leading.
        /// </Summary>
        public virtual double Leading { get; set; }
        /// <Summary>
        /// Whether the strut height should be forced.
        ///
        /// When true, all lines will be laid out with the height of the
        /// strut. All line and run-specific metrics will be ignored/overridden
        /// and only strut metrics will be used instead. This property guarantees
        /// uniform line spacing, however text in adjacent lines may overlap.
        ///
        /// This property should be enabled with caution as
        /// it bypasses a large portion of the vertical layout system.
        ///
        /// This is equivalent to setting [TextStyle.height] to zero for all [TextStyle]s
        /// in the paragraph. Since the height of each line is calculated as a max of the
        /// metrics of each run of text, zero height [TextStyle]s cause the minimums
        /// defined by strut to always manifest, resulting in all lines having the height
        /// of the strut.
        ///
        /// The default is false.
        /// </Summary>
        public virtual bool ForceStrutHeight { get; set; }
        /// <Summary>
        /// A human-readable description of this strut style.
        ///
        /// This property is maintained only in debug builds.
        ///
        /// This property is not considered when comparing strut styles using `==` or
        /// [compareTo], and it does not affect [hashCode].
        /// </Summary>
        public virtual string DebugLabel { get; set; }
        public virtual List<string> FontFamilyFallback { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Describe the difference between this style and another, in terms of how
        /// much damage it will make to the rendering.
        ///
        /// See also:
        ///
        ///  * [TextSpan.compareTo], which does the same thing for entire [TextSpan]s.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.RenderComparison CompareTo(FlutterSDK.Painting.Strutstyle.StrutStyle other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return RenderComparison.Identical;
            if (FontFamily != other.FontFamily || FontSize != other.FontSize || FontWeight != other.FontWeight || FontStyle != other.FontStyle || Height != other.Height || Leading != other.Leading || ForceStrutHeight != other.ForceStrutHeight || !CollectionsDefaultClass.ListEquals(FontFamilyFallback, other.FontFamilyFallback)) return RenderComparison.Layout;
            return RenderComparison.Identical;
        }




        /// <Summary>
        /// Returns a new strut style that inherits its null values from
        /// corresponding properties in the [other] [TextStyle].
        ///
        /// The "missing" properties of the this strut style are _filled_ by
        /// the properties of the provided [TextStyle]. This is possible because
        /// [StrutStyle] shares many of the same basic properties as [TextStyle].
        ///
        /// If the given text style is null, returns this strut style.
        /// </Summary>
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle InheritFromTextStyle(FlutterSDK.Painting.Textstyle.TextStyle other)
        {
            if (other == null) return this;
            return new StrutStyle(fontFamily: FontFamily ?? other.FontFamily, fontFamilyFallback: FontFamilyFallback ?? other.FontFamilyFallback, fontSize: fontSize == default(double) ? other.fontSize : fontSize, height: height == default(double) ? other.height : height, leading: Leading, fontWeight: FontWeight ?? other.FontWeight, fontStyle: FontStyle ?? other.FontStyle, forceStrutHeight: ForceStrutHeight, debugLabel: DebugLabel ?? other.DebugLabel);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is StrutStyle && other.FontFamily == FontFamily && other.FontSize == FontSize && other.FontWeight == FontWeight && other.FontStyle == FontStyle && other.Height == Height && other.Leading == Leading && other.ForceStrutHeight == ForceStrutHeight;
        }




        public new string ToStringShort() => ObjectDefaultClass.ObjectRuntimeType(this, "StrutStyle");



        /// <Summary>
        /// Adds all properties prefixing property names with the optional `prefix`.
        /// </Summary>
        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties, string prefix = default(string))
        {
            base.DebugFillProperties(properties);
            if (DebugLabel != null) properties.Add(new MessageProperty($"'{prefix}debugLabel'", DebugLabel));
            List<DiagnosticsNode> styles = new List<DiagnosticsNode>() { new StringProperty($"'{prefix}family'", FontFamily, defaultValue: null, quoted: false), new IterableProperty<string>($"'{prefix}familyFallback'", FontFamilyFallback, defaultValue: null), new DoubleProperty($"'{prefix}size'", FontSize, defaultValue: null) };
            string weightDescription = default(string);
            if (FontWeight != null)
            {
                weightDescription = $"'w{FontWeight.Index + 1}00'";
            }

            styles.Add(new DiagnosticsProperty<FontWeight>($"'{prefix}weight'", FontWeight, description: weightDescription, defaultValue: null));
            styles.Add(new EnumProperty<FontStyle>($"'{prefix}style'", FontStyle, defaultValue: null));
            styles.Add(new DoubleProperty($"'{prefix}height'", Height, unit: 'x', defaultValue: null));
            styles.Add(new FlagProperty($"'{prefix}forceStrutHeight'", value: ForceStrutHeight, defaultValue: null, ifTrue: $"'{prefix}<strut height forced>'", ifFalse: $"'{prefix}<strut height normal>'"));
            bool styleSpecified = styles.Any((DiagnosticsNode n) => =>!n.IsFiltered(DiagnosticLevel.Info));
            styles.ForEach(properties.Add);
            if (!styleSpecified) properties.Add(new FlagProperty("forceStrutHeight", value: ForceStrutHeight, ifTrue: $"'{prefix}<strut height forced>'", ifFalse: $"'{prefix}<strut height normal>'"));
        }



    }

}
