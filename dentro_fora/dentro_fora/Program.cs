using System;

namespace dentro_fora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quandtos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int x, dentro = 0, fora = 0;
            
            
            for(int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());
                if(x < 10 || x > 20)
                {
                    fora++;
                }
                else
                {
                    dentro++;
                }
            }

            Console.WriteLine(+dentro + " DENTRO");
            Console.WriteLine(+fora + " FORA");
        }
    }
}
