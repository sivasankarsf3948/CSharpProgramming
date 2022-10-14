using System;
namespace SwitchStatement
{
    class Program
    {
        public static void Main(string[] args)
        {
           int number1,number2;
           System.Console.WriteLine("Enter first  number "); 
           int.TryParse(Console.ReadLine(),out number1);
           System.Console.WriteLine("Enter second  number "); 
           int.TryParse(Console.ReadLine(),out number2);
           System.Console.WriteLine("Enter the operation choice :\n + - Addition\n - Subtraction \n * -multiplication \n / -division\n %modulo division ");
           char choice=char.Parse(Console.ReadLine());
           switch(choice)
           {
            case '+':
            {
                int result=number1+number2;
                System.Console.WriteLine($"Result is {result}");
                break;
            }
            case '-':
            {
                int result=number1-number2;
                System.Console.WriteLine($"Result is {result}");
                break;
            }
             case '*':
            {
                int result=number1*number2;
                System.Console.WriteLine($"Result is {result}");
                break;
            }
             case '/':
            {
                int result=number1/number2;
                System.Console.WriteLine($"Result is {result}");
                break;
            }
             case '%':
            {
                int result=number1%number2;
                System.Console.WriteLine($"Result is {result}");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid input");
                break;
            }

           }
           
        }
    }
}