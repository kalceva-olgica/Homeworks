using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Inheritance
{
   public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public Manager Responsible { get; set; }
        public int PayPerHour { get; set; }


        public Contractor(string name, int age, double workHours, int payPerHour, Manager responsible)
            : base(name, age, 0)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            return Responsible.Department;
        }
    }
}
