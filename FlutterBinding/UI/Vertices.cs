using System;
using System.Collections.Generic;
using System.Linq;
using SkiaSharp;

namespace FlutterBinding.UI
{
    /// A set of vertex data used by [Canvas.drawVertices].
    public class Vertices
    {
        public static SKVertices Raw(
            SKVertexMode mode,
            List<Offset> positions,
            List<Offset> textureCoordinates = null,
            List<Color> colors = null,
            List<int> indices = null)
        {
            //assert(mode != null),
            //assert(positions != null)
            if (textureCoordinates != null && textureCoordinates.Count != positions.Count)
                throw new ArgumentException("'positions' and 'textureCoordinates' lengths must match.");
            if (colors != null && colors.Count != positions.Count)
                throw new ArgumentException("'positions' and 'colors' lengths must match.");
            if (indices != null && indices.Any((int i) => i < 0 || i >= positions.Count))
                throw new ArgumentException("'indices' values must be valid indices in the positions list.");


            var positionList = new List<SKPoint>();
            foreach (var p in positions)
                positionList.Add(p.ToPoint());

            List<SKPoint> textureList = null;
            if (textureCoordinates != null)
            {
                textureList = new List<SKPoint>();
                foreach (var t in textureCoordinates)
                    textureList.Add(t.ToPoint());
            }

            return SKVertices.CreateCopy(
                mode, 
                positionList.ToArray(), 
                textureList?.ToArray(), 
                colors.ToColors().ToArray(), 
                indices?.Cast<ushort>().ToArray());
        }
    }
}