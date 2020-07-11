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
using FlutterSDK.Widgets.Constants;
using FlutterSDK.Widgets.Routenotificationmessages;
namespace FlutterSDK.Widgets.Textselection
{
    public delegate void TextSelectionOverlayChanged(FlutterSDK.Services.Textinput.TextEditingValue value, FlutterBinding.UI.Rect caretRect);
    public delegate void DragSelectionUpdateCallback(FlutterSDK.Gestures.Dragdetails.DragStartDetails startDetails, FlutterSDK.Gestures.Dragdetails.DragUpdateDetails updateDetails);
    internal static class TextselectionDefaultClass
    {
        public static TimeSpan _KDragSelectionUpdateThrottle = default(TimeSpan);
    }

    public interface ITextSelectionControls { }

    public class TextSelectionControls
    {

        public virtual FlutterSDK.Widgets.Framework.Widget BuildHandle(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Textselection.TextSelectionHandleType type, double textLineHeight) { throw new NotImplementedException(); }


        public virtual Offset GetHandleAnchor(FlutterSDK.Widgets.Textselection.TextSelectionHandleType type, double textLineHeight) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Widget BuildToolbar(FlutterSDK.Widgets.Framework.BuildContext context, FlutterBinding.UI.Rect globalEditableRegion, double textLineHeight, FlutterBinding.UI.Offset position, List<FlutterSDK.Rendering.Editable.TextSelectionPoint> endpoints, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) { throw new NotImplementedException(); }


        public virtual Size GetHandleSize(double textLineHeight) { throw new NotImplementedException(); }


        public virtual bool CanCut(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) { throw new NotImplementedException(); }


        public virtual bool CanCopy(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) { throw new NotImplementedException(); }


        public virtual bool CanPaste(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) { throw new NotImplementedException(); }


        public virtual bool CanSelectAll(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) { throw new NotImplementedException(); }


        public virtual void HandleCut(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) { throw new NotImplementedException(); }


        public virtual void HandleCopy(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) { throw new NotImplementedException(); }


        public virtual Future<object> HandlePaste(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) { throw new NotImplementedException(); }


        public virtual void HandleSelectAll(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) { throw new NotImplementedException(); }

    }
    public static class TextSelectionControlsMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<ITextSelectionControls, TextSelectionControls> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ITextSelectionControls, TextSelectionControls>();
        static TextSelectionControls GetOrCreate(ITextSelectionControls instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new TextSelectionControls();
                _table.Add(instance, value);
            }
            return (TextSelectionControls)value;
        }
        public static FlutterSDK.Widgets.Framework.Widget BuildHandle(this ITextSelectionControls instance, FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Textselection.TextSelectionHandleType type, double textLineHeight) => GetOrCreate(instance).BuildHandle(context, type, textLineHeight);
        public static Offset GetHandleAnchor(this ITextSelectionControls instance, FlutterSDK.Widgets.Textselection.TextSelectionHandleType type, double textLineHeight) => GetOrCreate(instance).GetHandleAnchor(type, textLineHeight);
        public static FlutterSDK.Widgets.Framework.Widget BuildToolbar(this ITextSelectionControls instance, FlutterSDK.Widgets.Framework.BuildContext context, FlutterBinding.UI.Rect globalEditableRegion, double textLineHeight, FlutterBinding.UI.Offset position, List<FlutterSDK.Rendering.Editable.TextSelectionPoint> endpoints, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) => GetOrCreate(instance).BuildToolbar(context, globalEditableRegion, textLineHeight, position, endpoints, @delegate);
        public static Size GetHandleSize(this ITextSelectionControls instance, double textLineHeight) => GetOrCreate(instance).GetHandleSize(textLineHeight);
        public static bool CanCut(this ITextSelectionControls instance, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) => GetOrCreate(instance).CanCut(@delegate);
        public static bool CanCopy(this ITextSelectionControls instance, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) => GetOrCreate(instance).CanCopy(@delegate);
        public static bool CanPaste(this ITextSelectionControls instance, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) => GetOrCreate(instance).CanPaste(@delegate);
        public static bool CanSelectAll(this ITextSelectionControls instance, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) => GetOrCreate(instance).CanSelectAll(@delegate);
        public static void HandleCut(this ITextSelectionControls instance, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) => GetOrCreate(instance).HandleCut(@delegate);
        public static void HandleCopy(this ITextSelectionControls instance, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) => GetOrCreate(instance).HandleCopy(@delegate);
        public static Future<object> HandlePaste(this ITextSelectionControls instance, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) => GetOrCreate(instance).HandlePaste(@delegate);
        public static void HandleSelectAll(this ITextSelectionControls instance, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate) => GetOrCreate(instance).HandleSelectAll(@delegate);
    }


    public interface ITextSelectionGestureDetectorBuilderDelegate { }

    public class TextSelectionGestureDetectorBuilderDelegate
    {
        public virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Editabletext.EditableTextState> EditableTextKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool ForcePressEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool SelectionEnabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }
    public static class TextSelectionGestureDetectorBuilderDelegateMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<ITextSelectionGestureDetectorBuilderDelegate, TextSelectionGestureDetectorBuilderDelegate> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ITextSelectionGestureDetectorBuilderDelegate, TextSelectionGestureDetectorBuilderDelegate>();
        static TextSelectionGestureDetectorBuilderDelegate GetOrCreate(ITextSelectionGestureDetectorBuilderDelegate instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new TextSelectionGestureDetectorBuilderDelegate();
                _table.Add(instance, value);
            }
            return (TextSelectionGestureDetectorBuilderDelegate)value;
        }
        public static FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Editabletext.EditableTextState> EditableTextKeyProperty(this ITextSelectionGestureDetectorBuilderDelegate instance) => GetOrCreate(instance).EditableTextKey;
        public static bool ForcePressEnabledProperty(this ITextSelectionGestureDetectorBuilderDelegate instance) => GetOrCreate(instance).ForcePressEnabled;
        public static bool SelectionEnabledProperty(this ITextSelectionGestureDetectorBuilderDelegate instance) => GetOrCreate(instance).SelectionEnabled;
    }


    public class TextSelectionOverlay
    {
        #region constructors
        public TextSelectionOverlay(FlutterSDK.Services.Textinput.TextEditingValue value = default(FlutterSDK.Services.Textinput.TextEditingValue), FlutterSDK.Widgets.Framework.BuildContext context = default(FlutterSDK.Widgets.Framework.BuildContext), FlutterSDK.Widgets.Framework.Widget debugRequiredFor = default(FlutterSDK.Widgets.Framework.Widget), FlutterSDK.Rendering.Layer.LayerLink toolbarLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Rendering.Layer.LayerLink startHandleLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Rendering.Layer.LayerLink endHandleLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Rendering.Editable.RenderEditable renderObject = default(FlutterSDK.Rendering.Editable.RenderEditable), FlutterSDK.Widgets.Textselection.TextSelectionControls selectionControls = default(FlutterSDK.Widgets.Textselection.TextSelectionControls), bool handlesVisible = false, FlutterSDK.Services.Textinput.TextSelectionDelegate selectionDelegate = default(FlutterSDK.Services.Textinput.TextSelectionDelegate), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), VoidCallback onSelectionHandleTapped = default(VoidCallback))
        : base()
        {
            this.Context = context;
            this.DebugRequiredFor = debugRequiredFor;
            this.ToolbarLayerLink = toolbarLayerLink;
            this.StartHandleLayerLink = startHandleLayerLink;
            this.EndHandleLayerLink = endHandleLayerLink;
            this.RenderObject = renderObject;
            this.SelectionControls = selectionControls;
            this.SelectionDelegate = selectionDelegate;
            this.DragStartBehavior = dragStartBehavior;
            this.OnSelectionHandleTapped = onSelectionHandleTapped; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Framework.BuildContext Context { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget DebugRequiredFor { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LayerLink ToolbarLayerLink { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LayerLink StartHandleLayerLink { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LayerLink EndHandleLayerLink { get; set; }
        public virtual FlutterSDK.Rendering.Editable.RenderEditable RenderObject { get; set; }
        public virtual FlutterSDK.Widgets.Textselection.TextSelectionControls SelectionControls { get; set; }
        public virtual FlutterSDK.Services.Textinput.TextSelectionDelegate SelectionDelegate { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        public virtual VoidCallback OnSelectionHandleTapped { get; set; }
        public virtual TimeSpan FadeDuration { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _ToolbarController { get; set; }
        internal virtual FlutterSDK.Services.Textinput.TextEditingValue _Value { get; set; }
        internal virtual List<FlutterSDK.Widgets.Overlay.OverlayEntry> _Handles { get; set; }
        internal virtual FlutterSDK.Widgets.Overlay.OverlayEntry _Toolbar { get; set; }
        internal virtual bool _HandlesVisible { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _ToolbarOpacity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Services.Textinput.TextEditingValue Value { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        internal virtual FlutterSDK.Services.Textediting.TextSelection _Selection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HandlesVisible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HandlesAreVisible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool ToolbarIsVisible { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void ShowHandles() { throw new NotImplementedException(); }


        public virtual void HideHandles() { throw new NotImplementedException(); }


        public virtual void ShowToolbar() { throw new NotImplementedException(); }


        public virtual void Update(FlutterSDK.Services.Textinput.TextEditingValue newValue) { throw new NotImplementedException(); }


        public virtual void UpdateForScroll() { throw new NotImplementedException(); }


        private void _MarkNeedsBuild(TimeSpan duration = default(TimeSpan)) { throw new NotImplementedException(); }


        public virtual void Hide() { throw new NotImplementedException(); }


        public virtual void HideToolbar() { throw new NotImplementedException(); }


        public virtual void Dispose() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildHandle(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Textselection._TextSelectionHandlePosition position) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _BuildToolbar(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        private void _HandleSelectionHandleChanged(FlutterSDK.Services.Textediting.TextSelection newSelection, FlutterSDK.Widgets.Textselection._TextSelectionHandlePosition position) { throw new NotImplementedException(); }

        #endregion
    }


    public class _TextSelectionHandleOverlay : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public _TextSelectionHandleOverlay(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Services.Textediting.TextSelection selection = default(FlutterSDK.Services.Textediting.TextSelection), FlutterSDK.Widgets.Textselection._TextSelectionHandlePosition position = default(FlutterSDK.Widgets.Textselection._TextSelectionHandlePosition), FlutterSDK.Rendering.Layer.LayerLink startHandleLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Rendering.Layer.LayerLink endHandleLayerLink = default(FlutterSDK.Rendering.Layer.LayerLink), FlutterSDK.Rendering.Editable.RenderEditable renderObject = default(FlutterSDK.Rendering.Editable.RenderEditable), FlutterSDK.Foundation.Basictypes.ValueChanged<TextSelection> onSelectionHandleChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<TextSelection>), VoidCallback onSelectionHandleTapped = default(VoidCallback), FlutterSDK.Widgets.Textselection.TextSelectionControls selectionControls = default(FlutterSDK.Widgets.Textselection.TextSelectionControls), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior))
        : base(key: key)
        {
            this.Selection = selection;
            this.Position = position;
            this.StartHandleLayerLink = startHandleLayerLink;
            this.EndHandleLayerLink = endHandleLayerLink;
            this.RenderObject = renderObject;
            this.OnSelectionHandleChanged = onSelectionHandleChanged;
            this.OnSelectionHandleTapped = onSelectionHandleTapped;
            this.SelectionControls = selectionControls;
            this.DragStartBehavior = dragStartBehavior; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Services.Textediting.TextSelection Selection { get; set; }
        public virtual FlutterSDK.Widgets.Textselection._TextSelectionHandlePosition Position { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LayerLink StartHandleLayerLink { get; set; }
        public virtual FlutterSDK.Rendering.Layer.LayerLink EndHandleLayerLink { get; set; }
        public virtual FlutterSDK.Rendering.Editable.RenderEditable RenderObject { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<TextSelection> OnSelectionHandleChanged { get; set; }
        public virtual VoidCallback OnSelectionHandleTapped { get; set; }
        public virtual FlutterSDK.Widgets.Textselection.TextSelectionControls SelectionControls { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        internal virtual FlutterSDK.Foundation.Changenotifier.ValueListenable<bool> _Visibility { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Textselection._TextSelectionHandleOverlayState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _TextSelectionHandleOverlayState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Textselection._TextSelectionHandleOverlay>, ISingleTickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _TextSelectionHandleOverlayState()
        { }
        #endregion

        #region fields
        internal virtual FlutterBinding.UI.Offset _DragPosition { get; set; }
        internal virtual FlutterSDK.Animation.Animationcontroller.AnimationController _Controller { get; set; }
        internal virtual FlutterSDK.Animation.Animation.Animation<double> _Opacity { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        private void _HandleVisibilityChanged() { throw new NotImplementedException(); }


        public new void DidUpdateWidget(FlutterSDK.Widgets.Textselection._TextSelectionHandleOverlay oldWidget) { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) { throw new NotImplementedException(); }


        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details) { throw new NotImplementedException(); }


        private void _HandleTap() { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Textselection.TextSelectionHandleType _ChooseType(TextDirection textDirection, FlutterSDK.Widgets.Textselection.TextSelectionHandleType ltrType, FlutterSDK.Widgets.Textselection.TextSelectionHandleType rtlType) { throw new NotImplementedException(); }

        #endregion
    }


    public class TextSelectionGestureDetectorBuilder
    {
        #region constructors
        public TextSelectionGestureDetectorBuilder(FlutterSDK.Widgets.Textselection.TextSelectionGestureDetectorBuilderDelegate @delegate = default(FlutterSDK.Widgets.Textselection.TextSelectionGestureDetectorBuilderDelegate))
        : base()
        {
            this.@delegate = @delegate; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Textselection.TextSelectionGestureDetectorBuilderDelegate @delegate { get; set; }
        internal virtual bool _ShouldShowSelectionToolbar { get; set; }
        public virtual bool ShouldShowSelectionToolbar { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Editabletext.EditableTextState EditableText { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Rendering.Editable.RenderEditable RenderEditable { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public virtual void OnTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details) { throw new NotImplementedException(); }


        public virtual void OnForcePressStart(FlutterSDK.Gestures.Forcepress.ForcePressDetails details) { throw new NotImplementedException(); }


        public virtual void OnForcePressEnd(FlutterSDK.Gestures.Forcepress.ForcePressDetails details) { throw new NotImplementedException(); }


        public virtual void OnSingleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details) { throw new NotImplementedException(); }


        public virtual void OnSingleTapCancel() { throw new NotImplementedException(); }


        public virtual void OnSingleLongTapStart(FlutterSDK.Gestures.Longpress.LongPressStartDetails details) { throw new NotImplementedException(); }


        public virtual void OnSingleLongTapMoveUpdate(FlutterSDK.Gestures.Longpress.LongPressMoveUpdateDetails details) { throw new NotImplementedException(); }


        public virtual void OnSingleLongTapEnd(FlutterSDK.Gestures.Longpress.LongPressEndDetails details) { throw new NotImplementedException(); }


        public virtual void OnDoubleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details) { throw new NotImplementedException(); }


        public virtual void OnDragSelectionStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) { throw new NotImplementedException(); }


        public virtual void OnDragSelectionUpdate(FlutterSDK.Gestures.Dragdetails.DragStartDetails startDetails, FlutterSDK.Gestures.Dragdetails.DragUpdateDetails updateDetails) { throw new NotImplementedException(); }


        public virtual void OnDragSelectionEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Widget BuildGestureDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget)) { throw new NotImplementedException(); }

        #endregion
    }


    public class TextSelectionGestureDetector : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public TextSelectionGestureDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Gestures.Tap.GestureTapDownCallback onTapDown = default(FlutterSDK.Gestures.Tap.GestureTapDownCallback), FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback onForcePressStart = default(FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback), FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback onForcePressEnd = default(FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback), FlutterSDK.Gestures.Tap.GestureTapUpCallback onSingleTapUp = default(FlutterSDK.Gestures.Tap.GestureTapUpCallback), FlutterSDK.Gestures.Tap.GestureTapCancelCallback onSingleTapCancel = default(FlutterSDK.Gestures.Tap.GestureTapCancelCallback), FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback onSingleLongTapStart = default(FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback), FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback onSingleLongTapMoveUpdate = default(FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback), FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback onSingleLongTapEnd = default(FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback), FlutterSDK.Gestures.Tap.GestureTapDownCallback onDoubleTapDown = default(FlutterSDK.Gestures.Tap.GestureTapDownCallback), FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback onDragSelectionStart = default(FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback), FlutterSDK.Widgets.Textselection.DragSelectionUpdateCallback onDragSelectionUpdate = default(FlutterSDK.Widgets.Textselection.DragSelectionUpdateCallback), FlutterSDK.Gestures.Monodrag.GestureDragEndCallback onDragSelectionEnd = default(FlutterSDK.Gestures.Monodrag.GestureDragEndCallback), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        : base(key: key)
        {
            this.OnTapDown = onTapDown;
            this.OnForcePressStart = onForcePressStart;
            this.OnForcePressEnd = onForcePressEnd;
            this.OnSingleTapUp = onSingleTapUp;
            this.OnSingleTapCancel = onSingleTapCancel;
            this.OnSingleLongTapStart = onSingleLongTapStart;
            this.OnSingleLongTapMoveUpdate = onSingleLongTapMoveUpdate;
            this.OnSingleLongTapEnd = onSingleLongTapEnd;
            this.OnDoubleTapDown = onDoubleTapDown;
            this.OnDragSelectionStart = onDragSelectionStart;
            this.OnDragSelectionUpdate = onDragSelectionUpdate;
            this.OnDragSelectionEnd = onDragSelectionEnd;
            this.Behavior = behavior;
            this.Child = child; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Gestures.Tap.GestureTapDownCallback OnTapDown { get; set; }
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressStartCallback OnForcePressStart { get; set; }
        public virtual FlutterSDK.Gestures.Forcepress.GestureForcePressEndCallback OnForcePressEnd { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapUpCallback OnSingleTapUp { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapCancelCallback OnSingleTapCancel { get; set; }
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressStartCallback OnSingleLongTapStart { get; set; }
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressMoveUpdateCallback OnSingleLongTapMoveUpdate { get; set; }
        public virtual FlutterSDK.Gestures.Longpress.GestureLongPressEndCallback OnSingleLongTapEnd { get; set; }
        public virtual FlutterSDK.Gestures.Tap.GestureTapDownCallback OnDoubleTapDown { get; set; }
        public virtual FlutterSDK.Gestures.Dragdetails.GestureDragStartCallback OnDragSelectionStart { get; set; }
        public virtual FlutterSDK.Widgets.Textselection.DragSelectionUpdateCallback OnDragSelectionUpdate { get; set; }
        public virtual FlutterSDK.Gestures.Monodrag.GestureDragEndCallback OnDragSelectionEnd { get; set; }
        public virtual FlutterSDK.Rendering.Proxybox.HitTestBehavior Behavior { get; set; }
        public virtual FlutterSDK.Widgets.Framework.Widget Child { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    public class _TextSelectionGestureDetectorState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Textselection.TextSelectionGestureDetector>
    {
        #region constructors
        public _TextSelectionGestureDetectorState()
        { }
        #endregion

        #region fields
        internal virtual Timer _DoubleTapTimer { get; set; }
        internal virtual FlutterBinding.UI.Offset _LastTapOffset { get; set; }
        internal virtual bool _IsDoubleTap { get; set; }
        internal virtual FlutterSDK.Gestures.Dragdetails.DragStartDetails _LastDragStartDetails { get; set; }
        internal virtual FlutterSDK.Gestures.Dragdetails.DragUpdateDetails _LastDragUpdateDetails { get; set; }
        internal virtual Timer _DragUpdateThrottleTimer { get; set; }
        #endregion

        #region methods

        public new void Dispose() { throw new NotImplementedException(); }


        private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details) { throw new NotImplementedException(); }


        private void _HandleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details) { throw new NotImplementedException(); }


        private void _HandleTapCancel() { throw new NotImplementedException(); }


        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) { throw new NotImplementedException(); }


        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details) { throw new NotImplementedException(); }


        private void _HandleDragUpdateThrottled() { throw new NotImplementedException(); }


        private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) { throw new NotImplementedException(); }


        private void _ForcePressStarted(FlutterSDK.Gestures.Forcepress.ForcePressDetails details) { throw new NotImplementedException(); }


        private void _ForcePressEnded(FlutterSDK.Gestures.Forcepress.ForcePressDetails details) { throw new NotImplementedException(); }


        private void _HandleLongPressStart(FlutterSDK.Gestures.Longpress.LongPressStartDetails details) { throw new NotImplementedException(); }


        private void _HandleLongPressMoveUpdate(FlutterSDK.Gestures.Longpress.LongPressMoveUpdateDetails details) { throw new NotImplementedException(); }


        private void _HandleLongPressEnd(FlutterSDK.Gestures.Longpress.LongPressEndDetails details) { throw new NotImplementedException(); }


        private void _DoubleTapTimeout() { throw new NotImplementedException(); }


        private bool _IsWithinDoubleTapTolerance(FlutterBinding.UI.Offset secondTapOffset) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _TransparentTapGestureRecognizer : FlutterSDK.Gestures.Tap.TapGestureRecognizer
    {
        #region constructors
        public _TransparentTapGestureRecognizer(@Object debugOwner = default(@Object))
        : base(debugOwner: debugOwner)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new void RejectGesture(int pointer) { throw new NotImplementedException(); }

        #endregion
    }


    public enum TextSelectionHandleType
    {

        Left,
        Right,
        Collapsed,
    }


    public enum _TextSelectionHandlePosition
    {

        Start,
        End,
    }

}
