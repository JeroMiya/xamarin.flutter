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
using FlutterSDK.Foundation;
namespace FlutterSDK.Cupertino.Theme
{
    internal static class ThemeDefaultClass
    {
        public static FlutterSDK.Cupertino.Theme._CupertinoThemeDefaults _KDefaultTheme = default(FlutterSDK.Cupertino.Theme._CupertinoThemeDefaults);
    }

    /// <Summary>
    /// Applies a visual styling theme to descendant Cupertino widgets.
    ///
    /// Affects the color and text styles of Cupertino widgets whose styling
    /// are not overridden when constructing the respective widgets instances.
    ///
    /// Descendant widgets can retrieve the current [CupertinoThemeData] by calling
    /// [CupertinoTheme.of]. An [InheritedWidget] dependency is created when
    /// an ancestor [CupertinoThemeData] is retrieved via [CupertinoTheme.of].
    ///
    /// The [CupertinoTheme] widget implies an [IconTheme] widget, whose
    /// [IconTheme.data] has the same color as [CupertinoThemeData.primaryColor]
    ///
    /// See also:
    ///
    ///  * [CupertinoThemeData], specifies the theme's visual styling.
    ///  * [CupertinoApp], which will automatically add a [CupertinoTheme] based on the
    ///    value of [CupertinoApp.theme].
    ///  * [Theme], a Material theme which will automatically add a [CupertinoTheme]
    ///    with a [CupertinoThemeData] derived from the Material [ThemeData].
    /// </Summary>
    public class CupertinoTheme : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a [CupertinoTheme] to change descendant Cupertino widgets' styling.
        ///
        /// The [data] and [child] parameters must not be null.
        /// </Summary>
        public CupertinoTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Cupertino.Theme.CupertinoThemeData data = default(FlutterSDK.Cupertino.Theme.CupertinoThemeData), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Data = data;
            this.Child = child;
        }
        /// <Summary>
        /// The [CupertinoThemeData] styling for this theme.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData Data { get; set; }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// {@macro flutter.widgets.child}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        /// <Summary>
        /// Retrieves the [CupertinoThemeData] from the closest ancestor [CupertinoTheme]
        /// widget, or a default [CupertinoThemeData] if no [CupertinoTheme] ancestor
        /// exists.
        ///
        /// Resolves all the colors defined in that [CupertinoThemeData] against the
        /// given [BuildContext] on a best-effort basis.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _InheritedCupertinoTheme inheritedTheme = context.DependOnInheritedWidgetOfExactType();
            return (inheritedTheme?.Theme?.Data ?? new CupertinoThemeData()).ResolveFrom(context, nullOk: true);
        }




        /// <Summary>
        /// Retrieves the [Brightness] to use for descendant Cupertino widgets, based
        /// on the value of [CupertinoThemeData.brightness] in the given [context].
        ///
        /// If no [CupertinoTheme] can be found in the given [context], or its `brightness`
        /// is null, it will fall back to [MediaQueryData.brightness].
        ///
        /// Throws an exception if no valid [CupertinoTheme] or [MediaQuery] widgets
        /// exist in the ancestry tree, unless [nullOk] is set to true.
        ///
        /// See also:
        ///
        /// * [CupertinoThemeData.brightness], the property takes precedence over
        ///   [MediaQueryData.platformBrightness] for descendant Cupertino widgets.
        /// </Summary>
        public virtual Brightness BrightnessOf(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
        {
            _InheritedCupertinoTheme inheritedTheme = context.DependOnInheritedWidgetOfExactType();
            return inheritedTheme?.Theme?.Data?.Brightness ?? MediaqueryDefaultClass.MediaQuery.Of(context, nullOk: nullOk)?.PlatformBrightness;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _InheritedCupertinoTheme(theme: this, child: new IconTheme(data: new CupertinoIconThemeData(color: Data.PrimaryColor), child: Child));
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            Data.DebugFillProperties(properties);
        }



    }


    public class _InheritedCupertinoTheme : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        public _InheritedCupertinoTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Cupertino.Theme.CupertinoTheme theme = default(FlutterSDK.Cupertino.Theme.CupertinoTheme), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Theme = theme;
        }
        public virtual FlutterSDK.Cupertino.Theme.CupertinoTheme Theme { get; set; }

        public new bool UpdateShouldNotify(FlutterSDK.Cupertino.Theme._InheritedCupertinoTheme old) => Theme.Data != old.Theme.Data;

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => Theme.Data != old.Theme.Data;


    }


    /// <Summary>
    /// Styling specifications for a [CupertinoTheme].
    ///
    /// All constructor parameters can be null, in which case a
    /// [CupertinoColors.activeBlue] based default iOS theme styling is used.
    ///
    /// Parameters can also be partially specified, in which case some parameters
    /// will cascade down to other dependent parameters to create a cohesive
    /// visual effect. For instance, if a [primaryColor] is specified, it would
    /// cascade down to affect some fonts in [textTheme] if [textTheme] is not
    /// specified.
    ///
    /// See also:
    ///
    ///  * [CupertinoTheme], in which this [CupertinoThemeData] is inserted.
    ///  * [ThemeData], a Material equivalent that also configures Cupertino
    ///    styling via a [CupertinoThemeData] subclass [MaterialBasedCupertinoThemeData].
    /// </Summary>
    public class CupertinoThemeData : IDiagnosticable
    {
        /// <Summary>
        /// Creates a [CupertinoTheme] styling specification.
        ///
        /// Unspecified parameters default to a reasonable iOS default style.
        /// </Summary>
        public CupertinoThemeData(Brightness brightness = default(Brightness), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryContrastingColor = default(FlutterBinding.UI.Color), FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme = default(FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData), FlutterBinding.UI.Color barBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color))
        : base()
        {

        }
        /// <Summary>
        /// Same as the default constructor but with positional arguments to avoid
        /// forgetting any and to specify all arguments.
        ///
        /// Used by subclasses to get the superclass's defaulting behaviors.
        /// </Summary>
        public static CupertinoThemeData Raw(Brightness brightness, FlutterBinding.UI.Color primaryColor, FlutterBinding.UI.Color primaryContrastingColor, FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme, FlutterBinding.UI.Color barBackgroundColor, FlutterBinding.UI.Color scaffoldBackgroundColor)
        {
            var instance = new CupertinoThemeData();
        }
        internal static CupertinoThemeData _RawWithDefaults(Brightness brightness, FlutterBinding.UI.Color _primaryColor, FlutterBinding.UI.Color _primaryContrastingColor, FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData _textTheme, FlutterBinding.UI.Color _barBackgroundColor, FlutterBinding.UI.Color _scaffoldBackgroundColor, FlutterSDK.Cupertino.Theme._CupertinoThemeDefaults _defaults)
        {
            var instance = new CupertinoThemeData(); instance.Brightness = brightness;
            instance._PrimaryColor = _primaryColor;
            instance._PrimaryContrastingColor = _primaryContrastingColor;
            instance._TextTheme = _textTheme;
            instance._BarBackgroundColor = _barBackgroundColor;
            instance._ScaffoldBackgroundColor = _scaffoldBackgroundColor;
            instance._Defaults = _defaults;
        }
        internal virtual FlutterSDK.Cupertino.Theme._CupertinoThemeDefaults _Defaults { get; set; }
        /// <Summary>
        /// The brightness override for Cupertino descendants.
        ///
        /// Defaults to null. If a non-null [Brightness] is specified, the value will
        /// take precedence over the ambient [MediaQueryData.platformBrightness], when
        /// determining the brightness of descendant Cupertino widgets.
        ///
        /// If coming from a Material [Theme] and unspecified, [brightness] will be
        /// derived from the Material [ThemeData]'s `brightness`.
        ///
        /// See also:
        ///
        ///  * [MaterialBasedCupertinoThemeData], a [CupertinoThemeData] that defers
        ///    [brightness] to its Material [Theme] parent if it's unspecified.
        ///
        ///  * [CupertinoTheme.brightnessOf], a method used to retrieve the overall
        ///    [Brightness] from a [BuildContext], for Cupertino widgets.
        /// </Summary>
        public virtual Brightness Brightness { get; set; }
        internal virtual FlutterBinding.UI.Color _PrimaryColor { get; set; }
        internal virtual FlutterBinding.UI.Color _PrimaryContrastingColor { get; set; }
        internal virtual FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData _TextTheme { get; set; }
        internal virtual FlutterBinding.UI.Color _BarBackgroundColor { get; set; }
        internal virtual FlutterBinding.UI.Color _ScaffoldBackgroundColor { get; set; }
        public virtual FlutterBinding.UI.Color PrimaryColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color PrimaryContrastingColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData TextTheme { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color BarBackgroundColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color ScaffoldBackgroundColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns an instance of the [CupertinoThemeData] whose property getters
        /// only return the construction time specifications with no derived values.
        ///
        /// Used in Material themes to let unspecified properties fallback to Material
        /// theme properties instead of iOS defaults.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData NoDefault()
        {
            return new _NoDefaultCupertinoThemeData(Brightness, _PrimaryColor, _PrimaryContrastingColor, _TextTheme, _BarBackgroundColor, _ScaffoldBackgroundColor);
        }




        /// <Summary>
        /// Returns a new `CupertinoThemeData` with all its colors resolved against the
        /// given [BuildContext].
        ///
        /// Called by [CupertinoTheme.of] to resolve colors defined in the retrieved
        /// [CupertinoThemeData].
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
        {
            Color ConvertColor(Color color) => ColorsDefaultClass.CupertinoDynamicColor.Resolve(color, context, nullOk: nullOk);
            return CupertinoThemeData._RawWithDefaults(Brightness, ConvertColor(_PrimaryColor), ConvertColor(_PrimaryContrastingColor), _TextTheme?.ResolveFrom(context, nullOk: nullOk), ConvertColor(_BarBackgroundColor), ConvertColor(_ScaffoldBackgroundColor), _Defaults.ResolveFrom(context, _TextTheme == null, nullOk: nullOk));
        }




        /// <Summary>
        /// Creates a copy of [CupertinoThemeData] with specified attributes overridden.
        ///
        /// Only the current instance's specified attributes are copied instead of
        /// derived values. For instance, if the current [CupertinoThemeData.textTheme]
        /// is implied from the current [primaryColor] because it was not specified,
        /// copying with a different [primaryColor] will also change the copy's implied
        /// [textTheme].
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Theme.CupertinoThemeData CopyWith(Brightness brightness = default(Brightness), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryContrastingColor = default(FlutterBinding.UI.Color), FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme = default(FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData), FlutterBinding.UI.Color barBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color))
        {
            return CupertinoThemeData._RawWithDefaults(brightness ?? this.Brightness, primaryColor ?? _PrimaryColor, primaryContrastingColor ?? _PrimaryContrastingColor, textTheme ?? _TextTheme, barBackgroundColor ?? _BarBackgroundColor, scaffoldBackgroundColor ?? _ScaffoldBackgroundColor, _Defaults);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            CupertinoThemeData defaultData = new CupertinoThemeData();
            properties.Add(new EnumProperty<Brightness>("brightness", Brightness, defaultValue: null));
            properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("primaryColor", PrimaryColor, defaultValue: defaultData.PrimaryColor));
            properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("primaryContrastingColor", PrimaryContrastingColor, defaultValue: defaultData.PrimaryContrastingColor));
            properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("barBackgroundColor", BarBackgroundColor, defaultValue: defaultData.BarBackgroundColor));
            properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("scaffoldBackgroundColor", ScaffoldBackgroundColor, defaultValue: defaultData.ScaffoldBackgroundColor));
            TextTheme.DebugFillProperties(properties);
        }



    }


    public class _NoDefaultCupertinoThemeData : FlutterSDK.Cupertino.Theme.CupertinoThemeData
    {
        public _NoDefaultCupertinoThemeData(Brightness brightness, FlutterBinding.UI.Color primaryColor, FlutterBinding.UI.Color primaryContrastingColor, FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme, FlutterBinding.UI.Color barBackgroundColor, FlutterBinding.UI.Color scaffoldBackgroundColor)
        : base(brightness, primaryColor, primaryContrastingColor, textTheme, barBackgroundColor, scaffoldBackgroundColor, null)
        {
            this.PrimaryColor = primaryColor;
            this.PrimaryContrastingColor = primaryContrastingColor;
            this.TextTheme = textTheme;
            this.BarBackgroundColor = barBackgroundColor;
            this.ScaffoldBackgroundColor = scaffoldBackgroundColor;
        }
        public new FlutterBinding.UI.Color PrimaryColor { get; set; }
        public new FlutterBinding.UI.Color PrimaryContrastingColor { get; set; }
        public new FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData TextTheme { get; set; }
        public new FlutterBinding.UI.Color BarBackgroundColor { get; set; }
        public new FlutterBinding.UI.Color ScaffoldBackgroundColor { get; set; }

        public new FlutterSDK.Cupertino.Theme._NoDefaultCupertinoThemeData ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false)
        {
            Color ConvertColor(Color color) => ColorsDefaultClass.CupertinoDynamicColor.Resolve(color, context, nullOk: nullOk);
            return new _NoDefaultCupertinoThemeData(Brightness, ConvertColor(PrimaryColor), ConvertColor(PrimaryContrastingColor), TextTheme?.ResolveFrom(context, nullOk: nullOk), ConvertColor(BarBackgroundColor), ConvertColor(ScaffoldBackgroundColor));
        }




        public new FlutterSDK.Cupertino.Theme.CupertinoThemeData CopyWith(Brightness brightness = default(Brightness), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryContrastingColor = default(FlutterBinding.UI.Color), FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData textTheme = default(FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData), FlutterBinding.UI.Color barBackgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color scaffoldBackgroundColor = default(FlutterBinding.UI.Color))
        {
            return new _NoDefaultCupertinoThemeData(brightness ?? this.Brightness, primaryColor ?? this.PrimaryColor, primaryContrastingColor ?? this.PrimaryContrastingColor, textTheme ?? this.TextTheme, barBackgroundColor ?? this.BarBackgroundColor, scaffoldBackgroundColor ?? this.ScaffoldBackgroundColor);
        }



    }


    public class _CupertinoThemeDefaults
    {
        public _CupertinoThemeDefaults(Brightness brightness, FlutterBinding.UI.Color primaryColor, FlutterBinding.UI.Color primaryContrastingColor, FlutterBinding.UI.Color barBackgroundColor, FlutterBinding.UI.Color scaffoldBackgroundColor, FlutterSDK.Cupertino.Theme._CupertinoTextThemeDefaults textThemeDefaults)
        {
            this.Brightness = brightness;
            this.PrimaryColor = primaryColor;
            this.PrimaryContrastingColor = primaryContrastingColor;
            this.BarBackgroundColor = barBackgroundColor;
            this.ScaffoldBackgroundColor = scaffoldBackgroundColor;
            this.TextThemeDefaults = textThemeDefaults;
        }
        public virtual Brightness Brightness { get; set; }
        public virtual FlutterBinding.UI.Color PrimaryColor { get; set; }
        public virtual FlutterBinding.UI.Color PrimaryContrastingColor { get; set; }
        public virtual FlutterBinding.UI.Color BarBackgroundColor { get; set; }
        public virtual FlutterBinding.UI.Color ScaffoldBackgroundColor { get; set; }
        public virtual FlutterSDK.Cupertino.Theme._CupertinoTextThemeDefaults TextThemeDefaults { get; set; }

        public virtual FlutterSDK.Cupertino.Theme._CupertinoThemeDefaults ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context, bool resolveTextTheme, bool nullOk = default(bool))
        {

            Color ConvertColor(Color color) => ColorsDefaultClass.CupertinoDynamicColor.Resolve(color, context, nullOk: nullOk);
            return new _CupertinoThemeDefaults(Brightness, ConvertColor(PrimaryColor), ConvertColor(PrimaryContrastingColor), ConvertColor(BarBackgroundColor), ConvertColor(ScaffoldBackgroundColor), resolveTextTheme ? TextThemeDefaults?.ResolveFrom(context, nullOk: nullOk) : TextThemeDefaults);
        }



    }


    public class _CupertinoTextThemeDefaults
    {
        public _CupertinoTextThemeDefaults(FlutterBinding.UI.Color labelColor, FlutterBinding.UI.Color inactiveGray)
        {
            this.LabelColor = labelColor;
            this.InactiveGray = inactiveGray;
        }
        public virtual FlutterBinding.UI.Color LabelColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveGray { get; set; }

        public virtual FlutterSDK.Cupertino.Theme._CupertinoTextThemeDefaults ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = default(bool))
        {
            return new _CupertinoTextThemeDefaults(ColorsDefaultClass.CupertinoDynamicColor.Resolve(LabelColor, context, nullOk: nullOk), ColorsDefaultClass.CupertinoDynamicColor.Resolve(InactiveGray, context, nullOk: nullOk));
        }




        public virtual FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData CreateDefaults(FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color))
        {

            return new _DefaultCupertinoTextThemeData(primaryColor: primaryColor, labelColor: LabelColor, inactiveGray: InactiveGray);
        }



    }


    public class _DefaultCupertinoTextThemeData : FlutterSDK.Cupertino.Texttheme.CupertinoTextThemeData
    {
        public _DefaultCupertinoTextThemeData(FlutterBinding.UI.Color labelColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveGray = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color))
        : base(primaryColor: primaryColor)
        {
            this.LabelColor = labelColor;
            this.InactiveGray = inactiveGray;
        }
        public virtual FlutterBinding.UI.Color LabelColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveGray { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TabLabelTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle NavTitleTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle NavLargeTitleTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle PickerTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle DateTimePickerTextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }

}
