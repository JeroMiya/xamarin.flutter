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
namespace FlutterSDK.Cupertino.Localizations
{
    internal static class LocalizationsDefaultClass
    {
    }

    public interface ICupertinoLocalizations { }

    public class CupertinoLocalizations
    {
        public virtual FlutterSDK.Cupertino.Localizations.DatePickerDateOrder DatePickerDateOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Cupertino.Localizations.DatePickerDateTimeOrder DatePickerDateTimeOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string AnteMeridiemAbbreviation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PostMeridiemAbbreviation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string TodayLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string AlertDialogLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CutButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CopyButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PasteButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string SelectAllButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Year that is shown in [CupertinoDatePicker] spinner corresponding to the
        /// given year index.
        ///
        /// Examples: datePickerYear(1) in:
        ///
        ///  - US English: 2018
        ///  - Korean: 2018년
        /// </Summary>
        public virtual string DatePickerYear(int yearIndex)
        {
            return default(string);
        }


        /// <Summary>
        /// Month that is shown in [CupertinoDatePicker] spinner corresponding to
        /// the given month index.
        ///
        /// Examples: datePickerMonth(1) in:
        ///
        ///  - US English: January
        ///  - Korean: 1월
        /// </Summary>
        public virtual string DatePickerMonth(int monthIndex)
        {
            return default(string);
        }


        /// <Summary>
        /// Day of month that is shown in [CupertinoDatePicker] spinner corresponding
        /// to the given day index.
        ///
        /// Examples: datePickerDayOfMonth(1) in:
        ///
        ///  - US English: 1
        ///  - Korean: 1일
        /// </Summary>
        public virtual string DatePickerDayOfMonth(int dayIndex)
        {
            return default(string);
        }


        /// <Summary>
        /// The medium-width date format that is shown in [CupertinoDatePicker]
        /// spinner. Abbreviates month and days of week.
        ///
        /// Examples:
        ///
        /// - US English: Wed Sep 27
        /// - Russian: ср сент. 27
        /// </Summary>
        public virtual string DatePickerMediumDate(DateTime date)
        {
            return default(string);
        }


        /// <Summary>
        /// Hour that is shown in [CupertinoDatePicker] spinner corresponding
        /// to the given hour value.
        ///
        /// Examples: datePickerHour(1) in:
        ///
        ///  - US English: 1
        ///  - Arabic: ٠١
        /// </Summary>
        public virtual string DatePickerHour(int hour)
        {
            return default(string);
        }


        /// <Summary>
        /// Semantics label for the given hour value in [CupertinoDatePicker].
        /// </Summary>
        public virtual string DatePickerHourSemanticsLabel(int hour)
        {
            return default(string);
        }


        /// <Summary>
        /// Minute that is shown in [CupertinoDatePicker] spinner corresponding
        /// to the given minute value.
        ///
        /// Examples: datePickerMinute(1) in:
        ///
        ///  - US English: 01
        ///  - Arabic: ٠١
        /// </Summary>
        public virtual string DatePickerMinute(int minute)
        {
            return default(string);
        }


        /// <Summary>
        /// Semantics label for the given minute value in [CupertinoDatePicker].
        /// </Summary>
        public virtual string DatePickerMinuteSemanticsLabel(int minute)
        {
            return default(string);
        }


        /// <Summary>
        /// Hour that is shown in [CupertinoTimerPicker] corresponding to
        /// the given hour value.
        ///
        /// Examples: timerPickerHour(1) in:
        ///
        ///  - US English: 1
        ///  - Arabic: ١
        /// </Summary>
        public virtual string TimerPickerHour(int hour)
        {
            return default(string);
        }


        /// <Summary>
        /// Minute that is shown in [CupertinoTimerPicker] corresponding to
        /// the given minute value.
        ///
        /// Examples: timerPickerMinute(1) in:
        ///
        ///  - US English: 1
        ///  - Arabic: ١
        /// </Summary>
        public virtual string TimerPickerMinute(int minute)
        {
            return default(string);
        }


        /// <Summary>
        /// Second that is shown in [CupertinoTimerPicker] corresponding to
        /// the given second value.
        ///
        /// Examples: timerPickerSecond(1) in:
        ///
        ///  - US English: 1
        ///  - Arabic: ١
        /// </Summary>
        public virtual string TimerPickerSecond(int second)
        {
            return default(string);
        }


        /// <Summary>
        /// Label that appears next to the hour picker in
        /// [CupertinoTimerPicker] when selected hour value is `hour`.
        /// This function will deal with pluralization based on the `hour` parameter.
        /// </Summary>
        public virtual string TimerPickerHourLabel(int hour)
        {
            return default(string);
        }


        /// <Summary>
        /// Label that appears next to the minute picker in
        /// [CupertinoTimerPicker] when selected minute value is `minute`.
        /// This function will deal with pluralization based on the `minute` parameter.
        /// </Summary>
        public virtual string TimerPickerMinuteLabel(int minute)
        {
            return default(string);
        }


        /// <Summary>
        /// Label that appears next to the minute picker in
        /// [CupertinoTimerPicker] when selected minute value is `second`.
        /// This function will deal with pluralization based on the `second` parameter.
        /// </Summary>
        public virtual string TimerPickerSecondLabel(int second)
        {
            return default(string);
        }


        /// <Summary>
        /// The `CupertinoLocalizations` from the closest [Localizations] instance
        /// that encloses the given context.
        ///
        /// This method is just a convenient shorthand for:
        /// `Localizations.of<CupertinoLocalizations>(context, CupertinoLocalizations)`.
        ///
        /// References to the localized resources defined by this class are typically
        /// written in terms of this method. For example:
        ///
        /// ```dart
        /// CupertinoLocalizations.of(context).anteMeridiemAbbreviation;
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Localizations.CupertinoLocalizations Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return LocalizationsDefaultClass.Localizations.Of(context, LocalizationsDefaultClass.CupertinoLocalizations);
        }



    }
    public static class CupertinoLocalizationsMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<ICupertinoLocalizations, CupertinoLocalizations> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ICupertinoLocalizations, CupertinoLocalizations>();
        static CupertinoLocalizations GetOrCreate(ICupertinoLocalizations instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new CupertinoLocalizations();
                _table.Add(instance, value);
            }
            return (CupertinoLocalizations)value;
        }
        public static FlutterSDK.Cupertino.Localizations.DatePickerDateOrder DatePickerDateOrderProperty(this ICupertinoLocalizations instance) => GetOrCreate(instance).DatePickerDateOrder;
        public static FlutterSDK.Cupertino.Localizations.DatePickerDateTimeOrder DatePickerDateTimeOrderProperty(this ICupertinoLocalizations instance) => GetOrCreate(instance).DatePickerDateTimeOrder;
        public static string AnteMeridiemAbbreviationProperty(this ICupertinoLocalizations instance) => GetOrCreate(instance).AnteMeridiemAbbreviation;
        public static string PostMeridiemAbbreviationProperty(this ICupertinoLocalizations instance) => GetOrCreate(instance).PostMeridiemAbbreviation;
        public static string TodayLabelProperty(this ICupertinoLocalizations instance) => GetOrCreate(instance).TodayLabel;
        public static string AlertDialogLabelProperty(this ICupertinoLocalizations instance) => GetOrCreate(instance).AlertDialogLabel;
        public static string CutButtonLabelProperty(this ICupertinoLocalizations instance) => GetOrCreate(instance).CutButtonLabel;
        public static string CopyButtonLabelProperty(this ICupertinoLocalizations instance) => GetOrCreate(instance).CopyButtonLabel;
        public static string PasteButtonLabelProperty(this ICupertinoLocalizations instance) => GetOrCreate(instance).PasteButtonLabel;
        public static string SelectAllButtonLabelProperty(this ICupertinoLocalizations instance) => GetOrCreate(instance).SelectAllButtonLabel;
        public static string DatePickerYear(this ICupertinoLocalizations instance, int yearIndex) => GetOrCreate(instance).DatePickerYear(yearIndex);
        public static string DatePickerMonth(this ICupertinoLocalizations instance, int monthIndex) => GetOrCreate(instance).DatePickerMonth(monthIndex);
        public static string DatePickerDayOfMonth(this ICupertinoLocalizations instance, int dayIndex) => GetOrCreate(instance).DatePickerDayOfMonth(dayIndex);
        public static string DatePickerMediumDate(this ICupertinoLocalizations instance, DateTime date) => GetOrCreate(instance).DatePickerMediumDate(date);
        public static string DatePickerHour(this ICupertinoLocalizations instance, int hour) => GetOrCreate(instance).DatePickerHour(hour);
        public static string DatePickerHourSemanticsLabel(this ICupertinoLocalizations instance, int hour) => GetOrCreate(instance).DatePickerHourSemanticsLabel(hour);
        public static string DatePickerMinute(this ICupertinoLocalizations instance, int minute) => GetOrCreate(instance).DatePickerMinute(minute);
        public static string DatePickerMinuteSemanticsLabel(this ICupertinoLocalizations instance, int minute) => GetOrCreate(instance).DatePickerMinuteSemanticsLabel(minute);
        public static string TimerPickerHour(this ICupertinoLocalizations instance, int hour) => GetOrCreate(instance).TimerPickerHour(hour);
        public static string TimerPickerMinute(this ICupertinoLocalizations instance, int minute) => GetOrCreate(instance).TimerPickerMinute(minute);
        public static string TimerPickerSecond(this ICupertinoLocalizations instance, int second) => GetOrCreate(instance).TimerPickerSecond(second);
        public static string TimerPickerHourLabel(this ICupertinoLocalizations instance, int hour) => GetOrCreate(instance).TimerPickerHourLabel(hour);
        public static string TimerPickerMinuteLabel(this ICupertinoLocalizations instance, int minute) => GetOrCreate(instance).TimerPickerMinuteLabel(minute);
        public static string TimerPickerSecondLabel(this ICupertinoLocalizations instance, int second) => GetOrCreate(instance).TimerPickerSecondLabel(second);
        public static FlutterSDK.Cupertino.Localizations.CupertinoLocalizations Of(this ICupertinoLocalizations instance, FlutterSDK.Widgets.Framework.BuildContext context) => GetOrCreate(instance).Of(context);
    }


    public class _CupertinoLocalizationsDelegate : FlutterSDK.Widgets.Localizations.LocalizationsDelegate<FlutterSDK.Cupertino.Localizations.CupertinoLocalizations>
    {
        #region constructors
        public _CupertinoLocalizationsDelegate()
    
}
    #endregion

    #region fields
    #endregion

    #region methods

    public new bool IsSupported(Locale locale) => locale.LanguageCode == "en";



    public new Future<FlutterSDK.Cupertino.Localizations.CupertinoLocalizations> Load(Locale locale) => LocalizationsDefaultClass.DefaultCupertinoLocalizations.Load(locale);



    public new bool ShouldReload(FlutterSDK.Cupertino.Localizations._CupertinoLocalizationsDelegate old) => false;



    #endregion
}


/// <Summary>
/// US English strings for the cupertino widgets.
/// </Summary>
public class DefaultCupertinoLocalizations : ICupertinoLocalizations
{
    #region constructors
    public DefaultCupertinoLocalizations()

}
#endregion

#region fields
internal virtual List<string> _ShortWeekdays { get; set; }
internal virtual List<string> _ShortMonths { get; set; }
internal virtual List<string> _Months { get; set; }
public virtual FlutterSDK.Widgets.Localizations.LocalizationsDelegate<FlutterSDK.Cupertino.Localizations.CupertinoLocalizations> @delegate { get; set; }
public virtual FlutterSDK.Cupertino.Localizations.DatePickerDateOrder DatePickerDateOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Cupertino.Localizations.DatePickerDateTimeOrder DatePickerDateTimeOrder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string AnteMeridiemAbbreviation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string PostMeridiemAbbreviation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string TodayLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string AlertDialogLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string CutButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string CopyButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string PasteButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual string SelectAllButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new string DatePickerYear(int yearIndex) => yearIndex.ToString();



public new string DatePickerMonth(int monthIndex) => _Months[monthIndex - 1];



public new string DatePickerDayOfMonth(int dayIndex) => dayIndex.ToString();



public new string DatePickerHour(int hour) => hour.ToString();



public new string DatePickerHourSemanticsLabel(int hour) => hour.ToString() + " o'clock";



public new string DatePickerMinute(int minute) => minute.ToString().PadLeft(2, '0');



public new string DatePickerMinuteSemanticsLabel(int minute)
{
    if (minute == 1) return "1 minute";
    return minute.ToString() + " minutes";
}




public new string DatePickerMediumDate(DateTime date)
{
    return $"'{_ShortWeekdays[date.Weekday - Dart:coreDefaultClass.DateTime.Monday]} '" + $"'{_ShortMonths[date.Month - Dart:coreDefaultClass.DateTime.January]} '" + $"'{date.Day.ToString().PadRight(2)}'";
}




public new string TimerPickerHour(int hour) => hour.ToString();



public new string TimerPickerMinute(int minute) => minute.ToString();



public new string TimerPickerSecond(int second) => second.ToString();



public new string TimerPickerHourLabel(int hour) => hour == 1 ? "hour" : "hours";



public new string TimerPickerMinuteLabel(int minute) => "min.";



public new string TimerPickerSecondLabel(int second) => "sec.";



/// <Summary>
/// Creates an object that provides US English resource values for the
/// cupertino library widgets.
///
/// The [locale] parameter is ignored.
///
/// This method is typically used to create a [LocalizationsDelegate].
/// </Summary>
public virtual Future<FlutterSDK.Cupertino.Localizations.CupertinoLocalizations> Load(Locale locale)
{
    return new SynchronousFuture<CupertinoLocalizations>(new DefaultCupertinoLocalizations());
}



#endregion
}


/// <Summary>
/// Determines the order of the columns inside [CupertinoDatePicker] in
/// time and date time mode.
/// </Summary>
public enum DatePickerDateTimeOrder
{

    /// <Summary>
    /// Order of the columns, from left to right: date, hour, minute, am/pm.
    ///
    /// Example: Fri Aug 31 | 02 | 08 | PM.
    /// </Summary>
    Date_time_dayPeriod,
    /// <Summary>
    /// Order of the columns, from left to right: date, am/pm, hour, minute.
    ///
    /// Example: Fri Aug 31 | PM | 02 | 08.
    /// </Summary>
    Date_dayPeriod_time,
    /// <Summary>
    /// Order of the columns, from left to right: hour, minute, am/pm, date.
    ///
    /// Example: 02 | 08 | PM | Fri Aug 31.
    /// </Summary>
    Time_dayPeriod_date,
    /// <Summary>
    /// Order of the columns, from left to right: am/pm, hour, minute, date.
    ///
    /// Example: PM | 02 | 08 | Fri Aug 31.
    /// </Summary>
    DayPeriod_time_date,
}


/// <Summary>
/// Determines the order of the columns inside [CupertinoDatePicker] in date mode.
/// </Summary>
public enum DatePickerDateOrder
{

    /// <Summary>
    /// Order of the columns, from left to right: day, month, year.
    ///
    /// Example: 12 | March | 1996
    /// </Summary>
    Dmy,
    /// <Summary>
    /// Order of the columns, from left to right: month, day, year.
    ///
    /// Example: March | 12 | 1996
    /// </Summary>
    Mdy,
    /// <Summary>
    /// Order of the columns, from left to right: year, month, day.
    ///
    /// Example: 1996 | March | 12
    /// </Summary>
    Ymd,
    /// <Summary>
    /// Order of the columns, from left to right: year, day, month.
    ///
    /// Example: 1996 | 12 | March
    /// </Summary>
    Ydm,
}

}
