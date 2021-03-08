using System;

namespace ifelse_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro e descubra se é par ou impar");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
        }
    }
}
