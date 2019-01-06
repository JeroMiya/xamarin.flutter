using System.Collections.Generic;

namespace FlutterBinding.UI
{
    /// An opaque object that determines the size, position, and rendering of text.
    public class TextStyle
    {
        public Color Color { get; }
        public TextDecoration Decoration { get; }
        public Color DecorationColor { get; }
        public TextDecorationStyle DecorationStyle { get; }
        public FontWeight FontWeight { get; }
        public FontStyle FontStyle { get; }
        public TextBaseline TextBaseline { get; }
        public string FontFamily { get; }
        public double FontSize { get; }
        public double LetterSpacing { get; }
        public double WordSpacing { get; }
        public double Height { get; }
        public Paint Background { get; }
        public Paint Foreground { get; }
        public List<Shadow> Shadows { get; }

        /// Creates a new TextStyle object.
        ///
        /// * `color`: The color to use when painting the text. If this is specified, `foreground` must be null.
        /// * `decoration`: The decorations to paint near the text (e.g., an underline).
        /// * `decorationColor`: The color in which to paint the text decorations.
        /// * `decorationStyle`: The style in which to paint the text decorations (e.g., dashed).
        /// * `fontWeight`: The typeface thickness to use when painting the text (e.g., bold).
        /// * `fontStyle`: The typeface variant to use when drawing the letters (e.g., italics).
        /// * `fontFamily`: The name of the font to use when painting the text (e.g., Roboto).
        /// * `fontSize`: The size of glyphs (in logical pixels) to use when painting the text.
        /// * `letterSpacing`: The amount of space (in logical pixels) to add between each letter.
        /// * `wordSpacing`: The amount of space (in logical pixels) to add at each sequence of white-space (i.e. between each word).
        /// * `textBaseline`: The common baseline that should be aligned between this text span and its parent text span, or, for the root text spans, with the line box.
        /// * `height`: The height of this text span, as a multiple of the font size.
        /// * `background`: The paint drawn as a background for the text.
        /// * `foreground`: The paint used to draw the text. If this is specified, `color` must be null.
        public TextStyle(
            Color color = null,
            TextDecoration decoration = TextDecoration.None,
            Color decorationColor = null,
            TextDecorationStyle decorationStyle = TextDecorationStyle.Solid,
            FontWeight fontWeight = null,
            FontStyle fontStyle = FontStyle.Normal,
            TextBaseline textBaseline = TextBaseline.Alphabetic,
            string fontFamily = null,
            double fontSize = 0.0,
            double letterSpacing = 0.0,
            double wordSpacing = 0.0,
            double height = 0.0,
            Paint background = null,
            Paint foreground = null,
            List<Shadow> shadows = null)
        {
            //assert(color == null || foreground == null,
            //        "Cannot provide both a color and a foreground\n" +
            //        "The color argument is just a shorthand for 'foreground: new Paint()..color = color'."
            //      );

            Color = color;
            Decoration = decoration;
            DecorationColor = decorationColor;
            DecorationStyle = decorationStyle;
            FontWeight = fontWeight;
            FontStyle = fontStyle;
            TextBaseline = textBaseline;
            FontFamily    = fontFamily ?? "";
            FontSize      = fontSize;
            LetterSpacing = letterSpacing;
            WordSpacing   = wordSpacing;
            Height        = height;
            Background    = background;
            Foreground    = foreground;
            Shadows       = shadows;
        }

        protected bool Equals(TextStyle other)
        {
            return Equals(Color, other.Color) && 
                Equals(Decoration, other.Decoration) && 
                Equals(DecorationColor, other.DecorationColor) && 
                DecorationStyle == other.DecorationStyle && 
                Equals(FontWeight, other.FontWeight) && 
                FontStyle == other.FontStyle && 
                TextBaseline == other.TextBaseline && 
                string.Equals(FontFamily, other.FontFamily) && 
                FontSize.Equals(other.FontSize) && 
                LetterSpacing.Equals(other.LetterSpacing) && 
                WordSpacing.Equals(other.WordSpacing) && 
                Height.Equals(other.Height) && 
                Equals(Background, other.Background) && 
                Equals(Foreground, other.Foreground) && 
                Equals(Shadows, other.Shadows);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TextStyle)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Color != null ? Color.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)Decoration;
                hashCode = (hashCode * 397) ^ (DecorationColor != null ? DecorationColor.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)DecorationStyle;
                hashCode = (hashCode * 397) ^ (FontWeight != null ? FontWeight.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (int)FontStyle;
                hashCode = (hashCode * 397) ^ (int)TextBaseline;
                hashCode = (hashCode * 397) ^ (FontFamily != null ? FontFamily.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ FontSize.GetHashCode();
                hashCode = (hashCode * 397) ^ LetterSpacing.GetHashCode();
                hashCode = (hashCode * 397) ^ WordSpacing.GetHashCode();
                hashCode = (hashCode * 397) ^ Height.GetHashCode();
                hashCode = (hashCode * 397) ^ (Background != null ? Background.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Foreground != null ? Foreground.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Shadows != null ? Shadows.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(TextStyle left, TextStyle right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TextStyle left, TextStyle right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return "TextStyle(" +
                $"color: {Color}, " +
                $"decoration: {Decoration}, " +
                $"decorationColor:{DecorationColor}, " +
                $"decorationStyle: {DecorationStyle}, " +
                $"fontWeight: {FontWeight}, " +
                $"fontStyle: {FontStyle}, " +
                $"textBaseline: {TextBaseline}, " +
                $"fontFamily: {FontFamily}, " +
                $"fontSize: {FontSize}, " +
                $"letterSpacing: {LetterSpacing}, " +
                $"wordSpacing: {WordSpacing}, " +
                $"height: {Height}, " +
                $"background: {Background}, " +
                $"foreground: {Foreground}, " +
                $"shadows: {Shadows}" +
                ")";
        }
    }
}