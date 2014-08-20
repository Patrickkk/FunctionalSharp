using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.LinqExtensions
{
    public static class SingleExtensions
    {
        public static T Single<T>(this IEnumerable<T> collection, Func<T, bool> predicate, string additionalExceptionInformation)
        {
            if (collection.Count() > 1)
            {
                throw new Exception("The sequence containes more than one element. " + additionalExceptionInformation);
            }

            var value = collection.Single();
            if (value == null)
            {
                throw new Exception("The sequence does not contain any elements. " + additionalExceptionInformation);
            }

            return value;
        }

        public static T Single<T>(this IEnumerable<T> collection, string additionalExceptionInformation)
        {
            return collection.Single(additionalExceptionInformation);
        }
    }
}
