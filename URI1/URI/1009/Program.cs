using System;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendedor = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"TOTAL = R$ {(salario + (total*0.15)).ToString("F2").Replace(",", ".")}");
        }
    }
}
