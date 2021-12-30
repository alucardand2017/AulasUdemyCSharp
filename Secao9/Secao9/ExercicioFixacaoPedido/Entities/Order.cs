using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixacaoPedido.Entities.Enums;
using System.Globalization;
namespace ExercicioFixacaoPedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();
        public Client Cliente { get; set; }
        public void addItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Item.Remove(item);
        }
        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }
        public override string ToString()
        {
            double sum = 0;
            StringBuilder builder = new StringBuilder();
            builder.Append("\nORDER SUMMARY: ");
            builder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            builder.Append("Order status: ");
            builder.AppendLine(Status.ToString());
            builder.Append(Cliente.Name);
            builder.Append(" - ");
            builder.AppendLine(Cliente.Email);
            builder.AppendLine("Order Items: ");
            foreach (OrderItem c in Item)
            {
                builder.Append(c.Product.Name);
                builder.Append(", ");
                builder.Append(c.Price.ToString("F2", CultureInfo.InvariantCulture));
                builder.Append(", Quantity: ");
                builder.Append(c.Quantity.ToString("F2", CultureInfo.InvariantCulture));
                builder.Append(", Subtotal: ");
                builder.AppendLine(c.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                sum += c.SubTotal();
            }
            builder.Append("Total price: ");
            builder.Append(sum.ToString("F2", CultureInfo.InvariantCulture));
            return builder.ToString();
        }
    }
}
