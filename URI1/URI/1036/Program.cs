using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split();
        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);
        double c = double.Parse(entrada[2]);

        double delta = Math.Pow(b, 2) - 4 * a * c;
        double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double r2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (delta < 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            Console.WriteLine($"R1 = {r1.ToString("F5")}");
            Console.WriteLine($"R2 = {r2.ToString("F5")}");
        }
    }

}