using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.LinqExtensions
{
    public static class SingleExtensions
    {
        public static T Single<T>(this IEnumerable<T> collection, Func<T, bool> predicate, string additionalExceptionInformation)
        {
            return collection.Single(predicate,
                noResultsException: new Exception("The sequence does not contain any elements. " + additionalExceptionInformation),
                moreThanOneResultException: new Exception("The sequence containes more than one element. " + additionalExceptionInformation)
                );
        }

        public static T Single<T>(this IEnumerable<T> collection, Func<T, bool> predicate, Exception exceptionToThrow)
        {
            return collection.Single(predicate, exceptionToThrow, exceptionToThrow);
        }

        public static T Single<T>(this IEnumerable<T> collection, string additionalExceptionInformation)
        {
            return collection.Single(_ => { return true; }, additionalExceptionInformation);
        }

        public static T Single<T>(this IEnumerable<T> collection, Func<T, bool> predicate, Exception noResultsException, Exception moreThanOneResultException)
        {
            // take 2 elements to prevent iterating the entire collection.
            var firstTwoItems = collection.Take(2);
            if (firstTwoItems.Count() == 0)
            {
                throw noResultsException;
            }
            else if (firstTwoItems.Count() > 1)
            {
                throw moreThanOneResultException;
            }
            else
            {
                return firstTwoItems.First();
            }
        }
    }
}