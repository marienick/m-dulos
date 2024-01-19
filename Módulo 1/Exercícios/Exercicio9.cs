using System;
class Calculadora
{
    static double pi = 3.14;

    public static double GetCircunferencia(double raio)
    {
        return raio * pi * 2.0;
    }
    public static double GetVolume(double raio)
    {
        return 4.0 / 3.0 * pi * Math.Pow(raio, 3);
    }
    public static double GetPi()
    {
        return pi;
    }
}
class Program
{
    static void Main()
    {
        Calculadora.GetCircunferencia(3);
        Calculadora.GetVolume(3);
        Calculadora.GetPi();
    }
}