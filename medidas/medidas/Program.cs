using System;
using System.Globalization;

namespace medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a medida A: ");
            double medidaA = double.Parse(Console.ReadLine(), CI);
            
            Console.Write("Digite a medida B: ");
            double medidaB = double.Parse(Console.ReadLine(), CI);
            
            Console.Write("Digite a medida C: ");
            double medidaC = double.Parse(Console.ReadLine(), CI);

            double areaQ = medidaA * medidaA;
            Console.WriteLine("Area do Quadrado = " + areaQ.ToString("F4", CI));

            double areaTri = medidaA * medidaB / 2;
            Console.WriteLine("Area do Triangulo = " + areaTri.ToString("F4", CI));

            double areaTra = (medidaA + medidaB) * medidaC / 2;
            Console.WriteLine("Area do Trapezio = " + areaTra.ToString("F4", CI));


        }
    }
}
