using System;
using System.Globalization;

namespace redoExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + produto);

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int adicionar = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(adicionar);

            Console.WriteLine("\nDados atualizados: " + produto);

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(remover);

            Console.Write  ("\nDados atualizados: " + produto);





        }
    }
}
