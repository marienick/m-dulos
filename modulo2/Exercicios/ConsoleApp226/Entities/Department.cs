using ConsoleApp226.Entities.WorkLevel;
using System;
using System.Collections.Generic;


namespace ConsoleApp226.Entities
{
    class Department
    {
        public string Name {  get; set; }
        //Necessário inicializar a lista para funcionar.
        public List<Worker> Workers { get; } = new List<Worker>();

        public Department() { }
        public Department(string name)
        {
            Name = name;
        }
        /* Não foi pedido nesse exercício:
         public void AddWorker(string Name, WorkerLevel workLevel, double baseSalary)
        {
            Worker worker = new Worker( Name, workLevel,  baseSalary);
            Workers.Add(worker);
        }
        public void RemoveWorker(Worker worker)
        {
            Workers.Remove(worker);
        }
        public void ShowWorkes()
        {
            for(int i = 0; i < Workers.Count; i++)
            {
                Console.WriteLine("Trabalhador: " + i);
                Console.WriteLine(Workers[i]);
            }
        }*/
    }
}
