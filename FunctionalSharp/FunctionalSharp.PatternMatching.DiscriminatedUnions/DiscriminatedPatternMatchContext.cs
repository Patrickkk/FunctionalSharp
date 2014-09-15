using System;
using System.Collections.Generic;

namespace FunctionalSharp.PatternMatching
{
    public class DiscriminatedPatternMatchContext<T>
    {
        private readonly IEnumerable<T> values;

        internal DiscriminatedPatternMatchContext(IEnumerable<T> values)
        {
            this.values = values;
        }

        public DiscriminatedPatternMatch<T, TResult> With<TResult>(Func<T, bool> pattern, TResult resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public DiscriminatedPatternMatch<T, TResult> With<TResult>(Func<T, bool> pattern, Func<T, TResult> resultFunction)
        {
            return new DiscriminatedPatternMatch<T, TResult>(this.values, pattern, resultFunction);
        }

        public DiscriminatedPatternMatch<T, TResult> With<TResult>(T equalObject, TResult resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }
    }
}