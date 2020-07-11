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
namespace FlutterSDK.Cupertino.Colors{
internal static class ColorsDefaultClass{
internal static FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<Color> CreateCupertinoColorProperty(string name,FlutterBinding.UI.Color value,bool showName = true,@Object defaultValue = default(@Object),FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle),DiagnosticLevel level = default(DiagnosticLevel)){
throw new NotImplementedException();
}

}

public class CupertinoColors
{
#region constructors
internal CupertinoColors()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor ActiveBlue{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor ActiveGreen{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor ActiveOrange{get;set;}
public virtual FlutterBinding.UI.Color White{get;set;}
public virtual FlutterBinding.UI.Color Black{get;set;}
public virtual FlutterBinding.UI.Color LightBackgroundGray{get;set;}
public virtual FlutterBinding.UI.Color ExtraLightBackgroundGray{get;set;}
public virtual FlutterBinding.UI.Color DarkBackgroundGray{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor InactiveGray{get;set;}
public virtual FlutterBinding.UI.Color DestructiveRed{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemBlue{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGreen{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemIndigo{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemOrange{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemPink{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemPurple{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemRed{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemTeal{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemYellow{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey2{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey3{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey4{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey5{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey6{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor Label{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SecondaryLabel{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor TertiaryLabel{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor QuaternaryLabel{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemFill{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SecondarySystemFill{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor TertiarySystemFill{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor QuaternarySystemFill{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor PlaceholderText{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemBackground{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SecondarySystemBackground{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor TertiarySystemBackground{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGroupedBackground{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SecondarySystemGroupedBackground{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor TertiarySystemGroupedBackground{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor Separator{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor OpaqueSeparator{get;set;}
public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor Link{get;set;}
#endregion

#region methods
#endregion
}


public class CupertinoDynamicColor : Color,IDiagnosticable
{
#region constructors
public CupertinoDynamicColor(string debugLabel = default(string),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color darkColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color highContrastColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color darkHighContrastColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color elevatedColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color darkElevatedColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color highContrastElevatedColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color darkHighContrastElevatedColor = default(FlutterBinding.UI.Color))
: base()
{
throw new NotImplementedException(); }
public static CupertinoDynamicColor WithBrightnessAndContrast(string debugLabel = default(string),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color darkColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color highContrastColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color darkHighContrastColor = default(FlutterBinding.UI.Color))
{
var instance =new CupertinoDynamicColor();throw new NotImplementedException(); }
public static CupertinoDynamicColor WithBrightness(string debugLabel = default(string),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color darkColor = default(FlutterBinding.UI.Color))
{
var instance =new CupertinoDynamicColor();throw new NotImplementedException(); }
internal CupertinoDynamicColor(FlutterBinding.UI.Color _effectiveColor,FlutterBinding.UI.Color color,FlutterBinding.UI.Color darkColor,FlutterBinding.UI.Color highContrastColor,FlutterBinding.UI.Color darkHighContrastColor,FlutterBinding.UI.Color elevatedColor,FlutterBinding.UI.Color darkElevatedColor,FlutterBinding.UI.Color highContrastElevatedColor,FlutterBinding.UI.Color darkHighContrastElevatedColor,FlutterSDK.Widgets.Framework.Element _debugResolveContext,string _debugLabel)
: base(0)
{
this._EffectiveColor = _effectiveColor;
this.Color = color;
this.DarkColor = darkColor;
this.HighContrastColor = highContrastColor;
this.DarkHighContrastColor = darkHighContrastColor;
this.ElevatedColor = elevatedColor;
this.DarkElevatedColor = darkElevatedColor;
this.HighContrastElevatedColor = highContrastElevatedColor;
this.DarkHighContrastElevatedColor = darkHighContrastElevatedColor;
this._DebugResolveContext = _debugResolveContext;
this._DebugLabel = _debugLabel;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterBinding.UI.Color _EffectiveColor{get;set;}
internal virtual string _DebugLabel{get;set;}
internal virtual FlutterSDK.Widgets.Framework.Element _DebugResolveContext{get;set;}
public virtual FlutterBinding.UI.Color Color{get;set;}
public virtual FlutterBinding.UI.Color DarkColor{get;set;}
public virtual FlutterBinding.UI.Color HighContrastColor{get;set;}
public virtual FlutterBinding.UI.Color DarkHighContrastColor{get;set;}
public virtual FlutterBinding.UI.Color ElevatedColor{get;set;}
public virtual FlutterBinding.UI.Color DarkElevatedColor{get;set;}
public virtual FlutterBinding.UI.Color HighContrastElevatedColor{get;set;}
public virtual FlutterBinding.UI.Color DarkHighContrastElevatedColor{get;set;}
public virtual int Value{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual bool _IsPlatformBrightnessDependent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual bool _IsHighContrastDependent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual bool _IsInterfaceElevationDependent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual Color Resolve(FlutterBinding.UI.Color resolvable,FlutterSDK.Widgets.Framework.BuildContext context,bool nullOk = true){ throw new NotImplementedException(); }


public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context,bool nullOk = true){ throw new NotImplementedException(); }


public new bool Equals(@Object other){ throw new NotImplementedException(); }



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}

}