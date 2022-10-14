using System;
namespace WhileloopQuestion5
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number ");
            int number=int.Parse(Console.ReadLine());
            int sum=0;
            

            //sum of digits
            while(number>0)
            {
                int reminder=number%10;
                sum=sum+reminder;
                number=number/10;
                
            }
            System.Console.WriteLine("Sum of their digits are{0}",sum);
            
        }
    }
}
