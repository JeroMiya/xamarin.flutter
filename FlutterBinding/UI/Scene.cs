using FlutterBinding.Flow.Layers;
using FlutterBinding.Mapping;
using FlutterBinding.Shell;
using SkiaSharp;

using static FlutterBinding.Mapping.Helper;

namespace FlutterBinding.UI
{
    /// <summary>
    /// An opaque object representing a composited scene.
    ///
    /// To create a Scene object, use a [SceneBuilder].
    ///
    /// Scene objects can be displayed on the screen using the
    /// [Window.render] method.
    /// </summary>
    public class Scene
    {
        public LayerTree LayerTree { get; }

        private Scene(
            Layer rootLayer,
            uint rasterizerTracingThreshold,
            bool checkerboardRasterCacheImages,
            bool checkerboardOffscreenLayers) 
        {
            LayerTree = new LayerTree();
            LayerTree.set_root_layer(rootLayer);
            LayerTree.set_rasterizer_tracing_threshold(rasterizerTracingThreshold);
            LayerTree.set_checkerboard_raster_cache_images(checkerboardRasterCacheImages);
            LayerTree.set_checkerboard_offscreen_layers(checkerboardOffscreenLayers);
        }

        /// Creates a raster image representation of the current state of the scene.
        /// This is a slow operation that is performed on a background thread.
        public Future<SKImage> ToImage(int width, int height)
        {
            if (width <= 0 || height <= 0)
                throw new FlutterException("Image dimensions for scene were invalid.");

            if (LayerTree == null)
                throw new FlutterException("Scene did not contain a layer tree.");

            // We can't create an image on this task runner because we don't have a
            // graphics context. Even if we did, it would be slow anyway. Also, this
            // thread owns the sole reference to the layer tree. So we flatten the layer
            // tree into a picture and use that as the thread transport mechanism.

            var picture = LayerTree.Flatten(new SKRect(0, 0, width, height));
            if (picture == null)
                throw new FlutterException("Could not flatten scene into a layer tree.");

            return _futurize(() => SKImage.FromPicture(picture, new SKSizeI(width, height)));
        }

        public static Scene Create(
            Layer rootLayer,
            uint rasterizerTracingThreshold,
            bool checkerboardRasterCacheImages,
            bool checkerboardOffscreenLayers)
        {
            return new Scene(
                rootLayer,
                rasterizerTracingThreshold,
                checkerboardRasterCacheImages,
                checkerboardOffscreenLayers);
        }
    }
}