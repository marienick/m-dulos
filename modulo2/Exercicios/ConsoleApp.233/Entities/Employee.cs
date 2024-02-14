using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp237.Entities
{
     class Employee
    {
        public string name {  get; set; }
        public int hours { get; set; }
        public double valuePerHour { get; set; }

        public Employee() { }   
        public Employee(string name, int hoursWorked, double valuePerHour)
        {
            this.name = name;
            this.hours = hoursWorked;
            this.valuePerHour = valuePerHour;
        }
        public virtual double Payment(Employee employee)
        {
            return hours * valuePerHour;
        }
    }
}
