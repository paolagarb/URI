using System;

class URI
{

    static void Main(string[] args)
    {
        int quantidade = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            int total = 0;
            string[] entrada = Console.ReadLine().Split(' ');

            int figurinhasRicardo = Int32.Parse(entrada[0]);
            int figurinhasVicente = Int32.Parse(entrada[1]);

            int maior = figurinhasRicardo > figurinhasVicente ? figurinhasRicardo : figurinhasVicente;
            int menor = figurinhasRicardo == maior ? figurinhasVicente : figurinhasRicardo;

            while (menor != 0)
            {
                int sub = maior % menor;
                maior = menor;
                menor = sub;
            }

            Console.WriteLine(maior);
        } 
    }
}