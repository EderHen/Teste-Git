using System;
using System.Globalization;

namespace lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Codigo do produto comprado: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade Comprada: ");
            int qtd = int.Parse(Console.ReadLine());

            double pagar = 0;

            if (codigo == 1)
            {
                pagar = 5.00 * qtd;
            }
            else if (codigo == 2)
            {
                pagar = 3.50 * qtd;
            }
            else if (codigo == 3)
            {
                pagar = 4.80 * qtd;
            }
            else if (codigo == 4)
            {
                pagar = 8.90 * qtd;
            }
            else if (codigo == 5)
            {
                pagar = 7.32 * qtd;
            }


            Console.Write("Valor a pagar: " + pagar.ToString("F2", CI));

        }
    }
}
