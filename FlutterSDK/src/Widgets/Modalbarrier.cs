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
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Widgets.Constants;
namespace FlutterSDK.Widgets.Modalbarrier
{
    internal static class ModalbarrierDefaultClass
    {
    }

    /// <Summary>
    /// A widget that prevents the user from interacting with widgets behind itself.
    ///
    /// The modal barrier is the scrim that is rendered behind each route, which
    /// generally prevents the user from interacting with the route below the
    /// current route, and normally partially obscures such routes.
    ///
    /// For example, when a dialog is on the screen, the page below the dialog is
    /// usually darkened by the modal barrier.
    ///
    /// See also:
    ///
    ///  * [ModalRoute], which indirectly uses this widget.
    ///  * [AnimatedModalBarrier], which is similar but takes an animated [color]
    ///    instead of a single color value.
    /// </Summary>
    public class ModalBarrier : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a widget that blocks user interaction.
        /// </Summary>
        public ModalBarrier(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), bool dismissible = true, string semanticsLabel = default(string), bool barrierSemanticsDismissible = true)
        : base(key: key)
        {
            this.Color = color;
            this.Dismissible = dismissible;
            this.SemanticsLabel = semanticsLabel;
            this.BarrierSemanticsDismissible = barrierSemanticsDismissible;
        }
        /// <Summary>
        /// If non-null, fill the barrier with this color.
        ///
        /// See also:
        ///
        ///  * [ModalRoute.barrierColor], which controls this property for the
        ///    [ModalBarrier] built by [ModalRoute] pages.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// Whether touching the barrier will pop the current route off the [Navigator].
        ///
        /// See also:
        ///
        ///  * [ModalRoute.barrierDismissible], which controls this property for the
        ///    [ModalBarrier] built by [ModalRoute] pages.
        /// </Summary>
        public virtual bool Dismissible { get; set; }
        /// <Summary>
        /// Whether the modal barrier semantics are included in the semantics tree.
        ///
        /// See also:
        ///
        ///  * [ModalRoute.semanticsDismissible], which controls this property for
        ///    the [ModalBarrier] built by [ModalRoute] pages.
        /// </Summary>
        public virtual bool BarrierSemanticsDismissible { get; set; }
        /// <Summary>
        /// Semantics label used for the barrier if it is [dismissible].
        ///
        /// The semantics label is read out by accessibility tools (e.g. TalkBack
        /// on Android and VoiceOver on iOS) when the barrier is focused.
        ///
        /// See also:
        ///
        ///  * [ModalRoute.barrierLabel], which controls this property for the
        ///    [ModalBarrier] built by [ModalRoute] pages.
        /// </Summary>
        public virtual string SemanticsLabel { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            bool platformSupportsDismissingBarrier = default(bool);
            switch (PlatformDefaultClass.DefaultTargetPlatform) { case TargetPlatform.Android: case TargetPlatform.Fuchsia: case TargetPlatform.Linux: case TargetPlatform.Windows: platformSupportsDismissingBarrier = false; break; case TargetPlatform.IOS: case TargetPlatform.MacOS: platformSupportsDismissingBarrier = true; break; }

            bool semanticsDismissible = Dismissible && platformSupportsDismissingBarrier;
            bool modalBarrierSemanticsDismissible = BarrierSemanticsDismissible ?? semanticsDismissible;
            return new BlockSemantics(child: new ExcludeSemantics(excluding: !semanticsDismissible || !modalBarrierSemanticsDismissible, child: new _ModalBarrierGestureDetector(onDismiss: () =>
            {
                if (Dismissible) NavigatorDefaultClass.Navigator.MaybePop(context);
            }
            , child: new Semantics(label: semanticsDismissible ? SemanticsLabel : null, textDirection: semanticsDismissible && SemanticsLabel != null ? BasicDefaultClass.Directionality.Of(context) : null, child: new MouseRegion(opaque: true, child: new ConstrainedBox(constraints: BoxConstraints.Expand(), child: Color == null ? null : new DecoratedBox(decoration: new BoxDecoration(color: Color))))))));
        }



    }


    /// <Summary>
    /// A widget that prevents the user from interacting with widgets behind itself,
    /// and can be configured with an animated color value.
    ///
    /// The modal barrier is the scrim that is rendered behind each route, which
    /// generally prevents the user from interacting with the route below the
    /// current route, and normally partially obscures such routes.
    ///
    /// For example, when a dialog is on the screen, the page below the dialog is
    /// usually darkened by the modal barrier.
    ///
    /// This widget is similar to [ModalBarrier] except that it takes an animated
    /// [color] instead of a single color.
    ///
    /// See also:
    ///
    ///  * [ModalRoute], which uses this widget.
    /// </Summary>
    public class AnimatedModalBarrier : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        /// <Summary>
        /// Creates a widget that blocks user interaction.
        /// </Summary>
        public AnimatedModalBarrier(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<Color> color = default(FlutterSDK.Animation.Animation.Animation<Color>), bool dismissible = true, string semanticsLabel = default(string), bool barrierSemanticsDismissible = default(bool))
        : base(key: key, listenable: color)
        {
            this.Dismissible = dismissible;
            this.SemanticsLabel = semanticsLabel;
            this.BarrierSemanticsDismissible = barrierSemanticsDismissible;
        }
        /// <Summary>
        /// Whether touching the barrier will pop the current route off the [Navigator].
        ///
        /// See also:
        ///
        ///  * [ModalRoute.barrierDismissible], which controls this property for the
        ///    [AnimatedModalBarrier] built by [ModalRoute] pages.
        /// </Summary>
        public virtual bool Dismissible { get; set; }
        /// <Summary>
        /// Semantics label used for the barrier if it is [dismissible].
        ///
        /// The semantics label is read out by accessibility tools (e.g. TalkBack
        /// on Android and VoiceOver on iOS) when the barrier is focused.
        /// See also:
        ///
        ///  * [ModalRoute.barrierLabel], which controls this property for the
        ///    [ModalBarrier] built by [ModalRoute] pages.
        /// </Summary>
        public virtual string SemanticsLabel { get; set; }
        /// <Summary>
        /// Whether the modal barrier semantics are included in the semantics tree.
        ///
        /// See also:
        ///
        ///  * [ModalRoute.semanticsDismissible], which controls this property for
        ///    the [ModalBarrier] built by [ModalRoute] pages.
        /// </Summary>
        public virtual bool BarrierSemanticsDismissible { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<Color> Color { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new ModalBarrier(color: Color?.Value, dismissible: Dismissible, semanticsLabel: SemanticsLabel, barrierSemanticsDismissible: BarrierSemanticsDismissible);
        }



    }


    public class _AnyTapGestureRecognizer : FlutterSDK.Gestures.Tap.BaseTapGestureRecognizer
    {
        public _AnyTapGestureRecognizer(@Object debugOwner = default(@Object))
        : base(debugOwner: debugOwner)
        {

        }
        public virtual VoidCallback OnAnyTapUp { get; set; }
        public virtual string DebugDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new bool IsPointerAllowed(FlutterSDK.Gestures.Events.PointerDownEvent @event)
        {
            if (OnAnyTapUp == null) return false;
            return base.IsPointerAllowed(@event);
        }




        public new void HandleTapDown(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent))
        {
        }




        public new void HandleTapUp(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent), FlutterSDK.Gestures.Events.PointerUpEvent up = default(FlutterSDK.Gestures.Events.PointerUpEvent))
        {
            if (OnAnyTapUp != null) OnAnyTapUp();
        }




        public new void HandleTapCancel(FlutterSDK.Gestures.Events.PointerDownEvent down = default(FlutterSDK.Gestures.Events.PointerDownEvent), FlutterSDK.Gestures.Events.PointerCancelEvent cancel = default(FlutterSDK.Gestures.Events.PointerCancelEvent), string reason = default(string))
        {
        }



    }


    public class _ModalBarrierSemanticsDelegate : FlutterSDK.Widgets.Gesturedetector.SemanticsGestureDelegate
    {
        public _ModalBarrierSemanticsDelegate(VoidCallback onDismiss = default(VoidCallback))
        {
            this.OnDismiss = onDismiss;
        }
        public virtual VoidCallback OnDismiss { get; set; }

        public new void AssignSemantics(FlutterSDK.Rendering.Proxybox.RenderSemanticsGestureHandler renderObject)
        {
            renderObject.OnTap = OnDismiss;
        }



    }


    public class _AnyTapGestureRecognizerFactory : FlutterSDK.Widgets.Gesturedetector.GestureRecognizerFactory<FlutterSDK.Widgets.Modalbarrier._AnyTapGestureRecognizer>
    {
        public _AnyTapGestureRecognizerFactory(VoidCallback onAnyTapUp = default(VoidCallback))
        {
            this.OnAnyTapUp = onAnyTapUp;
        }
        public virtual VoidCallback OnAnyTapUp { get; set; }

        public new FlutterSDK.Widgets.Modalbarrier._AnyTapGestureRecognizer Constructor() => new _AnyTapGestureRecognizer();



        public new void Initializer(FlutterSDK.Widgets.Modalbarrier._AnyTapGestureRecognizer instance)
        {
            instance.OnAnyTapUp = OnAnyTapUp;
        }



    }


    public class _ModalBarrierGestureDetector : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _ModalBarrierGestureDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), VoidCallback onDismiss = default(VoidCallback))
        : base(key: key)
        {
            this.Child = child;
            this.OnDismiss = onDismiss;
        }
        /// <Summary>
        /// The widget below this widget in the tree.
        /// See [RawGestureDetector.child].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// Immediately called when an event that should dismiss the modal barrier
        /// has happened.
        /// </Summary>
        public virtual VoidCallback OnDismiss { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Dictionary<Type, GestureRecognizerFactory> gestures = new Dictionary<Type, GestureRecognizerFactory> { { ModalbarrierDefaultClass._AnyTapGestureRecognizer, new _AnyTapGestureRecognizerFactory(onAnyTapUp: OnDismiss) } };
            return new RawGestureDetector(gestures: gestures, behavior: HitTestBehavior.Opaque, semantics: new _ModalBarrierSemanticsDelegate(onDismiss: OnDismiss), child: Child);
        }



    }

}
