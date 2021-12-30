using System;
using System.Globalization;
using ExercicioFixacaoPedido.Entities.Enums;
using ExercicioFixacaoPedido.Entities;
namespace ExercicioFixacaoPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            //DADOS DO CLIENTE
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            client.Name = Console.ReadLine();
            Console.Write("Email: ");
            client.Email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            client.BirthDate = DateTime.Parse(Console.ReadLine());

            // CRIAÇÃO DA ORDEM e STATUS INICIAL
            Console.WriteLine("Enter order Data:");
            Order order = new Order();
            Console.Write("Status: ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());

            //DADOS DO PEDIDO
            int qntItems;
            Console.Write("How many items to this order: ");
            qntItems = int.Parse(Console.ReadLine());
            for (int i = 0; i < qntItems; i++)
            {
                Console.WriteLine("Enter #{0} item data: ", i + 1); 
                Console.Write("Product Name: ");
                string nameProductTemp = Console.ReadLine();
                Console.Write("Product Price: ");
                double priceProductTemp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qntProductTemp = int.Parse(Console.ReadLine());
                Product product = new Product(nameProductTemp, priceProductTemp);
                OrderItem orderItem = new OrderItem(qntProductTemp, priceProductTemp, product);
                order.addItem(orderItem);
                order.Cliente = client;
            }
            order.Moment = DateTime.Now;
            Console.WriteLine(order);
        }
    }
}
