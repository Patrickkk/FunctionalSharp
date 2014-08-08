using System;

namespace OptionTypes
{
    [Serializable]
    public class None<T> : IOption<T>
    {
        public void IfNotNullDo(Action<T> withValue)
        {

        }

        public void Match(Action<T> withValue, Action withoutValue)
        {
            withoutValue();
        }

        public TResult Match<TResult>(Func<T, TResult> withValue, TResult withoutValue)
        {
            return withoutValue;
        }

        public TResult Match<TResult>(Func<T, TResult> withValue, Func<TResult> withoutValue)
        {
            return withoutValue();
        }

        public override string ToString()
        {
            return "null value for " + typeof(T).Name;
        }
    }
}
