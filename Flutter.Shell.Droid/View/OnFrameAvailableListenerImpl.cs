using System;
using Android.Graphics;

namespace Flutter.Shell.Droid.View
{
    public class OnFrameAvailableListenerImpl : Java.Lang.Object, SurfaceTexture.IOnFrameAvailableListener
    {
        public Action<SurfaceTexture> FrameAvailable;

        /// <inheritdoc />
        public void OnFrameAvailable(SurfaceTexture surfaceTexture)
        {
            FrameAvailable?.Invoke(surfaceTexture);
        }
    }
}