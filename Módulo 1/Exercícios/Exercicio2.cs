using System;
class Pessoas
{
    public string Nome;
    public int Idade;

    public void SetarPessoa()
    {
        Console.WriteLine("Digite o nome da pessoa:");
        this.Nome = Console.ReadLine();
        Console.WriteLine($"Digite a idade de {this.Nome}:");
        this.Idade = int.Parse(Console.ReadLine());
    }
    public string QualEMaisVelha(Pessoas pessoa1, Pessoas pessoa2)
    {
        if (pessoa1.Idade > pessoa2.Idade)
        {
            return "Pessoa mais velha: " + pessoa1.Nome;
        }
        else
        {
            return "Pessoa mais velha: " + pessoa2.Nome;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1 = new Pessoas();
            pessoa1.SetarPessoa();
            Pessoas pessoa2 = new Pessoas();
            pessoa2.SetarPessoa();
            Console.WriteLine(pessoa2.QualEMaisVelha(pessoa1,pessoa2));
        }
    }
}