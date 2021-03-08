using System;

namespace iniciovetor_negativo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Numeros negativos: ");
            for(int i = 0; i < n; i++)
            {
                if(vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }









        }
    }
}
