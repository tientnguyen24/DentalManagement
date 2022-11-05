using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Utillities.Exceptions
{
    public class DentalManagementException : Exception
    {
        public DentalManagementException()
        {

        }
        public DentalManagementException(string message) : base(message)
        {

        }
        public DentalManagementException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
