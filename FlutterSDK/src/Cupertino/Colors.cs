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
namespace FlutterSDK.Cupertino.Colors
{
    internal static class ColorsDefaultClass
    {
        /// <Summary>
        /// Creates a diagnostics property for [CupertinoDynamicColor].
        ///
        /// The [showName], [style], and [level] arguments must not be null.
        /// </Summary>
        internal static FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<Color> CreateCupertinoColorProperty(string name, FlutterBinding.UI.Color value, bool showName = true, @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), DiagnosticLevel level = default(DiagnosticLevel))
        {
            if (value is CupertinoDynamicColor)
            {
                return new DiagnosticsProperty<CupertinoDynamicColor>(name, ((CupertinoDynamicColor)value), description: ((CupertinoDynamicColor)value)._DebugLabel, showName: showName, defaultValue: defaultValue, style: style, level: level);
            }
            else
            {
                return new ColorProperty(name, value, showName: showName, defaultValue: defaultValue, style: style, level: level);
            }

        }



    }

    /// <Summary>
    /// A palette of [Color] constants that describe colors commonly used when
    /// matching the iOS platform aesthetics.
    /// </Summary>
    public class CupertinoColors
    {
        internal CupertinoColors()
        {

        }
        /// <Summary>
        /// iOS 13's default blue color. Used to indicate active elements such as
        /// buttons, selected tabs and your own chat bubbles.
        ///
        /// This is SystemBlue in the iOS palette.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor ActiveBlue { get; set; }
        /// <Summary>
        /// iOS 13's default green color. Used to indicate active accents such as
        /// the switch in its on state and some accent buttons such as the call button
        /// and Apple Map's 'Go' button.
        ///
        /// This is SystemGreen in the iOS palette.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor ActiveGreen { get; set; }
        /// <Summary>
        /// iOS 13's orange color.
        ///
        /// This is SystemOrange in the iOS palette.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor ActiveOrange { get; set; }
        /// <Summary>
        /// Opaque white color. Used for backgrounds and fonts against dark backgrounds.
        ///
        /// This is SystemWhiteColor in the iOS palette.
        ///
        /// See also:
        ///
        ///  * [material.Colors.white], the same color, in the material design palette.
        ///  * [black], opaque black in the [CupertinoColors] palette.
        /// </Summary>
        public virtual FlutterBinding.UI.Color White { get; set; }
        /// <Summary>
        /// Opaque black color. Used for texts against light backgrounds.
        ///
        /// This is SystemBlackColor in the iOS palette.
        ///
        /// See also:
        ///
        ///  * [material.Colors.black], the same color, in the material design palette.
        ///  * [white], opaque white in the [CupertinoColors] palette.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Black { get; set; }
        /// <Summary>
        /// Used in iOS 10 for light background fills such as the chat bubble background.
        ///
        /// This is SystemLightGrayColor in the iOS palette.
        /// </Summary>
        public virtual FlutterBinding.UI.Color LightBackgroundGray { get; set; }
        /// <Summary>
        /// Used in iOS 12 for very light background fills in tables between cell groups.
        ///
        /// This is SystemExtraLightGrayColor in the iOS palette.
        /// </Summary>
        public virtual FlutterBinding.UI.Color ExtraLightBackgroundGray { get; set; }
        /// <Summary>
        /// Used in iOS 12 for very dark background fills in tables between cell groups
        /// in dark mode.
        /// </Summary>
        public virtual FlutterBinding.UI.Color DarkBackgroundGray { get; set; }
        /// <Summary>
        /// Used in iOS 13 for unselected selectables such as tab bar items in their
        /// inactive state or de-emphasized subtitles and details text.
        ///
        /// Not the same grey as disabled buttons etc.
        ///
        /// This is the disabled color in the iOS palette.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor InactiveGray { get; set; }
        /// <Summary>
        /// Used for iOS 13 for destructive actions such as the delete actions in
        /// table view cells and dialogs.
        ///
        /// Not the same red as the camera shutter or springboard icon notifications
        /// or the foreground red theme in various native apps such as HealthKit.
        ///
        /// This is SystemRed in the iOS palette.
        /// </Summary>
        public virtual FlutterBinding.UI.Color DestructiveRed { get; set; }
        /// <Summary>
        /// A blue color that can adapt to the given [BuildContext].
        ///
        /// See also:
        ///
        ///  * [UIColor.systemBlue](https://developer.apple.com/documentation/uikit/uicolor/3173141-systemblue),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemBlue { get; set; }
        /// <Summary>
        /// A green color that can adapt to the given [BuildContext].
        ///
        /// See also:
        ///
        ///  * [UIColor.systemGreen](https://developer.apple.com/documentation/uikit/uicolor/3173144-systemgreen),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGreen { get; set; }
        /// <Summary>
        /// An indigo color that can adapt to the given [BuildContext].
        ///
        /// See also:
        ///
        ///  * [UIColor.systemIndigo](https://developer.apple.com/documentation/uikit/uicolor/3173146-systemindigo),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemIndigo { get; set; }
        /// <Summary>
        /// An orange color that can adapt to the given [BuildContext].
        ///
        /// See also:
        ///
        ///  * [UIColor.systemOrange](https://developer.apple.com/documentation/uikit/uicolor/3173147-systemorange),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemOrange { get; set; }
        /// <Summary>
        /// A pink color that can adapt to the given [BuildContext].
        ///
        /// See also:
        ///
        ///  * [UIColor.systemPink](https://developer.apple.com/documentation/uikit/uicolor/3173148-systempink),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemPink { get; set; }
        /// <Summary>
        /// A purple color that can adapt to the given [BuildContext].
        ///
        /// See also:
        ///
        ///  * [UIColor.systemPurple](https://developer.apple.com/documentation/uikit/uicolor/3173149-systempurple),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemPurple { get; set; }
        /// <Summary>
        /// A red color that can adapt to the given [BuildContext].
        ///
        /// See also:
        ///
        ///  * [UIColor.systemRed](https://developer.apple.com/documentation/uikit/uicolor/3173150-systemred),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemRed { get; set; }
        /// <Summary>
        /// A teal color that can adapt to the given [BuildContext].
        ///
        /// See also:
        ///
        ///  * [UIColor.systemTeal](https://developer.apple.com/documentation/uikit/uicolor/3173151-systemteal),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemTeal { get; set; }
        /// <Summary>
        /// A yellow color that can adapt to the given [BuildContext].
        ///
        /// See also:
        ///
        ///  * [UIColor.systemYellow](https://developer.apple.com/documentation/uikit/uicolor/3173152-systemyellow),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemYellow { get; set; }
        /// <Summary>
        /// The base grey color.
        ///
        /// See also:
        ///
        ///  * [UIColor.systemGray](https://developer.apple.com/documentation/uikit/uicolor/3173143-systemgray),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey { get; set; }
        /// <Summary>
        /// A second-level shade of grey.
        ///
        /// See also:
        ///
        ///  * [UIColor.systemGray2](https://developer.apple.com/documentation/uikit/uicolor/3255071-systemgray2),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey2 { get; set; }
        /// <Summary>
        /// A third-level shade of grey.
        ///
        /// See also:
        ///
        ///  * [UIColor.systemGray3](https://developer.apple.com/documentation/uikit/uicolor/3255072-systemgray3),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey3 { get; set; }
        /// <Summary>
        /// A fourth-level shade of grey.
        ///
        /// See also:
        ///
        ///  * [UIColor.systemGray4](https://developer.apple.com/documentation/uikit/uicolor/3255073-systemgray4),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey4 { get; set; }
        /// <Summary>
        /// A fifth-level shade of grey.
        ///
        /// See also:
        ///
        ///  * [UIColor.systemGray5](https://developer.apple.com/documentation/uikit/uicolor/3255074-systemgray5),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey5 { get; set; }
        /// <Summary>
        /// A sixth-level shade of grey.
        ///
        /// See also:
        ///
        ///  * [UIColor.systemGray6](https://developer.apple.com/documentation/uikit/uicolor/3255075-systemgray6),
        ///    the `UIKit` equivalent.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGrey6 { get; set; }
        /// <Summary>
        /// The color for text labels containing primary content, equivalent to
        /// [UIColor.label](https://developer.apple.com/documentation/uikit/uicolor/3173131-label).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor Label { get; set; }
        /// <Summary>
        /// The color for text labels containing secondary content, equivalent to
        /// [UIColor.secondaryLabel](https://developer.apple.com/documentation/uikit/uicolor/3173136-secondarylabel).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SecondaryLabel { get; set; }
        /// <Summary>
        /// The color for text labels containing tertiary content, equivalent to
        /// [UIColor.tertiaryLabel](https://developer.apple.com/documentation/uikit/uicolor/3173153-tertiarylabel).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor TertiaryLabel { get; set; }
        /// <Summary>
        /// The color for text labels containing quaternary content, equivalent to
        /// [UIColor.quaternaryLabel](https://developer.apple.com/documentation/uikit/uicolor/3173135-quaternarylabel).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor QuaternaryLabel { get; set; }
        /// <Summary>
        /// An overlay fill color for thin and small shapes, equivalent to
        /// [UIColor.systemFill](https://developer.apple.com/documentation/uikit/uicolor/3255070-systemfill).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemFill { get; set; }
        /// <Summary>
        /// An overlay fill color for medium-size shapes, equivalent to
        /// [UIColor.secondarySystemFill](https://developer.apple.com/documentation/uikit/uicolor/3255069-secondarysystemfill).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SecondarySystemFill { get; set; }
        /// <Summary>
        /// An overlay fill color for large shapes, equivalent to
        /// [UIColor.tertiarySystemFill](https://developer.apple.com/documentation/uikit/uicolor/3255076-tertiarysystemfill).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor TertiarySystemFill { get; set; }
        /// <Summary>
        /// An overlay fill color for large areas containing complex content, equivalent
        /// to [UIColor.quaternarySystemFill](https://developer.apple.com/documentation/uikit/uicolor/3255068-quaternarysystemfill).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor QuaternarySystemFill { get; set; }
        /// <Summary>
        /// The color for placeholder text in controls or text views, equivalent to
        /// [UIColor.placeholderText](https://developer.apple.com/documentation/uikit/uicolor/3173134-placeholdertext).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor PlaceholderText { get; set; }
        /// <Summary>
        /// The color for the main background of your interface, equivalent to
        /// [UIColor.systemBackground](https://developer.apple.com/documentation/uikit/uicolor/3173140-systembackground).
        ///
        /// Typically used for designs that have a white primary background in a light environment.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemBackground { get; set; }
        /// <Summary>
        /// The color for content layered on top of the main background, equivalent to
        /// [UIColor.secondarySystemBackground](https://developer.apple.com/documentation/uikit/uicolor/3173137-secondarysystembackground).
        ///
        /// Typically used for designs that have a white primary background in a light environment.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SecondarySystemBackground { get; set; }
        /// <Summary>
        /// The color for content layered on top of secondary backgrounds, equivalent
        /// to [UIColor.tertiarySystemBackground](https://developer.apple.com/documentation/uikit/uicolor/3173154-tertiarysystembackground).
        ///
        /// Typically used for designs that have a white primary background in a light environment.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor TertiarySystemBackground { get; set; }
        /// <Summary>
        /// The color for the main background of your grouped interface, equivalent to
        /// [UIColor.systemGroupedBackground](https://developer.apple.com/documentation/uikit/uicolor/3173145-systemgroupedbackground).
        ///
        /// Typically used for grouped content, including table views and platter-based designs.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SystemGroupedBackground { get; set; }
        /// <Summary>
        /// The color for content layered on top of the main background of your grouped interface,
        /// equivalent to [UIColor.secondarySystemGroupedBackground](https://developer.apple.com/documentation/uikit/uicolor/3173138-secondarysystemgroupedbackground).
        ///
        /// Typically used for grouped content, including table views and platter-based designs.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor SecondarySystemGroupedBackground { get; set; }
        /// <Summary>
        /// The color for content layered on top of secondary backgrounds of your grouped interface,
        /// equivalent to [UIColor.tertiarySystemGroupedBackground](https://developer.apple.com/documentation/uikit/uicolor/3173155-tertiarysystemgroupedbackground).
        ///
        /// Typically used for grouped content, including table views and platter-based designs.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor TertiarySystemGroupedBackground { get; set; }
        /// <Summary>
        /// The color for thin borders or divider lines that allows some underlying content to be visible,
        /// equivalent to [UIColor.separator](https://developer.apple.com/documentation/uikit/uicolor/3173139-separator).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor Separator { get; set; }
        /// <Summary>
        /// The color for borders or divider lines that hide any underlying content,
        /// equivalent to [UIColor.opaqueSeparator](https://developer.apple.com/documentation/uikit/uicolor/3173133-opaqueseparator).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor OpaqueSeparator { get; set; }
        /// <Summary>
        /// The color for links, equivalent to
        /// [UIColor.link](https://developer.apple.com/documentation/uikit/uicolor/3173132-link).
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor Link { get; set; }
    }


    /// <Summary>
    /// A [Color] subclass that represents a family of colors, and the currect effective
    /// color in the color family.
    ///
    /// When used as a regular color, [CupertinoDynamicColor] is equivalent to the
    /// effective color (i.e. [CupertinoDynamicColor.value] will come from the effective
    /// color), which is determined by the [BuildContext] it is last resolved against.
    /// If it has never been resolved, the light, normal contrast, base elevation variant
    /// [CupertinoDynamicColor.color] will be the default effective color.
    ///
    /// Sometimes manually resolving a [CupertinoDynamicColor] is not necessary, because
    /// the Cupertino Library provides built-in support for it.
    ///
    /// ### Using [CupertinoDynamicColor] in a Cupertino widget
    ///
    /// When a Cupertino widget is provided with a [CupertinoDynamicColor], either
    /// directly in its constructor, or from an [InheritedWidget] it depends on (for example,
    /// [DefaultTextStyle]), the widget will automatically resolve the color using
    /// [CupertinoDynamicColor.resolve] against its own [BuildContext], on a best-effort
    /// basis.
    ///
    /// {@tool snippet}
    /// By default a [CupertinoButton] has no background color. The following sample
    /// code shows how to build a [CupertinoButton] that appears white in light mode,
    /// and changes automatically to black in dark mode.
    ///
    /// ```dart
    /// CupertinoButton(
    ///   child: child,
    ///   // CupertinoDynamicColor works out of box in a CupertinoButton.
    ///   color: CupertinoDynamicColor.withBrightness(
    ///     color: CupertinoColors.white,
    ///     darkColor: CupertinoColors.black,
    ///   ),
    ///   onPressed: () { },
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ### Using a [CupertinoDynamicColor] from a [CupertinoTheme]
    ///
    /// When referring to a [CupertinoTheme] color, generally the color will already
    /// have adapted to the ambient [BuildContext], because [CupertinoTheme.of]
    /// implicitly resolves all the colors used in the retrieved [CupertinoThemeData],
    /// before returning it.
    ///
    /// {@tool snippet}
    /// The following code sample creates a [Container] with the `primaryColor` of the
    /// current theme. If `primaryColor` is a [CupertinoDynamicColor], the container
    /// will be adaptive, thanks to [CupertinoTheme.of]: it will switch to `primaryColor`'s
    /// dark variant once dark mode is turned on, and turns to primaryColor`'s high
    /// contrast variant when [MediaQueryData.highContrast] is requested in the ambient
    /// [MediaQuery], etc.
    ///
    /// ```dart
    /// Container(
    ///   // Container is not a Cupertino widget, but CupertinoTheme.of implicitly
    ///   // resolves colors used in the retrieved CupertinoThemeData.
    ///   color: CupertinoTheme.of(context).primaryColor,
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ### Manually Resolving a [CupertinoDynamicColor]
    ///
    /// When used to configure a non-Cupertino widget, or wrapped in an object opaque
    /// to the receiving Cupertino component, a [CupertinoDynamicColor] may need to be
    /// manually resolved using [CupertinoDynamicColor.resolve], before it can used
    /// to paint. For example, to use a custom [Border] in a [CupertinoNavigationBar],
    /// the colors used in the [Border] have to be resolved manually before being passed
    /// to [CupertinoNavigationBar]'s constructor.
    ///
    /// {@tool snippet}
    ///
    /// The following code samples demonstrate two cases where you have to manually
    /// resolve a [CupertinoDynamicColor].
    ///
    /// ```dart
    /// CupertinoNavigationBar(
    ///   // CupertinoNavigationBar does not know how to resolve colors used in
    ///   // a Border class.
    ///   border: Border(
    ///     bottom: BorderSide(
    ///       color: CupertinoDynamicColor.resolve(CupertinoColors.systemBlue, context),
    ///     ),
    ///   ),
    /// )
    /// ```
    ///
    /// ```dart
    /// Container(
    ///   // Container is not a Cupertino widget.
    ///   color: CupertinoDynamicColor.resolve(CupertinoColors.systemBlue, context),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [CupertinoUserInterfaceLevel], an [InheritedWidget] that may affect color
    ///    resolution of a [CupertinoDynamicColor].
    ///  * [CupertinoTheme.of], a static method that retrieves the ambient [CupertinoThemeData],
    ///    and then resolves [CupertinoDynamicColor]s used in the retrieved data.
    /// </Summary>
    public class CupertinoDynamicColor : Color, IDiagnosticable
    {
        /// <Summary>
        /// Creates an adaptive [Color] that changes its effective color based on the
        /// [BuildContext] given. The default effective color is [color].
        ///
        /// All the colors must not be null.
        /// </Summary>
        public CupertinoDynamicColor(string debugLabel = default(string), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color darkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highContrastColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color darkHighContrastColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color elevatedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color darkElevatedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highContrastElevatedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color darkHighContrastElevatedColor = default(FlutterBinding.UI.Color))
        : base()
        {

        }
        /// <Summary>
        /// Creates an adaptive [Color] that changes its effective color based on the
        /// given [BuildContext]'s brightness (from [MediaQueryData.platformBrightness]
        /// or [CupertinoThemeData.brightness]) and accessibility contrast setting
        /// ([MediaQueryData.highContrast]). The default effective color is [color].
        ///
        /// All the colors must not be null.
        /// </Summary>
        public static CupertinoDynamicColor WithBrightnessAndContrast(string debugLabel = default(string), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color darkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highContrastColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color darkHighContrastColor = default(FlutterBinding.UI.Color))
        {
            var instance = new CupertinoDynamicColor();
        }
        /// <Summary>
        /// Creates an adaptive [Color] that changes its effective color based on the given
        /// [BuildContext]'s brightness (from [MediaQueryData.platformBrightness] or
        /// [CupertinoThemeData.brightness]). The default effective color is [color].
        ///
        /// All the colors must not be null.
        /// </Summary>
        public static CupertinoDynamicColor WithBrightness(string debugLabel = default(string), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color darkColor = default(FlutterBinding.UI.Color))
        {
            var instance = new CupertinoDynamicColor();
        }
        internal CupertinoDynamicColor(FlutterBinding.UI.Color _effectiveColor, FlutterBinding.UI.Color color, FlutterBinding.UI.Color darkColor, FlutterBinding.UI.Color highContrastColor, FlutterBinding.UI.Color darkHighContrastColor, FlutterBinding.UI.Color elevatedColor, FlutterBinding.UI.Color darkElevatedColor, FlutterBinding.UI.Color highContrastElevatedColor, FlutterBinding.UI.Color darkHighContrastElevatedColor, FlutterSDK.Widgets.Framework.Element _debugResolveContext, string _debugLabel)
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
            this._DebugLabel = _debugLabel;
        }
        /// <Summary>
        /// The current effective color.
        ///
        /// Must not be null. Defaults to [color] if this [CupertinoDynamicColor] has
        /// never been resolved.
        /// </Summary>
        internal virtual FlutterBinding.UI.Color _EffectiveColor { get; set; }
        internal virtual string _DebugLabel { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Element _DebugResolveContext { get; set; }
        /// <Summary>
        /// The color to use when the [BuildContext] implies a combination of light mode,
        /// normal contrast, and base interface elevation.
        ///
        /// In other words, this color will be the effective color of the [CupertinoDynamicColor]
        /// after it is resolved against a [BuildContext] that:
        /// - has a [CupertinoTheme] whose [CupertinoThemeData.brightness] is [Brightness.light],
        /// or a [MediaQuery] whose [MediaQueryData.platformBrightness] is [Brightness.light].
        /// - has a [MediaQuery] whose [MediaQueryData.highContrast] is `false`.
        /// - has a [CupertinoUserInterfaceLevel] that indicates [CupertinoUserInterfaceLevelData.base].
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// The color to use when the [BuildContext] implies a combination of dark mode,
        /// normal contrast, and base interface elevation.
        ///
        /// In other words, this color will be the effective color of the [CupertinoDynamicColor]
        /// after it is resolved against a [BuildContext] that:
        /// - has a [CupertinoTheme] whose [CupertinoThemeData.brightness] is [Brightness.dark],
        /// or a [MediaQuery] whose [MediaQueryData.platformBrightness] is [Brightness.dark].
        /// - has a [MediaQuery] whose [MediaQueryData.highContrast] is `false`.
        /// - has a [CupertinoUserInterfaceLevel] that indicates [CupertinoUserInterfaceLevelData.base].
        /// </Summary>
        public virtual FlutterBinding.UI.Color DarkColor { get; set; }
        /// <Summary>
        /// The color to use when the [BuildContext] implies a combination of light mode,
        /// high contrast, and base interface elevation.
        ///
        /// In other words, this color will be the effective color of the [CupertinoDynamicColor]
        /// after it is resolved against a [BuildContext] that:
        /// - has a [CupertinoTheme] whose [CupertinoThemeData.brightness] is [Brightness.light],
        /// or a [MediaQuery] whose [MediaQueryData.platformBrightness] is [Brightness.light].
        /// - has a [MediaQuery] whose [MediaQueryData.highContrast] is `true`.
        /// - has a [CupertinoUserInterfaceLevel] that indicates [CupertinoUserInterfaceLevelData.base].
        /// </Summary>
        public virtual FlutterBinding.UI.Color HighContrastColor { get; set; }
        /// <Summary>
        /// The color to use when the [BuildContext] implies a combination of dark mode,
        /// high contrast, and base interface elevation.
        ///
        /// In other words, this color will be the effective color of the [CupertinoDynamicColor]
        /// after it is resolved against a [BuildContext] that:
        /// - has a [CupertinoTheme] whose [CupertinoThemeData.brightness] is [Brightness.dark],
        /// or a [MediaQuery] whose [MediaQueryData.platformBrightness] is [Brightness.dark].
        /// - has a [MediaQuery] whose [MediaQueryData.highContrast] is `true`.
        /// - has a [CupertinoUserInterfaceLevel] that indicates [CupertinoUserInterfaceLevelData.base].
        /// </Summary>
        public virtual FlutterBinding.UI.Color DarkHighContrastColor { get; set; }
        /// <Summary>
        /// The color to use when the [BuildContext] implies a combination of light mode,
        /// normal contrast, and elevated interface elevation.
        ///
        /// In other words, this color will be the effective color of the [CupertinoDynamicColor]
        /// after it is resolved against a [BuildContext] that:
        /// - has a [CupertinoTheme] whose [CupertinoThemeData.brightness] is [Brightness.light],
        /// or a [MediaQuery] whose [MediaQueryData.platformBrightness] is [Brightness.light].
        /// - has a [MediaQuery] whose [MediaQueryData.highContrast] is `false`.
        /// - has a [CupertinoUserInterfaceLevel] that indicates [CupertinoUserInterfaceLevelData.elevated].
        /// </Summary>
        public virtual FlutterBinding.UI.Color ElevatedColor { get; set; }
        /// <Summary>
        /// The color to use when the [BuildContext] implies a combination of dark mode,
        /// normal contrast, and elevated interface elevation.
        ///
        /// In other words, this color will be the effective color of the [CupertinoDynamicColor]
        /// after it is resolved against a [BuildContext] that:
        /// - has a [CupertinoTheme] whose [CupertinoThemeData.brightness] is [Brightness.dark],
        /// or a [MediaQuery] whose [MediaQueryData.platformBrightness] is [Brightness.dark].
        /// - has a [MediaQuery] whose [MediaQueryData.highContrast] is `false`.
        /// - has a [CupertinoUserInterfaceLevel] that indicates [CupertinoUserInterfaceLevelData.elevated].
        /// </Summary>
        public virtual FlutterBinding.UI.Color DarkElevatedColor { get; set; }
        /// <Summary>
        /// The color to use when the [BuildContext] implies a combination of light mode,
        /// high contrast, and elevated interface elevation.
        ///
        /// In other words, this color will be the effective color of the [CupertinoDynamicColor]
        /// after it is resolved against a [BuildContext] that:
        /// - has a [CupertinoTheme] whose [CupertinoThemeData.brightness] is [Brightness.light],
        /// or a [MediaQuery] whose [MediaQueryData.platformBrightness] is [Brightness.light].
        /// - has a [MediaQuery] whose [MediaQueryData.highContrast] is `true`.
        /// - has a [CupertinoUserInterfaceLevel] that indicates [CupertinoUserInterfaceLevelData.elevated].
        /// </Summary>
        public virtual FlutterBinding.UI.Color HighContrastElevatedColor { get; set; }
        /// <Summary>
        /// The color to use when the [BuildContext] implies a combination of dark mode,
        /// high contrast, and elevated interface elevation.
        ///
        /// In other words, this color will be the effective color of the [CupertinoDynamicColor]
        /// after it is resolved against a [BuildContext] that:
        /// - has a [CupertinoTheme] whose [CupertinoThemeData.brightness] is [Brightness.dark],
        /// or a [MediaQuery] whose [MediaQueryData.platformBrightness] is [Brightness.dark].
        /// - has a [MediaQuery] whose [MediaQueryData.highContrast] is `true`.
        /// - has a [CupertinoUserInterfaceLevel] that indicates [CupertinoUserInterfaceLevelData.elevated].
        /// </Summary>
        public virtual FlutterBinding.UI.Color DarkHighContrastElevatedColor { get; set; }
        public virtual int Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsPlatformBrightnessDependent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsHighContrastDependent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsInterfaceElevationDependent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Resolves the given [Color] by calling [resolveFrom].
        ///
        /// If the given color is already a concrete [Color], it will be returned as is.
        /// If the given color is null, returns null.
        /// If the given color is a [CupertinoDynamicColor], but the given [BuildContext]
        /// lacks the dependencies required to the color resolution, the default trait
        /// value will be used ([Brightness.light] platform brightness, normal contrast,
        /// [CupertinoUserInterfaceLevelData.base] elevation level), unless [nullOk] is
        /// set to false, in which case an exception will be thrown.
        /// </Summary>
        public virtual Color Resolve(FlutterBinding.UI.Color resolvable, FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = true)
        {
            if (resolvable == null) return null;

            return (resolvable is CupertinoDynamicColor) ? resolvable.ResolveFrom(context, nullOk: nullOk) : resolvable;
        }




        /// <Summary>
        /// Resolves this [CupertinoDynamicColor] using the provided [BuildContext].
        ///
        /// Calling this method will create a new [CupertinoDynamicColor] that is almost
        /// identical to this [CupertinoDynamicColor], except the effective color is
        /// changed to adapt to the given [BuildContext].
        ///
        /// For example, if the given [BuildContext] indicates the widgets in the subtree
        /// should be displayed in dark mode (the surrounding [CupertinoTheme]'s [CupertinoThemeData.brightness]
        /// or [MediaQuery]'s [MediaQueryData.platformBrightness] is [Brightness.dark]),
        /// with a high accessibility contrast (the surrounding [MediaQuery]'s [MediaQueryData.highContrast]
        /// is `true`), and an elevated interface elevation (the surrounding [CupertinoUserInterfaceLevel]'s
        /// `data` is [CupertinoUserInterfaceLevelData.elevated]), the resolved
        /// [CupertinoDynamicColor] will be the same as this [CupertinoDynamicColor],
        /// except its effective color will be the `darkHighContrastElevatedColor` variant
        /// from the original [CupertinoDynamicColor].
        ///
        /// Calling this function may create dependencies on the closest instance of some
        /// [InheritedWidget]s that enclose the given [BuildContext]. E.g., if [darkColor]
        /// is different from [color], this method will call [CupertinoTheme.of], and
        /// then [MediaQuery.of] if brightness wasn't specified in the theme data retrieved
        /// from the previous [CupertinoTheme.of] call, in an effort to determine the
        /// brightness value.
        ///
        /// If any of the required dependencies are missing from the given context, the
        /// default value of that trait will be used ([Brightness.light] platform
        /// brightness, normal contrast, [CupertinoUserInterfaceLevelData.base] elevation
        /// level), unless [nullOk] is set to false, in which case an exception will be
        /// thrown.
        /// </Summary>
        public virtual FlutterSDK.Cupertino.Colors.CupertinoDynamicColor ResolveFrom(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = true)
        {
            Brightness brightness = _IsPlatformBrightnessDependent ? ThemeDefaultClass.CupertinoTheme.BrightnessOf(context, nullOk: nullOk) ?? Brightness.Light : Brightness.Light;
            bool isHighContrastEnabled = _IsHighContrastDependent && (MediaqueryDefaultClass.MediaQuery.Of(context, nullOk: nullOk)?.HighContrast ?? false);
            CupertinoUserInterfaceLevelData level = _IsInterfaceElevationDependent ? InterfacelevelDefaultClass.CupertinoUserInterfaceLevel.Of(context, nullOk: nullOk) ?? CupertinoUserInterfaceLevelData.Base : CupertinoUserInterfaceLevelData.Base;
            Color resolved = default(Color);
            switch (brightness) { case Brightness.Light: switch (level) { case CupertinoUserInterfaceLevelData.Base: resolved = isHighContrastEnabled ? HighContrastColor : Color; break; case CupertinoUserInterfaceLevelData.Elevated: resolved = isHighContrastEnabled ? HighContrastElevatedColor : ElevatedColor; break; } break; case Brightness.Dark: switch (level) { case CupertinoUserInterfaceLevelData.Base: resolved = isHighContrastEnabled ? DarkHighContrastColor : DarkColor; break; case CupertinoUserInterfaceLevelData.Elevated: resolved = isHighContrastEnabled ? DarkHighContrastElevatedColor : DarkElevatedColor; break; } }
            Element _debugContext = default(Element);

            return CupertinoDynamicColor._(resolved, Color, DarkColor, HighContrastColor, DarkHighContrastColor, ElevatedColor, DarkElevatedColor, HighContrastElevatedColor, DarkHighContrastElevatedColor, _debugContext, _DebugLabel);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is CupertinoDynamicColor && other.Value == Value && other.Color == Color && other.DarkColor == DarkColor && other.HighContrastColor == HighContrastColor && other.DarkHighContrastColor == DarkHighContrastColor && other.ElevatedColor == ElevatedColor && other.DarkElevatedColor == DarkElevatedColor && other.HighContrastElevatedColor == HighContrastElevatedColor && other.DarkHighContrastElevatedColor == DarkHighContrastElevatedColor;
        }





        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            if (_DebugLabel != null) properties.Add(new MessageProperty("debugLabel", _DebugLabel));
            properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("color", Color));
            if (_IsPlatformBrightnessDependent) properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("darkColor", DarkColor));
            if (_IsHighContrastDependent) properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("highContrastColor", HighContrastColor));
            if (_IsPlatformBrightnessDependent && _IsHighContrastDependent) properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("darkHighContrastColor", DarkHighContrastColor));
            if (_IsInterfaceElevationDependent) properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("elevatedColor", ElevatedColor));
            if (_IsPlatformBrightnessDependent && _IsInterfaceElevationDependent) properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("darkElevatedColor", DarkElevatedColor));
            if (_IsHighContrastDependent && _IsInterfaceElevationDependent) properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("highContrastElevatedColor", HighContrastElevatedColor));
            if (_IsPlatformBrightnessDependent && _IsHighContrastDependent && _IsInterfaceElevationDependent) properties.Add(ColorsDefaultClass.CreateCupertinoColorProperty("darkHighContrastElevatedColor", DarkHighContrastElevatedColor));
            if (_DebugResolveContext != null) properties.Add(new DiagnosticsProperty<Element>("last resolved", _DebugResolveContext));
        }



    }

}
