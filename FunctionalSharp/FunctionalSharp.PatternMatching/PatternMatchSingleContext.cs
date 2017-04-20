using NullGuard;
using System;

namespace FunctionalSharp.PatternMatching
{
    public class PatternMatchSingleContext<T>
    {
        private readonly T value;

        internal PatternMatchSingleContext([AllowNull]T value)
        {
            this.value = value;
        }

        public PatternMatchSingle<T, TResult> With<TResult>(Func<T, bool> pattern, TResult resultValue)
        {
            return With(this.value, pattern, _ => resultValue);
        }

        public PatternMatchSingle<T, TResult> With<TResult>(Func<T, bool> pattern, Func<T, TResult> result)
        {
            return With(this.value, pattern, result);
        }

        public PatternMatchSingle<T, TResult> With<TResult>(T valueToMatch, TResult resultValue)
        {
            return With(this.value, value => value.Equals(valueToMatch), _ => resultValue);
        }

        public PatternMatchSingle<T, TResult> With<TResult>(T valueToMatch, Func<T, TResult> result)
        {
            return With(this.value, value => value.Equals(valueToMatch), result);
        }

        private PatternMatchSingle<T, TResult> With<TResult>(T valueToMatch, Func<T, bool> pattern, Func<T, TResult> result)
        {
            return new PatternMatchSingle<T, TResult>(value, pattern, result);
        }

        public PatternMatchSingleAction<T> With(Func<T, bool> pattern, Action action)
        {
            return With(this.value, pattern, _ => action());
        }

        public PatternMatchSingleAction<T> With(T valueToMatch, Action action)
        {
            return With(this.value, (value) => value.Equals(valueToMatch), _ => action());
        }

        private PatternMatchSingleAction<T> With(T value, Func<T, bool> pattern, Action<T> action)
        {
            return new PatternMatchSingleAction<T>(value, pattern, action);
        }
    }
}