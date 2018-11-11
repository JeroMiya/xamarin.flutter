using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlutterBinding.UI;
using SkiaSharp;

namespace FlutterBinding.Engine.Painting
{
    // TODO: This is going to be a hard one to port
    public class MultiFrameCodec : Codec
    {
        /// <inheritdoc />
        public override int frameCount { get; }

        /// <inheritdoc />
        public override int repetitionCount { get; }

        /// <inheritdoc />
        protected override FrameInfo _getNextFrame(_Callback<FrameInfo> callback)
        {
            throw new NotImplementedException();
        }
    }
}
