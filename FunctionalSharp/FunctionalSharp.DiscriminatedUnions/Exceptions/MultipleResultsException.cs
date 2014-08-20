using System;

namespace FunctionalSharp.DiscriminatedUnions.Exceptions
{
    public class MultipleResultsException : Exception
    {

        public MultipleResultsException(string message) : base("The sequence contains multiple elements. " + message)
        {
        }

        public MultipleResultsException() : this("")
        {
        }
    }
}
