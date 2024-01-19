using System;
class Funcionario
{
    public string Nome;
    public double Salario;


    public void SetarFuncionario()
    {
        Console.WriteLine("Digite o nome do funcionário:");
        this.Nome = Console.ReadLine();
        Console.WriteLine("Digite o salário do funcionário:");
        this.Salario = double.Parse(Console.ReadLine());
    }
    public  double SalarioMedio(Funcionario funcionario1,  Funcionario funcionario2)
    {
        double media = (funcionario1.Salario + funcionario2.Salario)/ 2;
        return media;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario();
        funcionario1.SetarFuncionario();
        Funcionario funcionario2 = new Funcionario();
        funcionario2.SetarFuncionario();
        double media = funcionario1.SalarioMedio(funcionario1, funcionario2);
        Console.WriteLine("Salário médio = "+ media);
    }
}