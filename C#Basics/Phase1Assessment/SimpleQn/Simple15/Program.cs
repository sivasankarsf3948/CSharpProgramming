using System;
namespace StringQn16
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number ");
            int number=int.Parse(Console.ReadLine());
            int count=0;
            for(int i=2;i<number-1;i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
            if(count==0)
            {
                System.Console.WriteLine("The number is prime");
            }
            else{
                System.Console.WriteLine("The number is not prime");
            }
            
        }
    }
}
