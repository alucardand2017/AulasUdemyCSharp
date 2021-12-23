using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelQuartos
{
    class Reservas
    {
        private string nome;
        private string email;
        private int room;
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public int Room { get => room; set => room = value; }

        public override string ToString()
        {
            return
                "\nNome:  " + nome  +
                "\nEmail: " + email +
                "\nRoom: "  + room  ;
        }
    }

}
