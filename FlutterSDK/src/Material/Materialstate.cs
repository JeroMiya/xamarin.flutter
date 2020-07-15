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
namespace FlutterSDK.Material.Materialstate
{
    public delegate T MaterialPropertyResolver<T>(HashSet<FlutterSDK.Material.Materialstate.MaterialState> states);
    internal static class MaterialstateDefaultClass
    {
    }

    /// <Summary>
    /// Defines a [Color] whose value depends on a set of [MaterialState]s which
    /// represent the interactive state of a component.
    ///
    /// This is useful for improving the accessibility of text in different states
    /// of a component. For example, in a [FlatButton] with blue text, the text will
    /// become more difficult to read when the button is hovered, focused, or pressed,
    /// because the contrast ratio between the button and the text will decrease. To
    /// solve this, you can use [MaterialStateColor] to make the text darker when the
    /// [FlatButton] is hovered, focused, or pressed.
    ///
    /// To use a [MaterialStateColor], you can either:
    ///   1. Create a subclass of [MaterialStateColor] and implement the abstract `resolve` method.
    ///   2. Use [MaterialStateColor.resolveWith] and pass in a callback that
    ///      will be used to resolve the color in the given states.
    ///
    /// This should only be used as parameters when they are documented to take
    /// [MaterialStateColor], otherwise only the default state will be used.
    ///
    /// {@tool snippet}
    ///
    /// This example shows how you could pass a `MaterialStateColor` to `FlatButton.textColor`.
    /// Here, the text color will be `Colors.blue[900]` when the button is being
    /// pressed, hovered, or focused. Otherwise, the text color will be `Colors.blue[600]`.
    ///
    /// ```dart
    /// Color getTextColor(Set<MaterialState> states) {
    ///   const Set<MaterialState> interactiveStates = <MaterialState>{
    ///     MaterialState.pressed,
    ///     MaterialState.hovered,
    ///     MaterialState.focused,
    ///   };
    ///   if (states.any(interactiveStates.contains)) {
    ///     return Colors.blue[900];
    ///   }
    ///   return Colors.blue[600];
    /// }
    ///
    /// FlatButton(
    ///   child: Text('FlatButton'),
    ///   onPressed: () {},
    ///   textColor: MaterialStateColor.resolveWith(getTextColor),
    /// ),
    /// ```
    /// {@end-tool}
    /// </Summary>
    public interface IMaterialStateColor
    {
        FlutterSDK.Material.Materialstate.MaterialStateColor ResolveWith<T>(FlutterSDK.Material.Materialstate.MaterialPropertyResolver<Color> callback);
        Color Resolve(HashSet<FlutterSDK.Material.Materialstate.MaterialState> states);
    }


    public interface IMaterialStateProperty<T> { }

    public class MaterialStateProperty<T>
    {

        /// <Summary>
        /// Returns a different value of type `T` depending on the given `states`.
        ///
        /// Some widgets (such as [RawMaterialButton]) keep track of their set of
        /// [MaterialState]s, and will call `resolve` with the current states at build
        /// time for specified properties (such as [RawMaterialButton.textStyle]'s color).
        /// </Summary>
        public virtual T Resolve(HashSet<FlutterSDK.Material.Materialstate.MaterialState> states)
        {
            return default(T);
        }


        /// <Summary>
        /// Returns the value resolved in the given set of states if `value` is a
        /// [MaterialStateProperty], otherwise returns the value itself.
        ///
        /// This is useful for widgets that have parameters which can optionally be a
        /// [MaterialStateProperty]. For example, [RaisedButton.textColor] can be a
        /// [Color] or a [MaterialStateProperty<Color>].
        /// </Summary>
        public virtual T ResolveAs<T>(T value, HashSet<FlutterSDK.Material.Materialstate.MaterialState> states)
        {
            if (value is MaterialStateProperty<T>)
            {
                MaterialStateProperty<T> property = ((MaterialStateProperty<T>)value);
                return property.Resolve(states);
            }

            return value;
        }




        /// <Summary>
        /// Convenience method for creating a [MaterialStateProperty] from a
        /// [MaterialPropertyResolver] function alone.
        /// </Summary>
        public virtual MaterialStateProperty<T> ResolveWith<T>(FlutterSDK.Material.Materialstate.MaterialPropertyResolver<T> callback) => new _MaterialStateProperty<T>(callback);


    }
    public static class MaterialStatePropertyMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<object, object> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<object, object>();
        static MaterialStateProperty<T> GetOrCreate<T>(IMaterialStateProperty<T> instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new MaterialStateProperty<T>();
                _table.Add(instance, value);
            }
            return (MaterialStateProperty<T>)value;
        }
        public static T Resolve<T>(this IMaterialStateProperty<T> instance, HashSet<FlutterSDK.Material.Materialstate.MaterialState> states) => GetOrCreate(instance).Resolve(states);
        public static T ResolveAs<T><T>(this IMaterialStateProperty<T> instance, T value, HashSet<FlutterSDK.Material.Materialstate.MaterialState> states) => GetOrCreate(instance).ResolveAs<T>(value, states);
        public static MaterialStateProperty<T> ResolveWith<T><T>(this IMaterialStateProperty<T> instance, FlutterSDK.Material.Materialstate.MaterialPropertyResolver<T> callback) => GetOrCreate(instance).ResolveWith<T>(callback);
    }


    /// <Summary>
    /// Defines a [Color] whose value depends on a set of [MaterialState]s which
    /// represent the interactive state of a component.
    ///
    /// This is useful for improving the accessibility of text in different states
    /// of a component. For example, in a [FlatButton] with blue text, the text will
    /// become more difficult to read when the button is hovered, focused, or pressed,
    /// because the contrast ratio between the button and the text will decrease. To
    /// solve this, you can use [MaterialStateColor] to make the text darker when the
    /// [FlatButton] is hovered, focused, or pressed.
    ///
    /// To use a [MaterialStateColor], you can either:
    ///   1. Create a subclass of [MaterialStateColor] and implement the abstract `resolve` method.
    ///   2. Use [MaterialStateColor.resolveWith] and pass in a callback that
    ///      will be used to resolve the color in the given states.
    ///
    /// This should only be used as parameters when they are documented to take
    /// [MaterialStateColor], otherwise only the default state will be used.
    ///
    /// {@tool snippet}
    ///
    /// This example shows how you could pass a `MaterialStateColor` to `FlatButton.textColor`.
    /// Here, the text color will be `Colors.blue[900]` when the button is being
    /// pressed, hovered, or focused. Otherwise, the text color will be `Colors.blue[600]`.
    ///
    /// ```dart
    /// Color getTextColor(Set<MaterialState> states) {
    ///   const Set<MaterialState> interactiveStates = <MaterialState>{
    ///     MaterialState.pressed,
    ///     MaterialState.hovered,
    ///     MaterialState.focused,
    ///   };
    ///   if (states.any(interactiveStates.contains)) {
    ///     return Colors.blue[900];
    ///   }
    ///   return Colors.blue[600];
    /// }
    ///
    /// FlatButton(
    ///   child: Text('FlatButton'),
    ///   onPressed: () {},
    ///   textColor: MaterialStateColor.resolveWith(getTextColor),
    /// ),
    /// ```
    /// {@end-tool}
    /// </Summary>
    public class MaterialStateColor : Color, IMaterialStateProperty<Color>
    {
        #region constructors
        public MaterialStateColor(int defaultValue)
        : base(defaultValue)
    
}
    #endregion

    #region fields
    #endregion

    #region methods

    /// <Summary>
    /// Creates a [MaterialStateColor] from a [MaterialPropertyResolver<Color>]
    /// callback function.
    ///
    /// If used as a regular color, the color resolved in the default state (the
    /// empty set of states) will be used.
    ///
    /// The given callback parameter must return a non-null color in the default
    /// state.
    /// </Summary>
    public virtual FlutterSDK.Material.Materialstate.MaterialStateColor ResolveWith<T>(FlutterSDK.Material.Materialstate.MaterialPropertyResolver<Color> callback) => new _MaterialStateColor(callback);



    /// <Summary>
    /// Returns a [Color] that's to be used when a Material component is in the
    /// specified state.
    /// </Summary>
    public new Color Resolve(HashSet<FlutterSDK.Material.Materialstate.MaterialState> states)
    {
        return default(Color);
    }

    #endregion
}


/// <Summary>
/// A [MaterialStateColor] created from a [MaterialPropertyResolver<Color>]
/// callback alone.
///
/// If used as a regular color, the color resolved in the default state will
/// be used.
///
/// Used by [MaterialStateColor.resolveWith].
/// </Summary>
public class _MaterialStateColor : FlutterSDK.Material.Materialstate.MaterialStateColor
{
    #region constructors
    public _MaterialStateColor(FlutterSDK.Material.Materialstate.MaterialPropertyResolver<Color> _resolve)
    : base(_resolve(_DefaultStates).Value)

}
#endregion

#region fields
internal virtual FlutterSDK.Material.Materialstate.MaterialPropertyResolver<Color> _Resolve { get; set; }
internal virtual HashSet<FlutterSDK.Material.Materialstate.MaterialState> _DefaultStates { get; set; }
#endregion

#region methods

public new Color Resolve(HashSet<FlutterSDK.Material.Materialstate.MaterialState> states) => _Resolve(states);


#endregion
}


public class _MaterialStateProperty<T> : IMaterialStateProperty<T>
{
    #region constructors
    public _MaterialStateProperty(FlutterSDK.Material.Materialstate.MaterialPropertyResolver<T> _resolve)

}
#endregion

#region fields
internal virtual FlutterSDK.Material.Materialstate.MaterialPropertyResolver<T> _Resolve { get; set; }
#endregion

#region methods

public new T Resolve(HashSet<FlutterSDK.Material.Materialstate.MaterialState> states) => _Resolve(states);


#endregion
}


/// <Summary>
/// Interactive states that some of the Material widgets can take on when
/// receiving input from the user.
///
/// States are defined by https://material.io/design/interaction/states.html#usage.
///
/// Some Material widgets track their current state in a `Set<MaterialState>`.
///
/// See also:
///
///  * [MaterialStateColor], a color that has a `resolve` method that can
///    return a different color depending on the state of the widget that it
///    is used in.
/// </Summary>
public enum MaterialState
{

    /// <Summary>
    /// The state when the user drags their mouse cursor over the given widget.
    ///
    /// See: https://material.io/design/interaction/states.html#hover.
    /// </Summary>
    Hovered,
    /// <Summary>
    /// The state when the user navigates with the keyboard to a given widget.
    ///
    /// This can also sometimes be triggered when a widget is tapped. For example,
    /// when a [TextField] is tapped, it becomes [focused].
    ///
    /// See: https://material.io/design/interaction/states.html#focus.
    /// </Summary>
    Focused,
    /// <Summary>
    /// The state when the user is actively pressing down on the given widget.
    ///
    /// See: https://material.io/design/interaction/states.html#pressed.
    /// </Summary>
    Pressed,
    /// <Summary>
    /// The state when this widget is being dragged from one place to another by
    /// the user.
    ///
    /// https://material.io/design/interaction/states.html#dragged.
    /// </Summary>
    Dragged,
    /// <Summary>
    /// The state when this item has been selected.
    ///
    /// This applies to things that can be toggled (such as chips and checkboxes)
    /// and things that are selected from a set of options (such as tabs and radio buttons).
    ///
    /// See: https://material.io/design/interaction/states.html#selected.
    /// </Summary>
    Selected,
    /// <Summary>
    /// The state when this widget disabled and can not be interacted with.
    ///
    /// Disabled widgets should not respond to hover, focus, press, or drag
    /// interactions.
    ///
    /// See: https://material.io/design/interaction/states.html#disabled.
    /// </Summary>
    Disabled,
    /// <Summary>
    /// The state when the widget has entered some form of invalid state.
    ///
    /// See https://material.io/design/interaction/states.html#usage.
    /// </Summary>
    Error,
}

}
