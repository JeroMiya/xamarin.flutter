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
namespace FlutterSDK.Material.Switch
{
    internal static class SwitchDefaultClass
    {
        public static double _KTrackHeight = default(double);
        public static double _KTrackWidth = default(double);
        public static double _KTrackRadius = default(double);
        public static double _KThumbRadius = default(double);
        public static double _KSwitchWidth = default(double);
        public static double _KSwitchHeight = default(double);
        public static double _KSwitchHeightCollapsed = default(double);
    }

    public class Switch : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public Switch(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool value = default(bool), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color activeTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveThumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTrackColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Imageprovider.ImageProvider<object> activeThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imagestream.ImageErrorListener onActiveThumbImageError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener), FlutterSDK.Painting.Imageprovider.ImageProvider<object> inactiveThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imagestream.ImageErrorListener onInactiveThumbImageError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false)
        : base(key: key)
        {
            this.Value = value;
            this.OnChanged = onChanged;
            this.ActiveColor = activeColor;
            this.ActiveTrackColor = activeTrackColor;
            this.InactiveThumbColor = inactiveThumbColor;
            this.InactiveTrackColor = inactiveTrackColor;
            this.ActiveThumbImage = activeThumbImage;
            this.OnActiveThumbImageError = onActiveThumbImageError;
            this.InactiveThumbImage = inactiveThumbImage;
            this.OnInactiveThumbImageError = onInactiveThumbImageError;
            this.MaterialTapTargetSize = materialTapTargetSize;
            this.DragStartBehavior = dragStartBehavior;
            this.FocusColor = focusColor;
            this.HoverColor = hoverColor;
            this.FocusNode = focusNode;
            this.Autofocus = autofocus; throw new NotImplementedException();
        }
        public static Switch Adaptive(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool value = default(bool), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color activeTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveThumbColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTrackColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Imageprovider.ImageProvider<object> activeThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imagestream.ImageErrorListener onActiveThumbImageError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener), FlutterSDK.Painting.Imageprovider.ImageProvider<object> inactiveThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imagestream.ImageErrorListener onInactiveThumbImageError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener), FlutterSDK.Material.Themedata.MaterialTapTargetSize materialTapTargetSize = default(FlutterSDK.Material.Themedata.MaterialTapTargetSize), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode), bool autofocus = false)
        {
            var instance = new Switch(key: key); instance.Value = value;
            instance.OnChanged = onChanged;
            instance.ActiveColor = activeColor;
            instance.ActiveTrackColor = activeTrackColor;
            instance.InactiveThumbColor = inactiveThumbColor;
            instance.InactiveTrackColor = inactiveTrackColor;
            instance.ActiveThumbImage = activeThumbImage;
            instance.OnActiveThumbImageError = onActiveThumbImageError;
            instance.InactiveThumbImage = inactiveThumbImage;
            instance.OnInactiveThumbImageError = onInactiveThumbImageError;
            instance.MaterialTapTargetSize = materialTapTargetSize;
            instance.DragStartBehavior = dragStartBehavior;
            instance.FocusColor = focusColor;
            instance.HoverColor = hoverColor;
            instance.FocusNode = focusNode;
            instance.Autofocus = autofocus; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Value { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get; set; }
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        public virtual FlutterBinding.UI.Color ActiveTrackColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveThumbColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveTrackColor { get; set; }
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> ActiveThumbImage { get; set; }
        public virtual FlutterSDK.Painting.Imagestream.ImageErrorListener OnActiveThumbImageError { get; set; }
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> InactiveThumbImage { get; set; }
        public virtual FlutterSDK.Painting.Imagestream.ImageErrorListener OnInactiveThumbImageError { get; set; }
        public virtual FlutterSDK.Material.Themedata.MaterialTapTargetSize MaterialTapTargetSize { get; set; }
        internal virtual FlutterSDK.Material.Switch._SwitchType _SwitchType { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode { get; set; }
        public virtual bool Autofocus { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Switch._SwitchState CreateState() { throw new NotImplementedException(); }


        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SwitchState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Switch.Switch>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public _SwitchState()
        { }
        #endregion

        #region fields
        internal virtual Dictionary<FlutterSDK.Foundation.Key.LocalKey, object> _ActionMap { get; set; }
        internal virtual bool _Focused { get; set; }
        internal virtual bool _Hovering { get; set; }
        public virtual bool Enabled { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        private void _ActionHandler(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Widgets.Actions.Intent intent) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Actions.Action _CreateAction() { throw new NotImplementedException(); }


        private void _HandleFocusHighlightChanged(bool focused) { throw new NotImplementedException(); }


        private void _HandleHoverChanged(bool hovering) { throw new NotImplementedException(); }


        public virtual Size GetSwitchSize(FlutterSDK.Material.Themedata.ThemeData theme) { throw new NotImplementedException(); }


        private void _DidFinishDragging() { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Widget BuildMaterialSwitch(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public virtual FlutterSDK.Widgets.Framework.Widget BuildCupertinoSwitch(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    public class _SwitchRenderObjectWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
    {
        #region constructors
        public _SwitchRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), bool value = default(bool), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Imageprovider.ImageProvider<object> activeThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imagestream.ImageErrorListener onActiveThumbImageError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener), FlutterSDK.Painting.Imageprovider.ImageProvider<object> inactiveThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imagestream.ImageErrorListener onInactiveThumbImageError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener), FlutterBinding.UI.Color activeTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTrackColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool hasFocus = default(bool), bool hovering = default(bool), FlutterSDK.Material.Switch._SwitchState state = default(FlutterSDK.Material.Switch._SwitchState))
        : base(key: key)
        {
            this.Value = value;
            this.ActiveColor = activeColor;
            this.InactiveColor = inactiveColor;
            this.HoverColor = hoverColor;
            this.FocusColor = focusColor;
            this.ActiveThumbImage = activeThumbImage;
            this.OnActiveThumbImageError = onActiveThumbImageError;
            this.InactiveThumbImage = inactiveThumbImage;
            this.OnInactiveThumbImageError = onInactiveThumbImageError;
            this.ActiveTrackColor = activeTrackColor;
            this.InactiveTrackColor = inactiveTrackColor;
            this.Configuration = configuration;
            this.OnChanged = onChanged;
            this.AdditionalConstraints = additionalConstraints;
            this.DragStartBehavior = dragStartBehavior;
            this.HasFocus = hasFocus;
            this.Hovering = hovering;
            this.State = state; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual bool Value { get; set; }
        public virtual FlutterBinding.UI.Color ActiveColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveColor { get; set; }
        public virtual FlutterBinding.UI.Color HoverColor { get; set; }
        public virtual FlutterBinding.UI.Color FocusColor { get; set; }
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> ActiveThumbImage { get; set; }
        public virtual FlutterSDK.Painting.Imagestream.ImageErrorListener OnActiveThumbImageError { get; set; }
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> InactiveThumbImage { get; set; }
        public virtual FlutterSDK.Painting.Imagestream.ImageErrorListener OnInactiveThumbImageError { get; set; }
        public virtual FlutterBinding.UI.Color ActiveTrackColor { get; set; }
        public virtual FlutterBinding.UI.Color InactiveTrackColor { get; set; }
        public virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration Configuration { get; set; }
        public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<bool> OnChanged { get; set; }
        public virtual FlutterSDK.Rendering.Box.BoxConstraints AdditionalConstraints { get; set; }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get; set; }
        public virtual bool HasFocus { get; set; }
        public virtual bool Hovering { get; set; }
        public virtual FlutterSDK.Material.Switch._SwitchState State { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Material.Switch._RenderSwitch CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }


        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Material.Switch._RenderSwitch renderObject) { throw new NotImplementedException(); }
        public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Rendering.@object.RenderObject renderObject) { throw new NotImplementedException(); }

        #endregion
    }


    public class _RenderSwitch : FlutterSDK.Material.Toggleable.RenderToggleable
    {
        #region constructors
        public _RenderSwitch(bool value = default(bool), FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color hoverColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color focusColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Imageprovider.ImageProvider<object> activeThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imagestream.ImageErrorListener onActiveThumbImageError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener), FlutterSDK.Painting.Imageprovider.ImageProvider<object> inactiveThumbImage = default(FlutterSDK.Painting.Imageprovider.ImageProvider<object>), FlutterSDK.Painting.Imagestream.ImageErrorListener onInactiveThumbImageError = default(FlutterSDK.Painting.Imagestream.ImageErrorListener), FlutterBinding.UI.Color activeTrackColor = default(FlutterBinding.UI.Color), FlutterBinding.UI.Color inactiveTrackColor = default(FlutterBinding.UI.Color), FlutterSDK.Painting.Imageprovider.ImageConfiguration configuration = default(FlutterSDK.Painting.Imageprovider.ImageConfiguration), FlutterSDK.Rendering.Box.BoxConstraints additionalConstraints = default(FlutterSDK.Rendering.Box.BoxConstraints), TextDirection textDirection = default(TextDirection), FlutterSDK.Foundation.Basictypes.ValueChanged<bool> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<bool>), FlutterSDK.Gestures.Recognizer.DragStartBehavior dragStartBehavior = default(FlutterSDK.Gestures.Recognizer.DragStartBehavior), bool hasFocus = default(bool), bool hovering = default(bool), FlutterSDK.Material.Switch._SwitchState state = default(FlutterSDK.Material.Switch._SwitchState))
        : base(value: value, tristate: false, activeColor: activeColor, inactiveColor: inactiveColor, hoverColor: hoverColor, focusColor: focusColor, onChanged: onChanged, additionalConstraints: additionalConstraints, hasFocus: hasFocus, hovering: hovering, vsync: state)
        {
            this.State = state; throw new NotImplementedException();
        }
        #endregion

        #region fields
        internal virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> _ActiveThumbImage { get; set; }
        internal virtual FlutterSDK.Painting.Imagestream.ImageErrorListener _OnActiveThumbImageError { get; set; }
        internal virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> _InactiveThumbImage { get; set; }
        internal virtual FlutterSDK.Painting.Imagestream.ImageErrorListener _OnInactiveThumbImageError { get; set; }
        internal virtual FlutterBinding.UI.Color _ActiveTrackColor { get; set; }
        internal virtual FlutterBinding.UI.Color _InactiveTrackColor { get; set; }
        internal virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration _Configuration { get; set; }
        internal virtual TextDirection _TextDirection { get; set; }
        public virtual FlutterSDK.Material.Switch._SwitchState State { get; set; }
        internal virtual FlutterSDK.Gestures.Monodrag.HorizontalDragGestureRecognizer _Drag { get; set; }
        internal virtual bool _NeedsPositionAnimation { get; set; }
        internal virtual FlutterBinding.UI.Color _CachedThumbColor { get; set; }
        internal virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> _CachedThumbImage { get; set; }
        internal virtual FlutterSDK.Painting.Imagestream.ImageErrorListener _CachedThumbErrorListener { get; set; }
        internal virtual FlutterSDK.Painting.Decoration.BoxPainter _CachedThumbPainter { get; set; }
        internal virtual bool _IsPainting { get; set; }
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> ActiveThumbImage { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Imagestream.ImageErrorListener OnActiveThumbImageError { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Imageprovider.ImageProvider<object> InactiveThumbImage { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Imagestream.ImageErrorListener OnInactiveThumbImageError { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color ActiveTrackColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Color InactiveTrackColor { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Painting.Imageprovider.ImageConfiguration Configuration { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual TextDirection TextDirection { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Gestures.Recognizer.DragStartBehavior DragStartBehavior { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool Value { set { throw new NotImplementedException(); } }
        internal virtual double _TrackInnerLength { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        #endregion

        #region methods

        public new void Detach() { throw new NotImplementedException(); }


        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details) { throw new NotImplementedException(); }


        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details) { throw new NotImplementedException(); }


        private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details) { throw new NotImplementedException(); }


        public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event, FlutterSDK.Rendering.Box.BoxHitTestEntry entry) { throw new NotImplementedException(); }


        private FlutterSDK.Painting.Boxdecoration.BoxDecoration _CreateDefaultThumbDecoration(FlutterBinding.UI.Color color, FlutterSDK.Painting.Imageprovider.ImageProvider<object> image, FlutterSDK.Painting.Imagestream.ImageErrorListener errorListener) { throw new NotImplementedException(); }


        private void _HandleDecorationChanged() { throw new NotImplementedException(); }


        public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config) { throw new NotImplementedException(); }


        public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context, FlutterBinding.UI.Offset offset) { throw new NotImplementedException(); }

        #endregion
    }


    public enum _SwitchType
    {

        Material,
        Adaptive,
    }

}
