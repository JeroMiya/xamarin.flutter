using System;
using Android.Content;
using Flutter.Shell.Droid.Plugin.Common;

namespace Flutter.Shell.Droid.Plugin.Platform
{
    public abstract class PlatformViewFactory
    {
        private readonly MessageCodec<object> _createArgsCodec;

        /**
         *
         * @param createArgsCodec the codec used to decode the args parameter of {@link #create}.
         */
        protected PlatformViewFactory(MessageCodec<object> createArgsCodec)
        {
            _createArgsCodec = createArgsCodec;
        }

        /**
         * Creates a new Android view to be embedded in the Flutter hierarchy.
         *
         * @param context the context to be used when creating the view, this is different than FlutterView's context.
         * @param viewId unique identifier for the created instance, this value is known on the Dart side.
         * @param args arguments sent from the Flutter app. The bytes for this value are decoded using the createArgsCodec
         *             argument passed to the constructor. This is null if createArgsCodec was null, or no arguments were
         *             sent from the Flutter app.
         */
        public abstract PlatformView Create(Context context, int viewId, Object args);

        /**
         * Returns the codec to be used for decoding the args parameter of {@link #create}.
         */
        public MessageCodec<object> GetCreateArgsCodec() => _createArgsCodec;
    }
}