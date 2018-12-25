using SkiaSharp;

namespace Flutter.Framework.Engine.Painting
{
    public class NativePictureRecorder: SKPictureRecorder
    {

        protected SKCanvas Canvas;
        public void SetCanvas(SKCanvas canvas)
            => this.Canvas = canvas;

    }
}
