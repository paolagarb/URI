using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        int codigo = Int32.Parse(entrada[0]);
        int quantidade = Int32.Parse(entrada[1]);
        double valor = 0.00;
        
        switch (codigo) {
            case 1:
            valor = 4.00;
            break;
            case 2:
            valor = 4.50;
            break;
            case 3:
            valor = 5.00;
            break;
            case 4:
            valor = 2.00;
            break;
            case 5:
            valor = 1.50;
            break;
            deafault:
            valor = 0.00;
            break;
        }
        Console.WriteLine($"Total: R$ {(valor * quantidade).ToString("F2")}");
    }
}