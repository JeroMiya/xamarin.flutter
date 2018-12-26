using Android.Graphics;

namespace Flutter.Shell.Droid.View
{
    /**
     * Registry of backend textures used with a single {@link FlutterView} instance.
     * Entries may be embedded into the Flutter view using the
     * <a href="https://docs.flutter.io/flutter/widgets/Texture-class.html">Texture</a>
     * widget.
     */
    public interface ITextureRegistry
    {
        /**
         * Creates and registers a SurfaceTexture managed by the Flutter engine.
         *
         * @return A SurfaceTextureEntry.
         */
        ITextureRegistrySurfaceTextureEntry CreateSurfaceTexture();
    }

    /**
     * A registry entry for a managed SurfaceTexture.
     */
    public interface ITextureRegistrySurfaceTextureEntry
    {
        /// <summary>
        /// The managed SurfaceTexture.
        /// </summary>
        SurfaceTexture SurfaceTexture { get; }

        /// <summary>
        /// The identity of this SurfaceTexture.
        /// </summary>
        long Id { get; }

        /// <summary>
        /// Deregisters and releases this SurfaceTexture.
        /// </summary>
        void Release();
    }
}
