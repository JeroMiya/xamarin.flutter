using FlutterBinding.Mapping;
using SkiaSharp;

namespace FlutterBinding.UI
{
    /// <summary>
    /// A mask filter to apply to shapes as they are painted. A mask filter is a
    /// function that takes a bitmap of color pixels, and returns another bitmap of
    /// color pixels.
    ///
    /// Instances of this class are used with [Paint.maskFilter] on [Paint] objects.
    /// </summary>
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
        public static MaskFilter Blur(SKBlurStyle style, double sigma)
        { 
            //assert(_style != null),
            //assert(_sigma != null);

            return new MaskFilter(style, sigma);
        }

        private MaskFilter(SKBlurStyle style, double sigma)
        {
            Style = style;
            Sigma = sigma;
        }

        public SKBlurStyle Style { get; }
        public double Sigma { get; }

        // The type of MaskFilter class to create for Skia.
        // These constants must be kept in sync with MaskFilterType in paint.cc.
        public const SKBlurMaskFilterFlags TypeNone = SKBlurMaskFilterFlags.None;            // null
        public const SKBlurMaskFilterFlags TypeBlur = SKBlurMaskFilterFlags.IgnoreTransform; // SkBlurMaskFilter

        protected bool Equals(MaskFilter other)
        {
            return Style == other.Style && Sigma.Equals(other.Sigma);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MaskFilter)obj);
        }

        public static bool operator ==(MaskFilter left, MaskFilter right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MaskFilter left, MaskFilter right)
        {
            return !Equals(left, right);
        }

        /// <inheritdoc />
        public override int GetHashCode() => Mapping.Helper.hashValues(Style, Sigma);

        /// <inheritdoc />
        public override string ToString() => $"MaskFilter.blur({Style}, {Sigma.toStringAsFixed(1)})";
    }
}