using System;
namespace MethodQn3
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter first number");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter second number");
            int number2=int.Parse(Console.ReadLine());
            Swap();

            //swapping
            void Swap()
            {
                int temp;
                temp=number1;
                number1=number2;
                number2=temp;
                System.Console.WriteLine($"Now the First number is {number1}\nSecond number is {number2}");

            }
           
        }
    }
}
