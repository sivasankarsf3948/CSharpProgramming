using System;
namespace DateTimeqn5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter starting year ");
            int start=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter ending year ");
            int end=int.Parse(Console.ReadLine());
            for(int i=start;i<=end;i++)
            { 
                DateTime date=new DateTime(i,12,31);
                 if(i%100==0)
                {  
                    if(i%4==0 &&i%400==0)
                    {
                      System.Console.WriteLine($"{date.ToString("d")} day 366 of {i} (Leap year)");
                    }
                    else
                    {
                       System.Console.WriteLine($"{date.ToString("d")} day 365 of {i} ");
                    }
                }
                else if(i%4==0)
                {
                       System.Console.WriteLine($"{date.ToString("d")} day 366 of {i} (Leap year)");
                }
                else
                {
                     System.Console.WriteLine($"{date.ToString("d")} day 365 of {i} ");
               }
        }   }
    }
}
