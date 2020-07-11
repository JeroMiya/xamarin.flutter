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
namespace FlutterSDK.Material.Timepicker{
internal static class TimepickerDefaultClass{
public static TimeSpan _KDialAnimateDuration = default(TimeSpan);
public static double _KTwoPi = default(double);
public static TimeSpan _KVibrateCommitDelay = default(TimeSpan);
public static double _KTimePickerHeaderPortraitHeight = default(double);
public static double _KTimePickerHeaderLandscapeWidth = default(double);
public static double _KTimePickerWidthPortrait = default(double);
public static double _KTimePickerWidthLandscape = default(double);
public static double _KTimePickerHeightPortrait = default(double);
public static double _KTimePickerHeightLandscape = default(double);
public static double _KTimePickerHeightPortraitCollapsed = default(double);
public static double _KTimePickerHeightLandscapeCollapsed = default(double);
public static FlutterSDK.Rendering.Box.BoxConstraints _KMinTappableRegion = default(FlutterSDK.Rendering.Box.BoxConstraints);
internal static FlutterSDK.Material.Timepicker._TimePickerHeaderFormat _BuildHeaderFormat(FlutterSDK.Material.Time.TimeOfDayFormat timeOfDayFormat,FlutterSDK.Material.Timepicker._TimePickerFragmentContext context,FlutterSDK.Widgets.Mediaquery.Orientation orientation){
throw new NotImplementedException();
}

internal static Future<FlutterSDK.Material.Time.TimeOfDay> ShowTimePicker(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext),FlutterSDK.Material.Time.TimeOfDay initialTime = default(FlutterSDK.Material.Time.TimeOfDay),FlutterSDK.Widgets.Framework.TransitionBuilder builder = default(FlutterSDK.Widgets.Framework.TransitionBuilder),bool useRootNavigator = true,FlutterSDK.Widgets.Navigator.RouteSettings routeSettings = default(FlutterSDK.Widgets.Navigator.RouteSettings)){
throw new NotImplementedException();
}

internal static void _AnnounceToAccessibility(FlutterSDK.Widgets.Framework.BuildContext context,string message){
throw new NotImplementedException();
}

}

public class _TimePickerFragmentContext
{
#region constructors
public _TimePickerFragmentContext(FlutterSDK.Material.Texttheme.TextTheme headerTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme),TextDirection textDirection = default(TextDirection),FlutterSDK.Material.Time.TimeOfDay selectedTime = default(FlutterSDK.Material.Time.TimeOfDay),FlutterSDK.Material.Timepicker._TimePickerMode mode = default(FlutterSDK.Material.Timepicker._TimePickerMode),FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color),FlutterSDK.Painting.Textstyle.TextStyle activeStyle = default(FlutterSDK.Painting.Textstyle.TextStyle),FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color),FlutterSDK.Painting.Textstyle.TextStyle inactiveStyle = default(FlutterSDK.Painting.Textstyle.TextStyle),FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> onTimeChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay>),FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode> onModeChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode>),FlutterSDK.Foundation.Platform.TargetPlatform targetPlatform = default(FlutterSDK.Foundation.Platform.TargetPlatform),bool use24HourDials = default(bool))
: base()
{
this.HeaderTextTheme = headerTextTheme;
this.TextDirection = textDirection;
this.SelectedTime = selectedTime;
this.Mode = mode;
this.ActiveColor = activeColor;
this.ActiveStyle = activeStyle;
this.InactiveColor = inactiveColor;
this.InactiveStyle = inactiveStyle;
this.OnTimeChange = onTimeChange;
this.OnModeChange = onModeChange;
this.TargetPlatform = targetPlatform;
this.Use24HourDials = use24HourDials;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Texttheme.TextTheme HeaderTextTheme{get;set;}
public virtual TextDirection TextDirection{get;set;}
public virtual FlutterSDK.Material.Time.TimeOfDay SelectedTime{get;set;}
public virtual FlutterSDK.Material.Timepicker._TimePickerMode Mode{get;set;}
public virtual FlutterBinding.UI.Color ActiveColor{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle ActiveStyle{get;set;}
public virtual FlutterBinding.UI.Color InactiveColor{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle InactiveStyle{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> OnTimeChange{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode> OnModeChange{get;set;}
public virtual FlutterSDK.Foundation.Platform.TargetPlatform TargetPlatform{get;set;}
public virtual bool Use24HourDials{get;set;}
#endregion

#region methods
#endregion
}


public class _TimePickerHeaderFragment
{
#region constructors
public _TimePickerHeaderFragment(FlutterSDK.Material.Timepicker._TimePickerHeaderId layoutId = default(FlutterSDK.Material.Timepicker._TimePickerHeaderId),FlutterSDK.Widgets.Framework.Widget widget = default(FlutterSDK.Widgets.Framework.Widget),double startMargin = 0.0)
: base()
{
this.LayoutId = layoutId;
this.Widget = widget;
this.StartMargin = startMargin;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Timepicker._TimePickerHeaderId LayoutId{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Widget{get;set;}
public virtual double StartMargin{get;set;}
#endregion

#region methods
#endregion
}


public class _TimePickerHeaderPiece
{
#region constructors
public _TimePickerHeaderPiece(int pivotIndex,List<FlutterSDK.Material.Timepicker._TimePickerHeaderFragment> fragments,double bottomMargin = 0.0)
: base()
{
this.PivotIndex = pivotIndex;
this.Fragments = fragments;
this.BottomMargin = bottomMargin;throw new NotImplementedException(); }
#endregion

#region fields
public virtual int PivotIndex{get;set;}
public virtual List<FlutterSDK.Material.Timepicker._TimePickerHeaderFragment> Fragments{get;set;}
public virtual double BottomMargin{get;set;}
#endregion

#region methods
#endregion
}


public class _TimePickerHeaderFormat
{
#region constructors
public _TimePickerHeaderFormat(int centerpieceIndex,List<FlutterSDK.Material.Timepicker._TimePickerHeaderPiece> pieces)
: base()
{
this.CenterpieceIndex = centerpieceIndex;
this.Pieces = pieces;throw new NotImplementedException(); }
#endregion

#region fields
public virtual int CenterpieceIndex{get;set;}
public virtual List<FlutterSDK.Material.Timepicker._TimePickerHeaderPiece> Pieces{get;set;}
#endregion

#region methods
#endregion
}


public class _DayPeriodControl : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _DayPeriodControl(FlutterSDK.Material.Timepicker._TimePickerFragmentContext fragmentContext = default(FlutterSDK.Material.Timepicker._TimePickerFragmentContext),FlutterSDK.Widgets.Mediaquery.Orientation orientation = default(FlutterSDK.Widgets.Mediaquery.Orientation))
{
this.FragmentContext = fragmentContext;
this.Orientation = orientation;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Timepicker._TimePickerFragmentContext FragmentContext{get;set;}
public virtual FlutterSDK.Widgets.Mediaquery.Orientation Orientation{get;set;}
#endregion

#region methods

private void _TogglePeriod(){ throw new NotImplementedException(); }


private void _SetAm(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


private void _SetPm(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _HourControl : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _HourControl(FlutterSDK.Material.Timepicker._TimePickerFragmentContext fragmentContext = default(FlutterSDK.Material.Timepicker._TimePickerFragmentContext))
{
this.FragmentContext = fragmentContext;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Timepicker._TimePickerFragmentContext FragmentContext{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _StringFragment : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _StringFragment(FlutterSDK.Material.Timepicker._TimePickerFragmentContext fragmentContext = default(FlutterSDK.Material.Timepicker._TimePickerFragmentContext),string value = default(string))
{
this.FragmentContext = fragmentContext;
this.Value = value;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Timepicker._TimePickerFragmentContext FragmentContext{get;set;}
public virtual string Value{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _MinuteControl : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _MinuteControl(FlutterSDK.Material.Timepicker._TimePickerFragmentContext fragmentContext = default(FlutterSDK.Material.Timepicker._TimePickerFragmentContext))
{
this.FragmentContext = fragmentContext;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Timepicker._TimePickerFragmentContext FragmentContext{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _TimePickerHeaderLayout : FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate
{
#region constructors
public _TimePickerHeaderLayout(FlutterSDK.Widgets.Mediaquery.Orientation orientation,FlutterSDK.Material.Timepicker._TimePickerHeaderFormat format)
: base()
{
this.Orientation = orientation;
this.Format = format;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Mediaquery.Orientation Orientation{get;set;}
public virtual FlutterSDK.Material.Timepicker._TimePickerHeaderFormat Format{get;set;}
#endregion

#region methods

public new void PerformLayout(Size size){ throw new NotImplementedException(); }


private void _LayoutHorizontally(Size size,FlutterSDK.Rendering.Box.BoxConstraints constraints){ throw new NotImplementedException(); }


private void _LayoutVertically(Size size,FlutterSDK.Rendering.Box.BoxConstraints constraints){ throw new NotImplementedException(); }


private void _PositionPivoted(double width,double y,Dictionary<FlutterSDK.Material.Timepicker._TimePickerHeaderId,Size> childSizes,List<FlutterSDK.Material.Timepicker._TimePickerHeaderFragment> fragments,int pivotIndex){ throw new NotImplementedException(); }


private void _PositionPiece(double width,double centeredAroundY,Dictionary<FlutterSDK.Material.Timepicker._TimePickerHeaderId,Size> childSizes,List<FlutterSDK.Material.Timepicker._TimePickerHeaderFragment> fragments){ throw new NotImplementedException(); }


public new bool ShouldRelayout(FlutterSDK.Material.Timepicker._TimePickerHeaderLayout oldDelegate){ throw new NotImplementedException(); }
public new bool ShouldRelayout(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate oldDelegate){ throw new NotImplementedException(); }

#endregion
}


public class _TimePickerHeader : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _TimePickerHeader(FlutterSDK.Material.Time.TimeOfDay selectedTime = default(FlutterSDK.Material.Time.TimeOfDay),FlutterSDK.Material.Timepicker._TimePickerMode mode = default(FlutterSDK.Material.Timepicker._TimePickerMode),FlutterSDK.Widgets.Mediaquery.Orientation orientation = default(FlutterSDK.Widgets.Mediaquery.Orientation),FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode> onModeChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode>),FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay>),bool use24HourDials = default(bool))
: base()
{
this.SelectedTime = selectedTime;
this.Mode = mode;
this.Orientation = orientation;
this.OnModeChanged = onModeChanged;
this.OnChanged = onChanged;
this.Use24HourDials = use24HourDials;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Time.TimeOfDay SelectedTime{get;set;}
public virtual FlutterSDK.Material.Timepicker._TimePickerMode Mode{get;set;}
public virtual FlutterSDK.Widgets.Mediaquery.Orientation Orientation{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode> OnModeChanged{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> OnChanged{get;set;}
public virtual bool Use24HourDials{get;set;}
#endregion

#region methods

private void _HandleChangeMode(FlutterSDK.Material.Timepicker._TimePickerMode value){ throw new NotImplementedException(); }


private FlutterSDK.Painting.Textstyle.TextStyle _GetBaseHeaderStyle(FlutterSDK.Material.Texttheme.TextTheme headerTextTheme){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _TappableLabel
{
#region constructors
public _TappableLabel(int value = default(int),FlutterSDK.Painting.Textpainter.TextPainter painter = default(FlutterSDK.Painting.Textpainter.TextPainter),VoidCallback onTap = default(VoidCallback))
{
this.Value = value;
this.Painter = painter;
this.OnTap = onTap;throw new NotImplementedException(); }
#endregion

#region fields
public virtual int Value{get;set;}
public virtual FlutterSDK.Painting.Textpainter.TextPainter Painter{get;set;}
public virtual VoidCallback OnTap{get;set;}
#endregion

#region methods
#endregion
}


public class _DialPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
{
#region constructors
public _DialPainter(List<FlutterSDK.Material.Timepicker._TappableLabel> primaryOuterLabels = default(List<FlutterSDK.Material.Timepicker._TappableLabel>),List<FlutterSDK.Material.Timepicker._TappableLabel> primaryInnerLabels = default(List<FlutterSDK.Material.Timepicker._TappableLabel>),List<FlutterSDK.Material.Timepicker._TappableLabel> secondaryOuterLabels = default(List<FlutterSDK.Material.Timepicker._TappableLabel>),List<FlutterSDK.Material.Timepicker._TappableLabel> secondaryInnerLabels = default(List<FlutterSDK.Material.Timepicker._TappableLabel>),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color accentColor = default(FlutterBinding.UI.Color),double theta = default(double),FlutterSDK.Material.Timepicker._DialRing activeRing = default(FlutterSDK.Material.Timepicker._DialRing),TextDirection textDirection = default(TextDirection),int selectedValue = default(int))
: base(repaint:BindingDefaultClass.PaintingBinding.Instance.SystemFonts)
{
this.PrimaryOuterLabels = primaryOuterLabels;
this.PrimaryInnerLabels = primaryInnerLabels;
this.SecondaryOuterLabels = secondaryOuterLabels;
this.SecondaryInnerLabels = secondaryInnerLabels;
this.BackgroundColor = backgroundColor;
this.AccentColor = accentColor;
this.Theta = theta;
this.ActiveRing = activeRing;
this.TextDirection = textDirection;
this.SelectedValue = selectedValue;throw new NotImplementedException(); }
#endregion

#region fields
public virtual List<FlutterSDK.Material.Timepicker._TappableLabel> PrimaryOuterLabels{get;set;}
public virtual List<FlutterSDK.Material.Timepicker._TappableLabel> PrimaryInnerLabels{get;set;}
public virtual List<FlutterSDK.Material.Timepicker._TappableLabel> SecondaryOuterLabels{get;set;}
public virtual List<FlutterSDK.Material.Timepicker._TappableLabel> SecondaryInnerLabels{get;set;}
public virtual FlutterBinding.UI.Color BackgroundColor{get;set;}
public virtual FlutterBinding.UI.Color AccentColor{get;set;}
public virtual double Theta{get;set;}
public virtual FlutterSDK.Material.Timepicker._DialRing ActiveRing{get;set;}
public virtual TextDirection TextDirection{get;set;}
public virtual int SelectedValue{get;set;}
internal virtual double _SemanticNodeSizeScale{get;set;}
public virtual FlutterSDK.Rendering.Custompaint.SemanticsBuilderCallback SemanticsBuilder{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void Paint(Canvas canvas,Size size){ throw new NotImplementedException(); }


private List<FlutterSDK.Rendering.Custompaint.CustomPainterSemantics> _BuildSemantics(Size size){ throw new NotImplementedException(); }


public new bool ShouldRepaint(FlutterSDK.Material.Timepicker._DialPainter oldPainter){ throw new NotImplementedException(); }
public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate){ throw new NotImplementedException(); }

#endregion
}


public class _Dial : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public _Dial(FlutterSDK.Material.Time.TimeOfDay selectedTime = default(FlutterSDK.Material.Time.TimeOfDay),FlutterSDK.Material.Timepicker._TimePickerMode mode = default(FlutterSDK.Material.Timepicker._TimePickerMode),bool use24HourDials = default(bool),FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay>),VoidCallback onHourSelected = default(VoidCallback))
: base()
{
this.SelectedTime = selectedTime;
this.Mode = mode;
this.Use24HourDials = use24HourDials;
this.OnChanged = onChanged;
this.OnHourSelected = onHourSelected;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Time.TimeOfDay SelectedTime{get;set;}
public virtual FlutterSDK.Material.Timepicker._TimePickerMode Mode{get;set;}
public virtual bool Use24HourDials{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> OnChanged{get;set;}
public virtual VoidCallback OnHourSelected{get;set;}
#endregion

#region methods

public new FlutterSDK.Material.Timepicker._DialState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _DialState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Timepicker._Dial>,ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
#region constructors
public _DialState()
{ }
#endregion

#region fields
public virtual FlutterSDK.Material.Themedata.ThemeData ThemeData{get;set;}
public virtual FlutterSDK.Material.Materiallocalizations.MaterialLocalizations Localizations{get;set;}
public virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData Media{get;set;}
internal virtual FlutterSDK.Animation.Tween.Tween<double> _ThetaTween{get;set;}
internal virtual FlutterSDK.Animation.Animation.Animation<double> _Theta{get;set;}
internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ThetaController{get;set;}
internal virtual bool _Dragging{get;set;}
internal virtual FlutterBinding.UI.Offset _Position{get;set;}
internal virtual FlutterBinding.UI.Offset _Center{get;set;}
internal virtual FlutterSDK.Material.Timepicker._DialRing _ActiveRing{get;set;}
internal virtual List<FlutterSDK.Material.Time.TimeOfDay> _AmHours{get;set;}
internal virtual List<FlutterSDK.Material.Time.TimeOfDay> _PmHours{get;set;}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


public new void DidChangeDependencies(){ throw new NotImplementedException(); }


public new void DidUpdateWidget(FlutterSDK.Material.Timepicker._Dial oldWidget){ throw new NotImplementedException(); }


private void _UpdateDialRingFromWidget(){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }


private double _Nearest(double target,double a,double b){ throw new NotImplementedException(); }


private void _AnimateTo(double targetTheta){ throw new NotImplementedException(); }


private double _GetThetaForTime(FlutterSDK.Material.Time.TimeOfDay time){ throw new NotImplementedException(); }


private FlutterSDK.Material.Time.TimeOfDay _GetTimeForTheta(double theta){ throw new NotImplementedException(); }


private FlutterSDK.Material.Time.TimeOfDay _NotifyOnChangedIfNeeded(){ throw new NotImplementedException(); }


private void _UpdateThetaForPan(){ throw new NotImplementedException(); }


private void _HandlePanStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details){ throw new NotImplementedException(); }


private void _HandlePanUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details){ throw new NotImplementedException(); }


private void _HandlePanEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details){ throw new NotImplementedException(); }


private void _HandleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details){ throw new NotImplementedException(); }


private void _SelectHour(int hour){ throw new NotImplementedException(); }


private void _SelectMinute(int minute){ throw new NotImplementedException(); }


private FlutterSDK.Material.Timepicker._TappableLabel _BuildTappableLabel(FlutterSDK.Material.Texttheme.TextTheme textTheme,int value,string label,VoidCallback onTap){ throw new NotImplementedException(); }


private List<FlutterSDK.Material.Timepicker._TappableLabel> _Build24HourInnerRing(FlutterSDK.Material.Texttheme.TextTheme textTheme){ throw new NotImplementedException(); }


private List<FlutterSDK.Material.Timepicker._TappableLabel> _Build24HourOuterRing(FlutterSDK.Material.Texttheme.TextTheme textTheme){ throw new NotImplementedException(); }


private List<FlutterSDK.Material.Timepicker._TappableLabel> _Build12HourOuterRing(FlutterSDK.Material.Texttheme.TextTheme textTheme){ throw new NotImplementedException(); }


private List<FlutterSDK.Material.Timepicker._TappableLabel> _BuildMinutes(FlutterSDK.Material.Texttheme.TextTheme textTheme){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _TimePickerDialog : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public _TimePickerDialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Material.Time.TimeOfDay initialTime = default(FlutterSDK.Material.Time.TimeOfDay))
: base(key:key)
{
this.InitialTime = initialTime;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Time.TimeOfDay InitialTime{get;set;}
#endregion

#region methods

public new FlutterSDK.Material.Timepicker._TimePickerDialogState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _TimePickerDialogState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Timepicker._TimePickerDialog>
{
#region constructors
public _TimePickerDialogState()
{ }
#endregion

#region fields
internal virtual FlutterSDK.Material.Timepicker._TimePickerMode _Mode{get;set;}
internal virtual FlutterSDK.Material.Timepicker._TimePickerMode _LastModeAnnounced{get;set;}
internal virtual FlutterSDK.Material.Time.TimeOfDay _SelectedTime{get;set;}
internal virtual Timer _VibrateTimer{get;set;}
public virtual FlutterSDK.Material.Materiallocalizations.MaterialLocalizations Localizations{get;set;}
internal virtual bool _AnnouncedInitialTime{get;set;}
public virtual FlutterSDK.Material.Time.TimeOfDay SelectedTime{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


public new void DidChangeDependencies(){ throw new NotImplementedException(); }


private void _Vibrate(){ throw new NotImplementedException(); }


private void _HandleModeChanged(FlutterSDK.Material.Timepicker._TimePickerMode mode){ throw new NotImplementedException(); }


private void _AnnounceModeOnce(){ throw new NotImplementedException(); }


private void _AnnounceInitialTimeOnce(){ throw new NotImplementedException(); }


private void _HandleTimeChanged(FlutterSDK.Material.Time.TimeOfDay value){ throw new NotImplementedException(); }


private void _HandleHourSelected(){ throw new NotImplementedException(); }


private void _HandleCancel(){ throw new NotImplementedException(); }


private void _HandleOk(){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }

#endregion
}


public enum _TimePickerMode{

Hour,
Minute,
}


public enum _TimePickerHeaderId{

Hour,
Colon,
Minute,
Period,
Dot,
HString,
}


public enum _DialRing{

Outer,
Inner,
}

}
