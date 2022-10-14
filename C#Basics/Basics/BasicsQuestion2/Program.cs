using System;
namespace BasicQn2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First number;");
            int number1,number2;
            bool temp=int.TryParse(Console.ReadLine(),out number1);
            Console.WriteLine("Enter second number");
            int.TryParse(Console.ReadLine(),out number2);
            Console.WriteLine($"{number1} + {number2} = {number1+number2}");
            Console.WriteLine($"{number1} - {number2} = {number1-number2}");
            Console.WriteLine($"{number1} * {number2} = {number1*number2}");
            Console.WriteLine($"{number1} / {number2} = {number1/number2}");
            Console.WriteLine($"{number1} % {number2} = {number1%number2}");


        }
    }
}
