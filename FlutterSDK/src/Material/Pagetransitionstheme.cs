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
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Typography;
using FlutterSDK.Scheduler;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Pagetransitionstheme;
namespace FlutterSDK.Material.Pagetransitionstheme
{
    internal static class PagetransitionsthemeDefaultClass
    {
    }

    /// <Summary>
    /// Used by [PageTransitionsTheme] to define a [MaterialPageRoute] page
    /// transition animation.
    ///
    /// Apps can configure the map of builders for [ThemeData.pageTransitionsTheme]
    /// to customize the default [MaterialPageRoute] page transition animation
    /// for different platforms.
    ///
    /// See also:
    ///
    ///  * [FadeUpwardsPageTransitionsBuilder], which defines a default page transition.
    ///  * [OpenUpwardsPageTransitionsBuilder], which defines a page transition
    ///    that's similar to the one provided by Android P.
    ///  * [ZoomPageTransitionsBuilder], which defines a page transition similar
    ///    to the one provided in Android 10.
    ///  * [CupertinoPageTransitionsBuilder], which defines a horizontal page
    ///    transition that matches native iOS page transitions.
    /// </Summary>
    public interface IPageTransitionsBuilder
    {
        FlutterSDK.Widgets.Framework.Widget BuildTransitions<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child);
    }


    public class _FadeUpwardsPageTransition : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _FadeUpwardsPageTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> routeAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child;
        }
        internal virtual FlutterSDK.Animation.Tween.Tween<Offset> _BottomUpTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _FastOutSlowInTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Animatable<double> _EaseInTween { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<Offset> _PositionAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _OpacityAnimation { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new SlideTransition(position: _PositionAnimation, child: new FadeTransition(opacity: _OpacityAnimation, child: Child));
        }



    }


    public class _OpenUpwardsPageTransition : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        public _OpenUpwardsPageTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Animation = animation;
            this.SecondaryAnimation = secondaryAnimation;
            this.Child = child;
        }
        internal virtual FlutterSDK.Animation.Tween.Tween<Offset> _PrimaryTranslationTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<Offset> _SecondaryTranslationTween { get; set; }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _ScrimOpacityTween { get; set; }
        internal virtual FlutterSDK.Animation.Curves.Curve _TransitionCurve { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> SecondaryAnimation { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new LayoutBuilder(builder: (BuildContext context, BoxConstraints constraints) =>
            {
                Size size = constraints.Biggest;
                CurvedAnimation primaryAnimation = new CurvedAnimation(parent: Animation, curve: _TransitionCurve, reverseCurve: _TransitionCurve.Flipped);
                Animation<double> clipAnimation = new Tween<double>(begin: 0.0, end: size.Height).Animate(primaryAnimation);
                Animation<double> opacityAnimation = _ScrimOpacityTween.Animate(primaryAnimation);
                Animation<Offset> primaryTranslationAnimation = _PrimaryTranslationTween.Animate(primaryAnimation);
                Animation<Offset> secondaryTranslationAnimation = _SecondaryTranslationTween.Animate(new CurvedAnimation(parent: SecondaryAnimation, curve: _TransitionCurve, reverseCurve: _TransitionCurve.Flipped));
                return new AnimatedBuilder(animation: Animation, builder: (BuildContext context, Widget child) =>
                {
                    return new Container(color: ColorsDefaultClass.Colors.Black.WithOpacity(opacityAnimation.Value), alignment: AlignmentDefaultClass.Alignment.BottomLeft, child: new ClipRect(child: new SizedBox(height: clipAnimation.Value, child: new OverflowBox(alignment: AlignmentDefaultClass.Alignment.BottomLeft, maxHeight: size.Height, child: child))));
                }
                , child: new AnimatedBuilder(animation: SecondaryAnimation, child: new FractionalTranslation(translation: primaryTranslationAnimation.Value, child: Child), builder: (BuildContext context, Widget child) =>
                {
                    return new FractionalTranslation(translation: secondaryTranslationAnimation.Value, child: child);
                }
                ));
            }
            );
        }



    }


    public class _ZoomPageTransition : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        public _ZoomPageTransition(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Animation = animation;
            this.SecondaryAnimation = secondaryAnimation;
            this.Child = child;
        }
        internal virtual FlutterSDK.Animation.Tween.Tween<double> _ScrimOpacityTween { get; set; }
        public virtual List<FlutterSDK.Animation.Tweensequence.TweenSequenceItem<double>> FastOutExtraSlowInTweenSequenceItems { get; set; }
        internal virtual FlutterSDK.Animation.Tweensequence.TweenSequence<double> _ScaleCurveSequence { get; set; }
        internal virtual FlutterSDK.Animation.Tweensequence.FlippedTweenSequence _FlippedScaleCurveSequence { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> SecondaryAnimation { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }

        public new FlutterSDK.Material.Pagetransitionstheme._ZoomPageTransitionState CreateState() => new _ZoomPageTransitionState();


    }


    public class _ZoomPageTransitionState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Pagetransitionstheme._ZoomPageTransition>
    {
        public __ZoomPageTransitionState()
        { }
        internal virtual FlutterSDK.Animation.Animation.AnimationStatus _CurrentAnimationStatus { get; set; }
        internal virtual FlutterSDK.Animation.Animation.AnimationStatus _LastAnimationStatus { get; set; }
        internal virtual bool _TransitionWasInterrupted { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void InitState()
        {
            base.InitState();
            Widget.Animation.AddStatusListener((AnimationStatus animationStatus) =>
            {
                _LastAnimationStatus = _CurrentAnimationStatus;
                _CurrentAnimationStatus = animationStatus;
            }
            );
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Animation<double> _forwardScrimOpacityAnimation = Widget.Animation.Drive(PagetransitionsthemeDefaultClass._ZoomPageTransition._ScrimOpacityTween.Chain(new CurveTween(curve: new Interval(0.2075, 0.4175))));
            Animation<double> _forwardEndScreenScaleTransition = Widget.Animation.Drive(new Tween<double>(begin: 0.85, end: 1.00).Chain(PagetransitionsthemeDefaultClass._ZoomPageTransition._ScaleCurveSequence));
            Animation<double> _forwardStartScreenScaleTransition = Widget.SecondaryAnimation.Drive(new Tween<double>(begin: 1.00, end: 1.05).Chain(PagetransitionsthemeDefaultClass._ZoomPageTransition._ScaleCurveSequence));
            Animation<double> _forwardEndScreenFadeTransition = Widget.Animation.Drive(new Tween<double>(begin: 0.0, end: 1.00).Chain(new CurveTween(curve: new Interval(0.125, 0.250))));
            Animation<double> _reverseEndScreenScaleTransition = Widget.SecondaryAnimation.Drive(new Tween<double>(begin: 1.00, end: 1.10).Chain(PagetransitionsthemeDefaultClass._ZoomPageTransition._FlippedScaleCurveSequence));
            Animation<double> _reverseStartScreenScaleTransition = Widget.Animation.Drive(new Tween<double>(begin: 0.9, end: 1.0).Chain(PagetransitionsthemeDefaultClass._ZoomPageTransition._FlippedScaleCurveSequence));
            Animation<double> _reverseStartScreenFadeTransition = Widget.Animation.Drive(new Tween<double>(begin: 0.0, end: 1.00).Chain(new CurveTween(curve: new Interval(1 - 0.2075, 1 - 0.0825))));
            return new AnimatedBuilder(animation: Widget.Animation, builder: (BuildContext context, Widget child) =>
            {
                if (Widget.Animation.Status == AnimationStatus.Forward || _TransitionWasInterrupted)
                {
                    return new Container(color: ColorsDefaultClass.Colors.Black.WithOpacity(_forwardScrimOpacityAnimation.Value), child: new FadeTransition(opacity: _forwardEndScreenFadeTransition, child: new ScaleTransition(scale: _forwardEndScreenScaleTransition, child: child)));
                }
                else if (Widget.Animation.Status == AnimationStatus.Reverse)
                {
                    return new ScaleTransition(scale: _reverseStartScreenScaleTransition, child: new FadeTransition(opacity: _reverseStartScreenFadeTransition, child: child));
                }

                return child;
            }
            , child: new AnimatedBuilder(animation: Widget.SecondaryAnimation, builder: (BuildContext context, Widget child) =>
            {
                if (Widget.SecondaryAnimation.Status == AnimationStatus.Forward || _TransitionWasInterrupted)
                {
                    return new ScaleTransition(scale: _forwardStartScreenScaleTransition, child: child);
                }
                else if (Widget.SecondaryAnimation.Status == AnimationStatus.Reverse)
                {
                    return new ScaleTransition(scale: _reverseEndScreenScaleTransition, child: child);
                }

                return child;
            }
            , child: Widget.Child));
        }



    }


    /// <Summary>
    /// Used by [PageTransitionsTheme] to define a [MaterialPageRoute] page
    /// transition animation.
    ///
    /// Apps can configure the map of builders for [ThemeData.pageTransitionsTheme]
    /// to customize the default [MaterialPageRoute] page transition animation
    /// for different platforms.
    ///
    /// See also:
    ///
    ///  * [FadeUpwardsPageTransitionsBuilder], which defines a default page transition.
    ///  * [OpenUpwardsPageTransitionsBuilder], which defines a page transition
    ///    that's similar to the one provided by Android P.
    ///  * [ZoomPageTransitionsBuilder], which defines a page transition similar
    ///    to the one provided in Android 10.
    ///  * [CupertinoPageTransitionsBuilder], which defines a horizontal page
    ///    transition that matches native iOS page transitions.
    /// </Summary>
    public class PageTransitionsBuilder
    {
        public PageTransitionsBuilder()
        {

        }

        /// <Summary>
        /// Wraps the child with one or more transition widgets which define how [route]
        /// arrives on and leaves the screen.
        ///
        /// The [MaterialPageRoute.buildTransitions] method looks up the current
        /// current [PageTransitionsTheme] with `Theme.of(context).pageTransitionsTheme`
        /// and delegates to this method with a [PageTransitionsBuilder] based
        /// on the theme's [ThemeData.platform].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildTransitions<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            return default(Widget);
        }

    }


    /// <Summary>
    /// Used by [PageTransitionsTheme] to define a default [MaterialPageRoute] page
    /// transition animation.
    ///
    /// The default animation fades the new page in while translating it upwards,
    /// starting from about 25% below the top of the screen.
    ///
    /// See also:
    ///
    ///  * [OpenUpwardsPageTransitionsBuilder], which defines a page transition
    ///    that's similar to the one provided by Android P.
    ///  * [ZoomPageTransitionsBuilder], which defines a page transition similar
    ///    to the one provided in Android 10.
    ///  * [CupertinoPageTransitionsBuilder], which defines a horizontal page
    ///    transition that matches native iOS page transitions.
    /// </Summary>
    public class FadeUpwardsPageTransitionsBuilder : FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder
    {
        public FadeUpwardsPageTransitionsBuilder()
        {

        }

        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            return new _FadeUpwardsPageTransition(routeAnimation: animation, child: child);
        }



    }


    /// <Summary>
    /// Used by [PageTransitionsTheme] to define a vertical [MaterialPageRoute] page
    /// transition animation that looks like the default page transition
    /// used on Android P.
    ///
    /// See also:
    ///
    ///  * [FadeUpwardsPageTransitionsBuilder], which defines a default page transition.
    ///  * [ZoomPageTransitionsBuilder], which defines a page transition similar
    ///    to the one provided in Android 10.
    ///  * [CupertinoPageTransitionsBuilder], which defines a horizontal page
    ///    transition that matches native iOS page transitions.
    /// </Summary>
    public class OpenUpwardsPageTransitionsBuilder : FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder
    {
        public OpenUpwardsPageTransitionsBuilder()
        {

        }

        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            return new _OpenUpwardsPageTransition(animation: animation, secondaryAnimation: secondaryAnimation, child: child);
        }



    }


    /// <Summary>
    /// Used by [PageTransitionsTheme] to define a zooming [MaterialPageRoute] page
    /// transition animation that looks like the default page transition used on
    /// Android 10.
    ///
    /// See also:
    ///
    ///  * [FadeUpwardsPageTransitionsBuilder], which defines a default page transition.
    ///  * [OpenUpwardsPageTransitionsBuilder], which defines a page transition
    ///    similar to the one provided by Android P.
    ///  * [CupertinoPageTransitionsBuilder], which defines a horizontal page
    ///    transition that matches native iOS page transitions.
    /// </Summary>
    public class ZoomPageTransitionsBuilder : FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder
    {
        public ZoomPageTransitionsBuilder()
        {

        }

        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            return new _ZoomPageTransition(animation: animation, secondaryAnimation: secondaryAnimation, child: child);
        }



    }


    /// <Summary>
    /// Used by [PageTransitionsTheme] to define a horizontal [MaterialPageRoute]
    /// page transition animation that matches native iOS page transitions.
    ///
    /// See also:
    ///
    ///  * [FadeUpwardsPageTransitionsBuilder], which defines a default page transition.
    ///  * [OpenUpwardsPageTransitionsBuilder], which defines a page transition
    ///    that's similar to the one provided by Android P.
    ///  * [ZoomPageTransitionsBuilder], which defines a page transition similar
    ///    to the one provided in Android 10.
    /// </Summary>
    public class CupertinoPageTransitionsBuilder : FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder
    {
        public CupertinoPageTransitionsBuilder()
        {

        }

        public new FlutterSDK.Widgets.Framework.Widget BuildTransitions<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            return RouteDefaultClass.CupertinoPageRoute.BuildPageTransitions(route, context, animation, secondaryAnimation, child);
        }



    }


    /// <Summary>
    /// Defines the page transition animations used by [MaterialPageRoute]
    /// for different [TargetPlatform]s.
    ///
    /// The [MaterialPageRoute.buildTransitions] method looks up the current
    /// current [PageTransitionsTheme] with `Theme.of(context).pageTransitionsTheme`
    /// and delegates to [buildTransitions].
    ///
    /// If a builder with a matching platform is not found, then the
    /// [FadeUpwardsPageTransitionsBuilder] is used.
    ///
    /// See also:
    ///
    ///  * [ThemeData.pageTransitionsTheme], which defines the default page
    ///    transitions for the overall theme.
    ///  * [FadeUpwardsPageTransitionsBuilder], which defines a default page transition.
    ///  * [OpenUpwardsPageTransitionsBuilder], which defines a page transition
    ///    that's similar to the one provided by Android P.
    ///  * [CupertinoPageTransitionsBuilder], which defines a horizontal page
    ///    transition that matches native iOS page transitions.
    /// </Summary>
    public class PageTransitionsTheme : IDiagnosticable
    {
        public PageTransitionsTheme(Dictionary<FlutterSDK.Foundation.Platform.TargetPlatform, FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder> builders = default(Dictionary<FlutterSDK.Foundation.Platform.TargetPlatform, FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder>))
        : base()
        {

        }
        internal virtual Dictionary<FlutterSDK.Foundation.Platform.TargetPlatform, FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder> _DefaultBuilders { get; set; }
        internal virtual Dictionary<FlutterSDK.Foundation.Platform.TargetPlatform, FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder> _Builders { get; set; }
        public virtual Dictionary<FlutterSDK.Foundation.Platform.TargetPlatform, FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder> Builders { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Delegates to the builder for the current [ThemeData.platform]
        /// or [FadeUpwardsPageTransitionsBuilder].
        ///
        /// [MaterialPageRoute.buildTransitions] delegates to this method.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildTransitions<T>(FlutterSDK.Widgets.Pages.PageRoute<T> route, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation, FlutterSDK.Animation.Animation.Animation<double> secondaryAnimation, FlutterSDK.Widgets.Framework.Widget child)
        {
            TargetPlatform platform = ThemeDefaultClass.Theme.Of(context).Platform;
            if (RouteDefaultClass.CupertinoPageRoute.IsPopGestureInProgress(route)) platform = TargetPlatform.IOS;
            PageTransitionsBuilder matchingBuilder = Builders[platform] ?? new FadeUpwardsPageTransitionsBuilder();
            return matchingBuilder.BuildTransitions(route, context, animation, secondaryAnimation, child);
        }




        private List<FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder> _All(Dictionary<FlutterSDK.Foundation.Platform.TargetPlatform, FlutterSDK.Material.Pagetransitionstheme.PageTransitionsBuilder> builders)
        {
            return TargetPlatform.Values.Map((TargetPlatform platform) => =>builders[platform]).ToList();
        }




        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            if (other.GetType() != GetType()) return false;
            if (other is PageTransitionsTheme && Dart:coreDefaultClass.Identical(Builders, other.Builders))return true;
            return other is PageTransitionsTheme && CollectionsDefaultClass.ListEquals(_All(other.Builders), _All(Builders));
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<Dictionary<TargetPlatform, PageTransitionsBuilder>>("builders", Builders, defaultValue: PagetransitionsthemeDefaultClass.PageTransitionsTheme._DefaultBuilders));
        }



    }

}
