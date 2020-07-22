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
namespace FlutterSDK.Material.Bottomnavigationbar
{
    internal static class BottomnavigationbarDefaultClass
    {
    }

    /// <Summary>
    /// A material widget that's displayed at the bottom of an app for selecting
    /// among a small number of views, typically between three and five.
    ///
    /// The bottom navigation bar consists of multiple items in the form of
    /// text labels, icons, or both, laid out on top of a piece of material. It
    /// provides quick navigation between the top-level views of an app. For larger
    /// screens, side navigation may be a better fit.
    ///
    /// A bottom navigation bar is usually used in conjunction with a [Scaffold],
    /// where it is provided as the [Scaffold.bottomNavigationBar] argument.
    ///
    /// The bottom navigation bar's [type] changes how its [items] are displayed.
    /// If not specified, then it's automatically set to
    /// [BottomNavigationBarType.fixed] when there are less than four items, and
    /// [BottomNavigationBarType.shifting] otherwise.
    ///
    ///  * [BottomNavigationBarType.fixed], the default when there are less than
    ///    four [items]. The selected item is rendered with the
    ///    [selectedItemColor] if it's non-null, otherwise the theme's
    ///    [ThemeData.primaryColor] is used. If [backgroundColor] is null, The
    ///    navigation bar's background color defaults to the [Material] background
    ///    color, [ThemeData.canvasColor] (essentially opaque white).
    ///  * [BottomNavigationBarType.shifting], the default when there are four
    ///    or more [items]. If [selectedItemColor] is null, all items are rendered
    ///    in white. The navigation bar's background color is the same as the
    ///    [BottomNavigationBarItem.backgroundColor] of the selected item. In this
    ///    case it's assumed that each item will have a different background color
    ///    and that background color will contrast well with white.
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    /// This example shows a [BottomNavigationBar] as it is used within a [Scaffold]
    /// widget. The [BottomNavigationBar] has three [BottomNavigationBarItem]
    /// widgets and the [currentIndex] is set to index 0. The selected item is
    /// amber. The `_onItemTapped` function changes the selected item's index
    /// and displays a corresponding message in the center of the [Scaffold].
    ///
    /// ![A scaffold with a bottom navigation bar containing three bottom navigation
    /// bar items. The first one is selected.](https://flutter.github.io/assets-for-api-docs/assets/material/bottom_navigation_bar.png)
    ///
    /// ```dart
    /// int _selectedIndex = 0;
    /// static const TextStyle optionStyle = TextStyle(fontSize: 30, fontWeight: FontWeight.bold);
    /// static const List<Widget> _widgetOptions = <Widget>[
    ///   Text(
    ///     'Index 0: Home',
    ///     style: optionStyle,
    ///   ),
    ///   Text(
    ///      'Index 1: Business',
    ///      style: optionStyle,
    ///   ),
    ///   Text(
    ///      'Index 2: School',
    ///      style: optionStyle,
    ///   ),
    /// ];
    ///
    /// void _onItemTapped(int index) {
    ///   setState(() {
    ///     _selectedIndex = index;
    ///   });
    /// }
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     appBar: AppBar(
    ///       title: const Text('BottomNavigationBar Sample'),
    ///     ),
    ///     body: Center(
    ///       child: _widgetOptions.elementAt(_selectedIndex),
    ///     ),
    ///     bottomNavigationBar: BottomNavigationBar(
    ///       items: const <BottomNavigationBarItem>[
    ///         BottomNavigationBarItem(
    ///           icon: Icon(Icons.home),
    ///           title: Text('Home'),
    ///         ),
    ///         BottomNavigationBarItem(
    ///           icon: Icon(Icons.business),
    ///           title: Text('Business'),
    ///         ),
    ///         BottomNavigationBarItem(
    ///           icon: Icon(Icons.school),
    ///           title: Text('School'),
    ///         ),
    ///       ],
    ///       currentIndex: _selectedIndex,
    ///       selectedItemColor: Colors.amber[800],
    ///       onTap: _onItemTapped,
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [BottomNavigationBarItem]
    ///  * [Scaffold]
    ///  * <https://material.io/design/components/bottom-navigation.html>
    /// </Summary>
    public class BottomNavigationBar : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public BottomNavigationBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem> items = default(List<FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem>), FlutterSDK.Foundation.Basictypes.ValueChanged<int> onTap = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), int currentIndex = 0, double elevation = 8.0, FlutterSDK.Material.Bottomnavigationbar.BottomNavigationBarType type = default(FlutterSDK.Material.Bottomnavigationbar.BottomNavigationBarType), FlutterBinding.UI.Color fixedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), double iconSize = 24.0, FlutterBinding.UI.Color selectedItemColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color unselectedItemColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Iconthemedata.IconThemeData selectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData unselectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), double selectedFontSize = 14.0, double unselectedFontSize = 12.0, FlutterSDK.Painting.Textstyle.TextStyle selectedLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle unselectedLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool showSelectedLabels = true, bool showUnselectedLabels = default(bool))
        : base(key: key)
        {
            this.Items = items;
            this.OnTap = onTap;
            this.CurrentIndex = currentIndex;
            this.Elevation = elevation;
            this.BackgroundColor = backgroundColor;
            this.IconSize = iconSize;
            this.UnselectedItemColor = unselectedItemColor;
            this.SelectedIconTheme = selectedIconTheme;
            this.UnselectedIconTheme = unselectedIconTheme;
            this.SelectedFontSize = selectedFontSize;
            this.UnselectedFontSize = unselectedFontSize;
            this.SelectedLabelStyle = selectedLabelStyle;
            this.UnselectedLabelStyle = unselectedLabelStyle;
            this.ShowSelectedLabels = showSelectedLabels;
        }
        public virtual List<FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem> Items { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnTap { get; set; }
        public virtual int CurrentIndex { get; set; }
        public virtual double Elevation { get; set; }
        public virtual FlutterSDK.Material.Bottomnavigationbar.BottomNavigationBarType Type { get; set; }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual double IconSize { get; set; }
        public virtual FlutterBinding.UI.Color SelectedItemColor { get; set; }
        public virtual FlutterBinding.UI.Color UnselectedItemColor { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData SelectedIconTheme { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData UnselectedIconTheme { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle SelectedLabelStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle UnselectedLabelStyle { get; set; }
        public virtual double SelectedFontSize { get; set; }
        public virtual double UnselectedFontSize { get; set; }
        public virtual bool ShowUnselectedLabels { get; set; }
        public virtual bool ShowSelectedLabels { get; set; }
        public virtual FlutterBinding.UI.Color FixedColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private FlutterSDK.Material.Bottomnavigationbar.BottomNavigationBarType _Type(FlutterSDK.Material.Bottomnavigationbar.BottomNavigationBarType type, List<FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem> items)
        {
            if (type != null)
            {
                return type;
            }

            return items.Count <= 3 ? BottomNavigationBarType.Fixed : BottomNavigationBarType.Shifting;
        }




        private bool _DefaultShowUnselected(FlutterSDK.Material.Bottomnavigationbar.BottomNavigationBarType type)
        {
            switch (type) { case BottomNavigationBarType.Shifting: return false; case BottomNavigationBarType.Fixed: return true; }

            return false;
        }




        public new FlutterSDK.Material.Bottomnavigationbar._BottomNavigationBarState CreateState() => new _BottomNavigationBarState();


    }


    public class _BottomNavigationTile : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _BottomNavigationTile(FlutterSDK.Material.Bottomnavigationbar.BottomNavigationBarType type, FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem item, FlutterSDK.Animation.Animation.Animation<double> animation, double iconSize, VoidCallback onTap = default(VoidCallback), FlutterSDK.Animation.Tween.ColorTween colorTween = default(FlutterSDK.Animation.Tween.ColorTween), double flex = default(double), bool selected = false, FlutterSDK.Painting.Textstyle.TextStyle selectedLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle unselectedLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Iconthemedata.IconThemeData selectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData unselectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), bool showSelectedLabels = default(bool), bool showUnselectedLabels = default(bool), string indexLabel = default(string))
        : base()
        {
            this.Type = type;
            this.Item = item;
            this.Animation = animation;
            this.IconSize = iconSize;
            this.OnTap = onTap;
            this.ColorTween = colorTween;
            this.Flex = flex;
            this.Selected = selected;
            this.SelectedLabelStyle = selectedLabelStyle;
            this.UnselectedLabelStyle = unselectedLabelStyle;
            this.SelectedIconTheme = selectedIconTheme;
            this.UnselectedIconTheme = unselectedIconTheme;
            this.ShowSelectedLabels = showSelectedLabels;
            this.ShowUnselectedLabels = showUnselectedLabels;
            this.IndexLabel = indexLabel;
        }
        public virtual FlutterSDK.Material.Bottomnavigationbar.BottomNavigationBarType Type { get; set; }
        public virtual FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem Item { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
        public virtual double IconSize { get; set; }
        public virtual VoidCallback OnTap { get; set; }
        public virtual FlutterSDK.Animation.Tween.ColorTween ColorTween { get; set; }
        public virtual double Flex { get; set; }
        public virtual bool Selected { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData SelectedIconTheme { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData UnselectedIconTheme { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle SelectedLabelStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle UnselectedLabelStyle { get; set; }
        public virtual string IndexLabel { get; set; }
        public virtual bool ShowSelectedLabels { get; set; }
        public virtual bool ShowUnselectedLabels { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            int size = default(int);
            double selectedFontSize = SelectedLabelStyle.FontSize;
            double selectedIconSize = SelectedIconTheme?.Size ?? IconSize;
            double unselectedIconSize = UnselectedIconTheme?.Size ?? IconSize;
            double selectedIconDiff = Math.Dart:mathDefaultClass.Max(selectedIconSize - unselectedIconSize, 0);
            double unselectedIconDiff = Math.Dart:mathDefaultClass.Max(unselectedIconSize - selectedIconSize, 0);
            double bottomPadding = default(double);
            double topPadding = default(double);
            if (ShowSelectedLabels && !ShowUnselectedLabels)
            {
                bottomPadding = new Tween<double>(begin: selectedIconDiff / 2.0, end: selectedFontSize / 2.0 - unselectedIconDiff / 2.0).Evaluate(Animation);
                topPadding = new Tween<double>(begin: selectedFontSize + selectedIconDiff / 2.0, end: selectedFontSize / 2.0 - unselectedIconDiff / 2.0).Evaluate(Animation);
            }
            else if (!ShowSelectedLabels && !ShowUnselectedLabels)
            {
                bottomPadding = new Tween<double>(begin: selectedIconDiff / 2.0, end: unselectedIconDiff / 2.0).Evaluate(Animation);
                topPadding = new Tween<double>(begin: selectedFontSize + selectedIconDiff / 2.0, end: selectedFontSize + unselectedIconDiff / 2.0).Evaluate(Animation);
            }
            else
            {
                bottomPadding = new Tween<double>(begin: selectedFontSize / 2.0 + selectedIconDiff / 2.0, end: selectedFontSize / 2.0 + unselectedIconDiff / 2.0).Evaluate(Animation);
                topPadding = new Tween<double>(begin: selectedFontSize / 2.0 + selectedIconDiff / 2.0, end: selectedFontSize / 2.0 + unselectedIconDiff / 2.0).Evaluate(Animation);
            }

            switch (Type) { case BottomNavigationBarType.Fixed: size = 1; break; case BottomNavigationBarType.Shifting: size = (Flex * 1000.0).Round(); break; }
            return new Expanded(flex: size, child: new Semantics(container: true, selected: Selected, child: new Stack(children: new List<Widget>() { new InkResponse(onTap: OnTap, child: new Padding(padding: EdgeInsets.Only(top: topPadding, bottom: bottomPadding), child: new Column(crossAxisAlignment: CrossAxisAlignment.Center, mainAxisAlignment: MainAxisAlignment.SpaceBetween, mainAxisSize: MainAxisSize.Min, children: new List<Widget>() { new _TileIcon(colorTween: ColorTween, animation: Animation, iconSize: IconSize, selected: Selected, item: Item, selectedIconTheme: SelectedIconTheme, unselectedIconTheme: UnselectedIconTheme), new _Label(colorTween: ColorTween, animation: Animation, item: Item, selectedLabelStyle: SelectedLabelStyle, unselectedLabelStyle: UnselectedLabelStyle, showSelectedLabels: ShowSelectedLabels, showUnselectedLabels: ShowUnselectedLabels) }))), new Semantics(label: IndexLabel) })));
        }



    }


    public class _TileIcon : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _TileIcon(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Tween.ColorTween colorTween = default(FlutterSDK.Animation.Tween.ColorTween), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), double iconSize = default(double), bool selected = default(bool), FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem item = default(FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem), FlutterSDK.Widgets.Iconthemedata.IconThemeData selectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData unselectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData))
        : base(key: key)
        {
            this.ColorTween = colorTween;
            this.Animation = animation;
            this.IconSize = iconSize;
            this.Selected = selected;
            this.Item = item;
            this.SelectedIconTheme = selectedIconTheme;
            this.UnselectedIconTheme = unselectedIconTheme;
        }
        public virtual FlutterSDK.Animation.Tween.ColorTween ColorTween { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
        public virtual double IconSize { get; set; }
        public virtual bool Selected { get; set; }
        public virtual FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem Item { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData SelectedIconTheme { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData UnselectedIconTheme { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Color iconColor = ColorTween.Evaluate(Animation);
            IconThemeData defaultIconTheme = new IconThemeData(color: iconColor, size: IconSize);
            IconThemeData iconThemeData = IconthemedataDefaultClass.IconThemeData.Lerp(defaultIconTheme.Merge(UnselectedIconTheme), defaultIconTheme.Merge(SelectedIconTheme), Animation.Value);
            return new Align(alignment: AlignmentDefaultClass.Alignment.TopCenter, heightFactor: 1.0, child: new Container(child: new IconTheme(data: iconThemeData, child: Selected ? Item.ActiveIcon : Item.Icon)));
        }



    }


    public class _Label : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _Label(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Tween.ColorTween colorTween = default(FlutterSDK.Animation.Tween.ColorTween), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem item = default(FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem), FlutterSDK.Painting.Textstyle.TextStyle selectedLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle unselectedLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool showSelectedLabels = default(bool), bool showUnselectedLabels = default(bool))
        : base(key: key)
        {
            this.ColorTween = colorTween;
            this.Animation = animation;
            this.Item = item;
            this.SelectedLabelStyle = selectedLabelStyle;
            this.UnselectedLabelStyle = unselectedLabelStyle;
            this.ShowSelectedLabels = showSelectedLabels;
            this.ShowUnselectedLabels = showUnselectedLabels;
        }
        public virtual FlutterSDK.Animation.Tween.ColorTween ColorTween { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
        public virtual FlutterSDK.Widgets.Bottomnavigationbaritem.BottomNavigationBarItem Item { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle SelectedLabelStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle UnselectedLabelStyle { get; set; }
        public virtual bool ShowSelectedLabels { get; set; }
        public virtual bool ShowUnselectedLabels { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            double selectedFontSize = SelectedLabelStyle.FontSize;
            double unselectedFontSize = UnselectedLabelStyle.FontSize;
            TextStyle customStyle = TextstyleDefaultClass.TextStyle.Lerp(UnselectedLabelStyle, SelectedLabelStyle, Animation.Value);
            Widget text = TextDefaultClass.DefaultTextStyle.Merge(style: customStyle.CopyWith(fontSize: selectedFontSize, color: ColorTween.Evaluate(Animation)), child: new Transform(transform: Matrix4.Diagonal3(Vector3.All(new Tween<double>(begin: unselectedFontSize / selectedFontSize, end: 1.0).Evaluate(Animation))), alignment: AlignmentDefaultClass.Alignment.BottomCenter, child: Item.Title));
            if (!ShowUnselectedLabels && !ShowSelectedLabels)
            {
                text = new Opacity(alwaysIncludeSemantics: true, opacity: 0.0, child: text);
            }
            else if (!ShowUnselectedLabels)
            {
                text = new FadeTransition(alwaysIncludeSemantics: true, opacity: Animation, child: text);
            }
            else if (!ShowSelectedLabels)
            {
                text = new FadeTransition(alwaysIncludeSemantics: true, opacity: new Tween<double>(begin: 1.0, end: 0.0).Animate(Animation), child: text);
            }

            return new Align(alignment: AlignmentDefaultClass.Alignment.BottomCenter, heightFactor: 1.0, child: new Container(child: text));
        }



    }


    public class _BottomNavigationBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Bottomnavigationbar.BottomNavigationBar>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _BottomNavigationBarState()
        { }
        internal virtual List<FlutterSDK.Animation.Animationcontroller.AnimationController> _Controllers { get; set; }
        internal virtual List<FlutterSDK.Animation.Animations.CurvedAnimation> _Animations { get; set; }
        internal virtual Queue<FlutterSDK.Material.Bottomnavigationbar._Circle> _Circles { get; set; }
        internal virtual FlutterBinding.UI.Color _BackgroundColor { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _FlexTween { get; set; }

        private void _ResetState()
        {
            foreach (AnimationController controller in _Controllers) controller.Dispose();
            foreach (_Circle circle in _Circles) circle.Dispose();
            _Circles.Clear();
            _Controllers = List<AnimationController>.Generate(Widget.Items.Count, (int index) =>
            {
                return new AnimationController(duration: ThemeDefaultClass.KThemeAnimationDuration, vsync: this);
                new AnimationController(duration: ThemeDefaultClass.KThemeAnimationDuration, vsync: this).AddListener(_Rebuild);
            }
            );
            _Animations = List<CurvedAnimation>.Generate(Widget.Items.Count, (int index) =>
            {
                return new CurvedAnimation(parent: _Controllers[index], curve: CurvesDefaultClass.Curves.FastOutSlowIn, reverseCurve: CurvesDefaultClass.Curves.FastOutSlowIn.Flipped);
            }
            );
            _Controllers[Widget.CurrentIndex].Value = 1.0;
            _BackgroundColor = Widget.Items[Widget.CurrentIndex].BackgroundColor;
        }




        public new void InitState()
        {
            base.InitState();
            _ResetState();
        }




        private void _Rebuild()
        {
            SetState(() =>
            {
            }
            );
        }




        public new void Dispose()
        {
            foreach (AnimationController controller in _Controllers) controller.Dispose();
            foreach (_Circle circle in _Circles) circle.Dispose();
            base.Dispose();
        }




        private double _EvaluateFlex(FlutterSDK.Animation.Animation.Animation<double> animation) => _FlexTween.Evaluate(animation);



        private void _PushCircle(int index)
        {
            if (Widget.Items[index].BackgroundColor != null)
            {
                _Circles.Add(new _Circle(state: this, index: index, color: Widget.Items[index].BackgroundColor, vsync: this)..Controller.AddStatusListener((AnimationStatus status) =>
                {
                    switch (status)
                    {
                        case AnimationStatus.Completed:
                            SetState(() =>
                            {
                                _Circle circle = _Circles.RemoveFirst();
                                _BackgroundColor = circle.Color;
                                circle.Dispose();
                            }
); break;
                        case AnimationStatus.Dismissed: case AnimationStatus.Forward: case AnimationStatus.Reverse: break;
                    }
                }
                ));
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Material.Bottomnavigationbar.BottomNavigationBar oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Items.Count != oldWidget.Items.Count)
            {
                _ResetState();
                return;
            }

            if (Widget.CurrentIndex != oldWidget.CurrentIndex)
            {
                switch (Widget.Type) { case BottomNavigationBarType.Fixed: break; case BottomNavigationBarType.Shifting: _PushCircle(Widget.CurrentIndex); break; }
                _Controllers[oldWidget.CurrentIndex].Reverse();
                _Controllers[Widget.CurrentIndex].Forward();
            }
            else
            {
                if (_BackgroundColor != Widget.Items[Widget.CurrentIndex].BackgroundColor) _BackgroundColor = Widget.Items[Widget.CurrentIndex].BackgroundColor;
            }

        }




        private FlutterSDK.Painting.Textstyle.TextStyle _EffectiveTextStyle(FlutterSDK.Painting.Textstyle.TextStyle textStyle, double fontSize)
        {
            textStyle = (textStyle == null ? new TextStyle() : textStyle);
            return textStyle.FontSize == null ? textStyle.CopyWith(fontSize: fontSize) : textStyle;
        }




        private List<FlutterSDK.Widgets.Framework.Widget> _CreateTiles()
        {
            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context);

            ThemeData themeData = ThemeDefaultClass.Theme.Of(Context);
            TextStyle effectiveSelectedLabelStyle = _EffectiveTextStyle(Widget.SelectedLabelStyle, Widget.SelectedFontSize);
            TextStyle effectiveUnselectedLabelStyle = _EffectiveTextStyle(Widget.UnselectedLabelStyle, Widget.UnselectedFontSize);
            Color themeColor = default(Color);
            switch (themeData.Brightness) { case Brightness.Light: themeColor = themeData.PrimaryColor; break; case Brightness.Dark: themeColor = themeData.AccentColor; break; }
            ColorTween colorTween = default(ColorTween);
            switch (Widget.Type) { case BottomNavigationBarType.Fixed: colorTween = new ColorTween(begin: Widget.UnselectedItemColor ?? themeData.TextTheme.Caption.Color, end: Widget.SelectedItemColor ?? Widget.FixedColor ?? themeColor); break; case BottomNavigationBarType.Shifting: colorTween = new ColorTween(begin: Widget.UnselectedItemColor ?? ColorsDefaultClass.Colors.White, end: Widget.SelectedItemColor ?? ColorsDefaultClass.Colors.White); break; }
            List<Widget> tiles = new List<Widget>() { };
            for (int i = 0; i < Widget.Items.Count; i++)
            {
                tiles.Add(new _BottomNavigationTile(Widget.Type, Widget.Items[i], _Animations[i], Widget.IconSize, selectedIconTheme: Widget.SelectedIconTheme, unselectedIconTheme: Widget.UnselectedIconTheme, selectedLabelStyle: effectiveSelectedLabelStyle, unselectedLabelStyle: effectiveUnselectedLabelStyle, onTap: () =>
                {
                    if (Widget.OnTap != null) Widget.OnTap(i);
                }
                , colorTween: colorTween, flex: _EvaluateFlex(_Animations[i]), selected: i == Widget.CurrentIndex, showSelectedLabels: Widget.ShowSelectedLabels, showUnselectedLabels: Widget.ShowUnselectedLabels, indexLabel: localizations.TabLabel(tabIndex: i + 1, tabCount: Widget.Items.Count)));
            }

            return tiles;
        }




        private FlutterSDK.Widgets.Framework.Widget _CreateContainer(List<FlutterSDK.Widgets.Framework.Widget> tiles)
        {
            return TextDefaultClass.DefaultTextStyle.Merge(overflow: TextOverflow.Ellipsis, child: new Row(mainAxisAlignment: MainAxisAlignment.SpaceBetween, children: tiles));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {



            double additionalBottomPadding = Math.Dart:mathDefaultClass.Max(MediaqueryDefaultClass.MediaQuery.Of(context).Padding.Bottom - Widget.SelectedFontSize / 2.0, 0.0);
            Color backgroundColor = default(Color);
            switch (Widget.Type) { case BottomNavigationBarType.Fixed: backgroundColor = Widget.BackgroundColor; break; case BottomNavigationBarType.Shifting: backgroundColor = _BackgroundColor; break; }
            return new Semantics(explicitChildNodes: true, child: new Material(elevation: Widget.Elevation, color: backgroundColor, child: new ConstrainedBox(constraints: new BoxConstraints(minHeight: ConstantsDefaultClass.KBottomNavigationBarHeight + additionalBottomPadding), child: new CustomPaint(painter: new _RadialPainter(circles: _Circles.ToList(), textDirection: BasicDefaultClass.Directionality.Of(context)), child: new Material(type: MaterialType.Transparency, child: new Padding(padding: EdgeInsets.Only(bottom: additionalBottomPadding), child: MediaQuery.RemovePadding(context: context, removeBottom: true, child: _CreateContainer(_CreateTiles()))))))));
        }



    }


    public class _Circle
    {
        public _Circle(FlutterSDK.Material.Bottomnavigationbar._BottomNavigationBarState state = default(FlutterSDK.Material.Bottomnavigationbar._BottomNavigationBarState), int index = default(int), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider))
        : base()
        {
            this.State = state;
            this.Index = index;
            this.Color = color;
            Controller = new AnimationController(duration: ThemeDefaultClass.KThemeAnimationDuration, vsync: vsync);
            Animation = new CurvedAnimation(parent: Controller, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            Controller.Forward();
        }


        public virtual FlutterSDK.Material.Bottomnavigationbar._BottomNavigationBarState State { get; set; }
        public virtual int Index { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; set; }
        public virtual FlutterSDK.Animation.Animations.CurvedAnimation Animation { get; set; }
        public virtual double HorizontalLeadingOffset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public virtual void Dispose()
        {
            Controller.Dispose();
        }



    }


    public class _RadialPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        public _RadialPainter(List<FlutterSDK.Material.Bottomnavigationbar._Circle> circles = default(List<FlutterSDK.Material.Bottomnavigationbar._Circle>), TextDirection textDirection = default(TextDirection))
        : base()
        {
            this.Circles = circles;
            this.TextDirection = textDirection;
        }
        public virtual List<FlutterSDK.Material.Bottomnavigationbar._Circle> Circles { get; set; }
        public virtual TextDirection TextDirection { get; set; }

        private double _MaxRadius(FlutterBinding.UI.Offset center, Size size)
        {
            double maxX = Math.Dart:mathDefaultClass.Max(center.Dx, size.Width - center.Dx);
            double maxY = Math.Dart:mathDefaultClass.Max(center.Dy, size.Height - center.Dy);
            return Math.Dart:mathDefaultClass.Sqrt(maxX * maxX + maxY * maxY);
        }




        public new bool ShouldRepaint(FlutterSDK.Material.Bottomnavigationbar._RadialPainter oldPainter)
        {
            if (TextDirection != oldPainter.TextDirection) return true;
            if (Circles == oldPainter.Circles) return false;
            if (Circles.Count != oldPainter.Circles.Count) return true;
            for (int i = 0; i < Circles.Count; i += 1) if (Circles[i] != oldPainter.Circles[i]) return true;
            return false;
        }


        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            if (TextDirection != oldPainter.TextDirection) return true;
            if (Circles == oldPainter.Circles) return false;
            if (Circles.Count != oldPainter.Circles.Count) return true;
            for (int i = 0; i < Circles.Count; i += 1) if (Circles[i] != oldPainter.Circles[i]) return true;
            return false;
        }




        public new void Paint(Canvas canvas, Size size)
        {
            foreach (_Circle circle in Circles)
            {
                Paint paint = new Paint()..Color = circle.Color;
                Rect rect = Rect.FromLTWH(0.0, 0.0, size.Width, size.Height);
                canvas.ClipRect(rect);
                double leftFraction = default(double);
                switch (TextDirection) { case TextDirection.Rtl: leftFraction = 1.0 - circle.HorizontalLeadingOffset; break; case TextDirection.Ltr: leftFraction = circle.HorizontalLeadingOffset; break; }
                Offset center = new Offset(leftFraction * size.Width, size.Height / 2.0);
                Tween<double> radiusTween = new Tween<double>(begin: 0.0, end: _MaxRadius(center, size));
                canvas.DrawCircle(center, radiusTween.Transform(circle.Animation.Value), paint);
            }

        }



    }


    /// <Summary>
    /// Defines the layout and behavior of a [BottomNavigationBar].
    ///
    /// See also:
    ///
    ///  * [BottomNavigationBar]
    ///  * [BottomNavigationBarItem]
    ///  * <https://material.io/design/components/bottom-navigation.html#specs>
    /// </Summary>
    public enum BottomNavigationBarType
    {

        /// <Summary>
        /// The [BottomNavigationBar]'s [BottomNavigationBarItem]s have fixed width.
        /// </Summary>
        @Fixed,
        /// <Summary>
        /// The location and size of the [BottomNavigationBar] [BottomNavigationBarItem]s
        /// animate and labels fade in when they are tapped.
        /// </Summary>
        Shifting,
    }

}
