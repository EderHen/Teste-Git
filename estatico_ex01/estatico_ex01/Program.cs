using System;
using System.Globalization;

namespace estatico_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Qual é a cotação do dolar: ");
            double Cotacao = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantos dolares voce vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CI);

            double result = ConversorDeMoeda.Conversor(quantia, Cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CI));



        }
    }
}
