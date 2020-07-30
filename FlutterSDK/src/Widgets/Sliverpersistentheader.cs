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
namespace FlutterSDK.Widgets.Sliverpersistentheader
{
    internal static class SliverpersistentheaderDefaultClass
    {
    }

    /// <Summary>
    /// Delegate for configuring a [SliverPersistentHeader].
    /// </Summary>
    public interface ISliverPersistentHeaderDelegate
    {
        FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, double shrinkOffset, bool overlapsContent);
        bool ShouldRebuild(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate oldDelegate);
        double MinExtent { get; }
        double MaxExtent { get; }
        FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration SnapConfiguration { get; }
        FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration StretchConfiguration { get; }
    }


    internal interface I_SliverPersistentHeaderRenderObjectWidget
    {
        FlutterSDK.Widgets.Sliverpersistentheader._SliverPersistentHeaderElement CreateElement();
        FlutterSDK.Widgets.Sliverpersistentheader._RenderSliverPersistentHeaderForWidgetsMixin CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context);
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description);
        FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate @delegate { get; }
    }


    public interface I_RenderSliverPersistentHeaderForWidgetsMixin { }

    public class _RenderSliverPersistentHeaderForWidgetsMixin
    {
        internal virtual FlutterSDK.Widgets.Sliverpersistentheader._SliverPersistentHeaderElement _Element { get; set; }
        public virtual double MinExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MaxExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void UpdateChild(double shrinkOffset, bool overlapsContent)
        {

            _Element._Build(shrinkOffset, overlapsContent);
        }




        public virtual void TriggerRebuild()
        {
            MarkNeedsLayout();
        }



    }
    public static class _RenderSliverPersistentHeaderForWidgetsMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<I_RenderSliverPersistentHeaderForWidgetsMixin, _RenderSliverPersistentHeaderForWidgetsMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<I_RenderSliverPersistentHeaderForWidgetsMixin, _RenderSliverPersistentHeaderForWidgetsMixin>();
        static _RenderSliverPersistentHeaderForWidgetsMixin GetOrCreate(I_RenderSliverPersistentHeaderForWidgetsMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new _RenderSliverPersistentHeaderForWidgetsMixin();
                _table.Add(instance, value);
            }
            return (_RenderSliverPersistentHeaderForWidgetsMixin)value;
        }
        public static double MinExtentProperty(this I_RenderSliverPersistentHeaderForWidgetsMixin instance) => GetOrCreate(instance).MinExtent;
        public static double MaxExtentProperty(this I_RenderSliverPersistentHeaderForWidgetsMixin instance) => GetOrCreate(instance).MaxExtent;
        public static void UpdateChild(this I_RenderSliverPersistentHeaderForWidgetsMixin instance, double shrinkOffset, bool overlapsContent) => GetOrCreate(instance).UpdateChild(shrinkOffset, overlapsContent);
        public static void TriggerRebuild(this I_RenderSliverPersistentHeaderForWidgetsMixin instance) => GetOrCreate(instance).TriggerRebuild();
    }


    /// <Summary>
    /// Delegate for configuring a [SliverPersistentHeader].
    /// </Summary>
    public class SliverPersistentHeaderDelegate
    {
        public SliverPersistentHeaderDelegate()
        {

        }
        public virtual double MinExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MaxExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration SnapConfiguration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration StretchConfiguration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// The widget to place inside the [SliverPersistentHeader].
        ///
        /// The `context` is the [BuildContext] of the sliver.
        ///
        /// The `shrinkOffset` is a distance from [maxExtent] towards [minExtent]
        /// representing the current amount by which the sliver has been shrunk. When
        /// the `shrinkOffset` is zero, the contents will be rendered with a dimension
        /// of [maxExtent] in the main axis. When `shrinkOffset` equals the difference
        /// between [maxExtent] and [minExtent] (a positive number), the contents will
        /// be rendered with a dimension of [minExtent] in the main axis. The
        /// `shrinkOffset` will always be a positive number in that range.
        ///
        /// The `overlapsContent` argument is true if subsequent slivers (if any) will
        /// be rendered beneath this one, and false if the sliver will not have any
        /// contents below it. Typically this is used to decide whether to draw a
        /// shadow to simulate the sliver being above the contents below it. Typically
        /// this is true when `shrinkOffset` is at its greatest value and false
        /// otherwise, but that is not guaranteed. See [NestedScrollView] for an
        /// example of a case where `overlapsContent`'s value can be unrelated to
        /// `shrinkOffset`.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, double shrinkOffset, bool overlapsContent)
        {
            return default(Widget);
        }


        /// <Summary>
        /// Whether this delegate is meaningfully different from the old delegate.
        ///
        /// If this returns false, then the header might not be rebuilt, even though
        /// the instance of the delegate changed.
        ///
        /// This must return true if `oldDelegate` and this object would return
        /// different values for [minExtent], [maxExtent], [snapConfiguration], or
        /// would return a meaningfully different widget tree from [build] for the
        /// same arguments.
        /// </Summary>
        public virtual bool ShouldRebuild(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate oldDelegate)
        {
            return default(bool);
        }

    }


    /// <Summary>
    /// A sliver whose size varies when the sliver is scrolled to the edge
    /// of the viewport opposite the sliver's [GrowthDirection].
    ///
    /// In the normal case of a [CustomScrollView] with no centered sliver, this
    /// sliver will vary its size when scrolled to the leading edge of the viewport.
    ///
    /// This is the layout primitive that [SliverAppBar] uses for its
    /// shrinking/growing effect.
    /// </Summary>
    public class SliverPersistentHeader : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public SliverPersistentHeader(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate @delegate = default(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate), bool pinned = false, bool floating = false)
        : base(key: key)
        {
            this.@delegate = @delegate;
            this.Pinned = pinned;
            this.Floating = floating;
        }
        public virtual FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate @delegate { get; set; }
        public virtual bool Pinned { get; set; }
        public virtual bool Floating { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (Floating && Pinned) return new _SliverFloatingPinnedPersistentHeader(@delegate: @Delegate);
            if (Pinned) return new _SliverPinnedPersistentHeader(@delegate: @Delegate);
            if (Floating) return new _SliverFloatingPersistentHeader(@delegate: @Delegate);
            return new _SliverScrollingPersistentHeader(@delegate: @Delegate);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<SliverPersistentHeaderDelegate>("delegate", Delegate));
            List<string> flags = new List<string>() { };
            if (flags.IsEmpty()) flags.Add("normal");
            properties.Add(new IterableProperty<string>("mode", flags));
        }



    }


    public class _SliverPersistentHeaderElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        public _SliverPersistentHeaderElement(FlutterSDK.Widgets.Sliverpersistentheader._SliverPersistentHeaderRenderObjectWidget widget)
        : base(widget)
        {

        }
        public virtual FlutterSDK.Widgets.Framework.Element Child { get; set; }
        public virtual FlutterSDK.Widgets.Sliverpersistentheader._SliverPersistentHeaderRenderObjectWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Sliverpersistentheader._RenderSliverPersistentHeaderForWidgetsMixin RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {
            base.Mount(parent, newSlot);
            RenderObject._Element = this;
        }




        public new void Unmount()
        {
            base.Unmount();
            RenderObject._Element = null;
        }




        public new void Update(FlutterSDK.Widgets.Sliverpersistentheader._SliverPersistentHeaderRenderObjectWidget newWidget)
        {
            _SliverPersistentHeaderRenderObjectWidget oldWidget = Widget;
            base.Update(newWidget);
            SliverPersistentHeaderDelegate newDelegate = newWidget.Delegate;
            SliverPersistentHeaderDelegate oldDelegate = oldWidget.Delegate;
            if (newDelegate != oldDelegate && (newDelegate.GetType() != oldDelegate.GetType() || newDelegate.ShouldRebuild(oldDelegate))) RenderObject.TriggerRebuild();
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            _SliverPersistentHeaderRenderObjectWidget oldWidget = Widget;
            base.Update(newWidget);
            SliverPersistentHeaderDelegate newDelegate = newWidget.Delegate;
            SliverPersistentHeaderDelegate oldDelegate = oldWidget.Delegate;
            if (newDelegate != oldDelegate && (newDelegate.GetType() != oldDelegate.GetType() || newDelegate.ShouldRebuild(oldDelegate))) RenderObject.TriggerRebuild();
        }




        public new void PerformRebuild()
        {
            base.PerformRebuild();
            RenderObject.TriggerRebuild();
        }




        private void _Build(double shrinkOffset, bool overlapsContent)
        {
            Owner.BuildScope(this, () =>
            {
                Child = UpdateChild(Child, Widget.Delegate.Build(this, shrinkOffset, overlapsContent), null);
            }
            );
        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {

            this.Child = null;
            base.ForgetChild(child);
        }




        public new void InsertChildRenderObject(FlutterSDK.Rendering.Box.RenderBox child, object slot)
        {

            RenderObject.Child = child;
        }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {

            RenderObject.Child = child;
        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slot)
        {

        }




        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {
            RenderObject.Child = null;
        }




        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            if (Child != null) visitor(Child);
        }



    }


    public class _SliverPersistentHeaderRenderObjectWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        public _SliverPersistentHeaderRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate @delegate = default(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate))
        : base(key: key)
        {
            this.@delegate = @delegate;
        }
        public virtual FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate @delegate { get; set; }

        public new FlutterSDK.Widgets.Sliverpersistentheader._SliverPersistentHeaderElement CreateElement() => new _SliverPersistentHeaderElement(this);



        public new FlutterSDK.Widgets.Sliverpersistentheader._RenderSliverPersistentHeaderForWidgetsMixin CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return default(_RenderSliverPersistentHeaderForWidgetsMixin);
        }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
        {
            base.DebugFillProperties(description);
            description.Add(new DiagnosticsProperty<SliverPersistentHeaderDelegate>("delegate", Delegate));
        }



    }


    public class _SliverScrollingPersistentHeader : FlutterSDK.Widgets.Sliverpersistentheader._SliverPersistentHeaderRenderObjectWidget
    {
        public _SliverScrollingPersistentHeader(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate @delegate = default(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate))
        : base(key: key, @delegate: @delegate)
        {

        }

        public new FlutterSDK.Widgets.Sliverpersistentheader._RenderSliverPersistentHeaderForWidgetsMixin CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderSliverScrollingPersistentHeaderForWidgets(stretchConfiguration: Delegate.StretchConfiguration);
        }



    }


    public class _RenderSliverScrollingPersistentHeaderForWidgets : FlutterSDK.Rendering.Sliverpersistentheader.RenderSliverScrollingPersistentHeader, I_RenderSliverPersistentHeaderForWidgetsMixin
    {
        public _RenderSliverScrollingPersistentHeaderForWidgets(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration))
        : base(child: child, stretchConfiguration: stretchConfiguration)
        {

        }
    }


    public class _SliverPinnedPersistentHeader : FlutterSDK.Widgets.Sliverpersistentheader._SliverPersistentHeaderRenderObjectWidget
    {
        public _SliverPinnedPersistentHeader(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate @delegate = default(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate))
        : base(key: key, @delegate: @delegate)
        {

        }

        public new FlutterSDK.Widgets.Sliverpersistentheader._RenderSliverPersistentHeaderForWidgetsMixin CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderSliverPinnedPersistentHeaderForWidgets(stretchConfiguration: Delegate.StretchConfiguration);
        }



    }


    public class _RenderSliverPinnedPersistentHeaderForWidgets : FlutterSDK.Rendering.Sliverpersistentheader.RenderSliverPinnedPersistentHeader, I_RenderSliverPersistentHeaderForWidgetsMixin
    {
        public _RenderSliverPinnedPersistentHeaderForWidgets(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration))
        : base(child: child, stretchConfiguration: stretchConfiguration)
        {

        }
    }


    public class _SliverFloatingPersistentHeader : FlutterSDK.Widgets.Sliverpersistentheader._SliverPersistentHeaderRenderObjectWidget
    {
        public _SliverFloatingPersistentHeader(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate @delegate = default(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate))
        : base(key: key, @delegate: @delegate)
        {

        }

        public new FlutterSDK.Widgets.Sliverpersistentheader._RenderSliverPersistentHeaderForWidgetsMixin CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderSliverFloatingPersistentHeaderForWidgets(snapConfiguration: Delegate.SnapConfiguration, stretchConfiguration: Delegate.StretchConfiguration);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Sliverpersistentheader._RenderSliverFloatingPersistentHeaderForWidgets renderObject)
        {
            renderObject.SnapConfiguration = Delegate.SnapConfiguration;
            renderObject.StretchConfiguration = Delegate.StretchConfiguration;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.SnapConfiguration = Delegate.SnapConfiguration;
            renderObject.StretchConfiguration = Delegate.StretchConfiguration;
        }



    }


    public class _RenderSliverFloatingPinnedPersistentHeaderForWidgets : FlutterSDK.Rendering.Sliverpersistentheader.RenderSliverFloatingPinnedPersistentHeader, I_RenderSliverPersistentHeaderForWidgetsMixin
    {
        public _RenderSliverFloatingPinnedPersistentHeaderForWidgets(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration snapConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration))
        : base(child: child, snapConfiguration: snapConfiguration, stretchConfiguration: stretchConfiguration)
        {

        }
    }


    public class _SliverFloatingPinnedPersistentHeader : FlutterSDK.Widgets.Sliverpersistentheader._SliverPersistentHeaderRenderObjectWidget
    {
        public _SliverFloatingPinnedPersistentHeader(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate @delegate = default(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate))
        : base(key: key, @delegate: @delegate)
        {

        }

        public new FlutterSDK.Widgets.Sliverpersistentheader._RenderSliverPersistentHeaderForWidgetsMixin CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderSliverFloatingPinnedPersistentHeaderForWidgets(snapConfiguration: Delegate.SnapConfiguration, stretchConfiguration: Delegate.StretchConfiguration);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Sliverpersistentheader._RenderSliverFloatingPinnedPersistentHeaderForWidgets renderObject)
        {
            renderObject.SnapConfiguration = Delegate.SnapConfiguration;
            renderObject.StretchConfiguration = Delegate.StretchConfiguration;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.SnapConfiguration = Delegate.SnapConfiguration;
            renderObject.StretchConfiguration = Delegate.StretchConfiguration;
        }



    }


    public class _RenderSliverFloatingPersistentHeaderForWidgets : FlutterSDK.Rendering.Sliverpersistentheader.RenderSliverFloatingPersistentHeader, I_RenderSliverPersistentHeaderForWidgetsMixin
    {
        public _RenderSliverFloatingPersistentHeaderForWidgets(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration snapConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.FloatingHeaderSnapConfiguration), FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration stretchConfiguration = default(FlutterSDK.Rendering.Sliverpersistentheader.OverScrollHeaderStretchConfiguration))
        : base(child: child, snapConfiguration: snapConfiguration, stretchConfiguration: stretchConfiguration)
        {

        }
    }

}
