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
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Typography;
using FlutterSDK.Scheduler;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Routenotificationmessages;
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
        #region constructors
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
        public static DefaultTextStyle Fallback(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        {
            var instance = new DefaultTextStyle(key: key, child: null);
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual bool SoftWrap { get; set; }
        public virtual FlutterSDK.Rendering.Paragraph.TextOverflow Overflow { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        public virtual TextHeightBehavior TextHeightBehavior { get; set; }
        #endregion

        #region methods

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
            return Dart:coreDefaultClass.Identical(this, defaultTextStyle) ? child : new DefaultTextStyle(style: Style, textAlign: TextAlign, softWrap: SoftWrap, overflow: Overflow, maxLines: MaxLines, textWidthBasis: TextWidthBasis, textHeightBehavior: TextHeightBehavior, child: child);
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
            properties.Add(new DiagnosticsProperty<Ui.Dart:uiDefaultClass.TextHeightBehavior>("textHeightBehavior", TextHeightBehavior, defaultValue: null));
        }



        #endregion
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
        #region constructors
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
        #endregion

        #region fields
        public virtual string Data { get; set; }
        public virtual FlutterSDK.Painting.Inlinespan.InlineSpan TextSpan { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual Locale Locale { get; set; }
        public virtual bool SoftWrap { get; set; }
        public virtual FlutterSDK.Rendering.Paragraph.TextOverflow Overflow { get; set; }
        public virtual double TextScaleFactor { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual string SemanticsLabel { get; set; }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        public virtual TextHeightBehavior TextHeightBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            DefaultTextStyle defaultTextStyle = TextDefaultClass.DefaultTextStyle.Of(context);
            TextStyle effectiveTextStyle = Style;
            if (Style == null || Style.Inherit) effectiveTextStyle = defaultTextStyle.Style.Merge(Style);
            if (MediaqueryDefaultClass.MediaQuery.BoldTextOverride(context)) effectiveTextStyle = effectiveTextStyle.Merge(new TextStyle(fontWeight: Dart:uiDefaultClass.FontWeight.Bold));
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
            properties.Add(new DiagnosticsProperty<Ui.Dart:uiDefaultClass.TextHeightBehavior>("textHeightBehavior", TextHeightBehavior, defaultValue: null));
            if (SemanticsLabel != null)
            {
                properties.Add(new StringProperty("semanticsLabel", SemanticsLabel));
            }

        }



        #endregion
    }

}
