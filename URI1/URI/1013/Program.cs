using System;

class URI
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');

        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);
        int c = int.Parse(entrada[2]);

        int maior = (a + b + Math.Abs(a - b)) / 2;

        if (maior > c)
        {
            Console.WriteLine($"{maior} eh o maior");
        } else
        {
            Console.WriteLine($"{c} eh o maior");
        }
    }
}
