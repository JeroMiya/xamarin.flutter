using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SkiaSharp;

namespace FlutterBinding.Flow.Layers
{
    public class PerformanceOverlayLayer : Layer
    {
        const int kDisplayRasterizerStatistics = 1 << 0;
        const int kVisualizeRasterizerStatistics = 1 << 1;
        const int kDisplayEngineStatistics = 1 << 2;
        const int kVisualizeEngineStatistics = 1 << 3;

        private readonly UInt64 _options;

        public static void DrawStatisticsText(SKCanvas canvas, string str, int x, int y)
        {
            SKPaint paint = new SKPaint
            {
                TextSize = 15,
                IsLinearText = false,
                Color = SKColors.Gray
            };
            canvas.DrawText(str, x, y, paint);
        }

        public static void VisualizeStopWatch(
            SKCanvas canvas, 
            Flow.Stopwatch stopwatch, 
            float x,
            float y,
            float width,
            float height,
            bool show_graph,
            bool show_labels,
            string label_prefix)
        {
            const int label_x = 8;   // distance from x
            const int label_y = -10; // distance from y+height

            if (show_graph)
            {
                var visualization_rect = SKRect.Create(x, y, width, height);
                stopwatch.Visualize(canvas, visualization_rect);
            }

            if (show_labels)
            {
                double ms_per_frame = stopwatch.MaxDelta().TotalMilliseconds;
                double fps;
                if (ms_per_frame < Stopwatch.kOneFrameMS)
                {
                    fps = 1e3 / Stopwatch.kOneFrameMS;
                }
                else
                {
                    fps = 1e3 / ms_per_frame;
                }

                var str = $"{label_prefix} {fps:F1} fps {ms_per_frame}ms/frame";
                DrawStatisticsText(canvas, str, (int)(x + label_x), (int)(y + height + label_y));
            }
        }

        public PerformanceOverlayLayer(UInt64 options)
        {
            _options = options;
        }

        /// <inheritdoc />
        public override void Paint(PaintContext context)
        {
            const int padding = 8;

            if (_options == 0)
                return;

            //TRACE_EVENT0("flutter", "PerformanceOverlayLayer::Paint");

            float x = paint_bounds().Left + padding;
            float y = paint_bounds().Top + padding;
            float width = paint_bounds().Width - (padding * 2);
            float height = paint_bounds().Height / 2;

            context.canvas.Save();

            using (new SKAutoCanvasRestore(context.canvas, true))
            {
                VisualizeStopWatch(
                    context.canvas,
                    context.frame_time,
                    x,
                    y,
                    width,
                    height - padding,
                    (_options & kVisualizeRasterizerStatistics) != 0,
                    (_options & kDisplayRasterizerStatistics) != 0,
                    "GPU");

                VisualizeStopWatch(
                    context.canvas,
                    context.engine_time,
                    x,
                    y + height,
                    width,
                    height - padding,
                    (_options & kVisualizeEngineStatistics) != 0,
                    (_options & kDisplayEngineStatistics) != 0,
                    "UI");
            }
        }
    }
}
