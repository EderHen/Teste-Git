using System;
using System.Globalization;

namespace Course02
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo C = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];
            double sum = 0.0;

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), C);
                vect[i] = new Produto (name, price);
                sum += vect[i].Price;

            }

            double average = sum / n;

            Console.WriteLine("Average Price = {0}", average.ToString("F2", C));









        }
    }
}
