using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Inheritancee
{
   public  class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice;

        public CEO(string firstName, string lastName, double salary, int shares, Employee[] employees) : base(firstName, lastName, salary)
        {
            Shares = shares;
            Employees = employees;
        }

        public void AddSharesPrice(double price)
        {
            SharesPrice = price;
        }

        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Emplotees:");
            Console.WriteLine(string.Join("\n", Employees.Select(temp => temp.FirstName + " " + temp.LastName)));

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Ceo:\nfirst name: {FirstName}, last name: {LastName}, alary: {Salary}");
        }
    }
}
