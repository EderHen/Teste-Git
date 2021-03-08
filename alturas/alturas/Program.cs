using System;
using System.Globalization;
namespace alturas
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantas pessoas serao digitadas? ");
            int n = int.Parse(Console.ReadLine());

            int qtd = 0;
            double totalA = 0, media, porc;
            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa:");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                altura[i] = double.Parse(Console.ReadLine(), CI);

                totalA = totalA + altura[i];
                if (idade[i] < 16)
                {
                    qtd++;
                } 

            }
            media = totalA / n;
            Console.WriteLine("Altura media = " + media.ToString("F2", CI));

            porc = qtd * 100 / n;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porc.ToString("F1", CI) + "%");
            for (int i = 0; i < n; i++)
            {
                if(idade[i] < 16)
                {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}
