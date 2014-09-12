using NullGuard;
using System;

namespace FunctionalSharp.OptionTypes
{
    [Serializable]
    public class None<T> : IOption<T>
    {
        public None()
        {
            if (default(T) != null)
            {
                throw new Exception("Option type used for non nullable type " + typeof(T).Name);
            }
        }

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

        [return: AllowNull]
        public T ToNullable()
        {
            return default(T);
        }

        public override string ToString()
        {
            return "null value for " + typeof(T).Name;
        }
    }
}
