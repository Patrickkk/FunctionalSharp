using NullGuard;
using System.Collections.Generic;
namespace FunctionalSharp.PatternMatching
{
    public static class PatternMatchExtensions
    {
        public static PatternMatchSingleContext<T> Match<T>([AllowNull]this T value)
        {
            return new PatternMatchSingleContext<T>(value);
        }

        public static PatternMatchContext<T> Match<T>([AllowNull]this IEnumerable<T> values)
        {
            return new PatternMatchContext<T>(values);
        }
    }
}
