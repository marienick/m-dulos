using System;
class Quartos
{
    public string Nome;
    private string _email;
    public bool Vazio = true;

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
}
class Pensao
{
    public Quartos[] quartos = new Quartos[10];


    public void InicializarQuartos()
    {
        for(int i = 0; i < quartos.Length; i++)
        {
            quartos[i] = new Quartos();
        }
    }
    public void RegistarEStudantes()
    {
        InicializarQuartos();
        Console.WriteLine("Digite quantos estudantes vão alugar quartos hoje:");
        int quantidade = int.Parse(Console.ReadLine());
        for(int i = 0; i < quantidade; i++)
        {
            Quartos quarto = new Quartos();

            
            Console.WriteLine("\nInsira seu nome:");
            quarto.Nome = Console.ReadLine();
            Console.WriteLine("Insira seu email:");
            quarto.Email = Console.ReadLine();
            Console.WriteLine("Quartos vagos:");
            for (int j = 0; j < quartos.Length; j++)
            {
                Console.WriteLine($"Quarto {j}:" + quartos[j].Vazio);
            }
            Console.WriteLine("Qual quarto você deseja alugar:\n");
            int k = int.Parse(Console.ReadLine());
            while (quartos[k].Vazio == false)
            {
                Console.WriteLine($"Digite outro quarto, pois o {k} está ocupado");
                k = int.Parse(Console.ReadLine());
            }
            quartos[k] = quarto;
            quartos[k].Vazio = false;

        }
    }
    public void ImprimiQuartos()
    {
        for (int j = 0; j < quartos.Length; j++)
        {
            if(quartos[j].Vazio == false)
            {
                Console.WriteLine($"Quarto {j}: ocupado por {quartos[j].Nome}.");
            }
            else
            {
                Console.WriteLine($"Quarto {j}: vago.");
            }
        }
    }
   
}

class Program
{
    static void Main(string[] args)
    {
        Pensao pensao = new Pensao();
        pensao.RegistarEStudantes();
        pensao.ImprimiQuartos();
    }
}