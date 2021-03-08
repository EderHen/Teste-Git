using System;
using System.Globalization;

namespace ifelse_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite o codigo do produto e a quantidade comprada");
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double preco = 0;
            if (codigo == 1)
            {
                preco = 4.00;
            }
            else if(codigo == 2)
            {
                preco = 4.50;
            }
            else if(codigo == 3)
            {
                preco = 5.00;
            }
            else if(codigo == 4)
            {
                preco = 2.00;
            }
            else
            {
                preco = 1.50;
            }
            double  total;

            total = preco * qtd;
            Console.WriteLine("Total = " + total.ToString("F2", CI));
 




















        }
    }
}
