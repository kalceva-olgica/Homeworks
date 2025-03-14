namespace Car_Rasing_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two cars and two drivers: ");

            Car[] cars = {
            new Car("Golf", 200),
            new Car("Mazda", 220),
            new Car("Ferrari", 300),
            new Car("Fiat", 280)
        };

            Driver[] drivers = {
            new Driver("Bob", 3),
            new Driver("Teo", 4),
            new Driver("Ana", 5),
            new Driver("Sofia", 2)


        };


        }
    }
}
