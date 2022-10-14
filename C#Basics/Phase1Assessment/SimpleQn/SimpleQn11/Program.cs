using System;
namespace StringQn12
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number=int.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter a number to be in power");
            int power=int.Parse(Console.ReadLine());
            int product=1;
            for(int i=1;i<=power;i++)
            {
                product=product*number;
            }
            System.Console.WriteLine("The result is "+product);

            
        }
    }
}
