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
namespace FlutterSDK.Material.Material{
public delegate Rect RectCallback();
internal static class MaterialDefaultClass{
public static Dictionary<FlutterSDK.Material.Material.MaterialType,FlutterSDK.Painting.Borderradius.BorderRadius> KMaterialEdges = default(Dictionary<FlutterSDK.Material.Material.MaterialType,FlutterSDK.Painting.Borderradius.BorderRadius>);
}

public interface IInkFeature{
void Dispose();
void PaintFeature(Canvas canvas,Matrix4 transform);
string ToString();
FlutterSDK.Rendering.Box.RenderBox ReferenceBox{get;}
VoidCallback OnRemoved{get;}
FlutterSDK.Material.Material.MaterialInkController Controller{get;}
}


public interface IMaterialInkController{}

public class MaterialInkController{
public virtual FlutterBinding.UI.Color Color{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}

public virtual void AddInkFeature(FlutterSDK.Material.Material.InkFeature feature){ throw new NotImplementedException(); }


public virtual void MarkNeedsPaint(){ throw new NotImplementedException(); }

}
public static class MaterialInkControllerMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<IMaterialInkController, MaterialInkController> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IMaterialInkController, MaterialInkController>();
static MaterialInkController GetOrCreate(IMaterialInkController instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new MaterialInkController();
_table.Add(instance, value);
}
return (MaterialInkController)value;
}
public static FlutterBinding.UI.Color ColorProperty(this IMaterialInkController instance) => GetOrCreate(instance).Color;
public static FlutterSDK.Scheduler.Ticker.TickerProvider VsyncProperty(this IMaterialInkController instance) => GetOrCreate(instance).Vsync;
public static void AddInkFeature(this IMaterialInkController instance,FlutterSDK.Material.Material.InkFeature feature) => GetOrCreate(instance).AddInkFeature(feature);
public static void MarkNeedsPaint(this IMaterialInkController instance) => GetOrCreate(instance).MarkNeedsPaint();
}


public class Material : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public Material(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Material.Material.MaterialType type = default(FlutterSDK.Material.Material.MaterialType),double elevation = 0.0,FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color),FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle),FlutterSDK.Painting.Borderradius.BorderRadiusGeometry borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry),FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder),bool borderOnForeground = true,FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),TimeSpan animationDuration = default(TimeSpan),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key)
{
this.Type = type;
this.Elevation = elevation;
this.Color = color;
this.ShadowColor = shadowColor;
this.TextStyle = textStyle;
this.BorderRadius = borderRadius;
this.Shape = shape;
this.BorderOnForeground = borderOnForeground;
this.ClipBehavior = clipBehavior;
this.AnimationDuration = animationDuration;
this.Child = child;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child{get;set;}
public virtual FlutterSDK.Material.Material.MaterialType Type{get;set;}
public virtual double Elevation{get;set;}
public virtual FlutterBinding.UI.Color Color{get;set;}
public virtual FlutterBinding.UI.Color ShadowColor{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle{get;set;}
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape{get;set;}
public virtual bool BorderOnForeground{get;set;}
public virtual FlutterBinding.UI.Clip ClipBehavior{get;set;}
public virtual TimeSpan AnimationDuration{get;set;}
public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry BorderRadius{get;set;}
public virtual double DefaultSplashRadius{get;set;}
#endregion

#region methods

public virtual FlutterSDK.Material.Material.MaterialInkController Of(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new FlutterSDK.Material.Material._MaterialState CreateState(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class _MaterialState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Material.Material>,ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
#region constructors
public _MaterialState()
{ }
#endregion

#region fields
internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> _InkFeatureRenderer{get;set;}
#endregion

#region methods

private Color _GetBackgroundColor(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


private FlutterSDK.Widgets.Framework.Widget _TransparentInterior(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext),FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),FlutterSDK.Widgets.Framework.Widget contents = default(FlutterSDK.Widgets.Framework.Widget)){ throw new NotImplementedException(); }


private FlutterSDK.Painting.Borders.ShapeBorder _GetShape(){ throw new NotImplementedException(); }

#endregion
}


public class _RenderInkFeatures : FlutterSDK.Rendering.Proxybox.RenderProxyBox,IMaterialInkController
{
#region constructors
public _RenderInkFeatures(FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color))
: base(child)
{
this.Vsync = vsync;
this.Color = color;throw new NotImplementedException(); }
#endregion

#region fields
public new FlutterSDK.Scheduler.Ticker.TickerProvider Vsync{get;set;}
public new FlutterBinding.UI.Color Color{get;set;}
internal virtual List<FlutterSDK.Material.Material.InkFeature> _InkFeatures{get;set;}
#endregion

#region methods

public new void AddInkFeature(FlutterSDK.Material.Material.InkFeature feature){ throw new NotImplementedException(); }


private void _RemoveFeature(FlutterSDK.Material.Material.InkFeature feature){ throw new NotImplementedException(); }


private void _DidChangeLayout(){ throw new NotImplementedException(); }


public new bool HitTestSelf(FlutterBinding.UI.Offset position){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }

#endregion
}


public class _InkFeatures : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
#region constructors
public _InkFeatures(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key,child:child)
{
this.Color = color;
this.Vsync = vsync;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterBinding.UI.Color Color{get;set;}
public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync{get;set;}
#endregion

#region methods

public new FlutterSDK.Material.Material._RenderInkFeatures CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Material.Material._RenderInkFeatures renderObject){ throw new NotImplementedException(); }
public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Rendering.@object.RenderObject renderObject){ throw new NotImplementedException(); }

#endregion
}


public class InkFeature
{
#region constructors
public InkFeature(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController),FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox),VoidCallback onRemoved = default(VoidCallback))
: base()
{
this.ReferenceBox = referenceBox;
this.OnRemoved = onRemoved;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Material.Material._RenderInkFeatures _Controller{get;set;}
public virtual FlutterSDK.Rendering.Box.RenderBox ReferenceBox{get;set;}
public virtual VoidCallback OnRemoved{get;set;}
internal virtual bool _DebugDisposed{get;set;}
public virtual FlutterSDK.Material.Material.MaterialInkController Controller{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual void Dispose(){ throw new NotImplementedException(); }


private void _Paint(Canvas canvas){ throw new NotImplementedException(); }


public virtual void PaintFeature(Canvas canvas,Matrix4 transform){ throw new NotImplementedException(); }


#endregion
}


public class ShapeBorderTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Painting.Borders.ShapeBorder>
{
#region constructors
public ShapeBorderTween(FlutterSDK.Painting.Borders.ShapeBorder begin = default(FlutterSDK.Painting.Borders.ShapeBorder),FlutterSDK.Painting.Borders.ShapeBorder end = default(FlutterSDK.Painting.Borders.ShapeBorder))
: base(begin:begin,end:end)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Painting.Borders.ShapeBorder Lerp(double t){ throw new NotImplementedException(); }

#endregion
}


public class _MaterialInterior : FlutterSDK.Widgets.Implicitanimations.ImplicitlyAnimatedWidget
{
#region constructors
public _MaterialInterior(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder),bool borderOnForeground = true,FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),double elevation = default(double),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color),FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve),TimeSpan duration = default(TimeSpan))
: base(key:key,curve:curve,duration:duration)
{
this.Child = child;
this.Shape = shape;
this.BorderOnForeground = borderOnForeground;
this.ClipBehavior = clipBehavior;
this.Elevation = elevation;
this.Color = color;
this.ShadowColor = shadowColor;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child{get;set;}
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape{get;set;}
public virtual bool BorderOnForeground{get;set;}
public virtual FlutterBinding.UI.Clip ClipBehavior{get;set;}
public virtual double Elevation{get;set;}
public virtual FlutterBinding.UI.Color Color{get;set;}
public virtual FlutterBinding.UI.Color ShadowColor{get;set;}
#endregion

#region methods

public new FlutterSDK.Material.Material._MaterialInteriorState CreateState(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder description){ throw new NotImplementedException(); }

#endregion
}


public class _MaterialInteriorState : FlutterSDK.Widgets.Implicitanimations.AnimatedWidgetBaseState<FlutterSDK.Material.Material._MaterialInterior>
{
#region constructors
public _MaterialInteriorState()
{ }
#endregion

#region fields
internal virtual FlutterSDK.Animation.Tween.Tween<double> _Elevation{get;set;}
internal virtual FlutterSDK.Animation.Tween.ColorTween _ShadowColor{get;set;}
internal virtual FlutterSDK.Material.Material.ShapeBorderTween _Border{get;set;}
#endregion

#region methods

public new void ForEachTween(FlutterSDK.Widgets.Implicitanimations.TweenVisitor<object> visitor){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _ShapeBorderPaint : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _ShapeBorderPaint(FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder),bool borderOnForeground = true)
{
this.Child = child;
this.Shape = shape;
this.BorderOnForeground = borderOnForeground;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child{get;set;}
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape{get;set;}
public virtual bool BorderOnForeground{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _ShapeBorderPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
{
#region constructors
public _ShapeBorderPainter(FlutterSDK.Painting.Borders.ShapeBorder border,TextDirection textDirection)
{
this.Border = border;
this.TextDirection = textDirection;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Painting.Borders.ShapeBorder Border{get;set;}
public virtual TextDirection TextDirection{get;set;}
#endregion

#region methods

public new void Paint(Canvas canvas,Size size){ throw new NotImplementedException(); }


public new bool ShouldRepaint(FlutterSDK.Material.Material._ShapeBorderPainter oldDelegate){ throw new NotImplementedException(); }
public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate){ throw new NotImplementedException(); }

#endregion
}


public enum MaterialType{

Canvas,
Card,
Circle,
Button,
Transparency,
}

}
