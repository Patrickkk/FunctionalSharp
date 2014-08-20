using FunctionalSharp.DiscriminatedUnions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalSharp.DiscriminatedUnions
{
    public static class LinqExtensions
    {
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
