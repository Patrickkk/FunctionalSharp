using System;

namespace FunctionalSharp.PatternMatching
{
    public class PatternMatchCase
    {
        public Action Action { get; }

        public Func<bool> Condition { get; set; }

        public PatternMatchCase(Func<bool> condition, Action action)
        {
            this.Action = action;
            this.Condition = condition;
        }
    }
}