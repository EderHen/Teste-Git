using System;
using System.Globalization;

namespace multiplos
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite dois numeros inteiros: ");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());

            if(x1 % x2 == 0 || x2 % x1 == 0)
            {
                Console.Write("Sao multiplos");
            }
            else
            {
                Console.Write("Nao sao multiplos");
            }

        }
    }
}
