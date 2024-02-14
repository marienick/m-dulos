using System;
using ConsoleApp237.Entities;
class Program
{
    static void Main (string[] args)
    {
        Company company = new Company("X");
        Console.WriteLine("Enter the number of employees:");
        int number = int.Parse(Console.ReadLine());
        Employee employee;
        for (int i = 0;  i < number; i++)
        {
            Console.WriteLine($"Employee #{i+1} data");
            Console.WriteLine("Outsorced (y/n) ?");
            string awnser = Console.ReadLine().ToLower();
            if(awnser == "y" ||  awnser == "s")
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Hous:");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Additional charge:");
                double additionalCharge = double.Parse(Console.ReadLine());
                employee = new OutsoucederEmployee(name, hours, valuePerHour, additionalCharge); 
                company.AddEmployee(employee);
            }
            else
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Hours:");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine());
                employee = new Employee(name, hours, valuePerHour);
                company.AddEmployee(employee);
            }
        }
        for(int i = 0; i < number;i++)
        {
            Console.WriteLine(company.Employees[i].name +": "+ company.Employees[i].Payment(company.Employees[i]));
        }
    }
}