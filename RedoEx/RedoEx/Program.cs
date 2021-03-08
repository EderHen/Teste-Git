using System;
using System.Globalization;

namespace RedoEx
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Enter the measures of the triangle X:");
            x.A = double.Parse(Console.ReadLine(), CI);
            x.B = double.Parse(Console.ReadLine(), CI);
            x.C = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Enter the measures of the triangle Y:");
            y.A = double.Parse(Console.ReadLine(), CI);
            y.B = double.Parse(Console.ReadLine(), CI);
            y.C = double.Parse(Console.ReadLine(), CI);

            double areaX = x.Area();
            Console.WriteLine("Area of X = " + x.Area().ToString("F4", CI));
            double areaY = y.Area();
            Console.WriteLine("Area of Y = " + y.Area().ToString("F4", CI));
            if (Math.Max(x.Area(), y.Area()) == x.Area())
            {
                Console.WriteLine("Biggest area: X");
            }
            else
            {
                Console.WriteLine("Biggest area: Y");
            }










        }
    }
}
