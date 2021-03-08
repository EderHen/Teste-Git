using System;
using System.Globalization;

namespace teste
{
    class Program
    {

        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos você tem na sua casa? ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto:");
            double preco = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Entre seu ultimo nome, idade e altura(mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string lastname = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CI);

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CI));
            Console.WriteLine(lastname);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CI));



        }
    }
}
