using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Cupertino.Navbar
{
    internal static class NavbarDefaultClass
    {
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
        /// <Summary>
        /// Returns `child` wrapped with background and a bottom border if background color
        /// is opaque. Otherwise, also blur with [BackdropFilter].
        ///
        /// When `updateSystemUiOverlay` is true, the nav bar will update the OS
        /// status bar's color theme based on the background color of the nav bar.
        /// </Summary>
        internal static FlutterSDK.Widgets.Framework.Widget _WrapWithBackground(FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool updateSystemUiOverlay = true)
        {
            Widget result = child;
            if (updateSystemUiOverlay)
            {
                bool isDark = backgroundColor.ComputeLuminance() < 0.179;
                Brightness newBrightness = brightness ?? (isDark ? Brightness.Dark : Brightness.Light);
                SystemUiOverlayStyle overlayStyle = default(SystemUiOverlayStyle);
                switch (newBrightness) { case Brightness.Dark: overlayStyle = SystemchromeDefaultClass.SystemUiOverlayStyle.Light; break; case Brightness.Light: default: overlayStyle = SystemchromeDefaultClass.SystemUiOverlayStyle.Dark; break; }
                result = new AnnotatedRegion<SystemUiOverlayStyle>(value: overlayStyle, sized: true, child: result);
            }

            DecoratedBox childWithBackground = new DecoratedBox(decoration: new BoxDecoration(border: border, color: backgroundColor), child: result);
            if (backgroundColor.Alpha == 0xFF) return childWithBackground;
            return new ClipRect(child: new BackdropFilter(filter: ImageFilter.Blur(sigmaX: 10.0, sigmaY: 10.0), child: childWithBackground));
        }



        internal static FlutterSDK.Widgets.Framework.Widget _WrapActiveColor(FlutterBinding.UI.Color color, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            if (color == null)
            {
                return child;
            }

            return new CupertinoTheme(data: ThemeDefaultClass.CupertinoTheme.Of(context).CopyWith(primaryColor: color), child: child);
        }



        internal static bool _IsTransitionable(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ModalRoute<object> route = RoutesDefaultClass.ModalRoute.Of(context);
            return route is PageRoute && !route.FullscreenDialog;
        }



    }

    public class _HeroTag
    {
        public _HeroTag(FlutterSDK.Widgets.Navigator.NavigatorState navigator)
        {
            this.Navigator = navigator;
        }
        public virtual FlutterSDK.Widgets.Navigator.NavigatorState Navigator { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }


        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return other is _HeroTag && other.Navigator == Navigator;
        }



    }


    /// <Summary>
    /// An iOS-styled navigation bar.
    ///
    /// The navigation bar is a toolbar that minimally consists of a widget, normally
    /// a page title, in the [middle] of the toolbar.
    ///
    /// It also supports a [leading] and [trailing] widget before and after the
    /// [middle] widget while keeping the [middle] widget centered.
    ///
    /// The [leading] widget will automatically be a back chevron icon button (or a
    /// close button in case of a fullscreen dialog) to pop the current route if none
    /// is provided and [automaticallyImplyLeading] is true (true by default).
    ///
    /// The [middle] widget will automatically be a title text from the current
    /// [CupertinoPageRoute] if none is provided and [automaticallyImplyMiddle] is
    /// true (true by default).
    ///
    /// It should be placed at top of the screen and automatically accounts for
    /// the OS's status bar.
    ///
    /// If the given [backgroundColor]'s opacity is not 1.0 (which is the case by
    /// default), it will produce a blurring effect to the content behind it.
    ///
    /// When [transitionBetweenRoutes] is true, this navigation bar will transition
    /// on top of the routes instead of inside them if the route being transitioned
    /// to also has a [CupertinoNavigationBar] or a [CupertinoSliverNavigationBar]
    /// with [transitionBetweenRoutes] set to true. If [transitionBetweenRoutes] is
    /// true, none of the [Widget] parameters can contain a key in its subtree since
    /// that widget will exist in multiple places in the tree simultaneously.
    ///
    /// By default, only one [CupertinoNavigationBar] or [CupertinoSliverNavigationBar]
    /// should be present in each [PageRoute] to support the default transitions.
    /// Use [transitionBetweenRoutes] or [heroTag] to customize the transition
    /// behavior for multiple navigation bars per route.
    ///
    /// When used in a [CupertinoPageScaffold], [CupertinoPageScaffold.navigationBar]
    /// has its text scale factor set to 1.0 and does not respond to text scale factor
    /// changes from the operating system, to match the native iOS behavior. To override
    /// this behavior, wrap each of the `navigationBar`'s components inside a [MediaQuery]
    /// with the desired [MediaQueryData.textScaleFactor] value. The text scale factor
    /// value from the operating system can be retrieved in many ways, such as querying
    /// [MediaQuery.textScaleFactorOf] against [CupertinoApp]'s [BuildContext].
    ///
    /// See also:
    ///
    ///  * [CupertinoPageScaffold], a page layout helper typically hosting the
    ///    [CupertinoNavigationBar].
    ///  * [CupertinoSliverNavigationBar] for a navigation bar to be placed in a
    ///    scrolling list and that supports iOS-11-style large titles.
    /// </Summary>
    public class CupertinoNavigationBar : FlutterSDK.Widgets.Framework.StatefulWidget, FlutterSDK.Cupertino.Pagescaffold.IObstructingPreferredSizeWidget
    {
        /// <Summary>
        /// Creates a navigation bar in the iOS style.
        /// </Summary>
        public CupertinoNavigationBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), bool automaticallyImplyLeading = true, bool automaticallyImplyMiddle = true, string previousPageTitle = default(string), FlutterSDK.Widgets.Framework.Widget middle = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget trailing = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional), FlutterBinding.UI.Color actionsForegroundColor = default(FlutterBinding.UI.Color), bool transitionBetweenRoutes = true, @Object heroTag = default(@Object))
        : base(key: key)
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
            this.HeroTag = heroTag;
        }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.leading}
        /// Widget to place at the start of the navigation bar. Normally a back button
        /// for a normal page or a cancel button for full page dialogs.
        ///
        /// If null and [automaticallyImplyLeading] is true, an appropriate button
        /// will be automatically created.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Leading { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.automaticallyImplyLeading}
        /// Controls whether we should try to imply the leading widget if null.
        ///
        /// If true and [leading] is null, automatically try to deduce what the [leading]
        /// widget should be. If [leading] widget is not null, this parameter has no effect.
        ///
        /// Specifically this navigation bar will:
        ///
        /// 1. Show a 'Close' button if the current route is a `fullscreenDialog`.
        /// 2. Show a back chevron with [previousPageTitle] if [previousPageTitle] is
        ///    not null.
        /// 3. Show a back chevron with the previous route's `title` if the current
        ///    route is a [CupertinoPageRoute] and the previous route is also a
        ///    [CupertinoPageRoute].
        ///
        /// This value cannot be null.
        /// {@endtemplate}
        /// </Summary>
        public virtual bool AutomaticallyImplyLeading { get; set; }
        /// <Summary>
        /// Controls whether we should try to imply the middle widget if null.
        ///
        /// If true and [middle] is null, automatically fill in a [Text] widget with
        /// the current route's `title` if the route is a [CupertinoPageRoute].
        /// If [middle] widget is not null, this parameter has no effect.
        ///
        /// This value cannot be null.
        /// </Summary>
        public virtual bool AutomaticallyImplyMiddle { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.previousPageTitle}
        /// Manually specify the previous route's title when automatically implying
        /// the leading back button.
        ///
        /// Overrides the text shown with the back chevron instead of automatically
        /// showing the previous [CupertinoPageRoute]'s `title` when
        /// [automaticallyImplyLeading] is true.
        ///
        /// Has no effect when [leading] is not null or if [automaticallyImplyLeading]
        /// is false.
        /// {@endtemplate}
        /// </Summary>
        public virtual string PreviousPageTitle { get; set; }
        /// <Summary>
        /// Widget to place in the middle of the navigation bar. Normally a title or
        /// a segmented control.
        ///
        /// If null and [automaticallyImplyMiddle] is true, an appropriate [Text]
        /// title will be created if the current route is a [CupertinoPageRoute] and
        /// has a `title`.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Middle { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.trailing}
        /// Widget to place at the end of the navigation bar. Normally additional actions
        /// taken on the page such as a search or edit function.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Trailing { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.backgroundColor}
        /// The background color of the navigation bar. If it contains transparency, the
        /// tab bar will automatically produce a blurring effect to the content
        /// behind it.
        ///
        /// Defaults to [CupertinoTheme]'s `barBackgroundColor` if null.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.brightness}
        /// The brightness of the specified [backgroundColor].
        ///
        /// Setting this value changes the style of the system status bar. Typically
        /// used to increase the contrast ratio of the system status bar over
        /// [backgroundColor].
        ///
        /// If set to null, the value of the property will be inferred from the relative
        /// luminance of [backgroundColor].
        /// {@endtemplate}
        /// </Summary>
        public virtual Brightness Brightness { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.padding}
        /// Padding for the contents of the navigation bar.
        ///
        /// If null, the navigation bar will adopt the following defaults:
        ///
        ///  * Vertically, contents will be sized to the same height as the navigation
        ///    bar itself minus the status bar.
        ///  * Horizontally, padding will be 16 pixels according to iOS specifications
        ///    unless the leading widget is an automatically inserted back button, in
        ///    which case the padding will be 0.
        ///
        /// Vertical padding won't change the height of the nav bar.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Padding { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.border}
        /// The border of the navigation bar. By default renders a single pixel bottom border side.
        ///
        /// If a border is null, the navigation bar will not display a border.
        /// {@endtemplate}
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxborder.Border Border { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.actionsForegroundColor}
        /// Default color used for text and icons of the [leading] and [trailing]
        /// widgets in the navigation bar.
        ///
        /// Defaults to the `primaryColor` of the [CupertinoTheme] when null.
        /// {@endtemplate}
        ///
        /// The default color for text in the [middle] slot is always black, as per
        /// iOS standard design.
        /// </Summary>
        public virtual FlutterBinding.UI.Color ActionsForegroundColor { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.transitionBetweenRoutes}
        /// Whether to transition between navigation bars.
        ///
        /// When [transitionBetweenRoutes] is true, this navigation bar will transition
        /// on top of the routes instead of inside it if the route being transitioned
        /// to also has a [CupertinoNavigationBar] or a [CupertinoSliverNavigationBar]
        /// with [transitionBetweenRoutes] set to true.
        ///
        /// This transition will also occur on edge back swipe gestures like on iOS
        /// but only if the previous page below has `maintainState` set to true on the
        /// [PageRoute].
        ///
        /// When set to true, only one navigation bar can be present per route unless
        /// [heroTag] is also set.
        ///
        /// This value defaults to true and cannot be null.
        /// {@endtemplate}
        /// </Summary>
        public virtual bool TransitionBetweenRoutes { get; set; }
        /// <Summary>
        /// {@template flutter.cupertino.navBar.heroTag}
        /// Tag for the navigation bar's Hero widget if [transitionBetweenRoutes] is true.
        ///
        /// Defaults to a common tag between all [CupertinoNavigationBar] and
        /// [CupertinoSliverNavigationBar] instances of the same [Navigator]. With the
        /// default tag, all navigation bars of the same navigator can transition
        /// between each other as long as there's only one navigation bar per route.
        ///
        /// This [heroTag] can be overridden to manually handle having multiple
        /// navigation bars per route or to transition between multiple
        /// [Navigator]s.
        ///
        /// Cannot be null. To disable Hero transitions for this navigation bar,
        /// set [transitionBetweenRoutes] to false.
        /// {@endtemplate}
        /// </Summary>
        public virtual @Object HeroTag { get; set; }
        public virtual Size PreferredSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// True if the navigation bar's background color has no transparency.
        /// </Summary>
        public new bool ShouldFullyObstruct(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Color backgroundColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(this.BackgroundColor, context) ?? ThemeDefaultClass.CupertinoTheme.Of(context).BarBackgroundColor;
            return backgroundColor.Alpha == 0xFF;
        }




        public new FlutterSDK.Cupertino.Navbar._CupertinoNavigationBarState CreateState()
        {
            return new _CupertinoNavigationBarState();
        }



    }


    public class _CupertinoNavigationBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Navbar.CupertinoNavigationBar>
    {
        public _CupertinoNavigationBarState()
        { }
        public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys Keys { get; set; }

        public new void InitState()
        {
            base.InitState();
            Keys = new _NavigationBarStaticComponentsKeys();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Color backgroundColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.BackgroundColor, context) ?? ThemeDefaultClass.CupertinoTheme.Of(context).BarBackgroundColor;
            _NavigationBarStaticComponents components = new _NavigationBarStaticComponents(keys: Keys, route: RoutesDefaultClass.ModalRoute.Of(context), userLeading: Widget.Leading, automaticallyImplyLeading: Widget.AutomaticallyImplyLeading, automaticallyImplyTitle: Widget.AutomaticallyImplyMiddle, previousPageTitle: Widget.PreviousPageTitle, userMiddle: Widget.Middle, userTrailing: Widget.Trailing, padding: Widget.Padding, userLargeTitle: null, large: false);
            Widget navBar = NavbarDefaultClass._WrapWithBackground(border: Widget.Border, backgroundColor: backgroundColor, brightness: Widget.Brightness, child: new DefaultTextStyle(style: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.TextStyle, child: new _PersistentNavigationBar(components: components, padding: Widget.Padding)));
            Color actionsForegroundColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.ActionsForegroundColor, context);
            if (!Widget.TransitionBetweenRoutes || !NavbarDefaultClass._IsTransitionable(context))
            {
                return NavbarDefaultClass._WrapActiveColor(actionsForegroundColor, context, navBar);
            }

            return NavbarDefaultClass._WrapActiveColor(actionsForegroundColor, context, new Builder(builder: (BuildContext context) =>
            {
                return new Hero(tag: Widget.HeroTag == NavbarDefaultClass._DefaultHeroTag ? new _HeroTag(NavigatorDefaultClass.Navigator.Of(context)) : Widget.HeroTag, createRectTween: NavbarDefaultClass._LinearTranslateWithLargestRectSizeTween, placeholderBuilder: NavbarDefaultClass._NavBarHeroLaunchPadBuilder, flightShuttleBuilder: NavbarDefaultClass._NavBarHeroFlightShuttleBuilder, transitionOnUserGestures: true, child: new _TransitionableNavigationBar(componentsKeys: Keys, backgroundColor: backgroundColor, backButtonTextStyle: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.NavActionTextStyle, titleTextStyle: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.NavTitleTextStyle, largeTitleTextStyle: null, border: Widget.Border, hasUserMiddle: Widget.Middle != null, largeExpanded: false, child: navBar));
            }
            ));
        }



    }


    /// <Summary>
    /// An iOS-styled navigation bar with iOS-11-style large titles using slivers.
    ///
    /// The [CupertinoSliverNavigationBar] must be placed in a sliver group such
    /// as the [CustomScrollView].
    ///
    /// This navigation bar consists of two sections, a pinned static section on top
    /// and a sliding section containing iOS-11-style large title below it.
    ///
    /// It should be placed at top of the screen and automatically accounts for
    /// the iOS status bar.
    ///
    /// Minimally, a [largeTitle] widget will appear in the middle of the app bar
    /// when the sliver is collapsed and transfer to the area below in larger font
    /// when the sliver is expanded.
    ///
    /// For advanced uses, an optional [middle] widget can be supplied to show a
    /// different widget in the middle of the navigation bar when the sliver is collapsed.
    ///
    /// Like [CupertinoNavigationBar], it also supports a [leading] and [trailing]
    /// widget on the static section on top that remains while scrolling.
    ///
    /// The [leading] widget will automatically be a back chevron icon button (or a
    /// close button in case of a fullscreen dialog) to pop the current route if none
    /// is provided and [automaticallyImplyLeading] is true (true by default).
    ///
    /// The [largeTitle] widget will automatically be a title text from the current
    /// [CupertinoPageRoute] if none is provided and [automaticallyImplyTitle] is
    /// true (true by default).
    ///
    /// When [transitionBetweenRoutes] is true, this navigation bar will transition
    /// on top of the routes instead of inside them if the route being transitioned
    /// to also has a [CupertinoNavigationBar] or a [CupertinoSliverNavigationBar]
    /// with [transitionBetweenRoutes] set to true. If [transitionBetweenRoutes] is
    /// true, none of the [Widget] parameters can contain any [GlobalKey]s in their
    /// subtrees since those widgets will exist in multiple places in the tree
    /// simultaneously.
    ///
    /// By default, only one [CupertinoNavigationBar] or [CupertinoSliverNavigationBar]
    /// should be present in each [PageRoute] to support the default transitions.
    /// Use [transitionBetweenRoutes] or [heroTag] to customize the transition
    /// behavior for multiple navigation bars per route.
    ///
    /// `CupertinoSliverNavigationBar` has its text scale factor set to 1.0 by default
    /// and does not respond to text scale factor changes from the operating system,
    /// to match the native iOS behavior. To override this behavior, wrap each of the
    /// `CupertinoSliverNavigationBar`'s components inside a [MediaQuery] with the
    /// desired [MediaQueryData.textScaleFactor] value. The text scale factor value
    /// from the operating system can be retrieved in many ways, such as querying
    /// [MediaQuery.textScaleFactorOf] against [CupertinoApp]'s [BuildContext].
    ///
    /// See also:
    ///
    ///  * [CupertinoNavigationBar], an iOS navigation bar for use on non-scrolling
    ///    pages.
    /// </Summary>
    public class CupertinoSliverNavigationBar : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a navigation bar for scrolling lists.
        ///
        /// The [largeTitle] argument is required and must not be null.
        /// </Summary>
        public CupertinoSliverNavigationBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget largeTitle = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), bool automaticallyImplyLeading = true, bool automaticallyImplyTitle = true, string previousPageTitle = default(string), FlutterSDK.Widgets.Framework.Widget middle = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget trailing = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional), FlutterBinding.UI.Color actionsForegroundColor = default(FlutterBinding.UI.Color), bool transitionBetweenRoutes = true, @Object heroTag = default(@Object))
        : base(key: key)
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
            this.HeroTag = heroTag;
        }
        /// <Summary>
        /// The navigation bar's title.
        ///
        /// This text will appear in the top static navigation bar when collapsed and
        /// below the navigation bar, in a larger font, when expanded.
        ///
        /// A suitable [DefaultTextStyle] is provided around this widget as it is
        /// moved around, to change its font size.
        ///
        /// If [middle] is null, then the [largeTitle] widget will be inserted into
        /// the tree in two places when transitioning from the collapsed state to the
        /// expanded state. It is therefore imperative that this subtree not contain
        /// any [GlobalKey]s, and that it not rely on maintaining state (for example,
        /// animations will not survive the transition from one location to the other,
        /// and may in fact be visible in two places at once during the transition).
        ///
        /// If null and [automaticallyImplyTitle] is true, an appropriate [Text]
        /// title will be created if the current route is a [CupertinoPageRoute] and
        /// has a `title`.
        ///
        /// This parameter must either be non-null or the route must have a title
        /// ([CupertinoPageRoute.title]) and [automaticallyImplyTitle] must be true.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget LargeTitle { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.leading}
        ///
        /// This widget is visible in both collapsed and expanded states.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Leading { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.automaticallyImplyLeading}
        /// </Summary>
        public virtual bool AutomaticallyImplyLeading { get; set; }
        /// <Summary>
        /// Controls whether we should try to imply the [largeTitle] widget if null.
        ///
        /// If true and [largeTitle] is null, automatically fill in a [Text] widget
        /// with the current route's `title` if the route is a [CupertinoPageRoute].
        /// If [largeTitle] widget is not null, this parameter has no effect.
        ///
        /// This value cannot be null.
        /// </Summary>
        public virtual bool AutomaticallyImplyTitle { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.previousPageTitle}
        /// </Summary>
        public virtual string PreviousPageTitle { get; set; }
        /// <Summary>
        /// A widget to place in the middle of the static navigation bar instead of
        /// the [largeTitle].
        ///
        /// This widget is visible in both collapsed and expanded states. The text
        /// supplied in [largeTitle] will no longer appear in collapsed state if a
        /// [middle] widget is provided.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Middle { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.trailing}
        ///
        /// This widget is visible in both collapsed and expanded states.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Trailing { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.backgroundColor}
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.brightness}
        /// </Summary>
        public virtual Brightness Brightness { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.padding}
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Padding { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.border}
        /// </Summary>
        public virtual FlutterSDK.Painting.Boxborder.Border Border { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.actionsForegroundColor}
        ///
        /// The default color for text in the [largeTitle] slot is always black, as per
        /// iOS standard design.
        /// </Summary>
        public virtual FlutterBinding.UI.Color ActionsForegroundColor { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.transitionBetweenRoutes}
        /// </Summary>
        public virtual bool TransitionBetweenRoutes { get; set; }
        /// <Summary>
        /// {@macro flutter.cupertino.navBar.heroTag}
        /// </Summary>
        public virtual @Object HeroTag { get; set; }
        public virtual bool Opaque { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Cupertino.Navbar._CupertinoSliverNavigationBarState CreateState() => new _CupertinoSliverNavigationBarState();


    }


    public class _CupertinoSliverNavigationBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Navbar.CupertinoSliverNavigationBar>
    {
        public _CupertinoSliverNavigationBarState()
        { }
        public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys Keys { get; set; }

        public new void InitState()
        {
            base.InitState();
            Keys = new _NavigationBarStaticComponentsKeys();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Color actionsForegroundColor = ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.ActionsForegroundColor, context) ?? ThemeDefaultClass.CupertinoTheme.Of(context).PrimaryColor;
            _NavigationBarStaticComponents components = new _NavigationBarStaticComponents(keys: Keys, route: RoutesDefaultClass.ModalRoute.Of(context), userLeading: Widget.Leading, automaticallyImplyLeading: Widget.AutomaticallyImplyLeading, automaticallyImplyTitle: Widget.AutomaticallyImplyTitle, previousPageTitle: Widget.PreviousPageTitle, userMiddle: Widget.Middle, userTrailing: Widget.Trailing, userLargeTitle: Widget.LargeTitle, padding: Widget.Padding, large: true);
            return NavbarDefaultClass._WrapActiveColor(actionsForegroundColor, context, new MediaQuery(data: MediaqueryDefaultClass.MediaQuery.Of(context).CopyWith(textScaleFactor: 1), child: new SliverPersistentHeader(pinned: true, @delegate: new _LargeTitleNavigationBarSliverDelegate(keys: Keys, components: components, userMiddle: Widget.Middle, backgroundColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.BackgroundColor, context) ?? ThemeDefaultClass.CupertinoTheme.Of(context).BarBackgroundColor, brightness: Widget.Brightness, border: Widget.Border, padding: Widget.Padding, actionsForegroundColor: actionsForegroundColor, transitionBetweenRoutes: Widget.TransitionBetweenRoutes, heroTag: Widget.HeroTag, persistentHeight: NavbarDefaultClass._KNavBarPersistentHeight + MediaqueryDefaultClass.MediaQuery.Of(context).Padding.Top, alwaysShowMiddle: Widget.Middle != null))));
        }



    }


    public class _LargeTitleNavigationBarSliverDelegate : FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate, IDiagnosticableTreeMixin
    {
        public _LargeTitleNavigationBarSliverDelegate(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys keys = default(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys), FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents components = default(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents), FlutterSDK.Widgets.Framework.Widget userMiddle = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness), FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border), FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional), FlutterBinding.UI.Color actionsForegroundColor = default(FlutterBinding.UI.Color), bool transitionBetweenRoutes = default(bool), @Object heroTag = default(@Object), double persistentHeight = default(double), bool alwaysShowMiddle = default(bool))
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
            this.AlwaysShowMiddle = alwaysShowMiddle;
        }
        public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys Keys { get; set; }
        public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents Components { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget UserMiddle { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual Brightness Brightness { get; set; }
        public virtual FlutterSDK.Painting.Boxborder.Border Border { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Padding { get; set; }
        public virtual FlutterBinding.UI.Color ActionsForegroundColor { get; set; }
        public virtual bool TransitionBetweenRoutes { get; set; }
        public virtual @Object HeroTag { get; set; }
        public virtual double PersistentHeight { get; set; }
        public virtual bool AlwaysShowMiddle { get; set; }
        public virtual double MinExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double MaxExtent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context, double shrinkOffset, bool overlapsContent)
        {
            bool showLargeTitle = shrinkOffset < MaxExtent - MinExtent - NavbarDefaultClass._KNavBarShowLargeTitleThreshold;
            _PersistentNavigationBar persistentNavigationBar = new _PersistentNavigationBar(components: Components, padding: Padding, middleVisible: AlwaysShowMiddle ? null : !showLargeTitle);
            Widget navBar = NavbarDefaultClass._WrapWithBackground(border: Border, backgroundColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(BackgroundColor, context), brightness: Brightness, child: new DefaultTextStyle(style: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.TextStyle, child: new Stack(fit: StackFit.Expand, children: new List<Widget>() { new Positioned(top: PersistentHeight, left: 0.0, right: 0.0, bottom: 0.0, child: new ClipRect(child: new OverflowBox(minHeight: 0.0, maxHeight: Dart.CoreDefaultClass.Double.Infinity, alignment: AlignmentDefaultClass.AlignmentDirectional.BottomStart, child: new Padding(padding: EdgeInsetsDirectional.Only(start: NavbarDefaultClass._KNavBarEdgePadding, bottom: 8.0), child: new SafeArea(top: false, bottom: false, child: new AnimatedOpacity(opacity: showLargeTitle ? 1.0 : 0.0, duration: NavbarDefaultClass._KNavBarTitleFadeDuration, child: new Semantics(header: true, child: new DefaultTextStyle(style: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.NavLargeTitleTextStyle, maxLines: 1, overflow: TextOverflow.Ellipsis, child: Components.LargeTitle)))))))), new Positioned(left: 0.0, right: 0.0, top: 0.0, child: persistentNavigationBar) })));
            if (!TransitionBetweenRoutes || !NavbarDefaultClass._IsTransitionable(context))
            {
                return navBar;
            }

            return new Hero(tag: HeroTag == NavbarDefaultClass._DefaultHeroTag ? new _HeroTag(NavigatorDefaultClass.Navigator.Of(context)) : HeroTag, createRectTween: NavbarDefaultClass._LinearTranslateWithLargestRectSizeTween, flightShuttleBuilder: NavbarDefaultClass._NavBarHeroFlightShuttleBuilder, placeholderBuilder: NavbarDefaultClass._NavBarHeroLaunchPadBuilder, transitionOnUserGestures: true, child: new _TransitionableNavigationBar(componentsKeys: Keys, backgroundColor: ColorsDefaultClass.CupertinoDynamicColor.Resolve(BackgroundColor, context), backButtonTextStyle: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.NavActionTextStyle, titleTextStyle: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.NavTitleTextStyle, largeTitleTextStyle: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.NavLargeTitleTextStyle, border: Border, hasUserMiddle: UserMiddle != null, largeExpanded: showLargeTitle, child: navBar));
        }




        public new bool ShouldRebuild(FlutterSDK.Cupertino.Navbar._LargeTitleNavigationBarSliverDelegate oldDelegate)
        {
            return Components != oldDelegate.Components || UserMiddle != oldDelegate.UserMiddle || BackgroundColor != oldDelegate.BackgroundColor || Border != oldDelegate.Border || Padding != oldDelegate.Padding || ActionsForegroundColor != oldDelegate.ActionsForegroundColor || TransitionBetweenRoutes != oldDelegate.TransitionBetweenRoutes || PersistentHeight != oldDelegate.PersistentHeight || AlwaysShowMiddle != oldDelegate.AlwaysShowMiddle || HeroTag != oldDelegate.HeroTag;
        }


        public new bool ShouldRebuild(FlutterSDK.Widgets.Sliverpersistentheader.SliverPersistentHeaderDelegate oldDelegate)
        {
            return Components != oldDelegate.Components || UserMiddle != oldDelegate.UserMiddle || BackgroundColor != oldDelegate.BackgroundColor || Border != oldDelegate.Border || Padding != oldDelegate.Padding || ActionsForegroundColor != oldDelegate.ActionsForegroundColor || TransitionBetweenRoutes != oldDelegate.TransitionBetweenRoutes || PersistentHeight != oldDelegate.PersistentHeight || AlwaysShowMiddle != oldDelegate.AlwaysShowMiddle || HeroTag != oldDelegate.HeroTag;
        }



    }


    /// <Summary>
    /// The top part of the navigation bar that's never scrolled away.
    ///
    /// Consists of the entire navigation bar without background and border when used
    /// without large titles. With large titles, it's the top static half that
    /// doesn't scroll.
    /// </Summary>
    public class _PersistentNavigationBar : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _PersistentNavigationBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents components = default(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents), FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional), bool middleVisible = default(bool))
        : base(key: key)
        {
            this.Components = components;
            this.Padding = padding;
            this.MiddleVisible = middleVisible;
        }
        public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponents Components { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional Padding { get; set; }
        /// <Summary>
        /// Whether the middle widget has a visible animated opacity. A null value
        /// means the middle opacity will not be animated.
        /// </Summary>
        public virtual bool MiddleVisible { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Widget middle = Components.Middle;
            if (middle != null)
            {
                middle = new DefaultTextStyle(style: ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.NavTitleTextStyle, child: new Semantics(header: true, child: middle));
                middle = MiddleVisible == null ? middle : new AnimatedOpacity(opacity: MiddleVisible ? 1.0 : 0.0, duration: NavbarDefaultClass._KNavBarTitleFadeDuration, child: middle);
            }

            Widget leading = Components.Leading;
            Widget backChevron = Components.BackChevron;
            Widget backLabel = Components.BackLabel;
            if (leading == null && backChevron != null && backLabel != null)
            {
                leading = CupertinoNavigationBarBackButton._Assemble(backChevron, backLabel);
            }

            Widget paddedToolbar = new NavigationToolbar(leading: leading, middle: middle, trailing: Components.Trailing, centerMiddle: true, middleSpacing: 6.0);
            if (Padding != null)
            {
                paddedToolbar = new Padding(padding: EdgeInsets.Only(top: Padding.Top, bottom: Padding.Bottom), child: paddedToolbar);
            }

            return new SizedBox(height: NavbarDefaultClass._KNavBarPersistentHeight + MediaqueryDefaultClass.MediaQuery.Of(context).Padding.Top, child: new SafeArea(bottom: false, child: paddedToolbar));
        }



    }


    public class _NavigationBarStaticComponentsKeys
    {
        public _NavigationBarStaticComponentsKeys()
        : base()
        {

        }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> NavBarBoxKey { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> LeadingKey { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> BackChevronKey { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> BackLabelKey { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> MiddleKey { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> TrailingKey { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> LargeTitleKey { get; set; }
    }


    public class _NavigationBarStaticComponents
    {
        public _NavigationBarStaticComponents(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys keys = default(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys), FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>), FlutterSDK.Widgets.Framework.Widget userLeading = default(FlutterSDK.Widgets.Framework.Widget), bool automaticallyImplyLeading = default(bool), bool automaticallyImplyTitle = default(bool), string previousPageTitle = default(string), FlutterSDK.Widgets.Framework.Widget userMiddle = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget userTrailing = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget userLargeTitle = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional), bool large = default(bool))
        : base()
        {

        }
        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree Leading { get; set; }
        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree BackChevron { get; set; }
        /// <Summary>
        /// This widget is not decorated with a font since the font style could
        /// animate during transitions.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree BackLabel { get; set; }
        /// <Summary>
        /// This widget is not decorated with a font since the font style could
        /// animate during transitions.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree Middle { get; set; }
        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree Trailing { get; set; }
        /// <Summary>
        /// This widget is not decorated with a font since the font style could
        /// animate during transitions.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree LargeTitle { get; set; }

        private FlutterSDK.Widgets.Framework.Widget _DerivedTitle(bool automaticallyImplyTitle = default(bool), FlutterSDK.Widgets.Routes.ModalRoute<object> currentRoute = default(FlutterSDK.Widgets.Routes.ModalRoute<object>))
        {
            if (automaticallyImplyTitle && currentRoute is CupertinoPageRoute && currentRoute.Title != null)
            {
                return new Text(((CupertinoPageRoute)currentRoute).Title);
            }

            return null;
        }




        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateLeading(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> leadingKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Widgets.Framework.Widget userLeading = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>), bool automaticallyImplyLeading = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional))
        {
            Widget leadingContent = default(Widget);
            if (userLeading != null)
            {
                leadingContent = userLeading;
            }
            else if (automaticallyImplyLeading && route is PageRoute && route.CanPop && route.FullscreenDialog)
            {
                leadingContent = new CupertinoButton(child: new Text("Close"), padding: EdgeinsetsDefaultClass.EdgeInsets.Zero, onPressed: () =>
                {
                    ((PageRoute)route).Navigator.MaybePop();
                }
                );
            }

            if (leadingContent == null)
            {
                return null;
            }

            return new KeyedSubtree(key: leadingKey, child: new Padding(padding: EdgeInsetsDirectional.Only(start: padding?.Start ?? NavbarDefaultClass._KNavBarEdgePadding), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(size: 32.0), child: leadingContent)));
        }




        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateBackChevron(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> backChevronKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Widgets.Framework.Widget userLeading = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>), bool automaticallyImplyLeading = default(bool))
        {
            if (userLeading != null || !automaticallyImplyLeading || route == null || !route.CanPop || (route is PageRoute && route.FullscreenDialog))
            {
                return null;
            }

            return new KeyedSubtree(key: backChevronKey, child: new _BackChevron());
        }




        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateBackLabel(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> backLabelKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Widgets.Framework.Widget userLeading = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>), bool automaticallyImplyLeading = default(bool), string previousPageTitle = default(string))
        {
            if (userLeading != null || !automaticallyImplyLeading || route == null || !route.CanPop || (route is PageRoute && route.FullscreenDialog))
            {
                return null;
            }

            return new KeyedSubtree(key: backLabelKey, child: new _BackLabel(specifiedPreviousTitle: previousPageTitle, route: route));
        }




        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateMiddle(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> middleKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Widgets.Framework.Widget userMiddle = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget userLargeTitle = default(FlutterSDK.Widgets.Framework.Widget), bool large = default(bool), bool automaticallyImplyTitle = default(bool), FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>))
        {
            Widget middleContent = userMiddle;
            if (large)
            {
                middleContent = (middleContent == null ? userLargeTitle : middleContent);
            }

            middleContent = (middleContent == null ? _DerivedTitle(automaticallyImplyTitle: automaticallyImplyTitle, currentRoute: route) : middleContent);
            if (middleContent == null)
            {
                return null;
            }

            return new KeyedSubtree(key: middleKey, child: middleContent);
        }




        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateTrailing(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> trailingKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Widgets.Framework.Widget userTrailing = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsDirectional))
        {
            if (userTrailing == null)
            {
                return null;
            }

            return new KeyedSubtree(key: trailingKey, child: new Padding(padding: EdgeInsetsDirectional.Only(end: padding?.End ?? NavbarDefaultClass._KNavBarEdgePadding), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(size: 32.0), child: userTrailing)));
        }




        public virtual FlutterSDK.Widgets.Basic.KeyedSubtree CreateLargeTitle(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> largeTitleKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Widgets.Framework.Widget userLargeTitle = default(FlutterSDK.Widgets.Framework.Widget), bool large = default(bool), bool automaticImplyTitle = default(bool), FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>))
        {
            if (!large)
            {
                return null;
            }

            Widget largeTitleContent = userLargeTitle ?? _DerivedTitle(automaticallyImplyTitle: automaticImplyTitle, currentRoute: route);

            return new KeyedSubtree(key: largeTitleKey, child: largeTitleContent);
        }



    }


    /// <Summary>
    /// A nav bar back button typically used in [CupertinoNavigationBar].
    ///
    /// This is automatically inserted into [CupertinoNavigationBar] and
    /// [CupertinoSliverNavigationBar]'s `leading` slot when
    /// `automaticallyImplyLeading` is true.
    ///
    /// When manually inserted, the [CupertinoNavigationBarBackButton] should only
    /// be used in routes that can be popped unless a custom [onPressed] is
    /// provided.
    ///
    /// Shows a back chevron and the previous route's title when available from
    /// the previous [CupertinoPageRoute.title]. If [previousPageTitle] is specified,
    /// it will be shown instead.
    /// </Summary>
    public class CupertinoNavigationBarBackButton : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Construct a [CupertinoNavigationBarBackButton] that can be used to pop
        /// the current route.
        ///
        /// The [color] parameter must not be null.
        /// </Summary>
        public CupertinoNavigationBarBackButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), string previousPageTitle = default(string), VoidCallback onPressed = default(VoidCallback))
        : base(key: key)
        {
            this.Color = color;
            this.PreviousPageTitle = previousPageTitle;
            this.OnPressed = onPressed;
        }
        internal static CupertinoNavigationBarBackButton _Assemble(FlutterSDK.Widgets.Framework.Widget _backChevron, FlutterSDK.Widgets.Framework.Widget _backLabel)
        {
            var instance = new CupertinoNavigationBarBackButton(); instance._BackChevron = _backChevron;
            instance._BackLabel = _backLabel;
        }
        /// <Summary>
        /// The [Color] of the back button.
        ///
        /// Can be used to override the color of the back button chevron and label.
        ///
        /// Defaults to [CupertinoTheme]'s `primaryColor` if null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// An override for showing the previous route's title. If null, it will be
        /// automatically derived from [CupertinoPageRoute.title] if the current and
        /// previous routes are both [CupertinoPageRoute]s.
        /// </Summary>
        public virtual string PreviousPageTitle { get; set; }
        /// <Summary>
        /// An override callback to perform instead of the default behavior which is
        /// to pop the [Navigator].
        ///
        /// It can, for instance, be used to pop the platform's navigation stack
        /// via [SystemNavigator] instead of Flutter's [Navigator] in add-to-app
        /// situations.
        ///
        /// Defaults to null.
        /// </Summary>
        public virtual VoidCallback OnPressed { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _BackChevron { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _BackLabel { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ModalRoute<object> currentRoute = RoutesDefaultClass.ModalRoute.Of(context);
            if (OnPressed == null)
            {

            }

            TextStyle actionTextStyle = ThemeDefaultClass.CupertinoTheme.Of(context).TextTheme.NavActionTextStyle;
            if (Color != null)
            {
                actionTextStyle = actionTextStyle.CopyWith(color: ColorsDefaultClass.CupertinoDynamicColor.Resolve(Color, context));
            }

            return new CupertinoButton(child: new Semantics(container: true, excludeSemantics: true, label: "Back", button: true, child: new DefaultTextStyle(style: actionTextStyle, child: new ConstrainedBox(constraints: new BoxConstraints(minWidth: NavbarDefaultClass._KNavBarBackButtonTapWidth), child: new Row(mainAxisSize: MainAxisSize.Min, mainAxisAlignment: MainAxisAlignment.Start, children: new List<Widget>() { new Padding(padding: EdgeInsetsDirectional.Only(start: 8.0)), _BackChevron ?? new _BackChevron(), new Padding(padding: EdgeInsetsDirectional.Only(start: 6.0)), new Flexible(child: _BackLabel ?? new _BackLabel(specifiedPreviousTitle: PreviousPageTitle, route: currentRoute)) })))), padding: EdgeinsetsDefaultClass.EdgeInsets.Zero, onPressed: () =>
            {
                if (OnPressed != null)
                {
                    OnPressed();
                }
                else
                {
                    NavigatorDefaultClass.Navigator.MaybePop(context);
                }

            }
            );
        }



    }


    public class _BackChevron : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _BackChevron(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key)
        {

        }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            TextDirection textDirection = BasicDefaultClass.Directionality.Of(context);
            TextStyle textStyle = TextDefaultClass.DefaultTextStyle.Of(context).Style;
            Widget iconWidget = Text.Rich(new TextSpan(text: string.FromCharCode(IconsDefaultClass.CupertinoIcons.Back.CodePoint), style: new TextStyle(inherit: false, color: textStyle.Color, fontSize: 34.0, fontFamily: IconsDefaultClass.CupertinoIcons.Back.FontFamily, package: IconsDefaultClass.CupertinoIcons.Back.FontPackage)));
            switch (textDirection)
            {
                case TextDirection.Rtl:
                    iconWidget = new Transform(transform: Matrix4.Identity();
                    Matrix4.Identity().Scale(-1.0, 1.0, 1.0), alignment: AlignmentDefaultClass.Alignment.Center, transformHitTests: false , child: iconWidget); break;
                case TextDirection.Ltr: break;
            }
            return iconWidget;
        }



    }


    /// <Summary>
    /// A widget that shows next to the back chevron when `automaticallyImplyLeading`
    /// is true.
    /// </Summary>
    public class _BackLabel : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _BackLabel(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string specifiedPreviousTitle = default(string), FlutterSDK.Widgets.Routes.ModalRoute<object> route = default(FlutterSDK.Widgets.Routes.ModalRoute<object>))
        : base(key: key)
        {
            this.SpecifiedPreviousTitle = specifiedPreviousTitle;
            this.Route = route;
        }
        public virtual string SpecifiedPreviousTitle { get; set; }
        public virtual FlutterSDK.Widgets.Routes.ModalRoute<object> Route { get; set; }

        private FlutterSDK.Widgets.Framework.Widget _BuildPreviousTitleWidget(FlutterSDK.Widgets.Framework.BuildContext context, string previousTitle, FlutterSDK.Widgets.Framework.Widget child)
        {
            if (previousTitle == null)
            {
                return new SizedBox(height: 0.0, width: 0.0);
            }

            Text textWidget = new Text(previousTitle, maxLines: 1, overflow: TextOverflow.Ellipsis);
            if (previousTitle.Length > 12)
            {
                textWidget = new Text("Back");
            }

            return new Align(alignment: AlignmentDefaultClass.AlignmentDirectional.CenterStart, widthFactor: 1.0, child: textWidget);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (SpecifiedPreviousTitle != null)
            {
                return _BuildPreviousTitleWidget(context, SpecifiedPreviousTitle, null);
            }
            else if (Route is CupertinoPageRoute<object> && !Route.IsFirst)
            {
                CupertinoPageRoute<object> cupertinoRoute = ((CupertinoPageRoute<dynamic>)Route) as CupertinoPageRoute<object>;
                return new ValueListenableBuilder<string>(valueListenable: cupertinoRoute.PreviousTitle, builder: _BuildPreviousTitleWidget);
            }
            else
            {
                return new SizedBox(height: 0.0, width: 0.0);
            }

        }



    }


    /// <Summary>
    /// This should always be the first child of Hero widgets.
    ///
    /// This class helps each Hero transition obtain the start or end navigation
    /// bar's box size and the inner components of the navigation bar that will
    /// move around.
    ///
    /// It should be wrapped around the biggest [RenderBox] of the static
    /// navigation bar in each route.
    /// </Summary>
    public class _TransitionableNavigationBar : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _TransitionableNavigationBar(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys componentsKeys = default(FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle backButtonTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle titleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle largeTitleTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Boxborder.Border border = default(FlutterSDK.Painting.Boxborder.Border), bool hasUserMiddle = default(bool), bool largeExpanded = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: componentsKeys.NavBarBoxKey)
        {
            this.ComponentsKeys = componentsKeys;
            this.BackgroundColor = backgroundColor;
            this.BackButtonTextStyle = backButtonTextStyle;
            this.TitleTextStyle = titleTextStyle;
            this.LargeTitleTextStyle = largeTitleTextStyle;
            this.Border = border;
            this.HasUserMiddle = hasUserMiddle;
            this.LargeExpanded = largeExpanded;
            this.Child = child;
        }
        public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys ComponentsKeys { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle BackButtonTextStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TitleTextStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LargeTitleTextStyle { get; set; }
        public virtual FlutterSDK.Painting.Boxborder.Border Border { get; set; }
        public virtual bool HasUserMiddle { get; set; }
        public virtual bool LargeExpanded { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Rendering.Box.RenderBox RenderBox { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            return Child;
        }



    }


    /// <Summary>
    /// This class represents the widget that will be in the Hero flight instead of
    /// the 2 static navigation bars by taking inner components from both.
    ///
    /// The `topNavBar` parameter is the nav bar that was on top regardless of
    /// push/pop direction.
    ///
    /// Similarly, the `bottomNavBar` parameter is the nav bar that was at the
    /// bottom regardless of the push/pop direction.
    ///
    /// If [MediaQuery.padding] is still present in this widget's [BuildContext],
    /// that padding will become part of the transitional navigation bar as well.
    ///
    /// [MediaQuery.padding] should be consistent between the from/to routes and
    /// the Hero overlay. Inconsistent [MediaQuery.padding] will produce undetermined
    /// results.
    /// </Summary>
    public class _NavigationBarTransition : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _NavigationBarTransition(FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar topNavBar = default(FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar), FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar bottomNavBar = default(FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar))
        : base()
        {
            this.Animation = animation;
            this.TopNavBar = topNavBar;
            this.BottomNavBar = bottomNavBar;
        }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
        public virtual FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar TopNavBar { get; set; }
        public virtual FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar BottomNavBar { get; set; }
        public virtual FlutterSDK.Animation.Tween.Tween<double> HeightTween { get; set; }
        public virtual FlutterSDK.Animation.Tween.ColorTween BackgroundTween { get; set; }
        public virtual FlutterSDK.Widgets.Implicitanimations.BorderTween BorderTween { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _NavigationBarComponentsTransition componentsTransition = new _NavigationBarComponentsTransition(animation: Animation, bottomNavBar: BottomNavBar, topNavBar: TopNavBar, directionality: BasicDefaultClass.Directionality.Of(context));
            List<Widget> children = new List<Widget>(){new AnimatedBuilder(animation:Animation, builder:(BuildContext context, Widget child) => {
return NavbarDefaultClass._WrapWithBackground(updateSystemUiOverlay:false , backgroundColor:BackgroundTween.Evaluate(Animation), border:BorderTween.Evaluate(Animation), child:new SizedBox(height:HeightTween.Evaluate(Animation), width:Dart.CoreDefaultClass.Double.Infinity));
}
), componentsTransition.BottomBackChevron, componentsTransition.BottomBackLabel, componentsTransition.BottomLeading, componentsTransition.BottomMiddle, componentsTransition.BottomLargeTitle, componentsTransition.BottomTrailing, componentsTransition.TopLeading, componentsTransition.TopBackChevron, componentsTransition.TopBackLabel, componentsTransition.TopMiddle, componentsTransition.TopLargeTitle, componentsTransition.TopTrailing};
            children.RemoveWhere((Widget child) => =>child == null);
            return new SizedBox(height: Dart.Math.MathDefaultClass.Max(HeightTween.Begin, HeightTween.End) + MediaqueryDefaultClass.MediaQuery.Of(context).Padding.Top, width: Dart.CoreDefaultClass.Double.Infinity, child: new Stack(children: children));
        }



    }


    /// <Summary>
    /// This class helps create widgets that are in transition based on static
    /// components from the bottom and top navigation bars.
    ///
    /// It animates these transitional components both in terms of position and
    /// their appearance.
    ///
    /// Instead of running the transitional components through their normal static
    /// navigation bar layout logic, this creates transitional widgets that are based
    /// on these widgets' existing render objects' layout and position.
    ///
    /// This is possible because this widget is only used during Hero transitions
    /// where both the from and to routes are already built and laid out.
    ///
    /// The components' existing layout constraints and positions are then
    /// replicated using [Positioned] or [PositionedTransition] wrappers.
    ///
    /// This class should never return [KeyedSubtree]s created by
    /// _NavigationBarStaticComponents directly. Since widgets from
    /// _NavigationBarStaticComponents are still present in the widget tree during the
    /// hero transitions, it would cause global key duplications. Instead, return
    /// only the [KeyedSubtree]s' child.
    /// </Summary>
    public class _NavigationBarComponentsTransition
    {
        public _NavigationBarComponentsTransition(FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar bottomNavBar = default(FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar), FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar topNavBar = default(FlutterSDK.Cupertino.Navbar._TransitionableNavigationBar), TextDirection directionality = default(TextDirection))
        : base()
        {
            this.Animation = animation;
        }
        public virtual FlutterSDK.Animation.Tween.Animatable<double> FadeOut { get; set; }
        public virtual FlutterSDK.Animation.Tween.Animatable<double> FadeIn { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
        public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys BottomComponents { get; set; }
        public virtual FlutterSDK.Cupertino.Navbar._NavigationBarStaticComponentsKeys TopComponents { get; set; }
        public virtual FlutterSDK.Rendering.Box.RenderBox BottomNavBarBox { get; set; }
        public virtual FlutterSDK.Rendering.Box.RenderBox TopNavBarBox { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle BottomBackButtonTextStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TopBackButtonTextStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle BottomTitleTextStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TopTitleTextStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle BottomLargeTitleTextStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TopLargeTitleTextStyle { get; set; }
        public virtual bool BottomHasUserMiddle { get; set; }
        public virtual bool TopHasUserMiddle { get; set; }
        public virtual bool BottomLargeExpanded { get; set; }
        public virtual bool TopLargeExpanded { get; set; }
        public virtual FlutterBinding.UI.Rect TransitionBox { get; set; }
        public virtual double ForwardDirection { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget BottomLeading { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget BottomBackChevron { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget BottomBackLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget BottomMiddle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget BottomLargeTitle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget BottomTrailing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget TopLeading { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget TopBackChevron { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget TopBackLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget TopMiddle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget TopTrailing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget TopLargeTitle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public virtual FlutterSDK.Rendering.Stack.RelativeRect PositionInTransitionBox(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> key, FlutterSDK.Rendering.Box.RenderBox from = default(FlutterSDK.Rendering.Box.RenderBox))
        {
            RenderBox componentBox = key.CurrentContext.FindRenderObject() as RenderBox;

            return RelativeRect.FromRect(componentBox.LocalToGlobal(Dart.UI.UiDefaultClass.Offset.Zero, ancestor: from) & componentBox.Size, TransitionBox);
        }




        public virtual FlutterSDK.Widgets.Transitions.RelativeRectTween SlideFromLeadingEdge(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> fromKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Rendering.Box.RenderBox fromNavBarBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> toKey = default(FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>), FlutterSDK.Rendering.Box.RenderBox toNavBarBox = default(FlutterSDK.Rendering.Box.RenderBox))
        {
            RelativeRect fromRect = PositionInTransitionBox(fromKey, from: fromNavBarBox);
            RenderBox fromBox = fromKey.CurrentContext.FindRenderObject() as RenderBox;
            RenderBox toBox = toKey.CurrentContext.FindRenderObject() as RenderBox;
            Rect toRect = toBox.LocalToGlobal(Dart.UI.UiDefaultClass.Offset.Zero, ancestor: toNavBarBox).Translate(0.0, -fromBox.Size.Height / 2 + toBox.Size.Height / 2) & fromBox.Size;
            if (ForwardDirection < 0)
            {
                toRect = toRect.Translate(-fromBox.Size.Width + toBox.Size.Width, 0.0);
            }

            return new RelativeRectTween(begin: fromRect, end: RelativeRect.FromRect(toRect, TransitionBox));
        }




        public virtual FlutterSDK.Animation.Animation.Animation<double> FadeInFrom(double t, FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {
            return Animation.Drive(FadeIn.Chain(new CurveTween(curve: new Interval(t, 1.0, curve: curve))));
        }




        public virtual FlutterSDK.Animation.Animation.Animation<double> FadeOutBy(double t, FlutterSDK.Animation.Curves.Curve curve = default(FlutterSDK.Animation.Curves.Curve))
        {
            return Animation.Drive(FadeOut.Chain(new CurveTween(curve: new Interval(0.0, t, curve: curve))));
        }



    }

}
