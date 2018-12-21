using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Flutter.Shell.Droid.View
{
    /**
     * Registry of backend textures used with a single {@link FlutterView} instance.
     * Entries may be embedded into the Flutter view using the
     * <a href="https://docs.flutter.io/flutter/widgets/Texture-class.html">Texture</a>
     * widget.
     */
    public interface TextureRegistry
    {
        /**
         * Creates and registers a SurfaceTexture managed by the Flutter engine.
         *
         * @return A SurfaceTextureEntry.
         */
        TextureRegistry_SurfaceTextureEntry CreateSurfaceTexture();
    }

    /**
     * A registry entry for a managed SurfaceTexture.
     */
    public interface TextureRegistry_SurfaceTextureEntry
    {
        /**
         * @return The managed SurfaceTexture.
         */
        SurfaceTexture SurfaceTexture();

        /**
         * @return The identity of this SurfaceTexture.
         */
        long Id();

        /**
         * Deregisters and releases this SurfaceTexture.
         */
        void Release();
    }

}