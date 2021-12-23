using System;

namespace AluguelQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 10;
            Console.WriteLine("How many Rooms will be Rented?");
            int n = int.Parse(Console.ReadLine());
            Reservas[] Reserva = new Reservas[total];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");
                string aux1 = Console.ReadLine();
                Console.Write("Email: ");
                string aux2 = Console.ReadLine();
                Console.Write("Quarto: ");
                int aux3 = int.Parse(Console.ReadLine());

                if (Reserva[aux3] == null)
                    Reserva[aux3] = new Reservas { Nome = aux1, Email = aux2, Room = aux3 };
                else
                {
                    Console.WriteLine("Quarto já reservado! Por favor refaça essa operaçao!");
                    i--;
                }
            }
            for(int i = 0; i < total; i++)
            {
                if (Reserva[i] == null)
                    continue;
                Console.WriteLine(Reserva[i]);
            }
        }
    }
}
