using System;

class URI
{
    static void Main(string[] args)
    {
        string[] peca1 = Console.ReadLine().Split(' ');
        string[] peca2 = Console.ReadLine().Split(' ');

        int quantidade = Int32.Parse(peca1[1]);
        double valor = double.Parse(peca1[2]);
        double totalPeca1 = quantidade * valor;

        int quantidade2 = Int32.Parse(peca2[1]);
        double valor2 = double.Parse(peca2[2]);
        double totalPeca2 = quantidade2 * valor2;

        double total = totalPeca1 + totalPeca2;

        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);
    }
}
