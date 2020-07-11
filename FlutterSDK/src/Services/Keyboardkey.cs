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
namespace FlutterSDK.Services.Keyboardkey{
internal static class KeyboardkeyDefaultClass{
}

public interface IKeyboardKey{
}


public class KeyboardKey : IDiagnosticable
{
#region constructors
public KeyboardKey()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods
#endregion
}


public class LogicalKeyboardKey : FlutterSDK.Services.Keyboardkey.KeyboardKey
{
#region constructors
public LogicalKeyboardKey(int keyId,string debugName = default(string),string keyLabel = default(string))
: base()
{
this.KeyId = keyId;
this.DebugName = debugName;
this.KeyLabel = keyLabel;throw new NotImplementedException(); }
#endregion

#region fields
public virtual int KeyId{get;set;}
public virtual string DebugName{get;set;}
public virtual string KeyLabel{get;set;}
public virtual int ValueMask{get;set;}
public virtual int PlatformMask{get;set;}
public virtual int AutogeneratedMask{get;set;}
public virtual int SynonymMask{get;set;}
public virtual int UnicodePlane{get;set;}
public virtual int HidPlane{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey None{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Hyper{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey SuperKey{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey FnLock{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Suspend{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Resume{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Turbo{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey PrivacyScreenToggle{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Sleep{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey WakeUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey DisplayToggleIntExt{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey UsbReserved{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey UsbErrorRollOver{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey UsbPostFail{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey UsbErrorUndefined{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyA{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyB{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyC{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyD{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyE{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyF{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyG{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyH{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyI{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyJ{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyK{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyL{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyM{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyN{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyO{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyP{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyQ{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyR{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyS{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyT{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyU{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyV{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyW{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyX{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyY{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyZ{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit3{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit4{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit5{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit6{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit7{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit8{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit9{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Digit0{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Enter{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Escape{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Backspace{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Tab{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Space{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Minus{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Equal{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BracketLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BracketRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Backslash{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Semicolon{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Quote{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Backquote{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Comma{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Period{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Slash{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey CapsLock{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F3{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F4{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F5{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F6{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F7{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F8{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F9{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F10{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F11{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F12{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey PrintScreen{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ScrollLock{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Pause{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Insert{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Home{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey PageUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Delete{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey End{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey PageDown{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ArrowRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ArrowLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ArrowDown{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ArrowUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumLock{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadDivide{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMultiply{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadSubtract{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadAdd{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadEnter{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad3{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad4{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad5{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad6{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad7{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad8{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad9{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Numpad0{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadDecimal{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey IntlBackslash{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ContextMenu{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Power{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadEqual{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F13{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F14{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F15{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F16{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F17{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F18{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F19{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F20{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F21{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F22{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F23{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey F24{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Open{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Help{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Select{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Again{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Undo{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Cut{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Copy{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Paste{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Find{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey AudioVolumeMute{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey AudioVolumeUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey AudioVolumeDown{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadComma{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey IntlRo{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KanaMode{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey IntlYen{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Convert{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NonConvert{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Lang1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Lang2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Lang3{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Lang4{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Lang5{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Abort{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Props{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadParenLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadParenRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadBackspace{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMemoryStore{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMemoryRecall{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMemoryClear{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMemoryAdd{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadMemorySubtract{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadSignChange{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadClear{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NumpadClearEntry{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ControlLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ShiftLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey AltLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MetaLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ControlRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ShiftRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey AltRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MetaRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Info{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ClosedCaptionToggle{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessDown{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessToggle{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessMinimum{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessMaximum{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrightnessAuto{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaLast{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchPhone{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ProgramGuide{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Exit{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ChannelUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ChannelDown{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaPlay{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaPause{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaRecord{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaFastForward{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaRewind{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaTrackNext{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaTrackPrevious{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaStop{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Eject{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaPlayPause{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey SpeechInputToggle{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BassBoost{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MediaSelect{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchWordProcessor{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchSpreadsheet{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchMail{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchContacts{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchCalendar{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchApp2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchApp1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchInternetBrowser{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LogOff{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LockScreen{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchControlPanel{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey SelectTask{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchDocuments{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey SpellCheck{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchKeyboardLayout{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchScreenSaver{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchAssistant{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey LaunchAudioBrowser{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey NewKey{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Close{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Save{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Print{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserSearch{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserHome{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserBack{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserForward{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserStop{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserRefresh{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey BrowserFavorites{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ZoomIn{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ZoomOut{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ZoomToggle{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Redo{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MailReply{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MailForward{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey MailSend{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey KeyboardLayoutSelect{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey ShowAllWindows{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton3{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton4{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton5{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton6{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton7{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton8{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton9{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton10{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton11{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton12{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton13{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton14{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton15{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButton16{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonA{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonB{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonC{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonLeft1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonLeft2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonMode{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonRight1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonRight2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonSelect{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonStart{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonThumbLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonThumbRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonX{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonY{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey GameButtonZ{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Fn{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Shift{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Meta{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Alt{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey Control{get;set;}
internal virtual Dictionary<int,FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _KnownLogicalKeys{get;set;}
internal virtual Dictionary<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey,FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> _Synonyms{get;set;}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsAutogenerated{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> Synonyms{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool Equals(@Object other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey FindKeyByKeyId(int keyId){ throw new NotImplementedException(); }


public virtual bool IsControlCharacter(string label){ throw new NotImplementedException(); }


public virtual HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> CollapseSynonyms(HashSet<FlutterSDK.Services.Keyboardkey.LogicalKeyboardKey> input){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class PhysicalKeyboardKey : FlutterSDK.Services.Keyboardkey.KeyboardKey
{
#region constructors
public PhysicalKeyboardKey(int usbHidUsage,string debugName = default(string))
: base()
{
this.UsbHidUsage = usbHidUsage;
this.DebugName = debugName;throw new NotImplementedException(); }
#endregion

#region fields
public virtual int UsbHidUsage{get;set;}
public virtual string DebugName{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey None{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Hyper{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey SuperKey{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey FnLock{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Suspend{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Resume{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Turbo{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PrivacyScreenToggle{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Sleep{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey WakeUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey DisplayToggleIntExt{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey UsbReserved{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey UsbErrorRollOver{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey UsbPostFail{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey UsbErrorUndefined{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyA{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyB{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyC{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyD{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyE{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyF{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyG{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyH{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyI{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyJ{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyK{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyL{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyM{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyN{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyO{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyP{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyQ{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyR{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyS{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyT{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyU{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyV{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyW{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyX{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyY{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyZ{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit3{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit4{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit5{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit6{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit7{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit8{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit9{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Digit0{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Enter{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Escape{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Backspace{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Tab{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Space{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Minus{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Equal{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BracketLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BracketRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Backslash{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Semicolon{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Quote{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Backquote{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Comma{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Period{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Slash{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey CapsLock{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F3{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F4{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F5{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F6{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F7{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F8{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F9{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F10{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F11{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F12{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PrintScreen{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ScrollLock{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Pause{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Insert{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Home{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PageUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Delete{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey End{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey PageDown{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ArrowRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ArrowLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ArrowDown{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ArrowUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumLock{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadDivide{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMultiply{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadSubtract{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadAdd{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadEnter{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad3{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad4{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad5{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad6{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad7{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad8{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad9{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Numpad0{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadDecimal{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey IntlBackslash{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ContextMenu{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Power{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadEqual{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F13{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F14{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F15{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F16{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F17{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F18{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F19{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F20{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F21{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F22{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F23{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey F24{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Open{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Help{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Select{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Again{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Undo{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Cut{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Copy{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Paste{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Find{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey AudioVolumeMute{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey AudioVolumeUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey AudioVolumeDown{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadComma{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey IntlRo{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KanaMode{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey IntlYen{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Convert{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NonConvert{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Lang1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Lang2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Lang3{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Lang4{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Lang5{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Abort{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Props{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadParenLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadParenRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadBackspace{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMemoryStore{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMemoryRecall{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMemoryClear{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMemoryAdd{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadMemorySubtract{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadSignChange{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadClear{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NumpadClearEntry{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ControlLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ShiftLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey AltLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MetaLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ControlRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ShiftRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey AltRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MetaRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Info{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ClosedCaptionToggle{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessDown{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessToggle{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessMinimum{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessMaximum{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrightnessAuto{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaLast{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchPhone{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ProgramGuide{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Exit{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ChannelUp{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ChannelDown{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaPlay{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaPause{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaRecord{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaFastForward{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaRewind{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaTrackNext{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaTrackPrevious{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaStop{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Eject{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaPlayPause{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey SpeechInputToggle{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BassBoost{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MediaSelect{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchWordProcessor{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchSpreadsheet{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchMail{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchContacts{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchCalendar{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchApp2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchApp1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchInternetBrowser{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LogOff{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LockScreen{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchControlPanel{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey SelectTask{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchDocuments{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey SpellCheck{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchKeyboardLayout{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchScreenSaver{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchAssistant{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey LaunchAudioBrowser{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey NewKey{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Close{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Save{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Print{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserSearch{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserHome{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserBack{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserForward{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserStop{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserRefresh{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey BrowserFavorites{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ZoomIn{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ZoomOut{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ZoomToggle{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Redo{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MailReply{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MailForward{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey MailSend{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey KeyboardLayoutSelect{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey ShowAllWindows{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton3{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton4{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton5{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton6{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton7{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton8{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton9{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton10{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton11{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton12{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton13{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton14{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton15{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButton16{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonA{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonB{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonC{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonLeft1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonLeft2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonMode{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonRight1{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonRight2{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonSelect{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonStart{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonThumbLeft{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonThumbRight{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonX{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonY{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey GameButtonZ{get;set;}
public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey Fn{get;set;}
internal virtual Dictionary<int,FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey> _KnownPhysicalKeys{get;set;}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual FlutterSDK.Services.Keyboardkey.PhysicalKeyboardKey FindKeyByCode(int usageCode){ throw new NotImplementedException(); }


public new bool Equals(@Object other){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}

}
