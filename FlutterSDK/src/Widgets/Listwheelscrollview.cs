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
namespace FlutterSDK.Widgets.Listwheelscrollview
{
    internal static class ListwheelscrollviewDefaultClass
    {
        internal static int _GetItemFromOffset(double offset = default(double), double itemExtent = default(double), double minScrollExtent = default(double), double maxScrollExtent = default(double))
        {
            return (ListwheelscrollviewDefaultClass._ClipOffsetToScrollableRange(offset, minScrollExtent, maxScrollExtent) / itemExtent).Round();
        }



        internal static double _ClipOffsetToScrollableRange(double offset, double minScrollExtent, double maxScrollExtent)
        {
            return Dart.Math.MathDefaultClass.Min(Dart.Math.MathDefaultClass.Max(offset, minScrollExtent), maxScrollExtent);
        }



    }

    /// <Summary>
    /// Metrics for a [ScrollPosition] to a scroll view with fixed item sizes.
    ///
    /// The metrics are available on [ScrollNotification]s generated from a scroll
    /// views such as [ListWheelScrollView]s with a [FixedExtentScrollController] and
    /// exposes the current [itemIndex] and the scroll view's [itemExtent].
    ///
    /// `FixedExtent` refers to the fact that the scrollable items have the same size.
    /// This is distinct from `Fixed` in the parent class name's [FixedScrollMetric]
    /// which refers to its immutability.
    /// </Summary>
    public interface IFixedExtentMetrics
    {
        FlutterSDK.Widgets.Listwheelscrollview.FixedExtentMetrics CopyWith(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), int itemIndex = default(int));
        int ItemIndex { get; }
    }


    public interface IListWheelChildDelegate { }

    public class ListWheelChildDelegate
    {
        public virtual int EstimatedChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Return the child at the given index. If the child at the given
        /// index does not exist, return null.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index)
        {
            return default(Widget);
        }


        /// <Summary>
        /// Returns the true index for a child built at a given index. Defaults to
        /// the given index, however if the delegate is [ListWheelChildLoopingListDelegate],
        /// this value is the index of the true element that the delegate is looping to.
        ///
        ///
        /// Example: [ListWheelChildLoopingListDelegate] is built by looping a list of
        /// length 8. Then, trueIndexOf(10) = 2 and trueIndexOf(-5) = 3.
        /// </Summary>
        public virtual int TrueIndexOf(int index) => index;



        /// <Summary>
        /// Called to check whether this and the old delegate are actually 'different',
        /// so that the caller can decide to rebuild or not.
        /// </Summary>
        public virtual bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate oldDelegate)
        {
            return default(bool);
        }

    }
    public static class ListWheelChildDelegateMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IListWheelChildDelegate, ListWheelChildDelegate> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IListWheelChildDelegate, ListWheelChildDelegate>();
        static ListWheelChildDelegate GetOrCreate(IListWheelChildDelegate instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ListWheelChildDelegate();
                _table.Add(instance, value);
            }
            return (ListWheelChildDelegate)value;
        }
        public static int EstimatedChildCountProperty(this IListWheelChildDelegate instance) => GetOrCreate(instance).EstimatedChildCount;
        public static FlutterSDK.Widgets.Framework.Widget Build(this IListWheelChildDelegate instance, FlutterSDK.Widgets.Framework.BuildContext context, int index) => GetOrCreate(instance).Build(context, index);
        public static int TrueIndexOf(this IListWheelChildDelegate instance, int index) => GetOrCreate(instance).TrueIndexOf(index);
        public static bool ShouldRebuild(this IListWheelChildDelegate instance, FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate oldDelegate) => GetOrCreate(instance).ShouldRebuild(oldDelegate);
    }


    /// <Summary>
    /// A delegate that supplies children for [ListWheelScrollView] using an
    /// explicit list.
    ///
    /// [ListWheelScrollView] lazily constructs its children to avoid creating more
    /// children than are visible through the [Viewport]. This delegate provides
    /// children using an explicit list, which is convenient but reduces the benefit
    /// of building children lazily.
    ///
    /// In general building all the widgets in advance is not efficient. It is
    /// better to create a delegate that builds them on demand using
    /// [ListWheelChildBuilderDelegate] or by subclassing [ListWheelChildDelegate]
    /// directly.
    ///
    /// This class is provided for the cases where either the list of children is
    /// known well in advance (ideally the children are themselves compile-time
    /// constants, for example), and therefore will not be built each time the
    /// delegate itself is created, or the list is small, such that it's likely
    /// always visible (and thus there is nothing to be gained by building it on
    /// demand). For example, the body of a dialog box might fit both of these
    /// conditions.
    /// </Summary>
    public class ListWheelChildListDelegate : FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate
    {
        /// <Summary>
        /// Constructs the delegate from a concrete list of children.
        /// </Summary>
        public ListWheelChildListDelegate(List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base()
        {
            this.Children = children;
        }
        /// <Summary>
        /// The list containing all children that can be supplied.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        public virtual int EstimatedChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index)
        {
            if (index < 0 || index >= Children.Count) return null;
            return new IndexedSemantics(child: Children[index], index: index);
        }




        public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildListDelegate oldDelegate)
        {
            return Children != oldDelegate.Children;
        }


        public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate oldDelegate)
        {
            return Children != oldDelegate.Children;
        }



    }


    /// <Summary>
    /// A delegate that supplies infinite children for [ListWheelScrollView] by
    /// looping an explicit list.
    ///
    /// [ListWheelScrollView] lazily constructs its children to avoid creating more
    /// children than are visible through the [Viewport]. This delegate provides
    /// children using an explicit list, which is convenient but reduces the benefit
    /// of building children lazily.
    ///
    /// In general building all the widgets in advance is not efficient. It is
    /// better to create a delegate that builds them on demand using
    /// [ListWheelChildBuilderDelegate] or by subclassing [ListWheelChildDelegate]
    /// directly.
    ///
    /// This class is provided for the cases where either the list of children is
    /// known well in advance (ideally the children are themselves compile-time
    /// constants, for example), and therefore will not be built each time the
    /// delegate itself is created, or the list is small, such that it's likely
    /// always visible (and thus there is nothing to be gained by building it on
    /// demand). For example, the body of a dialog box might fit both of these
    /// conditions.
    /// </Summary>
    public class ListWheelChildLoopingListDelegate : FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate
    {
        /// <Summary>
        /// Constructs the delegate from a concrete list of children.
        /// </Summary>
        public ListWheelChildLoopingListDelegate(List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base()
        {
            this.Children = children;
        }
        /// <Summary>
        /// The list containing all children that can be supplied.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        public virtual int EstimatedChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new int TrueIndexOf(int index) => index % Children.Count;



        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index)
        {
            if (Children.IsEmpty()) return null;
            return new IndexedSemantics(child: Children[index % Children.Count], index: index);
        }




        public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildLoopingListDelegate oldDelegate)
        {
            return Children != oldDelegate.Children;
        }


        public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate oldDelegate)
        {
            return Children != oldDelegate.Children;
        }



    }


    /// <Summary>
    /// A delegate that supplies children for [ListWheelScrollView] using a builder
    /// callback.
    ///
    /// [ListWheelScrollView] lazily constructs its children to avoid creating more
    /// children than are visible through the [Viewport]. This delegate provides
    /// children using an [IndexedWidgetBuilder] callback, so that the children do
    /// not have to be built until they are displayed.
    /// </Summary>
    public class ListWheelChildBuilderDelegate : FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate
    {
        /// <Summary>
        /// Constructs the delegate from a builder callback.
        /// </Summary>
        public ListWheelChildBuilderDelegate(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder builder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder), int childCount = default(int))
        : base()
        {
            this.Builder = builder;
            this.ChildCount = childCount;
        }
        /// <Summary>
        /// Called lazily to build children.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.IndexedWidgetBuilder Builder { get; set; }
        /// <Summary>
        /// {@template flutter.widgets.wheelList.childCount}
        /// If non-null, [childCount] is the maximum number of children that can be
        /// provided, and children are available from 0 to [childCount] - 1.
        ///
        /// If null, then the lower and upper limit are not known. However the [builder]
        /// must provide children for a contiguous segment. If the builder returns null
        /// at some index, the segment terminates there.
        /// {@endtemplate}
        /// </Summary>
        public virtual int ChildCount { get; set; }
        public virtual int EstimatedChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, int index)
        {
            if (ChildCount == null)
            {
                Widget child = Builder(context, index);
                return child == null ? null : new IndexedSemantics(child: child, index: index);
            }

            if (index < 0 || index >= ChildCount) return null;
            return new IndexedSemantics(child: Builder(context, index), index: index);
        }




        public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildBuilderDelegate oldDelegate)
        {
            return Builder != oldDelegate.Builder || ChildCount != oldDelegate.ChildCount;
        }


        public new bool ShouldRebuild(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate oldDelegate)
        {
            return Builder != oldDelegate.Builder || ChildCount != oldDelegate.ChildCount;
        }



    }


    /// <Summary>
    /// A controller for scroll views whose items have the same size.
    ///
    /// Similar to a standard [ScrollController] but with the added convenience
    /// mechanisms to read and go to item indices rather than a raw pixel scroll
    /// offset.
    ///
    /// See also:
    ///
    ///  * [ListWheelScrollView], a scrollable view widget with fixed size items
    ///    that this widget controls.
    ///  * [FixedExtentMetrics], the `metrics` property exposed by
    ///    [ScrollNotification] from [ListWheelScrollView] which can be used
    ///    to listen to the current item index on a push basis rather than polling
    ///    the [FixedExtentScrollController].
    /// </Summary>
    public class FixedExtentScrollController : FlutterSDK.Widgets.Scrollcontroller.ScrollController
    {
        /// <Summary>
        /// Creates a scroll controller for scrollables whose items have the same size.
        ///
        /// [initialItem] defaults to 0 and must not be null.
        /// </Summary>
        public FixedExtentScrollController(int initialItem = 0)
        : base()
        {
            this.InitialItem = initialItem;
        }
        /// <Summary>
        /// The page to show when first creating the scroll view.
        ///
        /// Defaults to 0 and must not be null.
        /// </Summary>
        public virtual int InitialItem { get; set; }
        public virtual int SelectedItem { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Animates the controlled scroll view to the given item index.
        ///
        /// The animation lasts for the given duration and follows the given curve.
        /// The returned [Future] resolves when the animation completes.
        ///
        /// The `duration` and `curve` arguments must not be null.
        /// </Summary>
        public virtual async Future<object> AnimateToItem(int itemIndex, TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {
            if (!HasClients)
            {
                return;
            }

            await Dart.AsyncDefaultClass.Future.Wait(new List<Future<void>>() { });
        }




        /// <Summary>
        /// Changes which item index is centered in the controlled scroll view.
        ///
        /// Jumps the item index position from its current value to the given value,
        /// without animation, and without checking if the new value is in range.
        /// </Summary>
        public virtual void JumpToItem(int itemIndex)
        {
            foreach (_FixedExtentScrollPosition position in Positions.Cast())
            {
                position.JumpTo(itemIndex * position.ItemExtent);
            }

        }




        public new FlutterSDK.Widgets.Scrollposition.ScrollPosition CreateScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics, FlutterSDK.Widgets.Scrollcontext.ScrollContext context, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition)
        {
            return new _FixedExtentScrollPosition(physics: physics, context: context, initialItem: InitialItem, oldPosition: oldPosition);
        }



    }


    /// <Summary>
    /// Metrics for a [ScrollPosition] to a scroll view with fixed item sizes.
    ///
    /// The metrics are available on [ScrollNotification]s generated from a scroll
    /// views such as [ListWheelScrollView]s with a [FixedExtentScrollController] and
    /// exposes the current [itemIndex] and the scroll view's [itemExtent].
    ///
    /// `FixedExtent` refers to the fact that the scrollable items have the same size.
    /// This is distinct from `Fixed` in the parent class name's [FixedScrollMetric]
    /// which refers to its immutability.
    /// </Summary>
    public class FixedExtentMetrics : FlutterSDK.Widgets.Scrollmetrics.FixedScrollMetrics
    {
        /// <Summary>
        /// Creates an immutable snapshot of values associated with a
        /// [ListWheelScrollView].
        /// </Summary>
        public FixedExtentMetrics(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), int itemIndex = default(int))
        : base(minScrollExtent: minScrollExtent, maxScrollExtent: maxScrollExtent, pixels: pixels, viewportDimension: viewportDimension, axisDirection: axisDirection)
        {
            this.ItemIndex = itemIndex;
        }
        /// <Summary>
        /// The scroll view's currently selected item index.
        /// </Summary>
        public virtual int ItemIndex { get; set; }

        public new FlutterSDK.Widgets.Listwheelscrollview.FixedExtentMetrics CopyWith(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), int itemIndex = default(int))
        {
            return new FixedExtentMetrics(minScrollExtent: minScrollExtent == default(double) ? this.minScrollExtent : minScrollExtent, maxScrollExtent: maxScrollExtent == default(double) ? this.maxScrollExtent : maxScrollExtent, pixels: pixels == default(double) ? this.pixels : pixels, viewportDimension: viewportDimension == default(double) ? this.viewportDimension : viewportDimension, axisDirection: axisDirection ?? this.AxisDirection, itemIndex: itemIndex ?? this.ItemIndex);
        }



    }


    /// <Summary>
    /// A [ScrollPositionWithSingleContext] that can only be created based on
    /// [_FixedExtentScrollable] and can access its `itemExtent` to derive [itemIndex].
    /// </Summary>
    public class _FixedExtentScrollPosition : FlutterSDK.Widgets.Scrollpositionwithsinglecontext.ScrollPositionWithSingleContext, IFixedExtentMetrics
    {
        public _FixedExtentScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontext.ScrollContext context = default(FlutterSDK.Widgets.Scrollcontext.ScrollContext), int initialItem = default(int), bool keepScrollOffset = true, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition), string debugLabel = default(string))
        : base(physics: physics, context: context, initialPixels: _GetItemExtentFromScrollContext(context) * initialItem, keepScrollOffset: keepScrollOffset, oldPosition: oldPosition, debugLabel: debugLabel)
        {

        }
        public virtual double ItemExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int ItemIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private double _GetItemExtentFromScrollContext(FlutterSDK.Widgets.Scrollcontext.ScrollContext context)
        {
            _FixedExtentScrollableState scrollable = context as _FixedExtentScrollableState;
            return scrollable.ItemExtent;
        }




        public new FlutterSDK.Widgets.Listwheelscrollview.FixedExtentMetrics CopyWith(double minScrollExtent = default(double), double maxScrollExtent = default(double), double pixels = default(double), double viewportDimension = default(double), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), int itemIndex = default(int))
        {
            return new FixedExtentMetrics(minScrollExtent: minScrollExtent == default(double) ? this.minScrollExtent : minScrollExtent, maxScrollExtent: maxScrollExtent == default(double) ? this.maxScrollExtent : maxScrollExtent, pixels: pixels == default(double) ? this.pixels : pixels, viewportDimension: viewportDimension == default(double) ? this.viewportDimension : viewportDimension, axisDirection: axisDirection ?? this.AxisDirection, itemIndex: itemIndex ?? this.ItemIndex);
        }



    }


    /// <Summary>
    /// A [Scrollable] which must be given its viewport children's item extent
    /// size so it can pass it on ultimately to the [FixedExtentScrollController].
    /// </Summary>
    public class _FixedExtentScrollable : FlutterSDK.Widgets.Scrollable.Scrollable
    {
        public _FixedExtentScrollable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), double itemExtent = default(double), FlutterSDK.Widgets.Scrollable.ViewportBuilder viewportBuilder = default(FlutterSDK.Widgets.Scrollable.ViewportBuilder))
        : base(key: key, axisDirection: axisDirection, controller: controller, physics: physics, viewportBuilder: viewportBuilder)
        {
            this.ItemExtent = itemExtent;
        }
        public virtual double ItemExtent { get; set; }

        public new FlutterSDK.Widgets.Listwheelscrollview._FixedExtentScrollableState CreateState() => new _FixedExtentScrollableState();


    }


    /// <Summary>
    /// This [ScrollContext] is used by [_FixedExtentScrollPosition] to read the
    /// prescribed [itemExtent].
    /// </Summary>
    public class _FixedExtentScrollableState : FlutterSDK.Widgets.Scrollable.ScrollableState
    {
        public _FixedExtentScrollableState()
        { }
        public virtual double ItemExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }


    /// <Summary>
    /// A snapping physics that always lands directly on items instead of anywhere
    /// within the scroll extent.
    ///
    /// Behaves similarly to a slot machine wheel except the ballistics simulation
    /// never overshoots and rolls back within a single item if it's to settle on
    /// that item.
    ///
    /// Must be used with a scrollable that uses a [FixedExtentScrollController].
    ///
    /// Defers back to the parent beyond the scroll extents.
    /// </Summary>
    public class FixedExtentScrollPhysics : FlutterSDK.Widgets.Scrollphysics.ScrollPhysics
    {
        /// <Summary>
        /// Creates a scroll physics that always lands on items.
        /// </Summary>
        public FixedExtentScrollPhysics(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics parent = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
        : base(parent: parent)
        {

        }

        public new FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollPhysics ApplyTo(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ancestor)
        {
            return new FixedExtentScrollPhysics(parent: BuildParent(ancestor));
        }




        public new FlutterSDK.Physics.Simulation.Simulation CreateBallisticSimulation(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double velocity)
        {

            _FixedExtentScrollPosition metrics = position as _FixedExtentScrollPosition;
            if ((velocity <= 0.0 && metrics.Pixels <= metrics.MinScrollExtent) || (velocity >= 0.0 && metrics.Pixels >= metrics.MaxScrollExtent))
            {
                return base.CreateBallisticSimulation(metrics, velocity);
            }

            Simulation testFrictionSimulation = base.CreateBallisticSimulation(metrics, velocity);
            if (testFrictionSimulation != null && (testFrictionSimulation.x(Dart.CoreDefaultClass.Double.Infinity) == metrics.MinScrollExtent || testFrictionSimulation.x(Dart.CoreDefaultClass.Double.Infinity) == metrics.MaxScrollExtent))
            {
                return base.CreateBallisticSimulation(metrics, velocity);
            }

            int settlingItemIndex = ListwheelscrollviewDefaultClass._GetItemFromOffset(offset: testFrictionSimulation?.x(Dart.CoreDefaultClass.Double.Infinity) ?? metrics.Pixels, itemExtent: metrics.ItemExtent, minScrollExtent: metrics.MinScrollExtent, maxScrollExtent: metrics.MaxScrollExtent);
            double settlingPixels = settlingItemIndex * metrics.ItemExtent;
            if (velocity.Abs() < Tolerance.Velocity && (settlingPixels - metrics.Pixels).Abs() < Tolerance.Distance)
            {
                return null;
            }

            if (settlingItemIndex == metrics.ItemIndex)
            {
                return new SpringSimulation(Spring, metrics.Pixels, settlingPixels, velocity, tolerance: Tolerance);
            }

            return FrictionSimulation.Through(metrics.Pixels, settlingPixels, velocity, Tolerance.Velocity * velocity.Sign);
        }



    }


    /// <Summary>
    /// A box in which children on a wheel can be scrolled.
    ///
    /// This widget is similar to a [ListView] but with the restriction that all
    /// children must be the same size along the scrolling axis.
    ///
    /// When the list is at the zero scroll offset, the first child is aligned with
    /// the middle of the viewport. When the list is at the final scroll offset,
    /// the last child is aligned with the middle of the viewport
    ///
    /// The children are rendered as if rotating on a wheel instead of scrolling on
    /// a plane.
    /// </Summary>
    public class ListWheelScrollView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Constructs a list in which children are scrolled a wheel. Its children
        /// are passed to a delegate and lazily built during layout.
        /// </Summary>
        public ListWheelScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), double diameterRatio = default(double), double perspective = default(double), double offAxisFraction = 0.0, bool useMagnifier = false, double magnification = 1.0, double overAndUnderCenterOpacity = 1.0, double itemExtent = default(double), double squeeze = 1.0, FlutterSDK.Foundation.Basictypes.ValueChanged<int> onSelectedItemChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), bool clipToSize = true, bool renderChildrenOutsideViewport = false, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key)
        {
            this.Controller = controller;
            this.Physics = physics;
            this.DiameterRatio = diameterRatio;
            this.Perspective = perspective;
            this.OffAxisFraction = offAxisFraction;
            this.UseMagnifier = useMagnifier;
            this.Magnification = magnification;
            this.OverAndUnderCenterOpacity = overAndUnderCenterOpacity;
            this.ItemExtent = itemExtent;
            this.Squeeze = squeeze;
            this.OnSelectedItemChanged = onSelectedItemChanged;
            this.ClipToSize = clipToSize;
            this.RenderChildrenOutsideViewport = renderChildrenOutsideViewport;
        }
        /// <Summary>
        /// Constructs a list in which children are scrolled a wheel. Its children
        /// are managed by a delegate and are lazily built during layout.
        /// </Summary>
        public static ListWheelScrollView UseDelegate(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), double diameterRatio = default(double), double perspective = default(double), double offAxisFraction = 0.0, bool useMagnifier = false, double magnification = 1.0, double overAndUnderCenterOpacity = 1.0, double itemExtent = default(double), double squeeze = 1.0, FlutterSDK.Foundation.Basictypes.ValueChanged<int> onSelectedItemChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), bool clipToSize = true, bool renderChildrenOutsideViewport = false, FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate childDelegate = default(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate))
        {
            var instance = new ListWheelScrollView(key: key); instance.Controller = controller;
            instance.Physics = physics;
            instance.DiameterRatio = diameterRatio;
            instance.Perspective = perspective;
            instance.OffAxisFraction = offAxisFraction;
            instance.UseMagnifier = useMagnifier;
            instance.Magnification = magnification;
            instance.OverAndUnderCenterOpacity = overAndUnderCenterOpacity;
            instance.ItemExtent = itemExtent;
            instance.Squeeze = squeeze;
            instance.OnSelectedItemChanged = onSelectedItemChanged;
            instance.ClipToSize = clipToSize;
            instance.RenderChildrenOutsideViewport = renderChildrenOutsideViewport;
            instance.ChildDelegate = childDelegate;
        }
        /// <Summary>
        /// Typically a [FixedExtentScrollController] used to control the current item.
        ///
        /// A [FixedExtentScrollController] can be used to read the currently
        /// selected/centered child item and can be used to change the current item.
        ///
        /// If none is provided, a new [FixedExtentScrollController] is implicitly
        /// created.
        ///
        /// If a [ScrollController] is used instead of [FixedExtentScrollController],
        /// [ScrollNotification.metrics] will no longer provide [FixedExtentMetrics]
        /// to indicate the current item index and [onSelectedItemChanged] will not
        /// work.
        ///
        /// To read the current selected item only when the value changes, use
        /// [onSelectedItemChanged].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller { get; set; }
        /// <Summary>
        /// How the scroll view should respond to user input.
        ///
        /// For example, determines how the scroll view continues to animate after the
        /// user stops dragging the scroll view.
        ///
        /// Defaults to matching platform conventions.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.diameterRatio}
        /// </Summary>
        public virtual double DiameterRatio { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.perspective}
        /// </Summary>
        public virtual double Perspective { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.offAxisFraction}
        /// </Summary>
        public virtual double OffAxisFraction { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.useMagnifier}
        /// </Summary>
        public virtual bool UseMagnifier { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.magnification}
        /// </Summary>
        public virtual double Magnification { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.overAndUnderCenterOpacity}
        /// </Summary>
        public virtual double OverAndUnderCenterOpacity { get; set; }
        /// <Summary>
        /// Size of each child in the main axis. Must not be null and must be
        /// positive.
        /// </Summary>
        public virtual double ItemExtent { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.squeeze}
        ///
        /// Defaults to 1.
        /// </Summary>
        public virtual double Squeeze { get; set; }
        /// <Summary>
        /// On optional listener that's called when the centered item changes.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnSelectedItemChanged { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.clipToSize}
        /// </Summary>
        public virtual bool ClipToSize { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.renderChildrenOutsideViewport}
        /// </Summary>
        public virtual bool RenderChildrenOutsideViewport { get; set; }
        /// <Summary>
        /// A delegate that helps lazily instantiating child.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate ChildDelegate { get; set; }

        public new FlutterSDK.Widgets.Listwheelscrollview._ListWheelScrollViewState CreateState() => new _ListWheelScrollViewState();


    }


    public class _ListWheelScrollViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Listwheelscrollview.ListWheelScrollView>
    {
        public _ListWheelScrollViewState()
        { }
        internal virtual int _LastReportedItemIndex { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }

        public new void InitState()
        {
            base.InitState();
            ScrollController = Widget.Controller ?? new FixedExtentScrollController();
            if (Widget.Controller is FixedExtentScrollController)
            {
                FixedExtentScrollController controller = ((FixedExtentScrollController)Widget.Controller) as FixedExtentScrollController;
                _LastReportedItemIndex = controller.InitialItem;
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Listwheelscrollview.ListWheelScrollView oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Controller != null && Widget.Controller != ScrollController)
            {
                ScrollController oldScrollController = ScrollController;
                BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((_) =>
                {
                    oldScrollController.Dispose();
                }
                );
                ScrollController = Widget.Controller;
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new NotificationListener<ScrollNotification>(onNotification: (ScrollNotification notification) =>
            {
                if (notification.Depth == 0 && Widget.OnSelectedItemChanged != null && notification is ScrollUpdateNotification && notification.Metrics is FixedExtentMetrics)
                {
                    FixedExtentMetrics metrics = ((FixedExtentMetrics)notification.Metrics) as FixedExtentMetrics;
                    int currentItemIndex = metrics.ItemIndex;
                    if (currentItemIndex != _LastReportedItemIndex)
                    {
                        _LastReportedItemIndex = currentItemIndex;
                        int trueIndex = Widget.ChildDelegate.TrueIndexOf(currentItemIndex);
                        Widget.OnSelectedItemChanged(trueIndex);
                    }

                }

                return false;
            }
            , child: new _FixedExtentScrollable(controller: ScrollController, physics: Widget.Physics, itemExtent: Widget.ItemExtent, viewportBuilder: (BuildContext context, ViewportOffset offset) =>
            {
                return new ListWheelViewport(diameterRatio: Widget.DiameterRatio, perspective: Widget.Perspective, offAxisFraction: Widget.OffAxisFraction, useMagnifier: Widget.UseMagnifier, magnification: Widget.Magnification, overAndUnderCenterOpacity: Widget.OverAndUnderCenterOpacity, itemExtent: Widget.ItemExtent, squeeze: Widget.Squeeze, clipToSize: Widget.ClipToSize, renderChildrenOutsideViewport: Widget.RenderChildrenOutsideViewport, offset: offset, childDelegate: Widget.ChildDelegate);
            }
            ));
        }



    }


    /// <Summary>
    /// Element that supports building children lazily for [ListWheelViewport].
    /// </Summary>
    public class ListWheelElement : FlutterSDK.Widgets.Framework.RenderObjectElement, IListWheelChildManager
    {
        /// <Summary>
        /// Creates an element that lazily builds children for the given widget.
        /// </Summary>
        public ListWheelElement(FlutterSDK.Widgets.Listwheelscrollview.ListWheelViewport widget)
        : base(widget)
        {

        }
        /// <Summary>
        /// A cache of widgets so that we don't have to rebuild every time.
        /// </Summary>
        internal virtual Dictionary<int, FlutterSDK.Widgets.Framework.Widget> _ChildWidgets { get; set; }
        /// <Summary>
        /// The map containing all active child elements. SplayTreeMap is used so that
        /// we have all elements ordered and iterable by their keys.
        /// </Summary>
        internal virtual SplayTreeMap<int, FlutterSDK.Widgets.Framework.Element> _ChildElements { get; set; }
        public virtual FlutterSDK.Widgets.Listwheelscrollview.ListWheelViewport Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Listwheelviewport.RenderListWheelViewport RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int ChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Update(FlutterSDK.Widgets.Listwheelscrollview.ListWheelViewport newWidget)
        {
            ListWheelViewport oldWidget = Widget;
            base.Update(newWidget);
            ListWheelChildDelegate newDelegate = newWidget.ChildDelegate;
            ListWheelChildDelegate oldDelegate = oldWidget.ChildDelegate;
            if (newDelegate != oldDelegate && (newDelegate.GetType() != oldDelegate.GetType() || newDelegate.ShouldRebuild(oldDelegate))) PerformRebuild();
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            ListWheelViewport oldWidget = Widget;
            base.Update(newWidget);
            ListWheelChildDelegate newDelegate = newWidget.ChildDelegate;
            ListWheelChildDelegate oldDelegate = oldWidget.ChildDelegate;
            if (newDelegate != oldDelegate && (newDelegate.GetType() != oldDelegate.GetType() || newDelegate.ShouldRebuild(oldDelegate))) PerformRebuild();
        }




        public new void PerformRebuild()
        {
            _ChildWidgets.Clear();
            base.PerformRebuild();
            if (_ChildElements.IsEmpty()) return;
            int firstIndex = _ChildElements.FirstKey();
            int lastIndex = _ChildElements.LastKey();
            for (int index = firstIndex; index <= lastIndex; ++index)
            {
                Element newChild = UpdateChild(_ChildElements[index], RetrieveWidget(index), index);
                if (newChild != null)
                {
                    _ChildElements[index] = newChild;
                }
                else
                {
                    _ChildElements.Remove(index);
                }

            }

        }




        /// <Summary>
        /// Asks the underlying delegate for a widget at the given index.
        ///
        /// Normally the builder is only called once for each index and the result
        /// will be cached. However when the element is rebuilt, the cache will be
        /// cleared.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget RetrieveWidget(int index)
        {
            return _ChildWidgets.PutIfAbsent(index, () => =>Widget.ChildDelegate.Build(this, index));
        }




        public new bool ChildExistsAt(int index) => RetrieveWidget(index) != null;



        public new void CreateChild(int index, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox))
        {
            Owner.BuildScope(this, () =>
            {
                bool insertFirst = after == null;

                Element newChild = UpdateChild(_ChildElements[index], RetrieveWidget(index), index);
                if (newChild != null)
                {
                    _ChildElements[index] = newChild;
                }
                else
                {
                    _ChildElements.Remove(index);
                }

            }
            );
        }




        public new void RemoveChild(FlutterSDK.Rendering.Box.RenderBox child)
        {
            int index = RenderObject.IndexOf(child);
            Owner.BuildScope(this, () =>
            {

                Element result = UpdateChild(_ChildElements[index], null, index);

                _ChildElements.Remove(index);

            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Element UpdateChild(FlutterSDK.Widgets.Framework.Element child, FlutterSDK.Widgets.Framework.Widget newWidget, object newSlot)
        {
            ListWheelParentData oldParentData = child?.RenderObject?.ParentData as ListWheelParentData;
            Element newChild = base.UpdateChild(child, newWidget, newSlot);
            ListWheelParentData newParentData = newChild?.RenderObject?.ParentData as ListWheelParentData;
            if (newParentData != null)
            {
                newParentData.Index = newSlot as int;
                if (oldParentData != null) newParentData.Offset = oldParentData.Offset;
            }

            return newChild;
        }




        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, int slot)
        {
            RenderListWheelViewport renderObject = this.RenderObject;

            renderObject.Insert(child as RenderBox, after: _ChildElements[slot - 1]?.RenderObject as RenderBox);

        }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
            RenderListWheelViewport renderObject = this.RenderObject;

            renderObject.Insert(child as RenderBox, after: _ChildElements[slot - 1]?.RenderObject as RenderBox);

        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {
            string moveChildRenderObjectErrorMessage = "Currently we maintain the list in contiguous increasing order, so " + "moving children around is not allowed.";

        }




        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {

            RenderObject.Remove(child as RenderBox);
        }




        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            _ChildElements.ForEach((int key, Element child) =>
            {
                visitor(child);
            }
            );
        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {
            _ChildElements.Remove(child.Slot);
            base.ForgetChild(child);
        }



    }


    /// <Summary>
    /// A viewport showing a subset of children on a wheel.
    ///
    /// Typically used with [ListWheelScrollView], this viewport is similar to
    /// [Viewport] in that it shows a subset of children in a scrollable based
    /// on the scrolling offset and the children's dimensions. But uses
    /// [RenderListWheelViewport] to display the children on a wheel.
    ///
    /// See also:
    ///
    ///  * [ListWheelScrollView], widget that combines this viewport with a scrollable.
    ///  * [RenderListWheelViewport], the render object that renders the children
    ///    on a wheel.
    /// </Summary>
    public class ListWheelViewport : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        /// <Summary>
        /// Creates a viewport where children are rendered onto a wheel.
        ///
        /// The [diameterRatio] argument defaults to 2.0 and must not be null.
        ///
        /// The [perspective] argument defaults to 0.003 and must not be null.
        ///
        /// The [itemExtent] argument in pixels must be provided and must be positive.
        ///
        /// The [clipToSize] argument defaults to true and must not be null.
        ///
        /// The [renderChildrenOutsideViewport] argument defaults to false and must
        /// not be null.
        ///
        /// The [offset] argument must be provided and must not be null.
        /// </Summary>
        public ListWheelViewport(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double diameterRatio = default(double), double perspective = default(double), double offAxisFraction = 0.0, bool useMagnifier = false, double magnification = 1.0, double overAndUnderCenterOpacity = 1.0, double itemExtent = default(double), double squeeze = 1.0, bool clipToSize = true, bool renderChildrenOutsideViewport = false, FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate childDelegate = default(FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate))
        : base(key: key)
        {
            this.DiameterRatio = diameterRatio;
            this.Perspective = perspective;
            this.OffAxisFraction = offAxisFraction;
            this.UseMagnifier = useMagnifier;
            this.Magnification = magnification;
            this.OverAndUnderCenterOpacity = overAndUnderCenterOpacity;
            this.ItemExtent = itemExtent;
            this.Squeeze = squeeze;
            this.ClipToSize = clipToSize;
            this.RenderChildrenOutsideViewport = renderChildrenOutsideViewport;
            this.Offset = offset;
            this.ChildDelegate = childDelegate;
        }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.diameterRatio}
        /// </Summary>
        public virtual double DiameterRatio { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.perspective}
        /// </Summary>
        public virtual double Perspective { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.offAxisFraction}
        /// </Summary>
        public virtual double OffAxisFraction { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.useMagnifier}
        /// </Summary>
        public virtual bool UseMagnifier { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.magnification}
        /// </Summary>
        public virtual double Magnification { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.overAndUnderCenterOpacity}
        /// </Summary>
        public virtual double OverAndUnderCenterOpacity { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.itemExtent}
        /// </Summary>
        public virtual double ItemExtent { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.squeeze}
        ///
        /// Defaults to 1.
        /// </Summary>
        public virtual double Squeeze { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.clipToSize}
        /// </Summary>
        public virtual bool ClipToSize { get; set; }
        /// <Summary>
        /// {@macro flutter.rendering.wheelList.renderChildrenOutsideViewport}
        /// </Summary>
        public virtual bool RenderChildrenOutsideViewport { get; set; }
        /// <Summary>
        /// [ViewportOffset] object describing the content that should be visible
        /// in the viewport.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get; set; }
        /// <Summary>
        /// A delegate that lazily instantiates children.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Listwheelscrollview.ListWheelChildDelegate ChildDelegate { get; set; }

        public new FlutterSDK.Widgets.Listwheelscrollview.ListWheelElement CreateElement() => new ListWheelElement(this);



        public new FlutterSDK.Rendering.Listwheelviewport.RenderListWheelViewport CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ListWheelElement childManager = context as ListWheelElement;
            return new RenderListWheelViewport(childManager: childManager, offset: Offset, diameterRatio: DiameterRatio, perspective: Perspective, offAxisFraction: OffAxisFraction, useMagnifier: UseMagnifier, magnification: Magnification, overAndUnderCenterOpacity: OverAndUnderCenterOpacity, itemExtent: ItemExtent, squeeze: Squeeze, clipToSize: ClipToSize, renderChildrenOutsideViewport: RenderChildrenOutsideViewport);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Listwheelviewport.RenderListWheelViewport renderObject)
        {
            ..Offset = Offset..DiameterRatio = DiameterRatio..Perspective = Perspective..OffAxisFraction = OffAxisFraction..UseMagnifier = UseMagnifier..Magnification = Magnification..OverAndUnderCenterOpacity = OverAndUnderCenterOpacity..ItemExtent = ItemExtent..Squeeze = Squeeze..ClipToSize = ClipToSize..RenderChildrenOutsideViewport = RenderChildrenOutsideViewport;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Offset = Offset..DiameterRatio = DiameterRatio..Perspective = Perspective..OffAxisFraction = OffAxisFraction..UseMagnifier = UseMagnifier..Magnification = Magnification..OverAndUnderCenterOpacity = OverAndUnderCenterOpacity..ItemExtent = ItemExtent..Squeeze = Squeeze..ClipToSize = ClipToSize..RenderChildrenOutsideViewport = RenderChildrenOutsideViewport;
        }



    }

}
