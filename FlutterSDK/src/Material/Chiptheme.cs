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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
        #region constructors
        public ChipTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Chiptheme.ChipThemeData data = default(FlutterSDK.Material.Chiptheme.ChipThemeData), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Material.Chiptheme.ChipThemeData Data { get; set; }
    #endregion

    #region methods

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
        return Dart:coreDefaultClass.Identical(this, ancestorTheme) ? child : new ChipTheme(data: Data, child: child);
    }




    public new bool UpdateShouldNotify(FlutterSDK.Material.Chiptheme.ChipTheme oldWidget) => Data != oldWidget.Data;

    public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => Data != oldWidget.Data;


    #endregion
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
    #region constructors
    public ChipThemeData(FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color deleteIconColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondarySelectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), bool showCheckmark = default(bool), FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle secondaryLabelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), Brightness brightness = default(Brightness), double elevation = default(double), double pressElevation = default(double))
    : base()

}
public static ChipThemeData FromDefaults(Brightness brightness = default(Brightness), FlutterBinding.UI.Color primaryColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color secondaryColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle))





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


#endregion

#region fields
public virtual FlutterBinding.UI.Color BackgroundColor { get; set; }
public virtual FlutterBinding.UI.Color DeleteIconColor { get; set; }
public virtual FlutterBinding.UI.Color DisabledColor { get; set; }
public virtual FlutterBinding.UI.Color SelectedColor { get; set; }
public virtual FlutterBinding.UI.Color SecondarySelectedColor { get; set; }
public virtual FlutterBinding.UI.Color ShadowColor { get; set; }
public virtual FlutterBinding.UI.Color SelectedShadowColor { get; set; }
public virtual bool ShowCheckmark { get; set; }
public virtual FlutterBinding.UI.Color CheckmarkColor { get; set; }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get; set; }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
public virtual FlutterSDK.Painting.Textstyle.TextStyle SecondaryLabelStyle { get; set; }
public virtual Brightness Brightness { get; set; }
public virtual double Elevation { get; set; }
public virtual double PressElevation { get; set; }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

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
    return new ChipThemeData(backgroundColor: Dart:uiDefaultClass.Color.Lerp(a?.BackgroundColor, b?.BackgroundColor, t), deleteIconColor: Dart:uiDefaultClass.Color.Lerp(a?.DeleteIconColor, b?.DeleteIconColor, t), disabledColor: Dart:uiDefaultClass.Color.Lerp(a?.DisabledColor, b?.DisabledColor, t), selectedColor: Dart:uiDefaultClass.Color.Lerp(a?.SelectedColor, b?.SelectedColor, t), secondarySelectedColor: Dart:uiDefaultClass.Color.Lerp(a?.SecondarySelectedColor, b?.SecondarySelectedColor, t), shadowColor: Dart:uiDefaultClass.Color.Lerp(a?.ShadowColor, b?.ShadowColor, t), selectedShadowColor: Dart:uiDefaultClass.Color.Lerp(a?.SelectedShadowColor, b?.SelectedShadowColor, t), checkmarkColor: Dart:uiDefaultClass.Color.Lerp(a?.CheckmarkColor, b?.CheckmarkColor, t), labelPadding: EdgeinsetsDefaultClass.EdgeInsetsGeometry.Lerp(a?.LabelPadding, b?.LabelPadding, t), padding: EdgeinsetsDefaultClass.EdgeInsetsGeometry.Lerp(a?.Padding, b?.Padding, t), shape: BordersDefaultClass.ShapeBorder.Lerp(a?.Shape, b?.Shape, t), labelStyle: TextstyleDefaultClass.TextStyle.Lerp(a?.LabelStyle, b?.LabelStyle, t), secondaryLabelStyle: TextstyleDefaultClass.TextStyle.Lerp(a?.SecondaryLabelStyle, b?.SecondaryLabelStyle, t), brightness: t < 0.5 ? a?.Brightness ?? Brightness.Light : b?.Brightness ?? Brightness.Light, elevation: Dart:uiDefaultClass.LerpDouble(a?.Elevation, b?.Elevation, t), pressElevation: Dart:uiDefaultClass.LerpDouble(a?.PressElevation, b?.PressElevation, t));
}




public new bool Equals(@Object other)
{
    if (Dart:coreDefaultClass.Identical(this, other)){
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



#endregion
}

}
