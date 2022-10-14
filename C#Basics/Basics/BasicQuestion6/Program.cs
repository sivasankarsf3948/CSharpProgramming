using System;
namespace BasicQuestion6
{
    class program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Price amount");
            double price=double.Parse(Console.ReadLine());
            double total=price+price*0.18;
            System.Console.WriteLine($"Total amount inclusive of tax is {total}");
            
        }
    }
}