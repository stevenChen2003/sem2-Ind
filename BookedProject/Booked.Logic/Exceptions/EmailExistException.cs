using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions
{
	public class EmailExistException : Exception
	{
		public EmailExistException(string msg) : base(msg)
		{

		}

		public EmailExistException(string message, Exception innerException) : base(message, innerException)
		{
		}

	}
}
