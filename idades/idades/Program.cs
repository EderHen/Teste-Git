using System;
using System.Globalization;

namespace idades
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome1, nome2;
            int idade1, idade2;
            double media;

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("NOME: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("NOME: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            media = ((double)idade1 + (double)idade2) / 2;
            Console.Write("A idade media de " + nome1 + " e " + nome2 + " eh de " + media.ToString("F1", CI) + " anos");

        }
    }
}
