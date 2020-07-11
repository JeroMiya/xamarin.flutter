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
namespace FlutterSDK.Widgets.Focustraversal{
internal static class FocustraversalDefaultClass{
internal static FlutterSDK.Widgets.Framework.BuildContext _GetAncestor(FlutterSDK.Widgets.Framework.BuildContext context,int count = 1){
throw new NotImplementedException();
}

internal static void _FocusAndEnsureVisible(FlutterSDK.Widgets.Focusmanager.FocusNode node,FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy alignmentPolicy = default(FlutterSDK.Widgets.Scrollposition.ScrollPositionAlignmentPolicy)){
throw new NotImplementedException();
}

}

public interface IFocusTraversalPolicy{
FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocus(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode);
FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocusInDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode,FlutterSDK.Widgets.Focustraversal.TraversalDirection direction);
void InvalidateScopeData(FlutterSDK.Widgets.Focusmanager.FocusScopeNode node);
void ChangedScope(FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode),FlutterSDK.Widgets.Focusmanager.FocusScopeNode oldScope = default(FlutterSDK.Widgets.Focusmanager.FocusScopeNode));
bool Next(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode);
bool Previous(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode);
bool InDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode,FlutterSDK.Widgets.Focustraversal.TraversalDirection direction);
Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> SortDescendants(Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> descendants);
}


public interface IFocusOrder{
int CompareTo(FlutterSDK.Widgets.Focustraversal.FocusOrder other);
int DoCompare(FlutterSDK.Widgets.Focustraversal.FocusOrder other);
}


public interface IDirectionalFocusTraversalPolicyMixin{}

public class DirectionalFocusTraversalPolicyMixin{
internal virtual Dictionary<FlutterSDK.Widgets.Focusmanager.FocusScopeNode,FlutterSDK.Widgets.Focustraversal._DirectionalPolicyData> _PolicyData{get;set;}

public new void InvalidateScopeData(FlutterSDK.Widgets.Focusmanager.FocusScopeNode node){ throw new NotImplementedException(); }


public new void ChangedScope(FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode),FlutterSDK.Widgets.Focusmanager.FocusScopeNode oldScope = default(FlutterSDK.Widgets.Focusmanager.FocusScopeNode)){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocusInDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode,FlutterSDK.Widgets.Focustraversal.TraversalDirection direction){ throw new NotImplementedException(); }


private FlutterSDK.Widgets.Focusmanager.FocusNode _SortAndFindInitial(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode,bool vertical = default(bool),bool first = default(bool)){ throw new NotImplementedException(); }


private Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> _SortAndFilterHorizontally(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction,FlutterBinding.UI.Rect target,FlutterSDK.Widgets.Focusmanager.FocusNode nearestScope){ throw new NotImplementedException(); }


private Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> _SortAndFilterVertically(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction,FlutterBinding.UI.Rect target,Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> nodes){ throw new NotImplementedException(); }


private bool _PopPolicyDataIfNeeded(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction,FlutterSDK.Widgets.Focusmanager.FocusScopeNode nearestScope,FlutterSDK.Widgets.Focusmanager.FocusNode focusedChild){ throw new NotImplementedException(); }


private void _PushPolicyData(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction,FlutterSDK.Widgets.Focusmanager.FocusScopeNode nearestScope,FlutterSDK.Widgets.Focusmanager.FocusNode focusedChild){ throw new NotImplementedException(); }


public new bool InDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode,FlutterSDK.Widgets.Focustraversal.TraversalDirection direction){ throw new NotImplementedException(); }

}
public static class DirectionalFocusTraversalPolicyMixinMixin {
static System.Runtime.CompilerServices.ConditionalWeakTable<IDirectionalFocusTraversalPolicyMixin, DirectionalFocusTraversalPolicyMixin> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<IDirectionalFocusTraversalPolicyMixin, DirectionalFocusTraversalPolicyMixin>();
static DirectionalFocusTraversalPolicyMixin GetOrCreate(IDirectionalFocusTraversalPolicyMixin instance)
{
if (!_table.TryGetValue(instance, out var value))
{
value = new DirectionalFocusTraversalPolicyMixin();
_table.Add(instance, value);
}
return (DirectionalFocusTraversalPolicyMixin)value;
}
public static void InvalidateScopeData(this IDirectionalFocusTraversalPolicyMixin instance,FlutterSDK.Widgets.Focusmanager.FocusScopeNode node) => GetOrCreate(instance).InvalidateScopeData(node);
public static void ChangedScope(this IDirectionalFocusTraversalPolicyMixin instance,FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode),FlutterSDK.Widgets.Focusmanager.FocusScopeNode oldScope = default(FlutterSDK.Widgets.Focusmanager.FocusScopeNode)) => GetOrCreate(instance).ChangedScope(node, oldScope);
public static FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocusInDirection(this IDirectionalFocusTraversalPolicyMixin instance,FlutterSDK.Widgets.Focusmanager.FocusNode currentNode,FlutterSDK.Widgets.Focustraversal.TraversalDirection direction) => GetOrCreate(instance).FindFirstFocusInDirection(currentNode, direction);
public static bool InDirection(this IDirectionalFocusTraversalPolicyMixin instance,FlutterSDK.Widgets.Focusmanager.FocusNode currentNode,FlutterSDK.Widgets.Focustraversal.TraversalDirection direction) => GetOrCreate(instance).InDirection(currentNode, direction);
}


public class _FocusTraversalGroupInfo
{
#region constructors
public _FocusTraversalGroupInfo(FlutterSDK.Widgets.Focustraversal._FocusTraversalGroupMarker marker,FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy defaultPolicy = default(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy),List<FlutterSDK.Widgets.Focusmanager.FocusNode> members = default(List<FlutterSDK.Widgets.Focusmanager.FocusNode>))
: base()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Focusmanager.FocusNode GroupNode{get;set;}
public virtual FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy Policy{get;set;}
public virtual List<FlutterSDK.Widgets.Focusmanager.FocusNode> Members{get;set;}
#endregion

#region methods
#endregion
}


public class FocusTraversalPolicy : IDiagnosticable
{
#region constructors
public FocusTraversalPolicy()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocus(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode){ throw new NotImplementedException(); }


public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FindFirstFocusInDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode,FlutterSDK.Widgets.Focustraversal.TraversalDirection direction){ throw new NotImplementedException(); }


public virtual void InvalidateScopeData(FlutterSDK.Widgets.Focusmanager.FocusScopeNode node){ throw new NotImplementedException(); }


public virtual void ChangedScope(FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode),FlutterSDK.Widgets.Focusmanager.FocusScopeNode oldScope = default(FlutterSDK.Widgets.Focusmanager.FocusScopeNode)){ throw new NotImplementedException(); }


public virtual bool Next(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode){ throw new NotImplementedException(); }


public virtual bool Previous(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode){ throw new NotImplementedException(); }


public virtual bool InDirection(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode,FlutterSDK.Widgets.Focustraversal.TraversalDirection direction){ throw new NotImplementedException(); }


public virtual Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> SortDescendants(Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> descendants){ throw new NotImplementedException(); }


private FlutterSDK.Widgets.Focustraversal._FocusTraversalGroupMarker _GetMarker(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


private List<FlutterSDK.Widgets.Focusmanager.FocusNode> _SortAllDescendants(FlutterSDK.Widgets.Focusmanager.FocusScopeNode scope){ throw new NotImplementedException(); }


private bool _MoveFocus(FlutterSDK.Widgets.Focusmanager.FocusNode currentNode,bool forward = default(bool)){ throw new NotImplementedException(); }

#endregion
}


public class _DirectionalPolicyDataEntry
{
#region constructors
public _DirectionalPolicyDataEntry(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction = default(FlutterSDK.Widgets.Focustraversal.TraversalDirection),FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode))
: base()
{
this.Direction = direction;
this.Node = node;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Focustraversal.TraversalDirection Direction{get;set;}
public virtual FlutterSDK.Widgets.Focusmanager.FocusNode Node{get;set;}
#endregion

#region methods
#endregion
}


public class _DirectionalPolicyData
{
#region constructors
public _DirectionalPolicyData(List<FlutterSDK.Widgets.Focustraversal._DirectionalPolicyDataEntry> history = default(List<FlutterSDK.Widgets.Focustraversal._DirectionalPolicyDataEntry>))
: base()
{
this.History = history;throw new NotImplementedException(); }
#endregion

#region fields
public virtual List<FlutterSDK.Widgets.Focustraversal._DirectionalPolicyDataEntry> History{get;set;}
#endregion

#region methods
#endregion
}


public class WidgetOrderTraversalPolicy : FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy,IDirectionalFocusTraversalPolicyMixin
{
#region constructors
public WidgetOrderTraversalPolicy()
{ }
#endregion

#region fields
#endregion

#region methods

public new Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> SortDescendants(Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> descendants){ throw new NotImplementedException(); }

#endregion
}


public class _ReadingOrderSortData : IDiagnosticable
{
#region constructors
public _ReadingOrderSortData(FlutterSDK.Widgets.Focusmanager.FocusNode node)
: base()
{
this.Node = node;throw new NotImplementedException(); }
#endregion

#region fields
public virtual TextDirection Directionality{get;set;}
public virtual FlutterBinding.UI.Rect Rect{get;set;}
public virtual FlutterSDK.Widgets.Focusmanager.FocusNode Node{get;set;}
internal virtual List<FlutterSDK.Widgets.Basic.Directionality> _DirectionalAncestors{get;set;}
public virtual Iterable<FlutterSDK.Widgets.Basic.Directionality> DirectionalAncestors{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private TextDirection _FindDirectionality(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public virtual TextDirection CommonDirectionalityOf(List<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> list){ throw new NotImplementedException(); }


public virtual void SortWithDirectionality(List<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> list,TextDirection directionality){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class _ReadingOrderDirectionalGroupData : IDiagnosticable
{
#region constructors
public _ReadingOrderDirectionalGroupData(List<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> members)
{
this.Members = members;throw new NotImplementedException(); }
#endregion

#region fields
public virtual List<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> Members{get;set;}
internal virtual FlutterBinding.UI.Rect _Rect{get;set;}
internal virtual List<FlutterSDK.Widgets.Basic.Directionality> _MemberAncestors{get;set;}
public virtual TextDirection Directionality{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterBinding.UI.Rect Rect{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual List<FlutterSDK.Widgets.Basic.Directionality> MemberAncestors{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

public virtual void SortWithDirectionality(List<FlutterSDK.Widgets.Focustraversal._ReadingOrderDirectionalGroupData> list,TextDirection directionality){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class ReadingOrderTraversalPolicy : FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy,IDirectionalFocusTraversalPolicyMixin
{
#region constructors
public ReadingOrderTraversalPolicy()
{ }
#endregion

#region fields
#endregion

#region methods

private List<FlutterSDK.Widgets.Focustraversal._ReadingOrderDirectionalGroupData> _CollectDirectionalityGroups(Iterable<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> candidates){ throw new NotImplementedException(); }


private FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData _PickNext(List<FlutterSDK.Widgets.Focustraversal._ReadingOrderSortData> candidates){ throw new NotImplementedException(); }


public new Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> SortDescendants(Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> descendants){ throw new NotImplementedException(); }

#endregion
}


public class FocusOrder : IComparable<FlutterSDK.Widgets.Focustraversal.FocusOrder>,IDiagnosticable
{
#region constructors
public FocusOrder()
{
throw new NotImplementedException(); }
#endregion

#region fields
#endregion

#region methods

public new int CompareTo(FlutterSDK.Widgets.Focustraversal.FocusOrder other){ throw new NotImplementedException(); }


public virtual int DoCompare(FlutterSDK.Widgets.Focustraversal.FocusOrder other){ throw new NotImplementedException(); }

#endregion
}


public class NumericFocusOrder : FlutterSDK.Widgets.Focustraversal.FocusOrder
{
#region constructors
public NumericFocusOrder(double order)
: base()
{
this.Order = order;throw new NotImplementedException(); }
#endregion

#region fields
public virtual double Order{get;set;}
#endregion

#region methods

public new int DoCompare(FlutterSDK.Widgets.Focustraversal.NumericFocusOrder other){ throw new NotImplementedException(); }
public new int DoCompare(FlutterSDK.Widgets.Focustraversal.FocusOrder other){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class LexicalFocusOrder : FlutterSDK.Widgets.Focustraversal.FocusOrder
{
#region constructors
public LexicalFocusOrder(string order)
: base()
{
this.Order = order;throw new NotImplementedException(); }
#endregion

#region fields
public virtual string Order{get;set;}
#endregion

#region methods

public new int DoCompare(FlutterSDK.Widgets.Focustraversal.LexicalFocusOrder other){ throw new NotImplementedException(); }
public new int DoCompare(FlutterSDK.Widgets.Focustraversal.FocusOrder other){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class _OrderedFocusInfo
{
#region constructors
public _OrderedFocusInfo(FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode),FlutterSDK.Widgets.Focustraversal.FocusOrder order = default(FlutterSDK.Widgets.Focustraversal.FocusOrder))
: base()
{
this.Node = node;
this.Order = order;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Focusmanager.FocusNode Node{get;set;}
public virtual FlutterSDK.Widgets.Focustraversal.FocusOrder Order{get;set;}
#endregion

#region methods
#endregion
}


public class OrderedTraversalPolicy : FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy,IDirectionalFocusTraversalPolicyMixin
{
#region constructors
public OrderedTraversalPolicy(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy secondary = default(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy))
{
this.Secondary = secondary;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy Secondary{get;set;}
#endregion

#region methods

public new Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> SortDescendants(Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> descendants){ throw new NotImplementedException(); }

#endregion
}


public class FocusTraversalOrder : FlutterSDK.Widgets.Framework.InheritedWidget
{
#region constructors
public FocusTraversalOrder(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Focustraversal.FocusOrder order = default(FlutterSDK.Widgets.Focustraversal.FocusOrder),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key,child:child)
{
this.Order = order;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Focustraversal.FocusOrder Order{get;set;}
#endregion

#region methods

public virtual FlutterSDK.Widgets.Focustraversal.FocusOrder Of(FlutterSDK.Widgets.Framework.BuildContext context,bool nullOk = false){ throw new NotImplementedException(); }


public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class FocusTraversalGroup : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public FocusTraversalGroup(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy policy = default(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(key:key)
{
this.Child = child;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Framework.Widget Child{get;set;}
public virtual FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy Policy{get;set;}
#endregion

#region methods

public virtual FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy Of(FlutterSDK.Widgets.Framework.BuildContext context,bool nullOk = false){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Focustraversal._FocusTraversalGroupState CreateState(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class _FocusTraversalGroupState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Focustraversal.FocusTraversalGroup>
{
#region constructors
public _FocusTraversalGroupState()
{ }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode{get;set;}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _FocusTraversalGroupMarker : FlutterSDK.Widgets.Framework.InheritedWidget
{
#region constructors
public _FocusTraversalGroupMarker(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy policy = default(FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy),FlutterSDK.Widgets.Focusmanager.FocusNode focusNode = default(FlutterSDK.Widgets.Focusmanager.FocusNode),FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
: base(child:child)
{
this.Policy = policy;
this.FocusNode = focusNode;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Focustraversal.FocusTraversalPolicy Policy{get;set;}
public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusNode{get;set;}
#endregion

#region methods

public new bool UpdateShouldNotify(FlutterSDK.Widgets.Framework.InheritedWidget oldWidget){ throw new NotImplementedException(); }

#endregion
}


public class _RequestFocusActionBase : FlutterSDK.Widgets.Actions.Action
{
#region constructors
public _RequestFocusActionBase(FlutterSDK.Foundation.Key.LocalKey name)
: base(name)
{
throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _PreviousFocus{get;set;}
#endregion

#region methods

public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node,FlutterSDK.Widgets.Actions.Intent intent){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class RequestFocusAction : FlutterSDK.Widgets.Focustraversal._RequestFocusActionBase
{
#region constructors
public RequestFocusAction()
: base(Key)
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Foundation.Key.LocalKey Key{get;set;}
#endregion

#region methods

public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node,FlutterSDK.Widgets.Actions.Intent intent){ throw new NotImplementedException(); }

#endregion
}


public class NextFocusAction : FlutterSDK.Widgets.Focustraversal._RequestFocusActionBase
{
#region constructors
public NextFocusAction()
: base(Key)
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Foundation.Key.LocalKey Key{get;set;}
#endregion

#region methods

public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node,FlutterSDK.Widgets.Actions.Intent intent){ throw new NotImplementedException(); }

#endregion
}


public class PreviousFocusAction : FlutterSDK.Widgets.Focustraversal._RequestFocusActionBase
{
#region constructors
public PreviousFocusAction()
: base(Key)
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Foundation.Key.LocalKey Key{get;set;}
#endregion

#region methods

public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node,FlutterSDK.Widgets.Actions.Intent intent){ throw new NotImplementedException(); }

#endregion
}


public class DirectionalFocusIntent : FlutterSDK.Widgets.Actions.Intent
{
#region constructors
public DirectionalFocusIntent(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction,bool ignoreTextFields = true)
: base(FocustraversalDefaultClass.DirectionalFocusAction.Key)
{
this.Direction = direction;
this.IgnoreTextFields = ignoreTextFields;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Widgets.Focustraversal.TraversalDirection Direction{get;set;}
public virtual bool IgnoreTextFields{get;set;}
#endregion

#region methods
#endregion
}


public class DirectionalFocusAction : FlutterSDK.Widgets.Focustraversal._RequestFocusActionBase
{
#region constructors
public DirectionalFocusAction()
: base(Key)
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Foundation.Key.LocalKey Key{get;set;}
#endregion

#region methods

public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node,FlutterSDK.Widgets.Focustraversal.DirectionalFocusIntent intent){ throw new NotImplementedException(); }
public new void Invoke(FlutterSDK.Widgets.Focusmanager.FocusNode node,FlutterSDK.Widgets.Actions.Intent intent){ throw new NotImplementedException(); }

#endregion
}


public enum TraversalDirection{

Up,
Right,
Down,
Left,
}

}
