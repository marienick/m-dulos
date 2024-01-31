using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp231.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public OrderItem() { }
        public OrderItem(int quantity)
        {
            Quantity = quantity;
        }
        public double SubTotal()
        {
            double Total = 0;
            foreach(var item in Products)
            {
                Total += item.Price * item.Quantity;
            }
            Price = Total;
            return Total;
        }
    }
}
