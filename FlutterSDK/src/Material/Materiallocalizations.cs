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
namespace FlutterSDK.Material.Materiallocalizations
{
    internal static class MateriallocalizationsDefaultClass
    {
    }

    public interface IMaterialLocalizations { }

    public class MaterialLocalizations
    {
        public virtual string OpenAppDrawerTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string BackButtonTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CloseButtonTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DeleteButtonTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string MoreButtonTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string NextMonthTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PreviousMonthTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string NextPageTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PreviousPageTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ShowMenuTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string LicensesPageTitle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string RowsPerPageTitle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CancelButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CloseButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ContinueButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CopyButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CutButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string OkButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PasteButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string SelectAllButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ViewLicensesButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string AnteMeridiemAbbreviation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PostMeridiemAbbreviation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string TimePickerHourModeAnnouncement { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string TimePickerMinuteModeAnnouncement { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ModalBarrierDismissLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DrawerLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PopupMenuLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DialogLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string AlertDialogLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string SearchFieldLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Typography.ScriptCategory ScriptCategory { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual List<string> NarrowWeekdays { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int FirstDayOfWeekIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string SignedInLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string HideAccountsLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ShowAccountsLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemToStart { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemToEnd { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemUp { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemDown { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ExpandedIconTapHint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CollapsedIconTapHint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string RefreshIndicatorSemanticLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// The default title for [AboutListTile].
        /// </Summary>
        public virtual string AboutListTileTitle(string applicationName)
        {
            return default(string);
        }


        /// <Summary>
        /// Title for the [PaginatedDataTable]'s row info footer.
        /// </Summary>
        public virtual string PageRowsInfoTitle(int firstRow, int lastRow, int rowCount, bool rowCountIsApproximate)
        {
            return default(string);
        }


        /// <Summary>
        /// The accessibility label used on a tab in a [TabBar].
        ///
        /// This message describes the index of the selected tab and how many tabs
        /// there are, e.g. 'Tab 1 of 2' in United States English.
        ///
        /// `tabIndex` and `tabCount` must be greater than or equal to one.
        /// </Summary>
        public virtual string TabLabel(int tabIndex = default(int), int tabCount = default(int))
        {
            return default(string);
        }


        /// <Summary>
        /// Title for the [PaginatedDataTable]'s selected row count header.
        /// </Summary>
        public virtual string SelectedRowCountTitle(int selectedRowCount)
        {
            return default(string);
        }


        /// <Summary>
        /// The format used to lay out the time picker.
        ///
        /// The documentation for [TimeOfDayFormat] enum values provides details on
        /// each supported layout.
        /// </Summary>
        public virtual FlutterSDK.Material.Time.TimeOfDayFormat TimeOfDayFormat(bool alwaysUse24HourFormat = false)
        {
            return default(TimeOfDayFormat);
        }


        /// <Summary>
        /// Formats [number] as a decimal, inserting locale-appropriate thousands
        /// separators as necessary.
        /// </Summary>
        public virtual string FormatDecimal(int number)
        {
            return default(string);
        }


        /// <Summary>
        /// Formats [TimeOfDay.hour] in the given time of day according to the value
        /// of [timeOfDayFormat].
        ///
        /// If [alwaysUse24HourFormat] is true, formats hour using [HourFormat.HH]
        /// rather than the default for the current locale.
        /// </Summary>
        public virtual string FormatHour(FlutterSDK.Material.Time.TimeOfDay timeOfDay, bool alwaysUse24HourFormat = false)
        {
            return default(string);
        }


        /// <Summary>
        /// Formats [TimeOfDay.minute] in the given time of day according to the value
        /// of [timeOfDayFormat].
        /// </Summary>
        public virtual string FormatMinute(FlutterSDK.Material.Time.TimeOfDay timeOfDay)
        {
            return default(string);
        }


        /// <Summary>
        /// Formats [timeOfDay] according to the value of [timeOfDayFormat].
        ///
        /// If [alwaysUse24HourFormat] is true, formats hour using [HourFormat.HH]
        /// rather than the default for the current locale. This value is usually
        /// passed from [MediaQueryData.alwaysUse24HourFormat], which has platform-
        /// specific behavior.
        /// </Summary>
        public virtual string FormatTimeOfDay(FlutterSDK.Material.Time.TimeOfDay timeOfDay, bool alwaysUse24HourFormat = false)
        {
            return default(string);
        }


        /// <Summary>
        /// Full unabbreviated year format, e.g. 2017 rather than 17.
        /// </Summary>
        public virtual string FormatYear(DateTime date)
        {
            return default(string);
        }


        /// <Summary>
        /// Formats the date in a compact format.
        ///
        /// Usually just the numeric values for the for day, month and year are used.
        ///
        /// Examples:
        ///
        /// - US English: 02/21/2019
        /// - Russian: 21.02.2019
        ///
        /// See also:
        ///   * [parseCompactDate], which will convert a compact date string to a [DateTime].
        /// </Summary>
        public virtual string FormatCompactDate(DateTime date)
        {
            return default(string);
        }


        /// <Summary>
        /// Formats the date using a short-width format.
        ///
        /// Includes the abbreviation of the month, the day and year.
        ///
        /// Examples:
        ///
        /// - US English: Feb 21, 2019
        /// - Russian: 21 февр. 2019 г.
        /// </Summary>
        public virtual string FormatShortDate(DateTime date)
        {
            return default(string);
        }


        /// <Summary>
        /// Formats the date using a medium-width format.
        ///
        /// Abbreviates month and days of week. This appears in the header of the date
        /// picker invoked using [showDatePicker].
        ///
        /// Examples:
        ///
        /// - US English: Wed, Sep 27
        /// - Russian: ср, сент. 27
        /// </Summary>
        public virtual string FormatMediumDate(DateTime date)
        {
            return default(string);
        }


        /// <Summary>
        /// Formats day of week, month, day of month and year in a long-width format.
        ///
        /// Does not abbreviate names. Appears in spoken announcements of the date
        /// picker invoked using [showDatePicker], when accessibility mode is on.
        ///
        /// Examples:
        ///
        /// - US English: Wednesday, September 27, 2017
        /// - Russian: Среда, Сентябрь 27, 2017
        /// </Summary>
        public virtual string FormatFullDate(DateTime date)
        {
            return default(string);
        }


        /// <Summary>
        /// Formats the month and the year of the given [date].
        ///
        /// The returned string does not contain the day of the month. This appears
        /// in the date picker invoked using [showDatePicker].
        /// </Summary>
        public virtual string FormatMonthYear(DateTime date)
        {
            return default(string);
        }


        /// <Summary>
        /// Formats the month and day of the given [date].
        ///
        /// Examples:
        ///
        /// - US English: Feb 21
        /// - Russian: 21 февр.
        /// </Summary>
        public virtual string FormatShortMonthDay(DateTime date)
        {
            return default(string);
        }


        /// <Summary>
        /// Converts the given compact date formatted string into a [DateTime].
        ///
        /// The format of the string must be a valid compact date format for the
        /// given locale. If the text doesn't represent a valid date, `null` will be
        /// returned.
        ///
        /// See also:
        ///   * [formatCompactDate], which will convert a [DateTime] into a string in the compact format.
        /// </Summary>
        public virtual DateTime ParseCompactDate(string inputString)
        {
            return default(DateTime);
        }


        /// <Summary>
        /// The label for the [TextField]'s character counter.
        /// </Summary>
        public virtual string RemainingTextFieldCharacterCount(int remaining)
        {
            return default(string);
        }


        /// <Summary>
        /// The `MaterialLocalizations` from the closest [Localizations] instance
        /// that encloses the given context.
        ///
        /// This method is just a convenient shorthand for:
        /// `Localizations.of<MaterialLocalizations>(context, MaterialLocalizations)`.
        ///
        /// References to the localized resources defined by this class are typically
        /// written in terms of this method. For example:
        ///
        /// ```dart
        /// tooltip: MaterialLocalizations.of(context).backButtonTooltip,
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Material.Materiallocalizations.MaterialLocalizations Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return LocalizationsDefaultClass.Localizations.Of(context, MateriallocalizationsDefaultClass.MaterialLocalizations);
        }



    }
    public static class MaterialLocalizationsMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IMaterialLocalizations, MaterialLocalizations> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IMaterialLocalizations, MaterialLocalizations>();
        static MaterialLocalizations GetOrCreate(IMaterialLocalizations instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new MaterialLocalizations();
                _table.Add(instance, value);
            }
            return (MaterialLocalizations)value;
        }
        public static string OpenAppDrawerTooltipProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).OpenAppDrawerTooltip;
        public static string BackButtonTooltipProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).BackButtonTooltip;
        public static string CloseButtonTooltipProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).CloseButtonTooltip;
        public static string DeleteButtonTooltipProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).DeleteButtonTooltip;
        public static string MoreButtonTooltipProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).MoreButtonTooltip;
        public static string NextMonthTooltipProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).NextMonthTooltip;
        public static string PreviousMonthTooltipProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).PreviousMonthTooltip;
        public static string NextPageTooltipProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).NextPageTooltip;
        public static string PreviousPageTooltipProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).PreviousPageTooltip;
        public static string ShowMenuTooltipProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ShowMenuTooltip;
        public static string LicensesPageTitleProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).LicensesPageTitle;
        public static string RowsPerPageTitleProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).RowsPerPageTitle;
        public static string CancelButtonLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).CancelButtonLabel;
        public static string CloseButtonLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).CloseButtonLabel;
        public static string ContinueButtonLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ContinueButtonLabel;
        public static string CopyButtonLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).CopyButtonLabel;
        public static string CutButtonLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).CutButtonLabel;
        public static string OkButtonLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).OkButtonLabel;
        public static string PasteButtonLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).PasteButtonLabel;
        public static string SelectAllButtonLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).SelectAllButtonLabel;
        public static string ViewLicensesButtonLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ViewLicensesButtonLabel;
        public static string AnteMeridiemAbbreviationProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).AnteMeridiemAbbreviation;
        public static string PostMeridiemAbbreviationProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).PostMeridiemAbbreviation;
        public static string TimePickerHourModeAnnouncementProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).TimePickerHourModeAnnouncement;
        public static string TimePickerMinuteModeAnnouncementProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).TimePickerMinuteModeAnnouncement;
        public static string ModalBarrierDismissLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ModalBarrierDismissLabel;
        public static string DrawerLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).DrawerLabel;
        public static string PopupMenuLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).PopupMenuLabel;
        public static string DialogLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).DialogLabel;
        public static string AlertDialogLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).AlertDialogLabel;
        public static string SearchFieldLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).SearchFieldLabel;
        public static FlutterSDK.Material.Typography.ScriptCategory ScriptCategoryProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ScriptCategory;
        public static List<string> NarrowWeekdaysProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).NarrowWeekdays;
        public static int FirstDayOfWeekIndexProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).FirstDayOfWeekIndex;
        public static string SignedInLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).SignedInLabel;
        public static string HideAccountsLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).HideAccountsLabel;
        public static string ShowAccountsLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ShowAccountsLabel;
        public static string ReorderItemToStartProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ReorderItemToStart;
        public static string ReorderItemToEndProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ReorderItemToEnd;
        public static string ReorderItemUpProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ReorderItemUp;
        public static string ReorderItemDownProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ReorderItemDown;
        public static string ReorderItemLeftProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ReorderItemLeft;
        public static string ReorderItemRightProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ReorderItemRight;
        public static string ExpandedIconTapHintProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).ExpandedIconTapHint;
        public static string CollapsedIconTapHintProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).CollapsedIconTapHint;
        public static string RefreshIndicatorSemanticLabelProperty(this IMaterialLocalizations instance) => GetOrCreate(instance).RefreshIndicatorSemanticLabel;
        public static string AboutListTileTitle(this IMaterialLocalizations instance, string applicationName) => GetOrCreate(instance).AboutListTileTitle(applicationName);
        public static string PageRowsInfoTitle(this IMaterialLocalizations instance, int firstRow, int lastRow, int rowCount, bool rowCountIsApproximate) => GetOrCreate(instance).PageRowsInfoTitle(firstRow, lastRow, rowCount, rowCountIsApproximate);
        public static string TabLabel(this IMaterialLocalizations instance, int tabIndex = default(int), int tabCount = default(int)) => GetOrCreate(instance).TabLabel(tabIndex, tabCount);
        public static string SelectedRowCountTitle(this IMaterialLocalizations instance, int selectedRowCount) => GetOrCreate(instance).SelectedRowCountTitle(selectedRowCount);
        public static FlutterSDK.Material.Time.TimeOfDayFormat TimeOfDayFormat(this IMaterialLocalizations instance, bool alwaysUse24HourFormat = false) => GetOrCreate(instance).TimeOfDayFormat(alwaysUse24HourFormat);
        public static string FormatDecimal(this IMaterialLocalizations instance, int number) => GetOrCreate(instance).FormatDecimal(number);
        public static string FormatHour(this IMaterialLocalizations instance, FlutterSDK.Material.Time.TimeOfDay timeOfDay, bool alwaysUse24HourFormat = false) => GetOrCreate(instance).FormatHour(timeOfDay, alwaysUse24HourFormat);
        public static string FormatMinute(this IMaterialLocalizations instance, FlutterSDK.Material.Time.TimeOfDay timeOfDay) => GetOrCreate(instance).FormatMinute(timeOfDay);
        public static string FormatTimeOfDay(this IMaterialLocalizations instance, FlutterSDK.Material.Time.TimeOfDay timeOfDay, bool alwaysUse24HourFormat = false) => GetOrCreate(instance).FormatTimeOfDay(timeOfDay, alwaysUse24HourFormat);
        public static string FormatYear(this IMaterialLocalizations instance, DateTime date) => GetOrCreate(instance).FormatYear(date);
        public static string FormatCompactDate(this IMaterialLocalizations instance, DateTime date) => GetOrCreate(instance).FormatCompactDate(date);
        public static string FormatShortDate(this IMaterialLocalizations instance, DateTime date) => GetOrCreate(instance).FormatShortDate(date);
        public static string FormatMediumDate(this IMaterialLocalizations instance, DateTime date) => GetOrCreate(instance).FormatMediumDate(date);
        public static string FormatFullDate(this IMaterialLocalizations instance, DateTime date) => GetOrCreate(instance).FormatFullDate(date);
        public static string FormatMonthYear(this IMaterialLocalizations instance, DateTime date) => GetOrCreate(instance).FormatMonthYear(date);
        public static string FormatShortMonthDay(this IMaterialLocalizations instance, DateTime date) => GetOrCreate(instance).FormatShortMonthDay(date);
        public static DateTime ParseCompactDate(this IMaterialLocalizations instance, string inputString) => GetOrCreate(instance).ParseCompactDate(inputString);
        public static string RemainingTextFieldCharacterCount(this IMaterialLocalizations instance, int remaining) => GetOrCreate(instance).RemainingTextFieldCharacterCount(remaining);
        public static FlutterSDK.Material.Materiallocalizations.MaterialLocalizations Of(this IMaterialLocalizations instance, FlutterSDK.Widgets.Framework.BuildContext context) => GetOrCreate(instance).Of(context);
    }


    public class _MaterialLocalizationsDelegate : FlutterSDK.Widgets.Localizations.LocalizationsDelegate<FlutterSDK.Material.Materiallocalizations.MaterialLocalizations>
    {
        public _MaterialLocalizationsDelegate()
        {

        }

        public new bool IsSupported(Locale locale) => locale.LanguageCode == "en";



        public new Future<FlutterSDK.Material.Materiallocalizations.MaterialLocalizations> Load(Locale locale) => MateriallocalizationsDefaultClass.DefaultMaterialLocalizations.Load(locale);



        public new bool ShouldReload(FlutterSDK.Material.Materiallocalizations._MaterialLocalizationsDelegate old) => false;



    }


    /// <Summary>
    /// US English strings for the material widgets.
    ///
    /// See also:
    ///
    ///  * [GlobalMaterialLocalizations], which provides material localizations for
    ///    many languages.
    ///  * [MaterialApp.localizationsDelegates], which automatically includes
    ///    [DefaultMaterialLocalizations.delegate] by default.
    /// </Summary>
    public class DefaultMaterialLocalizations : IMaterialLocalizations
    {
        public DefaultMaterialLocalizations()
        {

        }
        internal virtual List<string> _ShortWeekdays { get; set; }
        internal virtual List<string> _Weekdays { get; set; }
        internal virtual List<string> _NarrowWeekdays { get; set; }
        internal virtual List<string> _ShortMonths { get; set; }
        internal virtual List<string> _Months { get; set; }
        public virtual FlutterSDK.Widgets.Localizations.LocalizationsDelegate<FlutterSDK.Material.Materiallocalizations.MaterialLocalizations> @delegate { get; set; }
        public virtual List<string> NarrowWeekdays { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int FirstDayOfWeekIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string OpenAppDrawerTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string BackButtonTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CloseButtonTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DeleteButtonTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string MoreButtonTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string NextMonthTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PreviousMonthTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string NextPageTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PreviousPageTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ShowMenuTooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DrawerLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PopupMenuLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DialogLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string AlertDialogLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string SearchFieldLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string LicensesPageTitle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string RowsPerPageTitle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CancelButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CloseButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ContinueButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CopyButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CutButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string OkButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PasteButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string SelectAllButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ViewLicensesButtonLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string AnteMeridiemAbbreviation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string PostMeridiemAbbreviation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string TimePickerHourModeAnnouncement { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string TimePickerMinuteModeAnnouncement { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ModalBarrierDismissLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Typography.ScriptCategory ScriptCategory { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string SignedInLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string HideAccountsLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ShowAccountsLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemUp { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemDown { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemLeft { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemRight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemToEnd { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ReorderItemToStart { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string ExpandedIconTapHint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string CollapsedIconTapHint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string RefreshIndicatorSemanticLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns the number of days in a month, according to the proleptic
        /// Gregorian calendar.
        ///
        /// This applies the leap year logic introduced by the Gregorian reforms of
        /// 1582. It will not give valid results for dates prior to that time.
        /// </Summary>
        private int _GetDaysInMonth(int year, int month)
        {
            if (month == Dart.CoreDefaultClass.DateTime.February)
            {
                bool isLeapYear = (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0);
                if (isLeapYear) return 29;
                return 28;
            }

            List<int> daysInMonth = new List<int>() { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return daysInMonth[month - 1];
        }




        public new string FormatHour(FlutterSDK.Material.Time.TimeOfDay timeOfDay, bool alwaysUse24HourFormat = false)
        {
            TimeOfDayFormat format = TimeOfDayFormat(alwaysUse24HourFormat: alwaysUse24HourFormat);
            switch (format) { case TimeOfDayFormat.H_colon_mm_space_a: return FormatDecimal(timeOfDay.HourOfPeriod == 0 ? 12 : timeOfDay.HourOfPeriod); case TimeOfDayFormat.HH_colon_mm: return _FormatTwoDigitZeroPad(timeOfDay.Hour); default: throw new AssertionError($"'{GetType()} does not support {format}.'"); }
        }




        /// <Summary>
        /// Formats [number] using two digits, assuming it's in the 0-99 inclusive
        /// range. Not designed to format values outside this range.
        /// </Summary>
        private string _FormatTwoDigitZeroPad(int number)
        {

            if (number < 10) return $"'0{number}'";
            return $"'{number}'";
        }




        public new string FormatMinute(FlutterSDK.Material.Time.TimeOfDay timeOfDay)
        {
            int minute = timeOfDay.Minute;
            return minute < 10 ? $"'0{minute}'" : minute.ToString();
        }




        public new string FormatYear(DateTime date) => date.Year.ToString();



        public new string FormatCompactDate(DateTime date)
        {
            string month = _FormatTwoDigitZeroPad(date.Month);
            string day = _FormatTwoDigitZeroPad(date.Day);
            string year = date.Year.ToString().PadLeft(4, '0');
            return $"'{month}/{day}/{year}'";
        }




        public new string FormatShortDate(DateTime date)
        {
            string month = _ShortMonths[date.Month - Dart.CoreDefaultClass.DateTime.January];
            return $"'{month} {date.Day}, {date.Year}'";
        }




        public new string FormatMediumDate(DateTime date)
        {
            string day = _ShortWeekdays[date.Weekday - Dart.CoreDefaultClass.DateTime.Monday];
            string month = _ShortMonths[date.Month - Dart.CoreDefaultClass.DateTime.January];
            return $"'{day}, {month} {date.Day}'";
        }




        public new string FormatFullDate(DateTime date)
        {
            string month = _Months[date.Month - Dart.CoreDefaultClass.DateTime.January];
            return $"'{_Weekdays[date.Weekday - Dart.CoreDefaultClass.DateTime.Monday]}, {month} {date.Day}, {date.Year}'";
        }




        public new string FormatMonthYear(DateTime date)
        {
            string year = FormatYear(date);
            string month = _Months[date.Month - Dart.CoreDefaultClass.DateTime.January];
            return $"'{month} {year}'";
        }




        public new string FormatShortMonthDay(DateTime date)
        {
            string month = _ShortMonths[date.Month - Dart.CoreDefaultClass.DateTime.January];
            return $"'{month} {date.Day}'";
        }




        public new DateTime ParseCompactDate(string inputString)
        {
            List<string> inputParts = inputString.Split('/').ToList();
            if (inputParts.Count != 3)
            {
                return null;
            }

            int year = Dart.CoreDefaultClass.Int.TryParse(inputParts[2], radix: 10);
            if (year == null || year < 1)
            {
                return null;
            }

            int month = Dart.CoreDefaultClass.Int.TryParse(inputParts[0], radix: 10);
            if (month == null || month < 1 || month > 12)
            {
                return null;
            }

            int day = Dart.CoreDefaultClass.Int.TryParse(inputParts[1], radix: 10);
            if (day == null || day < 1 || day > _GetDaysInMonth(year, month))
            {
                return null;
            }

            return new DateTime(year, month, day);
        }




        private string _FormatDayPeriod(FlutterSDK.Material.Time.TimeOfDay timeOfDay)
        {
            switch (timeOfDay.Period) { case DayPeriod.Am: return AnteMeridiemAbbreviation; case DayPeriod.Pm: return PostMeridiemAbbreviation; }
            return null;
        }




        public new string FormatDecimal(int number)
        {
            if (number > -1000 && number < 1000) return number.ToString();
            string digits = number.Abs().ToString();
            StringBuffer result = new StringBuffer(number < 0 ? '-' : "");
            int maxDigitIndex = digits.Length - 1;
            for (int i = 0; i <= maxDigitIndex; i += 1)
            {
                result.Write(digits[i]);
                if (i < maxDigitIndex && (maxDigitIndex - i) % 3 == 0) result.Write(',');
            }

            return result.ToString();
        }




        public new string FormatTimeOfDay(FlutterSDK.Material.Time.TimeOfDay timeOfDay, bool alwaysUse24HourFormat = false)
        {
            StringBuffer buffer = new StringBuffer();
            ;
            buffer.Write(FormatHour(timeOfDay, alwaysUse24HourFormat: alwaysUse24HourFormat));
            buffer.Write(':');
            buffer.Write(FormatMinute(timeOfDay));
            if (alwaysUse24HourFormat)
            {
                return $"'{buffer}'";
            }

        ;
            buffer.Write(' ');
            buffer.Write(_FormatDayPeriod(timeOfDay));
            return $"'{buffer}'";
        }




        public new string AboutListTileTitle(string applicationName) => $"'About {applicationName}'";



        public new string PageRowsInfoTitle(int firstRow, int lastRow, int rowCount, bool rowCountIsApproximate)
        {
            return rowCountIsApproximate ? $"'{firstRow}–{lastRow} of about {rowCount}'" : $"'{firstRow}–{lastRow} of {rowCount}'";
        }




        public new string TabLabel(int tabIndex = default(int), int tabCount = default(int))
        {


            return $"'Tab {tabIndex} of {tabCount}'";
        }




        public new string SelectedRowCountTitle(int selectedRowCount)
        {
            switch (selectedRowCount) { case 0: return "No items selected"; case 1: return "1 item selected"; default: return $"'{selectedRowCount} items selected'"; }
        }




        public new FlutterSDK.Material.Time.TimeOfDayFormat TimeOfDayFormat(bool alwaysUse24HourFormat = false)
        {
            return alwaysUse24HourFormat ? TimeOfDayFormat.HH_colon_mm : TimeOfDayFormat.H_colon_mm_space_a;
        }




        /// <Summary>
        /// Creates an object that provides US English resource values for the material
        /// library widgets.
        ///
        /// The [locale] parameter is ignored.
        ///
        /// This method is typically used to create a [LocalizationsDelegate].
        /// The [MaterialApp] does so by default.
        /// </Summary>
        public virtual Future<FlutterSDK.Material.Materiallocalizations.MaterialLocalizations> Load(Locale locale)
        {
            return new SynchronousFuture<MaterialLocalizations>(new DefaultMaterialLocalizations());
        }




        public new string RemainingTextFieldCharacterCount(int remaining)
        {
            switch (remaining) { case 0: return "No characters remaining"; case 1: return "1 character remaining"; default: return $"'{remaining} characters remaining'"; }
        }



    }

}
