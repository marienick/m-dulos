using System;

class Retangulo
{
    public double Largura;
    public double Altura;

    public void SetRetangulo()
    {
        Console.WriteLine("Entre com os dados do retângulo:");
        Console.WriteLine("Altura:");
        this.Altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Largura:");
        this.Largura = double.Parse(Console.ReadLine());
    }

    public double GetArea()
    {
        double Area = Largura * Altura;
        return Area;
    }

    public double GetPerimetro()
    {
        double Perimetro = (Largura * 2) + (Altura * 2);
        return Perimetro;
    }

    public double GetDiagonal()
    {
        double Diagonal = Math.Sqrt((Math.Pow(Largura, 2)) + (Math.Pow(Altura, 2)));
        return Diagonal;
    }

    public override string ToString()
    {
        return $"Área: {GetArea():f2}\nPerímetro: {GetPerimetro():f2}\nDiagonal: {GetDiagonal():f2}";
    }
}

class Program
{
    static void Main()
    {
        Retangulo r = new Retangulo();
        r.SetRetangulo();
        Console.WriteLine("Dados do retângulo:\n" + r);
    }
}