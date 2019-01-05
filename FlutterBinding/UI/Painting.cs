using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Mapping;
using SkiaSharp;
using static FlutterBinding.Mapping.Helper;

namespace FlutterBinding.UI
{
    public class Painting
    {
        // Some methods in this file assert that their arguments are not null. These
        // asserts are just to improve the error messages; they should only cover
        // arguments that are either dereferenced _in Dart_, before being passed to the
        // engine, or that the engine explicitly null-checks itself (after attempting to
        // convert the argument to a native type). It should not be possible for a null
        // or invalid value to be used by the engine even in release mode, since that
        // would cause a crash. It is, however, acceptable for error messages to be much
        // less useful or correct in release mode than in debug mode.
        //
        // Painting APIs will also warn about arguments representing NaN coordinates,
        // which can not be rendered by Skia.

        // Update this list when changing the list of supported codecs.
        /// {@template flutter.dart:ui.imageFormats}
        /// JPEG, PNG, GIF, Animated GIF, WebP, Animated WebP, BMP, and WBMP
        /// {@endtemplate}
        public static bool _rectIsValid(Rect rect)
        {
            //assert(rect != null, 'Rect argument was null.');
            //assert(!rect._value.any((double value) => value.isNaN), 'Rect argument contained a NaN value.');
            return true;
        }

        public static bool _rrectIsValid(RRect rrect)
        {
            //assert(rrect != null, 'RRect argument was null.');
            //assert(!rrect._value.any((double value) => value.isNaN), 'RRect argument contained a NaN value.');
            return true;
        }

        public static bool _offsetIsValid(Offset offset)
        {
            //assert(offset != null, 'Offset argument was null.');
            //assert(!offset.dx.isNaN && !offset.dy.isNaN, 'Offset argument contained a NaN value.');
            return true;
        }

        public static bool _matrix4IsValid(List<float> matrix4)
        {
            //assert(matrix4 != null, 'Matrix4 argument was null.');
            //assert(matrix4.length == 16, 'Matrix4 must have 16 entries.');
            return true;
        }

        public static bool _radiusIsValid(Radius radius)
        {
            //assert(radius != null, 'Radius argument was null.');
            //assert(!radius.x.isNaN && !radius.y.isNaN, 'Radius argument contained a NaN value.');
            return true;
        }

        public static Color ScaleAlpha(Color a, double factor)
        {
            return a.WithAlpha((uint)(a.Alpha * factor).round().clamp(0, 255));
        }

        public static List<uint> EncodeColorList(List<Color> colors)
        {
            int colorCount = colors.Count;
            List<uint> result = new List<uint>(colorCount);
            for (int i = 0; i < colorCount; ++i)
                result[i] = colors[i].Value;
            return result;
        }

        public static List<double> EncodePointList(List<Offset> points)
        {
            //assert(points != null);
            int pointCount = points.Count;
            List<double> result = new List<double>(pointCount * 2);
            for (int i = 0; i < pointCount; ++i)
            {
                int xIndex = i * 2;
                int yIndex = xIndex + 1;
                Offset point = points[i];
                //assert(_offsetIsValid(point));
                result[xIndex] = point.dx;
                result[yIndex] = point.dy;
            }

            return result;
        }

        public static List<double> EncodeTwoPoints(Offset pointA, Offset pointB)
        {
            //assert(_offsetIsValid(pointA));
            //assert(_offsetIsValid(pointB));
            List<double> result = new List<double>(4);
            result[0] = pointA.dx;
            result[1] = pointA.dy;
            result[2] = pointB.dx;
            result[3] = pointB.dy;
            return result;
        }

        /// The global default value of whether and how to clip a widget. This is only for
        /// temporary migration from default-to-clip to default-to-NOT-clip.
        ///
        // TODO(liyuqian): Set it to Clip.none. (https://github.com/flutter/flutter/issues/18057)
        // We currently have Clip.antiAlias to preserve our old behaviors.
        [Obsolete("Do not use this as it'll soon be removed after we set the default behavior to Clip.none.")]
        public const Clip DefaultClipBehavior = Clip.AntiAlias;

        // If we actually run on big endian machines, we'll need to do something smarter
        // here. We don't use [Endian.Host] because it's not a compile-time
        // constant and can't propagate into the set/get calls.
        public const Types.Endian kFakeHostEndian = Types.Endian.little;

        /// Instantiates an image codec [Codec] object.
        ///
        /// [list] is the binary image data (e.g a PNG or GIF binary data).
        /// The data can be for either static or animated images. The following image
        /// formats are supported: {@macro flutter.dart:ui.imageFormats}
        ///
        /// The [decodedCacheRatioCap] is the default maximum multiple of the compressed
        /// image size to cache when decoding animated image frames. For example,
        /// setting this to `2.0` means that a 400KB GIF would be allowed at most to use
        /// 800KB of memory caching unessential decoded frames. Caching decoded frames
        /// saves CPU but can result in out-of-memory crashes when decoding large (or
        /// multiple) animated images. Note that GIFs are highly compressed, and it's
        /// unlikely that a factor that low will be sufficient to cache all decoded
        /// frames. The default value is `25.0`.
        ///
        /// The returned future can complete with an error if the image decoding has
        /// failed.
        public Task<SKCodec> InstantiateImageCodec(
            List<int> list,
            double decodedCacheRatioCap = double.PositiveInfinity)
        {
            return _instantiateImageCodec(list, null, decodedCacheRatioCap);
        }

        /// Instantiates a [Codec] object for an image binary data.
        ///
        /// Returns an error message if the instantiation has failed, null otherwise.
        private Task<SKCodec> _instantiateImageCodec(List<int> list, _ImageInfo imageInfo, double decodedCacheRatioCap)
            => NativeCodec.InstantiateImageCodec(list, imageInfo, decodedCacheRatioCap);

        /// Loads a single image frame from a byte array into an [Image] object.
        ///
        /// This is a convenience wrapper around [InstantiateImageCodec].
        /// Prefer using [InstantiateImageCodec] which also supports multi frame images.
        public void DecodeImageFromList(List<int> list, ImageDecoderCallback callback)
        {
            _decodeImageFromListAsync(list, callback);
        }

        private async Task _decodeImageFromListAsync(
            List<int> list,
            ImageDecoderCallback callback)
        {
            SKCodec codec = await InstantiateImageCodec(list);
            SKCodecFrameInfo frameInfo = codec.FrameInfo[0]; // TODO: .getNextFrame();
            callback(frameInfo.GetImage(codec));
        }

        /// Convert an array of pixel values into an [Image] object.
        ///
        /// [pixels] is the pixel data in the encoding described by [format].
        ///
        /// [rowBytes] is the number of bytes consumed by each row of pixels in the
        /// data buffer.  If unspecified, it defaults to [width] multipled by the
        /// number of bytes per pixel in the provided [format].
        ///
        /// The [decodedCacheRatioCap] is the default maximum multiple of the compressed
        /// image size to cache when decoding animated image frames. For example,
        /// setting this to `2.0` means that a 400KB GIF would be allowed at most to use
        /// 800KB of memory caching unessential decoded frames. Caching decoded frames
        /// saves CPU but can result in out-of-memory crashes when decoding large (or
        /// multiple) animated images. Note that GIFs are highly compressed, and it's
        /// unlikely that a factor that low will be sufficient to cache all decoded
        /// frames. The default value is `25.0`.
        public async void DecodeImageFromPixels(
            List<int> pixels,
            int width,
            int height,
            PixelFormat format,
            ImageDecoderCallback callback,
            int rowBytes = 0, double decodedCacheRatioCap = double.PositiveInfinity)
        {
            _ImageInfo imageInfo = new _ImageInfo(width, height, (int)format, rowBytes);
            var codec = await _instantiateImageCodec(pixels, imageInfo, decodedCacheRatioCap);
            callback(codec.FrameInfo[0].GetImage(codec));
        }
    }


    /// The format in which image bytes should be returned when using
    /// [Image.toByteData].
    public enum ImageByteFormat
    {
        /// Raw RGBA format.
        ///
        /// Unencoded bytes, in RGBA row-primary form, 8 bits per channel.
        rawRgba,

        /// Raw unmodified format.
        ///
        /// Unencoded bytes, in the image's existing format. For example, a grayscale
        /// image may use a single 8-bit channel for each pixel.
        rawUnmodified,

        /// PNG format.
        ///
        /// A loss-less compression format for images. This format is well suited for
        /// images with hard edges, such as screenshots or sprites, and images with
        /// text. Transparency is supported. The PNG format supports images up to
        /// 2,147,483,647 pixels in either dimension, though in practice available
        /// memory provides a more immediate limitation on maximum image size.
        ///
        /// PNG images normally use the `.png` file extension and the `image/png` MIME
        /// type.
        ///
        /// See also:
        ///
        ///  * <https://en.wikipedia.org/wiki/Portable_Network_Graphics>, the Wikipedia page on PNG.
        ///  * <https://tools.ietf.org/rfc/rfc2083.txt>, the PNG standard.
        png,
    }

    /// The format of pixel data given to [decodeImageFromPixels].
    public enum PixelFormat
    {
        /// Each pixel is 32 bits, with the highest 8 bits encoding red, the next 8
        /// bits encoding green, the next 8 bits encoding blue, and the lowest 8 bits
        /// encoding alpha.
        rgba8888,

        /// Each pixel is 32 bits, with the highest 8 bits encoding blue, the next 8
        /// bits encoding green, the next 8 bits encoding red, and the lowest 8 bits
        /// encoding alpha.
        bgra8888,
    }

    public class _ImageInfo
    {
        public _ImageInfo(int width, int height, int format, int? rowBytes)
        {
            this.width  = width;
            this.height = height;
            this.format = format;

            if (rowBytes == null)
                this.rowBytes = width * 4;
            else
                this.rowBytes = rowBytes.Value;
        }

        int width;
        int height;
        int format;
        int rowBytes;
    }

    /// Callback signature for [decodeImageFromList].
    public delegate void ImageDecoderCallback(SKImage result);

    /// Determines the winding rule that decides how the interior of a [Path] is
    /// calculated.
    ///
    /// This enum is used by the [Path.fillType] property.
    public enum PathFillType
    {
        /// The interior is defined by a non-zero sum of signed edge crossings.
        ///
        /// For a given point, the point is considered to be on the inside of the path
        /// if a line drawn from the point to infinity crosses lines going clockwise
        /// around the point a different number of times than it crosses lines going
        /// counter-clockwise around that point.
        ///
        /// See: <https://en.wikipedia.org/wiki/Nonzero-rule>
        nonZero,

        /// The interior is defined by an odd number of edge crossings.
        ///
        /// For a given point, the point is considered to be on the inside of the path
        /// if a line drawn from the point to infinity crosses an odd number of lines.
        ///
        /// See: <https://en.wikipedia.org/wiki/Even-odd_rule>
        evenOdd,
    }

    /// Strategies for combining paths.
    ///
    /// See also:
    ///
    /// * [Path.combine], which uses this enum to decide how to combine two paths.
    // Must be kept in sync with SKPathOp
    public enum PathOperation
    {
        /// Subtract the second path from the first path.
        ///
        /// For example, if the two paths are overlapping circles of equal diameter
        /// but differing centers, the result would be a crescent portion of the
        /// first circle that was not overlapped by the second circle.
        ///
        /// See also:
        ///
        ///  * [reverseDifference], which is the same but subtracting the first path
        ///    from the second.
        difference,

        /// Create a new path that is the intersection of the two paths, leaving the
        /// overlapping pieces of the path.
        ///
        /// For example, if the two paths are overlapping circles of equal diameter
        /// but differing centers, the result would be only the overlapping portion
        /// of the two circles.
        ///
        /// See also:
        ///  * [xor], which is the inverse of this operation
        intersect,

        /// Create a new path that is the union (inclusive-or) of the two paths.
        ///
        /// For example, if the two paths are overlapping circles of equal diameter
        /// but differing centers, the result would be a figure-eight like shape
        /// matching the outer boundaries of both circles.
        union,

        /// Create a new path that is the exclusive-or of the two paths, leaving
        /// everything but the overlapping pieces of the path.
        ///
        /// For example, if the two paths are overlapping circles of equal diameter
        /// but differing centers, the figure-eight like shape less the overlapping parts
        ///
        /// See also:
        ///  * [intersect], which is the inverse of this operation
        xor,

        /// Subtract the first path from the second path.
        ///
        /// For example, if the two paths are overlapping circles of equal diameter
        /// but differing centers, the result would be a crescent portion of the
        /// second circle that was not overlapped by the first circle.
        ///
        /// See also:
        ///
        ///  * [difference], which is the same but subtracting the second path
        ///    from the first.
        reverseDifference,
    }

    /// A complex, one-dimensional subset of a plane.
    ///
    /// A path consists of a number of subpaths, and a _current point_.
    ///
    /// Subpaths consist of segments of various types, such as lines,
    /// arcs, or beziers. Subpaths can be open or closed, and can
    /// self-intersect.
    ///
    /// Closed subpaths enclose a (possibly discontiguous) region of the
    /// plane based on the current [fillType].
    ///
    /// The _current point_ is initially at the origin. After each
    /// operation adding a segment to a subpath, the current point is
    /// updated to the end of that segment.
    ///
    /// Paths can be drawn on canvases using [Canvas.drawPath], and can
    /// used to create clip regions using [Canvas.clipPath].
    public class Path : SKPath
    {
        /// Create a new empty [Path] object.
        public Path()
        {
            _constructor();
        }

        void _constructor()
        {
            // [DONE] native 'Path_constructor';
        }

        /// Creates a copy of another [Path].
        ///
        /// This copy is fast and does not require additional memory unless either
        /// the `source` path or the path returned by this constructor are modified.
        public static Path from(Path source)
        {
            return source.clone();
        }

        private Path clone()
        {
            return (Path)this.MemberwiseClone();
        }

        /// Determines how the interior of this path is calculated.
        ///
        /// Defaults to the non-zero winding rule, [PathFillType.nonZero].
        public PathFillType fillType
        {
            get => (PathFillType)_getFillType();
            set => _setFillType((int)value);
        }

        int _getFillType()
        {
            return (int)this.FillType;
        }

        void _setFillType(int fillType)
        {
            this.FillType = (SKPathFillType)fillType;
        }

        /// Starts a new subpath at the given coordinate.
        public void moveTo(double x, double y)
        {
            this.MoveTo((float)x, (float)y);
        }

        /// Starts a new subpath at the given offset from the current point.
        public void relativeMoveTo(double dx, double dy)
        {
            this.RMoveTo((float)dx, (float)dy);
        }

        /// Adds a straight line segment from the current point to the given
        /// point.
        public void lineTo(double x, double y)
        {
            this.LineTo((float)x, (float)y);
        }

        /// Adds a straight line segment from the current point to the point
        /// at the given offset from the current point.
        public void relativeLineTo(double dx, double dy)
        {
            this.RLineTo((float)dx, (float)dy);
        }

        /// Adds a quadratic bezier segment that curves from the current
        /// point to the given point (x2,y2), using the control point
        /// (x1,y1).
        public void quadraticBezierTo(double x1, double y1, double x2, double y2)
        {
            this.QuadTo((float)x1, (float)y1, (float)x2, (float)y2);
        }

        /// Adds a quadratic bezier segment that curves from the current
        /// point to the point at the offset (x2,y2) from the current point,
        /// using the control point at the offset (x1,y1) from the current
        /// point.
        public void relativeQuadraticBezierTo(double x1, double y1, double x2, double y2)
        {
            this.RQuadTo((float)x1, (float)y1, (float)x2, (float)y2);
        }

        /// Adds a cubic bezier segment that curves from the current point
        /// to the given point (x3,y3), using the control points (x1,y1) and
        /// (x2,y2).
        public void cubicTo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.CubicTo((float)x1, (float)y1, (float)x2, (float)y2, (float)x3, (float)y3);
        }

        /// Adds a cubic bezier segment that curves from the current point
        /// to the point at the offset (x3,y3) from the current point, using
        /// the control points at the offsets (x1,y1) and (x2,y2) from the
        /// current point.
        public void relativeCubicTo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.RCubicTo((float)x1, (float)y1, (float)x2, (float)y2, (float)x3, (float)y3);
        }

        /// Adds a bezier segment that curves from the current point to the
        /// given point (x2,y2), using the control points (x1,y1) and the
        /// weight w. If the weight is greater than 1, then the curve is a
        /// hyperbola; if the weight equals 1, it's a parabola; and if it is
        /// less than 1, it is an ellipse.
        public void conicTo(double x1, double y1, double x2, double y2, double w)
        {
            this.ConicTo((float)x1, (float)y1, (float)x2, (float)y2, (float)w);
        }

        /// Adds a bezier segment that curves from the current point to the
        /// point at the offset (x2,y2) from the current point, using the
        /// control point at the offset (x1,y1) from the current point and
        /// the weight w. If the weight is greater than 1, then the curve is
        /// a hyperbola; if the weight equals 1, it's a parabola; and if it
        /// is less than 1, it is an ellipse.
        public void relativeConicTo(double x1, double y1, double x2, double y2, double w)
        {
            this.RConicTo((float)x1, (float)y1, (float)x2, (float)y2, (float)w);
        }

        /// If the `forceMoveTo` argument is false, adds a straight line
        /// segment and an arc segment.
        ///
        /// If the `forceMoveTo` argument is true, starts a new subpath
        /// consisting of an arc segment.
        ///
        /// In either case, the arc segment consists of the arc that follows
        /// the edge of the oval bounded by the given rectangle, from
        /// startAngle radians around the oval up to startAngle + sweepAngle
        /// radians around the oval, with zero radians being the point on
        /// the right hand side of the oval that crosses the horizontal line
        /// that intersects the center of the rectangle and with positive
        /// angles going clockwise around the oval.
        ///
        /// The line segment added if `forceMoveTo` is false starts at the
        /// current point and ends at the start of the arc.
        public void arcTo(Rect rect, double startAngle, double sweepAngle, bool forceMoveTo)
        {
            _arcTo(rect.left, rect.top, rect.right, rect.bottom, startAngle, sweepAngle, forceMoveTo);
        }

        void _arcTo(
            double left, double top, double right, double bottom,
            double startAngle, double sweepAngle, bool forceMoveTo)
        {
            this.ArcTo(new SKRect((float)left, (float)top, (float)right, (float)bottom), (float)startAngle, (float)sweepAngle, forceMoveTo);
        }

        /// Appends up to four conic curves weighted to describe an oval of `radius`
        /// and rotated by `rotation`.
        ///
        /// The first curve begins from the last point in the path and the last ends
        /// at `arcEnd`. The curves follow a path in a direction determined by
        /// `clockwise` and `largeArc` in such a way that the sweep angle
        /// is always less than 360 degrees.
        ///
        /// A simple line is appended if either either radii are zero or the last
        /// point in the path is `arcEnd`. The radii are scaled to fit the last path
        /// point if both are greater than zero but too small to describe an arc.
        ///
        public void arcToPoint(
            Offset arcEnd,
            Radius radius = null,
            double rotation = 0.0,
            bool largeArc = false,
            bool clockwise = true)
        {
            if (radius == null)
                radius = Radius.zero;
            //assert(_offsetIsValid(arcEnd));
            //assert(_radiusIsValid(radius));
            _arcToPoint(
                arcEnd.dx,
                arcEnd.dy,
                radius.x,
                radius.y,
                rotation,
                largeArc,
                clockwise);
        }

        void _arcToPoint(
            double arcEndX, double arcEndY, double radiusX,
            double radiusY, double rotation, bool largeArc,
            bool clockwise)
        {
            var arcSize = largeArc ? SKPathArcSize.Large : SKPathArcSize.Small;

            var direction = clockwise ? SKPathDirection.Clockwise : SKPathDirection.CounterClockwise;

            this.ArcTo(
                (float)radiusX,
                (float)radiusY,
                (float)rotation,
                arcSize,
                direction,
                (float)arcEndX,
                (float)arcEndY);
        }


        /// Appends up to four conic curves weighted to describe an oval of `radius`
        /// and rotated by `rotation`.
        ///
        /// The last path point is described by (px, py).
        ///
        /// The first curve begins from the last point in the path and the last ends
        /// at `arcEndDelta.dx + px` and `arcEndDelta.dy + py`. The curves follow a
        /// path in a direction determined by `clockwise` and `largeArc`
        /// in such a way that the sweep angle is always less than 360 degrees.
        ///
        /// A simple line is appended if either either radii are zero, or, both
        /// `arcEndDelta.dx` and `arcEndDelta.dy` are zero. The radii are scaled to
        /// fit the last path point if both are greater than zero but too small to
        /// describe an arc.
        public void relativeArcToPoint(
            Offset arcEndDelta,
            Radius radius = null,
            double rotation = 0.0,
            bool largeArc = false,
            bool clockwise = true)
        {
            if (radius == null)
                radius = Radius.zero;
            //assert(_offsetIsValid(arcEndDelta));
            //assert(_radiusIsValid(radius));
            _relativeArcToPoint(
                arcEndDelta.dx,
                arcEndDelta.dy,
                radius.x,
                radius.y,
                rotation,
                largeArc,
                clockwise);
        }

        void _relativeArcToPoint(
            double arcEndX, double arcEndY, double radiusX,
            double radiusY, double rotation,
            bool largeArc, bool clockwise)
        {
            var arcSize = largeArc ? SKPathArcSize.Large : SKPathArcSize.Small;

            var direction = clockwise ? SKPathDirection.Clockwise : SKPathDirection.CounterClockwise;

            this.RArcTo(
                (float)radiusX,
                (float)radiusY,
                (float)rotation,
                arcSize,
                direction,
                (float)arcEndX,
                (float)arcEndY);
        }

        /// Adds a new subpath that consists of four lines that outline the
        /// given rectangle.
        public void addRect(Rect rect)
        {
            //assert(_rectIsValid(rect));
            _addRect(rect.left, rect.top, rect.right, rect.bottom);
        }

        void _addRect(double left, double top, double right, double bottom)
        {
            this.AddRect(new SKRect((float)left, (float)top, (float)right, (float)bottom));
        }

        /// Adds a new subpath that consists of a curve that forms the
        /// ellipse that fills the given rectangle.
        ///
        /// To add a circle, pass an appropriate rectangle as `oval`. [Rect.fromCircle]
        /// can be used to easily describe the circle's center [Offset] and radius.
        public void addOval(Rect oval)
        {
            //assert(_rectIsValid(oval));
            _addOval(oval.left, oval.top, oval.right, oval.bottom);
        }

        void _addOval(double left, double top, double right, double bottom)
        {
            this.AddOval(new SKRect((float)left, (float)top, (float)right, (float)bottom));
        }

        /// Adds a new subpath with one arc segment that consists of the arc
        /// that follows the edge of the oval bounded by the given
        /// rectangle, from startAngle radians around the oval up to
        /// startAngle + sweepAngle radians around the oval, with zero
        /// radians being the point on the right hand side of the oval that
        /// crosses the horizontal line that intersects the center of the
        /// rectangle and with positive angles going clockwise around the
        /// oval.
        public void addArc(Rect oval, double startAngle, double sweepAngle)
        {
            //assert(_rectIsValid(oval));
            _addArc(oval.left, oval.top, oval.right, oval.bottom, startAngle, sweepAngle);
        }

        void _addArc(
            double left, double top, double right, double bottom,
            double startAngle, double sweepAngle)
        {
            this.AddArc(new SKRect((float)left, (float)top, (float)right, (float)bottom), (float)startAngle, (float)sweepAngle);
        }

        /// Adds a new subpath with a sequence of line segments that connect the given
        /// points.
        ///
        /// If `close` is true, a final line segment will be added that connects the
        /// last point to the first point.
        ///
        /// The `points` argument is interpreted as offsets from the origin.
        public void addPolygon(List<Offset> points, bool close)
        {
            //assert(points != null);
            _addPolygon(points, close);
        }

        void _addPolygon(List<Offset> points, bool close)
        {
            var list = new List<SKPoint>();
            foreach (var point in points)
                list.Add(new SKPoint((float)point.dx, (float)point.dy));
            this.AddPoly(list.ToArray(), close);
        }

        /// Adds a new subpath that consists of the straight lines and
        /// curves needed to form the rounded rectangle described by the
        /// argument.
        public void addRRect(RRect rrect)
        {
            //assert(_rrectIsValid(rrect));
            //_addRRect(rrect._value);
            this.AddRoundedRect(new SKRect((float)rrect.left, (float)rrect.top, (float)rrect.right, (float)rrect.bottom), (float)rrect.tlRadiusX, (float)rrect.tlRadiusY);
        }


        /// Adds a new subpath that consists of the given `path` offset by the given
        /// `offset`.
        ///
        /// If `matrix4` is specified, the path will be transformed by this matrix
        /// after the matrix is translated by the given offset. The matrix is a 4x4
        /// matrix stored in column major order.
        public void addPath(Path path, Offset offset, List<float> matrix4 = null)
        {
            //assert(path != null); // path is checked on the engine side
            //assert(_offsetIsValid(offset));
            if (matrix4 != null)
            {
                //assert(_matrix4IsValid(matrix4));
                _addPathWithMatrix(path, offset.dx, offset.dy, matrix4);
            }
            else
            {
                _addPath(path, offset.dx, offset.dy);
            }
        }

        void _addPath(Path path, double dx, double dy)
        {
            this.AddPath(path, (float)dx, (float)dy);
        }

        void _addPathWithMatrix(Path path, double dx, double dy, List<float> matrix)
        {
            var skMatrix = Matrix.ToSkMatrix(matrix);
            skMatrix.TransX += (float)dx;
            skMatrix.TransY += (float)dy;
            this.AddPath(path, ref skMatrix);
        }

        /// Adds the given path to this path by extending the current segment of this
        /// path with the the first segment of the given path.
        ///
        /// If `matrix4` is specified, the path will be transformed by this matrix
        /// after the matrix is translated by the given `offset`.  The matrix is a 4x4
        /// matrix stored in column major order.
        public void extendWithPath(Path path, Offset offset, List<float> matrix4 = null)
        {
            //assert(path != null); // path is checked on the engine side
            //assert(_offsetIsValid(offset));
            if (matrix4 != null)
            {
                //assert(_matrix4IsValid(matrix4));
                _extendWithPathAndMatrix(path, offset.dx, offset.dy, matrix4);
            }
            else
            {
                _extendWithPath(path, offset.dx, offset.dy);
            }
        }

        void _extendWithPath(Path path, double dx, double dy)
        {
            this.AddPath(path, (float)dx, (float)dy, SKPathAddMode.Extend);
        }

        void _extendWithPathAndMatrix(Path path, double dx, double dy, List<float> matrix)
        {
            var skMatrix = Matrix.ToSkMatrix(matrix);
            skMatrix.TransX += (float)dx;
            skMatrix.TransY += (float)dy;
            this.AddPath(path, ref skMatrix, SKPathAddMode.Extend);
        }

        /// Closes the last subpath, as if a straight line had been drawn
        /// from the current point to the first point of the subpath.
        public void close()
        {
            this.Close();
        }

        /// Clears the [Path] object of all subpaths, returning it to the
        /// same state it had when it was created. The _current point_ is
        /// reset to the origin.
        public void reset()
        {
            this.Reset();
        }

        /// Tests to see if the given point is within the path. (That is, whether the
        /// point would be in the visible portion of the path if the path was used
        /// with [Canvas.clipPath].)
        ///
        /// The `point` argument is interpreted as an offset from the origin.
        ///
        /// Returns true if the point is in the path, and false otherwise.
        public bool contains(Offset point)
        {
            //assert(_offsetIsValid(point));
            return _contains(point.dx, point.dy);
        }

        bool _contains(double x, double y)
        {
            return this.Contains((float)x, (float)y);
        }

        /// Returns a copy of the path with all the segments of every
        /// subpath translated by the given offset.
        public Path shift(Offset offset)
        {
            //assert(_offsetIsValid(offset));
            return _shift(offset.dx, offset.dy);
        }

        Path _shift(double dx, double dy)
        {
            var path = this.clone();
            path.Offset((float)dx, (float)dy);
            return path;
        }

        /// Returns a copy of the path with all the segments of every
        /// subpath transformed by the given matrix.
        public Path transform(List<float> matrix4)
        {
            //assert(_matrix4IsValid(matrix4));
            return _transform(matrix4);
        }

        Path _transform(List<float> matrix4)
        {
            var path = this.clone();
            this.Transform(Matrix.ToSkMatrix(matrix4));
            return path;
        }

        /// Computes the bounding rectangle for this path.
        ///
        /// A path containing only axis-aligned points on the same straight line will
        /// have no area, and therefore `Rect.isEmpty` will return true for such a
        /// path. Consider checking `rect.width + rect.height > 0.0` instead, or
        /// using the [computeMetrics] API to check the path length.
        ///
        /// For many more elaborate paths, the bounds may be inaccurate.  For example,
        /// when a path contains a circle, the points used to compute the bounds are
        /// the circle's implied control points, which form a square around the circle;
        /// if the circle has a transformation applied using [transform] then that
        /// square is rotated, and the (axis-aligned, non-rotated) bounding box
        /// therefore ends up grossly overestimating the actual area covered by the
        /// circle.
        // see https://skia.org/user/api/SKPath_Reference#SKPath_getBounds
        public Rect getBounds()
        {
            List<float> rect = _getBounds();
            return Rect.fromLTRB(rect[0], rect[1], rect[2], rect[3]);
        }

        List<float> _getBounds()
        {
            var skRect = new SKRect();
            this.GetBounds(out skRect);
            return new List<float>()
            {
                skRect.Left,
                skRect.Top,
                skRect.Right,
                skRect.Bottom
            };
        }

        /// Combines the two paths according to the manner specified by the given
        /// `operation`.
        ///
        /// The resulting path will be constructed from non-overlapping contours. The
        /// curve order is reduced where possible so that cubics may be turned into
        /// quadratics, and quadratics maybe turned into lines.
        public static Path combine(PathOperation operation, Path path1, Path path2)
        {
            //assert(path1 != null);
            //assert(path2 != null);
            Path path = new Path();
            if (path1.Op(path2, (SKPathOp)operation, path))
            {
                return path;
            }

            throw new Types.StateError("Path.combine() failed.  This may be due an invalid path; in particular, check for NaN values.");
        }

        /// Creates a [PathMetrics] object for this path.
        ///
        /// If `forceClosed` is set to true, the contours of the path will be measured
        /// as if they had been closed, even if they were not explicitly closed.
        public PathMetrics computeMetrics(bool forceClosed = false)
        {
            return new PathMetrics(this, forceClosed);
        }
    }

    /// The geometric description of a tangent: the angle at a point.
    ///
    /// See also:
    ///  * [PathMetric.getTangentForOffset], which returns the tangent of an offset along a path.
    public class Tangent
    {
        /// Creates a [Tangent] with the given values.
        ///
        /// The arguments must not be null.
        public Tangent(Offset position, Offset vector)
        {
            //assert(position != null),
            //assert(vector != null);
            this.position = position;
            this.vector   = vector;
        }


        /// Creates a [Tangent] based on the angle rather than the vector.
        ///
        /// The [vector] is computed to be the unit vector at the given angle, interpreted
        /// as clockwise radians from the x axis.
        public static Tangent fromAngle(Offset position, double angle)
        {
            return new Tangent(position, new Offset(Math.Cos(angle), Math.Sin(angle)));
        }

        /// Position of the tangent.
        ///
        /// When used with [PathMetric.getTangentForOffset], this represents the precise
        /// position that the given offset along the path corresponds to.
        public readonly Offset position;

        /// The vector of the curve at [position].
        ///
        /// When used with [PathMetric.getTangentForOffset], this is the vector of the
        /// curve that is at the given offset along the path (i.e. the direction of the
        /// curve at [position]).
        public readonly Offset vector;

        /// The direction of the curve at [position].
        ///
        /// When used with [PathMetric.getTangentForOffset], this is the angle of the
        /// curve that is the given offset along the path (i.e. the direction of the
        /// curve at [position]).
        ///
        /// This value is in radians, with 0.0 meaning pointing along the x axis in
        /// the positive x-axis direction, positive numbers pointing downward toward
        /// the negative y-axis, i.e. in a clockwise direction, and negative numbers
        /// pointing upward toward the positive y-axis, i.e. in a counter-clockwise
        /// direction.
        // flip the sign to be consistent with [Path.arcTo]'s `sweepAngle`
        public double angle => -Math.Atan2(vector.dy, vector.dx);
    }

    /// An iterable collection of [PathMetric] objects describing a [Path].
    ///
    /// A [PathMetrics] object is created by using the [Path.computeMetrics] method,
    /// and represents the path as it stood at the time of the call. Subsequent
    /// modifications of the path do not affect the [PathMetrics] object.
    ///
    /// Each path metric corresponds to a segment, or contour, of a path.
    ///
    /// For example, a path consisting of a [Path.lineTo], a [Path.moveTo], and
    /// another [Path.lineTo] will contain two contours and thus be represented by
    /// two [PathMetric] objects.
    ///
    /// When iterating across a [PathMetrics]' contours, the [PathMetric] objects are only
    /// valid until the next one is obtained.
    public class PathMetrics : List<PathMetric>
    {
        internal PathMetrics(Path path, bool forceClosed)
        {
            iterator = new PathMetricIterator(new PathMetric(path, forceClosed));
        }

        public IEnumerable<PathMetric> iterator { get; }
    }

    /// Tracks iteration from one segment of a path to the next for measurement.
    public class PathMetricIterator : List<PathMetric>
    {
        internal PathMetricIterator(PathMetric _pathMetric)
        {
            this._pathMetric = _pathMetric;
        }

        PathMetric _pathMetric;
        bool _firstTime = true;

        public PathMetric current => _firstTime ? null : _pathMetric;

        public bool moveNext()
        {
            // PathMetric isn't a normal iterable - it's already initialized to its
            // first Path.  Should only call MoveNext when done with the first one.
            if (_firstTime == true)
            {
                _firstTime = false;
                return true;
            }
            else if (_pathMetric?.MoveNext() == true)
            {
                return true;
            }

            _pathMetric = null;
            return false;
        }
    }


    /// A mask filter to apply to shapes as they are painted. A mask filter is a
    /// function that takes a bitmap of color pixels, and returns another bitmap of
    /// color pixels.
    ///
    /// Instances of this class are used with [Paint.maskFilter] on [Paint] objects.
    public class MaskFilter
    {
        /// Creates a mask filter that takes the shape being drawn and blurs it.
        ///
        /// This is commonly used to approximate shadows.
        ///
        /// The `style` argument controls the kind of effect to draw; see [SKBlurStyle].
        ///
        /// The `sigma` argument controls the size of the effect. It is the standard
        /// deviation of the Gaussian blur to apply. The value must be greater than
        /// zero. The sigma corresponds to very roughly half the radius of the effect
        /// in pixels.
        ///
        /// A blur is an expensive operation and should therefore be used sparingly.
        ///
        /// The arguments must not be null.
        ///
        /// See also:
        ///
        ///  * [Canvas.drawShadow], which is a more efficient way to draw shadows.
        public static MaskFilter blur(SKBlurStyle _style, double _sigma)
        { //assert(_style != null),
            //assert(_sigma != null);

            return new MaskFilter(_style, _sigma);
        }

        private MaskFilter(SKBlurStyle style, double sigma)
        {
            _style = style;
            _sigma = sigma;
        }

        public readonly SKBlurStyle _style;
        public readonly double _sigma;

        // The type of MaskFilter class to create for Skia.
        // These constants must be kept in sync with MaskFilterType in paint.cc.
        public const int _TypeNone = 0; // null
        public const int _TypeBlur = 1; // SkBlurMaskFilter

        public static bool operator ==(MaskFilter mask, Object other)
        {
            if (!(other is MaskFilter))
                return false;
            MaskFilter typedOther = (MaskFilter)other;
            return mask._style == typedOther._style &&
                mask._sigma == typedOther._sigma;
        }

        public static bool operator !=(MaskFilter mask, Object other) => !(mask == other);

        public int hashCode => hashValues(_style, _sigma);

        public String toString() => $"MaskFilter.blur({_style}, {_sigma.toStringAsFixed(1)})";
    }

    /// A description of a color filter to apply when drawing a shape or compositing
    /// a layer with a particular [Paint]. A color filter is a function that takes
    /// two colors, and outputs one color. When applied during compositing, it is
    /// independently applied to each pixel of the layer being drawn before the
    /// entire layer is merged with the destination.
    ///
    /// Instances of this class are used with [Paint.colorFilter] on [Paint]
    /// objects.
    public class ColorFilter
    {
        /// Creates a color filter that applies the blend mode given as the second
        /// argument. The source color is the one given as the first argument, and the
        /// destination color is the one from the layer being composited.
        ///
        /// The output of this filter is then composited into the background according
        /// to the [Paint.blendMode], using the output of this filter as the source
        /// and the background as the destination.
        public static ColorFilter mode(Color color, SKBlendMode blendMode)
        {
            return new ColorFilter(color, blendMode);
        }

        public ColorFilter(Color color, SKBlendMode blendMode)
        {
            _color     = color;
            _blendMode = blendMode;
        }

        public readonly Color _color;
        public readonly SKBlendMode _blendMode;

        public static bool operator ==(ColorFilter filter, Object other)
        {
            if (!(other is ColorFilter))
                return false;
            ColorFilter typedOther = (ColorFilter)other;
            return filter._color == typedOther._color &&
                filter._blendMode == typedOther._blendMode;
        }

        public static bool operator !=(ColorFilter filter, Object other) => !(filter == other);

        public int hashCode => hashValues(_color, _blendMode);

        public String toString() => $"ColorFilter({_color}, {_blendMode})";
    }

    /// A filter operation to apply to a raster image.
    ///
    /// See also:
    ///
    ///  * [BackdropFilter], a widget that applies [ImageFilter] to its rendering.
    ///  * [SceneBuilder.pushBackdropFilter], which is the low-level API for using
    ///    this class.
    public class ImageFilter
    {
        private readonly SKImageFilter _filter;
        public SKImageFilter ToSKImageFilter() => _filter;

        private ImageFilter(SKImageFilter filter)
        {
            _filter = filter;
        }

        /// Creates an image filter that applies a Gaussian blur.
        public static ImageFilter blur(double sigmaX = 0.0, double sigmaY = 0.0)
        {
            var skFilter = SKImageFilter.CreateBlur((float)sigmaX, (float)sigmaY);
            return new ImageFilter(skFilter);
        }

        /// Creates an image filter that applies a matrix transformation.
        ///
        /// For example, applying a positive scale matrix (see [new Matrix4.diagonal3])
        /// when used with [BackdropFilter] would magnify the background image.
        public static ImageFilter matrix(
            Float64List matrix4,
            SKFilterQuality filterQuality = SKFilterQuality.Low)
        {
            if (matrix4.Count != 16)
                throw new ArgumentException("'matrix4' must have 16 entries.");

            var skFilter = SKImageFilter.CreateMatrix(
                Matrix.ToSkMatrix(matrix4),
                (SkiaSharp.SKFilterQuality)filterQuality);

            return new ImageFilter(skFilter);
        }
    }

    /// Base class for objects such as [Gradient] and [ImageShader] which
    /// correspond to shaders as used by [Paint.shader].
    public class Shader
    {
        protected SKShader _shader;

        public SKShader ToSKShader() => _shader;

        /// This class is created by the engine, and should not be instantiated
        /// or extended directly.
        // //@pragma('vm:entry-point')
        protected Shader() { }

        public Shader(SKShader shader)
        {
            _shader = shader;
        }
    }

    /// Defines what happens at the edge of the gradient.
    ///
    /// A gradient is defined along a finite inner area. In the case of a linear
    /// gradient, it's between the parallel lines that are orthogonal to the line
    /// drawn between two points. In the case of radial gradients, it's the disc
    /// that covers the circle centered on a particular point up to a given radius.
    ///
    /// This enum is used to define how the gradient should paint the regions
    /// outside that defined inner area.
    ///
    /// See also:
    ///
    ///  * [painting.Gradient], the superclass for [LinearGradient] and
    ///    [RadialGradient], as used by [BoxDecoration] et al, which works in
    ///    relative coordinates and can create a [Shader] representing the gradient
    ///    for a particular [Rect] on demand.
    ///  * [dart:ui.Gradient], the low-level class used when dealing with the
    ///    [Paint.shader] property directly, with its [new Gradient.linear] and [new
    ///    Gradient.radial] constructors.
    // These enum values must be kept in sync with SkShader::TileMode.
    public enum TileMode
    {
        /// Edge is clamped to the final color.
        ///
        /// The gradient will paint the all the regions outside the inner area with
        /// the color of the point closest to that region.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_clamp_radial.png)
        clamp,

        /// Edge is repeated from first color to last.
        ///
        /// This is as if the stop points from 0.0 to 1.0 were then repeated from 1.0
        /// to 2.0, 2.0 to 3.0, and so forth (and for linear gradients, similarly from
        /// -1.0 to 0.0, -2.0 to -1.0, etc).
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_repeated_linear.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_repeated_radial.png)
        repeated,

        /// Edge is mirrored from last color to first.
        ///
        /// This is as if the stop points from 0.0 to 1.0 were then repeated backwards
        /// from 2.0 to 1.0, then forwards from 2.0 to 3.0, then backwards again from
        /// 4.0 to 3.0, and so forth (and for linear gradients, similarly from in the
        /// negative direction).
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_mirror_linear.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_mirror_radial.png)
        mirror,
    }


    /// A shader (as used by [Paint.shader]) that renders a color gradient.
    ///
    /// There are several types of gradients, represented by the various constructors
    /// on this class.
    public class Gradient : Shader
    {
        public Gradient(SKShader skShader) : base(skShader) { }

        /// Creates a linear gradient from `from` to `to`.
        ///
        /// If `colorStops` is provided, `colorStops[i]` is a number from 0.0 to 1.0
        /// that specifies where `color[i]` begins in the gradient. If `colorStops` is
        /// not provided, then only two stops, at 0.0 and 1.0, are implied (and
        /// `color` must therefore only have two entries).
        ///
        /// The behavior before `from` and after `to` is described by the `tileMode`
        /// argument. For details, see the [TileMode] enum.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_clamp_linear.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_mirror_linear.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_repeated_linear.png)
        ///
        /// If `from`, `to`, `colors`, or `tileMode` are null, or if `colors` or
        /// `colorStops` contain null values, this constructor will throw a
        /// [NoSuchMethodError].
        public static Shader linear(
            Offset from,
            Offset to,
            List<Color> colors,
            List<double> colorStops = null,
            TileMode tileMode = TileMode.clamp)
        {
            //assert(_offsetIsValid(from)),
            //assert(_offsetIsValid(to)),
            //assert(colors != null),
            //assert(tileMode != null),

            var skShader = SKShader.CreateLinearGradient(
                from.ToPoint(),
                to.ToPoint(),
                colors.ToColors().ToArray(),
                colorStops.Cast<float>().ToArray(),
                (SKShaderTileMode)tileMode);

            return new Gradient(skShader);
        }

        /// Creates a radial gradient centered at `center` that ends at `radius`
        /// distance from the center.
        ///
        /// If `colorStops` is provided, `colorStops[i]` is a number from 0.0 to 1.0
        /// that specifies where `color[i]` begins in the gradient. If `colorStops` is
        /// not provided, then only two stops, at 0.0 and 1.0, are implied (and
        /// `color` must therefore only have two entries).
        ///
        /// The behavior before and after the radius is described by the `tileMode`
        /// argument. For details, see the [TileMode] enum.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_clamp_radial.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_mirror_radial.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_repeated_radial.png)
        ///
        /// If `center`, `radius`, `colors`, or `tileMode` are null, or if `colors` or
        /// `colorStops` contain null values, this constructor will throw a
        /// [NoSuchMethodError].
        ///
        /// If `matrix4` is provided, the gradient fill will be transformed by the
        /// specified 4x4 matrix relative to the local coordinate system. `matrix4` must
        /// be a column-major matrix packed into a list of 16 values.
        ///
        /// If `focal` is provided and not equal to `center` and `focalRadius` is
        /// provided and not equal to 0.0, the generated shader will be a two point
        /// conical radial gradient, with `focal` being the center of the focal
        /// circle and `focalRadius` being the radius of that circle. If `focal` is
        /// provided and not equal to `center`, at least one of the two offsets must
        /// not be equal to [Offset.zero].
        public static Shader radial(
            Offset center,
            double radius,
            List<Color> colors,
            List<double> colorStops = null,
            TileMode tileMode = TileMode.clamp,
            List<float> matrix4 = null,
            Offset focal = null,
            double focalRadius = 0.0)
        {
            //assert(_offsetIsValid(center)),
            //assert(colors != null),
            //assert(tileMode != null),
            //assert(matrix4 == null || _matrix4IsValid(matrix4)),

            _validateColorStops(colors, colorStops);
            //List<uint> colorsBuffer = EncodeColorList(colors);
            List<double> colorStopsBuffer = colorStops == null ? null : new List<double>(colorStops);

            SKShader skShader;

            // If focal is null or focal radius is null, this should be treated as a regular radial gradient
            // If focal == center and the focal radius is 0.0, it's still a regular radial gradient
            if (focal == null || (focal == center && focalRadius == 0.0))
            {
                skShader = SKShader.CreateRadialGradient(
                    center.ToPoint(),
                    (float)radius,
                    colors.ToColors().ToArray(),
                    colorStopsBuffer.Cast<float>().ToArray(),
                    (SKShaderTileMode)tileMode,
                    Matrix.ToSkMatrix(matrix4));
            }
            else
            {
                skShader = SKShader.CreateTwoPointConicalGradient(
                    focal.ToPoint(),
                    (float)focalRadius,
                    center.ToPoint(),
                    (float)radius,
                    colors.ToColors().ToArray(),
                    colorStopsBuffer.Cast<float>().ToArray(),
                    (SKShaderTileMode)tileMode,
                    Matrix.ToSkMatrix(matrix4));
            }

            return new Gradient(skShader);
        }


        /// Creates a sweep gradient centered at `center` that starts at `startAngle`
        /// and ends at `endAngle`.
        ///
        /// `startAngle` and `endAngle` should be provided in radians, with zero
        /// radians being the horizontal line to the right of the `center` and with
        /// positive angles going clockwise around the `center`.
        ///
        /// If `colorStops` is provided, `colorStops[i]` is a number from 0.0 to 1.0
        /// that specifies where `color[i]` begins in the gradient. If `colorStops` is
        /// not provided, then only two stops, at 0.0 and 1.0, are implied (and
        /// `color` must therefore only have two entries).
        ///
        /// The behavior before `startAngle` and after `endAngle` is described by the
        /// `tileMode` argument. For details, see the [TileMode] enum.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_clamp_sweep.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_mirror_sweep.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_repeated_sweep.png)
        ///
        /// If `center`, `colors`, `tileMode`, `startAngle`, or `endAngle` are null,
        /// or if `colors` or `colorStops` contain null values, this constructor will
        /// throw a [NoSuchMethodError].
        ///
        /// If `matrix4` is provided, the gradient fill will be transformed by the
        /// specified 4x4 matrix relative to the local coordinate system. `matrix4` must
        /// be a column-major matrix packed into a list of 16 values.
        public static Shader sweep(
            Offset center,
            List<Color> colors,
            List<double> colorStops = null,
            TileMode tileMode = TileMode.clamp,
            double startAngle = 0.0,
            double endAngle = Math.PI * 2,
            List<float> matrix4 = null)
        {
            //assert(_offsetIsValid(center)),
            //assert(colors != null),
            //assert(tileMode != null),
            //assert(startAngle != null),
            //assert(endAngle != null),
            //assert(startAngle<endAngle),
            //assert(matrix4 == null || _matrix4IsValid(matrix4)),

            _validateColorStops(colors, colorStops);
            List<uint> colorsBuffer = Painting.EncodeColorList(colors);
            List<double> colorStopsBuffer = colorStops == null ? null : new List<double>(colorStops);
            var skShader = SKShader.CreateSweepGradient(
                center.ToPoint(),
                colors.ToColors().ToArray(),
                colorStopsBuffer?.Cast<float>().ToArray(),
                Matrix.ToSkMatrix(matrix4));
            return new Shader(skShader);
        }

        static void _validateColorStops(List<Color> colors, List<double> colorStops)
        {
            if (colorStops == null)
            {
                if (colors.Count != 2)
                    throw new ArgumentException("'colors' must have length 2 if 'colorStops' is omitted.");
            }
            else
            {
                if (colors.Count != colorStops.Count)
                    throw new ArgumentException("'colors' and 'colorStops' arguments must have equal length.");
            }
        }
    }

    /// A shader (as used by [Paint.shader]) that tiles an image.
    public class ImageShader
    {
        /// Creates an image-tiling shader. The first argument specifies the image to
        /// tile. The second and third arguments specify the [TileMode] for the x
        /// direction and y direction respectively. The fourth argument gives the
        /// matrix to apply to the effect. All the arguments are required and must not
        /// be null.
        public static SKShader ToImageShader(SKImage image, TileMode tmx, TileMode tmy, List<double> matrix4)
        {
            //assert(image != null), // image is checked on the engine side
            //assert(tmx != null),
            //assert(tmy != null),
            //assert(matrix4 != null),
            if (matrix4.Count != 16)
                throw new ArgumentException("'matrix4' must have 16 entries.");

            return image.ToShader((SKShaderTileMode)tmx, (SKShaderTileMode)tmy, Matrix.ToSkMatrix(matrix4));
        }
    }

    /// Defines how a list of points is interpreted when drawing a set of triangles.
    ///
    /// Used by [Canvas.drawVertices].
    // These enum values must be kept in sync with SkVertices::VertexMode.
    public enum VertexMode
    {
        /// Draw each sequence of three points as the vertices of a triangle.
        triangles,

        /// Draw each sliding window of three points as the vertices of a triangle.
        triangleStrip,

        /// Draw the first point and each sliding window of two points as the vertices of a triangle.
        triangleFan,
    }

    /// A set of vertex data used by [Canvas.drawVertices].
    public class Vertices
    {
        public static SKVertices Raw(
            VertexMode mode,
            List<Offset> positions,
            List<Offset> textureCoordinates = null,
            List<Color> colors = null,
            List<int> indices = null)
        {
            //assert(mode != null),
            //assert(positions != null)
            if (textureCoordinates != null && textureCoordinates.Count != positions.Count)
                throw new ArgumentException("'positions' and 'textureCoordinates' lengths must match.");
            if (colors != null && colors.Count != positions.Count)
                throw new ArgumentException("'positions' and 'colors' lengths must match.");
            if (indices != null && indices.Any((int i) => i < 0 || i >= positions.Count))
                throw new ArgumentException("'indices' values must be valid indices in the positions list.");


            var positionList = new List<SKPoint>();
            foreach (var p in positions)
                positionList.Add(p.ToPoint());

            var textureList = new List<SKPoint>();
            foreach (var t in textureCoordinates)
                textureList.Add(t.ToPoint());

            return SKVertices.CreateCopy((SKVertexMode)mode, positionList.ToArray(), textureList.ToArray(), colors.ToColors().ToArray(), indices.Cast<ushort>().ToArray());
        }
    }

    /// Defines how a list of points is interpreted when drawing a set of points.
    ///
    // ignore: deprecated_member_use
    /// Used by [Canvas.drawPoints].
    // These enum values must be kept in sync with SKCanvas::PointMode.
    public enum PointMode
    {
        /// Draw each point separately.
        ///
        /// If the [Paint.strokeCap] is [SKStrokeCap.round], then each point is drawn
        /// as a circle with the diameter of the [Paint.strokeWidth], filled as
        /// described by the [Paint] (ignoring [Paint.style]).
        ///
        /// Otherwise, each point is drawn as an axis-aligned square with sides of
        /// length [Paint.strokeWidth], filled as described by the [Paint] (ignoring
        /// [Paint.style]).
        points,

        /// Draw each sequence of two points as a line segment.
        ///
        /// If the number of points is odd, then the last point is ignored.
        ///
        /// The lines are stroked as described by the [Paint] (ignoring
        /// [Paint.style]).
        lines,

        /// Draw the entire sequence of point as one line.
        ///
        /// The lines are stroked as described by the [Paint] (ignoring
        /// [Paint.style]).
        polygon,
    }

    /// Defines how a new clip region should be merged with the existing clip
    /// region.
    ///
    /// Used by [Canvas.clipRect].
    public enum ClipOp
    {
        /// Subtract the new region from the existing region.
        difference,

        /// Intersect the new region from the existing region.
        intersect,
    }

    /// Records a [Picture] containing a sequence of graphical operations.
    ///
    /// To begin recording, construct a [Canvas] to record the commands.
    /// To end recording, use the [PictureRecorder.endRecording] method.
    public class PictureRecorder : NativePictureRecorder
    {
        /// Whether this object is currently recording commands.
        ///
        /// Specifically, this returns true if a [Canvas] object has been
        /// created to record commands and recording has not yet ended via a
        /// call to [endRecording], and false if either this
        /// [PictureRecorder] has not yet been associated with a [Canvas],
        /// or the [endRecording] method has already been called.
        public bool isRecording
        {
            get { return this.RecordingCanvas != null; }
        }

        /// Finishes recording graphical operations.
        ///
        /// Returns a picture containing the graphical operations that have been
        /// recorded thus far. After calling this function, both the picture recorder
        /// and the canvas objects are invalid and cannot be used further.
        ///
        /// Returns null if the PictureRecorder is not associated with a canvas.
        public SKPicture endRecording()
        {
            return this.EndRecording();
        }
    }

    /// A single shadow.
    ///
    /// Multiple shadows are stacked together in a [TextStyle].
    public class Shadow
    {
        /// Construct a shadow.
        ///
        /// The default shadow is a black shadow with zero offset and zero blur.
        /// Default shadows should be completely covered by the casting element,
        /// and not be visble.
        ///
        /// Transparency should be adjusted through the [color] alpha.
        ///
        /// Shadow order matters due to compositing multiple translucent objects not
        /// being commutative.
        public Shadow(
            Color color = null,
            Offset offset = null,
            double blurRadius = 0.0)
        {
            //assert(color != null, 'Text shadow color was null.'),
            //assert(offset != null, 'Text shadow offset was null.'),
            //assert(blurRadius >= 0.0, 'Text shadow blur radius should be non-negative.');
            if (color == null)
                this.color = new Color(_kColorDefault);
            else
                this.color = color;

            if (offset == null)
                this.offset = Offset.zero;
            else
                this.offset = offset;

            this.blurRadius = blurRadius;
        }

        const uint _kColorDefault = 0xFF000000;

        // Constants for shadow encoding.
        const int _kBytesPerShadow = 16;
        const int _kColorOffset = 0 << 2;
        const int _kXOffset = 1 << 2;
        const int _kYOffset = 2 << 2;
        const int _kBlurOffset = 3 << 2;

        /// Color that the shadow will be drawn with.
        ///
        /// The shadows are shapes composited directly over the base canvas, and do not
        /// represent optical occlusion.
        public readonly Color color;

        /// The displacement of the shadow from the casting element.
        ///
        /// Positive x/y offsets will shift the shadow to the right and down, while
        /// negative offsets shift the shadow to the left and up. The offsets are
        /// relative to the position of the element that is casting it.
        public readonly Offset offset;

        /// The standard deviation of the Gaussian to convolve with the shadow's shape.
        public readonly double blurRadius;

        /// Converts a blur radius in pixels to sigmas.
        ///
        /// See the sigma argument to [MaskFilter.blur].
        ///
        // See SkBlurMask::ConvertRadiusToSigma().
        // <https://github.com/google/skia/blob/bb5b77db51d2e149ee66db284903572a5aac09be/src/effects/SkBlurMask.cpp#L23>
        static double convertRadiusToSigma(double radius)
        {
            return radius * 0.57735 + 0.5;
        }

        /// The [blurRadius] in sigmas instead of logical pixels.
        ///
        /// See the sigma argument to [MaskFilter.blur].
        public double blurSigma => convertRadiusToSigma(blurRadius);

        /// Create the [Paint] object that corresponds to this shadow description.
        ///
        /// The [offset] is not represented in the [Paint] object.
        /// To honor this as well, the shape should be translated by [offset] before
        /// being filled using this [Paint].
        ///
        /// This class does not provide a way to disable shadows to avoid inconsistencies
        /// in shadow blur rendering, primarily as a method of reducing test flakiness.
        /// [toPaint] should be overriden in subclasses to provide this functionality.
        public Paint toPaint()
        {
            return new Paint
            {
                Color      = color,
                MaskFilter = MaskFilter.blur(SKBlurStyle.Normal, blurSigma)
            };
        }

        /// Returns a new shadow with its [offset] and [blurRadius] scaled by the given
        /// factor.
        public Shadow scale(double factor)
        {
            return new Shadow(
                color: color,
                offset: offset * factor,
                blurRadius: blurRadius * factor);
        }

        /// Linearly interpolate between two shadows.
        ///
        /// If either shadow is null, this function linearly interpolates from a
        /// a shadow that matches the other shadow in color but has a zero
        /// offset and a zero blurRadius.
        ///
        /// {@template dart.ui.shadow.lerp}
        /// The `t` argument represents position on the timeline, with 0.0 meaning
        /// that the interpolation has not started, returning `a` (or something
        /// equivalent to `a`), 1.0 meaning that the interpolation has finished,
        /// returning `b` (or something equivalent to `b`), and values in between
        /// meaning that the interpolation is at the relevant point on the timeline
        /// between `a` and `b`. The interpolation can be extrapolated beyond 0.0 and
        /// 1.0, so negative values and values greater than 1.0 are valid (and can
        /// easily be generated by curves such as [Curves.elasticInOut]).
        ///
        /// Values for `t` are usually obtained from an [Animation<double>], such as
        /// an [AnimationController].
        /// {@endtemplate}
        public static Shadow lerp(Shadow a, Shadow b, double t)
        {
            //assert(t != null);
            if (a == null && b == null)
                return null;
            if (a == null)
                return b.scale(t);
            if (b == null)
                return a.scale(1.0 - t);
            return new Shadow(
                color: Color.Lerp(a.color, b.color, t),
                offset: Offset.lerp(a.offset, b.offset, t),
                blurRadius: Lerp.lerpDouble(a.blurRadius, b.blurRadius, t));
        }

        /// Linearly interpolate between two lists of shadows.
        ///
        /// If the lists differ in length, excess items are lerped with null.
        ///
        /// {@macro dart.ui.shadow.lerp}
        static List<Shadow> lerpList(List<Shadow> a, List<Shadow> b, double t)
        {
            //assert(t != null);
            if (a == null && b == null)
                return null;

            if (a == null)
                a = new List<Shadow>();

            if (b == null)
                b = new List<Shadow>();

            List<Shadow> result = new List<Shadow>();
            int commonLength = Math.Min(a.Count, b.Count);
            for (int i = 0; i < commonLength; i += 1)
                result.Add(Shadow.lerp(a[i], b[i], t));
            for (int i = commonLength; i < a.Count; i += 1)
                result.Add(a[i].scale(1.0 - t));
            for (int i = commonLength; i < b.Count; i += 1)
                result.Add(b[i].scale(t));
            return result;
        }

        public static bool operator ==(Shadow first, Shadow second)
        {
            if (identical(first, second))
                return true;

            Shadow typedOther = second;
            return first.color == typedOther.color &&
                first.offset == typedOther.offset &&
                first.blurRadius == typedOther.blurRadius;
        }

        public static bool operator !=(Shadow first, Shadow second) => !(first == second);

        public int hashCode => hashValues(color, offset, blurRadius);

        /// Determines if lists [a] and [b] are deep equivalent.
        ///
        /// Returns true if the lists are both null, or if they are both non-null, have
        /// the same length, and contain the same Shadows in the same order. Returns
        /// false otherwise.
        public static bool _shadowsListEquals(List<Shadow> a, List<Shadow> b)
        {
            // Compare _shadows
            if (a == null)
                return b == null;
            if (b == null || a.Count != b.Count)
                return false;
            for (int index = 0; index < a.Count; ++index)
                if (a[index] != b[index])
                    return false;
            return true;
        }

        // Serialize [shadows] into ByteData. The format is a single uint_32_t at
        // the beginning indicating the number of shadows, followed by _kBytesPerShadow
        // bytes for each shadow.
        public static Types.ByteData _encodeShadows(List<Shadow> shadows)
        {
            if (shadows == null)
                return new Types.ByteData(0);

            int byteCount = shadows.Count * _kBytesPerShadow;
            Types.ByteData shadowsData = new Types.ByteData(byteCount);

            int shadowOffset = 0;
            for (int shadowIndex = 0; shadowIndex < shadows.Count; ++shadowIndex)
            {
                Shadow shadow = shadows[shadowIndex];
                if (shadow == null)
                    continue;
                shadowOffset = shadowIndex * _kBytesPerShadow;

                shadowsData.setInt32(
                    _kColorOffset + shadowOffset,
                    (int)(shadow.color.Value ^ Shadow._kColorDefault),
                    (int)Painting.kFakeHostEndian);

                shadowsData.setFloat32(
                    _kXOffset + shadowOffset,
                    shadow.offset.dx,
                    (int)Painting.kFakeHostEndian);

                shadowsData.setFloat32(
                    _kYOffset + shadowOffset,
                    shadow.offset.dy,
                    (int)Painting.kFakeHostEndian);

                shadowsData.setFloat32(
                    _kBlurOffset + shadowOffset,
                    shadow.blurRadius,
                    (int)Painting.kFakeHostEndian);
            }

            return shadowsData;
        }

        public String toString() => $"TextShadow({color}, {offset}, {blurRadius})";
    }
}
