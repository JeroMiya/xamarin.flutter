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
namespace FlutterSDK.Widgets.Sliverfill
{
    internal static class SliverfillDefaultClass
    {
    }

    /// <Summary>
    /// A sliver that contains multiple box children that each fills the viewport.
    ///
    /// [SliverFillViewport] places its children in a linear array along the main
    /// axis. Each child is sized to fill the viewport, both in the main and cross
    /// axis.
    ///
    /// See also:
    ///
    ///  * [SliverFixedExtentList], which has a configurable
    ///    [SliverFixedExtentList.itemExtent].
    ///  * [SliverPrototypeExtentList], which is similar to [SliverFixedExtentList]
    ///    except that it uses a prototype list item instead of a pixel value to define
    ///    the main axis extent of each item.
    ///  * [SliverList], which does not require its children to have the same
    ///    extent in the main axis.
    /// </Summary>
    public class SliverFillViewport : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a sliver whose box children that each fill the viewport.
        /// </Summary>
        public SliverFillViewport(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate), double viewportFraction = 1.0, bool padEnds = true)
        : base(key: key)
        {
            this.@delegate = @delegate;
            this.ViewportFraction = viewportFraction;
            this.PadEnds = padEnds;
        }
        /// <Summary>
        /// The fraction of the viewport that each child should fill in the main axis.
        ///
        /// If this fraction is less than 1.0, more than one child will be visible at
        /// once. If this fraction is greater than 1.0, each child will be larger than
        /// the viewport in the main axis.
        /// </Summary>
        public virtual double ViewportFraction { get; set; }
        /// <Summary>
        /// Whether to add padding to both ends of the list.
        ///
        /// If this is set to true and [viewportFraction] < 1.0, padding will be added
        /// such that the first and last child slivers will be in the center of
        /// the viewport when scrolled all the way to the start or end, respectively.
        /// You may want to set this to false if this [SliverFillViewport] is not the only
        /// widget along this main axis, such as in a [CustomScrollView] with multiple
        /// children.
        ///
        /// This option cannot be [null]. If [viewportFraction] >= 1.0, this option has no
        /// effect. Defaults to [true].
        /// </Summary>
        public virtual bool PadEnds { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.sliverMultiBoxAdaptor.delegate}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _SliverFractionalPadding(viewportFraction: PadEnds ? (1 - ViewportFraction).Clamp(0, 1) / 2 : 0, sliver: new _SliverFillViewportRenderObjectWidget(viewportFraction: ViewportFraction, @delegate: @Delegate));
        }



    }


    public class _SliverFillViewportRenderObjectWidget : FlutterSDK.Widgets.Sliver.SliverMultiBoxAdaptorWidget
    {
        public _SliverFillViewportRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Sliver.SliverChildDelegate @delegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate), double viewportFraction = 1.0)
        : base(key: key, @delegate: @delegate)
        {
            this.ViewportFraction = viewportFraction;
        }
        public virtual double ViewportFraction { get; set; }

        public new FlutterSDK.Rendering.Sliverfill.RenderSliverFillViewport CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            SliverMultiBoxAdaptorElement element = context as SliverMultiBoxAdaptorElement;
            return new RenderSliverFillViewport(childManager: element, viewportFraction: ViewportFraction);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Sliverfill.RenderSliverFillViewport renderObject)
        {
            renderObject.ViewportFraction = ViewportFraction;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.ViewportFraction = ViewportFraction;
        }



    }


    public class _SliverFractionalPadding : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _SliverFractionalPadding(double viewportFraction = 0, FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
        : base(child: sliver)
        {
            this.ViewportFraction = viewportFraction;
        }
        public virtual double ViewportFraction { get; set; }

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new _RenderSliverFractionalPadding(viewportFraction: ViewportFraction);



        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Sliverfill._RenderSliverFractionalPadding renderObject)
        {
            renderObject.ViewportFraction = ViewportFraction;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.ViewportFraction = ViewportFraction;
        }



    }


    public class _RenderSliverFractionalPadding : FlutterSDK.Rendering.Sliverpadding.RenderSliverEdgeInsetsPadding
    {
        public _RenderSliverFractionalPadding(double viewportFraction = 0)
        : base()
        {

        }
        internal virtual FlutterSDK.Rendering.Sliver.SliverConstraints _LastResolvedConstraints { get; set; }
        internal virtual double _ViewportFraction { get; set; }
        internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets _ResolvedPadding { get; set; }
        public virtual double ViewportFraction { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ResolvedPadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _MarkNeedsResolution()
        {
            _ResolvedPadding = null;
            MarkNeedsLayout();
        }




        private void _Resolve()
        {
            if (_ResolvedPadding != null && _LastResolvedConstraints == Constraints) return;

            double paddingValue = Constraints.ViewportMainAxisExtent * ViewportFraction;
            _LastResolvedConstraints = Constraints;
            switch (Constraints.Axis) { case Axis.Horizontal: _ResolvedPadding = EdgeInsets.Symmetric(horizontal: paddingValue); break; case Axis.Vertical: _ResolvedPadding = EdgeInsets.Symmetric(vertical: paddingValue); break; }
            return;
        }




        public new void PerformLayout()
        {
            _Resolve();
            base.PerformLayout();
        }



    }


    /// <Summary>
    /// A sliver that contains a single box child that fills the remaining space in
    /// the viewport.
    ///
    /// [SliverFillRemaining] will size its [child] to fill the viewport in the
    /// cross axis. The extent of the sliver and its child's size in the main axis
    /// is computed conditionally, described in further detail below.
    ///
    /// Typically this will be the last sliver in a viewport, since (by definition)
    /// there is never any room for anything beyond this sliver.
    ///
    /// ## Main Axis Extent
    ///
    /// ### When [SliverFillRemaining] has a scrollable child
    ///
    /// The [hasScrollBody] flag indicates whether the sliver's child has a
    /// scrollable body. This value is never null, and defaults to true. A common
    /// example of this use is a [NestedScrollView]. In this case, the sliver will
    /// size its child to fill the maximum available extent.
    ///
    /// ### When [SliverFillRemaining] does not have a scrollable child
    ///
    /// When [hasScrollBody] is set to false, the child's size is taken into account
    /// when considering the extent to which it should fill the space. The extent to
    /// which the preceding slivers have been scrolled is also taken into
    /// account in deciding how to layout this sliver.
    ///
    /// [SliverFillRemaining] will size its [child] to fill the viewport in the
    /// main axis if that space is larger than the child's extent, and the
    /// the amount of space that has been scrolled beforehand has not exceeded the
    /// main axis extent of the viewport.
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// In this sample the [SliverFillRemaining] sizes its [child] to fill the
    /// remaining extent of the viewport in both axes. The icon is centered in the
    /// sliver, and would be in any computed extent for the sliver.
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return CustomScrollView(
    ///     slivers: <Widget>[
    ///       SliverToBoxAdapter(
    ///         child: Container(
    ///           color: Colors.amber[300],
    ///           height: 150.0,
    ///         ),
    ///       ),
    ///       SliverFillRemaining(
    ///         hasScrollBody: false,
    ///         child: Container(
    ///           color: Colors.blue[100],
    ///           child: Icon(
    ///             Icons.sentiment_very_satisfied,
    ///             size: 75,
    ///             color: Colors.blue[900],
    ///           ),
    ///         ),
    ///       ),
    ///     ],
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// [SliverFillRemaining] will defer to the size of its [child] if the
    /// child's size exceeds the remaining space in the viewport.
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// In this sample the [SliverFillRemaining] defers to the size of its [child]
    /// because the child's extent exceeds that of the remaining extent of the
    /// viewport's main axis.
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return CustomScrollView(
    ///     slivers: <Widget>[
    ///       SliverFixedExtentList(
    ///         itemExtent: 100.0,
    ///         delegate: SliverChildBuilderDelegate(
    ///           (BuildContext context, int index) {
    ///             return Container(
    ///               color: index % 2 == 0
    ///                 ? Colors.amber[200]
    ///                 : Colors.blue[200],
    ///             );
    ///           },
    ///           childCount: 3,
    ///         ),
    ///       ),
    ///       SliverFillRemaining(
    ///         hasScrollBody: false,
    ///         child: Container(
    ///           color: Colors.orange[300],
    ///           child: Padding(
    ///             padding: const EdgeInsets.all(50.0),
    ///             child: FlutterLogo(size: 100),
    ///           ),
    ///         ),
    ///       ),
    ///     ],
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// [SliverFillRemaining] will defer to the size of its [child] if the
    /// [precedingScrollExtent] exceeded the length of the viewport's main axis.
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// In this sample the [SliverFillRemaining] defers to the size of its [child]
    /// because the [precedingScrollExtent] of the [SliverConstraints] has gone
    /// beyond that of the viewport's main axis.
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return CustomScrollView(
    ///     slivers: <Widget>[
    ///       SliverFixedExtentList(
    ///         itemExtent: 130.0,
    ///         delegate: SliverChildBuilderDelegate(
    ///           (BuildContext context, int index) {
    ///             return Container(
    ///               color: index % 2 == 0
    ///                 ? Colors.indigo[200]
    ///                 : Colors.orange[200],
    ///             );
    ///           },
    ///           childCount: 5,
    ///         ),
    ///       ),
    ///       SliverFillRemaining(
    ///         hasScrollBody: false,
    ///         child: Container(
    ///           child: Padding(
    ///             padding: const EdgeInsets.all(50.0),
    ///             child: Icon(
    ///               Icons.pan_tool,
    ///               size: 60,
    ///               color: Colors.blueGrey,
    ///             ),
    ///           ),
    ///         ),
    ///       ),
    ///     ],
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// For [ScrollPhysics] that allow overscroll, such as
    /// [BouncingScrollPhysics], setting the [fillOverscroll] flag to true allows
    /// the size of the [child] to _stretch_, filling the overscroll area. It does
    /// this regardless of the path chosen to provide the child's size.
    ///
    /// {@animation 250 500 https://flutter.github.io/assets-for-api-docs/assets/widgets/sliver_fill_remaining_fill_overscroll.mp4}
    ///
    /// {@tool sample --template=stateless_widget_scaffold}
    ///
    /// In this sample the [SliverFillRemaining]'s child stretches to fill the
    /// overscroll area when [fillOverscroll] is true. This sample also features a
    /// button that is pinned to the bottom of the sliver, regardless of size or
    /// overscroll behavior. Try switching [fillOverscroll] to see the difference.
    ///
    /// This sample only shows the overscroll behavior on devices that support
    /// overscroll.
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return CustomScrollView(
    ///     // The ScrollPhysics are overridden here to illustrate the functionality
    ///     // of fillOverscroll on all devices this sample may be run on.
    ///     // fillOverscroll only changes the behavior of your layout when applied
    ///     // to Scrollables that allow for overscroll. BouncingScrollPhysics are
    ///     // one example, which are provided by default on the iOS platform.
    ///     physics: BouncingScrollPhysics(),
    ///     slivers: <Widget>[
    ///       SliverToBoxAdapter(
    ///         child: Container(
    ///           color: Colors.tealAccent[700],
    ///           height: 150.0,
    ///         ),
    ///       ),
    ///       SliverFillRemaining(
    ///         hasScrollBody: false,
    ///         // Switch for different overscroll behavior in your layout.
    ///         // If your ScrollPhysics do not allow for overscroll, setting
    ///         // fillOverscroll to true will have no effect.
    ///         fillOverscroll: true,
    ///         child: Container(
    ///           color: Colors.teal[100],
    ///           child: Align(
    ///             alignment: Alignment.bottomCenter,
    ///             child: Padding(
    ///               padding: const EdgeInsets.all(16.0),
    ///               child: RaisedButton(
    ///                 onPressed: () {
    ///                   /* Place your onPressed code here! */
    ///                 },
    ///                 child: Text('Bottom Pinned Button!'),
    ///               ),
    ///             ),
    ///           ),
    ///         ),
    ///       ),
    ///     ],
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    ///
    /// See also:
    ///
    ///  * [SliverFillViewport], which sizes its children based on the
    ///    size of the viewport, regardless of what else is in the scroll view.
    ///  * [SliverList], which shows a list of variable-sized children in a
    ///    viewport.
    /// </Summary>
    public class SliverFillRemaining : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a sliver that fills the remaining space in the viewport.
        /// </Summary>
        public SliverFillRemaining(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool hasScrollBody = true, bool fillOverscroll = false)
        : base(key: key)
        {
            this.Child = child;
            this.HasScrollBody = hasScrollBody;
            this.FillOverscroll = fillOverscroll;
        }
        /// <Summary>
        /// Doc
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// Indicates whether the child has a scrollable body, this value cannot be
        /// null.
        ///
        /// Defaults to true such that the child will extend beyond the viewport and
        /// scroll, as seen in [NestedScrollView].
        ///
        /// Setting this value to false will allow the child to fill the remainder of
        /// the viewport and not extend further. However, if the
        /// [precedingScrollExtent] of the [SliverConstraints] and/or the [child]'s
        /// extent exceeds the size of the viewport, the sliver will defer to the
        /// child's size rather than overriding it.
        /// </Summary>
        public virtual bool HasScrollBody { get; set; }
        /// <Summary>
        /// Indicates whether the child should stretch to fill the overscroll area
        /// created by certain scroll physics, such as iOS' default scroll physics.
        /// This value cannot be null. This flag is only relevant when the
        /// [hasScrollBody] value is false.
        ///
        /// Defaults to false, meaning the default behavior is for the child to
        /// maintain its size and not extend into the overscroll area.
        /// </Summary>
        public virtual bool FillOverscroll { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (HasScrollBody) return new _SliverFillRemainingWithScrollable(child: Child);
            if (!FillOverscroll) return new _SliverFillRemainingWithoutScrollable(child: Child);
            return new _SliverFillRemainingAndOverscroll(child: Child);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Widget>("child", Child));
            List<string> flags = new List<string>() { };
            if (flags.IsEmpty()) flags.Add("nonscrollable");
            properties.Add(new IterableProperty<string>("mode", flags));
        }



    }


    public class _SliverFillRemainingWithScrollable : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _SliverFillRemainingWithScrollable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {

        }

        public new FlutterSDK.Rendering.Sliverfill.RenderSliverFillRemainingWithScrollable CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new RenderSliverFillRemainingWithScrollable();


    }


    public class _SliverFillRemainingWithoutScrollable : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _SliverFillRemainingWithoutScrollable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {

        }

        public new FlutterSDK.Rendering.Sliverfill.RenderSliverFillRemaining CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new RenderSliverFillRemaining();


    }


    public class _SliverFillRemainingAndOverscroll : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _SliverFillRemainingAndOverscroll(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {

        }

        public new FlutterSDK.Rendering.Sliverfill.RenderSliverFillRemainingAndOverscroll CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new RenderSliverFillRemainingAndOverscroll();


    }

}
