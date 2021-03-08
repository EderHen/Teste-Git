using System;
using System.Globalization;

namespace Iniciowhile_Crescente
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite dois numeros: ");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());

            while (x1 != x2)
            {
                if(x1 > x2)
                {
                    Console.WriteLine("Decrescente!");
                }
                else
                {
                    Console.WriteLine("Crescente!");
                }
                Console.WriteLine("Digite outros dois numeros:");
                x1 = int.Parse(Console.ReadLine());
                x2 = int.Parse(Console.ReadLine());
            }












        }
    }
}
