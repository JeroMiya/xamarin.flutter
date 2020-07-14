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
namespace FlutterSDK.Rendering.Editable
{
    public delegate void SelectionChangedHandler(FlutterSDK.Services.Textediting.TextSelection selection, FlutterSDK.Rendering.Editable.RenderEditable renderObject, FlutterSDK.Rendering.Editable.SelectionChangedCause cause);
    public delegate void CaretChangedHandler(FlutterBinding.UI.Rect caretRect);
    internal static class EditableDefaultClass
    {
        public static double _KCaretGap = default(double);
        public static double _KCaretHeightOffset = default(double);
        public static Offset _KFloatingCaretSizeIncrease = default(Offset);
        public static double _KFloatingCaretRadius = default(double);
        internal static bool _IsWhitespace(int codeUnit)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// Represents the coordinates of the point in a selection, and the text
    /// direction at that point, relative to top left of the [RenderEditable] that
    /// holds the selection.
    /// </Summary>
    public class TextSelectionPoint
    {
        #region constructors
        public TextSelectionPoint(FlutterBinding.UI.Offset point, TextDirection direction)
        : base()
    
}
    #endregion

    #region fields
    public virtual FlutterBinding.UI.Offset Point { get; set; }
    public virtual TextDirection Direction { get; set; }
    #endregion

    #region methods

    #endregion
}


/// <Summary>
/// Displays some text in a scrollable container with a potentially blinking
/// cursor and with gesture recognizers.
///
/// This is the renderer for an editable text field. It does not directly
/// provide affordances for editing the text, but it does handle text selection
/// and manipulation of the text cursor.
///
/// The [text] is displayed, scrolled by the given [offset], aligned according
/// to [textAlign]. The [maxLines] property controls whether the text displays
/// on one line or many. The [selection], if it is not collapsed, is painted in
/// the [selectionColor]. If it _is_ collapsed, then it represents the cursor
/// position. The cursor is shown while [showCursor] is true. It is painted in
/// the [cursorColor].
///
/// If, when the render object paints, the caret is found to have changed
/// location, [onCaretChanged] is called.
///
/// The user may interact with the render object by tapping or long-pressing.
/// When the user does so, the selection is updated, and [onSelectionChanged] is
/// called.
///
/// Keyboard handling, IME handling, scrolling, toggling the [showCursor] value
/// to actually blink the cursor, and other features not mentioned above are the
/// responsibility of higher layers and not handled by this object.
/// </Summary>
public class RenderEditable : FlutterSDK.Rendering.Box.RenderBox, IRelayoutWhenSystemFontsChangeMixin
{
    #region constructors
    public RenderEditable(FlutterSDK.Painting.Textspan.TextSpan text = default(FlutterSDK.Painting.Textspan.TextSpan), TextDirection textDirection = default(TextDirection), TextAlign textAlign = default(TextAlign), FlutterBinding.UI.Color cursorColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundCursorColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> showCursor = default(FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool>), bool hasFocus = default(bool), FlutterSDK.Rendering.Layer.LayerLink startHandleLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Rendering.Layer.LayerLink endHandleLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), int maxLines = 1, int minLines = default(int), bool expands = false, FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), FlutterBinding.UI.Color selectionColor = default(FlutterBinding.UI.Color), double textScaleFactor = 1.0, FlutterSDK.Services.Textediting.TextSelection selection = default(FlutterSDK.Services.Textediting.TextSelection), FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset = default(FlutterSDK.Rendering.Viewportoffset.ViewportOffset), FlutterSDK.Rendering.Editable.SelectionChangedHandler onSelectionChanged = default(FlutterSDK.Rendering.Editable.SelectionChangedHandler), FlutterSDK.Rendering.Editable.CaretChangedHandler onCaretChanged = default(FlutterSDK.Rendering.Editable.CaretChangedHandler), bool ignorePointer = false, bool readOnly = false, bool forceLine = true, FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), bool obscureText = false, Locale locale = default(Locale), double cursorWidth = 1.0, Radius cursorRadius = default(Radius), bool paintCursorAboveText = false, FlutterBinding.UI.Offset cursorOffset = default(FlutterBinding.UI.Offset), double devicePixelRatio = 1.0, BoxHeightStyle selectionHeightStyle = default(BoxHeightStyle), BoxWidthStyle selectionWidthStyle = default(BoxWidthStyle), bool enableInteractiveSelection = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsets floatingCursorAddedMargin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Services.Textinput.TextSelectionDelegate textSelectionDelegate = default(FlutterSDK.Services.Textinput.TextSelectionDelegate))
    : base()



this .HasFocus=hasFocus??false ;
}


#endregion

#region fields
public virtual string ObscuringCharacter { get; set; }
public virtual FlutterSDK.Rendering.Editable.SelectionChangedHandler OnSelectionChanged { get; set; }
internal virtual double _TextLayoutLastMaxWidth { get; set; }
internal virtual double _TextLayoutLastMinWidth { get; set; }
public virtual FlutterSDK.Rendering.Editable.CaretChangedHandler OnCaretChanged { get; set; }
public virtual bool IgnorePointer { get; set; }
internal virtual double _DevicePixelRatio { get; set; }
internal virtual bool _ObscureText { get; set; }
public virtual FlutterSDK.Services.Textinput.TextSelectionDelegate TextSelectionDelegate { get; set; }
internal virtual FlutterBinding.UI.Rect _LastCaretRect { get; set; }
internal virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> _SelectionStartInViewport { get; set; }
internal virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> _SelectionEndInViewport { get; set; }
internal virtual int _CursorResetLocation { get; set; }
internal virtual bool _WasSelectingVerticallyWithKeyboard { get; set; }
internal virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _MovementKeys { get; set; }
internal virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _ShortcutKeys { get; set; }
internal virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _NonModifierKeys { get; set; }
internal virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _ModifierKeys { get; set; }
internal virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _MacOsModifierKeys { get; set; }
internal virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _InterestingKeys { get; set; }
internal virtual string _CachedPlainText { get; set; }
internal virtual FlutterSDK.Painting.Textpainter.TextPainter _TextPainter { get; set; }
internal virtual FlutterBinding.UI.Color _CursorColor { get; set; }
internal virtual FlutterBinding.UI.Color _BackgroundCursorColor { get; set; }
internal virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> _ShowCursor { get; set; }
internal virtual bool _HasFocus { get; set; }
internal virtual bool _ListenerAttached { get; set; }
internal virtual bool _ForceLine { get; set; }
internal virtual bool _ReadOnly { get; set; }
internal virtual int _MaxLines { get; set; }
internal virtual int _MinLines { get; set; }
internal virtual bool _Expands { get; set; }
internal virtual FlutterBinding.UI.Color _SelectionColor { get; set; }
internal virtual List<TextBox> _SelectionRects { get; set; }
internal virtual FlutterSDK.Services.Textediting.TextSelection _Selection { get; set; }
internal virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset _Offset { get; set; }
internal virtual double _CursorWidth { get; set; }
internal virtual bool _PaintCursorOnTop { get; set; }
internal virtual FlutterBinding.UI.Offset _CursorOffset { get; set; }
internal virtual Radius _CursorRadius { get; set; }
internal virtual FlutterSDK.Rendering.Layer.LayerLink _StartHandleLayerLink { get; set; }
internal virtual FlutterSDK.Rendering.Layer.LayerLink _EndHandleLayerLink { get; set; }
internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets _FloatingCursorAddedMargin { get; set; }
internal virtual bool _FloatingCursorOn { get; set; }
internal virtual FlutterBinding.UI.Offset _FloatingCursorOffset { get; set; }
internal virtual TextPosition _FloatingCursorTextPosition { get; set; }
internal virtual BoxHeightStyle _SelectionHeightStyle { get; set; }
internal virtual BoxWidthStyle _SelectionWidthStyle { get; set; }
internal virtual bool _EnableInteractiveSelection { get; set; }
internal virtual double _MaxScrollExtent { get; set; }
internal virtual FlutterSDK.Gestures.Tap.TapGestureRecognizer _Tap { get; set; }
internal virtual FlutterSDK.Gestures.Longpress.LongPressGestureRecognizer _LongPress { get; set; }
internal virtual FlutterBinding.UI.Offset _LastTapDownPosition { get; set; }
internal virtual FlutterBinding.UI.Rect _CaretPrototype { get; set; }
internal virtual FlutterBinding.UI.Offset _RelativeOrigin { get; set; }
internal virtual FlutterBinding.UI.Offset _PreviousOffset { get; set; }
internal virtual bool _ResetOriginOnLeft { get; set; }
internal virtual bool _ResetOriginOnRight { get; set; }
internal virtual bool _ResetOriginOnTop { get; set; }
internal virtual bool _ResetOriginOnBottom { get; set; }
internal virtual double _ResetFloatingCursorAnimationValue { get; set; }
public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double DevicePixelRatio { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool ObscureText { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Foundation.Changenotifier.ValueListenable<bool> SelectionStartInViewport { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Foundation.Changenotifier.ValueListenable<bool> SelectionEndInViewport { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual string _PlainText { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Textspan.TextSpan Text { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual TextAlign TextAlign { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual Locale Locale { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color CursorColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color BackgroundCursorColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Foundation.Changenotifier.ValueNotifier<bool> ShowCursor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool HasFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool ForceLine { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool ReadOnly { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int MaxLines { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int MinLines { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool Expands { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Color SelectionColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double TextScaleFactor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Services.Textediting.TextSelection Selection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Viewportoffset.ViewportOffset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double CursorWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool PaintCursorAboveText { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterBinding.UI.Offset CursorOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual Radius CursorRadius { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Layer.LayerLink StartHandleLayerLink { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Rendering.Layer.LayerLink EndHandleLayerLink { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets FloatingCursorAddedMargin { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual BoxHeightStyle SelectionHeightStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual BoxWidthStyle SelectionWidthStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool EnableInteractiveSelection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double MaxScrollExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _CaretMargin { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual bool _IsMultiline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual FlutterSDK.Painting.Basictypes.Axis _ViewportAxis { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual FlutterBinding.UI.Offset _PaintOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual double _ViewportExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual bool _HasVisualOverflow { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double PreferredLineHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
internal virtual FlutterBinding.UI.Rect _GetCaretPrototype { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

private void _UpdateSelectionExtentsVisibility(FlutterBinding.UI.Offset effectiveOffset)
{
    Rect visibleRegion = Dart:uiDefaultClass.Offset.Zero & Size;
Offset startOffset = _TextPainter.GetOffsetForCaret(new TextPosition(offset: _Selection.Start, affinity: _Selection.Affinity), _CaretPrototype);
double visibleRegionSlop = 0.5;
_SelectionStartInViewport.Value = visibleRegion.Inflate(visibleRegionSlop).Contains(startOffset + effectiveOffset);
Offset endOffset = _TextPainter.GetOffsetForCaret(new TextPosition(offset: _Selection.End, affinity: _Selection.Affinity), _CaretPrototype);
_SelectionEndInViewport.Value = visibleRegion.Inflate(visibleRegionSlop).Contains(endOffset + effectiveOffset);
}




private void _HandleSelectionChange(FlutterSDK.Services.Textediting.TextSelection nextSelection, FlutterSDK.Rendering.Editable.SelectionChangedCause cause)
{
    bool focusingEmpty = nextSelection.BaseOffset == 0 && nextSelection.ExtentOffset == 0 && !HasFocus;
    if (nextSelection == Selection && cause != SelectionChangedCause.Keyboard && !focusingEmpty)
    {
        return;
    }

    if (OnSelectionChanged != null)
    {
        OnSelectionChanged(nextSelection, this, cause);
    }

}




private void _HandleKeyEvent(FlutterSDK.Services.Rawkeyboard.RawKeyEvent keyEvent)
{
    if (ConstantsDefaultClass.KIsWeb)
    {
        return;
    }

    if (!(keyEvent is RawKeyDownEvent) || OnSelectionChanged == null) return;
    HashSet<LogicalKeyboardKey> keysPressed = KeyboardkeyDefaultClass.LogicalKeyboardKey.CollapseSynonyms(RawkeyboardDefaultClass.RawKeyboard.Instance.KeysPressed);
    LogicalKeyboardKey key = keyEvent.LogicalKey;
    bool isMacOS = keyEvent.Data is RawKeyEventDataMacOs;
    if (!_NonModifierKeys.Contains(key) || keysPressed.Difference(isMacOS ? _MacOsModifierKeys : _ModifierKeys).Length > 1 || keysPressed.Difference(_InterestingKeys).IsNotEmpty)
    {
        return;
    }

    bool isWordModifierPressed = isMacOS ? keyEvent.IsAltPressed : keyEvent.IsControlPressed;
    bool isLineModifierPressed = isMacOS ? keyEvent.IsMetaPressed : keyEvent.IsAltPressed;
    bool isShortcutModifierPressed = isMacOS ? keyEvent.IsMetaPressed : keyEvent.IsControlPressed;
    if (_MovementKeys.Contains(key))
    {
        _HandleMovement(key, wordModifier: isWordModifierPressed, lineModifier: isLineModifierPressed, shift: keyEvent.IsShiftPressed);
    }
    else if (isShortcutModifierPressed && _ShortcutKeys.Contains(key))
    {
        _HandleShortcuts(key);
    }
    else if (key == KeyboardkeyDefaultClass.LogicalKeyboardKey.Delete)
    {
        _HandleDelete();
    }

}




private void _HandleMovement(FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey key, bool wordModifier = default(bool), bool lineModifier = default(bool), bool shift = default(bool))
{
    if (wordModifier && lineModifier)
    {
        return;
    }

    TextSelection newSelection = Selection;
    bool rightArrow = key == KeyboardkeyDefaultClass.LogicalKeyboardKey.ArrowRight;
    bool leftArrow = key == KeyboardkeyDefaultClass.LogicalKeyboardKey.ArrowLeft;
    bool upArrow = key == KeyboardkeyDefaultClass.LogicalKeyboardKey.ArrowUp;
    bool downArrow = key == KeyboardkeyDefaultClass.LogicalKeyboardKey.ArrowDown;
    int PreviousNonWhitespace(int extent) => {
        int result = Math.Dart:mathDefaultClass.Max(extent - 1, 0);
while (result > 0 && EditableDefaultClass._IsWhitespace(_PlainText.CodeUnitAt(result)))
{
    result -= 1;
}

return result;
}
 
int NextNonWhitespace(int extent) => {
    int result = Math.Dart:mathDefaultClass.Min(extent + 1, _PlainText.Length);
    while (result < _PlainText.Length && EditableDefaultClass._IsWhitespace(_PlainText.CodeUnitAt(result)))
    {
        result += 1;
    }

    return result;
}

if ((rightArrow || leftArrow) && !(rightArrow && leftArrow))
{
    if (wordModifier)
    {
        if (leftArrow)
        {
            int startPoint = PreviousNonWhitespace(newSelection.ExtentOffset);
            TextSelection textSelection = _SelectWordAtOffset(new TextPosition(offset: startPoint));
            newSelection = newSelection.CopyWith(extentOffset: textSelection.BaseOffset);
        }
        else
        {
            int startPoint = NextNonWhitespace(newSelection.ExtentOffset);
            TextSelection textSelection = _SelectWordAtOffset(new TextPosition(offset: startPoint));
            newSelection = newSelection.CopyWith(extentOffset: textSelection.ExtentOffset);
        }

    }
    else if (lineModifier)
    {
        if (leftArrow)
        {
            int startPoint = PreviousNonWhitespace(newSelection.ExtentOffset);
            TextSelection textSelection = _SelectLineAtOffset(new TextPosition(offset: startPoint));
            newSelection = newSelection.CopyWith(extentOffset: textSelection.BaseOffset);
        }
        else
        {
            int startPoint = NextNonWhitespace(newSelection.ExtentOffset);
            TextSelection textSelection = _SelectLineAtOffset(new TextPosition(offset: startPoint));
            newSelection = newSelection.CopyWith(extentOffset: textSelection.ExtentOffset);
        }

    }
    else
    {
        if (rightArrow && newSelection.ExtentOffset < _PlainText.Length)
        {
            newSelection = newSelection.CopyWith(extentOffset: newSelection.ExtentOffset + 1);
            if (shift)
            {
                _CursorResetLocation += 1;
            }

        }
        else if (leftArrow && newSelection.ExtentOffset > 0)
        {
            newSelection = newSelection.CopyWith(extentOffset: newSelection.ExtentOffset - 1);
            if (shift)
            {
                _CursorResetLocation -= 1;
            }

        }

    }

}

if (downArrow || upArrow)
{
    double preferredLineHeight = _TextPainter.PreferredLineHeight;
    double verticalOffset = upArrow ? -0.5 * preferredLineHeight : 1.5 * preferredLineHeight;
    Offset caretOffset = _TextPainter.GetOffsetForCaret(new TextPosition(offset: newSelection.ExtentOffset), _CaretPrototype);
    Offset caretOffsetTranslated = caretOffset.Translate(0.0, verticalOffset);
    TextPosition position = _TextPainter.GetPositionForOffset(caretOffsetTranslated);
    if (position.Offset == newSelection.ExtentOffset)
    {
        if (downArrow)
        {
            newSelection = newSelection.CopyWith(extentOffset: _PlainText.Length);
        }
        else if (upArrow)
        {
            newSelection = newSelection.CopyWith(extentOffset: 0);
        }

        _WasSelectingVerticallyWithKeyboard = shift;
    }
    else if (_WasSelectingVerticallyWithKeyboard && shift)
    {
        newSelection = newSelection.CopyWith(extentOffset: _CursorResetLocation);
        _WasSelectingVerticallyWithKeyboard = false;
    }
    else
    {
        newSelection = newSelection.CopyWith(extentOffset: position.Offset);
        _CursorResetLocation = newSelection.ExtentOffset;
    }

}

if (!shift)
{
    int newOffset = newSelection.ExtentOffset;
    if (!Selection.IsCollapsed)
    {
        if (leftArrow)
        {
            newOffset = newSelection.BaseOffset < newSelection.ExtentOffset ? newSelection.BaseOffset : newSelection.ExtentOffset;
        }
        else if (rightArrow)
        {
            newOffset = newSelection.BaseOffset > newSelection.ExtentOffset ? newSelection.BaseOffset : newSelection.ExtentOffset;
        }

    }

    newSelection = TextSelection.FromPosition(new TextPosition(offset: newOffset));
}

TextSelectionDelegate.TextEditingValue = TextSelectionDelegate.TextEditingValue.CopyWith(selection: newSelection);
_HandleSelectionChange(newSelection, SelectionChangedCause.Keyboard);
}




private Future<object> _HandleShortcuts(FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey key)
async
{

    if (key == KeyboardkeyDefaultClass.LogicalKeyboardKey.KeyC)
    {
        if (!Selection.IsCollapsed)
        {
            ClipboardDefaultClass.Clipboard.SetData(new ClipboardData(text: Selection.TextInside(_PlainText)));
        }

        return;
    }

    if (key == KeyboardkeyDefaultClass.LogicalKeyboardKey.KeyX)
    {
        if (!Selection.IsCollapsed)
        {
            ClipboardDefaultClass.Clipboard.SetData(new ClipboardData(text: Selection.TextInside(_PlainText)));
            TextSelectionDelegate.TextEditingValue = new TextEditingValue(text: Selection.TextBefore(_PlainText) + Selection.TextAfter(_PlainText), selection: TextSelection.Collapsed(offset: Selection.Start));
        }

        return;
    }

    if (key == KeyboardkeyDefaultClass.LogicalKeyboardKey.KeyV)
    {
        TextEditingValue value = TextSelectionDelegate.TextEditingValue;
        ClipboardData data = await ClipboardDefaultClass.Clipboard.GetData(ClipboardDefaultClass.Clipboard.KTextPlain);
        if (data != null)
        {
            TextSelectionDelegate.TextEditingValue = new TextEditingValue(text: value.Selection.TextBefore(value.Text) + data.Text + value.Selection.TextAfter(value.Text), selection: TextSelection.Collapsed(offset: value.Selection.Start + data.Text.Length));
        }

        return;
    }

    if (key == KeyboardkeyDefaultClass.LogicalKeyboardKey.KeyA)
    {
        _HandleSelectionChange(Selection.CopyWith(baseOffset: 0, extentOffset: TextSelectionDelegate.TextEditingValue.Text.Length), SelectionChangedCause.Keyboard);
        return;
    }

}




private void _HandleDelete()
{
    if (Selection.TextAfter(_PlainText).IsNotEmpty)
    {
        TextSelectionDelegate.TextEditingValue = new TextEditingValue(text: Selection.TextBefore(_PlainText) + Selection.TextAfter(_PlainText).Substring(1), selection: TextSelection.Collapsed(offset: Selection.Start));
    }
    else
    {
        TextSelectionDelegate.TextEditingValue = new TextEditingValue(text: Selection.TextBefore(_PlainText), selection: TextSelection.Collapsed(offset: Selection.Start));
    }

}




/// <Summary>
/// Marks the render object as needing to be laid out again and have its text
/// metrics recomputed.
///
/// Implies [markNeedsLayout].
/// </Summary>
public virtual void MarkNeedsTextLayout()
{
    _TextLayoutLastMaxWidth = null;
    _TextLayoutLastMinWidth = null;
    MarkNeedsLayout();
}




public new void SystemFontsDidChange()
{
    base.SystemFontsDidChange();
    _TextPainter.MarkNeedsLayout();
    _TextLayoutLastMaxWidth = null;
    _TextLayoutLastMinWidth = null;
}




public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
{
    base.DescribeSemanticsConfiguration(config);
    ..Value = ObscureText ? ObscuringCharacter * _PlainText.Length : _PlainText..IsObscured = ObscureText..IsMultiline = _IsMultiline..TextDirection = TextDirection..IsFocused = HasFocus..IsTextField = true..IsReadOnly = ReadOnly;
    if (HasFocus && SelectionEnabled) config.OnSetSelection = _HandleSetSelection;
    if (SelectionEnabled && _Selection?.IsValid == true)
    {
        config.TextSelection = _Selection;
        if (_TextPainter.GetOffsetBefore(_Selection.ExtentOffset) != null)
        {
            ..OnMoveCursorBackwardByWord = _HandleMoveCursorBackwardByWord..OnMoveCursorBackwardByCharacter = _HandleMoveCursorBackwardByCharacter;
        }

        if (_TextPainter.GetOffsetAfter(_Selection.ExtentOffset) != null)
        {
            ..OnMoveCursorForwardByWord = _HandleMoveCursorForwardByWord..OnMoveCursorForwardByCharacter = _HandleMoveCursorForwardByCharacter;
        }

    }

}




private void _HandleSetSelection(FlutterSDK.Services.Textediting.TextSelection selection)
{
    _HandleSelectionChange(selection, SelectionChangedCause.Keyboard);
}




private void _HandleMoveCursorForwardByCharacter(bool extentSelection)
{
    int extentOffset = _TextPainter.GetOffsetAfter(_Selection.ExtentOffset);
    if (extentOffset == null) return;
    int baseOffset = !extentSelection ? extentOffset : _Selection.BaseOffset;
    _HandleSelectionChange(new TextSelection(baseOffset: baseOffset, extentOffset: extentOffset), SelectionChangedCause.Keyboard);
}




private void _HandleMoveCursorBackwardByCharacter(bool extentSelection)
{
    int extentOffset = _TextPainter.GetOffsetBefore(_Selection.ExtentOffset);
    if (extentOffset == null) return;
    int baseOffset = !extentSelection ? extentOffset : _Selection.BaseOffset;
    _HandleSelectionChange(new TextSelection(baseOffset: baseOffset, extentOffset: extentOffset), SelectionChangedCause.Keyboard);
}




private void _HandleMoveCursorForwardByWord(bool extentSelection)
{
    TextRange currentWord = _TextPainter.GetWordBoundary(_Selection.Extent);
    if (currentWord == null) return;
    TextRange nextWord = _GetNextWord(currentWord.End);
    if (nextWord == null) return;
    int baseOffset = extentSelection ? _Selection.BaseOffset : nextWord.Start;
    _HandleSelectionChange(new TextSelection(baseOffset: baseOffset, extentOffset: nextWord.Start), SelectionChangedCause.Keyboard);
}




private void _HandleMoveCursorBackwardByWord(bool extentSelection)
{
    TextRange currentWord = _TextPainter.GetWordBoundary(_Selection.Extent);
    if (currentWord == null) return;
    TextRange previousWord = _GetPreviousWord(currentWord.Start - 1);
    if (previousWord == null) return;
    int baseOffset = extentSelection ? _Selection.BaseOffset : previousWord.Start;
    _HandleSelectionChange(new TextSelection(baseOffset: baseOffset, extentOffset: previousWord.Start), SelectionChangedCause.Keyboard);
}




private TextRange _GetNextWord(int offset)
{
    while (true)
    {
        TextRange range = _TextPainter.GetWordBoundary(new TextPosition(offset: offset));
        if (range == null || !range.IsValid || range.IsCollapsed) return null;
        if (!_OnlyWhitespace(range)) return range;
        offset = range.End;
    }

}




private TextRange _GetPreviousWord(int offset)
{
    while (offset >= 0)
    {
        TextRange range = _TextPainter.GetWordBoundary(new TextPosition(offset: offset));
        if (range == null || !range.IsValid || range.IsCollapsed) return null;
        if (!_OnlyWhitespace(range)) return range;
        offset = range.Start - 1;
    }

    return null;
}




private bool _OnlyWhitespace(TextRange range)
{
    for (int i = range.Start; i < range.End; i++)
    {
        int codeUnit = Text.CodeUnitAt(i);
        if (!EditableDefaultClass._IsWhitespace(codeUnit))
        {
            return false;
        }

    }

    return true;
}




public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
{
    base.Attach(owner);
    _Tap = new TapGestureRecognizer(debugOwner: this)..OnTapDown = _HandleTapDown..OnTap = _HandleTap;
    _LongPress = new LongPressGestureRecognizer(debugOwner: this)..OnLongPress = _HandleLongPress;
    _Offset.AddListener(MarkNeedsPaint);
    _ShowCursor.AddListener(MarkNeedsPaint);
}


public new void Attach(@Object owner)
{
    base.Attach(owner);
    _Tap = new TapGestureRecognizer(debugOwner: this)..OnTapDown = _HandleTapDown..OnTap = _HandleTap;
    _LongPress = new LongPressGestureRecognizer(debugOwner: this)..OnLongPress = _HandleLongPress;
    _Offset.AddListener(MarkNeedsPaint);
    _ShowCursor.AddListener(MarkNeedsPaint);
}




public new void Detach()
{
    _Tap.Dispose();
    _LongPress.Dispose();
    _Offset.RemoveListener(MarkNeedsPaint);
    _ShowCursor.RemoveListener(MarkNeedsPaint);
    if (_ListenerAttached) RawkeyboardDefaultClass.RawKeyboard.Instance.RemoveListener(_HandleKeyEvent);
    base.Detach();
}




private double _GetMaxScrollExtent(Size contentSize)
{

    switch (_ViewportAxis) { case Axis.Horizontal: return Math.Dart:mathDefaultClass.Max(0.0, contentSize.Width - Size.Width);case Axis.Vertical:return Math.Dart:mathDefaultClass.Max(0.0, contentSize.Height - Size.Height);}
return null;
}




/// <Summary>
/// Returns the local coordinates of the endpoints of the given selection.
///
/// If the selection is collapsed (and therefore occupies a single point), the
/// returned list is of length one. Otherwise, the selection is not collapsed
/// and the returned list is of length two. In this case, however, the two
/// points might actually be co-located (e.g., because of a bidirectional
/// selection that contains some text but whose ends meet in the middle).
///
/// See also:
///
///  * [getLocalRectForCaret], which is the equivalent but for
///    a [TextPosition] rather than a [TextSelection].
/// </Summary>
public virtual List<FlutterSDK.Rendering.Editable.TextSelectionPoint> GetEndpointsForSelection(FlutterSDK.Services.Textediting.TextSelection selection)
{

    _LayoutText(minWidth: Constraints.MinWidth, maxWidth: Constraints.MaxWidth);
    Offset paintOffset = _PaintOffset;
    if (selection.IsCollapsed)
    {
        Offset caretOffset = _TextPainter.GetOffsetForCaret(selection.Extent, _CaretPrototype);
        Offset start = new Offset(0.0, PreferredLineHeight) + caretOffset + paintOffset;
        return new List<TextSelectionPoint>() { new TextSelectionPoint(start, null) };
    }
    else
    {
        List < Ui.Dart:uiDefaultClass.TextBox > boxes = _TextPainter.GetBoxesForSelection(selection);
        Offset start = new Offset(boxes.First.Start, boxes.First.Bottom) + paintOffset;
        Offset end = new Offset(boxes.Last().End, boxes.Last().Bottom) + paintOffset;
        return new List<TextSelectionPoint>() { new TextSelectionPoint(start, boxes.First.Direction), new TextSelectionPoint(end, boxes.Last().Direction) };
    }

}




/// <Summary>
/// Returns the position in the text for the given global coordinate.
///
/// See also:
///
///  * [getLocalRectForCaret], which is the reverse operation, taking
///    a [TextPosition] and returning a [Rect].
///  * [TextPainter.getPositionForOffset], which is the equivalent method
///    for a [TextPainter] object.
/// </Summary>
public virtual TextPosition GetPositionForPoint(FlutterBinding.UI.Offset globalPosition)
{
    _LayoutText(minWidth: Constraints.MinWidth, maxWidth: Constraints.MaxWidth);
    globalPosition += -_PaintOffset;
    return _TextPainter.GetPositionForOffset(GlobalToLocal(globalPosition));
}




/// <Summary>
/// Returns the [Rect] in local coordinates for the caret at the given text
/// position.
///
/// See also:
///
///  * [getPositionForPoint], which is the reverse operation, taking
///    an [Offset] in global coordinates and returning a [TextPosition].
///  * [getEndpointsForSelection], which is the equivalent but for
///    a selection rather than a particular text position.
///  * [TextPainter.getOffsetForCaret], the equivalent method for a
///    [TextPainter] object.
/// </Summary>
public virtual Rect GetLocalRectForCaret(TextPosition caretPosition)
{
    _LayoutText(minWidth: Constraints.MinWidth, maxWidth: Constraints.MaxWidth);
    Offset caretOffset = _TextPainter.GetOffsetForCaret(caretPosition, _CaretPrototype);
    Rect rect = Rect.FromLTWH(0.0, 0.0, CursorWidth, PreferredLineHeight).Shift(caretOffset + _PaintOffset);
    if (_CursorOffset != null) rect = rect.Shift(_CursorOffset);
    return rect.Shift(_GetPixelPerfectCursorOffset(rect));
}




public new double ComputeMinIntrinsicWidth(double height)
{
    _LayoutText(maxWidth: Dart:coreDefaultClass.Double.Infinity);
    return _TextPainter.MinIntrinsicWidth;
}




public new double ComputeMaxIntrinsicWidth(double height)
{
    _LayoutText(maxWidth: Dart:coreDefaultClass.Double.Infinity);
    return _TextPainter.MaxIntrinsicWidth + CursorWidth;
}




private double _PreferredHeight(double width)
{
    bool lockedMax = MaxLines != null && MinLines == null;
    bool lockedBoth = MinLines != null && MinLines == MaxLines;
    bool singleLine = MaxLines == 1;
    if (singleLine || lockedMax || lockedBoth)
    {
        return PreferredLineHeight * MaxLines;
    }

    bool minLimited = MinLines != null && MinLines > 1;
    bool maxLimited = MaxLines != null;
    if (minLimited || maxLimited)
    {
        _LayoutText(maxWidth: width);
        if (minLimited && _TextPainter.Height < PreferredLineHeight * MinLines)
        {
            return PreferredLineHeight * MinLines;
        }

        if (maxLimited && _TextPainter.Height > PreferredLineHeight * MaxLines)
        {
            return PreferredLineHeight * MaxLines;
        }

    }

    if (width == Dart:coreDefaultClass.Double.Infinity){
    string text = _PlainText;
    int lines = 1;
    for (int index = 0; index < text.Length; index += 1)
    {
        if (text.CodeUnitAt(index) == 0x0A) lines += 1;
    }

    return PreferredLineHeight * lines;
}

_LayoutText(maxWidth: width);
return Math.Dart:mathDefaultClass.Max(PreferredLineHeight, _TextPainter.Height);
}




public new double ComputeMinIntrinsicHeight(double width)
{
    return _PreferredHeight(width);
}




public new double ComputeMaxIntrinsicHeight(double width)
{
    return _PreferredHeight(width);
}




public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
{
    _LayoutText(minWidth: Constraints.MinWidth, maxWidth: Constraints.MaxWidth);
    return _TextPainter.ComputeDistanceToActualBaseline(baseline);
}




public new bool HitTestSelf(FlutterBinding.UI.Offset position) => true;



public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry)
{
    if (IgnorePointer) return;

    if (@event is PointerDownEvent && OnSelectionChanged != null)
    {
        _Tap.AddPointer(((PointerDownEvent)@event));
        _LongPress.AddPointer(((PointerDownEvent)@event));
    }

}




/// <Summary>
/// If [ignorePointer] is false (the default) then this method is called by
/// the internal gesture recognizer's [TapGestureRecognizer.onTapDown]
/// callback.
///
/// When [ignorePointer] is true, an ancestor widget must respond to tap
/// down events by calling this method.
/// </Summary>
public virtual void HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details)
{
    _LastTapDownPosition = details.GlobalPosition;
}




private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details)
{

    HandleTapDown(details);
}




/// <Summary>
/// If [ignorePointer] is false (the default) then this method is called by
/// the internal gesture recognizer's [TapGestureRecognizer.onTap]
/// callback.
///
/// When [ignorePointer] is true, an ancestor widget must respond to tap
/// events by calling this method.
/// </Summary>
public virtual void HandleTap()
{
    SelectPosition(cause: SelectionChangedCause.Tap);
}




private void _HandleTap()
{

    HandleTap();
}




/// <Summary>
/// If [ignorePointer] is false (the default) then this method is called by
/// the internal gesture recognizer's [DoubleTapGestureRecognizer.onDoubleTap]
/// callback.
///
/// When [ignorePointer] is true, an ancestor widget must respond to double
/// tap events by calling this method.
/// </Summary>
public virtual void HandleDoubleTap()
{
    SelectWord(cause: SelectionChangedCause.DoubleTap);
}




/// <Summary>
/// If [ignorePointer] is false (the default) then this method is called by
/// the internal gesture recognizer's [LongPressGestureRecognizer.onLongPress]
/// callback.
///
/// When [ignorePointer] is true, an ancestor widget must respond to long
/// press events by calling this method.
/// </Summary>
public virtual void HandleLongPress()
{
    SelectWord(cause: SelectionChangedCause.LongPress);
}




private void _HandleLongPress()
{

    HandleLongPress();
}




/// <Summary>
/// Move selection to the location of the last tap down.
///
/// {@template flutter.rendering.editable.select}
/// This method is mainly used to translate user inputs in global positions
/// into a [TextSelection]. When used in conjunction with a [EditableText],
/// the selection change is fed back into [TextEditingController.selection].
///
/// If you have a [TextEditingController], it's generally easier to
/// programmatically manipulate its `value` or `selection` directly.
/// {@endtemplate}
/// </Summary>
public virtual void SelectPosition(FlutterSDK.Rendering.Editable.SelectionChangedCause cause = default(FlutterSDK.Rendering.Editable.SelectionChangedCause))
{
    SelectPositionAt(from: _LastTapDownPosition, cause: cause);
}




/// <Summary>
/// Select text between the global positions [from] and [to].
/// </Summary>
public virtual void SelectPositionAt(FlutterBinding.UI.Offset from = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset to = default(FlutterBinding.UI.Offset), FlutterSDK.Rendering.Editable.SelectionChangedCause cause = default(FlutterSDK.Rendering.Editable.SelectionChangedCause))
{


    _LayoutText(minWidth: Constraints.MinWidth, maxWidth: Constraints.MaxWidth);
    if (OnSelectionChanged == null)
    {
        return;
    }

    TextPosition fromPosition = _TextPainter.GetPositionForOffset(GlobalToLocal(from - _PaintOffset));
    TextPosition toPosition = to == null ? null : _TextPainter.GetPositionForOffset(GlobalToLocal(to - _PaintOffset));
    int baseOffset = fromPosition.Offset;
    int extentOffset = fromPosition.Offset;
    if (toPosition != null)
    {
        baseOffset = Math.Dart:mathDefaultClass.Min(fromPosition.Offset, toPosition.Offset);
        extentOffset = Math.Dart:mathDefaultClass.Max(fromPosition.Offset, toPosition.Offset);
    }

    TextSelection newSelection = new TextSelection(baseOffset: baseOffset, extentOffset: extentOffset, affinity: fromPosition.Affinity);
    _HandleSelectionChange(newSelection, cause);
}




/// <Summary>
/// Select a word around the location of the last tap down.
///
/// {@macro flutter.rendering.editable.select}
/// </Summary>
public virtual void SelectWord(FlutterSDK.Rendering.Editable.SelectionChangedCause cause = default(FlutterSDK.Rendering.Editable.SelectionChangedCause))
{
    SelectWordsInRange(from: _LastTapDownPosition, cause: cause);
}




/// <Summary>
/// Selects the set words of a paragraph in a given range of global positions.
///
/// The first and last endpoints of the selection will always be at the
/// beginning and end of a word respectively.
///
/// {@macro flutter.rendering.editable.select}
/// </Summary>
public virtual void SelectWordsInRange(FlutterBinding.UI.Offset from = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Offset to = default(FlutterBinding.UI.Offset), FlutterSDK.Rendering.Editable.SelectionChangedCause cause = default(FlutterSDK.Rendering.Editable.SelectionChangedCause))
{


    _LayoutText(minWidth: Constraints.MinWidth, maxWidth: Constraints.MaxWidth);
    if (OnSelectionChanged == null)
    {
        return;
    }

    TextPosition firstPosition = _TextPainter.GetPositionForOffset(GlobalToLocal(from - _PaintOffset));
    TextSelection firstWord = _SelectWordAtOffset(firstPosition);
    TextSelection lastWord = to == null ? firstWord : _SelectWordAtOffset(_TextPainter.GetPositionForOffset(GlobalToLocal(to - _PaintOffset)));
    _HandleSelectionChange(new TextSelection(baseOffset: firstWord.Base.Offset, extentOffset: lastWord.Extent.Offset, affinity: firstWord.Affinity), cause);
}




/// <Summary>
/// Move the selection to the beginning or end of a word.
///
/// {@macro flutter.rendering.editable.select}
/// </Summary>
public virtual void SelectWordEdge(FlutterSDK.Rendering.Editable.SelectionChangedCause cause = default(FlutterSDK.Rendering.Editable.SelectionChangedCause))
{

    _LayoutText(minWidth: Constraints.MinWidth, maxWidth: Constraints.MaxWidth);

    if (OnSelectionChanged == null)
    {
        return;
    }

    TextPosition position = _TextPainter.GetPositionForOffset(GlobalToLocal(_LastTapDownPosition - _PaintOffset));
    TextRange word = _TextPainter.GetWordBoundary(position);
    if (position.Offset - word.Start <= 1)
    {
        _HandleSelectionChange(TextSelection.Collapsed(offset: word.Start, affinity: TextAffinity.Downstream), cause);
    }
    else
    {
        _HandleSelectionChange(TextSelection.Collapsed(offset: word.End, affinity: TextAffinity.Upstream), cause);
    }

}




private FlutterSDK.Services.Textediting.TextSelection _SelectWordAtOffset(TextPosition position)
{

    TextRange word = _TextPainter.GetWordBoundary(position);
    if (position.Offset >= word.End) return TextSelection.FromPosition(position);
    if (ObscureText)
    {
        return new TextSelection(baseOffset: 0, extentOffset: _PlainText.Length);
    }

    return new TextSelection(baseOffset: word.Start, extentOffset: word.End);
}




private FlutterSDK.Services.Textediting.TextSelection _SelectLineAtOffset(TextPosition position)
{

    TextRange line = _TextPainter.GetLineBoundary(position);
    if (position.Offset >= line.End) return TextSelection.FromPosition(position);
    if (ObscureText)
    {
        return new TextSelection(baseOffset: 0, extentOffset: _PlainText.Length);
    }

    return new TextSelection(baseOffset: line.Start, extentOffset: line.End);
}




private void _LayoutText(double minWidth = 0.0, double maxWidth = default(double))
{

    if (_TextLayoutLastMaxWidth == maxWidth && _TextLayoutLastMinWidth == minWidth) return;
    double availableMaxWidth = Math.Dart:mathDefaultClass.Max(0.0, maxWidth - _CaretMargin);
double availableMinWidth = Math.Dart:mathDefaultClass.Min(minWidth, availableMaxWidth);
double textMaxWidth = _IsMultiline ? availableMaxWidth : Dart:coreDefaultClass.Double.Infinity;
double textMinWidth = ForceLine ? availableMaxWidth : availableMinWidth;
_TextPainter.Layout(minWidth: textMinWidth, maxWidth: textMaxWidth);
_TextLayoutLastMinWidth = minWidth;
_TextLayoutLastMaxWidth = maxWidth;
}




public new void PerformLayout()
{
    BoxConstraints constraints = this.Constraints;
    _LayoutText(minWidth: constraints.MinWidth, maxWidth: constraints.MaxWidth);
    _CaretPrototype = _GetCaretPrototype;
    _SelectionRects = null;
    Size textPainterSize = _TextPainter.Size;
    double width = ForceLine ? constraints.MaxWidth : constraints.ConstrainWidth(_TextPainter.Size.Width + _CaretMargin);
    Size = new Size(width, constraints.ConstrainHeight(_PreferredHeight(constraints.MaxWidth)));
    Size contentSize = new Size(textPainterSize.Width + _CaretMargin, textPainterSize.Height);
    _MaxScrollExtent = _GetMaxScrollExtent(contentSize);
    Offset.ApplyViewportDimension(_ViewportExtent);
    Offset.ApplyContentDimensions(0.0, _MaxScrollExtent);
}




private Offset _GetPixelPerfectCursorOffset(FlutterBinding.UI.Rect caretRect)
{
    Offset caretPosition = LocalToGlobal(caretRect.TopLeft);
    double pixelMultiple = 1.0 / _DevicePixelRatio;
    int quotientX = (caretPosition.Dx / pixelMultiple).Round();
    int quotientY = (caretPosition.Dy / pixelMultiple).Round();
    double pixelPerfectOffsetX = quotientX * pixelMultiple - caretPosition.Dx;
    double pixelPerfectOffsetY = quotientY * pixelMultiple - caretPosition.Dy;
    return new Offset(pixelPerfectOffsetX, pixelPerfectOffsetY);
}




private void _PaintCaret(Canvas canvas, FlutterBinding.UI.Offset effectiveOffset, TextPosition textPosition)
{

    Paint paint = new Paint()..Color = _FloatingCursorOn ? BackgroundCursorColor : _CursorColor;
    Offset caretOffset = _TextPainter.GetOffsetForCaret(textPosition, _CaretPrototype) + effectiveOffset;
    Rect caretRect = _CaretPrototype.Shift(caretOffset);
    if (_CursorOffset != null) caretRect = caretRect.Shift(_CursorOffset);
    double caretHeight = _TextPainter.GetFullHeightForCaret(textPosition, _CaretPrototype);
    if (caretHeight != null)
    {
        switch (PlatformDefaultClass.DefaultTargetPlatform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: double heightDiff = caretHeight - caretRect.Height; caretRect = Rect.FromLTWH(caretRect.Left, caretRect.Top + heightDiff / 2, caretRect.Width, caretRect.Height); break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: caretRect = Rect.FromLTWH(caretRect.Left, caretRect.Top - EditableDefaultClass._KCaretHeightOffset, caretRect.Width, caretHeight); break; }
    }

    caretRect = caretRect.Shift(_GetPixelPerfectCursorOffset(caretRect));
    if (CursorRadius == null)
    {
        canvas.DrawRect(caretRect, paint);
    }
    else
    {
        RRect caretRRect = RRect.FromRectAndRadius(caretRect, CursorRadius);
        canvas.DrawRRect(caretRRect, paint);
    }

    if (caretRect != _LastCaretRect)
    {
        _LastCaretRect = caretRect;
        if (OnCaretChanged != null) OnCaretChanged(caretRect);
    }

}




/// <Summary>
/// Sets the screen position of the floating cursor and the text position
/// closest to the cursor.
/// </Summary>
public virtual void SetFloatingCursor(FlutterSDK.Services.Textinput.FloatingCursorDragState state, FlutterBinding.UI.Offset boundedOffset, TextPosition lastTextPosition, double resetLerpValue = default(double))
{



    if (state == FloatingCursorDragState.Start)
    {
        _RelativeOrigin = new Offset(0, 0);
        _PreviousOffset = null;
        _ResetOriginOnBottom = false;
        _ResetOriginOnTop = false;
        _ResetOriginOnRight = false;
        _ResetOriginOnBottom = false;
    }

    _FloatingCursorOn = state != FloatingCursorDragState.End;
    _ResetFloatingCursorAnimationValue = resetLerpValue;
    if (_FloatingCursorOn)
    {
        _FloatingCursorOffset = boundedOffset;
        _FloatingCursorTextPosition = lastTextPosition;
    }

    MarkNeedsPaint();
}




private void _PaintFloatingCaret(Canvas canvas, FlutterBinding.UI.Offset effectiveOffset)
{


    Paint paint = new Paint()..Color = _CursorColor.WithOpacity(0.75);
    double sizeAdjustmentX = EditableDefaultClass._KFloatingCaretSizeIncrease.Dx;
    double sizeAdjustmentY = EditableDefaultClass._KFloatingCaretSizeIncrease.Dy;
    if (_ResetFloatingCursorAnimationValue != null)
    {
        sizeAdjustmentX = Ui.Dart:uiDefaultClass.LerpDouble(sizeAdjustmentX, 0, _ResetFloatingCursorAnimationValue);
sizeAdjustmentY = Ui.Dart:uiDefaultClass.LerpDouble(sizeAdjustmentY, 0, _ResetFloatingCursorAnimationValue);
}

Rect floatingCaretPrototype = Rect.FromLTRB(_CaretPrototype.Left - sizeAdjustmentX, _CaretPrototype.Top - sizeAdjustmentY, _CaretPrototype.Right + sizeAdjustmentX, _CaretPrototype.Bottom + sizeAdjustmentY);
Rect caretRect = floatingCaretPrototype.Shift(effectiveOffset);
Radius floatingCursorRadius = Radius.Circular(EditableDefaultClass._KFloatingCaretRadius);
RRect caretRRect = RRect.FromRectAndRadius(caretRect, floatingCursorRadius);
canvas.DrawRRect(caretRRect, paint);
}




/// <Summary>
/// Returns the position within the text field closest to the raw cursor offset.
/// </Summary>
public virtual Offset CalculateBoundedFloatingCursorOffset(FlutterBinding.UI.Offset rawCursorOffset)
{
    Offset deltaPosition = new Offset(0, 0);
    double topBound = -FloatingCursorAddedMargin.Top;
    double bottomBound = _TextPainter.Height - PreferredLineHeight + FloatingCursorAddedMargin.Bottom;
    double leftBound = -FloatingCursorAddedMargin.Left;
    double rightBound = _TextPainter.Width + FloatingCursorAddedMargin.Right;
    if (_PreviousOffset != null) deltaPosition = rawCursorOffset - _PreviousOffset;
    if (_ResetOriginOnLeft && deltaPosition.Dx > 0)
    {
        _RelativeOrigin = new Offset(rawCursorOffset.Dx - leftBound, _RelativeOrigin.Dy);
        _ResetOriginOnLeft = false;
    }
    else if (_ResetOriginOnRight && deltaPosition.Dx < 0)
    {
        _RelativeOrigin = new Offset(rawCursorOffset.Dx - rightBound, _RelativeOrigin.Dy);
        _ResetOriginOnRight = false;
    }

    if (_ResetOriginOnTop && deltaPosition.Dy > 0)
    {
        _RelativeOrigin = new Offset(_RelativeOrigin.Dx, rawCursorOffset.Dy - topBound);
        _ResetOriginOnTop = false;
    }
    else if (_ResetOriginOnBottom && deltaPosition.Dy < 0)
    {
        _RelativeOrigin = new Offset(_RelativeOrigin.Dx, rawCursorOffset.Dy - bottomBound);
        _ResetOriginOnBottom = false;
    }

    double currentX = rawCursorOffset.Dx - _RelativeOrigin.Dx;
    double currentY = rawCursorOffset.Dy - _RelativeOrigin.Dy;
    double adjustedX = Math.Dart:mathDefaultClass.Min(Math.Dart:mathDefaultClass.Max(currentX, leftBound), rightBound);
    double adjustedY = Math.Dart:mathDefaultClass.Min(Math.Dart:mathDefaultClass.Max(currentY, topBound), bottomBound);
    Offset adjustedOffset = new Offset(adjustedX, adjustedY);
    if (currentX < leftBound && deltaPosition.Dx < 0) _ResetOriginOnLeft = true; else if (currentX > rightBound && deltaPosition.Dx > 0) _ResetOriginOnRight = true;
    if (currentY < topBound && deltaPosition.Dy < 0) _ResetOriginOnTop = true; else if (currentY > bottomBound && deltaPosition.Dy > 0) _ResetOriginOnBottom = true;
    _PreviousOffset = rawCursorOffset;
    return adjustedOffset;
}




private void _PaintSelection(Canvas canvas, FlutterBinding.UI.Offset effectiveOffset)
{


    Paint paint = new Paint()..Color = _SelectionColor;
    foreach (Ui.Dart:uiDefaultClass.TextBox box  in _SelectionRects)canvas.DrawRect(box.ToRect().Shift(effectiveOffset), paint);
}




private void _PaintContents(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

    Offset effectiveOffset = offset + _PaintOffset;
    bool showSelection = false;
    bool showCaret = false;
    if (_Selection != null && !_FloatingCursorOn)
    {
        if (_Selection.IsCollapsed && _ShowCursor.Value && CursorColor != null) showCaret = true; else if (!_Selection.IsCollapsed && _SelectionColor != null) showSelection = true;
        _UpdateSelectionExtentsVisibility(effectiveOffset);
    }

    if (showSelection)
    {
        _SelectionRects = (_SelectionRects == null ? _TextPainter.GetBoxesForSelection(_Selection, boxHeightStyle: _SelectionHeightStyle, boxWidthStyle: _SelectionWidthStyle) : _SelectionRects);
        _PaintSelection(context.Canvas, effectiveOffset);
    }

    if (PaintCursorAboveText) _TextPainter.Paint(context.Canvas, effectiveOffset);
    if (showCaret) _PaintCaret(context.Canvas, effectiveOffset, _Selection.Extent);
    if (!PaintCursorAboveText) _TextPainter.Paint(context.Canvas, effectiveOffset);
    if (_FloatingCursorOn)
    {
        if (_ResetFloatingCursorAnimationValue == null) _PaintCaret(context.Canvas, effectiveOffset, _FloatingCursorTextPosition);
        _PaintFloatingCaret(context.Canvas, _FloatingCursorOffset);
    }

}




private void _PaintHandleLayers(FlutterSDK.Rendering.@object.PaintingContext context, List<FlutterSDK.Rendering.Editable.TextSelectionPoint> endpoints)
{
    Offset startPoint = endpoints[0].Point;
    startPoint = new Offset(startPoint.Dx.Clamp(0.0, Size.Width) as double, startPoint.Dy.Clamp(0.0, Size.Height) as double);
    context.PushLayer(new LeaderLayer(link: StartHandleLayerLink, offset: startPoint), base.Paint, Dart: uiDefaultClass.Offset.Zero);
    if (endpoints.Count == 2)
    {
        Offset endPoint = endpoints[1].Point;
        endPoint = new Offset(endPoint.Dx.Clamp(0.0, Size.Width) as double, endPoint.Dy.Clamp(0.0, Size.Height) as double);
        context.PushLayer(new LeaderLayer(link: EndHandleLayerLink, offset: endPoint), base.Paint, Dart: uiDefaultClass.Offset.Zero);
    }

}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    _LayoutText(minWidth: Constraints.MinWidth, maxWidth: Constraints.MaxWidth);
    if (_HasVisualOverflow) context.PushClipRect(NeedsCompositing, offset, Dart: uiDefaultClass.Offset.Zero & Size, _PaintContents); else _PaintContents(context, offset);
    _PaintHandleLayers(context, GetEndpointsForSelection(Selection));
}




public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child) => _HasVisualOverflow ? Dart : uiDefaultClass.Offset.Zero & Size:null;



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    properties.Add(new ColorProperty("cursorColor", CursorColor));
    properties.Add(new DiagnosticsProperty<ValueNotifier<bool>>("showCursor", ShowCursor));
    properties.Add(new IntProperty("maxLines", MaxLines));
    properties.Add(new IntProperty("minLines", MinLines));
    properties.Add(new DiagnosticsProperty<bool>("expands", Expands, defaultValue: false));
    properties.Add(new ColorProperty("selectionColor", SelectionColor));
    properties.Add(new DoubleProperty("textScaleFactor", TextScaleFactor));
    properties.Add(new DiagnosticsProperty<Locale>("locale", Locale, defaultValue: null));
    properties.Add(new DiagnosticsProperty<TextSelection>("selection", Selection));
    properties.Add(new DiagnosticsProperty<ViewportOffset>("offset", Offset));
}




public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
{
    return new List<DiagnosticsNode>() { Text.ToDiagnosticsNode(name: "text", style: DiagnosticsTreeStyle.Transition) };
}



#endregion
}


/// <Summary>
/// Indicates what triggered the change in selected text (including changes to
/// the cursor location).
/// </Summary>
public enum SelectionChangedCause
{

    /// <Summary>
    /// The user tapped on the text and that caused the selection (or the location
    /// of the cursor) to change.
    /// </Summary>
    Tap,
    /// <Summary>
    /// The user tapped twice in quick succession on the text and that caused
    /// the selection (or the location of the cursor) to change.
    /// </Summary>
    DoubleTap,
    /// <Summary>
    /// The user long-pressed the text and that caused the selection (or the
    /// location of the cursor) to change.
    /// </Summary>
    LongPress,
    /// <Summary>
    /// The user force-pressed the text and that caused the selection (or the
    /// location of the cursor) to change.
    /// </Summary>
    ForcePress,
    /// <Summary>
    /// The user used the keyboard to change the selection or the location of the
    /// cursor.
    ///
    /// Keyboard-triggered selection changes may be caused by the IME as well as
    /// by accessibility tools (e.g. TalkBack on Android).
    /// </Summary>
    Keyboard,
    /// <Summary>
    /// The user used the mouse to change the selection by dragging over a piece
    /// of text.
    /// </Summary>
    Drag,
}

}
