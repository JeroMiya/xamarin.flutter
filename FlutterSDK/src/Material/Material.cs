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
namespace FlutterSDK.Material.Material
{
    public delegate Rect RectCallback();
    internal static class MaterialDefaultClass
    {
        public static Dictionary<FlutterSDK.Material.Material.MaterialType, FlutterSDK.Painting.Borderradius.BorderRadius> KMaterialEdges = default(Dictionary<FlutterSDK.Material.Material.MaterialType, FlutterSDK.Painting.Borderradius.BorderRadius>);
    }

    /// <Summary>
    /// A visual reaction on a piece of [Material].
    ///
    /// To add an ink feature to a piece of [Material], obtain the
    /// [MaterialInkController] via [Material.of] and call
    /// [MaterialInkController.addInkFeature].
    /// </Summary>
    public interface IInkFeature
    {
        void Dispose();
        void PaintFeature(Canvas canvas, Matrix4 transform);
        string ToString();
        FlutterSDK.Rendering.Box.RenderBox ReferenceBox { get; }
        VoidCallback OnRemoved { get; }
        FlutterSDK.Material.Material.MaterialInkController Controller { get; }
    }


    public interface IMaterialInkController { }

    public class MaterialInkController
    {
        public virtual FlutterBinding.UI.Color Color { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Add an [InkFeature], such as an [InkSplash] or an [InkHighlight].
        ///
        /// The ink feature will paint as part of this controller.
        /// </Summary>
        public virtual void AddInkFeature(FlutterSDK.Material.Material.InkFeature feature)
        {
        }


        /// <Summary>
        /// Notifies the controller that one of its ink features needs to repaint.
        /// </Summary>
        public virtual void MarkNeedsPaint()
        {
        }

    }
    public static class MaterialInkControllerMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IMaterialInkController, MaterialInkController> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IMaterialInkController, MaterialInkController>();
        static MaterialInkController GetOrCreate(IMaterialInkController instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new MaterialInkController();
                _table.Add(instance, value);
            }
            return (MaterialInkController)value;
        }
        public static FlutterBinding.UI.Color ColorProperty(this IMaterialInkController instance) => GetOrCreate(instance).Color;
        public static FlutterSDK.Scheduler.Ticker.TickerProvider VsyncProperty(this IMaterialInkController instance) => GetOrCreate(instance).Vsync;
        public static void AddInkFeature(this IMaterialInkController instance, FlutterSDK.Material.Material.InkFeature feature) => GetOrCreate(instance).AddInkFeature(feature);
        public static void MarkNeedsPaint(this IMaterialInkController instance) => GetOrCreate(instance).MarkNeedsPaint();
    }


    /// <Summary>
    /// A piece of material.
    ///
    /// The Material widget is responsible for:
    ///
    /// 1. Clipping: If [clipBehavior] is not [Clip.none], Material clips its widget
    ///    sub-tree to the shape specified by [shape], [type], and [borderRadius].
    ///    By default, [clipBehavior] is [Clip.none] for performance considerations.
    /// 2. Elevation: Material elevates its widget sub-tree on the Z axis by
    ///    [elevation] pixels, and draws the appropriate shadow.
    /// 3. Ink effects: Material shows ink effects implemented by [InkFeature]s
    ///    like [InkSplash] and [InkHighlight] below its children.
    ///
    /// ## The Material Metaphor
    ///
    /// Material is the central metaphor in material design. Each piece of material
    /// exists at a given elevation, which influences how that piece of material
    /// visually relates to other pieces of material and how that material casts
    /// shadows.
    ///
    /// Most user interface elements are either conceptually printed on a piece of
    /// material or themselves made of material. Material reacts to user input using
    /// [InkSplash] and [InkHighlight] effects. To trigger a reaction on the
    /// material, use a [MaterialInkController] obtained via [Material.of].
    ///
    /// In general, the features of a [Material] should not change over time (e.g. a
    /// [Material] should not change its [color], [shadowColor] or [type]).
    /// Changes to [elevation] and [shadowColor] are animated for [animationDuration].
    /// Changes to [shape] are animated if [type] is not [MaterialType.transparency]
    /// and [ShapeBorder.lerp] between the previous and next [shape] values is
    /// supported. Shape changes are also animated for [animationDuration].
    ///
    ///
    /// ## Shape
    ///
    /// The shape for material is determined by [shape], [type], and [borderRadius].
    ///
    ///  - If [shape] is non null, it determines the shape.
    ///  - If [shape] is null and [borderRadius] is non null, the shape is a
    ///    rounded rectangle, with corners specified by [borderRadius].
    ///  - If [shape] and [borderRadius] are null, [type] determines the
    ///    shape as follows:
    ///    - [MaterialType.canvas]: the default material shape is a rectangle.
    ///    - [MaterialType.card]: the default material shape is a rectangle with
    ///      rounded edges. The edge radii is specified by [kMaterialEdges].
    ///    - [MaterialType.circle]: the default material shape is a circle.
    ///    - [MaterialType.button]: the default material shape is a rectangle with
    ///      rounded edges. The edge radii is specified by [kMaterialEdges].
    ///    - [MaterialType.transparency]: the default material shape is a rectangle.
    ///
    /// ## Border
    ///
    /// If [shape] is not null, then its border will also be painted (if any).
    ///
    /// ## Layout change notifications
    ///
    /// If the layout changes (e.g. because there's a list on the material, and it's
    /// been scrolled), a [LayoutChangedNotification] must be dispatched at the
    /// relevant subtree. This in particular means that transitions (e.g.
    /// [SlideTransition]) should not be placed inside [Material] widgets so as to
    /// move subtrees that contain [InkResponse]s, [InkWell]s, [Ink]s, or other
    /// widgets that use the [InkFeature] mechanism. Otherwise, in-progress ink
    /// features (e.g., ink splashes and ink highlights) won't move to account for
    /// the new layout.
    ///
    /// See also:
    ///
    ///  * [MergeableMaterial], a piece of material that can split and re-merge.
    ///  * [Card], a wrapper for a [Material] of [type] [MaterialType.card].
    ///  * <https://material.io/design/>
    /// </Summary>
    public class Material : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public Material(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Material.MaterialType type = default(FlutterSDK.Material.Material.MaterialType), double elevation = 0.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Borderradius.BorderRadiusGeometry borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), bool borderOnForeground = true, FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), TimeSpan animationDuration = default(TimeSpan), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
    public virtual FlutterSDK.Material.Material.MaterialType Type { get; set; }
    public virtual double Elevation { get; set; }
    public virtual FlutterBinding.UI.Color Color { get; set; }
    public virtual FlutterBinding.UI.Color ShadowColor { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
    public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
    public virtual bool BorderOnForeground { get; set; }
    public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
    public virtual TimeSpan AnimationDuration { get; set; }
    public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry BorderRadius { get; set; }
    public virtual double DefaultSplashRadius { get; set; }
    #endregion

    #region methods

    /// <Summary>
    /// The ink controller from the closest instance of this class that
    /// encloses the given context.
    ///
    /// Typical usage is as follows:
    ///
    /// ```dart
    /// MaterialInkController inkController = Material.of(context);
    /// ```
    /// </Summary>
    public virtual FlutterSDK.Material.Material.MaterialInkController Of(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        _RenderInkFeatures result = context.FindAncestorRenderObjectOfType();
        return result;
    }




    public new FlutterSDK.Material.Material._MaterialState CreateState() => new _MaterialState();



    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new EnumProperty<MaterialType>("type", Type));
        properties.Add(new DoubleProperty("elevation", Elevation, defaultValue: 0.0));
        properties.Add(new ColorProperty("color", Color, defaultValue: null));
        properties.Add(new ColorProperty("shadowColor", ShadowColor, defaultValue: new Color(0xFF000000)));
        TextStyle?.DebugFillProperties(properties, prefix: "textStyle.");
        properties.Add(new DiagnosticsProperty<ShapeBorder>("shape", Shape, defaultValue: null));
        properties.Add(new DiagnosticsProperty<bool>("borderOnForeground", BorderOnForeground, defaultValue: true));
        properties.Add(new DiagnosticsProperty<BorderRadiusGeometry>("borderRadius", BorderRadius, defaultValue: null));
    }



    #endregion
}


public class _MaterialState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Material.Material>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
    #region constructors
    public _MaterialState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _InkFeatureRenderer { get; set; }
    #endregion

    #region methods

    private Color _GetBackgroundColor(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        ThemeData theme = ThemeDefaultClass.Theme.Of(context);
        Color color = Widget.Color;
        if (color == null)
        {
            switch (Widget.Type) { case MaterialType.Canvas: color = theme.CanvasColor; break; case MaterialType.Card: color = theme.CardColor; break; default: break; }
        }

        return color;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        Color backgroundColor = _GetBackgroundColor(context);

        Widget contents = Widget.Child;
        if (contents != null)
        {
            contents = new AnimatedDefaultTextStyle(style: Widget.TextStyle ?? ThemeDefaultClass.Theme.Of(context).TextTheme.BodyText2, duration: Widget.AnimationDuration, child: contents);
        }

        contents = new NotificationListener<LayoutChangedNotification>(onNotification: (LayoutChangedNotification notification) =>
        {
            _RenderInkFeatures renderer = _InkFeatureRenderer.CurrentContext.FindRenderObject() as _RenderInkFeatures;
            renderer._DidChangeLayout();
            return false;
        }
        , child: new _InkFeatures(key: _InkFeatureRenderer, color: backgroundColor, child: contents, vsync: this));
        if (Widget.Type == MaterialType.Canvas && Widget.Shape == null && Widget.BorderRadius == null)
        {
            return new AnimatedPhysicalModel(curve: CurvesDefaultClass.Curves.FastOutSlowIn, duration: Widget.AnimationDuration, shape: BoxShape.Rectangle, clipBehavior: Widget.ClipBehavior, borderRadius: BorderradiusDefaultClass.BorderRadius.Zero, elevation: Widget.Elevation, color: ElevationoverlayDefaultClass.ElevationOverlay.ApplyOverlay(context, backgroundColor, Widget.Elevation), shadowColor: Widget.ShadowColor, animateColor: false, child: contents);
        }

        ShapeBorder shape = _GetShape();
        if (Widget.Type == MaterialType.Transparency)
        {
            return _TransparentInterior(context: context, shape: shape, clipBehavior: Widget.ClipBehavior, contents: contents);
        }

        return new _MaterialInterior(curve: CurvesDefaultClass.Curves.FastOutSlowIn, duration: Widget.AnimationDuration, shape: shape, borderOnForeground: Widget.BorderOnForeground, clipBehavior: Widget.ClipBehavior, elevation: Widget.Elevation, color: backgroundColor, shadowColor: Widget.ShadowColor, child: contents);
    }




    private FlutterSDK.Widgets.Framework.Widget _TransparentInterior(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget contents = default(FlutterSDK.Widgets.Framework.Widget))
    {
        _ShapeBorderPaint child = new _ShapeBorderPaint(child: contents, shape: shape);
        if (clipBehavior == Clip.None)
        {
            return child;
        }

        return new ClipPath(child: child, clipper: new ShapeBorderClipper(shape: shape, textDirection: BasicDefaultClass.Directionality.Of(context)), clipBehavior: clipBehavior);
    }




    private FlutterSDK.Painting.Borders.ShapeBorder _GetShape()
    {
        if (Widget.Shape != null) return Widget.Shape;
        if (Widget.BorderRadius != null) return new RoundedRectangleBorder(borderRadius: Widget.BorderRadius);
        switch (Widget.Type) { case MaterialType.Canvas: case MaterialType.Transparency: return new RoundedRectangleBorder(); case MaterialType.Card: case MaterialType.Button: return new RoundedRectangleBorder(borderRadius: Widget.BorderRadius ?? MaterialDefaultClass.KMaterialEdges[Widget.Type]); case MaterialType.Circle: return new CircleBorder(); }
        return new RoundedRectangleBorder();
    }



    #endregion
}


public class _RenderInkFeatures : FlutterSDK.Rendering.Proxybox.RenderProxyBox, IMaterialInkController
{
    #region constructors
    public _RenderInkFeatures(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color))
    : base(child)

}
#endregion

#region fields
public new FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get; set; }
public new FlutterBinding.UI.Color Color { get; set; }
internal virtual List<FlutterSDK.Material.Material.InkFeature> _InkFeatures { get; set; }
#endregion

#region methods

public new void AddInkFeature(FlutterSDK.Material.Material.InkFeature feature)
{


    _InkFeatures = (_InkFeatures == null ? new List<InkFeature>() { } : _InkFeatures);

    _InkFeatures.Add(feature);
    MarkNeedsPaint();
}




private void _RemoveFeature(FlutterSDK.Material.Material.InkFeature feature)
{

    _InkFeatures.Remove(feature);
    MarkNeedsPaint();
}




private void _DidChangeLayout()
{
    if (_InkFeatures != null && _InkFeatures.IsNotEmpty) MarkNeedsPaint();
}




public new bool HitTestSelf(FlutterBinding.UI.Offset position) => true;



public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (_InkFeatures != null && _InkFeatures.IsNotEmpty)
    {
        Canvas canvas = context.Canvas;
        canvas.Save();
        canvas.Translate(offset.Dx, offset.Dy);
        canvas.ClipRect(Dart: uiDefaultClass.Offset.Zero & Size);
        foreach (InkFeature inkFeature in _InkFeatures) inkFeature._Paint(canvas);
        canvas.Restore();
    }

    base.Paint(context, offset);
}



#endregion
}


public class _InkFeatures : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
    #region constructors
    public _InkFeatures(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
    : base(key: key, child: child)

}
#endregion

#region fields
public virtual FlutterBinding.UI.Color Color { get; set; }
public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Material._RenderInkFeatures CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new _RenderInkFeatures(color: Color, vsync: Vsync);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Material._RenderInkFeatures renderObject)
{
    renderObject.Color = Color;

}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    renderObject.Color = Color;

}



#endregion
}


/// <Summary>
/// A visual reaction on a piece of [Material].
///
/// To add an ink feature to a piece of [Material], obtain the
/// [MaterialInkController] via [Material.of] and call
/// [MaterialInkController.addInkFeature].
/// </Summary>
public class InkFeature
{
    #region constructors
    public InkFeature(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController), FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox), VoidCallback onRemoved = default(VoidCallback))
    : base()

}
#endregion

#region fields
internal virtual FlutterSDK.Material.Material._RenderInkFeatures _Controller { get; set; }
public virtual FlutterSDK.Rendering.Box.RenderBox ReferenceBox { get; set; }
public virtual VoidCallback OnRemoved { get; set; }
internal virtual bool _DebugDisposed { get; set; }
public virtual FlutterSDK.Material.Material.MaterialInkController Controller { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// Free up the resources associated with this ink feature.
/// </Summary>
public virtual void Dispose()
{


    _Controller._RemoveFeature(this);
    if (OnRemoved != null) OnRemoved();
}




private void _Paint(Canvas canvas)
{


    List<RenderObject> descendants = new List<RenderObject>() { ReferenceBox };
    RenderObject node = ReferenceBox;
    while (node != _Controller)
    {
        node = node.Parent as RenderObject;

        descendants.Add(node);
    }

    Matrix4 transform = Matrix4.Identity();

    for (int index = descendants.Count - 1; index > 0; index -= 1) descendants[index].ApplyPaintTransform(descendants[index - 1], transform);
    PaintFeature(canvas, transform);
}




/// <Summary>
/// Override this method to paint the ink feature.
///
/// The transform argument gives the coordinate conversion from the coordinate
/// system of the canvas to the coordinate system of the [referenceBox].
/// </Summary>
public virtual void PaintFeature(Canvas canvas, Matrix4 transform)
{
}


#endregion
}


/// <Summary>
/// An interpolation between two [ShapeBorder]s.
///
/// This class specializes the interpolation of [Tween] to use [ShapeBorder.lerp].
/// </Summary>
public class ShapeBorderTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Borders.ShapeBorder>
{
    #region constructors
    public ShapeBorderTween(FlutterSDK.Painting.Borders.ShapeBorder begin = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Painting.Borders.ShapeBorder end = default(FlutterSDK.Painting.Borders.ShapeBorder))
    : base(begin: begin, end: end)

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Returns the value this tween has at the given animation clock value.
/// </Summary>
public new FlutterSDK.Painting.Borders.ShapeBorder Lerp(double t)
{
    return BordersDefaultClass.ShapeBorder.Lerp(Begin, End, t);
}



#endregion
}


/// <Summary>
/// The interior of non-transparent material.
///
/// Animates [elevation], [shadowColor], and [shape].
/// </Summary>
public class _MaterialInterior : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
    #region constructors
    public _MaterialInterior(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), bool borderOnForeground = true, FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), double elevation = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve), TimeSpan duration = default(TimeSpan))
    : base(key: key, curve: curve, duration: duration)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
public virtual bool BorderOnForeground { get; set; }
public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
public virtual double Elevation { get; set; }
public virtual FlutterBinding.UI.Color Color { get; set; }
public virtual FlutterBinding.UI.Color ShadowColor { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Material._MaterialInteriorState CreateState() => new _MaterialInteriorState();



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description)
{
    base.DebugFillProperties(description);
    description.Add(new DiagnosticsProperty<ShapeBorder>("shape", Shape));
    description.Add(new DoubleProperty("elevation", Elevation));
    description.Add(new ColorProperty("color", Color));
    description.Add(new ColorProperty("shadowColor", ShadowColor));
}



#endregion
}


public class _MaterialInteriorState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Material.Material._MaterialInterior>
{
    #region constructors
    public _MaterialInteriorState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _Elevation { get; set; }
    internal virtual FlutterSDK.Animation.Tween.ColorTween _ShadowColor { get; set; }
    internal virtual FlutterSDK.Material.Material.ShapeBorderTween _Border { get; set; }
    #endregion

    #region methods

    public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor)
    {
        _Elevation = visitor(_Elevation, Widget.Elevation, (object value) => =>new Tween<double>(begin: value as double)) as Tween<double>;
        _ShadowColor = visitor(_ShadowColor, Widget.ShadowColor, (object value) => =>new ColorTween(begin: value as Color)) as ColorTween;
        _Border = visitor(_Border, Widget.Shape, (object value) => =>new ShapeBorderTween(begin: value as ShapeBorder)) as ShapeBorderTween;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        ShapeBorder shape = _Border.Evaluate(Animation);
        double elevation = _Elevation.Evaluate(Animation);
        return new PhysicalShape(child: new _ShapeBorderPaint(child: Widget.Child, shape: shape, borderOnForeground: Widget.BorderOnForeground), clipper: new ShapeBorderClipper(shape: shape, textDirection: BasicDefaultClass.Directionality.Of(context)), clipBehavior: Widget.ClipBehavior, elevation: elevation, color: ElevationoverlayDefaultClass.ElevationOverlay.ApplyOverlay(context, Widget.Color, elevation), shadowColor: _ShadowColor.Evaluate(Animation));
    }



    #endregion
}


public class _ShapeBorderPaint : FlutterSDK.Widgets.Framework.StatelessWidget
{
    #region constructors
    public _ShapeBorderPaint(FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), bool borderOnForeground = true)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
public virtual bool BorderOnForeground { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new CustomPaint(child: Child, painter: BorderOnForeground ? null : new _ShapeBorderPainter(Shape, BasicDefaultClass.Directionality.Of(context)), foregroundPainter: BorderOnForeground ? new _ShapeBorderPainter(Shape, BasicDefaultClass.Directionality.Of(context)) : null);
}



#endregion
}


public class _ShapeBorderPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
{
    #region constructors
    public _ShapeBorderPainter(FlutterSDK.Painting.Borders.ShapeBorder border, TextDirection textDirection)

}
#endregion

#region fields
public virtual FlutterSDK.Painting.Borders.ShapeBorder Border { get; set; }
public virtual TextDirection TextDirection { get; set; }
#endregion

#region methods

public new void Paint(Canvas canvas, Size size)
{
    Border.Paint(canvas, Dart: uiDefaultClass.Offset.Zero & size, textDirection: TextDirection);
}




public new bool ShouldRepaint(FlutterSDK.Material.Material._ShapeBorderPainter oldDelegate)
{
    return oldDelegate.Border != Border;
}


public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
{
    return oldDelegate.Border != Border;
}



#endregion
}


/// <Summary>
/// The various kinds of material in material design. Used to
/// configure the default behavior of [Material] widgets.
///
/// See also:
///
///  * [Material], in particular [Material.type].
///  * [kMaterialEdges]
/// </Summary>
public enum MaterialType
{

    /// <Summary>
    /// Rectangle using default theme canvas color.
    /// </Summary>
    Canvas,
    /// <Summary>
    /// Rounded edges, card theme color.
    /// </Summary>
    Card,
    /// <Summary>
    /// A circle, no color by default (used for floating action buttons).
    /// </Summary>
    Circle,
    /// <Summary>
    /// Rounded edges, no color by default (used for [MaterialButton] buttons).
    /// </Summary>
    Button,
    /// <Summary>
    /// A transparent piece of material that draws ink splashes and highlights.
    ///
    /// While the material metaphor describes child widgets as printed on the
    /// material itself and do not hide ink effects, in practice the [Material]
    /// widget draws child widgets on top of the ink effects.
    /// A [Material] with type transparency can be placed on top of opaque widgets
    /// to show ink effects on top of them.
    ///
    /// Prefer using the [Ink] widget for showing ink effects on top of opaque
    /// widgets.
    /// </Summary>
    Transparency,
}

}
