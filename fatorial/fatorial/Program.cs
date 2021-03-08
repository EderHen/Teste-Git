using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            int mult = 1;
            for (int i = 1; i <= n; i++)
            {
                mult = mult * i;
            }
            Console.Write("Fatorial = " + mult);




        }
    }
}
