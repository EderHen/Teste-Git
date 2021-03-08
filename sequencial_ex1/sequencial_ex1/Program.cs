using System;

namespace sequencial_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type two numbers to add them");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int sum = n1 + n2;
            Console.WriteLine("Sum result = " + sum);



        }
    }
}
