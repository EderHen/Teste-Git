using System;
using System.Globalization;

namespace dardo
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite as tres distancias: ");
            double d1 = double.Parse(Console.ReadLine(), CI);
            double d2 = double.Parse(Console.ReadLine(), CI);
            double d3 = double.Parse(Console.ReadLine(), CI);

            double maior;
            if(d1>d2 && d1 > d3)
            {
                maior = d1;
            }
            else if(d2 > d3)
            {
                maior = d2;
            }
            else
            {
                maior = d3;
            }

            Console.Write("Maior distancia = " + maior.ToString("F2", CI));

        }
    }
}
