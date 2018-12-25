using System;
using Flutter.Framework.Engine;
using FlutterBinding.Engine;
using SkiaSharp;

namespace Flutter.Framework.Shell
{
    public class IOManager
    {
        
        // Convenience methods for platforms to create a GrContext used to supply to
        // the IOManager. The platforms may create the context themselves if they so
        // desire.
        public static GRContext CreateCompatibleResourceLoadingContext(GRBackend backend)
        {
            if (backend != GRBackend.OpenGL)
                return null;

            var options = GRContextOptions.Default;

            // TODO: Not currently in SkiaSharp
            //options.fPersistentCache = PersistentCache::GetCacheForProcess();

            // There is currently a bug with doing GPU YUV to RGB conversions on the IO
            // thread. The necessary work isn't being flushed or synchronized with the
            // other threads correctly, so the textures end up blank.  For now, suppress
            // that feature, which will cause texture uploads to do CPU YUV conversion.
            options.DisableGpuYuvConversion = true;

            // To get video playback on the widest range of devices, we limit Skia to
            // ES2 shading language when the ES3 external image extension is missing.

            // TODO: Not currently supported by SkiaSharp
            //options.fPreferExternalImagesOverES3 = true;


            var context = GRContext.Create(GRBackend.OpenGL, GRGlInterface.CreateNativeGlInterface(), options);
            if (context != null)
            {
                // Do not cache textures created by the image decoder.  These textures
                // should be deleted when they are no longer referenced by an SkImage.
                context.SetResourceCacheLimits(0, 0);
                return context;
            }

            return null;
        }

        public IOManager(GRContext resourceContext, TaskRunner unrefQueueTaskRunner)
        {
            _resourceContext = resourceContext;
            _unrefQueue = new SkiaUnrefQueue(unrefQueueTaskRunner, TimeSpan.FromMilliseconds(250));

            if (_resourceContext == null)
            {
                //FML_DLOG(WARNING) << "The IO manager was initialized without a resource context. Async texture uploads will be disabled. Expect performance degradation.";
            }
        }

        ~IOManager()
        {
            _unrefQueue.Drain();
        }

        public GRContext GetResourceContext() => _resourceContext;
        public SkiaUnrefQueue GetSkiaUnrefQueue() => _unrefQueue;

        // Resource context management.
        private readonly GRContext _resourceContext;

        // Unref queue management.
        private readonly SkiaUnrefQueue _unrefQueue;

        //FML_DISALLOW_COPY_AND_ASSIGN(IOManager);
    };
}
