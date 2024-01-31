using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp231.Entities.Enums;

namespace ConsoleApp231.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public OrderItem Item { get; set; } = new OrderItem();


        public Order() { }
        public Order(string status, Client client)
        {
            Client = client;
            Moment = DateTime.Now;
            Status = Enum.Parse<OrderStatus>(status);
        }
        public  void AddItem(Product item)
        {
            Item.Products.Add(item);
        }
        public void RemoveItem(Product item)
        {
            Item.Products.Remove(item);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary:");
            sb.AppendLine("Order moment: " +  Moment);
            sb.AppendLine("Order status: "+  Status);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.DateBirth.ToString("dd/MM/yyyy") + ") - " + Client.Email);
            sb.AppendLine("Order Items:");
            foreach (Product item in Item.Products)
            {
                sb.AppendLine(item.Name+", "+ item.Price.ToString("N2") +", Quantity: "+ item.Quantity+", Subtotal: "+ item.Total());
            }
            sb.AppendLine("Total Price: "+ Item.SubTotal());
            return sb.ToString();
            
        }

    }
}