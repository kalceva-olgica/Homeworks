namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 3;
            //int c = 4;
            //int d = 22;

            //int average = (a + b + c + d) / 4;

            //Console.WriteLine(average);

            Console.WriteLine("Enter th first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int thirdNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the fourth number: ");
            int fourthNum = Convert.ToInt32(Console.ReadLine());

            int result = (firstNum + secondNum + thirdNum + fourthNum) / 4;

            Console.WriteLine("The average number is " + result);


        }
    }
}
