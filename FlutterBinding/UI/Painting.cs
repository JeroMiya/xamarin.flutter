using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Extensions;
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
        public static bool RectIsValid(Rect rect)
        {
            //assert(rect != null, 'Rect argument was null.');
            //assert(!rect._value.any((double value) => value.isNaN), 'Rect argument contained a NaN value.');
            return true;
        }

        public static bool RrectIsValid(RRect rrect)
        {
            //assert(rrect != null, 'RRect argument was null.');
            //assert(!rrect._value.any((double value) => value.isNaN), 'RRect argument contained a NaN value.');
            return true;
        }

        public static bool OffsetIsValid(Offset offset)
        {
            //assert(offset != null, 'Offset argument was null.');
            //assert(!offset.dx.isNaN && !offset.dy.isNaN, 'Offset argument contained a NaN value.');
            return true;
        }

        public static bool Matrix4IsValid(List<float> matrix4)
        {
            //assert(matrix4 != null, 'Matrix4 argument was null.');
            //assert(matrix4.length == 16, 'Matrix4 must have 16 entries.');
            return true;
        }

        public static bool RadiusIsValid(Radius radius)
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
                //assert(OffsetIsValid(point));
                result[xIndex] = point.dx;
                result[yIndex] = point.dy;
            }

            return result;
        }

        public static List<double> EncodeTwoPoints(Offset pointA, Offset pointB)
        {
            //assert(OffsetIsValid(pointA));
            //assert(OffsetIsValid(pointB));
            return new List<double>(4)
            {
                [0] = pointA.dx,
                [1] = pointA.dy,
                [2] = pointB.dx,
                [3] = pointB.dy
            };
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
        public const Types.Endian FakeHostEndian = Types.Endian.little;

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
            return NativeCodec.InstantiateImageCodec(list, null, decodedCacheRatioCap);
        }

        /// Loads a single image frame from a byte array into an [Image] object.
        ///
        /// This is a convenience wrapper around [InstantiateImageCodec].
        /// Prefer using [InstantiateImageCodec] which also supports multi frame images.
        public async Task<SKImage> DecodeImageFromList(List<int> list)
        {
            SKCodec codec = await InstantiateImageCodec(list);
            SKCodecFrameInfo frameInfo = codec.FrameInfo[0]; // TODO: .getNextFrame();

            return frameInfo.GetImage(codec);
        }


        /// Convert an array of pixel values into an [Image] object.
        ///
        /// [pixels] is the pixel data in the encoding described by [format].
        ///
        /// [rowBytes] is the number of bytes consumed by each row of pixels in the
        /// data buffer.  If unspecified, it defaults to [width] multiplied by the
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
        public async Task<SKImage> DecodeImageFromPixels(
            List<int> pixels,
            int width,
            int height,
            PixelFormat format,
            int rowBytes = 0, double decodedCacheRatioCap = double.PositiveInfinity)
        {
            ImageInfo imageInfo = new ImageInfo(width, height, (int)format, rowBytes);
            var codec = await NativeCodec.InstantiateImageCodec(pixels, imageInfo, decodedCacheRatioCap);

            return codec.FrameInfo[0].GetImage(codec);
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

    public class ImageInfo
    {
        public ImageInfo(int width, int height, int format, int? rowBytes)
        {
            Width  = width;
            Height = height;
            Format = format;

            if (rowBytes == null)
                RowBytes = width * 4;
            else
                RowBytes = rowBytes.Value;
        }

        public int Width { get; }
        public int Height { get; }
        public int Format { get; }
        public int RowBytes { get; }
    }
}
