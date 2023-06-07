using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions.HotelException
{
    public class AddHotelException : Exception
    {
        public AddHotelException(string msg) : base(msg)
        {

        }

        public AddHotelException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
