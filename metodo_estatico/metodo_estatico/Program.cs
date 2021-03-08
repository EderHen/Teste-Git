using System;
using System.Globalization;

namespace metodo_estatico
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CI));
            Console.WriteLine("Volume: " + volume.ToString("F2", CI));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2",CI));
        }
    }
}
