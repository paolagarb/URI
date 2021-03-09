using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

        string numero = Console.ReadLine().Trim();
        string invertido = new string(numero.Reverse().ToArray());
        Console.WriteLine(invertido);

    }

}