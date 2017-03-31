using System;

namespace FunctionalSharp.DiscriminatedUnions
{
    /// <summary>
    /// An Exception that indicates that the sequence is empty.
    /// </summary>
    public class EmptySequenceException : Exception
    {
        /// <summary>
        /// Creates a new Emptyexception instance with the givven message.
        /// </summary>
        /// <param name="exceptionMessage"></param>
        public EmptySequenceException(string exceptionMessage) : base("The sequence does not contain any elements. " + exceptionMessage) { }

        /// <summary>
        /// Creates a new Emptyexception instance.
        /// </summary>
        public EmptySequenceException() : this("")
        {
        }
    }
}