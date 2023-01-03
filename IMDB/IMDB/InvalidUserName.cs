using System;

namespace IMDB
{
    internal class InvalidUserName : Exception
    {
        public InvalidUserName() { }

        public InvalidUserName(string message) : base(message)
        {
        }

        public InvalidUserName(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
