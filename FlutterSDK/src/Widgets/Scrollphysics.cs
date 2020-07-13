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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/scheduler.dart;
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
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Routenotificationmessages;
namespace FlutterSDK.Widgets.Scrollphysics
{
    internal static class ScrollphysicsDefaultClass
    {
    }

    /// <Summary>
    /// Determines the physics of a [Scrollable] widget.
    ///
    /// For example, determines how the [Scrollable] will behave when the user
    /// reaches the maximum scroll extent or when the user stops scrolling.
    ///
    /// When starting a physics [Simulation], the current scroll position and
    /// velocity are used as the initial conditions for the particle in the
    /// simulation. The movement of the particle in the simulation is then used to
    /// determine the scroll position for the widget.
    ///
    /// Instead of creating your own subclasses, [parent] can be used to combine
    /// [ScrollPhysics] objects of different types to get the desired scroll physics.
    /// </Summary>
    public class ScrollPhysics
    {
        #region constructors
        public ScrollPhysics(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics parent = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
    
}
    #endregion

    #region fields
    public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Parent { get; set; }
    internal virtual FlutterSDK.Physics.Springsimulation.SpringDescription _KDefaultSpring { get; set; }
    internal virtual FlutterSDK.Physics.Tolerance.Tolerance _KDefaultTolerance { get; set; }
    public virtual FlutterSDK.Physics.Springsimulation.SpringDescription Spring { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Physics.Tolerance.Tolerance Tolerance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double MinFlingDistance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double MinFlingVelocity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double MaxFlingVelocity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual double DragStartDistanceMotionThreshold { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool AllowImplicitScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// If [parent] is null then return ancestor, otherwise recursively build a
    /// ScrollPhysics that has [ancestor] as its parent.
    ///
    /// This method is typically used to define [applyTo] methods like:
    ///
    /// ```dart
    /// FooScrollPhysics applyTo(ScrollPhysics ancestor) {
    ///   return FooScrollPhysics(parent: buildParent(ancestor));
    /// }
    /// ```
    /// </Summary>
    public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics BuildParent(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ancestor) => Parent?.ApplyTo(ancestor) ?? ancestor;



    /// <Summary>
    /// If [parent] is null then return a [ScrollPhysics] with the same
    /// [runtimeType] where the [parent] has been replaced with the [ancestor].
    ///
    /// If this scroll physics object already has a parent, then this method
    /// is applied recursively and ancestor will appear at the end of the
    /// existing chain of parents.
    ///
    /// The returned object will combine some of the behaviors from this
    /// [ScrollPhysics] instance and some of the behaviors from [ancestor].
    ///
    /// {@tool snippet}
    ///
    /// In the following example, the [applyTo] method is used to combine the
    /// scroll physics of two [ScrollPhysics] objects, the resulting [ScrollPhysics]
    /// `x` has the same behavior as `y`:
    ///
    /// ```dart
    /// final FooScrollPhysics x = FooScrollPhysics().applyTo(BarScrollPhysics());
    /// const FooScrollPhysics y = FooScrollPhysics(parent: BarScrollPhysics());
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [buildParent], a utility method that's often used to define [applyTo]
    ///    methods for ScrollPhysics subclasses.
    /// </Summary>
    public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ApplyTo(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ancestor)
    {
        return new ScrollPhysics(parent: BuildParent(ancestor));
    }




    /// <Summary>
    /// Used by [DragScrollActivity] and other user-driven activities to convert
    /// an offset in logical pixels as provided by the [DragUpdateDetails] into a
    /// delta to apply (subtract from the current position) using
    /// [ScrollActivityDelegate.setPixels].
    ///
    /// This is used by some [ScrollPosition] subclasses to apply friction during
    /// overscroll situations.
    ///
    /// This method must not adjust parts of the offset that are entirely within
    /// the bounds described by the given `position`.
    ///
    /// The given `position` is only valid during this method call. Do not keep a
    /// reference to it to use later, as the values may update, may not update, or
    /// may update to reflect an entirely unrelated scrollable.
    /// </Summary>
    public virtual double ApplyPhysicsToUserOffset(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double offset)
    {
        if (Parent == null) return offset;
        return Parent.ApplyPhysicsToUserOffset(position, offset);
    }




    /// <Summary>
    /// Whether the scrollable should let the user adjust the scroll offset, for
    /// example by dragging.
    ///
    /// By default, the user can manipulate the scroll offset if, and only if,
    /// there is actually content outside the viewport to reveal.
    ///
    /// The given `position` is only valid during this method call. Do not keep a
    /// reference to it to use later, as the values may update, may not update, or
    /// may update to reflect an entirely unrelated scrollable.
    /// </Summary>
    public virtual bool ShouldAcceptUserOffset(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position)
    {
        if (Parent == null) return position.Pixels != 0.0 || position.MinScrollExtent != position.MaxScrollExtent;
        return Parent.ShouldAcceptUserOffset(position);
    }




    /// <Summary>
    /// Provides a heuristic to determine if expensive frame-bound tasks should be
    /// deferred.
    ///
    /// The velocity parameter must not be null, but may be positive, negative, or
    /// zero.
    ///
    /// The metrics parameter must not be null.
    ///
    /// The context parameter must not be null. It normally refers to the
    /// [BuildContext] of the widget making the call, such as an [Image] widget
    /// in a [ListView].
    ///
    /// This can be used to determine whether decoding or fetching complex data
    /// for the currently visible part of the viewport should be delayed
    /// to avoid doing work that will not have a chance to appear before a new
    /// frame is rendered.
    ///
    /// For example, a list of images could use this logic to delay decoding
    /// images until scrolling is slow enough to actually render the decoded
    /// image to the screen.
    ///
    /// The default implementation is a heuristic that compares the current
    /// scroll velocity in local logical pixels to the longest side of the window
    /// in physical pixels. Implementers can change this heuristic by overriding
    /// this method and providing their custom physics to the scrollable widget.
    /// For example, an application that changes the local coordinate system with
    /// a large perspective transform could provide a more or less aggressive
    /// heuristic depending on whether the transform was increasing or decreasing
    /// the overall scale between the global screen and local scrollable
    /// coordinate systems.
    ///
    /// The default implementation is stateless, and simply provides a point-in-
    /// time decision about how fast the scrollable is scrolling. It would always
    /// return true for a scrollable that is animating back and forth at high
    /// velocity in a loop. It is assumed that callers will handle such
    /// a case, or that a custom stateful implementation would be written that
    /// tracks the sign of the velocity on successive calls.
    ///
    /// Returning true from this method indicates that the current scroll velocity
    /// is great enough that expensive operations impacting the UI should be
    /// deferred.
    /// </Summary>
    public virtual bool RecommendDeferredLoading(double velocity, FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics metrics, FlutterSDK.Widgets.Framework.BuildContext context)
    {



        if (Parent == null)
        {
            double maxPhysicalPixels = BindingDefaultClass.WidgetsBinding.Instance.Window.PhysicalSize.LongestSide;
            return velocity.Abs() > maxPhysicalPixels;
        }

        return Parent.RecommendDeferredLoading(velocity, metrics, context);
    }




    /// <Summary>
    /// Determines the overscroll by applying the boundary conditions.
    ///
    /// Called by [ScrollPosition.applyBoundaryConditions], which is called by
    /// [ScrollPosition.setPixels] just before the [ScrollPosition.pixels] value
    /// is updated, to determine how much of the offset is to be clamped off and
    /// sent to [ScrollPosition.didOverscrollBy].
    ///
    /// The `value` argument is guaranteed to not equal the [ScrollMetrics.pixels]
    /// of the `position` argument when this is called.
    ///
    /// It is possible for this method to be called when the `position` describes
    /// an already-out-of-bounds position. In that case, the boundary conditions
    /// should usually only prevent a further increase in the extent to which the
    /// position is out of bounds, allowing a decrease to be applied successfully,
    /// so that (for instance) an animation can smoothly snap an out of bounds
    /// position to the bounds. See [BallisticScrollActivity].
    ///
    /// This method must not clamp parts of the offset that are entirely within
    /// the bounds described by the given `position`.
    ///
    /// The given `position` is only valid during this method call. Do not keep a
    /// reference to it to use later, as the values may update, may not update, or
    /// may update to reflect an entirely unrelated scrollable.
    ///
    /// ## Examples
    ///
    /// [BouncingScrollPhysics] returns zero. In other words, it allows scrolling
    /// past the boundary unhindered.
    ///
    /// [ClampingScrollPhysics] returns the amount by which the value is beyond
    /// the position or the boundary, whichever is furthest from the content. In
    /// other words, it disallows scrolling past the boundary, but allows
    /// scrolling back from being overscrolled, if for some reason the position
    /// ends up overscrolled.
    /// </Summary>
    public virtual double ApplyBoundaryConditions(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double value)
    {
        if (Parent == null) return 0.0;
        return Parent.ApplyBoundaryConditions(position, value);
    }




    /// <Summary>
    /// Returns a simulation for ballistic scrolling starting from the given
    /// position with the given velocity.
    ///
    /// This is used by [ScrollPositionWithSingleContext] in the
    /// [ScrollPositionWithSingleContext.goBallistic] method. If the result
    /// is non-null, [ScrollPositionWithSingleContext] will begin a
    /// [BallisticScrollActivity] with the returned value. Otherwise, it will
    /// begin an idle activity instead.
    ///
    /// The given `position` is only valid during this method call. Do not keep a
    /// reference to it to use later, as the values may update, may not update, or
    /// may update to reflect an entirely unrelated scrollable.
    /// </Summary>
    public virtual FlutterSDK.Physics.Simulation.Simulation CreateBallisticSimulation(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double velocity)
    {
        if (Parent == null) return null;
        return Parent.CreateBallisticSimulation(position, velocity);
    }




    /// <Summary>
    /// Returns the velocity carried on repeated flings.
    ///
    /// The function is applied to the existing scroll velocity when another
    /// scroll drag is applied in the same direction.
    ///
    /// By default, physics for platforms other than iOS doesn't carry momentum.
    /// </Summary>
    public virtual double CarriedMomentum(double existingVelocity)
    {
        if (Parent == null) return 0.0;
        return Parent.CarriedMomentum(existingVelocity);
    }




    #endregion
}


/// <Summary>
/// Scroll physics for environments that allow the scroll offset to go beyond
/// the bounds of the content, but then bounce the content back to the edge of
/// those bounds.
///
/// This is the behavior typically seen on iOS.
///
/// See also:
///
///  * [ScrollConfiguration], which uses this to provide the default
///    scroll behavior on iOS.
///  * [ClampingScrollPhysics], which is the analogous physics for Android's
///    clamping behavior.
/// </Summary>
public class BouncingScrollPhysics : FlutterSDK.Widgets.Scrollphysics.ScrollPhysics
{
    #region constructors
    public BouncingScrollPhysics(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics parent = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
    : base(parent: parent)

}
#endregion

#region fields
public virtual double MinFlingVelocity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual double DragStartDistanceMotionThreshold { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new FlutterSDK.Widgets.Scrollphysics.BouncingScrollPhysics ApplyTo(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ancestor)
{
    return new BouncingScrollPhysics(parent: BuildParent(ancestor));
}




/// <Summary>
/// The multiple applied to overscroll to make it appear that scrolling past
/// the edge of the scrollable contents is harder than scrolling the list.
/// This is done by reducing the ratio of the scroll effect output vs the
/// scroll gesture input.
///
/// This factor starts at 0.52 and progressively becomes harder to overscroll
/// as more of the area past the edge is dragged in (represented by an increasing
/// `overscrollFraction` which starts at 0 when there is no overscroll).
/// </Summary>
public virtual double FrictionFactor(double overscrollFraction) => 0.52 * Math.Dart:mathDefaultClass.Pow(1 - overscrollFraction, 2);



public new double ApplyPhysicsToUserOffset(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double offset)
{


    if (!position.OutOfRange) return offset;
    double overscrollPastStart = Math.Dart:mathDefaultClass.Max(position.MinScrollExtent - position.Pixels, 0.0);
    double overscrollPastEnd = Math.Dart:mathDefaultClass.Max(position.Pixels - position.MaxScrollExtent, 0.0);
    double overscrollPast = Math.Dart:mathDefaultClass.Max(overscrollPastStart, overscrollPastEnd);
    bool easing = (overscrollPastStart > 0.0 && offset < 0.0) || (overscrollPastEnd > 0.0 && offset > 0.0);
    double friction = easing ? FrictionFactor((overscrollPast - offset.Abs()) / position.ViewportDimension) : FrictionFactor(overscrollPast / position.ViewportDimension);
    double direction = offset.Sign;
    return direction * _ApplyFriction(overscrollPast, offset.Abs(), friction);
}




private double _ApplyFriction(double extentOutside, double absDelta, double gamma)
{

    double total = 0.0;
    if (extentOutside > 0)
    {
        double deltaToLimit = extentOutside / gamma;
        if (absDelta < deltaToLimit) return absDelta * gamma;
        total += extentOutside;
        absDelta -= deltaToLimit;
    }

    return total + absDelta;
}




public new double ApplyBoundaryConditions(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double value) => 0.0;



public new FlutterSDK.Physics.Simulation.Simulation CreateBallisticSimulation(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double velocity)
{
    Tolerance tolerance = this.Tolerance;
    if (velocity.Abs() >= tolerance.Velocity || position.OutOfRange)
    {
        return new BouncingScrollSimulation(spring: Spring, position: position.Pixels, velocity: velocity * 0.91, leadingExtent: position.MinScrollExtent, trailingExtent: position.MaxScrollExtent, tolerance: tolerance);
    }

    return null;
}




/// <Summary>
/// Momentum build-up function that mimics iOS's scroll speed increase with repeated flings.
///
/// The velocity of the last fling is not an important factor. Existing speed
/// and (related) time since last fling are factors for the velocity transfer
/// calculations.
/// </Summary>
public new double CarriedMomentum(double existingVelocity)
{
    return existingVelocity.Sign * Math.Dart:mathDefaultClass.Min(0.000816 * Math.Dart:mathDefaultClass.Pow(existingVelocity.Abs(), 1.967).ToDouble(), 40000.0);
}



#endregion
}


/// <Summary>
/// Scroll physics for environments that prevent the scroll offset from reaching
/// beyond the bounds of the content.
///
/// This is the behavior typically seen on Android.
///
/// See also:
///
///  * [ScrollConfiguration], which uses this to provide the default
///    scroll behavior on Android.
///  * [BouncingScrollPhysics], which is the analogous physics for iOS' bouncing
///    behavior.
///  * [GlowingOverscrollIndicator], which is used by [ScrollConfiguration] to
///    provide the glowing effect that is usually found with this clamping effect
///    on Android. When using a [MaterialApp], the [GlowingOverscrollIndicator]'s
///    glow color is specified to use [ThemeData.accentColor].
/// </Summary>
public class ClampingScrollPhysics : FlutterSDK.Widgets.Scrollphysics.ScrollPhysics
{
    #region constructors
    public ClampingScrollPhysics(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics parent = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
    : base(parent: parent)

}
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Widgets.Scrollphysics.ClampingScrollPhysics ApplyTo(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ancestor)
{
    return new ClampingScrollPhysics(parent: BuildParent(ancestor));
}




public new double ApplyBoundaryConditions(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double value)
{

    if (value < position.Pixels && position.Pixels <= position.MinScrollExtent) return value - position.Pixels;
    if (position.MaxScrollExtent <= position.Pixels && position.Pixels < value) return value - position.Pixels;
    if (value < position.MinScrollExtent && position.MinScrollExtent < position.Pixels) return value - position.MinScrollExtent;
    if (position.Pixels < position.MaxScrollExtent && position.MaxScrollExtent < value) return value - position.MaxScrollExtent;
    return 0.0;
}




public new FlutterSDK.Physics.Simulation.Simulation CreateBallisticSimulation(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position, double velocity)
{
    Tolerance tolerance = this.Tolerance;
    if (position.OutOfRange)
    {
        double end = default(double);
        if (position.Pixels > position.MaxScrollExtent) end = position.MaxScrollExtent;
        if (position.Pixels < position.MinScrollExtent) end = position.MinScrollExtent;

        return new ScrollSpringSimulation(Spring, position.Pixels, end, Math.Dart:mathDefaultClass.Min(0.0, velocity), tolerance: tolerance);
    }

    if (velocity.Abs() < tolerance.Velocity) return null;
    if (velocity > 0.0 && position.Pixels >= position.MaxScrollExtent) return null;
    if (velocity < 0.0 && position.Pixels <= position.MinScrollExtent) return null;
    return new ClampingScrollSimulation(position: position.Pixels, velocity: velocity, tolerance: tolerance);
}



#endregion
}


/// <Summary>
/// Scroll physics that always lets the user scroll.
///
/// On Android, overscrolls will be clamped by default and result in an
/// overscroll glow. On iOS, overscrolls will load a spring that will return
/// the scroll view to its normal range when released.
///
/// See also:
///
///  * [ScrollPhysics], which can be used instead of this class when the default
///    behavior is desired instead.
///  * [BouncingScrollPhysics], which provides the bouncing overscroll behavior
///    found on iOS.
///  * [ClampingScrollPhysics], which provides the clamping overscroll behavior
///    found on Android.
/// </Summary>
public class AlwaysScrollableScrollPhysics : FlutterSDK.Widgets.Scrollphysics.ScrollPhysics
{
    #region constructors
    public AlwaysScrollableScrollPhysics(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics parent = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
    : base(parent: parent)

}
#endregion

#region fields
#endregion

#region methods

public new FlutterSDK.Widgets.Scrollphysics.AlwaysScrollableScrollPhysics ApplyTo(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ancestor)
{
    return new AlwaysScrollableScrollPhysics(parent: BuildParent(ancestor));
}




public new bool ShouldAcceptUserOffset(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position) => true;


#endregion
}


/// <Summary>
/// Scroll physics that does not allow the user to scroll.
///
/// See also:
///
///  * [ScrollPhysics], which can be used instead of this class when the default
///    behavior is desired instead.
///  * [BouncingScrollPhysics], which provides the bouncing overscroll behavior
///    found on iOS.
///  * [ClampingScrollPhysics], which provides the clamping overscroll behavior
///    found on Android.
/// </Summary>
public class NeverScrollableScrollPhysics : FlutterSDK.Widgets.Scrollphysics.ScrollPhysics
{
    #region constructors
    public NeverScrollableScrollPhysics(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics parent = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics))
    : base(parent: parent)

}
#endregion

#region fields
public virtual bool AllowImplicitScrolling { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new FlutterSDK.Widgets.Scrollphysics.NeverScrollableScrollPhysics ApplyTo(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics ancestor)
{
    return new NeverScrollableScrollPhysics(parent: BuildParent(ancestor));
}




public new bool ShouldAcceptUserOffset(FlutterSDK.Widgets.Scrollmetrics.ScrollMetrics position) => false;


#endregion
}

}
