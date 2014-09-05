using System;

namespace FunctionalSharp.PatternMatching
{
    public class PatternMatchSingleContext<T>
    {

        private readonly T value;

        internal PatternMatchSingleContext(T value)
        {
            this.value = value;
        }

        public PatternMatchSingle<T, TResult> With<TResult>(Func<T, bool> pattern, TResult resultValue)
        {
            return With(this.value, pattern, _ => resultValue);
        }

        private PatternMatchSingle<T, TResult> With<TResult>(T value, Func<T, bool> pattern, Func<T, TResult> result)
        {
            return new PatternMatchSingle<T, TResult>(value, pattern, result);
        }
    }
}
