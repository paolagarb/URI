﻿using System;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = ((a * 3.5) + (b * 7.5)) / 11;
            Console.WriteLine($"MEDIA = {media.ToString("F5").Replace(",",".")}");
        }
    }
}
