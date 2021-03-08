using System;
using System.Globalization;

namespace Operadora
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double pagar = 50.00;

            Console.Write("Digite a quantidade de minutos: ");
            int minutos = int.Parse(Console.ReadLine());

            if(minutos > 100)
            {
                pagar = ((minutos - 100.00) * 2.0) + 50.00;
            }
      
            
            Console.Write("Valor a pagar: " + pagar.ToString("F2", CI));





        }
    }
}
