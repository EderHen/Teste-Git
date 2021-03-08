using System;
using System.Globalization;

namespace introductionOO_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo!");
            retangulo.Base = double.Parse(Console.ReadLine(), CI);
            retangulo.Altura = double.Parse(Console.ReadLine(), CI);


            Console.WriteLine("Area = " + retangulo.Area().ToString("F2", CI));
            Console.WriteLine("Perimetro = " + retangulo.Perimetro().ToString("F2", CI));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2", CI));


        }
    }
}
