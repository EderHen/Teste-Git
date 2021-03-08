using System;
using System.Globalization;

namespace for_ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite a quantidade de divisões:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int x1 = int.Parse(valores[0]);
                int x2 = int.Parse(valores[1]);

                if (x2 == 0)
                {
                    Console.WriteLine("Divisao Impossivel");
                }
                else
                {
                    double div = (double)x1 / x2;
                    Console.WriteLine(div.ToString("F1", CI));
                }

            }
        }
    }
}
