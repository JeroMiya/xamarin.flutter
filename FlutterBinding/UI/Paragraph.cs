using System.Collections.Generic;
using FlutterBinding.Engine.Text;
using SkiaSharp;

namespace FlutterBinding.UI {
    /// A paragraph of text.
    ///
    /// A paragraph retains the size and position of each glyph in the text and can
    /// be efficiently resized and painted.
    ///
    /// To create a [Paragraph] object, use a [ParagraphBuilder].
    ///
    /// Paragraphs can be displayed on a [Canvas] using the [Canvas.drawParagraph]
    /// method.
    public class Paragraph
    {
        /// This class is created by the engine, and should not be instantiated
        /// or extended directly.
        ///
        /// To create a [Paragraph] object, use a [ParagraphBuilder].
        //@pragma('vm:entry-point')
        public Paragraph() { }

        public string Text { get; set; }

        private double _width;

        // Temporary, to use for all text, until SkiaSharp can be updated
        private readonly SKPaint _paint = new SKPaint
        {
            Color       = SKColors.Black,
            IsAntialias = true,
            Style       = SKPaintStyle.Fill,
            TextAlign   = SKTextAlign.Center,
            TextSize    = 24
        };

        public void Paint(SKCanvas canvas, double x, double y)
        {
            canvas.DrawText(Text, (float)x, (float)y, _paint);
        }

        public void Layout(double width)
        {
            _width = width;
        }

        /// The amount of horizontal space this paragraph occupies.
        /// Valid only after [layout] has been called.
        public float Width => _paint.MeasureText(Text);

        /// The amount of vertical space this paragraph occupies.
        /// Valid only after [layout] has been called.
        public float Height => 24;

        /// The minimum width that this paragraph could be without failing to paint
        /// its contents within itself.
        ///
        /// Valid only after [layout] has been called.
        public double MinIntrinsicWidth => 0.0; // native 'Paragraph_minIntrinsicWidth';

        /// Returns the smallest width beyond which increasing the width never
        /// decreases the height.
        ///
        /// Valid only after [layout] has been called.
        public static double MaxIntrinsicWidth => 0.0; // native 'Paragraph_maxIntrinsicWidth';

        /// The distance from the top of the paragraph to the alphabetic
        /// baseline of the first line, in logical pixels.
        public double AlphabeticBaseline => 0.0; // native 'Paragraph_alphabeticBaseline';

        /// The distance from the top of the paragraph to the ideographic
        /// baseline of the first line, in logical pixels.
        public double IdeographicBaseline => 0.0; // native 'Paragraph_ideographicBaseline';

        /// True if there is more vertical content, but the text was truncated, either
        /// because we reached `maxLines` lines of text or because the `maxLines` was
        /// null, `ellipsis` was not null, and one of the lines exceeded the width
        /// constraint.
        ///
        /// See the discussion of the `maxLines` and `ellipsis` arguments at [new
        /// ParagraphStyle].
        public bool DidExceedMaxLines => false; // native 'Paragraph_didExceedMaxLines';

        /// Computes the size and position of each glyph in the paragraph.
        ///
        /// The [ParagraphConstraints] control how wide the text is allowed to be.
        public void Layout(ParagraphConstraints constraints)
        { 
            Layout(constraints.Width);
            // native 'Paragraph_layout';
        }

        /// Returns a list of text boxes that enclose the given text range.
        public List<TextBox> GetBoxesForRange(int start, int end)
        {
            // native 'Paragraph_getRectsForRange';
            return null;
        }

        /// Returns the text position closest to the given offset.
        TextPosition GetPositionForOffset(Offset offset)
        {
            List<int> encoded = null; //_getPositionForOffset(offset.dx, offset.dy);
            // native 'Paragraph_getPositionForOffset';
            return new TextPosition(offset: encoded[0], affinity: (TextAffinity)encoded[1]);
        }

        /// Returns the [start, end] of the word at the given offset. Characters not
        /// part of a word, such as spaces, symbols, and punctuation, have word breaks
        /// on both sides. In such cases, this method will return [offset, offset+1].
        /// Word boundaries are defined more precisely in Unicode Standard Annex #29
        /// http://www.unicode.org/reports/tr29/#Word_Boundaries
        public List<int> GetWordBoundary(int offset)
        {
            // native 'Paragraph_getWordBoundary';
            return null; 
        }
    }
}