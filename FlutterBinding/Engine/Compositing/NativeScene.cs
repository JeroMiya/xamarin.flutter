using FlutterBinding.Flow.Layers;
using FlutterBinding.Mapping;
using SkiaSharp;
using static FlutterBinding.Mapping.Helper;

namespace FlutterBinding.Engine.Compositing
{
    public class NativeScene
    {
        public static NativeScene Create(
            Layer rootLayer,
            uint rasterizerTracingThreshold,
            bool checkerboardRasterCacheImages,
            bool checkerboardOffscreenLayers)
        {
            return new NativeScene(
                rootLayer,
                rasterizerTracingThreshold,
                checkerboardRasterCacheImages,
                checkerboardOffscreenLayers);
        }

        private readonly LayerTree _layerTree;


        public LayerTree TakeLayerTree()
        {
            return _layerTree;
        }

        public NativeScene(
            Layer rootLayer,
            uint rasterizerTracingThreshold,
            bool checkerboardRasterCacheImages,
            bool checkerboardOffscreenLayers)
        {
            _layerTree = new LayerTree();
            _layerTree.set_root_layer(rootLayer);
            _layerTree.set_rasterizer_tracing_threshold(rasterizerTracingThreshold);
            _layerTree.set_checkerboard_raster_cache_images(
                checkerboardRasterCacheImages);
            _layerTree.set_checkerboard_offscreen_layers(checkerboardOffscreenLayers);
        }

        public Future<SKImage> ToImage(int width, int height)
        {
            if (_layerTree == null)
                throw new FlutterException("Scene did not contain a layer tree.");

            if (width == 0 || height == 0)
                throw new FlutterException("Image dimensions for scene were invalid.");

            // We can't create an image on this task runner because we don't have a
            // graphics context. Even if we did, it would be slow anyway. Also, this
            // thread owns the sole reference to the layer tree. So we flatten the layer
            // tree into a picture and use that as the thread transport mechanism.

            var picture = _layerTree.Flatten(new SKRect(0, 0, width, height));
            if (picture == null)
                throw new FlutterException("Could not flatten scene into a layer tree.");

            return _futurize(() => SKImage.FromPicture(picture, new SKSizeI(width, height)));
        }
    }
}
