using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSecao14Interface.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message): base(message)
        {
        }
    }
}
