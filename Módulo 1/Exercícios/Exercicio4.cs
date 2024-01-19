using System;
class Loja
{
    public string NomeProduto;
    public double Preco;
    public int Quantidade;

    public void SetarProduto()
    {
        Console.WriteLine("Digite o nome do produto:");
        this.NomeProduto = Console.ReadLine();
        Console.WriteLine("Digite o preço do(a) " + this.NomeProduto);
        this.Preco = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de " + this.NomeProduto + " que tem no estoque:");
        this.Quantidade = int.Parse(Console.ReadLine());

    }
    public void EntradaEstoque()
    {
        Console.WriteLine("Digite a quantidade de " + this.NomeProduto + " que vão entrar no estoque:");
        int qtd = int.Parse(Console.ReadLine());
        this.Quantidade += qtd;

        Console.WriteLine("\nNome do produto:" + this.NomeProduto + "\nPreço: " + this.Preco + "\nQuantidade no estoque: " + this.Quantidade);

    }
    public void SairEstoque()
    {
        Console.WriteLine("Digite a quantidade de " + this.NomeProduto + " que vão sair do estoque:");
        int qtd = int.Parse(Console.ReadLine());
        this.Quantidade-= qtd;  
    }
    public void MostrarOsDado()
    {
        Console.WriteLine("Nome do produto:" + this.NomeProduto + "\nPreço: " + this.Preco + "\nQuantidade no estoque: " + this.Quantidade);

    }
}
class Program
{
    static void Main(string[] args)
    {
        Loja loja = new Loja();
        loja.SetarProduto();
        loja.EntradaEstoque();
        loja.SairEstoque();
    }
}
