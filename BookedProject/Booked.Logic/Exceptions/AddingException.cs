﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions
{
    public class AddingException : Exception
    {
        public AddingException(string msg) : base(msg)
        {

        }

        public AddingException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
