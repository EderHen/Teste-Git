using System;
using System.Globalization;

namespace fixacao
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args) // Versão 1: métodos na própria classe do Programa.
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

        

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);
            double circ = Circunferencia(raio);
            double volume = Volume(raio);


            Console.WriteLine("Circunferencia: " + circ.ToString("F2",CI));
            Console.WriteLine("Volume: " + volume.ToString("F2", CI));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CI));
        }

        static double Circunferencia (double r)
        {
           return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

    }
}
