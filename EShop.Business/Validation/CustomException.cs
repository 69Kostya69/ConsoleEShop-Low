using System;
using System.Net;

namespace EShop.Business.Validation
{
    public class CustomException : Exception
    {
        protected readonly HttpStatusCode _statuscode;

        public CustomException() : base()
        {

        }

        public CustomException(string message) : base(message)
        {

        }

        public CustomException(string message, HttpStatusCode code) : base(message)
        {
            _statuscode = code;
        }
    }
}
