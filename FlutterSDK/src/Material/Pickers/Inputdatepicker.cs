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
namespace FlutterSDK.Material.Pickers.Inputdatepicker
{
    internal static class InputdatepickerDefaultClass
    {
        public static double _InputPortraitHeight = default(double);
        public static double _InputLandscapeHeight = default(double);
    }

    /// <Summary>
    /// A [TextFormField] configured to accept and validate a date entered by the user.
    ///
    /// The text entered into this field will be constrained to only allow digits
    /// and separators. When saved or submitted, the text will be parsed into a
    /// [DateTime] according to the ambient locale. If the input text doesn't parse
    /// into a date, the [errorFormatText] message will be displayed under the field.
    ///
    /// [firstDate], [lastDate], and [selectableDayPredicate] provide constraints on
    /// what days are valid. If the input date isn't in the date range or doesn't pass
    /// the given predicate, then the [errorInvalidText] message will be displayed
    /// under the field.
    ///
    /// See also:
    ///
    ///  * [showDatePicker], which shows a dialog that contains a material design
    ///    date picker which includes support for text entry of dates.
    ///  * [MaterialLocalizations.parseCompactDate], which is used to parse the text
    ///    input into a [DateTime].
    ///
    /// </Summary>
    public class InputDatePickerFormField : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a [TextFormField] configured to accept and validate a date.
        ///
        /// If the optional [initialDate] is provided, then it will be used to populate
        /// the text field. If the [fieldHintText] is provided, it will be shown.
        ///
        /// If [initialDate] is provided, it must not be before [firstDate] or after
        /// [lastDate]. If [selectableDayPredicate] is provided, it must return `true`
        /// for [initialDate].
        ///
        /// [firstDate] must be on or before [lastDate].
        ///
        /// [firstDate], [lastDate], and [autofocus] must be non-null.
        ///
        /// </Summary>
        public InputDatePickerFormField(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), DateTime initialDate = default(DateTime), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onDateSubmitted = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onDateSaved = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate), string errorFormatText = default(string), string errorInvalidText = default(string), string fieldHintText = default(string), string fieldLabelText = default(string), bool autofocus = false)
        : base(key: key)
        {
            this.OnDateSubmitted = onDateSubmitted;
            this.OnDateSaved = onDateSaved;
            this.SelectableDayPredicate = selectableDayPredicate;
            this.ErrorFormatText = errorFormatText;
            this.ErrorInvalidText = errorInvalidText;
            this.FieldHintText = fieldHintText;
            this.FieldLabelText = fieldLabelText;
            this.Autofocus = autofocus;




        }


        /// <Summary>
        /// If provided, it will be used as the default value of the field.
        /// </Summary>
        public virtual DateTime InitialDate { get; set; }
        /// <Summary>
        /// The earliest allowable [DateTime] that the user can input.
        /// </Summary>
        public virtual DateTime FirstDate { get; set; }
        /// <Summary>
        /// The latest allowable [DateTime] that the user can input.
        /// </Summary>
        public virtual DateTime LastDate { get; set; }
        /// <Summary>
        /// An optional method to call when the user indicates they are done editing
        /// the text in the field. Will only be called if the input represents a valid
        /// [DateTime].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnDateSubmitted { get; set; }
        /// <Summary>
        /// An optional method to call with the final date when the form is
        /// saved via [FormState.save]. Will only be called if the input represents
        /// a valid [DateTime].
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnDateSaved { get; set; }
        /// <Summary>
        /// Function to provide full control over which [DateTime] can be selected.
        /// </Summary>
        public virtual FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate SelectableDayPredicate { get; set; }
        /// <Summary>
        /// The error text displayed if the entered date is not in the correct format.
        /// </Summary>
        public virtual string ErrorFormatText { get; set; }
        /// <Summary>
        /// The error text displayed if the date is not valid.
        ///
        /// A date is not valid if it is earlier than [firstDate], later than
        /// [lastDate], or doesn't pass the [selectableDayPredicate].
        /// </Summary>
        public virtual string ErrorInvalidText { get; set; }
        /// <Summary>
        /// The hint text displayed in the [TextField].
        ///
        /// If this is null, it will default to the date format string. For example,
        /// 'mm/dd/yyyy' for en_US.
        /// </Summary>
        public virtual string FieldHintText { get; set; }
        /// <Summary>
        /// The label text displayed in the [TextField].
        ///
        /// If this is null, it will default to the words representing the date format
        /// string. For example, 'Month, Day, Year' for en_US.
        /// </Summary>
        public virtual string FieldLabelText { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.editableText.autofocus}
        /// </Summary>
        public virtual bool Autofocus { get; set; }

        public new FlutterSDK.Material.Pickers.Inputdatepicker._InputDatePickerFormFieldState CreateState() => new _InputDatePickerFormFieldState();


    }


    public class _InputDatePickerFormFieldState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Inputdatepicker.InputDatePickerFormField>
    {
        public _InputDatePickerFormFieldState()
        { }
        internal virtual FlutterSDK.Widgets.Editabletext.TextEditingController _Controller { get; set; }
        internal virtual DateTime _SelectedDate { get; set; }
        internal virtual string _InputText { get; set; }
        internal virtual bool _AutoSelected { get; set; }

        public new void InitState()
        {
            base.InitState();
            _SelectedDate = Widget.InitialDate;
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            if (_SelectedDate != null)
            {
                MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
                _InputText = localizations.FormatCompactDate(_SelectedDate);
                TextEditingValue textEditingValue = _Controller.Value.CopyWith(text: _InputText);
                if (Widget.Autofocus && !_AutoSelected)
                {
                    textEditingValue = textEditingValue.CopyWith(selection: new TextSelection(baseOffset: 0, extentOffset: _InputText.Length));
                    _AutoSelected = true;
                }

                _Controller.Value = textEditingValue;
            }

        }




        private DateTime _ParseDate(string text)
        {
            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
            return localizations.ParseCompactDate(text);
        }




        private bool _IsValidAcceptableDate(DateTime date)
        {
            return date != null && !date.IsBefore(Widget.FirstDate) && !date.IsAfter(Widget.LastDate) && (Widget.SelectableDayPredicate == null || Widget.SelectableDayPredicate(date));
        }




        private string _ValidateDate(string text)
        {
            DateTime date = _ParseDate(text);
            if (date == null)
            {
                return Widget.ErrorFormatText ?? "Invalid format.";
            }
            else if (!_IsValidAcceptableDate(date))
            {
                return Widget.ErrorInvalidText ?? "Out of range.";
            }

            return null;
        }




        private void _HandleSaved(string text)
        {
            if (Widget.OnDateSaved != null)
            {
                DateTime date = _ParseDate(text);
                if (_IsValidAcceptableDate(date))
                {
                    _SelectedDate = date;
                    _InputText = text;
                    Widget.OnDateSaved(date);
                }

            }

        }




        private void _HandleSubmitted(string text)
        {
            if (Widget.OnDateSubmitted != null)
            {
                DateTime date = _ParseDate(text);
                if (_IsValidAcceptableDate(date))
                {
                    _SelectedDate = date;
                    _InputText = text;
                    Widget.OnDateSubmitted(date);
                }

            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new OrientationBuilder(builder: (BuildContext context, Orientation orientation) =>
            {

                return new Container(padding: EdgeInsets.Symmetric(horizontal: 24), height: orientation == Orientation.Portrait ? InputdatepickerDefaultClass._InputPortraitHeight : InputdatepickerDefaultClass._InputLandscapeHeight, child: new Column(children: new List<Widget>() { new Spacer(), new TextFormField(decoration: new InputDecoration(border: new UnderlineInputBorder(), filled: true, hintText: Widget.FieldHintText ?? "mm/dd/yyyy", labelText: Widget.FieldLabelText ?? "Enter Date"), validator: _ValidateDate, inputFormatters: new List<TextInputFormatter>() { new _DateTextInputFormatter('/') }, keyboardType: TextinputDefaultClass.TextInputType.Datetime, onSaved: _HandleSaved, onFieldSubmitted: _HandleSubmitted, autofocus: Widget.Autofocus, controller: _Controller), new Spacer() }));
            }
            );
        }



    }


    public class _DateTextInputFormatter : FlutterSDK.Services.Textformatter.TextInputFormatter
    {
        public _DateTextInputFormatter(string separator)
        {
            this.Separator = separator;
        }
        public virtual string Separator { get; set; }
        internal virtual FlutterSDK.Services.Textformatter.WhitelistingTextInputFormatter _FilterFormatter { get; set; }

        public new FlutterSDK.Services.Textinput.TextEditingValue FormatEditUpdate(FlutterSDK.Services.Textinput.TextEditingValue oldValue, FlutterSDK.Services.Textinput.TextEditingValue newValue)
        {
            TextEditingValue filteredValue = _FilterFormatter.FormatEditUpdate(oldValue, newValue);
            return filteredValue.CopyWith(text: filteredValue.Text.ReplaceAll(new RegExp("'[\D]"), Separator));
        }



    }

}
