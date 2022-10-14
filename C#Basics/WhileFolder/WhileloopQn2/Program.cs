using System;
namespace WhileloopQn2;
class Program
{
    public static void Main(string[] args)
    {
        int count,sum=0;
        System.Console.WriteLine("Enter a count");
        int.TryParse(Console.ReadLine(),out count);
        int number=1;
        while(number<=count)
        {
          sum=sum+number*number;
          number++;
        }
        System.Console.WriteLine("Result is {0}",sum);
        
        
    }
}
