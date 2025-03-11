
public class DateCalculations
    {
        public static void Main(string[] args)
        {
            DateTime today = DateTime.Today;

            DateTime threeDaysFromNow = today.AddDays(3);   
            Console.WriteLine("3 days from now: " + threeDaysFromNow.ToString("yyyy-MM-sd"));

            DateTime oneMonthFromNow = today.AddMonths(1);
            Console.WriteLine("1 month from now: " + oneMonthFromNow.ToString("yyyy-MM-dd"));

            DateTime oneMonthAndThreeDaysFromNow = today.AddMonths(1).AddDays(3);
            Console.WriteLine("1 month and 3 days from now: " + oneMonthAndThreeDaysFromNow.ToString("yyyy-MM-dd"));

            DateTime oneYearTwoMonthsAgo = today.AddYears(-1).AddMonths(-2);
            Console.WriteLine("1 year and 2 months ago: " + oneYearTwoMonthsAgo.ToString("yyyy-MM-dd"));

            int currentMonth = today.Month;
            Console.WriteLine("Current month: " + currentMonth);

            int currentYear = today.Year;
            Console.WriteLine("Current year: " + currentYear);
        }
    }


