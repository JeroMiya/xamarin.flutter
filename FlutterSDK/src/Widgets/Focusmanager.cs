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
using FlutterSDK.Scheduler;
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
namespace FlutterSDK.Widgets.Focusmanager
{
    /// <Summary>
    /// Signature of a callback used by [Focus.onKey] and [FocusScope.onKey]
    /// to receive key events.
    ///
    /// The [node] is the node that received the event.
    /// </Summary>
    public delegate bool FocusOnKeyCallback(FlutterSDK.Widgets.Focusmanager.FocusNode node, FlutterSDK.Services.Rawkeyboard.RawKeyEvent @event);
    internal static class FocusmanagerDefaultClass
    {
        public static bool _KDebugFocus = default(bool);
        public static FlutterSDK.Widgets.Focusmanager.FocusNode PrimaryFocus = default(FlutterSDK.Widgets.Focusmanager.FocusNode);
        internal static bool _FocusDebug(string message, Iterable<string> details = default(Iterable<string>))
        {
            if (FocusmanagerDefaultClass._KDebugFocus)
            {
                PrintDefaultClass.DebugPrint($"'FOCUS: {message}'");
                if (details != null && details.IsNotEmpty)
                {
                    foreach (string detail in details)
                    {
                        PrintDefaultClass.DebugPrint($"'    {detail}'");
                    }

                }

            }

            return true;
        }



        /// <Summary>
        /// Returns a text representation of the current focus tree, along with the
        /// current attributes on each node.
        ///
        /// Will return an empty string in release builds.
        /// </Summary>
        internal static string DebugDescribeFocusTree()
        {

            string result = default(string);

            return result ?? "";
        }



        /// <Summary>
        /// Prints a text representation of the current focus tree, along with the
        /// current attributes on each node.
        ///
        /// Will do nothing in release builds.
        /// </Summary>
        internal static void DebugDumpFocusTree()
        {

        }



    }

    /// <Summary>
    /// An attachment point for a [FocusNode].
    ///
    /// Using a [FocusAttachment] is rarely needed, unless you are building
    /// something akin to the [Focus] or [FocusScope] widgets from scratch.
    ///
    /// Once created, a [FocusNode] must be attached to the widget tree by its
    /// _host_ [StatefulWidget] via a [FocusAttachment] object. [FocusAttachment]s
    /// are owned by the [StatefulWidget] that hosts a [FocusNode] or
    /// [FocusScopeNode]. There can be multiple [FocusAttachment]s for each
    /// [FocusNode], but the node will only ever be attached to one of them at a
    /// time.
    ///
    /// This attachment is created by calling [FocusNode.attach], usually from the
    /// host widget's [State.initState] method. If the widget is updated to have a
    /// different focus node, then the new node needs to be attached in
    /// [State.didUpdateWidget], after calling [detach] on the previous
    /// [FocusAttachment]. Once detached, the attachment is defunct and will no
    /// longer make changes to the [FocusNode] through [reparent].
    ///
    /// Without these attachment points, it would be possible for a focus node to
    /// simultaneously be attached to more than one part of the widget tree during
    /// the build stage.
    /// </Summary>
    public class FocusAttachment
    {
        /// <Summary>
        /// A private constructor, because [FocusAttachment]s are only to be created
        /// by [FocusNode.attach].
        /// </Summary>
        internal FocusAttachment(FlutterSDK.Widgets.Focusmanager.FocusNode _node)
        : base()
        {
            this._Node = _node;
        }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _Node { get; set; }
        public virtual bool IsAttached { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Detaches the [FocusNode] this attachment point is associated with from the
        /// focus tree, and disconnects it from this attachment point.
        ///
        /// Calling [FocusNode.dispose] will also automatically detach the node.
        /// </Summary>
        public virtual void Detach()
        {


            if (IsAttached)
            {
                if (_Node.HasPrimaryFocus || (_Node._Manager != null && _Node._Manager._MarkedForFocus == _Node))
                {
                    _Node.Unfocus(disposition: UnfocusDisposition.PreviouslyFocusedChild);
                }

                _Node._Manager?._MarkDetached(_Node);
                _Node._Parent?._RemoveChild(_Node);
                _Node._Attachment = null;


            }


        }




        /// <Summary>
        /// Ensures that the [FocusNode] attached at this attachment point has the
        /// proper parent node, changing it if necessary.
        ///
        /// If given, ensures that the given [parent] node is the parent of the node
        /// that is attached at this attachment point, changing it if necessary.
        /// However, it is usually not necessary to supply an explicit parent, since
        /// [reparent] will use [Focus.of] to determine the correct parent node for
        /// the context given in [FocusNode.attach].
        ///
        /// If [isAttached] is false, then calling this method does nothing.
        ///
        /// Should be called whenever the associated widget is rebuilt in order to
        /// maintain the focus hierarchy.
        ///
        /// A [StatefulWidget] that hosts a [FocusNode] should call this method on the
        /// node it hosts during its [State.build] or [State.didChangeDependencies]
        /// methods in case the widget is moved from one location in the tree to
        /// another location that has a different [FocusScope] or context.
        ///
        /// The optional [parent] argument must be supplied when not using [Focus] and
        /// [FocusScope] widgets to build the focus tree, or if there is a need to
        /// supply the parent explicitly (which are both uncommon).
        /// </Summary>
        public virtual void Reparent(FlutterSDK.Widgets.Focusmanager.FocusNode parent = default(FlutterSDK.Widgets.Focusmanager.FocusNode))
        {

            if (IsAttached)
            {

                parent = (parent == null ? FocusscopeDefaultClass.Focus.Of(_Node.Context, nullOk: true, scopeOk: true) : parent);
                parent = (parent == null ? _Node.Context.Owner.FocusManager.RootScope : parent);

                parent._Reparent(_Node);
            }

        }



    }


    /// <Summary>
    /// An object that can be used by a stateful widget to obtain the keyboard focus
    /// and to handle keyboard events.
    ///
    /// _Please see the [Focus] and [FocusScope] widgets, which are utility widgets
    /// that manage their own [FocusNode]s and [FocusScopeNode]s, respectively. If
    /// they aren't appropriate, [FocusNode]s can be managed directly, but doing
    /// this yourself is rare._
    ///
    /// [FocusNode]s are persistent objects that form a _focus tree_ that is a
    /// representation of the widgets in the hierarchy that are interested in focus.
    /// A focus node might need to be created if it is passed in from an ancestor of
    /// a [Focus] widget to control the focus of the children from the ancestor, or
    /// a widget might need to host one if the widget subsystem is not being used,
    /// or if the [Focus] and [FocusScope] widgets provide insufficient control.
    ///
    /// [FocusNodes] are organized into _scopes_ (see [FocusScopeNode]), which form
    /// sub-trees of nodes that restrict traversal to a group of nodes. Within a
    /// scope, the most recent nodes to have focus are remembered, and if a node is
    /// focused and then unfocused, the previous node receives focus again.
    ///
    /// The focus node hierarchy can be traversed using the [parent], [children],
    /// [ancestors] and [descendants] accessors.
    ///
    /// [FocusNode]s are [ChangeNotifier]s, so a listener can be registered to
    /// receive a notification when the focus changes. If the [Focus] and
    /// [FocusScope] widgets are being used to manage the nodes, consider
    /// establishing an [InheritedWidget] dependency on them by calling [Focus.of]
    /// or [FocusScope.of] instead. [Focus.hasFocus] can also be used to establish a
    /// similar dependency, especially if all that is needed is to determine whether
    /// or not the widget is focused at build time.
    ///
    /// To see the focus tree in the debug console, call [debugDumpFocusTree]. To
    /// get the focus tree as a string, call [debugDescribeFocusTree].
    ///
    /// {@template flutter.widgets.focus_manager.focus.lifecycle}
    /// ## Lifecycle
    ///
    /// There are several actors involved in the lifecycle of a
    /// [FocusNode]/[FocusScopeNode]. They are created and disposed by their
    /// _owner_, attached, detached, and re-parented using a [FocusAttachment] by
    /// their _host_ (which must be owned by the [State] of a [StatefulWidget]), and
    /// they are managed by the [FocusManager]. Different parts of the [FocusNode]
    /// API are intended for these different actors.
    ///
    /// [FocusNode]s (and hence [FocusScopeNode]s) are persistent objects that form
    /// part of a _focus tree_ that is a sparse representation of the widgets in the
    /// hierarchy that are interested in receiving keyboard events. They must be
    /// managed like other persistent state, which is typically done by a
    /// [StatefulWidget] that owns the node. A stateful widget that owns a focus
    /// scope node must call [dispose] from its [State.dispose] method.
    ///
    /// Once created, a [FocusNode] must be attached to the widget tree via a
    /// [FocusAttachment] object. This attachment is created by calling [attach],
    /// usually from the [State.initState] method. If the hosting widget is updated
    /// to have a different focus node, then the updated node needs to be attached
    /// in [State.didUpdateWidget], after calling [detach] on the previous
    /// [FocusAttachment].
    ///
    /// Because [FocusNode]s form a sparse representation of the widget tree,
    /// they must be updated whenever the widget tree is rebuilt. This is done by
    /// calling [FocusAttachment.reparent], usually from the [State.build] or
    /// [State.didChangeDependencies] methods of the widget that represents the
    /// focused region, so that the [BuildContext] assigned to the [FocusScopeNode]
    /// can be tracked (the context is used to obtain the [RenderObject], from which
    /// the geometry of focused regions can be determined).
    ///
    /// Creating a [FocusNode] each time [State.build] is invoked will cause the
    /// focus to be lost each time the widget is built, which is usually not desired
    /// behavior (call [unfocus] if losing focus is desired).
    ///
    /// If, as is common, the hosting [StatefulWidget] is also the owner of the
    /// focus node, then it will also call [dispose] from its [State.dispose] (in
    /// which case the [detach] may be skipped, since dispose will automatically
    /// detach). If another object owns the focus node, then it must call [dispose]
    /// when the node is done being used.
    /// {@endtemplate}
    ///
    /// {@template flutter.widgets.focus_manager.focus.keyEvents}
    /// ## Key Event Propagation
    ///
    /// The [FocusManager] receives key events from [RawKeyboard] and will pass them
    /// to the focused nodes. It starts with the node with the primary focus, and
    /// will call the [onKey] callback for that node. If the callback returns false,
    /// indicating that it did not handle the event, the [FocusManager] will move to
    /// the parent of that node and call its [onKey]. If that [onKey] returns true,
    /// then it will stop propagating the event. If it reaches the root
    /// [FocusScopeNode], [FocusManager.rootScope], the event is discarded.
    /// {@endtemplate}
    ///
    /// ## Focus Traversal
    ///
    /// The term _traversal_, sometimes called _tab traversal_, refers to moving the
    /// focus from one widget to the next in a particular order (also sometimes
    /// referred to as the _tab order_, since the TAB key is often bound to the
    /// action to move to the next widget).
    ///
    /// To give focus to the logical _next_ or _previous_ widget in the UI, call the
    /// [nextFocus] or [previousFocus] methods. To give the focus to a widget in a
    /// particular direction, call the [focusInDirection] method.
    ///
    /// The policy for what the _next_ or _previous_ widget is, or the widget in a
    /// particular direction, is determined by the [FocusTraversalPolicy] in force.
    ///
    /// The ambient policy is determined by looking up the widget hierarchy for a
    /// [FocusTraversalGroup] widget, and obtaining the focus traversal policy from
    /// it. Different focus nodes can inherit difference policies, so part of the
    /// app can go in a predefined order (using [OrderedTraversalPolicy]), and part
    /// can go in reading order (using [ReadingOrderTraversalPolicy]), depending
    /// upon the use case.
    ///
    /// Predefined policies include [WidgetOrderTraversalPolicy],
    /// [ReadingOrderTraversalPolicy], [OrderedTraversalPolicy], and
    /// [DirectionalFocusTraversalPolicyMixin], but custom policies can be built
    /// based upon these policies. See [FocusTraversalPolicy] for more information.
    ///
    /// {@tool dartpad --template=stateless_widget_scaffold}
    /// This example shows how a FocusNode should be managed if not using the
    /// [Focus] or [FocusScope] widgets. See the [Focus] widget for a similar
    /// example using [Focus] and [FocusScope] widgets.
    ///
    /// ```dart imports
    /// import 'package:flutter/services.dart';
    /// ```
    ///
    /// ```dart preamble
    /// class ColorfulButton extends StatefulWidget {
    ///   ColorfulButton({Key key}) : super(key: key);
    ///
    ///   @override
    ///   _ColorfulButtonState createState() => _ColorfulButtonState();
    /// }
    ///
    /// class _ColorfulButtonState extends State<ColorfulButton> {
    ///   FocusNode _node;
    ///   bool _focused = false;
    ///   FocusAttachment _nodeAttachment;
    ///   Color _color = Colors.white;
    ///
    ///   @override
    ///   void initState() {
    ///     super.initState();
    ///     _node = FocusNode(debugLabel: 'Button');
    ///     _node.addListener(_handleFocusChange);
    ///     _nodeAttachment = _node.attach(context, onKey: _handleKeyPress);
    ///   }
    ///
    ///   void _handleFocusChange() {
    ///     if (_node.hasFocus != _focused) {
    ///       setState(() {
    ///         _focused = _node.hasFocus;
    ///       });
    ///     }
    ///   }
    ///
    ///   bool _handleKeyPress(FocusNode node, RawKeyEvent event) {
    ///     if (event is RawKeyDownEvent) {
    ///       print('Focus node ${node.debugLabel} got key event: ${event.logicalKey}');
    ///       if (event.logicalKey == LogicalKeyboardKey.keyR) {
    ///         print('Changing color to red.');
    ///         setState(() {
    ///           _color = Colors.red;
    ///         });
    ///         return true;
    ///       } else if (event.logicalKey == LogicalKeyboardKey.keyG) {
    ///         print('Changing color to green.');
    ///         setState(() {
    ///           _color = Colors.green;
    ///         });
    ///         return true;
    ///       } else if (event.logicalKey == LogicalKeyboardKey.keyB) {
    ///         print('Changing color to blue.');
    ///         setState(() {
    ///           _color = Colors.blue;
    ///         });
    ///         return true;
    ///       }
    ///     }
    ///     return false;
    ///   }
    ///
    ///   @override
    ///   void dispose() {
    ///     _node.removeListener(_handleFocusChange);
    ///     // The attachment will automatically be detached in dispose().
    ///     _node.dispose();
    ///     super.dispose();
    ///   }
    ///
    ///   @override
    ///   Widget build(BuildContext context) {
    ///     _nodeAttachment.reparent();
    ///     return GestureDetector(
    ///       onTap: () {
    ///         if (_focused) {
    ///             _node.unfocus();
    ///         } else {
    ///            _node.requestFocus();
    ///         }
    ///       },
    ///       child: Center(
    ///         child: Container(
    ///           width: 400,
    ///           height: 100,
    ///           color: _focused ? _color : Colors.white,
    ///           alignment: Alignment.center,
    ///           child: Text(
    ///               _focused ? "I'm in color! Press R,G,B!" : 'Press to focus'),
    ///         ),
    ///       ),
    ///     );
    ///   }
    /// }
    /// ```
    ///
    /// ```dart
    /// Widget build(BuildContext context) {
    ///   final TextTheme textTheme = Theme.of(context).textTheme;
    ///   return DefaultTextStyle(
    ///     style: textTheme.headline4,
    ///     child: ColorfulButton(),
    ///   );
    /// }
    /// ```
    /// {@end-tool}
    ///
    /// See also:
    ///
    ///  * [Focus], a widget that manages a [FocusNode] and provides access to
    ///    focus information and actions to its descendant widgets.
    ///  * [FocusTraversalGroup], a widget used to group together and configure the
    ///    focus traversal policy for a widget subtree.
    ///  * [FocusManager], a singleton that manages the primary focus and
    ///    distributes key events to focused nodes.
    ///  * [FocusTraversalPolicy], a class used to determine how to move the focus
    ///    to other nodes.
    /// </Summary>
    public class FocusNode : IDiagnosticableTreeMixin, IChangeNotifier
    {
        /// <Summary>
        /// Creates a focus node.
        ///
        /// The [debugLabel] is ignored on release builds.
        ///
        /// The [skipTraversal] and [canRequestFocus] arguments must not be null.
        /// </Summary>
        public FocusNode(string debugLabel = default(string), FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback onKey = default(FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback), bool skipTraversal = false, bool canRequestFocus = true)
        : base()
        {

            this.DebugLabel = debugLabel;
        }


        internal virtual bool _SkipTraversal { get; set; }
        internal virtual bool _CanRequestFocus { get; set; }
        internal virtual FlutterSDK.Widgets.Framework.BuildContext _Context { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback _OnKey { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusManager _Manager { get; set; }
        internal virtual List<FlutterSDK.Widgets.Focusmanager.FocusNode> _Ancestors { get; set; }
        internal virtual List<FlutterSDK.Widgets.Focusmanager.FocusNode> _Descendants { get; set; }
        internal virtual bool _HasKeyboardToken { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _Parent { get; set; }
        internal virtual List<FlutterSDK.Widgets.Focusmanager.FocusNode> _Children { get; set; }
        internal virtual string _DebugLabel { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusAttachment _Attachment { get; set; }
        internal virtual bool _RequestFocusWhenReparented { get; set; }
        public virtual bool SkipTraversal { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool CanRequestFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Framework.BuildContext Context { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback OnKey { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode Parent { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> Children { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> TraversalChildren { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual string DebugLabel { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> Descendants { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> TraversalDescendants { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Iterable<FlutterSDK.Widgets.Focusmanager.FocusNode> Ancestors { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool HasPrimaryFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusHighlightMode HighlightMode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusScopeNode NearestScope { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusScopeNode EnclosingScope { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual Size Size { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Offset Offset { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterBinding.UI.Rect Rect { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Removes the focus on this node by moving the primary focus to another node.
        ///
        /// This method removes focus from a node that has the primary focus, cancels
        /// any outstanding requests to focus it, while setting the primary focus to
        /// another node according to the `disposition`.
        ///
        /// It is safe to call regardless of whether this node has ever requested
        /// focus or not. If this node doesn't have focus or primary focus, nothing
        /// happens.
        ///
        /// The `disposition` argument determines which node will receive primary
        /// focus after this one loses it.
        ///
        /// If `disposition` is set to [UnfocusDisposition.scope] (the default), then
        /// the previously focused node history of the enclosing scope will be
        /// cleared, and the primary focus will be moved to the nearest enclosing
        /// scope ancestor that is enabled for focus, ignoring the
        /// [FocusScopeNode.focusedChild] for that scope.
        ///
        /// If `disposition` is set to [UnfocusDisposition.previouslyFocusedChild],
        /// then this node will be removed from the previously focused list in the
        /// [enclosingScope], and the focus will be moved to the previously focused
        /// node of the [enclosingScope], which (if it is a scope itself), will find
        /// its focused child, etc., until a leaf focus node is found. If there is no
        /// previously focused child, then the scope itself will receive focus, as if
        /// [UnfocusDisposition.scope] were specified.
        ///
        /// If you want this node to lose focus and the focus to move to the next or
        /// previous node in the enclosing [FocusTraversalGroup], call [nextFocus] or
        /// [previousFocus] instead of calling `unfocus`.
        ///
        /// {@tool dartpad --template=stateful_widget_material}
        /// This example shows the difference between the different [UnfocusDisposition]
        /// values for [unfocus].
        ///
        /// Try setting focus on the four text fields by selecting them, and then
        /// select "UNFOCUS" to see what happens when the current
        /// [FocusManager.primaryFocus] is unfocused.
        ///
        /// Try pressing the TAB key after unfocusing to see what the next widget
        /// chosen is.
        ///
        /// ```dart imports
        /// import 'package:flutter/foundation.dart';
        /// ```
        ///
        /// ```dart
        /// UnfocusDisposition disposition = UnfocusDisposition.scope;
        ///
        /// @override
        /// Widget build(BuildContext context) {
        ///   return Material(
        ///     child: Container(
        ///       color: Colors.white,
        ///       child: Column(
        ///         mainAxisAlignment: MainAxisAlignment.center,
        ///         children: <Widget>[
        ///           Wrap(
        ///             children: List<Widget>.generate(4, (int index) {
        ///               return SizedBox(
        ///                 width: 200,
        ///                 child: Padding(
        ///                   padding: const EdgeInsets.all(8.0),
        ///                   child: TextField(
        ///                     decoration: InputDecoration(border: OutlineInputBorder()),
        ///                   ),
        ///                 ),
        ///               );
        ///             }),
        ///           ),
        ///           Row(
        ///             mainAxisAlignment: MainAxisAlignment.spaceAround,
        ///             children: <Widget>[
        ///               ...List<Widget>.generate(UnfocusDisposition.values.length,
        ///                   (int index) {
        ///                 return Row(
        ///                   mainAxisSize: MainAxisSize.min,
        ///                   children: <Widget>[
        ///                     Radio<UnfocusDisposition>(
        ///                       groupValue: disposition,
        ///                       onChanged: (UnfocusDisposition value) {
        ///                         setState(() {
        ///                           disposition = value;
        ///                         });
        ///                       },
        ///                       value: UnfocusDisposition.values[index],
        ///                     ),
        ///                     Text(describeEnum(UnfocusDisposition.values[index])),
        ///                   ],
        ///                 );
        ///               }),
        ///               OutlineButton(
        ///                 child: const Text('UNFOCUS'),
        ///                 onPressed: () {
        ///                   setState(() {
        ///                     primaryFocus.unfocus(disposition: disposition);
        ///                   });
        ///                 },
        ///               ),
        ///             ],
        ///           ),
        ///         ],
        ///       ),
        ///     ),
        ///   );
        /// }
        /// ```
        /// {@end-tool}
        /// </Summary>
        public virtual void Unfocus(FlutterSDK.Widgets.Focusmanager.UnfocusDisposition disposition = default(FlutterSDK.Widgets.Focusmanager.UnfocusDisposition))
        {

            if (!HasFocus && (_Manager == null || _Manager._MarkedForFocus != this))
            {
                return;
            }

            FocusScopeNode scope = EnclosingScope;
            if (scope == null)
            {
                return;
            }

            switch (disposition)
            {
                case UnfocusDisposition.Scope:
                    if (scope.CanRequestFocus)
                    {
                        scope._FocusedChildren.Clear();
                    }
                    while (!scope.CanRequestFocus)
                    {
                        scope = scope.EnclosingScope ?? _Manager?.RootScope;
                    }
                    scope?._DoRequestFocus(findFirstFocus: false); break;
                case UnfocusDisposition.PreviouslyFocusedChild:
                    if (scope.CanRequestFocus)
                    {
                        scope?._FocusedChildren?.Remove(this);
                    }
                    while (!scope.CanRequestFocus)
                    {
                        scope.EnclosingScope?._FocusedChildren?.Remove(scope);
                        scope = scope.EnclosingScope ?? _Manager?.RootScope;
                    }
                    scope?._DoRequestFocus(findFirstFocus: true); break;
            }

        }




        /// <Summary>
        /// Removes the keyboard token from this focus node if it has one.
        ///
        /// This mechanism helps distinguish between an input control gaining focus by
        /// default and gaining focus as a result of an explicit user action.
        ///
        /// When a focus node requests the focus (either via
        /// [FocusScopeNode.requestFocus] or [FocusScopeNode.autofocus]), the focus
        /// node receives a keyboard token if it does not already have one. Later,
        /// when the focus node becomes focused, the widget that manages the
        /// [TextInputConnection] should show the keyboard (i.e. call
        /// [TextInputConnection.show]) only if it successfully consumes the keyboard
        /// token from the focus node.
        ///
        /// Returns true if this method successfully consumes the keyboard token.
        /// </Summary>
        public virtual bool ConsumeKeyboardToken()
        {
            if (!_HasKeyboardToken)
            {
                return false;
            }

            _HasKeyboardToken = false;
            return true;
        }




        private void _MarkNextFocus(FlutterSDK.Widgets.Focusmanager.FocusNode newFocus)
        {
            if (_Manager != null)
            {
                _Manager._MarkNextFocus(this);
                return;
            }

            newFocus?._SetAsFocusedChildForScope();
            newFocus?._Notify();
            if (newFocus != this)
            {
                _Notify();
            }

        }




        private void _RemoveChild(FlutterSDK.Widgets.Focusmanager.FocusNode node, bool removeScopeFocus = true)
        {




            if (removeScopeFocus)
            {
                node.EnclosingScope?._FocusedChildren?.Remove(node);
            }

            node._Parent = null;
            _Children.Remove(node);
            foreach (FocusNode ancestor in Ancestors)
            {
                ancestor._Descendants = null;
            }

            _Descendants = null;

        }




        private void _UpdateManager(FlutterSDK.Widgets.Focusmanager.FocusManager manager)
        {
            _Manager = manager;
            foreach (FocusNode descendant in Descendants)
            {
                descendant._Manager = manager;
                descendant._Ancestors = null;
            }

        }




        private void _Reparent(FlutterSDK.Widgets.Focusmanager.FocusNode child)
        {


            if (child._Parent == this)
            {

                return;
            }



            FocusScopeNode oldScope = child.EnclosingScope;
            bool hadFocus = child.HasFocus;
            child._Parent?._RemoveChild(child, removeScopeFocus: oldScope != NearestScope);
            _Children.Add(child);
            child._Parent = this;
            child._Ancestors = null;
            child._UpdateManager(_Manager);
            foreach (FocusNode ancestor in child.Ancestors)
            {
                ancestor._Descendants = null;
            }

            if (hadFocus)
            {
                _Manager?.PrimaryFocus?._SetAsFocusedChildForScope();
            }

            if (oldScope != null && child.Context != null && child.EnclosingScope != oldScope)
            {
                FocustraversalDefaultClass.FocusTraversalGroup.Of(child.Context, nullOk: true)?.ChangedScope(node: child, oldScope: oldScope);
            }

            if (child._RequestFocusWhenReparented)
            {
                child._DoRequestFocus(findFirstFocus: true);
                child._RequestFocusWhenReparented = false;
            }

        }




        /// <Summary>
        /// Called by the _host_ [StatefulWidget] to attach a [FocusNode] to the
        /// widget tree.
        ///
        /// In order to attach a [FocusNode] to the widget tree, call [attach],
        /// typically from the [StatefulWidget]'s [State.initState] method.
        ///
        /// If the focus node in the host widget is swapped out, the new node will
        /// need to be attached. [FocusAttachment.detach] should be called on the old
        /// node, and then [attach] called on the new node. This typically happens in
        /// the [State.didUpdateWidget] method.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusAttachment Attach(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback onKey = default(FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback))
        {
            _Context = context;
            _OnKey = onKey ?? _OnKey;
            _Attachment = FocusAttachment._(this);
            return _Attachment;
        }




        public new void Dispose()
        {
            _Attachment?.Detach();
            base.Dispose();
        }




        private void _Notify()
        {
            if (_Parent == null)
            {
                return;
            }

            if (HasPrimaryFocus)
            {
                _SetAsFocusedChildForScope();
            }

            NotifyListeners();
        }




        /// <Summary>
        /// Requests the primary focus for this node, or for a supplied [node], which
        /// will also give focus to its [ancestors].
        ///
        /// If called without a node, request focus for this node. If the node hasn't
        /// been added to the focus tree yet, then defer the focus request until it
        /// is, allowing newly created widgets to request focus as soon as they are
        /// added.
        ///
        /// If the given [node] is not yet a part of the focus tree, then this method
        /// will add the [node] as a child of this node before requesting focus.
        ///
        /// If the given [node] is a [FocusScopeNode] and that focus scope node has a
        /// non-null [focusedChild], then request the focus for the focused child.
        /// This process is recursive and continues until it encounters either a focus
        /// scope node with a null focused child or an ordinary (non-scope)
        /// [FocusNode] is found.
        ///
        /// The node is notified that it has received the primary focus in a
        /// microtask, so notification may lag the request by up to one frame.
        /// </Summary>
        public virtual void RequestFocus(FlutterSDK.Widgets.Focusmanager.FocusNode node = default(FlutterSDK.Widgets.Focusmanager.FocusNode))
        {
            if (node != null)
            {
                if (node._Parent == null)
                {
                    _Reparent(node);
                }


                node._DoRequestFocus(findFirstFocus: true);
                return;
            }

            _DoRequestFocus(findFirstFocus: true);
        }




        private void _DoRequestFocus(bool findFirstFocus = default(bool))
        {

            if (!CanRequestFocus)
            {

                return;
            }

            if (_Parent == null)
            {
                _RequestFocusWhenReparented = true;
                return;
            }

            _SetAsFocusedChildForScope();
            if (HasPrimaryFocus && (_Manager._MarkedForFocus == null || _Manager._MarkedForFocus == this))
            {
                return;
            }

            _HasKeyboardToken = true;

            _MarkNextFocus(this);
        }




        /// <Summary>
        /// Sets this node as the [FocusScopeNode.focusedChild] of the enclosing
        /// scope.
        ///
        /// Sets this node as the focused child for the enclosing scope, and that
        /// scope as the focused child for the scope above it, etc., until it reaches
        /// the root node. It doesn't change the primary focus, it just changes what
        /// node would be focused if the enclosing scope receives focus, and keeps
        /// track of previously focused children in that scope, so that if the focused
        /// child in that scope is removed, the previous focus returns.
        /// </Summary>
        private void _SetAsFocusedChildForScope()
        {
            FocusNode scopeFocus = this;
            foreach (FocusScopeNode ancestor in Ancestors.WhereType())
            {


                ancestor._FocusedChildren.Remove(scopeFocus);
                ancestor._FocusedChildren.Add(scopeFocus);
                scopeFocus = ancestor;
            }

        }




        /// <Summary>
        /// Request to move the focus to the next focus node, by calling the
        /// [FocusTraversalPolicy.next] method.
        ///
        /// Returns true if it successfully found a node and requested focus.
        /// </Summary>
        public virtual bool NextFocus() => FocustraversalDefaultClass.FocusTraversalGroup.Of(Context).Next(this);



        /// <Summary>
        /// Request to move the focus to the previous focus node, by calling the
        /// [FocusTraversalPolicy.previous] method.
        ///
        /// Returns true if it successfully found a node and requested focus.
        /// </Summary>
        public virtual bool PreviousFocus() => FocustraversalDefaultClass.FocusTraversalGroup.Of(Context).Previous(this);



        /// <Summary>
        /// Request to move the focus to the nearest focus node in the given
        /// direction, by calling the [FocusTraversalPolicy.inDirection] method.
        ///
        /// Returns true if it successfully found a node and requested focus.
        /// </Summary>
        public virtual bool FocusInDirection(FlutterSDK.Widgets.Focustraversal.TraversalDirection direction) => FocustraversalDefaultClass.FocusTraversalGroup.Of(Context).InDirection(this, direction);



        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            properties.Add(new DiagnosticsProperty<BuildContext>("context", Context, defaultValue: null));
            properties.Add(new FlagProperty("canRequestFocus", value: CanRequestFocus, ifFalse: "NOT FOCUSABLE", defaultValue: true));
            properties.Add(new FlagProperty("hasFocus", value: HasFocus && !HasPrimaryFocus, ifTrue: "IN FOCUS PATH", defaultValue: false));
            properties.Add(new FlagProperty("hasPrimaryFocus", value: HasPrimaryFocus, ifTrue: "PRIMARY FOCUS", defaultValue: false));
        }




        public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            int count = 1;
            return _Children.Map((FocusNode child) =>
            {
                return child.ToDiagnosticsNode(name: $"'Child {count++}'");
            }
            ).ToList();
        }




        public new string ToStringShort()
        {
            bool hasDebugLabel = DebugLabel != null && DebugLabel.IsNotEmpty;
            string extraData = $"'{hasDebugLabel ? DebugLabel:""}'" + $"'{HasFocus && hasDebugLabel ? ' ':""}'" + $"'{HasFocus && !HasPrimaryFocus ? "[IN FOCUS PATH]":""}'" + $"'{HasPrimaryFocus ? "[PRIMARY FOCUS]":""}'";
            return $"'{DiagnosticsDefaultClass.DescribeIdentity(this)}{extraData.IsNotEmpty ? $"'({extraData})'":""}'";
        }



    }


    /// <Summary>
    /// A subclass of [FocusNode] that acts as a scope for its descendants,
    /// maintaining information about which descendant is currently or was last
    /// focused.
    ///
    /// _Please see the [FocusScope] and [Focus] widgets, which are utility widgets
    /// that manage their own [FocusScopeNode]s and [FocusNode]s, respectively. If
    /// they aren't appropriate, [FocusScopeNode]s can be managed directly._
    ///
    /// [FocusScopeNode] organizes [FocusNodes] into _scopes_. Scopes form sub-trees
    /// of nodes that can be traversed as a group. Within a scope, the most recent
    /// nodes to have focus are remembered, and if a node is focused and then
    /// removed, the original node receives focus again.
    ///
    /// From a [FocusScopeNode], calling [setFirstFocus], sets the given focus scope
    /// as the [focusedChild] of this node, adopting if it isn't already part of the
    /// focus tree.
    ///
    /// {@macro flutter.widgets.focus_manager.focus.lifecycle}
    /// {@macro flutter.widgets.focus_manager.focus.keyEvents}
    ///
    /// See also:
    ///
    ///  * [Focus], a widget that manages a [FocusNode] and provides access to focus
    ///    information and actions to its descendant widgets.
    ///  * [FocusManager], a singleton that manages the primary focus and
    ///    distributes key events to focused nodes.
    /// </Summary>
    public class FocusScopeNode : FlutterSDK.Widgets.Focusmanager.FocusNode
    {
        /// <Summary>
        /// Creates a [FocusScopeNode].
        ///
        /// All parameters are optional.
        /// </Summary>
        public FocusScopeNode(string debugLabel = default(string), FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback onKey = default(FlutterSDK.Widgets.Focusmanager.FocusOnKeyCallback), bool skipTraversal = false, bool canRequestFocus = true)
        : base(debugLabel: debugLabel, onKey: onKey, canRequestFocus: canRequestFocus, skipTraversal: skipTraversal)
        {

        }
        internal virtual List<FlutterSDK.Widgets.Focusmanager.FocusNode> _FocusedChildren { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusScopeNode NearestScope { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual bool IsFirstFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode FocusedChild { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Make the given [scope] the active child scope for this scope.
        ///
        /// If the given [scope] is not yet a part of the focus tree, then add it to
        /// the tree as a child of this scope. If it is already part of the focus
        /// tree, the given scope must be a descendant of this scope.
        /// </Summary>
        public virtual void SetFirstFocus(FlutterSDK.Widgets.Focusmanager.FocusScopeNode scope)
        {



            if (scope._Parent == null)
            {
                _Reparent(scope);
            }


            if (HasFocus)
            {
                scope._DoRequestFocus(findFirstFocus: true);
            }
            else
            {
                scope._SetAsFocusedChildForScope();
            }

        }




        /// <Summary>
        /// If this scope lacks a focus, request that the given node become the focus.
        ///
        /// If the given node is not yet part of the focus tree, then add it as a
        /// child of this node.
        ///
        /// Useful for widgets that wish to grab the focus if no other widget already
        /// has the focus.
        ///
        /// The node is notified that it has received the primary focus in a
        /// microtask, so notification may lag the request by up to one frame.
        /// </Summary>
        public virtual void Autofocus(FlutterSDK.Widgets.Focusmanager.FocusNode node)
        {

            if (FocusedChild == null)
            {
                if (node._Parent == null)
                {
                    _Reparent(node);
                }


                node._DoRequestFocus(findFirstFocus: true);
            }

        }




        protected new void _DoRequestFocus(bool findFirstFocus = default(bool))
        {

            while (FocusedChild != null && !FocusedChild.CanRequestFocus) _FocusedChildren.RemoveLast();
            if (!findFirstFocus)
            {
                if (CanRequestFocus)
                {
                    _SetAsFocusedChildForScope();
                    _MarkNextFocus(this);
                }

                return;
            }

            FocusNode primaryFocus = FocusedChild ?? this;
            while (primaryFocus is FocusScopeNode && primaryFocus.FocusedChild != null)
            {
                FocusScopeNode scope = primaryFocus as FocusScopeNode;
                primaryFocus = scope.FocusedChild;
            }

            if (Dart.CoreDefaultClass.Identical(primaryFocus, this))
            {
                if (((FocusScopeNode)primaryFocus).CanRequestFocus)
                {
                    _SetAsFocusedChildForScope();
                    _MarkNextFocus(this);
                }

            }
            else
            {
                primaryFocus._DoRequestFocus(findFirstFocus: findFirstFocus);
            }

        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            base.DebugFillProperties(properties);
            if (_FocusedChildren.IsEmpty())
            {
                return;
            }

            List<string> childList = _FocusedChildren.Reversed.Map((FocusNode child) =>
            {
                return child.ToStringShort();
            }
            ).ToList();
            properties.Add(new IterableProperty<string>("focusedChildren", childList, defaultValue: new List<string>() { }));
        }



    }


    /// <Summary>
    /// Manages the focus tree.
    ///
    /// The focus tree is a separate, sparser, tree from the widget tree that
    /// maintains the hierarchical relationship between focusable widgets in the
    /// widget tree.
    ///
    /// The focus manager is responsible for tracking which [FocusNode] has the
    /// primary input focus (the [primaryFocus]), holding the [FocusScopeNode] that
    /// is the root of the focus tree (the [rootScope]), and what the current
    /// [highlightMode] is. It also distributes key events from [RawKeyboard] to the
    /// nodes in the focus tree.
    ///
    /// The singleton [FocusManager] instance is held by the [WidgetsBinding] as
    /// [WidgetsBinding.focusManager], and can be conveniently accessed using the
    /// [FocusManager.instance] static accessor.
    ///
    /// To find the [FocusNode] for a given [BuildContext], use [Focus.of]. To find
    /// the [FocusScopeNode] for a given [BuildContext], use [FocusScope.of].
    ///
    /// If you would like notification whenever the [primaryFocus] changes, register
    /// a listener with [addListener]. When you no longer want to receive these
    /// events, as when your object is about to be disposed, you must unregister
    /// with [removeListener] to avoid memory leaks. Removing listeners is typically
    /// done in [State.dispose] on stateful widgets.
    ///
    /// The [highlightMode] describes how focus highlights should be displayed on
    /// components in the UI. The [highlightMode] changes are notified separately
    /// via [addHighlightModeListener] and removed with
    /// [removeHighlightModeListener]. The highlight mode changes when the user
    /// switches from a mouse to a touch interface, or vice versa.
    ///
    /// The widgets that are used to manage focus in the widget tree are:
    ///
    ///  * [Focus], a widget that manages a [FocusNode] in the focus tree so that
    ///    the focus tree reflects changes in the widget hierarchy.
    ///  * [FocusScope], a widget that manages a [FocusScopeNode] in the focus tree,
    ///    creating a new scope for restricting focus to a set of focus nodes.
    ///  * [FocusTraversalGroup], a widget that groups together nodes that should be
    ///    traversed using an order described by a given [FocusTraversalPolicy].
    ///
    /// See also:
    ///
    ///  * [FocusNode], which is a node in the focus tree that can receive focus.
    ///  * [FocusScopeNode], which is a node in the focus tree used to collect
    ///    subtrees into groups and restrict focus to them.
    ///  * The [primaryFocus] global accessor, for convenient access from anywhere
    ///    to the current focus manager state.
    /// </Summary>
    public class FocusManager : IDiagnosticableTreeMixin, IChangeNotifier
    {
        /// <Summary>
        /// Creates an object that manages the focus tree.
        ///
        /// This constructor is rarely called directly. To access the [FocusManager],
        /// consider using the [FocusManager.instance] accessor instead (which gets it
        /// from the [WidgetsBinding] singleton).
        /// </Summary>
        public FocusManager()
        {

            RootScope._Manager = this;
            RawkeyboardDefaultClass.RawKeyboard.Instance.AddListener(_HandleRawKeyEvent);
            BindingDefaultClass.GestureBinding.Instance.PointerRouter.AddGlobalRoute(_HandlePointerEvent);
        }


        internal virtual bool _LastInteractionWasTouch { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusHighlightStrategy _HighlightStrategy { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusHighlightMode _HighlightMode { get; set; }
        internal virtual FlutterSDK.Foundation.Observerlist.HashedObserverList<object> _Listeners { get; set; }
        /// <Summary>
        /// The root [FocusScopeNode] in the focus tree.
        ///
        /// This field is rarely used directly. To find the nearest [FocusScopeNode]
        /// for a given [FocusNode], call [FocusNode.nearestScope].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Focusmanager.FocusScopeNode RootScope { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _PrimaryFocus { get; set; }
        internal virtual HashSet<FlutterSDK.Widgets.Focusmanager.FocusNode> _DirtyNodes { get; set; }
        internal virtual FlutterSDK.Widgets.Focusmanager.FocusNode _MarkedForFocus { get; set; }
        internal virtual bool _HaveScheduledUpdate { get; set; }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusManager Instance { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusHighlightStrategy HighlightStrategy { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusHighlightMode HighlightMode { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public virtual FlutterSDK.Widgets.Focusmanager.FocusNode PrimaryFocus { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        private void _UpdateHighlightMode()
        {
            _LastInteractionWasTouch = (_LastInteractionWasTouch == null ? Dart.IoDefaultClass.Platform.IsAndroid || Dart.IoDefaultClass.Platform.IsIOS || !BindingDefaultClass.WidgetsBinding.Instance.MouseTracker.MouseIsConnected : _LastInteractionWasTouch);
            FocusHighlightMode newMode = default(FocusHighlightMode);
            switch (HighlightStrategy)
            {
                case FocusHighlightStrategy.Automatic:
                    if (_LastInteractionWasTouch)
                    {
                        newMode = FocusHighlightMode.Touch;
                    }
                    else
                    {
                        newMode = FocusHighlightMode.Traditional;
                    }
                    break;
                case FocusHighlightStrategy.AlwaysTouch: newMode = FocusHighlightMode.Touch; break;
                case FocusHighlightStrategy.AlwaysTraditional: newMode = FocusHighlightMode.Traditional; break;
            }
            if (newMode != _HighlightMode)
            {
                _HighlightMode = newMode;
                _NotifyHighlightModeListeners();
            }

        }




        /// <Summary>
        /// Register a closure to be called when the [FocusManager] notifies its listeners
        /// that the value of [highlightMode] has changed.
        /// </Summary>
        public virtual void AddHighlightModeListener(FlutterSDK.Foundation.Basictypes.ValueChanged<FocusHighlightMode> listener) => _Listeners.Add(listener);



        /// <Summary>
        /// Remove a previously registered closure from the list of closures that the
        /// [FocusManager] notifies.
        /// </Summary>
        public virtual void RemoveHighlightModeListener(FlutterSDK.Foundation.Basictypes.ValueChanged<FocusHighlightMode> listener) => _Listeners?.Remove(listener);



        private void _NotifyHighlightModeListeners()
        {
            if (_Listeners.IsEmpty())
            {
                return;
            }

            List<ValueChanged<FocusHighlightMode>> localListeners = List<ValueChanged<FocusHighlightMode>>.From(_Listeners);
            foreach (ValueChanged<FocusHighlightMode> listener in localListeners)
            {
                try
                {
                    if (_Listeners.Contains(listener))
                    {
                        listener(_HighlightMode);
                    }

                }
                catch (exception,stack){
                    InformationCollector collector = default(InformationCollector);

                    AssertionsDefaultClass.FlutterError.ReportError(new FlutterErrorDetails(exception: exception, stack: stack, library: "widgets library", context: new ErrorDescription($"'while dispatching notifications for {GetType()}'"), informationCollector: collector));
                }

                }

            }




            private void _HandlePointerEvent(FlutterSDK.Gestures.Events.PointerEvent @event)
            {
                bool currentInteractionIsTouch = default(bool);
                switch (@event.Kind) { case PointerDeviceKind.Touch: case PointerDeviceKind.Stylus: case PointerDeviceKind.InvertedStylus: currentInteractionIsTouch = true; break; case PointerDeviceKind.Mouse: case PointerDeviceKind.Unknown: currentInteractionIsTouch = false; break; }
                if (_LastInteractionWasTouch != currentInteractionIsTouch)
                {
                    _LastInteractionWasTouch = currentInteractionIsTouch;
                    _UpdateHighlightMode();
                }

            }




            private void _HandleRawKeyEvent(FlutterSDK.Services.Rawkeyboard.RawKeyEvent @event)
            {
                if (_LastInteractionWasTouch)
                {
                    _LastInteractionWasTouch = false;
                    _UpdateHighlightMode();
                }


                if (_PrimaryFocus == null)
                {

                    return;
                }

                bool handled = false;
                foreach (FocusNode node in new List<FocusNode>() { _PrimaryFocus,  /* ..._PrimaryFocus.Ancestors */})
                {
                    if (node.OnKey != null && node.OnKey(node, @event))
                    {

                        handled = true;
                        break;
                    }

                }

                if (!handled)
                {

                }

            }




            private void _MarkDetached(FlutterSDK.Widgets.Focusmanager.FocusNode node)
            {

                if (_PrimaryFocus == node)
                {
                    _PrimaryFocus = null;
                }

                _DirtyNodes?.Remove(node);
            }




            private void _MarkPropertiesChanged(FlutterSDK.Widgets.Focusmanager.FocusNode node)
            {
                _MarkNeedsUpdate();

                _DirtyNodes?.Add(node);
            }




            private void _MarkNextFocus(FlutterSDK.Widgets.Focusmanager.FocusNode node)
            {
                if (_PrimaryFocus == node)
                {
                    _MarkedForFocus = null;
                }
                else
                {
                    _MarkedForFocus = node;
                    _MarkNeedsUpdate();
                }

            }




            private void _MarkNeedsUpdate()
            {

                if (_HaveScheduledUpdate)
                {
                    return;
                }

                _HaveScheduledUpdate = true;
                Dart.AsyncDefaultClass.ScheduleMicrotask(_ApplyFocusChange);
            }




            private void _ApplyFocusChange()
            {
                _HaveScheduledUpdate = false;
                FocusNode previousFocus = _PrimaryFocus;
                if (_PrimaryFocus == null && _MarkedForFocus == null)
                {
                    _MarkedForFocus = RootScope;
                }


                if (_MarkedForFocus != null && _MarkedForFocus != _PrimaryFocus)
                {
                    HashSet<FocusNode> previousPath = previousFocus?.Ancestors?.ToSet() ?? new Dictionary<FocusNode> { };
                    HashSet<FocusNode> nextPath = _MarkedForFocus.Ancestors.ToSet();
                    _DirtyNodes.AddAll(nextPath.Difference(previousPath));
                    _DirtyNodes.AddAll(previousPath.Difference(nextPath));
                    _PrimaryFocus = _MarkedForFocus;
                    _MarkedForFocus = null;
                }

                if (previousFocus != _PrimaryFocus)
                {

                    if (previousFocus != null)
                    {
                        _DirtyNodes.Add(previousFocus);
                    }

                    if (_PrimaryFocus != null)
                    {
                        _DirtyNodes.Add(_PrimaryFocus);
                    }

                }


                foreach (FocusNode node in _DirtyNodes)
                {
                    node._Notify();
                }

                _DirtyNodes.Clear();
                if (previousFocus != _PrimaryFocus)
                {
                    NotifyListeners();
                }


            }




public new List<FlutterSDK.Foundation.Diagnostics.DiagnosticsNode> DebugDescribeChildren()
        {
            return new List<DiagnosticsNode>() { RootScope.ToDiagnosticsNode(name: "rootScope") };
        }




        public new void DebugFillProperties(FlutterSDK.Foundation.Diagnostics.DiagnosticPropertiesBuilder properties)
        {
            properties.Add(new FlagProperty("haveScheduledUpdate", value: _HaveScheduledUpdate, ifTrue: "UPDATE SCHEDULED"));
            properties.Add(new DiagnosticsProperty<FocusNode>("primaryFocus", PrimaryFocus, defaultValue: null));
            properties.Add(new DiagnosticsProperty<FocusNode>("nextFocus", _MarkedForFocus, defaultValue: null));
            Element element = PrimaryFocus?.Context as Element;
            if (element != null)
            {
                properties.Add(new DiagnosticsProperty<string>("primaryFocusCreator", element.DebugGetCreatorChain(20)));
            }

        }



    }


    /// <Summary>
    /// Describe what should happen after [FocusNode.unfocus] is called.
    ///
    /// See also:
    ///
    ///  * [FocusNode.unfocus], which takes this as its `disposition` parameter.
    /// </Summary>
    public enum UnfocusDisposition
    {

        /// <Summary>
        /// Focus the nearest focusable enclosing scope of this node, but do not
        /// descend to locate the leaf [FocusScopeNode.focusedChild] the way
        /// [previouslyFocusedChild] does.
        ///
        /// Focusing the scope in this way clears the [FocusScopeNode.focusedChild]
        /// history for the enclosing scope when it receives focus. Because of this,
        /// calling a traversal method like [FocusNode.nextFocus] after unfocusing
        /// will cause the [FocusTraversalPolicy] to pick the node it thinks should be
        /// first in the scope.
        ///
        /// This is the default disposition for [FocusNode.unfocus].
        /// </Summary>
        Scope,
        /// <Summary>
        /// Focus the previously focused child of the nearest focusable enclosing
        /// scope of this node.
        ///
        /// If there is no previously focused child, then this is equivalent to
        /// using the [scope] disposition.
        ///
        /// Unfocusing with this disposition will cause [FocusNode.unfocus] to walk up
        /// the tree to the nearest focusable enclosing scope, then start to walk down
        /// the tree, looking for a focused child at its
        /// [FocusScopeNode.focusedChild].
        ///
        /// If the [FocusScopeNode.focusedChild] is a scope, then look for its
        /// [FocusScopeNode.focusedChild], and so on, finding the leaf
        /// [FocusScopeNode.focusedChild] that is not a scope, or, failing that, a
        /// leaf scope that has no focused child.
        /// </Summary>
        PreviouslyFocusedChild,
    }


    /// <Summary>
    /// An enum to describe which kind of focus highlight behavior to use when
    /// displaying focus information.
    /// </Summary>
    public enum FocusHighlightMode
    {

        /// <Summary>
        /// Touch interfaces will not show the focus highlight except for controls
        /// which bring up the soft keyboard.
        ///
        /// If a device that uses a traditional mouse and keyboard has a touch screen
        /// attached, it can also enter `touch` mode if the user is using the touch
        /// screen.
        /// </Summary>
        Touch,
        /// <Summary>
        /// Traditional interfaces (keyboard and mouse) will show the currently
        /// focused control via a focus highlight of some sort.
        ///
        /// If a touch device (like a mobile phone) has a keyboard and/or mouse
        /// attached, it also can enter `traditional` mode if the user is using these
        /// input devices.
        /// </Summary>
        Traditional,
    }


    /// <Summary>
    /// An enum to describe how the current value of [FocusManager.highlightMode] is
    /// determined. The strategy is set on [FocusManager.highlightStrategy].
    /// </Summary>
    public enum FocusHighlightStrategy
    {

        /// <Summary>
        /// Automatic switches between the various highlight modes based on the last
        /// kind of input that was received. This is the default.
        /// </Summary>
        Automatic,
        /// <Summary>
        /// [FocusManager.highlightMode] always returns [FocusHighlightMode.touch].
        /// </Summary>
        AlwaysTouch,
        /// <Summary>
        /// [FocusManager.highlightMode] always returns [FocusHighlightMode.traditional].
        /// </Summary>
        AlwaysTraditional,
    }

}
