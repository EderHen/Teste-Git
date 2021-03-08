using System;
using System.Globalization;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Distancia percorrida: ");
            int distancia = int.Parse(Console.ReadLine());
            Console.Write("Combustivel Gasto: ");
            double gasto = double.Parse(Console.ReadLine(), CI);

            double media = distancia / gasto;
            Console.Write("Consumo medio = " + media.ToString("F3", CI));




        }
    }
}
