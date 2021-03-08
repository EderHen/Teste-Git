using System;
using System.Collections.Generic;
using System.Globalization;

namespace RedoLIst
{
    class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public void SalaryIncrease(double percentage)
        {
            Salary = (Salary * percentage / 100) + Salary;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
