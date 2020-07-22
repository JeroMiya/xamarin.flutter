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
            TextStyle style = ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.DateTimePickerTextStyle;
            return isValid ? style : style.CopyWith(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.InactiveGray, context));
        }



        internal static void _AnimateColumnControllerToItem(FlutterSDK.Widgets.Listwheelscrollview.FixedExtentScrollController controller, int targetItem)
        {
            controller.AnimateToItem(targetItem, curve: CurvesDefaultClass.Curves.EaseInOut, duration: new TimeSpan(milliseconds: 200));
        }



    }

    public class _DatePickerLayoutDelegate : FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate
    {
        public _DatePickerLayoutDelegate(List<double> columnWidths = default(List<double>), int textDirectionFactor = default(int))
        : base()
        {
            this.ColumnWidths = columnWidths;
            this.TextDirectionFactor = textDirectionFactor;
        }
        public virtual List<double> ColumnWidths { get; set; }
        public virtual int TextDirectionFactor { get; set; }

        public new void PerformLayout(Size size)
        {
            double remainingWidth = size.Width;
            for (int i = 0; i < ColumnWidths.Count; i++) remainingWidth -= ColumnWidths[i] + DatepickerDefaultClass._KDatePickerPadSize * 2;
            double currentHorizontalOffset = 0.0;
            for (int i = 0; i < ColumnWidths.Count; i++)
            {
                int index = TextDirectionFactor == 1 ? i : ColumnWidths.Count - i - 1;
                double childWidth = ColumnWidths[index] + DatepickerDefaultClass._KDatePickerPadSize * 2;
                if (index == 0 || index == ColumnWidths.Count - 1) childWidth += remainingWidth / 2;

                LayoutChild(index, BoxConstraints.Tight(new Size(Math.Dart:mathDefaultClass.Max(0.0, childWidth), size.Height)));
                PositionChild(index, new Offset(currentHorizontalOffset, 0.0));
                currentHorizontalOffset += childWidth;
            }

        }




        public new bool ShouldRelayout(FlutterSDK.Cupertino.Datepicker._DatePickerLayoutDelegate oldDelegate)
        {
            return ColumnWidths != oldDelegate.ColumnWidths || TextDirectionFactor != oldDelegate.TextDirectionFactor;
        }


        public new bool ShouldRelayout(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate oldDelegate)
        {
            return ColumnWidths != oldDelegate.ColumnWidths || TextDirectionFactor != oldDelegate.TextDirectionFactor;
        }



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
            this.BackgroundColor = backgroundColor;








        }


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

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState()
        {
            switch (Mode) { case CupertinoDatePickerMode.Time: case CupertinoDatePickerMode.DateAndTime: return new _CupertinoDatePickerDateTimeState(); case CupertinoDatePickerMode.Date: return new _CupertinoDatePickerDateState(); }

            return new _CupertinoDatePickerDateTimeState();
        }




        private double _GetColumnWidth(FlutterSDK.Cupertino.Datepicker._PickerColumnType columnType, FlutterSDK.Cupertino.Localizations.CupertinoLocalizations localizations, FlutterSDK.Widgets.Framework.BuildContext context)
        {
            string longestText = "";
            switch (columnType)
            {
                case _PickerColumnType.Date:
                    for (int i = 1; i <= 12; i++)
                    {
                        string date = localizations.DatePickerMediumDate(new DateTime(2018, i, 25));
                        if (longestText.Length < date.Length) longestText = date;
                    }
                    break;
                case _PickerColumnType.Hour:
                    for (int i = 0; i < 24; i++)
                    {
                        string hour = localizations.DatePickerHour(i);
                        if (longestText.Length < hour.Length) longestText = hour;
                    }
                    break;
                case _PickerColumnType.Minute:
                    for (int i = 0; i < 60; i++)
                    {
                        string minute = localizations.DatePickerMinute(i);
                        if (longestText.Length < minute.Length) longestText = minute;
                    }
                    break;
                case _PickerColumnType.DayPeriod: longestText = localizations.AnteMeridiemAbbreviation.Length > localizations.PostMeridiemAbbreviation.Length ? localizations.AnteMeridiemAbbreviation : localizations.PostMeridiemAbbreviation; break;
                case _PickerColumnType.DayOfMonth:
                    for (int i = 1; i <= 31; i++)
                    {
                        string dayOfMonth = localizations.DatePickerDayOfMonth(i);
                        if (longestText.Length < dayOfMonth.Length) longestText = dayOfMonth;
                    }
                    break;
                case _PickerColumnType.Month:
                    for (int i = 1; i <= 12; i++)
                    {
                        string month = localizations.DatePickerMonth(i);
                        if (longestText.Length < month.Length) longestText = month;
                    }
                    break;
                case _PickerColumnType.Year: longestText = localizations.DatePickerYear(2018); break;
            }

            TextPainter painter = new TextPainter(text: new TextSpan(style: DatepickerDefaultClass._ThemeTextStyle(context), text: longestText), textDirection: BasicDefaultClass.Directionality.Of(context));
            painter.Layout();
            return painter.MaxIntrinsicWidth;
        }



    }


    public class _CupertinoDatePickerDateTimeState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Datepicker.CupertinoDatePicker>
    {
        public _CupertinoDatePickerDateTimeState()
        { }
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

        private int _SelectedHour(int selectedAmPm, int selectedHour)
        {
            return _IsHourRegionFlipped(selectedAmPm) ? (selectedHour + 12) % 24 : selectedHour;
        }




        private bool _IsHourRegionFlipped(int selectedAmPm) => selectedAmPm != MeridiemRegion;



        public new void InitState()
        {
            base.InitState();
            InitialDateTime = Widget.InitialDateTime;
            SelectedAmPm = InitialDateTime.Hour~/ 12;
            MeridiemRegion = SelectedAmPm;
            MeridiemController = new FixedExtentScrollController(initialItem: SelectedAmPm);
            HourController = new FixedExtentScrollController(initialItem: InitialDateTime.Hour);
            MinuteController = new FixedExtentScrollController(initialItem: InitialDateTime.Minute~/ Widget.MinuteInterval);
            DateController = new FixedExtentScrollController(initialItem: 0);
            BindingDefaultClass.PaintingBinding.Instance.SystemFonts.AddListener(_HandleSystemFontsChange);
        }




        private void _HandleSystemFontsChange()
        {
            SetState(() =>
            {
                EstimatedColumnWidths.Clear();
            }
            );
        }




        public new void Dispose()
        {
            DateController.Dispose();
            HourController.Dispose();
            MinuteController.Dispose();
            MeridiemController.Dispose();
            BindingDefaultClass.PaintingBinding.Instance.SystemFonts.RemoveListener(_HandleSystemFontsChange);
            base.Dispose();
        }




        public new void DidUpdateWidget(FlutterSDK.Cupertino.Datepicker.CupertinoDatePicker oldWidget)
        {
            base.DidUpdateWidget(oldWidget);

            if (!Widget.Use24hFormat && oldWidget.Use24hFormat)
            {
                MeridiemController.Dispose();
                MeridiemController = new FixedExtentScrollController(initialItem: SelectedAmPm);
            }

        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            TextDirectionFactor = BasicDefaultClass.Directionality.Of(Context) == TextDirection.Ltr ? 1 : -1;
            Localizations = LocalizationsDefaultClass.CupertinoLocalizations.Of(Context);
            AlignCenterLeft = TextDirectionFactor == 1 ? AlignmentDefaultClass.Alignment.CenterLeft : AlignmentDefaultClass.Alignment.CenterRight;
            AlignCenterRight = TextDirectionFactor == 1 ? AlignmentDefaultClass.Alignment.CenterRight : AlignmentDefaultClass.Alignment.CenterLeft;
            EstimatedColumnWidths.Clear();
        }




        private double _GetEstimatedColumnWidth(FlutterSDK.Cupertino.Datepicker._PickerColumnType columnType)
        {
            if (EstimatedColumnWidths[columnType.Index] == null)
            {
                EstimatedColumnWidths[columnType.Index] = DatepickerDefaultClass.CupertinoDatePicker._GetColumnWidth(columnType, Localizations, Context);
            }

            return EstimatedColumnWidths[columnType.Index];
        }




        private void _OnSelectedItemChange(int index)
        {
            DateTime selected = SelectedDateTime;
            bool isDateInvalid = Widget.MinimumDate?.IsAfter(selected) == true || Widget.MaximumDate?.IsBefore(selected) == true;
            if (isDateInvalid) return;
            Widget.OnDateTimeChanged(selected);
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildMediumDatePicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder)
        {
            return new NotificationListener<ScrollNotification>(onNotification: (ScrollNotification notification) =>
            {
                if (notification is ScrollStartNotification)
                {
                    IsDatePickerScrolling = true;
                }
                else if (notification is ScrollEndNotification)
                {
                    IsDatePickerScrolling = false;
                    _PickerDidStopScrolling();
                }

                return false;
            }
            , child: CupertinoPicker.Builder(scrollController: DateController, offAxisFraction: offAxisFraction, itemExtent: DatepickerDefaultClass._KItemExtent, useMagnifier: DatepickerDefaultClass._KUseMagnifier, magnification: DatepickerDefaultClass._KMagnification, backgroundColor: Widget.BackgroundColor, squeeze: DatepickerDefaultClass._KSqueeze, onSelectedItemChanged: (int index) =>
            {
                _OnSelectedItemChange(index);
            }
            , itemBuilder: (BuildContext context, int index) =>
            {
                DateTime rangeStart = new DateTime(InitialDateTime.Year, InitialDateTime.Month, InitialDateTime.Day + index);
                DateTime rangeEnd = new DateTime(InitialDateTime.Year, InitialDateTime.Month, InitialDateTime.Day + index + 1);
                DateTime now = DateTime.Now();
                if (Widget.MinimumDate?.IsAfter(rangeEnd) == true) return null;
                if (Widget.MaximumDate?.IsAfter(rangeStart) == false) return null;
                string dateText = rangeStart == new DateTime(now.Year, now.Month, now.Day) ? Localizations.TodayLabel : Localizations.DatePickerMediumDate(rangeStart);
                return itemPositioningBuilder(context, new Text(dateText, style: DatepickerDefaultClass._ThemeTextStyle(context)));
            }
            ));
        }




        private bool _IsValidHour(int meridiemIndex, int hourIndex)
        {
            DateTime rangeStart = new DateTime(InitialDateTime.Year, InitialDateTime.Month, InitialDateTime.Day + SelectedDayFromInitial, _SelectedHour(meridiemIndex, hourIndex), 0);
            DateTime rangeEnd = rangeStart.Add(new TimeSpan(hours: 1));
            return (Widget.MinimumDate?.IsBefore(rangeEnd) ?? true) && !(Widget.MaximumDate?.IsBefore(rangeStart) ?? false);
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildHourPicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder)
        {
            return new NotificationListener<ScrollNotification>(onNotification: (ScrollNotification notification) =>
            {
                if (notification is ScrollStartNotification)
                {
                    IsHourPickerScrolling = true;
                }
                else if (notification is ScrollEndNotification)
                {
                    IsHourPickerScrolling = false;
                    _PickerDidStopScrolling();
                }

                return false;
            }
            , child: new CupertinoPicker(scrollController: HourController, offAxisFraction: offAxisFraction, itemExtent: DatepickerDefaultClass._KItemExtent, useMagnifier: DatepickerDefaultClass._KUseMagnifier, magnification: DatepickerDefaultClass._KMagnification, backgroundColor: Widget.BackgroundColor, squeeze: DatepickerDefaultClass._KSqueeze, onSelectedItemChanged: (int index) =>
            {
                bool regionChanged = MeridiemRegion != index~/ 12;
                bool debugIsFlipped = IsHourRegionFlipped;
                if (regionChanged)
                {
                    MeridiemRegion = index~/ 12;
                    SelectedAmPm = 1 - SelectedAmPm;
                }

                if (!Widget.Use24hFormat && regionChanged)
                {
                    MeridiemController.AnimateToItem(SelectedAmPm, duration: new TimeSpan(milliseconds: 300), curve: CurvesDefaultClass.Curves.EaseOut);
                }
                else
                {
                    _OnSelectedItemChange(index);
                }


            }
            , children: List<Widget>.Generate(24, (int index) =>
            {
                int hour = IsHourRegionFlipped ? (index + 12) % 24 : index;
                int displayHour = Widget.Use24hFormat ? hour : (hour + 11) % 12 + 1;
                return itemPositioningBuilder(Context, new Text(Localizations.DatePickerHour(displayHour), semanticsLabel: Localizations.DatePickerHourSemanticsLabel(displayHour), style: DatepickerDefaultClass._ThemeTextStyle(Context, isValid: _IsValidHour(SelectedAmPm, index))));
            }
            ), looping: true));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildMinutePicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder)
        {
            return new NotificationListener<ScrollNotification>(onNotification: (ScrollNotification notification) =>
            {
                if (notification is ScrollStartNotification)
                {
                    IsMinutePickerScrolling = true;
                }
                else if (notification is ScrollEndNotification)
                {
                    IsMinutePickerScrolling = false;
                    _PickerDidStopScrolling();
                }

                return false;
            }
            , child: new CupertinoPicker(scrollController: MinuteController, offAxisFraction: offAxisFraction, itemExtent: DatepickerDefaultClass._KItemExtent, useMagnifier: DatepickerDefaultClass._KUseMagnifier, magnification: DatepickerDefaultClass._KMagnification, backgroundColor: Widget.BackgroundColor, squeeze: DatepickerDefaultClass._KSqueeze, onSelectedItemChanged: _OnSelectedItemChange, children: List<Widget>.Generate(60~/ Widget.MinuteInterval, (int index) =>
            {
                int minute = index * Widget.MinuteInterval;
                DateTime date = new DateTime(InitialDateTime.Year, InitialDateTime.Month, InitialDateTime.Day + SelectedDayFromInitial, SelectedHour, minute);
                bool isInvalidMinute = (Widget.MinimumDate?.IsAfter(date) ?? false) || (Widget.MaximumDate?.IsBefore(date) ?? false);
                return itemPositioningBuilder(Context, new Text(Localizations.DatePickerMinute(minute), semanticsLabel: Localizations.DatePickerMinuteSemanticsLabel(minute), style: DatepickerDefaultClass._ThemeTextStyle(Context, isValid: !isInvalidMinute)));
            }
            ), looping: true));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildAmPmPicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder)
        {
            return new NotificationListener<ScrollNotification>(onNotification: (ScrollNotification notification) =>
            {
                if (notification is ScrollStartNotification)
                {
                    IsMeridiemPickerScrolling = true;
                }
                else if (notification is ScrollEndNotification)
                {
                    IsMeridiemPickerScrolling = false;
                    _PickerDidStopScrolling();
                }

                return false;
            }
            , child: new CupertinoPicker(scrollController: MeridiemController, offAxisFraction: offAxisFraction, itemExtent: DatepickerDefaultClass._KItemExtent, useMagnifier: DatepickerDefaultClass._KUseMagnifier, magnification: DatepickerDefaultClass._KMagnification, backgroundColor: Widget.BackgroundColor, squeeze: DatepickerDefaultClass._KSqueeze, onSelectedItemChanged: (int index) =>
            {
                SelectedAmPm = index;

                _OnSelectedItemChange(index);
            }
            , children: List<Widget>.Generate(2, (int index) =>
            {
                return itemPositioningBuilder(Context, new Text(index == 0 ? Localizations.AnteMeridiemAbbreviation : Localizations.PostMeridiemAbbreviation, style: DatepickerDefaultClass._ThemeTextStyle(Context, isValid: _IsValidHour(index, _SelectedHourIndex))));
            }
            )));
        }




        private void _PickerDidStopScrolling()
        {
            SetState(() =>
            {
            }
            );
            if (IsScrolling) return;
            DateTime selectedDate = SelectedDateTime;
            bool minCheck = Widget.MinimumDate?.IsAfter(selectedDate) ?? false;
            bool maxCheck = Widget.MaximumDate?.IsBefore(selectedDate) ?? false;
            if (minCheck || maxCheck)
            {
                DateTime targetDate = minCheck ? Widget.MinimumDate : Widget.MaximumDate;
                _ScrollToDate(targetDate, selectedDate);
            }

        }




        private void _ScrollToDate(DateTime newDate, DateTime fromDate)
        {

            BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan timestamp) =>
            {
            if (fromDate.Year != newDate.Year || fromDate.Month != newDate.Month || fromDate.Day != newDate.Day)
            {
                DatepickerDefaultClass._AnimateColumnControllerToItem(DateController, SelectedDayFromInitial);
            }

            if (fromDate.Hour != newDate.Hour)
            {
                bool needsMeridiemChange = !Widget.Use24hFormat && fromDate.Hour~/ 12 != newDate.Hour~/ 12;
                if (needsMeridiemChange)
                {
                    DatepickerDefaultClass._AnimateColumnControllerToItem(MeridiemController, 1 - MeridiemController.SelectedItem);
                    int newItem = (HourController.SelectedItem~/ 12) * 12 + (HourController.SelectedItem + newDate.Hour - fromDate.Hour) % 12;
            DatepickerDefaultClass._AnimateColumnControllerToItem(HourController, newItem);
        }
else {
DatepickerDefaultClass._AnimateColumnControllerToItem(HourController, HourController.SelectedItem+newDate.Hour-fromDate.Hour);
}

}

if (fromDate.Minute != newDate.Minute)
{
    DatepickerDefaultClass._AnimateColumnControllerToItem(MinuteController, newDate.Minute);
}

}
);
}




public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    List<double> columnWidths = new List<double>() { _GetEstimatedColumnWidth(_PickerColumnType.Hour), _GetEstimatedColumnWidth(_PickerColumnType.Minute) };
    List<_ColumnBuilder> pickerBuilders = new List<_ColumnBuilder>() { _BuildHourPicker, _BuildMinutePicker };
    if (!Widget.Use24hFormat)
    {
        if (Localizations.DatePickerDateTimeOrder == DatePickerDateTimeOrder.Date_time_dayPeriod || Localizations.DatePickerDateTimeOrder == DatePickerDateTimeOrder.Time_dayPeriod_date)
        {
            pickerBuilders.Add(_BuildAmPmPicker);
            columnWidths.Add(_GetEstimatedColumnWidth(_PickerColumnType.DayPeriod));
        }
        else
        {
            pickerBuilders.Insert(0, _BuildAmPmPicker);
            columnWidths.Insert(0, _GetEstimatedColumnWidth(_PickerColumnType.DayPeriod));
        }

    }

    if (Widget.Mode == CupertinoDatePickerMode.DateAndTime)
    {
        if (Localizations.DatePickerDateTimeOrder == DatePickerDateTimeOrder.Time_dayPeriod_date || Localizations.DatePickerDateTimeOrder == DatePickerDateTimeOrder.DayPeriod_time_date)
        {
            pickerBuilders.Add(_BuildMediumDatePicker);
            columnWidths.Add(_GetEstimatedColumnWidth(_PickerColumnType.Date));
        }
        else
        {
            pickerBuilders.Insert(0, _BuildMediumDatePicker);
            columnWidths.Insert(0, _GetEstimatedColumnWidth(_PickerColumnType.Date));
        }

    }

    List<Widget> pickers = new List<Widget>() { };
    for (int i = 0; i < columnWidths.Count; i++)
    {
        double offAxisFraction = 0.0;
        if (i == 0) offAxisFraction = -_KMaximumOffAxisFraction * TextDirectionFactor; else if (i >= 2 || columnWidths.Count == 2) offAxisFraction = _KMaximumOffAxisFraction * TextDirectionFactor;
        EdgeInsets padding = EdgeInsets.Only(right: DatepickerDefaultClass._KDatePickerPadSize);
        if (i == columnWidths.Count - 1) padding = padding.Flipped;
        if (TextDirectionFactor == -1) padding = padding.Flipped;
        pickers.Add(new LayoutId(id: i, child: pickerBuilders[i](offAxisFraction, (BuildContext context, Widget child) =>
        {
            return new Container(alignment: i == columnWidths.Count - 1 ? AlignCenterLeft : AlignCenterRight, padding: padding, child: new Container(alignment: i == columnWidths.Count - 1 ? AlignCenterLeft : AlignCenterRight, width: i == 0 || i == columnWidths.Count - 1 ? null : columnWidths[i] + DatepickerDefaultClass._KDatePickerPadSize, child: child));
        }
        )));
    }

    return new MediaQuery(data: MediaqueryDefaultClass.MediaQuery.Of(context).CopyWith(textScaleFactor: 1.0), child: TextDefaultClass.DefaultTextStyle.Merge(style: DatepickerDefaultClass._KDefaultPickerTextStyle, child: new CustomMultiChildLayout(@delegate: new _DatePickerLayoutDelegate(columnWidths: columnWidths, textDirectionFactor: TextDirectionFactor), children: pickers)));
}



}


public class _CupertinoDatePickerDateState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Datepicker.CupertinoDatePicker>
{
    public _CupertinoDatePickerDateState()
    { }
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

    public new void InitState()
    {
        base.InitState();
        SelectedDay = Widget.InitialDateTime.Day;
        SelectedMonth = Widget.InitialDateTime.Month;
        SelectedYear = Widget.InitialDateTime.Year;
        DayController = new FixedExtentScrollController(initialItem: SelectedDay - 1);
        MonthController = new FixedExtentScrollController(initialItem: SelectedMonth - 1);
        YearController = new FixedExtentScrollController(initialItem: SelectedYear);
        BindingDefaultClass.PaintingBinding.Instance.SystemFonts.AddListener(_HandleSystemFontsChange);
    }




    private void _HandleSystemFontsChange()
    {
        SetState(() =>
        {
            _RefreshEstimatedColumnWidths();
        }
        );
    }




    public new void Dispose()
    {
        DayController.Dispose();
        MonthController.Dispose();
        YearController.Dispose();
        BindingDefaultClass.PaintingBinding.Instance.SystemFonts.RemoveListener(_HandleSystemFontsChange);
        base.Dispose();
    }




    public new void DidChangeDependencies()
    {
        base.DidChangeDependencies();
        TextDirectionFactor = BasicDefaultClass.Directionality.Of(Context) == TextDirection.Ltr ? 1 : -1;
        Localizations = LocalizationsDefaultClass.CupertinoLocalizations.Of(Context);
        AlignCenterLeft = TextDirectionFactor == 1 ? AlignmentDefaultClass.Alignment.CenterLeft : AlignmentDefaultClass.Alignment.CenterRight;
        AlignCenterRight = TextDirectionFactor == 1 ? AlignmentDefaultClass.Alignment.CenterRight : AlignmentDefaultClass.Alignment.CenterLeft;
        _RefreshEstimatedColumnWidths();
    }




    private void _RefreshEstimatedColumnWidths()
    {
        EstimatedColumnWidths[_PickerColumnType.DayOfMonth.Index] = DatepickerDefaultClass.CupertinoDatePicker._GetColumnWidth(_PickerColumnType.DayOfMonth, Localizations, Context);
        EstimatedColumnWidths[_PickerColumnType.Month.Index] = DatepickerDefaultClass.CupertinoDatePicker._GetColumnWidth(_PickerColumnType.Month, Localizations, Context);
        EstimatedColumnWidths[_PickerColumnType.Year.Index] = DatepickerDefaultClass.CupertinoDatePicker._GetColumnWidth(_PickerColumnType.Year, Localizations, Context);
    }




    private DateTime _LastDayInMonth(int year, int month) => new DateTime(year, month + 1, 0);



    private FlutterSDK.Widgets.Framework.Widget _BuildDayPicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder)
    {
        int daysInCurrentMonth = _LastDayInMonth(SelectedYear, SelectedMonth).Day;
        return new NotificationListener<ScrollNotification>(onNotification: (ScrollNotification notification) =>
        {
            if (notification is ScrollStartNotification)
            {
                IsDayPickerScrolling = true;
            }
            else if (notification is ScrollEndNotification)
            {
                IsDayPickerScrolling = false;
                _PickerDidStopScrolling();
            }

            return false;
        }
        , child: new CupertinoPicker(scrollController: DayController, offAxisFraction: offAxisFraction, itemExtent: DatepickerDefaultClass._KItemExtent, useMagnifier: DatepickerDefaultClass._KUseMagnifier, magnification: DatepickerDefaultClass._KMagnification, backgroundColor: Widget.BackgroundColor, squeeze: DatepickerDefaultClass._KSqueeze, onSelectedItemChanged: (int index) =>
        {
            SelectedDay = index + 1;
            if (_IsCurrentDateValid) Widget.OnDateTimeChanged(new DateTime(SelectedYear, SelectedMonth, SelectedDay));
        }
        , children: List<Widget>.Generate(31, (int index) =>
        {
            int day = index + 1;
            return itemPositioningBuilder(Context, new Text(Localizations.DatePickerDayOfMonth(day), style: DatepickerDefaultClass._ThemeTextStyle(Context, isValid: day <= daysInCurrentMonth)));
        }
        ), looping: true));
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildMonthPicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder)
    {
        return new NotificationListener<ScrollNotification>(onNotification: (ScrollNotification notification) =>
        {
            if (notification is ScrollStartNotification)
            {
                IsMonthPickerScrolling = true;
            }
            else if (notification is ScrollEndNotification)
            {
                IsMonthPickerScrolling = false;
                _PickerDidStopScrolling();
            }

            return false;
        }
        , child: new CupertinoPicker(scrollController: MonthController, offAxisFraction: offAxisFraction, itemExtent: DatepickerDefaultClass._KItemExtent, useMagnifier: DatepickerDefaultClass._KUseMagnifier, magnification: DatepickerDefaultClass._KMagnification, backgroundColor: Widget.BackgroundColor, squeeze: DatepickerDefaultClass._KSqueeze, onSelectedItemChanged: (int index) =>
        {
            SelectedMonth = index + 1;
            if (_IsCurrentDateValid) Widget.OnDateTimeChanged(new DateTime(SelectedYear, SelectedMonth, SelectedDay));
        }
        , children: List<Widget>.Generate(12, (int index) =>
        {
            int month = index + 1;
            bool isInvalidMonth = (Widget.MinimumDate?.Year == SelectedYear && Widget.MinimumDate.Month > month) || (Widget.MaximumDate?.Year == SelectedYear && Widget.MaximumDate.Month < month);
            return itemPositioningBuilder(Context, new Text(Localizations.DatePickerMonth(month), style: DatepickerDefaultClass._ThemeTextStyle(Context, isValid: !isInvalidMonth)));
        }
        ), looping: true));
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildYearPicker(double offAxisFraction, FlutterSDK.Widgets.Framework.TransitionBuilder itemPositioningBuilder)
    {
        return new NotificationListener<ScrollNotification>(onNotification: (ScrollNotification notification) =>
        {
            if (notification is ScrollStartNotification)
            {
                IsYearPickerScrolling = true;
            }
            else if (notification is ScrollEndNotification)
            {
                IsYearPickerScrolling = false;
                _PickerDidStopScrolling();
            }

            return false;
        }
        , child: CupertinoPicker.Builder(scrollController: YearController, itemExtent: DatepickerDefaultClass._KItemExtent, offAxisFraction: offAxisFraction, useMagnifier: DatepickerDefaultClass._KUseMagnifier, magnification: DatepickerDefaultClass._KMagnification, backgroundColor: Widget.BackgroundColor, onSelectedItemChanged: (int index) =>
        {
            SelectedYear = index;
            if (_IsCurrentDateValid) Widget.OnDateTimeChanged(new DateTime(SelectedYear, SelectedMonth, SelectedDay));
        }
        , itemBuilder: (BuildContext context, int year) =>
        {
            if (year < Widget.MinimumYear) return null;
            if (Widget.MaximumYear != null && year > Widget.MaximumYear) return null;
            bool isValidYear = (Widget.MinimumDate == null || Widget.MinimumDate.Year <= year) && (Widget.MaximumDate == null || Widget.MaximumDate.Year >= year);
            return itemPositioningBuilder(context, new Text(Localizations.DatePickerYear(year), style: DatepickerDefaultClass._ThemeTextStyle(context, isValid: isValidYear)));
        }
        ));
    }




    private void _PickerDidStopScrolling()
    {
        SetState(() =>
        {
        }
        );
        if (IsScrolling)
        {
            return;
        }

        DateTime minSelectDate = new DateTime(SelectedYear, SelectedMonth, SelectedDay);
        DateTime maxSelectDate = new DateTime(SelectedYear, SelectedMonth, SelectedDay + 1);
        bool minCheck = Widget.MinimumDate?.IsBefore(maxSelectDate) ?? true;
        bool maxCheck = Widget.MaximumDate?.IsBefore(minSelectDate) ?? false;
        if (!minCheck || maxCheck)
        {
            DateTime targetDate = minCheck ? Widget.MaximumDate : Widget.MinimumDate;
            _ScrollToDate(targetDate);
            return;
        }

        if (minSelectDate.Day != SelectedDay)
        {
            DateTime lastDay = _LastDayInMonth(SelectedYear, SelectedMonth);
            _ScrollToDate(lastDay);
        }

    }




    private void _ScrollToDate(DateTime newDate)
    {

        BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback((TimeSpan timestamp) =>
        {
            if (SelectedYear != newDate.Year)
            {
                DatepickerDefaultClass._AnimateColumnControllerToItem(YearController, newDate.Year);
            }

            if (SelectedMonth != newDate.Month)
            {
                DatepickerDefaultClass._AnimateColumnControllerToItem(MonthController, newDate.Month - 1);
            }

            if (SelectedDay != newDate.Day)
            {
                DatepickerDefaultClass._AnimateColumnControllerToItem(DayController, newDate.Day - 1);
            }

        }
        );
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        List<_ColumnBuilder> pickerBuilders = new List<_ColumnBuilder>() { };
        List<double> columnWidths = new List<double>() { };
        switch (Localizations.DatePickerDateOrder) { case DatePickerDateOrder.Mdy: pickerBuilders = new List<_ColumnBuilder>() { _BuildMonthPicker, _BuildDayPicker, _BuildYearPicker }; columnWidths = new List<double>() { EstimatedColumnWidths[_PickerColumnType.Month.Index], EstimatedColumnWidths[_PickerColumnType.DayOfMonth.Index], EstimatedColumnWidths[_PickerColumnType.Year.Index] }; break; case DatePickerDateOrder.Dmy: pickerBuilders = new List<_ColumnBuilder>() { _BuildDayPicker, _BuildMonthPicker, _BuildYearPicker }; columnWidths = new List<double>() { EstimatedColumnWidths[_PickerColumnType.DayOfMonth.Index], EstimatedColumnWidths[_PickerColumnType.Month.Index], EstimatedColumnWidths[_PickerColumnType.Year.Index] }; break; case DatePickerDateOrder.Ymd: pickerBuilders = new List<_ColumnBuilder>() { _BuildYearPicker, _BuildMonthPicker, _BuildDayPicker }; columnWidths = new List<double>() { EstimatedColumnWidths[_PickerColumnType.Year.Index], EstimatedColumnWidths[_PickerColumnType.Month.Index], EstimatedColumnWidths[_PickerColumnType.DayOfMonth.Index] }; break; case DatePickerDateOrder.Ydm: pickerBuilders = new List<_ColumnBuilder>() { _BuildYearPicker, _BuildDayPicker, _BuildMonthPicker }; columnWidths = new List<double>() { EstimatedColumnWidths[_PickerColumnType.Year.Index], EstimatedColumnWidths[_PickerColumnType.DayOfMonth.Index], EstimatedColumnWidths[_PickerColumnType.Month.Index] }; break; default: }
        List<Widget> pickers = new List<Widget>() { };
        for (int i = 0; i < columnWidths.Count; i++)
        {
            double offAxisFraction = (i - 1) * 0.3 * TextDirectionFactor;
            EdgeInsets padding = EdgeInsets.Only(right: DatepickerDefaultClass._KDatePickerPadSize);
            if (TextDirectionFactor == -1) padding = EdgeInsets.Only(left: DatepickerDefaultClass._KDatePickerPadSize);
            pickers.Add(new LayoutId(id: i, child: pickerBuilders[i](offAxisFraction, (BuildContext context, Widget child) =>
            {
                return new Container(alignment: i == columnWidths.Count - 1 ? AlignCenterLeft : AlignCenterRight, padding: i == 0 ? null : padding, child: new Container(alignment: i == 0 ? AlignCenterLeft : AlignCenterRight, width: columnWidths[i] + DatepickerDefaultClass._KDatePickerPadSize, child: child));
            }
            )));
        }

        return new MediaQuery(data: MediaqueryDefaultClass.MediaQuery.Of(context).CopyWith(textScaleFactor: 1.0), child: TextDefaultClass.DefaultTextStyle.Merge(style: DatepickerDefaultClass._KDefaultPickerTextStyle, child: new CustomMultiChildLayout(@delegate: new _DatePickerLayoutDelegate(columnWidths: columnWidths, textDirectionFactor: TextDirectionFactor), children: pickers)));
    }



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
    public CupertinoTimerPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Cupertino.Datepicker.CupertinoTimerPickerMode mode = default(FlutterSDK.Cupertino.Datepicker.CupertinoTimerPickerMode), TimeSpan initialTimerDuration = default(TimeSpan), int minuteInterval = 1, int secondInterval = 1, FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<TimeSpan> onTimerDurationChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<TimeSpan>))
    : base(key: key)
    {
        this.Mode = mode;
        this.InitialTimerDuration = initialTimerDuration;
        this.MinuteInterval = minuteInterval;
        this.SecondInterval = secondInterval;
        this.Alignment = alignment;
        this.BackgroundColor = backgroundColor;
        this.OnTimerDurationChanged = onTimerDurationChanged;
    }
    public virtual FlutterSDK.Cupertino.Datepicker.CupertinoTimerPickerMode Mode { get; set; }
    public virtual TimeSpan InitialTimerDuration { get; set; }
    public virtual int MinuteInterval { get; set; }
    public virtual int SecondInterval { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<TimeSpan> OnTimerDurationChanged { get; set; }
    public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
    public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }

    public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() => new _CupertinoTimerPickerState();


}


public class _CupertinoTimerPickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Datepicker.CupertinoTimerPicker>
{
    public _CupertinoTimerPickerState()
    { }
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

    public new void InitState()
    {
        base.InitState();
        SelectedMinute = Widget.InitialTimerDuration.InMinutes % 60;
        if (Widget.Mode != CupertinoTimerPickerMode.Ms) SelectedHour = Widget.InitialTimerDuration.InHours;
        if (Widget.Mode != CupertinoTimerPickerMode.Hm) SelectedSecond = Widget.InitialTimerDuration.InSeconds % 60;
        BindingDefaultClass.PaintingBinding.Instance.SystemFonts.AddListener(_HandleSystemFontsChange);
    }




    private void _HandleSystemFontsChange()
    {
        SetState(() =>
        {
            TextPainter.MarkNeedsLayout();
            _MeasureLabelMetrics();
        }
        );
    }




    public new void Dispose()
    {
        BindingDefaultClass.PaintingBinding.Instance.SystemFonts.RemoveListener(_HandleSystemFontsChange);
        base.Dispose();
    }




    public new void DidUpdateWidget(FlutterSDK.Cupertino.Datepicker.CupertinoTimerPicker oldWidget)
    {
        base.DidUpdateWidget(oldWidget);

    }




    public new void DidChangeDependencies()
    {
        base.DidChangeDependencies();
        TextDirection = BasicDefaultClass.Directionality.Of(Context);
        Localizations = LocalizationsDefaultClass.CupertinoLocalizations.Of(Context);
        _MeasureLabelMetrics();
    }




    private void _MeasureLabelMetrics()
    {
        TextPainter.TextDirection = TextDirection;
        TextStyle textStyle = _TextStyleFrom(Context);
        double maxWidth = Dart:coreDefaultClass.Double.NegativeInfinity;
        string widestNumber = default(string);
        foreach (string input in Numbers)
        {
            TextPainter.Text = new TextSpan(text: input, style: textStyle);
            TextPainter.Layout();
            if (TextPainter.MaxIntrinsicWidth > maxWidth)
            {
                maxWidth = TextPainter.MaxIntrinsicWidth;
                widestNumber = input;
            }

        }

        TextPainter.Text = new TextSpan(text: $"'{widestNumber}{widestNumber}'", style: textStyle);
        TextPainter.Layout();
        NumberLabelWidth = TextPainter.MaxIntrinsicWidth;
        NumberLabelHeight = TextPainter.Height;
        NumberLabelBaseline = TextPainter.ComputeDistanceToActualBaseline(TextBaseline.Alphabetic);
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildLabel(string text, FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional pickerPadding)
    {
        EdgeInsetsDirectional padding = EdgeInsetsDirectional.Only(start: NumberLabelWidth + DatepickerDefaultClass._KTimerPickerLabelPadSize + pickerPadding.Start);
        return new IgnorePointer(child: new Container(alignment: AlignmentDefaultClass.AlignmentDirectional.CenterStart.Resolve(TextDirection), padding: padding.Resolve(TextDirection), child: new SizedBox(height: NumberLabelHeight, child: new Baseline(baseline: NumberLabelBaseline, baselineType: TextBaseline.Alphabetic, child: new Text(text, style: new TextStyle(fontSize: DatepickerDefaultClass._KTimerPickerLabelFontSize, fontWeight: Dart:uiDefaultClass.FontWeight.W600), maxLines: 1, softWrap: false)))));
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildPickerNumberLabel(string text, FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding)
    {
        return new Container(width: DatepickerDefaultClass._KTimerPickerColumnIntrinsicWidth + padding.Horizontal, padding: padding.Resolve(TextDirection), alignment: AlignmentDefaultClass.AlignmentDirectional.CenterStart.Resolve(TextDirection), child: new Container(width: NumberLabelWidth, alignment: AlignmentDefaultClass.AlignmentDirectional.CenterEnd.Resolve(TextDirection), child: new Text(text, softWrap: false, maxLines: 1, overflow: TextOverflow.Visible)));
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildHourPicker(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding)
    {
        return new CupertinoPicker(scrollController: new FixedExtentScrollController(initialItem: SelectedHour), offAxisFraction: -0.5 * TextDirectionFactor, itemExtent: DatepickerDefaultClass._KItemExtent, backgroundColor: Widget.BackgroundColor, squeeze: DatepickerDefaultClass._KSqueeze, onSelectedItemChanged: (int index) =>
        {
            SetState(() =>
            {
                SelectedHour = index;
                Widget.OnTimerDurationChanged(new TimeSpan(hours: SelectedHour, minutes: SelectedMinute, seconds: SelectedSecond ?? 0));
            }
            );
        }
        , children: List<Widget>.Generate(24, (int index) =>
        {
            string semanticsLabel = TextDirectionFactor == 1 ? Localizations.TimerPickerHour(index) + Localizations.TimerPickerHourLabel(index) : Localizations.TimerPickerHourLabel(index) + Localizations.TimerPickerHour(index);
            return new Semantics(label: semanticsLabel, excludeSemantics: true, child: _BuildPickerNumberLabel(Localizations.TimerPickerHour(index), additionalPadding));
        }
        ));
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildHourColumn(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding)
    {
        return new Stack(children: new List<Widget>(){new NotificationListener<ScrollEndNotification>(onNotification:(ScrollEndNotification notification) => {
SetState(() => {
LastSelectedHour=SelectedHour;
}
);
return false ;
}
, child:_BuildHourPicker(additionalPadding)), _BuildLabel(Localizations.TimerPickerHourLabel(LastSelectedHour??SelectedHour), additionalPadding)});
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildMinutePicker(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding)
    {
        double offAxisFraction = default(double);
        switch (Widget.Mode) { case CupertinoTimerPickerMode.Hm: offAxisFraction = 0.5 * TextDirectionFactor; break; case CupertinoTimerPickerMode.Hms: offAxisFraction = 0.0; break; case CupertinoTimerPickerMode.Ms: offAxisFraction = -0.5 * TextDirectionFactor; }
        return new CupertinoPicker(scrollController: new FixedExtentScrollController(initialItem: SelectedMinute~/ Widget.MinuteInterval), offAxisFraction: offAxisFraction, itemExtent: DatepickerDefaultClass._KItemExtent, backgroundColor: Widget.BackgroundColor, squeeze: DatepickerDefaultClass._KSqueeze, looping: true, onSelectedItemChanged: (int index) =>
        {
            SetState(() =>
            {
                SelectedMinute = index * Widget.MinuteInterval;
                Widget.OnTimerDurationChanged(new TimeSpan(hours: SelectedHour ?? 0, minutes: SelectedMinute, seconds: SelectedSecond ?? 0));
            }
            );
        }
        , children: List<Widget>.Generate(60~/ Widget.MinuteInterval, (int index) =>
        {
            int minute = index * Widget.MinuteInterval;
            string semanticsLabel = TextDirectionFactor == 1 ? Localizations.TimerPickerMinute(minute) + Localizations.TimerPickerMinuteLabel(minute) : Localizations.TimerPickerMinuteLabel(minute) + Localizations.TimerPickerMinute(minute);
            return new Semantics(label: semanticsLabel, excludeSemantics: true, child: _BuildPickerNumberLabel(Localizations.TimerPickerMinute(minute), additionalPadding));
        }
        ));
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildMinuteColumn(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding)
    {
        return new Stack(children: new List<Widget>(){new NotificationListener<ScrollEndNotification>(onNotification:(ScrollEndNotification notification) => {
SetState(() => {
LastSelectedMinute=SelectedMinute;
}
);
return false ;
}
, child:_BuildMinutePicker(additionalPadding)), _BuildLabel(Localizations.TimerPickerMinuteLabel(LastSelectedMinute??SelectedMinute), additionalPadding)});
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildSecondPicker(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding)
    {
        double offAxisFraction = 0.5 * TextDirectionFactor;
        return new CupertinoPicker(scrollController: new FixedExtentScrollController(initialItem: SelectedSecond~/ Widget.SecondInterval), offAxisFraction: offAxisFraction, itemExtent: DatepickerDefaultClass._KItemExtent, backgroundColor: Widget.BackgroundColor, squeeze: DatepickerDefaultClass._KSqueeze, looping: true, onSelectedItemChanged: (int index) =>
        {
            SetState(() =>
            {
                SelectedSecond = index * Widget.SecondInterval;
                Widget.OnTimerDurationChanged(new TimeSpan(hours: SelectedHour ?? 0, minutes: SelectedMinute, seconds: SelectedSecond));
            }
            );
        }
        , children: List<Widget>.Generate(60~/ Widget.SecondInterval, (int index) =>
        {
            int second = index * Widget.SecondInterval;
            string semanticsLabel = TextDirectionFactor == 1 ? Localizations.TimerPickerSecond(second) + Localizations.TimerPickerSecondLabel(second) : Localizations.TimerPickerSecondLabel(second) + Localizations.TimerPickerSecond(second);
            return new Semantics(label: semanticsLabel, excludeSemantics: true, child: _BuildPickerNumberLabel(Localizations.TimerPickerSecond(second), additionalPadding));
        }
        ));
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildSecondColumn(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional additionalPadding)
    {
        return new Stack(children: new List<Widget>(){new NotificationListener<ScrollEndNotification>(onNotification:(ScrollEndNotification notification) => {
SetState(() => {
LastSelectedSecond=SelectedSecond;
}
);
return false ;
}
, child:_BuildSecondPicker(additionalPadding)), _BuildLabel(Localizations.TimerPickerSecondLabel(LastSelectedSecond??SelectedSecond), additionalPadding)});
    }




    private FlutterSDK.Painting.Textstyle.TextStyle _TextStyleFrom(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        return ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.PickerTextStyle.Merge(new TextStyle(fontSize: DatepickerDefaultClass._KTimerPickerNumberLabelFontSize));
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        List<Widget> columns = default(List<Widget>);
        double paddingValue = DatepickerDefaultClass._KPickerWidth - 2 * DatepickerDefaultClass._KTimerPickerColumnIntrinsicWidth - 2 * DatepickerDefaultClass._KTimerPickerHalfColumnPadding;
        double totalWidth = DatepickerDefaultClass._KPickerWidth;

        switch (Widget.Mode) { case CupertinoTimerPickerMode.Hm: columns = new List<Widget>() { _BuildHourColumn(EdgeInsetsDirectional.Only(start: paddingValue / 2, end: DatepickerDefaultClass._KTimerPickerHalfColumnPadding)), _BuildMinuteColumn(EdgeInsetsDirectional.Only(start: DatepickerDefaultClass._KTimerPickerHalfColumnPadding, end: paddingValue / 2)) }; break; case CupertinoTimerPickerMode.Ms: columns = new List<Widget>() { _BuildMinuteColumn(EdgeInsetsDirectional.Only(start: paddingValue / 2, end: DatepickerDefaultClass._KTimerPickerHalfColumnPadding)), _BuildSecondColumn(EdgeInsetsDirectional.Only(start: DatepickerDefaultClass._KTimerPickerHalfColumnPadding, end: paddingValue / 2)) }; break; case CupertinoTimerPickerMode.Hms: double paddingValue = DatepickerDefaultClass._KTimerPickerHalfColumnPadding * 2; totalWidth = DatepickerDefaultClass._KTimerPickerColumnIntrinsicWidth * 3 + 4 * DatepickerDefaultClass._KTimerPickerHalfColumnPadding + paddingValue; columns = new List<Widget>() { _BuildHourColumn(EdgeInsetsDirectional.Only(start: paddingValue / 2, end: DatepickerDefaultClass._KTimerPickerHalfColumnPadding)), _BuildMinuteColumn(EdgeInsetsDirectional.Only(start: DatepickerDefaultClass._KTimerPickerHalfColumnPadding, end: DatepickerDefaultClass._KTimerPickerHalfColumnPadding)), _BuildSecondColumn(EdgeInsetsDirectional.Only(start: DatepickerDefaultClass._KTimerPickerHalfColumnPadding, end: paddingValue / 2)) }; break; }
        CupertinoThemeData themeData = ThemeDefaultClass.CupertinoTheme.Of(context);
        return new MediaQuery(data: MediaqueryDefaultClass.MediaQuery.Of(context).CopyWith(textScaleFactor: 1.0), child: new CupertinoTheme(data: themeData.CopyWith(textTheme: themeData.TextTheme.CopyWith(pickerTextStyle: _TextStyleFrom(context))), child: new Align(alignment: Widget.Alignment, child: new Container(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.BackgroundColor, context), width: totalWidth, height: DatepickerDefaultClass._KPickerHeight, child: new DefaultTextStyle(style: _TextStyleFrom(context), child: new Row(children: columns.Map((Widget child) => =>new Expanded(child: child)).ToList(growable: false)))))));
    }



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
