using System;
using System.Globalization;

namespace sequential_exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Type the Identification  Number of the employee, worked hours and the value of each hour worked: ");
            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double paymentphour = double.Parse(Console.ReadLine(), CI);

            double monthpayment = hours * paymentphour;
            Console.WriteLine($"Number = {number}");
            Console.WriteLine("Salary = U$ " + monthpayment.ToString("F2", CI));
        }
    }
}
