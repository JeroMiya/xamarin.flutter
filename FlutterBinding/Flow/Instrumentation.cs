using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using SkiaSharp;

namespace FlutterBinding.Flow
{
    public class Stopwatch
    {
        public const float kOneFrameMS = 1e3f / 60.0f;
        public const int kMaxSamples = 120;
        public const int kMaxFrameMarkers = 8;

        private DateTime start_;
        private List<TimeSpan> laps_;
        private int current_sample_;

        // Mutable data cache for performance optimization of the graphs. Prevents
        // expensive redrawing of old data.
        private bool cache_dirty_;
        private SKSurface visualize_cache_surface_;
        private int prev_drawn_sample_index_;

        public Stopwatch()
        {
            start_       = DateTime.Now;
            laps_        = new List<TimeSpan>(kMaxSamples);
            cache_dirty_ = true;
        }

        public TimeSpan LastLap()
        {
            return laps_[(current_sample_ - 1) % kMaxSamples];
        }

        public TimeSpan CurrentLap() => DateTime.Now - start_;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float UnitFrameInterval(float frame_time_ms)
        {
            return frame_time_ms * 60.0f * 1e-3f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float UnitHeight(float frame_time_ms, float max_unit_interval)
        {
            var unitHeight = UnitFrameInterval(frame_time_ms) / max_unit_interval;
            if (unitHeight > 1.0)
                unitHeight = 1.0f;
            return unitHeight;
        }

        public TimeSpan MaxDelta()
        {
            var maxDelta = TimeSpan.Zero;
            for (int i = 0; i < kMaxSamples; i++)
            {
                if (laps_[i] > maxDelta)
                    maxDelta = laps_[i];
            }

            return maxDelta;
        }

        public void InitVisualizeSurface(SKRect rect)
        {
            if (!cache_dirty_)
                return;
            cache_dirty_ = false;

            // TODO(garyq): Use a GPU surface instead of a CPU surface.
            visualize_cache_surface_ = SKSurface.Create(
                (int)rect.Width,
                (int)rect.Height,
                SKColorType.Rgba8888,
                SKAlphaType.Premul);

            var cache_canvas = visualize_cache_surface_.Canvas;

            // Establish the graph position.
            float x = 0;
            float y = 0;
            float width = rect.Width;
            float height = rect.Height;

            var paint = new SKPaint {Color = new SKColor(0x99FFFFFF)};
            cache_canvas.DrawRect(SKRect.Create(x, y, width, height), paint);

            // Scale the graph to show frame times up to those that are 3 times the frame
            // time.
            float max_interval = kOneFrameMS * 3.0f;
            float max_unit_interval = UnitFrameInterval(max_interval);

            // Draw the old data to initially populate the graph.
            // Prepare a path for the data. We start at the height of the last point, so
            // it looks like we wrap around
            var path = new SKPath();
            //path.setIsVolatile(true);
            path.MoveTo(x, height);
            path.LineTo(x, (float)(y + height * (1.0 - UnitHeight((float)laps_[0].TotalMilliseconds, max_unit_interval))));
            float unit_x;
            float unit_next_x = 0.0f;
            for (int i = 0; i < kMaxSamples; i += 1)
            {
                unit_x      = unit_next_x;
                unit_next_x = ((float)(i + 1) / kMaxSamples);
                float sample_y = y + height * (1.0f - UnitHeight((float)laps_[i].TotalMilliseconds, max_unit_interval));
                path.LineTo(x + width * unit_x, sample_y);
                path.LineTo(x + width * unit_next_x, sample_y);
            }

            path.LineTo(
                width,
                y + height * (1.0f - UnitHeight((float)laps_[kMaxSamples - 1].TotalMilliseconds, max_unit_interval)));
            path.LineTo(width, height);
            path.Close();

            // Draw the graph.
            paint.Color = new SKColor(0xAA0000FF);
            cache_canvas.DrawPath(path, paint);
        }

        public void Visualize(SKCanvas canvas, SKRect rect)
        {
            // Initialize visualize cache if it has not yet been initialized.
            InitVisualizeSurface(rect);

            var cache_canvas = visualize_cache_surface_.Canvas;
            var paint = new SKPaint();

            // Establish the graph position.
            float x = 0f;
            float y = 0f;
            float width = rect.Width;
            float height = rect.Height;

            // Scale the graph to show frame times up to those that are 3 times the frame
            // time.
            float max_interval = kOneFrameMS * 3.0f;
            float max_unit_interval = UnitFrameInterval(max_interval);

            float sample_unit_width = (1.0f / kMaxSamples);

            // Draw vertical replacement bar to erase old/stale pixels.
            paint.Color     = new SKColor(0x99FFFFFF);
            paint.Style     = SKPaintStyle.Fill;
            paint.BlendMode = SKBlendMode.Src;
            float sample_x = x + width * ((float)prev_drawn_sample_index_ / kMaxSamples);
            var eraser_rect = new SKRect(sample_x, y, sample_x + width * sample_unit_width, height);
            cache_canvas.DrawRect(eraser_rect, paint);

            // Draws blue timing bar for new data.
            paint.Color     = new SKColor(0xAA0000FF);
            paint.BlendMode = SKBlendMode.SrcOver;
            var bar_rect = new SKRect(
                sample_x,
                y + height *
                (1.0f - UnitHeight((float)laps_[current_sample_ == 0 ? kMaxSamples - 1 : current_sample_ - 1].TotalMilliseconds, max_unit_interval)),
                sample_x + width * sample_unit_width,
                height);
            cache_canvas.DrawRect(bar_rect, paint);

            // Draw horizontal frame markers.
            paint.StrokeWidth = 0; // hairline
            paint.Style       = SKPaintStyle.Stroke;
            paint.Color       = new SKColor(0xCC000000);

            if (max_interval > kOneFrameMS)
            {
                // Paint the horizontal markers
                int frame_marker_count = (int)(max_interval / kOneFrameMS);

                // Limit the number of markers displayed. After a certain point, the graph
                // becomes crowded
                if (frame_marker_count > kMaxFrameMarkers)
                    frame_marker_count = 1;

                for (int frame_index = 0; frame_index < frame_marker_count; frame_index++)
                {
                    float frame_height =
                        height * (1.0f - (UnitFrameInterval((frame_index + 1) * kOneFrameMS) / max_unit_interval));
                    cache_canvas.DrawLine(
                        x,
                        y + frame_height,
                        width,
                        y + frame_height,
                        paint);
                }
            }

            // Paint the vertical marker for the current frame.
            // We paint it over the current frame, not after it, because when we
            // paint this we don't yet have all the times for the current frame.
            paint.Style     = SKPaintStyle.Fill;
            paint.BlendMode = SKBlendMode.SrcOver;
            if (UnitFrameInterval((float)LastLap().TotalMilliseconds) > 1.0f)
            {
                // budget exceeded
                paint.Color = SKColors.Red;
            }
            else
            {
                // within budget
                paint.Color = SKColors.Green;
            }

            sample_x = x + width * ((float)current_sample_ / kMaxSamples);
            var marker_rect = new SKRect(
                sample_x,
                y,
                sample_x + width * sample_unit_width,
                height);
            cache_canvas.DrawRect(marker_rect, paint);
            prev_drawn_sample_index_ = current_sample_;

            // Draw the cached surface onto the output canvas.
            paint = new SKPaint();
            visualize_cache_surface_.Draw(canvas, rect.Left, rect.Top, paint);
        }

        public void Start()
        {
            start_          = DateTime.Now;
            current_sample_ = (current_sample_ + 1) % kMaxSamples;
        }

        public void Stop()
        {
            laps_[current_sample_] = DateTime.Now - start_;
        }

        public void SetLapTime(TimeSpan delta)
        {
            current_sample_        = (current_sample_ + 1) % kMaxSamples;
            laps_[current_sample_] = delta;
        }
    }
}
