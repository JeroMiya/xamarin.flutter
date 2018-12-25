using SkiaSharp;

namespace FlutterBinding.Engine.Painting
{
    public class NativeCanvas
    {
        protected SKCanvas _canvas;

        internal SKCanvas SKCanvas => _canvas;

        public void Constructor(SKPictureRecorder recorder,
                          double left,
                          double top,
                          double right,
                          double bottom)
        {
            _canvas = recorder.BeginRecording(new SKRect((float)left, (float)top, (float)right, (float)bottom));
        }


    }
}