using System;
class Produto
{
    public string Nome;
    public double Preco;

    public Produto() { }
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public Produto[] RegistrarProdutos(int quantidade)
    {
        Produto[] produtos = new Produto[quantidade]; 
        for(int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("Digite o nome do produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto:");
            double preco = double.Parse(Console.ReadLine());
            Produto produto = new Produto(nome,preco);
            produtos[i] = produto;
        }
        return produtos;
    }
    public double CalcularMedia()
    {
        double media = 0;
        Console.WriteLine("Qual a quantidade de produtos:");
        int quantidade = int.Parse(Console.ReadLine());
        Produto[] produtos = RegistrarProdutos(quantidade);
        for(int i = 0;i < quantidade; i++)
        {
            media += produtos[i].Preco;
        }
        return media/produtos.Length;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();
        Console.WriteLine(p.CalcularMedia());
    }
}