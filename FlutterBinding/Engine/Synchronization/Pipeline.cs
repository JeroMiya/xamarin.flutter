using System;
using System.Collections.Generic;
using System.Threading;

namespace FlutterBinding.Engine.Synchronization
{
    public enum PipelineConsumeResult
    {
        NoneAvailable,
        Done,
        MoreAvailable,
    };

    public class Pipeline<TResource> where TResource : class
    {
        //using ResourcePtr = std::unique_ptr<TResource>;

        private static long _nextPipelineTraceId;
        private static long GetNextPipelineTraceId()
        {
            return Interlocked.Increment(ref _nextPipelineTraceId);
        }

        /// Denotes a spot in the pipeline reserved for the producer to finish
        /// preparing a completed pipeline resource.
        public class ProducerContinuation
        {
            public ProducerContinuation() { }

            public ProducerContinuation(ProducerContinuation other)
            {
                continuation_ = other.continuation_;
                trace_id_ = other.trace_id_;
                other.continuation_ = null;
                other.trace_id_ = 0;
            }

            /* Weird syntax. 
            ProducerContinuation operator=(ProducerContinuation&& other) {
            std::swap(continuation_, other.continuation_);
            std::swap(trace_id_, other.trace_id_);
            return *this; } */

            public ProducerContinuation Swap(ProducerContinuation other)
            {
                Continuation x = other.continuation_;
                other.continuation_ = continuation_;
                continuation_ = x;
                return this;
            }

            ~ProducerContinuation()
            {
                if (continuation_ != null)
                {
                    continuation_((TResource)null, trace_id_);
                    //TRACE_EVENT_ASYNC_END0("flutter", "PipelineProduce", trace_id_);

                    // The continuation is being dropped on the floor. End the flow.
                    //TRACE_FLOW_END("flutter", "PipelineItem", trace_id_);
                }
            }

            private void Complete(TResource resource)
            {
                if (continuation_ != null)
                {
                    continuation_(resource, trace_id_);
                    continuation_ = null;
                    //TRACE_EVENT_ASYNC_END0("flutter", "PipelineProduce", trace_id_);
                    //TRACE_FLOW_STEP("flutter", "PipelineItem", trace_id_);
                }
            }

            // using Continuation = std::function<void(ResourcePtr, size_t)>;
            internal delegate void Continuation(TResource resource, long size);

            private Continuation continuation_;
            private long trace_id_;

            internal ProducerContinuation(Continuation continuation, long trace_id)
            {
                continuation_ = continuation;
                trace_id_ = trace_id;
                //TRACE_FLOW_BEGIN("flutter", "PipelineItem", trace_id_);
                //TRACE_EVENT_ASYNC_BEGIN0("flutter", "PipelineProduce", trace_id_);
            }
        }

        public Pipeline(int depth)
        {
            empty_ = new Semaphore(depth, depth);
            available_ = new Semaphore(0, depth);
        }

        public bool IsValid()
        {
            return empty_ != null && available_ != null;
        }

        public ProducerContinuation Produce()
        {
            if (!empty_.WaitOne(TimeSpan.FromMilliseconds(50)))
            {
                return new ProducerContinuation();
            }

            return new ProducerContinuation(ProducerCommit, GetNextPipelineTraceId());
        }

        //using Consumer = std::function<void(ResourcePtr)>;
        public delegate void Consumer(TResource resource);

        public PipelineConsumeResult Consume(Consumer consumer)
        {
            if (consumer == null)
                return PipelineConsumeResult.NoneAvailable;

            if (!available_.WaitOne(TimeSpan.FromMilliseconds(50)))
                return PipelineConsumeResult.NoneAvailable;

            TResource resource = null;
            long trace_id = 0;
            long items_count = 0;

            lock(queue_mutex_)
            {
                (resource, trace_id) = queue_.Dequeue();
                items_count = queue_.Count;
            }

            //TRACE_EVENT0("flutter", "PipelineConsume");
            consumer(resource);

            empty_.Release();

            //TRACE_FLOW_END("flutter", "PipelineItem", trace_id);

            return items_count > 0 ? PipelineConsumeResult.MoreAvailable : PipelineConsumeResult.Done;
        }

        private Semaphore empty_;
        private Semaphore available_;
        private readonly object queue_mutex_ = new object();
        private Queue<Tuple<TResource, long>> queue_;

        private void ProducerCommit(TResource resource, long trace_id)
        {
            lock(queue_mutex_)
            {
                queue_.Enqueue(new Tuple<TResource, long>(resource, trace_id));
            }

            // Ensure the queue mutex is not held as that would be a pessimization.
            available_.Release();
        }
    };

}
