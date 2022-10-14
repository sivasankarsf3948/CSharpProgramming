using System;
namespace IfStatementQuestion9
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" Enter Month name");
            string month=Console.ReadLine().ToLower();
            if(month=="december" || month=="january" || month== "february")
            {
                System.Console.WriteLine("It's winter");
            }
            else if(month=="march" || month=="april" || month== "may")
            {
                System.Console.WriteLine("It's spring");
            }
            else if(month=="june" || month=="july" || month== "august") {           
                System.Console.WriteLine("It's winter");
            }
            else if(month=="september" || month=="october" || month== "november")
            {
                System.Console.WriteLine("It's rainfall");
            }
        }
    }
}