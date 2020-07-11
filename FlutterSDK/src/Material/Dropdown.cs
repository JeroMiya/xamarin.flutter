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
namespace FlutterSDK.Material.Dropdown
{
    public delegate List<FlutterSDK.Widgets.Framework.Widget> DropdownButtonBuilder(FlutterSDK.Widgets.Framework.BuildContext context);
    internal static class DropdownDefaultClass
    {
        public static TimeSpan _KDropdownMenuDuration = default(TimeSpan);
        public static double _KMenuItemHeight = default(double);
        public static double _KDenseButtonHeight = default(double);
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _KMenuItemPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _KAlignedButtonPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry);
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _KUnalignedButtonPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _KAlignedMenuMargin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _KUnalignedMenuMargin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry);
    }

    public class _DropdownMenuPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        #region constructors
        public _DropdownMenuPainter(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), int elevation = default(int), int selectedIndex = default(int), FlutterSDK.Animation.Animation.Animation<double> resize = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Foundation.Basictypes.ValueGetter<double> getSelectedItemOffset = default(FlutterSDK.Foundation.Basictypes.ValueGetter<double>))
        : base(repaint: resize)
        {
            this.Color = color;
            this.Elevation = elevation;
            this.SelectedIndex = selectedIndex;
            this.Resize = resize;
            this.GetSelectedItemOffset = getSelectedItemOffset; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual int Elevation { get; set; }
        public virtual int SelectedIndex { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Resize { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueGetter<double> GetSelectedItemOffset { get; set; }
        internal virtual FlutterSDK.Painting.Decoration.BoxPainter _Painter { get; set; }
        #endregion

        #region methods

        public new void Paint(Canvas canvas, Size size) { throw new NotImplementedException(); }


        public new bool ShouldRepaint(FlutterSDK.Material.Dropdown._DropdownMenuPainter oldPainter) { throw new NotImplementedException(); }
        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate) { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownScrollBehavior : FlutterSDK.Widgets.Scrollconfiguration.ScrollBehavior
    {
        #region constructors
        public _DropdownScrollBehavior()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Foundation.Platform.TargetPlatform GetPlatform(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget BuildViewportChrome(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Scrollphysics.ScrollPhysics GetScrollPhysics(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownMenuItemButton<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _DropdownMenuItemButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Material.Dropdown._DropdownRoute<T> route = default(FlutterSDK.Material.Dropdown._DropdownRoute<T>), FlutterBinding.UI.Rect buttonRect = default(FlutterBinding.UI.Rect), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints), int itemIndex = default(int))
        : base(key: key)
        {
            this.Padding = padding;
            this.Route = route;
            this.ButtonRect = buttonRect;
            this.Constraints = constraints;
            this.ItemIndex = itemIndex; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Dropdown._DropdownRoute<T> Route { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Padding { get; set; }
        public virtual FlutterBinding.UI.Rect ButtonRect { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
        public virtual int ItemIndex { get; set; }
        #endregion

        #region methods

        public new _DropdownMenuItemButtonState<T> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownMenuItemButtonState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Dropdown._DropdownMenuItemButton<T>>
    {
        #region constructors
        public _DropdownMenuItemButtonState()
        { }
        #endregion

        #region fields
        internal virtual Dictionary<FlutterSDK.Widgets.Shortcuts.LogicalKeySet, FlutterSDK.Widgets.Actions.Intent> _WebShortcuts { get; set; }
        #endregion

        #region methods

        private void _HandleFocusChange(bool focused) { throw new NotImplementedException(); }


        private void _HandleOnTap() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownMenu<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _DropdownMenu(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Material.Dropdown._DropdownRoute<T> route = default(FlutterSDK.Material.Dropdown._DropdownRoute<T>), FlutterBinding.UI.Rect buttonRect = default(FlutterBinding.UI.Rect), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterBinding.UI.Color dropdownColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Padding = padding;
            this.Route = route;
            this.ButtonRect = buttonRect;
            this.Constraints = constraints;
            this.DropdownColor = dropdownColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Dropdown._DropdownRoute<T> Route { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Padding { get; set; }
        public virtual FlutterBinding.UI.Rect ButtonRect { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
        public virtual FlutterBinding.UI.Color DropdownColor { get; set; }
        #endregion

        #region methods

        public new _DropdownMenuState<T> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownMenuState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Dropdown._DropdownMenu<T>>
    {
        #region constructors
        public _DropdownMenuState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Animations.CurvedAnimation _FadeOpacity { get; set; }
        internal virtual FlutterSDK.Animation.Animations.CurvedAnimation _Resize { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownMenuRouteLayout<T> : FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate
    {
        #region constructors
        public _DropdownMenuRouteLayout(FlutterBinding.UI.Rect buttonRect = default(FlutterBinding.UI.Rect), FlutterSDK.Material.Dropdown._DropdownRoute<T> route = default(FlutterSDK.Material.Dropdown._DropdownRoute<T>), TextDirection textDirection = default(TextDirection))
        {
            this.ButtonRect = buttonRect;
            this.Route = route;
            this.TextDirection = textDirection; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Rect ButtonRect { get; set; }
        public virtual FlutterSDK.Material.Dropdown._DropdownRoute<T> Route { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(FlutterSDK.Rendering.Box.BoxConstraints constraints) { throw new NotImplementedException(); }


        public new Offset GetPositionForChild(Size size, Size childSize) { throw new NotImplementedException(); }


        public new bool ShouldRelayout(FlutterSDK.Material.Dropdown._DropdownMenuRouteLayout<T> oldDelegate) { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownRouteResult<T>
    {
        #region constructors
        public _DropdownRouteResult(T result)
        {
            this.Result = result; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual T Result { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }

        #endregion
    }


    public class _MenuLimits
    {
        #region constructors
        public _MenuLimits(double top, double bottom, double height, double scrollOffset)
        {
            this.Top = top;
            this.Bottom = bottom;
            this.Height = height;
            this.ScrollOffset = scrollOffset; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Top { get; set; }
        public virtual double Bottom { get; set; }
        public virtual double Height { get; set; }
        public virtual double ScrollOffset { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class _DropdownRoute<T> : FlutterSDK.Widgets.Routes.PopupRoute<FlutterSDK.Material.Dropdown._DropdownRouteResult<T>>
    {
        #region constructors
        public _DropdownRoute(List<FlutterSDK.Material.Dropdown._MenuItem<T>> items = default(List<FlutterSDK.Material.Dropdown._MenuItem<T>>), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Rect buttonRect = default(FlutterBinding.UI.Rect), int selectedIndex = default(int), int elevation = 8, FlutterSDK.Material.Themedata.ThemeData theme = default(FlutterSDK.Material.Themedata.ThemeData), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), string barrierLabel = default(string), double itemHeight = default(double), FlutterBinding.UI.Color dropdownColor = default(FlutterBinding.UI.Color))
        : base()
        {
            this.Items = items;
            this.Padding = padding;
            this.ButtonRect = buttonRect;
            this.SelectedIndex = selectedIndex;
            this.Elevation = elevation;
            this.Theme = theme;
            this.Style = style;
            this.BarrierLabel = barrierLabel;
            this.ItemHeight = itemHeight;
            this.DropdownColor = dropdownColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Material.Dropdown._MenuItem<T>> Items { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public virtual FlutterBinding.UI.Rect ButtonRect { get; set; }
        public virtual int SelectedIndex { get; set; }
        public virtual int Elevation { get; set; }
        public virtual FlutterSDK.Material.Themedata.ThemeData Theme { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual double ItemHeight { get; set; }
        public virtual FlutterBinding.UI.Color DropdownColor { get; set; }
        public virtual List<double> ItemHeights { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController ScrollController { get; set; }
        public new string BarrierLabel { get; set; }
        public virtual TimeSpan TransitionDuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool BarrierDismissible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color BarrierColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation) { throw new NotImplementedException(); }


        private void _Dismiss() { throw new NotImplementedException(); }


        public virtual double GetItemOffset(int index) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Material.Dropdown._MenuLimits GetMenuLimits(FlutterBinding.UI.Rect buttonRect, double availableHeight, int index) { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownRoutePage<T> : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public _DropdownRoutePage(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Dropdown._DropdownRoute<T> route = default(FlutterSDK.Material.Dropdown._DropdownRoute<T>), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints), List<FlutterSDK.Material.Dropdown._MenuItem<T>> items = default(List<FlutterSDK.Material.Dropdown._MenuItem<T>>), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Rect buttonRect = default(FlutterBinding.UI.Rect), int selectedIndex = default(int), int elevation = 8, FlutterSDK.Material.Themedata.ThemeData theme = default(FlutterSDK.Material.Themedata.ThemeData), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterBinding.UI.Color dropdownColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Route = route;
            this.Constraints = constraints;
            this.Items = items;
            this.Padding = padding;
            this.ButtonRect = buttonRect;
            this.SelectedIndex = selectedIndex;
            this.Elevation = elevation;
            this.Theme = theme;
            this.Style = style;
            this.DropdownColor = dropdownColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Dropdown._DropdownRoute<T> Route { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
        public virtual List<FlutterSDK.Material.Dropdown._MenuItem<T>> Items { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public virtual FlutterBinding.UI.Rect ButtonRect { get; set; }
        public virtual int SelectedIndex { get; set; }
        public virtual int Elevation { get; set; }
        public virtual FlutterSDK.Material.Themedata.ThemeData Theme { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual FlutterBinding.UI.Color DropdownColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _MenuItem<T> : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public _MenuItem(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Foundation.Basictypes.ValueChanged<Size> onLayout = default(FlutterSDK.Foundation.Basictypes.ValueChanged<Size>), FlutterSDK.Material.Dropdown.DropdownMenuItem<T> item = default(FlutterSDK.Material.Dropdown.DropdownMenuItem<T>))
        : base(key: key, child: item)
        {
            this.OnLayout = onLayout;
            this.Item = item; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<Size> OnLayout { get; set; }
        public virtual FlutterSDK.Material.Dropdown.DropdownMenuItem<T> Item { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Dropdown._RenderMenuItem renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderMenuItem : FlutterSDK.Rendering.Proxybox.RenderProxyBox
    {
        #region constructors
        public _RenderMenuItem(FlutterSDK.Foundation.Basictypes.ValueChanged<Size> onLayout, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(child)
        {
            this.OnLayout = onLayout; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<Size> OnLayout { get; set; }
        #endregion

        #region methods

        public new void PerformLayout() { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownMenuItemContainer : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public _DropdownMenuItemContainer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class DropdownMenuItem<T> : FlutterSDK.Material.Dropdown._DropdownMenuItemContainer
    {
        #region constructors
        public DropdownMenuItem(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onTap = default(VoidCallback), T value = default(T), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.OnTap = onTap;
            this.Value = value; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual VoidCallback OnTap { get; set; }
        public virtual T Value { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class DropdownButtonHideUnderline : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public DropdownButtonHideUnderline(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual bool At(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new bool UpdateShouldNotify(FlutterSDK.Material.Dropdown.DropdownButtonHideUnderline oldWidget) { throw new NotImplementedException(); }
        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }

        #endregion
    }


    public class DropdownButton<T> : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public DropdownButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Material.Dropdown.DropdownMenuItem<T>> items = default(List<FlutterSDK.Material.Dropdown.DropdownMenuItem<T>>), FlutterSDK.Material.Dropdown.DropdownButtonBuilder selectedItemBuilder = default(FlutterSDK.Material.Dropdown.DropdownButtonBuilder), T value = default(T), FlutterSDK.Widgets.Framework.Widget hint = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget disabledHint = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Foundation.Basictypes.ValueChanged<T> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<T>), VoidCallback onTap = default(VoidCallback), int elevation = 8, FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget underline = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Color iconDisabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color iconEnabledColor = default(FlutterBinding.UI.Color), double iconSize = 24.0, bool isDense = false, bool isExpanded = false, double itemHeight = default(double), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color dropdownColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Items = items;
            this.SelectedItemBuilder = selectedItemBuilder;
            this.Value = value;
            this.Hint = hint;
            this.DisabledHint = disabledHint;
            this.OnChanged = onChanged;
            this.OnTap = onTap;
            this.Elevation = elevation;
            this.Style = style;
            this.Underline = underline;
            this.Icon = icon;
            this.IconDisabledColor = iconDisabledColor;
            this.IconEnabledColor = iconEnabledColor;
            this.IconSize = iconSize;
            this.IsDense = isDense;
            this.IsExpanded = isExpanded;
            this.ItemHeight = itemHeight;
            this.FocusColor = focusColor;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.DropdownColor = dropdownColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Material.Dropdown.DropdownMenuItem<T>> Items { get; set; }
        public virtual T Value { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Hint { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget DisabledHint { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<T> OnChanged { get; set; }
        public virtual VoidCallback OnTap { get; set; }
        public virtual FlutterSDK.Material.Dropdown.DropdownButtonBuilder SelectedItemBuilder { get; set; }
        public virtual int Elevation { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Underline { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        public virtual FlutterBinding.UI.Color IconDisabledColor { get; set; }
        public virtual FlutterBinding.UI.Color IconEnabledColor { get; set; }
        public virtual double IconSize { get; set; }
        public virtual bool IsDense { get; set; }
        public virtual bool IsExpanded { get; set; }
        public virtual double ItemHeight { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public virtual bool Autofocus { get; set; }
        public virtual FlutterBinding.UI.Color DropdownColor { get; set; }
        #endregion

        #region methods

        public new _DropdownButtonState<T> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownButtonState<T> : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Dropdown.DropdownButton<T>>, IWidgetsBindingObserver
    {
        #region constructors
        public _DropdownButtonState()
        { }
        #endregion

        #region fields
        internal virtual int _SelectedIndex { get; set; }
        internal virtual FlutterSDK.Material.Dropdown._DropdownRoute<T> _DropdownRoute { get; set; }
        internal virtual FlutterSDK.Widgets.Mediaquery.Orientation _LastOrientation { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _InternalNode { get; set; }
        internal virtual bool _HasPrimaryFocus { get; set; }
        internal virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> _ActionMap { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusHighlightMode _FocusHighlightMode { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Painting.Textstyle.TextStyle _TextStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _DenseButtonHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterBinding.UI.Color _IconColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _ShowHighlight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private FlutterSDK.Widgets.Focusmanager.FocusNode _CreateFocusNode() { throw new NotImplementedException(); }


        public new void InitState() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _RemoveDropdownRoute() { throw new NotImplementedException(); }


        private void _HandleFocusChanged() { throw new NotImplementedException(); }


        private void _HandleFocusHighlightModeChange(FlutterSDK.Widgets.Focusmanager.FocusHighlightMode mode) { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Dropdown.DropdownButton<T> oldWidget) { throw new NotImplementedException(); }


        private void _UpdateSelectedIndex() { throw new NotImplementedException(); }


        private void _HandleTap() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Actions.Action _CreateAction() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Mediaquery.Orientation _GetOrientation(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class DropdownButtonFormField<T> : FlutterSDK.Widgets.Form.FormField<T>
    {
        #region constructors
        public DropdownButtonFormField(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), T value = default(T), List<FlutterSDK.Material.Dropdown.DropdownMenuItem<T>> items = default(List<FlutterSDK.Material.Dropdown.DropdownMenuItem<T>>), FlutterSDK.Material.Dropdown.DropdownButtonBuilder selectedItemBuilder = default(FlutterSDK.Material.Dropdown.DropdownButtonBuilder), FlutterSDK.Widgets.Framework.Widget hint = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Foundation.Basictypes.ValueChanged<T> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<T>), VoidCallback onTap = default(VoidCallback), FlutterSDK.Material.Inputdecorator.InputDecoration decoration = default(FlutterSDK.Material.Inputdecorator.InputDecoration), FlutterSDK.Widgets.Form.FormFieldSetter<T> onSaved = default(FlutterSDK.Widgets.Form.FormFieldSetter<T>), FlutterSDK.Widgets.Form.FormFieldValidator<T> validator = default(FlutterSDK.Widgets.Form.FormFieldValidator<T>), bool autovalidate = false, FlutterSDK.Widgets.Framework.Widget disabledHint = default(FlutterSDK.Widgets.Framework.Widget), int elevation = 8, FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterBinding.UI.Color iconDisabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color iconEnabledColor = default(FlutterBinding.UI.Color), double iconSize = 24.0, bool isDense = true, bool isExpanded = false, double itemHeight = default(double))
        : base(key: key, onSaved: onSaved, initialValue: value, validator: validator, autovalidate: autovalidate, builder: (FormFieldState<T> field) =>
        {
            _DropdownButtonFormFieldState<T> state = field as _DropdownButtonFormFieldState<T>;
            InputDecoration effectiveDecoration = decoration.ApplyDefaults(ThemeDefaultClass.Theme.Of(field.Context).InputDecorationTheme);
            return new InputDecorator(decoration: effectiveDecoration.CopyWith(errorText: field.ErrorText), isEmpty: state.Value == null, child: new DropdownButtonHideUnderline(child: new DropdownButton<T>(value: state.Value, items: items, selectedItemBuilder: selectedItemBuilder, hint: hint, onChanged: onChanged == null ? null : state.DidChange, onTap: onTap, disabledHint: disabledHint, elevation: elevation, style: style, icon: icon, iconDisabledColor: iconDisabledColor, iconEnabledColor: iconEnabledColor, iconSize: iconSize, isDense: isDense, isExpanded: isExpanded, itemHeight: itemHeight)));
        })
        {
            this.OnChanged = onChanged;
            this.Decoration = decoration; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<T> OnChanged { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration Decoration { get; set; }
        #endregion

        #region methods

        public new FormFieldState<T> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _DropdownButtonFormFieldState<T> : FlutterSDK.Widgets.Form.FormFieldState<T>
    {
        #region constructors
        public _DropdownButtonFormFieldState()
        { }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Dropdown.DropdownButtonFormField<T> Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void DidChange(T value) { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Dropdown.DropdownButtonFormField<T> oldWidget) { throw new NotImplementedException(); }

        #endregion
    }

}
