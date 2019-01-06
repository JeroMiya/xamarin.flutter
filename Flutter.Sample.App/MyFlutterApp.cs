using System;
using System.Collections.Generic;
using System.Text;
using FlutterBinding.Flow;
using FlutterBinding.UI;
using SkiaSharp;
using SKPaintStyle = SkiaSharp.SKPaintStyle;

namespace Flutter.Sample.App
{
    public class MyFlutterApp
    {
        public Scene CreateScene()
        {
            var window = FlutterBinding.UI.Window.Instance;

            double devicePixelRatio = window.DevicePixelRatio;
            var physicalSize = window.PhysicalSize;
            var logicalSize = physicalSize / devicePixelRatio;

            var paragraphBuilder = new ParagraphBuilder(new ParagraphStyle());
            paragraphBuilder.addText("Hello, world!");
            var paragraph = paragraphBuilder.build();

            paragraph.Layout(new ParagraphConstraints(width: logicalSize.width));

            var physicalBounds = Offset.zero & physicalSize;
            var recorder = new SKPictureRecorder();

            var canvas = new Canvas(recorder, physicalBounds);
            canvas.Scale((float)devicePixelRatio, (float)devicePixelRatio);

            PaintUtils.DrawCheckerboard(canvas, Rect.fromLTWH(0, 0, (float)physicalSize.width, (float)physicalSize.height));

            var circlePaint = new SKPaint
            {
                Style       = SKPaintStyle.Stroke,
                IsAntialias = true,
                StrokeWidth = 3,
                Color       = SKColors.OrangeRed
            };
            canvas.DrawCircle(new Offset(logicalSize.width / 2, logicalSize.height / 2), 100, circlePaint);

            canvas.DrawParagraph(paragraph, new Offset(
                (logicalSize.width - Paragraph.MaxIntrinsicWidth) / 2.0,
                (logicalSize.height - paragraph.Height) / 2.0));

            var picture = recorder.EndRecording();

            var sceneBuilder = new SceneBuilder();
            sceneBuilder.PushClipRect(physicalBounds);
            sceneBuilder.AddPicture(Offset.zero, picture);
            sceneBuilder.Pop();

            var scene = sceneBuilder.Build();
            return scene;
        }

    }
}
