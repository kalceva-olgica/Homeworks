using System;

namespace Bonus_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your level of difficulty.(EASY, NORMAL OR HARD)");
            string inputMode = Console.ReadLine();

            switch (inputMode.ToLower())
            {
                case "easy":
                    Console.WriteLine("You have 9 tries to guess the number between 0-100");
                    break;
                case "normal":
                    Console.WriteLine("You have 7 tries to guess the number between 0-100");
                    break;
                case "hard":
                    Console.WriteLine("You have 5 tries to guess the number between 0-100");
                    break;
                default:
                    Console.WriteLine("Invalid mode");
                    break;
            }

            int number = 72;

            int numberInput = Convert.ToInt32(Console.ReadLine());

            if(numberInput > 0 && numberInput < 62)
            {
                Console.WriteLine("Your guess is far to low, number entered: " + numberInput);
            } else if(numberInput > 63 && numberInput < 71)
            {
                Console.WriteLine("Your guess is a little bit lower, number entered: " + numberInput);
            } else if( numberInput > 73 && numberInput < 80)
            {
                Console.WriteLine("Your guess is a little bit higher, number entered: " + numberInput);
            } else if(numberInput > 80 && numberInput < 100)
            {
                Console.WriteLine("Your guess is far to high, number entered: " + numberInput);
            } else if (numberInput == number)
            {
                Console.WriteLine("Nailed it. number entered: " + number);
            }


            while(numberInput != number)
            {
                Console.WriteLine("Try again");
            }



            
           


        }
    }
}
