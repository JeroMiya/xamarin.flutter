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
namespace FlutterSDK.Services.Textformatter
{
    /// <Summary>
    /// Function signature expected for creating custom [TextInputFormatter]
    /// shorthands via [TextInputFormatter.withFunction];
    /// </Summary>
    public delegate FlutterSDK.Services.Textinput.TextEditingValue TextInputFormatFunction(FlutterSDK.Services.Textinput.TextEditingValue oldValue, FlutterSDK.Services.Textinput.TextEditingValue newValue);
    internal static class TextformatterDefaultClass
    {
        internal static FlutterSDK.Services.Textinput.TextEditingValue _SelectionAwareTextManipulation(FlutterSDK.Services.Textinput.TextEditingValue value, Func<String, string> substringManipulation)
        {
            int selectionStartIndex = value.Selection.Start;
            int selectionEndIndex = value.Selection.End;
            string manipulatedText = default(string);
            TextSelection manipulatedSelection = default(TextSelection);
            if (selectionStartIndex < 0 || selectionEndIndex < 0)
            {
                manipulatedText = substringManipulation(value.Text);
            }
            else
            {
                string beforeSelection = substringManipulation(value.Text.Substring(0, selectionStartIndex));
                string inSelection = substringManipulation(value.Text.Substring(selectionStartIndex, selectionEndIndex));
                string afterSelection = substringManipulation(value.Text.Substring(selectionEndIndex));
                manipulatedText = beforeSelection + inSelection + afterSelection;
                if (value.Selection.BaseOffset > value.Selection.ExtentOffset)
                {
                    manipulatedSelection = value.Selection.CopyWith(baseOffset: beforeSelection.Length + inSelection.Length, extentOffset: beforeSelection.Length);
                }
                else
                {
                    manipulatedSelection = value.Selection.CopyWith(baseOffset: beforeSelection.Length, extentOffset: beforeSelection.Length + inSelection.Length);
                }

            }

            return new TextEditingValue(text: manipulatedText, selection: manipulatedSelection ?? TextSelection.Collapsed(offset: -1), composing: manipulatedText == value.Text ? value.Composing : Dart.UiDefaultClass.TextRange.Empty);
        }



    }

    public interface ITextInputFormatter { }

    public class TextInputFormatter
    {

        /// <Summary>
        /// Called when text is being typed or cut/copy/pasted in the [EditableText].
        ///
        /// You can override the resulting text based on the previous text value and
        /// the incoming new text value.
        ///
        /// When formatters are chained, `oldValue` reflects the initial value of
        /// [TextEditingValue] at the beginning of the chain.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextEditingValue FormatEditUpdate(FlutterSDK.Services.Textinput.TextEditingValue oldValue, FlutterSDK.Services.Textinput.TextEditingValue newValue)
        {
            return default(TextEditingValue);
        }


        /// <Summary>
        /// A shorthand to creating a custom [TextInputFormatter] which formats
        /// incoming text input changes with the given function.
        /// </Summary>
        public virtual FlutterSDK.Services.Textformatter.TextInputFormatter WithFunction(FlutterSDK.Services.Textformatter.TextInputFormatFunction formatFunction)
        {
            return new _SimpleTextInputFormatter(formatFunction);
        }



    }
    public static class TextInputFormatterMixin
    {
        static System.Runtime.CompilerServices.ConditionalWeakTable<ITextInputFormatter, TextInputFormatter> _table = new System.Runtime.CompilerServices.ConditionalWeakTable<ITextInputFormatter, TextInputFormatter>();
        static TextInputFormatter GetOrCreate(ITextInputFormatter instance)
        {
            if (!_table.TryGetValue(instance, out var value))
            {
                value = new TextInputFormatter();
                _table.Add(instance, value);
            }
            return (TextInputFormatter)value;
        }
        public static FlutterSDK.Services.Textinput.TextEditingValue FormatEditUpdate(this ITextInputFormatter instance, FlutterSDK.Services.Textinput.TextEditingValue oldValue, FlutterSDK.Services.Textinput.TextEditingValue newValue) => GetOrCreate(instance).FormatEditUpdate(oldValue, newValue);
        public static FlutterSDK.Services.Textformatter.TextInputFormatter WithFunction(this ITextInputFormatter instance, FlutterSDK.Services.Textformatter.TextInputFormatFunction formatFunction) => GetOrCreate(instance).WithFunction(formatFunction);
    }


    /// <Summary>
    /// Wiring for [TextInputFormatter.withFunction].
    /// </Summary>
    public class _SimpleTextInputFormatter : FlutterSDK.Services.Textformatter.TextInputFormatter
    {
        public _SimpleTextInputFormatter(FlutterSDK.Services.Textformatter.TextInputFormatFunction formatFunction)
        : base()
        {
            this.FormatFunction = formatFunction;
        }
        public virtual FlutterSDK.Services.Textformatter.TextInputFormatFunction FormatFunction { get; set; }

        public new FlutterSDK.Services.Textinput.TextEditingValue FormatEditUpdate(FlutterSDK.Services.Textinput.TextEditingValue oldValue, FlutterSDK.Services.Textinput.TextEditingValue newValue)
        {
            return FormatFunction(oldValue, newValue);
        }



    }


    /// <Summary>
    /// A [TextInputFormatter] that prevents the insertion of blacklisted
    /// characters patterns.
    ///
    /// Instances of blacklisted characters found in the new [TextEditingValue]s
    /// will be replaced with the [replacementString] which defaults to the empty
    /// string.
    ///
    /// Since this formatter only removes characters from the text, it attempts to
    /// preserve the existing [TextEditingValue.selection] to values it would now
    /// fall at with the removed characters.
    ///
    /// See also:
    ///
    ///  * [WhitelistingTextInputFormatter], which uses a whitelist instead of a
    ///    blacklist.
    /// </Summary>
    public class BlacklistingTextInputFormatter : FlutterSDK.Services.Textformatter.TextInputFormatter
    {
        /// <Summary>
        /// Creates a formatter that prevents the insertion of blacklisted characters patterns.
        ///
        /// The [blacklistedPattern] must not be null.
        /// </Summary>
        public BlacklistingTextInputFormatter(Pattern blacklistedPattern, string replacementString = default(string))
        : base()
        {
            this.BlacklistedPattern = blacklistedPattern;
            this.ReplacementString = replacementString;
        }
        /// <Summary>
        /// A [Pattern] to match and replace incoming [TextEditingValue]s.
        /// </Summary>
        public virtual Pattern BlacklistedPattern { get; set; }
        /// <Summary>
        /// String used to replace found patterns.
        /// </Summary>
        public virtual string ReplacementString { get; set; }
        /// <Summary>
        /// A [BlacklistingTextInputFormatter] that forces input to be a single line.
        /// </Summary>
        public virtual FlutterSDK.Services.Textformatter.BlacklistingTextInputFormatter SingleLineFormatter { get; set; }

        public new FlutterSDK.Services.Textinput.TextEditingValue FormatEditUpdate(FlutterSDK.Services.Textinput.TextEditingValue oldValue, FlutterSDK.Services.Textinput.TextEditingValue newValue)
        {
            return TextformatterDefaultClass._SelectionAwareTextManipulation(newValue, (string substring) =>
            {
                return substring.ReplaceAll(BlacklistedPattern, ReplacementString);
            }
            );
        }



    }


    /// <Summary>
    /// A [TextInputFormatter] that prevents the insertion of more characters
    /// (currently defined as Unicode scalar values) than allowed.
    ///
    /// Since this formatter only prevents new characters from being added to the
    /// text, it preserves the existing [TextEditingValue.selection].
    ///
    ///  * [maxLength], which discusses the precise meaning of "number of
    ///    characters" and how it may differ from the intuitive meaning.
    /// </Summary>
    public class LengthLimitingTextInputFormatter : FlutterSDK.Services.Textformatter.TextInputFormatter
    {
        /// <Summary>
        /// Creates a formatter that prevents the insertion of more characters than a
        /// limit.
        ///
        /// The [maxLength] must be null, -1 or greater than zero. If it is null or -1
        /// then no limit is enforced.
        /// </Summary>
        public LengthLimitingTextInputFormatter(int maxLength)
        : base()
        {
            this.MaxLength = maxLength;
        }
        /// <Summary>
        /// The limit on the number of characters (i.e. Unicode scalar values) this formatter
        /// will allow.
        ///
        /// The value must be null or greater than zero. If it is null, then no limit
        /// is enforced.
        ///
        /// This formatter does not currently count Unicode grapheme clusters (i.e.
        /// characters visible to the user), it counts Unicode scalar values, which leaves
        /// out a number of useful possible characters (like many emoji and composed
        /// characters), so this will be inaccurate in the presence of those
        /// characters. If you expect to encounter these kinds of characters, be
        /// generous in the maxLength used.
        ///
        /// For instance, the character "ö" can be represented as '\u{006F}\u{0308}',
        /// which is the letter "o" followed by a composed diaeresis "¨", or it can
        /// be represented as '\u{00F6}', which is the Unicode scalar value "LATIN
        /// SMALL LETTER O WITH DIAERESIS". In the first case, the text field will
        /// count two characters, and the second case will be counted as one
        /// character, even though the user can see no difference in the input.
        ///
        /// Similarly, some emoji are represented by multiple scalar values. The
        /// Unicode "THUMBS UP SIGN + MEDIUM SKIN TONE MODIFIER", "👍🏽", should be
        /// counted as a single character, but because it is a combination of two
        /// Unicode scalar values, '\u{1F44D}\u{1F3FD}', it is counted as two
        /// characters.
        /// </Summary>
        public virtual int MaxLength { get; set; }

        /// <Summary>
        /// Truncate the given TextEditingValue to maxLength runes.
        /// </Summary>
        public virtual FlutterSDK.Services.Textinput.TextEditingValue Truncate(FlutterSDK.Services.Textinput.TextEditingValue value, int maxLength)
        {
            TextSelection newSelection = value.Selection.CopyWith(baseOffset: Dart.Math.MathDefaultClass.Min(value.Selection.Start, maxLength), extentOffset: Dart.Math.MathDefaultClass.Min(value.Selection.End, maxLength));
            RuneIterator iterator = new RuneIterator(value.Text);
            if (iterator.MoveNext()) for (int count = 0; count < maxLength; ++count) if (!iterator.MoveNext()) break;
            string truncated = value.Text.Substring(0, iterator.RawIndex);
            return new TextEditingValue(text: truncated, selection: newSelection, composing: Dart.UiDefaultClass.TextRange.Empty);
        }




        public new FlutterSDK.Services.Textinput.TextEditingValue FormatEditUpdate(FlutterSDK.Services.Textinput.TextEditingValue oldValue, FlutterSDK.Services.Textinput.TextEditingValue newValue)
        {
            if (MaxLength != null && MaxLength > 0 && newValue.Text.Runes.Length > MaxLength)
            {
                if (oldValue.Text.Runes.Length == MaxLength)
                {
                    return oldValue;
                }

                return Truncate(newValue, MaxLength);
            }

            return newValue;
        }



    }


    /// <Summary>
    /// A [TextInputFormatter] that allows only the insertion of whitelisted
    /// characters patterns.
    ///
    /// Since this formatter only removes characters from the text, it attempts to
    /// preserve the existing [TextEditingValue.selection] to values it would now
    /// fall at with the removed characters.
    ///
    /// See also:
    ///
    ///  * [BlacklistingTextInputFormatter], which uses a blacklist instead of a
    ///    whitelist.
    /// </Summary>
    public class WhitelistingTextInputFormatter : FlutterSDK.Services.Textformatter.TextInputFormatter
    {
        /// <Summary>
        /// Creates a formatter that allows only the insertion of whitelisted characters patterns.
        ///
        /// The [whitelistedPattern] must not be null.
        /// </Summary>
        public WhitelistingTextInputFormatter(Pattern whitelistedPattern)
        : base()
        {
            this.WhitelistedPattern = whitelistedPattern;
        }
        /// <Summary>
        /// A [Pattern] to extract all instances of allowed characters.
        ///
        /// [RegExp] with multiple groups is not supported.
        /// </Summary>
        public virtual Pattern WhitelistedPattern { get; set; }
        /// <Summary>
        /// A [WhitelistingTextInputFormatter] that takes in digits `[0-9]` only.
        /// </Summary>
        public virtual FlutterSDK.Services.Textformatter.WhitelistingTextInputFormatter DigitsOnly { get; set; }

        public new FlutterSDK.Services.Textinput.TextEditingValue FormatEditUpdate(FlutterSDK.Services.Textinput.TextEditingValue oldValue, FlutterSDK.Services.Textinput.TextEditingValue newValue)
        {
            return TextformatterDefaultClass._SelectionAwareTextManipulation(newValue, (string substring) =>
            {
                return WhitelistedPattern.AllMatches(substring).Map((Match match) => =>match.Group(0)).Join();
            }
            );
        }



    }

}
