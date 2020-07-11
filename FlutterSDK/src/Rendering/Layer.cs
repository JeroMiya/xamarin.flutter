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
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
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
        public virtual void Add(FlutterSDK.Rendering.Layer.AnnotationEntry<T> entry) { throw new NotImplementedException(); }

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
        #region constructors
        public AnnotationEntry(T annotation = default(T), FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.Annotation = annotation;
            this.LocalPosition = localPosition; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual T Annotation { get; set; }
        public virtual FlutterBinding.UI.Offset LocalPosition { get; set; }
        #endregion

        #region methods

        #endregion
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
        #region constructors
        public Layer()
        { }
        #endregion

        #region fields
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
        #endregion

        #region methods

        /// <Summary>
        /// Mark that this layer has changed and [addToScene] needs to be called.
        /// </Summary>
        public virtual void MarkNeedsAddToScene() { throw new NotImplementedException(); }


        /// <Summary>
        /// Mark that this layer is in sync with engine.
        ///
        /// This is for debugging and testing purposes only. In release builds
        /// this method has no effect.
        /// </Summary>
        public virtual void DebugMarkClean() { throw new NotImplementedException(); }


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
        public virtual void UpdateSubtreeNeedsAddToScene() { throw new NotImplementedException(); }


        public new void DropChild(FlutterSDK.Foundation.Node.AbstractNode child) { throw new NotImplementedException(); }


        public new void AdoptChild(FlutterSDK.Foundation.Node.AbstractNode child) { throw new NotImplementedException(); }


        /// <Summary>
        /// Removes this layer from its parent layer's child list.
        ///
        /// This has no effect if the layer's parent is already null.
        /// </Summary>
        public virtual void Remove() { throw new NotImplementedException(); }


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
        public virtual bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


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
        public virtual S Find<S>(FlutterBinding.UI.Offset localPosition) { throw new NotImplementedException(); }


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
        public virtual Iterable<S> FindAll<S>(FlutterBinding.UI.Offset localPosition) { throw new NotImplementedException(); }


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
        public virtual AnnotationResult<S> FindAllAnnotations<S>(FlutterBinding.UI.Offset localPosition) { throw new NotImplementedException(); }


        /// <Summary>
        /// Override this method to upload this layer to the engine.
        ///
        /// Return the engine layer for retained rendering. When there's no
        /// corresponding engine layer, null is returned.
        /// </Summary>
        public virtual void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        private void _AddToSceneWithRetainedRendering(SceneBuilder builder) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A composited layer containing a [Picture].
    ///
    /// Picture layers are always leaves in the layer tree.
    /// </Summary>
    public class PictureLayer : FlutterSDK.Rendering.Layer.Layer
    {
        #region constructors
        public PictureLayer(FlutterBinding.UI.Rect canvasBounds)
        {
            this.CanvasBounds = canvasBounds; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Rect CanvasBounds { get; set; }
        internal virtual SKPicture _Picture { get; set; }
        internal virtual bool _IsComplexHint { get; set; }
        internal virtual bool _WillChangeHint { get; set; }
        public virtual SKPicture Picture { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsComplexHint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool WillChangeHint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public TextureLayer(FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), int textureId = default(int), bool freeze = false)
        : base()
        {
            this.Rect = rect;
            this.TextureId = textureId;
            this.Freeze = freeze; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Rect Rect { get; set; }
        public virtual int TextureId { get; set; }
        public virtual bool Freeze { get; set; }
        #endregion

        #region methods

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A layer that shows an embedded [UIView](https://developer.apple.com/documentation/uikit/uiview)
    /// on iOS.
    /// </Summary>
    public class PlatformViewLayer : FlutterSDK.Rendering.Layer.Layer
    {
        #region constructors
        public PlatformViewLayer(FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), int viewId = default(int), FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation hoverAnnotation = default(FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation))
        : base()
        {
            this.Rect = rect;
            this.ViewId = viewId;
            this.HoverAnnotation = hoverAnnotation; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Rect Rect { get; set; }
        public virtual int ViewId { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation HoverAnnotation { get; set; }
        #endregion

        #region methods

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A layer that indicates to the compositor that it should display
    /// certain performance statistics within it.
    ///
    /// Performance overlay layers are always leaves in the layer tree.
    /// </Summary>
    public class PerformanceOverlayLayer : FlutterSDK.Rendering.Layer.Layer
    {
        #region constructors
        public PerformanceOverlayLayer(FlutterBinding.UI.Rect overlayRect = default(FlutterBinding.UI.Rect), int optionsMask = default(int), int rasterizerThreshold = default(int), bool checkerboardRasterCacheImages = default(bool), bool checkerboardOffscreenLayers = default(bool))
        : base()
        {
            this.OptionsMask = optionsMask;
            this.RasterizerThreshold = rasterizerThreshold;
            this.CheckerboardRasterCacheImages = checkerboardRasterCacheImages;
            this.CheckerboardOffscreenLayers = checkerboardOffscreenLayers; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterBinding.UI.Rect _OverlayRect { get; set; }
        public virtual int OptionsMask { get; set; }
        public virtual int RasterizerThreshold { get; set; }
        public virtual bool CheckerboardRasterCacheImages { get; set; }
        public virtual bool CheckerboardOffscreenLayers { get; set; }
        public virtual FlutterBinding.UI.Rect OverlayRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public ContainerLayer()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Layer.Layer _FirstChild { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.Layer _LastChild { get; set; }
        public virtual FlutterSDK.Rendering.Layer.Layer FirstChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Layer.Layer LastChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasChildren { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Consider this layer as the root and build a scene (a tree of layers)
        /// in the engine.
        /// </Summary>
        public virtual Scene BuildScene(SceneBuilder builder) { throw new NotImplementedException(); }


        private bool _DebugUltimatePreviousSiblingOf(FlutterSDK.Rendering.Layer.Layer child, FlutterSDK.Rendering.Layer.Layer equals = default(FlutterSDK.Rendering.Layer.Layer)) { throw new NotImplementedException(); }


        private bool _DebugUltimateNextSiblingOf(FlutterSDK.Rendering.Layer.Layer child, FlutterSDK.Rendering.Layer.Layer equals = default(FlutterSDK.Rendering.Layer.Layer)) { throw new NotImplementedException(); }


        private FlutterSDK.Rendering.Layer.PictureLayer _HighlightConflictingLayer(FlutterSDK.Rendering.Layer.PhysicalModelLayer child) { throw new NotImplementedException(); }


        private List<FlutterSDK.Rendering.Layer.PictureLayer> _ProcessConflictingPhysicalLayers(FlutterSDK.Rendering.Layer.PhysicalModelLayer predecessor, FlutterSDK.Rendering.Layer.PhysicalModelLayer child) { throw new NotImplementedException(); }


        /// <Summary>
        /// Checks that no [PhysicalModelLayer] would paint after another overlapping
        /// [PhysicalModelLayer] that has a higher elevation.
        ///
        /// Returns a list of [PictureLayer] objects it added to the tree to highlight
        /// bad nodes. These layers should be removed from the tree after building the
        /// [Scene].
        /// </Summary>
        private List<FlutterSDK.Rendering.Layer.PictureLayer> _DebugCheckElevations() { throw new NotImplementedException(); }


        public new void UpdateSubtreeNeedsAddToScene() { throw new NotImplementedException(); }


        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        /// <Summary>
        /// Adds the given layer to the end of this layer's child list.
        /// </Summary>
        public virtual void Append(FlutterSDK.Rendering.Layer.Layer child) { throw new NotImplementedException(); }


        private void _RemoveChild(FlutterSDK.Rendering.Layer.Layer child) { throw new NotImplementedException(); }


        /// <Summary>
        /// Removes all of this layer's children from its child list.
        /// </Summary>
        public virtual void RemoveAllChildren() { throw new NotImplementedException(); }


        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Uploads all of this layer's children to the engine.
        ///
        /// This method is typically used by [addToScene] to insert the children into
        /// the scene. Subclasses of [ContainerLayer] typically override [addToScene]
        /// to apply effects to the scene using the [SceneBuilder] API, then insert
        /// their children using [addChildrenToScene], then reverse the aforementioned
        /// effects before returning from [addToScene].
        /// </Summary>
        public virtual void AddChildrenToScene(SceneBuilder builder, FlutterBinding.UI.Offset childOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


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
        public virtual void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform) { throw new NotImplementedException(); }


        /// <Summary>
        /// Returns the descendants of this layer in depth first order.
        /// </Summary>
        public virtual List<FlutterSDK.Rendering.Layer.Layer> DepthFirstIterateChildren() { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public OffsetLayer(FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterBinding.UI.Offset _Offset { get; set; }
        public virtual FlutterBinding.UI.Offset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


        public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform) { throw new NotImplementedException(); }


        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


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
        public virtual Future<SKImage> ToImage(FlutterBinding.UI.Rect bounds, double pixelRatio = 1.0) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public ClipRectLayer(FlutterBinding.UI.Rect clipRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterBinding.UI.Rect _ClipRect { get; set; }
        internal virtual FlutterBinding.UI.Clip _ClipBehavior { get; set; }
        public virtual FlutterBinding.UI.Rect ClipRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public ClipRRectLayer(FlutterBinding.UI.RRect clipRRect = default(FlutterBinding.UI.RRect), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterBinding.UI.RRect _ClipRRect { get; set; }
        internal virtual FlutterBinding.UI.Clip _ClipBehavior { get; set; }
        public virtual FlutterBinding.UI.RRect ClipRRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public ClipPathLayer(Path clipPath = default(Path), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual Path _ClipPath { get; set; }
        internal virtual FlutterBinding.UI.Clip _ClipBehavior { get; set; }
        public virtual Path ClipPath { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A composite layer that applies a [ColorFilter] to its children.
    /// </Summary>
    public class ColorFilterLayer : FlutterSDK.Rendering.Layer.ContainerLayer
    {
        #region constructors
        public ColorFilterLayer(ColorFilter colorFilter = default(ColorFilter))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual ColorFilter _ColorFilter { get; set; }
        public virtual ColorFilter ColorFilter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A composite layer that applies an [ImageFilter] to its children.
    /// </Summary>
    public class ImageFilterLayer : FlutterSDK.Rendering.Layer.ContainerLayer
    {
        #region constructors
        public ImageFilterLayer(ImageFilter imageFilter = default(ImageFilter))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual ImageFilter _ImageFilter { get; set; }
        public virtual ImageFilter ImageFilter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public TransformLayer(Matrix4 transform = default(Matrix4), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
        : base(offset: offset)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual Matrix4 _Transform { get; set; }
        internal virtual Matrix4 _LastEffectiveTransform { get; set; }
        internal virtual Matrix4 _InvertedTransform { get; set; }
        internal virtual bool _InverseDirty { get; set; }
        public virtual object Transform { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        private Offset _TransformOffset(FlutterBinding.UI.Offset localPosition) { throw new NotImplementedException(); }


        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


        public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public OpacityLayer(int alpha = default(int), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual int _Alpha { get; set; }
        internal virtual FlutterBinding.UI.Offset _Offset { get; set; }
        public virtual int Alpha { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform) { throw new NotImplementedException(); }


        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public ShaderMaskLayer(SKShader shader = default(SKShader), FlutterBinding.UI.Rect maskRect = default(FlutterBinding.UI.Rect), FlutterBinding.UI.BlendMode blendMode = default(FlutterBinding.UI.BlendMode))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual SKShader _Shader { get; set; }
        internal virtual FlutterBinding.UI.Rect _MaskRect { get; set; }
        internal virtual FlutterBinding.UI.BlendMode _BlendMode { get; set; }
        public virtual SKShader Shader { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect MaskRect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.BlendMode BlendMode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A composited layer that applies a filter to the existing contents of the scene.
    /// </Summary>
    public class BackdropFilterLayer : FlutterSDK.Rendering.Layer.ContainerLayer
    {
        #region constructors
        public BackdropFilterLayer(ImageFilter filter = default(ImageFilter))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual ImageFilter _Filter { get; set; }
        public virtual ImageFilter Filter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public PhysicalModelLayer(Path clipPath = default(Path), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), double elevation = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
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
        #endregion

        #region methods

        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public LeaderLayer(FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.Offset = offset; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Rendering.Layer.LayerLink _Link { get; set; }
        public virtual FlutterBinding.UI.Offset Offset { get; set; }
        internal virtual FlutterBinding.UI.Offset _LastOffset { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LayerLink Link { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool AlwaysNeedsAddToScene { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Applies the transform that would be applied when compositing the given
        /// child to the given matrix.
        ///
        /// See [ContainerLayer.applyTransform] for details.
        ///
        /// The `child` argument may be null, as the same transform is applied to all
        /// children.
        /// </Summary>
        public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public FollowerLayer(FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink), bool showWhenUnlinked = true, FlutterBinding.UI.Offset unlinkedOffset = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset linkedOffset = default(FlutterBinding.UI.Offset))
        : base()
        {
            this.ShowWhenUnlinked = showWhenUnlinked;
            this.UnlinkedOffset = unlinkedOffset;
            this.LinkedOffset = linkedOffset; throw new NotImplementedException();
        }
        #endregion

        #region fields
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
        #endregion

        #region methods

        private Offset _TransformOffset<S>(FlutterBinding.UI.Offset localPosition) { throw new NotImplementedException(); }


        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


        /// <Summary>
        /// The transform that was used during the last composition phase.
        ///
        /// If the [link] was not linked to a [LeaderLayer], or if this layer has
        /// a degenerate matrix applied, then this will be null.
        ///
        /// This method returns a new [Matrix4] instance each time it is invoked.
        /// </Summary>
        public virtual Matrix4 GetLastTransform() { throw new NotImplementedException(); }


        /// <Summary>
        /// Call [applyTransform] for each layer in the provided list.
        ///
        /// The list is in reverse order (deepest first). The first layer will be
        /// treated as the child of the second, and so forth. The first layer in the
        /// list won't have [applyTransform] called on it. The first layer may be
        /// null.
        /// </Summary>
        private Matrix4 _CollectTransformForLayerChain(List<FlutterSDK.Rendering.Layer.ContainerLayer> layers) { throw new NotImplementedException(); }


        /// <Summary>
        /// Populate [_lastTransform] given the current state of the tree.
        /// </Summary>
        private void _EstablishTransform() { throw new NotImplementedException(); }


        public new void AddToScene(SceneBuilder builder, FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child, Matrix4 transform) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
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
        #region constructors
        public AnnotatedRegionLayer(T value, Size size = default(Size), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), bool opaque = false)
        : base()
        {
            this.Value = value;
            this.Size = size;
            this.Opaque = opaque; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual T Value { get; set; }
        public virtual Size Size { get; set; }
        public virtual FlutterBinding.UI.Offset Offset { get; set; }
        public virtual bool Opaque { get; set; }
        #endregion

        #region methods

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
        public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result, FlutterBinding.UI.Offset localPosition, bool onlyFirst = default(bool)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }

}
