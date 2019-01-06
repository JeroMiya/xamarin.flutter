using FlutterBinding.Mapping;

namespace FlutterBinding.UI
{
    /// A rectangle enclosing a run of text.
    ///
    /// This is similar to [Rect] but includes an inherent [TextDirection].
    public class TextBox
    {
        /// Creates an object that describes a box containing text.
        public static TextBox FromLTRBD(
            double left,
            double top,
            double right,
            double bottom,
            TextDirection direction)
        {
            return new TextBox(left, top, right, bottom, direction);
        }

        //@pragma('vm:entry-point')
        public TextBox(
            double left,
            double top,
            double right,
            double bottom,
            TextDirection direction)
        {
            Left   = left;
            Top    = top;
            Right  = right;
            Bottom = bottom;
            Direction   = direction;
        }

        /// The left edge of the text box, irrespective of direction.
        ///
        /// To get the leading edge (which may depend on the [direction]), consider [start].
        public double Left { get; }

        /// The top edge of the text box.
        public double Top { get; }

        /// The right edge of the text box, irrespective of direction.
        ///
        /// To get the trailing edge (which may depend on the [direction]), consider [end].
        public double Right { get; }

        /// The bottom edge of the text box.
        public double Bottom { get; }

        /// The direction in which text inside this box flows.
        public TextDirection Direction { get; }

        /// Returns a rect of the same size as this box.
        public Rect ToRect() => Rect.fromLTRB(Left, Top, Right, Bottom);

        /// The [left] edge of the box for left-to-right text; the [right] edge of the box for right-to-left text.
        ///
        /// See also:
        ///
        ///  * [direction], which specifies the text direction.
        public double Start => Direction == TextDirection.Ltr ? Left : Right;

        /// The [right] edge of the box for left-to-right text; the [left] edge of the box for right-to-left text.
        ///
        /// See also:
        ///
        ///  * [direction], which specifies the text direction.
        public double End => Direction == TextDirection.Ltr ? Right : Left;

        protected bool Equals(TextBox other)
        {
            return Left.Equals(other.Left) && 
                Top.Equals(other.Top) && 
                Right.Equals(other.Right) && 
                Bottom.Equals(other.Bottom) && 
                Direction == other.Direction;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((TextBox)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Left.GetHashCode();
                hashCode = (hashCode * 397) ^ Top.GetHashCode();
                hashCode = (hashCode * 397) ^ Right.GetHashCode();
                hashCode = (hashCode * 397) ^ Bottom.GetHashCode();
                hashCode = (hashCode * 397) ^ (int)Direction;
                return hashCode;
            }
        }

        public static bool operator ==(TextBox left, TextBox right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TextBox left, TextBox right)
        {
            return !Equals(left, right);
        }

        public override string ToString() => $"TextBox.FromLTRBD({Left.toStringAsFixed(1)}, {Top.toStringAsFixed(1)}, {Right.toStringAsFixed(1)}, {Bottom.toStringAsFixed(1)}, {Direction})";
    }
}