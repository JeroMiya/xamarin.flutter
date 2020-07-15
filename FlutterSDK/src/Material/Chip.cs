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


    /// <Summary>
    /// A material design chip.
    ///
    /// Chips are compact elements that represent an attribute, text, entity, or
    /// action.
    ///
    /// Supplying a non-null [onDeleted] callback will cause the chip to include a
    /// button for deleting the chip.
    ///
    /// Its ancestors must include [Material], [MediaQuery], [Directionality], and
    /// [MaterialLocalizations]. Typically all of these widgets are provided by
    /// [MaterialApp] and [Scaffold]. The [label] and [clipBehavior] arguments must
    /// not be null.
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// Chip(
    ///   avatar: CircleAvatar(
    ///     backgroundColor: Colors.grey.shade800,
    ///     child: Text('AB'),
    ///   ),
    ///   label: Text('Aaron Burr'),
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [InputChip], a chip that represents a complex piece of information, such
    ///    as an entity (person, place, or thing) or conversational text, in a
    ///    compact form.
    ///  * [ChoiceChip], allows a single selection from a set of options. Choice
    ///    chips contain related descriptive text or categories.
    ///  * [FilterChip], uses tags or descriptive words as a way to filter content.
    ///  * [ActionChip], represents an action related to primary content.
    ///  * [CircleAvatar], which shows images or initials of entities.
    ///  * [Wrap], A widget that displays its children in multiple horizontal or
    ///    vertical runs.
    ///  * <https://material.io/design/components/chips.html>
    /// </Summary>
    public class Chip : FlutterSDK.Widgets.Framework.StatelessWidget, IChipAttributes, IDeletableChipAttributes
    {
        #region constructors
        public Chip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget deleteIcon = default(FlutterSDK.Widgets.Framework.Widget), VoidCallback onDeleted = default(VoidCallback), FlutterBinding.UI.Color deleteIconColor = default(FlutterBinding.UI.Color), string deleteButtonTooltipMessage = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
        : base(key: key)
    
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

    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {

        return new RawChip(avatar: Avatar, label: Label, labelStyle: LabelStyle, labelPadding: LabelPadding, deleteIcon: DeleteIcon, onDeleted: OnDeleted, deleteIconColor: DeleteIconColor, deleteButtonTooltipMessage: DeleteButtonTooltipMessage, tapEnabled: false, shape: Shape, clipBehavior: ClipBehavior, focusNode: FocusNode, autofocus: Autofocus, backgroundColor: BackgroundColor, padding: Padding, visualDensity: VisualDensity, materialTapTargetSize: MaterialTapTargetSize, elevation: Elevation, shadowColor: ShadowColor, isEnabled: true);
    }



    #endregion
}


/// <Summary>
/// A material design input chip.
///
/// Input chips represent a complex piece of information, such as an entity
/// (person, place, or thing) or conversational text, in a compact form.
///
/// Input chips can be made selectable by setting [onSelected], deletable by
/// setting [onDeleted], and pressable like a button with [onPressed]. They have
/// a [label], and they can have a leading icon (see [avatar]) and a trailing
/// icon ([deleteIcon]). Colors and padding can be customized.
///
/// Requires one of its ancestors to be a [Material] widget.
///
/// Input chips work together with other UI elements. They can appear:
///
///  * In a [Wrap] widget.
///  * In a horizontally scrollable list, like a [ListView] whose
///    scrollDirection is [Axis.horizontal].
///
/// {@tool snippet}
///
/// ```dart
/// InputChip(
///   avatar: CircleAvatar(
///     backgroundColor: Colors.grey.shade800,
///     child: Text('AB'),
///   ),
///   label: Text('Aaron Burr'),
///   onPressed: () {
///     print('I am the one thing in life.');
///   }
/// )
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [Chip], a chip that displays information and can be deleted.
///  * [ChoiceChip], allows a single selection from a set of options. Choice
///    chips contain related descriptive text or categories.
///  * [FilterChip], uses tags or descriptive words as a way to filter content.
///  * [ActionChip], represents an action related to primary content.
///  * [CircleAvatar], which shows images or initials of people.
///  * [Wrap], A widget that displays its children in multiple horizontal or
///    vertical runs.
///  * <https://material.io/design/components/chips.html>
/// </Summary>
public class InputChip : FlutterSDK.Widgets.Framework.StatelessWidget, IChipAttributes, IDeletableChipAttributes, ISelectableChipAttributes, ICheckmarkableChipAttributes, IDisabledChipAttributes, ITappableChipAttributes
{
    #region constructors
    public InputChip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool selected = false, bool isEnabled = true, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelected = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Widgets.Framework.Widget deleteIcon = default(FlutterSDK.Widgets.Framework.Widget), VoidCallback onDeleted = default(VoidCallback), FlutterBinding.UI.Color deleteIconColor = default(FlutterBinding.UI.Color), string deleteButtonTooltipMessage = default(string), VoidCallback onPressed = default(VoidCallback), double pressElevation = default(double), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), string tooltip = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), bool showCheckmark = default(bool), FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
    : base(key: key)

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

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{

    return new RawChip(avatar: Avatar, label: Label, labelStyle: LabelStyle, labelPadding: LabelPadding, deleteIcon: DeleteIcon, onDeleted: OnDeleted, deleteIconColor: DeleteIconColor, deleteButtonTooltipMessage: DeleteButtonTooltipMessage, onSelected: OnSelected, onPressed: OnPressed, pressElevation: PressElevation, selected: Selected, tapEnabled: true, disabledColor: DisabledColor, selectedColor: SelectedColor, tooltip: Tooltip, shape: Shape, clipBehavior: ClipBehavior, focusNode: FocusNode, autofocus: Autofocus, backgroundColor: BackgroundColor, padding: Padding, visualDensity: VisualDensity, materialTapTargetSize: MaterialTapTargetSize, elevation: Elevation, shadowColor: ShadowColor, selectedShadowColor: SelectedShadowColor, showCheckmark: ShowCheckmark, checkmarkColor: CheckmarkColor, isEnabled: IsEnabled && (OnSelected != null || OnDeleted != null || OnPressed != null), avatarBorder: AvatarBorder);
}



#endregion
}


/// <Summary>
/// A material design choice chip.
///
/// [ChoiceChip]s represent a single choice from a set. Choice chips contain
/// related descriptive text or categories.
///
/// Requires one of its ancestors to be a [Material] widget. The [selected] and
/// [label] arguments must not be null.
///
/// {@tool snippet}
///
/// ```dart
/// class MyThreeOptions extends StatefulWidget {
///   @override
///   _MyThreeOptionsState createState() => _MyThreeOptionsState();
/// }
///
/// class _MyThreeOptionsState extends State<MyThreeOptions> {
///   int _value = 1;
///
///   @override
///   Widget build(BuildContext context) {
///     return Wrap(
///       children: List<Widget>.generate(
///         3,
///         (int index) {
///           return ChoiceChip(
///             label: Text('Item $index'),
///             selected: _value == index,
///             onSelected: (bool selected) {
///               setState(() {
///                 _value = selected ? index : null;
///               });
///             },
///           );
///         },
///       ).toList(),
///     );
///   }
/// }
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [Chip], a chip that displays information and can be deleted.
///  * [InputChip], a chip that represents a complex piece of information, such
///    as an entity (person, place, or thing) or conversational text, in a
///    compact form.
///  * [FilterChip], uses tags or descriptive words as a way to filter content.
///  * [ActionChip], represents an action related to primary content.
///  * [CircleAvatar], which shows images or initials of people.
///  * [Wrap], A widget that displays its children in multiple horizontal or
///    vertical runs.
///  * <https://material.io/design/components/chips.html>
/// </Summary>
public class ChoiceChip : FlutterSDK.Widgets.Framework.StatelessWidget, IChipAttributes, ISelectableChipAttributes, IDisabledChipAttributes
{
    #region constructors
    public ChoiceChip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelected = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), double pressElevation = default(double), bool selected = default(bool), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), string tooltip = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
    : base(key: key)

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

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{

    ChipThemeData chipTheme = ChipthemeDefaultClass.ChipTheme.Of(context);
    return new RawChip(avatar: Avatar, label: Label, labelStyle: LabelStyle ?? (Selected ? chipTheme.SecondaryLabelStyle : null), labelPadding: LabelPadding, onSelected: OnSelected, pressElevation: PressElevation, selected: Selected, showCheckmark: false, onDeleted: null, tooltip: Tooltip, shape: Shape, clipBehavior: ClipBehavior, focusNode: FocusNode, autofocus: Autofocus, disabledColor: DisabledColor, selectedColor: SelectedColor ?? chipTheme.SecondarySelectedColor, backgroundColor: BackgroundColor, padding: Padding, visualDensity: VisualDensity, isEnabled: IsEnabled, materialTapTargetSize: MaterialTapTargetSize, elevation: Elevation, shadowColor: ShadowColor, selectedShadowColor: SelectedShadowColor, avatarBorder: AvatarBorder);
}



#endregion
}


/// <Summary>
/// A material design filter chip.
///
/// Filter chips use tags or descriptive words as a way to filter content.
///
/// Filter chips are a good alternative to [Checkbox] or [Switch] widgets.
/// Unlike these alternatives, filter chips allow for clearly delineated and
/// exposed options in a compact area.
///
/// Requires one of its ancestors to be a [Material] widget.
///
/// {@tool snippet}
///
/// ```dart
/// class ActorFilterEntry {
///   const ActorFilterEntry(this.name, this.initials);
///   final String name;
///   final String initials;
/// }
///
/// class CastFilter extends StatefulWidget {
///   @override
///   State createState() => CastFilterState();
/// }
///
/// class CastFilterState extends State<CastFilter> {
///   final List<ActorFilterEntry> _cast = <ActorFilterEntry>[
///     const ActorFilterEntry('Aaron Burr', 'AB'),
///     const ActorFilterEntry('Alexander Hamilton', 'AH'),
///     const ActorFilterEntry('Eliza Hamilton', 'EH'),
///     const ActorFilterEntry('James Madison', 'JM'),
///   ];
///   List<String> _filters = <String>[];
///
///   Iterable<Widget> get actorWidgets sync* {
///     for (final ActorFilterEntry actor in _cast) {
///       yield Padding(
///         padding: const EdgeInsets.all(4.0),
///         child: FilterChip(
///           avatar: CircleAvatar(child: Text(actor.initials)),
///           label: Text(actor.name),
///           selected: _filters.contains(actor.name),
///           onSelected: (bool value) {
///             setState(() {
///               if (value) {
///                 _filters.add(actor.name);
///               } else {
///                 _filters.removeWhere((String name) {
///                   return name == actor.name;
///                 });
///               }
///             });
///           },
///         ),
///       );
///     }
///   }
///
///   @override
///   Widget build(BuildContext context) {
///     return Column(
///       mainAxisAlignment: MainAxisAlignment.center,
///       children: <Widget>[
///         Wrap(
///           children: actorWidgets.toList(),
///         ),
///         Text('Look for: ${_filters.join(', ')}'),
///       ],
///     );
///   }
/// }
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [Chip], a chip that displays information and can be deleted.
///  * [InputChip], a chip that represents a complex piece of information, such
///    as an entity (person, place, or thing) or conversational text, in a
///    compact form.
///  * [ChoiceChip], allows a single selection from a set of options. Choice
///    chips contain related descriptive text or categories.
///  * [ActionChip], represents an action related to primary content.
///  * [CircleAvatar], which shows images or initials of people.
///  * [Wrap], A widget that displays its children in multiple horizontal or
///    vertical runs.
///  * <https://material.io/design/components/chips.html>
/// </Summary>
public class FilterChip : FlutterSDK.Widgets.Framework.StatelessWidget, IChipAttributes, ISelectableChipAttributes, ICheckmarkableChipAttributes, IDisabledChipAttributes
{
    #region constructors
    public FilterChip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), bool selected = false, FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelected = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), double pressElevation = default(double), FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), string tooltip = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), bool showCheckmark = default(bool), FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
    : base(key: key)

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

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{

    return new RawChip(avatar: Avatar, label: Label, labelStyle: LabelStyle, labelPadding: LabelPadding, onSelected: OnSelected, pressElevation: PressElevation, selected: Selected, tooltip: Tooltip, shape: Shape, clipBehavior: ClipBehavior, focusNode: FocusNode, autofocus: Autofocus, backgroundColor: BackgroundColor, disabledColor: DisabledColor, selectedColor: SelectedColor, padding: Padding, visualDensity: VisualDensity, isEnabled: IsEnabled, materialTapTargetSize: MaterialTapTargetSize, elevation: Elevation, shadowColor: ShadowColor, selectedShadowColor: SelectedShadowColor, showCheckmark: ShowCheckmark, checkmarkColor: CheckmarkColor, avatarBorder: AvatarBorder);
}



#endregion
}


/// <Summary>
/// A material design action chip.
///
/// Action chips are a set of options which trigger an action related to primary
/// content. Action chips should appear dynamically and contextually in a UI.
///
/// Action chips can be tapped to trigger an action or show progress and
/// confirmation. They cannot be disabled; if the action is not applicable, the
/// chip should not be included in the interface. (This contrasts with buttons,
/// where unavailable choices are usually represented as disabled controls.)
///
/// Action chips are displayed after primary content, such as below a card or
/// persistently at the bottom of a screen.
///
/// The material button widgets, [RaisedButton], [FlatButton], and
/// [OutlineButton], are an alternative to action chips, which should appear
/// statically and consistently in a UI.
///
/// Requires one of its ancestors to be a [Material] widget.
///
/// {@tool snippet}
///
/// ```dart
/// ActionChip(
///   avatar: CircleAvatar(
///     backgroundColor: Colors.grey.shade800,
///     child: Text('AB'),
///   ),
///   label: Text('Aaron Burr'),
///   onPressed: () {
///     print("If you stand for nothing, Burr, what’ll you fall for?");
///   }
/// )
/// ```
/// {@end-tool}
///
/// See also:
///
///  * [Chip], a chip that displays information and can be deleted.
///  * [InputChip], a chip that represents a complex piece of information, such
///    as an entity (person, place, or thing) or conversational text, in a
///    compact form.
///  * [ChoiceChip], allows a single selection from a set of options. Choice
///    chips contain related descriptive text or categories.
///  * [CircleAvatar], which shows images or initials of people.
///  * [Wrap], A widget that displays its children in multiple horizontal or
///    vertical runs.
///  * <https://material.io/design/components/chips.html>
/// </Summary>
public class ActionChip : FlutterSDK.Widgets.Framework.StatelessWidget, IChipAttributes, ITappableChipAttributes
{
    #region constructors
    public ActionChip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), VoidCallback onPressed = default(VoidCallback), double pressElevation = default(double), string tooltip = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color))
    : base(key: key)

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

public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
{

    return new RawChip(avatar: Avatar, label: Label, onPressed: OnPressed, pressElevation: PressElevation, tooltip: Tooltip, labelStyle: LabelStyle, backgroundColor: BackgroundColor, shape: Shape, clipBehavior: ClipBehavior, focusNode: FocusNode, autofocus: Autofocus, padding: Padding, visualDensity: VisualDensity, labelPadding: LabelPadding, isEnabled: true, materialTapTargetSize: MaterialTapTargetSize, elevation: Elevation, shadowColor: ShadowColor);
}



#endregion
}


/// <Summary>
/// A raw material design chip.
///
/// This serves as the basis for all of the chip widget types to aggregate.
/// It is typically not created directly, one of the other chip types
/// that are appropriate for the use case are used instead:
///
///  * [Chip] a simple chip that can only display information and be deleted.
///  * [InputChip] represents a complex piece of information, such as an entity
///    (person, place, or thing) or conversational text, in a compact form.
///  * [ChoiceChip] allows a single selection from a set of options.
///  * [FilterChip] a chip that uses tags or descriptive words as a way to
///    filter content.
///  * [ActionChip]s display a set of actions related to primary content.
///
/// Raw chips are typically only used if you want to create your own custom chip
/// type.
///
/// Raw chips can be selected by setting [onSelected], deleted by setting
/// [onDeleted], and pushed like a button with [onPressed]. They have a [label],
/// and they can have a leading icon (see [avatar]) and a trailing icon
/// ([deleteIcon]). Colors and padding can be customized.
///
/// Requires one of its ancestors to be a [Material] widget.
///
/// See also:
///
///  * [CircleAvatar], which shows images or initials of people.
///  * [Wrap], A widget that displays its children in multiple horizontal or
///    vertical runs.
///  * <https://material.io/design/components/chips.html>
/// </Summary>
public class RawChip : FlutterSDK.Widgets.Framework.StatefulWidget, IChipAttributes, IDeletableChipAttributes, ISelectableChipAttributes, ICheckmarkableChipAttributes, IDisabledChipAttributes, ITappableChipAttributes
{
    #region constructors
    public RawChip(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Painting.Textstyle.TextStyle labelStyle = default(FlutterSDK.Painting.Textstyle.TextStyle), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry), FlutterSDK.Widgets.Framework.Widget deleteIcon = default(FlutterSDK.Widgets.Framework.Widget), VoidCallback onDeleted = default(VoidCallback), FlutterBinding.UI.Color deleteIconColor = default(FlutterBinding.UI.Color), string deleteButtonTooltipMessage = default(string), VoidCallback onPressed = default(VoidCallback), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onSelected = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), double pressElevation = default(double), bool tapEnabled = true, bool selected = false, bool isEnabled = true, FlutterBinding.UI.Color disabledColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedColor = default(FlutterBinding.UI.Color), string tooltip = default(string), FlutterSDK.Painting.Borders.ShapeBorder shape = default(FlutterSDK.Painting.Borders.ShapeBorder), FlutterBinding.UI.Clip clipBehavior = default(FlutterBinding.UI.Clip), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false, FlutterBinding.UI.Color backgroundColor = default(FlutterBinding.UI.Color), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), double elevation = default(double), FlutterBinding.UI.Color shadowColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color selectedShadowColor = default(FlutterBinding.UI.Color), bool showCheckmark = true, FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
    : base(key: key)

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

public new FlutterSDK.Material.Chip._RawChipState CreateState() => new _RawChipState();


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

    public new void InitState()
    {

        base.InitState();
        _UpdateState(MaterialState.Disabled, !Widget.IsEnabled);
        _UpdateState(MaterialState.Selected, Widget.Selected);
        SelectController = new AnimationController(duration: ChipDefaultClass._KSelectDuration, value: Widget.Selected == true ? 1.0 : 0.0, vsync: this);
        SelectionFade = new CurvedAnimation(parent: SelectController, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
        AvatarDrawerController = new AnimationController(duration: ChipDefaultClass._KDrawerDuration, value: HasAvatar || Widget.Selected == true ? 1.0 : 0.0, vsync: this);
        DeleteDrawerController = new AnimationController(duration: ChipDefaultClass._KDrawerDuration, value: HasDeleteButton ? 1.0 : 0.0, vsync: this);
        EnableController = new AnimationController(duration: ChipDefaultClass._KDisableDuration, value: Widget.IsEnabled ? 1.0 : 0.0, vsync: this);
        double checkmarkPercentage = ChipDefaultClass._KCheckmarkDuration.InMilliseconds / ChipDefaultClass._KSelectDuration.InMilliseconds;
        double checkmarkReversePercentage = ChipDefaultClass._KCheckmarkReverseDuration.InMilliseconds / ChipDefaultClass._KSelectDuration.InMilliseconds;
        double avatarDrawerReversePercentage = ChipDefaultClass._KReverseDrawerDuration.InMilliseconds / ChipDefaultClass._KSelectDuration.InMilliseconds;
        CheckmarkAnimation = new CurvedAnimation(parent: SelectController, curve: new Interval(1.0 - checkmarkPercentage, 1.0, curve: CurvesDefaultClass.Curves.FastOutSlowIn), reverseCurve: new Interval(1.0 - checkmarkReversePercentage, 1.0, curve: CurvesDefaultClass.Curves.FastOutSlowIn));
        DeleteDrawerAnimation = new CurvedAnimation(parent: DeleteDrawerController, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
        AvatarDrawerAnimation = new CurvedAnimation(parent: AvatarDrawerController, curve: CurvesDefaultClass.Curves.FastOutSlowIn, reverseCurve: new Interval(1.0 - avatarDrawerReversePercentage, 1.0, curve: CurvesDefaultClass.Curves.FastOutSlowIn));
        EnableAnimation = new CurvedAnimation(parent: EnableController, curve: CurvesDefaultClass.Curves.FastOutSlowIn);
    }




    public new void Dispose()
    {
        SelectController.Dispose();
        AvatarDrawerController.Dispose();
        DeleteDrawerController.Dispose();
        EnableController.Dispose();
        base.Dispose();
    }




    private void _UpdateState(FlutterSDK.Material.Materialstate.MaterialState state, bool value)
    {
        value? _States.Add(state):_States.Remove(state);
    }




    private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details)
    {
        if (!CanTap)
        {
            return;
        }

        SetState(() =>
        {
            _IsTapping = true;
            _UpdateState(MaterialState.Pressed, true);
        }
        );
    }




    private void _HandleTapCancel()
    {
        if (!CanTap)
        {
            return;
        }

        SetState(() =>
        {
            _IsTapping = false;
            _UpdateState(MaterialState.Pressed, false);
        }
        );
    }




    private void _HandleTap()
    {
        if (!CanTap)
        {
            return;
        }

        SetState(() =>
        {
            _IsTapping = false;
            _UpdateState(MaterialState.Pressed, false);
        }
        );
        Widget.OnSelected?.Call(!Widget.Selected);
        Widget.OnPressed?.Call();
    }




    private void _HandleFocus(bool isFocused)
    {
        SetState(() =>
        {
            _UpdateState(MaterialState.Focused, isFocused);
        }
        );
    }




    private void _HandleHover(bool isHovered)
    {
        SetState(() =>
        {
            _UpdateState(MaterialState.Hovered, isHovered);
        }
        );
    }




    /// <Summary>
    /// Picks between three different colors, depending upon the state of two
    /// different animations.
    /// </Summary>
    public virtual Color GetBackgroundColor(FlutterSDK.Material.Chiptheme.ChipThemeData theme)
    {
        ColorTween backgroundTween = new ColorTween(begin: Widget.DisabledColor ?? theme.DisabledColor, end: Widget.BackgroundColor ?? theme.BackgroundColor);
        ColorTween selectTween = new ColorTween(begin: backgroundTween.Evaluate(EnableController), end: Widget.SelectedColor ?? theme.SelectedColor);
        return selectTween.Evaluate(SelectionFade);
    }




    public new void DidUpdateWidget(FlutterSDK.Material.Chip.RawChip oldWidget)
    {
        base.DidUpdateWidget(oldWidget);
        if (oldWidget.IsEnabled != Widget.IsEnabled)
        {
            SetState(() =>
            {
                _UpdateState(MaterialState.Disabled, !Widget.IsEnabled);
                if (Widget.IsEnabled)
                {
                    EnableController.Forward();
                }
                else
                {
                    EnableController.Reverse();
                }

            }
            );
        }

        if (oldWidget.Avatar != Widget.Avatar || oldWidget.Selected != Widget.Selected)
        {
            SetState(() =>
            {
                if (HasAvatar || Widget.Selected == true)
                {
                    AvatarDrawerController.Forward();
                }
                else
                {
                    AvatarDrawerController.Reverse();
                }

            }
            );
        }

        if (oldWidget.Selected != Widget.Selected)
        {
            SetState(() =>
            {
                _UpdateState(MaterialState.Selected, Widget.Selected);
                if (Widget.Selected == true)
                {
                    SelectController.Forward();
                }
                else
                {
                    SelectController.Reverse();
                }

            }
            );
        }

        if (oldWidget.OnDeleted != Widget.OnDeleted)
        {
            SetState(() =>
            {
                if (HasDeleteButton)
                {
                    DeleteDrawerController.Forward();
                }
                else
                {
                    DeleteDrawerController.Reverse();
                }

            }
            );
        }

    }




    private FlutterSDK.Widgets.Framework.Widget _WrapWithTooltip(string tooltip, VoidCallback callback, FlutterSDK.Widgets.Framework.Widget child)
    {
        if (child == null || callback == null || tooltip == null)
        {
            return child;
        }

        return new Tooltip(message: tooltip, child: child);
    }




    private FlutterSDK.Widgets.Framework.Widget _BuildDeleteIcon(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Themedata.ThemeData theme, FlutterSDK.Material.Chiptheme.ChipThemeData chipTheme, FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> deleteIconKey)
    {
        if (!HasDeleteButton)
        {
            return null;
        }

        return new Semantics(container: true, button: true, child: _WrapWithTooltip(Widget.DeleteButtonTooltipMessage ?? MateriallocalizationsDefaultClass.MaterialLocalizations.Of(context)?.DeleteButtonTooltip, Widget.OnDeleted, new GestureDetector(key: deleteIconKey, behavior: HitTestBehavior.Opaque, onTap: Widget.IsEnabled ? () =>
        {
            FeedbackDefaultClass.Feedback.ForTap(context);
            Widget.OnDeleted();
        }
        : null, child: new IconTheme(data: theme.IconTheme.CopyWith(color: Widget.DeleteIconColor ?? chipTheme.DeleteIconColor), child: Widget.DeleteIcon))));
    }




    public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
    {




        ThemeData theme = ThemeDefaultClass.Theme.Of(context);
        ChipThemeData chipTheme = ChipthemeDefaultClass.ChipTheme.Of(context);
        TextDirection textDirection = BasicDefaultClass.Directionality.Of(context);
        ShapeBorder shape = Widget.Shape ?? chipTheme.Shape;
        double elevation = Widget.Elevation ?? chipTheme.Elevation ?? _DefaultElevation;
        double pressElevation = Widget.PressElevation ?? chipTheme.PressElevation ?? _DefaultPressElevation;
        Color shadowColor = Widget.ShadowColor ?? chipTheme.ShadowColor ?? _DefaultShadowColor;
        Color selectedShadowColor = Widget.SelectedShadowColor ?? chipTheme.SelectedShadowColor ?? _DefaultShadowColor;
        Color checkmarkColor = Widget.CheckmarkColor ?? chipTheme.CheckmarkColor;
        bool showCheckmark = Widget.ShowCheckmark ?? chipTheme.ShowCheckmark ?? true;
        TextStyle effectiveLabelStyle = Widget.LabelStyle ?? chipTheme.LabelStyle;
        Color resolvedLabelColor = MaterialstateDefaultClass.MaterialStateProperty.ResolveAs(effectiveLabelStyle?.Color, _States);
        TextStyle resolvedLabelStyle = effectiveLabelStyle?.CopyWith(color: resolvedLabelColor);
        Widget result = new Material(elevation: IsTapping ? pressElevation : elevation, shadowColor: Widget.Selected ? selectedShadowColor : shadowColor, animationDuration: PressedAnimationDuration, shape: shape, clipBehavior: Widget.ClipBehavior, child: new InkWell(onFocusChange: _HandleFocus, focusNode: Widget.FocusNode, autofocus: Widget.Autofocus, canRequestFocus: Widget.IsEnabled, onTap: CanTap ? _HandleTap : null, onTapDown: CanTap ? _HandleTapDown : null, onTapCancel: CanTap ? _HandleTapCancel : null, onHover: CanTap ? _HandleHover : null, splashFactory: new _LocationAwareInkRippleFactory(HasDeleteButton, context, DeleteIconKey), customBorder: shape, child: new AnimatedBuilder(animation: Listenable.Merge(new List<Listenable>() { SelectController, EnableController }), builder: (BuildContext context, Widget child) =>
        {
            return new Container(decoration: new ShapeDecoration(shape: shape, color: GetBackgroundColor(chipTheme)), child: child);
        }
        , child: _WrapWithTooltip(Widget.Tooltip, Widget.OnPressed, new _ChipRenderWidget(theme: new _ChipRenderTheme(label: new DefaultTextStyle(overflow: TextOverflow.Fade, textAlign: TextAlign.Start, maxLines: 1, softWrap: false, style: resolvedLabelStyle, child: Widget.Label), avatar: new AnimatedSwitcher(child: Widget.Avatar, duration: ChipDefaultClass._KDrawerDuration, switchInCurve: CurvesDefaultClass.Curves.FastOutSlowIn), deleteIcon: new AnimatedSwitcher(child: _BuildDeleteIcon(context, theme, chipTheme, DeleteIconKey), duration: ChipDefaultClass._KDrawerDuration, switchInCurve: CurvesDefaultClass.Curves.FastOutSlowIn), brightness: chipTheme.Brightness, padding: (Widget.Padding ?? chipTheme.Padding).Resolve(textDirection), visualDensity: Widget.VisualDensity ?? theme.VisualDensity, labelPadding: (Widget.LabelPadding ?? chipTheme.LabelPadding).Resolve(textDirection), showAvatar: HasAvatar, showCheckmark: showCheckmark, checkmarkColor: checkmarkColor, canTapBody: CanTap), value: Widget.Selected, checkmarkAnimation: CheckmarkAnimation, enableAnimation: EnableAnimation, avatarDrawerAnimation: AvatarDrawerAnimation, deleteDrawerAnimation: DeleteDrawerAnimation, isEnabled: Widget.IsEnabled, avatarBorder: Widget.AvatarBorder)))));
        BoxConstraints constraints = default(BoxConstraints);
        Offset densityAdjustment = (Widget.VisualDensity ?? theme.VisualDensity).BaseSizeAdjustment;
        switch (Widget.MaterialTapTargetSize ?? theme.MaterialTapTargetSize) { case MaterialTapTargetSize.Padded: constraints = new BoxConstraints(minHeight: ConstantsDefaultClass.KMinInteractiveDimension + densityAdjustment.Dy); break; case MaterialTapTargetSize.ShrinkWrap: constraints = new BoxConstraints(); break; }
        result = new _ChipRedirectingHitDetectionWidget(constraints: constraints, child: new Center(child: result, widthFactor: 1.0, heightFactor: 1.0));
        return new Semantics(container: true, selected: Widget.Selected, enabled: CanTap ? Widget.IsEnabled : null, child: result);
    }



    #endregion
}


/// <Summary>
/// Redirects the [position.dy] passed to [RenderBox.hitTest] to the vertical
/// center of the widget.
///
/// The primary purpose of this widget is to allow padding around the [RawChip]
/// to trigger the child ink feature without increasing the size of the material.
/// </Summary>
public class _ChipRedirectingHitDetectionWidget : FlutterSDK.Widgets.Framework.SingleChildRenderObjectWidget
{
    #region constructors
    public _ChipRedirectingHitDetectionWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Rendering.Box.BoxConstraints constraints = default(FlutterSDK.Rendering.Box.BoxConstraints))
    : base(key: key, child: child)

}
#endregion

#region fields
public virtual FlutterSDK.Rendering.Box.BoxConstraints Constraints { get; set; }
#endregion

#region methods

public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new _RenderChipRedirectingHitDetection(Constraints);
}




public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Chip._RenderChipRedirectingHitDetection renderObject)
{
    renderObject.AdditionalConstraints = Constraints;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    renderObject.AdditionalConstraints = Constraints;
}



#endregion
}


public class _RenderChipRedirectingHitDetection : FlutterSDK.Rendering.Proxybox.RenderConstrainedBox
{
    #region constructors
    public _RenderChipRedirectingHitDetection(FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints)
    : base(additionalConstraints: additionalConstraints)

}
#endregion

#region fields
#endregion

#region methods

public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    if (!Size.Contains(position)) return false;
    Offset offset = new Offset(position.Dx, Size.Height / 2);
    return result.AddWithRawTransform(transform: MatrixutilsDefaultClass.MatrixUtils.ForceToPoint(offset), position: position, hitTest: (BoxHitTestResult result, Offset position) =>
    {

        return Child.HitTest(result, position: offset);
    }
    );
}



#endregion
}


public class _ChipRenderWidget : FlutterSDK.Widgets.Framework.RenderObjectWidget
{
    #region constructors
    public _ChipRenderWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Material.Chip._ChipRenderTheme theme = default(FlutterSDK.Material.Chip._ChipRenderTheme), bool value = default(bool), bool isEnabled = default(bool), FlutterSDK.Animation.Animation.Animation<double> checkmarkAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> avatarDrawerAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> deleteDrawerAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
    : base(key: key)

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

public new FlutterSDK.Material.Chip._RenderChipElement CreateElement() => new _RenderChipElement(this);



public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Chip._RenderChip renderObject)
{
    ..Theme = Theme..TextDirection = BasicDefaultClass.Directionality.Of(context)..Value = Value..IsEnabled = IsEnabled..CheckmarkAnimation = CheckmarkAnimation..AvatarDrawerAnimation = AvatarDrawerAnimation..DeleteDrawerAnimation = DeleteDrawerAnimation..EnableAnimation = EnableAnimation..AvatarBorder = AvatarBorder;
}


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject)
{
    ..Theme = Theme..TextDirection = BasicDefaultClass.Directionality.Of(context)..Value = Value..IsEnabled = IsEnabled..CheckmarkAnimation = CheckmarkAnimation..AvatarDrawerAnimation = AvatarDrawerAnimation..DeleteDrawerAnimation = DeleteDrawerAnimation..EnableAnimation = EnableAnimation..AvatarBorder = AvatarBorder;
}




public new FlutterSDK.Rendering.@object.RenderObject CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context)
{
    return new _RenderChip(theme: Theme, textDirection: BasicDefaultClass.Directionality.Of(context), value: Value, isEnabled: IsEnabled, checkmarkAnimation: CheckmarkAnimation, avatarDrawerAnimation: AvatarDrawerAnimation, deleteDrawerAnimation: DeleteDrawerAnimation, enableAnimation: EnableAnimation, avatarBorder: AvatarBorder);
}



#endregion
}


public class _RenderChipElement : FlutterSDK.Widgets.Framework.RenderObjectElement
{
    #region constructors
    public _RenderChipElement(FlutterSDK.Material.Chip._ChipRenderWidget chip)
    : base(chip)

}
#endregion

#region fields
public virtual Dictionary<FlutterSDK.Material.Chip._ChipSlot, FlutterSDK.Widgets.Framework.Element> SlotToChild { get; set; }
public virtual Dictionary<FlutterSDK.Widgets.Framework.Element, FlutterSDK.Material.Chip._ChipSlot> ChildToSlot { get; set; }
public virtual FlutterSDK.Material.Chip._ChipRenderWidget Widget { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
public virtual FlutterSDK.Material.Chip._RenderChip RenderObject { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public new void VisitChildren(FlutterSDK.Widgets.Framework.ElementVisitor visitor)
{
    SlotToChild.Values.ForEach(visitor);
}




public new void ForgetChild(FlutterSDK.Widgets.Framework.Element child)
{


    _ChipSlot slot = ChildToSlot[child];
    ChildToSlot.Remove(child);
    SlotToChild.Remove(slot);
    base.ForgetChild(child);
}




private void _MountChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Chip._ChipSlot slot)
{
    Element oldChild = SlotToChild[slot];
    Element newChild = UpdateChild(oldChild, widget, slot);
    if (oldChild != null)
    {
        SlotToChild.Remove(slot);
        ChildToSlot.Remove(oldChild);
    }

    if (newChild != null)
    {
        SlotToChild[slot] = newChild;
        ChildToSlot[newChild] = slot;
    }

}




public new void Mount(FlutterSDK.Widgets.Framework.Element parent, object newSlot)
{
    base.Mount(parent, newSlot);
    _MountChild(Widget.Theme.Avatar, _ChipSlot.Avatar);
    _MountChild(Widget.Theme.DeleteIcon, _ChipSlot.DeleteIcon);
    _MountChild(Widget.Theme.Label, _ChipSlot.Label);
}




private void _UpdateChild(FlutterSDK.Widgets.Framework.Widget widget, FlutterSDK.Material.Chip._ChipSlot slot)
{
    Element oldChild = SlotToChild[slot];
    Element newChild = UpdateChild(oldChild, widget, slot);
    if (oldChild != null)
    {
        ChildToSlot.Remove(oldChild);
        SlotToChild.Remove(slot);
    }

    if (newChild != null)
    {
        SlotToChild[slot] = newChild;
        ChildToSlot[newChild] = slot;
    }

}




public new void Update(FlutterSDK.Material.Chip._ChipRenderWidget newWidget)
{
    base.Update(newWidget);

    _UpdateChild(Widget.Theme.Label, _ChipSlot.Label);
    _UpdateChild(Widget.Theme.Avatar, _ChipSlot.Avatar);
    _UpdateChild(Widget.Theme.DeleteIcon, _ChipSlot.DeleteIcon);
}


public new void Update(FlutterSDK.Widgets.Framework.Widget newWidget)
{
    base.Update(newWidget);

    _UpdateChild(Widget.Theme.Label, _ChipSlot.Label);
    _UpdateChild(Widget.Theme.Avatar, _ChipSlot.Avatar);
    _UpdateChild(Widget.Theme.DeleteIcon, _ChipSlot.DeleteIcon);
}




private void _UpdateRenderObject(FlutterSDK.Rendering.@object.RenderObject child, FlutterSDK.Material.Chip._ChipSlot slot)
{
    switch (slot) { case _ChipSlot.Avatar: RenderObject.Avatar = child as RenderBox; break; case _ChipSlot.Label: RenderObject.Label = child as RenderBox; break; case _ChipSlot.DeleteIcon: RenderObject.DeleteIcon = child as RenderBox; break; }
}




public new void InsertChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue)
{


    _ChipSlot slot = slotValue as _ChipSlot;
    _UpdateRenderObject(child, slot);


}




public new void RemoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child)
{


    _UpdateRenderObject(null, RenderObject.ChildToSlot[child]);


}




public new void MoveChildRenderObject(FlutterSDK.Rendering.@object.RenderObject child, object slotValue)
{

}



#endregion
}


public class _ChipRenderTheme
{
    #region constructors
    public _ChipRenderTheme(FlutterSDK.Widgets.Framework.Widget avatar = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget label = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Widgets.Framework.Widget deleteIcon = default(FlutterSDK.Widgets.Framework.Widget), Brightness brightness = default(Brightness), FlutterSDK.Painting.Edgeinsets.EdgeInsets padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), FlutterSDK.Material.Themedata.VisualDensity visualDensity = default(FlutterSDK.Material.Themedata.VisualDensity), FlutterSDK.Painting.Edgeinsets.EdgeInsets labelPadding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsets), bool showAvatar = default(bool), bool showCheckmark = default(bool), FlutterBinding.UI.Color checkmarkColor = default(FlutterBinding.UI.Color), bool canTapBody = default(bool))

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

public new bool Equals(@Object other)
{
    if (Dart:coreDefaultClass.Identical(this, other)){
        return true;
    }

    if (other.GetType() != GetType())
    {
        return false;
    }

    return other is _ChipRenderTheme && other.Avatar == Avatar && other.Label == Label && other.DeleteIcon == DeleteIcon && other.Brightness == Brightness && other.Padding == Padding && other.LabelPadding == LabelPadding && other.ShowAvatar == ShowAvatar && other.ShowCheckmark == ShowCheckmark && other.CheckmarkColor == CheckmarkColor && other.CanTapBody == CanTapBody;
}



#endregion
}


public class _RenderChip : FlutterSDK.Rendering.Box.RenderBox
{
    #region constructors
    public _RenderChip(FlutterSDK.Material.Chip._ChipRenderTheme theme = default(FlutterSDK.Material.Chip._ChipRenderTheme), TextDirection textDirection = default(TextDirection), bool value = default(bool), bool isEnabled = default(bool), FlutterSDK.Animation.Animation.Animation<double> checkmarkAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> avatarDrawerAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> deleteDrawerAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Animation.Animation.Animation<double> enableAnimation = default(FlutterSDK.Animation.Animation.Animation<double>), FlutterSDK.Painting.Borders.ShapeBorder avatarBorder = default(FlutterSDK.Painting.Borders.ShapeBorder))
    : base()

CheckmarkAnimation.AddListener(MarkNeedsPaint);
AvatarDrawerAnimation.AddListener(MarkNeedsLayout);
DeleteDrawerAnimation.AddListener(MarkNeedsLayout);
EnableAnimation.AddListener(MarkNeedsPaint);
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

private FlutterSDK.Rendering.Box.RenderBox _UpdateChild(FlutterSDK.Rendering.Box.RenderBox oldChild, FlutterSDK.Rendering.Box.RenderBox newChild, FlutterSDK.Material.Chip._ChipSlot slot)
{
    if (oldChild != null)
    {
        DropChild(oldChild);
        ChildToSlot.Remove(oldChild);
        SlotToChild.Remove(slot);
    }

    if (newChild != null)
    {
        ChildToSlot[newChild] = slot;
        SlotToChild[slot] = newChild;
        AdoptChild(newChild);
    }

    return newChild;
}




public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner)
{
    base.Attach(owner);
    foreach (RenderBox child in _Children)
    {
        child.Attach(owner);
    }

}


public new void Attach(@Object owner)
{
    base.Attach(owner);
    foreach (RenderBox child in _Children)
    {
        child.Attach(owner);
    }

}




public new void Detach()
{
    base.Detach();
    foreach (RenderBox child in _Children)
    {
        child.Detach();
    }

}




public new void RedepthChildren()
{
    _Children.ForEach(RedepthChild);
}




public new void VisitChildren(FlutterSDK.Rendering.@object.RenderObjectVisitor visitor)
{
    _Children.ForEach(visitor);
}




public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
{
    List<DiagnosticsNode> value = new List<DiagnosticsNode>() { };
    void Add(RenderBox child, string name) => {
        if (child != null)
        {
            value.Add(child.ToDiagnosticsNode(name: name));
        }

    }

    Add(Avatar, "avatar");
    Add(Label, "label");
    Add(DeleteIcon, "deleteIcon");
    return value;
}




private double _MinWidth(FlutterSDK.Rendering.Box.RenderBox box, double height)
{
    return box == null ? 0.0 : box.GetMinIntrinsicWidth(height);
}




private double _MaxWidth(FlutterSDK.Rendering.Box.RenderBox box, double height)
{
    return box == null ? 0.0 : box.GetMaxIntrinsicWidth(height);
}




private double _MinHeight(FlutterSDK.Rendering.Box.RenderBox box, double width)
{
    return box == null ? 0.0 : box.GetMinIntrinsicHeight(width);
}




private Size _BoxSize(FlutterSDK.Rendering.Box.RenderBox box) => box == null ? Dart : uiDefaultClass.Size.Zero:box.Size;



private Rect _BoxRect(FlutterSDK.Rendering.Box.RenderBox box) => box == null ? Dart : uiDefaultClass.Rect.Zero:_BoxParentData(box).Offset & box.Size;



private FlutterSDK.Rendering.Box.BoxParentData _BoxParentData(FlutterSDK.Rendering.Box.RenderBox box) => box.ParentData as BoxParentData;



public new double ComputeMinIntrinsicWidth(double height)
{
    double overallPadding = Theme.Padding.Horizontal + Theme.LabelPadding.Horizontal;
    return overallPadding + _MinWidth(Avatar, height) + _MinWidth(Label, height) + _MinWidth(DeleteIcon, height);
}




public new double ComputeMaxIntrinsicWidth(double height)
{
    double overallPadding = Theme.Padding.Vertical + Theme.LabelPadding.Horizontal;
    return overallPadding + _MaxWidth(Avatar, height) + _MaxWidth(Label, height) + _MaxWidth(DeleteIcon, height);
}




public new double ComputeMinIntrinsicHeight(double width)
{
    return Math.Dart:mathDefaultClass.Max(ChipDefaultClass._KChipHeight, Theme.Padding.Vertical + Theme.LabelPadding.Vertical + _MinHeight(Label, width));
}




public new double ComputeMaxIntrinsicHeight(double width) => ComputeMinIntrinsicHeight(width);



public new double ComputeDistanceToActualBaseline(TextBaseline baseline)
{
    return Label.GetDistanceToActualBaseline(baseline);
}




private Size _LayoutLabel(double iconSizes, Size size)
{
    Size rawSize = _BoxSize(Label);
    if (Constraints.MaxWidth.IsFinite())
    {
        double maxWidth = Math.Dart:mathDefaultClass.Max(0.0, Constraints.MaxWidth - iconSizes - Theme.LabelPadding.Horizontal - Theme.Padding.Horizontal);
Label.Layout(Constraints.CopyWith(minWidth: 0.0, maxWidth: maxWidth, minHeight: rawSize.Height, maxHeight: size.Height), parentUsesSize: true);
Size updatedSize = _BoxSize(Label);
return new Size(updatedSize.Width + Theme.LabelPadding.Horizontal, updatedSize.Height + Theme.LabelPadding.Vertical);
}

Label.Layout(new BoxConstraints(minHeight: rawSize.Height, maxHeight: size.Height, minWidth: 0.0, maxWidth: size.Width), parentUsesSize: true);
return new Size(rawSize.Width + Theme.LabelPadding.Horizontal, rawSize.Height + Theme.LabelPadding.Vertical);
}




private Size _LayoutAvatar(FlutterSDK.Rendering.Box.BoxConstraints contentConstraints, double contentSize)
{
    double requestedSize = Math.Dart:mathDefaultClass.Max(0.0, contentSize);
BoxConstraints avatarConstraints = BoxConstraints.TightFor(width: requestedSize, height: requestedSize);
Avatar.Layout(avatarConstraints, parentUsesSize: true);
if (!Theme.ShowCheckmark && !Theme.ShowAvatar)
{
    return new Size(0.0, contentSize);
}

double avatarWidth = 0.0;
double avatarHeight = 0.0;
Size avatarBoxSize = _BoxSize(Avatar);
if (Theme.ShowAvatar)
{
    avatarWidth += AvatarDrawerAnimation.Value * avatarBoxSize.Width;
}
else
{
    avatarWidth += AvatarDrawerAnimation.Value * contentSize;
}

avatarHeight += avatarBoxSize.Height;
return new Size(avatarWidth, avatarHeight);
}




private Size _LayoutDeleteIcon(FlutterSDK.Rendering.Box.BoxConstraints contentConstraints, double contentSize)
{
    double requestedSize = Math.Dart:mathDefaultClass.Max(0.0, contentSize);
BoxConstraints deleteIconConstraints = BoxConstraints.TightFor(width: requestedSize, height: requestedSize);
DeleteIcon.Layout(deleteIconConstraints, parentUsesSize: true);
if (!DeleteIconShowing)
{
    return new Size(0.0, contentSize);
}

double deleteIconWidth = 0.0;
double deleteIconHeight = 0.0;
Size boxSize = _BoxSize(DeleteIcon);
deleteIconWidth += DeleteDrawerAnimation.Value * boxSize.Width;
deleteIconHeight += boxSize.Height;
return new Size(deleteIconWidth, deleteIconHeight);
}




public new bool HitTest(FlutterSDK.Rendering.Box.BoxHitTestResult result, FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset))
{
    if (!Size.Contains(position))
    {
        return false;
    }

    bool tapIsOnDeleteIcon = ChipDefaultClass._TapIsOnDeleteIcon(hasDeleteButton: DeleteIcon != null, tapPosition: position, chipSize: Size, textDirection: TextDirection);
    RenderBox hitTestChild = tapIsOnDeleteIcon ? (DeleteIcon ?? Label ?? Avatar) : (Label ?? Avatar);
    if (hitTestChild != null)
    {
        Offset center = hitTestChild.Size.Center(Dart: uiDefaultClass.Offset.Zero);
        return result.AddWithRawTransform(transform: MatrixutilsDefaultClass.MatrixUtils.ForceToPoint(center), position: position, hitTest: (BoxHitTestResult result, Offset position) =>
        {

            return hitTestChild.HitTest(result, position: center);
        }
        );
    }

    return false;
}




public new void PerformLayout()
{
    BoxConstraints contentConstraints = Constraints.Loosen();
    Offset densityAdjustment = new Offset(0.0, Theme.VisualDensity.BaseSizeAdjustment.Dy / 2.0);
    Label.Layout(contentConstraints, parentUsesSize: true);
    double contentSize = Math.Dart:mathDefaultClass.Max(ChipDefaultClass._KChipHeight - Theme.Padding.Vertical + Theme.LabelPadding.Vertical, _BoxSize(Label).Height + Theme.LabelPadding.Vertical);
    Size avatarSize = _LayoutAvatar(contentConstraints, contentSize);
    Size deleteIconSize = _LayoutDeleteIcon(contentConstraints, contentSize);
    Size labelSize = new Size(_BoxSize(Label).Width, contentSize);
    labelSize = _LayoutLabel(avatarSize.Width + deleteIconSize.Width, labelSize);
    Size overallSize = new Size(avatarSize.Width + labelSize.Width + deleteIconSize.Width, contentSize) + densityAdjustment;
    double left = 0.0;
    double right = overallSize.Width;
    Offset CenterLayout(Size boxSize, double x) => {

        Offset boxOffset = default(Offset);
        switch (TextDirection) { case TextDirection.Rtl: boxOffset = new Offset(x - boxSize.Width, (contentSize - boxSize.Height + densityAdjustment.Dy) / 2.0); break; case TextDirection.Ltr: boxOffset = new Offset(x, (contentSize - boxSize.Height + densityAdjustment.Dy) / 2.0); break; }
        return boxOffset;
    }

    Offset avatarOffset = Dart:uiDefaultClass.Offset.Zero;
    Offset labelOffset = Dart:uiDefaultClass.Offset.Zero;
    Offset deleteIconOffset = Dart:uiDefaultClass.Offset.Zero;
    switch (TextDirection)
    {
        case TextDirection.Rtl:
            double start = right; if (Theme.ShowCheckmark || Theme.ShowAvatar)
            {
                avatarOffset = CenterLayout(avatarSize, start);
                start -= avatarSize.Width;
            }
            labelOffset = CenterLayout(labelSize, start); start -= labelSize.Width; if (DeleteIconShowing)
            {
                DeleteButtonRect = Rect.FromLTWH(0.0, 0.0, deleteIconSize.Width + Theme.Padding.Right, overallSize.Height + Theme.Padding.Vertical);
                deleteIconOffset = CenterLayout(deleteIconSize, start);
            }
            else
            {
                DeleteButtonRect = Dart:uiDefaultClass.Rect.Zero;
            }
            start -= deleteIconSize.Width; if (Theme.CanTapBody)
            {
                PressRect = Rect.FromLTWH(DeleteButtonRect.Width, 0.0, overallSize.Width - DeleteButtonRect.Width + Theme.Padding.Horizontal, overallSize.Height + Theme.Padding.Vertical);
            }
            else
            {
                PressRect = Dart:uiDefaultClass.Rect.Zero;
            }
            break;
        case TextDirection.Ltr:
            double start = left; if (Theme.ShowCheckmark || Theme.ShowAvatar)
            {
                avatarOffset = CenterLayout(avatarSize, start - _BoxSize(Avatar).Width + avatarSize.Width);
                start += avatarSize.Width;
            }
            labelOffset = CenterLayout(labelSize, start); start += labelSize.Width; if (Theme.CanTapBody)
            {
                PressRect = Rect.FromLTWH(0.0, 0.0, DeleteIconShowing ? start + Theme.Padding.Left : overallSize.Width + Theme.Padding.Horizontal, overallSize.Height + Theme.Padding.Vertical);
            }
            else
            {
                PressRect = Dart:uiDefaultClass.Rect.Zero;
            }
            start -= _BoxSize(DeleteIcon).Width - deleteIconSize.Width; if (DeleteIconShowing)
            {
                deleteIconOffset = CenterLayout(deleteIconSize, start);
                DeleteButtonRect = Rect.FromLTWH(start + Theme.Padding.Left, 0.0, deleteIconSize.Width + Theme.Padding.Right, overallSize.Height + Theme.Padding.Vertical);
            }
            else
            {
                DeleteButtonRect = Dart:uiDefaultClass.Rect.Zero;
            }
            break;
    }
    labelOffset = labelOffset + new Offset(0.0, ((labelSize.Height - Theme.LabelPadding.Vertical) - _BoxSize(Label).Height) / 2.0);
    _BoxParentData(Avatar).Offset = Theme.Padding.TopLeft + avatarOffset;
    _BoxParentData(Label).Offset = Theme.Padding.TopLeft + labelOffset + Theme.LabelPadding.TopLeft;
    _BoxParentData(DeleteIcon).Offset = Theme.Padding.TopLeft + deleteIconOffset;
    Size paddedSize = new Size(overallSize.Width + Theme.Padding.Horizontal, overallSize.Height + Theme.Padding.Vertical);
    Size = Constraints.Constrain(paddedSize);


}




private void _PaintCheck(Canvas canvas, FlutterBinding.UI.Offset origin, double size)
{
    Color paintColor = default(Color);
    if (Theme.CheckmarkColor != null)
    {
        paintColor = Theme.CheckmarkColor;
    }
    else
    {
        switch (Theme.Brightness) { case Brightness.Light: paintColor = Theme.ShowAvatar ? ColorsDefaultClass.Colors.White : ColorsDefaultClass.Colors.Black.WithAlpha(ChipDefaultClass._KCheckmarkAlpha); break; case Brightness.Dark: paintColor = Theme.ShowAvatar ? ColorsDefaultClass.Colors.Black : ColorsDefaultClass.Colors.White.WithAlpha(ChipDefaultClass._KCheckmarkAlpha); break; }
    }

    ColorTween fadeTween = new ColorTween(begin: ColorsDefaultClass.Colors.Transparent, end: paintColor);
    paintColor = CheckmarkAnimation.Status == AnimationStatus.Reverse ? fadeTween.Evaluate(CheckmarkAnimation) : paintColor;
    Paint paint = new Paint()..Color = paintColor..Style = PaintingStyle.Stroke..StrokeWidth = ChipDefaultClass._KCheckmarkStrokeWidth * (Avatar != null ? Avatar.Size.Height / 24.0 : 1.0);
    double t = CheckmarkAnimation.Status == AnimationStatus.Reverse ? 1.0 : CheckmarkAnimation.Value;
    if (t == 0.0)
    {
        return;
    }


    Path path = new Path();
    Offset start = new Offset(size * 0.15, size * 0.45);
    Offset mid = new Offset(size * 0.4, size * 0.7);
    Offset end = new Offset(size * 0.85, size * 0.25);
    if (t < 0.5)
    {
        double strokeT = t * 2.0;
        Offset drawMid = Dart:uiDefaultClass.Offset.Lerp(start, mid, strokeT);
path.MoveTo(origin.Dx + start.Dx, origin.Dy + start.Dy);
path.LineTo(origin.Dx + drawMid.Dx, origin.Dy + drawMid.Dy);
}
else
{
    double strokeT = (t - 0.5) * 2.0;
    Offset drawEnd = Dart:uiDefaultClass.Offset.Lerp(mid, end, strokeT);
    path.MoveTo(origin.Dx + start.Dx, origin.Dy + start.Dy);
    path.LineTo(origin.Dx + mid.Dx, origin.Dy + mid.Dy);
    path.LineTo(origin.Dx + drawEnd.Dx, origin.Dy + drawEnd.Dy);
}

canvas.DrawPath(path, paint);
}




private void _PaintSelectionOverlay(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    if (IsDrawingCheckmark)
    {
        if (Theme.ShowAvatar)
        {
            Rect avatarRect = _BoxRect(Avatar).Shift(offset);
            Paint darkenPaint = new Paint()..Color = SelectionScrimTween.Evaluate(CheckmarkAnimation)..BlendMode = BlendMode.SrcATop;
            Path path = AvatarBorder.GetOuterPath(avatarRect);
            context.Canvas.DrawPath(path, darkenPaint);
        }

        double checkSize = Avatar.Size.Height * 0.75;
        Offset checkOffset = _BoxParentData(Avatar).Offset + new Offset(Avatar.Size.Height * 0.125, Avatar.Size.Height * 0.125);
        _PaintCheck(context.Canvas, offset + checkOffset, checkSize);
    }

}




private void _PaintAvatar(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    void PaintWithOverlay(PaintingContext context, Offset offset) => {
        context.PaintChild(Avatar, _BoxParentData(Avatar).Offset + offset);
        _PaintSelectionOverlay(context, offset);
    }

    if (Theme.ShowAvatar == false && AvatarDrawerAnimation.IsDismissed)
    {
        return;
    }

    Color disabledColor = _DisabledColor;
    int disabledColorAlpha = disabledColor.Alpha;
    if (NeedsCompositing)
    {
        context.PushLayer(new OpacityLayer(alpha: disabledColorAlpha), PaintWithOverlay, offset);
    }
    else
    {
        if (disabledColorAlpha != 0xff)
        {
            context.Canvas.SaveLayer(_BoxRect(Avatar).Shift(offset).Inflate(20.0), new Paint()..Color = disabledColor);
        }

        PaintWithOverlay(context, offset);
        if (disabledColorAlpha != 0xff)
        {
            context.Canvas.Restore();
        }

    }

}




private void _PaintChild(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset, FlutterSDK.Rendering.Box.RenderBox child, bool isEnabled)
{
    if (child == null)
    {
        return;
    }

    int disabledColorAlpha = _DisabledColor.Alpha;
    if (!EnableAnimation.IsCompleted)
    {
        if (NeedsCompositing)
        {
            context.PushLayer(new OpacityLayer(alpha: disabledColorAlpha), (PaintingContext context, Offset offset) =>
            {
                context.PaintChild(child, _BoxParentData(child).Offset + offset);
            }
            , offset);
        }
        else
        {
            Rect childRect = _BoxRect(child).Shift(offset);
            context.Canvas.SaveLayer(childRect.Inflate(20.0), new Paint()..Color = _DisabledColor);
            context.PaintChild(child, _BoxParentData(child).Offset + offset);
            context.Canvas.Restore();
        }

    }
    else
    {
        context.PaintChild(child, _BoxParentData(child).Offset + offset);
    }

}




public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{
    _PaintAvatar(context, offset);
    if (DeleteIconShowing)
    {
        _PaintChild(context, offset, DeleteIcon, IsEnabled);
    }

    _PaintChild(context, offset, Label, IsEnabled);
}




public new void DebugPaint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset)
{

}




public new bool HitTestSelf(FlutterBinding.UI.Offset position) => DeleteButtonRect.Contains(position) || PressRect.Contains(position);


#endregion
}


public class _LocationAwareInkRippleFactory : FlutterSDK.Material.Inkwell.InteractiveInkFeatureFactory
{
    #region constructors
    public _LocationAwareInkRippleFactory(bool hasDeleteButton, FlutterSDK.Widgets.Framework.BuildContext chipContext, FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> deleteIconKey)

}
#endregion

#region fields
public virtual bool HasDeleteButton { get; set; }
public virtual FlutterSDK.Widgets.Framework.BuildContext ChipContext { get; set; }
public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget>> DeleteIconKey { get; set; }
#endregion

#region methods

public new FlutterSDK.Material.Inkwell.InteractiveInkFeature Create(FlutterSDK.Material.Material.MaterialInkController controller = default(FlutterSDK.Material.Material.MaterialInkController), FlutterSDK.Rendering.Box.RenderBox referenceBox = default(FlutterSDK.Rendering.Box.RenderBox), FlutterBinding.UI.Offset position = default(FlutterBinding.UI.Offset), FlutterBinding.UI.Color color = default(FlutterBinding.UI.Color), TextDirection textDirection = default(TextDirection), bool containedInkWell = false, FlutterSDK.Material.Material.RectCallback rectCallback = default(FlutterSDK.Material.Material.RectCallback), FlutterSDK.Painting.Borderradius.BorderRadius borderRadius = default(FlutterSDK.Painting.Borderradius.BorderRadius), FlutterSDK.Painting.Borders.ShapeBorder customBorder = default(FlutterSDK.Painting.Borders.ShapeBorder), double radius = default(double), VoidCallback onRemoved = default(VoidCallback))
{
    bool tapIsOnDeleteIcon = ChipDefaultClass._TapIsOnDeleteIcon(hasDeleteButton: HasDeleteButton, tapPosition: position, chipSize: ChipContext.Size, textDirection: textDirection);
    BuildContext splashContext = tapIsOnDeleteIcon ? DeleteIconKey.CurrentContext : ChipContext;
    InteractiveInkFeatureFactory splashFactory = ThemeDefaultClass.Theme.Of(splashContext).SplashFactory;
    if (tapIsOnDeleteIcon)
    {
        RenderBox currentBox = referenceBox;
        referenceBox = DeleteIconKey.CurrentContext.FindRenderObject() as RenderBox;
        position = referenceBox.GlobalToLocal(currentBox.LocalToGlobal(position));
        containedInkWell = false;
    }

    return splashFactory.Create(controller: controller, referenceBox: referenceBox, position: position, color: color, textDirection: textDirection, containedInkWell: containedInkWell, rectCallback: rectCallback, borderRadius: borderRadius, customBorder: customBorder, radius: radius, onRemoved: onRemoved);
}



#endregion
}


public enum _ChipSlot
{

    Label,
    Avatar,
    DeleteIcon,
}

}
