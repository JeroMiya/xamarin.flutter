using System;
using System.Collections.Generic;
using System.Text;
using FlutterBinding.Mapping;
using SkiaSharp;

namespace FlutterBinding.UI
{
    /// <summary>
    /// A description of the style to use when drawing on a [Canvas].
    ///
    /// Most APIs on [Canvas] take a [Paint] object to describe the style
    /// to use for that operation.
    /// </summary>
    public class Paint
    {
        // Paint objects are encoded in two buffers:
        //
        // * _data is binary data in four-byte fields, each of which is either a
        //   uint or a float. The default value for each field is encoded as
        //   zero to make initialization trivial. Most values already have a default
        //   value of zero, but some, such as color, have a non-zero default value.
        //   To encode or decode these values, XOR the value with the default value.
        //
        // * _objects is a list of unencodable objects, typically wrappers for native
        //   objects. The objects are simply stored in the list without any additional
        //   encoding.
        //
        // The binary format must match the deserialization code in paint.cc.

        internal readonly Types.ByteData _data = new Types.ByteData(DataByteCount);
        const int IsAntiAliasIndex = 0;
        const int ColorIndex = 1;
        const int BlendModeIndex = 2;
        const int StyleIndex = 3;
        const int StrokeWidthIndex = 4;
        const int StrokeCapIndex = 5;
        const int StrokeJoinIndex = 6;
        const int StrokeMiterLimitIndex = 7;
        const int FilterQualityIndex = 8;
        const int ColorFilterIndex = 9;
        const int ColorFilterColorIndex = 10;
        const int ColorFilterBlendModeIndex = 11;
        const int MaskFilterIndex = 12;
        const int MaskFilterBlurStyleIndex = 13;
        const int MaskFilterSigmaIndex = 14;
        const int InvertColorIndex = 15;

        const int IsAntiAliasOffset = IsAntiAliasIndex << 2;
        const int ColorOffset = ColorIndex << 2;
        const int BlendModeOffset = BlendModeIndex << 2;
        const int StyleOffset = StyleIndex << 2;
        const int StrokeWidthOffset = StrokeWidthIndex << 2;
        const int StrokeCapOffset = StrokeCapIndex << 2;
        const int StrokeJoinOffset = StrokeJoinIndex << 2;
        const int StrokeMiterLimitOffset = StrokeMiterLimitIndex << 2;
        const int FilterQualityOffset = FilterQualityIndex << 2;
        const int ColorFilterOffset = ColorFilterIndex << 2;
        const int ColorFilterColorOffset = ColorFilterColorIndex << 2;
        const int ColorFilterBlendModeOffset = ColorFilterBlendModeIndex << 2;
        const int MaskFilterOffset = MaskFilterIndex << 2;
        const int MaskFilterBlurStyleOffset = MaskFilterBlurStyleIndex << 2;
        const int MaskFilterSigmaOffset = MaskFilterSigmaIndex << 2;

        const int InvertColorOffset = InvertColorIndex << 2;

        // If you add more fields, remember to update DataByteCount.
        const int DataByteCount = 75;

        // Binary format must match the deserialization code in paint.cc.
        internal List<object> _objects;
        const int ShaderIndex = 0;
        const int ObjectCount = 1; // Must be one larger than the largest index.

        /// Whether to apply anti-aliasing to lines and images drawn on the
        /// canvas.
        ///
        /// We encode true as zero and false as one because the default value, which
        /// we always encode as zero, is true.
        /// Defaults to true.
        public bool IsAntiAlias
        {
            get => _data.getInt32(IsAntiAliasOffset, (int)Painting.kFakeHostEndian) == 0;
            set => _data.setInt32(IsAntiAliasOffset, value ? 0 : 1, (int)Painting.kFakeHostEndian);
        }

        // Must be kept in sync with the default in paint.cc.
        const uint _kColorDefault = 0xFF000000;

        /// The color to use when stroking or filling a shape.
        ///
        /// Defaults to opaque black.
        ///
        /// See also:
        ///
        ///  * [style], which controls whether to stroke or fill (or both).
        ///  * [colorFilter], which overrides [color].
        ///  * [shader], which overrides [color] with more elaborate effects.
        ///
        /// This color is not used when compositing. To colorize a layer, use
        /// [colorFilter].
        public Color Color
        {
            get
            {
                uint encoded = (uint)_data.getInt32(ColorOffset, (int)Painting.kFakeHostEndian);
                return new Color(encoded ^ _kColorDefault);
            }
            set
            {
                //assert(value != null);
                int encoded = (int)(value.Value ^ _kColorDefault);
                _data.setInt32(ColorOffset, encoded, (int)Painting.kFakeHostEndian);
            }
        }


        // Must be kept in sync with the default in paint.cc.
        static readonly SKBlendMode _kBlendModeDefault = SKBlendMode.SrcOver;

        /// A blend mode to apply when a shape is drawn or a layer is composited.
        ///
        /// The source colors are from the shape being drawn (e.g. from
        /// [Canvas.drawPath]) or layer being composited (the graphics that were drawn
        /// between the [Canvas.saveLayer] and [Canvas.restore] calls), after applying
        /// the [colorFilter], if any.
        ///
        /// The destination colors are from the background onto which the shape or
        /// layer is being composited.
        ///
        /// Defaults to [SKBlendMode.srcOver].
        ///
        /// See also:
        ///
        ///  * [Canvas.saveLayer], which uses its [Paint]'s [blendMode] to composite
        ///    the layer when [restore] is called.
        ///  * [SKBlendMode], which discusses the user of [saveLayer] with [blendMode].
        public SKBlendMode BlendMode
        {
            get
            {
                int encoded = _data.getInt32(BlendModeOffset, (int)Painting.kFakeHostEndian);
                return (SKBlendMode)(encoded ^ (int)_kBlendModeDefault);
            }
            set
            {
                //assert(value != null);
                int encoded = (int)value ^ (int)_kBlendModeDefault;
                _data.setInt32(BlendModeOffset, encoded, (int)Painting.kFakeHostEndian);
            }
        }

        /// Whether to paint inside shapes, the edges of shapes, or both.
        ///
        /// Defaults to [SKPaintStyle.fill].
        public SKPaintStyle Style
        {
            get => (SKPaintStyle)_data.getInt32(StyleOffset, (int)Painting.kFakeHostEndian);
            set
            {
                //assert(value != null);
                int encoded = (int)value;
                _data.setInt32(StyleOffset, encoded, (int)Painting.kFakeHostEndian);
            }
        }

        /// How wide to make edges drawn when [style] is set to
        /// [SKPaintStyle.stroke]. The width is given in logical pixels measured in
        /// the direction orthogonal to the direction of the path.
        ///
        /// Defaults to 0.0, which correspond to a hairline width.
        public double StrokeWidth
        {
            get => _data.getFloat32(StrokeWidthOffset, (int)Painting.kFakeHostEndian);
            set
            {
                //assert(value != null);
                double encoded = value;
                _data.setFloat32(StrokeWidthOffset, encoded, (int)Painting.kFakeHostEndian);
            }
        }

        /// The kind of finish to place on the end of lines drawn when
        /// [style] is set to [SKPaintStyle.stroke].
        ///
        /// Defaults to [SKStrokeCap.butt], i.e. no caps.
        public SKStrokeCap StrokeCap
        {
            get => (SKStrokeCap)_data.getInt32(StrokeCapOffset, (int)Painting.kFakeHostEndian);
            set
            {
                int encoded = (int)value;
                _data.setInt32(StrokeCapOffset, encoded, (int)Painting.kFakeHostEndian);
            }
        }

        /// The kind of finish to place on the joins between segments.
        ///
        /// This applies to paths drawn when [style] is set to [SKPaintStyle.stroke],
        /// It does not apply to points drawn as lines with [Canvas.drawPoints].
        ///
        /// Defaults to [SKStrokeJoin.miter], i.e. sharp corners.
        ///
        /// Some examples of joins:
        ///
        /// {@animation 300 300 https://flutter.github.io/assets-for-api-docs/assets/dart-ui/miter_4_join.mp4}
        ///
        /// {@animation 300 300 https://flutter.github.io/assets-for-api-docs/assets/dart-ui/round_join.mp4}
        ///
        /// {@animation 300 300 https://flutter.github.io/assets-for-api-docs/assets/dart-ui/bevel_join.mp4}
        ///
        /// The centers of the line segments are colored in the diagrams above to
        /// highlight the joins, but in normal usage the join is the same color as the
        /// line.
        ///
        /// See also:
        ///
        ///  * [strokeMiterLimit] to control when miters are replaced by bevels when
        ///    this is set to [SKStrokeJoin.miter].
        ///  * [strokeCap] to control what is drawn at the ends of the stroke.
        ///  * [SKStrokeJoin] for the definitive list of stroke joins.
        public SKStrokeJoin StrokeJoin
        {
            get { return (SKStrokeJoin)_data.getInt32(StrokeJoinOffset, (int)Painting.kFakeHostEndian); }
            set
            {
                //assert(value != null);
                int encoded = (int)value;
                _data.setInt32(StrokeJoinOffset, encoded, (int)Painting.kFakeHostEndian);
            }
        }

        // Must be kept in sync with the default in paint.cc.
        const double _kStrokeMiterLimitDefault = 4.0;

        /// The limit for miters to be drawn on segments when the join is set to
        /// [SKStrokeJoin.miter] and the [style] is set to [SKPaintStyle.stroke]. If
        /// this limit is exceeded, then a [SKStrokeJoin.bevel] join will be drawn
        /// instead. This may cause some 'popping' of the corners of a path if the
        /// angle between line segments is animated, as seen in the diagrams below.
        ///
        /// This limit is expressed as a limit on the length of the miter.
        ///
        /// Defaults to 4.0.  Using zero as a limit will cause a [SKStrokeJoin.bevel]
        /// join to be used all the time.
        ///
        /// {@animation 300 300 https://flutter.github.io/assets-for-api-docs/assets/dart-ui/miter_0_join.mp4}
        ///
        /// {@animation 300 300 https://flutter.github.io/assets-for-api-docs/assets/dart-ui/miter_4_join.mp4}
        ///
        /// {@animation 300 300 https://flutter.github.io/assets-for-api-docs/assets/dart-ui/miter_6_join.mp4}
        ///
        /// The centers of the line segments are colored in the diagrams above to
        /// highlight the joins, but in normal usage the join is the same color as the
        /// line.
        ///
        /// See also:
        ///
        ///  * [strokeJoin] to control the kind of finish to place on the joins
        ///    between segments.
        ///  * [strokeCap] to control what is drawn at the ends of the stroke.
        public double StrokeMiterLimit
        {
            get => _data.getFloat32(StrokeMiterLimitOffset, (int)Painting.kFakeHostEndian);
            set
            {
                //assert(value != null);
                double encoded = value - _kStrokeMiterLimitDefault;
                _data.setFloat32(StrokeMiterLimitOffset, encoded, (int)Painting.kFakeHostEndian);
            }
        }

        /// A mask filter (for example, a blur) to apply to a shape after it has been
        /// drawn but before it has been composited into the image.
        ///
        /// See [MaskFilter] for details.
        public MaskFilter MaskFilter
        {
            get
            {
                switch (_data.getInt32(MaskFilterOffset, (int)Painting.kFakeHostEndian))
                {
                case MaskFilter._TypeNone:
                    return null;
                case MaskFilter._TypeBlur:
                    return MaskFilter.blur(
                        (SKBlurStyle)_data.getInt32(MaskFilterBlurStyleOffset, (int)Painting.kFakeHostEndian),
                        _data.getFloat32(MaskFilterSigmaOffset, (int)Painting.kFakeHostEndian));
                }

                return null;
            }
            set
            {
                if (value == null)
                {
                    _data.setInt32(MaskFilterOffset, MaskFilter._TypeNone, (int)Painting.kFakeHostEndian);
                    _data.setInt32(MaskFilterBlurStyleOffset, 0, (int)Painting.kFakeHostEndian);
                    _data.setFloat32(MaskFilterSigmaOffset, 0.0, (int)Painting.kFakeHostEndian);
                }
                else
                {
                    // For now we only support one kind of MaskFilter, so we don't need to
                    // check what the type is if it's not null.
                    _data.setInt32(MaskFilterOffset, MaskFilter._TypeBlur, (int)Painting.kFakeHostEndian);
                    _data.setInt32(MaskFilterBlurStyleOffset, (int)value._style, (int)Painting.kFakeHostEndian);
                    _data.setFloat32(MaskFilterSigmaOffset, value._sigma, (int)Painting.kFakeHostEndian);
                }
            }
        }

        /// Controls the performance vs quality trade-off to use when applying
        /// filters, such as [maskFilter], or when drawing images, as with
        /// [Canvas.drawImageRect] or [Canvas.drawImageNine].
        ///
        /// Defaults to [SKFilterQuality.none].
        public SKFilterQuality FilterQuality
        {
            get => (SKFilterQuality)(_data.getInt32(FilterQualityOffset, (int)Painting.kFakeHostEndian));
            set
            {
                //assert(value != null);
                int encoded = (int)value;
                _data.setInt32(FilterQualityOffset, encoded, (int)Painting.kFakeHostEndian);
            }
        }

        /// The shader to use when stroking or filling a shape.
        ///
        /// When this is null, the [color] is used instead.
        ///
        /// See also:
        ///
        ///  * [Gradient], a shader that paints a color gradient.
        ///  * [ImageShader], a shader that tiles an [Image].
        ///  * [colorFilter], which overrides [shader].
        ///  * [color], which is used if [shader] and [colorFilter] are null.
        public SKShader Shader
        {
            get
            {
                if (_objects == null)
                    return null;
                return (SKShader)_objects[ShaderIndex];
            }
            set
            {
                if (_objects == null)
                    _objects = new List<Object>(ObjectCount);
                _objects[ShaderIndex] = value;
            }
        }

        /// A color filter to apply when a shape is drawn or when a layer is
        /// composited.
        ///
        /// See [ColorFilter] for details.
        ///
        /// When a shape is being drawn, [colorFilter] overrides [color] and [shader].
        public ColorFilter ColorFilter
        {
            get
            {
                bool isNull = _data.getInt32(ColorFilterOffset, (int)Painting.kFakeHostEndian) == 0;
                if (isNull)
                    return null;
                return ColorFilter.mode(
                    new Color((uint)_data.getInt32(ColorFilterColorOffset, (int)Painting.kFakeHostEndian)),
                    (SKBlendMode)(_data.getInt32(ColorFilterBlendModeOffset, (int)Painting.kFakeHostEndian))
                );
            }
            set
            {
                if (value == null)
                {
                    _data.setInt32(ColorFilterOffset, 0, (int)Painting.kFakeHostEndian);
                    _data.setInt32(ColorFilterColorOffset, 0, (int)Painting.kFakeHostEndian);
                    _data.setInt32(ColorFilterBlendModeOffset, 0, (int)Painting.kFakeHostEndian);
                }
                else
                {
                    _data.setInt32(ColorFilterOffset, 1, (int)Painting.kFakeHostEndian);
                    _data.setInt32(ColorFilterColorOffset, (int)value._color.Value, (int)Painting.kFakeHostEndian);
                    _data.setInt32(ColorFilterBlendModeOffset, (int)value._blendMode, (int)Painting.kFakeHostEndian);
                }
            }
        }

        /// Whether the colors of the image are inverted when drawn.
        ///
        /// inverting the colors of an image applies a new color filter that will
        /// be composed with any user provided color filters. This is primarily
        /// used for implementing smart invert on iOS.
        public bool InvertColors
        {
            get { return _data.getInt32(InvertColorOffset, (int)Painting.kFakeHostEndian) == 1; }
            set { _data.setInt32(InvertColorOffset, value ? 1 : 0, (int)Painting.kFakeHostEndian); }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            String semicolon = "";
            result.Append("Paint(");
            if (Style == SKPaintStyle.Stroke)
            {
                result.Append($"{Style}");
                if (StrokeWidth != 0.0)
                    result.Append($" {StrokeWidth.toStringAsFixed(1)}");
                else
                    result.Append(" hairline");
                if (StrokeCap != SKStrokeCap.Butt)
                    result.Append($" {StrokeCap}");
                if (StrokeJoin == SKStrokeJoin.Miter)
                {
                    if (StrokeMiterLimit != _kStrokeMiterLimitDefault)
                        result.Append($" {StrokeJoin} up to ${StrokeMiterLimit.toStringAsFixed(1)}");
                }
                else
                {
                    result.Append($" {StrokeJoin}");
                }

                semicolon = "; ";
            }

            if (IsAntiAlias != true)
            {
                result.Append($"{semicolon}antialias off");
                semicolon = "; ";
            }

            if (Color != new Color(_kColorDefault))
            {
                if (Color != null)
                    result.Append($"{semicolon}{Color}");
                else
                    result.Append($"{semicolon}no color");
                semicolon = "; ";
            }

            if (BlendMode != _kBlendModeDefault)
            {
                result.Append($"{semicolon}{BlendMode}");
                semicolon = "; ";
            }

            if (ColorFilter != null)
            {
                result.Append($"{semicolon}colorFilter: {ColorFilter}");
                semicolon = "; ";
            }

            if (MaskFilter != null)
            {
                result.Append($"{semicolon}maskFilter: {MaskFilter}");
                semicolon = "; ";
            }

            if (FilterQuality != SKFilterQuality.None)
            {
                result.Append($"{semicolon}filterQuality: {FilterQuality}");
                semicolon = "; ";
            }

            if (Shader != null)
            {
                result.Append($"{semicolon}shader: {Shader}");
                semicolon = "; ";
            }

            if (InvertColors)
                result.Append($"{semicolon}invert: {InvertColors}");
            result.Append(")");
            return result.ToString();
        }
    }
}