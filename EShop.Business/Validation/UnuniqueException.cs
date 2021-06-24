using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Business.Validation
{
   
    public class UnuniqueException : CustomException
    {
        public UnuniqueException()
        {

        }

        public UnuniqueException(string message) : base(message)
        {

        }
    }
}
