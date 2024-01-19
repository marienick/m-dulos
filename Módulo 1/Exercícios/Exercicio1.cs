using System;
class Triangulo
{
    public double l1;
    public double l2;
    public double l3;


    public void CadastrarTriangulo()
    {
        Console.WriteLine("Digite os dados do  triângulo:");
        Console.WriteLine("Lado 1:");
        double l1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Lado 2:");
        double l2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Lado 3:");
        double l3 = double.Parse(Console.ReadLine());
        this.l1 = l1;
        this.l2 = l2;
        this.l3 = l3;
        
    }
    public double CalcularP(Triangulo triangulo)
    {
        double p = (l1 + l2 + l3) / 2;
        return p;
    }
    public double CalcularArea(Triangulo triangulo)
    {
        double p = CalcularP(triangulo);
        double area = Math.Sqrt(p * (p - triangulo.l1) * (p - triangulo.l2) * (p - triangulo.l3));
        return area;
    }
    public string QualEMaior(double area1, double area2)
    {
        if(area1 > area2)
        {
            return "Triângulo 1 é maior.";
        }
        else
        {
            return "Triângulo 2 é maior.";
        }
    }
}
class Program
{
    static void Main (string[] args)
    {
        Triangulo triangulo1 = new Triangulo();
        triangulo1.CadastrarTriangulo();
        double area1 = triangulo1.CalcularArea(triangulo1);
        Triangulo triangulo2 = new Triangulo();
        triangulo2.CadastrarTriangulo();
        double area2 = triangulo2.CalcularArea(triangulo2);
        Console.WriteLine(triangulo2.QualEMaior(area1, area2));

    }
}