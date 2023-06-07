using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions.HotelException
{
    public class UpdateHotelException : Exception
    {
        public UpdateHotelException(string msg) : base(msg)
        {

        }

        public UpdateHotelException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
