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
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Typography;
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
using FlutterSDK.Scheduler;
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
            double controllerValue = controller.Animation.Value;
            double previousIndex = controller.PreviousIndex.ToDouble();
            double currentIndex = controller.Index.ToDouble();
            if (!controller.IndexIsChanging) return (currentIndex - controllerValue).Abs().Clamp(0.0, 1.0) as double;
            return (controllerValue - currentIndex).Abs() / (currentIndex - previousIndex).Abs();
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
        /// <Summary>
        /// Creates a material design [TabBar] tab.
        ///
        /// At least one of [text], [icon], and [child] must be non-null. The [text]
        /// and [child] arguments must not be used at the same time. The
        /// [iconMargin] is only useful when [icon] and either one of [text] or
        /// [child] is non-null.
        /// </Summary>
        public Tab(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), string text = default(string), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry iconMargin = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Text = text;
            this.Icon = icon;
            this.IconMargin = iconMargin;
            this.Child = child;
        }
        /// <Summary>
        /// The text to display as the tab's label.
        ///
        /// Must not be used in combination with [child].
        /// </Summary>
        public virtual string Text { get; set; }
        /// <Summary>
        /// The widget to be used as the tab's label.
        ///
        /// Usually a [Text] widget, possibly wrapped in a [Semantics] widget.
        ///
        /// Must not be used in combination with [text].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// An icon to display as the tab's label.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        /// <Summary>
        /// The margin added around the tab's icon.
        ///
        /// Only useful when used in combination with [icon], and either one of
        /// [text] or [child] is non-null.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry IconMargin { get; set; }

        private FlutterSDK.Widgets.Framework.Widget _BuildLabelText()
        {
            return Child ?? new Text(Text, softWrap: false, overflow: TextOverflow.Fade);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            double height = default(double);
            Widget label = default(Widget);
            if (Icon == null)
            {
                height = TabsDefaultClass._KTabHeight;
                label = _BuildLabelText();
            }
            else if (Text == null && Child == null)
            {
                height = TabsDefaultClass._KTabHeight;
                label = Icon;
            }
            else
            {
                height = TabsDefaultClass._KTextAndIconTabHeight;
                label = new Column(mainAxisAlignment: MainAxisAlignment.Center, crossAxisAlignment: CrossAxisAlignment.Center, children: new List<Widget>() { new Container(child: Icon, margin: IconMargin), _BuildLabelText() });
            }

            return new SizedBox(height: height, child: new Center(child: label, widthFactor: 1.0));
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new StringProperty("text", Text, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Widget>("icon", Icon, defaultValue: null));
        }



    }


    public class _TabStyle : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        public _TabStyle(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), bool selected = default(bool), FlutterBinding.UI.Color labelColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color unselectedLabelColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle unselectedLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: animation)
        {
            this.Selected = selected;
            this.LabelColor = labelColor;
            this.UnselectedLabelColor = unselectedLabelColor;
            this.LabelStyle = labelStyle;
            this.UnselectedLabelStyle = unselectedLabelStyle;
            this.Child = child;
        }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle UnselectedLabelStyle { get; set; }
        public virtual bool Selected { get; set; }
        public virtual FlutterBinding.UI.Color LabelColor { get; set; }
        public virtual FlutterBinding.UI.Color UnselectedLabelColor { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
            TabBarTheme tabBarTheme = TabbarthemeDefaultClass.TabBarTheme.Of(context);
            Animation<double> animation = Listenable as Animation<double>;
            TextStyle defaultStyle = (LabelStyle ?? tabBarTheme.LabelStyle ?? themeData.PrimaryTextTheme.BodyText1).CopyWith(inherit: true);
            TextStyle defaultUnselectedStyle = (UnselectedLabelStyle ?? tabBarTheme.UnselectedLabelStyle ?? LabelStyle ?? themeData.PrimaryTextTheme.BodyText1).CopyWith(inherit: true);
            TextStyle textStyle = Selected ? TextstyleDefaultClass.TextStyle.Lerp(defaultStyle, defaultUnselectedStyle, animation.Value) : TextstyleDefaultClass.TextStyle.Lerp(defaultUnselectedStyle, defaultStyle, animation.Value);
            Color selectedColor = LabelColor ?? tabBarTheme.LabelColor ?? themeData.PrimaryTextTheme.BodyText1.Color;
            Color unselectedColor = UnselectedLabelColor ?? tabBarTheme.UnselectedLabelColor ?? selectedColor.WithAlpha(0xB2);
            Color color = Selected ? Dart.UI.UiDefaultClass.Color.Lerp(selectedColor, unselectedColor, animation.Value) : Dart.UI.UiDefaultClass.Color.Lerp(unselectedColor, selectedColor, animation.Value);
            return new DefaultTextStyle(style: textStyle.CopyWith(color: color), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(size: 24.0, color: color), child: Child));
        }



    }


    public class _TabLabelBarRenderer : FlutterSDK.Rendering.Flex.RenderFlex
    {
        public _TabLabelBarRenderer(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), FlutterSDK.Painting.Basictypes.Axis direction = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), FlutterSDK.Material.Tabs._LayoutCallback onPerformLayout = default(FlutterSDK.Material.Tabs._LayoutCallback))
        : base(children: children, direction: direction, mainAxisSize: mainAxisSize, mainAxisAlignment: mainAxisAlignment, crossAxisAlignment: crossAxisAlignment, textDirection: textDirection, verticalDirection: verticalDirection)
        {
            this.OnPerformLayout = onPerformLayout;
        }
        public virtual FlutterSDK.Material.Tabs._LayoutCallback OnPerformLayout { get; set; }

        public new void PerformLayout()
        {
            base.PerformLayout();
            RenderBox child = FirstChild;
            List<double> xOffsets = new List<double>() { };
            while (child != null)
            {
                FlexParentData childParentData = child.ParentData as FlexParentData;
                xOffsets.Add(childParentData.Offset.Dx);

                child = childParentData.NextSibling;
            }


            switch (TextDirection) { case TextDirection.Rtl: xOffsets.Insert(0, Size.Width); break; case TextDirection.Ltr: xOffsets.Add(Size.Width); break; }
            OnPerformLayout(xOffsets, TextDirection, Size.Width);
        }



    }


    public class _TabLabelBar : FlutterSDK.Widgets.Basic.Flex
    {
        public _TabLabelBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Material.Tabs._LayoutCallback onPerformLayout = default(FlutterSDK.Material.Tabs._LayoutCallback))
        : base(key: key, children: children, direction: Axis.Horizontal, mainAxisSize: MainAxisSize.Max, mainAxisAlignment: MainAxisAlignment.Start, crossAxisAlignment: CrossAxisAlignment.Center, verticalDirection: VerticalDirection.Down)
        {
            this.OnPerformLayout = onPerformLayout;
        }
        public virtual FlutterSDK.Material.Tabs._LayoutCallback OnPerformLayout { get; set; }

        public new FlutterSDK.Rendering.Flex.RenderFlex CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _TabLabelBarRenderer(direction: Direction, mainAxisAlignment: MainAxisAlignment, mainAxisSize: MainAxisSize, crossAxisAlignment: CrossAxisAlignment, textDirection: GetEffectiveTextDirection(context), verticalDirection: VerticalDirection, onPerformLayout: OnPerformLayout);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Tabs._TabLabelBarRenderer renderObject)
        {
            base.UpdateRenderObject(context, renderObject);
            renderObject.OnPerformLayout = OnPerformLayout;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            base.UpdateRenderObject(context, renderObject);
            renderObject.OnPerformLayout = OnPerformLayout;
        }



    }


    public class _IndicatorPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        public _IndicatorPainter(FlutterSDK.Material.Tabcontroller.TabController controller = default(FlutterSDK.Material.Tabcontroller.TabController), FlutterSDK.Painting.Decoration.Decoration indicator = default(FlutterSDK.Painting.Decoration.Decoration), FlutterSDK.Material.Tabs.TabBarIndicatorSize indicatorSize = default(FlutterSDK.Material.Tabs.TabBarIndicatorSize), List<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>> tabKeys = default(List<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>>), FlutterSDK.Material.Tabs._IndicatorPainter old = default(FlutterSDK.Material.Tabs._IndicatorPainter))
        : base(repaint: controller.Animation)
        {
            this.Controller = controller;
            this.Indicator = indicator;
            this.IndicatorSize = indicatorSize;
            this.TabKeys = tabKeys;
            if (old != null) SaveTabOffsets(old._CurrentTabOffsets, old._CurrentTextDirection);
        }


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

        public virtual void MarkNeedsPaint()
        {
            _NeedsPaint = true;
        }




        public virtual void Dispose()
        {
            _Painter?.Dispose();
        }




        public virtual void SaveTabOffsets(List<double> tabOffsets, TextDirection textDirection)
        {
            _CurrentTabOffsets = tabOffsets;
            _CurrentTextDirection = textDirection;
        }




        public virtual double CenterOf(int tabIndex)
        {




            return (_CurrentTabOffsets[tabIndex] + _CurrentTabOffsets[tabIndex + 1]) / 2.0;
        }




        public virtual Rect IndicatorRect(Size tabBarSize, int tabIndex)
        {





            double tabLeft tabRight = default(double);
            switch (_CurrentTextDirection) { case TextDirection.Rtl: tabLeft = _CurrentTabOffsets[tabIndex + 1]; tabRight = _CurrentTabOffsets[tabIndex]; break; case TextDirection.Ltr: tabLeft = _CurrentTabOffsets[tabIndex]; tabRight = _CurrentTabOffsets[tabIndex + 1]; break; }
            if (IndicatorSize == TabBarIndicatorSize.Label)
            {
                double tabWidth = TabKeys[tabIndex].CurrentContext.Size.Width;
                double delta = ((tabRight - tabLeft) - tabWidth) / 2.0;
                tabLeft += delta;
                tabRight -= delta;
            }

            return Rect.FromLTWH(tabLeft, 0.0, tabRight - tabLeft, tabBarSize.Height);
        }




        public new void Paint(Canvas canvas, Size size)
        {
            _NeedsPaint = false;
            _Painter = (_Painter == null ? Indicator.CreateBoxPainter(MarkNeedsPaint) : _Painter);
            if (Controller.IndexIsChanging)
            {
                Rect targetRect = IndicatorRect(size, Controller.Index);
                _CurrentRect = Dart.UI.UiDefaultClass.Rect.Lerp(targetRect, _CurrentRect ?? targetRect, TabsDefaultClass._IndexChangeProgress(Controller));
            }
            else
            {
                int currentIndex = Controller.Index;
                Rect previous = currentIndex > 0 ? IndicatorRect(size, currentIndex - 1) : null;
                Rect middle = IndicatorRect(size, currentIndex);
                Rect next = currentIndex < MaxTabIndex ? IndicatorRect(size, currentIndex + 1) : null;
                double index = Controller.Index.ToDouble();
                double value = Controller.Animation.Value;
                if (value == index - 1.0) _CurrentRect = previous ?? middle; else if (value == index + 1.0) _CurrentRect = next ?? middle; else if (value == index) _CurrentRect = middle; else if (value < index) _CurrentRect = previous == null ? middle : Dart.UI.UiDefaultClass.Rect.Lerp(middle, previous, index - value); else _CurrentRect = next == null ? middle : Dart.UI.UiDefaultClass.Rect.Lerp(middle, next, value - index);
            }


            ImageConfiguration configuration = new ImageConfiguration(size: _CurrentRect.Size, textDirection: _CurrentTextDirection);
            _Painter.Paint(canvas, _CurrentRect.TopLeft, configuration);
        }




        private bool _TabOffsetsEqual(List<double> a, List<double> b)
        {
            if (a == null || b == null || a.Count != b.Count) return false;
            for (int i = 0; i < a.Count; i += 1)
            {
                if (a[i] != b[i]) return false;
            }

            return true;
        }




        public new bool ShouldRepaint(FlutterSDK.Material.Tabs._IndicatorPainter old)
        {
            return _NeedsPaint || Controller != old.Controller || Indicator != old.Indicator || TabKeys.Count != old.TabKeys.Count || (!_TabOffsetsEqual(_CurrentTabOffsets, old._CurrentTabOffsets)) || _CurrentTextDirection != old._CurrentTextDirection;
        }


        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            return _NeedsPaint || Controller != old.Controller || Indicator != old.Indicator || TabKeys.Count != old.TabKeys.Count || (!_TabOffsetsEqual(_CurrentTabOffsets, old._CurrentTabOffsets)) || _CurrentTextDirection != old._CurrentTextDirection;
        }



    }


    public class _ChangeAnimation : FlutterSDK.Animation.Animation.Animation<double>, IAnimationWithParentMixin<double>
    {
        public _ChangeAnimation(FlutterSDK.Material.Tabcontroller.TabController controller)
        {
            this.Controller = controller;
        }
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Parent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener)
        {
            if (Parent != null) base.RemoveStatusListener(listener);
        }




        public new void RemoveListener(VoidCallback listener)
        {
            if (Parent != null) base.RemoveListener(listener);
        }



    }


    public class _DragAnimation : FlutterSDK.Animation.Animation.Animation<double>, IAnimationWithParentMixin<double>
    {
        public _DragAnimation(FlutterSDK.Material.Tabcontroller.TabController controller, int index)
        {
            this.Controller = controller;
            this.Index = index;
        }
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        public virtual int Index { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Parent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void RemoveStatusListener(FlutterSDK.Animation.Animation.AnimationStatusListener listener)
        {
            if (Parent != null) base.RemoveStatusListener(listener);
        }




        public new void RemoveListener(VoidCallback listener)
        {
            if (Parent != null) base.RemoveListener(listener);
        }



    }


    public class _TabBarScrollPosition : FlutterSDK.Widgets.Scrollpositionwithsinglecontext.ScrollPositionWithSingleContext
    {
        public _TabBarScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Widgets.Scrollcontext.ScrollContext context = default(FlutterSDK.Widgets.Scrollcontext.ScrollContext), FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition = default(FlutterSDK.Widgets.Scrollposition.ScrollPosition), FlutterSDK.Material.Tabs._TabBarState tabBar = default(FlutterSDK.Material.Tabs._TabBarState))
        : base(physics: physics, context: context, initialPixels: null, oldPosition: oldPosition)
        {
            this.TabBar = tabBar;
        }
        public virtual FlutterSDK.Material.Tabs._TabBarState TabBar { get; set; }
        internal virtual bool _InitialViewportDimensionWasZero { get; set; }

        public new bool ApplyContentDimensions(double minScrollExtent, double maxScrollExtent)
        {
            bool result = true;
            if (_InitialViewportDimensionWasZero != true)
            {

                _InitialViewportDimensionWasZero = ViewportDimension != 0.0;
                CorrectPixels(TabBar._InitialScrollOffset(ViewportDimension, minScrollExtent, maxScrollExtent));
                result = false;
            }

            return base.ApplyContentDimensions(minScrollExtent, maxScrollExtent) && result;
        }



    }


    public class _TabBarScrollController : FlutterSDK.Widgets.Scrollcontroller.ScrollController
    {
        public _TabBarScrollController(FlutterSDK.Material.Tabs._TabBarState tabBar)
        {
            this.TabBar = tabBar;
        }
        public virtual FlutterSDK.Material.Tabs._TabBarState TabBar { get; set; }

        public new FlutterSDK.Widgets.Scrollposition.ScrollPosition CreateScrollPosition(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics, FlutterSDK.Widgets.Scrollcontext.ScrollContext context, FlutterSDK.Widgets.Scrollposition.ScrollPosition oldPosition)
        {
            return new _TabBarScrollPosition(physics: physics, context: context, oldPosition: oldPosition, tabBar: TabBar);
        }



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
        /// <Summary>
        /// Creates a material design tab bar.
        ///
        /// The [tabs] argument must not be null and its length must match the [controller]'s
        /// [TabController.length].
        ///
        /// If a [TabController] is not provided, then there must be a
        /// [DefaultTabController] ancestor.
        ///
        /// The [indicatorWeight] parameter defaults to 2, and must not be null.
        ///
        /// The [indicatorPadding] parameter defaults to [EdgeInsets.zero], and must not be null.
        ///
        /// If [indicator] is not null, then [indicatorWeight], [indicatorPadding], and
        /// [indicatorColor] are ignored.
        /// </Summary>
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
            this.OnTap = onTap;
        }
        /// <Summary>
        /// Typically a list of two or more [Tab] widgets.
        ///
        /// The length of this list must match the [controller]'s [TabController.length]
        /// and the length of the [TabBarView.children] list.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Tabs { get; set; }
        /// <Summary>
        /// This widget's selection and animation state.
        ///
        /// If [TabController] is not provided, then the value of [DefaultTabController.of]
        /// will be used.
        /// </Summary>
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        /// <Summary>
        /// Whether this tab bar can be scrolled horizontally.
        ///
        /// If [isScrollable] is true, then each tab is as wide as needed for its label
        /// and the entire [TabBar] is scrollable. Otherwise each tab gets an equal
        /// share of the available space.
        /// </Summary>
        public virtual bool IsScrollable { get; set; }
        /// <Summary>
        /// The color of the line that appears below the selected tab.
        ///
        /// If this parameter is null, then the value of the Theme's indicatorColor
        /// property is used.
        ///
        /// If [indicator] is specified, this property is ignored.
        /// </Summary>
        public virtual FlutterBinding.UI.Color IndicatorColor { get; set; }
        /// <Summary>
        /// The thickness of the line that appears below the selected tab.
        ///
        /// The value of this parameter must be greater than zero and its default
        /// value is 2.0.
        ///
        /// If [indicator] is specified, this property is ignored.
        /// </Summary>
        public virtual double IndicatorWeight { get; set; }
        /// <Summary>
        /// The horizontal padding for the line that appears below the selected tab.
        ///
        /// For [isScrollable] tab bars, specifying [kTabLabelPadding] will align
        /// the indicator with the tab's text for [Tab] widgets and all but the
        /// shortest [Tab.text] values.
        ///
        /// The [EdgeInsets.top] and [EdgeInsets.bottom] values of the
        /// [indicatorPadding] are ignored.
        ///
        /// The default value of [indicatorPadding] is [EdgeInsets.zero].
        ///
        /// If [indicator] is specified, this property is ignored.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry IndicatorPadding { get; set; }
        /// <Summary>
        /// Defines the appearance of the selected tab indicator.
        ///
        /// If [indicator] is specified, the [indicatorColor], [indicatorWeight],
        /// and [indicatorPadding] properties are ignored.
        ///
        /// The default, underline-style, selected tab indicator can be defined with
        /// [UnderlineTabIndicator].
        ///
        /// The indicator's size is based on the tab's bounds. If [indicatorSize]
        /// is [TabBarIndicatorSize.tab] the tab's bounds are as wide as the space
        /// occupied by the tab in the tab bar. If [indicatorSize] is
        /// [TabBarIndicatorSize.label], then the tab's bounds are only as wide as
        /// the tab widget itself.
        /// </Summary>
        public virtual FlutterSDK.Painting.Decoration.Decoration Indicator { get; set; }
        /// <Summary>
        /// Defines how the selected tab indicator's size is computed.
        ///
        /// The size of the selected tab indicator is defined relative to the
        /// tab's overall bounds if [indicatorSize] is [TabBarIndicatorSize.tab]
        /// (the default) or relative to the bounds of the tab's widget if
        /// [indicatorSize] is [TabBarIndicatorSize.label].
        ///
        /// The selected tab's location appearance can be refined further with
        /// the [indicatorColor], [indicatorWeight], [indicatorPadding], and
        /// [indicator] properties.
        /// </Summary>
        public virtual FlutterSDK.Material.Tabs.TabBarIndicatorSize IndicatorSize { get; set; }
        /// <Summary>
        /// The color of selected tab labels.
        ///
        /// Unselected tab labels are rendered with the same color rendered at 70%
        /// opacity unless [unselectedLabelColor] is non-null.
        ///
        /// If this parameter is null, then the color of the [ThemeData.primaryTextTheme]'s
        /// bodyText1 text color is used.
        /// </Summary>
        public virtual FlutterBinding.UI.Color LabelColor { get; set; }
        /// <Summary>
        /// The color of unselected tab labels.
        ///
        /// If this property is null, unselected tab labels are rendered with the
        /// [labelColor] with 70% opacity.
        /// </Summary>
        public virtual FlutterBinding.UI.Color UnselectedLabelColor { get; set; }
        /// <Summary>
        /// The text style of the selected tab labels.
        ///
        /// If [unselectedLabelStyle] is null, then this text style will be used for
        /// both selected and unselected label styles.
        ///
        /// If this property is null, then the text style of the
        /// [ThemeData.primaryTextTheme]'s bodyText1 definition is used.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        /// <Summary>
        /// The padding added to each of the tab labels.
        ///
        /// If this property is null, then kTabLabelPadding is used.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get; set; }
        /// <Summary>
        /// The text style of the unselected tab labels
        ///
        /// If this property is null, then the [labelStyle] value is used. If [labelStyle]
        /// is null, then the text style of the [ThemeData.primaryTextTheme]'s
        /// bodyText1 definition is used.
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle UnselectedLabelStyle { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.scrollable.dragStartBehavior}
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        /// <Summary>
        /// An optional callback that's called when the [TabBar] is tapped.
        ///
        /// The callback is applied to the index of the tab where the tap occurred.
        ///
        /// This callback has no effect on the default handling of taps. It's for
        /// applications that want to do a little extra work when a tab is tapped,
        /// even if the tap doesn't change the TabController's index. TabBar [onTap]
        /// callbacks should not make changes to the TabController since that would
        /// interfere with the default tap handler.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<int> OnTap { get; set; }
        public virtual Size PreferredSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Material.Tabs._TabBarState CreateState() => new _TabBarState();


    }


    public class _TabBarState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Tabs.TabBar>
    {
        public _TabBarState()
        { }
        internal virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController _ScrollController { get; set; }
        internal virtual FlutterSDK.Material.Tabcontroller.TabController _Controller { get; set; }
        internal virtual FlutterSDK.Material.Tabs._IndicatorPainter _IndicatorPainter { get; set; }
        internal virtual int _CurrentIndex { get; set; }
        internal virtual double _TabStripWidth { get; set; }
        internal virtual List<FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>>> _TabKeys { get; set; }
        internal virtual FlutterSDK.Painting.Decoration.Decoration _Indicator { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _ControllerIsValid { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int MaxTabIndex { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _TabKeys = Widget.Tabs.Map((Widget tab) => =>new GlobalKey()).ToList();
        }




        private void _UpdateTabController()
        {
            TabController newController = Widget.Controller ?? TabcontrollerDefaultClass.DefaultTabController.Of(Context);

            if (newController == _Controller) return;
            if (_ControllerIsValid)
            {
                _Controller.Animation.RemoveListener(_HandleTabControllerAnimationTick);
                _Controller.RemoveListener(_HandleTabControllerTick);
            }

            _Controller = newController;
            if (_Controller != null)
            {
                _Controller.Animation.AddListener(_HandleTabControllerAnimationTick);
                _Controller.AddListener(_HandleTabControllerTick);
                _CurrentIndex = _Controller.Index;
            }

        }




        private void _InitIndicatorPainter()
        {
            _IndicatorPainter = !_ControllerIsValid ? null : new _IndicatorPainter(controller: _Controller, indicator: _Indicator, indicatorSize: Widget.IndicatorSize ?? TabbarthemeDefaultClass.TabBarTheme.Of(Context).IndicatorSize, tabKeys: _TabKeys, old: _IndicatorPainter);
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();

            _UpdateTabController();
            _InitIndicatorPainter();
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Tabs.TabBar oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Controller != oldWidget.Controller)
            {
                _UpdateTabController();
                _InitIndicatorPainter();
            }
            else if (Widget.IndicatorColor != oldWidget.IndicatorColor || Widget.IndicatorWeight != oldWidget.IndicatorWeight || Widget.IndicatorSize != oldWidget.IndicatorSize || Widget.Indicator != oldWidget.Indicator)
            {
                _InitIndicatorPainter();
            }

            if (Widget.Tabs.Count > oldWidget.Tabs.Count)
            {
                int delta = Widget.Tabs.Count - oldWidget.Tabs.Count;
                _TabKeys.AddAll(List<GlobalKey>.Generate(delta, (int n) => =>new GlobalKey()));
            }
            else if (Widget.Tabs.Count < oldWidget.Tabs.Count)
            {
                _TabKeys.RemoveRange(Widget.Tabs.Count, oldWidget.Tabs.Count);
            }

        }




        public new void Dispose()
        {
            _IndicatorPainter.Dispose();
            if (_ControllerIsValid)
            {
                _Controller.Animation.RemoveListener(_HandleTabControllerAnimationTick);
                _Controller.RemoveListener(_HandleTabControllerTick);
            }

            _Controller = null;
            base.Dispose();
        }




        private double _TabScrollOffset(int index, double viewportWidth, double minExtent, double maxExtent)
        {
            if (!Widget.IsScrollable) return 0.0;
            double tabCenter = _IndicatorPainter.CenterOf(index);
            switch (BasicDefaultClass.Directionality.Of(Context)) { case TextDirection.Rtl: tabCenter = _TabStripWidth - tabCenter; break; case TextDirection.Ltr: break; }
            return (tabCenter - viewportWidth / 2.0).Clamp(minExtent, maxExtent) as double;
        }




        private double _TabCenteredScrollOffset(int index)
        {
            ScrollPosition position = _ScrollController.Position;
            return _TabScrollOffset(index, position.ViewportDimension, position.MinScrollExtent, position.MaxScrollExtent);
        }




        private double _InitialScrollOffset(double viewportWidth, double minExtent, double maxExtent)
        {
            return _TabScrollOffset(_CurrentIndex, viewportWidth, minExtent, maxExtent);
        }




        private void _ScrollToCurrentIndex()
        {
            double offset = _TabCenteredScrollOffset(_CurrentIndex);
            _ScrollController.AnimateTo(offset, duration: ConstantsDefaultClass.KTabScrollDuration, curve: CurvesDefaultClass.Curves.Ease);
        }




        private void _ScrollToControllerValue()
        {
            double leadingPosition = _CurrentIndex > 0 ? _TabCenteredScrollOffset(_CurrentIndex - 1) : null;
            double middlePosition = _TabCenteredScrollOffset(_CurrentIndex);
            double trailingPosition = _CurrentIndex < MaxTabIndex ? _TabCenteredScrollOffset(_CurrentIndex + 1) : null;
            double index = _Controller.Index.ToDouble();
            double value = _Controller.Animation.Value;
            double offset = default(double);
            if (value == index - 1.0) offset = leadingPosition == default(double) ? middlePosition : leadingPosition; else if (value == index + 1.0) offset = trailingPosition == default(double) ? middlePosition : trailingPosition; else if (value == index) offset = middlePosition; else if (value < index) offset = leadingPosition == null ? middlePosition : Dart.UI.UiDefaultClass.LerpDouble(middlePosition, leadingPosition, index - value); else offset = trailingPosition == null ? middlePosition : Dart.UI.UiDefaultClass.LerpDouble(middlePosition, trailingPosition, value - index);
            _ScrollController.JumpTo(offset);
        }




        private void _HandleTabControllerAnimationTick()
        {

            if (!_Controller.IndexIsChanging && Widget.IsScrollable)
            {
                _CurrentIndex = _Controller.Index;
                _ScrollToControllerValue();
            }

        }




        private void _HandleTabControllerTick()
        {
            if (_Controller.Index != _CurrentIndex)
            {
                _CurrentIndex = _Controller.Index;
                if (Widget.IsScrollable) _ScrollToCurrentIndex();
            }

            SetState(() =>
            {
            }
            );
        }




        private void _SaveTabOffsets(List<double> tabOffsets, TextDirection textDirection, double width)
        {
            _TabStripWidth = width;
            _IndicatorPainter?.SaveTabOffsets(tabOffsets, textDirection);
        }




        private void _HandleTap(int index)
        {

            _Controller.AnimateTo(index);
            if (Widget.OnTap != null)
            {
                Widget.OnTap(index);
            }

        }




        private FlutterSDK.Widgets.Framework.Widget _BuildStyledTab(FlutterSDK.Widgets.Framework.Widget child, bool selected, FlutterSDK.Animation.Animation.Animation<double> animation)
        {
            return new _TabStyle(animation: animation, selected: selected, labelColor: Widget.LabelColor, unselectedLabelColor: Widget.UnselectedLabelColor, labelStyle: Widget.LabelStyle, unselectedLabelStyle: Widget.UnselectedLabelStyle, child: child);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {


            MaterialLocalizations localizations = MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context);
            if (_Controller.Length == 0)
            {
                return new Container(height: TabsDefaultClass._KTabHeight + Widget.IndicatorWeight);
            }

            TabBarTheme tabBarTheme = TabbarthemeDefaultClass.TabBarTheme.Of(context);
            List<Widget> wrappedTabs = new List<Widget>(Widget.Tabs.Count);
            for (int i = 0; i < Widget.Tabs.Count; i += 1)
            {
                wrappedTabs[i] = new Center(heightFactor: 1.0, child: new Padding(padding: Widget.LabelPadding ?? tabBarTheme.LabelPadding ?? ConstantsDefaultClass.KTabLabelPadding, child: new KeyedSubtree(key: _TabKeys[i], child: Widget.Tabs[i])));
            }

            if (_Controller != null)
            {
                int previousIndex = _Controller.PreviousIndex;
                if (_Controller.IndexIsChanging)
                {

                    Animation<double> animation = new _ChangeAnimation(_Controller);
                    wrappedTabs[_CurrentIndex] = _BuildStyledTab(wrappedTabs[_CurrentIndex], true, animation);
                    wrappedTabs[previousIndex] = _BuildStyledTab(wrappedTabs[previousIndex], false, animation);
                }
                else
                {
                    int tabIndex = _CurrentIndex;
                    Animation<double> centerAnimation = new _DragAnimation(_Controller, tabIndex);
                    wrappedTabs[tabIndex] = _BuildStyledTab(wrappedTabs[tabIndex], true, centerAnimation);
                    if (_CurrentIndex > 0)
                    {
                        int tabIndex = _CurrentIndex - 1;
                        Animation<double> previousAnimation = new ReverseAnimation(new _DragAnimation(_Controller, tabIndex));
                        wrappedTabs[tabIndex] = _BuildStyledTab(wrappedTabs[tabIndex], false, previousAnimation);
                    }

                    if (_CurrentIndex < Widget.Tabs.Count - 1)
                    {
                        int tabIndex = _CurrentIndex + 1;
                        Animation<double> nextAnimation = new ReverseAnimation(new _DragAnimation(_Controller, tabIndex));
                        wrappedTabs[tabIndex] = _BuildStyledTab(wrappedTabs[tabIndex], false, nextAnimation);
                    }

                }

            }

            int tabCount = Widget.Tabs.Count;
            for (int index = 0; index < tabCount; index += 1)
            {
                wrappedTabs[index] = new InkWell(onTap: () =>
                {
                    _HandleTap(index);
                }
                , child: new Padding(padding: EdgeInsets.Only(bottom: Widget.IndicatorWeight), child: new Stack(children: new List<Widget>() { wrappedTabs[index], new Semantics(selected: index == _CurrentIndex, label: localizations.TabLabel(tabIndex: index + 1, tabCount: tabCount)) })));
                if (!Widget.IsScrollable) wrappedTabs[index] = new Expanded(child: wrappedTabs[index]);
            }

            Widget tabBar = new CustomPaint(painter: _IndicatorPainter, child: new _TabStyle(animation: AnimationsDefaultClass.KAlwaysDismissedAnimation, selected: false, labelColor: Widget.LabelColor, unselectedLabelColor: Widget.UnselectedLabelColor, labelStyle: Widget.LabelStyle, unselectedLabelStyle: Widget.UnselectedLabelStyle, child: new _TabLabelBar(onPerformLayout: _SaveTabOffsets, children: wrappedTabs)));
            if (Widget.IsScrollable)
            {
                _ScrollController = (_ScrollController == null ? new _TabBarScrollController(this) : _ScrollController);
                tabBar = new SingleChildScrollView(dragStartBehavior: Widget.DragStartBehavior, scrollDirection: Axis.Horizontal, controller: _ScrollController, child: tabBar);
            }

            return tabBar;
        }



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
        /// <Summary>
        /// Creates a page view with one child per tab.
        ///
        /// The length of [children] must be the same as the [controller]'s length.
        /// </Summary>
        public TabBarView(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Material.Tabcontroller.TabController controller = default(FlutterSDK.Material.Tabcontroller.TabController), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.Children = children;
            this.Controller = controller;
            this.Physics = physics;
            this.DragStartBehavior = dragStartBehavior;
        }
        /// <Summary>
        /// This widget's selection and animation state.
        ///
        /// If [TabController] is not provided, then the value of [DefaultTabController.of]
        /// will be used.
        /// </Summary>
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        /// <Summary>
        /// One widget per tab.
        ///
        /// Its length must match the length of the [TabBar.tabs]
        /// list, as well as the [controller]'s [TabController.length].
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }
        /// <Summary>
        /// How the page view should respond to user input.
        ///
        /// For example, determines how the page view continues to animate after the
        /// user stops dragging the page view.
        ///
        /// The physics are modified to snap to page boundaries using
        /// [PageScrollPhysics] prior to being used.
        ///
        /// Defaults to matching platform conventions.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.scrollable.dragStartBehavior}
        /// </Summary>
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }

        public new FlutterSDK.Material.Tabs._TabBarViewState CreateState() => new _TabBarViewState();


    }


    public class _TabBarViewState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Tabs.TabBarView>
    {
        public _TabBarViewState()
        { }
        internal virtual FlutterSDK.Material.Tabcontroller.TabController _Controller { get; set; }
        internal virtual FlutterSDK.Widgets.Pageview.PageController _PageController { get; set; }
        internal virtual List<FlutterSDK.Widgets.Framework.Widget> _Children { get; set; }
        internal virtual List<FlutterSDK.Widgets.Framework.Widget> _ChildrenWithKey { get; set; }
        internal virtual int _CurrentIndex { get; set; }
        internal virtual int _WarpUnderwayCount { get; set; }
        internal virtual bool _ControllerIsValid { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _UpdateTabController()
        {
            TabController newController = Widget.Controller ?? TabcontrollerDefaultClass.DefaultTabController.Of(Context);

            if (newController == _Controller) return;
            if (_ControllerIsValid) _Controller.Animation.RemoveListener(_HandleTabControllerAnimationTick);
            _Controller = newController;
            if (_Controller != null) _Controller.Animation.AddListener(_HandleTabControllerAnimationTick);
        }




        public new void InitState()
        {
            base.InitState();
            _UpdateChildren();
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            _UpdateTabController();
            _CurrentIndex = _Controller?.Index;
            _PageController = new PageController(initialPage: _CurrentIndex ?? 0);
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Tabs.TabBarView oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Controller != oldWidget.Controller) _UpdateTabController();
            if (Widget.Children != oldWidget.Children && _WarpUnderwayCount == 0) _UpdateChildren();
        }




        public new void Dispose()
        {
            if (_ControllerIsValid) _Controller.Animation.RemoveListener(_HandleTabControllerAnimationTick);
            _Controller = null;
            base.Dispose();
        }




        private void _UpdateChildren()
        {
            _Children = Widget.Children;
            _ChildrenWithKey = BasicDefaultClass.KeyedSubtree.EnsureUniqueKeysForList(Widget.Children);
        }




        private void _HandleTabControllerAnimationTick()
        {
            if (_WarpUnderwayCount > 0 || !_Controller.IndexIsChanging) return;
            if (_Controller.Index != _CurrentIndex)
            {
                _CurrentIndex = _Controller.Index;
                _WarpToCurrentIndex();
            }

        }




        private async Future<object> _WarpToCurrentIndex()
        {
            if (!Mounted) return Future<void>.Value();
            if (_PageController.Page == _CurrentIndex.ToDouble()) return Future<void>.Value();
            int previousIndex = _Controller.PreviousIndex;
            if ((_CurrentIndex - previousIndex).Abs() == 1) return _PageController.AnimateToPage(_CurrentIndex, duration: ConstantsDefaultClass.KTabScrollDuration, curve: CurvesDefaultClass.Curves.Ease);

            int initialPage = _CurrentIndex > previousIndex ? _CurrentIndex - 1 : _CurrentIndex + 1;
            List<Widget> originalChildren = _ChildrenWithKey;
            SetState(() =>
            {
                _WarpUnderwayCount += 1;
                _ChildrenWithKey = List<Widget>.From(_ChildrenWithKey, growable: false);
                Widget temp = _ChildrenWithKey[initialPage];
                _ChildrenWithKey[initialPage] = _ChildrenWithKey[previousIndex];
                _ChildrenWithKey[previousIndex] = temp;
            }
            );
            _PageController.JumpToPage(initialPage);
            await _PageController.AnimateToPage(_CurrentIndex, duration: ConstantsDefaultClass.KTabScrollDuration, curve: CurvesDefaultClass.Curves.Ease);
            if (!Mounted) return Future<void>.Value();
            SetState(() =>
            {
                _WarpUnderwayCount -= 1;
                if (Widget.Children != _Children)
                {
                    _UpdateChildren();
                }
                else
                {
                    _ChildrenWithKey = originalChildren;
                }

            }
            );
        }




        private bool _HandleScrollNotification(FlutterSDK.Widgets.Scrollnotification.ScrollNotification notification)
        {
            if (_WarpUnderwayCount > 0) return false;
            if (notification.Depth != 0) return false;
            _WarpUnderwayCount += 1;
            if (notification is ScrollUpdateNotification && !_Controller.IndexIsChanging)
            {
                if ((_PageController.Page - _Controller.Index).Abs() > 1.0)
                {
                    _Controller.Index = _PageController.Page.Floor();
                    _CurrentIndex = _Controller.Index;
                }

                _Controller.Offset = (_PageController.Page - _Controller.Index).Clamp(-1.0, 1.0) as double;
            }
            else if (notification is ScrollEndNotification)
            {
                _Controller.Index = _PageController.Page.Round();
                _CurrentIndex = _Controller.Index;
            }

            _WarpUnderwayCount -= 1;
            return false;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            return new NotificationListener<ScrollNotification>(onNotification: _HandleScrollNotification, child: new PageView(dragStartBehavior: Widget.DragStartBehavior, controller: _PageController, physics: Widget.Physics == null ? TabsDefaultClass._KTabBarViewPhysics : TabsDefaultClass._KTabBarViewPhysics.ApplyTo(Widget.Physics), children: _ChildrenWithKey));
        }



    }


    /// <Summary>
    /// Displays a single circle with the specified border and background colors.
    ///
    /// Used by [TabPageSelector] to indicate the selected page.
    /// </Summary>
    public class TabPageSelectorIndicator : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates an indicator used by [TabPageSelector].
        ///
        /// The [backgroundColor], [borderColor], and [size] parameters must not be null.
        /// </Summary>
        public TabPageSelectorIndicator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color borderColor = default(FlutterBinding.UI.Color), double size = default(double))
        : base(key: key)
        {
            this.BackgroundColor = backgroundColor;
            this.BorderColor = borderColor;
            this.Size = size;
        }
        /// <Summary>
        /// The indicator circle's background color.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// The indicator circle's border color.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BorderColor { get; set; }
        /// <Summary>
        /// The indicator circle's diameter.
        /// </Summary>
        public virtual double Size { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Container(width: Size, height: Size, margin: EdgeInsets.All(4.0), decoration: new BoxDecoration(color: BackgroundColor, border: Border.All(color: BorderColor), shape: BoxShape.Circle));
        }



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
        /// <Summary>
        /// Creates a compact widget that indicates which tab has been selected.
        /// </Summary>
        public TabPageSelector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Tabcontroller.TabController controller = default(FlutterSDK.Material.Tabcontroller.TabController), double indicatorSize = 12.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Controller = controller;
            this.IndicatorSize = indicatorSize;
            this.Color = color;
            this.SelectedColor = selectedColor;
        }
        /// <Summary>
        /// This widget's selection and animation state.
        ///
        /// If [TabController] is not provided, then the value of
        /// [DefaultTabController.of] will be used.
        /// </Summary>
        public virtual FlutterSDK.Material.Tabcontroller.TabController Controller { get; set; }
        /// <Summary>
        /// The indicator circle's diameter (the default value is 12.0).
        /// </Summary>
        public virtual double IndicatorSize { get; set; }
        /// <Summary>
        /// The indicator circle's fill color for unselected pages.
        ///
        /// If this parameter is null, then the indicator is filled with [Colors.transparent].
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// The indicator circle's fill color for selected pages and border color
        /// for all indicator circles.
        ///
        /// If this parameter is null, then the indicator is filled with the theme's
        /// accent color, [ThemeData.accentColor].
        /// </Summary>
        public virtual FlutterBinding.UI.Color SelectedColor { get; set; }

        private FlutterSDK.Widgets.Framework.Widget _BuildTabIndicator(int tabIndex, FlutterSDK.Material.Tabcontroller.TabController tabController, FlutterSDK.Animation.Tween.ColorTween selectedColorTween, FlutterSDK.Animation.Tween.ColorTween previousColorTween)
        {
            Color background = default(Color);
            if (tabController.IndexIsChanging)
            {
                double t = 1.0 - TabsDefaultClass._IndexChangeProgress(tabController);
                if (tabController.Index == tabIndex) background = selectedColorTween.Lerp(t); else if (tabController.PreviousIndex == tabIndex) background = previousColorTween.Lerp(t); else background = selectedColorTween.Begin;
            }
            else
            {
                double offset = tabController.Offset;
                if (tabController.Index == tabIndex)
                {
                    background = selectedColorTween.Lerp(1.0 - offset.Abs());
                }
                else if (tabController.Index == tabIndex - 1 && offset > 0.0)
                {
                    background = selectedColorTween.Lerp(offset);
                }
                else if (tabController.Index == tabIndex + 1 && offset < 0.0)
                {
                    background = selectedColorTween.Lerp(-offset);
                }
                else
                {
                    background = selectedColorTween.Begin;
                }

            }

            return new TabPageSelectorIndicator(backgroundColor: background, borderColor: selectedColorTween.End, size: IndicatorSize);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Color fixColor = Color ?? ColorsDefaultClass.Colors.Transparent;
            Color fixSelectedColor = SelectedColor ?? ThemeDefaultClass.Theme.Of(context).AccentColor;
            ColorTween selectedColorTween = new ColorTween(begin: fixColor, end: fixSelectedColor);
            ColorTween previousColorTween = new ColorTween(begin: fixSelectedColor, end: fixColor);
            TabController tabController = Controller ?? TabcontrollerDefaultClass.DefaultTabController.Of(context);

            Animation<double> animation = new CurvedAnimation(parent: tabController.Animation, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
            return new AnimatedBuilder(animation: animation, builder: (BuildContext context, Widget child) =>
            {
                return new Semantics(label: $"'Page {tabController.Index + 1} of {tabController.Length}'", child: new Row(mainAxisSize: MainAxisSize.Min, children: List<Widget>.Generate(tabController.Length, (int tabIndex) =>
                {
                    return _BuildTabIndicator(tabIndex, tabController, selectedColorTween, previousColorTween);
                }
                ).ToList()));
            }
            );
        }



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
