using System;
using System.Globalization;

namespace Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Valor de X: ");
            double x = double.Parse(Console.ReadLine(), CI);
            Console.Write("Valor de Y: ");
            double y = double.Parse(Console.ReadLine(), CI);

            if(x > 0 && y > 0)
            {
                Console.Write("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.Write("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.Write("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.Write("Q4");
            }
            else if (x == 0 && y == 0)
            {
                Console.Write("Origem");
            }
            else if(x == 0)
            {
                Console.Write("Eixo Y");
            }
            else
            {
                Console.Write("Eixo X");
            }

        }
    }
}
