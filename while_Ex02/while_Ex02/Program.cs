using System;

namespace while_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas (X, Y)");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Q4");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Q3");
                }
                else
                {
                    Console.WriteLine("Q2");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}
