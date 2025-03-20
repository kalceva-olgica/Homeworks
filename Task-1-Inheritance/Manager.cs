using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Inheritance
{
   public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string name, int age, double salary, string department)
            : base(name, age, salary)
        {
            Department = department;
        }
    }
}
