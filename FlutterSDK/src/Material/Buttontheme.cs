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
namespace FlutterSDK.Material.Buttontheme
{
    internal static class ButtonthemeDefaultClass
    {
    }

    /// <Summary>
    /// Used with [ButtonThemeData] to configure the color and geometry of buttons.
    ///
    /// A button theme can be specified as part of the overall Material theme
    /// using [ThemeData.buttonTheme]. The Material theme's button theme data
    /// can be overridden with [ButtonTheme].
    ///
    /// The actual appearance of buttons depends on the button theme, the
    /// button's enabled state, its elevation (if any), and the overall [Theme].
    ///
    /// See also:
    ///
    ///  * [FlatButton] [RaisedButton], and [OutlineButton], which are styled
    ///    based on the ambient button theme.
    ///  * [RawMaterialButton], which can be used to configure a button that doesn't
    ///    depend on any inherited themes.
    /// </Summary>
    public class ButtonTheme : FlutterSDK.Widgets.Inheritedtheme.InheritedTheme
    {
        #region constructors
        public ButtonTheme(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior layoutBehavior = default(FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior), double minWidth = 88.0, double height = 36.0, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), bool alignedDropdown = false, FlutterBinding.UI.Color buttonColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
    
}
    public static ButtonTheme FromButtonThemeData(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Buttontheme.ButtonThemeData data = default(FlutterSDK.Material.Buttontheme.ButtonThemeData), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))

}
public static ButtonTheme Bar(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), double minWidth = 64.0, double height = 36.0, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), bool alignedDropdown = false, FlutterBinding.UI.Color buttonColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior layoutBehavior = default(FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior))

}
#endregion

#region fields
public virtual FlutterSDK.Material.Buttontheme.ButtonThemeData Data { get; set; }
#endregion

#region methods

/// <Summary>
/// The closest instance of this class that encloses the given context.
///
/// Typical usage is as follows:
///
/// ```dart
/// ButtonThemeData theme = ButtonTheme.of(context);
/// ```
/// </Summary>
public virtual FlutterSDK.Material.Buttontheme.ButtonThemeData Of(FlutterSDK.Widgets.Framework.BuildContext context)
{
    ButtonTheme inheritedButtonTheme = context.DependOnInheritedWidgetOfExactType();
    ButtonThemeData buttonTheme = inheritedButtonTheme?.Data;
    if (buttonTheme?.ColorScheme == null)
    {
        ThemeData theme = ThemeDefaultClass.Theme.Of(context);
        buttonTheme = (buttonTheme == null ? theme.ButtonTheme : buttonTheme);
        if (buttonTheme.ColorScheme == null)
        {
            buttonTheme = buttonTheme.CopyWith(colorScheme: theme.ButtonTheme.ColorScheme ?? theme.ColorScheme);

        }

    }

    return buttonTheme;
}




public new FlutterSDK.Widgets.Framework.Widget Wrap(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.Widget child)
{
    ButtonTheme ancestorTheme = context.FindAncestorWidgetOfExactType();
    return Dart:coreDefaultClass.Identical(this, ancestorTheme) ? child : ButtonTheme.FromButtonThemeData(data: Data, child: child);
}




public new bool UpdateShouldNotify(FlutterSDK.Material.Buttontheme.ButtonTheme oldWidget) => Data != oldWidget.Data;

public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) => Data != oldWidget.Data;


#endregion
}


/// <Summary>
/// Used with [ButtonTheme] to configure the color and geometry of buttons.
///
/// A button theme can be specified as part of the overall Material theme
/// using [ThemeData.buttonTheme]. The Material theme's button theme data
/// can be overridden with [ButtonTheme].
/// </Summary>
public class ButtonThemeData : IDiagnosticable
{
    #region constructors
    public ButtonThemeData(FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), double minWidth = 88.0, double height = 36.0, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior layoutBehavior = default(FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior), bool alignedDropdown = false, FlutterBinding.UI.Color buttonColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize))
    : base()

}
#endregion

#region fields
public virtual double MinWidth { get; set; }
public virtual double Height { get; set; }
public virtual FlutterSDK.Material.Buttontheme.ButtonTextTheme TextTheme { get; set; }
public virtual FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior LayoutBehavior { get; set; }
internal virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry _Padding { get; set; }
internal virtual FlutterSDK.Painting.Borders.ShapeBorder _Shape { get; set; }
public virtual bool AlignedDropdown { get; set; }
internal virtual FlutterBinding.UI.Color _ButtonColor { get; set; }
internal virtual FlutterBinding.UI.Color _DisabledColor { get; set; }
internal virtual FlutterBinding.UI.Color _FocusColor { get; set; }
internal virtual FlutterBinding.UI.Color _HoverColor { get; set; }
internal virtual FlutterBinding.UI.Color _HighlightColor { get; set; }
internal virtual FlutterBinding.UI.Color _SplashColor { get; set; }
public virtual FlutterSDK.Material.Colorscheme.ColorScheme ColorScheme { get; set; }
internal virtual FlutterSDK.Material.Themedata.MaterialTapTargetSize _MaterialTapTargetSize { get; set; }
public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

/// <Summary>
/// The [button]'s overall brightness.
///
/// Returns the button's [MaterialButton.colorBrightness] if it is non-null,
/// otherwise the color scheme's [ColorScheme.brightness] is returned.
/// </Summary>
public virtual Brightness GetBrightness(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    return button.ColorBrightness ?? ColorScheme.Brightness;
}




/// <Summary>
/// Defines the [button]'s base colors, and the defaults for the button's
/// minimum size, internal padding, and shape.
///
/// Despite the name, this property is not the [TextTheme] whose
/// [TextTheme.button] is used as the button text's [TextStyle].
/// </Summary>
public virtual FlutterSDK.Material.Buttontheme.ButtonTextTheme GetTextTheme(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    return button.TextTheme ?? TextTheme;
}




/// <Summary>
/// The foreground color of the [button]'s text and icon when
/// [MaterialButton.onPressed] is null (when MaterialButton.enabled is false).
///
/// Returns the button's [MaterialButton.disabledColor] if it is non-null.
/// Otherwise the color scheme's [ColorScheme.onSurface] color is returned
/// with its opacity set to 0.38.
///
/// If [MaterialButton.textColor] is a [MaterialStateProperty<Color>], it will be
/// used as the `disabledTextColor`. It will be resolved in the [MaterialState.disabled] state.
/// </Summary>
public virtual Color GetDisabledTextColor(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (button.TextColor is MaterialStateProperty<Color>) return button.TextColor;
    if (button.DisabledTextColor != null) return button.DisabledTextColor;
    return ColorScheme.OnSurface.WithOpacity(0.38);
}




/// <Summary>
/// The [button]'s background color when [MaterialButton.onPressed] is null
/// (when [MaterialButton.enabled] is false).
///
/// Returns the button's [MaterialButton.disabledColor] if it is non-null.
///
/// Otherwise the value of the `disabledColor` constructor parameter
/// is returned, if it is non-null.
///
/// Otherwise the color scheme's [ColorScheme.onSurface] color is returned
/// with its opacity set to 0.38.
/// </Summary>
public virtual Color GetDisabledFillColor(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (button.DisabledColor != null) return button.DisabledColor;
    if (_DisabledColor != null) return _DisabledColor;
    return ColorScheme.OnSurface.WithOpacity(0.38);
}




/// <Summary>
/// The button's background fill color or null for buttons that don't have
/// a background color.
///
/// Returns [MaterialButton.color] if it is non-null and the button
/// is enabled.
///
/// Otherwise, returns [MaterialButton.disabledColor] if it is non-null and
/// the button is disabled.
///
/// Otherwise, if button is a [FlatButton] or an [OutlineButton] then null is
/// returned.
///
/// Otherwise, if button is a [RaisedButton], returns the `buttonColor`
/// constructor parameter if it was non-null and the button is enabled.
///
/// Otherwise the fill color depends on the value of [getTextTheme].
///
///  * [ButtonTextTheme.normal] or [ButtonTextTheme.accent], the
///    color scheme's [ColorScheme.primary] color if the [button] is enabled
///    the value of [getDisabledFillColor] otherwise.
///  * [ButtonTextTheme.primary], if the [button] is enabled then the value
///    of the `buttonColor` constructor parameter if it is non-null,
///    otherwise the color scheme's ColorScheme.primary color. If the button
///    is not enabled then the colorScheme's [ColorScheme.onSurface] color
///    with opacity 0.12.
/// </Summary>
public virtual Color GetFillColor(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    Color fillColor = button.Enabled ? button.Color : button.DisabledColor;
    if (fillColor != null) return fillColor;
    if (button is FlatButton || button is OutlineButton || button.GetType() == MaterialbuttonDefaultClass.MaterialButton) return null;
    if (button.Enabled && button is RaisedButton && _ButtonColor != null) return _ButtonColor;
    switch (GetTextTheme(button)) { case ButtonTextTheme.Normal: case ButtonTextTheme.Accent: return button.Enabled ? ColorScheme.Primary : GetDisabledFillColor(button); case ButtonTextTheme.Primary: return button.Enabled ? _ButtonColor ?? ColorScheme.Primary : ColorScheme.OnSurface.WithOpacity(0.12); }

    return null;
}




/// <Summary>
/// The foreground color of the [button]'s text and icon.
///
/// If [button] is not [MaterialButton.enabled], the value of
/// [getDisabledTextColor] is returned. If the button is enabled and
/// [buttonTextColor] is non-null, then [buttonTextColor] is returned.
///
/// Otherwise the text color depends on the value of [getTextTheme]
/// and [getBrightness].
///
///  * [ButtonTextTheme.normal]: [Colors.white] is used if [getBrightness]
///    resolves to [Brightness.dark]. [Colors.black87] is used if
///    [getBrightness] resolves to [Brightness.light].
///  * [ButtonTextTheme.accent]: [colorScheme.secondary].
///  * [ButtonTextTheme.primary]: If [getFillColor] is dark then [Colors.white],
///    otherwise if [button] is a [FlatButton] or an [OutlineButton] then
///    [colorScheme.primary], otherwise [Colors.black].
/// </Summary>
public virtual Color GetTextColor(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (!button.Enabled) return GetDisabledTextColor(button);
    if (button.TextColor != null) return button.TextColor;
    switch (GetTextTheme(button)) { case ButtonTextTheme.Normal: return GetBrightness(button) == Brightness.Dark ? ColorsDefaultClass.Colors.White : ColorsDefaultClass.Colors.Black87; case ButtonTextTheme.Accent: return ColorScheme.Secondary; case ButtonTextTheme.Primary: Color fillColor = GetFillColor(button); bool fillIsDark = fillColor != null ? ThemedataDefaultClass.ThemeData.EstimateBrightnessForColor(fillColor) == Brightness.Dark : GetBrightness(button) == Brightness.Dark; if (fillIsDark) return ColorsDefaultClass.Colors.White; if (button is FlatButton || button is OutlineButton) return ColorScheme.Primary; return ColorsDefaultClass.Colors.Black; }

    return null;
}




/// <Summary>
/// The color of the ink "splash" overlay that appears when the (enabled)
/// [button] is tapped.
///
/// Returns the button's [MaterialButton.splashColor] if it is non-null.
///
/// Otherwise, returns the value of the `splashColor` constructor parameter
/// it is non-null and [button] is a [RaisedButton] or an [OutlineButton].
///
/// Otherwise, returns the value of the `splashColor` constructor parameter
/// if it is non-null and [button] is a [FlatButton] and
/// [getTextTheme] is not [ButtonTextTheme.primary]
///
/// Otherwise, returns [getTextColor] with an opacity of 0.12.
/// </Summary>
public virtual Color GetSplashColor(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (button.SplashColor != null) return button.SplashColor;
    if (_SplashColor != null && (button is RaisedButton || button is OutlineButton)) return _SplashColor;
    if (_SplashColor != null && button is FlatButton)
    {
        switch (GetTextTheme(((FlatButton)button))) { case ButtonTextTheme.Normal: case ButtonTextTheme.Accent: return _SplashColor; case ButtonTextTheme.Primary: break; }
    }

    return GetTextColor(button).WithOpacity(0.12);
}




/// <Summary>
/// The fill color of the button when it has input focus.
///
/// Returns the button's [MaterialButton.focusColor] if it is non-null.
/// Otherwise the focus color depends on [getTextTheme]:
///
///  * [ButtonTextTheme.normal], [ButtonTextTheme.accent]: returns the
///    value of the `focusColor` constructor parameter if it is non-null,
///    otherwise the value of [getTextColor] with opacity 0.12.
///  * [ButtonTextTheme.primary], returns [Colors.transparent].
/// </Summary>
public virtual Color GetFocusColor(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    return button.FocusColor ?? _FocusColor ?? GetTextColor(button).WithOpacity(0.12);
}




/// <Summary>
/// The fill color of the button when it has input focus.
///
/// Returns the button's [MaterialButton.focusColor] if it is non-null.
/// Otherwise the focus color depends on [getTextTheme]:
///
///  * [ButtonTextTheme.normal], [ButtonTextTheme.accent],
///    [ButtonTextTheme.primary]: returns the value of the `focusColor`
///    constructor parameter if it is non-null, otherwise the value of
///    [getTextColor] with opacity 0.04.
/// </Summary>
public virtual Color GetHoverColor(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    return button.HoverColor ?? _HoverColor ?? GetTextColor(button).WithOpacity(0.04);
}




/// <Summary>
/// The color of the overlay that appears when the [button] is pressed.
///
/// Returns the button's [MaterialButton.highlightColor] if it is non-null.
/// Otherwise the highlight color depends on [getTextTheme]:
///
///  * [ButtonTextTheme.normal], [ButtonTextTheme.accent]: returns the
///    value of the `highlightColor` constructor parameter if it is non-null,
///    otherwise the value of [getTextColor] with opacity 0.16.
///  * [ButtonTextTheme.primary], returns [Colors.transparent].
/// </Summary>
public virtual Color GetHighlightColor(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (button.HighlightColor != null) return button.HighlightColor;
    switch (GetTextTheme(button)) { case ButtonTextTheme.Normal: case ButtonTextTheme.Accent: return _HighlightColor ?? GetTextColor(button).WithOpacity(0.16); case ButtonTextTheme.Primary: return ColorsDefaultClass.Colors.Transparent; }

    return ColorsDefaultClass.Colors.Transparent;
}




/// <Summary>
/// The [button]'s elevation when it is enabled and has not been pressed.
///
/// Returns the button's [MaterialButton.elevation] if it is non-null.
///
/// If button is a [FlatButton] then elevation is 0.0, otherwise it is 2.0.
/// </Summary>
public virtual double GetElevation(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (button.Elevation != null) return button.Elevation;
    if (button is FlatButton) return 0.0;
    return 2.0;
}




/// <Summary>
/// The [button]'s elevation when it is enabled and has focus.
///
/// Returns the button's [MaterialButton.focusElevation] if it is non-null.
///
/// If button is a [FlatButton] or an [OutlineButton] then the focus
/// elevation is 0.0, otherwise the highlight elevation is 4.0.
/// </Summary>
public virtual double GetFocusElevation(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (button.FocusElevation != null) return button.FocusElevation;
    if (button is FlatButton) return 0.0;
    if (button is OutlineButton) return 0.0;
    return 4.0;
}




/// <Summary>
/// The [button]'s elevation when it is enabled and has focus.
///
/// Returns the button's [MaterialButton.hoverElevation] if it is non-null.
///
/// If button is a [FlatButton] or an [OutlineButton] then the hover
/// elevation is 0.0, otherwise the highlight elevation is 4.0.
/// </Summary>
public virtual double GetHoverElevation(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (button.HoverElevation != null) return button.HoverElevation;
    if (button is FlatButton) return 0.0;
    if (button is OutlineButton) return 0.0;
    return 4.0;
}




/// <Summary>
/// The [button]'s elevation when it is enabled and has been pressed.
///
/// Returns the button's [MaterialButton.highlightElevation] if it is non-null.
///
/// If button is a [FlatButton] or an [OutlineButton] then the highlight
/// elevation is 0.0, otherwise the highlight elevation is 8.0.
/// </Summary>
public virtual double GetHighlightElevation(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (button.HighlightElevation != null) return button.HighlightElevation;
    if (button is FlatButton) return 0.0;
    if (button is OutlineButton) return 0.0;
    return 8.0;
}




/// <Summary>
/// The [button]'s elevation when [MaterialButton.onPressed] is null (when
/// MaterialButton.enabled is false).
///
/// Returns the button's [MaterialButton.elevation] if it is non-null.
///
/// Otherwise the disabled elevation is 0.0.
/// </Summary>
public virtual double GetDisabledElevation(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (button.DisabledElevation != null) return button.DisabledElevation;
    return 0.0;
}




/// <Summary>
/// Padding for the [button]'s child (typically the button's label).
///
/// Returns the button's [MaterialButton.padding] if it is non-null.
///
/// If this is a button constructed with [RaisedButton.icon] or
/// [FlatButton.icon] or [OutlineButton.icon] then the padding is:
/// `EdgeInsetsDirectional.only(start: 12.0, end: 16.0)`.
///
/// Otherwise, returns [padding] if it is non-null.
///
/// Otherwise, returns horizontal padding of 24.0 on the left and right if
/// [getTextTheme] is [ButtonTextTheme.primary], 16.0 on the left and right
/// otherwise.
/// </Summary>
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry GetPadding(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    if (button.Padding != null) return button.Padding;
    if (button is MaterialButtonWithIconMixin) return EdgeInsetsDirectional.Only(start: 12.0, end: 16.0);
    if (_Padding != null) return _Padding;
    switch (GetTextTheme(button)) { case ButtonTextTheme.Normal: case ButtonTextTheme.Accent: return EdgeInsets.Symmetric(horizontal: 16.0); case ButtonTextTheme.Primary: return EdgeInsets.Symmetric(horizontal: 24.0); }

    return EdgeinsetsDefaultClass.EdgeInsets.Zero;
}




/// <Summary>
/// The shape of the [button]'s [Material].
///
/// Returns the button's [MaterialButton.shape] if it is non-null, otherwise
/// [shape] is returned.
/// </Summary>
public virtual FlutterSDK.Painting.Borders.ShapeBorder GetShape(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    return button.Shape ?? Shape;
}




/// <Summary>
/// The duration of the [button]'s highlight animation.
///
/// Returns the button's [MaterialButton.animationDuration] it if is non-null,
/// otherwise 200ms.
/// </Summary>
public virtual TimeSpan GetAnimationDuration(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    return button.AnimationDuration ?? ConstantsDefaultClass.KThemeChangeDuration;
}




/// <Summary>
/// The [BoxConstraints] that the define the [button]'s size.
///
/// By default this method just returns [constraints]. Subclasses
/// could override this method to return a value that was,
/// for example, based on the button's type.
/// </Summary>
public virtual FlutterSDK.Rendering.Box.BoxConstraints GetConstraints(FlutterSDK.Material.Materialbutton.MaterialButton button) => Constraints;



/// <Summary>
/// The minimum size of the [button]'s tap target.
///
/// Returns the button's [MaterialButton.tapTargetSize] if it is non-null.
///
/// Otherwise the value of the [materialTapTargetSize] constructor
/// parameter is returned if that's non-null.
///
/// Otherwise [MaterialTapTargetSize.padded] is returned.
/// </Summary>
public virtual FlutterSDK.Material.Themedata.MaterialTapTargetSize GetMaterialTapTargetSize(FlutterSDK.Material.Materialbutton.MaterialButton button)
{
    return button.MaterialTapTargetSize ?? _MaterialTapTargetSize ?? MaterialTapTargetSize.Padded;
}




/// <Summary>
/// Creates a copy of this button theme data object with the matching fields
/// replaced with the non-null parameter values.
/// </Summary>
public virtual FlutterSDK.Material.Buttontheme.ButtonThemeData CopyWith(FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior layoutBehavior = default(FlutterSDK.Material.Buttontheme.ButtonBarLayoutBehavior), double minWidth = default(double), double height = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), bool alignedDropdown = default(bool), FlutterBinding.UI.Color buttonColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Colorscheme.ColorScheme colorScheme = default(FlutterSDK.Material.Colorscheme.ColorScheme), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize))
{
    return new ButtonThemeData(textTheme: textTheme ?? this.TextTheme, layoutBehavior: layoutBehavior ?? this.LayoutBehavior, minWidth: minWidth == default(double) ? this.minWidth : minWidth, height: height == default(double) ? this.height : height, padding: padding ?? this.Padding, shape: shape ?? this.Shape, alignedDropdown: alignedDropdown ?? this.AlignedDropdown, buttonColor: buttonColor ?? _ButtonColor, disabledColor: disabledColor ?? _DisabledColor, focusColor: focusColor ?? _FocusColor, hoverColor: hoverColor ?? _HoverColor, highlightColor: highlightColor ?? _HighlightColor, splashColor: splashColor ?? _SplashColor, colorScheme: colorScheme ?? this.ColorScheme, materialTapTargetSize: materialTapTargetSize ?? _MaterialTapTargetSize);
}




public new bool Equals(@Object other)
{
    if (other.GetType() != GetType()) return false;
    return other is ButtonThemeData && other.TextTheme == TextTheme && other.MinWidth == MinWidth && other.Height == Height && other.Padding == Padding && other.Shape == Shape && other.AlignedDropdown == AlignedDropdown && other._ButtonColor == _ButtonColor && other._DisabledColor == _DisabledColor && other._FocusColor == _FocusColor && other._HoverColor == _HoverColor && other._HighlightColor == _HighlightColor && other._SplashColor == _SplashColor && other.ColorScheme == ColorScheme && other._MaterialTapTargetSize == _MaterialTapTargetSize;
}




public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
{
    base.DebugFillProperties(properties);
    ButtonThemeData defaultTheme = new ButtonThemeData();
    properties.Add(new EnumProperty<ButtonTextTheme>("textTheme", TextTheme, defaultValue: defaultTheme.TextTheme));
    properties.Add(new DoubleProperty("minWidth", MinWidth, defaultValue: defaultTheme.MinWidth));
    properties.Add(new DoubleProperty("height", Height, defaultValue: defaultTheme.Height));
    properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding, defaultValue: defaultTheme.Padding));
    properties.Add(new DiagnosticsProperty<ShapeBorder>("shape", Shape, defaultValue: defaultTheme.Shape));
    properties.Add(new FlagProperty("alignedDropdown", value: AlignedDropdown, defaultValue: defaultTheme.AlignedDropdown, ifTrue: "dropdown width matches button"));
    properties.Add(new ColorProperty("buttonColor", _ButtonColor, defaultValue: null));
    properties.Add(new ColorProperty("disabledColor", _DisabledColor, defaultValue: null));
    properties.Add(new ColorProperty("focusColor", _FocusColor, defaultValue: null));
    properties.Add(new ColorProperty("hoverColor", _HoverColor, defaultValue: null));
    properties.Add(new ColorProperty("highlightColor", _HighlightColor, defaultValue: null));
    properties.Add(new ColorProperty("splashColor", _SplashColor, defaultValue: null));
    properties.Add(new DiagnosticsProperty<ColorScheme>("colorScheme", ColorScheme, defaultValue: defaultTheme.ColorScheme));
    properties.Add(new DiagnosticsProperty<MaterialTapTargetSize>("materialTapTargetSize", _MaterialTapTargetSize, defaultValue: null));
}



#endregion
}


/// <Summary>
/// Used with [ButtonTheme] and [ButtonThemeData] to define a button's base
/// colors, and the defaults for the button's minimum size, internal padding,
/// and shape.
///
/// See also:
///
///  * [RaisedButton], [FlatButton], [OutlineButton], which are configured
///    based on the ambient [ButtonTheme].
/// </Summary>
public enum ButtonTextTheme
{

    /// <Summary>
    /// Button text is black or white depending on [ThemeData.brightness].
    /// </Summary>
    Normal,
    /// <Summary>
    /// Button text is [ThemeData.accentColor].
    /// </Summary>
    Accent,
    /// <Summary>
    /// Button text is based on [ThemeData.primaryColor].
    /// </Summary>
    Primary,
}


/// <Summary>
/// Used with [ButtonTheme] and [ButtonThemeData] to define how the button bar
/// should size itself with either constraints or internal padding.
/// </Summary>
public enum ButtonBarLayoutBehavior
{

    /// <Summary>
    /// Button bars will be constrained to a minimum height of 52.
    ///
    /// This setting is require to create button bars which conform to the
    /// material specification.
    /// </Summary>
    Constrained,
    /// <Summary>
    /// Button bars will calculate their padding from the button theme padding.
    /// </Summary>
    Padded,
}

}
