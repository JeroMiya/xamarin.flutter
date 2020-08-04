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
namespace FlutterSDK.Widgets.Scrollnotification
{
    /// <Summary>
    /// A predicate for [ScrollNotification], used to customize widgets that
    /// listen to notifications from their children.
    /// </Summary>
    public delegate bool ScrollNotificationPredicate(FlutterSDK.Widgets.Scrollnotification.ScrollNotification notification);
    internal static class ScrollnotificationDefaultClass
    {
        /// <Summary>
        /// A [ScrollNotificationPredicate] that checks whether
        /// `notification.depth == 0`, which means that the notification did not bubble
        /// through any intervening scrolling widgets.
        /// </Summary>
        internal static bool DefaultScrollNotificationPredicate(FlutterSDK.Widgets.Scrollnotification.ScrollNotification notification)
        {
            return notification.Depth == 0;
        }



    }

    /// <Summary>
    /// A [Notification] related to scrolling.
    ///
    /// [Scrollable] widgets notify their ancestors about scrolling-related changes.
    /// The notifications have the following lifecycle:
    ///
    ///  * A [ScrollStartNotification], which indicates that the widget has started
    ///    scrolling.
    ///  * Zero or more [ScrollUpdateNotification]s, which indicate that the widget
    ///    has changed its scroll position, mixed with zero or more
    ///    [OverscrollNotification]s, which indicate that the widget has not changed
    ///    its scroll position because the change would have caused its scroll
    ///    position to go outside its scroll bounds.
    ///  * Interspersed with the [ScrollUpdateNotification]s and
    ///    [OverscrollNotification]s are zero or more [UserScrollNotification]s,
    ///    which indicate that the user has changed the direction in which they are
    ///    scrolling.
    ///  * A [ScrollEndNotification], which indicates that the widget has stopped
    ///    scrolling.
    ///  * A [UserScrollNotification], with a [UserScrollNotification.direction] of
    ///    [ScrollDirection.idle].
    ///
    /// Notifications bubble up through the tree, which means a given
    /// [NotificationListener] will receive notifications for all descendant
    /// [Scrollable] widgets. To focus on notifications from the nearest
    /// [Scrollable] descendant, check that the [depth] property of the notification
    /// is zero.
    ///
    /// When a scroll notification is received by a [NotificationListener], the
    /// listener will have already completed build and layout, and it is therefore
    /// too late for that widget to call [State.setState]. Any attempt to adjust the
    /// build or layout based on a scroll notification would result in a layout that
    /// lagged one frame behind, which is a poor user experience. Scroll
    /// notifications are therefore primarily useful for paint effects (since paint
    /// happens after layout). The [GlowingOverscrollIndicator] and [Scrollbar]
    /// widgets are examples of paint effects that use scroll notifications.
    ///
    /// To drive layout based on the scroll position, consider listening to the
    /// [ScrollPosition] directly (or indirectly via a [ScrollController]).
    /// </Summary>
    public interface IScrollNotification
    {
        void DebugFillDescription(List<string> description);
        FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics Metrics { get; }
        FlutterSDK.Widgets.Framework.BuildContext Context { get; }
    }


    public interface IViewportNotificationMixin { }

    public class ViewportNotificationMixin
    {
        internal virtual int _Depth { get; set; }
        public virtual int Depth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool VisitAncestor(FlutterSDK.Widgets.Framework.Element element)
        {
            if (element is RenderObjectElement && element.RenderObject is RenderAbstractViewport) _Depth += 1;
            return base.VisitAncestor(element);
        }




        public new void DebugFillDescription(List<string> description)
        {
            base.DebugFillDescription(description);
            description.Add($"'depth: {Depth} ({Depth == 0 ? "local":"remote"})'");
        }



    }
    public static class ViewportNotificationMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IViewportNotificationMixin, ViewportNotificationMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IViewportNotificationMixin, ViewportNotificationMixin>();
        static ViewportNotificationMixin GetOrCreate(IViewportNotificationMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ViewportNotificationMixin();
                _table.Add(instance, value);
            }
            return (ViewportNotificationMixin)value;
        }
        public static int DepthProperty(this IViewportNotificationMixin instance) => GetOrCreate(instance).Depth;
        public static bool VisitAncestor(this IViewportNotificationMixin instance, FlutterSDK.Widgets.Framework.Element element) => GetOrCreate(instance).VisitAncestor(element);
        public static void DebugFillDescription(this IViewportNotificationMixin instance, List<string> description) => GetOrCreate(instance).DebugFillDescription(description);
    }


    /// <Summary>
    /// A [Notification] related to scrolling.
    ///
    /// [Scrollable] widgets notify their ancestors about scrolling-related changes.
    /// The notifications have the following lifecycle:
    ///
    ///  * A [ScrollStartNotification], which indicates that the widget has started
    ///    scrolling.
    ///  * Zero or more [ScrollUpdateNotification]s, which indicate that the widget
    ///    has changed its scroll position, mixed with zero or more
    ///    [OverscrollNotification]s, which indicate that the widget has not changed
    ///    its scroll position because the change would have caused its scroll
    ///    position to go outside its scroll bounds.
    ///  * Interspersed with the [ScrollUpdateNotification]s and
    ///    [OverscrollNotification]s are zero or more [UserScrollNotification]s,
    ///    which indicate that the user has changed the direction in which they are
    ///    scrolling.
    ///  * A [ScrollEndNotification], which indicates that the widget has stopped
    ///    scrolling.
    ///  * A [UserScrollNotification], with a [UserScrollNotification.direction] of
    ///    [ScrollDirection.idle].
    ///
    /// Notifications bubble up through the tree, which means a given
    /// [NotificationListener] will receive notifications for all descendant
    /// [Scrollable] widgets. To focus on notifications from the nearest
    /// [Scrollable] descendant, check that the [depth] property of the notification
    /// is zero.
    ///
    /// When a scroll notification is received by a [NotificationListener], the
    /// listener will have already completed build and layout, and it is therefore
    /// too late for that widget to call [State.setState]. Any attempt to adjust the
    /// build or layout based on a scroll notification would result in a layout that
    /// lagged one frame behind, which is a poor user experience. Scroll
    /// notifications are therefore primarily useful for paint effects (since paint
    /// happens after layout). The [GlowingOverscrollIndicator] and [Scrollbar]
    /// widgets are examples of paint effects that use scroll notifications.
    ///
    /// To drive layout based on the scroll position, consider listening to the
    /// [ScrollPosition] directly (or indirectly via a [ScrollController]).
    /// </Summary>
    public class ScrollNotification : FlutterSDK.Widgets.Notificationlistener.LayoutChangedNotification, IViewportNotificationMixin
    {
        /// <Summary>
        /// Initializes fields for subclasses.
        /// </Summary>
        public ScrollNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics = default(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext))
        {
            this.Metrics = metrics;
            this.Context = context;
        }
        /// <Summary>
        /// A description of a [Scrollable]'s contents, useful for modeling the state
        /// of its viewport.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics Metrics { get; set; }
        /// <Summary>
        /// The build context of the widget that fired this notification.
        ///
        /// This can be used to find the scrollable's render objects to determine the
        /// size of the viewport, for instance.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.BuildContext Context { get; set; }

        public new void DebugFillDescription(List<string> description)
        {
            base.DebugFillDescription(description);
            description.Add($"'{Metrics}'");
        }



    }


    /// <Summary>
    /// A notification that a [Scrollable] widget has started scrolling.
    ///
    /// See also:
    ///
    ///  * [ScrollEndNotification], which indicates that scrolling has stopped.
    ///  * [ScrollNotification], which describes the notification lifecycle.
    /// </Summary>
    public class ScrollStartNotification : FlutterSDK.Widgets.Scrollnotification.ScrollNotification
    {
        /// <Summary>
        /// Creates a notification that a [Scrollable] widget has started scrolling.
        /// </Summary>
        public ScrollStartNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics = default(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Gestures.Dragdetails.DragStartDetails dragDetails = default(FlutterSDK.Gestures.Dragdetails.DragStartDetails))
        : base(metrics: metrics, context: context)
        {
            this.DragDetails = dragDetails;
        }
        /// <Summary>
        /// If the [Scrollable] started scrolling because of a drag, the details about
        /// that drag start.
        ///
        /// Otherwise, null.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.DragStartDetails DragDetails { get; set; }

        public new void DebugFillDescription(List<string> description)
        {
            base.DebugFillDescription(description);
            if (DragDetails != null) description.Add($"'{DragDetails}'");
        }



    }


    /// <Summary>
    /// A notification that a [Scrollable] widget has changed its scroll position.
    ///
    /// See also:
    ///
    ///  * [OverscrollNotification], which indicates that a [Scrollable] widget
    ///    has not changed its scroll position because the change would have caused
    ///    its scroll position to go outside its scroll bounds.
    ///  * [ScrollNotification], which describes the notification lifecycle.
    /// </Summary>
    public class ScrollUpdateNotification : FlutterSDK.Widgets.Scrollnotification.ScrollNotification
    {
        /// <Summary>
        /// Creates a notification that a [Scrollable] widget has changed its scroll
        /// position.
        /// </Summary>
        public ScrollUpdateNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics = default(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Gestures.Dragdetails.DragUpdateDetails dragDetails = default(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails), double scrollDelta = default(double))
        : base(metrics: metrics, context: context)
        {
            this.DragDetails = dragDetails;
            this.ScrollDelta = scrollDelta;
        }
        /// <Summary>
        /// If the [Scrollable] changed its scroll position because of a drag, the
        /// details about that drag update.
        ///
        /// Otherwise, null.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.DragUpdateDetails DragDetails { get; set; }
        /// <Summary>
        /// The distance by which the [Scrollable] was scrolled, in logical pixels.
        /// </Summary>
        public virtual double ScrollDelta { get; set; }

        public new void DebugFillDescription(List<string> description)
        {
            base.DebugFillDescription(description);
            description.Add($"'scrollDelta: {ScrollDelta}'");
            if (DragDetails != null) description.Add($"'{DragDetails}'");
        }



    }


    /// <Summary>
    /// A notification that a [Scrollable] widget has not changed its scroll position
    /// because the change would have caused its scroll position to go outside of
    /// its scroll bounds.
    ///
    /// See also:
    ///
    ///  * [ScrollUpdateNotification], which indicates that a [Scrollable] widget
    ///    has changed its scroll position.
    ///  * [ScrollNotification], which describes the notification lifecycle.
    /// </Summary>
    public class OverscrollNotification : FlutterSDK.Widgets.Scrollnotification.ScrollNotification
    {
        /// <Summary>
        /// Creates a notification that a [Scrollable] widget has changed its scroll
        /// position outside of its scroll bounds.
        /// </Summary>
        public OverscrollNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics = default(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Gestures.Dragdetails.DragUpdateDetails dragDetails = default(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails), double overscroll = default(double), double velocity = 0.0)
        : base(metrics: metrics, context: context)
        {
            this.DragDetails = dragDetails;
            this.Overscroll = overscroll;
            this.Velocity = velocity;
        }
        /// <Summary>
        /// If the [Scrollable] overscrolled because of a drag, the details about that
        /// drag update.
        ///
        /// Otherwise, null.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.DragUpdateDetails DragDetails { get; set; }
        /// <Summary>
        /// The number of logical pixels that the [Scrollable] avoided scrolling.
        ///
        /// This will be negative for overscroll on the "start" side and positive for
        /// overscroll on the "end" side.
        /// </Summary>
        public virtual double Overscroll { get; set; }
        /// <Summary>
        /// The velocity at which the [ScrollPosition] was changing when this
        /// overscroll happened.
        ///
        /// This will typically be 0.0 for touch-driven overscrolls, and positive
        /// for overscrolls that happened from a [BallisticScrollActivity] or
        /// [DrivenScrollActivity].
        /// </Summary>
        public virtual double Velocity { get; set; }

        public new void DebugFillDescription(List<string> description)
        {
            base.DebugFillDescription(description);
            description.Add($"'overscroll: {Overscroll.ToStringAsFixed(1)}'");
            description.Add($"'velocity: {Velocity.ToStringAsFixed(1)}'");
            if (DragDetails != null) description.Add($"'{DragDetails}'");
        }



    }


    /// <Summary>
    /// A notification that a [Scrollable] widget has stopped scrolling.
    ///
    /// See also:
    ///
    ///  * [ScrollStartNotification], which indicates that scrolling has started.
    ///  * [ScrollNotification], which describes the notification lifecycle.
    /// </Summary>
    public class ScrollEndNotification : FlutterSDK.Widgets.Scrollnotification.ScrollNotification
    {
        /// <Summary>
        /// Creates a notification that a [Scrollable] widget has stopped scrolling.
        /// </Summary>
        public ScrollEndNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics = default(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Gestures.Dragdetails.DragEndDetails dragDetails = default(FlutterSDK.Gestures.Dragdetails.DragEndDetails))
        : base(metrics: metrics, context: context)
        {
            this.DragDetails = dragDetails;
        }
        /// <Summary>
        /// If the [Scrollable] stopped scrolling because of a drag, the details about
        /// that drag end.
        ///
        /// Otherwise, null.
        ///
        /// If a drag ends with some residual velocity, a typical [ScrollPhysics] will
        /// start a ballistic scroll, which delays the [ScrollEndNotification] until
        /// the ballistic simulation completes, at which time [dragDetails] will
        /// be null. If the residual velocity is too small to trigger ballistic
        /// scrolling, then the [ScrollEndNotification] will be dispatched immediately
        /// and [dragDetails] will be non-null.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.DragEndDetails DragDetails { get; set; }

        public new void DebugFillDescription(List<string> description)
        {
            base.DebugFillDescription(description);
            if (DragDetails != null) description.Add($"'{DragDetails}'");
        }



    }


    /// <Summary>
    /// A notification that the user has changed the direction in which they are
    /// scrolling.
    ///
    /// See also:
    ///
    ///  * [ScrollNotification], which describes the notification lifecycle.
    /// </Summary>
    public class UserScrollNotification : FlutterSDK.Widgets.Scrollnotification.ScrollNotification
    {
        /// <Summary>
        /// Creates a notification that the user has changed the direction in which
        /// they are scrolling.
        /// </Summary>
        public UserScrollNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics = default(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Rendering.Viewportoffset.ScrollDirection direction = default(FlutterSDK.Rendering.Viewportoffset.ScrollDirection))
        : base(metrics: metrics, context: context)
        {
            this.Direction = direction;
        }
        /// <Summary>
        /// The direction in which the user is scrolling.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Viewportoffset.ScrollDirection Direction { get; set; }

        public new void DebugFillDescription(List<string> description)
        {
            base.DebugFillDescription(description);
            description.Add($"'direction: {Direction}'");
        }



    }

}
