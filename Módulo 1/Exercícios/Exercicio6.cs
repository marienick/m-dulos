using System;

class Funcionario
{
    public string Nome;
    public double SalaioBruto;
    public double Imposto;

    public void SetFuncionario()
    {
        Console.WriteLine("Digite os dados do funcionário:");
        Console.WriteLine("Nome:");
        this.Nome = Console.ReadLine();
        Console.WriteLine("Salário Bruto:");
        this.SalaioBruto = double.Parse(Console.ReadLine());
        Console.WriteLine("Imposto:");
        this.Imposto = double.Parse(Console.ReadLine());
    }

    public double GetSalarioLiquido()
    {
        double SalarioLiquido = SalaioBruto - Imposto;
        return SalarioLiquido;
    }

    public void AumentarSalario(double Porcentagem)
    {
        double Adicional = (this.SalaioBruto * Porcentagem) / 100;
        this.SalaioBruto += Adicional;
    }

    public override string ToString()
    {
        return "Funcionário: " + Nome + " Salário Líquido: " + GetSalarioLiquido().ToString("f2");
    }
}

class Program
{
    static void Main()
    {
        Funcionario f = new Funcionario();
        f.SetFuncionario();
        Console.WriteLine(f);
        f.AumentarSalario(10.0);
        Console.WriteLine(f);
    }
}