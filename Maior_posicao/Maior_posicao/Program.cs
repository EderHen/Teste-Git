using System;
using System.Globalization;

namespace Maior_posicao
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            double maior = vet[0];
            int posmaior = 0;

                for(int i = 0; i < n; i++)
            {
                if(vet[i] > maior)
                {
                    maior = vet[i];
                    posmaior = i;
                }               
            }
            Console.WriteLine("Maior valor = " + maior.ToString("F1", CI));
            Console.Write("Posicao do maior valor = " + posmaior);
        }
    }
}
