using System;

class URI
{
    static void Main(string[] args)
    {
        int reais = Int32.Parse(Console.ReadLine());
        int calculo = 0;

        Console.WriteLine(reais);

        calculo = reais / 100;
        Console.WriteLine($"{calculo} nota(s) de R$ 100,00");

        reais = reais % 100;
        calculo = reais / 50;
        Console.WriteLine($"{calculo} nota(s) de R$ 50,00");

        reais = reais % 50;
        calculo = reais / 20;
        Console.WriteLine($"{calculo} nota(s) de R$ 20,00");

        reais = reais % 20;
        calculo = reais / 10;
        Console.WriteLine($"{calculo} nota(s) de R$ 10,00");

        reais = reais % 10;
        calculo = reais / 5;
        Console.WriteLine($"{calculo} nota(s) de R$ 5,00");

        reais = reais % 5;
        calculo = reais / 2;
        Console.WriteLine($"{calculo} nota(s) de R$ 2,00");

        reais = reais % 2;
        calculo = reais / 1;
        Console.WriteLine($"{calculo} nota(s) de R$ 1,00");
    }
}
