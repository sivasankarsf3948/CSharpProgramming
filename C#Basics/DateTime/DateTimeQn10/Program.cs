using System;
namespace DateTimeQn10
{
    class Program{
        public static void Main(string[] args)
        {
            DateTime date=DateTime.Now;
             System.Console.WriteLine("Yesterday date is ");
            System.Console.WriteLine(date.AddDays(-1).ToString("dd/mm/yyyy"));
            System.Console.WriteLine("Tomorow date is ");
            System.Console.WriteLine(date.AddDays(1).ToString("dd/mm/yyyy"));
        }
    }
}
