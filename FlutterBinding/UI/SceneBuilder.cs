using System;
using System.Collections.Generic;
using FlutterBinding.Engine.Painting;
using FlutterBinding.Flow.Layers;
using SkiaSharp;

namespace FlutterBinding.UI
{
    /// <summary>
    /// Builds a [Scene] containing the given visuals.
    ///
    /// A [Scene] can then be rendered using [Window.render].
    ///
    /// To draw graphical operations onto a [Scene], first create a
    /// [Picture] using a [PictureRecorder] and a [Canvas], and then add
    /// it to the scene using [addPicture].
    /// </summary>
    public class SceneBuilder
    {
        /// Creates an empty [SceneBuilder] object.
        public SceneBuilder() { }

        /// Pushes a transform operation onto the operation stack.
        ///
        /// The objects are transformed by the given matrix before rasterization.
        ///
        /// See [pop] for details about the operation stack.
        public void PushTransform(List<double> matrix4)
        {
            if (matrix4 == null)
                throw new ArgumentException("'matrix4' argument cannot be null");
            if (matrix4.Count != 16)
                throw new ArgumentException("'matrix4' must have 16 entries.");

            var skMatrix = Matrix.ToSkMatrix(matrix4);
            var layer = new TransformLayer();
            layer.set_transform(skMatrix);
            PushLayer(layer);
        }

        /// Pushes an offset operation onto the operation stack.
        ///
        /// This is equivalent to [pushTransform] with a matrix with only translation.
        ///
        /// See [pop] for details about the operation stack.
        public void PushOffset(double dx, double dy)
        {
            SKMatrix skMatrix = SKMatrix.MakeTranslation((float)dx, (float)dy);
            var layer = new TransformLayer();
            layer.set_transform(skMatrix);
            PushLayer(layer);
        }

        /// Pushes a rectangular clip operation onto the operation stack.
        ///
        /// Rasterization outside the given rectangle is discarded.
        ///
        /// See [pop] for details about the operation stack, and [Clip] for different clip modes.
        /// By default, the clip will be anti-aliased (clip = [Clip.antiAlias]).
        public void PushClipRect(Rect rect, Clip clipBehavior = Clip.AntiAlias)
        {
            //assert(clipBehavior != null);
            //assert(clipBehavior != Clip.none);

            var clipRect = new SKRect((float)rect.left, (float)rect.top, (float)rect.right, (float)rect.bottom);
            var layer = new ClipRectLayer(clipBehavior);
            layer.set_clip_rect(clipRect);
            PushLayer(layer);
        }

        /// Pushes a rounded-rectangular clip operation onto the operation stack.
        ///
        /// Rasterization outside the given rounded rectangle is discarded.
        ///
        /// See [pop] for details about the operation stack, and [Clip] for different clip modes.
        /// By default, the clip will be anti-aliased (clip = [Clip.antiAlias]).
        public void PushClipRRect(RRect rrect, Clip clipBehavior = Clip.AntiAlias)
        {
            //assert(clipBehavior != null);
            //assert(clipBehavior != Clip.none);

            var layer = new ClipRRectLayer(clipBehavior);
            layer.SetClipRRect(rrect.ToRoundedRect());
            PushLayer(layer);
        }

        /// Pushes a path clip operation onto the operation stack.
        ///
        /// Rasterization outside the given path is discarded.
        ///
        /// See [pop] for details about the operation stack. See [Clip] for different clip modes.
        /// By default, the clip will be anti-aliased (clip = [Clip.antiAlias]).
        public void PushClipPath(Path path, Clip clipBehavior = Clip.AntiAlias)
        {
            //assert(clipBehavior != null);
            //assert(clipBehavior != Clip.none);

            // FML_DCHECK(clip_behavior != flow::Clip::none);
            var layer = new ClipPathLayer(clipBehavior);
            layer.SetClipPath(path);
            PushLayer(layer);

        }

        /// Pushes an opacity operation onto the operation stack.
        ///
        /// The given alpha value is blended into the alpha value of the objects'
        /// rasterization. An alpha value of 0 makes the objects entirely invisible.
        /// An alpha value of 255 has no effect (i.e., the objects retain the current
        /// opacity).
        ///
        /// See [pop] for details about the operation stack.
        public void PushOpacity(int alpha, Offset offset = null)
        {
            if (offset == null)
                offset = Offset.zero;

            var layer = new OpacityLayer();
            layer.set_alpha(alpha);
            layer.set_offset(new SKPoint((float)offset.dx, (float)offset.dy));
            PushLayer(layer);

        }

        /// Pushes a color filter operation onto the operation stack.
        ///
        /// The given color is applied to the objects' rasterization using the given
        /// blend mode.
        ///
        /// See [pop] for details about the operation stack.
        public void PushColorFilter(Color color, SKBlendMode blendMode)
        {
            var layer = new ColorFilterLayer();
            layer.set_color(color.Value);
            layer.set_blend_mode(blendMode);
            PushLayer(layer);
        }

        /// Pushes a backdrop filter operation onto the operation stack.
        ///
        /// The given filter is applied to the current contents of the scene prior to
        /// rasterizing the given objects.
        ///
        /// See [pop] for details about the operation stack.
        public void PushBackdropFilter(ImageFilter filter)
        {
            var layer = new BackdropFilterLayer();
            layer.set_filter(filter.ToSKImageFilter());
            PushLayer(layer);
        }

        /// Pushes a shader mask operation onto the operation stack.
        ///
        /// The given shader is applied to the object's rasterization in the given
        /// rectangle using the given blend mode.
        ///
        /// See [pop] for details about the operation stack.
        public void PushShaderMask(SKShader shader, Rect maskRect, SKBlendMode blendMode)
        {
            var rect = new SKRect((float)maskRect.left, (float)maskRect.top, (float)maskRect.right, (float)maskRect.bottom);
            var layer = new ShaderMaskLayer();
            layer.set_shader(shader);
            layer.set_mask_rect(rect);
            layer.set_blend_mode(blendMode);
            PushLayer(layer);

        }

        /// Pushes a physical layer operation for an arbitrary shape onto the
        /// operation stack.
        ///
        /// By default, the layer's content will not be clipped (clip = [Clip.none]).
        /// If clip equals [Clip.hardEdge], [Clip.antiAlias], or [Clip.antiAliasWithSaveLayer],
        /// then the content is clipped to the given shape defined by [path].
        ///
        /// If [elevation] is greater than 0.0, then a shadow is drawn around the layer.
        /// [shadowColor] defines the color of the shadow if present and [color] defines the
        /// color of the layer background.
        ///
        /// See [pop] for details about the operation stack, and [Clip] for different clip modes.
        // ignore: deprecated_member_use
        public void PushPhysicalShape(Path path, double elevation, Color color, Color shadowColor, Clip clipBehavior = Clip.None)
        {
            SKPath skPath = path;
            var layer = new PhysicalShapeLayer(clipBehavior);
            layer.set_path(skPath);
            layer.set_elevation((float)elevation);
            layer.set_color(color.Value);
            layer.set_shadow_color(shadowColor.Value);

            layer.set_device_pixel_ratio((float)Window.Instance.devicePixelRatio);
            //layer.set_device_pixel_ratio(UIDartState::Current()->window()->viewport_metrics().device_pixel_ratio);

            PushLayer(layer);
        }

        /// Ends the effect of the most recently pushed operation.
        ///
        /// Internally the scene builder maintains a stack of operations. Each of the
        /// operations in the stack applies to each of the objects added to the scene.
        /// Calling this function removes the most recently added operation from the
        /// stack.
        public void Pop()
        {
            if (_currentLayer == null)
                return;
            _currentLayer = _currentLayer.parent();
        }

        /// Add a retained engine layer subtree from previous frames.
        ///
        /// All the engine layers that are in the subtree of the retained layer will
        /// be automatically appended to the current engine layer tree.
        ///
        /// Therefore, when implementing a subclass of the [Layer] concept defined in
        /// the rendering layer of Flutter's framework, once this is called, there's
        /// no need to call [addToScene] for its children layers.
        public Layer AddRetained(Layer retainedLayer)
        {
            _currentLayer?.Add(retainedLayer);
            return retainedLayer;
        }

        /// Adds an object to the scene that displays performance statistics.
        ///
        /// Useful during development to assess the performance of the application.
        /// The enabledOptions controls which statistics are displayed. The bounds
        /// controls where the statistics are displayed.
        ///
        /// enabledOptions is a bit field with the following bits defined:
        ///  - 0x01: displayRasterizerStatistics - show GPU thread frame time
        ///  - 0x02: visualizeRasterizerStatistics - graph GPU thread frame times
        ///  - 0x04: displayEngineStatistics - show UI thread frame time
        ///  - 0x08: visualizeEngineStatistics - graph UI thread frame times
        /// Set enabledOptions to 0x0F to enable all the currently defined features.
        ///
        /// The "UI thread" is the thread that includes all the execution of
        /// the main Dart isolate (the isolate that can call
        /// [Window.render]). The UI thread frame time is the total time
        /// spent executing the [Window.onBeginFrame] callback. The "GPU
        /// thread" is the thread (running on the CPU) that subsequently
        /// processes the [Scene] provided by the Dart code to turn it into
        /// GPU commands and send it to the GPU.
        ///
        /// See also the [PerformanceOverlayOption] enum in the rendering library.
        /// for more details.
        // Values above must match constants in //engine/src/sky/compositor/performance_overlay_layer.h
        public void AddPerformanceOverlay(int enabledOptions, Rect bounds)
        {
            if (_currentLayer == null)
                return;

            var rect = new SKRect((float)bounds.left, (float)bounds.top, (float)bounds.right, (float)bounds.bottom);
            var layer = new PerformanceOverlayLayer((UInt64)enabledOptions);
            layer.set_paint_bounds(rect);

            _currentLayer.Add(layer);
        }

        /// Adds a [Picture] to the scene.
        ///
        /// The picture is rasterized at the given offset.
        public void AddPicture(Offset offset, SKPicture picture, bool isComplexHint = false, bool willChangeHint = false)
        {
            int hints = 0;
            if (isComplexHint)
                hints |= 1;
            if (willChangeHint)
                hints |= 2;

            if (_currentLayer == null)
                return;

            SKPoint skOffset = offset.ToPoint();
            SKRect pictureRect = picture.CullRect;
            pictureRect.Offset(skOffset.X, skOffset.Y);
            var layer = new PictureLayer();
            layer.set_offset(skOffset);
            layer.set_picture(picture);
            layer.set_is_complex((hints & 1) == 1);
            layer.set_will_change((hints & 2) == 2);

            _currentLayer.Add(layer);
        }

        /// Adds a backend texture to the scene.
        ///
        /// The texture is scaled to the given size and rasterized at the given offset.
        ///
        /// If `freeze` is true the texture that is added to the scene will not
        /// be updated with new frames. `freeze` is used when resizing an embedded
        /// Android view: When resizing an Android view there is a short period during
        /// which the framework cannot tell if the newest texture frame has the
        /// previous or new size, to workaround this the framework "freezes" the
        /// texture just before resizing the Android view and unfreezes it when it is
        /// certain that a frame with the new size is ready.
        public void AddTexture(int textureId, Offset offset = null, double width = 0.0, double height = 0.0, bool freeze = false)
        {
            if (offset == null)
                offset = Offset.zero;

            //assert(offset != null, 'Offset argument was null');

            if (_currentLayer == null)
                return;

            var layer = new TextureLayer();
            layer.set_offset(offset.ToPoint());
            layer.set_size(new SKSize((float)width, (float)height));
            layer.set_texture_id((ulong)textureId);
            layer.set_freeze(freeze);

            _currentLayer.Add(layer);
        }

        /// Adds a platform view (e.g an iOS UIView) to the scene.
        ///
        /// This is work in progress and is not currently supported on any platform.
        public void AddPlatformView(int viewId, Offset offset = null, double width = 0.0, double height = 0.0)
        {
            if (offset == null)
                offset = Offset.zero;
            //assert(offset != null, 'Offset argument was null');

            if (_currentLayer == null)
                return;

            var layer = new PlatformViewLayer();
            layer.set_offset(offset.ToPoint());
            layer.set_size(new SKSize((float)width, (float)height));
            layer.set_view_id((ulong)viewId);

            _currentLayer.Add(layer);
        }


        /// Sets a threshold after which additional debugging information should be recorded.
        ///
        /// Currently this interface is difficult to use by end-developers. If you're
        /// interested in using this feature, please contact [flutter-dev](https://groups.google.com/forum/#!forum/flutter-dev).
        /// We'll hopefully be able to figure out how to make this feature more useful
        /// to you.
        public void SetRasterizerTracingThreshold(int frameInterval)
        {
            _rasterizerTracingThreshold = (uint)frameInterval;
        }


        /// Sets whether the raster cache should checkerboard cached entries. This is
        /// only useful for debugging purposes.
        ///
        /// The compositor can sometimes decide to cache certain portions of the
        /// widget hierarchy. Such portions typically don't change often from frame to
        /// frame and are expensive to render. This can speed up overall rendering. However,
        /// there is certain upfront cost to constructing these cache entries. And, if
        /// the cache entries are not used very often, this cost may not be worth the
        /// speedup in rendering of subsequent frames. If the developer wants to be certain
        /// that populating the raster cache is not causing stutters, this option can be
        /// set. Depending on the observations made, hints can be provided to the compositor
        /// that aid it in making better decisions about caching.
        ///
        /// Currently this interface is difficult to use by end-developers. If you're
        /// interested in using this feature, please contact [flutter-dev](https://groups.google.com/forum/#!forum/flutter-dev).
        public void SetCheckerboardRasterCacheImages(bool checkerboard)
        {
            _checkerboardRasterCacheImages = checkerboard;
        }

        /// Sets whether the compositor should checkerboard layers that are rendered
        /// to offscreen bitmaps.
        ///
        /// This is only useful for debugging purposes.
        public void SetCheckerboardOffscreenLayers(bool checkerboard)
        {
            _checkerboardOffscreenLayers = checkerboard;
        }

        /// Finishes building the scene.
        ///
        /// Returns a [Scene] containing the objects that have been added to
        /// this scene builder. The [Scene] can then be displayed on the
        /// screen with [Window.render].
        ///
        /// After calling this function, the scene builder object is invalid and
        /// cannot be used further.
        public Scene Build()
        {
            var scene = Scene.Create(
                _rootLayer,
                _rasterizerTracingThreshold,
                _checkerboardRasterCacheImages,
                _checkerboardOffscreenLayers);

            return scene;
        }

        protected void PushLayer(ContainerLayer layer)
        {
            if (_rootLayer == null)
            {
                _rootLayer = layer;
                _currentLayer = _rootLayer;
                return;
            }

            if (_currentLayer == null)
            {
                return;
            }

            ContainerLayer newLayer = layer;
            _currentLayer.Add(layer);
            _currentLayer = newLayer;
        }


        private ContainerLayer _rootLayer;
        private ContainerLayer _currentLayer;

        uint _rasterizerTracingThreshold = 0;
        bool _checkerboardRasterCacheImages = false;
        bool _checkerboardOffscreenLayers = false;
    }
}