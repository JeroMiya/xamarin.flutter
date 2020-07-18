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
namespace FlutterSDK.Rendering.Stack
{
    internal static class StackDefaultClass
    {
    }

    /// <Summary>
    /// An immutable 2D, axis-aligned, floating-point rectangle whose coordinates
    /// are given relative to another rectangle's edges, known as the container.
    /// Since the dimensions of the rectangle are relative to those of the
    /// container, this class has no width and height members. To determine the
    /// width or height of the rectangle, convert it to a [Rect] using [toRect()]
    /// (passing the container's own Rect), and then examine that object.
    ///
    /// The fields [left], [right], [bottom], and [top] must not be null.
    /// </Summary>
    public class RelativeRect
    {
        #region constructors
        public static RelativeRect FromLTRB(double left, double top, double right, double bottom)
        {
            var instance = new RelativeRect(); instance.Left = left;
            instance.Top = top;
            instance.Right = right;
            instance.Bottom = bottom;
        }
        public static RelativeRect FromSize(FlutterBinding.UI.Rect rect, Size container)
        {
            var instance = new RelativeRect();
            return RelativeRect.FromLTRB(rect.Left, rect.Top, container.Width - rect.Right, container.Height - rect.Bottom);
        }


        public static RelativeRect FromRect(FlutterBinding.UI.Rect rect, FlutterBinding.UI.Rect container)
        {
            var instance = new RelativeRect();
            return RelativeRect.FromLTRB(rect.Left - container.Left, rect.Top - container.Top, container.Right - rect.Right, container.Bottom - rect.Bottom);
        }


        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Stack.RelativeRect Fill { get; set; }
        public virtual double Left { get; set; }
        public virtual double Top { get; set; }
        public virtual double Right { get; set; }
        public virtual double Bottom { get; set; }
        public virtual bool HasInsets { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        /// <Summary>
        /// Returns a new rectangle object translated by the given offset.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Stack.RelativeRect Shift(FlutterBinding.UI.Offset offset)
        {
            return RelativeRect.FromLTRB(Left + offset.Dx, Top + offset.Dy, Right - offset.Dx, Bottom - offset.Dy);
        }




        /// <Summary>
        /// Returns a new rectangle with edges moved outwards by the given delta.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Stack.RelativeRect Inflate(double delta)
        {
            return RelativeRect.FromLTRB(Left - delta, Top - delta, Right - delta, Bottom - delta);
        }




        /// <Summary>
        /// Returns a new rectangle with edges moved inwards by the given delta.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Stack.RelativeRect Deflate(double delta)
        {
            return Inflate(-delta);
        }




        /// <Summary>
        /// Returns a new rectangle that is the intersection of the given rectangle and this rectangle.
        /// </Summary>
        public virtual FlutterSDK.Rendering.Stack.RelativeRect Intersect(FlutterSDK.Rendering.Stack.RelativeRect other)
        {
            return RelativeRect.FromLTRB(Math.Dart:mathDefaultClass.Max(Left, other.Left), Math.Dart:mathDefaultClass.Max(Top, other.Top), Math.Dart:mathDefaultClass.Max(Right, other.Right), Math.Dart:mathDefaultClass.Max(Bottom, other.Bottom));
        }




        /// <Summary>
        /// Convert this [RelativeRect] to a [Rect], in the coordinate space of the container.
        ///
        /// See also:
        ///
        ///  * [toSize], which returns the size part of the rect, based on the size of
        ///    the container.
        /// </Summary>
        public virtual Rect ToRect(FlutterBinding.UI.Rect container)
        {
            return Rect.FromLTRB(Left, Top, container.Width - Right, container.Height - Bottom);
        }




        /// <Summary>
        /// Convert this [RelativeRect] to a [Size], assuming a container with the given size.
        ///
        /// See also:
        ///
        ///  * [toRect], which also computes the position relative to the container.
        /// </Summary>
        public virtual Size ToSize(Size container)
        {
            return new Size(container.Width - Left - Right, container.Height - Top - Bottom);
        }




        /// <Summary>
        /// Linearly interpolate between two RelativeRects.
        ///
        /// If either rect is null, this function interpolates from [RelativeRect.fill].
        ///
        /// {@macro dart.ui.shadow.lerp}
        /// </Summary>
        public virtual FlutterSDK.Rendering.Stack.RelativeRect Lerp(FlutterSDK.Rendering.Stack.RelativeRect a, FlutterSDK.Rendering.Stack.RelativeRect b, double t)
        {

            if (a == null && b == null) return null;
            if (a == null) return RelativeRect.FromLTRB(b.Left * t, b.Top * t, b.Right * t, b.Bottom * t);
            if (b == null)
            {
                double k = 1.0 - t;
                return RelativeRect.FromLTRB(b.Left * k, b.Top * k, b.Right * k, b.Bottom * k);
            }

            return RelativeRect.FromLTRB(Dart: uiDefaultClass.LerpDouble(a.Left, b.Left, t), Dart: uiDefaultClass.LerpDouble(a.Top, b.Top, t), Dart: uiDefaultClass.LerpDouble(a.Right, b.Right, t), Dart: uiDefaultClass.LerpDouble(a.Bottom, b.Bottom, t));
        }




        public new bool Equals(@Object other)
        {
            if (Dart:coreDefaultClass.Identical(this, other))return true;
            return other is RelativeRect && other.Left == Left && other.Top == Top && other.Right == Right && other.Bottom == Bottom;
        }




        #endregion
    }


    /// <Summary>
    /// Parent data for use with [RenderStack].
    /// </Summary>
    public class StackParentData : FlutterSDK.Rendering.Box.ContainerBoxParentData<FlutterSDK.Rendering.Box.RenderBox>
    {
        #region constructors
        public StackParentData()
        { }
        #endregion

        #region fields
        public virtual double Top { get; set; }
        public virtual double Right { get; set; }
        public virtual double Bottom { get; set; }
        public virtual double Left { get; set; }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual FlutterSDK.Rendering.Stack.RelativeRect Rect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsPositioned { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        #endregion
    }


    /// <Summary>
    /// Implements the stack layout algorithm
    ///
    /// In a stack layout, the children are positioned on top of each other in the
    /// order in which they appear in the child list. First, the non-positioned
    /// children (those with null values for top, right, bottom, and left) are
    /// laid out and initially placed in the upper-left corner of the stack. The
    /// stack is then sized to enclose all of the non-positioned children. If there
    /// are no non-positioned children, the stack becomes as large as possible.
    ///
    /// The final location of non-positioned children is determined by the alignment
    /// parameter. The left of each non-positioned child becomes the
    /// difference between the child's width and the stack's width scaled by
    /// alignment.x. The top of each non-positioned child is computed
    /// similarly and scaled by alignment.y. So if the alignment x and y properties
    /// are 0.0 (the default) then the non-positioned children remain in the
    /// upper-left corner. If the alignment x and y properties are 0.5 then the
    /// non-positioned children are centered within the stack.
    ///
    /// Next, the positioned children are laid out. If a child has top and bottom
    /// values that are both non-null, the child is given a fixed height determined
    /// by subtracting the sum of the top and bottom values from the height of the stack.
    /// Similarly, if the child has right and left values that are both non-null,
    /// the child is given a fixed width derived from the stack's width.
    /// Otherwise, the child is given unbounded constraints in the non-fixed dimensions.
    ///
    /// Once the child is laid out, the stack positions the child
    /// according to the top, right, bottom, and left properties of their
    /// [StackParentData]. For example, if the bottom value is 10.0, the
    /// bottom edge of the child will be inset 10.0 pixels from the bottom
    /// edge of the stack. If the child extends beyond the bounds of the
    /// stack, the stack will clip the child's painting to the bounds of
    /// the stack.
    ///
    /// See also:
    ///
    ///  * [RenderFlow]
    /// </Summary>
    public class RenderStack : FlutterSDK.Rendering.Box.RenderBox, IContainerRenderObjectMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Stack.StackParentData>, IRenderBoxContainerDefaultsMixin<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Rendering.Stack.StackParentData>
    {
        #region constructors
        public RenderStack(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Stack.StackFit fit = default(FlutterSDK.Rendering.Stack.StackFit), FlutterSDK.Rendering.Stack.Overflow overflow = default(FlutterSDK.Rendering.Stack.Overflow))
        : base()
        {

            AddAll(children);
        }


        #endregion

        #region fields
        internal virtual bool _HasVisualOverflow { get; set; }
        internal virtual FlutterSDK.Painting.Alignment.Alignment _ResolvedAlignment { get; set; }
        internal virtual FlutterSDK.Painting.Alignment.AlignmentGeometry _Alignment { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        internal virtual FlutterSDK.Rendering.Stack.StackFit _Fit { get; set; }
        internal virtual FlutterSDK.Rendering.Stack.Overflow _Overflow { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Stack.StackFit Fit { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Stack.Overflow Overflow { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void SetupParentData(FlutterSDK.Rendering.Box.RenderBox child)
        {
            if (!(child.ParentData is StackParentData)) child.ParentData = new StackParentData();
        }


        public new void SetupParentData(FlutterSDK.Rendering.@object.RenderObject child)
        {
            if (!(child.ParentData is StackParentData)) child.ParentData = new StackParentData();
        }




        private void _Resolve()
        {
            if (_ResolvedAlignment != null) return;
            _ResolvedAlignment = Alignment.Resolve(TextDirection);
        }




        private void _MarkNeedResolution()
        {
            _ResolvedAlignment = null;
            MarkNeedsLayout();
        }




        /// <Summary>
        /// Helper function for calculating the intrinsics metrics of a Stack.
        /// </Summary>
        public virtual double GetIntrinsicDimension(FlutterSDK.Rendering.Box.RenderBox firstChild, Func<double, RenderBox> mainChildSizeGetter)
        {
            double extent = 0.0;
            RenderBox child = firstChild;
            while (child != null)
            {
                StackParentData childParentData = child.ParentData as StackParentData;
                if (!childParentData.IsPositioned) extent = Math.Dart:mathDefaultClass.Max(extent, mainChildSizeGetter(child));

                child = childParentData.NextSibling;
            }

            return extent;
        }




        public new double ComputeMinIntrinsicWidth(double height)
        {
            return GetIntrinsicDimension(FirstChild, (RenderBox child) => =>child.GetMinIntrinsicWidth(height));
        }




        public new double ComputeMaxIntrinsicWidth(double height)
        {
            return GetIntrinsicDimension(FirstChild, (RenderBox child) => =>child.GetMaxIntrinsicWidth(height));
        }




        public new double ComputeMinIntrinsicHeight(double width)
        {
            return GetIntrinsicDimension(FirstChild, (RenderBox child) => =>child.GetMinIntrinsicHeight(width));
        }




        public new double ComputeMaxIntrinsicHeight(double width)
        {
            return GetIntrinsicDimension(FirstChild, (RenderBox child) => =>child.GetMaxIntrinsicHeight(width));
        }




        public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
        {
            return DefaultComputeDistanceToHighestActualBaseline(baseline);
        }




        /// <Summary>
        /// Lays out the positioned `child` according to `alignment` within a Stack of `size`.
        ///
        /// Returns true when the child has visual overflow.
        /// </Summary>
        public virtual bool LayoutPositionedChild(FlutterSDK.Rendering.Box.RenderBox child, FlutterSDK.Rendering.Stack.StackParentData childParentData, Size size, FlutterSDK.Painting.Alignment.Alignment alignment)
        {


            bool hasVisualOverflow = false;
            BoxConstraints childConstraints = new BoxConstraints();
            if (childParentData.Left != null && childParentData.Right != null) childConstraints = childConstraints.Tighten(width: size.Width - childParentData.Right - childParentData.Left); else if (childParentData.Width != null) childConstraints = childConstraints.Tighten(width: childParentData.Width);
            if (childParentData.Top != null && childParentData.Bottom != null) childConstraints = childConstraints.Tighten(height: size.Height - childParentData.Bottom - childParentData.Top); else if (childParentData.Height != null) childConstraints = childConstraints.Tighten(height: childParentData.Height);
            child.Layout(childConstraints, parentUsesSize: true);
            double x = default(double);
            if (childParentData.Left != null)
            {
                x = childParentData.Left;
            }
            else if (childParentData.Right != null)
            {
                x = size.Width - childParentData.Right - child.Size.Width;
            }
            else
            {
                x = alignment.AlongOffset(size - child.Size as Offset).Dx;
            }

            if (x < 0.0 || x + child.Size.Width > size.Width) hasVisualOverflow = true;
            double y = default(double);
            if (childParentData.Top != null)
            {
                y = childParentData.Top;
            }
            else if (childParentData.Bottom != null)
            {
                y = size.Height - childParentData.Bottom - child.Size.Height;
            }
            else
            {
                y = alignment.AlongOffset(size - child.Size as Offset).Dy;
            }

            if (y < 0.0 || y + child.Size.Height > size.Height) hasVisualOverflow = true;
            childParentData.Offset = new Offset(x, y);
            return hasVisualOverflow;
        }




        public new void PerformLayout()
        {
            BoxConstraints constraints = this.Constraints;
            _Resolve();

            _HasVisualOverflow = false;
            bool hasNonPositionedChildren = false;
            if (ChildCount == 0)
            {
                Size = constraints.Biggest;

                return;
            }

            double width = constraints.MinWidth;
            double height = constraints.MinHeight;
            BoxConstraints nonPositionedConstraints = default(BoxConstraints);

            switch (Fit) { case StackFit.Loose: nonPositionedConstraints = constraints.Loosen(); break; case StackFit.Expand: nonPositionedConstraints = BoxConstraints.Tight(constraints.Biggest); break; case StackFit.Passthrough: nonPositionedConstraints = constraints; break; }

            RenderBox child = FirstChild;
            while (child != null)
            {
                StackParentData childParentData = child.ParentData as StackParentData;
                if (!childParentData.IsPositioned)
                {
                    hasNonPositionedChildren = true;
                    child.Layout(nonPositionedConstraints, parentUsesSize: true);
                    Size childSize = child.Size;
                    width = Math.Dart:mathDefaultClass.Max(width, childSize.Width);
                    height = Math.Dart:mathDefaultClass.Max(height, childSize.Height);
                }

                child = childParentData.NextSibling;
            }

            if (hasNonPositionedChildren)
            {
                Size = new Size(width, height);


            }
            else
            {
                Size = constraints.Biggest;
            }


            child = FirstChild;
            while (child != null)
            {
                StackParentData childParentData = child.ParentData as StackParentData;
                if (!childParentData.IsPositioned)
                {
                    childParentData.Offset = _ResolvedAlignment.AlongOffset(Size - child.Size as Offset);
                }
                else
                {
                    _HasVisualOverflow = LayoutPositionedChild(child, childParentData, Size, _ResolvedAlignment) || _HasVisualOverflow;
                }


                child = childParentData.NextSibling;
            }

        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            return DefaultHitTestChildren(result, position: position);
        }




        /// <Summary>
        /// Override in subclasses to customize how the stack paints.
        ///
        /// By default, the stack uses [defaultPaint]. This function is called by
        /// [paint] after potentially applying a clip to contain visual overflow.
        /// </Summary>
        public virtual void PaintStack(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            DefaultPaint(context, offset);
        }




        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (_Overflow == Overflow.Clip && _HasVisualOverflow)
            {
                context.PushClipRect(NeedsCompositing, offset, Dart: uiDefaultClass.Offset.Zero & Size, PaintStack);
            }
            else
            {
                PaintStack(context, offset);
            }

        }




        public new Rect DescribeApproximatePaintClip(FlutterSDK.Rendering.@object.RenderObject child) => _HasVisualOverflow ? Dart : uiDefaultClass.Offset.Zero & Size:null ;



public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<AlignmentGeometry>("alignment", Alignment));
            properties.Add(new EnumProperty<TextDirection>("textDirection", TextDirection));
            properties.Add(new EnumProperty<StackFit>("fit", Fit));
            properties.Add(new EnumProperty<Overflow>("overflow", Overflow));
        }



        #endregion
    }


    /// <Summary>
    /// Implements the same layout algorithm as RenderStack but only paints the child
    /// specified by index.
    ///
    /// Although only one child is displayed, the cost of the layout algorithm is
    /// still O(N), like an ordinary stack.
    /// </Summary>
    public class RenderIndexedStack : FlutterSDK.Rendering.Stack.RenderStack
    {
        #region constructors
        public RenderIndexedStack(List<FlutterSDK.Rendering.Box.RenderBox> children = default(List<FlutterSDK.Rendering.Box.RenderBox>), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection), int index = 0)
        : base(children: children, alignment: alignment, textDirection: textDirection)
        {

        }
        #endregion

        #region fields
        internal virtual int _Index { get; set; }
        public virtual int Index { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void VisitChildrenForSemantics(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
        {
            if (Index != null && FirstChild != null) visitor(_ChildAtIndex());
        }




        private FlutterSDK.Rendering.Box.RenderBox _ChildAtIndex()
        {

            RenderBox child = FirstChild;
            int i = 0;
            while (child != null && i < Index)
            {
                StackParentData childParentData = child.ParentData as StackParentData;
                child = childParentData.NextSibling;
                i += 1;
            }



            return child;
        }




        public new bool HitTestChildren(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
        {
            if (FirstChild == null || Index == null) return false;

            RenderBox child = _ChildAtIndex();
            StackParentData childParentData = child.ParentData as StackParentData;
            return result.AddWithPaintOffset(offset: childParentData.Offset, position: position, hitTest: (BoxHitTestResult result, Offset transformed) =>
            {

                return child.HitTest(result, position: transformed);
            }
            );
        }




        public new void PaintStack(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
        {
            if (FirstChild == null || Index == null) return;
            RenderBox child = _ChildAtIndex();
            StackParentData childParentData = child.ParentData as StackParentData;
            context.PaintChild(child, childParentData.Offset + offset);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new IntProperty("index", Index));
        }



        #endregion
    }


    /// <Summary>
    /// How to size the non-positioned children of a [Stack].
    ///
    /// This enum is used with [Stack.fit] and [RenderStack.fit] to control
    /// how the [BoxConstraints] passed from the stack's parent to the stack's child
    /// are adjusted.
    ///
    /// See also:
    ///
    ///  * [Stack], the widget that uses this.
    ///  * [RenderStack], the render object that implements the stack algorithm.
    /// </Summary>
    public enum StackFit
    {

        /// <Summary>
        /// The constraints passed to the stack from its parent are loosened.
        ///
        /// For example, if the stack has constraints that force it to 350x600, then
        /// this would allow the non-positioned children of the stack to have any
        /// width from zero to 350 and any height from zero to 600.
        ///
        /// See also:
        ///
        ///  * [Center], which loosens the constraints passed to its child and then
        ///    centers the child in itself.
        ///  * [BoxConstraints.loosen], which implements the loosening of box
        ///    constraints.
        /// </Summary>
        Loose,
        /// <Summary>
        /// The constraints passed to the stack from its parent are tightened to the
        /// biggest size allowed.
        ///
        /// For example, if the stack has loose constraints with a width in the range
        /// 10 to 100 and a height in the range 0 to 600, then the non-positioned
        /// children of the stack would all be sized as 100 pixels wide and 600 high.
        /// </Summary>
        Expand,
        /// <Summary>
        /// The constraints passed to the stack from its parent are passed unmodified
        /// to the non-positioned children.
        ///
        /// For example, if a [Stack] is an [Expanded] child of a [Row], the
        /// horizontal constraints will be tight and the vertical constraints will be
        /// loose.
        /// </Summary>
        Passthrough,
    }


    /// <Summary>
    /// Whether overflowing children should be clipped, or their overflow be
    /// visible.
    /// </Summary>
    public enum Overflow
    {

        /// <Summary>
        /// Overflowing children will be visible.
        /// </Summary>
        Visible,
        /// <Summary>
        /// Overflowing children will be clipped to the bounds of their parent.
        /// </Summary>
        Clip,
    }

}
