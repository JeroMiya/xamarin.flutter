using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flutter.Shell
{
    public static class EnumerableExtensions
    {
        public static string ToDisplay<T>(this IEnumerable<T> array) => string.Join(", ", array);
    }
}
