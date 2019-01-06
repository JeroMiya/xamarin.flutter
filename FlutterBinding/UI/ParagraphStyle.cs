using System;
using System.Collections.Generic;

namespace FlutterBinding.UI
{
    /// An opaque object that determines the configuration used by
    /// [ParagraphBuilder] to position lines within a [Paragraph] of text.
    public class ParagraphStyle
    {
        /// Creates a new ParagraphStyle object.
        ///
        /// * `textAlign`: The alignment of the text within the lines of the
        ///   paragraph. If the last line is ellipsized (see `ellipsis` below), the
        ///   alignment is applied to that line after it has been truncated but before
        ///   the ellipsis has been added.
        ///   See: https://github.com/flutter/flutter/issues/9819
        ///
        /// * `textDirection`: The directionality of the text, left-to-right (e.g.
        ///   Norwegian) or right-to-left (e.g. Hebrew). This controls the overall
        ///   directionality of the paragraph, as well as the meaning of
        ///   [TextAlign.start] and [TextAlign.end] in the `textAlign` field.
        ///
        /// * `fontWeight`: The typeface thickness to use when painting the text
        ///   (e.g., bold).
        ///
        /// * `fontStyle`: The typeface variant to use when drawing the letters (e.g.,
        ///   italics).
        ///
        /// * `maxLines`: The maximum number of lines painted. Lines beyond this
        ///   number are silently dropped. For example, if `maxLines` is 1, then only
        ///   one line is rendered. If `maxLines` is null, but `ellipsis` is not null,
        ///   then lines after the first one that overflows the width constraints are
        ///   dropped. The width constraints are those set in the
        ///   [ParagraphConstraints] object passed to the [Paragraph.layout] method.
        ///
        /// * `fontFamily`: The name of the font to use when painting the text (e.g.,
        ///   Roboto).
        ///
        /// * `fontSize`: The size of glyphs (in logical pixels) to use when painting
        ///   the text.
        ///
        /// * `lineHeight`: The minimum height of the line boxes, as a multiple of the
        ///   font size.
        ///
        /// * `ellipsis`: String used to ellipsize overflowing text. If `maxLines` is
        ///   not null, then the `ellipsis`, if any, is applied to the last rendered
        ///   line, if that line overflows the width constraints. If `maxLines` is
        ///   null, then the `ellipsis` is applied to the first line that overflows
        ///   the width constraints, and subsequent lines are dropped. The width
        ///   constraints are those set in the [ParagraphConstraints] object passed to
        ///   the [Paragraph.layout] method. The empty string and the null value are
        ///   considered equivalent and turn off this behavior.
        public ParagraphStyle(
            TextAlign textAlign = TextAlign.Left,
            TextDirection textDirection = TextDirection.Ltr,
            FontWeight fontWeight = null,
            FontStyle fontStyle = FontStyle.Normal,
            int maxLines = 0,
            string fontFamily = "",
            double fontSize = 0.0,
            double lineHeight = 0.0,
            string ellipsis = "")
        {
            if (fontFamily == null)
                throw new ArgumentNullException(nameof(fontFamily));
            if (fontWeight == null)
                fontWeight = FontWeight.Normal;

            TextAlign = textAlign;
            TextDirection = textDirection;
            FontWeight = fontWeight;
            FontStyle = fontStyle;
            MaxLines = maxLines;
            FontFamily = fontFamily;
            FontSize   = fontSize;
            LineHeight = lineHeight;
            Ellipsis   = ellipsis;
        }

        public TextAlign TextAlign { get; }
        public TextDirection TextDirection { get; }
        public FontWeight FontWeight { get; }
        public FontStyle FontStyle { get; }
        public int MaxLines { get; }
        public string FontFamily { get; }
        public double FontSize { get; }
        public double LineHeight { get; }
        public string Ellipsis { get; }

        protected bool Equals(ParagraphStyle other)
        {
            return TextAlign == other.TextAlign && 
                TextDirection == other.TextDirection && 
                Equals(FontWeight, other.FontWeight) && 
                FontStyle == other.FontStyle && 
                MaxLines == other.MaxLines && 
                string.Equals(FontFamily, other.FontFamily) && 
                FontSize.Equals(other.FontSize) && 
                LineHeight.Equals(other.LineHeight) && 
                string.Equals(Ellipsis, other.Ellipsis);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ParagraphStyle)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)TextAlign;
                hashCode = (hashCode * 397) ^ (int)TextDirection;
                hashCode = (hashCode * 397) ^ (FontWeight != null ? FontWeight.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)FontStyle;
                hashCode = (hashCode * 397) ^ MaxLines;
                hashCode = (hashCode * 397) ^ (FontFamily != null ? FontFamily.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ FontSize.GetHashCode();
                hashCode = (hashCode * 397) ^ LineHeight.GetHashCode();
                hashCode = (hashCode * 397) ^ (Ellipsis != null ? Ellipsis.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(ParagraphStyle left, ParagraphStyle right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ParagraphStyle left, ParagraphStyle right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return $"{GetType()}(" +
                $"textAlign: {TextAlign}, " +
                $"textDirection: {TextDirection}, " +
                $"fontWeight: {FontWeight}, " +
                $"fontStyle: {FontStyle}, " +
                $"maxLines: {MaxLines}, " +
                $"fontFamily: {FontFamily}, " +
                $"fontSize: {FontSize}, " +
                $"lineHeight: {LineHeight}, " +
                $"ellipsis: {Ellipsis} )";
        }
    }
}