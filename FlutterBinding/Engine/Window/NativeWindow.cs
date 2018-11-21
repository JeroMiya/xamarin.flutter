using FlutterBinding.UI;
using System;
using System.Collections.Generic;
using System.Text;
using FlutterBinding.Flow.Layers;

namespace FlutterBinding.Engine.Window
{
    public class NativeWindow
    {
        public void Render(Scene scene)
        {
            Engine.Instance.Render(scene.TakeLayerTree());
        }
    }

    public interface WindowClient
    {
        string DefaultRouteName();
        void ScheduleFrame();
        void Render(Scene scene);
        void UpdateSemantics(SemanticsUpdate update);
        //void HandlePlatformMessage(PlatformMessage message);
        void SetIsolateDebugName(string isolateName);
        //FontCollection GetFontCollection();
    };

    public interface RuntimeDelegate
    {
        string DefaultRouteName();
        void ScheduleFrame(bool regenerate_layer_tree = true);
        void Render(LayerTree layer_tree);

        void UpdateSemantics(
            SemanticsNodeUpdates update,
            CustomAccessibilityActionUpdates actions);

        //void HandlePlatformMessage(PlatformMessage message);
        //FontCollection GetFontCollection();
    };


    public sealed class RuntimeController : WindowClient, IDisposable
    {
        /// <inheritdoc />
        public string DefaultRouteName()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ScheduleFrame()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Render(Scene scene)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void UpdateSemantics(SemanticsUpdate update)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetIsolateDebugName(string isolateName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Dispose() { }
    }
}
