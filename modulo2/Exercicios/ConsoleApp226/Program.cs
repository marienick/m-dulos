using System;
using ConsoleApp226.Entities.WorkLevel;
using ConsoleApp226.Entities;


namespace ConsoleApp226
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do departamento? ");
            string nome = Console.ReadLine();
            Department department = new Department(nome);
            Console.WriteLine("Você deseja adicionar um novo trabalhador?");
            string resposta = Console.ReadLine().ToLower();
            if(resposta == "s" || resposta == "sim")
            {
                Console.WriteLine("Qual o nome do trabalhador?");
                string name = Console.ReadLine();
                Console.WriteLine("Qual o nível do trabalhador?\n1-Júnior\n2-Nível MD\n3-Sênior");
                int opcao = int.Parse(Console.ReadLine());
                while(opcao > 3 || opcao < 1)
                {
                    Console.WriteLine("Opção incorreta!\nPor favor, digite novamente qual o nível do trabalhador?\n1-Júnior\n2-Nível MD\n3-Sênior");
                     opcao = int.Parse(Console.ReadLine());
                }
                WorkerLevel workerLevel = new WorkerLevel();
                if(opcao == 1)
                {
                     workerLevel = WorkerLevel.Parse<WorkerLevel>("Junior");
                }
                else if(opcao == 2)
                {
                     workerLevel = WorkerLevel.Parse<WorkerLevel>("Md_Level");
                }
                else
                {
                     workerLevel = WorkerLevel.Parse<WorkerLevel>("Senior");

                }
                Console.WriteLine("Digite o salário base:");
                double salarioBase = double.Parse(Console.ReadLine());
                department.AddWorker(name, workerLevel, salarioBase);
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
                    //Nesse exercício não entendi mmuito bem a função do income.

                }

            }
        }
    }
}