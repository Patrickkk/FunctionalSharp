using System;

namespace FunctionalSharp.PatternMatching
{
    class PatternMatchActionCase<T>
    {
        public Func<T, bool> Condition { get; set; }
        public Action<T> Action { get; set; }
    }
}
