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
namespace FlutterSDK.Cupertino.Button
{
    internal static class ButtonDefaultClass
    {
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _KButtonPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsets _KBackgroundButtonPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets);
    }

    /// <Summary>
    /// An iOS-style button.
    ///
    /// Takes in a text or an icon that fades out and in on touch. May optionally have a
    /// background.
    ///
    /// See also:
    ///
    ///  * <https://developer.apple.com/ios/human-interface-guidelines/controls/buttons/>
    /// </Summary>
    public class CupertinoButton : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        /// <Summary>
        /// Creates an iOS-style button.
        /// </Summary>
        public CupertinoButton(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), double minSize = default(double), double pressedOpacity = 0.4, FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), VoidCallback onPressed = default(VoidCallback))
        : base(key: key)
        {
            this.Child = child;
            this.Padding = padding;
            this.Color = color;
            this.DisabledColor = disabledColor;
            this.MinSize = minSize;
            this.PressedOpacity = pressedOpacity;
            this.BorderRadius = borderRadius;
            this.OnPressed = onPressed;
        }
        /// <Summary>
        /// Creates an iOS-style button with a filled background.
        ///
        /// The background color is derived from the [CupertinoTheme]'s `primaryColor`.
        ///
        /// To specify a custom background color, use the [color] argument of the
        /// default constructor.
        /// </Summary>
        public static CupertinoButton Filled(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), double minSize = default(double), double pressedOpacity = 0.4, FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), VoidCallback onPressed = default(VoidCallback))
        {
            var instance = new CupertinoButton(key: key); instance.Child = child;
            instance.Padding = padding;
            instance.DisabledColor = disabledColor;
            instance.MinSize = minSize;
            instance.PressedOpacity = pressedOpacity;
            instance.BorderRadius = borderRadius;
            instance.OnPressed = onPressed;
        }
        /// <Summary>
        /// The widget below this widget in the tree.
        ///
        /// Typically a [Text] widget.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        /// <Summary>
        /// The amount of space to surround the child inside the bounds of the button.
        ///
        /// Defaults to 16.0 pixels.
        /// </Summary>
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        /// <Summary>
        /// The color of the button's background.
        ///
        /// Defaults to null which produces a button with no background or border.
        ///
        /// Defaults to the [CupertinoTheme]'s `primaryColor` when the
        /// [CupertinoButton.filled] constructor is used.
        /// </Summary>
        public virtual FlutterBinding.UI.Color Color { get; set; }
        /// <Summary>
        /// The color of the button's background when the button is disabled.
        ///
        /// Ignored if the [CupertinoButton] doesn't also have a [color].
        ///
        /// Defaults to [CupertinoColors.quaternarySystemFill] when [color] is
        /// specified. Must not be null.
        /// </Summary>
        public virtual FlutterBinding.UI.Color DisabledColor { get; set; }
        /// <Summary>
        /// The callback that is called when the button is tapped or otherwise activated.
        ///
        /// If this is set to null, the button will be disabled.
        /// </Summary>
        public virtual VoidCallback OnPressed { get; set; }
        /// <Summary>
        /// Minimum size of the button.
        ///
        /// Defaults to kMinInteractiveDimensionCupertino which the iOS Human
        /// Interface Guidelines recommends as the minimum tappable area.
        /// </Summary>
        public virtual double MinSize { get; set; }
        /// <Summary>
        /// The opacity that the button will fade to when it is pressed.
        /// The button will have an opacity of 1.0 when it is not pressed.
        ///
        /// This defaults to 0.4. If null, opacity will not change on pressed if using
        /// your own custom effects is desired.
        /// </Summary>
        public virtual double PressedOpacity { get; set; }
        /// <Summary>
        /// The radius of the button's corners when it has a background color.
        ///
        /// Defaults to round corners of 8 logical pixels.
        /// </Summary>
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        internal virtual bool _Filled { get; set; }
        public virtual bool Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new FlutterSDK.Cupertino.Button._CupertinoButtonState CreateState() => new _CupertinoButtonState();



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new FlagProperty("enabled", value: Enabled, ifFalse: "disabled"));
        }



    }


    public class _CupertinoButtonState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Cupertino.Button.CupertinoButton>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        public _CupertinoButtonState()
        { }
        public virtual TimeSpan KFadeOutDuration { get; set; }
        public virtual TimeSpan KFadeInDuration { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _OpacityTween { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _AnimationController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _OpacityAnimation { get; set; }
        internal virtual bool _ButtonHeldDown { get; set; }

        public new void InitState()
        {
            base.InitState();
            _AnimationController = new AnimationController(duration: new TimeSpan(milliseconds: 200), value: 0.0, vsync: this);
            _OpacityAnimation = _AnimationController.Drive(new CurveTween(curve: CurvesDefaultClass.Curves.Decelerate)).Drive(_OpacityTween);
            _SetTween();
        }




        public new void DidUpdateWidget(FlutterSDK.Cupertino.Button.CupertinoButton old)
        {
            base.DidUpdateWidget(old);
            _SetTween();
        }




        private void _SetTween()
        {
            _OpacityTween.End = Widget.PressedOpacity ?? 1.0;
        }




        public new void Dispose()
        {
            _AnimationController.Dispose();
            _AnimationController = null;
            base.Dispose();
        }




        private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails @event)
        {
            if (!_ButtonHeldDown)
            {
                _ButtonHeldDown = true;
                _Animate();
            }

        }




        private void _HandleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails @event)
        {
            if (_ButtonHeldDown)
            {
                _ButtonHeldDown = false;
                _Animate();
            }

        }




        private void _HandleTapCancel()
        {
            if (_ButtonHeldDown)
            {
                _ButtonHeldDown = false;
                _Animate();
            }

        }




        private void _Animate()
        {
            if (_AnimationController.IsAnimating) return;
            bool wasHeldDown = _ButtonHeldDown;
            TickerFuture ticker = _ButtonHeldDown ? _AnimationController.AnimateTo(1.0, duration: KFadeOutDuration) : _AnimationController.AnimateTo(0.0, duration: KFadeInDuration);
            ticker.Then((void value) =>
            {
                if (Mounted && wasHeldDown != _ButtonHeldDown) _Animate();
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            bool enabled = Widget.Enabled;
            CupertinoThemeData themeData = ThemeDefaultClass.CupertinoTheme.Of(context);
            Color primaryColor = themeData.PrimaryColor;
            Color backgroundColor = Widget.Color == null ? (Widget._Filled ? primaryColor : null) : ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.Color, context);
            Color foregroundColor = backgroundColor != null ? themeData.PrimaryContrastingColor : enabled ? primaryColor : ColorsDefaultClass.CupertinoDynamicColor.Resolve(ColorsDefaultClass.CupertinoColors.PlaceholderText, context);
            TextStyle textStyle = themeData.TextTheme.TextStyle.CopyWith(color: foregroundColor);
            return new GestureDetector(behavior: HitTestBehavior.Opaque, onTapDown: enabled ? _HandleTapDown : null, onTapUp: enabled ? _HandleTapUp : null, onTapCancel: enabled ? _HandleTapCancel : null, onTap: Widget.OnPressed, child: new Semantics(button: true, child: new ConstrainedBox(constraints: Widget.MinSize == null ? new BoxConstraints() : new BoxConstraints(minWidth: Widget.MinSize, minHeight: Widget.MinSize), child: new FadeTransition(opacity: _OpacityAnimation, child: new DecoratedBox(decoration: new BoxDecoration(borderRadius: Widget.BorderRadius, color: backgroundColor != null && !enabled ? ColorsDefaultClass.CupertinoDynamicColor.Resolve(Widget.DisabledColor, context) : backgroundColor), child: new Padding(padding: Widget.Padding ?? (backgroundColor != null ? ButtonDefaultClass._KBackgroundButtonPadding : ButtonDefaultClass._KButtonPadding), child: new Center(widthFactor: 1.0, heightFactor: 1.0, child: new DefaultTextStyle(style: textStyle, child: new IconTheme(data: new IconThemeData(color: foregroundColor), child: Widget.Child)))))))));
        }



    }

}
