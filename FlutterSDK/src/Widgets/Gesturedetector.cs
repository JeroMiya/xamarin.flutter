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
namespace FlutterSDK.Widgets.Gesturedetector
{
    /// <Summary>
    /// Signature for closures that implement [GestureRecognizerFactory.constructor].
    /// </Summary>
    public delegate T GestureRecognizerFactoryConstructor<T>();
    /// <Summary>
    /// Signature for closures that implement [GestureRecognizerFactory.initializer].
    /// </Summary>
    public delegate void GestureRecognizerFactoryInitializer<T>(T instance);
    public delegate void _AssignSemantics(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler p1);
    internal static class GesturedetectorDefaultClass
    {
    }

    /// <Summary>
    /// Factory for creating gesture recognizers.
    ///
    /// `T` is the type of gesture recognizer this class manages.
    ///
    /// Used by [RawGestureDetector.gestures].
    /// </Summary>
    public interface IGestureRecognizerFactory<T>
    {
        T Constructor();
        void Initializer(T instance);
    }


    /// <Summary>
    /// A base class that describes what semantics notations a [RawGestureDetector]
    /// should add to the render object [RenderSemanticsGestureHandler].
    ///
    /// It is used to allow custom [GestureDetector]s to add semantics notations.
    /// </Summary>
    public interface ISemanticsGestureDelegate
    {
        void AssignSemantics(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject);
        string ToString();
    }


    /// <Summary>
    /// Factory for creating gesture recognizers.
    ///
    /// `T` is the type of gesture recognizer this class manages.
    ///
    /// Used by [RawGestureDetector.gestures].
    /// </Summary>
    public class GestureRecognizerFactory<T>
    {
        /// <Summary>
        /// Abstract const constructor. This constructor enables subclasses to provide
        /// const constructors so that they can be used in const expressions.
        /// </Summary>
        public GestureRecognizerFactory()
        {

        }

        /// <Summary>
        /// Must return an instance of T.
        /// </Summary>
        public virtual T Constructor()
        {
            return default(T);
        }


        /// <Summary>
        /// Must configure the given instance (which will have been created by
        /// `constructor`).
        ///
        /// This normally means setting the callbacks.
        /// </Summary>
        public virtual void Initializer(T instance)
        {
        }


        private bool _DebugAssertTypeMatches(Type type)
        {

            return true;
        }



    }


    /// <Summary>
    /// Factory for creating gesture recognizers that delegates to callbacks.
    ///
    /// Used by [RawGestureDetector.gestures].
    /// </Summary>
    public class GestureRecognizerFactoryWithHandlers<T> : FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<T>
    {
        /// <Summary>
        /// Creates a gesture recognizer factory with the given callbacks.
        ///
        /// The arguments must not be null.
        /// </Summary>
        public GestureRecognizerFactoryWithHandlers(FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactoryConstructor<T> _constructor, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactoryInitializer<T> _initializer)
        : base()
        {
            this._Constructor = _constructor;
            this._Initializer = _initializer;
        }
        internal virtual FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactoryConstructor<T> _Constructor { get; set; }
        internal virtual FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactoryInitializer<T> _Initializer { get; set; }

        public new T Constructor() => _Constructor();



        public new void Initializer(T instance) => _Initializer(instance);


    }


    /// <Summary>
    /// A widget that detects gestures.
    ///
    /// Attempts to recognize gestures that correspond to its non-null callbacks.
    ///
    /// If this widget has a child, it defers to that child for its sizing behavior.
    /// If it does not have a child, it grows to fit the parent instead.
    ///
    /// By default a GestureDetector with an invisible child ignores touches;
    /// this behavior can be controlled with [behavior].
    ///
    /// GestureDetector also listens for accessibility events and maps
    /// them to the callbacks. To ignore accessibility events, set
    /// [excludeFromSemantics] to true.
    ///
    /// See <http://flutter.dev/gestures/> for additional information.
    ///
    /// Material design applications typically react to touches with ink splash
    /// effects. The [InkWell] class implements this effect and can be used in place
    /// of a [GestureDetector] for handling taps.
    ///
    /// {@animation 200 150 https://flutter.github.io/assets-for-api-docs/assets/widgets/gesture_detector.mp4}
    ///
    /// {@tool snippet}
    ///
    /// This example turns the light bulb yellow when the "turn lights on" button is
    /// tapped by setting the `_lights` field:
    ///
    /// ```dart
    /// Container(
    ///   alignment: FractionalOffset.center,
    ///   color: Colors.white,
    ///   child: Column(
    ///     mainAxisAlignment: MainAxisAlignment.center,
    ///     children: <Widget>[
    ///       Padding(
    ///         padding: const EdgeInsets.all(8.0),
    ///         child: Icon(
    ///           Icons.lightbulb_outline,
    ///           color: _lights ? Colors.yellow.shade600 : Colors.black,
    ///           size: 60,
    ///         ),
    ///       ),
    ///       GestureDetector(
    ///         onTap: () {
    ///           setState(() {
    ///             _lights = true;
    ///           });
    ///         },
    ///         child: Container(
    ///           color: Colors.yellow.shade600,
    ///           padding: const EdgeInsets.all(8),
    ///           child: const Text('TURN LIGHTS ON'),
    ///         ),
    ///       ),
    ///     ],
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ## Debugging
    ///
    /// To see how large the hit test box of a [GestureDetector] is for debugging
    /// purposes, set [debugPaintPointersEnabled] to true.
    /// </Summary>
    public class GestureDetector : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a widget that detects gestures.
        ///
        /// Pan and scale callbacks cannot be used simultaneously because scale is a
        /// superset of pan. Simply use the scale callbacks instead.
        ///
        /// Horizontal and vertical drag callbacks cannot be used simultaneously
        /// because a combination of a horizontal and vertical drag is a pan. Simply
        /// use the pan callbacks instead.
        ///
        /// By default, gesture detectors contribute semantic information to the tree
        /// that is used by assistive technology.
        /// </Summary>
        public GestureDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Gestures.Tap.GestureTapDownCallback onTapDown = default(FlutterSDK.Gestures.Tap.GestureTapDownCallback), FlutterSDK.Gestures.Tap.GestureTapUpCallback onTapUp = default(FlutterSDK.Gestures.Tap.GestureTapUpCallback), FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Tap.GestureTapCancelCallback onTapCancel = default(FlutterSDK.Gestures.Tap.GestureTapCancelCallback), FlutterSDK.Gestures.Tap.GestureTapDownCallback onSecondaryTapDown = default(FlutterSDK.Gestures.Tap.GestureTapDownCallback), FlutterSDK.Gestures.Tap.GestureTapUpCallback onSecondaryTapUp = default(FlutterSDK.Gestures.Tap.GestureTapUpCallback), FlutterSDK.Gestures.Tap.GestureTapCancelCallback onSecondaryTapCancel = default(FlutterSDK.Gestures.Tap.GestureTapCancelCallback), FlutterSDK.Gestures.Tap.GestureTapCallback onDoubleTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback), FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback onLongPressStart = default(FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback), FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback onLongPressMoveUpdate = default(FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback), FlutterSDK.Gestures.Longpress.GestureLongPressUpCallback onLongPressUp = default(FlutterSDK.Gestures.Longpress.GestureLongPressUpCallback), FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback onLongPressEnd = default(FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback), FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback onVerticalDragDown = default(FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback), FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback onVerticalDragStart = default(FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback), FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback onVerticalDragUpdate = default(FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback), FlutterSDK.Gestures.Monodrag.GestureDragEndCallback onVerticalDragEnd = default(FlutterSDK.Gestures.Monodrag.GestureDragEndCallback), FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback onVerticalDragCancel = default(FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback), FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback onHorizontalDragDown = default(FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback), FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback onHorizontalDragStart = default(FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback), FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback onHorizontalDragUpdate = default(FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback), FlutterSDK.Gestures.Monodrag.GestureDragEndCallback onHorizontalDragEnd = default(FlutterSDK.Gestures.Monodrag.GestureDragEndCallback), FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback onHorizontalDragCancel = default(FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback), FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback onForcePressStart = default(FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback), FlutterSDK.Gestures.Forcepress.GestureForcePressPeakCallback onForcePressPeak = default(FlutterSDK.Gestures.Forcepress.GestureForcePressPeakCallback), FlutterSDK.Gestures.Forcepress.GestureForcePressUpdateCallback onForcePressUpdate = default(FlutterSDK.Gestures.Forcepress.GestureForcePressUpdateCallback), FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback onForcePressEnd = default(FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback), FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback onPanDown = default(FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback), FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback onPanStart = default(FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback), FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback onPanUpdate = default(FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback), FlutterSDK.Gestures.Monodrag.GestureDragEndCallback onPanEnd = default(FlutterSDK.Gestures.Monodrag.GestureDragEndCallback), FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback onPanCancel = default(FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback), FlutterSDK.Gestures.Scale.GestureScaleStartCallback onScaleStart = default(FlutterSDK.Gestures.Scale.GestureScaleStartCallback), FlutterSDK.Gestures.Scale.GestureScaleUpdateCallback onScaleUpdate = default(FlutterSDK.Gestures.Scale.GestureScaleUpdateCallback), FlutterSDK.Gestures.Scale.GestureScaleEndCallback onScaleEnd = default(FlutterSDK.Gestures.Scale.GestureScaleEndCallback), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), bool excludeFromSemantics = false, FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.Child = child;
            this.OnTapDown = onTapDown;
            this.OnTapUp = onTapUp;
            this.OnTap = onTap;
            this.OnTapCancel = onTapCancel;
            this.OnSecondaryTapDown = onSecondaryTapDown;
            this.OnSecondaryTapUp = onSecondaryTapUp;
            this.OnSecondaryTapCancel = onSecondaryTapCancel;
            this.OnDoubleTap = onDoubleTap;
            this.OnLongPress = onLongPress;
            this.OnLongPressStart = onLongPressStart;
            this.OnLongPressMoveUpdate = onLongPressMoveUpdate;
            this.OnLongPressUp = onLongPressUp;
            this.OnLongPressEnd = onLongPressEnd;
            this.OnVerticalDragDown = onVerticalDragDown;
            this.OnVerticalDragStart = onVerticalDragStart;
            this.OnVerticalDragUpdate = onVerticalDragUpdate;
            this.OnVerticalDragEnd = onVerticalDragEnd;
            this.OnVerticalDragCancel = onVerticalDragCancel;
            this.OnHorizontalDragDown = onHorizontalDragDown;
            this.OnHorizontalDragStart = onHorizontalDragStart;
            this.OnHorizontalDragUpdate = onHorizontalDragUpdate;
            this.OnHorizontalDragEnd = onHorizontalDragEnd;
            this.OnHorizontalDragCancel = onHorizontalDragCancel;
            this.OnForcePressStart = onForcePressStart;
            this.OnForcePressPeak = onForcePressPeak;
            this.OnForcePressUpdate = onForcePressUpdate;
            this.OnForcePressEnd = onForcePressEnd;
            this.OnPanDown = onPanDown;
            this.OnPanStart = onPanStart;
            this.OnPanUpdate = onPanUpdate;
            this.OnPanEnd = onPanEnd;
            this.OnPanCancel = onPanCancel;
            this.OnScaleStart = onScaleStart;
            this.OnScaleUpdate = onScaleUpdate;
            this.OnScaleEnd = onScaleEnd;
            this.Behavior = behavior;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.DragStartBehavior = dragStartBehavior;
        }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// A pointer that might cause a tap with a primary button has contacted the
        /// screen at a particular location.
        ///
        /// This is called after a short timeout, even if the winning gesture has not
        /// yet been selected. If the tap gesture wins, [onTapUp] will be called,
        /// otherwise [onTapCancel] will be called.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapDownCallback OnTapDown { get; set; }
        /// <Summary>
        /// A pointer that will trigger a tap with a primary button has stopped
        /// contacting the screen at a particular location.
        ///
        /// This triggers immediately before [onTap] in the case of the tap gesture
        /// winning. If the tap gesture did not win, [onTapCancel] is called instead.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapUpCallback OnTapUp { get; set; }
        /// <Summary>
        /// A tap with a primary button has occurred.
        ///
        /// This triggers when the tap gesture wins. If the tap gesture did not win,
        /// [onTapCancel] is called instead.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onTapUp], which is called at the same time but includes details
        ///    regarding the pointer position.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap { get; set; }
        /// <Summary>
        /// The pointer that previously triggered [onTapDown] will not end up causing
        /// a tap.
        ///
        /// This is called after [onTapDown], and instead of [onTapUp] and [onTap], if
        /// the tap gesture did not win.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapCancelCallback OnTapCancel { get; set; }
        /// <Summary>
        /// A pointer that might cause a tap with a secondary button has contacted the
        /// screen at a particular location.
        ///
        /// This is called after a short timeout, even if the winning gesture has not
        /// yet been selected. If the tap gesture wins, [onSecondaryTapUp] will be
        /// called, otherwise [onSecondaryTapCancel] will be called.
        ///
        /// See also:
        ///
        ///  * [kSecondaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapDownCallback OnSecondaryTapDown { get; set; }
        /// <Summary>
        /// A pointer that will trigger a tap with a secondary button has stopped
        /// contacting the screen at a particular location.
        ///
        /// This triggers in the case of the tap gesture winning. If the tap gesture
        /// did not win, [onSecondaryTapCancel] is called instead.
        ///
        /// See also:
        ///
        ///  * [kSecondaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapUpCallback OnSecondaryTapUp { get; set; }
        /// <Summary>
        /// The pointer that previously triggered [onSecondaryTapDown] will not end up
        /// causing a tap.
        ///
        /// This is called after [onSecondaryTapDown], and instead of
        /// [onSecondaryTapUp], if the tap gesture did not win.
        ///
        /// See also:
        ///
        ///  * [kSecondaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapCancelCallback OnSecondaryTapCancel { get; set; }
        /// <Summary>
        /// The user has tapped the screen with a primary button at the same location
        /// twice in quick succession.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnDoubleTap { get; set; }
        /// <Summary>
        /// Called when a long press gesture with a primary button has been recognized.
        ///
        /// Triggered when a pointer has remained in contact with the screen at the
        /// same location for a long period of time.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onLongPressStart], which has the same timing but has gesture details.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback OnLongPress { get; set; }
        /// <Summary>
        /// Called when a long press gesture with a primary button has been recognized.
        ///
        /// Triggered when a pointer has remained in contact with the screen at the
        /// same location for a long period of time.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onLongPress], which has the same timing but without the gesture details.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback OnLongPressStart { get; set; }
        /// <Summary>
        /// A pointer has been drag-moved after a long press with a primary button.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback OnLongPressMoveUpdate { get; set; }
        /// <Summary>
        /// A pointer that has triggered a long-press with a primary button has
        /// stopped contacting the screen.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onLongPressEnd], which has the same timing but has gesture details.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressUpCallback OnLongPressUp { get; set; }
        /// <Summary>
        /// A pointer that has triggered a long-press with a primary button has
        /// stopped contacting the screen.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        ///  * [onLongPressUp], which has the same timing but without the gesture
        ///    details.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback OnLongPressEnd { get; set; }
        /// <Summary>
        /// A pointer has contacted the screen with a primary button and might begin
        /// to move vertically.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback OnVerticalDragDown { get; set; }
        /// <Summary>
        /// A pointer has contacted the screen with a primary button and has begun to
        /// move vertically.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback OnVerticalDragStart { get; set; }
        /// <Summary>
        /// A pointer that is in contact with the screen with a primary button and
        /// moving vertically has moved in the vertical direction.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnVerticalDragUpdate { get; set; }
        /// <Summary>
        /// A pointer that was previously in contact with the screen with a primary
        /// button and moving vertically is no longer in contact with the screen and
        /// was moving at a specific velocity when it stopped contacting the screen.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragEndCallback OnVerticalDragEnd { get; set; }
        /// <Summary>
        /// The pointer that previously triggered [onVerticalDragDown] did not
        /// complete.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback OnVerticalDragCancel { get; set; }
        /// <Summary>
        /// A pointer has contacted the screen with a primary button and might begin
        /// to move horizontally.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback OnHorizontalDragDown { get; set; }
        /// <Summary>
        /// A pointer has contacted the screen with a primary button and has begun to
        /// move horizontally.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback OnHorizontalDragStart { get; set; }
        /// <Summary>
        /// A pointer that is in contact with the screen with a primary button and
        /// moving horizontally has moved in the horizontal direction.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnHorizontalDragUpdate { get; set; }
        /// <Summary>
        /// A pointer that was previously in contact with the screen with a primary
        /// button and moving horizontally is no longer in contact with the screen and
        /// was moving at a specific velocity when it stopped contacting the screen.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragEndCallback OnHorizontalDragEnd { get; set; }
        /// <Summary>
        /// The pointer that previously triggered [onHorizontalDragDown] did not
        /// complete.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback OnHorizontalDragCancel { get; set; }
        /// <Summary>
        /// A pointer has contacted the screen with a primary button and might begin
        /// to move.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragDownCallback OnPanDown { get; set; }
        /// <Summary>
        /// A pointer has contacted the screen with a primary button and has begun to
        /// move.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback OnPanStart { get; set; }
        /// <Summary>
        /// A pointer that is in contact with the screen with a primary button and
        /// moving has moved again.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback OnPanUpdate { get; set; }
        /// <Summary>
        /// A pointer that was previously in contact with the screen with a primary
        /// button and moving is no longer in contact with the screen and was moving
        /// at a specific velocity when it stopped contacting the screen.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragEndCallback OnPanEnd { get; set; }
        /// <Summary>
        /// The pointer that previously triggered [onPanDown] did not complete.
        ///
        /// See also:
        ///
        ///  * [kPrimaryButton], the button this callback responds to.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragCancelCallback OnPanCancel { get; set; }
        /// <Summary>
        /// The pointers in contact with the screen have established a focal point and
        /// initial scale of 1.0.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Scale.GestureScaleStartCallback OnScaleStart { get; set; }
        /// <Summary>
        /// The pointers in contact with the screen have indicated a new focal point
        /// and/or scale.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Scale.GestureScaleUpdateCallback OnScaleUpdate { get; set; }
        /// <Summary>
        /// The pointers are no longer in contact with the screen.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Scale.GestureScaleEndCallback OnScaleEnd { get; set; }
        /// <Summary>
        /// The pointer is in contact with the screen and has pressed with sufficient
        /// force to initiate a force press. The amount of force is at least
        /// [ForcePressGestureRecognizer.startPressure].
        ///
        /// Note that this callback will only be fired on devices with pressure
        /// detecting screens.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback OnForcePressStart { get; set; }
        /// <Summary>
        /// The pointer is in contact with the screen and has pressed with the maximum
        /// force. The amount of force is at least
        /// [ForcePressGestureRecognizer.peakPressure].
        ///
        /// Note that this callback will only be fired on devices with pressure
        /// detecting screens.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressPeakCallback OnForcePressPeak { get; set; }
        /// <Summary>
        /// A pointer is in contact with the screen, has previously passed the
        /// [ForcePressGestureRecognizer.startPressure] and is either moving on the
        /// plane of the screen, pressing the screen with varying forces or both
        /// simultaneously.
        ///
        /// Note that this callback will only be fired on devices with pressure
        /// detecting screens.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressUpdateCallback OnForcePressUpdate { get; set; }
        /// <Summary>
        /// The pointer is no longer in contact with the screen.
        ///
        /// Note that this callback will only be fired on devices with pressure
        /// detecting screens.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback OnForcePressEnd { get; set; }
        /// <Summary>
        /// How this gesture detector should behave during hit testing.
        ///
        /// This defaults to [HitTestBehavior.deferToChild] if [child] is not null and
        /// [HitTestBehavior.translucent] if child is null.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        /// <Summary>
        /// Whether to exclude these gestures from the semantics tree. For
        /// example, the long-press gesture for showing a tooltip is
        /// excluded because the tooltip itself is included in the semantics
        /// tree directly and so having a gesture to show it would result in
        /// duplication of information.
        /// </Summary>
        public virtual bool ExcludeFromSemantics { get; set; }
        /// <Summary>
        /// Determines the way that drag start behavior is handled.
        ///
        /// If set to [DragStartBehavior.start], gesture drag behavior will
        /// begin upon the detection of a drag gesture. If set to
        /// [DragStartBehavior.down] it will begin when a down event is first detected.
        ///
        /// In general, setting this to [DragStartBehavior.start] will make drag
        /// animation smoother and setting it to [DragStartBehavior.down] will make
        /// drag behavior feel slightly more reactive.
        ///
        /// By default, the drag start behavior is [DragStartBehavior.start].
        ///
        /// Only the [onStart] callbacks for the [VerticalDragGestureRecognizer],
        /// [HorizontalDragGestureRecognizer] and [PanGestureRecognizer] are affected
        /// by this setting.
        ///
        /// See also:
        ///
        ///  * [DragGestureRecognizer.dragStartBehavior], which gives an example for the different behaviors.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Dictionary<Type, GestureRecognizerFactory> gestures = new Dictionary<Type, GestureRecognizerFactory> { };
            if (OnTapDown != null || OnTapUp != null || OnTap != null || OnTapCancel != null || OnSecondaryTapDown != null || OnSecondaryTapUp != null || OnSecondaryTapCancel != null)
            {
                gestures[TapDefaultClass.TapGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<TapGestureRecognizer>(() => =>new TapGestureRecognizer(debugOwner: this), (TapGestureRecognizer instance) =>
                {
                    ..OnTapDown = OnTapDown..OnTapUp = OnTapUp..OnTap = OnTap..OnTapCancel = OnTapCancel..OnSecondaryTapDown = OnSecondaryTapDown..OnSecondaryTapUp = OnSecondaryTapUp..OnSecondaryTapCancel = OnSecondaryTapCancel;
                }
                );
            }

            if (OnDoubleTap != null)
            {
                gestures[MultitapDefaultClass.DoubleTapGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<DoubleTapGestureRecognizer>(() => =>new DoubleTapGestureRecognizer(debugOwner: this), (DoubleTapGestureRecognizer instance) =>
                {
                    instance.OnDoubleTap = OnDoubleTap;
                }
                );
            }

            if (OnLongPress != null || OnLongPressUp != null || OnLongPressStart != null || OnLongPressMoveUpdate != null || OnLongPressEnd != null)
            {
                gestures[LongpressDefaultClass.LongPressGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<LongPressGestureRecognizer>(() => =>new LongPressGestureRecognizer(debugOwner: this), (LongPressGestureRecognizer instance) =>
                {
                    ..OnLongPress = OnLongPress..OnLongPressStart = OnLongPressStart..OnLongPressMoveUpdate = OnLongPressMoveUpdate..OnLongPressEnd = OnLongPressEnd..OnLongPressUp = OnLongPressUp;
                }
                );
            }

            if (OnVerticalDragDown != null || OnVerticalDragStart != null || OnVerticalDragUpdate != null || OnVerticalDragEnd != null || OnVerticalDragCancel != null)
            {
                gestures[MonodragDefaultClass.VerticalDragGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<VerticalDragGestureRecognizer>(() => =>new VerticalDragGestureRecognizer(debugOwner: this), (VerticalDragGestureRecognizer instance) =>
                {
                    ..OnDown = OnVerticalDragDown..OnStart = OnVerticalDragStart..OnUpdate = OnVerticalDragUpdate..OnEnd = OnVerticalDragEnd..OnCancel = OnVerticalDragCancel..DragStartBehavior = DragStartBehavior;
                }
                );
            }

            if (OnHorizontalDragDown != null || OnHorizontalDragStart != null || OnHorizontalDragUpdate != null || OnHorizontalDragEnd != null || OnHorizontalDragCancel != null)
            {
                gestures[MonodragDefaultClass.HorizontalDragGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<HorizontalDragGestureRecognizer>(() => =>new HorizontalDragGestureRecognizer(debugOwner: this), (HorizontalDragGestureRecognizer instance) =>
                {
                    ..OnDown = OnHorizontalDragDown..OnStart = OnHorizontalDragStart..OnUpdate = OnHorizontalDragUpdate..OnEnd = OnHorizontalDragEnd..OnCancel = OnHorizontalDragCancel..DragStartBehavior = DragStartBehavior;
                }
                );
            }

            if (OnPanDown != null || OnPanStart != null || OnPanUpdate != null || OnPanEnd != null || OnPanCancel != null)
            {
                gestures[MonodragDefaultClass.PanGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<PanGestureRecognizer>(() => =>new PanGestureRecognizer(debugOwner: this), (PanGestureRecognizer instance) =>
                {
                    ..OnDown = OnPanDown..OnStart = OnPanStart..OnUpdate = OnPanUpdate..OnEnd = OnPanEnd..OnCancel = OnPanCancel..DragStartBehavior = DragStartBehavior;
                }
                );
            }

            if (OnScaleStart != null || OnScaleUpdate != null || OnScaleEnd != null)
            {
                gestures[ScaleDefaultClass.ScaleGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<ScaleGestureRecognizer>(() => =>new ScaleGestureRecognizer(debugOwner: this), (ScaleGestureRecognizer instance) =>
                {
                    ..OnStart = OnScaleStart..OnUpdate = OnScaleUpdate..OnEnd = OnScaleEnd;
                }
                );
            }

            if (OnForcePressStart != null || OnForcePressPeak != null || OnForcePressUpdate != null || OnForcePressEnd != null)
            {
                gestures[ForcepressDefaultClass.ForcePressGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<ForcePressGestureRecognizer>(() => =>new ForcePressGestureRecognizer(debugOwner: this), (ForcePressGestureRecognizer instance) =>
                {
                    ..OnStart = OnForcePressStart..OnPeak = OnForcePressPeak..OnUpdate = OnForcePressUpdate..OnEnd = OnForcePressEnd;
                }
                );
            }

            return new RawGestureDetector(gestures: gestures, behavior: Behavior, excludeFromSemantics: ExcludeFromSemantics, child: Child);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new EnumProperty<DragStartBehavior>("startBehavior", DragStartBehavior));
        }



    }


    /// <Summary>
    /// A widget that detects gestures described by the given gesture
    /// factories.
    ///
    /// For common gestures, use a [GestureRecognizer].
    /// [RawGestureDetector] is useful primarily when developing your
    /// own gesture recognizers.
    ///
    /// Configuring the gesture recognizers requires a carefully constructed map, as
    /// described in [gestures] and as shown in the example below.
    ///
    /// {@tool snippet}
    ///
    /// This example shows how to hook up a [TapGestureRecognizer]. It assumes that
    /// the code is being used inside a [State] object with a `_last` field that is
    /// then displayed as the child of the gesture detector.
    ///
    /// ```dart
    /// RawGestureDetector(
    ///   gestures: <Type, GestureRecognizerFactory>{
    ///     TapGestureRecognizer: GestureRecognizerFactoryWithHandlers<TapGestureRecognizer>(
    ///       () => TapGestureRecognizer(),
    ///       (TapGestureRecognizer instance) {
    ///         instance
    ///           ..onTapDown = (TapDownDetails details) { setState(() { _last = 'down'; }); }
    ///           ..onTapUp = (TapUpDetails details) { setState(() { _last = 'up'; }); }
    ///           ..onTap = () { setState(() { _last = 'tap'; }); }
    ///           ..onTapCancel = () { setState(() { _last = 'cancel'; }); };
    ///       },
    ///     ),
    ///   },
    ///   child: Container(width: 300.0, height: 300.0, color: Colors.yellow, child: Text(_last)),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [GestureDetector], a less flexible but much simpler widget that does the same thing.
    ///  * [Listener], a widget that reports raw pointer events.
    ///  * [GestureRecognizer], the class that you extend to create a custom gesture recognizer.
    /// </Summary>
    public class RawGestureDetector : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a widget that detects gestures.
        ///
        /// Gesture detectors can contribute semantic information to the tree that is
        /// used by assistive technology. The behavior can be configured by
        /// [semantics], or disabled with [excludeFromSemantics].
        /// </Summary>
        public RawGestureDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> gestures = default(Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>>), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), bool excludeFromSemantics = false, FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate semantics = default(FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate))
        : base(key: key)
        {
            this.Child = child;
            this.Gestures = gestures;
            this.Behavior = behavior;
            this.ExcludeFromSemantics = excludeFromSemantics;
            this.Semantics = semantics;
        }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The gestures that this widget will attempt to recognize.
        ///
        /// This should be a map from [GestureRecognizer] subclasses to
        /// [GestureRecognizerFactory] subclasses specialized with the same type.
        ///
        /// This value can be late-bound at layout time using
        /// [RawGestureDetectorState.replaceGestureRecognizers].
        /// </Summary>
        public virtual Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> Gestures { get; set; }
        /// <Summary>
        /// How this gesture detector should behave during hit testing.
        ///
        /// This defaults to [HitTestBehavior.deferToChild] if [child] is not null and
        /// [HitTestBehavior.translucent] if child is null.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        /// <Summary>
        /// Whether to exclude these gestures from the semantics tree. For
        /// example, the long-press gesture for showing a tooltip is
        /// excluded because the tooltip itself is included in the semantics
        /// tree directly and so having a gesture to show it would result in
        /// duplication of information.
        /// </Summary>
        public virtual bool ExcludeFromSemantics { get; set; }
        /// <Summary>
        /// Describes the semantics notations that should be added to the underlying
        /// render object [RenderSemanticsGestureHandler].
        ///
        /// It has no effect if [excludeFromSemantics] is true.
        ///
        /// When [semantics] is null, [RawGestureDetector] will fall back to a
        /// default delegate which checks if the detector owns certain gesture
        /// recognizers and calls their callbacks if they exist:
        ///
        ///  * During a semantic tap, it calls [TapGestureRecognizer]'s
        ///    `onTapDown`, `onTapUp`, and `onTap`.
        ///  * During a semantic long press, it calls [LongPressGestureRecognizer]'s
        ///    `onLongPressStart`, `onLongPress`, `onLongPressEnd` and `onLongPressUp`.
        ///  * During a semantic horizontal drag, it calls [HorizontalDragGestureRecognizer]'s
        ///    `onDown`, `onStart`, `onUpdate` and `onEnd`, then
        ///    [PanGestureRecognizer]'s `onDown`, `onStart`, `onUpdate` and `onEnd`.
        ///  * During a semantic vertical drag, it calls [VerticalDragGestureRecognizer]'s
        ///    `onDown`, `onStart`, `onUpdate` and `onEnd`, then
        ///    [PanGestureRecognizer]'s `onDown`, `onStart`, `onUpdate` and `onEnd`.
        ///
        /// {@tool snippet}
        /// This custom gesture detector listens to force presses, while also allows
        /// the same callback to be triggered by semantic long presses.
        ///
        /// ```dart
        /// class ForcePressGestureDetectorWithSemantics extends StatelessWidget {
        ///   const ForcePressGestureDetectorWithSemantics({
        ///     this.child,
        ///     this.onForcePress,
        ///   });
        ///
        ///   final Widget child;
        ///   final VoidCallback onForcePress;
        ///
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     return RawGestureDetector(
        ///       gestures: <Type, GestureRecognizerFactory>{
        ///         ForcePressGestureRecognizer: GestureRecognizerFactoryWithHandlers<ForcePressGestureRecognizer>(
        ///           () => ForcePressGestureRecognizer(debugOwner: this),
        ///           (ForcePressGestureRecognizer instance) {
        ///             instance.onStart = (_) => onForcePress();
        ///           }
        ///         ),
        ///       },
        ///       behavior: HitTestBehavior.opaque,
        ///       semantics: _LongPressSemanticsDelegate(onForcePress),
        ///       child: child,
        ///     );
        ///   }
        /// }
        ///
        /// class _LongPressSemanticsDelegate extends SemanticsGestureDelegate {
        ///   _LongPressSemanticsDelegate(this.onLongPress);
        ///
        ///   VoidCallback onLongPress;
        ///
        ///   @override
        ///   void assignSemantics(RenderSemanticsGestureHandler renderObject) {
        ///     renderObject.onLongPress = onLongPress;
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate Semantics { get; set; }

        public new FlutterSDK.Widgets.Gesturedetector.RawGestureDetectorState CreateState() => new RawGestureDetectorState();


    }


    /// <Summary>
    /// State for a [RawGestureDetector].
    /// </Summary>
    public class RawGestureDetectorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Gesturedetector.RawGestureDetector>
    {
        public RawGestureDetectorState()
        { }
        internal virtual Dictionary<Type, FlutterSDK.Gestures.Recognizer.GestureRecognizer> _Recognizers { get; set; }
        internal virtual FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate _Semantics { get; set; }
        internal virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior _DefaultBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _Semantics = Widget.Semantics ?? new _DefaultSemanticsGestureDelegate(this);
            _SyncAll(Widget.Gestures);
        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Gesturedetector.RawGestureDetector oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (!(oldWidget.Semantics == null && Widget.Semantics == null))
            {
                _Semantics = Widget.Semantics ?? new _DefaultSemanticsGestureDelegate(this);
            }

            _SyncAll(Widget.Gestures);
        }




        /// <Summary>
        /// This method can be called after the build phase, during the
        /// layout of the nearest descendant [RenderObjectWidget] of the
        /// gesture detector, to update the list of active gesture
        /// recognizers.
        ///
        /// The typical use case is [Scrollable]s, which put their viewport
        /// in their gesture detector, and then need to know the dimensions
        /// of the viewport and the viewport's child to determine whether
        /// the gesture detector should be enabled.
        ///
        /// The argument should follow the same conventions as
        /// [RawGestureDetector.gestures]. It acts like a temporary replacement for
        /// that value until the next build.
        /// </Summary>
        public virtual void ReplaceGestureRecognizers(Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> gestures)
        {

            _SyncAll(gestures);
            if (!Widget.ExcludeFromSemantics)
            {
                RenderSemanticsGestureHandler semanticsGestureHandler = Context.FindRenderObject() as RenderSemanticsGestureHandler;
                _UpdateSemanticsForRenderObject(semanticsGestureHandler);
            }

        }




        /// <Summary>
        /// This method can be called to filter the list of available semantic actions,
        /// after the render object was created.
        ///
        /// The actual filtering is happening in the next frame and a frame will be
        /// scheduled if non is pending.
        ///
        /// This is used by [Scrollable] to configure system accessibility tools so
        /// that they know in which direction a particular list can be scrolled.
        ///
        /// If this is never called, then the actions are not filtered. If the list of
        /// actions to filter changes, it must be called again.
        /// </Summary>
        public virtual void ReplaceSemanticsActions(HashSet<SemanticsAction> actions)
        {
            if (Widget.ExcludeFromSemantics) return;
            RenderSemanticsGestureHandler semanticsGestureHandler = Context.FindRenderObject() as RenderSemanticsGestureHandler;

            semanticsGestureHandler.ValidActions = actions;
        }




        public new void Dispose()
        {
            foreach (GestureRecognizer recognizer in _Recognizers.Values) recognizer.Dispose();
            _Recognizers = null;
            base.Dispose();
        }




        private void _SyncAll(Dictionary<Type, FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> gestures)
        {

            Dictionary<Type, GestureRecognizer> oldRecognizers = _Recognizers;
            _Recognizers = new Dictionary<Type, GestureRecognizer> { };
            foreach (Type type in gestures.Keys)
            {



                _Recognizers[type] = oldRecognizers[type] ?? gestures[type].Constructor();

                gestures[type].Initializer(_Recognizers[type]);
            }

            foreach (Type type in oldRecognizers.Keys)
            {
                if (!_Recognizers.ContainsKey(type)) oldRecognizers[type].Dispose();
            }

        }




        private void _HandlePointerDown(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {

            foreach (GestureRecognizer recognizer in _Recognizers.Values) recognizer.AddPointer(@event);
        }




        private void _UpdateSemanticsForRenderObject(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject)
        {


            _Semantics.AssignSemantics(renderObject);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Widget result = new Listener(onPointerDown: _HandlePointerDown, behavior: Widget.Behavior ?? _DefaultBehavior, child: Widget.Child);
            if (!Widget.ExcludeFromSemantics) result = new _GestureSemantics(child: result, assignSemantics: _UpdateSemanticsForRenderObject);
            return result;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            if (_Recognizers == null)
            {
                properties.Add(DiagnosticsNode.Message("DISPOSED"));
            }
            else
            {
                List<string> gestures = _Recognizers.Values.Map((GestureRecognizer recognizer) => =>recognizer.DebugDescription).ToList();
                properties.Add(new IterableProperty<string>("gestures", gestures, ifEmpty: "<none>"));
                properties.Add(new IterableProperty<GestureRecognizer>("recognizers", _Recognizers.Values, level: DiagnosticLevel.Fine));
                properties.Add(new DiagnosticsProperty<bool>("excludeFromSemantics", Widget.ExcludeFromSemantics, defaultValue: false));
                if (!Widget.ExcludeFromSemantics)
                {
                    properties.Add(new DiagnosticsProperty<SemanticsGestureDelegate>("semantics", Widget.Semantics, defaultValue: null));
                }

            }

            properties.Add(new EnumProperty<HitTestBehavior>("behavior", Widget.Behavior, defaultValue: null));
        }



    }


    public class _GestureSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _GestureSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Gesturedetector._AssignSemantics assignSemantics = default(FlutterSDK.Widgets.Gesturedetector._AssignSemantics))
        : base(key: key, child: child)
        {
            this.AssignSemantics = assignSemantics;
        }
        public virtual FlutterSDK.Widgets.Gesturedetector._AssignSemantics AssignSemantics { get; set; }

        public new FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            RenderSemanticsGestureHandler renderObject = new RenderSemanticsGestureHandler();
            AssignSemantics(renderObject);
            return renderObject;
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject)
        {
            AssignSemantics(renderObject);
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            AssignSemantics(renderObject);
        }



    }


    /// <Summary>
    /// A base class that describes what semantics notations a [RawGestureDetector]
    /// should add to the render object [RenderSemanticsGestureHandler].
    ///
    /// It is used to allow custom [GestureDetector]s to add semantics notations.
    /// </Summary>
    public class SemanticsGestureDelegate
    {
        /// <Summary>
        /// Create a delegate of gesture semantics.
        /// </Summary>
        public SemanticsGestureDelegate()
        {

        }

        /// <Summary>
        /// Assigns semantics notations to the [RenderSemanticsGestureHandler] render
        /// object of the gesture detector.
        ///
        /// This method is called when the widget is created, updated, or during
        /// [RawGestureDetector.replaceGestureRecognizers].
        /// </Summary>
        public virtual void AssignSemantics(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject)
        {
        }


    }


    public class _DefaultSemanticsGestureDelegate : FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate
    {
        public _DefaultSemanticsGestureDelegate(FlutterSDK.Widgets.Gesturedetector.RawGestureDetectorState detectorState)
        {
            this.DetectorState = detectorState;
        }
        public virtual FlutterSDK.Widgets.Gesturedetector.RawGestureDetectorState DetectorState { get; set; }

        public new void AssignSemantics(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject)
        {

            Dictionary<Type, GestureRecognizer> recognizers = DetectorState._Recognizers;
            ..OnTap = _GetTapHandler(recognizers)..OnLongPress = _GetLongPressHandler(recognizers)..OnHorizontalDragUpdate = _GetHorizontalDragUpdateHandler(recognizers)..OnVerticalDragUpdate = _GetVerticalDragUpdateHandler(recognizers);
        }




        private FlutterSDK.Gestures.Tap.GestureTapCallback _GetTapHandler(Dictionary<Type, FlutterSDK.Gestures.Recognizer.GestureRecognizer> recognizers)
        {
            TapGestureRecognizer tap = recognizers[TapDefaultClass.TapGestureRecognizer] as TapGestureRecognizer;
            if (tap == null) return null;

            return () =>
            {

                if (tap.OnTapDown != null) tap.OnTapDown(new TapDownDetails());
                if (tap.OnTapUp != null) tap.OnTapUp(new TapUpDetails());
                if (tap.OnTap != null) tap.OnTap();
            }
            ;
        }




        private FlutterSDK.Gestures.Longpress.GestureLongPressCallback _GetLongPressHandler(Dictionary<Type, FlutterSDK.Gestures.Recognizer.GestureRecognizer> recognizers)
        {
            LongPressGestureRecognizer longPress = recognizers[LongpressDefaultClass.LongPressGestureRecognizer] as LongPressGestureRecognizer;
            if (longPress == null) return null;
            return () =>
            {

                if (longPress.OnLongPressStart != null) longPress.OnLongPressStart(new LongPressStartDetails());
                if (longPress.OnLongPress != null) longPress.OnLongPress();
                if (longPress.OnLongPressEnd != null) longPress.OnLongPressEnd(new LongPressEndDetails());
                if (longPress.OnLongPressUp != null) longPress.OnLongPressUp();
            }
            ;
        }




        private FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback _GetHorizontalDragUpdateHandler(Dictionary<Type, FlutterSDK.Gestures.Recognizer.GestureRecognizer> recognizers)
        {
            HorizontalDragGestureRecognizer horizontal = recognizers[MonodragDefaultClass.HorizontalDragGestureRecognizer] as HorizontalDragGestureRecognizer;
            PanGestureRecognizer pan = recognizers[MonodragDefaultClass.PanGestureRecognizer] as PanGestureRecognizer;
            GestureDragUpdateCallback horizontalHandler = horizontal == null ? null : (DragUpdateDetails details) =>
            {

                if (horizontal.OnDown != null) horizontal.OnDown(new DragDownDetails());
                if (horizontal.OnStart != null) horizontal.OnStart(new DragStartDetails());
                if (horizontal.OnUpdate != null) horizontal.OnUpdate(details);
                if (horizontal.OnEnd != null) horizontal.OnEnd(new DragEndDetails(primaryVelocity: 0.0));
            }
            ;
            GestureDragUpdateCallback panHandler = pan == null ? null : (DragUpdateDetails details) =>
            {

                if (pan.OnDown != null) pan.OnDown(new DragDownDetails());
                if (pan.OnStart != null) pan.OnStart(new DragStartDetails());
                if (pan.OnUpdate != null) pan.OnUpdate(details);
                if (pan.OnEnd != null) pan.OnEnd(new DragEndDetails());
            }
            ;
            if (horizontalHandler == null && panHandler == null) return null;
            return (DragUpdateDetails details) =>
            {
                if (horizontalHandler != null) horizontalHandler(details);
                if (panHandler != null) panHandler(details);
            }
            ;
        }




        private FlutterSDK.Gestures.Dragdetails.GestureDragUpdateCallback _GetVerticalDragUpdateHandler(Dictionary<Type, FlutterSDK.Gestures.Recognizer.GestureRecognizer> recognizers)
        {
            VerticalDragGestureRecognizer vertical = recognizers[MonodragDefaultClass.VerticalDragGestureRecognizer] as VerticalDragGestureRecognizer;
            PanGestureRecognizer pan = recognizers[MonodragDefaultClass.PanGestureRecognizer] as PanGestureRecognizer;
            GestureDragUpdateCallback verticalHandler = vertical == null ? null : (DragUpdateDetails details) =>
            {

                if (vertical.OnDown != null) vertical.OnDown(new DragDownDetails());
                if (vertical.OnStart != null) vertical.OnStart(new DragStartDetails());
                if (vertical.OnUpdate != null) vertical.OnUpdate(details);
                if (vertical.OnEnd != null) vertical.OnEnd(new DragEndDetails(primaryVelocity: 0.0));
            }
            ;
            GestureDragUpdateCallback panHandler = pan == null ? null : (DragUpdateDetails details) =>
            {

                if (pan.OnDown != null) pan.OnDown(new DragDownDetails());
                if (pan.OnStart != null) pan.OnStart(new DragStartDetails());
                if (pan.OnUpdate != null) pan.OnUpdate(details);
                if (pan.OnEnd != null) pan.OnEnd(new DragEndDetails());
            }
            ;
            if (verticalHandler == null && panHandler == null) return null;
            return (DragUpdateDetails details) =>
            {
                if (verticalHandler != null) verticalHandler(details);
                if (panHandler != null) panHandler(details);
            }
            ;
        }



    }

}
