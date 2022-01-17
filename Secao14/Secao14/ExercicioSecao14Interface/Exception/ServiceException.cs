using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao14Interface.Exception
{
    class ServiceException : ApplicationException
    {
        public ServiceException(string message): base (message)
        {
        }
    }
}
