using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.OptionTypes
{
    /// <summary>
    /// Provides extension methods for IEnumerable of IOption of T.
    /// </summary>
    public static class OptionTypeLinqExtensions
    {
        /// <summary>
        /// Returns all elements with a value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IEnumerable<T> WithValue<T>(this IEnumerable<IOption<T>> values)
        {
            return values.ToNullable().Where(item => item != null);
        }

        /// <summary>
        /// Returns all elements without a value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IEnumerable<T> WithoutValue<T>(this IEnumerable<IOption<T>> values)
        {
            return values.ToNullable().Where(item => item == null);
        }

        /// <summary>
        /// Turns all items into nullable values.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IEnumerable<T> ToNullable<T>(this IEnumerable<IOption<T>> values)
        {
            foreach (var item in values)
            {
                yield return item.ToNullable();
            }
        }
    }
}
