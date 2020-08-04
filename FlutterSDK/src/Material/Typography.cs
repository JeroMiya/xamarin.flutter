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
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
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
using FlutterSDK.Scheduler;
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
namespace FlutterSDK.Material.Typography
{
    internal static class TypographyDefaultClass
    {
    }

    /// <Summary>
    /// The color and geometry [TextThemes] for Material apps.
    ///
    /// The text themes provided by the overall [Theme], like
    /// [ThemeData.textTheme], are based on the current locale's
    /// [MaterialLocalizations.scriptCategory] and are created
    /// by merging a color text theme, [black] or [white]
    /// and a geometry text theme, one of [englishLike], [dense],
    /// or [tall], depending on the locale.
    ///
    /// To lookup a localized text theme use
    /// `Theme.of(context).textTheme` or
    /// `Theme.of(context).primaryTextTheme` or
    /// `Theme.of(context).accentTextTheme`.
    ///
    /// The color text themes are [blackMountainView], [whiteMountainView],
    /// [blackCupertino], and [whiteCupertino]. The Mountain View theme [TextStyles]
    /// are based on the Roboto fonts as used on Android. The Cupertino themes are
    /// based on the [San Francisco
    /// font](https://developer.apple.com/ios/human-interface-guidelines/visual-design/typography/)
    /// fonts as used by Apple on iOS.
    ///
    /// Two sets of geometry themes are provided: 2014 and 2018. The 2014 themes
    /// correspond to the original version of the Material Design spec and are
    /// the defaults. The 2018 themes correspond the second iteration of the
    /// specification and feature different font sizes, font weights, and
    /// letter spacing values.
    ///
    /// By default, [ThemeData.typography] is `Typography.material2014(platform:
    /// platform)` which uses [englishLike2014], [dense2014] and [tall2014]. To use
    /// the 2018 text theme geometries, specify a value using the [material2018]
    /// constructor:
    ///
    /// ```dart
    /// typography: Typography.material2018(platform: platform)
    /// ```
    ///
    /// See also:
    ///
    ///  * [ThemeData.typography], which can be used to configure the
    ///    text themes used to create [ThemeData.textTheme],
    ///    [ThemeData.primaryTextTheme], [ThemeData.accentTextTheme].
    ///  * <https://material.io/design/typography/>
    /// </Summary>
    public class Typography : IDiagnosticable
    {
        /// <Summary>
        /// Creates a typography instance.
        ///
        /// This constructor is identical to [Typography.material2014]. It is
        /// deprecated because the 2014 material design defaults used by that
        /// constructor are obsolete. The current material design specification
        /// recommendations are those reflected by [Typography.material2018].
        /// </Summary>
        public Typography(FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Material.Texttheme.TextTheme black = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme white = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme englishLike = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme dense = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme tall = default(FlutterSDK.Material.Texttheme.TextTheme))
        : base()
        {

        }
        /// <Summary>
        /// Creates a typography instance using material design's 2014 defaults.
        ///
        /// If [platform] is [TargetPlatform.iOS] or [TargetPlatform.macOS], the
        /// default values for [black] and [white] are [blackCupertino] and
        /// [whiteCupertino] respectively. Otherwise they are [blackMountainView] and
        /// [whiteMoutainView]. If [platform] is null then both [black] and [white]
        /// must be specified.
        ///
        /// The default values for [englishLike], [dense], and [tall] are
        /// [englishLike2014], [dense2014], and [tall2014].
        /// </Summary>
        public static Typography Material2014(FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Material.Texttheme.TextTheme black = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme white = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme englishLike = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme dense = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme tall = default(FlutterSDK.Material.Texttheme.TextTheme))
        {
            var instance = new Typography();

            return Typography._WithPlatform(platform, black, white, englishLike ?? EnglishLike2014, dense ?? Dense2014, tall ?? Tall2014);
        }


        /// <Summary>
        /// Creates a typography instance using material design's 2018 defaults.
        ///
        /// If [platform] is [TargetPlatform.iOS] or [TargetPlatform.macOS], the
        /// default values for [black] and [white] are [blackCupertino] and
        /// [whiteCupertino] respectively. Otherwise they are [blackMountainView] and
        /// [whiteMoutainView]. If [platform] is null then both [black] and [white]
        /// must be specified.
        ///
        /// The default values for [englishLike], [dense], and [tall] are
        /// [englishLike2018], [dense2018], and [tall2018].
        /// </Summary>
        public static Typography Material2018(FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform), FlutterSDK.Material.Texttheme.TextTheme black = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme white = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme englishLike = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme dense = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme tall = default(FlutterSDK.Material.Texttheme.TextTheme))
        {
            var instance = new Typography();

            return Typography._WithPlatform(platform, black, white, englishLike ?? EnglishLike2018, dense ?? Dense2018, tall ?? Tall2018);
        }


        internal static Typography _WithPlatform(FlutterSDK.Foundation.Platform.TargetPlatform platform, FlutterSDK.Material.Texttheme.TextTheme black, FlutterSDK.Material.Texttheme.TextTheme white, FlutterSDK.Material.Texttheme.TextTheme englishLike, FlutterSDK.Material.Texttheme.TextTheme dense, FlutterSDK.Material.Texttheme.TextTheme tall)
        {
            var instance = new Typography();




            switch (platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: black = (black == null ? BlackCupertino : black); white = (white == null ? WhiteCupertino : white); break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: black = (black == null ? BlackMountainView : black); white = (white == null ? WhiteMountainView : white); break; case TargetPlatform.Windows: black = (black == null ? BlackRedmond : black); white = (white == null ? WhiteRedmond : white); break; case TargetPlatform.Linux: black = (black == null ? BlackHelsinki : black); white = (white == null ? WhiteHelsinki : white); break; }
            return Typography._(black, white, englishLike, dense, tall);
        }


        internal Typography(FlutterSDK.Material.Texttheme.TextTheme black, FlutterSDK.Material.Texttheme.TextTheme white, FlutterSDK.Material.Texttheme.TextTheme englishLike, FlutterSDK.Material.Texttheme.TextTheme dense, FlutterSDK.Material.Texttheme.TextTheme tall)
        : base()
        {
            this.Black = black;
            this.White = white;
            this.EnglishLike = englishLike;
            this.Dense = dense;
            this.Tall = tall;
        }
        /// <Summary>
        /// A material design text theme with dark glyphs.
        ///
        /// This [TextTheme] should provide color but not geometry (font size,
        /// weight, etc). A text theme's geometry depends on the locale. To look
        /// up a localized [TextTheme], use the overall [Theme], for example:
        /// `Theme.of(context).textTheme`.
        ///
        /// The [englishLike], [dense], and [tall] text theme's provide locale-specific
        /// geometry.
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme Black { get; set; }
        /// <Summary>
        /// A material design text theme with light glyphs.
        ///
        /// This [TextTheme] provides color but not geometry (font size, weight, etc).
        /// A text theme's geometry depends on the locale. To look up a localized
        /// [TextTheme], use the overall [Theme], for example:
        /// `Theme.of(context).textTheme`.
        ///
        /// The [englishLike], [dense], and [tall] text theme's provide locale-specific
        /// geometry.
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme White { get; set; }
        /// <Summary>
        /// Defines text geometry for [ScriptCategory.englishLike] scripts, such as
        /// English, French, Russian, etc.
        ///
        /// This text theme is merged with either [black] or [white], depending
        /// on the overall [ThemeData.brightness], when the current locale's
        /// [MaterialLocalizations.scriptCategory] is [ScriptCategory.englishLike].
        ///
        /// To look up a localized [TextTheme], use the overall [Theme], for
        /// example: `Theme.of(context).textTheme`.
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme EnglishLike { get; set; }
        /// <Summary>
        /// Defines text geometry for dense scripts, such as Chinese, Japanese
        /// and Korean.
        ///
        /// This text theme is merged with either [black] or [white], depending
        /// on the overall [ThemeData.brightness], when the current locale's
        /// [MaterialLocalizations.scriptCategory] is [ScriptCategory.dense].
        ///
        /// To look up a localized [TextTheme], use the overall [Theme], for
        /// example: `Theme.of(context).textTheme`.
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme Dense { get; set; }
        /// <Summary>
        /// Defines text geometry for tall scripts, such as Farsi, Hindi, and Thai.
        ///
        /// This text theme is merged with either [black] or [white], depending
        /// on the overall [ThemeData.brightness], when the current locale's
        /// [MaterialLocalizations.scriptCategory] is [ScriptCategory.tall].
        ///
        /// To look up a localized [TextTheme], use the overall [Theme], for
        /// example: `Theme.of(context).textTheme`.
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme Tall { get; set; }
        /// <Summary>
        /// A material design text theme with dark glyphs based on Roboto.
        ///
        /// This [TextTheme] provides color but not geometry (font size, weight, etc).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme BlackMountainView { get; set; }
        /// <Summary>
        /// A material design text theme with light glyphs based on Roboto.
        ///
        /// This [TextTheme] provides color but not geometry (font size, weight, etc).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme WhiteMountainView { get; set; }
        /// <Summary>
        /// A material design text theme with dark glyphs based on Segoe UI.
        ///
        /// This [TextTheme] provides color but not geometry (font size, weight, etc).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme BlackRedmond { get; set; }
        /// <Summary>
        /// A material design text theme with light glyphs based on Segoe UI.
        ///
        /// This [TextTheme] provides color but not geometry (font size, weight, etc).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme WhiteRedmond { get; set; }
        internal virtual List<string> _HelsinkiFontFallbacks { get; set; }
        /// <Summary>
        /// A material design text theme with dark glyphs based on Roboto, with
        /// fallback fonts that are likely (but not guaranteed) to be installed on
        /// Linux.
        ///
        /// This [TextTheme] provides color but not geometry (font size, weight, etc).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme BlackHelsinki { get; set; }
        /// <Summary>
        /// A material design text theme with light glyphs based on Roboto, with fallbacks of DejaVu Sans, Liberation Sans and Arial.
        ///
        /// This [TextTheme] provides color but not geometry (font size, weight, etc).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme WhiteHelsinki { get; set; }
        /// <Summary>
        /// A material design text theme with dark glyphs based on San Francisco.
        ///
        /// This [TextTheme] provides color but not geometry (font size, weight, etc).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme BlackCupertino { get; set; }
        /// <Summary>
        /// A material design text theme with light glyphs based on San Francisco.
        ///
        /// This [TextTheme] provides color but not geometry (font size, weight, etc).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme WhiteCupertino { get; set; }
        /// <Summary>
        /// Defines text geometry for [ScriptCategory.englishLike] scripts, such as
        /// English, French, Russian, etc.
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme EnglishLike2014 { get; set; }
        /// <Summary>
        /// Defines text geometry for [ScriptCategory.englishLike] scripts, such as
        /// English, French, Russian, etc.
        ///
        /// The font sizes, weights, and letter spacings in this version match the
        /// [latest Material Design specification](https://material.io/go/design-typography#typography-styles).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme EnglishLike2018 { get; set; }
        /// <Summary>
        /// Defines text geometry for dense scripts, such as Chinese, Japanese
        /// and Korean.
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme Dense2014 { get; set; }
        /// <Summary>
        /// Defines text geometry for dense scripts, such as Chinese, Japanese
        /// and Korean.
        ///
        /// The font sizes, weights, and letter spacings in this version match the
        /// latest [Material Design specification](https://material.io/go/design-typography#typography-styles).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme Dense2018 { get; set; }
        /// <Summary>
        /// Defines text geometry for tall scripts, such as Farsi, Hindi, and Thai.
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme Tall2014 { get; set; }
        /// <Summary>
        /// Defines text geometry for tall scripts, such as Farsi, Hindi, and Thai.
        ///
        /// The font sizes, weights, and letter spacings in this version match the
        /// latest [Material Design specification](https://material.io/go/design-typography#typography-styles).
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme Tall2018 { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Returns one of [englishLike], [dense], or [tall].
        /// </Summary>
        public virtual FlutterSDK.Material.Texttheme.TextTheme GeometryThemeFor(FlutterSDK.Material.Typography.ScriptCategory category)
        {

            switch (category) { case ScriptCategory.EnglishLike: return EnglishLike; case ScriptCategory.Dense: return Dense; case ScriptCategory.Tall: return Tall; }
            return null;
        }




        /// <Summary>
        /// Creates a copy of this [Typography] with the given fields
        /// replaced by the non-null parameter values.
        /// </Summary>
        public virtual FlutterSDK.Material.Typography.Typography CopyWith(FlutterSDK.Material.Texttheme.TextTheme black = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme white = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme englishLike = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme dense = default(FlutterSDK.Material.Texttheme.TextTheme), FlutterSDK.Material.Texttheme.TextTheme tall = default(FlutterSDK.Material.Texttheme.TextTheme))
        {
            return Typography._(black ?? this.Black, white ?? this.White, englishLike ?? this.EnglishLike, dense ?? this.Dense, tall ?? this.Tall);
        }




        /// <Summary>
        /// Linearly interpolate between two [Typography] objects.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Material.Typography.Typography Lerp(FlutterSDK.Material.Typography.Typography a, FlutterSDK.Material.Typography.Typography b, double t)
        {
            return Typography._(TextthemeDefaultClass.TextTheme.Lerp(a.Black, b.Black, t), TextthemeDefaultClass.TextTheme.Lerp(a.White, b.White, t), TextthemeDefaultClass.TextTheme.Lerp(a.EnglishLike, b.EnglishLike, t), TextthemeDefaultClass.TextTheme.Lerp(a.Dense, b.Dense, t), TextthemeDefaultClass.TextTheme.Lerp(a.Tall, b.Tall, t));
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is Typography && other.Black == Black && other.White == White && other.EnglishLike == EnglishLike && other.Dense == Dense && other.Tall == Tall;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            Typography defaultTypography = Typography.Material2014();
            properties.Add(new DiagnosticsProperty<TextTheme>("black", Black, defaultValue: defaultTypography.Black));
            properties.Add(new DiagnosticsProperty<TextTheme>("white", White, defaultValue: defaultTypography.White));
            properties.Add(new DiagnosticsProperty<TextTheme>("englishLike", EnglishLike, defaultValue: defaultTypography.EnglishLike));
            properties.Add(new DiagnosticsProperty<TextTheme>("dense", Dense, defaultValue: defaultTypography.Dense));
            properties.Add(new DiagnosticsProperty<TextTheme>("tall", Tall, defaultValue: defaultTypography.Tall));
        }



    }


    /// <Summary>
    /// A characterization of the of a [TextTheme]'s glyphs that is used to define
    /// its localized [TextStyle] geometry for [ThemeData.textTheme].
    ///
    /// The script category defines the overall geometry of a [TextTheme] for
    /// the [Typography.geometryThemeFor] method in terms of the
    /// three language categories defined in <https://material.io/go/design-typography>.
    ///
    /// Generally speaking, font sizes for [ScriptCategory.tall] and
    /// [ScriptCategory.dense] scripts - for text styles that are smaller than the
    /// title style - are one unit larger than they are for
    /// [ScriptCategory.englishLike] scripts.
    /// </Summary>
    public enum ScriptCategory
    {

        /// <Summary>
        /// The languages of Western, Central, and Eastern Europe and much of
        /// Africa are typically written in the Latin alphabet. Vietnamese is a
        /// notable exception in that, while it uses a localized form of the Latin
        /// writing system, its accented glyphs can be much taller than those
        /// found in Western European languages. The Greek and Cyrillic writing
        /// systems are very similar to Latin.
        /// </Summary>
        EnglishLike,
        /// <Summary>
        /// Language scripts that require extra line height to accommodate larger
        /// glyphs, including Chinese, Japanese, and Korean.
        /// </Summary>
        Dense,
        /// <Summary>
        /// Language scripts that require extra line height to accommodate
        /// larger glyphs, including South and Southeast Asian and
        /// Middle-Eastern languages, like Arabic, Hindi, Telugu, Thai, and
        /// Vietnamese.
        /// </Summary>
        Tall,
    }

}
