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
            this.GetSelectedItemOffset = getSelectedItemOffset;
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

        public new void Paint(Canvas canvas, Size size)
        {
            double selectedItemOffset = GetSelectedItemOffset();
            Tween<double> top = new Tween<double>(begin: selectedItemOffset.Clamp(0.0, size.Height - DropdownDefaultClass._KMenuItemHeight) as double, end: 0.0);
            Tween<double> bottom = new Tween<double>(begin: (top.Begin + DropdownDefaultClass._KMenuItemHeight).Clamp(DropdownDefaultClass._KMenuItemHeight, size.Height) as double, end: size.Height);
            Rect rect = Rect.FromLTRB(0.0, top.Evaluate(Resize), size.Width, bottom.Evaluate(Resize));
            _Painter.Paint(canvas, rect.TopLeft, new ImageConfiguration(size: rect.Size));
        }




        public new bool ShouldRepaint(FlutterSDK.Material.Dropdown._DropdownMenuPainter oldPainter)
        {
            return oldPainter.Color != Color || oldPainter.Elevation != Elevation || oldPainter.SelectedIndex != SelectedIndex || oldPainter.Resize != Resize;
        }


        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            return oldPainter.Color != Color || oldPainter.Elevation != Elevation || oldPainter.SelectedIndex != SelectedIndex || oldPainter.Resize != Resize;
        }



        #endregion
    }


    public class _DropdownScrollBehavior : FlutterSDK.Widgets.Scrollconfiguration.ScrollBehavior
    {
        #region constructors
        public _DropdownScrollBehavior()
        {

        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Foundation.Platform.TargetPlatform GetPlatform(FlutterSDK.Widgets.Framework.BuildContext context) => ThemeDefaultClass.Theme.Of(context).Platform;



        public new FlutterSDK.Widgets.Framework.Widget BuildViewportChrome(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child, FlutterSDK.Painting.Basictypes.AxisDirection axisDirection) => child;



        public new FlutterSDK.Widgets.Scrollphysics.ScrollPhysics GetScrollPhysics(FlutterSDK.Widgets.Framework.BuildContext context) => new ClampingScrollPhysics();


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
            this.ItemIndex = itemIndex;
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

        public new _DropdownMenuItemButtonState<T> CreateState() => new _DropdownMenuItemButtonState<T>();


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

        private void _HandleFocusChange(bool focused)
        {
            bool inTraditionalMode = default(bool);
            switch (FocusmanagerDefaultClass.FocusManager.Instance.HighlightMode) { case FocusHighlightMode.Touch: inTraditionalMode = false; break; case FocusHighlightMode.Traditional: inTraditionalMode = true; break; }
            if (focused && inTraditionalMode)
            {
                _MenuLimits menuLimits = Widget.Route.GetMenuLimits(Widget.ButtonRect, Widget.Constraints.MaxHeight, Widget.ItemIndex);
                Widget.Route.ScrollController.AnimateTo(menuLimits.ScrollOffset, curve: CurvesDefaultClass.Curves.EaseInOut, duration: new TimeSpan(milliseconds: 100));
            }

        }




        private void _HandleOnTap()
        {
            DropdownMenuItem<T> dropdownMenuItem = Widget.Route.Items[Widget.ItemIndex].Item;
            if (dropdownMenuItem.OnTap != null)
            {
                dropdownMenuItem.OnTap();
            }

            NavigatorDefaultClass.Navigator.Pop(Context, new _DropdownRouteResult<T>(dropdownMenuItem.Value));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            CurvedAnimation opacity = default(CurvedAnimation);
            double unit = 0.5 / (Widget.Route.Items.Count + 1.5);
            if (Widget.ItemIndex == Widget.Route.SelectedIndex)
            {
                opacity = new CurvedAnimation(parent: Widget.Route.Animation, curve: new Threshold(0.0));
            }
            else
            {
                double start = (0.5 + (Widget.ItemIndex + 1) * unit).Clamp(0.0, 1.0) as double;
                double end = (start + 1.5 * unit).Clamp(0.0, 1.0) as double;
                opacity = new CurvedAnimation(parent: Widget.Route.Animation, curve: new Interval(start, end));
            }

            Widget child = new FadeTransition(opacity: opacity, child: new InkWell(autofocus: Widget.ItemIndex == Widget.Route.SelectedIndex, child: new Container(padding: Widget.Padding, child: Widget.Route.Items[Widget.ItemIndex]), onTap: _HandleOnTap, onFocusChange: _HandleFocusChange));
            if (ConstantsDefaultClass.KIsWeb)
            {
                child = new Shortcuts(shortcuts: _WebShortcuts, child: child);
            }

            return child;
        }



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
            this.DropdownColor = dropdownColor;
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

        public new _DropdownMenuState<T> CreateState() => new _DropdownMenuState<T>();


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

        public new void InitState()
        {
            base.InitState();
            _FadeOpacity = new CurvedAnimation(parent: Widget.Route.Animation, curve: new Interval(0.0, 0.25), reverseCurve: new Interval(0.75, 1.0));
            _Resize = new CurvedAnimation(parent: Widget.Route.Animation, curve: new Interval(0.25, 0.5), reverseCurve: new Threshold(0.0));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
            _DropdownRoute<T> route = Widget.Route;
            List<Widget> children = new List<Widget>() { };
            return new FadeTransition(opacity: _FadeOpacity, child: new CustomPaint(painter: new _DropdownMenuPainter(color: Widget.DropdownColor ?? ThemeDefaultClass.Theme.Of(context).CanvasColor, elevation: route.Elevation, selectedIndex: route.SelectedIndex, resize: _Resize, getSelectedItemOffset: () => =>route.GetItemOffset(route.SelectedIndex)), child: new Semantics(scopesRoute: true, namesRoute: true, explicitChildNodes: true, label: localizations.PopupMenuLabel, child: new Material(type: MaterialType.Transparency, textStyle: route.Style, child: new ScrollConfiguration(behavior: new _DropdownScrollBehavior(), child: new Scrollbar(child: new ListView(controller: Widget.Route.ScrollController, padding: ConstantsDefaultClass.KMaterialListPadding, shrinkWrap: true, children: children)))))));
        }



        #endregion
    }


    public class _DropdownMenuRouteLayout<T> : FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate
    {
        #region constructors
        public _DropdownMenuRouteLayout(FlutterBinding.UI.Rect buttonRect = default(FlutterBinding.UI.Rect), FlutterSDK.Material.Dropdown._DropdownRoute<T> route = default(FlutterSDK.Material.Dropdown._DropdownRoute<T>), TextDirection textDirection = default(TextDirection))
        {
            this.ButtonRect = buttonRect;
            this.Route = route;
            this.TextDirection = textDirection;
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Rect ButtonRect { get; set; }
        public virtual FlutterSDK.Material.Dropdown._DropdownRoute<T> Route { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Box.BoxConstraints GetConstraintsForChild(FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            double maxHeight = Math.Dart:mathDefaultClass.Max(0.0, constraints.MaxHeight - 2 * DropdownDefaultClass._KMenuItemHeight);
            double width = Math.Dart:mathDefaultClass.Min(constraints.MaxWidth, ButtonRect.Width);
            return new BoxConstraints(minWidth: width, maxWidth: width, minHeight: 0.0, maxHeight: maxHeight);
        }




        public new Offset GetPositionForChild(Size size, Size childSize)
        {
            _MenuLimits menuLimits = Route.GetMenuLimits(ButtonRect, size.Height, Route.SelectedIndex);


            double left = default(double);
            switch (TextDirection) { case TextDirection.Rtl: left = (ButtonRect.Right.Clamp(0.0, size.Width) as double) - childSize.Width; break; case TextDirection.Ltr: left = ButtonRect.Left.Clamp(0.0, size.Width - childSize.Width) as double; break; }
            return new Offset(left, menuLimits.Top);
        }




        public new bool ShouldRelayout(FlutterSDK.Material.Dropdown._DropdownMenuRouteLayout<T> oldDelegate)
        {
            return ButtonRect != oldDelegate.ButtonRect || TextDirection != oldDelegate.TextDirection;
        }



        #endregion
    }


    public class _DropdownRouteResult<T>
    {
        #region constructors
        public _DropdownRouteResult(T result)
        {
            this.Result = result;
        }
        #endregion

        #region fields
        public virtual T Result { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other)
        {
            return other is _DropdownRouteResult<T> && other.Result == Result;
        }



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
            this.ScrollOffset = scrollOffset;
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
            this.DropdownColor = dropdownColor;
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

        public new FlutterSDK.Widgets.Framework.Widget BuildPage(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation)
        {
            return new LayoutBuilder(builder: (BuildContext context, BoxConstraints constraints) =>
            {
                return new _DropdownRoutePage<T>(route: this, constraints: constraints, items: Items, padding: Padding, buttonRect: ButtonRect, selectedIndex: SelectedIndex, elevation: Elevation, theme: Theme, style: Style, dropdownColor: DropdownColor);
            }
            );
        }




        private void _Dismiss()
        {
            Navigator?.RemoveRoute(this);
        }




        public virtual double GetItemOffset(int index)
        {
            double offset = ConstantsDefaultClass.KMaterialListPadding.Top;
            if (Items.IsNotEmpty && index > 0)
            {

                offset += ItemHeights.Sublist(0, index).Reduce((double total, double height) => =>total + height);
            }

            return offset;
        }




        public virtual FlutterSDK.Material.Dropdown._MenuLimits GetMenuLimits(FlutterBinding.UI.Rect buttonRect, double availableHeight, int index)
        {
            double maxMenuHeight = availableHeight - 2.0 * DropdownDefaultClass._KMenuItemHeight;
            double buttonTop = buttonRect.Top;
            double buttonBottom = Math.Dart:mathDefaultClass.Min(buttonRect.Bottom, availableHeight);
            double selectedItemOffset = GetItemOffset(index);
            double topLimit = Math.Dart:mathDefaultClass.Min(DropdownDefaultClass._KMenuItemHeight, buttonTop);
            double bottomLimit = Math.Dart:mathDefaultClass.Max(availableHeight - DropdownDefaultClass._KMenuItemHeight, buttonBottom);
            double menuTop = (buttonTop - selectedItemOffset) - (ItemHeights[SelectedIndex] - buttonRect.Height) / 2.0;
            double preferredMenuHeight = ConstantsDefaultClass.KMaterialListPadding.Vertical;
            if (Items.IsNotEmpty) preferredMenuHeight += ItemHeights.Reduce((double total, double height) => =>total + height);
            double menuHeight = Math.Dart:mathDefaultClass.Min(maxMenuHeight, preferredMenuHeight);
            double menuBottom = menuTop + menuHeight;
            if (menuTop < topLimit) menuTop = Math.Dart:mathDefaultClass.Min(buttonTop, topLimit);
            if (menuBottom > bottomLimit)
            {
                menuBottom = Math.Dart:mathDefaultClass.Max(buttonBottom, bottomLimit);
                menuTop = menuBottom - menuHeight;
            }

            double scrollOffset = preferredMenuHeight <= maxMenuHeight ? 0 : Math.Dart:mathDefaultClass.Max(0.0, selectedItemOffset - (buttonTop - menuTop));
            return new _MenuLimits(menuTop, menuBottom, menuHeight, scrollOffset);
        }



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
            this.DropdownColor = dropdownColor;
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

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            if (Route.ScrollController == null)
            {
                _MenuLimits menuLimits = Route.GetMenuLimits(ButtonRect, Constraints.MaxHeight, SelectedIndex);
                Route.ScrollController = new ScrollController(initialScrollOffset: menuLimits.ScrollOffset);
            }

            TextDirection textDirection = BasicDefaultClass.Directionality.Of(context);
            Widget menu = new _DropdownMenu<T>(route: Route, padding: Padding.Resolve(textDirection), buttonRect: ButtonRect, constraints: Constraints, dropdownColor: DropdownColor);
            if (Theme != null) menu = new Theme(data: Theme, child: menu);
            return MediaQuery.RemovePadding(context: context, removeTop: true, removeBottom: true, removeLeft: true, removeRight: true, child: new Builder(builder: (BuildContext context) =>
            {
                return new CustomSingleChildLayout(@delegate: new _DropdownMenuRouteLayout<T>(buttonRect: ButtonRect, route: Route, textDirection: textDirection), child: menu);
            }
            ));
        }



        #endregion
    }


    public class _MenuItem<T> : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public _MenuItem(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Foundation.Basictypes.ValueChanged<Size> onLayout = default(FlutterSDK.Foundation.Basictypes.ValueChanged<Size>), FlutterSDK.Material.Dropdown.DropdownMenuItem<T> item = default(FlutterSDK.Material.Dropdown.DropdownMenuItem<T>))
        : base(key: key, child: item)
        {
            this.OnLayout = onLayout;
            this.Item = item;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<Size> OnLayout { get; set; }
        public virtual FlutterSDK.Material.Dropdown.DropdownMenuItem<T> Item { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderMenuItem(OnLayout);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Dropdown._RenderMenuItem renderObject)
        {
            renderObject.OnLayout = OnLayout;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.OnLayout = OnLayout;
        }



        #endregion
    }


    public class _RenderMenuItem : FlutterSDK.Rendering.Proxybox.RenderProxyBox
    {
        #region constructors
        public _RenderMenuItem(FlutterSDK.Foundation.Basictypes.ValueChanged<Size> onLayout, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(child)
        {
            this.OnLayout = onLayout;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<Size> OnLayout { get; set; }
        #endregion

        #region methods

        public new void PerformLayout()
        {
            base.PerformLayout();
            OnLayout(Size);
        }



        #endregion
    }


    public class _DropdownMenuItemContainer : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public _DropdownMenuItemContainer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Container(constraints: new BoxConstraints(minHeight: DropdownDefaultClass._KMenuItemHeight), alignment: AlignmentDefaultClass.AlignmentDirectional.CenterStart, child: Child);
        }



        #endregion
    }


    /// <Summary>
    /// An item in a menu created by a [DropdownButton].
    ///
    /// The type `T` is the type of the value the entry represents. All the entries
    /// in a given menu must represent values with consistent types.
    /// </Summary>
    public class DropdownMenuItem<T> : FlutterSDK.Material.Dropdown._DropdownMenuItemContainer
    {
        #region constructors
        public DropdownMenuItem(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onTap = default(VoidCallback), T value = default(T), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.OnTap = onTap;
            this.Value = value;
        }
        #endregion

        #region fields
        public virtual VoidCallback OnTap { get; set; }
        public virtual T Value { get; set; }
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// An inherited widget that causes any descendant [DropdownButton]
    /// widgets to not include their regular underline.
    ///
    /// This is used by [DataTable] to remove the underline from any
    /// [DropdownButton] widgets placed within material data tables, as
    /// required by the material design specification.
    /// </Summary>
    public class DropdownButtonHideUnderline : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public DropdownButtonHideUnderline(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {

        }
        #endregion

        #region fields
        #endregion

        #region methods

        /// <Summary>
        /// Returns whether the underline of [DropdownButton] widgets should
        /// be hidden.
        /// </Summary>
        public virtual bool At(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return context.DependOnInheritedWidgetOfExactType() != null;
        }




        public new bool UpdateShouldNotify(FlutterSDK.Material.Dropdown.DropdownButtonHideUnderline oldWidget) => false;

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => false;


        #endregion
    }


    /// <Summary>
    /// A material design button for selecting from a list of items.
    ///
    /// A dropdown button lets the user select from a number of items. The button
    /// shows the currently selected item as well as an arrow that opens a menu for
    /// selecting another item.
    ///
    /// The type `T` is the type of the [value] that each dropdown item represents.
    /// All the entries in a given menu must represent values with consistent types.
    /// Typically, an enum is used. Each [DropdownMenuItem] in [items] must be
    /// specialized with that same type argument.
    ///
    /// The [onChanged] callback should update a state variable that defines the
    /// dropdown's value. It should also call [State.setState] to rebuild the
    /// dropdown with the new value.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center}
    ///
    /// This sample shows a `DropdownButton` with a large arrow icon,
    /// purple text style, and bold purple underline, whose value is one of "One",
    /// "Two", "Free", or "Four".
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/dropdown_button.png)
    ///
    /// ```dart
    /// String dropdownValue = 'One';
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return DropdownButton<String>(
    ///     value: dropdownValue,
    ///     icon: Icon(Icons.arrow_downward),
    ///     iconSize: 24,
    ///     elevation: 16,
    ///     style: TextStyle(
    ///       color: Colors.deepPurple
    ///     ),
    ///     underline: Container(
    ///       height: 2,
    ///       color: Colors.deepPurpleAccent,
    ///     ),
    ///     onChanged: (String newValue) {
    ///       setState(() {
    ///         dropdownValue = newValue;
    ///       });
    ///     },
    ///     items: <String>['One', 'Two', 'Free', 'Four']
    ///       .map<DropdownMenuItem<String>>((String value) {
    ///         return DropdownMenuItem<String>(
    ///           value: value,
    ///           child: Text(value),
    ///         );
    ///       })
    ///       .toList(),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// If the [onChanged] callback is null or the list of [items] is null
    /// then the dropdown button will be disabled, i.e. its arrow will be
    /// displayed in grey and it will not respond to input. A disabled button
    /// will display the [disabledHint] widget if it is non-null. However, if
    /// [disabledHint] is null and [hint] is non-null, the [hint] widget will
    /// instead be displayed.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// See also:
    ///
    ///  * [DropdownMenuItem], the class used to represent the [items].
    ///  * [DropdownButtonHideUnderline], which prevents its descendant dropdown buttons
    ///    from displaying their underlines.
    ///  * [RaisedButton], [FlatButton], ordinary buttons that trigger a single action.
    ///  * <https://material.io/design/components/menus.html#dropdown-menu>
    /// </Summary>
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
            this.DropdownColor = dropdownColor;
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

        public new _DropdownButtonState<T> CreateState() => new _DropdownButtonState<T>();


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

        private FlutterSDK.Widgets.Focusmanager.FocusNode _CreateFocusNode()
        {
            return new FocusNode(debugLabel: $"'{Widget.GetType()}'");
        }




        public new void InitState()
        {
            base.InitState();
            _UpdateSelectedIndex();
            if (Widget.FocusNode == null)
            {
                _InternalNode = (_InternalNode == null ? _CreateFocusNode() : _InternalNode);
            }

            _ActionMap = new Dictionary<LocalKey, ActionFactory> { { ActionsDefaultClass.ActivateAction.Key, _CreateAction } };
            FocusNode.AddListener(_HandleFocusChanged);
            FocusManager focusManager = BindingDefaultClass.WidgetsBinding.Instance.FocusManager;
            _FocusHighlightMode = focusManager.HighlightMode;
            focusManager.AddHighlightModeListener(_HandleFocusHighlightModeChange);
        }




        public new void Dispose()
        {
            BindingDefaultClass.WidgetsBinding.Instance.RemoveObserver(this);
            _RemoveDropdownRoute();
            BindingDefaultClass.WidgetsBinding.Instance.FocusManager.RemoveHighlightModeListener(_HandleFocusHighlightModeChange);
            FocusNode.RemoveListener(_HandleFocusChanged);
            _InternalNode?.Dispose();
            base.Dispose();
        }




        private void _RemoveDropdownRoute()
        {
            _DropdownRoute?._Dismiss();
            _DropdownRoute = null;
            _LastOrientation = null;
        }




        private void _HandleFocusChanged()
        {
            if (_HasPrimaryFocus != FocusNode.HasPrimaryFocus)
            {
                SetState(() =>
                {
                    _HasPrimaryFocus = FocusNode.HasPrimaryFocus;
                }
                );
            }

        }




        private void _HandleFocusHighlightModeChange(FlutterSDK.Widgets.Focusmanager.FocusHighlightMode mode)
        {
            if (!Mounted)
            {
                return;
            }

            SetState(() =>
            {
                _FocusHighlightMode = mode;
            }
            );
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Dropdown.DropdownButton<T> oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.FocusNode != oldWidget.FocusNode)
            {
                oldWidget.FocusNode?.RemoveListener(_HandleFocusChanged);
                if (Widget.FocusNode == null)
                {
                    _InternalNode = (_InternalNode == null ? _CreateFocusNode() : _InternalNode);
                }

                _HasPrimaryFocus = FocusNode.HasPrimaryFocus;
                FocusNode.AddListener(_HandleFocusChanged);
            }

            _UpdateSelectedIndex();
        }




        private void _UpdateSelectedIndex()
        {
            if (!_Enabled)
            {
                return;
            }


            _SelectedIndex = null;
            for (int itemIndex = 0; itemIndex < Widget.Items.Count; itemIndex++)
            {
                if (Widget.Items[itemIndex].Value == Widget.Value)
                {
                    _SelectedIndex = itemIndex;
                    return;
                }

            }

        }




        private void _HandleTap()
        {
            RenderBox itemBox = Context.FindRenderObject() as RenderBox;
            Rect itemRect = itemBox.LocalToGlobal(Dart: uiDefaultClass.Offset.Zero) & itemBox.Size;
            TextDirection textDirection = BasicDefaultClass.Directionality.Of(Context);
            EdgeInsetsGeometry menuMargin = ButtonthemeDefaultClass.ButtonTheme.Of(Context).AlignedDropdown ? DropdownDefaultClass._KAlignedMenuMargin : DropdownDefaultClass._KUnalignedMenuMargin;
            List<_MenuItem<T>> menuItems = new List<_MenuItem<T>>(Widget.Items.Count);
            for (int index = 0; index < Widget.Items.Count; index += 1)
            {
                menuItems[index] = new _MenuItem<T>(item: Widget.Items[index], onLayout: (Size size) =>
                {
                    if (_DropdownRoute == null) return;
                    _DropdownRoute.ItemHeights[index] = size.Height;
                }
                );
            }


            _DropdownRoute = new _DropdownRoute<T>(items: menuItems, buttonRect: menuMargin.Resolve(textDirection).InflateRect(itemRect), padding: DropdownDefaultClass._KMenuItemPadding.Resolve(textDirection), selectedIndex: _SelectedIndex ?? 0, elevation: Widget.Elevation, theme: ThemeDefaultClass.Theme.Of(Context, shadowThemeOnly: true), style: _TextStyle, barrierLabel: MateriallocalizationsDefaultClass.MaterialLocalizations.Of(Context).ModalBarrierDismissLabel, itemHeight: Widget.ItemHeight, dropdownColor: Widget.DropdownColor);
            NavigatorDefaultClass.Navigator.Push(Context, _DropdownRoute).Then((_DropdownRouteResult<T> newValue) =>
            {
                _RemoveDropdownRoute();
                if (!Mounted || newValue == null) return;
                if (Widget.OnChanged != null) Widget.OnChanged(newValue.Result);
            }
            );
            if (Widget.OnTap != null)
            {
                Widget.OnTap();
            }

        }




        private FlutterSDK.Widgets.Actions.Action _CreateAction()
        {
            return new CallbackAction(ActionsDefaultClass.ActivateAction.Key, onInvoke: (FocusNode node, Intent intent) =>
            {
                _HandleTap();
            }
            );
        }




        private FlutterSDK.Widgets.Mediaquery.Orientation _GetOrientation(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Orientation result = MediaqueryDefaultClass.MediaQuery.Of(context, nullOk: true)?.Orientation;
            if (result == null)
            {
                Size size = Dart:uiDefaultClass.Window.PhysicalSize;
                result = size.Width > size.Height ? Orientation.Landscape : Orientation.Portrait;
            }

            return result;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {


            Orientation newOrientation = _GetOrientation(context);
            _LastOrientation = (_LastOrientation == null ? newOrientation : _LastOrientation);
            if (newOrientation != _LastOrientation)
            {
                _RemoveDropdownRoute();
                _LastOrientation = newOrientation;
            }

            List<Widget> items = default(List<Widget>);
            if (_Enabled)
            {
                items = Widget.SelectedItemBuilder == null ? List<Widget>.From(Widget.Items) : Widget.SelectedItemBuilder(context);
            }
            else
            {
                items = Widget.SelectedItemBuilder == null ? new List<Widget>() { } : Widget.SelectedItemBuilder(context);
            }

            int hintIndex = default(int);
            if (Widget.Hint != null || (!_Enabled && Widget.DisabledHint != null))
            {
                Widget displayedHint = _Enabled ? Widget.Hint : Widget.DisabledHint ?? Widget.Hint;
                if (Widget.SelectedItemBuilder == null) displayedHint = new _DropdownMenuItemContainer(child: displayedHint);
                hintIndex = items.Count;
                items.Add(new DefaultTextStyle(style: _TextStyle.CopyWith(color: ThemeDefaultClass.Theme.Of(context).HintColor), child: new IgnorePointer(ignoringSemantics: false, child: displayedHint)));
            }

            EdgeInsetsGeometry padding = ButtonthemeDefaultClass.ButtonTheme.Of(context).AlignedDropdown ? DropdownDefaultClass._KAlignedButtonPadding : DropdownDefaultClass._KUnalignedButtonPadding;
            int index = _Enabled ? (_SelectedIndex ?? hintIndex) : hintIndex;
            Widget innerItemsWidget = default(Widget);
            if (items.IsEmpty())
            {
                innerItemsWidget = new Container();
            }
            else
            {
                innerItemsWidget = new IndexedStack(index: index, alignment: AlignmentDefaultClass.AlignmentDirectional.CenterStart, children: Widget.IsDense ? items : items.Map((Widget item) =>
                {
                    return Widget.ItemHeight != null ? new SizedBox(height: Widget.ItemHeight, child: item) : new Column(mainAxisSize: MainAxisSize.Min, children: new List<Widget>() { item });
                }
                ).ToList());
            }

            Icon defaultIcon = new Icon(IconsDefaultClass.Icons.Arrow_drop_down);
            Widget result = new DefaultTextStyle(style: _TextStyle, child: new Container(decoration: _ShowHighlight ? new BoxDecoration(color: Widget.FocusColor ?? ThemeDefaultClass.Theme.Of(context).FocusColor, borderRadius: BorderRadius.All(Radius.Circular(4.0))) : null, padding: padding.Resolve(BasicDefaultClass.Directionality.Of(context)), height: Widget.IsDense ? _DenseButtonHeight : null, child: new Row(mainAxisAlignment: MainAxisAlignment.SpaceBetween, mainAxisSize: MainAxisSize.Min, children: new List<Widget>() { })));
            if (!DropdownDefaultClass.DropdownButtonHideUnderline.At(context))
            {
                double bottom = (Widget.IsDense || Widget.ItemHeight == null) ? 0.0 : 8.0;
                result = new Stack(children: new List<Widget>() { result, new Positioned(left: 0.0, right: 0.0, bottom: bottom, child: Widget.Underline ?? new Container(height: 1.0, decoration: new BoxDecoration(border: new Border(bottom: new BorderSide(color: new Color(0xFFBDBDBD), width: 0.0))))) });
            }

            return new Semantics(button: true, child: new Actions(actions: _ActionMap, child: new Focus(canRequestFocus: _Enabled, focusNode: FocusNode, autofocus: Widget.Autofocus, child: new GestureDetector(onTap: _Enabled ? _HandleTap : null, behavior: HitTestBehavior.Opaque, child: result))));
        }



        #endregion
    }


    /// <Summary>
    /// A convenience widget that wraps a [DropdownButton] in a [FormField].
    /// </Summary>
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
            this.Decoration = decoration;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<T> OnChanged { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration Decoration { get; set; }
        #endregion

        #region methods

        public new FormFieldState<T> CreateState() => new _DropdownButtonFormFieldState<T>();


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

        public new void DidChange(T value)
        {
            base.DidChange(value);

            Widget.OnChanged(value);
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Dropdown.DropdownButtonFormField<T> oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (oldWidget.InitialValue != Widget.InitialValue)
            {
                SetValue(Widget.InitialValue);
            }

        }



        #endregion
    }

}
