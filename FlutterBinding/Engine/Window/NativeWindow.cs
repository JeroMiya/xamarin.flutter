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
}
