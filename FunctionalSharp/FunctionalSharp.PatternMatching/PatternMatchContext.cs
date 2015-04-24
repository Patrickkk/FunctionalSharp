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

        public PatternMatchAction<T> With(Func<T, bool> pattern, Action<T> callback)
        {
            return new PatternMatchAction<T>(this.values, pattern, callback);
        }

        public PatternMatchAction<T> With(Func<T, bool> pattern, Action callback)
        {
            return With(pattern, value => callback());
        }

        public PatternMatchAction<T> With(T equalObject, Action callback)
        {
            return With(value => value.Equals(equalObject), value => callback());
        }

        public PatternMatchAction<T> With(T equalObject, Action<T> callback)
        {
            return With(value => value.Equals(equalObject), value => callback(value));
        }
    }
}
