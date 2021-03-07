using System;

class URI
{
    static void Main(string[] args)
    {
        int dias = Int32.Parse(Console.ReadLine());

        int anos = dias / 365;
        dias %= 365;
        int meses = dias / 30;
        dias %= 30;

        Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
    }
}
