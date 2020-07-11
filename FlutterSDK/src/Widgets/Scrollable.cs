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
using FlutterSDK.Widgets.Routenotificationmessages;
namespace FlutterSDK.Widgets.Scrollable{
public delegate FlutterSDK.Widgets.Framework.Widget ViewportBuilder(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Rendering.Viewportoffset.ViewportOffset position);
public delegate double ScrollIncrementCalculator(FlutterSDK.Widgets.Scrollable.ScrollIncrementDetails details);
internal static class ScrollableDefaultClass{
}

public class Scrollable : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public Scrollable(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.AxisDirection axisDirection = default(FlutterSDK.Painting.Basictypes.AxisDirection),FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),FlutterSDK.Widgets.Scrollable.ViewportBuilder viewportBuilder = default(FlutterSDK.Widgets.Scrollable.ViewportBuilder),FlutterSDK.Widgets.Scrollable.ScrollIncrementCalculator incrementCalculator = default(FlutterSDK.Widgets.Scrollable.ScrollIncrementCalculator),bool excludeFromSemantics = false,int semanticChildCount = default(int),FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
: base(key:key)
{
this.AxisDirection = axisDirection;
this.Controller = controller;
this.Physics = physics;
this.ViewportBuilder = viewportBuilder;
this.IncrementCalculator = incrementCalculator;
this.ExcludeFromSemantics = excludeFromSemantics;
this.SemanticChildCount = semanticChildCount;
this.DragStartBehavior = dragStartBehavior;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection{get;set;}
public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller{get;set;}
public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics{get;set;}
public virtual FlutterSDK.Widgets.Scrollable.ViewportBuilder ViewportBuilder{get;set;}
public virtual FlutterSDK.Widgets.Scrollable.ScrollIncrementCalculator IncrementCalculator{get;set;}
public virtual bool ExcludeFromSemantics{get;set;}
public virtual int SemanticChildCount{get;set;}
public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior{get;set;}
public virtual FlutterSDK.Painting.Basictypes.Axis Axis{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new FlutterSDK.Widgets.Scrollable.ScrollableState CreateState(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Scrollable.ScrollableState Of(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public virtual bool RecommendDeferredLoadingForContext(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public virtual Future<object> EnsureVisible(FlutterSDK.Widgets.Framework.BuildContext context,double alignment = 0.0,TimeSpan duration = default(TimeSpan),FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve),FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy alignmentPolicy = default(FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy)){ throw new NotImplementedException(); }

#endregion
}


public class _ScrollableScope : FlutterSDK.Widgets.Framework.InheritedWidget
{
#region constructors
public _ScrollableScope(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Scrollable.ScrollableState scrollable = default(FlutterSDK.Widgets.Scrollable.ScrollableState),FlutterSDK.Widgets.Scrollposition.ScrollPosition position = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key,child:child)
{
this.Scrollable = scrollable;
this.Position = position;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Scrollable.ScrollableState Scrollable{get;set;}
public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition Position{get;set;}
#endregion

#region methods

public new bool UpdateShouldNotify(FlutterSDK.Widgets.Scrollable._ScrollableScope old){ throw new NotImplementedException(); }
public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget){ throw new NotImplementedException(); }

#endregion
}


public class ScrollableState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Scrollable.Scrollable>,IScrollContext,ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
#region constructors
public ScrollableState()
{ }
#endregion

#region fields
internal virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition _Position{get;set;}
internal virtual FlutterSDK.Widgets.Scrollconfiguration.ScrollBehavior _Configuration{get;set;}
internal virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics _Physics{get;set;}
internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _ScrollSemanticsKey{get;set;}
internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Gesturedetector.RawGestureDetectorState> _GestureDetectorKey{get;set;}
internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _IgnorePointerKey{get;set;}
internal virtual Dictionary<Type,FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Gestures.Recognizer.GestureRecognizer>> _GestureRecognizers{get;set;}
internal virtual bool _ShouldIgnorePointer{get;set;}
internal virtual bool _LastCanDrag{get;set;}
internal virtual FlutterSDK.Painting.Basictypes.Axis _LastAxisDirection{get;set;}
internal virtual FlutterSDK.Gestures.Drag.Drag _Drag{get;set;}
internal virtual FlutterSDK.Widgets.Scrollactivity.ScrollHoldController _Hold{get;set;}
public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition Position{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Painting.Basictypes.AxisDirection AxisDirection{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.BuildContext NotificationContext{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.BuildContext StorageContext{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private void _UpdatePosition(){ throw new NotImplementedException(); }


public new void DidChangeDependencies(){ throw new NotImplementedException(); }


private bool _ShouldUpdatePosition(FlutterSDK.Widgets.Scrollable.Scrollable oldWidget){ throw new NotImplementedException(); }


public new void DidUpdateWidget(FlutterSDK.Widgets.Scrollable.Scrollable oldWidget){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }


public new void SetSemanticsActions(HashSet<SemanticsAction> actions){ throw new NotImplementedException(); }


public new void SetCanDrag(bool canDrag){ throw new NotImplementedException(); }


public new void SetIgnorePointer(bool value){ throw new NotImplementedException(); }


private void _HandleDragDown(FlutterSDK.Gestures.Dragdetails.DragDownDetails details){ throw new NotImplementedException(); }


private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details){ throw new NotImplementedException(); }


private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details){ throw new NotImplementedException(); }


private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details){ throw new NotImplementedException(); }


private void _HandleDragCancel(){ throw new NotImplementedException(); }


private void _DisposeHold(){ throw new NotImplementedException(); }


private void _DisposeDrag(){ throw new NotImplementedException(); }


private double _TargetScrollOffsetForPointerScroll(FlutterSDK.Gestures.Events.PointerScrollEvent @event){ throw new NotImplementedException(); }


private void _ReceivedPointerSignal(FlutterSDK.Gestures.Events.PointerSignalEvent @event){ throw new NotImplementedException(); }


private void _HandlePointerScroll(FlutterSDK.Gestures.Events.PointerEvent @event){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class _ScrollSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
#region constructors
public _ScrollSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Scrollposition.ScrollPosition position = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition),bool allowImplicitScrolling = default(bool),int semanticChildCount = default(int),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key,child:child)
{
this.Position = position;
this.AllowImplicitScrolling = allowImplicitScrolling;
this.SemanticChildCount = semanticChildCount;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition Position{get;set;}
public virtual bool AllowImplicitScrolling{get;set;}
public virtual int SemanticChildCount{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Scrollable._RenderScrollSemantics CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Widgets.Scrollable._RenderScrollSemantics renderObject){ throw new NotImplementedException(); }
public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Rendering.@object.RenderObject renderObject){ throw new NotImplementedException(); }

#endregion
}


public class _RenderScrollSemantics : FlutterSDK.Rendering.Proxybox.RenderProxyBox
{
#region constructors
public _RenderScrollSemantics(FlutterSDK.Widgets.Scrollposition.ScrollPosition position = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition),bool allowImplicitScrolling = default(bool),int semanticChildCount = default(int),FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
: base(child)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition _Position{get;set;}
internal virtual bool _AllowImplicitScrolling{get;set;}
internal virtual int _SemanticChildCount{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.SemanticsNode _InnerNode{get;set;}
public virtual FlutterSDK.Widgets.Scrollposition.ScrollPosition Position{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool AllowImplicitScrolling{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual int SemanticChildCount{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config){ throw new NotImplementedException(); }


public new void AssembleSemanticsNode(FlutterSDK.Semantics.Semantics.SemanticsNode node,FlutterSDK.Semantics.Semantics.SemanticsConfiguration config,Iterable<FlutterSDK.Semantics.Semantics.SemanticsNode> children){ throw new NotImplementedException(); }


public new void ClearSemantics(){ throw new NotImplementedException(); }

#endregion
}


public class ScrollIncrementDetails
{
#region constructors
public ScrollIncrementDetails(FlutterSDK.Widgets.Scrollable.ScrollIncrementType type = default(FlutterSDK.Widgets.Scrollable.ScrollIncrementType),FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics = default(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics))
: base()
{
this.Type = type;
this.Metrics = metrics;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Scrollable.ScrollIncrementType Type{get;set;}
public virtual FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics Metrics{get;set;}
#endregion

#region methods
#endregion
}


public class ScrollIntent : FlutterSDK.Widgets.Actions.Intent
{
#region constructors
public ScrollIntent(FlutterSDK.Painting.Basictypes.AxisDirection direction = default(FlutterSDK.Painting.Basictypes.AxisDirection),FlutterSDK.Widgets.Scrollable.ScrollIncrementType type = default(FlutterSDK.Widgets.Scrollable.ScrollIncrementType))
: base(ScrollableDefaultClass.ScrollAction.Key)
{
this.Direction = direction;
this.Type = type;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Painting.Basictypes.AxisDirection Direction{get;set;}
public virtual FlutterSDK.Widgets.Scrollable.ScrollIncrementType Type{get;set;}
#endregion

#region methods

public new bool IsEnabled(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class ScrollAction : FlutterSDK.Widgets.Actions.Action
{
#region constructors
public ScrollAction()
: base(Key)
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Foundation.Key.LocalKey Key{get;set;}
#endregion

#region methods

private double _CalculateScrollIncrement(FlutterSDK.Widgets.Scrollable.ScrollableState state,FlutterSDK.Widgets.Scrollable.ScrollIncrementType type = default(FlutterSDK.Widgets.Scrollable.ScrollIncrementType)){ throw new NotImplementedException(); }


private double _GetIncrement(FlutterSDK.Widgets.Scrollable.ScrollableState state,FlutterSDK.Widgets.Scrollable.ScrollIntent intent){ throw new NotImplementedException(); }


public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node,FlutterSDK.Widgets.Scrollable.ScrollIntent intent){ throw new NotImplementedException(); }
public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node,FlutterSDK.Widgets.Actions.Intent intent){ throw new NotImplementedException(); }

#endregion
}


public enum ScrollIncrementType{

Line,
Page,
}

}
