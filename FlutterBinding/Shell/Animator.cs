using System;
using System.Threading;
using FlutterBinding.Engine;
using FlutterBinding.Flow.Layers;
using SkiaSharp;
using LayerTreePipeline = FlutterBinding.Engine.Synchronization.Pipeline<FlutterBinding.Flow.Layers.LayerTree>;

namespace FlutterBinding.Shell
{
    public sealed partial class Animator
    {

        // Wait 51 milliseconds (which is 1 more milliseconds than 3 frames at 60hz)
        // before notifying the engine that we are idle.  See comments in |BeginFrame|
        // for further discussion on why this is necessary.
        private readonly TimeDelta kNotifyIdleTaskWaitTime = TimeSpan.FromMilliseconds(51);

        public Animator(Animator.IAnimatorDelegate @delegate, TaskRunners taskRunners, VsyncWaiter waiter)
        {
            _delegate = @delegate;
            _taskRunners = taskRunners;
            _waiter = waiter;
            _lastBeginFrameTime = new TimePoint();
            _dartFrameDeadline = 0;
            _layerTreePipeline = new LayerTreePipeline(2);
            _pendingFrameSemaphore = new Semaphore(1, 1);
            _frameNumber = 1;
            _paused = false;
            _regenerateLayerTree = false;
            _frameScheduled = false;
            _notifyIdleTaskId = 0;
            _dimensionChangePending = false;
        }

        public void RequestFrame(bool regenerateLayerTree = true)
        {
            if (regenerateLayerTree)
            {
                _regenerateLayerTree = true;
            }
            if (_paused && !_dimensionChangePending)
            {
                return;
            }

            if (!_pendingFrameSemaphore.WaitOne(TimeSpan.FromMilliseconds(50)))
            {
                // Multiple calls to Animator::RequestFrame will still result in a
                // single request to the VsyncWaiter.
                return;
            }

            // The AwaitVSync is going to call us back at the next VSync. However, we want
            // to be reasonably certain that the UI thread is not in the middle of a
            // particularly expensive callout. We post the AwaitVSync to run right after
            // an idle. This does NOT provide a guarantee that the UI thread has not
            // started an expensive operation right after posting this message however.
            // To support that, we need edge triggered wakes on VSync.

            _taskRunners.UITaskRunner.PostTask( () =>
                {
                    //TRACE_EVENT_ASYNC_BEGIN0("flutter", "Frame Request Pending", frame_number);
                    AwaitVSync();
                });
            _frameScheduled = true;
        }

        public void Render(LayerTree layerTree)
        {
            if (_dimensionChangePending && layerTree.frame_size() != _lastLayerTreeSize)
            {
                _dimensionChangePending = false;
            }
            _lastLayerTreeSize = layerTree.frame_size();

                // Note the frame time for instrumentation.
            layerTree?.set_construction_time(TimePoint.Now() - _lastBeginFrameTime);

            // Commit the pending continuation.
            _producerContinuation.Complete(layerTree);

            _delegate.OnAnimatorDraw(_layerTreePipeline);
        }

        public void Start()
        {
            if (!_paused)
                return;

            _paused = false;
            RequestFrame();
        }

        public void Stop()
        {
            _paused = true;
        }

        public void SetDimensionChangePending()
        {
            _dimensionChangePending = true;
        }

        private static Int64 FxlToDartOrEarlier(TimePoint time)
        {
            var totalTicks = (time.Ticks - TimePoint.Now().Ticks);
            return totalTicks;
        }

        private void BeginFrame(TimePoint frameStartTime, TimePoint frameTargetTime)
        {
            //TRACE_EVENT_ASYNC_END0("flutter", "Frame Request Pending", frame_number_++);

            _frameScheduled = false;
            _notifyIdleTaskId++;
            _regenerateLayerTree = false;
            _pendingFrameSemaphore.Release();

            if (_producerContinuation == null)
            {
                // We may already have a valid pipeline continuation in case a previous
                // begin frame did not result in an Animation::Render. Simply reuse that
                // instead of asking the pipeline for a fresh continuation.
                _producerContinuation = _layerTreePipeline.Produce();

                if (_producerContinuation == null)
                {
                    // If we still don't have valid continuation, the pipeline is currently
                    // full because the consumer is being too slow. Try again at the next
                    // frame interval.
                    RequestFrame();
                    return;
                }
            }

            // We have acquired a valid continuation from the pipeline and are ready
            // to service potential frame.
            //FML_DCHECK(producer_continuation_);

            _lastBeginFrameTime = frameStartTime;
            _dartFrameDeadline = FxlToDartOrEarlier(frameTargetTime);
            {
                //TRACE_EVENT2("flutter", "Framework Workload", "mode", "basic", "frame", FrameParity());
                _delegate.OnAnimatorBeginFrame(_lastBeginFrameTime);
            }

            if (!_frameScheduled)
            {
                // Under certain workloads (such as our parent view resizing us, which is
                // communicated to us by repeat viewport metrics events), we won't
                // actually have a frame scheduled yet, despite the fact that we *will* be
                // producing a frame next vsync (it will be scheduled once we receive the
                // viewport event).  Because of this, we hold off on calling
                // |OnAnimatorNotifyIdle| for a little bit, as that could cause garbage
                // collection to trigger at a highly undesirable time.
                var notifyIdleTaskId = _notifyIdleTaskId;
                _taskRunners.UITaskRunner.PostDelayedTask(() =>
                    {
                        // If our (this task's) task id is the same as the current one, then
                        // no further frames were produced, and it is safe (w.r.t. jank) to
                        // notify the engine we are idle.
                        if (notifyIdleTaskId == _notifyIdleTaskId)
                        {
                            _delegate.OnAnimatorNotifyIdle(TimePoint.Now().TotalMicroseconds + 100000);
                        }
                    }, kNotifyIdleTaskWaitTime);
            }
        }

        private bool CanReuseLastLayerTree()
        {
            return !_regenerateLayerTree;
        }

        private void DrawLastLayerTree()
        {
            _pendingFrameSemaphore.Release();
            _delegate.OnAnimatorDrawLastLayerTree();
        }

        private void AwaitVSync()
        {
            _waiter.AsyncWaitForVsync( (frameStartTime, frameTargetTime) =>
                {
                    if (CanReuseLastLayerTree())
                        DrawLastLayerTree();
                    else
                        BeginFrame(frameStartTime, frameTargetTime);
                });

            _delegate.OnAnimatorNotifyIdle(_dartFrameDeadline);
        }

        private string FrameParity() => ((_frameNumber % 2) == 0) ? "even" : "odd";

        private readonly Animator.IAnimatorDelegate _delegate;
        private readonly TaskRunners _taskRunners;
        private readonly VsyncWaiter _waiter;

        private TimePoint _lastBeginFrameTime;
        private Int64 _dartFrameDeadline;
        private LayerTreePipeline _layerTreePipeline;
        private Semaphore _pendingFrameSemaphore;
        private LayerTreePipeline.ProducerContinuation _producerContinuation;
        private Int64 _frameNumber;
        private bool _paused;
        private bool _regenerateLayerTree;
        private bool _frameScheduled;
        private int _notifyIdleTaskId;
        private bool _dimensionChangePending;
        private SKSizeI _lastLayerTreeSize;

        //FML_DISALLOW_COPY_AND_ASSIGN(Animator);
    }
}
