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
using FlutterSDK.Widgets.Constants;
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
        /// <Summary>
        /// Creates an inherited widget that supports dependencies qualified by
        /// "aspects", i.e. a descendant widget can indicate that it should
        /// only be rebuilt if a specific aspect of the model changes.
        /// </Summary>
        public InheritedModel(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key, child: child)
        {

        }

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



    }


    /// <Summary>
    /// An [Element] that uses a [InheritedModel] as its configuration.
    /// </Summary>
    public class InheritedModelElement<T> : FlutterSDK.Widgets.Framework.InheritedElement
    {
        /// <Summary>
        /// Creates an element that uses the given widget as its configuration.
        /// </Summary>
        public InheritedModelElement(FlutterSDK.Widgets.Inheritedmodel.InheritedModel<T> widget)
        : base(widget)
        {

        }
        public virtual FlutterSDK.Widgets.Inheritedmodel.InheritedModel<T> Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public new void UpdateDependencies(FlutterSDK.Widgets.Framework.Element dependent, @Object aspect)
        {
            HashSet<T> dependencies = GetDependencies(dependent) as HashSet<T>;
            if (dependencies != null && dependencies.IsEmpty()) return;
            if (aspect == null)
            {
                SetDependencies(dependent, HashSet.CreateNew<T>());
            }
            else
            {

                SetDependencies(dependent, (dependencies ?? HashSet.CreateNew<T>());
                (dependencies ?? HashSet.CreateNew<T>()).Add(aspect as T));
            }

        }




        public new void NotifyDependent(FlutterSDK.Widgets.Inheritedmodel.InheritedModel<T> oldWidget, FlutterSDK.Widgets.Framework.Element dependent)
        {
            HashSet<T> dependencies = GetDependencies(dependent) as HashSet<T>;
            if (dependencies == null) return;
            if (dependencies.IsEmpty() || Widget.UpdateShouldNotifyDependent(oldWidget, dependencies)) dependent.DidChangeDependencies();
        }



    }

}
