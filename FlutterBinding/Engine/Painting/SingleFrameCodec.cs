using System;
using FlutterBinding.UI;

namespace FlutterBinding.Engine.Painting {
    public class SingleFrameCodec : Codec
    {
        private readonly FrameInfo _frameInfo;

        /// <inheritdoc />
        public override int frameCount => 1;

        /// <inheritdoc />
        public override int repetitionCount => 0;

        public SingleFrameCodec(FrameInfo frameInfo)
        {
            _frameInfo = frameInfo;
        }

        /// <inheritdoc />
        protected override FrameInfo _getNextFrame(_Callback<FrameInfo> callback)
        {
            if (callback == null)
                throw new ArgumentNullException(nameof(callback));

            callback(_frameInfo);
            return _frameInfo;
        }
    }
}