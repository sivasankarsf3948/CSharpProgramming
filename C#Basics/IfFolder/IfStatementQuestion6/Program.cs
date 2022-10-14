using System;
namespace IfStatementquestion6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a celcius value");
            int temp=int.Parse(Console.ReadLine());
            if(temp<0)
            {
                System.Console.WriteLine("It's freezing weather");
            }
            else if(temp>=0 && temp<10)
            {
                System.Console.WriteLine("It's very cold weather");
            }
            else if(temp>=10 && temp<20)
            {
                System.Console.WriteLine("It's cold  weather");
            }
            else if(temp>=20 && temp<30)
            {
                System.Console.WriteLine("It's normal in temperature");
            }
            else if(temp>=30 && temp<40)
            {
                System.Console.WriteLine("It's hot");
            }
            else if(temp>=40)
            {
                System.Console.WriteLine("It's very hot");
            }
            
        }
    }
}
