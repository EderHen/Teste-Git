using System;
using System.Globalization;

namespace Problema_estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

          
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);







            /*
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CI);


            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto { Nome = "TV", Preco = 500.00, Quantidade = 20 };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionadas ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + p);
            */

        }
    }
}
