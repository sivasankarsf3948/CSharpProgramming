using System;
namespace MethodsPractice
{
    class Program{
        public static void Main(string[] args)
        {
            int number1,number2;
            string condition="";
           do{

            System.Console.WriteLine("Enter the options to perform \n1. Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                System.Console.WriteLine("Enter the two numbers");
                number1=int.Parse(Console.ReadLine());
                
                number2=int.Parse(Console.ReadLine());
                int addition=Addition(number1,number2);
                System.Console.WriteLine("Added value is :"+addition);
                break;

                case 2:
                System.Console.WriteLine("Enter the two numbers");
                number1=int.Parse(Console.ReadLine());
                number2=int.Parse(Console.ReadLine());
                int subtraction=Subtraction(number1,number2);
                System.Console.WriteLine("Subtracted value is :"+subtraction);
                break;

                case 3:
                System.Console.WriteLine("Enter the two numbers");
                number1=int.Parse(Console.ReadLine());
                number2=int.Parse(Console.ReadLine());
                int multiplication=Multiplication(number1,number2);
                System.Console.WriteLine("Multiplicated value is :"+multiplication);
                break;

                case 4:
                System.Console.WriteLine("Enter the two numbers");
                number1=int.Parse(Console.ReadLine());
                number2=int.Parse(Console.ReadLine());
                int division=Division(number1,number2);
                System.Console.WriteLine("Divided value is :"+division);
                break;

                default:
                {
                    System.Console.WriteLine("Invalid input . Enter a valid input");
                    break;
                }
            }
            System.Console.WriteLine("Do you want to continue with another time.\nIf need Enter 'yes' Otherwise Enter any key to exit");
            condition=Console.ReadLine().ToLower();
            }while(condition=="yes");
            
            //Addition method
            int Addition(int data1,int data2)
            {
                int sum=data1+data2;
                return sum;
            }

            //Subtraction method
            int Subtraction(int data1,int data2)
            {
                int sub=data1-data2;
                return sub;
            }

            //Multiplication method
            int Multiplication(int data1,int data2)
            {
                int mul=data1*data2;
                return mul;
            }

            //Division method
            int Division(int data1,int data2)
            {
                int div=data1/data2;
                return div;
            }
            
            
            
           

        }
    }
}
