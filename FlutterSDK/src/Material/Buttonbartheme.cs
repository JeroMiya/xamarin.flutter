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
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
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
namespace FlutterSDK.Material.Buttonbartheme
{
    internal static class ButtonbarthemeDefaultClass
    {
    }

    /// <Summary>
    /// Defines the visual properties of [ButtonBar] widgets.
    ///
    /// Used by [ButtonBarTheme] to control the visual properties of [ButtonBar]
    /// instances in a widget subtree.
    ///
    /// To obtain this configuration, use [ButtonBarTheme.of] to access the closest
    /// ancestor [ButtonBarTheme] of the current [BuildContext].
    ///
    /// See also:
    ///
    ///  * [ButtonBarTheme], an [InheritedWidget] that propagates the theme down
    ///    its subtree.
    ///  * [ButtonBar], which uses this to configure itself and its children
    ///    button widgets.
    /// </Summary>
    public class ButtonBarThemeData : IDiagnosticable
    {
        /// <Summary>
        /// Constructs the set of properties used to configure [ButtonBar] widgets.
        ///
        /// Both [buttonMinWidth] and [buttonHeight] must be non-negative if they
        /// are not null.
        /// </Summary>
        public ButtonBarThemeData(FlutterSDK.Rendering.Flex.MainAxisAlignment alignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Material.Buttontheme.ButtonTextTheme buttonTextTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), double buttonMinWidth = default(double), double buttonHeight = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry buttonPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool buttonAlignedDropdown = default(bool), FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior layoutBehavior = default(FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior), FlutterSDK.Painting.Basictypes.VerticalDirection overflowDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection))
        : base()
        {
            this.Alignment = alignment;
            this.MainAxisSize = mainAxisSize;
            this.ButtonTextTheme = buttonTextTheme;
            this.ButtonMinWidth = buttonMinWidth;
            this.ButtonHeight = buttonHeight;
            this.ButtonPadding = buttonPadding;
            this.ButtonAlignedDropdown = buttonAlignedDropdown;
            this.LayoutBehavior = layoutBehavior;
            this.OverflowDirection = overflowDirection;
        }
        /// <Summary>
        /// How the children should be placed along the horizontal axis.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Flex.MainAxisAlignment Alignment { get; set; }
        /// <Summary>
        /// How much horizontal space is available. See [Row.mainAxisSize].
        /// </Summary>
        public virtual FlutterSDK.Rendering.Flex.MainAxisSize MainAxisSize { get; set; }
        /// <Summary>
        /// Defines a [ButtonBar] button's base colors, and the defaults for
        /// the button's minimum size, internal padding, and shape.
        ///
        /// This will override the surrounding [ButtonTheme.textTheme] setting
        /// for buttons contained in the [ButtonBar].
        ///
        /// Despite the name, this property is not a [TextTheme], its value is not a
        /// collection of [TextStyle]s.
        /// </Summary>
        public virtual FlutterSDK.Material.Buttontheme.ButtonTextTheme ButtonTextTheme { get; set; }
        /// <Summary>
        /// The minimum width for [ButtonBar] buttons.
        ///
        /// This will override the surrounding [ButtonTheme.minWidth] setting
        /// for buttons contained in the [ButtonBar].
        ///
        /// The actual horizontal space allocated for a button's child is
        /// at least this value less the theme's horizontal [padding].
        /// </Summary>
        public virtual double ButtonMinWidth { get; set; }
        /// <Summary>
        /// The minimum height for [ButtonBar] buttons.
        ///
        /// This will override the surrounding [ButtonTheme.height] setting
        /// for buttons contained in the [ButtonBar].
        /// </Summary>
        public virtual double ButtonHeight { get; set; }
        /// <Summary>
        /// Padding for a [ButtonBar] button's child (typically the button's label).
        ///
        /// This will override the surrounding [ButtonTheme.padding] setting
        /// for buttons contained in the [ButtonBar].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ButtonPadding { get; set; }
        /// <Summary>
        /// If true, then a [DropdownButton] menu's width will match the [ButtonBar]
        /// button's width.
        ///
        /// If false, then the dropdown's menu will be wider than
        /// its button. In either case the dropdown button will line up the leading
        /// edge of the menu's value with the leading edge of the values
        /// displayed by the menu items.
        ///
        /// This will override the surrounding [ButtonTheme.alignedDropdown] setting
        /// for buttons contained in the [ButtonBar].
        ///
        /// This property only affects [DropdownButton] contained in a [ButtonBar]
        /// and its menu.
        /// </Summary>
        public virtual bool ButtonAlignedDropdown { get; set; }
        /// <Summary>
        /// Defines whether a [ButtonBar] should size itself with a minimum size
        /// constraint or with padding.
        /// </Summary>
        public virtual FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior LayoutBehavior { get; set; }
        /// <Summary>
        /// Defines the vertical direction of a [ButtonBar]'s children if it
        /// overflows.
        ///
        /// If the [ButtonBar]'s children do not fit into a single row, then they
        /// are arranged in a column. The first action is at the top of the
        /// column if this property is set to [VerticalDirection.down], since it
        /// "starts" at the top and "ends" at the bottom. On the other hand,
        /// the first action will be at the bottom of the column if this
        /// property is set to [VerticalDirection.up], since it "starts" at the
        /// bottom and "ends" at the top.
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.VerticalDirection OverflowDirection { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a copy of this object but with the given fields replaced with the
        /// new values.
        /// </Summary>
        public virtual FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData CopyWith(FlutterSDK.Rendering.Flex.MainAxisAlignment alignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Material.Buttontheme.ButtonTextTheme buttonTextTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), double buttonMinWidth = default(double), double buttonHeight = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry buttonPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool buttonAlignedDropdown = default(bool), FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior layoutBehavior = default(FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior), FlutterSDK.Painting.Basictypes.VerticalDirection overflowDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection))
        {
            return new ButtonBarThemeData(alignment: alignment ?? this.Alignment, mainAxisSize: mainAxisSize ?? this.MainAxisSize, buttonTextTheme: buttonTextTheme ?? this.ButtonTextTheme, buttonMinWidth: buttonMinWidth == default(double) ? this.buttonMinWidth : buttonMinWidth, buttonHeight: buttonHeight == default(double) ? this.buttonHeight : buttonHeight, buttonPadding: buttonPadding ?? this.ButtonPadding, buttonAlignedDropdown: buttonAlignedDropdown ?? this.ButtonAlignedDropdown, layoutBehavior: layoutBehavior ?? this.LayoutBehavior, overflowDirection: overflowDirection ?? this.OverflowDirection);
        }




        /// <Summary>
        /// Linearly interpolate between two button bar themes.
        ///
        /// If both arguments are null, then null is returned.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData Lerp(FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData a, FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData b, double t)
        {

            if (a == null && b == null) return null;
            return new ButtonBarThemeData(alignment: t < 0.5 ? a.Alignment : b.Alignment, mainAxisSize: t < 0.5 ? a.MainAxisSize : b.MainAxisSize, buttonTextTheme: t < 0.5 ? a.ButtonTextTheme : b.ButtonTextTheme, buttonMinWidth: Dart.UI.UiDefaultClass.LerpDouble(a?.ButtonMinWidth, b?.ButtonMinWidth, t), buttonHeight: Dart.UI.UiDefaultClass.LerpDouble(a?.ButtonHeight, b?.ButtonHeight, t), buttonPadding: EdgeinsetsDefaultClass.EdgeInsetsGeometry.Lerp(a?.ButtonPadding, b?.ButtonPadding, t), buttonAlignedDropdown: t < 0.5 ? a.ButtonAlignedDropdown : b.ButtonAlignedDropdown, layoutBehavior: t < 0.5 ? a.LayoutBehavior : b.LayoutBehavior, overflowDirection: t < 0.5 ? a.OverflowDirection : b.OverflowDirection);
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other)) return true;
            if (other.GetType() != GetType()) return false;
            return other is ButtonBarThemeData && other.Alignment == Alignment && other.MainAxisSize == MainAxisSize && other.ButtonTextTheme == ButtonTextTheme && other.ButtonMinWidth == ButtonMinWidth && other.ButtonHeight == ButtonHeight && other.ButtonPadding == ButtonPadding && other.ButtonAlignedDropdown == ButtonAlignedDropdown && other.LayoutBehavior == LayoutBehavior && other.OverflowDirection == OverflowDirection;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<MainAxisAlignment>("alignment", Alignment, defaultValue: null));
            properties.Add(new DiagnosticsProperty<MainAxisSize>("mainAxisSize", MainAxisSize, defaultValue: null));
            properties.Add(new DiagnosticsProperty<ButtonTextTheme>("textTheme", ButtonTextTheme, defaultValue: null));
            properties.Add(new DoubleProperty("minWidth", ButtonMinWidth, defaultValue: null));
            properties.Add(new DoubleProperty("height", ButtonHeight, defaultValue: null));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", ButtonPadding, defaultValue: null));
            properties.Add(new FlagProperty("buttonAlignedDropdown", value: ButtonAlignedDropdown, ifTrue: "dropdown width matches button", defaultValue: null));
            properties.Add(new DiagnosticsProperty<ButtonBarLayoutBehavior>("layoutBehavior", LayoutBehavior, defaultValue: null));
            properties.Add(new DiagnosticsProperty<VerticalDirection>("overflowDirection", OverflowDirection, defaultValue: null));
        }



    }


    /// <Summary>
    /// Applies a button bar theme to descendant [ButtonBar] widgets.
    ///
    /// A button bar theme describes the layout and properties for the buttons
    /// contained in a [ButtonBar].
    ///
    /// Descendant widgets obtain the current theme's [ButtonBarTheme] object using
    /// [ButtonBarTheme.of]. When a widget uses [ButtonBarTheme.of], it is automatically
    /// rebuilt if the theme later changes.
    ///
    /// A button bar theme can be specified as part of the overall Material theme
    /// using [ThemeData.buttonBarTheme].
    ///
    /// See also:
    ///
    ///  * [ButtonBarThemeData], which describes the actual configuration of a button
    ///    bar theme.
    /// </Summary>
    public class ButtonBarTheme : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        /// <Summary>
        /// Constructs a button bar theme that configures all descendent [ButtonBar]
        /// widgets.
        ///
        /// The [data] must not be null.
        /// </Summary>
        public ButtonBarTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData data = default(FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Data = data;
        }
        /// <Summary>
        /// The properties used for all descendant [ButtonBar] widgets.
        /// </Summary>
        public virtual FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData Data { get; set; }

        /// <Summary>
        /// Returns the configuration [data] from the closest [ButtonBarTheme]
        /// ancestor. If there is no ancestor, it returns [ThemeData.buttonBarTheme].
        /// Applications can assume that the returned value will not be null.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// ButtonBarThemeData theme = ButtonBarTheme.of(context);
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Material.Buttonbartheme.ButtonBarThemeData Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ButtonBarTheme buttonBarTheme = context.DependOnInheritedWidgetOfExactType();
            return buttonBarTheme?.Data ?? ThemeDefaultClass.Theme.Of(context).ButtonBarTheme;
        }




        public new bool UpdateShouldNotify(FlutterSDK.Material.Buttonbartheme.ButtonBarTheme oldWidget) => Data != oldWidget.Data;

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => Data != oldWidget.Data;


    }

}
