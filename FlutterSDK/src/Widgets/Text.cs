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
using FlutterSDK.Widgets.Constants;
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
using FlutterSDK.Widgets.Routenotificationmessages;
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
namespace FlutterSDK.Widgets.Text
{
    internal static class TextDefaultClass
    {
    }

    /// <Summary>
    /// The text style to apply to descendant [Text] widgets which don't have an
    /// explicit style.
    ///
    /// See also:
    ///
    ///  * [AnimatedDefaultTextStyle], which animates changes in the text style
    ///    smoothly over a given duration.
    ///  * [DefaultTextStyleTransition], which takes a provided [Animation] to
    ///    animate changes in text style smoothly over time.
    /// </Summary>
    public class DefaultTextStyle : FlutterSDK.Widgets.Inheritedtheme.InheritedTheme
    {
        /// <Summary>
        /// Creates a default text style for the given subtree.
        ///
        /// Consider using [DefaultTextStyle.merge] to inherit styling information
        /// from the current default text style for a given [BuildContext].
        ///
        /// The [style] and [child] arguments are required and must not be null.
        ///
        /// The [softWrap] and [overflow] arguments must not be null (though they do
        /// have default values).
        ///
        /// The [maxLines] property may be null (and indeed defaults to null), but if
        /// it is not null, it must be greater than zero.
        /// </Summary>
        public DefaultTextStyle(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), TextAlign textAlign = default(TextAlign), bool softWrap = true, FlutterSDK.Rendering.Paragraph.TextOverflow overflow = default(FlutterSDK.Rendering.Paragraph.TextOverflow), int maxLines = default(int), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), TextHeightBehavior textHeightBehavior = default(TextHeightBehavior), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Style = style;
            this.TextAlign = textAlign;
            this.SoftWrap = softWrap;
            this.Overflow = overflow;
            this.MaxLines = maxLines;
            this.TextWidthBasis = textWidthBasis;
            this.TextHeightBehavior = textHeightBehavior;
        }
        /// <Summary>
        /// A const-constructible default text style that provides fallback values.
        ///
        /// Returned from [of] when the given [BuildContext] doesn't have an enclosing default text style.
        ///
        /// This constructor creates a [DefaultTextStyle] that lacks a [child], which
        /// means the constructed value cannot be incorporated into the tree.
        /// </Summary>
        public static DefaultTextStyle Fallback(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        {
            var instance = new DefaultTextStyle(key: key, child: null);
        }
        /// <Summary>
        /// The text style to apply.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        /// <Summary>
        /// How the text should be aligned horizontally.
        /// </Summary>
        public virtual TextAlign TextAlign { get; set; }
        /// <Summary>
        /// Whether the text should break at soft line breaks.
        ///
        /// If false, the glyphs in the text will be positioned as if there was unlimited horizontal space.
        /// </Summary>
        public virtual bool SoftWrap { get; set; }
        /// <Summary>
        /// How visual overflow should be handled.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Paragraph.TextOverflow Overflow { get; set; }
        /// <Summary>
        /// An optional maximum number of lines for the text to span, wrapping if necessary.
        /// If the text exceeds the given number of lines, it will be truncated according
        /// to [overflow].
        ///
        /// If this is 1, text will not wrap. Otherwise, text will be wrapped at the
        /// edge of the box.
        ///
        /// If this is non-null, it will override even explicit null values of
        /// [Text.maxLines].
        /// </Summary>
        public virtual int MaxLines { get; set; }
        /// <Summary>
        /// The strategy to use when calculating the width of the Text.
        ///
        /// See [TextWidthBasis] for possible values and their implications.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        /// <Summary>
        /// {@macro flutter.dart:ui.textHeightBehavior}
        /// </Summary>
        public virtual TextHeightBehavior TextHeightBehavior { get; set; }

        /// <Summary>
        /// Creates a default text style that overrides the text styles in scope at
        /// this point in the widget tree.
        ///
        /// The given [style] is merged with the [style] from the default text style
        /// for the [BuildContext] where the widget is inserted, and any of the other
        /// arguments that are not null replace the corresponding properties on that
        /// same default text style.
        ///
        /// This constructor cannot be used to override the [maxLines] property of the
        /// ancestor with the value null, since null here is used to mean "defer to
        /// ancestor". To replace a non-null [maxLines] from an ancestor with the null
        /// value (to remove the restriction on number of lines), manually obtain the
        /// ambient [DefaultTextStyle] using [DefaultTextStyle.of], then create a new
        /// [DefaultTextStyle] using the [new DefaultTextStyle] constructor directly.
        /// See the source below for an example of how to do this (since that's
        /// essentially what this constructor does).
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Merge(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), TextAlign textAlign = default(TextAlign), bool softWrap = default(bool), FlutterSDK.Rendering.Paragraph.TextOverflow overflow = default(FlutterSDK.Rendering.Paragraph.TextOverflow), int maxLines = default(int), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {

            return new Builder(builder: (BuildContext context) =>
            {
                DefaultTextStyle parent = TextDefaultClass.DefaultTextStyle.Of(context);
                return new DefaultTextStyle(key: key, style: parent.Style.Merge(style), textAlign: textAlign ?? parent.TextAlign, softWrap: softWrap ?? parent.SoftWrap, overflow: overflow ?? parent.Overflow, maxLines: maxLines ?? parent.MaxLines, textWidthBasis: textWidthBasis ?? parent.TextWidthBasis, child: child);
            }
            );
        }




        /// <Summary>
        /// The closest instance of this class that encloses the given context.
        ///
        /// If no such instance exists, returns an instance created by
        /// [DefaultTextStyle.fallback], which contains fallback values.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// DefaultTextStyle style = DefaultTextStyle.of(context);
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Widgets.Text.DefaultTextStyle Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return context.DependOnInheritedWidgetOfExactType() ?? DefaultTextStyle.Fallback();
        }




        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Text.DefaultTextStyle oldWidget)
        {
            return Style != oldWidget.Style || TextAlign != oldWidget.TextAlign || SoftWrap != oldWidget.SoftWrap || Overflow != oldWidget.Overflow || MaxLines != oldWidget.MaxLines || TextWidthBasis != oldWidget.TextWidthBasis || TextHeightBehavior != oldWidget.TextHeightBehavior;
        }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget)
        {
            return Style != oldWidget.Style || TextAlign != oldWidget.TextAlign || SoftWrap != oldWidget.SoftWrap || Overflow != oldWidget.Overflow || MaxLines != oldWidget.MaxLines || TextWidthBasis != oldWidget.TextWidthBasis || TextHeightBehavior != oldWidget.TextHeightBehavior;
        }




        public new FlutterSDK.Widgets.Framework.Widget Wrap(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            DefaultTextStyle defaultTextStyle = context.FindAncestorWidgetOfExactType();
            return Dart.CoreDefaultClass.Identical(this, defaultTextStyle) ? child : new DefaultTextStyle(style: Style, textAlign: TextAlign, softWrap: SoftWrap, overflow: Overflow, maxLines: MaxLines, textWidthBasis: TextWidthBasis, textHeightBehavior: TextHeightBehavior, child: child);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            Style?.DebugFillProperties(properties);
            properties.Add(new EnumProperty<TextAlign>("textAlign", TextAlign, defaultValue: null));
            properties.Add(new FlagProperty("softWrap", value: SoftWrap, ifTrue: "wrapping at box width", ifFalse: "no wrapping except at line break characters", showName: true));
            properties.Add(new EnumProperty<TextOverflow>("overflow", Overflow, defaultValue: null));
            properties.Add(new IntProperty("maxLines", MaxLines, defaultValue: null));
            properties.Add(new EnumProperty<TextWidthBasis>("textWidthBasis", TextWidthBasis, defaultValue: TextWidthBasis.Parent));
            properties.Add(new DiagnosticsProperty<Dart.UI.TextHeightBehavior>("textHeightBehavior", TextHeightBehavior, defaultValue: null));
        }



    }


    /// <Summary>
    /// A run of text with a single style.
    ///
    /// The [Text] widget displays a string of text with single style. The string
    /// might break across multiple lines or might all be displayed on the same line
    /// depending on the layout constraints.
    ///
    /// The [style] argument is optional. When omitted, the text will use the style
    /// from the closest enclosing [DefaultTextStyle]. If the given style's
    /// [TextStyle.inherit] property is true (the default), the given style will
    /// be merged with the closest enclosing [DefaultTextStyle]. This merging
    /// behavior is useful, for example, to make the text bold while using the
    /// default font family and size.
    ///
    /// {@tool snippet}
    ///
    /// This example shows how to display text using the [Text] widget with the
    /// [overflow] set to [TextOverflow.ellipsis].
    ///
    /// ![If the text is shorter than the available space, it is displayed in full without an ellipsis.](https://flutter.github.io/assets-for-api-docs/assets/widgets/text.png)
    ///
    /// ![If the text overflows, the Text widget displays an ellipsis to trim the overflowing text](https://flutter.github.io/assets-for-api-docs/assets/widgets/text_ellipsis.png)
    ///
    /// ```dart
    /// Text(
    ///   'Hello, $_name! How are you?',
    ///   textAlign: TextAlign.center,
    ///   overflow: TextOverflow.ellipsis,
    ///   style: TextStyle(fontWeight: FontWeight.bold),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// Using the [Text.rich] constructor, the [Text] widget can
    /// display a paragraph with differently styled [TextSpan]s. The sample
    /// that follows displays "Hello beautiful world" with different styles
    /// for each word.
    ///
    /// {@tool snippet}
    ///
    /// ![The word "Hello" is shown with the default text styles. The word "beautiful" is italicized. The word "world" is bold.](https://flutter.github.io/assets-for-api-docs/assets/widgets/text_rich.png)
    ///
    /// ```dart
    /// const Text.rich(
    ///   TextSpan(
    ///     text: 'Hello', // default text style
    ///     children: <TextSpan>[
    ///       TextSpan(text: ' beautiful ', style: TextStyle(fontStyle: FontStyle.italic)),
    ///       TextSpan(text: 'world', style: TextStyle(fontWeight: FontWeight.bold)),
    ///     ],
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ## Interactivity
    ///
    /// To make [Text] react to touch events, wrap it in a [GestureDetector] widget
    /// with a [GestureDetector.onTap] handler.
    ///
    /// In a material design application, consider using a [FlatButton] instead, or
    /// if that isn't appropriate, at least using an [InkWell] instead of
    /// [GestureDetector].
    ///
    /// To make sections of the text interactive, use [RichText] and specify a
    /// [TapGestureRecognizer] as the [TextSpan.recognizer] of the relevant part of
    /// the text.
    ///
    /// See also:
    ///
    ///  * [RichText], which gives you more control over the text styles.
    ///  * [DefaultTextStyle], which sets default styles for [Text] widgets.
    /// </Summary>
    public class Text : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a text widget.
        ///
        /// If the [style] argument is null, the text will use the style from the
        /// closest enclosing [DefaultTextStyle].
        ///
        /// The [data] parameter must not be null.
        /// </Summary>
        public Text(string data, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), Locale locale = default(Locale), bool softWrap = default(bool), FlutterSDK.Rendering.Paragraph.TextOverflow overflow = default(FlutterSDK.Rendering.Paragraph.TextOverflow), double textScaleFactor = default(double), int maxLines = default(int), string semanticsLabel = default(string), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), TextHeightBehavior textHeightBehavior = default(TextHeightBehavior))
        : base(key: key)
        {
            this.Data = data;
            this.Style = style;
            this.StrutStyle = strutStyle;
            this.TextAlign = textAlign;
            this.TextDirection = textDirection;
            this.Locale = locale;
            this.SoftWrap = softWrap;
            this.Overflow = overflow;
            this.TextScaleFactor = textScaleFactor;
            this.MaxLines = maxLines;
            this.SemanticsLabel = semanticsLabel;
            this.TextWidthBasis = textWidthBasis;
            this.TextHeightBehavior = textHeightBehavior;
        }
        /// <Summary>
        /// Creates a text widget with a [InlineSpan].
        ///
        /// The following subclasses of [InlineSpan] may be used to build rich text:
        ///
        /// * [TextSpan]s define text and children [InlineSpan]s.
        /// * [WidgetSpan]s define embedded inline widgets.
        ///
        /// The [textSpan] parameter must not be null.
        ///
        /// See [RichText] which provides a lower-level way to draw text.
        /// </Summary>
        public static Text Rich(FlutterSDK.Painting.Inlinespan.InlineSpan textSpan, FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), Locale locale = default(Locale), bool softWrap = default(bool), FlutterSDK.Rendering.Paragraph.TextOverflow overflow = default(FlutterSDK.Rendering.Paragraph.TextOverflow), double textScaleFactor = default(double), int maxLines = default(int), string semanticsLabel = default(string), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), TextHeightBehavior textHeightBehavior = default(TextHeightBehavior))
        {
            var instance = new Text(key: key); instance.TextSpan = textSpan;
            instance.Style = style;
            instance.StrutStyle = strutStyle;
            instance.TextAlign = textAlign;
            instance.TextDirection = textDirection;
            instance.Locale = locale;
            instance.SoftWrap = softWrap;
            instance.Overflow = overflow;
            instance.TextScaleFactor = textScaleFactor;
            instance.MaxLines = maxLines;
            instance.SemanticsLabel = semanticsLabel;
            instance.TextWidthBasis = textWidthBasis;
            instance.TextHeightBehavior = textHeightBehavior;
        }
        /// <Summary>
        /// The text to display.
        ///
        /// This will be null if a [textSpan] is provided instead.
        /// </Summary>
        public virtual string Data { get; set; }
        /// <Summary>
        /// The text to display as a [InlineSpan].
        ///
        /// This will be null if [data] is provided instead.
        /// </Summary>
        public virtual FlutterSDK.Painting.Inlinespan.InlineSpan TextSpan { get; set; }
        /// <Summary>
        /// If non-null, the style to use for this text.
        ///
        /// If the style's "inherit" property is true, the style will be merged with
        /// the closest enclosing [DefaultTextStyle]. Otherwise, the style will
        /// replace the closest enclosing [DefaultTextStyle].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        /// <Summary>
        /// {@macro flutter.painting.textPainter.strutStyle}
        /// </Summary>
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get; set; }
        /// <Summary>
        /// How the text should be aligned horizontally.
        /// </Summary>
        public virtual TextAlign TextAlign { get; set; }
        /// <Summary>
        /// The directionality of the text.
        ///
        /// This decides how [textAlign] values like [TextAlign.start] and
        /// [TextAlign.end] are interpreted.
        ///
        /// This is also used to disambiguate how to render bidirectional text. For
        /// example, if the [data] is an English phrase followed by a Hebrew phrase,
        /// in a [TextDirection.ltr] context the English phrase will be on the left
        /// and the Hebrew phrase to its right, while in a [TextDirection.rtl]
        /// context, the English phrase will be on the right and the Hebrew phrase on
        /// its left.
        ///
        /// Defaults to the ambient [Directionality], if any.
        /// </Summary>
        public virtual TextDirection TextDirection { get; set; }
        /// <Summary>
        /// Used to select a font when the same Unicode character can
        /// be rendered differently, depending on the locale.
        ///
        /// It's rarely necessary to set this property. By default its value
        /// is inherited from the enclosing app with `Localizations.localeOf(context)`.
        ///
        /// See [RenderParagraph.locale] for more information.
        /// </Summary>
        public virtual Locale Locale { get; set; }
        /// <Summary>
        /// Whether the text should break at soft line breaks.
        ///
        /// If false, the glyphs in the text will be positioned as if there was unlimited horizontal space.
        /// </Summary>
        public virtual bool SoftWrap { get; set; }
        /// <Summary>
        /// How visual overflow should be handled.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Paragraph.TextOverflow Overflow { get; set; }
        /// <Summary>
        /// The number of font pixels for each logical pixel.
        ///
        /// For example, if the text scale factor is 1.5, text will be 50% larger than
        /// the specified font size.
        ///
        /// The value given to the constructor as textScaleFactor. If null, will
        /// use the [MediaQueryData.textScaleFactor] obtained from the ambient
        /// [MediaQuery], or 1.0 if there is no [MediaQuery] in scope.
        /// </Summary>
        public virtual double TextScaleFactor { get; set; }
        /// <Summary>
        /// An optional maximum number of lines for the text to span, wrapping if necessary.
        /// If the text exceeds the given number of lines, it will be truncated according
        /// to [overflow].
        ///
        /// If this is 1, text will not wrap. Otherwise, text will be wrapped at the
        /// edge of the box.
        ///
        /// If this is null, but there is an ambient [DefaultTextStyle] that specifies
        /// an explicit number for its [DefaultTextStyle.maxLines], then the
        /// [DefaultTextStyle] value will take precedence. You can use a [RichText]
        /// widget directly to entirely override the [DefaultTextStyle].
        /// </Summary>
        public virtual int MaxLines { get; set; }
        /// <Summary>
        /// An alternative semantics label for this text.
        ///
        /// If present, the semantics of this widget will contain this value instead
        /// of the actual text. This will overwrite any of the semantics labels applied
        /// directly to the [TextSpan]s.
        ///
        /// This is useful for replacing abbreviations or shorthands with the full
        /// text value:
        ///
        /// ```dart
        /// Text(r'$$', semanticsLabel: 'Double dollars')
        /// ```
        /// </Summary>
        public virtual string SemanticsLabel { get; set; }
        /// <Summary>
        /// {@macro flutter.painting.textPainter.textWidthBasis}
        /// </Summary>
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        /// <Summary>
        /// {@macro flutter.dart:ui.textHeightBehavior}
        /// </Summary>
        public virtual TextHeightBehavior TextHeightBehavior { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            DefaultTextStyle defaultTextStyle = TextDefaultClass.DefaultTextStyle.Of(context);
            TextStyle effectiveTextStyle = Style;
            if (Style == null || Style.Inherit) effectiveTextStyle = defaultTextStyle.Style.Merge(Style);
            if (MediaqueryDefaultClass.MediaQuery.BoldTextOverride(context)) effectiveTextStyle = effectiveTextStyle.Merge(new TextStyle(fontWeight: Dart.UI.UiDefaultClass.FontWeight.Bold));
            Widget result = new RichText(textAlign: TextAlign ?? defaultTextStyle.TextAlign ?? TextAlign.Start, textDirection: TextDirection, locale: Locale, softWrap: SoftWrap ?? defaultTextStyle.SoftWrap, overflow: Overflow ?? defaultTextStyle.Overflow, textScaleFactor: textScaleFactor == default(double) ? MediaQuery.textScaleFactorOf(context) : textScaleFactor, maxLines: MaxLines ?? defaultTextStyle.MaxLines, strutStyle: StrutStyle, textWidthBasis: TextWidthBasis ?? defaultTextStyle.TextWidthBasis, textHeightBehavior: TextHeightBehavior ?? defaultTextStyle.TextHeightBehavior, text: new TextSpan(style: effectiveTextStyle, text: Data, children: TextSpan != null ? new List<InlineSpan>() { TextSpan } : null));
            if (SemanticsLabel != null)
            {
                result = new Semantics(textDirection: TextDirection, label: SemanticsLabel, child: new ExcludeSemantics(child: result));
            }

            return result;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new StringProperty("data", Data, showName: false));
            if (TextSpan != null)
            {
                properties.Add(TextSpan.ToDiagnosticsNode(name: "textSpan", style: DiagnosticsTreeStyle.Transition));
            }

            Style?.DebugFillProperties(properties);
            properties.Add(new EnumProperty<TextAlign>("textAlign", TextAlign, defaultValue: null));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Locale>("locale", Locale, defaultValue: null));
            properties.Add(new FlagProperty("softWrap", value: SoftWrap, ifTrue: "wrapping at box width", ifFalse: "no wrapping except at line break characters", showName: true));
            properties.Add(new EnumProperty<TextOverflow>("overflow", Overflow, defaultValue: null));
            properties.Add(new DoubleProperty("textScaleFactor", TextScaleFactor, defaultValue: null));
            properties.Add(new IntProperty("maxLines", MaxLines, defaultValue: null));
            properties.Add(new EnumProperty<TextWidthBasis>("textWidthBasis", TextWidthBasis, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Dart.UI.TextHeightBehavior>("textHeightBehavior", TextHeightBehavior, defaultValue: null));
            if (SemanticsLabel != null)
            {
                properties.Add(new StringProperty("semanticsLabel", SemanticsLabel));
            }

        }



    }

}
