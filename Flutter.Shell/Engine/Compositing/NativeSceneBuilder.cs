using System;
using System.Collections.Generic;
using Flutter.Framework.Engine.Painting;
using SkiaSharp;

namespace Flutter.Framework.Engine.Compositing
{
    //https://github.com/flutter/engine/blob/master/lib/ui/compositing/scene_builder.h
    //https://github.com/flutter/engine/blob/master/lib/ui/compositing/scene_builder.cc

    public abstract class NativeSceneBuilder
    {
        public void PushTransform(List<double> matrix4)
        {
            var sk_matrix = Matrix.ToSkMatrix(matrix4);
            var layer = new TransformLayer();
            layer.set_transform(sk_matrix);
            PushLayer(layer);
        }

        public NativeEngineLayer PushOffset(double dx, double dy)
        {
            SKMatrix sk_matrix = SKMatrix.MakeTranslation((float)dx, (float)dy);
            var layer = new TransformLayer();
            layer.set_transform(sk_matrix);
            PushLayer(layer);
            return NativeEngineLayer.MakeRetained(layer);
        }

        public void PushClipRect(
            double left,
            double right,
            double top,
            double bottom,
            int clipBehavior)
        {
            var clipRect = new SKRect((float)left, (float)top, (float)right, (float)bottom);
            var layer = new ClipRectLayer((Flow.Layers.Clip)clipBehavior);
            layer.set_clip_rect(clipRect);
            PushLayer(layer);
        }

        public void PushClipRRect(RRect rrect, int clipBehavior)
        {
            var clip_behavior = (Flow.Layers.Clip)clipBehavior;
            var layer = new ClipRRectLayer(clip_behavior);
            layer.set_clip_rrect(rrect.ToRoundedRect());
            PushLayer(layer);
        }

        public void PushClipPath(SKPath path, int clipBehavior)
        {
            // FML_DCHECK(clip_behavior != flow::Clip::none);
            var layer = new ClipPathLayer((Flow.Layers.Clip)clipBehavior);
            layer.set_clip_path(path);
            PushLayer(layer);
        }

        public void PushOpacity(int alpha, double dx = 0, double dy = 0)
        {
            var layer = new OpacityLayer();
            layer.set_alpha(alpha);
            layer.set_offset(new SKPoint((float)dx, (float)dy));
            PushLayer(layer);
        }

        public void PushColorFilter(int color, int blendMode)
        {
            var layer = new ColorFilterLayer();
            layer.set_color((uint)color);
            layer.set_blend_mode((SKBlendMode)blendMode);
            PushLayer(layer);
        }

        public void PushBackdropFilter(ImageFilter filter)
        {
            var layer = new BackdropFilterLayer();
            layer.set_filter(filter.ToSKImageFilter());
            PushLayer(layer);
        }

        public void PushShaderMask(
            SKShader skShader,
            double maskRectLeft,
            double maskRectRight,
            double maskRectTop,
            double maskRectBottom,
            int blendMode)
        {
            var rect = new SKRect((float)maskRectLeft, (float)maskRectTop, (float)maskRectRight, (float)maskRectBottom);
            var layer = new ShaderMaskLayer();
            layer.set_shader(skShader);
            layer.set_mask_rect(rect);
            layer.set_blend_mode((SKBlendMode)blendMode);
            PushLayer(layer);
        }

        public NativeEngineLayer PushPhysicalShape(
            Path path,
            double elevation,
            int color,
            int shadowColor,
            int clipBehavior)
        {
            SKPath sk_path = path;
            var clip_behavior = (Flow.Layers.Clip)clipBehavior;
            var layer = new PhysicalShapeLayer(clip_behavior);
            layer.set_path(sk_path);
            layer.set_elevation((float)elevation);
            layer.set_color((uint)color);
            layer.set_shadow_color((uint)shadowColor);

            // TODO: Pixel Ratio
            //layer.set_device_pixel_ratio(UIDartState::Current()->window()->viewport_metrics().device_pixel_ratio);

            PushLayer(layer);
            return NativeEngineLayer.MakeRetained(layer);
        }

        public void AddRetained(NativeEngineLayer retainedLayer)
        {
            current_layer_?.Add(retainedLayer.Layer);
        }

        public void Pop()
        {
            if (current_layer_ == null)
                return;
            current_layer_ = current_layer_.parent();
        }

        public void AddPerformanceOverlay(
            UInt64 enabledOptions,
            double left,
            double right,
            double top,
            double bottom)
        {
            if (current_layer_ == null)
                return;

            var rect = new SKRect((float)left, (float)top, (float)right, (float)bottom);
            var layer = new PerformanceOverlayLayer(enabledOptions);
            layer.set_paint_bounds(rect);

            current_layer_.Add(layer);
        }

        public void AddPicture(double dx, double dy, SKPicture picture, int hints)
        {
            if (current_layer_ == null)
                return;

            SKPoint offset = new SKPoint((float)dx, (float)dy);
            SKRect pictureRect = picture.CullRect;
            pictureRect.Offset(offset.X, offset.Y);
            var layer = new PictureLayer();
            layer.set_offset(offset);
            layer.set_picture(picture);
            layer.set_is_complex((hints & 1) == 1);
            layer.set_will_change((hints & 2) == 2);
            current_layer_.Add(layer);
        }

        public void AddTexture(
            double dx,
            double dy,
            double width,
            double height,
            Int64 textureId,
            bool freeze)
        {
            if (current_layer_ == null)
                return;

            var layer = new TextureLayer();
            layer.set_offset(new SKPoint((float)dx, (float)dy));
            layer.set_size(new SKSize((float)width, (float)height));
            layer.set_texture_id((ulong)textureId);
            layer.set_freeze(freeze);
            current_layer_.Add(layer);
        }

        public void AddPlatformView(
            double dx,
            double dy,
            double width,
            double height,
            Int64 viewId)
        {
            if (current_layer_ == null)
                return;

            var layer = new PlatformViewLayer();
            layer.set_offset(new SKPoint((float)dx, (float)dy));
            layer.set_size(new SKSize((float)width, (float)height));
            layer.set_view_id((ulong)viewId);
            current_layer_.Add(layer);
        }

        public void AddChildScene(
            double dx,
            double dy,
            double width,
            double height,
            SceneHost sceneHost,
            bool hitTestable)
        {
            #if OS_FUCHSIA
              if (!current_layer_) {
                return;
              }
              auto layer = std::make_unique<flow::ChildSceneLayer>();
              layer->set_offset(SkPoint::Make(dx, dy));
              layer->set_size(SkSize::Make(width, height));
              layer->set_export_node_holder(sceneHost->export_node_holder());
              layer->set_hit_testable(hitTestable);
              current_layer_->Add(std::move(layer));
            #endif // defined(OS_FUCHSIA)
        }

        public void SetRasterizerTracingThreshold(UInt32 frameInterval)
        {
            rasterizer_tracing_threshold_ = frameInterval;
        }

        public void SetCheckerboardRasterCacheImages(bool checkerboard)
        {
            checkerboard_raster_cache_images_ = checkerboard;
        }

        public void SetCheckerboardOffscreenLayers(bool checkerboard)
        {
            checkerboard_offscreen_layers_ = checkerboard;
        }

        public Scene Build()
        {
            var scene = new Scene(
                root_layer_,
                rasterizer_tracing_threshold_,
                checkerboard_raster_cache_images_,
                checkerboard_offscreen_layers_);

            return scene;
        }

        protected void PushLayer(ContainerLayer layer)
        {
            if (root_layer_ == null)
            {
                root_layer_    = layer;
                current_layer_ = root_layer_;
                return;
            }

            if (current_layer_ == null)
            {
                return;
            }

            ContainerLayer newLayer = layer;
            current_layer_.Add(layer);
            current_layer_ = newLayer;
        }


        private ContainerLayer root_layer_;
        private ContainerLayer current_layer_;

        uint rasterizer_tracing_threshold_ = 0;
        bool checkerboard_raster_cache_images_ = false;
        bool checkerboard_offscreen_layers_ = false;
    }
}
