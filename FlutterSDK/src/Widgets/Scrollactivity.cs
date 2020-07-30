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
namespace FlutterSDK.Widgets.Scrollactivity
{
    internal static class ScrollactivityDefaultClass
    {
    }

    /// <Summary>
    /// Base class for scrolling activities like dragging and flinging.
    ///
    /// See also:
    ///
    ///  * [ScrollPosition], which uses [ScrollActivity] objects to manage the
    ///    [ScrollPosition] of a [Scrollable].
    /// </Summary>
    public interface IScrollActivity
    {
        void UpdateDelegate(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate value);
        void ResetActivity();
        void DispatchScrollStartNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context);
        void DispatchScrollUpdateNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context, double scrollDelta);
        void DispatchOverscrollNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context, double overscroll);
        void DispatchScrollEndNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context);
        void ApplyNewDimensions();
        void Dispose();
        string ToString();
        FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate @delegate { get; }
        bool ShouldIgnorePointer { get; }
        bool IsScrolling { get; }
        double Velocity { get; }
    }


    public interface IScrollActivityDelegate { }

    public class ScrollActivityDelegate
    {
        public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Update the scroll position to the given pixel value.
        ///
        /// Returns the overscroll, if any. See [ScrollPosition.setPixels] for more
        /// information.
        /// </Summary>
        public virtual double SetPixels(double pixels)
        {
            return default(double);
        }


        /// <Summary>
        /// Updates the scroll position by the given amount.
        ///
        /// Appropriate for when the user is directly manipulating the scroll
        /// position, for example by dragging the scroll view. Typically applies
        /// [ScrollPhysics.applyPhysicsToUserOffset] and other transformations that
        /// are appropriate for user-driving scrolling.
        /// </Summary>
        public virtual void ApplyUserOffset(double delta)
        {
        }


        /// <Summary>
        /// Terminate the current activity and start an idle activity.
        /// </Summary>
        public virtual void GoIdle()
        {
        }


        /// <Summary>
        /// Terminate the current activity and start a ballistic activity with the
        /// given velocity.
        /// </Summary>
        public virtual void GoBallistic(double velocity)
        {
        }

    }
    public static class ScrollActivityDelegateMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IScrollActivityDelegate, ScrollActivityDelegate> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IScrollActivityDelegate, ScrollActivityDelegate>();
        static ScrollActivityDelegate GetOrCreate(IScrollActivityDelegate instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ScrollActivityDelegate();
                _table.Add(instance, value);
            }
            return (ScrollActivityDelegate)value;
        }
        public static FlutterSDK.Painting.Basictypes.AxisDirection AxisDirectionProperty(this IScrollActivityDelegate instance) => GetOrCreate(instance).AxisDirection;
        public static double SetPixels(this IScrollActivityDelegate instance, double pixels) => GetOrCreate(instance).SetPixels(pixels);
        public static void ApplyUserOffset(this IScrollActivityDelegate instance, double delta) => GetOrCreate(instance).ApplyUserOffset(delta);
        public static void GoIdle(this IScrollActivityDelegate instance) => GetOrCreate(instance).GoIdle();
        public static void GoBallistic(this IScrollActivityDelegate instance, double velocity) => GetOrCreate(instance).GoBallistic(velocity);
    }


    public interface IScrollHoldController { }

    public class ScrollHoldController
    {

        /// <Summary>
        /// Release the [Scrollable], potentially letting it go ballistic if
        /// necessary.
        /// </Summary>
        public virtual void Cancel()
        {
        }

    }
    public static class ScrollHoldControllerMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IScrollHoldController, ScrollHoldController> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IScrollHoldController, ScrollHoldController>();
        static ScrollHoldController GetOrCreate(IScrollHoldController instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ScrollHoldController();
                _table.Add(instance, value);
            }
            return (ScrollHoldController)value;
        }
        public static void Cancel(this IScrollHoldController instance) => GetOrCreate(instance).Cancel();
    }


    /// <Summary>
    /// Base class for scrolling activities like dragging and flinging.
    ///
    /// See also:
    ///
    ///  * [ScrollPosition], which uses [ScrollActivity] objects to manage the
    ///    [ScrollPosition] of a [Scrollable].
    /// </Summary>
    public class ScrollActivity
    {
        public ScrollActivity(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate _delegate)
        {
            this._Delegate = _delegate;
        }
        internal virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate _Delegate { get; set; }
        public virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate @delegate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool ShouldIgnorePointer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Velocity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Updates the activity's link to the [ScrollActivityDelegate].
        ///
        /// This should only be called when an activity is being moved from a defunct
        /// (or about-to-be defunct) [ScrollActivityDelegate] object to a new one.
        /// </Summary>
        public virtual void UpdateDelegate(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate value)
        {

            _Delegate = value;
        }




        /// <Summary>
        /// Called by the [ScrollActivityDelegate] when it has changed type (for
        /// example, when changing from an Android-style scroll position to an
        /// iOS-style scroll position). If this activity can differ between the two
        /// modes, then it should tell the position to restart that activity
        /// appropriately.
        ///
        /// For example, [BallisticScrollActivity]'s implementation calls
        /// [ScrollActivityDelegate.goBallistic].
        /// </Summary>
        public virtual void ResetActivity()
        {
        }




        /// <Summary>
        /// Dispatch a [ScrollStartNotification] with the given metrics.
        /// </Summary>
        public virtual void DispatchScrollStartNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context)
        {
            new ScrollStartNotification(metrics: metrics, context: context).Dispatch(context);
        }




        /// <Summary>
        /// Dispatch a [ScrollUpdateNotification] with the given metrics and scroll delta.
        /// </Summary>
        public virtual void DispatchScrollUpdateNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context, double scrollDelta)
        {
            new ScrollUpdateNotification(metrics: metrics, context: context, scrollDelta: scrollDelta).Dispatch(context);
        }




        /// <Summary>
        /// Dispatch an [OverscrollNotification] with the given metrics and overscroll.
        /// </Summary>
        public virtual void DispatchOverscrollNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context, double overscroll)
        {
            new OverscrollNotification(metrics: metrics, context: context, overscroll: overscroll).Dispatch(context);
        }




        /// <Summary>
        /// Dispatch a [ScrollEndNotification] with the given metrics and overscroll.
        /// </Summary>
        public virtual void DispatchScrollEndNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context)
        {
            new ScrollEndNotification(metrics: metrics, context: context).Dispatch(context);
        }




        /// <Summary>
        /// Called when the scroll view that is performing this activity changes its metrics.
        /// </Summary>
        public virtual void ApplyNewDimensions()
        {
        }




        /// <Summary>
        /// Called when the scroll view stops performing this activity.
        /// </Summary>
        public virtual void Dispose()
        {
            _Delegate = null;
        }




    }


    /// <Summary>
    /// A scroll activity that does nothing.
    ///
    /// When a scroll view is not scrolling, it is performing the idle activity.
    ///
    /// If the [Scrollable] changes dimensions, this activity triggers a ballistic
    /// activity to restore the view.
    /// </Summary>
    public class IdleScrollActivity : FlutterSDK.Widgets.Scrollactivity.ScrollActivity
    {
        public IdleScrollActivity(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate @delegate)
        : base(@delegate)
        {

        }
        public virtual bool ShouldIgnorePointer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Velocity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void ApplyNewDimensions()
        {
            Delegate.GoBallistic(0.0);
        }



    }


    /// <Summary>
    /// A scroll activity that does nothing but can be released to resume
    /// normal idle behavior.
    ///
    /// This is used while the user is touching the [Scrollable] but before the
    /// touch has become a [Drag].
    ///
    /// For the purposes of [ScrollNotification]s, this activity does not constitute
    /// scrolling, and does not prevent the user from interacting with the contents
    /// of the [Scrollable] (unlike when a drag has begun or there is a scroll
    /// animation underway).
    /// </Summary>
    public class HoldScrollActivity : FlutterSDK.Widgets.Scrollactivity.ScrollActivity, IScrollHoldController
    {
        public HoldScrollActivity(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate @delegate = default(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate), VoidCallback onHoldCanceled = default(VoidCallback))
        : base(@delegate)
        {
            this.OnHoldCanceled = onHoldCanceled;
        }
        public virtual VoidCallback OnHoldCanceled { get; set; }
        public virtual bool ShouldIgnorePointer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Velocity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Cancel()
        {
            Delegate.GoBallistic(0.0);
        }




        public new void Dispose()
        {
            if (OnHoldCanceled != null) OnHoldCanceled();
            base.Dispose();
        }



    }


    /// <Summary>
    /// Scrolls a scroll view as the user drags their finger across the screen.
    ///
    /// See also:
    ///
    ///  * [DragScrollActivity], which is the activity the scroll view performs
    ///    while a drag is underway.
    /// </Summary>
    public class ScrollDragController : IDrag
    {
        public ScrollDragController(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate @delegate = default(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate), FlutterSDK.Gestures.Dragdetails.DragStartDetails details = default(FlutterSDK.Gestures.Dragdetails.DragStartDetails), VoidCallback onDragCanceled = default(VoidCallback), double carriedVelocity = default(double), double motionStartDistanceThreshold = default(double))
        : base()
        {
            this.OnDragCanceled = onDragCanceled;
            this.CarriedVelocity = carriedVelocity;
            this.MotionStartDistanceThreshold = motionStartDistanceThreshold;
        }
        internal virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate _Delegate { get; set; }
        public virtual VoidCallback OnDragCanceled { get; set; }
        public virtual double CarriedVelocity { get; set; }
        public virtual double MotionStartDistanceThreshold { get; set; }
        internal virtual TimeSpan _LastNonStationaryTimestamp { get; set; }
        internal virtual bool _RetainMomentum { get; set; }
        internal virtual double _OffsetSinceLastStop { get; set; }
        public virtual TimeSpan MomentumRetainStationaryDurationThreshold { get; set; }
        public virtual TimeSpan MotionStoppedDurationThreshold { get; set; }
        internal virtual double _BigThresholdBreakDistance { get; set; }
        internal virtual object _LastDetails { get; set; }
        public virtual FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate @delegate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _Reversed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual object LastDetails { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Updates the controller's link to the [ScrollActivityDelegate].
        ///
        /// This should only be called when a controller is being moved from a defunct
        /// (or about-to-be defunct) [ScrollActivityDelegate] object to a new one.
        /// </Summary>
        public virtual void UpdateDelegate(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate value)
        {

            _Delegate = value;
        }




        /// <Summary>
        /// Determines whether to lose the existing incoming velocity when starting
        /// the drag.
        /// </Summary>
        private void _MaybeLoseMomentum(double offset, TimeSpan timestamp)
        {
            if (_RetainMomentum && offset == 0.0 && (timestamp == null || timestamp - _LastNonStationaryTimestamp > MomentumRetainStationaryDurationThreshold))
            {
                _RetainMomentum = false;
            }

        }




        /// <Summary>
        /// If a motion start threshold exists, determine whether the threshold needs
        /// to be broken to scroll. Also possibly apply an offset adjustment when
        /// threshold is first broken.
        ///
        /// Returns `0.0` when stationary or within threshold. Returns `offset`
        /// transparently when already in motion.
        /// </Summary>
        private double _AdjustForScrollStartThreshold(double offset, TimeSpan timestamp)
        {
            if (timestamp == null)
            {
                return offset;
            }

            if (offset == 0.0)
            {
                if (MotionStartDistanceThreshold != null && _OffsetSinceLastStop == null && timestamp - _LastNonStationaryTimestamp > MotionStoppedDurationThreshold)
                {
                    _OffsetSinceLastStop = 0.0;
                }

                return 0.0;
            }
            else
            {
                if (_OffsetSinceLastStop == null)
                {
                    return offset;
                }
                else
                {
                    _OffsetSinceLastStop += offset;
                    if (_OffsetSinceLastStop.Abs() > MotionStartDistanceThreshold)
                    {
                        _OffsetSinceLastStop = null;
                        if (offset.Abs() > _BigThresholdBreakDistance)
                        {
                            return offset;
                        }
                        else
                        {
                            return Dart.Math.MathDefaultClass.Min(MotionStartDistanceThreshold / 3.0, offset.Abs()) * offset.Sign;
                        }

                    }
                    else
                    {
                        return 0.0;
                    }

                }

            }

        }




        public new void Update(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {

            _LastDetails = details;
            double offset = details.PrimaryDelta;
            if (offset != 0.0)
            {
                _LastNonStationaryTimestamp = details.SourceTimeStamp;
            }

            _MaybeLoseMomentum(offset, details.SourceTimeStamp);
            offset = _AdjustForScrollStartThreshold(offset, details.SourceTimeStamp);
            if (offset == 0.0)
            {
                return;
            }

            if (_Reversed) offset = -offset;
            Delegate.ApplyUserOffset(offset);
        }




        public new void End(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {

            double velocity = -details.PrimaryVelocity;
            if (_Reversed) velocity = -velocity;
            _LastDetails = details;
            if (_RetainMomentum && velocity.Sign == CarriedVelocity.Sign) velocity += CarriedVelocity;
            Delegate.GoBallistic(velocity);
        }




        public new void Cancel()
        {
            Delegate.GoBallistic(0.0);
        }




        /// <Summary>
        /// Called by the delegate when it is no longer sending events to this object.
        /// </Summary>
        public virtual void Dispose()
        {
            _LastDetails = null;
            if (OnDragCanceled != null) OnDragCanceled();
        }




    }


    /// <Summary>
    /// The activity a scroll view performs when a the user drags their finger
    /// across the screen.
    ///
    /// See also:
    ///
    ///  * [ScrollDragController], which listens to the [Drag] and actually scrolls
    ///    the scroll view.
    /// </Summary>
    public class DragScrollActivity : FlutterSDK.Widgets.Scrollactivity.ScrollActivity
    {
        public DragScrollActivity(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate @delegate, FlutterSDK.Widgets.Scrollactivity.ScrollDragController controller)
        : base(@delegate)
        {

        }
        internal virtual FlutterSDK.Widgets.Scrollactivity.ScrollDragController _Controller { get; set; }
        public virtual bool ShouldIgnorePointer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Velocity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void DispatchScrollStartNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context)
        {
            object lastDetails = _Controller.LastDetails;

            new ScrollStartNotification(metrics: metrics, context: context, dragDetails: lastDetails as DragStartDetails).Dispatch(context);
        }




        public new void DispatchScrollUpdateNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context, double scrollDelta)
        {
            object lastDetails = _Controller.LastDetails;

            new ScrollUpdateNotification(metrics: metrics, context: context, scrollDelta: scrollDelta, dragDetails: lastDetails as DragUpdateDetails).Dispatch(context);
        }




        public new void DispatchOverscrollNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context, double overscroll)
        {
            object lastDetails = _Controller.LastDetails;

            new OverscrollNotification(metrics: metrics, context: context, overscroll: overscroll, dragDetails: lastDetails as DragUpdateDetails).Dispatch(context);
        }




        public new void DispatchScrollEndNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context)
        {
            object lastDetails = _Controller.LastDetails;
            new ScrollEndNotification(metrics: metrics, context: context, dragDetails: lastDetails is DragEndDetails ? lastDetails : null).Dispatch(context);
        }




        public new void Dispose()
        {
            _Controller = null;
            base.Dispose();
        }




    }


    /// <Summary>
    /// An activity that animates a scroll view based on a physics [Simulation].
    ///
    /// A [BallisticScrollActivity] is typically used when the user lifts their
    /// finger off the screen to continue the scrolling gesture with the current velocity.
    ///
    /// [BallisticScrollActivity] is also used to restore a scroll view to a valid
    /// scroll offset when the geometry of the scroll view changes. In these
    /// situations, the [Simulation] typically starts with a zero velocity.
    ///
    /// See also:
    ///
    ///  * [DrivenScrollActivity], which animates a scroll view based on a set of
    ///    animation parameters.
    /// </Summary>
    public class BallisticScrollActivity : FlutterSDK.Widgets.Scrollactivity.ScrollActivity
    {
        public BallisticScrollActivity(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate @delegate, FlutterSDK.Physics.Simulation.Simulation simulation, FlutterSDK.Scheduler.Ticker.TickerProvider vsync)
        : base(@delegate)
        {

            _Controller = AnimationController.Unbounded(debugLabel: ConstantsDefaultClass.KDebugMode ? ObjectDefaultClass.ObjectRuntimeType(this, "BallisticScrollActivity") : null, vsync: vsync);
            AnimationController.Unbounded(debugLabel: ConstantsDefaultClass.KDebugMode ? ObjectDefaultClass.ObjectRuntimeType(this, "BallisticScrollActivity") : null, vsync: vsync).AddListener(_Tick);
            AnimationController.Unbounded(debugLabel: ConstantsDefaultClass.KDebugMode ? ObjectDefaultClass.ObjectRuntimeType(this, "BallisticScrollActivity") : null, vsync: vsync).AnimateWith(simulation).WhenComplete(_End);
        }


        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        public virtual double Velocity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool ShouldIgnorePointer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void ResetActivity()
        {
            Delegate.GoBallistic(Velocity);
        }




        public new void ApplyNewDimensions()
        {
            Delegate.GoBallistic(Velocity);
        }




        private void _Tick()
        {
            if (!ApplyMoveTo(_Controller.Value)) Delegate.GoIdle();
        }




        /// <Summary>
        /// Move the position to the given location.
        ///
        /// If the new position was fully applied, returns true. If there was any
        /// overflow, returns false.
        ///
        /// The default implementation calls [ScrollActivityDelegate.setPixels]
        /// and returns true if the overflow was zero.
        /// </Summary>
        public virtual bool ApplyMoveTo(double value)
        {
            return Delegate.SetPixels(value) == 0.0;
        }




        private void _End()
        {
            Delegate?.GoBallistic(0.0);
        }




        public new void DispatchOverscrollNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context, double overscroll)
        {
            new OverscrollNotification(metrics: metrics, context: context, overscroll: overscroll, velocity: Velocity).Dispatch(context);
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




    }


    /// <Summary>
    /// An activity that animates a scroll view based on animation parameters.
    ///
    /// For example, a [DrivenScrollActivity] is used to implement
    /// [ScrollController.animateTo].
    ///
    /// See also:
    ///
    ///  * [BallisticScrollActivity], which animates a scroll view based on a
    ///    physics [Simulation].
    /// </Summary>
    public class DrivenScrollActivity : FlutterSDK.Widgets.Scrollactivity.ScrollActivity
    {
        public DrivenScrollActivity(FlutterSDK.Widgets.Scrollactivity.ScrollActivityDelegate @delegate, double from = default(double), double to = default(double), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider))
        : base(@delegate)
        {

            _Completer = new Completer<void>();
            _Controller = AnimationController.Unbounded(value: from, debugLabel: ObjectDefaultClass.ObjectRuntimeType(this, "DrivenScrollActivity"), vsync: vsync);
            AnimationController.Unbounded(value: from, debugLabel: ObjectDefaultClass.ObjectRuntimeType(this, "DrivenScrollActivity"), vsync: vsync).AddListener(_Tick);
            AnimationController.Unbounded(value: from, debugLabel: ObjectDefaultClass.ObjectRuntimeType(this, "DrivenScrollActivity"), vsync: vsync).AnimateTo(to, duration: duration, curve: curve).WhenComplete(_End);
        }


        internal virtual Completer<object> _Completer { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        public virtual Future<object> Done { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Velocity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool ShouldIgnorePointer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _Tick()
        {
            if (Delegate.SetPixels(_Controller.Value) != 0.0) Delegate.GoIdle();
        }




        private void _End()
        {
            Delegate?.GoBallistic(Velocity);
        }




        public new void DispatchOverscrollNotification(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context, double overscroll)
        {
            new OverscrollNotification(metrics: metrics, context: context, overscroll: overscroll, velocity: Velocity).Dispatch(context);
        }




        public new void Dispose()
        {
            _Completer.Complete();
            _Controller.Dispose();
            base.Dispose();
        }




    }

}
