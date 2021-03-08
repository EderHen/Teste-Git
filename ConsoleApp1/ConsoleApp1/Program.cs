using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores e descubra se são multiplos: ");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            if(x % y == 0 || y % x == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
            

          


        }
    }
}
