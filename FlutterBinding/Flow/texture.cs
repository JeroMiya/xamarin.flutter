using SkiaSharp;
using System.Collections.Generic;

// Copyright 2017 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

namespace FlutterBinding.Flow
{
    public abstract class Texture
    {
        protected Texture(long id)
        {
            Id = id;
        }

        // Called from GPU thread.
        public abstract void Paint(SKCanvas canvas, SKRect bounds, bool freeze);

        // Called from GPU thread.
        public abstract void OnGRContextCreated();

        // Called from GPU thread.
        public abstract void OnGRContextDestroyed();

        // Called on GPU thread.
        public abstract void MarkNewFrameAvailable();

        public long Id { get; }
    }

    public class TextureRegistry
    {
        // Called from GPU thread.
        public void RegisterTexture(Texture texture)
        {
            _mapping[texture.Id] = texture;
        }

        // Called from GPU thread.
        public void UnregisterTexture(long id)
        {
            _mapping.Remove(id);
        }

        // Called from GPU thread.
        public Texture GetTexture(long id)
        {
            return _mapping[id];
        }

        // Called from GPU thread.
        public void OnGRContextCreated()
        {
            foreach (KeyValuePair<long, Texture> pair in _mapping)
                pair.Value.OnGRContextCreated();
        }

        // Called from GPU thread.
        public void OnGRContextDestroyed()
        {
            foreach (KeyValuePair<long, Texture> pair in _mapping)
                pair.Value.OnGRContextDestroyed();
        }

        private readonly SortedDictionary<long, Texture> _mapping = new SortedDictionary<long, Texture>();
    }
}
