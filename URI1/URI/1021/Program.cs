using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int reais = (int)valor;

        int reaisCentavos = (int)(valor * 100);
        int centavos = (reaisCentavos - reais * 100);
        int calculo = 0;

        Console.WriteLine("NOTAS:");

        calculo = reais / 100;
        Console.WriteLine($"{calculo} nota(s) de R$ 100.00");

        reais = reais % 100;
        calculo = reais / 50;
        Console.WriteLine($"{calculo} nota(s) de R$ 50.00");

        reais = reais % 50;
        calculo = reais / 20;
        Console.WriteLine($"{calculo} nota(s) de R$ 20.00");

        reais = reais % 20;
        calculo = reais / 10;
        Console.WriteLine($"{calculo} nota(s) de R$ 10.00");

        reais = reais % 10;
        calculo = reais / 5;
        Console.WriteLine($"{calculo} nota(s) de R$ 5.00");

        reais = reais % 5;
        calculo = reais / 2;
        Console.WriteLine($"{calculo} nota(s) de R$ 2.00");

        reais = reais % 2;

        centavos += reais * 100;

        Console.WriteLine("MOEDAS:");

        calculo = centavos / 100;
        Console.WriteLine($"{calculo} moeda(s) de R$ 1.00");

        centavos = centavos % 100;
        calculo = centavos / 50;
        Console.WriteLine($"{calculo} moeda(s) de R$ 0.50");

        centavos = centavos % 50;
        calculo = centavos / 25;
        Console.WriteLine($"{calculo} moeda(s) de R$ 0.25");

        centavos = centavos % 25;
        calculo = centavos / 10;
        Console.WriteLine($"{calculo} moeda(s) de R$ 0.10");

        centavos = centavos % 10;
        calculo = centavos / 5;
        Console.WriteLine($"{calculo} moeda(s) de R$ 0.05");

        centavos = centavos % 5;
        Console.WriteLine($"{centavos} moeda(s) de R$ 0.01");

    }
}