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
namespace FlutterSDK.Material.Pickers.Calendardatepicker{
internal static class CalendardatepickerDefaultClass{
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

public class CalendarDatePicker : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public CalendarDatePicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),DateTime initialDate = default(DateTime),DateTime firstDate = default(DateTime),DateTime lastDate = default(DateTime),FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onDateChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>),FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onDisplayedMonthChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>),FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode initialCalendarMode = default(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode),FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate))
: base(key:key)
{
this.OnDateChanged = onDateChanged;
this.OnDisplayedMonthChanged = onDisplayedMonthChanged;
this.InitialCalendarMode = initialCalendarMode;
this.SelectableDayPredicate = selectableDayPredicate;throw new NotImplementedException(); }
#endregion

#region fields
public virtual DateTime InitialDate{get;set;}
public virtual DateTime FirstDate{get;set;}
public virtual DateTime LastDate{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnDateChanged{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnDisplayedMonthChanged{get;set;}
public virtual FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode InitialCalendarMode{get;set;}
public virtual FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate SelectableDayPredicate{get;set;}
#endregion

#region methods

public new FlutterSDK.Material.Pickers.Calendardatepicker._CalendarDatePickerState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _CalendarDatePickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Calendardatepicker.CalendarDatePicker>
{
#region constructors
public _CalendarDatePickerState()
{ }
#endregion

#region fields
internal virtual bool _AnnouncedInitialDate{get;set;}
internal virtual FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode _Mode{get;set;}
internal virtual DateTime _CurrentDisplayedMonthDate{get;set;}
internal virtual DateTime _SelectedDate{get;set;}
internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _MonthPickerKey{get;set;}
internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _YearPickerKey{get;set;}
internal virtual FlutterSDK.Material.Materiallocalizations.MaterialLocalizations _Localizations{get;set;}
internal virtual TextDirection _TextDirection{get;set;}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


public new void DidChangeDependencies(){ throw new NotImplementedException(); }


private void _Vibrate(){ throw new NotImplementedException(); }


private void _HandleModeChanged(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode mode){ throw new NotImplementedException(); }


private void _HandleMonthChanged(DateTime date){ throw new NotImplementedException(); }


private void _HandleYearChanged(DateTime value){ throw new NotImplementedException(); }


private void _HandleDayChanged(DateTime value){ throw new NotImplementedException(); }


private FlutterSDK.Widgets.Framework.Widget _BuildPicker(){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _DatePickerModeToggleButton : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public _DatePickerModeToggleButton(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode mode = default(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode),string title = default(string),VoidCallback onTitlePressed = default(VoidCallback))
{
this.Mode = mode;
this.Title = title;
this.OnTitlePressed = onTitlePressed;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode Mode{get;set;}
public virtual string Title{get;set;}
public virtual VoidCallback OnTitlePressed{get;set;}
#endregion

#region methods

public new FlutterSDK.Material.Pickers.Calendardatepicker._DatePickerModeToggleButtonState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _DatePickerModeToggleButtonState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Calendardatepicker._DatePickerModeToggleButton>,ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
#region constructors
public _DatePickerModeToggleButtonState()
{ }
#endregion

#region fields
internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller{get;set;}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


public new void DidUpdateWidget(FlutterSDK.Material.Pickers.Calendardatepicker._DatePickerModeToggleButton oldWidget){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }

#endregion
}


public class _MonthPicker : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public _MonthPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),DateTime initialMonth = default(DateTime),DateTime currentDate = default(DateTime),DateTime firstDate = default(DateTime),DateTime lastDate = default(DateTime),DateTime selectedDate = default(DateTime),FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>),FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onDisplayedMonthChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>),FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate))
: base(key:key)
{
this.InitialMonth = initialMonth;
this.CurrentDate = currentDate;
this.FirstDate = firstDate;
this.LastDate = lastDate;
this.SelectedDate = selectedDate;
this.OnChanged = onChanged;
this.OnDisplayedMonthChanged = onDisplayedMonthChanged;
this.SelectableDayPredicate = selectableDayPredicate;throw new NotImplementedException(); }
#endregion

#region fields
public virtual DateTime InitialMonth{get;set;}
public virtual DateTime CurrentDate{get;set;}
public virtual DateTime FirstDate{get;set;}
public virtual DateTime LastDate{get;set;}
public virtual DateTime SelectedDate{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnChanged{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnDisplayedMonthChanged{get;set;}
public virtual FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate SelectableDayPredicate{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _MonthPickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Calendardatepicker._MonthPicker>
{
#region constructors
public _MonthPickerState()
{ }
#endregion

#region fields
internal virtual DateTime _CurrentMonth{get;set;}
internal virtual DateTime _NextMonthDate{get;set;}
internal virtual DateTime _PreviousMonthDate{get;set;}
internal virtual FlutterSDK.Widgets.Pageview.PageController _PageController{get;set;}
internal virtual FlutterSDK.Material.Materiallocalizations.MaterialLocalizations _Localizations{get;set;}
internal virtual TextDirection _TextDirection{get;set;}
internal virtual bool _IsDisplayingFirstMonth{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual bool _IsDisplayingLastMonth{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


public new void DidChangeDependencies(){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }


private void _HandleMonthPageChanged(int monthPage){ throw new NotImplementedException(); }


private void _HandleNextMonth(){ throw new NotImplementedException(); }


private void _HandlePreviousMonth(){ throw new NotImplementedException(); }


private FlutterSDK.Widgets.Framework.Widget _BuildItems(FlutterSDK.Widgets.Framework.BuildContext context,int index){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _DayPicker : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _DayPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),DateTime currentDate = default(DateTime),DateTime displayedMonth = default(DateTime),DateTime firstDate = default(DateTime),DateTime lastDate = default(DateTime),DateTime selectedDate = default(DateTime),FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>),FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate))
: base(key:key)
{
this.CurrentDate = currentDate;
this.DisplayedMonth = displayedMonth;
this.FirstDate = firstDate;
this.LastDate = lastDate;
this.SelectedDate = selectedDate;
this.OnChanged = onChanged;
this.SelectableDayPredicate = selectableDayPredicate;throw new NotImplementedException(); }
#endregion

#region fields
public virtual DateTime SelectedDate{get;set;}
public virtual DateTime CurrentDate{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnChanged{get;set;}
public virtual DateTime FirstDate{get;set;}
public virtual DateTime LastDate{get;set;}
public virtual DateTime DisplayedMonth{get;set;}
public virtual FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate SelectableDayPredicate{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _DayPickerGridDelegate : FlutterSDK.Rendering.Slivergrid.SliverGridDelegate
{
#region constructors
public _DayPickerGridDelegate()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Rendering.Slivergrid.SliverGridLayout GetLayout(FlutterSDK.Rendering.Sliver.SliverConstraints constraints){ throw new NotImplementedException(); }


public new bool ShouldRelayout(FlutterSDK.Material.Pickers.Calendardatepicker._DayPickerGridDelegate oldDelegate){ throw new NotImplementedException(); }
public new bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate oldDelegate){ throw new NotImplementedException(); }

#endregion
}


public class _DayHeaders : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _DayHeaders()
{ }
#endregion

#region fields
#endregion

#region methods

private List<FlutterSDK.Widgets.Framework.Widget> _GetDayHeaders(FlutterSDK.Painting.Textstyle.TextStyle headerStyle,FlutterSDK.Material.Materiallocalizations.MaterialLocalizations localizations){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _YearPicker : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public _YearPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),DateTime currentDate = default(DateTime),DateTime firstDate = default(DateTime),DateTime lastDate = default(DateTime),DateTime initialDate = default(DateTime),DateTime selectedDate = default(DateTime),FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>))
: base(key:key)
{
this.CurrentDate = currentDate;
this.FirstDate = firstDate;
this.LastDate = lastDate;
this.InitialDate = initialDate;
this.SelectedDate = selectedDate;
this.OnChanged = onChanged;throw new NotImplementedException(); }
#endregion

#region fields
public virtual DateTime CurrentDate{get;set;}
public virtual DateTime FirstDate{get;set;}
public virtual DateTime LastDate{get;set;}
public virtual DateTime InitialDate{get;set;}
public virtual DateTime SelectedDate{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnChanged{get;set;}
#endregion

#region methods

public new FlutterSDK.Material.Pickers.Calendardatepicker._YearPickerState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _YearPickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Calendardatepicker._YearPicker>
{
#region constructors
public _YearPickerState()
{ }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController{get;set;}
public virtual int MinYears{get;set;}
internal virtual int _ItemCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


private FlutterSDK.Widgets.Framework.Widget _BuildYearItem(FlutterSDK.Widgets.Framework.BuildContext context,int index){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _YearPickerGridDelegate : FlutterSDK.Rendering.Slivergrid.SliverGridDelegate
{
#region constructors
public _YearPickerGridDelegate()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Rendering.Slivergrid.SliverGridLayout GetLayout(FlutterSDK.Rendering.Sliver.SliverConstraints constraints){ throw new NotImplementedException(); }


public new bool ShouldRelayout(FlutterSDK.Material.Pickers.Calendardatepicker._YearPickerGridDelegate oldDelegate){ throw new NotImplementedException(); }
public new bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate oldDelegate){ throw new NotImplementedException(); }

#endregion
}

}
