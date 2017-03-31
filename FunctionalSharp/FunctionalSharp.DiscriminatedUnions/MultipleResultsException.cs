using System;

namespace FunctionalSharp.DiscriminatedUnions
{
    /// <summary>
    /// An exception indicating that the sequence
    /// </summary>
    public class MultipleResultsException : Exception
    {
        /// <summary>
        /// Creates a new MultipleResultsException with aditional information in the message.
        /// </summary>
        /// <param name="message"></param>
        public MultipleResultsException(string message) : base("The sequence contains multiple elements. " + message)
        {
        }

        /// <summary>
        /// Creates a new MultipleResultsException with the default message.
        /// </summary>
        public MultipleResultsException() : this("")
        {
        }
    }
}