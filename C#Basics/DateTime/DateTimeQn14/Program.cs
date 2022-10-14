using System;
namespace DateTimeQn14;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter month number");
        int month=int.Parse(Console.ReadLine());
       // DateTime date=new DateTime(2022,month,12);
        int days=DateTime.DaysInMonth(2022,month);
       // System.Console.WriteLine(days);
        System.Console.WriteLine("Enter number of leaves taken");
        int leave=int.Parse(Console.ReadLine());
        int total=days-leave;
        int salary=total*500;
        System.Console.WriteLine("Your salary is "+salary);
    }
}
