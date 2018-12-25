using SkiaSharp;

namespace Flutter.Framework.Engine.Painting
{
    public class NativePathMetric: SKPathMeasure
    {
        public NativePathMetric(SKPath path, bool forceClosed = false, float resScale = 1) : base(path, forceClosed, resScale)
        { }

    }
}
