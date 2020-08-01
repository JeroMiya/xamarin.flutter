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
namespace FlutterSDK.Material.Refreshindicator
{
    /// <Summary>
    /// The signature for a function that's called when the user has dragged a
    /// [RefreshIndicator] far enough to demonstrate that they want the app to
    /// refresh. The returned [Future] must complete when the refresh operation is
    /// finished.
    ///
    /// Used by [RefreshIndicator.onRefresh].
    /// </Summary>
    public delegate Future<object> RefreshCallback();
    internal static class RefreshindicatorDefaultClass
    {
        public static double _KDragContainerExtentPercentage = default(double);
        public static double _KDragSizeFactorLimit = default(double);
        public static TimeSpan _KIndicatorSnapDuration = default(TimeSpan);
        public static TimeSpan _KIndicatorScaleDuration = default(TimeSpan);
    }

    /// <Summary>
    /// A widget that supports the Material "swipe to refresh" idiom.
    ///
    /// When the child's [Scrollable] descendant overscrolls, an animated circular
    /// progress indicator is faded into view. When the scroll ends, if the
    /// indicator has been dragged far enough for it to become completely opaque,
    /// the [onRefresh] callback is called. The callback is expected to update the
    /// scrollable's contents and then complete the [Future] it returns. The refresh
    /// indicator disappears after the callback's [Future] has completed.
    ///
    /// ## Troubleshooting
    ///
    /// ### Refresh indicator does not show up
    ///
    /// The [RefreshIndicator] will appear if its scrollable descendant can be
    /// overscrolled, i.e. if the scrollable's content is bigger than its viewport.
    /// To ensure that the [RefreshIndicator] will always appear, even if the
    /// scrollable's content fits within its viewport, set the scrollable's
    /// [Scrollable.physics] property to [AlwaysScrollableScrollPhysics]:
    ///
    /// ```dart
    /// ListView(
    ///   physics: const AlwaysScrollableScrollPhysics(),
    ///   children: ...
    /// )
    /// ```
    ///
    /// A [RefreshIndicator] can only be used with a vertical scroll view.
    ///
    /// See also:
    ///
    ///  * <https://material.io/design/platform-guidance/android-swipe-to-refresh.html>
    ///  * [RefreshIndicatorState], can be used to programmatically show the refresh indicator.
    ///  * [RefreshProgressIndicator], widget used by [RefreshIndicator] to show
    ///    the inner circular progress spinner during refreshes.
    ///  * [CupertinoSliverRefreshControl], an iOS equivalent of the pull-to-refresh pattern.
    ///    Must be used as a sliver inside a [CustomScrollView] instead of wrapping
    ///    around a [ScrollView] because it's a part of the scrollable instead of
    ///    being overlaid on top of it.
    /// </Summary>
    public class RefreshIndicator : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a refresh indicator.
        ///
        /// The [onRefresh], [child], and [notificationPredicate] arguments must be
        /// non-null. The default
        /// [displacement] is 40.0 logical pixels.
        ///
        /// The [semanticsLabel] is used to specify an accessibility label for this widget.
        /// If it is null, it will be defaulted to [MaterialLocalizations.refreshIndicatorSemanticLabel].
        /// An empty string may be passed to avoid having anything read by screen reading software.
        /// The [semanticsValue] may be used to specify progress on the widget.
        /// </Summary>
        public RefreshIndicator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), double displacement = 40.0, FlutterSDK.Material.Refreshindicator.RefreshCallback onRefresh = default(FlutterSDK.Material.Refreshindicator.RefreshCallback), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Scrollnotification.ScrollNotificationPredicate notificationPredicate = default(FlutterSDK.Widgets.Scrollnotification.ScrollNotificationPredicate), string semanticsLabel = default(string), string semanticsValue = default(string), double strokeWidth = 2.0)
        : base(key: key)
        {
            this.Child = child;
            this.Displacement = displacement;
            this.OnRefresh = onRefresh;
            this.Color = color;
            this.BackgroundColor = backgroundColor;
            this.NotificationPredicate = notificationPredicate;
            this.SemanticsLabel = semanticsLabel;
            this.SemanticsValue = semanticsValue;
            this.StrokeWidth = strokeWidth;
        }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// The refresh indicator will be stacked on top of this child. The indicator
        /// will appear when child's Scrollable descendant is over-scrolled.
        ///
        /// Typically a [ListView] or [CustomScrollView].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The distance from the child's top or bottom edge to where the refresh
        /// indicator will settle. During the drag that exposes the refresh indicator,
        /// its actual displacement may significantly exceed this value.
        /// </Summary>
        public virtual double Displacement { get; set; }
        /// <Summary>
        /// A function that's called when the user has dragged the refresh indicator
        /// far enough to demonstrate that they want the app to refresh. The returned
        /// [Future] must complete when the refresh operation is finished.
        /// </Summary>
        public virtual FlutterSDK.Material.Refreshindicator.RefreshCallback OnRefresh { get; set; }
        /// <Summary>
        /// The progress indicator's foreground color. The current theme's
        /// [ThemeData.accentColor] by default.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// The progress indicator's background color. The current theme's
        /// [ThemeData.canvasColor] by default.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// A check that specifies whether a [ScrollNotification] should be
        /// handled by this widget.
        ///
        /// By default, checks whether `notification.depth == 0`. Set it to something
        /// else for more complicated layouts.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollnotification.ScrollNotificationPredicate NotificationPredicate { get; set; }
        /// <Summary>
        /// {@macro flutter.material.progressIndicator.semanticsLabel}
        ///
        /// This will be defaulted to [MaterialLocalizations.refreshIndicatorSemanticLabel]
        /// if it is null.
        /// </Summary>
        public virtual string SemanticsLabel { get; set; }
        /// <Summary>
        /// {@macro flutter.material.progressIndicator.semanticsValue}
        /// </Summary>
        public virtual string SemanticsValue { get; set; }
        /// <Summary>
        /// Defines `strokeWidth` for `RefreshIndicator`.
        ///
        /// By default, the value of `strokeWidth` is 2.0 pixels.
        /// </Summary>
        public virtual double StrokeWidth { get; set; }

        public new FlutterSDK.Material.Refreshindicator.RefreshIndicatorState CreateState() => new RefreshIndicatorState();


    }


    /// <Summary>
    /// Contains the state for a [RefreshIndicator]. This class can be used to
    /// programmatically show the refresh indicator, see the [show] method.
    /// </Summary>
    public class RefreshIndicatorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Refreshindicator.RefreshIndicator>, ITickerProviderStateMixin<FlutterSDK.Material.Refreshindicator.RefreshIndicator>
    {
        public RefreshIndicatorState()
        { }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _PositionController { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ScaleController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _PositionFactor { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _ScaleFactor { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Value { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Color> _ValueColor { get; set; }
        internal virtual FlutterSDK.Material.Refreshindicator._RefreshIndicatorMode _Mode { get; set; }
        internal virtual Future<object> _PendingRefreshFuture { get; set; }
        internal virtual bool _IsIndicatorAtTop { get; set; }
        internal virtual double _DragOffset { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _ThreeQuarterTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _KDragSizeFactorLimitTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _OneToZeroTween { get; set; }

        public new void InitState()
        {
            base.InitState();
            _PositionController = new AnimationController(vsync: this);
            _PositionFactor = _PositionController.Drive(_KDragSizeFactorLimitTween);
            _Value = _PositionController.Drive(_ThreeQuarterTween);
            _ScaleController = new AnimationController(vsync: this);
            _ScaleFactor = _ScaleController.Drive(_OneToZeroTween);
        }




        public new void DidChangeDependencies()
        {
            ThemeData theme = ThemeDefaultClass.Theme.Of(Context);
            _ValueColor = _PositionController.Drive(new ColorTween(begin: (Widget.Color ?? theme.AccentColor).WithOpacity(0.0), end: (Widget.Color ?? theme.AccentColor).WithOpacity(1.0)).Chain(new CurveTween(curve: new Interval(0.0, 1.0 / RefreshindicatorDefaultClass._KDragSizeFactorLimit))));
            base.DidChangeDependencies();
        }




        public new void Dispose()
        {
            _PositionController.Dispose();
            _ScaleController.Dispose();
            base.Dispose();
        }




        private bool _HandleScrollNotification(FlutterSDK.Widgets.Scrollnotification.ScrollNotification notification)
        {
            if (!Widget.NotificationPredicate(notification)) return false;
            if (notification is ScrollStartNotification && notification.Metrics.ExtentBefore == 0.0 && _Mode == null && _Start(notification.Metrics.AxisDirection))
            {
                SetState(() =>
                {
                    _Mode = _RefreshIndicatorMode.Drag;
                }
                );
                return false;
            }

            bool indicatorAtTopNow = default(bool);
            switch (notification.Metrics.AxisDirection) { case AxisDirection.Down: indicatorAtTopNow = true; break; case AxisDirection.Up: indicatorAtTopNow = false; break; case AxisDirection.Left: case AxisDirection.Right: indicatorAtTopNow = null; break; }
            if (indicatorAtTopNow != _IsIndicatorAtTop)
            {
                if (_Mode == _RefreshIndicatorMode.Drag || _Mode == _RefreshIndicatorMode.Armed) _Dismiss(_RefreshIndicatorMode.Canceled);
            }
            else if (notification is ScrollUpdateNotification)
            {
                if (_Mode == _RefreshIndicatorMode.Drag || _Mode == _RefreshIndicatorMode.Armed)
                {
                    if (((ScrollUpdateNotification)notification).Metrics.ExtentBefore > 0.0)
                    {
                        _Dismiss(_RefreshIndicatorMode.Canceled);
                    }
                    else
                    {
                        _DragOffset -= notification.ScrollDelta;
                        _CheckDragOffset(notification.Metrics.ViewportDimension);
                    }

                }

                if (_Mode == _RefreshIndicatorMode.Armed && notification.DragDetails == null)
                {
                    _Show();
                }

            }
            else if (notification is OverscrollNotification)
            {
                if (_Mode == _RefreshIndicatorMode.Drag || _Mode == _RefreshIndicatorMode.Armed)
                {
                    _DragOffset -= ((OverscrollNotification)notification).Overscroll / 2.0;
                    _CheckDragOffset(((OverscrollNotification)notification).Metrics.ViewportDimension);
                }

            }
            else if (notification is ScrollEndNotification)
            {
                switch (_Mode) { case _RefreshIndicatorMode.Armed: _Show(); break; case _RefreshIndicatorMode.Drag: _Dismiss(_RefreshIndicatorMode.Canceled); break; default: break; }
            }

            return false;
        }




        private bool _HandleGlowNotification(FlutterSDK.Widgets.Overscrollindicator.OverscrollIndicatorNotification notification)
        {
            if (notification.Depth != 0 || !notification.Leading) return false;
            if (_Mode == _RefreshIndicatorMode.Drag)
            {
                notification.DisallowGlow();
                return true;
            }

            return false;
        }




        private bool _Start(FlutterSDK.Painting.Basictypes.AxisDirection direction)
        {



            switch (direction) { case AxisDirection.Down: _IsIndicatorAtTop = true; break; case AxisDirection.Up: _IsIndicatorAtTop = false; break; case AxisDirection.Left: case AxisDirection.Right: _IsIndicatorAtTop = null; return false; }
            _DragOffset = 0.0;
            _ScaleController.Value = 0.0;
            _PositionController.Value = 0.0;
            return true;
        }




        private void _CheckDragOffset(double containerExtent)
        {

            double newValue = _DragOffset / (containerExtent * RefreshindicatorDefaultClass._KDragContainerExtentPercentage);
            if (_Mode == _RefreshIndicatorMode.Armed) newValue = Dart.Math.MathDefaultClass.Max(newValue, 1.0 / RefreshindicatorDefaultClass._KDragSizeFactorLimit);
            _PositionController.Value = newValue.Clamp(0.0, 1.0) as double;
            if (_Mode == _RefreshIndicatorMode.Drag && _ValueColor.Value.Alpha == 0xFF) _Mode = _RefreshIndicatorMode.Armed;
        }




        private async Future<object> _Dismiss(FlutterSDK.Material.Refreshindicator._RefreshIndicatorMode newMode)
        {
            await Future<void>.Value();

            SetState(() =>
            {
                _Mode = newMode;
            }
            );
            switch (_Mode) { case _RefreshIndicatorMode.Done: await _ScaleController.AnimateTo(1.0, duration: RefreshindicatorDefaultClass._KIndicatorScaleDuration); break; case _RefreshIndicatorMode.Canceled: await _PositionController.AnimateTo(0.0, duration: RefreshindicatorDefaultClass._KIndicatorScaleDuration); break; default: }
            if (Mounted && _Mode == newMode)
            {
                _DragOffset = null;
                _IsIndicatorAtTop = null;
                SetState(() =>
                {
                    _Mode = null;
                }
                );
            }

        }




        private void _Show()
        {


            Completer<void> completer = new Completer<void>();
            _PendingRefreshFuture = completer.Future;
            _Mode = _RefreshIndicatorMode.Snap;
            _PositionController.AnimateTo(1.0 / RefreshindicatorDefaultClass._KDragSizeFactorLimit, duration: RefreshindicatorDefaultClass._KIndicatorSnapDuration).Then((void value) =>
            {
                if (Mounted && _Mode == _RefreshIndicatorMode.Snap)
                {

                    SetState(() =>
                    {
                        _Mode = _RefreshIndicatorMode.Refresh;
                    }
                    );
                    Future<void> refreshResult = Widget.OnRefresh();

                    if (refreshResult == null) return;
                    refreshResult.WhenComplete(() =>
                    {
                        if (Mounted && _Mode == _RefreshIndicatorMode.Refresh)
                        {
                            completer.Complete();
                            _Dismiss(_RefreshIndicatorMode.Done);
                        }

                    }
                    );
                }

            }
            );
        }




        /// <Summary>
        /// Show the refresh indicator and run the refresh callback as if it had
        /// been started interactively. If this method is called while the refresh
        /// callback is running, it quietly does nothing.
        ///
        /// Creating the [RefreshIndicator] with a [GlobalKey<RefreshIndicatorState>]
        /// makes it possible to refer to the [RefreshIndicatorState].
        ///
        /// The future returned from this method completes when the
        /// [RefreshIndicator.onRefresh] callback's future completes.
        ///
        /// If you await the future returned by this function from a [State], you
        /// should check that the state is still [mounted] before calling [setState].
        ///
        /// When initiated in this manner, the refresh indicator is independent of any
        /// actual scroll view. It defaults to showing the indicator at the top. To
        /// show it at the bottom, set `atTop` to false.
        /// </Summary>
        public virtual Future<object> Show(bool atTop = true)
        {
            if (_Mode != _RefreshIndicatorMode.Refresh && _Mode != _RefreshIndicatorMode.Snap)
            {
                if (_Mode == null) _Start(atTop ? AxisDirection.Down : AxisDirection.Up);
                _Show();
            }

            return _PendingRefreshFuture;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            Widget child = new NotificationListener<ScrollNotification>(onNotification: _HandleScrollNotification, child: new NotificationListener<OverscrollIndicatorNotification>(onNotification: _HandleGlowNotification, child: Widget.Child));

            bool showIndeterminateIndicator = _Mode == _RefreshIndicatorMode.Refresh || _Mode == _RefreshIndicatorMode.Done;
            return new Stack(children: new List<Widget>() { child });
        }



    }


    public enum _RefreshIndicatorMode
    {

        Drag,
        Armed,
        Snap,
        Refresh,
        Done,
        Canceled,
    }

}
