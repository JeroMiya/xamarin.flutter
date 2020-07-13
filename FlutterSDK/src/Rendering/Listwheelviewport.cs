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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Rendering.Listwheelviewport
{
    public delegate double _ChildSizingFunction(FlutterSDK.Rendering.Box.RenderBox child);
    internal static class ListwheelviewportDefaultClass
    {
    }

    public interface IListWheelChildManager { }

    public class ListWheelChildManager
    {
        public virtual int ChildCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Checks whether the delegate is able to provide a child widget at the given
        /// index.
        ///
        /// This function is not about whether the child at the given index is
        /// attached to the [RenderListWheelViewport] or not.
        /// </Summary>
        public virtual bool ChildExistsAt(int index)
        {
            return default(bool);
        }


        /// <Summary>
        /// Creates a new child at the given index and updates it to the child list
        /// of [RenderListWheelViewport]. If no child corresponds to `index`, then do
        /// nothing.
        ///
        /// It is possible to create children with negative indices.
        /// </Summary>
        public virtual void CreateChild(int index, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox))
        {
        }


        /// <Summary>
        /// Removes the child element corresponding with the given RenderBox.
        /// </Summary>
        public virtual void RemoveChild(FlutterSDK.Rendering.Box.RenderBox child)
        {
        }

    }
    public static class ListWheelChildManagerMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IListWheelChildManager, ListWheelChildManager> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IListWheelChildManager, ListWheelChildManager>();
        static ListWheelChildManager GetOrCreate(IListWheelChildManager instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ListWheelChildManager();
                _table.Add(instance, value);
            }
            return (ListWheelChildManager)value;
        }
        public static int ChildCountProperty(this IListWheelChildManager instance) => GetOrCreate(instance).ChildCount;
        public static bool ChildExistsAt(this IListWheelChildManager instance, int index) => GetOrCreate(instance).ChildExistsAt(index);
        public static void CreateChild(this IListWheelChildManager instance, int index, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox)) => GetOrCreate(instance).CreateChild(index, after);
        public static void RemoveChild(this IListWheelChildManager instance, FlutterSDK.Rendering.Box.RenderBox child) => GetOrCreate(instance).RemoveChild(child);
    }


    /// <Summary>
    /// [ParentData] for use with [RenderListWheelViewport].
    /// </Summary>
    public class ListWheelParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
    {
        #region constructors
        public ListWheelParentData()
        { }
        #endregion

        #region fields
        public virtual int Index { get; set; }
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// Render, onto a wheel, a bigger sequential set of objects inside this viewport.
    ///
    /// Takes a scrollable set of fixed sized [RenderBox]es and renders them
    /// sequentially from top down on a vertical scrolling axis.
    ///
    /// It starts with the first scrollable item in the center of the main axis
    /// and ends with the last scrollable item in the center of the main axis. This
    /// is in contrast to typical lists that start with the first scrollable item
    /// at the start of the main axis and ends with the last scrollable item at the
    /// end of the main axis.
    ///
    /// Instead of rendering its children on a flat plane, it renders them
    /// as if each child is broken into its own plane and that plane is
    /// perpendicularly fixed onto a cylinder which rotates along the scrolling
    /// axis.
    ///
    /// This class works in 3 coordinate systems:
    ///
    /// 1. The **scrollable layout coordinates**. This coordinate system is used to
    ///    communicate with [ViewportOffset] and describes its children's abstract
    ///    offset from the beginning of the scrollable list at (0.0, 0.0).
    ///
    ///    The list is scrollable from the start of the first child item to the
    ///    start of the last child item.
    ///
    ///    Children's layout coordinates don't change as the viewport scrolls.
    ///
    /// 2. The **untransformed plane's viewport painting coordinates**. Children are
    ///    not painted in this coordinate system. It's an abstract intermediary used
    ///    before transforming into the next cylindrical coordinate system.
    ///
    ///    This system is the **scrollable layout coordinates** translated by the
    ///    scroll offset such that (0.0, 0.0) is the top left corner of the
    ///    viewport.
    ///
    ///    Because the viewport is centered at the scrollable list's scroll offset
    ///    instead of starting at the scroll offset, there are paintable children
    ///    ~1/2 viewport length before and after the scroll offset instead of ~1
    ///    viewport length after the scroll offset.
    ///
    ///    Children's visibility inclusion in the viewport is determined in this
    ///    system regardless of the cylinder's properties such as [diameterRatio]
    ///    or [perspective]. In other words, a 100px long viewport will always
    ///    paint 10-11 visible 10px children if there are enough children in the
    ///    viewport.
    ///
    /// 3. The **transformed cylindrical space viewport painting coordinates**.
    ///    Children from system 2 get their positions transformed into a cylindrical
    ///    projection matrix instead of its Cartesian offset with respect to the
    ///    scroll offset.
    ///
    ///    Children in this coordinate system are painted.
    ///
    ///    The wheel's size and the maximum and minimum visible angles are both
    ///    controlled by [diameterRatio]. Children visible in the **untransformed
    ///    plane's viewport painting coordinates**'s viewport will be radially
    ///    evenly laid out between the maximum and minimum angles determined by
    ///    intersecting the viewport's main axis length with a cylinder whose
    ///    diameter is [diameterRatio] times longer, as long as those angles are
    ///    between -pi/2 and pi/2.
    ///
    ///    For example, if [diameterRatio] is 2.0 and this [RenderListWheelViewport]
    ///    is 100.0px in the main axis, then the diameter is 200.0. And children
    ///    will be evenly laid out between that cylinder's -arcsin(1/2) and
    ///    arcsin(1/2) angles.
    ///
    ///    The cylinder's 0 degree side is always centered in the
    ///    [RenderListWheelViewport]. The transformation from **untransformed
    ///    plane's viewport painting coordinates** is also done such that the child
    ///    in the center of that plane will be mostly untransformed with children
    ///    above and below it being transformed more as the angle increases.
    /// </Summary>
    public class RenderListWheelViewport : FlutterSDK.Rendering.Box.RenderBox, IRenderAbstractViewport, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Listwheelviewport.ListWheelParentData>
    {
        #region constructors
        public RenderListWheelViewport(FlutterSDK.Rendering.Listwheelviewport.ListWheelChildManager childManager = default(FlutterSDK.Rendering.Listwheelviewport.ListWheelChildManager), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), double diameterRatio = default(double), double perspective = default(double), double offAxisFraction = 0, bool useMagnifier = false, double magnification = 1, double overAndUnderCenterOpacity = 1, double itemExtent = default(double), double squeeze = 1, bool clipToSize = true, bool renderChildrenOutsideViewport = false, List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>))
        : base()
    
AddAll(children);
    }


    #endregion

    #region fields
    public virtual double DefaultDiameterRatio { get; set; }
    public virtual double DefaultPerspective { get; set; }
    public virtual string DiameterRatioZeroMessage { get; set; }
    public virtual string PerspectiveTooHighMessage { get; set; }
    public virtual string ClipToSizeAndRenderChildrenOutsideViewportConflict { get; set; }
    public virtual FlutterSDK.Rendering.Listwheelviewport.ListWheelChildManager ChildManager { get; set; }
    internal virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset _Offset { get; set; }
    internal virtual double _DiameterRatio { get; set; }
    internal virtual double _Perspective { get; set; }
    internal virtual double _OffAxisFraction { get; set; }
    internal virtual bool _UseMagnifier { get; set; }
    internal virtual double _Magnification { get; set; }
    internal virtual double _OverAndUnderCenterOpacity { get; set; }
    internal virtual double _ItemExtent { get; set; }
    internal virtual double _Squeeze { get; set; }
    internal virtual bool _ClipToSize { get; set; }
    internal virtual bool _RenderChildrenOutsideViewport { get; set; }
    public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double DiameterRatio { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double Perspective { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double OffAxisFraction { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool UseMagnifier { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double Magnification { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double OverAndUnderCenterOpacity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double ItemExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double Squeeze { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool ClipToSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool RenderChildrenOutsideViewport { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool IsRepaintBoundary { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    internal virtual double _ViewportExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    internal virtual double _MinEstimatedScrollExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    internal virtual double _MaxEstimatedScrollExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    internal virtual double _TopScrollMarginExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    internal virtual double _MaxVisibleRadian { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    private void _HasScrolled()
    {
        MarkNeedsLayout();
        MarkNeedsSemanticsUpdate();
    }




    public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
    {
        if (!(child.ParentData is ListWheelParentData)) child.ParentData = new ListWheelParentData();
    }




    public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
    {
        base.Attach(owner);
        _Offset.AddListener(_HasScrolled);
    }


    public new void Attach(@Object owner)
    {
        base.Attach(owner);
        _Offset.AddListener(_HasScrolled);
    }




    public new void Detach()
    {
        _Offset.RemoveListener(_HasScrolled);
        base.Detach();
    }




    /// <Summary>
    /// Transforms a **scrollable layout coordinates**' y position to the
    /// **untransformed plane's viewport painting coordinates**' y position given
    /// the current scroll offset.
    /// </Summary>
    private double _GetUntransformedPaintingCoordinateY(double layoutCoordinateY)
    {
        return layoutCoordinateY - _TopScrollMarginExtent - Offset.Pixels;
    }




    private double _GetIntrinsicCrossAxis(FlutterSDK.Rendering.Listwheelviewport._ChildSizingFunction childSize)
    {
        double extent = 0.0;
        RenderBox child = FirstChild;
        while (child != null)
        {
            extent = Math.Dart:mathDefaultClass.Max(extent, childSize(child));
            child = ChildAfter(child);
        }

        return extent;
    }




    public new double ComputeMinIntrinsicWidth(double height)
    {
        return _GetIntrinsicCrossAxis((RenderBox child) => =>child.GetMinIntrinsicWidth(height));
    }




    public new double ComputeMaxIntrinsicWidth(double height)
    {
        return _GetIntrinsicCrossAxis((RenderBox child) => =>child.GetMaxIntrinsicWidth(height));
    }




    public new double ComputeMinIntrinsicHeight(double width)
    {
        if (ChildManager.ChildCount == null) return 0.0;
        return ChildManager.ChildCount * _ItemExtent;
    }




    public new double ComputeMaxIntrinsicHeight(double width)
    {
        if (ChildManager.ChildCount == null) return 0.0;
        return ChildManager.ChildCount * _ItemExtent;
    }




    public new void PerformResize()
    {
        Size = Constraints.Biggest;
    }




    /// <Summary>
    /// Gets the index of a child by looking at its parentData.
    /// </Summary>
    public virtual int IndexOf(FlutterSDK.Rendering.Box.RenderBox child)
    {

        ListWheelParentData childParentData = child.ParentData as ListWheelParentData;

        return childParentData.Index;
    }




    /// <Summary>
    /// Returns the index of the child at the given offset.
    /// </Summary>
    public virtual int ScrollOffsetToIndex(double scrollOffset) => (scrollOffset / ItemExtent).Floor();



    /// <Summary>
    /// Returns the scroll offset of the child with the given index.
    /// </Summary>
    public virtual double IndexToScrollOffset(int index) => index * ItemExtent;



    private void _CreateChild(int index, FlutterSDK.Rendering.Box.RenderBox after = default(FlutterSDK.Rendering.Box.RenderBox))
    {
        InvokeLayoutCallback((BoxConstraints constraints) =>
        {

            ChildManager.CreateChild(index, after: after);
        }
        );
    }




    private void _DestroyChild(FlutterSDK.Rendering.Box.RenderBox child)
    {
        InvokeLayoutCallback((BoxConstraints constraints) =>
        {

            ChildManager.RemoveChild(child);
        }
        );
    }




    private void _LayoutChild(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Rendering.Box.BoxConstraints constraints, int index)
    {
        child.Layout(constraints, parentUsesSize: true);
        ListWheelParentData childParentData = child.ParentData as ListWheelParentData;
        double crossPosition = Size.Width / 2.0 - child.Size.Width / 2.0;
        childParentData.Offset = new Offset(crossPosition, IndexToScrollOffset(index));
    }




    /// <Summary>
    /// Performs layout based on how [childManager] provides children.
    ///
    /// From the current scroll offset, the minimum index and maximum index that
    /// is visible in the viewport can be calculated. The index range of the
    /// currently active children can also be acquired by looking directly at
    /// the current child list. This function has to modify the current index
    /// range to match the target index range by removing children that are no
    /// longer visible and creating those that are visible but not yet provided
    /// by [childManager].
    /// </Summary>
    public new void PerformLayout()
    {
        BoxConstraints childConstraints = Constraints.CopyWith(minHeight: _ItemExtent, maxHeight: _ItemExtent, minWidth: 0.0);
        double visibleHeight = Size.Height * _Squeeze;
        if (RenderChildrenOutsideViewport) visibleHeight *= 2;
        double firstVisibleOffset = Offset.Pixels + _ItemExtent / 2 - visibleHeight / 2;
        double lastVisibleOffset = firstVisibleOffset + visibleHeight;
        int targetFirstIndex = ScrollOffsetToIndex(firstVisibleOffset);
        int targetLastIndex = ScrollOffsetToIndex(lastVisibleOffset);
        if (targetLastIndex * _ItemExtent == lastVisibleOffset) targetLastIndex--;
        while (!ChildManager.ChildExistsAt(targetFirstIndex) && targetFirstIndex <= targetLastIndex) targetFirstIndex++;
        while (!ChildManager.ChildExistsAt(targetLastIndex) && targetFirstIndex <= targetLastIndex) targetLastIndex--;
        if (targetFirstIndex > targetLastIndex)
        {
            while (FirstChild != null) _DestroyChild(FirstChild);
            return;
        }

        if (ChildCount > 0 && (IndexOf(FirstChild) > targetLastIndex || IndexOf(LastChild) < targetFirstIndex))
        {
            while (FirstChild != null) _DestroyChild(FirstChild);
        }

        if (ChildCount == 0)
        {
            _CreateChild(targetFirstIndex);
            _LayoutChild(FirstChild, childConstraints, targetFirstIndex);
        }

        int currentFirstIndex = IndexOf(FirstChild);
        int currentLastIndex = IndexOf(LastChild);
        while (currentFirstIndex < targetFirstIndex)
        {
            _DestroyChild(FirstChild);
            currentFirstIndex++;
        }

        while (currentLastIndex > targetLastIndex)
        {
            _DestroyChild(LastChild);
            currentLastIndex--;
        }

        RenderBox child = FirstChild;
        while (child != null)
        {
            child.Layout(childConstraints, parentUsesSize: true);
            child = ChildAfter(child);
        }

        while (currentFirstIndex > targetFirstIndex)
        {
            _CreateChild(currentFirstIndex - 1);
            _LayoutChild(FirstChild, childConstraints, --currentFirstIndex);
        }

        while (currentLastIndex < targetLastIndex)
        {
            _CreateChild(currentLastIndex + 1, after: LastChild);
            _LayoutChild(LastChild, childConstraints, ++currentLastIndex);
        }

        Offset.ApplyViewportDimension(_ViewportExtent);
        double minScrollExtent = ChildManager.ChildExistsAt(targetFirstIndex - 1) ? _MinEstimatedScrollExtent : IndexToScrollOffset(targetFirstIndex);
        double maxScrollExtent = ChildManager.ChildExistsAt(targetLastIndex + 1) ? _MaxEstimatedScrollExtent : IndexToScrollOffset(targetLastIndex);
        Offset.ApplyContentDimensions(minScrollExtent, maxScrollExtent);
    }




    private bool _ShouldClipAtCurrentOffset()
    {
        double highestUntransformedPaintY = _GetUntransformedPaintingCoordinateY(0.0);
        return highestUntransformedPaintY < 0.0 || Size.Height < highestUntransformedPaintY + _MaxEstimatedScrollExtent + _ItemExtent;
    }




    public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {
        if (ChildCount > 0)
        {
            if (_ClipToSize && _ShouldClipAtCurrentOffset())
            {
                context.PushClipRect(NeedsCompositing, offset, Dart: uiDefaultClass.Offset.Zero & Size, _PaintVisibleChildren);
            }
            else
            {
                _PaintVisibleChildren(context, offset);
            }

        }

    }




    /// <Summary>
    /// Paints all children visible in the current viewport.
    /// </Summary>
    private void _PaintVisibleChildren(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
    {
        RenderBox childToPaint = FirstChild;
        ListWheelParentData childParentData = childToPaint?.ParentData as ListWheelParentData;
        while (childParentData != null)
        {
            _PaintTransformedChild(childToPaint, context, offset, childParentData.Offset);
            childToPaint = ChildAfter(childToPaint);
            childParentData = childToPaint?.ParentData as ListWheelParentData;
        }

    }




    /// <Summary>
    /// Takes in a child with a **scrollable layout offset** and paints it in the
    /// **transformed cylindrical space viewport painting coordinates**.
    /// </Summary>
    private void _PaintTransformedChild(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterBinding.UI.Offset layoutOffset)
    {
        Offset untransformedPaintingCoordinates = offset + new Offset(layoutOffset.Dx, _GetUntransformedPaintingCoordinateY(layoutOffset.Dy));
        double fractionalY = (untransformedPaintingCoordinates.Dy + _ItemExtent / 2.0) / Size.Height;
        double angle = -(fractionalY - 0.5) * 2.0 * _MaxVisibleRadian / Squeeze;
        if (angle > Math.Dart:mathDefaultClass.Pi / 2.0 || angle < -Math.Dart:mathDefaultClass.Pi / 2.0)return;
        Matrix4 transform = MatrixutilsDefaultClass.MatrixUtils.CreateCylindricalProjectionTransform(radius: Size.Height * _DiameterRatio / 2.0, angle: angle, perspective: _Perspective);
        Offset offsetToCenter = new Offset(untransformedPaintingCoordinates.Dx, -_TopScrollMarginExtent);
        bool shouldApplyOffCenterDim = OverAndUnderCenterOpacity < 1;
        if (UseMagnifier || shouldApplyOffCenterDim)
        {
            _PaintChildWithMagnifier(context, offset, child, transform, offsetToCenter, untransformedPaintingCoordinates);
        }
        else
        {
            _PaintChildCylindrically(context, offset, child, transform, offsetToCenter);
        }

    }




    /// <Summary>
    /// Paint child with the magnifier active - the child will be rendered
    /// differently if it intersects with the magnifier.
    /// </Summary>
    private void _PaintChildWithMagnifier(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox child, Matrix4 cylindricalTransform, FlutterBinding.UI.Offset offsetToCenter, FlutterBinding.UI.Offset untransformedPaintingCoordinates)
    {
        double magnifierTopLinePosition = Size.Height / 2 - _ItemExtent * _Magnification / 2;
        double magnifierBottomLinePosition = Size.Height / 2 + _ItemExtent * _Magnification / 2;
        bool isAfterMagnifierTopLine = untransformedPaintingCoordinates.Dy >= magnifierTopLinePosition - _ItemExtent * _Magnification;
        bool isBeforeMagnifierBottomLine = untransformedPaintingCoordinates.Dy <= magnifierBottomLinePosition;
        if (isAfterMagnifierTopLine && isBeforeMagnifierBottomLine)
        {
            Rect centerRect = Rect.FromLTWH(0.0, magnifierTopLinePosition, Size.Width, _ItemExtent * _Magnification);
            Rect topHalfRect = Rect.FromLTWH(0.0, 0.0, Size.Width, magnifierTopLinePosition);
            Rect bottomHalfRect = Rect.FromLTWH(0.0, magnifierBottomLinePosition, Size.Width, magnifierTopLinePosition);
            context.PushClipRect(NeedsCompositing, offset, centerRect, (PaintingContext context, Offset offset) =>
            {
                context.PushTransform(NeedsCompositing, offset, _MagnifyTransform(), (PaintingContext context, Offset offset) =>
                {
                    context.PaintChild(child, offset + untransformedPaintingCoordinates);
                }
                );
            }
            );
            context.PushClipRect(NeedsCompositing, offset, untransformedPaintingCoordinates.Dy <= magnifierTopLinePosition ? topHalfRect : bottomHalfRect, (PaintingContext context, Offset offset) =>
            {
                _PaintChildCylindrically(context, offset, child, cylindricalTransform, offsetToCenter);
            }
            );
        }
        else
        {
            _PaintChildCylindrically(context, offset, child, cylindricalTransform, offsetToCenter);
        }

    }




    private void _PaintChildCylindrically(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox child, Matrix4 cylindricalTransform, FlutterBinding.UI.Offset offsetToCenter)
    {
        PaintingContextCallback painter = (PaintingContext context, Offset offset) =>
        {
            context.PaintChild(child, offset + offsetToCenter);
        }
        ;
        PaintingContextCallback opacityPainter = (PaintingContext context, Offset offset) =>
        {
            context.PushOpacity(offset, (OverAndUnderCenterOpacity * 255).Round(), painter);
        }
        ;
        context.PushTransform(NeedsCompositing, offset, _CenterOriginTransform(cylindricalTransform), OverAndUnderCenterOpacity == 1 ? painter : opacityPainter);
    }




    /// <Summary>
    /// Return the Matrix4 transformation that would zoom in content in the
    /// magnified area.
    /// </Summary>
    private Matrix4 _MagnifyTransform()
    {
        Matrix4 magnify = Matrix4.Identity();
        magnify.Translate(Size.Width * (-_OffAxisFraction + 0.5), Size.Height / 2);
        magnify.Scale(_Magnification, _Magnification, _Magnification);
        magnify.Translate(-Size.Width * (-_OffAxisFraction + 0.5), -Size.Height / 2);
        return magnify;
    }




    /// <Summary>
    /// Apply incoming transformation with the transformation's origin at the
    /// viewport's center or horizontally off to the side based on offAxisFraction.
    /// </Summary>
    private Matrix4 _CenterOriginTransform(Matrix4 originalMatrix)
    {
        Matrix4 result = Matrix4.Identity();
        Offset centerOriginTranslation = AlignmentDefaultClass.Alignment.Center.AlongSize(Size);
        result.Translate(centerOriginTranslation.Dx * (-_OffAxisFraction * 2 + 1), centerOriginTranslation.Dy);
        result.Multiply(originalMatrix);
        result.Translate(-centerOriginTranslation.Dx * (-_OffAxisFraction * 2 + 1), -centerOriginTranslation.Dy);
        return result;
    }




    /// <Summary>
    /// This returns the matrices relative to the **untransformed plane's viewport
    /// painting coordinates** system.
    /// </Summary>
    public new void ApplyPaintTransform(FlutterSDK.Rendering.Box.RenderBox child, Matrix4 transform)
    {
        ListWheelParentData parentData = child?.ParentData as ListWheelParentData;
        transform.Translate(0.0, _GetUntransformedPaintingCoordinateY(parentData.Offset.Dy));
    }


    public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
    {
        ListWheelParentData parentData = child?.ParentData as ListWheelParentData;
        transform.Translate(0.0, _GetUntransformedPaintingCoordinateY(parentData.Offset.Dy));
    }




    public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child)
    {
        if (child != null && _ShouldClipAtCurrentOffset())
        {
            return Dart:uiDefaultClass.Offset.Zero & Size;
        }

        return null;
    }




    public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) => false;



    public new FlutterSDK.Rendering.Viewport.RevealedOffset GetOffsetToReveal(FlutterSDK.Rendering.@object.RenderObject target, double alignment, FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect))
    {
        rect = (rect == null ? target.PaintBounds : rect);
        RenderObject child = target;
        while (child.Parent != this) child = child.Parent as RenderObject;
        ListWheelParentData parentData = child.ParentData as ListWheelParentData;
        double targetOffset = parentData.Offset.Dy;
        Matrix4 transform = target.GetTransformTo(child);
        Rect bounds = MatrixutilsDefaultClass.MatrixUtils.TransformRect(transform, rect);
        Rect targetRect = bounds.Translate(0.0, (Size.Height - ItemExtent) / 2);
        return new RevealedOffset(offset: targetOffset, rect: targetRect);
    }




    public new void ShowOnScreen(FlutterSDK.Rendering.@object.RenderObject descendant = default(FlutterSDK.Rendering.@object.RenderObject), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), TimeSpan duration = default(TimeSpan), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
    {
        if (descendant != null)
        {
            RevealedOffset revealedOffset = GetOffsetToReveal(descendant, 0.5, rect: rect);
            if (duration == Dart:coreDefaultClass.Duration.Zero){
                Offset.JumpTo(revealedOffset.Offset);
            }
else
            {
                Offset.AnimateTo(revealedOffset.Offset, duration: duration, curve: curve);
            }

            rect = revealedOffset.Rect;
        }

        base.ShowOnScreen(rect: rect, duration: duration, curve: curve);
    }



    #endregion
    RenderAbstractViewport _RenderAbstractViewportInstance = new RenderAbstractViewport();
    public FlutterSDK.Rendering.Viewport.RenderAbstractViewport Of(FlutterSDK.Rendering.@object.RenderObject @object) => _RenderAbstractViewportInstance.Of(@object);
    public double DefaultCacheExtent => _RenderAbstractViewportInstance.DefaultCacheExtent;
}

}
