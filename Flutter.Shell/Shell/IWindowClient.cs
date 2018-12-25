namespace Flutter.Framework.Shell
{
    public interface IWindowClient
    {
        string DefaultRouteName();
        void ScheduleFrame();
        void Render(Scene scene);
        void UpdateSemantics(SemanticsUpdate update);
        void SetIsolateDebugName(string isolateName);
        void HandlePlatformMessage(PlatformMessage message);
        //FontCollection GetFontCollection();
    };
}