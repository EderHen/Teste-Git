using System;
using System.Globalization;

namespace problema_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CI);
            x.B = double.Parse(Console.ReadLine(), CI);
            x.C = double.Parse(Console.ReadLine(), CI);

            double area = x.Area();

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CI);
            y.B = double.Parse(Console.ReadLine(), CI);
            y.C = double.Parse(Console.ReadLine(), CI);

            double area2 = y.Area();

            Console.WriteLine("Área de X = " + area.ToString("F4", CI));
            Console.WriteLine("Área de Y = " + area2.ToString("F4", CI));

            if (area > area2)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }

        }
    }
}
