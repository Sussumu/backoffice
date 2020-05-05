using System;

namespace Backoffice.Application.Contracts
{
    public class Error
    {
        public string Message { get; }

        public Error(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Message cannot be null", nameof(message));

            Message = message;
        }
    }
}
