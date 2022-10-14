using System;
namespace IfStatementQuestion3
{
    class Program
    {
     public static void Main(string[] args)
     {
        System.Console.WriteLine("Enter year ");
        int year=int.Parse(Console.ReadLine());
        if(year%100==0)
        {
            string result=(year%4==0 && year%400==0)?$"{year}  is leap year":"No it is not a leap year";
            System.Console.WriteLine(result);
        }
        else
        {
            string result=(year%4==0 )?$"{year} is leap year":"No it is not a leap year";
            System.Console.WriteLine(result);
        }

        
     }
    }
}
