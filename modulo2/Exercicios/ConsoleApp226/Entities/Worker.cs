using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp226.Entities.WorkLevel;

namespace ConsoleApp226.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; } = new List<HourContract>();

        public Worker() { }
        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }
        public void AddContract(DateTime date, double valuePerHour, int Hours)
        {
            HourContract hourContract = new HourContract(date, valuePerHour, Hours);
            Contracts.Add(hourContract);
        }
        public void RemoveContracts(HourContract hourContract)
        {
            Contracts.Remove(hourContract);
        }
        public override string ToString()
        {
            return "Nome: " + Name +"\nNível: "+ Level +"\nSalário Base: "+ BaseSalary + ", " + Contracts;
        }

    }
}
