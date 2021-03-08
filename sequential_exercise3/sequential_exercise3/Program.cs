using System;

namespace sequential_exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type four values to find the difference between them: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            int dif = n1 * n2 - n3 * n4;
            Console.WriteLine("Difference between them = " + dif);
            Console.WriteLine("Difference between them = {0}", dif);
            Console.WriteLine($"Difference between them = {dif}");
        }
    }
}
