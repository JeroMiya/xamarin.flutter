using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using FlutterBinding.UI;
using FlutterSDK;
using FlutterSDK.Animation.Animation;
using FlutterSDK.Animation.Animationcontroller;
using FlutterSDK.Animation.Animations;
using FlutterSDK.Animation.Curves;
using FlutterSDK.Animation.Listenerhelpers;
using FlutterSDK.Animation.Tween;
using FlutterSDK.Animation.Tweensequence;
using FlutterSDK.Foundation;
using FlutterSDK.Foundation._Bitfieldio;
using FlutterSDK.Foundation._Isolatesio;
using FlutterSDK.Foundation._Platformio;
using FlutterSDK.Foundation.Annotations;
using FlutterSDK.Foundation.Assertions;
using FlutterSDK.Foundation.Basictypes;
using FlutterSDK.Foundation.Binding;
using FlutterSDK.Foundation.Bitfield;
using FlutterSDK.Foundation.Changenotifier;
using FlutterSDK.Foundation.Collections;
using FlutterSDK.Foundation.Consolidateresponse;
using FlutterSDK.Foundation.Constants;
using FlutterSDK.Foundation.Debug;
using FlutterSDK.Foundation.Diagnostics;
using FlutterSDK.Foundation.Isolates;
using FlutterSDK.Foundation.Key;
using FlutterSDK.Foundation.Licenses;
using FlutterSDK.Foundation.Node;
using FlutterSDK.Foundation.@object;
using FlutterSDK.Foundation.Observerlist;
using FlutterSDK.Foundation.Platform;
using FlutterSDK.Foundation.Print;
using FlutterSDK.Foundation.Profile;
using FlutterSDK.Foundation.Serialization;
using FlutterSDK.Foundation.Stackframe;
using FlutterSDK.Foundation.Synchronousfuture;
using FlutterSDK.Foundation.Unicode;
using FlutterSDK.Gestures.Arena;
using FlutterSDK.Gestures.Binding;
using FlutterSDK.Gestures.Constants;
using FlutterSDK.Gestures.Converter;
using FlutterSDK.Gestures.Debug;
using FlutterSDK.Gestures.Drag;
using FlutterSDK.Gestures.Dragdetails;
using FlutterSDK.Gestures.Eager;
using FlutterSDK.Gestures.Events;
using FlutterSDK.Gestures.Forcepress;
using FlutterSDK.Gestures.Hittest;
using FlutterSDK.Gestures.Longpress;
using FlutterSDK.Gestures.Lsqsolver;
using FlutterSDK.Gestures.Monodrag;
using FlutterSDK.Gestures.Multidrag;
using FlutterSDK.Gestures.Multitap;
using FlutterSDK.Gestures.Pointerrouter;
using FlutterSDK.Gestures.Pointersignalresolver;
using FlutterSDK.Gestures.Recognizer;
using FlutterSDK.Gestures.Scale;
using FlutterSDK.Gestures.Tap;
using FlutterSDK.Gestures.Team;
using FlutterSDK.Gestures.Velocitytracker;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatedicons;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Animatedicons.Animatediconsdata;
using FlutterSDK.Material.Appbar;
using FlutterSDK.Material.Appbartheme;
using FlutterSDK.Material.Arc;
using FlutterSDK.Material.Backbutton;
using FlutterSDK.Material.Bannertheme;
using FlutterSDK.Material.Bottomappbartheme;
using FlutterSDK.Material.Bottomsheet;
using FlutterSDK.Material.Bottomsheettheme;
using FlutterSDK.Material.Button;
using FlutterSDK.Material.Buttonbar;
using FlutterSDK.Material.Buttonbartheme;
using FlutterSDK.Material.Buttontheme;
using FlutterSDK.Material.Card;
using FlutterSDK.Material.Cardtheme;
using FlutterSDK.Material.Checkbox;
using FlutterSDK.Material.Chiptheme;
using FlutterSDK.Material.Colors;
using FlutterSDK.Material.Colorscheme;
using FlutterSDK.Material.Constants;
using FlutterSDK.Material.Curves;
using FlutterSDK.Material.Datatable;
using FlutterSDK.Material.Datatablesource;
using FlutterSDK.Material.Debug;
using FlutterSDK.Material.Dialog;
using FlutterSDK.Material.Dialogtheme;
using FlutterSDK.Material.Divider;
using FlutterSDK.Material.Dividertheme;
using FlutterSDK.Material.Drawer;
using FlutterSDK.Material.Drawerheader;
using FlutterSDK.Material.Dropdown;
using FlutterSDK.Material.Elevationoverlay;
using FlutterSDK.Material.Expandicon;
using FlutterSDK.Material.Feedback;
using FlutterSDK.Material.Flatbutton;
using FlutterSDK.Material.Flexiblespacebar;
using FlutterSDK.Material.Floatingactionbutton;
using FlutterSDK.Material.Floatingactionbuttonlocation;
using FlutterSDK.Material.Floatingactionbuttontheme;
using FlutterSDK.Material.Iconbutton;
using FlutterSDK.Material.Icons;
using FlutterSDK.Material.Inkdecoration;
using FlutterSDK.Material.Inkhighlight;
using FlutterSDK.Material.Inksplash;
using FlutterSDK.Material.Inkwell;
using FlutterSDK.Material.Inputborder;
using FlutterSDK.Material.Inputdecorator;
using FlutterSDK.Material.Listtile;
using FlutterSDK.Material.Material;
using FlutterSDK.Material.Materialbutton;
using FlutterSDK.Material.Materiallocalizations;
using FlutterSDK.Material.Materialstate;
using FlutterSDK.Material.Mergeablematerial;
using FlutterSDK.Material.Navigationrail;
using FlutterSDK.Material.Navigationrailtheme;
using FlutterSDK.Material.Outlinebutton;
using FlutterSDK.Material.Page;
using FlutterSDK.Material.Pagetransitionstheme;
using FlutterSDK.Material.Pickers.Calendardatepicker;
using FlutterSDK.Material.Pickers.Datepickercommon;
using FlutterSDK.Material.Pickers.Datepickerheader;
using FlutterSDK.Material.Pickers.Dateutils;
using FlutterSDK.Material.Pickers.Inputdatepicker;
using FlutterSDK.Material.Popupmenutheme;
using FlutterSDK.Material.Progressindicator;
using FlutterSDK.Material.Radio;
using FlutterSDK.Material.Raisedbutton;
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Scaffold;
using FlutterSDK.Material.Scrollbar;
using FlutterSDK.Material.Selectabletext;
using FlutterSDK.Material.Shadows;
using FlutterSDK.Material.Slidertheme;
using FlutterSDK.Material.Snackbar;
using FlutterSDK.Material.Snackbartheme;
using FlutterSDK.Material.Switch;
using FlutterSDK.Material.Tabbartheme;
using FlutterSDK.Material.Tabcontroller;
using FlutterSDK.Material.Tabindicator;
using FlutterSDK.Material.Tabs;
using FlutterSDK.Material.Textfield;
using FlutterSDK.Material.Textformfield;
using FlutterSDK.Material.Textselection;
using FlutterSDK.Material.Texttheme;
using FlutterSDK.Material.Theme;
using FlutterSDK.Material.Themedata;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Toggleable;
using FlutterSDK.Material.Togglebuttonstheme;
using FlutterSDK.Material.Tooltip;
using FlutterSDK.Material.Tooltiptheme;
using FlutterSDK.Material.Typography;
using FlutterSDK.Painting._Networkimageio;
using FlutterSDK.Painting.Alignment;
using FlutterSDK.Painting.Basictypes;
using FlutterSDK.Painting.Beveledrectangleborder;
using FlutterSDK.Painting.Binding;
using FlutterSDK.Painting.Borderradius;
using FlutterSDK.Painting.Borders;
using FlutterSDK.Painting.Boxborder;
using FlutterSDK.Painting.Boxdecoration;
using FlutterSDK.Painting.Boxfit;
using FlutterSDK.Painting.Boxshadow;
using FlutterSDK.Painting.Circleborder;
using FlutterSDK.Painting.Clip;
using FlutterSDK.Painting.Colors;
using FlutterSDK.Painting.Continuousrectangleborder;
using FlutterSDK.Painting.Debug;
using FlutterSDK.Painting.Decoration;
using FlutterSDK.Painting.Decorationimage;
using FlutterSDK.Painting.Edgeinsets;
using FlutterSDK.Painting.Flutterlogo;
using FlutterSDK.Painting.Fractionaloffset;
using FlutterSDK.Painting.Geometry;
using FlutterSDK.Painting.Gradient;
using FlutterSDK.Painting.Imagecache;
using FlutterSDK.Painting.Imagedecoder;
using FlutterSDK.Painting.Imageprovider;
using FlutterSDK.Painting.Imageresolution;
using FlutterSDK.Painting.Imagestream;
using FlutterSDK.Painting.Inlinespan;
using FlutterSDK.Painting.Matrixutils;
using FlutterSDK.Painting.Notchedshapes;
using FlutterSDK.Painting.Paintutilities;
using FlutterSDK.Painting.Placeholderspan;
using FlutterSDK.Painting.Roundedrectangleborder;
using FlutterSDK.Painting.Shaderwarmup;
using FlutterSDK.Painting.Shapedecoration;
using FlutterSDK.Painting.Stadiumborder;
using FlutterSDK.Painting.Strutstyle;
using FlutterSDK.Painting.Textpainter;
using FlutterSDK.Painting.Textspan;
using FlutterSDK.Painting.Textstyle;
using FlutterSDK.Physics.Clampedsimulation;
using FlutterSDK.Physics.Frictionsimulation;
using FlutterSDK.Physics.Gravitysimulation;
using FlutterSDK.Physics.Simulation;
using FlutterSDK.Physics.Springsimulation;
using FlutterSDK.Physics.Tolerance;
using FlutterSDK.Physics.Utils;
using FlutterSDK.Rendering.Animatedsize;
using FlutterSDK.Rendering.Binding;
using FlutterSDK.Rendering.Box;
using FlutterSDK.Rendering.Customlayout;
using FlutterSDK.Rendering.Custompaint;
using FlutterSDK.Rendering.Debug;
using FlutterSDK.Rendering.Debugoverflowindicator;
using FlutterSDK.Rendering.Editable;
using FlutterSDK.Rendering.Error;
using FlutterSDK.Rendering.Flex;
using FlutterSDK.Rendering.Flow;
using FlutterSDK.Rendering.Image;
using FlutterSDK.Rendering.Layer;
using FlutterSDK.Rendering.Listbody;
using FlutterSDK.Rendering.Listwheelviewport;
using FlutterSDK.Rendering.Mousetracking;
using FlutterSDK.Rendering.@object;
using FlutterSDK.Rendering.Paragraph;
using FlutterSDK.Rendering.Performanceoverlay;
using FlutterSDK.Rendering.Platformview;
using FlutterSDK.Rendering.Proxybox;
using FlutterSDK.Rendering.Proxysliver;
using FlutterSDK.Rendering.Rotatedbox;
using FlutterSDK.Rendering.Shiftedbox;
using FlutterSDK.Rendering.Sliver;
using FlutterSDK.Rendering.Sliverfill;
using FlutterSDK.Rendering.Sliverfixedextentlist;
using FlutterSDK.Rendering.Slivergrid;
using FlutterSDK.Rendering.Sliverlist;
using FlutterSDK.Rendering.Slivermultiboxadaptor;
using FlutterSDK.Rendering.Sliverpadding;
using FlutterSDK.Rendering.Sliverpersistentheader;
using FlutterSDK.Rendering.Stack;
using FlutterSDK.Rendering.Table;
using FlutterSDK.Rendering.Tableborder;
using FlutterSDK.Rendering.Texture;
using FlutterSDK.Rendering.Tweens;
using FlutterSDK.Rendering.View;
using FlutterSDK.Rendering.Viewport;
using FlutterSDK.Rendering.Viewportoffset;
using FlutterSDK.Rendering.Wrap;
using FlutterSDK.Scheduler;
using FlutterSDK.Scheduler.Binding;
using FlutterSDK.Scheduler.Debug;
using FlutterSDK.Scheduler.Priority;
using FlutterSDK.Scheduler.Ticker;
using FlutterSDK.Semantics.Binding;
using FlutterSDK.Semantics.Debug;
using FlutterSDK.Semantics.Semantics;
using FlutterSDK.Semantics.Semanticsevent;
using FlutterSDK.Semantics.Semanticsservice;
using FlutterSDK.Services.Assetbundle;
using FlutterSDK.Services.Binarymessenger;
using FlutterSDK.Services.Binding;
using FlutterSDK.Services.Clipboard;
using FlutterSDK.Services.Fontloader;
using FlutterSDK.Services.Hapticfeedback;
using FlutterSDK.Services.Keyboardkey;
using FlutterSDK.Services.Keyboardmaps;
using FlutterSDK.Services.Messagecodec;
using FlutterSDK.Services.Messagecodecs;
using FlutterSDK.Services.Platformchannel;
using FlutterSDK.Services.Platformmessages;
using FlutterSDK.Services.Platformviews;
using FlutterSDK.Services.Rawkeyboard;
using FlutterSDK.Services.Rawkeyboardandroid;
using FlutterSDK.Services.Rawkeyboardfuchsia;
using FlutterSDK.Services.Rawkeyboardlinux;
using FlutterSDK.Services.Rawkeyboardmacos;
using FlutterSDK.Services.Rawkeyboardweb;
using FlutterSDK.Services.Systemchannels;
using FlutterSDK.Services.Systemchrome;
using FlutterSDK.Services.Systemnavigator;
using FlutterSDK.Services.Systemsound;
using FlutterSDK.Services.Textediting;
using FlutterSDK.Services.Textformatter;
using FlutterSDK.Services.Textinput;
using FlutterSDK.Widgets.Actions;
using FlutterSDK.Widgets.Animatedcrossfade;
using FlutterSDK.Widgets.Animatedlist;
using FlutterSDK.Widgets.Animatedsize;
using FlutterSDK.Widgets.Animatedswitcher;
using FlutterSDK.Widgets.Annotatedregion;
using FlutterSDK.Widgets.App;
using FlutterSDK.Widgets.Async;
using FlutterSDK.Widgets.Automatickeepalive;
using FlutterSDK.Widgets.Banner;
using FlutterSDK.Widgets.Basic;
using FlutterSDK.Widgets.Binding;
using FlutterSDK.Widgets.Bottomnavigationbaritem;
using FlutterSDK.Widgets.Colorfilter;
using FlutterSDK.Widgets.Container;
using FlutterSDK.Widgets.Debug;
using FlutterSDK.Widgets.Dismissible;
using FlutterSDK.Widgets.Disposablebuildcontext;
using FlutterSDK.Widgets.Draggablescrollablesheet;
using FlutterSDK.Widgets.Dragtarget;
using FlutterSDK.Widgets.Editabletext;
using FlutterSDK.Widgets.Fadeinimage;
using FlutterSDK.Widgets.Focusmanager;
using FlutterSDK.Widgets.Focusscope;
using FlutterSDK.Widgets.Focustraversal;
using FlutterSDK.Widgets.Form;
using FlutterSDK.Widgets.Framework;
using FlutterSDK.Widgets.Gesturedetector;
using FlutterSDK.Widgets.Gridpaper;
using FlutterSDK.Widgets.Heroes;
using FlutterSDK.Widgets.Icon;
using FlutterSDK.Widgets.Icondata;
using FlutterSDK.Widgets.Icontheme;
using FlutterSDK.Widgets.Iconthemedata;
using FlutterSDK.Widgets.Image;
using FlutterSDK.Widgets.Imagefilter;
using FlutterSDK.Widgets.Imageicon;
using FlutterSDK.Widgets.Implicitanimations;
using FlutterSDK.Widgets.Inheritedmodel;
using FlutterSDK.Widgets.Inheritednotifier;
using FlutterSDK.Widgets.Inheritedtheme;
using FlutterSDK.Widgets.Layoutbuilder;
using FlutterSDK.Widgets.Listwheelscrollview;
using FlutterSDK.Widgets.Localizations;
using FlutterSDK.Widgets.Mediaquery;
using FlutterSDK.Widgets.Modalbarrier;
using FlutterSDK.Widgets.Navigationtoolbar;
using FlutterSDK.Widgets.Navigator;
using FlutterSDK.Widgets.Nestedscrollview;
using FlutterSDK.Widgets.Notificationlistener;
using FlutterSDK.Widgets.Orientationbuilder;
using FlutterSDK.Widgets.Overlay;
using FlutterSDK.Widgets.Overscrollindicator;
using FlutterSDK.Widgets.Pages;
using FlutterSDK.Widgets.Pagestorage;
using FlutterSDK.Widgets.Pageview;
using FlutterSDK.Widgets.Performanceoverlay;
using FlutterSDK.Widgets.Placeholder;
using FlutterSDK.Widgets.Platformview;
using FlutterSDK.Widgets.Preferredsize;
using FlutterSDK.Widgets.Primaryscrollcontroller;
using FlutterSDK.Widgets.Rawkeyboardlistener;
using FlutterSDK.Widgets.Routes;
using FlutterSDK.Widgets.Safearea;
using FlutterSDK.Widgets.Scrollable;
using FlutterSDK.Widgets.Scrollactivity;
using FlutterSDK.Widgets.Scrollawareimageprovider;
using FlutterSDK.Widgets.Scrollbar;
using FlutterSDK.Widgets.Scrollconfiguration;
using FlutterSDK.Widgets.Scrollcontext;
using FlutterSDK.Widgets.Scrollcontroller;
using FlutterSDK.Widgets.Scrollmetrics;
using FlutterSDK.Widgets.Scrollnotification;
using FlutterSDK.Widgets.Scrollphysics;
using FlutterSDK.Widgets.Scrollposition;
using FlutterSDK.Widgets.Scrollpositionwithsinglecontext;
using FlutterSDK.Widgets.Scrollsimulation;
using FlutterSDK.Widgets.Scrollview;
using FlutterSDK.Widgets.Semanticsdebugger;
using FlutterSDK.Widgets.Shortcuts;
using FlutterSDK.Widgets.Singlechildscrollview;
using FlutterSDK.Widgets.Sizechangedlayoutnotifier;
using FlutterSDK.Widgets.Sliver;
using FlutterSDK.Widgets.Sliverfill;
using FlutterSDK.Widgets.Sliverlayoutbuilder;
using FlutterSDK.Widgets.Sliverpersistentheader;
using FlutterSDK.Widgets.Sliverprototypeextentlist;
using FlutterSDK.Widgets.Spacer;
using FlutterSDK.Widgets.Statustransitions;
using FlutterSDK.Widgets.Table;
using FlutterSDK.Widgets.Text;
using FlutterSDK.Widgets.Textselection;
using FlutterSDK.Widgets.Texture;
using FlutterSDK.Widgets.Tickerprovider;
using FlutterSDK.Widgets.Title;
using FlutterSDK.Widgets.Transitions;
using FlutterSDK.Widgets.Tweenanimationbuilder;
using FlutterSDK.Widgets.Uniquewidget;
using FlutterSDK.Widgets.Valuelistenablebuilder;
using FlutterSDK.Widgets.Viewport;
using FlutterSDK.Widgets.Visibility;
using FlutterSDK.Widgets.Widgetinspector;
using FlutterSDK.Widgets.Widgetspan;
using FlutterSDK.Widgets.Willpopscope;
using SkiaSharp;
using static FlutterSDK.Global;
namespace FlutterSDK.Painting.Matrixutils
{
    internal static class MatrixutilsDefaultClass
    {
        /// <Summary>
        /// Returns a list of strings representing the given transform in a format
        /// useful for [TransformProperty].
        ///
        /// If the argument is null, returns a list with the single string "null".
        /// </Summary>
        internal static List<string> DebugDescribeTransform(Matrix4 transform)
        {
            if (transform == null) return new List<string>() { "null" };
            return new List<string>() { $"'[0] {DebugDefaultClass.DebugFormatDouble(transform.Entry(0, 0))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(0, 1))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(0, 2))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(0, 3))}'", $"'[1] {DebugDefaultClass.DebugFormatDouble(transform.Entry(1, 0))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(1, 1))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(1, 2))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(1, 3))}'", $"'[2] {DebugDefaultClass.DebugFormatDouble(transform.Entry(2, 0))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(2, 1))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(2, 2))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(2, 3))}'", $"'[3] {DebugDefaultClass.DebugFormatDouble(transform.Entry(3, 0))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(3, 1))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(3, 2))},{DebugDefaultClass.DebugFormatDouble(transform.Entry(3, 3))}'" };
        }



    }

    /// <Summary>
    /// Utility functions for working with matrices.
    /// </Summary>
    public class MatrixUtils
    {
        internal MatrixUtils()
        {

        }
        internal virtual List<float> _MinMax { get; set; }

        /// <Summary>
        /// Returns the given [transform] matrix as an [Offset], if the matrix is
        /// nothing but a 2D translation.
        ///
        /// Otherwise, returns null.
        /// </Summary>
        public virtual Offset GetAsTranslation(Matrix4 transform)
        {

            List<float> values = transform.Storage;
            if (values[0] == 1.0 && values[1] == 0.0 && values[2] == 0.0 && values[3] == 0.0 && values[4] == 0.0 && values[5] == 1.0 && values[6] == 0.0 && values[7] == 0.0 && values[8] == 0.0 && values[9] == 0.0 && values[10] == 1.0 && values[11] == 0.0 && values[14] == 0.0 && values[15] == 1.0)
            {
                return new Offset(values[12], values[13]);
            }

            return null;
        }




        /// <Summary>
        /// Returns the given [transform] matrix as a [double] describing a uniform
        /// scale, if the matrix is nothing but a symmetric 2D scale transform.
        ///
        /// Otherwise, returns null.
        /// </Summary>
        public virtual double GetAsScale(Matrix4 transform)
        {

            List<float> values = transform.Storage;
            if (values[1] == 0.0 && values[2] == 0.0 && values[3] == 0.0 && values[4] == 0.0 && values[6] == 0.0 && values[7] == 0.0 && values[8] == 0.0 && values[9] == 0.0 && values[10] == 1.0 && values[11] == 0.0 && values[12] == 0.0 && values[13] == 0.0 && values[14] == 0.0 && values[15] == 1.0 && values[0] == values[5])
            {
                return values[0];
            }

            return null;
        }




        /// <Summary>
        /// Returns true if the given matrices are exactly equal, and false
        /// otherwise. Null values are assumed to be the identity matrix.
        /// </Summary>
        public virtual bool MatrixEquals(Matrix4 a, Matrix4 b)
        {
            if (Dart.CoreDefaultClass.Identical(a, b)) return true;

            if (a == null) return IsIdentity(b);
            if (b == null) return IsIdentity(a);

            return a.Storage[0] == b.Storage[0] && a.Storage[1] == b.Storage[1] && a.Storage[2] == b.Storage[2] && a.Storage[3] == b.Storage[3] && a.Storage[4] == b.Storage[4] && a.Storage[5] == b.Storage[5] && a.Storage[6] == b.Storage[6] && a.Storage[7] == b.Storage[7] && a.Storage[8] == b.Storage[8] && a.Storage[9] == b.Storage[9] && a.Storage[10] == b.Storage[10] && a.Storage[11] == b.Storage[11] && a.Storage[12] == b.Storage[12] && a.Storage[13] == b.Storage[13] && a.Storage[14] == b.Storage[14] && a.Storage[15] == b.Storage[15];
        }




        /// <Summary>
        /// Whether the given matrix is the identity matrix.
        /// </Summary>
        public virtual bool IsIdentity(Matrix4 a)
        {

            return a.Storage[0] == 1.0 && a.Storage[1] == 0.0 && a.Storage[2] == 0.0 && a.Storage[3] == 0.0 && a.Storage[4] == 0.0 && a.Storage[5] == 1.0 && a.Storage[6] == 0.0 && a.Storage[7] == 0.0 && a.Storage[8] == 0.0 && a.Storage[9] == 0.0 && a.Storage[10] == 1.0 && a.Storage[11] == 0.0 && a.Storage[12] == 0.0 && a.Storage[13] == 0.0 && a.Storage[14] == 0.0 && a.Storage[15] == 1.0;
        }




        /// <Summary>
        /// Applies the given matrix as a perspective transform to the given point.
        ///
        /// This function assumes the given point has a z-coordinate of 0.0. The
        /// z-coordinate of the result is ignored.
        /// </Summary>
        public virtual Offset TransformPoint(Matrix4 transform, FlutterBinding.UI.Offset point)
        {
            List<float> storage = transform.Storage;
            double x = point.Dx;
            double y = point.Dy;
            double rx = storage[0] * x + storage[4] * y + storage[12];
            double ry = storage[1] * x + storage[5] * y + storage[13];
            double rw = storage[3] * x + storage[7] * y + storage[15];
            if (rw == 1.0)
            {
                return new Offset(rx, ry);
            }
            else
            {
                return new Offset(rx / rw, ry / rw);
            }

        }




        /// <Summary>
        /// Returns a rect that bounds the result of applying the given matrix as a
        /// perspective transform to the given rect.
        ///
        /// This version of the operation is slower than the regular transformRect
        /// method, but it avoids creating infinite values from large finite values
        /// if it can.
        /// </Summary>
        private Rect _SafeTransformRect(Matrix4 transform, FlutterBinding.UI.Rect rect)
        {
            List<float> storage = transform.Storage;
            bool isAffine = storage[3] == 0.0 && storage[7] == 0.0 && storage[15] == 1.0;
            _MinMax = (_MinMax == null ? new List<float>(4) : _MinMax);
            _Accumulate(storage, rect.Left, rect.Top, true, isAffine);
            _Accumulate(storage, rect.Right, rect.Top, false, isAffine);
            _Accumulate(storage, rect.Left, rect.Bottom, false, isAffine);
            _Accumulate(storage, rect.Right, rect.Bottom, false, isAffine);
            return Rect.FromLTRB(_MinMax[0], _MinMax[1], _MinMax[2], _MinMax[3]);
        }




        private void _Accumulate(List<float> m, double x, double y, bool first, bool isAffine)
        {
            double w = isAffine ? 1.0 : 1.0 / (m[3] * x + m[7] * y + m[15]);
            double tx = (m[0] * x + m[4] * y + m[12]) * w;
            double ty = (m[1] * x + m[5] * y + m[13]) * w;
            if (first)
            {
                _MinMax[0] = _MinMax[2] = tx;
                _MinMax[1] = _MinMax[3] = ty;
            }
            else
            {
                if (tx < _MinMax[0])
                {
                    _MinMax[0] = tx;
                }

                if (ty < _MinMax[1])
                {
                    _MinMax[1] = ty;
                }

                if (tx > _MinMax[2])
                {
                    _MinMax[2] = tx;
                }

                if (ty > _MinMax[3])
                {
                    _MinMax[3] = ty;
                }

            }

        }




        /// <Summary>
        /// Returns a rect that bounds the result of applying the given matrix as a
        /// perspective transform to the given rect.
        ///
        /// This function assumes the given rect is in the plane with z equals 0.0.
        /// The transformed rect is then projected back into the plane with z equals
        /// 0.0 before computing its bounding rect.
        /// </Summary>
        public virtual Rect TransformRect(Matrix4 transform, FlutterBinding.UI.Rect rect)
        {
            List<float> storage = transform.Storage;
            double x = rect.Left;
            double y = rect.Top;
            double w = rect.Right - x;
            double h = rect.Bottom - y;
            if (!w.IsFinite() || !h.IsFinite())
            {
                return _SafeTransformRect(transform, rect);
            }

            double wx = storage[0] * w;
            double hx = storage[4] * h;
            double rx = storage[0] * x + storage[4] * y + storage[12];
            double wy = storage[1] * w;
            double hy = storage[5] * h;
            double ry = storage[1] * x + storage[5] * y + storage[13];
            if (storage[3] == 0.0 && storage[7] == 0.0 && storage[15] == 1.0)
            {
                double left = rx;
                double right = rx;
                if (wx < 0)
                {
                    left += wx;
                }
                else
                {
                    right += wx;
                }

                if (hx < 0)
                {
                    left += hx;
                }
                else
                {
                    right += hx;
                }

                double top = ry;
                double bottom = ry;
                if (wy < 0)
                {
                    top += wy;
                }
                else
                {
                    bottom += wy;
                }

                if (hy < 0)
                {
                    top += hy;
                }
                else
                {
                    bottom += hy;
                }

                return Rect.FromLTRB(left, top, right, bottom);
            }
            else
            {
                double ww = storage[3] * w;
                double hw = storage[7] * h;
                double rw = storage[3] * x + storage[7] * y + storage[15];
                double ulx = rx / rw;
                double uly = ry / rw;
                double urx = (rx + wx) / (rw + ww);
                double ury = (ry + wy) / (rw + ww);
                double llx = (rx + hx) / (rw + hw);
                double lly = (ry + hy) / (rw + hw);
                double lrx = (rx + wx + hx) / (rw + ww + hw);
                double lry = (ry + wy + hy) / (rw + ww + hw);
                return Rect.FromLTRB(_Min4(ulx, urx, llx, lrx), _Min4(uly, ury, lly, lry), _Max4(ulx, urx, llx, lrx), _Max4(uly, ury, lly, lry));
            }

        }




        private double _Min4(double a, double b, double c, double d)
        {
            double e = (a < b) ? a : b;
            double f = (c < d) ? c : d;
            return (e < f) ? e : f;
        }




        private double _Max4(double a, double b, double c, double d)
        {
            double e = (a > b) ? a : b;
            double f = (c > d) ? c : d;
            return (e > f) ? e : f;
        }




        /// <Summary>
        /// Returns a rect that bounds the result of applying the inverse of the given
        /// matrix as a perspective transform to the given rect.
        ///
        /// This function assumes the given rect is in the plane with z equals 0.0.
        /// The transformed rect is then projected back into the plane with z equals
        /// 0.0 before computing its bounding rect.
        /// </Summary>
        public virtual Rect InverseTransformRect(Matrix4 transform, FlutterBinding.UI.Rect rect)
        {

            if (IsIdentity(transform)) return rect;
            transform = Matrix4.Copy(transform);
            Matrix4.Copy(transform).Invert();
            return TransformRect(transform, rect);
        }




        /// <Summary>
        /// Create a transformation matrix which mimics the effects of tangentially
        /// wrapping the plane on which this transform is applied around a cylinder
        /// and then looking at the cylinder from a point outside the cylinder.
        ///
        /// The `radius` simulates the radius of the cylinder the plane is being
        /// wrapped onto. If the transformation is applied to a 0-dimensional dot
        /// instead of a plane, the dot would simply translate by +/- `radius` pixels
        /// along the `orientation` [Axis] when rotating from 0 to +/- 90 degrees.
        ///
        /// A positive radius means the object is closest at 0 `angle` and a negative
        /// radius means the object is closest at π `angle` or 180 degrees.
        ///
        /// The `angle` argument is the difference in angle in radians between the
        /// object and the viewing point. A positive `angle` on a positive `radius`
        /// moves the object up when `orientation` is vertical and right when
        /// horizontal.
        ///
        /// The transformation is always done such that a 0 `angle` keeps the
        /// transformed object at exactly the same size as before regardless of
        /// `radius` and `perspective` when `radius` is positive.
        ///
        /// The `perspective` argument is a number between 0 and 1 where 0 means
        /// looking at the object from infinitely far with an infinitely narrow field
        /// of view and 1 means looking at the object from infinitely close with an
        /// infinitely wide field of view. Defaults to a sane but arbitrary 0.001.
        ///
        /// The `orientation` is the direction of the rotation axis.
        ///
        /// Because the viewing position is a point, it's never possible to see the
        /// outer side of the cylinder at or past +/- π / 2 or 90 degrees and it's
        /// almost always possible to end up seeing the inner side of the cylinder
        /// or the back side of the transformed plane before π / 2 when perspective > 0.
        /// </Summary>
        public virtual Matrix4 CreateCylindricalProjectionTransform(double radius = default(double), double angle = default(double), double perspective = 0.001, FlutterSDK.Painting.Basictypes.Axis orientation = default(FlutterSDK.Painting.Basictypes.Axis))
        {




            Matrix4 result = Matrix4.Identity();
            Matrix4.Identity().SetEntry(3, 2, -perspective);
            Matrix4.Identity().SetEntry(2, 3, -radius);
            Matrix4.Identity().SetEntry(3, 3, perspective * radius + 1.0);
            result = result * ((orientation == Axis.Horizontal ? Matrix4.RotationY(angle) : Matrix4.RotationX(angle)) * Matrix4.TranslationValues(0.0, 0.0, radius)) as Matrix4;
            return result;
        }




        /// <Summary>
        /// Returns a matrix that transforms every point to [offset].
        /// </Summary>
        public virtual Matrix4 ForceToPoint(FlutterBinding.UI.Offset offset)
        {
            return Matrix4.Identity();
            Matrix4.Identity().SetRow(0, Vector4(0, 0, 0, offset.Dx));
            Matrix4.Identity().SetRow(1, Vector4(0, 0, 0, offset.Dy));
        }



    }


    /// <Summary>
    /// Property which handles [Matrix4] that represent transforms.
    /// </Summary>
    public class TransformProperty : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<object>
    {
        /// <Summary>
        /// Create a diagnostics property for [Matrix4] objects.
        ///
        /// The [showName] and [level] arguments must not be null.
        /// </Summary>
        public TransformProperty(string name, Matrix4 value, bool showName = true, @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, showName: showName, defaultValue: defaultValue, level: level)
        {

        }

        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
        {
            if (parentConfiguration != null && !parentConfiguration.LineBreakProperties)
            {
                List<string> values = new List<string>() { $"'{DebugDefaultClass.DebugFormatDouble(Value.Entry(0, 0))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(0, 1))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(0, 2))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(0, 3))}'", $"'{DebugDefaultClass.DebugFormatDouble(Value.Entry(1, 0))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(1, 1))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(1, 2))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(1, 3))}'", $"'{DebugDefaultClass.DebugFormatDouble(Value.Entry(2, 0))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(2, 1))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(2, 2))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(2, 3))}'", $"'{DebugDefaultClass.DebugFormatDouble(Value.Entry(3, 0))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(3, 1))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(3, 2))},{DebugDefaultClass.DebugFormatDouble(Value.Entry(3, 3))}'" };
                return $"'[{values.Join("; ")}]'";
            }

            return MatrixutilsDefaultClass.DebugDescribeTransform(Value).Join('\n');
        }



    }

}
