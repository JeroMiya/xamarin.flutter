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
namespace FlutterSDK.Material.Chip
{
    internal static class ChipDefaultClass
    {
        public static double _KChipHeight = default(double);
        public static double _KDeleteIconSize = default(double);
        public static int _KCheckmarkAlpha = default(int);
        public static int _KDisabledAlpha = default(int);
        public static double _KCheckmarkStrokeWidth = default(double);
        public static TimeSpan _KSelectDuration = default(TimeSpan);
        public static TimeSpan _KCheckmarkDuration = default(TimeSpan);
        public static TimeSpan _KCheckmarkReverseDuration = default(TimeSpan);
        public static TimeSpan _KDrawerDuration = default(TimeSpan);
        public static TimeSpan _KReverseDrawerDuration = default(TimeSpan);
        public static TimeSpan _KDisableDuration = default(TimeSpan);
        public static Color _KSelectScrimColor = default(Color);
        public static FlutterSDK.Widgets.Icon.Icon _KDefaultDeleteIcon = default(FlutterSDK.Widgets.Icon.Icon);
        internal static bool _TapIsOnDeleteIcon(bool hasDeleteButton = default(bool), FlutterBinding.UI.Offset tapPosition = default(FlutterBinding.UI.Offset), Size chipSize = default(Size), TextDirection textDirection = default(TextDirection))
        {
            throw new NotImplementedException();
        }

    }

    public interface IChipAttributes { }

    public class ChipAttributes
    {
        public virtual FlutterSDK.Widgets.Framework.Widget Label { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.Widget Avatar { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder Shape { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Clip ClipBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Autofocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color BackgroundColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double Elevation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color ShadowColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }
    public static class ChipAttributesMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IChipAttributes, ChipAttributes> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IChipAttributes, ChipAttributes>();
        static ChipAttributes GetOrCreate(IChipAttributes instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new ChipAttributes();
                _table.Add(instance, value);
            }
            return (ChipAttributes)value;
        }
        public static FlutterSDK.Widgets.Framework.Widget LabelProperty(this IChipAttributes instance) => GetOrCreate(instance).Label;
        public static FlutterSDK.Widgets.Framework.Widget AvatarProperty(this IChipAttributes instance) => GetOrCreate(instance).Avatar;
        public static FlutterSDK.Painting.Textstyle.TextStyle LabelStyleProperty(this IChipAttributes instance) => GetOrCreate(instance).LabelStyle;
        public static FlutterSDK.Painting.Borders.ShapeBorder ShapeProperty(this IChipAttributes instance) => GetOrCreate(instance).Shape;
        public static FlutterBinding.UI.Clip ClipBehaviorProperty(this IChipAttributes instance) => GetOrCreate(instance).ClipBehavior;
        public static FlutterSDK.Widgets.Focusmanager.FocusNode FocusNodeProperty(this IChipAttributes instance) => GetOrCreate(instance).FocusNode;
        public static bool AutofocusProperty(this IChipAttributes instance) => GetOrCreate(instance).Autofocus;
        public static FlutterBinding.UI.Color BackgroundColorProperty(this IChipAttributes instance) => GetOrCreate(instance).BackgroundColor;
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry PaddingProperty(this IChipAttributes instance) => GetOrCreate(instance).Padding;
        public static FlutterSDK.Material.Themedata.VisualDensity VisualDensityProperty(this IChipAttributes instance) => GetOrCreate(instance).VisualDensity;
        public static FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPaddingProperty(this IChipAttributes instance) => GetOrCreate(instance).LabelPadding;
        public static FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSizeProperty(this IChipAttributes instance) => GetOrCreate(instance).MaterialTapTargetSize;
        public static double ElevationProperty(this IChipAttributes instance) => GetOrCreate(instance).Elevation;
        public static FlutterBinding.UI.Color ShadowColorProperty(this IChipAttributes instance) => GetOrCreate(instance).ShadowColor;
    }


    public interface IDeletableChipAttributes { }

    public class DeletableChipAttributes
    {
        public virtual FlutterSDK.Widgets.Framework.Widget DeleteIcon { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual VoidCallback OnDeleted { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color DeleteIconColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DeleteButtonTooltipMessage { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }
    public static class DeletableChipAttributesMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IDeletableChipAttributes, DeletableChipAttributes> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IDeletableChipAttributes, DeletableChipAttributes>();
        static DeletableChipAttributes GetOrCreate(IDeletableChipAttributes instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new DeletableChipAttributes();
                _table.Add(instance, value);
            }
            return (DeletableChipAttributes)value;
        }
        public static FlutterSDK.Widgets.Framework.Widget DeleteIconProperty(this IDeletableChipAttributes instance) => GetOrCreate(instance).DeleteIcon;
        public static VoidCallback OnDeletedProperty(this IDeletableChipAttributes instance) => GetOrCreate(instance).OnDeleted;
        public static FlutterBinding.UI.Color DeleteIconColorProperty(this IDeletableChipAttributes instance) => GetOrCreate(instance).DeleteIconColor;
        public static string DeleteButtonTooltipMessageProperty(this IDeletableChipAttributes instance) => GetOrCreate(instance).DeleteButtonTooltipMessage;
    }


    public interface ICheckmarkableChipAttributes { }

    public class CheckmarkableChipAttributes
    {
        public virtual bool ShowCheckmark { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color CheckmarkColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }
    public static class CheckmarkableChipAttributesMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<ICheckmarkableChipAttributes, CheckmarkableChipAttributes> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ICheckmarkableChipAttributes, CheckmarkableChipAttributes>();
        static CheckmarkableChipAttributes GetOrCreate(ICheckmarkableChipAttributes instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new CheckmarkableChipAttributes();
                _table.Add(instance, value);
            }
            return (CheckmarkableChipAttributes)value;
        }
        public static bool ShowCheckmarkProperty(this ICheckmarkableChipAttributes instance) => GetOrCreate(instance).ShowCheckmark;
        public static FlutterBinding.UI.Color CheckmarkColorProperty(this ICheckmarkableChipAttributes instance) => GetOrCreate(instance).CheckmarkColor;
    }


    public interface ISelectableChipAttributes { }

    public class SelectableChipAttributes
    {
        public virtual bool Selected { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnSelected { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double PressElevation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color SelectedColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color SelectedShadowColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string Tooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder AvatarBorder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }
    public static class SelectableChipAttributesMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<ISelectableChipAttributes, SelectableChipAttributes> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ISelectableChipAttributes, SelectableChipAttributes>();
        static SelectableChipAttributes GetOrCreate(ISelectableChipAttributes instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new SelectableChipAttributes();
                _table.Add(instance, value);
            }
            return (SelectableChipAttributes)value;
        }
        public static bool SelectedProperty(this ISelectableChipAttributes instance) => GetOrCreate(instance).Selected;
        public static FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnSelectedProperty(this ISelectableChipAttributes instance) => GetOrCreate(instance).OnSelected;
        public static double PressElevationProperty(this ISelectableChipAttributes instance) => GetOrCreate(instance).PressElevation;
        public static FlutterBinding.UI.Color SelectedColorProperty(this ISelectableChipAttributes instance) => GetOrCreate(instance).SelectedColor;
        public static FlutterBinding.UI.Color SelectedShadowColorProperty(this ISelectableChipAttributes instance) => GetOrCreate(instance).SelectedShadowColor;
        public static string TooltipProperty(this ISelectableChipAttributes instance) => GetOrCreate(instance).Tooltip;
        public static FlutterSDK.Painting.Borders.ShapeBorder AvatarBorderProperty(this ISelectableChipAttributes instance) => GetOrCreate(instance).AvatarBorder;
    }


    public interface IDisabledChipAttributes { }

    public class DisabledChipAttributes
    {
        public virtual bool IsEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color DisabledColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }
    public static class DisabledChipAttributesMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<IDisabledChipAttributes, DisabledChipAttributes> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IDisabledChipAttributes, DisabledChipAttributes>();
        static DisabledChipAttributes GetOrCreate(IDisabledChipAttributes instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new DisabledChipAttributes();
                _table.Add(instance, value);
            }
            return (DisabledChipAttributes)value;
        }
        public static bool IsEnabledProperty(this IDisabledChipAttributes instance) => GetOrCreate(instance).IsEnabled;
        public static FlutterBinding.UI.Color DisabledColorProperty(this IDisabledChipAttributes instance) => GetOrCreate(instance).DisabledColor;
    }


    public interface ITappableChipAttributes { }

    public class TappableChipAttributes
    {
        public virtual VoidCallback OnPressed { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual double PressElevation { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string Tooltip { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }
    public static class TappableChipAttributesMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<ITappableChipAttributes, TappableChipAttributes> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ITappableChipAttributes, TappableChipAttributes>();
        static TappableChipAttributes GetOrCreate(ITappableChipAttributes instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new TappableChipAttributes();
                _table.Add(instance, value);
            }
            return (TappableChipAttributes)value;
        }
        public static VoidCallback OnPressedProperty(this ITappableChipAttributes instance) => GetOrCreate(instance).OnPressed;
        public static double PressElevationProperty(this ITappableChipAttributes instance) => GetOrCreate(instance).PressElevation;
        public static string TooltipProperty(this ITappableChipAttributes instance) => GetOrCreate(instance).Tooltip;
    }


    public class Chip : FlutterSDK.Widgets.Framework.StatelessWidget, IChipAttributes, IDeletableChipAttributes
    {
        #region constructors
        public Chip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget deleteIcon = default(FlutterSDK.Widgets.Framework.Widget), VoidCallback onDeleted = default(VoidCallback), FlutterBinding.UI.Color deleteIconColor = default(FlutterBinding.UI.Color), string deleteButtonTooltipMessage = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Avatar = avatar;
            this.Label = label;
            this.LabelStyle = labelStyle;
            this.LabelPadding = labelPadding;
            this.DeleteIcon = deleteIcon;
            this.OnDeleted = onDeleted;
            this.DeleteIconColor = deleteIconColor;
            this.DeleteButtonTooltipMessage = deleteButtonTooltipMessage;
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.BackgroundColor = backgroundColor;
            this.Padding = padding;
            this.VisualDensity = visualDensity;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.Elevation = elevation;
            this.ShadowColor = shadowColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public new FlutterSDK.Widgets.Framework.Widget Avatar { get; set; }
        public new FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public new FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get; set; }
        public new FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public new FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public new FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public new bool Autofocus { get; set; }
        public new FlutterBinding.UI.Color BackgroundColor { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public new FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public new FlutterSDK.Widgets.Framework.Widget DeleteIcon { get; set; }
        public new VoidCallback OnDeleted { get; set; }
        public new FlutterBinding.UI.Color DeleteIconColor { get; set; }
        public new string DeleteButtonTooltipMessage { get; set; }
        public new FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        public new double Elevation { get; set; }
        public new FlutterBinding.UI.Color ShadowColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class InputChip : FlutterSDK.Widgets.Framework.StatelessWidget, IChipAttributes, IDeletableChipAttributes, ISelectableChipAttributes, ICheckmarkableChipAttributes, IDisabledChipAttributes, ITappableChipAttributes
    {
        #region constructors
        public InputChip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool selected = false, bool isEnabled = true, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelected = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Widgets.Framework.Widget deleteIcon = default(FlutterSDK.Widgets.Framework.Widget), VoidCallback onDeleted = default(VoidCallback), FlutterBinding.UI.Color deleteIconColor = default(FlutterBinding.UI.Color), string deleteButtonTooltipMessage = default(string), VoidCallback onPressed = default(VoidCallback), double pressElevation = default(double), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), string tooltip = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), bool showCheckmark = default(bool), FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base(key: key)
        {
            this.Avatar = avatar;
            this.Label = label;
            this.LabelStyle = labelStyle;
            this.LabelPadding = labelPadding;
            this.Selected = selected;
            this.IsEnabled = isEnabled;
            this.OnSelected = onSelected;
            this.DeleteIcon = deleteIcon;
            this.OnDeleted = onDeleted;
            this.DeleteIconColor = deleteIconColor;
            this.DeleteButtonTooltipMessage = deleteButtonTooltipMessage;
            this.OnPressed = onPressed;
            this.PressElevation = pressElevation;
            this.DisabledColor = disabledColor;
            this.SelectedColor = selectedColor;
            this.Tooltip = tooltip;
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.BackgroundColor = backgroundColor;
            this.Padding = padding;
            this.VisualDensity = visualDensity;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.Elevation = elevation;
            this.ShadowColor = shadowColor;
            this.SelectedShadowColor = selectedShadowColor;
            this.ShowCheckmark = showCheckmark;
            this.CheckmarkColor = checkmarkColor;
            this.AvatarBorder = avatarBorder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public new FlutterSDK.Widgets.Framework.Widget Avatar { get; set; }
        public new FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public new FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get; set; }
        public new bool Selected { get; set; }
        public new bool IsEnabled { get; set; }
        public new FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnSelected { get; set; }
        public new FlutterSDK.Widgets.Framework.Widget DeleteIcon { get; set; }
        public new VoidCallback OnDeleted { get; set; }
        public new FlutterBinding.UI.Color DeleteIconColor { get; set; }
        public new string DeleteButtonTooltipMessage { get; set; }
        public new VoidCallback OnPressed { get; set; }
        public new double PressElevation { get; set; }
        public new FlutterBinding.UI.Color DisabledColor { get; set; }
        public new FlutterBinding.UI.Color SelectedColor { get; set; }
        public new string Tooltip { get; set; }
        public new FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public new FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public new FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public new bool Autofocus { get; set; }
        public new FlutterBinding.UI.Color BackgroundColor { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public new FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public new FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        public new double Elevation { get; set; }
        public new FlutterBinding.UI.Color ShadowColor { get; set; }
        public new FlutterBinding.UI.Color SelectedShadowColor { get; set; }
        public new bool ShowCheckmark { get; set; }
        public new FlutterBinding.UI.Color CheckmarkColor { get; set; }
        public new FlutterSDK.Painting.Borders.ShapeBorder AvatarBorder { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class ChoiceChip : FlutterSDK.Widgets.Framework.StatelessWidget, IChipAttributes, ISelectableChipAttributes, IDisabledChipAttributes
    {
        #region constructors
        public ChoiceChip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelected = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), double pressElevation = default(double), bool selected = default(bool), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), string tooltip = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base(key: key)
        {
            this.Avatar = avatar;
            this.Label = label;
            this.LabelStyle = labelStyle;
            this.LabelPadding = labelPadding;
            this.OnSelected = onSelected;
            this.PressElevation = pressElevation;
            this.Selected = selected;
            this.SelectedColor = selectedColor;
            this.DisabledColor = disabledColor;
            this.Tooltip = tooltip;
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.BackgroundColor = backgroundColor;
            this.Padding = padding;
            this.VisualDensity = visualDensity;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.Elevation = elevation;
            this.ShadowColor = shadowColor;
            this.SelectedShadowColor = selectedShadowColor;
            this.AvatarBorder = avatarBorder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public new FlutterSDK.Widgets.Framework.Widget Avatar { get; set; }
        public new FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public new FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get; set; }
        public new FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnSelected { get; set; }
        public new double PressElevation { get; set; }
        public new bool Selected { get; set; }
        public new FlutterBinding.UI.Color DisabledColor { get; set; }
        public new FlutterBinding.UI.Color SelectedColor { get; set; }
        public new string Tooltip { get; set; }
        public new FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public new FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public new FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public new bool Autofocus { get; set; }
        public new FlutterBinding.UI.Color BackgroundColor { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public new FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public new FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        public new double Elevation { get; set; }
        public new FlutterBinding.UI.Color ShadowColor { get; set; }
        public new FlutterBinding.UI.Color SelectedShadowColor { get; set; }
        public new FlutterSDK.Painting.Borders.ShapeBorder AvatarBorder { get; set; }
        public virtual bool IsEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class FilterChip : FlutterSDK.Widgets.Framework.StatelessWidget, IChipAttributes, ISelectableChipAttributes, ICheckmarkableChipAttributes, IDisabledChipAttributes
    {
        #region constructors
        public FilterChip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool selected = false, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelected = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), double pressElevation = default(double), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), string tooltip = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), bool showCheckmark = default(bool), FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base(key: key)
        {
            this.Avatar = avatar;
            this.Label = label;
            this.LabelStyle = labelStyle;
            this.LabelPadding = labelPadding;
            this.Selected = selected;
            this.OnSelected = onSelected;
            this.PressElevation = pressElevation;
            this.DisabledColor = disabledColor;
            this.SelectedColor = selectedColor;
            this.Tooltip = tooltip;
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.BackgroundColor = backgroundColor;
            this.Padding = padding;
            this.VisualDensity = visualDensity;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.Elevation = elevation;
            this.ShadowColor = shadowColor;
            this.SelectedShadowColor = selectedShadowColor;
            this.ShowCheckmark = showCheckmark;
            this.CheckmarkColor = checkmarkColor;
            this.AvatarBorder = avatarBorder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public new FlutterSDK.Widgets.Framework.Widget Avatar { get; set; }
        public new FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public new FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get; set; }
        public new bool Selected { get; set; }
        public new FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnSelected { get; set; }
        public new double PressElevation { get; set; }
        public new FlutterBinding.UI.Color DisabledColor { get; set; }
        public new FlutterBinding.UI.Color SelectedColor { get; set; }
        public new string Tooltip { get; set; }
        public new FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public new FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public new FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public new bool Autofocus { get; set; }
        public new FlutterBinding.UI.Color BackgroundColor { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public new FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public new FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        public new double Elevation { get; set; }
        public new FlutterBinding.UI.Color ShadowColor { get; set; }
        public new FlutterBinding.UI.Color SelectedShadowColor { get; set; }
        public new bool ShowCheckmark { get; set; }
        public new FlutterBinding.UI.Color CheckmarkColor { get; set; }
        public new FlutterSDK.Painting.Borders.ShapeBorder AvatarBorder { get; set; }
        public virtual bool IsEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class ActionChip : FlutterSDK.Widgets.Framework.StatelessWidget, IChipAttributes, ITappableChipAttributes
    {
        #region constructors
        public ActionChip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), VoidCallback onPressed = default(VoidCallback), double pressElevation = default(double), string tooltip = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
        : base(key: key)
        {
            this.Avatar = avatar;
            this.Label = label;
            this.LabelStyle = labelStyle;
            this.LabelPadding = labelPadding;
            this.OnPressed = onPressed;
            this.PressElevation = pressElevation;
            this.Tooltip = tooltip;
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.BackgroundColor = backgroundColor;
            this.Padding = padding;
            this.VisualDensity = visualDensity;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.Elevation = elevation;
            this.ShadowColor = shadowColor; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public new FlutterSDK.Widgets.Framework.Widget Avatar { get; set; }
        public new FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public new FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get; set; }
        public new VoidCallback OnPressed { get; set; }
        public new double PressElevation { get; set; }
        public new string Tooltip { get; set; }
        public new FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public new FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public new FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public new bool Autofocus { get; set; }
        public new FlutterBinding.UI.Color BackgroundColor { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public new FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public new FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        public new double Elevation { get; set; }
        public new FlutterBinding.UI.Color ShadowColor { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class RawChip : FlutterSDK.Widgets.Framework.StatefulWidget, IChipAttributes, IDeletableChipAttributes, ISelectableChipAttributes, ICheckmarkableChipAttributes, IDisabledChipAttributes, ITappableChipAttributes
    {
        #region constructors
        public RawChip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget deleteIcon = default(FlutterSDK.Widgets.Framework.Widget), VoidCallback onDeleted = default(VoidCallback), FlutterBinding.UI.Color deleteIconColor = default(FlutterBinding.UI.Color), string deleteButtonTooltipMessage = default(string), VoidCallback onPressed = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelected = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), double pressElevation = default(double), bool tapEnabled = true, bool selected = false, bool isEnabled = true, FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), string tooltip = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), bool showCheckmark = true, FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base(key: key)
        {
            this.Avatar = avatar;
            this.Label = label;
            this.LabelStyle = labelStyle;
            this.Padding = padding;
            this.VisualDensity = visualDensity;
            this.LabelPadding = labelPadding;
            this.OnDeleted = onDeleted;
            this.DeleteIconColor = deleteIconColor;
            this.DeleteButtonTooltipMessage = deleteButtonTooltipMessage;
            this.OnPressed = onPressed;
            this.OnSelected = onSelected;
            this.PressElevation = pressElevation;
            this.TapEnabled = tapEnabled;
            this.Selected = selected;
            this.IsEnabled = isEnabled;
            this.DisabledColor = disabledColor;
            this.SelectedColor = selectedColor;
            this.Tooltip = tooltip;
            this.Shape = shape;
            this.ClipBehavior = clipBehavior;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus;
            this.BackgroundColor = backgroundColor;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.Elevation = elevation;
            this.ShadowColor = shadowColor;
            this.SelectedShadowColor = selectedShadowColor;
            this.ShowCheckmark = showCheckmark;
            this.CheckmarkColor = checkmarkColor;
            this.AvatarBorder = avatarBorder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public new FlutterSDK.Widgets.Framework.Widget Avatar { get; set; }
        public new FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public new FlutterSDK.Painting.Textstyle.TextStyle LabelStyle { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry LabelPadding { get; set; }
        public new FlutterSDK.Widgets.Framework.Widget DeleteIcon { get; set; }
        public new VoidCallback OnDeleted { get; set; }
        public new FlutterBinding.UI.Color DeleteIconColor { get; set; }
        public new string DeleteButtonTooltipMessage { get; set; }
        public new FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnSelected { get; set; }
        public new VoidCallback OnPressed { get; set; }
        public new double PressElevation { get; set; }
        public new bool Selected { get; set; }
        public new bool IsEnabled { get; set; }
        public new FlutterBinding.UI.Color DisabledColor { get; set; }
        public new FlutterBinding.UI.Color SelectedColor { get; set; }
        public new string Tooltip { get; set; }
        public new FlutterSDK.Painting.Borders.ShapeBorder Shape { get; set; }
        public new FlutterBinding.UI.Clip ClipBehavior { get; set; }
        public new FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public new bool Autofocus { get; set; }
        public new FlutterBinding.UI.Color BackgroundColor { get; set; }
        public new FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        public new FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public new FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        public new double Elevation { get; set; }
        public new FlutterBinding.UI.Color ShadowColor { get; set; }
        public new FlutterBinding.UI.Color SelectedShadowColor { get; set; }
        public new bool ShowCheckmark { get; set; }
        public new FlutterBinding.UI.Color CheckmarkColor { get; set; }
        public new FlutterSDK.Painting.Borders.ShapeBorder AvatarBorder { get; set; }
        public virtual bool TapEnabled { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Chip._RawChipState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _RawChipState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Chip.RawChip>, ITickerProviderStateMixin<FlutterSDK.Material.Chip.RawChip>
    {
        #region constructors
        public _RawChipState()
        { }
        #endregion

        #region fields
        public virtual TimeSpan PressedAnimationDuration { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController SelectController { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController AvatarDrawerController { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController DeleteDrawerController { get; set; }
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController EnableController { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> CheckmarkAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> AvatarDrawerAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> DeleteDrawerAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> EnableAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> SelectionFade { get; set; }
        internal virtual HashSet<FlutterSDK.Material.Materialstate.MaterialState> _States { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> DeleteIconKey { get; set; }
        internal virtual bool _IsTapping { get; set; }
        internal virtual double _DefaultElevation { get; set; }
        internal virtual double _DefaultPressElevation { get; set; }
        internal virtual FlutterBinding.UI.Color _DefaultShadowColor { get; set; }
        public virtual bool HasDeleteButton { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasAvatar { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CanTap { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsTapping { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _UpdateState(FlutterSDK.Material.Materialstate.MaterialState state, bool value) { throw new NotImplementedException(); }


        private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details) { throw new NotImplementedException(); }


        private void _HandleTapCancel() { throw new NotImplementedException(); }


        private void _HandleTap() { throw new NotImplementedException(); }


        private void _HandleFocus(bool isFocused) { throw new NotImplementedException(); }


        private void _HandleHover(bool isHovered) { throw new NotImplementedException(); }


        public virtual Color GetBackgroundColor(FlutterSDK.Material.Chiptheme.ChipThemeData theme) { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Material.Chip.RawChip oldWidget) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _WrapWithTooltip(string tooltip, VoidCallback callback, FlutterSDK.Widgets.Framework.Widget child) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildDeleteIcon(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Themedata.ThemeData theme, FlutterSDK.Material.Chiptheme.ChipThemeData chipTheme, FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> deleteIconKey) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ChipRedirectingHitDetectionWidget : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
    {
        #region constructors
        public _ChipRedirectingHitDetectionWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints))
        : base(key: key, child: child)
        {
            this.Constraints = constraints; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Chip._RenderChipRedirectingHitDetection renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderChipRedirectingHitDetection : FlutterSDK.Rendering.Proxybox.RenderConstrainedBox
    {
        #region constructors
        public _RenderChipRedirectingHitDetection(FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints)
        : base(additionalConstraints: additionalConstraints)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ChipRenderWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
    {
        #region constructors
        public _ChipRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Chip._ChipRenderTheme theme = default(FlutterSDK.Material.Chip._ChipRenderTheme), bool value = default(bool), bool isEnabled = default(bool), FlutterSDK.Animation.Animation.Animation<double> checkmarkAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> avatarDrawerAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> deleteDrawerAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base(key: key)
        {
            this.Theme = theme;
            this.Value = value;
            this.IsEnabled = isEnabled;
            this.CheckmarkAnimation = checkmarkAnimation;
            this.AvatarDrawerAnimation = avatarDrawerAnimation;
            this.DeleteDrawerAnimation = deleteDrawerAnimation;
            this.EnableAnimation = enableAnimation;
            this.AvatarBorder = avatarBorder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Material.Chip._ChipRenderTheme Theme { get; set; }
        public virtual bool Value { get; set; }
        public virtual bool IsEnabled { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> CheckmarkAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> AvatarDrawerAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> DeleteDrawerAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> EnableAnimation { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder AvatarBorder { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Chip._RenderChipElement CreateElement() { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Chip._RenderChip renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }


        public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderChipElement : FlutterSDK.Widgets.Framework.RenderObjectElement
    {
        #region constructors
        public _RenderChipElement(FlutterSDK.Material.Chip._ChipRenderWidget chip)
        : base(chip)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Dictionary<FlutterSDK.Material.Chip._ChipSlot, FlutterSDK.Widgets.Framework.Element> SlotToChild { get; set; }
        public virtual Dictionary<FlutterSDK.Widgets.Framework.Element, FlutterSDK.Material.Chip._ChipSlot> ChildToSlot { get; set; }
        public virtual FlutterSDK.Material.Chip._ChipRenderWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Chip._RenderChip RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor) { throw new NotImplementedException(); }


        public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child) { throw new NotImplementedException(); }


        private void _MountChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Chip._ChipSlot slot) { throw new NotImplementedException(); }


        public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot) { throw new NotImplementedException(); }


        private void _UpdateChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Chip._ChipSlot slot) { throw new NotImplementedException(); }


        public new void Update(FlutterSDK.Material.Chip._ChipRenderWidget newWidget) { throw new NotImplementedException(); }
        public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget) { throw new NotImplementedException(); }


        private void _UpdateRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Material.Chip._ChipSlot slot) { throw new NotImplementedException(); }


        public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue) { throw new NotImplementedException(); }


        public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child) { throw new NotImplementedException(); }


        public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue) { throw new NotImplementedException(); }

        #endregion
    }


    public class _ChipRenderTheme
    {
        #region constructors
        public _ChipRenderTheme(FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget deleteIcon = default(FlutterSDK.Widgets.Framework.Widget), Brightness brightness = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Edgeinsets.EdgeInsets labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), bool showAvatar = default(bool), bool showCheckmark = default(bool), FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), bool canTapBody = default(bool))
        {
            this.Avatar = avatar;
            this.Label = label;
            this.DeleteIcon = deleteIcon;
            this.Brightness = brightness;
            this.Padding = padding;
            this.VisualDensity = visualDensity;
            this.LabelPadding = labelPadding;
            this.ShowAvatar = showAvatar;
            this.ShowCheckmark = showCheckmark;
            this.CheckmarkColor = checkmarkColor;
            this.CanTapBody = canTapBody; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.Widget Avatar { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Label { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget DeleteIcon { get; set; }
        public virtual Brightness Brightness { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets Padding { get; set; }
        public virtual FlutterSDK.Material.Themedata.VisualDensity VisualDensity { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsets LabelPadding { get; set; }
        public virtual bool ShowAvatar { get; set; }
        public virtual bool ShowCheckmark { get; set; }
        public virtual FlutterBinding.UI.Color CheckmarkColor { get; set; }
        public virtual bool CanTapBody { get; set; }
        public virtual int HashCode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new bool Equals(@Object other) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderChip : FlutterSDK.Rendering.Box.RenderBox
    {
        #region constructors
        public _RenderChip(FlutterSDK.Material.Chip._ChipRenderTheme theme = default(FlutterSDK.Material.Chip._ChipRenderTheme), TextDirection textDirection = default(TextDirection), bool value = default(bool), bool isEnabled = default(bool), FlutterSDK.Animation.Animation.Animation<double> checkmarkAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> avatarDrawerAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> deleteDrawerAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
        : base()
        {
            this.Value = value;
            this.IsEnabled = isEnabled;
            this.CheckmarkAnimation = checkmarkAnimation;
            this.AvatarDrawerAnimation = avatarDrawerAnimation;
            this.DeleteDrawerAnimation = deleteDrawerAnimation;
            this.EnableAnimation = enableAnimation;
            this.AvatarBorder = avatarBorder; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual Dictionary<FlutterSDK.Material.Chip._ChipSlot, FlutterSDK.Rendering.Box.RenderBox> SlotToChild { get; set; }
        public virtual Dictionary<FlutterSDK.Rendering.Box.RenderBox, FlutterSDK.Material.Chip._ChipSlot> ChildToSlot { get; set; }
        public virtual bool Value { get; set; }
        public virtual bool IsEnabled { get; set; }
        public virtual FlutterBinding.UI.Rect DeleteButtonRect { get; set; }
        public virtual FlutterBinding.UI.Rect PressRect { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> CheckmarkAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> AvatarDrawerAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> DeleteDrawerAnimation { get; set; }
        public virtual FlutterSDK.Animation.Animation.Animation<double> EnableAnimation { get; set; }
        public virtual FlutterSDK.Painting.Borders.ShapeBorder AvatarBorder { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Avatar { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _DeleteIcon { get; set; }
        internal virtual FlutterSDK.Rendering.Box.RenderBox _Label { get; set; }
        internal virtual FlutterSDK.Material.Chip._ChipRenderTheme _Theme { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        public virtual FlutterSDK.Animation.Tween.ColorTween SelectionScrimTween { get; set; }
        internal virtual bool _DebugShowTapTargetOutlines { get; set; }
        public virtual FlutterSDK.Rendering.Box.RenderBox Avatar { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox DeleteIcon { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Box.RenderBox Label { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Material.Chip._ChipRenderTheme Theme { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual Iterable<FlutterSDK.Rendering.Box.RenderBox> _Children { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsDrawingCheckmark { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool DeleteIconShowing { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SizedByParent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterBinding.UI.Color _DisabledColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        private FlutterSDK.Rendering.Box.RenderBox _UpdateChild(FlutterSDK.Rendering.Box.RenderBox oldChild, FlutterSDK.Rendering.Box.RenderBox newChild, FlutterSDK.Material.Chip._ChipSlot slot) { throw new NotImplementedException(); }


        public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner) { throw new NotImplementedException(); }
        public new void Attach(@Object owner) { throw new NotImplementedException(); }


        public new void Detach() { throw new NotImplementedException(); }


        public new void RedepthChildren() { throw new NotImplementedException(); }


        public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor) { throw new NotImplementedException(); }


        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren() { throw new NotImplementedException(); }


        private double _MinWidth(FlutterSDK.Rendering.Box.RenderBox box, double height) { throw new NotImplementedException(); }


        private double _MaxWidth(FlutterSDK.Rendering.Box.RenderBox box, double height) { throw new NotImplementedException(); }


        private double _MinHeight(FlutterSDK.Rendering.Box.RenderBox box, double width) { throw new NotImplementedException(); }


        private Size _BoxSize(FlutterSDK.Rendering.Box.RenderBox box) { throw new NotImplementedException(); }


        private Rect _BoxRect(FlutterSDK.Rendering.Box.RenderBox box) { throw new NotImplementedException(); }


        private FlutterSDK.Rendering.Box.BoxParentData _BoxParentData(FlutterSDK.Rendering.Box.RenderBox box) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicWidth(double height) { throw new NotImplementedException(); }


        public new double ComputeMinIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeMaxIntrinsicHeight(double width) { throw new NotImplementedException(); }


        public new double ComputeDistanceToActualBaseline(TextBaseline baseline) { throw new NotImplementedException(); }


        private Size _LayoutLabel(double iconSizes, Size size) { throw new NotImplementedException(); }


        private Size _LayoutAvatar(FlutterSDK.Rendering.Box.BoxConstraints contentConstraints, double contentSize) { throw new NotImplementedException(); }


        private Size _LayoutDeleteIcon(FlutterSDK.Rendering.Box.BoxConstraints contentConstraints, double contentSize) { throw new NotImplementedException(); }


        public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset)) { throw new NotImplementedException(); }


        public new void PerformLayout() { throw new NotImplementedException(); }


        private void _PaintCheck(Canvas canvas, FlutterBinding.UI.Offset origin, double size) { throw new NotImplementedException(); }


        private void _PaintSelectionOverlay(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        private void _PaintAvatar(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        private void _PaintChild(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox child, bool isEnabled) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }


        public new bool HitTestSelf(FlutterBinding.UI.Offset position) { throw new NotImplementedException(); }

        #endregion
    }


    public class _LocationAwareInkRippleFactory : FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory
    {
        #region constructors
        public _LocationAwareInkRippleFactory(bool hasDeleteButton, FlutterSDK.Widgets.Framework.BuildContext chipContext, FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> deleteIconKey)
        {
            this.HasDeleteButton = hasDeleteButton;
            this.ChipContext = chipContext;
            this.DeleteIconKey = deleteIconKey; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool HasDeleteButton { get; set; }
        public virtual FlutterSDK.Widgets.Framework.BuildContext ChipContext { get; set; }
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> DeleteIconKey { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Inkwell.InteractiveInkFeature Create(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController), FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), TextDirection textDirection = default(TextDirection), bool containedInkWell = false, FlutterSDK.Material.Material.RectCallback rectCallback = default(FlutterSDK.Material.Material.RectCallback), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder), double radius = default(double), VoidCallback onRemoved = default(VoidCallback)) { throw new NotImplementedException(); }

        #endregion
    }


    public enum _ChipSlot
    {

        Label,
        Avatar,
        DeleteIcon,
    }

}
