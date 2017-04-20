using NullGuard;
using System.Collections.Generic;
namespace FunctionalSharp.PatternMatching
{
    public static class PatternMatchExtensions
    {
        /// <summary>
        /// Starts a pattern match for a single value. Subsequent calls to With() need to be used to specify conditions
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">value to match. Can be Null</param>
        /// <returns></returns>
        public static PatternMatchSingleContext<T> Match<T>([AllowNull]this T value)
        {
            return new PatternMatchSingleContext<T>(value);
        }

        /// <summary>
        /// Starts a pattern match. Subsequent calls to With() need to be used to specify conditions
        /// </summary>
        /// <typeparam name="T">Type to Match</typeparam>
        /// <param name="values">Values to Match</param>
        /// <returns></returns>
        public static PatternMatchContext<T> Match<T>(this IEnumerable<T> values)
        {
            return new PatternMatchContext<T>(values);
        }
    }
}
