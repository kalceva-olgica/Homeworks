namespace Task_2_Inheritancee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] Company = {
            new Contractor("Bob", "Bobert", 1000),
            new Contractor("Rick", "Rickert", 1450),
            new Manager("Mona", "Monalisa", 3000),
            new Manager("Igor", "Igorsky", 3600),
            new SalesPerson("Lea", "Leova", 1000)
        };

            CEO ceo = new CEO("Ron", "Ronsky", 1500, 100, Company);
            ceo.AddSharesPrice(10);

            ceo.PrintInfo();
            Console.WriteLine($"Salary of CEo is: {ceo.GetSalary()}");
            ceo.PrintEmployees();
        }
    }
    }

