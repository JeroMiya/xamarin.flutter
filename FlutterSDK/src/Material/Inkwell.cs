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
namespace FlutterSDK.Material.Inkwell{
internal static class InkwellDefaultClass{
}

public interface IInteractiveInkFeature{
void Confirm();
void Cancel();
void PaintInkCircle(Canvas canvas = default(Canvas),Matrix4 transform = default(Matrix4),SKPaint paint = default(SKPaint),FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset),double radius = default(double),TextDirection textDirection = default(TextDirection),FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder),FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius),FlutterSDK.Material.Material.RectCallback clipCallback = default(FlutterSDK.Material.Material.RectCallback));
FlutterBinding.UI.Color Color{get;set;}
}


public interface IInteractiveInkFeatureFactory{
FlutterSDK.Material.Inkwell.InteractiveInkFeature Create(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController),FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox),FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),TextDirection textDirection = default(TextDirection),bool containedInkWell = false,FlutterSDK.Material.Material.RectCallback rectCallback = default(FlutterSDK.Material.Material.RectCallback),FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius),FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder),double radius = default(double),VoidCallback onRemoved = default(VoidCallback));
}


public class InteractiveInkFeature : FlutterSDK.Material.Material.InkFeature
{
#region constructors
public InteractiveInkFeature(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController),FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),VoidCallback onRemoved = default(VoidCallback))
: base(controller:controller,referenceBox:referenceBox,onRemoved:onRemoved)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterBinding.UI.Color _Color{get;set;}
public virtual FlutterBinding.UI.Color Color{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public virtual void Confirm(){ throw new NotImplementedException(); }


public virtual void Cancel(){ throw new NotImplementedException(); }


public virtual void PaintInkCircle(Canvas canvas = default(Canvas),Matrix4 transform = default(Matrix4),SKPaint paint = default(SKPaint),FlutterBinding.UI.Offset center = default(FlutterBinding.UI.Offset),double radius = default(double),TextDirection textDirection = default(TextDirection),FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder),FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius),FlutterSDK.Material.Material.RectCallback clipCallback = default(FlutterSDK.Material.Material.RectCallback)){ throw new NotImplementedException(); }

#endregion
}


public class InteractiveInkFeatureFactory
{
#region constructors
public InteractiveInkFeatureFactory()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public virtual FlutterSDK.Material.Inkwell.InteractiveInkFeature Create(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController),FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox),FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),TextDirection textDirection = default(TextDirection),bool containedInkWell = false,FlutterSDK.Material.Material.RectCallback rectCallback = default(FlutterSDK.Material.Material.RectCallback),FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius),FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder),double radius = default(double),VoidCallback onRemoved = default(VoidCallback)){ throw new NotImplementedException(); }

#endregion
}


public class InkResponse : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public InkResponse(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback),FlutterSDK.Gestures.Tap.GestureTapDownCallback onTapDown = default(FlutterSDK.Gestures.Tap.GestureTapDownCallback),FlutterSDK.Gestures.Tap.GestureTapCallback onTapCancel = default(FlutterSDK.Gestures.Tap.GestureTapCallback),FlutterSDK.Gestures.Tap.GestureTapCallback onDoubleTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback),FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback),FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>),FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHover = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>),bool containedInkWell = false,FlutterSDK.Painting.Boxborder.BoxShape highlightShape = default(FlutterSDK.Painting.Boxborder.BoxShape),double radius = default(double),FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius),FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder),FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color),FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory splashFactory = default(FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory),bool enableFeedback = true,bool excludeFromSemantics = false,FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode),bool canRequestFocus = true,FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onFocusChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>),bool autofocus = false)
: base(key:key)
{
this.Child = child;
this.OnTap = onTap;
this.OnTapDown = onTapDown;
this.OnTapCancel = onTapCancel;
this.OnDoubleTap = onDoubleTap;
this.OnLongPress = onLongPress;
this.OnHighlightChanged = onHighlightChanged;
this.OnHover = onHover;
this.ContainedInkWell = containedInkWell;
this.HighlightShape = highlightShape;
this.Radius = radius;
this.BorderRadius = borderRadius;
this.CustomBorder = customBorder;
this.FocusColor = focusColor;
this.HoverColor = hoverColor;
this.HighlightColor = highlightColor;
this.SplashColor = splashColor;
this.SplashFactory = splashFactory;
this.EnableFeedback = enableFeedback;
this.ExcludeFromSemantics = excludeFromSemantics;
this.FocusNode = focusNode;
this.CanRequestFocus = canRequestFocus;
this.OnFocusChange = onFocusChange;
this.Autofocus = autofocus;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child{get;set;}
public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap{get;set;}
public virtual FlutterSDK.Gestures.Tap.GestureTapDownCallback OnTapDown{get;set;}
public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTapCancel{get;set;}
public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnDoubleTap{get;set;}
public virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback OnLongPress{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnHighlightChanged{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnHover{get;set;}
public virtual bool ContainedInkWell{get;set;}
public virtual FlutterSDK.Painting.Boxborder.BoxShape HighlightShape{get;set;}
public virtual double Radius{get;set;}
public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius{get;set;}
public virtual FlutterSDK.Painting.Borders.ShapeBorder CustomBorder{get;set;}
public virtual FlutterBinding.UI.Color FocusColor{get;set;}
public virtual FlutterBinding.UI.Color HoverColor{get;set;}
public virtual FlutterBinding.UI.Color HighlightColor{get;set;}
public virtual FlutterBinding.UI.Color SplashColor{get;set;}
public virtual FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory SplashFactory{get;set;}
public virtual bool EnableFeedback{get;set;}
public virtual bool ExcludeFromSemantics{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnFocusChange{get;set;}
public virtual bool Autofocus{get;set;}
public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode{get;set;}
public virtual bool CanRequestFocus{get;set;}
#endregion

#region methods

public virtual FlutterSDK.Material.Material.RectCallback GetRectCallback(FlutterSDK.Rendering.Box.RenderBox referenceBox){ throw new NotImplementedException(); }


public virtual bool DebugCheckContext(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new FlutterSDK.Material.Inkwell._InkResponseState<FlutterSDK.Material.Inkwell.InkResponse> CreateState(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class _InkResponseState<T> : FlutterSDK.Widgets.Framework.State<T>,IAutomaticKeepAliveClientMixin<T>
{
#region constructors
public _InkResponseState()
{ }
#endregion

#region fields
internal virtual HashSet<FlutterSDK.Material.Inkwell.InteractiveInkFeature> _Splashes{get;set;}
internal virtual FlutterSDK.Material.Inkwell.InteractiveInkFeature _CurrentSplash{get;set;}
internal virtual bool _Hovering{get;set;}
internal virtual Dictionary<FlutterSDK.Material.Inkwell._HighlightType,FlutterSDK.Material.Inkhighlight.InkHighlight> _Highlights{get;set;}
internal virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey,object> _ActionMap{get;set;}
internal virtual bool _HasFocus{get;set;}
public virtual bool HighlightsExist{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool WantKeepAlive{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool Enabled{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private void _HandleAction(FlutterSDK.Widgets.Focusmanager.FocusNode node,FlutterSDK.Widgets.Actions.Intent intent){ throw new NotImplementedException(); }


private FlutterSDK.Widgets.Actions.Action _CreateAction(){ throw new NotImplementedException(); }


public new void InitState(){ throw new NotImplementedException(); }


public new void DidUpdateWidget(T oldWidget){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }


public virtual Color GetHighlightColorForType(FlutterSDK.Material.Inkwell._HighlightType type){ throw new NotImplementedException(); }


public virtual TimeSpan GetFadeDurationForType(FlutterSDK.Material.Inkwell._HighlightType type){ throw new NotImplementedException(); }


public virtual void UpdateHighlight(FlutterSDK.Material.Inkwell._HighlightType type,bool value = default(bool)){ throw new NotImplementedException(); }


private FlutterSDK.Material.Inkwell.InteractiveInkFeature _CreateInkFeature(FlutterBinding.UI.Offset globalPosition){ throw new NotImplementedException(); }


private void _HandleFocusHighlightModeChange(FlutterSDK.Widgets.Focusmanager.FocusHighlightMode mode){ throw new NotImplementedException(); }


private void _UpdateFocusHighlights(){ throw new NotImplementedException(); }


private void _HandleFocusUpdate(bool hasFocus){ throw new NotImplementedException(); }


private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details){ throw new NotImplementedException(); }


private void _StartSplash(FlutterSDK.Gestures.Tap.TapDownDetails details = default(FlutterSDK.Gestures.Tap.TapDownDetails),FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext)){ throw new NotImplementedException(); }


private void _HandleTap(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


private void _HandleTapCancel(){ throw new NotImplementedException(); }


private void _HandleDoubleTap(){ throw new NotImplementedException(); }


private void _HandleLongPress(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void Deactivate(){ throw new NotImplementedException(); }


private bool _IsWidgetEnabled(FlutterSDK.Material.Inkwell.InkResponse widget){ throw new NotImplementedException(); }


private void _HandleMouseEnter(FlutterSDK.Gestures.Events.PointerEnterEvent @event){ throw new NotImplementedException(); }


private void _HandleMouseExit(FlutterSDK.Gestures.Events.PointerExitEvent @event){ throw new NotImplementedException(); }


private void _HandleHoverChange(bool hovering){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class InkWell : FlutterSDK.Material.Inkwell.InkResponse
{
#region constructors
public InkWell(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback),FlutterSDK.Gestures.Tap.GestureTapCallback onDoubleTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback),FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback),FlutterSDK.Gestures.Tap.GestureTapDownCallback onTapDown = default(FlutterSDK.Gestures.Tap.GestureTapDownCallback),FlutterSDK.Gestures.Tap.GestureTapCancelCallback onTapCancel = default(FlutterSDK.Gestures.Tap.GestureTapCancelCallback),FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>),FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHover = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>),FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color),FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory splashFactory = default(FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory),double radius = default(double),FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius),FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder),bool enableFeedback = true,bool excludeFromSemantics = false,FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode),bool canRequestFocus = true,FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onFocusChange = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>),bool autofocus = false)
: base(key:key,child:child,onTap:onTap,onDoubleTap:onDoubleTap,onLongPress:onLongPress,onTapDown:onTapDown,onTapCancel:onTapCancel,onHighlightChanged:onHighlightChanged,onHover:onHover,containedInkWell:true,highlightShape:BoxShape.Rectangle,focusColor:focusColor,hoverColor:hoverColor,highlightColor:highlightColor,splashColor:splashColor,splashFactory:splashFactory,radius:radius,borderRadius:borderRadius,customBorder:customBorder,enableFeedback:enableFeedback??true,excludeFromSemantics:excludeFromSemantics??false,focusNode:focusNode,canRequestFocus:canRequestFocus??true,onFocusChange:onFocusChange,autofocus:autofocus??false)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods
#endregion
}


public enum _HighlightType{

Pressed,
Hover,
Focus,
}

}
