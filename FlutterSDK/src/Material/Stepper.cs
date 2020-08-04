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
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
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
namespace FlutterSDK.Material.Stepper
{
    internal static class StepperDefaultClass
    {
        public static FlutterSDK.Painting.Textstyle.TextStyle _KStepStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static Color _KErrorLight = default(Color);
        public static Color _KErrorDark = default(Color);
        public static Color _KCircleActiveLight = default(Color);
        public static Color _KCircleActiveDark = default(Color);
        public static Color _KDisabledLight = default(Color);
        public static Color _KDisabledDark = default(Color);
        public static double _KStepSize = default(double);
        public static double _KTriangleHeight = default(double);
    }

    /// <Summary>
    /// A material step used in [Stepper]. The step can have a title and subtitle,
    /// an icon within its circle, some content and a state that governs its
    /// styling.
    ///
    /// See also:
    ///
    ///  * [Stepper]
    ///  * <https://material.io/archive/guidelines/components/steppers.html>
    /// </Summary>
    public class Step
    {
        /// <Summary>
        /// Creates a step for a [Stepper].
        ///
        /// The [title], [content], and [state] arguments must not be null.
        /// </Summary>
        public Step(FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget subtitle = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget content = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Material.Stepper.StepState state = default(FlutterSDK.Material.Stepper.StepState), bool isActive = false)
        : base()
        {
            this.Title = title;
            this.Subtitle = subtitle;
            this.Content = content;
            this.State = state;
            this.IsActive = isActive;
        }
        /// <Summary>
        /// The title of the step that typically describes it.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        /// <Summary>
        /// The subtitle of the step that appears below the title and has a smaller
        /// font size. It typically gives more details that complement the title.
        ///
        /// If null, the subtitle is not shown.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Subtitle { get; set; }
        /// <Summary>
        /// The content of the step that appears below the [title] and [subtitle].
        ///
        /// Below the content, every step has a 'continue' and 'cancel' button.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Content { get; set; }
        /// <Summary>
        /// The state of the step which determines the styling of its components
        /// and whether steps are interactive.
        /// </Summary>
        public virtual FlutterSDK.Material.Stepper.StepState State { get; set; }
        /// <Summary>
        /// Whether or not the step is active. The flag only influences styling.
        /// </Summary>
        public virtual bool IsActive { get; set; }
    }


    /// <Summary>
    /// A material stepper widget that displays progress through a sequence of
    /// steps. Steppers are particularly useful in the case of forms where one step
    /// requires the completion of another one, or where multiple steps need to be
    /// completed in order to submit the whole form.
    ///
    /// The widget is a flexible wrapper. A parent class should pass [currentStep]
    /// to this widget based on some logic triggered by the three callbacks that it
    /// provides.
    ///
    /// See also:
    ///
    ///  * [Step]
    ///  * <https://material.io/archive/guidelines/components/steppers.html>
    /// </Summary>
    public class Stepper : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a stepper from a list of steps.
        ///
        /// This widget is not meant to be rebuilt with a different list of steps
        /// unless a key is provided in order to distinguish the old stepper from the
        /// new one.
        ///
        /// The [steps], [type], and [currentStep] arguments must not be null.
        /// </Summary>
        public Stepper(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Material.Stepper.Step> steps = default(List<FlutterSDK.Material.Stepper.Step>), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Material.Stepper.StepperType type = default(FlutterSDK.Material.Stepper.StepperType), int currentStep = 0, FlutterSDK.Foundation.Basictypes.ValueChanged<int> onStepTapped = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), VoidCallback onStepContinue = default(VoidCallback), VoidCallback onStepCancel = default(VoidCallback), FlutterSDK.Widgets.Framework.ControlsWidgetBuilder controlsBuilder = default(FlutterSDK.Widgets.Framework.ControlsWidgetBuilder))
        : base(key: key)
        {
            this.Steps = steps;
            this.Physics = physics;
            this.Type = type;
            this.CurrentStep = currentStep;
            this.OnStepTapped = onStepTapped;
            this.OnStepContinue = onStepContinue;
            this.OnStepCancel = onStepCancel;
            this.ControlsBuilder = controlsBuilder;
        }
        /// <Summary>
        /// The steps of the stepper whose titles, subtitles, icons always get shown.
        ///
        /// The length of [steps] must not change.
        /// </Summary>
        public virtual List<FlutterSDK.Material.Stepper.Step> Steps { get; set; }
        /// <Summary>
        /// How the stepper's scroll view should respond to user input.
        ///
        /// For example, determines how the scroll view continues to
        /// animate after the user stops dragging the scroll view.
        ///
        /// If the stepper is contained within another scrollable it
        /// can be helpful to set this property to [ClampingScrollPhysics].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
        /// <Summary>
        /// The type of stepper that determines the layout. In the case of
        /// [StepperType.horizontal], the content of the current step is displayed
        /// underneath as opposed to the [StepperType.vertical] case where it is
        /// displayed in-between.
        /// </Summary>
        public virtual FlutterSDK.Material.Stepper.StepperType Type { get; set; }
        /// <Summary>
        /// The index into [steps] of the current step whose content is displayed.
        /// </Summary>
        public virtual int CurrentStep { get; set; }
        /// <Summary>
        /// The callback called when a step is tapped, with its index passed as
        /// an argument.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnStepTapped { get; set; }
        /// <Summary>
        /// The callback called when the 'continue' button is tapped.
        ///
        /// If null, the 'continue' button will be disabled.
        /// </Summary>
        public virtual VoidCallback OnStepContinue { get; set; }
        /// <Summary>
        /// The callback called when the 'cancel' button is tapped.
        ///
        /// If null, the 'cancel' button will be disabled.
        /// </Summary>
        public virtual VoidCallback OnStepCancel { get; set; }
        /// <Summary>
        /// The callback for creating custom controls.
        ///
        /// If null, the default controls from the current theme will be used.
        ///
        /// This callback which takes in a context and two functions,[onStepContinue]
        /// and [onStepCancel]. These can be used to control the stepper.
        ///
        /// {@tool dartpad --template=stateless_widget_scaffold}
        /// Creates a stepper control with custom buttons.
        ///
        /// ```dart
        /// Widget build(BuildContext context) {
        ///   return Stepper(
        ///     controlsBuilder:
        ///       (BuildContext context, {VoidCallback onStepContinue, VoidCallback onStepCancel}) {
        ///          return Row(
        ///            children: <Widget>[
        ///              FlatButton(
        ///                onPressed: onStepContinue,
        ///                child: const Text('NEXT'),
        ///              ),
        ///              FlatButton(
        ///                onPressed: onStepCancel,
        ///                child: const Text('CANCEL'),
        ///              ),
        ///            ],
        ///          );
        ///       },
        ///     steps: const <Step>[
        ///       Step(
        ///         title: Text('A'),
        ///         content: SizedBox(
        ///           width: 100.0,
        ///           height: 100.0,
        ///         ),
        ///       ),
        ///       Step(
        ///         title: Text('B'),
        ///         content: SizedBox(
        ///           width: 100.0,
        ///           height: 100.0,
        ///         ),
        ///       ),
        ///     ],
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.ControlsWidgetBuilder ControlsBuilder { get; set; }

        public new FlutterSDK.Material.Stepper._StepperState CreateState() => new _StepperState();


    }


    public class _StepperState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Stepper.Stepper>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _StepperState()
        { }
        internal virtual List<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>> _Keys { get; set; }
        internal virtual Dictionary<int, FlutterSDK.Material.Stepper.StepState> _OldStates { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Keys = List<GlobalKey>.Generate(Widget.Steps.Count, (int i) => =>new GlobalKey());
            for (int i = 0; i < Widget.Steps.Count; i += 1) _OldStates[i] = Widget.Steps[i].State;
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Stepper.Stepper oldWidget)
        {
            base.DidUpdateWidget(oldWidget);

            for (int i = 0; i < oldWidget.Steps.Count; i += 1) _OldStates[i] = oldWidget.Steps[i].State;
        }




        private bool _IsFirst(int index)
        {
            return index == 0;
        }




        private bool _IsLast(int index)
        {
            return Widget.Steps.Count - 1 == index;
        }




        private bool _IsCurrent(int index)
        {
            return Widget.CurrentStep == index;
        }




        private bool _IsDark()
        {
            return ThemeDefaultClass.Theme.Of(Context).Brightness == Brightness.Dark;
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildLine(bool visible)
        {
            return new Container(width: visible ? 1.0 : 0.0, height: 16.0, color: ColorsDefaultClass.Colors.Grey.Shade400);
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildCircleChild(int index, bool oldState)
        {
            StepState state = oldState ? _OldStates[index] : Widget.Steps[index].State;
            bool isDarkActive = _IsDark() && Widget.Steps[index].IsActive;

            switch (state) { case StepState.Indexed: case StepState.Disabled: return new Text($"'{index + 1}'", style: isDarkActive ? StepperDefaultClass._KStepStyle.CopyWith(color: ColorsDefaultClass.Colors.Black87) : StepperDefaultClass._KStepStyle); case StepState.Editing: return new Icon(IconsDefaultClass.Icons.Edit, color: isDarkActive ? StepperDefaultClass._KCircleActiveDark : StepperDefaultClass._KCircleActiveLight, size: 18.0); case StepState.Complete: return new Icon(IconsDefaultClass.Icons.Check, color: isDarkActive ? StepperDefaultClass._KCircleActiveDark : StepperDefaultClass._KCircleActiveLight, size: 18.0); case StepState.Error: return new Text('!', style: StepperDefaultClass._KStepStyle); }
            return null;
        }




        private Color _CircleColor(int index)
        {
            ThemeData themeData = ThemeDefaultClass.Theme.Of(Context);
            if (!_IsDark())
            {
                return Widget.Steps[index].IsActive ? themeData.PrimaryColor : ColorsDefaultClass.Colors.Black38;
            }
            else
            {
                return Widget.Steps[index].IsActive ? themeData.AccentColor : themeData.BackgroundColor;
            }

        }




        private FlutterSDK.Widgets.Framework.Widget _BuildCircle(int index, bool oldState)
        {
            return new Container(margin: EdgeInsets.Symmetric(vertical: 8.0), width: StepperDefaultClass._KStepSize, height: StepperDefaultClass._KStepSize, child: new AnimatedContainer(curve: CurvesDefaultClass.Curves.FastOutSlowIn, duration: ThemeDefaultClass.KThemeAnimationDuration, decoration: new BoxDecoration(color: _CircleColor(index), shape: BoxShape.Circle), child: new Center(child: _BuildCircleChild(index, oldState && Widget.Steps[index].State == StepState.Error))));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildTriangle(int index, bool oldState)
        {
            return new Container(margin: EdgeInsets.Symmetric(vertical: 8.0), width: StepperDefaultClass._KStepSize, height: StepperDefaultClass._KStepSize, child: new Center(child: new SizedBox(width: StepperDefaultClass._KStepSize, height: StepperDefaultClass._KTriangleHeight, child: new CustomPaint(painter: new _TrianglePainter(color: _IsDark() ? StepperDefaultClass._KErrorDark : StepperDefaultClass._KErrorLight), child: new Align(alignment: new Alignment(0.0, 0.8), child: _BuildCircleChild(index, oldState && Widget.Steps[index].State != StepState.Error))))));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildIcon(int index)
        {
            if (Widget.Steps[index].State != _OldStates[index])
            {
                return new AnimatedCrossFade(firstChild: _BuildCircle(index, true), secondChild: _BuildTriangle(index, true), firstCurve: new Interval(0.0, 0.6, curve: CurvesDefaultClass.Curves.FastOutSlowIn), secondCurve: new Interval(0.4, 1.0, curve: CurvesDefaultClass.Curves.FastOutSlowIn), sizeCurve: CurvesDefaultClass.Curves.FastOutSlowIn, crossFadeState: Widget.Steps[index].State == StepState.Error ? CrossFadeState.ShowSecond : CrossFadeState.ShowFirst, duration: ThemeDefaultClass.KThemeAnimationDuration);
            }
            else
            {
                if (Widget.Steps[index].State != StepState.Error) return _BuildCircle(index, false); else return _BuildTriangle(index, false);
            }

        }




        private FlutterSDK.Widgets.Framework.Widget _BuildVerticalControls()
        {
            if (Widget.ControlsBuilder != null) return Widget.ControlsBuilder(Context, onStepContinue: Widget.OnStepContinue, onStepCancel: Widget.OnStepCancel);
            Color cancelColor = default(Color);
            switch (ThemeDefaultClass.Theme.Of(Context).Brightness) { case Brightness.Light: cancelColor = ColorsDefaultClass.Colors.Black54; break; case Brightness.Dark: cancelColor = ColorsDefaultClass.Colors.White70; break; }

            ThemeData themeData = ThemeDefaultClass.Theme.Of(Context);
            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
            return new Container(margin: EdgeInsets.Only(top: 16.0), child: new ConstrainedBox(constraints: BoxConstraints.TightFor(height: 48.0), child: new Row(children: new List<Widget>() { new FlatButton(onPressed: Widget.OnStepContinue, color: _IsDark() ? themeData.BackgroundColor : themeData.PrimaryColor, textColor: ColorsDefaultClass.Colors.White, textTheme: ButtonTextTheme.Normal, child: new Text(localizations.ContinueButtonLabel)), new Container(margin: EdgeInsetsDirectional.Only(start: 8.0), child: new FlatButton(onPressed: Widget.OnStepCancel, textColor: cancelColor, textTheme: ButtonTextTheme.Normal, child: new Text(localizations.CancelButtonLabel))) })));
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _TitleStyle(int index)
        {
            ThemeData themeData = ThemeDefaultClass.Theme.Of(Context);
            TextTheme textTheme = themeData.TextTheme;

            switch (Widget.Steps[index].State) { case StepState.Indexed: case StepState.Editing: case StepState.Complete: return textTheme.BodyText1; case StepState.Disabled: return textTheme.BodyText1.CopyWith(color: _IsDark() ? StepperDefaultClass._KDisabledDark : StepperDefaultClass._KDisabledLight); case StepState.Error: return textTheme.BodyText1.CopyWith(color: _IsDark() ? StepperDefaultClass._KErrorDark : StepperDefaultClass._KErrorLight); }
            return null;
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _SubtitleStyle(int index)
        {
            ThemeData themeData = ThemeDefaultClass.Theme.Of(Context);
            TextTheme textTheme = themeData.TextTheme;

            switch (Widget.Steps[index].State) { case StepState.Indexed: case StepState.Editing: case StepState.Complete: return textTheme.Caption; case StepState.Disabled: return textTheme.Caption.CopyWith(color: _IsDark() ? StepperDefaultClass._KDisabledDark : StepperDefaultClass._KDisabledLight); case StepState.Error: return textTheme.Caption.CopyWith(color: _IsDark() ? StepperDefaultClass._KErrorDark : StepperDefaultClass._KErrorLight); }
            return null;
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildHeaderText(int index)
        {
            return new Column(crossAxisAlignment: CrossAxisAlignment.Start, mainAxisSize: MainAxisSize.Min, children: new List<Widget>() { new AnimatedDefaultTextStyle(style: _TitleStyle(index), duration: ThemeDefaultClass.KThemeAnimationDuration, curve: CurvesDefaultClass.Curves.FastOutSlowIn, child: Widget.Steps[index].Title) });
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildVerticalHeader(int index)
        {
            return new Container(margin: EdgeInsets.Symmetric(horizontal: 24.0), child: new Row(children: new List<Widget>() { new Column(children: new List<Widget>() { _BuildLine(!_IsFirst(index)), _BuildIcon(index), _BuildLine(!_IsLast(index)) }), new Container(margin: EdgeInsetsDirectional.Only(start: 12.0), child: _BuildHeaderText(index)) }));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildVerticalBody(int index)
        {
            return new Stack(children: new List<Widget>() { new PositionedDirectional(start: 24.0, top: 0.0, bottom: 0.0, child: new SizedBox(width: 24.0, child: new Center(child: new SizedBox(width: _IsLast(index) ? 0.0 : 1.0, child: new Container(color: ColorsDefaultClass.Colors.Grey.Shade400))))), new AnimatedCrossFade(firstChild: new Container(height: 0.0), secondChild: new Container(margin: EdgeInsetsDirectional.Only(start: 60.0, end: 24.0, bottom: 24.0), child: new Column(children: new List<Widget>() { Widget.Steps[index].Content, _BuildVerticalControls() })), firstCurve: new Interval(0.0, 0.6, curve: CurvesDefaultClass.Curves.FastOutSlowIn), secondCurve: new Interval(0.4, 1.0, curve: CurvesDefaultClass.Curves.FastOutSlowIn), sizeCurve: CurvesDefaultClass.Curves.FastOutSlowIn, crossFadeState: _IsCurrent(index) ? CrossFadeState.ShowSecond : CrossFadeState.ShowFirst, duration: ThemeDefaultClass.KThemeAnimationDuration) });
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildVertical()
        {
            return new ListView(shrinkWrap: true, physics: Widget.Physics, children: new List<Widget>() { });
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildHorizontal()
        {
            List<Widget> children = new List<Widget>() { };
            return new Column(children: new List<Widget>() { new Material(elevation: 2.0, child: new Container(margin: EdgeInsets.Symmetric(horizontal: 24.0), child: new Row(children: children))), new Expanded(child: new ListView(padding: EdgeInsets.All(24.0), children: new List<Widget>() { new AnimatedSize(curve: CurvesDefaultClass.Curves.FastOutSlowIn, duration: ThemeDefaultClass.KThemeAnimationDuration, vsync: this, child: Widget.Steps[Widget.CurrentStep].Content), _BuildVerticalControls() })) });
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {




            switch (Widget.Type) { case StepperType.Vertical: return _BuildVertical(); case StepperType.Horizontal: return _BuildHorizontal(); }
            return null;
        }



    }


    public class _TrianglePainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        public _TrianglePainter(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color))
        {
            this.Color = color;
        }
        public virtual FlutterBinding.UI.Color Color { get; set; }

        public new bool HitTest(FlutterBinding.UI.Offset point) => true;



        public new bool ShouldRepaint(FlutterSDK.Material.Stepper._TrianglePainter oldPainter)
        {
            return oldPainter.Color != Color;
        }


        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            return oldPainter.Color != Color;
        }




        public new void Paint(Canvas canvas, Size size)
        {
            double   base = size.Width;
            double halfBase = size.Width / 2.0;
            double height = size.Height;
            List<Offset> points = new List<Offset>() { new Offset(0.0, height), new Offset(base, height), new Offset(halfBase, 0.0) };
            canvas.DrawPath(new Path();
            new Path().AddPolygon(points, true), new Paint()..Color = Color);
        }



    }


    /// <Summary>
    /// The state of a [Step] which is used to control the style of the circle and
    /// text.
    ///
    /// See also:
    ///
    ///  * [Step]
    /// </Summary>
    public enum StepState
    {

        /// <Summary>
        /// A step that displays its index in its circle.
        /// </Summary>
        Indexed,
        /// <Summary>
        /// A step that displays a pencil icon in its circle.
        /// </Summary>
        Editing,
        /// <Summary>
        /// A step that displays a tick icon in its circle.
        /// </Summary>
        Complete,
        /// <Summary>
        /// A step that is disabled and does not to react to taps.
        /// </Summary>
        Disabled,
        /// <Summary>
        /// A step that is currently having an error. e.g. the user has submitted wrong
        /// input.
        /// </Summary>
        Error,
    }


    /// <Summary>
    /// Defines the [Stepper]'s main axis.
    /// </Summary>
    public enum StepperType
    {

        /// <Summary>
        /// A vertical layout of the steps with their content in-between the titles.
        /// </Summary>
        Vertical,
        /// <Summary>
        /// A horizontal layout of the steps with their content below the titles.
        /// </Summary>
        Horizontal,
    }

}
