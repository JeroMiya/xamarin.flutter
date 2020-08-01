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
        /// <Summary>
        /// <i class="material-icons md-36">360</i> &#x2014; material icon named "360".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Threesixty { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">3d_rotation</i> &#x2014; material icon named "3d rotation".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Threedrotation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">4k</i> &#x2014; material icon named "4k".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fourk { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">ac_unit</i> &#x2014; material icon named "ac unit".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Acunit { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">access_alarm</i> &#x2014; material icon named "access alarm".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessalarm { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">access_alarms</i> &#x2014; material icon named "access alarms".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessalarms { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">access_time</i> &#x2014; material icon named "access time".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accesstime { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">accessibility</i> &#x2014; material icon named "accessibility".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessibility { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">accessibility_new</i> &#x2014; material icon named "accessibility new".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessibilitynew { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">accessible</i> &#x2014; material icon named "accessible".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessible { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">accessible_forward</i> &#x2014; material icon named "accessible forward".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accessibleforward { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">account_balance</i> &#x2014; material icon named "account balance".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accountbalance { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">account_balance_wallet</i> &#x2014; material icon named "account balance wallet".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accountbalancewallet { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">account_box</i> &#x2014; material icon named "account box".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accountbox { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">account_circle</i> &#x2014; material icon named "account circle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Accountcircle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">adb</i> &#x2014; material icon named "adb".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Adb { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add</i> &#x2014; material icon named "add".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Add { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_a_photo</i> &#x2014; material icon named "add a photo".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addaphoto { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_alarm</i> &#x2014; material icon named "add alarm".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addalarm { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_alert</i> &#x2014; material icon named "add alert".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addalert { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_box</i> &#x2014; material icon named "add box".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addbox { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_call</i> &#x2014; material icon named "add call".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addcall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_circle</i> &#x2014; material icon named "add circle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addcircle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_circle_outline</i> &#x2014; material icon named "add circle outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addcircleoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_comment</i> &#x2014; material icon named "add comment".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addcomment { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_location</i> &#x2014; material icon named "add location".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addlocation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_photo_alternate</i> &#x2014; material icon named "add photo alternate".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addphotoalternate { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_shopping_cart</i> &#x2014; material icon named "add shopping cart".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addshoppingcart { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_to_home_screen</i> &#x2014; material icon named "add to home screen".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addtohomescreen { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_to_photos</i> &#x2014; material icon named "add to photos".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addtophotos { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">add_to_queue</i> &#x2014; material icon named "add to queue".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addtoqueue { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">adjust</i> &#x2014; material icon named "adjust".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Adjust { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airline_seat_flat</i> &#x2014; material icon named "airline seat flat".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatflat { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airline_seat_flat_angled</i> &#x2014; material icon named "airline seat flat angled".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatflatangled { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airline_seat_individual_suite</i> &#x2014; material icon named "airline seat individual suite".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatindividualsuite { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airline_seat_legroom_extra</i> &#x2014; material icon named "airline seat legroom extra".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatlegroomextra { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airline_seat_legroom_normal</i> &#x2014; material icon named "airline seat legroom normal".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatlegroomnormal { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airline_seat_legroom_reduced</i> &#x2014; material icon named "airline seat legroom reduced".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatlegroomreduced { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airline_seat_recline_extra</i> &#x2014; material icon named "airline seat recline extra".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatreclineextra { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airline_seat_recline_normal</i> &#x2014; material icon named "airline seat recline normal".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airlineseatreclinenormal { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airplanemode_active</i> &#x2014; material icon named "airplanemode active".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airplanemodeactive { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airplanemode_inactive</i> &#x2014; material icon named "airplanemode inactive".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airplanemodeinactive { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airplay</i> &#x2014; material icon named "airplay".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airplay { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">airport_shuttle</i> &#x2014; material icon named "airport shuttle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Airportshuttle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">alarm</i> &#x2014; material icon named "alarm".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Alarm { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">alarm_add</i> &#x2014; material icon named "alarm add".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Alarmadd { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">alarm_off</i> &#x2014; material icon named "alarm off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Alarmoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">alarm_on</i> &#x2014; material icon named "alarm on".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Alarmon { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">album</i> &#x2014; material icon named "album".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Album { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">all_inclusive</i> &#x2014; material icon named "all inclusive".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Allinclusive { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">all_out</i> &#x2014; material icon named "all out".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Allout { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">alternate_email</i> &#x2014; material icon named "alternate email".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Alternateemail { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">android</i> &#x2014; material icon named "android".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Android { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">announcement</i> &#x2014; material icon named "announcement".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Announcement { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">apps</i> &#x2014; material icon named "apps".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Apps { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">archive</i> &#x2014; material icon named "archive".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Archive { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_back</i> &#x2014; material icon named "arrow back".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowback { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_back_ios</i> &#x2014; material icon named "arrow back ios".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowbackios { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_downward</i> &#x2014; material icon named "arrow downward".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowdownward { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_drop_down</i> &#x2014; material icon named "arrow drop down".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowdropdown { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_drop_down_circle</i> &#x2014; material icon named "arrow drop down circle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowdropdowncircle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_drop_up</i> &#x2014; material icon named "arrow drop up".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowdropup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_forward</i> &#x2014; material icon named "arrow forward".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowforward { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_forward_ios</i> &#x2014; material icon named "arrow forward ios".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowforwardios { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_left</i> &#x2014; material icon named "arrow left".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowleft { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_right</i> &#x2014; material icon named "arrow right".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowright { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">arrow_upward</i> &#x2014; material icon named "arrow upward".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arrowupward { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">art_track</i> &#x2014; material icon named "art track".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Arttrack { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">aspect_ratio</i> &#x2014; material icon named "aspect ratio".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Aspectratio { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">assessment</i> &#x2014; material icon named "assessment".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Assessment { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">assignment</i> &#x2014; material icon named "assignment".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignment { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">assignment_ind</i> &#x2014; material icon named "assignment ind".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignmentind { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">assignment_late</i> &#x2014; material icon named "assignment late".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignmentlate { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">assignment_return</i> &#x2014; material icon named "assignment return".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignmentreturn { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">assignment_returned</i> &#x2014; material icon named "assignment returned".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignmentreturned { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">assignment_turned_in</i> &#x2014; material icon named "assignment turned in".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Assignmentturnedin { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">assistant</i> &#x2014; material icon named "assistant".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Assistant { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">assistant_photo</i> &#x2014; material icon named "assistant photo".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Assistantphoto { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">atm</i> &#x2014; material icon named "atm".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Atm { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">attach_file</i> &#x2014; material icon named "attach file".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Attachfile { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">attach_money</i> &#x2014; material icon named "attach money".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Attachmoney { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">attachment</i> &#x2014; material icon named "attachment".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Attachment { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">audiotrack</i> &#x2014; material icon named "audiotrack".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Audiotrack { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">autorenew</i> &#x2014; material icon named "autorenew".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Autorenew { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">av_timer</i> &#x2014; material icon named "av timer".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Avtimer { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">backspace</i> &#x2014; material icon named "backspace".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Backspace { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">backup</i> &#x2014; material icon named "backup".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Backup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">battery_alert</i> &#x2014; material icon named "battery alert".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Batteryalert { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">battery_charging_full</i> &#x2014; material icon named "battery charging full".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Batterychargingfull { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">battery_full</i> &#x2014; material icon named "battery full".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Batteryfull { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">battery_std</i> &#x2014; material icon named "battery std".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Batterystd { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">battery_unknown</i> &#x2014; material icon named "battery unknown".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Batteryunknown { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">beach_access</i> &#x2014; material icon named "beach access".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Beachaccess { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">beenhere</i> &#x2014; material icon named "beenhere".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Beenhere { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">block</i> &#x2014; material icon named "block".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Block { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">bluetooth</i> &#x2014; material icon named "bluetooth".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetooth { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">bluetooth_audio</i> &#x2014; material icon named "bluetooth audio".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetoothaudio { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">bluetooth_connected</i> &#x2014; material icon named "bluetooth connected".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetoothconnected { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">bluetooth_disabled</i> &#x2014; material icon named "bluetooth disabled".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetoothdisabled { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">bluetooth_searching</i> &#x2014; material icon named "bluetooth searching".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetoothsearching { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">blur_circular</i> &#x2014; material icon named "blur circular".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Blurcircular { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">blur_linear</i> &#x2014; material icon named "blur linear".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Blurlinear { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">blur_off</i> &#x2014; material icon named "blur off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluroff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">blur_on</i> &#x2014; material icon named "blur on".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluron { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">book</i> &#x2014; material icon named "book".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Book { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">bookmark</i> &#x2014; material icon named "bookmark".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bookmark { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">bookmark_border</i> &#x2014; material icon named "bookmark border".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bookmarkborder { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_all</i> &#x2014; material icon named "border all".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_bottom</i> &#x2014; material icon named "border bottom".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderbottom { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_clear</i> &#x2014; material icon named "border clear".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderclear { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_color</i> &#x2014; material icon named "border color".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bordercolor { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_horizontal</i> &#x2014; material icon named "border horizontal".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderhorizontal { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_inner</i> &#x2014; material icon named "border inner".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderinner { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_left</i> &#x2014; material icon named "border left".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderleft { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_outer</i> &#x2014; material icon named "border outer".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderouter { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_right</i> &#x2014; material icon named "border right".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderright { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_style</i> &#x2014; material icon named "border style".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Borderstyle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_top</i> &#x2014; material icon named "border top".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bordertop { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">border_vertical</i> &#x2014; material icon named "border vertical".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bordervertical { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">branding_watermark</i> &#x2014; material icon named "branding watermark".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brandingwatermark { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_1</i> &#x2014; material icon named "brightness 1".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness1 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_2</i> &#x2014; material icon named "brightness 2".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness2 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_3</i> &#x2014; material icon named "brightness 3".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness3 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_4</i> &#x2014; material icon named "brightness 4".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness4 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_5</i> &#x2014; material icon named "brightness 5".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness5 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_6</i> &#x2014; material icon named "brightness 6".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness6 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_7</i> &#x2014; material icon named "brightness 7".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness7 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_auto</i> &#x2014; material icon named "brightness auto".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightnessauto { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_high</i> &#x2014; material icon named "brightness high".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightnesshigh { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_low</i> &#x2014; material icon named "brightness low".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightnesslow { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brightness_medium</i> &#x2014; material icon named "brightness medium".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightnessmedium { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">broken_image</i> &#x2014; material icon named "broken image".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brokenimage { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">brush</i> &#x2014; material icon named "brush".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brush { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">bubble_chart</i> &#x2014; material icon named "bubble chart".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bubblechart { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">bug_report</i> &#x2014; material icon named "bug report".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bugreport { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">build</i> &#x2014; material icon named "build".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Build { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">burst_mode</i> &#x2014; material icon named "burst mode".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Burstmode { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">business</i> &#x2014; material icon named "business".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Business { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">business_center</i> &#x2014; material icon named "business center".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Businesscenter { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cached</i> &#x2014; material icon named "cached".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cached { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cake</i> &#x2014; material icon named "cake".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cake { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">calendar_today</i> &#x2014; material icon named "calendar today".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Calendartoday { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">calendar_view_day</i> &#x2014; material icon named "calendar view day".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Calendarviewday { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">call</i> &#x2014; material icon named "call".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Call { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">call_end</i> &#x2014; material icon named "call end".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Callend { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">call_made</i> &#x2014; material icon named "call made".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Callmade { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">call_merge</i> &#x2014; material icon named "call merge".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Callmerge { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">call_missed</i> &#x2014; material icon named "call missed".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Callmissed { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">call_missed_outgoing</i> &#x2014; material icon named "call missed outgoing".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Callmissedoutgoing { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">call_received</i> &#x2014; material icon named "call received".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Callreceived { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">call_split</i> &#x2014; material icon named "call split".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Callsplit { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">call_to_action</i> &#x2014; material icon named "call to action".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Calltoaction { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">camera</i> &#x2014; material icon named "camera".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Camera { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">camera_alt</i> &#x2014; material icon named "camera alt".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cameraalt { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">camera_enhance</i> &#x2014; material icon named "camera enhance".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cameraenhance { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">camera_front</i> &#x2014; material icon named "camera front".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Camerafront { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">camera_rear</i> &#x2014; material icon named "camera rear".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Camerarear { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">camera_roll</i> &#x2014; material icon named "camera roll".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cameraroll { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cancel</i> &#x2014; material icon named "cancel".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cancel { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">card_giftcard</i> &#x2014; material icon named "card giftcard".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cardgiftcard { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">card_membership</i> &#x2014; material icon named "card membership".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cardmembership { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">card_travel</i> &#x2014; material icon named "card travel".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cardtravel { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">casino</i> &#x2014; material icon named "casino".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Casino { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cast</i> &#x2014; material icon named "cast".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cast { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cast_connected</i> &#x2014; material icon named "cast connected".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Castconnected { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">category</i> &#x2014; material icon named "category".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Category { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">center_focus_strong</i> &#x2014; material icon named "center focus strong".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Centerfocusstrong { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">center_focus_weak</i> &#x2014; material icon named "center focus weak".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Centerfocusweak { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">change_history</i> &#x2014; material icon named "change history".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Changehistory { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">chat</i> &#x2014; material icon named "chat".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Chat { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">chat_bubble</i> &#x2014; material icon named "chat bubble".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Chatbubble { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">chat_bubble_outline</i> &#x2014; material icon named "chat bubble outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Chatbubbleoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">check</i> &#x2014; material icon named "check".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Check { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">check_box</i> &#x2014; material icon named "check box".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkbox { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">check_box_outline_blank</i> &#x2014; material icon named "check box outline blank".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkboxoutlineblank { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">check_circle</i> &#x2014; material icon named "check circle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkcircle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">check_circle_outline</i> &#x2014; material icon named "check circle outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkcircleoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">chevron_left</i> &#x2014; material icon named "chevron left".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Chevronleft { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">chevron_right</i> &#x2014; material icon named "chevron right".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Chevronright { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">child_care</i> &#x2014; material icon named "child care".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Childcare { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">child_friendly</i> &#x2014; material icon named "child friendly".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Childfriendly { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">chrome_reader_mode</i> &#x2014; material icon named "chrome reader mode".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Chromereadermode { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">class</i> &#x2014; material icon named "class".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Class { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">clear</i> &#x2014; material icon named "clear".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clear { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">clear_all</i> &#x2014; material icon named "clear all".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clearall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">close</i> &#x2014; material icon named "close".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Close { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">closed_caption</i> &#x2014; material icon named "closed caption".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Closedcaption { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cloud</i> &#x2014; material icon named "cloud".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cloud { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cloud_circle</i> &#x2014; material icon named "cloud circle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cloudcircle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cloud_done</i> &#x2014; material icon named "cloud done".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clouddone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cloud_download</i> &#x2014; material icon named "cloud download".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clouddownload { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cloud_off</i> &#x2014; material icon named "cloud off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cloudoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cloud_queue</i> &#x2014; material icon named "cloud queue".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cloudqueue { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">cloud_upload</i> &#x2014; material icon named "cloud upload".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cloudupload { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">code</i> &#x2014; material icon named "code".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Code { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">collections</i> &#x2014; material icon named "collections".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Collections { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">collections_bookmark</i> &#x2014; material icon named "collections bookmark".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Collectionsbookmark { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">color_lens</i> &#x2014; material icon named "color lens".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Colorlens { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">colorize</i> &#x2014; material icon named "colorize".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Colorize { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">comment</i> &#x2014; material icon named "comment".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Comment { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">compare</i> &#x2014; material icon named "compare".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Compare { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">compare_arrows</i> &#x2014; material icon named "compare arrows".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Comparearrows { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">computer</i> &#x2014; material icon named "computer".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Computer { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">confirmation_number</i> &#x2014; material icon named "confirmation number".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Confirmationnumber { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">contact_mail</i> &#x2014; material icon named "contact mail".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Contactmail { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">contact_phone</i> &#x2014; material icon named "contact phone".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Contactphone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">contacts</i> &#x2014; material icon named "contacts".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Contacts { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">content_copy</i> &#x2014; material icon named "content copy".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Contentcopy { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">content_cut</i> &#x2014; material icon named "content cut".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Contentcut { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">content_paste</i> &#x2014; material icon named "content paste".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Contentpaste { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">control_point</i> &#x2014; material icon named "control point".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Controlpoint { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">control_point_duplicate</i> &#x2014; material icon named "control point duplicate".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Controlpointduplicate { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">copyright</i> &#x2014; material icon named "copyright".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Copyright { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">create</i> &#x2014; material icon named "create".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Create { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">create_new_folder</i> &#x2014; material icon named "create new folder".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Createnewfolder { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">credit_card</i> &#x2014; material icon named "credit card".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Creditcard { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop</i> &#x2014; material icon named "crop".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Crop { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_16_9</i> &#x2014; material icon named "crop 16 9".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Crop169 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_3_2</i> &#x2014; material icon named "crop 3 2".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Crop32 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_5_4</i> &#x2014; material icon named "crop 5 4".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Crop54 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_7_5</i> &#x2014; material icon named "crop 7 5".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Crop75 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_din</i> &#x2014; material icon named "crop din".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cropdin { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_free</i> &#x2014; material icon named "crop free".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cropfree { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_landscape</i> &#x2014; material icon named "crop landscape".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Croplandscape { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_original</i> &#x2014; material icon named "crop original".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Croporiginal { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_portrait</i> &#x2014; material icon named "crop portrait".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cropportrait { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_rotate</i> &#x2014; material icon named "crop rotate".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Croprotate { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">crop_square</i> &#x2014; material icon named "crop square".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cropsquare { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">dashboard</i> &#x2014; material icon named "dashboard".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Dashboard { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">data_usage</i> &#x2014; material icon named "data usage".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Datausage { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">date_range</i> &#x2014; material icon named "date range".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Daterange { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">dehaze</i> &#x2014; material icon named "dehaze".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Dehaze { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">delete</i> &#x2014; material icon named "delete".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Delete { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">delete_forever</i> &#x2014; material icon named "delete forever".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Deleteforever { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">delete_outline</i> &#x2014; material icon named "delete outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Deleteoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">delete_sweep</i> &#x2014; material icon named "delete sweep".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Deletesweep { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">departure_board</i> &#x2014; material icon named "departure board".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Departureboard { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">description</i> &#x2014; material icon named "description".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Description { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">desktop_mac</i> &#x2014; material icon named "desktop mac".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Desktopmac { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">desktop_windows</i> &#x2014; material icon named "desktop windows".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Desktopwindows { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">details</i> &#x2014; material icon named "details".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Details { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">developer_board</i> &#x2014; material icon named "developer board".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Developerboard { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">developer_mode</i> &#x2014; material icon named "developer mode".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Developermode { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">device_hub</i> &#x2014; material icon named "device hub".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Devicehub { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">device_unknown</i> &#x2014; material icon named "device unknown".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Deviceunknown { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">devices</i> &#x2014; material icon named "devices".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Devices { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">devices_other</i> &#x2014; material icon named "devices other".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Devicesother { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">dialer_sip</i> &#x2014; material icon named "dialer sip".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Dialersip { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">dialpad</i> &#x2014; material icon named "dialpad".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Dialpad { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">directions</i> &#x2014; material icon named "directions".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Directions { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">directions_bike</i> &#x2014; material icon named "directions bike".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionsbike { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">directions_boat</i> &#x2014; material icon named "directions boat".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionsboat { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">directions_bus</i> &#x2014; material icon named "directions bus".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionsbus { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">directions_car</i> &#x2014; material icon named "directions car".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionscar { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">directions_railway</i> &#x2014; material icon named "directions railway".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionsrailway { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">directions_run</i> &#x2014; material icon named "directions run".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionsrun { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">directions_subway</i> &#x2014; material icon named "directions subway".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionssubway { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">directions_transit</i> &#x2014; material icon named "directions transit".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionstransit { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">directions_walk</i> &#x2014; material icon named "directions walk".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Directionswalk { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">disc_full</i> &#x2014; material icon named "disc full".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Discfull { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">dns</i> &#x2014; material icon named "dns".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Dns { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">do_not_disturb</i> &#x2014; material icon named "do not disturb".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Donotdisturb { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">do_not_disturb_alt</i> &#x2014; material icon named "do not disturb alt".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Donotdisturbalt { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">do_not_disturb_off</i> &#x2014; material icon named "do not disturb off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Donotdisturboff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">do_not_disturb_on</i> &#x2014; material icon named "do not disturb on".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Donotdisturbon { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">dock</i> &#x2014; material icon named "dock".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Dock { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">domain</i> &#x2014; material icon named "domain".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Domain { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">done</i> &#x2014; material icon named "done".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Done { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">done_all</i> &#x2014; material icon named "done all".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Doneall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">done_outline</i> &#x2014; material icon named "done outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Doneoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">donut_large</i> &#x2014; material icon named "donut large".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Donutlarge { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">donut_small</i> &#x2014; material icon named "donut small".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Donutsmall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">drafts</i> &#x2014; material icon named "drafts".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Drafts { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">drag_handle</i> &#x2014; material icon named "drag handle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Draghandle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">drive_eta</i> &#x2014; material icon named "drive eta".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Driveeta { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">dvr</i> &#x2014; material icon named "dvr".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Dvr { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">edit</i> &#x2014; material icon named "edit".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Edit { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">edit_attributes</i> &#x2014; material icon named "edit attributes".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Editattributes { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">edit_location</i> &#x2014; material icon named "edit location".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Editlocation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">eject</i> &#x2014; material icon named "eject".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Eject { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">email</i> &#x2014; material icon named "email".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Email { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">enhanced_encryption</i> &#x2014; material icon named "enhanced encryption".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Enhancedencryption { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">equalizer</i> &#x2014; material icon named "equalizer".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Equalizer { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">error</i> &#x2014; material icon named "error".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Error { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">error_outline</i> &#x2014; material icon named "error outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Erroroutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">euro_symbol</i> &#x2014; material icon named "euro symbol".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Eurosymbol { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">ev_station</i> &#x2014; material icon named "ev station".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Evstation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">event</i> &#x2014; material icon named "event".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData @event { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">event_available</i> &#x2014; material icon named "event available".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Eventavailable { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">event_busy</i> &#x2014; material icon named "event busy".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Eventbusy { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">event_note</i> &#x2014; material icon named "event note".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Eventnote { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">event_seat</i> &#x2014; material icon named "event seat".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Eventseat { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">exit_to_app</i> &#x2014; material icon named "exit to app".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Exittoapp { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">expand_less</i> &#x2014; material icon named "expand less".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Expandless { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">expand_more</i> &#x2014; material icon named "expand more".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Expandmore { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">explicit</i> &#x2014; material icon named "explicit".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Explicit { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">explore</i> &#x2014; material icon named "explore".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Explore { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">exposure</i> &#x2014; material icon named "exposure".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposure { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">exposure_neg_1</i> &#x2014; material icon named "exposure neg 1".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposureneg1 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">exposure_neg_2</i> &#x2014; material icon named "exposure neg 2".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposureneg2 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">exposure_plus_1</i> &#x2014; material icon named "exposure plus 1".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposureplus1 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">exposure_plus_2</i> &#x2014; material icon named "exposure plus 2".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposureplus2 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">exposure_zero</i> &#x2014; material icon named "exposure zero".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Exposurezero { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">extension</i> &#x2014; material icon named "extension".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Extension { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">face</i> &#x2014; material icon named "face".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Face { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fast_forward</i> &#x2014; material icon named "fast forward".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fastforward { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fast_rewind</i> &#x2014; material icon named "fast rewind".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fastrewind { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fastfood</i> &#x2014; material icon named "fastfood".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fastfood { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">favorite</i> &#x2014; material icon named "favorite".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Favorite { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">favorite_border</i> &#x2014; material icon named "favorite border".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Favoriteborder { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">featured_play_list</i> &#x2014; material icon named "featured play list".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Featuredplaylist { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">featured_video</i> &#x2014; material icon named "featured video".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Featuredvideo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">feedback</i> &#x2014; material icon named "feedback".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Feedback { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fiber_dvr</i> &#x2014; material icon named "fiber dvr".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fiberdvr { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fiber_manual_record</i> &#x2014; material icon named "fiber manual record".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fibermanualrecord { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fiber_new</i> &#x2014; material icon named "fiber new".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fibernew { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fiber_pin</i> &#x2014; material icon named "fiber pin".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fiberpin { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fiber_smart_record</i> &#x2014; material icon named "fiber smart record".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fibersmartrecord { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">file_download</i> &#x2014; material icon named "file download".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filedownload { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">file_upload</i> &#x2014; material icon named "file upload".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fileupload { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter</i> &#x2014; material icon named "filter".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_1</i> &#x2014; material icon named "filter 1".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter1 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_2</i> &#x2014; material icon named "filter 2".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter2 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_3</i> &#x2014; material icon named "filter 3".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter3 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_4</i> &#x2014; material icon named "filter 4".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter4 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_5</i> &#x2014; material icon named "filter 5".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter5 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_6</i> &#x2014; material icon named "filter 6".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter6 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_7</i> &#x2014; material icon named "filter 7".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter7 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_8</i> &#x2014; material icon named "filter 8".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter8 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_9</i> &#x2014; material icon named "filter 9".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter9 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_9_plus</i> &#x2014; material icon named "filter 9 plus".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filter9plus { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_b_and_w</i> &#x2014; material icon named "filter b and w".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filterbandw { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_center_focus</i> &#x2014; material icon named "filter center focus".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filtercenterfocus { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_drama</i> &#x2014; material icon named "filter drama".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filterdrama { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_frames</i> &#x2014; material icon named "filter frames".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filterframes { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_hdr</i> &#x2014; material icon named "filter hdr".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filterhdr { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_list</i> &#x2014; material icon named "filter list".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filterlist { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_none</i> &#x2014; material icon named "filter none".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filternone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_tilt_shift</i> &#x2014; material icon named "filter tilt shift".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filtertiltshift { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">filter_vintage</i> &#x2014; material icon named "filter vintage".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Filtervintage { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">find_in_page</i> &#x2014; material icon named "find in page".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Findinpage { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">find_replace</i> &#x2014; material icon named "find replace".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Findreplace { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fingerprint</i> &#x2014; material icon named "fingerprint".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fingerprint { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">first_page</i> &#x2014; material icon named "first page".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Firstpage { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fitness_center</i> &#x2014; material icon named "fitness center".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fitnesscenter { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flag</i> &#x2014; material icon named "flag".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Flag { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flare</i> &#x2014; material icon named "flare".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Flare { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flash_auto</i> &#x2014; material icon named "flash auto".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Flashauto { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flash_off</i> &#x2014; material icon named "flash off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Flashoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flash_on</i> &#x2014; material icon named "flash on".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Flashon { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flight</i> &#x2014; material icon named "flight".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Flight { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flight_land</i> &#x2014; material icon named "flight land".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Flightland { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flight_takeoff</i> &#x2014; material icon named "flight takeoff".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Flighttakeoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flip</i> &#x2014; material icon named "flip".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Flip { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flip_to_back</i> &#x2014; material icon named "flip to back".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fliptoback { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">flip_to_front</i> &#x2014; material icon named "flip to front".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fliptofront { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">folder</i> &#x2014; material icon named "folder".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Folder { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">folder_open</i> &#x2014; material icon named "folder open".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Folderopen { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">folder_shared</i> &#x2014; material icon named "folder shared".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Foldershared { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">folder_special</i> &#x2014; material icon named "folder special".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Folderspecial { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">font_download</i> &#x2014; material icon named "font download".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fontdownload { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_align_center</i> &#x2014; material icon named "format align center".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formataligncenter { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_align_justify</i> &#x2014; material icon named "format align justify".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatalignjustify { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_align_left</i> &#x2014; material icon named "format align left".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatalignleft { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_align_right</i> &#x2014; material icon named "format align right".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatalignright { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_bold</i> &#x2014; material icon named "format bold".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatbold { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_clear</i> &#x2014; material icon named "format clear".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatclear { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_color_fill</i> &#x2014; material icon named "format color fill".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatcolorfill { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_color_reset</i> &#x2014; material icon named "format color reset".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatcolorreset { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_color_text</i> &#x2014; material icon named "format color text".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatcolortext { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_indent_decrease</i> &#x2014; material icon named "format indent decrease".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatindentdecrease { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_indent_increase</i> &#x2014; material icon named "format indent increase".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatindentincrease { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_italic</i> &#x2014; material icon named "format italic".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatitalic { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_line_spacing</i> &#x2014; material icon named "format line spacing".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatlinespacing { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_list_bulleted</i> &#x2014; material icon named "format list bulleted".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatlistbulleted { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_list_numbered</i> &#x2014; material icon named "format list numbered".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatlistnumbered { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_list_numbered_rtl</i> &#x2014; material icon named "format list numbered rtl".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatlistnumberedrtl { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_paint</i> &#x2014; material icon named "format paint".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatpaint { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_quote</i> &#x2014; material icon named "format quote".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatquote { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_shapes</i> &#x2014; material icon named "format shapes".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatshapes { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_size</i> &#x2014; material icon named "format size".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatsize { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_strikethrough</i> &#x2014; material icon named "format strikethrough".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatstrikethrough { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_textdirection_l_to_r</i> &#x2014; material icon named "format textdirection l to r".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formattextdirectionltor { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_textdirection_r_to_l</i> &#x2014; material icon named "format textdirection r to l".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formattextdirectionrtol { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">format_underlined</i> &#x2014; material icon named "format underlined".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Formatunderlined { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">forum</i> &#x2014; material icon named "forum".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Forum { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">forward</i> &#x2014; material icon named "forward".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Forward { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">forward_10</i> &#x2014; material icon named "forward 10".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Forward10 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">forward_30</i> &#x2014; material icon named "forward 30".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Forward30 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">forward_5</i> &#x2014; material icon named "forward 5".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Forward5 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">free_breakfast</i> &#x2014; material icon named "free breakfast".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Freebreakfast { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fullscreen</i> &#x2014; material icon named "fullscreen".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fullscreen { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">fullscreen_exit</i> &#x2014; material icon named "fullscreen exit".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fullscreenexit { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">functions</i> &#x2014; material icon named "functions".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Functions { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">g_translate</i> &#x2014; material icon named "g translate".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gtranslate { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">gamepad</i> &#x2014; material icon named "gamepad".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gamepad { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">games</i> &#x2014; material icon named "games".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Games { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">gavel</i> &#x2014; material icon named "gavel".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gavel { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">gesture</i> &#x2014; material icon named "gesture".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gesture { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">get_app</i> &#x2014; material icon named "get app".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Getapp { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">gif</i> &#x2014; material icon named "gif".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gif { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">golf_course</i> &#x2014; material icon named "golf course".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Golfcourse { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">gps_fixed</i> &#x2014; material icon named "gps fixed".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gpsfixed { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">gps_not_fixed</i> &#x2014; material icon named "gps not fixed".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gpsnotfixed { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">gps_off</i> &#x2014; material icon named "gps off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gpsoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">grade</i> &#x2014; material icon named "grade".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Grade { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">gradient</i> &#x2014; material icon named "gradient".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gradient { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">grain</i> &#x2014; material icon named "grain".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Grain { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">graphic_eq</i> &#x2014; material icon named "graphic eq".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Graphiceq { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">grid_off</i> &#x2014; material icon named "grid off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gridoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">grid_on</i> &#x2014; material icon named "grid on".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gridon { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">group</i> &#x2014; material icon named "group".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Group { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">group_add</i> &#x2014; material icon named "group add".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Groupadd { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">group_work</i> &#x2014; material icon named "group work".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Groupwork { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">hd</i> &#x2014; material icon named "hd".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Hd { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">hdr_off</i> &#x2014; material icon named "hdr off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Hdroff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">hdr_on</i> &#x2014; material icon named "hdr on".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Hdron { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">hdr_strong</i> &#x2014; material icon named "hdr strong".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Hdrstrong { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">hdr_weak</i> &#x2014; material icon named "hdr weak".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Hdrweak { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">headset</i> &#x2014; material icon named "headset".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Headset { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">headset_mic</i> &#x2014; material icon named "headset mic".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Headsetmic { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">headset_off</i> &#x2014; material icon named "headset off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Headsetoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">healing</i> &#x2014; material icon named "healing".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Healing { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">hearing</i> &#x2014; material icon named "hearing".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Hearing { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">help</i> &#x2014; material icon named "help".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Help { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">help_outline</i> &#x2014; material icon named "help outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Helpoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">high_quality</i> &#x2014; material icon named "high quality".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Highquality { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">highlight</i> &#x2014; material icon named "highlight".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Highlight { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">highlight_off</i> &#x2014; material icon named "highlight off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Highlightoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">history</i> &#x2014; material icon named "history".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData History { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">home</i> &#x2014; material icon named "home".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Home { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">hot_tub</i> &#x2014; material icon named "hot tub".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Hottub { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">hotel</i> &#x2014; material icon named "hotel".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Hotel { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">hourglass_empty</i> &#x2014; material icon named "hourglass empty".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Hourglassempty { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">hourglass_full</i> &#x2014; material icon named "hourglass full".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Hourglassfull { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">http</i> &#x2014; material icon named "http".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Http { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">https</i> &#x2014; material icon named "https".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Https { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">image</i> &#x2014; material icon named "image".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Image { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">image_aspect_ratio</i> &#x2014; material icon named "image aspect ratio".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Imageaspectratio { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">import_contacts</i> &#x2014; material icon named "import contacts".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Importcontacts { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">import_export</i> &#x2014; material icon named "import export".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Importexport { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">important_devices</i> &#x2014; material icon named "important devices".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Importantdevices { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">inbox</i> &#x2014; material icon named "inbox".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Inbox { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">indeterminate_check_box</i> &#x2014; material icon named "indeterminate check box".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Indeterminatecheckbox { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">info</i> &#x2014; material icon named "info".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Info { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">info_outline</i> &#x2014; material icon named "info outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Infooutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">input</i> &#x2014; material icon named "input".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Input { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">insert_chart</i> &#x2014; material icon named "insert chart".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertchart { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">insert_comment</i> &#x2014; material icon named "insert comment".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertcomment { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">insert_drive_file</i> &#x2014; material icon named "insert drive file".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertdrivefile { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">insert_emoticon</i> &#x2014; material icon named "insert emoticon".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertemoticon { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">insert_invitation</i> &#x2014; material icon named "insert invitation".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertinvitation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">insert_link</i> &#x2014; material icon named "insert link".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertlink { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">insert_photo</i> &#x2014; material icon named "insert photo".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Insertphoto { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">invert_colors</i> &#x2014; material icon named "invert colors".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Invertcolors { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">invert_colors_off</i> &#x2014; material icon named "invert colors off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Invertcolorsoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">iso</i> &#x2014; material icon named "iso".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Iso { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard</i> &#x2014; material icon named "keyboard".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboard { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard_arrow_down</i> &#x2014; material icon named "keyboard arrow down".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardarrowdown { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard_arrow_left</i> &#x2014; material icon named "keyboard arrow left".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardarrowleft { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard_arrow_right</i> &#x2014; material icon named "keyboard arrow right".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardarrowright { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard_arrow_up</i> &#x2014; material icon named "keyboard arrow up".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardarrowup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard_backspace</i> &#x2014; material icon named "keyboard backspace".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardbackspace { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard_capslock</i> &#x2014; material icon named "keyboard capslock".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardcapslock { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard_hide</i> &#x2014; material icon named "keyboard hide".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardhide { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard_return</i> &#x2014; material icon named "keyboard return".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardreturn { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard_tab</i> &#x2014; material icon named "keyboard tab".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardtab { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">keyboard_voice</i> &#x2014; material icon named "keyboard voice".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Keyboardvoice { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">kitchen</i> &#x2014; material icon named "kitchen".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Kitchen { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">label</i> &#x2014; material icon named "label".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Label { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">label_important</i> &#x2014; material icon named "label important".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Labelimportant { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">label_outline</i> &#x2014; material icon named "label outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Labeloutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">landscape</i> &#x2014; material icon named "landscape".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Landscape { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">language</i> &#x2014; material icon named "language".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Language { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">laptop</i> &#x2014; material icon named "laptop".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Laptop { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">laptop_chromebook</i> &#x2014; material icon named "laptop chromebook".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Laptopchromebook { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">laptop_mac</i> &#x2014; material icon named "laptop mac".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Laptopmac { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">laptop_windows</i> &#x2014; material icon named "laptop windows".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Laptopwindows { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">last_page</i> &#x2014; material icon named "last page".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Lastpage { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">launch</i> &#x2014; material icon named "launch".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Launch { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">layers</i> &#x2014; material icon named "layers".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Layers { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">layers_clear</i> &#x2014; material icon named "layers clear".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Layersclear { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">leak_add</i> &#x2014; material icon named "leak add".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Leakadd { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">leak_remove</i> &#x2014; material icon named "leak remove".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Leakremove { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">lens</i> &#x2014; material icon named "lens".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Lens { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">library_add</i> &#x2014; material icon named "library add".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Libraryadd { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">library_books</i> &#x2014; material icon named "library books".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Librarybooks { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">library_music</i> &#x2014; material icon named "library music".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Librarymusic { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">lightbulb_outline</i> &#x2014; material icon named "lightbulb outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Lightbulboutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">line_style</i> &#x2014; material icon named "line style".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Linestyle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">line_weight</i> &#x2014; material icon named "line weight".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Lineweight { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">linear_scale</i> &#x2014; material icon named "linear scale".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Linearscale { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">link</i> &#x2014; material icon named "link".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Link { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">link_off</i> &#x2014; material icon named "link off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Linkoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">linked_camera</i> &#x2014; material icon named "linked camera".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Linkedcamera { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">list</i> &#x2014; material icon named "list".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData List { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">live_help</i> &#x2014; material icon named "live help".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Livehelp { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">live_tv</i> &#x2014; material icon named "live tv".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Livetv { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_activity</i> &#x2014; material icon named "local activity".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localactivity { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_airport</i> &#x2014; material icon named "local airport".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localairport { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_atm</i> &#x2014; material icon named "local atm".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localatm { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_bar</i> &#x2014; material icon named "local bar".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localbar { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_cafe</i> &#x2014; material icon named "local cafe".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localcafe { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_car_wash</i> &#x2014; material icon named "local car wash".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localcarwash { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_convenience_store</i> &#x2014; material icon named "local convenience store".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localconveniencestore { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_dining</i> &#x2014; material icon named "local dining".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localdining { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_drink</i> &#x2014; material icon named "local drink".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localdrink { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_florist</i> &#x2014; material icon named "local florist".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localflorist { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_gas_station</i> &#x2014; material icon named "local gas station".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localgasstation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_grocery_store</i> &#x2014; material icon named "local grocery store".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localgrocerystore { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_hospital</i> &#x2014; material icon named "local hospital".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localhospital { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_hotel</i> &#x2014; material icon named "local hotel".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localhotel { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_laundry_service</i> &#x2014; material icon named "local laundry service".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Locallaundryservice { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_library</i> &#x2014; material icon named "local library".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Locallibrary { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_mall</i> &#x2014; material icon named "local mall".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localmall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_movies</i> &#x2014; material icon named "local movies".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localmovies { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_offer</i> &#x2014; material icon named "local offer".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localoffer { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_parking</i> &#x2014; material icon named "local parking".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localparking { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_pharmacy</i> &#x2014; material icon named "local pharmacy".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localpharmacy { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_phone</i> &#x2014; material icon named "local phone".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localphone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_pizza</i> &#x2014; material icon named "local pizza".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localpizza { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_play</i> &#x2014; material icon named "local play".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localplay { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_post_office</i> &#x2014; material icon named "local post office".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localpostoffice { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_printshop</i> &#x2014; material icon named "local printshop".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localprintshop { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_see</i> &#x2014; material icon named "local see".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localsee { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_shipping</i> &#x2014; material icon named "local shipping".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localshipping { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">local_taxi</i> &#x2014; material icon named "local taxi".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Localtaxi { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">location_city</i> &#x2014; material icon named "location city".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationcity { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">location_disabled</i> &#x2014; material icon named "location disabled".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationdisabled { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">location_off</i> &#x2014; material icon named "location off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">location_on</i> &#x2014; material icon named "location on".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationon { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">location_searching</i> &#x2014; material icon named "location searching".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationsearching { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">lock</i> &#x2014; material icon named "lock".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Lock { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">lock_open</i> &#x2014; material icon named "lock open".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Lockopen { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">lock_outline</i> &#x2014; material icon named "lock outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Lockoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">looks</i> &#x2014; material icon named "looks".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Looks { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">looks_3</i> &#x2014; material icon named "looks 3".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Looks3 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">looks_4</i> &#x2014; material icon named "looks 4".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Looks4 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">looks_5</i> &#x2014; material icon named "looks 5".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Looks5 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">looks_6</i> &#x2014; material icon named "looks 6".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Looks6 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">looks_one</i> &#x2014; material icon named "looks one".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Looksone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">looks_two</i> &#x2014; material icon named "looks two".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Lookstwo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">loop</i> &#x2014; material icon named "loop".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Loop { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">loupe</i> &#x2014; material icon named "loupe".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Loupe { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">low_priority</i> &#x2014; material icon named "low priority".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Lowpriority { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">loyalty</i> &#x2014; material icon named "loyalty".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Loyalty { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mail</i> &#x2014; material icon named "mail".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mail { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mail_outline</i> &#x2014; material icon named "mail outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mailoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">map</i> &#x2014; material icon named "map".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Map { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">markunread</i> &#x2014; material icon named "markunread".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Markunread { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">markunread_mailbox</i> &#x2014; material icon named "markunread mailbox".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Markunreadmailbox { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">maximize</i> &#x2014; material icon named "maximize".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Maximize { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">memory</i> &#x2014; material icon named "memory".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Memory { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">menu</i> &#x2014; material icon named "menu".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Menu { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">merge_type</i> &#x2014; material icon named "merge type".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mergetype { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">message</i> &#x2014; material icon named "message".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Message { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mic</i> &#x2014; material icon named "mic".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mic { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mic_none</i> &#x2014; material icon named "mic none".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Micnone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mic_off</i> &#x2014; material icon named "mic off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Micoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">minimize</i> &#x2014; material icon named "minimize".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Minimize { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">missed_video_call</i> &#x2014; material icon named "missed video call".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Missedvideocall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mms</i> &#x2014; material icon named "mms".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mms { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mobile_screen_share</i> &#x2014; material icon named "mobile screen share".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mobilescreenshare { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mode_comment</i> &#x2014; material icon named "mode comment".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Modecomment { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mode_edit</i> &#x2014; material icon named "mode edit".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Modeedit { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">monetization_on</i> &#x2014; material icon named "monetization on".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Monetizationon { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">money_off</i> &#x2014; material icon named "money off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Moneyoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">monochrome_photos</i> &#x2014; material icon named "monochrome photos".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Monochromephotos { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mood</i> &#x2014; material icon named "mood".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mood { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mood_bad</i> &#x2014; material icon named "mood bad".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Moodbad { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">more</i> &#x2014; material icon named "more".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData More { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">more_horiz</i> &#x2014; material icon named "more horiz".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Morehoriz { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">more_vert</i> &#x2014; material icon named "more vert".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Morevert { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">motorcycle</i> &#x2014; material icon named "motorcycle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Motorcycle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">mouse</i> &#x2014; material icon named "mouse".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mouse { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">move_to_inbox</i> &#x2014; material icon named "move to inbox".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Movetoinbox { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">movie</i> &#x2014; material icon named "movie".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Movie { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">movie_creation</i> &#x2014; material icon named "movie creation".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Moviecreation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">movie_filter</i> &#x2014; material icon named "movie filter".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Moviefilter { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">multiline_chart</i> &#x2014; material icon named "multiline chart".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Multilinechart { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">music_note</i> &#x2014; material icon named "music note".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Musicnote { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">music_video</i> &#x2014; material icon named "music video".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Musicvideo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">my_location</i> &#x2014; material icon named "my location".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mylocation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">nature</i> &#x2014; material icon named "nature".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Nature { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">nature_people</i> &#x2014; material icon named "nature people".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Naturepeople { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">navigate_before</i> &#x2014; material icon named "navigate before".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Navigatebefore { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">navigate_next</i> &#x2014; material icon named "navigate next".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Navigatenext { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">navigation</i> &#x2014; material icon named "navigation".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Navigation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">near_me</i> &#x2014; material icon named "near me".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Nearme { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">network_cell</i> &#x2014; material icon named "network cell".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Networkcell { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">network_check</i> &#x2014; material icon named "network check".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Networkcheck { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">network_locked</i> &#x2014; material icon named "network locked".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Networklocked { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">network_wifi</i> &#x2014; material icon named "network wifi".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Networkwifi { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">new_releases</i> &#x2014; material icon named "new releases".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Newreleases { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">next_week</i> &#x2014; material icon named "next week".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Nextweek { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">nfc</i> &#x2014; material icon named "nfc".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Nfc { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">no_encryption</i> &#x2014; material icon named "no encryption".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Noencryption { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">no_sim</i> &#x2014; material icon named "no sim".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Nosim { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">not_interested</i> &#x2014; material icon named "not interested".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Notinterested { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">not_listed_location</i> &#x2014; material icon named "not listed location".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Notlistedlocation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">note</i> &#x2014; material icon named "note".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Note { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">note_add</i> &#x2014; material icon named "note add".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Noteadd { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">notification_important</i> &#x2014; material icon named "notification important".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Notificationimportant { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">notifications</i> &#x2014; material icon named "notifications".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Notifications { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">notifications_active</i> &#x2014; material icon named "notifications active".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Notificationsactive { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">notifications_none</i> &#x2014; material icon named "notifications none".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Notificationsnone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">notifications_off</i> &#x2014; material icon named "notifications off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Notificationsoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">notifications_paused</i> &#x2014; material icon named "notifications paused".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Notificationspaused { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">offline_bolt</i> &#x2014; material icon named "offline bolt".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Offlinebolt { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">offline_pin</i> &#x2014; material icon named "offline pin".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Offlinepin { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">ondemand_video</i> &#x2014; material icon named "ondemand video".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Ondemandvideo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">opacity</i> &#x2014; material icon named "opacity".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Opacity { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">open_in_browser</i> &#x2014; material icon named "open in browser".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Openinbrowser { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">open_in_new</i> &#x2014; material icon named "open in new".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Openinnew { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">open_with</i> &#x2014; material icon named "open with".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Openwith { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">outlined_flag</i> &#x2014; material icon named "outlined flag".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Outlinedflag { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pages</i> &#x2014; material icon named "pages".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pages { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pageview</i> &#x2014; material icon named "pageview".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pageview { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">palette</i> &#x2014; material icon named "palette".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Palette { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pan_tool</i> &#x2014; material icon named "pan tool".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pantool { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">panorama</i> &#x2014; material icon named "panorama".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Panorama { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">panorama_fish_eye</i> &#x2014; material icon named "panorama fish eye".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Panoramafisheye { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">panorama_horizontal</i> &#x2014; material icon named "panorama horizontal".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Panoramahorizontal { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">panorama_vertical</i> &#x2014; material icon named "panorama vertical".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Panoramavertical { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">panorama_wide_angle</i> &#x2014; material icon named "panorama wide angle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Panoramawideangle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">party_mode</i> &#x2014; material icon named "party mode".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Partymode { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pause</i> &#x2014; material icon named "pause".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pause { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pause_circle_filled</i> &#x2014; material icon named "pause circle filled".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pausecirclefilled { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pause_circle_outline</i> &#x2014; material icon named "pause circle outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pausecircleoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">payment</i> &#x2014; material icon named "payment".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Payment { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">people</i> &#x2014; material icon named "people".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData People { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">people_outline</i> &#x2014; material icon named "people outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Peopleoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">perm_camera_mic</i> &#x2014; material icon named "perm camera mic".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Permcameramic { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">perm_contact_calendar</i> &#x2014; material icon named "perm contact calendar".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Permcontactcalendar { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">perm_data_setting</i> &#x2014; material icon named "perm data setting".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Permdatasetting { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">perm_device_information</i> &#x2014; material icon named "perm device information".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Permdeviceinformation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">perm_identity</i> &#x2014; material icon named "perm identity".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Permidentity { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">perm_media</i> &#x2014; material icon named "perm media".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Permmedia { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">perm_phone_msg</i> &#x2014; material icon named "perm phone msg".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Permphonemsg { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">perm_scan_wifi</i> &#x2014; material icon named "perm scan wifi".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Permscanwifi { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">person</i> &#x2014; material icon named "person".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Person { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">person_add</i> &#x2014; material icon named "person add".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Personadd { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">person_outline</i> &#x2014; material icon named "person outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Personoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">person_pin</i> &#x2014; material icon named "person pin".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Personpin { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">person_pin_circle</i> &#x2014; material icon named "person pin circle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Personpincircle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">personal_video</i> &#x2014; material icon named "personal video".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Personalvideo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pets</i> &#x2014; material icon named "pets".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pets { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phone</i> &#x2014; material icon named "phone".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phone_android</i> &#x2014; material icon named "phone android".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phoneandroid { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phone_bluetooth_speaker</i> &#x2014; material icon named "phone bluetooth speaker".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonebluetoothspeaker { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phone_forwarded</i> &#x2014; material icon named "phone forwarded".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phoneforwarded { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phone_in_talk</i> &#x2014; material icon named "phone in talk".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phoneintalk { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phone_iphone</i> &#x2014; material icon named "phone iphone".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phoneiphone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phone_locked</i> &#x2014; material icon named "phone locked".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelocked { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phone_missed</i> &#x2014; material icon named "phone missed".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonemissed { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phone_paused</i> &#x2014; material icon named "phone paused".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonepaused { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phonelink</i> &#x2014; material icon named "phonelink".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelink { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phonelink_erase</i> &#x2014; material icon named "phonelink erase".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelinkerase { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phonelink_lock</i> &#x2014; material icon named "phonelink lock".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelinklock { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phonelink_off</i> &#x2014; material icon named "phonelink off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelinkoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phonelink_ring</i> &#x2014; material icon named "phonelink ring".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelinkring { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">phonelink_setup</i> &#x2014; material icon named "phonelink setup".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonelinksetup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">photo</i> &#x2014; material icon named "photo".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Photo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">photo_album</i> &#x2014; material icon named "photo album".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Photoalbum { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">photo_camera</i> &#x2014; material icon named "photo camera".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Photocamera { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">photo_filter</i> &#x2014; material icon named "photo filter".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Photofilter { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">photo_library</i> &#x2014; material icon named "photo library".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Photolibrary { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">photo_size_select_actual</i> &#x2014; material icon named "photo size select actual".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Photosizeselectactual { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">photo_size_select_large</i> &#x2014; material icon named "photo size select large".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Photosizeselectlarge { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">photo_size_select_small</i> &#x2014; material icon named "photo size select small".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Photosizeselectsmall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">picture_as_pdf</i> &#x2014; material icon named "picture as pdf".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pictureaspdf { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">picture_in_picture</i> &#x2014; material icon named "picture in picture".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pictureinpicture { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">picture_in_picture_alt</i> &#x2014; material icon named "picture in picture alt".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pictureinpicturealt { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pie_chart</i> &#x2014; material icon named "pie chart".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Piechart { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pie_chart_outlined</i> &#x2014; material icon named "pie chart outlined".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Piechartoutlined { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pin_drop</i> &#x2014; material icon named "pin drop".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pindrop { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">place</i> &#x2014; material icon named "place".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Place { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">play_arrow</i> &#x2014; material icon named "play arrow".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Playarrow { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">play_circle_filled</i> &#x2014; material icon named "play circle filled".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Playcirclefilled { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">play_circle_outline</i> &#x2014; material icon named "play circle outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Playcircleoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">play_for_work</i> &#x2014; material icon named "play for work".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Playforwork { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">playlist_add</i> &#x2014; material icon named "playlist add".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Playlistadd { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">playlist_add_check</i> &#x2014; material icon named "playlist add check".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Playlistaddcheck { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">playlist_play</i> &#x2014; material icon named "playlist play".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Playlistplay { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">plus_one</i> &#x2014; material icon named "plus one".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Plusone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">poll</i> &#x2014; material icon named "poll".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Poll { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">polymer</i> &#x2014; material icon named "polymer".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Polymer { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pool</i> &#x2014; material icon named "pool".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pool { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">portable_wifi_off</i> &#x2014; material icon named "portable wifi off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Portablewifioff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">portrait</i> &#x2014; material icon named "portrait".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Portrait { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">power</i> &#x2014; material icon named "power".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Power { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">power_input</i> &#x2014; material icon named "power input".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Powerinput { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">power_settings_new</i> &#x2014; material icon named "power settings new".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Powersettingsnew { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">pregnant_woman</i> &#x2014; material icon named "pregnant woman".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pregnantwoman { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">present_to_all</i> &#x2014; material icon named "present to all".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Presenttoall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">print</i> &#x2014; material icon named "print".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Print { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">priority_high</i> &#x2014; material icon named "priority high".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Priorityhigh { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">public</i> &#x2014; material icon named "public".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Public { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">publish</i> &#x2014; material icon named "publish".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Publish { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">query_builder</i> &#x2014; material icon named "query builder".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Querybuilder { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">question_answer</i> &#x2014; material icon named "question answer".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Questionanswer { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">queue</i> &#x2014; material icon named "queue".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Queue { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">queue_music</i> &#x2014; material icon named "queue music".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Queuemusic { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">queue_play_next</i> &#x2014; material icon named "queue play next".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Queueplaynext { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">radio</i> &#x2014; material icon named "radio".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Radio { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">radio_button_checked</i> &#x2014; material icon named "radio button checked".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Radiobuttonchecked { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">radio_button_unchecked</i> &#x2014; material icon named "radio button unchecked".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Radiobuttonunchecked { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">rate_review</i> &#x2014; material icon named "rate review".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Ratereview { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">receipt</i> &#x2014; material icon named "receipt".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Receipt { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">recent_actors</i> &#x2014; material icon named "recent actors".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Recentactors { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">record_voice_over</i> &#x2014; material icon named "record voice over".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Recordvoiceover { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">redeem</i> &#x2014; material icon named "redeem".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Redeem { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">redo</i> &#x2014; material icon named "redo".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Redo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">refresh</i> &#x2014; material icon named "refresh".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Refresh { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">remove</i> &#x2014; material icon named "remove".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Remove { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">remove_circle</i> &#x2014; material icon named "remove circle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Removecircle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">remove_circle_outline</i> &#x2014; material icon named "remove circle outline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Removecircleoutline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">remove_from_queue</i> &#x2014; material icon named "remove from queue".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Removefromqueue { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">remove_red_eye</i> &#x2014; material icon named "remove red eye".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Removeredeye { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">remove_shopping_cart</i> &#x2014; material icon named "remove shopping cart".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Removeshoppingcart { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">reorder</i> &#x2014; material icon named "reorder".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Reorder { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">repeat</i> &#x2014; material icon named "repeat".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Repeat { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">repeat_one</i> &#x2014; material icon named "repeat one".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Repeatone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">replay</i> &#x2014; material icon named "replay".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Replay { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">replay_10</i> &#x2014; material icon named "replay 10".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Replay10 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">replay_30</i> &#x2014; material icon named "replay 30".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Replay30 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">replay_5</i> &#x2014; material icon named "replay 5".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Replay5 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">reply</i> &#x2014; material icon named "reply".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Reply { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">reply_all</i> &#x2014; material icon named "reply all".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Replyall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">report</i> &#x2014; material icon named "report".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Report { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">report_off</i> &#x2014; material icon named "report off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Reportoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">report_problem</i> &#x2014; material icon named "report problem".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Reportproblem { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">restaurant</i> &#x2014; material icon named "restaurant".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Restaurant { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">restaurant_menu</i> &#x2014; material icon named "restaurant menu".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Restaurantmenu { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">restore</i> &#x2014; material icon named "restore".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Restore { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">restore_from_trash</i> &#x2014; material icon named "restore from trash".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Restorefromtrash { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">restore_page</i> &#x2014; material icon named "restore page".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Restorepage { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">ring_volume</i> &#x2014; material icon named "ring volume".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Ringvolume { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">room</i> &#x2014; material icon named "room".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Room { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">room_service</i> &#x2014; material icon named "room service".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Roomservice { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">rotate_90_degrees_ccw</i> &#x2014; material icon named "rotate 90 degrees ccw".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Rotate90degreesccw { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">rotate_left</i> &#x2014; material icon named "rotate left".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Rotateleft { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">rotate_right</i> &#x2014; material icon named "rotate right".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Rotateright { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">rounded_corner</i> &#x2014; material icon named "rounded corner".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Roundedcorner { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">router</i> &#x2014; material icon named "router".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Router { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">rowing</i> &#x2014; material icon named "rowing".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Rowing { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">rss_feed</i> &#x2014; material icon named "rss feed".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Rssfeed { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">rv_hookup</i> &#x2014; material icon named "rv hookup".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Rvhookup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">satellite</i> &#x2014; material icon named "satellite".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Satellite { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">save</i> &#x2014; material icon named "save".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Save { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">save_alt</i> &#x2014; material icon named "save alt".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Savealt { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">scanner</i> &#x2014; material icon named "scanner".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Scanner { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">scatter_plot</i> &#x2014; material icon named "scatter plot".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Scatterplot { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">schedule</i> &#x2014; material icon named "schedule".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Schedule { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">school</i> &#x2014; material icon named "school".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData School { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">score</i> &#x2014; material icon named "score".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Score { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">screen_lock_landscape</i> &#x2014; material icon named "screen lock landscape".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Screenlocklandscape { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">screen_lock_portrait</i> &#x2014; material icon named "screen lock portrait".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Screenlockportrait { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">screen_lock_rotation</i> &#x2014; material icon named "screen lock rotation".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Screenlockrotation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">screen_rotation</i> &#x2014; material icon named "screen rotation".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Screenrotation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">screen_share</i> &#x2014; material icon named "screen share".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Screenshare { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sd_card</i> &#x2014; material icon named "sd card".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sdcard { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sd_storage</i> &#x2014; material icon named "sd storage".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sdstorage { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">search</i> &#x2014; material icon named "search".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Search { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">security</i> &#x2014; material icon named "security".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Security { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">select_all</i> &#x2014; material icon named "select all".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Selectall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">send</i> &#x2014; material icon named "send".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Send { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sentiment_dissatisfied</i> &#x2014; material icon named "sentiment dissatisfied".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sentimentdissatisfied { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sentiment_neutral</i> &#x2014; material icon named "sentiment neutral".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sentimentneutral { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sentiment_satisfied</i> &#x2014; material icon named "sentiment satisfied".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sentimentsatisfied { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sentiment_very_dissatisfied</i> &#x2014; material icon named "sentiment very dissatisfied".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sentimentverydissatisfied { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sentiment_very_satisfied</i> &#x2014; material icon named "sentiment very satisfied".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sentimentverysatisfied { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings</i> &#x2014; material icon named "settings".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settings { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_applications</i> &#x2014; material icon named "settings applications".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsapplications { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_backup_restore</i> &#x2014; material icon named "settings backup restore".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsbackuprestore { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_bluetooth</i> &#x2014; material icon named "settings bluetooth".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsbluetooth { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_brightness</i> &#x2014; material icon named "settings brightness".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsbrightness { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_cell</i> &#x2014; material icon named "settings cell".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingscell { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_ethernet</i> &#x2014; material icon named "settings ethernet".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsethernet { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_input_antenna</i> &#x2014; material icon named "settings input antenna".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsinputantenna { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_input_component</i> &#x2014; material icon named "settings input component".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsinputcomponent { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_input_composite</i> &#x2014; material icon named "settings input composite".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsinputcomposite { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_input_hdmi</i> &#x2014; material icon named "settings input hdmi".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsinputhdmi { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_input_svideo</i> &#x2014; material icon named "settings input svideo".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsinputsvideo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_overscan</i> &#x2014; material icon named "settings overscan".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsoverscan { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_phone</i> &#x2014; material icon named "settings phone".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsphone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_power</i> &#x2014; material icon named "settings power".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingspower { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_remote</i> &#x2014; material icon named "settings remote".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsremote { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_system_daydream</i> &#x2014; material icon named "settings system daydream".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingssystemdaydream { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">settings_voice</i> &#x2014; material icon named "settings voice".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingsvoice { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">share</i> &#x2014; material icon named "share".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Share { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">shop</i> &#x2014; material icon named "shop".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shop { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">shop_two</i> &#x2014; material icon named "shop two".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shoptwo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">shopping_basket</i> &#x2014; material icon named "shopping basket".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shoppingbasket { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">shopping_cart</i> &#x2014; material icon named "shopping cart".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shoppingcart { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">short_text</i> &#x2014; material icon named "short text".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shorttext { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">show_chart</i> &#x2014; material icon named "show chart".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Showchart { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">shuffle</i> &#x2014; material icon named "shuffle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shuffle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">shutter_speed</i> &#x2014; material icon named "shutter speed".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shutterspeed { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">signal_cellular_4_bar</i> &#x2014; material icon named "signal cellular 4 bar".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalcellular4bar { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">signal_cellular_connected_no_internet_4_bar</i> &#x2014; material icon named "signal cellular connected no internet 4 bar".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalcellularconnectednointernet4bar { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">signal_cellular_no_sim</i> &#x2014; material icon named "signal cellular no sim".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalcellularnosim { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">signal_cellular_null</i> &#x2014; material icon named "signal cellular null".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalcellularnull { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">signal_cellular_off</i> &#x2014; material icon named "signal cellular off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalcellularoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">signal_wifi_4_bar</i> &#x2014; material icon named "signal wifi 4 bar".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalwifi4bar { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">signal_wifi_4_bar_lock</i> &#x2014; material icon named "signal wifi 4 bar lock".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalwifi4barlock { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">signal_wifi_off</i> &#x2014; material icon named "signal wifi off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Signalwifioff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sim_card</i> &#x2014; material icon named "sim card".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Simcard { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sim_card_alert</i> &#x2014; material icon named "sim card alert".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Simcardalert { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">skip_next</i> &#x2014; material icon named "skip next".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Skipnext { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">skip_previous</i> &#x2014; material icon named "skip previous".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Skipprevious { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">slideshow</i> &#x2014; material icon named "slideshow".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Slideshow { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">slow_motion_video</i> &#x2014; material icon named "slow motion video".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Slowmotionvideo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">smartphone</i> &#x2014; material icon named "smartphone".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Smartphone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">smoke_free</i> &#x2014; material icon named "smoke free".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Smokefree { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">smoking_rooms</i> &#x2014; material icon named "smoking rooms".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Smokingrooms { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sms</i> &#x2014; material icon named "sms".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sms { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sms_failed</i> &#x2014; material icon named "sms failed".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Smsfailed { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">snooze</i> &#x2014; material icon named "snooze".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Snooze { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sort</i> &#x2014; material icon named "sort".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sort { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sort_by_alpha</i> &#x2014; material icon named "sort by alpha".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sortbyalpha { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">spa</i> &#x2014; material icon named "spa".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Spa { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">space_bar</i> &#x2014; material icon named "space bar".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Spacebar { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">speaker</i> &#x2014; material icon named "speaker".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Speaker { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">speaker_group</i> &#x2014; material icon named "speaker group".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Speakergroup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">speaker_notes</i> &#x2014; material icon named "speaker notes".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Speakernotes { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">speaker_notes_off</i> &#x2014; material icon named "speaker notes off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Speakernotesoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">speaker_phone</i> &#x2014; material icon named "speaker phone".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Speakerphone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">spellcheck</i> &#x2014; material icon named "spellcheck".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Spellcheck { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">star</i> &#x2014; material icon named "star".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Star { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">star_border</i> &#x2014; material icon named "star border".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Starborder { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">star_half</i> &#x2014; material icon named "star half".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Starhalf { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">stars</i> &#x2014; material icon named "stars".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Stars { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">stay_current_landscape</i> &#x2014; material icon named "stay current landscape".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Staycurrentlandscape { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">stay_current_portrait</i> &#x2014; material icon named "stay current portrait".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Staycurrentportrait { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">stay_primary_landscape</i> &#x2014; material icon named "stay primary landscape".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Stayprimarylandscape { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">stay_primary_portrait</i> &#x2014; material icon named "stay primary portrait".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Stayprimaryportrait { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">stop</i> &#x2014; material icon named "stop".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Stop { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">stop_screen_share</i> &#x2014; material icon named "stop screen share".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Stopscreenshare { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">storage</i> &#x2014; material icon named "storage".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Storage { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">store</i> &#x2014; material icon named "store".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Store { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">store_mall_directory</i> &#x2014; material icon named "store mall directory".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Storemalldirectory { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">straighten</i> &#x2014; material icon named "straighten".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Straighten { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">streetview</i> &#x2014; material icon named "streetview".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Streetview { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">strikethrough_s</i> &#x2014; material icon named "strikethrough s".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Strikethroughs { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">style</i> &#x2014; material icon named "style".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Style { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">subdirectory_arrow_left</i> &#x2014; material icon named "subdirectory arrow left".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Subdirectoryarrowleft { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">subdirectory_arrow_right</i> &#x2014; material icon named "subdirectory arrow right".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Subdirectoryarrowright { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">subject</i> &#x2014; material icon named "subject".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Subject { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">subscriptions</i> &#x2014; material icon named "subscriptions".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Subscriptions { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">subtitles</i> &#x2014; material icon named "subtitles".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Subtitles { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">subway</i> &#x2014; material icon named "subway".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Subway { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">supervised_user_circle</i> &#x2014; material icon named "supervised user circle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Supervisedusercircle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">supervisor_account</i> &#x2014; material icon named "supervisor account".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Supervisoraccount { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">surround_sound</i> &#x2014; material icon named "surround sound".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Surroundsound { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">swap_calls</i> &#x2014; material icon named "swap calls".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Swapcalls { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">swap_horiz</i> &#x2014; material icon named "swap horiz".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Swaphoriz { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">swap_horizontal_circle</i> &#x2014; material icon named "swap horizontal circle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Swaphorizontalcircle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">swap_vert</i> &#x2014; material icon named "swap vert".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Swapvert { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">swap_vertical_circle</i> &#x2014; material icon named "swap vertical circle".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Swapverticalcircle { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">switch_camera</i> &#x2014; material icon named "switch camera".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Switchcamera { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">switch_video</i> &#x2014; material icon named "switch video".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Switchvideo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sync</i> &#x2014; material icon named "sync".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sync { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sync_disabled</i> &#x2014; material icon named "sync disabled".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Syncdisabled { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">sync_problem</i> &#x2014; material icon named "sync problem".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Syncproblem { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">system_update</i> &#x2014; material icon named "system update".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Systemupdate { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">system_update_alt</i> &#x2014; material icon named "system update alt".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Systemupdatealt { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tab</i> &#x2014; material icon named "tab".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tab { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tab_unselected</i> &#x2014; material icon named "tab unselected".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tabunselected { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">table_chart</i> &#x2014; material icon named "table chart".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tablechart { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tablet</i> &#x2014; material icon named "tablet".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tablet { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tablet_android</i> &#x2014; material icon named "tablet android".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tabletandroid { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tablet_mac</i> &#x2014; material icon named "tablet mac".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tabletmac { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tag_faces</i> &#x2014; material icon named "tag faces".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tagfaces { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tap_and_play</i> &#x2014; material icon named "tap and play".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tapandplay { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">terrain</i> &#x2014; material icon named "terrain".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Terrain { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">text_fields</i> &#x2014; material icon named "text fields".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Textfields { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">text_format</i> &#x2014; material icon named "text format".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Textformat { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">text_rotate_up</i> &#x2014; material icon named "text rotate up".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotateup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">text_rotate_vertical</i> &#x2014; material icon named "text rotate vertical".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotatevertical { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">text_rotation_angledown</i> &#x2014; material icon named "text rotation angledown".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotationangledown { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">text_rotation_angleup</i> &#x2014; material icon named "text rotation angleup".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotationangleup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">text_rotation_down</i> &#x2014; material icon named "text rotation down".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotationdown { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">text_rotation_none</i> &#x2014; material icon named "text rotation none".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Textrotationnone { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">textsms</i> &#x2014; material icon named "textsms".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Textsms { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">texture</i> &#x2014; material icon named "texture".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Texture { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">theaters</i> &#x2014; material icon named "theaters".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Theaters { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">thumb_down</i> &#x2014; material icon named "thumb down".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Thumbdown { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">thumb_up</i> &#x2014; material icon named "thumb up".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Thumbup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">thumbs_up_down</i> &#x2014; material icon named "thumbs up down".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Thumbsupdown { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">time_to_leave</i> &#x2014; material icon named "time to leave".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Timetoleave { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">timelapse</i> &#x2014; material icon named "timelapse".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Timelapse { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">timeline</i> &#x2014; material icon named "timeline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Timeline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">timer</i> &#x2014; material icon named "timer".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Timer { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">timer_10</i> &#x2014; material icon named "timer 10".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Timer10 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">timer_3</i> &#x2014; material icon named "timer 3".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Timer3 { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">timer_off</i> &#x2014; material icon named "timer off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Timeroff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">title</i> &#x2014; material icon named "title".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Title { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">toc</i> &#x2014; material icon named "toc".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Toc { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">today</i> &#x2014; material icon named "today".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Today { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">toll</i> &#x2014; material icon named "toll".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Toll { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tonality</i> &#x2014; material icon named "tonality".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tonality { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">touch_app</i> &#x2014; material icon named "touch app".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Touchapp { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">toys</i> &#x2014; material icon named "toys".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Toys { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">track_changes</i> &#x2014; material icon named "track changes".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Trackchanges { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">traffic</i> &#x2014; material icon named "traffic".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Traffic { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">train</i> &#x2014; material icon named "train".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Train { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tram</i> &#x2014; material icon named "tram".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tram { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">transfer_within_a_station</i> &#x2014; material icon named "transfer within a station".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Transferwithinastation { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">transform</i> &#x2014; material icon named "transform".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Transform { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">transit_enterexit</i> &#x2014; material icon named "transit enterexit".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Transitenterexit { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">translate</i> &#x2014; material icon named "translate".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Translate { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">trending_down</i> &#x2014; material icon named "trending down".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Trendingdown { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">trending_flat</i> &#x2014; material icon named "trending flat".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Trendingflat { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">trending_up</i> &#x2014; material icon named "trending up".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Trendingup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">trip_origin</i> &#x2014; material icon named "trip origin".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Triporigin { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tune</i> &#x2014; material icon named "tune".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tune { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">turned_in</i> &#x2014; material icon named "turned in".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Turnedin { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">turned_in_not</i> &#x2014; material icon named "turned in not".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Turnedinnot { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">tv</i> &#x2014; material icon named "tv".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tv { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">unarchive</i> &#x2014; material icon named "unarchive".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Unarchive { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">undo</i> &#x2014; material icon named "undo".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Undo { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">unfold_less</i> &#x2014; material icon named "unfold less".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Unfoldless { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">unfold_more</i> &#x2014; material icon named "unfold more".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Unfoldmore { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">update</i> &#x2014; material icon named "update".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Update { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">usb</i> &#x2014; material icon named "usb".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Usb { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">verified_user</i> &#x2014; material icon named "verified user".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Verifieduser { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">vertical_align_bottom</i> &#x2014; material icon named "vertical align bottom".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Verticalalignbottom { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">vertical_align_center</i> &#x2014; material icon named "vertical align center".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Verticalaligncenter { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">vertical_align_top</i> &#x2014; material icon named "vertical align top".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Verticalaligntop { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">vibration</i> &#x2014; material icon named "vibration".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Vibration { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">video_call</i> &#x2014; material icon named "video call".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Videocall { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">video_label</i> &#x2014; material icon named "video label".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Videolabel { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">video_library</i> &#x2014; material icon named "video library".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Videolibrary { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">videocam</i> &#x2014; material icon named "videocam".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Videocam { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">videocam_off</i> &#x2014; material icon named "videocam off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Videocamoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">videogame_asset</i> &#x2014; material icon named "videogame asset".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Videogameasset { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_agenda</i> &#x2014; material icon named "view agenda".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewagenda { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_array</i> &#x2014; material icon named "view array".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewarray { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_carousel</i> &#x2014; material icon named "view carousel".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewcarousel { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_column</i> &#x2014; material icon named "view column".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewcolumn { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_comfy</i> &#x2014; material icon named "view comfy".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewcomfy { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_compact</i> &#x2014; material icon named "view compact".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewcompact { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_day</i> &#x2014; material icon named "view day".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewday { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_headline</i> &#x2014; material icon named "view headline".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewheadline { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_list</i> &#x2014; material icon named "view list".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewlist { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_module</i> &#x2014; material icon named "view module".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewmodule { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_quilt</i> &#x2014; material icon named "view quilt".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewquilt { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_stream</i> &#x2014; material icon named "view stream".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewstream { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">view_week</i> &#x2014; material icon named "view week".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Viewweek { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">vignette</i> &#x2014; material icon named "vignette".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Vignette { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">visibility</i> &#x2014; material icon named "visibility".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Visibility { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">visibility_off</i> &#x2014; material icon named "visibility off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Visibilityoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">voice_chat</i> &#x2014; material icon named "voice chat".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Voicechat { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">voicemail</i> &#x2014; material icon named "voicemail".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Voicemail { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">volume_down</i> &#x2014; material icon named "volume down".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumedown { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">volume_mute</i> &#x2014; material icon named "volume mute".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumemute { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">volume_off</i> &#x2014; material icon named "volume off".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumeoff { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">volume_up</i> &#x2014; material icon named "volume up".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumeup { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">vpn_key</i> &#x2014; material icon named "vpn key".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Vpnkey { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">vpn_lock</i> &#x2014; material icon named "vpn lock".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Vpnlock { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wallpaper</i> &#x2014; material icon named "wallpaper".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wallpaper { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">warning</i> &#x2014; material icon named "warning".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Warning { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">watch</i> &#x2014; material icon named "watch".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Watch { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">watch_later</i> &#x2014; material icon named "watch later".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Watchlater { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wb_auto</i> &#x2014; material icon named "wb auto".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wbauto { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wb_cloudy</i> &#x2014; material icon named "wb cloudy".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wbcloudy { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wb_incandescent</i> &#x2014; material icon named "wb incandescent".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wbincandescent { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wb_iridescent</i> &#x2014; material icon named "wb iridescent".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wbiridescent { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wb_sunny</i> &#x2014; material icon named "wb sunny".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wbsunny { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wc</i> &#x2014; material icon named "wc".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wc { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">web</i> &#x2014; material icon named "web".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Web { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">web_asset</i> &#x2014; material icon named "web asset".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Webasset { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">weekend</i> &#x2014; material icon named "weekend".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Weekend { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">whatshot</i> &#x2014; material icon named "whatshot".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Whatshot { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">widgets</i> &#x2014; material icon named "widgets".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Widgets { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wifi</i> &#x2014; material icon named "wifi".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wifi { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wifi_lock</i> &#x2014; material icon named "wifi lock".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wifilock { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wifi_tethering</i> &#x2014; material icon named "wifi tethering".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wifitethering { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">work</i> &#x2014; material icon named "work".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Work { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">wrap_text</i> &#x2014; material icon named "wrap text".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Wraptext { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">youtube_searched_for</i> &#x2014; material icon named "youtube searched for".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Youtubesearchedfor { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">zoom_in</i> &#x2014; material icon named "zoom in".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Zoomin { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">zoom_out</i> &#x2014; material icon named "zoom out".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Zoomout { get; set; }
        /// <Summary>
        /// <i class="material-icons md-36">zoom_out_map</i> &#x2014; material icon named "zoom out map".
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Zoomoutmap { get; set; }
    }

}
