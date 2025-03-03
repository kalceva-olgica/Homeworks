namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the operator: ");

            char operation = Console.ReadLine()[0];  

            int result = 0; 

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                    {
                        Console.WriteLine("You cant divide with zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }

            Console.WriteLine("The result is: " + result);
        }

    }
    }






