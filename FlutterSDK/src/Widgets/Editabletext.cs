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
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Widgets.Constants;
namespace FlutterSDK.Widgets.Editabletext
{
    public delegate void SelectionChangedCallback(FlutterSDK.Services.Textediting.TextSelection selection, FlutterSDK.Rendering.Editable.SelectionChangedCause cause);
    internal static class EditabletextDefaultClass
    {
        public static TimeSpan _KCursorBlinkHalfPeriod = default(TimeSpan);
        public static TimeSpan _KCursorBlinkWaitForStart = default(TimeSpan);
        public static int _KObscureShowLatestCharCursorTicks = default(int);
    }

    public class TextEditingController : FlutterSDK.Foundation.Changenotifier.ValueNotifier<FlutterSDK.Services.Textinput.TextEditingValue>
    {
        #region constructors
        public TextEditingController(string text = default(string))
        : base(text == null ? TextinputDefaultClass.TextEditingValue.Empty : new TextEditingValue(text: text))
        {
            throw new NotImplementedException();
        }
        public static TextEditingController FromValue(FlutterSDK.Services.Textinput.TextEditingValue value)
        {
            var instance = new TextEditingController(value ?? TextinputDefaultClass.TextEditingValue.Empty); throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual string Text { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Textediting.TextSelection Selection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual FlutterSDK.Painting.Textspan.TextSpan BuildTextSpan(FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), bool withComposing = default(bool)) { throw new NotImplementedException(); }


        public virtual void Clear() { throw new NotImplementedException(); }


        public virtual void ClearComposing() { throw new NotImplementedException(); }


        public virtual bool IsSelectionWithinTextBounds(FlutterSDK.Services.Textediting.TextSelection selection) { throw new NotImplementedException(); }

        #endregion
    }


    public class ToolbarOptions
    {
        #region constructors
        public ToolbarOptions(bool copy = false, bool cut = false, bool paste = false, bool selectAll = false)
        : base()
        {
            this.Copy = copy;
            this.Cut = cut;
            this.Paste = paste;
            this.SelectAll = selectAll; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Copy { get; set; }
        public virtual bool Cut { get; set; }
        public virtual bool Paste { get; set; }
        public virtual bool SelectAll { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class EditableText : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public EditableText(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Editabletext.TextEditingController controller = default(FlutterSDK.Widgets.Editabletext.TextEditingController), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool readOnly = false, bool obscureText = false, bool autocorrect = true, FlutterSDK.Services.Textinput.SmartDashesType smartDashesType = default(FlutterSDK.Services.Textinput.SmartDashesType), FlutterSDK.Services.Textinput.SmartQuotesType smartQuotesType = default(FlutterSDK.Services.Textinput.SmartQuotesType), bool enableSuggestions = true, FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundCursorColor = default(FlutterBinding.UI.Color), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), Locale locale = default(Locale), double textScaleFactor = default(double), int maxLines = 1, int minLines = default(int), bool expands = false, bool forceLine = true, FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), bool autofocus = false, bool showCursor = default(bool), bool showSelectionHandles = false, FlutterBinding.UI.Color selectionColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Textselection.TextSelectionControls selectionControls = default(FlutterSDK.Widgets.Textselection.TextSelectionControls), FlutterSDK.Services.Textinput.TextInputType keyboardType = default(FlutterSDK.Services.Textinput.TextInputType), FlutterSDK.Services.Textinput.TextInputAction textInputAction = default(FlutterSDK.Services.Textinput.TextInputAction), FlutterSDK.Services.Textinput.TextCapitalization textCapitalization = default(FlutterSDK.Services.Textinput.TextCapitalization), FlutterSDK.Foundation.Basictypes.ValueChanged<string> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<string>), VoidCallback onEditingComplete = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<string> onSubmitted = default(FlutterSDK.Foundation.Basictypes.ValueChanged<string>), FlutterSDK.Widgets.Editabletext.SelectionChangedCallback onSelectionChanged = default(FlutterSDK.Widgets.Editabletext.SelectionChangedCallback), VoidCallback onSelectionHandleTapped = default(VoidCallback), List<FlutterSDK.Services.Textformatter.TextInputFormatter> inputFormatters = default(List<FlutterSDK.Services.Textformatter.TextInputFormatter>), bool rendererIgnoresPointer = false, double cursorWidth = 2.0, Radius cursorRadius = default(Radius), bool cursorOpacityAnimates = false, FlutterBinding.UI.Offset cursorOffset = default(FlutterBinding.UI.Offset), bool paintCursorAboveText = false, BoxHeightStyle selectionHeightStyle = default(BoxHeightStyle), BoxWidthStyle selectionWidthStyle = default(BoxWidthStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsets scrollPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), Brightness keyboardAppearance = default(Brightness), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool enableInteractiveSelection = true, FlutterSDK.Widgets.Scrollcontroller.ScrollController scrollController = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics scrollPhysics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Editabletext.ToolbarOptions toolbarOptions = default(FlutterSDK.Widgets.Editabletext.ToolbarOptions))
        : base(key: key)
        {
            this.Controller = controller;
            this.FocusNode = focusNode;
            this.ReadOnly = readOnly;
            this.ObscureText = obscureText;
            this.Autocorrect = autocorrect;
            this.EnableSuggestions = enableSuggestions;
            this.Style = style;
            this.CursorColor = cursorColor;
            this.BackgroundCursorColor = backgroundCursorColor;
            this.TextAlign = textAlign;
            this.TextDirection = textDirection;
            this.Locale = locale;
            this.TextScaleFactor = textScaleFactor;
            this.MaxLines = maxLines;
            this.MinLines = minLines;
            this.Expands = expands;
            this.ForceLine = forceLine;
            this.TextWidthBasis = textWidthBasis;
            this.Autofocus = autofocus;
            this.ShowSelectionHandles = showSelectionHandles;
            this.SelectionColor = selectionColor;
            this.SelectionControls = selectionControls;
            this.TextInputAction = textInputAction;
            this.TextCapitalization = textCapitalization;
            this.OnChanged = onChanged;
            this.OnEditingComplete = onEditingComplete;
            this.OnSubmitted = onSubmitted;
            this.OnSelectionChanged = onSelectionChanged;
            this.OnSelectionHandleTapped = onSelectionHandleTapped;
            this.RendererIgnoresPointer = rendererIgnoresPointer;
            this.CursorWidth = cursorWidth;
            this.CursorRadius = cursorRadius;
            this.CursorOpacityAnimates = cursorOpacityAnimates;
            this.CursorOffset = cursorOffset;
            this.PaintCursorAboveText = paintCursorAboveText;
            this.SelectionHeightStyle = selectionHeightStyle;
            this.SelectionWidthStyle = selectionWidthStyle;
            this.ScrollPadding = scrollPadding;
            this.KeyboardAppearance = keyboardAppearance;
            this.DragStartBehavior = dragStartBehavior;
            this.EnableInteractiveSelection = enableInteractiveSelection;
            this.ScrollController = scrollController;
            this.ScrollPhysics = scrollPhysics;
            this.ToolbarOptions = toolbarOptions; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Editabletext.TextEditingController Controller { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public virtual bool ObscureText { get; set; }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        public virtual bool ReadOnly { get; set; }
        public virtual bool ForceLine { get; set; }
        public virtual FlutterSDK.Widgets.Editabletext.ToolbarOptions ToolbarOptions { get; set; }
        public virtual bool ShowSelectionHandles { get; set; }
        public virtual bool ShowCursor { get; set; }
        public virtual bool Autocorrect { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartDashesType SmartDashesType { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartQuotesType SmartQuotesType { get; set; }
        public virtual bool EnableSuggestions { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        internal virtual FlutterSDK.Painting.Strutstyle.StrutStyle _StrutStyle { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextCapitalization TextCapitalization { get; set; }
        public virtual Locale Locale { get; set; }
        public virtual double TextScaleFactor { get; set; }
        public virtual FlutterBinding.UI.Color CursorColor { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundCursorColor { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual int MinLines { get; set; }
        public virtual bool Expands { get; set; }
        public virtual bool Autofocus { get; set; }
        public virtual FlutterBinding.UI.Color SelectionColor { get; set; }
        public virtual FlutterSDK.Widgets.Textselection.TextSelectionControls SelectionControls { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextInputType KeyboardType { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextInputAction TextInputAction { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<string> OnChanged { get; set; }
        public virtual VoidCallback OnEditingComplete { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<string> OnSubmitted { get; set; }
        public virtual FlutterSDK.Widgets.Editabletext.SelectionChangedCallback OnSelectionChanged { get; set; }
        public virtual VoidCallback OnSelectionHandleTapped { get; set; }
        public virtual List<FlutterSDK.Services.Textformatter.TextInputFormatter> InputFormatters { get; set; }
        public virtual bool RendererIgnoresPointer { get; set; }
        public virtual double CursorWidth { get; set; }
        public virtual Radius CursorRadius { get; set; }
        public virtual bool CursorOpacityAnimates { get; set; }
        public virtual FlutterBinding.UI.Offset CursorOffset { get; set; }
        public virtual bool PaintCursorAboveText { get; set; }
        public virtual BoxHeightStyle SelectionHeightStyle { get; set; }
        public virtual BoxWidthStyle SelectionWidthStyle { get; set; }
        public virtual Brightness KeyboardAppearance { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ScrollPadding { get; set; }
        public virtual bool EnableInteractiveSelection { get; set; }
        public virtual bool DebugDeterministicCursor { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ScrollPhysics { get; set; }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Editabletext.EditableTextState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class EditableTextState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Editabletext.EditableText>, ITextInputClient, ITextSelectionDelegate, IAutomaticKeepAliveClientMixin<FlutterSDK.Widgets.Editabletext.EditableText>, IWidgetsBindingObserver, ITickerProviderStateMixin<FlutterSDK.Widgets.Editabletext.EditableText>
    {
        #region constructors
        public EditableTextState()
        { }
        #endregion

        #region fields
        internal virtual Timer _CursorTimer { get; set; }
        internal virtual bool _TargetCursorVisibility { get; set; }
        internal virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> _CursorVisibilityNotifier { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _EditableKey { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextInputConnection _TextInputConnection { get; set; }
        internal virtual FlutterSDK.Widgets.Textselection.TextSelectionOverlay _SelectionOverlay { get; set; }
        internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _ScrollController { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _CursorBlinkOpacityController { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.LayerLink _ToolbarLayerLink { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.LayerLink _StartHandleLayerLink { get; set; }
        internal virtual FlutterSDK.Rendering.Layer.LayerLink _EndHandleLayerLink { get; set; }
        internal virtual bool _DidAutoFocus { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusAttachment _FocusAttachment { get; set; }
        internal virtual TimeSpan _FadeDuration { get; set; }
        internal virtual TimeSpan _FloatingCursorResetTime { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _FloatingCursorResetController { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextEditingValue _LastFormattedUnmodifiedTextEditingValue { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextEditingValue _LastFormattedValue { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextEditingValue _ReceivedRemoteTextEditingValue { get; set; }
        internal virtual FlutterBinding.UI.Rect _StartCaretRect { get; set; }
        internal virtual TextPosition _LastTextPosition { get; set; }
        internal virtual FlutterBinding.UI.Offset _PointOffsetOrigin { get; set; }
        internal virtual FlutterBinding.UI.Offset _LastBoundedOffset { get; set; }
        internal virtual bool _TextChangedSinceLastCaretUpdate { get; set; }
        internal virtual FlutterBinding.UI.Rect _CurrentCaretRect { get; set; }
        internal virtual TimeSpan _CaretAnimationDuration { get; set; }
        internal virtual FlutterSDK.Animation.Curves.Curve _CaretAnimationCurve { get; set; }
        internal virtual bool _ShowCaretOnScreenScheduled { get; set; }
        internal virtual double _LastBottomViewInset { get; set; }
        internal virtual FlutterSDK.Widgets.Editabletext._WhitespaceDirectionalityFormatter _WhitespaceFormatter { get; set; }
        internal virtual int _ObscureShowCharTicksPending { get; set; }
        internal virtual int _ObscureLatestCharIndex { get; set; }
        public virtual bool WantKeepAlive { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterBinding.UI.Color _CursorColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CutEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CopyEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool PasteEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SelectAllEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Textinput.TextEditingValue CurrentTextEditingValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterBinding.UI.Offset _FloatingCursorOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Services.Textinput.TextEditingValue _Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _HasFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsMultiline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _HasInputConnection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CursorCurrentlyVisible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TimeSpan CursorBlinkInterval { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Textselection.TextSelectionOverlay SelectionOverlay { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual TextDirection _TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Editable.RenderEditable RenderEditable { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Textinput.TextEditingValue TextEditingValue { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _DevicePixelRatio { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Widgets.Editabletext.EditableText oldWidget) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        public new void UpdateEditingValue(FlutterSDK.Services.Textinput.TextEditingValue value) { throw new NotImplementedException(); }


        public new void PerformAction(FlutterSDK.Services.Textinput.TextInputAction action) { throw new NotImplementedException(); }


        public new void UpdateFloatingCursor(FlutterSDK.Services.Textinput.RawFloatingCursorPoint point) { throw new NotImplementedException(); }


        private void _OnFloatingCursorResetTick() { throw new NotImplementedException(); }


        private void _FinalizeEditing(bool shouldUnfocus) { throw new NotImplementedException(); }


        private void _UpdateRemoteEditingValueIfNeeded() { throw new NotImplementedException(); }


        private double _GetScrollOffsetForCaret(FlutterBinding.UI.Rect caretRect) { throw new NotImplementedException(); }


        private Rect _GetCaretRectAtScrollOffset(FlutterBinding.UI.Rect caretRect, double scrollOffset) { throw new NotImplementedException(); }


        private void _OpenInputConnection() { throw new NotImplementedException(); }


        private void _CloseInputConnectionIfNeeded() { throw new NotImplementedException(); }


        private void _OpenOrCloseInputConnectionIfNeeded() { throw new NotImplementedException(); }


        public new void ConnectionClosed() { throw new NotImplementedException(); }


        public virtual void RequestKeyboard() { throw new NotImplementedException(); }


        private void _UpdateOrDisposeSelectionOverlayIfNeeded() { throw new NotImplementedException(); }


        private void _HandleSelectionChanged(FlutterSDK.Services.Textediting.TextSelection selection, FlutterSDK.Rendering.Editable.RenderEditable renderObject, FlutterSDK.Rendering.Editable.SelectionChangedCause cause) { throw new NotImplementedException(); }


        private void _HandleCaretChanged(FlutterBinding.UI.Rect caretRect) { throw new NotImplementedException(); }


        private void _ShowCaretOnScreen() { throw new NotImplementedException(); }


        public new void DidChangeMetrics() { throw new NotImplementedException(); }


        private void _FormatAndSetValue(FlutterSDK.Services.Textinput.TextEditingValue value) { throw new NotImplementedException(); }


        private void _OnCursorColorTick() { throw new NotImplementedException(); }


        private void _CursorTick(Timer timer) { throw new NotImplementedException(); }


        private void _CursorWaitForStart(Timer timer) { throw new NotImplementedException(); }


        private void _StartCursorTimer() { throw new NotImplementedException(); }


        private void _StopCursorTimer(bool resetCharTicks = true) { throw new NotImplementedException(); }


        private void _StartOrStopCursorTimerIfNeeded() { throw new NotImplementedException(); }


        private void _DidChangeTextEditingValue() { throw new NotImplementedException(); }


        private void _HandleFocusChanged() { throw new NotImplementedException(); }


        private void _UpdateSizeAndTransform() { throw new NotImplementedException(); }


        public new void BringIntoView(TextPosition position) { throw new NotImplementedException(); }


        public virtual bool ShowToolbar() { throw new NotImplementedException(); }


        public new void HideToolbar() { throw new NotImplementedException(); }


        public virtual void ToggleToolbar() { throw new NotImplementedException(); }


        private VoidCallback _SemanticsOnCopy(FlutterSDK.Widgets.Textselection.TextSelectionControls controls) { throw new NotImplementedException(); }


        private VoidCallback _SemanticsOnCut(FlutterSDK.Widgets.Textselection.TextSelectionControls controls) { throw new NotImplementedException(); }


        private VoidCallback _SemanticsOnPaste(FlutterSDK.Widgets.Textselection.TextSelectionControls controls) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Painting.Textspan.TextSpan BuildTextSpan() { throw new NotImplementedException(); }

        #endregion
    }


    public class _Editable : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public _Editable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Textspan.TextSpan textSpan = default(FlutterSDK.Painting.Textspan.TextSpan), FlutterSDK.Services.Textinput.TextEditingValue value = default(FlutterSDK.Services.Textinput.TextEditingValue), FlutterSDK.Rendering.Layer.LayerLink startHandleLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Rendering.Layer.LayerLink endHandleLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundCursorColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> showCursor = default(FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool>), bool forceLine = default(bool), bool readOnly = default(bool), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), bool hasFocus = default(bool), int maxLines = default(int), int minLines = default(int), bool expands = default(bool), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), FlutterBinding.UI.Color selectionColor = default(FlutterBinding.UI.Color), double textScaleFactor = default(double), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), Locale locale = default(Locale), bool obscureText = default(bool), bool autocorrect = default(bool), FlutterSDK.Services.Textinput.SmartDashesType smartDashesType = default(FlutterSDK.Services.Textinput.SmartDashesType), FlutterSDK.Services.Textinput.SmartQuotesType smartQuotesType = default(FlutterSDK.Services.Textinput.SmartQuotesType), bool enableSuggestions = default(bool), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), FlutterSDK.Rendering.Editable.SelectionChangedHandler onSelectionChanged = default(FlutterSDK.Rendering.Editable.SelectionChangedHandler), FlutterSDK.Rendering.Editable.CaretChangedHandler onCaretChanged = default(FlutterSDK.Rendering.Editable.CaretChangedHandler), bool rendererIgnoresPointer = false, double cursorWidth = default(double), Radius cursorRadius = default(Radius), FlutterBinding.UI.Offset cursorOffset = default(FlutterBinding.UI.Offset), bool paintCursorAboveText = default(bool), BoxHeightStyle selectionHeightStyle = default(BoxHeightStyle), BoxWidthStyle selectionWidthStyle = default(BoxWidthStyle), bool enableInteractiveSelection = true, FlutterSDK.Services.Textinput.TextSelectionDelegate textSelectionDelegate = default(FlutterSDK.Services.Textinput.TextSelectionDelegate), double devicePixelRatio = default(double))
        : base(key: key)
        {
            this.TextSpan = textSpan;
            this.Value = value;
            this.StartHandleLayerLink = startHandleLayerLink;
            this.EndHandleLayerLink = endHandleLayerLink;
            this.CursorColor = cursorColor;
            this.BackgroundCursorColor = backgroundCursorColor;
            this.ShowCursor = showCursor;
            this.ForceLine = forceLine;
            this.ReadOnly = readOnly;
            this.TextWidthBasis = textWidthBasis;
            this.HasFocus = hasFocus;
            this.MaxLines = maxLines;
            this.MinLines = minLines;
            this.Expands = expands;
            this.StrutStyle = strutStyle;
            this.SelectionColor = selectionColor;
            this.TextScaleFactor = textScaleFactor;
            this.TextAlign = textAlign;
            this.TextDirection = textDirection;
            this.Locale = locale;
            this.ObscureText = obscureText;
            this.Autocorrect = autocorrect;
            this.SmartDashesType = smartDashesType;
            this.SmartQuotesType = smartQuotesType;
            this.EnableSuggestions = enableSuggestions;
            this.Offset = offset;
            this.OnSelectionChanged = onSelectionChanged;
            this.OnCaretChanged = onCaretChanged;
            this.RendererIgnoresPointer = rendererIgnoresPointer;
            this.CursorWidth = cursorWidth;
            this.CursorRadius = cursorRadius;
            this.CursorOffset = cursorOffset;
            this.PaintCursorAboveText = paintCursorAboveText;
            this.SelectionHeightStyle = selectionHeightStyle;
            this.SelectionWidthStyle = selectionWidthStyle;
            this.EnableInteractiveSelection = enableInteractiveSelection;
            this.TextSelectionDelegate = textSelectionDelegate;
            this.DevicePixelRatio = devicePixelRatio; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Textspan.TextSpan TextSpan { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextEditingValue Value { get; set; }
        public virtual FlutterBinding.UI.Color CursorColor { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LayerLink StartHandleLayerLink { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LayerLink EndHandleLayerLink { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundCursorColor { get; set; }
        public virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> ShowCursor { get; set; }
        public virtual bool ForceLine { get; set; }
        public virtual bool ReadOnly { get; set; }
        public virtual bool HasFocus { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual int MinLines { get; set; }
        public virtual bool Expands { get; set; }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get; set; }
        public virtual FlutterBinding.UI.Color SelectionColor { get; set; }
        public virtual double TextScaleFactor { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual Locale Locale { get; set; }
        public virtual bool ObscureText { get; set; }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        public virtual bool Autocorrect { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartDashesType SmartDashesType { get; set; }
        public virtual FlutterSDK.Services.Textinput.SmartQuotesType SmartQuotesType { get; set; }
        public virtual bool EnableSuggestions { get; set; }
        public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get; set; }
        public virtual FlutterSDK.Rendering.Editable.SelectionChangedHandler OnSelectionChanged { get; set; }
        public virtual FlutterSDK.Rendering.Editable.CaretChangedHandler OnCaretChanged { get; set; }
        public virtual bool RendererIgnoresPointer { get; set; }
        public virtual double CursorWidth { get; set; }
        public virtual Radius CursorRadius { get; set; }
        public virtual FlutterBinding.UI.Offset CursorOffset { get; set; }
        public virtual bool PaintCursorAboveText { get; set; }
        public virtual BoxHeightStyle SelectionHeightStyle { get; set; }
        public virtual BoxWidthStyle SelectionWidthStyle { get; set; }
        public virtual bool EnableInteractiveSelection { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextSelectionDelegate TextSelectionDelegate { get; set; }
        public virtual double DevicePixelRatio { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Editable.RenderEditable CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Editable.RenderEditable renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _WhitespaceDirectionalityFormatter : FlutterSDK.Services.Textformatter.TextInputFormatter
    {
        #region constructors
        public _WhitespaceDirectionalityFormatter(TextDirection textDirection = default(TextDirection))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual RegExp _LtrRegExp { get; set; }
        internal virtual RegExp _RtlRegExp { get; set; }
        internal virtual RegExp _WhitespaceRegExp { get; set; }
        internal virtual TextDirection _BaseDirection { get; set; }
        internal virtual TextDirection _PreviousNonWhitespaceDirection { get; set; }
        internal virtual bool _HasOpposingDirection { get; set; }
        internal virtual int _Rlm { get; set; }
        internal virtual int _Lrm { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Services.Textinput.TextEditingValue FormatEditUpdate(FlutterSDK.Services.Textinput.TextEditingValue oldValue, FlutterSDK.Services.Textinput.TextEditingValue newValue) { throw new NotImplementedException(); }


        public virtual bool IsWhitespace(int value) { throw new NotImplementedException(); }


        public virtual bool IsDirectionalityMarker(int value) { throw new NotImplementedException(); }


        public virtual TextDirection GetDirection(int value) { throw new NotImplementedException(); }

        #endregion
    }

}
