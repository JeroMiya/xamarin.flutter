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
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Divider;
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
namespace FlutterSDK.Material.Chiptheme
{
    internal static class ChipthemeDefaultClass
    {
    }

    /// <Summary>
    /// Applies a chip theme to descendant [RawChip]-based widgets, like [Chip],
    /// [InputChip], [ChoiceChip], [FilterChip], and [ActionChip].
    ///
    /// A chip theme describes the color, shape and text styles for the chips it is
    /// applied to
    ///
    /// Descendant widgets obtain the current theme's [ChipThemeData] object using
    /// [ChipTheme.of]. When a widget uses [ChipTheme.of], it is automatically
    /// rebuilt if the theme later changes.
    ///
    /// The [ThemeData] object given by the [Theme.of] call also contains a default
    /// [ThemeData.chipTheme] that can be customized by copying it (using
    /// [ChipThemeData.copyWith]).
    ///
    /// See also:
    ///
    ///  * [Chip], a chip that displays information and can be deleted.
    ///  * [InputChip], a chip that represents a complex piece of information, such
    ///    as an entity (person, place, or thing) or conversational text, in a
    ///    compact form.
    ///  * [ChoiceChip], allows a single selection from a set of options. Choice
    ///    chips contain related descriptive text or categories.
    ///  * [FilterChip], uses tags or descriptive words as a way to filter content.
    ///  * [ActionChip], represents an action related to primary content.
    ///  * [ChipThemeData], which describes the actual configuration of a chip
    ///    theme.
    ///  * [ThemeData], which describes the overall theme information for the
    ///    application.
    /// </Summary>
    public class ChipTheme : FlutterSDK.Widgets.Inheritedtheme.InheritedTheme
    {
        /// <Summary>
        /// Applies the given theme [data] to [child].
        ///
        /// The [data] and [child] arguments must not be null.
        /// </Summary>
        public ChipTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Chiptheme.ChipThemeData data = default(FlutterSDK.Material.Chiptheme.ChipThemeData), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Data = data;
        }
        /// <Summary>
        /// Specifies the color, shape, and text style values for descendant chip
        /// widgets.
        /// </Summary>
        public virtual FlutterSDK.Material.Chiptheme.ChipThemeData Data { get; set; }

        /// <Summary>
        /// Returns the data from the closest [ChipTheme] instance that encloses
        /// the given context.
        ///
        /// Defaults to the ambient [ThemeData.chipTheme] if there is no
        /// [ChipTheme] in the given build context.
        ///
        /// {@tool snippet}
        ///
        /// ```dart
        /// class Spaceship extends StatelessWidget {
        ///   @override
        ///   Widget build(BuildContext context) {
        ///     return ChipTheme(
        ///       data: ChipTheme.of(context).copyWith(backgroundColor: Colors.red),
        ///       child: ActionChip(
        ///         label: const Text('Launch'),
        ///         onPressed: () { print('We have liftoff!'); },
        ///       ),
        ///     );
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// See also:
        ///
        ///  * [ChipThemeData], which describes the actual configuration of a chip
        ///    theme.
        /// </Summary>
        public virtual FlutterSDK.Material.Chiptheme.ChipThemeData Of(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ChipTheme inheritedTheme = context.DependOnInheritedWidgetOfExactType();
            return inheritedTheme?.Data ?? ThemeDefaultClass.Theme.Of(context).ChipTheme;
        }




        public new FlutterSDK.Widgets.Framework.Widget Wrap(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
        {
            ChipTheme ancestorTheme = context.FindAncestorWidgetOfExactType();
            return Dart.CoreDefaultClass.Identical(this, ancestorTheme) ? child : new ChipTheme(data: Data, child: child);
        }




        public new bool UpdateShouldNotify(FlutterSDK.Material.Chiptheme.ChipTheme oldWidget) => Data != oldWidget.Data;

        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => Data != oldWidget.Data;


    }


    /// <Summary>
    /// Holds the color, shape, and text styles for a material design chip theme.
    ///
    /// Use this class to configure a [ChipTheme] widget, or to set the
    /// [ThemeData.chipTheme] for a [Theme] widget.
    ///
    /// To obtain the current ambient chip theme, use [ChipTheme.of].
    ///
    /// The parts of a chip are:
    ///
    ///  * The "avatar", which is a widget that appears at the beginning of the
    ///    chip. This is typically a [CircleAvatar] widget.
    ///  * The "label", which is the widget displayed in the center of the chip.
    ///    Typically this is a [Text] widget.
    ///  * The "delete icon", which is a widget that appears at the end of the chip.
    ///  * The chip is disabled when it is not accepting user input. Only some chips
    ///    have a disabled state: [InputChip], [ChoiceChip], and [FilterChip].
    ///
    /// The simplest way to create a ChipThemeData is to use [copyWith] on the one
    /// you get from [ChipTheme.of], or create an entirely new one with
    /// [ChipThemeData..fromDefaults].
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// class CarColor extends StatefulWidget {
    ///   @override
    ///   State createState() => _CarColorState();
    /// }
    ///
    /// class _CarColorState extends State<CarColor> {
    ///   Color _color = Colors.red;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return ChipTheme(
    ///       data: ChipTheme.of(context).copyWith(backgroundColor: Colors.lightBlue),
    ///       child: ChoiceChip(
    ///         label: Text('Light Blue'),
    ///         onSelected: (bool value) {
    ///           setState(() {
    ///             _color = value ? Colors.lightBlue : Colors.red;
    ///           });
    ///         },
    ///         selected: _color == Colors.lightBlue,
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Chip], a chip that displays information and can be deleted.
    ///  * [InputChip], a chip that represents a complex piece of information, such
    ///    as an entity (person, place, or thing) or conversational text, in a
    ///    compact form.
    ///  * [ChoiceChip], allows a single selection from a set of options. Choice
    ///    chips contain related descriptive text or categories.
    ///  * [FilterChip], uses tags or descriptive words as a way to filter content.
    ///  * [ActionChip], represents an action related to primary content.
    ///  * [CircleAvatar], which shows images or initials of entities.
    ///  * [Wrap], A widget that displays its children in multiple horizontal or
    ///    vertical runs.
    ///  * [ChipTheme] widget, which can override the chip theme of its
    ///    children.
    ///  * [Theme] widget, which performs a similar function to [ChipTheme],
    ///    but for overall themes.
    ///  * [ThemeData], which has a default [ChipThemeData].
    /// </Summary>
    public class ChipThemeData : IDiagnosticable
    {
        /// <Summary>
        /// Create a [ChipThemeData] given a set of exact values. All the values
        /// must be specified except for [shadowColor], [selectedShadowColor],
        /// [elevation], and [pressElevation], which may be null.
        ///
        /// This will rarely be used directly. It is used by [lerp] to
        /// create intermediate themes based on two themes.
        /// </Summary>
        public ChipThemeData(FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color deleteIconColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondarySelectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), bool showCheckmark = default(bool), FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle secondaryLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), Brightness brightness = default(Brightness), double elevation = default(double), double pressElevation = default(double))
        : base()
        {
            this.BackgroundColor = backgroundColor;
            this.DeleteIconColor = deleteIconColor;
            this.DisabledColor = disabledColor;
            this.SelectedColor = selectedColor;
            this.SecondarySelectedColor = secondarySelectedColor;
            this.ShadowColor = shadowColor;
            this.SelectedShadowColor = selectedShadowColor;
            this.ShowCheckmark = showCheckmark;
            this.CheckmarkColor = checkmarkColor;
            this.LabelPadding = labelPadding;
            this.Padding = padding;
            this.Shape = shape;
            this.LabelStyle = labelStyle;
            this.SecondaryLabelStyle = secondaryLabelStyle;
            this.Brightness = brightness;
            this.Elevation = elevation;
            this.PressElevation = pressElevation;
        }
        /// <Summary>
        /// Generates a ChipThemeData from a brightness, a primary color, and a text
        /// style.
        ///
        /// The [brightness] is used to select a primary color from the default
        /// values.
        ///
        /// The optional [primaryColor] is used as the base color for the other
        /// colors. The opacity of the [primaryColor] is ignored. If a [primaryColor]
        /// is specified, then the [brightness] is ignored, and the theme brightness
        /// is determined from the [primaryColor].
        ///
        /// Only one of [primaryColor] or [brightness] may be specified.
        ///
        /// The [secondaryColor] is used for the selection colors needed by
        /// [ChoiceChip].
        ///
        /// This is used to generate the default chip theme for a [ThemeData].
        /// </Summary>
        public static ChipThemeData FromDefaults(Brightness brightness = default(Brightness), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondaryColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle))
        {
            var instance = new ChipThemeData();




            if (primaryColor != null)
            {
                brightness = ThemedataDefaultClass.ThemeData.EstimateBrightnessForColor(primaryColor);
            }

            int backgroundAlpha = 0x1f;
            int deleteIconAlpha = 0xde;
            int disabledAlpha = 0x0c;
            int selectAlpha = 0x3d;
            int textLabelAlpha = 0xde;
            ShapeBorder shape = new StadiumBorder();
            EdgeInsetsGeometry labelPadding = EdgeInsets.Symmetric(horizontal: 8.0);
            EdgeInsetsGeometry padding = EdgeInsets.All(4.0);
            primaryColor = primaryColor ?? (brightness == Brightness.Light ? ColorsDefaultClass.Colors.Black : ColorsDefaultClass.Colors.White);
            Color backgroundColor = primaryColor.WithAlpha(backgroundAlpha);
            Color deleteIconColor = primaryColor.WithAlpha(deleteIconAlpha);
            Color disabledColor = primaryColor.WithAlpha(disabledAlpha);
            Color selectedColor = primaryColor.WithAlpha(selectAlpha);
            Color secondarySelectedColor = secondaryColor.WithAlpha(selectAlpha);
            TextStyle secondaryLabelStyle = labelStyle.CopyWith(color: secondaryColor.WithAlpha(textLabelAlpha));
            labelStyle = labelStyle.CopyWith(color: primaryColor.WithAlpha(textLabelAlpha));
            return new ChipThemeData(backgroundColor: backgroundColor, deleteIconColor: deleteIconColor, disabledColor: disabledColor, selectedColor: selectedColor, secondarySelectedColor: secondarySelectedColor, labelPadding: labelPadding, padding: padding, shape: shape, labelStyle: labelStyle, secondaryLabelStyle: secondaryLabelStyle, brightness: brightness);
        }


        /// <Summary>
        /// Color to be used for the unselected, enabled chip's background.
        ///
        /// The default is light grey.
        /// </Summary>
        public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
        /// <Summary>
        /// The [Color] for the delete icon. The default is Color(0xde000000)
        /// (slightly transparent black) for light themes, and Color(0xdeffffff)
        /// (slightly transparent white) for dark themes.
        ///
        /// May be set to null, in which case the ambient [IconTheme.color] is used.
        /// </Summary>
        public virtual FlutterBinding.UI.Color DeleteIconColor { get; set; }
        /// <Summary>
        /// Color to be used for the chip's background indicating that it is disabled.
        ///
        /// The chip is disabled when [isEnabled] is false, or all three of
        /// [SelectableChipAttributes.onSelected], [TappableChipAttributes.onPressed],
        /// and [DeletableChipAttributes.onDelete] are null.
        ///
        /// It defaults to [Colors.black38].
        /// </Summary>
        public virtual FlutterBinding.UI.Color DisabledColor { get; set; }
        /// <Summary>
        /// Color to be used for the chip's background, indicating that it is
        /// selected.
        ///
        /// The chip is selected when [selected] is true.
        /// </Summary>
        public virtual FlutterBinding.UI.Color SelectedColor { get; set; }
        /// <Summary>
        /// An alternate color to be used for the chip's background, indicating that
        /// it is selected. For example, this color is used by [ChoiceChip] when the
        /// choice is selected.
        ///
        /// The chip is selected when [selected] is true.
        /// </Summary>
        public virtual FlutterBinding.UI.Color SecondarySelectedColor { get; set; }
        /// <Summary>
        /// Color of the chip's shadow when the elevation is greater than 0.
        ///
        /// If null, the chip defaults to [Colors.black].
        ///
        /// See also:
        ///
        ///  * [selectedShadowColor]
        /// </Summary>
        public virtual FlutterBinding.UI.Color ShadowColor { get; set; }
        /// <Summary>
        /// Color of the chip's shadow when the elevation is greater than 0 and the
        /// chip is selected.
        ///
        /// If null, the chip defaults to [Colors.black].
        ///
        /// See also:
        ///
        ///  * [shadowColor]
        /// </Summary>
        public virtual FlutterBinding.UI.Color SelectedShadowColor { get; set; }
        /// <Summary>
        /// Whether or not to show a check mark when [selected] is true.
        ///
        /// For instance, the [ChoiceChip] sets this to false so that it can be
        /// selected without showing the check mark.
        ///
        /// Defaults to true.
        /// </Summary>
        public virtual bool ShowCheckmark { get; set; }
        /// <Summary>
        /// Color of the chip's check mark when a check mark is visible.
        ///
        /// This will override the color set by the platform's brightness setting.
        /// </Summary>
        public virtual FlutterBinding.UI.Color CheckmarkColor { get; set; }
        /// <Summary>
        /// The padding around the [label] widget.
        ///
        /// By default, this is 4 logical pixels at the beginning and the end of the
        /// label, and zero on top and bottom.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get; set; }
        /// <Summary>
        /// The padding between the contents of the chip and the outside [shape].
        ///
        /// Defaults to 4 logical pixels on all sides.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        /// <Summary>
        /// The border to draw around the chip.
        ///
        /// Defaults to a [StadiumBorder]. Must not be null.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        /// <Summary>
        /// The style to be applied to the chip's label.
        ///
        /// This only has an effect on label widgets that respect the
        /// [DefaultTextStyle], such as [Text].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        /// <Summary>
        /// An alternate style to be applied to the chip's label. For example, this
        /// style is applied to the text of a selected [ChoiceChip].
        ///
        /// This only has an effect on label widgets that respect the
        /// [DefaultTextStyle], such as [Text].
        /// </Summary>
        public virtual FlutterSDK.Painting.Textstyle.TextStyle SecondaryLabelStyle { get; set; }
        /// <Summary>
        /// The brightness setting for this theme.
        ///
        /// This affects various base material color choices in the chip rendering.
        /// </Summary>
        public virtual Brightness Brightness { get; set; }
        /// <Summary>
        /// The elevation to be applied to the chip.
        ///
        /// If null, the chip defaults to 0.
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// The elevation to be applied to the chip during the press motion.
        ///
        /// If null, the chip defaults to 8.
        /// </Summary>
        public virtual double PressElevation { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Creates a copy of this object but with the given fields replaced with the
        /// new values.
        /// </Summary>
        public virtual FlutterSDK.Material.Chiptheme.ChipThemeData CopyWith(FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color deleteIconColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondarySelectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle secondaryLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), Brightness brightness = default(Brightness), double elevation = default(double), double pressElevation = default(double))
        {
            return new ChipThemeData(backgroundColor: backgroundColor ?? this.BackgroundColor, deleteIconColor: deleteIconColor ?? this.DeleteIconColor, disabledColor: disabledColor ?? this.DisabledColor, selectedColor: selectedColor ?? this.SelectedColor, secondarySelectedColor: secondarySelectedColor ?? this.SecondarySelectedColor, shadowColor: shadowColor ?? this.ShadowColor, selectedShadowColor: selectedShadowColor ?? this.SelectedShadowColor, checkmarkColor: checkmarkColor ?? this.CheckmarkColor, labelPadding: labelPadding ?? this.LabelPadding, padding: padding ?? this.Padding, shape: shape ?? this.Shape, labelStyle: labelStyle ?? this.LabelStyle, secondaryLabelStyle: secondaryLabelStyle ?? this.SecondaryLabelStyle, brightness: brightness ?? this.Brightness, elevation: elevation == default(double) ? this.elevation : elevation, pressElevation: pressElevation == default(double) ? this.pressElevation : pressElevation);
        }




        /// <Summary>
        /// Linearly interpolate between two chip themes.
        ///
        /// The arguments must not be null.
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Material.Chiptheme.ChipThemeData Lerp(FlutterSDK.Material.Chiptheme.ChipThemeData a, FlutterSDK.Material.Chiptheme.ChipThemeData b, double t)
        {

            if (a == null && b == null) return null;
            return new ChipThemeData(backgroundColor: Dart.UI.UiDefaultClass.Color.Lerp(a?.BackgroundColor, b?.BackgroundColor, t), deleteIconColor: Dart.UI.UiDefaultClass.Color.Lerp(a?.DeleteIconColor, b?.DeleteIconColor, t), disabledColor: Dart.UI.UiDefaultClass.Color.Lerp(a?.DisabledColor, b?.DisabledColor, t), selectedColor: Dart.UI.UiDefaultClass.Color.Lerp(a?.SelectedColor, b?.SelectedColor, t), secondarySelectedColor: Dart.UI.UiDefaultClass.Color.Lerp(a?.SecondarySelectedColor, b?.SecondarySelectedColor, t), shadowColor: Dart.UI.UiDefaultClass.Color.Lerp(a?.ShadowColor, b?.ShadowColor, t), selectedShadowColor: Dart.UI.UiDefaultClass.Color.Lerp(a?.SelectedShadowColor, b?.SelectedShadowColor, t), checkmarkColor: Dart.UI.UiDefaultClass.Color.Lerp(a?.CheckmarkColor, b?.CheckmarkColor, t), labelPadding: EdgeinsetsDefaultClass.EdgeInsetsGeometry.Lerp(a?.LabelPadding, b?.LabelPadding, t), padding: EdgeinsetsDefaultClass.EdgeInsetsGeometry.Lerp(a?.Padding, b?.Padding, t), shape: BordersDefaultClass.ShapeBorder.Lerp(a?.Shape, b?.Shape, t), labelStyle: TextstyleDefaultClass.TextStyle.Lerp(a?.LabelStyle, b?.LabelStyle, t), secondaryLabelStyle: TextstyleDefaultClass.TextStyle.Lerp(a?.SecondaryLabelStyle, b?.SecondaryLabelStyle, t), brightness: t < 0.5 ? a?.Brightness ?? Brightness.Light : b?.Brightness ?? Brightness.Light, elevation: Dart.UI.UiDefaultClass.LerpDouble(a?.Elevation, b?.Elevation, t), pressElevation: Dart.UI.UiDefaultClass.LerpDouble(a?.PressElevation, b?.PressElevation, t));
        }




        public new bool Equals(@Object other)
        {
            if (Dart.CoreDefaultClass.Identical(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return other is ChipThemeData && other.BackgroundColor == BackgroundColor && other.DeleteIconColor == DeleteIconColor && other.DisabledColor == DisabledColor && other.SelectedColor == SelectedColor && other.SecondarySelectedColor == SecondarySelectedColor && other.ShadowColor == ShadowColor && other.SelectedShadowColor == SelectedShadowColor && other.CheckmarkColor == CheckmarkColor && other.LabelPadding == LabelPadding && other.Padding == Padding && other.Shape == Shape && other.LabelStyle == LabelStyle && other.SecondaryLabelStyle == SecondaryLabelStyle && other.Brightness == Brightness && other.Elevation == Elevation && other.PressElevation == PressElevation;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            ThemeData defaultTheme = ThemeData.Fallback();
            ChipThemeData defaultData = ChipThemeData.FromDefaults(secondaryColor: defaultTheme.PrimaryColor, brightness: defaultTheme.Brightness, labelStyle: defaultTheme.TextTheme.BodyText1);
            properties.Add(new ColorProperty("backgroundColor", BackgroundColor, defaultValue: defaultData.BackgroundColor));
            properties.Add(new ColorProperty("deleteIconColor", DeleteIconColor, defaultValue: defaultData.DeleteIconColor));
            properties.Add(new ColorProperty("disabledColor", DisabledColor, defaultValue: defaultData.DisabledColor));
            properties.Add(new ColorProperty("selectedColor", SelectedColor, defaultValue: defaultData.SelectedColor));
            properties.Add(new ColorProperty("secondarySelectedColor", SecondarySelectedColor, defaultValue: defaultData.SecondarySelectedColor));
            properties.Add(new ColorProperty("shadowColor", ShadowColor, defaultValue: defaultData.ShadowColor));
            properties.Add(new ColorProperty("selectedShadowColor", SelectedShadowColor, defaultValue: defaultData.SelectedShadowColor));
            properties.Add(new ColorProperty("checkMarkColor", CheckmarkColor, defaultValue: defaultData.CheckmarkColor));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("labelPadding", LabelPadding, defaultValue: defaultData.LabelPadding));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding, defaultValue: defaultData.Padding));
            properties.Add(new DiagnosticsProperty<ShapeBorder>("shape", Shape, defaultValue: defaultData.Shape));
            properties.Add(new DiagnosticsProperty<TextStyle>("labelStyle", LabelStyle, defaultValue: defaultData.LabelStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("secondaryLabelStyle", SecondaryLabelStyle, defaultValue: defaultData.SecondaryLabelStyle));
            properties.Add(new EnumProperty<Brightness>("brightness", Brightness, defaultValue: defaultData.Brightness));
            properties.Add(new DoubleProperty("elevation", Elevation, defaultValue: defaultData.Elevation));
            properties.Add(new DoubleProperty("pressElevation", PressElevation, defaultValue: defaultData.PressElevation));
        }



    }

}
