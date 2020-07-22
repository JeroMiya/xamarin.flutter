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
namespace FlutterSDK.Material.Icons
{
    internal static class IconsDefaultClass
    {
    }

    /// <Summary>
    /// Identifiers for the supported material design icons.
    ///
    /// Use with the [Icon] class to show specific icons.
    ///
    /// Icons are identified by their name as listed below.
    ///
    /// To use this class, make sure you set `uses-material-design: true` in your
    /// project's `pubspec.yaml` file in the `flutter` section. This ensures that
    /// the MaterialIcons font is included in your application. This font is used to
    /// display the icons. For example:
    ///
    /// ```yaml
    /// name: my_awesome_application
    /// flutter:
    ///   uses-material-design: true
    /// ```
    ///
    /// {@tool snippet}
    /// This example shows how to create a [Row] of [Icon]s in different colors and
    /// sizes. The first [Icon] uses a [Icon.semanticLabel] to announce in accessibility
    /// modes like TalkBack and VoiceOver.
    ///
    /// ![A row of icons representing a pink heart, a green musical note, and a blue umbrella](https://flutter.github.io/assets-for-api-docs/assets/widgets/icon.png)
    ///
    /// ```dart
    /// Row(
    ///   mainAxisAlignment: MainAxisAlignment.spaceAround,
    ///   children: const <Widget>[
    ///     Icon(
    ///       Icons.favorite,
    ///       color: Colors.pink,
    ///       size: 24.0,
    ///       semanticLabel: 'Text to announce in accessibility modes',
    ///     ),
    ///     Icon(
    ///       Icons.audiotrack,
    ///       color: Colors.green,
    ///       size: 30.0,
    ///     ),
    ///     Icon(
    ///       Icons.beach_access,
    ///       color: Colors.blue,
    ///       size: 36.0,
    ///     ),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Icon]
    ///  * [IconButton]
    ///  * <https://design.google.com/icons/>
    /// </Summary>
    public class Icons
    {
        internal Icons()
        {

        }
        public virtual FlutterSDK.Widgets.Icondata.IconData Threesixty { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Threedrotation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fourk { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Acunit { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessalarm { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessalarms { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accesstime { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessibility { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessibilitynew { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessible { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessibleforward { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accountbalance { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accountbalancewallet { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accountbox { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Accountcircle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Adb { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Add { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addaphoto { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addalarm { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addalert { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addbox { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addcall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addcircle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addcircleoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addcomment { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addlocation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addphotoalternate { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addshoppingcart { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addtohomescreen { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addtophotos { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Addtoqueue { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Adjust { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatflat { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatflatangled { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatindividualsuite { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatlegroomextra { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatlegroomnormal { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatlegroomreduced { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatreclineextra { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatreclinenormal { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airplanemodeactive { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airplanemodeinactive { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airplay { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Airportshuttle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Alarm { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Alarmadd { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Alarmoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Alarmon { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Album { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Allinclusive { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Allout { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Alternateemail { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Android { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Announcement { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Apps { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Archive { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowback { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowbackios { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowdownward { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowdropdown { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowdropdowncircle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowdropup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowforward { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowforwardios { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowleft { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowright { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowupward { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Arttrack { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Aspectratio { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Assessment { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignment { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignmentind { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignmentlate { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignmentreturn { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignmentreturned { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignmentturnedin { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Assistant { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Assistantphoto { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Atm { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Attachfile { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Attachmoney { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Attachment { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Audiotrack { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Autorenew { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Avtimer { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Backspace { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Backup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Batteryalert { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Batterychargingfull { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Batteryfull { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Batterystd { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Batteryunknown { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Beachaccess { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Beenhere { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Block { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetooth { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetoothaudio { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetoothconnected { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetoothdisabled { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetoothsearching { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Blurcircular { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Blurlinear { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluroff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluron { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Book { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bookmark { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bookmarkborder { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderbottom { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderclear { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bordercolor { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderhorizontal { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderinner { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderleft { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderouter { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderright { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderstyle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bordertop { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bordervertical { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brandingwatermark { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness1 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness2 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness3 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness4 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness5 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness6 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness7 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightnessauto { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightnesshigh { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightnesslow { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightnessmedium { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brokenimage { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Brush { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bubblechart { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Bugreport { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Build { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Burstmode { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Business { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Businesscenter { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cached { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cake { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Calendartoday { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Calendarviewday { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Call { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Callend { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Callmade { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Callmerge { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Callmissed { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Callmissedoutgoing { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Callreceived { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Callsplit { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Calltoaction { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Camera { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cameraalt { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cameraenhance { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Camerafront { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Camerarear { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cameraroll { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cancel { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cardgiftcard { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cardmembership { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cardtravel { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Casino { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cast { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Castconnected { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Category { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Centerfocusstrong { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Centerfocusweak { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Changehistory { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Chat { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Chatbubble { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Chatbubbleoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Check { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkbox { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkboxoutlineblank { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkcircle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkcircleoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Chevronleft { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Chevronright { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Childcare { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Childfriendly { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Chromereadermode { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Class { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Clear { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Clearall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Close { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Closedcaption { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cloud { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cloudcircle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Clouddone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Clouddownload { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cloudoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cloudqueue { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cloudupload { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Code { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Collections { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Collectionsbookmark { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Colorlens { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Colorize { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Comment { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Compare { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Comparearrows { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Computer { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Confirmationnumber { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Contactmail { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Contactphone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Contacts { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Contentcopy { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Contentcut { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Contentpaste { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Controlpoint { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Controlpointduplicate { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Copyright { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Create { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Createnewfolder { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Creditcard { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Crop { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Crop169 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Crop32 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Crop54 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Crop75 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cropdin { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cropfree { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Croplandscape { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Croporiginal { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cropportrait { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Croprotate { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Cropsquare { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Dashboard { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Datausage { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Daterange { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Dehaze { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Delete { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Deleteforever { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Deleteoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Deletesweep { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Departureboard { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Description { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Desktopmac { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Desktopwindows { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Details { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Developerboard { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Developermode { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Devicehub { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Deviceunknown { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Devices { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Devicesother { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Dialersip { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Dialpad { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Directions { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionsbike { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionsboat { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionsbus { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionscar { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionsrailway { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionsrun { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionssubway { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionstransit { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionswalk { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Discfull { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Dns { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Donotdisturb { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Donotdisturbalt { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Donotdisturboff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Donotdisturbon { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Dock { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Domain { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Done { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Doneall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Doneoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Donutlarge { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Donutsmall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Drafts { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Draghandle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Driveeta { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Dvr { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Edit { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Editattributes { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Editlocation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Eject { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Email { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Enhancedencryption { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Equalizer { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Error { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Erroroutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Eurosymbol { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Evstation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData @event { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Eventavailable { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Eventbusy { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Eventnote { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Eventseat { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Exittoapp { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Expandless { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Expandmore { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Explicit { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Explore { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposure { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposureneg1 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposureneg2 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposureplus1 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposureplus2 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposurezero { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Extension { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Face { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fastforward { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fastrewind { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fastfood { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Favorite { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Favoriteborder { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Featuredplaylist { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Featuredvideo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Feedback { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fiberdvr { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fibermanualrecord { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fibernew { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fiberpin { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fibersmartrecord { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filedownload { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fileupload { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter1 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter2 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter3 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter4 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter5 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter6 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter7 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter8 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter9 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter9plus { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filterbandw { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filtercenterfocus { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filterdrama { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filterframes { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filterhdr { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filterlist { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filternone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filtertiltshift { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Filtervintage { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Findinpage { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Findreplace { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fingerprint { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Firstpage { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fitnesscenter { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Flag { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Flare { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Flashauto { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Flashoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Flashon { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Flight { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Flightland { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Flighttakeoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Flip { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fliptoback { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fliptofront { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Folder { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Folderopen { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Foldershared { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Folderspecial { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fontdownload { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formataligncenter { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatalignjustify { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatalignleft { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatalignright { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatbold { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatclear { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatcolorfill { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatcolorreset { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatcolortext { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatindentdecrease { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatindentincrease { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatitalic { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatlinespacing { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatlistbulleted { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatlistnumbered { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatlistnumberedrtl { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatpaint { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatquote { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatshapes { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatsize { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatstrikethrough { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formattextdirectionltor { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formattextdirectionrtol { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatunderlined { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Forum { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Forward { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Forward10 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Forward30 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Forward5 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Freebreakfast { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fullscreen { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Fullscreenexit { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Functions { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gtranslate { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gamepad { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Games { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gavel { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gesture { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Getapp { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gif { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Golfcourse { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gpsfixed { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gpsnotfixed { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gpsoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Grade { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gradient { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Grain { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Graphiceq { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gridoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Gridon { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Group { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Groupadd { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Groupwork { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Hd { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Hdroff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Hdron { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Hdrstrong { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Hdrweak { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Headset { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Headsetmic { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Headsetoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Healing { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Hearing { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Help { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Helpoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Highquality { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Highlight { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Highlightoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData History { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Home { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Hottub { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Hotel { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Hourglassempty { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Hourglassfull { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Http { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Https { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Image { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Imageaspectratio { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Importcontacts { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Importexport { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Importantdevices { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Inbox { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Indeterminatecheckbox { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Info { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Infooutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Input { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertchart { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertcomment { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertdrivefile { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertemoticon { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertinvitation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertlink { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertphoto { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Invertcolors { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Invertcolorsoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Iso { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboard { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardarrowdown { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardarrowleft { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardarrowright { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardarrowup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardbackspace { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardcapslock { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardhide { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardreturn { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardtab { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardvoice { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Kitchen { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Label { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Labelimportant { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Labeloutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Landscape { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Language { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Laptop { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Laptopchromebook { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Laptopmac { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Laptopwindows { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Lastpage { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Launch { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Layers { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Layersclear { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Leakadd { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Leakremove { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Lens { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Libraryadd { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Librarybooks { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Librarymusic { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Lightbulboutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Linestyle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Lineweight { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Linearscale { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Link { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Linkoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Linkedcamera { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData List { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Livehelp { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Livetv { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localactivity { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localairport { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localatm { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localbar { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localcafe { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localcarwash { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localconveniencestore { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localdining { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localdrink { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localflorist { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localgasstation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localgrocerystore { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localhospital { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localhotel { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Locallaundryservice { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Locallibrary { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localmall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localmovies { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localoffer { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localparking { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localpharmacy { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localphone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localpizza { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localplay { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localpostoffice { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localprintshop { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localsee { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localshipping { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Localtaxi { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationcity { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationdisabled { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationon { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationsearching { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Lock { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Lockopen { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Lockoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Looks { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Looks3 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Looks4 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Looks5 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Looks6 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Looksone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Lookstwo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Loop { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Loupe { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Lowpriority { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Loyalty { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Mail { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Mailoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Map { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Markunread { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Markunreadmailbox { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Maximize { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Memory { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Menu { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Mergetype { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Message { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Mic { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Micnone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Micoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Minimize { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Missedvideocall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Mms { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Mobilescreenshare { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Modecomment { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Modeedit { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Monetizationon { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Moneyoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Monochromephotos { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Mood { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Moodbad { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData More { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Morehoriz { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Morevert { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Motorcycle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Mouse { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Movetoinbox { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Movie { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Moviecreation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Moviefilter { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Multilinechart { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Musicnote { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Musicvideo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Mylocation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Nature { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Naturepeople { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Navigatebefore { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Navigatenext { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Navigation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Nearme { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Networkcell { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Networkcheck { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Networklocked { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Networkwifi { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Newreleases { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Nextweek { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Nfc { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Noencryption { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Nosim { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Notinterested { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Notlistedlocation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Note { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Noteadd { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Notificationimportant { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Notifications { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Notificationsactive { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Notificationsnone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Notificationsoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Notificationspaused { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Offlinebolt { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Offlinepin { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Ondemandvideo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Opacity { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Openinbrowser { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Openinnew { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Openwith { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Outlinedflag { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pages { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pageview { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Palette { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pantool { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Panorama { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Panoramafisheye { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Panoramahorizontal { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Panoramavertical { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Panoramawideangle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Partymode { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pause { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pausecirclefilled { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pausecircleoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Payment { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData People { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Peopleoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Permcameramic { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Permcontactcalendar { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Permdatasetting { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Permdeviceinformation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Permidentity { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Permmedia { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Permphonemsg { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Permscanwifi { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Person { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Personadd { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Personoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Personpin { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Personpincircle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Personalvideo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pets { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phoneandroid { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonebluetoothspeaker { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phoneforwarded { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phoneintalk { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phoneiphone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelocked { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonemissed { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonepaused { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelink { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelinkerase { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelinklock { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelinkoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelinkring { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelinksetup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Photo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Photoalbum { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Photocamera { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Photofilter { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Photolibrary { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Photosizeselectactual { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Photosizeselectlarge { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Photosizeselectsmall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pictureaspdf { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pictureinpicture { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pictureinpicturealt { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Piechart { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Piechartoutlined { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pindrop { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Place { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Playarrow { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Playcirclefilled { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Playcircleoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Playforwork { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Playlistadd { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Playlistaddcheck { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Playlistplay { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Plusone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Poll { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Polymer { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pool { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Portablewifioff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Portrait { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Power { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Powerinput { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Powersettingsnew { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Pregnantwoman { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Presenttoall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Print { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Priorityhigh { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Public { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Publish { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Querybuilder { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Questionanswer { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Queue { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Queuemusic { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Queueplaynext { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Radio { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Radiobuttonchecked { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Radiobuttonunchecked { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Ratereview { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Receipt { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Recentactors { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Recordvoiceover { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Redeem { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Redo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Refresh { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Remove { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Removecircle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Removecircleoutline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Removefromqueue { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Removeredeye { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Removeshoppingcart { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Reorder { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Repeat { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Repeatone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Replay { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Replay10 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Replay30 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Replay5 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Reply { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Replyall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Report { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Reportoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Reportproblem { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Restaurant { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Restaurantmenu { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Restore { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Restorefromtrash { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Restorepage { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Ringvolume { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Room { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Roomservice { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Rotate90degreesccw { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Rotateleft { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Rotateright { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Roundedcorner { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Router { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Rowing { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Rssfeed { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Rvhookup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Satellite { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Save { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Savealt { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Scanner { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Scatterplot { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Schedule { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData School { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Score { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Screenlocklandscape { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Screenlockportrait { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Screenlockrotation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Screenrotation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Screenshare { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sdcard { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sdstorage { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Search { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Security { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Selectall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Send { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sentimentdissatisfied { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sentimentneutral { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sentimentsatisfied { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sentimentverydissatisfied { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sentimentverysatisfied { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settings { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsapplications { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsbackuprestore { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsbluetooth { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsbrightness { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingscell { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsethernet { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsinputantenna { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsinputcomponent { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsinputcomposite { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsinputhdmi { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsinputsvideo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsoverscan { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsphone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingspower { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsremote { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingssystemdaydream { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsvoice { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Share { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Shop { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Shoptwo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Shoppingbasket { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Shoppingcart { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Shorttext { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Showchart { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Shuffle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Shutterspeed { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalcellular4bar { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalcellularconnectednointernet4bar { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalcellularnosim { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalcellularnull { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalcellularoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalwifi4bar { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalwifi4barlock { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalwifioff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Simcard { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Simcardalert { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Skipnext { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Skipprevious { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Slideshow { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Slowmotionvideo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Smartphone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Smokefree { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Smokingrooms { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sms { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Smsfailed { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Snooze { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sort { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sortbyalpha { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Spa { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Spacebar { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Speaker { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Speakergroup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Speakernotes { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Speakernotesoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Speakerphone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Spellcheck { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Star { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Starborder { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Starhalf { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Stars { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Staycurrentlandscape { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Staycurrentportrait { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Stayprimarylandscape { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Stayprimaryportrait { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Stop { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Stopscreenshare { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Storage { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Store { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Storemalldirectory { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Straighten { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Streetview { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Strikethroughs { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Style { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Subdirectoryarrowleft { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Subdirectoryarrowright { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Subject { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Subscriptions { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Subtitles { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Subway { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Supervisedusercircle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Supervisoraccount { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Surroundsound { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Swapcalls { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Swaphoriz { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Swaphorizontalcircle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Swapvert { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Swapverticalcircle { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Switchcamera { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Switchvideo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Sync { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Syncdisabled { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Syncproblem { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Systemupdate { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Systemupdatealt { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tab { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tabunselected { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tablechart { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tablet { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tabletandroid { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tabletmac { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tagfaces { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tapandplay { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Terrain { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Textfields { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Textformat { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotateup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotatevertical { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotationangledown { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotationangleup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotationdown { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotationnone { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Textsms { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Texture { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Theaters { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Thumbdown { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Thumbup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Thumbsupdown { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Timetoleave { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Timelapse { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Timeline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Timer { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Timer10 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Timer3 { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Timeroff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Title { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Toc { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Today { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Toll { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tonality { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Touchapp { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Toys { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Trackchanges { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Traffic { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Train { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tram { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Transferwithinastation { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Transform { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Transitenterexit { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Translate { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Trendingdown { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Trendingflat { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Trendingup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Triporigin { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tune { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Turnedin { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Turnedinnot { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Tv { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Unarchive { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Undo { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Unfoldless { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Unfoldmore { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Update { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Usb { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Verifieduser { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Verticalalignbottom { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Verticalaligncenter { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Verticalaligntop { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Vibration { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Videocall { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Videolabel { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Videolibrary { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Videocam { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Videocamoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Videogameasset { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewagenda { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewarray { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewcarousel { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewcolumn { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewcomfy { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewcompact { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewday { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewheadline { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewlist { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewmodule { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewquilt { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewstream { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewweek { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Vignette { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Visibility { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Visibilityoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Voicechat { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Voicemail { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumedown { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumemute { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumeoff { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumeup { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Vpnkey { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Vpnlock { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wallpaper { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Warning { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Watch { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Watchlater { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wbauto { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wbcloudy { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wbincandescent { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wbiridescent { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wbsunny { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wc { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Web { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Webasset { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Weekend { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Whatshot { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Widgets { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wifi { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wifilock { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wifitethering { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Work { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Wraptext { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Youtubesearchedfor { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Zoomin { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Zoomout { get; set; }
        public virtual FlutterSDK.Widgets.Icondata.IconData Zoomoutmap { get; set; }
    }

}
