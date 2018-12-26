using FlutterBinding.Flow;
using SkiaSharp;

namespace FlutterBinding.Shell
{
    /// Represents a Frame that has been fully configured for the underlying client
    /// rendering API. A frame may only be submitted once.
    public class SurfaceFrame
    {
        public delegate bool SubmitCallback(SurfaceFrame surfaceFrame, SKCanvas canvas);

        public SurfaceFrame(SKSurface surface, SubmitCallback submitCallback)
        {
            _submitted      = false;
            _surface        = surface;
            _submitCallback = submitCallback;
            if (_surface != null)
            {
                var colorSpace = SKColorSpace.CreateSrgb();
                // TODO: SKCreateColorSpaceXformCanvas not exposed by SkiaSharp
                //xform_canvas_ = SKCreateColorSpaceXformCanvas(surface_.Canvas, colorSpace);
            }
        }

        public bool Submit()
        {
            if (_submitted)
                return false;

            _submitted = PerformSubmit();
            return _submitted;
        }

        public SKCanvas SkiaCanvas => _xformCanvas ?? _surface?.Canvas;
        public SKSurface SkiaSurface => _surface;


        private bool _submitted;
        private readonly SKSurface _surface;
        private SKCanvas _xformCanvas;
        private SubmitCallback _submitCallback;

        private bool PerformSubmit()
        {
            if (_submitCallback == null)
                return false;

            if (_submitCallback(this, SkiaCanvas))
                return true;

            return false;
        }
    };

    public interface Surface
    {
        bool IsValid();

        SurfaceFrame AcquireFrame(SKSizeI size);

        SKMatrix GetRootTransformation();

        GRContext GetContext();

        ExternalViewEmbedder GetExternalViewEmbedder();
    }
}
