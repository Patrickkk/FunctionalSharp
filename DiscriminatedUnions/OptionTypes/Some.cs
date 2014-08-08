using System;

namespace OptionTypes
{
    [Serializable]
    public class Some<T> : IOption<T>
    {
        private T value;

        internal Some(T value)
        {
            this.value = value;
        }

        public void IfNotNullDo(Action<T> withValue)
        {
            withValue(value);
        }

        public void Match(Action<T> withValue, Action withoutValue)
        {
            withValue(value);
        }

        public TResult Match<TResult>(Func<T, TResult> withValue, TResult withoutValue)
        {
            return withValue(value);
        }

        public TResult Match<TResult>(Func<T, TResult> withValue, Func<TResult> withoutValue)
        {
            return withValue(value);
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
