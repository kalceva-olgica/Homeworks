namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input the first number");
            int firstInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number");
            int secondInput = Convert.ToInt32(Console.ReadLine());

            int temp = firstInput;
            firstInput = secondInput;
            secondInput = temp;

            Console.WriteLine($"First Input ={firstInput}, second Input = {secondInput}");

        }
    }
}
