using System;
using FlutterBinding.UI;
using SkiaSharp;
using static FlutterBinding.Flow.Helper;

// Copyright 2017 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

namespace FlutterBinding.Flow
{

    public static class PaintUtils
    {
        private static SKShader CreateCheckerboardShader(SKColor c1, SKColor c2, int size)
        {
            SKBitmap bm = new SKBitmap(new SKImageInfo(size * 2, size * 2));
            bm.Erase(c1);
            bm.Erase(c2, new SKRectI(0,0,size,size));
            bm.Erase(c2, new SKRectI(size, size, 2*size, 2*size));
            return SKShader.CreateBitmap(bm, SKShaderTileMode.Repeat, SKShaderTileMode.Repeat); 
        }

        public static void DrawCheckerboard(SKCanvas canvas, SKColor c1, SKColor c2, int size)
        {
            SKPaint paint = new SKPaint
            {
                Shader = CreateCheckerboardShader(c1, c2, size)
            };
            canvas.DrawPaint(paint);
        }

        public static void DrawCheckerboard(Canvas canvas, Rect rect)
        {
            DrawCheckerboard(canvas.SKCanvas, rect.ToSKRect());
        }

        public static void DrawCheckerboard(SKCanvas canvas, SKRect rect)
        {
            var rnd = new Random();
            // Draw a checkerboard
            canvas.Save();
            canvas.ClipRect(rect);

            var checkerboard_color = new SKColor((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256), 64);

            DrawCheckerboard(canvas, checkerboard_color, 0x00000000, 12);
            canvas.Restore();

            // Stroke the drawn area
            SKPaint debugPaint = new SKPaint
            {
                StrokeWidth = 8,
                Style = SKPaintStyle.Stroke,
                Color = new SKColor(checkerboard_color.Red, checkerboard_color.Green, checkerboard_color.Blue, 255)
            };
            canvas.DrawRect(rect, debugPaint);
        }
    }


}