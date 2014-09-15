using System.Collections.Generic;

namespace FunctionalSharp.PatternMatching
{
    public static class DiscriminatedPatternMatchExtensions
    {
        public static DiscriminatedPatternMatchContext<T> MatchDiscriminated<T>(this IEnumerable<T> values)
        {
            return new DiscriminatedPatternMatchContext<T>(values);
        }
    }
}
