using System;
using System.Globalization;

namespace teste_alturas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());



            Product[] vet = new Product[n];

            double sum = 0.0;
            for(int i = 0; i< n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CI);
                vet[i] = new Product { Name = name, Price = price };
            }

            for(int i = 0; i <n; i++)
            {
                sum += vet[i].Price;
            }





            double avg = sum / n;
            Console.WriteLine("Average Price = " + avg.ToString("F2", CI));



        }
    }
}
