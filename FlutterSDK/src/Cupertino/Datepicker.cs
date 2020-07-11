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
namespace FlutterSDK.Cupertino.Datepicker
{
    public delegate FlutterSDK.Widgets.Framework.Widget _ColumnBuilder(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder);
    internal static class DatepickerDefaultClass
    {
        public static double _KItemExtent = default(double);
        public static double _KPickerWidth = default(double);
        public static double _KPickerHeight = default(double);
        public static bool _KUseMagnifier = default(bool);
        public static double _KMagnification = default(double);
        public static double _KDatePickerPadSize = default(double);
        public static double _KSqueeze = default(double);
        public static FlutterSDK.Painting.Textstyle.TextStyle _KDefaultPickerTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle);
        public static double _KTimerPickerHalfColumnPadding = default(double);
        public static double _KTimerPickerLabelPadSize = default(double);
        public static double _KTimerPickerLabelFontSize = default(double);
        public static double _KTimerPickerColumnIntrinsicWidth = default(double);
        public static double _KTimerPickerNumberLabelFontSize = default(double);
        internal static FlutterSDK.Painting.Textstyle.TextStyle _ThemeTextStyle(FlutterSDK.Widgets.Framework.BuildContext context, bool isValid = true)
        {
            throw new NotImplementedException();
        }

        internal static void _AnimateColumnControllerToItem(FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController controller, int targetItem)
        {
            throw new NotImplementedException();
        }

    }

    public class _DatePickerLayoutDelegate : FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate
    {
        #region constructors
        public _DatePickerLayoutDelegate(List<double> columnWidths = default(List<double>), int textDirectionFactor = default(int))
        : base()
        {
            this.ColumnWidths = columnWidths;
            this.TextDirectionFactor = textDirectionFactor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<double> ColumnWidths { get; set; }
        public virtual int TextDirectionFactor { get; set; }
        #endregion

        #region methods

        public new void PerformLayout(Size size) { throw new NotImplementedException(); }


        public new bool ShouldRelayout(FlutterSDK.Cupertino.Datepicker._DatePickerLayoutDelegate oldDelegate) { throw new NotImplementedException(); }
        public new bool ShouldRelayout(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate oldDelegate) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A date picker widget in iOS style.
    ///
    /// There are several modes of the date picker listed in [CupertinoDatePickerMode].
    ///
    /// The class will display its children as consecutive columns. Its children
    /// order is based on internationalization.
    ///
    /// Example of the picker in date mode:
    ///
    ///  * US-English: `| July | 13 | 2012 |`
    ///  * Vietnamese: `| 13 | Tháng 7 | 2012 |`
    ///
    /// Can be used with [showCupertinoModalPopup] to display the picker modally at
    /// the bottom of the screen.
    ///
    /// Sizes itself to its parent and may not render correctly if not given the
    /// full screen width. Content texts are shown with
    /// [CupertinoTextThemeData.dateTimePickerTextStyle].
    ///
    /// See also:
    ///
    ///  * [CupertinoTimerPicker], the class that implements the iOS-style timer picker.
    ///  * [CupertinoPicker], the class that implements a content agnostic spinner UI.
    /// </Summary>
    public class CupertinoDatePicker : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public CupertinoDatePicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Cupertino.Datepicker.CupertinoDatePickerMode mode = default(FlutterSDK.Cupertino.Datepicker.CupertinoDatePickerMode), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onDateTimeChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), DateTime initialDateTime = default(DateTime), DateTime minimumDate = default(DateTime), DateTime maximumDate = default(DateTime), int minimumYear = 1, int maximumYear = default(int), int minuteInterval = 1, bool use24hFormat = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Mode = mode;
            this.OnDateTimeChanged = onDateTimeChanged;
            this.MinimumDate = minimumDate;
            this.MaximumDate = maximumDate;
            this.MinimumYear = minimumYear;
            this.MaximumYear = maximumYear;
            this.MinuteInterval = minuteInterval;
            this.Use24hFormat = use24hFormat;
            this.BackgroundColor = backgroundColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Cupertino.Datepicker.CupertinoDatePickerMode Mode { get; set; }
        public virtual DateTime InitialDateTime { get; set; }
        public virtual DateTime MinimumDate { get; set; }
        public virtual DateTime MaximumDate { get; set; }
        public virtual int MinimumYear { get; set; }
        public virtual int MaximumYear { get; set; }
        public virtual int MinuteInterval { get; set; }
        public virtual bool Use24hFormat { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnDateTimeChanged { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() { throw new NotImplementedException(); }


        private double _GetColumnWidth(FlutterSDK.Cupertino.Datepicker._PickerColumnType columnType, FlutterSDK.Cupertino.Localizations.CupertinoLocalizations localizations, FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoDatePickerDateTimeState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Datepicker.CupertinoDatePicker>
    {
        #region constructors
        public _CupertinoDatePickerDateTimeState()
        { }
        #endregion

        #region fields
        internal virtual double _KMaximumOffAxisFraction { get; set; }
        public virtual int TextDirectionFactor { get; set; }
        public virtual FlutterSDK.Cupertino.Localizations.CupertinoLocalizations Localizations { get; set; }
        public virtual FlutterSDK.Painting.Alignment.Alignment AlignCenterLeft { get; set; }
        public virtual FlutterSDK.Painting.Alignment.Alignment AlignCenterRight { get; set; }
        public virtual DateTime InitialDateTime { get; set; }
        public virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController DateController { get; set; }
        public virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController HourController { get; set; }
        public virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController MinuteController { get; set; }
        public virtual int SelectedAmPm { get; set; }
        public virtual int MeridiemRegion { get; set; }
        public virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController MeridiemController { get; set; }
        public virtual bool IsDatePickerScrolling { get; set; }
        public virtual bool IsHourPickerScrolling { get; set; }
        public virtual bool IsMinutePickerScrolling { get; set; }
        public virtual bool IsMeridiemPickerScrolling { get; set; }
        public virtual Dictionary<int, double> EstimatedColumnWidths { get; set; }
        public virtual int SelectedDayFromInitial { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int SelectedHour { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual int _SelectedHourIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int SelectedMinute { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsHourRegionFlipped { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual DateTime SelectedDateTime { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private int _SelectedHour(int selectedAmPm, int selectedHour) { throw new NotImplementedException(); }


        private bool _IsHourRegionFlipped(int selectedAmPm) { throw new NotImplementedException(); }


        public new void InitState() { throw new NotImplementedException(); }


        private void _HandleSystemFontsChange() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Cupertino.Datepicker.CupertinoDatePicker oldWidget) { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        private double _GetEstimatedColumnWidth(FlutterSDK.Cupertino.Datepicker._PickerColumnType columnType) { throw new NotImplementedException(); }


        private void _OnSelectedItemChange(int index) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildMediumDatePicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder) { throw new NotImplementedException(); }


        private bool _IsValidHour(int meridiemIndex, int hourIndex) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildHourPicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildMinutePicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildAmPmPicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder) { throw new NotImplementedException(); }


        private void _PickerDidStopScrolling() { throw new NotImplementedException(); }


        private void _ScrollToDate(DateTime newDate, DateTime fromDate) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoDatePickerDateState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Datepicker.CupertinoDatePicker>
    {
        #region constructors
        public _CupertinoDatePickerDateState()
        { }
        #endregion

        #region fields
        public virtual int TextDirectionFactor { get; set; }
        public virtual FlutterSDK.Cupertino.Localizations.CupertinoLocalizations Localizations { get; set; }
        public virtual FlutterSDK.Painting.Alignment.Alignment AlignCenterLeft { get; set; }
        public virtual FlutterSDK.Painting.Alignment.Alignment AlignCenterRight { get; set; }
        public virtual int SelectedDay { get; set; }
        public virtual int SelectedMonth { get; set; }
        public virtual int SelectedYear { get; set; }
        public virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController DayController { get; set; }
        public virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController MonthController { get; set; }
        public virtual FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController YearController { get; set; }
        public virtual bool IsDayPickerScrolling { get; set; }
        public virtual bool IsMonthPickerScrolling { get; set; }
        public virtual bool IsYearPickerScrolling { get; set; }
        public virtual Dictionary<int, double> EstimatedColumnWidths { get; set; }
        public virtual bool IsScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsCurrentDateValid { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        private void _HandleSystemFontsChange() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        private void _RefreshEstimatedColumnWidths() { throw new NotImplementedException(); }


        private DateTime _LastDayInMonth(int year, int month) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildDayPicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildMonthPicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildYearPicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder) { throw new NotImplementedException(); }


        private void _PickerDidStopScrolling() { throw new NotImplementedException(); }


        private void _ScrollToDate(DateTime newDate) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A countdown timer picker in iOS style.
    ///
    /// This picker shows a countdown duration with hour, minute and second spinners.
    /// The duration is bound between 0 and 23 hours 59 minutes 59 seconds.
    ///
    /// There are several modes of the timer picker listed in [CupertinoTimerPickerMode].
    ///
    /// The picker has a fixed size of 320 x 216, in logical pixels, with the exception
    /// of [CupertinoTimerPickerMode.hms], which is 330 x 216. If the parent widget
    /// provides more space than it needs, the picker will position itself according
    /// to its [alignment] property.
    ///
    /// See also:
    ///
    ///  * [CupertinoDatePicker], the class that implements different display modes
    ///    of the iOS-style date picker.
    ///  * [CupertinoPicker], the class that implements a content agnostic spinner UI.
    /// </Summary>
    public class CupertinoTimerPicker : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public CupertinoTimerPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Cupertino.Datepicker.CupertinoTimerPickerMode mode = default(FlutterSDK.Cupertino.Datepicker.CupertinoTimerPickerMode), TimeSpan initialTimerDuration = default(TimeSpan), int minuteInterval = 1, int secondInterval = 1, FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<TimeSpan> onTimerDurationChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<TimeSpan>))
        : base(key: key)
        {
            this.Mode = mode;
            this.InitialTimerDuration = initialTimerDuration;
            this.MinuteInterval = minuteInterval;
            this.SecondInterval = secondInterval;
            this.Alignment = alignment;
            this.BackgroundColor = backgroundColor;
            this.OnTimerDurationChanged = onTimerDurationChanged; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Cupertino.Datepicker.CupertinoTimerPickerMode Mode { get; set; }
        public virtual TimeSpan InitialTimerDuration { get; set; }
        public virtual int MinuteInterval { get; set; }
        public virtual int SecondInterval { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<TimeSpan> OnTimerDurationChanged { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _CupertinoTimerPickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Datepicker.CupertinoTimerPicker>
    {
        #region constructors
        public _CupertinoTimerPickerState()
        { }
        #endregion

        #region fields
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Cupertino.Localizations.CupertinoLocalizations Localizations { get; set; }
        public virtual int SelectedHour { get; set; }
        public virtual int SelectedMinute { get; set; }
        public virtual int SelectedSecond { get; set; }
        public virtual int LastSelectedHour { get; set; }
        public virtual int LastSelectedMinute { get; set; }
        public virtual int LastSelectedSecond { get; set; }
        public virtual FlutterSDK.Painting.Textpainter.TextPainter TextPainter { get; set; }
        public virtual List<string> Numbers { get; set; }
        public virtual double NumberLabelWidth { get; set; }
        public virtual double NumberLabelHeight { get; set; }
        public virtual double NumberLabelBaseline { get; set; }
        public virtual int TextDirectionFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        private void _HandleSystemFontsChange() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Cupertino.Datepicker.CupertinoTimerPicker oldWidget) { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        private void _MeasureLabelMetrics() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildLabel(string text, FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional pickerPadding) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildPickerNumberLabel(string text, FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildHourPicker(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildHourColumn(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildMinutePicker(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildMinuteColumn(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildSecondPicker(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildSecondColumn(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Textstyle.TextStyle _TextStyleFrom(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Different display modes of [CupertinoDatePicker].
    ///
    /// See also:
    ///
    ///  * [CupertinoDatePicker], the class that implements different display modes
    ///    of the iOS-style date picker.
    ///  * [CupertinoPicker], the class that implements a content agnostic spinner UI.
    /// </Summary>
    public enum CupertinoDatePickerMode
    {

        /// <Summary>
        /// Mode that shows the date in hour, minute, and (optional) an AM/PM designation.
        /// The AM/PM designation is shown only if [CupertinoDatePicker] does not use 24h format.
        /// Column order is subject to internationalization.
        ///
        /// Example: ` 4 | 14 | PM `.
        /// </Summary>
        Time,
        /// <Summary>
        /// Mode that shows the date in month, day of month, and year.
        /// Name of month is spelled in full.
        /// Column order is subject to internationalization.
        ///
        /// Example: ` July | 13 | 2012 `.
        /// </Summary>
        Date,
        /// <Summary>
        /// Mode that shows the date as day of the week, month, day of month and
        /// the time in hour, minute, and (optional) an AM/PM designation.
        /// The AM/PM designation is shown only if [CupertinoDatePicker] does not use 24h format.
        /// Column order is subject to internationalization.
        ///
        /// Example: ` Fri Jul 13 | 4 | 14 | PM `
        /// </Summary>
        DateAndTime,
    }


    public enum _PickerColumnType
    {

        DayOfMonth,
        Month,
        Year,
        Date,
        Hour,
        Minute,
        DayPeriod,
    }


    /// <Summary>
    /// Different modes of [CupertinoTimerPicker].
    ///
    /// See also:
    ///
    ///  * [CupertinoTimerPicker], the class that implements the iOS-style timer picker.
    ///  * [CupertinoPicker], the class that implements a content agnostic spinner UI.
    /// </Summary>
    public enum CupertinoTimerPickerMode
    {

        /// <Summary>
        /// Mode that shows the timer duration in hour and minute.
        ///
        /// Examples: 16 hours | 14 min.
        /// </Summary>
        Hm,
        /// <Summary>
        /// Mode that shows the timer duration in minute and second.
        ///
        /// Examples: 14 min | 43 sec.
        /// </Summary>
        Ms,
        /// <Summary>
        /// Mode that shows the timer duration in hour, minute, and second.
        ///
        /// Examples: 16 hours | 14 min | 43 sec.
        /// </Summary>
        Hms,
    }

}
