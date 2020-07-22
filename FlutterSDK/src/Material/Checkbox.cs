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
namespace FlutterSDK.Material.Checkbox
{
    internal static class CheckboxDefaultClass
    {
        public static double _KEdgeSize = default(double);
        public static Radius _KEdgeRadius = default(Radius);
        public static double _KStrokeWidth = default(double);
    }

    /// <Summary>
    /// A material design checkbox.
    ///
    /// The checkbox itself does not maintain any state. Instead, when the state of
    /// the checkbox changes, the widget calls the [onChanged] callback. Most
    /// widgets that use a checkbox will listen for the [onChanged] callback and
    /// rebuild the checkbox with a new [value] to update the visual appearance of
    /// the checkbox.
    ///
    /// The checkbox can optionally display three values - true, false, and null -
    /// if [tristate] is true. When [value] is null a dash is displayed. By default
    /// [tristate] is false and the checkbox's [value] must be true or false.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// See also:
    ///
    ///  * [CheckboxListTile], which combines this widget with a [ListTile] so that
    ///    you can give the checkbox a label.
    ///  * [Switch], a widget with semantics similar to [Checkbox].
    ///  * [Radio], for selecting among a set of explicit values.
    ///  * [Slider], for selecting a value in a range.
    ///  * <https://material.io/design/components/selection-controls.html#checkboxes>
    ///  * <https://material.io/design/components/lists.html#types>
    /// </Summary>
    public class Checkbox : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public Checkbox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool value = default(bool), bool tristate = false, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color checkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false)
        : base(key: key)
        {
            this.Value = value;
            this.Tristate = tristate;
            this.OnChanged = onChanged;
            this.ActiveColor = activeColor;
            this.CheckColor = checkColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.VisualDensity = visualDensity;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
        }
        public virtual bool Value { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get; set; }
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        public virtual FlutterBinding.UI.Color CheckColor { get; set; }
        public virtual bool Tristate { get; set; }
        public virtual FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public virtual bool Autofocus { get; set; }
        public virtual double Width { get; set; }

        public new FlutterSDK.Material.Checkbox._CheckboxState CreateState() => new _CheckboxState();


    }


    public class _CheckboxState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Checkbox.Checkbox>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _CheckboxState()
        { }
        internal virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> _ActionMap { get; set; }
        internal virtual bool _Focused { get; set; }
        internal virtual bool _Hovering { get; set; }
        public virtual bool Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            _ActionMap = new Dictionary<LocalKey, ActionFactory> { { ActionsDefaultClass.ActivateAction.Key, _CreateAction } };
        }




        private void _ActionHandler(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent)
        {
            if (Widget.OnChanged != null)
            {
                switch (Widget.Value) { case false: Widget.OnChanged(true); break; case true: Widget.OnChanged(Widget.Tristate ? null : false); break; default: Widget.OnChanged(false); break; }
            }

            RenderObject renderObject = node.Context.FindRenderObject();
            renderObject.SendSemanticsEvent(new TapSemanticEvent());
        }




        private FlutterSDK.Widgets.Actions.Action _CreateAction()
        {
            return new CallbackAction(ActionsDefaultClass.ActivateAction.Key, onInvoke: _ActionHandler);
        }




        private void _HandleFocusHighlightChanged(bool focused)
        {
            if (focused != _Focused)
            {
                SetState(() =>
                {
                    _Focused = focused;
                }
                );
            }

        }




        private void _HandleHoverChanged(bool hovering)
        {
            if (hovering != _Hovering)
            {
                SetState(() =>
                {
                    _Hovering = hovering;
                }
                );
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {

            ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
            Size size = default(Size);
            switch (Widget.MaterialTapTargetSize ?? themeData.MaterialTapTargetSize) { case MaterialTapTargetSize.Padded: size = new Size(2 * ConstantsDefaultClass.KRadialReactionRadius + 8.0, 2 * ConstantsDefaultClass.KRadialReactionRadius + 8.0); break; case MaterialTapTargetSize.ShrinkWrap: size = new Size(2 * ConstantsDefaultClass.KRadialReactionRadius, 2 * ConstantsDefaultClass.KRadialReactionRadius); break; }
            size += (Widget.VisualDensity ?? themeData.VisualDensity).BaseSizeAdjustment;
            BoxConstraints additionalConstraints = BoxConstraints.Tight(size);
            return new FocusableActionDetector(actions: _ActionMap, focusNode: Widget.FocusNode, autofocus: Widget.Autofocus, enabled: Enabled, onShowFocusHighlight: _HandleFocusHighlightChanged, onShowHoverHighlight: _HandleHoverChanged, child: new Builder(builder: (BuildContext context) =>
            {
                return new _CheckboxRenderObjectWidget(value: Widget.Value, tristate: Widget.Tristate, activeColor: Widget.ActiveColor ?? themeData.ToggleableActiveColor, checkColor: Widget.CheckColor ?? new Color(0xFFFFFFFF), inactiveColor: Enabled ? themeData.UnselectedWidgetColor : themeData.DisabledColor, focusColor: Widget.FocusColor ?? themeData.FocusColor, hoverColor: Widget.HoverColor ?? themeData.HoverColor, onChanged: Widget.OnChanged, additionalConstraints: additionalConstraints, vsync: this, hasFocus: _Focused, hovering: _Hovering);
            }
            ));
        }



    }


    public class _CheckboxRenderObjectWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        public _CheckboxRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool value = default(bool), bool tristate = default(bool), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color checkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider), FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), bool hasFocus = default(bool), bool hovering = default(bool))
        : base(key: key)
        {
            this.Value = value;
            this.Tristate = tristate;
            this.ActiveColor = activeColor;
            this.CheckColor = checkColor;
            this.InactiveColor = inactiveColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.OnChanged = onChanged;
            this.Vsync = vsync;
            this.AdditionalConstraints = additionalConstraints;
            this.HasFocus = hasFocus;
            this.Hovering = hovering;
        }
        public virtual bool Value { get; set; }
        public virtual bool Tristate { get; set; }
        public virtual bool HasFocus { get; set; }
        public virtual bool Hovering { get; set; }
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        public virtual FlutterBinding.UI.Color CheckColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveColor { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get; set; }
        public virtual FlutterSDK.Scheduler.Ticker.TickerProvider Vsync { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints AdditionalConstraints { get; set; }

        public new FlutterSDK.Material.Checkbox._RenderCheckbox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) => new _RenderCheckbox(value: Value, tristate: Tristate, activeColor: ActiveColor, checkColor: CheckColor, inactiveColor: InactiveColor, focusColor: FocusColor, hoverColor: HoverColor, onChanged: OnChanged, vsync: Vsync, additionalConstraints: AdditionalConstraints, hasFocus: HasFocus, hovering: Hovering);



        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Checkbox._RenderCheckbox renderObject)
        {
            ..Value = Value..Tristate = Tristate..ActiveColor = ActiveColor..CheckColor = CheckColor..InactiveColor = InactiveColor..FocusColor = FocusColor..HoverColor = HoverColor..OnChanged = OnChanged..AdditionalConstraints = AdditionalConstraints..Vsync = Vsync..HasFocus = HasFocus..Hovering = Hovering;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Value = Value..Tristate = Tristate..ActiveColor = ActiveColor..CheckColor = CheckColor..InactiveColor = InactiveColor..FocusColor = FocusColor..HoverColor = HoverColor..OnChanged = OnChanged..AdditionalConstraints = AdditionalConstraints..Vsync = Vsync..HasFocus = HasFocus..Hovering = Hovering;
        }



    }


    public class _RenderCheckbox : FlutterSDK.Material.Toggleable.RenderToggleable
    {
        public _RenderCheckbox(bool value = default(bool), bool tristate = default(bool), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color checkColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), bool hasFocus = default(bool), bool hovering = default(bool), FlutterSDK.Scheduler.Ticker.TickerProvider vsync = default(FlutterSDK.Scheduler.Ticker.TickerProvider))
        : base(value: value, tristate: tristate, activeColor: activeColor, inactiveColor: inactiveColor, focusColor: focusColor, hoverColor: hoverColor, onChanged: onChanged, additionalConstraints: additionalConstraints, vsync: vsync, hasFocus: hasFocus, hovering: hovering)
        {
            this.CheckColor = checkColor;
        }
        internal virtual bool _OldValue { get; set; }
        public virtual FlutterBinding.UI.Color CheckColor { get; set; }
        public virtual bool Value { set { throw new NotImplementedException(); } }

        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config)
        {
            base.DescribeSemanticsConfiguration(config);
            config.IsChecked = Value == true;
        }




        private RRect _OuterRectAt(FlutterBinding.UI.Offset origin, double t)
        {
            double inset = 1.0 - (t - 0.5).Abs() * 2.0;
            double size = CheckboxDefaultClass._KEdgeSize - inset * CheckboxDefaultClass._KStrokeWidth;
            Rect rect = Rect.FromLTWH(origin.Dx + inset, origin.Dy + inset, size, size);
            return RRect.FromRectAndRadius(rect, CheckboxDefaultClass._KEdgeRadius);
        }




        private Color _ColorAt(double t)
        {
            return OnChanged == null ? InactiveColor : (t >= 0.25 ? ActiveColor : Dart:uiDefaultClass.Color.Lerp(InactiveColor, ActiveColor, t * 4.0));
        }




        private Paint _CreateStrokePaint()
        {
            return new Paint()..Color = CheckColor..Style = PaintingStyle.Stroke..StrokeWidth = CheckboxDefaultClass._KStrokeWidth;
        }




        private void _DrawBorder(Canvas canvas, FlutterBinding.UI.RRect outer, double t, SKPaint paint)
        {

            double size = outer.Width;
            RRect inner = outer.Deflate(Math.Dart:mathDefaultClass.Min(size / 2.0, CheckboxDefaultClass._KStrokeWidth + size * t));
            canvas.DrawDRRect(outer, inner, paint);
        }




        private void _DrawCheck(Canvas canvas, FlutterBinding.UI.Offset origin, double t, SKPaint paint)
        {

            Path path = new Path();
            Offset start = new Offset(CheckboxDefaultClass._KEdgeSize * 0.15, CheckboxDefaultClass._KEdgeSize * 0.45);
            Offset mid = new Offset(CheckboxDefaultClass._KEdgeSize * 0.4, CheckboxDefaultClass._KEdgeSize * 0.7);
            Offset end = new Offset(CheckboxDefaultClass._KEdgeSize * 0.85, CheckboxDefaultClass._KEdgeSize * 0.25);
            if (t < 0.5)
            {
                double strokeT = t * 2.0;
                Offset drawMid = Dart:uiDefaultClass.Offset.Lerp(start, mid, strokeT);
                path.MoveTo(origin.Dx + start.Dx, origin.Dy + start.Dy);
                path.LineTo(origin.Dx + drawMid.Dx, origin.Dy + drawMid.Dy);
            }
            else
            {
                double strokeT = (t - 0.5) * 2.0;
                Offset drawEnd = Dart:uiDefaultClass.Offset.Lerp(mid, end, strokeT);
                path.MoveTo(origin.Dx + start.Dx, origin.Dy + start.Dy);
                path.LineTo(origin.Dx + mid.Dx, origin.Dy + mid.Dy);
                path.LineTo(origin.Dx + drawEnd.Dx, origin.Dy + drawEnd.Dy);
            }

            canvas.DrawPath(path, paint);
        }




        private void _DrawDash(Canvas canvas, FlutterBinding.UI.Offset origin, double t, SKPaint paint)
        {

            Offset start = new Offset(CheckboxDefaultClass._KEdgeSize * 0.2, CheckboxDefaultClass._KEdgeSize * 0.5);
            Offset mid = new Offset(CheckboxDefaultClass._KEdgeSize * 0.5, CheckboxDefaultClass._KEdgeSize * 0.5);
            Offset end = new Offset(CheckboxDefaultClass._KEdgeSize * 0.8, CheckboxDefaultClass._KEdgeSize * 0.5);
            Offset drawStart = Dart:uiDefaultClass.Offset.Lerp(start, mid, 1.0 - t);
            Offset drawEnd = Dart:uiDefaultClass.Offset.Lerp(mid, end, t);
            canvas.DrawLine(origin + drawStart, origin + drawEnd, paint);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            Canvas canvas = context.Canvas;
            PaintRadialReaction(canvas, offset, Size.Center(Dart: uiDefaultClass.Offset.Zero));
            Paint strokePaint = _CreateStrokePaint();
            Offset origin = offset + (Size / 2.0 - Size.Square(CheckboxDefaultClass._KEdgeSize) / 2.0 as Offset);
            AnimationStatus status = Position.Status;
            double tNormalized = status == AnimationStatus.Forward || status == AnimationStatus.Completed ? Position.Value : 1.0 - Position.Value;
            if (_OldValue == false || Value == false)
            {
                double t = Value == false ? 1.0 - tNormalized : tNormalized;
                RRect outer = _OuterRectAt(origin, t);
                Paint paint = new Paint()..Color = _ColorAt(t);
                if (t <= 0.5)
                {
                    _DrawBorder(canvas, outer, t, paint);
                }
                else
                {
                    canvas.DrawRRect(outer, paint);
                    double tShrink = (t - 0.5) * 2.0;
                    if (_OldValue == null || Value == null) _DrawDash(canvas, origin, tShrink, strokePaint); else _DrawCheck(canvas, origin, tShrink, strokePaint);
                }

            }
            else
            {
                RRect outer = _OuterRectAt(origin, 1.0);
                Paint paint = new Paint()..Color = _ColorAt(1.0);
                canvas.DrawRRect(outer, paint);
                if (tNormalized <= 0.5)
                {
                    double tShrink = 1.0 - tNormalized * 2.0;
                    if (_OldValue == true) _DrawCheck(canvas, origin, tShrink, strokePaint); else _DrawDash(canvas, origin, tShrink, strokePaint);
                }
                else
                {
                    double tExpand = (tNormalized - 0.5) * 2.0;
                    if (Value == true) _DrawCheck(canvas, origin, tExpand, strokePaint); else _DrawDash(canvas, origin, tExpand, strokePaint);
                }

            }

        }



    }

}
