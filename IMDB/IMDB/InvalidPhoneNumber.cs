using System;

namespace IMDB
{
    internal class InvalidPhoneNumber : Exception
    {
        public InvalidPhoneNumber() { }

        public InvalidPhoneNumber(string message) : base(message)
        {

        }

        public InvalidPhoneNumber(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
