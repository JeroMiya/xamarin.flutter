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

        public new string ToStringShort() { throw new NotImplementedException(); }



        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

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

        public virtual string ToStringShort() { throw new NotImplementedException(); }



        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }


        public virtual void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

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


        public new string ToStringShallow(string joiner = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) { throw new NotImplementedException(); }


        public new string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

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

        public virtual Dictionary<string, @Object> AdditionalNodeProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node) { throw new NotImplementedException(); }


        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterChildren(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) { throw new NotImplementedException(); }


        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterProperties(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) { throw new NotImplementedException(); }


        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> TruncateNodesList(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate DelegateForNode(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate CopyWith(int subtreeDepth = default(int), bool includeProperties = default(bool)) { throw new NotImplementedException(); }

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
            this.MandatoryFooter = mandatoryFooter; throw new NotImplementedException();
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


    public class _PrefixedStringBuilder
    {
        #region constructors
        public _PrefixedStringBuilder(string prefixLineOne = default(string), string prefixOtherLines = default(string), int wrapWidth = default(int))
        : base()
        {
            this.PrefixLineOne = prefixLineOne;
            this.WrapWidth = wrapWidth; throw new NotImplementedException();
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

        public virtual void IncrementPrefixOtherLines(string suffix, bool updateCurrentLine = default(bool)) { throw new NotImplementedException(); }


        private void _FinalizeLine(bool addTrailingLineBreak) { throw new NotImplementedException(); }


        private Iterable<string> _WordWrapLine(string message, List<int> wrapRanges, int width, int startOffset = 0, int otherLineOffset = 0) { throw new NotImplementedException(); }


        public virtual void Write(string s, bool allowWrap = false) { throw new NotImplementedException(); }


        private void _UpdatePrefix() { throw new NotImplementedException(); }


        private void _WriteLine(string line, bool includeLineBreak = default(bool), bool firstLine = default(bool)) { throw new NotImplementedException(); }


        private string _GetCurrentPrefix(bool firstLine) { throw new NotImplementedException(); }


        public virtual void WriteRawLines(string lines) { throw new NotImplementedException(); }


        public virtual void WriteStretched(string text, int targetLineLength) { throw new NotImplementedException(); }


        public virtual string Build() { throw new NotImplementedException(); }

        #endregion
    }


    public class _NoDefaultValue
    {
        #region constructors
        public _NoDefaultValue()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    public class TextTreeRenderer
    {
        #region constructors
        public TextTreeRenderer(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel), int wrapWidth = 100, int wrapWidthProperties = 65, int maxDescendentsTruncatableNode = -1)
        : base()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual int _WrapWidth { get; set; }
        internal virtual int _WrapWidthProperties { get; set; }
        internal virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel _MinLevel { get; set; }
        internal virtual int _MaxDescendentsTruncatableNode { get; set; }
        #endregion

        #region methods

        private FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration _ChildTextConfiguration(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode child, FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration textStyle) { throw new NotImplementedException(); }


        public virtual string Render(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node, string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }


        private string _DebugRender(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node, string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }

        #endregion
    }


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
            this.LinePrefix = linePrefix; throw new NotImplementedException();
        }
        public static DiagnosticsNode Message(string message, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel), bool allowWrap = true)
        {
            var instance = new DiagnosticsNode(); throw new NotImplementedException();
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

        public virtual string ToDescription(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }


        public virtual bool IsFiltered(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel) { throw new NotImplementedException(); }


        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetProperties() { throw new NotImplementedException(); }


        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren() { throw new NotImplementedException(); }


        public virtual Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate) { throw new NotImplementedException(); }


        public virtual List<Dictionary<string, @Object>> ToJsonList(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode parent, FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate) { throw new NotImplementedException(); }



        public virtual string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) { throw new NotImplementedException(); }

        #endregion
    }


    public class MessageProperty : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<object>
    {
        #region constructors
        public MessageProperty(string name, string message, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, null, description: message, style: style, level: level)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods
        #endregion
    }


    public class StringProperty : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<string>
    {
        #region constructors
        public StringProperty(string name, string value, string description = default(string), string tooltip = default(string), bool showName = true, @Object defaultValue = default(@Object), bool quoted = true, string ifEmpty = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, description: description, defaultValue: defaultValue, tooltip: tooltip, showName: showName, ifEmpty: ifEmpty, style: style, level: level)
        {
            this.Quoted = quoted; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Quoted { get; set; }
        #endregion

        #region methods

        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate) { throw new NotImplementedException(); }


        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _NumProperty<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<T>
    {
        #region constructors
        public _NumProperty(string name, T value, string ifNull = default(string), string unit = default(string), bool showName = true, @Object defaultValue = default(@Object), string tooltip = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, ifNull: ifNull, showName: showName, defaultValue: defaultValue, tooltip: tooltip, level: level, style: style)
        {
            this.Unit = unit; throw new NotImplementedException();
        }
        public static _NumProperty<T> Lazy(string name, FlutterSDK.Foundation.Diagnostics.ComputePropertyValueCallback<T> computeValue, string ifNull = default(string), string unit = default(string), bool showName = true, @Object defaultValue = default(@Object), string tooltip = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        {
            var instance = new _NumProperty<T>(name, computeValue, ifNull: ifNull, showName: showName, defaultValue: defaultValue, tooltip: tooltip, style: style, level: level); instance.Unit = unit; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual string Unit { get; set; }
        #endregion

        #region methods

        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate) { throw new NotImplementedException(); }


        public virtual string NumberToString() { throw new NotImplementedException(); }


        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }

        #endregion
    }


    public class DoubleProperty : FlutterSDK.Foundation.Diagnostics._NumProperty<double>
    {
        #region constructors
        public DoubleProperty(string name, double value, string ifNull = default(string), string unit = default(string), string tooltip = default(string), @Object defaultValue = default(@Object), bool showName = true, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, ifNull: ifNull, unit: unit, tooltip: tooltip, defaultValue: defaultValue, showName: showName, style: style, level: level)
        {
            throw new NotImplementedException();
        }
        public static DoubleProperty Lazy(string name, FlutterSDK.Foundation.Diagnostics.ComputePropertyValueCallback<double> computeValue, string ifNull = default(string), bool showName = true, string unit = default(string), string tooltip = default(string), @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        {
            var instance = new DoubleProperty(name, computeValue, showName: showName, ifNull: ifNull, unit: unit, tooltip: tooltip, defaultValue: defaultValue, level: level); throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new string NumberToString() { throw new NotImplementedException(); }

        #endregion
    }


    public class IntProperty : FlutterSDK.Foundation.Diagnostics._NumProperty<int>
    {
        #region constructors
        public IntProperty(string name, int value, string ifNull = default(string), bool showName = true, string unit = default(string), @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, ifNull: ifNull, showName: showName, unit: unit, defaultValue: defaultValue, level: level)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new string NumberToString() { throw new NotImplementedException(); }

        #endregion
    }


    public class PercentProperty : FlutterSDK.Foundation.Diagnostics.DoubleProperty
    {
        #region constructors
        public PercentProperty(string name, double fraction, string ifNull = default(string), bool showName = true, string tooltip = default(string), string unit = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, fraction, ifNull: ifNull, showName: showName, tooltip: tooltip, unit: unit, level: level)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }


        public new string NumberToString() { throw new NotImplementedException(); }

        #endregion
    }


    public class FlagProperty : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<bool>
    {
        #region constructors
        public FlagProperty(string name, bool value = default(bool), string ifTrue = default(string), string ifFalse = default(string), bool showName = false, @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, showName: showName, defaultValue: defaultValue, level: level)
        {
            this.IfTrue = ifTrue;
            this.IfFalse = ifFalse; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual string IfTrue { get; set; }
        public virtual string IfFalse { get; set; }
        public virtual bool ShowName { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate) { throw new NotImplementedException(); }


        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }

        #endregion
    }


    public class IterableProperty<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<Iterable<T>>
    {
        #region constructors
        public IterableProperty(string name, Iterable<T> value, @Object defaultValue = default(@Object), string ifNull = default(string), string ifEmpty = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), bool showName = true, bool showSeparator = true, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, defaultValue: defaultValue, ifNull: ifNull, ifEmpty: ifEmpty, style: style, showName: showName, showSeparator: showSeparator, level: level)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }


        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate) { throw new NotImplementedException(); }

        #endregion
    }


    public class EnumProperty<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<T>
    {
        #region constructors
        public EnumProperty(string name, T value, @Object defaultValue = default(@Object), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, defaultValue: defaultValue, level: level)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }

        #endregion
    }


    public class ObjectFlagProperty<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<T>
    {
        #region constructors
        public ObjectFlagProperty(string name, T value, string ifPresent = default(string), string ifNull = default(string), bool showName = false, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, showName: showName, ifNull: ifNull, level: level)
        {
            this.IfPresent = ifPresent; throw new NotImplementedException();
        }
        public static ObjectFlagProperty<T> Has(string name, T value, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        {
            var instance = new ObjectFlagProperty<T>(name, value, showName: false, level: level); throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual string IfPresent { get; set; }
        public virtual bool ShowName { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }


        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate) { throw new NotImplementedException(); }

        #endregion
    }


    public class FlagsSummary<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsProperty<Dictionary<string, T>>
    {
        #region constructors
        public FlagsSummary(string name, Dictionary<string, T> value, string ifEmpty = default(string), bool showName = true, bool showSeparator = true, FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        : base(name, value, ifEmpty: ifEmpty, showName: showName, showSeparator: showSeparator, level: level)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticLevel Level { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }


        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate) { throw new NotImplementedException(); }


        private bool _HasNonNullEntry() { throw new NotImplementedException(); }


        private Iterable<string> _FormattedValues() { throw new NotImplementedException(); }

        #endregion
    }


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
            this.AllowNameWrap = allowNameWrap; throw new NotImplementedException();
        }
        public static DiagnosticsProperty<T> Lazy(string name, FlutterSDK.Foundation.Diagnostics.ComputePropertyValueCallback<T> computeValue, string description = default(string), string ifNull = default(string), string ifEmpty = default(string), bool showName = true, bool showSeparator = true, @Object defaultValue = default(@Object), string tooltip = default(string), bool missingIfNull = false, bool expandableValue = false, bool allowWrap = true, bool allowNameWrap = true, FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel))
        {
            var instance = new DiagnosticsProperty<T>(name: name, showName: showName, showSeparator: showSeparator, style: style); instance.IfEmpty = ifEmpty;
            instance.DefaultValue = defaultValue;
            instance.Tooltip = tooltip;
            instance.MissingIfNull = missingIfNull;
            instance.ExpandableValue = expandableValue;
            instance.AllowWrap = allowWrap;
            instance.AllowNameWrap = allowNameWrap; throw new NotImplementedException();
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

        public new Dictionary<string, @Object> ToJsonMap(FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate @delegate) { throw new NotImplementedException(); }


        public virtual string ValueToString(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }


        public new string ToDescription(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }


        private string _AddTooltip(string text) { throw new NotImplementedException(); }


        private void _MaybeCacheValue() { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetProperties() { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren() { throw new NotImplementedException(); }

        #endregion
    }


    public class DiagnosticableNode<T> : FlutterSDK.Foundation.Diagnostics.DiagnosticsNode
    {
        #region constructors
        public DiagnosticableNode(string name = default(string), T value = default(T), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        : base(name: name, style: style)
        {
            this.Value = value; throw new NotImplementedException();
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

        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetProperties() { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren() { throw new NotImplementedException(); }


        public new string ToDescription(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }

        #endregion
    }


    public class DiagnosticableTreeNode : FlutterSDK.Foundation.Diagnostics.DiagnosticableNode<FlutterSDK.Foundation.Diagnostics.DiagnosticableTree>
    {
        #region constructors
        public DiagnosticableTreeNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticableTree value = default(FlutterSDK.Foundation.Diagnostics.DiagnosticableTree), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle))
        : base(name: name, value: value, style: style)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren() { throw new NotImplementedException(); }

        #endregion
    }


    public class DiagnosticPropertiesBuilder
    {
        #region constructors
        public DiagnosticPropertiesBuilder()
        : base()
        {
            throw new NotImplementedException();
        }
        public static DiagnosticPropertiesBuilder FromProperties(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> properties)
        {
            var instance = new DiagnosticPropertiesBuilder(); instance.Properties = properties; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> Properties { get; set; }
        public virtual FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle DefaultDiagnosticsTreeStyle { get; set; }
        public virtual string EmptyBodyDescription { get; set; }
        #endregion

        #region methods

        public virtual void Add(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode property) { throw new NotImplementedException(); }

        #endregion
    }


    public class DiagnosticableTree : IDiagnosticable
    {
        #region constructors
        public DiagnosticableTree()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public virtual string ToStringShallow(string joiner = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) { throw new NotImplementedException(); }


        public virtual string ToStringDeep(string prefixLineOne = default(string), string prefixOtherLines = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel minLevel = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel)) { throw new NotImplementedException(); }


        public new string ToStringShort() { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsNode ToDiagnosticsNode(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle)) { throw new NotImplementedException(); }


        public virtual List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }

        #endregion
    }


    public class DiagnosticsBlock : FlutterSDK.Foundation.Diagnostics.DiagnosticsNode
    {
        #region constructors
        public DiagnosticsBlock(string name = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle style = default(FlutterSDK.Foundation.Diagnostics.DiagnosticsTreeStyle), bool showName = true, bool showSeparator = true, string linePrefix = default(string), @Object value = default(@Object), string description = default(string), FlutterSDK.Foundation.Diagnostics.DiagnosticLevel level = default(FlutterSDK.Foundation.Diagnostics.DiagnosticLevel), bool allowTruncate = false, List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> children = default(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode>), List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> properties = default(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode>))
        : base(name: name, style: style, showName: showName && name != null, showSeparator: showSeparator, linePrefix: linePrefix)
        {
            this.Value = value;
            this.Level = level;
            this.AllowTruncate = allowTruncate; throw new NotImplementedException();
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

        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetChildren() { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> GetProperties() { throw new NotImplementedException(); }


        public new string ToDescription(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration parentConfiguration = default(FlutterSDK.Foundation.Diagnostics.TextTreeConfiguration)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _DefaultDiagnosticsSerializationDelegate : IDiagnosticsSerializationDelegate
    {
        #region constructors
        public _DefaultDiagnosticsSerializationDelegate(bool includeProperties = false, int subtreeDepth = 0)
        {
            this.IncludeProperties = includeProperties;
            this.SubtreeDepth = subtreeDepth; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public new bool IncludeProperties { get; set; }
        public new int SubtreeDepth { get; set; }
        public virtual bool ExpandPropertyValues { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new Dictionary<string, @Object> AdditionalNodeProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node) { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate DelegateForNode(FlutterSDK.Foundation.Diagnostics.DiagnosticsNode node) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterChildren(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> FilterProperties(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> TruncateNodesList(List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> nodes, FlutterSDK.Foundation.Diagnostics.DiagnosticsNode owner) { throw new NotImplementedException(); }


        public new FlutterSDK.Foundation.Diagnostics.DiagnosticsSerializationDelegate CopyWith(int subtreeDepth = default(int), bool includeProperties = default(bool)) { throw new NotImplementedException(); }

        #endregion
    }


    public enum DiagnosticLevel
    {

        Hidden,
        Fine,
        Debug,
        Info,
        Warning,
        Hint,
        Summary,
        Error,
        Off,
    }


    public enum DiagnosticsTreeStyle
    {

        None,
        Sparse,
        Offstage,
        Dense,
        Transition,
        Error,
        Whitespace,
        Flat,
        SingleLine,
        ErrorProperty,
        Shallow,
        TruncateChildren,
    }


    public enum _WordWrapParseMode
    {

        InSpace,
        InWord,
        AtBreak,
    }

}
