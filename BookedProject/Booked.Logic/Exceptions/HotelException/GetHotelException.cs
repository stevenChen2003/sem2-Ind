using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions.HotelException
{
    public class GetHotelException : Exception
    {
        public GetHotelException(string msg) : base(msg)
        {

        }

        public GetHotelException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
