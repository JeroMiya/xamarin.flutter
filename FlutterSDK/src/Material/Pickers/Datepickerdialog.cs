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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Material.Pickers.Datepickerdialog
{
    internal static class DatepickerdialogDefaultClass
    {
        public static Size _CalendarPortraitDialogSize = default(Size);
        public static Size _CalendarLandscapeDialogSize = default(Size);
        public static Size _InputPortraitDialogSize = default(Size);
        public static Size _InputLandscapeDialogSize = default(Size);
        public static TimeSpan _DialogSizeAnimationDuration = default(TimeSpan);
        internal static Future<DateTime> ShowDatePicker(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), DateTime initialDate = default(DateTime), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), FlutterSDK.Material.Pickers.Datepickercommon.DatePickerEntryMode initialEntryMode = default(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerEntryMode), FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate), string helpText = default(string), string cancelText = default(string), string confirmText = default(string), Locale locale = default(Locale), bool useRootNavigator = true, FlutterSDK.Widgets.Navigator.RouteSettings routeSettings = default(FlutterSDK.Widgets.Navigator.RouteSettings), TextDirection textDirection = default(TextDirection), FlutterSDK.Widgets.Framework.TransitionBuilder builder = default(FlutterSDK.Widgets.Framework.TransitionBuilder), FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode initialDatePickerMode = default(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode), string errorFormatText = default(string), string errorInvalidText = default(string), string fieldHintText = default(string), string fieldLabelText = default(string))
        {
            throw new NotImplementedException();
        }

    }

    public class _DatePickerDialog : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _DatePickerDialog(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), DateTime initialDate = default(DateTime), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), FlutterSDK.Material.Pickers.Datepickercommon.DatePickerEntryMode initialEntryMode = default(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerEntryMode), FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate), string cancelText = default(string), string confirmText = default(string), string helpText = default(string), FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode initialCalendarMode = default(FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode), string errorFormatText = default(string), string errorInvalidText = default(string), string fieldHintText = default(string), string fieldLabelText = default(string))
        : base(key: key)
    




}


    #endregion

    #region fields
    public virtual DateTime InitialDate { get; set; }
    public virtual DateTime FirstDate { get; set; }
    public virtual DateTime LastDate { get; set; }
    public virtual FlutterSDK.Material.Pickers.Datepickercommon.DatePickerEntryMode InitialEntryMode { get; set; }
    public virtual FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate SelectableDayPredicate { get; set; }
    public virtual string CancelText { get; set; }
    public virtual string ConfirmText { get; set; }
    public virtual string HelpText { get; set; }
    public virtual FlutterSDK.Material.Pickers.Datepickercommon.DatePickerMode InitialCalendarMode { get; set; }
    public virtual string ErrorFormatText { get; set; }
    public virtual string ErrorInvalidText { get; set; }
    public virtual string FieldHintText { get; set; }
    public virtual string FieldLabelText { get; set; }
    #endregion

    #region methods

    public new FlutterSDK.Material.Pickers.Datepickerdialog._DatePickerDialogState CreateState() => new _DatePickerDialogState();


    #endregion
}


public class _DatePickerDialogState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Datepickerdialog._DatePickerDialog>
{
    #region constructors
    public _DatePickerDialogState()
    { }
    #endregion

    #region fields
    internal virtual FlutterSDK.Material.Pickers.Datepickercommon.DatePickerEntryMode _EntryMode { get; set; }
    internal virtual DateTime _SelectedDate { get; set; }
    internal virtual bool _AutoValidate { get; set; }
    internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _CalendarPickerKey { get; set; }
    internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Form.FormState> _FormKey { get; set; }
    #endregion

    #region methods

    public new void InitState()
    {
        base.InitState();
        _EntryMode = Widget.InitialEntryMode;
        _SelectedDate = Widget.InitialDate;
        _AutoValidate = false;
    }




    private void _HandleOk()
    {
        if (_EntryMode == DatePickerEntryMode.Input)
        {
            FormState form = _FormKey.CurrentState;
            if (!form.Validate())
            {
                SetState(() => =>_AutoValidate = true);
                return;
            }

            form.Save();
        }

        NavigatorDefaultClass.Navigator.Pop(Context, _SelectedDate);
    }




    private void _HandleCancel()
    {
        NavigatorDefaultClass.Navigator.Pop(Context);
    }




    private void _HandelEntryModeToggle()
    {
        SetState(() =>
        {
            switch (_EntryMode) { case DatePickerEntryMode.Calendar: _AutoValidate = false; _EntryMode = DatePickerEntryMode.Input; break; case DatePickerEntryMode.Input: _FormKey.CurrentState.Save(); _EntryMode = DatePickerEntryMode.Calendar; break; }
        }
        );
    }




    private void _HandleDateChanged(DateTime date)
    {
        SetState(() => =>_SelectedDate = date);
    }




    private Size _DialogSize(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        Orientation orientation = MediaqueryDefaultClass.MediaQuery.Of(context).Orientation;
        switch (_EntryMode) { case DatePickerEntryMode.Calendar: switch (orientation) { case Orientation.Portrait: return DatepickerdialogDefaultClass._CalendarPortraitDialogSize; case Orientation.Landscape: return DatepickerdialogDefaultClass._CalendarLandscapeDialogSize; } break; case DatePickerEntryMode.Input: switch (orientation) { case Orientation.Portrait: return DatepickerdialogDefaultClass._InputPortraitDialogSize; case Orientation.Landscape: return DatepickerdialogDefaultClass._InputLandscapeDialogSize; } break; }
        return null;
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {
        ThemeData theme = ThemeDefaultClass.Theme.Of(context);
        ColorScheme colorScheme = theme.ColorScheme;
        MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
        Orientation orientation = MediaqueryDefaultClass.MediaQuery.Of(context).Orientation;
        TextTheme textTheme = theme.TextTheme;
        double textScaleFactor = Math.Dart:mathDefaultClass.Min(MediaqueryDefaultClass.MediaQuery.Of(context).TextScaleFactor, 1.3);
        string dateText = _SelectedDate != null ? localizations.FormatMediumDate(_SelectedDate) : "Date";
        Color dateColor = colorScheme.Brightness == Brightness.Light ? colorScheme.OnPrimary : colorScheme.OnSurface;
        TextStyle dateStyle = orientation == Orientation.Landscape ? textTheme.Headline5?.CopyWith(color: dateColor) : textTheme.Headline4?.CopyWith(color: dateColor);
        Widget actions = new ButtonBar(buttonTextTheme: ButtonTextTheme.Primary, layoutBehavior: ButtonBarLayoutBehavior.Constrained, children: new List<Widget>() { new FlatButton(child: new Text(Widget.CancelText ?? localizations.CancelButtonLabel), onPressed: _HandleCancel), new FlatButton(child: new Text(Widget.ConfirmText ?? localizations.OkButtonLabel), onPressed: _HandleOk) });
        Widget picker = default(Widget);
        IconData entryModeIcon = default(IconData);
        string entryModeTooltip = default(string);
        switch (_EntryMode) { case DatePickerEntryMode.Calendar: picker = new CalendarDatePicker(key: _CalendarPickerKey, initialDate: _SelectedDate, firstDate: Widget.FirstDate, lastDate: Widget.LastDate, onDateChanged: _HandleDateChanged, selectableDayPredicate: Widget.SelectableDayPredicate, initialCalendarMode: Widget.InitialCalendarMode); entryModeIcon = IconsDefaultClass.Icons.Edit; entryModeTooltip = "Switch to input"; break; case DatePickerEntryMode.Input: picker = new Form(key: _FormKey, autovalidate: _AutoValidate, child: new InputDatePickerFormField(initialDate: _SelectedDate, firstDate: Widget.FirstDate, lastDate: Widget.LastDate, onDateSubmitted: _HandleDateChanged, onDateSaved: _HandleDateChanged, selectableDayPredicate: Widget.SelectableDayPredicate, errorFormatText: Widget.ErrorFormatText, errorInvalidText: Widget.ErrorInvalidText, fieldHintText: Widget.FieldHintText, fieldLabelText: Widget.FieldLabelText, autofocus: true)); entryModeIcon = IconsDefaultClass.Icons.Calendar_today; entryModeTooltip = "Switch to calendar"; break; }
        Widget header = new DatePickerHeader(helpText: Widget.HelpText ?? "SELECT DATE", titleText: dateText, titleStyle: dateStyle, orientation: orientation, isShort: orientation == Orientation.Landscape, icon: entryModeIcon, iconTooltip: entryModeTooltip, onIconPressed: _HandelEntryModeToggle);
        Size dialogSize = _DialogSize(context) * textScaleFactor;
        DialogTheme dialogTheme = ThemeDefaultClass.Theme.Of(context).DialogTheme;
        return new Dialog(child: new AnimatedContainer(width: dialogSize.Width, height: dialogSize.Height, duration: DatepickerdialogDefaultClass._DialogSizeAnimationDuration, curve: CurvesDefaultClass.Curves.EaseIn, child: new MediaQuery(data: MediaqueryDefaultClass.MediaQuery.Of(context).CopyWith(textScaleFactor: textScaleFactor), child: new Builder(builder: (BuildContext context) =>
        {
            switch (orientation) { case Orientation.Portrait: return new Column(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: new List<Widget>() { header, new Expanded(child: picker), actions }); case Orientation.Landscape: return new Row(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: new List<Widget>() { header, new Flexible(child: new Column(mainAxisSize: MainAxisSize.Min, crossAxisAlignment: CrossAxisAlignment.Stretch, children: new List<Widget>() { new Expanded(child: picker), actions })) }); }
            return null;
        }
        ))), insetPadding: EdgeInsets.Symmetric(horizontal: 16.0, vertical: 24.0), shape: dialogTheme.Shape ?? new RoundedRectangleBorder(borderRadius: BorderRadius.All(Radius.Circular(4.0))), clipBehavior: Clip.AntiAlias);
    }



    #endregion
}

}
