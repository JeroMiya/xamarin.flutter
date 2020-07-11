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
namespace FlutterSDK.Semantics.Semantics{
public delegate bool SemanticsNodeVisitor(FlutterSDK.Semantics.Semantics.SemanticsNode node);
public delegate void MoveCursorHandler(bool extendSelection);
public delegate void SetSelectionHandler(FlutterSDK.Services.Textediting.TextSelection selection);
public delegate void _SemanticsActionHandler(object args);
internal static class SemanticsDefaultClass{
internal static void DebugResetSemanticsIdCounter(){
throw new NotImplementedException();
}

internal static Offset _PointInParentCoordinates(FlutterSDK.Semantics.Semantics.SemanticsNode node,FlutterBinding.UI.Offset point){
throw new NotImplementedException();
}

internal static List<FlutterSDK.Semantics.Semantics.SemanticsNode> _ChildrenInDefaultOrder(List<FlutterSDK.Semantics.Semantics.SemanticsNode> children,TextDirection textDirection){
throw new NotImplementedException();
}

internal static string _ConcatStrings(string thisString = default(string),string otherString = default(string),TextDirection thisTextDirection = default(TextDirection),TextDirection otherTextDirection = default(TextDirection)){
throw new NotImplementedException();
}

}

public interface ISemanticsSortKey{
int CompareTo(FlutterSDK.Semantics.Semantics.SemanticsSortKey other);
int DoCompare(FlutterSDK.Semantics.Semantics.SemanticsSortKey other);
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
string Name{get;}
}


public interface ISemanticsConfiguration{}

public class SemanticsConfiguration{
internal virtual bool _IsSemanticBoundary{get;set;}
public virtual bool ExplicitChildNodes{get;set;}
public virtual bool IsBlockingSemanticsOfPreviouslyPaintedNodes{get;set;}
internal virtual bool _HasBeenAnnotated{get;set;}
internal virtual Dictionary<SemanticsAction,object> _Actions{get;set;}
internal virtual int _ActionsAsBits{get;set;}
internal virtual VoidCallback _OnTap{get;set;}
internal virtual VoidCallback _OnLongPress{get;set;}
internal virtual VoidCallback _OnScrollLeft{get;set;}
internal virtual VoidCallback _OnDismiss{get;set;}
internal virtual VoidCallback _OnScrollRight{get;set;}
internal virtual VoidCallback _OnScrollUp{get;set;}
internal virtual VoidCallback _OnScrollDown{get;set;}
internal virtual VoidCallback _OnIncrease{get;set;}
internal virtual VoidCallback _OnDecrease{get;set;}
internal virtual VoidCallback _OnCopy{get;set;}
internal virtual VoidCallback _OnCut{get;set;}
internal virtual VoidCallback _OnPaste{get;set;}
internal virtual VoidCallback _OnShowOnScreen{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorForwardByCharacter{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorBackwardByCharacter{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorForwardByWord{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler _OnMoveCursorBackwardByWord{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.SetSelectionHandler _OnSetSelection{get;set;}
internal virtual VoidCallback _OnDidGainAccessibilityFocus{get;set;}
internal virtual VoidCallback _OnDidLoseAccessibilityFocus{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey _SortKey{get;set;}
internal virtual int _IndexInParent{get;set;}
internal virtual int _ScrollChildCount{get;set;}
internal virtual int _ScrollIndex{get;set;}
internal virtual int _PlatformViewId{get;set;}
internal virtual int _MaxValueLength{get;set;}
internal virtual int _CurrentValueLength{get;set;}
internal virtual bool _IsMergingSemanticsOfDescendants{get;set;}
internal virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object> _CustomSemanticsActions{get;set;}
internal virtual string _Label{get;set;}
internal virtual string _Value{get;set;}
internal virtual string _DecreasedValue{get;set;}
internal virtual string _IncreasedValue{get;set;}
internal virtual string _Hint{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides _HintOverrides{get;set;}
internal virtual double _Elevation{get;set;}
internal virtual double _Thickness{get;set;}
internal virtual TextDirection _TextDirection{get;set;}
internal virtual FlutterSDK.Services.Textediting.TextSelection _TextSelection{get;set;}
internal virtual double _ScrollPosition{get;set;}
internal virtual double _ScrollExtentMax{get;set;}
internal virtual double _ScrollExtentMin{get;set;}
internal virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> _TagsForChildren{get;set;}
internal virtual int _Flags{get;set;}
public virtual bool IsSemanticBoundary{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool HasBeenAnnotated{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual VoidCallback OnTap{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnLongPress{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnScrollLeft{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnDismiss{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnScrollRight{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnScrollUp{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnScrollDown{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnIncrease{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnDecrease{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnCopy{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnCut{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnPaste{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnShowOnScreen{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByCharacter{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByCharacter{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByWord{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByWord{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.SetSelectionHandler OnSetSelection{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnDidGainAccessibilityFocus{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual VoidCallback OnDidLoseAccessibilityFocus{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKey{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual int IndexInParent{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual int ScrollChildCount{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual int ScrollIndex{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual int PlatformViewId{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual int MaxValueLength{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual int CurrentValueLength{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsMergingSemanticsOfDescendants{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object> CustomSemanticsActions{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual string Label{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual string Value{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual string DecreasedValue{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual string IncreasedValue{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual string Hint{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides HintOverrides{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual double Elevation{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual double Thickness{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool ScopesRoute{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool NamesRoute{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsImage{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool LiveRegion{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual TextDirection TextDirection{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsSelected{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsEnabled{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsChecked{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsToggled{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsInMutuallyExclusiveGroup{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsFocusable{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsFocused{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsButton{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsLink{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsHeader{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsHidden{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsTextField{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsReadOnly{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsObscured{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsMultiline{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool HasImplicitScrolling{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Services.Textediting.TextSelection TextSelection{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual double ScrollPosition{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual double ScrollExtentMax{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual double ScrollExtentMin{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual Iterable<FlutterSDK.Semantics.Semantics.SemanticsTag> TagsForChildren{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}

private void _AddAction(SemanticsAction action,FlutterSDK.Semantics.Semantics._SemanticsActionHandler handler){ throw new NotImplementedException(); }


private void _AddArgumentlessAction(SemanticsAction action,VoidCallback handler){ throw new NotImplementedException(); }


public virtual FlutterSDK.Semantics.Semantics._SemanticsActionHandler GetActionHandler(SemanticsAction action){ throw new NotImplementedException(); }


private void _OnCustomSemanticsAction(object args){ throw new NotImplementedException(); }


public virtual void AddTagForChildren(FlutterSDK.Semantics.Semantics.SemanticsTag tag){ throw new NotImplementedException(); }


private void _SetFlag(SemanticsFlag flag,bool value){ throw new NotImplementedException(); }


private bool _HasFlag(SemanticsFlag flag){ throw new NotImplementedException(); }


public virtual bool IsCompatibleWith(FlutterSDK.Semantics.Semantics.SemanticsConfiguration other){ throw new NotImplementedException(); }


public virtual void Absorb(FlutterSDK.Semantics.Semantics.SemanticsConfiguration child){ throw new NotImplementedException(); }


public virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration Copy(){ throw new NotImplementedException(); }

}
public static class SemanticsConfigurationMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<ISemanticsConfiguration, SemanticsConfiguration> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ISemanticsConfiguration, SemanticsConfiguration>();
static SemanticsConfiguration GetOrCreate(ISemanticsConfiguration instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new SemanticsConfiguration();
_table.Add(instance, value);
}
return (SemanticsConfiguration)value;
}
public static bool ExplicitChildNodesProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ExplicitChildNodes;
public static bool IsBlockingSemanticsOfPreviouslyPaintedNodesProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsBlockingSemanticsOfPreviouslyPaintedNodes;
public static bool IsSemanticBoundaryProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsSemanticBoundary;
public static bool HasBeenAnnotatedProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).HasBeenAnnotated;
public static VoidCallback OnTapProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnTap;
public static VoidCallback OnLongPressProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnLongPress;
public static VoidCallback OnScrollLeftProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnScrollLeft;
public static VoidCallback OnDismissProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnDismiss;
public static VoidCallback OnScrollRightProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnScrollRight;
public static VoidCallback OnScrollUpProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnScrollUp;
public static VoidCallback OnScrollDownProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnScrollDown;
public static VoidCallback OnIncreaseProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnIncrease;
public static VoidCallback OnDecreaseProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnDecrease;
public static VoidCallback OnCopyProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnCopy;
public static VoidCallback OnCutProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnCut;
public static VoidCallback OnPasteProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnPaste;
public static VoidCallback OnShowOnScreenProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnShowOnScreen;
public static FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByCharacterProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnMoveCursorForwardByCharacter;
public static FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByCharacterProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnMoveCursorBackwardByCharacter;
public static FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByWordProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnMoveCursorForwardByWord;
public static FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByWordProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnMoveCursorBackwardByWord;
public static FlutterSDK.Semantics.Semantics.SetSelectionHandler OnSetSelectionProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnSetSelection;
public static VoidCallback OnDidGainAccessibilityFocusProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnDidGainAccessibilityFocus;
public static VoidCallback OnDidLoseAccessibilityFocusProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).OnDidLoseAccessibilityFocus;
public static FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKeyProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).SortKey;
public static int IndexInParentProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IndexInParent;
public static int ScrollChildCountProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScrollChildCount;
public static int ScrollIndexProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScrollIndex;
public static int PlatformViewIdProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).PlatformViewId;
public static int MaxValueLengthProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).MaxValueLength;
public static int CurrentValueLengthProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).CurrentValueLength;
public static bool IsMergingSemanticsOfDescendantsProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsMergingSemanticsOfDescendants;
public static Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object> CustomSemanticsActionsProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).CustomSemanticsActions;
public static string LabelProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).Label;
public static string ValueProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).Value;
public static string DecreasedValueProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).DecreasedValue;
public static string IncreasedValueProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IncreasedValue;
public static string HintProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).Hint;
public static FlutterSDK.Semantics.Semantics.SemanticsHintOverrides HintOverridesProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).HintOverrides;
public static double ElevationProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).Elevation;
public static double ThicknessProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).Thickness;
public static bool ScopesRouteProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScopesRoute;
public static bool NamesRouteProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).NamesRoute;
public static bool IsImageProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsImage;
public static bool LiveRegionProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).LiveRegion;
public static TextDirection TextDirectionProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).TextDirection;
public static bool IsSelectedProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsSelected;
public static bool IsEnabledProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsEnabled;
public static bool IsCheckedProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsChecked;
public static bool IsToggledProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsToggled;
public static bool IsInMutuallyExclusiveGroupProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsInMutuallyExclusiveGroup;
public static bool IsFocusableProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsFocusable;
public static bool IsFocusedProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsFocused;
public static bool IsButtonProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsButton;
public static bool IsLinkProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsLink;
public static bool IsHeaderProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsHeader;
public static bool IsHiddenProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsHidden;
public static bool IsTextFieldProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsTextField;
public static bool IsReadOnlyProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsReadOnly;
public static bool IsObscuredProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsObscured;
public static bool IsMultilineProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).IsMultiline;
public static bool HasImplicitScrollingProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).HasImplicitScrolling;
public static FlutterSDK.Services.Textediting.TextSelection TextSelectionProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).TextSelection;
public static double ScrollPositionProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScrollPosition;
public static double ScrollExtentMaxProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScrollExtentMax;
public static double ScrollExtentMinProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).ScrollExtentMin;
public static Iterable<FlutterSDK.Semantics.Semantics.SemanticsTag> TagsForChildrenProperty(this ISemanticsConfiguration instance) => GetOrCreate(instance).TagsForChildren;
public static FlutterSDK.Semantics.Semantics._SemanticsActionHandler GetActionHandler(this ISemanticsConfiguration instance,SemanticsAction action) => GetOrCreate(instance).GetActionHandler(action);
public static void AddTagForChildren(this ISemanticsConfiguration instance,FlutterSDK.Semantics.Semantics.SemanticsTag tag) => GetOrCreate(instance).AddTagForChildren(tag);
public static bool IsCompatibleWith(this ISemanticsConfiguration instance,FlutterSDK.Semantics.Semantics.SemanticsConfiguration other) => GetOrCreate(instance).IsCompatibleWith(other);
public static void Absorb(this ISemanticsConfiguration instance,FlutterSDK.Semantics.Semantics.SemanticsConfiguration child) => GetOrCreate(instance).Absorb(child);
public static FlutterSDK.Semantics.Semantics.SemanticsConfiguration Copy(this ISemanticsConfiguration instance) => GetOrCreate(instance).Copy();
}


public class SemanticsTag
{
#region constructors
public SemanticsTag(string name)
{
this.Name = name;throw new NotImplementedException(); }
#endregion

#region fields
public virtual string Name{get;set;}
#endregion

#region methods

#endregion
}


public class CustomSemanticsAction
{
#region constructors
public CustomSemanticsAction(string label = default(string))
: base()
{
this.Label = label;throw new NotImplementedException(); }
public static CustomSemanticsAction OverridingAction(string hint = default(string),SemanticsAction action = default(SemanticsAction))
{
var instance =new CustomSemanticsAction();instance.Hint = hint;
instance.Action = action;throw new NotImplementedException(); }
#endregion

#region fields
public virtual string Label{get;set;}
public virtual string Hint{get;set;}
public virtual SemanticsAction Action{get;set;}
internal virtual int _NextId{get;set;}
internal virtual Dictionary<int,FlutterSDK.Semantics.Semantics.CustomSemanticsAction> _Actions{get;set;}
internal virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,int> _Ids{get;set;}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool Equals(@Object other){ throw new NotImplementedException(); }



public virtual int GetIdentifier(FlutterSDK.Semantics.Semantics.CustomSemanticsAction action){ throw new NotImplementedException(); }


public virtual FlutterSDK.Semantics.Semantics.CustomSemanticsAction GetAction(int id){ throw new NotImplementedException(); }

#endregion
}


public class SemanticsData : IDiagnosticable
{
#region constructors
public SemanticsData(int flags = default(int),int actions = default(int),string label = default(string),string increasedValue = default(string),string value = default(string),string decreasedValue = default(string),string hint = default(string),TextDirection textDirection = default(TextDirection),FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect),double elevation = default(double),double thickness = default(double),FlutterSDK.Services.Textediting.TextSelection textSelection = default(FlutterSDK.Services.Textediting.TextSelection),int scrollIndex = default(int),int scrollChildCount = default(int),double scrollPosition = default(double),double scrollExtentMax = default(double),double scrollExtentMin = default(double),int platformViewId = default(int),int maxValueLength = default(int),int currentValueLength = default(int),HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> tags = default(HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag>),Matrix4 transform = default(Matrix4),List<int> customSemanticsActionIds = default(List<int>))
: base()
{
this.Flags = flags;
this.Actions = actions;
this.Label = label;
this.IncreasedValue = increasedValue;
this.Value = value;
this.DecreasedValue = decreasedValue;
this.Hint = hint;
this.TextDirection = textDirection;
this.Rect = rect;
this.Elevation = elevation;
this.Thickness = thickness;
this.TextSelection = textSelection;
this.ScrollIndex = scrollIndex;
this.ScrollChildCount = scrollChildCount;
this.ScrollPosition = scrollPosition;
this.ScrollExtentMax = scrollExtentMax;
this.ScrollExtentMin = scrollExtentMin;
this.PlatformViewId = platformViewId;
this.MaxValueLength = maxValueLength;
this.CurrentValueLength = currentValueLength;
this.Tags = tags;
this.Transform = transform;
this.CustomSemanticsActionIds = customSemanticsActionIds;throw new NotImplementedException(); }
#endregion

#region fields
public virtual int Flags{get;set;}
public virtual int Actions{get;set;}
public virtual string Label{get;set;}
public virtual string Value{get;set;}
public virtual string IncreasedValue{get;set;}
public virtual string DecreasedValue{get;set;}
public virtual string Hint{get;set;}
public virtual TextDirection TextDirection{get;set;}
public virtual FlutterSDK.Services.Textediting.TextSelection TextSelection{get;set;}
public virtual int ScrollChildCount{get;set;}
public virtual int ScrollIndex{get;set;}
public virtual double ScrollPosition{get;set;}
public virtual double ScrollExtentMax{get;set;}
public virtual double ScrollExtentMin{get;set;}
public virtual int PlatformViewId{get;set;}
public virtual int MaxValueLength{get;set;}
public virtual int CurrentValueLength{get;set;}
public virtual FlutterBinding.UI.Rect Rect{get;set;}
public virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> Tags{get;set;}
public virtual Matrix4 Transform{get;set;}
public virtual double Elevation{get;set;}
public virtual double Thickness{get;set;}
public virtual List<int> CustomSemanticsActionIds{get;set;}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual bool HasFlag(SemanticsFlag flag){ throw new NotImplementedException(); }


public virtual bool HasAction(SemanticsAction action){ throw new NotImplementedException(); }


public new string ToStringShort(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }


public new bool Equals(@Object other){ throw new NotImplementedException(); }


private bool _SortedListsEqual(List<int> left,List<int> right){ throw new NotImplementedException(); }

#endregion
}


public class _SemanticsDiagnosticableNode : FlutterSDK.Foundation.Diagnostics.DiagnosticableNode<FlutterSDK.Semantics.Semantics.SemanticsNode>
{
#region constructors
public _SemanticsDiagnosticableNode(string name = default(string),FlutterSDK.Semantics.Semantics.SemanticsNode value = default(FlutterSDK.Semantics.Semantics.SemanticsNode),FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle),FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder = default(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder))
: base(name:name,value:value,style:style)
{
this.ChildOrder = childOrder;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder ChildOrder{get;set;}
#endregion

#region methods

public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren(){ throw new NotImplementedException(); }

#endregion
}


public class SemanticsHintOverrides : FlutterSDK.Foundation.Diagnostics.DiagnosticableTree
{
#region constructors
public SemanticsHintOverrides(string onTapHint = default(string),string onLongPressHint = default(string))
: base()
{
this.OnTapHint = onTapHint;
this.OnLongPressHint = onLongPressHint;throw new NotImplementedException(); }
#endregion

#region fields
public virtual string OnTapHint{get;set;}
public virtual string OnLongPressHint{get;set;}
public virtual bool IsNotEmpty{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool Equals(@Object other){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class SemanticsProperties : FlutterSDK.Foundation.Diagnostics.DiagnosticableTree
{
#region constructors
public SemanticsProperties(bool enabled = default(bool),bool @checked = default(bool),bool selected = default(bool),bool toggled = default(bool),bool button = default(bool),bool link = default(bool),bool header = default(bool),bool textField = default(bool),bool readOnly = default(bool),bool focusable = default(bool),bool focused = default(bool),bool inMutuallyExclusiveGroup = default(bool),bool hidden = default(bool),bool obscured = default(bool),bool multiline = default(bool),bool scopesRoute = default(bool),bool namesRoute = default(bool),bool image = default(bool),bool liveRegion = default(bool),int maxValueLength = default(int),int currentValueLength = default(int),string label = default(string),string value = default(string),string increasedValue = default(string),string decreasedValue = default(string),string hint = default(string),FlutterSDK.Semantics.Semantics.SemanticsHintOverrides hintOverrides = default(FlutterSDK.Semantics.Semantics.SemanticsHintOverrides),TextDirection textDirection = default(TextDirection),FlutterSDK.Semantics.Semantics.SemanticsSortKey sortKey = default(FlutterSDK.Semantics.Semantics.SemanticsSortKey),VoidCallback onTap = default(VoidCallback),VoidCallback onLongPress = default(VoidCallback),VoidCallback onScrollLeft = default(VoidCallback),VoidCallback onScrollRight = default(VoidCallback),VoidCallback onScrollUp = default(VoidCallback),VoidCallback onScrollDown = default(VoidCallback),VoidCallback onIncrease = default(VoidCallback),VoidCallback onDecrease = default(VoidCallback),VoidCallback onCopy = default(VoidCallback),VoidCallback onCut = default(VoidCallback),VoidCallback onPaste = default(VoidCallback),FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorForwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler),FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorBackwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler),FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorForwardByWord = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler),FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorBackwardByWord = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler),FlutterSDK.Semantics.Semantics.SetSelectionHandler onSetSelection = default(FlutterSDK.Semantics.Semantics.SetSelectionHandler),VoidCallback onDidGainAccessibilityFocus = default(VoidCallback),VoidCallback onDidLoseAccessibilityFocus = default(VoidCallback),VoidCallback onDismiss = default(VoidCallback),Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object> customSemanticsActions = default(Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object>))
{
this.Enabled = enabled;
this.@checked = @checked;
this.Selected = selected;
this.Toggled = toggled;
this.Button = button;
this.Link = link;
this.Header = header;
this.TextField = textField;
this.ReadOnly = readOnly;
this.Focusable = focusable;
this.Focused = focused;
this.InMutuallyExclusiveGroup = inMutuallyExclusiveGroup;
this.Hidden = hidden;
this.Obscured = obscured;
this.Multiline = multiline;
this.ScopesRoute = scopesRoute;
this.NamesRoute = namesRoute;
this.Image = image;
this.LiveRegion = liveRegion;
this.MaxValueLength = maxValueLength;
this.CurrentValueLength = currentValueLength;
this.Label = label;
this.Value = value;
this.IncreasedValue = increasedValue;
this.DecreasedValue = decreasedValue;
this.Hint = hint;
this.HintOverrides = hintOverrides;
this.TextDirection = textDirection;
this.SortKey = sortKey;
this.OnTap = onTap;
this.OnLongPress = onLongPress;
this.OnScrollLeft = onScrollLeft;
this.OnScrollRight = onScrollRight;
this.OnScrollUp = onScrollUp;
this.OnScrollDown = onScrollDown;
this.OnIncrease = onIncrease;
this.OnDecrease = onDecrease;
this.OnCopy = onCopy;
this.OnCut = onCut;
this.OnPaste = onPaste;
this.OnMoveCursorForwardByCharacter = onMoveCursorForwardByCharacter;
this.OnMoveCursorBackwardByCharacter = onMoveCursorBackwardByCharacter;
this.OnMoveCursorForwardByWord = onMoveCursorForwardByWord;
this.OnMoveCursorBackwardByWord = onMoveCursorBackwardByWord;
this.OnSetSelection = onSetSelection;
this.OnDidGainAccessibilityFocus = onDidGainAccessibilityFocus;
this.OnDidLoseAccessibilityFocus = onDidLoseAccessibilityFocus;
this.OnDismiss = onDismiss;
this.CustomSemanticsActions = customSemanticsActions;throw new NotImplementedException(); }
#endregion

#region fields
public virtual bool Enabled{get;set;}
public virtual bool @checked{get;set;}
public virtual bool Toggled{get;set;}
public virtual bool Selected{get;set;}
public virtual bool Button{get;set;}
public virtual bool Link{get;set;}
public virtual bool Header{get;set;}
public virtual bool TextField{get;set;}
public virtual bool ReadOnly{get;set;}
public virtual bool Focusable{get;set;}
public virtual bool Focused{get;set;}
public virtual bool InMutuallyExclusiveGroup{get;set;}
public virtual bool Hidden{get;set;}
public virtual bool Obscured{get;set;}
public virtual bool Multiline{get;set;}
public virtual bool ScopesRoute{get;set;}
public virtual bool NamesRoute{get;set;}
public virtual bool Image{get;set;}
public virtual bool LiveRegion{get;set;}
public virtual int MaxValueLength{get;set;}
public virtual int CurrentValueLength{get;set;}
public virtual string Label{get;set;}
public virtual string Value{get;set;}
public virtual string IncreasedValue{get;set;}
public virtual string DecreasedValue{get;set;}
public virtual string Hint{get;set;}
public virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides HintOverrides{get;set;}
public virtual TextDirection TextDirection{get;set;}
public virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKey{get;set;}
public virtual VoidCallback OnTap{get;set;}
public virtual VoidCallback OnLongPress{get;set;}
public virtual VoidCallback OnScrollLeft{get;set;}
public virtual VoidCallback OnScrollRight{get;set;}
public virtual VoidCallback OnScrollUp{get;set;}
public virtual VoidCallback OnScrollDown{get;set;}
public virtual VoidCallback OnIncrease{get;set;}
public virtual VoidCallback OnDecrease{get;set;}
public virtual VoidCallback OnCopy{get;set;}
public virtual VoidCallback OnCut{get;set;}
public virtual VoidCallback OnPaste{get;set;}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByCharacter{get;set;}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByCharacter{get;set;}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorForwardByWord{get;set;}
public virtual FlutterSDK.Semantics.Semantics.MoveCursorHandler OnMoveCursorBackwardByWord{get;set;}
public virtual FlutterSDK.Semantics.Semantics.SetSelectionHandler OnSetSelection{get;set;}
public virtual VoidCallback OnDidGainAccessibilityFocus{get;set;}
public virtual VoidCallback OnDidLoseAccessibilityFocus{get;set;}
public virtual VoidCallback OnDismiss{get;set;}
public virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object> CustomSemanticsActions{get;set;}
#endregion

#region methods

public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }


public new string ToStringShort(){ throw new NotImplementedException(); }

#endregion
}


public class SemanticsNode : FlutterSDK.Foundation.Node.AbstractNode,IDiagnosticableTreeMixin
{
#region constructors
public SemanticsNode(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),VoidCallback showOnScreen = default(VoidCallback))
: base()
{
this.Key = key;throw new NotImplementedException(); }
public static SemanticsNode Root(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),VoidCallback showOnScreen = default(VoidCallback),FlutterSDK.Semantics.Semantics.SemanticsOwner owner = default(FlutterSDK.Semantics.Semantics.SemanticsOwner))
{
var instance =new SemanticsNode();instance.Key = key;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual int _MaxFrameworkAccessibilityIdentifier{get;set;}
internal virtual int _LastIdentifier{get;set;}
public virtual FlutterSDK.Foundation.Key.Key Key{get;set;}
public virtual int Id{get;set;}
internal virtual VoidCallback _ShowOnScreen{get;set;}
internal virtual Matrix4 _Transform{get;set;}
internal virtual FlutterBinding.UI.Rect _Rect{get;set;}
public virtual FlutterBinding.UI.Rect ParentSemanticsClipRect{get;set;}
public virtual FlutterBinding.UI.Rect ParentPaintClipRect{get;set;}
public virtual double ElevationAdjustment{get;set;}
public virtual int IndexInParent{get;set;}
internal virtual bool _IsMergedIntoParent{get;set;}
internal virtual bool _MergeAllDescendantsIntoThisNode{get;set;}
internal virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> _Children{get;set;}
internal virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> _DebugPreviousSnapshot{get;set;}
internal virtual bool _Dead{get;set;}
internal virtual bool _Dirty{get;set;}
internal virtual Dictionary<SemanticsAction,object> _Actions{get;set;}
internal virtual Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction,object> _CustomSemanticsActions{get;set;}
internal virtual int _ActionsAsBits{get;set;}
public virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsTag> Tags{get;set;}
internal virtual int _Flags{get;set;}
internal virtual string _Label{get;set;}
internal virtual string _Value{get;set;}
internal virtual string _DecreasedValue{get;set;}
internal virtual string _IncreasedValue{get;set;}
internal virtual string _Hint{get;set;}
internal virtual double _Elevation{get;set;}
internal virtual double _Thickness{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides _HintOverrides{get;set;}
internal virtual TextDirection _TextDirection{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey _SortKey{get;set;}
internal virtual FlutterSDK.Services.Textediting.TextSelection _TextSelection{get;set;}
internal virtual bool _IsMultiline{get;set;}
internal virtual int _ScrollChildCount{get;set;}
internal virtual int _ScrollIndex{get;set;}
internal virtual double _ScrollPosition{get;set;}
internal virtual double _ScrollExtentMax{get;set;}
internal virtual double _ScrollExtentMin{get;set;}
internal virtual int _PlatformViewId{get;set;}
internal virtual int _MaxValueLength{get;set;}
internal virtual int _CurrentValueLength{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.SemanticsConfiguration _KEmptyConfig{get;set;}
internal virtual List<uint> _KEmptyChildList{get;set;}
internal virtual List<uint> _KEmptyCustomSemanticsActionsList{get;set;}
internal virtual List<float> _KIdentityTransform{get;set;}
public virtual object Transform{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Rect Rect{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsInvisible{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsMergedIntoParent{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsPartOfNodeMerging{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool MergeAllDescendantsIntoThisNode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool HasChildren{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int ChildrenCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Semantics.Semantics.SemanticsOwner Owner{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Semantics.Semantics.SemanticsNode Parent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual string Label{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual string Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual string DecreasedValue{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual string IncreasedValue{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual string Hint{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double Elevation{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double Thickness{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Semantics.Semantics.SemanticsHintOverrides HintOverrides{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual TextDirection TextDirection{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKey{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Services.Textediting.TextSelection TextSelection{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsMultiline{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int ScrollChildCount{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int ScrollIndex{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double ScrollPosition{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double ScrollExtentMax{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double ScrollExtentMin{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int PlatformViewId{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int MaxValueLength{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int CurrentValueLength{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private int _GenerateNewId(){ throw new NotImplementedException(); }


private void _ReplaceChildren(List<FlutterSDK.Semantics.Semantics.SemanticsNode> newChildren){ throw new NotImplementedException(); }


public virtual void VisitChildren(FlutterSDK.Semantics.Semantics.SemanticsNodeVisitor visitor){ throw new NotImplementedException(); }


private bool _VisitDescendants(FlutterSDK.Semantics.Semantics.SemanticsNodeVisitor visitor){ throw new NotImplementedException(); }


public new void RedepthChildren(){ throw new NotImplementedException(); }


public new void Attach(FlutterSDK.Semantics.Semantics.SemanticsOwner owner){ throw new NotImplementedException(); }
public new void Attach(@Object owner){ throw new NotImplementedException(); }


public new void Detach(){ throw new NotImplementedException(); }


private void _MarkDirty(){ throw new NotImplementedException(); }


private bool _IsDifferentFromCurrentSemanticAnnotation(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config){ throw new NotImplementedException(); }


public virtual bool IsTagged(FlutterSDK.Semantics.Semantics.SemanticsTag tag){ throw new NotImplementedException(); }


public virtual bool HasFlag(SemanticsFlag flag){ throw new NotImplementedException(); }


private bool _CanPerformAction(SemanticsAction action){ throw new NotImplementedException(); }


public virtual void UpdateWith(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config = default(FlutterSDK.Semantics.Semantics.SemanticsConfiguration),List<FlutterSDK.Semantics.Semantics.SemanticsNode> childrenInInversePaintOrder = default(List<FlutterSDK.Semantics.Semantics.SemanticsNode>)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Semantics.Semantics.SemanticsData GetSemanticsData(){ throw new NotImplementedException(); }


private List<float> _InitIdentityTransform(){ throw new NotImplementedException(); }


private void _AddToUpdate(SemanticsUpdateBuilder builder,HashSet<int> customSemanticsActionIdsUpdate){ throw new NotImplementedException(); }


private List<FlutterSDK.Semantics.Semantics.SemanticsNode> _ChildrenInTraversalOrder(){ throw new NotImplementedException(); }


public virtual void SendEvent(FlutterSDK.Semantics.Semanticsevent.SemanticsEvent @event){ throw new NotImplementedException(); }


public new string ToStringShort(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }


public new string ToStringDeep(string prefixLineOne = default(string),string prefixOtherLines = default(string),FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel),FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder = default(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder)){ throw new NotImplementedException(); }


public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string),FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle),FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder = default(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder)){ throw new NotImplementedException(); }


public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder = default(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder)){ throw new NotImplementedException(); }


public virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> DebugListChildrenInOrder(FlutterSDK.Semantics.Semantics.DebugSemanticsDumpOrder childOrder){ throw new NotImplementedException(); }

#endregion
}


public class _BoxEdge : IComparable<FlutterSDK.Semantics.Semantics._BoxEdge>
{
#region constructors
public _BoxEdge(bool isLeadingEdge = default(bool),double offset = default(double),FlutterSDK.Semantics.Semantics.SemanticsNode node = default(FlutterSDK.Semantics.Semantics.SemanticsNode))
: base()
{
this.IsLeadingEdge = isLeadingEdge;
this.Offset = offset;
this.Node = node;throw new NotImplementedException(); }
#endregion

#region fields
public virtual bool IsLeadingEdge{get;set;}
public virtual double Offset{get;set;}
public virtual FlutterSDK.Semantics.Semantics.SemanticsNode Node{get;set;}
#endregion

#region methods

public new int CompareTo(FlutterSDK.Semantics.Semantics._BoxEdge other){ throw new NotImplementedException(); }

#endregion
}


public class _SemanticsSortGroup : Comparable<FlutterSDK.Semantics.Semantics._SemanticsSortGroup>
{
#region constructors
public _SemanticsSortGroup(double startOffset = default(double),TextDirection textDirection = default(TextDirection))
: base()
{
this.StartOffset = startOffset;
this.TextDirection = textDirection;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double StartOffset{get;set;}
public virtual TextDirection TextDirection{get;set;}
public virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> Nodes{get;set;}
#endregion

#region methods

public new int CompareTo(FlutterSDK.Semantics.Semantics._SemanticsSortGroup other){ throw new NotImplementedException(); }


public virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> SortedWithinVerticalGroup(){ throw new NotImplementedException(); }


public virtual List<FlutterSDK.Semantics.Semantics.SemanticsNode> SortedWithinKnot(){ throw new NotImplementedException(); }

#endregion
}


public class _TraversalSortNode : IComparable<FlutterSDK.Semantics.Semantics._TraversalSortNode>
{
#region constructors
public _TraversalSortNode(FlutterSDK.Semantics.Semantics.SemanticsNode node = default(FlutterSDK.Semantics.Semantics.SemanticsNode),FlutterSDK.Semantics.Semantics.SemanticsSortKey sortKey = default(FlutterSDK.Semantics.Semantics.SemanticsSortKey),int position = default(int))
: base()
{
this.Node = node;
this.SortKey = sortKey;
this.Position = position;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Semantics.Semantics.SemanticsNode Node{get;set;}
public virtual FlutterSDK.Semantics.Semantics.SemanticsSortKey SortKey{get;set;}
public virtual int Position{get;set;}
#endregion

#region methods

public new int CompareTo(FlutterSDK.Semantics.Semantics._TraversalSortNode other){ throw new NotImplementedException(); }

#endregion
}


public class SemanticsOwner : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
{
#region constructors
public SemanticsOwner()
{ }
#endregion

#region fields
internal virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsNode> _DirtyNodes{get;set;}
internal virtual Dictionary<int,FlutterSDK.Semantics.Semantics.SemanticsNode> _Nodes{get;set;}
internal virtual HashSet<FlutterSDK.Semantics.Semantics.SemanticsNode> _DetachedNodes{get;set;}
public virtual FlutterSDK.Semantics.Semantics.SemanticsNode RootSemanticsNode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void Dispose(){ throw new NotImplementedException(); }


public virtual void SendSemanticsUpdate(){ throw new NotImplementedException(); }


private FlutterSDK.Semantics.Semantics._SemanticsActionHandler _GetSemanticsActionHandlerForId(int id,SemanticsAction action){ throw new NotImplementedException(); }


public virtual void PerformAction(int id,SemanticsAction action,object args = default(object)){ throw new NotImplementedException(); }


private FlutterSDK.Semantics.Semantics._SemanticsActionHandler _GetSemanticsActionHandlerForPosition(FlutterSDK.Semantics.Semantics.SemanticsNode node,FlutterBinding.UI.Offset position,SemanticsAction action){ throw new NotImplementedException(); }


public virtual void PerformActionAt(FlutterBinding.UI.Offset position,SemanticsAction action,object args = default(object)){ throw new NotImplementedException(); }


#endregion
}


public class SemanticsSortKey : IComparable<FlutterSDK.Semantics.Semantics.SemanticsSortKey>,IDiagnosticable
{
#region constructors
public SemanticsSortKey(string name = default(string))
{
this.Name = name;throw new NotImplementedException(); }
#endregion

#region fields
public virtual string Name{get;set;}
#endregion

#region methods

public new int CompareTo(FlutterSDK.Semantics.Semantics.SemanticsSortKey other){ throw new NotImplementedException(); }


public virtual int DoCompare(FlutterSDK.Semantics.Semantics.SemanticsSortKey other){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class OrdinalSortKey : FlutterSDK.Semantics.Semantics.SemanticsSortKey
{
#region constructors
public OrdinalSortKey(double order,string name = default(string))
: base(name:name)
{
this.Order = order;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double Order{get;set;}
#endregion

#region methods

public new int DoCompare(FlutterSDK.Semantics.Semantics.OrdinalSortKey other){ throw new NotImplementedException(); }
public new int DoCompare(FlutterSDK.Semantics.Semantics.SemanticsSortKey other){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public enum DebugSemanticsDumpOrder{

InverseHitTest,
TraversalOrder,
}

}
