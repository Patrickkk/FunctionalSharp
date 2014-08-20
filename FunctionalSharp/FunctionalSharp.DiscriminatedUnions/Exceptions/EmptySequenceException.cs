using System;

namespace FunctionalSharp.DiscriminatedUnions.Exceptions
{
    public class EmptySequenceException : Exception
    {
        public EmptySequenceException(string exceptionMessage) : base("The sequence does not contain any elements. " + exceptionMessage) { }

        public EmptySequenceException() : this("")
        {
        }
    }
}
