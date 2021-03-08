using System;

namespace for_ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
                Console.WriteLine();

            }
        }
    }
}
