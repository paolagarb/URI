using System; 

class URI {

    static void Main(string[] args) { 

        int duracao = Int32.Parse(Console.ReadLine());

        int segundos = duracao % 60;
        int minutos = duracao / 60;
        int horas = minutos / 60;
        minutos %= 60;
        Console.WriteLine($"{horas}:{minutos}:{segundos}");

    }

}