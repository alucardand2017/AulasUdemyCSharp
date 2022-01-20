using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto.Exceptions
{
    class ServiceExceptions : ApplicationException
    {
        public ServiceExceptions(string message): base(message)
        {
        }
    }
}
