namespace Task_1_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("Olgica", 22, 30000, "IT");
            Manager manager2 = new Manager("Alex", 34, 81000, "Finance");

            Contractor contractor1 = new Contractor("Ana", 30, 160, 50, manager1);
            Contractor contractor2 = new Contractor("Justin", 28, 180, 55, manager2);

            Console.WriteLine($"{contractor1.Name}'s Salary: {contractor1.GetSalary()} in {contractor1.CurrentPosition()} department");
            Console.WriteLine($"{contractor2.Name}'s Salary: {contractor2.GetSalary()} in {contractor2.CurrentPosition()} department");
        }
    }
}
