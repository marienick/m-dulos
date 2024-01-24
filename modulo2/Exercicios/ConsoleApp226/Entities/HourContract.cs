using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp226.Entities
{
    class HourContract
    {
        public DateTime Date {  get; set; }
        public double ValuePerHour { get; set; }
        public int Hours {  get; set; }

        public HourContract() { }
        public HourContract (DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hour;
        }
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
       
    }
}
