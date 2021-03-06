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
namespace FlutterSDK.Material.Materialbutton
{
    internal static class MaterialbuttonDefaultClass
    {
    }

    public interface IMaterialButtonWithIconMixin { }

    public class MaterialButtonWithIconMixin
    {
    }
    public static class MaterialButtonWithIconMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IMaterialButtonWithIconMixin, MaterialButtonWithIconMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IMaterialButtonWithIconMixin, MaterialButtonWithIconMixin>();
        static MaterialButtonWithIconMixin GetOrCreate(IMaterialButtonWithIconMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new MaterialButtonWithIconMixin();
                _table.Add(instance, value);
            }
            return (MaterialButtonWithIconMixin)value;
        }
    }


    /// <Summary>
    /// A utility class for building Material buttons that depend on the
    /// ambient [ButtonTheme] and [Theme].
    ///
    /// The button's size will expand to fit the child widget, if necessary.
    ///
    /// MaterialButtons whose [onPressed] and [onLongPress] callbacks are null will be disabled. To have
    /// an enabled button, make sure to pass a non-null value for [onPressed] or [onLongPress].
    ///
    /// Rather than using this class directly, consider using [FlatButton],
    /// [OutlineButton], or [RaisedButton], which configure this class with
    /// appropriate defaults that match the material design specification.
    ///
    /// To create a button directly, without inheriting theme defaults, use
    /// [RawMaterialButton].
    ///
    /// If you want an ink-splash effect for taps, but don't want to use a button,
    /// consider using [InkWell] directly.
    ///
    /// See also:
    ///
    ///  * [IconButton], to create buttons that contain icons rather than text.
    /// </Summary>
    public class MaterialButton : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        /// <Summary>
        /// Creates a material button.
        ///
        /// Rather than creating a material button directly, consider using
        /// [FlatButton] or [RaisedButton]. To create a custom Material button
        /// consider using [RawMaterialButton].
        ///
        /// The [autofocus] and [clipBehavior] arguments must not be null.
        /// Additionally,  [elevation], [hoverElevation], [focusElevation],
        /// [highlightElevation], and [disabledElevation] must be non-negative, if
        /// specified.
        /// </Summary>
        public MaterialButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Material.Buttontheme.ButtonTextTheme textTheme = default(FlutterSDK.Material.Buttontheme.ButtonTextTheme), FlutterBinding.UI.Color textColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledTextColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), Brightness colorBrightness = default(Brightness), double elevation = default(double), double focusElevation = default(double), double hoverElevation = default(double), double highlightElevation = default(double), double disabledElevation = default(double), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), TimeSpan animationDuration = default(TimeSpan), double minWidth = default(double), double height = default(double), bool enableFeedback = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.OnPressed = onPressed;
            this.OnLongPress = onLongPress;
            this.OnHighlightChanged = onHighlightChanged;
            this.TextTheme = textTheme;
            this.TextColor = textColor;
            this.DisabledTextColor = disabledTextColor;
            this.Color = color;
            this.DisabledColor = disabledColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.HighlightColor = highlightColor;
            this.SplashColor = splashColor;
            this.ColorBrightness = colorBrightness;
            this.Elevation = elevation;
            this.FocusElevation = focusElevation;
            this.HoverElevation = hoverElevation;
            this.HighlightElevation = highlightElevation;
            this.DisabledElevation = disabledElevation;
            this.Padding = padding;
            this.VisualDensity = visualDensity;
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.AnimationDuration = animationDuration;
            this.MinWidth = minWidth;
            this.Height = height;
            this.EnableFeedback = enableFeedback;
            this.Child = child;
        }
        /// <Summary>
        /// The callback that is called when the button is tapped or otherwise activated.
        ///
        /// If this callback and [onLongPress] are null, then the button will be disabled.
        ///
        /// See also:
        ///
        ///  * [enabled], which is true if the button is enabled.
        /// </Summary>
        public virtual VoidCallback OnPressed { get; set; }
        /// <Summary>
        /// The callback that is called when the button is long-pressed.
        ///
        /// If this callback and [onPressed] are null, then the button will be disabled.
        ///
        /// See also:
        ///
        ///  * [enabled], which is true if the button is enabled.
        /// </Summary>
        public virtual VoidCallback OnLongPress { get; set; }
        /// <Summary>
        /// Called by the underlying [InkWell] widget's [InkWell.onHighlightChanged]
        /// callback.
        ///
        /// If [onPressed] changes from null to non-null while a gesture is ongoing,
        /// this can fire during the build phase (in which case calling
        /// [State.setState] is not allowed).
        /// </Summary>
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnHighlightChanged { get; set; }
        /// <Summary>
        /// Defines the button's base colors, and the defaults for the button's minimum
        /// size, internal padding, and shape.
        ///
        /// Defaults to `ButtonTheme.of(context).textTheme`.
        /// </Summary>
        public virtual FlutterSDK.Material.Buttontheme.ButtonTextTheme TextTheme { get; set; }
        /// <Summary>
        /// The color to use for this button's text.
        ///
        /// The button's [Material.textStyle] will be the current theme's button
        /// text style, [ThemeData.textTheme.button], configured with this color.
        ///
        /// The default text color depends on the button theme's text theme,
        /// [ButtonThemeData.textTheme].
        ///
        /// If [textColor] is a [MaterialStateProperty<Color>], [disabledTextColor]
        /// will be ignored.
        ///
        /// See also:
        ///
        ///  * [disabledTextColor], the text color to use when the button has been
        ///    disabled.
        /// </Summary>
        public virtual FlutterBinding.UI.Color TextColor { get; set; }
        /// <Summary>
        /// The color to use for this button's text when the button is disabled.
        ///
        /// The button's [Material.textStyle] will be the current theme's button
        /// text style, [ThemeData.textTheme.button], configured with this color.
        ///
        /// The default value is the theme's disabled color,
        /// [ThemeData.disabledColor].
        ///
        /// If [textColor] is a [MaterialStateProperty<Color>], [disabledTextColor]
        /// will be ignored.
        ///
        /// See also:
        ///
        ///  * [textColor] - The color to use for this button's text when the button is [enabled].
        /// </Summary>
        public virtual FlutterBinding.UI.Color DisabledTextColor { get; set; }
        /// <Summary>
        /// The button's fill color, displayed by its [Material], while it
        /// is in its default (unpressed, [enabled]) state.
        ///
        /// The default fill color is the theme's button color, [ThemeData.buttonColor].
        ///
        /// See also:
        ///
        ///  * [disabledColor] - the fill color of the button when the button is disabled.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// The fill color of the button when the button is disabled.
        ///
        /// The default value of this color is the theme's disabled color,
        /// [ThemeData.disabledColor].
        ///
        /// See also:
        ///
        ///  * [color] - the fill color of the button when the button is [enabled].
        /// </Summary>
        public virtual FlutterBinding.UI.Color DisabledColor { get; set; }
        /// <Summary>
        /// The splash color of the button's [InkWell].
        ///
        /// The ink splash indicates that the button has been touched. It
        /// appears on top of the button's child and spreads in an expanding
        /// circle beginning where the touch occurred.
        ///
        /// The default splash color is the current theme's splash color,
        /// [ThemeData.splashColor].
        ///
        /// The appearance of the splash can be configured with the theme's splash
        /// factory, [ThemeData.splashFactory].
        /// </Summary>
        public virtual FlutterBinding.UI.Color SplashColor { get; set; }
        /// <Summary>
        /// The fill color of the button's [Material] when it has the input focus.
        ///
        /// The button changed focus color when the button has the input focus. It
        /// appears behind the button's child.
        /// </Summary>
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        /// <Summary>
        /// The fill color of the button's [Material] when a pointer is hovering over
        /// it.
        ///
        /// The button changes fill color when a pointer is hovering over the button.
        /// It appears behind the button's child.
        /// </Summary>
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        /// <Summary>
        /// The highlight color of the button's [InkWell].
        ///
        /// The highlight indicates that the button is actively being pressed. It
        /// appears on top of the button's child and quickly spreads to fill
        /// the button, and then fades out.
        ///
        /// If [textTheme] is [ButtonTextTheme.primary], the default highlight color is
        /// transparent (in other words the highlight doesn't appear). Otherwise it's
        /// the current theme's highlight color, [ThemeData.highlightColor].
        /// </Summary>
        public virtual FlutterBinding.UI.Color HighlightColor { get; set; }
        /// <Summary>
        /// The z-coordinate at which to place this button relative to its parent.
        ///
        /// This controls the size of the shadow below the raised button.
        ///
        /// Defaults to 2, the appropriate elevation for raised buttons. The value
        /// is always non-negative.
        ///
        /// See also:
        ///
        ///  * [FlatButton], a button with no elevation or fill color.
        ///  * [focusElevation], the elevation when the button is focused.
        ///  * [hoverElevation], the elevation when a pointer is hovering over the
        ///    button.
        ///  * [disabledElevation], the elevation when the button is disabled.
        ///  * [highlightElevation], the elevation when the button is pressed.
        /// </Summary>
        public virtual double Elevation { get; set; }
        /// <Summary>
        /// The elevation for the button's [Material] when the button
        /// is [enabled] and a pointer is hovering over it.
        ///
        /// Defaults to 4.0. The value is always non-negative.
        ///
        /// See also:
        ///
        ///  * [elevation], the default elevation.
        ///  * [focusElevation], the elevation when the button is focused.
        ///  * [disabledElevation], the elevation when the button is disabled.
        ///  * [highlightElevation], the elevation when the button is pressed.
        /// </Summary>
        public virtual double HoverElevation { get; set; }
        /// <Summary>
        /// The elevation for the button's [Material] when the button
        /// is [enabled] and has the input focus.
        ///
        /// Defaults to 4.0. The value is always non-negative.
        ///
        /// See also:
        ///
        ///  * [elevation], the default elevation.
        ///  * [hoverElevation], the elevation when a pointer is hovering over the
        ///    button.
        ///  * [disabledElevation], the elevation when the button is disabled.
        ///  * [highlightElevation], the elevation when the button is pressed.
        /// </Summary>
        public virtual double FocusElevation { get; set; }
        /// <Summary>
        /// The elevation for the button's [Material] relative to its parent when the
        /// button is [enabled] and pressed.
        ///
        /// This controls the size of the shadow below the button. When a tap
        /// down gesture occurs within the button, its [InkWell] displays a
        /// [highlightColor] "highlight".
        ///
        /// Defaults to 8.0. The value is always non-negative.
        ///
        /// See also:
        ///
        ///  * [elevation], the default elevation.
        ///  * [focusElevation], the elevation when the button is focused.
        ///  * [hoverElevation], the elevation when a pointer is hovering over the
        ///    button.
        ///  * [disabledElevation], the elevation when the button is disabled.
        /// </Summary>
        public virtual double HighlightElevation { get; set; }
        /// <Summary>
        /// The elevation for the button's [Material] relative to its parent when the
        /// button is not [enabled].
        ///
        /// Defaults to 0.0. The value is always non-negative.
        ///
        /// See also:
        ///
        ///  * [elevation], the default elevation.
        ///  * [highlightElevation], the elevation when the button is pressed.
        /// </Summary>
        public virtual double DisabledElevation { get; set; }
        /// <Summary>
        /// The theme brightness to use for this button.
        ///
        /// Defaults to the theme's brightness in [ThemeData.brightness]. Setting
        /// this value determines the button text's colors based on
        /// [ButtonThemeData.getTextColor].
        ///
        /// See also:
        ///
        ///  * [ButtonTextTheme], uses [Brightness] to determine text color.
        /// </Summary>
        public virtual Brightness ColorBrightness { get; set; }
        /// <Summary>
        /// The button's label.
        ///
        /// Often a [Text] widget in all caps.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The internal padding for the button's [child].
        ///
        /// Defaults to the value from the current [ButtonTheme],
        /// [ButtonThemeData.padding].
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        /// <Summary>
        /// Defines how compact the button's layout will be.
        ///
        /// {@macro flutter.material.themedata.visualDensity}
        ///
        /// See also:
        ///
        ///  * [ThemeData.visualDensity], which specifies the [density] for all widgets
        ///    within a [Theme].
        /// </Summary>
        public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        /// <Summary>
        /// The shape of the button's [Material].
        ///
        /// The button's highlight and splash are clipped to this shape. If the
        /// button has an elevation, then its drop shadow is defined by this
        /// shape as well.
        ///
        /// Defaults to the value from the current [ButtonTheme],
        /// [ButtonThemeData.shape].
        /// </Summary>
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Clip}
        ///
        /// Defaults to [Clip.none], and must not be null.
        /// </Summary>
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Focus.focusNode}
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        /// <Summary>
        /// {@macro flutter.widgets.Focus.autofocus}
        /// </Summary>
        public virtual bool Autofocus { get; set; }
        /// <Summary>
        /// Defines the duration of animated changes for [shape] and [elevation].
        ///
        /// The default value is [kThemeChangeDuration].
        /// </Summary>
        public virtual TimeSpan AnimationDuration { get; set; }
        /// <Summary>
        /// Configures the minimum size of the tap target.
        ///
        /// Defaults to [ThemeData.materialTapTargetSize].
        ///
        /// See also:
        ///
        ///  * [MaterialTapTargetSize], for a description of how this affects tap targets.
        /// </Summary>
        public virtual FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        /// <Summary>
        /// The smallest horizontal extent that the button will occupy.
        ///
        /// Defaults to the value from the current [ButtonTheme].
        /// </Summary>
        public virtual double MinWidth { get; set; }
        /// <Summary>
        /// The vertical extent of the button.
        ///
        /// Defaults to the value from the current [ButtonTheme].
        /// </Summary>
        public virtual double Height { get; set; }
        /// <Summary>
        /// Whether detected gestures should provide acoustic and/or haptic feedback.
        ///
        /// For example, on Android a tap will produce a clicking sound and a
        /// long-press will produce a short vibration, when feedback is enabled.
        ///
        /// See also:
        ///
        ///  * [Feedback] for providing platform-specific feedback to certain actions.
        /// </Summary>
        public virtual bool EnableFeedback { get; set; }
        public virtual bool Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ThemeData theme = ThemeDefaultClass.Theme.Of(context);
            ButtonThemeData buttonTheme = ButtonthemeDefaultClass.ButtonTheme.Of(context);
            return new RawMaterialButton(onPressed: OnPressed, onLongPress: OnLongPress, enableFeedback: EnableFeedback, onHighlightChanged: OnHighlightChanged, fillColor: buttonTheme.GetFillColor(this), textStyle: theme.TextTheme.Button.CopyWith(color: buttonTheme.GetTextColor(this)), focusColor: FocusColor ?? buttonTheme.GetFocusColor(this) ?? theme.FocusColor, hoverColor: HoverColor ?? buttonTheme.GetHoverColor(this) ?? theme.HoverColor, highlightColor: HighlightColor ?? theme.HighlightColor, splashColor: SplashColor ?? theme.SplashColor, elevation: buttonTheme.GetElevation(this), focusElevation: buttonTheme.GetFocusElevation(this), hoverElevation: buttonTheme.GetHoverElevation(this), highlightElevation: buttonTheme.GetHighlightElevation(this), padding: buttonTheme.GetPadding(this), visualDensity: VisualDensity ?? theme.VisualDensity, constraints: buttonTheme.GetConstraints(this).CopyWith(minWidth: MinWidth, minHeight: Height), shape: buttonTheme.GetShape(this), clipBehavior: ClipBehavior, focusNode: FocusNode, autofocus: Autofocus, animationDuration: buttonTheme.GetAnimationDuration(this), child: Child, materialTapTargetSize: MaterialTapTargetSize ?? theme.MaterialTapTargetSize);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new FlagProperty("enabled", value: Enabled, ifFalse: "disabled"));
            properties.Add(new DiagnosticsProperty<ButtonTextTheme>("textTheme", TextTheme, defaultValue: null));
            properties.Add(new ColorProperty("textColor", TextColor, defaultValue: null));
            properties.Add(new ColorProperty("disabledTextColor", DisabledTextColor, defaultValue: null));
            properties.Add(new ColorProperty("color", Color, defaultValue: null));
            properties.Add(new ColorProperty("disabledColor", DisabledColor, defaultValue: null));
            properties.Add(new ColorProperty("focusColor", FocusColor, defaultValue: null));
            properties.Add(new ColorProperty("hoverColor", HoverColor, defaultValue: null));
            properties.Add(new ColorProperty("highlightColor", HighlightColor, defaultValue: null));
            properties.Add(new ColorProperty("splashColor", SplashColor, defaultValue: null));
            properties.Add(new DiagnosticsProperty<Brightness>("colorBrightness", ColorBrightness, defaultValue: null));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("padding", Padding, defaultValue: null));
            properties.Add(new DiagnosticsProperty<VisualDensity>("visualDensity", VisualDensity, defaultValue: null));
            properties.Add(new DiagnosticsProperty<ShapeBorder>("shape", Shape, defaultValue: null));
            properties.Add(new DiagnosticsProperty<FocusNode>("focusNode", FocusNode, defaultValue: null));
            properties.Add(new DiagnosticsProperty<MaterialTapTargetSize>("materialTapTargetSize", MaterialTapTargetSize, defaultValue: null));
        }



    }

}
