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
namespace FlutterSDK.Physics.Springsimulation
{
    internal static class SpringsimulationDefaultClass
    {
    }

    public interface I_SpringSolution { }

    public class _SpringSolution
    {
        public virtual FlutterSDK.Physics.Springsimulation.SpringType Type { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public virtual double x(double time)
        {
            return default(double);
        }


        public virtual double Dx(double time)
        {
            return default(double);
        }

    }
    public static class _SpringSolutionMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<I_SpringSolution, _SpringSolution> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<I_SpringSolution, _SpringSolution>();
        static _SpringSolution GetOrCreate(I_SpringSolution instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new _SpringSolution();
                _table.Add(instance, value);
            }
            return (_SpringSolution)value;
        }
        public static FlutterSDK.Physics.Springsimulation.SpringType TypeProperty(this I_SpringSolution instance) => GetOrCreate(instance).Type;
        public static double x(this I_SpringSolution instance, double time) => GetOrCreate(instance).x(time);
        public static double Dx(this I_SpringSolution instance, double time) => GetOrCreate(instance).Dx(time);
    }


    /// <Summary>
    /// Structure that describes a spring's constants.
    ///
    /// Used to configure a [SpringSimulation].
    /// </Summary>
    public class SpringDescription
    {
        /// <Summary>
        /// Creates a spring given the mass, stiffness, and the damping coefficient.
        ///
        /// See [mass], [stiffness], and [damping] for the units of the arguments.
        /// </Summary>
        public SpringDescription(double mass = default(double), double stiffness = default(double), double damping = default(double))
        {
            this.Mass = mass;
            this.Stiffness = stiffness;
            this.Damping = damping;
        }
        /// <Summary>
        /// Creates a spring given the mass (m), stiffness (k), and damping ratio (ζ).
        /// The damping ratio is especially useful trying to determining the type of
        /// spring to create. A ratio of 1.0 creates a critically damped spring, > 1.0
        /// creates an overdamped spring and < 1.0 an underdamped one.
        ///
        /// See [mass] and [stiffness] for the units for those arguments. The damping
        /// ratio is unitless.
        /// </Summary>
        public static SpringDescription WithDampingRatio(double mass = default(double), double stiffness = default(double), double ratio = 1.0)
        {
            var instance = new SpringDescription(); instance.Mass = mass;
            instance.Stiffness = stiffness;
        }
        /// <Summary>
        /// The mass of the spring (m). The units are arbitrary, but all springs
        /// within a system should use the same mass units.
        /// </Summary>
        public virtual double Mass { get; set; }
        /// <Summary>
        /// The spring constant (k). The units of stiffness are M/T², where M is the
        /// mass unit used for the value of the [mass] property, and T is the time
        /// unit used for driving the [SpringSimulation].
        /// </Summary>
        public virtual double Stiffness { get; set; }
        /// <Summary>
        /// The damping coefficient (c).
        ///
        /// Do not confuse the damping _coefficient_ (c) with the damping _ratio_ (ζ).
        /// To create a [SpringDescription] with a damping ratio, use the [new
        /// SpringDescription.withDampingRatio] constructor.
        ///
        /// The units of the damping coefficient are M/T, where M is the mass unit
        /// used for the value of the [mass] property, and T is the time unit used for
        /// driving the [SpringSimulation].
        /// </Summary>
        public virtual double Damping { get; set; }

    }


    /// <Summary>
    /// A spring simulation.
    ///
    /// Models a particle attached to a spring that follows Hooke's law.
    /// </Summary>
    public class SpringSimulation : FlutterSDK.Physics.Simulation.Simulation
    {
        /// <Summary>
        /// Creates a spring simulation from the provided spring description, start
        /// distance, end distance, and initial velocity.
        ///
        /// The units for the start and end distance arguments are arbitrary, but must
        /// be consistent with the units used for other lengths in the system.
        ///
        /// The units for the velocity are L/T, where L is the aforementioned
        /// arbitrary unit of length, and T is the time unit used for driving the
        /// [SpringSimulation].
        /// </Summary>
        public SpringSimulation(FlutterSDK.Physics.Springsimulation.SpringDescription spring, double start, double end, double velocity, FlutterSDK.Physics.Tolerance.Tolerance tolerance = default(FlutterSDK.Physics.Tolerance.Tolerance))
        : base(tolerance: tolerance)
        {

        }
        internal virtual double _EndPosition { get; set; }
        internal virtual FlutterSDK.Physics.Springsimulation._SpringSolution _Solution { get; set; }
        public virtual FlutterSDK.Physics.Springsimulation.SpringType Type { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new double x(double time) => _EndPosition + _Solution.x(time);



        public new double Dx(double time) => _Solution.Dx(time);



        public new bool IsDone(double time)
        {
            return UtilsDefaultClass.NearZero(_Solution.x(time), Tolerance.Distance) && UtilsDefaultClass.NearZero(_Solution.Dx(time), Tolerance.Velocity);
        }




    }


    /// <Summary>
    /// A [SpringSimulation] where the value of [x] is guaranteed to have exactly the
    /// end value when the simulation [isDone].
    /// </Summary>
    public class ScrollSpringSimulation : FlutterSDK.Physics.Springsimulation.SpringSimulation
    {
        /// <Summary>
        /// Creates a spring simulation from the provided spring description, start
        /// distance, end distance, and initial velocity.
        ///
        /// See the [new SpringSimulation] constructor on the superclass for a
        /// discussion of the arguments' units.
        /// </Summary>
        public ScrollSpringSimulation(FlutterSDK.Physics.Springsimulation.SpringDescription spring, double start, double end, double velocity, FlutterSDK.Physics.Tolerance.Tolerance tolerance = default(FlutterSDK.Physics.Tolerance.Tolerance))
        : base(spring, start, end, velocity, tolerance: tolerance)
        {

        }

        public new double x(double time) => IsDone(time) ? _EndPosition : base.x(time);


    }


    public class _CriticalSolution : I_SpringSolution
    {
        public _CriticalSolution(FlutterSDK.Physics.Springsimulation.SpringDescription spring, double distance, double velocity)
        {

            double r = -spring.Damping / (2.0 * spring.Mass);
            double c1 = distance;
            double c2 = velocity / (r * distance);
            return _CriticalSolution.WithArgs(r, c1, c2);
        }


        public static _CriticalSolution WithArgs(double r, double c1, double c2)
        {
            var instance = new _CriticalSolution();
        }
        internal virtual double _R { get; set; }
        internal virtual double _C1 { get; set; }
        internal virtual double _C2 { get; set; }
        public virtual FlutterSDK.Physics.Springsimulation.SpringType Type { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new double x(double time)
        {
            return (_C1 + _C2 * time) * Dart.Math.MathDefaultClass.Pow(Math.Dart.Math.MathDefaultClass.e, _R * time);
        }




        public new double Dx(double time)
        {
            double power = Dart.Math.MathDefaultClass.Pow(Math.Dart.Math.MathDefaultClass.e, _R * time) as double;
            return _R * (_C1 + _C2 * time) * power + _C2 * power;
        }



    }


    public class _OverdampedSolution : I_SpringSolution
    {
        public _OverdampedSolution(FlutterSDK.Physics.Springsimulation.SpringDescription spring, double distance, double velocity)
        {

            double cmk = spring.Damping * spring.Damping - 4 * spring.Mass * spring.Stiffness;
            double r1 = (-spring.Damping - Dart.Math.MathDefaultClass.Sqrt(cmk)) / (2.0 * spring.Mass);
            double r2 = (-spring.Damping + Dart.Math.MathDefaultClass.Sqrt(cmk)) / (2.0 * spring.Mass);
            double c2 = (velocity - r1 * distance) / (r2 - r1);
            double c1 = distance - c2;
            return _OverdampedSolution.WithArgs(r1, r2, c1, c2);
        }


        public static _OverdampedSolution WithArgs(double r1, double r2, double c1, double c2)
        {
            var instance = new _OverdampedSolution();
        }
        internal virtual double _R1 { get; set; }
        internal virtual double _R2 { get; set; }
        internal virtual double _C1 { get; set; }
        internal virtual double _C2 { get; set; }
        public virtual FlutterSDK.Physics.Springsimulation.SpringType Type { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new double x(double time)
        {
            return _C1 * Dart.Math.MathDefaultClass.Pow(Math.Dart.Math.MathDefaultClass.e, _R1 * time) + _C2 * Dart.Math.MathDefaultClass.Pow(Math.Dart.Math.MathDefaultClass.e, _R2 * time);
        }




        public new double Dx(double time)
        {
            return _C1 * _R1 * Dart.Math.MathDefaultClass.Pow(Math.Dart.Math.MathDefaultClass.e, _R1 * time) + _C2 * _R2 * Dart.Math.MathDefaultClass.Pow(Math.Dart.Math.MathDefaultClass.e, _R2 * time);
        }



    }


    public class _UnderdampedSolution : I_SpringSolution
    {
        public _UnderdampedSolution(FlutterSDK.Physics.Springsimulation.SpringDescription spring, double distance, double velocity)
        {

            double w = Dart.Math.MathDefaultClass.Sqrt(4.0 * spring.Mass * spring.Stiffness - spring.Damping * spring.Damping) / (2.0 * spring.Mass);
            double r = -(spring.Damping / 2.0 * spring.Mass);
            double c1 = distance;
            double c2 = (velocity - r * distance) / w;
            return _UnderdampedSolution.WithArgs(w, r, c1, c2);
        }


        public static _UnderdampedSolution WithArgs(double w, double r, double c1, double c2)
        {
            var instance = new _UnderdampedSolution();
        }
        internal virtual double _W { get; set; }
        internal virtual double _R { get; set; }
        internal virtual double _C1 { get; set; }
        internal virtual double _C2 { get; set; }
        public virtual FlutterSDK.Physics.Springsimulation.SpringType Type { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new double x(double time)
        {
            return (Dart.Math.MathDefaultClass.Pow(Math.Dart.Math.MathDefaultClass.e, _R * time) as double) * (_C1 * Dart.Math.MathDefaultClass.Cos(_W * time) + _C2 * Dart.Math.MathDefaultClass.Sin(_W * time));
        }




        public new double Dx(double time)
        {
            double power = Dart.Math.MathDefaultClass.Pow(Math.Dart.Math.MathDefaultClass.e, _R * time) as double;
            double cosine = Dart.Math.MathDefaultClass.Cos(_W * time);
            double sine = Dart.Math.MathDefaultClass.Sin(_W * time);
            return power * (_C2 * _W * cosine - _C1 * _W * sine) + _R * power * (_C2 * sine + _C1 * cosine);
        }



    }


    /// <Summary>
    /// The kind of spring solution that the [SpringSimulation] is using to simulate the spring.
    ///
    /// See [SpringSimulation.type].
    /// </Summary>
    public enum SpringType
    {

        /// <Summary>
        /// A spring that does not bounce and returns to its rest position in the
        /// shortest possible time.
        /// </Summary>
        CriticallyDamped,
        /// <Summary>
        /// A spring that bounces.
        /// </Summary>
        UnderDamped,
        /// <Summary>
        /// A spring that does not bounce but takes longer to return to its rest
        /// position than a [criticallyDamped] one.
        /// </Summary>
        OverDamped,
    }

}
