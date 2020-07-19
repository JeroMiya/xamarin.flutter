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

        /// <Summary>
        /// Builds a selection handle of the given type.
        ///
        /// The top left corner of this widget is positioned at the bottom of the
        /// selection position.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildHandle(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Textselection.TextSelectionHandleType type, double textLineHeight)
        {
            return default(Widget);
        }


        /// <Summary>
        /// Get the anchor point of the handle relative to itself. The anchor point is
        /// the point that is aligned with a specific point in the text. A handle
        /// often visually "points to" that location.
        /// </Summary>
        public virtual Offset GetHandleAnchor(FlutterSDK.Widgets.Textselection.TextSelectionHandleType type, double textLineHeight)
        {
            return default(Offset);
        }


        /// <Summary>
        /// Builds a toolbar near a text selection.
        ///
        /// Typically displays buttons for copying and pasting text.
        ///
        /// [globalEditableRegion] is the TextField size of the global coordinate system
        /// in logical pixels.
        ///
        /// [textLineHeight] is the `preferredLineHeight` of the [RenderEditable] we
        /// are building a toolbar for.
        ///
        /// The [position] is a general calculation midpoint parameter of the toolbar.
        /// If you want more detailed position information, can use [endpoints]
        /// to calculate it.
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildToolbar(FlutterSDK.Widgets.Framework.BuildContext context, FlutterBinding.UI.Rect globalEditableRegion, double textLineHeight, FlutterBinding.UI.Offset position, List<FlutterSDK.Rendering.Editable.TextSelectionPoint> endpoints, FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
        {
            return default(Widget);
        }


        /// <Summary>
        /// Returns the size of the selection handle.
        /// </Summary>
        public virtual Size GetHandleSize(double textLineHeight)
        {
            return default(Size);
        }


        /// <Summary>
        /// Whether the current selection of the text field managed by the given
        /// `delegate` can be removed from the text field and placed into the
        /// [Clipboard].
        ///
        /// By default, false is returned when nothing is selected in the text field.
        ///
        /// Subclasses can use this to decide if they should expose the cut
        /// functionality to the user.
        /// </Summary>
        public virtual bool CanCut(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
        {
            return delegate.CutEnabled && !delegate.TextEditingValue.Selection.IsCollapsed;
        }




        /// <Summary>
        /// Whether the current selection of the text field managed by the given
        /// `delegate` can be copied to the [Clipboard].
        ///
        /// By default, false is returned when nothing is selected in the text field.
        ///
        /// Subclasses can use this to decide if they should expose the copy
        /// functionality to the user.
        /// </Summary>
        public virtual bool CanCopy(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
        {
            return delegate.CopyEnabled && !delegate.TextEditingValue.Selection.IsCollapsed;
        }




        /// <Summary>
        /// Whether the current [Clipboard] content can be pasted into the text field
        /// managed by the given `delegate`.
        ///
        /// Subclasses can use this to decide if they should expose the paste
        /// functionality to the user.
        /// </Summary>
        public virtual bool CanPaste(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
        {
            return delegate.PasteEnabled;
        }




        /// <Summary>
        /// Whether the current selection of the text field managed by the given
        /// `delegate` can be extended to include the entire content of the text
        /// field.
        ///
        /// Subclasses can use this to decide if they should expose the select all
        /// functionality to the user.
        /// </Summary>
        public virtual bool CanSelectAll(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
        {
            return delegate.SelectAllEnabled && delegate.TextEditingValue.Text.IsNotEmpty && delegate.TextEditingValue.Selection.IsCollapsed;
        }




        /// <Summary>
        /// Copy the current selection of the text field managed by the given
        /// `delegate` to the [Clipboard]. Then, remove the selected text from the
        /// text field and hide the toolbar.
        ///
        /// This is called by subclasses when their cut affordance is activated by
        /// the user.
        /// </Summary>
        public virtual void HandleCut(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
        {
            TextEditingValue value = delegate.TextEditingValue;
            ClipboardDefaultClass.Clipboard.SetData(new ClipboardData(text: value.Selection.TextInside(value.Text)));
            delegate.TextEditingValue = new TextEditingValue(text: value.Selection.TextBefore(value.Text) + value.Selection.TextAfter(value.Text), selection: TextSelection.Collapsed(offset: value.Selection.Start));
            delegate.BringIntoView(delegate.TextEditingValue.Selection.Extent);
            delegate.HideToolbar();
        }




        /// <Summary>
        /// Copy the current selection of the text field managed by the given
        /// `delegate` to the [Clipboard]. Then, move the cursor to the end of the
        /// text (collapsing the selection in the process), and hide the toolbar.
        ///
        /// This is called by subclasses when their copy affordance is activated by
        /// the user.
        /// </Summary>
        public virtual void HandleCopy(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
        {
            TextEditingValue value = delegate.TextEditingValue;
            ClipboardDefaultClass.Clipboard.SetData(new ClipboardData(text: value.Selection.TextInside(value.Text)));
            delegate.TextEditingValue = new TextEditingValue(text: value.Text, selection: TextSelection.Collapsed(offset: value.Selection.End));
            delegate.BringIntoView(delegate.TextEditingValue.Selection.Extent);
            delegate.HideToolbar();
        }




        /// <Summary>
        /// Paste the current clipboard selection (obtained from [Clipboard]) into
        /// the text field managed by the given `delegate`, replacing its current
        /// selection, if any. Then, hide the toolbar.
        ///
        /// This is called by subclasses when their paste affordance is activated by
        /// the user.
        ///
        /// This function is asynchronous since interacting with the clipboard is
        /// asynchronous. Race conditions may exist with this API as currently
        /// implemented.
        /// </Summary>
        public virtual Future<object> HandlePaste(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
        {
            TextEditingValue value = delegate.TextEditingValue;
            ClipboardData data = await ClipboardDefaultClass.Clipboard.GetData(ClipboardDefaultClass.Clipboard.KTextPlain);
            if (data != null)
            {
                delegate.TextEditingValue = new TextEditingValue(text: value.Selection.TextBefore(value.Text) + data.Text + value.Selection.TextAfter(value.Text), selection: TextSelection.Collapsed(offset: value.Selection.Start + data.Text.Length));
            }

            delegate.BringIntoView(delegate.TextEditingValue.Selection.Extent);
            delegate.HideToolbar();
        }




        /// <Summary>
        /// Adjust the selection of the text field managed by the given `delegate` so
        /// that everything is selected.
        ///
        /// Does not hide the toolbar.
        ///
        /// This is called by subclasses when their select-all affordance is activated
        /// by the user.
        /// </Summary>
        public virtual void HandleSelectAll(FlutterSDK.Services.Textinput.TextSelectionDelegate @delegate)
        {
            delegate.TextEditingValue = new TextEditingValue(text: delegate.TextEditingValue.Text, selection: new TextSelection(baseOffset: 0, extentOffset: delegate.TextEditingValue.Text.Length));
            delegate.BringIntoView(delegate.TextEditingValue.Selection.Extent);
        }



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


    /// <Summary>
    /// An object that manages a pair of text selection handles.
    ///
    /// The selection handles are displayed in the [Overlay] that most closely
    /// encloses the given [BuildContext].
    /// </Summary>
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
            this.OnSelectionHandleTapped = onSelectionHandleTapped;
            OverlayState overlay = OverlayDefaultClass.Overlay.Of(Context, rootOverlay: true);

            _ToolbarController = new AnimationController(duration: FadeDuration, vsync: overlay);
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

        /// <Summary>
        /// Builds the handles by inserting them into the [context]'s overlay.
        /// </Summary>
        public virtual void ShowHandles()
        {

            _Handles = new List<OverlayEntry>() { new OverlayEntry(builder: (BuildContext context) => =>_BuildHandle(context, _TextSelectionHandlePosition.Start)), new OverlayEntry(builder: (BuildContext context) => =>_BuildHandle(context, _TextSelectionHandlePosition.End)) };
            OverlayDefaultClass.Overlay.Of(Context, rootOverlay: true, debugRequiredFor: DebugRequiredFor).InsertAll(_Handles);
        }




        /// <Summary>
        /// Destroys the handles by removing them from overlay.
        /// </Summary>
        public virtual void HideHandles()
        {
            if (_Handles != null)
            {
                _Handles[0].Remove();
                _Handles[1].Remove();
                _Handles = null;
            }

        }




        /// <Summary>
        /// Shows the toolbar by inserting it into the [context]'s overlay.
        /// </Summary>
        public virtual void ShowToolbar()
        {

            _Toolbar = new OverlayEntry(builder: _BuildToolbar);
            OverlayDefaultClass.Overlay.Of(Context, rootOverlay: true, debugRequiredFor: DebugRequiredFor).Insert(_Toolbar);
            _ToolbarController.Forward(from: 0.0);
        }




        /// <Summary>
        /// Updates the overlay after the selection has changed.
        ///
        /// If this method is called while the [SchedulerBinding.schedulerPhase] is
        /// [SchedulerPhase.persistentCallbacks], i.e. during the build, layout, or
        /// paint phases (see [WidgetsBinding.drawFrame]), then the update is delayed
        /// until the post-frame callbacks phase. Otherwise the update is done
        /// synchronously. This means that it is safe to call during builds, but also
        /// that if you do call this during a build, the UI will not update until the
        /// next frame (i.e. many milliseconds later).
        /// </Summary>
        public virtual void Update(FlutterSDK.Services.Textinput.TextEditingValue newValue)
        {
            if (_Value == newValue) return;
            _Value = newValue;
            if (BindingDefaultClass.SchedulerBinding.Instance.SchedulerPhase == SchedulerPhase.PersistentCallbacks)
            {
                BindingDefaultClass.SchedulerBinding.Instance.AddPostFrameCallback(_MarkNeedsBuild);
            }
            else
            {
                _MarkNeedsBuild();
            }

        }




        /// <Summary>
        /// Causes the overlay to update its rendering.
        ///
        /// This is intended to be called when the [renderObject] may have changed its
        /// text metrics (e.g. because the text was scrolled).
        /// </Summary>
        public virtual void UpdateForScroll()
        {
            _MarkNeedsBuild();
        }




        private void _MarkNeedsBuild(TimeSpan duration = default(TimeSpan))
        {
            if (_Handles != null)
            {
                _Handles[0].MarkNeedsBuild();
                _Handles[1].MarkNeedsBuild();
            }

            _Toolbar?.MarkNeedsBuild();
        }




        /// <Summary>
        /// Hides the entire overlay including the toolbar and the handles.
        /// </Summary>
        public virtual void Hide()
        {
            if (_Handles != null)
            {
                _Handles[0].Remove();
                _Handles[1].Remove();
                _Handles = null;
            }

            if (_Toolbar != null)
            {
                HideToolbar();
            }

        }




        /// <Summary>
        /// Hides the toolbar part of the overlay.
        ///
        /// To hide the whole overlay, see [hide].
        /// </Summary>
        public virtual void HideToolbar()
        {

            _ToolbarController.Stop();
            _Toolbar.Remove();
            _Toolbar = null;
        }




        /// <Summary>
        /// Final cleanup.
        /// </Summary>
        public virtual void Dispose()
        {
            Hide();
            _ToolbarController.Dispose();
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildHandle(FlutterSDK.Widgets.Framework.BuildContext context, FlutterSDK.Widgets.Textselection._TextSelectionHandlePosition position)
        {
            if ((_Selection.IsCollapsed && position == _TextSelectionHandlePosition.End) || SelectionControls == null) return new Container();
            return new Visibility(visible: HandlesVisible, child: new _TextSelectionHandleOverlay(onSelectionHandleChanged: (TextSelection newSelection) =>
            {
                _HandleSelectionHandleChanged(newSelection, position);
            }
            , onSelectionHandleTapped: OnSelectionHandleTapped, startHandleLayerLink: StartHandleLayerLink, endHandleLayerLink: EndHandleLayerLink, renderObject: RenderObject, selection: _Selection, selectionControls: SelectionControls, position: position, dragStartBehavior: DragStartBehavior));
        }




        private FlutterSDK.Widgets.Framework.Widget _BuildToolbar(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            if (SelectionControls == null) return new Container();
            List<TextSelectionPoint> endpoints = RenderObject.GetEndpointsForSelection(_Selection);
            Rect editingRegion = Rect.FromPoints(RenderObject.LocalToGlobal(Dart: uiDefaultClass.Offset.Zero), RenderObject.LocalToGlobal(RenderObject.Size.BottomRight(Dart: uiDefaultClass.Offset.Zero)));
            bool isMultiline = endpoints.Last().Point.Dy - endpoints.First.Point.Dy > RenderObject.PreferredLineHeight / 2;
            double midX = isMultiline ? editingRegion.Width / 2 : (endpoints.First.Point.Dx + endpoints.Last().Point.Dx) / 2;
            Offset midpoint = new Offset(midX, endpoints[0].Point.Dy - RenderObject.PreferredLineHeight);
            return new FadeTransition(opacity: _ToolbarOpacity, child: new CompositedTransformFollower(link: ToolbarLayerLink, showWhenUnlinked: false, offset: -editingRegion.TopLeft, child: SelectionControls.BuildToolbar(context, editingRegion, RenderObject.PreferredLineHeight, midpoint, endpoints, SelectionDelegate)));
        }




        private void _HandleSelectionHandleChanged(FlutterSDK.Services.Textediting.TextSelection newSelection, FlutterSDK.Widgets.Textselection._TextSelectionHandlePosition position)
        {
            TextPosition textPosition = default(TextPosition);
            switch (position) { case _TextSelectionHandlePosition.Start: textPosition = newSelection.Base; break; case _TextSelectionHandlePosition.End: textPosition = newSelection.Extent; break; }
            SelectionDelegate.TextEditingValue = _Value.CopyWith(selection: newSelection, composing: Dart:uiDefaultClass.TextRange.Empty);
            SelectionDelegate.BringIntoView(textPosition);
        }



        #endregion
    }


    /// <Summary>
    /// This widget represents a single draggable text selection handle.
    /// </Summary>
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
            this.DragStartBehavior = dragStartBehavior;
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

        public new FlutterSDK.Widgets.Textselection._TextSelectionHandleOverlayState CreateState() => new _TextSelectionHandleOverlayState();


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

        public new void InitState()
        {
            base.InitState();
            _Controller = new AnimationController(duration: TextselectionDefaultClass.TextSelectionOverlay.FadeDuration, vsync: this);
            _HandleVisibilityChanged();
            Widget._Visibility.AddListener(_HandleVisibilityChanged);
        }




        private void _HandleVisibilityChanged()
        {
            if (Widget._Visibility.Value)
            {
                _Controller.Forward();
            }
            else
            {
                _Controller.Reverse();
            }

        }




        public new void DidUpdateWidget(FlutterSDK.Widgets.Textselection._TextSelectionHandleOverlay oldWidget)
        {
            base.DidUpdateWidget(oldWidget);
            oldWidget._Visibility.RemoveListener(_HandleVisibilityChanged);
            _HandleVisibilityChanged();
            Widget._Visibility.AddListener(_HandleVisibilityChanged);
        }




        public new void Dispose()
        {
            Widget._Visibility.RemoveListener(_HandleVisibilityChanged);
            _Controller.Dispose();
            base.Dispose();
        }




        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details)
        {
            Size handleSize = Widget.SelectionControls.GetHandleSize(Widget.RenderObject.PreferredLineHeight);
            _DragPosition = details.GlobalPosition + new Offset(0.0, -handleSize.Height);
        }




        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {
            _DragPosition += details.Delta;
            TextPosition position = Widget.RenderObject.GetPositionForPoint(_DragPosition);
            if (Widget.Selection.IsCollapsed)
            {
                Widget.OnSelectionHandleChanged(TextSelection.FromPosition(position));
                return;
            }

            TextSelection newSelection = default(TextSelection);
            switch (Widget.Position) { case _TextSelectionHandlePosition.Start: newSelection = new TextSelection(baseOffset: position.Offset, extentOffset: Widget.Selection.ExtentOffset); break; case _TextSelectionHandlePosition.End: newSelection = new TextSelection(baseOffset: Widget.Selection.BaseOffset, extentOffset: position.Offset); break; }
            if (newSelection.BaseOffset >= newSelection.ExtentOffset) return;
            Widget.OnSelectionHandleChanged(newSelection);
        }




        private void _HandleTap()
        {
            if (Widget.OnSelectionHandleTapped != null) Widget.OnSelectionHandleTapped();
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            LayerLink layerLink = default(LayerLink);
            TextSelectionHandleType type = default(TextSelectionHandleType);
            switch (Widget.Position) { case _TextSelectionHandlePosition.Start: layerLink = Widget.StartHandleLayerLink; type = _ChooseType(Widget.RenderObject.TextDirection, TextSelectionHandleType.Left, TextSelectionHandleType.Right); break; case _TextSelectionHandlePosition.End: layerLink = Widget.EndHandleLayerLink; type = _ChooseType(Widget.RenderObject.TextDirection, TextSelectionHandleType.Right, TextSelectionHandleType.Left); break; }
            Offset handleAnchor = Widget.SelectionControls.GetHandleAnchor(type, Widget.RenderObject.PreferredLineHeight);
            Size handleSize = Widget.SelectionControls.GetHandleSize(Widget.RenderObject.PreferredLineHeight);
            Rect handleRect = Rect.FromLTWH(-handleAnchor.Dx, -handleAnchor.Dy, handleSize.Width, handleSize.Height);
            Rect interactiveRect = handleRect.ExpandToInclude(Rect.FromCircle(center: handleRect.Center, radius: ConstantsDefaultClass.KMinInteractiveDimension / 2));
            RelativeRect padding = RelativeRect.FromLTRB(Math.Dart:mathDefaultClass.Max((interactiveRect.Width - handleRect.Width) / 2, 0), Math.Dart:mathDefaultClass.Max((interactiveRect.Height - handleRect.Height) / 2, 0), Math.Dart:mathDefaultClass.Max((interactiveRect.Width - handleRect.Width) / 2, 0), Math.Dart:mathDefaultClass.Max((interactiveRect.Height - handleRect.Height) / 2, 0));
            return new CompositedTransformFollower(link: layerLink, offset: interactiveRect.TopLeft, showWhenUnlinked: false, child: new FadeTransition(opacity: _Opacity, child: new Container(alignment: AlignmentDefaultClass.Alignment.TopLeft, width: interactiveRect.Width, height: interactiveRect.Height, child: new GestureDetector(behavior: HitTestBehavior.Translucent, dragStartBehavior: Widget.DragStartBehavior, onPanStart: _HandleDragStart, onPanUpdate: _HandleDragUpdate, onTap: _HandleTap, child: new Padding(padding: EdgeInsets.Only(left: padding.Left, top: padding.Top, right: padding.Right, bottom: padding.Bottom), child: Widget.SelectionControls.BuildHandle(context, type, Widget.RenderObject.PreferredLineHeight))))));
        }




        private FlutterSDK.Widgets.Textselection.TextSelectionHandleType _ChooseType(TextDirection textDirection, FlutterSDK.Widgets.Textselection.TextSelectionHandleType ltrType, FlutterSDK.Widgets.Textselection.TextSelectionHandleType rtlType)
        {
            if (Widget.Selection.IsCollapsed) return TextSelectionHandleType.Collapsed;

            switch (textDirection) { case TextDirection.Ltr: return ltrType; case TextDirection.Rtl: return rtlType; }
            return null;
        }



        #endregion
    }


    /// <Summary>
    /// Builds a [TextSelectionGestureDetector] to wrap an [EditableText].
    ///
    /// The class implements sensible defaults for many user interactions
    /// with an [EditableText] (see the documentation of the various gesture handler
    /// methods, e.g. [onTapDown], [onFrocePress], etc.). Subclasses of
    /// [EditableTextSelectionHandlesProvider] can change the behavior performed in
    /// responds to these gesture events by overriding the corresponding handler
    /// methods of this class.
    ///
    /// The resulting [TextSelectionGestureDetector] to wrap an [EditableText] is
    /// obtained by calling [buildGestureDetector].
    ///
    /// See also:
    ///
    ///  * [TextField], which uses a subclass to implement the Material-specific
    ///    gesture logic of an [EditableText].
    ///  * [CupertinoTextField], which uses a subclass to implement the
    ///    Cupertino-specific gesture logic of an [EditableText].
    /// </Summary>
    public class TextSelectionGestureDetectorBuilder
    {
        #region constructors
        public TextSelectionGestureDetectorBuilder(FlutterSDK.Widgets.Textselection.TextSelectionGestureDetectorBuilderDelegate @delegate = default(FlutterSDK.Widgets.Textselection.TextSelectionGestureDetectorBuilderDelegate))
        : base()
        {
            this.@delegate = @delegate;
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

        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onTapDown].
        ///
        /// By default, it forwards the tap to [RenderEditable.handleTapDown] and sets
        /// [shouldShowSelectionToolbar] to true if the tap was initiated by a finger or stylus.
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onTapDown], which triggers this callback.
        /// </Summary>
        public virtual void OnTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details)
        {
            RenderEditable.HandleTapDown(details);
            PointerDeviceKind kind = details.Kind;
            _ShouldShowSelectionToolbar = kind == null || kind == PointerDeviceKind.Touch || kind == PointerDeviceKind.Stylus;
        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onForcePressStart].
        ///
        /// By default, it selects the word at the position of the force press,
        /// if selection is enabled.
        ///
        /// This callback is only applicable when force press is enabled.
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onForcePressStart], which triggers this
        ///    callback.
        /// </Summary>
        public virtual void OnForcePressStart(FlutterSDK.Gestures.Forcepress.ForcePressDetails details)
        {

            _ShouldShowSelectionToolbar = true;
            if (Delegate.SelectionEnabled)
            {
                RenderEditable.SelectWordsInRange(from: details.GlobalPosition, cause: SelectionChangedCause.ForcePress);
            }

        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onForcePressEnd].
        ///
        /// By default, it selects words in the range specified in [details] and shows
        /// toolbar if it is necessary.
        ///
        /// This callback is only applicable when force press is enabled.
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onForcePressEnd], which triggers this
        ///    callback.
        /// </Summary>
        public virtual void OnForcePressEnd(FlutterSDK.Gestures.Forcepress.ForcePressDetails details)
        {

            RenderEditable.SelectWordsInRange(from: details.GlobalPosition, cause: SelectionChangedCause.ForcePress);
            if (ShouldShowSelectionToolbar) EditableText.ShowToolbar();
        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onSingleTapUp].
        ///
        /// By default, it selects word edge if selection is enabled.
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onSingleTapUp], which triggers
        ///    this callback.
        /// </Summary>
        public virtual void OnSingleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details)
        {
            if (Delegate.SelectionEnabled)
            {
                RenderEditable.SelectWordEdge(cause: SelectionChangedCause.Tap);
            }

        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onSingleTapCancel].
        ///
        /// By default, it services as place holder to enable subclass override.
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onSingleTapCancel], which triggers
        ///    this callback.
        /// </Summary>
        public virtual void OnSingleTapCancel()
        {
        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onSingleLongTapStart].
        ///
        /// By default, it selects text position specified in [details] if selection
        /// is enabled.
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onSingleLongTapStart], which triggers
        ///    this callback.
        /// </Summary>
        public virtual void OnSingleLongTapStart(FlutterSDK.Gestures.Longpress.LongPressStartDetails details)
        {
            if (Delegate.SelectionEnabled)
            {
                RenderEditable.SelectPositionAt(from: details.GlobalPosition, cause: SelectionChangedCause.LongPress);
            }

        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onSingleLongTapMoveUpdate].
        ///
        /// By default, it updates the selection location specified in [details] if
        /// selection is enabled.
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onSingleLongTapMoveUpdate], which
        ///    triggers this callback.
        /// </Summary>
        public virtual void OnSingleLongTapMoveUpdate(FlutterSDK.Gestures.Longpress.LongPressMoveUpdateDetails details)
        {
            if (Delegate.SelectionEnabled)
            {
                RenderEditable.SelectPositionAt(from: details.GlobalPosition, cause: SelectionChangedCause.LongPress);
            }

        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onSingleLongTapEnd].
        ///
        /// By default, it shows toolbar if necessary.
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onSingleLongTapEnd], which triggers this
        ///    callback.
        /// </Summary>
        public virtual void OnSingleLongTapEnd(FlutterSDK.Gestures.Longpress.LongPressEndDetails details)
        {
            if (ShouldShowSelectionToolbar) EditableText.ShowToolbar();
        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onDoubleTapDown].
        ///
        /// By default, it selects a word through [renderEditable.selectWord] if
        /// selectionEnabled and shows toolbar if necessary.
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onDoubleTapDown], which triggers this
        ///    callback.
        /// </Summary>
        public virtual void OnDoubleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details)
        {
            if (Delegate.SelectionEnabled)
            {
                RenderEditable.SelectWord(cause: SelectionChangedCause.Tap);
                if (ShouldShowSelectionToolbar) EditableText.ShowToolbar();
            }

        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onDragSelectionStart].
        ///
        /// By default, it selects a text position specified in [details].
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onDragSelectionStart], which triggers
        ///    this callback.
        /// </Summary>
        public virtual void OnDragSelectionStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details)
        {
            RenderEditable.SelectPositionAt(from: details.GlobalPosition, cause: SelectionChangedCause.Drag);
        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onDragSelectionUpdate].
        ///
        /// By default, it updates the selection location specified in [details].
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onDragSelectionUpdate], which triggers
        ///    this callback./lib/src/material/text_field.dart
        /// </Summary>
        public virtual void OnDragSelectionUpdate(FlutterSDK.Gestures.Dragdetails.DragStartDetails startDetails, FlutterSDK.Gestures.Dragdetails.DragUpdateDetails updateDetails)
        {
            RenderEditable.SelectPositionAt(from: startDetails.GlobalPosition, to: updateDetails.GlobalPosition, cause: SelectionChangedCause.Drag);
        }




        /// <Summary>
        /// Handler for [TextSelectionGestureDetector.onDragSelectionEnd].
        ///
        /// By default, it services as place holder to enable subclass override.
        ///
        /// See also:
        ///
        ///  * [TextSelectionGestureDetector.onDragSelectionEnd], which triggers this
        ///    callback.
        /// </Summary>
        public virtual void OnDragSelectionEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {
        }




        /// <Summary>
        /// Returns a [TextSelectionGestureDetector] configured with the handlers
        /// provided by this builder.
        ///
        /// The [child] or its subtree should contain [EditableText].
        /// </Summary>
        public virtual FlutterSDK.Widgets.Framework.Widget BuildGestureDetector(FlutterSDK.Foundation.Key.Key key = default(FlutterSDK.Foundation.Key.Key), FlutterSDK.Rendering.Proxybox.HitTestBehavior behavior = default(FlutterSDK.Rendering.Proxybox.HitTestBehavior), FlutterSDK.Widgets.Framework.Widget child = default(FlutterSDK.Widgets.Framework.Widget))
        {
            return new TextSelectionGestureDetector(key: key, onTapDown: OnTapDown, onForcePressStart: Delegate.ForcePressEnabled ? OnForcePressStart : null, onForcePressEnd: Delegate.ForcePressEnabled ? OnForcePressEnd : null, onSingleTapUp: OnSingleTapUp, onSingleTapCancel: OnSingleTapCancel, onSingleLongTapStart: OnSingleLongTapStart, onSingleLongTapMoveUpdate: OnSingleLongTapMoveUpdate, onSingleLongTapEnd: OnSingleLongTapEnd, onDoubleTapDown: OnDoubleTapDown, onDragSelectionStart: OnDragSelectionStart, onDragSelectionUpdate: OnDragSelectionUpdate, onDragSelectionEnd: OnDragSelectionEnd, behavior: behavior, child: child);
        }



        #endregion
    }


    /// <Summary>
    /// A gesture detector to respond to non-exclusive event chains for a text field.
    ///
    /// An ordinary [GestureDetector] configured to handle events like tap and
    /// double tap will only recognize one or the other. This widget detects both:
    /// first the tap and then, if another tap down occurs within a time limit, the
    /// double tap.
    ///
    /// See also:
    ///
    ///  * [TextField], a Material text field which uses this gesture detector.
    ///  * [CupertinoTextField], a Cupertino text field which uses this gesture
    ///    detector.
    /// </Summary>
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
            this.Child = child;
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

        public new FlutterSDK.Widgets.Framework.State<FlutterSDK.Widgets.Framework.StatefulWidget> CreateState() => new _TextSelectionGestureDetectorState();


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

        public new void Dispose()
        {
            _DoubleTapTimer?.Cancel();
            _DragUpdateThrottleTimer?.Cancel();
            base.Dispose();
        }




        private void _HandleTapDown(FlutterSDK.Gestures.Tap.TapDownDetails details)
        {
            if (Widget.OnTapDown != null)
            {
                Widget.OnTapDown(details);
            }

            if (_DoubleTapTimer != null && _IsWithinDoubleTapTolerance(details.GlobalPosition))
            {
                if (Widget.OnDoubleTapDown != null)
                {
                    Widget.OnDoubleTapDown(details);
                }

                _DoubleTapTimer.Cancel();
                _DoubleTapTimeout();
                _IsDoubleTap = true;
            }

        }




        private void _HandleTapUp(FlutterSDK.Gestures.Tap.TapUpDetails details)
        {
            if (!_IsDoubleTap)
            {
                if (Widget.OnSingleTapUp != null)
                {
                    Widget.OnSingleTapUp(details);
                }

                _LastTapOffset = details.GlobalPosition;
                _DoubleTapTimer = new Timer(ConstantsDefaultClass.KDoubleTapTimeout, _DoubleTapTimeout);
            }

            _IsDoubleTap = false;
        }




        private void _HandleTapCancel()
        {
            if (Widget.OnSingleTapCancel != null)
            {
                Widget.OnSingleTapCancel();
            }

        }




        private void _HandleDragStart(FlutterSDK.Gestures.Dragdetails.DragStartDetails details)
        {

            _LastDragStartDetails = details;
            if (Widget.OnDragSelectionStart != null)
            {
                Widget.OnDragSelectionStart(details);
            }

        }




        private void _HandleDragUpdate(FlutterSDK.Gestures.Dragdetails.DragUpdateDetails details)
        {
            _LastDragUpdateDetails = details;
            _DragUpdateThrottleTimer = (_DragUpdateThrottleTimer == null ? new Timer(TextselectionDefaultClass._KDragSelectionUpdateThrottle, _HandleDragUpdateThrottled) : _DragUpdateThrottleTimer);
        }




        /// <Summary>
        /// Drag updates are being throttled to avoid excessive text layouts in text
        /// fields. The frequency of invocations is controlled by the constant
        /// [_kDragSelectionUpdateThrottle].
        ///
        /// Once the drag gesture ends, any pending drag update will be fired
        /// immediately. See [_handleDragEnd].
        /// </Summary>
        private void _HandleDragUpdateThrottled()
        {


            if (Widget.OnDragSelectionUpdate != null)
            {
                Widget.OnDragSelectionUpdate(_LastDragStartDetails, _LastDragUpdateDetails);
            }

            _DragUpdateThrottleTimer = null;
            _LastDragUpdateDetails = null;
        }




        private void _HandleDragEnd(FlutterSDK.Gestures.Dragdetails.DragEndDetails details)
        {

            if (_DragUpdateThrottleTimer != null)
            {
                _DragUpdateThrottleTimer.Cancel();
                _HandleDragUpdateThrottled();
            }

            if (Widget.OnDragSelectionEnd != null)
            {
                Widget.OnDragSelectionEnd(details);
            }

            _DragUpdateThrottleTimer = null;
            _LastDragStartDetails = null;
            _LastDragUpdateDetails = null;
        }




        private void _ForcePressStarted(FlutterSDK.Gestures.Forcepress.ForcePressDetails details)
        {
            _DoubleTapTimer?.Cancel();
            _DoubleTapTimer = null;
            if (Widget.OnForcePressStart != null) Widget.OnForcePressStart(details);
        }




        private void _ForcePressEnded(FlutterSDK.Gestures.Forcepress.ForcePressDetails details)
        {
            if (Widget.OnForcePressEnd != null) Widget.OnForcePressEnd(details);
        }




        private void _HandleLongPressStart(FlutterSDK.Gestures.Longpress.LongPressStartDetails details)
        {
            if (!_IsDoubleTap && Widget.OnSingleLongTapStart != null)
            {
                Widget.OnSingleLongTapStart(details);
            }

        }




        private void _HandleLongPressMoveUpdate(FlutterSDK.Gestures.Longpress.LongPressMoveUpdateDetails details)
        {
            if (!_IsDoubleTap && Widget.OnSingleLongTapMoveUpdate != null)
            {
                Widget.OnSingleLongTapMoveUpdate(details);
            }

        }




        private void _HandleLongPressEnd(FlutterSDK.Gestures.Longpress.LongPressEndDetails details)
        {
            if (!_IsDoubleTap && Widget.OnSingleLongTapEnd != null)
            {
                Widget.OnSingleLongTapEnd(details);
            }

            _IsDoubleTap = false;
        }




        private void _DoubleTapTimeout()
        {
            _DoubleTapTimer = null;
            _LastTapOffset = null;
        }




        private bool _IsWithinDoubleTapTolerance(FlutterBinding.UI.Offset secondTapOffset)
        {

            if (_LastTapOffset == null)
            {
                return false;
            }

            Offset difference = secondTapOffset - _LastTapOffset;
            return difference.Distance <= ConstantsDefaultClass.KDoubleTapSlop;
        }




        public new FlutterSDK.Widgets.Framework.Widget Build(FlutterSDK.Widgets.Framework.BuildContext context)
        {
            Dictionary<Type, GestureRecognizerFactory> gestures = new Dictionary<Type, GestureRecognizerFactory> { };
            gestures[TextselectionDefaultClass._TransparentTapGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<_TransparentTapGestureRecognizer>(() => =>new _TransparentTapGestureRecognizer(debugOwner: this), (_TransparentTapGestureRecognizer instance) =>
            {
                ..OnTapDown = _HandleTapDown..OnTapUp = _HandleTapUp..OnTapCancel = _HandleTapCancel;
            }
            );
            if (Widget.OnSingleLongTapStart != null || Widget.OnSingleLongTapMoveUpdate != null || Widget.OnSingleLongTapEnd != null)
            {
                gestures[LongpressDefaultClass.LongPressGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<LongPressGestureRecognizer>(() => =>new LongPressGestureRecognizer(debugOwner: this, kind: PointerDeviceKind.Touch), (LongPressGestureRecognizer instance) =>
                {
                    ..OnLongPressStart = _HandleLongPressStart..OnLongPressMoveUpdate = _HandleLongPressMoveUpdate..OnLongPressEnd = _HandleLongPressEnd;
                }
                );
            }

            if (Widget.OnDragSelectionStart != null || Widget.OnDragSelectionUpdate != null || Widget.OnDragSelectionEnd != null)
            {
                gestures[MonodragDefaultClass.HorizontalDragGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<HorizontalDragGestureRecognizer>(() => =>new HorizontalDragGestureRecognizer(debugOwner: this, kind: PointerDeviceKind.Mouse), (HorizontalDragGestureRecognizer instance) =>
                {
                    ..DragStartBehavior = DragStartBehavior.Down..OnStart = _HandleDragStart..OnUpdate = _HandleDragUpdate..OnEnd = _HandleDragEnd;
                }
                );
            }

            if (Widget.OnForcePressStart != null || Widget.OnForcePressEnd != null)
            {
                gestures[ForcepressDefaultClass.ForcePressGestureRecognizer] = new GestureRecognizerFactoryWithHandlers<ForcePressGestureRecognizer>(() => =>new ForcePressGestureRecognizer(debugOwner: this), (ForcePressGestureRecognizer instance) =>
                {
                    ..OnStart = Widget.OnForcePressStart != null ? _ForcePressStarted : null..OnEnd = Widget.OnForcePressEnd != null ? _ForcePressEnded : null;
                }
                );
            }

            return new RawGestureDetector(gestures: gestures, excludeFromSemantics: true, behavior: Widget.Behavior, child: Widget.Child);
        }



        #endregion
    }


    public class _TransparentTapGestureRecognizer : FlutterSDK.Gestures.Tap.TapGestureRecognizer
    {
        #region constructors
        public _TransparentTapGestureRecognizer(@Object debugOwner = default(@Object))
        : base(debugOwner: debugOwner)
        {

        }
        #endregion

        #region fields
        #endregion

        #region methods

        public new void RejectGesture(int pointer)
        {
            if (State == GestureRecognizerState.Ready)
            {
                AcceptGesture(pointer);
            }
            else
            {
                base.RejectGesture(pointer);
            }

        }



        #endregion
    }


    /// <Summary>
    /// Which type of selection handle to be displayed.
    ///
    /// With mixed-direction text, both handles may be the same type. Examples:
    ///
    /// * LTR text: 'the &lt;quick brown&gt; fox':
    ///
    ///   The '&lt;' is drawn with the [left] type, the '&gt;' with the [right]
    ///
    /// * RTL text: 'XOF &lt;NWORB KCIUQ&gt; EHT':
    ///
    ///   Same as above.
    ///
    /// * mixed text: '&lt;the NWOR&lt;B KCIUQ fox'
    ///
    ///   Here 'the QUICK B' is selected, but 'QUICK BROWN' is RTL. Both are drawn
    ///   with the [left] type.
    ///
    /// See also:
    ///
    ///  * [TextDirection], which discusses left-to-right and right-to-left text in
    ///    more detail.
    /// </Summary>
    public enum TextSelectionHandleType
    {

        /// <Summary>
        /// The selection handle is to the left of the selection end point.
        /// </Summary>
        Left,
        /// <Summary>
        /// The selection handle is to the right of the selection end point.
        /// </Summary>
        Right,
        /// <Summary>
        /// The start and end of the selection are co-incident at this point.
        /// </Summary>
        Collapsed,
    }


    /// <Summary>
    /// The text position that a give selection handle manipulates. Dragging the
    /// [start] handle always moves the [start]/[baseOffset] of the selection.
    /// </Summary>
    public enum _TextSelectionHandlePosition
    {

        Start,
        End,
    }

}
