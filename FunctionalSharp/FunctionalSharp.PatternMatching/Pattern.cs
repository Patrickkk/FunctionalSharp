using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FunctionalSharp.PatternMatching
{
    public class Pattern
    {
        public static Pattern MatchWith(Func<bool> condition, Action action)
        {
            return new Pattern(condition, action);
        }

        public static Pattern MatchWith(bool condition, Action action)
        {
            return new Pattern(() => condition, action);
        }

        public static Pattern<TResult> MatchWith<TResult>(bool condition, Func<TResult> function)
        {
            return new Pattern<TResult>(() => condition, function);
        }

        public static Pattern<TResult> MatchWith<TResult>(bool condition, TResult value)
        {
            return new Pattern<TResult>(() => condition, () => value);
        }

        public static Pattern<TResult> MatchWith<TResult>(Func<bool> condition, Func<TResult> function)
        {
            return new Pattern<TResult>(condition, function);
        }

        public static Pattern<TResult> MatchWith<TResult>(Func<bool> condition, TResult value)
        {
            return new Pattern<TResult>(condition, () => value);
        }

        public Pattern(Func<bool> condition, Action action)
        {
            CurrentCases = new ReadOnlyCollection<PatternMatchCase>(new PatternMatchCase[] { new PatternMatchCase(condition, action) });
        }

        public Pattern(ReadOnlyCollection<PatternMatchCase> exsistingCases, Func<bool> condition, Action action)
        {
            CurrentCases = exsistingCases.Add(new PatternMatchCase(condition, action));
        }

        public Pattern OrElse(Func<bool> condition, Action action)
        {
            return new Pattern(this.CurrentCases, condition, action);
        }

        public Pattern OrElse(bool condition, Action action)
        {
            return new Pattern(this.CurrentCases, () => condition, action);
        }

        public void Else(Action action)
        {
            foreach (var item in CurrentCases)
            {
                if (item.Condition())
                {
                    item.Action();
                    return;
                }
            }
            action();
        }

        public ReadOnlyCollection<PatternMatchCase> CurrentCases { get; }
    }

    public class Pattern<TResult>
    {
        public ReadOnlyCollection<PatternMatchCase<TResult>> CurrentCases { get; }

        public Pattern(Func<bool> pattern, Func<TResult> function)
        {
            var initialItem = new PatternMatchCase<TResult>(pattern, function);
            this.CurrentCases = new ReadOnlyCollection<PatternMatchCase<TResult>>(new PatternMatchCase<TResult>[] { initialItem });
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