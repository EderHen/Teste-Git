using System;

namespace for_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int x = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= x; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
