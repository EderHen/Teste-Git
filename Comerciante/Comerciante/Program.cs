using System;
using System.Globalization;

namespace Comerciante
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Serao digitados dados de quantos produtos? ");
            int n = int.Parse(Console.ReadLine());

            string[] produto = new string[n];
            double[] compra = new double[n];
            double[] venda = new double[n];
            double totalc = 0, totalv = 0;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Produto " + (i + 1) + ":");
                produto[i] = Console.ReadLine();
                Console.Write("Preco de compra: ");
                compra[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Preco de venda: ");
                venda[i] = double.Parse(Console.ReadLine(), CI);

                totalc = totalc + compra[i];
                totalv = totalv + venda[i];
            
            }

            double lucro, lucrop;
            int l10= 0, l20 = 0, lmais = 0;
            for (int i = 0; i < n; i++)
            {
                lucro = venda[i] - compra[i];
                lucrop = lucro / compra[i] * 100;
                if (lucrop < 10)
                {
                    l10++;
                }
                else if (lucrop <= 20)
                {
                    l20++;
                }
                else
                {
                    lmais++;
                }
            }
                double lucrot = totalv - totalc;
                Console.WriteLine("\nRelatorio:");
                Console.WriteLine("Lucro abaixo de 10%: " + l10);
                Console.WriteLine("Lucro ente 10% e 20%: " + l20);
                Console.WriteLine("Lucro acima de 20%: " + lmais);
                Console.WriteLine("Valor total de compra: " + totalc.ToString("F2", CI));
                Console.WriteLine("Valor total de venda: " + totalv.ToString("F2", CI)) ;
                Console.WriteLine("Lucro total: " + lucrot.ToString("F2", CI));

        }
    }
}
