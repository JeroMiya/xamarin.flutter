using System;

namespace Flutter.Framework.Shell
{
    /// Additional accessibility features that may be enabled by the platform.
    ///
    /// It is not possible to enable these settings from Flutter, instead they are
    /// used by the platform to indicate that additional accessibility features are
    /// enabled.
    [Flags]
    public enum AccessibilityFeatures
    {
        AccessibleNavigation = 1 << 0,
        InvertColors = 1 << 1,
        DisableAnimations = 1 << 2,
        BoldText = 1 << 3,
        ReduceMotion = 1 << 4,
    };
}
