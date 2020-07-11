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
namespace FlutterSDK.Widgets.Animatedlist
{
    public delegate FlutterSDK.Widgets.Framework.Widget AnimatedListItemBuilder(FlutterSDK.Widgets.Framework.BuildContext context, int index, FlutterSDK.Animation.Animation.Animation<double> animation);
    public delegate FlutterSDK.Widgets.Framework.Widget AnimatedListRemovedItemBuilder(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Animation.Animation.Animation<double> animation);
    internal static class AnimatedlistDefaultClass
    {
        public static TimeSpan _KDuration = default(TimeSpan);
    }

    public class _ActiveItem : IComparable<FlutterSDK.Widgets.Animatedlist._ActiveItem>
    {
        #region constructors
        public static _ActiveItem Incoming(FlutterSDK.Animation.Animationcontroller.AnimationController controller, int itemIndex)
        {
            var instance = new _ActiveItem(); instance.Controller = controller;
            instance.ItemIndex = itemIndex; throw new NotImplementedException();
        }
        public static _ActiveItem Outgoing(FlutterSDK.Animation.Animationcontroller.AnimationController controller, int itemIndex, FlutterSDK.Widgets.Animatedlist.AnimatedListRemovedItemBuilder removedItemBuilder)
        {
            var instance = new _ActiveItem(); instance.Controller = controller;
            instance.ItemIndex = itemIndex;
            instance.RemovedItemBuilder = removedItemBuilder; throw new NotImplementedException();
        }
        public static _ActiveItem Index(int itemIndex)
        {
            var instance = new _ActiveItem(); instance.ItemIndex = itemIndex; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Animation.Animationcontroller.AnimationController Controller { get; set; }
        public virtual FlutterSDK.Widgets.Animatedlist.AnimatedListRemovedItemBuilder RemovedItemBuilder { get; set; }
        public virtual int ItemIndex { get; set; }
        #endregion

        #region methods

        public new int CompareTo(FlutterSDK.Widgets.Animatedlist._ActiveItem other) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A scrolling container that animates items when they are inserted or removed.
    ///
    /// This widget's [AnimatedListState] can be used to dynamically insert or
    /// remove items. To refer to the [AnimatedListState] either provide a
    /// [GlobalKey] or use the static [of] method from an item's input callback.
    ///
    /// This widget is similar to one created by [ListView.builder].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=ZtfItHwFlZ8}
    ///
    /// {@tool dartpad --template=freeform}
    /// This sample application uses an [AnimatedList] to create an effect when
    /// items are removed or added to the list.
    ///
    /// ```dart imports
    /// import 'package:flutter/foundation.dart';
    /// import 'package:flutter/material.dart';
    /// ```
    ///
    /// ```dart
    /// class AnimatedListSample extends StatefulWidget {
    ///   @override
    ///   _AnimatedListSampleState createState() => _AnimatedListSampleState();
    /// }
    ///
    /// class _AnimatedListSampleState extends State<AnimatedListSample> {
    ///   final GlobalKey<AnimatedListState> _listKey = GlobalKey<AnimatedListState>();
    ///   ListModel<int> _list;
    ///   int _selectedItem;
    ///   int _nextItem; // The next item inserted when the user presses the '+' button.
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     _list = ListModel<int>(
    ///       listKey: _listKey,
    ///       initialItems: <int>[0, 1, 2],
    ///       removedItemBuilder: _buildRemovedItem,
    ///     );
    ///     _nextItem = 3;
    ///   }
    ///
    ///   // Used to build list items that haven't been removed.
    ///   Widget _buildItem(BuildContext context, int index, Animation<double> animation) {
    ///     return CardItem(
    ///       animation: animation,
    ///       item: _list[index],
    ///       selected: _selectedItem == _list[index],
    ///       onTap: () {
    ///         setState(() {
    ///           _selectedItem = _selectedItem == _list[index] ? null : _list[index];
    ///         });
    ///       },
    ///     );
    ///   }
    ///
    ///   // Used to build an item after it has been removed from the list. This
    ///   // method is needed because a removed item remains visible until its
    ///   // animation has completed (even though it's gone as far this ListModel is
    ///   // concerned). The widget will be used by the
    ///   // [AnimatedListState.removeItem] method's
    ///   // [AnimatedListRemovedItemBuilder] parameter.
    ///   Widget _buildRemovedItem(int item, BuildContext context, Animation<double> animation) {
    ///     return CardItem(
    ///       animation: animation,
    ///       item: item,
    ///       selected: false,
    ///       // No gesture detector here: we don't want removed items to be interactive.
    ///     );
    ///   }
    ///
    ///   // Insert the "next item" into the list model.
    ///   void _insert() {
    ///     final int index = _selectedItem == null ? _list.length : _list.indexOf(_selectedItem);
    ///     _list.insert(index, _nextItem++);
    ///   }
    ///
    ///   // Remove the selected item from the list model.
    ///   void _remove() {
    ///     if (_selectedItem != null) {
    ///       _list.removeAt(_list.indexOf(_selectedItem));
    ///       setState(() {
    ///         _selectedItem = null;
    ///       });
    ///     }
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return MaterialApp(
    ///       home: Scaffold(
    ///         appBar: AppBar(
    ///           title: const Text('AnimatedList'),
    ///           actions: <Widget>[
    ///             IconButton(
    ///               icon: const Icon(Icons.add_circle),
    ///               onPressed: _insert,
    ///               tooltip: 'insert a new item',
    ///             ),
    ///             IconButton(
    ///               icon: const Icon(Icons.remove_circle),
    ///               onPressed: _remove,
    ///               tooltip: 'remove the selected item',
    ///             ),
    ///           ],
    ///         ),
    ///         body: Padding(
    ///           padding: const EdgeInsets.all(16.0),
    ///           child: AnimatedList(
    ///             key: _listKey,
    ///             initialItemCount: _list.length,
    ///             itemBuilder: _buildItem,
    ///           ),
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// /// Keeps a Dart [List] in sync with an [AnimatedList].
    /// ///
    /// /// The [insert] and [removeAt] methods apply to both the internal list and
    /// /// the animated list that belongs to [listKey].
    /// ///
    /// /// This class only exposes as much of the Dart List API as is needed by the
    /// /// sample app. More list methods are easily added, however methods that
    /// /// mutate the list must make the same changes to the animated list in terms
    /// /// of [AnimatedListState.insertItem] and [AnimatedList.removeItem].
    /// class ListModel<E> {
    ///   ListModel({
    ///     @required this.listKey,
    ///     @required this.removedItemBuilder,
    ///     Iterable<E> initialItems,
    ///   }) : assert(listKey != null),
    ///       assert(removedItemBuilder != null),
    ///       _items = List<E>.from(initialItems ?? <E>[]);
    ///
    ///   final GlobalKey<AnimatedListState> listKey;
    ///   final dynamic removedItemBuilder;
    ///   final List<E> _items;
    ///
    ///   AnimatedListState get _animatedList => listKey.currentState;
    ///
    ///   void insert(int index, E item) {
    ///     _items.insert(index, item);
    ///     _animatedList.insertItem(index);
    ///   }
    ///
    ///   E removeAt(int index) {
    ///     final E removedItem = _items.removeAt(index);
    ///     if (removedItem != null) {
    ///       _animatedList.removeItem(
    ///         index,
    ///           (BuildContext context, Animation<double> animation) => removedItemBuilder(removedItem, context, animation),
    ///       );
    ///     }
    ///     return removedItem;
    ///   }
    ///
    ///   int get length => _items.length;
    ///
    ///   E operator [](int index) => _items[index];
    ///
    ///   int indexOf(E item) => _items.indexOf(item);
    /// }
    ///
    /// /// Displays its integer item as 'item N' on a Card whose color is based on
    /// /// the item's value.
    /// ///
    /// /// The text is displayed in bright green if [selected] is
    /// /// true. This widget's height is based on the [animation] parameter, it
    /// /// varies from 0 to 128 as the animation varies from 0.0 to 1.0.
    /// class CardItem extends StatelessWidget {
    ///   const CardItem({
    ///     Key key,
    ///     @required this.animation,
    ///     this.onTap,
    ///     @required this.item,
    ///     this.selected: false
    ///   }) : assert(animation != null),
    ///        assert(item != null && item >= 0),
    ///        assert(selected != null),
    ///        super(key: key);
    ///
    ///   final Animation<double> animation;
    ///   final VoidCallback onTap;
    ///   final int item;
    ///   final bool selected;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     TextStyle textStyle = Theme.of(context).textTheme.headline4;
    ///     if (selected)
    ///       textStyle = textStyle.copyWith(color: Colors.lightGreenAccent[400]);
    ///     return Padding(
    ///       padding: const EdgeInsets.all(2.0),
    ///       child: SizeTransition(
    ///         axis: Axis.vertical,
    ///         sizeFactor: animation,
    ///         child: GestureDetector(
    ///           behavior: HitTestBehavior.opaque,
    ///           onTap: onTap,
    ///           child: SizedBox(
    ///             height: 80.0,
    ///             child: Card(
    ///               color: Colors.primaries[item % Colors.primaries.length],
    ///               child: Center(
    ///                 child: Text('Item $item', style: textStyle),
    ///               ),
    ///             ),
    ///           ),
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// void main() {
    ///   runApp(AnimatedListSample());
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [SliverAnimatedList], a sliver that animates items when they are inserted
    ///    or removed from a list.
    /// </Summary>
    public class AnimatedList : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public AnimatedList(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Animatedlist.AnimatedListItemBuilder itemBuilder = default(FlutterSDK.Widgets.Animatedlist.AnimatedListItemBuilder), int initialItemCount = 0, FlutterSDK.Painting.Basictypes.Axis scrollDirection = default(FlutterSDK.Painting.Basictypes.Axis), bool reverse = false, FlutterSDK.Widgets.Scrollcontroller.ScrollController controller = default(FlutterSDK.Widgets.Scrollcontroller.ScrollController), bool primary = default(bool), FlutterSDK.Widgets.Scrollphysics.ScrollPhysics physics = default(FlutterSDK.Widgets.Scrollphysics.ScrollPhysics), bool shrinkWrap = false, FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry padding = default(FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry))
        : base(key: key)
        {
            this.ItemBuilder = itemBuilder;
            this.InitialItemCount = initialItemCount;
            this.ScrollDirection = scrollDirection;
            this.Reverse = reverse;
            this.Controller = controller;
            this.Primary = primary;
            this.Physics = physics;
            this.ShrinkWrap = shrinkWrap;
            this.Padding = padding; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Animatedlist.AnimatedListItemBuilder ItemBuilder { get; set; }
        public virtual int InitialItemCount { get; set; }
        public virtual FlutterSDK.Painting.Basictypes.Axis ScrollDirection { get; set; }
        public virtual bool Reverse { get; set; }
        public virtual FlutterSDK.Widgets.Scrollcontroller.ScrollController Controller { get; set; }
        public virtual bool Primary { get; set; }
        public virtual FlutterSDK.Widgets.Scrollphysics.ScrollPhysics Physics { get; set; }
        public virtual bool ShrinkWrap { get; set; }
        public virtual FlutterSDK.Painting.Edgeinsets.EdgeInsetsGeometry Padding { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// The state from the closest instance of this class that encloses the given
        /// context.
        ///
        /// This method is typically used by [AnimatedList] item widgets that insert
        /// or remove items in response to user input.
        ///
        /// ```dart
        /// AnimatedListState animatedList = AnimatedList.of(context);
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Widgets.Animatedlist.AnimatedListState Of(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Animatedlist.AnimatedListState CreateState() { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// The state for a scrolling container that animates items when they are
    /// inserted or removed.
    ///
    /// When an item is inserted with [insertItem] an animation begins running. The
    /// animation is passed to [AnimatedList.itemBuilder] whenever the item's widget
    /// is needed.
    ///
    /// When an item is removed with [removeItem] its animation is reversed.
    /// The removed item's animation is passed to the [removeItem] builder
    /// parameter.
    ///
    /// An app that needs to insert or remove items in response to an event
    /// can refer to the [AnimatedList]'s state with a global key:
    ///
    /// ```dart
    /// GlobalKey<AnimatedListState> listKey = GlobalKey<AnimatedListState>();
    /// ...
    /// AnimatedList(key: listKey, ...);
    /// ...
    /// listKey.currentState.insert(123);
    /// ```
    ///
    /// [AnimatedList] item input handlers can also refer to their [AnimatedListState]
    /// with the static [AnimatedList.of] method.
    /// </Summary>
    public class AnimatedListState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Animatedlist.AnimatedList>, ITickerProviderStateMixin<FlutterSDK.Widgets.Animatedlist.AnimatedList>
    {
        #region constructors
        public AnimatedListState()
        { }
        #endregion

        #region fields
        internal virtual FlutterSDK.Widgets.Framework.GlobalKey<FlutterSDK.Widgets.Animatedlist.SliverAnimatedListState> _SliverAnimatedListKey { get; set; }
        #endregion

        #region methods

        /// <Summary>
        /// Insert an item at [index] and start an animation that will be passed
        /// to [AnimatedList.itemBuilder] when the item is visible.
        ///
        /// This method's semantics are the same as Dart's [List.insert] method:
        /// it increases the length of the list by one and shifts all items at or
        /// after [index] towards the end of the list.
        /// </Summary>
        public virtual void InsertItem(int index, TimeSpan duration = default(TimeSpan)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Remove the item at [index] and start an animation that will be passed
        /// to [builder] when the item is visible.
        ///
        /// Items are removed immediately. After an item has been removed, its index
        /// will no longer be passed to the [AnimatedList.itemBuilder]. However the
        /// item will still appear in the list for [duration] and during that time
        /// [builder] must construct its widget as needed.
        ///
        /// This method's semantics are the same as Dart's [List.remove] method:
        /// it decreases the length of the list by one and shifts all items at or
        /// before [index] towards the beginning of the list.
        /// </Summary>
        public virtual void RemoveItem(int index, FlutterSDK.Widgets.Animatedlist.AnimatedListRemovedItemBuilder builder, TimeSpan duration = default(TimeSpan)) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// A sliver that animates items when they are inserted or removed.
    ///
    /// This widget's [SliverAnimatedListState] can be used to dynamically insert or
    /// remove items. To refer to the [SliverAnimatedListState] either provide a
    /// [GlobalKey] or use the static [SliverAnimatedList.of] method from an item's
    /// input callback.
    ///
    /// {@tool dartpad --template=freeform}
    /// This sample application uses a [SliverAnimatedList] to create an animated
    /// effect when items are removed or added to the list.
    ///
    /// ```dart imports
    /// import 'package:flutter/foundation.dart';
    /// import 'package:flutter/material.dart';
    /// ```
    ///
    /// ```dart
    /// void main() => runApp(SliverAnimatedListSample());
    ///
    /// class SliverAnimatedListSample extends StatefulWidget {
    ///   @override
    ///   _SliverAnimatedListSampleState createState() => _SliverAnimatedListSampleState();
    /// }
    ///
    /// class _SliverAnimatedListSampleState extends State<SliverAnimatedListSample> {
    ///   final GlobalKey<SliverAnimatedListState> _listKey = GlobalKey<SliverAnimatedListState>();
    ///   final GlobalKey<ScaffoldState> _scaffoldKey = GlobalKey<ScaffoldState>();
    ///   ListModel<int> _list;
    ///   int _selectedItem;
    ///   int _nextItem; // The next item inserted when the user presses the '+' button.
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     _list = ListModel<int>(
    ///       listKey: _listKey,
    ///       initialItems: <int>[0, 1, 2],
    ///       removedItemBuilder: _buildRemovedItem,
    ///     );
    ///     _nextItem = 3;
    ///   }
    ///
    ///   // Used to build list items that haven't been removed.
    ///   Widget _buildItem(BuildContext context, int index, Animation<double> animation) {
    ///     return CardItem(
    ///       animation: animation,
    ///       item: _list[index],
    ///       selected: _selectedItem == _list[index],
    ///       onTap: () {
    ///         setState(() {
    ///           _selectedItem = _selectedItem == _list[index] ? null : _list[index];
    ///         });
    ///       },
    ///     );
    ///   }
    ///
    ///   // Used to build an item after it has been removed from the list. This
    ///   // method is needed because a removed item remains visible until its
    ///   // animation has completed (even though it's gone as far this ListModel is
    ///   // concerned). The widget will be used by the
    ///   // [AnimatedListState.removeItem] method's
    ///   // [AnimatedListRemovedItemBuilder] parameter.
    ///   Widget _buildRemovedItem(int item, BuildContext context, Animation<double> animation) {
    ///     return CardItem(
    ///       animation: animation,
    ///       item: item,
    ///       selected: false,
    ///     );
    ///   }
    ///
    ///   // Insert the "next item" into the list model.
    ///   void _insert() {
    ///     final int index = _selectedItem == null ? _list.length : _list.indexOf(_selectedItem);
    ///     _list.insert(index, _nextItem++);
    ///   }
    ///
    ///   // Remove the selected item from the list model.
    ///   void _remove() {
    ///     if (_selectedItem != null) {
    ///       _list.removeAt(_list.indexOf(_selectedItem));
    ///       setState(() {
    ///         _selectedItem = null;
    ///       });
    ///     } else {
    ///       _scaffoldKey.currentState.showSnackBar(SnackBar(
    ///         content: Text(
    ///           'Select an item to remove from the list.',
    ///           style: TextStyle(fontSize: 20),
    ///         ),
    ///       ));
    ///     }
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return MaterialApp(
    ///       home: Scaffold(
    ///         key: _scaffoldKey,
    ///         body: CustomScrollView(
    ///           slivers: <Widget>[
    ///             SliverAppBar(
    ///               title: Text(
    ///                 'SliverAnimatedList',
    ///                 style: TextStyle(fontSize: 30),
    ///               ),
    ///               expandedHeight: 60,
    ///               centerTitle: true,
    ///               backgroundColor: Colors.amber[900],
    ///               leading: IconButton(
    ///                 icon: const Icon(Icons.add_circle),
    ///                 onPressed: _insert,
    ///                 tooltip: 'Insert a new item.',
    ///                 iconSize: 32,
    ///               ),
    ///               actions: [
    ///                 IconButton(
    ///                   icon: const Icon(Icons.remove_circle),
    ///                   onPressed: _remove,
    ///                   tooltip: 'Remove the selected item.',
    ///                   iconSize: 32,
    ///                 ),
    ///               ],
    ///             ),
    ///             SliverAnimatedList(
    ///               key: _listKey,
    ///               initialItemCount: _list.length,
    ///               itemBuilder: _buildItem,
    ///             ),
    ///           ],
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    ///
    /// // Keeps a Dart [List] in sync with an [AnimatedList].
    /// //
    /// // The [insert] and [removeAt] methods apply to both the internal list and
    /// // the animated list that belongs to [listKey].
    /// //
    /// // This class only exposes as much of the Dart List API as is needed by the
    /// // sample app. More list methods are easily added, however methods that
    /// // mutate the list must make the same changes to the animated list in terms
    /// // of [AnimatedListState.insertItem] and [AnimatedList.removeItem].
    /// class ListModel<E> {
    ///   ListModel({
    ///     @required this.listKey,
    ///     @required this.removedItemBuilder,
    ///     Iterable<E> initialItems,
    ///   }) : assert(listKey != null),
    ///        assert(removedItemBuilder != null),
    ///        _items = List<E>.from(initialItems ?? <E>[]);
    ///
    ///   final GlobalKey<SliverAnimatedListState> listKey;
    ///   final dynamic removedItemBuilder;
    ///   final List<E> _items;
    ///
    ///   SliverAnimatedListState get _animatedList => listKey.currentState;
    ///
    ///   void insert(int index, E item) {
    ///     _items.insert(index, item);
    ///     _animatedList.insertItem(index);
    ///   }
    ///
    ///   E removeAt(int index) {
    ///     final E removedItem = _items.removeAt(index);
    ///     if (removedItem != null) {
    ///       _animatedList.removeItem(
    ///         index,
    ///         (BuildContext context, Animation<double> animation) => removedItemBuilder(removedItem, context, animation),
    ///       );
    ///     }
    ///     return removedItem;
    ///   }
    ///
    ///   int get length => _items.length;
    ///
    ///   E operator [](int index) => _items[index];
    ///
    ///   int indexOf(E item) => _items.indexOf(item);
    /// }
    ///
    /// // Displays its integer item as 'Item N' on a Card whose color is based on
    /// // the item's value.
    /// //
    /// // The card turns gray when [selected] is true. This widget's height
    /// // is based on the [animation] parameter. It varies as the animation value
    /// // transitions from 0.0 to 1.0.
    /// class CardItem extends StatelessWidget {
    ///   const CardItem({
    ///     Key key,
    ///     @required this.animation,
    ///     @required this.item,
    ///     this.onTap,
    ///     this.selected = false,
    ///   }) : assert(animation != null),
    ///        assert(item != null && item >= 0),
    ///        assert(selected != null),
    ///        super(key: key);
    ///
    ///   final Animation<double> animation;
    ///   final VoidCallback onTap;
    ///   final int item;
    ///   final bool selected;
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     return Padding(
    ///       padding:
    ///       const EdgeInsets.only(
    ///         left: 2.0,
    ///         right: 2.0,
    ///         top: 2.0,
    ///         bottom: 0.0,
    ///       ),
    ///       child: SizeTransition(
    ///         axis: Axis.vertical,
    ///         sizeFactor: animation,
    ///         child: GestureDetector(
    ///           onTap: onTap,
    ///           child: SizedBox(
    ///             height: 80.0,
    ///             child: Card(
    ///               color: selected
    ///                 ? Colors.black12
    ///                 : Colors.primaries[item % Colors.primaries.length],
    ///               child: Center(
    ///                 child: Text(
    ///                   'Item $item',
    ///                   style: Theme.of(context).textTheme.headline4,
    ///                 ),
    ///               ),
    ///             ),
    ///           ),
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [SliverList], which does not animate items when they are inserted or
    ///    removed.
    ///  * [AnimatedList], a non-sliver scrolling container that animates items when
    ///    they are inserted or removed.
    /// </Summary>
    public class SliverAnimatedList : FlutterSDK.Widgets.Framework.StatefulWidget
    {
        #region constructors
        public SliverAnimatedList(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Widgets.Animatedlist.AnimatedListItemBuilder itemBuilder = default(FlutterSDK.Widgets.Animatedlist.AnimatedListItemBuilder), int initialItemCount = 0)
        : base(key: key)
        {
            this.ItemBuilder = itemBuilder;
            this.InitialItemCount = initialItemCount; throw new NotImplementedException();
        }
        #endregion

        #region fields
        public virtual FlutterSDK.Widgets.Animatedlist.AnimatedListItemBuilder ItemBuilder { get; set; }
        public virtual int InitialItemCount { get; set; }
        #endregion

        #region methods

        public new FlutterSDK.Widgets.Animatedlist.SliverAnimatedListState CreateState() { throw new NotImplementedException(); }


        /// <Summary>
        /// The state from the closest instance of this class that encloses the given
        /// context.
        ///
        /// This method is typically used by [SliverAnimatedList] item widgets that
        /// insert or remove items in response to user input.
        ///
        /// ```dart
        /// SliverAnimatedListState animatedList = SliverAnimatedList.of(context);
        /// ```
        /// </Summary>
        public virtual FlutterSDK.Widgets.Animatedlist.SliverAnimatedListState Of(FlutterSDK.Widgets.Framework.BuildContext context, bool nullOk = false) { throw new NotImplementedException(); }

        #endregion
    }


    /// <Summary>
    /// The state for a sliver that animates items when they are
    /// inserted or removed.
    ///
    /// When an item is inserted with [insertItem] an animation begins running. The
    /// animation is passed to [SliverAnimatedList.itemBuilder] whenever the item's
    /// widget is needed.
    ///
    /// When an item is removed with [removeItem] its animation is reversed.
    /// The removed item's animation is passed to the [removeItem] builder
    /// parameter.
    ///
    /// An app that needs to insert or remove items in response to an event
    /// can refer to the [SliverAnimatedList]'s state with a global key:
    ///
    /// ```dart
    /// GlobalKey<SliverAnimatedListState> listKey = GlobalKey<SliverAnimatedListState>();
    /// ...
    /// SliverAnimatedList(key: listKey, ...);
    /// ...
    /// listKey.currentState.insert(123);
    /// ```
    ///
    /// [SliverAnimatedList] item input handlers can also refer to their
    /// [SliverAnimatedListState] with the static [SliverAnimatedList.of] method.
    /// </Summary>
    public class SliverAnimatedListState : FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Animatedlist.SliverAnimatedList>, ITickerProviderStateMixin<FlutterSDK.Widgets.Framework.StatefulWidget>
    {
        #region constructors
        public SliverAnimatedListState()
        { }
        #endregion

        #region fields
        internal virtual List<FlutterSDK.Widgets.Animatedlist._ActiveItem> _IncomingItems { get; set; }
        internal virtual List<FlutterSDK.Widgets.Animatedlist._ActiveItem> _OutgoingItems { get; set; }
        internal virtual int _ItemsCount { get; set; }
        #endregion

        #region methods

        public new void InitState() { throw new NotImplementedException(); }


        public new void Dispose() { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Animatedlist._ActiveItem _RemoveActiveItemAt(List<FlutterSDK.Widgets.Animatedlist._ActiveItem> items, int itemIndex) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Animatedlist._ActiveItem _ActiveItemAt(List<FlutterSDK.Widgets.Animatedlist._ActiveItem> items, int itemIndex) { throw new NotImplementedException(); }


        private int _IndexToItemIndex(int index) { throw new NotImplementedException(); }


        private int _ItemIndexToIndex(int itemIndex) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Sliver.SliverChildDelegate _CreateDelegate() { throw new NotImplementedException(); }


        /// <Summary>
        /// Insert an item at [index] and start an animation that will be passed to
        /// [SliverAnimatedList.itemBuilder] when the item is visible.
        ///
        /// This method's semantics are the same as Dart's [List.insert] method:
        /// it increases the length of the list by one and shifts all items at or
        /// after [index] towards the end of the list.
        /// </Summary>
        public virtual void InsertItem(int index, TimeSpan duration = default(TimeSpan)) { throw new NotImplementedException(); }


        /// <Summary>
        /// Remove the item at [index] and start an animation that will be passed
        /// to [builder] when the item is visible.
        ///
        /// Items are removed immediately. After an item has been removed, its index
        /// will no longer be passed to the [SliverAnimatedList.itemBuilder]. However
        /// the item will still appear in the list for [duration] and during that time
        /// [builder] must construct its widget as needed.
        ///
        /// This method's semantics are the same as Dart's [List.remove] method:
        /// it decreases the length of the list by one and shifts all items at or
        /// before [index] towards the beginning of the list.
        /// </Summary>
        public virtual void RemoveItem(int index, FlutterSDK.Widgets.Animatedlist.AnimatedListRemovedItemBuilder builder, TimeSpan duration = default(TimeSpan)) { throw new NotImplementedException(); }


        private FlutterSDK.Widgets.Framework.Widget _ItemBuilder(FlutterSDK.Widgets.Framework.BuildContext context, int itemIndex) { throw new NotImplementedException(); }


        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context) { throw new NotImplementedException(); }

        #endregion
    }

}
