using System.Collections.Generic;

namespace FlutterBinding.Extensions
{
    public static class EnumerableExtensions
    {
        public static string ToDisplay<T>(this IEnumerable<T> array) => string.Join(", ", array);
    }
}
