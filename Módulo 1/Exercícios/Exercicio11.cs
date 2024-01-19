using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("quantas pessoas?");
        int pessoas = int.Parse(Console.ReadLine());
        double[] alturas = new double[pessoas];
        double soma = 0;
        for(int i = 0; i < pessoas; i++)
        {
            Console.WriteLine("Digite um número:");
            soma += double.Parse(Console.ReadLine());
        }
        double media = soma/ alturas.Length;
        Console.WriteLine(media);
    }
}