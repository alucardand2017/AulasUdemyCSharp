﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoDictionary.Exceptions
{
    class ServiceException : ApplicationException
    {
        public ServiceException(string message): base(message)
        {
        }
    }
}