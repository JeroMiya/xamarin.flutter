using System;
using System.Collections.Generic;
using System.Linq;
using FlutterBinding.Extensions;
using FlutterBinding.Mapping;
using SkiaSharp;

namespace FlutterBinding.UI
{
    /// Base class for objects such as [Gradient] and [ImageShader] which
    /// correspond to shaders as used by [Paint.shader].
    public class Shader
    {
        protected readonly SKShader _shader;

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
        /// argument. For details, see the [SKShaderTileMode] enum.
        ///
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_clamp_linear.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_mirror_linear.png)
        /// ![](https://flutter.github.io/assets-for-api-docs/assets/dart-ui/tile_mode_repeated_linear.png)
        ///
        /// If `from`, `to`, `colors`, or `tileMode` are null, or if `colors` or
        /// `colorStops` contain null values, this constructor will throw a
        /// [NoSuchMethodError].
        public static Shader Linear(
            Offset from,
            Offset to,
            List<Color> colors,
            List<double> colorStops = null,
            SKShaderTileMode tileMode = SKShaderTileMode.Clamp)
        {
            //assert(OffsetIsValid(from)),
            //assert(OffsetIsValid(to)),
            //assert(colors != null),
            //assert(tileMode != null),

            var skShader = SKShader.CreateLinearGradient(
                from.ToPoint(),
                to.ToPoint(),
                colors.ToColors().ToArray(),
                colorStops?.Cast<float>().ToArray(),
                tileMode);

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
        /// argument. For details, see the [SKShaderTileMode] enum.
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
        public static Shader Radial(
            Offset center,
            double radius,
            List<Color> colors,
            List<double> colorStops = null,
            SKShaderTileMode tileMode = SKShaderTileMode.Clamp,
            List<float> matrix4 = null,
            Offset focal = null,
            double focalRadius = 0.0)
        {
            //assert(OffsetIsValid(center)),
            //assert(colors != null),
            //assert(tileMode != null),
            //assert(matrix4 == null || Matrix4IsValid(matrix4)),

            ValidateColorStops(colors, colorStops);
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
                    colorStopsBuffer?.Cast<float>().ToArray(),
                    tileMode,
                    matrix4.ToSkMatrix());
            }
            else
            {
                skShader = SKShader.CreateTwoPointConicalGradient(
                    focal.ToPoint(),
                    (float)focalRadius,
                    center.ToPoint(),
                    (float)radius,
                    colors.ToColors().ToArray(),
                    colorStopsBuffer?.Cast<float>().ToArray(),
                    tileMode,
                    matrix4.ToSkMatrix());
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
        /// `tileMode` argument. For details, see the [SKShaderTileMode] enum.
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
        public static Shader Sweep(
            Offset center,
            List<Color> colors,
            List<double> colorStops = null,
            SKShaderTileMode tileMode = SKShaderTileMode.Clamp,
            double startAngle = 0.0,
            double endAngle = Math.PI * 2,
            List<float> matrix4 = null)
        {
            //assert(OffsetIsValid(center)),
            //assert(colors != null),
            //assert(tileMode != null),
            //assert(startAngle != null),
            //assert(endAngle != null),
            //assert(startAngle<endAngle),
            //assert(matrix4 == null || Matrix4IsValid(matrix4)),

            ValidateColorStops(colors, colorStops);
            List<uint> colorsBuffer = Painting.EncodeColorList(colors);
            List<double> colorStopsBuffer = colorStops == null ? null : new List<double>(colorStops);
            var skShader = SKShader.CreateSweepGradient(
                center.ToPoint(),
                colors.ToColors().ToArray(),
                colorStopsBuffer?.Cast<float>().ToArray(),
                matrix4.ToSkMatrix());
            return new Shader(skShader);
        }

        private static void ValidateColorStops(List<Color> colors, List<double> colorStops)
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
        /// tile. The second and third arguments specify the [SKShaderTileMode] for the x
        /// direction and y direction respectively. The fourth argument gives the
        /// matrix to apply to the effect. All the arguments are required and must not
        /// be null.
        public static SKShader ToImageShader(SKImage image, SKShaderTileMode tmx, SKShaderTileMode tmy, List<double> matrix4)
        {
            //assert(image != null), // image is checked on the engine side
            //assert(tmx != null),
            //assert(tmy != null),
            //assert(matrix4 != null),
            if (matrix4.Count != 16)
                throw new ArgumentException("'matrix4' must have 16 entries.");

            return image.ToShader(tmx, tmy, matrix4.ToSkMatrix());
        }
    }

}