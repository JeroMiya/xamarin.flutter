using FlutterBinding.UI;
using SkiaSharp;
using static FlutterBinding.Flow.Helper;

// Copyright 2015 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

namespace FlutterBinding.Flow.Layers
{
    public class ClipPathLayer : ContainerLayer
    {
        public ClipPathLayer(Clip clipBehavior = Clip.AntiAlias)
        {
            _clipBehavior = clipBehavior;
        }

        public void SetClipPath(SKPath clipPath)
        {
            _clipPath = clipPath;
        }

        public override void Preroll(PrerollContext context, SKMatrix matrix)
        {
            SKRect childPaintBounds = SKRect.Empty;
            PrerollChildren(context, matrix, ref childPaintBounds);

            if (childPaintBounds.IntersectsWith(_clipPath.Bounds))
                set_paint_bounds(childPaintBounds);
        }

        public override void Paint(PaintContext context)
        {
            TRACE_EVENT0("flutter", "ClipPathLayer::Paint");
            FML_DCHECK(needs_painting());

            context.canvas.ClipPath(_clipPath, antialias: _clipBehavior != Clip.HardEdge);
            if (_clipBehavior == Clip.AntiAliasWithSaveLayer)
                context.canvas.SaveLayer(paint_bounds(), null);

            PaintChildren(context);
            if (_clipBehavior == Clip.AntiAliasWithSaveLayer)
                context.canvas.Restore();
        }

        private SKPath _clipPath = new SKPath();
        private readonly Clip _clipBehavior;
    }
}
