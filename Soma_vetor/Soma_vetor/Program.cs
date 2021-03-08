using System;
using System.Globalization;
namespace Soma_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Quantos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];
            double soma = 0;
            for(int i= 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
                soma = soma + vet[i];
            }

            Console.Write("\nValores = ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i].ToString("F1", CI)+ "  ");
            }
            Console.WriteLine("\nSoma = " + soma.ToString("F2", CI));
            double media = soma / n;
            Console.WriteLine("Media = " + media.ToString("F2", CI));










        }
    }
}
