namespace FlutterBinding.Shell
{
    public class LogicalSize
    {
        public double Width = 0.0;
        public double Height = 0.0;
    };

    public class LogicalInset
    {
        public double Left = 0.0;
        public double Top = 0.0;
        public double Right = 0.0;
        public double Bottom = 0.0;
    };

    public class LogicalMetrics
    {
        public LogicalSize Size;
        public double Scale = 1.0;
        public LogicalInset Padding;
        public LogicalInset ViewInset;
    };

    public class ViewportMetrics
    {
        public float DevicePixelRatio = 1.0f;
        public int PhysicalWidth = 0;
        public int PhysicalHeight = 0;
        public int PhysicalPaddingTop = 0;
        public int PhysicalPaddingRight = 0;
        public int PhysicalPaddingBottom = 0;
        public int PhysicalPaddingLeft = 0;
        public int PhysicalViewInsetTop = 0;
        public int PhysicalViewInsetRight = 0;
        public int PhysicalViewInsetBottom = 0;
        public int PhysicalViewInsetLeft = 0;
    }
}
