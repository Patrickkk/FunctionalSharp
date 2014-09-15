using System;

namespace FunctionalSharp.PatternMatching
{
    internal class DiscriminatedPatternMatchCase<T, TResult>
    {
        public Func<T, bool> Condition { get; set; }
        public int Order { get; set; }
        public Func<T, TResult> Value { get; set; }
    }
}
