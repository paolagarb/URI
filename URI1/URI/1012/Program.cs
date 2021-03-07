using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');

        double a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
        double b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
        double c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

        double triangulo = (a * c) / 2;
        double circulo = 3.14159 * Math.Pow(c, 2);
        double trapezio = ((a + b) * c) / 2;
        double quadrado = Math.Pow(b, 2);
        double retangulo = a * b;

        Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3")}");
        Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
        Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
        Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
        Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");
    }
}
