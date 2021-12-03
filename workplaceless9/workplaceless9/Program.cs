// See https://aka.ms/new-console-template for more information

using System;

namespace workplaceless9
{
    public class less9
    {
        public static void Main()
        {
            Employee employee = new Employee()
            {
                dailysalary = 500,
                name = "pervin",
                position = "programmer",
                surname = "pasha"
            };
            employee.salary(employee.dailysalary);
            int monthsal = employee.salary(employee.dailysalary);
            Console.WriteLine(monthsal);
        }
    }
}