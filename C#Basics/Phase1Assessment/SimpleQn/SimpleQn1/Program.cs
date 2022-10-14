using System;
namespace SimpleQn1
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a inch value ");
            double number=double.Parse(Console.ReadLine());
            //converting to cm
            double result=number*2.54;
            System.Console.WriteLine("The value in centimetres be :"+result);
            
        }
    }
}
