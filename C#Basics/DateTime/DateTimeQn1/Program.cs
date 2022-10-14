using System;
namespace DateTimeQn1
{
    class Program{
        public static void Main(string[] args)
        {
           DateTime[] dates = { DateTime.Now,new DateTime(2016, 8, 16, 9, 28, 0),new DateTime(2011, 5, 28, 10, 35, 0), new DateTime(1979, 12, 25, 14, 30, 0) }; 
          
          for(var i=0;i<dates.Length;i++)
          {
           System.Console.Write(" Day "+dates[i].ToShortDateString());
           System.Console.WriteLine(" Time "+dates[i].ToString("hh:mm:ss.fff"));
           System.Console.WriteLine(" ");
           System.Console.Write(" Day "+dates[i].ToShortDateString());
           System.Console.Write(" Time "+dates[i].ToString("hh:mm:ss:tt")); 
           System.Console.WriteLine(" ");

          }


                           
        }
    }
}
