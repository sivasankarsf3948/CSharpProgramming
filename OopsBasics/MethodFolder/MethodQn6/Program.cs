using System;
namespace MethodQn6
{
    class Program{
      public static void Main(string[] args)
      {
        System.Console.WriteLine("Enter a number");
        int number=int.Parse(Console.ReadLine());
        int result=Factorial(number);
        System.Console.WriteLine("The factorial is"+result);

        int Factorial(int number)
        {
            
            int number1=number;
            if(number1==1)
            return 1;
            return number1*(Factorial(number1-1));
        }
        
      }
    }
}
