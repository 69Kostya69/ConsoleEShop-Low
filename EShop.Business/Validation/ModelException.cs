using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Business.Validation
{
    public class ModelException : CustomException
    {
        public ModelException()
        {

        }

        public ModelException(string message) : base(message)
        {

        }
    }
}
