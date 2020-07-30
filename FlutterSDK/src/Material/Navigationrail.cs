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
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Typography;
using FlutterSDK.Scheduler;
using FlutterSDK.Material.Navigationrailtheme;
namespace FlutterSDK.Material.Navigationrail
{
    internal static class NavigationrailDefaultClass
    {
        public static double _MinRailWidth = default(double);
        public static double _MinExtendedRailWidth = default(double);
        public static double _HorizontalDestinationPadding = default(double);
        public static double _VerticalDestinationPaddingNoLabel = default(double);
        public static double _VerticalDestinationPaddingWithLabel = default(double);
        public static FlutterSDK.Widgets.Framework.Widget _VerticalSpacer = default(FlutterSDK.Widgets.Framework.Widget);
    }

    /// <Summary>
    /// A material widget that is meant to be displayed at the left or right of an
    /// app to navigate between a small number of views, typically between three and
    /// five.
    ///
    /// A navigation rail is usually used as the first or last element of a [Row]
    /// which defines the app's [Scaffold] body.
    ///
    /// The appearance of all of the [NavigationRail]s within an app can be
    /// specified with [NavigationRailTheme]. The default values for null theme
    /// properties are based on the [Theme]'s [ThemeData.textTheme],
    /// [ThemeData.iconTheme], and [ThemeData.colorScheme].
    /// The navigation rail is meant for layouts with wide viewports, such as a
    /// desktop web or tablet landscape layout. For smaller layouts, like mobile
    /// portrait, a [BottomNavigationBar] should be used instead.
    ///
    /// Adaptive layouts can build different instances of the [Scaffold] in order to
    /// have a navigation rail for more horizontal layouts and a bottom navigation
    /// bar for more vertical layouts. See
    /// [https://github.com/flutter/samples/blob/master/experimental/web_dashboard/lib/src/widgets/third_party/adaptive_scaffold.dart]
    /// for an example.
    ///
    /// {@tool dartpad --template=stateful_widget_material}
    ///
    /// This example shows a [NavigationRail] used within a Scaffold with 3
    /// [NavigationRailDestination]s. The main content is separated by a divider
    /// (although elevation on the navigation rail can be used instead). The
    /// `_selectedIndex` is updated by the `onDestinationSelected` callback.
    ///
    /// ```dart
    /// int _selectedIndex = 0;
    ///
    ///  @override
    ///  Widget build(BuildContext context) {
    ///    return Scaffold(
    ///      body: Row(
    ///        children: <Widget>[
    ///          NavigationRail(
    ///            selectedIndex: _selectedIndex,
    ///            onDestinationSelected: (int index) {
    ///              setState(() {
    ///                _selectedIndex = index;
    ///              });
    ///            },
    ///            labelType: NavigationRailLabelType.selected,
    ///            destinations: [
    ///              NavigationRailDestination(
    ///                icon: Icon(Icons.favorite_border),
    ///                selectedIcon: Icon(Icons.favorite),
    ///                label: Text('First'),
    ///              ),
    ///              NavigationRailDestination(
    ///                icon: Icon(Icons.bookmark_border),
    ///                selectedIcon: Icon(Icons.book),
    ///                label: Text('Second'),
    ///              ),
    ///              NavigationRailDestination(
    ///                icon: Icon(Icons.star_border),
    ///                selectedIcon: Icon(Icons.star),
    ///                label: Text('Third'),
    ///              ),
    ///            ],
    ///          ),
    ///          VerticalDivider(thickness: 1, width: 1),
    ///          // This is the main content.
    ///          Expanded(
    ///            child: Center(
    ///              child: Text('selectedIndex: $_selectedIndex'),
    ///            ),
    ///          )
    ///        ],
    ///      ),
    ///    );
    ///  }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Scaffold], which can display the navigation rail within a [Row] of the
    ///    [Scaffold.body] slot.
    ///  * [NavigationRailDestination], which is used as a model to create tappable
    ///    destinations in the navigation rail.
    ///  * [BottomNavigationBar], which is a similar navigation widget that's laid
    ///     out horizontally.
    ///  * [https://material.io/components/navigation-rail/]
    /// </Summary>
    public class NavigationRail : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public NavigationRail(FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), bool extended = false, FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget trailing = default(FlutterSDK.Widgets.Framework.Widget), List<FlutterSDK.Material.Navigationrail.NavigationRailDestination> destinations = default(List<FlutterSDK.Material.Navigationrail.NavigationRailDestination>), int selectedIndex = default(int), FlutterSDK.Foundation.Basictypes.ValueChanged<int> onDestinationSelected = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>), double elevation = default(double), double groupAlignment = default(double), FlutterSDK.Material.Navigationrail.NavigationRailLabelType labelType = default(FlutterSDK.Material.Navigationrail.NavigationRailLabelType), FlutterSDK.Painting.Textstyle.TextStyle unselectedLabelTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle selectedLabelTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Iconthemedata.IconThemeData unselectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Widgets.Iconthemedata.IconThemeData selectedIconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), double minWidth = default(double), double minExtendedWidth = default(double))
        : base()
        {
            this.BackgroundColor = backgroundColor;
            this.Extended = extended;
            this.Leading = leading;
            this.Trailing = trailing;
            this.Destinations = destinations;
            this.SelectedIndex = selectedIndex;
            this.OnDestinationSelected = onDestinationSelected;
            this.Elevation = elevation;
            this.GroupAlignment = groupAlignment;
            this.LabelType = labelType;
            this.UnselectedLabelTextStyle = unselectedLabelTextStyle;
            this.SelectedLabelTextStyle = selectedLabelTextStyle;
            this.UnselectedIconTheme = unselectedIconTheme;
            this.SelectedIconTheme = selectedIconTheme;
            this.MinWidth = minWidth;
            this.MinExtendedWidth = minExtendedWidth;
        }
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual bool Extended { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Leading { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Trailing { get; set; }
        public virtual List<FlutterSDK.Material.Navigationrail.NavigationRailDestination> Destinations { get; set; }
        public virtual int SelectedIndex { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnDestinationSelected { get; set; }
        public virtual double Elevation { get; set; }
        public virtual double GroupAlignment { get; set; }
        public virtual FlutterSDK.Material.Navigationrail.NavigationRailLabelType LabelType { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle UnselectedLabelTextStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle SelectedLabelTextStyle { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData UnselectedIconTheme { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData SelectedIconTheme { get; set; }
        public virtual double MinWidth { get; set; }
        public virtual double MinExtendedWidth { get; set; }

        /// <Summary>
        /// Returns the animation that controls the [NavigationRail.extended] state.
        ///
        /// This can be used to synchronize animations in the [leading] or [trailing]
        /// widget, such as an animated menu or a [FloatingActionButton] animation.
        ///
        /// {@tool snippet}
        ///
        /// This example shows how to use this animation to create a
        /// [FloatingActionButton] that animates itself between the normal and
        /// extended states of the [NavigationRail].
        ///
        /// An instance of `ExtendableFab` would be created for
        /// [NavigationRail.leading].
        ///
        /// ```dart
        /// import 'dart:ui';
        ///
        /// @override
        /// Widget build(BuildContext context) {
        ///   final Animation<double> animation = NavigationRail.extendedAnimation(context);
        ///   return AnimatedBuilder(
        ///     animation: animation,
        ///     builder: (BuildContext context, Widget child) {
        ///       // The extended fab has a shorter height than the regular fab.
        ///       return Container(
        ///         height: 56,
        ///         padding: EdgeInsets.symmetric(
        ///           vertical: lerpDouble(0, 6, animation.value),
        ///         ),
        ///         child: animation.value == 0
        ///           ? FloatingActionButton(
        ///               child: Icon(Icons.add),
        ///               onPressed: () {},
        ///             )
        ///           : Align(
        ///               alignment: AlignmentDirectional.centerStart,
        ///               widthFactor: animation.value,
        ///               child: Padding(
        ///                 padding: const EdgeInsetsDirectional.only(start: 8),
        ///                 child: FloatingActionButton.extended(
        ///                   icon: Icon(Icons.add),
        ///                   label: Text('CREATE'),
        ///                   onPressed: () {},
        ///                 ),
        ///               ),
        ///             ),
        ///       );
        ///     },
        ///   );
        /// }
        /// ```
        ///
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Animation.Animation.Animation<double> ExtendedAnimation(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return context.DependOnInheritedWidgetOfExactType().Animation;
        }




        public new FlutterSDK.Material.Navigationrail._NavigationRailState CreateState() => new _NavigationRailState();


    }


    public class _NavigationRailState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Navigationrail.NavigationRail>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _NavigationRailState()
        { }
        internal virtual List<FlutterSDK.Animation.Animationcontroller.AnimationController> _DestinationControllers { get; set; }
        internal virtual List<FlutterSDK.Animation.Animation.Animation<double>> _DestinationAnimations { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ExtendedController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _ExtendedAnimation { get; set; }

        public new void InitState()
        {
            base.InitState();
            _InitControllers();
        }




        public new void Dispose()
        {
            _DisposeControllers();
            base.Dispose();
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Navigationrail.NavigationRail oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Extended != oldWidget.Extended)
            {
                if (Widget.Extended)
                {
                    _ExtendedController.Forward();
                }
                else
                {
                    _ExtendedController.Reverse();
                }

            }

            if (Widget.Destinations.Count != oldWidget.Destinations.Count)
            {
                _ResetState();
                return;
            }

            if (Widget.SelectedIndex != oldWidget.SelectedIndex)
            {
                _DestinationControllers[oldWidget.SelectedIndex].Reverse();
                _DestinationControllers[Widget.SelectedIndex].Forward();
                return;
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            NavigationRailThemeData navigationRailTheme = NavigationrailthemeDefaultClass.NavigationRailTheme.Of(context);
            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
            Color backgroundColor = Widget.BackgroundColor ?? navigationRailTheme.BackgroundColor ?? theme.ColorScheme.Surface;
            double elevation = Widget.Elevation ?? navigationRailTheme.Elevation ?? 0;
            double minWidth = Widget.MinWidth ?? NavigationrailDefaultClass._MinRailWidth;
            double minExtendedWidth = Widget.MinExtendedWidth ?? NavigationrailDefaultClass._MinExtendedRailWidth;
            Color baseSelectedColor = theme.ColorScheme.Primary;
            Color baseColor = theme.ColorScheme.OnSurface.WithOpacity(0.64);
            IconThemeData defaultUnselectedIconTheme = Widget.UnselectedIconTheme ?? navigationRailTheme.UnselectedIconTheme;
            IconThemeData unselectedIconTheme = new IconThemeData(size: defaultUnselectedIconTheme?.Size ?? 24.0, color: defaultUnselectedIconTheme?.Color ?? theme.ColorScheme.OnSurface, opacity: defaultUnselectedIconTheme?.Opacity ?? 1.0);
            IconThemeData defaultSelectedIconTheme = Widget.SelectedIconTheme ?? navigationRailTheme.SelectedIconTheme;
            IconThemeData selectedIconTheme = new IconThemeData(size: defaultSelectedIconTheme?.Size ?? 24.0, color: defaultSelectedIconTheme?.Color ?? theme.ColorScheme.Primary, opacity: defaultSelectedIconTheme?.Opacity ?? 0.64);
            TextStyle unselectedLabelTextStyle = theme.TextTheme.BodyText1.CopyWith(color: baseColor).Merge(Widget.UnselectedLabelTextStyle ?? navigationRailTheme.UnselectedLabelTextStyle);
            TextStyle selectedLabelTextStyle = theme.TextTheme.BodyText1.CopyWith(color: baseSelectedColor).Merge(Widget.SelectedLabelTextStyle ?? navigationRailTheme.SelectedLabelTextStyle);
            double groupAlignment = Widget.GroupAlignment ?? navigationRailTheme.GroupAlignment ?? -1.0;
            NavigationRailLabelType labelType = Widget.LabelType ?? navigationRailTheme.LabelType ?? NavigationRailLabelType.None;
            return new _ExtendedNavigationRailAnimation(animation: _ExtendedAnimation, child: new Semantics(explicitChildNodes: true, child: new Material(elevation: elevation, color: backgroundColor, child: new Column(children: new List<Widget>() { NavigationrailDefaultClass._VerticalSpacer }))));
        }




        private void _DisposeControllers()
        {
            foreach (AnimationController controller in _DestinationControllers)
            {
                controller.Dispose();
            }

            _ExtendedController.Dispose();
        }




        private void _InitControllers()
        {
            _DestinationControllers = List<AnimationController>.Generate(Widget.Destinations.Count, (int index) =>
            {
                return new AnimationController(duration: ThemeDefaultClass.KThemeAnimationDuration, vsync: this);
                new AnimationController(duration: ThemeDefaultClass.KThemeAnimationDuration, vsync: this).AddListener(_Rebuild);
            }
            );
            _DestinationAnimations = _DestinationControllers.Map((AnimationController controller) => =>controller.View).ToList();
            _DestinationControllers[Widget.SelectedIndex].Value = 1.0;
            _ExtendedController = new AnimationController(duration: ThemeDefaultClass.KThemeAnimationDuration, vsync: this, value: Widget.Extended ? 1.0 : 0.0);
            _ExtendedAnimation = new CurvedAnimation(parent: _ExtendedController, curve: CurvesDefaultClass.Curves.EaseInOut);
            _ExtendedController.AddListener(() =>
            {
                _Rebuild();
            }
            );
        }




        private void _ResetState()
        {
            _DisposeControllers();
            _InitControllers();
        }




        private void _Rebuild()
        {
            SetState(() =>
            {
            }
            );
        }



    }


    public class _RailDestination : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _RailDestination(double minWidth = default(double), double minExtendedWidth = default(double), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Animation.Animation.Animation<double> destinationAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> extendedTransitionAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Material.Navigationrail.NavigationRailLabelType labelType = default(FlutterSDK.Material.Navigationrail.NavigationRailLabelType), bool selected = default(bool), FlutterSDK.Widgets.Iconthemedata.IconThemeData iconTheme = default(FlutterSDK.Widgets.Iconthemedata.IconThemeData), FlutterSDK.Painting.Textstyle.TextStyle labelTextStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), VoidCallback onTap = default(VoidCallback), string indexLabel = default(string))
        : base()
        {
            this.MinWidth = minWidth;
            this.MinExtendedWidth = minExtendedWidth;
            this.Icon = icon;
            this.Label = label;
            this.DestinationAnimation = destinationAnimation;
            this.ExtendedTransitionAnimation = extendedTransitionAnimation;
            this.LabelType = labelType;
            this.Selected = selected;
            this.IconTheme = iconTheme;
            this.LabelTextStyle = labelTextStyle;
            this.OnTap = onTap;
            this.IndexLabel = indexLabel;
        }
        public virtual double MinWidth { get; set; }
        public virtual double MinExtendedWidth { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> DestinationAnimation { get; set; }
        public virtual FlutterSDK.Material.Navigationrail.NavigationRailLabelType LabelType { get; set; }
        public virtual bool Selected { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> ExtendedTransitionAnimation { get; set; }
        public virtual FlutterSDK.Widgets.Iconthemedata.IconThemeData IconTheme { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelTextStyle { get; set; }
        public virtual VoidCallback OnTap { get; set; }
        public virtual string IndexLabel { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _PositionAnimation { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Widget themedIcon = new IconTheme(data: IconTheme, child: Icon);
            Widget styledLabel = new DefaultTextStyle(style: LabelTextStyle, child: Label);
            Widget content = default(Widget);
            switch (LabelType)
            {
                case NavigationRailLabelType.None:
                    Widget iconPart = new SizedBox(width: MinWidth, height: MinWidth, child: new Align(alignment: AlignmentDefaultClass.Alignment.Center, child: themedIcon)); if (ExtendedTransitionAnimation.Value == 0)
                    {
                        content = new Stack(children: new List<Widget>() { iconPart, new SizedBox(width: 0, height: 0, child: new Opacity(alwaysIncludeSemantics: true, opacity: 0.0, child: Label)) });
                    }
                    else
                    {
                        content = new ConstrainedBox(constraints: new BoxConstraints(minWidth: Dart.UI.UiDefaultClass.LerpDouble(MinWidth, MinExtendedWidth, ExtendedTransitionAnimation.Value)), child: new ClipRect(child: new Row(children: new List<Widget>() { iconPart, new Align(heightFactor: 1.0, widthFactor: ExtendedTransitionAnimation.Value, alignment: AlignmentDefaultClass.AlignmentDirectional.CenterStart, child: new Opacity(alwaysIncludeSemantics: true, opacity: _ExtendedLabelFadeValue(), child: styledLabel)), new SizedBox(width: NavigationrailDefaultClass._HorizontalDestinationPadding) })));
                    }
                    break;
                case NavigationRailLabelType.Selected: double appearingAnimationValue = 1 - _PositionAnimation.Value; double verticalPadding = Dart.UI.UiDefaultClass.LerpDouble(NavigationrailDefaultClass._VerticalDestinationPaddingNoLabel, NavigationrailDefaultClass._VerticalDestinationPaddingWithLabel, appearingAnimationValue); content = new Container(constraints: new BoxConstraints(minWidth: MinWidth, minHeight: MinWidth), padding: EdgeInsets.Symmetric(horizontal: NavigationrailDefaultClass._HorizontalDestinationPadding), child: new ClipRect(child: new Column(mainAxisSize: MainAxisSize.Min, mainAxisAlignment: MainAxisAlignment.Center, children: new List<Widget>() { new SizedBox(height: verticalPadding), themedIcon, new Align(alignment: AlignmentDefaultClass.Alignment.TopCenter, heightFactor: appearingAnimationValue, widthFactor: 1.0, child: new Opacity(alwaysIncludeSemantics: true, opacity: Selected ? _NormalLabelFadeInValue() : _NormalLabelFadeOutValue(), child: styledLabel)), new SizedBox(height: verticalPadding) }))); break;
                case NavigationRailLabelType.All: content = new Container(constraints: new BoxConstraints(minWidth: MinWidth, minHeight: MinWidth), padding: EdgeInsets.Symmetric(horizontal: NavigationrailDefaultClass._HorizontalDestinationPadding), child: new Column(children: new List<Widget>() { new SizedBox(height: NavigationrailDefaultClass._VerticalDestinationPaddingWithLabel), themedIcon, styledLabel, new SizedBox(height: NavigationrailDefaultClass._VerticalDestinationPaddingWithLabel) })); break;
            }
            ColorScheme colors = ThemeDefaultClass.Theme.Of(context).ColorScheme;
            return new Semantics(container: true, selected: Selected, child: new Stack(children: new List<Widget>(){new Material(type:MaterialType.Transparency, clipBehavior:Clip.None, child:new InkResponse(onTap:OnTap, onHover:(_) => {
}
, highlightShape:BoxShape.Rectangle, borderRadius:BorderRadius.All(Radius.Circular(MinWidth/2.0)), containedInkWell:true , splashColor:colors.Primary.WithOpacity(0.12), hoverColor:colors.Primary.WithOpacity(0.04), child:content)), new Semantics(label:IndexLabel)}));
        }




        private double _NormalLabelFadeInValue()
        {
            if (DestinationAnimation.Value < 0.25)
            {
                return 0;
            }
            else if (DestinationAnimation.Value < 0.75)
            {
                return (DestinationAnimation.Value - 0.25) * 2;
            }
            else
            {
                return 1;
            }

        }




        private double _NormalLabelFadeOutValue()
        {
            if (DestinationAnimation.Value > 0.75)
            {
                return (DestinationAnimation.Value - 0.75) * 4.0;
            }
            else
            {
                return 0;
            }

        }




        private double _ExtendedLabelFadeValue()
        {
            return ExtendedTransitionAnimation.Value < 0.25 ? ExtendedTransitionAnimation.Value * 4.0 : 1.0;
        }



    }


    /// <Summary>
    /// Defines a [NavigationRail] button that represents one "destination" view.
    ///
    /// See also:
    ///
    ///  * [NavigationRail]
    /// </Summary>
    public class NavigationRailDestination
    {
        public NavigationRailDestination(FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget selectedIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget))
        : base()
        {
            this.Icon = icon;
            this.Label = label;
        }
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget SelectedIcon { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Label { get; set; }
    }


    public class _ExtendedNavigationRailAnimation : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        public _ExtendedNavigationRailAnimation(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Animation = animation;
        }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }

        public new bool UpdateShouldNotify(FlutterSDK.Material.Navigationrail._ExtendedNavigationRailAnimation old) => Animation != old.Animation;

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => Animation != old.Animation;


    }


    /// <Summary>
    /// Defines the behavior of the labels of a [NavigationRail].
    ///
    /// See also:
    ///
    ///   * [NavigationRail]
    /// </Summary>
    public enum NavigationRailLabelType
    {

        /// <Summary>
        /// Only the [NavigationRailDestination]s are shown.
        /// </Summary>
        None,
        /// <Summary>
        /// Only the selected [NavigationRailDestination] will show its label.
        ///
        /// The label will animate in and out as new [NavigationRailDestination]s are
        /// selected.
        /// </Summary>
        Selected,
        /// <Summary>
        /// All [NavigationRailDestination]s will show their label.
        /// </Summary>
        All,
    }

}
