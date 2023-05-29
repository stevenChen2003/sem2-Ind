using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions
{
    public class FlightExistException : Exception
    {
        public FlightExistException(string msg) : base(msg)
        {

        }

        public FlightExistException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
