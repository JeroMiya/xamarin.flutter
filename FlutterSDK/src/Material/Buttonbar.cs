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
namespace FlutterSDK.Material.Buttonbar
{
    internal static class ButtonbarDefaultClass
    {
    }

    /// <Summary>
    /// An end-aligned row of buttons, laying out into a column if there is not
    /// enough horizontal space.
    ///
    /// Places the buttons horizontally according to the [buttonPadding]. The
    /// children are laid out in a [Row] with [MainAxisAlignment.end]. When the
    /// [Directionality] is [TextDirection.ltr], the button bar's children are
    /// right justified and the last child becomes the rightmost child. When the
    /// [Directionality] [TextDirection.rtl] the children are left justified and
    /// the last child becomes the leftmost child.
    ///
    /// If the button bar's width exceeds the maximum width constraint on the
    /// widget, it aligns its buttons in a column. The key difference here
    /// is that the [MainAxisAlignment] will then be treated as a
    /// cross-axis/horizontal alignment. For example, if the buttons overflow and
    /// [ButtonBar.alignment] was set to [MainAxisAlignment.start], the buttons would
    /// align to the horizontal start of the button bar.
    ///
    /// The [ButtonBar] can be configured with a [ButtonBarTheme]. For any null
    /// property on the ButtonBar, the surrounding ButtonBarTheme's property
    /// will be used instead. If the ButtonBarTheme's property is null
    /// as well, the property will default to a value described in the field
    /// documentation below.
    ///
    /// The [children] are wrapped in a [ButtonTheme] that is a copy of the
    /// surrounding ButtonTheme with the button properties overridden by the
    /// properties of the ButtonBar as described above. These properties include
    /// [buttonTextTheme], [buttonMinWidth], [buttonHeight], [buttonPadding],
    /// and [buttonAlignedDropdown].
    ///
    /// Used by [Dialog] to arrange the actions at the bottom of the dialog.
    ///
    /// See also:
    ///
    ///  * [RaisedButton], a kind of button.
    ///  * [FlatButton], another kind of button.
    ///  * [Card], at the bottom of which it is common to place a [ButtonBar].
    ///  * [Dialog], which uses a [ButtonBar] for its actions.
    ///  * [ButtonBarTheme], which configures the [ButtonBar].
    /// </Summary>
    public class ButtonBar : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a button bar.
        ///
        /// Both [buttonMinWidth] and [buttonHeight] must be non-negative if they
        /// are not null.
        /// </Summary>
        public ButtonBar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Flex.MainAxisAlignment alignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Material.Buttontheme.ButtonTextTheme buttonTextTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), double buttonMinWidth = default(double), double buttonHeight = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry buttonPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool buttonAlignedDropdown = default(bool), FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior layoutBehavior = default(FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior), FlutterSDK.Painting.Basictypes.VerticalDirection overflowDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), double overflowButtonSpacing = default(double), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key)
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
            this.OverflowButtonSpacing = overflowButtonSpacing;
            this.Children = children;
        }
        /// <Summary>
        /// How the children should be placed along the horizontal axis.
        ///
        /// If null then it will use [ButtonBarTheme.alignment]. If that is null,
        /// it will default to [MainAxisAlignment.end].
        /// </Summary>
        public virtual FlutterSDK.Rendering.Flex.MainAxisAlignment Alignment { get; set; }
        /// <Summary>
        /// How much horizontal space is available. See [Row.mainAxisSize].
        ///
        /// If null then it will use the surrounding [ButtonBarTheme.mainAxisSize].
        /// If that is null, it will default to [MainAxisSize.max].
        /// </Summary>
        public virtual FlutterSDK.Rendering.Flex.MainAxisSize MainAxisSize { get; set; }
        /// <Summary>
        /// Overrides the surrounding [ButtonTheme.textTheme] to define a button's
        /// base colors, size, internal padding and shape.
        ///
        /// If null then it will use the surrounding [ButtonBarTheme.buttonTextTheme].
        /// If that is null, it will default to [ButtonTextTheme.primary].
        /// </Summary>
        public virtual FlutterSDK.Material.Buttontheme.ButtonTextTheme ButtonTextTheme { get; set; }
        /// <Summary>
        /// Overrides the surrounding [ButtonThemeData.minWidth] to define a button's
        /// minimum width.
        ///
        /// If null then it will use the surrounding [ButtonBarTheme.buttonMinWidth].
        /// If that is null, it will default to 64.0 logical pixels.
        /// </Summary>
        public virtual double ButtonMinWidth { get; set; }
        /// <Summary>
        /// Overrides the surrounding [ButtonThemeData.height] to define a button's
        /// minimum height.
        ///
        /// If null then it will use the surrounding [ButtonBarTheme.buttonHeight].
        /// If that is null, it will default to 36.0 logical pixels.
        /// </Summary>
        public virtual double ButtonHeight { get; set; }
        /// <Summary>
        /// Overrides the surrounding [ButtonThemeData.padding] to define the padding
        /// for a button's child (typically the button's label).
        ///
        /// If null then it will use the surrounding [ButtonBarTheme.buttonPadding].
        /// If that is null, it will default to 8.0 logical pixels on the left
        /// and right.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ButtonPadding { get; set; }
        /// <Summary>
        /// Overrides the surrounding [ButtonThemeData.alignedDropdown] to define whether
        /// a [DropdownButton] menu's width will match the button's width.
        ///
        /// If null then it will use the surrounding [ButtonBarTheme.buttonAlignedDropdown].
        /// If that is null, it will default to false.
        /// </Summary>
        public virtual bool ButtonAlignedDropdown { get; set; }
        /// <Summary>
        /// Defines whether a [ButtonBar] should size itself with a minimum size
        /// constraint or with padding.
        ///
        /// Overrides the surrounding [ButtonThemeData.layoutBehavior].
        ///
        /// If null then it will use the surrounding [ButtonBarTheme.layoutBehavior].
        /// If that is null, it will default [ButtonBarLayoutBehavior.padded].
        /// </Summary>
        public virtual FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior LayoutBehavior { get; set; }
        /// <Summary>
        /// Defines the vertical direction of a [ButtonBar]'s children if it
        /// overflows.
        ///
        /// If [children] do not fit into a single row, then they
        /// are arranged in a column. The first action is at the top of the
        /// column if this property is set to [VerticalDirection.down], since it
        /// "starts" at the top and "ends" at the bottom. On the other hand,
        /// the first action will be at the bottom of the column if this
        /// property is set to [VerticalDirection.up], since it "starts" at the
        /// bottom and "ends" at the top.
        ///
        /// If null then it will use the surrounding
        /// [ButtonBarTheme.overflowDirection]. If that is null, it will
        /// default to [VerticalDirection.down].
        /// </Summary>
        public virtual FlutterSDK.Painting.Basictypes.VerticalDirection OverflowDirection { get; set; }
        /// <Summary>
        /// The spacing between buttons when the button bar overflows.
        ///
        /// If the [children] do not fit into a single row, they are
        /// arranged into a column. This parameter provides additional
        /// vertical space in between buttons when it does overflow.
        ///
        /// Note that the button spacing may appear to be more than
        /// the value provided. This is because most buttons adhere to the
        /// [MaterialTapTargetSize] of 48px. So, even though a button
        /// might visually be 36px in height, it might still take up to
        /// 48px vertically.
        ///
        /// If null then no spacing will be added in between buttons in
        /// an overflow state.
        /// </Summary>
        public virtual double OverflowButtonSpacing { get; set; }
        /// <Summary>
        /// The buttons to arrange horizontally.
        ///
        /// Typically [RaisedButton] or [FlatButton] widgets.
        /// </Summary>
        public virtual List<FlutterSDK.Widgets.Framework.Widget> Children { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ButtonThemeData parentButtonTheme = ButtonthemeDefaultClass.ButtonTheme.Of(context);
            ButtonBarThemeData barTheme = ButtonbarthemeDefaultClass.ButtonBarTheme.Of(context);
            ButtonThemeData buttonTheme = parentButtonTheme.CopyWith(textTheme: ButtonTextTheme ?? barTheme.ButtonTextTheme ?? ButtonTextTheme.Primary, minWidth: buttonMinWidth == default(double) ? barTheme.buttonMinWidth : buttonMinWidth ?? 64.0, height: buttonHeight == default(double) ? barTheme.buttonHeight : buttonHeight ?? 36.0, padding: ButtonPadding ?? barTheme.ButtonPadding ?? EdgeInsets.Symmetric(horizontal: 8.0), alignedDropdown: ButtonAlignedDropdown ?? barTheme.ButtonAlignedDropdown ?? false, layoutBehavior: LayoutBehavior ?? barTheme.LayoutBehavior ?? ButtonBarLayoutBehavior.Padded);
            double paddingUnit = buttonTheme.Padding.Horizontal / 4.0;
            Widget child = ButtonTheme.FromButtonThemeData(data: buttonTheme, child: new _ButtonBarRow(mainAxisAlignment: Alignment ?? barTheme.Alignment ?? MainAxisAlignment.End, mainAxisSize: MainAxisSize ?? barTheme.MainAxisSize ?? MainAxisSize.Max, overflowDirection: OverflowDirection ?? barTheme.OverflowDirection ?? VerticalDirection.Down, children: Children.Map((Widget child) =>
            {
                return new Padding(padding: EdgeInsets.Symmetric(horizontal: paddingUnit), child: child);
            }
            ).ToList(), overflowButtonSpacing: OverflowButtonSpacing));
            switch (buttonTheme.LayoutBehavior) { case ButtonBarLayoutBehavior.Padded: return new Padding(padding: EdgeInsets.Symmetric(vertical: 2.0 * paddingUnit, horizontal: paddingUnit), child: child); case ButtonBarLayoutBehavior.Constrained: return new Container(padding: EdgeInsets.Symmetric(horizontal: paddingUnit), constraints: new BoxConstraints(minHeight: 52.0), alignment: AlignmentDefaultClass.Alignment.Center, child: child); }

            return null;
        }



    }


    /// <Summary>
    /// Attempts to display buttons in a row, but displays them in a column if
    /// there is not enough horizontal space.
    ///
    /// It first attempts to lay out its buttons as though there were no
    /// maximum width constraints on the widget. If the button bar's width is
    /// less than the maximum width constraints of the widget, it then lays
    /// out the widget as though it were placed in a [Row].
    ///
    /// However, if the button bar's width exceeds the maximum width constraint on
    /// the widget, it then aligns its buttons in a column. The key difference here
    /// is that the [MainAxisAlignment] will then be treated as a
    /// cross-axis/horizontal alignment. For example, if the buttons overflow and
    /// [ButtonBar.alignment] was set to [MainAxisAligment.start], the column of
    /// buttons would align to the horizontal start of the button bar.
    /// </Summary>
    public class _ButtonBarRow : FlutterSDK.Widgets.Basic.Flex
    {
        /// <Summary>
        /// Creates a button bar that attempts to display in a row, but displays in
        /// a column if there is insufficient horizontal space.
        /// </Summary>
        public _ButtonBarRow(List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>), FlutterSDK.Painting.Basictypes.Axis direction = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection overflowDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), TextBaseline textBaseline = default(TextBaseline), double overflowButtonSpacing = default(double))
        : base(children: children, direction: direction, mainAxisSize: mainAxisSize, mainAxisAlignment: mainAxisAlignment, crossAxisAlignment: crossAxisAlignment, textDirection: textDirection, verticalDirection: overflowDirection, textBaseline: textBaseline)
        {
            this.OverflowButtonSpacing = overflowButtonSpacing;
        }
        public virtual double OverflowButtonSpacing { get; set; }

        public new FlutterSDK.Material.Buttonbar._RenderButtonBarRow CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderButtonBarRow(direction: Direction, mainAxisAlignment: MainAxisAlignment, mainAxisSize: MainAxisSize, crossAxisAlignment: CrossAxisAlignment, textDirection: GetEffectiveTextDirection(context), verticalDirection: VerticalDirection, textBaseline: TextBaseline, overflowButtonSpacing: OverflowButtonSpacing);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Buttonbar._RenderButtonBarRow renderObject)
        {
            ..Direction = Direction..MainAxisAlignment = MainAxisAlignment..MainAxisSize = MainAxisSize..CrossAxisAlignment = CrossAxisAlignment..TextDirection = GetEffectiveTextDirection(context)..VerticalDirection = VerticalDirection..TextBaseline = TextBaseline..OverflowButtonSpacing = OverflowButtonSpacing;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Direction = Direction..MainAxisAlignment = MainAxisAlignment..MainAxisSize = MainAxisSize..CrossAxisAlignment = CrossAxisAlignment..TextDirection = GetEffectiveTextDirection(context)..VerticalDirection = VerticalDirection..TextBaseline = TextBaseline..OverflowButtonSpacing = OverflowButtonSpacing;
        }



    }


    /// <Summary>
    /// Attempts to display buttons in a row, but displays them in a column if
    /// there is not enough horizontal space.
    ///
    /// It first attempts to lay out its buttons as though there were no
    /// maximum width constraints on the widget. If the button bar's width is
    /// less than the maximum width constraints of the widget, it then lays
    /// out the widget as though it were placed in a [Row].
    ///
    /// However, if the button bar's width exceeds the maximum width constraint on
    /// the widget, it then aligns its buttons in a column. The key difference here
    /// is that the [MainAxisAlignment] will then be treated as a
    /// cross-axis/horizontal alignment. For example, if the buttons overflow and
    /// [ButtonBar.alignment] was set to [MainAxisAligment.start], the buttons would
    /// align to the horizontal start of the button bar.
    /// </Summary>
    public class _RenderButtonBarRow : FlutterSDK.Rendering.Flex.RenderFlex
    {
        /// <Summary>
        /// Creates a button bar that attempts to display in a row, but displays in
        /// a column if there is insufficient horizontal space.
        /// </Summary>
        public _RenderButtonBarRow(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), FlutterSDK.Painting.Basictypes.Axis direction = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), TextBaseline textBaseline = default(TextBaseline), double overflowButtonSpacing = default(double))
        : base(children: children, direction: direction, mainAxisSize: mainAxisSize, mainAxisAlignment: mainAxisAlignment, crossAxisAlignment: crossAxisAlignment, textDirection: textDirection, verticalDirection: verticalDirection, textBaseline: textBaseline)
        {
            this.OverflowButtonSpacing = overflowButtonSpacing;
        }
        internal virtual bool _HasCheckedLayoutWidth { get; set; }
        public virtual double OverflowButtonSpacing { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void PerformLayout()
        {
            _HasCheckedLayoutWidth = false;
            base.PerformLayout();
            _HasCheckedLayoutWidth = true;
            if (Size.Width <= Constraints.MaxWidth)
            {
                base.PerformLayout();
            }
            else
            {
                BoxConstraints childConstraints = Constraints.CopyWith(minWidth: 0.0);
                RenderBox child = default(RenderBox);
                double currentHeight = 0.0;
                switch (VerticalDirection) { case VerticalDirection.Down: child = FirstChild; break; case VerticalDirection.Up: child = LastChild; break; }
                while (child != null)
                {
                    FlexParentData childParentData = child.ParentData as FlexParentData;
                    child.Layout(childConstraints, parentUsesSize: true);
                    switch (TextDirection) { case TextDirection.Ltr: switch (MainAxisAlignment) { case MainAxisAlignment.Center: double midpoint = (Constraints.MaxWidth - child.Size.Width) / 2.0; childParentData.Offset = new Offset(midpoint, currentHeight); break; case MainAxisAlignment.End: childParentData.Offset = new Offset(Constraints.MaxWidth - child.Size.Width, currentHeight); break; default: childParentData.Offset = new Offset(0, currentHeight); break; } break; case TextDirection.Rtl: switch (MainAxisAlignment) { case MainAxisAlignment.Center: double midpoint = Constraints.MaxWidth / 2.0 - child.Size.Width / 2.0; childParentData.Offset = new Offset(midpoint, currentHeight); break; case MainAxisAlignment.End: childParentData.Offset = new Offset(0, currentHeight); break; default: childParentData.Offset = new Offset(Constraints.MaxWidth - child.Size.Width, currentHeight); break; } break; }
                    currentHeight += child.Size.Height;
                    switch (VerticalDirection) { case VerticalDirection.Down: child = childParentData.NextSibling; break; case VerticalDirection.Up: child = childParentData.PreviousSibling; break; }
                    if (OverflowButtonSpacing != null && child != null) currentHeight += OverflowButtonSpacing;
                }

                Size = Constraints.Constrain(new Size(Constraints.MaxWidth, currentHeight));
            }

        }



    }

}
