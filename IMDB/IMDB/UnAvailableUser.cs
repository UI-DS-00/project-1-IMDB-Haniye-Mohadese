using System;

namespace IMDB
{
    internal class UnAvailableUser : Exception
    {
        public UnAvailableUser()
        {
        }

        public UnAvailableUser(string message) : base(message)
        {
        }

        public UnAvailableUser(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
