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
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Painting._Networkimageio;
namespace FlutterSDK.Painting.Roundedrectangleborder
{
    internal static class RoundedrectangleborderDefaultClass
    {
    }

    /// <Summary>
    /// A rectangular border with rounded corners.
    ///
    /// Typically used with [ShapeDecoration] to draw a box with a rounded
    /// rectangle.
    ///
    /// This shape can interpolate to and from [CircleBorder].
    ///
    /// See also:
    ///
    ///  * [BorderSide], which is used to describe each side of the box.
    ///  * [Border], which, when used with [BoxDecoration], can also
    ///    describe a rounded rectangle.
    /// </Summary>
    public class RoundedRectangleBorder : FlutterSDK.Painting.Borders.ShapeBorder
    {
        #region constructors
        public RoundedRectangleBorder(FlutterSDK.Painting.Borders.BorderSide side = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadiusGeometry borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry))
        : base()
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Painting.Borders.BorderSide Side { get; set; }
    public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry BorderRadius { get; set; }
    public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new FlutterSDK.Painting.Borders.ShapeBorder Scale(double t)
    {
        return new RoundedRectangleBorder(side: Side.Scale(t), borderRadius: BorderRadius * t);
    }




    public new FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t)
    {

        if (a is RoundedRectangleBorder)
        {
            return new RoundedRectangleBorder(side: BordersDefaultClass.BorderSide.Lerp(((RoundedRectangleBorder)a).Side, Side, t), borderRadius: BorderradiusDefaultClass.BorderRadiusGeometry.Lerp(((RoundedRectangleBorder)a).BorderRadius, BorderRadius, t));
        }

        if (a is CircleBorder)
        {
            return new _RoundedRectangleToCircleBorder(side: BordersDefaultClass.BorderSide.Lerp(((CircleBorder)a).Side, Side, t), borderRadius: BorderRadius, circleness: 1.0 - t);
        }

        return base.LerpFrom(a, t);
    }




    public new FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t)
    {

        if (b is RoundedRectangleBorder)
        {
            return new RoundedRectangleBorder(side: BordersDefaultClass.BorderSide.Lerp(Side, ((RoundedRectangleBorder)b).Side, t), borderRadius: BorderradiusDefaultClass.BorderRadiusGeometry.Lerp(BorderRadius, ((RoundedRectangleBorder)b).BorderRadius, t));
        }

        if (b is CircleBorder)
        {
            return new _RoundedRectangleToCircleBorder(side: BordersDefaultClass.BorderSide.Lerp(Side, ((CircleBorder)b).Side, t), borderRadius: BorderRadius, circleness: t);
        }

        return base.LerpTo(b, t);
    }




    public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
    {
        return new Path();
        new Path().AddRRect(BorderRadius.Resolve(textDirection).ToRRect(rect).Deflate(Side.Width));
    }




    public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
    {
        return new Path();
        new Path().AddRRect(BorderRadius.Resolve(textDirection).ToRRect(rect));
    }




    public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
    {
        switch (Side.Style)
        {
            case BorderStyle.None: break;
            case BorderStyle.Solid:
                double width = Side.Width; if (width == 0.0)
                {
                    canvas.DrawRRect(BorderRadius.Resolve(textDirection).ToRRect(rect), Side.ToPaint());
                }
                else
                {
                    RRect outer = BorderRadius.Resolve(textDirection).ToRRect(rect);
                    RRect inner = outer.Deflate(width);
                    Paint paint = new Paint()..Color = Side.Color;
                    canvas.DrawDRRect(outer, inner, paint);
                }
        }
    }




    public new bool Equals(@Object other)
    {
        if (other.GetType() != GetType()) return false;
        return other is RoundedRectangleBorder && other.Side == Side && other.BorderRadius == BorderRadius;
    }




    #endregion
}


public class _RoundedRectangleToCircleBorder : FlutterSDK.Painting.Borders.ShapeBorder
{
    #region constructors
    public _RoundedRectangleToCircleBorder(FlutterSDK.Painting.Borders.BorderSide side = default(FlutterSDK.Painting.Borders.BorderSide), FlutterSDK.Painting.Borderradius.BorderRadiusGeometry borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadiusGeometry), double circleness = default(double))
    : base()

}
#endregion

#region fields
public virtual FlutterSDK.Painting.Borders.BorderSide Side { get; set; }
public virtual FlutterSDK.Painting.Borderradius.BorderRadiusGeometry BorderRadius { get; set; }
public virtual double Circleness { get; set; }
public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Dimensions { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new FlutterSDK.Painting.Borders.ShapeBorder Scale(double t)
{
    return new _RoundedRectangleToCircleBorder(side: Side.Scale(t), borderRadius: BorderRadius * t, circleness: t);
}




public new FlutterSDK.Painting.Borders.ShapeBorder LerpFrom(FlutterSDK.Painting.Borders.ShapeBorder a, double t)
{

    if (a is RoundedRectangleBorder)
    {
        return new _RoundedRectangleToCircleBorder(side: BordersDefaultClass.BorderSide.Lerp(((RoundedRectangleBorder)a).Side, Side, t), borderRadius: BorderradiusDefaultClass.BorderRadiusGeometry.Lerp(((RoundedRectangleBorder)a).BorderRadius, BorderRadius, t), circleness: Circleness * t);
    }

    if (a is CircleBorder)
    {
        return new _RoundedRectangleToCircleBorder(side: BordersDefaultClass.BorderSide.Lerp(((CircleBorder)a).Side, Side, t), borderRadius: BorderRadius, circleness: Circleness + (1.0 - Circleness) * (1.0 - t));
    }

    if (a is _RoundedRectangleToCircleBorder)
    {
        return new _RoundedRectangleToCircleBorder(side: BordersDefaultClass.BorderSide.Lerp(((_RoundedRectangleToCircleBorder)a).Side, Side, t), borderRadius: BorderradiusDefaultClass.BorderRadiusGeometry.Lerp(((_RoundedRectangleToCircleBorder)a).BorderRadius, BorderRadius, t), circleness: Ui.Dart:uiDefaultClass.LerpDouble(((_RoundedRectangleToCircleBorder)a).Circleness, Circleness, t));
    }

    return base.LerpFrom(a, t);
}




public new FlutterSDK.Painting.Borders.ShapeBorder LerpTo(FlutterSDK.Painting.Borders.ShapeBorder b, double t)
{
    if (b is RoundedRectangleBorder)
    {
        return new _RoundedRectangleToCircleBorder(side: BordersDefaultClass.BorderSide.Lerp(Side, ((RoundedRectangleBorder)b).Side, t), borderRadius: BorderradiusDefaultClass.BorderRadiusGeometry.Lerp(BorderRadius, ((RoundedRectangleBorder)b).BorderRadius, t), circleness: Circleness * (1.0 - t));
    }

    if (b is CircleBorder)
    {
        return new _RoundedRectangleToCircleBorder(side: BordersDefaultClass.BorderSide.Lerp(Side, ((CircleBorder)b).Side, t), borderRadius: BorderRadius, circleness: Circleness + (1.0 - Circleness) * t);
    }

    if (b is _RoundedRectangleToCircleBorder)
    {
        return new _RoundedRectangleToCircleBorder(side: BordersDefaultClass.BorderSide.Lerp(Side, ((_RoundedRectangleToCircleBorder)b).Side, t), borderRadius: BorderradiusDefaultClass.BorderRadiusGeometry.Lerp(BorderRadius, ((_RoundedRectangleToCircleBorder)b).BorderRadius, t), circleness: Ui.Dart:uiDefaultClass.LerpDouble(Circleness, ((_RoundedRectangleToCircleBorder)b).Circleness, t));
    }

    return base.LerpTo(b, t);
}




private Rect _AdjustRect(FlutterBinding.UI.Rect rect)
{
    if (Circleness == 0.0 || rect.Width == rect.Height) return rect;
    if (rect.Width < rect.Height)
    {
        double delta = Circleness * (rect.Height - rect.Width) / 2.0;
        return Rect.FromLTRB(rect.Left, rect.Top + delta, rect.Right, rect.Bottom - delta);
    }
    else
    {
        double delta = Circleness * (rect.Width - rect.Height) / 2.0;
        return Rect.FromLTRB(rect.Left + delta, rect.Top, rect.Right - delta, rect.Bottom);
    }

}




private FlutterSDK.Painting.Borderradius.BorderRadius _AdjustBorderRadius(FlutterBinding.UI.Rect rect, TextDirection textDirection)
{
    BorderRadius resolvedRadius = BorderRadius.Resolve(textDirection);
    if (Circleness == 0.0) return resolvedRadius;
    return BorderradiusDefaultClass.BorderRadius.Lerp(resolvedRadius, BorderRadius.Circular(rect.ShortestSide / 2.0), Circleness);
}




public new Path GetInnerPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    return new Path();
    new Path().AddRRect(_AdjustBorderRadius(rect, textDirection).ToRRect(_AdjustRect(rect)).Deflate(Side.Width));
}




public new Path GetOuterPath(FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    return new Path();
    new Path().AddRRect(_AdjustBorderRadius(rect, textDirection).ToRRect(_AdjustRect(rect)));
}




public new void Paint(Canvas canvas, FlutterBinding.UI.Rect rect, TextDirection textDirection = default(TextDirection))
{
    switch (Side.Style)
    {
        case BorderStyle.None: break;
        case BorderStyle.Solid:
            double width = Side.Width; if (width == 0.0)
            {
                canvas.DrawRRect(_AdjustBorderRadius(rect, textDirection).ToRRect(_AdjustRect(rect)), Side.ToPaint());
            }
            else
            {
                RRect outer = _AdjustBorderRadius(rect, textDirection).ToRRect(_AdjustRect(rect));
                RRect inner = outer.Deflate(width);
                Paint paint = new Paint()..Color = Side.Color;
                canvas.DrawDRRect(outer, inner, paint);
            }
    }
}




public new bool Equals(@Object other)
{
    if (other.GetType() != GetType()) return false;
    return other is _RoundedRectangleToCircleBorder && other.Side == Side && other.BorderRadius == BorderRadius && other.Circleness == Circleness;
}




#endregion
}

}
