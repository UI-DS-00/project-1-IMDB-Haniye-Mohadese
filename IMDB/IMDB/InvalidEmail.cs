using System;

namespace IMDB
{
    internal class InvalidEmail : Exception
    {
        public InvalidEmail() { }

        public InvalidEmail(string message) : base(message)
        {
        }

        public InvalidEmail(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
