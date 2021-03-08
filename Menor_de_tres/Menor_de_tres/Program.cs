using System;
using System.Globalization;

namespace Menor_de_tres
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Primeiro Valor: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Terceiro Valor: ");
            int x3 = int.Parse(Console.ReadLine());

            int menor;

            if (x1 < x2 && x1 < x3)
            {
                menor = x1;
            }
            else if (x2 < x3)
            {
                menor = x2;
            }
            else
            {
                menor = x3;
            }
            Console.Write("Menor = " + menor);
            
                    
                   
           


        }
    }
}
