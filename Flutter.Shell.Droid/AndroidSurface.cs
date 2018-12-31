using Android.Views;
using SkiaSharp;

namespace Flutter.Shell.Droid
{
    // TODO: I don't think this approach is where I will go
    public abstract class AndroidSurface
    {
        public static AndroidSurface Create(bool use_software_rendering)
        {
            return null;
        }

        public abstract bool IsValid();

        public abstract void TeardownOnScreenContext();

        public abstract FlutterBinding.Shell.Surface CreateGPUSurface();

        public abstract bool OnScreenSurfaceResize(SKSizeI size);

        public abstract bool ResourceContextMakeCurrent();

        public abstract bool ResourceContextClearCurrent();

        public abstract bool SetNativeWindow(AndroidNativeWindow window);
    }

    public class AndroidNativeWindow
    {
        public AndroidNativeWindow(Surface surface)
        {
            
        }
    }
}
