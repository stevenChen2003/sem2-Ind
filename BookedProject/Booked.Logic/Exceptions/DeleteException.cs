﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Exceptions
{
    public class DeleteException : Exception
    {
        public DeleteException(string msg) : base(msg)
        {

        }

        public DeleteException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
