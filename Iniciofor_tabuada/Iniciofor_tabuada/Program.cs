using System;

namespace Iniciofor_tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int mult;

            Console.Write("Deseja a tabuada para qual valor? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                mult = x * i;
                Console.WriteLine(+x + " X " + i + " = " + mult);
            }



        }
    }
}
