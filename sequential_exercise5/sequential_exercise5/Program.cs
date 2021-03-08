using System;
using System.Globalization;

namespace sequential_exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Type code of the FIRST Piece, the amount and the price of each one: ");
            string[] vet = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet[0]);
            int amount1 = int.Parse(vet[1]);
            double value1 = double.Parse(vet[2], CI);

            Console.WriteLine("Type code of the SECOND Piece, the amount and the price of each one: ");
            vet = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet[0]);
            int amount2 = int.Parse(vet[1]);
            double value2 = double.Parse(vet[2], CI);
            

            double payment = value1 * amount1 + value2 * amount2;
            Console.WriteLine("Amount payable : " + payment.ToString("F2",CI));












        }
    }
}
