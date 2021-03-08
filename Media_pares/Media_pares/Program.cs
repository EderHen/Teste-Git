using System;
using System.Globalization;

namespace Media_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos elementos vai tero vetor? ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0, qtd = 0;
            double media;
            int[] vet = new int[n];

            for(int i = 0;i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
                if(vet[i] % 2 == 0)
                {
                    soma = soma + vet[i];
                    qtd++;
                }
            }

                if(qtd == 0)
                {
                    Console.Write("Nenhum numero par");
                }
                else
                {
                media = (double)soma / qtd;
                Console.Write("Media dos Pares = " + media.ToString("F1", CI));
                }
        }
    }
}
