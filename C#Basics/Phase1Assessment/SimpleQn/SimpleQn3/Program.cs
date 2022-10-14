using System;
namespace SimpleQn3
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a Celcius value ");
            double celcius=double.Parse(Console.ReadLine());
            double fahrenheit=(double)celcius*(double)9/5+32;
            System.Console.WriteLine("The value in fahrenheit is :");
            System.Console.WriteLine(Math.Round(fahrenheit,2));
            
        }
    }
}
