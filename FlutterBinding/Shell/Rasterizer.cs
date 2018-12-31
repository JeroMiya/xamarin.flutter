using System;
using System.Text;
using FlutterBinding.Engine;
using FlutterBinding.Engine.Synchronization;
using FlutterBinding.Flow;
using FlutterBinding.Flow.Layers;
using SkiaSharp;

namespace FlutterBinding.Shell
{
    public interface SnapshotDelegate
    {
        SKImage MakeRasterSnapshot(SKPicture picture, SKSizeI pictureSize);
    };


    public class Rasterizer : SnapshotDelegate
    {
        public Rasterizer(TaskRunners taskRunners, CompositorContext compositorContext = null)
        {
            _taskRunners       = taskRunners;
            _compositorContext = compositorContext;
        }

        public void Setup(Surface surface)
        {
            _surface = surface;
            _compositorContext.OnGRContextCreated();
        }

        public void Teardown()
        {
            _compositorContext.OnGRContextDestroyed();
            //surface_.reset();
            //last_layer_tree_.reset();
        }

        public SnapshotDelegate GetSnapshotDelegate() => this;

        public LayerTree GetLastLayerTree()
        {
            return _lastLayerTree;
        }

        public void DrawLastLayerTree()
        {
            if (_lastLayerTree == null || _surface == null)
                return;

            DrawToSurface(_lastLayerTree);
        }

        public TextureRegistry GetTextureRegistry()
        {
            return _compositorContext.texture_registry();
        }

        public void Draw(Pipeline<LayerTree> pipeline)
        {
            //TRACE_EVENT0("flutter", "GPURasterizer::Draw");

            Pipeline<LayerTree>.Consumer consumer = DoDraw;

            // Consume as many pipeline items as possible. But yield the event loop between successive tries.
            switch (pipeline.Consume(consumer))
            {
            case PipelineConsumeResult.MoreAvailable:
                _taskRunners.GPUTaskRunner.PostTask(() => Draw(pipeline));
                break;

            default:
                break;
            }
        }

        public enum ScreenshotType
        {
            SkiaPicture,
            UncompressedImage, // In kN32_SkColorType format
            CompressedImage,
        };

        public class Screenshot
        {
            public SKImage Image { get; }
            public SKSizeI FrameSize { get; } = SKSizeI.Empty;

            public Screenshot() { }

            public Screenshot(SKImage image, SKSizeI size)
            {
                Image      = image;
                FrameSize = size;
            }
        };

        public Screenshot ScreenshotLastLayerTree(ScreenshotType type, bool base64Encode)
        {
            LayerTree layer_tree = GetLastLayerTree();
            if (layer_tree == null)
            {
                //FML_LOG(ERROR) << "Last layer tree was null when screenshotting.";
                return new Screenshot();
            }

            SKImage image = null;
            GRContext surfaceContext = _surface?.GetContext();

            switch (type)
            {
            case ScreenshotType.SkiaPicture:
                image = ScreenshotLayerTreeAsPicture(layer_tree, _compositorContext);
                break;
            case ScreenshotType.UncompressedImage:
                image = ScreenshotLayerTreeAsImage(layer_tree, _compositorContext, surfaceContext, false);
                break;
            case ScreenshotType.CompressedImage:
                image = ScreenshotLayerTreeAsImage(layer_tree, _compositorContext, surfaceContext, true);
                break;
            }

            if (image == null)
            {
                //FML_LOG(ERROR) << "Screenshot data was null.";
                return new Screenshot();
            }

            /*
            if (base64Encode)
            {
                string b64 = Convert.ToBase64String(image.ToArray());
                image = SKData.CreateCopy(Encoding.UTF8.GetBytes(b64));
                return new Screenshot(image, layer_tree.frame_size());
            }
            */

            return new Screenshot(image, layer_tree.frame_size());
        }

        // Sets a callback that will be executed after the next frame is submitted to
        // the surface on the GPU task runner.
        public void SetNextFrameCallback(Action callback)
        {
            _nextFrameCallback = callback;
        }

        public CompositorContext compositor_context()
        {
            return _compositorContext;
        }

        private readonly TaskRunners _taskRunners;
        private Surface _surface;
        private readonly CompositorContext _compositorContext;
        private LayerTree _lastLayerTree;
        private Action _nextFrameCallback;

        // |blink::SnapshotDelegate|
        public SKImage MakeRasterSnapshot(SKPicture picture, SKSizeI pictureSize)
        {
            //TRACE_EVENT0("flutter", __FUNCTION__);

            SKSurface surface;
            if (_surface?.GetContext() == null)
            {
                // Raster surface is fine if there is no on screen surface. This might
                // happen in case of software rendering.
                surface = SKSurface.Create(new SKImageInfo(pictureSize.Width, pictureSize.Height)); // ..MakeRaster(SkImageInfo::MakeN32Premul(picture_size));
            }
            else
            {
                // When there is an on screen surface, we need a render target SkSurface
                // because we want to access texture backed images.
                surface = SKSurface.CreateAsRenderTarget(
                    _surface.GetContext(),
                    new GRBackendTextureDesc() // SkBudgeted::kNo, SkImageInfo::MakeN32Premul(picture_size) // image info
                );
            }

            if (surface == null || surface.Canvas == null)
                return null;

            surface.Canvas.DrawPicture(picture);

            surface.Canvas.Flush();

            //TRACE_EVENT0("flutter", "MakeDeviceSnapshot");
            SKImage deviceSnapshot = surface.Snapshot();

            //TRACE_EVENT0("flutter", "DeviceHostTransfer");
            return deviceSnapshot?.ToRasterImage();
        }

        private void DoDraw(LayerTree layerTree)
        {
            if (layerTree == null || _surface == null)
                return;

            if (DrawToSurface(layerTree))
                _lastLayerTree = layerTree;
        }

        private bool DrawToSurface(LayerTree layerTree)
        {
            //FML_DCHECK(surface_);

            SurfaceFrame frame = _surface.AcquireFrame(layerTree.frame_size());

            if (frame == null)
                return false;

            // There is no way for the compositor to know how long the layer tree
            // construction took. Fortunately, the layer tree does. Grab that time
            // for instrumentation.
            _compositorContext.engine_time().SetLapTime(layerTree.construction_time());

            SKCanvas canvas = frame.SkiaCanvas;

            // External view embedding required that the gpu and platform threads are the
            // same. The dynamic merging of these threads is WIP so for now we don't
            // populate the view embedder. Once we can merge the threads, we should
            // populate the view embedded here with surface_->GetExternalViewEmbedder() if
            // the scene contains an external view (and we can probably assert that the
            // gpu and platform threads are the same).
            //
            // TODO(amirh): populate the view embedder once we dynamically merge the
            // threads for embedded platform views.
            ExternalViewEmbedder externalViewEmbedder = null;

            CompositorContext.ScopedFrame compositorFrame = _compositorContext.AcquireFrame(
                _surface.GetContext(),
                canvas,
                externalViewEmbedder,
                _surface.GetRootTransformation(),
                true);

            canvas?.Clear(SKColors.Transparent);

            if (compositorFrame?.Raster(layerTree, false) ?? false)
            {
                frame.Submit();
                FireNextFrameCallbackIfPresent();
                return true;
            }

            return false;
        }

        private void FireNextFrameCallbackIfPresent()
        {
            if (_nextFrameCallback == null)
                return;

            // It is safe for the callback to set a new callback.
            Action callback = _nextFrameCallback;
            _nextFrameCallback = null;
            callback();
        }

        private static SKImage ScreenshotLayerTreeAsPicture(LayerTree tree, CompositorContext compositorContext)
        {
            //FML_DCHECK(tree != nullptr);

            SKPictureRecorder recorder = new SKPictureRecorder();
            SKCanvas canvas = recorder.BeginRecording(SKRect.Create(tree.frame_size().Width, tree.frame_size().Height));

            SKMatrix rootSurfaceTransformation = new SKMatrix();

            // TODO(amirh): figure out how to take a screenshot with embedded UIView.
            // https://github.com/flutter/flutter/issues/23435
            CompositorContext.ScopedFrame frame = compositorContext.AcquireFrame(
                null,
                canvas,
                null,
                rootSurfaceTransformation,
                false);

            frame.Raster(tree, true);

            SKPicture picture = recorder.EndRecording();
            SKImage image = SKImage.FromPicture(picture, tree.frame_size());

            //return image.Encode();
            return image;
        }

        private static SKSurface CreateSnapshotSurface(GRContext surfaceContext, SKSizeI size)
        {
            if (surfaceContext != null)
            {
                // There is a rendering surface that may contain textures that are going to
                // be referenced in the layer tree about to be drawn.
                return SKSurface.CreateAsRenderTarget(
                    surfaceContext,
                    new GRGlBackendTextureDesc
                    {
                        Width  = size.Width,
                        Height = size.Height
                    });
            }

            // There is no rendering surface, assume no GPU textures are present and
            // create a raster surface.
            return SKSurface.Create(new SKImageInfo(size.Width, size.Height));
        }

        private static SKImage ScreenshotLayerTreeAsImage(
            LayerTree tree,
            CompositorContext compositorContext,
            GRContext surfaceContext,
            bool compressed)
        {
            // Attempt to create a snapshot surface depending on whether we have access to
            // a valid GPU rendering context.
            SKSurface snapshotSurface = CreateSnapshotSurface(surfaceContext, tree.frame_size());
            if (snapshotSurface == null)
            {
                //FML_LOG(ERROR) << "Screenshot: unable to create snapshot surface";
                return null;
            }

            // Draw the current layer tree into the snapshot surface.
            SKCanvas canvas = snapshotSurface.Canvas;

            // There is no root surface transformation for the screenshot layer. Reset the
            // matrix to identity.
            SKMatrix rootSurfaceTransformation = new SKMatrix();
            //root_surface_transformation.reset();

            CompositorContext.ScopedFrame frame = compositorContext.AcquireFrame(surfaceContext, canvas, null, rootSurfaceTransformation, false);
            canvas.Clear(SKColors.Transparent);
            frame.Raster(tree, true);
            canvas.Flush();

            // Prepare an image from the surface, this image may potentially be on th GPU.
            SKImage potentiallyGpuSnapshot = snapshotSurface.Snapshot();
            if (potentiallyGpuSnapshot == null)
            {
                //FML_LOG(ERROR) << "Screenshot: unable to make image screenshot";
                return null;
            }

            // Copy the GPU image snapshot into CPU memory.
            SKImage cpuSnapshot = potentiallyGpuSnapshot.ToRasterImage();
            if (cpuSnapshot == null)
            {
                //FML_LOG(ERROR) << "Screenshot: unable to make raster image";
                return null;
            }

            return cpuSnapshot;

            /*
            // If the caller want the pixels to be compressed, there is a Skia utility to
            // compress to PNG. Use that.
            if (compressed)
            {
                return cpuSnapshot.Encode();
            }

            // Copy it into a bitmap and return the same.
            SKPixmap pixmap = new SKPixmap();
            if (!cpuSnapshot.PeekPixels(pixmap))
            {
                //FML_LOG(ERROR) << "Screenshot: unable to obtain bitmap pixels";
                return null;
            }

            ulong len = (ulong)pixmap.Width * (ulong)pixmap.Height * (ulong)pixmap.BytesPerPixel;
            return SKData.CreateCopy(pixmap.GetPixels(), len);
            */
        }
    }
}
