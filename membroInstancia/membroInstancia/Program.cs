using System;
using System.Globalization;

namespace membroInstancia
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Calculadora calc = new Calculadora();

            Console.Write("Digite o valor do raio: ");
            double Raio = double.Parse(Console.ReadLine(), CI);
            double circ = calc.Cicurferencia(Raio);
            double volume = calc.Volume(Raio);


            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CI));
            Console.WriteLine("Volume: " + volume.ToString("F2", CI));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CI));












        }
    }
}
