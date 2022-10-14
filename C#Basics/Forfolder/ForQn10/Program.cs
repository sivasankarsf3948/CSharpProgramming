using System;
namespace ForQn10
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number=int.Parse(Console.ReadLine());
            int count=0;
            for(int i=2;i<number;i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
            string result=count==0 ?"The number is prime":"The number is not prime";
            System.Console.WriteLine(result);
            
        }
    }
}
