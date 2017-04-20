using System;
using System.Collections.Generic;

namespace FunctionalSharp.PatternMatching
{
    public class PatternMatchSingleAction<T>
    {
        private readonly T value;
        private readonly List<PatternMatchActionCase<T>> matches = new List<PatternMatchActionCase<T>>();

        internal PatternMatchSingleAction(T value, Func<T, bool> pattern, Action<T> result)
        {
            this.value = value;
            With(pattern, result);
        }

        public PatternMatchSingleAction<T> With(Func<T, bool> pattern, Action action)
        {
            return With(pattern, _ => action());
        }

        public PatternMatchSingleAction<T> With(T equalObject, Action action)
        {
            return With(value => value.Equals(equalObject), _ => action());
        }

        public PatternMatchSingleAction<T> With(T equalObject, Action<T> action)
        {
            return With(value => value.Equals(equalObject), action);
        }

        public PatternMatchSingleAction<T> With(Func<T, bool> pattern, Action<T> action)
        {
            matches.Add(new PatternMatchActionCase<T>
            {
                Condition = pattern,
                Action = action
            });
            return this;
        }

        public void Else(Action<T> action)
        {
            foreach (var match in matches)
            {
                if (match.Condition(value))
                {
                    match.Action(value);
                }
            }
            action(value);
        }

        public void Else(Action action)
        {
            Else(_ => action());
        }

        public void ElseException()
        {
            ElseException(new Exception("No Pattern matched"));
        }

        public void ElseException(Exception exception)
        {
            Else(_ => { throw exception; });
        }

        public void ElseNothing()
        {
            Else(_ => { });
        }
    }
}
