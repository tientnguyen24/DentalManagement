using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Utilities.Exceptions
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
