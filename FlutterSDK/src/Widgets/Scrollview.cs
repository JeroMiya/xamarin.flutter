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
namespace FlutterSDK.Widgets.Scrollview{
internal static class ScrollviewDefaultClass{
}

public interface IScrollView{
FlutterSDK.Painting.Basictypes.AxisDirection GetDirection(FlutterSDK.Widgets.Framework.BuildContext context);
List<FlutterSDK.Widgets.Framework.Widget> BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context);
FlutterSDK.Widgets.Framework.Widget BuildViewport(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset,FlutterSDK.Painting.Basictypes.AxisDirection axisDirection,List<FlutterSDK.Widgets.Framework.Widget> slivers);
FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context);
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
FlutterSDK.Painting.Basictypes.Axis ScrollDirection{get;}
bool Reverse{get;}
FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller{get;}
bool Primary{get;}
FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics{get;}
bool ShrinkWrap{get;}
FlutterSDK.Foundation.Key.Key Center{get;}
double Anchor{get;}
double CacheExtent{get;}
int SemanticChildCount{get;}
FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior{get;}
FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior KeyboardDismissBehavior{get;}
}


public interface IBoxScrollView{
List<FlutterSDK.Widgets.Framework.Widget> BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context);
FlutterSDK.Widgets.Framework.Widget BuildChildLayout(FlutterSDK.Widgets.Framework.BuildContext context);
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding{get;}
}


public class ScrollView : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public ScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Foundation.Key.Key center = default(FlutterSDK.Foundation.Key.Key),double anchor = 0.0,double cacheExtent = default(double),int semanticChildCount = default(int),FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior),FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior keyboardDismissBehavior = default(FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior))
: base(key:key)
{
this.ScrollDirection = scrollDirection;
this.Reverse = reverse;
this.Controller = controller;
this.ShrinkWrap = shrinkWrap;
this.Center = center;
this.Anchor = anchor;
this.CacheExtent = cacheExtent;
this.SemanticChildCount = semanticChildCount;
this.DragStartBehavior = dragStartBehavior;
this.KeyboardDismissBehavior = keyboardDismissBehavior;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Painting.Basictypes.Axis ScrollDirection{get;set;}
public virtual bool Reverse{get;set;}
public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller{get;set;}
public virtual bool Primary{get;set;}
public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics{get;set;}
public virtual bool ShrinkWrap{get;set;}
public virtual FlutterSDK.Foundation.Key.Key Center{get;set;}
public virtual double Anchor{get;set;}
public virtual double CacheExtent{get;set;}
public virtual int SemanticChildCount{get;set;}
public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior{get;set;}
public virtual FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior KeyboardDismissBehavior{get;set;}
#endregion

#region methods

public virtual FlutterSDK.Painting.Basictypes.AxisDirection GetDirection(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public virtual List<FlutterSDK.Widgets.Framework.Widget> BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Framework.Widget BuildViewport(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Rendering.Viewportoffset.ViewportOffset offset,FlutterSDK.Painting.Basictypes.AxisDirection axisDirection,List<FlutterSDK.Widgets.Framework.Widget> slivers){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class CustomScrollView : FlutterSDK.Widgets.Scrollview.ScrollView
{
#region constructors
public CustomScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Foundation.Key.Key center = default(FlutterSDK.Foundation.Key.Key),double anchor = 0.0,double cacheExtent = default(double),List<FlutterSDK.Widgets.Framework.Widget> slivers = default(List<FlutterSDK.Widgets.Framework.Widget>),int semanticChildCount = default(int),FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
: base(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,center:center,anchor:anchor,cacheExtent:cacheExtent,semanticChildCount:semanticChildCount,dragStartBehavior:dragStartBehavior)
{
this.Slivers = slivers;throw new NotImplementedException(); }
#endregion

#region fields
public virtual List<FlutterSDK.Widgets.Framework.Widget> Slivers{get;set;}
#endregion

#region methods

public new List<FlutterSDK.Widgets.Framework.Widget> BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class BoxScrollView : FlutterSDK.Widgets.Scrollview.ScrollView
{
#region constructors
public BoxScrollView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry),double cacheExtent = default(double),int semanticChildCount = default(int),FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior),FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior keyboardDismissBehavior = default(FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior))
: base(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,cacheExtent:cacheExtent,semanticChildCount:semanticChildCount,dragStartBehavior:dragStartBehavior,keyboardDismissBehavior:keyboardDismissBehavior)
{
this.Padding = padding;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding{get;set;}
#endregion

#region methods

public new List<FlutterSDK.Widgets.Framework.Widget> BuildSlivers(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Framework.Widget BuildChildLayout(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class ListView : FlutterSDK.Widgets.Scrollview.BoxScrollView
{
#region constructors
public ListView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry),double itemExtent = default(double),bool addAutomaticKeepAlives = true,bool addRepaintBoundaries = true,bool addSemanticIndexes = true,double cacheExtent = default(double),List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>),int semanticChildCount = default(int),FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior),FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior keyboardDismissBehavior = default(FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior))
: base(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,padding:padding,cacheExtent:cacheExtent,semanticChildCount:semanticChildCount??children.Count,dragStartBehavior:dragStartBehavior,keyboardDismissBehavior:keyboardDismissBehavior)
{
this.ItemExtent = itemExtent;throw new NotImplementedException(); }
public static ListView Builder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry),double itemExtent = default(double),FlutterSDK.Widgets.Framework.IndexedWidgetBuilder itemBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder),int itemCount = default(int),bool addAutomaticKeepAlives = true,bool addRepaintBoundaries = true,bool addSemanticIndexes = true,double cacheExtent = default(double),int semanticChildCount = default(int),FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
{
var instance =new ListView(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,padding:padding,cacheExtent:cacheExtent,semanticChildCount:semanticChildCount??itemCount,dragStartBehavior:dragStartBehavior);instance.ItemExtent = itemExtent;throw new NotImplementedException(); }
public static ListView Separated(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry),FlutterSDK.Widgets.Framework.IndexedWidgetBuilder itemBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder),FlutterSDK.Widgets.Framework.IndexedWidgetBuilder separatorBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder),int itemCount = default(int),bool addAutomaticKeepAlives = true,bool addRepaintBoundaries = true,bool addSemanticIndexes = true,double cacheExtent = default(double),FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior keyboardDismissBehavior = default(FlutterSDK.Widgets.Scrollview.ScrollViewKeyboardDismissBehavior))
{
var instance =new ListView(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,padding:padding,cacheExtent:cacheExtent,semanticChildCount:itemCount,keyboardDismissBehavior:keyboardDismissBehavior);throw new NotImplementedException(); }
public static ListView Custom(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry),double itemExtent = default(double),FlutterSDK.Widgets.Sliver.SliverChildDelegate childrenDelegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate),double cacheExtent = default(double),int semanticChildCount = default(int))
{
var instance =new ListView(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,padding:padding,cacheExtent:cacheExtent,semanticChildCount:semanticChildCount);instance.ItemExtent = itemExtent;
instance.ChildrenDelegate = childrenDelegate;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double ItemExtent{get;set;}
public virtual FlutterSDK.Widgets.Sliver.SliverChildDelegate ChildrenDelegate{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget BuildChildLayout(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }


private int _ComputeActualChildCount(int itemCount){ throw new NotImplementedException(); }

#endregion
}


public class GridView : FlutterSDK.Widgets.Scrollview.BoxScrollView
{
#region constructors
public GridView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry),FlutterSDK.Rendering.Slivergrid.SliverGridDelegate gridDelegate = default(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate),bool addAutomaticKeepAlives = true,bool addRepaintBoundaries = true,bool addSemanticIndexes = true,double cacheExtent = default(double),List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>),int semanticChildCount = default(int))
: base(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,padding:padding,cacheExtent:cacheExtent,semanticChildCount:semanticChildCount??children.Count)
{
this.GridDelegate = gridDelegate;throw new NotImplementedException(); }
public static GridView Builder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry),FlutterSDK.Rendering.Slivergrid.SliverGridDelegate gridDelegate = default(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate),FlutterSDK.Widgets.Framework.IndexedWidgetBuilder itemBuilder = default(FlutterSDK.Widgets.Framework.IndexedWidgetBuilder),int itemCount = default(int),bool addAutomaticKeepAlives = true,bool addRepaintBoundaries = true,bool addSemanticIndexes = true,double cacheExtent = default(double),int semanticChildCount = default(int))
{
var instance =new GridView(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,padding:padding,cacheExtent:cacheExtent,semanticChildCount:semanticChildCount??itemCount);instance.GridDelegate = gridDelegate;throw new NotImplementedException(); }
public static GridView Custom(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry),FlutterSDK.Rendering.Slivergrid.SliverGridDelegate gridDelegate = default(FlutterSDK.Rendering.Slivergrid.SliverGridDelegate),FlutterSDK.Widgets.Sliver.SliverChildDelegate childrenDelegate = default(FlutterSDK.Widgets.Sliver.SliverChildDelegate),double cacheExtent = default(double),int semanticChildCount = default(int),FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
{
var instance =new GridView(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,padding:padding,cacheExtent:cacheExtent,semanticChildCount:semanticChildCount,dragStartBehavior:dragStartBehavior);instance.GridDelegate = gridDelegate;
instance.ChildrenDelegate = childrenDelegate;throw new NotImplementedException(); }
public static GridView Count(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry),int crossAxisCount = default(int),double mainAxisSpacing = 0.0,double crossAxisSpacing = 0.0,double childAspectRatio = 1.0,bool addAutomaticKeepAlives = true,bool addRepaintBoundaries = true,bool addSemanticIndexes = true,double cacheExtent = default(double),List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>),int semanticChildCount = default(int),FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
{
var instance =new GridView(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,padding:padding,cacheExtent:cacheExtent,semanticChildCount:semanticChildCount??children.Count,dragStartBehavior:dragStartBehavior);throw new NotImplementedException(); }
public static GridView Extent(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis),bool reverse = false,FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController),bool primary = default(bool),FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics),bool shrinkWrap = false,FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry),double maxCrossAxisExtent = default(double),double mainAxisSpacing = 0.0,double crossAxisSpacing = 0.0,double childAspectRatio = 1.0,bool addAutomaticKeepAlives = true,bool addRepaintBoundaries = true,bool addSemanticIndexes = true,List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>),int semanticChildCount = default(int),FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
{
var instance =new GridView(key:key,scrollDirection:scrollDirection,reverse:reverse,controller:controller,primary:primary,physics:physics,shrinkWrap:shrinkWrap,padding:padding,semanticChildCount:semanticChildCount??children.Count,dragStartBehavior:dragStartBehavior);throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Rendering.Slivergrid.SliverGridDelegate GridDelegate{get;set;}
public virtual FlutterSDK.Widgets.Sliver.SliverChildDelegate ChildrenDelegate{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget BuildChildLayout(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public enum ScrollViewKeyboardDismissBehavior{

Manual,
OnDrag,
}

}
