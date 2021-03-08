using System;
using System.Globalization;
namespace Troco
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double unidade, recebido, troco, total;
            int qtd;

            Console.Write("Preco unitario do produto: ");
            unidade = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade Comprada: ");
            qtd = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro Recebido: ");
            recebido = double.Parse(Console.ReadLine(), CI);

            total = unidade * qtd;
            troco = recebido - total;
            Console.Write("TROCO = " + troco.ToString("F2", CI));

        }
    }
}
