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
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
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
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
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
namespace FlutterSDK.Material.Colorscheme
{
    internal static class ColorschemeDefaultClass
    {
    }

    /// <Summary>
    /// A set of twelve colors based on the
    /// [Material spec](https://material.io/design/color/the-color-system.html)
    /// that can be used to configure the color properties of most components.
    ///
    /// The [Theme] has a color scheme, [ThemeData.colorScheme], which is constructed
    /// with [ColorScheme.fromSwatch].
    /// </Summary>
    public class ColorScheme : IDiagnosticable
    {
        /// <Summary>
        /// Create a ColorScheme instance.
        /// </Summary>
        public ColorScheme(FlutterBinding.UI.Color primary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryVariant = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondaryVariant = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color surface = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color background = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color error = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onPrimary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onSecondary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onSurface = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onBackground = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onError = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness))
        : base()
        {
            this.Primary = primary;
            this.PrimaryVariant = primaryVariant;
            this.Secondary = secondary;
            this.SecondaryVariant = secondaryVariant;
            this.Surface = surface;
            this.Background = background;
            this.Error = error;
            this.OnPrimary = onPrimary;
            this.OnSecondary = onSecondary;
            this.OnSurface = onSurface;
            this.OnBackground = onBackground;
            this.OnError = onError;
            this.Brightness = brightness;
        }
        /// <Summary>
        /// Create a ColorScheme based on a purple primary color that matches the
        /// [baseline Material color scheme](https://material.io/design/color/the-color-system.html#color-theme-creation).
        /// </Summary>
        public static ColorScheme Light(FlutterBinding.UI.Color primary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryVariant = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondaryVariant = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color surface = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color background = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color error = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onPrimary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onSecondary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onSurface = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onBackground = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onError = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness))
        {
            var instance = new ColorScheme(); instance.Primary = primary;
            instance.PrimaryVariant = primaryVariant;
            instance.Secondary = secondary;
            instance.SecondaryVariant = secondaryVariant;
            instance.Surface = surface;
            instance.Background = background;
            instance.Error = error;
            instance.OnPrimary = onPrimary;
            instance.OnSecondary = onSecondary;
            instance.OnSurface = onSurface;
            instance.OnBackground = onBackground;
            instance.OnError = onError;
            instance.Brightness = brightness;
        }
        /// <Summary>
        /// Create the recommended dark color scheme that matches the
        /// [baseline Material color scheme](https://material.io/design/color/dark-theme.html#ui-application).
        /// </Summary>
        public static ColorScheme Dark(FlutterBinding.UI.Color primary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryVariant = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondaryVariant = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color surface = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color background = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color error = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onPrimary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onSecondary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onSurface = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onBackground = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onError = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness))
        {
            var instance = new ColorScheme(); instance.Primary = primary;
            instance.PrimaryVariant = primaryVariant;
            instance.Secondary = secondary;
            instance.SecondaryVariant = secondaryVariant;
            instance.Surface = surface;
            instance.Background = background;
            instance.Error = error;
            instance.OnPrimary = onPrimary;
            instance.OnSecondary = onSecondary;
            instance.OnSurface = onSurface;
            instance.OnBackground = onBackground;
            instance.OnError = onError;
            instance.Brightness = brightness;
        }
        /// <Summary>
        /// Create a color scheme from a [MaterialColor] swatch.
        ///
        /// This constructor is used by [ThemeData] to create its default
        /// color scheme.
        /// </Summary>
        public static ColorScheme FromSwatch(FlutterSDK.Material.Colors.MaterialColor primarySwatch = default(FlutterSDK.Material.Colors.MaterialColor), FlutterBinding.UI.Color primaryColorDark = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color accentColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color cardColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color errorColor = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness))
        {
            var instance = new ColorScheme();


            bool isDark = brightness == Brightness.Dark;
            bool primaryIsDark = _BrightnessFor(primarySwatch) == Brightness.Dark;
            Color secondary = accentColor ?? (isDark ? ColorsDefaultClass.Colors.TealAccent[200] : primarySwatch);
            bool secondaryIsDark = _BrightnessFor(secondary) == Brightness.Dark;
            return new ColorScheme(primary: primarySwatch, primaryVariant: primaryColorDark ?? (isDark ? ColorsDefaultClass.Colors.Black : primarySwatch[700]), secondary: secondary, secondaryVariant: isDark ? ColorsDefaultClass.Colors.TealAccent[700] : primarySwatch[700], surface: cardColor ?? (isDark ? ColorsDefaultClass.Colors.Grey[800] : ColorsDefaultClass.Colors.White), background: backgroundColor ?? (isDark ? ColorsDefaultClass.Colors.Grey[700] : primarySwatch[200]), error: errorColor ?? ColorsDefaultClass.Colors.Red[700], onPrimary: primaryIsDark ? ColorsDefaultClass.Colors.White : ColorsDefaultClass.Colors.Black, onSecondary: secondaryIsDark ? ColorsDefaultClass.Colors.White : ColorsDefaultClass.Colors.Black, onSurface: isDark ? ColorsDefaultClass.Colors.White : ColorsDefaultClass.Colors.Black, onBackground: primaryIsDark ? ColorsDefaultClass.Colors.White : ColorsDefaultClass.Colors.Black, onError: isDark ? ColorsDefaultClass.Colors.Black : ColorsDefaultClass.Colors.White, brightness: brightness);
        }


        /// <Summary>
        /// The color displayed most frequently across your app’s screens and components.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Primary { get; set; }
        /// <Summary>
        /// A darker version of the primary color.
        /// </Summary>
        public virtual FlutterBinding.UI.Color PrimaryVariant { get; set; }
        /// <Summary>
        /// An accent color that, when used sparingly, calls attention to parts
        /// of your app.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Secondary { get; set; }
        /// <Summary>
        /// A darker version of the secondary color.
        /// </Summary>
        public virtual FlutterBinding.UI.Color SecondaryVariant { get; set; }
        /// <Summary>
        /// The background color for widgets like [Card].
        /// </Summary>
        public virtual FlutterBinding.UI.Color Surface { get; set; }
        /// <Summary>
        /// A color that typically appears behind scrollable content.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Background { get; set; }
        /// <Summary>
        /// The color to use for input validation errors, e.g. for
        /// [InputDecoration.errorText].
        /// </Summary>
        public virtual FlutterBinding.UI.Color Error { get; set; }
        /// <Summary>
        /// A color that's clearly legible when drawn on [primary].
        ///
        /// To ensure that an app is accessible, a contrast ratio of 4.5:1 for [primary]
        /// and [onPrimary] is recommended. See
        /// <https://www.w3.org/TR/UNDERSTANDING-WCAG20/visual-audio-contrast-contrast.html>.
        /// </Summary>
        public virtual FlutterBinding.UI.Color OnPrimary { get; set; }
        /// <Summary>
        /// A color that's clearly legible when drawn on [secondary].
        ///
        /// To ensure that an app is accessible, a contrast ratio of 4.5:1 for [secondary]
        /// and [onSecondary] is recommended. See
        /// <https://www.w3.org/TR/UNDERSTANDING-WCAG20/visual-audio-contrast-contrast.html>.
        /// </Summary>
        public virtual FlutterBinding.UI.Color OnSecondary { get; set; }
        /// <Summary>
        /// A color that's clearly legible when drawn on [surface].
        ///
        /// To ensure that an app is accessible, a contrast ratio of 4.5:1 for [surface]
        /// and [onSurface] is recommended. See
        /// <https://www.w3.org/TR/UNDERSTANDING-WCAG20/visual-audio-contrast-contrast.html>.
        /// </Summary>
        public virtual FlutterBinding.UI.Color OnSurface { get; set; }
        /// <Summary>
        /// A color that's clearly legible when drawn on [background].
        ///
        /// To ensure that an app is accessible, a contrast ratio of 4.5:1 for [background]
        /// and [onBackground] is recommended. See
        /// <https://www.w3.org/TR/UNDERSTANDING-WCAG20/visual-audio-contrast-contrast.html>.
        /// </Summary>
        public virtual FlutterBinding.UI.Color OnBackground { get; set; }
        /// <Summary>
        /// A color that's clearly legible when drawn on [error].
        ///
        /// To ensure that an app is accessible, a contrast ratio of 4.5:1 for [error]
        /// and [onError] is recommended. See
        /// <https://www.w3.org/TR/UNDERSTANDING-WCAG20/visual-audio-contrast-contrast.html>.
        /// </Summary>
        public virtual FlutterBinding.UI.Color OnError { get; set; }
        /// <Summary>
        /// The overall brightness of this color scheme.
        /// </Summary>
        public virtual Brightness Brightness { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private Brightness _BrightnessFor(FlutterBinding.UI.Color color) => ThemedataDefaultClass.ThemeData.EstimateBrightnessForColor(color);



        /// <Summary>
        /// Creates a copy of this color scheme with the given fields
        /// replaced by the non-null parameter values.
        /// </Summary>
        public virtual FlutterSDK.Material.Colorscheme.ColorScheme CopyWith(FlutterBinding.UI.Color primary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color primaryVariant = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondaryVariant = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color surface = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color background = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color error = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onPrimary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onSecondary = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onSurface = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onBackground = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color onError = default(FlutterBinding.UI.Color), Brightness brightness = default(Brightness))
        {
            return new ColorScheme(primary: primary ?? this.Primary, primaryVariant: primaryVariant ?? this.PrimaryVariant, secondary: secondary ?? this.Secondary, secondaryVariant: secondaryVariant ?? this.SecondaryVariant, surface: surface ?? this.Surface, background: background ?? this.Background, error: error ?? this.Error, onPrimary: onPrimary ?? this.OnPrimary, onSecondary: onSecondary ?? this.OnSecondary, onSurface: onSurface ?? this.OnSurface, onBackground: onBackground ?? this.OnBackground, onError: onError ?? this.OnError, brightness: brightness ?? this.Brightness);
        }




        /// <Summary>
        /// Linearly interpolate between two [ColorScheme] objects.
        ///
        /// {@macro flutter.material.themeData.lerp}
        /// </Summary>
        public virtual FlutterSDK.Material.Colorscheme.ColorScheme Lerp(FlutterSDK.Material.Colorscheme.ColorScheme a, FlutterSDK.Material.Colorscheme.ColorScheme b, double t)
        {
            return new ColorScheme(primary: Dart.UI.UiDefaultClass.Color.Lerp(a.Primary, b.Primary, t), primaryVariant: Dart.UI.UiDefaultClass.Color.Lerp(a.PrimaryVariant, b.PrimaryVariant, t), secondary: Dart.UI.UiDefaultClass.Color.Lerp(a.Secondary, b.Secondary, t), secondaryVariant: Dart.UI.UiDefaultClass.Color.Lerp(a.SecondaryVariant, b.SecondaryVariant, t), surface: Dart.UI.UiDefaultClass.Color.Lerp(a.Surface, b.Surface, t), background: Dart.UI.UiDefaultClass.Color.Lerp(a.Background, b.Background, t), error: Dart.UI.UiDefaultClass.Color.Lerp(a.Error, b.Error, t), onPrimary: Dart.UI.UiDefaultClass.Color.Lerp(a.OnPrimary, b.OnPrimary, t), onSecondary: Dart.UI.UiDefaultClass.Color.Lerp(a.OnSecondary, b.OnSecondary, t), onSurface: Dart.UI.UiDefaultClass.Color.Lerp(a.OnSurface, b.OnSurface, t), onBackground: Dart.UI.UiDefaultClass.Color.Lerp(a.OnBackground, b.OnBackground, t), onError: Dart.UI.UiDefaultClass.Color.Lerp(a.OnError, b.OnError, t), brightness: t < 0.5 ? a.Brightness : b.Brightness);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is ColorScheme && other.Primary == Primary && other.PrimaryVariant == PrimaryVariant && other.Secondary == Secondary && other.SecondaryVariant == SecondaryVariant && other.Surface == Surface && other.Background == Background && other.Error == Error && other.OnPrimary == OnPrimary && other.OnSecondary == OnSecondary && other.OnSurface == OnSurface && other.OnBackground == OnBackground && other.OnError == OnError && other.Brightness == Brightness;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            ColorScheme defaultScheme = ColorScheme.Light();
            properties.Add(new ColorProperty("primary", Primary, defaultValue: defaultScheme.Primary));
            properties.Add(new ColorProperty("primaryVariant", PrimaryVariant, defaultValue: defaultScheme.PrimaryVariant));
            properties.Add(new ColorProperty("secondary", Secondary, defaultValue: defaultScheme.Secondary));
            properties.Add(new ColorProperty("secondaryVariant", SecondaryVariant, defaultValue: defaultScheme.SecondaryVariant));
            properties.Add(new ColorProperty("surface", Surface, defaultValue: defaultScheme.Surface));
            properties.Add(new ColorProperty("background", Background, defaultValue: defaultScheme.Background));
            properties.Add(new ColorProperty("error", Error, defaultValue: defaultScheme.Error));
            properties.Add(new ColorProperty("onPrimary", OnPrimary, defaultValue: defaultScheme.OnPrimary));
            properties.Add(new ColorProperty("onSecondary", OnSecondary, defaultValue: defaultScheme.OnSecondary));
            properties.Add(new ColorProperty("onSurface", OnSurface, defaultValue: defaultScheme.OnSurface));
            properties.Add(new ColorProperty("onBackground", OnBackground, defaultValue: defaultScheme.OnBackground));
            properties.Add(new ColorProperty("onError", OnError, defaultValue: defaultScheme.OnError));
            properties.Add(new DiagnosticsProperty<Brightness>("brightness", Brightness, defaultValue: defaultScheme.Brightness));
        }



    }

}
