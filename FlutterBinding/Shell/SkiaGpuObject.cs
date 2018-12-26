using System;
using System.Collections.Generic;
using System.Linq;
using FlutterBinding.Engine;
using SkiaSharp;

namespace FlutterBinding.Shell
{
    // A queue that holds Skia objects that must be destructed on the the given task
    // runner.
    public class SkiaUnrefQueue
    {
        public SkiaUnrefQueue(TaskRunner taskRunner, TimeDelta delay)
        {
            _taskRunner   = taskRunner;
            _drainDelay   = delay;
            _drainPending = false;
        }

        ~SkiaUnrefQueue()
        {
            Drain();
        }

        public void Unref(SKObject obj)
        {
            lock (_lockObject)
            {
                _objects.Add(obj);
                if (!_drainPending)
                {
                    _drainPending = true;
                    _taskRunner.PostDelayedTask(Drain, _drainDelay);
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
            List<SKObject> skiaObjects = null;
            lock (_lockObject)
            {
                skiaObjects = _objects.ToList();
                _objects.Clear();
            }

            _drainPending = false;
            foreach (var skiaObject in skiaObjects)
                skiaObject.Dispose();
        }

        private TaskRunner _taskRunner;
        private TimeDelta _drainDelay;
        private object _lockObject = new object();
        private List<SKObject> _objects = new List<SKObject>();
        private bool _drainPending;

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
            _object = obj;
            _queue  = queue;
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
            if (_object != null)
            {
                _queue.Unref(_object);
                _object.Dispose();
                _object = null;
            }

            _queue = null;
            //FML_DCHECK(object_ == nullptr);
        }

        private TSkiaObjectType _object;
        private SkiaUnrefQueue _queue;

        public TSkiaObjectType Object => _object;

        //FML_DISALLOW_COPY_AND_ASSIGN(SkiaGPUObject);
    };
}
