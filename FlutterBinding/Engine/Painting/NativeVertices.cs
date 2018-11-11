using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlutterBinding.Mapping;
using SkiaSharp;

namespace FlutterBinding.Engine.Painting
{
    public class NativeVertices
    {
        private SKVertices _vertices;

        protected NativeVertices() { }

        public static NativeVertices Create()
        {
            return new NativeVertices();
        }

        public void init(
            SKVertexMode vertex_mode,
            Float32List  positions,
            Float32List  texture_coordinates,
            Int32List    colors,
            Int32List    indices)
        {
            var points = new List<SKPoint>(positions.Count / 2);
            for (var i = 0; i < positions.Count; i += 2)
                points.Add(new SKPoint { X = (float)positions[i], Y = (float)positions[i + 1] });

            var coords = new List<SKPoint>(texture_coordinates.Count / 2);
            for (var i = 0; i < texture_coordinates.Count; i += 2)
                coords.Add(new SKPoint { X = (float)texture_coordinates[i], Y = (float)texture_coordinates[i + 1] });

            var skColors  = colors?.Select(c => new SKColor((uint)c)).ToArray();
            var skIndices = indices?.Select(i => (ushort)i).ToArray();

            _vertices = SKVertices.CreateCopy(
                vertex_mode,
                points.Count > 0 ? points.ToArray() : null,
                coords.Count > 0 ? coords.ToArray() : null,
                skColors,
                skIndices);
        }

        public SKVertices ToSKVertices()
        {
            return _vertices;
        }
    }
}
