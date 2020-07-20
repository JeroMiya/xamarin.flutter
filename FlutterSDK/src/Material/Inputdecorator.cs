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

        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            if (other.GetType() != GetType()) return false;
            return other is _InputBorderGap && other.Start == Start && other.Extent == Extent;
        }



        #endregion
    }


    public class _InputBorderTween : FlutterSDK.Animation.Tween.Tween<FlutterSDK.Material.Inputborder.InputBorder>
    {
        #region constructors
        public _InputBorderTween(FlutterSDK.Material.Inputborder.InputBorder begin = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder end = default(FlutterSDK.Material.Inputborder.InputBorder))
        : base(begin: begin, end: end)
        {

        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Material.Inputborder.InputBorder Lerp(double t) => BordersDefaultClass.ShapeBorder.Lerp(Begin, End, t) as InputBorder;


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
            this.HoverColorTween = hoverColorTween;
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

        public new void Paint(Canvas canvas, Size size)
        {
            InputBorder borderValue = Border.Evaluate(BorderAnimation);
            Rect canvasRect = Dart:uiDefaultClass.Offset.Zero & size;
            Color blendedFillColor = BlendedColor;
            if (blendedFillColor.Alpha > 0)
            {
                canvas.DrawPath(borderValue.GetOuterPath(canvasRect, textDirection: TextDirection), new Paint()..Color = blendedFillColor..Style = PaintingStyle.Fill);
            }

            borderValue.Paint(canvas, canvasRect, gapStart: Gap.Start, gapExtent: Gap.Extent, gapPercentage: GapAnimation.Value, textDirection: TextDirection);
        }




        public new bool ShouldRepaint(FlutterSDK.Material.Inputdecorator._InputBorderPainter oldPainter)
        {
            return BorderAnimation != oldPainter.BorderAnimation || HoverAnimation != oldPainter.HoverAnimation || GapAnimation != oldPainter.GapAnimation || Border != oldPainter.Border || Gap != oldPainter.Gap || TextDirection != oldPainter.TextDirection;
        }


        public new bool ShouldRepaint(FlutterSDK.Rendering.Custompaint.CustomPainter oldDelegate)
        {
            return BorderAnimation != oldPainter.BorderAnimation || HoverAnimation != oldPainter.HoverAnimation || GapAnimation != oldPainter.GapAnimation || Border != oldPainter.Border || Gap != oldPainter.Gap || TextDirection != oldPainter.TextDirection;
        }



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
            this.Child = child;
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

        public new FlutterSDK.Material.Inputdecorator._BorderContainerState CreateState() => new _BorderContainerState();


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

        public new void InitState()
        {
            base.InitState();
            _HoverColorController = new AnimationController(duration: _KHoverDuration, value: Widget.IsHovering ? 1.0 : 0.0, vsync: this);
            _Controller = new AnimationController(duration: InputdecoratorDefaultClass._KTransitionDuration, vsync: this);
            _BorderAnimation = new CurvedAnimation(parent: _Controller, curve: InputdecoratorDefaultClass._KTransitionCurve);
            _Border = new _InputBorderTween(begin: Widget.Border, end: Widget.Border);
            _HoverAnimation = new CurvedAnimation(parent: _HoverColorController, curve: CurvesDefaultClass.Curves.Linear);
            _HoverColorTween = new ColorTween(begin: ColorsDefaultClass.Colors.Transparent, end: Widget.HoverColor);
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            _HoverColorController.Dispose();
            base.Dispose();
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Inputdecorator._BorderContainer oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            if (Widget.Border != oldWidget.Border)
            {
                _Border = new _InputBorderTween(begin: oldWidget.Border, end: Widget.Border);
                ..Value = 0.0;
                _Controller.Forward();
            }

            if (Widget.HoverColor != oldWidget.HoverColor)
            {
                _HoverColorTween = new ColorTween(begin: ColorsDefaultClass.Colors.Transparent, end: Widget.HoverColor);
            }

            if (Widget.IsHovering != oldWidget.IsHovering)
            {
                if (Widget.IsHovering)
                {
                    _HoverColorController.Forward();
                }
                else
                {
                    _HoverColorController.Reverse();
                }

            }

        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new CustomPaint(foregroundPainter: new _InputBorderPainter(repaint: Listenable.Merge(new List<Listenable>() { _BorderAnimation, Widget.Gap, _HoverColorController }), borderAnimation: _BorderAnimation, border: _Border, gapAnimation: Widget.GapAnimation, gap: Widget.Gap, textDirection: BasicDefaultClass.Directionality.Of(context), fillColor: Widget.FillColor, hoverColorTween: _HoverColorTween, hoverAnimation: _HoverAnimation), child: Widget.Child);
        }



        #endregion
    }


    public class _Shaker : FlutterSDK.Widgets.Transitions.AnimatedWidget
    {
        #region constructors
        public _Shaker(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Animation.Animation.Animation<double> animation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, listenable: animation)
        {
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> Animation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double TranslateX { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new Transform(transform: Matrix4.TranslationValues(TranslateX, 0.0, 0.0), child: Child);
        }



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
            this.ErrorMaxLines = errorMaxLines;
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

        public new FlutterSDK.Material.Inputdecorator._HelperErrorState CreateState() => new _HelperErrorState();


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

        public new void InitState()
        {
            base.InitState();
            _Controller = new AnimationController(duration: InputdecoratorDefaultClass._KTransitionDuration, vsync: this);
            if (Widget.ErrorText != null)
            {
                _Error = _BuildError();
                _Controller.Value = 1.0;
            }
            else if (Widget.HelperText != null)
            {
                _Helper = _BuildHelper();
            }

            _Controller.AddListener(_HandleChange);
        }




        public new void Dispose()
        {
            _Controller.Dispose();
            base.Dispose();
        }




        private void _HandleChange()
        {
            SetState(() =>
            {
            }
            );
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Inputdecorator._HelperError old)
        {
            base.DidUpdateWidget(old);
            string newErrorText = Widget.ErrorText;
            string newHelperText = Widget.HelperText;
            string oldErrorText = old.ErrorText;
            string oldHelperText = old.HelperText;
            bool errorTextStateChanged = (newErrorText != null) != (oldErrorText != null);
            bool helperTextStateChanged = newErrorText == null && (newHelperText != null) != (oldHelperText != null);
            if (errorTextStateChanged || helperTextStateChanged)
            {
                if (newErrorText != null)
                {
                    _Error = _BuildError();
                    _Controller.Forward();
                }
                else if (newHelperText != null)
                {
                    _Helper = _BuildHelper();
                    _Controller.Reverse();
                }
                else
                {
                    _Controller.Reverse();
                }

            }

        }




        private FlutterSDK.Widgets.Framework.Widget _BuildHelper()
        {

            return new Semantics(container: true, child: new Opacity(opacity: 1.0 - _Controller.Value, child: new Text(Widget.HelperText, style: Widget.HelperStyle, textAlign: Widget.TextAlign, overflow: TextOverflow.Ellipsis, maxLines: Widget.HelperMaxLines)));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildError()
        {

            return new Semantics(container: true, liveRegion: true, child: new Opacity(opacity: _Controller.Value, child: new FractionalTranslation(translation: new Tween<Offset>(begin: new Offset(0.0, -0.25), end: new Offset(0.0, 0.0)).Evaluate(_Controller.View), child: new Text(Widget.ErrorText, style: Widget.ErrorStyle, textAlign: Widget.TextAlign, overflow: TextOverflow.Ellipsis, maxLines: Widget.ErrorMaxLines))));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (_Controller.IsDismissed)
            {
                _Error = null;
                if (Widget.HelperText != null)
                {
                    return _Helper = _BuildHelper();
                }
                else
                {
                    _Helper = null;
                    return Empty;
                }

            }

            if (_Controller.IsCompleted)
            {
                _Helper = null;
                if (Widget.ErrorText != null)
                {
                    return _Error = _BuildError();
                }
                else
                {
                    _Error = null;
                    return Empty;
                }

            }

            if (_Helper == null && Widget.ErrorText != null) return _BuildError();
            if (_Error == null && Widget.HelperText != null) return _BuildHelper();
            if (Widget.ErrorText != null)
            {
                return new Stack(children: new List<Widget>() { new Opacity(opacity: 1.0 - _Controller.Value, child: _Helper), _BuildError() });
            }

            if (Widget.HelperText != null)
            {
                return new Stack(children: new List<Widget>() { _BuildHelper(), new Opacity(opacity: _Controller.Value, child: _Error) });
            }

            return Empty;
        }



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
            this.Container = container;
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

        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            if (other.GetType() != GetType()) return false;
            return other is _Decoration && other.ContentPadding == ContentPadding && other.IsCollapsed == IsCollapsed && other.FloatingLabelHeight == FloatingLabelHeight && other.FloatingLabelProgress == FloatingLabelProgress && other.Border == Border && other.BorderGap == BorderGap && other.AlignLabelWithHint == AlignLabelWithHint && other.IsDense == IsDense && other.VisualDensity == VisualDensity && other.Icon == Icon && other.Input == Input && other.Label == Label && other.Hint == Hint && other.Prefix == Prefix && other.Suffix == Suffix && other.PrefixIcon == PrefixIcon && other.SuffixIcon == SuffixIcon && other.HelperError == HelperError && other.Counter == Counter && other.Container == Container;
        }



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
            this.SubtextHeight = subtextHeight;
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

        private FlutterSDK.Rendering.Box.RenderBox _UpdateChild(FlutterSDK.Rendering.Box.RenderBox oldChild, FlutterSDK.Rendering.Box.RenderBox newChild, FlutterSDK.Material.Inputdecorator._DecorationSlot slot)
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




        public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            if (Icon != null) visitor(Icon);
            if (Prefix != null) visitor(Prefix);
            if (PrefixIcon != null) visitor(PrefixIcon);
            if (Label != null)
            {
                visitor(Label);
            }

            if (Hint != null)
            {
                if (IsFocused)
                {
                    visitor(Hint);
                }
                else if (Label == null)
                {
                    visitor(Hint);
                }

            }

            if (Input != null) visitor(Input);
            if (SuffixIcon != null) visitor(SuffixIcon);
            if (Suffix != null) visitor(Suffix);
            if (Container != null) visitor(Container);
            if (HelperError != null) visitor(HelperError);
            if (Counter != null) visitor(Counter);
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            List<DiagnosticsNode> value = new List<DiagnosticsNode>() { };
            void Add(RenderBox child, string name)
            {
                if (child != null) value.Add(child.ToDiagnosticsNode(name: name));
            }

            Add(Icon, "icon");
            Add(Input, "input");
            Add(Label, "label");
            Add(Hint, "hint");
            Add(Prefix, "prefix");
            Add(Suffix, "suffix");
            Add(PrefixIcon, "prefixIcon");
            Add(SuffixIcon, "suffixIcon");
            Add(HelperError, "helperError");
            Add(Counter, "counter");
            Add(Container, "container");
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




        private double _MinHeight(FlutterSDK.Rendering.Box.RenderBox box, double width)
        {
            return box == null ? 0.0 : box.GetMinIntrinsicHeight(width);
        }




        private Size _BoxSize(FlutterSDK.Rendering.Box.RenderBox box) => box == null ? Dart : uiDefaultClass.Size.Zero:box.Size;



private FlutterSDK.Rendering.Box.BoxParentData _BoxParentData(FlutterSDK.Rendering.Box.RenderBox box) => box.ParentData as BoxParentData;



        private double _LayoutLineBox(FlutterSDK.Rendering.Box.RenderBox box, FlutterSDK.Rendering.Box.BoxConstraints constraints)
        {
            if (box == null)
            {
                return 0.0;
            }

            box.Layout(constraints, parentUsesSize: true);
            double baseline = box.GetDistanceToBaseline(TextBaseline.Alphabetic);

            return baseline;
        }




        private FlutterSDK.Material.Inputdecorator._RenderDecorationLayout _Layout(FlutterSDK.Rendering.Box.BoxConstraints layoutConstraints)
        {

            Dictionary<RenderBox, double> boxToBaseline = new Dictionary<RenderBox, double> { };
            BoxConstraints boxConstraints = layoutConstraints.Loosen();
            boxToBaseline[Prefix] = _LayoutLineBox(Prefix, boxConstraints);
            boxToBaseline[Suffix] = _LayoutLineBox(Suffix, boxConstraints);
            boxToBaseline[Icon] = _LayoutLineBox(Icon, boxConstraints);
            boxToBaseline[PrefixIcon] = _LayoutLineBox(PrefixIcon, boxConstraints);
            boxToBaseline[SuffixIcon] = _LayoutLineBox(SuffixIcon, boxConstraints);
            double inputWidth = Math.Dart:mathDefaultClass.Max(0.0, Constraints.MaxWidth - (_BoxSize(Icon).Width + ContentPadding.Left + _BoxSize(PrefixIcon).Width + _BoxSize(Prefix).Width + _BoxSize(Suffix).Width + _BoxSize(SuffixIcon).Width + ContentPadding.Right));
            boxToBaseline[Label] = _LayoutLineBox(Label, boxConstraints.CopyWith(maxWidth: inputWidth));
            boxToBaseline[Hint] = _LayoutLineBox(Hint, boxConstraints.CopyWith(minWidth: inputWidth, maxWidth: inputWidth));
            boxToBaseline[Counter] = _LayoutLineBox(Counter, boxConstraints);
            boxToBaseline[HelperError] = _LayoutLineBox(HelperError, boxConstraints.CopyWith(maxWidth: Math.Dart:mathDefaultClass.Max(0.0, boxConstraints.MaxWidth - _BoxSize(Icon).Width - _BoxSize(Counter).Width - ContentPadding.Horizontal)));
            double labelHeight = Label == null ? 0 : Decoration.FloatingLabelHeight;
            double topHeight = Decoration.Border.IsOutline ? Math.Dart : mathDefaultClass.Max(labelHeight - boxToBaseline[Label], 0):labelHeight;
            double counterHeight = Counter == null ? 0 : boxToBaseline[Counter] + SubtextGap;
            bool helperErrorExists = HelperError?.Size != null && HelperError.Size.Height > 0;
            double helperErrorHeight = !helperErrorExists ? 0 : HelperError.Size.Height + SubtextGap;
            double bottomHeight = Math.Dart:mathDefaultClass.Max(counterHeight, helperErrorHeight);
            boxToBaseline[Input] = _LayoutLineBox(Input, boxConstraints.Deflate(EdgeInsets.Only(top: ContentPadding.Top + topHeight, bottom: ContentPadding.Bottom + bottomHeight)).CopyWith(minWidth: inputWidth, maxWidth: inputWidth));
            double hintHeight = Hint == null ? 0 : Hint.Size.Height;
            double inputDirectHeight = Input == null ? 0 : Input.Size.Height;
            double inputHeight = Math.Dart:mathDefaultClass.Max(hintHeight, inputDirectHeight);
            double inputInternalBaseline = Math.Dart:mathDefaultClass.Max(boxToBaseline[Input], boxToBaseline[Hint]);
            double prefixHeight = Prefix == null ? 0 : Prefix.Size.Height;
            double suffixHeight = Suffix == null ? 0 : Suffix.Size.Height;
            double fixHeight = Math.Dart:mathDefaultClass.Max(boxToBaseline[Prefix], boxToBaseline[Suffix]);
            double fixAboveInput = Math.Dart:mathDefaultClass.Max(0, fixHeight - inputInternalBaseline);
            double fixBelowBaseline = Math.Dart:mathDefaultClass.Max(prefixHeight - boxToBaseline[Prefix], suffixHeight - boxToBaseline[Suffix]);
            double fixBelowInput = Math.Dart:mathDefaultClass.Max(0, fixBelowBaseline - (inputHeight - inputInternalBaseline));
            Offset densityOffset = Decoration.VisualDensity.BaseSizeAdjustment;
            double prefixIconHeight = PrefixIcon == null ? 0 : PrefixIcon.Size.Height;
            double suffixIconHeight = SuffixIcon == null ? 0 : SuffixIcon.Size.Height;
            double fixIconHeight = Math.Dart:mathDefaultClass.Max(prefixIconHeight, suffixIconHeight);
            double contentHeight = Math.Dart:mathDefaultClass.Max(fixIconHeight, topHeight + ContentPadding.Top + fixAboveInput + inputHeight + fixBelowInput + ContentPadding.Bottom + densityOffset.Dy);
            double minContainerHeight = Decoration.IsDense || Expands ? 0.0 : ConstantsDefaultClass.KMinInteractiveDimension + densityOffset.Dy;
            double maxContainerHeight = boxConstraints.MaxHeight - bottomHeight + densityOffset.Dy;
            double containerHeight = Expands ? maxContainerHeight : Math.Dart:mathDefaultClass.Min(Math.Dart:mathDefaultClass.Max(contentHeight, minContainerHeight), maxContainerHeight);
            double interactiveAdjustment = minContainerHeight > contentHeight ? (minContainerHeight - contentHeight) / 2.0 : 0.0;
            double overflow = Math.Dart:mathDefaultClass.Max(0, contentHeight - maxContainerHeight);
            double textAlignVerticalFactor = (TextAlignVertical.y + 1.0) / 2.0;
            double baselineAdjustment = fixAboveInput - overflow * (1 - textAlignVerticalFactor);
            double topInputBaseline = ContentPadding.Top + topHeight + inputInternalBaseline + baselineAdjustment + interactiveAdjustment;
            double maxContentHeight = containerHeight - ContentPadding.Top - topHeight - ContentPadding.Bottom;
            double alignableHeight = fixAboveInput + inputHeight + fixBelowInput;
            double maxVerticalOffset = maxContentHeight - alignableHeight;
            double textAlignVerticalOffset = maxVerticalOffset * textAlignVerticalFactor;
            double inputBaseline = topInputBaseline + textAlignVerticalOffset + densityOffset.Dy / 2.0;
            double outlineCenterBaseline = inputInternalBaseline + baselineAdjustment / 2.0 + (containerHeight - (2.0 + inputHeight)) / 2.0;
            double outlineTopBaseline = topInputBaseline;
            double outlineBottomBaseline = topInputBaseline + maxVerticalOffset;
            double outlineBaseline = _InterpolateThree(outlineTopBaseline, outlineCenterBaseline, outlineBottomBaseline, TextAlignVertical);
            double subtextCounterBaseline = 0;
            double subtextHelperBaseline = 0;
            double subtextCounterHeight = 0;
            double subtextHelperHeight = 0;
            if (Counter != null)
            {
                subtextCounterBaseline = containerHeight + SubtextGap + boxToBaseline[Counter];
                subtextCounterHeight = Counter.Size.Height + SubtextGap;
            }

            if (helperErrorExists)
            {
                subtextHelperBaseline = containerHeight + SubtextGap + boxToBaseline[HelperError];
                subtextHelperHeight = helperErrorHeight;
            }

            double subtextBaseline = Math.Dart:mathDefaultClass.Max(subtextCounterBaseline, subtextHelperBaseline);
            double subtextHeight = Math.Dart:mathDefaultClass.Max(subtextCounterHeight, subtextHelperHeight);
            return new _RenderDecorationLayout(boxToBaseline: boxToBaseline, containerHeight: containerHeight, inputBaseline: inputBaseline, outlineBaseline: outlineBaseline, subtextBaseline: subtextBaseline, subtextHeight: subtextHeight);
        }




        private double _InterpolateThree(double begin, double middle, double end, FlutterSDK.Painting.Alignment.TextAlignVertical textAlignVertical)
        {
            if (textAlignVertical.y <= 0)
            {
                if (begin >= middle)
                {
                    return middle;
                }

                double t = textAlignVertical.y + 1;
                return begin + (middle - begin) * t;
            }

            if (middle >= end)
            {
                return middle;
            }

            double t = textAlignVertical.y;
            return middle + (end - middle) * t;
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            return _MinWidth(Icon, height) + ContentPadding.Left + _MinWidth(PrefixIcon, height) + _MinWidth(Prefix, height) + Math.Dart:mathDefaultClass.Max(_MinWidth(Input, height), _MinWidth(Hint, height)) + _MinWidth(Suffix, height) + _MinWidth(SuffixIcon, height) + ContentPadding.Right;
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            return _MaxWidth(Icon, height) + ContentPadding.Left + _MaxWidth(PrefixIcon, height) + _MaxWidth(Prefix, height) + Math.Dart:mathDefaultClass.Max(_MaxWidth(Input, height), _MaxWidth(Hint, height)) + _MaxWidth(Suffix, height) + _MaxWidth(SuffixIcon, height) + ContentPadding.Right;
        }




        private double _LineHeight(double width, List<FlutterSDK.Rendering.Box.RenderBox> boxes)
        {
            double height = 0.0;
            foreach (RenderBox box in boxes)
            {
                if (box == null) continue;
                height = Math.Dart:mathDefaultClass.Max(_MinHeight(box, width), height);
            }

            return height;
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            double subtextHeight = _LineHeight(width, new List<RenderBox>() { HelperError, Counter });
            if (subtextHeight > 0.0) subtextHeight += SubtextGap;
            return ContentPadding.Top + (Label == null ? 0.0 : Decoration.FloatingLabelHeight) + _LineHeight(width, new List<RenderBox>() { Prefix, Input, Suffix }) + subtextHeight + ContentPadding.Bottom;
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            return ComputeMinIntrinsicHeight(width);
        }




        public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
        {
            return _BoxParentData(Input).Offset.Dy + Input.ComputeDistanceToActualBaseline(baseline);
        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            _LabelTransform = null;
            _RenderDecorationLayout layout = _Layout(constraints);
            double overallWidth = constraints.MaxWidth;
            double overallHeight = layout.ContainerHeight + layout.SubtextHeight;
            if (Container != null)
            {
                BoxConstraints containerConstraints = BoxConstraints.TightFor(height: layout.ContainerHeight, width: overallWidth - _BoxSize(Icon).Width);
                Container.Layout(containerConstraints, parentUsesSize: true);
                double x = default(double);
                switch (TextDirection) { case TextDirection.Rtl: x = 0.0; break; case TextDirection.Ltr: x = _BoxSize(Icon).Width; break; }
                _BoxParentData(Container).Offset = new Offset(x, 0.0);
            }

            double height = default(double);
            double CenterLayout(RenderBox box, double x)
            {
                _BoxParentData(box).Offset = new Offset(x, (height - box.Size.Height) / 2.0);
                return box.Size.Width;
            }

            double baseline = default(double);
            double BaselineLayout(RenderBox box, double x)
            {
                _BoxParentData(box).Offset = new Offset(x, baseline - layout.BoxToBaseline[box]);
                return box.Size.Width;
            }

            double left = ContentPadding.Left;
            double right = overallWidth - ContentPadding.Right;
            height = layout.ContainerHeight;
            baseline = _IsOutlineAligned ? layout.OutlineBaseline : layout.InputBaseline;
            if (Icon != null)
            {
                double x = default(double);
                switch (TextDirection) { case TextDirection.Rtl: x = overallWidth - Icon.Size.Width; break; case TextDirection.Ltr: x = 0.0; break; }
                CenterLayout(Icon, x);
            }

            switch (TextDirection)
            {
                case TextDirection.Rtl:
                    {
                        double start = right - _BoxSize(Icon).Width;
                        double end = left;
                        if (PrefixIcon != null)
                        {
                            start += ContentPadding.Left;
                            start -= CenterLayout(PrefixIcon, start - PrefixIcon.Size.Width);
                        }

                        if (Label != null)
                        {
                            if (Decoration.AlignLabelWithHint)
                            {
                                BaselineLayout(Label, start - Label.Size.Width);
                            }
                            else
                            {
                                CenterLayout(Label, start - Label.Size.Width);
                            }

                        }

                        if (Prefix != null) start -= BaselineLayout(Prefix, start - Prefix.Size.Width);
                        if (Input != null) BaselineLayout(Input, start - Input.Size.Width);
                        if (Hint != null) BaselineLayout(Hint, start - Hint.Size.Width);
                        if (SuffixIcon != null)
                        {
                            end -= ContentPadding.Left;
                            end += CenterLayout(SuffixIcon, end);
                        }

                        if (Suffix != null) end += BaselineLayout(Suffix, end);
                        break;
                    }
                case TextDirection.Ltr:
                    {
                        double start = left + _BoxSize(Icon).Width;
                        double end = right;
                        if (PrefixIcon != null)
                        {
                            start -= ContentPadding.Left;
                            start += CenterLayout(PrefixIcon, start);
                        }

                        if (Label != null)
                        {
                            if (Decoration.AlignLabelWithHint)
                            {
                                BaselineLayout(Label, start);
                            }
                            else
                            {
                                CenterLayout(Label, start);
                            }

                        }

                        if (Prefix != null) start += BaselineLayout(Prefix, start);
                        if (Input != null) BaselineLayout(Input, start);
                        if (Hint != null) BaselineLayout(Hint, start);
                        if (SuffixIcon != null)
                        {
                            end += ContentPadding.Right;
                            end -= CenterLayout(SuffixIcon, end - SuffixIcon.Size.Width);
                        }

                        if (Suffix != null) end -= BaselineLayout(Suffix, end - Suffix.Size.Width);
                        break;
                    }
            }
            if (HelperError != null || Counter != null)
            {
                height = layout.SubtextHeight;
                baseline = layout.SubtextBaseline;
                switch (TextDirection) { case TextDirection.Rtl: if (HelperError != null) BaselineLayout(HelperError, right - HelperError.Size.Width - _BoxSize(Icon).Width); if (Counter != null) BaselineLayout(Counter, left); break; case TextDirection.Ltr: if (HelperError != null) BaselineLayout(HelperError, left + _BoxSize(Icon).Width); if (Counter != null) BaselineLayout(Counter, right - Counter.Size.Width); break; }
            }

            if (Label != null)
            {
                double labelX = _BoxParentData(Label).Offset.Dx;
                switch (TextDirection) { case TextDirection.Rtl: Decoration.BorderGap.Start = labelX + Label.Size.Width; break; case TextDirection.Ltr: Decoration.BorderGap.Start = labelX - _BoxSize(Icon).Width; break; }
                Decoration.BorderGap.Extent = Label.Size.Width * 0.75;
            }
            else
            {
                Decoration.BorderGap.Start = null;
                Decoration.BorderGap.Extent = 0.0;
            }

            Size = constraints.Constrain(new Size(overallWidth, overallHeight));


        }




        private void _PaintLabel(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            context.PaintChild(Label, offset);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            void DoPaint(RenderBox child)
            {
                if (child != null) context.PaintChild(child, _BoxParentData(child).Offset + offset);
            }

            DoPaint(Container);
            if (Label != null)
            {
                Offset labelOffset = _BoxParentData(Label).Offset;
                double labelHeight = Label.Size.Height;
                double t = Decoration.FloatingLabelProgress;
                bool isOutlineBorder = Decoration.Border != null && Decoration.Border.IsOutline;
                double floatingY = isOutlineBorder ? -labelHeight * 0.25 : ContentPadding.Top;
                double scale = Dart:uiDefaultClass.LerpDouble(1.0, 0.75, t);
                double dx = default(double);
                switch (TextDirection) { case TextDirection.Rtl: dx = labelOffset.Dx + Label.Size.Width * (1.0 - scale); break; case TextDirection.Ltr: dx = labelOffset.Dx; break; }
                double dy = Dart:uiDefaultClass.LerpDouble(0.0, floatingY - labelOffset.Dy, t);
                _LabelTransform = Matrix4.Identity();
                Matrix4.Identity().Translate(dx, labelOffset.Dy + dy);
                Matrix4.Identity().Scale(scale);
                context.PushTransform(NeedsCompositing, offset, _LabelTransform, _PaintLabel);
            }

            DoPaint(Icon);
            DoPaint(Prefix);
            DoPaint(Suffix);
            DoPaint(PrefixIcon);
            DoPaint(SuffixIcon);
            DoPaint(Hint);
            DoPaint(Input);
            DoPaint(HelperError);
            DoPaint(Counter);
        }




        public new bool HitTestSelf(FlutterBinding.UI.Offset position) => true;



        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {

            foreach (RenderBox child in _Children)
            {
                Offset offset = _BoxParentData(child).Offset;
                bool isHit = result.AddWithPaintOffset(offset: offset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
                {

                    return child.HitTest(result, position: transformed);
                }
                );
                if (isHit) return true;
            }

            return false;
        }




        public new void ApplyPaintTransform(FlutterSDK.Rendering.@object.RenderObject child, Matrix4 transform)
        {
            if (child == Label && _LabelTransform != null)
            {
                Offset labelOffset = _BoxParentData(Label).Offset;
                ;
                transform.Multiply(_LabelTransform);
                transform.Translate(-labelOffset.Dx, -labelOffset.Dy);
            }

            base.ApplyPaintTransform(child, transform);
        }



        #endregion
    }


    public class _RenderDecorationElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        #region constructors
        public _RenderDecorationElement(FlutterSDK.Material.Inputdecorator._Decorator widget)
        : base(widget)
        {

        }
        #endregion

        #region fields
        public virtual Dictionary<FlutterSDK.Material.Inputdecorator._DecorationSlot, FlutterSDK.Widgets.Framework.Element> SlotToChild { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Framework.Element, FlutterSDK.Material.Inputdecorator._DecorationSlot> ChildToSlot { get; set; }
        public virtual FlutterSDK.Material.Inputdecorator._Decorator Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Inputdecorator._RenderDecoration RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
        {
            SlotToChild.Values.ForEach(visitor);
        }




        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
        {


            _DecorationSlot slot = ChildToSlot[child];
            ChildToSlot.Remove(child);
            SlotToChild.Remove(slot);
            base.ForgetChild(child);
        }




        private void _MountChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Inputdecorator._DecorationSlot slot)
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
            _MountChild(Widget.Decoration.Icon, _DecorationSlot.Icon);
            _MountChild(Widget.Decoration.Input, _DecorationSlot.Input);
            _MountChild(Widget.Decoration.Label, _DecorationSlot.Label);
            _MountChild(Widget.Decoration.Hint, _DecorationSlot.Hint);
            _MountChild(Widget.Decoration.Prefix, _DecorationSlot.Prefix);
            _MountChild(Widget.Decoration.Suffix, _DecorationSlot.Suffix);
            _MountChild(Widget.Decoration.PrefixIcon, _DecorationSlot.PrefixIcon);
            _MountChild(Widget.Decoration.SuffixIcon, _DecorationSlot.SuffixIcon);
            _MountChild(Widget.Decoration.HelperError, _DecorationSlot.HelperError);
            _MountChild(Widget.Decoration.Counter, _DecorationSlot.Counter);
            _MountChild(Widget.Decoration.Container, _DecorationSlot.Container);
        }




        private void _UpdateChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Inputdecorator._DecorationSlot slot)
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




        public new void Update(FlutterSDK.Material.Inputdecorator._Decorator newWidget)
        {
            base.Update(newWidget);

            _UpdateChild(Widget.Decoration.Icon, _DecorationSlot.Icon);
            _UpdateChild(Widget.Decoration.Input, _DecorationSlot.Input);
            _UpdateChild(Widget.Decoration.Label, _DecorationSlot.Label);
            _UpdateChild(Widget.Decoration.Hint, _DecorationSlot.Hint);
            _UpdateChild(Widget.Decoration.Prefix, _DecorationSlot.Prefix);
            _UpdateChild(Widget.Decoration.Suffix, _DecorationSlot.Suffix);
            _UpdateChild(Widget.Decoration.PrefixIcon, _DecorationSlot.PrefixIcon);
            _UpdateChild(Widget.Decoration.SuffixIcon, _DecorationSlot.SuffixIcon);
            _UpdateChild(Widget.Decoration.HelperError, _DecorationSlot.HelperError);
            _UpdateChild(Widget.Decoration.Counter, _DecorationSlot.Counter);
            _UpdateChild(Widget.Decoration.Container, _DecorationSlot.Container);
        }


        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
        {
            base.Update(newWidget);

            _UpdateChild(Widget.Decoration.Icon, _DecorationSlot.Icon);
            _UpdateChild(Widget.Decoration.Input, _DecorationSlot.Input);
            _UpdateChild(Widget.Decoration.Label, _DecorationSlot.Label);
            _UpdateChild(Widget.Decoration.Hint, _DecorationSlot.Hint);
            _UpdateChild(Widget.Decoration.Prefix, _DecorationSlot.Prefix);
            _UpdateChild(Widget.Decoration.Suffix, _DecorationSlot.Suffix);
            _UpdateChild(Widget.Decoration.PrefixIcon, _DecorationSlot.PrefixIcon);
            _UpdateChild(Widget.Decoration.SuffixIcon, _DecorationSlot.SuffixIcon);
            _UpdateChild(Widget.Decoration.HelperError, _DecorationSlot.HelperError);
            _UpdateChild(Widget.Decoration.Counter, _DecorationSlot.Counter);
            _UpdateChild(Widget.Decoration.Container, _DecorationSlot.Container);
        }




        private void _UpdateRenderObject(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Material.Inputdecorator._DecorationSlot slot)
        {
            switch (slot) { case _DecorationSlot.Icon: RenderObject.Icon = child; break; case _DecorationSlot.Input: RenderObject.Input = child; break; case _DecorationSlot.Label: RenderObject.Label = child; break; case _DecorationSlot.Hint: RenderObject.Hint = child; break; case _DecorationSlot.Prefix: RenderObject.Prefix = child; break; case _DecorationSlot.Suffix: RenderObject.Suffix = child; break; case _DecorationSlot.PrefixIcon: RenderObject.PrefixIcon = child; break; case _DecorationSlot.SuffixIcon: RenderObject.SuffixIcon = child; break; case _DecorationSlot.HelperError: RenderObject.HelperError = child; break; case _DecorationSlot.Counter: RenderObject.Counter = child; break; case _DecorationSlot.Container: RenderObject.Container = child; break; }
        }




        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue)
        {


            _DecorationSlot slot = slotValue as _DecorationSlot;
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
            this.Expands = expands;
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

        public new FlutterSDK.Material.Inputdecorator._RenderDecorationElement CreateElement() => new _RenderDecorationElement(this);



        public new FlutterSDK.Material.Inputdecorator._RenderDecoration CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return new _RenderDecoration(decoration: Decoration, textDirection: TextDirection, textBaseline: TextBaseline, textAlignVertical: TextAlignVertical, isFocused: IsFocused, expands: Expands);
        }




        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Inputdecorator._RenderDecoration renderObject)
        {
            ..Decoration = Decoration..TextDirection = TextDirection..TextBaseline = TextBaseline..Expands = Expands..IsFocused = IsFocused;
        }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
        {
            ..Decoration = Decoration..TextDirection = TextDirection..TextBaseline = TextBaseline..Expands = Expands..IsFocused = IsFocused;
        }



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
            this.Child = child;
        }
        #endregion

        #region fields
        public virtual bool LabelIsFloating { get; set; }
        public virtual string Text { get; set; }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle Style { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            return TextDefaultClass.DefaultTextStyle.Merge(style: Style, child: new AnimatedOpacity(duration: InputdecoratorDefaultClass._KTransitionDuration, curve: InputdecoratorDefaultClass._KTransitionCurve, opacity: LabelIsFloating ? 1.0 : 0.0, child: Child ?? new Text(Text, style: Style)));
        }



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
            this.Child = child;
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

        public new FlutterSDK.Material.Inputdecorator._InputDecoratorState CreateState() => new _InputDecoratorState();



        /// <Summary>
        /// The RenderBox that defines this decorator's "container". That's the
        /// area which is filled if [InputDecoration.filled] is true. It's the area
        /// adjacent to [InputDecoration.icon] and above the widgets that contain
        /// [InputDecoration.helperText], [InputDecoration.errorText], and
        /// [InputDecoration.counterText].
        ///
        /// [TextField] renders ink splashes within the container.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Box.RenderBox ContainerOf(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            _RenderDecoration result = context.FindAncestorRenderObjectOfType();
            return result?.Container;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<InputDecoration>("decoration", Decoration));
            properties.Add(new DiagnosticsProperty<TextStyle>("baseStyle", BaseStyle, defaultValue: null));
            properties.Add(new DiagnosticsProperty<bool>("isFocused", IsFocused));
            properties.Add(new DiagnosticsProperty<bool>("expands", Expands, defaultValue: false));
            properties.Add(new DiagnosticsProperty<bool>("isEmpty", IsEmpty()));
        }



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

        public new void InitState()
        {
            base.InitState();
            bool labelIsInitiallyFloating = Widget.Decoration.FloatingLabelBehavior == FloatingLabelBehavior.Always || (Widget.Decoration.HasFloatingPlaceholder && Widget._LabelShouldWithdraw);
            _FloatingLabelController = new AnimationController(duration: InputdecoratorDefaultClass._KTransitionDuration, vsync: this, value: labelIsInitiallyFloating ? 1.0 : 0.0);
            _FloatingLabelController.AddListener(_HandleChange);
            _ShakingLabelController = new AnimationController(duration: InputdecoratorDefaultClass._KTransitionDuration, vsync: this);
        }




        public new void DidChangeDependencies()
        {
            base.DidChangeDependencies();
            _EffectiveDecoration = null;
        }




        public new void Dispose()
        {
            _FloatingLabelController.Dispose();
            _ShakingLabelController.Dispose();
            base.Dispose();
        }




        private void _HandleChange()
        {
            SetState(() =>
            {
            }
            );
        }




        public new void DidUpdateWidget(FlutterSDK.Material.Inputdecorator.InputDecorator old)
        {
            base.DidUpdateWidget(old);
            if (Widget.Decoration != old.Decoration) _EffectiveDecoration = null;
            bool floatBehaviourChanged = Widget.Decoration.FloatingLabelBehavior != old.Decoration.FloatingLabelBehavior || Widget.Decoration.HasFloatingPlaceholder != old.Decoration.HasFloatingPlaceholder;
            if (Widget._LabelShouldWithdraw != old._LabelShouldWithdraw || floatBehaviourChanged)
            {
                if (_FloatingLabelEnabled && (Widget._LabelShouldWithdraw || Widget.Decoration.FloatingLabelBehavior == FloatingLabelBehavior.Always)) _FloatingLabelController.Forward(); else _FloatingLabelController.Reverse();
            }

            string errorText = Decoration.ErrorText;
            string oldErrorText = old.Decoration.ErrorText;
            if (_FloatingLabelController.IsCompleted && errorText != null && errorText != oldErrorText)
            {
                ..Value = 0.0;
                _ShakingLabelController.Forward();
            }

        }




        private Color _GetActiveColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (IsFocused)
            {
                switch (themeData.Brightness) { case Brightness.Dark: return themeData.AccentColor; case Brightness.Light: return themeData.PrimaryColor; }
            }

            return themeData.HintColor;
        }




        private Color _GetDefaultBorderColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (IsFocused)
            {
                switch (themeData.Brightness) { case Brightness.Dark: return themeData.AccentColor; case Brightness.Light: return themeData.PrimaryColor; }
            }

            if (Decoration.Filled)
            {
                return themeData.HintColor;
            }

            Color enabledColor = themeData.ColorScheme.OnSurface.WithOpacity(0.38);
            if (IsHovering)
            {
                Color hoverColor = Decoration.HoverColor ?? themeData.InputDecorationTheme?.HoverColor ?? themeData.HoverColor;
                return Dart:uiDefaultClass.Color.AlphaBlend(hoverColor.WithOpacity(0.12), enabledColor);
            }

            return enabledColor;
        }




        private Color _GetFillColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (Decoration.Filled != true) return ColorsDefaultClass.Colors.Transparent;
            if (Decoration.FillColor != null) return Decoration.FillColor;
            Color darkEnabled = new Color(0x1AFFFFFF);
            Color darkDisabled = new Color(0x0DFFFFFF);
            Color lightEnabled = new Color(0x0A000000);
            Color lightDisabled = new Color(0x05000000);
            switch (themeData.Brightness) { case Brightness.Dark: return Decoration.Enabled ? darkEnabled : darkDisabled; case Brightness.Light: return Decoration.Enabled ? lightEnabled : lightDisabled; }
            return lightEnabled;
        }




        private Color _GetHoverColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (Decoration.Filled == null || !Decoration.Filled || IsFocused || !Decoration.Enabled) return ColorsDefaultClass.Colors.Transparent;
            return Decoration.HoverColor ?? themeData.InputDecorationTheme?.HoverColor ?? themeData.HoverColor;
        }




        private Color _GetDefaultIconColor(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (!Decoration.Enabled) return themeData.DisabledColor;
            switch (themeData.Brightness) { case Brightness.Dark: return ColorsDefaultClass.Colors.White70; case Brightness.Light: return ColorsDefaultClass.Colors.Black45; default: return themeData.IconTheme.Color; }
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _GetInlineStyle(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            return themeData.TextTheme.Subtitle1.Merge(Widget.BaseStyle).CopyWith(color: Decoration.Enabled ? themeData.HintColor : themeData.DisabledColor);
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _GetFloatingLabelStyle(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            Color color = Decoration.ErrorText != null ? Decoration.ErrorStyle?.Color ?? themeData.ErrorColor : _GetActiveColor(themeData);
            TextStyle style = themeData.TextTheme.Subtitle1.Merge(Widget.BaseStyle);
            return style.CopyWith(color: Decoration.Enabled ? color : themeData.DisabledColor).Merge(Decoration.LabelStyle);
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _GetHelperStyle(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            Color color = Decoration.Enabled ? themeData.HintColor : ColorsDefaultClass.Colors.Transparent;
            return themeData.TextTheme.Caption.CopyWith(color: color).Merge(Decoration.HelperStyle);
        }




        private FlutterSDK.Painting.Textstyle.TextStyle _GetErrorStyle(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            Color color = Decoration.Enabled ? themeData.ErrorColor : ColorsDefaultClass.Colors.Transparent;
            return themeData.TextTheme.Caption.CopyWith(color: color).Merge(Decoration.ErrorStyle);
        }




        private FlutterSDK.Material.Inputborder.InputBorder _GetDefaultBorder(FlutterSDK.Material.Themedata.ThemeData themeData)
        {
            if (Decoration.Border?.BorderSide == BordersDefaultClass.BorderSide.None)
            {
                return Decoration.Border;
            }

            Color borderColor = default(Color);
            if (Decoration.Enabled)
            {
                borderColor = Decoration.ErrorText == null ? _GetDefaultBorderColor(themeData) : themeData.ErrorColor;
            }
            else
            {
                borderColor = (Decoration.Filled == true && Decoration.Border?.IsOutline != true) ? ColorsDefaultClass.Colors.Transparent : themeData.DisabledColor;
            }

            double borderWeight = default(double);
            if (Decoration.IsCollapsed || Decoration?.Border == InputborderDefaultClass.InputBorder.None || !Decoration.Enabled) borderWeight = 0.0; else borderWeight = IsFocused ? 2.0 : 1.0;
            InputBorder border = Decoration.Border ?? new UnderlineInputBorder();
            return border.CopyWith(borderSide: new BorderSide(color: borderColor, width: borderWeight));
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            ThemeData themeData = ThemeDefaultClass.Theme.Of(context);
            TextStyle inlineStyle = _GetInlineStyle(themeData);
            TextBaseline textBaseline = inlineStyle.TextBaseline;
            TextStyle hintStyle = inlineStyle.Merge(Decoration.HintStyle);
            Widget hint = Decoration.HintText == null ? null : new AnimatedOpacity(opacity: (IsEmpty() && !_HasInlineLabel) ? 1.0 : 0.0, duration: InputdecoratorDefaultClass._KTransitionDuration, curve: InputdecoratorDefaultClass._KTransitionCurve, alwaysIncludeSemantics: true, child: new Text(Decoration.HintText, style: hintStyle, overflow: TextOverflow.Ellipsis, textAlign: TextAlign, maxLines: Decoration.HintMaxLines));
            bool isError = Decoration.ErrorText != null;
            InputBorder border = default(InputBorder);
            if (!Decoration.Enabled) border = isError ? Decoration.ErrorBorder : Decoration.DisabledBorder; else if (IsFocused) border = isError ? Decoration.FocusedErrorBorder : Decoration.FocusedBorder; else border = isError ? Decoration.ErrorBorder : Decoration.EnabledBorder;
            border = (border == null ? _GetDefaultBorder(themeData) : border);
            Widget container = new _BorderContainer(border: border, gap: _BorderGap, gapAnimation: _FloatingLabelController.View, fillColor: _GetFillColor(themeData), hoverColor: _GetHoverColor(themeData), isHovering: IsHovering);
            TextStyle inlineLabelStyle = inlineStyle.Merge(Decoration.LabelStyle);
            Widget label = Decoration.LabelText == null ? null : new _Shaker(animation: _ShakingLabelController.View, child: new AnimatedOpacity(duration: InputdecoratorDefaultClass._KTransitionDuration, curve: InputdecoratorDefaultClass._KTransitionCurve, opacity: _ShouldShowLabel ? 1.0 : 0.0, child: new AnimatedDefaultTextStyle(duration: InputdecoratorDefaultClass._KTransitionDuration, curve: InputdecoratorDefaultClass._KTransitionCurve, style: Widget._LabelShouldWithdraw ? _GetFloatingLabelStyle(themeData) : inlineLabelStyle, child: new Text(Decoration.LabelText, overflow: TextOverflow.Ellipsis, textAlign: TextAlign))));
            Widget prefix = Decoration.Prefix == null && Decoration.PrefixText == null ? null : new _AffixText(labelIsFloating: Widget._LabelShouldWithdraw, text: Decoration.PrefixText, style: Decoration.PrefixStyle ?? hintStyle, child: Decoration.Prefix);
            Widget suffix = Decoration.Suffix == null && Decoration.SuffixText == null ? null : new _AffixText(labelIsFloating: Widget._LabelShouldWithdraw, text: Decoration.SuffixText, style: Decoration.SuffixStyle ?? hintStyle, child: Decoration.Suffix);
            Color activeColor = _GetActiveColor(themeData);
            bool decorationIsDense = Decoration.IsDense == true;
            double iconSize = decorationIsDense ? 18.0 : 24.0;
            Color iconColor = IsFocused ? activeColor : _GetDefaultIconColor(themeData);
            Widget icon = Decoration.Icon == null ? null : new Padding(padding: EdgeInsetsDirectional.Only(end: 16.0), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(color: iconColor, size: iconSize), child: Decoration.Icon));
            Widget prefixIcon = Decoration.PrefixIcon == null ? null : new Center(widthFactor: 1.0, heightFactor: 1.0, child: new ConstrainedBox(constraints: Decoration.PrefixIconConstraints ?? themeData.VisualDensity.EffectiveConstraints(new BoxConstraints(minWidth: ConstantsDefaultClass.KMinInteractiveDimension, minHeight: ConstantsDefaultClass.KMinInteractiveDimension)), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(color: iconColor, size: iconSize), child: Decoration.PrefixIcon)));
            Widget suffixIcon = Decoration.SuffixIcon == null ? null : new Center(widthFactor: 1.0, heightFactor: 1.0, child: new ConstrainedBox(constraints: Decoration.SuffixIconConstraints ?? themeData.VisualDensity.EffectiveConstraints(new BoxConstraints(minWidth: ConstantsDefaultClass.KMinInteractiveDimension, minHeight: ConstantsDefaultClass.KMinInteractiveDimension)), child: IconthemeDefaultClass.IconTheme.Merge(data: new IconThemeData(color: iconColor, size: iconSize), child: Decoration.SuffixIcon)));
            Widget helperError = new _HelperError(textAlign: TextAlign, helperText: Decoration.HelperText, helperStyle: _GetHelperStyle(themeData), helperMaxLines: Decoration.HelperMaxLines, errorText: Decoration.ErrorText, errorStyle: _GetErrorStyle(themeData), errorMaxLines: Decoration.ErrorMaxLines);
            Widget counter = default(Widget);
            if (Decoration.Counter != null)
            {
                counter = Decoration.Counter;
            }
            else if (Decoration.CounterText != null && Decoration.CounterText != "")
            {
                counter = new Semantics(container: true, liveRegion: IsFocused, child: new Text(Decoration.CounterText, style: _GetHelperStyle(themeData).Merge(Decoration.CounterStyle), overflow: TextOverflow.Ellipsis, semanticsLabel: Decoration.SemanticCounterText));
            }

            TextDirection textDirection = BasicDefaultClass.Directionality.Of(context);
            EdgeInsets decorationContentPadding = Decoration.ContentPadding?.Resolve(textDirection);
            EdgeInsets contentPadding = default(EdgeInsets);
            double floatingLabelHeight = default(double);
            if (Decoration.IsCollapsed)
            {
                floatingLabelHeight = 0.0;
                contentPadding = decorationContentPadding ?? EdgeinsetsDefaultClass.EdgeInsets.Zero;
            }
            else if (!border.IsOutline)
            {
                floatingLabelHeight = (4.0 + 0.75 * inlineLabelStyle.FontSize) * MediaqueryDefaultClass.MediaQuery.TextScaleFactorOf(context);
                if (Decoration.Filled == true)
                {
                    contentPadding = decorationContentPadding ?? (decorationIsDense ? EdgeInsets.FromLTRB(12.0, 8.0, 12.0, 8.0) : EdgeInsets.FromLTRB(12.0, 12.0, 12.0, 12.0));
                }
                else
                {
                    contentPadding = decorationContentPadding ?? (decorationIsDense ? EdgeInsets.FromLTRB(0.0, 8.0, 0.0, 8.0) : EdgeInsets.FromLTRB(0.0, 12.0, 0.0, 12.0));
                }

            }
            else
            {
                floatingLabelHeight = 0.0;
                contentPadding = decorationContentPadding ?? (decorationIsDense ? EdgeInsets.FromLTRB(12.0, 20.0, 12.0, 12.0) : EdgeInsets.FromLTRB(12.0, 24.0, 12.0, 16.0));
            }

            return new _Decorator(decoration: new _Decoration(contentPadding: contentPadding, isCollapsed: Decoration.IsCollapsed, floatingLabelHeight: floatingLabelHeight, floatingLabelProgress: _FloatingLabelController.Value, border: border, borderGap: _BorderGap, alignLabelWithHint: Decoration.AlignLabelWithHint, isDense: Decoration.IsDense, visualDensity: themeData.VisualDensity, icon: icon, input: Widget.Child, label: label, hint: hint, prefix: prefix, suffix: suffix, prefixIcon: prefixIcon, suffixIcon: suffixIcon, helperError: helperError, counter: counter, container: container), textDirection: textDirection, textBaseline: textBaseline, textAlignVertical: Widget.TextAlignVertical, isFocused: IsFocused, expands: Widget.Expands);
        }



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
            this.AlignLabelWithHint = alignLabelWithHint;
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
            instance.Enabled = enabled;
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
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration CopyWith(FlutterSDK.Widgets.Framework.Widget icon = default(FlutterSDK.Widgets.Framework.Widget), string labelText = default(string), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), string helperText = default(string), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), string hintText = default(string), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int hintMaxLines = default(int), string errorText = default(string), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int), bool hasFloatingPlaceholder = default(bool), FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), bool isDense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget prefixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget prefix = default(FlutterSDK.Widgets.Framework.Widget), string prefixText = default(string), FlutterSDK.Rendering.Box.BoxConstraints prefixIconConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Painting.Textstyle.TextStyle prefixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Widgets.Framework.Widget suffixIcon = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget suffix = default(FlutterSDK.Widgets.Framework.Widget), string suffixText = default(string), FlutterSDK.Painting.Textstyle.TextStyle suffixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Rendering.Box.BoxConstraints suffixIconConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Widgets.Framework.Widget counter = default(FlutterSDK.Widgets.Framework.Widget), string counterText = default(string), FlutterSDK.Painting.Textstyle.TextStyle counterStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = default(bool), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder errorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedErrorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder disabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder enabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool enabled = default(bool), string semanticCounterText = default(string), bool alignLabelWithHint = default(bool))
        {
            return new InputDecoration(icon: icon ?? this.Icon, labelText: labelText ?? this.LabelText, labelStyle: labelStyle ?? this.LabelStyle, helperText: helperText ?? this.HelperText, helperStyle: helperStyle ?? this.HelperStyle, helperMaxLines: helperMaxLines ?? this.HelperMaxLines, hintText: hintText ?? this.HintText, hintStyle: hintStyle ?? this.HintStyle, hintMaxLines: hintMaxLines ?? this.HintMaxLines, errorText: errorText ?? this.ErrorText, errorStyle: errorStyle ?? this.ErrorStyle, errorMaxLines: errorMaxLines ?? this.ErrorMaxLines, hasFloatingPlaceholder: hasFloatingPlaceholder ?? this.HasFloatingPlaceholder, floatingLabelBehavior: floatingLabelBehavior ?? this.FloatingLabelBehavior, isDense: isDense ?? this.IsDense, contentPadding: contentPadding ?? this.ContentPadding, prefixIcon: prefixIcon ?? this.PrefixIcon, prefix: prefix ?? this.Prefix, prefixText: prefixText ?? this.PrefixText, prefixStyle: prefixStyle ?? this.PrefixStyle, prefixIconConstraints: prefixIconConstraints ?? this.PrefixIconConstraints, suffixIcon: suffixIcon ?? this.SuffixIcon, suffix: suffix ?? this.Suffix, suffixText: suffixText ?? this.SuffixText, suffixStyle: suffixStyle ?? this.SuffixStyle, suffixIconConstraints: suffixIconConstraints ?? this.SuffixIconConstraints, counter: counter ?? this.Counter, counterText: counterText ?? this.CounterText, counterStyle: counterStyle ?? this.CounterStyle, filled: filled ?? this.Filled, fillColor: fillColor ?? this.FillColor, focusColor: focusColor ?? this.FocusColor, hoverColor: hoverColor ?? this.HoverColor, errorBorder: errorBorder ?? this.ErrorBorder, focusedBorder: focusedBorder ?? this.FocusedBorder, focusedErrorBorder: focusedErrorBorder ?? this.FocusedErrorBorder, disabledBorder: disabledBorder ?? this.DisabledBorder, enabledBorder: enabledBorder ?? this.EnabledBorder, border: border ?? this.Border, enabled: enabled ?? this.Enabled, semanticCounterText: semanticCounterText ?? this.SemanticCounterText, alignLabelWithHint: alignLabelWithHint ?? this.AlignLabelWithHint);
        }




        /// <Summary>
        /// Used by widgets like [TextField] and [InputDecorator] to create a new
        /// [InputDecoration] with default values taken from the [theme].
        ///
        /// Only null valued properties from this [InputDecoration] are replaced
        /// by the corresponding values from [theme].
        /// </Summary>
        public virtual FlutterSDK.Material.Inputdecorator.InputDecoration ApplyDefaults(FlutterSDK.Material.Inputdecorator.InputDecorationTheme theme)
        {
            return CopyWith(labelStyle: LabelStyle ?? theme.LabelStyle, helperStyle: HelperStyle ?? theme.HelperStyle, helperMaxLines: HelperMaxLines ?? theme.HelperMaxLines, hintStyle: HintStyle ?? theme.HintStyle, errorStyle: ErrorStyle ?? theme.ErrorStyle, errorMaxLines: ErrorMaxLines ?? theme.ErrorMaxLines, hasFloatingPlaceholder: HasFloatingPlaceholder ?? theme.HasFloatingPlaceholder, floatingLabelBehavior: FloatingLabelBehavior ?? theme.FloatingLabelBehavior, isDense: IsDense ?? theme.IsDense, contentPadding: ContentPadding ?? theme.ContentPadding, prefixStyle: PrefixStyle ?? theme.PrefixStyle, suffixStyle: SuffixStyle ?? theme.SuffixStyle, counterStyle: CounterStyle ?? theme.CounterStyle, filled: Filled ?? theme.Filled, fillColor: FillColor ?? theme.FillColor, focusColor: FocusColor ?? theme.FocusColor, hoverColor: HoverColor ?? theme.HoverColor, errorBorder: ErrorBorder ?? theme.ErrorBorder, focusedBorder: FocusedBorder ?? theme.FocusedBorder, focusedErrorBorder: FocusedErrorBorder ?? theme.FocusedErrorBorder, disabledBorder: DisabledBorder ?? theme.DisabledBorder, enabledBorder: EnabledBorder ?? theme.EnabledBorder, border: Border ?? theme.Border, alignLabelWithHint: AlignLabelWithHint ?? theme.AlignLabelWithHint);
        }




        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            if (other.GetType() != GetType()) return false;
            return other is InputDecoration && other.Icon == Icon && other.LabelText == LabelText && other.LabelStyle == LabelStyle && other.HelperText == HelperText && other.HelperStyle == HelperStyle && other.HelperMaxLines == HelperMaxLines && other.HintText == HintText && other.HintStyle == HintStyle && other.HintMaxLines == HintMaxLines && other.ErrorText == ErrorText && other.ErrorStyle == ErrorStyle && other.ErrorMaxLines == ErrorMaxLines && other.HasFloatingPlaceholder == HasFloatingPlaceholder && other.FloatingLabelBehavior == FloatingLabelBehavior && other.IsDense == IsDense && other.ContentPadding == ContentPadding && other.IsCollapsed == IsCollapsed && other.PrefixIcon == PrefixIcon && other.Prefix == Prefix && other.PrefixText == PrefixText && other.PrefixStyle == PrefixStyle && other.PrefixIconConstraints == PrefixIconConstraints && other.SuffixIcon == SuffixIcon && other.Suffix == Suffix && other.SuffixText == SuffixText && other.SuffixStyle == SuffixStyle && other.SuffixIconConstraints == SuffixIconConstraints && other.Counter == Counter && other.CounterText == CounterText && other.CounterStyle == CounterStyle && other.Filled == Filled && other.FillColor == FillColor && other.FocusColor == FocusColor && other.HoverColor == HoverColor && other.ErrorBorder == ErrorBorder && other.FocusedBorder == FocusedBorder && other.FocusedErrorBorder == FocusedErrorBorder && other.DisabledBorder == DisabledBorder && other.EnabledBorder == EnabledBorder && other.Border == Border && other.Enabled == Enabled && other.SemanticCounterText == SemanticCounterText && other.AlignLabelWithHint == AlignLabelWithHint;
        }




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
            this.AlignLabelWithHint = alignLabelWithHint;
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
        public virtual FlutterSDK.Material.Inputdecorator.InputDecorationTheme CopyWith(FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle helperStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int helperMaxLines = default(int), FlutterSDK.Painting.Textstyle.TextStyle hintStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle errorStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), int errorMaxLines = default(int), bool hasFloatingPlaceholder = default(bool), FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior floatingLabelBehavior = default(FlutterSDK.Material.Inputdecorator.FloatingLabelBehavior), bool isDense = default(bool), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry contentPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool isCollapsed = default(bool), FlutterSDK.Painting.Textstyle.TextStyle prefixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle suffixStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Textstyle.TextStyle counterStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), bool filled = default(bool), FlutterBinding.UI.Color fillColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Inputborder.InputBorder errorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder focusedErrorBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder disabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder enabledBorder = default(FlutterSDK.Material.Inputborder.InputBorder), FlutterSDK.Material.Inputborder.InputBorder border = default(FlutterSDK.Material.Inputborder.InputBorder), bool alignLabelWithHint = default(bool))
        {
            return new InputDecorationTheme(labelStyle: labelStyle ?? this.LabelStyle, helperStyle: helperStyle ?? this.HelperStyle, helperMaxLines: helperMaxLines ?? this.HelperMaxLines, hintStyle: hintStyle ?? this.HintStyle, errorStyle: errorStyle ?? this.ErrorStyle, errorMaxLines: errorMaxLines ?? this.ErrorMaxLines, hasFloatingPlaceholder: hasFloatingPlaceholder ?? this.HasFloatingPlaceholder, floatingLabelBehavior: floatingLabelBehavior ?? this.FloatingLabelBehavior, isDense: isDense ?? this.IsDense, contentPadding: contentPadding ?? this.ContentPadding, isCollapsed: isCollapsed ?? this.IsCollapsed, prefixStyle: prefixStyle ?? this.PrefixStyle, suffixStyle: suffixStyle ?? this.SuffixStyle, counterStyle: counterStyle ?? this.CounterStyle, filled: filled ?? this.Filled, fillColor: fillColor ?? this.FillColor, focusColor: focusColor ?? this.FocusColor, hoverColor: hoverColor ?? this.HoverColor, errorBorder: errorBorder ?? this.ErrorBorder, focusedBorder: focusedBorder ?? this.FocusedBorder, focusedErrorBorder: focusedErrorBorder ?? this.FocusedErrorBorder, disabledBorder: disabledBorder ?? this.DisabledBorder, enabledBorder: enabledBorder ?? this.EnabledBorder, border: border ?? this.Border, alignLabelWithHint: alignLabelWithHint ?? this.AlignLabelWithHint);
        }




        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            if (other.GetType() != GetType()) return false;
            return other is InputDecorationTheme && other.LabelStyle == LabelStyle && other.HelperStyle == HelperStyle && other.HelperMaxLines == HelperMaxLines && other.HintStyle == HintStyle && other.ErrorStyle == ErrorStyle && other.ErrorMaxLines == ErrorMaxLines && other.IsDense == IsDense && other.ContentPadding == ContentPadding && other.IsCollapsed == IsCollapsed && other.PrefixStyle == PrefixStyle && other.SuffixStyle == SuffixStyle && other.CounterStyle == CounterStyle && other.FloatingLabelBehavior == FloatingLabelBehavior && other.Filled == Filled && other.FillColor == FillColor && other.FocusColor == FocusColor && other.HoverColor == HoverColor && other.ErrorBorder == ErrorBorder && other.FocusedBorder == FocusedBorder && other.FocusedErrorBorder == FocusedErrorBorder && other.DisabledBorder == DisabledBorder && other.EnabledBorder == EnabledBorder && other.Border == Border && other.AlignLabelWithHint == AlignLabelWithHint && other.DisabledBorder == DisabledBorder;
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            InputDecorationTheme defaultTheme = new InputDecorationTheme();
            properties.Add(new DiagnosticsProperty<TextStyle>("labelStyle", LabelStyle, defaultValue: defaultTheme.LabelStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("helperStyle", HelperStyle, defaultValue: defaultTheme.HelperStyle));
            properties.Add(new IntProperty("helperMaxLines", HelperMaxLines, defaultValue: defaultTheme.HelperMaxLines));
            properties.Add(new DiagnosticsProperty<TextStyle>("hintStyle", HintStyle, defaultValue: defaultTheme.HintStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("errorStyle", ErrorStyle, defaultValue: defaultTheme.ErrorStyle));
            properties.Add(new IntProperty("errorMaxLines", ErrorMaxLines, defaultValue: defaultTheme.ErrorMaxLines));
            properties.Add(new DiagnosticsProperty<bool>("hasFloatingPlaceholder", HasFloatingPlaceholder, defaultValue: defaultTheme.HasFloatingPlaceholder));
            properties.Add(new DiagnosticsProperty<FloatingLabelBehavior>("floatingLabelBehavior", FloatingLabelBehavior, defaultValue: defaultTheme.FloatingLabelBehavior));
            properties.Add(new DiagnosticsProperty<bool>("isDense", IsDense, defaultValue: defaultTheme.IsDense));
            properties.Add(new DiagnosticsProperty<EdgeInsetsGeometry>("contentPadding", ContentPadding, defaultValue: defaultTheme.ContentPadding));
            properties.Add(new DiagnosticsProperty<bool>("isCollapsed", IsCollapsed, defaultValue: defaultTheme.IsCollapsed));
            properties.Add(new DiagnosticsProperty<TextStyle>("prefixStyle", PrefixStyle, defaultValue: defaultTheme.PrefixStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("suffixStyle", SuffixStyle, defaultValue: defaultTheme.SuffixStyle));
            properties.Add(new DiagnosticsProperty<TextStyle>("counterStyle", CounterStyle, defaultValue: defaultTheme.CounterStyle));
            properties.Add(new DiagnosticsProperty<bool>("filled", Filled, defaultValue: defaultTheme.Filled));
            properties.Add(new ColorProperty("fillColor", FillColor, defaultValue: defaultTheme.FillColor));
            properties.Add(new ColorProperty("focusColor", FocusColor, defaultValue: defaultTheme.FocusColor));
            properties.Add(new ColorProperty("hoverColor", HoverColor, defaultValue: defaultTheme.HoverColor));
            properties.Add(new DiagnosticsProperty<InputBorder>("errorBorder", ErrorBorder, defaultValue: defaultTheme.ErrorBorder));
            properties.Add(new DiagnosticsProperty<InputBorder>("focusedBorder", FocusedBorder, defaultValue: defaultTheme.FocusedErrorBorder));
            properties.Add(new DiagnosticsProperty<InputBorder>("focusedErrorBorder", FocusedErrorBorder, defaultValue: defaultTheme.FocusedErrorBorder));
            properties.Add(new DiagnosticsProperty<InputBorder>("disabledBorder", DisabledBorder, defaultValue: defaultTheme.DisabledBorder));
            properties.Add(new DiagnosticsProperty<InputBorder>("enabledBorder", EnabledBorder, defaultValue: defaultTheme.EnabledBorder));
            properties.Add(new DiagnosticsProperty<InputBorder>("border", Border, defaultValue: defaultTheme.Border));
            properties.Add(new DiagnosticsProperty<bool>("alignLabelWithHint", AlignLabelWithHint, defaultValue: defaultTheme.AlignLabelWithHint));
        }



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
