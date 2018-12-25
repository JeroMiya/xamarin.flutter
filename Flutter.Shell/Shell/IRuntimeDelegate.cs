namespace Flutter.Framework.Shell
{
    public interface IRuntimeDelegate
    {
        string DefaultRouteName();

        void ScheduleFrame(bool regenerateLayerTree = true);

        void Render(LayerTree layerTree);

        void UpdateSemantics(
            SemanticsNodeUpdates update,
            CustomAccessibilityActionUpdates actions);

        // Use dependency injection, not platform messages!
        //void HandlePlatformMessage(PlatformMessage message);
        //FontCollection GetFontCollection();
    };
}