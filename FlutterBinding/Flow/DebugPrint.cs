using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;

namespace FlutterBinding.Flow
{
    public static class DebugPrint
    {
        public static string Debug(this SKMatrix m)
        {
            return 
                $"[{m.ScaleX:8.4f} {m.SkewX:8.4f} {m.TransX:8.4f}]" + 
                $"[{m.ScaleY:8.4f} {m.SkewY:8.4f} {m.TransY:8.4f}]" + 
                $"[{m.Persp0:8.4f} {m.Persp1:8.4f} {m.Persp2:8.4f}]";
        }

        public static string Debug(this SKMatrix44 m)
        {
            return 
                $"{m[0, 0]}, {m[0, 1]}, {m[0, 2]}, {m[0, 3]}\n" +
                $"{m[1, 0]}, {m[1, 1]}, {m[1, 2]}, {m[1, 3]}\n" +
                $"{m[2, 0]}, {m[2, 1]}, {m[2, 2]}, {m[2, 3]}\n" +
                $"{m[3, 0]}, {m[3, 1]}, {m[3, 2]}, {m[3, 3]}\n";
        }

        public static string Debug(this SKRect value)
        {
            return $"LTRB: {value.Left}, {value.Top}, {value.Right}, {value.Bottom}";
        }

        public static string Debug(this SKRoundRect value)
        {
            return value.Rect.Debug();
        }

        public static string Debug(this SKPoint value)
        {
            return $"XY: {value.X}, {value.Y}";
        }

        public static string Debug(this SKSizeI value)
        {
            return $"WH: {value.Width}, {value.Height}";
        }
    }
}
