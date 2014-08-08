using System;

namespace FunctionalSharp.OptionTypes
{
    public interface IOption<T>
    {
        void Match(Action<T> withValue, Action withoutValue);

        void IfNotNullDo(Action<T> withValue);

        TResult Match<TResult>(Func<T, TResult> withValue, Func<TResult> withoutValue);

        TResult Match<TResult>(Func<T, TResult> withValue, TResult withoutValue);
    }

    public static class OptionExtensions
    {
        public static IOption<T> ToOption<T>(this T value)
        {
            if (value == null)
            {
                return new None<T>();
            }
            else
            {
                return new Some<T>(value);
            }
        }
    }
}
