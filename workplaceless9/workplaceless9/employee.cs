using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workplaceless9
{
    public class Employee
    {
       public string name;
        public string surname;
        public string position;
        public int dailysalary;
        public int salary(int num)
        {
            return dailysalary * 30;
        }
        
    }
}
