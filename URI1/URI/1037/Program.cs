using System; 

class URI {

    static void Main(string[] args) { 

       double entrada = double.Parse(Console.ReadLine());

        if (entrada < 0.0000)
        {
            Console.WriteLine("Fora de intervalo");
        }
        else if (entrada <= 25.00000)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (entrada <= 50.00000)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (entrada <= 75.00000)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (entrada <= 100.00000)
        {
            Console.WriteLine("Intervalo (75,100]");
        } else
        {
            Console.WriteLine("Fora de intervalo");
        }
    }
}