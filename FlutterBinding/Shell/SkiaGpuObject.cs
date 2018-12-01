using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using FlutterBinding.Engine;
using SkiaSharp;

namespace FlutterBinding.Shell
{
    // A queue that holds Skia objects that must be destructed on the the given task
    // runner.
    public class SkiaUnrefQueue
    {
        public SkiaUnrefQueue(TaskRunner task_runner, TimeDelta delay)
        {
            task_runner_ = task_runner;
            drain_delay_ = delay;
            drain_pending_ = false;
        }

        ~SkiaUnrefQueue()
        {
            Drain();
        }

        public void Unref(SKObject obj)
        {
            lock (mutex_)
            {
                objects_.Add(obj);
                if (!drain_pending_)
                {
                    drain_pending_ = true;
                    task_runner_.PostDelayedTask( Drain, drain_delay_);
                }
            }
        }

        // Usually, the drain is called automatically. However, during IO manager
        // shutdown (when the platform side reference to the OpenGL context is about
        // to go away), we may need to pre-emptively drain the unref queue. It is the
        // responsibility of the caller to ensure that no further unrefs are queued
        // after this call.
        public void Drain()
        {
            List<SKObject> skia_objects = null;
            lock (mutex_)
            {
                skia_objects = objects_.ToList();
                objects_.Clear();
            }

            drain_pending_ = false;
            foreach (var skiaObject in skia_objects)
                skiaObject.Dispose();
        }

        private TaskRunner task_runner_;
        private TimeDelta drain_delay_;
        private Mutex mutex_ = new Mutex();
        private List<SKObject> objects_ = new List<SKObject>();
        private bool drain_pending_;

        //FML_FRIEND_REF_COUNTED_THREAD_SAFE(SkiaUnrefQueue);
        //FML_FRIEND_MAKE_REF_COUNTED(SkiaUnrefQueue);
        //FML_DISALLOW_COPY_AND_ASSIGN(SkiaUnrefQueue);
    }

    /// An object whose deallocation needs to be performed on an specific unref
    /// queue. The template argument U need to have a call operator that returns
    /// that unref queue.
    public class SkiaGPUObject<TSkiaObjectType> : IDisposable where TSkiaObjectType : SKObject
    {
        public SkiaGPUObject() { }

        public SkiaGPUObject(TSkiaObjectType obj, SkiaUnrefQueue queue)
        {
            object_ = obj;
            queue_ = queue;
            //FML_DCHECK(queue_ && object_);
        }

        protected virtual void Dispose(bool disposing)
        {
            reset();
            if (disposing) { }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <inheritdoc />
        ~SkiaGPUObject()
        {
            Dispose(false);
        }

        void reset()
        {
            if (object_ != null)
            {
                queue_.Unref(object_);
                object_.Dispose();
                object_ = null;
            }
            queue_ = null;
            //FML_DCHECK(object_ == nullptr);
        }

        private TSkiaObjectType object_;
        private SkiaUnrefQueue queue_;

        public TSkiaObjectType Object => object_;

        //FML_DISALLOW_COPY_AND_ASSIGN(SkiaGPUObject);
    };

}
