using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions
{
    public class HotelExistException : Exception
    {
        public HotelExistException(string msg) : base(msg)
        {

        }

        public HotelExistException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
