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
using file:///C:/src/xamarin.flutter/flutter/lib/foundation.dart;
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
namespace FlutterSDK.Material.Inputdecorator
{
    internal static class InputdecoratorDefaultClass
    {
        public static TimeSpan _KTransitionDuration = default(TimeSpan);
        public static FlutterSDK.Animation.Curves.Curve _KTransitionCurve = default(FlutterSDK.Animation.Curves.Curve);
    }

    public class _InputBorderGap : FlutterSDK.Foundation.Changenotifier.ChangeNotifier
    {
        #region constructors
        public _InputBorderGap()
        { }
        #endregion

        #region fields
        internal virtual double _Start { get; set; }
        internal virtual double _Extent { get; set; }
        public virtual double Start { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Extent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }

        #endregion
    }


    public class _InputBorderTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Material.Inputborder.InputBorder>
    {
        #region constructors
        public _InputBorderTween(FlutterSDK.Material.Inputborder.InputBorder begin = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder end = default(FlutterSDK.Material.Inputborder.InputBorder))
        : base(begin: begin, end: end)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Material.Inputborder.InputBorder Lerp(double t) { throw new NotImplementedException(); }

        #endregion
    }


    public class _InputBorderPainter : FlutterSDK.Rendering.Custompaint.CustomPainter
    {
        #region constructors
        public _InputBorderPainter(FlutterSDK.Foundation.Changenotifier.Listenable repaint = default(FlutterSDK.Foundation.Changenotifier.Listenable), FlutterSDK.Animation.Animation.Animation<double> borderAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Material.Inputdecorator._InputBorderTween border = default(FlutterSDK.Material.Inputdecorator._InputBorderTween), FlutterSDK.Animation.Animation.Animation<double> gapAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Material.Inputdecorator._InputBorderGap gap = default(FlutterSDK.Material.Inputdecorator._InputBorderGap), TextDirection textDirection = default(TextDirection), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterSDK.Animation.Animation.Animation<double> hoverAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Tween.ColorTween hoverColorTween = default(FlutterSDK.Animation.Tween.ColorTween))
        : base(repaint: repaint)
        {
            this.BorderAnimation = borderAnimation;
            this.Border = border;
            this.GapAnimation = gapAnimation;
            this.Gap = gap;
            this.TextDirection = textDirection;
            this.FillColor = fillColor;
            this.HoverAnimation = hoverAnimation;
            this.HoverColorTween = hoverColorTween; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Animation.Animation.Animation<double> BorderAnimation { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._InputBorderTween Border { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> GapAnimation { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._InputBorderGap Gap { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        public virtual FlutterSDK.Animation.Tween.ColorTween HoverColorTween { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> HoverAnimation { get; set; }
        public virtual FlutterBinding.UI.Color BlendedColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Paint(Canvas canvas, Size size) { throw new NotImplementedException(); }


        public new bool ShouldRepaint(FlutterSDK.Material.Inputdecorator._InputBorderPainter oldPainter) { throw new NotImplementedException(); }
        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate) { throw new NotImplementedException(); }

        #endregion
    }


    public class _BorderContainer : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _BorderContainer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputdecorator._InputBorderGap gap = default(FlutterSDK.Material.Inputdecorator._InputBorderGap), FlutterSDK.Animation.Animation.Animation<double> gapAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), bool isHovering = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Border = border;
            this.Gap = gap;
            this.GapAnimation = gapAnimation;
            this.FillColor = fillColor;
            this.HoverColor = hoverColor;
            this.IsHovering = isHovering;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Inputborder.InputBorder Border { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._InputBorderGap Gap { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> GapAnimation { get; set; }
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual bool IsHovering { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Inputdecorator._BorderContainerState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _BorderContainerState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Inputdecorator._BorderContainer>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _BorderContainerState()
        { }
        #endregion

        #region fields
        internal virtual TimeSpan _KHoverDuration { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _HoverColorController { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _BorderAnimation { get; set; }
        internal virtual FlutterSDK.Material.Inputdecorator._InputBorderTween _Border { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _HoverAnimation { get; set; }
        internal virtual FlutterSDK.Animation.Tween.ColorTween _HoverColorTween { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Inputdecorator._BorderContainer oldWidget) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _Shaker : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        #region constructors
        public _Shaker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: animation)
        {
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double TranslateX { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _HelperError : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _HelperError(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), TextAlign textAlign = default(TextAlign), string helperText = default(string), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), string errorText = default(string), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int))
        : base(key: key)
        {
            this.TextAlign = textAlign;
            this.HelperText = helperText;
            this.HelperStyle = helperStyle;
            this.HelperMaxLines = helperMaxLines;
            this.ErrorText = errorText;
            this.ErrorStyle = errorStyle;
            this.ErrorMaxLines = errorMaxLines; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual TextAlign TextAlign { get; set; }
        public virtual string HelperText { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle HelperStyle { get; set; }
        public virtual int HelperMaxLines { get; set; }
        public virtual string ErrorText { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle ErrorStyle { get; set; }
        public virtual int ErrorMaxLines { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Inputdecorator._HelperErrorState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _HelperErrorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Inputdecorator._HelperError>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _HelperErrorState()
        { }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Empty { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Helper { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Error { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _HandleChange() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Inputdecorator._HelperError old) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildHelper() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildError() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _Decoration
    {
        #region constructors
        public _Decoration(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool isCollapsed = default(bool), double floatingLabelHeight = default(double), double floatingLabelProgress = default(double), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputdecorator._InputBorderGap borderGap = default(FlutterSDK.Material.Inputdecorator._InputBorderGap), bool alignLabelWithHint = default(bool), bool isDense = default(bool), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget input = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget hint = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget prefix = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget suffix = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget prefixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget suffixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget helperError = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget counter = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget container = default(FlutterSDK.Widgets.Framework.Widget))
        : base()
        {
            this.ContentPadding = contentPadding;
            this.IsCollapsed = isCollapsed;
            this.FloatingLabelHeight = floatingLabelHeight;
            this.FloatingLabelProgress = floatingLabelProgress;
            this.Border = border;
            this.BorderGap = borderGap;
            this.AlignLabelWithHint = alignLabelWithHint;
            this.IsDense = isDense;
            this.VisualDensity = visualDensity;
            this.Icon = icon;
            this.Input = input;
            this.Label = label;
            this.Hint = hint;
            this.Prefix = prefix;
            this.Suffix = suffix;
            this.PrefixIcon = prefixIcon;
            this.SuffixIcon = suffixIcon;
            this.HelperError = helperError;
            this.Counter = counter;
            this.Container = container; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        public virtual bool IsCollapsed { get; set; }
        public virtual double FloatingLabelHeight { get; set; }
        public virtual double FloatingLabelProgress { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder Border { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._InputBorderGap BorderGap { get; set; }
        public virtual bool AlignLabelWithHint { get; set; }
        public virtual bool IsDense { get; set; }
        public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Input { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Hint { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Prefix { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Suffix { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget PrefixIcon { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget SuffixIcon { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget HelperError { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Counter { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Container { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderDecorationLayout
    {
        #region constructors
        public _RenderDecorationLayout(Dictionary<FlutterSDK.Rendering.Box.RenderBox, double> boxToBaseline = default(Dictionary<FlutterSDK.Rendering.Box.RenderBox, double>), double inputBaseline = default(double), double outlineBaseline = default(double), double subtextBaseline = default(double), double containerHeight = default(double), double subtextHeight = default(double))
        {
            this.BoxToBaseline = boxToBaseline;
            this.InputBaseline = inputBaseline;
            this.OutlineBaseline = outlineBaseline;
            this.SubtextBaseline = subtextBaseline;
            this.ContainerHeight = containerHeight;
            this.SubtextHeight = subtextHeight; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Dictionary<FlutterSDK.Rendering.Box.RenderBox, double> BoxToBaseline { get; set; }
        public virtual double InputBaseline { get; set; }
        public virtual double OutlineBaseline { get; set; }
        public virtual double SubtextBaseline { get; set; }
        public virtual double ContainerHeight { get; set; }
        public virtual double SubtextHeight { get; set; }
        #endregion

        #region methods
        #endregion
    }


    public class _RenderDecoration : FlutterSDK.Rendering.Box.RenderBox
    {
        #region constructors
        public _RenderDecoration(FlutterSDK.Material.Inputdecorator._Decoration decoration = default(FlutterSDK.Material.Inputdecorator._Decoration), TextDirection textDirection = default(TextDirection), TextBaseline textBaseline = default(TextBaseline), bool isFocused = default(bool), bool expands = default(bool), FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical = default(FlutterSDK.Painting.Alignment.TextAlignVertical))
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double SubtextGap { get; set; }
        public virtual Dictionary<FlutterSDK.Material.Inputdecorator._DecorationSlot, FlutterSDK.Rendering.Box.RenderBox> SlotToChild { get; set; }
        public virtual Dictionary<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Material.Inputdecorator._DecorationSlot> ChildToSlot { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Icon { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Input { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Label { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Hint { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Prefix { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Suffix { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _PrefixIcon { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _SuffixIcon { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _HelperError { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Counter { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Container { get; set; }
        internal virtual FlutterSDK.Material.Inputdecorator._Decoration _Decoration { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual TextBaseline _TextBaseline { get; set; }
        internal virtual FlutterSDK.Painting.Alignment.TextAlignVertical _TextAlignVertical { get; set; }
        internal virtual bool _IsFocused { get; set; }
        internal virtual bool _Expands { get; set; }
        internal virtual Matrix4 _LabelTransform { get; set; }
        public virtual FlutterSDK.Rendering.Box.RenderBox Icon { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Input { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Label { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Hint { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Prefix { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Suffix { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox PrefixIcon { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox SuffixIcon { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox HelperError { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Counter { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Container { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Iterable<FlutterSDK.Rendering.Box.RenderBox> _Children { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Inputdecorator._Decoration Decoration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextBaseline TextBaseline { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Alignment.TextAlignVertical TextAlignVertical { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsFocused { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Expands { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _IsOutlineAligned { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets ContentPadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private FlutterSDK.Rendering.Box.RenderBox _UpdateChild(FlutterSDK.Rendering.Box.RenderBox oldChild, FlutterSDK.Rendering.Box.RenderBox newChild, FlutterSDK.Material.Inputdecorator._DecorationSlot slot) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        public new void RedepthChildren() { throw new NotImplementedException(); }


        public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) { throw new NotImplementedException(); }


        public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }


        private double _MinWidth(FlutterSDK.Rendering.Box.RenderBox box, double height) { throw new NotImplementedException(); }


        private double _MaxWidth(FlutterSDK.Rendering.Box.RenderBox box, double height) { throw new NotImplementedException(); }


        private double _MinHeight(FlutterSDK.Rendering.Box.RenderBox box, double width) { throw new NotImplementedException(); }


        private Size _BoxSize(FlutterSDK.Rendering.Box.RenderBox box) { throw new NotImplementedException(); }


        private FlutterSDK.Rendering.Box.BoxParentData _BoxParentData(FlutterSDK.Rendering.Box.RenderBox box) { throw new NotImplementedException(); }


        private double _LayoutLineBox(FlutterSDK.Rendering.Box.RenderBox box, FlutterSDK.Rendering.Box.BoxConstraints constraints) { throw new NotImplementedException(); }


        private FlutterSDK.Material.Inputdecorator._RenderDecorationLayout _Layout(FlutterSDK.Rendering.Box.BoxConstraints layoutConstraints) { throw new NotImplementedException(); }


        private double _InterpolateThree(double begin, double middle, double end, FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        private double _LineHeight(double width, List<FlutterSDK.Rendering.Box.RenderBox> boxes) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeDistanceToActualBaseline(TextBaseline baseline) { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        private void _PaintLabel(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new bool HitTestSelf(FlutterBinding.UI.Offset position) { throw new NotImplementedException(); }


        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderDecorationElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        #region constructors
        public _RenderDecorationElement(FlutterSDK.Material.Inputdecorator._Decorator widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Dictionary<FlutterSDK.Material.Inputdecorator._DecorationSlot, FlutterSDK.Widgets.Framework.Element> SlotToChild { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Framework.Element, FlutterSDK.Material.Inputdecorator._DecorationSlot> ChildToSlot { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._Decorator Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Inputdecorator._RenderDecoration RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        private void _MountChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Inputdecorator._DecorationSlot slot) { throw new NotImplementedException(); }


        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot) { throw new NotImplementedException(); }


        private void _UpdateChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Inputdecorator._DecorationSlot slot) { throw new NotImplementedException(); }


        public new void Update(FlutterSDK.Material.Inputdecorator._Decorator newWidget) { throw new NotImplementedException(); }
        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }


        private void _UpdateRenderObject(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Material.Inputdecorator._DecorationSlot slot) { throw new NotImplementedException(); }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue) { throw new NotImplementedException(); }


        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue) { throw new NotImplementedException(); }

        #endregion
    }


    public class _Decorator : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        #region constructors
        public _Decorator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical = default(FlutterSDK.Painting.Alignment.TextAlignVertical), FlutterSDK.Material.Inputdecorator._Decoration decoration = default(FlutterSDK.Material.Inputdecorator._Decoration), TextDirection textDirection = default(TextDirection), TextBaseline textBaseline = default(TextBaseline), bool isFocused = default(bool), bool expands = default(bool))
        : base(key: key)
        {
            this.TextAlignVertical = textAlignVertical;
            this.Decoration = decoration;
            this.TextDirection = textDirection;
            this.TextBaseline = textBaseline;
            this.IsFocused = isFocused;
            this.Expands = expands; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Inputdecorator._Decoration Decoration { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual TextBaseline TextBaseline { get; set; }
        public virtual FlutterSDK.Painting.Alignment.TextAlignVertical TextAlignVertical { get; set; }
        public virtual bool IsFocused { get; set; }
        public virtual bool Expands { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Inputdecorator._RenderDecorationElement CreateElement() { throw new NotImplementedException(); }


        public new FlutterSDK.Material.Inputdecorator._RenderDecoration CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Inputdecorator._RenderDecoration renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _AffixText : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public _AffixText(bool labelIsFloating = default(bool), string text = default(string), FlutterSDK.Painting.Textstyle.TextStyle style = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            this.LabelIsFloating = labelIsFloating;
            this.Text = text;
            this.Style = style;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool LabelIsFloating { get; set; }
        public virtual string Text { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Defines the appearance of a Material Design text field.
    ///
    /// [InputDecorator] displays the visual elements of a Material Design text
    /// field around its input [child]. The visual elements themselves are defined
    /// by an [InputDecoration] object and their layout and appearance depend
    /// on the `baseStyle`, `textAlign`, `isFocused`, and `isEmpty` parameters.
    ///
    /// [TextField] uses this widget to decorate its [EditableText] child.
    ///
    /// [InputDecorator] can be used to create widgets that look and behave like a
    /// [TextField] but support other kinds of input.
    ///
    /// Requires one of its ancestors to be a [Material] widget.
    ///
    /// See also:
    ///
    ///  * [TextField], which uses an [InputDecorator] to display a border,
    ///    labels, and icons, around its [EditableText] child.
    ///  * [Decoration] and [DecoratedBox], for drawing arbitrary decorations
    ///    around other widgets.
    /// </Summary>
    public class InputDecorator : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public InputDecorator(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Inputdecorator.InputDecoration decoration = default(FlutterSDK.Material.Inputdecorator.InputDecoration), FlutterSDK.Painting.Textstyle.TextStyle baseStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), TextAlign textAlign = default(TextAlign), FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical = default(FlutterSDK.Painting.Alignment.TextAlignVertical), bool isFocused = false, bool isHovering = false, bool expands = false, bool isEmpty = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Decoration = decoration;
            this.BaseStyle = baseStyle;
            this.TextAlign = textAlign;
            this.TextAlignVertical = textAlignVertical;
            this.IsFocused = isFocused;
            this.IsHovering = isHovering;
            this.Expands = expands;
            this.IsEmpty = isEmpty;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration Decoration { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle BaseStyle { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual FlutterSDK.Painting.Alignment.TextAlignVertical TextAlignVertical { get; set; }
        public virtual bool IsFocused { get; set; }
        public virtual bool IsHovering { get; set; }
        public virtual bool Expands { get; set; }
        public virtual bool IsEmpty { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        internal virtual bool _LabelShouldWithdraw { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Material.Inputdecorator._InputDecoratorState CreateState() { throw new NotImplementedException(); }


        /// <Summary>
        /// The RenderBox that defines this decorator's "container". That's the
        /// area which is filled if [InputDecoration.filled] is true. It's the area
        /// adjacent to [InputDecoration.icon] and above the widgets that contain
        /// [InputDecoration.helperText], [InputDecoration.errorText], and
        /// [InputDecoration.counterText].
        ///
        /// [TextField] renders ink splashes within the container.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.RenderBox ContainerOf(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _InputDecoratorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Inputdecorator.InputDecorator>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _InputDecoratorState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _FloatingLabelController { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ShakingLabelController { get; set; }
        internal virtual FlutterSDK.Material.Inputdecorator._InputBorderGap _BorderGap { get; set; }
        internal virtual FlutterSDK.Material.Inputdecorator.InputDecoration _EffectiveDecoration { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration Decoration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextAlign TextAlign { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsFocused { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsHovering { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsEmpty { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _FloatingLabelEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _HasInlineLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual bool _ShouldShowLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void DidChangeDependencies() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _HandleChange() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Inputdecorator.InputDecorator old) { throw new NotImplementedException(); }


        private Color _GetActiveColor(FlutterSDK.Material.Themedata.ThemeData themeData) { throw new NotImplementedException(); }


        private Color _GetDefaultBorderColor(FlutterSDK.Material.Themedata.ThemeData themeData) { throw new NotImplementedException(); }


        private Color _GetFillColor(FlutterSDK.Material.Themedata.ThemeData themeData) { throw new NotImplementedException(); }


        private Color _GetHoverColor(FlutterSDK.Material.Themedata.ThemeData themeData) { throw new NotImplementedException(); }


        private Color _GetDefaultIconColor(FlutterSDK.Material.Themedata.ThemeData themeData) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Textstyle.TextStyle _GetInlineStyle(FlutterSDK.Material.Themedata.ThemeData themeData) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Textstyle.TextStyle _GetFloatingLabelStyle(FlutterSDK.Material.Themedata.ThemeData themeData) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Textstyle.TextStyle _GetHelperStyle(FlutterSDK.Material.Themedata.ThemeData themeData) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Textstyle.TextStyle _GetErrorStyle(FlutterSDK.Material.Themedata.ThemeData themeData) { throw new NotImplementedException(); }


        private FlutterSDK.Material.Inputborder.InputBorder _GetDefaultBorder(FlutterSDK.Material.Themedata.ThemeData themeData) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// The border, labels, icons, and styles used to decorate a Material
    /// Design text field.
    ///
    /// The [TextField] and [InputDecorator] classes use [InputDecoration] objects
    /// to describe their decoration. (In fact, this class is merely the
    /// configuration of an [InputDecorator], which does all the heavy lifting.)
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This sample shows how to style a `TextField` using an `InputDecorator`. The
    /// TextField displays a "send message" icon to the left of the input area,
    /// which is surrounded by a border an all sides. It displays the `hintText`
    /// inside the input area to help the user understand what input is required. It
    /// displays the `helperText` and `counterText` below the input area.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/input_decoration.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return TextField(
    ///     decoration: InputDecoration(
    ///       icon: Icon(Icons.send),
    ///       hintText: 'Hint Text',
    ///       helperText: 'Helper Text',
    ///       counterText: '0 characters',
    ///       border: const OutlineInputBorder(),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This sample shows how to style a "collapsed" `TextField` using an
    /// `InputDecorator`. The collapsed `TextField` surrounds the hint text and
    /// input area with a border, but does not add padding around them.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/input_decoration_collapsed.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return TextField(
    ///     decoration: InputDecoration.collapsed(
    ///       hintText: 'Hint Text',
    ///       border: OutlineInputBorder(),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This sample shows how to create a `TextField` with hint text, a red border
    /// on all sides, and an error message. To display a red border and error
    /// message, provide `errorText` to the `InputDecoration` constructor.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/input_decoration_error.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return TextField(
    ///     decoration: InputDecoration(
    ///       hintText: 'Hint Text',
    ///       errorText: 'Error Text',
    ///       border: OutlineInputBorder(),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    ///
    /// This sample shows how to style a `TextField` with a round border and
    /// additional text before and after the input area. It displays "Prefix" before
    /// the input area, and "Suffix" after the input area.
    ///
    /// ![](https://flutter.github.io/assets-for-api-docs/assets/material/input_decoration_prefix_suffix.png)
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   return TextFormField(
    ///     initialValue: 'abc',
    ///     decoration: const InputDecoration(
    ///       prefix: Text('Prefix'),
    ///       suffix: Text('Suffix'),
    ///       border: OutlineInputBorder(),
    ///     ),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [TextField], which is a text input widget that uses an
    ///    [InputDecoration].
    ///  * [InputDecorator], which is a widget that draws an [InputDecoration]
    ///    around an input child widget.
    ///  * [Decoration] and [DecoratedBox], for drawing borders and backgrounds
    ///    around a child widget.
    /// </Summary>
    public class InputDecoration
    {
        #region constructors
        public InputDecoration(FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), string labelText = default(string), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), string helperText = default(string), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), string hintText = default(string), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int hintMaxLines = default(int), string errorText = default(string), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int), bool hasFloatingPlaceholder = true, FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), bool isDense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget prefixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Rendering.Box.BoxConstraints prefixIconConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Widgets.Framework.Widget prefix = default(FlutterSDK.Widgets.Framework.Widget), string prefixText = default(string), FlutterSDK.Painting.Textstyle.TextStyle prefixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget suffixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget suffix = default(FlutterSDK.Widgets.Framework.Widget), string suffixText = default(string), FlutterSDK.Painting.Textstyle.TextStyle suffixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Rendering.Box.BoxConstraints suffixIconConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Widgets.Framework.Widget counter = default(FlutterSDK.Widgets.Framework.Widget), string counterText = default(string), FlutterSDK.Painting.Textstyle.TextStyle counterStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = default(bool), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder errorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedErrorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder disabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder enabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool enabled = true, string semanticCounterText = default(string), bool alignLabelWithHint = default(bool))
        : base()
        {
            this.Icon = icon;
            this.LabelText = labelText;
            this.LabelStyle = labelStyle;
            this.HelperText = helperText;
            this.HelperStyle = helperStyle;
            this.HelperMaxLines = helperMaxLines;
            this.HintText = hintText;
            this.HintStyle = hintStyle;
            this.HintMaxLines = hintMaxLines;
            this.ErrorText = errorText;
            this.ErrorStyle = errorStyle;
            this.ErrorMaxLines = errorMaxLines;
            this.HasFloatingPlaceholder = hasFloatingPlaceholder;
            this.FloatingLabelBehavior = floatingLabelBehavior;
            this.IsDense = isDense;
            this.ContentPadding = contentPadding;
            this.PrefixIcon = prefixIcon;
            this.PrefixIconConstraints = prefixIconConstraints;
            this.Prefix = prefix;
            this.PrefixText = prefixText;
            this.PrefixStyle = prefixStyle;
            this.SuffixIcon = suffixIcon;
            this.Suffix = suffix;
            this.SuffixText = suffixText;
            this.SuffixStyle = suffixStyle;
            this.SuffixIconConstraints = suffixIconConstraints;
            this.Counter = counter;
            this.CounterText = counterText;
            this.CounterStyle = counterStyle;
            this.Filled = filled;
            this.FillColor = fillColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.ErrorBorder = errorBorder;
            this.FocusedBorder = focusedBorder;
            this.FocusedErrorBorder = focusedErrorBorder;
            this.DisabledBorder = disabledBorder;
            this.EnabledBorder = enabledBorder;
            this.Border = border;
            this.Enabled = enabled;
            this.SemanticCounterText = semanticCounterText;
            this.AlignLabelWithHint = alignLabelWithHint; throw new NotImplementedException();
        }
        public static InputDecoration Collapsed(string hintText = default(string), bool hasFloatingPlaceholder = true, FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = false, FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool enabled = true)
        {
            var instance = new InputDecoration(); instance.HintText = hintText;
            instance.HasFloatingPlaceholder = hasFloatingPlaceholder;
            instance.FloatingLabelBehavior = floatingLabelBehavior;
            instance.HintStyle = hintStyle;
            instance.Filled = filled;
            instance.FillColor = fillColor;
            instance.FocusColor = focusColor;
            instance.HoverColor = hoverColor;
            instance.Border = border;
            instance.Enabled = enabled; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Icon { get; set; }
        public virtual string LabelText { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public virtual string HelperText { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle HelperStyle { get; set; }
        public virtual int HelperMaxLines { get; set; }
        public virtual string HintText { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle HintStyle { get; set; }
        public virtual int HintMaxLines { get; set; }
        public virtual string ErrorText { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle ErrorStyle { get; set; }
        public virtual int ErrorMaxLines { get; set; }
        public virtual bool HasFloatingPlaceholder { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior FloatingLabelBehavior { get; set; }
        public virtual bool IsDense { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        public virtual bool IsCollapsed { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget PrefixIcon { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints PrefixIconConstraints { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Prefix { get; set; }
        public virtual string PrefixText { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle PrefixStyle { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget SuffixIcon { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Suffix { get; set; }
        public virtual string SuffixText { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle SuffixStyle { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints SuffixIconConstraints { get; set; }
        public virtual string CounterText { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Counter { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle CounterStyle { get; set; }
        public virtual bool Filled { get; set; }
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder ErrorBorder { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder FocusedBorder { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder FocusedErrorBorder { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder DisabledBorder { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder EnabledBorder { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder Border { get; set; }
        public virtual bool Enabled { get; set; }
        public virtual string SemanticCounterText { get; set; }
        public virtual bool AlignLabelWithHint { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Creates a copy of this input decoration with the given fields replaced
        /// by the new values.
        ///
        /// Always sets [isCollapsed] to false.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration CopyWith(FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), string labelText = default(string), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), string helperText = default(string), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), string hintText = default(string), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int hintMaxLines = default(int), string errorText = default(string), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int), bool hasFloatingPlaceholder = default(bool), FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), bool isDense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget prefixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget prefix = default(FlutterSDK.Widgets.Framework.Widget), string prefixText = default(string), FlutterSDK.Rendering.Box.BoxConstraints prefixIconConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Painting.Textstyle.TextStyle prefixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget suffixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget suffix = default(FlutterSDK.Widgets.Framework.Widget), string suffixText = default(string), FlutterSDK.Painting.Textstyle.TextStyle suffixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Rendering.Box.BoxConstraints suffixIconConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Widgets.Framework.Widget counter = default(FlutterSDK.Widgets.Framework.Widget), string counterText = default(string), FlutterSDK.Painting.Textstyle.TextStyle counterStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = default(bool), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder errorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedErrorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder disabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder enabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool enabled = default(bool), string semanticCounterText = default(string), bool alignLabelWithHint = default(bool)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Used by widgets like [TextField] and [InputDecorator] to create a new
        /// [InputDecoration] with default values taken from the [theme].
        ///
        /// Only null valued properties from this [InputDecoration] are replaced
        /// by the corresponding values from [theme].
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration ApplyDefaults(FlutterSDK.Material.Inputdecorator.InputDecorationTheme theme) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        #endregion
    }


    /// <Summary>
    /// Defines the default appearance of [InputDecorator]s.
    ///
    /// This class is used to define the value of [ThemeData.inputDecorationTheme].
    /// The [InputDecorator], [TextField], and [TextFormField] widgets use
    /// the current input decoration theme to initialize null [InputDecoration]
    /// properties.
    ///
    /// The [InputDecoration.applyDefaults] method is used to combine a input
    /// decoration theme with an [InputDecoration] object.
    /// </Summary>
    public class InputDecorationTheme : IDiagnosticable
    {
        #region constructors
        public InputDecorationTheme(FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int), bool hasFloatingPlaceholder = true, FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), bool isDense = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool isCollapsed = false, FlutterSDK.Painting.Textstyle.TextStyle prefixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle suffixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle counterStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = false, FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder errorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedErrorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder disabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder enabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool alignLabelWithHint = false)
        : base()
        {
            this.LabelStyle = labelStyle;
            this.HelperStyle = helperStyle;
            this.HelperMaxLines = helperMaxLines;
            this.HintStyle = hintStyle;
            this.ErrorStyle = errorStyle;
            this.ErrorMaxLines = errorMaxLines;
            this.HasFloatingPlaceholder = hasFloatingPlaceholder;
            this.FloatingLabelBehavior = floatingLabelBehavior;
            this.IsDense = isDense;
            this.ContentPadding = contentPadding;
            this.IsCollapsed = isCollapsed;
            this.PrefixStyle = prefixStyle;
            this.SuffixStyle = suffixStyle;
            this.CounterStyle = counterStyle;
            this.Filled = filled;
            this.FillColor = fillColor;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.ErrorBorder = errorBorder;
            this.FocusedBorder = focusedBorder;
            this.FocusedErrorBorder = focusedErrorBorder;
            this.DisabledBorder = disabledBorder;
            this.EnabledBorder = enabledBorder;
            this.Border = border;
            this.AlignLabelWithHint = alignLabelWithHint; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle HelperStyle { get; set; }
        public virtual int HelperMaxLines { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle HintStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle ErrorStyle { get; set; }
        public virtual int ErrorMaxLines { get; set; }
        public virtual bool HasFloatingPlaceholder { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior FloatingLabelBehavior { get; set; }
        public virtual bool IsDense { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry ContentPadding { get; set; }
        public virtual bool IsCollapsed { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle PrefixStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle SuffixStyle { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle CounterStyle { get; set; }
        public virtual bool Filled { get; set; }
        public virtual FlutterBinding.UI.Color FillColor { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder ErrorBorder { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder FocusedBorder { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder FocusedErrorBorder { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder DisabledBorder { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder EnabledBorder { get; set; }
        public virtual FlutterSDK.Material.Inputborder.InputBorder Border { get; set; }
        public virtual bool AlignLabelWithHint { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Creates a copy of this object but with the given fields replaced with the
        /// new values.
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.InputDecorationTheme CopyWith(FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int), bool hasFloatingPlaceholder = default(bool), FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), bool isDense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool isCollapsed = default(bool), FlutterSDK.Painting.Textstyle.TextStyle prefixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle suffixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle counterStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = default(bool), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder errorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedErrorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder disabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder enabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool alignLabelWithHint = default(bool)) { throw new NotImplementedException(); }


        public new bool Equals(@Object other) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// Defines the behaviour of the floating label
    /// </Summary>
    public enum FloatingLabelBehavior
    {

        /// <Summary>
        /// The label will always be positioned within the content, or hidden.
        /// </Summary>
        Never,
        /// <Summary>
        /// The label will float when the input is focused, or has content.
        /// </Summary>
        Auto,
        /// <Summary>
        /// The label will always float above the content.
        /// </Summary>
        Always,
    }


    public enum _DecorationSlot
    {

        Icon,
        Input,
        Label,
        Hint,
        Prefix,
        Suffix,
        PrefixIcon,
        SuffixIcon,
        HelperError,
        Counter,
        Container,
    }

}
