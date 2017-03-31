using System;

namespace FunctionalSharp.OptionTypes
{
    /// <summary>
    /// Represents an option type with a value of T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class Some<T> : IOption<T>
    {
        private T value;

        /// <summary>
        /// Creates a new Some of T.
        /// </summary>
        /// <param name="value"></param>
        internal Some(T value)
        {
            this.value = value;
        }

        /// <summary>
        /// Performs the action with the value.
        /// </summary>
        /// <param name="withValue"></param>
        public void IfNotNullDo(Action<T> withValue)
        {
            withValue(value);
        }

        /// <summary>
        /// performs the withvalue action.
        /// </summary>
        /// <param name="withValue"></param>
        /// <param name="withoutValue"></param>
        public void Match(Action<T> withValue, Action withoutValue)
        {
            withValue(value);
        }

        /// <summary>
        /// performs the withvalue function to get a value of TResult.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="withValue"></param>
        /// <param name="withoutValue"></param>
        /// <returns></returns>
        public TResult Match<TResult>(Func<T, TResult> withValue, TResult withoutValue)
        {
            return withValue(value);
        }

        /// <summary>
        /// Performas the withvalue function.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="withValue"></param>
        /// <param name="withoutValue"></param>
        /// <returns></returns>
        public TResult Match<TResult>(Func<T, TResult> withValue, Func<TResult> withoutValue)
        {
            return withValue(value);
        }

        /// <summary>
        /// returns the value of T.
        /// </summary>
        /// <returns></returns>
        public T ToNullable()
        {
            return value;
        }

        /// <summary>
        /// returns the tostring method of T.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
