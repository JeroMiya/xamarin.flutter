using System;
using FlutterBinding.Engine;
using FlutterBinding.Engine.Synchronization;
using FlutterBinding.Flow.Layers;

namespace FlutterBinding.Shell
{
    public sealed partial class Animator
    {
        public interface IAnimatorDelegate
        {
            void OnAnimatorBeginFrame(TimePoint frameTime);
            void OnAnimatorNotifyIdle(Int64 deadline);
            void OnAnimatorDraw(Pipeline<LayerTree> pipeline);
            void OnAnimatorDrawLastLayerTree();
        };

        //FML_DISALLOW_COPY_AND_ASSIGN(Animator);
    }
}
