using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterBinding.Engine.Painting
{
    public class NativeCanvas
    {
        public NativeCanvas(SKBitmap bitmap) { }

        public SKCanvas RecordingCanvas { get; set; }

        public void Constructor(SKPictureRecorder recorder,
                          double left,
                          double top,
                          double right,
                          double bottom)
        {
            var canvas = recorder.BeginRecording(new SKRect((float)left, (float)top, (float)right, (float)bottom));
            RecordingCanvas = canvas;
        }


    }
}