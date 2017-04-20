using System;
using System.Collections.Generic;

namespace FunctionalSharp.PatternMatching
{
    public class PatternMatchSingle<T, TResult>
    {
        private readonly T value;
        private readonly List<PatternMatchCase<T, TResult>> matches = new List<PatternMatchCase<T, TResult>>();

        internal PatternMatchSingle(T value, Func<T, bool> pattern, Func<T, TResult> result)
        {
            this.value = value;
            With(pattern, result);
        }

        public PatternMatchSingle<T, TResult> With(Func<T, bool> pattern, TResult resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public PatternMatchSingle<T, TResult> With(T equalObject, TResult resultValue)
        {
            return With(value => value.Equals(equalObject), resultValue);
        }

        public PatternMatchSingle<T, TResult> With(T equalObject, Func<T, TResult> resultFunction)
        {
            return With(value => value.Equals(equalObject), resultFunction);
        }

        public PatternMatchSingle<T, TResult> With(Func<T, bool> pattern, Func<T, TResult> resultFunction)
        {
            matches.Add(new PatternMatchCase<T, TResult>
            {
                Condition = pattern,
                Value = resultFunction
            });
            return this;
        }

        public TResult Else(Func<T, TResult> result)
        {
            foreach (var match in matches)
            {
                if (match.Condition(value))
                {
                    return match.Value(value);
                }
            }
            return result(value);
        }

        public TResult Else(TResult result)
        {
            return Else(_ => result);
        }

        public TResult ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public TResult ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }
    }
}