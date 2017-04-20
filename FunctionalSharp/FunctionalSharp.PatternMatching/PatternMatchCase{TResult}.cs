using System;

namespace FunctionalSharp.PatternMatching
{
    public class PatternMatchCase<TResult>
    {
        public Func<TResult> Action { get; }

        public Func<bool> Condition { get; set; }

        public PatternMatchCase(Func<bool> condition, Func<TResult> action)
        {
            this.Action = action;
            this.Condition = condition;
        }
    }
}