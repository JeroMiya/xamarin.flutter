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
using file:///C:/Users/JBell/source/repos/xamarin.flutter/flutter/lib/foundation.dart;
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
namespace FlutterSDK.Material.Animatedicons.Animatedicons
{
    public delegate object _UiPathFactory();
    public delegate T _Interpolator<T>(T a, T b, double progress);
    internal static class AnimatediconsDefaultClass
    {
        internal static T _Interpolate<T>(List<T> values, double progress, FlutterSDK.Material.Animatedicons.Animatedicons._Interpolator<T> interpolator)
        {
            throw new NotImplementedException();
        }

    }

    /// <Summary>
    /// Paths are being built by a set of commands e.g moveTo, lineTo, etc...
    ///
    /// _PathCommand instances represents such a command, and can apply it to
    /// a given Path.
    /// </Summary>
    internal interface I_PathCommand
    {
        void Apply(Path path, double progress);
    }


    /// <Summary>
    /// Shows an animated icon at a given animation [progress].
    ///
    /// The available icons are specified in [AnimatedIcons].
    ///
    /// {@youtube 560 315 https://www.youtube.com/watch?v=pJcbh8pbvJs}
    ///
    /// {@tool snippet}
    ///
    /// ```dart
    /// AnimatedIcon(
    ///   icon: AnimatedIcons.menu_arrow,
    ///   progress: controller,
    ///   semanticLabel: 'Show menu',
    /// )
    /// ```
    /// {@end-tool}
    ///
    /// </Summary>
    public class AnimatedIcon
    {
        #region constructors
        public AnimatedIcon(Key key = default(Key), AnimatedIconData icon = default(AnimatedIconData), Animation<double> progress = default(Animation<double>), Color color = default(Color), double size = default(double), string semanticLabel = default(string), TextDirection textDirection = default(TextDirection))
        : base(Key: key)
    
}
    #endregion

    #region fields
    public virtual object Progress { get; set; }
    public virtual Color Color { get; set; }
    public virtual double Size { get; set; }
    public virtual AnimatedIconData Icon { get; set; }
    public virtual string SemanticLabel { get; set; }
    public virtual TextDirection TextDirection { get; set; }
    internal virtual FlutterSDK.Material.Animatedicons.Animatedicons._UiPathFactory _PathFactory { get; set; }
    #endregion

    #region methods

    public Widget Build(BuildContext context)
    {
        _AnimatedIconData iconData = Icon as _AnimatedIconData;
        IconThemeData iconTheme = IconTheme.Of(context);
        double iconSize = size == default(double) ? iconTheme.size : size;
        TextDirection textDirection = this.TextDirection ?? Directionality.Of(context);
        double iconOpacity = iconTheme.Opacity;
        Color iconColor = Color ?? iconTheme.Color;
        if (iconOpacity != 1.0) iconColor = iconColor.WithOpacity(iconColor.Opacity * iconOpacity);
        return Semantics(Label: SemanticLabel, Child: CustomPaint(Size: Size(iconSize, iconSize), Painter: new _AnimatedIconPainter(paths: iconData.Paths, progress: Progress, color: iconColor, scale: iconSize / iconData.Size.Width, shouldMirror: textDirection == TextDirection.Rtl && iconData.MatchTextDirection, uiPathFactory: _PathFactory)));
    }



    #endregion
}


public class _AnimatedIconPainter
{
    #region constructors
    public _AnimatedIconPainter(List<FlutterSDK.Material.Animatedicons.Animatedicons._PathFrames> paths = default(List<FlutterSDK.Material.Animatedicons.Animatedicons._PathFrames>), Animation<double> progress = default(Animation<double>), Color color = default(Color), double scale = default(double), bool shouldMirror = default(bool), FlutterSDK.Material.Animatedicons.Animatedicons._UiPathFactory uiPathFactory = default(FlutterSDK.Material.Animatedicons.Animatedicons._UiPathFactory))
    : base(Repaint: progress)

}
#endregion

#region fields
public virtual List<FlutterSDK.Material.Animatedicons.Animatedicons._PathFrames> Paths { get; set; }
public virtual object Progress { get; set; }
public virtual Color Color { get; set; }
public virtual double Scale { get; set; }
public virtual bool ShouldMirror { get; set; }
public virtual FlutterSDK.Material.Animatedicons.Animatedicons._UiPathFactory UiPathFactory { get; set; }
public virtual object SemanticsBuilder { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
#endregion

#region methods

public void Paint(Canvas canvas, Size size)
{
    canvas.Scale(Scale, Scale);
    if (ShouldMirror)
    {
        canvas.Rotate(Math.Pi);
        canvas.Translate(-size.Width, -size.Height);
    }

    double clampedProgress = Progress.Value.Clamp(0.0, 1.0) as double;
    foreach (_PathFrames path in Paths) path.Paint(canvas, Color, UiPathFactory, clampedProgress);
}




public bool ShouldRepaint(FlutterSDK.Material.Animatedicons.Animatedicons._AnimatedIconPainter oldDelegate)
{
    return oldDelegate.Progress.Value != Progress.Value || oldDelegate.Color != Color || oldDelegate.Paths != Paths || oldDelegate.Scale != Scale || oldDelegate.UiPathFactory != UiPathFactory;
}




public bool HitTest(Offset position) => null;



public bool ShouldRebuildSemantics(CustomPainter oldDelegate) => false;


#endregion
}


public class _PathFrames
{
    #region constructors
    public _PathFrames(List<FlutterSDK.Material.Animatedicons.Animatedicons._PathCommand> commands = default(List<FlutterSDK.Material.Animatedicons.Animatedicons._PathCommand>), List<double> opacities = default(List<double>))

}
#endregion

#region fields
public virtual List<FlutterSDK.Material.Animatedicons.Animatedicons._PathCommand> Commands { get; set; }
public virtual List<double> Opacities { get; set; }
#endregion

#region methods

public virtual void Paint(Canvas canvas, Color color, FlutterSDK.Material.Animatedicons.Animatedicons._UiPathFactory uiPathFactory, double progress)
{
    double opacity = AnimatediconsDefaultClass._Interpolate(Opacities, progress, LerpDouble);
    Ui.Paint paint = Ui.Paint()..Style = PaintingStyle.Fill..Color = color.WithOpacity(color.Opacity * opacity);
    Ui.Path path = uiPathFactory();
    foreach (_PathCommand command in Commands) command.Apply(path, progress);
    canvas.DrawPath(path, paint);
}



#endregion
}


/// <Summary>
/// Paths are being built by a set of commands e.g moveTo, lineTo, etc...
///
/// _PathCommand instances represents such a command, and can apply it to
/// a given Path.
/// </Summary>
public class _PathCommand
{
    #region constructors
    public _PathCommand()

}
#endregion

#region fields
#endregion

#region methods

/// <Summary>
/// Applies the path command to [path].
///
/// For example if the object is a [_PathMoveTo] command it will invoke
/// [Path.moveTo] on [path].
/// </Summary>
public virtual void Apply(Path path, double progress)
{
}

#endregion
}


public class _PathMoveTo : FlutterSDK.Material.Animatedicons.Animatedicons._PathCommand
{
    #region constructors
    public _PathMoveTo(List<object> points)

}
#endregion

#region fields
public virtual List<object> Points { get; set; }
#endregion

#region methods

public new void Apply(Path path, double progress)
{
    Offset offset = AnimatediconsDefaultClass._Interpolate(Points, progress, Offset.Lerp);
    path.MoveTo(offset.Dx, offset.Dy);
}



#endregion
}


public class _PathCubicTo : FlutterSDK.Material.Animatedicons.Animatedicons._PathCommand
{
    #region constructors
    public _PathCubicTo(List<object> controlPoints1, List<object> controlPoints2, List<object> targetPoints)

}
#endregion

#region fields
public virtual List<object> ControlPoints2 { get; set; }
public virtual List<object> ControlPoints1 { get; set; }
public virtual List<object> TargetPoints { get; set; }
#endregion

#region methods

public new void Apply(Path path, double progress)
{
    Offset controlPoint1 = AnimatediconsDefaultClass._Interpolate(ControlPoints1, progress, Offset.Lerp);
    Offset controlPoint2 = AnimatediconsDefaultClass._Interpolate(ControlPoints2, progress, Offset.Lerp);
    Offset targetPoint = AnimatediconsDefaultClass._Interpolate(TargetPoints, progress, Offset.Lerp);
    path.CubicTo(controlPoint1.Dx, controlPoint1.Dy, controlPoint2.Dx, controlPoint2.Dy, targetPoint.Dx, targetPoint.Dy);
}



#endregion
}


public class _PathLineTo : FlutterSDK.Material.Animatedicons.Animatedicons._PathCommand
{
    #region constructors
    public _PathLineTo(List<object> points)

}
#endregion

#region fields
public virtual List<object> Points { get; set; }
#endregion

#region methods

public new void Apply(Path path, double progress)
{
    Offset point = AnimatediconsDefaultClass._Interpolate(Points, progress, Offset.Lerp);
    path.LineTo(point.Dx, point.Dy);
}



#endregion
}


public class _PathClose : FlutterSDK.Material.Animatedicons.Animatedicons._PathCommand
{
    #region constructors
    public _PathClose()

}
#endregion

#region fields
#endregion

#region methods

public new void Apply(Path path, double progress)
{
    path.Close();
}



#endregion
}

}
