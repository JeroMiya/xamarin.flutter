using FlutterBinding.UI;
using System;
using System.Collections.Generic;
using SkiaSharp;

namespace FlutterBinding.Mapping
{
    public static class Helper
    {
        public static bool identical(object first, object second) => first.Equals(second);

        public static int hashValues(object first, object second, object third = null, object fourth = null, object fifth = null, object sixth = null, object seventh = null, object eigth = null, object ninth = null) => 0; // TODO:

        public static int hashList(List<double> list) => 0; // TODO:
        public static int hashList(List<int> list) => 0; // TODO:

        public static string toStringAsFixed(this double value, int points)
        {
            return value.ToString($"N{points}");
        }

        public static string toRadixString(this uint value, int places) => value.ToString(); // TODO:

        public static double round(this double value) => Math.Round(value);

        public static int toInt(this double value) => Convert.ToInt32(value);

        public static int clamp(this int value, int lower, int upper)
        {
            if (value > upper)
                return upper;

            if (value < lower)
                return lower;

            return value;
        }

        public static double clamp(this double value, int lower, int upper)
        {
            if (value > upper)
                return upper;

            if (value < lower)
                return lower;

            return value;
        }

        public static bool isFinite(this double value) => !double.IsInfinity(value);

        public static double abs(this double value) => Math.Abs(value);


        private static int[] kSkMatrixIndexToMatrix4Index =
        {
            0, 4, 12,
            1, 5, 13,
            3, 7, 15
        };

        public static SKMatrix ToSKMatrix(this Float64List matrix4)
        {
            // Mappings from SkMatrix-index to input-index.

            SKMatrix sk_matrix = new SKMatrix();
            for (int i = 0; i < 9; ++i)
            {
                int matrix4_index = kSkMatrixIndexToMatrix4Index[i];
                if (matrix4_index < matrix4.Count)
                    sk_matrix.Values[i] = matrix4[matrix4_index];
                else
                    sk_matrix.Values[i] = 0.0f;
            }
            return sk_matrix;

        }

        public static SKRoundRect ToSKRoundRect(this RRect rrect)
        {
            return new SKRoundRect( 
                new SKRect((float)rrect.left, (float)rrect.top, (float)rrect.right, (float)rrect.bottom),
                (float)rrect.tlRadiusX, 
                (float)rrect.tlRadiusY);
        }

        public static SKRect ToSKRect(this Rect rect)
        {
            return new SKRect((float)rect.left, (float)rect.top, (float)rect.right, (float)rect.bottom);
        }

        public static SKRectI ToSKRectI(this Rect rect)
        {
            return new SKRectI((int)rect.left, (int)rect.top, (int)rect.right, (int)rect.bottom);
        }

        public static SKPoint ToSKPoint(this Offset offset)
        {
            return new SKPoint((float)offset.dx, (float)offset.dy);
        }

        public static Future<T> _futurize<T>(Action<_Callback<T>> callback)
        {
            // Question, why is this so complicated for running a new Task.
            // Could be a Dart -> C# translation issue

            var result = default(T);

            var resolve = new _Callback<T>((t) => { result = t; });

            return new Future<T>(() => { return result; });
        }

        public static Future _futurize(Action<_Callback> callback)
        {
            // Question, why is this so complicated for running a new Task.
            // Could be a Dart -> C# translation issue

            var resolve = new _Callback(()=> { });

            return new Future(() => {  });
        }
    }
}
