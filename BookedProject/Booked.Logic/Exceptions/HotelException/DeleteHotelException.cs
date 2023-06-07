using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions.HotelException
{
    public class DeleteHotelException : Exception
    {
        public DeleteHotelException(string msg) : base(msg)
        {

        }

        public DeleteHotelException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
