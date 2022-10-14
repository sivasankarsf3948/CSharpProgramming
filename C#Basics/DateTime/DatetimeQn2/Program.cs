using System;
namespace DatetimeQn2
{
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter date in dd/mm/yyyy hh:mm:ss tt");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        System.Console.WriteLine("1.Complete date ");
        System.Console.WriteLine(date.ToString("dd/MM/yyyy hh:mm:ss tt"));
        System.Console.WriteLine("2.To short date string :");
        System.Console.WriteLine(date.ToShortDateString());
        System.Console.WriteLine("3.To long  date string :");
        System.Console.WriteLine(date.ToLongDateString());
        System.Console.WriteLine("4.12 Hour format");
        System.Console.WriteLine(date.ToString("dd/MM/yyyy hh:mm:ss tt"));
        System.Console.WriteLine("5.Date only ");
        System.Console.WriteLine(date.ToString("dd/MM/yyyy"));
        System.Console.WriteLine("5.Time only ");
        System.Console.WriteLine(date.ToString("hh:mm:ss tt"));
    }
}
}

