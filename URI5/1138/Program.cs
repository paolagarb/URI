using System; 

class URI {
// TIME!!!
    static void Main(string[] args) { 
            int a, b, a0 = 0, a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0;
        do
        {
            string[] entrada = Console.ReadLine().Split(' ');
            a = Int32.Parse(entrada[0]);
            b = Int32.Parse(entrada[1]);

            for (int i = b; i >= a; i--)
            {
                int numCaracteres = i.ToString().Length;
                for (int c = 0; c < numCaracteres; c++)
                {
                    string contando = i.ToString().Substring(c, 1);
                    switch (contando)
                    {
                        case "0":
                            a0++;
                            break;
                        case "1":
                            a1++;
                            break;
                        case "2":
                            a2++;
                            break;
                        case "3":
                            a3++;
                            break;
                        case "4":
                            a4++;
                            break;
                        case "5":
                            a5++;
                            break;
                        case "6":
                            a6++;
                            break;
                        case "7":
                            a7++;
                            break;
                        case "8":
                            a8++;
                            break;
                        case "9":
                            a9++;
                            break;
                        default:
                            Console.WriteLine();
                            break;
                    }
                }
            }

            Console.WriteLine($"{a0} {a1} {a2} {a3} {a4} {a5} {a6} {a7} {a8} {a9}");

        } while (a != 0 && b != 0);
    }
}