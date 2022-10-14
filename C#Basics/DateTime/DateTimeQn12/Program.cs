using System;
namespace DateTimeQn12;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter year");
        int year=int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter month");
        int month=int.Parse(Console.ReadLine());
        int result=DateTime.DaysInMonth(year,month);
        System.Console.WriteLine("The days in month are "+result);
    }
}
