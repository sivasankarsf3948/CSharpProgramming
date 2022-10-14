using System;
namespace Datetime_method{
    class Program{
        public static void Main(string[] args)
        {
            DateTime date=new DateTime(2021,8,10,10,40,32);
            System.Console.Write(" The year is ");
            System.Console.WriteLine(date.Year);
            System.Console.Write(" The month is ");
            System.Console.WriteLine(date.Month);
            System.Console.Write(" The day is ");
            System.Console.WriteLine(date.Day);
            System.Console.Write(" The hour is ");
            System.Console.WriteLine(date.Hour);
            System.Console.Write(" The minute is ");
            System.Console.WriteLine(date.Minute);
            System.Console.Write(" The second is ");
            System.Console.WriteLine(date.Second);

            
            string data=date.ToString();
            char[] value=new char[data.Length];
            for(int i=0;i<data.Length;i++)
            {
                 value[i]=data[i];
            }
            foreach(char i in value)
            {
                System.Console.Write(i);
            }
            System.Console.WriteLine(date.ToShortDateString());
        }
    }
}
