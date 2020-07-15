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
using FlutterSDK.Widgets.Constants;
namespace FlutterSDK.Widgets.Inheritedmodel
{
    internal static class InheritedmodelDefaultClass
    {
    }

    /// <Summary>
    /// An [InheritedWidget] that's intended to be used as the base class for
    /// models whose dependents may only depend on one part or "aspect" of the
    /// overall model.
    ///
    /// An inherited widget's dependents are unconditionally rebuilt when the
    /// inherited widget changes per [InheritedWidget.updateShouldNotify].
    /// This widget is similar except that dependents aren't rebuilt
    /// unconditionally.
    ///
    /// Widgets that depend on an [InheritedModel] qualify their dependence
    /// with a value that indicates what "aspect" of the model they depend
    /// on. When the model is rebuilt, dependents will also be rebuilt, but
    /// only if there was a change in the model that corresponds to the aspect
    /// they provided.
    ///
    /// The type parameter `T` is the type of the model aspect objects.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=ml5uefGgkaA}
    ///
    /// Widgets create a dependency on an [InheritedModel] with a static method:
    /// [InheritedModel.inheritFrom]. This method's `context` parameter
    /// defines the subtree that will be rebuilt when the model changes.
    /// Typically the `inheritFrom` method is called from a model-specific
    /// static `of` method. For example:
    ///
    /// ```dart
    /// class MyModel extends InheritedModel<String> {
    ///   // ...
    ///   static MyModel of(BuildContext context, String aspect) {
    ///     return InheritedModel.inheritFrom<MyModel>(context, aspect: aspect);
    ///   }
    /// }
    /// ```
    ///
    /// Calling `MyModel.of(context, 'foo')` means that `context` should only
    /// be rebuilt when the `foo` aspect of `MyModel` changes. If the aspect
    /// is null, then the model supports all aspects.
    ///
    /// When the inherited model is rebuilt the [updateShouldNotify] and
    /// [updateShouldNotifyDependent] methods are used to decide what
    /// should be rebuilt. If [updateShouldNotify] returns true, then the
    /// inherited model's [updateShouldNotifyDependent] method is tested for
    /// each dependent and the set of aspect objects it depends on.
    /// The [updateShouldNotifyDependent] method must compare the set of aspect
    /// dependencies with the changes in the model itself.
    ///
    /// For example:
    ///
    /// ```dart
    /// class ABModel extends InheritedModel<String> {
    ///   ABModel({ this.a, this.b, Widget child }) : super(child: child);
    ///
    ///   final int a;
    ///   final int b;
    ///
    ///   @override
    ///   bool updateShouldNotify(ABModel old) {
    ///     return a != old.a || b != old.b;
    ///   }
    ///
    ///   @override
    ///   bool updateShouldNotifyDependent(ABModel old, Set<String> aspects) {
    ///     return (a != old.a && aspects.contains('a'))
    ///         || (b != old.b && aspects.contains('b'))
    ///   }
    ///
    ///   // ...
    /// }
    /// ```
    ///
    /// In the previous example the dependencies checked by
    /// [updateShouldNotifyDependent] are just the aspect strings passed to
    /// `dependOnInheritedWidgetOfExactType`. They're represented as a [Set] because
    /// one Widget can depend on more than one aspect of the model.
    /// If a widget depends on the model but doesn't specify an aspect,
    /// then changes in the model will cause the widget to be rebuilt
    /// unconditionally.
    ///
    /// See also:
    ///
    ///  * [InheritedWidget], an inherited widget that only notifies dependents
    ///    when its value is different.
    ///  * [InheritedNotifier], an inherited widget whose value can be a
    ///    [Listenable], and which will notify dependents whenever the value
    ///    sends notifications.
    /// </Summary>
    public interface IInheritedModel<T>
    {
        InheritedModelElement<T> CreateElement();
        bool UpdateShouldNotifyDependent(FlutterSDK.Widgets.Inheritedmodel.InheritedModel<T> oldWidget, HashSet<T> dependencies);
        bool IsSupportedAspect(@Object aspect);
        T InheritFrom<T>(FlutterSDK.Widgets.Framework.BuildContext context, @Object aspect = default(@Object));
    }


    /// <Summary>
    /// An [InheritedWidget] that's intended to be used as the base class for
    /// models whose dependents may only depend on one part or "aspect" of the
    /// overall model.
    ///
    /// An inherited widget's dependents are unconditionally rebuilt when the
    /// inherited widget changes per [InheritedWidget.updateShouldNotify].
    /// This widget is similar except that dependents aren't rebuilt
    /// unconditionally.
    ///
    /// Widgets that depend on an [InheritedModel] qualify their dependence
    /// with a value that indicates what "aspect" of the model they depend
    /// on. When the model is rebuilt, dependents will also be rebuilt, but
    /// only if there was a change in the model that corresponds to the aspect
    /// they provided.
    ///
    /// The type parameter `T` is the type of the model aspect objects.
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=ml5uefGgkaA}
    ///
    /// Widgets create a dependency on an [InheritedModel] with a static method:
    /// [InheritedModel.inheritFrom]. This method's `context` parameter
    /// defines the subtree that will be rebuilt when the model changes.
    /// Typically the `inheritFrom` method is called from a model-specific
    /// static `of` method. For example:
    ///
    /// ```dart
    /// class MyModel extends InheritedModel<String> {
    ///   // ...
    ///   static MyModel of(BuildContext context, String aspect) {
    ///     return InheritedModel.inheritFrom<MyModel>(context, aspect: aspect);
    ///   }
    /// }
    /// ```
    ///
    /// Calling `MyModel.of(context, 'foo')` means that `context` should only
    /// be rebuilt when the `foo` aspect of `MyModel` changes. If the aspect
    /// is null, then the model supports all aspects.
    ///
    /// When the inherited model is rebuilt the [updateShouldNotify] and
    /// [updateShouldNotifyDependent] methods are used to decide what
    /// should be rebuilt. If [updateShouldNotify] returns true, then the
    /// inherited model's [updateShouldNotifyDependent] method is tested for
    /// each dependent and the set of aspect objects it depends on.
    /// The [updateShouldNotifyDependent] method must compare the set of aspect
    /// dependencies with the changes in the model itself.
    ///
    /// For example:
    ///
    /// ```dart
    /// class ABModel extends InheritedModel<String> {
    ///   ABModel({ this.a, this.b, Widget child }) : super(child: child);
    ///
    ///   final int a;
    ///   final int b;
    ///
    ///   @override
    ///   bool updateShouldNotify(ABModel old) {
    ///     return a != old.a || b != old.b;
    ///   }
    ///
    ///   @override
    ///   bool updateShouldNotifyDependent(ABModel old, Set<String> aspects) {
    ///     return (a != old.a && aspects.contains('a'))
    ///         || (b != old.b && aspects.contains('b'))
    ///   }
    ///
    ///   // ...
    /// }
    /// ```
    ///
    /// In the previous example the dependencies checked by
    /// [updateShouldNotifyDependent] are just the aspect strings passed to
    /// `dependOnInheritedWidgetOfExactType`. They're represented as a [Set] because
    /// one Widget can depend on more than one aspect of the model.
    /// If a widget depends on the model but doesn't specify an aspect,
    /// then changes in the model will cause the widget to be rebuilt
    /// unconditionally.
    ///
    /// See also:
    ///
    ///  * [InheritedWidget], an inherited widget that only notifies dependents
    ///    when its value is different.
    ///  * [InheritedNotifier], an inherited widget whose value can be a
    ///    [Listenable], and which will notify dependents whenever the value
    ///    sends notifications.
    /// </Summary>
    public class InheritedModel<T> : FlutterSDK.Widgets.Framework.InheritedWidget
    {
        #region constructors
        public InheritedModel(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
    
}
    #endregion

    #region fields
    #endregion

    #region methods

    public new InheritedModelElement<T> CreateElement() => new InheritedModelElement<T>(this);



    /// <Summary>
    /// Return true if the changes between this model and [oldWidget] match any
    /// of the [dependencies].
    /// </Summary>
    public virtual bool UpdateShouldNotifyDependent(FlutterSDK.Widgets.Inheritedmodel.InheritedModel<T> oldWidget, HashSet<T> dependencies)
    {
        return default(bool);
    }


    /// <Summary>
    /// Returns true if this model supports the given [aspect].
    ///
    /// Returns true by default: this model supports all aspects.
    ///
    /// Subclasses may override this method to indicate that they do not support
    /// all model aspects. This is typically done when a model can be used
    /// to "shadow" some aspects of an ancestor.
    /// </Summary>
    public virtual bool IsSupportedAspect(@Object aspect) => true;



    private void _FindModels<T>(FlutterSDK.Widgets.Framework.BuildContext context, @Object aspect, List<FlutterSDK.Widgets.Framework.InheritedElement> results)
    {
        InheritedElement model = context.GetElementForInheritedWidgetOfExactType();
        if (model == null) return;
        results.Add(model);

        T modelWidget = model.Widget as T;
        if (modelWidget.IsSupportedAspect(aspect)) return;
        Element modelParent = default(Element);
        model.VisitAncestorElements((Element ancestor) =>
        {
            modelParent = ancestor;
            return false;
        }
        );
        if (modelParent == null) return;
        _FindModels(modelParent, aspect, results);
    }




    /// <Summary>
    /// Makes [context] dependent on the specified [aspect] of an [InheritedModel]
    /// of type T.
    ///
    /// When the given [aspect] of the model changes, the [context] will be
    /// rebuilt. The [updateShouldNotifyDependent] method must determine if a
    /// change in the model widget corresponds to an [aspect] value.
    ///
    /// The dependencies created by this method target all [InheritedModel] ancestors
    /// of type T up to and including the first one for which [isSupportedAspect]
    /// returns true.
    ///
    /// If [aspect] is null this method is the same as
    /// `context.dependOnInheritedWidgetOfExactType<T>()`.
    ///
    /// If no ancestor of type T exists, null is returned.
    /// </Summary>
    public virtual T InheritFrom<T>(FlutterSDK.Widgets.Framework.BuildContext context, @Object aspect = default(@Object))
    {
        if (aspect == null) return context.DependOnInheritedWidgetOfExactType();
        List<InheritedElement> models = new List<InheritedElement>() { };
        _FindModels(context, aspect, models);
        if (models.IsEmpty())
        {
            return null;
        }

        InheritedElement lastModel = models.Last();
        foreach (InheritedElement model in models)
        {
            T value = context.DependOnInheritedElement(model, aspect: aspect) as T;
            if (model == lastModel) return value;
        }


        return null;
    }



    #endregion
}


/// <Summary>
/// An [Element] that uses a [InheritedModel] as its configuration.
/// </Summary>
public class InheritedModelElement<T> : FlutterSDK.Widgets.Framework.InheritedElement
{
    #region constructors
    public InheritedModelElement(FlutterSDK.Widgets.Inheritedmodel.InheritedModel<T> widget)
    : base(widget)

}
#endregion

#region fields
public virtual FlutterSDK.Widgets.Inheritedmodel.InheritedModel<T> Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void UpdateDependencies(FlutterSDK.Widgets.Framework.Element dependent, @Object aspect)
{
    HashSet<T> dependencies = GetDependencies(dependent) as HashSet<T>;
    if (dependencies != null && dependencies.IsEmpty()) return;
    if (aspect == null)
    {
        SetDependencies(dependent, new HashSet<T>());
    }
    else
    {

        SetDependencies(dependent, (dependencies ?? new HashSet<T>());
        (dependencies ?? new HashSet<T>()).Add(aspect as T));
    }

}




public new void NotifyDependent(FlutterSDK.Widgets.Inheritedmodel.InheritedModel<T> oldWidget, FlutterSDK.Widgets.Framework.Element dependent)
{
    HashSet<T> dependencies = GetDependencies(dependent) as HashSet<T>;
    if (dependencies == null) return;
    if (dependencies.IsEmpty() || Widget.UpdateShouldNotifyDependent(oldWidget, dependencies)) dependent.DidChangeDependencies();
}



#endregion
}

}
