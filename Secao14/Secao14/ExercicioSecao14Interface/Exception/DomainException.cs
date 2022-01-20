using System;

namespace ExercicioSecao14Interface.Exception
{
    class DomainException : ApplicationException
    {
        public DomainException(string message): base(message)
        {
        }
    }
}
