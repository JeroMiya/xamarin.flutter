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
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
namespace FlutterSDK.Widgets.Basic
{
    public delegate FlutterSDK.Widgets.Framework.Widget StatefulWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.StateSetter setState);
    internal static class BasicDefaultClass
    {
        internal static FlutterSDK.Painting.Basictypes.AxisDirection GetAxisDirectionFromAxisReverseAndDirectionality(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Painting.Basictypes.Axis axis, bool reverse)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// A widget that determines the ambient directionality of text and
    /// text-direction-sensitive render objects.
    ///
    /// For example, [Padding] depends on the [Directionality] to resolve
    /// [EdgeInsetsDirectional] objects into absolute [EdgeInsets] objects.
    /// </Summary>
    public class Directionality : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public Directionality(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), TextDirection textDirection = default(TextDirection), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.TextDirection = textDirection; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual TextDirection TextDirection { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// The text direction from the closest instance of this class that encloses
        /// the given context.
        ///
        /// If there is no [Directionality] ancestor widget in the tree at the given
        /// context, then this will return null.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// TextDirection textDirection = Directionality.of(context);
        /// ```
        /// </Summary>
        public virtual TextDirection Of(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Basic.Directionality oldWidget) { throw new NotImplementedException(); }
        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that makes its child partially transparent.
    ///
    /// This class paints its child into an intermediate buffer and then blends the
    /// child back into the scene partially transparent.
    ///
    /// For values of opacity other than 0.0 and 1.0, this class is relatively
    /// expensive because it requires painting the child into an intermediate
    /// buffer. For the value 0.0, the child is simply not painted at all. For the
    /// value 1.0, the child is painted immediately without an intermediate buffer.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=9hltevOHQBw}
    ///
    /// {@tool snippet}
    ///
    /// This example shows some [Text] when the `_visible` member field is true, and
    /// hides it when it is false:
    ///
    /// ```dart
    /// Opacity(
    ///   opacity: _visible ? 1.0 : 0.0,
    ///   child: const Text("Now you see me, now you don't!"),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// This is more efficient than adding and removing the child widget from the
    /// tree on demand.
    ///
    /// ## Performance considerations for opacity animation
    ///
    /// Animating an [Opacity] widget directly causes the widget (and possibly its
    /// subtree) to rebuild each frame, which is not very efficient. Consider using
    /// an [AnimatedOpacity] instead.
    ///
    /// ## Transparent image
    ///
    /// If only a single [Image] or [Color] needs to be composited with an opacity
    /// between 0.0 and 1.0, it's much faster to directly use them without [Opacity]
    /// widgets.
    ///
    /// For example, `Container(color: Color.fromRGBO(255, 0, 0, 0.5))` is much
    /// faster than `Opacity(opacity: 0.5, child: Container(color: Colors.red))`.
    ///
    /// {@tool snippet}
    ///
    /// The following example draws an [Image] with 0.5 opacity without using
    /// [Opacity]:
    ///
    /// ```dart
    /// Image.network(
    ///   'https://raw.githubusercontent.com/flutter/assets-for-api-docs/master/packages/diagrams/assets/blend_mode_destination.jpeg',
    ///   color: Color.fromRGBO(255, 255, 255, 0.5),
    ///   colorBlendMode: BlendMode.modulate
    /// )
    /// ```
    ///
    /// {@end-tool}
    ///
    /// Directly drawing an [Image] or [Color] with opacity is faster than using
    /// [Opacity] on top of them because [Opacity] could apply the opacity to a
    /// group of widgets and therefore a costly offscreen buffer will be used.
    /// Drawing content into the offscreen buffer may also trigger render target
    /// switches and such switching is particularly slow in older GPUs.
    ///
    /// See also:
    ///
    ///  * [Visibility], which can hide a child more efficiently (albeit less
    ///    subtly, because it is either visible or hidden, rather than allowing
    ///    fractional opacity values).
    ///  * [ShaderMask], which can apply more elaborate effects to its child.
    ///  * [Transform], which applies an arbitrary transform to its child widget at
    ///    paint time.
    ///  * [AnimatedOpacity], which uses an animation internally to efficiently
    ///    animate opacity.
    ///  * [FadeTransition], which uses a provided animation to efficiently animate
    ///    opacity.
    ///  * [Image], which can directly provide a partially transparent image with
    ///    much less performance hit.
    /// </Summary>
    public class Opacity : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Opacity(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double opacity = default(double), bool alwaysIncludeSemantics = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.OpacityValue = opacity;
            this.AlwaysIncludeSemantics = alwaysIncludeSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double OpacityValue { get; set; }
        public virtual bool AlwaysIncludeSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderOpacity CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderOpacity renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that applies a mask generated by a [Shader] to its child.
    ///
    /// For example, [ShaderMask] can be used to gradually fade out the edge
    /// of a child by using a [new ui.Gradient.linear] mask.
    ///
    /// {@tool snippet}
    ///
    /// This example makes the text look like it is on fire:
    ///
    /// ```dart
    /// ShaderMask(
    ///   shaderCallback: (Rect bounds) {
    ///     return RadialGradient(
    ///       center: Alignment.topLeft,
    ///       radius: 1.0,
    ///       colors: <Color>[Colors.yellow, Colors.deepOrange.shade900],
    ///       tileMode: TileMode.mirror,
    ///     ).createShader(bounds);
    ///   },
    ///   child: const Text('I’m burning the memories'),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Opacity], which can apply a uniform alpha effect to its child.
    ///  * [CustomPaint], which lets you draw directly on the canvas.
    ///  * [DecoratedBox], for another approach at decorating child widgets.
    ///  * [BackdropFilter], which applies an image filter to the background.
    /// </Summary>
    public class ShaderMask : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ShaderMask(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.ShaderCallback shaderCallback = default(FlutterSDK.Rendering.Proxybox.ShaderCallback), FlutterBinding.UI.BlendMode blendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.ShaderCallback = shaderCallback;
            this.BlendMode = blendMode; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.ShaderCallback ShaderCallback { get; set; }
        public virtual FlutterBinding.UI.BlendMode BlendMode { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderShaderMask CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderShaderMask renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that applies a filter to the existing painted content and then
    /// paints [child].
    ///
    /// The filter will be applied to all the area within its parent or ancestor
    /// widget's clip. If there's no clip, the filter will be applied to the full
    /// screen.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=dYRs7Q1vfYI}
    ///
    /// {@tool snippet}
    /// If the [BackdropFilter] needs to be applied to an area that exactly matches
    /// its child, wraps the [BackdropFilter] with a clip widget that clips exactly
    /// to that child.
    ///
    /// ```dart
    /// Stack(
    ///   fit: StackFit.expand,
    ///   children: <Widget>[
    ///     Text('0' * 10000),
    ///     Center(
    ///       child: ClipRect(  // <-- clips to the 200x200 [Container] below
    ///         child: BackdropFilter(
    ///           filter: ui.ImageFilter.blur(
    ///             sigmaX: 5.0,
    ///             sigmaY: 5.0,
    ///           ),
    ///           child: Container(
    ///             alignment: Alignment.center,
    ///             width: 200.0,
    ///             height: 200.0,
    ///             child: Text('Hello World'),
    ///           ),
    ///         ),
    ///       ),
    ///     ),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// This effect is relatively expensive, especially if the filter is non-local,
    /// such as a blur.
    ///
    /// See also:
    ///
    ///  * [DecoratedBox], which draws a background under (or over) a widget.
    ///  * [Opacity], which changes the opacity of the widget itself.
    /// </Summary>
    public class BackdropFilter : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public BackdropFilter(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), ImageFilter filter = default(ImageFilter), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Filter = filter; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual ImageFilter Filter { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderBackdropFilter CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderBackdropFilter renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that provides a canvas on which to draw during the paint phase.
    ///
    /// When asked to paint, [CustomPaint] first asks its [painter] to paint on the
    /// current canvas, then it paints its child, and then, after painting its
    /// child, it asks its [foregroundPainter] to paint. The coordinate system of the
    /// canvas matches the coordinate system of the [CustomPaint] object. The
    /// painters are expected to paint within a rectangle starting at the origin and
    /// encompassing a region of the given size. (If the painters paint outside
    /// those bounds, there might be insufficient memory allocated to rasterize the
    /// painting commands and the resulting behavior is undefined.) To enforce
    /// painting within those bounds, consider wrapping this [CustomPaint] with a
    /// [ClipRect] widget.
    ///
    /// Painters are implemented by subclassing [CustomPainter].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=kp14Y4uHpHs}
    ///
    /// Because custom paint calls its painters during paint, you cannot call
    /// `setState` or `markNeedsLayout` during the callback (the layout for this
    /// frame has already happened).
    ///
    /// Custom painters normally size themselves to their child. If they do not have
    /// a child, they attempt to size themselves to the [size], which defaults to
    /// [Size.zero]. [size] must not be null.
    ///
    /// [isComplex] and [willChange] are hints to the compositor's raster cache
    /// and must not be null.
    ///
    /// {@tool snippet}
    ///
    /// This example shows how the sample custom painter shown at [CustomPainter]
    /// could be used in a [CustomPaint] widget to display a background to some
    /// text.
    ///
    /// ```dart
    /// CustomPaint(
    ///   painter: Sky(),
    ///   child: Center(
    ///     child: Text(
    ///       'Once upon a time...',
    ///       style: const TextStyle(
    ///         fontSize: 40.0,
    ///         fontWeight: FontWeight.w900,
    ///         color: Color(0xFFFFFFFF),
    ///       ),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [CustomPainter], the class to extend when creating custom painters.
    ///  * [Canvas], the class that a custom painter uses to paint.
    /// </Summary>
    public class CustomPaint : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public CustomPaint(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Custompaint.CustomPainter painter = default(FlutterSDK.Rendering.Custompaint.CustomPainter), FlutterSDK.Rendering.Custompaint.CustomPainter foregroundPainter = default(FlutterSDK.Rendering.Custompaint.CustomPainter), Size size = default(Size), bool isComplex = false, bool willChange = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Painter = painter;
            this.ForegroundPainter = foregroundPainter;
            this.Size = size;
            this.IsComplex = isComplex;
            this.WillChange = willChange; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Custompaint.CustomPainter Painter { get; set; }
        public virtual FlutterSDK.Rendering.Custompaint.CustomPainter ForegroundPainter { get; set; }
        public virtual Size Size { get; set; }
        public virtual bool IsComplex { get; set; }
        public virtual bool WillChange { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Custompaint.RenderCustomPaint CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Custompaint.RenderCustomPaint renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DidUnmountRenderObject(FlutterSDK.Rendering.Custompaint.RenderCustomPaint renderObject) { throw new NotImplementedException(); }
        public new void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that clips its child using a rectangle.
    ///
    /// By default, [ClipRect] prevents its child from painting outside its
    /// bounds, but the size and location of the clip rect can be customized using a
    /// custom [clipper].
    ///
    /// [ClipRect] is commonly used with these widgets, which commonly paint outside
    /// their bounds:
    ///
    ///  * [CustomPaint]
    ///  * [CustomSingleChildLayout]
    ///  * [CustomMultiChildLayout]
    ///  * [Align] and [Center] (e.g., if [Align.widthFactor] or
    ///    [Align.heightFactor] is less than 1.0).
    ///  * [OverflowBox]
    ///  * [SizedOverflowBox]
    ///
    /// {@tool snippet}
    ///
    /// For example, by combining a [ClipRect] with an [Align], one can show just
    /// the top half of an [Image]:
    ///
    /// ```dart
    /// ClipRect(
    ///   child: Align(
    ///     alignment: Alignment.topCenter,
    ///     heightFactor: 0.5,
    ///     child: Image.network(userAvatarUrl),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [CustomClipper], for information about creating custom clips.
    ///  * [ClipRRect], for a clip with rounded corners.
    ///  * [ClipOval], for an elliptical clip.
    ///  * [ClipPath], for an arbitrarily shaped clip.
    /// </Summary>
    public class ClipRect : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ClipRect(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Rect>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Clipper = clipper;
            this.ClipBehavior = clipBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> Clipper { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderClipRect CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderClipRect renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DidUnmountRenderObject(FlutterSDK.Rendering.Proxybox.RenderClipRect renderObject) { throw new NotImplementedException(); }
        public new void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that clips its child using a rounded rectangle.
    ///
    /// By default, [ClipRRect] uses its own bounds as the base rectangle for the
    /// clip, but the size and location of the clip can be customized using a custom
    /// [clipper].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=eI43jkQkrvs}
    ///
    /// See also:
    ///
    ///  * [CustomClipper], for information about creating custom clips.
    ///  * [ClipRect], for more efficient clips without rounded corners.
    ///  * [ClipOval], for an elliptical clip.
    ///  * [ClipPath], for an arbitrarily shaped clip.
    /// </Summary>
    public class ClipRRect : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ClipRRect(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Rendering.Proxybox.CustomClipper<RRect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<RRect>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.BorderRadius = borderRadius;
            this.Clipper = clipper;
            this.ClipBehavior = clipBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<RRect> Clipper { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderClipRRect CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderClipRRect renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that clips its child using an oval.
    ///
    /// By default, inscribes an axis-aligned oval into its layout dimensions and
    /// prevents its child from painting outside that oval, but the size and
    /// location of the clip oval can be customized using a custom [clipper].
    ///
    /// See also:
    ///
    ///  * [CustomClipper], for information about creating custom clips.
    ///  * [ClipRect], for more efficient clips without rounded corners.
    ///  * [ClipRRect], for a clip with rounded corners.
    ///  * [ClipPath], for an arbitrarily shaped clip.
    /// </Summary>
    public class ClipOval : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ClipOval(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Rect>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Clipper = clipper;
            this.ClipBehavior = clipBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> Clipper { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderClipOval CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderClipOval renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DidUnmountRenderObject(FlutterSDK.Rendering.Proxybox.RenderClipOval renderObject) { throw new NotImplementedException(); }
        public new void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that clips its child using a path.
    ///
    /// Calls a callback on a delegate whenever the widget is to be
    /// painted. The callback returns a path and the widget prevents the
    /// child from painting outside the path.
    ///
    /// Clipping to a path is expensive. Certain shapes have more
    /// optimized widgets:
    ///
    ///  * To clip to a rectangle, consider [ClipRect].
    ///  * To clip to an oval or circle, consider [ClipOval].
    ///  * To clip to a rounded rectangle, consider [ClipRRect].
    ///
    /// To clip to a particular [ShapeBorder], consider using either the
    /// [ClipPath.shape] static method or the [ShapeBorderClipper] custom clipper
    /// class.
    /// </Summary>
    public class ClipPath : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ClipPath(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.CustomClipper<Path> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Path>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Clipper = clipper;
            this.ClipBehavior = clipBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<Path> Clipper { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Creates a shape clip.
        ///
        /// Uses a [ShapeBorderClipper] to configure the [ClipPath] to clip to the
        /// given [ShapeBorder].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Shape(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget)) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Proxybox.RenderClipPath CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderClipPath renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DidUnmountRenderObject(FlutterSDK.Rendering.Proxybox.RenderClipPath renderObject) { throw new NotImplementedException(); }
        public new void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget representing a physical layer that clips its children to a shape.
    ///
    /// Physical layers cast shadows based on an [elevation] which is nominally in
    /// logical pixels, coming vertically out of the rendering surface.
    ///
    /// For shapes that cannot be expressed as a rectangle with rounded corners use
    /// [PhysicalShape].
    ///
    /// See also:
    ///
    ///  * [AnimatedPhysicalModel], which animates property changes smoothly over
    ///    a given duration.
    ///  * [DecoratedBox], which can apply more arbitrary shadow effects.
    ///  * [ClipRect], which applies a clip to its child.
    /// </Summary>
    public class PhysicalModel : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public PhysicalModel(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), double elevation = 0.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.BorderRadius = borderRadius;
            this.Elevation = elevation;
            this.Color = color;
            this.ShadowColor = shadowColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Boxborder.BoxShape Shape { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        public virtual double Elevation { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterBinding.UI.Color ShadowColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderPhysicalModel CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderPhysicalModel renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget representing a physical layer that clips its children to a path.
    ///
    /// Physical layers cast shadows based on an [elevation] which is nominally in
    /// logical pixels, coming vertically out of the rendering surface.
    ///
    /// [PhysicalModel] does the same but only supports shapes that can be expressed
    /// as rectangles with rounded corners.
    ///
    /// See also:
    ///
    ///  * [ShapeBorderClipper], which converts a [ShapeBorder] to a [CustomerClipper], as
    ///    needed by this widget.
    /// </Summary>
    public class PhysicalShape : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public PhysicalShape(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.CustomClipper<Path> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Path>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), double elevation = 0.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Clipper = clipper;
            this.ClipBehavior = clipBehavior;
            this.Elevation = elevation;
            this.Color = color;
            this.ShadowColor = shadowColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<Path> Clipper { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public virtual double Elevation { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterBinding.UI.Color ShadowColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderPhysicalShape CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderPhysicalShape renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that applies a transformation before painting its child.
    ///
    /// Unlike [RotatedBox], which applies a rotation prior to layout, this object
    /// applies its transformation just prior to painting, which means the
    /// transformation is not taken into account when calculating how much space
    /// this widget's child (and thus this widget) consumes.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=9z_YNlRlWfA}
    ///
    /// {@tool snippet}
    ///
    /// This example rotates and skews an orange box containing text, keeping the
    /// top right corner pinned to its original position.
    ///
    /// ```dart
    /// Container(
    ///   color: Colors.black,
    ///   child: Transform(
    ///     alignment: Alignment.topRight,
    ///     transform: Matrix4.skewY(0.3)..rotateZ(-math.pi / 12.0),
    ///     child: Container(
    ///       padding: const EdgeInsets.all(8.0),
    ///       color: const Color(0xFFE8581C),
    ///       child: const Text('Apartment for rent!'),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [RotatedBox], which rotates the child widget during layout, not just
    ///    during painting.
    ///  * [FractionalTranslation], which applies a translation to the child
    ///    that is relative to the child's size.
    ///  * [FittedBox], which sizes and positions its child widget to fit the parent
    ///    according to a given [BoxFit] discipline.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Transform : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Transform(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Matrix4 transform = default(Matrix4), FlutterBinding.UI.Offset origin = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), bool transformHitTests = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.TransformValue = transform;
            this.Origin = origin;
            this.Alignment = alignment;
            this.TransformHitTests = transformHitTests; throw new NotImplementedException();
        }
        public static Transform Rotate(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double angle = default(double), FlutterBinding.UI.Offset origin = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), bool transformHitTests = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Transform(key: key, child: child); instance.Origin = origin;
            instance.Alignment = alignment;
            instance.TransformHitTests = transformHitTests; throw new NotImplementedException();
        }
        public static Transform Translate(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), bool transformHitTests = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Transform(key: key, child: child); instance.TransformHitTests = transformHitTests; throw new NotImplementedException();
        }
        public static Transform Scale(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double scale = default(double), FlutterBinding.UI.Offset origin = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), bool transformHitTests = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Transform(key: key, child: child); instance.Origin = origin;
            instance.Alignment = alignment;
            instance.TransformHitTests = transformHitTests; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Matrix4 TransformValue { get; set; }
        public virtual FlutterBinding.UI.Offset Origin { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual bool TransformHitTests { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderTransform CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderTransform renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that can be targeted by a [CompositedTransformFollower].
    ///
    /// When this widget is composited during the compositing phase (which comes
    /// after the paint phase, as described in [WidgetsBinding.drawFrame]), it
    /// updates the [link] object so that any [CompositedTransformFollower] widgets
    /// that are subsequently composited in the same frame and were given the same
    /// [LayerLink] can position themselves at the same screen location.
    ///
    /// A single [CompositedTransformTarget] can be followed by multiple
    /// [CompositedTransformFollower] widgets.
    ///
    /// The [CompositedTransformTarget] must come earlier in the paint order than
    /// any linked [CompositedTransformFollower]s.
    ///
    /// See also:
    ///
    ///  * [CompositedTransformFollower], the widget that can target this one.
    ///  * [LeaderLayer], the layer that implements this widget's logic.
    /// </Summary>
    public class CompositedTransformTarget : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public CompositedTransformTarget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Link = link; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Layer.LayerLink Link { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderLeaderLayer CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderLeaderLayer renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that follows a [CompositedTransformTarget].
    ///
    /// When this widget is composited during the compositing phase (which comes
    /// after the paint phase, as described in [WidgetsBinding.drawFrame]), it
    /// applies a transformation that causes it to provide its child with a
    /// coordinate space that matches that of the linked [CompositedTransformTarget]
    /// widget, offset by [offset].
    ///
    /// The [LayerLink] object used as the [link] must be the same object as that
    /// provided to the matching [CompositedTransformTarget].
    ///
    /// The [CompositedTransformTarget] must come earlier in the paint order than
    /// this [CompositedTransformFollower].
    ///
    /// Hit testing on descendants of this widget will only work if the target
    /// position is within the box that this widget's parent considers to be
    /// hittable. If the parent covers the screen, this is trivially achievable, so
    /// this widget is usually used as the root of an [OverlayEntry] in an app-wide
    /// [Overlay] (e.g. as created by the [MaterialApp] widget's [Navigator]).
    ///
    /// See also:
    ///
    ///  * [CompositedTransformTarget], the widget that this widget can target.
    ///  * [FollowerLayer], the layer that implements this widget's logic.
    ///  * [Transform], which applies an arbitrary transform to a child.
    /// </Summary>
    public class CompositedTransformFollower : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public CompositedTransformFollower(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink), bool showWhenUnlinked = true, FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Link = link;
            this.ShowWhenUnlinked = showWhenUnlinked;
            this.Offset = offset; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Layer.LayerLink Link { get; set; }
        public virtual bool ShowWhenUnlinked { get; set; }
        public virtual FlutterBinding.UI.Offset Offset { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderFollowerLayer CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderFollowerLayer renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Scales and positions its child within itself according to [fit].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=T4Uehk3_wlY}
    ///
    /// See also:
    ///
    ///  * [Transform], which applies an arbitrary transform to its child widget at
    ///    paint time.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class FittedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public FittedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Fit = fit;
            this.Alignment = alignment; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Boxfit.BoxFit Fit { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderFittedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderFittedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Applies a translation transformation before painting its child.
    ///
    /// The translation is expressed as a [Offset] scaled to the child's size. For
    /// example, an [Offset] with a `dx` of 0.25 will result in a horizontal
    /// translation of one quarter the width of the child.
    ///
    /// Hit tests will only be detected inside the bounds of the
    /// [FractionalTranslation], even if the contents are offset such that
    /// they overflow.
    ///
    /// See also:
    ///
    ///  * [Transform], which applies an arbitrary transform to its child widget at
    ///    paint time.
    ///  * [new Transform.translate], which applies an absolute offset translation
    ///    transformation instead of an offset scaled to the child.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class FractionalTranslation : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public FractionalTranslation(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Offset translation = default(FlutterBinding.UI.Offset), bool transformHitTests = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Translation = translation;
            this.TransformHitTests = transformHitTests; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Offset Translation { get; set; }
        public virtual bool TransformHitTests { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderFractionalTranslation CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderFractionalTranslation renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that rotates its child by a integral number of quarter turns.
    ///
    /// Unlike [Transform], which applies a transform just prior to painting,
    /// this object applies its rotation prior to layout, which means the entire
    /// rotated box consumes only as much space as required by the rotated child.
    ///
    /// {@tool snippet}
    ///
    /// This snippet rotates the child (some [Text]) so that it renders from bottom
    /// to top, like an axis label on a graph:
    ///
    /// ```dart
    /// RotatedBox(
    ///   quarterTurns: 3,
    ///   child: const Text('Hello World!'),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Transform], which is a paint effect that allows you to apply an
    ///    arbitrary transform to a child.
    ///  * [new Transform.rotate], which applies a rotation paint effect.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class RotatedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public RotatedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int quarterTurns = default(int), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.QuarterTurns = quarterTurns; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int QuarterTurns { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Rotatedbox.RenderRotatedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Rotatedbox.RenderRotatedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that insets its child by the given padding.
    ///
    /// When passing layout constraints to its child, padding shrinks the
    /// constraints by the given padding, causing the child to layout at a smaller
    /// size. Padding then sizes itself to its child's size, inflated by the
    /// padding, effectively creating empty space around the child.
    ///
    /// {@tool snippet}
    ///
    /// This snippet creates "Hello World!" [Text] inside a [Card] that is indented
    /// by sixteen pixels in each direction.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/widgets/padding.png)
    ///
    /// ```dart
    /// const Card(
    ///   child: Padding(
    ///     padding: EdgeInsets.all(16.0),
    ///     child: Text('Hello World!'),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ## Design discussion
    ///
    /// ### Why use a [Padding] widget rather than a [Container] with a [Container.padding] property?
    ///
    /// There isn't really any difference between the two. If you supply a
    /// [Container.padding] argument, [Container] simply builds a [Padding] widget
    /// for you.
    ///
    /// [Container] doesn't implement its properties directly. Instead, [Container]
    /// combines a number of simpler widgets together into a convenient package. For
    /// example, the [Container.padding] property causes the container to build a
    /// [Padding] widget and the [Container.decoration] property causes the
    /// container to build a [DecoratedBox] widget. If you find [Container]
    /// convenient, feel free to use it. If not, feel free to build these simpler
    /// widgets in whatever combination meets your needs.
    ///
    /// In fact, the majority of widgets in Flutter are simply combinations of other
    /// simpler widgets. Composition, rather than inheritance, is the primary
    /// mechanism for building up widgets.
    ///
    /// See also:
    ///
    ///  * [AnimatedPadding], which animates changes in [padding] over a given
    ///    duration.
    ///  * [EdgeInsets], the class that is used to describe the padding dimensions.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Padding : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Padding(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.PaddingValue = padding; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry PaddingValue { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderPadding CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderPadding renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that aligns its child within itself and optionally sizes itself
    /// based on the child's size.
    ///
    /// For example, to align a box at the bottom right, you would pass this box a
    /// tight constraint that is bigger than the child's natural size,
    /// with an alignment of [Alignment.bottomRight].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=g2E7yl3MwMk}
    ///
    /// This widget will be as big as possible if its dimensions are constrained and
    /// [widthFactor] and [heightFactor] are null. If a dimension is unconstrained
    /// and the corresponding size factor is null then the widget will match its
    /// child's size in that dimension. If a size factor is non-null then the
    /// corresponding dimension of this widget will be the product of the child's
    /// dimension and the size factor. For example if widthFactor is 2.0 then
    /// the width of this widget will always be twice its child's width.
    ///
    /// ## How it works
    ///
    /// The [alignment] property describes a point in the `child`'s coordinate system
    /// and a different point in the coordinate system of this widget. The [Align]
    /// widget positions the `child` such that both points are lined up on top of
    /// each other.
    ///
    /// {@tool snippet}
    /// The [Align] widget in this example uses one of the defined constants from
    /// [Alignment], [topRight]. This places the [FlutterLogo] in the top right corner
    /// of the parent blue [Container].
    ///
    /// ![A blue square container with the Flutter logo in the top right corner.](https://flutter.github.io/assets-for-api-docs/assets/widgets/align_constant.png)
    ///
    /// ```dart
    /// Center(
    ///   child: Container(
    ///     height: 120.0,
    ///     width: 120.0,
    ///     color: Colors.blue[50],
    ///     child: Align(
    ///       alignment: Alignment.topRight,
    ///       child: FlutterLogo(
    ///         size: 60,
    ///       ),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    /// The [Alignment] used in the following example defines a single point:
    ///
    ///   * (0.2 * width of [FlutterLogo]/2 + width of [FlutterLogo]/2, 0.6 * height
    ///   of [FlutterLogo]/2 + height of [FlutterLogo]/2) = (36.0, 48.0).
    ///
    /// The [Alignment] class uses a coordinate system with an origin in the center
    /// of the [Container], as shown with the [Icon] above. [Align] will place the
    /// [FlutterLogo] at (36.0, 48.0) according to this coordinate system.
    ///
    /// ![A blue square container with the Flutter logo positioned according to the
    /// Alignment specified above. A point is marked at the center of the container
    /// for the origin of the Alignment coordinate system.](https://flutter.github.io/assets-for-api-docs/assets/widgets/align_alignment.png)
    ///
    /// ```dart
    /// Center(
    ///   child: Container(
    ///     height: 120.0,
    ///     width: 120.0,
    ///     color: Colors.blue[50],
    ///     child: Align(
    ///       alignment: Alignment(0.2, 0.6),
    ///       child: FlutterLogo(
    ///         size: 60,
    ///       ),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    /// The [FractionalOffset] used in the following example defines two points:
    ///
    ///   * (0.2 * width of [FlutterLogo], 0.6 * height of [FlutterLogo]) = (12.0, 36.0)
    ///     in the coordinate system of the blue container.
    ///   * (0.2 * width of [Align], 0.6 * height of [Align]) = (24.0, 72.0) in the
    ///     coordinate system of the [Align] widget.
    ///
    /// The [Align] widget positions the [FlutterLogo] such that the two points are on
    /// top of each other. In this example, the top left of the [FlutterLogo] will
    /// be placed at (24.0, 72.0) - (12.0, 36.0) = (12.0, 36.0) from the top left of
    /// the [Align] widget.
    ///
    /// The [FractionalOffset] class uses a coordinate system with an origin in the top-left
    /// corner of the [Container] in difference to the center-oriented system used in
    /// the example above with [Alignment].
    ///
    /// ![A blue square container with the Flutter logo positioned according to the
    /// FractionalOffset specified above. A point is marked at the top left corner
    /// of the container for the origin of the FractionalOffset coordinate system.](https://flutter.github.io/assets-for-api-docs/assets/widgets/align_fractional_offset.png)
    ///
    /// ```dart
    /// Center(
    ///   child: Container(
    ///     height: 120.0,
    ///     width: 120.0,
    ///     color: Colors.blue[50],
    ///     child: Align(
    ///       alignment: FractionalOffset(0.2, 0.6),
    ///       child: FlutterLogo(
    ///         size: 60,
    ///       ),
    ///     ),
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [AnimatedAlign], which animates changes in [alignment] smoothly over a
    ///    given duration.
    ///  * [CustomSingleChildLayout], which uses a delegate to control the layout of
    ///    a single child.
    ///  * [Center], which is the same as [Align] but with the [alignment] always
    ///    set to [Alignment.center].
    ///  * [FractionallySizedBox], which sizes its child based on a fraction of its
    ///    own size and positions the child according to an [Alignment] value.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Align : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Align(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double widthFactor = default(double), double heightFactor = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Alignment = alignment;
            this.WidthFactor = widthFactor;
            this.HeightFactor = heightFactor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual double WidthFactor { get; set; }
        public virtual double HeightFactor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderPositionedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderPositionedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that centers its child within itself.
    ///
    /// This widget will be as big as possible if its dimensions are constrained and
    /// [widthFactor] and [heightFactor] are null. If a dimension is unconstrained
    /// and the corresponding size factor is null then the widget will match its
    /// child's size in that dimension. If a size factor is non-null then the
    /// corresponding dimension of this widget will be the product of the child's
    /// dimension and the size factor. For example if widthFactor is 2.0 then
    /// the width of this widget will always be twice its child's width.
    ///
    /// See also:
    ///
    ///  * [Align], which lets you arbitrarily position a child within itself,
    ///    rather than just centering it.
    ///  * [Row], a widget that displays its children in a horizontal array.
    ///  * [Column], a widget that displays its children in a vertical array.
    ///  * [Container], a convenience widget that combines common painting,
    ///    positioning, and sizing widgets.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Center : FlutterSDK.Widgets.Basic.Align
    {
        #region constructors
        public Center(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double widthFactor = default(double), double heightFactor = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, widthFactor: widthFactor, heightFactor: heightFactor, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A widget that defers the layout of its single child to a delegate.
    ///
    /// The delegate can determine the layout constraints for the child and can
    /// decide where to position the child. The delegate can also determine the size
    /// of the parent, but the size of the parent cannot depend on the size of the
    /// child.
    ///
    /// See also:
    ///
    ///  * [SingleChildLayoutDelegate], which controls the layout of the child.
    ///  * [Align], which sizes itself based on its child's size and positions
    ///    the child according to an [Alignment] value.
    ///  * [FractionallySizedBox], which sizes its child based on a fraction of its own
    ///    size and positions the child according to an [Alignment] value.
    ///  * [CustomMultiChildLayout], which uses a delegate to position multiple
    ///    children.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class CustomSingleChildLayout : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public CustomSingleChildLayout(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate @delegate = default(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.@delegate = @delegate; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate @delegate { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderCustomSingleChildLayoutBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderCustomSingleChildLayoutBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Metadata for identifying children in a [CustomMultiChildLayout].
    ///
    /// The [MultiChildLayoutDelegate.hasChild],
    /// [MultiChildLayoutDelegate.layoutChild], and
    /// [MultiChildLayoutDelegate.positionChild] methods use these identifiers.
    /// </Summary>
    public class LayoutId : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData>
    {
        #region constructors
        public LayoutId(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), @Object id = default(@Object), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key ?? new ValueKey<object>(id), child: child)
        {
            this.Id = id; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual @Object Id { get; set; }
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that uses a delegate to size and position multiple children.
    ///
    /// The delegate can determine the layout constraints for each child and can
    /// decide where to position each child. The delegate can also determine the
    /// size of the parent, but the size of the parent cannot depend on the sizes of
    /// the children.
    ///
    /// [CustomMultiChildLayout] is appropriate when there are complex relationships
    /// between the size and positioning of multiple widgets. To control the
    /// layout of a single child, [CustomSingleChildLayout] is more appropriate. For
    /// simple cases, such as aligning a widget to one or another edge, the [Stack]
    /// widget is more appropriate.
    ///
    /// Each child must be wrapped in a [LayoutId] widget to identify the widget for
    /// the delegate.
    ///
    /// See also:
    ///
    ///  * [MultiChildLayoutDelegate], for details about how to control the layout of
    ///    the children.
    ///  * [CustomSingleChildLayout], which uses a delegate to control the layout of
    ///    a single child.
    ///  * [Stack], which arranges children relative to the edges of the container.
    ///  * [Flow], which provides paint-time control of its children using transform
    ///    matrices.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class CustomMultiChildLayout : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public CustomMultiChildLayout(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate @delegate = default(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.@delegate = @delegate; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate @delegate { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Customlayout.RenderCustomMultiChildLayoutBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Customlayout.RenderCustomMultiChildLayoutBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A box with a specified size.
    ///
    /// If given a child, this widget forces its child to have a specific width
    /// and/or height (assuming values are permitted by this widget's parent). If
    /// either the width or height is null, this widget will try to size itself to
    /// match the child's size in that dimension. If the child's size depends on the
    /// size of its parent, the height and width must be provided.
    ///
    /// If not given a child, [SizedBox] will try to size itself as close to the
    /// specified height and width as possible given the parent's constraints. If
    /// [height] or [width] is null or unspecified, it will be treated as zero.
    ///
    /// The [new SizedBox.expand] constructor can be used to make a [SizedBox] that
    /// sizes itself to fit the parent. It is equivalent to setting [width] and
    /// [height] to [double.infinity].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=EHPu_DzRfqA}
    ///
    /// {@tool snippet}
    ///
    /// This snippet makes the child widget (a [Card] with some [Text]) have the
    /// exact size 200x300, parental constraints permitting:
    ///
    /// ```dart
    /// SizedBox(
    ///   width: 200.0,
    ///   height: 300.0,
    ///   child: const Card(child: Text('Hello World!')),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [ConstrainedBox], a more generic version of this class that takes
    ///    arbitrary [BoxConstraints] instead of an explicit width and height.
    ///  * [UnconstrainedBox], a container that tries to let its child draw without
    ///    constraints.
    ///  * [FractionallySizedBox], a widget that sizes its child to a fraction of
    ///    the total available space.
    ///  * [AspectRatio], a widget that attempts to fit within the parent's
    ///    constraints while also sizing its child to match a given aspect ratio.
    ///  * [FittedBox], which sizes and positions its child widget to fit the parent
    ///    according to a given [BoxFit] discipline.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class SizedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SizedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double width = default(double), double height = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Width = width;
            this.Height = height; throw new NotImplementedException();
        }
        public static SizedBox Expand(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new SizedBox(key: key, child: child); throw new NotImplementedException();
        }
        public static SizedBox Shrink(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new SizedBox(key: key, child: child); throw new NotImplementedException();
        }
        public static SizedBox FromSize(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), Size size = default(Size))
        {
            var instance = new SizedBox(key: key, child: child); throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        internal virtual FlutterSDK.Rendering.Box.BoxConstraints _AdditionalConstraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderConstrainedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderConstrainedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that imposes additional constraints on its child.
    ///
    /// For example, if you wanted [child] to have a minimum height of 50.0 logical
    /// pixels, you could use `const BoxConstraints(minHeight: 50.0)` as the
    /// [constraints].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=o2KveVr7adg}
    ///
    /// {@tool snippet}
    ///
    /// This snippet makes the child widget (a [Card] with some [Text]) fill the
    /// parent, by applying [BoxConstraints.expand] constraints:
    ///
    /// ```dart
    /// ConstrainedBox(
    ///   constraints: const BoxConstraints.expand(),
    ///   child: const Card(child: Text('Hello World!')),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// The same behavior can be obtained using the [new SizedBox.expand] widget.
    ///
    /// See also:
    ///
    ///  * [BoxConstraints], the class that describes constraints.
    ///  * [UnconstrainedBox], a container that tries to let its child draw without
    ///    constraints.
    ///  * [SizedBox], which lets you specify tight constraints by explicitly
    ///    specifying the height or width.
    ///  * [FractionallySizedBox], which sizes its child based on a fraction of its
    ///    own size and positions the child according to an [Alignment] value.
    ///  * [AspectRatio], a widget that attempts to fit within the parent's
    ///    constraints while also sizing its child to match a given aspect ratio.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class ConstrainedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ConstrainedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Constraints = constraints; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderConstrainedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderConstrainedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that imposes no constraints on its child, allowing it to render
    /// at its "natural" size.
    ///
    /// This allows a child to render at the size it would render if it were alone
    /// on an infinite canvas with no constraints. This container will then attempt
    /// to adopt the same size, within the limits of its own constraints. If it ends
    /// up with a different size, it will align the child based on [alignment].
    /// If the box cannot expand enough to accommodate the entire child, the
    /// child will be clipped.
    ///
    /// In debug mode, if the child overflows the container, a warning will be
    /// printed on the console, and black and yellow striped areas will appear where
    /// the overflow occurs.
    ///
    /// See also:
    ///
    ///  * [ConstrainedBox], for a box which imposes constraints on its child.
    ///  * [Align], which loosens the constraints given to the child rather than
    ///    removing them entirely.
    ///  * [Container], a convenience widget that combines common painting,
    ///    positioning, and sizing widgets.
    ///  * [OverflowBox], a widget that imposes different constraints on its child
    ///    than it gets from its parent, possibly allowing the child to overflow
    ///    the parent.
    /// </Summary>
    public class UnconstrainedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public UnconstrainedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Basictypes.Axis constrainedAxis = default(FlutterSDK.Painting.Basictypes.Axis))
        : base(key: key, child: child)
        {
            this.TextDirection = textDirection;
            this.Alignment = alignment;
            this.ConstrainedAxis = constrainedAxis; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis ConstrainedAxis { get; set; }
        #endregion

        #region methods

        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderUnconstrainedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Shiftedbox.RenderUnconstrainedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that sizes its child to a fraction of the total available space.
    /// For more details about the layout algorithm, see
    /// [RenderFractionallySizedOverflowBox].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=PEsY654EGZ0}
    ///
    /// See also:
    ///
    ///  * [Align], which sizes itself based on its child's size and positions
    ///    the child according to an [Alignment] value.
    ///  * [OverflowBox], a widget that imposes different constraints on its child
    ///    than it gets from its parent, possibly allowing the child to overflow the
    ///    parent.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class FractionallySizedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public FractionallySizedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double widthFactor = default(double), double heightFactor = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Alignment = alignment;
            this.WidthFactor = widthFactor;
            this.HeightFactor = heightFactor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double WidthFactor { get; set; }
        public virtual double HeightFactor { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderFractionallySizedOverflowBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderFractionallySizedOverflowBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A box that limits its size only when it's unconstrained.
    ///
    /// If this widget's maximum width is unconstrained then its child's width is
    /// limited to [maxWidth]. Similarly, if this widget's maximum height is
    /// unconstrained then its child's height is limited to [maxHeight].
    ///
    /// This has the effect of giving the child a natural dimension in unbounded
    /// environments. For example, by providing a [maxHeight] to a widget that
    /// normally tries to be as big as possible, the widget will normally size
    /// itself to fit its parent, but when placed in a vertical list, it will take
    /// on the given height.
    ///
    /// This is useful when composing widgets that normally try to match their
    /// parents' size, so that they behave reasonably in lists (which are
    /// unbounded).
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=uVki2CIzBTs}
    ///
    /// See also:
    ///
    ///  * [ConstrainedBox], which applies its constraints in all cases, not just
    ///    when the incoming constraints are unbounded.
    ///  * [SizedBox], which lets you specify tight constraints by explicitly
    ///    specifying the height or width.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class LimitedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public LimitedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double maxWidth = default(double), double maxHeight = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.MaxWidth = maxWidth;
            this.MaxHeight = maxHeight; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double MaxWidth { get; set; }
        public virtual double MaxHeight { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderLimitedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderLimitedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that imposes different constraints on its child than it gets
    /// from its parent, possibly allowing the child to overflow the parent.
    ///
    /// See also:
    ///
    ///  * [RenderConstrainedOverflowBox] for details about how [OverflowBox] is
    ///    rendered.
    ///  * [SizedOverflowBox], a widget that is a specific size but passes its
    ///    original constraints through to its child, which may then overflow.
    ///  * [ConstrainedBox], a widget that imposes additional constraints on its
    ///    child.
    ///  * [UnconstrainedBox], a container that tries to let its child draw without
    ///    constraints.
    ///  * [SizedBox], a box with a specified size.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class OverflowBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public OverflowBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double minWidth = default(double), double maxWidth = default(double), double minHeight = default(double), double maxHeight = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Alignment = alignment;
            this.MinWidth = minWidth;
            this.MaxWidth = maxWidth;
            this.MinHeight = minHeight;
            this.MaxHeight = maxHeight; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual double MinWidth { get; set; }
        public virtual double MaxWidth { get; set; }
        public virtual double MinHeight { get; set; }
        public virtual double MaxHeight { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderConstrainedOverflowBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderConstrainedOverflowBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that is a specific size but passes its original constraints
    /// through to its child, which may then overflow.
    ///
    /// See also:
    ///
    ///  * [OverflowBox], A widget that imposes different constraints on its child
    ///    than it gets from its parent, possibly allowing the child to overflow the
    ///    parent.
    ///  * [ConstrainedBox], a widget that imposes additional constraints on its
    ///    child.
    ///  * [UnconstrainedBox], a container that tries to let its child draw without
    ///    constraints.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class SizedOverflowBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SizedOverflowBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Size size = default(Size), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Size = size;
            this.Alignment = alignment; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual Size Size { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderSizedOverflowBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderSizedOverflowBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that lays the child out as if it was in the tree, but without
    /// painting anything, without making the child available for hit testing, and
    /// without taking any room in the parent.
    ///
    /// Offstage children are still active: they can receive focus and have keyboard
    /// input directed to them.
    ///
    /// Animations continue to run in offstage children, and therefore use battery
    /// and CPU time, regardless of whether the animations end up being visible.
    ///
    /// [Offstage] can be used to measure the dimensions of a widget without
    /// bringing it on screen (yet). To hide a widget from view while it is not
    /// needed, prefer removing the widget from the tree entirely rather than
    /// keeping it alive in an [Offstage] subtree.
    ///
    /// See also:
    ///
    ///  * [Visibility], which can hide a child more efficiently (albeit less
    ///    subtly).
    ///  * [TickerMode], which can be used to disable animations in a subtree.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Offstage : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Offstage(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool offstage = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.OffstageValue = offstage; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool OffstageValue { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderOffstage CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderOffstage renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Basic._OffstageElement CreateElement() { throw new NotImplementedException(); }

        #endregion
    }


    public class _OffstageElement : FlutterSDK.Widgets.Framework.SingleChildRenderObjectElement
    {
        #region constructors
        public _OffstageElement(FlutterSDK.Widgets.Basic.Offstage widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Basic.Offstage Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that attempts to size the child to a specific aspect ratio.
    ///
    /// The widget first tries the largest width permitted by the layout
    /// constraints. The height of the widget is determined by applying the
    /// given aspect ratio to the width, expressed as a ratio of width to height.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=XcnP3_mO_Ms}
    ///
    /// For example, a 16:9 width:height aspect ratio would have a value of
    /// 16.0/9.0. If the maximum width is infinite, the initial width is determined
    /// by applying the aspect ratio to the maximum height.
    ///
    /// Now consider a second example, this time with an aspect ratio of 2.0 and
    /// layout constraints that require the width to be between 0.0 and 100.0 and
    /// the height to be between 0.0 and 100.0. We'll select a width of 100.0 (the
    /// biggest allowed) and a height of 50.0 (to match the aspect ratio).
    ///
    /// In that same situation, if the aspect ratio is 0.5, we'll also select a
    /// width of 100.0 (still the biggest allowed) and we'll attempt to use a height
    /// of 200.0. Unfortunately, that violates the constraints because the child can
    /// be at most 100.0 pixels tall. The widget will then take that value
    /// and apply the aspect ratio again to obtain a width of 50.0. That width is
    /// permitted by the constraints and the child receives a width of 50.0 and a
    /// height of 100.0. If the width were not permitted, the widget would
    /// continue iterating through the constraints. If the widget does not
    /// find a feasible size after consulting each constraint, the widget
    /// will eventually select a size for the child that meets the layout
    /// constraints but fails to meet the aspect ratio constraints.
    ///
    /// See also:
    ///
    ///  * [Align], a widget that aligns its child within itself and optionally
    ///    sizes itself based on the child's size.
    ///  * [ConstrainedBox], a widget that imposes additional constraints on its
    ///    child.
    ///  * [UnconstrainedBox], a container that tries to let its child draw without
    ///    constraints.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class AspectRatio : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public AspectRatio(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double aspectRatio = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.AspectRatioValue = aspectRatio; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double AspectRatioValue { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderAspectRatio CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderAspectRatio renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that sizes its child to the child's intrinsic width.
    ///
    /// Sizes its child's width to the child's maximum intrinsic width. If
    /// [stepWidth] is non-null, the child's width will be snapped to a multiple of
    /// the [stepWidth]. Similarly, if [stepHeight] is non-null, the child's height
    /// will be snapped to a multiple of the [stepHeight].
    ///
    /// This class is useful, for example, when unlimited width is available and
    /// you would like a child that would otherwise attempt to expand infinitely to
    /// instead size itself to a more reasonable width.
    ///
    /// This class is relatively expensive, because it adds a speculative layout
    /// pass before the final layout phase. Avoid using it where possible. In the
    /// worst case, this widget can result in a layout that is O(N²) in the depth of
    /// the tree.
    ///
    /// See also:
    ///
    ///  * [The catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class IntrinsicWidth : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public IntrinsicWidth(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double stepWidth = default(double), double stepHeight = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.StepWidth = stepWidth;
            this.StepHeight = stepHeight; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double StepWidth { get; set; }
        public virtual double StepHeight { get; set; }
        internal virtual double _StepWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _StepHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderIntrinsicWidth CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderIntrinsicWidth renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that sizes its child to the child's intrinsic height.
    ///
    /// This class is useful, for example, when unlimited height is available and
    /// you would like a child that would otherwise attempt to expand infinitely to
    /// instead size itself to a more reasonable height.
    ///
    /// This class is relatively expensive, because it adds a speculative layout
    /// pass before the final layout phase. Avoid using it where possible. In the
    /// worst case, this widget can result in a layout that is O(N²) in the depth of
    /// the tree.
    ///
    /// See also:
    ///
    ///  * [The catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class IntrinsicHeight : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public IntrinsicHeight(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderIntrinsicHeight CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that positions its child according to the child's baseline.
    ///
    /// This widget shifts the child down such that the child's baseline (or the
    /// bottom of the child, if the child has no baseline) is [baseline]
    /// logical pixels below the top of this box, then sizes this box to
    /// contain the child. If [baseline] is less than the distance from
    /// the top of the child to the baseline of the child, then the child
    /// is top-aligned instead.
    ///
    /// See also:
    ///
    ///  * [Align], a widget that aligns its child within itself and optionally
    ///    sizes itself based on the child's size.
    ///  * [Center], a widget that centers its child within itself.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Baseline : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Baseline(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double baseline = default(double), TextBaseline baselineType = default(TextBaseline), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.BaselineValue = baseline;
            this.BaselineType = baselineType; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double BaselineValue { get; set; }
        public virtual TextBaseline BaselineType { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderBaseline CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderBaseline renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A sliver that contains a single box widget.
    ///
    /// Slivers are special-purpose widgets that can be combined using a
    /// [CustomScrollView] to create custom scroll effects. A [SliverToBoxAdapter]
    /// is a basic sliver that creates a bridge back to one of the usual box-based
    /// widgets.
    ///
    /// Rather than using multiple [SliverToBoxAdapter] widgets to display multiple
    /// box widgets in a [CustomScrollView], consider using [SliverList],
    /// [SliverFixedExtentList], [SliverPrototypeExtentList], or [SliverGrid],
    /// which are more efficient because they instantiate only those children that
    /// are actually visible through the scroll view's viewport.
    ///
    /// See also:
    ///
    ///  * [CustomScrollView], which displays a scrollable list of slivers.
    ///  * [SliverList], which displays multiple box widgets in a linear array.
    ///  * [SliverFixedExtentList], which displays multiple box widgets with the
    ///    same main-axis extent in a linear array.
    ///  * [SliverPrototypeExtentList], which displays multiple box widgets with the
    ///    same main-axis extent as a prototype item, in a linear array.
    ///  * [SliverGrid], which displays multiple box widgets in arbitrary positions.
    /// </Summary>
    public class SliverToBoxAdapter : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SliverToBoxAdapter(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Sliver.RenderSliverToBoxAdapter CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A sliver that applies padding on each side of another sliver.
    ///
    /// Slivers are special-purpose widgets that can be combined using a
    /// [CustomScrollView] to create custom scroll effects. A [SliverPadding]
    /// is a basic sliver that insets another sliver by applying padding on each
    /// side.
    ///
    /// Applying padding to anything but the most mundane sliver is likely to have
    /// undesired effects. For example, wrapping a [SliverPersistentHeader] with
    /// `pinned:true` will cause the app bar to overlap earlier slivers (contrary to
    /// the normal behavior of pinned app bars), and while the app bar is pinned,
    /// the padding will scroll away.
    ///
    /// See also:
    ///
    ///  * [CustomScrollView], which displays a scrollable list of slivers.
    /// </Summary>
    public class SliverPadding : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SliverPadding(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: sliver)
        {
            this.Padding = padding; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Sliverpadding.RenderSliverPadding CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Sliverpadding.RenderSliverPadding renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that arranges its children sequentially along a given axis, forcing
    /// them to the dimension of the parent in the other axis.
    ///
    /// This widget is rarely used directly. Instead, consider using [ListView],
    /// which combines a similar layout algorithm with scrolling behavior, or
    /// [Column], which gives you more flexible control over the layout of a
    /// vertical set of boxes.
    ///
    /// See also:
    ///
    ///  * [RenderListBody], which implements this layout algorithm and the
    ///    documentation for which describes some of its subtleties.
    ///  * [SingleChildScrollView], which is sometimes used with [ListBody] to
    ///    make the contents scrollable.
    ///  * [Column] and [Row], which implement a more elaborate version of
    ///    this layout algorithm (at the cost of being slightly less efficient).
    ///  * [ListView], which implements an efficient scrolling version of this
    ///    layout algorithm.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class ListBody : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public ListBody(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis mainAxis = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.MainAxis = mainAxis;
            this.Reverse = reverse; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Basictypes.Axis MainAxis { get; set; }
        public virtual bool Reverse { get; set; }
        #endregion

        #region methods

        private FlutterSDK.Painting.Basictypes.AxisDirection _GetDirection(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Listbody.RenderListBody CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Listbody.RenderListBody renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that positions its children relative to the edges of its box.
    ///
    /// This class is useful if you want to overlap several children in a simple
    /// way, for example having some text and an image, overlaid with a gradient and
    /// a button attached to the bottom.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=liEGSeD3Zt8}
    ///
    /// Each child of a [Stack] widget is either _positioned_ or _non-positioned_.
    /// Positioned children are those wrapped in a [Positioned] widget that has at
    /// least one non-null property. The stack sizes itself to contain all the
    /// non-positioned children, which are positioned according to [alignment]
    /// (which defaults to the top-left corner in left-to-right environments and the
    /// top-right corner in right-to-left environments). The positioned children are
    /// then placed relative to the stack according to their top, right, bottom, and
    /// left properties.
    ///
    /// The stack paints its children in order with the first child being at the
    /// bottom. If you want to change the order in which the children paint, you
    /// can rebuild the stack with the children in the new order. If you reorder
    /// the children in this way, consider giving the children non-null keys.
    /// These keys will cause the framework to move the underlying objects for
    /// the children to their new locations rather than recreate them at their
    /// new location.
    ///
    /// For more details about the stack layout algorithm, see [RenderStack].
    ///
    /// If you want to lay a number of children out in a particular pattern, or if
    /// you want to make a custom layout manager, you probably want to use
    /// [CustomMultiChildLayout] instead. In particular, when using a [Stack] you
    /// can't position children relative to their size or the stack's own size.
    ///
    /// {@tool snippet}
    ///
    /// Using a [Stack] you can position widgets over one another.
    ///
    /// ![The sample creates a blue box that overlaps a larger green box, which itself overlaps an even larger red box.](https://flutter.github.io/assets-for-api-docs/assets/widgets/stack.png)
    ///
    /// ```dart
    /// Stack(
    ///   children: <Widget>[
    ///     Container(
    ///       width: 100,
    ///       height: 100,
    ///       color: Colors.red,
    ///     ),
    ///     Container(
    ///       width: 90,
    ///       height: 90,
    ///       color: Colors.green,
    ///     ),
    ///     Container(
    ///       width: 80,
    ///       height: 80,
    ///       color: Colors.blue,
    ///     ),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// {@tool snippet}
    ///
    /// This example shows how [Stack] can be used to enhance text visibility
    /// by adding gradient backdrops.
    ///
    /// ![The gradient fades from transparent to dark grey at the bottom, with white text on top of the darker portion.](https://flutter.github.io/assets-for-api-docs/assets/widgets/stack_with_gradient.png)
    ///
    /// ```dart
    /// SizedBox(
    ///   width: 250,
    ///   height: 250,
    ///   child: Stack(
    ///     children: <Widget>[
    ///       Container(
    ///         width: 250,
    ///         height: 250,
    ///         color: Colors.white,
    ///       ),
    ///       Container(
    ///         padding: EdgeInsets.all(5.0),
    ///         alignment: Alignment.bottomCenter,
    ///         decoration: BoxDecoration(
    ///           gradient: LinearGradient(
    ///             begin: Alignment.topCenter,
    ///             end: Alignment.bottomCenter,
    ///             colors: <Color>[
    ///               Colors.black.withAlpha(0),
    ///               Colors.black12,
    ///               Colors.black45
    ///             ],
    ///           ),
    ///         ),
    ///         child: Text(
    ///           "Foreground Text",
    ///           style: TextStyle(color: Colors.white, fontSize: 20.0),
    ///         ),
    ///       ),
    ///     ],
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Align], which sizes itself based on its child's size and positions
    ///    the child according to an [Alignment] value.
    ///  * [CustomSingleChildLayout], which uses a delegate to control the layout of
    ///    a single child.
    ///  * [CustomMultiChildLayout], which uses a delegate to position multiple
    ///    children.
    ///  * [Flow], which provides paint-time control of its children using transform
    ///    matrices.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Stack : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public Stack(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Stack.StackFit fit = default(FlutterSDK.Rendering.Stack.StackFit), FlutterSDK.Rendering.Stack.Overflow overflow = default(FlutterSDK.Rendering.Stack.Overflow), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.Alignment = alignment;
            this.TextDirection = textDirection;
            this.Fit = fit;
            this.Overflow = overflow; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Rendering.Stack.StackFit Fit { get; set; }
        public virtual FlutterSDK.Rendering.Stack.Overflow Overflow { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Stack.RenderStack CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Stack.RenderStack renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A [Stack] that shows a single child from a list of children.
    ///
    /// The displayed child is the one with the given [index]. The stack is
    /// always as big as the largest child.
    ///
    /// If value is null, then nothing is displayed.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=_O0PPD1Xfbk}
    ///
    /// See also:
    ///
    ///  * [Stack], for more details about stacks.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class IndexedStack : FlutterSDK.Widgets.Basic.Stack
    {
        #region constructors
        public IndexedStack(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Stack.StackFit sizing = default(FlutterSDK.Rendering.Stack.StackFit), int index = 0, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, alignment: alignment, textDirection: textDirection, fit: sizing, children: children)
        {
            this.Index = index; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int Index { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Stack.RenderIndexedStack CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Stack.RenderIndexedStack renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that controls where a child of a [Stack] is positioned.
    ///
    /// A [Positioned] widget must be a descendant of a [Stack], and the path from
    /// the [Positioned] widget to its enclosing [Stack] must contain only
    /// [StatelessWidget]s or [StatefulWidget]s (not other kinds of widgets, like
    /// [RenderObjectWidget]s).
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=EgtPleVwxBQ}
    ///
    /// If a widget is wrapped in a [Positioned], then it is a _positioned_ widget
    /// in its [Stack]. If the [top] property is non-null, the top edge of this child
    /// will be positioned [top] layout units from the top of the stack widget. The
    /// [right], [bottom], and [left] properties work analogously.
    ///
    /// If both the [top] and [bottom] properties are non-null, then the child will
    /// be forced to have exactly the height required to satisfy both constraints.
    /// Similarly, setting the [right] and [left] properties to non-null values will
    /// force the child to have a particular width. Alternatively the [width] and
    /// [height] properties can be used to give the dimensions, with one
    /// corresponding position property (e.g. [top] and [height]).
    ///
    /// If all three values on a particular axis are null, then the
    /// [Stack.alignment] property is used to position the child.
    ///
    /// If all six values are null, the child is a non-positioned child. The [Stack]
    /// uses only the non-positioned children to size itself.
    ///
    /// See also:
    ///
    ///  * [AnimatedPositioned], which automatically transitions the child's
    ///    position over a given duration whenever the given position changes.
    ///  * [PositionedTransition], which takes a provided [Animation] to transition
    ///    changes in the child's position over a given duration.
    ///  * [PositionedDirectional], which adapts to the ambient [Directionality].
    /// </Summary>
    public class Positioned : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.Stack.StackParentData>
    {
        #region constructors
        public Positioned(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double left = default(double), double top = default(double), double right = default(double), double bottom = default(double), double width = default(double), double height = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
            this.Width = width;
            this.Height = height; throw new NotImplementedException();
        }
        public static Positioned FromRect(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Positioned(key: key, child: child); throw new NotImplementedException();
        }
        public static Positioned FromRelativeRect(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Stack.RelativeRect rect = default(FlutterSDK.Rendering.Stack.RelativeRect), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Positioned(key: key, child: child); throw new NotImplementedException();
        }
        public static Positioned Fill(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Positioned(key: key, child: child); instance.Left = left;
            instance.Top = top;
            instance.Right = right;
            instance.Bottom = bottom; throw new NotImplementedException();
        }
        public static Positioned Directional(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), TextDirection textDirection = default(TextDirection), double start = default(double), double top = default(double), double end = default(double), double bottom = default(double), double width = default(double), double height = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Positioned(); throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Left { get; set; }
        public virtual double Top { get; set; }
        public virtual double Right { get; set; }
        public virtual double Bottom { get; set; }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that controls where a child of a [Stack] is positioned without
    /// committing to a specific [TextDirection].
    ///
    /// The ambient [Directionality] is used to determine whether [start] is to the
    /// left or to the right.
    ///
    /// A [PositionedDirectional] widget must be a descendant of a [Stack], and the
    /// path from the [PositionedDirectional] widget to its enclosing [Stack] must
    /// contain only [StatelessWidget]s or [StatefulWidget]s (not other kinds of
    /// widgets, like [RenderObjectWidget]s).
    ///
    /// If a widget is wrapped in a [PositionedDirectional], then it is a
    /// _positioned_ widget in its [Stack]. If the [top] property is non-null, the
    /// top edge of this child/ will be positioned [top] layout units from the top
    /// of the stack widget. The [start], [bottom], and [end] properties work
    /// analogously.
    ///
    /// If both the [top] and [bottom] properties are non-null, then the child will
    /// be forced to have exactly the height required to satisfy both constraints.
    /// Similarly, setting the [start] and [end] properties to non-null values will
    /// force the child to have a particular width. Alternatively the [width] and
    /// [height] properties can be used to give the dimensions, with one
    /// corresponding position property (e.g. [top] and [height]).
    ///
    /// See also:
    ///
    ///  * [Positioned], which specifies the widget's position visually.
    ///  * [Positioned.directional], which also specifies the widget's horizontal
    ///    position using [start] and [end] but has an explicit [TextDirection].
    ///  * [AnimatedPositionedDirectional], which automatically transitions
    ///    the child's position over a given duration whenever the given position
    ///    changes.
    /// </Summary>
    public class PositionedDirectional : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public PositionedDirectional(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double start = default(double), double top = default(double), double end = default(double), double bottom = default(double), double width = default(double), double height = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Start = start;
            this.Top = top;
            this.End = end;
            this.Bottom = bottom;
            this.Width = width;
            this.Height = height;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Start { get; set; }
        public virtual double Top { get; set; }
        public virtual double End { get; set; }
        public virtual double Bottom { get; set; }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that displays its children in a one-dimensional array.
    ///
    /// The [Flex] widget allows you to control the axis along which the children are
    /// placed (horizontal or vertical). This is referred to as the _main axis_. If
    /// you know the main axis in advance, then consider using a [Row] (if it's
    /// horizontal) or [Column] (if it's vertical) instead, because that will be less
    /// verbose.
    ///
    /// To cause a child to expand to fill the available space in the [direction]
    /// of this widget's main axis, wrap the child in an [Expanded] widget.
    ///
    /// The [Flex] widget does not scroll (and in general it is considered an error
    /// to have more children in a [Flex] than will fit in the available room). If
    /// you have some widgets and want them to be able to scroll if there is
    /// insufficient room, consider using a [ListView].
    ///
    /// If you only have one child, then rather than using [Flex], [Row], or
    /// [Column], consider using [Align] or [Center] to position the child.
    ///
    /// ## Layout algorithm
    ///
    /// _This section describes how a [Flex] is rendered by the framework._
    /// _See [BoxConstraints] for an introduction to box layout models._
    ///
    /// Layout for a [Flex] proceeds in six steps:
    ///
    /// 1. Layout each child a null or zero flex factor (e.g., those that are not
    ///    [Expanded]) with unbounded main axis constraints and the incoming
    ///    cross axis constraints. If the [crossAxisAlignment] is
    ///    [CrossAxisAlignment.stretch], instead use tight cross axis constraints
    ///    that match the incoming max extent in the cross axis.
    /// 2. Divide the remaining main axis space among the children with non-zero
    ///    flex factors (e.g., those that are [Expanded]) according to their flex
    ///    factor. For example, a child with a flex factor of 2.0 will receive twice
    ///    the amount of main axis space as a child with a flex factor of 1.0.
    /// 3. Layout each of the remaining children with the same cross axis
    ///    constraints as in step 1, but instead of using unbounded main axis
    ///    constraints, use max axis constraints based on the amount of space
    ///    allocated in step 2. Children with [Flexible.fit] properties that are
    ///    [FlexFit.tight] are given tight constraints (i.e., forced to fill the
    ///    allocated space), and children with [Flexible.fit] properties that are
    ///    [FlexFit.loose] are given loose constraints (i.e., not forced to fill the
    ///    allocated space).
    /// 4. The cross axis extent of the [Flex] is the maximum cross axis extent of
    ///    the children (which will always satisfy the incoming constraints).
    /// 5. The main axis extent of the [Flex] is determined by the [mainAxisSize]
    ///    property. If the [mainAxisSize] property is [MainAxisSize.max], then the
    ///    main axis extent of the [Flex] is the max extent of the incoming main
    ///    axis constraints. If the [mainAxisSize] property is [MainAxisSize.min],
    ///    then the main axis extent of the [Flex] is the sum of the main axis
    ///    extents of the children (subject to the incoming constraints).
    /// 6. Determine the position for each child according to the
    ///    [mainAxisAlignment] and the [crossAxisAlignment]. For example, if the
    ///    [mainAxisAlignment] is [MainAxisAlignment.spaceBetween], any main axis
    ///    space that has not been allocated to children is divided evenly and
    ///    placed between the children.
    ///
    /// See also:
    ///
    ///  * [Row], for a version of this widget that is always horizontal.
    ///  * [Column], for a version of this widget that is always vertical.
    ///  * [Expanded], to indicate children that should take all the remaining room.
    ///  * [Flexible], to indicate children that should share the remaining room.
    ///  * [Spacer], a widget that takes up space proportional to it's flex value.
    ///    that may be sized smaller (leaving some remaining room unused).
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Flex : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public Flex(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis direction = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), TextBaseline textBaseline = default(TextBaseline), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.Direction = direction;
            this.MainAxisAlignment = mainAxisAlignment;
            this.MainAxisSize = mainAxisSize;
            this.CrossAxisAlignment = crossAxisAlignment;
            this.TextDirection = textDirection;
            this.VerticalDirection = verticalDirection;
            this.TextBaseline = textBaseline; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Basictypes.Axis Direction { get; set; }
        public virtual FlutterSDK.Rendering.Flex.MainAxisAlignment MainAxisAlignment { get; set; }
        public virtual FlutterSDK.Rendering.Flex.MainAxisSize MainAxisSize { get; set; }
        public virtual FlutterSDK.Rendering.Flex.CrossAxisAlignment CrossAxisAlignment { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.VerticalDirection VerticalDirection { get; set; }
        public virtual TextBaseline TextBaseline { get; set; }
        internal virtual bool _NeedTextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// The value to pass to [RenderFlex.textDirection].
        ///
        /// This value is derived from the [textDirection] property and the ambient
        /// [Directionality]. The value is null if there is no need to specify the
        /// text direction. In practice there's always a need to specify the direction
        /// except for vertical flexes (e.g. [Column]s) whose [crossAxisAlignment] is
        /// not dependent on the text direction (not `start` or `end`). In particular,
        /// a [Row] always needs a text direction because the text direction controls
        /// its layout order. (For [Column]s, the layout order is controlled by
        /// [verticalDirection], which is always specified as it does not depend on an
        /// inherited widget and defaults to [VerticalDirection.down].)
        ///
        /// This method exists so that subclasses of [Flex] that create their own
        /// render objects that are derived from [RenderFlex] can do so and still use
        /// the logic for providing a text direction only when it is necessary.
        /// </Summary>
        public virtual TextDirection GetEffectiveTextDirection(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Flex.RenderFlex CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Flex.RenderFlex renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that displays its children in a horizontal array.
    ///
    /// To cause a child to expand to fill the available horizontal space, wrap the
    /// child in an [Expanded] widget.
    ///
    /// The [Row] widget does not scroll (and in general it is considered an error
    /// to have more children in a [Row] than will fit in the available room). If
    /// you have a line of widgets and want them to be able to scroll if there is
    /// insufficient room, consider using a [ListView].
    ///
    /// For a vertical variant, see [Column].
    ///
    /// If you only have one child, then consider using [Align] or [Center] to
    /// position the child.
    ///
    /// {@tool snippet}
    ///
    /// This example divides the available space into three (horizontally), and
    /// places text centered in the first two cells and the Flutter logo centered in
    /// the third:
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/widgets/row.png)
    ///
    /// ```dart
    /// Row(
    ///   children: <Widget>[
    ///     Expanded(
    ///       child: Text('Deliver features faster', textAlign: TextAlign.center),
    ///     ),
    ///     Expanded(
    ///       child: Text('Craft beautiful UIs', textAlign: TextAlign.center),
    ///     ),
    ///     Expanded(
    ///       child: FittedBox(
    ///         fit: BoxFit.contain, // otherwise the logo will be tiny
    ///         child: const FlutterLogo(),
    ///       ),
    ///     ),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ## Troubleshooting
    ///
    /// ### Why does my row have a yellow and black warning stripe?
    ///
    /// If the non-flexible contents of the row (those that are not wrapped in
    /// [Expanded] or [Flexible] widgets) are together wider than the row itself,
    /// then the row is said to have overflowed. When a row overflows, the row does
    /// not have any remaining space to share between its [Expanded] and [Flexible]
    /// children. The row reports this by drawing a yellow and black striped
    /// warning box on the edge that is overflowing. If there is room on the outside
    /// of the row, the amount of overflow is printed in red lettering.
    ///
    /// #### Story time
    ///
    /// Suppose, for instance, that you had this code:
    ///
    /// ```dart
    /// Row(
    ///   children: <Widget>[
    ///     const FlutterLogo(),
    ///     const Text("Flutter's hot reload helps you quickly and easily experiment, build UIs, add features, and fix bug faster. Experience sub-second reload times, without losing state, on emulators, simulators, and hardware for iOS and Android."),
    ///     const Icon(Icons.sentiment_very_satisfied),
    ///   ],
    /// )
    /// ```
    ///
    /// The row first asks its first child, the [FlutterLogo], to lay out, at
    /// whatever size the logo would like. The logo is friendly and happily decides
    /// to be 24 pixels to a side. This leaves lots of room for the next child. The
    /// row then asks that next child, the text, to lay out, at whatever size it
    /// thinks is best.
    ///
    /// At this point, the text, not knowing how wide is too wide, says "Ok, I will
    /// be thiiiiiiiiiiiiiiiiiiiis wide.", and goes well beyond the space that the
    /// row has available, not wrapping. The row responds, "That's not fair, now I
    /// have no more room available for my other children!", and gets angry and
    /// sprouts a yellow and black strip.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/widgets/row_error.png)
    ///
    /// The fix is to wrap the second child in an [Expanded] widget, which tells the
    /// row that the child should be given the remaining room:
    ///
    /// ```dart
    /// Row(
    ///   children: <Widget>[
    ///     const FlutterLogo(),
    ///     const Expanded(
    ///       child: Text("Flutter's hot reload helps you quickly and easily experiment, build UIs, add features, and fix bug faster. Experience sub-second reload times, without losing state, on emulators, simulators, and hardware for iOS and Android."),
    ///     ),
    ///     const Icon(Icons.sentiment_very_satisfied),
    ///   ],
    /// )
    /// ```
    ///
    /// Now, the row first asks the logo to lay out, and then asks the _icon_ to lay
    /// out. The [Icon], like the logo, is happy to take on a reasonable size (also
    /// 24 pixels, not coincidentally, since both [FlutterLogo] and [Icon] honor the
    /// ambient [IconTheme]). This leaves some room left over, and now the row tells
    /// the text exactly how wide to be: the exact width of the remaining space. The
    /// text, now happy to comply to a reasonable request, wraps the text within
    /// that width, and you end up with a paragraph split over several lines.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/widgets/row_fixed.png)
    ///
    /// ## Layout algorithm
    ///
    /// _This section describes how a [Row] is rendered by the framework._
    /// _See [BoxConstraints] for an introduction to box layout models._
    ///
    /// Layout for a [Row] proceeds in six steps:
    ///
    /// 1. Layout each child a null or zero flex factor (e.g., those that are not
    ///    [Expanded]) with unbounded horizontal constraints and the incoming
    ///    vertical constraints. If the [crossAxisAlignment] is
    ///    [CrossAxisAlignment.stretch], instead use tight vertical constraints that
    ///    match the incoming max height.
    /// 2. Divide the remaining horizontal space among the children with non-zero
    ///    flex factors (e.g., those that are [Expanded]) according to their flex
    ///    factor. For example, a child with a flex factor of 2.0 will receive twice
    ///    the amount of horizontal space as a child with a flex factor of 1.0.
    /// 3. Layout each of the remaining children with the same vertical constraints
    ///    as in step 1, but instead of using unbounded horizontal constraints, use
    ///    horizontal constraints based on the amount of space allocated in step 2.
    ///    Children with [Flexible.fit] properties that are [FlexFit.tight] are
    ///    given tight constraints (i.e., forced to fill the allocated space), and
    ///    children with [Flexible.fit] properties that are [FlexFit.loose] are
    ///    given loose constraints (i.e., not forced to fill the allocated space).
    /// 4. The height of the [Row] is the maximum height of the children (which will
    ///    always satisfy the incoming vertical constraints).
    /// 5. The width of the [Row] is determined by the [mainAxisSize] property. If
    ///    the [mainAxisSize] property is [MainAxisSize.max], then the width of the
    ///    [Row] is the max width of the incoming constraints. If the [mainAxisSize]
    ///    property is [MainAxisSize.min], then the width of the [Row] is the sum
    ///    of widths of the children (subject to the incoming constraints).
    /// 6. Determine the position for each child according to the
    ///    [mainAxisAlignment] and the [crossAxisAlignment]. For example, if the
    ///    [mainAxisAlignment] is [MainAxisAlignment.spaceBetween], any horizontal
    ///    space that has not been allocated to children is divided evenly and
    ///    placed between the children.
    ///
    /// See also:
    ///
    ///  * [Column], for a vertical equivalent.
    ///  * [Flex], if you don't know in advance if you want a horizontal or vertical
    ///    arrangement.
    ///  * [Expanded], to indicate children that should take all the remaining room.
    ///  * [Flexible], to indicate children that should share the remaining room but
    ///    that may by sized smaller (leaving some remaining room unused).
    ///  * [Spacer], a widget that takes up space proportional to it's flex value.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Row : FlutterSDK.Widgets.Basic.Flex
    {
        #region constructors
        public Row(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), TextBaseline textBaseline = default(TextBaseline), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(children: children, key: key, direction: Axis.Horizontal, mainAxisAlignment: mainAxisAlignment, mainAxisSize: mainAxisSize, crossAxisAlignment: crossAxisAlignment, textDirection: textDirection, verticalDirection: verticalDirection, textBaseline: textBaseline)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A widget that displays its children in a vertical array.
    ///
    /// To cause a child to expand to fill the available vertical space, wrap the
    /// child in an [Expanded] widget.
    ///
    /// The [Column] widget does not scroll (and in general it is considered an error
    /// to have more children in a [Column] than will fit in the available room). If
    /// you have a line of widgets and want them to be able to scroll if there is
    /// insufficient room, consider using a [ListView].
    ///
    /// For a horizontal variant, see [Row].
    ///
    /// If you only have one child, then consider using [Align] or [Center] to
    /// position the child.
    ///
    /// {@tool snippet}
    ///
    /// This example uses a [Column] to arrange three widgets vertically, the last
    /// being made to fill all the remaining space.
    ///
    /// ![Using the Column in this way creates two short lines of text with a large Flutter underneath.](https://flutter.github.io/assets-for-api-docs/assets/widgets/column.png)
    ///
    /// ```dart
    /// Column(
    ///   children: <Widget>[
    ///     Text('Deliver features faster'),
    ///     Text('Craft beautiful UIs'),
    ///     Expanded(
    ///       child: FittedBox(
    ///         fit: BoxFit.contain, // otherwise the logo will be tiny
    ///         child: const FlutterLogo(),
    ///       ),
    ///     ),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// In the sample above, the text and the logo are centered on each line. In the
    /// following example, the [crossAxisAlignment] is set to
    /// [CrossAxisAlignment.start], so that the children are left-aligned. The
    /// [mainAxisSize] is set to [MainAxisSize.min], so that the column shrinks to
    /// fit the children.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/widgets/column_properties.png)
    ///
    /// ```dart
    /// Column(
    ///   crossAxisAlignment: CrossAxisAlignment.start,
    ///   mainAxisSize: MainAxisSize.min,
    ///   children: <Widget>[
    ///     Text('We move under cover and we move as one'),
    ///     Text('Through the night, we have one shot to live another day'),
    ///     Text('We cannot let a stray gunshot give us away'),
    ///     Text('We will fight up close, seize the moment and stay in it'),
    ///     Text('It’s either that or meet the business end of a bayonet'),
    ///     Text('The code word is ‘Rochambeau,’ dig me?'),
    ///     Text('Rochambeau!', style: DefaultTextStyle.of(context).style.apply(fontSizeFactor: 2.0)),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// ## Troubleshooting
    ///
    /// ### When the incoming vertical constraints are unbounded
    ///
    /// When a [Column] has one or more [Expanded] or [Flexible] children, and is
    /// placed in another [Column], or in a [ListView], or in some other context
    /// that does not provide a maximum height constraint for the [Column], you will
    /// get an exception at runtime saying that there are children with non-zero
    /// flex but the vertical constraints are unbounded.
    ///
    /// The problem, as described in the details that accompany that exception, is
    /// that using [Flexible] or [Expanded] means that the remaining space after
    /// laying out all the other children must be shared equally, but if the
    /// incoming vertical constraints are unbounded, there is infinite remaining
    /// space.
    ///
    /// The key to solving this problem is usually to determine why the [Column] is
    /// receiving unbounded vertical constraints.
    ///
    /// One common reason for this to happen is that the [Column] has been placed in
    /// another [Column] (without using [Expanded] or [Flexible] around the inner
    /// nested [Column]). When a [Column] lays out its non-flex children (those that
    /// have neither [Expanded] or [Flexible] around them), it gives them unbounded
    /// constraints so that they can determine their own dimensions (passing
    /// unbounded constraints usually signals to the child that it should
    /// shrink-wrap its contents). The solution in this case is typically to just
    /// wrap the inner column in an [Expanded] to indicate that it should take the
    /// remaining space of the outer column, rather than being allowed to take any
    /// amount of room it desires.
    ///
    /// Another reason for this message to be displayed is nesting a [Column] inside
    /// a [ListView] or other vertical scrollable. In that scenario, there really is
    /// infinite vertical space (the whole point of a vertical scrolling list is to
    /// allow infinite space vertically). In such scenarios, it is usually worth
    /// examining why the inner [Column] should have an [Expanded] or [Flexible]
    /// child: what size should the inner children really be? The solution in this
    /// case is typically to remove the [Expanded] or [Flexible] widgets from around
    /// the inner children.
    ///
    /// For more discussion about constraints, see [BoxConstraints].
    ///
    /// ### The yellow and black striped banner
    ///
    /// When the contents of a [Column] exceed the amount of space available, the
    /// [Column] overflows, and the contents are clipped. In debug mode, a yellow
    /// and black striped bar is rendered at the overflowing edge to indicate the
    /// problem, and a message is printed below the [Column] saying how much
    /// overflow was detected.
    ///
    /// The usual solution is to use a [ListView] rather than a [Column], to enable
    /// the contents to scroll when vertical space is limited.
    ///
    /// ## Layout algorithm
    ///
    /// _This section describes how a [Column] is rendered by the framework._
    /// _See [BoxConstraints] for an introduction to box layout models._
    ///
    /// Layout for a [Column] proceeds in six steps:
    ///
    /// 1. Layout each child a null or zero flex factor (e.g., those that are not
    ///    [Expanded]) with unbounded vertical constraints and the incoming
    ///    horizontal constraints. If the [crossAxisAlignment] is
    ///    [CrossAxisAlignment.stretch], instead use tight horizontal constraints
    ///    that match the incoming max width.
    /// 2. Divide the remaining vertical space among the children with non-zero
    ///    flex factors (e.g., those that are [Expanded]) according to their flex
    ///    factor. For example, a child with a flex factor of 2.0 will receive twice
    ///    the amount of vertical space as a child with a flex factor of 1.0.
    /// 3. Layout each of the remaining children with the same horizontal
    ///    constraints as in step 1, but instead of using unbounded vertical
    ///    constraints, use vertical constraints based on the amount of space
    ///    allocated in step 2. Children with [Flexible.fit] properties that are
    ///    [FlexFit.tight] are given tight constraints (i.e., forced to fill the
    ///    allocated space), and children with [Flexible.fit] properties that are
    ///    [FlexFit.loose] are given loose constraints (i.e., not forced to fill the
    ///    allocated space).
    /// 4. The width of the [Column] is the maximum width of the children (which
    ///    will always satisfy the incoming horizontal constraints).
    /// 5. The height of the [Column] is determined by the [mainAxisSize] property.
    ///    If the [mainAxisSize] property is [MainAxisSize.max], then the height of
    ///    the [Column] is the max height of the incoming constraints. If the
    ///    [mainAxisSize] property is [MainAxisSize.min], then the height of the
    ///    [Column] is the sum of heights of the children (subject to the incoming
    ///    constraints).
    /// 6. Determine the position for each child according to the
    ///    [mainAxisAlignment] and the [crossAxisAlignment]. For example, if the
    ///    [mainAxisAlignment] is [MainAxisAlignment.spaceBetween], any vertical
    ///    space that has not been allocated to children is divided evenly and
    ///    placed between the children.
    ///
    /// See also:
    ///
    ///  * [Row], for a horizontal equivalent.
    ///  * [Flex], if you don't know in advance if you want a horizontal or vertical
    ///    arrangement.
    ///  * [Expanded], to indicate children that should take all the remaining room.
    ///  * [Flexible], to indicate children that should share the remaining room but
    ///    that may size smaller (leaving some remaining room unused).
    ///  * [SingleChildScrollView], whose documentation discusses some ways to
    ///    use a [Column] inside a scrolling container.
    ///  * [Spacer], a widget that takes up space proportional to it's flex value.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Column : FlutterSDK.Widgets.Basic.Flex
    {
        #region constructors
        public Column(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), TextBaseline textBaseline = default(TextBaseline), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(children: children, key: key, direction: Axis.Vertical, mainAxisAlignment: mainAxisAlignment, mainAxisSize: mainAxisSize, crossAxisAlignment: crossAxisAlignment, textDirection: textDirection, verticalDirection: verticalDirection, textBaseline: textBaseline)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A widget that controls how a child of a [Row], [Column], or [Flex] flexes.
    ///
    /// Using a [Flexible] widget gives a child of a [Row], [Column], or [Flex]
    /// the flexibility to expand to fill the available space in the main axis
    /// (e.g., horizontally for a [Row] or vertically for a [Column]), but, unlike
    /// [Expanded], [Flexible] does not require the child to fill the available
    /// space.
    ///
    /// A [Flexible] widget must be a descendant of a [Row], [Column], or [Flex],
    /// and the path from the [Flexible] widget to its enclosing [Row], [Column], or
    /// [Flex] must contain only [StatelessWidget]s or [StatefulWidget]s (not other
    /// kinds of widgets, like [RenderObjectWidget]s).
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=CI7x0mAZiY0}
    ///
    /// See also:
    ///
    ///  * [Expanded], which forces the child to expand to fill the available space.
    ///  * [Spacer], a widget that takes up space proportional to its flex value.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Flexible : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.Flex.FlexParentData>
    {
        #region constructors
        public Flexible(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int flex = 1, FlutterSDK.Rendering.Flex.FlexFit fit = default(FlutterSDK.Rendering.Flex.FlexFit), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Flex = flex;
            this.Fit = fit; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int Flex { get; set; }
        public virtual FlutterSDK.Rendering.Flex.FlexFit Fit { get; set; }
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that expands a child of a [Row], [Column], or [Flex]
    /// so that the child fills the available space.
    ///
    /// Using an [Expanded] widget makes a child of a [Row], [Column], or [Flex]
    /// expand to fill the available space along the main axis (e.g., horizontally for
    /// a [Row] or vertically for a [Column]). If multiple children are expanded,
    /// the available space is divided among them according to the [flex] factor.
    ///
    /// An [Expanded] widget must be a descendant of a [Row], [Column], or [Flex],
    /// and the path from the [Expanded] widget to its enclosing [Row], [Column], or
    /// [Flex] must contain only [StatelessWidget]s or [StatefulWidget]s (not other
    /// kinds of widgets, like [RenderObjectWidget]s).
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=_rnZaagadyo}
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// This example shows how to use an [Expanded] widget in a [Column] so that
    /// it's middle child, a [Container] here, expands to fill the space.
    ///
    /// ![This results in two thin blue boxes with a larger amber box in between.](https://flutter.github.io/assets-for-api-docs/assets/widgets/expanded_column.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     appBar: AppBar(
    ///       title: Text('Expanded Column Sample'),
    ///     ),
    ///     body: Center(
    ///        child: Column(
    ///         children: <Widget>[
    ///           Container(
    ///             color: Colors.blue,
    ///             height: 100,
    ///             width: 100,
    ///           ),
    ///           Expanded(
    ///             child: Container(
    ///               color: Colors.amber,
    ///               width: 100,
    ///             ),
    ///           ),
    ///           Container(
    ///             color: Colors.blue,
    ///             height: 100,
    ///             width: 100,
    ///           ),
    ///         ],
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateless_widget_material}
    /// This example shows how to use an [Expanded] widget in a [Row] with multiple
    /// children expanded, utilizing the [flex] factor to prioritize available space.
    ///
    /// ![This results in a wide amber box, followed by a thin blue box, with a medium width amber box at the end.](https://flutter.github.io/assets-for-api-docs/assets/widgets/expanded_row.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Scaffold(
    ///     appBar: AppBar(
    ///       title: Text('Expanded Row Sample'),
    ///     ),
    ///     body: Center(
    ///       child: Row(
    ///         children: <Widget>[
    ///           Expanded(
    ///             flex: 2,
    ///             child: Container(
    ///               color: Colors.amber,
    ///               height: 100,
    ///             ),
    ///           ),
    ///           Container(
    ///             color: Colors.blue,
    ///             height: 100,
    ///             width: 50,
    ///           ),
    ///           Expanded(
    ///             flex: 1,
    ///             child: Container(
    ///               color: Colors.amber,
    ///               height: 100,
    ///             ),
    ///           ),
    ///         ],
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Flexible], which does not force the child to fill the available space.
    ///  * [Spacer], a widget that takes up space proportional to it's flex value.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Expanded : FlutterSDK.Widgets.Basic.Flexible
    {
        #region constructors
        public Expanded(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int flex = 1, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, flex: flex, fit: FlexFit.Tight, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    /// <Summary>
    /// A widget that displays its children in multiple horizontal or vertical runs.
    ///
    /// A [Wrap] lays out each child and attempts to place the child adjacent to the
    /// previous child in the main axis, given by [direction], leaving [spacing]
    /// space in between. If there is not enough space to fit the child, [Wrap]
    /// creates a new _run_ adjacent to the existing children in the cross axis.
    ///
    /// After all the children have been allocated to runs, the children within the
    /// runs are positioned according to the [alignment] in the main axis and
    /// according to the [crossAxisAlignment] in the cross axis.
    ///
    /// The runs themselves are then positioned in the cross axis according to the
    /// [runSpacing] and [runAlignment].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=z5iw2SeFx2M}
    ///
    /// {@tool snippet}
    ///
    /// This example renders some [Chip]s representing four contacts in a [Wrap] so
    /// that they flow across lines as necessary.
    ///
    /// ```dart
    /// Wrap(
    ///   spacing: 8.0, // gap between adjacent chips
    ///   runSpacing: 4.0, // gap between lines
    ///   children: <Widget>[
    ///     Chip(
    ///       avatar: CircleAvatar(backgroundColor: Colors.blue.shade900, child: Text('AH')),
    ///       label: Text('Hamilton'),
    ///     ),
    ///     Chip(
    ///       avatar: CircleAvatar(backgroundColor: Colors.blue.shade900, child: Text('ML')),
    ///       label: Text('Lafayette'),
    ///     ),
    ///     Chip(
    ///       avatar: CircleAvatar(backgroundColor: Colors.blue.shade900, child: Text('HM')),
    ///       label: Text('Mulligan'),
    ///     ),
    ///     Chip(
    ///       avatar: CircleAvatar(backgroundColor: Colors.blue.shade900, child: Text('JL')),
    ///       label: Text('Laurens'),
    ///     ),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Row], which places children in one line, and gives control over their
    ///    alignment and spacing.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    /// </Summary>
    public class Wrap : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public Wrap(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis direction = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Wrap.WrapAlignment alignment = default(FlutterSDK.Rendering.Wrap.WrapAlignment), double spacing = 0.0, FlutterSDK.Rendering.Wrap.WrapAlignment runAlignment = default(FlutterSDK.Rendering.Wrap.WrapAlignment), double runSpacing = 0.0, FlutterSDK.Rendering.Wrap.WrapCrossAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Wrap.WrapCrossAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.Direction = direction;
            this.Alignment = alignment;
            this.Spacing = spacing;
            this.RunAlignment = runAlignment;
            this.RunSpacing = runSpacing;
            this.CrossAxisAlignment = crossAxisAlignment;
            this.TextDirection = textDirection;
            this.VerticalDirection = verticalDirection; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Basictypes.Axis Direction { get; set; }
        public virtual FlutterSDK.Rendering.Wrap.WrapAlignment Alignment { get; set; }
        public virtual double Spacing { get; set; }
        public virtual FlutterSDK.Rendering.Wrap.WrapAlignment RunAlignment { get; set; }
        public virtual double RunSpacing { get; set; }
        public virtual FlutterSDK.Rendering.Wrap.WrapCrossAlignment CrossAxisAlignment { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.VerticalDirection VerticalDirection { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Wrap.RenderWrap CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Wrap.RenderWrap renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that sizes and positions children efficiently, according to the
    /// logic in a [FlowDelegate].
    ///
    /// Flow layouts are optimized for repositioning children using transformation
    /// matrices.
    ///
    /// The flow container is sized independently from the children by the
    /// [FlowDelegate.getSize] function of the delegate. The children are then sized
    /// independently given the constraints from the
    /// [FlowDelegate.getConstraintsForChild] function.
    ///
    /// Rather than positioning the children during layout, the children are
    /// positioned using transformation matrices during the paint phase using the
    /// matrices from the [FlowDelegate.paintChildren] function. The children can be
    /// repositioned efficiently by simply repainting the flow, which happens
    /// without the children being laid out again (contrast this with a [Stack],
    /// which does the sizing and positioning together during layout).
    ///
    /// The most efficient way to trigger a repaint of the flow is to supply an
    /// animation to the constructor of the [FlowDelegate]. The flow will listen to
    /// this animation and repaint whenever the animation ticks, avoiding both the
    /// build and layout phases of the pipeline.
    ///
    /// See also:
    ///
    ///  * [Wrap], which provides the layout model that some other frameworks call
    ///    "flow", and is otherwise unrelated to [Flow].
    ///  * [FlowDelegate], which controls the visual presentation of the children.
    ///  * [Stack], which arranges children relative to the edges of the container.
    ///  * [CustomSingleChildLayout], which uses a delegate to control the layout of
    ///    a single child.
    ///  * [CustomMultiChildLayout], which uses a delegate to position multiple
    ///    children.
    ///  * The [catalog of layout widgets](https://flutter.dev/widgets/layout/).
    ///
    ///
    /// {@tool dartpad --template=freeform}
    ///
    /// This example uses the [Flow] widget to create a menu that opens and closes
    /// as it is interacted with, shown above. The color of the button in the menu
    /// changes to indicate which one has been selected.
    ///
    /// ```dart main
    /// import 'package:flutter/material.dart';
    ///
    /// void main() => runApp(FlowApp());
    ///
    /// class FlowApp extends StatelessWidget {
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return MaterialApp(
    ///       home: Scaffold(
    ///         appBar: AppBar(
    ///           title: const Text('Flow Example'),
    ///         ),
    ///         body: FlowMenu(),
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// class FlowMenu extends StatefulWidget {
    ///   @override
    ///   _FlowMenuState createState() => _FlowMenuState();
    /// }
    ///
    /// class _FlowMenuState extends State<FlowMenu> with SingleTickerProviderStateMixin {
    ///   AnimationController menuAnimation;
    ///   IconData lastTapped = Icons.notifications;
    ///   final List<IconData> menuItems = <IconData>[
    ///     Icons.home,
    ///     Icons.new_releases,
    ///     Icons.notifications,
    ///     Icons.settings,
    ///     Icons.menu,
    ///   ];
    ///
    ///   void _updateMenu(IconData icon) {
    ///     if (icon != Icons.menu)
    ///       setState(() => lastTapped = icon);
    ///   }
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     menuAnimation = AnimationController(
    ///       duration: const Duration(milliseconds: 250),
    ///       vsync: this,
    ///     );
    ///   }
    ///
    ///   Widget flowMenuItem(IconData icon) {
    ///     final double buttonDiameter = MediaQuery.of(context).size.width / menuItems.length;
    ///     return Padding(
    ///       padding: const EdgeInsets.symmetric(vertical: 8.0),
    ///       child: RawMaterialButton(
    ///         fillColor: lastTapped == icon ? Colors.amber[700] : Colors.blue,
    ///         splashColor: Colors.amber[100],
    ///         shape: CircleBorder(),
    ///         constraints: BoxConstraints.tight(Size(buttonDiameter, buttonDiameter)),
    ///         onPressed: () {
    ///           _updateMenu(icon);
    ///           menuAnimation.status == AnimationStatus.completed
    ///             ? menuAnimation.reverse()
    ///             : menuAnimation.forward();
    ///         },
    ///         child: Icon(
    ///           icon,
    ///           color: Colors.white,
    ///           size: 45.0,
    ///         ),
    ///       ),
    ///     );
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Container(
    ///       child: Flow(
    ///         delegate: FlowMenuDelegate(menuAnimation: menuAnimation),
    ///         children: menuItems.map<Widget>((IconData icon) => flowMenuItem(icon)).toList(),
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// class FlowMenuDelegate extends FlowDelegate {
    ///   FlowMenuDelegate({this.menuAnimation}) : super(repaint: menuAnimation);
    ///
    ///   final Animation<double> menuAnimation;
    ///
    ///   @override
    ///   bool shouldRepaint(FlowMenuDelegate oldDelegate) {
    ///     return menuAnimation != oldDelegate.menuAnimation;
    ///   }
    ///
    ///   @override
    ///   void paintChildren(FlowPaintingContext context) {
    ///     double dx = 0.0;
    ///     for (int i = 0; i < context.childCount; ++i) {
    ///       dx = context.getChildSize(i).width * i;
    ///       context.paintChild(
    ///         i,
    ///         transform: Matrix4.translationValues(
    ///           dx * menuAnimation.value,
    ///           0,
    ///           0,
    ///         ),
    ///       );
    ///     }
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// </Summary>
    public class Flow : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public Flow(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Flow.FlowDelegate @delegate = default(FlutterSDK.Rendering.Flow.FlowDelegate), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: BasicDefaultClass.RepaintBoundary.WrapAll(children))
        {
            this.@delegate = @delegate; throw new NotImplementedException();
        }
        public static Flow Unwrapped(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Flow.FlowDelegate @delegate = default(FlutterSDK.Rendering.Flow.FlowDelegate), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        {
            var instance = new Flow(key: key, children: children); instance.@delegate = @delegate; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Flow.FlowDelegate @delegate { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Flow.RenderFlow CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Flow.RenderFlow renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A paragraph of rich text.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=rykDVh-QFfw}
    ///
    /// The [RichText] widget displays text that uses multiple different styles. The
    /// text to display is described using a tree of [TextSpan] objects, each of
    /// which has an associated style that is used for that subtree. The text might
    /// break across multiple lines or might all be displayed on the same line
    /// depending on the layout constraints.
    ///
    /// Text displayed in a [RichText] widget must be explicitly styled. When
    /// picking which style to use, consider using [DefaultTextStyle.of] the current
    /// [BuildContext] to provide defaults. For more details on how to style text in
    /// a [RichText] widget, see the documentation for [TextStyle].
    ///
    /// Consider using the [Text] widget to integrate with the [DefaultTextStyle]
    /// automatically. When all the text uses the same style, the default constructor
    /// is less verbose. The [Text.rich] constructor allows you to style multiple
    /// spans with the default text style while still allowing specified styles per
    /// span.
    ///
    /// {@tool snippet}
    ///
    /// This sample demonstrates how to mix and match text with different text
    /// styles using the [RichText] Widget. It displays the text "Hello bold world,"
    /// emphasizing the word "bold" using a bold font weight.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/widgets/rich_text.png)
    ///
    /// ```dart
    /// RichText(
    ///   text: TextSpan(
    ///     text: 'Hello ',
    ///     style: DefaultTextStyle.of(context).style,
    ///     children: <TextSpan>[
    ///       TextSpan(text: 'bold', style: TextStyle(fontWeight: FontWeight.bold)),
    ///       TextSpan(text: ' world!'),
    ///     ],
    ///   ),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [TextStyle], which discusses how to style text.
    ///  * [TextSpan], which is used to describe the text in a paragraph.
    ///  * [Text], which automatically applies the ambient styles described by a
    ///    [DefaultTextStyle] to a single string.
    ///  * [Text.rich], a const text widget that provides similar functionality
    ///    as [RichText]. [Text.rich] will inherit [TextStyle] from [DefaultTextStyle].
    /// </Summary>
    public class RichText : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public RichText(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Inlinespan.InlineSpan text = default(FlutterSDK.Painting.Inlinespan.InlineSpan), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), bool softWrap = true, FlutterSDK.Rendering.Paragraph.TextOverflow overflow = default(FlutterSDK.Rendering.Paragraph.TextOverflow), double textScaleFactor = 1.0, int maxLines = default(int), Locale locale = default(Locale), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), TextHeightBehavior textHeightBehavior = default(TextHeightBehavior))
        : base(key: key, children: _ExtractChildren(text))
        {
            this.Text = text;
            this.TextAlign = textAlign;
            this.TextDirection = textDirection;
            this.SoftWrap = softWrap;
            this.Overflow = overflow;
            this.TextScaleFactor = textScaleFactor;
            this.MaxLines = maxLines;
            this.Locale = locale;
            this.StrutStyle = strutStyle;
            this.TextWidthBasis = textWidthBasis;
            this.TextHeightBehavior = textHeightBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Inlinespan.InlineSpan Text { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual bool SoftWrap { get; set; }
        public virtual FlutterSDK.Rendering.Paragraph.TextOverflow Overflow { get; set; }
        public virtual double TextScaleFactor { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual Locale Locale { get; set; }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get; set; }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        public virtual TextHeightBehavior TextHeightBehavior { get; set; }
        #endregion

        #region methods

        private List<FlutterSDK.Widgets.Framework.Widget> _ExtractChildren(FlutterSDK.Painting.Inlinespan.InlineSpan span) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Paragraph.RenderParagraph CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Paragraph.RenderParagraph renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that displays a [dart:ui.Image] directly.
    ///
    /// The image is painted using [paintImage], which describes the meanings of the
    /// various fields on this class in more detail.
    ///
    /// This widget is rarely used directly. Instead, consider using [Image].
    /// </Summary>
    public class RawImage : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public RawImage(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), SKImage image = default(SKImage), double width = default(double), double height = default(double), double scale = 1.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool invertColors = false, FilterQuality filterQuality = default(FilterQuality))
        : base(key: key)
        {
            this.Image = image;
            this.Width = width;
            this.Height = height;
            this.Scale = scale;
            this.Color = color;
            this.ColorBlendMode = colorBlendMode;
            this.Fit = fit;
            this.Alignment = alignment;
            this.Repeat = repeat;
            this.CenterSlice = centerSlice;
            this.MatchTextDirection = matchTextDirection;
            this.InvertColors = invertColors;
            this.FilterQuality = filterQuality; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual SKImage Image { get; set; }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual double Scale { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FilterQuality FilterQuality { get; set; }
        public virtual FlutterBinding.UI.BlendMode ColorBlendMode { get; set; }
        public virtual FlutterSDK.Painting.Boxfit.BoxFit Fit { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual FlutterSDK.Painting.Decorationimage.ImageRepeat Repeat { get; set; }
        public virtual FlutterBinding.UI.Rect CenterSlice { get; set; }
        public virtual bool MatchTextDirection { get; set; }
        public virtual bool InvertColors { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Image.RenderImage CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Image.RenderImage renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that determines the default asset bundle for its descendants.
    ///
    /// For example, used by [Image] to determine which bundle to use for
    /// [AssetImage]s if no bundle is specified explicitly.
    ///
    /// {@tool snippet}
    ///
    /// This can be used in tests to override what the current asset bundle is, thus
    /// allowing specific resources to be injected into the widget under test.
    ///
    /// For example, a test could create a test asset bundle like this:
    ///
    /// ```dart
    /// class TestAssetBundle extends CachingAssetBundle {
    ///   @override
    ///   Future<ByteData> load(String key) async {
    ///     if (key == 'resources/test')
    ///       return ByteData.view(Uint8List.fromList(utf8.encode('Hello World!')).buffer);
    ///     return null;
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// ...then wrap the widget under test with a [DefaultAssetBundle] using this
    /// bundle implementation:
    ///
    /// ```dart
    /// await tester.pumpWidget(
    ///   MaterialApp(
    ///     home: DefaultAssetBundle(
    ///       bundle: TestAssetBundle(),
    ///       child: TestWidget(),
    ///     ),
    ///   ),
    /// );
    /// ```
    /// {@end-tool}
    ///
    /// Assuming that `TestWidget` uses [DefaultAssetBundle.of] to obtain its
    /// [AssetBundle], it will now see the [TestAssetBundle]'s "Hello World!" data
    /// when requesting the "resources/test" asset.
    ///
    /// See also:
    ///
    ///  * [AssetBundle], the interface for asset bundles.
    ///  * [rootBundle], the default default asset bundle.
    /// </Summary>
    public class DefaultAssetBundle : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public DefaultAssetBundle(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Bundle = bundle; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Services.Assetbundle.AssetBundle Bundle { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// The bundle from the closest instance of this class that encloses
        /// the given context.
        ///
        /// If there is no [DefaultAssetBundle] ancestor widget in the tree
        /// at the given context, then this will return the [rootBundle].
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// AssetBundle bundle = DefaultAssetBundle.of(context);
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Services.Assetbundle.AssetBundle Of(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Basic.DefaultAssetBundle oldWidget) { throw new NotImplementedException(); }
        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// An adapter for placing a specific [RenderBox] in the widget tree.
    ///
    /// A given render object can be placed at most once in the widget tree. This
    /// widget enforces that restriction by keying itself using a [GlobalObjectKey]
    /// for the given render object.
    /// </Summary>
    public class WidgetToRenderBoxAdapter : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public WidgetToRenderBoxAdapter(FlutterSDK.Rendering.Box.RenderBox renderBox = default(FlutterSDK.Rendering.Box.RenderBox), VoidCallback onBuild = default(VoidCallback))
        : base(key: new GlobalObjectKey(renderBox))
        {
            this.RenderBox = renderBox;
            this.OnBuild = onBuild; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Box.RenderBox RenderBox { get; set; }
        public virtual VoidCallback OnBuild { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Box.RenderBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Box.RenderBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that calls callbacks in response to common pointer events.
    ///
    /// It listens to events that can construct gestures, such as when the
    /// pointer is pressed, moved, then released or canceled.
    ///
    /// It does not listen to events that are exclusive to mouse, such as when the
    /// mouse enters, exits or hovers a region without pressing any buttons. For
    /// these events, use [MouseRegion].
    ///
    /// Rather than listening for raw pointer events, consider listening for
    /// higher-level gestures using [GestureDetector].
    ///
    /// ## Layout behavior
    ///
    /// _See [BoxConstraints] for an introduction to box layout models._
    ///
    /// If it has a child, this widget defers to the child for sizing behavior. If
    /// it does not have a child, it grows to fit the parent instead.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center}
    /// This example makes a [Container] react to being touched, showing a count of
    /// the number of pointer downs and ups.
    ///
    /// ```dart imports
    /// import 'package:flutter/widgets.dart';
    /// ```
    ///
    /// ```dart
    /// int _downCounter = 0;
    /// int _upCounter = 0;
    /// double x = 0.0;
    /// double y = 0.0;
    ///
    /// void _incrementDown(PointerEvent details) {
    ///   _updateLocation(details);
    ///   setState(() {
    ///     _downCounter++;
    ///   });
    /// }
    /// void _incrementUp(PointerEvent details) {
    ///   _updateLocation(details);
    ///   setState(() {
    ///     _upCounter++;
    ///   });
    /// }
    /// void _updateLocation(PointerEvent details) {
    ///   setState(() {
    ///     x = details.position.dx;
    ///     y = details.position.dy;
    ///   });
    /// }
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return ConstrainedBox(
    ///     constraints: new BoxConstraints.tight(Size(300.0, 200.0)),
    ///     child: Listener(
    ///       onPointerDown: _incrementDown,
    ///       onPointerMove: _updateLocation,
    ///       onPointerUp: _incrementUp,
    ///       child: Container(
    ///         color: Colors.lightBlueAccent,
    ///         child: Column(
    ///           mainAxisAlignment: MainAxisAlignment.center,
    ///           children: <Widget>[
    ///             Text('You have pressed or released in this area this many times:'),
    ///             Text(
    ///               '$_downCounter presses\n$_upCounter releases',
    ///               style: Theme.of(context).textTheme.headline4,
    ///             ),
    ///             Text(
    ///               'The cursor is here: (${x.toStringAsFixed(2)}, ${y.toStringAsFixed(2)})',
    ///             ),
    ///           ],
    ///         ),
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class Listener : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public Listener(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.PointerDownEventListener onPointerDown = default(FlutterSDK.Rendering.Proxybox.PointerDownEventListener), FlutterSDK.Rendering.Proxybox.PointerMoveEventListener onPointerMove = default(FlutterSDK.Rendering.Proxybox.PointerMoveEventListener), FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener onPointerEnter = default(FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener), FlutterSDK.Rendering.Mousetracking.PointerExitEventListener onPointerExit = default(FlutterSDK.Rendering.Mousetracking.PointerExitEventListener), FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener onPointerHover = default(FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener), FlutterSDK.Rendering.Proxybox.PointerUpEventListener onPointerUp = default(FlutterSDK.Rendering.Proxybox.PointerUpEventListener), FlutterSDK.Rendering.Proxybox.PointerCancelEventListener onPointerCancel = default(FlutterSDK.Rendering.Proxybox.PointerCancelEventListener), FlutterSDK.Rendering.Proxybox.PointerSignalEventListener onPointerSignal = default(FlutterSDK.Rendering.Proxybox.PointerSignalEventListener), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.OnPointerDown = onPointerDown;
            this.OnPointerMove = onPointerMove;
            this.OnPointerEnter = onPointerEnter;
            this.OnPointerExit = onPointerExit;
            this.OnPointerHover = onPointerHover;
            this.OnPointerUp = onPointerUp;
            this.OnPointerCancel = onPointerCancel;
            this.OnPointerSignal = onPointerSignal;
            this.Behavior = behavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.PointerDownEventListener OnPointerDown { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerMoveEventListener OnPointerMove { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener OnPointerEnter { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener OnPointerHover { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener OnPointerExit { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerUpEventListener OnPointerUp { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerCancelEventListener OnPointerCancel { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerSignalEventListener OnPointerSignal { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _PointerListener : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public _PointerListener(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.PointerDownEventListener onPointerDown = default(FlutterSDK.Rendering.Proxybox.PointerDownEventListener), FlutterSDK.Rendering.Proxybox.PointerMoveEventListener onPointerMove = default(FlutterSDK.Rendering.Proxybox.PointerMoveEventListener), FlutterSDK.Rendering.Proxybox.PointerUpEventListener onPointerUp = default(FlutterSDK.Rendering.Proxybox.PointerUpEventListener), FlutterSDK.Rendering.Proxybox.PointerCancelEventListener onPointerCancel = default(FlutterSDK.Rendering.Proxybox.PointerCancelEventListener), FlutterSDK.Rendering.Proxybox.PointerSignalEventListener onPointerSignal = default(FlutterSDK.Rendering.Proxybox.PointerSignalEventListener), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.OnPointerDown = onPointerDown;
            this.OnPointerMove = onPointerMove;
            this.OnPointerUp = onPointerUp;
            this.OnPointerCancel = onPointerCancel;
            this.OnPointerSignal = onPointerSignal;
            this.Behavior = behavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.PointerDownEventListener OnPointerDown { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerMoveEventListener OnPointerMove { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerUpEventListener OnPointerUp { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerCancelEventListener OnPointerCancel { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerSignalEventListener OnPointerSignal { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderPointerListener CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderPointerListener renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that tracks the movement of mice, even when no button is pressed.
    ///
    /// It does not listen to events that can construct gestures, such as when the
    /// pointer is pressed, moved, then released or canceled. For these events,
    /// use [Listener], or more preferably, [GestureDetector].
    ///
    /// ## Layout behavior
    ///
    /// _See [BoxConstraints] for an introduction to box layout models._
    ///
    /// If it has a child, this widget defers to the child for sizing behavior. If
    /// it does not have a child, it grows to fit the parent instead.
    ///
    /// {@tool dartpad --template=stateful_widget_scaffold_center}
    /// This example makes a [Container] react to being entered by a mouse
    /// pointer, showing a count of the number of entries and exits.
    ///
    /// ```dart imports
    /// import 'package:flutter/widgets.dart';
    /// ```
    ///
    /// ```dart
    /// int _enterCounter = 0;
    /// int _exitCounter = 0;
    /// double x = 0.0;
    /// double y = 0.0;
    ///
    /// void _incrementEnter(PointerEvent details) {
    ///   setState(() {
    ///     _enterCounter++;
    ///   });
    /// }
    /// void _incrementExit(PointerEvent details) {
    ///   setState(() {
    ///     _exitCounter++;
    ///   });
    /// }
    /// void _updateLocation(PointerEvent details) {
    ///   setState(() {
    ///     x = details.position.dx;
    ///     y = details.position.dy;
    ///   });
    /// }
    ///
    /// @override
    /// Widget build(BuildContext context) {
    ///   return ConstrainedBox(
    ///     constraints: new BoxConstraints.tight(Size(300.0, 200.0)),
    ///     child: MouseRegion(
    ///       onEnter: _incrementEnter,
    ///       onHover: _updateLocation,
    ///       onExit: _incrementExit,
    ///       child: Container(
    ///         color: Colors.lightBlueAccent,
    ///         child: Column(
    ///           mainAxisAlignment: MainAxisAlignment.center,
    ///           children: <Widget>[
    ///             Text('You have entered or exited this box this many times:'),
    ///             Text(
    ///               '$_enterCounter Entries\n$_exitCounter Exits',
    ///               style: Theme.of(context).textTheme.headline4,
    ///             ),
    ///             Text(
    ///               'The cursor is here: (${x.toStringAsFixed(2)}, ${y.toStringAsFixed(2)})',
    ///             ),
    ///           ],
    ///         ),
    ///       ),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Listener], a similar widget that tracks pointer events when the pointer
    ///    have buttons pressed.
    /// </Summary>
    public class MouseRegion : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public MouseRegion(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener onEnter = default(FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener), FlutterSDK.Rendering.Mousetracking.PointerExitEventListener onExit = default(FlutterSDK.Rendering.Mousetracking.PointerExitEventListener), FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener onHover = default(FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener), bool opaque = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.OnEnter = onEnter;
            this.OnExit = onExit;
            this.OnHover = onHover;
            this.Opaque = opaque;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener OnEnter { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener OnHover { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener OnExit { get; set; }
        public virtual bool Opaque { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Basic._MouseRegionState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _MouseRegionState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Basic.MouseRegion>
    {
        #region constructors
        public _MouseRegionState()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual void HandleExit(FlutterSDK.Gestures.Events.PointerExitEvent @event) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener GetHandleExit() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RawMouseRegion : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public _RawMouseRegion(FlutterSDK.Widgets.Basic._MouseRegionState owner)
        : base(child: owner.Widget.Child)
        {
            this.Owner = owner; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Basic._MouseRegionState Owner { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderMouseRegion CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderMouseRegion renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that creates a separate display list for its child.
    ///
    /// This widget creates a separate display list for its child, which
    /// can improve performance if the subtree repaints at different times than
    /// the surrounding parts of the tree.
    ///
    /// This is useful since [RenderObject.paint] may be triggered even if its
    /// associated [Widget] instances did not change or rebuild. A [RenderObject]
    /// will repaint whenever any [RenderObject] that shares the same [Layer] is
    /// marked as being dirty and needing paint (see [RenderObject.markNeedsPaint]),
    /// such as when an ancestor scrolls or when an ancestor or descendant animates.
    ///
    /// Containing [RenderObject.paint] to parts of the render subtree that are
    /// actually visually changing using [RepaintBoundary] explicitly or implicitly
    /// is therefore critical to minimizing redundant work and improving the app's
    /// performance.
    ///
    /// When a [RenderObject] is flagged as needing to paint via
    /// [RenderObject.markNeedsPaint], the nearest ancestor [RenderObject] with
    /// [RenderObject.isRepaintBoundary], up to possibly the root of the application,
    /// is requested to repaint. That nearest ancestor's [RenderObject.paint] method
    /// will cause _all_ of its descendant [RenderObject]s to repaint in the same
    /// layer.
    ///
    /// [RepaintBoundary] is therefore used, both while propagating the
    /// `markNeedsPaint` flag up the render tree and while traversing down the
    /// render tree via [RenderObject.paintChild], to strategically contain repaints
    /// to the render subtree that visually changed for performance. This is done
    /// because the [RepaintBoundary] widget creates a [RenderObject] that always
    /// has a [Layer], decoupling ancestor render objects from the descendant
    /// render objects.
    ///
    /// [RepaintBoundary] has the further side-effect of possibly hinting to the
    /// engine that it should further optimize animation performance if the render
    /// subtree behind the [RepaintBoundary] is sufficiently complex and is static
    /// while the surrounding tree changes frequently. In those cases, the engine
    /// may choose to pay a one time cost of rasterizing and caching the pixel
    /// values of the subtree for faster future GPU re-rendering speed.
    ///
    /// Several framework widgets insert [RepaintBoundary] widgets to mark natural
    /// separation points in applications. For instance, contents in Material Design
    /// drawers typically don't change while the drawer opens and closes, so
    /// repaints are automatically contained to regions inside or outside the drawer
    /// when using the [Drawer] widget during transitions.
    ///
    /// See also:
    ///
    ///  * [debugRepaintRainbowEnabled], a debugging flag to help visually monitor
    ///    render tree repaints in a running app.
    ///  * [debugProfilePaintsEnabled], a debugging flag to show render tree
    ///    repaints in the observatory's timeline view.
    /// </Summary>
    public class RepaintBoundary : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public RepaintBoundary(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        public static RepaintBoundary Wrap(FlutterSDK.Widgets.Framework.Widget child, int childIndex)
        {
            var instance = new RepaintBoundary(); throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        /// <Summary>
        /// Wraps each of the given children in [RepaintBoundary]s.
        ///
        /// The key for each [RepaintBoundary] is derived either from the wrapped
        /// child's key (if the wrapped child has a non-null key) or from the wrapped
        /// child's index in the list.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Basic.RepaintBoundary> WrapAll(List<FlutterSDK.Widgets.Framework.Widget> widgets) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Proxybox.RenderRepaintBoundary CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that is invisible during hit testing.
    ///
    /// When [ignoring] is true, this widget (and its subtree) is invisible
    /// to hit testing. It still consumes space during layout and paints its child
    /// as usual. It just cannot be the target of located events, because it returns
    /// false from [RenderBox.hitTest].
    ///
    /// When [ignoringSemantics] is true, the subtree will be invisible to
    /// the semantics layer (and thus e.g. accessibility tools). If
    /// [ignoringSemantics] is null, it uses the value of [ignoring].
    ///
    /// See also:
    ///
    ///  * [AbsorbPointer], which also prevents its children from receiving pointer
    ///    events but is itself visible to hit testing.
    /// </Summary>
    public class IgnorePointer : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public IgnorePointer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool ignoring = true, bool ignoringSemantics = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Ignoring = ignoring;
            this.IgnoringSemantics = ignoringSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Ignoring { get; set; }
        public virtual bool IgnoringSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderIgnorePointer CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderIgnorePointer renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that absorbs pointers during hit testing.
    ///
    /// When [absorbing] is true, this widget prevents its subtree from receiving
    /// pointer events by terminating hit testing at itself. It still consumes space
    /// during layout and paints its child as usual. It just prevents its children
    /// from being the target of located events, because it returns true from
    /// [RenderBox.hitTest].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=65HoWqBboI8}
    ///
    /// See also:
    ///
    ///  * [IgnorePointer], which also prevents its children from receiving pointer
    ///    events but is itself invisible to hit testing.
    /// </Summary>
    public class AbsorbPointer : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public AbsorbPointer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool absorbing = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool ignoringSemantics = default(bool))
        : base(key: key, child: child)
        {
            this.Absorbing = absorbing;
            this.IgnoringSemantics = ignoringSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Absorbing { get; set; }
        public virtual bool IgnoringSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderAbsorbPointer CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderAbsorbPointer renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Holds opaque meta data in the render tree.
    ///
    /// Useful for decorating the render tree with information that will be consumed
    /// later. For example, you could store information in the render tree that will
    /// be used when the user interacts with the render tree but has no visual
    /// impact prior to the interaction.
    /// </Summary>
    public class MetaData : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public MetaData(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), object metaData = default(object), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.MetaDataValue = metaData;
            this.Behavior = behavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual object MetaDataValue { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderMetaData CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderMetaData renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that annotates the widget tree with a description of the meaning of
    /// the widgets.
    ///
    /// Used by accessibility tools, search engines, and other semantic analysis
    /// software to determine the meaning of the application.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=NvtMt_DtFrQ}
    ///
    /// See also:
    ///
    ///  * [MergeSemantics], which marks a subtree as being a single node for
    ///    accessibility purposes.
    ///  * [ExcludeSemantics], which excludes a subtree from the semantics tree
    ///    (which might be useful if it is, e.g., totally decorative and not
    ///    important to the user).
    ///  * [RenderObject.semanticsAnnotator], the rendering library API through which
    ///    the [Semantics] widget is actually implemented.
    ///  * [SemanticsNode], the object used by the rendering library to represent
    ///    semantics in the semantics tree.
    ///  * [SemanticsDebugger], an overlay to help visualize the semantics tree. Can
    ///    be enabled using [WidgetsApp.showSemanticsDebugger] or
    ///    [MaterialApp.showSemanticsDebugger].
    /// </Summary>
    public class Semantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Semantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool container = false, bool explicitChildNodes = false, bool excludeSemantics = false, bool enabled = default(bool), bool @checked = default(bool), bool selected = default(bool), bool toggled = default(bool), bool button = default(bool), bool link = default(bool), bool header = default(bool), bool textField = default(bool), bool readOnly = default(bool), bool focusable = default(bool), bool focused = default(bool), bool inMutuallyExclusiveGroup = default(bool), bool obscured = default(bool), bool multiline = default(bool), bool scopesRoute = default(bool), bool namesRoute = default(bool), bool hidden = default(bool), bool image = default(bool), bool liveRegion = default(bool), int maxValueLength = default(int), int currentValueLength = default(int), string label = default(string), string value = default(string), string increasedValue = default(string), string decreasedValue = default(string), string hint = default(string), string onTapHint = default(string), string onLongPressHint = default(string), TextDirection textDirection = default(TextDirection), FlutterSDK.Semantics.Semantics.SemanticsSortKey sortKey = default(FlutterSDK.Semantics.Semantics.SemanticsSortKey), VoidCallback onTap = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), VoidCallback onScrollLeft = default(VoidCallback), VoidCallback onScrollRight = default(VoidCallback), VoidCallback onScrollUp = default(VoidCallback), VoidCallback onScrollDown = default(VoidCallback), VoidCallback onIncrease = default(VoidCallback), VoidCallback onDecrease = default(VoidCallback), VoidCallback onCopy = default(VoidCallback), VoidCallback onCut = default(VoidCallback), VoidCallback onPaste = default(VoidCallback), VoidCallback onDismiss = default(VoidCallback), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorForwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorBackwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.SetSelectionHandler onSetSelection = default(FlutterSDK.Semantics.Semantics.SetSelectionHandler), VoidCallback onDidGainAccessibilityFocus = default(VoidCallback), VoidCallback onDidLoseAccessibilityFocus = default(VoidCallback), Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> customSemanticsActions = default(Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object>))
        : base()
        {
            throw new NotImplementedException();
        }
        public static Semantics FromProperties(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool container = false, bool explicitChildNodes = false, bool excludeSemantics = false, FlutterSDK.Semantics.Semantics.SemanticsProperties properties = default(FlutterSDK.Semantics.Semantics.SemanticsProperties))
        {
            var instance = new Semantics(key: key, child: child); instance.Container = container;
            instance.ExplicitChildNodes = explicitChildNodes;
            instance.ExcludeSemantics = excludeSemantics;
            instance.Properties = properties; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Semantics.Semantics.SemanticsProperties Properties { get; set; }
        public virtual bool Container { get; set; }
        public virtual bool ExplicitChildNodes { get; set; }
        public virtual bool ExcludeSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderSemanticsAnnotations CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        private TextDirection _GetTextDirection(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderSemanticsAnnotations renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that merges the semantics of its descendants.
    ///
    /// Causes all the semantics of the subtree rooted at this node to be
    /// merged into one node in the semantics tree. For example, if you
    /// have a widget with a Text node next to a checkbox widget, this
    /// could be used to merge the label from the Text node with the
    /// "checked" semantic state of the checkbox into a single node that
    /// had both the label and the checked state. Otherwise, the label
    /// would be presented as a separate feature than the checkbox, and
    /// the user would not be able to be sure that they were related.
    ///
    /// Be aware that if two nodes in the subtree have conflicting
    /// semantics, the result may be nonsensical. For example, a subtree
    /// with a checked checkbox and an unchecked checkbox will be
    /// presented as checked. All the labels will be merged into a single
    /// string (with newlines separating each label from the other). If
    /// multiple nodes in the merged subtree can handle semantic gestures,
    /// the first one in tree order will be the one to receive the
    /// callbacks.
    /// </Summary>
    public class MergeSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public MergeSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderMergeSemantics CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that drops the semantics of all widget that were painted before it
    /// in the same semantic container.
    ///
    /// This is useful to hide widgets from accessibility tools that are painted
    /// behind a certain widget, e.g. an alert should usually disallow interaction
    /// with any widget located "behind" the alert (even when they are still
    /// partially visible). Similarly, an open [Drawer] blocks interactions with
    /// any widget outside the drawer.
    ///
    /// See also:
    ///
    ///  * [ExcludeSemantics] which drops all semantics of its descendants.
    /// </Summary>
    public class BlockSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public BlockSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool blocking = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Blocking = blocking; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Blocking { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderBlockSemantics CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderBlockSemantics renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that drops all the semantics of its descendants.
    ///
    /// When [excluding] is true, this widget (and its subtree) is excluded from
    /// the semantics tree.
    ///
    /// This can be used to hide descendant widgets that would otherwise be
    /// reported but that would only be confusing. For example, the
    /// material library's [Chip] widget hides the avatar since it is
    /// redundant with the chip label.
    ///
    /// See also:
    ///
    ///  * [BlockSemantics] which drops semantics of widgets earlier in the tree.
    /// </Summary>
    public class ExcludeSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ExcludeSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool excluding = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Excluding = excluding; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Excluding { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderExcludeSemantics CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderExcludeSemantics renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that annotates the child semantics with an index.
    ///
    /// Semantic indexes are used by TalkBack/Voiceover to make announcements about
    /// the current scroll state. Certain widgets like the [ListView] will
    /// automatically provide a child index for building semantics. A user may wish
    /// to manually provide semantic indexes if not all child of the scrollable
    /// contribute semantics.
    ///
    /// {@tool snippet}
    ///
    /// The example below handles spacers in a scrollable that don't contribute
    /// semantics. The automatic indexes would give the spaces a semantic index,
    /// causing scroll announcements to erroneously state that there are four items
    /// visible.
    ///
    /// ```dart
    /// ListView(
    ///   addSemanticIndexes: false,
    ///   semanticChildCount: 2,
    ///   children: const <Widget>[
    ///     IndexedSemantics(index: 0, child: Text('First')),
    ///     Spacer(),
    ///     IndexedSemantics(index: 1, child: Text('Second')),
    ///     Spacer(),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [CustomScrollView], for an explanation of index semantics.
    /// </Summary>
    public class IndexedSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public IndexedSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int index = default(int), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Index = index; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int Index { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderIndexedSemantics CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderIndexedSemantics renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that builds its child.
    ///
    /// Useful for attaching a key to an existing widget.
    /// </Summary>
    public class KeyedSubtree : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public KeyedSubtree(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child; throw new NotImplementedException();
        }
        public static KeyedSubtree Wrap(FlutterSDK.Widgets.Framework.Widget child, int childIndex)
        {
            var instance = new KeyedSubtree(); throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Wrap each item in a KeyedSubtree whose key is based on the item's existing key or
        /// the sum of its list index and `baseIndex`.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> EnsureUniqueKeysForList(List<FlutterSDK.Widgets.Framework.Widget> items, int baseIndex = 0) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A platonic widget that calls a closure to obtain its child widget.
    ///
    /// See also:
    ///
    ///  * [StatefulBuilder], a platonic widget which also has state.
    /// </Summary>
    public class Builder : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public Builder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder))
        : base(key: key)
        {
            this.BuilderValue = builder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.WidgetBuilder BuilderValue { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A platonic widget that both has state and calls a closure to obtain its child widget.
    ///
    /// The [StateSetter] function passed to the [builder] is used to invoke a
    /// rebuild instead of a typical [State]'s [State.setState].
    ///
    /// Since the [builder] is re-invoked when the [StateSetter] is called, any
    /// variables that represents state should be kept outside the [builder] function.
    ///
    /// {@tool snippet}
    ///
    /// This example shows using an inline StatefulBuilder that rebuilds and that
    /// also has state.
    ///
    /// ```dart
    /// await showDialog<void>(
    ///   context: context,
    ///   builder: (BuildContext context) {
    ///     int selectedRadio = 0;
    ///     return AlertDialog(
    ///       content: StatefulBuilder(
    ///         builder: (BuildContext context, StateSetter setState) {
    ///           return Column(
    ///             mainAxisSize: MainAxisSize.min,
    ///             children: List<Widget>.generate(4, (int index) {
    ///               return Radio<int>(
    ///                 value: index,
    ///                 groupValue: selectedRadio,
    ///                 onChanged: (int value) {
    ///                   setState(() => selectedRadio = value);
    ///                 },
    ///               );
    ///             }),
    ///           );
    ///         },
    ///       ),
    ///     );
    ///   },
    /// );
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Builder], the platonic stateless widget.
    /// </Summary>
    public class StatefulBuilder : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public StatefulBuilder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Basic.StatefulWidgetBuilder builder = default(FlutterSDK.Widgets.Basic.StatefulWidgetBuilder))
        : base(key: key)
        {
            this.Builder = builder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Basic.StatefulWidgetBuilder Builder { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Basic._StatefulBuilderState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _StatefulBuilderState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Basic.StatefulBuilder>
    {
        #region constructors
        public _StatefulBuilderState()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A widget that paints its area with a specified [Color] and then draws its
    /// child on top of that color.
    /// </Summary>
    public class ColoredBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ColoredBox(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key, child: child)
        {
            this.Color = color; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Color Color { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Basic._RenderColoredBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Basic._RenderColoredBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderColoredBox : FlutterSDK.Rendering.Proxybox.RenderProxyBoxWithHitTestBehavior
    {
        #region constructors
        public _RenderColoredBox(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color))
        : base(behavior: HitTestBehavior.Opaque)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterBinding.UI.Color _Color { get; set; }
        public virtual FlutterBinding.UI.Color Color { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }

        #endregion
    }

}
