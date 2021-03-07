using System;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario = Int32.Parse(Console.ReadLine());
            int horasTrabalhadas = Int32.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {(horasTrabalhadas*valorHora).ToString("F2").Replace(",",".")}");
        }
    }
}
