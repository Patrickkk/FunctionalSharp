using System;

namespace FunctionalSharp.OptionTypes
{
    [Serializable]
    public class Some<T> : IOption<T>
    {
        private T value;

        internal Some(T value)
        {
            if (default(T) != null)
            {
                throw new Exception("Option type used for non nullable type " + typeof(T).Name);
            }
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

        public T ToNullable()
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
