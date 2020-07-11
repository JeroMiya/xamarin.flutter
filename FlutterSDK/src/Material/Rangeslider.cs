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
namespace FlutterSDK.Material.Rangeslider{
internal static class RangesliderDefaultClass{
}

public class RangeSlider : FlutterSDK.Widgets.Framework.StatefulWidget
{
#region constructors
public RangeSlider(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Material.Slidertheme.RangeValues values = default(FlutterSDK.Material.Slidertheme.RangeValues),FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>),FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>),FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>),double min = 0.0,double max = 1.0,int divisions = default(int),FlutterSDK.Material.Slidertheme.RangeLabels labels = default(FlutterSDK.Material.Slidertheme.RangeLabels),FlutterBinding.UI.Color activeColor = default(FlutterBinding.UI.Color),FlutterBinding.UI.Color inactiveColor = default(FlutterBinding.UI.Color),FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback semanticFormatterCallback = default(FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback))
: base(key:key)
{
this.Values = values;
this.OnChanged = onChanged;
this.OnChangeStart = onChangeStart;
this.OnChangeEnd = onChangeEnd;
this.Min = min;
this.Max = max;
this.Divisions = divisions;
this.Labels = labels;
this.ActiveColor = activeColor;
this.InactiveColor = inactiveColor;
this.SemanticFormatterCallback = semanticFormatterCallback;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Slidertheme.RangeValues Values{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChanged{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeStart{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeEnd{get;set;}
public virtual double Min{get;set;}
public virtual double Max{get;set;}
public virtual int Divisions{get;set;}
public virtual FlutterSDK.Material.Slidertheme.RangeLabels Labels{get;set;}
public virtual FlutterBinding.UI.Color ActiveColor{get;set;}
public virtual FlutterBinding.UI.Color InactiveColor{get;set;}
public virtual FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback SemanticFormatterCallback{get;set;}
internal virtual double _MinTouchTargetWidth{get;set;}
#endregion

#region methods

public new FlutterSDK.Material.Rangeslider._RangeSliderState CreateState(){ throw new NotImplementedException(); }


public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties){ throw new NotImplementedException(); }

#endregion
}


public class _RangeSliderState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Material.Rangeslider.RangeSlider>,ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
{
#region constructors
public _RangeSliderState()
{ }
#endregion

#region fields
public virtual TimeSpan EnableAnimationDuration{get;set;}
public virtual TimeSpan ValueIndicatorAnimationDuration{get;set;}
public virtual FlutterSDK.Animation.Animationcontroller.AnimationController OverlayController{get;set;}
public virtual FlutterSDK.Animation.Animationcontroller.AnimationController ValueIndicatorController{get;set;}
public virtual FlutterSDK.Animation.Animationcontroller.AnimationController EnableController{get;set;}
public virtual FlutterSDK.Animation.Animationcontroller.AnimationController StartPositionController{get;set;}
public virtual FlutterSDK.Animation.Animationcontroller.AnimationController EndPositionController{get;set;}
public virtual Timer InteractionTimer{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.RangeThumbSelector _DefaultRangeThumbSelector{get;set;}
internal virtual double _DefaultTrackHeight{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.RangeSliderTrackShape _DefaultTrackShape{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.RangeSliderTickMarkShape _DefaultTickMarkShape{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.SliderComponentShape _DefaultOverlayShape{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.RangeSliderThumbShape _DefaultThumbShape{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.RangeSliderValueIndicatorShape _DefaultValueIndicatorShape{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.ShowValueIndicator _DefaultShowValueIndicator{get;set;}
internal virtual double _DefaultMinThumbSeparation{get;set;}
#endregion

#region methods

public new void InitState(){ throw new NotImplementedException(); }


public new void DidUpdateWidget(FlutterSDK.Material.Rangeslider.RangeSlider oldWidget){ throw new NotImplementedException(); }


public new void Dispose(){ throw new NotImplementedException(); }


private void _HandleChanged(FlutterSDK.Material.Slidertheme.RangeValues values){ throw new NotImplementedException(); }


private void _HandleDragStart(FlutterSDK.Material.Slidertheme.RangeValues values){ throw new NotImplementedException(); }


private void _HandleDragEnd(FlutterSDK.Material.Slidertheme.RangeValues values){ throw new NotImplementedException(); }


private double _Lerp(double value){ throw new NotImplementedException(); }


private FlutterSDK.Material.Slidertheme.RangeValues _LerpRangeValues(FlutterSDK.Material.Slidertheme.RangeValues values){ throw new NotImplementedException(); }


private double _Unlerp(double value){ throw new NotImplementedException(); }


private FlutterSDK.Material.Slidertheme.RangeValues _UnlerpRangeValues(FlutterSDK.Material.Slidertheme.RangeValues values){ throw new NotImplementedException(); }


public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }

#endregion
}


public class _RangeSliderRenderObjectWidget : FlutterSDK.Widgets.Framework.LeafRenderObjectWidget
{
#region constructors
public _RangeSliderRenderObjectWidget(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key),FlutterSDK.Material.Slidertheme.RangeValues values = default(FlutterSDK.Material.Slidertheme.RangeValues),int divisions = default(int),FlutterSDK.Material.Slidertheme.RangeLabels labels = default(FlutterSDK.Material.Slidertheme.RangeLabels),FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData),double textScaleFactor = default(double),FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>),FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>),FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>),FlutterSDK.Material.Rangeslider._RangeSliderState state = default(FlutterSDK.Material.Rangeslider._RangeSliderState),FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback semanticFormatterCallback = default(FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback))
: base(key:key)
{
this.Values = values;
this.Divisions = divisions;
this.Labels = labels;
this.SliderTheme = sliderTheme;
this.TextScaleFactor = textScaleFactor;
this.OnChanged = onChanged;
this.OnChangeStart = onChangeStart;
this.OnChangeEnd = onChangeEnd;
this.State = state;
this.SemanticFormatterCallback = semanticFormatterCallback;throw new NotImplementedException(); }
#endregion

#region fields
public virtual FlutterSDK.Material.Slidertheme.RangeValues Values{get;set;}
public virtual int Divisions{get;set;}
public virtual FlutterSDK.Material.Slidertheme.RangeLabels Labels{get;set;}
public virtual FlutterSDK.Material.Slidertheme.SliderThemeData SliderTheme{get;set;}
public virtual double TextScaleFactor{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChanged{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeStart{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeEnd{get;set;}
public virtual FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback SemanticFormatterCallback{get;set;}
public virtual FlutterSDK.Material.Rangeslider._RangeSliderState State{get;set;}
#endregion

#region methods

public new FlutterSDK.Material.Rangeslider._RenderRangeSlider CreateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context){ throw new NotImplementedException(); }


public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Material.Rangeslider._RenderRangeSlider renderObject){ throw new NotImplementedException(); }
public new void UpdateRenderObject(FlutterSDK.Widgets.Framework.BuildContext context,FlutterSDK.Rendering.@object.RenderObject renderObject){ throw new NotImplementedException(); }

#endregion
}


public class _RenderRangeSlider : FlutterSDK.Rendering.Box.RenderBox,IRelayoutWhenSystemFontsChangeMixin
{
#region constructors
public _RenderRangeSlider(FlutterSDK.Material.Slidertheme.RangeValues values = default(FlutterSDK.Material.Slidertheme.RangeValues),int divisions = default(int),FlutterSDK.Material.Slidertheme.RangeLabels labels = default(FlutterSDK.Material.Slidertheme.RangeLabels),FlutterSDK.Material.Slidertheme.SliderThemeData sliderTheme = default(FlutterSDK.Material.Slidertheme.SliderThemeData),FlutterSDK.Material.Themedata.ThemeData theme = default(FlutterSDK.Material.Themedata.ThemeData),double textScaleFactor = default(double),FlutterSDK.Foundation.Platform.TargetPlatform platform = default(FlutterSDK.Foundation.Platform.TargetPlatform),FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChanged = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>),FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback semanticFormatterCallback = default(FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback),FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeStart = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>),FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> onChangeEnd = default(FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues>),FlutterSDK.Material.Rangeslider._RangeSliderState state = default(FlutterSDK.Material.Rangeslider._RangeSliderState),TextDirection textDirection = default(TextDirection))
: base()
{
this.OnChangeStart = onChangeStart;
this.OnChangeEnd = onChangeEnd;throw new NotImplementedException(); }
#endregion

#region fields
internal virtual FlutterSDK.Material.Slidertheme.Thumb _LastThumbSelection{get;set;}
internal virtual TimeSpan _PositionAnimationDuration{get;set;}
internal virtual double _MinPreferredTrackWidth{get;set;}
internal virtual TimeSpan _MinimumInteractionTime{get;set;}
internal virtual FlutterSDK.Material.Rangeslider._RangeSliderState _State{get;set;}
internal virtual FlutterSDK.Animation.Animation.Animation<double> _OverlayAnimation{get;set;}
internal virtual FlutterSDK.Animation.Animation.Animation<double> _ValueIndicatorAnimation{get;set;}
internal virtual FlutterSDK.Animation.Animation.Animation<double> _EnableAnimation{get;set;}
internal virtual FlutterSDK.Painting.Textpainter.TextPainter _StartLabelPainter{get;set;}
internal virtual FlutterSDK.Painting.Textpainter.TextPainter _EndLabelPainter{get;set;}
internal virtual FlutterSDK.Gestures.Monodrag.HorizontalDragGestureRecognizer _Drag{get;set;}
internal virtual FlutterSDK.Gestures.Tap.TapGestureRecognizer _Tap{get;set;}
internal virtual bool _Active{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.RangeValues _NewValues{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.RangeValues _Values{get;set;}
internal virtual FlutterSDK.Foundation.Platform.TargetPlatform _Platform{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback _SemanticFormatterCallback{get;set;}
internal virtual int _Divisions{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.RangeLabels _Labels{get;set;}
internal virtual FlutterSDK.Material.Slidertheme.SliderThemeData _SliderTheme{get;set;}
internal virtual FlutterSDK.Material.Themedata.ThemeData _Theme{get;set;}
internal virtual double _TextScaleFactor{get;set;}
internal virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> _OnChanged{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeStart{get;set;}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChangeEnd{get;set;}
internal virtual TextDirection _TextDirection{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.CustomSemanticsAction _DecreaseStart{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.CustomSemanticsAction _IncreaseStart{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.CustomSemanticsAction _DecreaseEnd{get;set;}
internal virtual FlutterSDK.Semantics.Semantics.CustomSemanticsAction _IncreaseEnd{get;set;}
internal virtual double _MaxSliderPartWidth{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual double _MaxSliderPartHeight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual List<Size> _SliderPartSizes{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual double _MinPreferredTrackHeight{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual FlutterBinding.UI.Rect _TrackRect{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsEnabled{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool IsDiscrete{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual FlutterSDK.Material.Slidertheme.RangeValues Values{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Foundation.Platform.TargetPlatform Platform{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Material.Slidertheme.RangeSemanticFormatterCallback SemanticFormatterCallback{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual int Divisions{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Material.Slidertheme.RangeLabels Labels{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Material.Slidertheme.SliderThemeData SliderTheme{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Material.Themedata.ThemeData Theme{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual double TextScaleFactor{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual FlutterSDK.Foundation.Basictypes.ValueChanged<RangeValues> OnChanged{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual TextDirection TextDirection{get {throw new NotImplementedException();}set {throw new NotImplementedException();}}
public virtual bool ShowValueIndicator{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual Size _ThumbSize{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual double _AdjustmentUnit{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
public virtual bool SizedByParent{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
internal virtual double _SemanticActionUnit{get {throw new NotImplementedException();}set { throw new NotImplementedException(); }}
#endregion

#region methods

private void _UpdateLabelPainters(){ throw new NotImplementedException(); }


private void _UpdateLabelPainter(FlutterSDK.Material.Slidertheme.Thumb thumb){ throw new NotImplementedException(); }


public new void SystemFontsDidChange(){ throw new NotImplementedException(); }


public new void Attach(FlutterSDK.Rendering.@object.PipelineOwner owner){ throw new NotImplementedException(); }
public new void Attach(@Object owner){ throw new NotImplementedException(); }


public new void Detach(){ throw new NotImplementedException(); }


private double _GetValueFromVisualPosition(double visualPosition){ throw new NotImplementedException(); }


private double _GetValueFromGlobalPosition(FlutterBinding.UI.Offset globalPosition){ throw new NotImplementedException(); }


private double _Discretize(double value){ throw new NotImplementedException(); }


private FlutterSDK.Material.Slidertheme.RangeValues _DiscretizeRangeValues(FlutterSDK.Material.Slidertheme.RangeValues values){ throw new NotImplementedException(); }


private void _StartInteraction(FlutterBinding.UI.Offset globalPosition){ throw new NotImplementedException(); }


private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details){ throw new NotImplementedException(); }


private void _EndInteraction(){ throw new NotImplementedException(); }


private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details){ throw new NotImplementedException(); }


private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details){ throw new NotImplementedException(); }


private void _HandleDragCancel(){ throw new NotImplementedException(); }


private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details){ throw new NotImplementedException(); }


private void _HandleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details){ throw new NotImplementedException(); }


private void _HandleTapCancel(){ throw new NotImplementedException(); }


public new bool HitTestSelf(FlutterBinding.UI.Offset position){ throw new NotImplementedException(); }


public new void HandleEvent(FlutterSDK.Gestures.Events.PointerEvent @event,FlutterSDK.Gestures.Hittest.HitTestEntry entry){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicWidth(double height){ throw new NotImplementedException(); }


public new double ComputeMinIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new double ComputeMaxIntrinsicHeight(double width){ throw new NotImplementedException(); }


public new void PerformResize(){ throw new NotImplementedException(); }


public new void Paint(FlutterSDK.Rendering.@object.PaintingContext context,FlutterBinding.UI.Offset offset){ throw new NotImplementedException(); }


public new void DescribeSemanticsConfiguration(FlutterSDK.Semantics.Semantics.SemanticsConfiguration config){ throw new NotImplementedException(); }


private void _IncreaseStartAction(){ throw new NotImplementedException(); }


private void _DecreaseStartAction(){ throw new NotImplementedException(); }


private void _IncreaseEndAction(){ throw new NotImplementedException(); }


private void _DecreaseEndAction(){ throw new NotImplementedException(); }


private double _IncreaseValue(double value){ throw new NotImplementedException(); }


private double _DecreaseValue(double value){ throw new NotImplementedException(); }

#endregion
}

}
