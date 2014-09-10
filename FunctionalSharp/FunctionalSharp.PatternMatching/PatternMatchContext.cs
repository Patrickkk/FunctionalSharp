using System;
using System.Collections.Generic;

namespace FunctionalSharp.PatternMatching
{
    public class PatternMatchContext<T>
    {
        private readonly IEnumerable<T> values;

        internal PatternMatchContext(IEnumerable<T> values)
        {
            this.values = values;
        }

        public PatternMatch<T, TResult> With<TResult>(Func<T, bool> pattern, TResult resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public PatternMatch<T, TResult> With<TResult>(Func<T, bool> pattern, Func<T, TResult> resultFunction)
        {
            return new PatternMatch<T, TResult>(this.values, pattern, resultFunction);
        }

        public PatternMatch<T, TResult> With<TResult>(T equalObject, TResult resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }
    }
}
