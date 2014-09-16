using NullGuard;
using System;

namespace FunctionalSharp.OptionTypes
{
    /// <summary>
    /// The interface for an option type. It Might hold a value, if so it is Some of Type T. Else it is implemented by None of type T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IOption<T>
    {
        /// <summary>
        /// Depending on weither the option actually holds a value the <paramref name="withValue"/> is executed or the <paramref name="withoutValue"/> is executed.
        /// </summary>
        /// <param name="withValue"></param>
        /// <param name="withoutValue"></param>
        void Match(Action<T> withValue, Action withoutValue);

        /// <summary>
        /// Performs the Action <paramref name="withValue"/> if a value is available.
        /// </summary>
        /// <param name="withValue"></param>
        void IfNotNullDo(Action<T> withValue);

        /// <summary>
        /// Converts the IOption to T.
        /// </summary>
        /// <returns></returns>
        T ToNullable();

        /// <summary>
        /// depending on weither the option holds a value or not the given function is executed to produce a returnvalue.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="withValue"></param>
        /// <param name="withoutValue"></param>
        /// <returns></returns>
        TResult Match<TResult>(Func<T, TResult> withValue, Func<TResult> withoutValue);

        /// <summary>
        /// depending on weither the option holds a value or not the given values are returned.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="withValue"></param>
        /// <param name="withoutValue"></param>
        /// <returns></returns>
        TResult Match<TResult>(Func<T, TResult> withValue, TResult withoutValue);
    }

    /// <summary>
    /// contains extensionmethods for the option type
    /// </summary>
    public static class OptionExtensions
    {
        /// <summary>
        /// Turns the type T into an option type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IOption<T> ToOption<T>([AllowNull] this T value)
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
