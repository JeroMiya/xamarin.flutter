using Android.Graphics;
using FlutterBinding.Flow;
using SkiaSharp;

namespace Flutter.Shell.Droid {
    public class AndroidExternalTexture : Texture
    {
        private SurfaceTexture _surfaceTexture;

        public AndroidExternalTexture(long textureId, SurfaceTexture surfaceTexture) : base(textureId)
        {
            _surfaceTexture = surfaceTexture;
        }

        /// <inheritdoc />
        public override void Paint(SKCanvas canvas, SKRect bounds, bool freeze)
        {
            
        }

        /// <inheritdoc />
        public override void OnGRContextCreated()
        {
            
        }

        /// <inheritdoc />
        public override void OnGRContextDestroyed()
        {
            
        }

        /// <inheritdoc />
        public override void MarkNewFrameAvailable()
        {
            
        }
    }
}