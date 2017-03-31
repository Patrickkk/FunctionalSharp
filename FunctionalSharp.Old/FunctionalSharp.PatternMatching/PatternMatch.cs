using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.PatternMatching
{
    public class PatternMatch<T, TResult>
    {
        private readonly IEnumerable<T> values;
        private readonly List<PatternMatchCase<T, TResult>> matches = new List<PatternMatchCase<T, TResult>>();

        public PatternMatch(IEnumerable<T> values, Func<T, bool> pattern, Func<T, TResult> resultValue)
        {
            this.values = values;
            With(pattern, resultValue);
        }

        public PatternMatch<T, TResult> With(Func<T, bool> pattern, TResult resultValue)
        {
            return With(pattern, _ => resultValue);
        }

        public PatternMatch<T, TResult> With(T equalObject, TResult resultValue)
        {
            return With(value => value.Equals(equalObject), _ => resultValue);
        }

        public PatternMatch<T, TResult> With(Func<T, bool> pattern, Func<T, TResult> result)
        {
            matches.Add(new PatternMatchCase<T, TResult>
            {
                Condition = pattern,
                Value = result
            });
            return this;
        }

        public IEnumerable<TResult> Else(Func<T, TResult> result)
        {
            foreach (var value in values)
            {
                var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                if (match != null)
                {
                    yield return match.Value(value);
                }
                else
                {
                    yield return result(value);
                }
            }
        }

        public IEnumerable<TResult> Else(TResult result)
        {
            return Else(_ => result);
        }

        public IEnumerable<TResult> ElseException()
        {
            return ElseException(new Exception("No Pattern matched"));
        }

        public IEnumerable<TResult> ElseException(Exception exception)
        {
            return Else(_ => { throw exception; });
        }
    }
}
