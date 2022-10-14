using System;
namespace DateTimeQn7
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a starting date as dd/MM/yyyy");
            DateTime date1= DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter a ending date asdd/MM/yyyy ");
            DateTime date2= DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            int result=DateTime.Compare(date1,date2);
            if(result<0)
            {
                System.Console.WriteLine(date1.ToShortDateString()+" is earlier than "+date2.ToShortDateString());
            }
            
        }
    }
}
