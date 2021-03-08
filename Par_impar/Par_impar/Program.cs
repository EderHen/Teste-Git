using System;

namespace Par_impar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos valores voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int x;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if (x % 2 != 0 && x < 0)
                {
                    Console.WriteLine("Impar negativo");
                }
                else if (x % 2 != 0 && x > 0)
                {
                    Console.WriteLine("Impar positivo");
                }
                else if(x % 2 == 0 && x > 0)
                {
                    Console.WriteLine("Par positivo");
                }
                else if(x % 2 == 0 && x < 0)
                {
                    Console.WriteLine("Par negativo");
                }
                else
                {
                    Console.WriteLine("NULO");
                }

            }
        }
    }
}
