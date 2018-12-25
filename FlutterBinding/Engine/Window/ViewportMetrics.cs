namespace FlutterBinding.Engine.Window
{
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
