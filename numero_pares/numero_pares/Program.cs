using System;

namespace numero_pares
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int qtd = 0;
            int[] vet = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\nNumeros Pares: ");
            for(int i = 0; i < n; i++)
            {
                if(vet[i] % 2 == 0)
                {
                    qtd++;
                    Console.Write(vet[i] + "  ");
                }
            }
            Console.Write("\n\nQuantidade de Pares = " + qtd);












        }
    }
}
