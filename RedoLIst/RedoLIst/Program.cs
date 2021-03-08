using System;
using System.Collections.Generic;
using System.Globalization;

namespace RedoLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo C = CultureInfo.InvariantCulture;


            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #{0}: ", (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), C);
                list.Add(new Employee { Id = id, Name = name, Salary = salary });
                Console.WriteLine();
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == searchId);
            if(emp != null)
            {
                Console.Write("Enter the percetage: ");
                double percentage = double.Parse(Console.ReadLine(), C);
                emp.SalaryIncrease(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employess: ");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
