using System;
namespace ExercicioSecao14Interface.Exception
{
    class ServiceException : ApplicationException
    {
        public ServiceException(string message): base (message)
        {
        }
    }
}
