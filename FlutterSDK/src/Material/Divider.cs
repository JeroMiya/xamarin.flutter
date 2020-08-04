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
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Tooltip;
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
namespace FlutterSDK.Material.Divider
{
    internal static class DividerDefaultClass
    {
    }

    /// <Summary>
    /// A thin horizontal line, with padding on either side.
    ///
    /// In the material design language, this represents a divider. Dividers can be
    /// used in lists, [Drawer]s, and elsewhere to separate content.
    ///
    /// To create a divider between [ListTile] items, consider using
    /// [ListTile.divideTiles], which is optimized for this case.
    ///
    /// The box's total height is controlled by [height]. The appropriate
    /// padding is automatically computed from the height.
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This sample shows how to display a Divider between an orange and blue box
    /// inside a column. The Divider is 20 logical pixels in height and contains a
    /// vertically centered black line that is 5 logical pixels thick. The black
    /// line is indented by 20 logical pixels.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/divider.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return Center(
    ///     child: Column(
    ///       children: <Widget>[
    ///         Expanded(
    ///           child: Container(
    ///             color: Colors.amber,
    ///             child: const Center(
    ///               child: Text('Above'),
    ///             ),
    ///           ),
    ///         ),
    ///         const Divider(
    ///           color: Colors.black,
    ///           height: 20,
    ///           thickness: 5,
    ///           indent: 20,
    ///           endIndent: 0,
    ///         ),
    ///         Expanded(
    ///           child: Container(
    ///             color: Colors.blue,
    ///             child: const Center(
    ///               child: Text('Below'),
    ///             ),
    ///           ),
    ///         ),
    ///       ],
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    /// See also:
    ///
    ///  * [PopupMenuDivider], which is the equivalent but for popup menus.
    ///  * [ListTile.divideTiles], another approach to dividing widgets in a list.
    ///  * <https://material.io/design/components/dividers.html>
    /// </Summary>
    public class Divider : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a material design divider.
        ///
        /// The [height], [thickness], [indent], and [endIndent] must be null or
        /// non-negative.
        /// </Summary>
        public Divider(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double height = default(double), double thickness = default(double), double indent = default(double), double endIndent = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Height = height;
            this.Thickness = thickness;
            this.Indent = indent;
            this.EndIndent = endIndent;
            this.Color = color;
        }
        /// <Summary>
        /// The divider's height extent.
        ///
        /// The divider itself is always drawn as a horizontal line that is centered
        /// within the height specified by this value.
        ///
        /// If this is null, then the [DividerThemeData.space] is used. If that is
        /// also null, then this defaults to 16.0.
        /// </Summary>
        public virtual double Height { get; set; }
        /// <Summary>
        /// The thickness of the line drawn within the divider.
        ///
        /// A divider with a [thickness] of 0.0 is always drawn as a line with a
        /// height of exactly one device pixel.
        ///
        /// If this is null, then the [DividerThemeData.dividerThickness] is used. If
        /// that is also null, then this defaults to 0.0.
        /// </Summary>
        public virtual double Thickness { get; set; }
        /// <Summary>
        /// The amount of empty space to the leading edge of the divider.
        ///
        /// If this is null, then the [DividerThemeData.indent] is used. If that is
        /// also null, then this defaults to 0.0.
        /// </Summary>
        public virtual double Indent { get; set; }
        /// <Summary>
        /// The amount of empty space to the trailing edge of the divider.
        ///
        /// If this is null, then the [DividerThemeData.endIndent] is used. If that is
        /// also null, then this defaults to 0.0.
        /// </Summary>
        public virtual double EndIndent { get; set; }
        /// <Summary>
        /// The color to use when painting the line.
        ///
        /// If this is null, then the [DividerThemeData.color] is used. If that is
        /// also null, then [ThemeData.dividerColor] is used.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Divider(
        ///   color: Colors.deepOrange,
        /// )
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }

        /// <Summary>
        /// Computes the [BorderSide] that represents a divider..
        ///
        /// If [color] is null, then [DividerThemeData.color] is used. If that is also
        /// null, then [ThemeData.dividerColor] is used.
        ///
        /// If [width] is null, then [DividerThemeData.thickness] is used. If that is
        /// also null, then this defaults to 0.0 (a hairline border).
        ///
        /// If [context] is null, the default color of [BorderSide] is used and the
        /// default width of 0.0 is used.
        ///
        /// {@tool snippet}
        ///
        /// This example uses this method to create a box that has a divider above and
        /// below it. This is sometimes useful with lists, for instance, to separate a
        /// scrollable section from the rest of the interface.
        ///
        /// ```dart
        /// DecoratedBox(
        ///   decoration: BoxDecoration(
        ///     border: Border(
        ///       top: Divider.createBorderSide(context),
        ///       bottom: Divider.createBorderSide(context),
        ///     ),
        ///   ),
        ///   // child: ...
        /// )
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.BorderSide CreateBorderSide(FlutterSDK.Widgets.Framework.BuildContext context, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), double width = default(double))
        {
            Color effectiveColor = color ?? (context != null ? (DividerthemeDefaultClass.DividerTheme.Of(context).Color ?? ThemeDefaultClass.Theme.Of(context).DividerColor) : null);
            double effectiveWidth = width == default(double) ? (context != null ? DividerTheme.of(context).thickness : null) : width ?? 0.0;
            if (effectiveColor == null)
            {
                return new BorderSide(width: effectiveWidth);
            }

            return new BorderSide(color: effectiveColor, width: effectiveWidth);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            DividerThemeData dividerTheme = DividerthemeDefaultClass.DividerTheme.Of(context);
            double height = this.Height ?? dividerTheme.Space ?? 16.0;
            double thickness = this.Thickness ?? dividerTheme.Thickness ?? 0.0;
            double indent = this.Indent ?? dividerTheme.Indent ?? 0.0;
            double endIndent = this.EndIndent ?? dividerTheme.EndIndent ?? 0.0;
            return new SizedBox(height: height, child: new Center(child: new Container(height: thickness, margin: EdgeInsetsDirectional.Only(start: indent, end: endIndent), decoration: new BoxDecoration(border: new Border(bottom: CreateBorderSide(context, color: Color, width: thickness))))));
        }



    }


    /// <Summary>
    /// A thin vertical line, with padding on either side.
    ///
    /// In the material design language, this represents a divider. Vertical
    /// dividers can be used in horizontally scrolling lists, such as a
    /// [ListView] with [ListView.scrollDirection] set to [Axis.horizontal].
    ///
    /// The box's total width is controlled by [width]. The appropriate
    /// padding is automatically computed from the width.
    ///
    /// See also:
    ///
    ///  * [ListView.separated], which can be used to generate vertical dividers.
    ///  * <https://material.io/design/components/dividers.html>
    /// </Summary>
    public class VerticalDivider : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a material design vertical divider.
        ///
        /// The [width], [thickness], [indent], and [endIndent] must be null or
        /// non-negative.
        /// </Summary>
        public VerticalDivider(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double width = default(double), double thickness = default(double), double indent = default(double), double endIndent = default(double), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Width = width;
            this.Thickness = thickness;
            this.Indent = indent;
            this.EndIndent = endIndent;
            this.Color = color;
        }
        /// <Summary>
        /// The divider's width.
        ///
        /// The divider itself is always drawn as a vertical line that is centered
        /// within the width specified by this value.
        ///
        /// If this is null, then the [DividerThemeData.space] is used. If that is
        /// also null, then this defaults to 16.0.
        /// </Summary>
        public virtual double Width { get; set; }
        /// <Summary>
        /// The thickness of the line drawn within the divider.
        ///
        /// A divider with a [thickness] of 0.0 is always drawn as a line with a
        /// width of exactly one device pixel.
        ///
        /// If this is null, then the [DividerThemeData.thickness] is used which
        /// defaults to 0.0.
        /// </Summary>
        public virtual double Thickness { get; set; }
        /// <Summary>
        /// The amount of empty space on top of the divider.
        ///
        /// If this is null, then the [DividerThemeData.indent] is used. If that is
        /// also null, then this defaults to 0.0.
        /// </Summary>
        public virtual double Indent { get; set; }
        /// <Summary>
        /// The amount of empty space under the divider.
        ///
        /// If this is null, then the [DividerThemeData.endIndent] is used. If that is
        /// also null, then this defaults to 0.0.
        /// </Summary>
        public virtual double EndIndent { get; set; }
        /// <Summary>
        /// The color to use when painting the line.
        ///
        /// If this is null, then the [DividerThemeData.color] is used. If that is
        /// also null, then [ThemeData.dividerColor] is used.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// Divider(
        ///   color: Colors.deepOrange,
        /// )
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            DividerThemeData dividerTheme = DividerthemeDefaultClass.DividerTheme.Of(context);
            double width = this.Width ?? dividerTheme.Space ?? 16.0;
            double thickness = this.Thickness ?? dividerTheme.Thickness ?? 0.0;
            double indent = this.Indent ?? dividerTheme.Indent ?? 0.0;
            double endIndent = this.EndIndent ?? dividerTheme.EndIndent ?? 0.0;
            return new SizedBox(width: width, child: new Center(child: new Container(width: thickness, margin: EdgeInsetsDirectional.Only(top: indent, bottom: endIndent), decoration: new BoxDecoration(border: new Border(left: DividerDefaultClass.Divider.CreateBorderSide(context, color: Color, width: thickness))))));
        }



    }

}
