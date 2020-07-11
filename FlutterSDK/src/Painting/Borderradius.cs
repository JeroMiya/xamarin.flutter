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
namespace FlutterSDK.Painting.Borderradius{
internal static class BorderradiusDefaultClass{
}

public interface IBorderRadiusGeometry{
FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Subtract(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other);
FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Add(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other);
FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Unary();
FlutterSDK.Painting.Borderradius.BorderRadiusGeometry MultiplyOperator(double other);
FlutterSDK.Painting.Borderradius.BorderRadiusGeometry DivideOperator(double other);
FlutterSDK.Painting.Borderradius.BorderRadiusGeometry DivideIntegerResultOperator(double other);
FlutterSDK.Painting.Borderradius.BorderRadiusGeometry ModuloOperator(double other);
FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Lerp(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry a,FlutterSDK.Painting.Borderradius.BorderRadiusGeometry b,double t);
FlutterSDK.Painting.Borderradius.BorderRadius Resolve(TextDirection direction);
string ToString();
bool Equals(@Object other);
int HashCode{get;}
}


public class BorderRadiusGeometry
{
#region constructors
public BorderRadiusGeometry()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual Radius _TopLeft{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _TopRight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomLeft{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomRight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _TopStart{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _TopEnd{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomStart{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomEnd{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Subtract(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Add(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Unary(){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry MultiplyOperator(double other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry DivideOperator(double other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry DivideIntegerResultOperator(double other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry ModuloOperator(double other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Lerp(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry a,FlutterSDK.Painting.Borderradius.BorderRadiusGeometry b,double t){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadius Resolve(TextDirection direction){ throw new NotImplementedException(); }



public new bool Equals(@Object other){ throw new NotImplementedException(); }

#endregion
}


public class BorderRadius : FlutterSDK.Painting.Borderradius.BorderRadiusGeometry
{
#region constructors
public static BorderRadius All(Radius radius)
{
var instance =new BorderRadius();throw new NotImplementedException(); }
public static BorderRadius Circular(double radius)
{
var instance =new BorderRadius();throw new NotImplementedException(); }
public static BorderRadius Vertical(Radius top = default(Radius),Radius bottom = default(Radius))
{
var instance =new BorderRadius();throw new NotImplementedException(); }
public static BorderRadius Horizontal(Radius left = default(Radius),Radius right = default(Radius))
{
var instance =new BorderRadius();throw new NotImplementedException(); }
public static BorderRadius Only(Radius topLeft = default(Radius),Radius topRight = default(Radius),Radius bottomLeft = default(Radius),Radius bottomRight = default(Radius))
{
var instance =new BorderRadius();instance.TopLeft = topLeft;
instance.TopRight = topRight;
instance.BottomLeft = bottomLeft;
instance.BottomRight = bottomRight;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Painting.Borderradius.BorderRadius Zero{get;set;}
public virtual Radius TopLeft{get;set;}
public virtual Radius TopRight{get;set;}
public virtual Radius BottomLeft{get;set;}
public virtual Radius BottomRight{get;set;}
internal virtual Radius _TopLeft{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _TopRight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomLeft{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomRight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _TopStart{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _TopEnd{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomStart{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomEnd{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual RRect ToRRect(FlutterBinding.UI.Rect rect){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Subtract(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Add(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadius Unary(FlutterSDK.Painting.Borderradius.BorderRadius other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadius AddOperator(FlutterSDK.Painting.Borderradius.BorderRadius other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadius Unary(){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadius MultiplyOperator(double other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadius DivideOperator(double other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadius DivideIntegerResultOperator(double other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadius ModuloOperator(double other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadius Lerp(FlutterSDK.Painting.Borderradius.BorderRadius a,FlutterSDK.Painting.Borderradius.BorderRadius b,double t){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadius Resolve(TextDirection direction){ throw new NotImplementedException(); }

#endregion
}


public class BorderRadiusDirectional : FlutterSDK.Painting.Borderradius.BorderRadiusGeometry
{
#region constructors
public static BorderRadiusDirectional All(Radius radius)
{
var instance =new BorderRadiusDirectional();throw new NotImplementedException(); }
public static BorderRadiusDirectional Circular(double radius)
{
var instance =new BorderRadiusDirectional();throw new NotImplementedException(); }
public static BorderRadiusDirectional Vertical(Radius top = default(Radius),Radius bottom = default(Radius))
{
var instance =new BorderRadiusDirectional();throw new NotImplementedException(); }
public static BorderRadiusDirectional Horizontal(Radius start = default(Radius),Radius end = default(Radius))
{
var instance =new BorderRadiusDirectional();throw new NotImplementedException(); }
public static BorderRadiusDirectional Only(Radius topStart = default(Radius),Radius topEnd = default(Radius),Radius bottomStart = default(Radius),Radius bottomEnd = default(Radius))
{
var instance =new BorderRadiusDirectional();instance.TopStart = topStart;
instance.TopEnd = topEnd;
instance.BottomStart = bottomStart;
instance.BottomEnd = bottomEnd;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Painting.Borderradius.BorderRadiusDirectional Zero{get;set;}
public virtual Radius TopStart{get;set;}
public virtual Radius TopEnd{get;set;}
public virtual Radius BottomStart{get;set;}
public virtual Radius BottomEnd{get;set;}
internal virtual Radius _TopStart{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _TopEnd{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomStart{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomEnd{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _TopLeft{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _TopRight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomLeft{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Radius _BottomRight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Subtract(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadiusGeometry Add(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadiusDirectional Unary(FlutterSDK.Painting.Borderradius.BorderRadiusDirectional other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadiusDirectional AddOperator(FlutterSDK.Painting.Borderradius.BorderRadiusDirectional other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadiusDirectional Unary(){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadiusDirectional MultiplyOperator(double other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadiusDirectional DivideOperator(double other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadiusDirectional DivideIntegerResultOperator(double other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadiusDirectional ModuloOperator(double other){ throw new NotImplementedException(); }


public virtual FlutterSDK.Painting.Borderradius.BorderRadiusDirectional Lerp(FlutterSDK.Painting.Borderradius.BorderRadiusDirectional a,FlutterSDK.Painting.Borderradius.BorderRadiusDirectional b,double t){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadius Resolve(TextDirection direction){ throw new NotImplementedException(); }

#endregion
}


public class _MixedBorderRadius : FlutterSDK.Painting.Borderradius.BorderRadiusGeometry
{
#region constructors
public _MixedBorderRadius(Radius _topLeft,Radius _topRight,Radius _bottomLeft,Radius _bottomRight,Radius _topStart,Radius _topEnd,Radius _bottomStart,Radius _bottomEnd)
{
this._TopLeft = _topLeft;
this._TopRight = _topRight;
this._BottomLeft = _bottomLeft;
this._BottomRight = _bottomRight;
this._TopStart = _topStart;
this._TopEnd = _topEnd;
this._BottomStart = _bottomStart;
this._BottomEnd = _bottomEnd;throw new NotImplementedException(); }
#endregion

#region fields
internal new Radius _TopLeft{get;set;}
internal new Radius _TopRight{get;set;}
internal new Radius _BottomLeft{get;set;}
internal new Radius _BottomRight{get;set;}
internal new Radius _TopStart{get;set;}
internal new Radius _TopEnd{get;set;}
internal new Radius _BottomStart{get;set;}
internal new Radius _BottomEnd{get;set;}
#endregion

#region methods

public new FlutterSDK.Painting.Borderradius._MixedBorderRadius Unary(){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius._MixedBorderRadius MultiplyOperator(double other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius._MixedBorderRadius DivideOperator(double other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius._MixedBorderRadius DivideIntegerResultOperator(double other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius._MixedBorderRadius ModuloOperator(double other){ throw new NotImplementedException(); }


public new FlutterSDK.Painting.Borderradius.BorderRadius Resolve(TextDirection direction){ throw new NotImplementedException(); }

#endregion
}

}