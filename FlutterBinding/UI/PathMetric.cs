using SkiaSharp;

namespace FlutterBinding.UI
{
    /// <summary>
    /// Utilities for measuring a [Path] and extracting subpaths.
    ///
    /// Iterate over the object returned by [Path.computeMetrics] to obtain
    /// [PathMetric] objects.
    ///
    /// Once created, metrics will only be valid while the iterator is at the given
    /// contour. When the next contour's [PathMetric] is obtained, this object
    /// becomes invalid.
    /// </summary>
    public class PathMetric : SKPathMeasure
    {
        /// Create a new empty [Path] object.
        internal PathMetric(Path path, bool forceClosed)
            : base(path, forceClosed)
            { }

        /// Computes the position of hte current contour at the given offset, and the
        /// angle of the path at that point.
        ///
        /// For example, calling this method with a distance of 1.41 for a line from
        /// 0.0,0.0 to 2.0,2.0 would give a point 1.0,1.0 and the angle 45 degrees
        /// (but in radians).
        ///
        /// Returns null if the contour has zero [length].
        ///
        /// The distance is clamped to the [length] of the current contour.
        public Tangent GetTangentForOffset(double distance)
        {
            // first entry == 0 indicates that Skia returned false
            if (GetPositionAndTangent((float)distance, out var position, out var tangent))
            {
                return null;
            }
            return new Tangent(
                new Offset(position.X, position.Y),
                new Offset(tangent.X, tangent.Y));
        }

        /// Given a start and stop distance, return the intervening segment(s).
        ///
        /// `start` and `end` are pinned to legal values (0..[length])
        /// Returns null if the segment is 0 length or `start` > `stop`.
        /// Begin the segment with a moveTo if `startWithMoveTo` is true.
        public Path ExtractPath(double start, double end, bool startWithMoveTo = true)
        {
            Path path = new Path();
            if (GetSegment((float)start, (float)end, path, startWithMoveTo))
            {
                return path;
            }
            return null;
        }

        // Move to the next contour in the path.
        //
        // A path can have a next contour if [Path.moveTo] was called after drawing began.
        // Return true if one exists, or false.
        //
        // This is not exactly congruent with a regular [Iterator.moveNext].
        // Typically, [Iterator.moveNext] should be called before accessing the
        // [Iterator.current]. In this case, the [PathMetric] is valid before
        // calling `MoveNext` - `MoveNext` should be called after the first
        // iteration is done instead of before.
        public bool MoveNext() => NextContour();
    }
}