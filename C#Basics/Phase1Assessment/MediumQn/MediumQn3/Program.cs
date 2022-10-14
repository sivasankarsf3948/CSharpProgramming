using System;
namespace MediumQn3
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number ");
            int number=int.Parse(Console.ReadLine());
            int temp=number,reminder,sum=0;
            while(number>0)
            {
               reminder=number%10;
               sum=sum*10+reminder;
               number=number/10;
            }
            if(temp==sum)
            {
                System.Console.WriteLine("The number is Palindrome");
            }
            else{
                System.Console.WriteLine("The number is not a palindrome");
            }
        }
    }
}
