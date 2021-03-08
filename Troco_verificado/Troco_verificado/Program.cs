using System;
using System.Globalization;

namespace Troco_verificado
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Preco unitario do produto: ");
            double unidade = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            int qtd = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro Recebido: ");
            double recebido = double.Parse(Console.ReadLine(), CI);

            double troco = recebido - (unidade * qtd);

            if(troco < 0)
            {
                troco = troco * -1;
                Console.Write("Dinheiro Insuficiente. Faltam " + troco.ToString("F2", CI));
            }
            else
            {
                Console.Write("TROCO = " + troco.ToString("F2", CI));
            }
            
            


        }
    }
}
