
class Aluno
{
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public void SetAluno()
    {
        Console.WriteLine("Digite os dados do aluno:");
        Console.WriteLine("Nome:");
        this.Nome = Console.ReadLine();
        Console.WriteLine("Primeira nota:");
        this.Nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Segunda nota:");
        this.Nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Terceira nota:");
        this.Nota3 = double.Parse(Console.ReadLine());
    }

    public double GetNotaFinal()
    {
        double NotaFinal = Nota1 + Nota2 + Nota3;
        return NotaFinal;
    }

    public void GetResultado()
    {
        double resultado = GetNotaFinal();
        Console.WriteLine("Nota Final = " + resultado);
        if (resultado >= 60)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado\n" + "Faltaram " + (60 - resultado) + " pontos");
        }
    }
}

class Program
{
    static void Main()
    {
        Aluno a = new Aluno();
        a.SetAluno();
        a.GetResultado();
    }
}