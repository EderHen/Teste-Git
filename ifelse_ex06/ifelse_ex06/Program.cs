using System;
using System.Globalization;

namespace ifelse_ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.WriteLine("Digite um valor e desubra em qual intervalo ele está");
            double valor = double.Parse(Console.ReadLine(), CI);

            if (valor < 0.0 || valor > 100.0)
            {
                Console.WriteLine("Fora do Intervalo");
            }
            else if (valor <= 25.0)
            {
                Console.WriteLine("intervalo (0,25)");
            }
            else if (valor <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50)");
            }
            else if (valor <= 75)
                {
                    Console.WriteLine("Intervalo (50,75)");
                }
            else
            {
                Console.WriteLine("Intervalo (75,100)");
            }




        }
    }
}
