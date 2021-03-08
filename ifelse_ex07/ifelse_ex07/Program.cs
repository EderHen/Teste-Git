using System;
using System.Globalization;

namespace ifelse_ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite as coordernadas X e Y(mesma linha)");
            string[] coordenadas = Console.ReadLine().Split(' ');
            double x = double.Parse(coordenadas[0]);
            double y = double.Parse(coordenadas[1]);

            if(x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if(x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if(x > 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if(x == 0 && y > 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else
            {
                Console.WriteLine("Origem");
            }


        }
    }
}
