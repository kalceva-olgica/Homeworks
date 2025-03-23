namespace Homework_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> numbers = new Queue<int>();
            string firstInput;

            do
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                numbers.Enqueue(number);


                Console.Write("Do you want to input another number? (YES/NO) : ");
                firstInput = Console.ReadLine().ToUpper();

            } while (firstInput == "YES");


            Console.WriteLine("\nNumbers in the order they were entered from tge QUEUE: ");
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Dequeue());
            }
        }
    }
}





