using System.Collections.Generic;
using FlutterBinding.Extensions;
using FlutterBinding.Mapping;
using SkiaSharp;

namespace FlutterBinding.UI
{
    /// <summary>
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
    /// </summary>
    public class Path : SKPath
    {
        /// Creates a copy of another [Path].
        ///
        /// This copy is fast and does not require additional memory unless either
        /// the `source` path or the path returned by this constructor are modified.
        public static Path From(Path source)
        {
            return source.Clone();
        }

        private Path Clone()
        {
            return (Path)this.MemberwiseClone();
        }

        /// Starts a new subpath at the given coordinate.
        public void MoveTo(double x, double y)
        {
            base.MoveTo((float)x, (float)y);
        }

        /// Starts a new subpath at the given offset from the current point.
        public void RelativeMoveTo(double dx, double dy)
        {
            base.RMoveTo((float)dx, (float)dy);
        }

        /// Adds a straight line segment from the current point to the given
        /// point.
        public void LineTo(double x, double y)
        {
            base.LineTo((float)x, (float)y);
        }

        /// Adds a straight line segment from the current point to the point
        /// at the given offset from the current point.
        public void RelativeLineTo(double dx, double dy)
        {
            this.RLineTo((float)dx, (float)dy);
        }

        /// Adds a quadratic bezier segment that curves from the current
        /// point to the given point (x2,y2), using the control point
        /// (x1,y1).
        public void QuadraticBezierTo(double x1, double y1, double x2, double y2)
        {
            this.QuadTo((float)x1, (float)y1, (float)x2, (float)y2);
        }

        /// Adds a quadratic bezier segment that curves from the current
        /// point to the point at the offset (x2,y2) from the current point,
        /// using the control point at the offset (x1,y1) from the current
        /// point.
        public void RelativeQuadraticBezierTo(double x1, double y1, double x2, double y2)
        {
            this.RQuadTo((float)x1, (float)y1, (float)x2, (float)y2);
        }

        /// Adds a cubic bezier segment that curves from the current point
        /// to the given point (x3,y3), using the control points (x1,y1) and
        /// (x2,y2).
        public void CubicTo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            base.CubicTo((float)x1, (float)y1, (float)x2, (float)y2, (float)x3, (float)y3);
        }

        /// Adds a cubic bezier segment that curves from the current point
        /// to the point at the offset (x3,y3) from the current point, using
        /// the control points at the offsets (x1,y1) and (x2,y2) from the
        /// current point.
        public void RelativeCubicTo(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            base.RCubicTo((float)x1, (float)y1, (float)x2, (float)y2, (float)x3, (float)y3);
        }

        /// Adds a bezier segment that curves from the current point to the
        /// given point (x2,y2), using the control points (x1,y1) and the
        /// weight w. If the weight is greater than 1, then the curve is a
        /// hyperbola; if the weight equals 1, it's a parabola; and if it is
        /// less than 1, it is an ellipse.
        public void ConicTo(double x1, double y1, double x2, double y2, double w)
        {
            base.ConicTo((float)x1, (float)y1, (float)x2, (float)y2, (float)w);
        }

        /// Adds a bezier segment that curves from the current point to the
        /// point at the offset (x2,y2) from the current point, using the
        /// control point at the offset (x1,y1) from the current point and
        /// the weight w. If the weight is greater than 1, then the curve is
        /// a hyperbola; if the weight equals 1, it's a parabola; and if it
        /// is less than 1, it is an ellipse.
        public void RelativeConicTo(double x1, double y1, double x2, double y2, double w)
        {
            base.RConicTo((float)x1, (float)y1, (float)x2, (float)y2, (float)w);
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
        public void ArcTo(Rect rect, double startAngle, double sweepAngle, bool forceMoveTo)
        {
            base.ArcTo(rect.ToSKRect(), (float)startAngle, (float)sweepAngle, forceMoveTo);
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
        public void ArcToPoint(
            Offset arcEnd,
            Radius radius = null,
            double rotation = 0.0,
            bool largeArc = false,
            bool clockwise = true)
        {
            if (radius == null)
                radius = Radius.zero;
            //assert(OffsetIsValid(arcEnd));
            //assert(RadiusIsValid(radius));

            var arcSize = largeArc ? SKPathArcSize.Large : SKPathArcSize.Small;
            var direction = clockwise ? SKPathDirection.Clockwise : SKPathDirection.CounterClockwise;

            base.ArcTo(
                (float)radius.x,
                (float)radius.y,
                (float)rotation,
                arcSize,
                direction,
                (float)arcEnd.dx,
                (float)arcEnd.dy);

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
        public void RelativeArcToPoint(
            Offset arcEndDelta,
            Radius radius = null,
            double rotation = 0.0,
            bool largeArc = false,
            bool clockwise = true)
        {
            if (radius == null)
                radius = Radius.zero;
            //assert(OffsetIsValid(arcEndDelta));
            //assert(RadiusIsValid(radius));

            var arcSize = largeArc ? SKPathArcSize.Large : SKPathArcSize.Small;
            var direction = clockwise ? SKPathDirection.Clockwise : SKPathDirection.CounterClockwise;

            base.RArcTo(
                (float)radius.x,
                (float)radius.y,
                (float)rotation,
                arcSize,
                direction,
                (float)arcEndDelta.dx,
                (float)arcEndDelta.dy);
        }

        /// Adds a new subpath that consists of four lines that outline the
        /// given rectangle.
        public void AddRect(Rect rect)
        {
            //assert(RectIsValid(rect));
            AddRect(rect.ToSKRect());
        }

        /// Adds a new subpath that consists of a curve that forms the
        /// ellipse that fills the given rectangle.
        ///
        /// To add a circle, pass an appropriate rectangle as `oval`. [Rect.fromCircle]
        /// can be used to easily describe the circle's center [Offset] and radius.
        public void AddOval(Rect oval)
        {
            //assert(RectIsValid(oval));
            AddOval(oval.ToSKRect());
        }

        /// Adds a new subpath with one arc segment that consists of the arc
        /// that follows the edge of the oval bounded by the given
        /// rectangle, from startAngle radians around the oval up to
        /// startAngle + sweepAngle radians around the oval, with zero
        /// radians being the point on the right hand side of the oval that
        /// crosses the horizontal line that intersects the center of the
        /// rectangle and with positive angles going clockwise around the
        /// oval.
        public void AddArc(Rect oval, double startAngle, double sweepAngle)
        {
            //assert(RectIsValid(oval));
            AddArc(oval.ToSKRect(), (float)startAngle, (float)sweepAngle);
        }


        /// Adds a new subpath with a sequence of line segments that connect the given
        /// points.
        ///
        /// If `close` is true, a final line segment will be added that connects the
        /// last point to the first point.
        ///
        /// The `points` argument is interpreted as offsets from the origin.
        public void AddPolygon(List<Offset> points, bool close)
        {
            //assert(points != null);
            var list = new List<SKPoint>();
            foreach (var point in points)
                list.Add(new SKPoint((float)point.dx, (float)point.dy));
            base.AddPoly(list.ToArray(), close);
        }


        /// Adds a new subpath that consists of the straight lines and
        /// curves needed to form the rounded rectangle described by the
        /// argument.
        public void AddRRect(RRect rrect)
        {
            //assert(RrectIsValid(rrect));
            base.AddRoundRect(rrect.ToRoundedRect());
        }


        /// Adds a new subpath that consists of the given `path` offset by the given
        /// `offset`.
        ///
        /// If `matrix4` is specified, the path will be transformed by this matrix
        /// after the matrix is translated by the given offset. The matrix is a 4x4
        /// matrix stored in column major order.
        public void AddPath(Path path, Offset offset, List<float> matrix4 = null)
        {
            //assert(path != null); // path is checked on the engine side
            //assert(OffsetIsValid(offset));
            if (matrix4 != null)
            {
                //assert(Matrix4IsValid(matrix4));
                var skMatrix = MatrixExtensions.ToSkMatrix(matrix4);
                skMatrix.TransX += (float)offset.dx;
                skMatrix.TransY += (float)offset.dy;
                base.AddPath(path, ref skMatrix);
            }
            else
            {
                base.AddPath(path, (float)offset.dx, (float)offset.dy);
            }
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
            //assert(OffsetIsValid(offset));
            if (matrix4 != null)
            {
                //assert(Matrix4IsValid(matrix4));
                var skMatrix = MatrixExtensions.ToSkMatrix(matrix4);
                skMatrix.TransX += (float)offset.dx;
                skMatrix.TransY += (float)offset.dy;
                base.AddPath(path, ref skMatrix, SKPathAddMode.Extend);
            }
            else
            {
                base.AddPath(path, (float)offset.dx, (float)offset.dy, SKPathAddMode.Extend);
            }
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
            //assert(OffsetIsValid(point));
            return Contains((float)point.dx, (float)point.dy);
        }

        /// Returns a copy of the path with all the segments of every
        /// subpath translated by the given offset.
        public Path Shift(Offset offset)
        {
            //assert(OffsetIsValid(offset));

            var path = Clone();
            path.Offset((float)offset.dx, (float)offset.dy);
            return path;
        }


        /// Returns a copy of the path with all the segments of every
        /// subpath transformed by the given matrix.
        public Path Transform(List<float> matrix4)
        {
            //assert(Matrix4IsValid(matrix4));
            var path = this.Clone();
            base.Transform(matrix4.ToSkMatrix());
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
        public Rect GetBounds()
        {
            base.GetBounds(out var skRect);
            return skRect.ToRect();
        }

        /// Combines the two paths according to the manner specified by the given
        /// `operation`.
        ///
        /// The resulting path will be constructed from non-overlapping contours. The
        /// curve order is reduced where possible so that cubics may be turned into
        /// quadratics, and quadratics maybe turned into lines.
        public static Path Combine(SKPathOp operation, Path path1, Path path2)
        {
            //assert(path1 != null);
            //assert(path2 != null);
            Path path = new Path();
            if (path1.Op(path2, operation, path))
                return path;

            throw new Types.StateError("Path.combine() failed.  This may be due an invalid path; in particular, check for NaN values.");
        }

        /// Creates a [PathMetrics] object for this path.
        ///
        /// If `forceClosed` is set to true, the contours of the path will be measured
        /// as if they had been closed, even if they were not explicitly closed.
        public PathMetrics ComputeMetrics(bool forceClosed = false)
        {
            return new PathMetrics(this, forceClosed);
        }
    }
}