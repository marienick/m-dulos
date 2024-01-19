using System;
class ContaBancaria
{
    private string _nome;
    private int _numero;
    private double _depositoinicial;
    private double _saldo;

    public ContaBancaria(string Nome, int Numero, double Deposito)
    {
        _nome = Nome;
        _numero = Numero;
        _depositoinicial = Deposito;
        _saldo = Deposito;
    }
    public ContaBancaria(string Nome, int Numero)
    {
        _nome = Nome;
        _numero = Numero;
        _depositoinicial = 0.00;
        _saldo = 0.00;
    }
    public string Nome
    {
        get { return _nome; }
        set {
            if (value != null && value.Length > 1)
            {
                _nome = value;
            }
        }
    }
    public int Numero
    {
        get { return _numero; }
    }
    public double Saldo
    {
        get { return _saldo; }
    }
    public void Saques(double valor)
    {
        _saldo -= valor + 5.00;
    }
    public void Deposito(double valor)
    {
        _saldo += valor;
    }
    public override string ToString()
    {
        return "Nome: " + _nome + "\nNúmero da conta: "+ _numero + "\nSaldo: " + _saldo.ToString("F2");
    }
}
class Program
{
    static void Main(string[] args)
    {
        ContaBancaria b;
        Console.WriteLine("Bem Vindo!\nDigite o número da sua conta:");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Você deseja fazer seu depósito inicial?");
        string resposta = Console.ReadLine().ToLower();
        if(resposta == "sim" || resposta == "s")
        {
            Console.WriteLine("Digite o valor do depósito:");
            double deposito = double.Parse(Console.ReadLine());
            b = new ContaBancaria(nome, numero, deposito);
        }
        else
        {
            b = new ContaBancaria(nome, numero);

        }
        b.Deposito(200.00);
        Console.WriteLine(b);
        b.Saques(300.00);
        Console.WriteLine(b);

    }
}

