﻿using System;
using System.Globalization;

namespace URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"DIFERENCA = {a * b - c * d}");
        }
    }
}
