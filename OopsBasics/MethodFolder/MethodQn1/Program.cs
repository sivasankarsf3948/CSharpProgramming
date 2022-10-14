using System;
namespace MethodQn1
{
    class Program{
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter first number");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter second number");
            int number2=int.Parse(Console.ReadLine());
            Addition(number1,number2);
            Subtraction(number1,number2);
            Multiplication(number1,number2);
            Division(number1,number2);



            //Addition method
            void Addition(int data1,int data2)
            {
                int sum=data1+data2;
                System.Console.WriteLine("Added value is            :  "+sum);
                
            }
            // Subtracted method
            void Subtraction(int data1,int data2)
            {
                int subtract=data1-data2;
                System.Console.WriteLine("Subtracted value is       :  "+subtract);
                
            }
            //Multiplication method
            void Multiplication(int data1,int data2)
            {
                int multiplication=data1*data2;
                System.Console.WriteLine("Multiplicated value is    :  "+multiplication);
                
            }
            //DivisionMethod
            void Division(int data1,int data2)
            {
                int division=data1/data2;
                System.Console.WriteLine("Divided value is          :  "+division);
                
            }
            
        }
    }
}
