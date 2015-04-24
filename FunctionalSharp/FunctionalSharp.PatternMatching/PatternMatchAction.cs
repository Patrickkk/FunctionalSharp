using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.PatternMatching
{
    public class PatternMatchAction<T>
    {
        private readonly IEnumerable<T> values;
        private readonly List<PatternMatchActionCase<T>> matches = new List<PatternMatchActionCase<T>>();

        public PatternMatchAction(IEnumerable<T> values, Func<T, bool> pattern, Action<T> action)
        {
            this.values = values;
            With(pattern, action);
        }

        public PatternMatchAction<T> With(T equalObject, Action action)
        {
            return With(value => value.Equals(equalObject), _ => action());
        }

        public PatternMatchAction<T> With(T equalObject, Action<T> action)
        {
            return With(value => value.Equals(equalObject), action);
        }

        public PatternMatchAction<T> With(Func<T, bool> pattern, Action action)
        {
            return With(pattern, _ => action());
        }

        public PatternMatchAction<T> With(Func<T, bool> pattern, Action<T> action)
        {
            matches.Add(new PatternMatchActionCase<T>
            {
                Condition = pattern,
                Action = action
            });
            return this;
        }

        public void Else(Action<T> result)
        {
            foreach (var value in values)
            {
                var match = matches.FirstOrDefault(matchItem => matchItem.Condition(value));
                if (match != null)
                {
                    match.Action(value);
                }
                else
                {
                    result(value);
                }
            }
        }

        public void ElseNothing()
        {
            Else(_ => { });
        }

        public void Else(Action result)
        {
            Else(_ => result());
        }

        public void ElseException()
        {
            ElseException(new Exception("No Pattern matched"));
        }

        public void ElseException(Exception exception)
        {
            Else(_ => { throw exception; });
        }
    }
}
