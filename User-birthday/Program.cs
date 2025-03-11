namespace User_birthday
{
 
class Program
    {
        // FIRST HOMEWORK
        static int AgeCalculator(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        static void Main()
        {
            Console.Write("Enter your birthdate : ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime birthDate))
            {
                int age = AgeCalculator(birthDate);
                Console.WriteLine("You are " + age + " years old.");
            }
            else
            {
                Console.WriteLine("Invalid date formay.");
            }
        }
    }


}

