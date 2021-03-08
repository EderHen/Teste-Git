using System;

namespace for_exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos numeros voce vai digitar");
            int n = int.Parse(Console.ReadLine());


            int inn = 0, outt = 0, x;
            for(int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if(x >= 10 && x <= 20)
                {
                    inn++;
                }
                else
                {
                    outt++;
                }
            }
            Console.WriteLine($"{inn} in");
            Console.WriteLine($"{outt} out");
        }
    }
}
