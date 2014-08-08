using System;
using System.Collections.Generic;
namespace FunctionalSharp.PatternMatching
{
    public class PatternMatchCase<T, TResult>
    {
        public Func<T, bool> Condition { get; set; }
        public Func<T, TResult> Value { get; set; }
    }

    public class PatternMatch<T, TResult>
    {
        private readonly T value;
        private readonly List<PatternMatchCase<T, TResult>> matches = new List<PatternMatchCase<T, TResult>>();

        public PatternMatch(T value, Func<T, bool> pattern, Func<T, TResult> resultValue)
        {
            this.value = value;
            matches.Add(new PatternMatchCase<T, TResult>
            {
                Condition = pattern,
                Value = resultValue
            });
        }

        public PatternMatch<T, TResult> With(Func<T, bool> pattern, TResult resultValue)
        {
            matches.Add(new PatternMatchCase<T, TResult>
            {
                Condition = pattern,
                Value = _ => resultValue
            });
            return this;
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

        public TResult Else(Func<T, TResult> result)
        {
            foreach (var item in matches)
            {
                if (item.Condition(value))
                {
                    return item.Value(value);
                }
            }
            return result(value);
        }

        public TResult Else(TResult result)
        {
            return Else(_ => result);
        }
    }

    public class PatternMatchContext<T>
    {
        private readonly T value;

        internal PatternMatchContext(T value)
        {
            this.value = value;
        }

        public PatternMatch<T, TResult> With<TResult>(Func<T, bool> pattern, TResult resultValue)
        {
            return new PatternMatch<T, TResult>(this.value, pattern, _ => resultValue);
        }

        public PatternMatch<T, TResult> With<TResult>(Func<T, bool> pattern, Func<T, TResult> result)
        {
            return new PatternMatch<T, TResult>(this.value, pattern, result);
        }
    }

    public static class PatternMatchExtensions
    {
        public static PatternMatchContext<T> Match<T>(this T value)
        {
            return new PatternMatchContext<T>(value);
        }
    }
}
