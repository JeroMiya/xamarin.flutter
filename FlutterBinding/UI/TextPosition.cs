namespace FlutterBinding.UI
{
    /// A visual position in a string of text.
    public class TextPosition
    {
        /// Creates an object representing a particular position in a string.
        ///
        /// The arguments must not be null (so the [offset] argument is required).
        public TextPosition(
            int offset = 0,
            TextAffinity affinity = TextAffinity.Downstream)
        {
            //assert(offset != null),
            //assert(affinity != null);
            Offset   = offset;
            Affinity = affinity;
        }

        /// The index of the character that immediately follows the position.
        ///
        /// For example, given the string `'Hello'`, offset 0 represents the cursor
        /// being before the `H`, while offset 5 represents the cursor being just
        /// after the `o`.
        public int Offset { get; }

        /// If the offset has more than one visual location (e.g., occurs at a line
        /// break), which of the two locations is represented by this position.
        ///
        /// For example, if the text `'AB'` had a forced line break between the `A`
        /// and the `B`, then the downstream affinity at offset 1 represents the
        /// cursor being just after the `A` on the first line, while the upstream
        /// affinity at offset 1 represents the cursor being just before the `B` on
        /// the first line.
        public TextAffinity Affinity { get; }

        protected bool Equals(TextPosition other)
        {
            return Offset == other.Offset && Affinity == other.Affinity;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TextPosition)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (Offset * 397) ^ (int)Affinity;
            }
        }

        public static bool operator ==(TextPosition left, TextPosition right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TextPosition left, TextPosition right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            return $"{GetType()}(offset: {Offset}, affinity: {Affinity})";
        }
    }
}