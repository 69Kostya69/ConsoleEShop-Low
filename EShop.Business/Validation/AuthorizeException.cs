using System.Net;

namespace EShop.Business.Validation
{
    public class AuthorizeException : CustomException
    {
        public AuthorizeException() : base()
        {
        }

        public AuthorizeException(string message) : base(message)
        {
        }

        public AuthorizeException(string message, HttpStatusCode code) : base(message, code)
        {
        }
    }
}
