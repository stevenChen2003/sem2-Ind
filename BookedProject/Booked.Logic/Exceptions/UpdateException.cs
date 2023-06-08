﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions
{
    public class UpdateException : Exception
    {
        public UpdateException(string msg) : base(msg)
        {

        }

        public UpdateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}