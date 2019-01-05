using FlutterBinding.Engine;
using FlutterBinding.UI;
using SkiaSharp.Views.UWP;
using Windows.UI.Xaml.Controls;
using FlutterBinding.Flow;
using SkiaSharp;
using SKPaintStyle = SkiaSharp.SKPaintStyle;

namespace FlutterBindingSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var window = Window.Instance;
            var frame = (Frame)Windows.UI.Xaml.Window.Current.Content;

            window.physicalSize = new Size(frame.ActualWidth, frame.ActualHeight);

            Engine.Instance.LoadCanvas(e.Surface.Canvas);
            Engine.Instance.SetSize(frame.ActualWidth, frame.ActualHeight);

            BeginFrame();
        }


        public void BeginFrame()
        {
            var window = Window.Instance;

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
            canvas.Scale((float)devicePixelRatio, (float)devicePixelRatio);

            PaintUtils.DrawCheckerboard(canvas, Rect.fromLTWH(0,0,(float)physicalSize.width, (float)physicalSize.height));

            var circlePaint = new SKPaint
            {
                Style       = SKPaintStyle.Stroke,
                IsAntialias = true,
                StrokeWidth = 3,
                Color       = SKColors.OrangeRed
            };
            canvas.DrawCircle(new Offset(logicalSize.width / 2, logicalSize.height / 2), 100, circlePaint);

            canvas.DrawParagraph(paragraph, new Offset(
                (logicalSize.width - paragraph.maxIntrinsicWidth) / 2.0,
                (logicalSize.height - paragraph.height) / 2.0));

            var picture = recorder.endRecording();

            var sceneBuilder = new SceneBuilder();
            sceneBuilder.PushClipRect(physicalBounds);
            sceneBuilder.AddPicture(Offset.zero, picture);
            sceneBuilder.Pop();

            var scene = sceneBuilder.Build();

            window.Render(scene);
        }
    }
}
