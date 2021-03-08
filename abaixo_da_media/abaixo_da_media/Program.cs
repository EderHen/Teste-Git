using System;
using System.Globalization;

namespace abaixo_da_media
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos elementos vai ter o vetor? ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];
            double media = 0, soma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
                soma = soma + vet[i];
            }

            media = soma / n;
            Console.WriteLine("Media do vetor = " + media.ToString("F3", CI));

            Console.WriteLine("Elementos abaixo da media:");
            for (int i = 0; i < n; i++)
            {
                if(vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CI));
                }
            }
        }
    }
}
