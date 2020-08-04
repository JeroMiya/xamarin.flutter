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
namespace FlutterSDK.Widgets.Scrollbar
{
    internal static class ScrollbarDefaultClass
    {
        public static double _KMinThumbExtent = default(double);
        public static double _KMinInteractiveSize = default(double);
    }

    /// <Summary>
    /// A [CustomPainter] for painting scrollbars.
    ///
    /// The size of the scrollbar along its scroll direction is typically
    /// proportional to the percentage of content completely visible on screen,
    /// as long as its size isn't less than [minLength] and it isn't overscrolling.
    ///
    /// Unlike [CustomPainter]s that subclasses [CustomPainter] and only repaint
    /// when [shouldRepaint] returns true (which requires this [CustomPainter] to
    /// be rebuilt), this painter has the added optimization of repainting and not
    /// rebuilding when:
    ///
    ///  * the scroll position changes; and
    ///  * when the scrollbar fades away.
    ///
    /// Calling [update] with the new [ScrollMetrics] will repaint the new scrollbar
    /// position.
    ///
    /// Updating the value on the provided [fadeoutOpacityAnimation] will repaint
    /// with the new opacity.
    ///
    /// You must call [dispose] on this [ScrollbarPainter] when it's no longer used.
    ///
    /// See also:
    ///
    ///  * [Scrollbar] for a widget showing a scrollbar around a [Scrollable] in the
    ///    Material Design style.
    ///  * [CupertinoScrollbar] for a widget showing a scrollbar around a
    ///    [Scrollable] in the iOS style.
    /// </Summary>
    public class ScrollbarPainter : FlutterSDK.Foundation.Changenotifier.ChangeNotifier, ICustomPainter
    {
        /// <Summary>
        /// Creates a scrollbar with customizations given by construction arguments.
        /// </Summary>
        public ScrollbarPainter(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), TextDirection textDirection = default(TextDirection), double thickness = default(double), FlutterSDK.Animation.Animation.Animation<double> fadeoutOpacityAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), double mainAxisMargin = 0.0, double crossAxisMargin = 0.0, Radius radius = default(Radius), double minLength = default(double), double minOverscrollLength = default(double))
        : base()
        {
            this.Thickness = thickness;
            this.FadeoutOpacityAnimation = fadeoutOpacityAnimation;
            this.MainAxisMargin = mainAxisMargin;
            this.CrossAxisMargin = crossAxisMargin;
            this.Radius = radius;
            this.MinLength = minLength;
            FadeoutOpacityAnimation.AddListener(NotifyListeners);
        }


        internal virtual FlutterBinding.UI.Color _Color { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        /// <Summary>
        /// Thickness of the scrollbar in its cross-axis in logical pixels. Mustn't be null.
        /// </Summary>
        public virtual double Thickness { get; set; }
        /// <Summary>
        /// An opacity [Animation] that dictates the opacity of the thumb.
        /// Changes in value of this [Listenable] will automatically trigger repaints.
        /// Mustn't be null.
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<double> FadeoutOpacityAnimation { get; set; }
        /// <Summary>
        /// Distance from the scrollbar's start and end to the edge of the viewport
        /// in logical pixels. It affects the amount of available paint area.
        ///
        /// Mustn't be null and defaults to 0.
        /// </Summary>
        public virtual double MainAxisMargin { get; set; }
        /// <Summary>
        /// Distance from the scrollbar's side to the nearest edge in logical pixels.
        ///
        /// Must not be null and defaults to 0.
        /// </Summary>
        public virtual double CrossAxisMargin { get; set; }
        /// <Summary>
        /// [Radius] of corners if the scrollbar should have rounded corners.
        ///
        /// Scrollbar will be rectangular if [radius] is null.
        /// </Summary>
        public virtual Radius Radius { get; set; }
        internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets _Padding { get; set; }
        /// <Summary>
        /// The preferred smallest size the scrollbar can shrink to when the total
        /// scrollable extent is large, the current visible viewport is small, and the
        /// viewport is not overscrolled.
        ///
        /// The size of the scrollbar may shrink to a smaller size than [minLength]
        /// to fit in the available paint area. E.g., when [minLength] is
        /// `double.infinity`, it will not be respected if [viewportDimension] and
        /// [mainAxisMargin] are finite.
        ///
        /// Mustn't be null and the value has to be within the range of 0 to
        /// [minOverscrollLength], inclusive. Defaults to 18.0.
        /// </Summary>
        public virtual double MinLength { get; set; }
        /// <Summary>
        /// The preferred smallest size the scrollbar can shrink to when viewport is
        /// overscrolled.
        ///
        /// When overscrolling, the size of the scrollbar may shrink to a smaller size
        /// than [minOverscrollLength] to fit in the available paint area. E.g., when
        /// [minOverscrollLength] is `double.infinity`, it will not be respected if
        /// the [viewportDimension] and [mainAxisMargin] are finite.
        ///
        /// The value is less than or equal to [minLength] and greater than or equal to 0.
        /// If unspecified or set to null, it will defaults to the value of [minLength].
        /// </Summary>
        public virtual double MinOverscrollLength { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics _LastMetrics { get; set; }
        internal virtual FlutterSDK.Painting.Basictypes.AxisDirection _LastAxisDirection { get; set; }
        internal virtual FlutterBinding.UI.Rect _ThumbRect { get; set; }
        public virtual FlutterBinding.UI.Color Color { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Padding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual SKPaint _Paint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsVertical { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsReversed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _BeforeExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _AfterExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _MainAxisPadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _TrackExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _TotalContentExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Custompaint.SemanticsBuilderCallback SemanticsBuilder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Update with new [ScrollMetrics]. The scrollbar will show and redraw itself
        /// based on these new metrics.
        ///
        /// The scrollbar will remain on screen.
        /// </Summary>
        public virtual void Update(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection)
        {
            _LastMetrics = metrics;
            _LastAxisDirection = axisDirection;
            NotifyListeners();
        }




        /// <Summary>
        /// Update and redraw with new scrollbar thickness and radius.
        /// </Summary>
        public virtual void UpdateThickness(double nextThickness, Radius nextRadius)
        {
            Thickness = nextThickness;
            Radius = nextRadius;
            NotifyListeners();
        }




        private void _PaintThumbCrossAxis(Canvas canvas, Size size, double thumbOffset, double thumbExtent, FlutterSDK.Painting.Basictypes.AxisDirection direction)
        {
            double x y = default(double);
            Size thumbSize = default(Size);
            switch (direction) { case AxisDirection.Down: thumbSize = new Size(Thickness, thumbExtent); x = TextDirection == TextDirection.Rtl ? CrossAxisMargin + Padding.Left : size.Width - Thickness - CrossAxisMargin - Padding.Right; y = thumbOffset; break; case AxisDirection.Up: thumbSize = new Size(Thickness, thumbExtent); x = TextDirection == TextDirection.Rtl ? CrossAxisMargin + Padding.Left : size.Width - Thickness - CrossAxisMargin - Padding.Right; y = thumbOffset; break; case AxisDirection.Left: thumbSize = new Size(thumbExtent, Thickness); x = thumbOffset; y = size.Height - Thickness - CrossAxisMargin - Padding.Bottom; break; case AxisDirection.Right: thumbSize = new Size(thumbExtent, Thickness); x = thumbOffset; y = size.Height - Thickness - CrossAxisMargin - Padding.Bottom; break; }
            _ThumbRect = new Offset(x, y) & thumbSize;
            if (Radius == null) canvas.DrawRect(_ThumbRect, _Paint); else canvas.DrawRRect(RRect.FromRectAndRadius(_ThumbRect, Radius), _Paint);
        }




        private double _ThumbExtent()
        {
            double fractionVisible = ((_LastMetrics.ExtentInside - _MainAxisPadding) / (_TotalContentExtent - _MainAxisPadding)).Clamp(0.0, 1.0) as double;
            double thumbExtent = Dart.Math.MathDefaultClass.Max(Dart.Math.MathDefaultClass.Min(_TrackExtent, MinOverscrollLength), _TrackExtent * fractionVisible);
            double fractionOverscrolled = 1.0 - _LastMetrics.ExtentInside / _LastMetrics.ViewportDimension;
            double safeMinLength = Dart.Math.MathDefaultClass.Min(MinLength, _TrackExtent);
            double newMinLength = (_BeforeExtent > 0 && _AfterExtent > 0) ? safeMinLength : safeMinLength * (1.0 - fractionOverscrolled.Clamp(0.0, 0.2) / 0.2);
            return thumbExtent.Clamp(newMinLength, _TrackExtent) as double;
        }




        public new void Dispose()
        {
            FadeoutOpacityAnimation.RemoveListener(NotifyListeners);
            base.Dispose();
        }




        /// <Summary>
        /// Convert between a thumb track position and the corresponding scroll
        /// position.
        ///
        /// thumbOffsetLocal is a position in the thumb track. Cannot be null.
        /// </Summary>
        public virtual double GetTrackToScroll(double thumbOffsetLocal)
        {

            double scrollableExtent = _LastMetrics.MaxScrollExtent - _LastMetrics.MinScrollExtent;
            double thumbMovableExtent = _TrackExtent - _ThumbExtent();
            return scrollableExtent * thumbOffsetLocal / thumbMovableExtent;
        }




        private double _GetScrollToTrack(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, double thumbExtent)
        {
            double scrollableExtent = metrics.MaxScrollExtent - metrics.MinScrollExtent;
            double fractionPast = (scrollableExtent > 0) ? ((metrics.Pixels - metrics.MinScrollExtent) / scrollableExtent).Clamp(0.0, 1.0) as double : 0;
            return (_IsReversed ? 1 - fractionPast : fractionPast) * (_TrackExtent - thumbExtent);
        }




        public new void Paint(Canvas canvas, Size size)
        {
            if (_LastAxisDirection == null || _LastMetrics == null || FadeoutOpacityAnimation.Value == 0.0) return;
            if (_LastMetrics.ViewportDimension <= _MainAxisPadding || _TrackExtent <= 0)
            {
                return;
            }

            double beforePadding = _IsVertical ? Padding.Top : Padding.Left;
            double thumbExtent = _ThumbExtent();
            double thumbOffsetLocal = _GetScrollToTrack(_LastMetrics, thumbExtent);
            double thumbOffset = thumbOffsetLocal + MainAxisMargin + beforePadding;
            return _PaintThumbCrossAxis(canvas, size, thumbOffset, thumbExtent, _LastAxisDirection);
        }




        /// <Summary>
        /// Same as hitTest, but includes some padding to make sure that the region
        /// isn't too small to be interacted with by the user.
        /// </Summary>
        public virtual bool HitTestInteractive(FlutterBinding.UI.Offset position)
        {
            if (_ThumbRect == null)
            {
                return false;
            }

            if (FadeoutOpacityAnimation.Value == 0.0)
            {
                return false;
            }

            Rect interactiveThumbRect = _ThumbRect.ExpandToInclude(Rect.FromCircle(center: _ThumbRect.Center, radius: ScrollbarDefaultClass._KMinInteractiveSize / 2));
            return interactiveThumbRect.Contains(position);
        }




        public new bool HitTest(FlutterBinding.UI.Offset position)
        {
            if (_ThumbRect == null)
            {
                return null;
            }

            if (FadeoutOpacityAnimation.Value == 0.0)
            {
                return false;
            }

            return _ThumbRect.Contains(position);
        }




        public new bool ShouldRepaint(FlutterSDK.Widgets.Scrollbar.ScrollbarPainter old)
        {
            return Color != old.Color || TextDirection != old.TextDirection || Thickness != old.Thickness || FadeoutOpacityAnimation != old.FadeoutOpacityAnimation || MainAxisMargin != old.MainAxisMargin || CrossAxisMargin != old.CrossAxisMargin || Radius != old.Radius || MinLength != old.MinLength || Padding != old.Padding;
        }


        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            return Color != old.Color || TextDirection != old.TextDirection || Thickness != old.Thickness || FadeoutOpacityAnimation != old.FadeoutOpacityAnimation || MainAxisMargin != old.MainAxisMargin || CrossAxisMargin != old.CrossAxisMargin || Radius != old.Radius || MinLength != old.MinLength || Padding != old.Padding;
        }




        public new bool ShouldRebuildSemantics(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate) => false;


        CustomPainter _CustomPainterInstance = new CustomPainter();
        public void AddListener(VoidCallback listener) => _CustomPainterInstance.AddListener(listener);
        public void RemoveListener(VoidCallback listener) => _CustomPainterInstance.RemoveListener(listener);
        public string ToString() => _CustomPainterInstance.ToString();
    }

}
