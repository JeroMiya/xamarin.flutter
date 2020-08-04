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
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
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
namespace FlutterSDK.Material.Mergeablematerial
{
    internal static class MergeablematerialDefaultClass
    {
    }

    /// <Summary>
    /// The base type for [MaterialSlice] and [MaterialGap].
    ///
    /// All [MergeableMaterialItem] objects need a [LocalKey].
    /// </Summary>
    public interface IMergeableMaterialItem
    {
        FlutterSDK.Foundation.Key.LocalKey Key { get; }
    }


    /// <Summary>
    /// The base type for [MaterialSlice] and [MaterialGap].
    ///
    /// All [MergeableMaterialItem] objects need a [LocalKey].
    /// </Summary>
    public class MergeableMaterialItem
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        ///
        /// The argument is the [key], which must not be null.
        /// </Summary>
        public MergeableMaterialItem(FlutterSDK.Foundation.Key.LocalKey key)
        : base()
        {
            this.Key = key;
        }
        /// <Summary>
        /// The key for this item of the list.
        ///
        /// The key is used to match parts of the mergeable material from frame to
        /// frame so that state is maintained appropriately even as slices are added
        /// or removed.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Key.LocalKey Key { get; set; }
    }


    /// <Summary>
    /// A class that can be used as a child to [MergeableMaterial]. It is a slice
    /// of [Material] that animates merging with other slices.
    ///
    /// All [MaterialSlice] objects need a [LocalKey].
    /// </Summary>
    public class MaterialSlice : FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem
    {
        /// <Summary>
        /// Creates a slice of [Material] that's mergeable within a
        /// [MergeableMaterial].
        /// </Summary>
        public MaterialSlice(FlutterSDK.Foundation.Key.LocalKey key = default(FlutterSDK.Foundation.Key.LocalKey), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key)
        {
            this.Child = child;
        }
        /// <Summary>
        /// The contents of this slice.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

    }


    /// <Summary>
    /// A class that represents a gap within [MergeableMaterial].
    ///
    /// All [MaterialGap] objects need a [LocalKey].
    /// </Summary>
    public class MaterialGap : FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem
    {
        /// <Summary>
        /// Creates a Material gap with a given size.
        /// </Summary>
        public MaterialGap(FlutterSDK.Foundation.Key.LocalKey key = default(FlutterSDK.Foundation.Key.LocalKey), double size = 16.0)
        : base(key)
        {
            this.Size = size;
        }
        /// <Summary>
        /// The main axis extent of this gap. For example, if the [MergeableMaterial]
        /// is vertical, then this is the height of the gap.
        /// </Summary>
        public virtual double Size { get; set; }

    }


    /// <Summary>
    /// Displays a list of [MergeableMaterialItem] children. The list contains
    /// [MaterialSlice] items whose boundaries are either "merged" with adjacent
    /// items or separated by a [MaterialGap]. The [children] are distributed along
    /// the given [mainAxis] in the same way as the children of a [ListBody]. When
    /// the list of children changes, gaps are automatically animated open or closed
    /// as needed.
    ///
    /// To enable this widget to correlate its list of children with the previous
    /// one, each child must specify a key.
    ///
    /// When a new gap is added to the list of children the adjacent items are
    /// animated apart. Similarly when a gap is removed the adjacent items are
    /// brought back together.
    ///
    /// When a new slice is added or removed, the app is responsible for animating
    /// the transition of the slices, while the gaps will be animated automatically.
    ///
    /// See also:
    ///
    ///  * [Card], a piece of material that does not support splitting and merging
    ///    but otherwise looks the same.
    /// </Summary>
    public class MergeableMaterial : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a mergeable Material list of items.
        /// </Summary>
        public MergeableMaterial(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis mainAxis = default(FlutterSDK.Painting.Basictypes.Axis), int elevation = 2, bool hasDividers = false, List<FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem> children = default(List<FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem>))
        : base(key: key)
        {
            this.MainAxis = mainAxis;
            this.Elevation = elevation;
            this.HasDividers = hasDividers;
            this.Children = children;
        }
        /// <Summary>
        /// The children of the [MergeableMaterial].
        /// </Summary>
        public virtual List<FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem> Children { get; set; }
        /// <Summary>
        /// The main layout axis.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.Axis MainAxis { get; set; }
        /// <Summary>
        /// The z-coordinate at which to place all the [Material] slices.
        ///
        /// The following elevations have defined shadows: 1, 2, 3, 4, 6, 8, 9, 12, 16, 24
        ///
        /// Defaults to 2, the appropriate elevation for cards.
        ///
        /// This uses [kElevationToShadow] to simulate shadows, it does not use
        /// [Material]'s arbitrary elevation feature.
        /// </Summary>
        public virtual int Elevation { get; set; }
        /// <Summary>
        /// Whether connected pieces of [MaterialSlice] have dividers between them.
        /// </Summary>
        public virtual bool HasDividers { get; set; }

        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<Axis>("mainAxis", MainAxis));
            properties.Add(new DoubleProperty("elevation", Elevation.ToDouble()));
        }




        public new FlutterSDK.Material.Mergeablematerial._MergeableMaterialState CreateState() => new _MergeableMaterialState();


    }


    public class _AnimationTuple
    {
        public _AnimationTuple(FlutterSDK.Animation.Animationcontroller.AnimationController controller = default(FlutterSDK.Animation.Animationcontroller.AnimationController), FlutterSDK.Animation.Animations.CurvedAnimation startAnimation = default(FlutterSDK.Animation.Animations.CurvedAnimation), FlutterSDK.Animation.Animations.CurvedAnimation endAnimation = default(FlutterSDK.Animation.Animations.CurvedAnimation), FlutterSDK.Animation.Animations.CurvedAnimation gapAnimation = default(FlutterSDK.Animation.Animations.CurvedAnimation), double gapStart = 0.0)
        {
            this.Controller = controller;
            this.StartAnimation = startAnimation;
            this.EndAnimation = endAnimation;
            this.GapAnimation = gapAnimation;
            this.GapStart = gapStart;
        }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; set; }
        public virtual FlutterSDK.Animation.Animations.CurvedAnimation StartAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animations.CurvedAnimation EndAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animations.CurvedAnimation GapAnimation { get; set; }
        public virtual double GapStart { get; set; }
    }


    public class _MergeableMaterialState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Mergeablematerial.MergeableMaterial>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _MergeableMaterialState()
        { }
        internal virtual List<FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem> _Children { get; set; }
        internal virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, FlutterSDK.Material.Mergeablematerial._AnimationTuple> _AnimationTuples { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Children = List<MergeableMaterialItem>.From(Widget.Children);
            for (int i = 0; i < _Children.Count; i += 1)
            {
                MergeableMaterialItem child = _Children[i];
                if (child is MaterialGap)
                {
                    _InitGap(((MaterialGap)child));
                    _AnimationTuples[((MaterialGap)child).Key].Controller.Value = 1.0;
                }

            }


        }




        private void _InitGap(FlutterSDK.Material.Mergeablematerial.MaterialGap gap)
        {
            AnimationController controller = new AnimationController(duration: ThemeDefaultClass.KThemeAnimationDuration, vsync: this);
            CurvedAnimation startAnimation = new CurvedAnimation(parent: controller, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            CurvedAnimation endAnimation = new CurvedAnimation(parent: controller, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            CurvedAnimation gapAnimation = new CurvedAnimation(parent: controller, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            controller.AddListener(_HandleTick);
            _AnimationTuples[gap.Key] = new _AnimationTuple(controller: controller, startAnimation: startAnimation, endAnimation: endAnimation, gapAnimation: gapAnimation);
        }




        public new void Dispose()
        {
            foreach (MergeableMaterialItem child in _Children)
            {
                if (child is MaterialGap) _AnimationTuples[child.Key].Controller.Dispose();
            }

            base.Dispose();
        }




        private void _HandleTick()
        {
            SetState(() =>
            {
            }
            );
        }




        private bool _DebugHasConsecutiveGaps(List<FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem> children)
        {
            for (int i = 0; i < Widget.Children.Count - 1; i += 1)
            {
                if (Widget.Children[i] is MaterialGap && Widget.Children[i + 1] is MaterialGap) return true;
            }

            return false;
        }




        private bool _DebugGapsAreValid(List<FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem> children)
        {
            if (_DebugHasConsecutiveGaps(children)) return false;
            if (children.IsNotEmpty)
            {
                if (((MaterialGap)children.First) is MaterialGap || ((MaterialGap)children.Last()) is MaterialGap) return false;
            }

            return true;
        }




        private void _InsertChild(int index, FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem child)
        {
            _Children.Insert(index, child);
            if (child is MaterialGap) _InitGap(child);
        }




        private void _RemoveChild(int index)
        {
            MergeableMaterialItem child = _Children.RemoveAt(index);
            if (child is MaterialGap) _AnimationTuples[child.Key] = null;
        }




        private bool _IsClosingGap(int index)
        {
            if (index < _Children.Count - 1 && _Children[index] is MaterialGap)
            {
                return _AnimationTuples[((MaterialGap)_Children[index]).Key].Controller.Status == AnimationStatus.Reverse;
            }

            return false;
        }




        private void _RemoveEmptyGaps()
        {
            int j = 0;
            while (j < _Children.Count)
            {
                if (_Children[j] is MaterialGap && _AnimationTuples[_Children[j].Key].Controller.Status == AnimationStatus.Dismissed)
                {
                    _RemoveChild(j);
                }
                else
                {
                    j += 1;
                }

            }

        }




        public new void DidUpdateWidget(FlutterSDK.Material.Mergeablematerial.MergeableMaterial oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            HashSet<LocalKey> oldKeys = oldWidget.Children.Map((MergeableMaterialItem child) => =>child.Key).ToSet();
            HashSet<LocalKey> newKeys = Widget.Children.Map((MergeableMaterialItem child) => =>child.Key).ToSet();
            HashSet<LocalKey> newOnly = newKeys.Difference(oldKeys);
            HashSet<LocalKey> oldOnly = oldKeys.Difference(newKeys);
            List<MergeableMaterialItem> newChildren = Widget.Children;
            int i = 0;
            int j = 0;

            _RemoveEmptyGaps();
            while (i < newChildren.Count && j < _Children.Count)
            {
                if (newOnly.Contains(newChildren[i].Key) || oldOnly.Contains(_Children[j].Key))
                {
                    int startNew = i;
                    int startOld = j;
                    while (newOnly.Contains(newChildren[i].Key)) i += 1;
                    while (oldOnly.Contains(_Children[j].Key) || _IsClosingGap(j)) j += 1;
                    int newLength = i - startNew;
                    int oldLength = j - startOld;
                    if (newLength > 0)
                    {
                        if (oldLength > 1 || oldLength == 1 && ((MaterialSlice)_Children[startOld]) is MaterialSlice)
                        {
                            if (newLength == 1 && ((MaterialGap)newChildren[startNew]) is MaterialGap)
                            {
                                double gapSizeSum = 0.0;
                                while (startOld < j)
                                {
                                    MergeableMaterialItem child = ((MaterialSlice)_Children[startOld]);
                                    if (((MaterialGap)child) is MaterialGap)
                                    {
                                        MaterialGap gap = ((MaterialGap)child);
                                        gapSizeSum += gap.Size;
                                    }

                                    _RemoveChild(startOld);
                                    j -= 1;
                                }

                                _InsertChild(startOld, newChildren[startNew]);
                                _AnimationTuples[newChildren[startNew].Key]..GapStart = gapSizeSum.Controller.Forward(;
                                j += 1;
                            }
                            else
                            {
                                for (int k = 0; k < oldLength; k += 1) _RemoveChild(startOld);
                                for (int k = 0; k < newLength; k += 1) _InsertChild(startOld + k, newChildren[startNew + k]);
                                j += newLength - oldLength;
                            }

                        }
                        else if (oldLength == 1)
                        {
                            if (newLength == 1 && ((MaterialGap)newChildren[startNew]) is MaterialGap && _Children[startOld].Key == ((MaterialGap)newChildren[startNew]).Key)
                            {
                                _AnimationTuples[((MaterialGap)newChildren[startNew]).Key].Controller.Forward();
                            }
                            else
                            {
                                double gapSize = _GetGapSize(startOld);
                                _RemoveChild(startOld);
                                for (int k = 0; k < newLength; k += 1) _InsertChild(startOld + k, newChildren[startNew + k]);
                                j += newLength - 1;
                                double gapSizeSum = 0.0;
                                for (int k = startNew; k < i; k += 1)
                                {
                                    MergeableMaterialItem newChild = newChildren[k];
                                    if (((MaterialGap)newChild) is MaterialGap)
                                    {
                                        gapSizeSum += ((MaterialGap)newChild).Size;
                                    }

                                }

                                for (int k = startNew; k < i; k += 1)
                                {
                                    MergeableMaterialItem newChild = newChildren[k];
                                    if (newChild is MaterialGap)
                                    {
                                        _AnimationTuples[((MaterialGap)newChild).Key].GapStart = gapSize * ((MaterialGap)newChild).Size / gapSizeSum;
                                        _AnimationTuples[((MaterialGap)newChild).Key].Controller..Value = 0.0;
                                        _AnimationTuples[((MaterialGap)newChild).Key].Controller.Forward();
                                    }

                                }

                            }

                        }
                        else
                        {
                            for (int k = 0; k < newLength; k += 1)
                            {
                                MergeableMaterialItem newChild = newChildren[startNew + k];
                                _InsertChild(startOld + k, newChild);
                                if (((MaterialGap)newChild) is MaterialGap)
                                {
                                    _AnimationTuples[((MaterialGap)newChild).Key].Controller.Forward();
                                }

                            }

                            j += newLength;
                        }

                    }
                    else
                    {
                        if (oldLength > 1 || oldLength == 1 && ((MaterialSlice)_Children[startOld]) is MaterialSlice)
                        {
                            double gapSizeSum = 0.0;
                            while (startOld < j)
                            {
                                MergeableMaterialItem child = ((MaterialSlice)_Children[startOld]);
                                if (((MaterialGap)child) is MaterialGap)
                                {
                                    gapSizeSum += ((MaterialGap)child).Size;
                                }

                                _RemoveChild(startOld);
                                j -= 1;
                            }

                            if (gapSizeSum != 0.0)
                            {
                                MaterialGap gap = new MaterialGap(key: new UniqueKey(), size: gapSizeSum);
                                _InsertChild(startOld, gap);
                                _AnimationTuples[gap.Key].GapStart = 0.0;
                                _AnimationTuples[gap.Key].Controller..Value = 1.0;
                                _AnimationTuples[gap.Key].Controller.Reverse();
                                j += 1;
                            }

                        }
                        else if (oldLength == 1)
                        {
                            MaterialGap gap = _Children[startOld] as MaterialGap;
                            _AnimationTuples[gap.Key].GapStart = 0.0;
                            _AnimationTuples[gap.Key].Controller.Reverse();
                        }

                    }

                }
                else
                {
                    if ((((MaterialGap)_Children[j]) is MaterialGap) == (((MaterialGap)newChildren[i]) is MaterialGap))
                    {
                        ((MaterialGap)_Children[j]) = ((MaterialGap)newChildren[i]);
                        i += 1;
                        j += 1;
                    }
                    else
                    {

                        j += 1;
                    }

                }

            }

            while (j < _Children.Count) _RemoveChild(j);
            while (i < newChildren.Count)
            {
                _InsertChild(j, newChildren[i]);
                i += 1;
                j += 1;
            }

        }




        private FlutterSDK.Painting.Borderradius.BorderRadius _BorderRadius(int index, bool start, bool end)
        {



            Radius cardRadius = MaterialDefaultClass.KMaterialEdges[MaterialType.Card].TopLeft;
            Radius startRadius = Dart.UiDefaultClass.Radius.Zero;
            Radius endRadius = Dart.UiDefaultClass.Radius.Zero;
            if (index > 0 && _Children[index - 1] is MaterialGap)
            {
                startRadius = Dart.UI.UiDefaultClass.Radius.Lerp(Dart.UiDefaultClass.Radius.Zero, cardRadius, _AnimationTuples[((MaterialGap)_Children[index - 1]).Key].StartAnimation.Value);
            }

            if (index < _Children.Count - 2 && _Children[index + 1] is MaterialGap)
            {
                endRadius = Dart.UI.UiDefaultClass.Radius.Lerp(Dart.UiDefaultClass.Radius.Zero, cardRadius, _AnimationTuples[((MaterialGap)_Children[index + 1]).Key].EndAnimation.Value);
            }

            if (Widget.MainAxis == Axis.Vertical)
            {
                return BorderRadius.Vertical(top: start ? cardRadius : startRadius, bottom: end ? cardRadius : endRadius);
            }
            else
            {
                return BorderRadius.Horizontal(left: start ? cardRadius : startRadius, right: end ? cardRadius : endRadius);
            }

        }




        private double _GetGapSize(int index)
        {
            MaterialGap gap = _Children[index] as MaterialGap;
            return Dart.UI.UiDefaultClass.LerpDouble(_AnimationTuples[gap.Key].GapStart, gap.Size, _AnimationTuples[gap.Key].GapAnimation.Value);
        }




        private bool _WillNeedDivider(int index)
        {
            if (index < 0) return false;
            if (index >= _Children.Count) return false;
            return _Children[index] is MaterialSlice || _IsClosingGap(index);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _RemoveEmptyGaps();
            List<Widget> widgets = new List<Widget>() { };
            List<Widget> slices = new List<Widget>() { };
            int i = default(int);
            for (i = 0; i < _Children.Count; i += 1)
            {
                if (_Children[i] is MaterialGap)
                {

                    widgets.Add(new Container(decoration: new BoxDecoration(color: ThemeDefaultClass.Theme.Of(context).CardColor, borderRadius: _BorderRadius(i - 1, widgets.IsEmpty(), false), shape: BoxShape.Rectangle), child: new ListBody(mainAxis: Widget.MainAxis, children: slices)));
                    slices = new List<Widget>() { };
                    widgets.Add(new SizedBox(width: Widget.MainAxis == Axis.Horizontal ? _GetGapSize(i) : null, height: Widget.MainAxis == Axis.Vertical ? _GetGapSize(i) : null));
                }
                else
                {
                    MaterialSlice slice = _Children[i] as MaterialSlice;
                    Widget child = slice.Child;
                    if (Widget.HasDividers)
                    {
                        bool hasTopDivider = _WillNeedDivider(i - 1);
                        bool hasBottomDivider = _WillNeedDivider(i + 1);
                        Border border = default(Border);
                        BorderSide divider = DividerDefaultClass.Divider.CreateBorderSide(context, width: 0.5);
                        if (i == 0)
                        {
                            border = new Border(bottom: hasBottomDivider ? divider : BordersDefaultClass.BorderSide.None);
                        }
                        else if (i == _Children.Count - 1)
                        {
                            border = new Border(top: hasTopDivider ? divider : BordersDefaultClass.BorderSide.None);
                        }
                        else
                        {
                            border = new Border(top: hasTopDivider ? divider : BordersDefaultClass.BorderSide.None, bottom: hasBottomDivider ? divider : BordersDefaultClass.BorderSide.None);
                        }


                        child = new AnimatedContainer(key: new _MergeableMaterialSliceKey(_Children[i].Key), decoration: new BoxDecoration(border: border), duration: ThemeDefaultClass.KThemeAnimationDuration, curve: CurvesDefaultClass.Curves.FastOutSlowIn, child: child);
                    }

                    slices.Add(new Material(type: MaterialType.Transparency, child: child));
                }

            }

            if (slices.IsNotEmpty)
            {
                widgets.Add(new Container(decoration: new BoxDecoration(color: ThemeDefaultClass.Theme.Of(context).CardColor, borderRadius: _BorderRadius(i - 1, widgets.IsEmpty(), true), shape: BoxShape.Rectangle), child: new ListBody(mainAxis: Widget.MainAxis, children: slices)));
                slices = new List<Widget>() { };
            }

            return new _MergeableMaterialListBody(mainAxis: Widget.MainAxis, boxShadows: ShadowsDefaultClass.KElevationToShadow[Widget.Elevation], items: _Children, children: widgets);
        }



    }


    public class _MergeableMaterialSliceKey : FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>
    {
        public _MergeableMaterialSliceKey(FlutterSDK.Foundation.Key.LocalKey value)
        : base()
        {
            this.Value = value;
        }
        public virtual FlutterSDK.Foundation.Key.LocalKey Value { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool Equals(@Object other)
        {
            return other is _MergeableMaterialSliceKey && other.Value == Value;
        }




    }


    public class _MergeableMaterialListBody : FlutterSDK.Widgets.Basic.ListBody
    {
        public _MergeableMaterialListBody(List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Painting.Basictypes.Axis mainAxis = default(FlutterSDK.Painting.Basictypes.Axis), List<FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem> items = default(List<FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem>), List<FlutterSDK.Painting.Boxshadow.BoxShadow> boxShadows = default(List<FlutterSDK.Painting.Boxshadow.BoxShadow>))
        : base(children: children, mainAxis: mainAxis)
        {
            this.Items = items;
            this.BoxShadows = boxShadows;
        }
        public virtual List<FlutterSDK.Material.Mergeablematerial.MergeableMaterialItem> Items { get; set; }
        public virtual List<FlutterSDK.Painting.Boxshadow.BoxShadow> BoxShadows { get; set; }

        private FlutterSDK.Painting.Basictypes.AxisDirection _GetDirection(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return BasicDefaultClass.GetAxisDirectionFromAxisReverseAndDirectionality(context, MainAxis, false);
        }




        public new FlutterSDK.Rendering.Listbody.RenderListBody CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderMergeableMaterialListBody(axisDirection: _GetDirection(context), boxShadows: BoxShadows);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Listbody.RenderListBody renderObject)
        {
            _RenderMergeableMaterialListBody materialRenderListBody = renderObject as _RenderMergeableMaterialListBody;
            ..AxisDirection = _GetDirection(context)..BoxShadows = BoxShadows;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            _RenderMergeableMaterialListBody materialRenderListBody = renderObject as _RenderMergeableMaterialListBody;
            ..AxisDirection = _GetDirection(context)..BoxShadows = BoxShadows;
        }



    }


    public class _RenderMergeableMaterialListBody : FlutterSDK.Rendering.Listbody.RenderListBody
    {
        public _RenderMergeableMaterialListBody(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection), List<FlutterSDK.Painting.Boxshadow.BoxShadow> boxShadows = default(List<FlutterSDK.Painting.Boxshadow.BoxShadow>))
        : base(children: children, axisDirection: axisDirection)
        {
            this.BoxShadows = boxShadows;
        }
        public virtual List<FlutterSDK.Painting.Boxshadow.BoxShadow> BoxShadows { get; set; }

        private void _PaintShadows(Canvas canvas, FlutterBinding.UI.Rect rect)
        {
            foreach (BoxShadow boxShadow in BoxShadows)
            {
                Paint paint = boxShadow.ToPaint();
                canvas.DrawRRect(MaterialDefaultClass.KMaterialEdges[MaterialType.Card].ToRRect(rect), paint);
            }

        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            RenderBox child = FirstChild;
            int i = 0;
            while (child != null)
            {
                ListBodyParentData childParentData = child.ParentData as ListBodyParentData;
                Rect rect = (childParentData.Offset + offset) & child.Size;
                if (i % 2 == 0) _PaintShadows(context.Canvas, rect);
                child = childParentData.NextSibling;
                i += 1;
            }

            DefaultPaint(context, offset);
        }



    }

}
