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
namespace FlutterSDK.Material.Timepicker
{
    internal static class TimepickerDefaultClass
    {
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
        internal static FlutterSDK.Material.Timepicker._TimePickerHeaderFormat _BuildHeaderFormat(FlutterSDK.Material.Time.TimeOfDayFormat timeOfDayFormat, FlutterSDK.Material.Timepicker._TimePickerFragmentContext context, FlutterSDK.Widgets.Mediaquery.Orientation orientation)
        {
            throw new NotImplementedException();
        }

        internal static Future<FlutterSDK.Material.Time.TimeOfDay> ShowTimePicker(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Material.Time.TimeOfDay initialTime = default(FlutterSDK.Material.Time.TimeOfDay), FlutterSDK.Widgets.Framework.TransitionBuilder builder = default(FlutterSDK.Widgets.Framework.TransitionBuilder), bool useRootNavigator = true, FlutterSDK.Widgets.Navigator.RouteSettings routeSettings = default(FlutterSDK.Widgets.Navigator.RouteSettings))
        {
            throw new NotImplementedException();
        }

        internal static void _AnnounceToAccessibility(FlutterSDK.Widgets.Framework.BuildContext context, string message)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// Provides properties for rendering time picker header fragments.
    /// </Summary>
    public class _TimePickerFragmentContext
    {
        #region constructors
        public _TimePickerFragmentContext(FlutterSDK.Material.Texttheme.TextTheme headerTextTheme = default(FlutterSDK.Material.Texttheme.TextTheme), TextDirection textDirection = default(TextDirection), FlutterSDK.Material.Time.TimeOfDay selectedTime = default(FlutterSDK.Material.Time.TimeOfDay), FlutterSDK.Material.Timepicker._TimePickerMode mode = default(FlutterSDK.Material.Timepicker._TimePickerMode), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle activeStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle inactiveStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> onTimeChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay>), FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode> onModeChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode>), FlutterSDK.Foundation.Platform.TargetPlatform targetPlatform = default(FlutterSDK.Foundation.Platform.TargetPlatform), bool use24HourDials = default(bool))
        : base()
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Material.Texttheme.TextTheme HeaderTextTheme { get; set; }
    public virtual TextDirection TextDirection { get; set; }
    public virtual FlutterSDK.Material.Time.TimeOfDay SelectedTime { get; set; }
    public virtual FlutterSDK.Material.Timepicker._TimePickerMode Mode { get; set; }
    public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle ActiveStyle { get; set; }
    public virtual FlutterBinding.UI.Color InactiveColor { get; set; }
    public virtual FlutterSDK.Painting.Textstyle.TextStyle InactiveStyle { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> OnTimeChange { get; set; }
    public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode> OnModeChange { get; set; }
    public virtual FlutterSDK.Foundation.Platform.TargetPlatform TargetPlatform { get; set; }
    public virtual bool Use24HourDials { get; set; }
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Contains the [widget] and layout properties of an atom of time information,
/// such as am/pm indicator, hour, minute and string literals appearing in the
/// formatted time string.
/// </Summary>
public class _TimePickerHeaderFragment
{
    #region constructors
    public _TimePickerHeaderFragment(FlutterSDK.Material.Timepicker._TimePickerHeaderId layoutId = default(FlutterSDK.Material.Timepicker._TimePickerHeaderId), FlutterSDK.Widgets.Framework.Widget widget = default(FlutterSDK.Widgets.Framework.Widget), double startMargin = 0.0)
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Material.Timepicker._TimePickerHeaderId LayoutId { get; set; }
public virtual FlutterSDK.Widgets.Framework.Widget Widget { get; set; }
public virtual double StartMargin { get; set; }
#endregion

#region methods
#endregion
}


/// <Summary>
/// An unbreakable part of the time picker header.
///
/// When the picker is laid out vertically, [fragments] of the piece are laid
/// out on the same line, with each piece getting its own line.
/// </Summary>
public class _TimePickerHeaderPiece
{
    #region constructors
    public _TimePickerHeaderPiece(int pivotIndex, List<FlutterSDK.Material.Timepicker._TimePickerHeaderFragment> fragments, double bottomMargin = 0.0)
    : base()

}
#endregion

#region fields
public virtual int PivotIndex { get; set; }
public virtual List<FlutterSDK.Material.Timepicker._TimePickerHeaderFragment> Fragments { get; set; }
public virtual double BottomMargin { get; set; }
#endregion

#region methods
#endregion
}


/// <Summary>
/// Describes how the time picker header must be formatted.
///
/// A [_TimePickerHeaderFormat] is made of multiple [_TimePickerHeaderPiece]s.
/// A piece is made of multiple [_TimePickerHeaderFragment]s. A fragment has a
/// widget used to render some time information and contains some layout
/// properties.
///
/// ## Layout rules
///
/// Pieces are laid out such that all fragments inside the same piece are laid
/// out horizontally. Pieces are laid out horizontally if portrait orientation,
/// and vertically in landscape orientation.
///
/// One of the pieces is identified as a _centerpiece_. It is a piece that is
/// positioned in the center of the header, with all other pieces positioned
/// to the left or right of it.
/// </Summary>
public class _TimePickerHeaderFormat
{
    #region constructors
    public _TimePickerHeaderFormat(int centerpieceIndex, List<FlutterSDK.Material.Timepicker._TimePickerHeaderPiece> pieces)
    : base()

}
#endregion

#region fields
public virtual int CenterpieceIndex { get; set; }
public virtual List<FlutterSDK.Material.Timepicker._TimePickerHeaderPiece> Pieces { get; set; }
#endregion

#region methods
#endregion
}


/// <Summary>
/// Displays the am/pm fragment and provides controls for switching between am
/// and pm.
/// </Summary>
public class _DayPeriodControl : FlutterSDK.Widgets.Framework.StatelessWidget
{
    #region constructors
    public _DayPeriodControl(FlutterSDK.Material.Timepicker._TimePickerFragmentContext fragmentContext = default(FlutterSDK.Material.Timepicker._TimePickerFragmentContext), FlutterSDK.Widgets.Mediaquery.Orientation orientation = default(FlutterSDK.Widgets.Mediaquery.Orientation))

}
#endregion

#region fields
public virtual FlutterSDK.Material.Timepicker._TimePickerFragmentContext FragmentContext { get; set; }
public virtual FlutterSDK.Widgets.Mediaquery.Orientation Orientation { get; set; }
#endregion

#region methods

private void _TogglePeriod()
{
    int newHour = (FragmentContext.SelectedTime.Hour + TimeDefaultClass.TimeOfDay.HoursPerPeriod) % TimeDefaultClass.TimeOfDay.HoursPerDay;
    TimeOfDay newTime = FragmentContext.SelectedTime.Replacing(hour: newHour);
    FragmentContext.OnTimeChange(newTime);
}




private void _SetAm(FlutterSDK.Widgets.Framework.BuildContext context)
{
    if (FragmentContext.SelectedTime.Period == DayPeriod.Am)
    {
        return;
    }

    switch (FragmentContext.TargetPlatform) { case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: TimepickerDefaultClass._AnnounceToAccessibility(context, MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).AnteMeridiemAbbreviation); break; case TargetPlatform.IOS: case TargetPlatform.MacOS: break; }
    _TogglePeriod();
}




private void _SetPm(FlutterSDK.Widgets.Framework.BuildContext context)
{
    if (FragmentContext.SelectedTime.Period == DayPeriod.Pm)
    {
        return;
    }

    switch (FragmentContext.TargetPlatform) { case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: TimepickerDefaultClass._AnnounceToAccessibility(context, MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).PostMeridiemAbbreviation); break; case TargetPlatform.IOS: case TargetPlatform.MacOS: break; }
    _TogglePeriod();
}




public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    MaterialLocalizations materialLocalizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
    TextTheme headerTextTheme = FragmentContext.HeaderTextTheme;
    TimeOfDay selectedTime = FragmentContext.SelectedTime;
    Color activeColor = FragmentContext.ActiveColor;
    Color inactiveColor = FragmentContext.InactiveColor;
    bool amSelected = selectedTime.Period == DayPeriod.Am;
    TextStyle amStyle = headerTextTheme.Subtitle1.CopyWith(color: amSelected ? activeColor : inactiveColor);
    TextStyle pmStyle = headerTextTheme.Subtitle1.CopyWith(color: !amSelected ? activeColor : inactiveColor);
    bool layoutPortrait = Orientation == Orientation.Portrait;
    double buttonTextScaleFactor = Math.Dart:mathDefaultClass.Min(MediaqueryDefaultClass.MediaQuery.Of(context).TextScaleFactor, 2.0);
    Widget amButton = new ConstrainedBox(constraints: TimepickerDefaultClass._KMinTappableRegion, child: new Material(type: MaterialType.Transparency, child: new InkWell(onTap: FeedbackDefaultClass.Feedback.WrapForTap(() => =>_SetAm(context), context), child: new Padding(padding: layoutPortrait ? EdgeInsets.Only(bottom: 2.0) : EdgeInsets.Only(right: 4.0), child: new Align(alignment: layoutPortrait ? AlignmentDefaultClass.Alignment.BottomCenter : AlignmentDefaultClass.Alignment.CenterRight, widthFactor: 1, heightFactor: 1, child: new Semantics(selected: amSelected, child: new Text(materialLocalizations.AnteMeridiemAbbreviation, style: amStyle, textScaleFactor: buttonTextScaleFactor)))))));
    Widget pmButton = new ConstrainedBox(constraints: TimepickerDefaultClass._KMinTappableRegion, child: new Material(type: MaterialType.Transparency, textStyle: pmStyle, child: new InkWell(onTap: FeedbackDefaultClass.Feedback.WrapForTap(() => =>_SetPm(context), context), child: new Padding(padding: layoutPortrait ? EdgeInsets.Only(top: 2.0) : EdgeInsets.Only(left: 4.0), child: new Align(alignment: Orientation == Orientation.Portrait ? AlignmentDefaultClass.Alignment.TopCenter : AlignmentDefaultClass.Alignment.CenterLeft, widthFactor: 1, heightFactor: 1, child: new Semantics(selected: !amSelected, child: new Text(materialLocalizations.PostMeridiemAbbreviation, style: pmStyle, textScaleFactor: buttonTextScaleFactor)))))));
    switch (Orientation) { case Orientation.Portrait: return new Column(mainAxisSize: MainAxisSize.Min, children: new List<Widget>() { amButton, pmButton }); case Orientation.Landscape: return new Row(mainAxisSize: MainAxisSize.Min, children: new List<Widget>() { amButton, pmButton }); }
    return null;
}



#endregion
}


/// <Summary>
/// Displays the hour fragment.
///
/// When tapped changes time picker dial mode to [_TimePickerMode.hour].
/// </Summary>
public class _HourControl : FlutterSDK.Widgets.Framework.StatelessWidget
{
    #region constructors
    public _HourControl(FlutterSDK.Material.Timepicker._TimePickerFragmentContext fragmentContext = default(FlutterSDK.Material.Timepicker._TimePickerFragmentContext))

}
#endregion

#region fields
public virtual FlutterSDK.Material.Timepicker._TimePickerFragmentContext FragmentContext { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{

    bool alwaysUse24HourFormat = MediaqueryDefaultClass.MediaQuery.Of(context).AlwaysUse24HourFormat;
    MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
    TextStyle hourStyle = FragmentContext.Mode == _TimePickerMode.Hour ? FragmentContext.ActiveStyle : FragmentContext.InactiveStyle;
    string formattedHour = localizations.FormatHour(FragmentContext.SelectedTime, alwaysUse24HourFormat: alwaysUse24HourFormat);
    TimeOfDay HoursFromSelected(int hoursToAdd) => {
        if (FragmentContext.Use24HourDials)
        {
            int selectedHour = FragmentContext.SelectedTime.Hour;
            return FragmentContext.SelectedTime.Replacing(hour: (selectedHour + hoursToAdd) % TimeDefaultClass.TimeOfDay.HoursPerDay);
        }
        else
        {
            int periodOffset = FragmentContext.SelectedTime.PeriodOffset;
            int hours = FragmentContext.SelectedTime.HourOfPeriod;
            return FragmentContext.SelectedTime.Replacing(hour: periodOffset + (hours + hoursToAdd) % TimeDefaultClass.TimeOfDay.HoursPerPeriod);
        }

    }

    TimeOfDay nextHour = HoursFromSelected(1);
    string formattedNextHour = localizations.FormatHour(nextHour, alwaysUse24HourFormat: alwaysUse24HourFormat);
    TimeOfDay previousHour = HoursFromSelected(-1);
    string formattedPreviousHour = localizations.FormatHour(previousHour, alwaysUse24HourFormat: alwaysUse24HourFormat);
    return new Semantics(hint: localizations.TimePickerHourModeAnnouncement, value: formattedHour, excludeSemantics: true, increasedValue: formattedNextHour, onIncrease: () =>
    {
        FragmentContext.OnTimeChange(nextHour);
    }
    , decreasedValue: formattedPreviousHour, onDecrease: () =>
    {
        FragmentContext.OnTimeChange(previousHour);
    }
    , child: new ConstrainedBox(constraints: TimepickerDefaultClass._KMinTappableRegion, child: new Material(type: MaterialType.Transparency, child: new InkWell(onTap: FeedbackDefaultClass.Feedback.WrapForTap(() => =>FragmentContext.OnModeChange(_TimePickerMode.Hour), context), child: new Text(formattedHour, style: hourStyle, textAlign: TextAlign.End, textScaleFactor: 1.0)))));
}



#endregion
}


/// <Summary>
/// A passive fragment showing a string value.
/// </Summary>
public class _StringFragment : FlutterSDK.Widgets.Framework.StatelessWidget
{
    #region constructors
    public _StringFragment(FlutterSDK.Material.Timepicker._TimePickerFragmentContext fragmentContext = default(FlutterSDK.Material.Timepicker._TimePickerFragmentContext), string value = default(string))

}
#endregion

#region fields
public virtual FlutterSDK.Material.Timepicker._TimePickerFragmentContext FragmentContext { get; set; }
public virtual string Value { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new ExcludeSemantics(child: new Text(Value, style: FragmentContext.InactiveStyle, textScaleFactor: 1.0));
}



#endregion
}


/// <Summary>
/// Displays the minute fragment.
///
/// When tapped changes time picker dial mode to [_TimePickerMode.minute].
/// </Summary>
public class _MinuteControl : FlutterSDK.Widgets.Framework.StatelessWidget
{
    #region constructors
    public _MinuteControl(FlutterSDK.Material.Timepicker._TimePickerFragmentContext fragmentContext = default(FlutterSDK.Material.Timepicker._TimePickerFragmentContext))

}
#endregion

#region fields
public virtual FlutterSDK.Material.Timepicker._TimePickerFragmentContext FragmentContext { get; set; }
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
    TextStyle minuteStyle = FragmentContext.Mode == _TimePickerMode.Minute ? FragmentContext.ActiveStyle : FragmentContext.InactiveStyle;
    string formattedMinute = localizations.FormatMinute(FragmentContext.SelectedTime);
    TimeOfDay nextMinute = FragmentContext.SelectedTime.Replacing(minute: (FragmentContext.SelectedTime.Minute + 1) % TimeDefaultClass.TimeOfDay.MinutesPerHour);
    string formattedNextMinute = localizations.FormatMinute(nextMinute);
    TimeOfDay previousMinute = FragmentContext.SelectedTime.Replacing(minute: (FragmentContext.SelectedTime.Minute - 1) % TimeDefaultClass.TimeOfDay.MinutesPerHour);
    string formattedPreviousMinute = localizations.FormatMinute(previousMinute);
    return new Semantics(excludeSemantics: true, hint: localizations.TimePickerMinuteModeAnnouncement, value: formattedMinute, increasedValue: formattedNextMinute, onIncrease: () =>
    {
        FragmentContext.OnTimeChange(nextMinute);
    }
    , decreasedValue: formattedPreviousMinute, onDecrease: () =>
    {
        FragmentContext.OnTimeChange(previousMinute);
    }
    , child: new ConstrainedBox(constraints: TimepickerDefaultClass._KMinTappableRegion, child: new Material(type: MaterialType.Transparency, child: new InkWell(onTap: FeedbackDefaultClass.Feedback.WrapForTap(() => =>FragmentContext.OnModeChange(_TimePickerMode.Minute), context), child: new Text(formattedMinute, style: minuteStyle, textAlign: TextAlign.Start, textScaleFactor: 1.0)))));
}



#endregion
}


public class _TimePickerHeaderLayout : FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate
{
    #region constructors
    public _TimePickerHeaderLayout(FlutterSDK.Widgets.Mediaquery.Orientation orientation, FlutterSDK.Material.Timepicker._TimePickerHeaderFormat format)
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Mediaquery.Orientation Orientation { get; set; }
public virtual FlutterSDK.Material.Timepicker._TimePickerHeaderFormat Format { get; set; }
#endregion

#region methods

public new void PerformLayout(Size size)
{
    BoxConstraints constraints = BoxConstraints.Loose(size);
    switch (Orientation) { case Orientation.Portrait: _LayoutHorizontally(size, constraints); break; case Orientation.Landscape: _LayoutVertically(size, constraints); break; }
}




private void _LayoutHorizontally(Size size, FlutterSDK.Rendering.Box.BoxConstraints constraints)
{
    List<_TimePickerHeaderFragment> fragmentsFlattened = new List<_TimePickerHeaderFragment>() { };
    Dictionary<_TimePickerHeaderId, Size> childSizes = new Dictionary<_TimePickerHeaderId, Size> { };
    int pivotIndex = 0;
    for (int pieceIndex = 0; pieceIndex < Format.Pieces.Count; pieceIndex += 1)
    {
        _TimePickerHeaderPiece piece = Format.Pieces[pieceIndex];
        foreach (_TimePickerHeaderFragment fragment in piece.Fragments)
        {
            childSizes[fragment.LayoutId] = LayoutChild(fragment.LayoutId, constraints);
            fragmentsFlattened.Add(fragment);
        }

        if (pieceIndex == Format.CenterpieceIndex) pivotIndex += Format.Pieces[Format.CenterpieceIndex].PivotIndex; else if (pieceIndex < Format.CenterpieceIndex) pivotIndex += piece.Fragments.Count;
    }

    _PositionPivoted(size.Width, size.Height / 2.0, childSizes, fragmentsFlattened, pivotIndex);
}




private void _LayoutVertically(Size size, FlutterSDK.Rendering.Box.BoxConstraints constraints)
{
    Dictionary<_TimePickerHeaderId, Size> childSizes = new Dictionary<_TimePickerHeaderId, Size> { };
    List<double> pieceHeights = new List<double>() { };
    double height = 0.0;
    double margin = 0.0;
    foreach (_TimePickerHeaderPiece piece in Format.Pieces)
    {
        double pieceHeight = 0.0;
        foreach (_TimePickerHeaderFragment fragment in piece.Fragments)
        {
            Size childSize = childSizes[fragment.LayoutId] = LayoutChild(fragment.LayoutId, constraints);
            pieceHeight = Math.Dart:mathDefaultClass.Max(pieceHeight, childSize.Height);
}

pieceHeights.Add(pieceHeight);
height += pieceHeight + margin;
margin = piece.BottomMargin;
}

_TimePickerHeaderPiece centerpiece = Format.Pieces[Format.CenterpieceIndex];
double y = (size.Height - height) / 2.0;
for (int pieceIndex = 0; pieceIndex < Format.Pieces.Count; pieceIndex += 1)
{
    double pieceVerticalCenter = y + pieceHeights[pieceIndex] / 2.0;
    if (pieceIndex != Format.CenterpieceIndex) _PositionPiece(size.Width, pieceVerticalCenter, childSizes, Format.Pieces[pieceIndex].Fragments); else _PositionPivoted(size.Width, pieceVerticalCenter, childSizes, centerpiece.Fragments, centerpiece.PivotIndex);
    y += pieceHeights[pieceIndex] + Format.Pieces[pieceIndex].BottomMargin;
}

}




private void _PositionPivoted(double width, double y, Dictionary<FlutterSDK.Material.Timepicker._TimePickerHeaderId, Size> childSizes, List<FlutterSDK.Material.Timepicker._TimePickerHeaderFragment> fragments, int pivotIndex)
{
    double tailWidth = childSizes[fragments[pivotIndex].LayoutId].Width / 2.0;
    foreach (_TimePickerHeaderFragment fragment in fragments.Skip(pivotIndex + 1))
    {
        tailWidth += childSizes[fragment.LayoutId].Width + fragment.StartMargin;
    }

    double x = width / 2.0 + tailWidth;
    x = Math.Dart:mathDefaultClass.Min(x, width);
for (int i = fragments.Count - 1; i >= 0; i -= 1)
{
    _TimePickerHeaderFragment fragment = fragments[i];
    Size childSize = childSizes[fragment.LayoutId];
    x -= childSize.Width;
    PositionChild(fragment.LayoutId, new Offset(x, y - childSize.Height / 2.0));
    x -= fragment.StartMargin;
}

}




private void _PositionPiece(double width, double centeredAroundY, Dictionary<FlutterSDK.Material.Timepicker._TimePickerHeaderId, Size> childSizes, List<FlutterSDK.Material.Timepicker._TimePickerHeaderFragment> fragments)
{
    double pieceWidth = 0.0;
    double nextMargin = 0.0;
    foreach (_TimePickerHeaderFragment fragment in fragments)
    {
        Size childSize = childSizes[fragment.LayoutId];
        pieceWidth += childSize.Width + nextMargin;
        nextMargin = fragment.StartMargin;
    }

    double x = (width + pieceWidth) / 2.0;
    for (int i = fragments.Count - 1; i >= 0; i -= 1)
    {
        _TimePickerHeaderFragment fragment = fragments[i];
        Size childSize = childSizes[fragment.LayoutId];
        x -= childSize.Width;
        PositionChild(fragment.LayoutId, new Offset(x, centeredAroundY - childSize.Height / 2.0));
        x -= fragment.StartMargin;
    }

}




public new bool ShouldRelayout(FlutterSDK.Material.Timepicker._TimePickerHeaderLayout oldDelegate) => Orientation != oldDelegate.Orientation || Format != oldDelegate.Format;

public new bool ShouldRelayout(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate oldDelegate) => Orientation != oldDelegate.Orientation || Format != oldDelegate.Format;


#endregion
}


public class _TimePickerHeader : FlutterSDK.Widgets.Framework.StatelessWidget
{
    #region constructors
    public _TimePickerHeader(FlutterSDK.Material.Time.TimeOfDay selectedTime = default(FlutterSDK.Material.Time.TimeOfDay), FlutterSDK.Material.Timepicker._TimePickerMode mode = default(FlutterSDK.Material.Timepicker._TimePickerMode), FlutterSDK.Widgets.Mediaquery.Orientation orientation = default(FlutterSDK.Widgets.Mediaquery.Orientation), FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode> onModeChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode>), FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay>), bool use24HourDials = default(bool))
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Material.Time.TimeOfDay SelectedTime { get; set; }
public virtual FlutterSDK.Material.Timepicker._TimePickerMode Mode { get; set; }
public virtual FlutterSDK.Widgets.Mediaquery.Orientation Orientation { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<_TimePickerMode> OnModeChanged { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> OnChanged { get; set; }
public virtual bool Use24HourDials { get; set; }
#endregion

#region methods

private void _HandleChangeMode(FlutterSDK.Material.Timepicker._TimePickerMode value)
{
    if (value != Mode) OnModeChanged(value);
}




private FlutterSDK.Painting.Textstyle.TextStyle _GetBaseHeaderStyle(FlutterSDK.Material.Texttheme.TextTheme headerTextTheme)
{

    switch (Orientation) { case Orientation.Portrait: return headerTextTheme.Headline2.CopyWith(fontSize: 60.0); case Orientation.Landscape: return headerTextTheme.Headline3.CopyWith(fontSize: 50.0); }
    return null;
}




public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{

    ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
    MediaQueryData media = MediaqueryDefaultClass.MediaQuery.Of(context);
    TimeOfDayFormat timeOfDayFormat = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context).TimeOfDayFormat(alwaysUse24HourFormat: media.AlwaysUse24HourFormat);
    EdgeInsets padding = default(EdgeInsets);
    double height = default(double);
    double width = default(double);

    switch (Orientation) { case Orientation.Portrait: height = TimepickerDefaultClass._KTimePickerHeaderPortraitHeight; padding = EdgeInsets.Symmetric(horizontal: 24.0); break; case Orientation.Landscape: width = TimepickerDefaultClass._KTimePickerHeaderLandscapeWidth; padding = EdgeInsets.Symmetric(horizontal: 16.0); break; }
    Color backgroundColor = default(Color);
    switch (themeData.Brightness) { case Brightness.Light: backgroundColor = themeData.PrimaryColor; break; case Brightness.Dark: backgroundColor = themeData.BackgroundColor; break; }
    Color activeColor = default(Color);
    Color inactiveColor = default(Color);
    switch (themeData.PrimaryColorBrightness) { case Brightness.Light: activeColor = ColorsDefaultClass.Colors.Black87; inactiveColor = ColorsDefaultClass.Colors.Black54; break; case Brightness.Dark: activeColor = ColorsDefaultClass.Colors.White; inactiveColor = ColorsDefaultClass.Colors.White70; break; }
    TextTheme headerTextTheme = themeData.PrimaryTextTheme;
    TextStyle baseHeaderStyle = _GetBaseHeaderStyle(headerTextTheme);
    _TimePickerFragmentContext fragmentContext = new _TimePickerFragmentContext(headerTextTheme: headerTextTheme, textDirection: BasicDefaultClass.Directionality.Of(context), selectedTime: SelectedTime, mode: Mode, activeColor: activeColor, activeStyle: baseHeaderStyle.CopyWith(color: activeColor), inactiveColor: inactiveColor, inactiveStyle: baseHeaderStyle.CopyWith(color: inactiveColor), onTimeChange: OnChanged, onModeChange: _HandleChangeMode, targetPlatform: themeData.Platform, use24HourDials: Use24HourDials);
    _TimePickerHeaderFormat format = TimepickerDefaultClass._BuildHeaderFormat(timeOfDayFormat, fragmentContext, Orientation);
    return new Container(width: width, height: height, padding: padding, color: backgroundColor, child: new CustomMultiChildLayout(@delegate: new _TimePickerHeaderLayout(Orientation, format), children: format.Pieces.Expand((_TimePickerHeaderPiece piece) => =>piece.Fragments).Map((_TimePickerHeaderFragment fragment) =>
    {
        return new LayoutId(id: fragment.LayoutId, child: fragment.Widget);
    }
    ).ToList()));
}



#endregion
}


public class _TappableLabel
{
    #region constructors
    public _TappableLabel(int value = default(int), FlutterSDK.Painting.Textpainter.TextPainter painter = default(FlutterSDK.Painting.Textpainter.TextPainter), VoidCallback onTap = default(VoidCallback))

}
#endregion

#region fields
public virtual int Value { get; set; }
public virtual FlutterSDK.Painting.Textpainter.TextPainter Painter { get; set; }
public virtual VoidCallback OnTap { get; set; }
#endregion

#region methods
#endregion
}


public class _DialPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
{
    #region constructors
    public _DialPainter(List<FlutterSDK.Material.Timepicker._TappableLabel> primaryOuterLabels = default(List<FlutterSDK.Material.Timepicker._TappableLabel>), List<FlutterSDK.Material.Timepicker._TappableLabel> primaryInnerLabels = default(List<FlutterSDK.Material.Timepicker._TappableLabel>), List<FlutterSDK.Material.Timepicker._TappableLabel> secondaryOuterLabels = default(List<FlutterSDK.Material.Timepicker._TappableLabel>), List<FlutterSDK.Material.Timepicker._TappableLabel> secondaryInnerLabels = default(List<FlutterSDK.Material.Timepicker._TappableLabel>), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color accentColor = default(FlutterBinding.UI.Color), double theta = default(double), FlutterSDK.Material.Timepicker._DialRing activeRing = default(FlutterSDK.Material.Timepicker._DialRing), TextDirection textDirection = default(TextDirection), int selectedValue = default(int))
    : base(repaint: BindingDefaultClass.PaintingBinding.Instance.SystemFonts)

}
#endregion

#region fields
public virtual List<FlutterSDK.Material.Timepicker._TappableLabel> PrimaryOuterLabels { get; set; }
public virtual List<FlutterSDK.Material.Timepicker._TappableLabel> PrimaryInnerLabels { get; set; }
public virtual List<FlutterSDK.Material.Timepicker._TappableLabel> SecondaryOuterLabels { get; set; }
public virtual List<FlutterSDK.Material.Timepicker._TappableLabel> SecondaryInnerLabels { get; set; }
public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
public virtual FlutterBinding.UI.Color AccentColor { get; set; }
public virtual double Theta { get; set; }
public virtual FlutterSDK.Material.Timepicker._DialRing ActiveRing { get; set; }
public virtual TextDirection TextDirection { get; set; }
public virtual int SelectedValue { get; set; }
internal virtual double _SemanticNodeSizeScale { get; set; }
public virtual FlutterSDK.Rendering.Custompaint.SemanticsBuilderCallback SemanticsBuilder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void Paint(Canvas canvas, Size size)
{
    double radius = size.ShortestSide / 2.0;
    Offset center = new Offset(size.Width / 2.0, size.Height / 2.0);
    Offset centerPoint = center;
    canvas.DrawCircle(centerPoint, radius, new Paint()..Color = BackgroundColor);
    double labelPadding = 24.0;
    double outerLabelRadius = radius - labelPadding;
    double innerLabelRadius = radius - labelPadding * 2.5;
    Offset GetOffsetForTheta(double theta, _DialRing ring) => {
        double labelRadius = default(double);
        switch (ring) { case _DialRing.Outer: labelRadius = outerLabelRadius; break; case _DialRing.Inner: labelRadius = innerLabelRadius; break; }
        return center + new Offset(labelRadius * Math.Dart:mathDefaultClass.Cos(theta), -labelRadius * Math.Dart:mathDefaultClass.Sin(theta));
    }

    void PaintLabels(List<_TappableLabel> labels, _DialRing ring) => {
        if (labels == null) return;
        double labelThetaIncrement = -TimepickerDefaultClass._KTwoPi / labels.Count;
        double labelTheta = Math.Dart:mathDefaultClass.Pi / 2.0;
        foreach (_TappableLabel label in labels)
        {
            TextPainter labelPainter = label.Painter;
            Offset labelOffset = new Offset(-labelPainter.Width / 2.0, -labelPainter.Height / 2.0);
            labelPainter.Paint(canvas, GetOffsetForTheta(labelTheta, ring) + labelOffset);
            labelTheta += labelThetaIncrement;
        }

    }

    PaintLabels(PrimaryOuterLabels, _DialRing.Outer);
    PaintLabels(PrimaryInnerLabels, _DialRing.Inner);
    Paint selectorPaint = new Paint()..Color = AccentColor;
    Offset focusedPoint = GetOffsetForTheta(Theta, ActiveRing);
    double focusedRadius = labelPadding - 4.0;
    canvas.DrawCircle(centerPoint, 4.0, selectorPaint);
    canvas.DrawCircle(focusedPoint, focusedRadius, selectorPaint);
    selectorPaint.StrokeWidth = 2.0;
    canvas.DrawLine(centerPoint, focusedPoint, selectorPaint);
    Rect focusedRect = Rect.FromCircle(center: focusedPoint, radius: focusedRadius);
    ;
    canvas.Save();
    canvas.ClipPath(new Path();
    new Path().AddOval(focusedRect));
    PaintLabels(SecondaryOuterLabels, _DialRing.Outer);
    PaintLabels(SecondaryInnerLabels, _DialRing.Inner);
    canvas.Restore();
}




/// <Summary>
/// Creates semantics nodes for the hour/minute labels painted on the dial.
///
/// The nodes are positioned on top of the text and their size is
/// [_semanticNodeSizeScale] bigger than those of the text boxes to provide
/// bigger tap area.
/// </Summary>
private List<FlutterSDK.Rendering.Custompaint.CustomPainterSemantics> _BuildSemantics(Size size)
{
    double radius = size.ShortestSide / 2.0;
    Offset center = new Offset(size.Width / 2.0, size.Height / 2.0);
    double labelPadding = 24.0;
    double outerLabelRadius = radius - labelPadding;
    double innerLabelRadius = radius - labelPadding * 2.5;
    Offset GetOffsetForTheta(double theta, _DialRing ring) => {
        double labelRadius = default(double);
        switch (ring) { case _DialRing.Outer: labelRadius = outerLabelRadius; break; case _DialRing.Inner: labelRadius = innerLabelRadius; break; }
        return center + new Offset(labelRadius * Math.Dart:mathDefaultClass.Cos(theta), -labelRadius * Math.Dart:mathDefaultClass.Sin(theta));
}
 
List<CustomPainterSemantics> nodes = new List<CustomPainterSemantics>() { };
void PaintLabels(List<_TappableLabel> labels, _DialRing ring) => {
    if (labels == null) return;
    double labelThetaIncrement = -TimepickerDefaultClass._KTwoPi / labels.Count;
    double ordinalOffset = ring == _DialRing.Inner ? 12.0 : 0.0;
    double labelTheta = Math.Dart:mathDefaultClass.Pi / 2.0;
    for (int i = 0; i < labels.Count; i++)
    {
        _TappableLabel label = labels[i];
        TextPainter labelPainter = label.Painter;
        double width = labelPainter.Width * _SemanticNodeSizeScale;
        double height = labelPainter.Height * _SemanticNodeSizeScale;
        Offset nodeOffset = GetOffsetForTheta(labelTheta, ring) + new Offset(-width / 2.0, -height / 2.0);
        TextSpan textSpan = labelPainter.Text as TextSpan;
        CustomPainterSemantics node = new CustomPainterSemantics(rect: Rect.FromLTRB(nodeOffset.Dx - 24.0 + width / 2, nodeOffset.Dy - 24.0 + height / 2, nodeOffset.Dx + 24.0 + width / 2, nodeOffset.Dy + 24.0 + height / 2), properties: new SemanticsProperties(sortKey: new OrdinalSortKey(i.ToDouble() + ordinalOffset), selected: label.Value == SelectedValue, value: textSpan?.Text, textDirection: TextDirection, onTap: label.OnTap), tags: new Dictionary<SemanticsTag> { { new SemanticsTag("dial-label"), } });
        nodes.Add(node);
        labelTheta += labelThetaIncrement;
    }

}

PaintLabels(PrimaryOuterLabels, _DialRing.Outer);
PaintLabels(PrimaryInnerLabels, _DialRing.Inner);
return nodes;
}




public new bool ShouldRepaint(FlutterSDK.Material.Timepicker._DialPainter oldPainter)
{
    return oldPainter.PrimaryOuterLabels != PrimaryOuterLabels || oldPainter.PrimaryInnerLabels != PrimaryInnerLabels || oldPainter.SecondaryOuterLabels != SecondaryOuterLabels || oldPainter.SecondaryInnerLabels != SecondaryInnerLabels || oldPainter.BackgroundColor != BackgroundColor || oldPainter.AccentColor != AccentColor || oldPainter.Theta != Theta || oldPainter.ActiveRing != ActiveRing;
}


public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
{
    return oldPainter.PrimaryOuterLabels != PrimaryOuterLabels || oldPainter.PrimaryInnerLabels != PrimaryInnerLabels || oldPainter.SecondaryOuterLabels != SecondaryOuterLabels || oldPainter.SecondaryInnerLabels != SecondaryInnerLabels || oldPainter.BackgroundColor != BackgroundColor || oldPainter.AccentColor != AccentColor || oldPainter.Theta != Theta || oldPainter.ActiveRing != ActiveRing;
}



#endregion
}


public class _Dial : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public _Dial(FlutterSDK.Material.Time.TimeOfDay selectedTime = default(FlutterSDK.Material.Time.TimeOfDay), FlutterSDK.Material.Timepicker._TimePickerMode mode = default(FlutterSDK.Material.Timepicker._TimePickerMode), bool use24HourDials = default(bool), FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay>), VoidCallback onHourSelected = default(VoidCallback))
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Material.Time.TimeOfDay SelectedTime { get; set; }
public virtual FlutterSDK.Material.Timepicker._TimePickerMode Mode { get; set; }
public virtual bool Use24HourDials { get; set; }
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<TimeOfDay> OnChanged { get; set; }
public virtual VoidCallback OnHourSelected { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Timepicker._DialState CreateState() => new _DialState();


#endregion
}


public class _DialState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Timepicker._Dial>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
    #region constructors
    public _DialState()
    { }
    #endregion

    #region fields
    public virtual FlutterSDK.Material.Themedata.ThemeData ThemeData { get; set; }
    public virtual FlutterSDK.Material.Materiallocalizations.MaterialLocalizations Localizations { get; set; }
    public virtual FlutterSDK.Widgets.Mediaquery.MediaQueryData Media { get; set; }
    internal virtual FlutterSDK.Animation.Tween.Tween<double> _ThetaTween { get; set; }
    internal virtual FlutterSDK.Animation.Animation.Animation<double> _Theta { get; set; }
    internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ThetaController { get; set; }
    internal virtual bool _Dragging { get; set; }
    internal virtual FlutterBinding.UI.Offset _Position { get; set; }
    internal virtual FlutterBinding.UI.Offset _Center { get; set; }
    internal virtual FlutterSDK.Material.Timepicker._DialRing _ActiveRing { get; set; }
    internal virtual List<FlutterSDK.Material.Time.TimeOfDay> _AmHours { get; set; }
    internal virtual List<FlutterSDK.Material.Time.TimeOfDay> _PmHours { get; set; }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        _UpdateDialRingFromWidget();
        _ThetaController = new AnimationController(duration: TimepickerDefaultClass._KDialAnimateDuration, vsync: this);
        _ThetaTween = new Tween<double>(begin: _GetThetaForTime(Widget.SelectedTime));
        _Theta = _ThetaController.Drive(new CurveTween(curve: CurvesDefaultClass.Curves.FastOutSlowIn)).Drive(_ThetaTween);
        _ThetaController.Drive(new CurveTween(curve: CurvesDefaultClass.Curves.FastOutSlowIn)).Drive(_ThetaTween).AddListener(() => =>SetState(() =>
        {
        }
        ));
    }




    public new void DidChangeDependencies()
    {
        base.DidChangeDependencies();

        ThemeData = ThemeDefaultClass.Theme.Of(Context);
        Localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
        Media = MediaqueryDefaultClass.MediaQuery.Of(Context);
    }




    public new void DidUpdateWidget(FlutterSDK.Material.Timepicker._Dial oldWidget)
    {
        base.DidUpdateWidget(oldWidget);
        _UpdateDialRingFromWidget();
        if (Widget.Mode != oldWidget.Mode || Widget.SelectedTime != oldWidget.SelectedTime)
        {
            if (!_Dragging) _AnimateTo(_GetThetaForTime(Widget.SelectedTime));
        }

    }




    private void _UpdateDialRingFromWidget()
    {
        if (Widget.Mode == _TimePickerMode.Hour && Widget.Use24HourDials)
        {
            _ActiveRing = Widget.SelectedTime.Hour >= 1 && Widget.SelectedTime.Hour <= 12 ? _DialRing.Inner : _DialRing.Outer;
        }
        else
        {
            _ActiveRing = _DialRing.Outer;
        }

    }




    public new void Dispose()
    {
        _ThetaController.Dispose();
        base.Dispose();
    }




    private double _Nearest(double target, double a, double b)
    {
        return ((target - a).Abs() < (target - b).Abs()) ? a : b;
    }




    private void _AnimateTo(double targetTheta)
    {
        double currentTheta = _Theta.Value;
        double beginTheta = _Nearest(targetTheta, currentTheta, currentTheta + TimepickerDefaultClass._KTwoPi);
        beginTheta = _Nearest(targetTheta, beginTheta, currentTheta - TimepickerDefaultClass._KTwoPi);
        ..Begin = beginTheta..End = targetTheta;
        ..Value = 0.0;
        _ThetaController.Forward();
    }




    private double _GetThetaForTime(FlutterSDK.Material.Time.TimeOfDay time)
    {
        double fraction = Widget.Mode == _TimePickerMode.Hour ? (time.Hour / TimeDefaultClass.TimeOfDay.HoursPerPeriod) % TimeDefaultClass.TimeOfDay.HoursPerPeriod : (time.Minute / TimeDefaultClass.TimeOfDay.MinutesPerHour) % TimeDefaultClass.TimeOfDay.MinutesPerHour;
        return (Math.Dart:mathDefaultClass.Pi / 2.0 - fraction * TimepickerDefaultClass._KTwoPi)% TimepickerDefaultClass._KTwoPi;
    }




    private FlutterSDK.Material.Time.TimeOfDay _GetTimeForTheta(double theta)
    {
        double fraction = (0.25 - (theta % TimepickerDefaultClass._KTwoPi) / TimepickerDefaultClass._KTwoPi) % 1.0;
        if (Widget.Mode == _TimePickerMode.Hour)
        {
            int newHour = (fraction * TimeDefaultClass.TimeOfDay.HoursPerPeriod).Round() % TimeDefaultClass.TimeOfDay.HoursPerPeriod;
            if (Widget.Use24HourDials)
            {
                if (_ActiveRing == _DialRing.Outer)
                {
                    if (newHour != 0) newHour = (newHour + TimeDefaultClass.TimeOfDay.HoursPerPeriod) % TimeDefaultClass.TimeOfDay.HoursPerDay;
                }
                else if (newHour == 0)
                {
                    newHour = TimeDefaultClass.TimeOfDay.HoursPerPeriod;
                }

            }
            else
            {
                newHour = newHour + Widget.SelectedTime.PeriodOffset;
            }

            return Widget.SelectedTime.Replacing(hour: newHour);
        }
        else
        {
            return Widget.SelectedTime.Replacing(minute: (fraction * TimeDefaultClass.TimeOfDay.MinutesPerHour).Round() % TimeDefaultClass.TimeOfDay.MinutesPerHour);
        }

    }




    private FlutterSDK.Material.Time.TimeOfDay _NotifyOnChangedIfNeeded()
    {
        TimeOfDay current = _GetTimeForTheta(_Theta.Value);
        if (Widget.OnChanged == null) return current;
        if (current != Widget.SelectedTime) Widget.OnChanged(current);
        return current;
    }




    private void _UpdateThetaForPan()
    {
        SetState(() =>
        {
        Offset offset = _Position - _Center;
        double angle = (Math.Dart:mathDefaultClass.Atan2(offset.Dx, offset.Dy) - Math.Dart:mathDefaultClass.Pi / 2.0) % TimepickerDefaultClass._KTwoPi;
        ..Begin = angle..End = angle;
        RenderBox box = Context.FindRenderObject() as RenderBox;
        double radius = box.Size.ShortestSide / 2.0;
        if (Widget.Mode == _TimePickerMode.Hour && Widget.Use24HourDials)
        {
            if (offset.Distance * 1.5 < radius) _ActiveRing = _DialRing.Inner; else _ActiveRing = _DialRing.Outer;
        }

    }
);
}




private void _HandlePanStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details)
{

    _Dragging = true;
    RenderBox box = Context.FindRenderObject() as RenderBox;
    _Position = box.GlobalToLocal(details.GlobalPosition);
    _Center = box.Size.Center(Dart: uiDefaultClass.Offset.Zero);
    _UpdateThetaForPan();
    _NotifyOnChangedIfNeeded();
}




private void _HandlePanUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
{
    _Position += details.Delta;
    _UpdateThetaForPan();
    _NotifyOnChangedIfNeeded();
}




private void _HandlePanEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
{

    _Dragging = false;
    _Position = null;
    _Center = null;
    _AnimateTo(_GetThetaForTime(Widget.SelectedTime));
    if (Widget.Mode == _TimePickerMode.Hour)
    {
        if (Widget.OnHourSelected != null)
        {
            Widget.OnHourSelected();
        }

    }

}




private void _HandleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details)
{
    RenderBox box = Context.FindRenderObject() as RenderBox;
    _Position = box.GlobalToLocal(details.GlobalPosition);
    _Center = box.Size.Center(Dart: uiDefaultClass.Offset.Zero);
    _UpdateThetaForPan();
    TimeOfDay newTime = _NotifyOnChangedIfNeeded();
    if (Widget.Mode == _TimePickerMode.Hour)
    {
        if (Widget.Use24HourDials)
        {
            TimepickerDefaultClass._AnnounceToAccessibility(Context, Localizations.FormatDecimal(newTime.Hour));
        }
        else
        {
            TimepickerDefaultClass._AnnounceToAccessibility(Context, Localizations.FormatDecimal(newTime.HourOfPeriod));
        }

        if (Widget.OnHourSelected != null)
        {
            Widget.OnHourSelected();
        }

    }
    else
    {
        TimepickerDefaultClass._AnnounceToAccessibility(Context, Localizations.FormatDecimal(newTime.Minute));
    }

    _AnimateTo(_GetThetaForTime(_GetTimeForTheta(_Theta.Value)));
    _Dragging = false;
    _Position = null;
    _Center = null;
}




private void _SelectHour(int hour)
{
    TimepickerDefaultClass._AnnounceToAccessibility(Context, Localizations.FormatDecimal(hour));
    TimeOfDay time = default(TimeOfDay);
    if (Widget.Mode == _TimePickerMode.Hour && Widget.Use24HourDials)
    {
        _ActiveRing = hour >= 1 && hour <= 12 ? _DialRing.Inner : _DialRing.Outer;
        time = new TimeOfDay(hour: hour, minute: Widget.SelectedTime.Minute);
    }
    else
    {
        _ActiveRing = _DialRing.Outer;
        if (Widget.SelectedTime.Period == DayPeriod.Am)
        {
            time = new TimeOfDay(hour: hour, minute: Widget.SelectedTime.Minute);
        }
        else
        {
            time = new TimeOfDay(hour: hour + TimeDefaultClass.TimeOfDay.HoursPerPeriod, minute: Widget.SelectedTime.Minute);
        }

    }

    double angle = _GetThetaForTime(time);
    ..Begin = angle..End = angle;
    _NotifyOnChangedIfNeeded();
}




private void _SelectMinute(int minute)
{
    TimepickerDefaultClass._AnnounceToAccessibility(Context, Localizations.FormatDecimal(minute));
    TimeOfDay time = new TimeOfDay(hour: Widget.SelectedTime.Hour, minute: minute);
    double angle = _GetThetaForTime(time);
    ..Begin = angle..End = angle;
    _NotifyOnChangedIfNeeded();
}




private FlutterSDK.Material.Timepicker._TappableLabel _BuildTappableLabel(FlutterSDK.Material.Texttheme.TextTheme textTheme, int value, string label, VoidCallback onTap)
{
    TextStyle style = textTheme.Subtitle1;
    double labelScaleFactor = Math.Dart:mathDefaultClass.Min(MediaqueryDefaultClass.MediaQuery.Of(Context).TextScaleFactor, 2.0);
return new _TappableLabel(value: value, painter: new TextPainter(text: new TextSpan(style: style, text: label), textDirection: TextDirection.Ltr, textScaleFactor: labelScaleFactor);
new TextPainter(text: new TextSpan(style: style, text: label), textDirection: TextDirection.Ltr, textScaleFactor: labelScaleFactor).Layout(), onTap: onTap);
}




private List<FlutterSDK.Material.Timepicker._TappableLabel> _Build24HourInnerRing(FlutterSDK.Material.Texttheme.TextTheme textTheme) => new List<_TappableLabel>() { };



private List<FlutterSDK.Material.Timepicker._TappableLabel> _Build24HourOuterRing(FlutterSDK.Material.Texttheme.TextTheme textTheme) => new List<_TappableLabel>() { };



private List<FlutterSDK.Material.Timepicker._TappableLabel> _Build12HourOuterRing(FlutterSDK.Material.Texttheme.TextTheme textTheme) => new List<_TappableLabel>() { };



private List<FlutterSDK.Material.Timepicker._TappableLabel> _BuildMinutes(FlutterSDK.Material.Texttheme.TextTheme textTheme)
{
    List<TimeOfDay> _minuteMarkerValues = new List<TimeOfDay>() { new TimeOfDay(hour: 0, minute: 0), new TimeOfDay(hour: 0, minute: 5), new TimeOfDay(hour: 0, minute: 10), new TimeOfDay(hour: 0, minute: 15), new TimeOfDay(hour: 0, minute: 20), new TimeOfDay(hour: 0, minute: 25), new TimeOfDay(hour: 0, minute: 30), new TimeOfDay(hour: 0, minute: 35), new TimeOfDay(hour: 0, minute: 40), new TimeOfDay(hour: 0, minute: 45), new TimeOfDay(hour: 0, minute: 50), new TimeOfDay(hour: 0, minute: 55) };
    return new List<_TappableLabel>() { };
}




public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{
    Color backgroundColor = default(Color);
    switch (ThemeData.Brightness) { case Brightness.Light: backgroundColor = ColorsDefaultClass.Colors.Grey[200]; break; case Brightness.Dark: backgroundColor = ThemeData.BackgroundColor; break; }
    ThemeData theme = ThemeDefaultClass.Theme.Of(context);
    List<_TappableLabel> primaryOuterLabels = default(List<_TappableLabel>);
    List<_TappableLabel> primaryInnerLabels = default(List<_TappableLabel>);
    List<_TappableLabel> secondaryOuterLabels = default(List<_TappableLabel>);
    List<_TappableLabel> secondaryInnerLabels = default(List<_TappableLabel>);
    int selectedDialValue = default(int);
    switch (Widget.Mode)
    {
        case _TimePickerMode.Hour:
            if (Widget.Use24HourDials)
            {
                selectedDialValue = Widget.SelectedTime.Hour;
                primaryOuterLabels = _Build24HourOuterRing(theme.TextTheme);
                secondaryOuterLabels = _Build24HourOuterRing(theme.AccentTextTheme);
                primaryInnerLabels = _Build24HourInnerRing(theme.TextTheme);
                secondaryInnerLabels = _Build24HourInnerRing(theme.AccentTextTheme);
            }
            else
            {
                selectedDialValue = Widget.SelectedTime.HourOfPeriod;
                primaryOuterLabels = _Build12HourOuterRing(theme.TextTheme);
                secondaryOuterLabels = _Build12HourOuterRing(theme.AccentTextTheme);
            }
            break;
        case _TimePickerMode.Minute: selectedDialValue = Widget.SelectedTime.Minute; primaryOuterLabels = _BuildMinutes(theme.TextTheme); primaryInnerLabels = null; secondaryOuterLabels = _BuildMinutes(theme.AccentTextTheme); secondaryInnerLabels = null; break;
    }
    return new GestureDetector(excludeFromSemantics: true, onPanStart: _HandlePanStart, onPanUpdate: _HandlePanUpdate, onPanEnd: _HandlePanEnd, onTapUp: _HandleTapUp, child: new CustomPaint(key: new ValueKey<string>("time-picker-dial"), painter: new _DialPainter(selectedValue: selectedDialValue, primaryOuterLabels: primaryOuterLabels, primaryInnerLabels: primaryInnerLabels, secondaryOuterLabels: secondaryOuterLabels, secondaryInnerLabels: secondaryInnerLabels, backgroundColor: backgroundColor, accentColor: ThemeData.AccentColor, theta: _Theta.Value, activeRing: _ActiveRing, textDirection: BasicDefaultClass.Directionality.Of(context))));
}



#endregion
}


/// <Summary>
/// A material design time picker designed to appear inside a popup dialog.
///
/// Pass this widget to [showDialog]. The value returned by [showDialog] is the
/// selected [TimeOfDay] if the user taps the "OK" button, or null if the user
/// taps the "CANCEL" button. The selected time is reported by calling
/// [Navigator.pop].
/// </Summary>
public class _TimePickerDialog : FlutterSDK.Widgets.Framework.StatefulWidget
{
    #region constructors
    public _TimePickerDialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Time.TimeOfDay initialTime = default(FlutterSDK.Material.Time.TimeOfDay))
    : base(key: key)

}
#endregion

#region fields
public virtual FlutterSDK.Material.Time.TimeOfDay InitialTime { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Timepicker._TimePickerDialogState CreateState() => new _TimePickerDialogState();


#endregion
}


public class _TimePickerDialogState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Timepicker._TimePickerDialog>
{
    #region constructors
    public _TimePickerDialogState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Material.Timepicker._TimePickerMode _Mode { get; set; }
    internal virtual FlutterSDK.Material.Timepicker._TimePickerMode _LastModeAnnounced { get; set; }
    internal virtual FlutterSDK.Material.Time.TimeOfDay _SelectedTime { get; set; }
    internal virtual Timer _VibrateTimer { get; set; }
    public virtual FlutterSDK.Material.Materiallocalizations.MaterialLocalizations Localizations { get; set; }
    internal virtual bool _AnnouncedInitialTime { get; set; }
    public virtual FlutterSDK.Material.Time.TimeOfDay SelectedTime { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        _SelectedTime = Widget.InitialTime;
    }




    public new void DidChangeDependencies()
    {
        base.DidChangeDependencies();
        Localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
        _AnnounceInitialTimeOnce();
        _AnnounceModeOnce();
    }




    private void _Vibrate()
    {
        switch (ThemeDefaultClass.Theme.Of(Context).Platform)
        {
            case TargetPlatform.Android:
            case TargetPlatform.Fuchsia:
            case TargetPlatform.Linux:
            case TargetPlatform.Windows:
                _VibrateTimer?.Cancel(); _VibrateTimer = new Timer(TimepickerDefaultClass._KVibrateCommitDelay, () =>
                {
                    HapticfeedbackDefaultClass.HapticFeedback.Vibrate();
                    _VibrateTimer = null;
                }
); break;
            case TargetPlatform.IOS: case TargetPlatform.MacOS: break;
        }
    }




    private void _HandleModeChanged(FlutterSDK.Material.Timepicker._TimePickerMode mode)
    {
        _Vibrate();
        SetState(() =>
        {
            _Mode = mode;
            _AnnounceModeOnce();
        }
        );
    }




    private void _AnnounceModeOnce()
    {
        if (_LastModeAnnounced == _Mode)
        {
            return;
        }

        switch (_Mode) { case _TimePickerMode.Hour: TimepickerDefaultClass._AnnounceToAccessibility(Context, Localizations.TimePickerHourModeAnnouncement); break; case _TimePickerMode.Minute: TimepickerDefaultClass._AnnounceToAccessibility(Context, Localizations.TimePickerMinuteModeAnnouncement); break; }
        _LastModeAnnounced = _Mode;
    }




    private void _AnnounceInitialTimeOnce()
    {
        if (_AnnouncedInitialTime) return;
        MediaQueryData media = MediaqueryDefaultClass.MediaQuery.Of(Context);
        MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
        TimepickerDefaultClass._AnnounceToAccessibility(Context, localizations.FormatTimeOfDay(Widget.InitialTime, alwaysUse24HourFormat: media.AlwaysUse24HourFormat));
        _AnnouncedInitialTime = true;
    }




    private void _HandleTimeChanged(FlutterSDK.Material.Time.TimeOfDay value)
    {
        _Vibrate();
        SetState(() =>
        {
            _SelectedTime = value;
        }
        );
    }




    private void _HandleHourSelected()
    {
        SetState(() =>
        {
            _Mode = _TimePickerMode.Minute;
        }
        );
    }




    private void _HandleCancel()
    {
        NavigatorDefaultClass.Navigator.Pop(Context);
    }




    private void _HandleOk()
    {
        NavigatorDefaultClass.Navigator.Pop(Context, _SelectedTime);
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {

        MediaQueryData media = MediaqueryDefaultClass.MediaQuery.Of(context);
        TimeOfDayFormat timeOfDayFormat = Localizations.TimeOfDayFormat(alwaysUse24HourFormat: media.AlwaysUse24HourFormat);
        bool use24HourDials = TimeDefaultClass.HourFormat(of: timeOfDayFormat) != HourFormat.h;
        ThemeData theme = ThemeDefaultClass.Theme.Of(context);
        Widget picker = new Padding(padding: EdgeInsets.All(16.0), child: new AspectRatio(aspectRatio: 1.0, child: new _Dial(mode: _Mode, use24HourDials: use24HourDials, selectedTime: _SelectedTime, onChanged: _HandleTimeChanged, onHourSelected: _HandleHourSelected)));
        Widget actions = new ButtonBar(children: new List<Widget>() { new FlatButton(child: new Text(Localizations.CancelButtonLabel), onPressed: _HandleCancel), new FlatButton(child: new Text(Localizations.OkButtonLabel), onPressed: _HandleOk) });
        Dialog dialog = new Dialog(child: new OrientationBuilder(builder: (BuildContext context, Orientation orientation) =>
        {
            Widget header = new _TimePickerHeader(selectedTime: _SelectedTime, mode: _Mode, orientation: orientation, onModeChanged: _HandleModeChanged, onChanged: _HandleTimeChanged, use24HourDials: use24HourDials);
            Widget pickerAndActions = new Container(color: theme.DialogBackgroundColor, child: new Column(mainAxisSize: MainAxisSize.Min, children: new List<Widget>() { new Expanded(child: picker), actions }));
            double timePickerHeightPortrait = default(double);
            double timePickerHeightLandscape = default(double);
            switch (theme.MaterialTapTargetSize) { case MaterialTapTargetSize.Padded: timePickerHeightPortrait = TimepickerDefaultClass._KTimePickerHeightPortrait; timePickerHeightLandscape = TimepickerDefaultClass._KTimePickerHeightLandscape; break; case MaterialTapTargetSize.ShrinkWrap: timePickerHeightPortrait = TimepickerDefaultClass._KTimePickerHeightPortraitCollapsed; timePickerHeightLandscape = TimepickerDefaultClass._KTimePickerHeightLandscapeCollapsed; break; }

            switch (orientation) { case Orientation.Portrait: return new SizedBox(width: TimepickerDefaultClass._KTimePickerWidthPortrait, height: timePickerHeightPortrait, child: new Column(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: new List<Widget>() { header, new Expanded(child: pickerAndActions) })); case Orientation.Landscape: return new SizedBox(width: TimepickerDefaultClass._KTimePickerWidthLandscape, height: timePickerHeightLandscape, child: new Row(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: new List<Widget>() { header, new Flexible(child: pickerAndActions) })); }
            return null;
        }
        ));
        return new Theme(data: theme.CopyWith(dialogBackgroundColor: ColorsDefaultClass.Colors.Transparent), child: dialog);
    }




    public new void Dispose()
    {
        _VibrateTimer?.Cancel();
        _VibrateTimer = null;
        base.Dispose();
    }



    #endregion
}


public enum _TimePickerMode
{

    Hour,
    Minute,
}


public enum _TimePickerHeaderId
{

    Hour,
    Colon,
    Minute,
    Period,
    Dot,
    HString,
}


public enum _DialRing
{

    Outer,
    Inner,
}

}
