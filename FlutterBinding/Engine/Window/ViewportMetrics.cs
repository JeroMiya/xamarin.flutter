using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterBinding.Engine.Window
{
    public class ViewportMetrics
    {
        public double device_pixel_ratio = 1.0;
        public double physical_width = 0;
        public double physical_height = 0;
        public double physical_padding_top = 0;
        public double physical_padding_right = 0;
        public double physical_padding_bottom = 0;
        public double physical_padding_left = 0;
        public double physical_view_inset_top = 0;
        public double physical_view_inset_right = 0;
        public double physical_view_inset_bottom = 0;
        public double physical_view_inset_left = 0;
    };

    public class LogicalSize
    {
        public double width = 0.0;
        public double height = 0.0;
    };

    public class LogicalInset
    {
        public double left = 0.0;
        public double top = 0.0;
        public double right = 0.0;
        public double bottom = 0.0;
    };

    public class LogicalMetrics
    {
        public LogicalSize size;
        public double scale = 1.0;
        public LogicalInset padding;
        public LogicalInset view_inset;
    };
}
