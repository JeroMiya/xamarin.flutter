using System.Collections.Generic;
using System.Linq;
using SkiaSharp;

namespace FlutterBinding.Extensions
{
    public static class MatrixExtensions
    {
        // Mappings from SkMatrix-index to input-index.
        private static int[] kSkMatrixIndexToMatrix4Index = new int[]
        {
            // clang-format off
            0, 4, 12,
            1, 5, 13,
            3, 7, 15,
            // clang-format on
        };

        public static SKMatrix ToSkMatrix(this List<float> matrix4)
        {
            return ToSkMatrix(matrix4.Cast<double>().ToList());
        }

        public static SKMatrix ToSkMatrix(this List<double> matrix4)
        {
            SKMatrix skMatrix = new SKMatrix();
            for (int i = 0; i < 9; ++i)
            {
                int matrix4Index = kSkMatrixIndexToMatrix4Index[i];
                if (matrix4Index < matrix4.Count)
                    skMatrix.Values[i] = (float)matrix4[matrix4Index];
                else
                    skMatrix.Values[i] = 0.0f;
            }

            return skMatrix;
        }
    }
}
