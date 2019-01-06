﻿using FlutterBinding.UI;

namespace FlutterBinding.Shell
{
    public interface IWindowClient
    {
        string DefaultRouteName();
        void ScheduleFrame(bool regenerateLayerTree = true);
        void Render(Scene scene);
        void UpdateSemantics(SemanticsUpdate update);
        void SetIsolateDebugName(string isolateName);

        void HandlePlatformMessage(PlatformMessage message);
        //FontCollection GetFontCollection();
    };
}
