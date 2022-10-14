using System;
namespace SimpleQn4
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Indian  amount in rupee");
            double rupee=int.Parse(Console.ReadLine());
            double usd=rupee*0.0122;
            System.Console.WriteLine("Amount in USD is "+usd);
            double eur=rupee*0.0127;
            System.Console.WriteLine("Amount in EUR is "+eur);
            double cny=rupee*0.0879;
            System.Console.WriteLine("Amount in CNY is "+cny);
            
        }
    }
}
