using System.Collections.Generic;
using SkiaSharp;

namespace FlutterBinding.UI
{
    public static class Helper
    {
        public static SKPoint ToPoint(this Offset offset) => new SKPoint((float)offset.dx, (float)offset.dy);

        public static List<SKPoint> ToPoints(this List<Offset> offset)
        {
            var list = new List<SKPoint>();
            foreach (var point in offset)
                list.Add(point.ToPoint());

            return list;
        }

        public static List<SKColor> ToColors(this List<Color> colors)
        {
            var list = new List<SKColor>();

            foreach (var color in colors)
                list.Add(new SKColor(color.Value));

            return list;
        }

        public static SKRect ToSKRect(this Rect rect)
            => new SKRect((float)rect.left, (float)rect.top, (float)rect.right, (float)rect.bottom);

        public static SKRectI ToSKRectI(this Rect rect)
            => new SKRectI((int)rect.left, (int)rect.top, (int)rect.right, (int)rect.bottom);

        public static SKRoundRect ToRoundedRect(this RRect rect)
            => new SKRoundRect(new SKRect((float)rect.left, (float)rect.top, (float)rect.right, (float)rect.bottom), (float)rect.blRadiusX, (float)rect.blRadiusY);
    }
}