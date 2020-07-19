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
namespace FlutterSDK.Material.Listtile
{
    internal static class ListtileDefaultClass
    {
    }

    /// <Summary>
    /// An inherited widget that defines color and style parameters for [ListTile]s
    /// in this widget's subtree.
    ///
    /// Values specified here are used for [ListTile] properties that are not given
    /// an explicit non-null value.
    ///
    /// The [Drawer] widget specifies a tile theme for its children which sets
    /// [style] to [ListTileStyle.drawer].
    /// </Summary>
    public class ListTileTheme : FlutterSDK.Widgets.Inheritedtheme.InheritedTheme
    {
        #region constructors
        public ListTileTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool dense = false, FlutterSDK.Material.Listtile.ListTileStyle style = default(FlutterSDK.Material.Listtile.ListTileStyle), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color iconColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Dense = dense;
            this.Style = style;
            this.SelectedColor = selectedColor;
            this.IconColor = iconColor;
            this.TextColor = textColor;
            this.ContentPadding = contentPadding;
        }
        #endregion

        #region fields
        public virtual bool Dense { get; set; }
        public virtual FlutterSDK.Material.Listtile.ListTileStyle Style { get; set; }
        public virtual FlutterBinding.UI.Color SelectedColor { get; set; }
        public virtual FlutterBinding.UI.Color IconColor { get; set; }
        public virtual FlutterBinding.UI.Color TextColor { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Creates a list tile theme that controls the color and style parameters for
        /// [ListTile]s, and merges in the current list tile theme, if any.
        ///
        /// The [child] argument must not be null.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Merge(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool dense = default(bool), FlutterSDK.Material.Listtile.ListTileStyle style = default(FlutterSDK.Material.Listtile.ListTileStyle), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color iconColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {

            return new Builder(builder: (BuildContext context) =>
            {
                ListTileTheme parent = ListtileDefaultClass.ListTileTheme.Of(context);
                return new ListTileTheme(key: key, dense: dense ?? parent.Dense, style: style ?? parent.Style, selectedColor: selectedColor ?? parent.SelectedColor, iconColor: iconColor ?? parent.IconColor, textColor: textColor ?? parent.TextColor, contentPadding: contentPadding ?? parent.ContentPadding, child: child);
            }
            );
        }




        /// <Summary>
        /// The closest instance of this class that encloses the given context.
        ///
        /// Typical usage is as follows:
        ///
        /// ```dart
        /// ListTileTheme theme = ListTileTheme.of(context);
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Material.Listtile.ListTileTheme Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ListTileTheme result = context.DependOnInheritedWidgetOfExactType();
            return result ?? new ListTileTheme();
        }




        public new FlutterSDK.Widgets.Framework.Widget Wrap(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            ListTileTheme ancestorTheme = context.FindAncestorWidgetOfExactType();
            return Dart:coreDefaultClass.Identical(this, ancestorTheme) ? child : new ListTileTheme(dense: Dense, style: Style, selectedColor: SelectedColor, iconColor: IconColor, textColor: TextColor, contentPadding: ContentPadding, child: child);
        }




        public new bool UpdateShouldNotify(FlutterSDK.Material.Listtile.ListTileTheme oldWidget)
        {
            return Dense != oldWidget.Dense || Style != oldWidget.Style || SelectedColor != oldWidget.SelectedColor || IconColor != oldWidget.IconColor || TextColor != oldWidget.TextColor || ContentPadding != oldWidget.ContentPadding;
        }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget)
        {
            return Dense != oldWidget.Dense || Style != oldWidget.Style || SelectedColor != oldWidget.SelectedColor || IconColor != oldWidget.IconColor || TextColor != oldWidget.TextColor || ContentPadding != oldWidget.ContentPadding;
        }



        #endregion
    }


    /// <Summary>
    /// A single fixed-height row that typically contains some text as well as
    /// a leading or trailing icon.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=l8dj0yPBvgQ}
    ///
    /// A list tile contains one to three lines of text optionally flanked by icons or
    /// other widgets, such as check boxes. The icons (or other widgets) for the
    /// tile are defined with the [leading] and [trailing] parameters. The first
    /// line of text is not optional and is specified with [title]. The value of
    /// [subtitle], which _is_ optional, will occupy the space allocated for an
    /// additional line of text, or two lines if [isThreeLine] is true. If [dense]
    /// is true then the overall height of this tile and the size of the
    /// [DefaultTextStyle]s that wrap the [title] and [subtitle] widget are reduced.
    ///
    /// It is the responsibility of the caller to ensure that [title] does not wrap,
    /// and to ensure that [subtitle] doesn't wrap (if [isThreeLine] is false) or
    /// wraps to two lines (if it is true).
    ///
    /// The heights of the [leading] and [trailing] widgets are constrained
    /// according to the
    /// [Material spec](https://material.io/design/components/lists.html).
    /// An exception is made for one-line ListTiles for accessibility. Please
    /// see the example below to see how to adhere to both Material spec and
    /// accessibility requirements.
    ///
    /// Note that [leading] and [trailing] widgets can expand as far as they wish
    /// horizontally, so ensure that they are properly constrained.
    ///
    /// List tiles are typically used in [ListView]s, or arranged in [Column]s in
    /// [Drawer]s and [Card]s.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// {@tool snippet}
    ///
    /// This example uses a [ListView] to demonstrate different configurations of
    /// [ListTile]s in [Card]s.
    ///
    /// ![Different variations of ListTile](https://flutter.github.io/assets-for-api-docs/assets/material/list_tile.png)
    ///
    /// ```dart
    /// ListView(
    ///   children: const <Widget>[
    ///     Card(child: ListTile(title: Text('One-line ListTile'))),
    ///     Card(
    ///       child: ListTile(
    ///         leading: FlutterLogo(),
    ///         title: Text('One-line with leading widget'),
    ///       ),
    ///     ),
    ///     Card(
    ///       child: ListTile(
    ///         title: Text('One-line with trailing widget'),
    ///         trailing: Icon(Icons.more_vert),
    ///       ),
    ///     ),
    ///     Card(
    ///       child: ListTile(
    ///         leading: FlutterLogo(),
    ///         title: Text('One-line with both widgets'),
    ///         trailing: Icon(Icons.more_vert),
    ///       ),
    ///     ),
    ///     Card(
    ///       child: ListTile(
    ///         title: Text('One-line dense ListTile'),
    ///         dense: true,
    ///       ),
    ///     ),
    ///     Card(
    ///       child: ListTile(
    ///         leading: FlutterLogo(size: 56.0),
    ///         title: Text('Two-line ListTile'),
    ///         subtitle: Text('Here is a second line'),
    ///         trailing: Icon(Icons.more_vert),
    ///       ),
    ///     ),
    ///     Card(
    ///       child: ListTile(
    ///         leading: FlutterLogo(size: 72.0),
    ///         title: Text('Three-line ListTile'),
    ///         subtitle: Text(
    ///           'A sufficiently long subtitle warrants three lines.'
    ///         ),
    ///         trailing: Icon(Icons.more_vert),
    ///         isThreeLine: true,
    ///       ),
    ///     ),
    ///   ],
    /// )
    /// ```
    /// {@end-tool}
    /// {@tool snippet}
    ///
    /// Tiles can be much more elaborate. Here is a tile which can be tapped, but
    /// which is disabled when the `_act` variable is not 2. When the tile is
    /// tapped, the whole row has an ink splash effect (see [InkWell]).
    ///
    /// ```dart
    /// int _act = 1;
    /// // ...
    /// ListTile(
    ///   leading: const Icon(Icons.flight_land),
    ///   title: const Text("Trix's airplane"),
    ///   subtitle: _act != 2 ? const Text('The airplane is only in Act II.') : null,
    ///   enabled: _act == 2,
    ///   onTap: () { /* react to the tile being tapped */ }
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// To be accessible, tappable [leading] and [trailing] widgets have to
    /// be at least 48x48 in size. However, to adhere to the Material spec,
    /// [trailing] and [leading] widgets in one-line ListTiles should visually be
    /// at most 32 ([dense]: true) or 40 ([dense]: false) in height, which may
    /// conflict with the accessibility requirement.
    ///
    /// For this reason, a one-line ListTile allows the height of [leading]
    /// and [trailing] widgets to be constrained by the height of the ListTile.
    /// This allows for the creation of tappable [leading] and [trailing] widgets
    /// that are large enough, but it is up to the developer to ensure that
    /// their widgets follow the Material spec.
    ///
    /// {@tool snippet}
    ///
    /// Here is an example of a one-line, non-[dense] ListTile with a
    /// tappable leading widget that adheres to accessibility requirements and
    /// the Material spec. To adjust the use case below for a one-line, [dense]
    /// ListTile, adjust the vertical padding to 8.0.
    ///
    /// ```dart
    /// ListTile(
    ///   leading: GestureDetector(
    ///     behavior: HitTestBehavior.translucent,
    ///     onTap: () {},
    ///     child: Container(
    ///       width: 48,
    ///       height: 48,
    ///       padding: EdgeInsets.symmetric(vertical: 4.0),
    ///       alignment: Alignment.center,
    ///       child: CircleAvatar(),
    ///     ),
    ///   ),
    ///   title: Text('title'),
    ///   dense: false,
    /// ),
    /// ```
    /// {@end-tool}
    ///
    /// ## The ListTile layout isn't exactly what I want
    ///
    /// If the way ListTile pads and positions its elements isn't quite what
    /// you're looking for, it's easy to create custom list items with a
    /// combination of other widgets, such as [Row]s and [Column]s.
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// Here is an example of a custom list item that resembles a Youtube related
    /// video list item created with [Expanded] and [Container] widgets.
    ///
    /// ![Custom list item a](https://flutter.github.io/assets-for-api-docs/assets/widgets/custom_list_item_a.png)
    ///
    /// ```dart preamble
    /// class CustomListItem extends StatelessWidget {
    ///   const CustomListItem({
    ///     this.thumbnail,
    ///     this.title,
    ///     this.user,
    ///     this.viewCount,
    ///   });
    ///
    ///   final Widget thumbnail;
    ///   final String title;
    ///   final String user;
    ///   final int viewCount;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Padding(
    ///       padding: const EdgeInsets.symmetric(vertical: 5.0),
    ///       child: Row(
    ///         crossAxisAlignment: CrossAxisAlignment.start,
    ///         children: <Widget>[
    ///           Expanded(
    ///             flex: 2,
    ///             child: thumbnail,
    ///           ),
    ///           Expanded(
    ///             flex: 3,
    ///             child: _VideoDescription(
    ///               title: title,
    ///               user: user,
    ///               viewCount: viewCount,
    ///             ),
    ///           ),
    ///           const Icon(
    ///             Icons.more_vert,
    ///             size: 16.0,
    ///           ),
    ///         ],
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// class _VideoDescription extends StatelessWidget {
    ///   const _VideoDescription({
    ///     Key key,
    ///     this.title,
    ///     this.user,
    ///     this.viewCount,
    ///   }) : super(key: key);
    ///
    ///   final String title;
    ///   final String user;
    ///   final int viewCount;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Padding(
    ///       padding: const EdgeInsets.fromLTRB(5.0, 0.0, 0.0, 0.0),
    ///       child: Column(
    ///         crossAxisAlignment: CrossAxisAlignment.start,
    ///         children: <Widget>[
    ///           Text(
    ///             title,
    ///             style: const TextStyle(
    ///               fontWeight: FontWeight.w500,
    ///               fontSize: 14.0,
    ///             ),
    ///           ),
    ///           const Padding(padding: EdgeInsets.symmetric(vertical: 2.0)),
    ///           Text(
    ///             user,
    ///             style: const TextStyle(fontSize: 10.0),
    ///           ),
    ///           const Padding(padding: EdgeInsets.symmetric(vertical: 1.0)),
    ///           Text(
    ///             '$viewCount views',
    ///             style: const TextStyle(fontSize: 10.0),
    ///           ),
    ///         ],
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return ListView(
    ///     padding: const EdgeInsets.all(8.0),
    ///     itemExtent: 106.0,
    ///     children: <CustomListItem>[
    ///       CustomListItem(
    ///         user: 'Flutter',
    ///         viewCount: 999000,
    ///         thumbnail: Container(
    ///           decoration: const BoxDecoration(color: Colors.blue),
    ///         ),
    ///         title: 'The Flutter YouTube Channel',
    ///       ),
    ///       CustomListItem(
    ///         user: 'Dash',
    ///         viewCount: 884000,
    ///         thumbnail: Container(
    ///           decoration: const BoxDecoration(color: Colors.yellow),
    ///         ),
    ///         title: 'Announcing Flutter 1.0',
    ///       ),
    ///     ],
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// Here is an example of an article list item with multiline titles and
    /// subtitles. It utilizes [Row]s and [Column]s, as well as [Expanded] and
    /// [AspectRatio] widgets to organize its layout.
    ///
    /// ![Custom list item b](https://flutter.github.io/assets-for-api-docs/assets/widgets/custom_list_item_b.png)
    ///
    /// ```dart preamble
    /// class _ArticleDescription extends StatelessWidget {
    ///   _ArticleDescription({
    ///     Key key,
    ///     this.title,
    ///     this.subtitle,
    ///     this.author,
    ///     this.publishDate,
    ///     this.readDuration,
    ///   }) : super(key: key);
    ///
    ///   final String title;
    ///   final String subtitle;
    ///   final String author;
    ///   final String publishDate;
    ///   final String readDuration;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Column(
    ///       crossAxisAlignment: CrossAxisAlignment.start,
    ///       children: <Widget>[
    ///         Expanded(
    ///           flex: 1,
    ///           child: Column(
    ///             crossAxisAlignment: CrossAxisAlignment.start,
    ///             children: <Widget>[
    ///               Text(
    ///                 '$title',
    ///                 maxLines: 2,
    ///                 overflow: TextOverflow.ellipsis,
    ///                 style: const TextStyle(
    ///                   fontWeight: FontWeight.bold,
    ///                 ),
    ///               ),
    ///               const Padding(padding: EdgeInsets.only(bottom: 2.0)),
    ///               Text(
    ///                 '$subtitle',
    ///                 maxLines: 2,
    ///                 overflow: TextOverflow.ellipsis,
    ///                 style: const TextStyle(
    ///                   fontSize: 12.0,
    ///                   color: Colors.black54,
    ///                 ),
    ///               ),
    ///             ],
    ///           ),
    ///         ),
    ///         Expanded(
    ///           flex: 1,
    ///           child: Column(
    ///             crossAxisAlignment: CrossAxisAlignment.start,
    ///             mainAxisAlignment: MainAxisAlignment.end,
    ///             children: <Widget>[
    ///               Text(
    ///                 '$author',
    ///                 style: const TextStyle(
    ///                   fontSize: 12.0,
    ///                   color: Colors.black87,
    ///                 ),
    ///               ),
    ///               Text(
    ///                 '$publishDate - $readDuration',
    ///                 style: const TextStyle(
    ///                   fontSize: 12.0,
    ///                   color: Colors.black54,
    ///                 ),
    ///               ),
    ///             ],
    ///           ),
    ///         ),
    ///       ],
    ///     );
    ///   }
    /// }
    ///
    /// class CustomListItemTwo extends StatelessWidget {
    ///   CustomListItemTwo({
    ///     Key key,
    ///     this.thumbnail,
    ///     this.title,
    ///     this.subtitle,
    ///     this.author,
    ///     this.publishDate,
    ///     this.readDuration,
    ///   }) : super(key: key);
    ///
    ///   final Widget thumbnail;
    ///   final String title;
    ///   final String subtitle;
    ///   final String author;
    ///   final String publishDate;
    ///   final String readDuration;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Padding(
    ///       padding: const EdgeInsets.symmetric(vertical: 10.0),
    ///       child: SizedBox(
    ///         height: 100,
    ///         child: Row(
    ///           crossAxisAlignment: CrossAxisAlignment.start,
    ///           children: <Widget>[
    ///             AspectRatio(
    ///               aspectRatio: 1.0,
    ///               child: thumbnail,
    ///             ),
    ///             Expanded(
    ///               child: Padding(
    ///                 padding: const EdgeInsets.fromLTRB(20.0, 0.0, 2.0, 0.0),
    ///                 child: _ArticleDescription(
    ///                   title: title,
    ///                   subtitle: subtitle,
    ///                   author: author,
    ///                   publishDate: publishDate,
    ///                   readDuration: readDuration,
    ///                 ),
    ///               ),
    ///             )
    ///           ],
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return ListView(
    ///     padding: const EdgeInsets.all(10.0),
    ///     children: <Widget>[
    ///       CustomListItemTwo(
    ///         thumbnail: Container(
    ///           decoration: const BoxDecoration(color: Colors.pink),
    ///         ),
    ///         title: 'Flutter 1.0 Launch',
    ///         subtitle:
    ///           'Flutter continues to improve and expand its horizons.'
    ///           'This text should max out at two lines and clip',
    ///         author: 'Dash',
    ///         publishDate: 'Dec 28',
    ///         readDuration: '5 mins',
    ///       ),
    ///       CustomListItemTwo(
    ///         thumbnail: Container(
    ///           decoration: const BoxDecoration(color: Colors.blue),
    ///         ),
    ///         title: 'Flutter 1.2 Release - Continual updates to the framework',
    ///         subtitle: 'Flutter once again improves and makes updates.',
    ///         author: 'Flutter',
    ///         publishDate: 'Feb 26',
    ///         readDuration: '12 mins',
    ///       ),
    ///     ],
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [ListTileTheme], which defines visual properties for [ListTile]s.
    ///  * [ListView], which can display an arbitrary number of [ListTile]s
    ///    in a scrolling list.
    ///  * [CircleAvatar], which shows an icon representing a person and is often
    ///    used as the [leading] element of a ListTile.
    ///  * [Card], which can be used with [Column] to show a few [ListTile]s.
    ///  * [Divider], which can be used to separate [ListTile]s.
    ///  * [ListTile.divideTiles], a utility for inserting [Divider]s in between [ListTile]s.
    ///  * [CheckboxListTile], [RadioListTile], and [SwitchListTile], widgets
    ///    that combine [ListTile] with other controls.
    ///  * <https://material.io/design/components/lists.html>
    /// </Summary>
    public class ListTile : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public ListTile(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget subtitle = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget trailing = default(FlutterSDK.Widgets.Framework.Widget), bool isThreeLine = false, bool dense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool enabled = true, FlutterSDK.Gestures.Tap.GestureTapCallback onTap = default(FlutterSDK.Gestures.Tap.GestureTapCallback), FlutterSDK.Gestures.Longpress.GestureLongPressCallback onLongPress = default(FlutterSDK.Gestures.Longpress.GestureLongPressCallback), bool selected = false)
        : base(key: key)
        {
            this.Leading = leading;
            this.Title = title;
            this.Subtitle = subtitle;
            this.Trailing = trailing;
            this.IsThreeLine = isThreeLine;
            this.Dense = dense;
            this.ContentPadding = contentPadding;
            this.Enabled = enabled;
            this.OnTap = onTap;
            this.OnLongPress = onLongPress;
            this.Selected = selected;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Leading { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Subtitle { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Trailing { get; set; }
        public virtual bool IsThreeLine { get; set; }
        public virtual bool Dense { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapCallback OnTap { get; set; }
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressCallback OnLongPress { get; set; }
        public virtual bool Selected { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Add a one pixel border in between each tile. If color isn't specified the
        /// [ThemeData.dividerColor] of the context's [Theme] is used.
        ///
        /// See also:
        ///
        ///  * [Divider], which you can use to obtain this effect manually.
        /// </Summary>
        public virtual Iterable<FlutterSDK.Widgets.Framework.Widget> DivideTiles(FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), Iterable<FlutterSDK.Widgets.Framework.Widget> tiles = default(Iterable<FlutterSDK.Widgets.Framework.Widget>), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color))
        {


            Iterator<Widget> iterator = tiles.Iterator;
            bool isNotEmpty = iterator.MoveNext();
            Decoration decoration = new BoxDecoration(border: new Border(bottom: DividerDefaultClass.Divider.CreateBorderSide(context, color: color)));
            Widget tile = iterator.Current;
            while (iterator.MoveNext())
            {
                yield return new DecoratedBox(position: DecorationPosition.Foreground, decoration: decoration, child: tile);
                tile = iterator.Current;
            }

            if (isNotEmpty) yield return tile;
        }




        private Color _IconColor(FlutterSDK.Material.Themedata.ThemeData theme, FlutterSDK.Material.Listtile.ListTileTheme tileTheme)
        {
            if (!Enabled) return theme.DisabledColor;
            if (Selected && tileTheme?.SelectedColor != null) return tileTheme.SelectedColor;
            if (!Selected && tileTheme?.IconColor != null) return tileTheme.IconColor;
            switch (theme.Brightness) { case Brightness.Light: return Selected ? theme.PrimaryColor : ColorsDefaultClass.Colors.Black45; case Brightness.Dark: return Selected ? theme.AccentColor : null; }

            return null;
        }




        private Color _TextColor(FlutterSDK.Material.Themedata.ThemeData theme, FlutterSDK.Material.Listtile.ListTileTheme tileTheme, FlutterBinding.UI.Color defaultColor)
        {
            if (!Enabled) return theme.DisabledColor;
            if (Selected && tileTheme?.SelectedColor != null) return tileTheme.SelectedColor;
            if (!Selected && tileTheme?.TextColor != null) return tileTheme.TextColor;
            if (Selected)
            {
                switch (theme.Brightness) { case Brightness.Light: return theme.PrimaryColor; case Brightness.Dark: return theme.AccentColor; }
            }

            return defaultColor;
        }




        private bool _IsDenseLayout(FlutterSDK.Material.Listtile.ListTileTheme tileTheme)
        {
            return Dense ?? tileTheme?.Dense ?? false;
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _TitleTextStyle(FlutterSDK.Material.Themedata.ThemeData theme, FlutterSDK.Material.Listtile.ListTileTheme tileTheme)
        {
            TextStyle style = default(TextStyle);
            if (tileTheme != null)
            {
                switch (tileTheme.Style) { case ListTileStyle.Drawer: style = theme.TextTheme.BodyText1; break; case ListTileStyle.List: style = theme.TextTheme.Subtitle1; break; }
            }
            else
            {
                style = theme.TextTheme.Subtitle1;
            }

            Color color = _TextColor(theme, tileTheme, style.Color);
            return _IsDenseLayout(tileTheme) ? style.CopyWith(fontSize: 13.0, color: color) : style.CopyWith(color: color);
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _SubtitleTextStyle(FlutterSDK.Material.Themedata.ThemeData theme, FlutterSDK.Material.Listtile.ListTileTheme tileTheme)
        {
            TextStyle style = theme.TextTheme.BodyText2;
            Color color = _TextColor(theme, tileTheme, theme.TextTheme.Caption.Color);
            return _IsDenseLayout(tileTheme) ? style.CopyWith(color: color, fontSize: 12.0) : style.CopyWith(color: color);
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            ListTileTheme tileTheme = ListtileDefaultClass.ListTileTheme.Of(context);
            IconThemeData iconThemeData = default(IconThemeData);
            if (Leading != null || Trailing != null) iconThemeData = new IconThemeData(color: _IconColor(theme, tileTheme));
            Widget leadingIcon = default(Widget);
            if (Leading != null)
            {
                leadingIcon = IconthemeDefaultClass.IconTheme.Merge(data: iconThemeData, child: Leading);
            }

            TextStyle titleStyle = _TitleTextStyle(theme, tileTheme);
            Widget titleText = new AnimatedDefaultTextStyle(style: titleStyle, duration: ConstantsDefaultClass.KThemeChangeDuration, child: Title ?? new SizedBox());
            Widget subtitleText = default(Widget);
            TextStyle subtitleStyle = default(TextStyle);
            if (Subtitle != null)
            {
                subtitleStyle = _SubtitleTextStyle(theme, tileTheme);
                subtitleText = new AnimatedDefaultTextStyle(style: subtitleStyle, duration: ConstantsDefaultClass.KThemeChangeDuration, child: Subtitle);
            }

            Widget trailingIcon = default(Widget);
            if (Trailing != null)
            {
                trailingIcon = IconthemeDefaultClass.IconTheme.Merge(data: iconThemeData, child: Trailing);
            }

            EdgeInsets _defaultContentPadding = EdgeInsets.Symmetric(horizontal: 16.0);
            TextDirection textDirection = BasicDefaultClass.Directionality.Of(context);
            EdgeInsets resolvedContentPadding = ContentPadding?.Resolve(textDirection) ?? tileTheme?.ContentPadding?.Resolve(textDirection) ?? _defaultContentPadding;
            return new InkWell(onTap: Enabled ? OnTap : null, onLongPress: Enabled ? OnLongPress : null, canRequestFocus: Enabled, child: new Semantics(selected: Selected, enabled: Enabled, child: new SafeArea(top: false, bottom: false, minimum: resolvedContentPadding, child: new _ListTile(leading: leadingIcon, title: titleText, subtitle: subtitleText, trailing: trailingIcon, isDense: _IsDenseLayout(tileTheme), isThreeLine: IsThreeLine, textDirection: textDirection, titleBaselineType: titleStyle.TextBaseline, subtitleBaselineType: subtitleStyle?.TextBaseline))));
        }



        #endregion
    }


    public class _ListTile : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        #region constructors
        public _ListTile(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget leading = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget title = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget subtitle = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget trailing = default(FlutterSDK.Widgets.Framework.Widget), bool isThreeLine = default(bool), bool isDense = default(bool), TextDirection textDirection = default(TextDirection), TextBaseline titleBaselineType = default(TextBaseline), TextBaseline subtitleBaselineType = default(TextBaseline))
        : base(key: key)
        {
            this.Leading = leading;
            this.Title = title;
            this.Subtitle = subtitle;
            this.Trailing = trailing;
            this.IsThreeLine = isThreeLine;
            this.IsDense = isDense;
            this.TextDirection = textDirection;
            this.TitleBaselineType = titleBaselineType;
            this.SubtitleBaselineType = subtitleBaselineType;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Leading { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Title { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Subtitle { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Trailing { get; set; }
        public virtual bool IsThreeLine { get; set; }
        public virtual bool IsDense { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual TextBaseline TitleBaselineType { get; set; }
        public virtual TextBaseline SubtitleBaselineType { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Listtile._ListTileElement CreateElement() => new _ListTileElement(this);



        public new FlutterSDK.Material.Listtile._RenderListTile CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderListTile(isThreeLine: IsThreeLine, isDense: IsDense, textDirection: TextDirection, titleBaselineType: TitleBaselineType, subtitleBaselineType: SubtitleBaselineType);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Listtile._RenderListTile renderObject)
        {
            ..IsThreeLine = IsThreeLine..IsDense = IsDense..TextDirection = TextDirection..TitleBaselineType = TitleBaselineType..SubtitleBaselineType = SubtitleBaselineType;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..IsThreeLine = IsThreeLine..IsDense = IsDense..TextDirection = TextDirection..TitleBaselineType = TitleBaselineType..SubtitleBaselineType = SubtitleBaselineType;
        }



        #endregion
    }


    public class _ListTileElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        #region constructors
        public _ListTileElement(FlutterSDK.Material.Listtile._ListTile widget)
        : base(widget)
        {

        }
        #endregion

        #region fields
        public virtual Dictionary<FlutterSDK.Material.Listtile._ListTileSlot, FlutterSDK.Widgets.Framework.Element> SlotToChild { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Framework.Element, FlutterSDK.Material.Listtile._ListTileSlot> ChildToSlot { get; set; }
        public virtual FlutterSDK.Material.Listtile._ListTile Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Listtile._RenderListTile RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            SlotToChild.Values.ForEach(visitor);
        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {


            _ListTileSlot slot = ChildToSlot[child];
            ChildToSlot.Remove(child);
            SlotToChild.Remove(slot);
            base.ForgetChild(child);
        }




        private void _MountChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Listtile._ListTileSlot slot)
        {
            Element oldChild = SlotToChild[slot];
            Element newChild = UpdateChild(oldChild, widget, slot);
            if (oldChild != null)
            {
                SlotToChild.Remove(slot);
                ChildToSlot.Remove(oldChild);
            }

            if (newChild != null)
            {
                SlotToChild[slot] = newChild;
                ChildToSlot[newChild] = slot;
            }

        }




        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
        {
            base.Mount(parent, newSlot);
            _MountChild(Widget.Leading, _ListTileSlot.Leading);
            _MountChild(Widget.Title, _ListTileSlot.Title);
            _MountChild(Widget.Subtitle, _ListTileSlot.Subtitle);
            _MountChild(Widget.Trailing, _ListTileSlot.Trailing);
        }




        private void _UpdateChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Listtile._ListTileSlot slot)
        {
            Element oldChild = SlotToChild[slot];
            Element newChild = UpdateChild(oldChild, widget, slot);
            if (oldChild != null)
            {
                ChildToSlot.Remove(oldChild);
                SlotToChild.Remove(slot);
            }

            if (newChild != null)
            {
                SlotToChild[slot] = newChild;
                ChildToSlot[newChild] = slot;
            }

        }




        public new void Update(FlutterSDK.Material.Listtile._ListTile newWidget)
        {
            base.Update(newWidget);

            _UpdateChild(Widget.Leading, _ListTileSlot.Leading);
            _UpdateChild(Widget.Title, _ListTileSlot.Title);
            _UpdateChild(Widget.Subtitle, _ListTileSlot.Subtitle);
            _UpdateChild(Widget.Trailing, _ListTileSlot.Trailing);
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);

            _UpdateChild(Widget.Leading, _ListTileSlot.Leading);
            _UpdateChild(Widget.Title, _ListTileSlot.Title);
            _UpdateChild(Widget.Subtitle, _ListTileSlot.Subtitle);
            _UpdateChild(Widget.Trailing, _ListTileSlot.Trailing);
        }




        private void _UpdateRenderObject(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Material.Listtile._ListTileSlot slot)
        {
            switch (slot) { case _ListTileSlot.Leading: RenderObject.Leading = child; break; case _ListTileSlot.Title: RenderObject.Title = child; break; case _ListTileSlot.Subtitle: RenderObject.Subtitle = child; break; case _ListTileSlot.Trailing: RenderObject.Trailing = child; break; }
        }




        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue)
        {


            _ListTileSlot slot = slotValue as _ListTileSlot;
            _UpdateRenderObject(child as RenderBox, slot);


        }




        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
        {


            _UpdateRenderObject(null, RenderObject.ChildToSlot[child]);


        }




        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue)
        {

        }



        #endregion
    }


    public class _RenderListTile : FlutterSDK.Rendering.Box.RenderBox
    {
        #region constructors
        public _RenderListTile(bool isDense = default(bool), bool isThreeLine = default(bool), TextDirection textDirection = default(TextDirection), TextBaseline titleBaselineType = default(TextBaseline), TextBaseline subtitleBaselineType = default(TextBaseline))
        : base()
        {

        }
        #endregion

        #region fields
        internal virtual double _MinLeadingWidth { get; set; }
        internal virtual double _HorizontalTitleGap { get; set; }
        internal virtual double _MinVerticalPadding { get; set; }
        public virtual Dictionary<FlutterSDK.Material.Listtile._ListTileSlot, FlutterSDK.Rendering.Box.RenderBox> SlotToChild { get; set; }
        public virtual Dictionary<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Material.Listtile._ListTileSlot> ChildToSlot { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Leading { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Title { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Subtitle { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Trailing { get; set; }
        internal virtual bool _IsDense { get; set; }
        internal virtual bool _IsThreeLine { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual TextBaseline _TitleBaselineType { get; set; }
        internal virtual TextBaseline _SubtitleBaselineType { get; set; }
        public virtual FlutterSDK.Rendering.Box.RenderBox Leading { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Title { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Subtitle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Trailing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Iterable<FlutterSDK.Rendering.Box.RenderBox> _Children { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsDense { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsThreeLine { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextBaseline TitleBaselineType { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextBaseline SubtitleBaselineType { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _DefaultTileHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private FlutterSDK.Rendering.Box.RenderBox _UpdateChild(FlutterSDK.Rendering.Box.RenderBox oldChild, FlutterSDK.Rendering.Box.RenderBox newChild, FlutterSDK.Material.Listtile._ListTileSlot slot)
        {
            if (oldChild != null)
            {
                DropChild(oldChild);
                ChildToSlot.Remove(oldChild);
                SlotToChild.Remove(slot);
            }

            if (newChild != null)
            {
                ChildToSlot[newChild] = slot;
                SlotToChild[slot] = newChild;
                AdoptChild(newChild);
            }

            return newChild;
        }




        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
        {
            base.Attach(owner);
            foreach (RenderBox child in _Children) child.Attach(owner);
        }


        public new void Attach(@Object owner)
        {
            base.Attach(owner);
            foreach (RenderBox child in _Children) child.Attach(owner);
        }




        public new void Detach()
        {
            base.Detach();
            foreach (RenderBox child in _Children) child.Detach();
        }




        public new void RedepthChildren()
        {
            _Children.ForEach(RedepthChild);
        }




        public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            _Children.ForEach(visitor);
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            List<DiagnosticsNode> value = new List<DiagnosticsNode>() { };
            void Add(RenderBox child, string name) => {
                if (child != null) value.Add(child.ToDiagnosticsNode(name: name));
            }

            Add(Leading, "leading");
            Add(Title, "title");
            Add(Subtitle, "subtitle");
            Add(Trailing, "trailing");
            return value;
        }




        private double _MinWidth(FlutterSDK.Rendering.Box.RenderBox box, double height)
        {
            return box == null ? 0.0 : box.GetMinIntrinsicWidth(height);
        }




        private double _MaxWidth(FlutterSDK.Rendering.Box.RenderBox box, double height)
        {
            return box == null ? 0.0 : box.GetMaxIntrinsicWidth(height);
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            double leadingWidth = Leading != null ? Math.Dart : mathDefaultClass.Max(Leading.GetMinIntrinsicWidth(height), _MinLeadingWidth) + _HorizontalTitleGap:0.0;
            return leadingWidth + Math.Dart:mathDefaultClass.Max(_MinWidth(Title, height), _MinWidth(Subtitle, height)) + _MaxWidth(Trailing, height);
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            double leadingWidth = Leading != null ? Math.Dart : mathDefaultClass.Max(Leading.GetMaxIntrinsicWidth(height), _MinLeadingWidth) + _HorizontalTitleGap:0.0;
            return leadingWidth + Math.Dart:mathDefaultClass.Max(_MaxWidth(Title, height), _MaxWidth(Subtitle, height)) + _MaxWidth(Trailing, height);
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            return Math.Dart:mathDefaultClass.Max(_DefaultTileHeight, Title.GetMinIntrinsicHeight(width) + (Subtitle?.GetMinIntrinsicHeight(width) ?? 0.0));
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            return ComputeMinIntrinsicHeight(width);
        }




        public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
        {

            BoxParentData parentData = Title.ParentData as BoxParentData;
            return parentData.Offset.Dy + Title.GetDistanceToActualBaseline(baseline);
        }




        private double _BoxBaseline(FlutterSDK.Rendering.Box.RenderBox box, TextBaseline baseline)
        {
            return box.GetDistanceToBaseline(baseline);
        }




        private Size _LayoutBox(FlutterSDK.Rendering.Box.RenderBox box, FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            if (box == null) return Dart:uiDefaultClass.Size.Zero;
            box.Layout(constraints, parentUsesSize: true);
            return box.Size;
        }




        private void _PositionBox(FlutterSDK.Rendering.Box.RenderBox box, FlutterBinding.UI.Offset offset)
        {
            BoxParentData parentData = box.ParentData as BoxParentData;
            parentData.Offset = offset;
        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            bool hasLeading = Leading != null;
            bool hasSubtitle = Subtitle != null;
            bool hasTrailing = Trailing != null;
            bool isTwoLine = !IsThreeLine && hasSubtitle;
            bool isOneLine = !IsThreeLine && !hasSubtitle;
            BoxConstraints maxIconHeightConstraint = new BoxConstraints(maxHeight: IsDense ? 48.0 : 56.0);
            BoxConstraints looseConstraints = constraints.Loosen();
            BoxConstraints iconConstraints = looseConstraints.Enforce(maxIconHeightConstraint);
            double tileWidth = looseConstraints.MaxWidth;
            Size leadingSize = _LayoutBox(Leading, iconConstraints);
            Size trailingSize = _LayoutBox(Trailing, iconConstraints);


            double titleStart = hasLeading ? Math.Dart : mathDefaultClass.Max(_MinLeadingWidth, leadingSize.Width) + _HorizontalTitleGap:0.0;
            BoxConstraints textConstraints = looseConstraints.Tighten(width: tileWidth - titleStart - (hasTrailing ? trailingSize.Width + _HorizontalTitleGap : 0.0));
            Size titleSize = _LayoutBox(Title, textConstraints);
            Size subtitleSize = _LayoutBox(Subtitle, textConstraints);
            double titleBaseline = default(double);
            double subtitleBaseline = default(double);
            if (isTwoLine)
            {
                titleBaseline = IsDense ? 28.0 : 32.0;
                subtitleBaseline = IsDense ? 48.0 : 52.0;
            }
            else if (IsThreeLine)
            {
                titleBaseline = IsDense ? 22.0 : 28.0;
                subtitleBaseline = IsDense ? 42.0 : 48.0;
            }
            else
            {

            }

            double defaultTileHeight = _DefaultTileHeight;
            double tileHeight = default(double);
            double titleY = default(double);
            double subtitleY = default(double);
            if (!hasSubtitle)
            {
                tileHeight = Math.Dart:mathDefaultClass.Max(defaultTileHeight, titleSize.Height + 2.0 * _MinVerticalPadding);
                titleY = (tileHeight - titleSize.Height) / 2.0;
            }
            else
            {

                titleY = titleBaseline - _BoxBaseline(Title, TitleBaselineType);
                subtitleY = subtitleBaseline - _BoxBaseline(Subtitle, SubtitleBaselineType);
                tileHeight = defaultTileHeight;
                double titleOverlap = titleY + titleSize.Height - subtitleY;
                if (titleOverlap > 0.0)
                {
                    titleY -= titleOverlap / 2.0;
                    subtitleY += titleOverlap / 2.0;
                }

                if (titleY < _MinVerticalPadding || (subtitleY + subtitleSize.Height + _MinVerticalPadding) > tileHeight)
                {
                    tileHeight = titleSize.Height + subtitleSize.Height + 2.0 * _MinVerticalPadding;
                    titleY = _MinVerticalPadding;
                    subtitleY = titleSize.Height + _MinVerticalPadding;
                }

            }

            double leadingY = default(double);
            double trailingY = default(double);
            if (tileHeight > 72.0)
            {
                leadingY = 16.0;
                trailingY = 16.0;
            }
            else
            {
                leadingY = Math.Dart:mathDefaultClass.Min((tileHeight - leadingSize.Height) / 2.0, 16.0);
                trailingY = (tileHeight - trailingSize.Height) / 2.0;
            }

            switch (TextDirection)
            {
                case TextDirection.Rtl:
                    {
                        if (hasLeading) _PositionBox(Leading, new Offset(tileWidth - leadingSize.Width, leadingY));
                        double titleX = hasTrailing ? trailingSize.Width + _HorizontalTitleGap : 0.0;
                        _PositionBox(Title, new Offset(titleX, titleY));
                        if (hasSubtitle) _PositionBox(Subtitle, new Offset(titleX, subtitleY));
                        if (hasTrailing) _PositionBox(Trailing, new Offset(0.0, trailingY));
                        break;
                    }
                case TextDirection.Ltr:
                    {
                        if (hasLeading) _PositionBox(Leading, new Offset(0.0, leadingY));
                        _PositionBox(Title, new Offset(titleStart, titleY));
                        if (hasSubtitle) _PositionBox(Subtitle, new Offset(titleStart, subtitleY));
                        if (hasTrailing) _PositionBox(Trailing, new Offset(tileWidth - trailingSize.Width, trailingY));
                        break;
                    }
            }
            Size = constraints.Constrain(new Size(tileWidth, tileHeight));


        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            void DoPaint(RenderBox child) => {
                if (child != null)
                {
                    BoxParentData parentData = child.ParentData as BoxParentData;
                    context.PaintChild(child, parentData.Offset + offset);
                }

            }

            DoPaint(Leading);
            DoPaint(Title);
            DoPaint(Subtitle);
            DoPaint(Trailing);
        }




        public new bool HitTestSelf(FlutterBinding.UI.Offset position) => true;



        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {

            foreach (RenderBox child in _Children)
            {
                BoxParentData parentData = child.ParentData as BoxParentData;
                bool isHit = result.AddWithPaintOffset(offset: parentData.Offset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
                {

                    return child.HitTest(result, position: transformed);
                }
                );
                if (isHit) return true;
            }

            return false;
        }



        #endregion
    }


    /// <Summary>
    /// Defines the title font used for [ListTile] descendants of a [ListTileTheme].
    ///
    /// List tiles that appear in a [Drawer] use the theme's [TextTheme.bodyText1]
    /// text style, which is a little smaller than the theme's [TextTheme.subtitle1]
    /// text style, which is used by default.
    /// </Summary>
    public enum ListTileStyle
    {

        /// <Summary>
        /// Use a title font that's appropriate for a [ListTile] in a list.
        /// </Summary>
        List,
        /// <Summary>
        /// Use a title font that's appropriate for a [ListTile] that appears in a [Drawer].
        /// </Summary>
        Drawer,
    }


    /// <Summary>
    /// Where to place the control in widgets that use [ListTile] to position a
    /// control next to a label.
    ///
    /// See also:
    ///
    ///  * [CheckboxListTile], which combines a [ListTile] with a [Checkbox].
    ///  * [RadioListTile], which combines a [ListTile] with a [Radio] button.
    /// </Summary>
    public enum ListTileControlAffinity
    {

        /// <Summary>
        /// Position the control on the leading edge, and the secondary widget, if
        /// any, on the trailing edge.
        /// </Summary>
        Leading,
        /// <Summary>
        /// Position the control on the trailing edge, and the secondary widget, if
        /// any, on the leading edge.
        /// </Summary>
        Trailing,
        /// <Summary>
        /// Position the control relative to the text in the fashion that is typical
        /// for the current platform, and place the secondary widget on the opposite
        /// side.
        /// </Summary>
        Platform,
    }


    public enum _ListTileSlot
    {

        Leading,
        Title,
        Subtitle,
        Trailing,
    }

}
