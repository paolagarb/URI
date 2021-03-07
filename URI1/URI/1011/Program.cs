using System;

class URI
{
    static void Main(string[] args)
    {
        int raio = Int32.Parse(Console.ReadLine());

        double volume = (4.0 / 3) * 3.14159 * Math.Pow(raio, 3);

        Console.WriteLine($"VOLUME = {volume.ToString("F3").Replace(",",".")}");

    }
}
