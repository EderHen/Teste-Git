using System;
using System.Globalization;
using System.Collections.Generic;

namespace exerciseFixation_lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> infor = new List<Employee>();



            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CI);
                infor.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("Enter the employee id that will have increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = infor.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }


            
            Console.WriteLine("Updated list of employess:");
          foreach (Employee info in infor)
            {
                Console.WriteLine(info);
            }





        }
    }
}
