using System;
using System.Globalization;

namespace estruturawhile
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.WriteLine("Digite um numero para saber a sua raiz quadrada:");
            double n1 = double.Parse(Console.ReadLine(), CI);

            double raiz;
            while (n1 >= 0)
            {
                raiz = Math.Sqrt(n1);
                Console.WriteLine(raiz.ToString("F3", CI));
                Console.WriteLine("Digite outro numero:");
                n1 = double.Parse(Console.ReadLine(), CI);
            }

                Console.WriteLine("Numero Negativo");


        }
    }
}
