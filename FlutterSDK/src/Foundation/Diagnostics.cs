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
namespace FlutterSDK.Foundation.Diagnostics
{
    public delegate T ComputePropertyValueCallback<T>();
    internal static class DiagnosticsDefaultClass
    {
        public static FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration SparseTextConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration);
        public static FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration DashedTextConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration);
        public static FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration DenseTextConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration);
        public static FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration TransitionTextConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration);
        public static FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration ErrorTextConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration);
        public static FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration WhitespaceTextConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration);
        public static FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration FlatTextConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration);
        public static FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration SingleLineTextConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration);
        public static FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration ErrorPropertyTextConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration);
        public static FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration ShallowTextConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration);
        public static FlutterSDK.Foundation.Diagnostics._NoDefaultValue KNoDefaultValue = default(FlutterSDK.Foundation.Diagnostics._NoDefaultValue);
        internal static bool _IsSingleLine(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style)
        {
            throw new NotImplementedException();
        }

        internal static string ShortHash(@Object @object)
        {
            throw new NotImplementedException();
        }

        internal static string DescribeIdentity(@Object @object)
        {
            throw new NotImplementedException();
        }

        internal static string DescribeEnum(@Object enumEntry)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// Defines diagnostics data for a [value].
    ///
    /// For debug and profile modes, [DiagnosticsNode] provides a high quality
    /// multiline string dump via [toStringDeep]. The core members are the [name],
    /// [toDescription], [getProperties], [value], and [getChildren]. All other
    /// members exist typically to provide hints for how [toStringDeep] and
    /// debugging tools should format output.
    ///
    /// In release mode, far less information is retained and some information may
    /// not print at all.
    /// </Summary>
    public interface IDiagnosticsNode
    {
        string ToDescription(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration));
        bool IsFiltered(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel);
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetProperties();
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren();
        Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate);
        List<Dictionary<string, @Object>> ToJsonList(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode parent, FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate);
        string ToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel));
        string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel));
        string Name { get; }
        bool ShowSeparator { get; }
        bool ShowName { get; }
        string LinePrefix { get; }
        FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle Style { get; }
        FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get; }
        string EmptyBodyDescription { get; }
        @Object Value { get; }
        bool AllowWrap { get; }
        bool AllowNameWrap { get; }
        bool AllowTruncate { get; }
        FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration TextTreeConfiguration { get; }
    }


    internal interface I_NumProperty<T>
    {
        Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate);
        string NumberToString();
        string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration));
        string Unit { get; }
    }


    /// <Summary>
    /// A base class for providing string and [DiagnosticsNode] debug
    /// representations describing the properties and children of an object.
    ///
    /// The string debug representation is generated from the intermediate
    /// [DiagnosticsNode] representation. The [DiagnosticsNode] representation is
    /// also used by debugging tools displaying interactive trees of objects and
    /// properties.
    ///
    /// See also:
    ///
    ///  * [DiagnosticableTreeMixin], a mixin that implements this class.
    ///  * [DiagnosticableMixin], which should be used instead of this class to
    ///    provide diagnostics for objects without children.
    /// </Summary>
    public interface IDiagnosticableTree
    {
        string ToStringShallow(string joiner = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel));
        string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel));
        string ToStringShort();
        FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle));
        List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren();
    }


    public interface IDiagnosticableMixin { }

    public class DiagnosticableMixin : IDiagnosticable
    {

        public new string ToStringShort() => DiagnosticsDefaultClass.DescribeIdentity(this);




        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            return new DiagnosticableNode<Diagnosticable>(name: name, value: this, style: style);
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
        }



    }
    public static class DiagnosticableMixinMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IDiagnosticableMixin, DiagnosticableMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IDiagnosticableMixin, DiagnosticableMixin>();
        static DiagnosticableMixin GetOrCreate(IDiagnosticableMixin instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new DiagnosticableMixin();
                _table.Add(instance, value);
            }
            return (DiagnosticableMixin)value;
        }
        public static string ToStringShort(this IDiagnosticableMixin instance) => GetOrCreate(instance).ToStringShort();
        public static string ToString(this IDiagnosticableMixin instance, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) => GetOrCreate(instance).ToString(minLevel);
        public static FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(this IDiagnosticableMixin instance, string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) => GetOrCreate(instance).ToDiagnosticsNode(name, style);
        public static void DebugFillProperties(this IDiagnosticableMixin instance, FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) => GetOrCreate(instance).DebugFillProperties(properties);
    }


    public interface IDiagnosticable { }

    public class Diagnosticable
    {

        /// <Summary>
        /// A brief description of this object, usually just the [runtimeType] and the
        /// [hashCode].
        ///
        /// See also:
        ///
        ///  * [toString], for a detailed description of the object.
        /// </Summary>
        public virtual string ToStringShort() => DiagnosticsDefaultClass.DescribeIdentity(this);




        /// <Summary>
        /// Returns a debug representation of the object that is used by debugging
        /// tools and by [DiagnosticsNode.toStringDeep].
        ///
        /// Leave [name] as null if there is not a meaningful description of the
        /// relationship between the this node and its parent.
        ///
        /// Typically the [style] argument is only specified to indicate an atypical
        /// relationship between the parent and the node. For example, pass
        /// [DiagnosticsTreeStyle.offstage] to indicate that a node is offstage.
        /// </Summary>
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            return new DiagnosticableNode<Diagnosticable>(name: name, value: this, style: style);
        }




        /// <Summary>
        /// Add additional properties associated with the node.
        ///
        /// Use the most specific [DiagnosticsProperty] existing subclass to describe
        /// each property instead of the [DiagnosticsProperty] base class. There are
        /// only a small number of [DiagnosticsProperty] subclasses each covering a
        /// common use case. Consider what values a property is relevant for users
        /// debugging as users debugging large trees are overloaded with information.
        /// Common named parameters in [DiagnosticsNode] subclasses help filter when
        /// and how properties are displayed.
        ///
        /// `defaultValue`, `showName`, `showSeparator`, and `level` keep string
        /// representations of diagnostics terse and hide properties when they are not
        /// very useful.
        ///
        ///  * Use `defaultValue` any time the default value of a property is
        ///    uninteresting. For example, specify a default value of null any time
        ///    a property being null does not indicate an error.
        ///  * Avoid specifying the `level` parameter unless the result you want
        ///    cannot be achieved by using the `defaultValue` parameter or using
        ///    the [ObjectFlagProperty] class to conditionally display the property
        ///    as a flag.
        ///  * Specify `showName` and `showSeparator` in rare cases where the string
        ///    output would look clumsy if they were not set.
        ///    ```dart
        ///    DiagnosticsProperty<Object>('child(3, 4)', null, ifNull: 'is null', showSeparator: false).toString()
        ///    ```
        ///    Shows using `showSeparator` to get output `child(3, 4) is null` which
        ///    is more polished than `child(3, 4): is null`.
        ///    ```dart
        ///    DiagnosticsProperty<IconData>('icon', icon, ifNull: '<empty>', showName: false)).toString()
        ///    ```
        ///    Shows using `showName` to omit the property name as in this context the
        ///    property name does not add useful information.
        ///
        /// `ifNull`, `ifEmpty`, `unit`, and `tooltip` make property
        /// descriptions clearer. The examples in the code sample below illustrate
        /// good uses of all of these parameters.
        ///
        /// ## DiagnosticsProperty subclasses for primitive types
        ///
        ///  * [StringProperty], which supports automatically enclosing a [String]
        ///    value in quotes.
        ///  * [DoubleProperty], which supports specifying a unit of measurement for
        ///    a [double] value.
        ///  * [PercentProperty], which clamps a [double] to between 0 and 1 and
        ///    formats it as a percentage.
        ///  * [IntProperty], which supports specifying a unit of measurement for an
        ///    [int] value.
        ///  * [FlagProperty], which formats a [bool] value as one or more flags.
        ///    Depending on the use case it is better to format a bool as
        ///    `DiagnosticsProperty<bool>` instead of using [FlagProperty] as the
        ///    output is more verbose but unambiguous.
        ///
        /// ## Other important [DiagnosticsProperty] variants
        ///
        ///  * [EnumProperty], which provides terse descriptions of enum values
        ///    working around limitations of the `toString` implementation for Dart
        ///    enum types.
        ///  * [IterableProperty], which handles iterable values with display
        ///    customizable depending on the [DiagnosticsTreeStyle] used.
        ///  * [ObjectFlagProperty], which provides terse descriptions of whether a
        ///    property value is present or not. For example, whether an `onClick`
        ///    callback is specified or an animation is in progress.
        ///  * [ColorProperty], which must be used if the property value is
        ///    a [Color] or one of its subclasses.
        ///  * [IconDataProperty], which must be used if the property value
        ///    is of type [IconData].
        ///
        /// If none of these subclasses apply, use the [DiagnosticsProperty]
        /// constructor or in rare cases create your own [DiagnosticsProperty]
        /// subclass as in the case for [TransformProperty] which handles [Matrix4]
        /// that represent transforms. Generally any property value with a good
        /// `toString` method implementation works fine using [DiagnosticsProperty]
        /// directly.
        ///
        /// {@tool snippet}
        ///
        /// This example shows best practices for implementing [debugFillProperties]
        /// illustrating use of all common [DiagnosticsProperty] subclasses and all
        /// common [DiagnosticsProperty] parameters.
        ///
        /// ```dart
        /// class ExampleObject extends ExampleSuperclass {
        ///
        ///   // ...various members and properties...
        ///
        ///   @override
        ///   void debugFillProperties(DiagnosticPropertiesBuilder properties) {
        ///     // Always add properties from the base class first.
        ///     super.debugFillProperties(properties);
        ///
        ///     // Omit the property name 'message' when displaying this String property
        ///     // as it would just add visual noise.
        ///     properties.add(StringProperty('message', message, showName: false));
        ///
        ///     properties.add(DoubleProperty('stepWidth', stepWidth));
        ///
        ///     // A scale of 1.0 does nothing so should be hidden.
        ///     properties.add(DoubleProperty('scale', scale, defaultValue: 1.0));
        ///
        ///     // If the hitTestExtent matches the paintExtent, it is just set to its
        ///     // default value so is not relevant.
        ///     properties.add(DoubleProperty('hitTestExtent', hitTestExtent, defaultValue: paintExtent));
        ///
        ///     // maxWidth of double.infinity indicates the width is unconstrained and
        ///     // so maxWidth has no impact.,
        ///     properties.add(DoubleProperty('maxWidth', maxWidth, defaultValue: double.infinity));
        ///
        ///     // Progress is a value between 0 and 1 or null. Showing it as a
        ///     // percentage makes the meaning clear enough that the name can be
        ///     // hidden.
        ///     properties.add(PercentProperty(
        ///       'progress',
        ///       progress,
        ///       showName: false,
        ///       ifNull: '<indeterminate>',
        ///     ));
        ///
        ///     // Most text fields have maxLines set to 1.
        ///     properties.add(IntProperty('maxLines', maxLines, defaultValue: 1));
        ///
        ///     // Specify the unit as otherwise it would be unclear that time is in
        ///     // milliseconds.
        ///     properties.add(IntProperty('duration', duration.inMilliseconds, unit: 'ms'));
        ///
        ///     // Tooltip is used instead of unit for this case as a unit should be a
        ///     // terse description appropriate to display directly after a number
        ///     // without a space.
        ///     properties.add(DoubleProperty(
        ///       'device pixel ratio',
        ///       ui.window.devicePixelRatio,
        ///       tooltip: 'physical pixels per logical pixel',
        ///     ));
        ///
        ///     // Displaying the depth value would be distracting. Instead only display
        ///     // if the depth value is missing.
        ///     properties.add(ObjectFlagProperty<int>('depth', depth, ifNull: 'no depth'));
        ///
        ///     // bool flag that is only shown when the value is true.
        ///     properties.add(FlagProperty('using primary controller', value: primary));
        ///
        ///     properties.add(FlagProperty(
        ///       'isCurrent',
        ///       value: isCurrent,
        ///       ifTrue: 'active',
        ///       ifFalse: 'inactive',
        ///       showName: false,
        ///     ));
        ///
        ///     properties.add(DiagnosticsProperty<bool>('keepAlive', keepAlive));
        ///
        ///     // FlagProperty could have also been used in this case.
        ///     // This option results in the text "obscureText: true" instead
        ///     // of "obscureText" which is a bit more verbose but a bit clearer.
        ///     properties.add(DiagnosticsProperty<bool>('obscureText', obscureText, defaultValue: false));
        ///
        ///     properties.add(EnumProperty<TextAlign>('textAlign', textAlign, defaultValue: null));
        ///     properties.add(EnumProperty<ImageRepeat>('repeat', repeat, defaultValue: ImageRepeat.noRepeat));
        ///
        ///     // Warn users when the widget is missing but do not show the value.
        ///     properties.add(ObjectFlagProperty<Widget>('widget', widget, ifNull: 'no widget'));
        ///
        ///     properties.add(IterableProperty<BoxShadow>(
        ///       'boxShadow',
        ///       boxShadow,
        ///       defaultValue: null,
        ///       style: style,
        ///     ));
        ///
        ///     // Getting the value of size throws an exception unless hasSize is true.
        ///     properties.add(DiagnosticsProperty<Size>.lazy(
        ///       'size',
        ///       () => size,
        ///       description: '${ hasSize ? size : "MISSING" }',
        ///     ));
        ///
        ///     // If the `toString` method for the property value does not provide a
        ///     // good terse description, write a DiagnosticsProperty subclass as in
        ///     // the case of TransformProperty which displays a nice debugging view
        ///     // of a Matrix4 that represents a transform.
        ///     properties.add(TransformProperty('transform', transform));
        ///
        ///     // If the value class has a good `toString` method, use
        ///     // DiagnosticsProperty<YourValueType>. Specifying the value type ensures
        ///     // that debugging tools always know the type of the field and so can
        ///     // provide the right UI affordances. For example, in this case even
        ///     // if color is null, a debugging tool still knows the value is a Color
        ///     // and can display relevant color related UI.
        ///     properties.add(DiagnosticsProperty<Color>('color', color));
        ///
        ///     // Use a custom description to generate a more terse summary than the
        ///     // `toString` method on the map class.
        ///     properties.add(DiagnosticsProperty<Map<Listenable, VoidCallback>>(
        ///       'handles',
        ///       handles,
        ///       description: handles != null ?
        ///       '${handles.length} active client${ handles.length == 1 ? "" : "s" }' :
        ///       null,
        ///       ifNull: 'no notifications ever received',
        ///       showName: false,
        ///     ));
        ///   }
        /// }
        /// ```
        /// {@end-tool}
        ///
        /// Used by [toDiagnosticsNode] and [toString].
        /// </Summary>
        public virtual void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
        }



    }
    public static class DiagnosticableMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IDiagnosticable, Diagnosticable> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IDiagnosticable, Diagnosticable>();
        static Diagnosticable GetOrCreate(IDiagnosticable instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new Diagnosticable();
                _table.Add(instance, value);
            }
            return (Diagnosticable)value;
        }
        public static string ToStringShort(this IDiagnosticable instance) => GetOrCreate(instance).ToStringShort();
        public static string ToString(this IDiagnosticable instance, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) => GetOrCreate(instance).ToString(minLevel);
        public static FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(this IDiagnosticable instance, string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) => GetOrCreate(instance).ToDiagnosticsNode(name, style);
        public static void DebugFillProperties(this IDiagnosticable instance, FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) => GetOrCreate(instance).DebugFillProperties(properties);
    }


    public interface IDiagnosticableTreeMixin { }

    public class DiagnosticableTreeMixin : IDiagnosticableTree
    {


        public new string ToStringShallow(string joiner = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        {
            if (ConstantsDefaultClass.KReleaseMode)
            {
                return ToString();
            }

            string shallowString = default(string);

            return shallowString;
        }




        public new string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        {
            return ToDiagnosticsNode().ToStringDeep(prefixLineOne: prefixLineOne, prefixOtherLines: prefixOtherLines, minLevel: minLevel);
        }




        public new string ToStringShort() => DiagnosticsDefaultClass.DescribeIdentity(this);



        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        {
            return new DiagnosticableTreeNode(name: name, value: this, style: style);
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() => new List, <DiagnosticsNode>(};



    public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
    {
    }



}
public static class DiagnosticableTreeMixinMixin
{
    static System.Runtime.CompilerServices.ConditionalWeakTable<IDiagnosticableTreeMixin, DiagnosticableTreeMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IDiagnosticableTreeMixin, DiagnosticableTreeMixin>();
    static DiagnosticableTreeMixin GetOrCreate(IDiagnosticableTreeMixin instance)
    {
        if (!_table.TryGetValue(instance, out var value))
        {
            value = new DiagnosticableTreeMixin();
            _table.Add(instance, value);
        }
        return (DiagnosticableTreeMixin)value;
    }
    public static string ToString(this IDiagnosticableTreeMixin instance, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) => GetOrCreate(instance).ToString(minLevel);
    public static string ToStringShallow(this IDiagnosticableTreeMixin instance, string joiner = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) => GetOrCreate(instance).ToStringShallow(joiner, minLevel);
    public static string ToStringDeep(this IDiagnosticableTreeMixin instance, string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) => GetOrCreate(instance).ToStringDeep(prefixLineOne, prefixOtherLines, minLevel);
    public static string ToStringShort(this IDiagnosticableTreeMixin instance) => GetOrCreate(instance).ToStringShort();
    public static FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(this IDiagnosticableTreeMixin instance, string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) => GetOrCreate(instance).ToDiagnosticsNode(name, style);
    public static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren(this IDiagnosticableTreeMixin instance) => GetOrCreate(instance).DebugDescribeChildren();
    public static void DebugFillProperties(this IDiagnosticableTreeMixin instance, FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) => GetOrCreate(instance).DebugFillProperties(properties);
}


public interface IDiagnosticsSerializationDelegate { }

public class DiagnosticsSerializationDelegate
{
    public virtual int SubtreeDepth { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool IncludeProperties { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool ExpandPropertyValues { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

    /// <Summary>
    /// Returns a serializable map of additional information that will be included
    /// in the serialization of the given [DiagnosticsNode].
    ///
    /// This method is called for every [DiagnosticsNode] that's included in
    /// the serialization.
    /// </Summary>
    public virtual Dictionary<string, @Object> AdditionalNodeProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node)
    {
        return default(Dictionary<string, object>);
    }


    /// <Summary>
    /// Filters the list of [DiagnosticsNode]s that will be included as children
    /// for the given `owner` node.
    ///
    /// The callback may return a subset of the children in the provided list
    /// or replace the entire list with new child nodes.
    ///
    /// See also:
    ///
    ///  * [subtreeDepth], which controls how many levels of children will be
    ///    included in the serialization.
    /// </Summary>
    public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterChildren(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner)
    {
        return default(List<DiagnosticsNode>);
    }


    /// <Summary>
    /// Filters the list of [DiagnosticsNode]s that will be included as properties
    /// for the given `owner` node.
    ///
    /// The callback may return a subset of the properties in the provided list
    /// or replace the entire list with new property nodes.
    ///
    /// By default, `nodes` is returned as-is.
    ///
    /// See also:
    ///
    ///  * [includeProperties], which controls whether properties will be included
    ///    at all.
    /// </Summary>
    public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterProperties(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner)
    {
        return default(List<DiagnosticsNode>);
    }


    /// <Summary>
    /// Truncates the given list of [DiagnosticsNode] that will be added to the
    /// serialization as children or properties of the `owner` node.
    ///
    /// The method must return a subset of the provided nodes and may
    /// not replace any nodes. While [filterProperties] and [filterChildren]
    /// completely hide a node from the serialization, truncating a node will
    /// leave a hint in the serialization that there were additional nodes in the
    /// result that are not included in the current serialization.
    ///
    /// By default, `nodes` is returned as-is.
    /// </Summary>
    public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> TruncateNodesList(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner)
    {
        return default(List<DiagnosticsNode>);
    }


    /// <Summary>
    /// Returns the [DiagnosticsSerializationDelegate] to be used
    /// for adding the provided [DiagnosticsNode] to the serialization.
    ///
    /// By default, this will return a copy of this delegate, which has the
    /// [subtreeDepth] reduced by one.
    ///
    /// This is called for nodes that will be added to the serialization as
    /// property or child of another node. It may return the same delegate if no
    /// changes to it are necessary.
    /// </Summary>
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate DelegateForNode(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node)
    {
        return default(DiagnosticsSerializationDelegate);
    }


    /// <Summary>
    /// Creates a copy of this [DiagnosticsSerializationDelegate] with the
    /// provided values.
    /// </Summary>
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate CopyWith(int subtreeDepth = default(int), bool includeProperties = default(bool))
    {
        return default(DiagnosticsSerializationDelegate);
    }

}
public static class DiagnosticsSerializationDelegateMixin
{
    static System.Runtime.CompilerServices.ConditionalWeakTable<IDiagnosticsSerializationDelegate, DiagnosticsSerializationDelegate> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IDiagnosticsSerializationDelegate, DiagnosticsSerializationDelegate>();
    static DiagnosticsSerializationDelegate GetOrCreate(IDiagnosticsSerializationDelegate instance)
    {
        if (!_table.TryGetValue(instance, out var value))
        {
            value = new DiagnosticsSerializationDelegate();
            _table.Add(instance, value);
        }
        return (DiagnosticsSerializationDelegate)value;
    }
    public static int SubtreeDepthProperty(this IDiagnosticsSerializationDelegate instance) => GetOrCreate(instance).SubtreeDepth;
    public static bool IncludePropertiesProperty(this IDiagnosticsSerializationDelegate instance) => GetOrCreate(instance).IncludeProperties;
    public static bool ExpandPropertyValuesProperty(this IDiagnosticsSerializationDelegate instance) => GetOrCreate(instance).ExpandPropertyValues;
    public static Dictionary<string, @Object> AdditionalNodeProperties(this IDiagnosticsSerializationDelegate instance, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node) => GetOrCreate(instance).AdditionalNodeProperties(node);
    public static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterChildren(this IDiagnosticsSerializationDelegate instance, List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) => GetOrCreate(instance).FilterChildren(nodes, owner);
    public static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterProperties(this IDiagnosticsSerializationDelegate instance, List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) => GetOrCreate(instance).FilterProperties(nodes, owner);
    public static List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> TruncateNodesList(this IDiagnosticsSerializationDelegate instance, List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) => GetOrCreate(instance).TruncateNodesList(nodes, owner);
    public static FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate DelegateForNode(this IDiagnosticsSerializationDelegate instance, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node) => GetOrCreate(instance).DelegateForNode(node);
    public static FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate CopyWith(this IDiagnosticsSerializationDelegate instance, int subtreeDepth = default(int), bool includeProperties = default(bool)) => GetOrCreate(instance).CopyWith(subtreeDepth, includeProperties);
}


/// <Summary>
/// Configuration specifying how a particular [DiagnosticsTreeStyle] should be
/// rendered as text art.
///
/// See also:
///
///  * [sparseTextConfiguration], which is a typical style.
///  * [transitionTextConfiguration], which is an example of a complex tree style.
///  * [DiagnosticsNode.toStringDeep], for code using [TextTreeConfiguration]
///    to render text art for arbitrary trees of [DiagnosticsNode] objects.
/// </Summary>
public class TextTreeConfiguration
{
    #region constructors
    public TextTreeConfiguration(string prefixLineOne = default(string), string prefixOtherLines = default(string), string prefixLastChildLineOne = default(string), string prefixOtherLinesRootNode = default(string), string linkCharacter = default(string), string propertyPrefixIfChildren = default(string), string propertyPrefixNoChildren = default(string), string lineBreak = default(string), bool lineBreakProperties = true, string afterName = default(string), string afterDescriptionIfBody = default(string), string afterDescription = default(string), string beforeProperties = default(string), string afterProperties = default(string), string mandatoryAfterProperties = default(string), string propertySeparator = default(string), string bodyIndent = default(string), string footer = default(string), bool showChildren = true, bool addBlankLineIfNoChildren = true, bool isNameOnOwnLine = false, bool isBlankLineBetweenPropertiesAndChildren = true, string beforeName = default(string), string suffixLineOne = default(string), string mandatoryFooter = default(string))
    : base()
    {
        this.PrefixLineOne = prefixLineOne;
        this.PrefixOtherLines = prefixOtherLines;
        this.PrefixLastChildLineOne = prefixLastChildLineOne;
        this.PrefixOtherLinesRootNode = prefixOtherLinesRootNode;
        this.LinkCharacter = linkCharacter;
        this.PropertyPrefixIfChildren = propertyPrefixIfChildren;
        this.PropertyPrefixNoChildren = propertyPrefixNoChildren;
        this.LineBreak = lineBreak;
        this.LineBreakProperties = lineBreakProperties;
        this.AfterName = afterName;
        this.AfterDescriptionIfBody = afterDescriptionIfBody;
        this.AfterDescription = afterDescription;
        this.BeforeProperties = beforeProperties;
        this.AfterProperties = afterProperties;
        this.MandatoryAfterProperties = mandatoryAfterProperties;
        this.PropertySeparator = propertySeparator;
        this.BodyIndent = bodyIndent;
        this.Footer = footer;
        this.ShowChildren = showChildren;
        this.AddBlankLineIfNoChildren = addBlankLineIfNoChildren;
        this.IsNameOnOwnLine = isNameOnOwnLine;
        this.IsBlankLineBetweenPropertiesAndChildren = isBlankLineBetweenPropertiesAndChildren;
        this.BeforeName = beforeName;
        this.SuffixLineOne = suffixLineOne;
        this.MandatoryFooter = mandatoryFooter;
    }
    #endregion

    #region fields
    public virtual string PrefixLineOne { get; set; }
    public virtual string SuffixLineOne { get; set; }
    public virtual string PrefixOtherLines { get; set; }
    public virtual string PrefixLastChildLineOne { get; set; }
    public virtual string PrefixOtherLinesRootNode { get; set; }
    public virtual string PropertyPrefixIfChildren { get; set; }
    public virtual string PropertyPrefixNoChildren { get; set; }
    public virtual string LinkCharacter { get; set; }
    public virtual string ChildLinkSpace { get; set; }
    public virtual string LineBreak { get; set; }
    public virtual bool LineBreakProperties { get; set; }
    public virtual string BeforeName { get; set; }
    public virtual string AfterName { get; set; }
    public virtual string AfterDescriptionIfBody { get; set; }
    public virtual string AfterDescription { get; set; }
    public virtual string BeforeProperties { get; set; }
    public virtual string AfterProperties { get; set; }
    public virtual string MandatoryAfterProperties { get; set; }
    public virtual string PropertySeparator { get; set; }
    public virtual string BodyIndent { get; set; }
    public virtual bool ShowChildren { get; set; }
    public virtual bool AddBlankLineIfNoChildren { get; set; }
    public virtual bool IsNameOnOwnLine { get; set; }
    public virtual string Footer { get; set; }
    public virtual string MandatoryFooter { get; set; }
    public virtual bool IsBlankLineBetweenPropertiesAndChildren { get; set; }
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Builder that builds a String with specified prefixes for the first and
/// subsequent lines.
///
/// Allows for the incremental building of strings using `write*()` methods.
/// The strings are concatenated into a single string with the first line
/// prefixed by [prefixLineOne] and subsequent lines prefixed by
/// [prefixOtherLines].
/// </Summary>
public class _PrefixedStringBuilder
{
    #region constructors
    public _PrefixedStringBuilder(string prefixLineOne = default(string), string prefixOtherLines = default(string), int wrapWidth = default(int))
    : base()
    {
        this.PrefixLineOne = prefixLineOne;
        this.WrapWidth = wrapWidth;
    }
    #endregion

    #region fields
    public virtual string PrefixLineOne { get; set; }
    internal virtual string _PrefixOtherLines { get; set; }
    internal virtual string _NextPrefixOtherLines { get; set; }
    public virtual int WrapWidth { get; set; }
    internal virtual StringBuffer _Buffer { get; set; }
    internal virtual StringBuffer _CurrentLine { get; set; }
    internal virtual List<int> _WrappableRanges { get; set; }
    internal virtual int _NumLines { get; set; }
    public virtual string PrefixOtherLines { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool RequiresMultipleLines { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool IsCurrentLineEmpty { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public virtual void IncrementPrefixOtherLines(string suffix, bool updateCurrentLine = default(bool))
    {
        if (_CurrentLine.IsEmpty() || updateCurrentLine)
        {
            _PrefixOtherLines = PrefixOtherLines + suffix;
            _NextPrefixOtherLines = null;
        }
        else
        {
            _NextPrefixOtherLines = PrefixOtherLines + suffix;
        }

    }




    private void _FinalizeLine(bool addTrailingLineBreak)
    {
        bool firstLine = _Buffer.IsEmpty();
        string text = _CurrentLine.ToString();
        _CurrentLine.Clear();
        if (_WrappableRanges.IsEmpty())
        {
            _WriteLine(text, includeLineBreak: addTrailingLineBreak, firstLine: firstLine);
            return;
        }

        Iterable<string> lines = _WordWrapLine(text, _WrappableRanges, WrapWidth, startOffset: firstLine ? PrefixLineOne.Length : _PrefixOtherLines.Length, otherLineOffset: firstLine ? _PrefixOtherLines.Length : _PrefixOtherLines.Length);
        int i = 0;
        int length = lines.Length;
        foreach (string line in lines)
        {
            i++;
            _WriteLine(line, includeLineBreak: addTrailingLineBreak || i < length, firstLine: firstLine);
        }

        _WrappableRanges.Clear();
    }




    /// <Summary>
    /// Wraps the given string at the given width.
    ///
    /// Wrapping occurs at space characters (U+0020).
    ///
    /// This is not suitable for use with arbitrary Unicode text. For example, it
    /// doesn't implement UAX #14, can't handle ideographic text, doesn't hyphenate,
    /// and so forth. It is only intended for formatting error messages.
    ///
    /// This method wraps a sequence of text where only some spans of text can be
    /// used as wrap boundaries.
    /// </Summary>
    private Iterable<string> _WordWrapLine(string message, List<int> wrapRanges, int width, int startOffset = 0, int otherLineOffset = 0)
    {
        if (message.Length + startOffset < width)
        {
            yield return message;
            return;
        }

        int startForLengthCalculations = -startOffset;
        bool addPrefix = false;
        int index = 0;
        _WordWrapParseMode mode = _WordWrapParseMode.InSpace;
        int lastWordStart = default(int);
        int lastWordEnd = default(int);
        int start = 0;
        int currentChunk = 0;
        bool NoWrap(int index)
        {
            while (true)
            {
                if (currentChunk >= wrapRanges.Count) return true;
                if (index < wrapRanges[currentChunk + 1]) break;
                currentChunk += 2;
            }

            return index < wrapRanges[currentChunk];
        }

        while (true)
        {
            switch (mode)
            {
                case _WordWrapParseMode.InSpace: while ((index < message.Length) && (message[index] == ' ')) index += 1; lastWordStart = index; mode = _WordWrapParseMode.InWord; break;
                case _WordWrapParseMode.InWord: while ((index < message.Length) && (message[index] != ' ' || NoWrap(index))) index += 1; mode = _WordWrapParseMode.AtBreak; break;
                case _WordWrapParseMode.AtBreak:
                    if ((index - startForLengthCalculations > width) || (index == message.Length))
                    {
                        if ((index - startForLengthCalculations <= width) || (lastWordEnd == null))
                        {
                            lastWordEnd = index;
                        }

                        string line = message.Substring(start, lastWordEnd);
                        yield return line;
                        addPrefix = true;
                        if (lastWordEnd >= message.Length) return;
                        if (lastWordEnd == index)
                        {
                            while ((index < message.Length) && (message[index] == ' ')) index += 1;
                            start = index;
                            mode = _WordWrapParseMode.InWord;
                        }
                        else
                        {

                            start = lastWordStart;
                            mode = _WordWrapParseMode.AtBreak;
                        }

                        startForLengthCalculations = start - otherLineOffset;

                        lastWordEnd = null;
                    }
                    else
                    {
                        lastWordEnd = index;
                        mode = _WordWrapParseMode.InSpace;
                    }
                    break;
            }
        }

    }




    /// <Summary>
    /// Write text ensuring the specified prefixes for the first and subsequent
    /// lines.
    ///
    /// If [allowWrap] is true, the text may be wrapped to stay within the
    /// allow `wrapWidth`.
    /// </Summary>
    public virtual void Write(string s, bool allowWrap = false)
    {
        if (s.IsEmpty()) return;
        List<string> lines = s.Split('\n').ToList();
        for (int i = 0; i < lines.Count; i += 1)
        {
            if (i > 0)
            {
                _FinalizeLine(true);
                _UpdatePrefix();
            }

            string line = lines[i];
            if (line.IsNotEmpty)
            {
                if (allowWrap && WrapWidth != null)
                {
                    int wrapStart = _CurrentLine.Length;
                    int wrapEnd = wrapStart + line.Length;
                    if (_WrappableRanges.IsNotEmpty && _WrappableRanges.Last() == wrapStart)
                    {
                        _WrappableRanges.Last() = wrapEnd;
                    }
                    else
                    {
                        ;
                        _WrappableRanges.Add(wrapStart);
                        _WrappableRanges.Add(wrapEnd);
                    }

                }

                _CurrentLine.Write(line);
            }

        }

    }




    private void _UpdatePrefix()
    {
        if (_NextPrefixOtherLines != null)
        {
            _PrefixOtherLines = _NextPrefixOtherLines;
            _NextPrefixOtherLines = null;
        }

    }




    private void _WriteLine(string line, bool includeLineBreak = default(bool), bool firstLine = default(bool))
    {
        line = $"'{_GetCurrentPrefix(firstLine)}{line}'";
        _Buffer.Write(line.TrimEnd());
        if (includeLineBreak) _Buffer.Write('\n');
        _NumLines++;
    }




    private string _GetCurrentPrefix(bool firstLine)
    {
        return _Buffer.IsEmpty() ? PrefixLineOne : (firstLine ? _PrefixOtherLines : _PrefixOtherLines);
    }




    /// <Summary>
    /// Write lines assuming the lines obey the specified prefixes. Ensures that
    /// a newline is added if one is not present.
    /// </Summary>
    public virtual void WriteRawLines(string lines)
    {
        if (lines.IsEmpty()) return;
        if (_CurrentLine.IsNotEmpty)
        {
            _FinalizeLine(true);
        }


        _Buffer.Write(lines);
        if (!lines.EndsWith('\n')) _Buffer.Write('\n');
        _NumLines++;
        _UpdatePrefix();
    }




    /// <Summary>
    /// Finishes the current line with a stretched version of text.
    /// </Summary>
    public virtual void WriteStretched(string text, int targetLineLength)
    {
        Write(text);
        int currentLineLength = _CurrentLine.Length + _GetCurrentPrefix(_Buffer.IsEmpty()).Length;

        int targetLength = targetLineLength - currentLineLength;
        if (targetLength > 0)
        {

            string lastChar = text[text.Length - 1];

            _CurrentLine.Write(lastChar * targetLength);
        }

        _WrappableRanges.Clear();
    }




    public virtual string Build()
    {
        if (_CurrentLine.IsNotEmpty) _FinalizeLine(false);
        return _Buffer.ToString();
    }



    #endregion
}


public class _NoDefaultValue
{
    #region constructors
    public _NoDefaultValue()
    {

    }
    #endregion

    #region fields
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Renderer that creates ASCII art representations of trees of
/// [DiagnosticsNode] objects.
///
/// See also:
///
///  * [DiagnosticsNode.toStringDeep], which uses a [TextTreeRenderer] to return a
///    string representation of this node and its descendants.
/// </Summary>
public class TextTreeRenderer
{
    #region constructors
    public TextTreeRenderer(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel), int wrapWidth = 100, int wrapWidthProperties = 65, int maxDescendentsTruncatableNode = -1)
    : base()
    {

    }
    #endregion

    #region fields
    internal virtual int _WrapWidth { get; set; }
    internal virtual int _WrapWidthProperties { get; set; }
    internal virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel _MinLevel { get; set; }
    internal virtual int _MaxDescendentsTruncatableNode { get; set; }
    #endregion

    #region methods

    /// <Summary>
    /// Text configuration to use to connect this node to a `child`.
    ///
    /// The singleLine styles are special cased because the connection from the
    /// parent to the child should be consistent with the parent's style as the
    /// single line style does not provide any meaningful style for how children
    /// should be connected to their parents.
    /// </Summary>
    private FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration _ChildTextConfiguration(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode child, FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration textStyle)
    {
        DiagnosticsTreeStyle childStyle = child?.Style;
        return (DiagnosticsDefaultClass._IsSingleLine(childStyle) || childStyle == DiagnosticsTreeStyle.ErrorProperty) ? textStyle : child.TextTreeConfiguration;
    }




    /// <Summary>
    /// Renders a [node] to a String.
    /// </Summary>
    public virtual string Render(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node, string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        if (ConstantsDefaultClass.KReleaseMode)
        {
            return "";
        }
        else
        {
            return _DebugRender(node, prefixLineOne: prefixLineOne, prefixOtherLines: prefixOtherLines, parentConfiguration: parentConfiguration);
        }

    }




    private string _DebugRender(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node, string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        bool isSingleLine = DiagnosticsDefaultClass._IsSingleLine(node.Style) && parentConfiguration?.LineBreakProperties != true;
        prefixOtherLines = (prefixOtherLines == null ? prefixLineOne : prefixOtherLines);
        if (node.LinePrefix != null)
        {
            prefixLineOne += node.LinePrefix;
            prefixOtherLines += node.LinePrefix;
        }

        TextTreeConfiguration config = node.TextTreeConfiguration;
        if (prefixOtherLines.IsEmpty()) prefixOtherLines += config.PrefixOtherLinesRootNode;
        if (node.Style == DiagnosticsTreeStyle.TruncateChildren)
        {
            List<string> descendants = new List<string>() { };
            int maxDepth = 5;
            int depth = 0;
            int maxLines = 25;
            int lines = 0;
            void Visitor(DiagnosticsNode node)
            {
                foreach (DiagnosticsNode child in node.GetChildren())
                {
                    if (lines < maxLines)
                    {
                        depth += 1;
                        descendants.Add($"'{prefixOtherLines}{"  " * depth}{child}'");
                        if (depth < maxDepth) Visitor(child);
                        depth -= 1;
                    }
                    else if (lines == maxLines)
                    {
                        descendants.Add($"'{prefixOtherLines}  ...(descendants list truncated after {lines} lines)'");
                    }

                    lines += 1;
                }

            }

            Visitor(node);
            StringBuffer information = new StringBuffer(prefixLineOne);
            if (lines > 1)
            {
                information.Writeln($"'This {node.Name} had the following descendants (showing up to depth {maxDepth}):'");
            }
            else if (descendants.Count == 1)
            {
                information.Writeln($"'This {node.Name} had the following child:'");
            }
            else
            {
                information.Writeln($"'This {node.Name} has no descendants.'");
            }

            information.WriteAll(descendants, '\n');
            return information.ToString();
        }

        _PrefixedStringBuilder builder = new _PrefixedStringBuilder(prefixLineOne: prefixLineOne, prefixOtherLines: prefixOtherLines, wrapWidth: Math.Dart:mathDefaultClass.Max(_WrapWidth, prefixOtherLines.Length + _WrapWidthProperties));
        List<DiagnosticsNode> children = node.GetChildren();
        string description = node.ToDescription(parentConfiguration: parentConfiguration);
        if (config.BeforeName.IsNotEmpty)
        {
            builder.Write(config.BeforeName);
        }

        bool wrapName = !isSingleLine && node.AllowNameWrap;
        bool wrapDescription = !isSingleLine && node.AllowWrap;
        bool uppercaseTitle = node.Style == DiagnosticsTreeStyle.Error;
        string name = node.Name;
        if (uppercaseTitle)
        {
            name = name?.ToUpper();
        }

        if (description == null || description.IsEmpty())
        {
            if (node.ShowName && name != null) builder.Write(name, allowWrap: wrapName);
        }
        else
        {
            bool includeName = false;
            if (name != null && name.IsNotEmpty && node.ShowName)
            {
                includeName = true;
                builder.Write(name, allowWrap: wrapName);
                if (node.ShowSeparator) builder.Write(config.AfterName, allowWrap: wrapName);
                builder.Write(config.IsNameOnOwnLine || description.Contains('\n') ? '\n' : ' ', allowWrap: wrapName);
            }

            if (!isSingleLine && builder.RequiresMultipleLines && !builder.IsCurrentLineEmpty)
            {
                builder.Write('\n');
            }

            if (includeName)
            {
                builder.IncrementPrefixOtherLines(children.IsEmpty() ? config.PropertyPrefixNoChildren : config.PropertyPrefixIfChildren, updateCurrentLine: true);
            }

            if (uppercaseTitle)
            {
                description = description.ToUpper();
            }

            builder.Write(description.TrimEnd(), allowWrap: wrapDescription);
            if (!includeName)
            {
                builder.IncrementPrefixOtherLines(children.IsEmpty() ? config.PropertyPrefixNoChildren : config.PropertyPrefixIfChildren, updateCurrentLine: false);
            }

        }

        if (config.SuffixLineOne.IsNotEmpty)
        {
            builder.WriteStretched(config.SuffixLineOne, builder.WrapWidth);
        }

        Iterable<DiagnosticsNode> propertiesIterable = node.GetProperties().Where((DiagnosticsNode n) => =>!n.IsFiltered(_MinLevel));
        List<DiagnosticsNode> properties = default(List<DiagnosticsNode>);
        if (_MaxDescendentsTruncatableNode >= 0 && node.AllowTruncate)
        {
            if (propertiesIterable.Length < _MaxDescendentsTruncatableNode)
            {
                properties = propertiesIterable.Take(_MaxDescendentsTruncatableNode).ToList();
                properties.Add(DiagnosticsNode.Message("..."));
            }
            else
            {
                properties = propertiesIterable.ToList();
            }

            if (_MaxDescendentsTruncatableNode < children.Count)
            {
                children = children.Take(_MaxDescendentsTruncatableNode).ToList();
                children.Add(DiagnosticsNode.Message("..."));
            }

        }
        else
        {
            properties = propertiesIterable.ToList();
        }

        if ((properties.IsNotEmpty || children.IsNotEmpty || node.EmptyBodyDescription != null) && (node.ShowSeparator || description?.IsNotEmpty == true))
        {
            builder.Write(config.AfterDescriptionIfBody);
        }

        if (config.LineBreakProperties) builder.Write(config.LineBreak);
        if (properties.IsNotEmpty) builder.Write(config.BeforeProperties);
        builder.IncrementPrefixOtherLines(config.BodyIndent, updateCurrentLine: false);
        if (node.EmptyBodyDescription != null && properties.IsEmpty() && children.IsEmpty() && prefixLineOne.IsNotEmpty)
        {
            builder.Write(node.EmptyBodyDescription);
            if (config.LineBreakProperties) builder.Write(config.LineBreak);
        }

        for (int i = 0; i < properties.Count; ++i)
        {
            DiagnosticsNode property = properties[i];
            if (i > 0) builder.Write(config.PropertySeparator);
            TextTreeConfiguration propertyStyle = property.TextTreeConfiguration;
            if (DiagnosticsDefaultClass._IsSingleLine(property.Style))
            {
                string propertyRender = Render(property, prefixLineOne: propertyStyle.PrefixLineOne, prefixOtherLines: $"'{propertyStyle.ChildLinkSpace}{propertyStyle.PrefixOtherLines}'", parentConfiguration: config);
                List<string> propertyLines = propertyRender.Split('\n').ToList();
                if (propertyLines.Count == 1 && !config.LineBreakProperties)
                {
                    builder.Write(propertyLines.First);
                }
                else
                {
                    builder.Write(propertyRender, allowWrap: false);
                    if (!propertyRender.EndsWith('\n')) builder.Write('\n');
                }

            }
            else
            {
                string propertyRender = Render(property, prefixLineOne: $"'{builder.PrefixOtherLines}{propertyStyle.PrefixLineOne}'", prefixOtherLines: $"'{builder.PrefixOtherLines}{propertyStyle.ChildLinkSpace}{propertyStyle.PrefixOtherLines}'", parentConfiguration: config);
                builder.WriteRawLines(propertyRender);
            }

        }

        if (properties.IsNotEmpty) builder.Write(config.AfterProperties);
        builder.Write(config.MandatoryAfterProperties);
        if (!config.LineBreakProperties) builder.Write(config.LineBreak);
        string prefixChildren = config.BodyIndent;
        string prefixChildrenRaw = $"'{prefixOtherLines}{prefixChildren}'";
        if (children.IsEmpty() && config.AddBlankLineIfNoChildren && builder.RequiresMultipleLines && builder.PrefixOtherLines.TrimEnd().IsNotEmpty)
        {
            builder.Write(config.LineBreak);
        }

        if (children.IsNotEmpty && config.ShowChildren)
        {
            if (config.IsBlankLineBetweenPropertiesAndChildren && properties.IsNotEmpty && children.First.TextTreeConfiguration.IsBlankLineBetweenPropertiesAndChildren)
            {
                builder.Write(config.LineBreak);
            }

            builder.PrefixOtherLines = prefixOtherLines;
            for (int i = 0; i < children.Count; i++)
            {
                DiagnosticsNode child = children[i];

                TextTreeConfiguration childConfig = _ChildTextConfiguration(child, config);
                if (i == children.Count - 1)
                {
                    string lastChildPrefixLineOne = $"'{prefixChildrenRaw}{childConfig.PrefixLastChildLineOne}'";
                    string childPrefixOtherLines = $"'{prefixChildrenRaw}{childConfig.ChildLinkSpace}{childConfig.PrefixOtherLines}'";
                    builder.WriteRawLines(Render(child, prefixLineOne: lastChildPrefixLineOne, prefixOtherLines: childPrefixOtherLines, parentConfiguration: config));
                    if (childConfig.Footer.IsNotEmpty)
                    {
                        builder.PrefixOtherLines = prefixChildrenRaw;
                        builder.Write($"'{childConfig.ChildLinkSpace}{childConfig.Footer}'");
                        if (childConfig.MandatoryFooter.IsNotEmpty)
                        {
                            builder.WriteStretched(childConfig.MandatoryFooter, Math.Dart:mathDefaultClass.Max(builder.WrapWidth, _WrapWidthProperties + childPrefixOtherLines.Length));
                        }

                        builder.Write(config.LineBreak);
                    }

                }
                else
                {
                    TextTreeConfiguration nextChildStyle = _ChildTextConfiguration(children[i + 1], config);
                    string childPrefixLineOne = $"'{prefixChildrenRaw}{childConfig.PrefixLineOne}'";
                    string childPrefixOtherLines = $"'{prefixChildrenRaw}{nextChildStyle.LinkCharacter}{childConfig.PrefixOtherLines}'";
                    builder.WriteRawLines(Render(child, prefixLineOne: childPrefixLineOne, prefixOtherLines: childPrefixOtherLines, parentConfiguration: config));
                    if (childConfig.Footer.IsNotEmpty)
                    {
                        builder.PrefixOtherLines = prefixChildrenRaw;
                        builder.Write($"'{childConfig.LinkCharacter}{childConfig.Footer}'");
                        if (childConfig.MandatoryFooter.IsNotEmpty)
                        {
                            builder.WriteStretched(childConfig.MandatoryFooter, Math.Dart:mathDefaultClass.Max(builder.WrapWidth, _WrapWidthProperties + childPrefixOtherLines.Length));
                        }

                        builder.Write(config.LineBreak);
                    }

                }

            }

        }

        if (parentConfiguration == null && config.MandatoryFooter.IsNotEmpty)
        {
            builder.WriteStretched(config.MandatoryFooter, builder.WrapWidth);
            builder.Write(config.LineBreak);
        }

        return builder.Build();
    }



    #endregion
}


/// <Summary>
/// Defines diagnostics data for a [value].
///
/// For debug and profile modes, [DiagnosticsNode] provides a high quality
/// multiline string dump via [toStringDeep]. The core members are the [name],
/// [toDescription], [getProperties], [value], and [getChildren]. All other
/// members exist typically to provide hints for how [toStringDeep] and
/// debugging tools should format output.
///
/// In release mode, far less information is retained and some information may
/// not print at all.
/// </Summary>
public class DiagnosticsNode
{
    #region constructors
    public DiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), bool showName = true, bool showSeparator = true, string linePrefix = default(string))
    : base()
    {
        this.Name = name;
        this.Style = style;
        this.ShowName = showName;
        this.ShowSeparator = showSeparator;
        this.LinePrefix = linePrefix;
    }
    public static DiagnosticsNode Message(string message, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel), bool allowWrap = true)
    {
        var instance = new DiagnosticsNode();


        return new DiagnosticsProperty<void>("", null, description: message, style: style, showName: false, allowWrap: allowWrap, level: level);
    }


    #endregion

    #region fields
    public virtual string Name { get; set; }
    public virtual bool ShowSeparator { get; set; }
    public virtual bool ShowName { get; set; }
    public virtual string LinePrefix { get; set; }
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle Style { get; set; }
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual string EmptyBodyDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual @Object Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool AllowWrap { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool AllowNameWrap { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual bool AllowTruncate { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    internal virtual string _Separator { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration TextTreeConfiguration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    /// <Summary>
    /// Returns a description with a short summary of the node itself not
    /// including children or properties.
    ///
    /// `parentConfiguration` specifies how the parent is rendered as text art.
    /// For example, if the parent does not line break between properties, the
    /// description of a property should also be a single line if possible.
    /// </Summary>
    public virtual string ToDescription(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        return default(string);
    }


    /// <Summary>
    /// Whether the diagnostic should be filtered due to its [level] being lower
    /// than `minLevel`.
    ///
    /// If `minLevel` is [DiagnosticLevel.hidden] no diagnostics will be filtered.
    /// If `minLevel` is [DiagnosticLevel.off] all diagnostics will be filtered.
    /// </Summary>
    public virtual bool IsFiltered(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel) => ConstantsDefaultClass.KReleaseMode || Level.Index < minLevel.Index;



    /// <Summary>
    /// Properties of this [DiagnosticsNode].
    ///
    /// Properties and children are kept distinct even though they are both
    /// [List<DiagnosticsNode>] because they should be grouped differently.
    /// </Summary>
    public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetProperties()
    {
        return default(List<DiagnosticsNode>);
    }


    /// <Summary>
    /// Children of this [DiagnosticsNode].
    ///
    /// See also:
    ///
    ///  * [getProperties]
    /// </Summary>
    public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren()
    {
        return default(List<DiagnosticsNode>);
    }


    /// <Summary>
    /// Serialize the node to a JSON map according to the configuration provided
    /// in the [DiagnosticsSerializationDelegate].
    ///
    /// Subclasses should override if they have additional properties that are
    /// useful for the GUI tools that consume this JSON.
    ///
    /// See also:
    ///
    ///  * [WidgetInspectorService], which forms the bridge between JSON returned
    ///    by this method and interactive tree views in the Flutter IntelliJ
    ///    plugin.
    /// </Summary>
    public virtual Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
    {
        Dictionary<string, object> result = new Dictionary<string, object> { };

        return result;
    }




    /// <Summary>
    /// Serializes a [List] of [DiagnosticsNode]s to a JSON list according to
    /// the configuration provided by the [DiagnosticsSerializationDelegate].
    ///
    /// The provided `nodes` may be properties or children of the `parent`
    /// [DiagnosticsNode].
    /// </Summary>
    public virtual List<Dictionary<string, @Object>> ToJsonList(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode parent, FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
    {
        bool truncated = false;
        if (nodes == null) return new List, < Dictionary<string, object> > (};
    int originalNodeCount = nodes.Count;
    nodes=delegate.TruncateNodesList(nodes, parent);
if (nodes.Count!=originalNodeCount){
nodes.Add(DiagnosticsNode.Message("..."));
truncated=true ;
}

List<Dictionary<string, object>> json = nodes.Map((DiagnosticsNode node) =>
{
    return node.ToJsonMap(delegate.DelegateForNode(node));
}
).ToList();
if (truncated) json.Last()["truncated"] = true;
return json;
}





/// <Summary>
/// Returns a string representation of this node and its descendants.
///
/// `prefixLineOne` will be added to the front of the first line of the
/// output. `prefixOtherLines` will be added to the front of each other line.
/// If `prefixOtherLines` is null, the `prefixLineOne` is used for every line.
/// By default, there is no prefix.
///
/// `minLevel` specifies the minimum [DiagnosticLevel] for properties included
/// in the output.
///
/// The [toStringDeep] method takes other arguments, but those are intended
/// for internal use when recursing to the descendants, and so can be ignored.
///
/// See also:
///
///  * [toString], for a brief description of the [value] but not its
///    children.
/// </Summary>
public virtual string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
{
    string result = "";

    return result;
}



#endregion
}


/// <Summary>
/// Debugging message displayed like a property.
///
/// {@tool snippet}
///
/// The following two properties are better expressed using this
/// [MessageProperty] class, rather than [StringProperty], as the intent is to
/// show a message with property style display rather than to describe the value
/// of an actual property of the object:
///
/// ```dart
/// var table = MessageProperty('table size', '$columns\u00D7$rows');
/// var usefulness = MessageProperty('usefulness ratio', 'no metrics collected yet (never painted)');
/// ```
/// {@end-tool}
/// {@tool snippet}
///
/// On the other hand, [StringProperty] is better suited when the property has a
/// concrete value that is a string:
///
/// ```dart
/// var name = StringProperty('name', _name);
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [DiagnosticsNode.message], which serves the same role for messages
///    without a clear property name.
///  * [StringProperty], which is a better fit for properties with string values.
/// </Summary>
public class MessageProperty : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<object>
{
    #region constructors
    public MessageProperty(string name, string message, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, null, description: message, style: style, level: level)
    {

    }
    #endregion

    #region fields
    #endregion

    #region methods
    #endregion
}


/// <Summary>
/// Property which encloses its string [value] in quotes.
///
/// See also:
///
///  * [MessageProperty], which is a better fit for showing a message
///    instead of describing a property with a string value.
/// </Summary>
public class StringProperty : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<string>
{
    #region constructors
    public StringProperty(string name, string value, string description = default(string), string tooltip = default(string), bool showName = true, @Object defaultValue = default(@Object), bool quoted = true, string ifEmpty = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, value, description: description, defaultValue: defaultValue, tooltip: tooltip, showName: showName, ifEmpty: ifEmpty, style: style, level: level)
    {
        this.Quoted = quoted;
    }
    #endregion

    #region fields
    public virtual bool Quoted { get; set; }
    #endregion

    #region methods

    public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
    {
        Dictionary<string, object> json = base.ToJsonMap(delegate);
        json["quoted"] = Quoted;
        return json;
    }




    public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        string text = _Description ?? Value;
        if (parentConfiguration != null && !parentConfiguration.LineBreakProperties && text != null)
        {
            text = text.ReplaceAll('\n', "'\n");
        }

        if (Quoted && text != null)
        {
            if (IfEmpty != null && text.IsEmpty()) return IfEmpty;
            return $"'"{ text}
            "'";
        }

        return text.ToString();
    }



    #endregion
}


public class _NumProperty<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<T>
{
    #region constructors
    public _NumProperty(string name, T value, string ifNull = default(string), string unit = default(string), bool showName = true, @Object defaultValue = default(@Object), string tooltip = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, value, ifNull: ifNull, showName: showName, defaultValue: defaultValue, tooltip: tooltip, level: level, style: style)
    {
        this.Unit = unit;
    }
    public static _NumProperty<T> Lazy(string name, FlutterSDK.Foundation.Diagnostics.ComputePropertyValueCallback<T> computeValue, string ifNull = default(string), string unit = default(string), bool showName = true, @Object defaultValue = default(@Object), string tooltip = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    {
        var instance = new _NumProperty<T>(name, computeValue, ifNull: ifNull, showName: showName, defaultValue: defaultValue, tooltip: tooltip, style: style, level: level); instance.Unit = unit;
    }
    #endregion

    #region fields
    public virtual string Unit { get; set; }
    #endregion

    #region methods

    public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
    {
        Dictionary<string, object> json = base.ToJsonMap(delegate);
        if (Unit != null) json["unit"] = Unit;
        json["numberToString"] = NumberToString();
        return json;
    }




    /// <Summary>
    /// String describing just the numeric [value] without a unit suffix.
    /// </Summary>
    public virtual string NumberToString()
    {
        return default(string);
    }


    public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        if (Value == null) return Value.ToString();
        return Unit != null ? $"'{NumberToString()}{Unit}'" : NumberToString();
    }



    #endregion
}


/// <Summary>
/// Property describing a [double] [value] with an optional [unit] of measurement.
///
/// Numeric formatting is optimized for debug message readability.
/// </Summary>
public class DoubleProperty : FlutterSDK.Foundation.Diagnostics._NumProperty<double>
{
    #region constructors
    public DoubleProperty(string name, double value, string ifNull = default(string), string unit = default(string), string tooltip = default(string), @Object defaultValue = default(@Object), bool showName = true, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, value, ifNull: ifNull, unit: unit, tooltip: tooltip, defaultValue: defaultValue, showName: showName, style: style, level: level)
    {

    }
    public static DoubleProperty Lazy(string name, FlutterSDK.Foundation.Diagnostics.ComputePropertyValueCallback<double> computeValue, string ifNull = default(string), bool showName = true, string unit = default(string), string tooltip = default(string), @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    {
        var instance = new DoubleProperty(name, computeValue, showName: showName, ifNull: ifNull, unit: unit, tooltip: tooltip, defaultValue: defaultValue, level: level);
    }
    #endregion

    #region fields
    #endregion

    #region methods

    public new string NumberToString() => DebugDefaultClass.DebugFormatDouble(Value);


    #endregion
}


/// <Summary>
/// An int valued property with an optional unit the value is measured in.
///
/// Examples of units include 'px' and 'ms'.
/// </Summary>
public class IntProperty : FlutterSDK.Foundation.Diagnostics._NumProperty<int>
{
    #region constructors
    public IntProperty(string name, int value, string ifNull = default(string), bool showName = true, string unit = default(string), @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, value, ifNull: ifNull, showName: showName, unit: unit, defaultValue: defaultValue, level: level)
    {

    }
    #endregion

    #region fields
    #endregion

    #region methods

    public new string NumberToString() => Value.ToString();


    #endregion
}


/// <Summary>
/// Property which clamps a [double] to between 0 and 1 and formats it as a
/// percentage.
/// </Summary>
public class PercentProperty : FlutterSDK.Foundation.Diagnostics.DoubleProperty
{
    #region constructors
    public PercentProperty(string name, double fraction, string ifNull = default(string), bool showName = true, string tooltip = default(string), string unit = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, fraction, ifNull: ifNull, showName: showName, tooltip: tooltip, unit: unit, level: level)
    {

    }
    #endregion

    #region fields
    #endregion

    #region methods

    public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        if (Value == null) return Value.ToString();
        return Unit != null ? $"'{NumberToString()} {Unit}'" : NumberToString();
    }




    public new string NumberToString()
    {
        if (Value == null) return Value.ToString();
        return $"'{(Value.Clamp(0.0, 1.0) * 100.0).ToStringAsFixed(1)}%'";
    }



    #endregion
}


/// <Summary>
/// Property where the description is either [ifTrue] or [ifFalse] depending on
/// whether [value] is true or false.
///
/// Using [FlagProperty] instead of [DiagnosticsProperty<bool>] can make
/// diagnostics display more polished. For example, given a property named
/// `visible` that is typically true, the following code will return 'hidden'
/// when `visible` is false and nothing when visible is true, in contrast to
/// `visible: true` or `visible: false`.
///
/// {@tool snippet}
///
/// ```dart
/// FlagProperty(
///   'visible',
///   value: true,
///   ifFalse: 'hidden',
/// )
/// ```
/// {@end-tool}
/// {@tool snippet}
///
/// [FlagProperty] should also be used instead of [DiagnosticsProperty<bool>]
/// if showing the bool value would not clearly indicate the meaning of the
/// property value.
///
/// ```dart
/// FlagProperty(
///   'inherit',
///   value: inherit,
///   ifTrue: '<all styles inherited>',
///   ifFalse: '<no style specified>',
/// )
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [ObjectFlagProperty], which provides similar behavior describing whether
///    a [value] is null.
/// </Summary>
public class FlagProperty : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<bool>
{
    #region constructors
    public FlagProperty(string name, bool value = default(bool), string ifTrue = default(string), string ifFalse = default(string), bool showName = false, @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, value, showName: showName, defaultValue: defaultValue, level: level)
    {
        this.IfTrue = ifTrue;
        this.IfFalse = ifFalse;
    }
    #endregion

    #region fields
    public virtual string IfTrue { get; set; }
    public virtual string IfFalse { get; set; }
    public virtual bool ShowName { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
    {
        Dictionary<string, object> json = base.ToJsonMap(delegate);
        if (IfTrue != null) json["ifTrue"] = IfTrue;
        if (IfFalse != null) json["ifFalse"] = IfFalse;
        return json;
    }




    public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        if (Value == true)
        {
            if (IfTrue != null) return IfTrue;
        }
        else if (Value == false)
        {
            if (IfFalse != null) return IfFalse;
        }

        return base.ValueToString(parentConfiguration: parentConfiguration);
    }



    #endregion
}


/// <Summary>
/// Property with an `Iterable<T>` [value] that can be displayed with
/// different [DiagnosticsTreeStyle] for custom rendering.
///
/// If [style] is [DiagnosticsTreeStyle.singleLine], the iterable is described
/// as a comma separated list, otherwise the iterable is described as a line
/// break separated list.
/// </Summary>
public class IterableProperty<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<Iterable<T>>
{
    #region constructors
    public IterableProperty(string name, Iterable<T> value, @Object defaultValue = default(@Object), string ifNull = default(string), string ifEmpty = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), bool showName = true, bool showSeparator = true, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, value, defaultValue: defaultValue, ifNull: ifNull, ifEmpty: ifEmpty, style: style, showName: showName, showSeparator: showSeparator, level: level)
    {

    }
    #endregion

    #region fields
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        if (Value == null) return Value.ToString();
        if (Value.IsEmpty()) return IfEmpty ?? "[]";
        Iterable<string> formattedValues = Value.Map((T v) =>
        {
        if (T == Dart:coreDefaultClass.Double && v is double){
            return DebugDefaultClass.DebugFormatDouble(((Double)v));
        }
else
        {
            return v.ToString();
        }

    }
);
if (parentConfiguration!=null &&!parentConfiguration.LineBreakProperties){
return $"'[{formattedValues.Join(", ")}]'";
}

return formattedValues.Join(DiagnosticsDefaultClass._IsSingleLine(Style)?", ":'\n');
}




public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
{
    Dictionary<string, object> json = base.ToJsonMap(delegate);
    if (Value != null)
    {
        json["values"] = Value.Map((T value) => =>value.ToString()).ToList();
    }

    return json;
}



#endregion
}


/// <Summary>
/// An property than displays enum values tersely.
///
/// The enum value is displayed with the class name stripped. For example:
/// [HitTestBehavior.deferToChild] is shown as `deferToChild`.
///
/// See also:
///
///  * [DiagnosticsProperty] which documents named parameters common to all
///    [DiagnosticsProperty].
/// </Summary>
public class EnumProperty<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<T>
{
    #region constructors
    public EnumProperty(string name, T value, @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, value, defaultValue: defaultValue, level: level)
    {

    }
    #endregion

    #region fields
    #endregion

    #region methods

    public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        if (Value == null) return Value.ToString();
        return DiagnosticsDefaultClass.DescribeEnum(Value);
    }



    #endregion
}


/// <Summary>
/// A property where the important diagnostic information is primarily whether
/// the [value] is present (non-null) or absent (null), rather than the actual
/// value of the property itself.
///
/// The [ifPresent] and [ifNull] strings describe the property [value] when it
/// is non-null and null respectively. If one of [ifPresent] or [ifNull] is
/// omitted, that is taken to mean that [level] should be
/// [DiagnosticLevel.hidden] when [value] is non-null or null respectively.
///
/// This kind of diagnostics property is typically used for opaque
/// values, like closures, where presenting the actual object is of dubious
/// value but where reporting the presence or absence of the value is much more
/// useful.
///
/// See also:
///
///
///  * [FlagsSummary], which provides similar functionality but accepts multiple
///    flags under the same name, and is preferred if there are multiple such
///    values that can fit into a same category (such as "listeners").
///  * [FlagProperty], which provides similar functionality describing whether
///    a [value] is true or false.
/// </Summary>
public class ObjectFlagProperty<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<T>
{
    #region constructors
    public ObjectFlagProperty(string name, T value, string ifPresent = default(string), string ifNull = default(string), bool showName = false, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, value, showName: showName, ifNull: ifNull, level: level)
    {
        this.IfPresent = ifPresent;
    }
    public static ObjectFlagProperty<T> Has(string name, T value, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    {
        var instance = new ObjectFlagProperty<T>(name, value, showName: false, level: level);
    }
    #endregion

    #region fields
    public virtual string IfPresent { get; set; }
    public virtual bool ShowName { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        if (Value != null)
        {
            if (IfPresent != null) return IfPresent;
        }
        else
        {
            if (IfNull != null) return IfNull;
        }

        return base.ValueToString(parentConfiguration: parentConfiguration);
    }




    public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
    {
        Dictionary<string, object> json = base.ToJsonMap(delegate);
        if (IfPresent != null) json["ifPresent"] = IfPresent;
        return json;
    }



    #endregion
}


/// <Summary>
/// A summary of multiple properties, indicating whether each of them is present
/// (non-null) or absent (null).
///
/// Each entry of [value] is described by its key. The eventual description will
/// be a list of keys of non-null entries.
///
/// The [ifEmpty] describes the entire collection of [value] when it contains no
/// non-null entries. If [ifEmpty] is omitted, [level] will be
/// [DiagnosticLevel.hidden] when [value] contains no non-null entries.
///
/// This kind of diagnostics property is typically used for opaque
/// values, like closures, where presenting the actual object is of dubious
/// value but where reporting the presence or absence of the value is much more
/// useful.
///
/// See also:
///
///  * [ObjectFlagProperty], which provides similar functionality but accepts
///    only one flag, and is preferred if there is only one entry.
///  * [IterableProperty], which provides similar functionality describing
///    the values a collection of objects.
/// </Summary>
public class FlagsSummary<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<Dictionary<string, T>>
{
    #region constructors
    public FlagsSummary(string name, Dictionary<string, T> value, string ifEmpty = default(string), bool showName = true, bool showSeparator = true, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name, value, ifEmpty: ifEmpty, showName: showName, showSeparator: showSeparator, level: level)
    {

    }
    #endregion

    #region fields
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {

        if (!_HasNonNullEntry() && IfEmpty != null) return IfEmpty;
        Iterable<string> formattedValues = _FormattedValues();
        if (parentConfiguration != null && !parentConfiguration.LineBreakProperties)
        {
            return $"'[{formattedValues.Join(", ")}]'";
        }

        return formattedValues.Join(DiagnosticsDefaultClass._IsSingleLine(Style) ? ", " : '\n');
    }




    public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
    {
        Dictionary<string, object> json = base.ToJsonMap(delegate);
        if (Value.IsNotEmpty) json["values"] = _FormattedValues().ToList();
        return json;
    }




    private bool _HasNonNullEntry() => Value.Values.Any((object o) => =>o != null);



    private Iterable<string> _FormattedValues()
    {
        foreach (DictionaryEntry<string, T> entry in Value.Entries)
        {
            if (entry.Value != null)
            {
                yield return entry.Key;
            }

        }

    }



    #endregion
}


/// <Summary>
/// Property with a [value] of type [T].
///
/// If the default `value.toString()` does not provide an adequate description
/// of the value, specify `description` defining a custom description.
///
/// The [showSeparator] property indicates whether a separator should be placed
/// between the property [name] and its [value].
/// </Summary>
public class DiagnosticsProperty<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsNode
{
    #region constructors
    public DiagnosticsProperty(string name, T value, string description = default(string), string ifNull = default(string), string ifEmpty = default(string), bool showName = true, bool showSeparator = true, @Object defaultValue = default(@Object), string tooltip = default(string), bool missingIfNull = false, string linePrefix = default(string), bool expandableValue = false, bool allowWrap = true, bool allowNameWrap = true, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    : base(name: name, showName: showName, showSeparator: showSeparator, style: style, linePrefix: linePrefix)
    {
        this.IfEmpty = ifEmpty;
        this.DefaultValue = defaultValue;
        this.Tooltip = tooltip;
        this.MissingIfNull = missingIfNull;
        this.ExpandableValue = expandableValue;
        this.AllowWrap = allowWrap;
        this.AllowNameWrap = allowNameWrap;
    }
    public static DiagnosticsProperty<T> Lazy(string name, FlutterSDK.Foundation.Diagnostics.ComputePropertyValueCallback<T> computeValue, string description = default(string), string ifNull = default(string), string ifEmpty = default(string), bool showName = true, bool showSeparator = true, @Object defaultValue = default(@Object), string tooltip = default(string), bool missingIfNull = false, bool expandableValue = false, bool allowWrap = true, bool allowNameWrap = true, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    {
        var instance = new DiagnosticsProperty<T>(name: name, showName: showName, showSeparator: showSeparator, style: style); instance.IfEmpty = ifEmpty;
        instance.DefaultValue = defaultValue;
        instance.Tooltip = tooltip;
        instance.MissingIfNull = missingIfNull;
        instance.ExpandableValue = expandableValue;
        instance.AllowWrap = allowWrap;
        instance.AllowNameWrap = allowNameWrap;
    }
    #endregion

    #region fields
    internal virtual string _Description { get; set; }
    public virtual bool ExpandableValue { get; set; }
    public new bool AllowWrap { get; set; }
    public new bool AllowNameWrap { get; set; }
    public virtual string IfNull { get; set; }
    public virtual string IfEmpty { get; set; }
    public virtual string Tooltip { get; set; }
    public virtual bool MissingIfNull { get; set; }
    internal virtual T _Value { get; set; }
    internal virtual bool _ValueComputed { get; set; }
    internal virtual @Object _Exception { get; set; }
    public virtual @Object DefaultValue { get; set; }
    internal virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel _DefaultLevel { get; set; }
    internal virtual FlutterSDK.Foundation.Diagnostics.ComputePropertyValueCallback<T> _ComputeValue { get; set; }
    public virtual Type PropertyType { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual T Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual @Object Exception { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate)
    {
        T v = Value;
        List<Dictionary<string, object>> properties = default(List<Dictionary<string, object>>);
        if (delegate.ExpandPropertyValues && delegate.IncludeProperties && v is Diagnosticable && GetProperties().IsEmpty())
        {
            delegate= delegate.CopyWith(subtreeDepth: 0, includeProperties: false);
            properties = DiagnosticsDefaultClass.DiagnosticsNode.ToJsonList(delegate.FilterProperties(((Diagnosticable)v).ToDiagnosticsNode().GetProperties(), this), this, delegate);
        }

        Dictionary<string, object> json = base.ToJsonMap(delegate);
        if (properties != null)
        {
            json["properties"] = properties;
        }

        if (DefaultValue != DiagnosticsDefaultClass.KNoDefaultValue) json["defaultValue"] = DefaultValue.ToString();
        if (IfEmpty != null) json["ifEmpty"] = IfEmpty;
        if (IfNull != null) json["ifNull"] = IfNull;
        if (Tooltip != null) json["tooltip"] = Tooltip;
        json["missingIfNull"] = MissingIfNull;
        if (Exception != null) json["exception"] = Exception.ToString();
        json["propertyType"] = PropertyType.ToString();
        json["defaultLevel"] = DiagnosticsDefaultClass.DescribeEnum(_DefaultLevel);
        if (Value is Diagnosticable || Value is DiagnosticsNode) json["isDiagnosticableValue"] = true;
        if (v is Num) json["value"] = v.IsFinite() ? v : v.ToString();
        if (Value is string || Value is bool || Value == null) json["value"] = Value;
        return json;
    }




    /// <Summary>
    /// Returns a string representation of the property value.
    ///
    /// Subclasses should override this method instead of [toDescription] to
    /// customize how property values are converted to strings.
    ///
    /// Overriding this method ensures that behavior controlling how property
    /// values are decorated to generate a nice [toDescription] are consistent
    /// across all implementations. Debugging tools may also choose to use
    /// [valueToString] directly instead of [toDescription].
    ///
    /// `parentConfiguration` specifies how the parent is rendered as text art.
    /// For example, if the parent places all properties on one line, the value
    /// of the property should be displayed without line breaks if possible.
    /// </Summary>
    public virtual string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        T v = Value;
        return (v is DiagnosticableTree ? v.ToStringShort() : v.ToString()) ?? "";
    }




    public new string ToDescription(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
    {
        if (_Description != null) return _AddTooltip(_Description);
        if (Exception != null) return $"'EXCEPTION ({Exception.GetType()})'";
        if (IfNull != null && Value == null) return _AddTooltip(IfNull);
        string result = ValueToString(parentConfiguration: parentConfiguration);
        if (result.IsEmpty() && IfEmpty != null) result = IfEmpty;
        return _AddTooltip(result);
    }




    /// <Summary>
    /// If a [tooltip] is specified, add the tooltip it to the end of `text`
    /// enclosing it parenthesis to disambiguate the tooltip from the rest of
    /// the text.
    ///
    /// `text` must not be null.
    /// </Summary>
    private string _AddTooltip(string text)
    {

        return Tooltip == null ? text : $"'{text} ({Tooltip})'";
    }




    private void _MaybeCacheValue()
    {
        if (_ValueComputed) return;
        _ValueComputed = true;

        try
        {
            _Value = _ComputeValue();
        }
        catch (exception)
        {
            _Exception = exception;
            _Value = null;
        }

    }




    public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetProperties()
    {
        if (ExpandableValue)
        {
            T   object= ((Diagnosticable)Value);
            if (((DiagnosticsNode)object) is DiagnosticsNode)
            {
                return ((DiagnosticsNode)object).GetProperties();
            }

            if (object is Diagnosticable)
            {
                return ((Diagnosticable)object).ToDiagnosticsNode(style: Style).GetProperties();
            }

        }

        return new List, < DiagnosticsNode > (};
}




public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren()
{
    if (ExpandableValue)
    {
        T   object= Value;
        if (((DiagnosticsNode)object) is DiagnosticsNode)
        {
            return ((DiagnosticsNode)object).GetChildren();
        }

        if (object is Diagnosticable)
        {
            return ((Diagnosticable)object).ToDiagnosticsNode(style: Style).GetChildren();
        }

    }

    return new List, < DiagnosticsNode > (};
}



#endregion
}


/// <Summary>
/// [DiagnosticsNode] that lazily calls the associated [Diagnosticable] [value]
/// to implement [getChildren] and [getProperties].
/// </Summary>
public class DiagnosticableNode<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsNode
{
    #region constructors
    public DiagnosticableNode(string name = default(string), T value = default(T), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
    : base(name: name, style: style)
    {
        this.Value = value;
    }
    #endregion

    #region fields
    public new T Value { get; set; }
    internal virtual FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder _CachedBuilder { get; set; }
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder Builder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle Style { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    public virtual string EmptyBodyDescription { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetProperties() => (ConstantsDefaultClass.KReleaseMode || ConstantsDefaultClass.KProfileMode) ? new List, <DiagnosticsNode>(}:Builder.Properties;



public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren()
{
    return new List, < DiagnosticsNode > (};
}




public new string ToDescription(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration))
{
    string result = "";

    return result;
}



#endregion
}


/// <Summary>
/// [DiagnosticsNode] for an instance of [DiagnosticableTree].
/// </Summary>
public class DiagnosticableTreeNode : FlutterSDK.Foundation.Diagnostics.DiagnosticableNode<FlutterSDK.Foundation.Diagnostics.DiagnosticableTree>
{
    #region constructors
    public DiagnosticableTreeNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticableTree value = default(FlutterSDK.Foundation.Diagnostics.DiagnosticableTree), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
    : base(name: name, value: value, style: style)
    {

    }
    #endregion

    #region fields
    #endregion

    #region methods

    public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren()
    {
        if (Value != null) return Value.DebugDescribeChildren();
        return new List, < DiagnosticsNode > (};
}



#endregion
}


/// <Summary>
/// Builder to accumulate properties and configuration used to assemble a
/// [DiagnosticsNode] from a [DiagnosticableMixin] object.
/// </Summary>
public class DiagnosticPropertiesBuilder
{
    #region constructors
    public DiagnosticPropertiesBuilder()
    : base()
    {

    }
    public static DiagnosticPropertiesBuilder FromProperties(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> properties)
    {
        var instance = new DiagnosticPropertiesBuilder(); instance.Properties = properties;
    }
    #endregion

    #region fields
    public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> Properties { get; set; }
    public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle DefaultDiagnosticsTreeStyle { get; set; }
    public virtual string EmptyBodyDescription { get; set; }
    #endregion

    #region methods

    /// <Summary>
    /// Add a property to the list of properties.
    /// </Summary>
    public virtual void Add(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode property)
    {

    }



    #endregion
}


/// <Summary>
/// A base class for providing string and [DiagnosticsNode] debug
/// representations describing the properties and children of an object.
///
/// The string debug representation is generated from the intermediate
/// [DiagnosticsNode] representation. The [DiagnosticsNode] representation is
/// also used by debugging tools displaying interactive trees of objects and
/// properties.
///
/// See also:
///
///  * [DiagnosticableTreeMixin], a mixin that implements this class.
///  * [DiagnosticableMixin], which should be used instead of this class to
///    provide diagnostics for objects without children.
/// </Summary>
public class DiagnosticableTree : IDiagnosticable
{
    #region constructors
    public DiagnosticableTree()
    {

    }
    #endregion

    #region fields
    #endregion

    #region methods

    /// <Summary>
    /// Returns a one-line detailed description of the object.
    ///
    /// This description is often somewhat long. This includes the same
    /// information given by [toStringDeep], but does not recurse to any children.
    ///
    /// `joiner` specifies the string which is place between each part obtained
    /// from [debugFillProperties]. Passing a string such as `'\n '` will result
    /// in a multiline string that indents the properties of the object below its
    /// name (as per [toString]).
    ///
    /// `minLevel` specifies the minimum [DiagnosticLevel] for properties included
    /// in the output.
    ///
    /// See also:
    ///
    ///  * [toString], for a brief description of the object.
    ///  * [toStringDeep], for a description of the subtree rooted at this object.
    /// </Summary>
    public virtual string ToStringShallow(string joiner = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    {
        if (ConstantsDefaultClass.KReleaseMode)
        {
            return ToString();
        }

        string shallowString = default(string);

        return shallowString;
    }




    /// <Summary>
    /// Returns a string representation of this node and its descendants.
    ///
    /// `prefixLineOne` will be added to the front of the first line of the
    /// output. `prefixOtherLines` will be added to the front of each other line.
    /// If `prefixOtherLines` is null, the `prefixLineOne` is used for every line.
    /// By default, there is no prefix.
    ///
    /// `minLevel` specifies the minimum [DiagnosticLevel] for properties included
    /// in the output.
    ///
    /// The [toStringDeep] method takes other arguments, but those are intended
    /// for internal use when recursing to the descendants, and so can be ignored.
    ///
    /// See also:
    ///
    ///  * [toString], for a brief description of the object but not its children.
    ///  * [toStringShallow], for a detailed description of the object but not its
    ///    children.
    /// </Summary>
    public virtual string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
    {
        return ToDiagnosticsNode().ToStringDeep(prefixLineOne: prefixLineOne, prefixOtherLines: prefixOtherLines, minLevel: minLevel);
    }




    public new string ToStringShort() => DiagnosticsDefaultClass.DescribeIdentity(this);



    public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
    {
        return new DiagnosticableTreeNode(name: name, value: this, style: style);
    }




    /// <Summary>
    /// Returns a list of [DiagnosticsNode] objects describing this node's
    /// children.
    ///
    /// Children that are offstage should be added with `style` set to
    /// [DiagnosticsTreeStyle.offstage] to indicate that they are offstage.
    ///
    /// The list must not contain any null entries. If there are explicit null
    /// children to report, consider [new DiagnosticsNode.message] or
    /// [DiagnosticsProperty<Object>] as possible [DiagnosticsNode] objects to
    /// provide.
    ///
    /// Used by [toStringDeep], [toDiagnosticsNode] and [toStringShallow].
    ///
    /// See also:
    ///
    ///  * [RenderTable.debugDescribeChildren], which provides high quality custom
    ///    descriptions for its child nodes.
    /// </Summary>
    public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() => new List, <DiagnosticsNode>(};


#endregion
}


/// <Summary>
/// [DiagnosticsNode] that exists mainly to provide a container for other
/// diagnostics that typically lacks a meaningful value of its own.
///
/// This class is typically used for displaying complex nested error messages.
/// </Summary>
public class DiagnosticsBlock : FlutterSDK.Foundation.Diagnostics.DiagnosticsNode
{
    #region constructors
    public DiagnosticsBlock(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), bool showName = true, bool showSeparator = true, string linePrefix = default(string), @Object value = default(@Object), string description = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel), bool allowTruncate = false, List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> children = default(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode>), List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> properties = default(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode>))
    : base(name: name, style: style, showName: showName && name != null, showSeparator: showSeparator, linePrefix: linePrefix)
    {
        this.Value = value;
        this.Level = level;
        this.AllowTruncate = allowTruncate;
    }
    #endregion

    #region fields
    internal virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _Children { get; set; }
    internal virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> _Properties { get; set; }
    public new FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get; set; }
    internal virtual string _Description { get; set; }
    public new @Object Value { get; set; }
    public new bool AllowTruncate { get; set; }
    #endregion

    #region methods

    public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren() => _Children;



    public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetProperties() => _Properties;



    public new string ToDescription(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) => _Description;


    #endregion
}


public class _DefaultDiagnosticsSerializationDelegate : IDiagnosticsSerializationDelegate
{
    #region constructors
    public _DefaultDiagnosticsSerializationDelegate(bool includeProperties = false, int subtreeDepth = 0)
    {
        this.IncludeProperties = includeProperties;
        this.SubtreeDepth = subtreeDepth;
    }
    #endregion

    #region fields
    public new bool IncludeProperties { get; set; }
    public new int SubtreeDepth { get; set; }
    public virtual bool ExpandPropertyValues { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    #endregion

    #region methods

    public new Dictionary<string, @Object> AdditionalNodeProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node)
    {
        return new Dictionary<string, object> { };
    }




    public new FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate DelegateForNode(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node)
    {
        return SubtreeDepth > 0 ? CopyWith(subtreeDepth: SubtreeDepth - 1) : this;
    }




    public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterChildren(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner)
    {
        return nodes;
    }




    public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterProperties(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner)
    {
        return nodes;
    }




    public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> TruncateNodesList(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner)
    {
        return nodes;
    }




    public new FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate CopyWith(int subtreeDepth = default(int), bool includeProperties = default(bool))
    {
        return new _DefaultDiagnosticsSerializationDelegate(subtreeDepth: subtreeDepth ?? this.SubtreeDepth, includeProperties: includeProperties ?? this.IncludeProperties);
    }



    #endregion
}


/// <Summary>
/// The various priority levels used to filter which diagnostics are shown and
/// omitted.
///
/// Trees of Flutter diagnostics can be very large so filtering the diagnostics
/// shown matters. Typically filtering to only show diagnostics with at least
/// level [debug] is appropriate.
/// </Summary>
public enum DiagnosticLevel
{

    /// <Summary>
    /// Diagnostics that should not be shown.
    ///
    /// If a user chooses to display [hidden] diagnostics, they should not expect
    /// the diagnostics to be formatted consistently with other diagnostics and
    /// they should expect them to sometimes be misleading. For example,
    /// [FlagProperty] and [ObjectFlagProperty] have uglier formatting when the
    /// property `value` does does not match a value with a custom flag
    /// description. An example of a misleading diagnostic is a diagnostic for
    /// a property that has no effect because some other property of the object is
    /// set in a way that causes the hidden property to have no effect.
    /// </Summary>
    Hidden,
    /// <Summary>
    /// A diagnostic that is likely to be low value but where the diagnostic
    /// display is just as high quality as a diagnostic with a higher level.
    ///
    /// Use this level for diagnostic properties that match their default value
    /// and other cases where showing a diagnostic would not add much value such
    /// as an [IterableProperty] where the value is empty.
    /// </Summary>
    Fine,
    /// <Summary>
    /// Diagnostics that should only be shown when performing fine grained
    /// debugging of an object.
    ///
    /// Unlike a [fine] diagnostic, these diagnostics provide important
    /// information about the object that is likely to be needed to debug. Used by
    /// properties that are important but where the property value is too verbose
    /// (e.g. 300+ characters long) to show with a higher diagnostic level.
    /// </Summary>
    Debug,
    /// <Summary>
    /// Interesting diagnostics that should be typically shown.
    /// </Summary>
    Info,
    /// <Summary>
    /// Very important diagnostics that indicate problematic property values.
    ///
    /// For example, use if you would write the property description
    /// message in ALL CAPS.
    /// </Summary>
    Warning,
    /// <Summary>
    /// Diagnostics that provide a hint about best practices.
    ///
    /// For example, a diagnostic describing best practices for fixing an error.
    /// </Summary>
    Hint,
    /// <Summary>
    /// Diagnostics that summarize other diagnostics present.
    ///
    /// For example, use this level for a short one or two line summary
    /// describing other diagnostics present.
    /// </Summary>
    Summary,
    /// <Summary>
    /// Diagnostics that indicate errors or unexpected conditions.
    ///
    /// For example, use for property values where computing the value throws an
    /// exception.
    /// </Summary>
    Error,
    /// <Summary>
    /// Special level indicating that no diagnostics should be shown.
    ///
    /// Do not specify this level for diagnostics. This level is only used to
    /// filter which diagnostics are shown.
    /// </Summary>
    Off,
}


/// <Summary>
/// Styles for displaying a node in a [DiagnosticsNode] tree.
///
/// See also:
///
///  * [DiagnosticsNode.toStringDeep], which dumps text art trees for these
///    styles.
/// </Summary>
public enum DiagnosticsTreeStyle
{

    /// <Summary>
    /// A style that does not display the tree, for release mode.
    /// </Summary>
    None,
    /// <Summary>
    /// Sparse style for displaying trees.
    ///
    /// See also:
    ///
    ///  * [RenderObject], which uses this style.
    /// </Summary>
    Sparse,
    /// <Summary>
    /// Connects a node to its parent with a dashed line.
    ///
    /// See also:
    ///
    ///  * [RenderSliverMultiBoxAdaptor], which uses this style to distinguish
    ///    offstage children from onstage children.
    /// </Summary>
    Offstage,
    /// <Summary>
    /// Slightly more compact version of the [sparse] style.
    ///
    /// See also:
    ///
    ///  * [Element], which uses this style.
    /// </Summary>
    Dense,
    /// <Summary>
    /// Style that enables transitioning from nodes of one style to children of
    /// another.
    ///
    /// See also:
    ///
    ///  * [RenderParagraph], which uses this style to display a [TextSpan] child
    ///    in a way that is compatible with the [DiagnosticsTreeStyle.sparse]
    ///    style of the [RenderObject] tree.
    /// </Summary>
    Transition,
    /// <Summary>
    /// Style for displaying content describing an error.
    ///
    /// See also:
    ///
    ///  * [FlutterError], which uses this style for the root node in a tree
    ///    describing an error.
    /// </Summary>
    Error,
    /// <Summary>
    /// Render the tree just using whitespace without connecting parents to
    /// children using lines.
    ///
    /// See also:
    ///
    ///  * [SliverGeometry], which uses this style.
    /// </Summary>
    Whitespace,
    /// <Summary>
    /// Render the tree without indenting children at all.
    ///
    /// See also:
    ///
    ///  * [DiagnosticsStackTrace], which uses this style.
    /// </Summary>
    Flat,
    /// <Summary>
    /// Render the tree on a single line without showing children.
    /// </Summary>
    SingleLine,
    /// <Summary>
    /// Render the tree using a style appropriate for properties that are part
    /// of an error message.
    ///
    /// The name is placed on one line with the value and properties placed on
    /// the following line.
    ///
    /// See also:
    ///
    ///  * [singleLine], which displays the same information but keeps the
    ///    property and value on the same line.
    /// </Summary>
    ErrorProperty,
    /// <Summary>
    /// Render only the immediate properties of a node instead of the full tree.
    ///
    /// See also:
    ///
    ///  * [DebugOverflowIndicatorMixin], which uses this style to display just
    ///    the immediate children of a node.
    /// </Summary>
    Shallow,
    /// <Summary>
    /// Render only the children of a node truncating before the tree becomes too
    /// large.
    /// </Summary>
    TruncateChildren,
}


public enum _WordWrapParseMode
{

    InSpace,
    InWord,
    AtBreak,
}

}
