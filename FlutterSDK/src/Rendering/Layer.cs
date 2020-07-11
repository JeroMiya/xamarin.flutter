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
namespace FlutterSDK.Rendering.Layer{
internal static class LayerDefaultClass{
}

public interface ILayer{
void MarkNeedsAddToScene();
void DebugMarkClean();
void UpdateSubtreeNeedsAddToScene();
void DropChild(FlutterSDK.Foundation.Node.AbstractNode child);
void AdoptChild(FlutterSDK.Foundation.Node.AbstractNode child);
void Remove();
bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool));
S Find<S>(FlutterBinding.UI.Offset localPosition);
Iterable<S> FindAll<S>(FlutterBinding.UI.Offset localPosition);
AnnotationResult<S> FindAllAnnotations<S>(FlutterBinding.UI.Offset localPosition);
void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset));
string ToStringShort();
void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties);
object DebugCreator{get;set;}
FlutterSDK.Rendering.Layer.ContainerLayer Parent{get;}
bool AlwaysNeedsAddToScene{get;}
bool DebugSubtreeNeedsAddToScene{get;}
NativeEngineLayer EngineLayer{get;set;}
FlutterSDK.Rendering.Layer.Layer NextSibling{get;}
FlutterSDK.Rendering.Layer.Layer PreviousSibling{get;}
}


public interface IAnnotationResult<T>{}

public class AnnotationResult<T>{
internal virtual List<FlutterSDK.Rendering.Layer.AnnotationEntry<T>> _Entries{get;set;}
public virtual Iterable<FlutterSDK.Rendering.Layer.AnnotationEntry<T>> Entries{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual Iterable<T> Annotations{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}

public virtual void Add(FlutterSDK.Rendering.Layer.AnnotationEntry<T> entry){ throw new NotImplementedException(); }

}
public static class AnnotationResultMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
static AnnotationResult<T> GetOrCreate<T>(IAnnotationResult<T> instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new AnnotationResult<T>();
_table.Add(instance, value);
}
return (AnnotationResult<T>)value;
}
public static Iterable<FlutterSDK.Rendering.Layer.AnnotationEntry<T>> EntriesProperty<T>(this IAnnotationResult<T> instance) => GetOrCreate(instance).Entries;
public static Iterable<T> AnnotationsProperty<T>(this IAnnotationResult<T> instance) => GetOrCreate(instance).Annotations;
public static void Add<T>(this IAnnotationResult<T> instance,FlutterSDK.Rendering.Layer.AnnotationEntry<T> entry) => GetOrCreate(instance).Add(entry);
}


public interface ILayerLink{}

public class LayerLink{
internal virtual FlutterSDK.Rendering.Layer.LeaderLayer _Leader{get;set;}
public virtual FlutterSDK.Rendering.Layer.LeaderLayer Leader{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}

}
public static class LayerLinkMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<ILayerLink, LayerLink> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ILayerLink, LayerLink>();
static LayerLink GetOrCreate(ILayerLink instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new LayerLink();
_table.Add(instance, value);
}
return (LayerLink)value;
}
public static FlutterSDK.Rendering.Layer.LeaderLayer LeaderProperty(this ILayerLink instance) => GetOrCreate(instance).Leader;
public static string ToString(this ILayerLink instance) => GetOrCreate(instance).ToString();
}


public class AnnotationEntry<T>
{
#region constructors
public AnnotationEntry(T annotation = default(T),FlutterBinding.UI.Offset localPosition = default(FlutterBinding.UI.Offset))
: base()
{
this.Annotation = annotation;
this.LocalPosition = localPosition;throw new NotImplementedException(); }
#endregion

#region fields
public virtual T Annotation{get;set;}
public virtual FlutterBinding.UI.Offset LocalPosition{get;set;}
#endregion

#region methods

#endregion
}


public class Layer : FlutterSDK.Foundation.Node.AbstractNode,IDiagnosticableTreeMixin
{
#region constructors
public Layer()
{ }
#endregion

#region fields
internal virtual bool _NeedsAddToScene{get;set;}
internal virtual NativeEngineLayer _EngineLayer{get;set;}
internal virtual FlutterSDK.Rendering.Layer.Layer _NextSibling{get;set;}
internal virtual FlutterSDK.Rendering.Layer.Layer _PreviousSibling{get;set;}
public virtual object DebugCreator{get;set;}
public virtual FlutterSDK.Rendering.Layer.ContainerLayer Parent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool AlwaysNeedsAddToScene{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool DebugSubtreeNeedsAddToScene{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual NativeEngineLayer EngineLayer{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Rendering.Layer.Layer NextSibling{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Rendering.Layer.Layer PreviousSibling{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual void MarkNeedsAddToScene(){ throw new NotImplementedException(); }


public virtual void DebugMarkClean(){ throw new NotImplementedException(); }


public virtual void UpdateSubtreeNeedsAddToScene(){ throw new NotImplementedException(); }


public new void DropChild(FlutterSDK.Foundation.Node.AbstractNode child){ throw new NotImplementedException(); }


public new void AdoptChild(FlutterSDK.Foundation.Node.AbstractNode child){ throw new NotImplementedException(); }


public virtual void Remove(){ throw new NotImplementedException(); }


public virtual bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public virtual S Find<S>(FlutterBinding.UI.Offset localPosition){ throw new NotImplementedException(); }


public virtual Iterable<S> FindAll<S>(FlutterBinding.UI.Offset localPosition){ throw new NotImplementedException(); }


public virtual AnnotationResult<S> FindAllAnnotations<S>(FlutterBinding.UI.Offset localPosition){ throw new NotImplementedException(); }


public virtual void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


private void _AddToSceneWithRetainedRendering(SceneBuilder builder){ throw new NotImplementedException(); }


public new string ToStringShort(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class PictureLayer : FlutterSDK.Rendering.Layer.Layer
{
#region constructors
public PictureLayer(FlutterBinding.UI.Rect canvasBounds)
{
this.CanvasBounds = canvasBounds;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterBinding.UI.Rect CanvasBounds{get;set;}
internal virtual SKPicture _Picture{get;set;}
internal virtual bool _IsComplexHint{get;set;}
internal virtual bool _WillChangeHint{get;set;}
public virtual SKPicture Picture{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool IsComplexHint{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool WillChangeHint{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }


public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }

#endregion
}


public class TextureLayer : FlutterSDK.Rendering.Layer.Layer
{
#region constructors
public TextureLayer(FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect),int textureId = default(int),bool freeze = false)
: base()
{
this.Rect = rect;
this.TextureId = textureId;
this.Freeze = freeze;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterBinding.UI.Rect Rect{get;set;}
public virtual int TextureId{get;set;}
public virtual bool Freeze{get;set;}
#endregion

#region methods

public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }

#endregion
}


public class PlatformViewLayer : FlutterSDK.Rendering.Layer.Layer
{
#region constructors
public PlatformViewLayer(FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect),int viewId = default(int),FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation hoverAnnotation = default(FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation))
: base()
{
this.Rect = rect;
this.ViewId = viewId;
this.HoverAnnotation = hoverAnnotation;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterBinding.UI.Rect Rect{get;set;}
public virtual int ViewId{get;set;}
public virtual FlutterSDK.Rendering.Mousetracking.MouseTrackerAnnotation HoverAnnotation{get;set;}
#endregion

#region methods

public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }

#endregion
}


public class PerformanceOverlayLayer : FlutterSDK.Rendering.Layer.Layer
{
#region constructors
public PerformanceOverlayLayer(FlutterBinding.UI.Rect overlayRect = default(FlutterBinding.UI.Rect),int optionsMask = default(int),int rasterizerThreshold = default(int),bool checkerboardRasterCacheImages = default(bool),bool checkerboardOffscreenLayers = default(bool))
: base()
{
this.OptionsMask = optionsMask;
this.RasterizerThreshold = rasterizerThreshold;
this.CheckerboardRasterCacheImages = checkerboardRasterCacheImages;
this.CheckerboardOffscreenLayers = checkerboardOffscreenLayers;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterBinding.UI.Rect _OverlayRect{get;set;}
public virtual int OptionsMask{get;set;}
public virtual int RasterizerThreshold{get;set;}
public virtual bool CheckerboardRasterCacheImages{get;set;}
public virtual bool CheckerboardOffscreenLayers{get;set;}
public virtual FlutterBinding.UI.Rect OverlayRect{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }

#endregion
}


public class ContainerLayer : FlutterSDK.Rendering.Layer.Layer
{
#region constructors
public ContainerLayer()
{ }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Layer.Layer _FirstChild{get;set;}
internal virtual FlutterSDK.Rendering.Layer.Layer _LastChild{get;set;}
public virtual FlutterSDK.Rendering.Layer.Layer FirstChild{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Rendering.Layer.Layer LastChild{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool HasChildren{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual Scene BuildScene(SceneBuilder builder){ throw new NotImplementedException(); }


private bool _DebugUltimatePreviousSiblingOf(FlutterSDK.Rendering.Layer.Layer child,FlutterSDK.Rendering.Layer.Layer equals = default(FlutterSDK.Rendering.Layer.Layer)){ throw new NotImplementedException(); }


private bool _DebugUltimateNextSiblingOf(FlutterSDK.Rendering.Layer.Layer child,FlutterSDK.Rendering.Layer.Layer equals = default(FlutterSDK.Rendering.Layer.Layer)){ throw new NotImplementedException(); }


private FlutterSDK.Rendering.Layer.PictureLayer _HighlightConflictingLayer(FlutterSDK.Rendering.Layer.PhysicalModelLayer child){ throw new NotImplementedException(); }


private List<FlutterSDK.Rendering.Layer.PictureLayer> _ProcessConflictingPhysicalLayers(FlutterSDK.Rendering.Layer.PhysicalModelLayer predecessor,FlutterSDK.Rendering.Layer.PhysicalModelLayer child){ throw new NotImplementedException(); }


private List<FlutterSDK.Rendering.Layer.PictureLayer> _DebugCheckElevations(){ throw new NotImplementedException(); }


public new void UpdateSubtreeNeedsAddToScene(){ throw new NotImplementedException(); }


public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public new void Attach(@Object owner){ throw new NotImplementedException(); }


public new void Detach(){ throw new NotImplementedException(); }


public virtual void Append(FlutterSDK.Rendering.Layer.Layer child){ throw new NotImplementedException(); }


private void _RemoveChild(FlutterSDK.Rendering.Layer.Layer child){ throw new NotImplementedException(); }


public virtual void RemoveAllChildren(){ throw new NotImplementedException(); }


public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public virtual void AddChildrenToScene(SceneBuilder builder,FlutterBinding.UI.Offset childOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public virtual void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child,Matrix4 transform){ throw new NotImplementedException(); }


public virtual List<FlutterSDK.Rendering.Layer.Layer> DepthFirstIterateChildren(){ throw new NotImplementedException(); }


public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren(){ throw new NotImplementedException(); }

#endregion
}


public class OffsetLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public OffsetLayer(FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterBinding.UI.Offset _Offset{get;set;}
public virtual FlutterBinding.UI.Offset Offset{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child,Matrix4 transform){ throw new NotImplementedException(); }


public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }


public virtual Future<SKImage> ToImage(FlutterBinding.UI.Rect bounds,double pixelRatio = 1.0){ throw new NotImplementedException(); }

#endregion
}


public class ClipRectLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public ClipRectLayer(FlutterBinding.UI.Rect clipRect = default(FlutterBinding.UI.Rect),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterBinding.UI.Rect _ClipRect{get;set;}
internal virtual FlutterBinding.UI.Clip _ClipBehavior{get;set;}
public virtual FlutterBinding.UI.Rect ClipRect{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Clip ClipBehavior{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class ClipRRectLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public ClipRRectLayer(FlutterBinding.UI.RRect clipRRect = default(FlutterBinding.UI.RRect),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterBinding.UI.RRect _ClipRRect{get;set;}
internal virtual FlutterBinding.UI.Clip _ClipBehavior{get;set;}
public virtual FlutterBinding.UI.RRect ClipRRect{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Clip ClipBehavior{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class ClipPathLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public ClipPathLayer(Path clipPath = default(Path),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual Path _ClipPath{get;set;}
internal virtual FlutterBinding.UI.Clip _ClipBehavior{get;set;}
public virtual Path ClipPath{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Clip ClipBehavior{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class ColorFilterLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public ColorFilterLayer(ColorFilter colorFilter = default(ColorFilter))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual ColorFilter _ColorFilter{get;set;}
public virtual ColorFilter ColorFilter{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class ImageFilterLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public ImageFilterLayer(ImageFilter imageFilter = default(ImageFilter))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual ImageFilter _ImageFilter{get;set;}
public virtual ImageFilter ImageFilter{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class TransformLayer : FlutterSDK.Rendering.Layer.OffsetLayer
{
#region constructors
public TransformLayer(Matrix4 transform = default(Matrix4),FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
: base(offset:offset)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual Matrix4 _Transform{get;set;}
internal virtual Matrix4 _LastEffectiveTransform{get;set;}
internal virtual Matrix4 _InvertedTransform{get;set;}
internal virtual bool _InverseDirty{get;set;}
public virtual object Transform{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


private Offset _TransformOffset(FlutterBinding.UI.Offset localPosition){ throw new NotImplementedException(); }


public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child,Matrix4 transform){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class OpacityLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public OpacityLayer(int alpha = default(int),FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual int _Alpha{get;set;}
internal virtual FlutterBinding.UI.Offset _Offset{get;set;}
public virtual int Alpha{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Offset Offset{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child,Matrix4 transform){ throw new NotImplementedException(); }


public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class ShaderMaskLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public ShaderMaskLayer(SKShader shader = default(SKShader),FlutterBinding.UI.Rect maskRect = default(FlutterBinding.UI.Rect),FlutterBinding.UI.BlendMode blendMode = default(FlutterBinding.UI.BlendMode))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual SKShader _Shader{get;set;}
internal virtual FlutterBinding.UI.Rect _MaskRect{get;set;}
internal virtual FlutterBinding.UI.BlendMode _BlendMode{get;set;}
public virtual SKShader Shader{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Rect MaskRect{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.BlendMode BlendMode{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class BackdropFilterLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public BackdropFilterLayer(ImageFilter filter = default(ImageFilter))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual ImageFilter _Filter{get;set;}
public virtual ImageFilter Filter{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }

#endregion
}


public class PhysicalModelLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public PhysicalModelLayer(Path clipPath = default(Path),FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip),double elevation = default(double),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual Path _ClipPath{get;set;}
internal virtual FlutterBinding.UI.Clip _ClipBehavior{get;set;}
internal virtual double _Elevation{get;set;}
internal virtual FlutterBinding.UI.Color _Color{get;set;}
internal virtual FlutterBinding.UI.Color _ShadowColor{get;set;}
public virtual Path ClipPath{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
internal virtual Path _DebugTransformedClipPath{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterBinding.UI.Clip ClipBehavior{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual double Elevation{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Color Color{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterBinding.UI.Color ShadowColor{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
#endregion

#region methods

public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class LeaderLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public LeaderLayer(FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink),FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset))
: base()
{
this.Offset = offset;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Layer.LayerLink _Link{get;set;}
public virtual FlutterBinding.UI.Offset Offset{get;set;}
internal virtual FlutterBinding.UI.Offset _LastOffset{get;set;}
public virtual FlutterSDK.Rendering.Layer.LayerLink Link{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool AlwaysNeedsAddToScene{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new void Attach(@Object owner){ throw new NotImplementedException(); }


public new void Detach(){ throw new NotImplementedException(); }


public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child,Matrix4 transform){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class FollowerLayer : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public FollowerLayer(FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink),bool showWhenUnlinked = true,FlutterBinding.UI.Offset unlinkedOffset = default(FlutterBinding.UI.Offset),FlutterBinding.UI.Offset linkedOffset = default(FlutterBinding.UI.Offset))
: base()
{
this.ShowWhenUnlinked = showWhenUnlinked;
this.UnlinkedOffset = unlinkedOffset;
this.LinkedOffset = linkedOffset;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Rendering.Layer.LayerLink _Link{get;set;}
public virtual bool ShowWhenUnlinked{get;set;}
public virtual FlutterBinding.UI.Offset UnlinkedOffset{get;set;}
public virtual FlutterBinding.UI.Offset LinkedOffset{get;set;}
internal virtual FlutterBinding.UI.Offset _LastOffset{get;set;}
internal virtual Matrix4 _LastTransform{get;set;}
internal virtual Matrix4 _InvertedTransform{get;set;}
internal virtual bool _InverseDirty{get;set;}
public virtual FlutterSDK.Rendering.Layer.LayerLink Link{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool AlwaysNeedsAddToScene{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private Offset _TransformOffset<S>(FlutterBinding.UI.Offset localPosition){ throw new NotImplementedException(); }


public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public virtual Matrix4 GetLastTransform(){ throw new NotImplementedException(); }


private Matrix4 _CollectTransformForLayerChain(List<FlutterSDK.Rendering.Layer.ContainerLayer> layers){ throw new NotImplementedException(); }


private void _EstablishTransform(){ throw new NotImplementedException(); }


public new void AddToScene(SceneBuilder builder,FlutterBinding.UI.Offset layerOffset = default(FlutterBinding.UI.Offset)){ throw new NotImplementedException(); }


public new void ApplyTransform(FlutterSDK.Rendering.Layer.Layer child,Matrix4 transform){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class AnnotatedRegionLayer<T> : FlutterSDK.Rendering.Layer.ContainerLayer
{
#region constructors
public AnnotatedRegionLayer(T value,Size size = default(Size),FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset),bool opaque = false)
: base()
{
this.Value = value;
this.Size = size;
this.Opaque = opaque;throw new NotImplementedException(); }
#endregion

#region fields
public virtual T Value{get;set;}
public virtual Size Size{get;set;}
public virtual FlutterBinding.UI.Offset Offset{get;set;}
public virtual bool Opaque{get;set;}
#endregion

#region methods

public new bool FindAnnotations<S>(FlutterSDK.Rendering.Layer.AnnotationResult<S> result,FlutterBinding.UI.Offset localPosition,bool onlyFirst = default(bool)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}

}
