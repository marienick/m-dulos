using System;
using System.Diagnostics;
using System.Xml.Linq;
using ConsoleApp231.Entities;
using ConsoleApp231.Entities.Enums;


class Program
{
    static void Main(string[] args)
    {
        Client client = new Client("Alex Green", "alex@gmail.com", "15/03/1985");   
        Order order = new Order("Processing",client);
        Product product = new Product( "tv",  1000.00,  1);
        order.AddItem(product);
        Product product2 = new Product("Mouse", 40.00, 2);
        order.AddItem(product2);
        Console.WriteLine(order);
    }
}