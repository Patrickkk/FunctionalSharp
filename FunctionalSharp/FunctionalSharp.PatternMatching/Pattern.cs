using System;
using System.Collections.ObjectModel;

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
            return new Pattern(CurrentCases, condition, action);
        }

        public Pattern OrElse(bool condition, Action action)
        {
            return new Pattern(CurrentCases, () => condition, action);
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
}