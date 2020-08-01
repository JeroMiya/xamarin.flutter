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
namespace FlutterSDK.Cupertino.Icons
{
    internal static class IconsDefaultClass
    {
    }

    /// <Summary>
    /// Identifiers for the supported Cupertino icons.
    ///
    /// Use with the [Icon] class to show specific icons.
    ///
    /// Icons are identified by their name as listed below.
    ///
    /// To use this class, make sure you add a dependency on `cupertino_icons` in your
    /// project's `pubspec.yaml` file. This ensures that the CupertinoIcons font is
    /// included in your application. This font is used to display the icons. For example:
    ///
    /// ```yaml
    /// name: my_awesome_application
    ///
    /// dependencies:
    ///   cupertino_icons: ^0.1.0
    /// ```
    ///
    /// See also:
    ///
    ///  * [Icon], used to show these icons.
    ///  * <https://github.com/flutter/cupertino_icons/blob/master/map.png>, a map of the icons in this icons font.
    /// </Summary>
    public class CupertinoIcons
    {
        internal CupertinoIcons()
        {

        }
        /// <Summary>
        /// The icon font used for Cupertino icons.
        /// </Summary>
        public virtual string IconFont { get; set; }
        /// <Summary>
        /// The dependent package providing the Cupertino icons font.
        /// </Summary>
        public virtual string IconFontPackage { get; set; }
        /// <Summary>
        /// A thin left chevron.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Leftchevron { get; set; }
        /// <Summary>
        /// A thin right chevron.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Rightchevron { get; set; }
        /// <Summary>
        /// iOS style share icon with an arrow pointing up from a box. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [share_solid], which is similar, but filled in.
        ///  * [share_up], for another (pre-iOS 7) version of this icon.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Share { get; set; }
        /// <Summary>
        /// iOS style share icon with an arrow pointing up from a box. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [share], which is similar, but not filled in.
        ///  * [share_up], for another (pre-iOS 7) version of this icon.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Sharesolid { get; set; }
        /// <Summary>
        /// A book silhouette spread open. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [book_solid], which is similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Book { get; set; }
        /// <Summary>
        /// A book silhouette spread open. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [book], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Booksolid { get; set; }
        /// <Summary>
        /// A book silhouette spread open containing a bookmark in the upper right. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [bookmark_solid], which is similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bookmark { get; set; }
        /// <Summary>
        /// A book silhouette spread open containing a bookmark in the upper right. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [bookmark], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bookmarksolid { get; set; }
        /// <Summary>
        /// A letter 'i' in a circle.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Info { get; set; }
        /// <Summary>
        /// A curved up and left pointing arrow.
        ///
        /// For another version of this icon, see [reply_thick_solid].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Reply { get; set; }
        /// <Summary>
        /// A chat bubble.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Conversationbubble { get; set; }
        /// <Summary>
        /// A person's silhouette in a circle.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Profilecircled { get; set; }
        /// <Summary>
        /// A '+' sign in a circle.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pluscircled { get; set; }
        /// <Summary>
        /// A '-' sign in a circle.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Minuscircled { get; set; }
        /// <Summary>
        /// A right facing flag and pole outline.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Flag { get; set; }
        /// <Summary>
        /// A magnifier loop outline.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Search { get; set; }
        /// <Summary>
        /// A checkmark.
        ///
        /// See also:
        ///
        ///  * [check_mark_circled], which consists of this check mark and a circle surrounding it.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkmark { get; set; }
        /// <Summary>
        /// A checkmark in a circle. The circle is not filled in.
        ///
        /// See also:
        ///
        ///  * [check_mark_circled_solid], which is similar, but filled in.
        ///  * [check_mark], which is the check mark without a circle.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkmarkcircled { get; set; }
        /// <Summary>
        /// A checkmark in a circle. The circle is filled in.
        ///
        /// See also:
        ///
        ///  * [check_mark_circled], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Checkmarkcircledsolid { get; set; }
        /// <Summary>
        /// An empty circle (a ring).  An un-selected radio button.
        ///
        /// See also:
        ///
        ///  * [circle_filled], which is similar but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Circle { get; set; }
        /// <Summary>
        /// A filled circle.  The circle is surrounded by a ring.  A selected radio button.
        ///
        /// See also:
        ///
        ///  * [circle], which is similar but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Circlefilled { get; set; }
        /// <Summary>
        /// A thicker left chevron used in iOS for the navigation bar back button.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Back { get; set; }
        /// <Summary>
        /// A thicker right chevron that's the reverse of [back].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Forward { get; set; }
        /// <Summary>
        /// Outline of a simple front-facing house.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Home { get; set; }
        /// <Summary>
        /// A right-facing shopping cart outline.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shoppingcart { get; set; }
        /// <Summary>
        /// Three solid dots.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Ellipsis { get; set; }
        /// <Summary>
        /// A phone handset outline.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phone { get; set; }
        /// <Summary>
        /// A phone handset.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Phonesolid { get; set; }
        /// <Summary>
        /// A solid down arrow.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Downarrow { get; set; }
        /// <Summary>
        /// A solid up arrow.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Uparrow { get; set; }
        /// <Summary>
        /// A charging battery.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Batterycharging { get; set; }
        /// <Summary>
        /// An empty battery.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Batteryempty { get; set; }
        /// <Summary>
        /// A full battery.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Batteryfull { get; set; }
        /// <Summary>
        /// A 75% charged battery.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Battery75percent { get; set; }
        /// <Summary>
        /// A 25% charged battery.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Battery25percent { get; set; }
        /// <Summary>
        /// The Bluetooth logo.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bluetooth { get; set; }
        /// <Summary>
        /// A restart arrow, pointing downwards.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Restart { get; set; }
        /// <Summary>
        /// Two curved up and left pointing arrows.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Replyall { get; set; }
        /// <Summary>
        /// A curved up and left pointing arrow.
        ///
        /// For another version of this icon, see [reply].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Replythicksolid { get; set; }
        /// <Summary>
        /// iOS style share icon with an arrow pointing upwards to the right from a box.
        ///
        /// For another version of this icon (introduced in iOS 7), see [share].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shareup { get; set; }
        /// <Summary>
        /// Two thin right-facing intertwined arrows.
        ///
        /// See also:
        ///
        ///  * [shuffle_medium], with slightly thicker arrows.
        ///  * [shuffle_thick], with thicker, bold arrows.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shuffle { get; set; }
        /// <Summary>
        /// Two medium thickness right-facing intertwined arrows.
        ///
        /// See also:
        ///
        ///  * [shuffle], with thin arrows.
        ///  * [shuffle_thick], with thicker, bold arrows.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shufflemedium { get; set; }
        /// <Summary>
        /// Two thick right-facing intertwined arrows.
        ///
        /// See also:
        ///
        ///  * [shuffle], with thin arrows.
        ///  * [shuffle_medium], with slightly thinner arrows.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Shufflethick { get; set; }
        /// <Summary>
        /// A camera for still photographs. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [photo_camera], which is similar, but not filled in.
        ///  * [video_camera_solid], for the moving picture equivalent.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Photocamera { get; set; }
        /// <Summary>
        /// A camera for still photographs. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [photo_camera_solid], which is similar, but filled in.
        ///  * [video_camera], for the moving picture equivalent.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Photocamerasolid { get; set; }
        /// <Summary>
        /// A camera for moving pictures. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [video_camera_solid], which is similar, but filled in.
        ///  * [photo_camera], for the still photograph equivalent.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Videocamera { get; set; }
        /// <Summary>
        /// A camera for moving pictures. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [video_camera], which is similar, but not filled in.
        ///  * [photo_camera_solid], for the still photograph equivalent.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Videocamerasolid { get; set; }
        /// <Summary>
        /// A camera containing two circular arrows pointing at each other, which indicate switching. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [switch_camera_solid], which is similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Switchcamera { get; set; }
        /// <Summary>
        /// A camera containing two circular arrows pointing at each other, which indicate switching. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [switch_camera], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Switchcamerasolid { get; set; }
        /// <Summary>
        /// A collection of folders, which store collections of files, i.e. an album. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [collections_solid], which is similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Collections { get; set; }
        /// <Summary>
        /// A collection of folders, which store collections of files, i.e. an album. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [collections], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Collectionssolid { get; set; }
        /// <Summary>
        /// A single folder, which stores multiple files. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [folder_solid], which is similar, but filled in.
        ///  * [folder_open], which is the pre-iOS 7 version of this icon.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Folder { get; set; }
        /// <Summary>
        /// A single folder, which stores multiple files. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [folder], which is similar, but not filled in.
        ///  * [folder_open], which is the pre-iOS 7 version of this icon and not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Foldersolid { get; set; }
        /// <Summary>
        /// A single folder that indicates being opened. A folder like this typically stores multiple files.
        ///
        /// See also:
        ///
        ///  * [folder], which is the equivalent of this icon for iOS versions later than or equal to iOS 7.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Folderopen { get; set; }
        /// <Summary>
        /// A trash bin for removing items. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [delete_solid], which is similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Delete { get; set; }
        /// <Summary>
        /// A trash bin for removing items. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [delete], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Deletesolid { get; set; }
        /// <Summary>
        /// A trash bin with minimal detail for removing items.
        ///
        /// See also:
        ///
        ///  * [delete], which is the iOS 7 equivalent of this icon with richer detail.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Deletesimple { get; set; }
        /// <Summary>
        /// A simple pen.
        ///
        /// See also:
        ///
        ///  * [pencil], which is similar, but has less detail and looks like a pencil.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pen { get; set; }
        /// <Summary>
        /// A simple pencil.
        ///
        /// See also:
        ///
        ///  * [pen], which is similar, but has more detail and looks like a pen.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pencil { get; set; }
        /// <Summary>
        /// A box for writing and a pen on top (that indicates the writing). This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [create_solid], which is similar, but filled in.
        ///  * [pencil], which is just a pencil.
        ///  * [pen], which is just a pen.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Create { get; set; }
        /// <Summary>
        /// A box for writing and a pen on top (that indicates the writing). This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [create], which is similar, but not filled in.
        ///  * [pencil], which is just a pencil.
        ///  * [pen], which is just a pen.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Createsolid { get; set; }
        /// <Summary>
        /// An arrow on a circular path with its end pointing at its start.
        ///
        /// See also:
        ///
        ///  * [refresh_circled], which is this icon put in a circle.
        ///  * [refresh_thin], which is an arrow of the same concept, but thinner and with a smaller gap in between its end and start.
        ///  * [refresh_thick], which is similar, but rotated 45 degrees clockwise and thicker.
        ///  * [refresh_bold], which is similar, but rotated 90 degrees clockwise and much thicker.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Refresh { get; set; }
        /// <Summary>
        /// An arrow on a circular path with its end pointing at its start surrounded by a circle. This is icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [refresh_circled_solid], which is similar, but filled in.
        ///  * [refresh], which is the arrow of this icon without a circle.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Refreshcircled { get; set; }
        /// <Summary>
        /// An arrow on a circular path with its end pointing at its start surrounded by a circle. This is icon is filled in.
        ///
        /// See also:
        ///
        ///  * [refresh_circled], which is similar, but not filled in.
        ///  * [refresh], which is the arrow of this icon filled in without a circle.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Refreshcircledsolid { get; set; }
        /// <Summary>
        /// An arrow on a circular path with its end pointing at its start.
        ///
        /// See also:
        ///
        ///  * [refresh], which is an arrow of the same concept, but thicker and with a larger gap in between its end and start.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Refreshthin { get; set; }
        /// <Summary>
        /// An arrow on a circular path with its end pointing at its start.
        ///
        /// See also:
        ///
        ///  * [refresh], which is similar, but rotated 45 degrees anti-clockwise and thinner.
        ///  * [refresh_bold], which is similar, but rotated 45 degrees clockwise and thicker.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Refreshthick { get; set; }
        /// <Summary>
        /// An arrow on a circular path with its end pointing at its start.
        ///
        /// See also:
        ///
        ///  * [refresh_thick], which is similar, but rotated 45 degrees anti-clockwise and thinner.
        ///  * [refresh], which is similar, but rotated 90 degrees anti-clockwise and much thinner.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Refreshbold { get; set; }
        /// <Summary>
        /// A cross of two diagonal lines from edge to edge crossing in an angle of 90 degrees, which is used for dismissal.
        ///
        /// See also:
        ///
        ///  * [clear_circled], which uses this cross as a blank space in a filled out circled.
        ///  * [clear], which uses a thinner cross and is the iOS 7 equivalent of this icon.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clearthick { get; set; }
        /// <Summary>
        /// A cross of two diagonal lines from edge to edge crossing in an angle of 90 degrees, which is used for dismissal, used as a blank space in a circle.
        ///
        /// See also:
        ///
        ///  * [clear], which is equivalent to the cross of this icon without a circle.
        ///  * [clear_circled_solid], which is similar, but uses a thinner cross.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clearthickcircled { get; set; }
        /// <Summary>
        /// A cross of two diagonal lines from edge to edge crossing in an angle of 90 degrees, which is used for dismissal.
        ///
        /// See also:
        ///
        ///  * [clear_circled], which consists of this cross and a circle surrounding it.
        ///  * [clear], which uses a thicker cross and is the pre-iOS 7 equivalent of this icon.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clear { get; set; }
        /// <Summary>
        /// A cross of two diagonal lines from edge to edge crossing in an angle of 90 degrees, which is used for dismissal, surrounded by circle. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [clear_circled_solid], which is similar, but filled in.
        ///  * [clear], which is the standalone cross of this icon.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clearcircled { get; set; }
        /// <Summary>
        /// A cross of two diagonal lines from edge to edge crossing in an angle of 90 degrees, which is used for dismissal, used as a blank space in a circle. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [clear_circled], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clearcircledsolid { get; set; }
        /// <Summary>
        /// Two straight lines, one horizontal and one vertical, meeting in the middle, which is the equivalent of a plus sign.
        ///
        /// See also:
        ///
        ///  * [plus_circled], which is the pre-iOS 7 version of this icon with a thicker cross.
        ///  * [add_circled], which consists of the plus and a circle around it.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Add { get; set; }
        /// <Summary>
        /// Two straight lines, one horizontal and one vertical, meeting in the middle, which is the equivalent of a plus sign, surrounded by a circle. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [plus_circled], which is the pre-iOS 7 version of this icon with a thicker cross and a filled in circle.
        ///  * [add_circled_solid], which is similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addcircled { get; set; }
        /// <Summary>
        /// Two straight lines, one horizontal and one vertical, meeting in the middle, which is the equivalent of a plus sign, surrounded by a circle. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [plus_circled], which is the pre-iOS 7 version of this icon with a thicker cross.
        ///  * [add_circled], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Addcircledsolid { get; set; }
        /// <Summary>
        /// A gear with eight cogs. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [gear_solid], which is similar, but filled in.
        ///  * [gear_big], which is the pre-iOS 7 version of this icon and appears bigger because of fewer and bigger cogs.
        ///  * [settings], which is another cogwheel with a different design.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gear { get; set; }
        /// <Summary>
        /// A gear with eight cogs. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [gear], which is similar, but not filled in.
        ///  * [settings_solid], which is another cogwheel with a different design.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gearsolid { get; set; }
        /// <Summary>
        /// A gear with six cogs.
        ///
        /// See also:
        ///
        ///  * [gear], which is the iOS 7 version of this icon and appears smaller because of more and larger cogs.
        ///  * [settings_solid], which is another cogwheel with a different design.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gearbig { get; set; }
        /// <Summary>
        /// A cogwheel with many cogs and decoration in the middle. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [settings_solid], which is similar, but filled in.
        ///  * [gear], which is another cogwheel with a different design.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settings { get; set; }
        /// <Summary>
        /// A cogwheel with many cogs and decoration in the middle. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [settings], which is similar, but not filled in.
        ///  * [gear_solid], which is another cogwheel with a different design.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Settingssolid { get; set; }
        /// <Summary>
        /// A symbol representing a solid single musical note.
        ///
        /// See also:
        ///
        ///  * [double_music_note], which is similar, but with 2 connected notes.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Musicnote { get; set; }
        /// <Summary>
        /// A symbol representing 2 connected musical notes.
        ///
        /// See also:
        ///
        ///  * [music_note], which is similar, but with a single note.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Doublemusicnote { get; set; }
        /// <Summary>
        /// A triangle facing to the right. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [play_arrow_solid], which is similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Playarrow { get; set; }
        /// <Summary>
        /// A triangle facing to the right. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [play_arrow], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Playarrowsolid { get; set; }
        /// <Summary>
        /// Two vertical rectangles. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [pause_solid], which is similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pause { get; set; }
        /// <Summary>
        /// Two vertical rectangles. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [pause], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pausesolid { get; set; }
        /// <Summary>
        /// The infinity symbol.
        ///
        /// See also:
        ///
        ///  * [loop_thick], which is similar, but thicker.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Loop { get; set; }
        /// <Summary>
        /// The infinity symbol.
        ///
        /// See also:
        ///
        ///  * [loop], which is similar, but thinner.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Loopthick { get; set; }
        /// <Summary>
        /// A speaker with a single small sound wave.
        ///
        /// See also:
        ///
        ///  * [volume_mute], which is similar, but has no sound waves.
        ///  * [volume_off], which is similar, but with an additional larger sound wave and a diagonal line crossing the whole icon.
        ///  * [volume_up], which has an additional larger sound wave next to the small one.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumedown { get; set; }
        /// <Summary>
        /// A speaker symbol.
        ///
        /// See also:
        ///
        ///  * [volume_down], which is similar, but adds a small sound wave.
        ///  * [volume_off], which is similar, but adds a small and a large sound wave and a diagonal line crossing the whole icon.
        ///  * [volume_up], which is similar, but has a small and a large sound wave.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumemute { get; set; }
        /// <Summary>
        /// A speaker with a small and a large sound wave and a diagonal line crossing the whole icon.
        ///
        /// See also:
        ///
        ///  * [volume_down], which is similar, but not crossed out and only has the small wave.
        ///  * [volume_mute], which is similar, but not crossed out.
        ///  * [volume_up], which is the version of this icon that is not crossed out.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumeoff { get; set; }
        /// <Summary>
        /// A speaker with a small and a large sound wave.
        ///
        /// See also:
        ///
        ///  * [volume_down], which is similar, but only has the small sound wave.
        ///  * [volume_mute], which is similar, but has no sound waves.
        ///  * [volume_off], which is the crossed out version of this icon.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Volumeup { get; set; }
        /// <Summary>
        /// All four corners of a square facing inwards.
        ///
        /// See also:
        ///
        ///  * [fullscreen_exit], which is similar, but has the corners facing outwards.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fullscreen { get; set; }
        /// <Summary>
        /// All four corners of a square facing outwards.
        ///
        /// See also:
        ///
        ///  * [fullscreen], which is similar, but has the corners facing inwards.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Fullscreenexit { get; set; }
        /// <Summary>
        /// A filled in microphone with a diagonal line crossing it.
        ///
        /// See also:
        ///
        ///  * [mic], which is similar, but not filled in and without a diagonal line.
        ///  * [mic_solid], which is similar, but without a diagonal line.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Micoff { get; set; }
        /// <Summary>
        /// A microphone.
        ///
        /// See also:
        ///
        ///  * [mic_solid], which is similar, but filled in.
        ///  * [mic_off], which is similar, but filled in and with a diagonal line crossing the icon.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mic { get; set; }
        /// <Summary>
        /// A filled in microphone.
        ///
        /// See also:
        ///
        ///  * [mic], which is similar, but not filled in.
        ///  * [mic_off], which is similar, but with a diagonal line crossing the icon.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Micsolid { get; set; }
        /// <Summary>
        /// A circle with a dotted clock face inside with hands showing 10:30.
        ///
        /// See also:
        ///
        ///  * [clock_solid], which is similar, but filled in.
        ///  * [time], which is similar, but without dots on the clock face.
        ///  * [time_solid], which is similar, but filled in and without dots on the clock face.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clock { get; set; }
        /// <Summary>
        /// A filled in circle with a dotted clock face inside with hands showing 10:30.
        ///
        /// See also:
        ///
        ///  * [clock], which is similar, but not filled in.
        ///  * [time], which is similar, but not filled in and without dots on the clock face.
        ///  * [time_solid], which is similar, but without dots on the clock face.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Clocksolid { get; set; }
        /// <Summary>
        /// A circle with with a 90 degree angle shape in the center, resembling a clock with hands showing 09:00.
        ///
        /// See also:
        ///
        ///  * [time_solid], which is similar, but filled in.
        ///  * [clock], which is similar, but with dots on the clock face.
        ///  * [clock_solid], which is similar, but filled in and with dots on the clock face.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Time { get; set; }
        /// <Summary>
        /// A filled in circle with with a 90 degree angle shape in the center, resembling a clock with hands showing 09:00.
        ///
        /// See also:
        ///
        ///  * [time], which is similar, but not filled in.
        ///  * [clock], which is similar, but not filled in and with dots on the clock face.
        ///  * [clock_solid], which is similar, but with dots on the clock face.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Timesolid { get; set; }
        /// <Summary>
        /// An unlocked padlock.
        ///
        /// See also:
        ///
        ///  * [padlock_solid], which is similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Padlock { get; set; }
        /// <Summary>
        /// An unlocked padlock.
        ///
        /// See also:
        ///
        ///  * [padlock], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Padlocksolid { get; set; }
        /// <Summary>
        /// An open eye.
        ///
        /// See also:
        ///
        ///  * [eye_solid], which is similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Eye { get; set; }
        /// <Summary>
        /// An open eye.
        ///
        /// See also:
        ///
        ///  * [eye], which is similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Eyesolid { get; set; }
        /// <Summary>
        /// A single person. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [person_solid], which is similar, but filled in.
        ///  * [person_add], which has an additional plus sign next to the person.
        ///  * [group], which consists of three people.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Person { get; set; }
        /// <Summary>
        /// A single person. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [person], which is similar, but not filled in.
        ///  * [person_add_solid], which has an additional plus sign next to the person.
        ///  * [group_solid], which consists of three people.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Personsolid { get; set; }
        /// <Summary>
        /// A single person with a plus sign next to it. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [person_add_solid], which is similar, but filled in.
        ///  * [person], which is just the person.
        ///  * [group], which consists of three people.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Personadd { get; set; }
        /// <Summary>
        /// A single person with a plus sign next to it. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [person_add], which is similar, but not filled in.
        ///  * [person_solid], which is just the person.
        ///  * [group_solid], which consists of three people.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Personaddsolid { get; set; }
        /// <Summary>
        /// A group of three people. This icon is not filled in.
        ///
        /// See also:
        ///
        ///  * [group_solid], which is similar, but filled in.
        ///  * [person], which is just a single person.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Group { get; set; }
        /// <Summary>
        /// A group of three people. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [group], which is similar, but not filled in.
        ///  * [person_solid], which is just a single person.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Groupsolid { get; set; }
        /// <Summary>
        /// Outline of a closed mail envelope.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mail { get; set; }
        /// <Summary>
        /// A closed mail envelope. This icon is filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Mailsolid { get; set; }
        /// <Summary>
        /// Outline of a location pin.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Location { get; set; }
        /// <Summary>
        /// A location pin. This icon is filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Locationsolid { get; set; }
        /// <Summary>
        /// Outline of a sticker tag.
        ///
        /// See also:
        ///
        ///  * [tags], similar but with 2 overlapping tags.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tag { get; set; }
        /// <Summary>
        /// A sticker tag. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [tags_solid], similar but with 2 overlapping tags.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tagsolid { get; set; }
        /// <Summary>
        /// Outlines of 2 overlapping sticker tags.
        ///
        /// See also:
        ///
        ///  * [tag], similar but with only one tag.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tags { get; set; }
        /// <Summary>
        /// 2 overlapping sticker tags. This icon is filled in.
        ///
        /// See also:
        ///
        ///  * [tag_solid], similar but with only one tag.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Tagssolid { get; set; }
        /// <Summary>
        /// A filled in bus.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bus { get; set; }
        /// <Summary>
        /// A filled in car.
        ///
        /// See also:
        ///
        ///  * [car_detailed], similar, but a more detailed and realistic representation.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Car { get; set; }
        /// <Summary>
        /// A filled in detailed, realistic car.
        ///
        /// See also:
        ///
        ///  * [car], similar, but a more simple representation.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Cardetailed { get; set; }
        /// <Summary>
        /// A filled in train with a window divided in half and two headlights.
        ///
        /// See also:
        ///
        ///  * [train_style_two], similar, but with a full, undivided window and a single, centered headlight.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Trainstyleone { get; set; }
        /// <Summary>
        /// A filled in train with a window and a single, centered headlight.
        ///
        /// See also:
        ///
        ///  * [train_style_one], similar, but with a with a window divided in half and two headlights.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Trainstyletwo { get; set; }
        /// <Summary>
        /// An outlined paw.
        ///
        /// See also:
        ///
        ///  * [paw_solid], similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Paw { get; set; }
        /// <Summary>
        /// A filled in paw.
        ///
        /// See also:
        ///
        ///  * [paw], similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Pawsolid { get; set; }
        /// <Summary>
        /// An outlined game controller.
        ///
        /// See also:
        ///
        ///  * [game_controller_solid], similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gamecontroller { get; set; }
        /// <Summary>
        /// A filled in game controller.
        ///
        /// See also:
        ///
        ///  * [game_controller], similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Gamecontrollersolid { get; set; }
        /// <Summary>
        /// An outlined lab flask.
        ///
        /// See also:
        ///
        ///  * [lab_flask_solid], similar, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Labflask { get; set; }
        /// <Summary>
        /// A filled in lab flask.
        ///
        /// See also:
        ///
        ///  * [lab_flask], similar, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Labflasksolid { get; set; }
        /// <Summary>
        /// An outlined heart shape. Can be used to indicate like or favorite states.
        ///
        /// See also:
        ///
        ///  * [heart_solid], same shape, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Heart { get; set; }
        /// <Summary>
        /// A filled heart shape. Can be used to indicate like or favorite states.
        ///
        /// See also:
        ///
        ///  * [heart], same shape, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Heartsolid { get; set; }
        /// <Summary>
        /// An outlined bell. Can be used to represent notifications.
        ///
        /// See also:
        ///
        ///  * [bell_solid], same shape, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bell { get; set; }
        /// <Summary>
        /// A filled bell. Can be used represent notifications.
        ///
        /// See also:
        ///
        ///  * [bell], same shape, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Bellsolid { get; set; }
        /// <Summary>
        /// An outlined folded newspaper icon.
        ///
        /// See also:
        ///
        ///  * [news_solid], same shape, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData News { get; set; }
        /// <Summary>
        /// A filled folded newspaper icon.
        ///
        /// See also:
        ///
        ///  * [news], same shape, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Newssolid { get; set; }
        /// <Summary>
        /// A outlined brightness icon.
        ///
        /// See also:
        ///
        ///  * [brightness_solid], same shape, but filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightness { get; set; }
        /// <Summary>
        /// A filled in brightness icon.
        ///
        /// See also:
        ///
        ///  * [brightness], same shape, but not filled in.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Icondata.IconData Brightnesssolid { get; set; }
    }

}
