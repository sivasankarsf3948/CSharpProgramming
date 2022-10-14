using System;
namespace BasicQuestion7
{
    class Program
    {
     public static void Main(string[] args)
     {
       System.Console.WriteLine("Enter first number ");
       int number1=int.Parse(Console.ReadLine());
       System.Console.WriteLine("Enter second number ");
       int number2=int.Parse(Console.ReadLine());
       System.Console.WriteLine($"The output is  {(number1*number1)+(number2*number2)+2*number1*number2} ");
       
     }
    }
}
