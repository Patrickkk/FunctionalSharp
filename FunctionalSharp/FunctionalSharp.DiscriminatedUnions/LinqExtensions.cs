using FunctionalSharp.DiscriminatedUnions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.DiscriminatedUnions
{
    /// <summary>
    /// Provides linqextensions usng discriminated unions.
    /// </summary>
    public static class LinqExtensions
    {
        /// <summary>
        /// provides a mechanism to use Single on a collection that returns a discriminated union instead of an exception.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sequence"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static DiscriminatedUnion<T, MultipleResultsException, EmptySequenceException> SafeSingle<T>(this IEnumerable<T> sequence, Func<T, bool> predicate)
        {
            if (sequence.Any() == false)
                return new DiscriminatedUnion<T, MultipleResultsException, EmptySequenceException>(new EmptySequenceException());
            if (sequence.Skip(1).Any())
                return new DiscriminatedUnion<T, MultipleResultsException, EmptySequenceException>(new MultipleResultsException());

            return new DiscriminatedUnion<T, MultipleResultsException, EmptySequenceException>(sequence.First());
        }
    }
}
