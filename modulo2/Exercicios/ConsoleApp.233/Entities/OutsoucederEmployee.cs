using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp237.Entities
{
     class OutsoucederEmployee : Employee
    {
        public double additionalCharge {  get; set; }

        public OutsoucederEmployee()
        {
        }
        public OutsoucederEmployee(string name, int hours, double valuePerHour, double additionalCharge): base (name, hours, valuePerHour)
        {
            this.additionalCharge = additionalCharge;
        }
        public override double Payment(Employee employee)
        {
            return (hours * valuePerHour) + (1.1 * additionalCharge);
        }
    }
}
