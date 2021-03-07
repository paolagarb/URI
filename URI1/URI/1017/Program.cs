using System;

class URI
{
    static void Main(string[] args)
    {
        int horas = Int32.Parse(Console.ReadLine());
        int velocidade = Int32.Parse(Console.ReadLine());

        double total = Convert.ToDouble(horas * velocidade) / 12;
        Console.WriteLine(total.ToString("F3"));
    }
}
