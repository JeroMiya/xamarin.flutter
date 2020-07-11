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
namespace FlutterSDK.Cupertino.Navbar{
internal static class NavbarDefaultClass{
public static double _KNavBarPersistentHeight = default(double);
public static double _KNavBarLargeTitleHeightExtension = default(double);
public static double _KNavBarShowLargeTitleThreshold = default(double);
public static double _KNavBarEdgePadding = default(double);
public static double _KNavBarBackButtonTapWidth = default(double);
public static TimeSpan _KNavBarTitleFadeDuration = default(TimeSpan);
public static Color _KDefaultNavBarBorderColor = default(Color);
public static FlutterSDK.Painting.Boxborder.Border _KDefaultNavBarBorder = default(FlutterSDK.Painting.Boxborder.Border);
public static FlutterSDK.Cupertino.Navbar._HeroTag _DefaultHeroTag = default(FlutterSDK.Cupertino.Navbar._HeroTag);
public static object _LinearTranslateWithLargestRectSizeTween = default(object);
public static object _NavBarHeroLaunchPadBuilder = default(object);
public static object _NavBarHeroFlightShuttleBuilder = default(object);
internal static FlutterSDK.Widgets.Framework.Widget _WrapWithBackground(FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),Brightness brightness = default(Brightness),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget),bool updateSystemUiOverlay = true){
throw new NotImplementedException();
}

internal static FlutterSDK.Widgets.Framework.Widget _WrapActiveColor(FlutterBinding.UI.Color color,FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Widgets.Framework.Widget child){
throw new NotImplementedException();
}

internal static bool _IsTransitionable(FlutterSDK.Widgets.Framework.BuildContext context){
throw new NotImplementedException();
}

}

public class _HeroTag
{
#region constructors
public _HeroTag(FlutterSDK.Widgets.Navigator.NavigatorState navigator)
{
this.Navigator = navigator;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Navigator.NavigatorState Navigator{get;set;}
public virtual int HashCode{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods


public new bool Equals(@Object other){ throw new NotImplementedException(); }

#endregion
}


public class CupertinoNavigationBar : FlutterSDK.Widgets.Framework.StatefulWidget,FlutterSDK.Cupertino.Pagescaffold.IObstructingPreferredSizeWidget
{
#region constructors
public CupertinoNavigationBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget),bool automaticallyImplyLeading = true,bool automaticallyImplyMiddle = true,string previousPageTitle = default(string),FlutterSDK.Widgets.Framework.Widget middle = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Framework.Widget trailing = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),Brightness brightness = default(Brightness),FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional),FlutterBinding.UI.Color actionsForegroundColor = default(FlutterBinding.UI.Color),bool transitionBetweenRoutes = true,@Object heroTag = default(@Object))
: base(key:key)
{
this.Leading = leading;
this.AutomaticallyImplyLeading = automaticallyImplyLeading;
this.AutomaticallyImplyMiddle = automaticallyImplyMiddle;
this.PreviousPageTitle = previousPageTitle;
this.Middle = middle;
this.Trailing = trailing;
this.Border = border;
this.BackgroundColor = backgroundColor;
this.Brightness = brightness;
this.Padding = padding;
this.ActionsForegroundColor = actionsForegroundColor;
this.TransitionBetweenRoutes = transitionBetweenRoutes;
this.HeroTag = heroTag;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Leading{get;set;}
public virtual bool AutomaticallyImplyLeading{get;set;}
public virtual bool AutomaticallyImplyMiddle{get;set;}
public virtual string PreviousPageTitle{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Middle{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Trailing{get;set;}
public virtual FlutterBinding.UI.Color BackgroundColor{get;set;}
public virtual Brightness Brightness{get;set;}
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Padding{get;set;}
public virtual FlutterSDK.Painting.Boxborder.Border Border{get;set;}
public virtual FlutterBinding.UI.Color ActionsForegroundColor{get;set;}
public virtual bool TransitionBetweenRoutes{get;set;}
public virtual @Object HeroTag{get;set;}
public virtual Size PreferredSize{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new bool ShouldFullyObstruct(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new FlutterSDK.Cupertino.Navbar._CupertinoNavigationBarState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoNavigationBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Navbar.CupertinoNavigationBar>
{
#region constructors
public _CupertinoNavigationBarState()
{ }
#endregion

#region fields
public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys Keys{get;set;}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class CupertinoSliverNavigationBar : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public CupertinoSliverNavigationBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Framework.Widget largeTitle = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget),bool automaticallyImplyLeading = true,bool automaticallyImplyTitle = true,string previousPageTitle = default(string),FlutterSDK.Widgets.Framework.Widget middle = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Framework.Widget trailing = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),Brightness brightness = default(Brightness),FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional),FlutterBinding.UI.Color actionsForegroundColor = default(FlutterBinding.UI.Color),bool transitionBetweenRoutes = true,@Object heroTag = default(@Object))
: base(key:key)
{
this.LargeTitle = largeTitle;
this.Leading = leading;
this.AutomaticallyImplyLeading = automaticallyImplyLeading;
this.AutomaticallyImplyTitle = automaticallyImplyTitle;
this.PreviousPageTitle = previousPageTitle;
this.Middle = middle;
this.Trailing = trailing;
this.Border = border;
this.BackgroundColor = backgroundColor;
this.Brightness = brightness;
this.Padding = padding;
this.ActionsForegroundColor = actionsForegroundColor;
this.TransitionBetweenRoutes = transitionBetweenRoutes;
this.HeroTag = heroTag;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget LargeTitle{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Leading{get;set;}
public virtual bool AutomaticallyImplyLeading{get;set;}
public virtual bool AutomaticallyImplyTitle{get;set;}
public virtual string PreviousPageTitle{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Middle{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Trailing{get;set;}
public virtual FlutterBinding.UI.Color BackgroundColor{get;set;}
public virtual Brightness Brightness{get;set;}
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Padding{get;set;}
public virtual FlutterSDK.Painting.Boxborder.Border Border{get;set;}
public virtual FlutterBinding.UI.Color ActionsForegroundColor{get;set;}
public virtual bool TransitionBetweenRoutes{get;set;}
public virtual @Object HeroTag{get;set;}
public virtual bool Opaque{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new FlutterSDK.Cupertino.Navbar._CupertinoSliverNavigationBarState CreateState(){ throw new NotImplementedException(); }

#endregion
}


public class _CupertinoSliverNavigationBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Navbar.CupertinoSliverNavigationBar>
{
#region constructors
public _CupertinoSliverNavigationBarState()
{ }
#endregion

#region fields
public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys Keys{get;set;}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _LargeTitleNavigationBarSliverDelegate : FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate,IDiagnosticableTreeMixin
{
#region constructors
public _LargeTitleNavigationBarSliverDelegate(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys keys = default(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys),FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents components = default(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents),FlutterSDK.Widgets.Framework.Widget userMiddle = default(FlutterSDK.Widgets.Framework.Widget),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),Brightness brightness = default(Brightness),FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border),FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional),FlutterBinding.UI.Color actionsForegroundColor = default(FlutterBinding.UI.Color),bool transitionBetweenRoutes = default(bool),@Object heroTag = default(@Object),double persistentHeight = default(double),bool alwaysShowMiddle = default(bool))
: base()
{
this.Keys = keys;
this.Components = components;
this.UserMiddle = userMiddle;
this.BackgroundColor = backgroundColor;
this.Brightness = brightness;
this.Border = border;
this.Padding = padding;
this.ActionsForegroundColor = actionsForegroundColor;
this.TransitionBetweenRoutes = transitionBetweenRoutes;
this.HeroTag = heroTag;
this.PersistentHeight = persistentHeight;
this.AlwaysShowMiddle = alwaysShowMiddle;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys Keys{get;set;}
public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents Components{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget UserMiddle{get;set;}
public virtual FlutterBinding.UI.Color BackgroundColor{get;set;}
public virtual Brightness Brightness{get;set;}
public virtual FlutterSDK.Painting.Boxborder.Border Border{get;set;}
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Padding{get;set;}
public virtual FlutterBinding.UI.Color ActionsForegroundColor{get;set;}
public virtual bool TransitionBetweenRoutes{get;set;}
public virtual @Object HeroTag{get;set;}
public virtual double PersistentHeight{get;set;}
public virtual bool AlwaysShowMiddle{get;set;}
public virtual double MinExtent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual double MaxExtent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context,double shrinkOffset,bool overlapsContent){ throw new NotImplementedException(); }


public new bool ShouldRebuild(FlutterSDK.Cupertino.Navbar._LargeTitleNavigationBarSliverDelegate oldDelegate){ throw new NotImplementedException(); }
public new bool ShouldRebuild(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate oldDelegate){ throw new NotImplementedException(); }

#endregion
}


public class _PersistentNavigationBar : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _PersistentNavigationBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents components = default(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents),FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional),bool middleVisible = default(bool))
: base(key:key)
{
this.Components = components;
this.Padding = padding;
this.MiddleVisible = middleVisible;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents Components{get;set;}
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Padding{get;set;}
public virtual bool MiddleVisible{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _NavigationBarStaticComponentsKeys
{
#region constructors
public _NavigationBarStaticComponentsKeys()
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> NavBarBoxKey{get;set;}
public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> LeadingKey{get;set;}
public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> BackChevronKey{get;set;}
public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> BackLabelKey{get;set;}
public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> MiddleKey{get;set;}
public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> TrailingKey{get;set;}
public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> LargeTitleKey{get;set;}
#endregion

#region methods
#endregion
}


public class _NavigationBarStaticComponents
{
#region constructors
public _NavigationBarStaticComponents(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys keys = default(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys),FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>),FlutterSDK.Widgets.Framework.Widget userLeading = default(FlutterSDK.Widgets.Framework.Widget),bool automaticallyImplyLeading = default(bool),bool automaticallyImplyTitle = default(bool),string previousPageTitle = default(string),FlutterSDK.Widgets.Framework.Widget userMiddle = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Framework.Widget userTrailing = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Framework.Widget userLargeTitle = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional),bool large = default(bool))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Basic.KeyedSubtree Leading{get;set;}
public virtual FlutterSDK.Widgets.Basic.KeyedSubtree BackChevron{get;set;}
public virtual FlutterSDK.Widgets.Basic.KeyedSubtree BackLabel{get;set;}
public virtual FlutterSDK.Widgets.Basic.KeyedSubtree Middle{get;set;}
public virtual FlutterSDK.Widgets.Basic.KeyedSubtree Trailing{get;set;}
public virtual FlutterSDK.Widgets.Basic.KeyedSubtree LargeTitle{get;set;}
#endregion

#region methods

private FlutterSDK.Widgets.Framework.Widget _DerivedTitle(bool automaticallyImplyTitle = default(bool),FlutterSDK.Widgets.Routes.ModalRoute<object> currentRoute = default(FlutterSDK.Widgets.Routes.ModalRoute<object>)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateLeading(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> leadingKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>),FlutterSDK.Widgets.Framework.Widget userLeading = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>),bool automaticallyImplyLeading = default(bool),FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateBackChevron(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> backChevronKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>),FlutterSDK.Widgets.Framework.Widget userLeading = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>),bool automaticallyImplyLeading = default(bool)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateBackLabel(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> backLabelKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>),FlutterSDK.Widgets.Framework.Widget userLeading = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>),bool automaticallyImplyLeading = default(bool),string previousPageTitle = default(string)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateMiddle(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> middleKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>),FlutterSDK.Widgets.Framework.Widget userMiddle = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Widgets.Framework.Widget userLargeTitle = default(FlutterSDK.Widgets.Framework.Widget),bool large = default(bool),bool automaticallyImplyTitle = default(bool),FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateTrailing(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> trailingKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>),FlutterSDK.Widgets.Framework.Widget userTrailing = default(FlutterSDK.Widgets.Framework.Widget),FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateLargeTitle(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> largeTitleKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>),FlutterSDK.Widgets.Framework.Widget userLargeTitle = default(FlutterSDK.Widgets.Framework.Widget),bool large = default(bool),bool automaticImplyTitle = default(bool),FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>)){ throw new NotImplementedException(); }

#endregion
}


public class CupertinoNavigationBarBackButton : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public CupertinoNavigationBarBackButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color),string previousPageTitle = default(string),VoidCallback onPressed = default(VoidCallback))
: base(key:key)
{
this.Color = color;
this.PreviousPageTitle = previousPageTitle;
this.OnPressed = onPressed;throw new NotImplementedException(); }
internal static CupertinoNavigationBarBackButton _Assemble(FlutterSDK.Widgets.Framework.Widget _backChevron,FlutterSDK.Widgets.Framework.Widget _backLabel)
{
var instance =new CupertinoNavigationBarBackButton();instance._BackChevron = _backChevron;
instance._BackLabel = _backLabel;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterBinding.UI.Color Color{get;set;}
public virtual string PreviousPageTitle{get;set;}
public virtual VoidCallback OnPressed{get;set;}
internal virtual FlutterSDK.Widgets.Framework.Widget _BackChevron{get;set;}
internal virtual FlutterSDK.Widgets.Framework.Widget _BackLabel{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _BackChevron : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _BackChevron(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
: base(key:key)
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _BackLabel : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _BackLabel(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),string specifiedPreviousTitle = default(string),FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>))
: base(key:key)
{
this.SpecifiedPreviousTitle = specifiedPreviousTitle;
this.Route = route;throw new NotImplementedException(); }
#endregion

#region fields
public virtual string SpecifiedPreviousTitle{get;set;}
public virtual FlutterSDK.Widgets.Routes.ModalRoute<object> Route{get;set;}
#endregion

#region methods

private FlutterSDK.Widgets.Framework.Widget _BuildPreviousTitleWidget(FlutterSDK.Widgets.Framework.BuildContext context,string previousTitle,FlutterSDK.Widgets.Framework.Widget child){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _TransitionableNavigationBar : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _TransitionableNavigationBar(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys componentsKeys = default(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys),FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color),FlutterSDK.Painting.Textstyle.TextStyle backButtonTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle),FlutterSDK.Painting.Textstyle.TextStyle titleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle),FlutterSDK.Painting.Textstyle.TextStyle largeTitleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle),FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border),bool hasUserMiddle = default(bool),bool largeExpanded = default(bool),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:componentsKeys.NavBarBoxKey)
{
this.ComponentsKeys = componentsKeys;
this.BackgroundColor = backgroundColor;
this.BackButtonTextStyle = backButtonTextStyle;
this.TitleTextStyle = titleTextStyle;
this.LargeTitleTextStyle = largeTitleTextStyle;
this.Border = border;
this.HasUserMiddle = hasUserMiddle;
this.LargeExpanded = largeExpanded;
this.Child = child;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys ComponentsKeys{get;set;}
public virtual FlutterBinding.UI.Color BackgroundColor{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle BackButtonTextStyle{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle TitleTextStyle{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle LargeTitleTextStyle{get;set;}
public virtual FlutterSDK.Painting.Boxborder.Border Border{get;set;}
public virtual bool HasUserMiddle{get;set;}
public virtual bool LargeExpanded{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget Child{get;set;}
public virtual FlutterSDK.Rendering.Box.RenderBox RenderBox{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _NavigationBarTransition : FlutterSDK.Widgets.Framework.StatelessWidget
{
#region constructors
public _NavigationBarTransition(FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>),FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar topNavBar = default(FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar),FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar bottomNavBar = default(FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar))
: base()
{
this.Animation = animation;
this.TopNavBar = topNavBar;
this.BottomNavBar = bottomNavBar;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Animation.Animation<double> Animation{get;set;}
public virtual FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar TopNavBar{get;set;}
public virtual FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar BottomNavBar{get;set;}
public virtual FlutterSDK.Animation.Tween.Tween<double> HeightTween{get;set;}
public virtual FlutterSDK.Animation.Tween.ColorTween BackgroundTween{get;set;}
public virtual FlutterSDK.Widgets.Implicitanimations.BorderTween BorderTween{get;set;}
#endregion

#region methods

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _NavigationBarComponentsTransition
{
#region constructors
public _NavigationBarComponentsTransition(FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>),FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar bottomNavBar = default(FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar),FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar topNavBar = default(FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar),TextDirection directionality = default(TextDirection))
: base()
{
this.Animation = animation;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Animation.Tween.Animatable<double> FadeOut{get;set;}
public virtual FlutterSDK.Animation.Tween.Animatable<double> FadeIn{get;set;}
public virtual FlutterSDK.Animation.Animation.Animation<double> Animation{get;set;}
public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys BottomComponents{get;set;}
public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys TopComponents{get;set;}
public virtual FlutterSDK.Rendering.Box.RenderBox BottomNavBarBox{get;set;}
public virtual FlutterSDK.Rendering.Box.RenderBox TopNavBarBox{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle BottomBackButtonTextStyle{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle TopBackButtonTextStyle{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle BottomTitleTextStyle{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle TopTitleTextStyle{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle BottomLargeTitleTextStyle{get;set;}
public virtual FlutterSDK.Painting.Textstyle.TextStyle TopLargeTitleTextStyle{get;set;}
public virtual bool BottomHasUserMiddle{get;set;}
public virtual bool TopHasUserMiddle{get;set;}
public virtual bool BottomLargeExpanded{get;set;}
public virtual bool TopLargeExpanded{get;set;}
public virtual FlutterBinding.UI.Rect TransitionBox{get;set;}
public virtual double ForwardDirection{get;set;}
public virtual FlutterSDK.Widgets.Framework.Widget BottomLeading{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget BottomBackChevron{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget BottomBackLabel{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget BottomMiddle{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget BottomLargeTitle{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget BottomTrailing{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget TopLeading{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget TopBackChevron{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget TopBackLabel{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget TopMiddle{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget TopTrailing{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Widgets.Framework.Widget TopLargeTitle{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual FlutterSDK.Rendering.Stack.RelativeRect PositionInTransitionBox(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> key,FlutterSDK.Rendering.Box.RenderBox from = default(FlutterSDK.Rendering.Box.RenderBox)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Transitions.RelativeRectTween SlideFromLeadingEdge(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> fromKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>),FlutterSDK.Rendering.Box.RenderBox fromNavBarBox = default(FlutterSDK.Rendering.Box.RenderBox),FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> toKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>),FlutterSDK.Rendering.Box.RenderBox toNavBarBox = default(FlutterSDK.Rendering.Box.RenderBox)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Animation.Animation.Animation<double> FadeInFrom(double t,FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)){ throw new NotImplementedException(); }


public virtual FlutterSDK.Animation.Animation.Animation<double> FadeOutBy(double t,FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve)){ throw new NotImplementedException(); }

#endregion
}

}
