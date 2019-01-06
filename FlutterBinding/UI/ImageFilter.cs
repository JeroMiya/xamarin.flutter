using System;
using FlutterBinding.Extensions;
using FlutterBinding.Mapping;
using SkiaSharp;

namespace FlutterBinding.UI
{
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
        public static ImageFilter Blur(double sigmaX = 0.0, double sigmaY = 0.0)
        {
            var skFilter = SKImageFilter.CreateBlur((float)sigmaX, (float)sigmaY);
            return new ImageFilter(skFilter);
        }

        /// Creates an image filter that applies a matrix transformation.
        ///
        /// For example, applying a positive scale matrix (see [new Matrix4.diagonal3])
        /// when used with [BackdropFilter] would magnify the background image.
        public static ImageFilter Matrix(
            Float64List matrix4,
            SKFilterQuality filterQuality = SKFilterQuality.Low)
        {
            if (matrix4.Count != 16)
                throw new ArgumentException("'matrix4' must have 16 entries.");

            var skFilter = SKImageFilter.CreateMatrix(
                MatrixExtensions.ToSkMatrix(matrix4),
                (SkiaSharp.SKFilterQuality)filterQuality);

            return new ImageFilter(skFilter);
        }
    }
}