using System;
using ConsoleApp226.Entities.WorkLevel;
using ConsoleApp226.Entities;


namespace ConsoleApp226
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter departament's name:");
            string deptNme = Console.ReadLine();
            Department department = new Department(deptNme);
            Console.WriteLine("Enter worker data:");
            /*string resposta = Console.ReadLine().ToLower();
            if(resposta == "s" || resposta == "sim")
            {*/
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Level:\n1-Junior\n2-MidLevel\n3-Senior");
            int opcao = int.Parse(Console.ReadLine());
            while (opcao > 3 || opcao < 1)
            {
                Console.WriteLine("Incorrect option!\nPlease, type again the level of the worker:\n1-Junior\n2-MidLevel\n3-Senior");
                int option = int.Parse(Console.ReadLine());
            }
            WorkerLevel level = new WorkerLevel();
            if (opcao == 1)
            {
                level = WorkerLevel.Parse<WorkerLevel>("Junior");
            }
            else if (opcao == 2)
            {
                level = WorkerLevel.Parse<WorkerLevel>("Md_Level");
            }
            else
            {
                level = WorkerLevel.Parse<WorkerLevel>("Senior");

            }
            Console.WriteLine("Base salary:");
            double baseSalary = double.Parse(Console.ReadLine());
            Worker worker = new Worker(name, level, baseSalary, department);
            /*department.AddWorker(name, workerLevel, salarioBase);
            Console.WriteLine("Deseja adicionar um contrato de horas para algum funcionário?");
            string resposta2 = Console.ReadLine().ToLower();
            if(resposta2 == "s" || resposta2 == "sim")
            {
                Console.WriteLine("Qual deles:");
                department.ShowWorkes();
                int numberWorker = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de contratos desse funcionário:");
                int quantidadeContratos = int.Parse(Console.ReadLine());
                for(int i = 0; i < quantidadeContratos; i++)
                {
                    Console.WriteLine("Digite a data desse contrato:");
                    string data = Console.ReadLine();
                    DateTime date = DateTime.ParseExact(data, "yyyy-MM-dd",
                                   System.Globalization.CultureInfo.InvariantCulture);
                    Console.WriteLine("Qual a duração desse contrato em horas?");
                    int duracao = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor da hora desse funcionário?");
                    double valorDaHora = double.Parse(Console.ReadLine());
                    department.Workers[numberWorker - 1].AddContract(date, valorDaHora, duracao);
                }
            }*/
            Console.WriteLine("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter " + i + 1 + " contract data:");
                Console.WriteLine("Date:\n(DD/MM/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration:\n(hours)");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.Contracts.Add(contract);
            }
            Console.WriteLine("Enter with month and year to caculate the income:\n(MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3, 4));
            Console.WriteLine(worker);
            Console.WriteLine($"Income for {monthAndYear}: " + worker.Income(year,month));
        }
    }
}
