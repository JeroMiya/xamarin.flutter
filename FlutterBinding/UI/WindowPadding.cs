namespace FlutterBinding.UI
{
    /// <summary>
    /// A representation of distances for each of the four edges of a rectangle,
    /// used to encode the view insets and padding that applications should place
    /// around their user interface, as exposed by [Window.viewInsets] and
    /// [Window.padding]. View insets and padding are preferably read via
    /// [MediaQuery.of].
    ///
    /// For a generic class that represents distances around a rectangle, see the
    /// [EdgeInsets] class.
    ///
    /// See also:
    ///
    ///  * [WidgetsBindingObserver], for a widgets layer mechanism to receive
    ///    notifications when the padding changes.
    ///  * [MediaQuery.of], for the preferred mechanism for accessing these values.
    ///  * [Scaffold], which automatically applies the padding in material design
    ///    applications.
    /// </summary>
    public class WindowPadding
    {
        public WindowPadding(double left, double top, double right, double bottom)
        {
            Left   = left;
            Top    = top;
            Right  = right;
            Bottom = bottom;
        }

        /// The distance from the left edge to the first unpadded pixel, in physical pixels.
        public double Left { get; }

        /// The distance from the top edge to the first unpadded pixel, in physical pixels.
        public double Top { get; }

        /// The distance from the right edge to the first unpadded pixel, in physical pixels.
        public double Right { get; }

        /// The distance from the bottom edge to the first unpadded pixel, in physical pixels.
        public double Bottom { get; }

        /// A window padding that has zeros for each edge.
        public static readonly WindowPadding Zero = new WindowPadding(left: 0.0, top: 0.0, right: 0.0, bottom: 0.0);

        public override string ToString()
        {
            return $"{nameof(WindowPadding)}({Left}, {Top}, {Right}, {Bottom})";
        }
    }
}