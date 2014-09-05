using System;

namespace FunctionalSharp.PatternMatching
{
    public class PatternMatchCase<T, TResult>
    {
        public Func<T, bool> Condition { get; set; }
        public Func<T, TResult> Value { get; set; }
    }
}
