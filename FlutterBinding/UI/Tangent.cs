using System;

namespace FlutterBinding.UI
{
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
            Position = position;
            Vector   = vector;
        }


        /// Creates a [Tangent] based on the angle rather than the vector.
        ///
        /// The [vector] is computed to be the unit vector at the given angle, interpreted
        /// as clockwise radians from the x axis.
        public static Tangent FromAngle(Offset position, double angle)
        {
            return new Tangent(position, new Offset(Math.Cos(angle), Math.Sin(angle)));
        }

        /// Position of the tangent.
        ///
        /// When used with [PathMetric.getTangentForOffset], this represents the precise
        /// position that the given offset along the path corresponds to.
        public Offset Position { get; }

        /// The vector of the curve at [position].
        ///
        /// When used with [PathMetric.getTangentForOffset], this is the vector of the
        /// curve that is at the given offset along the path (i.e. the direction of the
        /// curve at [position]).
        public Offset Vector { get; }

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
        public double Angle => -Math.Atan2(Vector.dy, Vector.dx);
    }
}