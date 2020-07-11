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
namespace FlutterSDK.Cupertino.Icons{
internal static class IconsDefaultClass{
}

public class CupertinoIcons
{
#region constructors
internal CupertinoIcons()
{
throw new NotImplementedException(); }
#endregion

#region fields
public virtual string IconFont{get;set;}
public virtual string IconFontPackage{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Leftchevron{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Rightchevron{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Share{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Sharesolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Book{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Booksolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Bookmark{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Bookmarksolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Info{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Reply{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Conversationbubble{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Profilecircled{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Pluscircled{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Minuscircled{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Flag{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Search{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Checkmark{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Checkmarkcircled{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Checkmarkcircledsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Circle{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Circlefilled{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Back{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Forward{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Home{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Shoppingcart{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Ellipsis{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Phone{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Phonesolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Downarrow{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Uparrow{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Batterycharging{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Batteryempty{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Batteryfull{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Battery75percent{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Battery25percent{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Bluetooth{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Restart{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Replyall{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Replythicksolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Shareup{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Shuffle{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Shufflemedium{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Shufflethick{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Photocamera{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Photocamerasolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Videocamera{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Videocamerasolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Switchcamera{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Switchcamerasolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Collections{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Collectionssolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Folder{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Foldersolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Folderopen{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Delete{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Deletesolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Deletesimple{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Pen{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Pencil{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Create{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Createsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Refresh{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Refreshcircled{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Refreshcircledsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Refreshthin{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Refreshthick{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Refreshbold{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Clearthick{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Clearthickcircled{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Clear{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Clearcircled{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Clearcircledsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Add{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Addcircled{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Addcircledsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Gear{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Gearsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Gearbig{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Settings{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Settingssolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Musicnote{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Doublemusicnote{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Playarrow{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Playarrowsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Pause{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Pausesolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Loop{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Loopthick{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Volumedown{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Volumemute{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Volumeoff{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Volumeup{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Fullscreen{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Fullscreenexit{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Micoff{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Mic{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Micsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Clock{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Clocksolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Time{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Timesolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Padlock{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Padlocksolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Eye{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Eyesolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Person{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Personsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Personadd{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Personaddsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Group{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Groupsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Mail{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Mailsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Location{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Locationsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Tag{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Tagsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Tags{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Tagssolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Bus{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Car{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Cardetailed{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Trainstyleone{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Trainstyletwo{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Paw{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Pawsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Gamecontroller{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Gamecontrollersolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Labflask{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Labflasksolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Heart{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Heartsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Bell{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Bellsolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData News{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Newssolid{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Brightness{get;set;}
public virtual FlutterSDK.Widgets.Icondata.IconData Brightnesssolid{get;set;}
#endregion

#region methods
#endregion
}

}