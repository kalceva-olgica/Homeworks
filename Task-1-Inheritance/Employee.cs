using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Inheritance
{
   public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; protected set; }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
