using System;
namespace ExercicioFixacaoPedido.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Client()
        {
        }
        public Client(string name)
        {
            Name = name;
        }
        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public Client(string name, string email, DateTime birthDate) : this(name, email)
        {
            BirthDate = birthDate;
        }
    }
}
