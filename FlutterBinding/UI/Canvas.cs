using System;
using System.Collections.Generic;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Extensions;
using FlutterBinding.Flow.Layers;
using FlutterBinding.Shell;
using SkiaSharp;

namespace FlutterBinding.UI
{

    /// <summary>
    /// An interface for recording graphical operations.
    ///
    /// [Canvas] objects are used in creating [Picture] objects, which can
    /// themselves be used with a [SceneBuilder] to build a [Scene]. In
    /// normal usage, however, this is all handled by the framework.
    ///
    /// A canvas has a current transformation matrix which is applied to all
    /// operations. Initially, the transformation matrix is the identity transform.
    /// It can be modified using the [translate], [scale], [rotate], [skew],
    /// and [transform] methods.
    ///
    /// A canvas also has a current clip region which is applied to all operations.
    /// Initially, the clip region is infinite. It can be modified using the
    /// [clipRect], [clipRRect], and [clipPath] methods.
    ///
    /// The current transform and clip can be saved and restored using the stack
    /// managed by the [save], [saveLayer], and [restore] methods.
    /// </summary>
    public class Canvas
    {
        /// Creates a canvas for recording graphical operations into the
        /// given picture recorder.
        ///
        /// Graphical operations that affect pixels entirely outside the given
        /// `cullRect` might be discarded by the implementation. However, the
        /// implementation might draw outside these bounds if, for example, a command
        /// draws partially inside and outside the `cullRect`. To ensure that pixels
        /// outside a given region are discarded, consider using a [clipRect]. The
        /// `cullRect` is optional; by default, all operations are kept.
        ///
        /// To end the recording, call [PictureRecorder.endRecording] on the
        /// given recorder.
        public Canvas(SKPictureRecorder recorder, Rect cullRect = null)
        {
            if (recorder.RecordingCanvas != null)
                throw new ArgumentException("'recorder' must not already be associated with another Canvas.");
            if (cullRect == null)
                cullRect = Rect.largest;

            Constructor(recorder, cullRect.left, cullRect.top, cullRect.right, cullRect.bottom);
        }

        public Canvas(SKCanvas canvas)
        {
            _canvas = canvas;
        }

        private SKCanvas _canvas;
        internal SKCanvas SKCanvas => _canvas;

        public void Constructor(
            SKPictureRecorder recorder,
            double left,
            double top,
            double right,
            double bottom)
        {
            _canvas = recorder.BeginRecording(new SKRect((float)left, (float)top, (float)right, (float)bottom));
        }


        /// Saves a copy of the current transform and clip on the save stack.
        ///
        /// Call [restore] to pop the save stack.
        ///
        /// See also:
        ///
        ///  * [saveLayer], which does the same thing but additionally also groups the
        ///    commands done until the matching [restore].
        public void Save() => _canvas.Save();

        /// Saves a copy of the current transform and clip on the save stack, and then
        /// creates a new group which subsequent calls will become a part of. When the
        /// save stack is later popped, the group will be flattened into a layer and
        /// have the given `paint`'s [Paint.colorFilter] and [Paint.blendMode]
        /// applied.
        ///
        /// This lets you create composite effects, for example making a group of
        /// drawing commands semi-transparent. Without using [saveLayer], each part of
        /// the group would be painted individually, so where they overlap would be
        /// darker than where they do not. By using [saveLayer] to group them
        /// together, they can be drawn with an opaque color at first, and then the
        /// entire group can be made transparent using the [saveLayer]'s paint.
        ///
        /// Call [restore] to pop the save stack and apply the paint to the group.
        ///
        /// ## Using saveLayer with clips
        ///
        /// When a rectangular clip operation (from [clipRect]) is not axis-aligned
        /// with the raster buffer, or when the clip operation is not rectalinear (e.g.
        /// because it is a rounded rectangle clip created by [clipRRect] or an
        /// arbitrarily complicated path clip created by [clipPath]), the edge of the
        /// clip needs to be anti-aliased.
        ///
        /// If two draw calls overlap at the edge of such a clipped region, without
        /// using [saveLayer], the first drawing will be anti-aliased with the
        /// background first, and then the second will be anti-aliased with the result
        /// of blending the first drawing and the background. On the other hand, if
        /// [saveLayer] is used immediately after establishing the clip, the second
        /// drawing will cover the first in the layer, and thus the second alone will
        /// be anti-aliased with the background when the layer is clipped and
        /// composited (when [restore] is called).
        ///
        /// For example, this [CustomPainter.paint] method paints a clean white
        /// rounded rectangle:
        ///
        /// ```dart
        /// void paint(Canvas canvas, Size size) {
        ///   Rect rect = Offset.zero & size;
        ///   canvas.save();
        ///   canvas.clipRRect(new RRect.fromRectXY(rect, 100.0, 100.0));
        ///   canvas.saveLayer(rect, new Paint());
        ///   canvas.drawPaint(new Paint()..color = Colors.red);
        ///   canvas.drawPaint(new Paint()..color = Colors.white);
        ///   canvas.restore();
        ///   canvas.restore();
        /// }
        /// ```
        ///
        /// On the other hand, this one renders a red outline, the result of the red
        /// paint being anti-aliased with the background at the clip edge, then the
        /// white paint being similarly anti-aliased with the background _including
        /// the clipped red paint_:
        ///
        /// ```dart
        /// void paint(Canvas canvas, Size size) {
        ///   // (this example renders poorly, prefer the example above)
        ///   Rect rect = Offset.zero & size;
        ///   canvas.save();
        ///   canvas.clipRRect(new RRect.fromRectXY(rect, 100.0, 100.0));
        ///   canvas.drawPaint(new Paint()..color = Colors.red);
        ///   canvas.drawPaint(new Paint()..color = Colors.white);
        ///   canvas.restore();
        /// }
        /// ```
        ///
        /// This point is moot if the clip only clips one draw operation. For example,
        /// the following paint method paints a pair of clean white rounded
        /// rectangles, even though the clips are not done on a separate layer:
        ///
        /// ```dart
        /// void paint(Canvas canvas, Size size) {
        ///   canvas.save();
        ///   canvas.clipRRect(new RRect.fromRectXY(Offset.zero & (size / 2.0), 50.0, 50.0));
        ///   canvas.drawPaint(new Paint()..color = Colors.white);
        ///   canvas.restore();
        ///   canvas.save();
        ///   canvas.clipRRect(new RRect.fromRectXY(size.center(Offset.zero) & (size / 2.0), 50.0, 50.0));
        ///   canvas.drawPaint(new Paint()..color = Colors.white);
        ///   canvas.restore();
        /// }
        /// ```
        ///
        /// (Incidentally, rather than using [clipRRect] and [drawPaint] to draw
        /// rounded rectangles like this, prefer the [drawRRect] method. These
        /// examples are using [drawPaint] as a proxy for "complicated draw operations
        /// that will get clipped", to illustrate the point.)
        ///
        /// ## Performance considerations
        ///
        /// Generally speaking, [saveLayer] is relatively expensive.
        ///
        /// There are a several different hardware architectures for GPUs (graphics
        /// processing units, the hardware that handles graphics), but most of them
        /// involve batching commands and reordering them for performance. When layers
        /// are used, they cause the rendering pipeline to have to switch render
        /// target (from one layer to another). Render target switches can flush the
        /// GPU's command buffer, which typically means that optimizations that one
        /// could get with larger batching are lost. Render target switches also
        /// generate a lot of memory churn because the GPU needs to copy out the
        /// current frame buffer contents from the part of memory that's optimized for
        /// writing, and then needs to copy it back in once the previous render target
        /// (layer) is restored.
        ///
        /// See also:
        ///
        ///  * [save], which saves the current state, but does not create a new layer
        ///    for subsequent commands.
        ///  * [SKBlendMode], which discusses the use of [Paint.blendMode] with
        ///    [saveLayer].
        public void SaveLayer(Rect bounds, SKPaint paint)
        {
            ////assert(paint != null);
            if (bounds == null)
            {
                _canvas.SaveLayer(paint);
            }
            else
            {
                //assert(RectIsValid(bounds));
                _canvas.SaveLayer(bounds.ToSKRect(), paint);
            }
        }

        /// Pops the current save stack, if there is anything to pop.
        /// Otherwise, does nothing.
        ///
        /// Use [save] and [saveLayer] to push state onto the stack.
        ///
        /// If the state was pushed with with [saveLayer], then this call will also
        /// cause the new layer to be composited into the previous layer.
        public void Restore()
        {
            // [DONE] native 'Canvas_restore';
            _canvas.Restore();
        }

        /// Returns the number of items on the save stack, including the
        /// initial state. This means it returns 1 for a clean canvas, and
        /// that each call to [save] and [saveLayer] increments it, and that
        /// each matching call to [restore] decrements it.
        ///
        /// This number cannot go below 1.
        public int GetSaveCount() => _canvas.SaveCount;

        /// Add a translation to the current transform, shifting the coordinate space
        /// horizontally by the first argument and vertically by the second argument.
        public void Translate(double dx, double dy) => _canvas.Translate((float)dx, (float)dy);

        /// Add an axis-aligned scale to the current transform, scaling by the first
        /// argument in the horizontal direction and the second in the vertical
        /// direction.
        ///
        /// If [sy] is unspecified, [sx] will be used for the scale in both
        /// directions.
        public void Scale(double sx) => Scale(sx, sx);
        public void Scale(double sx, double sy)
        {
            _canvas.Scale((float)sx, (float)sy);
        }

        /// Add a rotation to the current transform. The argument is in radians clockwise.
        public void Rotate(double radians)
        {
            _canvas.RotateRadians((float)radians);
        }

        /// Add an axis-aligned skew to the current transform, with the first argument
        /// being the horizontal skew in radians clockwise around the origin, and the
        /// second argument being the vertical skew in radians clockwise around the
        /// origin.
        public void Skew(double sx, double sy)
        {
            _canvas.Skew((float)sx, (float)sy);
        }

        /// Multiply the current transform by the specified 4⨉4 transformation matrix
        /// specified as a list of values in column-major order.
        public void Transform(List<float> matrix4)
        {
            ////assert(matrix4 != null);
            if (matrix4.Count != 16)
                throw new ArgumentException("'matrix4' must have 16 entries.");

            var matrix = MatrixExtensions.ToSkMatrix(matrix4);
            _canvas.Concat(ref matrix);
        }

        /// Reduces the clip region to the intersection of the current clip and the
        /// given rectangle.
        ///
        /// If [doAntiAlias] is true, then the clip will be anti-aliased.
        ///
        /// If multiple draw commands intersect with the clip boundary, this can result
        /// in incorrect blending at the clip boundary. See [saveLayer] for a
        /// discussion of how to address that.
        ///
        /// Use [SKClipOperation.difference] to subtract the provided rectangle from the
        /// current clip.
        public void ClipRect(Rect rect, SKClipOperation clipOp = SKClipOperation.Intersect, bool doAntiAlias = true)
        {
            ////assert(RectIsValid(rect));
            ////assert(clipOp != null);
            ////assert(doAntiAlias != null);

            _canvas.ClipRect(rect.ToSKRect(), (SkiaSharp.SKClipOperation)clipOp, doAntiAlias);
        }

        /// Reduces the clip region to the intersection of the current clip and the
        /// given rounded rectangle.
        ///
        /// If [doAntiAlias] is true, then the clip will be anti-aliased.
        ///
        /// If multiple draw commands intersect with the clip boundary, this can result
        /// in incorrect blending at the clip boundary. See [saveLayer] for a
        /// discussion of how to address that and some examples of using [clipRRect].
        public void ClipRRect(RRect rrect, bool doAntiAlias = true)
        {
            ////assert(RrectIsValid(rrect));
            ////assert(doAntiAlias != null);
            _canvas.ClipRoundRect(rrect.ToRoundedRect(), antialias: doAntiAlias);
        }

        /// Reduces the clip region to the intersection of the current clip and the
        /// given [Path].
        ///
        /// If [doAntiAlias] is true, then the clip will be anti-aliased.
        ///
        /// If multiple draw commands intersect with the clip boundary, this can result
        /// multiple draw commands intersect with the clip boundary, this can result
        /// in incorrect blending at the clip boundary. See [saveLayer] for a
        /// discussion of how to address that.
        public void ClipPath(Path path, bool doAntiAlias = true)
        {
            ////assert(path != null); // path is checked on the engine side
            ////assert(doAntiAlias != null);
            _canvas.ClipPath(path, antialias: doAntiAlias);
        }

        /// Paints the given [Color] onto the canvas, applying the given
        /// [SKBlendMode], with the given color being the source and the background
        /// being the destination.
        public void DrawColor(Color color, SKBlendMode blendMode)
        {
            ////assert(color != null);
            ////assert(blendMode != null);
            _canvas.DrawColor(new SKColor(color.Value), (SkiaSharp.SKBlendMode)blendMode);
        }

        /// Draws a line between the given points using the given paint. The line is
        /// stroked, the value of the [Paint.style] is ignored for this call.
        ///
        /// The `p1` and `p2` arguments are interpreted as offsets from the origin.
        public void DrawLine(Offset p1, Offset p2, SKPaint paint)
        {
            ////assert(OffsetIsValid(p1));
            ////assert(OffsetIsValid(p2));
            ////assert(paint != null);

            _canvas.DrawLine(p1.ToPoint(), p2.ToPoint(), paint);
        }

        /// Fills the canvas with the given [Paint].
        ///
        /// To fill the canvas with a solid color and blend mode, consider
        /// [drawColor] instead.
        public void DrawPaint(SKPaint paint)
        {
            //assert(paint != null);
            _canvas.DrawPaint(paint);
        }

        /// Draws a rectangle with the given [Paint]. Whether the rectangle is filled
        /// or stroked (or both) is controlled by [Paint.style].
        public void DrawRect(Rect rect, SKPaint paint)
        {
            //assert(RectIsValid(rect));
            //assert(paint != null);
            _canvas.DrawRect(rect.ToSKRect(), paint);
        }

        /// Draws a rounded rectangle with the given [Paint]. Whether the rectangle is
        /// filled or stroked (or both) is controlled by [Paint.style].
        public void DrawRRect(RRect rrect, SKPaint paint)
        {
            //assert(RrectIsValid(rrect));
            //assert(paint != null);
            _canvas.DrawRoundRect(rrect.ToRoundedRect(), paint);
        }

        /// Draws a shape consisting of the difference between two rounded rectangles
        /// with the given [Paint]. Whether this shape is filled or stroked (or both)
        /// is controlled by [Paint.style].
        ///
        /// This shape is almost but not quite entirely unlike an annulus.
        public void DrawDRRect(RRect outer, RRect inner, Paint paint)
        {
            //assert(RrectIsValid(outer));
            //assert(RrectIsValid(inner));
            //assert(paint != null);

            // TODO: Missing SkiaSharp reference
            // native 'Canvas_drawDRRect';
            //SKCanvas.DrawDRRect(outer, inner, paint);
        }

        /// Draws an axis-aligned oval that fills the given axis-aligned rectangle
        /// with the given [Paint]. Whether the oval is filled or stroked (or both) is
        /// controlled by [Paint.style].
        public void DrawOval(Rect rect, SKPaint paint)
        {
            //assert(RectIsValid(rect));
            //assert(paint != null);
            _canvas.DrawOval(rect.ToSKRect(), paint);
        }

        /// Draws a circle centered at the point given by the first argument and
        /// that has the radius given by the second argument, with the [Paint] given in
        /// the third argument. Whether the circle is filled or stroked (or both) is
        /// controlled by [Paint.style].
        public void DrawCircle(Offset c, double radius, SKPaint paint)
        {
            //assert(OffsetIsValid(c));
            //assert(paint != null);
            _canvas.DrawCircle(c.ToPoint(), (float)radius, paint);
        }

        /// Draw an arc scaled to fit inside the given rectangle. It starts from
        /// startAngle radians around the oval up to startAngle + sweepAngle
        /// radians around the oval, with zero radians being the point on
        /// the right hand side of the oval that crosses the horizontal line
        /// that intersects the center of the rectangle and with positive
        /// angles going clockwise around the oval. If useCenter is true, the arc is
        /// closed back to the center, forming a circle sector. Otherwise, the arc is
        /// not closed, forming a circle segment.
        ///
        /// This method is optimized for drawing arcs and should be faster than [Path.arcTo].
        public void DrawArc(Rect rect, double startAngle, double sweepAngle, bool useCenter, Paint paint)
        {
            //assert(RectIsValid(rect));
            //assert(paint != null);

            // TODO: not implemented on SkiaSharp
            // native 'Canvas_drawArc';
            //_canvas.DrawArc(rect.ToSKRect(), startAngle, sweepAngle, useCenter, paint);
        }

        /// Draws the given [Path] with the given [Paint]. Whether this shape is
        /// filled or stroked (or both) is controlled by [Paint.style]. If the path is
        /// filled, then subpaths within it are implicitly closed (see [Path.close]).
        public void DrawPath(Path path, SKPaint paint)
        {
            //assert(path != null); // path is checked on the engine side
            //assert(paint != null);
            _canvas.DrawPath(path, paint);
        }

        /// Draws the given [Image] into the canvas with its top-left corner at the
        /// given [Offset]. The image is composited into the canvas using the given [Paint].
        public void DrawImage(SKImage image, Offset p, SKPaint paint)
        {
            //assert(image != null); // image is checked on the engine side
            //assert(OffsetIsValid(p));
            //assert(paint != null);
            _canvas.DrawImage(image, p.ToPoint(), paint);
        }

        /// Draws the subset of the given image described by the `src` argument into
        /// the canvas in the axis-aligned rectangle given by the `dst` argument.
        ///
        /// This might sample from outside the `src` rect by up to half the width of
        /// an applied filter.
        ///
        /// Multiple calls to this method with different arguments (from the same
        /// image) can be batched into a single call to [drawAtlas] to improve
        /// performance.
        public void DrawImageRect(SKImage image, Rect src, Rect dst, SKPaint paint)
        {
            //assert(image != null); // image is checked on the engine side
            //assert(RectIsValid(src));
            //assert(RectIsValid(dst));
            //assert(paint != null);
            _canvas.DrawImage(image, src.ToSKRect(), dst.ToSKRect(), paint);
        }

        /// Draws the given [Image] into the canvas using the given [Paint].
        ///
        /// The image is drawn in nine portions described by splitting the image by
        /// drawing two horizontal lines and two vertical lines, where the `center`
        /// argument describes the rectangle formed by the four points where these
        /// four lines intersect each other. (This forms a 3-by-3 grid of regions,
        /// the center region being described by the `center` argument.)
        ///
        /// The four regions in the corners are drawn, without scaling, in the four
        /// corners of the destination rectangle described by `dst`. The remaining
        /// five regions are drawn by stretching them to fit such that they exactly
        /// cover the destination rectangle while maintaining their relative
        /// positions.
        public void DrawImageNine(SKImage image, Rect center, Rect dst, SKPaint paint)
        {
            //assert(image != null); // image is checked on the engine side
            //assert(RectIsValid(center));
            //assert(RectIsValid(dst));
            //assert(paint != null);
            _canvas.DrawImageNinePatch(image, center.ToSKRectI(), dst.ToSKRect(), paint);
        }


        /// Draw the given picture onto the canvas. To create a picture, see
        /// [PictureRecorder].
        public void DrawPicture(SKPicture picture)
        {
            //assert(picture != null); // picture is checked on the engine side        
            _canvas.DrawPicture(picture);
        }

        /// Draws the text in the given [Paragraph] into this canvas at the given
        /// [Offset].
        ///
        /// The [Paragraph] object must have had [Paragraph.layout] called on it
        /// first.
        ///
        /// To align the text, set the `textAlign` on the [ParagraphStyle] object
        /// passed to the [new ParagraphBuilder] constructor. For more details see
        /// [TextAlign] and the discussion at [new ParagraphStyle].
        ///
        /// If the text is left aligned or justified, the left margin will be at the
        /// position specified by the `offset` argument's [Offset.dx] coordinate.
        ///
        /// If the text is right aligned or justified, the right margin will be at the
        /// position described by adding the [ParagraphConstraints.width] given to
        /// [Paragraph.layout], to the `offset` argument's [Offset.dx] coordinate.
        ///
        /// If the text is centered, the centering axis will be at the position
        /// described by adding half of the [ParagraphConstraints.width] given to
        /// [Paragraph.layout], to the `offset` argument's [Offset.dx] coordinate.
        public void DrawParagraph(Paragraph paragraph, Offset offset)
        {
            //assert(paragraph != null);
            //assert(OffsetIsValid(offset));
            paragraph.Paint(_canvas, offset.dx, offset.dy);
        }

        /// Draws a sequence of points according to the given [SKPointMode].
        ///
        /// The `points` argument is interpreted as offsets from the origin.
        ///
        /// See also:
        ///
        ///  * [drawRawPoints], which takes `points` as a [List<float> ] rather than a
        ///    [List<Offset>].
        public void DrawPoints(SKPointMode pointMode, List<Offset> points, SKPaint paint)
        {
            //assert(pointMode != null);
            //assert(points != null);
            //assert(paint != null);
            _canvas.DrawPoints((SkiaSharp.SKPointMode)pointMode, points.ToPoints().ToArray(), paint);
        }

        /// Draws a sequence of points according to the given [SKPointMode].
        ///
        /// The `points` argument is interpreted as a list of pairs of floating point
        /// numbers, where each pair represents an x and y offset from the origin.
        ///
        /// See also:
        ///
        ///  * [drawPoints], which takes `points` as a [List<Offset>] rather than a
        ///    [List<List<float> >].
        public void DrawRawPoints(SKPointMode pointMode, List<double> points, SKPaint paint)
        {
            //assert(pointMode != null);
            //assert(points != null);
            //assert(paint != null);
            if (points.Count % 2 != 0)
                throw new ArgumentException("'points' must have an even number of values.");

            var list = new List<Offset>();
            for (int i = 0; i < points.Count; i = i + 2)
            {
                list.Add(new Offset(points[i], points[i + 1]));
            }

            DrawPoints(pointMode, list, paint);
        }


        public void DrawVertices(SKVertices vertices, SKBlendMode blendMode, SKPaint paint)
        {
            //assert(vertices != null); // vertices is checked on the engine side
            //assert(paint != null);
            //assert(blendMode != null);
            _canvas.DrawVertices(vertices, (SkiaSharp.SKBlendMode)blendMode, paint);
        }

        //
        // See also:
        //
        //  * [drawRawAtlas], which takes its arguments as typed data lists rather than objects.
        public void DrawAtlas(
            SKImage atlas,
            List<RSTransform> transforms,
            List<Rect> rects,
            List<Color> colors,
            SKBlendMode blendMode,
            Rect cullRect,
            Paint paint)
        {
            //assert(atlas != null); // atlas is checked on the engine side
            //assert(transforms != null);
            //assert(rects != null);
            //assert(colors != null);
            //assert(blendMode != null);
            //assert(paint != null);

            int rectCount = rects.Count;
            if (transforms.Count != rectCount)
                throw new ArgumentException("'transforms' and 'rects' lengths must match.");
            if (colors.Count > 0 && colors.Count != rectCount)
                throw new ArgumentException("'If non-null, 'colors' length must match that of 'transforms' and 'rects'.");

            List<double> rstTransformBuffer = new List<double>(rectCount * 4);
            List<double> rectBuffer = new List<double>(rectCount * 4);

            for (int i = 0; i < rectCount; ++i)
            {
                int index0 = i * 4;
                int index1 = index0 + 1;
                int index2 = index0 + 2;
                int index3 = index0 + 3;
                RSTransform rstTransform = transforms[i];
                Rect rect = rects[i];
                //assert(RectIsValid(rect));
                rstTransformBuffer[index0] = rstTransform.scos;
                rstTransformBuffer[index1] = rstTransform.ssin;
                rstTransformBuffer[index2] = rstTransform.tx;
                rstTransformBuffer[index3] = rstTransform.ty;
                rectBuffer[index0]         = rect.left;
                rectBuffer[index1]         = rect.top;
                rectBuffer[index2]         = rect.right;
                rectBuffer[index3]         = rect.bottom;
            }

            List<uint> colorBuffer = colors.Count == 0 ? null : Painting.EncodeColorList(colors);
            List<double> cullRectBuffer = cullRect?._value;

            _drawAtlas(
                paint,
                atlas,
                rstTransformBuffer,
                rectBuffer,
                colorBuffer,
                blendMode,
                cullRectBuffer
            );
        }

        //
        // The `rstTransforms` argument is interpreted as a list of four-tuples, with
        // each tuple being ([RSTransform.scos], [RSTransform.ssin],
        // [RSTransform.tx], [RSTransform.ty]).
        //
        // The `rects` argument is interpreted as a list of four-tuples, with each
        // tuple being ([Rect.left], [Rect.top], [Rect.right], [Rect.bottom]).
        //
        // The `colors` argument, which can be null, is interpreted as a list of
        // 32-bit colors, with the same packing as [Color.value].
        //
        // See also:
        //
        //  * [drawAtlas], which takes its arguments as objects rather than typed
        //    data lists.
        internal void DrawRawAtlas(
            SKImage atlas,
            List<double> rstTransforms,
            List<double> rects,
            List<uint> colors,
            SKBlendMode blendMode,
            Rect cullRect,
            Paint paint)
        {
            ////assert(atlas != null); // atlas is checked on the engine side
            ////assert(rstTransforms != null);
            ////assert(rects != null);
            ////assert(colors != null);
            ////assert(blendMode != null);
            ////assert(paint != null);

            int rectCount = rects.Count;
            if (rstTransforms.Count != rectCount)
                throw new ArgumentException("'rstTransforms' and 'rects' lengths must match.");
            if (rectCount % 4 != 0)
                throw new ArgumentException("'rstTransforms' and 'rects' lengths must be a multiple of four.");
            if (colors != null && colors.Count * 4 != rectCount)
                throw new ArgumentException("If non-null, 'colors' length must be one fourth the length of 'rstTransforms' and 'rects'.");

            _drawAtlas(
                paint,
                atlas,
                rstTransforms,
                rects,
                colors,
                blendMode,
                cullRect?._value
            );
        }

        void _drawAtlas(
            Paint paint,
            SKImage atlas,
            List<double> transforms,
            List<double> rects,
            List<uint> colors,
            SKBlendMode blendMode,
            List<double> cullRect)
        {
            if (_canvas == null)
                return;
            if (atlas == null)
                throw new FlutterException("Canvas.drawAtlas or Canvas.drawRawAtlas called with non-genuine Image.");

            //static_assert(sizeof(SkRSXform) == sizeof(float) * 4, "SkRSXform doesn't use floats.");
            //static_assert(sizeof(SkRect) == sizeof(float) * 4, "SkRect doesn't use floats.");

            // TODO: not implemented on SkiaSharp
            //_canvas.DrawAtlas(atlas, transforms, rects, colors, rects.Count / 4, blendMode, cullRect, paint);
        }

        /// Draws a shadow for a [Path] representing the given material elevation.
        ///
        /// The `transparentOccluder` argument should be true if the occluding object
        /// is not opaque.
        ///
        /// The arguments must not be null.
        public void DrawShadow(Path path, Color color, double elevation, bool transparentOccluder)
        {
            //assert(path != null); // path is checked on the engine side
            //assert(color != null);
            //assert(transparentOccluder != null);

            PhysicalShapeLayer.DrawShadow(
                _canvas, 
                path, 
                color.Value, 
                (float)elevation, 
                transparentOccluder,
                (float)Window.Instance.DevicePixelRatio);
        }
    }
}