using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int km = Int32.Parse(Console.ReadLine());
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"{(km/valor).ToString("F3")} km/l");
    }
}
