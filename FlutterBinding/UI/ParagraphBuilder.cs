namespace FlutterBinding.UI
{
    /// <summary>
    /// Builds a [Paragraph] containing text with the given styling information.
    ///
    /// To set the paragraph's alignment, truncation, and ellipsis behavior, pass
    /// an appropriately-configured [ParagraphStyle] object to the [new ParagraphBuilder] constructor.
    ///
    /// Then, call combinations of [pushStyle], [addText], and [pop] to add styled
    /// text to the object.
    ///
    /// Finally, call [build] to obtain the constructed [Paragraph] object. After
    /// this point, the builder is no longer usable.
    ///
    /// After constructing a [Paragraph], call [Paragraph.layout] on it and then
    /// paint it with [Canvas.drawParagraph].
    /// </summary>
    public class ParagraphBuilder
    {
        private readonly ParagraphStyle _style;

        // TextStyle
        const int tsColorIndex = 1;
        const int tsTextDecorationIndex = 2;
        const int tsTextDecorationColorIndex = 3;
        const int tsTextDecorationStyleIndex = 4;
        const int tsFontWeightIndex = 5;
        const int tsFontStyleIndex = 6;
        const int tsTextBaselineIndex = 7;
        const int tsFontFamilyIndex = 8;
        const int tsFontSizeIndex = 9;
        const int tsLetterSpacingIndex = 10;
        const int tsWordSpacingIndex = 11;
        const int tsHeightIndex = 12;
        const int tsBackgroundIndex = 13;
        const int tsForegroundIndex = 14;
        const int tsTextShadowsIndex = 15;

        const int tsColorMask = 1 << tsColorIndex;
        const int tsTextDecorationMask = 1 << tsTextDecorationIndex;
        const int tsTextDecorationColorMask = 1 << tsTextDecorationColorIndex;
        const int tsTextDecorationStyleMask = 1 << tsTextDecorationStyleIndex;
        const int tsFontWeightMask = 1 << tsFontWeightIndex;
        const int tsFontStyleMask = 1 << tsFontStyleIndex;
        const int tsTextBaselineMask = 1 << tsTextBaselineIndex;
        const int tsFontFamilyMask = 1 << tsFontFamilyIndex;
        const int tsFontSizeMask = 1 << tsFontSizeIndex;
        const int tsLetterSpacingMask = 1 << tsLetterSpacingIndex;
        const int tsWordSpacingMask = 1 << tsWordSpacingIndex;
        const int tsHeightMask = 1 << tsHeightIndex;
        const int tsBackgroundMask = 1 << tsBackgroundIndex;
        const int tsForegroundMask = 1 << tsForegroundIndex;
        const int tsTextShadowsMask = 1 << tsTextShadowsIndex;


        // ParagraphStyle
        const int psTextAlignIndex = 1;
        const int psTextDirectionIndex = 2;
        const int psFontWeightIndex = 3;
        const int psFontStyleIndex = 4;
        const int psMaxLinesIndex = 5;
        const int psFontFamilyIndex = 6;
        const int psFontSizeIndex = 7;
        const int psLineHeightIndex = 8;
        const int psEllipsisIndex = 9;

        const int psTextAlignMask = 1 << psTextAlignIndex;
        const int psTextDirectionMask = 1 << psTextDirectionIndex;
        const int psFontWeightMask = 1 << psFontWeightIndex;
        const int psFontStyleMask = 1 << psFontStyleIndex;
        const int psMaxLinesMask = 1 << psMaxLinesIndex;
        const int psFontFamilyMask = 1 << psFontFamilyIndex;
        const int psFontSizeMask = 1 << psFontSizeIndex;
        const int psLineHeightMask = 1 << psLineHeightIndex;
        const int psEllipsisMask = 1 << psEllipsisIndex;

        // TextShadows decoding
        const uint ColorDefault = 0xFF000000;
        const uint BytesPerShadow = 16;
        const uint ShadowPropertiesCount = 4;
        const uint ColorOffset = 0;
        const uint XOffset = 1;
        const uint YOffset = 2;
        const uint BlurOffset = 3;


        //Txt.ParagraphBuilder m_paragraphBuilder;

        /// Creates a [ParagraphBuilder] object, which is used to create a [Paragraph].
        /// @pragma('vm:entry-point')
        public ParagraphBuilder(ParagraphStyle style)
        {
            _style = style;
            //m_paragraphBuilder = new Txt.ParagraphBuilder(style, font_collection.GetFontCollection());
        }

        /// Applies the given style to the added text until [pop] is called.
        ///
        /// See [Pop] for details.
        public void PushStyle(TextStyle style)
        {

        }

        /// Ends the effect of the most recent call to [pushStyle].
        ///
        /// Internally, the paragraph builder maintains a stack of text styles. Text
        /// added to the paragraph is affected by all the styles in the stack. Calling
        /// [pop] removes the topmost style in the stack, leaving the remaining styles
        /// in effect.
        public void Pop()
        {
            // native 'ParagraphBuilder_pop';
        }

        /// Adds the given text to the paragraph.
        ///
        /// The text will be styled according to the current stack of text styles.
        public void AddText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return;

            _text += text;

            // TODO:
            //m_paragraphBuilder->AddText(text);
        }

        /// Applies the given paragraph style and returns a [Paragraph] containing the
        /// added text and associated styling.
        ///
        /// After calling this function, the paragraph builder object is invalid and
        /// cannot be used further.
        public Paragraph Build()
        {
            return new Paragraph { Text = _text };
        }

        private string _text = "";

    }
}