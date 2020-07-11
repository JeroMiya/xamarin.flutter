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
using FlutterSDK.Material.Reorderablelist;
using FlutterSDK.Material.Time;
using FlutterSDK.Material.Typography;
using file:///C:/src/xamarin.flutter/flutter/lib/scheduler.dart;
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
namespace FlutterSDK.Widgets.Basic
{
    public delegate FlutterSDK.Widgets.Framework.Widget StatefulWidgetBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Framework.StateSetter setState);
    internal static class BasicDefaultClass
    {
        internal static FlutterSDK.Painting.Basictypes.AxisDirection GetAxisDirectionFromAxisReverseAndDirectionality(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Painting.Basictypes.Axis axis, bool reverse)
        {
            throw new NotImplementedException();
        }

    }

    public class Directionality : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public Directionality(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), TextDirection textDirection = default(TextDirection), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.TextDirection = textDirection; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual TextDirection TextDirection { get; set; }
        #endregion

        #region methods

        public virtual TextDirection Of(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Basic.Directionality oldWidget) { throw new NotImplementedException(); }
        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class Opacity : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Opacity(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double opacity = default(double), bool alwaysIncludeSemantics = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.OpacityValue = opacity;
            this.AlwaysIncludeSemantics = alwaysIncludeSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double OpacityValue { get; set; }
        public virtual bool AlwaysIncludeSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderOpacity CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderOpacity renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ShaderMask : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ShaderMask(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.ShaderCallback shaderCallback = default(FlutterSDK.Rendering.Proxybox.ShaderCallback), FlutterBinding.UI.BlendMode blendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.ShaderCallback = shaderCallback;
            this.BlendMode = blendMode; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.ShaderCallback ShaderCallback { get; set; }
        public virtual FlutterBinding.UI.BlendMode BlendMode { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderShaderMask CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderShaderMask renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class BackdropFilter : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public BackdropFilter(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), ImageFilter filter = default(ImageFilter), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Filter = filter; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual ImageFilter Filter { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderBackdropFilter CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderBackdropFilter renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class CustomPaint : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public CustomPaint(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Custompaint.CustomPainter painter = default(FlutterSDK.Rendering.Custompaint.CustomPainter), FlutterSDK.Rendering.Custompaint.CustomPainter foregroundPainter = default(FlutterSDK.Rendering.Custompaint.CustomPainter), Size size = default(Size), bool isComplex = false, bool willChange = false, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Painter = painter;
            this.ForegroundPainter = foregroundPainter;
            this.Size = size;
            this.IsComplex = isComplex;
            this.WillChange = willChange; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Custompaint.CustomPainter Painter { get; set; }
        public virtual FlutterSDK.Rendering.Custompaint.CustomPainter ForegroundPainter { get; set; }
        public virtual Size Size { get; set; }
        public virtual bool IsComplex { get; set; }
        public virtual bool WillChange { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Custompaint.RenderCustomPaint CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Custompaint.RenderCustomPaint renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DidUnmountRenderObject(FlutterSDK.Rendering.Custompaint.RenderCustomPaint renderObject) { throw new NotImplementedException(); }
        public new void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class ClipRect : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ClipRect(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Rect>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Clipper = clipper;
            this.ClipBehavior = clipBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> Clipper { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderClipRect CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderClipRect renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DidUnmountRenderObject(FlutterSDK.Rendering.Proxybox.RenderClipRect renderObject) { throw new NotImplementedException(); }
        public new void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ClipRRect : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ClipRRect(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Rendering.Proxybox.CustomClipper<RRect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<RRect>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.BorderRadius = borderRadius;
            this.Clipper = clipper;
            this.ClipBehavior = clipBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<RRect> Clipper { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderClipRRect CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderClipRRect renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ClipOval : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ClipOval(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Rect>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Clipper = clipper;
            this.ClipBehavior = clipBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<Rect> Clipper { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderClipOval CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderClipOval renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DidUnmountRenderObject(FlutterSDK.Rendering.Proxybox.RenderClipOval renderObject) { throw new NotImplementedException(); }
        public new void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ClipPath : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ClipPath(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.CustomClipper<Path> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Path>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Clipper = clipper;
            this.ClipBehavior = clipBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<Path> Clipper { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        #endregion

        #region methods

        public virtual FlutterSDK.Widgets.Framework.Widget Shape(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget)) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Proxybox.RenderClipPath CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderClipPath renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DidUnmountRenderObject(FlutterSDK.Rendering.Proxybox.RenderClipPath renderObject) { throw new NotImplementedException(); }
        public new void DidUnmountRenderObject(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class PhysicalModel : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public PhysicalModel(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Boxborder.BoxShape shape = default(FlutterSDK.Painting.Boxborder.BoxShape), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), double elevation = 0.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.BorderRadius = borderRadius;
            this.Elevation = elevation;
            this.Color = color;
            this.ShadowColor = shadowColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Boxborder.BoxShape Shape { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public virtual FlutterSDK.Painting.Borderradius.BorderRadius BorderRadius { get; set; }
        public virtual double Elevation { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterBinding.UI.Color ShadowColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderPhysicalModel CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderPhysicalModel renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class PhysicalShape : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public PhysicalShape(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.CustomClipper<Path> clipper = default(FlutterSDK.Rendering.Proxybox.CustomClipper<Path>), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), double elevation = 0.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Clipper = clipper;
            this.ClipBehavior = clipBehavior;
            this.Elevation = elevation;
            this.Color = color;
            this.ShadowColor = shadowColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.CustomClipper<Path> Clipper { get; set; }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public virtual double Elevation { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FlutterBinding.UI.Color ShadowColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderPhysicalShape CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderPhysicalShape renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class Transform : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Transform(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Matrix4 transform = default(Matrix4), FlutterBinding.UI.Offset origin = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), bool transformHitTests = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.TransformValue = transform;
            this.Origin = origin;
            this.Alignment = alignment;
            this.TransformHitTests = transformHitTests; throw new NotImplementedException();
        }
        public static Transform Rotate(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double angle = default(double), FlutterBinding.UI.Offset origin = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), bool transformHitTests = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Transform(key: key, child: child); instance.Origin = origin;
            instance.Alignment = alignment;
            instance.TransformHitTests = transformHitTests; throw new NotImplementedException();
        }
        public static Transform Translate(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), bool transformHitTests = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Transform(key: key, child: child); instance.TransformHitTests = transformHitTests; throw new NotImplementedException();
        }
        public static Transform Scale(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double scale = default(double), FlutterBinding.UI.Offset origin = default(FlutterBinding.UI.Offset), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), bool transformHitTests = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Transform(key: key, child: child); instance.Origin = origin;
            instance.Alignment = alignment;
            instance.TransformHitTests = transformHitTests; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Matrix4 TransformValue { get; set; }
        public virtual FlutterBinding.UI.Offset Origin { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual bool TransformHitTests { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderTransform CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderTransform renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class CompositedTransformTarget : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public CompositedTransformTarget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Link = link; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Layer.LayerLink Link { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderLeaderLayer CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderLeaderLayer renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class CompositedTransformFollower : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public CompositedTransformFollower(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Layer.LayerLink link = default(FlutterSDK.Rendering.Layer.LayerLink), bool showWhenUnlinked = true, FlutterBinding.UI.Offset offset = default(FlutterBinding.UI.Offset), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Link = link;
            this.ShowWhenUnlinked = showWhenUnlinked;
            this.Offset = offset; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Layer.LayerLink Link { get; set; }
        public virtual bool ShowWhenUnlinked { get; set; }
        public virtual FlutterBinding.UI.Offset Offset { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderFollowerLayer CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderFollowerLayer renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class FittedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public FittedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Fit = fit;
            this.Alignment = alignment; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Boxfit.BoxFit Fit { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderFittedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderFittedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class FractionalTranslation : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public FractionalTranslation(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Offset translation = default(FlutterBinding.UI.Offset), bool transformHitTests = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Translation = translation;
            this.TransformHitTests = transformHitTests; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Offset Translation { get; set; }
        public virtual bool TransformHitTests { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderFractionalTranslation CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderFractionalTranslation renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class RotatedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public RotatedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int quarterTurns = default(int), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.QuarterTurns = quarterTurns; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int QuarterTurns { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Rotatedbox.RenderRotatedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Rotatedbox.RenderRotatedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class Padding : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Padding(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.PaddingValue = padding; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry PaddingValue { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderPadding CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderPadding renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class Align : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Align(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double widthFactor = default(double), double heightFactor = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Alignment = alignment;
            this.WidthFactor = widthFactor;
            this.HeightFactor = heightFactor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual double WidthFactor { get; set; }
        public virtual double HeightFactor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderPositionedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderPositionedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class Center : FlutterSDK.Widgets.Basic.Align
    {
        #region constructors
        public Center(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double widthFactor = default(double), double heightFactor = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, widthFactor: widthFactor, heightFactor: heightFactor, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    public class CustomSingleChildLayout : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public CustomSingleChildLayout(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate @delegate = default(FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.@delegate = @delegate; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Shiftedbox.SingleChildLayoutDelegate @delegate { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderCustomSingleChildLayoutBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderCustomSingleChildLayoutBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class LayoutId : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.Customlayout.MultiChildLayoutParentData>
    {
        #region constructors
        public LayoutId(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), @Object id = default(@Object), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key ?? new ValueKey<object>(id), child: child)
        {
            this.Id = id; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual @Object Id { get; set; }
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class CustomMultiChildLayout : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public CustomMultiChildLayout(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate @delegate = default(FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.@delegate = @delegate; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Customlayout.MultiChildLayoutDelegate @delegate { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Customlayout.RenderCustomMultiChildLayoutBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Customlayout.RenderCustomMultiChildLayoutBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class SizedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SizedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double width = default(double), double height = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Width = width;
            this.Height = height; throw new NotImplementedException();
        }
        public static SizedBox Expand(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new SizedBox(key: key, child: child); throw new NotImplementedException();
        }
        public static SizedBox Shrink(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new SizedBox(key: key, child: child); throw new NotImplementedException();
        }
        public static SizedBox FromSize(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), Size size = default(Size))
        {
            var instance = new SizedBox(key: key, child: child); throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        internal virtual FlutterSDK.Rendering.Box.BoxConstraints _AdditionalConstraints { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderConstrainedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderConstrainedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ConstrainedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ConstrainedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Constraints = constraints; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderConstrainedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderConstrainedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class UnconstrainedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public UnconstrainedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Basictypes.Axis constrainedAxis = default(FlutterSDK.Painting.Basictypes.Axis))
        : base(key: key, child: child)
        {
            this.TextDirection = textDirection;
            this.Alignment = alignment;
            this.ConstrainedAxis = constrainedAxis; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis ConstrainedAxis { get; set; }
        #endregion

        #region methods

        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderUnconstrainedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Shiftedbox.RenderUnconstrainedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class FractionallySizedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public FractionallySizedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double widthFactor = default(double), double heightFactor = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Alignment = alignment;
            this.WidthFactor = widthFactor;
            this.HeightFactor = heightFactor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double WidthFactor { get; set; }
        public virtual double HeightFactor { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderFractionallySizedOverflowBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderFractionallySizedOverflowBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class LimitedBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public LimitedBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double maxWidth = default(double), double maxHeight = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.MaxWidth = maxWidth;
            this.MaxHeight = maxHeight; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double MaxWidth { get; set; }
        public virtual double MaxHeight { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderLimitedBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderLimitedBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class OverflowBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public OverflowBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), double minWidth = default(double), double maxWidth = default(double), double minHeight = default(double), double maxHeight = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Alignment = alignment;
            this.MinWidth = minWidth;
            this.MaxWidth = maxWidth;
            this.MinHeight = minHeight;
            this.MaxHeight = maxHeight; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual double MinWidth { get; set; }
        public virtual double MaxWidth { get; set; }
        public virtual double MinHeight { get; set; }
        public virtual double MaxHeight { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderConstrainedOverflowBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderConstrainedOverflowBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class SizedOverflowBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SizedOverflowBox(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), Size size = default(Size), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Size = size;
            this.Alignment = alignment; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual Size Size { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderSizedOverflowBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderSizedOverflowBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class Offstage : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Offstage(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool offstage = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.OffstageValue = offstage; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool OffstageValue { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderOffstage CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderOffstage renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Basic._OffstageElement CreateElement() { throw new NotImplementedException(); }

        #endregion
    }


    public class _OffstageElement : FlutterSDK.Widgets.Framework.SingleChildRenderObjectElement
    {
        #region constructors
        public _OffstageElement(FlutterSDK.Widgets.Basic.Offstage widget)
        : base(widget)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Basic.Offstage Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void DebugVisitOnstageChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }

        #endregion
    }


    public class AspectRatio : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public AspectRatio(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double aspectRatio = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.AspectRatioValue = aspectRatio; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double AspectRatioValue { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderAspectRatio CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderAspectRatio renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class IntrinsicWidth : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public IntrinsicWidth(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double stepWidth = default(double), double stepHeight = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.StepWidth = stepWidth;
            this.StepHeight = stepHeight; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double StepWidth { get; set; }
        public virtual double StepHeight { get; set; }
        internal virtual double _StepWidth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual double _StepHeight { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderIntrinsicWidth CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderIntrinsicWidth renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class IntrinsicHeight : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public IntrinsicHeight(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderIntrinsicHeight CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class Baseline : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Baseline(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double baseline = default(double), TextBaseline baselineType = default(TextBaseline), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.BaselineValue = baseline;
            this.BaselineType = baselineType; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double BaselineValue { get; set; }
        public virtual TextBaseline BaselineType { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Shiftedbox.RenderBaseline CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Shiftedbox.RenderBaseline renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverToBoxAdapter : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SliverToBoxAdapter(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Sliver.RenderSliverToBoxAdapter CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class SliverPadding : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public SliverPadding(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget sliver = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: sliver)
        {
            this.Padding = padding; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Sliverpadding.RenderSliverPadding CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Sliverpadding.RenderSliverPadding renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ListBody : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public ListBody(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis mainAxis = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.MainAxis = mainAxis;
            this.Reverse = reverse; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Basictypes.Axis MainAxis { get; set; }
        public virtual bool Reverse { get; set; }
        #endregion

        #region methods

        private FlutterSDK.Painting.Basictypes.AxisDirection _GetDirection(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Listbody.RenderListBody CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Listbody.RenderListBody renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class Stack : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public Stack(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Stack.StackFit fit = default(FlutterSDK.Rendering.Stack.StackFit), FlutterSDK.Rendering.Stack.Overflow overflow = default(FlutterSDK.Rendering.Stack.Overflow), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.Alignment = alignment;
            this.TextDirection = textDirection;
            this.Fit = fit;
            this.Overflow = overflow; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Rendering.Stack.StackFit Fit { get; set; }
        public virtual FlutterSDK.Rendering.Stack.Overflow Overflow { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Stack.RenderStack CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Stack.RenderStack renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class IndexedStack : FlutterSDK.Widgets.Basic.Stack
    {
        #region constructors
        public IndexedStack(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), TextDirection textDirection = default(TextDirection), FlutterSDK.Rendering.Stack.StackFit sizing = default(FlutterSDK.Rendering.Stack.StackFit), int index = 0, List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, alignment: alignment, textDirection: textDirection, fit: sizing, children: children)
        {
            this.Index = index; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int Index { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Stack.RenderIndexedStack CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Stack.RenderIndexedStack renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class Positioned : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.Stack.StackParentData>
    {
        #region constructors
        public Positioned(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double left = default(double), double top = default(double), double right = default(double), double bottom = default(double), double width = default(double), double height = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
            this.Width = width;
            this.Height = height; throw new NotImplementedException();
        }
        public static Positioned FromRect(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterBinding.UI.Rect rect = default(FlutterBinding.UI.Rect), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Positioned(key: key, child: child); throw new NotImplementedException();
        }
        public static Positioned FromRelativeRect(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Stack.RelativeRect rect = default(FlutterSDK.Rendering.Stack.RelativeRect), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Positioned(key: key, child: child); throw new NotImplementedException();
        }
        public static Positioned Fill(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Positioned(key: key, child: child); instance.Left = left;
            instance.Top = top;
            instance.Right = right;
            instance.Bottom = bottom; throw new NotImplementedException();
        }
        public static Positioned Directional(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), TextDirection textDirection = default(TextDirection), double start = default(double), double top = default(double), double end = default(double), double bottom = default(double), double width = default(double), double height = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            var instance = new Positioned(); throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Left { get; set; }
        public virtual double Top { get; set; }
        public virtual double Right { get; set; }
        public virtual double Bottom { get; set; }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class PositionedDirectional : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public PositionedDirectional(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), double start = default(double), double top = default(double), double end = default(double), double bottom = default(double), double width = default(double), double height = default(double), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Start = start;
            this.Top = top;
            this.End = end;
            this.Bottom = bottom;
            this.Width = width;
            this.Height = height;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual double Start { get; set; }
        public virtual double Top { get; set; }
        public virtual double End { get; set; }
        public virtual double Bottom { get; set; }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class Flex : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public Flex(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis direction = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), TextBaseline textBaseline = default(TextBaseline), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.Direction = direction;
            this.MainAxisAlignment = mainAxisAlignment;
            this.MainAxisSize = mainAxisSize;
            this.CrossAxisAlignment = crossAxisAlignment;
            this.TextDirection = textDirection;
            this.VerticalDirection = verticalDirection;
            this.TextBaseline = textBaseline; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Basictypes.Axis Direction { get; set; }
        public virtual FlutterSDK.Rendering.Flex.MainAxisAlignment MainAxisAlignment { get; set; }
        public virtual FlutterSDK.Rendering.Flex.MainAxisSize MainAxisSize { get; set; }
        public virtual FlutterSDK.Rendering.Flex.CrossAxisAlignment CrossAxisAlignment { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.VerticalDirection VerticalDirection { get; set; }
        public virtual TextBaseline TextBaseline { get; set; }
        internal virtual bool _NeedTextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual TextDirection GetEffectiveTextDirection(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Flex.RenderFlex CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Flex.RenderFlex renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class Row : FlutterSDK.Widgets.Basic.Flex
    {
        #region constructors
        public Row(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), TextBaseline textBaseline = default(TextBaseline), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(children: children, key: key, direction: Axis.Horizontal, mainAxisAlignment: mainAxisAlignment, mainAxisSize: mainAxisSize, crossAxisAlignment: crossAxisAlignment, textDirection: textDirection, verticalDirection: verticalDirection, textBaseline: textBaseline)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    public class Column : FlutterSDK.Widgets.Basic.Flex
    {
        #region constructors
        public Column(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Flex.MainAxisAlignment mainAxisAlignment = default(FlutterSDK.Rendering.Flex.MainAxisAlignment), FlutterSDK.Rendering.Flex.MainAxisSize mainAxisSize = default(FlutterSDK.Rendering.Flex.MainAxisSize), FlutterSDK.Rendering.Flex.CrossAxisAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Flex.CrossAxisAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), TextBaseline textBaseline = default(TextBaseline), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(children: children, key: key, direction: Axis.Vertical, mainAxisAlignment: mainAxisAlignment, mainAxisSize: mainAxisSize, crossAxisAlignment: crossAxisAlignment, textDirection: textDirection, verticalDirection: verticalDirection, textBaseline: textBaseline)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    public class Flexible : FlutterSDK.Widgets.Framework.ParentDataWidget<FlutterSDK.Rendering.Flex.FlexParentData>
    {
        #region constructors
        public Flexible(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int flex = 1, FlutterSDK.Rendering.Flex.FlexFit fit = default(FlutterSDK.Rendering.Flex.FlexFit), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Flex = flex;
            this.Fit = fit; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int Flex { get; set; }
        public virtual FlutterSDK.Rendering.Flex.FlexFit Fit { get; set; }
        public virtual Type DebugTypicalAncestorWidgetClass { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void ApplyParentData(FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class Expanded : FlutterSDK.Widgets.Basic.Flexible
    {
        #region constructors
        public Expanded(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int flex = 1, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, flex: flex, fit: FlexFit.Tight, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    public class Wrap : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public Wrap(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Basictypes.Axis direction = default(FlutterSDK.Painting.Basictypes.Axis), FlutterSDK.Rendering.Wrap.WrapAlignment alignment = default(FlutterSDK.Rendering.Wrap.WrapAlignment), double spacing = 0.0, FlutterSDK.Rendering.Wrap.WrapAlignment runAlignment = default(FlutterSDK.Rendering.Wrap.WrapAlignment), double runSpacing = 0.0, FlutterSDK.Rendering.Wrap.WrapCrossAlignment crossAxisAlignment = default(FlutterSDK.Rendering.Wrap.WrapCrossAlignment), TextDirection textDirection = default(TextDirection), FlutterSDK.Painting.Basictypes.VerticalDirection verticalDirection = default(FlutterSDK.Painting.Basictypes.VerticalDirection), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: children)
        {
            this.Direction = direction;
            this.Alignment = alignment;
            this.Spacing = spacing;
            this.RunAlignment = runAlignment;
            this.RunSpacing = runSpacing;
            this.CrossAxisAlignment = crossAxisAlignment;
            this.TextDirection = textDirection;
            this.VerticalDirection = verticalDirection; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Basictypes.Axis Direction { get; set; }
        public virtual FlutterSDK.Rendering.Wrap.WrapAlignment Alignment { get; set; }
        public virtual double Spacing { get; set; }
        public virtual FlutterSDK.Rendering.Wrap.WrapAlignment RunAlignment { get; set; }
        public virtual double RunSpacing { get; set; }
        public virtual FlutterSDK.Rendering.Wrap.WrapCrossAlignment CrossAxisAlignment { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.VerticalDirection VerticalDirection { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Wrap.RenderWrap CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Wrap.RenderWrap renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class Flow : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public Flow(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Flow.FlowDelegate @delegate = default(FlutterSDK.Rendering.Flow.FlowDelegate), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        : base(key: key, children: BasicDefaultClass.RepaintBoundary.WrapAll(children))
        {
            this.@delegate = @delegate; throw new NotImplementedException();
        }
        public static Flow Unwrapped(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Flow.FlowDelegate @delegate = default(FlutterSDK.Rendering.Flow.FlowDelegate), List<FlutterSDK.Widgets.Framework.Widget> children = default(List<FlutterSDK.Widgets.Framework.Widget>))
        {
            var instance = new Flow(key: key, children: children); instance.@delegate = @delegate; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Flow.FlowDelegate @delegate { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Flow.RenderFlow CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Flow.RenderFlow renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class RichText : FlutterSDK.Widgets.Framework.MultiChildRenderObjectWidget
    {
        #region constructors
        public RichText(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Painting.Inlinespan.InlineSpan text = default(FlutterSDK.Painting.Inlinespan.InlineSpan), TextAlign textAlign = default(TextAlign), TextDirection textDirection = default(TextDirection), bool softWrap = true, FlutterSDK.Rendering.Paragraph.TextOverflow overflow = default(FlutterSDK.Rendering.Paragraph.TextOverflow), double textScaleFactor = 1.0, int maxLines = default(int), Locale locale = default(Locale), FlutterSDK.Painting.Strutstyle.StrutStyle strutStyle = default(FlutterSDK.Painting.Strutstyle.StrutStyle), FlutterSDK.Painting.Textpainter.TextWidthBasis textWidthBasis = default(FlutterSDK.Painting.Textpainter.TextWidthBasis), TextHeightBehavior textHeightBehavior = default(TextHeightBehavior))
        : base(key: key, children: _ExtractChildren(text))
        {
            this.Text = text;
            this.TextAlign = textAlign;
            this.TextDirection = textDirection;
            this.SoftWrap = softWrap;
            this.Overflow = overflow;
            this.TextScaleFactor = textScaleFactor;
            this.MaxLines = maxLines;
            this.Locale = locale;
            this.StrutStyle = strutStyle;
            this.TextWidthBasis = textWidthBasis;
            this.TextHeightBehavior = textHeightBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Painting.Inlinespan.InlineSpan Text { get; set; }
        public virtual TextAlign TextAlign { get; set; }
        public virtual TextDirection TextDirection { get; set; }
        public virtual bool SoftWrap { get; set; }
        public virtual FlutterSDK.Rendering.Paragraph.TextOverflow Overflow { get; set; }
        public virtual double TextScaleFactor { get; set; }
        public virtual int MaxLines { get; set; }
        public virtual Locale Locale { get; set; }
        public virtual FlutterSDK.Painting.Strutstyle.StrutStyle StrutStyle { get; set; }
        public virtual FlutterSDK.Painting.Textpainter.TextWidthBasis TextWidthBasis { get; set; }
        public virtual TextHeightBehavior TextHeightBehavior { get; set; }
        #endregion

        #region methods

        private List<FlutterSDK.Widgets.Framework.Widget> _ExtractChildren(FlutterSDK.Painting.Inlinespan.InlineSpan span) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Paragraph.RenderParagraph CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Paragraph.RenderParagraph renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class RawImage : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public RawImage(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), SKImage image = default(SKImage), double width = default(double), double height = default(double), double scale = 1.0, FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterBinding.UI.BlendMode colorBlendMode = default(FlutterBinding.UI.BlendMode), FlutterSDK.Painting.Boxfit.BoxFit fit = default(FlutterSDK.Painting.Boxfit.BoxFit), FlutterSDK.Painting.Alignment.AlignmentGeometry alignment = default(FlutterSDK.Painting.Alignment.AlignmentGeometry), FlutterSDK.Painting.Decorationimage.ImageRepeat repeat = default(FlutterSDK.Painting.Decorationimage.ImageRepeat), FlutterBinding.UI.Rect centerSlice = default(FlutterBinding.UI.Rect), bool matchTextDirection = false, bool invertColors = false, FilterQuality filterQuality = default(FilterQuality))
        : base(key: key)
        {
            this.Image = image;
            this.Width = width;
            this.Height = height;
            this.Scale = scale;
            this.Color = color;
            this.ColorBlendMode = colorBlendMode;
            this.Fit = fit;
            this.Alignment = alignment;
            this.Repeat = repeat;
            this.CenterSlice = centerSlice;
            this.MatchTextDirection = matchTextDirection;
            this.InvertColors = invertColors;
            this.FilterQuality = filterQuality; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual SKImage Image { get; set; }
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public virtual double Scale { get; set; }
        public virtual FlutterBinding.UI.Color Color { get; set; }
        public virtual FilterQuality FilterQuality { get; set; }
        public virtual FlutterBinding.UI.BlendMode ColorBlendMode { get; set; }
        public virtual FlutterSDK.Painting.Boxfit.BoxFit Fit { get; set; }
        public virtual FlutterSDK.Painting.Alignment.AlignmentGeometry Alignment { get; set; }
        public virtual FlutterSDK.Painting.Decorationimage.ImageRepeat Repeat { get; set; }
        public virtual FlutterBinding.UI.Rect CenterSlice { get; set; }
        public virtual bool MatchTextDirection { get; set; }
        public virtual bool InvertColors { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Image.RenderImage CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Image.RenderImage renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class DefaultAssetBundle : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public DefaultAssetBundle(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Assetbundle.AssetBundle bundle = default(FlutterSDK.Services.Assetbundle.AssetBundle), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Bundle = bundle; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Services.Assetbundle.AssetBundle Bundle { get; set; }
        #endregion

        #region methods

        public virtual FlutterSDK.Services.Assetbundle.AssetBundle Of(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Basic.DefaultAssetBundle oldWidget) { throw new NotImplementedException(); }
        public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget) { throw new NotImplementedException(); }

        #endregion
    }


    public class WidgetToRenderBoxAdapter : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public WidgetToRenderBoxAdapter(FlutterSDK.Rendering.Box.RenderBox renderBox = default(FlutterSDK.Rendering.Box.RenderBox), VoidCallback onBuild = default(VoidCallback))
        : base(key: new GlobalObjectKey(renderBox))
        {
            this.RenderBox = renderBox;
            this.OnBuild = onBuild; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Box.RenderBox RenderBox { get; set; }
        public virtual VoidCallback OnBuild { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Box.RenderBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Box.RenderBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class Listener : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public Listener(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.PointerDownEventListener onPointerDown = default(FlutterSDK.Rendering.Proxybox.PointerDownEventListener), FlutterSDK.Rendering.Proxybox.PointerMoveEventListener onPointerMove = default(FlutterSDK.Rendering.Proxybox.PointerMoveEventListener), FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener onPointerEnter = default(FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener), FlutterSDK.Rendering.Mousetracking.PointerExitEventListener onPointerExit = default(FlutterSDK.Rendering.Mousetracking.PointerExitEventListener), FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener onPointerHover = default(FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener), FlutterSDK.Rendering.Proxybox.PointerUpEventListener onPointerUp = default(FlutterSDK.Rendering.Proxybox.PointerUpEventListener), FlutterSDK.Rendering.Proxybox.PointerCancelEventListener onPointerCancel = default(FlutterSDK.Rendering.Proxybox.PointerCancelEventListener), FlutterSDK.Rendering.Proxybox.PointerSignalEventListener onPointerSignal = default(FlutterSDK.Rendering.Proxybox.PointerSignalEventListener), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.OnPointerDown = onPointerDown;
            this.OnPointerMove = onPointerMove;
            this.OnPointerEnter = onPointerEnter;
            this.OnPointerExit = onPointerExit;
            this.OnPointerHover = onPointerHover;
            this.OnPointerUp = onPointerUp;
            this.OnPointerCancel = onPointerCancel;
            this.OnPointerSignal = onPointerSignal;
            this.Behavior = behavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.PointerDownEventListener OnPointerDown { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerMoveEventListener OnPointerMove { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener OnPointerEnter { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener OnPointerHover { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener OnPointerExit { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerUpEventListener OnPointerUp { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerCancelEventListener OnPointerCancel { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerSignalEventListener OnPointerSignal { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.Widget _Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _PointerListener : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public _PointerListener(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.PointerDownEventListener onPointerDown = default(FlutterSDK.Rendering.Proxybox.PointerDownEventListener), FlutterSDK.Rendering.Proxybox.PointerMoveEventListener onPointerMove = default(FlutterSDK.Rendering.Proxybox.PointerMoveEventListener), FlutterSDK.Rendering.Proxybox.PointerUpEventListener onPointerUp = default(FlutterSDK.Rendering.Proxybox.PointerUpEventListener), FlutterSDK.Rendering.Proxybox.PointerCancelEventListener onPointerCancel = default(FlutterSDK.Rendering.Proxybox.PointerCancelEventListener), FlutterSDK.Rendering.Proxybox.PointerSignalEventListener onPointerSignal = default(FlutterSDK.Rendering.Proxybox.PointerSignalEventListener), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.OnPointerDown = onPointerDown;
            this.OnPointerMove = onPointerMove;
            this.OnPointerUp = onPointerUp;
            this.OnPointerCancel = onPointerCancel;
            this.OnPointerSignal = onPointerSignal;
            this.Behavior = behavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Proxybox.PointerDownEventListener OnPointerDown { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerMoveEventListener OnPointerMove { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerUpEventListener OnPointerUp { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerCancelEventListener OnPointerCancel { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.PointerSignalEventListener OnPointerSignal { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderPointerListener CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderPointerListener renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class MouseRegion : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public MouseRegion(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener onEnter = default(FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener), FlutterSDK.Rendering.Mousetracking.PointerExitEventListener onExit = default(FlutterSDK.Rendering.Mousetracking.PointerExitEventListener), FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener onHover = default(FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener), bool opaque = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.OnEnter = onEnter;
            this.OnExit = onExit;
            this.OnHover = onHover;
            this.Opaque = opaque;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Mousetracking.PointerEnterEventListener OnEnter { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.PointerHoverEventListener OnHover { get; set; }
        public virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener OnExit { get; set; }
        public virtual bool Opaque { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Basic._MouseRegionState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _MouseRegionState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Basic.MouseRegion>
    {
        #region constructors
        public _MouseRegionState()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual void HandleExit(FlutterSDK.Gestures.Events.PointerExitEvent @event) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Rendering.Mousetracking.PointerExitEventListener GetHandleExit() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RawMouseRegion : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public _RawMouseRegion(FlutterSDK.Widgets.Basic._MouseRegionState owner)
        : base(child: owner.Widget.Child)
        {
            this.Owner = owner; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Basic._MouseRegionState Owner { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderMouseRegion CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderMouseRegion renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class RepaintBoundary : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public RepaintBoundary(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        public static RepaintBoundary Wrap(FlutterSDK.Widgets.Framework.Widget child, int childIndex)
        {
            var instance = new RepaintBoundary(); throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual List<FlutterSDK.Widgets.Basic.RepaintBoundary> WrapAll(List<FlutterSDK.Widgets.Framework.Widget> widgets) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.Proxybox.RenderRepaintBoundary CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class IgnorePointer : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public IgnorePointer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool ignoring = true, bool ignoringSemantics = default(bool), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Ignoring = ignoring;
            this.IgnoringSemantics = ignoringSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Ignoring { get; set; }
        public virtual bool IgnoringSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderIgnorePointer CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderIgnorePointer renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class AbsorbPointer : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public AbsorbPointer(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool absorbing = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool ignoringSemantics = default(bool))
        : base(key: key, child: child)
        {
            this.Absorbing = absorbing;
            this.IgnoringSemantics = ignoringSemantics; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Absorbing { get; set; }
        public virtual bool IgnoringSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderAbsorbPointer CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderAbsorbPointer renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class MetaData : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public MetaData(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), object metaData = default(object), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.MetaDataValue = metaData;
            this.Behavior = behavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual object MetaDataValue { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderMetaData CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderMetaData renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class Semantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public Semantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool container = false, bool explicitChildNodes = false, bool excludeSemantics = false, bool enabled = default(bool), bool @checked = default(bool), bool selected = default(bool), bool toggled = default(bool), bool button = default(bool), bool link = default(bool), bool header = default(bool), bool textField = default(bool), bool readOnly = default(bool), bool focusable = default(bool), bool focused = default(bool), bool inMutuallyExclusiveGroup = default(bool), bool obscured = default(bool), bool multiline = default(bool), bool scopesRoute = default(bool), bool namesRoute = default(bool), bool hidden = default(bool), bool image = default(bool), bool liveRegion = default(bool), int maxValueLength = default(int), int currentValueLength = default(int), string label = default(string), string value = default(string), string increasedValue = default(string), string decreasedValue = default(string), string hint = default(string), string onTapHint = default(string), string onLongPressHint = default(string), TextDirection textDirection = default(TextDirection), FlutterSDK.Semantics.Semantics.SemanticsSortKey sortKey = default(FlutterSDK.Semantics.Semantics.SemanticsSortKey), VoidCallback onTap = default(VoidCallback), VoidCallback onLongPress = default(VoidCallback), VoidCallback onScrollLeft = default(VoidCallback), VoidCallback onScrollRight = default(VoidCallback), VoidCallback onScrollUp = default(VoidCallback), VoidCallback onScrollDown = default(VoidCallback), VoidCallback onIncrease = default(VoidCallback), VoidCallback onDecrease = default(VoidCallback), VoidCallback onCopy = default(VoidCallback), VoidCallback onCut = default(VoidCallback), VoidCallback onPaste = default(VoidCallback), VoidCallback onDismiss = default(VoidCallback), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorForwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.MoveCursorHandler onMoveCursorBackwardByCharacter = default(FlutterSDK.Semantics.Semantics.MoveCursorHandler), FlutterSDK.Semantics.Semantics.SetSelectionHandler onSetSelection = default(FlutterSDK.Semantics.Semantics.SetSelectionHandler), VoidCallback onDidGainAccessibilityFocus = default(VoidCallback), VoidCallback onDidLoseAccessibilityFocus = default(VoidCallback), Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object> customSemanticsActions = default(Dictionary<FlutterSDK.Semantics.Semantics.CustomSemanticsAction, object>))
        : base()
        {
            throw new NotImplementedException();
        }
        public static Semantics FromProperties(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), bool container = false, bool explicitChildNodes = false, bool excludeSemantics = false, FlutterSDK.Semantics.Semantics.SemanticsProperties properties = default(FlutterSDK.Semantics.Semantics.SemanticsProperties))
        {
            var instance = new Semantics(key: key, child: child); instance.Container = container;
            instance.ExplicitChildNodes = explicitChildNodes;
            instance.ExcludeSemantics = excludeSemantics;
            instance.Properties = properties; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Semantics.Semantics.SemanticsProperties Properties { get; set; }
        public virtual bool Container { get; set; }
        public virtual bool ExplicitChildNodes { get; set; }
        public virtual bool ExcludeSemantics { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderSemanticsAnnotations CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        private TextDirection _GetTextDirection(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderSemanticsAnnotations renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class MergeSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public MergeSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderMergeSemantics CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class BlockSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public BlockSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool blocking = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Blocking = blocking; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Blocking { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderBlockSemantics CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderBlockSemantics renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class ExcludeSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ExcludeSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool excluding = true, FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Excluding = excluding; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Excluding { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderExcludeSemantics CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderExcludeSemantics renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class IndexedSemantics : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public IndexedSemantics(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), int index = default(int), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {
            this.Index = index; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual int Index { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.Proxybox.RenderIndexedSemantics CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.Proxybox.RenderIndexedSemantics renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class KeyedSubtree : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public KeyedSubtree(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.Child = child; throw new NotImplementedException();
        }
        public static KeyedSubtree Wrap(FlutterSDK.Widgets.Framework.Widget child, int childIndex)
        {
            var instance = new KeyedSubtree(); throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public virtual List<FlutterSDK.Widgets.Framework.Widget> EnsureUniqueKeysForList(List<FlutterSDK.Widgets.Framework.Widget> items, int baseIndex = 0) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class Builder : FlutterSDK.Widgets.Framework.StatelessWidget
    {
        #region constructors
        public Builder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.WidgetBuilder builder = default(FlutterSDK.Widgets.Framework.WidgetBuilder))
        : base(key: key)
        {
            this.BuilderValue = builder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.WidgetBuilder BuilderValue { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class StatefulBuilder : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public StatefulBuilder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Basic.StatefulWidgetBuilder builder = default(FlutterSDK.Widgets.Basic.StatefulWidgetBuilder))
        : base(key: key)
        {
            this.Builder = builder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Basic.StatefulWidgetBuilder Builder { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Basic._StatefulBuilderState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _StatefulBuilderState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Basic.StatefulBuilder>
    {
        #region constructors
        public _StatefulBuilderState()
        { }
        #endregion

        #region fields
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class ColoredBox : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public ColoredBox(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key))
        : base(key: key, child: child)
        {
            this.Color = color; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterBinding.UI.Color Color { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Basic._RenderColoredBox CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Basic._RenderColoredBox renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderColoredBox : FlutterSDK.Rendering.Proxybox.RenderProxyBoxWithHitTestBehavior
    {
        #region constructors
        public _RenderColoredBox(FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color))
        : base(behavior: HitTestBehavior.Opaque)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterBinding.UI.Color _Color { get; set; }
        public virtual FlutterBinding.UI.Color Color { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }

        #endregion
    }

}
