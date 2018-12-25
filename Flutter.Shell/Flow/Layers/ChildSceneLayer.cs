using SkiaSharp;
using static FlutterBinding.Flow.Helper;

// Copyright 2016 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

namespace FlutterBinding.Flow.Layers
{

    // Layer that represents an embedded child.
    public class ChildSceneLayer : Layer
    {

        public void set_offset(SKPoint offset)
        {
            offset_ = offset;
        }

        public void set_size(SKSize size)
        {
            size_ = size;
        }

        public void set_hit_testable(bool hit_testable)
        {
            hit_testable_ = hit_testable;
        }

        public override void Preroll(PrerollContext context, SKMatrix matrix)
        {
            set_needs_system_composite(true);
        }

        public override void Paint(PaintContext context)
        {
           // FXL_NOTREACHED() << "This layer never needs painting.";
        }

        /*
        void UpdateScene(SceneUpdateContext context)
        {
            FML_DCHECK(needs_system_composite());

            // TODO(MZ-191): Set clip.
            // It's worth asking whether all children should be clipped implicitly
            // or whether we should leave this up to the Flutter application to decide.
            // In some situations, it might be useful to allow children to draw
            // outside of their layout bounds.
            if (export_node_holder_ != null)
            {
                context.AddChildScene(export_node_holder_.export_node(), offset_, hit_testable_);
            }
        }
        */

        private SKPoint offset_ = new SKPoint();
        private SKSize size_ = new SKSize();
        //ExportNodeHolder export_node_holder_;
        private bool hit_testable_ = true;
    }
}
