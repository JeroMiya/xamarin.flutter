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
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
namespace FlutterSDK.Material.Tabs
{
    public delegate void _LayoutCallback(List<double> xOffsets, TextDirection textDirection, double width);
    internal static class TabsDefaultClass
    {
        public static double _KTabHeight = default(double);
        public static double _KTextAndIconTabHeight = default(double);
        public static FlutterSDK.Widgets.Pageview.PageScrollPhysics _KTabBarViewPhysics = default(FlutterSDK.Widgets.Pageview.PageScrollPhysics);
        internal static double _IndexChangeProgress(FlutterSDK.Material.Tabcontroller.TabController controller)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// A material design [TabBar] tab.
    ///
    /// If both [icon] and [text] are provided, the text is displayed below
    /// the icon.
    ///
    /// See also:
    ///
    ///  * [TabBar], which displays a row of tabs.
    ///  * [TabBarView], which displays a widget for the currently selected tab.
    ///  * [TabController], which coordinates tab selection between a [TabBar] and a [TabBarView].
    ///  * <https://material.io/design/components/tabs.html>
    /// </Summary>
    public class Tab : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public Tab(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string text = default(string), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry iconMargin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Text = text;
            this.Icon = icon;
            this.IconMargin = iconMargin;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual string Text { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry IconMargin { get; set; }
        #endregion

        #region methods

        private FlutterSDK.Widgets.Framework.Widget _BuildLabelText() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _TabStyle : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        #region constructors
        public _TabStyle(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), bool selected = default(bool), FlutterBinding.UI.Color labelColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color unselectedLabelColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle unselectedLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: animation)
        {
            this.Selected = selected;
            this.LabelColor = labelColor;
            this.UnselectedLabelColor = unselectedLabelColor;
            this.LabelStyle = labelStyle;
            this.UnselectedLabelStyle = unselectedLabelStyle;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle UnselectedLabelStyle { get; set; }
        public virtual bool Selected { get; set; }
        public virtual FlutterBinding.UI.Color LabelColor { get; set; }
        public virtual FlutterBinding.UI.Color UnselectedLabelColor { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _TabLabelBarRenderer : FlutterSDK.Rendering.Flex.RenderFlex
    {
        #region constructors
        public _TabLabelBarRenderer(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), FlutterSDK.Painting.Basictypes.Axis direction = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), FlutterSDK.Material.Tabs._LayoutCallback onPerformLayout = default(FlutterSDK.Material.Tabs._LayoutCallback))
        : base(children: children, direction: direction, mainAxisSize: mainAxisSize, mainAxisAlignment: mainAxisAlignment, crossAxisAlignment: crossAxisAlignment, textDirection: textDirection, verticalDirection: verticalDirection)
        {
            this.OnPerformLayout = onPerformLayout; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Tabs._LayoutCallback OnPerformLayout { get; set; }
        #endregion

        #region methods

        public new void PerformLayout() { throw new NotImplementedException(); }

        #endregion
    }


    public class _TabLabelBar : FlutterSDK.Widgets.Basic.Flex
    {
        #region constructors
        public _TabLabelBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Material.Tabs._LayoutCallback onPerformLayout = default(FlutterSDK.Material.Tabs._LayoutCallback))
        : base(key: key, children: children, direction: Axis.Horizontal, mainAxisSize: MainAxisSize.Max, mainAxisAlignment: MainAxisAlignment.Start, crossAxisAlignment: CrossAxisAlignment.Center, verticalDirection: VerticalDirection.Down)
        {
            this.OnPerformLayout = onPerformLayout; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Tabs._LayoutCallback OnPerformLayout { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Flex.RenderFlex CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Tabs._TabLabelBarRenderer renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _IndicatorPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        #region constructors
        public _IndicatorPainter(FlutterSDK.Material.Tabcontroller.TabController controller = default(FlutterSDK.Material.Tabcontroller.TabController), FlutterSDK.Painting.Decoration.Decoration indicator = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Material.Tabs.TabBarIndicatorSize indicatorSize = default(FlutterSDK.Material.Tabs.TabBarIndicatorSize), List<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>> tabKeys = default(List<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>>), FlutterSDK.Material.Tabs._IndicatorPainter old = default(FlutterSDK.Material.Tabs._IndicatorPainter))
        : base(repaint: controller.Animation)
        {
            this.Controller = controller;
            this.Indicator = indicator;
            this.IndicatorSize = indicatorSize;
            this.TabKeys = tabKeys; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        public virtual FlutterSDK.Painting.Decoration.Decoration Indicator { get; set; }
        public virtual FlutterSDK.Material.Tabs.TabBarIndicatorSize IndicatorSize { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>> TabKeys { get; set; }
        internal virtual List<double> _CurrentTabOffsets { get; set; }
        internal virtual TextDirection _CurrentTextDirection { get; set; }
        internal virtual FlutterBinding.UI.Rect _CurrentRect { get; set; }
        internal virtual FlutterSDK.Painting.Decoration.BoxPainter _Painter { get; set; }
        internal virtual bool _NeedsPaint { get; set; }
        public virtual int MaxTabIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void MarkNeedsPaint() { throw new NotImplementedException(); }


        public virtual void Dispose() { throw new NotImplementedException(); }


        public virtual void SaveTabOffsets(List<double> tabOffsets, TextDirection textDirection) { throw new NotImplementedException(); }


        public virtual double CenterOf(int tabIndex) { throw new NotImplementedException(); }


        public virtual Rect IndicatorRect(Size tabBarSize, int tabIndex) { throw new NotImplementedException(); }


        public new void Paint(Canvas canvas, Size size) { throw new NotImplementedException(); }


        private bool _TabOffsetsEqual(List<double> a, List<double> b) { throw new NotImplementedException(); }


        public new bool ShouldRepaint(FlutterSDK.Material.Tabs._IndicatorPainter old) { throw new NotImplementedException(); }
        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ChangeAnimation : FlutterSDK.Animation.Animation.Animation<double>, IAnimationWithParentMixin<double>
    {
        #region constructors
        public _ChangeAnimation(FlutterSDK.Material.Tabcontroller.TabController controller)
        {
            this.Controller = controller; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Parent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener) { throw new NotImplementedException(); }


        public new void RemoveListener(VoidCallback listener) { throw new NotImplementedException(); }

        #endregion
    }


    public class _DragAnimation : FlutterSDK.Animation.Animation.Animation<double>, IAnimationWithParentMixin<double>
    {
        #region constructors
        public _DragAnimation(FlutterSDK.Material.Tabcontroller.TabController controller, int index)
        {
            this.Controller = controller;
            this.Index = index; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        public virtual int Index { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Parent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener) { throw new NotImplementedException(); }


        public new void RemoveListener(VoidCallback listener) { throw new NotImplementedException(); }

        #endregion
    }


    public class _TabBarScrollPosition : FlutterSDK.Widgets.Scrollpositionwithsinglecontext.ScrollPositionWithSingleContext
    {
        #region constructors
        public _TabBarScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontext.ScrollContext context = default(FlutterSDK.Widgets.Scrollcontext.ScrollContext), FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition), FlutterSDK.Material.Tabs._TabBarState tabBar = default(FlutterSDK.Material.Tabs._TabBarState))
        : base(physics: physics, context: context, initialPixels: null, oldPosition: oldPosition)
        {
            this.TabBar = tabBar; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Tabs._TabBarState TabBar { get; set; }
        internal virtual bool _InitialViewportDimensionWasZero { get; set; }
        #endregion

        #region methods

        public new bool ApplyContentDimensions(double minScrollExtent, double maxScrollExtent) { throw new NotImplementedException(); }

        #endregion
    }


    public class _TabBarScrollController : FlutterSDK.Widgets.Scrollcontroller.ScrollController
    {
        #region constructors
        public _TabBarScrollController(FlutterSDK.Material.Tabs._TabBarState tabBar)
        {
            this.TabBar = tabBar; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Tabs._TabBarState TabBar { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Scrollposition.ScrollPosition CreateScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics, FlutterSDK.Widgets.Scrollcontext.ScrollContext context, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A material design widget that displays a horizontal row of tabs.
    ///
    /// Typically created as the [AppBar.bottom] part of an [AppBar] and in
    /// conjunction with a [TabBarView].
    ///
    /// If a [TabController] is not provided, then a [DefaultTabController] ancestor
    /// must be provided instead. The tab controller's [TabController.length] must
    /// equal the length of the [tabs] list and the length of the
    /// [TabBarView.children] list.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// Uses values from [TabBarTheme] if it is set in the current context.
    ///
    /// To see a sample implementation, visit the [TabController] documentation.
    ///
    /// See also:
    ///
    ///  * [TabBarView], which displays page views that correspond to each tab.
    /// </Summary>
    public class TabBar : FlutterSDK.Widgets.Framework.StatefulWidget, IPreferredSizeWidget
    {
        #region constructors
        public TabBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> tabs = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Material.Tabcontroller.TabController controller = default(FlutterSDK.Material.Tabcontroller.TabController), bool isScrollable = false, FlutterBinding.UI.Color indicatorColor = default(FlutterBinding.UI.Color), double indicatorWeight = 2.0, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry indicatorPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Decoration.Decoration indicator = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Material.Tabs.TabBarIndicatorSize indicatorSize = default(FlutterSDK.Material.Tabs.TabBarIndicatorSize), FlutterBinding.UI.Color labelColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color unselectedLabelColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle unselectedLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), FlutterSDK.Foundation.Basictypes.ValueChanged<int> onTap = default(FlutterSDK.Foundation.Basictypes.ValueChanged<int>))
        : base(key: key)
        {
            this.Tabs = tabs;
            this.Controller = controller;
            this.IsScrollable = isScrollable;
            this.IndicatorColor = indicatorColor;
            this.IndicatorWeight = indicatorWeight;
            this.IndicatorPadding = indicatorPadding;
            this.Indicator = indicator;
            this.IndicatorSize = indicatorSize;
            this.LabelColor = labelColor;
            this.LabelStyle = labelStyle;
            this.LabelPadding = labelPadding;
            this.UnselectedLabelColor = unselectedLabelColor;
            this.UnselectedLabelStyle = unselectedLabelStyle;
            this.DragStartBehavior = dragStartBehavior;
            this.OnTap = onTap; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Tabs { get; set; }
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        public virtual bool IsScrollable { get; set; }
        public virtual FlutterBinding.UI.Color IndicatorColor { get; set; }
        public virtual double IndicatorWeight { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry IndicatorPadding { get; set; }
        public virtual FlutterSDK.Painting.Decoration.Decoration Indicator { get; set; }
        public virtual FlutterSDK.Material.Tabs.TabBarIndicatorSize IndicatorSize { get; set; }
        public virtual FlutterBinding.UI.Color LabelColor { get; set; }
        public virtual FlutterBinding.UI.Color UnselectedLabelColor { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle UnselectedLabelStyle { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnTap { get; set; }
        public virtual Size PreferredSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Material.Tabs._TabBarState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _TabBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Tabs.TabBar>
    {
        #region constructors
        public _TabBarState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _ScrollController { get; set; }
        internal virtual FlutterSDK.Material.Tabcontroller.TabController _Controller { get; set; }
        internal virtual FlutterSDK.Material.Tabs._IndicatorPainter _IndicatorPainter { get; set; }
        internal virtual int _CurrentIndex { get; set; }
        internal virtual double _TabStripWidth { get; set; }
        internal virtual List<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>> _TabKeys { get; set; }
        internal virtual FlutterSDK.Painting.Decoration.Decoration _Indicator { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _ControllerIsValid { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int MaxTabIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        private void _UpdateTabController() { throw new NotImplementedException(); }


        private void _InitIndicatorPainter() { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Tabs.TabBar oldWidget) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private double _TabScrollOffset(int index, double viewportWidth, double minExtent, double maxExtent) { throw new NotImplementedException(); }


        private double _TabCenteredScrollOffset(int index) { throw new NotImplementedException(); }


        private double _InitialScrollOffset(double viewportWidth, double minExtent, double maxExtent) { throw new NotImplementedException(); }


        private void _ScrollToCurrentIndex() { throw new NotImplementedException(); }


        private void _ScrollToControllerValue() { throw new NotImplementedException(); }


        private void _HandleTabControllerAnimationTick() { throw new NotImplementedException(); }


        private void _HandleTabControllerTick() { throw new NotImplementedException(); }


        private void _SaveTabOffsets(List<double> tabOffsets, TextDirection textDirection, double width) { throw new NotImplementedException(); }


        private void _HandleTap(int index) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildStyledTab(FlutterSDK.Widgets.Framework.Widget child, bool selected, FlutterSDK.Animation.Animation.Animation<double> animation) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A page view that displays the widget which corresponds to the currently
    /// selected tab.
    ///
    /// This widget is typically used in conjunction with a [TabBar].
    ///
    /// If a [TabController] is not provided, then there must be a [DefaultTabController]
    /// ancestor.
    ///
    /// The tab controller's [TabController.length] must equal the length of the
    /// [children] list and the length of the [TabBar.tabs] list.
    ///
    /// To see a sample implementation, visit the [TabController] documentation.
    /// </Summary>
    public class TabBarView : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public TabBarView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Material.Tabcontroller.TabController controller = default(FlutterSDK.Material.Tabcontroller.TabController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.Children = children;
            this.Controller = controller;
            this.Physics = physics;
            this.DragStartBehavior = dragStartBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Tabs._TabBarViewState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _TabBarViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Tabs.TabBarView>
    {
        #region constructors
        public _TabBarViewState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Material.Tabcontroller.TabController _Controller { get; set; }
        internal virtual FlutterSDK.Widgets.Pageview.PageController _PageController { get; set; }
        internal virtual List<FlutterSDK.Widgets.Framework.Widget> _Children { get; set; }
        internal virtual List<FlutterSDK.Widgets.Framework.Widget> _ChildrenWithKey { get; set; }
        internal virtual int _CurrentIndex { get; set; }
        internal virtual int _WarpUnderwayCount { get; set; }
        internal virtual bool _ControllerIsValid { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private void _UpdateTabController() { throw new NotImplementedException(); }


        public new void InitState() { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Tabs.TabBarView oldWidget) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _UpdateChildren() { throw new NotImplementedException(); }


        private void _HandleTabControllerAnimationTick() { throw new NotImplementedException(); }


        private Future<object> _WarpToCurrentIndex() { throw new NotImplementedException(); }


        private bool _HandleScrollNotification(FlutterSDK.Widgets.Scrollnotification.ScrollNotification notification) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Displays a single circle with the specified border and background colors.
    ///
    /// Used by [TabPageSelector] to indicate the selected page.
    /// </Summary>
    public class TabPageSelectorIndicator : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public TabPageSelectorIndicator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color borderColor = default(FlutterBinding.UI.Color), double size = default(double))
        : base(key: key)
        {
            this.BackgroundColor = backgroundColor;
            this.BorderColor = borderColor;
            this.Size = size; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        public virtual FlutterBinding.UI.Color BorderColor { get; set; }
        public virtual double Size { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Displays a row of small circular indicators, one per tab.
    ///
    /// The selected tab's indicator is highlighted. Often used in conjunction with
    /// a [TabBarView].
    ///
    /// If a [TabController] is not provided, then there must be a
    /// [DefaultTabController] ancestor.
    /// </Summary>
    public class TabPageSelector : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public TabPageSelector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Tabcontroller.TabController controller = default(FlutterSDK.Material.Tabcontroller.TabController), double indicatorSize = 12.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Controller = controller;
            this.IndicatorSize = indicatorSize;
            this.Color = color;
            this.SelectedColor = selectedColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        public virtual double IndicatorSize { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterBinding.UI.Color SelectedColor { get; set; }
        #endregion

        #region methods

        private FlutterSDK.Widgets.Framework.Widget _BuildTabIndicator(int tabIndex, FlutterSDK.Material.Tabcontroller.TabController tabController, FlutterSDK.Animation.Tween.ColorTween selectedColorTween, FlutterSDK.Animation.Tween.ColorTween previousColorTween) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Defines how the bounds of the selected tab indicator are computed.
    ///
    /// See also:
    ///
    ///  * [TabBar], which displays a row of tabs.
    ///  * [TabBarView], which displays a widget for the currently selected tab.
    ///  * [TabBar.indicator], which defines the appearance of the selected tab
    ///    indicator relative to the tab's bounds.
    /// </Summary>
    public enum TabBarIndicatorSize
    {

        /// <Summary>
        /// The tab indicator's bounds are as wide as the space occupied by the tab
        /// in the tab bar: from the right edge of the previous tab to the left edge
        /// of the next tab.
        /// </Summary>
        Tab,
        /// <Summary>
        /// The tab's bounds are only as wide as the (centered) tab widget itself.
        ///
        /// This value is used to align the tab's label, typically a [Tab]
        /// widget's text or icon, with the selected tab indicator.
        /// </Summary>
        Label,
    }

}
