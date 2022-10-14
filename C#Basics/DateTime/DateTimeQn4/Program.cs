using System;
namespace DateTimeQn4
{
    class Program{
        public static void Main(string[] args)
        {
            DateTime date=new DateTime(2016/11/07);
            System.Console.WriteLine("THe day of the week is ");
            System.Console.WriteLine(date.DayOfWeek);
        }
    }
}
