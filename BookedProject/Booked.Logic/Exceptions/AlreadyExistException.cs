using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions
{
    public class AlreadyExistException : Exception
    {
        public AlreadyExistException(string msg) : base(msg)
        {

        }

        public AlreadyExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
