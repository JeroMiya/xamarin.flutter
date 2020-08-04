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
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
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
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Tabs;
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
namespace FlutterSDK.Material.Pickers.Datepickerdeprecated
{
    internal static class DatepickerdeprecatedDefaultClass
    {
        public static TimeSpan _KMonthScrollDuration = default(TimeSpan);
        public static double _KDayPickerRowHeight = default(double);
        public static int _KMaxDayPickerRowCount = default(int);
        public static double _KMaxDayPickerHeight = default(double);
        public static FlutterSDK.Material.Pickers.Datepickerdeprecated._DayPickerGridDelegate _KDayPickerGridDelegate = default(FlutterSDK.Material.Pickers.Datepickerdeprecated._DayPickerGridDelegate);
    }

    public class _DayPickerGridDelegate : FlutterSDK.Rendering.Slivergrid.SliverGridDelegate
    {
        public _DayPickerGridDelegate()
        {

        }

        public new FlutterSDK.Rendering.Slivergrid.SliverGridLayout GetLayout(FlutterSDK.Rendering.Sliver.SliverConstraints constraints)
        {
            int columnCount = Dart.CoreDefaultClass.DateTime.DaysPerWeek;
            double tileWidth = constraints.CrossAxisExtent / columnCount;
            double viewTileHeight = constraints.ViewportMainAxisExtent / (DatepickerdeprecatedDefaultClass._KMaxDayPickerRowCount + 1);
            double tileHeight = Dart.Math.MathDefaultClass.Max(DatepickerdeprecatedDefaultClass._KDayPickerRowHeight, viewTileHeight);
            return new SliverGridRegularTileLayout(crossAxisCount: columnCount, mainAxisStride: tileHeight, crossAxisStride: tileWidth, childMainAxisExtent: tileHeight, childCrossAxisExtent: tileWidth, reverseCrossAxis: BasictypesDefaultClass.AxisDirectionIsReversed(constraints.CrossAxisDirection));
        }




        public new bool ShouldRelayout(FlutterSDK.Material.Pickers.Datepickerdeprecated._DayPickerGridDelegate oldDelegate) => false;

        public new bool ShouldRelayout(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate oldDelegate) => false;


    }


    /// <Summary>
    /// Displays the days of a given month and allows choosing a day.
    ///
    /// The days are arranged in a rectangular grid with one column for each day of
    /// the week.
    ///
    /// The day picker widget is rarely used directly. Instead, consider using
    /// [showDatePicker], which creates a date picker dialog.
    ///
    /// See also:
    ///
    ///  * [showDatePicker], which shows a dialog that contains a material design
    ///    date picker.
    ///  * [showTimePicker], which shows a dialog that contains a material design
    ///    time picker.
    ///
    /// </Summary>
    public class DayPicker : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a day picker.
        ///
        /// Rarely used directly. Instead, typically used as part of a [MonthPicker].
        /// </Summary>
        public DayPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), DateTime selectedDate = default(DateTime), DateTime currentDate = default(DateTime), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), DateTime displayedMonth = default(DateTime), FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.SelectedDate = selectedDate;
            this.CurrentDate = currentDate;
            this.OnChanged = onChanged;
            this.FirstDate = firstDate;
            this.LastDate = lastDate;
            this.DisplayedMonth = displayedMonth;
            this.SelectableDayPredicate = selectableDayPredicate;
            this.DragStartBehavior = dragStartBehavior;
        }
        /// <Summary>
        /// The currently selected date.
        ///
        /// This date is highlighted in the picker.
        /// </Summary>
        public virtual DateTime SelectedDate { get; set; }
        /// <Summary>
        /// The current date at the time the picker is displayed.
        /// </Summary>
        public virtual DateTime CurrentDate { get; set; }
        /// <Summary>
        /// Called when the user picks a day.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnChanged { get; set; }
        /// <Summary>
        /// The earliest date the user is permitted to pick.
        /// </Summary>
        public virtual DateTime FirstDate { get; set; }
        /// <Summary>
        /// The latest date the user is permitted to pick.
        /// </Summary>
        public virtual DateTime LastDate { get; set; }
        /// <Summary>
        /// The month whose days are displayed by this picker.
        /// </Summary>
        public virtual DateTime DisplayedMonth { get; set; }
        /// <Summary>
        /// Optional user supplied predicate function to customize selectable days.
        /// </Summary>
        public virtual FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate SelectableDayPredicate { get; set; }
        /// <Summary>
        /// Determines the way that drag start behavior is handled.
        ///
        /// If set to [DragStartBehavior.start], the drag gesture used to scroll a
        /// date picker wheel will begin upon the detection of a drag gesture. If set
        /// to [DragStartBehavior.down] it will begin when a down event is first
        /// detected.
        ///
        /// In general, setting this to [DragStartBehavior.start] will make drag
        /// animation smoother and setting it to [DragStartBehavior.down] will make
        /// drag behavior feel slightly more reactive.
        ///
        /// By default, the drag start behavior is [DragStartBehavior.start].
        ///
        /// See also:
        ///
        ///  * [DragGestureRecognizer.dragStartBehavior], which gives an example for the different behaviors.
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        internal virtual List<int> _DaysInMonth { get; set; }

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




        /// <Summary>
        /// Returns the number of days in a month, according to the proleptic
        /// Gregorian calendar.
        ///
        /// This applies the leap year logic introduced by the Gregorian reforms of
        /// 1582. It will not give valid results for dates prior to that time.
        /// </Summary>
        public virtual int GetDaysInMonth(int year, int month)
        {
            if (month == Dart.CoreDefaultClass.DateTime.February)
            {
                bool isLeapYear = (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0);
                if (isLeapYear) return 29;
                return 28;
            }

            return _DaysInMonth[month - 1];
        }




        /// <Summary>
        /// Computes the offset from the first day of week that the first day of the
        /// [month] falls on.
        ///
        /// For example, September 1, 2017 falls on a Friday, which in the calendar
        /// localized for United States English appears as:
        ///
        /// ```
        /// S M T W T F S
        /// _ _ _ _ _ 1 2
        /// ```
        ///
        /// The offset for the first day of the months is the number of leading blanks
        /// in the calendar, i.e. 5.
        ///
        /// The same date localized for the Russian calendar has a different offset,
        /// because the first day of week is Monday rather than Sunday:
        ///
        /// ```
        /// M T W T F S S
        /// _ _ _ _ 1 2 3
        /// ```
        ///
        /// So the offset is 4, rather than 5.
        ///
        /// This code consolidates the following:
        ///
        /// - [DateTime.weekday] provides a 1-based index into days of week, with 1
        ///   falling on Monday.
        /// - [MaterialLocalizations.firstDayOfWeekIndex] provides a 0-based index
        ///   into the [MaterialLocalizations.narrowWeekdays] list.
        /// - [MaterialLocalizations.narrowWeekdays] list provides localized names of
        ///   days of week, always starting with Sunday and ending with Saturday.
        /// </Summary>
        private int _ComputeFirstDayOffset(int year, int month, FlutterSDK.Material.Materiallocalizations.MaterialLocalizations localizations)
        {
            int weekdayFromMonday = new DateTime(year, month).Weekday - 1;
            int firstDayOfWeekFromSunday = localizations.FirstDayOfWeekIndex;
            int firstDayOfWeekFromMonday = (firstDayOfWeekFromSunday - 1) % 7;
            return (weekdayFromMonday - firstDayOfWeekFromMonday) % 7;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
            int year = DisplayedMonth.Year;
            int month = DisplayedMonth.Month;
            int daysInMonth = GetDaysInMonth(year, month);
            int firstDayOffset = _ComputeFirstDayOffset(year, month, localizations);
            List<Widget> labels = new List<Widget>() { /* ..._GetDayHeaders(themeData.TextTheme.Caption, localizations), */ };
            for (int i = 0; true; i += 1)
            {
                int day = i - firstDayOffset + 1;
                if (day > daysInMonth) break;
                if (day < 1)
                {
                    labels.Add(new Container());
                }
                else
                {
                    DateTime dayToBuild = new DateTime(year, month, day);
                    bool disabled = dayToBuild.IsAfter(LastDate) || dayToBuild.IsBefore(FirstDate) || (SelectableDayPredicate != null && !SelectableDayPredicate(dayToBuild));
                    BoxDecoration decoration = default(BoxDecoration);
                    TextStyle itemStyle = themeData.TextTheme.BodyText2;
                    bool isSelectedDay = SelectedDate.Year == year && SelectedDate.Month == month && SelectedDate.Day == day;
                    if (isSelectedDay)
                    {
                        itemStyle = themeData.AccentTextTheme.BodyText1;
                        decoration = new BoxDecoration(color: themeData.AccentColor, shape: BoxShape.Circle);
                    }
                    else if (disabled)
                    {
                        itemStyle = themeData.TextTheme.BodyText2.CopyWith(color: themeData.DisabledColor);
                    }
                    else if (CurrentDate.Year == year && CurrentDate.Month == month && CurrentDate.Day == day)
                    {
                        itemStyle = themeData.TextTheme.BodyText1.CopyWith(color: themeData.AccentColor);
                    }

                    Widget dayWidget = new Container(decoration: decoration, child: new Center(child: new Semantics(label: $"'{localizations.FormatDecimal(day)}, {localizations.FormatFullDate(dayToBuild)}'", selected: isSelectedDay, sortKey: new OrdinalSortKey(day.ToDouble()), child: new ExcludeSemantics(child: new Text(localizations.FormatDecimal(day), style: itemStyle)))));
                    if (!disabled)
                    {
                        dayWidget = new GestureDetector(behavior: HitTestBehavior.Opaque, onTap: () =>
                        {
                            OnChanged(dayToBuild);
                        }
                        , child: dayWidget, dragStartBehavior: DragStartBehavior);
                    }

                    labels.Add(dayWidget);
                }

            }

            return new Padding(padding: EdgeInsets.Symmetric(horizontal: 8.0), child: new Column(children: new List<Widget>() { new Container(height: DatepickerdeprecatedDefaultClass._KDayPickerRowHeight, child: new Center(child: new ExcludeSemantics(child: new Text(localizations.FormatMonthYear(DisplayedMonth), style: themeData.TextTheme.Subtitle1)))), new Flexible(child: GridView.Custom(gridDelegate: DatepickerdeprecatedDefaultClass._KDayPickerGridDelegate, childrenDelegate: new SliverChildListDelegate(labels, addRepaintBoundaries: false), padding: EdgeinsetsDefaultClass.EdgeInsets.Zero)) }));
        }



    }


    /// <Summary>
    /// A scrollable list of months to allow picking a month.
    ///
    /// Shows the days of each month in a rectangular grid with one column for each
    /// day of the week.
    ///
    /// The month picker widget is rarely used directly. Instead, consider using
    /// [showDatePicker], which creates a date picker dialog.
    ///
    /// See also:
    ///
    ///  * [showDatePicker], which shows a dialog that contains a material design
    ///    date picker.
    ///  * [showTimePicker], which shows a dialog that contains a material design
    ///    time picker.
    ///
    /// </Summary>
    public class MonthPicker : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a month picker.
        ///
        /// Rarely used directly. Instead, typically used as part of the dialog shown
        /// by [showDatePicker].
        /// </Summary>
        public MonthPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), DateTime selectedDate = default(DateTime), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate selectableDayPredicate = default(FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.SelectedDate = selectedDate;
            this.OnChanged = onChanged;
            this.FirstDate = firstDate;
            this.LastDate = lastDate;
            this.SelectableDayPredicate = selectableDayPredicate;
            this.DragStartBehavior = dragStartBehavior;
        }
        /// <Summary>
        /// The currently selected date.
        ///
        /// This date is highlighted in the picker.
        /// </Summary>
        public virtual DateTime SelectedDate { get; set; }
        /// <Summary>
        /// Called when the user picks a month.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnChanged { get; set; }
        /// <Summary>
        /// The earliest date the user is permitted to pick.
        /// </Summary>
        public virtual DateTime FirstDate { get; set; }
        /// <Summary>
        /// The latest date the user is permitted to pick.
        /// </Summary>
        public virtual DateTime LastDate { get; set; }
        /// <Summary>
        /// Optional user supplied predicate function to customize selectable days.
        /// </Summary>
        public virtual FlutterSDK.Material.Pickers.Datepickercommon.SelectableDayPredicate SelectableDayPredicate { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.scrollable.dragStartBehavior}
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }

        public new FlutterSDK.Material.Pickers.Datepickerdeprecated._MonthPickerState CreateState() => new _MonthPickerState();


    }


    public class _MonthPickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Datepickerdeprecated.MonthPicker>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _MonthPickerState()
        { }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _ChevronOpacityTween { get; set; }
        public virtual FlutterSDK.Material.Materiallocalizations.MaterialLocalizations Localizations { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        internal virtual DateTime _TodayDate { get; set; }
        internal virtual DateTime _CurrentDisplayedMonthDate { get; set; }
        internal virtual Timer _Timer { get; set; }
        internal virtual FlutterSDK.Widgets.Pageview.PageController _DayPickerController { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ChevronOpacityController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _ChevronOpacityAnimation { get; set; }
        internal virtual DateTime _PreviousMonthDate { get; set; }
        internal virtual DateTime _NextMonthDate { get; set; }
        internal virtual bool _IsDisplayingFirstMonth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsDisplayingLastMonth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            int monthPage = _MonthDelta(Widget.FirstDate, Widget.SelectedDate);
            _DayPickerController = new PageController(initialPage: monthPage);
            _HandleMonthPageChanged(monthPage);
            _UpdateCurrentDate();
            _ChevronOpacityController = new AnimationController(duration: new TimeSpan(milliseconds: 250), vsync: this);
            _ChevronOpacityAnimation = _ChevronOpacityController.Drive(_ChevronOpacityTween);
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Pickers.Datepickerdeprecated.MonthPicker oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.SelectedDate != oldWidget.SelectedDate)
            {
                int monthPage = _MonthDelta(Widget.FirstDate, Widget.SelectedDate);
                _DayPickerController = new PageController(initialPage: monthPage);
                _HandleMonthPageChanged(monthPage);
            }

        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            Localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);
            TextDirection = BasicDefaultClass.Directionality.Of(Context);
        }




        private void _UpdateCurrentDate()
        {
            _TodayDate = DateTime.Now();
            DateTime tomorrow = new DateTime(_TodayDate.Year, _TodayDate.Month, _TodayDate.Day + 1);
            TimeSpan timeUntilTomorrow = tomorrow.Difference(_TodayDate);
            timeUntilTomorrow += new TimeSpan(seconds: 1);
            _Timer?.Cancel();
            _Timer = new Timer(timeUntilTomorrow, () =>
            {
                SetState(() =>
                {
                    _UpdateCurrentDate();
                }
                );
            }
            );
        }




        private int _MonthDelta(DateTime startDate, DateTime endDate)
        {
            return (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month;
        }




        /// <Summary>
        /// Add months to a month truncated date.
        /// </Summary>
        private DateTime _AddMonthsToMonthDate(DateTime monthDate, int monthsToAdd)
        {
            return new DateTime(monthDate.Year + monthsToAdd~/ 12, monthDate.Month + monthsToAdd % 12);
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildItems(FlutterSDK.Widgets.Framework.BuildContext context, int index)
        {
            DateTime month = _AddMonthsToMonthDate(Widget.FirstDate, index);
            return new DayPicker(key: new ValueKey<DateTime>(month), selectedDate: Widget.SelectedDate, currentDate: _TodayDate, onChanged: Widget.OnChanged, firstDate: Widget.FirstDate, lastDate: Widget.LastDate, displayedMonth: month, selectableDayPredicate: Widget.SelectableDayPredicate, dragStartBehavior: Widget.DragStartBehavior);
        }




        private void _HandleNextMonth()
        {
            if (!_IsDisplayingLastMonth)
            {
                SemanticsserviceDefaultClass.SemanticsService.Announce(Localizations.FormatMonthYear(_NextMonthDate), TextDirection);
                _DayPickerController.NextPage(duration: DatepickerdeprecatedDefaultClass._KMonthScrollDuration, curve: CurvesDefaultClass.Curves.Ease);
            }

        }




        private void _HandlePreviousMonth()
        {
            if (!_IsDisplayingFirstMonth)
            {
                SemanticsserviceDefaultClass.SemanticsService.Announce(Localizations.FormatMonthYear(_PreviousMonthDate), TextDirection);
                _DayPickerController.PreviousPage(duration: DatepickerdeprecatedDefaultClass._KMonthScrollDuration, curve: CurvesDefaultClass.Curves.Ease);
            }

        }




        private void _HandleMonthPageChanged(int monthPage)
        {
            SetState(() =>
            {
                _PreviousMonthDate = _AddMonthsToMonthDate(Widget.FirstDate, monthPage - 1);
                _CurrentDisplayedMonthDate = _AddMonthsToMonthDate(Widget.FirstDate, monthPage);
                _NextMonthDate = _AddMonthsToMonthDate(Widget.FirstDate, monthPage + 1);
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new SizedBox(height: DatepickerdeprecatedDefaultClass._KMaxDayPickerHeight, child: new Stack(children: new List<Widget>(){new Semantics(sortKey:DatepickerdeprecatedDefaultClass._MonthPickerSortKey.Calendar, child:new NotificationListener<ScrollStartNotification>(onNotification:(_) => {
_ChevronOpacityController.Forward();
return false ;
}
, child:new NotificationListener<ScrollEndNotification>(onNotification:(_) => {
_ChevronOpacityController.Reverse();
return false ;
}
, child:PageView.Builder(dragStartBehavior:Widget.DragStartBehavior, key:new ValueKey<DateTime>(Widget.SelectedDate), controller:_DayPickerController, scrollDirection:Axis.Horizontal, itemCount:_MonthDelta(Widget.FirstDate, Widget.LastDate)+1, itemBuilder:_BuildItems, onPageChanged:_HandleMonthPageChanged)))), new PositionedDirectional(top:0.0, start:8.0, child:new Semantics(sortKey:DatepickerdeprecatedDefaultClass._MonthPickerSortKey.PreviousMonth, child:new FadeTransition(opacity:_ChevronOpacityAnimation, child:new IconButton(icon:new Icon(IconsDefaultClass.Icons.Chevron_left), tooltip:_IsDisplayingFirstMonth?null :$"'{Localizations.PreviousMonthTooltip} {Localizations.FormatMonthYear(_PreviousMonthDate)}'", onPressed:_IsDisplayingFirstMonth?null :_HandlePreviousMonth)))), new PositionedDirectional(top:0.0, end:8.0, child:new Semantics(sortKey:DatepickerdeprecatedDefaultClass._MonthPickerSortKey.NextMonth, child:new FadeTransition(opacity:_ChevronOpacityAnimation, child:new IconButton(icon:new Icon(IconsDefaultClass.Icons.Chevron_right), tooltip:_IsDisplayingLastMonth?null :$"'{Localizations.NextMonthTooltip} {Localizations.FormatMonthYear(_NextMonthDate)}'", onPressed:_IsDisplayingLastMonth?null :_HandleNextMonth))))}));
        }




        public new void Dispose()
        {
            _Timer?.Cancel();
            _ChevronOpacityController?.Dispose();
            _DayPickerController?.Dispose();
            base.Dispose();
        }



    }


    public class _MonthPickerSortKey : FlutterSDK.Semantics.Semantics.OrdinalSortKey
    {
        public _MonthPickerSortKey(double order)
        : base(order)
        {

        }
        public virtual FlutterSDK.Material.Pickers.Datepickerdeprecated._MonthPickerSortKey PreviousMonth { get; set; }
        public virtual FlutterSDK.Material.Pickers.Datepickerdeprecated._MonthPickerSortKey NextMonth { get; set; }
        public virtual FlutterSDK.Material.Pickers.Datepickerdeprecated._MonthPickerSortKey Calendar { get; set; }
    }


    /// <Summary>
    /// A scrollable list of years to allow picking a year.
    ///
    /// The year picker widget is rarely used directly. Instead, consider using
    /// [showDatePicker], which creates a date picker dialog.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// See also:
    ///
    ///  * [showDatePicker], which shows a dialog that contains a material design
    ///    date picker.
    ///  * [showTimePicker], which shows a dialog that contains a material design
    ///    time picker.
    ///
    /// </Summary>
    public class YearPicker : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a year picker.
        ///
        /// The [selectedDate] and [onChanged] arguments must not be null. The
        /// [lastDate] must be after the [firstDate].
        ///
        /// Rarely used directly. Instead, typically used as part of the dialog shown
        /// by [showDatePicker].
        /// </Summary>
        public YearPicker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), DateTime selectedDate = default(DateTime), FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime>), DateTime firstDate = default(DateTime), DateTime lastDate = default(DateTime), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.SelectedDate = selectedDate;
            this.OnChanged = onChanged;
            this.FirstDate = firstDate;
            this.LastDate = lastDate;
            this.DragStartBehavior = dragStartBehavior;
        }
        /// <Summary>
        /// The currently selected date.
        ///
        /// This date is highlighted in the picker.
        /// </Summary>
        public virtual DateTime SelectedDate { get; set; }
        /// <Summary>
        /// Called when the user picks a year.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<DateTime> OnChanged { get; set; }
        /// <Summary>
        /// The earliest date the user is permitted to pick.
        /// </Summary>
        public virtual DateTime FirstDate { get; set; }
        /// <Summary>
        /// The latest date the user is permitted to pick.
        /// </Summary>
        public virtual DateTime LastDate { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.scrollable.dragStartBehavior}
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }

        public new FlutterSDK.Material.Pickers.Datepickerdeprecated._YearPickerState CreateState() => new _YearPickerState();


    }


    public class _YearPickerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pickers.Datepickerdeprecated.YearPicker>
    {
        public _YearPickerState()
        { }
        internal virtual double _ItemExtent { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }

        public new void InitState()
        {
            base.InitState();
            ScrollController = new ScrollController(initialScrollOffset: (Widget.SelectedDate.Year - Widget.FirstDate.Year) * _ItemExtent);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
            TextStyle style = themeData.TextTheme.BodyText2;
            return ListView.Builder(dragStartBehavior: Widget.DragStartBehavior, controller: ScrollController, itemExtent: _ItemExtent, itemCount: Widget.LastDate.Year - Widget.FirstDate.Year + 1, itemBuilder: (BuildContext context, int index) =>
            {
                int year = Widget.FirstDate.Year + index;
                bool isSelected = year == Widget.SelectedDate.Year;
                TextStyle itemStyle = isSelected ? themeData.TextTheme.Headline5.CopyWith(color: themeData.AccentColor) : style;
                return new InkWell(key: new ValueKey<int>(year), onTap: () =>
                {
                    Widget.OnChanged(new DateTime(year, Widget.SelectedDate.Month, Widget.SelectedDate.Day));
                }
                , child: new Center(child: new Semantics(selected: isSelected, child: new Text(year.ToString(), style: itemStyle))));
            }
            );
        }



    }

}
