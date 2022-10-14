using System;
namespace DateTimeQn9
{
    class Program{
        public static void Main(string[] args)
        {
      
            for(int i=1994;i<=2014;i++)
            {
                if(DateTime.IsLeapYear(i))
                {
                    System.Console.WriteLine(i+" is leap year");
                    DateTime date=new DateTime(i,2,29);
                    DateTime date1=date.AddYears(1);
                    System.Console.WriteLine($"One year from {date.ToString("d")} is {date1.ToString("d")}");
                }
            }
        }
    }
}
