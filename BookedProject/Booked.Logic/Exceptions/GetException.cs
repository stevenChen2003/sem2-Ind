using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions
{
    public class GetException : Exception
    {
        public GetException(string msg) : base(msg)
        {

        }

        public GetException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
