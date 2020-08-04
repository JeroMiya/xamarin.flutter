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
using FlutterSDK.Material.Button;
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
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
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
namespace FlutterSDK.Material.Flexiblespacebar
{
    internal static class FlexiblespacebarDefaultClass
    {
    }

    /// <Summary>
    /// The part of a material design [AppBar] that expands, collapses, and
    /// stretches.
    ///
    /// Most commonly used in in the [SliverAppBar.flexibleSpace] field, a flexible
    /// space bar expands and contracts as the app scrolls so that the [AppBar]
    /// reaches from the top of the app to the top of the scrolling contents of the
    /// app. Furthermore is included functionality for stretch behavior. When
    /// [SliverAppBar.stretch] is true, and your [ScrollPhysics] allow for
    /// overscroll, this space will stretch with the overscroll.
    ///
    /// The widget that sizes the [AppBar] must wrap it in the widget returned by
    /// [FlexibleSpaceBar.createSettings], to convey sizing information down to the
    /// [FlexibleSpaceBar].
    ///
    /// {@tool dartpad --template=freeform}
    /// This sample application demonstrates the different features of the
    /// [FlexibleSpaceBar] when used in a [SliverAppBar]. This app bar is configured
    /// to stretch into the overscroll space, and uses the
    /// [FlexibleSpaceBar.stretchModes] to apply `fadeTitle`, `blurBackground` and
    /// `zoomBackground`. The app bar also makes use of [CollapseMode.parallax] by
    /// default.
    ///
    /// ```dart imports
    /// import 'package:flutter/material.dart';
    /// ```
    /// ```dart
    /// void main() => runApp(MaterialApp(home: MyApp()));
    ///
    /// class MyApp extends StatelessWidget {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Scaffold(
    ///       body: CustomScrollView(
    ///         physics: const BouncingScrollPhysics(),
    ///         slivers: <Widget>[
    ///           SliverAppBar(
    ///             stretch: true,
    ///             onStretchTrigger: () {
    ///               // Function callback for stretch
    ///               return;
    ///             },
    ///             expandedHeight: 300.0,
    ///             flexibleSpace: FlexibleSpaceBar(
    ///               stretchModes: <StretchMode>[
    ///                 StretchMode.zoomBackground,
    ///                 StretchMode.blurBackground,
    ///                 StretchMode.fadeTitle,
    ///               ],
    ///               centerTitle: true,
    ///               title: const Text('Flight Report'),
    ///               background: Stack(
    ///                 fit: StackFit.expand,
    ///                 children: [
    ///                   Image.network(
    ///                     'https://flutter.github.io/assets-for-api-docs/assets/widgets/owl-2.jpg',
    ///                     fit: BoxFit.cover,
    ///                   ),
    ///                   const DecoratedBox(
    ///                     decoration: BoxDecoration(
    ///                       gradient: LinearGradient(
    ///                         begin: Alignment(0.0, 0.5),
    ///                         end: Alignment(0.0, 0.0),
    ///                         colors: <Color>[
    ///                           Color(0x60000000),
    ///                           Color(0x00000000),
    ///                         ],
    ///                       ),
    ///                     ),
    ///                   ),
    ///                 ],
    ///               ),
    ///             ),
    ///           ),
    ///           SliverList(
    ///             delegate: SliverChildListDelegate([
    ///               ListTile(
    ///                 leading: Icon(Icons.wb_sunny),
    ///                 title: Text('Sunday'),
    ///                 subtitle: Text('sunny, h: 80, l: 65'),
    ///               ),
    ///               ListTile(
    ///                 leading: Icon(Icons.wb_sunny),
    ///                 title: Text('Monday'),
    ///                 subtitle: Text('sunny, h: 80, l: 65'),
    ///               ),
    ///               // ListTiles++
    ///             ]),
    ///           ),
    ///         ],
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [SliverAppBar], which implements the expanding and contracting.
    ///  * [AppBar], which is used by [SliverAppBar].
    ///  * <https://material.io/design/components/app-bars-top.html#behavior>
    /// </Summary>
    public class FlexibleSpaceBar : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates a flexible space bar.
        ///
        /// Most commonly used in the [AppBar.flexibleSpace] field.
        /// </Summary>
        public FlexibleSpaceBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget background = default(FlutterSDK.Widgets.Framework.Widget), bool centerTitle = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry titlePadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Flexiblespacebar.CollapseMode collapseMode = default(FlutterSDK.Material.Flexiblespacebar.CollapseMode), List<FlutterSDK.Material.Flexiblespacebar.StretchMode> stretchModes = default(List<FlutterSDK.Material.Flexiblespacebar.StretchMode>))
        : base(key: key)
        {
            this.Title = title;
            this.Background = background;
            this.CenterTitle = centerTitle;
            this.TitlePadding = titlePadding;
            this.CollapseMode = collapseMode;
            this.StretchModes = stretchModes;
        }
        /// <Summary>
        /// The primary contents of the flexible space bar when expanded.
        ///
        /// Typically a [Text] widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        /// <Summary>
        /// Shown behind the [title] when expanded.
        ///
        /// Typically an [Image] widget with [Image.fit] set to [BoxFit.cover].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Background { get; set; }
        /// <Summary>
        /// Whether the title should be centered.
        ///
        /// By default this property is true if the current target platform
        /// is [TargetPlatform.iOS] or [TargetPlatform.macOS], false otherwise.
        /// </Summary>
        public virtual bool CenterTitle { get; set; }
        /// <Summary>
        /// Collapse effect while scrolling.
        ///
        /// Defaults to [CollapseMode.parallax].
        /// </Summary>
        public virtual FlutterSDK.Material.Flexiblespacebar.CollapseMode CollapseMode { get; set; }
        /// <Summary>
        /// Stretch effect while over-scrolling,
        ///
        /// Defaults to include [StretchMode.zoomBackground].
        /// </Summary>
        public virtual List<FlutterSDK.Material.Flexiblespacebar.StretchMode> StretchModes { get; set; }
        /// <Summary>
        /// Defines how far the [title] is inset from either the widget's
        /// bottom-left or its center.
        ///
        /// Typically this property is used to adjust how far the title is
        /// is inset from the bottom-left and it is specified along with
        /// [centerTitle] false.
        ///
        /// By default the value of this property is
        /// `EdgeInsetsDirectional.only(start: 72, bottom: 16)` if the title is
        /// not centered, `EdgeInsetsDirectional.only(start: 0, bottom: 16)` otherwise.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry TitlePadding { get; set; }

        /// <Summary>
        /// Wraps a widget that contains an [AppBar] to convey sizing information down
        /// to the [FlexibleSpaceBar].
        ///
        /// Used by [Scaffold] and [SliverAppBar].
        ///
        /// `toolbarOpacity` affects how transparent the text within the toolbar
        /// appears. `minExtent` sets the minimum height of the resulting
        /// [FlexibleSpaceBar] when fully collapsed. `maxExtent` sets the maximum
        /// height of the resulting [FlexibleSpaceBar] when fully expanded.
        /// `currentExtent` sets the scale of the [FlexibleSpaceBar.background] and
        /// [FlexibleSpaceBar.title] widgets of [FlexibleSpaceBar] upon
        /// initialization.
        ///
        /// See also:
        ///
        ///  * [FlexibleSpaceBarSettings] which creates a settings object that can be
        ///    used to specify these settings to a [FlexibleSpaceBar].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget CreateSettings(double toolbarOpacity = default(double), double minExtent = default(double), double maxExtent = default(double), double currentExtent = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {

            return new FlexibleSpaceBarSettings(toolbarOpacity: toolbarOpacity == default(double) ? 1.0 : toolbarOpacity, minExtent: minExtent == default(double) ? currentExtent : minExtent, maxExtent: maxExtent == default(double) ? currentExtent : maxExtent, currentExtent: currentExtent, child: child);
        }




        public new FlutterSDK.Material.Flexiblespacebar._FlexibleSpaceBarState CreateState() => new _FlexibleSpaceBarState();


    }


    public class _FlexibleSpaceBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Flexiblespacebar.FlexibleSpaceBar>
    {
        public _FlexibleSpaceBarState()
        { }

        private bool _GetEffectiveCenterTitle(FlutterSDK.Material.Themedata.ThemeData theme)
        {
            if (Widget.CenterTitle != null) return Widget.CenterTitle;

            switch (theme.Platform) { case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: return false; case TargetPlatform.IOS: case TargetPlatform.MacOS: return true; }
            return null;
        }




        private FlutterSDK.Painting.Alignment.Alignment _GetTitleAlignment(bool effectiveCenterTitle)
        {
            if (effectiveCenterTitle) return AlignmentDefaultClass.Alignment.BottomCenter;
            TextDirection textDirection = BasicDefaultClass.Directionality.Of(Context);

            switch (textDirection) { case TextDirection.Rtl: return AlignmentDefaultClass.Alignment.BottomRight; case TextDirection.Ltr: return AlignmentDefaultClass.Alignment.BottomLeft; }
            return null;
        }




        private double _GetCollapsePadding(double t, FlutterSDK.Material.Flexiblespacebar.FlexibleSpaceBarSettings settings)
        {
            switch (Widget.CollapseMode) { case CollapseMode.Pin: return -(settings.MaxExtent - settings.CurrentExtent); case CollapseMode.None: return 0.0; case CollapseMode.Parallax: double deltaExtent = settings.MaxExtent - settings.MinExtent; return -new Tween<double>(begin: 0.0, end: deltaExtent / 4.0).Transform(t); }
            return null;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new LayoutBuilder(builder: (BuildContext context, BoxConstraints constraints) =>
            {
                FlexibleSpaceBarSettings settings = context.DependOnInheritedWidgetOfExactType();

                List<Widget> children = new List<Widget>() { };
                double deltaExtent = settings.MaxExtent - settings.MinExtent;
                double t = (1.0 - (settings.CurrentExtent - settings.MinExtent) / deltaExtent).Clamp(0.0, 1.0) as double;
                if (Widget.Background != null)
                {
                    double fadeStart = Dart.Math.MathDefaultClass.Max(0.0, 1.0 - ConstantsDefaultClass.KToolbarHeight / deltaExtent);
                    double fadeEnd = 1.0;

                    double opacity = 1.0 - new Interval(fadeStart, fadeEnd).Transform(t);
                    if (opacity > 0.0)
                    {
                        double height = settings.MaxExtent;
                        if (Widget.StretchModes.Contains(StretchMode.ZoomBackground) && constraints.MaxHeight > height)
                        {
                            height = constraints.MaxHeight;
                        }

                        children.Add(new Positioned(top: _GetCollapsePadding(t, settings), left: 0.0, right: 0.0, height: height, child: new Opacity(opacity: opacity, child: Widget.Background)));
                        if (Widget.StretchModes.Contains(StretchMode.BlurBackground) && constraints.MaxHeight > settings.MaxExtent)
                        {
                            double blurAmount = (constraints.MaxHeight - settings.MaxExtent) / 10;
                            children.Add(Positioned.Fill(child: new BackdropFilter(child: new Container(color: ColorsDefaultClass.Colors.Transparent), filter: Dart.UI.ImageFilter.Blur(sigmaX: blurAmount, sigmaY: blurAmount))));
                        }

                    }

                }

                if (Widget.Title != null)
                {
                    ThemeData theme = ThemeDefaultClass.Theme.Of(context);
                    Widget title = default(Widget);
                    switch (theme.Platform) { case TargetPlatform.IOS: case TargetPlatform.MacOS: title = Widget.Title; break; case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: title = new Semantics(namesRoute: true, child: Widget.Title); break; }
                    if (Widget.StretchModes.Contains(StretchMode.FadeTitle) && constraints.MaxHeight > settings.MaxExtent)
                    {
                        double stretchOpacity = 1 - (((constraints.MaxHeight - settings.MaxExtent) / 100).Clamp(0.0, 1.0) as double);
                        title = new Opacity(opacity: stretchOpacity, child: title);
                    }

                    double opacity = settings.ToolbarOpacity;
                    if (opacity > 0.0)
                    {
                        TextStyle titleStyle = theme.PrimaryTextTheme.Headline6;
                        titleStyle = titleStyle.CopyWith(color: titleStyle.Color.WithOpacity(opacity));
                        bool effectiveCenterTitle = _GetEffectiveCenterTitle(theme);
                        EdgeInsetsGeometry padding = Widget.TitlePadding ?? EdgeInsetsDirectional.Only(start: effectiveCenterTitle ? 0.0 : 72.0, bottom: 16.0);
                        double scaleValue = new Tween<double>(begin: 1.5, end: 1.0).Transform(t);
                        Matrix4 scaleTransform = Matrix4.Identity();
                        Matrix4.Identity().Scale(scaleValue, scaleValue, 1.0);
                        Alignment titleAlignment = _GetTitleAlignment(effectiveCenterTitle);
                        children.Add(new Container(padding: padding, child: new Transform(alignment: titleAlignment, transform: scaleTransform, child: new Align(alignment: titleAlignment, child: new DefaultTextStyle(style: titleStyle, child: new LayoutBuilder(builder: (BuildContext context, BoxConstraints constraints) =>
                        {
                            return new Container(width: constraints.MaxWidth / scaleValue, alignment: titleAlignment, child: title);
                        }
                        ))))));
                    }

                }

                return new ClipRect(child: new Stack(children: children));
            }
            );
        }



    }


    /// <Summary>
    /// Provides sizing and opacity information to a [FlexibleSpaceBar].
    ///
    /// See also:
    ///
    ///  * [FlexibleSpaceBar] which creates a flexible space bar.
    /// </Summary>
    public class FlexibleSpaceBarSettings : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        /// <Summary>
        /// Creates a Flexible Space Bar Settings widget.
        ///
        /// Used by [Scaffold] and [SliverAppBar]. [child] must have a
        /// [FlexibleSpaceBar] widget in its tree for the settings to take affect.
        ///
        /// The required [toolbarOpacity], [minExtent], [maxExtent], [currentExtent],
        /// and [child] parameters must not be null.
        /// </Summary>
        public FlexibleSpaceBarSettings(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double toolbarOpacity = default(double), double minExtent = default(double), double maxExtent = default(double), double currentExtent = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.ToolbarOpacity = toolbarOpacity;
            this.MinExtent = minExtent;
            this.MaxExtent = maxExtent;
            this.CurrentExtent = currentExtent;
        }
        /// <Summary>
        /// Affects how transparent the text within the toolbar appears.
        /// </Summary>
        public virtual double ToolbarOpacity { get; set; }
        /// <Summary>
        /// Minimum height of the resulting [FlexibleSpaceBar] when fully collapsed.
        /// </Summary>
        public virtual double MinExtent { get; set; }
        /// <Summary>
        /// Maximum height of the resulting [FlexibleSpaceBar] when fully expanded.
        /// </Summary>
        public virtual double MaxExtent { get; set; }
        /// <Summary>
        /// If the [FlexibleSpaceBar.title] or the [FlexibleSpaceBar.background] is
        /// not null, then this value is used to calculate the relative scale of
        /// these elements upon initialization.
        /// </Summary>
        public virtual double CurrentExtent { get; set; }

        public new bool UpdateShouldNotify(FlutterSDK.Material.Flexiblespacebar.FlexibleSpaceBarSettings oldWidget)
        {
            return ToolbarOpacity != oldWidget.ToolbarOpacity || MinExtent != oldWidget.MinExtent || MaxExtent != oldWidget.MaxExtent || CurrentExtent != oldWidget.CurrentExtent;
        }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget)
        {
            return ToolbarOpacity != oldWidget.ToolbarOpacity || MinExtent != oldWidget.MinExtent || MaxExtent != oldWidget.MaxExtent || CurrentExtent != oldWidget.CurrentExtent;
        }



    }


    /// <Summary>
    /// The collapsing effect while the space bar collapses from its full size.
    /// </Summary>
    public enum CollapseMode
    {

        /// <Summary>
        /// The background widget will scroll in a parallax fashion.
        /// </Summary>
        Parallax,
        /// <Summary>
        /// The background widget pin in place until it reaches the min extent.
        /// </Summary>
        Pin,
        /// <Summary>
        /// The background widget will act as normal with no collapsing effect.
        /// </Summary>
        None,
    }


    /// <Summary>
    /// The stretching effect while the space bar stretches beyond its full size.
    /// </Summary>
    public enum StretchMode
    {

        /// <Summary>
        /// The background widget will expand to fill the extra space.
        /// </Summary>
        ZoomBackground,
        /// <Summary>
        /// The background will blur using a [ImageFilter.blur] effect.
        /// </Summary>
        BlurBackground,
        /// <Summary>
        /// The title will fade away as the user over-scrolls.
        /// </Summary>
        FadeTitle,
    }

}
