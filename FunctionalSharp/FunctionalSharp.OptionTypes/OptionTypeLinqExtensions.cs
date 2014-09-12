using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.OptionTypes
{
    public static class OptionTypeLinqExtensions
    {
        public static IEnumerable<T> WithValue<T>(this IEnumerable<IOption<T>> values)
        {
            return values.ToNullable().Where(item => item != null);
        }

        public static IEnumerable<T> WithoutValue<T>(this IEnumerable<IOption<T>> values)
        {
            return values.ToNullable().Where(item => item == null);
        }

        public static IEnumerable<T> ToNullable<T>(this IEnumerable<IOption<T>> values)
        {
            foreach (var item in values)
            {
                yield return item.ToNullable();
            }
        }
    }
}
