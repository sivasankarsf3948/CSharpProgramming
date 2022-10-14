using System;
namespace ByNumberOfArg
{
    class Program 
    {
        //method with one parameter
        static void Display(int number)
        {
            System.Console.WriteLine("Arguments :"+number);
        }
        //method with two parameter

         static void Display(int number,int number1)
        {
            System.Console.WriteLine("Arguments :"+number+" and "+number1);
        }
        public static void Main(string[] args)
        {
            Display(100);
            Display(100,200);
            Console.ReadLine();
            
        }
    }
}
