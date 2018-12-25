using System;
using Flutter.Framework.Engine;
using Flutter.Framework.Engine.Synchronization;
using FlutterBinding.Engine;

namespace Flutter.Framework.Shell
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
