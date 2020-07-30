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
namespace FlutterSDK.Material.Button
{
    internal static class ButtonDefaultClass
    {
    }

    /// <Summary>
    /// Creates a button based on [Semantics], [Material], and [InkWell]
    /// widgets.
    ///
    /// This class does not use the current [Theme] or [ButtonTheme] to
    /// compute default values for unspecified parameters. It's intended to
    /// be used for custom Material buttons that optionally incorporate defaults
    /// from the themes or from app-specific sources.
    ///
    /// [RaisedButton] and [FlatButton] configure a [RawMaterialButton] based
    /// on the current [Theme] and [ButtonTheme].
    /// </Summary>
    public class RawMaterialButton : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public RawMaterialButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), VoidCallback onPressed = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onHighlightChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Painting.Textstyle.TextStyle textStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color highlightColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color splashColor = default(FlutterBinding.UI.Color), double elevation = 2.0, double focusElevation = 4.0, double hoverElevation = 4.0, double highlightElevation = 8.0, double disabledElevation = 0.0, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), TimeSpan animationDuration = default(TimeSpan), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool enableFeedback = true)
        : base(key: key)
        {
            this.OnPressed = onPressed;
            this.OnLongPress = onLongPress;
            this.OnHighlightChanged = onHighlightChanged;
            this.TextStyle = textStyle;
            this.FillColor = fillColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.HighlightColor = highlightColor;
            this.SplashColor = splashColor;
            this.Elevation = elevation;
            this.FocusElevation = focusElevation;
            this.HoverElevation = hoverElevation;
            this.HighlightElevation = highlightElevation;
            this.DisabledElevation = disabledElevation;
            this.Padding = padding;
            this.VisualDensity = visualDensity;
            this.Constraints = constraints;
            this.Shape = shape;
            this.AnimationDuration = animationDuration;
            this.ClipBehavior = clipBehavior;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.Child = child;
            this.EnableFeedback = enableFeedback;
        }
        public virtual VoidCallback OnPressed { get; set; }
        public virtual VoidCallback OnLongPress { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnHighlightChanged { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle TextStyle { get; set; }
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual FlutterBinding.UI.Color HighlightColor { get; set; }
        public virtual FlutterBinding.UI.Color SplashColor { get; set; }
        public virtual double Elevation { get; set; }
        public virtual double HoverElevation { get; set; }
        public virtual double FocusElevation { get; set; }
        public virtual double HighlightElevation { get; set; }
        public virtual double DisabledElevation { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public virtual TimeSpan AnimationDuration { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public virtual bool Autofocus { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public virtual bool EnableFeedback { get; set; }
        public virtual bool Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Material.Button._RawMaterialButtonState CreateState() => new _RawMaterialButtonState();


    }


    public class _RawMaterialButtonState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Button.RawMaterialButton>
    {
        public _RawMaterialButtonState()
        { }
        internal virtual HashSet<FlutterSDK.Material.Materialstate.MaterialState> _States { get; set; }
        internal virtual bool _Hovered { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _Focused { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _Pressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _Disabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _EffectiveElevation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _UpdateState(FlutterSDK.Material.Materialstate.MaterialState state, bool value)
        {
            value? _States.Add(state):_States.Remove(state);
        }




        private void _HandleHighlightChanged(bool value)
        {
            if (_Pressed != value)
            {
                SetState(() =>
                {
                    _UpdateState(MaterialState.Pressed, value);
                    if (Widget.OnHighlightChanged != null)
                    {
                        Widget.OnHighlightChanged(value);
                    }

                }
                );
            }

        }




        private void _HandleHoveredChanged(bool value)
        {
            if (_Hovered != value)
            {
                SetState(() =>
                {
                    _UpdateState(MaterialState.Hovered, value);
                }
                );
            }

        }




        private void _HandleFocusedChanged(bool value)
        {
            if (_Focused != value)
            {
                SetState(() =>
                {
                    _UpdateState(MaterialState.Focused, value);
                }
                );
            }

        }




        public new void InitState()
        {
            base.InitState();
            _UpdateState(MaterialState.Disabled, !Widget.Enabled);
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Button.RawMaterialButton oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            _UpdateState(MaterialState.Disabled, !Widget.Enabled);
            if (_Disabled && _Pressed)
            {
                _HandleHighlightChanged(false);
            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Color effectiveTextColor = MaterialstateDefaultClass.MaterialStateProperty.ResolveAs(Widget.TextStyle?.Color, _States);
            ShapeBorder effectiveShape = MaterialstateDefaultClass.MaterialStateProperty.ResolveAs(Widget.Shape, _States);
            Offset densityAdjustment = Widget.VisualDensity.BaseSizeAdjustment;
            BoxConstraints effectiveConstraints = Widget.VisualDensity.EffectiveConstraints(Widget.Constraints);
            EdgeInsetsGeometry padding = Widget.Padding.Add(EdgeInsets.Only(left: densityAdjustment.Dx, top: densityAdjustment.Dy, right: densityAdjustment.Dx, bottom: densityAdjustment.Dy)).Clamp(EdgeinsetsDefaultClass.EdgeInsets.Zero, EdgeinsetsDefaultClass.EdgeInsetsGeometry.Infinity);
            Widget result = new ConstrainedBox(constraints: effectiveConstraints, child: new Material(elevation: _EffectiveElevation, textStyle: Widget.TextStyle?.CopyWith(color: effectiveTextColor), shape: effectiveShape, color: Widget.FillColor, type: Widget.FillColor == null ? MaterialType.Transparency : MaterialType.Button, animationDuration: Widget.AnimationDuration, clipBehavior: Widget.ClipBehavior, child: new InkWell(focusNode: Widget.FocusNode, canRequestFocus: Widget.Enabled, onFocusChange: _HandleFocusedChanged, autofocus: Widget.Autofocus, onHighlightChanged: _HandleHighlightChanged, splashColor: Widget.SplashColor, highlightColor: Widget.HighlightColor, focusColor: Widget.FocusColor, hoverColor: Widget.HoverColor, onHover: _HandleHoveredChanged, onTap: Widget.OnPressed, onLongPress: Widget.OnLongPress, enableFeedback: Widget.EnableFeedback, customBorder: effectiveShape, child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(color: effectiveTextColor), child: new Container(padding: padding, child: new Center(widthFactor: 1.0, heightFactor: 1.0, child: Widget.Child))))));
            Size minSize = default(Size);
            switch (Widget.MaterialTapTargetSize) { case MaterialTapTargetSize.Padded: minSize = new Size(ConstantsDefaultClass.KMinInteractiveDimension + densityAdjustment.Dx, ConstantsDefaultClass.KMinInteractiveDimension + densityAdjustment.Dy); break; case MaterialTapTargetSize.ShrinkWrap: minSize = Dart.UiDefaultClass.Size.Zero; break; }
            return new Semantics(container: true, button: true, enabled: Widget.Enabled, child: new _InputPadding(minSize: minSize, child: result));
        }



    }


    /// <Summary>
    /// A widget to pad the area around a [MaterialButton]'s inner [Material].
    ///
    /// Redirect taps that occur in the padded area around the child to the center
    /// of the child. This increases the size of the button and the button's
    /// "tap target", but not its material or its ink splashes.
    /// </Summary>
    public class _InputPadding : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        public _InputPadding(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), Size minSize = default(Size))
        : base(key: key, child: child)
        {
            this.MinSize = minSize;
        }
        public virtual Size MinSize { get; set; }

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderInputPadding(MinSize);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Button._RenderInputPadding renderObject)
        {
            renderObject.MinSize = MinSize;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            renderObject.MinSize = MinSize;
        }



    }


    public class _RenderInputPadding : FlutterSDK.Rendering.Shiftedbox.RenderShiftedBox
    {
        public _RenderInputPadding(Size _minSize, FlutterSDK.Rendering.Box.RenderBox child = default(FlutterSDK.Rendering.Box.RenderBox))
        : base(child)
        {
            this._MinSize = _minSize;
        }
        internal virtual Size _MinSize { get; set; }
        public virtual Size MinSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new double ComputeMinIntrinsicWidth(double height)
        {
            if (Child != null) return Dart.Math.MathDefaultClass.Max(Child.GetMinIntrinsicWidth(height), MinSize.Width);
            return 0.0;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            if (Child != null) return Dart.Math.MathDefaultClass.Max(Child.GetMinIntrinsicHeight(width), MinSize.Height);
            return 0.0;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            if (Child != null) return Dart.Math.MathDefaultClass.Max(Child.GetMaxIntrinsicWidth(height), MinSize.Width);
            return 0.0;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            if (Child != null) return Dart.Math.MathDefaultClass.Max(Child.GetMaxIntrinsicHeight(width), MinSize.Height);
            return 0.0;
        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            if (Child != null)
            {
                Child.Layout(constraints, parentUsesSize: true);
                double height = Dart.Math.MathDefaultClass.Max(Child.Size.Width, MinSize.Width);
                double width = Dart.Math.MathDefaultClass.Max(Child.Size.Height, MinSize.Height);
                Size = constraints.Constrain(new Size(height, width));
                BoxParentData childParentData = Child.ParentData as BoxParentData;
                childParentData.Offset = AlignmentDefaultClass.Alignment.Center.AlongOffset(Size - Child.Size as Offset);
            }
            else
            {
                Size = Dart.UiDefaultClass.Size.Zero;
            }

        }




        public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            if (base.HitTest(result, position: position))
            {
                return true;
            }

            Offset center = Child.Size.Center(Dart.UI.UiDefaultClass.Offset.Zero);
            return result.AddWithRawTransform(transform: MatrixutilsDefaultClass.MatrixUtils.ForceToPoint(center), position: center, hitTest: (BoxHitTestResult result, Offset position) =>
            {

                return Child.HitTest(result, position: center);
            }
            );
        }



    }

}
