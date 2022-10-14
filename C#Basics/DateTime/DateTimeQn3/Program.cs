using System;
namespace DateTimeQn3
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter datetime in the format dd/MM/yyyy hh:mm:ss.fff tt");
            DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss.fff tt",null);
            Console.WriteLine("1.Day = "+date.Day);       
            Console.WriteLine("2.month = "+date.Month);      
            Console.WriteLine("3.Year= "+date.Year);
            Console.WriteLine("4.Hour = "+date.Hour);         
            Console.WriteLine("5.Minute= "+date.Minute);      
            Console.WriteLine("6.Second = "+date.Second);
            Console.WriteLine("7.Millisecond = "+date.Millisecond);
        }
    }
}
