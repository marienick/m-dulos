using System;
class Calculadora
{
    double pi = 3.14;

    public double GetCircunferencia(double raio)
    {
        return raio * pi * 2.0;
    }
    public double GetVolume(double raio)
    {
        return 4.0 / 3.0 * pi * Math.Pow(raio, 3);
    }
    public double GetPi()
    {
        return pi;
    }
}
class Program
{
    static void Main()
    {
        Calculadora c = new Calculadora();
        c.GetCircunferencia(3);
        c.GetVolume(3);
        c.GetPi();
    }
}