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
namespace FlutterSDK.Material.Tooltip
{
    internal static class TooltipDefaultClass
    {
    }

    /// <Summary>
    /// A material design tooltip.
    ///
    /// Tooltips provide text labels that help explain the function of a button or
    /// other user interface action. Wrap the button in a [Tooltip] widget to
    /// show a label when the widget long pressed (or when the user takes some
    /// other appropriate action).
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=EeEfD5fI-5Q}
    ///
    /// Many widgets, such as [IconButton], [FloatingActionButton], and
    /// [PopupMenuButton] have a `tooltip` property that, when non-null, causes the
    /// widget to include a [Tooltip] in its build.
    ///
    /// Tooltips improve the accessibility of visual widgets by proving a textual
    /// representation of the widget, which, for example, can be vocalized by a
    /// screen reader.
    ///
    /// See also:
    ///
    ///  * <https://material.io/design/components/tooltips.html>
    ///  * [TooltipTheme] or [ThemeData.tooltipTheme]
    /// </Summary>
    public class Tooltip : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a tooltip.
        ///
        /// By default, tooltips should adhere to the
        /// [Material specification](https://material.io/design/components/tooltips.html#spec).
        /// If the optional constructor parameters are not defined, the values
        /// provided by [TooltipTheme.of] will be used if a [TooltipTheme] is present
        /// or specified in [ThemeData].
        ///
        /// All parameters that are defined in the constructor will
        /// override the default values _and_ the values in [TooltipTheme.of].
        /// </Summary>
        public Tooltip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string message = default(string), double height = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry margin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), double verticalOffset = default(double), bool preferBelow = default(bool), bool excludeFromSemantics = default(bool), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), TimeSpan waitDuration = default(TimeSpan), TimeSpan showDuration = default(TimeSpan), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Message = message;
            this.Height = height;
            this.Padding = padding;
            this.Margin = margin;
            this.VerticalOffset = verticalOffset;
            this.PreferBelow = preferBelow;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.Decoration = decoration;
            this.TextStyle = textStyle;
            this.WaitDuration = waitDuration;
            this.ShowDuration = showDuration;
            this.Child = child;
        }
        /// <Summary>
        /// The text to display in the tooltip.
        /// </Summary>
        public virtual string Message { get; set; }
        /// <Summary>
        /// The height of the tooltip's [child].
        ///
        /// If the [child] is null, then this is the tooltip's intrinsic height.
        /// </Summary>
        public virtual double Height { get; set; }
        /// <Summary>
        /// The amount of space by which to inset the tooltip's [child].
        ///
        /// Defaults to 16.0 logical pixels in each direction.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        /// <Summary>
        /// The empty space that surrounds the tooltip.
        ///
        /// Defines the tooltip's outer [Container.margin]. By default, a
        /// long tooltip will span the width of its window. If long enough,
        /// a tooltip might also span the window's height. This property allows
        /// one to define how much space the tooltip must be inset from the edges
        /// of their display window.
        ///
        /// If this property is null, then [TooltipThemeData.margin] is used.
        /// If [TooltipThemeData.margin] is also null, the default margin is
        /// 0.0 logical pixels on all sides.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Margin { get; set; }
        /// <Summary>
        /// The vertical gap between the widget and the displayed tooltip.
        ///
        /// When [preferBelow] is set to true and tooltips have sufficient space to
        /// display themselves, this property defines how much vertical space
        /// tooltips will position themselves under their corresponding widgets.
        /// Otherwise, tooltips will position themselves above their corresponding
        /// widgets with the given offset.
        /// </Summary>
        public virtual double VerticalOffset { get; set; }
        /// <Summary>
        /// Whether the tooltip defaults to being displayed below the widget.
        ///
        /// Defaults to true. If there is insufficient space to display the tooltip in
        /// the preferred direction, the tooltip will be displayed in the opposite
        /// direction.
        /// </Summary>
        public virtual bool PreferBelow { get; set; }
        /// <Summary>
        /// Whether the tooltip's [message] should be excluded from the semantics
        /// tree.
        ///
        /// Defaults to false. A tooltip will add a [Semantics.label] that is set to
        /// [Tooltip.message]. Set this property to true if the app is going to
        /// provide its own custom semantics label.
        /// </Summary>
        public virtual bool ExcludeFromSemantics { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// Specifies the tooltip's shape and background color.
        ///
        /// The tooltip shape defaults to a rounded rectangle with a border radius of
        /// 4.0. Tooltips will also default to an opacity of 90% and with the color
        /// [Colors.grey[700]] if [ThemeData.brightness] is [Brightness.dark], and
        /// [Colors.white] if it is [Brightness.light].
        /// </Summary>
        public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
        /// <Summary>
        /// The style to use for the message of the tooltip.
        ///
        /// If null, the message's [TextStyle] will be determined based on
        /// [ThemeData]. If [ThemeData.brightness] is set to [Brightness.dark],
        /// [ThemeData.textTheme.bodyText2] will be used with [Colors.white]. Otherwise,
        /// if [ThemeData.brightness] is set to [Brightness.light],
        /// [ThemeData.textTheme.bodyText2] will be used with [Colors.black].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
        /// <Summary>
        /// The length of time that a pointer must hover over a tooltip's widget
        /// before the tooltip will be shown.
        ///
        /// Once the pointer leaves the widget, the tooltip will immediately
        /// disappear.
        ///
        /// Defaults to 0 milliseconds (tooltips are shown immediately upon hover).
        /// </Summary>
        public virtual TimeSpan WaitDuration { get; set; }
        /// <Summary>
        /// The length of time that the tooltip will be shown after a long press
        /// is released.
        ///
        /// Defaults to 1.5 seconds.
        /// </Summary>
        public virtual TimeSpan ShowDuration { get; set; }

        public new FlutterSDK.Material.Tooltip._TooltipState CreateState() => new _TooltipState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new StringProperty("message", Message, showName: false));
            properties.Add(new DoubleProperty("height", Height, defaultValue: null));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding, defaultValue: null));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("margin", Margin, defaultValue: null));
            properties.Add(new DoubleProperty("vertical offset", VerticalOffset, defaultValue: null));
            properties.Add(new FlagProperty("position", value: PreferBelow, ifTrue: "below", ifFalse: "above", showName: true, defaultValue: null));
            properties.Add(new FlagProperty("semantics", value: ExcludeFromSemantics, ifTrue: "excluded", showName: true, defaultValue: null));
            properties.Add(new DiagnosticsProperty<TimeSpan>("wait duration", WaitDuration, defaultValue: null));
            properties.Add(new DiagnosticsProperty<TimeSpan>("show duration", ShowDuration, defaultValue: null));
        }



    }


    public class _TooltipState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Tooltip.Tooltip>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _TooltipState()
        { }
        internal virtual double _DefaultTooltipHeight { get; set; }
        internal virtual double _DefaultVerticalOffset { get; set; }
        internal virtual bool _DefaultPreferBelow { get; set; }
        internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _DefaultPadding { get; set; }
        internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _DefaultMargin { get; set; }
        internal virtual TimeSpan _FadeInDuration { get; set; }
        internal virtual TimeSpan _FadeOutDuration { get; set; }
        internal virtual TimeSpan _DefaultShowDuration { get; set; }
        internal virtual TimeSpan _DefaultWaitDuration { get; set; }
        internal virtual bool _DefaultExcludeFromSemantics { get; set; }
        public virtual double Height { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Margin { get; set; }
        public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
        public virtual double VerticalOffset { get; set; }
        public virtual bool PreferBelow { get; set; }
        public virtual bool ExcludeFromSemantics { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Widgets.Overlay.OverlayEntry _Entry { get; set; }
        internal virtual Timer _HideTimer { get; set; }
        internal virtual Timer _ShowTimer { get; set; }
        public virtual TimeSpan ShowDuration { get; set; }
        public virtual TimeSpan WaitDuration { get; set; }
        internal virtual bool _MouseIsConnected { get; set; }
        internal virtual bool _LongPressActivated { get; set; }

        public new void InitState()
        {
            base.InitState();
            _MouseIsConnected = BindingDefaultClass.RendererBinding.Instance.MouseTracker.MouseIsConnected;
            _Controller = new AnimationController(duration: _FadeInDuration, reverseDuration: _FadeOutDuration, vsync: this);
            new AnimationController(duration: _FadeInDuration, reverseDuration: _FadeOutDuration, vsync: this).AddStatusListener(_HandleStatusChanged);
            BindingDefaultClass.RendererBinding.Instance.MouseTracker.AddListener(_HandleMouseTrackerChange);
            BindingDefaultClass.GestureBinding.Instance.PointerRouter.AddGlobalRoute(_HandlePointerEvent);
        }




        private void _HandleMouseTrackerChange()
        {
            if (!Mounted)
            {
                return;
            }

            bool mouseIsConnected = BindingDefaultClass.RendererBinding.Instance.MouseTracker.MouseIsConnected;
            if (mouseIsConnected != _MouseIsConnected)
            {
                SetState(() =>
                {
                    _MouseIsConnected = mouseIsConnected;
                }
                );
            }

        }




        private void _HandleStatusChanged(FlutterSDK.Animation.Animation.AnimationStatus status)
        {
            if (status == AnimationStatus.Dismissed)
            {
                _HideTooltip(immediately: true);
            }

        }




        private void _HideTooltip(bool immediately = false)
        {
            _ShowTimer?.Cancel();
            _ShowTimer = null;
            if (immediately)
            {
                _RemoveEntry();
                return;
            }

            if (_LongPressActivated)
            {
                _HideTimer = (_HideTimer == null ? new Timer(ShowDuration, _Controller.Reverse) : _HideTimer);
            }
            else
            {
                _Controller.Reverse();
            }

            _LongPressActivated = false;
        }




        private void _ShowTooltip(bool immediately = false)
        {
            _HideTimer?.Cancel();
            _HideTimer = null;
            if (immediately)
            {
                EnsureTooltipVisible();
                return;
            }

            _ShowTimer = (_ShowTimer == null ? new Timer(WaitDuration, EnsureTooltipVisible) : _ShowTimer);
        }




        /// <Summary>
        /// Shows the tooltip if it is not already visible.
        ///
        /// Returns `false` when the tooltip was already visible.
        /// </Summary>
        public virtual bool EnsureTooltipVisible()
        {
            _ShowTimer?.Cancel();
            _ShowTimer = null;
            if (_Entry != null)
            {
                _HideTimer?.Cancel();
                _HideTimer = null;
                _Controller.Forward();
                return false;
            }

            _CreateNewEntry();
            _Controller.Forward();
            return true;
        }




        private void _CreateNewEntry()
        {
            RenderBox box = Context.FindRenderObject() as RenderBox;
            Offset target = box.LocalToGlobal(box.Size.Center(Dart.UI.UiDefaultClass.Offset.Zero));
            Widget overlay = new Directionality(textDirection: BasicDefaultClass.Directionality.Of(Context), child: new _TooltipOverlay(message: Widget.Message, height: Height, padding: Padding, margin: Margin, decoration: Decoration, textStyle: TextStyle, animation: new CurvedAnimation(parent: _Controller, curve: CurvesDefaultClass.Curves.FastOutSlowIn), target: target, verticalOffset: VerticalOffset, preferBelow: PreferBelow));
            _Entry = new OverlayEntry(builder: (BuildContext context) => =>overlay);
            OverlayDefaultClass.Overlay.Of(Context, debugRequiredFor: Widget).Insert(_Entry);
            SemanticsserviceDefaultClass.SemanticsService.Tooltip(Widget.Message);
        }




        private void _RemoveEntry()
        {
            _HideTimer?.Cancel();
            _HideTimer = null;
            _ShowTimer?.Cancel();
            _ShowTimer = null;
            _Entry?.Remove();
            _Entry = null;
        }




        private void _HandlePointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
        {
            if (_Entry == null)
            {
                return;
            }

            if (@event is PointerUpEvent || @event is PointerCancelEvent)
            {
                _HideTooltip();
            }
            else if (@event is PointerDownEvent)
            {
                _HideTooltip(immediately: true);
            }

        }




        public new void Deactivate()
        {
            if (_Entry != null)
            {
                _HideTooltip(immediately: true);
            }

            base.Deactivate();
        }




        public new void Dispose()
        {
            BindingDefaultClass.GestureBinding.Instance.PointerRouter.RemoveGlobalRoute(_HandlePointerEvent);
            BindingDefaultClass.RendererBinding.Instance.MouseTracker.RemoveListener(_HandleMouseTrackerChange);
            if (_Entry != null) _RemoveEntry();
            _Controller.Dispose();
            base.Dispose();
        }




        private void _HandleLongPress()
        {
            _LongPressActivated = true;
            bool tooltipCreated = EnsureTooltipVisible();
            if (tooltipCreated) FeedbackDefaultClass.Feedback.ForLongPress(Context);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            TooltipThemeData tooltipTheme = TooltipthemeDefaultClass.TooltipTheme.Of(context);
            TextStyle defaultTextStyle = default(TextStyle);
            BoxDecoration defaultDecoration = default(BoxDecoration);
            if (theme.Brightness == Brightness.Dark)
            {
                defaultTextStyle = theme.TextTheme.BodyText2.CopyWith(color: ColorsDefaultClass.Colors.Black);
                defaultDecoration = new BoxDecoration(color: ColorsDefaultClass.Colors.White.WithOpacity(0.9), borderRadius: BorderRadius.All(Radius.Circular(4)));
            }
            else
            {
                defaultTextStyle = theme.TextTheme.BodyText2.CopyWith(color: ColorsDefaultClass.Colors.White);
                defaultDecoration = new BoxDecoration(color: ColorsDefaultClass.Colors.Grey[700].WithOpacity(0.9), borderRadius: BorderRadius.All(Radius.Circular(4)));
            }

            Height = Widget.Height ?? tooltipTheme.Height ?? _DefaultTooltipHeight;
            Padding = Widget.Padding ?? tooltipTheme.Padding ?? _DefaultPadding;
            Margin = Widget.Margin ?? tooltipTheme.Margin ?? _DefaultMargin;
            VerticalOffset = Widget.VerticalOffset ?? tooltipTheme.VerticalOffset ?? _DefaultVerticalOffset;
            PreferBelow = Widget.PreferBelow ?? tooltipTheme.PreferBelow ?? _DefaultPreferBelow;
            ExcludeFromSemantics = Widget.ExcludeFromSemantics ?? tooltipTheme.ExcludeFromSemantics ?? _DefaultExcludeFromSemantics;
            Decoration = Widget.Decoration ?? tooltipTheme.Decoration ?? defaultDecoration;
            TextStyle = Widget.TextStyle ?? tooltipTheme.TextStyle ?? defaultTextStyle;
            WaitDuration = Widget.WaitDuration ?? tooltipTheme.WaitDuration ?? _DefaultWaitDuration;
            ShowDuration = Widget.ShowDuration ?? tooltipTheme.ShowDuration ?? _DefaultShowDuration;
            Widget result = new GestureDetector(behavior: HitTestBehavior.Opaque, onLongPress: _HandleLongPress, excludeFromSemantics: true, child: new Semantics(label: ExcludeFromSemantics ? null : Widget.Message, child: Widget.Child));
            if (_MouseIsConnected)
            {
                result = new MouseRegion(onEnter: (PointerEnterEvent @event) => =>_ShowTooltip(), onExit: (PointerExitEvent @event) => =>_HideTooltip(), child: result);
            }

            return result;
        }



    }


    /// <Summary>
    /// A delegate for computing the layout of a tooltip to be displayed above or
    /// bellow a target specified in the global coordinate system.
    /// </Summary>
    public class _TooltipPositionDelegate : FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate
    {
        /// <Summary>
        /// Creates a delegate for computing the layout of a tooltip.
        ///
        /// The arguments must not be null.
        /// </Summary>
        public _TooltipPositionDelegate(FlutterBinding.UI.Offset target = default(FlutterBinding.UI.Offset), double verticalOffset = default(double), bool preferBelow = default(bool))
        : base()
        {
            this.Target = target;
            this.VerticalOffset = verticalOffset;
            this.PreferBelow = preferBelow;
        }
        /// <Summary>
        /// The offset of the target the tooltip is positioned near in the global
        /// coordinate system.
        /// </Summary>
        public virtual FlutterBinding.UI.Offset Target { get; set; }
        /// <Summary>
        /// The amount of vertical distance between the target and the displayed
        /// tooltip.
        /// </Summary>
        public virtual double VerticalOffset { get; set; }
        /// <Summary>
        /// Whether the tooltip is displayed below its widget by default.
        ///
        /// If there is insufficient space to display the tooltip in the preferred
        /// direction, the tooltip will be displayed in the opposite direction.
        /// </Summary>
        public virtual bool PreferBelow { get; set; }

        public new FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(FlutterSDK.Rendering.Box.BoxConstraints constraints) => constraints.Loosen();



        public new Offset GetPositionForChild(Size size, Size childSize)
        {
            return GeometryDefaultClass.PositionDependentBox(size: size, childSize: childSize, target: Target, verticalOffset: VerticalOffset, preferBelow: PreferBelow);
        }




        public new bool ShouldRelayout(FlutterSDK.Material.Tooltip._TooltipPositionDelegate oldDelegate)
        {
            return Target != oldDelegate.Target || VerticalOffset != oldDelegate.VerticalOffset || PreferBelow != oldDelegate.PreferBelow;
        }


        public new bool ShouldRelayout(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate oldDelegate)
        {
            return Target != oldDelegate.Target || VerticalOffset != oldDelegate.VerticalOffset || PreferBelow != oldDelegate.PreferBelow;
        }



    }


    public class _TooltipOverlay : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _TooltipOverlay(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string message = default(string), double height = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry margin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Decoration.Decoration decoration = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Offset target = default(FlutterBinding.UI.Offset), double verticalOffset = default(double), bool preferBelow = default(bool))
        : base(key: key)
        {
            this.Message = message;
            this.Height = height;
            this.Padding = padding;
            this.Margin = margin;
            this.Decoration = decoration;
            this.TextStyle = textStyle;
            this.Animation = animation;
            this.Target = target;
            this.VerticalOffset = verticalOffset;
            this.PreferBelow = preferBelow;
        }
        public virtual string Message { get; set; }
        public virtual double Height { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Margin { get; set; }
        public virtual FlutterSDK.Painting.Decoration.Decoration Decoration { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
        public virtual FlutterBinding.UI.Offset Target { get; set; }
        public virtual double VerticalOffset { get; set; }
        public virtual bool PreferBelow { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return Positioned.Fill(child: new IgnorePointer(child: new CustomSingleChildLayout(@delegate: new _TooltipPositionDelegate(target: Target, verticalOffset: VerticalOffset, preferBelow: PreferBelow), child: new FadeTransition(opacity: Animation, child: new ConstrainedBox(constraints: new BoxConstraints(minHeight: Height), child: new DefaultTextStyle(style: ThemeDefaultClass.Theme.Of(context).TextTheme.BodyText2, child: new Container(decoration: Decoration, padding: Padding, margin: Margin, child: new Center(widthFactor: 1.0, heightFactor: 1.0, child: new Text(Message, style: TextStyle)))))))));
        }



    }

}
