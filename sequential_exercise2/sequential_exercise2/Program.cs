using System;
using System.Globalization;

namespace sequential_exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;



            Console.WriteLine("Type the radius of a circle: ");
            double radius = double.Parse(Console.ReadLine(), CI);
            double pi = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine(pi.ToString("F4", CI));
        }
    }
}
