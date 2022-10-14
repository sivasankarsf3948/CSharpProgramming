using System;
namespace DateTimeqn11;
class Program{
    public static void Main(string[] args)
    {
        DateTime date=DateTime.Now;
        System.Console.WriteLine("The date of today is "+date.ToString("d"));
        System.Console.WriteLine("The twelve months are ");
        for(int i=1;i<=12;i++)
        {
            System.Console.WriteLine(date.ToString("MMMM"));
            date=date.AddMonths(1);
        }
        
    }
}
