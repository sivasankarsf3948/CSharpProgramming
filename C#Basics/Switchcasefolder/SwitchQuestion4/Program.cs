using System;
namespace SwitchCaseQuestion3
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter first number");
            int number1=int.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter second number");
            int number2=int.Parse(Console.ReadLine());            
            System.Console.WriteLine("Enter the options :\n1-Addition\n2Subtraction\n3-Multiplication\n4-Division");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    int add=number1+number2;
                    System.Console.WriteLine("result is   :  "+add);
                    break;
                }
                  case 2:
                {
                    int sub=number1-number2;
                    System.Console.WriteLine("result is   :  "+sub);
                    break;
                }
                  case 3:
                {
                    int mul=number1*number2;
                    System.Console.WriteLine("result is   :  "+mul);
                    break;
                }
                  case 4:
                {
                    int div=number1/number2;
                    System.Console.WriteLine("result is   :  "+div);
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Enter a valid input");
                    break;
                }
            }
            
        }
    }
}
