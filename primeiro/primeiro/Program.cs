using System;
using System.Globalization;

namespace teste_vetor
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for(i=0;i<n;i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine();
            Console.WriteLine("Numeros Digitados:");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
           



        }
    }
}
