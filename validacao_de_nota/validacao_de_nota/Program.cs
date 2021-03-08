using System;
using System.Globalization;

namespace validacao_de_nota
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine(), CI);
            
            while (nota1 < 0 || nota1 > 10)
            {
                Console.Write("Valor invalido! Tente novamente: ");
                nota1 = double.Parse(Console.ReadLine(), CI);
            }

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine(), CI);

            while (nota2 < 0 || nota2 > 10)
            {
                Console.Write("Valor invalido! Tente novamente: ");
                nota2 = double.Parse(Console.ReadLine(), CI);
            }

            double media = (nota1 + nota2) / 2;
            Console.Write("MEDIA = " + media.ToString("F2", CI));


        }
    }
}
