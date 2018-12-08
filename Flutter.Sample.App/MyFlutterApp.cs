using System;
using System.Collections.Generic;
using System.Text;
using FlutterBinding.Flow;
using FlutterBinding.UI;
using SkiaSharp;
using Rect = FlutterSDK.Rect;

namespace Flutter.Sample.App
{
    public class MyFlutterApp
    {
        public Scene CreateScene()
        {
            var window = FlutterBinding.UI.Window.Instance;

            double devicePixelRatio = window.devicePixelRatio;
            var physicalSize = window.physicalSize;
            var logicalSize = physicalSize / devicePixelRatio;

            var paragraphBuilder = new ParagraphBuilder(new ParagraphStyle());
            paragraphBuilder.addText("Hello, world!");
            var paragraph = paragraphBuilder.build();

            paragraph.layout(new ParagraphConstraints(width: logicalSize.width));

            var physicalBounds = Offset.zero & physicalSize;
            var recorder = new PictureRecorder();

            var canvas = new FlutterBinding.UI.Canvas(recorder, physicalBounds);
            canvas.scale((float)devicePixelRatio, (float)devicePixelRatio);

            PaintUtils.DrawCheckerboard(canvas, Rect.fromLTWH(0, 0, (float)physicalSize.width, (float)physicalSize.height));

            var circlePaint = new SKPaint
            {
                Style       = SKPaintStyle.Stroke,
                IsAntialias = true,
                StrokeWidth = 3,
                Color       = SKColors.OrangeRed
            };
            canvas.drawCircle(new Offset(logicalSize.width / 2, logicalSize.height / 2), 100, circlePaint);

            canvas.drawParagraph(paragraph, new Offset(
                (logicalSize.width - paragraph.maxIntrinsicWidth) / 2.0,
                (logicalSize.height - paragraph.height) / 2.0));

            var picture = recorder.endRecording();

            var sceneBuilder = new SceneBuilder();
            sceneBuilder.pushClipRect(physicalBounds);
            sceneBuilder.addPicture(Offset.zero, picture);
            sceneBuilder.pop();

            var scene = sceneBuilder.build();
            return scene;
        }

    }
}
