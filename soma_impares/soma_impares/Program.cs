using System;

namespace soma_impares
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite dois numeros");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int troca = 0;
            if(x > y)
            {
                troca = x;
                x = y;
                y = troca;
            }

            int soma = 0;
            for(int i = x+1; i < y;i++)
            {
                if(i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.Write("Soma dos Impares = " + soma);



        }
    }
}
