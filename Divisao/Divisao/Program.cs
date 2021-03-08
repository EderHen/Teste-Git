using System;
using System.Globalization;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos casos voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int num, deno;
            double Div;
            for(int i = 0; i < n; i++)
            {
                Console.Write("Entre com o numerador: ");
                num = int.Parse(Console.ReadLine());
                Console.Write("Entre com o denominador: ");
                deno = int.Parse(Console.ReadLine());

                if(deno != 0)
                {
                    Div = (double)num / (double)deno;
                    Console.WriteLine("Divisao = "+ Div.ToString("F2", CI));
                }
                else
                {
                    Console.WriteLine("Divisao Impossivel!");
                }

            }



        }
    }
}
