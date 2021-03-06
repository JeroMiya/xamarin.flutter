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
namespace FlutterSDK.Foundation.Serialization
{
    internal static class SerializationDefaultClass
    {
    }

    /// <Summary>
    /// Write-only buffer for incrementally building a [ByteData] instance.
    ///
    /// A WriteBuffer instance can be used only once. Attempts to reuse will result
    /// in [NoSuchMethodError]s being thrown.
    ///
    /// The byte order used is [Endian.host] throughout.
    /// </Summary>
    public class WriteBuffer
    {
        /// <Summary>
        /// Creates an interface for incrementally building a [ByteData] instance.
        /// </Summary>
        public WriteBuffer()
        {

            _Buffer = Uint8Buffer();
            _EightBytes = new ByteData(8);
            _EightBytesAsList = _EightBytes.Buffer.AsUint8List();
        }


        internal virtual Uint8Buffer _Buffer { get; set; }
        internal virtual ByteData _EightBytes { get; set; }
        internal virtual Uint8List _EightBytesAsList { get; set; }

        /// <Summary>
        /// Write a Uint8 into the buffer.
        /// </Summary>
        public virtual void PutUint8(int @byte)
        {
            _Buffer.Add(@byte);
        }




        /// <Summary>
        /// Write a Uint16 into the buffer.
        /// </Summary>
        public virtual void PutUint16(int value, Endian endian = default(Endian))
        {
            _EightBytes.SetUint16(0, value, endian ?? Dart.TypeddataDefaultClass.Endian.Host);
            _Buffer.AddAll(_EightBytesAsList, 0, 2);
        }




        /// <Summary>
        /// Write a Uint32 into the buffer.
        /// </Summary>
        public virtual void PutUint32(int value, Endian endian = default(Endian))
        {
            _EightBytes.SetUint32(0, value, endian ?? Dart.TypeddataDefaultClass.Endian.Host);
            _Buffer.AddAll(_EightBytesAsList, 0, 4);
        }




        /// <Summary>
        /// Write an Int32 into the buffer.
        /// </Summary>
        public virtual void PutInt32(int value, Endian endian = default(Endian))
        {
            _EightBytes.SetInt32(0, value, endian ?? Dart.TypeddataDefaultClass.Endian.Host);
            _Buffer.AddAll(_EightBytesAsList, 0, 4);
        }




        /// <Summary>
        /// Write an Int64 into the buffer.
        /// </Summary>
        public virtual void PutInt64(int value, Endian endian = default(Endian))
        {
            _EightBytes.SetInt64(0, value, endian ?? Dart.TypeddataDefaultClass.Endian.Host);
            _Buffer.AddAll(_EightBytesAsList, 0, 8);
        }




        /// <Summary>
        /// Write an Float64 into the buffer.
        /// </Summary>
        public virtual void PutFloat64(double value, Endian endian = default(Endian))
        {
            _AlignTo(8);
            _EightBytes.SetFloat64(0, value, endian ?? Dart.TypeddataDefaultClass.Endian.Host);
            _Buffer.AddAll(_EightBytesAsList);
        }




        /// <Summary>
        /// Write all the values from a [Uint8List] into the buffer.
        /// </Summary>
        public virtual void PutUint8List(Uint8List list)
        {
            _Buffer.AddAll(list);
        }




        /// <Summary>
        /// Write all the values from an [Int32List] into the buffer.
        /// </Summary>
        public virtual void PutInt32List(List<uint> list)
        {
            _AlignTo(4);
            _Buffer.AddAll(list.Buffer.AsUint8List(list.OffsetInBytes, 4 * list.Count));
        }




        /// <Summary>
        /// Write all the values from an [Int64List] into the buffer.
        /// </Summary>
        public virtual void PutInt64List(Int64List list)
        {
            _AlignTo(8);
            _Buffer.AddAll(list.Buffer.AsUint8List(list.OffsetInBytes, 8 * list.Count));
        }




        /// <Summary>
        /// Write all the values from a [Float64List] into the buffer.
        /// </Summary>
        public virtual void PutFloat64List(List<float> list)
        {
            _AlignTo(8);
            _Buffer.AddAll(list.Buffer.AsUint8List(list.OffsetInBytes, 8 * list.Count));
        }




        private void _AlignTo(int alignment)
        {
            int mod = _Buffer.Length % alignment;
            if (mod != 0)
            {
                for (int i = 0; i < alignment - mod; i++) _Buffer.Add(0);
            }

        }




        /// <Summary>
        /// Finalize and return the written [ByteData].
        /// </Summary>
        public virtual ByteData Done()
        {
            ByteData result = _Buffer.Buffer.AsByteData(0, _Buffer.LengthInBytes);
            _Buffer = null;
            return result;
        }



    }


    /// <Summary>
    /// Read-only buffer for reading sequentially from a [ByteData] instance.
    ///
    /// The byte order used is [Endian.host] throughout.
    /// </Summary>
    public class ReadBuffer
    {
        /// <Summary>
        /// Creates a [ReadBuffer] for reading from the specified [data].
        /// </Summary>
        public ReadBuffer(ByteData data)
        : base()
        {
            this.Data = data;
        }
        /// <Summary>
        /// The underlying data being read.
        /// </Summary>
        public virtual ByteData Data { get; set; }
        /// <Summary>
        /// The position to read next.
        /// </Summary>
        internal virtual int _Position { get; set; }
        public virtual bool HasRemaining { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        /// <Summary>
        /// Reads a Uint8 from the buffer.
        /// </Summary>
        public virtual int GetUint8()
        {
            return Data.GetUint8(_Position++);
        }




        /// <Summary>
        /// Reads a Uint16 from the buffer.
        /// </Summary>
        public virtual int GetUint16(Endian endian = default(Endian))
        {
            int value = Data.GetUint16(_Position, endian ?? Dart.TypeddataDefaultClass.Endian.Host);
            _Position += 2;
            return value;
        }




        /// <Summary>
        /// Reads a Uint32 from the buffer.
        /// </Summary>
        public virtual int GetUint32(Endian endian = default(Endian))
        {
            int value = Data.GetUint32(_Position, endian ?? Dart.TypeddataDefaultClass.Endian.Host);
            _Position += 4;
            return value;
        }




        /// <Summary>
        /// Reads an Int32 from the buffer.
        /// </Summary>
        public virtual int GetInt32(Endian endian = default(Endian))
        {
            int value = Data.GetInt32(_Position, endian ?? Dart.TypeddataDefaultClass.Endian.Host);
            _Position += 4;
            return value;
        }




        /// <Summary>
        /// Reads an Int64 from the buffer.
        /// </Summary>
        public virtual int GetInt64(Endian endian = default(Endian))
        {
            int value = Data.GetInt64(_Position, endian ?? Dart.TypeddataDefaultClass.Endian.Host);
            _Position += 8;
            return value;
        }




        /// <Summary>
        /// Reads a Float64 from the buffer.
        /// </Summary>
        public virtual double GetFloat64(Endian endian = default(Endian))
        {
            _AlignTo(8);
            double value = Data.GetFloat64(_Position, endian ?? Dart.TypeddataDefaultClass.Endian.Host);
            _Position += 8;
            return value;
        }




        /// <Summary>
        /// Reads the given number of Uint8s from the buffer.
        /// </Summary>
        public virtual Uint8List GetUint8List(int length)
        {
            Uint8List list = Data.Buffer.AsUint8List(Data.OffsetInBytes + _Position, length);
            _Position += length;
            return list;
        }




        /// <Summary>
        /// Reads the given number of Int32s from the buffer.
        /// </Summary>
        public virtual List<uint> GetInt32List(int length)
        {
            _AlignTo(4);
            List<uint> list = Data.Buffer.AsInt32List(Data.OffsetInBytes + _Position, length);
            _Position += 4 * length;
            return list;
        }




        /// <Summary>
        /// Reads the given number of Int64s from the buffer.
        /// </Summary>
        public virtual Int64List GetInt64List(int length)
        {
            _AlignTo(8);
            Int64List list = Data.Buffer.AsInt64List(Data.OffsetInBytes + _Position, length);
            _Position += 8 * length;
            return list;
        }




        /// <Summary>
        /// Reads the given number of Float64s from the buffer.
        /// </Summary>
        public virtual List<float> GetFloat64List(int length)
        {
            _AlignTo(8);
            List<float> list = Data.Buffer.AsFloat64List(Data.OffsetInBytes + _Position, length);
            _Position += 8 * length;
            return list;
        }




        private void _AlignTo(int alignment)
        {
            int mod = _Position % alignment;
            if (mod != 0) _Position += alignment - mod;
        }



    }

}
