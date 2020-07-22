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
namespace FlutterSDK.Material.Pickers.Calendardatepicker
{
    internal static class CalendardatepickerDefaultClass
    {
        public static TimeSpan _MonthScrollDuration = default(TimeSpan);
        public static double _DayPickerRowHeight = default(double);
        public static int _MaxDayPickerRowCount = default(int);
        public static double _MaxDayPickerHeight = default(double);
        public static double _MonthPickerHorizontalPadding = default(double);
        public static int _YearPickerColumnCount = default(int);
        public static double _YearPickerPadding = default(double);
        public static double _YearPickerRowHeight = default(double);
        public static double _YearPickerRowSpacing = default(double);
        public static double _SubHeaderHeight = default(double);
        public static double _MonthNavButtonsWidth = default(double);
        public static FlutterSDK.Material.Pickers.Calendardatepicker._DayPickerGridDelegate _DayPickerGridDelegate = default(FlutterSDK.Material.Pickers.Calendardatepicker._DayPickerGridDelegate);
        public static FlutterSDK.Material.Pickers.Calendardatepicker._YearPickerGridDelegate _YearPickerGridDelegate = default(FlutterSDK.Material.Pickers.Calendardatepicker._YearPickerGridDelegate);
    }

    /// <Summary>
    /// Displays a grid of days for a given month and allows the user to select a date.
    ///
    /// Days are arranged in a rectangular grid with one column for each day of the
    /// week. Controls are provided to change the year and month that the grid is
    /// showing.
    ///
    /// The calendar picker widget is rarely used directly. Instead, consider using
    /// [showDatePicker], which will create a dialog that uses this as well as provides
    /// a text entry option.
    ///
    /// See also:
    ///
    ///  * [showDatePicker], which creates a Dialog that contains a [CalendarDatePicker]
    ///    and provides an optional compact view where the user can enter a date as
    ///    a line of text.
    ///  * [showTimePicker], which shows a dialog that contains a material design
    ///    time picker.
    ///
    /// </Summary>
    public class CalendarDatePicker : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public CalendarDatePicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), DateTime initialDate = default(DateTime), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onDateChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onDisplayedMonthChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode initialCalendarMode = default(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode), FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate))
        : base(key: key)
        {
            this.OnDateChanged = onDateChanged;
            this.OnDisplayedMonthChanged = onDisplayedMonthChanged;
            this.InitialCalendarMode = initialCalendarMode;
            this.SelectableDayPredicate = selectableDayPredicate;




        }


        public virtual DateTime InitialDate { get; set; }
        public virtual DateTime FirstDate { get; set; }
        public virtual DateTime LastDate { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnDateChanged { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnDisplayedMonthChanged { get; set; }
        public virtual FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode InitialCalendarMode { get; set; }
        public virtual FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate SelectableDayPredicate { get; set; }

        public new FlutterSDK.Material.Pickers.Calendardatepicker._CalendarDatePickerState CreateState() => new _CalendarDatePickerState();


    }


    public class _CalendarDatePickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Calendardatepicker.CalendarDatePicker>
    {
        public _CalendarDatePickerState()
        { }
        internal virtual bool _AnnouncedInitialDate { get; set; }
        internal virtual FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode _Mode { get; set; }
        internal virtual DateTime _CurrentDisplayedMonthDate { get; set; }
        internal virtual DateTime _SelectedDate { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _MonthPickerKey { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _YearPickerKey { get; set; }
        internal virtual FlutterSDK.Material.Materiallocalizations.MaterialLocalizations _Localizations { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Mode = Widget.InitialCalendarMode;
            _CurrentDisplayedMonthDate = new DateTime(Widget.InitialDate.Year, Widget.InitialDate.Month);
            _SelectedDate = Widget.InitialDate;
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            _Localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
            _TextDirection = BasicDefaultClass.Directionality.Of(Context);
            if (!_AnnouncedInitialDate)
            {
                _AnnouncedInitialDate = true;
                SemanticsserviceDefaultClass.SemanticsService.Announce(_Localizations.FormatFullDate(_SelectedDate), _TextDirection);
            }

        }




        private void _Vibrate()
        {
            switch (ThemeDefaultClass.Theme.Of(Context).Platform) { case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: HapticfeedbackDefaultClass.HapticFeedback.Vibrate(); break; case TargetPlatform.IOS: case TargetPlatform.MacOS: break; }
        }




        private void _HandleModeChanged(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode mode)
        {
            _Vibrate();
            SetState(() =>
            {
                _Mode = mode;
                if (_Mode == DatePickerMode.Day)
                {
                    SemanticsserviceDefaultClass.SemanticsService.Announce(_Localizations.FormatMonthYear(_SelectedDate), _TextDirection);
                }
                else
                {
                    SemanticsserviceDefaultClass.SemanticsService.Announce(_Localizations.FormatYear(_SelectedDate), _TextDirection);
                }

            }
            );
        }




        private void _HandleMonthChanged(DateTime date)
        {
            SetState(() =>
            {
                if (_CurrentDisplayedMonthDate.Year != date.Year || _CurrentDisplayedMonthDate.Month != date.Month)
                {
                    _CurrentDisplayedMonthDate = new DateTime(date.Year, date.Month);
                    Widget.OnDisplayedMonthChanged?.Call(_CurrentDisplayedMonthDate);
                }

            }
            );
        }




        private void _HandleYearChanged(DateTime value)
        {
            _Vibrate();
            if (value.IsBefore(Widget.FirstDate))
            {
                value = Widget.FirstDate;
            }
            else if (value.IsAfter(Widget.LastDate))
            {
                value = Widget.LastDate;
            }

            SetState(() =>
            {
                _Mode = DatePickerMode.Day;
                _HandleMonthChanged(value);
            }
            );
        }




        private void _HandleDayChanged(DateTime value)
        {
            _Vibrate();
            SetState(() =>
            {
                _SelectedDate = value;
                Widget.OnDateChanged?.Call(_SelectedDate);
            }
            );
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildPicker()
        {

            switch (_Mode) { case DatePickerMode.Day: return new _MonthPicker(key: _MonthPickerKey, initialMonth: _CurrentDisplayedMonthDate, currentDate: DateTime.Now(), firstDate: Widget.FirstDate, lastDate: Widget.LastDate, selectedDate: _SelectedDate, onChanged: _HandleDayChanged, onDisplayedMonthChanged: _HandleMonthChanged, selectableDayPredicate: Widget.SelectableDayPredicate); case DatePickerMode.Year: return new Padding(padding: EdgeInsets.Only(top: CalendardatepickerDefaultClass._SubHeaderHeight), child: new _YearPicker(key: _YearPickerKey, currentDate: DateTime.Now(), firstDate: Widget.FirstDate, lastDate: Widget.LastDate, initialDate: _CurrentDisplayedMonthDate, selectedDate: _SelectedDate, onChanged: _HandleYearChanged)); }
            return null;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Stack(children: new List<Widget>(){new SingleChildScrollView(child:new SizedBox(height:CalendardatepickerDefaultClass._MaxDayPickerHeight, child:_BuildPicker())), new _DatePickerModeToggleButton(mode:_Mode, title:_Localizations.FormatMonthYear(_CurrentDisplayedMonthDate), onTitlePressed:() => {
_HandleModeChanged(_Mode==DatePickerMode.Day?DatePickerMode.Year:DatePickerMode.Day);
}
)});
        }



    }


    /// <Summary>
    /// A button that used to toggle the [DatePickerMode] for a date picker.
    ///
    /// This appears above the calendar grid and allows the user to toggle the
    /// [DatePickerMode] to display either the calendar view or the year list.
    /// </Summary>
    public class _DatePickerModeToggleButton : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _DatePickerModeToggleButton(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode mode = default(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode), string title = default(string), VoidCallback onTitlePressed = default(VoidCallback))
        {
            this.Mode = mode;
            this.Title = title;
            this.OnTitlePressed = onTitlePressed;
        }
        public virtual FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode Mode { get; set; }
        public virtual string Title { get; set; }
        public virtual VoidCallback OnTitlePressed { get; set; }

        public new FlutterSDK.Material.Pickers.Calendardatepicker._DatePickerModeToggleButtonState CreateState() => new _DatePickerModeToggleButtonState();


    }


    public class _DatePickerModeToggleButtonState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Calendardatepicker._DatePickerModeToggleButton>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _DatePickerModeToggleButtonState()
        { }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }

        public new void InitState()
        {
            base.InitState();
            _Controller = new AnimationController(value: Widget.Mode == DatePickerMode.Year ? 0.5 : 0, upperBound: 0.5, duration: new TimeSpan(milliseconds: 200), vsync: this);
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Pickers.Calendardatepicker._DatePickerModeToggleButton oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (oldWidget.Mode == Widget.Mode)
            {
                return;
            }

            if (Widget.Mode == DatePickerMode.Year)
            {
                _Controller.Forward();
            }
            else
            {
                _Controller.Reverse();
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ColorScheme colorScheme = ThemeDefaultClass.Theme.Of(context).ColorScheme;
            TextTheme textTheme = ThemeDefaultClass.Theme.Of(context).TextTheme;
            Color controlColor = colorScheme.OnSurface.WithOpacity(0.60);
            return new Container(padding: EdgeInsetsDirectional.Only(start: 16, end: 4), height: CalendardatepickerDefaultClass._SubHeaderHeight, child: new Row(children: new List<Widget>() { new Flexible(child: new Semantics(label: "Select year", excludeSemantics: true, button: true, child: new Container(height: CalendardatepickerDefaultClass._SubHeaderHeight, child: new InkWell(onTap: Widget.OnTitlePressed, child: new Padding(padding: EdgeInsets.Symmetric(horizontal: 8), child: new Row(children: new List<Widget>() { new Flexible(child: new Text(Widget.Title, overflow: TextOverflow.Ellipsis, style: textTheme.Subtitle2?.CopyWith(color: controlColor))), new RotationTransition(turns: _Controller, child: new Icon(IconsDefaultClass.Icons.Arrow_drop_down, color: controlColor)) })))))) }));
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }



    }


    public class _MonthPicker : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _MonthPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), DateTime initialMonth = default(DateTime), DateTime currentDate = default(DateTime), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), DateTime selectedDate = default(DateTime), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onDisplayedMonthChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate))
        : base(key: key)
        {
            this.InitialMonth = initialMonth;
            this.CurrentDate = currentDate;
            this.FirstDate = firstDate;
            this.LastDate = lastDate;
            this.SelectedDate = selectedDate;
            this.OnChanged = onChanged;
            this.OnDisplayedMonthChanged = onDisplayedMonthChanged;
            this.SelectableDayPredicate = selectableDayPredicate;
        }
        public virtual DateTime InitialMonth { get; set; }
        public virtual DateTime CurrentDate { get; set; }
        public virtual DateTime FirstDate { get; set; }
        public virtual DateTime LastDate { get; set; }
        public virtual DateTime SelectedDate { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnChanged { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnDisplayedMonthChanged { get; set; }
        public virtual FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate SelectableDayPredicate { get; set; }

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() => new _MonthPickerState();


    }


    public class _MonthPickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Calendardatepicker._MonthPicker>
    {
        public _MonthPickerState()
        { }
        internal virtual DateTime _CurrentMonth { get; set; }
        internal virtual DateTime _NextMonthDate { get; set; }
        internal virtual DateTime _PreviousMonthDate { get; set; }
        internal virtual FlutterSDK.Widgets.Pageview.PageController _PageController { get; set; }
        internal virtual FlutterSDK.Material.Materiallocalizations.MaterialLocalizations _Localizations { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual bool _IsDisplayingFirstMonth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsDisplayingLastMonth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _CurrentMonth = Widget.InitialMonth;
            _PreviousMonthDate = Utils.DateutilsDefaultClass.AddMonthsToMonthDate(_CurrentMonth, -1);
            _NextMonthDate = Utils.DateutilsDefaultClass.AddMonthsToMonthDate(_CurrentMonth, 1);
            _PageController = new PageController(initialPage: Utils.DateutilsDefaultClass.MonthDelta(Widget.FirstDate, _CurrentMonth));
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            _Localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
            _TextDirection = BasicDefaultClass.Directionality.Of(Context);
        }




        public new void Dispose()
        {
            _PageController?.Dispose();
            base.Dispose();
        }




        private void _HandleMonthPageChanged(int monthPage)
        {
            DateTime monthDate = Utils.DateutilsDefaultClass.AddMonthsToMonthDate(Widget.FirstDate, monthPage);
            if (_CurrentMonth.Year != monthDate.Year || _CurrentMonth.Month != monthDate.Month)
            {
                _CurrentMonth = new DateTime(monthDate.Year, monthDate.Month);
                _PreviousMonthDate = Utils.DateutilsDefaultClass.AddMonthsToMonthDate(_CurrentMonth, -1);
                _NextMonthDate = Utils.DateutilsDefaultClass.AddMonthsToMonthDate(_CurrentMonth, 1);
                Widget.OnDisplayedMonthChanged?.Call(_CurrentMonth);
            }

        }




        private void _HandleNextMonth()
        {
            if (!_IsDisplayingLastMonth)
            {
                SemanticsserviceDefaultClass.SemanticsService.Announce(_Localizations.FormatMonthYear(_NextMonthDate), _TextDirection);
                _PageController.NextPage(duration: CalendardatepickerDefaultClass._MonthScrollDuration, curve: CurvesDefaultClass.Curves.Ease);
            }

        }




        private void _HandlePreviousMonth()
        {
            if (!_IsDisplayingFirstMonth)
            {
                SemanticsserviceDefaultClass.SemanticsService.Announce(_Localizations.FormatMonthYear(_PreviousMonthDate), _TextDirection);
                _PageController.PreviousPage(duration: CalendardatepickerDefaultClass._MonthScrollDuration, curve: CurvesDefaultClass.Curves.Ease);
            }

        }




        private FlutterSDK.Widgets.Framework.Widget _BuildItems(FlutterSDK.Widgets.Framework.BuildContext context, int index)
        {
            DateTime month = Utils.DateutilsDefaultClass.AddMonthsToMonthDate(Widget.FirstDate, index);
            return new _DayPicker(key: new ValueKey<DateTime>(month), selectedDate: Widget.SelectedDate, currentDate: Widget.CurrentDate, onChanged: Widget.OnChanged, firstDate: Widget.FirstDate, lastDate: Widget.LastDate, displayedMonth: month, selectableDayPredicate: Widget.SelectableDayPredicate);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            string previousTooltipText = $"'{_Localizations.PreviousMonthTooltip} {_Localizations.FormatMonthYear(_PreviousMonthDate)}'";
            string nextTooltipText = $"'{_Localizations.NextMonthTooltip} {_Localizations.FormatMonthYear(_NextMonthDate)}'";
            Color controlColor = ThemeDefaultClass.Theme.Of(context).ColorScheme.OnSurface.WithOpacity(0.60);
            return new Semantics(child: new Column(children: new List<Widget>() { new Container(padding: EdgeInsetsDirectional.Only(start: 16, end: 4), height: CalendardatepickerDefaultClass._SubHeaderHeight, child: new Row(children: new List<Widget>() { new Spacer(), new IconButton(icon: new Icon(IconsDefaultClass.Icons.Chevron_left), color: controlColor, tooltip: _IsDisplayingFirstMonth ? null : previousTooltipText, onPressed: _IsDisplayingFirstMonth ? null : _HandlePreviousMonth), new IconButton(icon: new Icon(IconsDefaultClass.Icons.Chevron_right), color: controlColor, tooltip: _IsDisplayingLastMonth ? null : nextTooltipText, onPressed: _IsDisplayingLastMonth ? null : _HandleNextMonth) })), new _DayHeaders(), new Expanded(child: PageView.Builder(controller: _PageController, itemBuilder: _BuildItems, itemCount: Utils.DateutilsDefaultClass.MonthDelta(Widget.FirstDate, Widget.LastDate) + 1, scrollDirection: Axis.Horizontal, onPageChanged: _HandleMonthPageChanged)) }));
        }



    }


    /// <Summary>
    /// Displays the days of a given month and allows choosing a day.
    ///
    /// The days are arranged in a rectangular grid with one column for each day of
    /// the week.
    /// </Summary>
    public class _DayPicker : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _DayPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), DateTime currentDate = default(DateTime), DateTime displayedMonth = default(DateTime), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), DateTime selectedDate = default(DateTime), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate))
        : base(key: key)
        {
            this.CurrentDate = currentDate;
            this.DisplayedMonth = displayedMonth;
            this.FirstDate = firstDate;
            this.LastDate = lastDate;
            this.SelectedDate = selectedDate;
            this.OnChanged = onChanged;
            this.SelectableDayPredicate = selectableDayPredicate;
        }
        public virtual DateTime SelectedDate { get; set; }
        public virtual DateTime CurrentDate { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnChanged { get; set; }
        public virtual DateTime FirstDate { get; set; }
        public virtual DateTime LastDate { get; set; }
        public virtual DateTime DisplayedMonth { get; set; }
        public virtual FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate SelectableDayPredicate { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ColorScheme colorScheme = ThemeDefaultClass.Theme.Of(context).ColorScheme;
            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
            TextTheme textTheme = ThemeDefaultClass.Theme.Of(context).TextTheme;
            TextStyle dayStyle = textTheme.Caption;
            Color enabledDayColor = colorScheme.OnSurface.WithOpacity(0.87);
            Color disabledDayColor = colorScheme.OnSurface.WithOpacity(0.38);
            Color selectedDayColor = colorScheme.OnPrimary;
            Color selectedDayBackground = colorScheme.Primary;
            Color todayColor = colorScheme.Primary;
            int year = DisplayedMonth.Year;
            int month = DisplayedMonth.Month;
            int daysInMonth = Utils.DateutilsDefaultClass.GetDaysInMonth(year, month);
            int dayOffset = Utils.DateutilsDefaultClass.FirstDayOffset(year, month, localizations);
            List<Widget> dayItems = new List<Widget>() { };
            int day = -dayOffset;
            while (day < daysInMonth)
            {
                day++;
                if (day < 1)
                {
                    dayItems.Add(new Container());
                }
                else
                {
                    DateTime dayToBuild = new DateTime(year, month, day);
                    bool isDisabled = dayToBuild.IsAfter(LastDate) || dayToBuild.IsBefore(FirstDate) || (SelectableDayPredicate != null && !SelectableDayPredicate(dayToBuild));
                    BoxDecoration decoration = default(BoxDecoration);
                    Color dayColor = enabledDayColor;
                    bool isSelectedDay = Utils.DateutilsDefaultClass.IsSameDay(SelectedDate, dayToBuild);
                    if (isSelectedDay)
                    {
                        dayColor = selectedDayColor;
                        decoration = new BoxDecoration(color: selectedDayBackground, shape: BoxShape.Circle);
                    }
                    else if (isDisabled)
                    {
                        dayColor = disabledDayColor;
                    }
                    else if (Utils.DateutilsDefaultClass.IsSameDay(CurrentDate, dayToBuild))
                    {
                        dayColor = todayColor;
                        decoration = new BoxDecoration(border: Border.All(color: todayColor, width: 1), shape: BoxShape.Circle);
                    }

                    Widget dayWidget = new Container(decoration: decoration, child: new Center(child: new Text(localizations.FormatDecimal(day), style: dayStyle.Apply(color: dayColor))));
                    if (isDisabled)
                    {
                        dayWidget = new ExcludeSemantics(child: dayWidget);
                    }
                    else
                    {
                        dayWidget = new GestureDetector(behavior: HitTestBehavior.Opaque, onTap: () => =>OnChanged(dayToBuild), child: new Semantics(label: $"'{localizations.FormatDecimal(day)}, {localizations.FormatFullDate(dayToBuild)}'", selected: isSelectedDay, excludeSemantics: true, child: dayWidget));
                    }

                    dayItems.Add(dayWidget);
                }

            }

            return new Padding(padding: EdgeInsets.Symmetric(horizontal: CalendardatepickerDefaultClass._MonthPickerHorizontalPadding), child: GridView.Custom(physics: new ClampingScrollPhysics(), gridDelegate: CalendardatepickerDefaultClass._DayPickerGridDelegate, childrenDelegate: new SliverChildListDelegate(dayItems, addRepaintBoundaries: false)));
        }



    }


    public class _DayPickerGridDelegate : FlutterSDK.Rendering.Slivergrid.SliverGridDelegate
    {
        public _DayPickerGridDelegate()
        {

        }

        public new FlutterSDK.Rendering.Slivergrid.SliverGridLayout GetLayout(FlutterSDK.Rendering.Sliver.SliverConstraints constraints)
        {
            int columnCount = Dart:coreDefaultClass.DateTime.DaysPerWeek;
            double tileWidth = constraints.CrossAxisExtent / columnCount;
            double tileHeight = Math.Dart:mathDefaultClass.Min(CalendardatepickerDefaultClass._DayPickerRowHeight, constraints.ViewportMainAxisExtent / CalendardatepickerDefaultClass._MaxDayPickerRowCount);
            return new SliverGridRegularTileLayout(childCrossAxisExtent: tileWidth, childMainAxisExtent: tileHeight, crossAxisCount: columnCount, crossAxisStride: tileWidth, mainAxisStride: tileHeight, reverseCrossAxis: BasictypesDefaultClass.AxisDirectionIsReversed(constraints.CrossAxisDirection));
        }




        public new bool ShouldRelayout(FlutterSDK.Material.Pickers.Calendardatepicker._DayPickerGridDelegate oldDelegate) => false;

        public new bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate oldDelegate) => false;


    }


    public class _DayHeaders : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _DayHeaders()
        { }

        /// <Summary>
        /// Builds widgets showing abbreviated days of week. The first widget in the
        /// returned list corresponds to the first day of week for the current locale.
        ///
        /// Examples:
        ///
        /// ```
        /// ┌ Sunday is the first day of week in the US (en_US)
        /// |
        /// S M T W T F S  <-- the returned list contains these widgets
        /// _ _ _ _ _ 1 2
        /// 3 4 5 6 7 8 9
        ///
        /// ┌ But it's Monday in the UK (en_GB)
        /// |
        /// M T W T F S S  <-- the returned list contains these widgets
        /// _ _ _ _ 1 2 3
        /// 4 5 6 7 8 9 10
        /// ```
        /// </Summary>
        private List<FlutterSDK.Widgets.Framework.Widget> _GetDayHeaders(FlutterSDK.Painting.Textstyle.TextStyle headerStyle, FlutterSDK.Material.Materiallocalizations.MaterialLocalizations localizations)
        {
            List<Widget> result = new List<Widget>() { };
            for (int i = localizations.FirstDayOfWeekIndex; true; i = (i + 1) % 7)
            {
                string weekday = localizations.NarrowWeekdays[i];
                result.Add(new ExcludeSemantics(child: new Center(child: new Text(weekday, style: headerStyle))));
                if (i == (localizations.FirstDayOfWeekIndex - 1) % 7) break;
            }

            return result;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            ColorScheme colorScheme = theme.ColorScheme;
            TextStyle dayHeaderStyle = theme.TextTheme.Caption?.Apply(color: colorScheme.OnSurface.WithOpacity(0.60));
            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
            List<Widget> labels = _GetDayHeaders(dayHeaderStyle, localizations);
            return new Padding(padding: EdgeInsets.Symmetric(horizontal: CalendardatepickerDefaultClass._MonthPickerHorizontalPadding), child: GridView.Custom(shrinkWrap: true, gridDelegate: CalendardatepickerDefaultClass._DayPickerGridDelegate, childrenDelegate: new SliverChildListDelegate(labels, addRepaintBoundaries: false)));
        }



    }


    /// <Summary>
    /// A scrollable list of years to allow picking a year.
    /// </Summary>
    public class _YearPicker : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _YearPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), DateTime currentDate = default(DateTime), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), DateTime initialDate = default(DateTime), DateTime selectedDate = default(DateTime), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>))
        : base(key: key)
        {
            this.CurrentDate = currentDate;
            this.FirstDate = firstDate;
            this.LastDate = lastDate;
            this.InitialDate = initialDate;
            this.SelectedDate = selectedDate;
            this.OnChanged = onChanged;
        }
        public virtual DateTime CurrentDate { get; set; }
        public virtual DateTime FirstDate { get; set; }
        public virtual DateTime LastDate { get; set; }
        public virtual DateTime InitialDate { get; set; }
        public virtual DateTime SelectedDate { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnChanged { get; set; }

        public new FlutterSDK.Material.Pickers.Calendardatepicker._YearPickerState CreateState() => new _YearPickerState();


    }


    public class _YearPickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Calendardatepicker._YearPicker>
    {
        public _YearPickerState()
        { }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        public virtual int MinYears { get; set; }
        internal virtual int _ItemCount { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            int initialYearIndex = Widget.SelectedDate.Year - Widget.FirstDate.Year;
            int initialYearRow = initialYearIndex~/ CalendardatepickerDefaultClass._YearPickerColumnCount;
            int centeredYearRow = initialYearRow - 2;
            double scrollOffset = _ItemCount < MinYears ? 0 : centeredYearRow * CalendardatepickerDefaultClass._YearPickerRowHeight;
            ScrollController = new ScrollController(initialScrollOffset: scrollOffset);
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildYearItem(FlutterSDK.Widgets.Framework.BuildContext context, int index)
        {
            ColorScheme colorScheme = ThemeDefaultClass.Theme.Of(context).ColorScheme;
            TextTheme textTheme = ThemeDefaultClass.Theme.Of(context).TextTheme;
            int offset = _ItemCount < MinYears ? (MinYears - _ItemCount)~/ 2:0;
            int year = Widget.FirstDate.Year + index - offset;
            bool isSelected = year == Widget.SelectedDate.Year;
            bool isCurrentYear = year == Widget.CurrentDate.Year;
            bool isDisabled = year < Widget.FirstDate.Year || year > Widget.LastDate.Year;
            double decorationHeight = 36.0;
            double decorationWidth = 72.0;
            Color textColor = default(Color);
            if (isSelected)
            {
                textColor = colorScheme.OnPrimary;
            }
            else if (isDisabled)
            {
                textColor = colorScheme.OnSurface.WithOpacity(0.38);
            }
            else if (isCurrentYear)
            {
                textColor = colorScheme.Primary;
            }
            else
            {
                textColor = colorScheme.OnSurface.WithOpacity(0.87);
            }

            TextStyle itemStyle = textTheme.BodyText1?.Apply(color: textColor);
            BoxDecoration decoration = default(BoxDecoration);
            if (isSelected)
            {
                decoration = new BoxDecoration(color: colorScheme.Primary, borderRadius: BorderRadius.Circular(decorationHeight / 2), shape: BoxShape.Rectangle);
            }
            else if (isCurrentYear && !isDisabled)
            {
                decoration = new BoxDecoration(border: Border.All(color: colorScheme.Primary, width: 1), borderRadius: BorderRadius.Circular(decorationHeight / 2), shape: BoxShape.Rectangle);
            }

            Widget yearItem = new Center(child: new Container(decoration: decoration, height: decorationHeight, width: decorationWidth, child: new Center(child: new Semantics(selected: isSelected, child: new Text(year.ToString(), style: itemStyle)))));
            if (isDisabled)
            {
                yearItem = new ExcludeSemantics(child: yearItem);
            }
            else
            {
                yearItem = new InkWell(key: new ValueKey<int>(year), onTap: () =>
                {
                    Widget.OnChanged(new DateTime(year, Widget.InitialDate.Month, Widget.InitialDate.Day));
                }
                , child: yearItem);
            }

            return yearItem;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Column(children: new List<Widget>() { new Divider(), new Expanded(child: GridView.Builder(controller: ScrollController, gridDelegate: CalendardatepickerDefaultClass._YearPickerGridDelegate, itemBuilder: _BuildYearItem, itemCount: Math.Dart:mathDefaultClass.Max(_ItemCount, MinYears), padding: EdgeInsets.Symmetric(horizontal: CalendardatepickerDefaultClass._YearPickerPadding))), new Divider() });
        }



    }


    public class _YearPickerGridDelegate : FlutterSDK.Rendering.Slivergrid.SliverGridDelegate
    {
        public _YearPickerGridDelegate()
        {

        }

        public new FlutterSDK.Rendering.Slivergrid.SliverGridLayout GetLayout(FlutterSDK.Rendering.Sliver.SliverConstraints constraints)
        {
            double tileWidth = (constraints.CrossAxisExtent - (CalendardatepickerDefaultClass._YearPickerColumnCount - 1) * CalendardatepickerDefaultClass._YearPickerRowSpacing) / CalendardatepickerDefaultClass._YearPickerColumnCount;
            return new SliverGridRegularTileLayout(childCrossAxisExtent: tileWidth, childMainAxisExtent: CalendardatepickerDefaultClass._YearPickerRowHeight, crossAxisCount: CalendardatepickerDefaultClass._YearPickerColumnCount, crossAxisStride: tileWidth + CalendardatepickerDefaultClass._YearPickerRowSpacing, mainAxisStride: CalendardatepickerDefaultClass._YearPickerRowHeight, reverseCrossAxis: BasictypesDefaultClass.AxisDirectionIsReversed(constraints.CrossAxisDirection));
        }




        public new bool ShouldRelayout(FlutterSDK.Material.Pickers.Calendardatepicker._YearPickerGridDelegate oldDelegate) => false;

        public new bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate oldDelegate) => false;


    }

}
