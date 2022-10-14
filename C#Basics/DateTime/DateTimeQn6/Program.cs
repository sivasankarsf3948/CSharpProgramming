using System;
namespace DateTimeQn6
{
    class Program{
        public static void Main(string[] args)
        {
            DateTime date=DateTime.Now;
            System.Console.WriteLine("Today date is"+date.ToString());
            DateTime date1=date.AddDays(40);
            System.Console.WriteLine("Day of week after 40 days");
            System.Console.WriteLine(date1.DayOfWeek);

        }
    }
}
