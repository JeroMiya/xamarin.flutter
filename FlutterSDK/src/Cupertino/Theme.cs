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
namespace FlutterSDK.Cupertino.Theme{
internal static class ThemeDefaultClass{
public static FlutterSDK.Cupertino.Theme._CupertinoThemeDefaults _KDefaultTheme = default(FlutterSDK.Cupertino.Theme._CupertinoThemeDefaults);
}

public class CupertinoTheme : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public CupertinoTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Cupertino.Theme.CupertinoThemeData data = default(FlutterSDK.Cupertino.Theme.CupertinoThemeData),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key)
{
this.Data = data;
this.Child = child;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData Data{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Child{get;set;}
#endregion

#region methods

public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData Of(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public virtual Brightness BrightnessOf(FlutterSDK.Widgets.Framework.BuildContext context,bool nullOk = false){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class _InheritedCupertinoTheme : FlutterSDK.Widgets.Framework.InheritedWidget
{
#region constructors
public _InheritedCupertinoTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Cupertino.Theme.CupertinoTheme theme = default(FlutterSDK.Cupertino.Theme.CupertinoTheme),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key,child:child)
{
this.Theme = theme;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Cupertino.Theme.CupertinoTheme Theme{get;set;}
#endregion

#region methods

public new bool UpdateShouldNotify(FlutterSDK.Cupertino.Theme._InheritedCupertinoTheme old){ throw new NotImplementedException(); }
public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget){ throw new NotImplementedException(); }

#endregion
}


public class CupertinoThemeData : IDiagnosticable
{
#region constructors
public CupertinoThemeData(Brightness brightness = default(Brightness),FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color primaryContrastingColor = default(FlutterBinding.UI.Color),FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme = default(FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData),FlutterBinding.UI.Color barBackgroundColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color))
: base()
{
throw new NotImplementedException(); }
public static CupertinoThemeData Raw(Brightness brightness,FlutterBinding.UI.Color primaryColor,FlutterBinding.UI.Color primaryContrastingColor,FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme,FlutterBinding.UI.Color barBackgroundColor,FlutterBinding.UI.Color scaffoldBackgroundColor)
{
var instance =new CupertinoThemeData();throw new NotImplementedException(); }
internal static CupertinoThemeData _RawWithDefaults(Brightness brightness,FlutterBinding.UI.Color _primaryColor,FlutterBinding.UI.Color _primaryContrastingColor,FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData _textTheme,FlutterBinding.UI.Color _barBackgroundColor,FlutterBinding.UI.Color _scaffoldBackgroundColor,FlutterSDK.Cupertino.Theme._CupertinoThemeDefaults _defaults)
{
var instance =new CupertinoThemeData();instance.Brightness = brightness;
instance._PrimaryColor = _primaryColor;
instance._PrimaryContrastingColor = _primaryContrastingColor;
instance._TextTheme = _textTheme;
instance._BarBackgroundColor = _barBackgroundColor;
instance._ScaffoldBackgroundColor = _scaffoldBackgroundColor;
instance._Defaults = _defaults;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Cupertino.Theme._CupertinoThemeDefaults _Defaults{get;set;}
public virtual Brightness Brightness{get;set;}
internal virtual FlutterBinding.UI.Color _PrimaryColor{get;set;}
internal virtual FlutterBinding.UI.Color _PrimaryContrastingColor{get;set;}
internal virtual FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData _TextTheme{get;set;}
internal virtual FlutterBinding.UI.Color _BarBackgroundColor{get;set;}
internal virtual FlutterBinding.UI.Color _ScaffoldBackgroundColor{get;set;}
public virtual FlutterBinding.UI.Color PrimaryColor{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterBinding.UI.Color PrimaryContrastingColor{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData TextTheme{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterBinding.UI.Color BarBackgroundColor{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterBinding.UI.Color ScaffoldBackgroundColor{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData NoDefault(){ throw new NotImplementedException(); }


public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context,bool nullOk = false){ throw new NotImplementedException(); }


public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData CopyWith(Brightness brightness = default(Brightness),FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color primaryContrastingColor = default(FlutterBinding.UI.Color),FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme = default(FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData),FlutterBinding.UI.Color barBackgroundColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color)){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class _NoDefaultCupertinoThemeData : FlutterSDK.Cupertino.Theme.CupertinoThemeData
{
#region constructors
public _NoDefaultCupertinoThemeData(Brightness brightness,FlutterBinding.UI.Color primaryColor,FlutterBinding.UI.Color primaryContrastingColor,FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme,FlutterBinding.UI.Color barBackgroundColor,FlutterBinding.UI.Color scaffoldBackgroundColor)
: base(brightness,primaryColor,primaryContrastingColor,textTheme,barBackgroundColor,scaffoldBackgroundColor,null)
{
this.PrimaryColor = primaryColor;
this.PrimaryContrastingColor = primaryContrastingColor;
this.TextTheme = textTheme;
this.BarBackgroundColor = barBackgroundColor;
this.ScaffoldBackgroundColor = scaffoldBackgroundColor;throw new NotImplementedException(); }
#endregion

#region fields
public new FlutterBinding.UI.Color PrimaryColor{get;set;}
public new FlutterBinding.UI.Color PrimaryContrastingColor{get;set;}
public new FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData TextTheme{get;set;}
public new FlutterBinding.UI.Color BarBackgroundColor{get;set;}
public new FlutterBinding.UI.Color ScaffoldBackgroundColor{get;set;}
#endregion

#region methods

public new FlutterSDK.Cupertino.Theme._NoDefaultCupertinoThemeData ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context,bool nullOk = false){ throw new NotImplementedException(); }


public new FlutterSDK.Cupertino.Theme.CupertinoThemeData CopyWith(Brightness brightness = default(Brightness),FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color primaryContrastingColor = default(FlutterBinding.UI.Color),FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme = default(FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData),FlutterBinding.UI.Color barBackgroundColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color)){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoThemeDefaults
{
#region constructors
public _CupertinoThemeDefaults(Brightness brightness,FlutterBinding.UI.Color primaryColor,FlutterBinding.UI.Color primaryContrastingColor,FlutterBinding.UI.Color barBackgroundColor,FlutterBinding.UI.Color scaffoldBackgroundColor,FlutterSDK.Cupertino.Theme._CupertinoTextThemeDefaults textThemeDefaults)
{
this.Brightness = brightness;
this.PrimaryColor = primaryColor;
this.PrimaryContrastingColor = primaryContrastingColor;
this.BarBackgroundColor = barBackgroundColor;
this.ScaffoldBackgroundColor = scaffoldBackgroundColor;
this.TextThemeDefaults = textThemeDefaults;throw new NotImplementedException(); }
#endregion

#region fields
public virtual Brightness Brightness{get;set;}
public virtual FlutterBinding.UI.Color PrimaryColor{get;set;}
public virtual FlutterBinding.UI.Color PrimaryContrastingColor{get;set;}
public virtual FlutterBinding.UI.Color BarBackgroundColor{get;set;}
public virtual FlutterBinding.UI.Color ScaffoldBackgroundColor{get;set;}
public virtual FlutterSDK.Cupertino.Theme._CupertinoTextThemeDefaults TextThemeDefaults{get;set;}
#endregion

#region methods

public virtual FlutterSDK.Cupertino.Theme._CupertinoThemeDefaults ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context,bool resolveTextTheme,bool nullOk = default(bool)){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoTextThemeDefaults
{
#region constructors
public _CupertinoTextThemeDefaults(FlutterBinding.UI.Color labelColor,FlutterBinding.UI.Color inactiveGray)
{
this.LabelColor = labelColor;
this.InactiveGray = inactiveGray;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterBinding.UI.Color LabelColor{get;set;}
public virtual FlutterBinding.UI.Color InactiveGray{get;set;}
#endregion

#region methods

public virtual FlutterSDK.Cupertino.Theme._CupertinoTextThemeDefaults ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context,bool nullOk = default(bool)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData CreateDefaults(FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color)){ throw new NotImplementedException(); }

#endregion
}


public class _DefaultCupertinoTextThemeData : FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData
{
#region constructors
public _DefaultCupertinoTextThemeData(FlutterBinding.UI.Color labelColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color inactiveGray = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color))
: base(primaryColor:primaryColor)
{
this.LabelColor = labelColor;
this.InactiveGray = inactiveGray;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterBinding.UI.Color LabelColor{get;set;}
public virtual FlutterBinding.UI.Color InactiveGray{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Painting.Textstyle.TextStyle TabLabelTextStyle{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Painting.Textstyle.TextStyle NavTitleTextStyle{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Painting.Textstyle.TextStyle NavLargeTitleTextStyle{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Painting.Textstyle.TextStyle PickerTextStyle{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Painting.Textstyle.TextStyle DateTimePickerTextStyle{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods
#endregion
}

}