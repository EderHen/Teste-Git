using System;
using System.Globalization;

namespace RedoExercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo C = CultureInfo.InvariantCulture;

            Console.Write("Qual é a contação do dólar? ");
            ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine(), C);
            Console.Write("Quantos dólares você vai comprar?");
            ConversorDeMoeda.CompraDolares = double.Parse(Console.ReadLine(), C);

            Console.WriteLine("Valor a ser pago em reais = {0}", ConversorDeMoeda.ValorAPagar().ToString("F2", C));
        }
    }
}
