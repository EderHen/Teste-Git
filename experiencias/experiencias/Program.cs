using System;
using System.Globalization;

namespace experiencias
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos casos de teste serao digitados? ");
            int n = int.Parse(Console.ReadLine());

            int qtd,somaT = 0,coelho = 0, sapo = 0, rato = 0;
            char cobaia;
            for(int i = 0; i < n; i++)
            {
                Console.Write("Quantidade de cobaias: ");
                qtd = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaia: ");
                cobaia = char.Parse(Console.ReadLine());

                somaT = somaT + qtd;
                if(cobaia == 'C')
                {
                    coelho = coelho + qtd;
                }
                else if(cobaia == 'R')
                {
                    rato = rato + qtd;
                }
                else if(cobaia == 'S')
                {
                    sapo = sapo + qtd;
                }
            }
        
            Console.WriteLine("\nRelatorio FInal: ");
            Console.WriteLine("Total: " + somaT);
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de Sapos: " + sapo);
            double pcoelho = 100 * (double)coelho / somaT;
            Console.WriteLine("Percentual de coelhos = " + pcoelho.ToString("F2", CI));
            double prato = 100 * (double)rato / somaT;
            Console.WriteLine("Percentual de ratos = " + prato.ToString("F2", CI));
            double psapo = 100 * (double)sapo / somaT;
            Console.WriteLine("Percentual de sapos = " + psapo.ToString("F2", CI));




        }
    }
}
