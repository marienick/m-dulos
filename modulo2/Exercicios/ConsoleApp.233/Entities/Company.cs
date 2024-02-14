using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp237.Entities
{
    class Company
    {
        public string name { get; set; }
        public Company(string name)
        {
            this.name = name;   
        }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
    }
}
