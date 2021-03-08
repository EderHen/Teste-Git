using System;
using System.Globalization;

namespace glicose
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a medida da glicose: ");
            double medida = double.Parse(Console.ReadLine(), CI);

            if(medida <= 100)
            {
                Console.Write("Classificacao: normal");
            }
            else if(medida <= 140)
            {
                Console.Write("Classificacao: elevado");
            }
            else
            {
                Console.Write("Classificacao: Diabetes");
            }
        }
    }
}
