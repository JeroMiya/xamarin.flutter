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
namespace FlutterSDK.Rendering.Layer
{
    internal static class LayerDefaultClass
    {
    }

    /// <Summary>
    /// A composited layer.
    ///
    /// During painting, the render tree generates a tree of composited layers that
    /// are uploaded into the engine and displayed by the compositor. This class is
    /// the base class for all composited layers.
    ///
    /// Most layers can have their properties mutated, and layers can be moved to
    /// different parents. The scene must be explicitly recomposited after such
    /// changes are made; the layer tree does not maintain its own dirty state.
    ///
    /// To composite the tree, create a [SceneBuilder] object, pass it to the
    /// root [Layer] object's [addToScene] method, and then call
    /// [SceneBuilder.build] to obtain a [Scene]. A [Scene] can then be painted
    /// using [Window.render].
    ///
    /// See also:
    ///
    ///  * [RenderView.compositeFrame], which implements this recomposition protocol
    ///    for painting [RenderObject] trees on the display.
    /// </Summary>
    public interface ILayer
    {
        void MarkNeedsAddToScene();
        void DebugMarkClean();
        void UpdateSubtreeNeedsAddToScene();
        void DropChild(FlutterSDK.Foundation.Node.AbstractNode child);
        void AdoptChild(FlutterSDK.Foundation.Node.AbstractNode child);
        void Remove();
        bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool));
        S Find<S>(FlutterBinding.UI.Offset localPosition);
        Iterable<S> FindAll<S>(FlutterBinding.UI.Offset localPosition);
        AnnotationResult<S> FindAllAnnotations<S>(FlutterBinding.UI.Offset localPosition);
        void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset));
        string ToStringShort();
        void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
        object DebugCreator { get; set; }
        FlutterSDK.Rendering.Layer.ContainerLayer Parent { get; }
        bool AlwaysNeedsAddToScene { get; }
        bool DebugSubtreeNeedsAddToScene { get; }
        NativeEngineLayer EngineLayer { get; set; }
        FlutterSDK.Rendering.Layer.Layer NextSibling { get; }
        FlutterSDK.Rendering.Layer.Layer PreviousSibling { get; }
    }


    public interface IAnnotationResult<T> { }

    public class AnnotationResult<T>
    {
        internal virtual List<FlutterSDK.Rendering.Layer.AnnotationEntry<T>> _Entries { get; set; }
        public virtual Iterable<FlutterSDK.Rendering.Layer.AnnotationEntry<T>> Entries { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<T> Annotations { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Add a new entry to the end of the result.
        ///
        /// Usually, entries should be added in order from most specific to least
        /// specific, typically during an upward walk of the tree.
        /// </Summary>
        public virtual void Add(FlutterSDK.Rendering.Layer.AnnotationEntry<T> entry) => _Entries.Add(entry);


    }
    public static class AnnotationResultMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static AnnotationResult<T> GetOrCreate<T>(IAnnotationResult<T> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new AnnotationResult<T>();
                _table.Add(instance, value);
            }
            return (AnnotationResult<T>)value;
        }
        public static Iterable<FlutterSDK.Rendering.Layer.AnnotationEntry<T>> EntriesProperty<T>(this IAnnotationResult<T> instance) => GetOrCreate(instance).Entries;
        public static Iterable<T> AnnotationsProperty<T>(this IAnnotationResult<T> instance) => GetOrCreate(instance).Annotations;
        public static void Add<T>(this IAnnotationResult<T> instance, FlutterSDK.Rendering.Layer.AnnotationEntry<T> entry) => GetOrCreate(instance).Add(entry);
    }


    public interface ILayerLink { }

    public class LayerLink
    {
        internal virtual FlutterSDK.Rendering.Layer.LeaderLayer _Leader { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LeaderLayer Leader { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    }
    public static class LayerLinkMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<ILayerLink, LayerLink> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ILayerLink, LayerLink>();
        static LayerLink GetOrCreate(ILayerLink instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new LayerLink();
                _table.Add(instance, value);
            }
            return (LayerLink)value;
        }
        public static FlutterSDK.Rendering.Layer.LeaderLayer LeaderProperty(this ILayerLink instance) => GetOrCreate(instance).Leader;
        public static string ToString(this ILayerLink instance) => GetOrCreate(instance).ToString();
    }


    /// <Summary>
    /// Information collected for an annotation that is found in the layer tree.
    ///
    /// See also:
    ///
    ///  * [Layer.findAnnotations], which create and use objects of this class.
    /// </Summary>
    public class AnnotationEntry<T>
    {
        public AnnotationEntry(T annotation = default(T), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.Annotation = annotation;
            this.LocalPosition = localPosition;
        }
        public virtual T Annotation { get; set; }
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }

    }


    /// <Summary>
    /// A composited layer.
    ///
    /// During painting, the render tree generates a tree of composited layers that
    /// are uploaded into the engine and displayed by the compositor. This class is
    /// the base class for all composited layers.
    ///
    /// Most layers can have their properties mutated, and layers can be moved to
    /// different parents. The scene must be explicitly recomposited after such
    /// changes are made; the layer tree does not maintain its own dirty state.
    ///
    /// To composite the tree, create a [SceneBuilder] object, pass it to the
    /// root [Layer] object's [addToScene] method, and then call
    /// [SceneBuilder.build] to obtain a [Scene]. A [Scene] can then be painted
    /// using [Window.render].
    ///
    /// See also:
    ///
    ///  * [RenderView.compositeFrame], which implements this recomposition protocol
    ///    for painting [RenderObject] trees on the display.
    /// </Summary>
    public class Layer : FlutterSDK.Foundation.Node.AbstractNode, IDiagnosticableTreeMixin
    {
        public Layer()
        { }
        internal virtual bool _NeedsAddToScene { get; set; }
        internal virtual NativeEngineLayer _EngineLayer { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.Layer _NextSibling { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.Layer _PreviousSibling { get; set; }
        public virtual object DebugCreator { get; set; }
        public virtual FlutterSDK.Rendering.Layer.ContainerLayer Parent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AlwaysNeedsAddToScene { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DebugSubtreeNeedsAddToScene { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual NativeEngineLayer EngineLayer { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Layer.Layer NextSibling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Layer.Layer PreviousSibling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Mark that this layer has changed and [addToScene] needs to be called.
        /// </Summary>
        public virtual void MarkNeedsAddToScene()
        {

            if (_NeedsAddToScene)
            {
                return;
            }

            _NeedsAddToScene = true;
        }




        /// <Summary>
        /// Mark that this layer is in sync with engine.
        ///
        /// This is for debugging and testing purposes only. In release builds
        /// this method has no effect.
        /// </Summary>
        public virtual void DebugMarkClean()
        {

        }




        /// <Summary>
        /// Traverses the layer subtree starting from this layer and determines whether it needs [addToScene].
        ///
        /// A layer needs [addToScene] if any of the following is true:
        ///
        /// - [alwaysNeedsAddToScene] is true.
        /// - [markNeedsAddToScene] has been called.
        /// - Any of its descendants need [addToScene].
        ///
        /// [ContainerLayer] overrides this method to recursively call it on its children.
        /// </Summary>
        public virtual void UpdateSubtreeNeedsAddToScene()
        {
            _NeedsAddToScene = _NeedsAddToScene || AlwaysNeedsAddToScene;
        }




        public new void DropChild(FlutterSDK.Foundation.Node.AbstractNode child)
        {
            if (!AlwaysNeedsAddToScene)
            {
                MarkNeedsAddToScene();
            }

            base.DropChild(child);
        }




        public new void AdoptChild(FlutterSDK.Foundation.Node.AbstractNode child)
        {
            if (!AlwaysNeedsAddToScene)
            {
                MarkNeedsAddToScene();
            }

            base.AdoptChild(child);
        }




        /// <Summary>
        /// Removes this layer from its parent layer's child list.
        ///
        /// This has no effect if the layer's parent is already null.
        /// </Summary>
        public virtual void Remove()
        {
            Parent?._RemoveChild(this);
        }




        /// <Summary>
        /// Search this layer and its subtree for annotations of type `S` at the
        /// location described by `localPosition`.
        ///
        /// This method is called by the default implementation of [find] and
        /// [findAllAnnotations]. Override this method to customize how the layer
        /// should search for annotations, or if the layer has its own annotations to
        /// add.
        ///
        /// The default implementation simply returns `false`, which means neither
        /// the layer nor its children has annotations, and the annotation search
        /// is not absorbed either (see below for explanation).
        ///
        /// ## About layer annotations
        ///
        /// {@template flutter.rendering.layer.findAnnotations.aboutAnnotations}
        /// An annotation is an optional object of any type that can be carried with a
        /// layer. An annotation can be found at a location as long as the owner layer
        /// contains the location and is walked to.
        ///
        /// The annotations are searched by first visiting each child recursively,
        /// then this layer, resulting in an order from visually front to back.
        /// Annotations must meet the given restrictions, such as type and position.
        ///
        /// The common way for a value to be found here is by pushing an
        /// [AnnotatedRegionLayer] into the layer tree, or by adding the desired
        /// annotation by overriding [findAnnotations].
        /// {@endtemplate}
        ///
        /// ## Parameters and return value
        ///
        /// The [result] parameter is where the method outputs the resulting
        /// annotations. New annotations found during the walk are added to the tail.
        ///
        /// The [onlyFirst] parameter indicates that, if true, the search will stop
        /// when it finds the first qualified annotation; otherwise, it will walk the
        /// entire subtree.
        ///
        /// The return value indicates the opacity of this layer and its subtree at
        /// this position. If it returns true, then this layer's parent should skip
        /// the children behind this layer. In other words, it is opaque to this type
        /// of annotation and has absorbed the search so that its siblings behind it
        /// are not aware of the search. If the return value is false, then the parent
        /// might continue with other siblings.
        ///
        /// The return value does not affect whether the parent adds its own
        /// annotations; in other words, if a layer is supposed to add an annotation,
        /// it will always add it even if its children are opaque to this type of
        /// annotation. However, the opacity that the parents return might be affected
        /// by their children, hence making all of its ancestors opaque to this type
        /// of annotation.
        /// </Summary>
        public virtual bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
        {
            return false;
        }




        /// <Summary>
        /// Search this layer and its subtree for the first annotation of type `S`
        /// under the point described by `localPosition`.
        ///
        /// Returns null if no matching annotations are found.
        ///
        /// By default this method simply calls [findAnnotations] with `onlyFirst:
        /// true` and returns the annotation of the first result. Prefer overriding
        /// [findAnnotations] instead of this method, because during an annotation
        /// search, only [findAnnotations] is recursively called, while custom
        /// behavior in this method is ignored.
        ///
        /// ## About layer annotations
        ///
        /// {@macro flutter.rendering.layer.findAnnotations.aboutAnnotations}
        ///
        /// See also:
        ///
        ///  * [findAllAnnotations], which is similar but returns all annotations found
        ///    at the given position.
        ///  * [AnnotatedRegionLayer], for placing values in the layer tree.
        /// </Summary>
        public virtual S Find<S>(FlutterBinding.UI.Offset localPosition)
        {
            AnnotationResult<S> result = new AnnotationResult<S>();
            FindAnnotations(result, localPosition, onlyFirst: true);
            return result.Entries.IsEmpty() ? null : result.Entries.First.Annotation;
        }




        /// <Summary>
        /// Search this layer and its subtree for all annotations of type `S` under
        /// the point described by `localPosition`.
        ///
        /// Returns a result with empty entries if no matching annotations are found.
        ///
        /// By default this method simply calls [findAnnotations] with `onlyFirst:
        /// false` and returns the annotations of its result. Prefer overriding
        /// [findAnnotations] instead of this method, because during an annotation
        /// search, only [findAnnotations] is recursively called, while custom
        /// behavior in this method is ignored.
        ///
        /// ## About layer annotations
        ///
        /// {@macro flutter.rendering.layer.findAnnotations.aboutAnnotations}
        ///
        /// See also:
        ///
        ///  * [find], which is similar but returns the first annotation found at the
        ///    given position.
        ///  * [findAllAnnotations], which is similar but returns an
        ///    [AnnotationResult], which contains more information, such as the local
        ///    position of the event related to each annotation, and is equally fast,
        ///    hence is preferred over [findAll].
        ///  * [AnnotatedRegionLayer], for placing values in the layer tree.
        /// </Summary>
        public virtual Iterable<S> FindAll<S>(FlutterBinding.UI.Offset localPosition)
        {
            AnnotationResult<S> result = FindAllAnnotations(localPosition);
            return result.Entries.Map((AnnotationEntry<S> entry) => =>entry.Annotation);
        }




        /// <Summary>
        /// Search this layer and its subtree for all annotations of type `S` under
        /// the point described by `localPosition`.
        ///
        /// Returns a result with empty entries if no matching annotations are found.
        ///
        /// By default this method simply calls [findAnnotations] with `onlyFirst:
        /// false` and returns the annotations of its result. Prefer overriding
        /// [findAnnotations] instead of this method, because during an annotation
        /// search, only [findAnnotations] is recursively called, while custom
        /// behavior in this method is ignored.
        ///
        /// ## About layer annotations
        ///
        /// {@macro flutter.rendering.layer.findAnnotations.aboutAnnotations}
        ///
        /// See also:
        ///
        ///  * [find], which is similar but returns the first annotation found at the
        ///    given position.
        ///  * [AnnotatedRegionLayer], for placing values in the layer tree.
        /// </Summary>
        public virtual AnnotationResult<S> FindAllAnnotations<S>(FlutterBinding.UI.Offset localPosition)
        {
            AnnotationResult<S> result = new AnnotationResult<S>();
            FindAnnotations(result, localPosition, onlyFirst: false);
            return result;
        }




        /// <Summary>
        /// Override this method to upload this layer to the engine.
        ///
        /// Return the engine layer for retained rendering. When there's no
        /// corresponding engine layer, null is returned.
        /// </Summary>
        public virtual void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
        {
        }


        private void _AddToSceneWithRetainedRendering(SceneBuilder builder)
        {
            if (!_NeedsAddToScene && _EngineLayer != null)
            {
                builder.AddRetained(_EngineLayer);
                return;
            }

            AddToScene(builder);
            _NeedsAddToScene = false;
        }




        public new string ToStringShort() => $"'{base.ToStringShort()}{Owner == null ? " DETACHED":""}'";



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<object>("owner", Owner, level: Parent != null ? DiagnosticLevel.Hidden : DiagnosticLevel.Info, defaultValue: null));
            properties.Add(new DiagnosticsProperty<object>("creator", DebugCreator, defaultValue: null, level: DiagnosticLevel.Debug));
            properties.Add(new DiagnosticsProperty<string>("engine layer", DiagnosticsDefaultClass.DescribeIdentity(_EngineLayer)));
        }



    }


    /// <Summary>
    /// A composited layer containing a [Picture].
    ///
    /// Picture layers are always leaves in the layer tree.
    /// </Summary>
    public class PictureLayer : FlutterSDK.Rendering.Layer.Layer
    {
        public PictureLayer(FlutterBinding.UI.Rect canvasBounds)
        {
            this.CanvasBounds = canvasBounds;
        }
        public virtual FlutterBinding.UI.Rect CanvasBounds { get; set; }
        internal virtual SKPicture _Picture { get; set; }
        internal virtual bool _IsComplexHint { get; set; }
        internal virtual bool _WillChangeHint { get; set; }
        public virtual SKPicture Picture { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsComplexHint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool WillChangeHint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
        {
            builder.AddPicture(layerOffset, Picture, isComplexHint: IsComplexHint, willChangeHint: WillChangeHint);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Rect>("paint bounds", CanvasBounds));
            properties.Add(new DiagnosticsProperty<string>("picture", DiagnosticsDefaultClass.DescribeIdentity(_Picture)));
            properties.Add(new DiagnosticsProperty<string>("raster cache hints", $"'isComplex = {IsComplexHint}, willChange = {WillChangeHint}'"));
        }




        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
        {
            return false;
        }



    }


    /// <Summary>
    /// A composited layer that maps a backend texture to a rectangle.
    ///
    /// Backend textures are images that can be applied (mapped) to an area of the
    /// Flutter view. They are created, managed, and updated using a
    /// platform-specific texture registry. This is typically done by a plugin
    /// that integrates with host platform video player, camera, or OpenGL APIs,
    /// or similar image sources.
    ///
    /// A texture layer refers to its backend texture using an integer ID. Texture
    /// IDs are obtained from the texture registry and are scoped to the Flutter
    /// view. Texture IDs may be reused after deregistration, at the discretion
    /// of the registry. The use of texture IDs currently unknown to the registry
    /// will silently result in a blank rectangle.
    ///
    /// Once inserted into the layer tree, texture layers are repainted autonomously
    /// as dictated by the backend (e.g. on arrival of a video frame). Such
    /// repainting generally does not involve executing Dart code.
    ///
    /// Texture layers are always leaves in the layer tree.
    ///
    /// See also:
    ///
    ///  * <https://api.flutter.dev/javadoc/io/flutter/view/TextureRegistry.html>
    ///    for how to create and manage backend textures on Android.
    ///  * <https://api.flutter.dev/objcdoc/Protocols/FlutterTextureRegistry.html>
    ///    for how to create and manage backend textures on iOS.
    /// </Summary>
    public class TextureLayer : FlutterSDK.Rendering.Layer.Layer
    {
        public TextureLayer(FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), int textureId = default(int), bool freeze = false)
        : base()
        {
            this.Rect = rect;
            this.TextureId = textureId;
            this.Freeze = freeze;
        }
        public virtual FlutterBinding.UI.Rect Rect { get; set; }
        public virtual int TextureId { get; set; }
        public virtual bool Freeze { get; set; }

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
        {
            Rect shiftedRect = layerOffset == Dart:uiDefaultClass.Offset.Zero? Rect:Rect.Shift(layerOffset);
            builder.AddTexture(TextureId, offset: shiftedRect.TopLeft, width: shiftedRect.Width, height: shiftedRect.Height, freeze: Freeze);
        }




        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
        {
            return false;
        }



    }


    /// <Summary>
    /// A layer that shows an embedded [UIView](https://developer.apple.com/documentation/uikit/uiview)
    /// on iOS.
    /// </Summary>
    public class PlatformViewLayer : FlutterSDK.Rendering.Layer.Layer
    {
        public PlatformViewLayer(FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), int viewId = default(int), FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation hoverAnnotation = default(FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation))
        : base()
        {
            this.Rect = rect;
            this.ViewId = viewId;
            this.HoverAnnotation = hoverAnnotation;
        }
        public virtual FlutterBinding.UI.Rect Rect { get; set; }
        public virtual int ViewId { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation HoverAnnotation { get; set; }

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
        {
            Rect shiftedRect = layerOffset == Dart:uiDefaultClass.Offset.Zero? Rect:Rect.Shift(layerOffset);
            builder.AddPlatformView(ViewId, offset: shiftedRect.TopLeft, width: shiftedRect.Width, height: shiftedRect.Height);
        }




        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
        {
            if (HoverAnnotation == null || !Rect.Contains(localPosition))
            {
                return false;
            }

            if (S == MousetrackingDefaultClass.MouseTrackerAnnotation)
            {
                object untypedValue = HoverAnnotation;
                S typedValue = untypedValue as S;
                result.Add(new AnnotationEntry<S>(annotation: typedValue, localPosition: localPosition));
                return true;
            }

            return false;
        }



    }


    /// <Summary>
    /// A layer that indicates to the compositor that it should display
    /// certain performance statistics within it.
    ///
    /// Performance overlay layers are always leaves in the layer tree.
    /// </Summary>
    public class PerformanceOverlayLayer : FlutterSDK.Rendering.Layer.Layer
    {
        public PerformanceOverlayLayer(FlutterBinding.UI.Rect overlayRect = default(FlutterBinding.UI.Rect), int optionsMask = default(int), int rasterizerThreshold = default(int), bool checkerboardRasterCacheImages = default(bool), bool checkerboardOffscreenLayers = default(bool))
        : base()
        {
            this.OptionsMask = optionsMask;
            this.RasterizerThreshold = rasterizerThreshold;
            this.CheckerboardRasterCacheImages = checkerboardRasterCacheImages;
            this.CheckerboardOffscreenLayers = checkerboardOffscreenLayers;
        }
        internal virtual FlutterBinding.UI.Rect _OverlayRect { get; set; }
        public virtual int OptionsMask { get; set; }
        public virtual int RasterizerThreshold { get; set; }
        public virtual bool CheckerboardRasterCacheImages { get; set; }
        public virtual bool CheckerboardOffscreenLayers { get; set; }
        public virtual FlutterBinding.UI.Rect OverlayRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
        {

            Rect shiftedOverlayRect = layerOffset == Dart:uiDefaultClass.Offset.Zero? OverlayRect:OverlayRect.Shift(layerOffset);
            builder.AddPerformanceOverlay(OptionsMask, shiftedOverlayRect);
            builder.SetRasterizerTracingThreshold(RasterizerThreshold);
            builder.SetCheckerboardRasterCacheImages(CheckerboardRasterCacheImages);
            builder.SetCheckerboardOffscreenLayers(CheckerboardOffscreenLayers);
        }




        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
        {
            return false;
        }



    }


    /// <Summary>
    /// A composited layer that has a list of children.
    ///
    /// A [ContainerLayer] instance merely takes a list of children and inserts them
    /// into the composited rendering in order. There are subclasses of
    /// [ContainerLayer] which apply more elaborate effects in the process.
    /// </Summary>
    public class ContainerLayer : FlutterSDK.Rendering.Layer.Layer
    {
        public ContainerLayer()
        { }
        internal virtual FlutterSDK.Rendering.Layer.Layer _FirstChild { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.Layer _LastChild { get; set; }
        public virtual FlutterSDK.Rendering.Layer.Layer FirstChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Layer.Layer LastChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasChildren { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Consider this layer as the root and build a scene (a tree of layers)
        /// in the engine.
        /// </Summary>
        public virtual Scene BuildScene(SceneBuilder builder)
        {
            List<PictureLayer> temporaryLayers = default(List<PictureLayer>);

            UpdateSubtreeNeedsAddToScene();
            AddToScene(builder);
            _NeedsAddToScene = false;
            Ui.Dart:uiDefaultClass.Scene scene = builder.Build();

            return scene;
        }




        private bool _DebugUltimatePreviousSiblingOf(FlutterSDK.Rendering.Layer.Layer child, FlutterSDK.Rendering.Layer.Layer equals = default(FlutterSDK.Rendering.Layer.Layer))
        {

            while (child.PreviousSibling != null)
            {

                child = child.PreviousSibling;

            }

            return child == equals;
        }




        private bool _DebugUltimateNextSiblingOf(FlutterSDK.Rendering.Layer.Layer child, FlutterSDK.Rendering.Layer.Layer equals = default(FlutterSDK.Rendering.Layer.Layer))
        {

            while (child._NextSibling != null)
            {

                child = child._NextSibling;

            }

            return child == equals;
        }




        private FlutterSDK.Rendering.Layer.PictureLayer _HighlightConflictingLayer(FlutterSDK.Rendering.Layer.PhysicalModelLayer child)
        {
            Ui.Dart:uiDefaultClass.PictureRecorder recorder = new Ui.PictureRecorder();
            Canvas canvas = new Canvas(recorder);
            canvas.DrawPath(child.ClipPath, new Paint()..Color = new Color(0xFFAA0000)..Style = PaintingStyle.Stroke..StrokeWidth = child.Elevation + 10.0);
            PictureLayer pictureLayer = new PictureLayer(child.ClipPath.GetBounds())..Picture = recorder.EndRecording()..DebugCreator = child;
            child.Append(pictureLayer);
            return pictureLayer;
        }




        private List<FlutterSDK.Rendering.Layer.PictureLayer> _ProcessConflictingPhysicalLayers(FlutterSDK.Rendering.Layer.PhysicalModelLayer predecessor, FlutterSDK.Rendering.Layer.PhysicalModelLayer child)
        {
            AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: new FlutterError("Painting order is out of order with respect to elevation.\n" + "See https://api.flutter.dev/flutter/rendering/debugCheckElevationsEnabled.html " + "for more details."), library: "rendering library", context: new ErrorDescription("during compositing"), informationCollector: () =>
            {
                return new List<DiagnosticsNode>() { child.ToDiagnosticsNode(name: "Attempted to composite layer", style: DiagnosticsTreeStyle.ErrorProperty), predecessor.ToDiagnosticsNode(name: "after layer", style: DiagnosticsTreeStyle.ErrorProperty), new ErrorDescription("which occupies the same area at a higher elevation.") };
            }
            ));
            return new List<PictureLayer>() { _HighlightConflictingLayer(predecessor), _HighlightConflictingLayer(child) };
        }




        /// <Summary>
        /// Checks that no [PhysicalModelLayer] would paint after another overlapping
        /// [PhysicalModelLayer] that has a higher elevation.
        ///
        /// Returns a list of [PictureLayer] objects it added to the tree to highlight
        /// bad nodes. These layers should be removed from the tree after building the
        /// [Scene].
        /// </Summary>
        private List<FlutterSDK.Rendering.Layer.PictureLayer> _DebugCheckElevations()
        {
            List<PhysicalModelLayer> physicalModelLayers = DepthFirstIterateChildren().WhereType().ToList();
            List<PictureLayer> addedLayers = new List<PictureLayer>() { };
            for (int i = 0; i < physicalModelLayers.Count; i++)
            {
                PhysicalModelLayer physicalModelLayer = physicalModelLayers[i];

                double accumulatedElevation = physicalModelLayer.Elevation;
                Layer ancestor = physicalModelLayer.Parent;
                while (ancestor != null)
                {
                    if (ancestor is PhysicalModelLayer)
                    {
                        accumulatedElevation += ((PhysicalModelLayer)ancestor).Elevation;
                    }

                    ancestor = ancestor.Parent;
                }

                for (int j = 0; j <= i; j++)
                {
                    PhysicalModelLayer predecessor = physicalModelLayers[j];
                    double predecessorAccumulatedElevation = predecessor.Elevation;
                    ancestor = predecessor.Parent;
                    while (ancestor != null)
                    {
                        if (ancestor == predecessor)
                        {
                            continue;
                        }

                        if (ancestor is PhysicalModelLayer)
                        {
                            predecessorAccumulatedElevation += ((PhysicalModelLayer)ancestor).Elevation;
                        }

                        ancestor = ancestor.Parent;
                    }

                    if (predecessorAccumulatedElevation <= accumulatedElevation)
                    {
                        continue;
                    }

                    Path intersection = Dart:uiDefaultClass.Path.Combine(PathOperation.Intersect, predecessor._DebugTransformedClipPath, physicalModelLayer._DebugTransformedClipPath);
                    if (intersection != null && intersection.ComputeMetrics().Any((Ui.Dart:uiDefaultClass.PathMetric metric) => =>metric.Length > 0)){
                addedLayers.AddAll(_ProcessConflictingPhysicalLayers(predecessor, physicalModelLayer));
            }

        }

    }

return addedLayers;
}




public new void UpdateSubtreeNeedsAddToScene()
{
    base.UpdateSubtreeNeedsAddToScene();
    Layer child = FirstChild;
    while (child != null)
    {
        child.UpdateSubtreeNeedsAddToScene();
        _NeedsAddToScene = _NeedsAddToScene || child._NeedsAddToScene;
        child = child.NextSibling;
    }

}




public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
{
    for (Layer child = LastChild; child != null; child = child.PreviousSibling)
    {
        bool isAbsorbed = child.FindAnnotations(result, localPosition, onlyFirst: onlyFirst);
        if (isAbsorbed) return true;
        if (onlyFirst && result.Entries.IsNotEmpty) return isAbsorbed;
    }

    return false;
}




public new void Attach(@Object owner)
{
    base.Attach(owner);
    Layer child = FirstChild;
    while (child != null)
    {
        child.Attach(owner);
        child = child.NextSibling;
    }

}




public new void Detach()
{
    base.Detach();
    Layer child = FirstChild;
    while (child != null)
    {
        child.Detach();
        child = child.NextSibling;
    }

}




/// <Summary>
/// Adds the given layer to the end of this layer's child list.
/// </Summary>
public virtual void Append(FlutterSDK.Rendering.Layer.Layer child)
{








    AdoptChild(child);
    child._PreviousSibling = LastChild;
    if (LastChild != null) LastChild._NextSibling = child;
    _LastChild = child;
    _FirstChild = (_FirstChild == null ? child : _FirstChild);

}




private void _RemoveChild(FlutterSDK.Rendering.Layer.Layer child)
{




    if (child._PreviousSibling == null)
    {

        _FirstChild = child._NextSibling;
    }
    else
    {
        child._PreviousSibling._NextSibling = child.NextSibling;
    }

    if (child._NextSibling == null)
    {

        _LastChild = child.PreviousSibling;
    }
    else
    {
        child.NextSibling._PreviousSibling = child.PreviousSibling;
    }






    child._PreviousSibling = null;
    child._NextSibling = null;
    DropChild(child);

}




/// <Summary>
/// Removes all of this layer's children from its child list.
/// </Summary>
public virtual void RemoveAllChildren()
{
    Layer child = FirstChild;
    while (child != null)
    {
        Layer next = child.NextSibling;
        child._PreviousSibling = null;
        child._NextSibling = null;

        DropChild(child);
        child = next;
    }

    _FirstChild = null;
    _LastChild = null;
}




public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
{
    AddChildrenToScene(builder, layerOffset);
}




/// <Summary>
/// Uploads all of this layer's children to the engine.
///
/// This method is typically used by [addToScene] to insert the children into
/// the scene. Subclasses of [ContainerLayer] typically override [addToScene]
/// to apply effects to the scene using the [SceneBuilder] API, then insert
/// their children using [addChildrenToScene], then reverse the aforementioned
/// effects before returning from [addToScene].
/// </Summary>
public virtual void AddChildrenToScene(SceneBuilder builder, FlutterBinding.UI.Offset childOffset = default(FlutterBinding.UI.Offset))
{
    Layer child = FirstChild;
    while (child != null)
    {
        if (childOffset == Dart:uiDefaultClass.Offset.Zero){
            child._AddToSceneWithRetainedRendering(builder);
        }
else
        {
            child.AddToScene(builder, childOffset);
        }

        child = child.NextSibling;
    }

}




/// <Summary>
/// Applies the transform that would be applied when compositing the given
/// child to the given matrix.
///
/// Specifically, this should apply the transform that is applied to child's
/// _origin_. When using [applyTransform] with a chain of layers, results will
/// be unreliable unless the deepest layer in the chain collapses the
/// `layerOffset` in [addToScene] to zero, meaning that it passes
/// [Offset.zero] to its children, and bakes any incoming `layerOffset` into
/// the [SceneBuilder] as (for instance) a transform (which is then also
/// included in the transformation applied by [applyTransform]).
///
/// For example, if [addToScene] applies the `layerOffset` and then
/// passes [Offset.zero] to the children, then it should be included in the
/// transform applied here, whereas if [addToScene] just passes the
/// `layerOffset` to the child, then it should not be included in the
/// transform applied here.
///
/// This method is only valid immediately after [addToScene] has been called,
/// before any of the properties have been changed.
///
/// The default implementation does nothing, since [ContainerLayer], by
/// default, composites its children at the origin of the [ContainerLayer]
/// itself.
///
/// The `child` argument should generally not be null, since in principle a
/// layer could transform each child independently. However, certain layers
/// may explicitly allow null as a value, for example if they know that they
/// transform all their children identically.
///
/// The `transform` argument must not be null.
///
/// Used by [FollowerLayer] to transform its child to a [LeaderLayer]'s
/// position.
/// </Summary>
public virtual void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform)
{


}




/// <Summary>
/// Returns the descendants of this layer in depth first order.
/// </Summary>
public virtual List<FlutterSDK.Rendering.Layer.Layer> DepthFirstIterateChildren()
{
    if (FirstChild == null) return new List<Layer>() { };
    List<Layer> children = new List<Layer>() { };
    Layer child = FirstChild;
    while (child != null)
    {
        children.Add(child);
        if (child is ContainerLayer)
        {
            children.AddAll(((ContainerLayer)child).DepthFirstIterateChildren());
        }

        child = child.NextSibling;
    }

    return children;
}




public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
{
    List<DiagnosticsNode> children = new List<DiagnosticsNode>() { };
    if (FirstChild == null) return children;
    Layer child = FirstChild;
    int count = 1;
    while (true)
    {
        children.Add(child.ToDiagnosticsNode(name: $"'child {count}'"));
        if (child == LastChild) break;
        count += 1;
        child = child.NextSibling;
    }

    return children;
}



}


/// <Summary>
/// A layer that is displayed at an offset from its parent layer.
///
/// Offset layers are key to efficient repainting because they are created by
/// repaint boundaries in the [RenderObject] tree (see
/// [RenderObject.isRepaintBoundary]). When a render object that is a repaint
/// boundary is asked to paint at given offset in a [PaintingContext], the
/// render object first checks whether it needs to repaint itself. If not, it
/// reuses its existing [OffsetLayer] (and its entire subtree) by mutating its
/// [offset] property, cutting off the paint walk.
/// </Summary>
public class OffsetLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public OffsetLayer(FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
    : base()
    {

    }
    internal virtual FlutterBinding.UI.Offset _Offset { get; set; }
    public virtual FlutterBinding.UI.Offset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
    {
        return base.FindAnnotations(result, localPosition - Offset, onlyFirst: onlyFirst);
    }




    public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform)
    {


        transform.Multiply(Matrix4.TranslationValues(Offset.Dx, Offset.Dy, 0.0));
    }




    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {
        EngineLayer = builder.PushOffset(layerOffset.Dx + Offset.Dx, layerOffset.Dy + Offset.Dy, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.OffsetEngineLayer);
        AddChildrenToScene(builder);
        builder.Pop();
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<Offset>("offset", Offset));
    }




    /// <Summary>
    /// Capture an image of the current state of this layer and its children.
    ///
    /// The returned [ui.Image] has uncompressed raw RGBA bytes, will be offset
    /// by the top-left corner of [bounds], and have dimensions equal to the size
    /// of [bounds] multiplied by [pixelRatio].
    ///
    /// The [pixelRatio] describes the scale between the logical pixels and the
    /// size of the output image. It is independent of the
    /// [window.devicePixelRatio] for the device, so specifying 1.0 (the default)
    /// will give you a 1:1 mapping between logical pixels and the output pixels
    /// in the image.
    ///
    /// See also:
    ///
    ///  * [RenderRepaintBoundary.toImage] for a similar API at the render object level.
    ///  * [dart:ui.Scene.toImage] for more information about the image returned.
    /// </Summary>
    public virtual async Future<SKImage> ToImage(FlutterBinding.UI.Rect bounds, double pixelRatio = 1.0)
    {


        Ui.Dart:uiDefaultClass.SceneBuilder builder = new Ui.SceneBuilder();
        Matrix4 transform = Matrix4.TranslationValues((-bounds.Left - Offset.Dx) * pixelRatio, (-bounds.Top - Offset.Dy) * pixelRatio, 0.0);
        transform.Scale(pixelRatio, pixelRatio);
        builder.PushTransform(transform.Storage);
        Ui.Dart:uiDefaultClass.Scene scene = BuildScene(builder);
        try
        {
            return await scene.ToImage((pixelRatio * bounds.Width).Ceil(), (pixelRatio * bounds.Height).Ceil());
        }
        finally
        {
            scene.Dispose();
        }

    }



}


/// <Summary>
/// A composite layer that clips its children using a rectangle.
///
/// When debugging, setting [debugDisableClipLayers] to true will cause this
/// layer to be skipped (directly replaced by its children). This can be helpful
/// to track down the cause of performance problems.
/// </Summary>
public class ClipRectLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public ClipRectLayer(FlutterBinding.UI.Rect clipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
    : base()
    {

    }
    internal virtual FlutterBinding.UI.Rect _ClipRect { get; set; }
    internal virtual FlutterBinding.UI.Clip _ClipBehavior { get; set; }
    public virtual FlutterBinding.UI.Rect ClipRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Clip ClipBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
    {
        if (!ClipRect.Contains(localPosition)) return false;
        return base.FindAnnotations(result, localPosition, onlyFirst: onlyFirst);
    }




    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {


        bool enabled = true;

        if (enabled)
        {
            Rect shiftedClipRect = layerOffset == Dart:uiDefaultClass.Offset.Zero? ClipRect:ClipRect.Shift(layerOffset);
            EngineLayer = builder.PushClipRect(shiftedClipRect, clipBehavior: ClipBehavior, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.ClipRectEngineLayer);
        }
        else
        {
            EngineLayer = null;
        }

        AddChildrenToScene(builder, layerOffset);
        if (enabled) builder.Pop();
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<Rect>("clipRect", ClipRect));
        properties.Add(new DiagnosticsProperty<FlutterBinding.UI.Clip>("clipBehavior", ClipBehavior));
    }



}


/// <Summary>
/// A composite layer that clips its children using a rounded rectangle.
///
/// When debugging, setting [debugDisableClipLayers] to true will cause this
/// layer to be skipped (directly replaced by its children). This can be helpful
/// to track down the cause of performance problems.
/// </Summary>
public class ClipRRectLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public ClipRRectLayer(FlutterBinding.UI.RRect clipRRect = default(FlutterBinding.UI.RRect), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
    : base()
    {

    }
    internal virtual FlutterBinding.UI.RRect _ClipRRect { get; set; }
    internal virtual FlutterBinding.UI.Clip _ClipBehavior { get; set; }
    public virtual FlutterBinding.UI.RRect ClipRRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Clip ClipBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
    {
        if (!ClipRRect.Contains(localPosition)) return false;
        return base.FindAnnotations(result, localPosition, onlyFirst: onlyFirst);
    }




    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {


        bool enabled = true;

        if (enabled)
        {
            RRect shiftedClipRRect = layerOffset == Dart:uiDefaultClass.Offset.Zero? ClipRRect:ClipRRect.Shift(layerOffset);
            EngineLayer = builder.PushClipRRect(shiftedClipRRect, clipBehavior: ClipBehavior, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.ClipRRectEngineLayer);
        }
        else
        {
            EngineLayer = null;
        }

        AddChildrenToScene(builder, layerOffset);
        if (enabled) builder.Pop();
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<RRect>("clipRRect", ClipRRect));
        properties.Add(new DiagnosticsProperty<FlutterBinding.UI.Clip>("clipBehavior", ClipBehavior));
    }



}


/// <Summary>
/// A composite layer that clips its children using a path.
///
/// When debugging, setting [debugDisableClipLayers] to true will cause this
/// layer to be skipped (directly replaced by its children). This can be helpful
/// to track down the cause of performance problems.
/// </Summary>
public class ClipPathLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public ClipPathLayer(Path clipPath = default(Path), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
    : base()
    {

    }
    internal virtual Path _ClipPath { get; set; }
    internal virtual FlutterBinding.UI.Clip _ClipBehavior { get; set; }
    public virtual Path ClipPath { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Clip ClipBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
    {
        if (!ClipPath.Contains(localPosition)) return false;
        return base.FindAnnotations(result, localPosition, onlyFirst: onlyFirst);
    }




    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {


        bool enabled = true;

        if (enabled)
        {
            Path shiftedPath = layerOffset == Dart:uiDefaultClass.Offset.Zero? ClipPath:ClipPath.Shift(layerOffset);
            EngineLayer = builder.PushClipPath(shiftedPath, clipBehavior: ClipBehavior, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.ClipPathEngineLayer);
        }
        else
        {
            EngineLayer = null;
        }

        AddChildrenToScene(builder, layerOffset);
        if (enabled) builder.Pop();
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<FlutterBinding.UI.Clip>("clipBehavior", ClipBehavior));
    }



}


/// <Summary>
/// A composite layer that applies a [ColorFilter] to its children.
/// </Summary>
public class ColorFilterLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public ColorFilterLayer(ColorFilter colorFilter = default(ColorFilter))
    : base()
    {

    }
    internal virtual ColorFilter _ColorFilter { get; set; }
    public virtual ColorFilter ColorFilter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {

        EngineLayer = builder.PushColorFilter(ColorFilter, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.ColorFilterEngineLayer);
        AddChildrenToScene(builder, layerOffset);
        builder.Pop();
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<ColorFilter>("colorFilter", ColorFilter));
    }



}


/// <Summary>
/// A composite layer that applies an [ImageFilter] to its children.
/// </Summary>
public class ImageFilterLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public ImageFilterLayer(ImageFilter imageFilter = default(ImageFilter))
    : base()
    {

    }
    internal virtual ImageFilter _ImageFilter { get; set; }
    public virtual ImageFilter ImageFilter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {

        EngineLayer = builder.PushImageFilter(ImageFilter, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.ImageFilterEngineLayer);
        AddChildrenToScene(builder, layerOffset);
        builder.Pop();
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<Ui.Dart:uiDefaultClass.ImageFilter>("imageFilter", ImageFilter));
    }



}


/// <Summary>
/// A composited layer that applies a given transformation matrix to its
/// children.
///
/// This class inherits from [OffsetLayer] to make it one of the layers that
/// can be used at the root of a [RenderObject] hierarchy.
/// </Summary>
public class TransformLayer : FlutterSDK.Rendering.Layer.OffsetLayer
{
    public TransformLayer(Matrix4 transform = default(Matrix4), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
    : base(offset: offset)
    {

    }
    internal virtual Matrix4 _Transform { get; set; }
    internal virtual Matrix4 _LastEffectiveTransform { get; set; }
    internal virtual Matrix4 _InvertedTransform { get; set; }
    internal virtual bool _InverseDirty { get; set; }
    public virtual object Transform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {

        _LastEffectiveTransform = Transform;
        Offset totalOffset = Offset + layerOffset;
        if (totalOffset != Dart:uiDefaultClass.Offset.Zero){
            _LastEffectiveTransform = Matrix4.TranslationValues(totalOffset.Dx, totalOffset.Dy, 0.0);
            Matrix4.TranslationValues(totalOffset.Dx, totalOffset.Dy, 0.0).Multiply(_LastEffectiveTransform);
        }

        EngineLayer = builder.PushTransform(_LastEffectiveTransform.Storage, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.TransformEngineLayer);
        AddChildrenToScene(builder);
        builder.Pop();
    }




    private Offset _TransformOffset(FlutterBinding.UI.Offset localPosition)
    {
        if (_InverseDirty)
        {
            _InvertedTransform = Matrix4.TryInvert(EventsDefaultClass.PointerEvent.RemovePerspectiveTransform(Transform));
            _InverseDirty = false;
        }

        if (_InvertedTransform == null) return null;
        return MatrixutilsDefaultClass.MatrixUtils.TransformPoint(_InvertedTransform, localPosition);
    }




    public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
    {
        Offset transformedOffset = _TransformOffset(localPosition);
        if (transformedOffset == null) return false;
        return base.FindAnnotations(result, transformedOffset, onlyFirst: onlyFirst);
    }




    public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform)
    {



        if (_LastEffectiveTransform == null)
        {
            transform.Multiply(this.Transform);
        }
        else
        {
            transform.Multiply(_LastEffectiveTransform);
        }

    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new TransformProperty("transform", Transform));
    }



}


/// <Summary>
/// A composited layer that makes its children partially transparent.
///
/// When debugging, setting [debugDisableOpacityLayers] to true will cause this
/// layer to be skipped (directly replaced by its children). This can be helpful
/// to track down the cause of performance problems.
///
/// Try to avoid an [OpacityLayer] with no children. Remove that layer if
/// possible to save some tree walks.
/// </Summary>
public class OpacityLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public OpacityLayer(int alpha = default(int), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
    : base()
    {

    }
    internal virtual int _Alpha { get; set; }
    internal virtual FlutterBinding.UI.Offset _Offset { get; set; }
    public virtual int Alpha { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Offset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform)
    {


        transform.Translate(Offset.Dx, Offset.Dy);
    }




    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {

        bool enabled = FirstChild != null;

        if (enabled) EngineLayer = builder.PushOpacity(Alpha, offset: Offset + layerOffset, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.OpacityEngineLayer); else EngineLayer = null;
        AddChildrenToScene(builder);
        if (enabled) builder.Pop();
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new IntProperty("alpha", Alpha));
        properties.Add(new DiagnosticsProperty<Offset>("offset", Offset));
    }



}


/// <Summary>
/// A composited layer that applies a shader to its children.
///
/// The shader is only applied inside the given [maskRect]. The shader itself
/// uses the top left of the [maskRect] as its origin.
///
/// The [maskRect] does not affect the positions of any child layers.
/// </Summary>
public class ShaderMaskLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public ShaderMaskLayer(SKShader shader = default(SKShader), FlutterBinding.UI.Rect maskRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.BlendMode blendMode = default(FlutterBinding.UI.BlendMode))
    : base()
    {

    }
    internal virtual SKShader _Shader { get; set; }
    internal virtual FlutterBinding.UI.Rect _MaskRect { get; set; }
    internal virtual FlutterBinding.UI.BlendMode _BlendMode { get; set; }
    public virtual SKShader Shader { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Rect MaskRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.BlendMode BlendMode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {




        Rect shiftedMaskRect = layerOffset == Dart:uiDefaultClass.Offset.Zero? MaskRect:MaskRect.Shift(layerOffset);
        EngineLayer = builder.PushShaderMask(Shader, shiftedMaskRect, BlendMode, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.ShaderMaskEngineLayer);
        AddChildrenToScene(builder, layerOffset);
        builder.Pop();
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<SKShader>("shader", Shader));
        properties.Add(new DiagnosticsProperty<Rect>("maskRect", MaskRect));
        properties.Add(new DiagnosticsProperty<BlendMode>("blendMode", BlendMode));
    }



}


/// <Summary>
/// A composited layer that applies a filter to the existing contents of the scene.
/// </Summary>
public class BackdropFilterLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public BackdropFilterLayer(ImageFilter filter = default(ImageFilter))
    : base()
    {

    }
    internal virtual ImageFilter _Filter { get; set; }
    public virtual ImageFilter Filter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {

        EngineLayer = builder.PushBackdropFilter(Filter, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.BackdropFilterEngineLayer);
        AddChildrenToScene(builder, layerOffset);
        builder.Pop();
    }



}


/// <Summary>
/// A composited layer that uses a physical model to producing lighting effects.
///
/// For example, the layer casts a shadow according to its geometry and the
/// relative position of lights and other physically modeled objects in the
/// scene.
///
/// When debugging, setting [debugDisablePhysicalShapeLayers] to true will cause this
/// layer to be skipped (directly replaced by its children). This can be helpful
/// to track down the cause of performance problems.
/// </Summary>
public class PhysicalModelLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public PhysicalModelLayer(Path clipPath = default(Path), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), double elevation = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
    : base()
    {

    }
    internal virtual Path _ClipPath { get; set; }
    internal virtual FlutterBinding.UI.Clip _ClipBehavior { get; set; }
    internal virtual double _Elevation { get; set; }
    internal virtual FlutterBinding.UI.Color _Color { get; set; }
    internal virtual FlutterBinding.UI.Color _ShadowColor { get; set; }
    public virtual Path ClipPath { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    internal virtual Path _DebugTransformedClipPath { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Clip ClipBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double Elevation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Color Color { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterBinding.UI.Color ShadowColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
    {
        if (!ClipPath.Contains(localPosition)) return false;
        return base.FindAnnotations(result, localPosition, onlyFirst: onlyFirst);
    }




    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {





        bool enabled = true;

        if (enabled)
        {
            EngineLayer = builder.PushPhysicalShape(path: layerOffset == Dart:uiDefaultClass.Offset.Zero ? ClipPath : ClipPath.Shift(layerOffset), elevation: Elevation, color: Color, shadowColor: ShadowColor, clipBehavior: ClipBehavior, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.PhysicalShapeEngineLayer);
        }
        else
        {
            EngineLayer = null;
        }

        AddChildrenToScene(builder, layerOffset);
        if (enabled) builder.Pop();
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DoubleProperty("elevation", Elevation));
        properties.Add(new ColorProperty("color", Color));
    }



}


/// <Summary>
/// A composited layer that can be followed by a [FollowerLayer].
///
/// This layer collapses the accumulated offset into a transform and passes
/// [Offset.zero] to its child layers in the [addToScene]/[addChildrenToScene]
/// methods, so that [applyTransform] will work reliably.
/// </Summary>
public class LeaderLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public LeaderLayer(FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
    : base()
    {
        this.Offset = offset;
    }
    internal virtual FlutterSDK.Rendering.Layer.LayerLink _Link { get; set; }
    public virtual FlutterBinding.UI.Offset Offset { get; set; }
    internal virtual FlutterBinding.UI.Offset _LastOffset { get; set; }
    public virtual FlutterSDK.Rendering.Layer.LayerLink Link { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool AlwaysNeedsAddToScene { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    public new void Attach(@Object owner)
    {
        base.Attach(owner);

        _LastOffset = null;
        Link._Leader = this;
    }




    public new void Detach()
    {

        Link._Leader = null;
        _LastOffset = null;
        base.Detach();
    }




    public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
    {
        return base.FindAnnotations(result, localPosition - Offset, onlyFirst: onlyFirst);
    }




    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {

        _LastOffset = Offset + layerOffset;
        if (_LastOffset != Dart:uiDefaultClass.Offset.Zero)EngineLayer = builder.PushTransform(Matrix4.TranslationValues(_LastOffset.Dx, _LastOffset.Dy, 0.0).Storage, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.TransformEngineLayer);
        AddChildrenToScene(builder);
        if (_LastOffset != Dart:uiDefaultClass.Offset.Zero)builder.Pop();
    }




    /// <Summary>
    /// Applies the transform that would be applied when compositing the given
    /// child to the given matrix.
    ///
    /// See [ContainerLayer.applyTransform] for details.
    ///
    /// The `child` argument may be null, as the same transform is applied to all
    /// children.
    /// </Summary>
    public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform)
    {

        if (_LastOffset != Dart:uiDefaultClass.Offset.Zero)transform.Translate(_LastOffset.Dx, _LastOffset.Dy);
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<Offset>("offset", Offset));
        properties.Add(new DiagnosticsProperty<LayerLink>("link", Link));
    }



}


/// <Summary>
/// A composited layer that applies a transformation matrix to its children such
/// that they are positioned to match a [LeaderLayer].
///
/// If any of the ancestors of this layer have a degenerate matrix (e.g. scaling
/// by zero), then the [FollowerLayer] will not be able to transform its child
/// to the coordinate space of the [LeaderLayer].
///
/// A [linkedOffset] property can be provided to further offset the child layer
/// from the leader layer, for example if the child is to follow the linked
/// layer at a distance rather than directly overlapping it.
/// </Summary>
public class FollowerLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public FollowerLayer(FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink), bool showWhenUnlinked = true, FlutterBinding.UI.Offset unlinkedOffset = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset linkedOffset = default(FlutterBinding.UI.Offset))
    : base()
    {
        this.ShowWhenUnlinked = showWhenUnlinked;
        this.UnlinkedOffset = unlinkedOffset;
        this.LinkedOffset = linkedOffset;
    }
    internal virtual FlutterSDK.Rendering.Layer.LayerLink _Link { get; set; }
    public virtual bool ShowWhenUnlinked { get; set; }
    public virtual FlutterBinding.UI.Offset UnlinkedOffset { get; set; }
    public virtual FlutterBinding.UI.Offset LinkedOffset { get; set; }
    internal virtual FlutterBinding.UI.Offset _LastOffset { get; set; }
    internal virtual Matrix4 _LastTransform { get; set; }
    internal virtual Matrix4 _InvertedTransform { get; set; }
    internal virtual bool _InverseDirty { get; set; }
    public virtual FlutterSDK.Rendering.Layer.LayerLink Link { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool AlwaysNeedsAddToScene { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    private Offset _TransformOffset<S>(FlutterBinding.UI.Offset localPosition)
    {
        if (_InverseDirty)
        {
            _InvertedTransform = Matrix4.TryInvert(GetLastTransform());
            _InverseDirty = false;
        }

        if (_InvertedTransform == null) return null;
        Vector4 vector = Vector4(localPosition.Dx, localPosition.Dy, 0.0, 1.0);
        Vector4 result = _InvertedTransform.Transform(vector);
        return new Offset(result[0] - LinkedOffset.Dx, result[1] - LinkedOffset.Dy);
    }




    public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
    {
        if (Link.Leader == null)
        {
            if (ShowWhenUnlinked)
            {
                return base.FindAnnotations(result, localPosition - UnlinkedOffset, onlyFirst: onlyFirst);
            }

            return false;
        }

        Offset transformedOffset = _TransformOffset(localPosition);
        if (transformedOffset == null)
        {
            return false;
        }

        return base.FindAnnotations(result, transformedOffset, onlyFirst: onlyFirst);
    }




    /// <Summary>
    /// The transform that was used during the last composition phase.
    ///
    /// If the [link] was not linked to a [LeaderLayer], or if this layer has
    /// a degenerate matrix applied, then this will be null.
    ///
    /// This method returns a new [Matrix4] instance each time it is invoked.
    /// </Summary>
    public virtual Matrix4 GetLastTransform()
    {
        if (_LastTransform == null) return null;
        Matrix4 result = Matrix4.TranslationValues(-_LastOffset.Dx, -_LastOffset.Dy, 0.0);
        result.Multiply(_LastTransform);
        return result;
    }




    /// <Summary>
    /// Call [applyTransform] for each layer in the provided list.
    ///
    /// The list is in reverse order (deepest first). The first layer will be
    /// treated as the child of the second, and so forth. The first layer in the
    /// list won't have [applyTransform] called on it. The first layer may be
    /// null.
    /// </Summary>
    private Matrix4 _CollectTransformForLayerChain(List<FlutterSDK.Rendering.Layer.ContainerLayer> layers)
    {
        Matrix4 result = Matrix4.Identity();
        for (int index = layers.Count - 1; index > 0; index -= 1) layers[index].ApplyTransform(layers[index - 1], result);
        return result;
    }




    /// <Summary>
    /// Populate [_lastTransform] given the current state of the tree.
    /// </Summary>
    private void _EstablishTransform()
    {

        _LastTransform = null;
        if (Link.Leader == null) return;


        HashSet<Layer> ancestors = new HashSet<Layer>();
        Layer ancestor = Parent;
        while (ancestor != null)
        {
            ancestors.Add(ancestor);
            ancestor = ancestor.Parent;
        }

        ContainerLayer layer = Link.Leader;
        List<ContainerLayer> forwardLayers = new List<ContainerLayer>() { null, layer };
        do
        {
            layer = layer.Parent;
            forwardLayers.Add(layer);
        }
        while (!ancestors.Contains(layer));
        ancestor = layer;
        layer = this;
        List<ContainerLayer> inverseLayers = new List<ContainerLayer>() { layer };
        do
        {
            layer = layer.Parent;
            inverseLayers.Add(layer);
        }
        while (layer != ancestor);
        Matrix4 forwardTransform = _CollectTransformForLayerChain(forwardLayers);
        Matrix4 inverseTransform = _CollectTransformForLayerChain(inverseLayers);
        if (inverseTransform.Invert() == 0.0)
        {
            return;
        }

        inverseTransform.Multiply(forwardTransform);
        inverseTransform.Translate(LinkedOffset.Dx, LinkedOffset.Dy);
        _LastTransform = inverseTransform;
        _InverseDirty = true;
    }




    public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset))
    {


        if (Link.Leader == null && !ShowWhenUnlinked)
        {
            _LastTransform = null;
            _LastOffset = null;
            _InverseDirty = true;
            EngineLayer = null;
            return;
        }

        _EstablishTransform();
        if (_LastTransform != null)
        {
            EngineLayer = builder.PushTransform(_LastTransform.Storage, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.TransformEngineLayer);
            AddChildrenToScene(builder);
            builder.Pop();
            _LastOffset = UnlinkedOffset + layerOffset;
        }
        else
        {
            _LastOffset = null;
            Matrix4 matrix = Matrix4.TranslationValues(UnlinkedOffset.Dx, UnlinkedOffset.Dy, .0);
            EngineLayer = builder.PushTransform(matrix.Storage, oldLayer: _EngineLayer as Ui.Dart:uiDefaultClass.TransformEngineLayer);
            AddChildrenToScene(builder);
            builder.Pop();
        }

        _InverseDirty = true;
    }




    public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform)
    {


        if (_LastTransform != null)
        {
            transform.Multiply(_LastTransform);
        }
        else
        {
            transform.Multiply(Matrix4.TranslationValues(UnlinkedOffset.Dx, UnlinkedOffset.Dy, .0));
        }

    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<LayerLink>("link", Link));
        properties.Add(new TransformProperty("transform", GetLastTransform(), defaultValue: null));
    }



}


/// <Summary>
/// A composited layer which annotates its children with a value. Pushing this
/// layer to the tree is the common way of adding an annotation.
///
/// An annotation is an optional object of any type that, when attached with a
/// layer, can be retrieved using [Layer.find] or [Layer.findAllAnnotations]
/// with a position. The search process is done recursively, controlled by a
/// concept of being opaque to a type of annotation, explained in the document
/// of [Layer.findAnnotations].
///
/// When an annotation search arrives, this layer defers the same search to each
/// of this layer's children, respecting their opacity. Then it adds this
/// layer's [annotation] if all of the following restrictions are met:
///
/// {@template flutter.rendering.annotatedRegionLayer.restrictions}
/// * The target type must be identical to the annotated type `T`.
/// * If [size] is provided, the target position must be contained within the
///   rectangle formed by [size] and [offset].
/// {@endtemplate}
///
/// This layer is opaque to a type of annotation if any child is also opaque, or
/// if [opaque] is true and the layer's annotation is added.
/// </Summary>
public class AnnotatedRegionLayer<T> : FlutterSDK.Rendering.Layer.ContainerLayer
{
    public AnnotatedRegionLayer(T value, Size size = default(Size), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), bool opaque = false)
    : base()
    {
        this.Value = value;
        this.Size = size;
        this.Opaque = opaque;
    }
    public virtual T Value { get; set; }
    public virtual Size Size { get; set; }
    public virtual FlutterBinding.UI.Offset Offset { get; set; }
    public virtual bool Opaque { get; set; }

    /// <Summary>
    /// Searches the subtree for annotations of type `S` at the location
    /// `localPosition`, then adds the annotation [value] if applicable.
    ///
    /// This method always searches its children, and if any child returns `true`,
    /// the remaining children are skipped. Regardless of what the children
    /// return, this method then adds this layer's annotation if all of the
    /// following restrictions are met:
    ///
    /// {@macro flutter.rendering.annotatedRegionLayer.restrictions}
    ///
    /// This search process respects `onlyFirst`, meaning that when `onlyFirst` is
    /// true, the search will stop when it finds the first annotation from the
    /// children, and the layer's own annotation is checked only when none is
    /// given by the children.
    ///
    /// The return value is true if any child returns `true`, or if [opaque] is
    /// true and the layer's annotation is added.
    ///
    /// For explanation of layer annotations, parameters and return value, refer
    /// to [Layer.findAnnotations].
    /// </Summary>
    public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool))
    {
        bool isAbsorbed = base.FindAnnotations(result, localPosition, onlyFirst: onlyFirst);
        if (result.Entries.IsNotEmpty && onlyFirst) return isAbsorbed;
        if (Size != null && !(Offset & Size).Contains(localPosition))
        {
            return isAbsorbed;
        }

        if (T == S)
        {
            isAbsorbed = isAbsorbed || Opaque;
            object untypedValue = Value;
            S typedValue = untypedValue as S;
            result.Add(new AnnotationEntry<S>(annotation: typedValue, localPosition: localPosition - Offset));
        }

        return isAbsorbed;
    }




    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
        base.DebugFillProperties(properties);
        properties.Add(new DiagnosticsProperty<T>("value", Value));
        properties.Add(new DiagnosticsProperty<Size>("size", Size, defaultValue: null));
        properties.Add(new DiagnosticsProperty<Offset>("offset", Offset, defaultValue: null));
        properties.Add(new DiagnosticsProperty<bool>("opaque", Opaque, defaultValue: false));
    }



}

}
