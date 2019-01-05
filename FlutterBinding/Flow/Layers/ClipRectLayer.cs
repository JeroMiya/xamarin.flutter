using FlutterBinding.UI;
using SkiaSharp;
using static FlutterBinding.Flow.Helper;

// Copyright 2015 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

namespace FlutterBinding.Flow.Layers
{
    public class ClipRectLayer : ContainerLayer
    {
        public ClipRectLayer(Clip clip_behavior)
        {
            _clipBehavior = clip_behavior;
        }

        public void set_clip_rect(SKRect clip_rect)
        {
            _clipRect = clip_rect;
        }

        public override void Preroll(PrerollContext context, SKMatrix matrix)
        {
            SKRect child_paint_bounds = SKRect.Empty;
            PrerollChildren(context, matrix, ref child_paint_bounds);

            if (child_paint_bounds.IntersectsWith(_clipRect))
            {
                set_paint_bounds(child_paint_bounds);
            }
        }

        public override void Paint(PaintContext context)
        {
            TRACE_EVENT0("flutter", "ClipRectLayer::Paint");
            FML_DCHECK(needs_painting());

            context.canvas.ClipRect(paint_bounds(), antialias: _clipBehavior != Clip.HardEdge);
            if (_clipBehavior == Clip.AntiAliasWithSaveLayer)
            {
                context.canvas.SaveLayer(paint_bounds(), null);
            }

            PaintChildren(context);
            if (_clipBehavior == Clip.AntiAliasWithSaveLayer)
            {
                context.canvas.Restore();
            }
        }

        private SKRect _clipRect = new SKRect();
        private readonly Clip _clipBehavior;
    }
}
