using System;
using System.Collections.ObjectModel;

namespace FunctionalSharp.PatternMatching
{

    public class Pattern<TResult>
    {
        public ReadOnlyCollection<PatternMatchCase<TResult>> CurrentCases { get; }

        public Pattern(Func<bool> pattern, Func<TResult> function)
        {
            var initialItem = new PatternMatchCase<TResult>(pattern, function);
            CurrentCases = new ReadOnlyCollection<PatternMatchCase<TResult>>(new PatternMatchCase<TResult>[] { initialItem });
        }

        public Pattern(ReadOnlyCollection<PatternMatchCase<TResult>> exsistingCases, Func<bool> pattern, Func<TResult> function)
        {
            CurrentCases = exsistingCases.Add(new PatternMatchCase<TResult>(pattern, function));
        }

        public Pattern<TResult> OrElse(bool condition, Func<TResult> function)
        {
            return new Pattern<TResult>(CurrentCases, () => condition, function);
        }

        public Pattern<TResult> OrElse(bool condition, TResult value)
        {
            return new Pattern<TResult>(CurrentCases, () => condition, () => value);
        }

        public Pattern<TResult> OrElse(Func<bool> condition, Func<TResult> function)
        {
            return new Pattern<TResult>(CurrentCases, condition, function);
        }

        public Pattern<TResult> OrElse(Func<bool> condition, TResult value)
        {
            return new Pattern<TResult>(CurrentCases, condition, () => value);
        }

        public TResult Else(TResult value)
        {
            return Else(() => value);
        }

        public TResult Else(Func<TResult> function)
        {
            foreach (var item in CurrentCases)
            {
                if (item.Condition())
                {
                    return item.Action();
                }
            }
            return function();
        }
    }
}
