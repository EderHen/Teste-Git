using System;
using System.Globalization;

namespace sequentia_exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.WriteLine("Type three different numbers (A,B,C). And then, calculate and show:");
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0], CI);
            double b = double.Parse(valores[1], CI);
            double c = double.Parse(valores[2], CI);

            // a) Area of a triangle = base A * height C
            double triangle = a * c / 2;
            // b) Area of the circle of radius C.
            double circle = Math.PI * Math.Pow(c,2);
            // c) Area of the trapeze with A and B as base and C as height;
            double trapeze = (a + b) * c / 2;
            // d) Area of the square with sides iqual B
            double square = Math.Pow(b, 2);
            // e) Area of the rectangle with sides iguals A e b
            double rectangle = a * b;

            Console.WriteLine("Triangle: " + triangle.ToString("F3", CI));
            Console.WriteLine("Circle: " + circle.ToString("F3", CI));
            Console.WriteLine("Trapeze: " + trapeze.ToString("F3", CI));
            Console.WriteLine("Square: "+ square.ToString("F3", CI));
            Console.WriteLine("Rectangle: "+ rectangle.ToString("F3", CI));



        }
    }
}
