using SkiaSharp;

namespace FlutterBinding.UI
{
    /// <summary>
    /// A description of a color filter to apply when drawing a shape or compositing
    /// a layer with a particular [Paint]. A color filter is a function that takes
    /// two colors, and outputs one color. When applied during compositing, it is
    /// independently applied to each pixel of the layer being drawn before the
    /// entire layer is merged with the destination.
    ///
    /// Instances of this class are used with [Paint.colorFilter] on [Paint]
    /// objects.
    /// </summary>
    public class ColorFilter
    {
        /// Creates a color filter that applies the blend mode given as the second
        /// argument. The source color is the one given as the first argument, and the
        /// destination color is the one from the layer being composited.
        ///
        /// The output of this filter is then composited into the background according
        /// to the [Paint.blendMode], using the output of this filter as the source
        /// and the background as the destination.
        public static ColorFilter Mode(Color color, SKBlendMode blendMode)
        {
            return new ColorFilter(color, blendMode);
        }

        public ColorFilter(Color color, SKBlendMode blendMode)
        {
            Color     = color;
            BlendMode = blendMode;
        }

        public Color Color { get; }
        public SKBlendMode BlendMode { get; }

        protected bool Equals(ColorFilter other)
        {
            return Equals(Color, other.Color) && BlendMode == other.BlendMode;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ColorFilter)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Color != null ? Color.GetHashCode() : 0) * 397) ^ (int)BlendMode;
            }
        }

        public static bool operator ==(ColorFilter left, ColorFilter right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ColorFilter left, ColorFilter right)
        {
            return !Equals(left, right);
        }

        public override string ToString() => $"ColorFilter({Color}, {BlendMode})";
    }
}