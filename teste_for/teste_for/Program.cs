using System;

namespace teste_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("quantos numero voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int valor, soma = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write("Valor #" + (i + 1) +": ");
                valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine($"Soma = {soma}");

        }
    }
}
