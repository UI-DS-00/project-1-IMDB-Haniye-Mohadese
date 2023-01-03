using System;

namespace IMDB
{
    internal class InvalidEmptyInput : Exception
    {
        public InvalidEmptyInput() { }

        public InvalidEmptyInput(string message) : base(message)
        {
        }

        public InvalidEmptyInput(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
