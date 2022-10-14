using System;
namespace DateTimeqn13;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter date");
        int date=int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter month ");
        int month=int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter year");
        int year=int.Parse(Console.ReadLine());
        DateTime data=new DateTime(year,month,date);
        System.Console.WriteLine("The formatted date is :"+data.ToString("d"));
       // DateTime date1=new DateTime();
        var value=System.Threading.Thread.CurrentThread.CurrentCulture;
        var difference=data.DayOfWeek-value.DateTimeFormat.FirstDayOfWeek;
        if(difference<0)
        {
            difference=difference+7;
        }
         data=data.AddDays(-difference).Date;
         System.Console.WriteLine(data.ToString("d"));
        
    }
}
